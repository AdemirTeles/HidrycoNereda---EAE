/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 11:00 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Calamity
{
	/// <summary>
	/// Summary description for sHiHiLevelCalamity.
	/// </summary>
	partial class sHiHiLevelCalamity
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CalamityLevelStatus = new NxtControl.GuiFramework.RoundedRectangle();
			this.OpenActions = new NxtControl.GuiFramework.Rectangle();
			// 
			// CalamityLevelStatus
			// 
			this.CalamityLevelStatus.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(192D)), ((float)(40D)));
			this.CalamityLevelStatus.Brush = new NxtControl.Drawing.Brush(true);
			this.CalamityLevelStatus.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CalamityLevelStatus.Name = "CalamityLevelStatus";
			this.CalamityLevelStatus.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpHiHiActions", NxtControl.GuiFramework.MouseButtonType.Click));
			this.CalamityLevelStatus.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.CalamityLevelStatus.Text = "Calamity Pit : Level Too High";
			this.CalamityLevelStatus.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.CalamityLevelStatus.TextColor = new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114)));
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
			// sHiHiLevelCalamity
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.CalamityLevelStatus,
			this.OpenActions});
			this.SymbolSize = new System.Drawing.Size(248, 200);

		}
		private NxtControl.GuiFramework.RoundedRectangle CalamityLevelStatus;
		private NxtControl.GuiFramework.Rectangle OpenActions;
		#endregion
	}
}
