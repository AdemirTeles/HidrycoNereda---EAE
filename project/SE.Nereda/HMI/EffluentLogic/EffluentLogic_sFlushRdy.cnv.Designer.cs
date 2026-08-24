/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/25/2026
 * Time: 3:22 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EffluentLogic
{
	/// <summary>
	/// Summary description for sFlushRdy.
	/// </summary>
	partial class sFlushRdy
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDefault1 = new SE.Nereda.Symbols.FlushSelector.sDefault();
			this.drawnButton4 = new NxtControl.GuiFramework.DrawnButton();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 56D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "FlushingManager.FlushControlSelector";
			this.sDefault1.EndInit();
			// 
			// drawnButton4
			// 
			this.drawnButton4.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(32D)), ((float)(248D)), ((float)(25D)));
			this.drawnButton4.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton4.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton4.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.drawnButton4.Name = "drawnButton4";
			this.drawnButton4.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpFlushCdts", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton4.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton4.Radius = 4D;
			this.drawnButton4.Text = "Force Flush Conditions";
			this.drawnButton4.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton4.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton4.Use3DEffect = false;
			// 
			// sFlushRdy
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.drawnButton4,
			this.sDefault1});
			this.SymbolSize = new System.Drawing.Size(384, 232);

		}
		private SE.Nereda.Symbols.FlushSelector.sDefault sDefault1;
		private NxtControl.GuiFramework.DrawnButton drawnButton4;
		#endregion
	}
}
