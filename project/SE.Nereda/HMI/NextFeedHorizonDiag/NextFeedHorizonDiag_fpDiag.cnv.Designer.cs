/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/6/2026
 * Time: 3:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.NextFeedHorizonDiag
{
	/// <summary>
	/// Summary description for fpDiag.
	/// </summary>
	partial class fpDiag
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fpDiag));
			this.CalcResult = new NxtControl.GuiFramework.FreeText();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.CorrectResult = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.Record = new System.HMI.Symbols.Base.CheckButton();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.i = new System.HMI.Symbols.Base.FreeText<int>();
			this.UpBtn = new NxtControl.GuiFramework.DrawnButton();
			this.DownBtn = new NxtControl.GuiFramework.DrawnButton();
			this.Supress = new System.HMI.Symbols.Base.CheckButton();
			this.Calc = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			// 
			// CalcResult
			// 
			this.CalcResult.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CalcResult.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.CalcResult.Location = new NxtControl.Drawing.PointF(128D, 16D);
			this.CalcResult.Name = "CalcResult";
			this.CalcResult.Text = "Diagnostic Calculation Equation";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(544D)), ((float)(32D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// CorrectResult
			// 
			this.CorrectResult.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(112D)), ((float)(32D)));
			this.CorrectResult.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.CorrectResult.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.CorrectResult.Name = "CorrectResult";
			this.CorrectResult.Text = "00.00";
			this.CorrectResult.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(40D)), ((float)(544D)), ((float)(72D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(238)), ((byte)(210))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// Record
			// 
			this.Record.BeginInit();
			this.Record.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 72D);
			this.Record.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Record.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Record.FalseText = "Record";
			this.Record.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Record.FontScale = false;
			this.Record.Name = "Record";
			this.Record.TagName = "Record";
			this.Record.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Record.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Record.TrueText = "Record";
			this.Record.Value = false;
			this.Record.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(32D, 48D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Record";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(120D, 112D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(120D, 40D);
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(266D, 48D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Up";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(350D, 48D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Down";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(176D, 112D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(176D, 40D);
			// 
			// i
			// 
			this.i.BeginInit();
			this.i.DecimalPlacesCount = ((uint)(2u));
			this.i.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 130D, 66D);
			this.i.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.i.IsOnlyInput = true;
			this.i.Name = "i";
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.i.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.i.TagName = "i";
			this.i.TextAngle = 0F;
			this.i.EndInit();
			// 
			// UpBtn
			// 
			this.UpBtn.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(72D)), ((float)(80D)), ((float)(30D)));
			this.UpBtn.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.UpBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.UpBtn.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.UpBtn.Name = "UpBtn";
			this.UpBtn.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.UpBtn.Radius = 4D;
			this.UpBtn.Text = "Button";
			this.UpBtn.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.UpBtn.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.UpBtn.Use3DEffect = false;
			this.UpBtn.Click += new System.EventHandler(this.UpBtnClick);
			// 
			// DownBtn
			// 
			this.DownBtn.Bounds = new NxtControl.Drawing.RectF(((float)(336D)), ((float)(72D)), ((float)(80D)), ((float)(30D)));
			this.DownBtn.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.DownBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.DownBtn.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.DownBtn.Name = "DownBtn";
			this.DownBtn.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.DownBtn.Radius = 4D;
			this.DownBtn.Text = "Button";
			this.DownBtn.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.DownBtn.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.DownBtn.Use3DEffect = false;
			this.DownBtn.Click += new System.EventHandler(this.DownBtnClick);
			// 
			// Supress
			// 
			this.Supress.BeginInit();
			this.Supress.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 456D, 72D);
			this.Supress.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Supress.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Supress.FalseText = "Clean DB";
			this.Supress.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Supress.FontScale = false;
			this.Supress.Name = "Supress";
			this.Supress.TagName = "Supress";
			this.Supress.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Supress.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Supress.TrueText = "Clean DB";
			this.Supress.Value = false;
			this.Supress.EndInit();
			// 
			// Calc
			// 
			this.Calc.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Calc.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.Calc.Location = new NxtControl.Drawing.PointF(16D, 152D);
			this.Calc.Name = "Calc";
			this.Calc.Text = "Equation";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 120D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Current Calculation :";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(144D)), ((float)(544D)), ((float)(32D)));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(184D)), ((float)(544D)), ((float)(40D)));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.ImageBytes = resources.GetString("rectangle5.ImageBytes");
			this.rectangle5.Name = "rectangle5";
			// 
			// fpDiag
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(560D)), ((float)(232D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle4,
			this.rectangle1,
			this.CalcResult,
			this.CorrectResult,
			this.rectangle2,
			this.Record,
			this.freeText1,
			this.line1,
			this.freeText2,
			this.freeText3,
			this.line2,
			this.i,
			this.UpBtn,
			this.DownBtn,
			this.Supress,
			this.Calc,
			this.freeText4,
			this.rectangle5});
			this.Size = new System.Drawing.Size(560, 232);
			this.Title = "Next Feed Horizon Diagnostic";

		}
		private NxtControl.GuiFramework.FreeText CalcResult;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle CorrectResult;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private System.HMI.Symbols.Base.CheckButton Record;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Line line2;
		private System.HMI.Symbols.Base.FreeText<int> i;
		private NxtControl.GuiFramework.DrawnButton UpBtn;
		private NxtControl.GuiFramework.DrawnButton DownBtn;
		private System.HMI.Symbols.Base.CheckButton Supress;
		private NxtControl.GuiFramework.FreeText Calc;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		#endregion
	}
}
