/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 04/03/2026
 * Tempo: 14:04
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Higienizacao
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.label_11 = new System.HMI.Symbols.Base.Label<bool>();
			this.btnManOn = new NxtControl.GuiFramework.DrawnButton();
			this.btnManOff = new NxtControl.GuiFramework.DrawnButton();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.fbkCmdLigaManual = new System.HMI.Symbols.Base.Execute<bool>();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.stsHorimetroHora = new System.HMI.Symbols.Base.Label<int>();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(240D, 72D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(0D, 72D);
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 14D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Operação";
			// 
			// label_11
			// 
			this.label_11.BeginInit();
			this.label_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label_11.DecimalPlacesCount = ((uint)(2u));
			this.label_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.79333333333333333D, 0D, 0D, 0.76190476190476186D, 104D, 16D);
			this.label_11.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.label_11.FontScale = false;
			this.label_11.IsOnlyInput = true;
			this.label_11.LeadingZeros = ((uint)(0u));
			this.label_11.Name = "label_11";
			this.label_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "Manual");
			propertyDictionary3.Add("Text", "Automatico");
			this.label_11.Ranges.Clear();
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.label_11.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.label_11.TagName = "stsAutomaticoSubsistema";
			this.label_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.label_11.EndInit();
			// 
			// btnManOn
			// 
			this.btnManOn.Bounds = new NxtControl.Drawing.RectF(((float)(143D)), ((float)(84D)), ((float)(80D)), ((float)(30D)));
			this.btnManOn.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManOn.ButtonPushedBrush = new NxtControl.Drawing.Brush("ButtonTrueBrush");
			this.btnManOn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManOn.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnManOn.Name = "btnManOn";
			this.btnManOn.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManOn.Radius = 4D;
			this.btnManOn.Text = "Abrir";
			this.btnManOn.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnManOn.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnManOn.Use3DEffect = false;
			this.btnManOn.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// btnManOff
			// 
			this.btnManOff.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(84D)), ((float)(80D)), ((float)(30D)));
			this.btnManOff.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManOff.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManOff.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnManOff.Name = "btnManOff";
			this.btnManOff.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManOff.Radius = 4D;
			this.btnManOff.Text = "Fechar";
			this.btnManOff.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnManOff.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnManOff.Use3DEffect = false;
			this.btnManOff.Click += new System.EventHandler(this.DrawnButton2Click);
			// 
			// freeText3
			// 
			this.freeText3.AngleIgnore = true;
			this.freeText3.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(48D, 96D);
			this.freeText3.Name = "freeText3";
			// 
			// fbkCmdLigaManual
			// 
			this.fbkCmdLigaManual.BeginInit();
			this.fbkCmdLigaManual.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.fbkCmdLigaManual.IsOnlyInput = true;
			this.fbkCmdLigaManual.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbkCmdLigaManual.Name = "fbkCmdLigaManual";
			this.fbkCmdLigaManual.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbkCmdLigaManual.TagName = "fbkCmdLigaManual";
			this.fbkCmdLigaManual.Value = false;
			this.fbkCmdLigaManual.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbkCmdLigaManualValueChanged);
			this.fbkCmdLigaManual.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(8D, 46D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Horímetro";
			// 
			// stsHorimetroHora
			// 
			this.stsHorimetroHora.BeginInit();
			this.stsHorimetroHora.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsHorimetroHora.DecimalPlacesCount = ((uint)(2u));
			this.stsHorimetroHora.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 143D, 46D);
			this.stsHorimetroHora.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsHorimetroHora.FontScale = false;
			this.stsHorimetroHora.IsOnlyInput = true;
			this.stsHorimetroHora.LeadingZeros = ((uint)(0u));
			this.stsHorimetroHora.Name = "stsHorimetroHora";
			this.stsHorimetroHora.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsHorimetroHora.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.stsHorimetroHora.TagName = "stsHorimetroHora";
			this.stsHorimetroHora.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsHorimetroHora.EndInit();
			// 
			// Faceplate1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(240D)), ((float)(128D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.freeText2,
			this.label_11,
			this.btnManOn,
			this.btnManOff,
			this.freeText3,
			this.fbkCmdLigaManual,
			this.freeText5,
			this.stsHorimetroHora});
			this.Size = new System.Drawing.Size(240, 128);

		}
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Label<bool> label_11;
		private NxtControl.GuiFramework.DrawnButton btnManOn;
		private NxtControl.GuiFramework.DrawnButton btnManOff;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.Execute<bool> fbkCmdLigaManual;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.Label<int> stsHorimetroHora;
		#endregion
	}
}
