/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/20/2026
 * Time: 3:44 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.PID
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cmdHabilitaPID = new System.HMI.Symbols.Base.CheckButton();
			this.stpSaidaDesejada = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpKP = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpKI = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpKD = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpMaximo = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpMinimo = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.stsSaidaPID = new System.HMI.Symbols.Base.Label<float>();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			// 
			// cmdHabilitaPID
			// 
			this.cmdHabilitaPID.BeginInit();
			this.cmdHabilitaPID.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1D, 0D, 0D, 1.0666666666666667D, 104D, 16D);
			this.cmdHabilitaPID.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaPID.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaPID.FalseText = "Habilitar";
			this.cmdHabilitaPID.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaPID.FontScale = false;
			this.cmdHabilitaPID.Name = "cmdHabilitaPID";
			this.cmdHabilitaPID.TagName = "cmdHabilitaPID";
			this.cmdHabilitaPID.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaPID.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaPID.TrueText = "Desabilitar";
			this.cmdHabilitaPID.Value = false;
			this.cmdHabilitaPID.EndInit();
			// 
			// stpSaidaDesejada
			// 
			this.stpSaidaDesejada.BeginInit();
			this.stpSaidaDesejada.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 112D);
			this.stpSaidaDesejada.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpSaidaDesejada.MaximumTag = null;
			this.stpSaidaDesejada.MinimumTag = null;
			this.stpSaidaDesejada.Name = "stpSaidaDesejada";
			this.stpSaidaDesejada.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpSaidaDesejada.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpSaidaDesejada.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpSaidaDesejada.TagName = "stpDesejado";
			this.stpSaidaDesejada.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpSaidaDesejada.Value = 0F;
			this.stpSaidaDesejada.EndInit();
			// 
			// stpKP
			// 
			this.stpKP.BeginInit();
			this.stpKP.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 158D);
			this.stpKP.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpKP.MaximumTag = null;
			this.stpKP.MinimumTag = null;
			this.stpKP.Name = "stpKP";
			this.stpKP.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpKP.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpKP.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpKP.TagName = "stpKP";
			this.stpKP.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpKP.Value = 0F;
			this.stpKP.EndInit();
			// 
			// stpKI
			// 
			this.stpKI.BeginInit();
			this.stpKI.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 204D);
			this.stpKI.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpKI.MaximumTag = null;
			this.stpKI.MinimumTag = null;
			this.stpKI.Name = "stpKI";
			this.stpKI.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpKI.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpKI.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpKI.TagName = "stpKI";
			this.stpKI.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpKI.Value = 0F;
			this.stpKI.EndInit();
			// 
			// stpKD
			// 
			this.stpKD.BeginInit();
			this.stpKD.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 250D);
			this.stpKD.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpKD.MaximumTag = null;
			this.stpKD.MinimumTag = null;
			this.stpKD.Name = "stpKD";
			this.stpKD.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpKD.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpKD.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpKD.TagName = "stpKD";
			this.stpKD.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpKD.Value = 0F;
			this.stpKD.EndInit();
			// 
			// stpMaximo
			// 
			this.stpMaximo.BeginInit();
			this.stpMaximo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 296D);
			this.stpMaximo.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpMaximo.MaximumTag = null;
			this.stpMaximo.MinimumTag = null;
			this.stpMaximo.Name = "stpMaximo";
			this.stpMaximo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpMaximo.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpMaximo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpMaximo.TagName = "stpMaximo";
			this.stpMaximo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpMaximo.Value = 0F;
			this.stpMaximo.EndInit();
			// 
			// stpMinimo
			// 
			this.stpMinimo.BeginInit();
			this.stpMinimo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 176D, 344D);
			this.stpMinimo.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpMinimo.MaximumTag = null;
			this.stpMinimo.MinimumTag = null;
			this.stpMinimo.Name = "stpMinimo";
			this.stpMinimo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpMinimo.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpMinimo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpMinimo.TagName = "stpMinimo";
			this.stpMinimo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpMinimo.Value = 0F;
			this.stpMinimo.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 112D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Setpoint desejado";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 163D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint KP";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 209D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Setpoint KI";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 255D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Setpoint KD";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 301D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Setpoint maximo";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 349D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Setpoint minimo";
			// 
			// stsSaidaPID
			// 
			this.stsSaidaPID.BeginInit();
			this.stsSaidaPID.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsSaidaPID.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7466666666666667D, 0D, 0D, 1D, 176D, 72D);
			this.stsSaidaPID.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsSaidaPID.FontScale = false;
			this.stsSaidaPID.IsOnlyInput = true;
			this.stsSaidaPID.LeadingZeros = ((uint)(0u));
			this.stsSaidaPID.Name = "stsSaidaPID";
			this.stsSaidaPID.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stsSaidaPID.Ranges.Clear();
			this.stsSaidaPID.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsSaidaPID.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsSaidaPID.TagName = "stsSaidaPID";
			this.stsSaidaPID.EndInit();
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 72D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Saída PID";
			// 
			// Faceplate1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(300D)), ((float)(400D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cmdHabilitaPID,
			this.stsSaidaPID,
			this.freeText7,
			this.stpKP,
			this.freeText2,
			this.stpSaidaDesejada,
			this.freeText1,
			this.stpMinimo,
			this.freeText6,
			this.stpMaximo,
			this.freeText5,
			this.stpKD,
			this.freeText4,
			this.stpKI,
			this.freeText3});
			this.Size = new System.Drawing.Size(300, 400);

		}
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaPID;
		private System.HMI.Symbols.Base.TextBox<float> stpSaidaDesejada;
		private System.HMI.Symbols.Base.TextBox<float> stpKP;
		private System.HMI.Symbols.Base.TextBox<float> stpKI;
		private System.HMI.Symbols.Base.TextBox<float> stpKD;
		private System.HMI.Symbols.Base.TextBox<float> stpMaximo;
		private System.HMI.Symbols.Base.TextBox<float> stpMinimo;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private System.HMI.Symbols.Base.Label<float> stsSaidaPID;
		private NxtControl.GuiFramework.FreeText freeText7;
		#endregion
	}
}
