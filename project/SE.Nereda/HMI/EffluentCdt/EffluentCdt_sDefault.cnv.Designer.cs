/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 2:15 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EffluentCdt
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.Cdt = new NxtControl.GuiFramework.Rectangle();
			// 
			// Cdt
			// 
			this.Cdt.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(16D)), ((float)(32D)), ((float)(32D)));
			this.Cdt.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.Cdt.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Cdt.ImageBytes = resources.GetString("Cdt.ImageBytes");
			this.Cdt.Name = "Cdt";
			this.Cdt.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpStartCdts", NxtControl.GuiFramework.MouseButtonType.Click));
			this.Cdt.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Cdt});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Rectangle Cdt;
		#endregion
	}
}
