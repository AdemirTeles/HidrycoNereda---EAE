/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 5:15 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for SLUDGE_BUFFER.
	/// </summary>
	partial class SLUDGE_BUFFER
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton5 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.changeCanvasButton3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton6 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton7 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.pipe5 = new NxtControl.GuiFramework.Pipe();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.pipe6 = new NxtControl.GuiFramework.Pipe();
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.changeCanvasButton8 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.pipe7 = new NxtControl.GuiFramework.Pipe();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.EFFLUENT = new SE.Nereda.Symbols.NeredaEffluent.sFlushValve017();
			this.sFlushingSettings1 = new SE.Nereda.Symbols.EffluentLogic.sFlushingSettings();
			this.EFFLUENT_1 = new SE.Nereda.Symbols.NeredaEffluent.sEffluentPumpValves();
			// 
			// changeCanvasButton2
			// 
			this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(392D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton2.CanvasName = "EFFLUENT";
			this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton2.Name = "changeCanvasButton2";
			this.changeCanvasButton2.Text = "EFFLUENT";
			// 
			// changeCanvasButton1
			// 
			this.changeCanvasButton1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(200D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton1.CanvasName = "INFLUENT_FEED";
			this.changeCanvasButton1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton1.Name = "changeCanvasButton1";
			this.changeCanvasButton1.Text = "INFLUENT FEED";
			// 
			// changeCanvasButton5
			// 
			this.changeCanvasButton5.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(152D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton5.CanvasName = "ALARMS";
			this.changeCanvasButton5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton5.Name = "changeCanvasButton5";
			this.changeCanvasButton5.Text = "ALARMS";
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(408D)), ((float)(160D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(312D, 408D),
			new NxtControl.Drawing.PointF(152D, 408D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(216D)), ((float)(504D)), ((float)(16D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(648D, 232D),
			new NxtControl.Drawing.PointF(648D, 216D),
			new NxtControl.Drawing.PointF(144D, 216D)});
			this.pipe2.Width = 10;
			// 
			// changeCanvasButton3
			// 
			this.changeCanvasButton3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(272D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton3.CanvasName = "CALAMITY";
			this.changeCanvasButton3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton3.Name = "changeCanvasButton3";
			this.changeCanvasButton3.Text = "CALAMITY";
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(288D)), ((float)(208D)), ((float)(0D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(344D, 288D),
			new NxtControl.Drawing.PointF(136D, 288D)});
			this.pipe3.Width = 10;
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(208D)), ((float)(32D)), ((float)(16D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(200D, 224D),
			new NxtControl.Drawing.PointF(200D, 208D),
			new NxtControl.Drawing.PointF(232D, 216D)});
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(400D)), ((float)(32D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(200D, 416D),
			new NxtControl.Drawing.PointF(200D, 400D),
			new NxtControl.Drawing.PointF(232D, 408D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(280D)), ((float)(32D)), ((float)(16D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(200D, 288D),
			new NxtControl.Drawing.PointF(232D, 280D),
			new NxtControl.Drawing.PointF(232D, 296D)});
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(1192D)), ((float)(320D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton4.CanvasName = "REACTOR3";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "REACTOR 3";
			// 
			// changeCanvasButton6
			// 
			this.changeCanvasButton6.Bounds = new NxtControl.Drawing.RectF(((float)(1192D)), ((float)(272D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton6.CanvasName = "REACTOR2";
			this.changeCanvasButton6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton6.Name = "changeCanvasButton6";
			this.changeCanvasButton6.Text = "REACTOR 2";
			// 
			// changeCanvasButton7
			// 
			this.changeCanvasButton7.Bounds = new NxtControl.Drawing.RectF(((float)(1192D)), ((float)(224D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton7.CanvasName = "REACTOR1";
			this.changeCanvasButton7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton7.Name = "changeCanvasButton7";
			this.changeCanvasButton7.Text = "REACTOR 1";
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(1128D)), ((float)(240D)), ((float)(80D)), ((float)(96D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1208D, 240D),
			new NxtControl.Drawing.PointF(1128D, 240D),
			new NxtControl.Drawing.PointF(1128D, 336D),
			new NxtControl.Drawing.PointF(1208D, 336D)});
			this.pipe4.Width = 10;
			// 
			// pipe5
			// 
			this.pipe5.Bounds = new NxtControl.Drawing.RectF(((float)(1088D)), ((float)(288D)), ((float)(120D)), ((float)(0D)));
			this.pipe5.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe5.Name = "pipe5";
			this.pipe5.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1088D, 288D),
			new NxtControl.Drawing.PointF(1208D, 288D)});
			this.pipe5.Width = 10;
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(1123D)), ((float)(283D)), ((float)(10D)), ((float)(10D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(1144D)), ((float)(232D)), ((float)(32D)), ((float)(16D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1144D, 240D),
			new NxtControl.Drawing.PointF(1176D, 232D),
			new NxtControl.Drawing.PointF(1176D, 248D)});
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(1144D)), ((float)(280D)), ((float)(32D)), ((float)(16D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1144D, 288D),
			new NxtControl.Drawing.PointF(1176D, 280D),
			new NxtControl.Drawing.PointF(1176D, 296D)});
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(1144D)), ((float)(328D)), ((float)(32D)), ((float)(16D)));
			this.polygon6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon6.Closed = true;
			this.polygon6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1144D, 336D),
			new NxtControl.Drawing.PointF(1176D, 328D),
			new NxtControl.Drawing.PointF(1176D, 344D)});
			// 
			// pipe6
			// 
			this.pipe6.Bounds = new NxtControl.Drawing.RectF(((float)(464D)), ((float)(432D)), ((float)(584D)), ((float)(174D)));
			this.pipe6.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe6.Name = "pipe6";
			this.pipe6.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1008D, 432D),
			new NxtControl.Drawing.PointF(1048D, 432D),
			new NxtControl.Drawing.PointF(1048D, 520.09090909090912D),
			new NxtControl.Drawing.PointF(464D, 520.09090909090912D),
			new NxtControl.Drawing.PointF(464D, 606D),
			new NxtControl.Drawing.PointF(624D, 606D)});
			this.pipe6.Width = 10;
			// 
			// polygon7
			// 
			this.polygon7.Bounds = new NxtControl.Drawing.RectF(((float)(536D)), ((float)(598D)), ((float)(32D)), ((float)(16D)));
			this.polygon7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon7.Closed = true;
			this.polygon7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon7.Name = "polygon7";
			this.polygon7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(536D, 614D),
			new NxtControl.Drawing.PointF(536D, 598D),
			new NxtControl.Drawing.PointF(568D, 606D)});
			// 
			// changeCanvasButton8
			// 
			this.changeCanvasButton8.Bounds = new NxtControl.Drawing.RectF(((float)(1192D)), ((float)(568D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton8.CanvasName = "CALAMITY";
			this.changeCanvasButton8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton8.Name = "changeCanvasButton8";
			this.changeCanvasButton8.Text = "RWZI WEERT";
			// 
			// pipe7
			// 
			this.pipe7.Bounds = new NxtControl.Drawing.RectF(((float)(1168D)), ((float)(584D)), ((float)(48D)), ((float)(0D)));
			this.pipe7.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe7.Name = "pipe7";
			this.pipe7.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1168D, 584D),
			new NxtControl.Drawing.PointF(1216D, 584D)});
			this.pipe7.Width = 10;
			// 
			// HeartBeat
			// 
			this.HeartBeat.BeginInit();
			this.HeartBeat.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.HeartBeat.Name = "HeartBeat";
			this.HeartBeat.SecurityToken = ((uint)(4294967295u));
			this.HeartBeat.TagName = "32B44D45F962192F";
			this.HeartBeat.EndInit();
			// 
			// MCCPower
			// 
			this.MCCPower.BeginInit();
			this.MCCPower.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 8D);
			this.MCCPower.Name = "MCCPower";
			this.MCCPower.SecurityToken = ((uint)(4294967295u));
			this.MCCPower.TagName = "E1E3B3442DD19945";
			this.MCCPower.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "7A79C015B9ADE3EB";
			this.Mode.EndInit();
			// 
			// sHiHiLevelCalamity1
			// 
			this.sHiHiLevelCalamity1.BeginInit();
			this.sHiHiLevelCalamity1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 632D, 8D);
			this.sHiHiLevelCalamity1.Name = "sHiHiLevelCalamity1";
			this.sHiHiLevelCalamity1.SecurityToken = ((uint)(4294967295u));
			this.sHiHiLevelCalamity1.TagName = "F2F66466CB372A96.EffluentLogic.Calamity";
			this.sHiHiLevelCalamity1.EndInit();
			// 
			// OpenWebPage
			// 
			this.OpenWebPage.BeginInit();
			this.OpenWebPage.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 840D, 8D);
			this.OpenWebPage.Name = "OpenWebPage";
			this.OpenWebPage.SecurityToken = ((uint)(4294967295u));
			this.OpenWebPage.TagName = "61745BDDB91DBEF5";
			this.OpenWebPage.EndInit();
			// 
			// EFFLUENT
			// 
			this.EFFLUENT.BeginInit();
			this.EFFLUENT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 272D, 344D);
			this.EFFLUENT.Name = "EFFLUENT";
			this.EFFLUENT.SecurityToken = ((uint)(4294967295u));
			this.EFFLUENT.TagName = "F2F66466CB372A96";
			this.EFFLUENT.EndInit();
			// 
			// sFlushingSettings1
			// 
			this.sFlushingSettings1.BeginInit();
			this.sFlushingSettings1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1144D, 8D);
			this.sFlushingSettings1.Name = "sFlushingSettings1";
			this.sFlushingSettings1.SecurityToken = ((uint)(4294967295u));
			this.sFlushingSettings1.TagName = "F2F66466CB372A96.EffluentLogic";
			this.sFlushingSettings1.EndInit();
			// 
			// EFFLUENT_1
			// 
			this.EFFLUENT_1.BeginInit();
			this.EFFLUENT_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 432D);
			this.EFFLUENT_1.Name = "EFFLUENT_1";
			this.EFFLUENT_1.SecurityToken = ((uint)(4294967295u));
			this.EFFLUENT_1.TagName = "F2F66466CB372A96";
			this.EFFLUENT_1.EndInit();
			// 
			// SLUDGE_BUFFER
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe5,
			this.pipe4,
			this.pipe2,
			this.pipe1,
			this.changeCanvasButton2,
			this.changeCanvasButton1,
			this.changeCanvasButton5,
			this.pipe3,
			this.changeCanvasButton3,
			this.polygon2,
			this.polygon1,
			this.polygon3,
			this.changeCanvasButton4,
			this.changeCanvasButton6,
			this.changeCanvasButton7,
			this.ellipse1,
			this.polygon4,
			this.polygon5,
			this.polygon6,
			this.pipe6,
			this.polygon7,
			this.pipe7,
			this.changeCanvasButton8,
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.EFFLUENT,
			this.sFlushingSettings1,
			this.EFFLUENT_1});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton1;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton5;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton6;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton7;
		private NxtControl.GuiFramework.Pipe pipe4;
		private NxtControl.GuiFramework.Pipe pipe5;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.Pipe pipe6;
		private NxtControl.GuiFramework.Polygon polygon7;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton8;
		private NxtControl.GuiFramework.Pipe pipe7;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.NeredaEffluent.sFlushValve017 EFFLUENT;
		private SE.Nereda.Symbols.EffluentLogic.sFlushingSettings sFlushingSettings1;
		private SE.Nereda.Symbols.NeredaEffluent.sEffluentPumpValves EFFLUENT_1;
		#endregion
	}
}
