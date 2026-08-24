/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 2/4/2026
 * Time: 11:49 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.E_DELAY_HOLD_V_D
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sCounter2
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Sp = new System.HMI.Symbols.Base.TimeLabel();
			this.Pv = new System.HMI.Symbols.Base.TimeLabel();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// Sp
			// 
			this.Sp.BeginInit();
			this.Sp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Sp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.69333333333333325D, 0D, 0D, 1D, 24.000000000000014D, 16D);
			this.Sp.FontScale = false;
			this.Sp.IsOnlyInput = true;
			this.Sp.Name = "Sp";
			this.Sp.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.Sp.TagName = "DurSp";
			this.Sp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Sp.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.69333333333333325D, 0D, 0D, 1D, 136D, 16D);
			this.Pv.FontScale = false;
			this.Pv.IsOnlyInput = true;
			this.Pv.Name = "Pv";
			this.Pv.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.Pv.TagName = "DurPv";
			this.Pv.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Pv.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(128D, 33D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(128D, 17D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Sp,
			this.Pv,
			this.line1});
			this.group1.EndInit();
			// 
			// sCounter2
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.TimeLabel Sp;
		private System.HMI.Symbols.Base.TimeLabel Pv;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
