/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 5:19 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
{
	/// <summary>
	/// Summary description for sResetSafetyStopNotif.
	/// </summary>
	partial class sResetSafetyStopNotif
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NeedReset = new NxtControl.GuiFramework.FreeText();
			// 
			// NeedReset
			// 
			this.NeedReset.Color = new NxtControl.Drawing.BlinkColor("SE.HwCommon.DevLEDOrangeRedFlash");
			this.NeedReset.Font = new NxtControl.Drawing.Font("LabelFont");
			this.NeedReset.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.NeedReset.Name = "NeedReset";
			this.NeedReset.Text = "Need Reset\r\nSafety Stop";
			// 
			// sResetSafetyStopNotif
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.NeedReset});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.FreeText NeedReset;
		#endregion
	}
}
