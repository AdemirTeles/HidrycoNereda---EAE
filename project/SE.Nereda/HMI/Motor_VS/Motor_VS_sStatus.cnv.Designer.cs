/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/26/2026
 * Time: 2:28 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.Motor_VS
{
	/// <summary>
	/// Summary description for sStatus.
	/// </summary>
	partial class sStatus
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.Status = new NxtControl.GuiFramework.Rectangle();
			this.State = new SE.Nereda.Symbols.ActState.sDefault();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.FbSpeed = new System.HMI.Symbols.Base.FreeText<float>();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(24D)), ((float)(80D)), ((float)(16D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// Status
			// 
			this.Status.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(24D)), ((float)(48D)), ((float)(16D)));
			this.Status.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Status.Name = "Status";
			this.Status.Text = "Running";
			this.Status.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State
			// 
			this.State.BeginInit();
			this.State.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 82D, 24D);
			this.State.Name = "State";
			this.State.SecurityToken = ((uint)(4294967295u));
			this.State.TagName = "State";
			this.State.ActuatorStatus += new SE.Nereda.Symbols.ActState.sDefault.ActState(this.StateActuatorStatus);
			this.State.EndInit();
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(24D)), ((float)(128D)), ((float)(32D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// FbSpeed
			// 
			this.FbSpeed.BeginInit();
			this.FbSpeed.DecimalPlacesCount = ((uint)(2u));
			this.FbSpeed.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 32D, 40D);
			this.FbSpeed.IsOnlyInput = true;
			this.FbSpeed.Name = "FbSpeed";
			this.FbSpeed.Ranges.Clear();
			this.FbSpeed.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.FbSpeed.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.FbSpeed.Suffix = "%";
			this.FbSpeed.TagName = "FbSpeed";
			this.FbSpeed.TextAngle = 0F;
			this.FbSpeed.EndInit();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(40D)), ((float)(128D)), ((float)(16D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// sStatus
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.rectangle1,
			this.Status,
			this.State,
			this.alarmFrame,
			this.FbSpeed});
			this.SymbolSize = new System.Drawing.Size(200, 192);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle Status;
		private SE.Nereda.Symbols.ActState.sDefault State;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private System.HMI.Symbols.Base.FreeText<float> FbSpeed;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		#endregion
	}
}
