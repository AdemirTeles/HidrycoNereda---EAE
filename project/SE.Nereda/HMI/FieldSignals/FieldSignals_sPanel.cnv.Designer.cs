/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/3/2026
 * Time: 10:19 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
{
	/// <summary>
	/// Summary description for sPanel.
	/// </summary>
	partial class sPanel
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sPanel));
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.LampElectriCircuitFail = new NxtControl.GuiFramework.Ellipse();
			this.SwitchElectriCircuitFail = new NxtControl.GuiFramework.TwoStateButton();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.LampchSafetySwitchOff = new NxtControl.GuiFramework.Ellipse();
			this.SwitchSafetySwitchOff = new NxtControl.GuiFramework.TwoStateButton();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.LampFreqInverterFail = new NxtControl.GuiFramework.Ellipse();
			this.SwitchFreqInverterFail = new NxtControl.GuiFramework.TwoStateButton();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.LampRemote = new NxtControl.GuiFramework.Ellipse();
			this.SwitchRemote = new NxtControl.GuiFramework.TwoStateButton();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.LampAuto = new NxtControl.GuiFramework.Ellipse();
			this.SwitchAuto = new NxtControl.GuiFramework.TwoStateButton();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.LampPowerFb = new NxtControl.GuiFramework.Ellipse();
			this.SwitchPowerFb = new NxtControl.GuiFramework.TwoStateButton();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.LampAtvReady = new NxtControl.GuiFramework.Ellipse();
			this.SwitchAtvReady = new NxtControl.GuiFramework.TwoStateButton();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.SimAtvEta = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.PanelName = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.OverEn_ElectricCircuitFail = new System.HMI.Symbols.Base.SwitchButton();
			this.OverEn_SafetySwitchOff = new System.HMI.Symbols.Base.SwitchButton();
			this.OverEn_FrequencyInverterFail = new System.HMI.Symbols.Base.SwitchButton();
			this.OverEn_AtvReady = new System.HMI.Symbols.Base.SwitchButton();
			this.OverEn_RemoteSelect = new System.HMI.Symbols.Base.SwitchButton();
			this.OverEn_AutoSelect = new System.HMI.Symbols.Base.SwitchButton();
			this.OverEn_PowerFb = new System.HMI.Symbols.Base.SwitchButton();
			this.OverEn_AtvEta = new System.HMI.Symbols.Base.SwitchButton();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(392D)), ((float)(312D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(231)), ((byte)(231)), ((byte)(231))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.DiagonalLeftTop));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// LampElectriCircuitFail
			// 
			this.LampElectriCircuitFail.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(40D)), ((float)(24D)), ((float)(24D)));
			this.LampElectriCircuitFail.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.LampElectriCircuitFail.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LampElectriCircuitFail.Name = "LampElectriCircuitFail";
			// 
			// SwitchElectriCircuitFail
			// 
			this.SwitchElectriCircuitFail.Bounds = new NxtControl.Drawing.RectF(((float)(44D)), ((float)(80D)), ((float)(32D)), ((float)(32D)));
			this.SwitchElectriCircuitFail.ButtonPushedBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchElectriCircuitFail.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.SwitchElectriCircuitFail.FalseBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchElectriCircuitFail.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwitchElectriCircuitFail.ImageBytes = resources.GetString("SwitchElectriCircuitFail.ImageBytes");
			this.SwitchElectriCircuitFail.InnerBorderColor = new NxtControl.Drawing.Color("transparent");
			this.SwitchElectriCircuitFail.MouseDownImageBytes = resources.GetString("SwitchElectriCircuitFail.MouseDownImageBytes");
			this.SwitchElectriCircuitFail.Name = "SwitchElectriCircuitFail";
			this.SwitchElectriCircuitFail.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.SwitchElectriCircuitFail.Radius = 8D;
			this.SwitchElectriCircuitFail.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.SwitchElectriCircuitFail.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.SwitchElectriCircuitFail.TrueBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchElectriCircuitFail.Use3DEffect = false;
			this.SwitchElectriCircuitFail.CheckedChanged += new System.EventHandler(this.SwitchElectriCircuitFailCheckedChanged);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(120D)), ((float)(72D)), ((float)(24D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "Electri Circuit Fail";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle2.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(40D, 72D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "0";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(72D, 72D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "1";
			// 
			// LampchSafetySwitchOff
			// 
			this.LampchSafetySwitchOff.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(40D)), ((float)(24D)), ((float)(24D)));
			this.LampchSafetySwitchOff.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.LampchSafetySwitchOff.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LampchSafetySwitchOff.Name = "LampchSafetySwitchOff";
			// 
			// SwitchSafetySwitchOff
			// 
			this.SwitchSafetySwitchOff.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(80D)), ((float)(32D)), ((float)(32D)));
			this.SwitchSafetySwitchOff.ButtonPushedBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchSafetySwitchOff.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.SwitchSafetySwitchOff.FalseBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchSafetySwitchOff.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwitchSafetySwitchOff.ImageBytes = resources.GetString("SwitchSafetySwitchOff.ImageBytes");
			this.SwitchSafetySwitchOff.InnerBorderColor = new NxtControl.Drawing.Color("transparent");
			this.SwitchSafetySwitchOff.MouseDownImageBytes = resources.GetString("SwitchSafetySwitchOff.MouseDownImageBytes");
			this.SwitchSafetySwitchOff.Name = "SwitchSafetySwitchOff";
			this.SwitchSafetySwitchOff.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.SwitchSafetySwitchOff.Radius = 8D;
			this.SwitchSafetySwitchOff.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.SwitchSafetySwitchOff.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.SwitchSafetySwitchOff.TrueBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchSafetySwitchOff.Use3DEffect = false;
			this.SwitchSafetySwitchOff.CheckedChanged += new System.EventHandler(this.SwitchSafetySwitchOffCheckedChanged);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(120D)), ((float)(72D)), ((float)(24D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Text = "Safety Switch";
			this.rectangle3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle3.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(136D, 72D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "0";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(168D, 72D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "1";
			// 
			// LampFreqInverterFail
			// 
			this.LampFreqInverterFail.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(40D)), ((float)(24D)), ((float)(24D)));
			this.LampFreqInverterFail.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.LampFreqInverterFail.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LampFreqInverterFail.Name = "LampFreqInverterFail";
			// 
			// SwitchFreqInverterFail
			// 
			this.SwitchFreqInverterFail.Bounds = new NxtControl.Drawing.RectF(((float)(236D)), ((float)(80D)), ((float)(32D)), ((float)(32D)));
			this.SwitchFreqInverterFail.ButtonPushedBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchFreqInverterFail.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.SwitchFreqInverterFail.FalseBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchFreqInverterFail.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwitchFreqInverterFail.ImageBytes = resources.GetString("SwitchFreqInverterFail.ImageBytes");
			this.SwitchFreqInverterFail.InnerBorderColor = new NxtControl.Drawing.Color("transparent");
			this.SwitchFreqInverterFail.MouseDownImageBytes = resources.GetString("SwitchFreqInverterFail.MouseDownImageBytes");
			this.SwitchFreqInverterFail.Name = "SwitchFreqInverterFail";
			this.SwitchFreqInverterFail.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.SwitchFreqInverterFail.Radius = 8D;
			this.SwitchFreqInverterFail.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.SwitchFreqInverterFail.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.SwitchFreqInverterFail.TrueBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchFreqInverterFail.Use3DEffect = false;
			this.SwitchFreqInverterFail.CheckedChanged += new System.EventHandler(this.SwitchFreqInverterFailCheckedChanged);
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(216D)), ((float)(120D)), ((float)(72D)), ((float)(24D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Text = "Frequency Inverter Fail";
			this.rectangle4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle4.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(232D, 72D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "0";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(264D, 72D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "1";
			// 
			// LampRemote
			// 
			this.LampRemote.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(184D)), ((float)(24D)), ((float)(24D)));
			this.LampRemote.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.LampRemote.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LampRemote.Name = "LampRemote";
			// 
			// SwitchRemote
			// 
			this.SwitchRemote.Bounds = new NxtControl.Drawing.RectF(((float)(44D)), ((float)(224D)), ((float)(32D)), ((float)(32D)));
			this.SwitchRemote.ButtonPushedBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchRemote.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.SwitchRemote.FalseBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchRemote.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwitchRemote.ImageBytes = resources.GetString("SwitchRemote.ImageBytes");
			this.SwitchRemote.InnerBorderColor = new NxtControl.Drawing.Color("transparent");
			this.SwitchRemote.MouseDownImageBytes = resources.GetString("SwitchRemote.MouseDownImageBytes");
			this.SwitchRemote.Name = "SwitchRemote";
			this.SwitchRemote.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.SwitchRemote.Radius = 8D;
			this.SwitchRemote.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.SwitchRemote.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.SwitchRemote.TrueBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchRemote.Use3DEffect = false;
			this.SwitchRemote.CheckedChanged += new System.EventHandler(this.SwitchRemoteCheckedChanged);
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(264D)), ((float)(72D)), ((float)(24D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			this.rectangle5.Text = "Remote Mode";
			this.rectangle5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle5.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(40D, 216D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "0";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(72D, 216D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "1";
			// 
			// LampAuto
			// 
			this.LampAuto.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(184D)), ((float)(24D)), ((float)(24D)));
			this.LampAuto.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.LampAuto.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LampAuto.Name = "LampAuto";
			// 
			// SwitchAuto
			// 
			this.SwitchAuto.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(224D)), ((float)(32D)), ((float)(32D)));
			this.SwitchAuto.ButtonPushedBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchAuto.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.SwitchAuto.FalseBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchAuto.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwitchAuto.ImageBytes = resources.GetString("SwitchAuto.ImageBytes");
			this.SwitchAuto.InnerBorderColor = new NxtControl.Drawing.Color("transparent");
			this.SwitchAuto.MouseDownImageBytes = resources.GetString("SwitchAuto.MouseDownImageBytes");
			this.SwitchAuto.Name = "SwitchAuto";
			this.SwitchAuto.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.SwitchAuto.Radius = 8D;
			this.SwitchAuto.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.SwitchAuto.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.SwitchAuto.TrueBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchAuto.Use3DEffect = false;
			this.SwitchAuto.CheckedChanged += new System.EventHandler(this.SwitchAutoCheckedChanged);
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(264D)), ((float)(72D)), ((float)(24D)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			this.rectangle6.Text = "Auto Mode";
			this.rectangle6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle6.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText10.Location = new NxtControl.Drawing.PointF(136D, 216D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "0";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText11.Location = new NxtControl.Drawing.PointF(168D, 216D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "1";
			// 
			// LampPowerFb
			// 
			this.LampPowerFb.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(184D)), ((float)(24D)), ((float)(24D)));
			this.LampPowerFb.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.LampPowerFb.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LampPowerFb.Name = "LampPowerFb";
			// 
			// SwitchPowerFb
			// 
			this.SwitchPowerFb.Bounds = new NxtControl.Drawing.RectF(((float)(236D)), ((float)(224D)), ((float)(32D)), ((float)(32D)));
			this.SwitchPowerFb.ButtonPushedBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchPowerFb.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.SwitchPowerFb.FalseBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchPowerFb.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwitchPowerFb.ImageBytes = resources.GetString("SwitchPowerFb.ImageBytes");
			this.SwitchPowerFb.InnerBorderColor = new NxtControl.Drawing.Color("transparent");
			this.SwitchPowerFb.MouseDownImageBytes = resources.GetString("SwitchPowerFb.MouseDownImageBytes");
			this.SwitchPowerFb.Name = "SwitchPowerFb";
			this.SwitchPowerFb.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.SwitchPowerFb.Radius = 8D;
			this.SwitchPowerFb.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.SwitchPowerFb.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.SwitchPowerFb.TrueBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchPowerFb.Use3DEffect = false;
			this.SwitchPowerFb.CheckedChanged += new System.EventHandler(this.SwitchPowerFbCheckedChanged);
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(216D)), ((float)(264D)), ((float)(72D)), ((float)(24D)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			this.rectangle7.Text = "Power Status";
			this.rectangle7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle7.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText12.Location = new NxtControl.Drawing.PointF(232D, 216D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "0";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(264D, 216D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "1";
			// 
			// LampAtvReady
			// 
			this.LampAtvReady.Bounds = new NxtControl.Drawing.RectF(((float)(332D)), ((float)(40D)), ((float)(24D)), ((float)(24D)));
			this.LampAtvReady.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Dark));
			this.LampAtvReady.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.LampAtvReady.Name = "LampAtvReady";
			// 
			// SwitchAtvReady
			// 
			this.SwitchAtvReady.Bounds = new NxtControl.Drawing.RectF(((float)(328D)), ((float)(80D)), ((float)(32D)), ((float)(32D)));
			this.SwitchAtvReady.ButtonPushedBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchAtvReady.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.CheckBox;
			this.SwitchAtvReady.FalseBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchAtvReady.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwitchAtvReady.ImageBytes = resources.GetString("SwitchAtvReady.ImageBytes");
			this.SwitchAtvReady.InnerBorderColor = new NxtControl.Drawing.Color("transparent");
			this.SwitchAtvReady.MouseDownImageBytes = resources.GetString("SwitchAtvReady.MouseDownImageBytes");
			this.SwitchAtvReady.Name = "SwitchAtvReady";
			this.SwitchAtvReady.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.SwitchAtvReady.Radius = 8D;
			this.SwitchAtvReady.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.SwitchAtvReady.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.SwitchAtvReady.TrueBrush = new NxtControl.Drawing.Brush("Transparent");
			this.SwitchAtvReady.Use3DEffect = false;
			this.SwitchAtvReady.CheckedChanged += new System.EventHandler(this.SwitchAtvReadyCheckedChanged);
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(308D)), ((float)(120D)), ((float)(76D)), ((float)(24D)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			this.rectangle8.Text = "Drive Avaibility";
			this.rectangle8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle8.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText14.Location = new NxtControl.Drawing.PointF(324D, 72D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "0";
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText15.Location = new NxtControl.Drawing.PointF(356D, 72D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "1";
			// 
			// SimAtvEta
			// 
			this.SimAtvEta.BeginInit();
			this.SimAtvEta.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5066666666666666D, 0D, 0D, 1D, 308D, 224D);
			this.SimAtvEta.MaximumTag = null;
			this.SimAtvEta.MinimumTag = null;
			this.SimAtvEta.Name = "SimAtvEta";
			this.SimAtvEta.NumberBase = NxtControl.GuiFramework.NumberBase.Hexadecimal;
			this.SimAtvEta.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.SimAtvEta.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SimAtvEta.TagName = "OverrideV_AtvEta";
			this.SimAtvEta.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SimAtvEta.Value = ((ushort)(0));
			this.SimAtvEta.EndInit();
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(308D)), ((float)(264D)), ((float)(76D)), ((float)(24D)));
			this.rectangle9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			this.rectangle9.Text = "ATV ETA";
			this.rectangle9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle9.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// PanelName
			// 
			this.PanelName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.PanelName.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.PanelName.Location = new NxtControl.Drawing.PointF(16D, 10D);
			this.PanelName.Name = "PanelName";
			this.PanelName.Text = "Name";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(392D, 176D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(16D, 176D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(392D, 32D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(16D, 32D);
			// 
			// OverEn_ElectricCircuitFail
			// 
			this.OverEn_ElectricCircuitFail.BeginInit();
			this.OverEn_ElectricCircuitFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.53333333333333333D, 24D, 152D);
			this.OverEn_ElectricCircuitFail.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_ElectricCircuitFail.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_ElectricCircuitFail.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_ElectricCircuitFail.Name = "OverEn_ElectricCircuitFail";
			this.OverEn_ElectricCircuitFail.TagName = "EnOverride_ElectricCircuitFail";
			this.OverEn_ElectricCircuitFail.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_ElectricCircuitFail.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_ElectricCircuitFail.Value = false;
			this.OverEn_ElectricCircuitFail.EndInit();
			// 
			// OverEn_SafetySwitchOff
			// 
			this.OverEn_SafetySwitchOff.BeginInit();
			this.OverEn_SafetySwitchOff.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.53333333333333333D, 120D, 152D);
			this.OverEn_SafetySwitchOff.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_SafetySwitchOff.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_SafetySwitchOff.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_SafetySwitchOff.Name = "OverEn_SafetySwitchOff";
			this.OverEn_SafetySwitchOff.TagName = "EnOverride_SafetySwitchOff";
			this.OverEn_SafetySwitchOff.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_SafetySwitchOff.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_SafetySwitchOff.Value = false;
			this.OverEn_SafetySwitchOff.EndInit();
			// 
			// OverEn_FrequencyInverterFail
			// 
			this.OverEn_FrequencyInverterFail.BeginInit();
			this.OverEn_FrequencyInverterFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.53333333333333333D, 216D, 152D);
			this.OverEn_FrequencyInverterFail.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_FrequencyInverterFail.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_FrequencyInverterFail.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_FrequencyInverterFail.Name = "OverEn_FrequencyInverterFail";
			this.OverEn_FrequencyInverterFail.TagName = "EnOverride_FrequencyInverterFail";
			this.OverEn_FrequencyInverterFail.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_FrequencyInverterFail.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_FrequencyInverterFail.Value = false;
			this.OverEn_FrequencyInverterFail.EndInit();
			// 
			// OverEn_AtvReady
			// 
			this.OverEn_AtvReady.BeginInit();
			this.OverEn_AtvReady.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.95D, 0D, 0D, 0.53333333333333333D, 308D, 152D);
			this.OverEn_AtvReady.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvReady.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvReady.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_AtvReady.Name = "OverEn_AtvReady";
			this.OverEn_AtvReady.TagName = "EnOverride_AtvReady";
			this.OverEn_AtvReady.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvReady.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvReady.Value = false;
			this.OverEn_AtvReady.EndInit();
			// 
			// OverEn_RemoteSelect
			// 
			this.OverEn_RemoteSelect.BeginInit();
			this.OverEn_RemoteSelect.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.53333333333333333D, 24D, 296D);
			this.OverEn_RemoteSelect.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_RemoteSelect.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_RemoteSelect.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_RemoteSelect.Name = "OverEn_RemoteSelect";
			this.OverEn_RemoteSelect.TagName = "EnOverride_RemoteSelect";
			this.OverEn_RemoteSelect.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_RemoteSelect.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_RemoteSelect.Value = false;
			this.OverEn_RemoteSelect.EndInit();
			// 
			// OverEn_AutoSelect
			// 
			this.OverEn_AutoSelect.BeginInit();
			this.OverEn_AutoSelect.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.53333333333333333D, 120D, 296D);
			this.OverEn_AutoSelect.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AutoSelect.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AutoSelect.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_AutoSelect.Name = "OverEn_AutoSelect";
			this.OverEn_AutoSelect.TagName = "EnOverride_AutoSelect";
			this.OverEn_AutoSelect.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AutoSelect.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AutoSelect.Value = false;
			this.OverEn_AutoSelect.EndInit();
			// 
			// OverEn_PowerFb
			// 
			this.OverEn_PowerFb.BeginInit();
			this.OverEn_PowerFb.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.53333333333333333D, 216D, 296D);
			this.OverEn_PowerFb.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_PowerFb.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_PowerFb.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_PowerFb.Name = "OverEn_PowerFb";
			this.OverEn_PowerFb.TagName = "EnOverride_PowerFb";
			this.OverEn_PowerFb.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_PowerFb.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_PowerFb.Value = false;
			this.OverEn_PowerFb.EndInit();
			// 
			// OverEn_AtvEta
			// 
			this.OverEn_AtvEta.BeginInit();
			this.OverEn_AtvEta.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.53333333333333333D, 304D, 296D);
			this.OverEn_AtvEta.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvEta.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvEta.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OverEn_AtvEta.Name = "OverEn_AtvEta";
			this.OverEn_AtvEta.TagName = "EnOverride_AtvEta";
			this.OverEn_AtvEta.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvEta.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OverEn_AtvEta.Value = false;
			this.OverEn_AtvEta.EndInit();
			// 
			// sPanel
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.LampElectriCircuitFail,
			this.SwitchElectriCircuitFail,
			this.rectangle2,
			this.freeText2,
			this.freeText3,
			this.LampchSafetySwitchOff,
			this.SwitchSafetySwitchOff,
			this.rectangle3,
			this.freeText4,
			this.freeText5,
			this.LampFreqInverterFail,
			this.SwitchFreqInverterFail,
			this.rectangle4,
			this.freeText6,
			this.freeText7,
			this.LampRemote,
			this.SwitchRemote,
			this.rectangle5,
			this.freeText8,
			this.freeText9,
			this.LampAuto,
			this.SwitchAuto,
			this.rectangle6,
			this.freeText10,
			this.freeText11,
			this.LampPowerFb,
			this.SwitchPowerFb,
			this.rectangle7,
			this.freeText12,
			this.freeText13,
			this.LampAtvReady,
			this.SwitchAtvReady,
			this.rectangle8,
			this.freeText14,
			this.freeText15,
			this.SimAtvEta,
			this.rectangle9,
			this.PanelName,
			this.line1,
			this.line2,
			this.OverEn_ElectricCircuitFail,
			this.OverEn_SafetySwitchOff,
			this.OverEn_FrequencyInverterFail,
			this.OverEn_AtvReady,
			this.OverEn_RemoteSelect,
			this.OverEn_AutoSelect,
			this.OverEn_PowerFb,
			this.OverEn_AtvEta});
			this.SymbolSize = new System.Drawing.Size(424, 336);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Ellipse LampElectriCircuitFail;
		private NxtControl.GuiFramework.TwoStateButton SwitchElectriCircuitFail;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Ellipse LampchSafetySwitchOff;
		private NxtControl.GuiFramework.TwoStateButton SwitchSafetySwitchOff;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Ellipse LampFreqInverterFail;
		private NxtControl.GuiFramework.TwoStateButton SwitchFreqInverterFail;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Ellipse LampRemote;
		private NxtControl.GuiFramework.TwoStateButton SwitchRemote;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Ellipse LampAuto;
		private NxtControl.GuiFramework.TwoStateButton SwitchAuto;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.Ellipse LampPowerFb;
		private NxtControl.GuiFramework.TwoStateButton SwitchPowerFb;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.Ellipse LampAtvReady;
		private NxtControl.GuiFramework.TwoStateButton SwitchAtvReady;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText freeText15;
		private System.HMI.Symbols.Base.TextBox<ushort> SimAtvEta;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private NxtControl.GuiFramework.FreeText PanelName;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private System.HMI.Symbols.Base.SwitchButton OverEn_ElectricCircuitFail;
		private System.HMI.Symbols.Base.SwitchButton OverEn_SafetySwitchOff;
		private System.HMI.Symbols.Base.SwitchButton OverEn_FrequencyInverterFail;
		private System.HMI.Symbols.Base.SwitchButton OverEn_AtvReady;
		private System.HMI.Symbols.Base.SwitchButton OverEn_RemoteSelect;
		private System.HMI.Symbols.Base.SwitchButton OverEn_AutoSelect;
		private System.HMI.Symbols.Base.SwitchButton OverEn_PowerFb;
		private System.HMI.Symbols.Base.SwitchButton OverEn_AtvEta;
		#endregion
	}
}
