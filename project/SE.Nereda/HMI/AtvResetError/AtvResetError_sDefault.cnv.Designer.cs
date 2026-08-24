/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/19/2024
 * Time: 3:34 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AtvResetError
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.ResetHMI = new System.HMI.Symbols.Base.CheckButton();
			this.NeedReset = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<bool>();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.Name_Object = new NxtControl.GuiFramework.FreeText();
			this.ETA = new System.HMI.Symbols.Base.TextBox<ushort>();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(240D)), ((float)(136D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// ResetHMI
			// 
			this.ResetHMI.BeginInit();
			this.ResetHMI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2D, 0D, 0D, 1.0666666666666667D, 80D, 112D);
			this.ResetHMI.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ResetHMI.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ResetHMI.FalseText = "Reset Error";
			this.ResetHMI.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ResetHMI.FontScale = false;
			this.ResetHMI.Name = "ResetHMI";
			this.ResetHMI.TagName = "ResetHMI";
			this.ResetHMI.TrueBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.LedTrueColor"));
			this.ResetHMI.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ResetHMI.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ResetHMI.TrueText = "Reset Error";
			this.ResetHMI.Value = false;
			this.ResetHMI.EndInit();
			// 
			// NeedReset
			// 
			this.NeedReset.BeginInit();
			this.NeedReset.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.NeedReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2500000000000002D, 0D, 0D, 1.2500000000000002D, 199.5D, 95.5D);
			this.NeedReset.FrameSize = 33F;
			this.NeedReset.IsOnlyInput = true;
			this.NeedReset.Name = "NeedReset";
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("DevAnalogOut"));
			this.NeedReset.Ranges.Clear();
			this.NeedReset.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.NeedReset.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.NeedReset.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.NeedReset.TagName = "NeedReset";
			this.NeedReset.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 60D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "ATV STATE (ETA) :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 88D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "NEED RESET ERROR :";
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.IsOnlyInput = true;
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "NeedReset";
			this.execute_11.Value = false;
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Execute_11ValueChanged);
			this.execute_11.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(8D, 48D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(248D, 48D);
			// 
			// Name_Object
			// 
			this.Name_Object.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Name_Object.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Name_Object.Location = new NxtControl.Drawing.PointF(16D, 24D);
			this.Name_Object.Name = "Name_Object";
			this.Name_Object.Text = "OBJECT_NAME";
			// 
			// ETA
			// 
			this.ETA.BeginInit();
			this.ETA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.ETA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.46666666666666667D, 0D, 0D, 1D, 168D, 56D);
			this.ETA.IsOnlyInput = true;
			this.ETA.MaximumTag = null;
			this.ETA.MinimumTag = null;
			this.ETA.Name = "ETA";
			this.ETA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.ETA.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.ETA.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.ETA.TagName = "ETA";
			this.ETA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.ETA.Value = ((ushort)(0));
			this.ETA.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.ResetHMI,
			this.NeedReset,
			this.freeText1,
			this.freeText2,
			this.execute_11,
			this.line1,
			this.Name_Object,
			this.ETA});
			this.SymbolSize = new System.Drawing.Size(304, 200);

		}
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private System.HMI.Symbols.Base.CheckButton ResetHMI;
		private System.HMI.Symbols.Base.Led<bool> NeedReset;
		private System.HMI.Symbols.Base.TextBox<System.UInt16> ETA;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Execute<bool> execute_11;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText Name_Object;
		#endregion
	}
}
