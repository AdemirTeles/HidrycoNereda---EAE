/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 24/02/2026
 * Tempo: 14:11
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.ElevatoriaEsgotoBruto
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.BoiaL = new Hidryco.HidrycoLib.Symbols.Boia.sDefault();
			this.BoiaH = new Hidryco.HidrycoLib.Symbols.Boia.sDefault();
			this.Motor_Inversor_ok4 = new Hidryco.HidrycoLib.Symbols.Motor_Inversor.sBomba();
			this.Motor_Inversor_ok5 = new Hidryco.HidrycoLib.Symbols.Motor_Inversor.sBomba();
			this.Motor_Inversor_ok6 = new Hidryco.HidrycoLib.Symbols.Motor_Inversor.sBomba();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.roundedRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.resetFalhasProcesso = new NxtControl.GuiFramework.DrawnButton();
			this.Revezamento_3_Motores_ok1 = new Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.sDefault();
			this.PID2 = new Hidryco.HidrycoLib.Symbols.PID.sDefault();
			this.Necessidade_2_Equipamentos_ok1 = new Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.sDefault();
			this.LIT_100_03 = new Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20.sDefault();
			this.PT_100_01 = new Hidryco.HidrycoLib.Symbols.Sensor_4a20.sDefault();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(268D)), ((float)(912D)), ((float)(384D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(120D, 456D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(0D, 456D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(1304D, 432D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(232D, 432D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(232D, 432D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(232D, 536D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(544D, 432D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(544D, 536D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(850D, 432D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(850D, 536D);
			// 
			// BoiaL
			// 
			this.BoiaL.BeginInit();
			this.BoiaL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 984D, 536D);
			this.BoiaL.Name = "BoiaL";
			this.BoiaL.SecurityToken = ((uint)(4294967295u));
			this.BoiaL.TagName = "LSL_100_04";
			this.BoiaL.EndInit();
			// 
			// BoiaH
			// 
			this.BoiaH.BeginInit();
			this.BoiaH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, -1D, 984D, 386D);
			this.BoiaH.Name = "BoiaH";
			this.BoiaH.SecurityToken = ((uint)(4294967295u));
			this.BoiaH.TagName = "LSH_100_05";
			this.BoiaH.EndInit();
			// 
			// Motor_Inversor_ok4
			// 
			this.Motor_Inversor_ok4.BeginInit();
			this.Motor_Inversor_ok4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 176D, 536D);
			this.Motor_Inversor_ok4.Name = "Motor_Inversor_ok4";
			this.Motor_Inversor_ok4.SecurityToken = ((uint)(4294967295u));
			this.Motor_Inversor_ok4.TagName = "BS_100_01";
			this.Motor_Inversor_ok4.EndInit();
			// 
			// Motor_Inversor_ok5
			// 
			this.Motor_Inversor_ok5.BeginInit();
			this.Motor_Inversor_ok5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 488D, 536D);
			this.Motor_Inversor_ok5.Name = "Motor_Inversor_ok5";
			this.Motor_Inversor_ok5.SecurityToken = ((uint)(4294967295u));
			this.Motor_Inversor_ok5.TagName = "BS_100_02";
			this.Motor_Inversor_ok5.EndInit();
			// 
			// Motor_Inversor_ok6
			// 
			this.Motor_Inversor_ok6.BeginInit();
			this.Motor_Inversor_ok6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 792D, 536D);
			this.Motor_Inversor_ok6.Name = "Motor_Inversor_ok6";
			this.Motor_Inversor_ok6.SecurityToken = ((uint)(4294967295u));
			this.Motor_Inversor_ok6.TagName = "BS_100_03";
			this.Motor_Inversor_ok6.EndInit();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(8D)), ((float)(192D)), ((float)(160D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roundedRectangle2
			// 
			this.roundedRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(1129D)), ((float)(17D)), ((float)(160D)), ((float)(59D)));
			this.roundedRectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.roundedRectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle2.Name = "roundedRectangle2";
			this.roundedRectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resetFalhasProcesso
			// 
			this.resetFalhasProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(1149D)), ((float)(28D)), ((float)(120D)), ((float)(36D)));
			this.resetFalhasProcesso.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.resetFalhasProcesso.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.resetFalhasProcesso.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.resetFalhasProcesso.Name = "resetFalhasProcesso";
			this.resetFalhasProcesso.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.resetFalhasProcesso.Radius = 4D;
			this.resetFalhasProcesso.Text = "Reset Falhas";
			this.resetFalhasProcesso.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.resetFalhasProcesso.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.resetFalhasProcesso.Use3DEffect = false;
			this.resetFalhasProcesso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResetFalhasProcessoMouseDown);
			this.resetFalhasProcesso.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResetFalhasProcessoMouseUp);
			// 
			// Revezamento_3_Motores_ok1
			// 
			this.Revezamento_3_Motores_ok1.BeginInit();
			this.Revezamento_3_Motores_ok1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 72D);
			this.Revezamento_3_Motores_ok1.Name = "Revezamento_3_Motores_ok1";
			this.Revezamento_3_Motores_ok1.SecurityToken = ((uint)(4294967295u));
			this.Revezamento_3_Motores_ok1.TagName = "Revezamento_3_Motores_ok1";
			this.Revezamento_3_Motores_ok1.EndInit();
			// 
			// PID2
			// 
			this.PID2.BeginInit();
			this.PID2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 120D);
			this.PID2.Name = "PID2";
			this.PID2.SecurityToken = ((uint)(4294967295u));
			this.PID2.TagName = "PID2";
			this.PID2.EndInit();
			// 
			// Necessidade_2_Equipamentos_ok1
			// 
			this.Necessidade_2_Equipamentos_ok1.BeginInit();
			this.Necessidade_2_Equipamentos_ok1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 48D, 24D);
			this.Necessidade_2_Equipamentos_ok1.Name = "Necessidade_2_Equipamentos_ok1";
			this.Necessidade_2_Equipamentos_ok1.SecurityToken = ((uint)(4294967295u));
			this.Necessidade_2_Equipamentos_ok1.TagName = "Necessidade_2_Equipamentos_ok1";
			this.Necessidade_2_Equipamentos_ok1.EndInit();
			// 
			// LIT_100_03
			// 
			this.LIT_100_03.BeginInit();
			this.LIT_100_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1875D, 0D, 0D, 1.2222461273666092D, 552D, 160D);
			this.LIT_100_03.Name = "LIT_100_03";
			this.LIT_100_03.SecurityToken = ((uint)(4294967295u));
			this.LIT_100_03.TagName = "LIT_100_03";
			this.LIT_100_03.EndInit();
			// 
			// PT_100_01
			// 
			this.PT_100_01.BeginInit();
			this.PT_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3125D, 0D, 0D, 1.3125D, 1104D, 336D);
			this.PT_100_01.Name = "PT_100_01";
			this.PT_100_01.SecurityToken = ((uint)(4294967295u));
			this.PT_100_01.TagName = "PT_100_01";
			this.PT_100_01.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.rectangle1,
			this.line1,
			this.line2,
			this.line4,
			this.line5,
			this.line6,
			this.BoiaL,
			this.BoiaH,
			this.Motor_Inversor_ok4,
			this.Motor_Inversor_ok5,
			this.Motor_Inversor_ok6,
			this.roundedRectangle2,
			this.resetFalhasProcesso,
			this.Revezamento_3_Motores_ok1,
			this.PID2,
			this.Necessidade_2_Equipamentos_ok1,
			this.LIT_100_03,
			this.PT_100_01});
			this.SymbolSize = new System.Drawing.Size(1300, 700);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private Hidryco.HidrycoLib.Symbols.Boia.sDefault BoiaL;
		private Hidryco.HidrycoLib.Symbols.Boia.sDefault BoiaH;
		private Hidryco.HidrycoLib.Symbols.Motor_Inversor.sBomba Motor_Inversor_ok4;
		private Hidryco.HidrycoLib.Symbols.Motor_Inversor.sBomba Motor_Inversor_ok5;
		private Hidryco.HidrycoLib.Symbols.Motor_Inversor.sBomba Motor_Inversor_ok6;
		private Hidryco.HidrycoLib.Symbols.PID.sDefault PID2;
		private Hidryco.HidrycoLib.Symbols.Revezamento_3_Motores_ok.sDefault Revezamento_3_Motores_ok1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle2;
		private NxtControl.GuiFramework.DrawnButton resetFalhasProcesso;
		private Hidryco.HidrycoLib.Symbols.Necessidade_2_Equipamentos_ok.sDefault Necessidade_2_Equipamentos_ok1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20.sDefault LIT_100_03;
		private Hidryco.HidrycoLib.Symbols.Sensor_4a20.sDefault PT_100_01;
		#endregion
	}
}
