/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 15:58
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.BloqueioAtivaDesativa
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
			this.aliasDisplayLabel1 = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(84D)), ((float)(46D)), ((float)(120D)), ((float)(36D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.drawnButton1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("Faceplate1", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// aliasDisplayLabel1
			// 
			this.aliasDisplayLabel1.AngleIgnore = true;
			this.aliasDisplayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aliasDisplayLabel1.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(56D)), ((float)(96D)), ((float)(16D)));
			this.aliasDisplayLabel1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.aliasDisplayLabel1.CustomInstanceName = null;
			this.aliasDisplayLabel1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.aliasDisplayLabel1.FontScale = true;
			this.aliasDisplayLabel1.Name = "aliasDisplayLabel1";
			this.aliasDisplayLabel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.aliasDisplayLabel1.Text = "Label";
			this.aliasDisplayLabel1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.aliasDisplayLabel1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(85D)), ((float)(47D)), ((float)(118D)), ((float)(34D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonInnerBorderColor"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.rectangle1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonInnerBorderColor");
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.aliasDisplayLabel1,
			this.drawnButton1});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.AliasDisplayLabel aliasDisplayLabel1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
