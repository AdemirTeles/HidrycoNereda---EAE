/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 11:38 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushGritScreenInstallation
{
	/// <summary>
	/// Summary description for sSettings.
	/// </summary>
	partial class sSettings
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
			this.TimeFromLastFlush = new System.HMI.Symbols.Base.TimeTextBox();
			this.FlushDuration = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.FlushFlowSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.CmdFlush = new NxtControl.GuiFramework.DrawnButton();
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
			this.polygon1.Text = "FLUSH GRIT SCREEN INSTALLATION";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(136D)));
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
			this.freeText1.Text = "Time From Last Flush :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Flush Duration :";
			// 
			// TimeFromLastFlush
			// 
			this.TimeFromLastFlush.BeginInit();
			this.TimeFromLastFlush.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 32D);
			this.TimeFromLastFlush.MaximumTag = null;
			this.TimeFromLastFlush.MinimumTag = null;
			this.TimeFromLastFlush.Name = "TimeFromLastFlush";
			this.TimeFromLastFlush.TagName = "TimeFromLastFlush";
			this.TimeFromLastFlush.UseInputPad = true;
			this.TimeFromLastFlush.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.TimeFromLastFlush.EndInit();
			// 
			// FlushDuration
			// 
			this.FlushDuration.BeginInit();
			this.FlushDuration.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 64D);
			this.FlushDuration.MaximumTag = null;
			this.FlushDuration.MinimumTag = null;
			this.FlushDuration.Name = "FlushDuration";
			this.FlushDuration.TagName = "FlushDuration";
			this.FlushDuration.UseInputPad = true;
			this.FlushDuration.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.FlushDuration.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 132D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Flush Manuel Start :";
			// 
			// FlushFlowSp
			// 
			this.FlushFlowSp.BeginInit();
			this.FlushFlowSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 96D);
			this.FlushFlowSp.MaximumTag = null;
			this.FlushFlowSp.MinimumTag = null;
			this.FlushFlowSp.Name = "FlushFlowSp";
			this.FlushFlowSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FlushFlowSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.FlushFlowSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FlushFlowSp.Suffix = "m³/h";
			this.FlushFlowSp.TagName = "FlushFlowSp";
			this.FlushFlowSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.FlushFlowSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.FlushFlowSp.UseInputPad = true;
			this.FlushFlowSp.Value = 0F;
			this.FlushFlowSp.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 100D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Flush Flow Setpoint :";
			// 
			// CmdFlush
			// 
			this.CmdFlush.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(128D)), ((float)(96D)), ((float)(25D)));
			this.CmdFlush.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.CmdFlush.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.CmdFlush.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.CmdFlush.Name = "CmdFlush";
			this.CmdFlush.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.CmdFlush.Radius = 4D;
			this.CmdFlush.Text = "START";
			this.CmdFlush.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.CmdFlush.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.CmdFlush.Use3DEffect = false;
			this.CmdFlush.Click += new System.EventHandler(this.CmdFlushClick);
			// 
			// sSettings
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.TimeFromLastFlush,
			this.FlushDuration,
			this.freeText4,
			this.FlushFlowSp,
			this.freeText3,
			this.CmdFlush});
			this.SymbolSize = new System.Drawing.Size(400, 264);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TimeTextBox TimeFromLastFlush;
		private System.HMI.Symbols.Base.TimeTextBox FlushDuration;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.DrawnButton CmdFlush;
		private System.HMI.Symbols.Base.TextBox<float> FlushFlowSp;
		private NxtControl.GuiFramework.FreeText freeText3;
		#endregion
	}
}
