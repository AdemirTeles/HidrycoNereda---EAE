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
	partial class sPumpStatus
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.sStatus4 = new SE.Nereda.Symbols.Motor_VS.sStatus();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(112D)), ((float)(16D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(24D, 16D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "NVPP 001 ctp 001";
			// 
			// sStatus4
			// 
			this.sStatus4.BeginInit();
			this.sStatus4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 128D, 16D);
			this.sStatus4.Name = "sStatus4";
			this.sStatus4.SecurityToken = ((uint)(4294967295u));
			this.sStatus4.TagName = "Actuators.FeedReactorPump01";
			this.sStatus4.EndInit();
			// 
			// sPumpStatus
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText5,
			this.sStatus4});
			this.SymbolSize = new System.Drawing.Size(488, 280);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText5;
		private SE.Nereda.Symbols.Motor_VS.sStatus sStatus4;
		#endregion
	}
}
