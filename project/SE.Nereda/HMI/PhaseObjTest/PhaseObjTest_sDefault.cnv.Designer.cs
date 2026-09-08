/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 10:12 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.PhaseObjTest
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
			this.OpCdt = new System.HMI.Symbols.Base.SwitchButton();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Mode = new System.HMI.Symbols.Base.DropDown<short>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			// 
			// OpCdt
			// 
			this.OpCdt.BeginInit();
			this.OpCdt.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 40D);
			this.OpCdt.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.OpCdt.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OpCdt.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OpCdt.Name = "OpCdt";
			this.OpCdt.TagName = "OpCdt";
			this.OpCdt.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.OpCdt.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.OpCdt.Value = false;
			this.OpCdt.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 16D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Operating conditions";
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(160D)), ((float)(144D)));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.96D, 0D, 0D, 1D, 16D, 112D);
			this.Mode.DropDownItems.AddRange(new System.HMI.Symbols.Base.DropDownItem[] {
			new System.HMI.Symbols.Base.DropDownItem("Automatic", ((long)(0))),
			new System.HMI.Symbols.Base.DropDownItem("OFF", ((long)(1))),
			new System.HMI.Symbols.Base.DropDownItem("Manuel", ((long)(2))),
			new System.HMI.Symbols.Base.DropDownItem("Emergency", ((long)(3)))});
			this.Mode.Font = new NxtControl.Drawing.Font("ComboBoxFont");
			this.Mode.Name = "Mode";
			this.Mode.TagName = "Mode";
			this.Mode.TextColor = new NxtControl.Drawing.Color("ComboBoxTextColor");
			this.Mode.TextPadding = new NxtControl.Drawing.Padding(2);
			this.Mode.Value = ((short)(0));
			this.Mode.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 88D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Mode";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(168D, 80D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(8D, 80D);
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.OpCdt,
			this.freeText1,
			this.Mode,
			this.freeText2,
			this.line1});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.SwitchButton OpCdt;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private System.HMI.Symbols.Base.DropDown<short> Mode;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Line line1;
		#endregion
	}
}
