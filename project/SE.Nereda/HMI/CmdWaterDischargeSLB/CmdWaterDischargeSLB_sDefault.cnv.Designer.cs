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

namespace SE.Nereda.Symbols.CmdWaterDischargeSLB
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.FeedFlowSpMan = new System.HMI.Symbols.Base.TextBox<float>();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.FeedFlowSp = new System.HMI.Symbols.Base.Label<float>();
			this.Cmax = new System.HMI.Symbols.Base.TextBox<float>();
			this.C2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.C3 = new System.HMI.Symbols.Base.TextBox<float>();
			this.T_C2 = new System.HMI.Symbols.Base.TimeTextBox();
			this.T_C3 = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.T_Restart = new System.HMI.Symbols.Base.TimeTextBox();
			this.T_FlowLL = new System.HMI.Symbols.Base.TimeTextBox();
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
			this.polygon1.Text = "WATER DISCHARGE";
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
			this.freeText2.Text = "Flow Setpoint (AutoMode) :";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(112D)), ((float)(376D)), ((float)(40D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(152D)), ((float)(376D)), ((float)(40D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(192D)), ((float)(376D)), ((float)(40D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(232D)), ((float)(376D)), ((float)(40D)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(272D)), ((float)(376D)), ((float)(40D)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(312D)), ((float)(376D)), ((float)(40D)));
			this.rectangle8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 204D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Starting 3nd Blower Sp (C3) :";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 164D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Starting 2rd Blower Sp (C2) :";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 124D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Maximun Capacity Blowers :";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 244D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Adjustable Time (C2) :";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 284D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Adjustable Time (C3) :";
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(352D)), ((float)(376D)), ((float)(40D)));
			this.rectangle9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			// 
			// FeedFlowSp
			// 
			this.FeedFlowSp.BeginInit();
			this.FeedFlowSp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.FeedFlowSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1.2380952380952381D, 272D, 80D);
			this.FeedFlowSp.FontScale = false;
			this.FeedFlowSp.LeadingZeros = ((uint)(0u));
			this.FeedFlowSp.Name = "FeedFlowSp";
			this.FeedFlowSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FeedFlowSp.Ranges.Clear();
			this.FeedFlowSp.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.FeedFlowSp.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.FeedFlowSp.Suffix = "m³/h";
			this.FeedFlowSp.TagName = "FeedFlowSp";
			this.FeedFlowSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.FeedFlowSp.EndInit();
			// 
			// Cmax
			// 
			this.Cmax.BeginInit();
			this.Cmax.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 120D);
			this.Cmax.MaximumTag = null;
			this.Cmax.MinimumTag = null;
			this.Cmax.Name = "Cmax";
			this.Cmax.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.Cmax.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Cmax.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.Cmax.Suffix = "m³/h";
			this.Cmax.TagName = "Cmax";
			this.Cmax.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.Cmax.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Cmax.Value = 0F;
			this.Cmax.EndInit();
			// 
			// C2
			// 
			this.C2.BeginInit();
			this.C2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 160D);
			this.C2.MaximumTag = null;
			this.C2.MinimumTag = null;
			this.C2.Name = "C2";
			this.C2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C2.Suffix = "m³/h";
			this.C2.TagName = "C2";
			this.C2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C2.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C2.Value = 0F;
			this.C2.EndInit();
			// 
			// C3
			// 
			this.C3.BeginInit();
			this.C3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 200D);
			this.C3.MaximumTag = null;
			this.C3.MinimumTag = null;
			this.C3.Name = "C3";
			this.C3.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.C3.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C3.Suffix = "m³/h";
			this.C3.TagName = "C3";
			this.C3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C3.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C3.Value = 0F;
			this.C3.EndInit();
			// 
			// T_C2
			// 
			this.T_C2.BeginInit();
			this.T_C2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 240D);
			this.T_C2.MaximumTag = null;
			this.T_C2.MinimumTag = null;
			this.T_C2.Name = "T_C2";
			this.T_C2.TagName = "T_C2";
			this.T_C2.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_C2.EndInit();
			// 
			// T_C3
			// 
			this.T_C3.BeginInit();
			this.T_C3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 280D);
			this.T_C3.MaximumTag = null;
			this.T_C3.MinimumTag = null;
			this.T_C3.Name = "T_C3";
			this.T_C3.TagName = "T_C3";
			this.T_C3.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_C3.EndInit();
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 324D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Restart Time :";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 364D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Flow LowLow Time :";
			// 
			// T_Restart
			// 
			this.T_Restart.BeginInit();
			this.T_Restart.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 319D);
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
			this.T_FlowLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 360D);
			this.T_FlowLL.MaximumTag = null;
			this.T_FlowLL.MinimumTag = null;
			this.T_FlowLL.Name = "T_FlowLL";
			this.T_FlowLL.TagName = "T_FlowLL";
			this.T_FlowLL.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.T_FlowLL.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle2,
			this.freeText2,
			this.rectangle1,
			this.freeText1,
			this.FeedFlowSpMan,
			this.rectangle3,
			this.rectangle4,
			this.rectangle5,
			this.rectangle6,
			this.rectangle7,
			this.rectangle8,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.rectangle9,
			this.FeedFlowSp,
			this.Cmax,
			this.C2,
			this.C3,
			this.T_C2,
			this.T_C3,
			this.freeText8,
			this.freeText9,
			this.T_Restart,
			this.T_FlowLL});
			this.SymbolSize = new System.Drawing.Size(432, 416);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> FeedFlowSpMan;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> Cmax;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private System.HMI.Symbols.Base.Label<float> FeedFlowSp;
		private System.HMI.Symbols.Base.TextBox<float> C2;
		private System.HMI.Symbols.Base.TextBox<float> C3;
		private System.HMI.Symbols.Base.TimeTextBox T_C2;
		private System.HMI.Symbols.Base.TimeTextBox T_C3;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private System.HMI.Symbols.Base.TimeTextBox T_Restart;
		private System.HMI.Symbols.Base.TimeTextBox T_FlowLL;
		#endregion
	}
}
