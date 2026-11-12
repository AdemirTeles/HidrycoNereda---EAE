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
			this.btnAckNereda = new NxtControl.GuiFramework.DrawnButton();
			this.changeCanvasButton3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.InfluentFeed = new SE.Nereda.Symbols.InfluentFeed.sInfluentFeed2();
			this.InfluentFeed_1 = new SE.Nereda.Symbols.InfluentFeed.sSensors();
			this.sDrainSettings1 = new SE.Nereda.Symbols.InfluentFeedLogic.sDrainSettings();
			// 
			// btnAckNereda
			// 
			this.btnAckNereda.Bounds = new NxtControl.Drawing.RectF(((float)(212D)), ((float)(12D)), ((float)(200D)), ((float)(32D)));
			this.btnAckNereda.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAckNereda.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAckNereda.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAckNereda.Name = "btnAckNereda";
			this.btnAckNereda.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAckNereda.Radius = 2D;
			this.btnAckNereda.Text = "Reconhecer alarmes";
			this.btnAckNereda.Use3DEffect = false;
			this.btnAckNereda.Click += new System.EventHandler(this.BtnAckNeredaClick);
			// 
			// changeCanvasButton3
			// 
			this.changeCanvasButton3.Bounds = new NxtControl.Drawing.RectF(((float)(844D)), ((float)(213.6D)), ((float)(193.2D)), ((float)(36.8D)));
			this.changeCanvasButton3.CanvasName = "REACTOR2";
			this.changeCanvasButton3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton3.Name = "changeCanvasButton3";
			this.changeCanvasButton3.Text = "REATOR NEREDA 2";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(844D)), ((float)(140D)), ((float)(193.2D)), ((float)(36.8D)));
			this.changeCanvasButton4.CanvasName = "REACTOR1";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "REATOR NEREDA 1";
			// 
			// HeartBeat
			// 
			this.HeartBeat.BeginInit();
			this.HeartBeat.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.HeartBeat.Name = "HeartBeat";
			this.HeartBeat.SecurityToken = ((uint)(4294967295u));
			this.HeartBeat.TagName = "1A7AD4234C2BE11C";
			this.HeartBeat.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "ECC9B0BB08A85534";
			this.Mode.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(825.6D)), ((float)(158.4D)), ((float)(46D)), ((float)(73.6D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(871.6D, 158.4D),
			new NxtControl.Drawing.PointF(825.6D, 158.4D),
			new NxtControl.Drawing.PointF(825.6D, 232D),
			new NxtControl.Drawing.PointF(871.6D, 232D)});
			this.pipe1.Width = 10;
			// 
			// InfluentFeed
			// 
			this.InfluentFeed.BeginInit();
			this.InfluentFeed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.15D, 0D, 0D, 1.15D, 16D, 140D);
			this.InfluentFeed.Name = "InfluentFeed";
			this.InfluentFeed.SecurityToken = ((uint)(4294967295u));
			this.InfluentFeed.TagName = "B949570768DD3945";
			this.InfluentFeed.EndInit();
			// 
			// InfluentFeed_1
			// 
			this.InfluentFeed_1.BeginInit();
			this.InfluentFeed_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1190D, 140D);
			this.InfluentFeed_1.Name = "InfluentFeed_1";
			this.InfluentFeed_1.SecurityToken = ((uint)(4294967295u));
			this.InfluentFeed_1.TagName = "B949570768DD3945";
			this.InfluentFeed_1.EndInit();
			// 
			// sDrainSettings1
			// 
			this.sDrainSettings1.BeginInit();
			this.sDrainSettings1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1238D, 8D);
			this.sDrainSettings1.Name = "sDrainSettings1";
			this.sDrainSettings1.SecurityToken = ((uint)(4294967295u));
			this.sDrainSettings1.TagName = "B949570768DD3945.InfluentFeedLogic";
			this.sDrainSettings1.EndInit();
			// 
			// INFLUENT_FEED
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InfluentFeed,
			this.HeartBeat,
			this.Mode,
			this.pipe1,
			this.changeCanvasButton4,
			this.changeCanvasButton3,
			this.InfluentFeed_1,
			this.sDrainSettings1,
			this.btnAckNereda});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private NxtControl.GuiFramework.Pipe pipe1;
		private SE.Nereda.Symbols.InfluentFeed.sInfluentFeed2 InfluentFeed;
		private SE.Nereda.Symbols.InfluentFeed.sSensors InfluentFeed_1;
		private SE.Nereda.Symbols.InfluentFeedLogic.sDrainSettings sDrainSettings1;
		private NxtControl.GuiFramework.DrawnButton btnAckNereda;
		#endregion
	}
}
