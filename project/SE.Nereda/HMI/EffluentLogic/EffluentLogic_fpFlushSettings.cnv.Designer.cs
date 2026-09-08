/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 1:05 AM
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
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpFlushSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FlushGritScreenInstallation = new SE.Nereda.Symbols.FlushGritScreenInstallation.sSettings();
			this.FlushGritScreens = new SE.Nereda.Symbols.FlushGritScreens.sSettings();
			this.FlushSludgeBuffer = new SE.Nereda.Symbols.FlushSludgeBuffer.sSettings();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			// 
			// FlushGritScreenInstallation
			// 
			this.FlushGritScreenInstallation.BeginInit();
			this.FlushGritScreenInstallation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.FlushGritScreenInstallation.Name = "FlushGritScreenInstallation";
			this.FlushGritScreenInstallation.SecurityToken = ((uint)(4294967295u));
			this.FlushGritScreenInstallation.TagName = "FlushGritScreenInstallation";
			this.FlushGritScreenInstallation.EndInit();
			// 
			// FlushGritScreens
			// 
			this.FlushGritScreens.BeginInit();
			this.FlushGritScreens.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 168D);
			this.FlushGritScreens.Name = "FlushGritScreens";
			this.FlushGritScreens.SecurityToken = ((uint)(4294967295u));
			this.FlushGritScreens.TagName = "FlushGritScreens";
			this.FlushGritScreens.EndInit();
			// 
			// FlushSludgeBuffer
			// 
			this.FlushSludgeBuffer.BeginInit();
			this.FlushSludgeBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 304D);
			this.FlushSludgeBuffer.Name = "FlushSludgeBuffer";
			this.FlushSludgeBuffer.SecurityToken = ((uint)(4294967295u));
			this.FlushSludgeBuffer.TagName = "FlushSludgeBuffer";
			this.FlushSludgeBuffer.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(296D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Priority 1";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(296D, 168D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Priority 2";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(296D, 304D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Priority 3";
			// 
			// fpFlushSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(464D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.FlushGritScreenInstallation,
			this.FlushGritScreens,
			this.FlushSludgeBuffer,
			this.freeText1,
			this.freeText2,
			this.freeText3});
			this.Size = new System.Drawing.Size(376, 464);
			this.Title = "Flushing Settings";

		}
		private SE.Nereda.Symbols.FlushGritScreenInstallation.sSettings FlushGritScreenInstallation;
		private SE.Nereda.Symbols.FlushGritScreens.sSettings FlushGritScreens;
		private SE.Nereda.Symbols.FlushSludgeBuffer.sSettings FlushSludgeBuffer;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		#endregion
	}
}
