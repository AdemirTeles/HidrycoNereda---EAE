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
	partial class sDisplayPv1
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
			this.Background = new NxtControl.GuiFramework.RoundedRectangle();
			this.SensorName = new NxtControl.GuiFramework.FreeText();
			this.alarmSAFrame1 = new NxtControl.GuiFramework.AlarmFrame();
			this.group1 = new NxtControl.GuiFramework.Group();
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).BeginInit();
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(248D)), ((float)(24D)));
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
			this.Unit.Location = new NxtControl.Drawing.PointF(216D, 12D);
			this.Unit.Name = "Unit";
			this.Unit.Text = "%";
			// 
			// PvBackGround
			// 
			this.PvBackGround.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(8D)), ((float)(96D)), ((float)(24D)));
			this.PvBackGround.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.PvBackGround.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.PvBackGround.Name = "PvBackGround";
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DecimalPlacesCount = ((uint)(2u));
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 160D, 12D);
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
			// Background
			// 
			this.Background.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(168D)), ((float)(24D)));
			this.Background.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))));
			this.Background.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Background.Name = "Background";
			this.Background.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SensorName
			// 
			this.SensorName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SensorName.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.SensorName.Location = new NxtControl.Drawing.PointF(16D, 12D);
			this.SensorName.Name = "SensorName";
			this.SensorName.Text = "Name";
			// 
			// alarmSAFrame1
			// 
			this.alarmSAFrame1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(248D)), ((float)(24D)));
			this.alarmSAFrame1.FrameWidth = ((uint)(2u));
			this.alarmSAFrame1.Name = "alarmSAFrame1";
			this.alarmSAFrame1.Radius = 5D;
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Background,
			this.PvBackGround,
			this.Unit,
			this.Pv,
			this.SensorName});
			this.group1.EndInit();
			// 
			// sDisplayPv1
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.alarmSAFrame1,
			this.OpenFp});
			this.SymbolSize = new System.Drawing.Size(272, 48);
			((System.ComponentModel.ISupportInitialize)(this.alarmSAFrame1)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle OpenFp;
		private NxtControl.GuiFramework.FreeText Unit;
		private NxtControl.GuiFramework.RoundedRectangle PvBackGround;
		private System.HMI.Symbols.Base.FreeText<float> Pv;
		private NxtControl.GuiFramework.RoundedRectangle Background;
		private NxtControl.GuiFramework.FreeText SensorName;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.AlarmFrame alarmSAFrame1;
		#endregion
	}
}
