/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 4:04 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.SludgeBufferLogic
{
	/// <summary>
	/// Summary description for sHiHiLevelSLB.
	/// </summary>
	partial class sHiHiLevelSLB
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SLBLevelStatus = new NxtControl.GuiFramework.RoundedRectangle();
			this.OpenActions = new NxtControl.GuiFramework.Rectangle();
			// 
			// SLBLevelStatus
			// 
			this.SLBLevelStatus.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(192D)), ((float)(40D)));
			this.SLBLevelStatus.Brush = new NxtControl.Drawing.Brush(true);
			this.SLBLevelStatus.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.SLBLevelStatus.Name = "SLBLevelStatus";
			this.SLBLevelStatus.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpHiHiActions", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SLBLevelStatus.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.SLBLevelStatus.Text = "Sludge Buffer : Level Too High";
			this.SLBLevelStatus.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.SLBLevelStatus.TextColor = new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114)));
			// 
			// OpenActions
			// 
			this.OpenActions.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(192D)), ((float)(40D)));
			this.OpenActions.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenActions.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenActions.Name = "OpenActions";
			this.OpenActions.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpHiHiActions", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenActions.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sHiHiLevelSLB
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.SLBLevelStatus,
			this.OpenActions});
			this.SymbolSize = new System.Drawing.Size(272, 200);

		}
		private NxtControl.GuiFramework.RoundedRectangle SLBLevelStatus;
		private NxtControl.GuiFramework.Rectangle OpenActions;
		#endregion
	}
}
