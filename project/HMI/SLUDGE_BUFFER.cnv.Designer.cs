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
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.SludgeBuffer_1 = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSettingsSLB();
			this.SludgeBuffer = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSludgeBufferyellow();
			this.SludgeBuffer_2 = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sPhases();
			this.SludgeBuffer_3 = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSensors();
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
			// SludgeBuffer_1
			// 
			this.SludgeBuffer_1.BeginInit();
			this.SludgeBuffer_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1104D, 80D);
			this.SludgeBuffer_1.Name = "SludgeBuffer_1";
			this.SludgeBuffer_1.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer_1.TagName = "9AA3696311BF0C3E";
			this.SludgeBuffer_1.EndInit();
			// 
			// SludgeBuffer
			// 
			this.SludgeBuffer.BeginInit();
			this.SludgeBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 80D, 224D);
			this.SludgeBuffer.Name = "SludgeBuffer";
			this.SludgeBuffer.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer.TagName = "9AA3696311BF0C3E";
			this.SludgeBuffer.EndInit();
			// 
			// SludgeBuffer_2
			// 
			this.SludgeBuffer_2.BeginInit();
			this.SludgeBuffer_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 112D);
			this.SludgeBuffer_2.Name = "SludgeBuffer_2";
			this.SludgeBuffer_2.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer_2.TagName = "9AA3696311BF0C3E";
			this.SludgeBuffer_2.EndInit();
			// 
			// SludgeBuffer_3
			// 
			this.SludgeBuffer_3.BeginInit();
			this.SludgeBuffer_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 520D, 80D);
			this.SludgeBuffer_3.Name = "SludgeBuffer_3";
			this.SludgeBuffer_3.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer_3.TagName = "9AA3696311BF0C3E";
			this.SludgeBuffer_3.EndInit();
			// 
			// SLUDGE_BUFFER
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon7,
			this.HeartBeat,
			this.Mode,
			this.OpenWebPage,
			this.SludgeBuffer_1,
			this.SludgeBuffer,
			this.SludgeBuffer_2,
			this.SludgeBuffer_3});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Polygon polygon7;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSludgeBufferyellow SludgeBuffer;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSettingsSLB SludgeBuffer_1;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sPhases SludgeBuffer_2;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSensors SludgeBuffer_3;
		#endregion
	}
}
