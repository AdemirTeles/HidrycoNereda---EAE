/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA371406
 * Date: 06/08/2021
 * Time: 10:27 am
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ATV320
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			this.RESET_ERROR_ATV320 = new System.HMI.Symbols.Base.CheckButton();
			this.QUICK_STOP_ATV320 = new System.HMI.Symbols.Base.CheckButton();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.SPEED_VALUE_ATV320 = new System.HMI.Symbols.Base.TextBox<short>();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.ETA = new System.HMI.Symbols.Base.Label<ushort>();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.RFRD = new System.HMI.Symbols.Base.Label<ushort>();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.Run_Stop = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.Default_ATV320 = new System.HMI.Symbols.Base.Led<bool>();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			// 
			// RESET_ERROR_ATV320
			// 
			this.RESET_ERROR_ATV320.BeginInit();
			this.RESET_ERROR_ATV320.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 136D);
			this.RESET_ERROR_ATV320.FalseBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.RESET_ERROR_ATV320.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.RESET_ERROR_ATV320.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.RESET_ERROR_ATV320.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.RESET_ERROR_ATV320.FontScale = false;
			this.RESET_ERROR_ATV320.Name = "RESET_ERROR_ATV320";
			this.RESET_ERROR_ATV320.TagName = "RESET_ERROR_ATV320";
			this.RESET_ERROR_ATV320.TextDisabledColor = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.RESET_ERROR_ATV320.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.RESET_ERROR_ATV320.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.RESET_ERROR_ATV320.Value = false;
			this.RESET_ERROR_ATV320.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RESET_ERROR_ATV320ValueChanged);
			this.RESET_ERROR_ATV320.EndInit();
			// 
			// QUICK_STOP_ATV320
			// 
			this.QUICK_STOP_ATV320.BeginInit();
			this.QUICK_STOP_ATV320.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 176D);
			this.QUICK_STOP_ATV320.FalseBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.QUICK_STOP_ATV320.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.QUICK_STOP_ATV320.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.QUICK_STOP_ATV320.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.QUICK_STOP_ATV320.FontScale = false;
			this.QUICK_STOP_ATV320.Name = "QUICK_STOP_ATV320";
			this.QUICK_STOP_ATV320.TagName = "QUICK_STOP_ATV320";
			this.QUICK_STOP_ATV320.TextDisabledColor = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.QUICK_STOP_ATV320.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.QUICK_STOP_ATV320.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.QUICK_STOP_ATV320.Value = false;
			this.QUICK_STOP_ATV320.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(600D)), ((float)(224D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(112D, 144D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "RESET ERROR";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(112D, 184D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "QUICK STOP";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(112D, 222D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "SPEED REF VALUE (LFRD)";
			// 
			// SPEED_VALUE_ATV320
			// 
			this.SPEED_VALUE_ATV320.BeginInit();
			this.SPEED_VALUE_ATV320.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.SPEED_VALUE_ATV320.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333321D, 0D, 0D, 1D, 24D, 216D);
			this.SPEED_VALUE_ATV320.MaximumTag = null;
			this.SPEED_VALUE_ATV320.MinimumTag = null;
			this.SPEED_VALUE_ATV320.Name = "SPEED_VALUE_ATV320";
			this.SPEED_VALUE_ATV320.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SPEED_VALUE_ATV320.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.SPEED_VALUE_ATV320.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SPEED_VALUE_ATV320.TagName = "SPEED_REF_VALUE_ATV320";
			this.SPEED_VALUE_ATV320.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.SPEED_VALUE_ATV320.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SPEED_VALUE_ATV320.TextDisabledColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SPEED_VALUE_ATV320.Value = ((short)(0));
			this.SPEED_VALUE_ATV320.EndInit();
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.freeText4.Location = new NxtControl.Drawing.PointF(260D, 40D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "ATV320";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.freeText5.Location = new NxtControl.Drawing.PointF(120D, 80D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "CMD";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.freeText6.Location = new NxtControl.Drawing.PointF(406D, 80D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "STATE";
			// 
			// ETA
			// 
			this.ETA.BeginInit();
			this.ETA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ETA.DecimalPlacesCount = ((uint)(2u));
			this.ETA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1.2380952380952381D, 320D, 178D);
			this.ETA.FontScale = false;
			this.ETA.IsOnlyInput = true;
			this.ETA.LeadingZeros = ((uint)(0u));
			this.ETA.Name = "ETA";
			this.ETA.NumberBase = NxtControl.GuiFramework.NumberBase.Hexadecimal;
			this.ETA.PrefixTag = new NxtControl.GuiFramework.AuxHMIAccessor("ETA", this.ETA);
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)))));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.ETA.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.ETA.TagName = "ETA";
			this.ETA.EndInit();
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(416D, 184D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "STATE ATV320 (ETA)";
			// 
			// RFRD
			// 
			this.RFRD.BeginInit();
			this.RFRD.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.RFRD.DecimalPlacesCount = ((uint)(2u));
			this.RFRD.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1.2380952380952381D, 320D, 216D);
			this.RFRD.FontScale = false;
			this.RFRD.IsOnlyInput = true;
			this.RFRD.LeadingZeros = ((uint)(0u));
			this.RFRD.Name = "RFRD";
			this.RFRD.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)))));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.RFRD.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.RFRD.TagName = "RFRD";
			this.RFRD.EndInit();
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(416D, 222D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "ACTUAL SPEED VALUE (RFRD)";
			// 
			// Run_Stop
			// 
			this.Run_Stop.BeginInit();
			this.Run_Stop.ColorFrame = new NxtControl.Drawing.Color("SE.Nereda.LedFrameColor");
			this.Run_Stop.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.083333333333333D, 0D, 0D, 2.0833333333333335D, 412.5D, 140.5D);
			this.Run_Stop.FrameSize = 33F;
			this.Run_Stop.IsOnlyInput = true;
			this.Run_Stop.Name = "Run_Stop";
			propertyDictionary4.Add("Color", new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			propertyDictionary5.Add("Color", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.Run_Stop.Ranges.Clear();
			this.Run_Stop.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary4));
			this.Run_Stop.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary5));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.Run_Stop.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.Run_Stop.TagName = "Run_Stop";
			this.Run_Stop.EndInit();
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(320D, 133D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "RUN/STOP :";
			// 
			// Default_ATV320
			// 
			this.Default_ATV320.BeginInit();
			this.Default_ATV320.ColorFrame = new NxtControl.Drawing.Color("SE.Nereda.LedFrameColor");
			this.Default_ATV320.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.0833333333333335D, 0D, 0D, 2.083333333333333D, 588.5D, 140.5D);
			this.Default_ATV320.FrameSize = 33F;
			this.Default_ATV320.IsOnlyInput = true;
			this.Default_ATV320.Name = "Default_ATV320";
			propertyDictionary7.Add("Color", new NxtControl.Drawing.Color("SE.Nereda.LedFalseColor"));
			propertyDictionary8.Add("Color", new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.Default_ATV320.Ranges.Clear();
			this.Default_ATV320.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary7));
			this.Default_ATV320.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary8));
			propertyDictionary6.Add("Color", new NxtControl.Drawing.Color("SE.Nereda.LedFalseColor"));
			this.Default_ATV320.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.Default_ATV320.TagName = "Default_ATV320";
			this.Default_ATV320.EndInit();
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(464D, 133D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "ERROR_ATV320 :";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(296D, 72D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(296D, 256D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(616D, 72D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(16D, 72D);
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.RESET_ERROR_ATV320,
			this.QUICK_STOP_ATV320,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.SPEED_VALUE_ATV320,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.ETA,
			this.freeText7,
			this.RFRD,
			this.freeText8,
			this.Run_Stop,
			this.freeText9,
			this.Default_ATV320,
			this.freeText10,
			this.line1,
			this.line2});
			this.SymbolSize = new System.Drawing.Size(632, 400);

		}
		private System.HMI.Symbols.Base.CheckButton RESET_ERROR_ATV320;
		private System.HMI.Symbols.Base.CheckButton QUICK_STOP_ATV320;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.TextBox<short> SPEED_VALUE_ATV320;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private System.HMI.Symbols.Base.Label<ushort> ETA;
		private NxtControl.GuiFramework.FreeText freeText7;
		private System.HMI.Symbols.Base.Label<ushort> RFRD;
		private NxtControl.GuiFramework.FreeText freeText8;
		private System.HMI.Symbols.Base.Led<bool> Run_Stop;
		private NxtControl.GuiFramework.FreeText freeText9;
		private System.HMI.Symbols.Base.Led<bool> Default_ATV320;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		#endregion
	}
}
