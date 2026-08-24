/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 11:02 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ToFinalTreatment
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
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.CapacitySp = new System.HMI.Symbols.Base.TextBox<float>();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.StartLevelSp_Ctp003 = new System.HMI.Symbols.Base.TextBox<float>();
			this.StopLevelSp_Ctp003 = new System.HMI.Symbols.Base.TextBox<float>();
			this.Enable = new System.HMI.Symbols.Base.SwitchButton();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(288D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(264D, 8D),
			new NxtControl.Drawing.PointF(296D, 32D)});
			this.polygon1.Text = "EFFLUENT PUMP CTP 003";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(168D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Capacity Setpoint (m³/h) :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 100D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Start Level Sp - CTP 003 :";
			// 
			// CapacitySp
			// 
			this.CapacitySp.BeginInit();
			this.CapacitySp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 64D);
			this.CapacitySp.MaximumTag = null;
			this.CapacitySp.MinimumTag = null;
			this.CapacitySp.Name = "CapacitySp";
			this.CapacitySp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.CapacitySp.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.CapacitySp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.CapacitySp.Suffix = "m³/h";
			this.CapacitySp.TagName = "CapacitySp";
			this.CapacitySp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.CapacitySp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.CapacitySp.UseInputPad = true;
			this.CapacitySp.Value = 0F;
			this.CapacitySp.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(160D)), ((float)(96D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpGrafcet", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Diagram";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 164D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Control Diagram :";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 132D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Stop Level Sp - CTP 003 :";
			// 
			// StartLevelSp_Ctp003
			// 
			this.StartLevelSp_Ctp003.BeginInit();
			this.StartLevelSp_Ctp003.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 96D);
			this.StartLevelSp_Ctp003.MaximumTag = null;
			this.StartLevelSp_Ctp003.MinimumTag = null;
			this.StartLevelSp_Ctp003.Name = "StartLevelSp_Ctp003";
			this.StartLevelSp_Ctp003.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StartLevelSp_Ctp003.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.StartLevelSp_Ctp003.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StartLevelSp_Ctp003.Suffix = "m";
			this.StartLevelSp_Ctp003.TagName = "StartLevelSp_Ctp003";
			this.StartLevelSp_Ctp003.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.StartLevelSp_Ctp003.UseInputPad = true;
			this.StartLevelSp_Ctp003.Value = 0F;
			this.StartLevelSp_Ctp003.EndInit();
			// 
			// StopLevelSp_Ctp003
			// 
			this.StopLevelSp_Ctp003.BeginInit();
			this.StopLevelSp_Ctp003.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 128D);
			this.StopLevelSp_Ctp003.MaximumTag = null;
			this.StopLevelSp_Ctp003.MinimumTag = null;
			this.StopLevelSp_Ctp003.Name = "StopLevelSp_Ctp003";
			this.StopLevelSp_Ctp003.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.StopLevelSp_Ctp003.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.StopLevelSp_Ctp003.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.StopLevelSp_Ctp003.Suffix = "m";
			this.StopLevelSp_Ctp003.TagName = "StopLevelSp_Ctp003";
			this.StopLevelSp_Ctp003.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.StopLevelSp_Ctp003.UseInputPad = true;
			this.StopLevelSp_Ctp003.Value = 0F;
			this.StopLevelSp_Ctp003.EndInit();
			// 
			// Enable
			// 
			this.Enable.BeginInit();
			this.Enable.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2D, 0D, 0D, 0.8666666666666667D, 240D, 32D);
			this.Enable.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Enable.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Enable.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Enable.Name = "Enable";
			this.Enable.TagName = "Enable";
			this.Enable.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Enable.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Enable.Value = false;
			this.Enable.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 36D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "CT003 Control :";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.freeText2,
			this.CapacitySp,
			this.drawnButton1,
			this.freeText3,
			this.freeText4,
			this.StartLevelSp_Ctp003,
			this.StopLevelSp_Ctp003,
			this.Enable,
			this.freeText5});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> CapacitySp;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.TextBox<float> StartLevelSp_Ctp003;
		private System.HMI.Symbols.Base.TextBox<float> StopLevelSp_Ctp003;
		private System.HMI.Symbols.Base.SwitchButton Enable;
		private NxtControl.GuiFramework.FreeText freeText5;
		#endregion
	}
}
