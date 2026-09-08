/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 3:50 PM
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
	/// Summary description for REACTOR1.
	/// </summary>
	partial class REACTOR1
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.changeCanvasButton1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton5 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.NVPP_REACTOR01 = new SE.Nereda.Symbols.NeredaReactor.sSettingsBtn();
			this.Mode_1 = new SE.Nereda.Symbols.Mode.ResetReactor1();
			this.sDefault1 = new SE.Nereda.Symbols.ResetValvesManager.sDefault();
			this.REACTOR01 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.REACTOR01_1 = new SE.Nereda.Symbols.NeredaReactor.sPhase2();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			// 
			// changeCanvasButton1
			// 
			this.changeCanvasButton1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(656D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton1.CanvasName = "SLUDGE_BUFFER";
			this.changeCanvasButton1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton1.Name = "changeCanvasButton1";
			this.changeCanvasButton1.Text = "SLUDGE BUFFER";
			// 
			// changeCanvasButton2
			// 
			this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(560D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton2.CanvasName = "INFLUENT_FEED";
			this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton2.Name = "changeCanvasButton2";
			this.changeCanvasButton2.Text = "INFLUENT FEED";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(608D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton4.CanvasName = "EFFLUENT";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "EFFLUENT";
			// 
			// changeCanvasButton5
			// 
			this.changeCanvasButton5.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(512D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton5.CanvasName = "AERATION";
			this.changeCanvasButton5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton5.Name = "changeCanvasButton5";
			this.changeCanvasButton5.Text = "AERATION";
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
			// NVPP_REACTOR01
			// 
			this.NVPP_REACTOR01.BeginInit();
			this.NVPP_REACTOR01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 976D, 8D);
			this.NVPP_REACTOR01.Name = "NVPP_REACTOR01";
			this.NVPP_REACTOR01.SecurityToken = ((uint)(4294967295u));
			this.NVPP_REACTOR01.TagName = "D32FABF3E7C17DE2";
			this.NVPP_REACTOR01.EndInit();
			// 
			// Mode_1
			// 
			this.Mode_1.BeginInit();
			this.Mode_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1112D, 8D);
			this.Mode_1.Name = "Mode_1";
			this.Mode_1.SecurityToken = ((uint)(4294967295u));
			this.Mode_1.TagName = "7A79C015B9ADE3EB";
			this.Mode_1.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.83333333333333337D, 0D, 0D, 1D, 480D, 64D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "D32FABF3E7C17DE2.Actuators.ResetAllValves";
			this.sDefault1.EndInit();
			// 
			// REACTOR01
			// 
			this.REACTOR01.BeginInit();
			this.REACTOR01._iAV4x101 = "AV41101";
			this.REACTOR01._iAV4x103 = "AV41103";
			this.REACTOR01._iAV4x107 = "AV41107";
			this.REACTOR01._iAV4x171 = "AV41171";
			this.REACTOR01._iAV4x172 = "AV41172";
			this.REACTOR01._iLT001 = "41LT1005";
			this.REACTOR01._iREACTOR = "Reactor 1";
			this.REACTOR01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 608D, 72D);
			this.REACTOR01.Name = "REACTOR01";
			this.REACTOR01.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(168D)), ((float)(480D)), ((float)(360D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(624D, 168D),
			new NxtControl.Drawing.PointF(600D, 168D),
			new NxtControl.Drawing.PointF(600D, 528D),
			new NxtControl.Drawing.PointF(144D, 528D)});
			this.pipe1.Width = 10;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(128D)), ((float)(568D)), ((float)(1184D)), ((float)(72D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1240D, 568D),
			new NxtControl.Drawing.PointF(1312D, 568D),
			new NxtControl.Drawing.PointF(1312D, 640D),
			new NxtControl.Drawing.PointF(600D, 640D),
			new NxtControl.Drawing.PointF(600D, 624D),
			new NxtControl.Drawing.PointF(128D, 624D)});
			this.pipe3.Width = 10;
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(400D)), ((float)(1200D)), ((float)(272D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1304D, 400D),
			new NxtControl.Drawing.PointF(1344D, 400D),
			new NxtControl.Drawing.PointF(1344D, 672D),
			new NxtControl.Drawing.PointF(144D, 672D)});
			this.pipe4.Width = 10;
			// 
			// REACTOR01_1
			// 
			this.REACTOR01_1.BeginInit();
			this.REACTOR01_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 64D);
			this.REACTOR01_1.Name = "REACTOR01_1";
			this.REACTOR01_1.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01_1.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01_1.EndInit();
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(128D)), ((float)(560D)), ((float)(496D)), ((float)(16D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(624D, 560D),
			new NxtControl.Drawing.PointF(600D, 560D),
			new NxtControl.Drawing.PointF(600D, 576D),
			new NxtControl.Drawing.PointF(128D, 576D)});
			this.pipe2.Width = 10;
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(520D)), ((float)(32D)), ((float)(16D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(192D, 520D),
			new NxtControl.Drawing.PointF(192D, 536D),
			new NxtControl.Drawing.PointF(224D, 528D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(568D)), ((float)(32D)), ((float)(16D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(192D, 568D),
			new NxtControl.Drawing.PointF(192D, 584D),
			new NxtControl.Drawing.PointF(224D, 576D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(616D)), ((float)(32D)), ((float)(16D)));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(224D, 616D),
			new NxtControl.Drawing.PointF(224D, 632D),
			new NxtControl.Drawing.PointF(192D, 624D)});
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(664D)), ((float)(32D)), ((float)(16D)));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(224D, 664D),
			new NxtControl.Drawing.PointF(224D, 680D),
			new NxtControl.Drawing.PointF(192D, 672D)});
			// 
			// REACTOR1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe2,
			this.pipe4,
			this.pipe3,
			this.pipe1,
			this.changeCanvasButton1,
			this.changeCanvasButton2,
			this.changeCanvasButton4,
			this.changeCanvasButton5,
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.NVPP_REACTOR01,
			this.Mode_1,
			this.sDefault1,
			this.REACTOR01,
			this.REACTOR01_1,
			this.polygon1,
			this.polygon2,
			this.polygon3,
			this.polygon4});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton1;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton5;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.NeredaReactor.sSettingsBtn NVPP_REACTOR01;
		private SE.Nereda.Symbols.Mode.ResetReactor1 Mode_1;
		private SE.Nereda.Symbols.ResetValvesManager.sDefault sDefault1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 REACTOR01;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe4;
		private SE.Nereda.Symbols.NeredaReactor.sPhase2 REACTOR01_1;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Polygon polygon4;
		#endregion
	}
}
