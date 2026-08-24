/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 3:19 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sEffValve011.
	/// </summary>
	partial class sFlushStatus016
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sStatus1 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.sInfos1 = new SE.Nereda.Symbols.FlushGritScreenInstallation.sInfos();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			// 
			// sStatus1
			// 
			this.sStatus1.BeginInit();
			this.sStatus1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 16D);
			this.sStatus1.Name = "sStatus1";
			this.sStatus1.SecurityToken = ((uint)(4294967295u));
			this.sStatus1.TagName = "Actuators.NVPP_001_a_016";
			this.sStatus1.EndInit();
			// 
			// sInfos1
			// 
			this.sInfos1.BeginInit();
			this.sInfos1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 16D);
			this.sInfos1.Name = "sInfos1";
			this.sInfos1.SecurityToken = ((uint)(4294967295u));
			this.sInfos1.TagName = "EffluentLogic.FlushGritScreenInstallation";
			this.sInfos1.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 32D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "NVPP 001 a-- 016";
			// 
			// sFlushStatus016
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sStatus1,
			this.sInfos1,
			this.freeText1});
			this.SymbolSize = new System.Drawing.Size(200, 72);

		}
		private SE.Nereda.Symbols.ValveS.sStatus sStatus1;
		private SE.Nereda.Symbols.FlushGritScreenInstallation.sInfos sInfos1;
		private NxtControl.GuiFramework.FreeText freeText1;
		#endregion
	}
}
