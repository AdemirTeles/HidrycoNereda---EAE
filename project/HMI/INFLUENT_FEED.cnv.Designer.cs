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
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
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
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "7A79C015B9ADE3EB";
			this.Mode.EndInit();
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
			this.Mode,
			this.OpenWebPage,
			this.pipe1,
			this.changeCanvasButton4,
			this.changeCanvasButton3});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private NxtControl.GuiFramework.Pipe pipe1;
		#endregion
	}
}
