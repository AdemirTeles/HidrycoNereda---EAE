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
			this.btnAckNereda = new NxtControl.GuiFramework.DrawnButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.EmergencyManagement_4 = new SE.Nereda.Symbols.EmergencyManagement.sReactorAvExist();
			this.EmergencyManagement_3 = new SE.Nereda.Symbols.EmergencyManagement.sSettingsBtn();
			this.EmergencyReactor1 = new SE.Nereda.Symbols.EmergencyReactor_2.sDefault();
			this.WarningR1 = new SE.Nereda.Symbols.EmergencyReactor_2.sWarning();
			this.WarningR2 = new SE.Nereda.Symbols.EmergencyReactor_2.sWarning();
			this.EmergencyReactor2 = new SE.Nereda.Symbols.EmergencyReactor_2.sDefault();
			this.EmergencyManagement = new SE.Nereda.Symbols.EmergencyManagement.sDataR2();
			this.EmergencyManagement_1 = new SE.Nereda.Symbols.EmergencyManagement.sDataR1();
			this.Reactor2 = new SE.Nereda.Symbols.NeredaReactor.sPhase2();
			this.Reactor1 = new SE.Nereda.Symbols.NeredaReactor.sPhase2();
			this.EmergencySB = new SE.Nereda.Symbols.EmergencySludgeBuffer.Symbol1();
			this.SludgeBuffer = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sPhases();
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
			// EmergencyManagement_4
			// 
			this.EmergencyManagement_4.BeginInit();
			this.EmergencyManagement_4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1152D, 8D);
			this.EmergencyManagement_4.Name = "EmergencyManagement_4";
			this.EmergencyManagement_4.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement_4.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement_4.EndInit();
			// 
			// EmergencyManagement_3
			// 
			this.EmergencyManagement_3.BeginInit();
			this.EmergencyManagement_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 960D, 8D);
			this.EmergencyManagement_3.Name = "EmergencyManagement_3";
			this.EmergencyManagement_3.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement_3.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement_3.EndInit();
			// 
			// EmergencyReactor1
			// 
			this.EmergencyReactor1.BeginInit();
			this.EmergencyReactor1._iReactorName = "Reactor Name";
			this.EmergencyReactor1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 72D);
			this.EmergencyReactor1.Name = "EmergencyReactor1";
			this.EmergencyReactor1.SecurityToken = ((uint)(4294967295u));
			this.EmergencyReactor1.TagName = "A5740D5EBB5FFB16";
			this.EmergencyReactor1.EndInit();
			// 
			// WarningR1
			// 
			this.WarningR1.BeginInit();
			this.WarningR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7931034482758621D, 0D, 0D, 0.7931034482758621D, 448D, 80D);
			this.WarningR1.Name = "WarningR1";
			this.WarningR1.SecurityToken = ((uint)(4294967295u));
			this.WarningR1.TagName = "A5740D5EBB5FFB16";
			this.WarningR1.EndInit();
			// 
			// WarningR2
			// 
			this.WarningR2.BeginInit();
			this.WarningR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7931034482758621D, 0D, 0D, 0.7931034482758621D, 720D, 80D);
			this.WarningR2.Name = "WarningR2";
			this.WarningR2.SecurityToken = ((uint)(4294967295u));
			this.WarningR2.TagName = "94EBD1CCA84A7246";
			this.WarningR2.EndInit();
			// 
			// EmergencyReactor2
			// 
			this.EmergencyReactor2.BeginInit();
			this.EmergencyReactor2._iReactorName = "Reactor Name";
			this.EmergencyReactor2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1120D, 72D);
			this.EmergencyReactor2.Name = "EmergencyReactor2";
			this.EmergencyReactor2.SecurityToken = ((uint)(4294967295u));
			this.EmergencyReactor2.TagName = "94EBD1CCA84A7246";
			this.EmergencyReactor2.EndInit();
			// 
			// EmergencyManagement
			// 
			this.EmergencyManagement.BeginInit();
			this.EmergencyManagement.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7931034482758621D, 0D, 0D, 0.7931034482758621D, 912D, 80D);
			this.EmergencyManagement.Name = "EmergencyManagement";
			this.EmergencyManagement.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement.EndInit();
			// 
			// EmergencyManagement_1
			// 
			this.EmergencyManagement_1.BeginInit();
			this.EmergencyManagement_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7931034482758621D, 0D, 0D, 0.7931034482758621D, 256D, 80D);
			this.EmergencyManagement_1.Name = "EmergencyManagement_1";
			this.EmergencyManagement_1.SecurityToken = ((uint)(4294967295u));
			this.EmergencyManagement_1.TagName = "A990A73C5D482C0A";
			this.EmergencyManagement_1.EndInit();
			// 
			// Reactor2
			// 
			this.Reactor2.BeginInit();
			this.Reactor2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74137931034482762D, 0D, 0D, 0.6206896551724137D, 760D, 520D);
			this.Reactor2.Name = "Reactor2";
			this.Reactor2.SecurityToken = ((uint)(4294967295u));
			this.Reactor2.TagName = "1D81A826384C2197";
			this.Reactor2.EndInit();
			// 
			// Reactor1
			// 
			this.Reactor1.BeginInit();
			this.Reactor1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74137931034482762D, 0D, 0D, 0.62068965517241381D, 264D, 520D);
			this.Reactor1.Name = "Reactor1";
			this.Reactor1.SecurityToken = ((uint)(4294967295u));
			this.Reactor1.TagName = "D41247DF3E1D30DC";
			this.Reactor1.EndInit();
			// 
			// EmergencySB
			// 
			this.EmergencySB.BeginInit();
			this.EmergencySB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 600D, 40D);
			this.EmergencySB.Name = "EmergencySB";
			this.EmergencySB.SecurityToken = ((uint)(4294967295u));
			this.EmergencySB.TagName = "9C8DCCD6030E46A0";
			this.EmergencySB.EndInit();
			// 
			// SludgeBuffer
			// 
			this.SludgeBuffer.BeginInit();
			this.SludgeBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.84482758620689646D, 0D, 0D, 0.77586206896551724D, 488D, 368D);
			this.SludgeBuffer.Name = "SludgeBuffer";
			this.SludgeBuffer.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer.TagName = "9AA3696311BF0C3E";
			this.SludgeBuffer.EndInit();
			// 
			// EMERGENCY_RECIPE
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.OpenWebPage,
			this.EmergencyManagement_4,
			this.EmergencyManagement_3,
			this.btnAckNereda,
			this.EmergencyReactor1,
			this.WarningR1,
			this.WarningR2,
			this.EmergencyReactor2,
			this.EmergencyManagement,
			this.EmergencyManagement_1,
			this.Reactor2,
			this.Reactor1,
			this.EmergencySB,
			this.SludgeBuffer});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR2 EmergencyManagement;
		private SE.Nereda.Symbols.EmergencyManagement.sDataR1 EmergencyManagement_1;
		private SE.Nereda.Symbols.EmergencyManagement.sSettingsBtn EmergencyManagement_3;
		private SE.Nereda.Symbols.EmergencyManagement.sReactorAvExist EmergencyManagement_4;
		private SE.Nereda.Symbols.EmergencyReactor_2.sDefault EmergencyReactor1;
		private SE.Nereda.Symbols.EmergencyReactor_2.sWarning WarningR1;
		private SE.Nereda.Symbols.EmergencyReactor_2.sWarning WarningR2;
		private SE.Nereda.Symbols.EmergencyReactor_2.sDefault EmergencyReactor2;
		private NxtControl.GuiFramework.DrawnButton btnAckNereda;
		private SE.Nereda.Symbols.NeredaReactor.sPhase2 Reactor2;
		private SE.Nereda.Symbols.NeredaReactor.sPhase2 Reactor1;
		private SE.Nereda.Symbols.EmergencySludgeBuffer.Symbol1 EmergencySB;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sPhases SludgeBuffer;
		#endregion
	}
}
