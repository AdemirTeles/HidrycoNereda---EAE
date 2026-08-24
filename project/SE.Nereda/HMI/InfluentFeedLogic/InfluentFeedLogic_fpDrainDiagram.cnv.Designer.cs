/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 4:09 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.InfluentFeedLogic
{
	/// <summary>
	/// Summary description for fpDrainDiagram.
	/// </summary>
	partial class fpDrainDiagram
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Drain_InfluentFeed = new SE.Nereda.Symbols.FeedReactorLogic.sGrafcet();
			// 
			// Drain_InfluentFeed
			// 
			this.Drain_InfluentFeed.BeginInit();
			this.Drain_InfluentFeed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.Drain_InfluentFeed.Name = "Drain_InfluentFeed";
			this.Drain_InfluentFeed.SecurityToken = ((uint)(4294967295u));
			this.Drain_InfluentFeed.TagName = "Drain_InfluentFeed";
			this.Drain_InfluentFeed.EndInit();
			// 
			// fpDrainDiagram
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(200D)), ((float)(400D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Drain_InfluentFeed});
			this.Size = new System.Drawing.Size(200, 400);

		}
		private SE.Nereda.Symbols.FeedReactorLogic.sGrafcet Drain_InfluentFeed;
		#endregion
	}
}
