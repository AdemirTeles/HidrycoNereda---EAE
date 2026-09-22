/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 9:44 AM
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
	/// Summary description for CALAMITY.
	/// </summary>
	partial class CALAMITY
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.pipe5 = new NxtControl.GuiFramework.Pipe();
			this.pipe6 = new NxtControl.GuiFramework.Pipe();
			this.pipe7 = new NxtControl.GuiFramework.Pipe();
			this.pipe8 = new NxtControl.GuiFramework.Pipe();
			this.changeCanvasButton1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse4 = new NxtControl.GuiFramework.Ellipse();
			this.changeCanvasButton5 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			// 
			// changeCanvasButton2
			// 
			this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(581D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton2.CanvasName = "EFFLUENT";
			this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton2.Name = "changeCanvasButton2";
			this.changeCanvasButton2.Text = "EFFLUENT";
			// 
			// changeCanvasButton3
			// 
			this.changeCanvasButton3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(293D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton3.CanvasName = "SLUDGE_BUFFER";
			this.changeCanvasButton3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton3.Name = "changeCanvasButton3";
			this.changeCanvasButton3.Text = "SLUDGE BUFFER";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(213D)), ((float)(168D)), ((float)(64D)));
			this.changeCanvasButton4.CanvasName = "REACTOR1";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "Nabehandeling BO3";
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(229D)), ((float)(184D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(336D, 229D),
			new NxtControl.Drawing.PointF(152D, 229D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(261D)), ((float)(184D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(336D, 261D),
			new NxtControl.Drawing.PointF(152D, 261D)});
			this.pipe2.Width = 10;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(293D)), ((float)(200D)), ((float)(16D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(344D, 293D),
			new NxtControl.Drawing.PointF(272D, 293D),
			new NxtControl.Drawing.PointF(272D, 309D),
			new NxtControl.Drawing.PointF(144D, 309D)});
			this.pipe3.Width = 10;
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(992D)), ((float)(133D)), ((float)(240D)), ((float)(232D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1232D, 365D),
			new NxtControl.Drawing.PointF(1232D, 133D),
			new NxtControl.Drawing.PointF(992D, 133D)});
			this.pipe4.Width = 10;
			// 
			// pipe5
			// 
			this.pipe5.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(205D)), ((float)(896D)), ((float)(392D)));
			this.pipe5.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe5.Name = "pipe5";
			this.pipe5.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(144D, 597D),
			new NxtControl.Drawing.PointF(1040D, 597D),
			new NxtControl.Drawing.PointF(1040D, 205D)});
			this.pipe5.Width = 10;
			// 
			// pipe6
			// 
			this.pipe6.Bounds = new NxtControl.Drawing.RectF(((float)(984D)), ((float)(205D)), ((float)(248D)), ((float)(0D)));
			this.pipe6.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe6.Name = "pipe6";
			this.pipe6.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(984D, 205D),
			new NxtControl.Drawing.PointF(1232D, 205D)});
			this.pipe6.Width = 10;
			// 
			// pipe7
			// 
			this.pipe7.Bounds = new NxtControl.Drawing.RectF(((float)(992D)), ((float)(269D)), ((float)(240D)), ((float)(8D)));
			this.pipe7.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe7.Name = "pipe7";
			this.pipe7.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(992D, 277D),
			new NxtControl.Drawing.PointF(1024D, 277D),
			new NxtControl.Drawing.PointF(1032D, 269D),
			new NxtControl.Drawing.PointF(1048D, 269D),
			new NxtControl.Drawing.PointF(1056D, 277D),
			new NxtControl.Drawing.PointF(1232D, 277D)});
			this.pipe7.Width = 10;
			// 
			// pipe8
			// 
			this.pipe8.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(277D)), ((float)(952D)), ((float)(376D)));
			this.pipe8.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe8.Name = "pipe8";
			this.pipe8.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(144D, 653D),
			new NxtControl.Drawing.PointF(1096D, 653D),
			new NxtControl.Drawing.PointF(1096D, 277D)});
			this.pipe8.Width = 10;
			// 
			// changeCanvasButton1
			// 
			this.changeCanvasButton1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(637D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton1.CanvasName = "SLUDGE_BUFFER";
			this.changeCanvasButton1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton1.Name = "changeCanvasButton1";
			this.changeCanvasButton1.Text = "SLUDGE BUFFER";
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(1035D)), ((float)(200D)), ((float)(10D)), ((float)(10D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(1091D)), ((float)(272D)), ((float)(10D)), ((float)(10D)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(1227D)), ((float)(200D)), ((float)(10D)), ((float)(10D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			// 
			// ellipse4
			// 
			this.ellipse4.Bounds = new NxtControl.Drawing.RectF(((float)(1227D)), ((float)(272D)), ((float)(10D)), ((float)(10D)));
			this.ellipse4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse4.Name = "ellipse4";
			// 
			// changeCanvasButton5
			// 
			this.changeCanvasButton5.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(528D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton5.CanvasName = "ALARMS";
			this.changeCanvasButton5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton5.Name = "changeCanvasButton5";
			this.changeCanvasButton5.Text = "ALARMS";
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
			this.OpenWebPage.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 840D, 8D);
			this.OpenWebPage.Name = "OpenWebPage";
			this.OpenWebPage.SecurityToken = ((uint)(4294967295u));
			this.OpenWebPage.TagName = "61745BDDB91DBEF5";
			this.OpenWebPage.EndInit();
			// 
			// CALAMITY
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe1,
			this.pipe2,
			this.changeCanvasButton4,
			this.pipe3,
			this.changeCanvasButton3,
			this.pipe4,
			this.pipe5,
			this.pipe6,
			this.pipe7,
			this.pipe8,
			this.changeCanvasButton2,
			this.changeCanvasButton1,
			this.ellipse1,
			this.ellipse2,
			this.ellipse3,
			this.ellipse4,
			this.changeCanvasButton5,
			this.HeartBeat,
			this.Mode,
			this.OpenWebPage});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe4;
		private NxtControl.GuiFramework.Pipe pipe5;
		private NxtControl.GuiFramework.Pipe pipe6;
		private NxtControl.GuiFramework.Pipe pipe7;
		private NxtControl.GuiFramework.Pipe pipe8;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton1;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.Ellipse ellipse4;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton5;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		#endregion
	}
}
