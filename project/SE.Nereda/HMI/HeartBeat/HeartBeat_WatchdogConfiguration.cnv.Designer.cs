/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA583220
 * Date: 8/29/2022
 * Time: 4:54 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.HeartBeat
{
	/// <summary>
	/// Summary description for WatchdogConfiguration.
	/// </summary>
	partial class WatchdogConfiguration
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new NxtControl.GuiFramework.Label();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.EnableSim = new System.HMI.Symbols.Base.SwitchButton();
			this.label2 = new NxtControl.GuiFramework.Label();
			this.Watchdog = new System.HMI.Symbols.Base.TimeTextBox();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.label3 = new NxtControl.GuiFramework.Label();
			this.TimeOutDisplayCounter = new SE.Nereda.Symbols.COUNTER.sDefault();
			// 
			// label1
			// 
			this.label1.AngleIgnore = true;
			this.label1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(176D)), ((float)(26D)));
			this.label1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label1.FontScale = true;
			this.label1.Name = "label1";
			this.label1.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label1.Text = "Watchdog Time Out :";
			this.label1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label1.TextAutoSizeHorizontalOffset = 10;
			this.label1.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(160D)), ((float)(24D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(136D, 8D),
			new NxtControl.Drawing.PointF(168D, 32D)});
			this.polygon2.Text = "WATCHDOG";
			this.polygon2.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(280D)), ((float)(144D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// EnableSim
			// 
			this.EnableSim.BeginInit();
			this.EnableSim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2D, 0D, 0D, 1D, 176D, 64D);
			this.EnableSim.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.EnableSim.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.EnableSim.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.EnableSim.Name = "EnableSim";
			this.EnableSim.TagName = "EnableSim";
			this.EnableSim.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.EnableSim.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.EnableSim.Value = false;
			this.EnableSim.EndInit();
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(64D)), ((float)(176D)), ((float)(26D)));
			this.label2.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.FontScale = true;
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label2.Text = "Watchdog Simulation :";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// Watchdog
			// 
			this.Watchdog.BeginInit();
			this.Watchdog.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 176D, 32D);
			this.Watchdog.MaximumTag = null;
			this.Watchdog.MinimumTag = null;
			this.Watchdog.Name = "Watchdog";
			this.Watchdog.TagName = "Watchdog";
			this.Watchdog.UseInputPad = true;
			this.Watchdog.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.Watchdog.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(8D, 104D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(288D, 104D);
			// 
			// label3
			// 
			this.label3.AngleIgnore = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label3.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(104D)), ((float)(176D)), ((float)(26D)));
			this.label3.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label3.FontScale = true;
			this.label3.Name = "label3";
			this.label3.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label3.Text = "Watchdog Time Out :";
			this.label3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label3.TextAutoSizeHorizontalOffset = 10;
			this.label3.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// TimeOutDisplayCounter
			// 
			this.TimeOutDisplayCounter.BeginInit();
			this.TimeOutDisplayCounter.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 128D);
			this.TimeOutDisplayCounter.Name = "TimeOutDisplayCounter";
			this.TimeOutDisplayCounter.SecurityToken = ((uint)(4294967295u));
			this.TimeOutDisplayCounter.TagName = "TimeOutDisplayCounter";
			this.TimeOutDisplayCounter.EndInit();
			// 
			// WatchdogConfiguration
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(296D)), ((float)(176D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.rectangle2,
			this.label1,
			this.EnableSim,
			this.label2,
			this.Watchdog,
			this.line1,
			this.label3,
			this.TimeOutDisplayCounter});
			this.Size = new System.Drawing.Size(296, 176);
			this.Title = "WatchDog";

		}
		private System.HMI.Symbols.Base.TimeTextBox Watchdog;
		private NxtControl.GuiFramework.Label label1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private System.HMI.Symbols.Base.SwitchButton EnableSim;
		private NxtControl.GuiFramework.Label label2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Label label3;
		private SE.Nereda.Symbols.COUNTER.sDefault TimeOutDisplayCounter;
		#endregion
	}
}
