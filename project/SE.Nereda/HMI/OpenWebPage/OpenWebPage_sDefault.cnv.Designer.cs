/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA685388
 * Date: 6/26/2024
 * Time: 10:11 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.OpenWebPage
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
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.URL = new System.HMI.Symbols.Base.Execute<string>();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(40D)), ((float)(120D)), ((float)(40D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("SE.Nereda.ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Open WebPage";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("SE.Nereda.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("SE.Nereda.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			this.drawnButton1.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// URL
			// 
			this.URL.BeginInit();
			this.URL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.URL.IsOnlyInput = true;
			this.URL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.URL.Name = "URL";
			this.URL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.URL.TagName = "URL";
			this.URL.Value = null;
			this.URL.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.drawnButton1,
			this.URL});
			this.SymbolSize = new System.Drawing.Size(224, 120);

		}
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private System.HMI.Symbols.Base.Execute<string> URL;
		#endregion
	}
}
