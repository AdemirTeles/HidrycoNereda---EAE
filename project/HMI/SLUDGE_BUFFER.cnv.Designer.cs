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
			this.sDefault1 = new SE.App2CommonProcess.Symbols.Autotune.sDefault();
			this.sBarPvSpOpVert2 = new SE.App2CommonProcess.Symbols.PID.sBarPvSpOpVert();
			this.sBarPvSpOpVert1 = new SE.App2CommonProcess.Symbols.PID.sBarPvSpOpVert();
			this.sDefault2 = new SE.App2CommonProcess.Symbols.Autotune.sDefault();
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
			this.SludgeBuffer_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1008D, 80D);
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
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DefaultInstanceName = null;
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 960D, 160D);
			this.sDefault1.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sDefault1.MyTagDisplayName = null;
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "9AA3696311BF0C3E.Logic.CmdSludgeDischargeSLB1.CommandLogic.Autotune1";
			this.sDefault1.EndInit();
			// 
			// sBarPvSpOpVert2
			// 
			this.sBarPvSpOpVert2.BeginInit();
			this.sBarPvSpOpVert2.DefaultInstanceName = null;
			this.sBarPvSpOpVert2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1032D, 128D);
			this.sBarPvSpOpVert2.DisplayType = SE.App2CommonProcess.SupportClasses.PidDisplayType.PvSpOp;
			this.sBarPvSpOpVert2.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sBarPvSpOpVert2.MyTagDisplayName = null;
			this.sBarPvSpOpVert2.Name = "sBarPvSpOpVert2";
			this.sBarPvSpOpVert2.SecurityToken = ((uint)(4294967295u));
			this.sBarPvSpOpVert2.TagName = "9AA3696311BF0C3E.Logic.CmdSludgeDischargeSLB1.CommandLogic.PID";
			this.sBarPvSpOpVert2.EndInit();
			// 
			// sBarPvSpOpVert1
			// 
			this.sBarPvSpOpVert1.BeginInit();
			this.sBarPvSpOpVert1.DefaultInstanceName = null;
			this.sBarPvSpOpVert1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1240D, 128D);
			this.sBarPvSpOpVert1.DisplayType = SE.App2CommonProcess.SupportClasses.PidDisplayType.PvSpOp;
			this.sBarPvSpOpVert1.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sBarPvSpOpVert1.MyTagDisplayName = null;
			this.sBarPvSpOpVert1.Name = "sBarPvSpOpVert1";
			this.sBarPvSpOpVert1.SecurityToken = ((uint)(4294967295u));
			this.sBarPvSpOpVert1.TagName = "9AA3696311BF0C3E.Logic.CmdWaterDischargeSLB1.CommandLogic.PID";
			this.sBarPvSpOpVert1.EndInit();
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2.DefaultInstanceName = null;
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1177D, 170D);
			this.sDefault2.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sDefault2.MyTagDisplayName = null;
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.TagName = "9AA3696311BF0C3E.Logic.CmdWaterDischargeSLB1.CommandLogic.Autotune1";
			this.sDefault2.EndInit();
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
			this.SludgeBuffer_3,
			this.sDefault1,
			this.sBarPvSpOpVert2,
			this.sBarPvSpOpVert1,
			this.sDefault2});
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
		private SE.App2CommonProcess.Symbols.PID.sBarPvSpOpVert sBarPvSpOpVert1;
		private SE.App2CommonProcess.Symbols.Autotune.sDefault sDefault1;
		private SE.App2CommonProcess.Symbols.PID.sBarPvSpOpVert sBarPvSpOpVert2;
		private SE.App2CommonProcess.Symbols.Autotune.sDefault sDefault2;
		#endregion
	}
}
