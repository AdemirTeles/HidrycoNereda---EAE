/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 17:38
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.BloqueioAtivaDesativa
{
	/// <summary>
	/// Summary description for fpAjuste.
	/// </summary>
	partial class fpAjuste
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.stpSaidaDesejada = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.stpKP = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.cmdHabilita = new System.HMI.Symbols.Base.CheckButton();
			this.aliasDisplayLabel1 = new NxtControl.GuiFramework.AliasDisplayLabel();
			// 
			// stpSaidaDesejada
			// 
			this.stpSaidaDesejada.BeginInit();
			this.stpSaidaDesejada.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 136D);
			this.stpSaidaDesejada.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpSaidaDesejada.MaximumTag = null;
			this.stpSaidaDesejada.MinimumTag = null;
			this.stpSaidaDesejada.Name = "stpSaidaDesejada";
			this.stpSaidaDesejada.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpSaidaDesejada.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpSaidaDesejada.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpSaidaDesejada.TagName = "";
			this.stpSaidaDesejada.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpSaidaDesejada.Value = 0F;
			this.stpSaidaDesejada.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 132D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Setpoint ativa\r\nbloqueio";
			// 
			// stpKP
			// 
			this.stpKP.BeginInit();
			this.stpKP.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 200D);
			this.stpKP.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpKP.MaximumTag = null;
			this.stpKP.MinimumTag = null;
			this.stpKP.Name = "stpKP";
			this.stpKP.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpKP.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpKP.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpKP.TagName = "";
			this.stpKP.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpKP.Value = 0F;
			this.stpKP.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 196D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint desativa\r\nbloqueio";
			// 
			// cmdHabilita
			// 
			this.cmdHabilita.BeginInit();
			this.cmdHabilita.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1.0666666666666667D, 104D, 64D);
			this.cmdHabilita.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.FalseText = "Habilitar";
			this.cmdHabilita.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilita.FontScale = false;
			this.cmdHabilita.Name = "cmdHabilita";
			this.cmdHabilita.TagName = "cmdHabilita";
			this.cmdHabilita.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.TrueText = "Desabilitar";
			this.cmdHabilita.Value = false;
			this.cmdHabilita.EndInit();
			// 
			// aliasDisplayLabel1
			// 
			this.aliasDisplayLabel1.AngleIgnore = true;
			this.aliasDisplayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aliasDisplayLabel1.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(24D)), ((float)(104D)), ((float)(16D)));
			this.aliasDisplayLabel1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.aliasDisplayLabel1.CustomInstanceName = null;
			this.aliasDisplayLabel1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.aliasDisplayLabel1.FontScale = true;
			this.aliasDisplayLabel1.Name = "aliasDisplayLabel1";
			this.aliasDisplayLabel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.aliasDisplayLabel1.Text = "Label";
			this.aliasDisplayLabel1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.aliasDisplayLabel1.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			// 
			// fpAjuste
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(300D)), ((float)(272D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stpKP,
			this.freeText2,
			this.cmdHabilita,
			this.stpSaidaDesejada,
			this.freeText1,
			this.aliasDisplayLabel1});
			this.Size = new System.Drawing.Size(300, 272);

		}
		private System.HMI.Symbols.Base.TextBox<float> stpSaidaDesejada;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> stpKP;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.CheckButton cmdHabilita;
		private NxtControl.GuiFramework.AliasDisplayLabel aliasDisplayLabel1;
		#endregion
	}
}
