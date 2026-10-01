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

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLB
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
			this.FeedFlowSpMan = new System.HMI.Symbols.Base.TextBox<float>();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.textBox_11 = new System.HMI.Symbols.Base.TextBox<float>();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.T_Restart = new System.HMI.Symbols.Base.TimeTextBox();
			this.T_FlowLL = new System.HMI.Symbols.Base.TimeTextBox();
			this.rectangleCmin = new NxtControl.GuiFramework.Rectangle();
			this.freeTextCmin = new NxtControl.GuiFramework.FreeText();
			this.Cmin = new System.HMI.Symbols.Base.TextBox<float>();
			this.PumpStatus = new SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic.sDefault();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(376D)), ((float)(40D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 44D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Flow Setpoint (Manual Mode) :";
			// 
			// FeedFlowSpMan
			// 
			this.FeedFlowSpMan.BeginInit();
			this.FeedFlowSpMan.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 40D);
			this.FeedFlowSpMan.MaximumTag = null;
			this.FeedFlowSpMan.MinimumTag = null;
			this.FeedFlowSpMan.Name = "FeedFlowSpMan";
			this.FeedFlowSpMan.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FeedFlowSpMan.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.FeedFlowSpMan.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FeedFlowSpMan.Suffix = "m³/h";
			this.FeedFlowSpMan.TagName = "FeedFlowSpMan";
			this.FeedFlowSpMan.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.FeedFlowSpMan.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FeedFlowSpMan.UseInputPad = true;
			this.FeedFlowSpMan.Value = 0F;
			this.FeedFlowSpMan.EndInit();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(176D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 40D),
			new NxtControl.Drawing.PointF(8D, 16D),
			new NxtControl.Drawing.PointF(160D, 16D),
			new NxtControl.Drawing.PointF(184D, 40D)});
			this.polygon1.Text = "SLUDGE DISCHARGE";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(72D)), ((float)(376D)), ((float)(40D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 84D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Flow Setpoint (Auto Mode) :";
			// 
			// textBox_11
			// 
			this.textBox_11.BeginInit();
			this.textBox_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 80D);
			this.textBox_11.MaximumTag = null;
			this.textBox_11.MinimumTag = null;
			this.textBox_11.Name = "textBox_11";
			this.textBox_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.textBox_11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.textBox_11.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_11.Suffix = "m³/h";
			this.textBox_11.TagName = "FeedFlowSp";
			this.textBox_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.textBox_11.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textBox_11.UseInputPad = true;
			this.textBox_11.Value = 0F;
			this.textBox_11.EndInit();
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(112D)), ((float)(376D)), ((float)(40D)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(152D)), ((float)(376D)), ((float)(40D)));
			this.rectangle9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 124D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Restart Time :";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 164D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Flow LowLow Time :";
			// 
			// T_Restart
			// 
			this.T_Restart.BeginInit();
			this.T_Restart.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 120D);
			this.T_Restart.MaximumTag = null;
			this.T_Restart.MinimumTag = null;
			this.T_Restart.Name = "T_Restart";
			this.T_Restart.TagName = "T_Restart";
			this.T_Restart.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_Restart.EndInit();
			// 
			// T_FlowLL
			// 
			this.T_FlowLL.BeginInit();
			this.T_FlowLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 160D);
			this.T_FlowLL.MaximumTag = null;
			this.T_FlowLL.MinimumTag = null;
			this.T_FlowLL.Name = "T_FlowLL";
			this.T_FlowLL.TagName = "T_FlowLL";
			this.T_FlowLL.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_FlowLL.EndInit();
			// 
			// rectangleCmin
			// 
			this.rectangleCmin.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(192D)), ((float)(376D)), ((float)(40D)));
			this.rectangleCmin.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangleCmin.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangleCmin.Name = "rectangleCmin";
			// 
			// freeTextCmin
			// 
			this.freeTextCmin.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeTextCmin.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeTextCmin.Location = new NxtControl.Drawing.PointF(16D, 204D);
			this.freeTextCmin.Name = "freeTextCmin";
			this.freeTextCmin.Text = "Min. Pump Speed (Cmin) :";
			// 
			// Cmin
			// 
			this.Cmin.BeginInit();
			this.Cmin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 200D);
			this.Cmin.MaximumTag = null;
			this.Cmin.MinimumTag = null;
			this.Cmin.Name = "Cmin";
			this.Cmin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Cmin.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Cmin.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Cmin.Suffix = "%";
			this.Cmin.TagName = "Cmin";
			this.Cmin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.Cmin.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Cmin.Value = 0F;
			this.Cmin.EndInit();
			// 
			// PumpStatus
			// 
			this.PumpStatus.BeginInit();
			this.PumpStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 240D);
			this.PumpStatus.Name = "PumpStatus";
			this.PumpStatus.SecurityToken = ((uint)(4294967295u));
			this.PumpStatus.TagName = "CommandLogic";
			this.PumpStatus.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.FeedFlowSpMan,
			this.rectangle2,
			this.freeText2,
			this.textBox_11,
			this.rectangle8,
			this.rectangle9,
			this.freeText8,
			this.freeText9,
			this.T_Restart,
			this.T_FlowLL,
			this.rectangleCmin,
			this.freeTextCmin,
			this.Cmin,
			this.PumpStatus});
			this.SymbolSize = new System.Drawing.Size(432, 424);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> FeedFlowSpMan;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> textBox_11;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private System.HMI.Symbols.Base.TimeTextBox T_Restart;
		private System.HMI.Symbols.Base.TimeTextBox T_FlowLL;
		private NxtControl.GuiFramework.Rectangle rectangleCmin;
		private NxtControl.GuiFramework.FreeText freeTextCmin;
		private System.HMI.Symbols.Base.TextBox<float> Cmin;
		private SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic.sDefault PumpStatus;
		#endregion
	}
}
