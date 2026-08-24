/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/16/2026
 * Time: 5:15 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizon
{
	/// <summary>
	/// Summary description for sNFHR31.
	/// </summary>
	partial class sNFHR31
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NextReactor = new NxtControl.GuiFramework.FreeText();
			this.NextFeedHorizonR1_1 = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// NextReactor
			// 
			this.NextReactor.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.NextReactor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NextReactor.Location = new NxtControl.Drawing.PointF(48D, 40D);
			this.NextReactor.Name = "NextReactor";
			this.NextReactor.Text = "Next Feed Horizon Reactor 3 :";
			// 
			// NextFeedHorizonR1_1
			// 
			this.NextFeedHorizonR1_1.BeginInit();
			this.NextFeedHorizonR1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.NextFeedHorizonR1_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7466666666666667D, 0D, 0D, 1D, 48D, 64D);
			this.NextFeedHorizonR1_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NextFeedHorizonR1_1.FontScale = false;
			this.NextFeedHorizonR1_1.IsOnlyInput = true;
			this.NextFeedHorizonR1_1.Name = "NextFeedHorizonR1_1";
			this.NextFeedHorizonR1_1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.NextFeedHorizonR1_1.TagName = "NextFeedHorizonR3";
			this.NextFeedHorizonR1_1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.NextFeedHorizonR1_1.EndInit();
			// 
			// sNFHR31
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.NextReactor,
			this.NextFeedHorizonR1_1});
			this.SymbolSize = new System.Drawing.Size(360, 200);

		}
		private NxtControl.GuiFramework.FreeText NextReactor;
		private System.HMI.Symbols.Base.TimeLabel NextFeedHorizonR1_1;
		#endregion
	}
}
