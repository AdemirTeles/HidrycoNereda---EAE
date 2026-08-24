/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/11/2026
 * Time: 11:30 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sFlushPump.
	/// </summary>
	partial class sFlushPump
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sPump1 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.sFlushFlowSp1 = new SE.Nereda.Symbols.FlushingManager.sFlushFlowSp();
			// 
			// sPump1
			// 
			this.sPump1.BeginInit();
			this.sPump1._iMotName = "Motor";
			this.sPump1._iUnit = "%";
			this.sPump1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 96D, 72D);
			this.sPump1.Name = "sPump1";
			this.sPump1.SecurityToken = ((uint)(4294967295u));
			this.sPump1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.sPump1.TagName = "Actuators.NVPP_001_ctp_002";
			this.sPump1.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(131D)), ((float)(56D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(128D, 131D),
			new NxtControl.Drawing.PointF(72D, 131D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(152D)), ((float)(109D)), ((float)(56D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 109D),
			new NxtControl.Drawing.PointF(152D, 109D)});
			this.pipe2.Width = 10;
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(80D)), ((float)(136D)), ((float)(88D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(64D)), ((float)(136D)), ((float)(16D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Text = "NVPP 001 ctp 002";
			this.rectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(168D)), ((float)(136D)), ((float)(16D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Text = "Flow SP :";
			this.rectangle3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			// 
			// sFlushFlowSp1
			// 
			this.sFlushFlowSp1.BeginInit();
			this.sFlushFlowSp1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 168D);
			this.sFlushFlowSp1.Name = "sFlushFlowSp1";
			this.sFlushFlowSp1.SecurityToken = ((uint)(4294967295u));
			this.sFlushFlowSp1.TagName = "EffluentLogic.FlushingManager";
			this.sFlushFlowSp1.EndInit();
			// 
			// sFlushPump
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.pipe1,
			this.pipe2,
			this.sPump1,
			this.rectangle2,
			this.rectangle3,
			this.sFlushFlowSp1});
			this.SymbolSize = new System.Drawing.Size(320, 288);

		}
		private SE.Nereda.Symbols.Motor_VS.sPump sPump1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private SE.Nereda.Symbols.FlushingManager.sFlushFlowSp sFlushFlowSp1;
		#endregion
	}
}
