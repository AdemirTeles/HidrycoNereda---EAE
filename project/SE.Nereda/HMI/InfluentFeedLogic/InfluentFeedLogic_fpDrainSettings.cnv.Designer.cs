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
			this.MixerLogic = new SE.Nereda.Symbols.MixerLogic.sDefault();
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
			// MixerLogic
			// 
			this.MixerLogic.BeginInit();
			this.MixerLogic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 224D);
			this.MixerLogic.Name = "MixerLogic";
			this.MixerLogic.SecurityToken = ((uint)(4294967295u));
			this.MixerLogic.TagName = "Mixer01Logic";
			this.MixerLogic.EndInit();
			// 
			// fpDrainSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(392D)), ((float)(288D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Drain_InfluentFeed,
			this.MixerLogic});
			this.Size = new System.Drawing.Size(392, 288);
			this.Title = "INFLUNET Settings";

		}
		private SE.Nereda.Symbols.FeedReactorLogic.sDefault Drain_InfluentFeed;
		private SE.Nereda.Symbols.MixerLogic.sDefault MixerLogic;
		#endregion
	}
}
