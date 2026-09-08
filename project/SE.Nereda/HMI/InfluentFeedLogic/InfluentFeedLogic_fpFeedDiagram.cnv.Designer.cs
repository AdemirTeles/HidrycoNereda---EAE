/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/18/2026
 * Time: 12:04 PM
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
	/// Summary description for fpFeedDiagram.
	/// </summary>
	partial class fpFeedDiagram
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Feed_InfluentFeed = new SE.Nereda.Symbols.FeedInfluentLogic.sGrafcet();
			// 
			// Feed_InfluentFeed
			// 
			this.Feed_InfluentFeed.BeginInit();
			this.Feed_InfluentFeed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.Feed_InfluentFeed.Name = "Feed_InfluentFeed";
			this.Feed_InfluentFeed.SecurityToken = ((uint)(4294967295u));
			this.Feed_InfluentFeed.TagName = "Feed_InfluentFeed";
			this.Feed_InfluentFeed.EndInit();
			// 
			// fpFeedDiagram
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(416D)), ((float)(392D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Feed_InfluentFeed});
			this.Size = new System.Drawing.Size(416, 392);
			this.Title = "Feed Influent Diagram";

		}
		private SE.Nereda.Symbols.FeedInfluentLogic.sGrafcet Feed_InfluentFeed;
		#endregion
	}
}
