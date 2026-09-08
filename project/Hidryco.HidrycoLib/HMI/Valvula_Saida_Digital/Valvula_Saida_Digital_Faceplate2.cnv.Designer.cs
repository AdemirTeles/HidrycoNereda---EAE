/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/28/2026
 * Time: 3:55 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Saida_Digital
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
			this.stpTempoFalhaLigamento.NumberBase = NxtControl.GuiFramework.NumberBase.Hexadecimal;
			this.stpTempoFalhaLigamento.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoFalhaLigamento.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoFalhaLigamento.Suffix = "seg";
			this.stpTempoFalhaLigamento.TagName = "stpTempoFalhaAbertura";
			this.stpTempoFalhaLigamento.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoFalhaLigamento.UseInputPad = true;
			this.stpTempoFalhaLigamento.UseRange = true;
			this.stpTempoFalhaLigamento.Value = ((ushort)(0));
			this.stpTempoFalhaLigamento.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 24D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint tempo falha \r\nabetura";
			// 
			// textBox_11
			// 
			this.textBox_11.BeginInit();
			this.textBox_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 176D, 93D);
			this.textBox_11.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.textBox_11.MaximumTag = null;
			this.textBox_11.MinimumTag = null;
			this.textBox_11.Name = "textBox_11";
			this.textBox_11.NumberBase = NxtControl.GuiFramework.NumberBase.Hexadecimal;
			this.textBox_11.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.textBox_11.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_11.Suffix = "seg";
			this.textBox_11.TagName = "stpTempoFalhaFechamento";
			this.textBox_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.textBox_11.UseInputPad = true;
			this.textBox_11.UseRange = true;
			this.textBox_11.Value = ((ushort)(0));
			this.textBox_11.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 93D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Setpoint tempo falha \r\nfechamento";
			// 
			// Faceplate2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(288D)), ((float)(152D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stpTempoFalhaLigamento,
			this.freeText2,
			this.textBox_11,
			this.freeText1});
			this.Size = new System.Drawing.Size(288, 152);

		}
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoFalhaLigamento;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<ushort> textBox_11;
		private NxtControl.GuiFramework.FreeText freeText1;
		#endregion
	}
}
