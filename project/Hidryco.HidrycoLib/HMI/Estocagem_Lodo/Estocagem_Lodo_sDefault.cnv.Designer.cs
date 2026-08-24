/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 28/04/2026
 * Tempo: 11:22
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Estocagem_Lodo
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
			this.SO_900_01 = new Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico.sSoprador();
			this.sSoprador1 = new Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico.sSoprador();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.VB_900_03 = new Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaVertical();
			this.VB_900_04 = new Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaVertical();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.LIT_900_01 = new Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20.sDefault();
			this.LIT_900_02 = new Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20.sDefault();
			this.Revezamento_2_Motores_ok1 = new Hidryco.HidrycoLib.Symbols.Revezamento_2_Motores_ok.sDefault();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.Valvula_Lodo1 = new Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaHorizontal();
			this.Valvula_Lodo2 = new Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaHorizontal();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.porcentagemLIT_900_01 = new System.HMI.Symbols.Base.BarValueVertical<float>();
			this.porcentagemLIT_900_02 = new System.HMI.Symbols.Base.BarValueVertical<float>();
			// 
			// SO_900_01
			// 
			this.SO_900_01.BeginInit();
			this.SO_900_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.79126213592233008D, 0D, 0D, 0.79126213592233019D, 176D, 384D);
			this.SO_900_01.Name = "SO_900_01";
			this.SO_900_01.SecurityToken = ((uint)(4294967295u));
			this.SO_900_01.TagName = "SO_900_01";
			this.SO_900_01.EndInit();
			// 
			// sSoprador1
			// 
			this.sSoprador1.BeginInit();
			this.sSoprador1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.79126213592233008D, 0D, 0D, 0.79126213592233019D, 416D, 384D);
			this.sSoprador1.Name = "sSoprador1";
			this.sSoprador1.SecurityToken = ((uint)(4294967295u));
			this.sSoprador1.TagName = "SO_900_01";
			this.sSoprador1.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(168D, 256D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(168D, 40D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(344D, 200D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(344D, 40D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(512D, 256D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(512D, 40D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(512D, 256D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(168D, 256D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(456D, 344D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(456D, 384D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(216D, 344D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(216D, 384D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(456D, 344D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(216D, 344D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(256D, 280D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(256D, 256D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(424D, 280D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(424D, 256D);
			// 
			// VB_900_03
			// 
			this.VB_900_03.BeginInit();
			this.VB_900_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55045871559633031D, 0D, 0D, 0.55045871559633031D, 214D, 280D);
			this.VB_900_03.Name = "VB_900_03";
			this.VB_900_03.SecurityToken = ((uint)(4294967295u));
			this.VB_900_03.TagName = "VB_900_03";
			this.VB_900_03.EndInit();
			// 
			// VB_900_04
			// 
			this.VB_900_04.BeginInit();
			this.VB_900_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55045871559633031D, 0D, 0D, 0.55045871559633019D, 382D, 280D);
			this.VB_900_04.Name = "VB_900_04";
			this.VB_900_04.SecurityToken = ((uint)(4294967295u));
			this.VB_900_04.TagName = "VB_900_04";
			this.VB_900_04.EndInit();
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(256D, 344D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(256D, 304D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(424D, 344D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(424D, 304D);
			// 
			// LIT_900_01
			// 
			this.LIT_900_01.BeginInit();
			this.LIT_900_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 48D);
			this.LIT_900_01.Name = "LIT_900_01";
			this.LIT_900_01.SecurityToken = ((uint)(4294967295u));
			this.LIT_900_01.TagName = "LIT_900_01";
			this.LIT_900_01.EndInit();
			// 
			// LIT_900_02
			// 
			this.LIT_900_02.BeginInit();
			this.LIT_900_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 368D, 48D);
			this.LIT_900_02.Name = "LIT_900_02";
			this.LIT_900_02.SecurityToken = ((uint)(4294967295u));
			this.LIT_900_02.TagName = "LIT_900_02";
			this.LIT_900_02.EndInit();
			// 
			// Revezamento_2_Motores_ok1
			// 
			this.Revezamento_2_Motores_ok1.BeginInit();
			this.Revezamento_2_Motores_ok1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 280D, 352D);
			this.Revezamento_2_Motores_ok1.Name = "Revezamento_2_Motores_ok1";
			this.Revezamento_2_Motores_ok1.SecurityToken = ((uint)(4294967295u));
			this.Revezamento_2_Motores_ok1.TagName = "Revezamento_2_Motores_ok1";
			this.Revezamento_2_Motores_ok1.EndInit();
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(600D, 224D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(512D, 224D);
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(224D)), ((float)(512D)), ((float)(112D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(168D, 232D),
			new NxtControl.Drawing.PointF(88D, 232D),
			new NxtControl.Drawing.PointF(88D, 336D),
			new NxtControl.Drawing.PointF(240D, 336D),
			new NxtControl.Drawing.PointF(248D, 320D),
			new NxtControl.Drawing.PointF(264D, 320D),
			new NxtControl.Drawing.PointF(272D, 336D),
			new NxtControl.Drawing.PointF(408D, 336D),
			new NxtControl.Drawing.PointF(416D, 320D),
			new NxtControl.Drawing.PointF(432D, 320D),
			new NxtControl.Drawing.PointF(440D, 336D),
			new NxtControl.Drawing.PointF(600D, 336D),
			new NxtControl.Drawing.PointF(600D, 224D),
			new NxtControl.Drawing.PointF(600D, 224D)});
			// 
			// Valvula_Lodo1
			// 
			this.Valvula_Lodo1.BeginInit();
			this.Valvula_Lodo1.DefaultInstanceName = null;
			this.Valvula_Lodo1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.59259259259259256D, 0D, 0D, 0.59259259259259267D, 104D, 191D);
			this.Valvula_Lodo1.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.Valvula_Lodo1.MyTagDisplayName = null;
			this.Valvula_Lodo1.Name = "Valvula_Lodo1";
			this.Valvula_Lodo1.SecurityToken = ((uint)(4294967295u));
			this.Valvula_Lodo1.TagName = "VA_900_01";
			this.Valvula_Lodo1.EndInit();
			// 
			// Valvula_Lodo2
			// 
			this.Valvula_Lodo2.BeginInit();
			this.Valvula_Lodo2.DefaultInstanceName = null;
			this.Valvula_Lodo2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.59259259259259256D, 0D, 0D, 0.59259259259259256D, 528D, 183.00000000000003D);
			this.Valvula_Lodo2.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.Valvula_Lodo2.MyTagDisplayName = null;
			this.Valvula_Lodo2.Name = "Valvula_Lodo2";
			this.Valvula_Lodo2.SecurityToken = ((uint)(4294967295u));
			this.Valvula_Lodo2.TagName = "VA_900_02";
			this.Valvula_Lodo2.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(336D)), ((float)(200D)), ((float)(16D)), ((float)(56D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// porcentagemLIT_900_01
			// 
			this.porcentagemLIT_900_01.BeginInit();
			this.porcentagemLIT_900_01.BarThickness = 175;
			this.porcentagemLIT_900_01.BarValueBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(122)), ((byte)(78)), ((byte)(43))));
			this.porcentagemLIT_900_01.Brush = new NxtControl.Drawing.Brush("TrackerBrush");
			this.porcentagemLIT_900_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.88333333333333364D, 157D, 15D);
			this.porcentagemLIT_900_01.Font = new NxtControl.Drawing.Font("TrackerFont");
			this.porcentagemLIT_900_01.IsOnlyInput = true;
			this.porcentagemLIT_900_01.Maximum = 100F;
			this.porcentagemLIT_900_01.MaximumTag = null;
			this.porcentagemLIT_900_01.Minimum = 0F;
			this.porcentagemLIT_900_01.MinimumTag = null;
			this.porcentagemLIT_900_01.MouseMoveValueThreshold = 0D;
			this.porcentagemLIT_900_01.Name = "porcentagemLIT_900_01";
			this.porcentagemLIT_900_01.Pen = new NxtControl.Drawing.Pen("TrackerPen");
			this.porcentagemLIT_900_01.Radius = 20D;
			this.porcentagemLIT_900_01.ScaleColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_01.ScaleDisabledColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_01.ShowValueTooltip = false;
			this.porcentagemLIT_900_01.TagName = "porcentagemLIT_900_01";
			this.porcentagemLIT_900_01.TextColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_01.TextDisabledColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_01.TextStyle = System.Windows.Forms.TickStyle.None;
			this.porcentagemLIT_900_01.TickLength = 0;
			this.porcentagemLIT_900_01.TickPercent = 0;
			this.porcentagemLIT_900_01.TickStyle = System.Windows.Forms.TickStyle.None;
			this.porcentagemLIT_900_01.Value = 0F;
			this.porcentagemLIT_900_01.ValueFont = new NxtControl.Drawing.Font("TrackerValueFont");
			this.porcentagemLIT_900_01.EndInit();
			// 
			// porcentagemLIT_900_02
			// 
			this.porcentagemLIT_900_02.BeginInit();
			this.porcentagemLIT_900_02.BarThickness = 175;
			this.porcentagemLIT_900_02.BarValueBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(122)), ((byte)(78)), ((byte)(43))));
			this.porcentagemLIT_900_02.Brush = new NxtControl.Drawing.Brush("TrackerBrush");
			this.porcentagemLIT_900_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.88333333333333364D, 327D, 15D);
			this.porcentagemLIT_900_02.Font = new NxtControl.Drawing.Font("TrackerFont");
			this.porcentagemLIT_900_02.IsOnlyInput = true;
			this.porcentagemLIT_900_02.Maximum = 100F;
			this.porcentagemLIT_900_02.MaximumTag = null;
			this.porcentagemLIT_900_02.Minimum = 0F;
			this.porcentagemLIT_900_02.MinimumTag = null;
			this.porcentagemLIT_900_02.MouseMoveValueThreshold = 0D;
			this.porcentagemLIT_900_02.Name = "porcentagemLIT_900_02";
			this.porcentagemLIT_900_02.Pen = new NxtControl.Drawing.Pen("TrackerPen");
			this.porcentagemLIT_900_02.Radius = 20D;
			this.porcentagemLIT_900_02.ScaleColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_02.ScaleDisabledColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_02.TagName = "porcentagemLIT_900_02";
			this.porcentagemLIT_900_02.TextColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_02.TextDisabledColor = new NxtControl.Drawing.Color("Transparent");
			this.porcentagemLIT_900_02.TextStyle = System.Windows.Forms.TickStyle.None;
			this.porcentagemLIT_900_02.TickLength = 0;
			this.porcentagemLIT_900_02.TickPercent = 0;
			this.porcentagemLIT_900_02.TickStyle = System.Windows.Forms.TickStyle.None;
			this.porcentagemLIT_900_02.Value = 0F;
			this.porcentagemLIT_900_02.ValueFont = new NxtControl.Drawing.Font("TrackerValueFont");
			this.porcentagemLIT_900_02.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.porcentagemLIT_900_02,
			this.porcentagemLIT_900_01,
			this.SO_900_01,
			this.sSoprador1,
			this.line1,
			this.line2,
			this.line3,
			this.line5,
			this.line4,
			this.line6,
			this.line7,
			this.line8,
			this.line9,
			this.line10,
			this.line11,
			this.VB_900_04,
			this.VB_900_03,
			this.LIT_900_01,
			this.LIT_900_02,
			this.Revezamento_2_Motores_ok1,
			this.line12,
			this.polyline1,
			this.Valvula_Lodo1,
			this.Valvula_Lodo2,
			this.rectangle1});
			this.SymbolSize = new System.Drawing.Size(680, 496);

		}
		private Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico.sSoprador SO_900_01;
		private Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico.sSoprador sSoprador1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaVertical VB_900_03;
		private Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaVertical VB_900_04;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20.sDefault LIT_900_01;
		private Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20.sDefault LIT_900_02;
		private Hidryco.HidrycoLib.Symbols.Revezamento_2_Motores_ok.sDefault Revezamento_2_Motores_ok1;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Polyline polyline1;
		private Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaHorizontal Valvula_Lodo1;
		private Hidryco.HidrycoLib.Symbols.Equipamento_On_Off.sValvulaHorizontal Valvula_Lodo2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.BarValueVertical<float> porcentagemLIT_900_01;
		private System.HMI.Symbols.Base.BarValueVertical<float> porcentagemLIT_900_02;
		#endregion
	}
}
