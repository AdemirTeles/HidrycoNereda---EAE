/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/24/2026
 * Time: 10:03 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushCdt
{
	/// <summary>
	/// Summary description for sForce.
	/// </summary>
	partial class sForce
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ActiveCdts = new System.HMI.Symbols.Base.SwitchButton();
			this.FlushCdtName = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			// 
			// ActiveCdts
			// 
			this.ActiveCdts.BeginInit();
			this.ActiveCdts.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.1750000000000003D, 0D, 0D, 0.93333333333333335D, 9D, 34D);
			this.ActiveCdts.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveCdts.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveCdts.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ActiveCdts.Name = "ActiveCdts";
			this.ActiveCdts.TagName = "ActiveCdts";
			this.ActiveCdts.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveCdts.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveCdts.Value = false;
			this.ActiveCdts.EndInit();
			// 
			// FlushCdtName
			// 
			this.FlushCdtName.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(176D)), ((float)(24D)));
			this.FlushCdtName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.FlushCdtName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.FlushCdtName.Name = "FlushCdtName";
			this.FlushCdtName.Text = "Flushing Conditions";
			this.FlushCdtName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(176D)), ((float)(56D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 10D;
			// 
			// sForce
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.ActiveCdts,
			this.FlushCdtName});
			this.SymbolSize = new System.Drawing.Size(304, 200);

		}
		private System.HMI.Symbols.Base.SwitchButton ActiveCdts;
		private NxtControl.GuiFramework.RoundedRectangle FlushCdtName;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		#endregion
	}
}
