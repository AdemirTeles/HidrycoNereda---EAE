/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 18/08/2026
 * Tempo: 13:43
 * 
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Faceplates.Atuador_Coester_CSR6T
{
	/// <summary>
	/// Description of fpSemPosicionar.
	/// </summary>
	public partial class fpSemPosicionar : NxtControl.GuiFramework.HMIFaceplate
	{
		private bool _fbkAutomatico;

		// Guarda o Brush original (do designer)
		private NxtControl.Drawing.Brush _autoNormalBrush;
		private NxtControl.Drawing.Brush _manNormalBrush;
		public fpSemPosicionar()
		{
			InitializeComponent();

			// Salva o Brush padrão configurado no designer
			_autoNormalBrush = btnAutomatico.Brush;
			_manNormalBrush  = btnManual.Brush;

			// garante texto branco desde o início
			var white = NxtControl.Drawing.SystemColors.White;
			btnManual.TextColor = white;
			btnAutomatico.TextColor = white;
		}

		void FbkAutomaticoValueChanged(object sender, ValueChangedEventArgs e)
		{
			_fbkAutomatico = Convert.ToBoolean(e.Value);
			UpdateModoButtons(_fbkAutomatico);
		}

		private void UpdateModoButtons(bool automatico)
		{
			var white = NxtControl.Drawing.SystemColors.White;


			if (automatico)
			{
				btnAutomatico.BrushColor = HidrycoColors.botaoTrue;
				btnManual.BrushColor = HidrycoColors.botaoFalse;
			}
			else
			{
				btnManual.BrushColor = HidrycoColors.botaoTrue;
				btnAutomatico.BrushColor = HidrycoColors.botaoFalse;
			}

			// Texto sempre branco (sem ficar cinza porque não desabilitamos)
			btnManual.TextColor = white;
			btnAutomatico.TextColor = white;

			// Mantém ambos habilitados (evita o "fade" cinza do Disabled)
			btnManual.Enabled = true;
			btnAutomatico.Enabled = true;
		}

		void BtnAutomaticoClick(object sender, EventArgs e)
		{
			FireEvent_E_STS_AUTOMATICO(true);
		}

		void BtnManualClick(object sender, EventArgs e)
		{
			FireEvent_E_STS_AUTOMATICO(false);
		}

		void BtnAbrirMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_CMD_ABRIR_MANUAL(true);
		}

		void BtnAbrirMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_CMD_ABRIR_MANUAL(false);
		}

		void BtnFecharMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_CMD_FECHAR_MANUAL(true);
		}

		void BtnFecharMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_CMD_FECHAR_MANUAL(false);
		}

		void BtnPosicionarMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_CMD_POSICIONAR_MANUAL(true);
		}

		void BtnPosicionarMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			FireEvent_E_CMD_POSICIONAR_MANUAL(false);
		}
	}
}
