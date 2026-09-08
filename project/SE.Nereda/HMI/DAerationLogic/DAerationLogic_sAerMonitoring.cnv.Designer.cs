/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/11/2026
 * Time: 11:35 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.DAerationLogic
{
	/// <summary>
	/// Summary description for sAerMonitoring.
	/// </summary>
	partial class sAerMonitoring
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.Y_100 = new NxtControl.GuiFramework.Line();
			this.X_100 = new NxtControl.GuiFramework.Line();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.Y_C_IN = new NxtControl.GuiFramework.Line();
			this.X_C_OUT = new NxtControl.GuiFramework.Line();
			this.Y_C3_IN = new NxtControl.GuiFramework.Line();
			this.Y_C2_IN = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.X_C_MAX = new NxtControl.GuiFramework.Line();
			this.C_MAX_Txt = new NxtControl.GuiFramework.FreeText();
			this.C_OUT_Txt = new NxtControl.GuiFramework.FreeText();
			this.C3_Txt = new NxtControl.GuiFramework.FreeText();
			this.C2_Txt = new NxtControl.GuiFramework.FreeText();
			this.C_IN_Txt = new NxtControl.GuiFramework.FreeText();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.iC_IN = new System.HMI.Symbols.Base.FreeText<float>();
			this.iC_OUT = new System.HMI.Symbols.Base.FreeText<float>();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.iC_MAX = new System.HMI.Symbols.Base.FreeText<float>();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.iC2_IN = new System.HMI.Symbols.Base.FreeText<float>();
			this.iC3_IN = new System.HMI.Symbols.Base.FreeText<float>();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.freeText17 = new NxtControl.GuiFramework.FreeText();
			this.freeText18 = new NxtControl.GuiFramework.FreeText();
			this.BL1OpCount = new System.HMI.Symbols.Base.FreeText<uint>();
			this.BL2OpCount = new System.HMI.Symbols.Base.FreeText<uint>();
			this.TotRunDurBl1Txt = new NxtControl.GuiFramework.FreeText();
			this.TotRunDurBl2Txt = new NxtControl.GuiFramework.FreeText();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(576D)), ((float)(288D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(60D, 264D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(60D, 48D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(60D, 264D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(468D, 264D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(57D)), ((float)(40D)), ((float)(6D)), ((float)(12D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(60D, 40D),
			new NxtControl.Drawing.PointF(57D, 52D),
			new NxtControl.Drawing.PointF(63D, 52D)});
			// 
			// Y_100
			// 
			this.Y_100.EndPoint = new NxtControl.Drawing.PointF(64D, 64D);
			this.Y_100.Name = "Y_100";
			this.Y_100.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Y_100.StartPoint = new NxtControl.Drawing.PointF(56D, 64D);
			// 
			// X_100
			// 
			this.X_100.EndPoint = new NxtControl.Drawing.PointF(452D, 268D);
			this.X_100.Name = "X_100";
			this.X_100.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.X_100.StartPoint = new NxtControl.Drawing.PointF(452D, 260D);
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(468D)), ((float)(261D)), ((float)(12D)), ((float)(6D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(480D, 264D),
			new NxtControl.Drawing.PointF(468D, 261D),
			new NxtControl.Drawing.PointF(468D, 267D)});
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 56D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "100 %";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(440D, 272D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "100 %";
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(464D, 64D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(64D, 64D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(452D, 264D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(452D, 56D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(64D, 164D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(56D, 164D);
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 156D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "50 %";
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(464D, 164D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(64D, 164D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(256D, 264D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(256D, 56D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(256D, 268D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(256D, 260D);
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(245D, 272D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "50 %";
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(64D, 92D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(56D, 92D);
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 84D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "86 %";
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(464D, 92D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(64D, 92D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(256D, 64D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(60D, 264D);
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(127D, 272D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "1 Blower";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(319D, 272D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "2 Blowers";
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(452D, 92D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(256D, 164D);
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 16D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Blower Capacity (%)";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(488D, 256D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Air Capacity SP";
			// 
			// Y_C_IN
			// 
			this.Y_C_IN.EndPoint = new NxtControl.Drawing.PointF(464D, 240D);
			this.Y_C_IN.Name = "Y_C_IN";
			this.Y_C_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.Y_C_IN.StartPoint = new NxtControl.Drawing.PointF(56D, 240D);
			// 
			// X_C_OUT
			// 
			this.X_C_OUT.EndPoint = new NxtControl.Drawing.PointF(448D, 268D);
			this.X_C_OUT.Name = "X_C_OUT";
			this.X_C_OUT.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.X_C_OUT.StartPoint = new NxtControl.Drawing.PointF(448D, 56D);
			// 
			// Y_C3_IN
			// 
			this.Y_C3_IN.EndPoint = new NxtControl.Drawing.PointF(464D, 224D);
			this.Y_C3_IN.Name = "Y_C3_IN";
			this.Y_C3_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(111)), ((byte)(49)), ((byte)(152))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Y_C3_IN.StartPoint = new NxtControl.Drawing.PointF(56D, 224D);
			// 
			// Y_C2_IN
			// 
			this.Y_C2_IN.EndPoint = new NxtControl.Drawing.PointF(464D, 184D);
			this.Y_C2_IN.Name = "Y_C2_IN";
			this.Y_C2_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Y_C2_IN.StartPoint = new NxtControl.Drawing.PointF(56D, 184D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line4,
			this.line1,
			this.line2,
			this.polygon1,
			this.Y_100,
			this.X_100,
			this.polygon2,
			this.freeText1,
			this.freeText2,
			this.line3,
			this.line5,
			this.freeText3,
			this.line6,
			this.line7,
			this.line8,
			this.freeText4,
			this.line10,
			this.freeText5,
			this.line11,
			this.line9,
			this.line12,
			this.freeText8,
			this.freeText9});
			this.group1.EndInit();
			// 
			// X_C_MAX
			// 
			this.X_C_MAX.EndPoint = new NxtControl.Drawing.PointF(320D, 268D);
			this.X_C_MAX.Name = "X_C_MAX";
			this.X_C_MAX.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(156)), ((byte)(12)), ((byte)(19))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.X_C_MAX.StartPoint = new NxtControl.Drawing.PointF(320D, 56D);
			// 
			// C_MAX_Txt
			// 
			this.C_MAX_Txt.Color = new NxtControl.Drawing.Color(((byte)(156)), ((byte)(12)), ((byte)(19)));
			this.C_MAX_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C_MAX_Txt.Location = new NxtControl.Drawing.PointF(300D, 40D);
			this.C_MAX_Txt.Name = "C_MAX_Txt";
			this.C_MAX_Txt.Text = "C MAX";
			// 
			// C_OUT_Txt
			// 
			this.C_OUT_Txt.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0)));
			this.C_OUT_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C_OUT_Txt.Location = new NxtControl.Drawing.PointF(428D, 40D);
			this.C_OUT_Txt.Name = "C_OUT_Txt";
			this.C_OUT_Txt.Text = "C OUT";
			// 
			// C3_Txt
			// 
			this.C3_Txt.Color = new NxtControl.Drawing.Color(((byte)(111)), ((byte)(49)), ((byte)(152)));
			this.C3_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C3_Txt.Location = new NxtControl.Drawing.PointF(472D, 216D);
			this.C3_Txt.Name = "C3_Txt";
			this.C3_Txt.Text = "C3";
			// 
			// C2_Txt
			// 
			this.C2_Txt.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66)));
			this.C2_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C2_Txt.Location = new NxtControl.Drawing.PointF(472D, 176D);
			this.C2_Txt.Name = "C2_Txt";
			this.C2_Txt.Text = "C2";
			// 
			// C_IN_Txt
			// 
			this.C_IN_Txt.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0)));
			this.C_IN_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C_IN_Txt.Location = new NxtControl.Drawing.PointF(472D, 232D);
			this.C_IN_Txt.Name = "C_IN_Txt";
			this.C_IN_Txt.Text = "C IN";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(304D)), ((float)(576D)), ((float)(128D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText6,
			this.freeText7,
			this.group1,
			this.X_C_OUT,
			this.Y_C_IN,
			this.Y_C3_IN,
			this.Y_C2_IN,
			this.X_C_MAX,
			this.C_MAX_Txt,
			this.C_OUT_Txt,
			this.C3_Txt,
			this.C2_Txt,
			this.C_IN_Txt});
			this.group2.EndInit();
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(16D, 312D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "C IN :";
			// 
			// iC_IN
			// 
			this.iC_IN.BeginInit();
			this.iC_IN.DecimalPlacesCount = ((uint)(2u));
			this.iC_IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 72D, 312D);
			this.iC_IN.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iC_IN.IsOnlyInput = true;
			this.iC_IN.Name = "iC_IN";
			this.iC_IN.Ranges.Clear();
			this.iC_IN.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.iC_IN.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.iC_IN.TagName = "iC_IN";
			this.iC_IN.TextAngle = 0F;
			this.iC_IN.EndInit();
			// 
			// iC_OUT
			// 
			this.iC_OUT.BeginInit();
			this.iC_OUT.DecimalPlacesCount = ((uint)(2u));
			this.iC_OUT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 72D, 336D);
			this.iC_OUT.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iC_OUT.IsOnlyInput = true;
			this.iC_OUT.Name = "iC_OUT";
			this.iC_OUT.Ranges.Clear();
			this.iC_OUT.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.iC_OUT.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.iC_OUT.TagName = "iC_OUT";
			this.iC_OUT.TextAngle = 0F;
			this.iC_OUT.EndInit();
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 336D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "C OUT :";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText12.Location = new NxtControl.Drawing.PointF(16D, 360D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "C MAX :";
			// 
			// iC_MAX
			// 
			this.iC_MAX.BeginInit();
			this.iC_MAX.DecimalPlacesCount = ((uint)(2u));
			this.iC_MAX.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 72D, 360D);
			this.iC_MAX.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iC_MAX.IsOnlyInput = true;
			this.iC_MAX.Name = "iC_MAX";
			this.iC_MAX.Ranges.Clear();
			this.iC_MAX.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary6));
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.iC_MAX.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.iC_MAX.TagName = "iC_MAX";
			this.iC_MAX.TextAngle = 0F;
			this.iC_MAX.EndInit();
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText13.Location = new NxtControl.Drawing.PointF(16D, 384D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "C 1 :";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText14.Location = new NxtControl.Drawing.PointF(16D, 408D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "C 3 :";
			// 
			// iC2_IN
			// 
			this.iC2_IN.BeginInit();
			this.iC2_IN.DecimalPlacesCount = ((uint)(2u));
			this.iC2_IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 56D, 384D);
			this.iC2_IN.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iC2_IN.IsOnlyInput = true;
			this.iC2_IN.Name = "iC2_IN";
			this.iC2_IN.Ranges.Clear();
			this.iC2_IN.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary8));
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.iC2_IN.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.iC2_IN.TagName = "iC2_IN";
			this.iC2_IN.TextAngle = 0F;
			this.iC2_IN.EndInit();
			// 
			// iC3_IN
			// 
			this.iC3_IN.BeginInit();
			this.iC3_IN.DecimalPlacesCount = ((uint)(2u));
			this.iC3_IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 56D, 408D);
			this.iC3_IN.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iC3_IN.IsOnlyInput = true;
			this.iC3_IN.Name = "iC3_IN";
			this.iC3_IN.Ranges.Clear();
			this.iC3_IN.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary10));
			propertyDictionary9.Add("Text", "${Value}");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.iC3_IN.Ranges.DefaultPropertyValues = propertyDictionary9;
			this.iC3_IN.TagName = "iC3_IN";
			this.iC3_IN.TextAngle = 0F;
			this.iC3_IN.EndInit();
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(152D, 432D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(152D, 304D);
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText15.Location = new NxtControl.Drawing.PointF(160D, 312D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Total Running Duration Blower 1 :";
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText16.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText16.Location = new NxtControl.Drawing.PointF(160D, 336D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Total Running Duration Blower 2 :";
			// 
			// freeText17
			// 
			this.freeText17.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText17.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText17.Location = new NxtControl.Drawing.PointF(160D, 360D);
			this.freeText17.Name = "freeText17";
			this.freeText17.Text = "Total Operation Blower 1 :";
			// 
			// freeText18
			// 
			this.freeText18.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText18.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText18.Location = new NxtControl.Drawing.PointF(160D, 384D);
			this.freeText18.Name = "freeText18";
			this.freeText18.Text = "Total Operation Blower 2 :";
			// 
			// BL1OpCount
			// 
			this.BL1OpCount.BeginInit();
			this.BL1OpCount.DecimalPlacesCount = ((uint)(2u));
			this.BL1OpCount.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 404D, 360D);
			this.BL1OpCount.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.BL1OpCount.IsOnlyInput = true;
			this.BL1OpCount.Name = "BL1OpCount";
			propertyDictionary11.Add("Text", "${Value}");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.BL1OpCount.Ranges.DefaultPropertyValues = propertyDictionary11;
			this.BL1OpCount.TagName = "BL1OpCount";
			this.BL1OpCount.TextAngle = 0F;
			this.BL1OpCount.EndInit();
			// 
			// BL2OpCount
			// 
			this.BL2OpCount.BeginInit();
			this.BL2OpCount.DecimalPlacesCount = ((uint)(2u));
			this.BL2OpCount.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 404D, 384D);
			this.BL2OpCount.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.BL2OpCount.IsOnlyInput = true;
			this.BL2OpCount.Name = "BL2OpCount";
			propertyDictionary12.Add("Text", "${Value}");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.BL2OpCount.Ranges.DefaultPropertyValues = propertyDictionary12;
			this.BL2OpCount.TagName = "BL2OpCount";
			this.BL2OpCount.TextAngle = 0F;
			this.BL2OpCount.EndInit();
			// 
			// TotRunDurBl1Txt
			// 
			this.TotRunDurBl1Txt.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.TotRunDurBl1Txt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.TotRunDurBl1Txt.Location = new NxtControl.Drawing.PointF(408D, 312D);
			this.TotRunDurBl1Txt.Name = "TotRunDurBl1Txt";
			this.TotRunDurBl1Txt.Text = "0h : 0min : 0s";
			// 
			// TotRunDurBl2Txt
			// 
			this.TotRunDurBl2Txt.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.TotRunDurBl2Txt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.TotRunDurBl2Txt.Location = new NxtControl.Drawing.PointF(408D, 336D);
			this.TotRunDurBl2Txt.Name = "TotRunDurBl2Txt";
			this.TotRunDurBl2Txt.Text = "0h : 0min : 0s";
			// 
			// sAerMonitoring
			// 
			this.AnchorPoint = new NxtControl.Drawing.PointF(-8D, -8D);
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.group2,
			this.freeText10,
			this.iC_IN,
			this.iC_OUT,
			this.freeText11,
			this.freeText12,
			this.iC_MAX,
			this.freeText13,
			this.freeText14,
			this.iC2_IN,
			this.iC3_IN,
			this.line13,
			this.freeText15,
			this.freeText16,
			this.freeText17,
			this.freeText18,
			this.BL1OpCount,
			this.BL2OpCount,
			this.TotRunDurBl1Txt,
			this.TotRunDurBl2Txt});
			this.SymbolSize = new System.Drawing.Size(616, 704);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line Y_100;
		private NxtControl.GuiFramework.Line X_100;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Line Y_C_IN;
		private NxtControl.GuiFramework.Line X_C_OUT;
		private NxtControl.GuiFramework.Line Y_C3_IN;
		private NxtControl.GuiFramework.Line Y_C2_IN;
		private NxtControl.GuiFramework.Line X_C_MAX;
		private NxtControl.GuiFramework.FreeText C_MAX_Txt;
		private NxtControl.GuiFramework.FreeText C_OUT_Txt;
		private NxtControl.GuiFramework.FreeText C3_Txt;
		private NxtControl.GuiFramework.FreeText C2_Txt;
		private NxtControl.GuiFramework.FreeText C_IN_Txt;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.FreeText freeText10;
		private System.HMI.Symbols.Base.FreeText<float> iC_IN;
		private System.HMI.Symbols.Base.FreeText<float> iC_OUT;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private System.HMI.Symbols.Base.FreeText<float> iC_MAX;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private System.HMI.Symbols.Base.FreeText<float> iC2_IN;
		private System.HMI.Symbols.Base.FreeText<float> iC3_IN;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.FreeText freeText16;
		private NxtControl.GuiFramework.FreeText freeText17;
		private NxtControl.GuiFramework.FreeText freeText18;
		private System.HMI.Symbols.Base.FreeText<uint> BL1OpCount;
		private System.HMI.Symbols.Base.FreeText<uint> BL2OpCount;
		private NxtControl.GuiFramework.FreeText TotRunDurBl1Txt;
		private NxtControl.GuiFramework.FreeText TotRunDurBl2Txt;
		#endregion
	}
}
