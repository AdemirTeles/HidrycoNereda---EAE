/*
 * Hidryco - Controle_Revezamento_3 - sStatus
 * Auxiliar invisivel (1 x 1): embutido no simbolo ou faceplate do processo com TagName = nome da instancia do sub-CAT.
 * Expoe os valores do IThis do sub-CAT como propriedades e avisa pelo evento Mudou.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_3
{
	public partial class sStatus : NxtControl.GuiFramework.HMISymbol
	{
		public sStatus()
		{
			InitializeComponent();
		}

		public event EventHandler Mudou;
		public bool Recebido { get; private set; }
		public ushort STS_RESTANTE_HOR { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STS_RESTANTE_HOR_Mudou;
		public ushort STS_RESTANTE_MIN { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STS_RESTANTE_MIN_Mudou;
		public ushort STS_RESTANTE_SEG { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STS_RESTANTE_SEG_Mudou;
		public bool CMD_HABILITA { get; private set; }
		public event EventHandler<ValueChangedEventArgs> CMD_HABILITA_Mudou;
		public ushort STP_TEMPO_B1 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_TEMPO_B1_Mudou;
		public ushort STP_TEMPO_B2 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_TEMPO_B2_Mudou;
		public ushort STP_TEMPO_B3 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_TEMPO_B3_Mudou;
		public short CMD_SELECAO_BOMBA { get; private set; }
		public event EventHandler<ValueChangedEventArgs> CMD_SELECAO_BOMBA_Mudou;

		void Valor_STS_RESTANTE_HOR(object sender, ValueChangedEventArgs e)
		{
			STS_RESTANTE_HOR = (ushort)Convert.ChangeType(e.Value, typeof(ushort)); Recebido = true;
			if (STS_RESTANTE_HOR_Mudou != null) STS_RESTANTE_HOR_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STS_RESTANTE_MIN(object sender, ValueChangedEventArgs e)
		{
			STS_RESTANTE_MIN = (ushort)Convert.ChangeType(e.Value, typeof(ushort)); Recebido = true;
			if (STS_RESTANTE_MIN_Mudou != null) STS_RESTANTE_MIN_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STS_RESTANTE_SEG(object sender, ValueChangedEventArgs e)
		{
			STS_RESTANTE_SEG = (ushort)Convert.ChangeType(e.Value, typeof(ushort)); Recebido = true;
			if (STS_RESTANTE_SEG_Mudou != null) STS_RESTANTE_SEG_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_CMD_HABILITA(object sender, ValueChangedEventArgs e)
		{
			CMD_HABILITA = (bool)Convert.ChangeType(e.Value, typeof(bool)); Recebido = true;
			if (CMD_HABILITA_Mudou != null) CMD_HABILITA_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_TEMPO_B1(object sender, ValueChangedEventArgs e)
		{
			STP_TEMPO_B1 = (ushort)Convert.ChangeType(e.Value, typeof(ushort)); Recebido = true;
			if (STP_TEMPO_B1_Mudou != null) STP_TEMPO_B1_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_TEMPO_B2(object sender, ValueChangedEventArgs e)
		{
			STP_TEMPO_B2 = (ushort)Convert.ChangeType(e.Value, typeof(ushort)); Recebido = true;
			if (STP_TEMPO_B2_Mudou != null) STP_TEMPO_B2_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_TEMPO_B3(object sender, ValueChangedEventArgs e)
		{
			STP_TEMPO_B3 = (ushort)Convert.ChangeType(e.Value, typeof(ushort)); Recebido = true;
			if (STP_TEMPO_B3_Mudou != null) STP_TEMPO_B3_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_CMD_SELECAO_BOMBA(object sender, ValueChangedEventArgs e)
		{
			CMD_SELECAO_BOMBA = (short)Convert.ChangeType(e.Value, typeof(short)); Recebido = true;
			if (CMD_SELECAO_BOMBA_Mudou != null) CMD_SELECAO_BOMBA_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
	}
}
