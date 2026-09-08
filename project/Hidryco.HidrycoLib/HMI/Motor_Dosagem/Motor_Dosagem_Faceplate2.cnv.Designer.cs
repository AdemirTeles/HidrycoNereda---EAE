/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/23/2026
 * Time: 1:59 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Dosagem
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
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.STP_FREQUENCIA_MANUAL = new System.HMI.Symbols.Base.TextBox<float>();
			// 
			// stpTempoFalhaLigamento
			// 
			this.stpTempoFalhaLigamento.BeginInit();
			this.stpTempoFalhaLigamento.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 176D, 20D);
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
			this.stpTempoFalhaLigamento.UseInputPad = true;
			this.stpTempoFalhaLigamento.Value = ((ushort)(0));
			this.stpTempoFalhaLigamento.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 20D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint tempo falha \r\nligamento";
			// 
			// textBox_11
			// 
			this.textBox_11.BeginInit();
			this.textBox_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 176D, 94D);
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
			this.textBox_11.UseInputPad = true;
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
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(8D, 166D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Setpoint vazão\r\nmanual";
			// 
			// STP_FREQUENCIA_MANUAL
			// 
			this.STP_FREQUENCIA_MANUAL.BeginInit();
			this.STP_FREQUENCIA_MANUAL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 9.9138597968777482D, 176D, 168D);
			this.STP_FREQUENCIA_MANUAL.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.STP_FREQUENCIA_MANUAL.MaximumTag = null;
			this.STP_FREQUENCIA_MANUAL.MinimumTag = null;
			this.STP_FREQUENCIA_MANUAL.Name = "STP_FREQUENCIA_MANUAL";
			this.STP_FREQUENCIA_MANUAL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.STP_FREQUENCIA_MANUAL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.STP_FREQUENCIA_MANUAL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.STP_FREQUENCIA_MANUAL.TagName = "STP_SAIDA_MANUAL";
			this.STP_FREQUENCIA_MANUAL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.STP_FREQUENCIA_MANUAL.UseInputPad = true;
			this.STP_FREQUENCIA_MANUAL.Value = 0F;
			this.STP_FREQUENCIA_MANUAL.EndInit();
			// 
			// Faceplate2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(296D)), ((float)(216D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stpTempoFalhaLigamento,
			this.freeText2,
			this.textBox_11,
			this.freeText1,
			this.freeText4,
			this.STP_FREQUENCIA_MANUAL});
			this.Size = new System.Drawing.Size(296, 216);

		}
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoFalhaLigamento;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<ushort> textBox_11;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.TextBox<float> STP_FREQUENCIA_MANUAL;
		#endregion
	}
}
