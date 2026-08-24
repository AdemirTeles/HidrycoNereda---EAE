/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 10:19 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Calamity
{
	/// <summary>
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.SpeedSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.H1LevelSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.CMD_NVPP_46_2_AP_a_95_008 = new SE.Nereda.Symbols.CalamityValveLogic.sSettings();
			this.CMD_NVPP_46_2_AP_a_95_009 = new SE.Nereda.Symbols.CalamityValveLogic.sSettings();
			this.CMD_NVPP_46_2_AP_a_95_010 = new SE.Nereda.Symbols.CalamityValveLogic.sSettings();
			this.CMD_NVPP_46_2_AP_a_95_008_1 = new SE.Nereda.Symbols.CalamityValveLogic.sDefault();
			this.CMD_NVPP_46_2_AP_a_95_009_1 = new SE.Nereda.Symbols.CalamityValveLogic.sDefault();
			this.CMD_NVPP_46_2_AP_a_95_010_1 = new SE.Nereda.Symbols.CalamityValveLogic.sDefault();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(288D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(264D, 8D),
			new NxtControl.Drawing.PointF(296D, 32D)});
			this.polygon1.Text = "CALAMITY";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(264D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 36D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Speed Setpoint (%) :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "High Level Setpoint (H1-level) :";
			// 
			// SpeedSp
			// 
			this.SpeedSp.BeginInit();
			this.SpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 32D);
			this.SpeedSp.MaximumTag = null;
			this.SpeedSp.MinimumTag = null;
			this.SpeedSp.Name = "SpeedSp";
			this.SpeedSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SpeedSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.SpeedSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SpeedSp.Suffix = "%";
			this.SpeedSp.TagName = "SpeedSp";
			this.SpeedSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.SpeedSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SpeedSp.UseInputPad = true;
			this.SpeedSp.Value = 0F;
			this.SpeedSp.EndInit();
			// 
			// H1LevelSp
			// 
			this.H1LevelSp.BeginInit();
			this.H1LevelSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 64D);
			this.H1LevelSp.MaximumTag = null;
			this.H1LevelSp.MinimumTag = null;
			this.H1LevelSp.Name = "H1LevelSp";
			this.H1LevelSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.H1LevelSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.H1LevelSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.H1LevelSp.Suffix = "m";
			this.H1LevelSp.TagName = "H1LevelSp";
			this.H1LevelSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.H1LevelSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.H1LevelSp.UseInputPad = true;
			this.H1LevelSp.Value = 0F;
			this.H1LevelSp.EndInit();
			// 
			// CMD_NVPP_46_2_AP_a_95_008
			// 
			this.CMD_NVPP_46_2_AP_a_95_008.BeginInit();
			this.CMD_NVPP_46_2_AP_a_95_008._iVLVN = "Valve 95 008";
			this.CMD_NVPP_46_2_AP_a_95_008.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 96D);
			this.CMD_NVPP_46_2_AP_a_95_008.Name = "CMD_NVPP_46_2_AP_a_95_008";
			this.CMD_NVPP_46_2_AP_a_95_008.SecurityToken = ((uint)(4294967295u));
			this.CMD_NVPP_46_2_AP_a_95_008.TagName = "CMD_NVPP_46_2_AP_a_95_008";
			this.CMD_NVPP_46_2_AP_a_95_008.EndInit();
			// 
			// CMD_NVPP_46_2_AP_a_95_009
			// 
			this.CMD_NVPP_46_2_AP_a_95_009.BeginInit();
			this.CMD_NVPP_46_2_AP_a_95_009._iVLVN = "Valve 95 009";
			this.CMD_NVPP_46_2_AP_a_95_009.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 160D);
			this.CMD_NVPP_46_2_AP_a_95_009.Name = "CMD_NVPP_46_2_AP_a_95_009";
			this.CMD_NVPP_46_2_AP_a_95_009.SecurityToken = ((uint)(4294967295u));
			this.CMD_NVPP_46_2_AP_a_95_009.TagName = "CMD_NVPP_46_2_AP_a_95_009";
			this.CMD_NVPP_46_2_AP_a_95_009.EndInit();
			// 
			// CMD_NVPP_46_2_AP_a_95_010
			// 
			this.CMD_NVPP_46_2_AP_a_95_010.BeginInit();
			this.CMD_NVPP_46_2_AP_a_95_010._iVLVN = "Valve 95 010";
			this.CMD_NVPP_46_2_AP_a_95_010.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 224D);
			this.CMD_NVPP_46_2_AP_a_95_010.Name = "CMD_NVPP_46_2_AP_a_95_010";
			this.CMD_NVPP_46_2_AP_a_95_010.SecurityToken = ((uint)(4294967295u));
			this.CMD_NVPP_46_2_AP_a_95_010.TagName = "CMD_NVPP_46_2_AP_a_95_010";
			this.CMD_NVPP_46_2_AP_a_95_010.EndInit();
			// 
			// CMD_NVPP_46_2_AP_a_95_008_1
			// 
			this.CMD_NVPP_46_2_AP_a_95_008_1.BeginInit();
			this.CMD_NVPP_46_2_AP_a_95_008_1._iVLVN = "Valve 95 008";
			this.CMD_NVPP_46_2_AP_a_95_008_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 128D);
			this.CMD_NVPP_46_2_AP_a_95_008_1.Name = "CMD_NVPP_46_2_AP_a_95_008_1";
			this.CMD_NVPP_46_2_AP_a_95_008_1.SecurityToken = ((uint)(4294967295u));
			this.CMD_NVPP_46_2_AP_a_95_008_1.TagName = "CMD_NVPP_46_2_AP_a_95_008";
			this.CMD_NVPP_46_2_AP_a_95_008_1.EndInit();
			// 
			// CMD_NVPP_46_2_AP_a_95_009_1
			// 
			this.CMD_NVPP_46_2_AP_a_95_009_1.BeginInit();
			this.CMD_NVPP_46_2_AP_a_95_009_1._iVLVN = "Valve 95 009";
			this.CMD_NVPP_46_2_AP_a_95_009_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 192D);
			this.CMD_NVPP_46_2_AP_a_95_009_1.Name = "CMD_NVPP_46_2_AP_a_95_009_1";
			this.CMD_NVPP_46_2_AP_a_95_009_1.SecurityToken = ((uint)(4294967295u));
			this.CMD_NVPP_46_2_AP_a_95_009_1.TagName = "CMD_NVPP_46_2_AP_a_95_009";
			this.CMD_NVPP_46_2_AP_a_95_009_1.EndInit();
			// 
			// CMD_NVPP_46_2_AP_a_95_010_1
			// 
			this.CMD_NVPP_46_2_AP_a_95_010_1.BeginInit();
			this.CMD_NVPP_46_2_AP_a_95_010_1._iVLVN = "Valve 95 010";
			this.CMD_NVPP_46_2_AP_a_95_010_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 256D);
			this.CMD_NVPP_46_2_AP_a_95_010_1.Name = "CMD_NVPP_46_2_AP_a_95_010_1";
			this.CMD_NVPP_46_2_AP_a_95_010_1.SecurityToken = ((uint)(4294967295u));
			this.CMD_NVPP_46_2_AP_a_95_010_1.TagName = "CMD_NVPP_46_2_AP_a_95_010";
			this.CMD_NVPP_46_2_AP_a_95_010_1.EndInit();
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(296D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.SpeedSp,
			this.H1LevelSp,
			this.CMD_NVPP_46_2_AP_a_95_008,
			this.CMD_NVPP_46_2_AP_a_95_009,
			this.CMD_NVPP_46_2_AP_a_95_010,
			this.CMD_NVPP_46_2_AP_a_95_008_1,
			this.CMD_NVPP_46_2_AP_a_95_009_1,
			this.CMD_NVPP_46_2_AP_a_95_010_1});
			this.Size = new System.Drawing.Size(376, 296);
			this.Title = "Calamity Settings";

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> SpeedSp;
		private System.HMI.Symbols.Base.TextBox<float> H1LevelSp;
		private SE.Nereda.Symbols.CalamityValveLogic.sSettings CMD_NVPP_46_2_AP_a_95_008;
		private SE.Nereda.Symbols.CalamityValveLogic.sSettings CMD_NVPP_46_2_AP_a_95_009;
		private SE.Nereda.Symbols.CalamityValveLogic.sSettings CMD_NVPP_46_2_AP_a_95_010;
		private SE.Nereda.Symbols.CalamityValveLogic.sDefault CMD_NVPP_46_2_AP_a_95_008_1;
		private SE.Nereda.Symbols.CalamityValveLogic.sDefault CMD_NVPP_46_2_AP_a_95_009_1;
		private SE.Nereda.Symbols.CalamityValveLogic.sDefault CMD_NVPP_46_2_AP_a_95_010_1;
		#endregion
	}
}
