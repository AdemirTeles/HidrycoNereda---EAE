/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 5:25 PM
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
	/// Summary description for fpFlushSettings.
	/// </summary>
	partial class fpSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ToFinalTreatment = new SE.Nereda.Symbols.ToFinalTreatment.sDefault();
			this.FlushingManager = new SE.Nereda.Symbols.FlushingManager.sDefault();
			// 
			// ToFinalTreatment
			// 
			this.ToFinalTreatment.BeginInit();
			this.ToFinalTreatment.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 200D);
			this.ToFinalTreatment.Name = "ToFinalTreatment";
			this.ToFinalTreatment.SecurityToken = ((uint)(4294967295u));
			this.ToFinalTreatment.TagName = "ToFinalTreatment";
			this.ToFinalTreatment.EndInit();
			// 
			// FlushingManager
			// 
			this.FlushingManager.BeginInit();
			this.FlushingManager.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.FlushingManager.Name = "FlushingManager";
			this.FlushingManager.SecurityToken = ((uint)(4294967295u));
			this.FlushingManager.TagName = "FlushingManager";
			this.FlushingManager.EndInit();
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(392D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ToFinalTreatment,
			this.FlushingManager});
			this.Size = new System.Drawing.Size(376, 392);
			this.Title = "Effluent Settings (ctp 002 - ctp 003)";

		}
		private SE.Nereda.Symbols.ToFinalTreatment.sDefault ToFinalTreatment;
		private SE.Nereda.Symbols.FlushingManager.sDefault FlushingManager;
		#endregion
	}
}
