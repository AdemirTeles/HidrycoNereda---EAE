/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 11:02 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushingManager
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
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.CapacitySp = new System.HMI.Symbols.Base.TextBox<float>();
			this.SwitchSpeedSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.StartSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.StopSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
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
			this.polygon1.Text = "EFFLUENT PUMP CTP 002";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(168D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 100D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Capacity Setpoint (m³/h) :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 132D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Switch Speed Setpoint (%) :";
			// 
			// CapacitySp
			// 
			this.CapacitySp.BeginInit();
			this.CapacitySp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 96D);
			this.CapacitySp.MaximumTag = null;
			this.CapacitySp.MinimumTag = null;
			this.CapacitySp.Name = "CapacitySp";
			this.CapacitySp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CapacitySp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.CapacitySp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.CapacitySp.Suffix = "m³/h";
			this.CapacitySp.TagName = "CapacitySp";
			this.CapacitySp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.CapacitySp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CapacitySp.UseInputPad = true;
			this.CapacitySp.Value = 0F;
			this.CapacitySp.EndInit();
			// 
			// SwitchSpeedSp
			// 
			this.SwitchSpeedSp.BeginInit();
			this.SwitchSpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 128D);
			this.SwitchSpeedSp.MaximumTag = null;
			this.SwitchSpeedSp.MinimumTag = null;
			this.SwitchSpeedSp.Name = "SwitchSpeedSp";
			this.SwitchSpeedSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SwitchSpeedSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.SwitchSpeedSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SwitchSpeedSp.Suffix = "%";
			this.SwitchSpeedSp.TagName = "SwitchSpeedSp";
			this.SwitchSpeedSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.SwitchSpeedSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SwitchSpeedSp.UseInputPad = true;
			this.SwitchSpeedSp.Value = 0F;
			this.SwitchSpeedSp.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(160D)), ((float)(96D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpGrafcet", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Diagram";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 164D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Control Diagram :";
			// 
			// StartSp
			// 
			this.StartSp.BeginInit();
			this.StartSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 32D);
			this.StartSp.MaximumTag = null;
			this.StartSp.MinimumTag = null;
			this.StartSp.Name = "StartSp";
			this.StartSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StartSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.StartSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StartSp.Suffix = "m";
			this.StartSp.TagName = "StartSp";
			this.StartSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.StartSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.StartSp.UseInputPad = true;
			this.StartSp.Value = 0F;
			this.StartSp.EndInit();
			// 
			// StopSp
			// 
			this.StopSp.BeginInit();
			this.StopSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 64D);
			this.StopSp.MaximumTag = null;
			this.StopSp.MinimumTag = null;
			this.StopSp.Name = "StopSp";
			this.StopSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StopSp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.StopSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StopSp.Suffix = "m";
			this.StopSp.TagName = "StopSp";
			this.StopSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.StopSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.StopSp.UseInputPad = true;
			this.StopSp.Value = 0F;
			this.StopSp.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 36D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Start Setpoint (m) :";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Stop Setpoint (m) :";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.CapacitySp,
			this.SwitchSpeedSp,
			this.drawnButton1,
			this.freeText3,
			this.StartSp,
			this.StopSp,
			this.freeText4,
			this.freeText5});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> CapacitySp;
		private System.HMI.Symbols.Base.TextBox<float> SwitchSpeedSp;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.TextBox<float> StartSp;
		private System.HMI.Symbols.Base.TextBox<float> StopSp;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		#endregion
	}
}
