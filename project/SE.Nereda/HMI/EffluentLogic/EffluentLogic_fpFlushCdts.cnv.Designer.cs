/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/25/2026
 * Time: 3:23 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EffluentLogic
{
	/// <summary>
	/// Summary description for fpGSICdt.
	/// </summary>
	partial class fpFlushCdts
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sForce1 = new SE.Nereda.Symbols.EffluentCdt.sForce();
			this.sForce2 = new SE.Nereda.Symbols.FlushCdt.sForce();
			// 
			// sForce1
			// 
			this.sForce1.BeginInit();
			this.sForce1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.sForce1.Name = "sForce1";
			this.sForce1.SecurityToken = ((uint)(4294967295u));
			this.sForce1.TagName = "FlushingManager.EffluentPumpCdts";
			this.sForce1.EndInit();
			// 
			// sForce2
			// 
			this.sForce2.BeginInit();
			this.sForce2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 8D);
			this.sForce2.Name = "sForce2";
			this.sForce2.SecurityToken = ((uint)(4294967295u));
			this.sForce2.TagName = "FlushGritScreenInstallation.FlushConditions";
			this.sForce2.EndInit();
			// 
			// fpFlushCdts
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(200D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sForce1,
			this.sForce2});
			this.Size = new System.Drawing.Size(376, 200);
			this.Title = "Force Flush Conditions";

		}
		private SE.Nereda.Symbols.EffluentCdt.sForce sForce1;
		private SE.Nereda.Symbols.FlushCdt.sForce sForce2;
		#endregion
	}
}
