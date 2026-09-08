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
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.Sp = new System.HMI.Symbols.Base.TimeLabel();
			this.Pv = new System.HMI.Symbols.Base.TimeLabel();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "DUR SP :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 24D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "DUR PV :";
			// 
			// Sp
			// 
			this.Sp.BeginInit();
			this.Sp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.Sp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 64D, 6D);
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
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 64D, 22D);
			this.Pv.FontScale = false;
			this.Pv.IsOnlyInput = true;
			this.Pv.Name = "Pv";
			this.Pv.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.Pv.TagName = "DurPv";
			this.Pv.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Pv.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1,
			this.freeText2,
			this.Sp,
			this.Pv});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TimeLabel Sp;
		private System.HMI.Symbols.Base.TimeLabel Pv;
		#endregion
	}
}
