/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/6/2026
 * Time: 3:09 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizon
{
	/// <summary>
	/// Summary description for sCalc.
	/// </summary>
	partial class sCalc
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sCalc));
			this.NextFeedHorizonR1 = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.StartFeedInterval = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.FallbackElapsedTime = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.i_R1 = new System.HMI.Symbols.Base.TextBox<short>();
			this.StartFeedInterval_1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.SettleTimeR1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			// 
			// NextFeedHorizonR1
			// 
			this.NextFeedHorizonR1.BeginInit();
			this.NextFeedHorizonR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 16D, 56D);
			this.NextFeedHorizonR1.IsOnlyInput = true;
			this.NextFeedHorizonR1.MaximumTag = null;
			this.NextFeedHorizonR1.MinimumTag = null;
			this.NextFeedHorizonR1.Name = "NextFeedHorizonR1";
			this.NextFeedHorizonR1.TagName = "NextFeedHorizonR1";
			this.NextFeedHorizonR1.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.NextFeedHorizonR1.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(104D, 64D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "=";
			// 
			// StartFeedInterval
			// 
			this.StartFeedInterval.BeginInit();
			this.StartFeedInterval.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 120D, 56D);
			this.StartFeedInterval.IsOnlyInput = true;
			this.StartFeedInterval.MaximumTag = null;
			this.StartFeedInterval.MinimumTag = null;
			this.StartFeedInterval.Name = "StartFeedInterval";
			this.StartFeedInterval.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StartFeedInterval.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.StartFeedInterval.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StartFeedInterval.TagName = "StartFeedInterval";
			this.StartFeedInterval.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.StartFeedInterval.Value = 0F;
			this.StartFeedInterval.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(208D, 64D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "-";
			// 
			// FallbackElapsedTime
			// 
			this.FallbackElapsedTime.BeginInit();
			this.FallbackElapsedTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 224D, 56D);
			this.FallbackElapsedTime.IsOnlyInput = true;
			this.FallbackElapsedTime.MaximumTag = null;
			this.FallbackElapsedTime.MinimumTag = null;
			this.FallbackElapsedTime.Name = "FallbackElapsedTime";
			this.FallbackElapsedTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.FallbackElapsedTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.FallbackElapsedTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.FallbackElapsedTime.TagName = "FallbackElapsedTime";
			this.FallbackElapsedTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.FallbackElapsedTime.Value = 0F;
			this.FallbackElapsedTime.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(312D, 64D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "+";
			// 
			// i_R1
			// 
			this.i_R1.BeginInit();
			this.i_R1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 328D, 56D);
			this.i_R1.IsOnlyInput = true;
			this.i_R1.MaximumTag = null;
			this.i_R1.MinimumTag = null;
			this.i_R1.Name = "i_R1";
			this.i_R1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.i_R1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.i_R1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.i_R1.TagName = "i_R1";
			this.i_R1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.i_R1.Value = ((short)(0));
			this.i_R1.EndInit();
			// 
			// StartFeedInterval_1
			// 
			this.StartFeedInterval_1.BeginInit();
			this.StartFeedInterval_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 432D, 56D);
			this.StartFeedInterval_1.IsOnlyInput = true;
			this.StartFeedInterval_1.MaximumTag = null;
			this.StartFeedInterval_1.MinimumTag = null;
			this.StartFeedInterval_1.Name = "StartFeedInterval_1";
			this.StartFeedInterval_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StartFeedInterval_1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.StartFeedInterval_1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StartFeedInterval_1.TagName = "StartFeedInterval";
			this.StartFeedInterval_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.StartFeedInterval_1.Value = 0F;
			this.StartFeedInterval_1.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(416D, 64D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "x";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(520D, 64D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "+";
			// 
			// SettleTimeR1
			// 
			this.SettleTimeR1.BeginInit();
			this.SettleTimeR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 1D, 536D, 56D);
			this.SettleTimeR1.IsOnlyInput = true;
			this.SettleTimeR1.MaximumTag = null;
			this.SettleTimeR1.MinimumTag = null;
			this.SettleTimeR1.Name = "SettleTimeR1";
			this.SettleTimeR1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SettleTimeR1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.SettleTimeR1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SettleTimeR1.TagName = "SettleTimeR1";
			this.SettleTimeR1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SettleTimeR1.Value = 0F;
			this.SettleTimeR1.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(24D)), ((float)(600D)), ((float)(16D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.ImageBytes = resources.GetString("rectangle1.ImageBytes");
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(40D)), ((float)(600D)), ((float)(16D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "Reactor 1";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sCalc
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.rectangle1,
			this.rectangle2,
			this.NextFeedHorizonR1,
			this.StartFeedInterval,
			this.FallbackElapsedTime,
			this.i_R1,
			this.StartFeedInterval_1,
			this.SettleTimeR1});
			this.SymbolSize = new System.Drawing.Size(664, 496);

		}
		private System.HMI.Symbols.Base.TimeTextBox NextFeedHorizonR1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> StartFeedInterval;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> FallbackElapsedTime;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.TextBox<short> i_R1;
		private System.HMI.Symbols.Base.TextBox<float> StartFeedInterval_1;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private System.HMI.Symbols.Base.TextBox<float> SettleTimeR1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		#endregion
	}
}
