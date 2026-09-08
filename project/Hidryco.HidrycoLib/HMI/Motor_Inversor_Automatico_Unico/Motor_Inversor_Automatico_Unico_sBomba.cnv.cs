using System;
using Hidryco.HidrycoLib.SupportClasses;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
{
	public partial class sBomba : HMISymbol
	{

		public sBomba()
		{
			InitializeComponent();
		}

		void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			bomba1.Animacao = Convert.ToInt16(e.Value);
		}

		void StsFalhaComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			falha_comunicacao1.Visible = (bool)e.Value;
		}

		void StsProtecaoTermicaValueChanged(object sender, ValueChangedEventArgs e)
		{
			unidade_Portecao_Termica1.Visible = (bool)e.Value;
		}
	}
}