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
			this.btnAckNereda = new NxtControl.GuiFramework.DrawnButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.Mode_1 = new SE.Nereda.Symbols.Mode.ResetReactor1();
			this.sSensors1 = new SE.Nereda.Symbols.NeredaReactor.sSensors();
			this.sReactor41 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.sPhase21 = new SE.Nereda.Symbols.NeredaReactor.sPhase2();
			this.sSettingsBtn1 = new SE.Nereda.Symbols.NeredaReactor.sSettingsBtn();
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
			// Mode_1
			// 
			this.Mode_1.BeginInit();
			this.Mode_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1112D, 8D);
			this.Mode_1.Name = "Mode_1";
			this.Mode_1.SecurityToken = ((uint)(4294967295u));
			this.Mode_1.TagName = "ECC9B0BB08A85534";
			this.Mode_1.EndInit();
			// 
			// sSensors1
			// 
			this.sSensors1.BeginInit();
			this.sSensors1._iReator = "41";
			this.sSensors1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.79120474507283622D, 0D, 0D, 0.88387713675213642D, 24.000000000000004D, 320.00000000000006D);
			this.sSensors1.Name = "sSensors1";
			this.sSensors1.SecurityToken = ((uint)(4294967295u));
			this.sSensors1.TagName = "0F513B831BAFCB32";
			this.sSensors1.EndInit();
			// 
			// sReactor41
			// 
			this.sReactor41.BeginInit();
			this.sReactor41._iAV4x101 = "AV41101\r\nAlimentação";
			this.sReactor41._iAV4x102 = "AV41102\r\nNível inferior";
			this.sReactor41._iAV4x103 = "AV41103\r\nDescarte de lodo";
			this.sReactor41._iAV4x170 = "AV41170\r\nAeração";
			this.sReactor41._iAV4x171 = "AV41171\r\nPressurização";
			this.sReactor41._iAV4x172 = "AV41172\r\nRespiro lodo";
			this.sReactor41._iLT001 = "41LT1005\r\nNível";
			this.sReactor41._iREACTOR = "Reator Nereda 1";
			this.sReactor41.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8669833729216152D, 0D, 0D, 0.8669833729216152D, 496D, 152D);
			this.sReactor41.Name = "sReactor41";
			this.sReactor41.SecurityToken = ((uint)(4294967295u));
			this.sReactor41.TagName = "0F513B831BAFCB32";
			this.sReactor41.EndInit();
			// 
			// sPhase21
			// 
			this.sPhase21.BeginInit();
			this.sPhase21.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.87931034482758619D, 0D, 0D, 0.87931034482758619D, 16D, 72D);
			this.sPhase21.Name = "sPhase21";
			this.sPhase21.SecurityToken = ((uint)(4294967295u));
			this.sPhase21.TagName = "0F513B831BAFCB32";
			this.sPhase21.EndInit();
			// 
			// sSettingsBtn1
			// 
			this.sSettingsBtn1.BeginInit();
			this.sSettingsBtn1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1112D, 72D);
			this.sSettingsBtn1.Name = "sSettingsBtn1";
			this.sSettingsBtn1.SecurityToken = ((uint)(4294967295u));
			this.sSettingsBtn1.TagName = "0F513B831BAFCB32";
			this.sSettingsBtn1.EndInit();
			// 
			// REACTOR1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.Mode_1,
			this.sSensors1,
			this.sReactor41,
			this.sPhase21,
			this.btnAckNereda,
			this.sSettingsBtn1});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Mode.ResetReactor1 Mode_1;
		private SE.Nereda.Symbols.NeredaReactor.sSensors sSensors1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 sReactor41;
		private SE.Nereda.Symbols.NeredaReactor.sPhase2 sPhase21;
		private SE.Nereda.Symbols.NeredaReactor.sSettingsBtn sSettingsBtn1;
		private NxtControl.GuiFramework.DrawnButton btnAckNereda;
		#endregion
	}
}
