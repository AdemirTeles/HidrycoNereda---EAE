/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 10/21/2026
 * Time: 11:57 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyInit2
{
	/// <summary>
	/// Summary description for sInitStatus.
	/// </summary>
	partial class sInitStatus
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.EmerInitStatus = new NxtControl.GuiFramework.Rectangle();
			this.EnoughTime = new System.HMI.Symbols.Base.Execute<bool>();
			this.InitCmd = new System.HMI.Symbols.Base.Execute<bool>();
			this.InitDone = new System.HMI.Symbols.Base.Execute<bool>();
			this.EmergencyON = new System.HMI.Symbols.Base.Execute<bool>();
			this.InitStatus_1 = new System.HMI.Symbols.Base.FreeText<short>();
			// 
			// EmerInitStatus
			// 
			this.EmerInitStatus.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(224D)), ((float)(26D)));
			this.EmerInitStatus.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(237)), ((byte)(230)), ((byte)(246))));
			this.EmerInitStatus.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.EmerInitStatus.Name = "EmerInitStatus";
			this.EmerInitStatus.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.EmerInitStatus.Text = "Emergency Init Status";
			this.EmerInitStatus.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// EnoughTime
			// 
			this.EnoughTime.BeginInit();
			this.EnoughTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.EnoughTime.IsOnlyInput = true;
			this.EnoughTime.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.EnoughTime.Name = "EnoughTime";
			this.EnoughTime.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.EnoughTime.TagName = "EnoughTime";
			this.EnoughTime.Value = false;
			this.EnoughTime.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EnoughTimeValueChanged);
			this.EnoughTime.EndInit();
			// 
			// InitCmd
			// 
			this.InitCmd.BeginInit();
			this.InitCmd.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.InitCmd.IsOnlyInput = true;
			this.InitCmd.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.InitCmd.Name = "InitCmd";
			this.InitCmd.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.InitCmd.TagName = "InitCmd";
			this.InitCmd.Value = false;
			this.InitCmd.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InitCmdValueChanged);
			this.InitCmd.EndInit();
			// 
			// InitDone
			// 
			this.InitDone.BeginInit();
			this.InitDone.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.InitDone.IsOnlyInput = true;
			this.InitDone.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.InitDone.Name = "InitDone";
			this.InitDone.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.InitDone.TagName = "InitDone";
			this.InitDone.Value = false;
			this.InitDone.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InitDoneValueChanged);
			this.InitDone.EndInit();
			// 
			// EmergencyON
			// 
			this.EmergencyON.BeginInit();
			this.EmergencyON.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.EmergencyON.IsOnlyInput = true;
			this.EmergencyON.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.EmergencyON.Name = "EmergencyON";
			this.EmergencyON.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.EmergencyON.TagName = "EmergencyON";
			this.EmergencyON.Value = false;
			this.EmergencyON.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EmergencyONValueChanged);
			this.EmergencyON.EndInit();
			// 
			// InitStatus_1
			// 
			this.InitStatus_1.BeginInit();
			this.InitStatus_1.DecimalPlacesCount = ((uint)(2u));
			this.InitStatus_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 24D);
			this.InitStatus_1.IsOnlyInput = true;
			this.InitStatus_1.Name = "InitStatus_1";
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.InitStatus_1.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.InitStatus_1.TagName = "InitStatus";
			this.InitStatus_1.TextAngle = 0F;
			this.InitStatus_1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InitStatus_1ValueChanged);
			this.InitStatus_1.EndInit();
			// 
			// sInitStatus
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.EnoughTime,
			this.InitCmd,
			this.InitDone,
			this.EmergencyON,
			this.InitStatus_1,
			this.EmerInitStatus});
			this.SymbolSize = new System.Drawing.Size(400, 88);

		}
		private NxtControl.GuiFramework.Rectangle EmerInitStatus;
		private System.HMI.Symbols.Base.Execute<bool> EnoughTime;
		private System.HMI.Symbols.Base.Execute<bool> InitCmd;
		private System.HMI.Symbols.Base.Execute<bool> InitDone;
		private System.HMI.Symbols.Base.Execute<bool> EmergencyON;
		private System.HMI.Symbols.Base.FreeText<short> InitStatus_1;
		#endregion
	}
}
