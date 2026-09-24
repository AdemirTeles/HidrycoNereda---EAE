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
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.Mode_1 = new SE.Nereda.Symbols.Mode.ResetReactor1();
			this.sSensors1 = new SE.Nereda.Symbols.NeredaReactor.sSensors();
			this.sReactor41 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.sPhase21 = new SE.Nereda.Symbols.NeredaReactor.sPhase2();
			this.sSettingsBtn1 = new SE.Nereda.Symbols.NeredaReactor.sSettingsBtn();
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
			// Mode_1
			// 
			this.Mode_1.BeginInit();
			this.Mode_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1112D, 8D);
			this.Mode_1.Name = "Mode_1";
			this.Mode_1.SecurityToken = ((uint)(4294967295u));
			this.Mode_1.TagName = "7A79C015B9ADE3EB";
			this.Mode_1.EndInit();
			// 
			// sSensors1
			// 
			this.sSensors1.BeginInit();
			this.sSensors1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.79120474507283622D, 0D, 0D, 0.88387713675213642D, 24.000000000000004D, 320.00000000000006D);
			this.sSensors1.Name = "sSensors1";
			this.sSensors1.SecurityToken = ((uint)(4294967295u));
			this.sSensors1.TagName = "D41247DF3E1D30DC";
			this.sSensors1.EndInit();
			// 
			// sReactor41
			// 
			this.sReactor41.BeginInit();
			this.sReactor41._iAV4x101 = "AV4x101";
			this.sReactor41._iAV4x102 = "AV4x102";
			this.sReactor41._iAV4x103 = "AV4x103";
			this.sReactor41._iAV4x170 = "AV4x170";
			this.sReactor41._iAV4x171 = "AV4x171";
			this.sReactor41._iAV4x172 = "AV4x172";
			this.sReactor41._iLT001 = "4xLT1005";
			this.sReactor41._iREACTOR = "Reactor 1";
			this.sReactor41.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8669833729216152D, 0D, 0D, 0.8669833729216152D, 496D, 152D);
			this.sReactor41.Name = "sReactor41";
			this.sReactor41.SecurityToken = ((uint)(4294967295u));
			this.sReactor41.TagName = "D41247DF3E1D30DC";
			this.sReactor41.EndInit();
			// 
			// sPhase21
			// 
			this.sPhase21.BeginInit();
			this.sPhase21.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.87931034482758619D, 0D, 0D, 0.87931034482758619D, 16D, 72D);
			this.sPhase21.Name = "sPhase21";
			this.sPhase21.SecurityToken = ((uint)(4294967295u));
			this.sPhase21.TagName = "D41247DF3E1D30DC";
			this.sPhase21.EndInit();
			// 
			// sSettingsBtn1
			// 
			this.sSettingsBtn1.BeginInit();
			this.sSettingsBtn1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1112D, 72D);
			this.sSettingsBtn1.Name = "sSettingsBtn1";
			this.sSettingsBtn1.SecurityToken = ((uint)(4294967295u));
			this.sSettingsBtn1.TagName = "D41247DF3E1D30DC";
			this.sSettingsBtn1.EndInit();
			// 
			// REACTOR1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.OpenWebPage,
			this.Mode_1,
			this.sSensors1,
			this.sReactor41,
			this.sPhase21,
			this.sSettingsBtn1});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.Mode.ResetReactor1 Mode_1;
		private SE.Nereda.Symbols.NeredaReactor.sSensors sSensors1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 sReactor41;
		private SE.Nereda.Symbols.NeredaReactor.sPhase2 sPhase21;
		private SE.Nereda.Symbols.NeredaReactor.sSettingsBtn sSettingsBtn1;
		#endregion
	}
}
