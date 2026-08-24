/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 03/03/2026
 * Tempo: 09:28
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Canal_UV
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
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.line18 = new NxtControl.GuiFramework.Line();
			this.line21 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.stsLowWaterLevelCondition = new System.HMI.Symbols.Base.Execute<bool>();
			this.boiaLoff = new NxtControl.GuiFramework.Group();
			this.boiaLon = new NxtControl.GuiFramework.Group();
			this.Bank1 = new Hidryco.HidrycoLib.Symbols.Bank.sDefault();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(173D)), ((float)(91D)), ((float)(330D)), ((float)(148D)));
			this.polygon2.Closed = true;
			this.polygon2.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.polygon2.FillPercent = 70F;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(173D, 91D),
			new NxtControl.Drawing.PointF(173D, 218.14093959731542D),
			new NxtControl.Drawing.PointF(223.30487804878055D, 218.14093959731542D),
			new NxtControl.Drawing.PointF(223.30487804878055D, 162.51677852348993D),
			new NxtControl.Drawing.PointF(390.31707317073165D, 162.51677852348993D),
			new NxtControl.Drawing.PointF(406.41463414634154D, 154.57046979865768D),
			new NxtControl.Drawing.PointF(446.65853658536571D, 154.57046979865768D),
			new NxtControl.Drawing.PointF(446.65853658536571D, 239D),
			new NxtControl.Drawing.PointF(503D, 239D),
			new NxtControl.Drawing.PointF(503D, 91D),
			new NxtControl.Drawing.PointF(173D, 91D)});
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.line2,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.polygon1,
			this.line7});
			this.group1.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(171D, 216D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 6F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(171D, 88D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(505D, 237D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 6F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(505D, 88D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(168D, 217D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(230D, 217D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(227D, 215D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 6F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(227D, 159D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(229D, 162D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 6F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(443D, 162D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(445D, 236D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 6F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(445D, 152D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(391D)), ((float)(152D)), ((float)(56D)), ((float)(8D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(391D, 160D),
			new NxtControl.Drawing.PointF(407D, 152D),
			new NxtControl.Drawing.PointF(447D, 152D),
			new NxtControl.Drawing.PointF(447D, 160D)});
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(442D, 238D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(508D, 238D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.group1});
			this.group2.EndInit();
			// 
			// line18
			// 
			this.line18.EndPoint = new NxtControl.Drawing.PointF(168D, 176D);
			this.line18.Name = "line18";
			this.line18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line18.StartPoint = new NxtControl.Drawing.PointF(128D, 176D);
			// 
			// line21
			// 
			this.line21.EndPoint = new NxtControl.Drawing.PointF(559D, 176D);
			this.line21.Name = "line21";
			this.line21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line21.StartPoint = new NxtControl.Drawing.PointF(508D, 176D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(367D, 110.78787862131216D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(371D, 128.36363592569705D);
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(360D)), ((float)(100D)), ((float)(12D)), ((float)(10.181818008422852D)));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(367D, 145.84727201938315D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(371D, 127.9999995676753D);
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(360D)), ((float)(145.25091552734375D)), ((float)(12D)), ((float)(10.385454177856445D)));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// stsLowWaterLevelCondition
			// 
			this.stsLowWaterLevelCondition.BeginInit();
			this.stsLowWaterLevelCondition.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsLowWaterLevelCondition.IsOnlyInput = true;
			this.stsLowWaterLevelCondition.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsLowWaterLevelCondition.Name = "stsLowWaterLevelCondition";
			this.stsLowWaterLevelCondition.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsLowWaterLevelCondition.TagName = "stsLowWaterLevelCondition";
			this.stsLowWaterLevelCondition.Value = false;
			this.stsLowWaterLevelCondition.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsLowWaterLevelConditionValueChanged);
			this.stsLowWaterLevelCondition.EndInit();
			// 
			// boiaLoff
			// 
			this.boiaLoff.BeginInit();
			this.boiaLoff.Name = "boiaLoff";
			this.boiaLoff.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line9,
			this.ellipse1});
			this.boiaLoff.EndInit();
			// 
			// boiaLon
			// 
			this.boiaLon.BeginInit();
			this.boiaLon.Name = "boiaLon";
			this.boiaLon.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line8,
			this.ellipse2});
			this.boiaLon.EndInit();
			// 
			// Bank1
			// 
			this.Bank1.BeginInit();
			this.Bank1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 103D);
			this.Bank1.Name = "Bank1";
			this.Bank1.SecurityToken = ((uint)(4294967295u));
			this.Bank1.TagName = "Bank1";
			this.Bank1.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(124D)), ((float)(8D)), ((float)(8D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2,
			this.line18,
			this.line21,
			this.stsLowWaterLevelCondition,
			this.Bank1,
			this.boiaLoff,
			this.boiaLon,
			this.rectangle1});
			this.SymbolSize = new System.Drawing.Size(700, 404);

		}
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Line line18;
		private NxtControl.GuiFramework.Line line21;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Group boiaLoff;
		private NxtControl.GuiFramework.Group boiaLon;
		private System.HMI.Symbols.Base.Execute<bool> stsLowWaterLevelCondition;
		private Hidryco.HidrycoLib.Symbols.Bank.sDefault Bank1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
