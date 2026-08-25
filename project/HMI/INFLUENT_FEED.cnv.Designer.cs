/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 7:02 PM
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
	/// Summary description for INFLUENT_FEED.
	/// </summary>
	partial class INFLUENT_FEED
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.changeCanvasButton3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.INFLUENT_FEED_4 = new SE.Nereda.Symbols.InfluentFeed.sSensors();
			this.sDrainSettings1 = new SE.Nereda.Symbols.InfluentFeedLogic.sDrainSettings();
			this.sDefault1 = new SE.Nereda.Symbols.Phase.sDefault();
			this.sDefault2 = new SE.Nereda.Symbols.Phase.sDefault();
			this.EFFLUENT_4 = new SE.Nereda.Symbols.NeredaEffluent.sTempSensor();
			this.Mode_1 = new SE.Nereda.Symbols.Mode.ResetMetalSaltDosing();
			this.METAL_SALT_DOSING_1 = new SE.Nereda.Symbols.NeredaMetalSaltDosing.sSensors();
			this.INFLUENT_FEED_1 = new SE.Nereda.Symbols.InfluentFeed.sInfluentFeed2();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			// 
			// changeCanvasButton3
			// 
			this.changeCanvasButton3.Bounds = new NxtControl.Drawing.RectF(((float)(752D)), ((float)(296D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton3.CanvasName = "REACTOR2";
			this.changeCanvasButton3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton3.Name = "changeCanvasButton3";
			this.changeCanvasButton3.Text = "REACTOR 2";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(752D)), ((float)(232D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton4.CanvasName = "REACTOR1";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "REACTOR 1";
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
			this.OpenWebPage.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8666666666666667D, 0D, 0D, 1D, 840D, 8D);
			this.OpenWebPage.Name = "OpenWebPage";
			this.OpenWebPage.SecurityToken = ((uint)(4294967295u));
			this.OpenWebPage.TagName = "61745BDDB91DBEF5";
			this.OpenWebPage.EndInit();
			// 
			// INFLUENT_FEED_4
			// 
			this.INFLUENT_FEED_4.BeginInit();
			this.INFLUENT_FEED_4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 960D, 144D);
			this.INFLUENT_FEED_4.Name = "INFLUENT_FEED_4";
			this.INFLUENT_FEED_4.SecurityToken = ((uint)(4294967295u));
			this.INFLUENT_FEED_4.TagName = "2098DAF96A66AD0A";
			this.INFLUENT_FEED_4.EndInit();
			// 
			// sDrainSettings1
			// 
			this.sDrainSettings1.BeginInit();
			this.sDrainSettings1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1096D, 8D);
			this.sDrainSettings1.Name = "sDrainSettings1";
			this.sDrainSettings1.SecurityToken = ((uint)(4294967295u));
			this.sDrainSettings1.TagName = "2098DAF96A66AD0A.InfluentFeedLogic";
			this.sDrainSettings1.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iReactorID = "Reactor 1";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 64D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.ReactorName;
			this.sDefault1.TagName = "D32FABF3E7C17DE2.ReactorLogic.Feed";
			this.sDefault1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2._iReactorID = "Reactor 2";
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 96D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.StateTextPosition = SE.Nereda.Symbols.Phase.sDefault.ShowReactorName.ReactorName;
			this.sDefault2.TagName = "B553EA539882D2E1.ReactorLogic.Feed";
			this.sDefault2.EndInit();
			// 
			// EFFLUENT_4
			// 
			this.EFFLUENT_4.BeginInit();
			this.EFFLUENT_4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 960D, 288D);
			this.EFFLUENT_4.Name = "EFFLUENT_4";
			this.EFFLUENT_4.SecurityToken = ((uint)(4294967295u));
			this.EFFLUENT_4.TagName = "F2F66466CB372A96";
			this.EFFLUENT_4.EndInit();
			// 
			// Mode_1
			// 
			this.Mode_1.BeginInit();
			this.Mode_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7142857142857143D, 0D, 0D, 1D, 960D, 8D);
			this.Mode_1.Name = "Mode_1";
			this.Mode_1.SecurityToken = ((uint)(4294967295u));
			this.Mode_1.TagName = "7A79C015B9ADE3EB";
			this.Mode_1.EndInit();
			// 
			// METAL_SALT_DOSING_1
			// 
			this.METAL_SALT_DOSING_1.BeginInit();
			this.METAL_SALT_DOSING_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1168D, 216D);
			this.METAL_SALT_DOSING_1.Name = "METAL_SALT_DOSING_1";
			this.METAL_SALT_DOSING_1.SecurityToken = ((uint)(4294967295u));
			this.METAL_SALT_DOSING_1.TagName = "19DBCE8B43D468D4";
			this.METAL_SALT_DOSING_1.EndInit();
			// 
			// INFLUENT_FEED_1
			// 
			this.INFLUENT_FEED_1.BeginInit();
			this.INFLUENT_FEED_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 232D);
			this.INFLUENT_FEED_1.Name = "INFLUENT_FEED_1";
			this.INFLUENT_FEED_1.SecurityToken = ((uint)(4294967295u));
			this.INFLUENT_FEED_1.TagName = "2098DAF96A66AD0A";
			this.INFLUENT_FEED_1.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(736D)), ((float)(248D)), ((float)(40D)), ((float)(64D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(776D, 248D),
			new NxtControl.Drawing.PointF(736D, 248D),
			new NxtControl.Drawing.PointF(736D, 312D),
			new NxtControl.Drawing.PointF(776D, 312D)});
			this.pipe1.Width = 10;
			// 
			// INFLUENT_FEED
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.INFLUENT_FEED_4,
			this.sDrainSettings1,
			this.sDefault1,
			this.sDefault2,
			this.EFFLUENT_4,
			this.Mode_1,
			this.METAL_SALT_DOSING_1,
			this.INFLUENT_FEED_1,
			this.pipe1,
			this.changeCanvasButton4,
			this.changeCanvasButton3});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.InfluentFeed.sInfluentFeed2 INFLUENT_FEED_1;
		private SE.Nereda.Symbols.InfluentFeed.sSensors INFLUENT_FEED_4;
		private SE.Nereda.Symbols.InfluentFeedLogic.sDrainSettings sDrainSettings1;
		private SE.Nereda.Symbols.Phase.sDefault sDefault1;
		private SE.Nereda.Symbols.Phase.sDefault sDefault2;
		private SE.Nereda.Symbols.NeredaEffluent.sTempSensor EFFLUENT_4;
		private SE.Nereda.Symbols.Mode.ResetMetalSaltDosing Mode_1;
		private SE.Nereda.Symbols.NeredaMetalSaltDosing.sSensors METAL_SALT_DOSING_1;
		private NxtControl.GuiFramework.Pipe pipe1;
		#endregion
	}
}
