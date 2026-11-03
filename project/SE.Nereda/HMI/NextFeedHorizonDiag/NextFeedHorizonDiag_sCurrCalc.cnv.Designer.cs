/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/19/2026
 * Time: 12:57 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizonDiag
{
	/// <summary>
	/// Summary description for sCurrCalc.
	/// </summary>
	partial class sCurrCalc
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.CalcResult = new NxtControl.GuiFramework.FreeText();
			// 
			// CalcResult
			// 
			this.CalcResult.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CalcResult.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.CalcResult.Location = new NxtControl.Drawing.PointF(16D, 16D);
			this.CalcResult.Name = "CalcResult";
			this.CalcResult.Text = "Text";
			// 
			// sCurrCalc
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.CalcResult});
			this.SymbolSize = new System.Drawing.Size(744, 200);

		}
		private NxtControl.GuiFramework.FreeText CalcResult;
		#endregion
	}
}
