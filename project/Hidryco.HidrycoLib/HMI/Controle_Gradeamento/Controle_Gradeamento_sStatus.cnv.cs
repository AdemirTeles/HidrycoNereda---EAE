/*
 * Hidryco - Controle_Gradeamento - sStatus
 * Auxiliar invisivel (1 x 1): embutido no simbolo ou faceplate do processo com TagName = nome da instancia do sub-CAT.
 * Expoe os valores do IThis do sub-CAT como propriedades e avisa pelo evento Mudou.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Gradeamento
{
	public partial class sStatus : NxtControl.GuiFramework.HMISymbol
	{
		public sStatus()
		{
			InitializeComponent();
		}

		public event EventHandler Mudou;
		public bool Recebido { get; private set; }
		public float STS_DIFERENCIAL_GRADE1 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STS_DIFERENCIAL_GRADE1_Mudou;
		public float STS_DIFERENCIAL_GRADE2 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STS_DIFERENCIAL_GRADE2_Mudou;
		public bool CMD_LIGA_CICLO_REMOTO { get; private set; }
		public event EventHandler<ValueChangedEventArgs> CMD_LIGA_CICLO_REMOTO_Mudou;
		public float STP_DIFERENCIAL_NIVEL_GRADE1 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_DIFERENCIAL_NIVEL_GRADE1_Mudou;
		public float STP_DIFERENCIAL_NIVEL_GRADE2 { get; private set; }
		public event EventHandler<ValueChangedEventArgs> STP_DIFERENCIAL_NIVEL_GRADE2_Mudou;

		void Valor_STS_DIFERENCIAL_GRADE1(object sender, ValueChangedEventArgs e)
		{
			STS_DIFERENCIAL_GRADE1 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STS_DIFERENCIAL_GRADE1_Mudou != null) STS_DIFERENCIAL_GRADE1_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STS_DIFERENCIAL_GRADE2(object sender, ValueChangedEventArgs e)
		{
			STS_DIFERENCIAL_GRADE2 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STS_DIFERENCIAL_GRADE2_Mudou != null) STS_DIFERENCIAL_GRADE2_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_CMD_LIGA_CICLO_REMOTO(object sender, ValueChangedEventArgs e)
		{
			CMD_LIGA_CICLO_REMOTO = (bool)Convert.ChangeType(e.Value, typeof(bool)); Recebido = true;
			if (CMD_LIGA_CICLO_REMOTO_Mudou != null) CMD_LIGA_CICLO_REMOTO_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_DIFERENCIAL_NIVEL_GRADE1(object sender, ValueChangedEventArgs e)
		{
			STP_DIFERENCIAL_NIVEL_GRADE1 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_DIFERENCIAL_NIVEL_GRADE1_Mudou != null) STP_DIFERENCIAL_NIVEL_GRADE1_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
		void Valor_STP_DIFERENCIAL_NIVEL_GRADE2(object sender, ValueChangedEventArgs e)
		{
			STP_DIFERENCIAL_NIVEL_GRADE2 = (float)Convert.ChangeType(e.Value, typeof(float)); Recebido = true;
			if (STP_DIFERENCIAL_NIVEL_GRADE2_Mudou != null) STP_DIFERENCIAL_NIVEL_GRADE2_Mudou(this, e);
			if (Mudou != null) Mudou(this, EventArgs.Empty);
		}
	}
}
