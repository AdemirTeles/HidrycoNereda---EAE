/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 2:53 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.OpeningValveDurLogic
{
	/// <summary>
	/// Summary description for sForceClose.
	/// </summary>
	partial class sForceClose
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ForceClose = new NxtControl.GuiFramework.DrawnButton();
			this.ValveName = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// ForceClose
			// 
			this.ForceClose.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(8D)), ((float)(104D)), ((float)(24D)));
			this.ForceClose.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ForceClose.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ForceClose.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.ForceClose.Name = "ForceClose";
			this.ForceClose.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.ForceClose.Radius = 4D;
			this.ForceClose.Text = "FORCE CLOSE";
			this.ForceClose.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.ForceClose.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.ForceClose.Use3DEffect = false;
			this.ForceClose.Click += new System.EventHandler(this.ForceCloseClick);
			// 
			// ValveName
			// 
			this.ValveName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ValveName.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.ValveName.Location = new NxtControl.Drawing.PointF(120D, 13D);
			this.ValveName.Name = "ValveName";
			this.ValveName.Text = "46 2 AP izp 95 0xx";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 13D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Force Close Valve :";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(320D)), ((float)(24D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// sForceClose
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.ForceClose,
			this.ValveName,
			this.freeText1});
			this.SymbolSize = new System.Drawing.Size(416, 200);

		}
		private NxtControl.GuiFramework.DrawnButton ForceClose;
		private NxtControl.GuiFramework.FreeText ValveName;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
