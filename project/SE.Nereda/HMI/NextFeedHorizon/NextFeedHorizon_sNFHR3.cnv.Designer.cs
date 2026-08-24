/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/16/2026
 * Time: 5:11 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizon
{
	/// <summary>
	/// Summary description for sNFHR3.
	/// </summary>
	partial class sNFHR3
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NextReactor = new NxtControl.GuiFramework.FreeText();
			this.NextFeedHorizonR3 = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// NextReactor
			// 
			this.NextReactor.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.NextReactor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NextReactor.Location = new NxtControl.Drawing.PointF(16D, 38D);
			this.NextReactor.Name = "NextReactor";
			this.NextReactor.Text = "Next Feed Horizon Reactor 3 :";
			// 
			// NextFeedHorizonR3
			// 
			this.NextFeedHorizonR3.BeginInit();
			this.NextFeedHorizonR3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NextFeedHorizonR3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7466666666666667D, 0D, 0D, 1D, 224D, 36D);
			this.NextFeedHorizonR3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NextFeedHorizonR3.FontScale = false;
			this.NextFeedHorizonR3.IsOnlyInput = true;
			this.NextFeedHorizonR3.Name = "NextFeedHorizonR3";
			this.NextFeedHorizonR3.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.NextFeedHorizonR3.TagName = "NextFeedHorizonR3";
			this.NextFeedHorizonR3.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.NextFeedHorizonR3.EndInit();
			// 
			// sNFHR3
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.NextReactor,
			this.NextFeedHorizonR3});
			this.SymbolSize = new System.Drawing.Size(488, 200);

		}
		private NxtControl.GuiFramework.FreeText NextReactor;
		private System.HMI.Symbols.Base.TimeLabel NextFeedHorizonR3;
		#endregion
	}
}
