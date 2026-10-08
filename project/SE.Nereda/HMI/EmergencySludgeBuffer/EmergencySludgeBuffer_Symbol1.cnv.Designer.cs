/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 9/18/2026
 * Time: 3:25 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencySludgeBuffer
{
	/// <summary>
	/// Summary description for Symbol1.
	/// </summary>
	partial class Symbol1
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line1 = new NxtControl.GuiFramework.Line();
			this.FeedRecS1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.WaitRecS2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.SDRecS3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.LLRecS4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Step4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle6 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle10 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle11 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle12 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.F_S1 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S2 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S3 = new NxtControl.GuiFramework.DrawnButton();
			this.F_S4 = new NxtControl.GuiFramework.DrawnButton();
			this.ReactorName = new NxtControl.GuiFramework.Rectangle();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.line14 = new NxtControl.GuiFramework.Line();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.Step1_Feed_1 = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step2_Wait = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step3_SludgeDischarge = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.Step4_SupernatantDischarge = new SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(112D, 272D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(112D, 96D);
			// 
			// FeedRecS1
			// 
			this.FeedRecS1.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(80D)), ((float)(168D)), ((float)(16D)));
			this.FeedRecS1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.FeedRecS1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.FeedRecS1.Name = "FeedRecS1";
			this.FeedRecS1.Text = "FEED";
			this.FeedRecS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WaitRecS2
			// 
			this.WaitRecS2.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(128D)), ((float)(168D)), ((float)(16D)));
			this.WaitRecS2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.WaitRecS2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.WaitRecS2.Name = "WaitRecS2";
			this.WaitRecS2.Text = "WAIT";
			this.WaitRecS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step1
			// 
			this.Step1.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(76D)), ((float)(24D)), ((float)(24D)));
			this.Step1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step1.Name = "Step1";
			// 
			// Step2
			// 
			this.Step2.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(124D)), ((float)(24D)), ((float)(24D)));
			this.Step2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step2.Name = "Step2";
			// 
			// SDRecS3
			// 
			this.SDRecS3.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(176D)), ((float)(168D)), ((float)(16D)));
			this.SDRecS3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.SDRecS3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.SDRecS3.Name = "SDRecS3";
			this.SDRecS3.Text = "SLUDGE DISCHARGE";
			this.SDRecS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step3
			// 
			this.Step3.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(172D)), ((float)(24D)), ((float)(24D)));
			this.Step3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step3.Name = "Step3";
			// 
			// LLRecS4
			// 
			this.LLRecS4.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(224D)), ((float)(168D)), ((float)(16D)));
			this.LLRecS4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.LLRecS4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.LLRecS4.Name = "LLRecS4";
			this.LLRecS4.Text = "SUPERNANT DISCHARGE";
			this.LLRecS4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Step4
			// 
			this.Step4.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(220D)), ((float)(24D)), ((float)(24D)));
			this.Step4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.Step4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Step4.Name = "Step4";
			// 
			// roundedRectangle6
			// 
			this.roundedRectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(80D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle6.Name = "roundedRectangle6";
			this.roundedRectangle6.Text = "S1";
			this.roundedRectangle6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle10
			// 
			this.roundedRectangle10.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(128D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle10.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle10.Name = "roundedRectangle10";
			this.roundedRectangle10.Text = "S2";
			this.roundedRectangle10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle11
			// 
			this.roundedRectangle11.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(176D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle11.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle11.Name = "roundedRectangle11";
			this.roundedRectangle11.Text = "S3";
			this.roundedRectangle11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle12
			// 
			this.roundedRectangle12.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(224D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.roundedRectangle12.Name = "roundedRectangle12";
			this.roundedRectangle12.Text = "S4";
			this.roundedRectangle12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(120D, 112D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(104D, 112D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(120D, 160D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(104D, 160D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(120D, 208D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(104D, 208D);
			// 
			// F_S1
			// 
			this.F_S1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(104D)), ((float)(24D)), ((float)(16D)));
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
			// 
			// F_S2
			// 
			this.F_S2.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(152D)), ((float)(24D)), ((float)(16D)));
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
			// 
			// F_S3
			// 
			this.F_S3.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(200D)), ((float)(24D)), ((float)(16D)));
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
			// 
			// F_S4
			// 
			this.F_S4.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(248D)), ((float)(24D)), ((float)(16D)));
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
			// 
			// ReactorName
			// 
			this.ReactorName.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(40D)), ((float)(184D)), ((float)(32D)));
			this.ReactorName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.ReactorName.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.ReactorName.Name = "ReactorName";
			this.ReactorName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ReactorName.Text = "Sludge Discharge";
			this.ReactorName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(72D, 56D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(80D, 56D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(72D, 56D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(72D, 344D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(288D, 56D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(288D, 344D);
			// 
			// line14
			// 
			this.line14.EndPoint = new NxtControl.Drawing.PointF(280D, 56D);
			this.line14.Name = "line14";
			this.line14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line14.StartPoint = new NxtControl.Drawing.PointF(288D, 56D);
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(72D, 344D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(288D, 344D);
			// 
			// Step1_Feed_1
			// 
			this.Step1_Feed_1.BeginInit();
			this.Step1_Feed_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 96D);
			this.Step1_Feed_1.Name = "Step1_Feed_1";
			this.Step1_Feed_1.SecurityToken = ((uint)(4294967295u));
			this.Step1_Feed_1.TagName = "Step1_Feed";
			this.Step1_Feed_1.EndInit();
			// 
			// Step2_Wait
			// 
			this.Step2_Wait.BeginInit();
			this.Step2_Wait.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 118D, 143D);
			this.Step2_Wait.Name = "Step2_Wait";
			this.Step2_Wait.SecurityToken = ((uint)(4294967295u));
			this.Step2_Wait.TagName = "Step2_Wait";
			this.Step2_Wait.EndInit();
			// 
			// Step3_SludgeDischarge
			// 
			this.Step3_SludgeDischarge.BeginInit();
			this.Step3_SludgeDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 192D);
			this.Step3_SludgeDischarge.Name = "Step3_SludgeDischarge";
			this.Step3_SludgeDischarge.SecurityToken = ((uint)(4294967295u));
			this.Step3_SludgeDischarge.TagName = "Step3_SludgeDischarge";
			this.Step3_SludgeDischarge.EndInit();
			// 
			// Step4_SupernatantDischarge
			// 
			this.Step4_SupernatantDischarge.BeginInit();
			this.Step4_SupernatantDischarge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 240D);
			this.Step4_SupernatantDischarge.Name = "Step4_SupernatantDischarge";
			this.Step4_SupernatantDischarge.SecurityToken = ((uint)(4294967295u));
			this.Step4_SupernatantDischarge.TagName = "Step4_SupernatantDischarge";
			this.Step4_SupernatantDischarge.EndInit();
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(120D, 256D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(104D, 256D);
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(296D)), ((float)(168D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSettings", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Step Settings";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// Symbol1
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
			this.roundedRectangle6,
			this.roundedRectangle10,
			this.roundedRectangle11,
			this.roundedRectangle12,
			this.line2,
			this.line3,
			this.line4,
			this.F_S1,
			this.F_S2,
			this.F_S3,
			this.F_S4,
			this.ReactorName,
			this.line10,
			this.line11,
			this.line13,
			this.line14,
			this.line15,
			this.Step1_Feed_1,
			this.Step2_Wait,
			this.Step3_SludgeDischarge,
			this.Step4_SupernatantDischarge,
			this.line5,
			this.drawnButton1});
			this.SymbolSize = new System.Drawing.Size(864, 632);

		}
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step2_Wait;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step3_SludgeDischarge;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step4_SupernatantDischarge;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.RoundedRectangle FeedRecS1;
		private NxtControl.GuiFramework.RoundedRectangle WaitRecS2;
		private NxtControl.GuiFramework.RoundedRectangle Step1;
		private NxtControl.GuiFramework.RoundedRectangle Step2;
		private NxtControl.GuiFramework.RoundedRectangle SDRecS3;
		private NxtControl.GuiFramework.RoundedRectangle Step3;
		private NxtControl.GuiFramework.RoundedRectangle LLRecS4;
		private NxtControl.GuiFramework.RoundedRectangle Step4;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle6;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle10;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle11;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle12;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.DrawnButton F_S1;
		private NxtControl.GuiFramework.DrawnButton F_S2;
		private NxtControl.GuiFramework.DrawnButton F_S3;
		private NxtControl.GuiFramework.DrawnButton F_S4;
		private NxtControl.GuiFramework.Rectangle ReactorName;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Line line14;
		private NxtControl.GuiFramework.Line line15;
		private SE.Nereda.Symbols.E_DELAY_V_D_ZERO.sDefault Step1_Feed_1;
		private NxtControl.GuiFramework.Line line5;
		#endregion
	}
}
