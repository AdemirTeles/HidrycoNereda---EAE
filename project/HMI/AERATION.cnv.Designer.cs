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
			this.btnReator1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.btnReator2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.pipeReator1 = new NxtControl.GuiFramework.Pipe();
			this.pipeReator2 = new NxtControl.GuiFramework.Pipe();
			this.vlvAeracaoR1 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.vlvAeracaoR2 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.vazaoArR1 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.vazaoArR2 = new SE.Nereda.Symbols.AnalogInput.sDisplayPv2();
			this.AjustesAeracao = new SE.Nereda.Symbols.CAerationLogic.sSettingsBtn();
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
			this.AERATION_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3D, 0D, 0D, 1.3D, 308D, 272D);
			this.AERATION_1.Name = "AERATION_1";
			this.AERATION_1.SecurityToken = ((uint)(4294967295u));
			this.AERATION_1.TagName = "35A194BD3A715270";
			this.AERATION_1.EndInit();
			//
			// btnReator1
			//
			this.btnReator1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(152D)), ((float)(162D)), ((float)(36D)));
			this.btnReator1.CanvasName = "REACTOR1";
			this.btnReator1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnReator1.Name = "btnReator1";
			this.btnReator1.Text = "‹  REATOR NEREDA 1";
			//
			// btnReator2
			//
			this.btnReator2.Bounds = new NxtControl.Drawing.RectF(((float)(1196D)), ((float)(152D)), ((float)(162D)), ((float)(36D)));
			this.btnReator2.CanvasName = "REACTOR2";
			this.btnReator2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnReator2.Name = "btnReator2";
			this.btnReator2.Text = "REATOR NEREDA 2  ›";
			//
			// pipeReator1
			//
			this.pipeReator1.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(170D)), ((float)(221.2D)), ((float)(117.6D)));
			this.pipeReator1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipeReator1.Name = "pipeReator1";
			this.pipeReator1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipeReator1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(391.2D, 287.6D),
			new NxtControl.Drawing.PointF(391.2D, 170D),
			new NxtControl.Drawing.PointF(170D, 170D)});
			this.pipeReator1.Width = 13;
			//
			// pipeReator2
			//
			this.pipeReator2.Bounds = new NxtControl.Drawing.RectF(((float)(906D)), ((float)(170D)), ((float)(290D)), ((float)(117.6D)));
			this.pipeReator2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipeReator2.Name = "pipeReator2";
			this.pipeReator2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipeReator2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(906D, 287.6D),
			new NxtControl.Drawing.PointF(906D, 170D),
			new NxtControl.Drawing.PointF(1196D, 170D)});
			this.pipeReator2.Width = 13;
			//
			// vlvAeracaoR1
			//
			this.vlvAeracaoR1.BeginInit();
			this.vlvAeracaoR1._iVlvName = "AV41170";
			this.vlvAeracaoR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3D, 0D, 0D, 1.3D, 212.4D, 107.6D);
			this.vlvAeracaoR1.Name = "vlvAeracaoR1";
			this.vlvAeracaoR1.SecurityToken = ((uint)(4294967295u));
			this.vlvAeracaoR1.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.vlvAeracaoR1.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.vlvAeracaoR1.TagName = "0F513B831BAFCB32.Actuators.AerationBlockValve_AV4x170";
			this.vlvAeracaoR1.EndInit();
			//
			// vlvAeracaoR2
			//
			this.vlvAeracaoR2.BeginInit();
			this.vlvAeracaoR2._iVlvName = "AV42170";
			this.vlvAeracaoR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3D, 0D, 0D, 1.3D, 1018.4D, 107.6D);
			this.vlvAeracaoR2.Name = "vlvAeracaoR2";
			this.vlvAeracaoR2.SecurityToken = ((uint)(4294967295u));
			this.vlvAeracaoR2.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.vlvAeracaoR2.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.vlvAeracaoR2.TagName = "19E8555E9622C1D3.Actuators.AerationBlockValve_AV4x170";
			this.vlvAeracaoR2.EndInit();
			//
			// vazaoArR1
			//
			this.vazaoArR1.BeginInit();
			this.vazaoArR1._iSensorName = "Vaz\u00e3o de ar R1";
			this.vazaoArR1._iUnit = "";
			this.vazaoArR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 13D, 200D);
			this.vazaoArR1.Name = "vazaoArR1";
			this.vazaoArR1.SecurityToken = ((uint)(4294967295u));
			this.vazaoArR1.TagName = "0F513B831BAFCB32.Sensors.AirFlowMeasurementReactor";
			this.vazaoArR1.EndInit();
			//
			// vazaoArR2
			//
			this.vazaoArR2.BeginInit();
			this.vazaoArR2._iSensorName = "Vaz\u00e3o de ar R2";
			this.vazaoArR2._iUnit = "";
			this.vazaoArR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1201D, 200D);
			this.vazaoArR2.Name = "vazaoArR2";
			this.vazaoArR2.SecurityToken = ((uint)(4294967295u));
			this.vazaoArR2.TagName = "19E8555E9622C1D3.Sensors.AirFlowMeasurementReactor";
			this.vazaoArR2.EndInit();
			//
			// AjustesAeracao
			//
			this.AjustesAeracao.BeginInit();
			this.AjustesAeracao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1238D, 8D);
			this.AjustesAeracao.Name = "AjustesAeracao";
			this.AjustesAeracao.SecurityToken = ((uint)(4294967295u));
			this.AjustesAeracao.TagName = "35A194BD3A715270.Logic";
			this.AjustesAeracao.EndInit();
			// 
			// AERATION
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.pipeReator1,
			this.pipeReator2,
			this.AERATION_1,
			this.btnReator1,
			this.btnReator2,
			this.vlvAeracaoR1,
			this.vlvAeracaoR2,
			this.vazaoArR1,
			this.vazaoArR2,
			this.AjustesAeracao,
			this.btnAckNereda});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.NeredaCAeration.sBlowers AERATION_1;
		private NxtControl.GuiFramework.DrawnButton btnAckNereda;
		private NxtControl.GuiFramework.ChangeCanvasButton btnReator1;
		private NxtControl.GuiFramework.ChangeCanvasButton btnReator2;
		private NxtControl.GuiFramework.Pipe pipeReator1;
		private NxtControl.GuiFramework.Pipe pipeReator2;
		private SE.Nereda.Symbols.ValveS.sDefault vlvAeracaoR1;
		private SE.Nereda.Symbols.ValveS.sDefault vlvAeracaoR2;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 vazaoArR1;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv2 vazaoArR2;
		private SE.Nereda.Symbols.CAerationLogic.sSettingsBtn AjustesAeracao;
		#endregion
	}
}
