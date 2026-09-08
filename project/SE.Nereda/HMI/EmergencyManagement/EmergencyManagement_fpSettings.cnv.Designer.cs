/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/5/2026
 * Time: 2:01 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EmergencyManagement
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
			this.CT_Nominal = new System.HMI.Symbols.Base.TimeTextBox();
			this.StartUpDelay = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.drawnButton2 = new NxtControl.GuiFramework.DrawnButton();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.ForceAvaibility = new SE.Nereda.Symbols.ReactorAvCtrl.sDefault();
			this.NextFeedHorizon = new SE.Nereda.Symbols.NextFeedHorizon.sDefault();
			this.NextFeedHorizon_1 = new SE.Nereda.Symbols.NextFeedHorizon.sNFHR1();
			this.NextFeedHorizon_2 = new SE.Nereda.Symbols.NextFeedHorizon.sNFHR2();
			this.NextFeedHorizon_3 = new SE.Nereda.Symbols.NextFeedHorizon.sNFHR3();
			this.group1 = new NxtControl.GuiFramework.Group();
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
			this.polygon1.Text = "EMERGENCY MANAGEMENT";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(128D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 37D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Nominal Cycle Time (CT_Nominal) :";
			// 
			// CT_Nominal
			// 
			this.CT_Nominal.BeginInit();
			this.CT_Nominal.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 256D, 32D);
			this.CT_Nominal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.CT_Nominal.MaximumTag = null;
			this.CT_Nominal.MinimumTag = null;
			this.CT_Nominal.Name = "CT_Nominal";
			this.CT_Nominal.TagName = "CT_Nominal";
			this.CT_Nominal.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CT_Nominal.UseInputPad = true;
			this.CT_Nominal.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.CT_Nominal.EndInit();
			// 
			// StartUpDelay
			// 
			this.StartUpDelay.BeginInit();
			this.StartUpDelay.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 256D, 72D);
			this.StartUpDelay.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.StartUpDelay.MaximumTag = null;
			this.StartUpDelay.MinimumTag = null;
			this.StartUpDelay.Name = "StartUpDelay";
			this.StartUpDelay.TagName = "StartUpDelay";
			this.StartUpDelay.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.StartUpDelay.UseInputPad = true;
			this.StartUpDelay.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.StartUpDelay.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 77D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Emergency Start Up Delay :";
			// 
			// drawnButton2
			// 
			this.drawnButton2.Bounds = new NxtControl.Drawing.RectF(((float)(256D)), ((float)(112D)), ((float)(96D)), ((float)(25D)));
			this.drawnButton2.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton2.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton2.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton2.Name = "drawnButton2";
			this.drawnButton2.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpEquations", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton2.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton2.Radius = 4D;
			this.drawnButton2.Text = "Equations";
			this.drawnButton2.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton2.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton2.Use3DEffect = false;
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 116D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Emergency Management Equations :";
			// 
			// ForceAvaibility
			// 
			this.ForceAvaibility.BeginInit();
			this.ForceAvaibility.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 160D);
			this.ForceAvaibility.Name = "ForceAvaibility";
			this.ForceAvaibility.SecurityToken = ((uint)(4294967295u));
			this.ForceAvaibility.TagName = "ForceAvaibility";
			this.ForceAvaibility.EndInit();
			// 
			// NextFeedHorizon
			// 
			this.NextFeedHorizon.BeginInit();
			this.NextFeedHorizon.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 288D);
			this.NextFeedHorizon.Name = "NextFeedHorizon";
			this.NextFeedHorizon.SecurityToken = ((uint)(4294967295u));
			this.NextFeedHorizon.TagName = "NextFeedHorizon";
			this.NextFeedHorizon.EndInit();
			// 
			// NextFeedHorizon_1
			// 
			this.NextFeedHorizon_1.BeginInit();
			this.NextFeedHorizon_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 312D);
			this.NextFeedHorizon_1.Name = "NextFeedHorizon_1";
			this.NextFeedHorizon_1.SecurityToken = ((uint)(4294967295u));
			this.NextFeedHorizon_1.TagName = "NextFeedHorizon";
			this.NextFeedHorizon_1.EndInit();
			// 
			// NextFeedHorizon_2
			// 
			this.NextFeedHorizon_2.BeginInit();
			this.NextFeedHorizon_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 344D);
			this.NextFeedHorizon_2.Name = "NextFeedHorizon_2";
			this.NextFeedHorizon_2.SecurityToken = ((uint)(4294967295u));
			this.NextFeedHorizon_2.TagName = "NextFeedHorizon";
			this.NextFeedHorizon_2.EndInit();
			// 
			// NextFeedHorizon_3
			// 
			this.NextFeedHorizon_3.BeginInit();
			this.NextFeedHorizon_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 376D);
			this.NextFeedHorizon_3.Name = "NextFeedHorizon_3";
			this.NextFeedHorizon_3.SecurityToken = ((uint)(4294967295u));
			this.NextFeedHorizon_3.TagName = "NextFeedHorizon";
			this.NextFeedHorizon_3.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ForceAvaibility,
			this.NextFeedHorizon,
			this.NextFeedHorizon_1,
			this.NextFeedHorizon_2,
			this.NextFeedHorizon_3});
			this.group1.EndInit();
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(376D)), ((float)(416D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.CT_Nominal,
			this.StartUpDelay,
			this.freeText2,
			this.drawnButton2,
			this.freeText4,
			this.group1});
			this.Size = new System.Drawing.Size(376, 416);
			this.Title = "Emergency Management Settings";

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TimeTextBox CT_Nominal;
		private System.HMI.Symbols.Base.TimeTextBox StartUpDelay;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.DrawnButton drawnButton2;
		private NxtControl.GuiFramework.FreeText freeText4;
		private SE.Nereda.Symbols.ReactorAvCtrl.sDefault ForceAvaibility;
		private SE.Nereda.Symbols.NextFeedHorizon.sDefault NextFeedHorizon;
		private SE.Nereda.Symbols.NextFeedHorizon.sNFHR1 NextFeedHorizon_1;
		private SE.Nereda.Symbols.NextFeedHorizon.sNFHR2 NextFeedHorizon_2;
		private SE.Nereda.Symbols.NextFeedHorizon.sNFHR3 NextFeedHorizon_3;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
