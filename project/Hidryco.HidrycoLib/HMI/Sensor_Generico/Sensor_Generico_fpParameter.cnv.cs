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
		void ComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			bool com = Convert.ToBoolean(e.Value);
			origem.Text = com ? "Origem: comunicação (valor já em unidade de engenharia)" : "Origem: entrada 4-20 mA";
			lblMin.Text = com ? "Mínimo da escala" : "Valor em 4 mA";
			lblMax.Text = com ? "Máximo da escala" : "Valor em 20 mA";
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

		void FalhaAtivaValueChanged(object sender, ValueChangedEventArgs e)
		{
			bool f = Convert.ToBoolean(e.Value);
			Indicador(sinalP1, sinalP1n, sinalP2, sinalP2n, sinalTxt, f ? 1 : 0, "EM FALHA");
			sinalBom.Visible = !f;
		}

	}
}
