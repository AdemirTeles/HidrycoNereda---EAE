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
	partial class sGraph
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
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
			this.L1Blowers = new NxtControl.GuiFramework.Line();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.L2Blowers = new NxtControl.GuiFramework.Line();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.Y_C_OUT = new NxtControl.GuiFramework.Line();
			this.X_C_IN = new NxtControl.GuiFramework.Line();
			this.Y_C3_IN = new NxtControl.GuiFramework.Line();
			this.Y_C2_IN = new NxtControl.GuiFramework.Line();
			this.X_C_MAX = new NxtControl.GuiFramework.Line();
			this.C_MAX_Txt = new NxtControl.GuiFramework.FreeText();
			this.C_IN_Txt = new NxtControl.GuiFramework.FreeText();
			this.C3_Txt = new NxtControl.GuiFramework.FreeText();
			this.C2_Txt = new NxtControl.GuiFramework.FreeText();
			this.C_OUT_Txt = new NxtControl.GuiFramework.FreeText();
			this.group1 = new NxtControl.GuiFramework.Group();
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
			// L1Blowers
			// 
			this.L1Blowers.EndPoint = new NxtControl.Drawing.PointF(256D, 64D);
			this.L1Blowers.Name = "L1Blowers";
			this.L1Blowers.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.L1Blowers.StartPoint = new NxtControl.Drawing.PointF(60D, 264D);
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(424D, 16D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "1 Blower";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(504D, 16D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "2 Blowers";
			// 
			// L2Blowers
			// 
			this.L2Blowers.EndPoint = new NxtControl.Drawing.PointF(452D, 92D);
			this.L2Blowers.Name = "L2Blowers";
			this.L2Blowers.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.L2Blowers.StartPoint = new NxtControl.Drawing.PointF(256D, 264D);
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
			this.freeText9.Location = new NxtControl.Drawing.PointF(488D, 272D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Air Capacity SP";
			// 
			// Y_C_OUT
			// 
			this.Y_C_OUT.EndPoint = new NxtControl.Drawing.PointF(464D, 240D);
			this.Y_C_OUT.Name = "Y_C_OUT";
			this.Y_C_OUT.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Dash);
			this.Y_C_OUT.StartPoint = new NxtControl.Drawing.PointF(56D, 240D);
			// 
			// X_C_IN
			// 
			this.X_C_IN.EndPoint = new NxtControl.Drawing.PointF(176D, 268D);
			this.X_C_IN.Name = "X_C_IN";
			this.X_C_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Dash);
			this.X_C_IN.StartPoint = new NxtControl.Drawing.PointF(176D, 56D);
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
			// X_C_MAX
			// 
			this.X_C_MAX.EndPoint = new NxtControl.Drawing.PointF(256D, 268D);
			this.X_C_MAX.Name = "X_C_MAX";
			this.X_C_MAX.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(156)), ((byte)(12)), ((byte)(19))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.X_C_MAX.StartPoint = new NxtControl.Drawing.PointF(256D, 56D);
			// 
			// C_MAX_Txt
			// 
			this.C_MAX_Txt.Color = new NxtControl.Drawing.Color(((byte)(156)), ((byte)(12)), ((byte)(19)));
			this.C_MAX_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C_MAX_Txt.Location = new NxtControl.Drawing.PointF(244D, 40D);
			this.C_MAX_Txt.Name = "C_MAX_Txt";
			this.C_MAX_Txt.Text = "C MAX";
			// 
			// C_IN_Txt
			// 
			this.C_IN_Txt.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0)));
			this.C_IN_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C_IN_Txt.Location = new NxtControl.Drawing.PointF(162D, 40D);
			this.C_IN_Txt.Name = "C_IN_Txt";
			this.C_IN_Txt.Text = "C IN";
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
			// C_OUT_Txt
			// 
			this.C_OUT_Txt.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0)));
			this.C_OUT_Txt.Font = new NxtControl.Drawing.Font("LabelFont");
			this.C_OUT_Txt.Location = new NxtControl.Drawing.PointF(472D, 232D);
			this.C_OUT_Txt.Name = "C_OUT_Txt";
			this.C_OUT_Txt.Text = "C OUT";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText6,
			this.freeText7,
			this.C_MAX_Txt,
			this.C_IN_Txt,
			this.C3_Txt,
			this.C2_Txt,
			this.C_OUT_Txt,
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
			this.freeText8,
			this.freeText9,
			this.Y_C2_IN,
			this.Y_C3_IN,
			this.Y_C_OUT,
			this.L1Blowers,
			this.X_C_IN,
			this.X_C_MAX,
			this.L2Blowers});
			this.group1.EndInit();
			// 
			// sGraph
			// 
			this.AnchorPoint = new NxtControl.Drawing.PointF(-8D, -8D);
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(616, 368);

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
		private NxtControl.GuiFramework.Line L1Blowers;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Line L2Blowers;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Line Y_C_OUT;
		private NxtControl.GuiFramework.Line X_C_IN;
		private NxtControl.GuiFramework.Line Y_C3_IN;
		private NxtControl.GuiFramework.Line Y_C2_IN;
		private NxtControl.GuiFramework.Line X_C_MAX;
		private NxtControl.GuiFramework.FreeText C_MAX_Txt;
		private NxtControl.GuiFramework.FreeText C_IN_Txt;
		private NxtControl.GuiFramework.FreeText C3_Txt;
		private NxtControl.GuiFramework.FreeText C2_Txt;
		private NxtControl.GuiFramework.FreeText C_OUT_Txt;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
