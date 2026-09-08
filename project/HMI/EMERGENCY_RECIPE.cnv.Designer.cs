/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/5/2026
 * Time: 1:58 AM
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
	/// Summary description for EMERGENCY_RECIPE.
	/// </summary>
	partial class EMERGENCY_RECIPE
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
			this.NVPP_REACTOR01 = new SE.Nereda.Symbols.NeredaReactor.sPhases();
			this.NVPP_REACTOR02 = new SE.Nereda.Symbols.NeredaReactor.sPhases();
			this.EmergencyR1 = new SE.Nereda.Symbols.EmergencyReactor.sDefault();
			this.EmergencyR2 = new SE.Nereda.Symbols.EmergencyReactor.sDefault();
			this.EmergencyManagement = new SE.Nereda.Symbols.EmergencyManagement.sDataR1();
			this.EmergencyManagement_1 = new SE.Nereda.Symbols.EmergencyManagement.sSettingsBtn();
			this.EmergencyManagement_2 = new SE.Nereda.Symbols.EmergencyManagement.sDataR2();
			this.EmergencyManagement_3 = new SE.Nereda.Symbols.EmergencyManagement.sDataR3();
			this.EmergencyManagement_4 = new SE.Nereda.Symbols.EmergencyManagement.sReactorAvExist();
			this.EmergencyR1_2 = new SE.Nereda.Symbols.EmergencyReactor.sWarning();
			this.EmergencyR2_2 = new SE.Nereda.Symbols.EmergencyReactor.sWarning();
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
			// NVPP_REACTOR01
			// 
			this.NVPP_REACTOR01.BeginInit();
			this.NVPP_REACTOR01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.91379310344827591D, 0D, 0D, 0.91145833333333337D, 16D, 512D);
			this.NVPP_REACTOR01.Name = "NVPP_REACTOR01";
			this.NVPP_REACTOR01.SecurityToken = ((uint)(4294967295u));
			this.NVPP_REACTOR01.TagName = "D32FABF3E7C17DE2";
			this.NVPP_REACTOR01.EndInit();
			// 
			// NVPP_REACTOR02
			// 
			this.NVPP_REACTOR02.BeginInit();
			this.NVPP_REACTOR02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.91379310344827591D, 0D, 0D, 0.91145833333333337D, 472D, 512D);
			this.NVPP_REACTOR02.Name = "NVPP_REACTOR02";
			this.NVPP_REACTOR02.SecurityToken = ((uint)(4294967295u));
			this.NVPP_REACTOR02.TagName = "B553EA539882D2E1";
			this.NVPP_REACTOR02.EndInit();
			// 
			// EmergencyR1
			// 
			this.EmergencyR1.BeginInit();
			this.EmergencyR1._iReactorName = "REACTOR 01";
			this.EmergencyR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 48D);
			this.EmergencyR1.Name = "EmergencyR1";
			this.EmergencyR1.SecurityToken = ((uint)(4294967295u));
			this.EmergencyR1.TagName = "E4C7D0B09BE668D4";
			this.EmergencyR1.EndInit();
			// 
			// EmergencyR2
			// 
			this.EmergencyR2.BeginInit();
			this.EmergencyR2._iReactorName = "REACTOR 02";
			this.EmergencyR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 472D, 48D);
			this.EmergencyR2.Name = "EmergencyR2";
			this.EmergencyR2.SecurityToken = ((uint)(4294967295u));
			this.EmergencyR2.TagName = "2D7E078AB6CE14BC";
			this.EmergencyR2.EndInit();
			// 
			// EmergencyManagement
			// 
			this.EmergencyManagement.BeginInit();
			this.EmergencyManagement.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 64D);
			this.EmergencyManagement.Name = "EmergencyManagement";
			this.EmergencyManagement.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement.EndInit();
			// 
			// EmergencyManagement_1
			// 
			this.EmergencyManagement_1.BeginInit();
			this.EmergencyManagement_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 976D, 8D);
			this.EmergencyManagement_1.Name = "EmergencyManagement_1";
			this.EmergencyManagement_1.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement_1.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement_1.EndInit();
			// 
			// EmergencyManagement_2
			// 
			this.EmergencyManagement_2.BeginInit();
			this.EmergencyManagement_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 672D, 64D);
			this.EmergencyManagement_2.Name = "EmergencyManagement_2";
			this.EmergencyManagement_2.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement_2.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement_2.EndInit();
			// 
			// EmergencyManagement_3
			// 
			this.EmergencyManagement_3.BeginInit();
			this.EmergencyManagement_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1128D, 64D);
			this.EmergencyManagement_3.Name = "EmergencyManagement_3";
			this.EmergencyManagement_3.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement_3.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement_3.EndInit();
			// 
			// EmergencyManagement_4
			// 
			this.EmergencyManagement_4.BeginInit();
			this.EmergencyManagement_4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1152D, 8D);
			this.EmergencyManagement_4.Name = "EmergencyManagement_4";
			this.EmergencyManagement_4.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement_4.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement_4.EndInit();
			// 
			// EmergencyR1_2
			// 
			this.EmergencyR1_2.BeginInit();
			this.EmergencyR1_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 64D);
			this.EmergencyR1_2.Name = "EmergencyR1_2";
			this.EmergencyR1_2.SecurityToken = ((uint)(4294967295u));
			this.EmergencyR1_2.TagName = "E4C7D0B09BE668D4";
			this.EmergencyR1_2.EndInit();
			// 
			// EmergencyR2_2
			// 
			this.EmergencyR2_2.BeginInit();
			this.EmergencyR2_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 672D, 64D);
			this.EmergencyR2_2.Name = "EmergencyR2_2";
			this.EmergencyR2_2.SecurityToken = ((uint)(4294967295u));
			this.EmergencyR2_2.TagName = "2D7E078AB6CE14BC";
			this.EmergencyR2_2.EndInit();
			// 
			// EMERGENCY_RECIPE
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.NVPP_REACTOR01,
			this.NVPP_REACTOR02,
			this.EmergencyR1,
			this.EmergencyR2,
			this.OpenWebPage,
			this.EmergencyManagement,
			this.EmergencyManagement_1,
			this.EmergencyManagement_2,
			this.EmergencyManagement_3,
			this.EmergencyManagement_4,
			this.EmergencyR1_2,
			this.EmergencyR2_2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.NeredaReactor.sPhases NVPP_REACTOR01;
		private SE.Nereda.Symbols.NeredaReactor.sPhases NVPP_REACTOR02;
		private SE.Nereda.Symbols.EmergencyReactor.sDefault EmergencyR1;
		private SE.Nereda.Symbols.EmergencyReactor.sDefault EmergencyR2;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR1 EmergencyManagement;
		private SE.Nereda.Symbols.EmergencyManagement.sSettingsBtn EmergencyManagement_1;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR2 EmergencyManagement_2;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR3 EmergencyManagement_3;
		private SE.Nereda.Symbols.EmergencyManagement.sReactorAvExist EmergencyManagement_4;
		private SE.Nereda.Symbols.EmergencyReactor.sWarning EmergencyR1_2;
		private SE.Nereda.Symbols.EmergencyReactor.sWarning EmergencyR2_2;
		#endregion
	}
}
