/*
 * Hidryco - tela HARDWARE: CLPs e comunicacao com as remotas, com diagnostico por coluna.
 * O diagnostico cruza o que cada CLP ve de cada remota (varias remotas sao lidas por dois CLPs) com os paineis da planta:
 *   painel Nereda = CLP Nereda + .160 + .161 | painel Subestacao = CLP Subestacao + .192 + .193
 *   painel PCE Lodo = CLP Lodo + .135 + .136 | paineis proprios: EEE Bruto (.197) e Desinfeccao (.137)
 * Estados do simbolo Status_Remota: 0 aguardando, 1 comunicando, 2 sem comunicacao, 3 sem dados do CLP.
 */

using System;
using System.Collections.Generic;
using NxtControl.GuiFramework;
using SR = Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault;


namespace HMI.Main.Canvases
{
	/// <summary>
	/// Description of HARDWARE.
	/// </summary>
	public partial class HARDWARE : NxtControl.GuiFramework.HMICanvas
	{
		class Leitura { public string Clp; public SR Sr; }
		class Remota { public string Nome; public string Ip; public string Painel; public List<Leitura> Leituras = new List<Leitura>(); }

		readonly List<Remota> remotas = new List<Remota>();
		readonly Dictionary<string, string> nomeClp = new Dictionary<string, string>();
		readonly Dictionary<string, string> painelClp = new Dictionary<string, string>();

		public HARDWARE()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();

			nomeClp["NER"] = "Nereda"; painelClp["NER"] = "Nereda";
			nomeClp["SUB"] = "Subestação"; painelClp["SUB"] = "Subestação";
			nomeClp["LODO"] = "Lodo"; painelClp["LODO"] = "PCE Lodo";

			Rem("Remota 1 Nereda", "10.26.208.160", "Nereda", "NER", srNER0, "SUB", srSUB2);
			Rem("Remota 2 Nereda", "10.26.208.161", "Nereda", "NER", srNER1, "SUB", srSUB3);
			Rem("Remota 1 Subestação", "10.26.208.192", "Subestação", "NER", srNER2, "SUB", srSUB0);
			Rem("Remota 2 Subestação", "10.26.208.193", "Subestação", "SUB", srSUB1);
			Rem("Remota EEE Bruto", "10.26.208.197", "EEE Bruto", "SUB", srSUB4, "SUB", srSUB5);
			Rem("Remota Desinfecção", "10.26.208.137", "Desinfecção", "SUB", srSUB6, "LODO", srLODO2);
			Rem("Remota 1 PCE Lodo", "10.26.208.135", "PCE Lodo", "LODO", srLODO0);
			Rem("Remota 2 PCE Lodo", "10.26.208.136", "PCE Lodo", "NER", srNER3, "LODO", srLODO1);

			foreach (Remota r in remotas)
				foreach (Leitura l in r.Leituras)
					l.Sr.EstadoMudou += new EventHandler(EstadoMudou);
			Diagnostica();
		}

		void Rem(string nome, string ip, string painel, params object[] leituras)
		{
			Remota r = new Remota(); r.Nome = nome; r.Ip = ip; r.Painel = painel;
			for (int i = 0; i + 1 < leituras.Length; i += 2)
			{
				Leitura l = new Leitura(); l.Clp = (string)leituras[i]; l.Sr = (SR)leituras[i + 1];
				r.Leituras.Add(l);
			}
			remotas.Add(r);
		}

		void EstadoMudou(object sender, EventArgs e) { Diagnostica(); }

		// CLP com dados chegando na IHM: alguma leitura dele fora do estado 3 (sem dados)
		bool ClpComDados(string clp)
		{
			foreach (Remota r in remotas)
				foreach (Leitura l in r.Leituras)
					if (l.Clp == clp && l.Sr.Estado != 3) return true;
			return false;
		}

		// Como a remota esta, pelo que os CLPs com dados enxergam: 1 responde a algum, 2 nao responde a nenhum, 0 sem informacao
		int Situacao(Remota r)
		{
			bool algumaFora = false;
			foreach (Leitura l in r.Leituras)
			{
				if (l.Sr.Estado == 1) return 1;
				if (l.Sr.Estado == 2) algumaFora = true;
			}
			return algumaFora ? 2 : 0;
		}

		string Quem(Remota r, string exceto)
		{
			foreach (Leitura l in r.Leituras)
				if (l.Clp != exceto && l.Sr.Estado == 1) return nomeClp[l.Clp];
			return null;
		}

