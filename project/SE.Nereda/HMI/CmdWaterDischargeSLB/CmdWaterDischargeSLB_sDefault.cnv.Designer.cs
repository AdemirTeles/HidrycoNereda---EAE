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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.FeedFlowSpMan = new System.HMI.Symbols.Base.TextBox<float>();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.textBox_11 = new System.HMI.Symbols.Base.TextBox<float>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(368D)), ((float)(40D)));
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
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(72D)), ((float)(368D)), ((float)(40D)));
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
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle2,
			this.freeText2,
			this.textBox_11,
			this.rectangle1,
			this.freeText1,
			this.FeedFlowSpMan});
			this.SymbolSize = new System.Drawing.Size(432, 144);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> FeedFlowSpMan;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> textBox_11;
		#endregion
	}
}
