/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 4:40 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CmdAerate
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.AirValveAerationGridMan = new System.HMI.Symbols.Base.SwitchButton();
			this.AirValveInfluentGridMan = new System.HMI.Symbols.Base.SwitchButton();
			this.ManCapacity_Blower = new System.HMI.Symbols.Base.TextBox<float>();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.D_C_Sel = new System.HMI.Symbols.Base.DropDown<bool>();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.D_C_Sel_1 = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(48D)), ((float)(368D)), ((float)(168D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 142D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Air valve aeration grid (Manual Mode) :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 182D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Air valve influent grid (Manual Mode) :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 100D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Aeration Capacity Sp (Manual Mode) :";
			// 
			// AirValveAerationGridMan
			// 
			this.AirValveAerationGridMan.BeginInit();
			this.AirValveAerationGridMan.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 272D, 136D);
			this.AirValveAerationGridMan.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.AirValveAerationGridMan.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirValveAerationGridMan.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.AirValveAerationGridMan.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.AirValveAerationGridMan.Name = "AirValveAerationGridMan";
			this.AirValveAerationGridMan.TagName = "AirValveAerationGridMan";
			this.AirValveAerationGridMan.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.AirValveAerationGridMan.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirValveAerationGridMan.Value = false;
			this.AirValveAerationGridMan.EndInit();
			// 
			// AirValveInfluentGridMan
			// 
			this.AirValveInfluentGridMan.BeginInit();
			this.AirValveInfluentGridMan.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 272D, 176D);
			this.AirValveInfluentGridMan.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.AirValveInfluentGridMan.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirValveInfluentGridMan.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.AirValveInfluentGridMan.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.AirValveInfluentGridMan.Name = "AirValveInfluentGridMan";
			this.AirValveInfluentGridMan.TagName = "AirValveInfluentGridMan";
			this.AirValveInfluentGridMan.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.AirValveInfluentGridMan.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirValveInfluentGridMan.Value = false;
			this.AirValveInfluentGridMan.EndInit();
			// 
			// ManCapacity_Blower
			// 
			this.ManCapacity_Blower.BeginInit();
			this.ManCapacity_Blower.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 96D);
			this.ManCapacity_Blower.MaximumTag = null;
			this.ManCapacity_Blower.MinimumTag = null;
			this.ManCapacity_Blower.Name = "ManCapacity_Blower";
			this.ManCapacity_Blower.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.ManCapacity_Blower.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ManCapacity_Blower.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.ManCapacity_Blower.Suffix = "%";
			this.ManCapacity_Blower.TagName = "ManCapacity_Blower";
			this.ManCapacity_Blower.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.ManCapacity_Blower.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ManCapacity_Blower.UseInputPad = true;
			this.ManCapacity_Blower.Value = 0F;
			this.ManCapacity_Blower.EndInit();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(176D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 56D),
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(160D, 32D),
			new NxtControl.Drawing.PointF(184D, 56D)});
			this.polygon1.Text = "AERATE";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// D_C_Sel
			// 
			this.D_C_Sel.BeginInit();
			this.D_C_Sel.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.D_C_Sel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1066666666666667D, 0D, 0D, 1D, 200D, 60D);
			this.D_C_Sel.DropDownItems.AddRange(new System.HMI.Symbols.Base.DropDownItem[] {
			new System.HMI.Symbols.Base.DropDownItem("Dedicated Aeration", ((long)(0))),
			new System.HMI.Symbols.Base.DropDownItem("Common Aeration", ((long)(1)))});
			this.D_C_Sel.Font = new NxtControl.Drawing.Font("ComboBoxFont");
			this.D_C_Sel.Name = "D_C_Sel";
			this.D_C_Sel.TagName = "D_C_Sel";
			this.D_C_Sel.TextColor = new NxtControl.Drawing.Color("ComboBoxTextColor");
			this.D_C_Sel.TextPadding = new NxtControl.Drawing.Padding(2);
			this.D_C_Sel.Value = false;
			this.D_C_Sel.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 64D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Aeration Type :";
			// 
			// D_C_Sel_1
			// 
			this.D_C_Sel_1.BeginInit();
			this.D_C_Sel_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 138D, 494D);
			this.D_C_Sel_1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.D_C_Sel_1.Name = "D_C_Sel_1";
			this.D_C_Sel_1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.D_C_Sel_1.TagName = "D_C_Sel";
			this.D_C_Sel_1.Value = false;
			this.D_C_Sel_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.D_C_Sel_1ValueChanged);
			this.D_C_Sel_1.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.AirValveAerationGridMan,
			this.AirValveInfluentGridMan,
			this.ManCapacity_Blower,
			this.D_C_Sel,
			this.freeText4,
			this.D_C_Sel_1});
			this.SymbolSize = new System.Drawing.Size(384, 280);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.SwitchButton AirValveAerationGridMan;
		private System.HMI.Symbols.Base.SwitchButton AirValveInfluentGridMan;
		private System.HMI.Symbols.Base.TextBox<float> ManCapacity_Blower;
		private NxtControl.GuiFramework.Polygon polygon1;
		private System.HMI.Symbols.Base.DropDown<bool> D_C_Sel;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.Execute<bool> D_C_Sel_1;
		#endregion
	}
}
