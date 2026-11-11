/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/20/2026
 * Time: 11:31 AM
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
	/// Summary description for AERATION.
	/// </summary>
	partial class AERATION
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAckNereda = new NxtControl.GuiFramework.DrawnButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.AERATION_1 = new SE.Nereda.Symbols.NeredaCAeration.sBlowers();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
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
			// AERATION_1
			// 
			this.AERATION_1.BeginInit();
			this.AERATION_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.99038461538461553D, 0D, 0D, 1D, 368.00000000000011D, 304D);
			this.AERATION_1.Name = "AERATION_1";
			this.AERATION_1.SecurityToken = ((uint)(4294967295u));
			this.AERATION_1.TagName = "35A194BD3A715270";
			this.AERATION_1.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(824D)), ((float)(88D)), ((float)(320D)), ((float)(232D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(824D, 320D),
			new NxtControl.Drawing.PointF(824D, 88D),
			new NxtControl.Drawing.PointF(1144D, 88D),
			new NxtControl.Drawing.PointF(1144D, 104D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(320D)), ((float)(304D)), ((float)(112D)), ((float)(56D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(432D, 320D),
			new NxtControl.Drawing.PointF(432D, 304D),
			new NxtControl.Drawing.PointF(320D, 304D),
			new NxtControl.Drawing.PointF(320D, 360D)});
			this.pipe2.Width = 10;
			// 
			// AERATION
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.AERATION_1,
			this.pipe1,
			this.btnAckNereda,
			this.pipe2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.NeredaCAeration.sBlowers AERATION_1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.DrawnButton btnAckNereda;
		#endregion
	}
}
