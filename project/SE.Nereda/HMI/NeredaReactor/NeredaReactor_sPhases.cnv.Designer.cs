/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 3:01 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaReactor
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sPhases
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DisplayStatus = new NxtControl.GuiFramework.Rectangle();
			this.ReactorLogic = new SE.Nereda.Symbols.ReactorLogic.sDefault();
			this.InStatus = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// DisplayStatus
			// 
			this.DisplayStatus.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(464D)), ((float)(32D)));
			this.DisplayStatus.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.DisplayStatus.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.DisplayStatus.Name = "DisplayStatus";
			this.DisplayStatus.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.DisplayStatus.Text = "REACTOR STATUS";
			this.DisplayStatus.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.DisplayStatus.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// ReactorLogic
			// 
			this.ReactorLogic.BeginInit();
			this.ReactorLogic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 48D);
			this.ReactorLogic.Name = "ReactorLogic";
			this.ReactorLogic.SecurityToken = ((uint)(4294967295u));
			this.ReactorLogic.TagName = "ReactorLogic";
			this.ReactorLogic.EndInit();
			// 
			// InStatus
			// 
			this.InStatus.BeginInit();
			this.InStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.InStatus.IsOnlyInput = true;
			this.InStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.InStatus.Name = "InStatus";
			this.InStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.InStatus.TagName = "InStatus";
			this.InStatus.Value = ((short)(0));
			this.InStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InStatusValueChanged);
			this.InStatus.EndInit();
			// 
			// sPhases
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.DisplayStatus,
			this.ReactorLogic,
			this.InStatus});
			this.SymbolSize = new System.Drawing.Size(504, 232);

		}
		private NxtControl.GuiFramework.Rectangle DisplayStatus;
		private SE.Nereda.Symbols.ReactorLogic.sDefault ReactorLogic;
		private System.HMI.Symbols.Base.Execute<short> InStatus;
		#endregion
	}
}
