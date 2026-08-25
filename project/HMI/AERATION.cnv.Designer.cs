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
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.AERATION_1 = new SE.Nereda.Symbols.NeredaCAeration.sBlowers();
			this.REACTOR01 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.REACTOR02 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.REACTOR01_1 = new SE.Nereda.Symbols.NeredaReactor.sSettingsBtn();
			this.REACTOR02_1 = new SE.Nereda.Symbols.NeredaReactor.sSettingsBtn();
			this.REACTOR01_2 = new SE.Nereda.Symbols.NeredaReactor.sPhases();
			this.REACTOR02_2 = new SE.Nereda.Symbols.NeredaReactor.sPhases();
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
			// AERATION_1
			// 
			this.AERATION_1.BeginInit();
			this.AERATION_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.99038461538461553D, 0D, 0D, 1D, 12D, 408D);
			this.AERATION_1.Name = "AERATION_1";
			this.AERATION_1.SecurityToken = ((uint)(4294967295u));
			this.AERATION_1.TagName = "6307B68BAFBA5753";
			this.AERATION_1.EndInit();
			// 
			// REACTOR01
			// 
			this.REACTOR01.BeginInit();
			this.REACTOR01._iLT001 = "41LT1005";
			this.REACTOR01._iREACTOR = "Reactor 1";
			this.REACTOR01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6811594202898551D, 0D, 0D, 0.6811594202898551D, 512D, 88D);
			this.REACTOR01.Name = "REACTOR01";
			this.REACTOR01.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01.EndInit();
			// 
			// REACTOR02
			// 
			this.REACTOR02.BeginInit();
			this.REACTOR02._iLT001 = "42LT1005";
			this.REACTOR02._iREACTOR = "Reactor 2";
			this.REACTOR02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6811594202898551D, 0D, 0D, 0.68112244897959184D, 512D, 408D);
			this.REACTOR02.Name = "REACTOR02";
			this.REACTOR02.SecurityToken = ((uint)(4294967295u));
			this.REACTOR02.TagName = "B553EA539882D2E1";
			this.REACTOR02.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(72D)), ((float)(504D)), ((float)(384D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 456D),
			new NxtControl.Drawing.PointF(24D, 72D),
			new NxtControl.Drawing.PointF(528D, 72D),
			new NxtControl.Drawing.PointF(528D, 88D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(416D)), ((float)(392D)), ((float)(112D)), ((float)(56D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(528D, 408D),
			new NxtControl.Drawing.PointF(528D, 392D),
			new NxtControl.Drawing.PointF(416D, 392D),
			new NxtControl.Drawing.PointF(416D, 448D)});
			this.pipe2.Width = 10;
			// 
			// REACTOR01_1
			// 
			this.REACTOR01_1.BeginInit();
			this.REACTOR01_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 896D, 288D);
			this.REACTOR01_1.Name = "REACTOR01_1";
			this.REACTOR01_1.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01_1.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01_1.EndInit();
			// 
			// REACTOR02_1
			// 
			this.REACTOR02_1.BeginInit();
			this.REACTOR02_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 896D, 608D);
			this.REACTOR02_1.Name = "REACTOR02_1";
			this.REACTOR02_1.SecurityToken = ((uint)(4294967295u));
			this.REACTOR02_1.TagName = "B553EA539882D2E1";
			this.REACTOR02_1.EndInit();
			// 
			// REACTOR01_2
			// 
			this.REACTOR01_2.BeginInit();
			this.REACTOR01_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 896D, 88D);
			this.REACTOR01_2.Name = "REACTOR01_2";
			this.REACTOR01_2.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01_2.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01_2.EndInit();
			// 
			// REACTOR02_2
			// 
			this.REACTOR02_2.BeginInit();
			this.REACTOR02_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 896D, 408D);
			this.REACTOR02_2.Name = "REACTOR02_2";
			this.REACTOR02_2.SecurityToken = ((uint)(4294967295u));
			this.REACTOR02_2.TagName = "B553EA539882D2E1";
			this.REACTOR02_2.EndInit();
			// 
			// AERATION
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.AERATION_1,
			this.REACTOR01,
			this.REACTOR02,
			this.pipe1,
			this.pipe2,
			this.REACTOR01_1,
			this.REACTOR02_1,
			this.REACTOR01_2,
			this.REACTOR02_2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.NeredaCAeration.sBlowers AERATION_1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 REACTOR01;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 REACTOR02;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private SE.Nereda.Symbols.NeredaReactor.sSettingsBtn REACTOR01_1;
		private SE.Nereda.Symbols.NeredaReactor.sSettingsBtn REACTOR02_1;
		private SE.Nereda.Symbols.NeredaReactor.sPhases REACTOR01_2;
		private SE.Nereda.Symbols.NeredaReactor.sPhases REACTOR02_2;
		#endregion
	}
}
