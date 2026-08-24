/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 7:07 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Summary description for sFeedInfluent.
	/// </summary>
	partial class sFeedInfluent
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.PUMP001 = new NxtControl.GuiFramework.FreeText();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.XV001 = new NxtControl.GuiFramework.FreeText();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.label5 = new NxtControl.GuiFramework.Label();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.sPump1 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.sDefault1 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.sDisplayPv41 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv4();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.sFreezeMode1 = new SE.Nereda.Symbols.FeedInfluentLogic.sFreezeMode();
			this.sPID1 = new SE.Nereda.Symbols.FeedInfluentLogic.sPID();
			this.sHiHiAlarms1 = new SE.Nereda.Symbols.FeedInfluentLogic.sHiHiAlarms();
			this.sReset1 = new SE.Nereda.Symbols.FeedInfluentLogic.sReset();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.sFreezWDuration1 = new SE.Nereda.Symbols.FeedInfluentLogic.sFreezWDuration();
			this.sDefault2 = new SE.Nereda.Symbols.E_DELAY_V_D.sDefault();
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(48D)), ((float)(0D)), ((float)(32D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(104D, 80D),
			new NxtControl.Drawing.PointF(104D, 48D)});
			this.pipe3.Width = 10;
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(104D)), ((float)(56D)), ((float)(304D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(92D, 408D),
			new NxtControl.Drawing.PointF(148D, 408D),
			new NxtControl.Drawing.PointF(148D, 372D),
			new NxtControl.Drawing.PointF(104D, 372D),
			new NxtControl.Drawing.PointF(104D, 104D)});
			this.pipe1.Width = 10;
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(328D)), ((float)(16D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(96D, 344D),
			new NxtControl.Drawing.PointF(112D, 344D),
			new NxtControl.Drawing.PointF(104D, 328D)});
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(112D, 328D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(96D, 328D);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(352D)), ((float)(72D)), ((float)(12D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(352D)), ((float)(228D)), ((float)(184D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(152D, 364D),
			new NxtControl.Drawing.PointF(236D, 364D),
			new NxtControl.Drawing.PointF(236D, 524D),
			new NxtControl.Drawing.PointF(32D, 524D),
			new NxtControl.Drawing.PointF(32D, 364D),
			new NxtControl.Drawing.PointF(80D, 364D),
			new NxtControl.Drawing.PointF(80D, 352D),
			new NxtControl.Drawing.PointF(20D, 352D),
			new NxtControl.Drawing.PointF(20D, 536D),
			new NxtControl.Drawing.PointF(248D, 536D),
			new NxtControl.Drawing.PointF(248D, 352D),
			new NxtControl.Drawing.PointF(152D, 352D)});
			// 
			// PUMP001
			// 
			this.PUMP001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.PUMP001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PUMP001.Location = new NxtControl.Drawing.PointF(40D, 480D);
			this.PUMP001.Name = "PUMP001";
			this.PUMP001.Text = "46 2 AP ifp 95 001";
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(108D)), ((float)(132D)), ((float)(168D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(108D, 132D),
			new NxtControl.Drawing.PointF(276D, 132D)});
			this.pipe2.Width = 10;
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(116D, 216D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "46 2 AP a-- 95 002";
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(99D)), ((float)(127D)), ((float)(10D)), ((float)(10D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// XV001
			// 
			this.XV001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV001.Location = new NxtControl.Drawing.PointF(112D, 84D);
			this.XV001.Name = "XV001";
			this.XV001.Text = "46 2 AP a-- 95 003";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(48D, 160D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(256D, 160D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(48D, 160D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(48D, 476D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(120D, 476D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(48D, 476D);
			// 
			// label5
			// 
			this.label5.AngleIgnore = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label5.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(100D)), ((float)(128D)), ((float)(16D)));
			this.label5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.label5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.label5.Name = "label5";
			this.label5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.label5.Text = "46 2 VB FT 95 001";
			this.label5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(120D, 472D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(120D, 476D);
			// 
			// sPump1
			// 
			this.sPump1.BeginInit();
			this.sPump1._iMotName = "Motor";
			this.sPump1._iUnit = "%";
			this.sPump1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 371D);
			this.sPump1.Name = "sPump1";
			this.sPump1.SecurityToken = ((uint)(4294967295u));
			this.sPump1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.sPump1.TagName = "Actuators.FeedInfluentPump01";
			this.sPump1.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iVlvName = "Valve";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 56D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Horizontal;
			this.sDefault1.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Hide;
			this.sDefault1.TagName = "Actuators.AirVentValve";
			this.sDefault1.EndInit();
			// 
			// sDisplayPv41
			// 
			this.sDisplayPv41.BeginInit();
			this.sDisplayPv41._iUnit = "m³/h";
			this.sDisplayPv41.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 208D, 116D);
			this.sDisplayPv41.Name = "sDisplayPv41";
			this.sDisplayPv41.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv41.TagName = "Sensors.FeedInfluentFlowPv";
			this.sDisplayPv41.EndInit();
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(118D)), ((float)(464D)), ((float)(4D)), ((float)(8D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(120D, 464D),
			new NxtControl.Drawing.PointF(118D, 472D),
			new NxtControl.Drawing.PointF(122D, 472D)});
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(256D, 128D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(256D, 160D);
			// 
			// sFreezeMode1
			// 
			this.sFreezeMode1.BeginInit();
			this.sFreezeMode1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 36D, 500D);
			this.sFreezeMode1.Name = "sFreezeMode1";
			this.sFreezeMode1.SecurityToken = ((uint)(4294967295u));
			this.sFreezeMode1.TagName = "InfluentFeedLogic.Feed_InfluentFeed";
			this.sFreezeMode1.EndInit();
			// 
			// sPID1
			// 
			this.sPID1.BeginInit();
			this.sPID1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 152D, 144D);
			this.sPID1.Name = "sPID1";
			this.sPID1.SecurityToken = ((uint)(4294967295u));
			this.sPID1.TagName = "InfluentFeedLogic.Feed_InfluentFeed";
			this.sPID1.EndInit();
			// 
			// sHiHiAlarms1
			// 
			this.sHiHiAlarms1.BeginInit();
			this.sHiHiAlarms1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 248D);
			this.sHiHiAlarms1.Name = "sHiHiAlarms1";
			this.sHiHiAlarms1.SecurityToken = ((uint)(4294967295u));
			this.sHiHiAlarms1.TagName = "InfluentFeedLogic.Feed_InfluentFeed";
			this.sHiHiAlarms1.EndInit();
			// 
			// sReset1
			// 
			this.sReset1.BeginInit();
			this.sReset1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3333333333333333D, 0D, 0D, 1.1641666666666668D, 168D, 368D);
			this.sReset1.Name = "sReset1";
			this.sReset1.SecurityToken = ((uint)(4294967295u));
			this.sReset1.TagName = "InfluentFeedLogic.Feed_InfluentFeed";
			this.sReset1.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sReset1,
			this.line3,
			this.pipe3,
			this.pipe1,
			this.polygon1,
			this.line1,
			this.rectangle1,
			this.polygon2,
			this.PUMP001,
			this.pipe2,
			this.freeText1,
			this.ellipse1,
			this.XV001,
			this.line2,
			this.line5,
			this.line6,
			this.label5,
			this.line7,
			this.sPump1,
			this.sDefault1,
			this.sDisplayPv41,
			this.polygon3,
			this.sFreezeMode1,
			this.sPID1,
			this.sHiHiAlarms1});
			this.group1.EndInit();
			// 
			// sFreezWDuration1
			// 
			this.sFreezWDuration1.BeginInit();
			this.sFreezWDuration1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 168D, 432D);
			this.sFreezWDuration1.Name = "sFreezWDuration1";
			this.sFreezWDuration1.SecurityToken = ((uint)(4294967295u));
			this.sFreezWDuration1.TagName = "InfluentFeedLogic.Feed_InfluentFeed";
			this.sFreezWDuration1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 48D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "InfluentFeedLogic.Feed_InfluentFeed.ValveControl.OpeningValveDur";
			this.sDefault2.EndInit();
			// 
			// sFeedInfluent
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.sFreezWDuration1,
			this.sDefault2});
			this.SymbolSize = new System.Drawing.Size(584, 672);

		}
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.FreeText PUMP001;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.FreeText XV001;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Label label5;
		private NxtControl.GuiFramework.Line line7;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump1;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv4 sDisplayPv41;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Line line3;
		private SE.Nereda.Symbols.FeedInfluentLogic.sFreezeMode sFreezeMode1;
		private SE.Nereda.Symbols.FeedInfluentLogic.sPID sPID1;
		private SE.Nereda.Symbols.FeedInfluentLogic.sHiHiAlarms sHiHiAlarms1;
		private NxtControl.GuiFramework.Group group1;
		private SE.Nereda.Symbols.FeedInfluentLogic.sReset sReset1;
		private SE.Nereda.Symbols.FeedInfluentLogic.sFreezWDuration sFreezWDuration1;
		private SE.Nereda.Symbols.E_DELAY_V_D.sDefault sDefault2;
		#endregion
	}
}
