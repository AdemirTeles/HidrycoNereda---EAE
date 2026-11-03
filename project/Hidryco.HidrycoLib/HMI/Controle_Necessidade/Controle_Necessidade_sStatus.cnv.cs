/*
 * Hidryco - Controle_Necessidade - sStatus
 * Auxiliar invisivel (1 x 1): embutido no simbolo ou faceplate do processo com TagName = nome da instancia do sub-CAT.
 * Expoe os valores do IThis do sub-CAT como propriedades e avisa pelo evento Mudou.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Necessidade
{
	public partial class sStatus : NxtControl.GuiFramework.HMISymbol
	{
		public sStatus()
		{
			InitializeComponent();
		}

		public event EventHandler Mudou;
		public bool Recebido { get; private set; }
		public ushort STS_NECESSIDADE_EQUIPAMENTO { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STS_NECESSIDADE_EQUIPAMENTO_Mudou;
		public float STS_NIVEL { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STS_NIVEL_Mudou;
		public bool CMD_HABILITA { get; private set; }
		public event EventHandler<ValueChangedEventArgs> CMD_HABILITA_Mudou;
		public float STP_LIMITE_FAIXA_1 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_LIMITE_FAIXA_1_Mudou;
		public float STP_LIMITE_FAIXA_2 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_LIMITE_FAIXA_2_Mudou;
		public float STP_LIMITE_FAIXA_3 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_LIMITE_FAIXA_3_Mudou;
		public float STP_LIMITE_FAIXA_4 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_LIMITE_FAIXA_4_Mudou;

		void Valor_STS_NECESSIDADE_EQUIPAMENTO(object sender, ValueChangedEventArgs e)
		{
			STS_NECESSIDADE_EQUIPAMENTO = (ushort)Convert.ChangeType(e.Value, typeof(ushort)); Recebido = true;
			if (STS_NECESSIDADE_EQUIPAMENTO_Mudou != null) STS_NECESSIDADE_EQUIPAMENTO_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STS_NIVEL(object sender, ValueChangedEventArgs e)
		{
			STS_NIVEL = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STS_NIVEL_Mudou != null) STS_NIVEL_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_CMD_HABILITA(object sender, ValueChangedEventArgs e)
		{
			CMD_HABILITA = (bool)Convert.ChangeType(e.Value, typeof(bool)); Recebido = true;
			if (CMD_HABILITA_Mudou != null) CMD_HABILITA_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_LIMITE_FAIXA_1(object sender, ValueChangedEventArgs e)
		{
			STP_LIMITE_FAIXA_1 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_LIMITE_FAIXA_1_Mudou != null) STP_LIMITE_FAIXA_1_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_LIMITE_FAIXA_2(object sender, ValueChangedEventArgs e)
		{
			STP_LIMITE_FAIXA_2 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_LIMITE_FAIXA_2_Mudou != null) STP_LIMITE_FAIXA_2_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_LIMITE_FAIXA_3(object sender, ValueChangedEventArgs e)
		{
			STP_LIMITE_FAIXA_3 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_LIMITE_FAIXA_3_Mudou != null) STP_LIMITE_FAIXA_3_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_LIMITE_FAIXA_4(object sender, ValueChangedEventArgs e)
		{
			STP_LIMITE_FAIXA_4 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_LIMITE_FAIXA_4_Mudou != null) STP_LIMITE_FAIXA_4_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
	}
}
