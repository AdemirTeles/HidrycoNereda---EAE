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
			this.btnAckNereda = new NxtControl.GuiFramework.DrawnButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.rotPid = new NxtControl.GuiFramework.FreeText();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.SludgeBuffer_1 = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSettingsSLB();
			this.SludgeBuffer = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSludgeBufferyellow();
			this.SludgeBuffer_2 = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sPhases();
			this.SludgeBuffer_3 = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSensors();
			this.sBarPvSpOpVert2 = new SE.App2CommonProcess.Symbols.PID.sBarPvSpOpVert();
			this.sDisplayPv21 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sDisplayPv22 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.sVertical1 = new SE.Nereda.Symbols.AnalogInput.sVertical();
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
			// SludgeBuffer_1
			// 
			this.SludgeBuffer_1.BeginInit();
			this.SludgeBuffer_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1238D, 8D);
			this.SludgeBuffer_1.Name = "SludgeBuffer_1";
			this.SludgeBuffer_1.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer_1.TagName = "2EDD2709EE346B30";
			this.SludgeBuffer_1.EndInit();
			// 
			// SludgeBuffer
			// 
			this.SludgeBuffer.BeginInit();
			this.SludgeBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 240D);
			this.SludgeBuffer.Name = "SludgeBuffer";
			this.SludgeBuffer.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer.TagName = "2EDD2709EE346B30";
			this.SludgeBuffer.EndInit();
			// 
			// SludgeBuffer_2
			// 
			this.SludgeBuffer_2.BeginInit();
			this.SludgeBuffer_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 60D);
			this.SludgeBuffer_2.Name = "SludgeBuffer_2";
			this.SludgeBuffer_2.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer_2.TagName = "2EDD2709EE346B30";
			this.SludgeBuffer_2.EndInit();
			// 
			// SludgeBuffer_3
			// 
			this.SludgeBuffer_3.BeginInit();
			this.SludgeBuffer_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 488D, 64D);
			this.SludgeBuffer_3.Name = "SludgeBuffer_3";
			this.SludgeBuffer_3.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer_3.TagName = "2EDD2709EE346B30";
			this.SludgeBuffer_3.EndInit();
			// 
			// rotPid
			// 
			this.rotPid.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rotPid.Font = new NxtControl.Drawing.Font("LabelFont");
			this.rotPid.Location = new NxtControl.Drawing.PointF(1150D, 46D);
			this.rotPid.Name = "rotPid";
			this.rotPid.Text = "PID da descarga";
			// 
			// sBarPvSpOpVert2
			// 
			this.sBarPvSpOpVert2.BeginInit();
			this.sBarPvSpOpVert2.DefaultInstanceName = null;
			this.sBarPvSpOpVert2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1150D, 64D);
			this.sBarPvSpOpVert2.DisplayType = SE.App2CommonProcess.SupportClasses.PidDisplayType.PvSpOp;
			this.sBarPvSpOpVert2.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sBarPvSpOpVert2.MyTagDisplayName = null;
			this.sBarPvSpOpVert2.Name = "sBarPvSpOpVert2";
			this.sBarPvSpOpVert2.SecurityToken = ((uint)(4294967295u));
			this.sBarPvSpOpVert2.TagName = "2EDD2709EE346B30.Logic.CmdWaterDischargeSLB1.CommandLogic.PID";
			this.sBarPvSpOpVert2.EndInit();
			// 
			// sDisplayPv21
			// 
			this.sDisplayPv21.BeginInit();
			this.sDisplayPv21._iSensorName = "900-LIT-01 Tanque 1";
			this.sDisplayPv21._iUnit = "m";
			this.sDisplayPv21.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7368421052631579D, 0D, 0D, 0.7368421052631579D, 1210D, 475D);
			this.sDisplayPv21.Name = "sDisplayPv21";
			this.sDisplayPv21.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv21.TagName = "428D497DE5BC46AE.LevelMeasurementReactor";
			this.sDisplayPv21.EndInit();
			// 
			// sDisplayPv22
			// 
			this.sDisplayPv22.BeginInit();
			this.sDisplayPv22._iSensorName = "900-LIT-02 Tanque 2";
			this.sDisplayPv22._iUnit = "m";
			this.sDisplayPv22.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7368421052631579D, 0D, 0D, 0.7368421052631579D, 1210D, 377D);
			this.sDisplayPv22.Name = "sDisplayPv22";
			this.sDisplayPv22.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPv22.TagName = "15BC11099FA14F71.LevelMeasurementReactor";
			this.sDisplayPv22.EndInit();
			// 
			// sVertical1
			// 
			this.sVertical1.BeginInit();
			this.sVertical1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 160D, 400D);
			this.sVertical1.Name = "sVertical1";
			this.sVertical1.SecurityToken = ((uint)(4294967295u));
			this.sVertical1.TagName = "2EDD2709EE346B30.Sensors.LevelMeasurementSludgeBuffer";
			this.sVertical1.EndInit();
			// 
			// SLUDGE_BUFFER
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.SludgeBuffer_1,
			this.SludgeBuffer,
			this.SludgeBuffer_2,
			this.SludgeBuffer_3,
			this.rotPid,
			this.sBarPvSpOpVert2,
			this.sDisplayPv21,
			this.btnAckNereda,
			this.sDisplayPv22,
			this.sVertical1});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSludgeBufferyellow SludgeBuffer;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSettingsSLB SludgeBuffer_1;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sPhases SludgeBuffer_2;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSensors SludgeBuffer_3;
		private NxtControl.GuiFramework.FreeText rotPid;
		private SE.App2CommonProcess.Symbols.PID.sBarPvSpOpVert sBarPvSpOpVert2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv21;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 sDisplayPv22;
		private NxtControl.GuiFramework.DrawnButton btnAckNereda;
		private SE.Nereda.Symbols.AnalogInput.sVertical sVertical1;
		#endregion
	}
}
