/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/16/2026
 * Time: 5:12 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizon
{
	/// <summary>
	/// Summary description for sNFHR2.
	/// </summary>
	partial class sNFHR2
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NextReactor = new NxtControl.GuiFramework.FreeText();
			this.NextFeedHorizonR2 = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// NextReactor
			// 
			this.NextReactor.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.NextReactor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NextReactor.Location = new NxtControl.Drawing.PointF(16D, 38D);
			this.NextReactor.Name = "NextReactor";
			this.NextReactor.Text = "Next Feed Horizon Reactor 2 :";
			// 
			// NextFeedHorizonR2
			// 
			this.NextFeedHorizonR2.BeginInit();
			this.NextFeedHorizonR2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NextFeedHorizonR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7466666666666667D, 0D, 0D, 1D, 224D, 36D);
			this.NextFeedHorizonR2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NextFeedHorizonR2.FontScale = false;
			this.NextFeedHorizonR2.IsOnlyInput = true;
			this.NextFeedHorizonR2.Name = "NextFeedHorizonR2";
			this.NextFeedHorizonR2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.NextFeedHorizonR2.TagName = "NextFeedHorizonR2";
			this.NextFeedHorizonR2.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.NextFeedHorizonR2.EndInit();
			// 
			// sNFHR2
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.NextReactor,
			this.NextFeedHorizonR2});
			this.SymbolSize = new System.Drawing.Size(456, 200);

		}
		private NxtControl.GuiFramework.FreeText NextReactor;
		private System.HMI.Symbols.Base.TimeLabel NextFeedHorizonR2;
		#endregion
	}
}
