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
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.EmergencyManagement = new SE.Nereda.Symbols.EmergencyManagement.sDataR1();
			this.EmergencyManagement_1 = new SE.Nereda.Symbols.EmergencyManagement.sSettingsBtn();
			this.EmergencyManagement_2 = new SE.Nereda.Symbols.EmergencyManagement.sDataR2();
			this.EmergencyManagement_3 = new SE.Nereda.Symbols.EmergencyManagement.sDataR3();
			this.EmergencyManagement_4 = new SE.Nereda.Symbols.EmergencyManagement.sReactorAvExist();
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
			// EMERGENCY_RECIPE
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.OpenWebPage,
			this.EmergencyManagement,
			this.EmergencyManagement_1,
			this.EmergencyManagement_2,
			this.EmergencyManagement_3,
			this.EmergencyManagement_4});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR1 EmergencyManagement;
		private SE.Nereda.Symbols.EmergencyManagement.sSettingsBtn EmergencyManagement_1;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR2 EmergencyManagement_2;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR3 EmergencyManagement_3;
		private SE.Nereda.Symbols.EmergencyManagement.sReactorAvExist EmergencyManagement_4;
		#endregion
	}
}
