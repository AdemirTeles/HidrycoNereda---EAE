/*
 * Hidryco - UV_Trojan - fpDetalhes
 * UV: falhas ativas decodificadas (sistema, bancos 1A/2A, limpeza) - tabela CP141200010 p.606-611.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UV_Trojan
{
	public partial class fpDetalhes : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDetalhes()
		{
			InitializeComponent();
			Atualiza();
		}
		// ---- dados recebidos da logica (Execute invisiveis)
		short w1003, w1004, c1w33, c1w34, c2w33, c2w34, l83, l85, l86, l89, l90;
		bool fCom;
		void XSYS3ValueChanged(object s, ValueChangedEventArgs e) { w1003 = Convert.ToInt16(e.Value); Atualiza(); }
		void XSYS4ValueChanged(object s, ValueChangedEventArgs e) { w1004 = Convert.ToInt16(e.Value); Atualiza(); }
		void XC1W33ValueChanged(object s, ValueChangedEventArgs e) { c1w33 = Convert.ToInt16(e.Value); Atualiza(); }
		void XC1W34ValueChanged(object s, ValueChangedEventArgs e) { c1w34 = Convert.ToInt16(e.Value); Atualiza(); }
		void XC2W33ValueChanged(object s, ValueChangedEventArgs e) { c2w33 = Convert.ToInt16(e.Value); Atualiza(); }
		void XC2W34ValueChanged(object s, ValueChangedEventArgs e) { c2w34 = Convert.ToInt16(e.Value); Atualiza(); }
		void XL83ValueChanged(object s, ValueChangedEventArgs e) { l83 = Convert.ToInt16(e.Value); Atualiza(); }
		void XL85ValueChanged(object s, ValueChangedEventArgs e) { l85 = Convert.ToInt16(e.Value); Atualiza(); }
		void XL86ValueChanged(object s, ValueChangedEventArgs e) { l86 = Convert.ToInt16(e.Value); Atualiza(); }
		void XL89ValueChanged(object s, ValueChangedEventArgs e) { l89 = Convert.ToInt16(e.Value); Atualiza(); }
		void XL90ValueChanged(object s, ValueChangedEventArgs e) { l90 = Convert.ToInt16(e.Value); Atualiza(); }
		void XFCOMValueChanged(object s, ValueChangedEventArgs e) { fCom = Convert.ToBoolean(e.Value); Atualiza(); }

		static string Lista(short w, int[] bits, string[] txt)
		{
			string s = "";
			for (int i = 0; i < bits.Length; i++)
				if (((ushort)w & (1 << bits[i])) != 0) s += (s.Length > 0 ? "\n" : "") + txt[i];
			return s;
		}
		static string Junta(string a, string b) { return a.Length == 0 ? (b.Length == 0 ? "nenhuma" : b) : (b.Length == 0 ? a : a + "\n" + b); }
		static readonly int[] B1003 = { 0, 1, 2, 3, 4, 5, 6, 7, 9, 10, 12 };
		static readonly string[] T1003 = { "Dose abaixo do alvo", "Canais saudáveis insuficientes", "Sinal de UVT fora da faixa", "UVT abaixo da validação",
			"Sinal de vazão fora da faixa", "Vazão acima da validação", "Vazão baixa", "Falha do controlador SCC", "Dose muito baixa", "UVT muito baixa", "Resposta NWRI" };
		static readonly int[] B1004 = { 1, 2, 4, 6, 7, 8, 9, 10, 11, 12 };
		static readonly string[] T1004 = { "SCC reiniciado (energia)", "Falha do protetor de surto", "SCC sem heartbeat do CLP", "UVT abaixo do projeto", "UVT baixa",
			"UVT em override", "UVT acima da validação", "Vazão em override", "Vazão abaixo da validação", "Modo inverno" };
		static readonly int[] BW33 = { 0, 1, 2, 3, 4, 5, 6, 7 };
		static readonly string[] TW33 = { "Falha de comunicação de módulo", "Falha de lâmpada adjacente (maior)", "NÍVEL DE ÁGUA BAIXO", "Intensidade UV muito baixa",
			"Falha de comunicação do PDC", "Falha de múltiplas lâmpadas", "Perda de alimentação", "Módulo desabilitado (maior)" };
		static readonly int[] BW34 = { 1, 2, 3, 4, 5, 6, 7, 8, 11, 12 };
		static readonly string[] TW34 = { "Fora de remoto automático", "Nível de água em bypass", "Banco reiniciado (energia)", "Módulo desabilitado (menor)",
			"Falha de lâmpada adjacente (menor)", "Falha de lâmpada", "Fim de vida de lâmpada", "Falha de reator (driver)", "Sensor UV em curto", "Intensidade UV baixa" };
		static readonly int[] B83 = { 0, 1, 2, 3, 4, 5 };
		static readonly string[] T83 = { "Falha de comunicação do HSC", "Nível de fluido baixo", "Falha do motor", "Pressão alta", "HSC reiniciado (energia)", "Grupo de limpeza desabilitado" };
		static readonly int[] BG = { 0, 1, 2, 8 };
		static readonly string[] TG = { "nível de fluido baixo", "falha do motor", "pressão alta", "fora de remoto" };
		static readonly int[] BGS = { 0, 1, 4 };
		static readonly string[] TGS = { "alarme maior", "alarme menor", "limpeza remota inibida" };
		static string Grupo(int n, short st, short fa)
		{
			string a = Lista(st, BGS, TGS), b = Lista(fa, BG, TG);
			string s = Junta(a, b);
			return s == "nenhuma" ? "" : "Grupo " + n.ToString() + ": " + s.Replace("\n", ", ");
		}

		void Atualiza()
		{
			if (fCom) { tSisv.Text = "SEM COMUNICAÇÃO"; tB1v.Text = ""; tB2v.Text = ""; tLimv.Text = ""; return; }
			tSisv.Text = Junta(Lista(w1003, B1003, T1003), Lista(w1004, B1004, T1004));
			tB1v.Text = Junta(Lista(c1w33, BW33, TW33), Lista(c1w34, BW34, TW34));
			tB2v.Text = Junta(Lista(c2w33, BW33, TW33), Lista(c2w34, BW34, TW34));
			string g1 = Grupo(1, l85, l86), g2 = Grupo(2, l89, l90);
			tLimv.Text = Junta(Lista(l83, B83, T83), g1 + (g1.Length > 0 && g2.Length > 0 ? "\n" : "") + g2);
		}

	}
}
