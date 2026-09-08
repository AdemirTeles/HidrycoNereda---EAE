/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/26/2026
 * Time: 5:29 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sCalamity.
	/// </summary>
	partial class sCalamity
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new SE.Nereda.Symbols.Calamity.sDefault();
			this.sPvBarVer1 = new SE.Nereda.Symbols.AnalogInput.sPvBarVer();
			this.sDIn11 = new SE.Nereda.Symbols.DigitalInput.sDIn1();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iCV001 = "46 2 AP lzp 95 008";
			this.sDefault1._iCV002 = "46 2 AP lzp 95 009";
			this.sDefault1._iCV003 = "46 2 AP lzp 95 010";
			this.sDefault1._iXV001 = "46 2 AP a-- 95 004";
			this.sDefault1._iXV002 = "46 2 AP a-- 95 005";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 80D, 64D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "EffluentLogic.Calamity";
			this.sDefault1.EndInit();
			// 
			// sPvBarVer1
			// 
			this.sPvBarVer1.BeginInit();
			this.sPvBarVer1._iSensorName = "46 2 AP LT 95 001";
			this.sPvBarVer1._iUnit = "m";
			this.sPvBarVer1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.125D, 0D, 0D, 1.125D, 472D, 300D);
			this.sPvBarVer1.Name = "sPvBarVer1";
			this.sPvBarVer1.SecurityToken = ((uint)(4294967295u));
			this.sPvBarVer1.TagName = "Sensors.NVPP_46_2_AP_LT_95_001";
			this.sPvBarVer1.EndInit();
			// 
			// sDIn11
			// 
			this.sDIn11.BeginInit();
			this.sDIn11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5652173913043479D, 0D, 0D, 1.5652173913043479D, 248D, 248D);
			this.sDIn11.Name = "sDIn11";
			this.sDIn11.SecurityToken = ((uint)(4294967295u));
			this.sDIn11.TagName = "Sensors.HiLevelSwitch_Calamity";
			this.sDIn11.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDefault1,
			this.sPvBarVer1,
			this.sDIn11});
			this.group1.EndInit();
			// 
			// sCalamity
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(824, 536);

		}
		private SE.Nereda.Symbols.Calamity.sDefault sDefault1;
		private SE.Nereda.Symbols.AnalogInput.sPvBarVer sPvBarVer1;
		private SE.Nereda.Symbols.DigitalInput.sDIn1 sDIn11;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
