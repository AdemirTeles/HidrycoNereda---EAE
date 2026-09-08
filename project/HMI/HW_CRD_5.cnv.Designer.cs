/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/12/2026
 * Time: 10:29 AM
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
	/// Summary description for HW_CRD_5.
	/// </summary>
	partial class HW_CRD_5
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
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
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
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(352D, 248D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "CRD REACTOR 3";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1});
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.group2.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(72D, 64D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "REACTOR3 CRD";
			// 
			// HW_CRD_5
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.group2,
			this.freeText2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.FreeText freeText2;
		#endregion
	}
}
