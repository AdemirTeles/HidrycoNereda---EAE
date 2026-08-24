/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/13/2026
 * Time: 7:00 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FeedReactorLogic
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
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.MaxCapacityOnePump = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.C2Capacity = new System.HMI.Symbols.Base.TextBox<float>();
			this.RestartWaitingTime = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(176D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(160D, 8D),
			new NxtControl.Drawing.PointF(184D, 32D)});
			this.polygon1.Text = "FEED REACTOR";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(376D)), ((float)(112D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 36D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Maximum Capacity for One Pump :";
			// 
			// MaxCapacityOnePump
			// 
			this.MaxCapacityOnePump.BeginInit();
			this.MaxCapacityOnePump.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6399999999999999D, 0D, 0D, 1D, 248D, 32D);
			this.MaxCapacityOnePump.MaximumTag = null;
			this.MaxCapacityOnePump.MinimumTag = null;
			this.MaxCapacityOnePump.Name = "MaxCapacityOnePump";
			this.MaxCapacityOnePump.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.MaxCapacityOnePump.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.MaxCapacityOnePump.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.MaxCapacityOnePump.Suffix = "m³/h";
			this.MaxCapacityOnePump.TagName = "MaxCapacityOnePump";
			this.MaxCapacityOnePump.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.MaxCapacityOnePump.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.MaxCapacityOnePump.UseInputPad = true;
			this.MaxCapacityOnePump.Value = 0F;
			this.MaxCapacityOnePump.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "C2 Transition Capacity :";
			// 
			// C2Capacity
			// 
			this.C2Capacity.BeginInit();
			this.C2Capacity.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 64D);
			this.C2Capacity.MaximumTag = null;
			this.C2Capacity.MinimumTag = null;
			this.C2Capacity.Name = "C2Capacity";
			this.C2Capacity.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.C2Capacity.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.C2Capacity.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.C2Capacity.Suffix = "m³/h";
			this.C2Capacity.TagName = "C2Capacity";
			this.C2Capacity.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.C2Capacity.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.C2Capacity.UseInputPad = true;
			this.C2Capacity.Value = 0F;
			this.C2Capacity.EndInit();
			// 
			// RestartWaitingTime
			// 
			this.RestartWaitingTime.BeginInit();
			this.RestartWaitingTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 248D, 96D);
			this.RestartWaitingTime.MaximumTag = null;
			this.RestartWaitingTime.MinimumTag = null;
			this.RestartWaitingTime.Name = "RestartWaitingTime";
			this.RestartWaitingTime.TagName = "RestartWaitingTime";
			this.RestartWaitingTime.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.RestartWaitingTime.UseInputPad = true;
			this.RestartWaitingTime.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.RestartWaitingTime.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 100D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Feed Restart Waiting Time :";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText11,
			this.MaxCapacityOnePump,
			this.freeText1,
			this.C2Capacity,
			this.RestartWaitingTime,
			this.freeText2});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText11;
		private System.HMI.Symbols.Base.TextBox<float> MaxCapacityOnePump;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> C2Capacity;
		private System.HMI.Symbols.Base.TimeTextBox RestartWaitingTime;
		private NxtControl.GuiFramework.FreeText freeText2;
		#endregion
	}
}
