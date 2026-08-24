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
	partial class fpDrainSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Drain_InfluentFeed = new SE.Nereda.Symbols.FeedReactorLogic.sDefault();
			this.GritScreenLogic = new SE.Nereda.Symbols.GritScreenLogic.sDefault();
			this.MixerLogic = new SE.Nereda.Symbols.MixerLogic.sDefault();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
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
			// GritScreenLogic
			// 
			this.GritScreenLogic.BeginInit();
			this.GritScreenLogic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 72D);
			this.GritScreenLogic.Name = "GritScreenLogic";
			this.GritScreenLogic.SecurityToken = ((uint)(4294967295u));
			this.GritScreenLogic.TagName = "GritScreenLogic";
			this.GritScreenLogic.EndInit();
			// 
			// MixerLogic
			// 
			this.MixerLogic.BeginInit();
			this.MixerLogic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 208D);
			this.MixerLogic.Name = "MixerLogic";
			this.MixerLogic.SecurityToken = ((uint)(4294967295u));
			this.MixerLogic.TagName = "Mixer01Logic";
			this.MixerLogic.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(32D)), ((float)(96D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDrainDiagram", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Diagram";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// fpDrainSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(272D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Drain_InfluentFeed,
			this.GritScreenLogic,
			this.MixerLogic,
			this.drawnButton1});
			this.Size = new System.Drawing.Size(376, 272);
			this.Title = "INFLUNET Settings";

		}
		private SE.Nereda.Symbols.FeedReactorLogic.sDefault Drain_InfluentFeed;
		private SE.Nereda.Symbols.GritScreenLogic.sDefault GritScreenLogic;
		private SE.Nereda.Symbols.MixerLogic.sDefault MixerLogic;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		#endregion
	}
}
