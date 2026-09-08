/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/8/2026
 * Time: 7:33 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FeedInfluentLogic
{
	/// <summary>
	/// Summary description for fpFreezWDur.
	/// </summary>
	partial class fpFreezWDur
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
			this.FreezRunOperation = new SE.Nereda.Symbols.E_DELAY_V_D.sDefault();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.FreezStopOperation = new SE.Nereda.Symbols.E_DELAY_V_D.sDefault();
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
			this.polygon1.Text = "Freeze Weather Duration";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(320D)), ((float)(64D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 28D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Running Duration :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(176D, 28D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Stop Duration :";
			// 
			// FreezRunOperation
			// 
			this.FreezRunOperation.BeginInit();
			this.FreezRunOperation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 48D);
			this.FreezRunOperation.Name = "FreezRunOperation";
			this.FreezRunOperation.SecurityToken = ((uint)(4294967295u));
			this.FreezRunOperation.TagName = "FreezRunOperation";
			this.FreezRunOperation.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(168D, 88D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(168D, 24D);
			// 
			// FreezStopOperation
			// 
			this.FreezStopOperation.BeginInit();
			this.FreezStopOperation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 176D, 48D);
			this.FreezStopOperation.Name = "FreezStopOperation";
			this.FreezStopOperation.SecurityToken = ((uint)(4294967295u));
			this.FreezStopOperation.TagName = "FreezStopOperation";
			this.FreezStopOperation.EndInit();
			// 
			// fpFreezWDur
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(336D)), ((float)(96D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.FreezRunOperation,
			this.line1,
			this.FreezStopOperation});
			this.Size = new System.Drawing.Size(336, 96);
			this.Title = "Freeze Weather Duration";

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private SE.Nereda.Symbols.E_DELAY_V_D.sDefault FreezRunOperation;
		private NxtControl.GuiFramework.Line line1;
		private SE.Nereda.Symbols.E_DELAY_V_D.sDefault FreezStopOperation;
		#endregion
	}
}
