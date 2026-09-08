/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 3:20 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.AnalogInput
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDisplayPv4
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.OpenFp = new NxtControl.GuiFramework.Rectangle();
			this.Unit = new NxtControl.GuiFramework.FreeText();
			this.PvBackGround = new NxtControl.GuiFramework.RoundedRectangle();
			this.Pv = new System.HMI.Symbols.Base.FreeText<float>();
			this.alarmSAFrame1 = new NxtControl.GuiFramework.AlarmFrame();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.iUnit = new System.HMI.Symbols.Base.Execute<string>();
			this.IOChannelFail = new NxtControl.GuiFramework.Ellipse();
			this.ChFail = new System.HMI.Symbols.Base.Execute<bool>();
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).BeginInit();
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(8D)), ((float)(64D)), ((float)(32D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// Unit
			// 
			this.Unit.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Unit.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Unit.Location = new NxtControl.Drawing.PointF(48D, 24D);
			this.Unit.Name = "Unit";
			this.Unit.Text = "%";
			// 
			// PvBackGround
			// 
			this.PvBackGround.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(8D)), ((float)(64D)), ((float)(32D)));
			this.PvBackGround.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.PvBackGround.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.PvBackGround.Name = "PvBackGround";
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DecimalPlacesCount = ((uint)(2u));
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 8D);
			this.Pv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.Pv.IsOnlyInput = true;
			this.Pv.Name = "Pv";
			this.Pv.Ranges.Clear();
			this.Pv.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Pv.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.Pv.TagName = "Pv";
			this.Pv.TextAngle = 0F;
			this.Pv.EndInit();
			// 
			// alarmSAFrame1
			// 
			this.alarmSAFrame1.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(8D)), ((float)(64D)), ((float)(32D)));
			this.alarmSAFrame1.FrameWidth = ((uint)(2u));
			this.alarmSAFrame1.Name = "alarmSAFrame1";
			this.alarmSAFrame1.Radius = 5D;
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(96D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 24D),
			new NxtControl.Drawing.PointF(104D, 24D)});
			this.pipe1.Width = 10;
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe1,
			this.PvBackGround,
			this.Unit,
			this.Pv,
			this.alarmSAFrame1,
			this.OpenFp});
			this.group1.EndInit();
			// 
			// iUnit
			// 
			this.iUnit.BeginInit();
			this.iUnit.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 242D, 246D);
			this.iUnit.IsOnlyInput = true;
			this.iUnit.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.iUnit.Name = "iUnit";
			this.iUnit.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.iUnit.TagName = "iUnit";
			this.iUnit.Value = null;
			this.iUnit.EndInit();
			// 
			// IOChannelFail
			// 
			this.IOChannelFail.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(32D)), ((float)(12D)), ((float)(12D)));
			this.IOChannelFail.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.IOChannelFail.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular);
			this.IOChannelFail.Name = "IOChannelFail";
			this.IOChannelFail.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.IOChannelFail.Text = "!";
			this.IOChannelFail.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ChFail
			// 
			this.ChFail.BeginInit();
			this.ChFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 92D, 106D);
			this.ChFail.IsOnlyInput = true;
			this.ChFail.Location = new NxtControl.Drawing.PointF(92D, 106D);
			this.ChFail.Name = "ChFail";
			this.ChFail.Size = new NxtControl.Drawing.SizeF(100D, 20D);
			this.ChFail.TagName = "ChFail";
			this.ChFail.Value = false;
			this.ChFail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ChFailValueChanged);
			this.ChFail.EndInit();
			// 
			// sDisplayPv4
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.iUnit,
			this.IOChannelFail,
			this.ChFail});
			this.SymbolSize = new System.Drawing.Size(272, 176);
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.FreeText Unit;
		private NxtControl.GuiFramework.RoundedRectangle PvBackGround;
		private System.HMI.Symbols.Base.FreeText<float> Pv;
		private NxtControl.GuiFramework.AlarmFrame alarmSAFrame1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Group group1;
		private System.HMI.Symbols.Base.Execute<string> iUnit;
		private NxtControl.GuiFramework.Ellipse IOChannelFail;
		private System.HMI.Symbols.Base.Execute<bool> ChFail;
		#endregion
	}
}
