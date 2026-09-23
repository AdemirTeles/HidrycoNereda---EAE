/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/13/2026
 * Time: 5:41 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sInfluentFeed2
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sShowLevel1 = new SE.Nereda.Symbols.AnalogInput.sShowLevel();
			this.polygon10 = new NxtControl.GuiFramework.Polygon();
			this.sPump1 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.sPump2 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.sPump3 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.sMotorVs2 = new SE.Nereda.Symbols.Motor_VS.sMotorVs();
			this.sMotorVs3 = new SE.Nereda.Symbols.Motor_VS.sMotorVs();
			this.sMixer2 = new SE.Nereda.Symbols.MixerLogic.sMixer();
			this.pipe15 = new NxtControl.GuiFramework.Pipe();
			this.pipe16 = new NxtControl.GuiFramework.Pipe();
			this.sMixer3 = new SE.Nereda.Symbols.MixerLogic.sMixer();
			this.pipe17 = new NxtControl.GuiFramework.Pipe();
			this.pipe18 = new NxtControl.GuiFramework.Pipe();
			this.pipe19 = new NxtControl.GuiFramework.Pipe();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.sPvBarVer2 = new SE.Nereda.Symbols.AnalogInput.sPvBarVer();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.group4 = new NxtControl.GuiFramework.Group();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.group5 = new NxtControl.GuiFramework.Group();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.group3 = new NxtControl.GuiFramework.Group();
			this.group6 = new NxtControl.GuiFramework.Group();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.pipe5 = new NxtControl.GuiFramework.Pipe();
			this.pipe6 = new NxtControl.GuiFramework.Pipe();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.pipe7 = new NxtControl.GuiFramework.Pipe();
			this.pipe8 = new NxtControl.GuiFramework.Pipe();
			this.group7 = new NxtControl.GuiFramework.Group();
			this.group8 = new NxtControl.GuiFramework.Group();
			this.pipe9 = new NxtControl.GuiFramework.Pipe();
			this.sDisplayPv41 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv4();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.line14 = new NxtControl.GuiFramework.Line();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.line16 = new NxtControl.GuiFramework.Line();
			this.line17 = new NxtControl.GuiFramework.Line();
			this.line18 = new NxtControl.GuiFramework.Line();
			this.polygon8 = new NxtControl.GuiFramework.Polygon();
			this.polygon9 = new NxtControl.GuiFramework.Polygon();
			this.sPID2 = new SE.Nereda.Symbols.FeedReactorLogic.sPID();
			// 
			// sShowLevel1
			// 
			this.sShowLevel1.BeginInit();
			this.sShowLevel1.DesignMatrix = new NxtControl.Drawing.Matrix2D(3.6814159292035407D, 0D, 0D, 0.77333333333333332D, 160D, 256D);
			this.sShowLevel1.Name = "sShowLevel1";
			this.sShowLevel1.SecurityToken = ((uint)(4294967295u));
			this.sShowLevel1.TagName = "Sensors.LevelPvInfluentBuffer";
			this.sShowLevel1.EndInit();
			// 
			// polygon10
			// 
			this.polygon10.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(248D)), ((float)(864D)), ((float)(256D)));
			this.polygon10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.polygon10.Closed = true;
			this.polygon10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon10.Name = "polygon10";
			this.polygon10.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(144D, 248D),
			new NxtControl.Drawing.PointF(144D, 504D),
			new NxtControl.Drawing.PointF(1008D, 504D),
			new NxtControl.Drawing.PointF(1008D, 248D),
			new NxtControl.Drawing.PointF(992D, 248D),
			new NxtControl.Drawing.PointF(992D, 488D),
			new NxtControl.Drawing.PointF(160D, 488D),
			new NxtControl.Drawing.PointF(160D, 248D)});
			// 
			// sPump1
			// 
			this.sPump1.BeginInit();
			this.sPump1._iMotName = "P4003";
			this.sPump1._iUnit = "%";
			this.sPump1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 577D, 392D);
			this.sPump1.Name = "sPump1";
			this.sPump1.SecurityToken = ((uint)(4294967295u));
			this.sPump1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Show;
			this.sPump1.TagName = "Actuators.FeedReactorPump01";
			this.sPump1.EndInit();
			// 
			// sPump2
			// 
			this.sPump2.BeginInit();
			this.sPump2._iMotName = "P4002";
			this.sPump2._iUnit = "%";
			this.sPump2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 431D, 392D);
			this.sPump2.Name = "sPump2";
			this.sPump2.SecurityToken = ((uint)(4294967295u));
			this.sPump2.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Show;
			this.sPump2.TagName = "Actuators.FeedReactorPump02";
			this.sPump2.EndInit();
			// 
			// sPump3
			// 
			this.sPump3.BeginInit();
			this.sPump3._iMotName = "P4001";
			this.sPump3._iUnit = "%";
			this.sPump3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 286D, 392D);
			this.sPump3.Name = "sPump3";
			this.sPump3.SecurityToken = ((uint)(4294967295u));
			this.sPump3.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Show;
			this.sPump3.TagName = "Actuators.FeedReactorPump03";
			this.sPump3.EndInit();
			// 
			// sMotorVs2
			// 
			this.sMotorVs2.BeginInit();
			this.sMotorVs2._iMotName = "P4005A";
			this.sMotorVs2._iUnit = "%";
			this.sMotorVs2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 166D, 256D);
			this.sMotorVs2.Name = "sMotorVs2";
			this.sMotorVs2.SecurityToken = ((uint)(4294967295u));
			this.sMotorVs2.StateTextPosition = SE.Nereda.Symbols.Motor_VS.sMotorVs.StateTextPositionOption.Horizontal;
			this.sMotorVs2.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sMotorVs.SymbolNameDisplayOption.Show;
			this.sMotorVs2.TagName = "Actuators.Mixer01";
			this.sMotorVs2.EndInit();
			// 
			// sMotorVs3
			// 
			this.sMotorVs3.BeginInit();
			this.sMotorVs3._iMotName = "P4005B";
			this.sMotorVs3._iUnit = "%";
			this.sMotorVs3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 696D, 256D);
			this.sMotorVs3.Name = "sMotorVs3";
			this.sMotorVs3.SecurityToken = ((uint)(4294967295u));
			this.sMotorVs3.StateTextPosition = SE.Nereda.Symbols.Motor_VS.sMotorVs.StateTextPositionOption.Horizontal;
			this.sMotorVs3.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sMotorVs.SymbolNameDisplayOption.Show;
			this.sMotorVs3.TagName = "Actuators.Mixer02";
			this.sMotorVs3.EndInit();
			// 
			// sMixer2
			// 
			this.sMixer2.BeginInit();
			this.sMixer2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 198D, 416D);
			this.sMixer2.Name = "sMixer2";
			this.sMixer2.SecurityToken = ((uint)(4294967295u));
			this.sMixer2.TagName = "InfluentFeedLogic.Mixer01Logic";
			this.sMixer2.EndInit();
			// 
			// pipe15
			// 
			this.pipe15.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(320D)), ((float)(0D)), ((float)(128D)));
			this.pipe15.InnerColor = new NxtControl.Drawing.Color(((byte)(246)), ((byte)(234)), ((byte)(210)));
			this.pipe15.Name = "pipe15";
			this.pipe15.OuterColor = new NxtControl.Drawing.Color(((byte)(147)), ((byte)(139)), ((byte)(125)));
			this.pipe15.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(224D, 320D),
			new NxtControl.Drawing.PointF(224D, 448D)});
			this.pipe15.Width = 5;
			// 
			// pipe16
			// 
			this.pipe16.Bounds = new NxtControl.Drawing.RectF(((float)(754D)), ((float)(320D)), ((float)(0D)), ((float)(128D)));
			this.pipe16.InnerColor = new NxtControl.Drawing.Color(((byte)(246)), ((byte)(234)), ((byte)(210)));
			this.pipe16.Name = "pipe16";
			this.pipe16.OuterColor = new NxtControl.Drawing.Color(((byte)(147)), ((byte)(139)), ((byte)(125)));
			this.pipe16.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(754D, 320D),
			new NxtControl.Drawing.PointF(754D, 448D)});
			this.pipe16.Width = 5;
			// 
			// sMixer3
			// 
			this.sMixer3.BeginInit();
			this.sMixer3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 728D, 416D);
			this.sMixer3.Name = "sMixer3";
			this.sMixer3.SecurityToken = ((uint)(4294967295u));
			this.sMixer3.TagName = "InfluentFeedLogic.Mixer02Logic";
			this.sMixer3.EndInit();
			// 
			// pipe17
			// 
			this.pipe17.Bounds = new NxtControl.Drawing.RectF(((float)(344D)), ((float)(160D)), ((float)(24D)), ((float)(269.00000000000006D)));
			this.pipe17.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe17.Name = "pipe17";
			this.pipe17.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe17.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(344D, 429.00000000000006D),
			new NxtControl.Drawing.PointF(368D, 429.00000000000006D),
			new NxtControl.Drawing.PointF(368D, 160D)});
			this.pipe17.Width = 10;
			// 
			// pipe18
			// 
			this.pipe18.Bounds = new NxtControl.Drawing.RectF(((float)(488D)), ((float)(160D)), ((float)(24D)), ((float)(269D)));
			this.pipe18.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe18.Name = "pipe18";
			this.pipe18.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe18.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(488D, 429D),
			new NxtControl.Drawing.PointF(512D, 429D),
			new NxtControl.Drawing.PointF(512D, 160D)});
			this.pipe18.Width = 10;
			// 
			// pipe19
			// 
			this.pipe19.Bounds = new NxtControl.Drawing.RectF(((float)(632D)), ((float)(160D)), ((float)(24D)), ((float)(269D)));
			this.pipe19.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe19.Name = "pipe19";
			this.pipe19.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe19.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(632D, 429D),
			new NxtControl.Drawing.PointF(656D, 429D),
			new NxtControl.Drawing.PointF(656D, 160D)});
			this.pipe19.Width = 10;
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sMixer3,
			this.pipe16,
			this.sMotorVs3});
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sMixer2,
			this.pipe15,
			this.sMotorVs2});
			this.group2.EndInit();
			// 
			// sPvBarVer2
			// 
			this.sPvBarVer2.BeginInit();
			this.sPvBarVer2._iSensorName = "40 LIT 0001";
			this.sPvBarVer2._iUnit = "%";
			this.sPvBarVer2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2252252252252254D, 0D, 0D, 1.2252252252252254D, 839.99999999999989D, 332.97297297297291D);
			this.sPvBarVer2.Name = "sPvBarVer2";
			this.sPvBarVer2.SecurityToken = ((uint)(4294967295u));
			this.sPvBarVer2.TagName = "Sensors.LevelPvInfluentBuffer";
			this.sPvBarVer2.EndInit();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(360D)), ((float)(128D)), ((float)(16D)), ((float)(32D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(360D, 128D),
			new NxtControl.Drawing.PointF(376D, 128D),
			new NxtControl.Drawing.PointF(360D, 160D),
			new NxtControl.Drawing.PointF(376D, 160D)});
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(352D, 144D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(368D, 144D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(352D, 152D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(352D, 136D);
			// 
			// group4
			// 
			this.group4.BeginInit();
			this.group4.Name = "group4";
			this.group4.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.line1,
			this.line2});
			this.group4.EndInit();
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(408D)), ((float)(200D)), ((float)(16D)), ((float)(32D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(408D, 200D),
			new NxtControl.Drawing.PointF(424D, 200D),
			new NxtControl.Drawing.PointF(408D, 232D),
			new NxtControl.Drawing.PointF(424D, 232D)});
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(400D, 216D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(416D, 216D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(400D, 224D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(400D, 208D);
			// 
			// group5
			// 
			this.group5.BeginInit();
			this.group5.Name = "group5";
			this.group5.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.line3,
			this.line4});
			this.group5.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(176D)), ((float)(48D)), ((float)(24D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 176D),
			new NxtControl.Drawing.PointF(416D, 176D),
			new NxtControl.Drawing.PointF(416D, 200D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(416D)), ((float)(232D)), ((float)(0D)), ((float)(8D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(416D, 232D),
			new NxtControl.Drawing.PointF(416D, 240D)});
			this.pipe2.Width = 10;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(112D)), ((float)(480D)), ((float)(16D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 128D),
			new NxtControl.Drawing.PointF(368D, 112D),
			new NxtControl.Drawing.PointF(848D, 112D)});
			this.pipe3.Width = 10;
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(504D)), ((float)(128D)), ((float)(16D)), ((float)(32D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(504D, 128D),
			new NxtControl.Drawing.PointF(520D, 128D),
			new NxtControl.Drawing.PointF(504D, 160D),
			new NxtControl.Drawing.PointF(520D, 160D)});
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(496D, 144D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(512D, 144D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(496D, 152D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(496D, 136D);
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(552D)), ((float)(200D)), ((float)(16D)), ((float)(32D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(552D, 200D),
			new NxtControl.Drawing.PointF(568D, 200D),
			new NxtControl.Drawing.PointF(552D, 232D),
			new NxtControl.Drawing.PointF(568D, 232D)});
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(544D, 216D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(560D, 216D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(544D, 224D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(544D, 208D);
			// 
			// group3
			// 
			this.group3.BeginInit();
			this.group3.Name = "group3";
			this.group3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon3,
			this.line5,
			this.line6});
			this.group3.EndInit();
			// 
			// group6
			// 
			this.group6.BeginInit();
			this.group6.Name = "group6";
			this.group6.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon4,
			this.line7,
			this.line8});
			this.group6.EndInit();
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(512D)), ((float)(176D)), ((float)(48D)), ((float)(24D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(512D, 176D),
			new NxtControl.Drawing.PointF(560D, 176D),
			new NxtControl.Drawing.PointF(560D, 200D)});
			this.pipe4.Width = 10;
			// 
			// pipe5
			// 
			this.pipe5.Bounds = new NxtControl.Drawing.RectF(((float)(560D)), ((float)(232D)), ((float)(0D)), ((float)(8D)));
			this.pipe5.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe5.Name = "pipe5";
			this.pipe5.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(560D, 232D),
			new NxtControl.Drawing.PointF(560D, 240D)});
			this.pipe5.Width = 10;
			// 
			// pipe6
			// 
			this.pipe6.Bounds = new NxtControl.Drawing.RectF(((float)(512D)), ((float)(112D)), ((float)(0D)), ((float)(16D)));
			this.pipe6.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe6.Name = "pipe6";
			this.pipe6.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(512D, 128D),
			new NxtControl.Drawing.PointF(512D, 112D)});
			this.pipe6.Width = 10;
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(648D)), ((float)(128D)), ((float)(16D)), ((float)(32D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(648D, 128D),
			new NxtControl.Drawing.PointF(664D, 128D),
			new NxtControl.Drawing.PointF(648D, 160D),
			new NxtControl.Drawing.PointF(664D, 160D)});
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(640D, 144D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(656D, 144D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(640D, 152D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(640D, 136D);
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(696D)), ((float)(200D)), ((float)(16D)), ((float)(32D)));
			this.polygon6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon6.Closed = true;
			this.polygon6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(696D, 200D),
			new NxtControl.Drawing.PointF(712D, 200D),
			new NxtControl.Drawing.PointF(696D, 232D),
			new NxtControl.Drawing.PointF(712D, 232D)});
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(688D, 216D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(704D, 216D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(688D, 224D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(688D, 208D);
			// 
			// pipe7
			// 
			this.pipe7.Bounds = new NxtControl.Drawing.RectF(((float)(656D)), ((float)(112D)), ((float)(0D)), ((float)(16D)));
			this.pipe7.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe7.Name = "pipe7";
			this.pipe7.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(656D, 128D),
			new NxtControl.Drawing.PointF(656D, 112D)});
			this.pipe7.Width = 10;
			// 
			// pipe8
			// 
			this.pipe8.Bounds = new NxtControl.Drawing.RectF(((float)(656D)), ((float)(176D)), ((float)(48D)), ((float)(24D)));
			this.pipe8.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe8.Name = "pipe8";
			this.pipe8.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(656D, 176D),
			new NxtControl.Drawing.PointF(704D, 176D),
			new NxtControl.Drawing.PointF(704D, 200D)});
			this.pipe8.Width = 10;
			// 
			// group7
			// 
			this.group7.BeginInit();
			this.group7.Name = "group7";
			this.group7.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon5,
			this.line9,
			this.line10});
			this.group7.EndInit();
			// 
			// group8
			// 
			this.group8.BeginInit();
			this.group8.Name = "group8";
			this.group8.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon6,
			this.line11,
			this.line12});
			this.group8.EndInit();
			// 
			// pipe9
			// 
			this.pipe9.Bounds = new NxtControl.Drawing.RectF(((float)(704D)), ((float)(232D)), ((float)(0D)), ((float)(8D)));
			this.pipe9.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe9.Name = "pipe9";
			this.pipe9.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(704D, 232D),
			new NxtControl.Drawing.PointF(704D, 240D)});
			this.pipe9.Width = 10;
			// 
			// sDisplayPv41
			// 
			this.sDisplayPv41.BeginInit();
			this.sDisplayPv41._iUnit = "m³/h";
			this.sDisplayPv41.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 736D, 96D);
			this.sDisplayPv41.Name = "sDisplayPv41";
			this.sDisplayPv41.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv41.TagName = "Sensors.FeedInfluentFlowPv";
			this.sDisplayPv41.EndInit();
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(784D, 80D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(784D, 96D);
			// 
			// line14
			// 
			this.line14.EndPoint = new NxtControl.Drawing.PointF(328D, 80D);
			this.line14.Name = "line14";
			this.line14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line14.StartPoint = new NxtControl.Drawing.PointF(784D, 80D);
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(328D, 80D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(328D, 376D);
			// 
			// polygon7
			// 
			this.polygon7.Bounds = new NxtControl.Drawing.RectF(((float)(324D)), ((float)(368D)), ((float)(8D)), ((float)(16D)));
			this.polygon7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon7.Closed = true;
			this.polygon7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon7.Name = "polygon7";
			this.polygon7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(328D, 384D),
			new NxtControl.Drawing.PointF(324D, 368D),
			new NxtControl.Drawing.PointF(332D, 368D)});
			// 
			// line16
			// 
			this.line16.EndPoint = new NxtControl.Drawing.PointF(328D, 336D);
			this.line16.Name = "line16";
			this.line16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line16.StartPoint = new NxtControl.Drawing.PointF(616D, 336D);
			// 
			// line17
			// 
			this.line17.EndPoint = new NxtControl.Drawing.PointF(472D, 336D);
			this.line17.Name = "line17";
			this.line17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line17.StartPoint = new NxtControl.Drawing.PointF(472D, 376D);
			// 
			// line18
			// 
			this.line18.EndPoint = new NxtControl.Drawing.PointF(616D, 336D);
			this.line18.Name = "line18";
			this.line18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.line18.StartPoint = new NxtControl.Drawing.PointF(616D, 376D);
			// 
			// polygon8
			// 
			this.polygon8.Bounds = new NxtControl.Drawing.RectF(((float)(468D)), ((float)(368D)), ((float)(8D)), ((float)(16D)));
			this.polygon8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon8.Closed = true;
			this.polygon8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon8.Name = "polygon8";
			this.polygon8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(472D, 384D),
			new NxtControl.Drawing.PointF(468D, 368D),
			new NxtControl.Drawing.PointF(476D, 368D)});
			// 
			// polygon9
			// 
			this.polygon9.Bounds = new NxtControl.Drawing.RectF(((float)(612D)), ((float)(368D)), ((float)(8D)), ((float)(16D)));
			this.polygon9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon9.Closed = true;
			this.polygon9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon9.Name = "polygon9";
			this.polygon9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(616D, 384D),
			new NxtControl.Drawing.PointF(612D, 368D),
			new NxtControl.Drawing.PointF(620D, 368D)});
			// 
			// sPID2
			// 
			this.sPID2.BeginInit();
			this.sPID2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 560D, 64D);
			this.sPID2.Name = "sPID2";
			this.sPID2.SecurityToken = ((uint)(4294967295u));
			this.sPID2.TagName = "InfluentFeedLogic.Drain_InfluentFeed";
			this.sPID2.EndInit();
			// 
			// sInfluentFeed2
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe8,
			this.pipe7,
			this.pipe6,
			this.pipe4,
			this.group4,
			this.group5,
			this.sShowLevel1,
			this.polygon10,
			this.pipe18,
			this.pipe19,
			this.sPump2,
			this.sPump1,
			this.group1,
			this.group2,
			this.sPvBarVer2,
			this.pipe1,
			this.pipe2,
			this.pipe17,
			this.pipe3,
			this.group3,
			this.group6,
			this.pipe5,
			this.sPump3,
			this.group7,
			this.group8,
			this.pipe9,
			this.sDisplayPv41,
			this.line13,
			this.line14,
			this.line15,
			this.polygon7,
			this.line16,
			this.line17,
			this.line18,
			this.polygon8,
			this.polygon9,
			this.sPID2});
			this.SymbolSize = new System.Drawing.Size(1072, 632);

		}
		private SE.Nereda.Symbols.AnalogInput.sShowLevel sShowLevel1;
		private NxtControl.GuiFramework.Polygon polygon10;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump1;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump2;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump3;
		private SE.Nereda.Symbols.Motor_VS.sMotorVs sMotorVs2;
		private SE.Nereda.Symbols.Motor_VS.sMotorVs sMotorVs3;
		private SE.Nereda.Symbols.MixerLogic.sMixer sMixer2;
		private NxtControl.GuiFramework.Pipe pipe15;
		private NxtControl.GuiFramework.Pipe pipe16;
		private SE.Nereda.Symbols.MixerLogic.sMixer sMixer3;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Pipe pipe17;
		private NxtControl.GuiFramework.Pipe pipe18;
		private NxtControl.GuiFramework.Pipe pipe19;
		private SE.Nereda.Symbols.AnalogInput.sPvBarVer sPvBarVer2;
		private NxtControl.GuiFramework.Group group3;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group group4;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Group group5;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Group group6;
		private NxtControl.GuiFramework.Pipe pipe4;
		private NxtControl.GuiFramework.Pipe pipe5;
		private NxtControl.GuiFramework.Pipe pipe6;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Pipe pipe7;
		private NxtControl.GuiFramework.Pipe pipe8;
		private NxtControl.GuiFramework.Group group7;
		private NxtControl.GuiFramework.Group group8;
		private NxtControl.GuiFramework.Pipe pipe9;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv4 sDisplayPv41;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Line line14;
		private NxtControl.GuiFramework.Line line15;
		private NxtControl.GuiFramework.Polygon polygon7;
		private NxtControl.GuiFramework.Line line16;
		private NxtControl.GuiFramework.Line line17;
		private NxtControl.GuiFramework.Line line18;
		private NxtControl.GuiFramework.Polygon polygon8;
		private NxtControl.GuiFramework.Polygon polygon9;
		private SE.Nereda.Symbols.FeedReactorLogic.sPID sPID2;
		#endregion
	}
}
