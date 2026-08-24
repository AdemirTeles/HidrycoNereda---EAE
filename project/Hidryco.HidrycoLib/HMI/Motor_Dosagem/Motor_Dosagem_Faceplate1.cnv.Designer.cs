/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/23/2026
 * Time: 1:58 PM
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.parameter1 = new SE.App2Base.Graphics.Parameter();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.stsRemoto_1 = new System.HMI.Symbols.Base.Label<bool>();
			this.label_11 = new System.HMI.Symbols.Base.Label<bool>();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.measures1 = new SE.App2Base.Graphics.Measures();
			this.btnModoManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnModoAutomatico = new NxtControl.GuiFramework.DrawnButton();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.Execute<bool>();
			this.btnDesligarManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigarManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnResetFalha = new NxtControl.GuiFramework.DrawnButton();
			this.fbkCmdManual = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// parameter1
			// 
			this.parameter1.BeginInit();
			this.parameter1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.5D, 8D, 8D);
			this.parameter1.Name = "parameter1";
			this.parameter1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("Faceplate2", NxtControl.GuiFramework.MouseButtonType.Click));
			this.parameter1.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(248D, 128D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(-67D, 128D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(0D, 54D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Modo operação";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(0D, 86D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Status";
			// 
			// stsRemoto_1
			// 
			this.stsRemoto_1.BeginInit();
			this.stsRemoto_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsRemoto_1.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.52666666666666662D, 0D, 0D, 0.76190476190476186D, 120D, 56D);
			this.stsRemoto_1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.stsRemoto_1.FontScale = false;
			this.stsRemoto_1.IsOnlyInput = true;
			this.stsRemoto_1.LeadingZeros = ((uint)(0u));
			this.stsRemoto_1.Name = "stsRemoto_1";
			this.stsRemoto_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "Local");
			propertyDictionary3.Add("Text", "Remoto");
			this.stsRemoto_1.Ranges.Clear();
			this.stsRemoto_1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.stsRemoto_1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "Local");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsRemoto_1.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsRemoto_1.TagName = "STS_REMOTO";
			this.stsRemoto_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsRemoto_1.EndInit();
			// 
			// label_11
			// 
			this.label_11.BeginInit();
			this.label_11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label_11.DecimalPlacesCount = ((uint)(2u));
			this.label_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.79333333333333333D, 0D, 0D, 0.76190476190476186D, 80D, 88D);
			this.label_11.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.label_11.FontScale = false;
			this.label_11.IsOnlyInput = true;
			this.label_11.LeadingZeros = ((uint)(0u));
			this.label_11.Name = "label_11";
			this.label_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "Manual");
			propertyDictionary6.Add("Text", "Automatico");
			this.label_11.Ranges.Clear();
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.label_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Text", "");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.label_11.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.label_11.TagName = "fbkStsAutomatico";
			this.label_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.label_11.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(8D)), ((float)(30D)), ((float)(30D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.ImageName = "SE.App2Base.HMI:libImages.maintenance_data_v2";
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("Faceplate3", NxtControl.GuiFramework.MouseButtonType.None));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// measures1
			// 
			this.measures1.BeginInit();
			this.measures1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.4999999999999993D, 0D, 0D, 1.4999999999999998D, 88D, 8D);
			this.measures1.Name = "measures1";
			this.measures1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("Faceplate4", NxtControl.GuiFramework.MouseButtonType.Click));
			this.measures1.EndInit();
			// 
			// btnModoManual
			// 
			this.btnModoManual.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(144D)), ((float)(80D)), ((float)(30D)));
			this.btnModoManual.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnModoManual.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnModoManual.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnModoManual.Name = "btnModoManual";
			this.btnModoManual.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnModoManual.Radius = 4D;
			this.btnModoManual.Text = "Manual";
			this.btnModoManual.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnModoManual.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnModoManual.Use3DEffect = false;
			this.btnModoManual.Click += new System.EventHandler(this.BtnModoManualClick);
			// 
			// btnModoAutomatico
			// 
			this.btnModoAutomatico.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(144D)), ((float)(80D)), ((float)(30D)));
			this.btnModoAutomatico.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnModoAutomatico.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnModoAutomatico.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnModoAutomatico.Name = "btnModoAutomatico";
			this.btnModoAutomatico.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnModoAutomatico.Radius = 4D;
			this.btnModoAutomatico.Text = "Automático";
			this.btnModoAutomatico.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnModoAutomatico.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnModoAutomatico.Use3DEffect = false;
			this.btnModoAutomatico.Click += new System.EventHandler(this.BtnModoAutomaticoClick);
			// 
			// fbkStsAutomatico
			// 
			this.fbkStsAutomatico.BeginInit();
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.fbkStsAutomatico.IsOnlyInput = true;
			this.fbkStsAutomatico.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbkStsAutomatico.Name = "fbkStsAutomatico";
			this.fbkStsAutomatico.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbkStsAutomatico.TagName = "fbkStsAutomatico";
			this.fbkStsAutomatico.Value = false;
			this.fbkStsAutomatico.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbkStsAutomaticoValueChanged);
			this.fbkStsAutomatico.EndInit();
			// 
			// btnDesligarManual
			// 
			this.btnDesligarManual.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(192D)), ((float)(80D)), ((float)(30D)));
			this.btnDesligarManual.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnDesligarManual.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnDesligarManual.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnDesligarManual.Name = "btnDesligarManual";
			this.btnDesligarManual.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnDesligarManual.Radius = 4D;
			this.btnDesligarManual.Text = "Desligar";
			this.btnDesligarManual.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnDesligarManual.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnDesligarManual.Use3DEffect = false;
			this.btnDesligarManual.Click += new System.EventHandler(this.BtnDesligarManualClick);
			// 
			// btnLigarManual
			// 
			this.btnLigarManual.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(192D)), ((float)(80D)), ((float)(30D)));
			this.btnLigarManual.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnLigarManual.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnLigarManual.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnLigarManual.Name = "btnLigarManual";
			this.btnLigarManual.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnLigarManual.Radius = 4D;
			this.btnLigarManual.Text = "Ligar";
			this.btnLigarManual.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnLigarManual.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnLigarManual.Use3DEffect = false;
			this.btnLigarManual.Click += new System.EventHandler(this.BtnLigarManualClick);
			// 
			// btnResetFalha
			// 
			this.btnResetFalha.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(239D)), ((float)(80D)), ((float)(30D)));
			this.btnResetFalha.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnResetFalha.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnResetFalha.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnResetFalha.Name = "btnResetFalha";
			this.btnResetFalha.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnResetFalha.Radius = 4D;
			this.btnResetFalha.Text = "Reset Falha";
			this.btnResetFalha.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnResetFalha.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnResetFalha.Use3DEffect = false;
			this.btnResetFalha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnResetFalhaMouseDown);
			this.btnResetFalha.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnResetFalhaMouseUp);
			// 
			// fbkCmdManual
			// 
			this.fbkCmdManual.BeginInit();
			this.fbkCmdManual.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 186D, 259D);
			this.fbkCmdManual.IsOnlyInput = true;
			this.fbkCmdManual.Location = new NxtControl.Drawing.PointF(186D, 259D);
			this.fbkCmdManual.Name = "fbkCmdManual";
			this.fbkCmdManual.Size = new NxtControl.Drawing.SizeF(100D, 20D);
			this.fbkCmdManual.TagName = "fbkCmdManual";
			this.fbkCmdManual.Value = false;
			this.fbkCmdManual.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbkCmdManualValueChanged);
			this.fbkCmdManual.EndInit();
			// 
			// Faceplate1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(200D)), ((float)(284D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.parameter1,
			this.line1,
			this.freeText1,
			this.freeText2,
			this.stsRemoto_1,
			this.label_11,
			this.drawnButton1,
			this.measures1,
			this.btnModoManual,
			this.btnModoAutomatico,
			this.fbkStsAutomatico,
			this.btnDesligarManual,
			this.btnLigarManual,
			this.btnResetFalha,
			this.fbkCmdManual});
			this.Size = new System.Drawing.Size(200, 284);

		}
		private SE.App2Base.Graphics.Parameter parameter1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Label<bool> stsRemoto_1;
		private System.HMI.Symbols.Base.Label<bool> label_11;
		private NxtControl.GuiFramework.DrawnButton btnDesligarManual;
		private NxtControl.GuiFramework.DrawnButton btnLigarManual;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.DrawnButton btnResetFalha;
		private SE.App2Base.Graphics.Measures measures1;
		private NxtControl.GuiFramework.DrawnButton btnModoManual;
		private NxtControl.GuiFramework.DrawnButton btnModoAutomatico;
		private System.HMI.Symbols.Base.Execute<bool> fbkStsAutomatico;
		private System.HMI.Symbols.Base.Execute<bool> fbkCmdManual;
		#endregion
	}
}
