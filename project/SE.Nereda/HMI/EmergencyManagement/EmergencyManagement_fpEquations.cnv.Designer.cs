/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/5/2026
 * Time: 5:48 PM
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
	/// Summary description for fpEquations.
	/// </summary>
	partial class fpEquations
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
			this.CT_ReactorActual = new System.HMI.Symbols.Base.TimeTextBox();
			this.NbrAvailableReactors = new System.HMI.Symbols.Base.TextBox<short>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.NbrTotalReactors = new System.HMI.Symbols.Base.TextBox<short>();
			this.iCT_Nominal = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.StartInterval = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.NbrAvailableReactors_1 = new System.HMI.Symbols.Base.TextBox<short>();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.CT_ReactorActual_1 = new System.HMI.Symbols.Base.TimeTextBox();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(592D)), ((float)(72D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(24D, 16D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "CT Reactor Actual   =   (Nbr Available Reactors   /   Nbr Total Reactors)   *   C" +
	"T Nominal";
			// 
			// CT_ReactorActual
			// 
			this.CT_ReactorActual.BeginInit();
			this.CT_ReactorActual.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 24D, 40D);
			this.CT_ReactorActual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.CT_ReactorActual.IsOnlyInput = true;
			this.CT_ReactorActual.MaximumTag = null;
			this.CT_ReactorActual.MinimumTag = null;
			this.CT_ReactorActual.Name = "CT_ReactorActual";
			this.CT_ReactorActual.TagName = "CT_ReactorActual";
			this.CT_ReactorActual.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.CT_ReactorActual.EndInit();
			// 
			// NbrAvailableReactors
			// 
			this.NbrAvailableReactors.BeginInit();
			this.NbrAvailableReactors.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.96D, 0D, 0D, 1D, 176D, 40D);
			this.NbrAvailableReactors.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NbrAvailableReactors.IsOnlyInput = true;
			this.NbrAvailableReactors.MaximumTag = null;
			this.NbrAvailableReactors.MinimumTag = null;
			this.NbrAvailableReactors.Name = "NbrAvailableReactors";
			this.NbrAvailableReactors.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.NbrAvailableReactors.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.NbrAvailableReactors.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.NbrAvailableReactors.TagName = "NbrAvailableReactors";
			this.NbrAvailableReactors.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.NbrAvailableReactors.Value = ((short)(0));
			this.NbrAvailableReactors.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(154D, 45D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "=";
			// 
			// NbrTotalReactors
			// 
			this.NbrTotalReactors.BeginInit();
			this.NbrTotalReactors.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 352D, 40D);
			this.NbrTotalReactors.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NbrTotalReactors.IsOnlyInput = true;
			this.NbrTotalReactors.MaximumTag = null;
			this.NbrTotalReactors.MinimumTag = null;
			this.NbrTotalReactors.Name = "NbrTotalReactors";
			this.NbrTotalReactors.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.NbrTotalReactors.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.NbrTotalReactors.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.NbrTotalReactors.TagName = "NbrTotalReactors";
			this.NbrTotalReactors.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.NbrTotalReactors.Value = ((short)(0));
			this.NbrTotalReactors.EndInit();
			// 
			// iCT_Nominal
			// 
			this.iCT_Nominal.BeginInit();
			this.iCT_Nominal.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.52D, 0D, 0D, 1D, 504D, 40D);
			this.iCT_Nominal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iCT_Nominal.IsOnlyInput = true;
			this.iCT_Nominal.MaximumTag = null;
			this.iCT_Nominal.MinimumTag = null;
			this.iCT_Nominal.Name = "iCT_Nominal";
			this.iCT_Nominal.TagName = "iCT_Nominal";
			this.iCT_Nominal.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.iCT_Nominal.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(332D, 44D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "/";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(482D, 44D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "x";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(88D)), ((float)(592D)), ((float)(72D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(24D, 96D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Start Interval   =   CT Reactor Actual   /   Nbr Available Reactors";
			// 
			// StartInterval
			// 
			this.StartInterval.BeginInit();
			this.StartInterval.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 24D, 120D);
			this.StartInterval.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.StartInterval.IsOnlyInput = true;
			this.StartInterval.MaximumTag = null;
			this.StartInterval.MinimumTag = null;
			this.StartInterval.Name = "StartInterval";
			this.StartInterval.TagName = "FeedInterval";
			this.StartInterval.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.StartInterval.EndInit();
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(114D, 125D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "=";
			// 
			// NbrAvailableReactors_1
			// 
			this.NbrAvailableReactors_1.BeginInit();
			this.NbrAvailableReactors_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.90666666666666673D, 0D, 0D, 1D, 288D, 120D);
			this.NbrAvailableReactors_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.NbrAvailableReactors_1.IsOnlyInput = true;
			this.NbrAvailableReactors_1.MaximumTag = null;
			this.NbrAvailableReactors_1.MinimumTag = null;
			this.NbrAvailableReactors_1.Name = "NbrAvailableReactors_1";
			this.NbrAvailableReactors_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.NbrAvailableReactors_1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.NbrAvailableReactors_1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.NbrAvailableReactors_1.TagName = "NbrAvailableReactors";
			this.NbrAvailableReactors_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.NbrAvailableReactors_1.Value = ((short)(0));
			this.NbrAvailableReactors_1.EndInit();
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(268D, 124D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "/";
			// 
			// CT_ReactorActual_1
			// 
			this.CT_ReactorActual_1.BeginInit();
			this.CT_ReactorActual_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 136D, 120D);
			this.CT_ReactorActual_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.CT_ReactorActual_1.IsOnlyInput = true;
			this.CT_ReactorActual_1.MaximumTag = null;
			this.CT_ReactorActual_1.MinimumTag = null;
			this.CT_ReactorActual_1.Name = "CT_ReactorActual_1";
			this.CT_ReactorActual_1.TagName = "CT_ReactorActual";
			this.CT_ReactorActual_1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.CT_ReactorActual_1.EndInit();
			// 
			// fpEquations
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(608D)), ((float)(168D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.rectangle3,
			this.freeText1,
			this.CT_ReactorActual,
			this.NbrAvailableReactors,
			this.freeText2,
			this.NbrTotalReactors,
			this.iCT_Nominal,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.StartInterval,
			this.freeText6,
			this.NbrAvailableReactors_1,
			this.freeText7,
			this.CT_ReactorActual_1});
			this.Size = new System.Drawing.Size(608, 168);
			this.Title = "Emergency Management Equations";

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TimeTextBox CT_ReactorActual;
		private System.HMI.Symbols.Base.TextBox<short> NbrAvailableReactors;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<short> NbrTotalReactors;
		private System.HMI.Symbols.Base.TimeTextBox iCT_Nominal;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.TimeTextBox StartInterval;
		private System.HMI.Symbols.Base.TimeTextBox CT_ReactorActual_1;
		private NxtControl.GuiFramework.FreeText freeText6;
		private System.HMI.Symbols.Base.TextBox<short> NbrAvailableReactors_1;
		private NxtControl.GuiFramework.FreeText freeText7;
		#endregion
	}
}
