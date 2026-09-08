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
	partial class sStatus
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.sStatus1 = new SE.Nereda.Symbols.Motor_VS.sStatus();
			this.sStatus2 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.sStatus3 = new SE.Nereda.Symbols.ValveS.sStatus();
			this.sStatus4 = new SE.Nereda.Symbols.Motor_VS.sStatus();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(32D)), ((float)(112D)), ((float)(80D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 48D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "46 2 AP a-- 95 003";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 64D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "NVPP 001 RGI 001";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 80D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "NVPP 001 a-- 003";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 96D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "NVPP 001 ctp 001";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(240D)), ((float)(16D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "Influent Pumps & Valves";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 32D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "46 2 AP ifp 95 001";
			// 
			// sStatus1
			// 
			this.sStatus1.BeginInit();
			this.sStatus1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 32D);
			this.sStatus1.Name = "sStatus1";
			this.sStatus1.SecurityToken = ((uint)(4294967295u));
			this.sStatus1.TagName = "Actuators.FeedInfluentPump01";
			this.sStatus1.EndInit();
			// 
			// sStatus2
			// 
			this.sStatus2.BeginInit();
			this.sStatus2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 48D);
			this.sStatus2.Name = "sStatus2";
			this.sStatus2.SecurityToken = ((uint)(4294967295u));
			this.sStatus2.TagName = "Actuators.AirVentValve";
			this.sStatus2.EndInit();
			// 
			// sStatus3
			// 
			this.sStatus3.BeginInit();
			this.sStatus3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 80D);
			this.sStatus3.Name = "sStatus3";
			this.sStatus3.SecurityToken = ((uint)(4294967295u));
			this.sStatus3.TagName = "Actuators.DischargeValve";
			this.sStatus3.EndInit();
			// 
			// sStatus4
			// 
			this.sStatus4.BeginInit();
			this.sStatus4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 96D);
			this.sStatus4.Name = "sStatus4";
			this.sStatus4.SecurityToken = ((uint)(4294967295u));
			this.sStatus4.TagName = "Actuators.FeedReactorPump01";
			this.sStatus4.EndInit();
			// 
			// sPumpStatus
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText5,
			this.rectangle2,
			this.freeText7,
			this.sStatus1,
			this.sStatus2,
			this.sStatus3,
			this.sStatus4});
			this.SymbolSize = new System.Drawing.Size(488, 280);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText7;
		private SE.Nereda.Symbols.Motor_VS.sStatus sStatus1;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus2;
		private SE.Nereda.Symbols.ValveS.sStatus sStatus3;
		private SE.Nereda.Symbols.Motor_VS.sStatus sStatus4;
		#endregion
	}
}
