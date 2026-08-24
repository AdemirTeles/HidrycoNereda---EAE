/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 21/04/2026
 * Tempo: 13:41
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Unifilar
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			
			
		}

	void ABERTO_FECHADO_1Q0ValueChanged(object sender, ValueChangedEventArgs e)
		{
			if ((bool)ABERTO_1Q0.Value && !(bool)FECHADO_1Q0.Value) {
				txStatus_1.Text = "Aberto";
			} else if (!(bool)ABERTO_1Q0.Value && (bool)FECHADO_1Q0.Value) {
				txStatus_1.Text = "Fechado";
			} else {
				txStatus_1.Text = "Transição";
			}
			
		}

		void FECHAR_1Q0MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FECHAR_1Q0.Checked = true;
			FECHAR_1Q0.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonTrueBrush");
		}

		void FECHAR_1Q0MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FECHAR_1Q0.Checked = false;
			FECHAR_1Q0.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonFalseBrush");
		}

		void ABRIR_1Q0MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ABRIR_1Q0.Checked = true;
			ABRIR_1Q0.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonTrueBrush");
		}

		void ABRIR_1Q0MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ABRIR_1Q0.Checked = false;
			ABRIR_1Q0.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonFalseBrush");
		}
		//____________________________________________________________________________
		void FECHAR_1Q1MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FECHAR_1Q1.Checked = true;
			FECHAR_1Q1.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonTrueBrush");
		}

		void FECHAR_1Q1MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FECHAR_1Q1.Checked = false;
			FECHAR_1Q1.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonFalseBrush");
		}

		void ABRIR_1Q1MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ABRIR_1Q1.Checked = true;
			ABRIR_1Q1.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonTrueBrush");
		}

		void ABRIR_1Q1MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ABRIR_1Q1.Checked = false;
			ABRIR_1Q1.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonFalseBrush");
		}
		//_______________________________________________________________________________
		void FECHAR_1Q2MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FECHAR_1Q2.Checked = true;
			FECHAR_1Q2.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonTrueBrush");
		}

		void FECHAR_1Q2MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FECHAR_1Q2.Checked = false;
			FECHAR_1Q2.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonFalseBrush");
		}

		void ABRIR_1Q2MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ABRIR_1Q2.Checked = true;
			ABRIR_1Q2.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonTrueBrush");
		}

		void ABRIR_1Q2MouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ABRIR_1Q2.Checked = false;
			ABRIR_1Q2.FalseBrush = NxtControl.Drawing.Brush.FromName("ButtonFalseBrush");
		}
		//_______________________________________________________________________________
		void STS_QTAM1_DISJUNTOR_LIGADO_GERADORValueChanged(object sender, ValueChangedEventArgs e)
		{
			stsQTAM1DisjuntorLigadoGerador.Visible = (bool)e.Value;
			
			if ((bool)e.Value) {
				stsQTAM1DisjuntorLigadoGeradorBase.PenColor = HidrycoColors.Ligado;
			} else{
				stsQTAM1DisjuntorLigadoGeradorBase.PenColor = HidrycoColors.Desligado;
			}
		}
		//_______________________________________________________________________________
		void STS_QTAM1_DISJUNTOR_LIGADO_QUADROValueChanged(object sender, ValueChangedEventArgs e)
		{
			stsQTAM1DisjuntorLigadoQuadro.Visible = (bool)e.Value;
			
			if ((bool)e.Value) {
				stsQTAM1DisjuntorLigadoQuadroBase.PenColor = HidrycoColors.Ligado;
			} else{
				stsQTAM1DisjuntorLigadoQuadroBase.PenColor = HidrycoColors.Desligado;
			}
		}
		//_______________________________________________________________________________
		void STS_QTAM2_DISJUNTOR_LIGADO_GERADORValueChanged(object sender, ValueChangedEventArgs e)
		{
			stsQTAM2DisjuntorLigadoGerador.Visible = (bool)e.Value;
			
			if ((bool)e.Value) {
				stsQTAM2DisjuntorLigadoGeradorBase.PenColor = HidrycoColors.Ligado;
			} else{
				stsQTAM2DisjuntorLigadoGeradorBase.PenColor = HidrycoColors.Desligado;
			}
		}
		//_______________________________________________________________________________
		void STS_QTAM2_DISJUNTOR_LIGADO_QUADROValueChanged(object sender, ValueChangedEventArgs e)
		{
			stsQTAM2DisjuntorLigadoQuadro.Visible = (bool)e.Value;
			
			if ((bool)e.Value) {
				stsQTAM2DisjuntorLigadoQuadroBase.PenColor = HidrycoColors.Ligado;
			} else{
				stsQTAM2DisjuntorLigadoQuadroBase.PenColor = HidrycoColors.Desligado;
			}
		}
	}
}
