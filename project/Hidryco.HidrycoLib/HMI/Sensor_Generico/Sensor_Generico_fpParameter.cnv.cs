/*
 * Hidryco - Sensor_Generico - fpParameter
 * ISA-101: ajustes do sensor (habilitacao, escala, altura maxima) e diagnostico do sinal.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	public partial class fpParameter : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpParameter()
		{
			InitializeComponent();
			LigaReplica();
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


		// Valor por comunicacao ja chega em unidade de engenharia: a faixa vira so a escala do indicador analogico
		bool com, skid, alturaAcima;
		void ComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			com = Convert.ToBoolean(e.Value);
			Origem();
		}

		// Valor de skid (gradeamento, UCT, C-Press) ja vem escalado do equipamento: sem ajuste de escala;
		// a altura maxima sobe para o lugar da escala
		void SkidValueChanged(object sender, ValueChangedEventArgs e)
		{
			skid = Convert.ToBoolean(e.Value);
			Origem();
		}

		void Origem()
		{
			origem.Text = skid ? "Origem: skid (valor já escalado no equipamento)" : (com ? "Origem: comunicação (valor já em unidade de engenharia)" : "Origem: entrada 4-20 mA");
			lblMin.Text = com ? "Mínimo da escala" : "Valor em 4 mA";
			lblMax.Text = com ? "Máximo da escala" : "Valor em 20 mA";
			lblMin.Visible = !skid; rangeMin.Visible = !skid;
			lblMax.Visible = !skid; rangeMax.Visible = !skid;
			if (skid != alturaAcima)
			{
				int dy = skid ? -80 : 80;              // DesignMatrix/Location so valem na criacao: depois anda com Move
				lblAltura.Move(0, dy); altura.Move(0, dy);
				alturaAcima = skid;
			}
		}

		void NivelValueChanged(object sender, ValueChangedEventArgs e)
		{
			bool nivelOn = Convert.ToBoolean(e.Value);
			lblAltura.Visible = nivelOn; altura.Visible = nivelOn;
		}

		void UnidadeValueChanged(object sender, ValueChangedEventArgs e)
		{
			string u = Convert.ToString(e.Value);
			string suf = u != null && u.Length > 0 ? " " + u : "";
			rangeMin.Suffix = suf; rangeMax.Suffix = suf; altura.Suffix = suf;
		}

		// Diagnostico do proprio dispositivo (ex.: SC4500 por Modbus): erro = falha do sensor; aviso = so alarme
		void CodErroValueChanged(object sender, ValueChangedEventArgs e)
		{
			int cod = Convert.ToInt32(e.Value);
			Indicador(erroP1, erroP1n, erroP2, erroP2n, erroTxt, cod != 0 ? 1 : 0, "FALHA (código " + cod.ToString() + ")");
			erroNenhum.Visible = cod == 0;
		}

		void CodAvisoValueChanged(object sender, ValueChangedEventArgs e)
		{
			int cod = Convert.ToInt32(e.Value);
			Indicador(avisoP1, avisoP1n, avisoP2, avisoP2n, avisoTxt, cod != 0 ? 2 : 0, "AVISO (código " + cod.ToString() + ")");
			avisoNenhum.Visible = cod == 0;
		}

		void FalhaAtivaValueChanged(object sender, ValueChangedEventArgs e)
		{
			bool f = Convert.ToBoolean(e.Value);
			Indicador(sinalP1, sinalP1n, sinalP2, sinalP2n, sinalTxt, f ? 1 : 0, "EM FALHA");
			sinalBom.Visible = !f;
		}

		// ---- Replicacao dos ajustes: avisa a tela quando o operador grava faixa, altura, alarmes ou habilitacoes.
		// As telas ESTOCAGEM_LODO e VISAO_GERAL replicam o LIT-900-01/02 no AnalogInput do SludgeHoldingTank1/2 da Nereda.
		void LigaReplica()
		{
			foreach (System.HMI.Symbols.Base.TextBox<float> c in new System.HMI.Symbols.Base.TextBox<float>[] { rangeMin, rangeMax, altura, rSpHH, rSpH, rSpL, rSpLL })
				c.OutputValueChanged += Replica;
			foreach (System.HMI.Symbols.Base.CheckButton c in new System.HMI.Symbols.Base.CheckButton[] { rHabHH, rHabH, rHabL, rHabLL })
				c.OutputValueChanged += Replica;
			foreach (System.HMI.Symbols.Base.TextBox<ushort> c in new System.HMI.Symbols.Base.TextBox<ushort>[] { rTempoHH, rTempoH, rTempoL, rTempoLL })
				c.OutputValueChanged += Replica;
		}

		static float ValF(System.HMI.Symbols.Base.TextBox<float> c, object sender, ValueChangedEventArgs e)
		{
			return object.ReferenceEquals(c, sender) ? Convert.ToSingle(e.Value) : Convert.ToSingle(c.Value);
		}

		static bool ValB(System.HMI.Symbols.Base.CheckButton c, object sender, ValueChangedEventArgs e)
		{
			return object.ReferenceEquals(c, sender) ? Convert.ToBoolean(e.Value) : Convert.ToBoolean(c.Value);
		}

		static ushort ValU(System.HMI.Symbols.Base.TextBox<ushort> c, object sender, ValueChangedEventArgs e)
		{
			return object.ReferenceEquals(c, sender) ? Convert.ToUInt16(e.Value) : Convert.ToUInt16(c.Value);
		}

		void Replica(object sender, ValueChangedEventArgs e)
		{
			Hidryco.HidrycoLib.SupportClasses.AjustesSensor a = new Hidryco.HidrycoLib.SupportClasses.AjustesSensor();
			a.Tag = TagName;
			a.RangeMin = ValF(rangeMin, sender, e);
			a.RangeMax = ValF(rangeMax, sender, e);
			a.Altura = ValF(altura, sender, e);
			a.Nivel = Convert.ToBoolean(xNivel.Value);
			a.Hab[0] = ValB(rHabHH, sender, e); a.Hab[1] = ValB(rHabH, sender, e); a.Hab[2] = ValB(rHabL, sender, e); a.Hab[3] = ValB(rHabLL, sender, e);
			a.Sp[0] = ValF(rSpHH, sender, e); a.Sp[1] = ValF(rSpH, sender, e); a.Sp[2] = ValF(rSpL, sender, e); a.Sp[3] = ValF(rSpLL, sender, e);
			a.Tempo[0] = ValU(rTempoHH, sender, e); a.Tempo[1] = ValU(rTempoH, sender, e); a.Tempo[2] = ValU(rTempoL, sender, e); a.Tempo[3] = ValU(rTempoLL, sender, e);
			Hidryco.HidrycoLib.SupportClasses.ReplicaSensor.Publicar(a);
		}
	}
}
