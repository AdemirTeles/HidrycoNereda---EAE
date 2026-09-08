/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 8/31/2022
 * Time: 11:36 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput_Status
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sStatus
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.StatusRec = new NxtControl.GuiFramework.RoundedRectangle();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(9D)), ((float)(10D)), ((float)(48D)), ((float)(15D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpStatus", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "STATUS";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("SE.Nereda.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("SE.Nereda.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// StatusRec
			// 
			this.StatusRec.Bounds = new NxtControl.Drawing.RectF(((float)(9D)), ((float)(8D)), ((float)(48D)), ((float)(18D)));
			this.StatusRec.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.StatusRec.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.StatusRec.Name = "StatusRec";
			this.StatusRec.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpStatus", NxtControl.GuiFramework.MouseButtonType.Click));
			// 
			// sStatus
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.StatusRec,
			this.drawnButton1});
			this.SymbolSize = new System.Drawing.Size(256, 193);

		}
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.RoundedRectangle StatusRec;
		#endregion
	}
}
