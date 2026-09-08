/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/20/2026
 * Time: 5:16 PM
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
	/// Summary description for Faceplate4.
	/// </summary>
	partial class Faceplate3
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
			this.btnResetHorimetro = new NxtControl.GuiFramework.DrawnButton();
			this.btnResetPartidas = new NxtControl.GuiFramework.DrawnButton();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.stsNumeroPartidas = new System.HMI.Symbols.Base.Label<uint>();
			this.stsHorimetroHora = new System.HMI.Symbols.Base.Label<uint>();
			// 
			// btnResetHorimetro
			// 
			this.btnResetHorimetro.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(51D)), ((float)(80D)), ((float)(30D)));
			this.btnResetHorimetro.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnResetHorimetro.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnResetHorimetro.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnResetHorimetro.Name = "btnResetHorimetro";
			this.btnResetHorimetro.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnResetHorimetro.Radius = 4D;
			this.btnResetHorimetro.Text = "Reset Horimetro";
			this.btnResetHorimetro.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnResetHorimetro.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnResetHorimetro.Use3DEffect = false;
			this.btnResetHorimetro.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnResetHorimetroMouseDown);
			this.btnResetHorimetro.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnResetHorimetroMouseUp);
			// 
			// btnResetPartidas
			// 
			this.btnResetPartidas.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(148D)), ((float)(80D)), ((float)(30D)));
			this.btnResetPartidas.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnResetPartidas.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnResetPartidas.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnResetPartidas.Name = "btnResetPartidas";
			this.btnResetPartidas.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnResetPartidas.Radius = 4D;
			this.btnResetPartidas.Text = "Reset Partidas";
			this.btnResetPartidas.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnResetPartidas.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnResetPartidas.Use3DEffect = false;
			this.btnResetPartidas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnResetPartidasMouseDown);
			this.btnResetPartidas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnResetPartidasMouseUp);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 96D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Número de \r\npartidas";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 17D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Horimetro";
			// 
			// stsNumeroPartidas
			// 
			this.stsNumeroPartidas.BeginInit();
			this.stsNumeroPartidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsNumeroPartidas.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.52D, 0D, 0D, 1D, 120D, 105D);
			this.stsNumeroPartidas.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsNumeroPartidas.FontScale = false;
			this.stsNumeroPartidas.IsOnlyInput = true;
			this.stsNumeroPartidas.LeadingZeros = ((uint)(0u));
			this.stsNumeroPartidas.Name = "stsNumeroPartidas";
			this.stsNumeroPartidas.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsNumeroPartidas.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsNumeroPartidas.TagName = "STS_NUMERO_PARTIDA";
			this.stsNumeroPartidas.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsNumeroPartidas.EndInit();
			// 
			// stsHorimetroHora
			// 
			this.stsHorimetroHora.BeginInit();
			this.stsHorimetroHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsHorimetroHora.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62666666666666671D, 0D, 0D, 1D, 104D, 16D);
			this.stsHorimetroHora.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsHorimetroHora.FontScale = false;
			this.stsHorimetroHora.IsOnlyInput = true;
			this.stsHorimetroHora.IsPrefixSuffixOutside = false;
			this.stsHorimetroHora.LeadingZeros = ((uint)(0u));
			this.stsHorimetroHora.Name = "stsHorimetroHora";
			this.stsHorimetroHora.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsHorimetroHora.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.stsHorimetroHora.Suffix = "h";
			this.stsHorimetroHora.TagName = "STS_HORIMETRO_HORA";
			this.stsHorimetroHora.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsHorimetroHora.EndInit();
			// 
			// Faceplate3
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(210D)), ((float)(186D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.btnResetHorimetro,
			this.btnResetPartidas,
			this.freeText1,
			this.freeText2,
			this.stsNumeroPartidas,
			this.stsHorimetroHora});
			this.Size = new System.Drawing.Size(210, 186);

		}
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Label<uint> stsHorimetroHora;
		private System.HMI.Symbols.Base.Label<uint> stsNumeroPartidas;
		private NxtControl.GuiFramework.DrawnButton btnResetHorimetro;
		private NxtControl.GuiFramework.DrawnButton btnResetPartidas;
		#endregion
	}
}
