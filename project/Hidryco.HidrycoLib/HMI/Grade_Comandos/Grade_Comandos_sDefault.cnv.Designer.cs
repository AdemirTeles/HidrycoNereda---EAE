/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/24/2026
 * Time: 10:59 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Grade_Comandos
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.stpDiferencialNivelGrade1 = new System.HMI.Symbols.Base.TextBox<short>();
			this.stpDiferencialNivelGrade2 = new System.HMI.Symbols.Base.TextBox<short>();
			this.cmdLigaCicloRemoto = new System.HMI.Symbols.Base.CheckButton();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(4D)), ((float)(0D)), ((float)(336D)), ((float)(152D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(229)), ((byte)(229)), ((byte)(229))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 16D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Setpoint nível para \r\nacionamento Grade 1";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 64D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint nível para \r\nacionamento Grade 2";
			// 
			// stpDiferencialNivelGrade1
			// 
			this.stpDiferencialNivelGrade1.BeginInit();
			this.stpDiferencialNivelGrade1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.85333333333333339D, 0D, 0D, 1D, 192D, 22D);
			this.stpDiferencialNivelGrade1.MaximumTag = null;
			this.stpDiferencialNivelGrade1.MinimumTag = null;
			this.stpDiferencialNivelGrade1.Name = "stpDiferencialNivelGrade1";
			this.stpDiferencialNivelGrade1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpDiferencialNivelGrade1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpDiferencialNivelGrade1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpDiferencialNivelGrade1.TagName = "stpDiferencialNivelGrade1";
			this.stpDiferencialNivelGrade1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpDiferencialNivelGrade1.UseInputPad = true;
			this.stpDiferencialNivelGrade1.Value = ((short)(0));
			this.stpDiferencialNivelGrade1.EndInit();
			// 
			// stpDiferencialNivelGrade2
			// 
			this.stpDiferencialNivelGrade2.BeginInit();
			this.stpDiferencialNivelGrade2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.85333333333333339D, 0D, 0D, 1D, 192D, 70D);
			this.stpDiferencialNivelGrade2.MaximumTag = null;
			this.stpDiferencialNivelGrade2.MinimumTag = null;
			this.stpDiferencialNivelGrade2.Name = "stpDiferencialNivelGrade2";
			this.stpDiferencialNivelGrade2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpDiferencialNivelGrade2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpDiferencialNivelGrade2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpDiferencialNivelGrade2.TagName = "stpDiferencialNivelGrade2";
			this.stpDiferencialNivelGrade2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpDiferencialNivelGrade2.UseInputPad = true;
			this.stpDiferencialNivelGrade2.Value = ((short)(0));
			this.stpDiferencialNivelGrade2.EndInit();
			// 
			// cmdLigaCicloRemoto
			// 
			this.cmdLigaCicloRemoto.BeginInit();
			this.cmdLigaCicloRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2D, 112D, 109D);
			this.cmdLigaCicloRemoto.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdLigaCicloRemoto.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdLigaCicloRemoto.FalseText = "Ligar ciclo";
			this.cmdLigaCicloRemoto.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.cmdLigaCicloRemoto.FontScale = false;
			this.cmdLigaCicloRemoto.Name = "cmdLigaCicloRemoto";
			this.cmdLigaCicloRemoto.TagName = "cmdLigaCicloRemoto";
			this.cmdLigaCicloRemoto.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdLigaCicloRemoto.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdLigaCicloRemoto.TrueText = "Desligar ciclo";
			this.cmdLigaCicloRemoto.Value = false;
			this.cmdLigaCicloRemoto.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.freeText1,
			this.freeText2,
			this.stpDiferencialNivelGrade1,
			this.stpDiferencialNivelGrade2,
			this.cmdLigaCicloRemoto});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<short> stpDiferencialNivelGrade1;
		private System.HMI.Symbols.Base.TextBox<short> stpDiferencialNivelGrade2;
		private System.HMI.Symbols.Base.CheckButton cmdLigaCicloRemoto;
		#endregion
	}
}
