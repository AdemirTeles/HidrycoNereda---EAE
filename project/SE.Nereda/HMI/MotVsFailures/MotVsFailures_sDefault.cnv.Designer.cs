/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/5/2026
 * Time: 9:56 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MotVsFailures
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(24D)), ((float)(40D)), ((float)(40D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular);
			this.rectangle1.ImageBytes = resources.GetString("rectangle1.ImageBytes");
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpData", NxtControl.GuiFramework.MouseButtonType.Click));
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.rectangle1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.rectangle1.TextColor = new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78)));
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
