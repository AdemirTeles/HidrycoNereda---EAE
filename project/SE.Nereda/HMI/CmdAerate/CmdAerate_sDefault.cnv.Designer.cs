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
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.ManCapacity_Blower = new System.HMI.Symbols.Base.TextBox<float>();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.AirFillValveMan = new System.HMI.Symbols.Base.SwitchButton();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(48D)), ((float)(368D)), ((float)(136D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 120D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Air Fill valve (Manual Mode) :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 64D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Aeration Capacity Sp (Manual Mode) :";
			// 
			// ManCapacity_Blower
			// 
			this.ManCapacity_Blower.BeginInit();
			this.ManCapacity_Blower.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1.1538461538461537D, 272D, 64D);
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
			// AirFillValveMan
			// 
			this.AirFillValveMan.BeginInit();
			this.AirFillValveMan.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 272D, 112D);
			this.AirFillValveMan.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.AirFillValveMan.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirFillValveMan.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.AirFillValveMan.Name = "AirFillValveMan";
			this.AirFillValveMan.TagName = "AirFillValveMan";
			this.AirFillValveMan.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.AirFillValveMan.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.AirFillValveMan.Value = false;
			this.AirFillValveMan.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText3,
			this.ManCapacity_Blower,
			this.AirFillValveMan});
			this.SymbolSize = new System.Drawing.Size(384, 280);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.SwitchButton AirFillValveMan;
		private System.HMI.Symbols.Base.TextBox<float> ManCapacity_Blower;
		private NxtControl.GuiFramework.Polygon polygon1;
		#endregion
	}
}
