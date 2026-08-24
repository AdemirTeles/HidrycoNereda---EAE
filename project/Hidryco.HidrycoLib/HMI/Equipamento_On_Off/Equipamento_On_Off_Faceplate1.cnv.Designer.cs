/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/27/2026
 * Time: 12:04 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Equipamento_On_Off
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
			this.btnResetFalha = new NxtControl.GuiFramework.DrawnButton();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.Execute<bool>();
			this.btnAbrirManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnFecharManual = new NxtControl.GuiFramework.DrawnButton();
			this.fbkCmdOn = new System.HMI.Symbols.Base.Execute<bool>();
			this.fbkCmdOff = new System.HMI.Symbols.Base.Execute<bool>();
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
			this.line1.EndPoint = new NxtControl.Drawing.PointF(208D, 120D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(-67D, 120D);
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
			// btnResetFalha
			// 
			this.btnResetFalha.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(175D)), ((float)(80D)), ((float)(30D)));
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
			// btnAbrirManual
			// 
			this.btnAbrirManual.Bounds = new NxtControl.Drawing.RectF(((float)(116D)), ((float)(128D)), ((float)(80D)), ((float)(30D)));
			this.btnAbrirManual.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnAbrirManual.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnAbrirManual.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnAbrirManual.Name = "btnAbrirManual";
			this.btnAbrirManual.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnAbrirManual.Radius = 4D;
			this.btnAbrirManual.Text = "Abrir";
			this.btnAbrirManual.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnAbrirManual.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnAbrirManual.Use3DEffect = false;
			this.btnAbrirManual.Click += new System.EventHandler(this.BtnAbrirManualClick);
			// 
			// btnFecharManual
			// 
			this.btnFecharManual.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(128D)), ((float)(80D)), ((float)(30D)));
			this.btnFecharManual.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnFecharManual.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnFecharManual.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnFecharManual.Name = "btnFecharManual";
			this.btnFecharManual.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnFecharManual.Radius = 4D;
			this.btnFecharManual.Text = "Fechar";
			this.btnFecharManual.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnFecharManual.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnFecharManual.Use3DEffect = false;
			this.btnFecharManual.Click += new System.EventHandler(this.BtnFecharManualClick);
			// 
			// fbkCmdOn
			// 
			this.fbkCmdOn.BeginInit();
			this.fbkCmdOn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.fbkCmdOn.IsOnlyInput = true;
			this.fbkCmdOn.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbkCmdOn.Name = "fbkCmdOn";
			this.fbkCmdOn.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbkCmdOn.TagName = "fbkCmdOn";
			this.fbkCmdOn.Value = false;
			this.fbkCmdOn.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbkCmdOnValueChanged);
			this.fbkCmdOn.EndInit();
			// 
			// fbkCmdOff
			// 
			this.fbkCmdOff.BeginInit();
			this.fbkCmdOff.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 316D, 516D);
			this.fbkCmdOff.IsOnlyInput = true;
			this.fbkCmdOff.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbkCmdOff.Name = "fbkCmdOff";
			this.fbkCmdOff.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbkCmdOff.TagName = "fbkCmdOff";
			this.fbkCmdOff.Value = false;
			this.fbkCmdOff.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbkCmdOffValueChanged);
			this.fbkCmdOff.EndInit();
			// 
			// Faceplate1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(208D)), ((float)(216D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.parameter1,
			this.line1,
			this.freeText1,
			this.freeText2,
			this.stsRemoto_1,
			this.label_11,
			this.btnResetFalha,
			this.fbkStsAutomatico,
			this.btnAbrirManual,
			this.btnFecharManual,
			this.fbkCmdOn,
			this.fbkCmdOff});
			this.Size = new System.Drawing.Size(208, 216);

		}
		private SE.App2Base.Graphics.Parameter parameter1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Label<bool> stsRemoto_1;
		private System.HMI.Symbols.Base.Label<bool> label_11;
		private System.HMI.Symbols.Base.Execute<bool> fbkStsAutomatico;
		private NxtControl.GuiFramework.DrawnButton btnResetFalha;
		private NxtControl.GuiFramework.DrawnButton btnAbrirManual;
		private NxtControl.GuiFramework.DrawnButton btnFecharManual;
		private System.HMI.Symbols.Base.Execute<bool> fbkCmdOn;
		private System.HMI.Symbols.Base.Execute<bool> fbkCmdOff;
		#endregion
	}
}
