/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/3/2026
 * Time: 2:58 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.InfluentFeed
{
	/// <summary>
	/// Summary description for sPumpStatus.
	/// </summary>
	partial class sPumpValveStatus
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.sStatus3 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.sStatus4 = new SE.Nereda.Symbols.Motor_VS.sStatus();
			this.line1 = new NxtControl.GuiFramework.Line();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(112D)), ((float)(48D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 32D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "NVPP 001 a-- 003";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 56D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "NVPP 001 ctp 001";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(240D)), ((float)(16D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "Influent Feed Pump & Valve";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// sStatus3
			// 
			this.sStatus3.BeginInit();
			this.sStatus3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 32D);
			this.sStatus3.Name = "sStatus3";
			this.sStatus3.SecurityToken = ((uint)(4294967295u));
			this.sStatus3.TagName = "Actuators.DischargeValve";
			this.sStatus3.EndInit();
			// 
			// sStatus4
			// 
			this.sStatus4.BeginInit();
			this.sStatus4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 48D);
			this.sStatus4.Name = "sStatus4";
			this.sStatus4.SecurityToken = ((uint)(4294967295u));
			this.sStatus4.TagName = "Actuators.FeedReactorPump01";
			this.sStatus4.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(8D, 48D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(120D, 48D);
			// 
			// sPumpValveStatus
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText3,
			this.freeText5,
			this.rectangle2,
			this.sStatus3,
			this.sStatus4,
			this.line1});
			this.SymbolSize = new System.Drawing.Size(488, 280);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus3;
		private SE.Nereda.Symbols.Motor_VS.sStatus sStatus4;
		private NxtControl.GuiFramework.Line line1;
		#endregion
	}
}
