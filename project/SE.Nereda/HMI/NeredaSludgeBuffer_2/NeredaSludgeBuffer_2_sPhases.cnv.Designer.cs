/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 5:17 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer_2
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sPhases
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DisplayStatus = new NxtControl.GuiFramework.Rectangle();
			this.Logic = new SE.Nereda.Symbols.SludgeBufferLogic_2.sDefault();
			// 
			// DisplayStatus
			// 
			this.DisplayStatus.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(464D)), ((float)(32D)));
			this.DisplayStatus.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.DisplayStatus.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.DisplayStatus.Name = "DisplayStatus";
			this.DisplayStatus.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.DisplayStatus.Text = "REACTOR STATUS";
			this.DisplayStatus.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.DisplayStatus.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// Logic
			// 
			this.Logic.BeginInit();
			this.Logic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 48D);
			this.Logic.Name = "Logic";
			this.Logic.SecurityToken = ((uint)(4294967295u));
			this.Logic.TagName = "Logic";
			this.Logic.EndInit();
			// 
			// sPhases
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DisplayStatus,
			this.Logic});
			this.SymbolSize = new System.Drawing.Size(848, 352);

		}
		private NxtControl.GuiFramework.Rectangle DisplayStatus;
		private SE.Nereda.Symbols.SludgeBufferLogic_2.sDefault Logic;
		#endregion
	}
}
