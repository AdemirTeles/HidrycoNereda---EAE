/*
 * Hidryco - Controle_PID - sStatus
 * Auxiliar invisivel (1 x 1): embutido no simbolo ou faceplate do processo com TagName = nome da instancia do sub-CAT.
 * Expoe os valores do IThis do sub-CAT como propriedades e avisa pelo evento Mudou.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_PID
{
	public partial class sStatus : NxtControl.GuiFramework.HMISymbol
	{
		public sStatus()
		{
			InitializeComponent();
		}

		public event EventHandler Mudou;
		public bool Recebido { get; private set; }
		public float stsSaidaPID { get; private set; }
		public event EventHandler<ValueChangedEventArgs> stsSaidaPID_Mudou;
		public bool CMD_HABILITA { get; private set; }
		public event EventHandler<ValueChangedEventArgs> CMD_HABILITA_Mudou;
		public float STP_DESEJADO { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_DESEJADO_Mudou;
		public float STP_PARAMETRO_KP { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_PARAMETRO_KP_Mudou;
		public float STP_PARAMETRO_KI { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_PARAMETRO_KI_Mudou;
		public float STP_PARAMETRO_KD { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_PARAMETRO_KD_Mudou;
		public float STP_MINIMO { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_MINIMO_Mudou;
		public float STP_MAXIMO { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_MAXIMO_Mudou;

		void Valor_stsSaidaPID(object sender, ValueChangedEventArgs e)
		{
			stsSaidaPID = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (stsSaidaPID_Mudou != null) stsSaidaPID_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_CMD_HABILITA(object sender, ValueChangedEventArgs e)
		{
			CMD_HABILITA = (bool)Convert.ChangeType(e.Value, typeof(bool)); Recebido = true;
			if (CMD_HABILITA_Mudou != null) CMD_HABILITA_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_DESEJADO(object sender, ValueChangedEventArgs e)
		{
			STP_DESEJADO = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_DESEJADO_Mudou != null) STP_DESEJADO_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_PARAMETRO_KP(object sender, ValueChangedEventArgs e)
		{
			STP_PARAMETRO_KP = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_PARAMETRO_KP_Mudou != null) STP_PARAMETRO_KP_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_PARAMETRO_KI(object sender, ValueChangedEventArgs e)
		{
			STP_PARAMETRO_KI = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_PARAMETRO_KI_Mudou != null) STP_PARAMETRO_KI_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_PARAMETRO_KD(object sender, ValueChangedEventArgs e)
		{
			STP_PARAMETRO_KD = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_PARAMETRO_KD_Mudou != null) STP_PARAMETRO_KD_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_MINIMO(object sender, ValueChangedEventArgs e)
		{
			STP_MINIMO = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_MINIMO_Mudou != null) STP_MINIMO_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_MAXIMO(object sender, ValueChangedEventArgs e)
		{
			STP_MAXIMO = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_MAXIMO_Mudou != null) STP_MAXIMO_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
	}
}
