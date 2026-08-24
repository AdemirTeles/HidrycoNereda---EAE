/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA197029
 * Date: 25/02/2022
 * Time: 3:53 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.HeartBeat
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
			this.label2 = new NxtControl.GuiFramework.Label();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.Check_Period = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.Time>();
			this.Watchdog = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.Time>();
			// 
			// label2
			// 
			this.label2.AngleIgnore = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label2.Bounds = new NxtControl.Drawing.RectF(((float)(185D)), ((float)(135D)), ((float)(158D)), ((float)(42D)));
			this.label2.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.label2.FontScale = true;
			this.label2.Name = "label2";
			this.label2.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label2.Text = "Nereda Controller Communication Status";
			this.label2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label2.TextAutoSizeHorizontalOffset = 10;
			this.label2.TextColor = new NxtControl.Drawing.BlinkColor("DevError");
			this.label2.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(186D)), ((float)(132D)), ((float)(192D)), ((float)(40D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Dash);
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(344D)), ((float)(139.72727966308594D)), ((float)(30D)), ((float)(27.272727966308594D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.ImageName = "SE.App2Base.HMI:modeIcons.settings2";
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("WatchdogConfiguration", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("SE.Nereda.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("SE.Nereda.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// Check_Period
			// 
			this.Check_Period.BeginInit();
			this.Check_Period.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Check_Period.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Check_Period.Name = "Check_Period";
			this.Check_Period.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Check_Period.TagName = "Check_Period";
			this.Check_Period.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.Check_Period.EndInit();
			// 
			// Watchdog
			// 
			this.Watchdog.BeginInit();
			this.Watchdog.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Watchdog.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Watchdog.Name = "Watchdog";
			this.Watchdog.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Watchdog.TagName = "Watchdog";
			this.Watchdog.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.Watchdog.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.label2,
			this.roundedRectangle1,
			this.drawnButton1,
			this.Check_Period,
			this.Watchdog});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Label label2;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.Time> Check_Period;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.Time> Watchdog;
		#endregion
	}
}
