/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/11/2026
 * Time: 3:14 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.DAerationLogic
{
	/// <summary>
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpSettingsS
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fpSettingsS));
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.C_MAX = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.C2_IN = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.C3_IN = new System.HMI.Symbols.Base.TextBox<float>();
			this.Config2 = new NxtControl.GuiFramework.Rectangle();
			this.CapacityConfig = new System.HMI.Symbols.Base.DropDown<short>();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.Config1 = new NxtControl.GuiFramework.Rectangle();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(368D)), ((float)(152D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 20D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "2-Blower Start Threshold (C MAX) :";
			// 
			// C_MAX
			// 
			this.C_MAX.BeginInit();
			this.C_MAX.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 16D);
			this.C_MAX.MaximumTag = null;
			this.C_MAX.MinimumTag = null;
			this.C_MAX.Name = "C_MAX";
			this.C_MAX.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C_MAX.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C_MAX.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C_MAX.Suffix = "%";
			this.C_MAX.TagName = "C_MAX";
			this.C_MAX.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C_MAX.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C_MAX.UseInputPad = true;
			this.C_MAX.Value = 0F;
			this.C_MAX.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 52D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Starting Blowers Sp (C2) :";
			// 
			// C2_IN
			// 
			this.C2_IN.BeginInit();
			this.C2_IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 48D);
			this.C2_IN.MaximumTag = null;
			this.C2_IN.MinimumTag = null;
			this.C2_IN.Name = "C2_IN";
			this.C2_IN.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C2_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C2_IN.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C2_IN.Suffix = "%";
			this.C2_IN.TagName = "C2_IN";
			this.C2_IN.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C2_IN.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C2_IN.UseInputPad = true;
			this.C2_IN.Value = 0F;
			this.C2_IN.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 84D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Below Capacity Sp (C3) :";
			// 
			// C3_IN
			// 
			this.C3_IN.BeginInit();
			this.C3_IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 256D, 80D);
			this.C3_IN.MaximumTag = null;
			this.C3_IN.MinimumTag = null;
			this.C3_IN.Name = "C3_IN";
			this.C3_IN.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C3_IN.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C3_IN.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C3_IN.Suffix = "%";
			this.C3_IN.TagName = "C3_IN";
			this.C3_IN.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C3_IN.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C3_IN.UseInputPad = true;
			this.C3_IN.Value = 0F;
			this.C3_IN.EndInit();
			// 
			// Config2
			// 
			this.Config2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(168D)), ((float)(368D)), ((float)(192D)));
			this.Config2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.Config2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Config2.ImageBytes = resources.GetString("Config2.ImageBytes");
			this.Config2.Name = "Config2";
			this.Config2.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpAerSettings", NxtControl.GuiFramework.MouseButtonType.Click));
			// 
			// CapacityConfig
			// 
			this.CapacityConfig.BeginInit();
			this.CapacityConfig.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.CapacityConfig.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 256D, 112D);
			this.CapacityConfig.DropDownItems.AddRange(new System.HMI.Symbols.Base.DropDownItem[] {
			new System.HMI.Symbols.Base.DropDownItem("0% - 86%", ((long)(1))),
			new System.HMI.Symbols.Base.DropDownItem("50% - 86%", ((long)(2)))});
			this.CapacityConfig.Font = new NxtControl.Drawing.Font("ComboBoxFont");
			this.CapacityConfig.Name = "CapacityConfig";
			this.CapacityConfig.TagName = "CapacityConfig";
			this.CapacityConfig.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CapacityConfig.TextPadding = new NxtControl.Drawing.Padding(2);
			this.CapacityConfig.Value = ((short)(0));
			this.CapacityConfig.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 116D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Blowers Capacity Range\r\nWhen C_IN > C_MAX :";
			// 
			// Config1
			// 
			this.Config1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(168D)), ((float)(368D)), ((float)(192D)));
			this.Config1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.Config1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Config1.ImageBytes = resources.GetString("Config1.ImageBytes");
			this.Config1.Name = "Config1";
			this.Config1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpAerSettings", NxtControl.GuiFramework.MouseButtonType.Click));
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(384D)), ((float)(368D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText1,
			this.C_MAX,
			this.freeText2,
			this.C2_IN,
			this.freeText3,
			this.C3_IN,
			this.Config2,
			this.CapacityConfig,
			this.freeText4,
			this.Config1});
			this.Size = new System.Drawing.Size(384, 368);
			this.Title = "Aeration Settings";

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> C_MAX;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> C2_IN;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.TextBox<float> C3_IN;
		private NxtControl.GuiFramework.Rectangle Config2;
		private System.HMI.Symbols.Base.DropDown<short> CapacityConfig;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle Config1;
		#endregion
	}
}
