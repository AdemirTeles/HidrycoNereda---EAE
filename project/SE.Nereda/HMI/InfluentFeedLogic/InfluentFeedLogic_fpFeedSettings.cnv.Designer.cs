/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/16/2026
 * Time: 11:22 AM
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
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpFeedSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Feed_InfluentFeed_1 = new SE.Nereda.Symbols.FeedInfluentLogic.sGraph();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.Feed_InfluentFeed = new SE.Nereda.Symbols.FeedInfluentLogic.sDefault();
			// 
			// Feed_InfluentFeed_1
			// 
			this.Feed_InfluentFeed_1.BeginInit();
			this.Feed_InfluentFeed_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 496D);
			this.Feed_InfluentFeed_1.Name = "Feed_InfluentFeed_1";
			this.Feed_InfluentFeed_1.SecurityToken = ((uint)(4294967295u));
			this.Feed_InfluentFeed_1.TagName = "Feed_InfluentFeed";
			this.Feed_InfluentFeed_1.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(416D)), ((float)(96D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpFeedDiagram", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Diagram";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
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
			// fpFeedSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(672D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Feed_InfluentFeed,
			this.Feed_InfluentFeed_1,
			this.drawnButton1});
			this.Size = new System.Drawing.Size(376, 672);
			this.Title = "FEED INFLUNET Settings";

		}
		private SE.Nereda.Symbols.FeedInfluentLogic.sDefault Feed_InfluentFeed;
		private SE.Nereda.Symbols.FeedInfluentLogic.sGraph Feed_InfluentFeed_1;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		#endregion
	}
}
