/*
 * Hidryco - Sensor_Generico - fpDefault
 * ISA-101: valor, estado em texto, indicador de alarme, indicador analogico com limites, tabela de alarmes, reset e navegacao.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDefault()
		{
			InitializeComponent();
			Atualiza();
		}

		// Indicador de alarme (ISA-101): forma + numero de prioridade + texto; escondido quando normal.
		// naoRec = alarme ainda nao reconhecido: a forma pisca (fase do temporizador), o texto fica fixo.
		bool fase = true;
		void Indicador(Rectangle p1, FreeText p1n, Polygon p2, FreeText p2n, FreeText txt, int prioridade, string texto, bool naoRec = false)
		{
			bool mostra = !naoRec || fase;
			p1.Visible = prioridade == 1 && mostra; p1n.Visible = prioridade == 1 && mostra;
			p2.Visible = prioridade == 2 && mostra; p2n.Visible = prioridade == 2 && mostra;
			txt.Visible = prioridade > 0;
			txt.Text = texto;
		}

		// Estado do ALARM_BIT (STATE_1): 2 = ativo nao reconhecido, 3 = saiu nao reconhecido, 4 = ativo e saiu nao reconhecido
		static bool NaoRec(byte estadoAlarme) { return estadoAlarme >= 2 && estadoAlarme <= 4; }

		System.Timers.Timer tPisca;

		// Liga o pisca (500 ms) enquanto houver alarme nao reconhecido; desliga e deixa a forma fixa quando nao houver
		void Pisca(bool precisa)
		{
			if (precisa && tPisca == null)
			{
				tPisca = new System.Timers.Timer();
				tPisca.Interval = 500D;
				tPisca.Elapsed += new System.Timers.ElapsedEventHandler(TPiscaElapsed);
				tPisca.Start();
			}
			else if (!precisa && tPisca != null)
			{
				tPisca.Stop();
				tPisca.Dispose();
				tPisca = null;
				fase = true;
			}
		}

		// O temporizador roda em outra thread: a troca de fase vai para a thread da IHM
		void TPiscaElapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			NxtControl.Services.IHMIMainThreadService svc = NxtControl.Services.ServiceProvider.GetService(typeof(NxtControl.Services.IHMIMainThreadService)) as NxtControl.Services.IHMIMainThreadService;
			if (svc != null) svc.SafeThreadAsyncCall(new Action(AlternaFase));
		}

		void AlternaFase()
		{
			if (tPisca == null) return;
			fase = !fase;
			Atualiza();
		}

		protected override void Dispose(bool disposing)
		{
			if (disposing && tPisca != null)
			{
				tPisca.Stop();
				tPisca.Dispose();
				tPisca = null;
			}
			base.Dispose(disposing);
		}

		// ---- dados recebidos da logica e da IHM (atualizados pelos Execute invisiveis)
		short estado = 4;
		bool falha, falhaAtiva, falhaCom, alHH, alH, alL, alLL, bHabHH, bHabH, bHabL, bHabLL;
		float pv, rMin, rMax = 100F, fHH, fH, fL, fLL, fAltura;
		string unidade = "";
		uint casas = 2;

		void EstadoValueChanged(object sender, ValueChangedEventArgs e) { estado = Convert.ToInt16(e.Value); Atualiza(); }
		void FalhaValueChanged(object sender, ValueChangedEventArgs e) { falha = Convert.ToBoolean(e.Value); Atualiza(); }
		void FalhaAtivaValueChanged(object sender, ValueChangedEventArgs e) { falhaAtiva = Convert.ToBoolean(e.Value); Atualiza(); }
		void FalhaComValueChanged(object sender, ValueChangedEventArgs e) { falhaCom = Convert.ToBoolean(e.Value); Atualiza(); }
		void AlHHValueChanged(object sender, ValueChangedEventArgs e) { alHH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AlHValueChanged(object sender, ValueChangedEventArgs e) { alH = Convert.ToBoolean(e.Value); Atualiza(); }
		void AlLValueChanged(object sender, ValueChangedEventArgs e) { alL = Convert.ToBoolean(e.Value); Atualiza(); }
		void AlLLValueChanged(object sender, ValueChangedEventArgs e) { alLL = Convert.ToBoolean(e.Value); Atualiza(); }
		void HabHHValueChanged(object sender, ValueChangedEventArgs e) { bHabHH = Convert.ToBoolean(e.Value); Atualiza(); }
		void HabHValueChanged(object sender, ValueChangedEventArgs e) { bHabH = Convert.ToBoolean(e.Value); Atualiza(); }
		void HabLValueChanged(object sender, ValueChangedEventArgs e) { bHabL = Convert.ToBoolean(e.Value); Atualiza(); }
		void HabLLValueChanged(object sender, ValueChangedEventArgs e) { bHabLL = Convert.ToBoolean(e.Value); Atualiza(); }
		void SpHHValueChanged(object sender, ValueChangedEventArgs e) { fHH = Convert.ToSingle(e.Value); Atualiza(); }
		void SpHValueChanged(object sender, ValueChangedEventArgs e) { fH = Convert.ToSingle(e.Value); Atualiza(); }
		void SpLValueChanged(object sender, ValueChangedEventArgs e) { fL = Convert.ToSingle(e.Value); Atualiza(); }
		void SpLLValueChanged(object sender, ValueChangedEventArgs e) { fLL = Convert.ToSingle(e.Value); Atualiza(); }
		void RMinValueChanged(object sender, ValueChangedEventArgs e) { rMin = Convert.ToSingle(e.Value); Atualiza(); }
		void RMaxValueChanged(object sender, ValueChangedEventArgs e) { rMax = Convert.ToSingle(e.Value); Atualiza(); }
		void AlturaValueChanged(object sender, ValueChangedEventArgs e) { fAltura = Convert.ToSingle(e.Value); Atualiza(); }
		void ValorValueChanged(object sender, ValueChangedEventArgs e) { pv = Convert.ToSingle(e.Value); Atualiza(); }
		void UnidadeValueChanged(object sender, ValueChangedEventArgs e) { unidade = Convert.ToString(e.Value); Atualiza(); }
		void CasasValueChanged(object sender, ValueChangedEventArgs e) { casas = Convert.ToUInt32(e.Value); Atualiza(); }

		// estado de reconhecimento de cada ALARM_BIT (STATE_1)
		byte eHH, eH, eL, eLL, eFalha;
		void EHHValueChanged(object sender, ValueChangedEventArgs e) { eHH = Convert.ToByte(e.Value); Atualiza(); }
		void EHValueChanged(object sender, ValueChangedEventArgs e) { eH = Convert.ToByte(e.Value); Atualiza(); }
		void ELValueChanged(object sender, ValueChangedEventArgs e) { eL = Convert.ToByte(e.Value); Atualiza(); }
		void ELLValueChanged(object sender, ValueChangedEventArgs e) { eLL = Convert.ToByte(e.Value); Atualiza(); }
		void EFalhaValueChanged(object sender, ValueChangedEventArgs e) { eFalha = Convert.ToByte(e.Value); Atualiza(); }

		// alarme mostrado ainda nao reconhecido (pelo texto devolvido por Prioridade)
		bool NaoRecDe(string t)
		{
			if (t == "FALHA") return NaoRec(eFalha);
			if (t == "HH") return NaoRec(eHH);
			if (t == "H") return NaoRec(eH);
			if (t == "L") return NaoRec(eL);
			if (t == "LL") return NaoRec(eLL);
			return false;
		}
		bool AlgumNaoRec() { return NaoRec(eHH) || NaoRec(eH) || NaoRec(eL) || NaoRec(eLL) || NaoRec(eFalha); }

		string Sufixo() { return unidade != null && unidade.Length > 0 ? " " + unidade : ""; }

		// Alarme de maior prioridade: falha e HH/LL = prioridade 1 (classe Alarm), H/L = prioridade 2 (Warning)
		int Prioridade(out string texto)
		{
			if (estado == 4) { texto = ""; return 0; }
			if (falha || falhaAtiva) { texto = "FALHA"; return 1; }   // o alarme de falha (AlarmeFalha) vale para sensor ou comunicacao
			if (alHH) { texto = "HH"; return 1; }
			if (alLL) { texto = "LL"; return 1; }
			if (alH) { texto = "H"; return 2; }
			if (alL) { texto = "L"; return 2; }
			texto = ""; return 0;
		}

		// Valor invalido nunca aparece como numero: '????' em falha, 'DESAB.' desabilitado
		void Valor(System.HMI.Symbols.Base.Label<float> lbl, FreeText invalido)
		{
			bool ok = estado != 4 && !falhaAtiva;
			lbl.Visible = ok;
			invalido.Visible = !ok;
			invalido.Text = estado == 4 ? "DESAB." : "????";
			lbl.Suffix = Sufixo();
			lbl.DecimalPlacesCount = casas;
		}

		const float MAI_X = 20F, MAI_Y = 98F, MAI_W = 340F, MAI_H = 14F;

		// Indicador analogico de faixa (ISA-101): zonas em cinza (normal claro, alerta medio, alarme escuro) e ponteiro preto
		float Pos(float v)
		{
			// sensor de nivel: alarmes e ponteiro em % (0 a 100); os demais na faixa de engenharia
			float a = nivelOn ? 0F : Math.Min(rMin, rMax), b = nivelOn ? 100F : Math.Max(rMin, rMax);
			if (b <= a) return MAI_X;
			float f = (v - a) / (b - a);
			if (f < 0F) f = 0F;
			if (f > 1F) f = 1F;
			return MAI_X + f * MAI_W;
		}

		void Zona(Rectangle r, float x1, float x2)
		{
			r.Bounds = new NxtControl.Drawing.RectF(x1, MAI_Y, Math.Max(x2 - x1, 0.01F), MAI_H);
		}

		bool skid;
		void SkidValueChanged(object sender, ValueChangedEventArgs e) { skid = Convert.ToBoolean(e.Value); btnParametros.Visible = !skid; Atualiza(); }   // skid: sem ajustes

		void AtualizaMai()
		{
			float x0 = MAI_X, x5 = MAI_X + MAI_W;
			float xLL = bHabLL ? Pos(fLL) : x0;
			float xL = bHabL ? Math.Max(Pos(fL), xLL) : xLL;
			float xHH = bHabHH ? Pos(fHH) : x5;
			float xH = bHabH ? Math.Min(Pos(fH), xHH) : xHH;
			if (xH < xL) xH = xL;
			Zona(maiLL, x0, xLL); Zona(maiL, xLL, xL); Zona(maiN, xL, xH); Zona(maiH, xH, xHH); Zona(maiHH, xHH, x5);
			bool ok = estado != 4 && !falhaAtiva;
			// valor de skid (ja escalado no equipamento): sem indicador de faixa nem escala
			maiLL.Visible = !skid; maiL.Visible = !skid; maiN.Visible = !skid; maiH.Visible = !skid; maiHH.Visible = !skid;
			escalaMin.Visible = !skid; escalaMax.Visible = !skid;
			maiPonteiro.Visible = ok && !skid;
			maiPonteiro.Location = new NxtControl.Drawing.PointF(Pos(nivelOn ? pct : pv) - 5F, MAI_Y + MAI_H);
		}


		bool nivelOn;
		float pct;
		void PctValueChanged(object sender, ValueChangedEventArgs e) { pct = Convert.ToSingle(e.Value); Atualiza(); }
		void NivelValueChanged(object sender, ValueChangedEventArgs e) { nivelOn = Convert.ToBoolean(e.Value); Atualiza(); }

		void Linha(Rectangle p1, FreeText p1n, Polygon p2, FreeText p2n, FreeText txt, FreeText normal, bool ativo, int prioridade, string texto, bool naoRec)
		{
			Indicador(p1, p1n, p2, p2n, txt, ativo ? prioridade : 0, texto, naoRec);
			normal.Visible = !ativo;
		}

		void Atualiza()
		{
			string t; int p = Prioridade(out t);
			Indicador(alP1, alP1n, alP2, alP2n, alTxt, p, t == "FALHA" ? (falhaCom ? "SEM COMUNICAÇÃO" : "FALHA DO SENSOR") : (t.Length > 0 ? "ALARME " + t : ""), NaoRecDe(t));
			Pisca(AlgumNaoRec());
			Valor(valor, invalido);
			textoEstado.Text = estado == 4 ? "Sensor desabilitado" : (falha || falhaAtiva ? (falhaCom ? "Sensor sem comunicação" : "Sensor em falha") : (p == 0 ? "Normal" : "Em alarme"));
			bool ok = estado != 4 && !falhaAtiva;
			tituloNivel.Visible = nivelOn; porcentagem.Visible = nivelOn && ok;
			string suf = nivelOn ? " %" : Sufixo();   // sensor de nivel: setpoints de alarme em %
			spHH.Suffix = suf; spH.Suffix = suf; spL.Suffix = suf; spLL.Suffix = suf;
			spHH.DecimalPlacesCount = casas; spH.DecimalPlacesCount = casas; spL.DecimalPlacesCount = casas; spLL.DecimalPlacesCount = casas;
			escalaMin.DecimalPlacesCount = casas; escalaMax.DecimalPlacesCount = casas;
			Linha(estHHP1, estHHP1n, estHHP2, estHHP2n, estHHTxt, normalHH, estado != 4 && alHH, 1, "ATIVO", NaoRec(eHH));
			Linha(estHP1, estHP1n, estHP2, estHP2n, estHTxt, normalH, estado != 4 && alH, 2, "ATIVO", NaoRec(eH));
			Linha(estLP1, estLP1n, estLP2, estLP2n, estLTxt, normalL, estado != 4 && alL, 2, "ATIVO", NaoRec(eL));
			Linha(estLLP1, estLLP1n, estLLP2, estLLP2n, estLLTxt, normalLL, estado != 4 && alLL, 1, "ATIVO", NaoRec(eLL));
			Linha(estFalhaP1, estFalhaP1n, estFalhaP2, estFalhaP2n, estFalhaTxt, normalFalha, estado != 4 && (falha || falhaAtiva), 1, "FALHA", NaoRec(eFalha));
			AtualizaMai();
		}

		// Reset da falha e dos alarmes (so libera o que ja normalizou)
		void BtnResetClick(object sender, EventArgs e)
		{
			FireEvent_E_RESET(true);
			FireEvent_E_RESET(false);
		}

	}
}
