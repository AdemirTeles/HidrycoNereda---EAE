/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 10:10 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyReactor
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
			this.FeedRecS1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.WaitRecS2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.SDRecS3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.LLRecS4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.AerateRecS5 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step5 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle7 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle8 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle9 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step6 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step7 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step8 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.roundedRectangle6 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle10 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle11 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle12 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle13 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle14 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle15 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle16 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.F_S1 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S2 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S3 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S4 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S5 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S6 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S7 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S8 = new NxtControl.GuiFramework.DrawnButton();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.ReactorName = new NxtControl.GuiFramework.Rectangle();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.line14 = new NxtControl.GuiFramework.Line();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.Step1_Feed = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step2_Wait = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step3_SludgeDischarge = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step4_LowerLevel = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step6_Vent = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step7_SludgeDischarge = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step8_Wait = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step5_Aerate = new SE.Nereda.Symbols.COUNTER.sDefault();
			this.ReactorNotAv = new NxtControl.GuiFramework.Rectangle();
			// 
			// FeedRecS1
			// 
			this.FeedRecS1.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(80D)), ((float)(168D)), ((float)(16D)));
			this.FeedRecS1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(14)), ((byte)(218)), ((byte)(255))));
			this.FeedRecS1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.FeedRecS1.Name = "FeedRecS1";
			this.FeedRecS1.Text = "FEED";
			this.FeedRecS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WaitRecS2
			// 
			this.WaitRecS2.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(128D)), ((float)(168D)), ((float)(16D)));
			this.WaitRecS2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.WaitRecS2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.WaitRecS2.Name = "WaitRecS2";
			this.WaitRecS2.Text = "WAIT";
			this.WaitRecS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step1
			// 
			this.Step1.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(76D)), ((float)(24D)), ((float)(24D)));
			this.Step1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step1.Name = "Step1";
			// 
			// Step2
			// 
			this.Step2.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(124D)), ((float)(24D)), ((float)(24D)));
			this.Step2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step2.Name = "Step2";
			// 
			// SDRecS3
			// 
			this.SDRecS3.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(176D)), ((float)(168D)), ((float)(16D)));
			this.SDRecS3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.SDRecS3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.SDRecS3.Name = "SDRecS3";
			this.SDRecS3.Text = "SLUDGE DISCHARGE";
			this.SDRecS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step3
			// 
			this.Step3.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(172D)), ((float)(24D)), ((float)(24D)));
			this.Step3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step3.Name = "Step3";
			// 
			// LLRecS4
			// 
			this.LLRecS4.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(224D)), ((float)(168D)), ((float)(16D)));
			this.LLRecS4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.LLRecS4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.LLRecS4.Name = "LLRecS4";
			this.LLRecS4.Text = "LOWER LEVEL";
			this.LLRecS4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step4
			// 
			this.Step4.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(220D)), ((float)(24D)), ((float)(24D)));
			this.Step4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step4.Name = "Step4";
			// 
			// AerateRecS5
			// 
			this.AerateRecS5.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(272D)), ((float)(168D)), ((float)(16D)));
			this.AerateRecS5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.AerateRecS5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.AerateRecS5.Name = "AerateRecS5";
			this.AerateRecS5.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpCurrAerateTime", NxtControl.GuiFramework.MouseButtonType.Click));
			this.AerateRecS5.Text = "AERATE";
			this.AerateRecS5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step5
			// 
			this.Step5.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(268D)), ((float)(24D)), ((float)(24D)));
			this.Step5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step5.Name = "Step5";
			// 
			// roundedRectangle7
			// 
			this.roundedRectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(416D)), ((float)(168D)), ((float)(16D)));
			this.roundedRectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.roundedRectangle7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle7.Name = "roundedRectangle7";
			this.roundedRectangle7.Text = "WAIT";
			this.roundedRectangle7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle8
			// 
			this.roundedRectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(320D)), ((float)(168D)), ((float)(16D)));
			this.roundedRectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.roundedRectangle8.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle8.Name = "roundedRectangle8";
			this.roundedRectangle8.Text = "VENT";
			this.roundedRectangle8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle9
			// 
			this.roundedRectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(368D)), ((float)(168D)), ((float)(16D)));
			this.roundedRectangle9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.roundedRectangle9.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle9.Name = "roundedRectangle9";
			this.roundedRectangle9.Text = "SLUDGE DISCHARGE";
			this.roundedRectangle9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step6
			// 
			this.Step6.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(316D)), ((float)(24D)), ((float)(24D)));
			this.Step6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step6.Name = "Step6";
			// 
			// Step7
			// 
			this.Step7.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(364D)), ((float)(24D)), ((float)(24D)));
			this.Step7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step7.Name = "Step7";
			// 
			// Step8
			// 
			this.Step8.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(412D)), ((float)(24D)), ((float)(24D)));
			this.Step8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step8.Name = "Step8";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(224D, 480D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(224D, 96D);
			// 
			// roundedRectangle6
			// 
			this.roundedRectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(80D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle6.Name = "roundedRectangle6";
			this.roundedRectangle6.Text = "S1";
			this.roundedRectangle6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle10
			// 
			this.roundedRectangle10.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(128D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle10.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle10.Name = "roundedRectangle10";
			this.roundedRectangle10.Text = "S2";
			this.roundedRectangle10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle11
			// 
			this.roundedRectangle11.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(176D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle11.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle11.Name = "roundedRectangle11";
			this.roundedRectangle11.Text = "S3";
			this.roundedRectangle11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle12
			// 
			this.roundedRectangle12.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(224D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle12.Name = "roundedRectangle12";
			this.roundedRectangle12.Text = "S4";
			this.roundedRectangle12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle13
			// 
			this.roundedRectangle13.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(272D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle13.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle13.Name = "roundedRectangle13";
			this.roundedRectangle13.Text = "S5";
			this.roundedRectangle13.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle14
			// 
			this.roundedRectangle14.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(320D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle14.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle14.Name = "roundedRectangle14";
			this.roundedRectangle14.Text = "S6";
			this.roundedRectangle14.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle15
			// 
			this.roundedRectangle15.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(368D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle15.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle15.Name = "roundedRectangle15";
			this.roundedRectangle15.Text = "S7";
			this.roundedRectangle15.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle16
			// 
			this.roundedRectangle16.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(416D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle16.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle16.Name = "roundedRectangle16";
			this.roundedRectangle16.Text = "S8";
			this.roundedRectangle16.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(232D, 112D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(216D, 112D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(232D, 160D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(216D, 160D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(232D, 208D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(216D, 208D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(232D, 256D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(216D, 256D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(232D, 304D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(216D, 304D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(232D, 352D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(216D, 352D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(232D, 400D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(216D, 400D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(232D, 448D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(216D, 448D);
			// 
			// F_S1
			// 
			this.F_S1.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(104D)), ((float)(24D)), ((float)(16D)));
			this.F_S1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S1.Name = "F_S1";
			this.F_S1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S1.Radius = 4D;
			this.F_S1.Text = "F";
			this.F_S1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S1.Use3DEffect = false;
			this.F_S1.Click += new System.EventHandler(this.F_S1Click);
			// 
			// F_S2
			// 
			this.F_S2.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(152D)), ((float)(24D)), ((float)(16D)));
			this.F_S2.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S2.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S2.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S2.Name = "F_S2";
			this.F_S2.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S2.Radius = 4D;
			this.F_S2.Text = "F";
			this.F_S2.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S2.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S2.Use3DEffect = false;
			this.F_S2.Click += new System.EventHandler(this.F_S2Click);
			// 
			// F_S3
			// 
			this.F_S3.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(200D)), ((float)(24D)), ((float)(16D)));
			this.F_S3.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S3.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S3.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S3.Name = "F_S3";
			this.F_S3.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S3.Radius = 4D;
			this.F_S3.Text = "F";
			this.F_S3.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S3.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S3.Use3DEffect = false;
			this.F_S3.Click += new System.EventHandler(this.F_S3Click);
			// 
			// F_S4
			// 
			this.F_S4.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(248D)), ((float)(24D)), ((float)(16D)));
			this.F_S4.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S4.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S4.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S4.Name = "F_S4";
			this.F_S4.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S4.Radius = 4D;
			this.F_S4.Text = "F";
			this.F_S4.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S4.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S4.Use3DEffect = false;
			this.F_S4.Click += new System.EventHandler(this.F_S4Click);
			// 
			// F_S5
			// 
			this.F_S5.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(296D)), ((float)(24D)), ((float)(16D)));
			this.F_S5.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S5.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S5.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S5.Name = "F_S5";
			this.F_S5.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S5.Radius = 4D;
			this.F_S5.Text = "F";
			this.F_S5.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S5.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S5.Use3DEffect = false;
			this.F_S5.Click += new System.EventHandler(this.F_S5Click);
			// 
			// F_S6
			// 
			this.F_S6.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(344D)), ((float)(24D)), ((float)(16D)));
			this.F_S6.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S6.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S6.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S6.Name = "F_S6";
			this.F_S6.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S6.Radius = 4D;
			this.F_S6.Text = "F";
			this.F_S6.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S6.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S6.Use3DEffect = false;
			this.F_S6.Click += new System.EventHandler(this.F_S6Click);
			// 
			// F_S7
			// 
			this.F_S7.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(392D)), ((float)(24D)), ((float)(16D)));
			this.F_S7.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S7.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S7.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S7.Name = "F_S7";
			this.F_S7.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S7.Radius = 4D;
			this.F_S7.Text = "F";
			this.F_S7.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S7.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S7.Use3DEffect = false;
			this.F_S7.Click += new System.EventHandler(this.F_S7Click);
			// 
			// F_S8
			// 
			this.F_S8.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(440D)), ((float)(24D)), ((float)(16D)));
			this.F_S8.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.F_S8.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.F_S8.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.F_S8.Name = "F_S8";
			this.F_S8.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.F_S8.Radius = 4D;
			this.F_S8.Text = "F";
			this.F_S8.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.F_S8.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.F_S8.Use3DEffect = false;
			this.F_S8.Click += new System.EventHandler(this.F_S8Click);
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(464D)), ((float)(184D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSettings", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Steps Settings";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// ReactorName
			// 
			this.ReactorName.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(40D)), ((float)(184D)), ((float)(32D)));
			this.ReactorName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.ReactorName.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.ReactorName.Name = "ReactorName";
			this.ReactorName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ReactorName.Text = "Reactor Name";
			this.ReactorName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(184D, 56D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(192D, 56D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(184D, 56D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(184D, 496D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(384D, 56D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(384D, 496D);
			// 
			// line14
			// 
			this.line14.EndPoint = new NxtControl.Drawing.PointF(376D, 56D);
			this.line14.Name = "line14";
			this.line14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line14.StartPoint = new NxtControl.Drawing.PointF(384D, 56D);
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(184D, 496D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(384D, 496D);
			// 
			// Step1_Feed
			// 
			this.Step1_Feed.BeginInit();
			this.Step1_Feed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 96D);
			this.Step1_Feed.Name = "Step1_Feed";
			this.Step1_Feed.SecurityToken = ((uint)(4294967295u));
			this.Step1_Feed.TagName = "Step1_Feed";
			this.Step1_Feed.EndInit();
			// 
			// Step2_Wait
			// 
			this.Step2_Wait.BeginInit();
			this.Step2_Wait.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 144D);
			this.Step2_Wait.Name = "Step2_Wait";
			this.Step2_Wait.SecurityToken = ((uint)(4294967295u));
			this.Step2_Wait.TagName = "Step2_Wait";
			this.Step2_Wait.EndInit();
			// 
			// Step3_SludgeDischarge
			// 
			this.Step3_SludgeDischarge.BeginInit();
			this.Step3_SludgeDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 192D);
			this.Step3_SludgeDischarge.Name = "Step3_SludgeDischarge";
			this.Step3_SludgeDischarge.SecurityToken = ((uint)(4294967295u));
			this.Step3_SludgeDischarge.TagName = "Step3_SludgeDischarge";
			this.Step3_SludgeDischarge.EndInit();
			// 
			// Step4_LowerLevel
			// 
			this.Step4_LowerLevel.BeginInit();
			this.Step4_LowerLevel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 240D);
			this.Step4_LowerLevel.Name = "Step4_LowerLevel";
			this.Step4_LowerLevel.SecurityToken = ((uint)(4294967295u));
			this.Step4_LowerLevel.TagName = "Step4_LowerLevel";
			this.Step4_LowerLevel.EndInit();
			// 
			// Step6_Vent
			// 
			this.Step6_Vent.BeginInit();
			this.Step6_Vent.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 336D);
			this.Step6_Vent.Name = "Step6_Vent";
			this.Step6_Vent.SecurityToken = ((uint)(4294967295u));
			this.Step6_Vent.TagName = "Step6_Vent";
			this.Step6_Vent.EndInit();
			// 
			// Step7_SludgeDischarge
			// 
			this.Step7_SludgeDischarge.BeginInit();
			this.Step7_SludgeDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 384D);
			this.Step7_SludgeDischarge.Name = "Step7_SludgeDischarge";
			this.Step7_SludgeDischarge.SecurityToken = ((uint)(4294967295u));
			this.Step7_SludgeDischarge.TagName = "Step7_SludgeDischarge";
			this.Step7_SludgeDischarge.EndInit();
			// 
			// Step8_Wait
			// 
			this.Step8_Wait.BeginInit();
			this.Step8_Wait.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 432D);
			this.Step8_Wait.Name = "Step8_Wait";
			this.Step8_Wait.SecurityToken = ((uint)(4294967295u));
			this.Step8_Wait.TagName = "Step8_Wait";
			this.Step8_Wait.EndInit();
			// 
			// Step5_Aerate
			// 
			this.Step5_Aerate.BeginInit();
			this.Step5_Aerate.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 232D, 288D);
			this.Step5_Aerate.Name = "Step5_Aerate";
			this.Step5_Aerate.SecurityToken = ((uint)(4294967295u));
			this.Step5_Aerate.TagName = "Step5_Aerate";
			this.Step5_Aerate.EndInit();
			// 
			// ReactorNotAv
			// 
			this.ReactorNotAv.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(228D)), ((float)(168D)), ((float)(96D)));
			this.ReactorNotAv.Font = new NxtControl.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
			this.ReactorNotAv.Name = "ReactorNotAv";
			this.ReactorNotAv.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ReactorNotAv.Text = "Reactor Not Available";
			this.ReactorNotAv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.ReactorNotAv.TextColor = new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30)));
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.FeedRecS1,
			this.WaitRecS2,
			this.Step1,
			this.Step2,
			this.SDRecS3,
			this.Step3,
			this.LLRecS4,
			this.Step4,
			this.AerateRecS5,
			this.Step5,
			this.roundedRectangle7,
			this.roundedRectangle8,
			this.roundedRectangle9,
			this.Step6,
			this.Step7,
			this.Step8,
			this.roundedRectangle6,
			this.roundedRectangle10,
			this.roundedRectangle11,
			this.roundedRectangle12,
			this.roundedRectangle13,
			this.roundedRectangle14,
			this.roundedRectangle15,
			this.roundedRectangle16,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.line7,
			this.line8,
			this.line9,
			this.F_S1,
			this.F_S2,
			this.F_S3,
			this.F_S4,
			this.F_S5,
			this.F_S6,
			this.F_S7,
			this.F_S8,
			this.ReactorName,
			this.line10,
			this.line11,
			this.line13,
			this.line14,
			this.line15,
			this.Step1_Feed,
			this.Step2_Wait,
			this.Step3_SludgeDischarge,
			this.Step4_LowerLevel,
			this.Step6_Vent,
			this.Step7_SludgeDischarge,
			this.Step8_Wait,
			this.drawnButton1,
			this.Step5_Aerate,
			this.ReactorNotAv});
			this.SymbolSize = new System.Drawing.Size(920, 616);

		}
		private NxtControl.GuiFramework.RoundedRectangle FeedRecS1;
		private NxtControl.GuiFramework.RoundedRectangle WaitRecS2;
		private NxtControl.GuiFramework.RoundedRectangle Step1;
		private NxtControl.GuiFramework.RoundedRectangle Step2;
		private NxtControl.GuiFramework.RoundedRectangle SDRecS3;
		private NxtControl.GuiFramework.RoundedRectangle Step3;
		private NxtControl.GuiFramework.RoundedRectangle LLRecS4;
		private NxtControl.GuiFramework.RoundedRectangle Step4;
		private NxtControl.GuiFramework.RoundedRectangle AerateRecS5;
		private NxtControl.GuiFramework.RoundedRectangle Step5;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle7;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle8;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle9;
		private NxtControl.GuiFramework.RoundedRectangle Step6;
		private NxtControl.GuiFramework.RoundedRectangle Step7;
		private NxtControl.GuiFramework.RoundedRectangle Step8;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle6;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle10;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle11;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle12;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle13;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle14;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle15;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle16;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.DrawnButton F_S1;
		private NxtControl.GuiFramework.DrawnButton F_S2;
		private NxtControl.GuiFramework.DrawnButton F_S3;
		private NxtControl.GuiFramework.DrawnButton F_S4;
		private NxtControl.GuiFramework.DrawnButton F_S5;
		private NxtControl.GuiFramework.DrawnButton F_S6;
		private NxtControl.GuiFramework.DrawnButton F_S7;
		private NxtControl.GuiFramework.DrawnButton F_S8;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.Rectangle ReactorName;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Line line14;
		private NxtControl.GuiFramework.Line line15;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step1_Feed;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step2_Wait;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step3_SludgeDischarge;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step4_LowerLevel;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step6_Vent;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step7_SludgeDischarge;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step8_Wait;
		private SE.Nereda.Symbols.COUNTER.sDefault Step5_Aerate;
		private NxtControl.GuiFramework.Rectangle ReactorNotAv;
		#endregion
	}
}
