/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/24/2026
 * Time: 11:46 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ValveS
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
			this.Status = new NxtControl.GuiFramework.Rectangle();
			this.State = new SE.Nereda.Symbols.ActState.sDefault();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// Status
			// 
			this.Status.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(24D)), ((float)(48D)), ((float)(16D)));
			this.Status.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Status.Name = "Status";
			this.Status.Text = "Opened";
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
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(24D)), ((float)(128D)), ((float)(16D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(24D)), ((float)(88D)), ((float)(16D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// sStatus
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.Status,
			this.State,
			this.alarmFrame});
			this.SymbolSize = new System.Drawing.Size(200, 200);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle Status;
		private SE.Nereda.Symbols.ActState.sDefault State;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		#endregion
	}
}
