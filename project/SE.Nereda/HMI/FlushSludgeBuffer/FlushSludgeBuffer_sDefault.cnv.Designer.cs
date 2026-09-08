/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 3:20 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushSludgeBuffer
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.Ctrl = new NxtControl.GuiFramework.Rectangle();
			this.FlushConditions = new SE.Nereda.Symbols.FlushCdt.sDefault();
			// 
			// Ctrl
			// 
			this.Ctrl.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(48D)), ((float)(32D)), ((float)(32D)));
			this.Ctrl.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.Ctrl.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Ctrl.ImageBytes = resources.GetString("Ctrl.ImageBytes");
			this.Ctrl.Name = "Ctrl";
			this.Ctrl.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpCtrl", NxtControl.GuiFramework.MouseButtonType.Click));
			this.Ctrl.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// FlushConditions
			// 
			this.FlushConditions.BeginInit();
			this.FlushConditions.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 16D);
			this.FlushConditions.Name = "FlushConditions";
			this.FlushConditions.SecurityToken = ((uint)(4294967295u));
			this.FlushConditions.TagName = "FlushConditions";
			this.FlushConditions.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Ctrl,
			this.FlushConditions});
			this.SymbolSize = new System.Drawing.Size(120, 136);

		}
		private NxtControl.GuiFramework.Rectangle Ctrl;
		private SE.Nereda.Symbols.FlushCdt.sDefault FlushConditions;
		#endregion
	}
}