		// Todas as remotas do painel com informacao estao sem resposta (as sem informacao nao contam)
		bool PainelTodoFora(string painel)
		{
			int n = 0;
			foreach (Remota r in remotas)
			{
				if (r.Painel != painel) continue;
				int s = Situacao(r);
				if (s == 1) return false;
				if (s == 2) n++;
			}
			return n > 0;
		}

		string Diagnostico(string clp)
		{
			List<string> linhas = new List<string>();
			string painel = painelClp[clp];
			if (!ClpComDados("NER") && !ClpComDados("SUB") && !ClpComDados("LODO"))
				return "Nenhum CLP manda dados para a IHM: verificar a rede da própria IHM (cabo, switch) antes dos painéis.";
			if (!ClpComDados(clp))
			{
				bool algumaResponde = false;
				foreach (Remota r in remotas)
					if (r.Painel == painel && Situacao(r) == 1) algumaResponde = true;
				if (PainelTodoFora(painel))
					linhas.Add("Painel " + painel + " provavelmente desligado: CLP e remotas do painel sem resposta.");
				else if (algumaResponde)
					linhas.Add("CLP sem dados, mas o painel está energizado (remotas respondem a outro CLP): CLP parado, rede do CLP ou deploy.");
				else
					linhas.Add("CLP sem dados na IHM: desligado, parado ou sem rede. Nenhum outro CLP confirma a energia do painel " + painel + ".");
				return string.Join("\n", linhas.ToArray());
			}
			int minhas = 0, minhasFora = 0, aguardando = 0;
			bool outroAlcancaMinhasFora = false;
			List<string> paineisFora = new List<string>();
			List<string> semResposta = new List<string>();
			foreach (Remota r in remotas)
			{
				foreach (Leitura l in r.Leituras)
				{
					if (l.Clp != clp) continue;
					minhas++;
					if (l.Sr.Estado == 0) { aguardando++; continue; }
					if (l.Sr.Estado != 2) continue;
					minhasFora++;
					string quem = Quem(r, clp);
					if (quem != null)
					{
						outroAlcancaMinhasFora = true;
						Add(linhas, r.Nome + ": só responde ao CLP " + quem + ". Cabo/switch até este CLP ou limite de conexões do acoplador.");
					}
					else if (PainelTodoFora(r.Painel) && r.Painel != painel)
					{
						if (!paineisFora.Contains(r.Painel)) paineisFora.Add(r.Painel);
					}
					else if (!semResposta.Contains(r.Nome))
						semResposta.Add(r.Nome);
				}
			}
			// CLP nao alcanca nenhuma das suas remotas, mas outro CLP alcanca alguma: a causa e o proprio CLP/rede do painel
			if (minhas > 1 && minhasFora == minhas && outroAlcancaMinhasFora)
				return "Este CLP não alcança nenhuma remota (outro CLP alcança): verificar a porta ETH2 do CLP e o switch do painel " + painel + ".";
			if (semResposta.Count > 0)
				Add(linhas, string.Join(", ", semResposta.ToArray()) + (semResposta.Count > 1 ? ": não respondem" : ": não responde") + " a nenhum CLP. Verificar 24 Vcc, cabo de rede e acoplador.");
			if (paineisFora.Count > 0)
				Add(linhas, (paineisFora.Count > 1 ? "Painéis " : "Painel ") + string.Join(" e ", paineisFora.ToArray()) + ": nenhuma remota responde. Provável falta de energia no painel ou no switch.");
			if (linhas.Count == 0)
				linhas.Add(aguardando > 0 ? "Aguardando a primeira leitura das remotas." : "Todas as remotas comunicando com este CLP.");
			return string.Join("\n", linhas.ToArray());
		}

		static void Add(List<string> l, string s) { if (!l.Contains(s)) l.Add(s); }

		static readonly NxtControl.Drawing.Color TXT_OK = new NxtControl.Drawing.Color(0, 110, 50);
		static readonly NxtControl.Drawing.Color TXT_FALHA = new NxtControl.Drawing.Color(170, 30, 30);

		void Diagnostica()
		{
			Mostra(dgXNER, Diagnostico("NER"));
			Mostra(dgXSUB, Diagnostico("SUB"));
			Mostra(dgXLODO, Diagnostico("LODO"));
		}

		static void Mostra(NxtControl.GuiFramework.Rectangle r, string texto)
		{
			r.Text = texto;
			bool ok = texto.StartsWith("Todas") || texto.StartsWith("Aguardando");
			r.TextColor = ok ? TXT_OK : TXT_FALHA;
		}
	}
}
