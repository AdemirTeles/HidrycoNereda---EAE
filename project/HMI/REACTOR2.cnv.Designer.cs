/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 4:04 PM
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
	/// Summary description for REACTOR2.
	/// </summary>
	partial class REACTOR2
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.NVPP_REACTOR02 = new SE.Nereda.Symbols.NeredaReactor.sPhases();
			this.NVPP_REACTOR02_3 = new SE.Nereda.Symbols.NeredaReactor.sSettingsBtn();
			this.Mode_1 = new SE.Nereda.Symbols.Mode.ResetReactor2();
			this.changeCanvasButton1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton5 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.sDefault1 = new SE.Nereda.Symbols.ResetValvesManager.sDefault();
			this.REACTOR02 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
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
			// MCCPower
			// 
			this.MCCPower.BeginInit();
			this.MCCPower.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 8D);
			this.MCCPower.Name = "MCCPower";
			this.MCCPower.SecurityToken = ((uint)(4294967295u));
			this.MCCPower.TagName = "E1E3B3442DD19945";
			this.MCCPower.EndInit();
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
			// sHiHiLevelCalamity1
			// 
			this.sHiHiLevelCalamity1.BeginInit();
			this.sHiHiLevelCalamity1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 632D, 8D);
			this.sHiHiLevelCalamity1.Name = "sHiHiLevelCalamity1";
			this.sHiHiLevelCalamity1.SecurityToken = ((uint)(4294967295u));
			this.sHiHiLevelCalamity1.TagName = "F2F66466CB372A96.EffluentLogic.Calamity";
			this.sHiHiLevelCalamity1.EndInit();
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
			// NVPP_REACTOR02
			// 
			this.NVPP_REACTOR02.BeginInit();
			this.NVPP_REACTOR02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 64D);
			this.NVPP_REACTOR02.Name = "NVPP_REACTOR02";
			this.NVPP_REACTOR02.SecurityToken = ((uint)(4294967295u));
			this.NVPP_REACTOR02.TagName = "B553EA539882D2E1";
			this.NVPP_REACTOR02.EndInit();
			// 
			// NVPP_REACTOR02_3
			// 
			this.NVPP_REACTOR02_3.BeginInit();
			this.NVPP_REACTOR02_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 976D, 8D);
			this.NVPP_REACTOR02_3.Name = "NVPP_REACTOR02_3";
			this.NVPP_REACTOR02_3.SecurityToken = ((uint)(4294967295u));
			this.NVPP_REACTOR02_3.TagName = "B553EA539882D2E1";
			this.NVPP_REACTOR02_3.EndInit();
			// 
			// Mode_1
			// 
			this.Mode_1.BeginInit();
			this.Mode_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1112D, 8D);
			this.Mode_1.Name = "Mode_1";
			this.Mode_1.SecurityToken = ((uint)(4294967191u));
			this.Mode_1.TagName = "7A79C015B9ADE3EB";
			this.Mode_1.EndInit();
			// 
			// changeCanvasButton1
			// 
			this.changeCanvasButton1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(592D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton1.CanvasName = "SLUDGE_BUFFER";
			this.changeCanvasButton1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton1.Name = "changeCanvasButton1";
			this.changeCanvasButton1.Text = "SLUDGE BUFFER";
			// 
			// changeCanvasButton2
			// 
			this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(640D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton2.CanvasName = "INFLUENT_FEED";
			this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton2.Name = "changeCanvasButton2";
			this.changeCanvasButton2.Text = "INFLUENT FEED";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(544D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton4.CanvasName = "EFFLUENT";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "EFFLUENT";
			// 
			// changeCanvasButton5
			// 
			this.changeCanvasButton5.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(496D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton5.CanvasName = "ALARMS";
			this.changeCanvasButton5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton5.Name = "changeCanvasButton5";
			this.changeCanvasButton5.Text = "ALARMS";
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 488D, 64D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "B553EA539882D2E1.Actuators.ResetAllValves";
			this.sDefault1.EndInit();
			// 
			// REACTOR02
			// 
			this.REACTOR02.BeginInit();
			this.REACTOR02._iAV4x101 = "AV4x101";
			this.REACTOR02._iAV4x103 = "AV4x103";
			this.REACTOR02._iAV4x107 = "AV4x107";
			this.REACTOR02._iAV4x171 = "AV4x171";
			this.REACTOR02._iAV4x172 = "AV4x172";
			this.REACTOR02._iLT001 = "42LT1005";
			this.REACTOR02._iREACTOR = "Reactor 2";
			this.REACTOR02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 600D, 200D);
			this.REACTOR02.Name = "REACTOR02";
			this.REACTOR02.SecurityToken = ((uint)(4294967295u));
			this.REACTOR02.TagName = "B553EA539882D2E1";
			this.REACTOR02.EndInit();
			// 
			// REACTOR2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.NVPP_REACTOR02,
			this.NVPP_REACTOR02_3,
			this.Mode_1,
			this.changeCanvasButton1,
			this.changeCanvasButton2,
			this.changeCanvasButton4,
			this.changeCanvasButton5,
			this.sDefault1,
			this.REACTOR02});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton1;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton5;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.NeredaReactor.sPhases NVPP_REACTOR02;
		private SE.Nereda.Symbols.NeredaReactor.sSettingsBtn NVPP_REACTOR02_3;
		private SE.Nereda.Symbols.Mode.ResetReactor2 Mode_1;
		private SE.Nereda.Symbols.ResetValvesManager.sDefault sDefault1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 REACTOR02;
		#endregion
	}
}
