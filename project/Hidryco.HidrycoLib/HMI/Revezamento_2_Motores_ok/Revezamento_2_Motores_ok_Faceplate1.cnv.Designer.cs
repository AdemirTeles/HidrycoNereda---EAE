/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 25/02/2026
 * Tempo: 09:37
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Revezamento_2_Motores_ok
{
	/// <summary>
	/// Summary description for Faceplate1.
	/// </summary>
	partial class Faceplate1
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cmdHabilitaRevezamento = new System.HMI.Symbols.Base.CheckButton();
			this.stpTempoEquipamento1 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.stpTempoEquipamento2 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.stsTempoRestanteHora = new System.HMI.Symbols.Base.Label<ushort>();
			this.stsTempoRestanteMinuto = new System.HMI.Symbols.Base.Label<ushort>();
			this.stsTempoRestanteSegundo = new System.HMI.Symbols.Base.Label<ushort>();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			// 
			// cmdHabilitaRevezamento
			// 
			this.cmdHabilitaRevezamento.BeginInit();
			this.cmdHabilitaRevezamento.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 119D, 8D);
			this.cmdHabilitaRevezamento.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaRevezamento.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaRevezamento.FalseText = "Habilitar";
			this.cmdHabilitaRevezamento.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaRevezamento.FontScale = false;
			this.cmdHabilitaRevezamento.Name = "cmdHabilitaRevezamento";
			this.cmdHabilitaRevezamento.TagName = "cmdHabilitaRevezamento";
			this.cmdHabilitaRevezamento.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaRevezamento.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaRevezamento.TrueText = "Desabilitar";
			this.cmdHabilitaRevezamento.Value = false;
			this.cmdHabilitaRevezamento.EndInit();
			// 
			// stpTempoEquipamento1
			// 
			this.stpTempoEquipamento1.BeginInit();
			this.stpTempoEquipamento1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 184D, 132D);
			this.stpTempoEquipamento1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpTempoEquipamento1.MaximumTag = null;
			this.stpTempoEquipamento1.MinimumTag = null;
			this.stpTempoEquipamento1.Name = "stpTempoEquipamento1";
			this.stpTempoEquipamento1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpTempoEquipamento1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoEquipamento1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoEquipamento1.Suffix = "min";
			this.stpTempoEquipamento1.TagName = "stpTempoEquipamento1";
			this.stpTempoEquipamento1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoEquipamento1.UseInputPad = true;
			this.stpTempoEquipamento1.Value = ((ushort)(0));
			this.stpTempoEquipamento1.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 127D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint tempo \r\nequipamento 1";
			// 
			// stpTempoEquipamento2
			// 
			this.stpTempoEquipamento2.BeginInit();
			this.stpTempoEquipamento2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 184D, 206D);
			this.stpTempoEquipamento2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpTempoEquipamento2.MaximumTag = null;
			this.stpTempoEquipamento2.MinimumTag = null;
			this.stpTempoEquipamento2.Name = "stpTempoEquipamento2";
			this.stpTempoEquipamento2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpTempoEquipamento2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoEquipamento2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoEquipamento2.Suffix = "min";
			this.stpTempoEquipamento2.TagName = "stpTempoEquipamento2";
			this.stpTempoEquipamento2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoEquipamento2.UseInputPad = true;
			this.stpTempoEquipamento2.Value = ((ushort)(0));
			this.stpTempoEquipamento2.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 201D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Setpoint tempo \r\nequipamento 2";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 72D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Tempo restante";
			// 
			// stsTempoRestanteHora
			// 
			this.stsTempoRestanteHora.BeginInit();
			this.stsTempoRestanteHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsTempoRestanteHora.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.22666666666666668D, 0D, 0D, 1D, 182D, 72D);
			this.stsTempoRestanteHora.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsTempoRestanteHora.FontScale = false;
			this.stsTempoRestanteHora.IsOnlyInput = true;
			this.stsTempoRestanteHora.LeadingZeros = ((uint)(0u));
			this.stsTempoRestanteHora.Name = "stsTempoRestanteHora";
			this.stsTempoRestanteHora.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsTempoRestanteHora.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsTempoRestanteHora.TagName = "stsTempoRestanteHora";
			this.stsTempoRestanteHora.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsTempoRestanteHora.EndInit();
			// 
			// stsTempoRestanteMinuto
			// 
			this.stsTempoRestanteMinuto.BeginInit();
			this.stsTempoRestanteMinuto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsTempoRestanteMinuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.22666666666666668D, 0D, 0D, 1D, 211D, 72D);
			this.stsTempoRestanteMinuto.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsTempoRestanteMinuto.FontScale = false;
			this.stsTempoRestanteMinuto.IsOnlyInput = true;
			this.stsTempoRestanteMinuto.LeadingZeros = ((uint)(0u));
			this.stsTempoRestanteMinuto.Name = "stsTempoRestanteMinuto";
			this.stsTempoRestanteMinuto.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsTempoRestanteMinuto.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.stsTempoRestanteMinuto.TagName = "stsTempoRestanteMinuto";
			this.stsTempoRestanteMinuto.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsTempoRestanteMinuto.EndInit();
			// 
			// stsTempoRestanteSegundo
			// 
			this.stsTempoRestanteSegundo.BeginInit();
			this.stsTempoRestanteSegundo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsTempoRestanteSegundo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.22666666666666668D, 0D, 0D, 1D, 240D, 72D);
			this.stsTempoRestanteSegundo.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsTempoRestanteSegundo.FontScale = false;
			this.stsTempoRestanteSegundo.IsOnlyInput = true;
			this.stsTempoRestanteSegundo.LeadingZeros = ((uint)(0u));
			this.stsTempoRestanteSegundo.Name = "stsTempoRestanteSegundo";
			this.stsTempoRestanteSegundo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsTempoRestanteSegundo.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.stsTempoRestanteSegundo.TagName = "stsTempoRestanteSegundo";
			this.stsTempoRestanteSegundo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsTempoRestanteSegundo.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(212D, 72D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = ":";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(239D, 72D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = ":";
			// 
			// Faceplate1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(312D)), ((float)(256D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cmdHabilitaRevezamento,
			this.stpTempoEquipamento1,
			this.freeText2,
			this.stpTempoEquipamento2,
			this.freeText1,
			this.freeText4,
			this.stsTempoRestanteHora,
			this.stsTempoRestanteMinuto,
			this.stsTempoRestanteSegundo,
			this.freeText5,
			this.freeText6});
			this.Size = new System.Drawing.Size(312, 256);

		}
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaRevezamento;
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoEquipamento1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoEquipamento2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.Label<ushort> stsTempoRestanteHora;
		private System.HMI.Symbols.Base.Label<ushort> stsTempoRestanteMinuto;
		private System.HMI.Symbols.Base.Label<ushort> stsTempoRestanteSegundo;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		#endregion
	}
}
