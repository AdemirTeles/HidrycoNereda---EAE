/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/24/2026
 * Time: 10:37 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Summary description for Sobretorque.
	/// </summary>
	partial class Sobretorque
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(23D)), ((float)(23D)), ((float)(23D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			this.ellipse1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(39D)), ((float)(3D)), ((float)(3D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			this.ellipse3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(26D)), ((float)(3D)), ((float)(11D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Sobretorque
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse1,
			this.ellipse3,
			this.roundedRectangle1});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		#endregion
	}
}
