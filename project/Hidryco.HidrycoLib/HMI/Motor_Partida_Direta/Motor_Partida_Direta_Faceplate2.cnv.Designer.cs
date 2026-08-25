/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 19/01/2026
 * Tempo: 16:54
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Partida_Direta
{
	/// <summary>
	/// Summary description for Faceplate2.
	/// </summary>
	partial class Faceplate2
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.stpTempoFalhaLigamento = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.textBox_11 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			// 
			// stpTempoFalhaLigamento
			// 
			this.stpTempoFalhaLigamento.BeginInit();
			this.stpTempoFalhaLigamento.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 176D, 24D);
			this.stpTempoFalhaLigamento.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpTempoFalhaLigamento.MaximumTag = null;
			this.stpTempoFalhaLigamento.MinimumTag = null;
			this.stpTempoFalhaLigamento.Name = "stpTempoFalhaLigamento";
			this.stpTempoFalhaLigamento.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpTempoFalhaLigamento.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoFalhaLigamento.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoFalhaLigamento.Suffix = "seg";
			this.stpTempoFalhaLigamento.TagName = "STP_FALHA_LIGAMENTO";
			this.stpTempoFalhaLigamento.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoFalhaLigamento.Value = ((ushort)(0));
			this.stpTempoFalhaLigamento.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 24D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint tempo falha \r\nligamento";
			// 
			// textBox_11
			// 
			this.textBox_11.BeginInit();
			this.textBox_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 176D, 93D);
			this.textBox_11.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.textBox_11.MaximumTag = null;
			this.textBox_11.MinimumTag = null;
			this.textBox_11.Name = "textBox_11";
			this.textBox_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.textBox_11.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.textBox_11.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_11.Suffix = "seg";
			this.textBox_11.TagName = "STP_FALHA_DESLIGAMENTO";
			this.textBox_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.textBox_11.Value = ((ushort)(0));
			this.textBox_11.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 93D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Setpoint tempo falha \r\ndesligamento";
			// 
			// Faceplate2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(300D)), ((float)(158D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stpTempoFalhaLigamento,
			this.freeText2,
			this.textBox_11,
			this.freeText1});
			this.Size = new System.Drawing.Size(300, 158);

		}
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoFalhaLigamento;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<ushort> textBox_11;
		private NxtControl.GuiFramework.FreeText freeText1;
		#endregion
	}
}
