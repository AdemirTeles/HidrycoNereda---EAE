/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/17/2026
 * Time: 4:42 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MemoOC_D
{
	/// <summary>
	/// Summary description for sMOCBtn.
	/// </summary>
	partial class sMOCBtn
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.MOCBtn = new NxtControl.GuiFramework.DrawnButton();
			// 
			// MOCBtn
			// 
			this.MOCBtn.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(64D)), ((float)(25D)));
			this.MOCBtn.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.MOCBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.MOCBtn.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.MOCBtn.Name = "MOCBtn";
			this.MOCBtn.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpMemoOC", NxtControl.GuiFramework.MouseButtonType.Click));
			this.MOCBtn.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.MOCBtn.Text = "Memo OC";
			this.MOCBtn.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.MOCBtn.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.MOCBtn.Use3DEffect = false;
			// 
			// sMOCBtn
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.MOCBtn});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.DrawnButton MOCBtn;
		#endregion
	}
}
