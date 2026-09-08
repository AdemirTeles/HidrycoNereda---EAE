/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/9/2026
 * Time: 5:21 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EffluentLogic
{
	/// <summary>
	/// Summary description for sFlushingSettings.
	/// </summary>
	partial class sFlushingSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.drawnButton2 = new NxtControl.GuiFramework.DrawnButton();
			// 
			// drawnButton2
			// 
			this.drawnButton2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(120D)), ((float)(40D)));
			this.drawnButton2.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton2.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton2.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			this.drawnButton2.Name = "drawnButton2";
			this.drawnButton2.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpFlushSettings", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton2.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton2.Radius = 4D;
			this.drawnButton2.Text = "Flushing Settings";
			this.drawnButton2.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton2.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton2.Use3DEffect = false;
			// 
			// sFlushingSettings
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.drawnButton2});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.DrawnButton drawnButton2;
		#endregion
	}
}
