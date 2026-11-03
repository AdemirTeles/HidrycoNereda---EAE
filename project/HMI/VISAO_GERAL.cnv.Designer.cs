/*
 * Hidryco - tela VISAO_GERAL (visao geral da ETE)
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs; arranjo do P&ID HID-PE-DE-ETE-FLX-002.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for VISAO_GERAL.
	/// </summary>
	partial class VISAO_GERAL
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.cardProcesso = new NxtControl.GuiFramework.Rectangle();
			this.qEEE = new NxtControl.GuiFramework.Rectangle();
			this.irEEE = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or1 = new NxtControl.GuiFramework.FreeText();
			this.or2 = new NxtControl.GuiFramework.FreeText();
			this.or3 = new NxtControl.GuiFramework.FreeText();
			this.or4 = new NxtControl.GuiFramework.FreeText();
			this.or5 = new NxtControl.GuiFramework.FreeText();
			this.or6 = new NxtControl.GuiFramework.FreeText();
			this.or7 = new NxtControl.GuiFramework.FreeText();
			this.or8 = new NxtControl.GuiFramework.FreeText();
			this.mlit10003 = new NxtControl.GuiFramework.Rectangle();
			this.or9 = new NxtControl.GuiFramework.FreeText();
			this.mgm1dif = new NxtControl.GuiFramework.Rectangle();
			this.or10 = new NxtControl.GuiFramework.FreeText();
			this.mgm2dif = new NxtControl.GuiFramework.Rectangle();
			this.or11 = new NxtControl.GuiFramework.FreeText();
			this.qPRE = new NxtControl.GuiFramework.Rectangle();
			this.irPRE = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or12 = new NxtControl.GuiFramework.FreeText();
			this.or13 = new NxtControl.GuiFramework.FreeText();
			this.or14 = new NxtControl.GuiFramework.FreeText();
			this.or15 = new NxtControl.GuiFramework.FreeText();
			this.or16 = new NxtControl.GuiFramework.FreeText();
			this.mft4002 = new NxtControl.GuiFramework.Rectangle();
			this.or17 = new NxtControl.GuiFramework.FreeText();
			this.qINF = new NxtControl.GuiFramework.Rectangle();
			this.irINF = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or18 = new NxtControl.GuiFramework.FreeText();
			this.or19 = new NxtControl.GuiFramework.FreeText();
			this.or20 = new NxtControl.GuiFramework.FreeText();
			this.or21 = new NxtControl.GuiFramework.FreeText();
			this.or22 = new NxtControl.GuiFramework.FreeText();
			this.qREA = new NxtControl.GuiFramework.Rectangle();
			this.irREA = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or23 = new NxtControl.GuiFramework.FreeText();
			this.or24 = new NxtControl.GuiFramework.FreeText();
			this.or25 = new NxtControl.GuiFramework.FreeText();
			this.or26 = new NxtControl.GuiFramework.FreeText();
			this.or27 = new NxtControl.GuiFramework.FreeText();
			this.or28 = new NxtControl.GuiFramework.FreeText();
			this.qDES = new NxtControl.GuiFramework.Rectangle();
			this.irDES = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or29 = new NxtControl.GuiFramework.FreeText();
			this.or30 = new NxtControl.GuiFramework.FreeText();
			this.or31 = new NxtControl.GuiFramework.FreeText();
			this.mft70001 = new NxtControl.GuiFramework.Rectangle();
			this.or32 = new NxtControl.GuiFramework.FreeText();
			this.os33 = new NxtControl.GuiFramework.Polygon();
			this.os34 = new NxtControl.GuiFramework.Polygon();
			this.os35 = new NxtControl.GuiFramework.Polygon();
			this.os36 = new NxtControl.GuiFramework.Polygon();
			this.qSLB = new NxtControl.GuiFramework.Rectangle();
			this.irSLB = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or37 = new NxtControl.GuiFramework.FreeText();
			this.or38 = new NxtControl.GuiFramework.FreeText();
			this.or39 = new NxtControl.GuiFramework.FreeText();
			this.or40 = new NxtControl.GuiFramework.FreeText();
			this.or41 = new NxtControl.GuiFramework.FreeText();
			this.qEST = new NxtControl.GuiFramework.Rectangle();
			this.irEST = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or42 = new NxtControl.GuiFramework.FreeText();
			this.or43 = new NxtControl.GuiFramework.FreeText();
			this.or44 = new NxtControl.GuiFramework.FreeText();
			this.or45 = new NxtControl.GuiFramework.FreeText();
			this.mlit90001 = new NxtControl.GuiFramework.Rectangle();
			this.or46 = new NxtControl.GuiFramework.FreeText();
			this.mlit90002 = new NxtControl.GuiFramework.Rectangle();
			this.or47 = new NxtControl.GuiFramework.FreeText();
			this.qFS = new NxtControl.GuiFramework.Rectangle();
			this.irFS = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or48 = new NxtControl.GuiFramework.FreeText();
			this.or49 = new NxtControl.GuiFramework.FreeText();
			this.or50 = new NxtControl.GuiFramework.FreeText();
			this.or51 = new NxtControl.GuiFramework.FreeText();
			this.or52 = new NxtControl.GuiFramework.FreeText();
			this.or53 = new NxtControl.GuiFramework.FreeText();
			this.or54 = new NxtControl.GuiFramework.FreeText();
			this.mft90001 = new NxtControl.GuiFramework.Rectangle();
			this.or55 = new NxtControl.GuiFramework.FreeText();
			this.mft90002 = new NxtControl.GuiFramework.Rectangle();
			this.or56 = new NxtControl.GuiFramework.FreeText();
			this.qAR = new NxtControl.GuiFramework.Rectangle();
			this.irAR = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.or57 = new NxtControl.GuiFramework.FreeText();
			this.or58 = new NxtControl.GuiFramework.FreeText();
			this.or59 = new NxtControl.GuiFramework.FreeText();
			this.mpit100001 = new NxtControl.GuiFramework.Rectangle();
			this.or60 = new NxtControl.GuiFramework.FreeText();
			this.mpit100002 = new NxtControl.GuiFramework.Rectangle();
			this.or61 = new NxtControl.GuiFramework.FreeText();
			this.os62 = new NxtControl.GuiFramework.Polygon();
			this.os63 = new NxtControl.GuiFramework.Polygon();
			this.btnResetGeral = new NxtControl.GuiFramework.DrawnButton();
			this.bs101 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.bs102 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.bs103 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.gm10001 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.gm10002 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.rt10001 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca();
			this.lit10003 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.gm1dif = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.gm2dif = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.gord1 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.gord2 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.gord3 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.ft4002 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.p4001 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4002 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4003 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.infNivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.infVazao = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.v4601 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.v4602 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.v4603 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.v4604 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.r1Nivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.r2Nivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.vc70001 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.ft70001 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.p4901 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4902 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4903 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.slbNivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.slbVazao = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.so901 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador();
			this.so902 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador();
			this.lit90001 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.lit90002 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.bo901 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal();
			this.bo902 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal();
			this.bo903 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal();
			this.br901 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.br902 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.ft90001 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.ft90002 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.pit100001 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.pit100002 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cardProcesso
			// 
			this.cardProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(1350D)), ((float)(682D)));
			this.cardProcesso.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(242)), ((byte)(242)), ((byte)(242))));
			this.cardProcesso.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cardProcesso.Name = "cardProcesso";
			this.cardProcesso.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qEEE
			// 
			this.qEEE.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(258D)), ((float)(310D)));
			this.qEEE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qEEE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qEEE.Name = "qEEE";
			this.qEEE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irEEE
			// 
			this.irEEE.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(20D)), ((float)(250D)), ((float)(26D)));
			this.irEEE.CanvasName = "EEE_BRUTO";
			this.irEEE.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irEEE.Name = "irEEE";
			this.irEEE.Text = "EEE BRUTO E GRADEAMENTO (100)  ›";
			// 
			// or1
			// 
			this.or1.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or1.Location = new NxtControl.Drawing.PointF(26D, 54D);
			this.or1.Name = "or1";
			this.or1.Text = "MOTORES";
			// 
			// or2
			// 
			this.or2.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or2.Location = new NxtControl.Drawing.PointF(26D, 222D);
			this.or2.Name = "or2";
			this.or2.Text = "MEDIÇÕES";
			// 
			// or3
			// 
			this.or3.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or3.Location = new NxtControl.Drawing.PointF(38.6667D, 125D);
			this.or3.Name = "or3";
			this.or3.Text = "100-BS-01";
			// 
			// or4
			// 
			this.or4.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or4.Location = new NxtControl.Drawing.PointF(118D, 125D);
			this.or4.Name = "or4";
			this.or4.Text = "100-BS-02";
			// 
			// or5
			// 
			this.or5.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or5.Location = new NxtControl.Drawing.PointF(197.333D, 125D);
			this.or5.Name = "or5";
			this.or5.Text = "100-BS-03";
			// 
			// or6
			// 
			this.or6.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or6.Location = new NxtControl.Drawing.PointF(38.6667D, 201D);
			this.or6.Name = "or6";
			this.or6.Text = "100-GM-01";
			// 
			// or7
			// 
			this.or7.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or7.Location = new NxtControl.Drawing.PointF(118D, 201D);
			this.or7.Name = "or7";
			this.or7.Text = "100-GM-02";
			// 
			// or8
			// 
			this.or8.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or8.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or8.Location = new NxtControl.Drawing.PointF(197.333D, 201D);
			this.or8.Name = "or8";
			this.or8.Text = "100-RT-01";
			// 
			// mlit10003
			// 
			this.mlit10003.Bounds = new NxtControl.Drawing.RectF(((float)(26D)), ((float)(238D)), ((float)(86D)), ((float)(24D)));
			this.mlit10003.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mlit10003.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mlit10003.Name = "mlit10003";
			this.mlit10003.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or9
			// 
			this.or9.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or9.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or9.Location = new NxtControl.Drawing.PointF(32D, 244D);
			this.or9.Name = "or9";
			this.or9.Text = "100-LIT-03";
			// 
			// mgm1dif
			// 
			this.mgm1dif.Bounds = new NxtControl.Drawing.RectF(((float)(26D)), ((float)(266D)), ((float)(86D)), ((float)(24D)));
			this.mgm1dif.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mgm1dif.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mgm1dif.Name = "mgm1dif";
			this.mgm1dif.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or10
			// 
			this.or10.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or10.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or10.Location = new NxtControl.Drawing.PointF(32D, 272D);
			this.or10.Name = "or10";
			this.or10.Text = "GM-01 difer.";
			// 
			// mgm2dif
			// 
			this.mgm2dif.Bounds = new NxtControl.Drawing.RectF(((float)(26D)), ((float)(294D)), ((float)(86D)), ((float)(24D)));
			this.mgm2dif.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mgm2dif.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mgm2dif.Name = "mgm2dif";
			this.mgm2dif.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or11
			// 
			this.or11.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or11.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or11.Location = new NxtControl.Drawing.PointF(32D, 300D);
			this.or11.Name = "or11";
			this.or11.Text = "GM-02 difer.";
			// 
			// qPRE
			// 
			this.qPRE.Bounds = new NxtControl.Drawing.RectF(((float)(285D)), ((float)(16D)), ((float)(258D)), ((float)(310D)));
			this.qPRE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qPRE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qPRE.Name = "qPRE";
			this.qPRE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irPRE
			// 
			this.irPRE.Bounds = new NxtControl.Drawing.RectF(((float)(289D)), ((float)(20D)), ((float)(250D)), ((float)(26D)));
			this.irPRE.CanvasName = "PRE_TRATAMENTO";
			this.irPRE.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irPRE.Name = "irPRE";
			this.irPRE.Text = "PRÉ-TRATAMENTO (200)  ›";
			// 
			// or12
			// 
			this.or12.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or12.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or12.Location = new NxtControl.Drawing.PointF(295D, 54D);
			this.or12.Name = "or12";
			this.or12.Text = "MOTORES";
			// 
			// or13
			// 
			this.or13.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or13.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or13.Location = new NxtControl.Drawing.PointF(295D, 222D);
			this.or13.Name = "or13";
			this.or13.Text = "MEDIÇÕES";
			// 
			// or14
			// 
			this.or14.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or14.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or14.Location = new NxtControl.Drawing.PointF(307.667D, 125D);
			this.or14.Name = "or14";
			this.or14.Text = "200-BR-03";
			// 
			// or15
			// 
			this.or15.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or15.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or15.Location = new NxtControl.Drawing.PointF(387D, 125D);
			this.or15.Name = "or15";
			this.or15.Text = "200-BR-04";
			// 
			// or16
			// 
			this.or16.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or16.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or16.Location = new NxtControl.Drawing.PointF(466.333D, 125D);
			this.or16.Name = "or16";
			this.or16.Text = "200-BR-05";
			// 
			// mft4002
			// 
			this.mft4002.Bounds = new NxtControl.Drawing.RectF(((float)(295D)), ((float)(238D)), ((float)(86D)), ((float)(24D)));
			this.mft4002.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mft4002.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mft4002.Name = "mft4002";
			this.mft4002.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or17
			// 
			this.or17.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or17.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or17.Location = new NxtControl.Drawing.PointF(301D, 244D);
			this.or17.Name = "or17";
			this.or17.Text = "40FT02";
			// 
			// qINF
			// 
			this.qINF.Bounds = new NxtControl.Drawing.RectF(((float)(554D)), ((float)(16D)), ((float)(258D)), ((float)(310D)));
			this.qINF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qINF.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qINF.Name = "qINF";
			this.qINF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irINF
			// 
			this.irINF.Bounds = new NxtControl.Drawing.RectF(((float)(558D)), ((float)(20D)), ((float)(250D)), ((float)(26D)));
			this.irINF.CanvasName = "INFLUENT_FEED";
			this.irINF.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irINF.Name = "irINF";
			this.irINF.Text = "NEREDA - ALIMENTAÇÃO  ›";
			// 
			// or18
			// 
			this.or18.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or18.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or18.Location = new NxtControl.Drawing.PointF(564D, 54D);
			this.or18.Name = "or18";
			this.or18.Text = "MOTORES";
			// 
			// or19
			// 
			this.or19.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or19.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or19.Location = new NxtControl.Drawing.PointF(564D, 222D);
			this.or19.Name = "or19";
			this.or19.Text = "MEDIÇÕES";
			// 
			// or20
			// 
			this.or20.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or20.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or20.Location = new NxtControl.Drawing.PointF(588.667D, 125D);
			this.or20.Name = "or20";
			this.or20.Text = "P4001";
			// 
			// or21
			// 
			this.or21.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or21.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or21.Location = new NxtControl.Drawing.PointF(668D, 125D);
			this.or21.Name = "or21";
			this.or21.Text = "P4002";
			// 
			// or22
			// 
			this.or22.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or22.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or22.Location = new NxtControl.Drawing.PointF(747.333D, 125D);
			this.or22.Name = "or22";
			this.or22.Text = "P4003";
			// 
			// qREA
			// 
			this.qREA.Bounds = new NxtControl.Drawing.RectF(((float)(823D)), ((float)(16D)), ((float)(258D)), ((float)(310D)));
			this.qREA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qREA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qREA.Name = "qREA";
			this.qREA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irREA
			// 
			this.irREA.Bounds = new NxtControl.Drawing.RectF(((float)(827D)), ((float)(20D)), ((float)(250D)), ((float)(26D)));
			this.irREA.CanvasName = "OVER_VIEW";
			this.irREA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irREA.Name = "irREA";
			this.irREA.Text = "NEREDA - REATORES E AERAÇÃO  ›";
			// 
			// or23
			// 
			this.or23.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or23.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or23.Location = new NxtControl.Drawing.PointF(833D, 54D);
			this.or23.Name = "or23";
			this.or23.Text = "MOTORES";
			// 
			// or24
			// 
			this.or24.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or24.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or24.Location = new NxtControl.Drawing.PointF(833D, 222D);
			this.or24.Name = "or24";
			this.or24.Text = "MEDIÇÕES";
			// 
			// or25
			// 
			this.or25.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or25.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or25.Location = new NxtControl.Drawing.PointF(857.667D, 125D);
			this.or25.Name = "or25";
			this.or25.Text = "V4601";
			// 
			// or26
			// 
			this.or26.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or26.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or26.Location = new NxtControl.Drawing.PointF(937D, 125D);
			this.or26.Name = "or26";
			this.or26.Text = "V4602";
			// 
			// or27
			// 
			this.or27.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or27.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or27.Location = new NxtControl.Drawing.PointF(1016.33D, 125D);
			this.or27.Name = "or27";
			this.or27.Text = "V4603";
			// 
			// or28
			// 
			this.or28.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or28.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or28.Location = new NxtControl.Drawing.PointF(857.667D, 201D);
			this.or28.Name = "or28";
			this.or28.Text = "V4604";
			// 
			// qDES
			// 
			this.qDES.Bounds = new NxtControl.Drawing.RectF(((float)(1092D)), ((float)(16D)), ((float)(258D)), ((float)(310D)));
			this.qDES.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qDES.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qDES.Name = "qDES";
			this.qDES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irDES
			// 
			this.irDES.Bounds = new NxtControl.Drawing.RectF(((float)(1096D)), ((float)(20D)), ((float)(250D)), ((float)(26D)));
			this.irDES.CanvasName = "DESINFECCAO";
			this.irDES.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irDES.Name = "irDES";
			this.irDES.Text = "DESINFECÇÃO UV (700)  ›";
			// 
			// or29
			// 
			this.or29.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or29.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or29.Location = new NxtControl.Drawing.PointF(1102D, 54D);
			this.or29.Name = "or29";
			this.or29.Text = "MOTORES";
			// 
			// or30
			// 
			this.or30.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or30.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or30.Location = new NxtControl.Drawing.PointF(1102D, 222D);
			this.or30.Name = "or30";
			this.or30.Text = "MEDIÇÕES";
			// 
			// or31
			// 
			this.or31.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or31.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or31.Location = new NxtControl.Drawing.PointF(1114.67D, 125D);
			this.or31.Name = "or31";
			this.or31.Text = "700-VC-01";
			// 
			// mft70001
			// 
			this.mft70001.Bounds = new NxtControl.Drawing.RectF(((float)(1102D)), ((float)(238D)), ((float)(86D)), ((float)(24D)));
			this.mft70001.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mft70001.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mft70001.Name = "mft70001";
			this.mft70001.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or32
			// 
			this.or32.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or32.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or32.Location = new NxtControl.Drawing.PointF(1108D, 244D);
			this.or32.Name = "or32";
			this.or32.Text = "700-FT-01";
			// 
			// os33
			// 
			this.os33.Bounds = new NxtControl.Drawing.RectF(((float)(278D)), ((float)(166D)), ((float)(10D)), ((float)(10D)));
			this.os33.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.os33.Closed = true;
			this.os33.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.os33.Name = "os33";
			this.os33.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.os33.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(278D, 166D),
			new NxtControl.Drawing.PointF(288D, 171D),
			new NxtControl.Drawing.PointF(278D, 176D)});
			// 
			// os34
			// 
			this.os34.Bounds = new NxtControl.Drawing.RectF(((float)(547D)), ((float)(166D)), ((float)(10D)), ((float)(10D)));
			this.os34.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.os34.Closed = true;
			this.os34.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.os34.Name = "os34";
			this.os34.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.os34.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(547D, 166D),
			new NxtControl.Drawing.PointF(557D, 171D),
			new NxtControl.Drawing.PointF(547D, 176D)});
			// 
			// os35
			// 
			this.os35.Bounds = new NxtControl.Drawing.RectF(((float)(816D)), ((float)(166D)), ((float)(10D)), ((float)(10D)));
			this.os35.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.os35.Closed = true;
			this.os35.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.os35.Name = "os35";
			this.os35.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.os35.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(816D, 166D),
			new NxtControl.Drawing.PointF(826D, 171D),
			new NxtControl.Drawing.PointF(816D, 176D)});
			// 
			// os36
			// 
			this.os36.Bounds = new NxtControl.Drawing.RectF(((float)(1085D)), ((float)(166D)), ((float)(10D)), ((float)(10D)));
			this.os36.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.os36.Closed = true;
			this.os36.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.os36.Name = "os36";
			this.os36.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.os36.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1085D, 166D),
			new NxtControl.Drawing.PointF(1095D, 171D),
			new NxtControl.Drawing.PointF(1085D, 176D)});
			// 
			// qSLB
			// 
			this.qSLB.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(338D)), ((float)(258D)), ((float)(310D)));
			this.qSLB.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qSLB.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qSLB.Name = "qSLB";
			this.qSLB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irSLB
			// 
			this.irSLB.Bounds = new NxtControl.Drawing.RectF(((float)(154D)), ((float)(342D)), ((float)(250D)), ((float)(26D)));
			this.irSLB.CanvasName = "SLUDGE_BUFFER";
			this.irSLB.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irSLB.Name = "irSLB";
			this.irSLB.Text = "NEREDA - BUFFER DE LODO  ›";
			// 
			// or37
			// 
			this.or37.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or37.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or37.Location = new NxtControl.Drawing.PointF(160D, 376D);
			this.or37.Name = "or37";
			this.or37.Text = "MOTORES";
			// 
			// or38
			// 
			this.or38.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or38.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or38.Location = new NxtControl.Drawing.PointF(160D, 544D);
			this.or38.Name = "or38";
			this.or38.Text = "MEDIÇÕES";
			// 
			// or39
			// 
			this.or39.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or39.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or39.Location = new NxtControl.Drawing.PointF(184.667D, 447D);
			this.or39.Name = "or39";
			this.or39.Text = "P4901";
			// 
			// or40
			// 
			this.or40.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or40.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or40.Location = new NxtControl.Drawing.PointF(264D, 447D);
			this.or40.Name = "or40";
			this.or40.Text = "P4902";
			// 
			// or41
			// 
			this.or41.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or41.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or41.Location = new NxtControl.Drawing.PointF(343.333D, 447D);
			this.or41.Name = "or41";
			this.or41.Text = "P4903";
			// 
			// qEST
			// 
			this.qEST.Bounds = new NxtControl.Drawing.RectF(((float)(419D)), ((float)(338D)), ((float)(258D)), ((float)(310D)));
			this.qEST.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qEST.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qEST.Name = "qEST";
			this.qEST.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irEST
			// 
			this.irEST.Bounds = new NxtControl.Drawing.RectF(((float)(423D)), ((float)(342D)), ((float)(250D)), ((float)(26D)));
			this.irEST.CanvasName = "ESTOCAGEM_LODO";
			this.irEST.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irEST.Name = "irEST";
			this.irEST.Text = "ESTOCAGEM DE LODO (900)  ›";
			// 
			// or42
			// 
			this.or42.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or42.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or42.Location = new NxtControl.Drawing.PointF(429D, 376D);
			this.or42.Name = "or42";
			this.or42.Text = "MOTORES";
			// 
			// or43
			// 
			this.or43.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or43.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or43.Location = new NxtControl.Drawing.PointF(429D, 544D);
			this.or43.Name = "or43";
			this.or43.Text = "MEDIÇÕES";
			// 
			// or44
			// 
			this.or44.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or44.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or44.Location = new NxtControl.Drawing.PointF(441.667D, 447D);
			this.or44.Name = "or44";
			this.or44.Text = "900-SO-01";
			// 
			// or45
			// 
			this.or45.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or45.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or45.Location = new NxtControl.Drawing.PointF(521D, 447D);
			this.or45.Name = "or45";
			this.or45.Text = "900-SO-02";
			// 
			// mlit90001
			// 
			this.mlit90001.Bounds = new NxtControl.Drawing.RectF(((float)(429D)), ((float)(560D)), ((float)(86D)), ((float)(24D)));
			this.mlit90001.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mlit90001.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mlit90001.Name = "mlit90001";
			this.mlit90001.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or46
			// 
			this.or46.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or46.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or46.Location = new NxtControl.Drawing.PointF(435D, 566D);
			this.or46.Name = "or46";
			this.or46.Text = "900-LIT-01";
			// 
			// mlit90002
			// 
			this.mlit90002.Bounds = new NxtControl.Drawing.RectF(((float)(429D)), ((float)(588D)), ((float)(86D)), ((float)(24D)));
			this.mlit90002.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mlit90002.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mlit90002.Name = "mlit90002";
			this.mlit90002.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or47
			// 
			this.or47.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or47.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or47.Location = new NxtControl.Drawing.PointF(435D, 594D);
			this.or47.Name = "or47";
			this.or47.Text = "900-LIT-02";
			// 
			// qFS
			// 
			this.qFS.Bounds = new NxtControl.Drawing.RectF(((float)(688D)), ((float)(338D)), ((float)(258D)), ((float)(310D)));
			this.qFS.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qFS.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qFS.Name = "qFS";
			this.qFS.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irFS
			// 
			this.irFS.Bounds = new NxtControl.Drawing.RectF(((float)(692D)), ((float)(342D)), ((float)(250D)), ((float)(26D)));
			this.irFS.CanvasName = "FASE_SOLIDA";
			this.irFS.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irFS.Name = "irFS";
			this.irFS.Text = "FASE SÓLIDA (900)  ›";
			// 
			// or48
			// 
			this.or48.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or48.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or48.Location = new NxtControl.Drawing.PointF(698D, 376D);
			this.or48.Name = "or48";
			this.or48.Text = "MOTORES";
			// 
			// or49
			// 
			this.or49.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or49.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or49.Location = new NxtControl.Drawing.PointF(698D, 544D);
			this.or49.Name = "or49";
			this.or49.Text = "MEDIÇÕES";
			// 
			// or50
			// 
			this.or50.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or50.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or50.Location = new NxtControl.Drawing.PointF(710.667D, 447D);
			this.or50.Name = "or50";
			this.or50.Text = "900-BO-01";
			// 
			// or51
			// 
			this.or51.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or51.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or51.Location = new NxtControl.Drawing.PointF(790D, 447D);
			this.or51.Name = "or51";
			this.or51.Text = "900-BO-02";
			// 
			// or52
			// 
			this.or52.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or52.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or52.Location = new NxtControl.Drawing.PointF(869.333D, 447D);
			this.or52.Name = "or52";
			this.or52.Text = "900-BO-03";
			// 
			// or53
			// 
			this.or53.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or53.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or53.Location = new NxtControl.Drawing.PointF(710.667D, 523D);
			this.or53.Name = "or53";
			this.or53.Text = "900-BR-01";
			// 
			// or54
			// 
			this.or54.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or54.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or54.Location = new NxtControl.Drawing.PointF(790D, 523D);
			this.or54.Name = "or54";
			this.or54.Text = "900-BR-02";
			// 
			// mft90001
			// 
			this.mft90001.Bounds = new NxtControl.Drawing.RectF(((float)(698D)), ((float)(560D)), ((float)(86D)), ((float)(24D)));
			this.mft90001.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mft90001.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mft90001.Name = "mft90001";
			this.mft90001.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or55
			// 
			this.or55.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or55.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or55.Location = new NxtControl.Drawing.PointF(704D, 566D);
			this.or55.Name = "or55";
			this.or55.Text = "900-FT-01";
			// 
			// mft90002
			// 
			this.mft90002.Bounds = new NxtControl.Drawing.RectF(((float)(698D)), ((float)(588D)), ((float)(86D)), ((float)(24D)));
			this.mft90002.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mft90002.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mft90002.Name = "mft90002";
			this.mft90002.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or56
			// 
			this.or56.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or56.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or56.Location = new NxtControl.Drawing.PointF(704D, 594D);
			this.or56.Name = "or56";
			this.or56.Text = "900-FT-02";
			// 
			// qAR
			// 
			this.qAR.Bounds = new NxtControl.Drawing.RectF(((float)(957D)), ((float)(338D)), ((float)(258D)), ((float)(310D)));
			this.qAR.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.qAR.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qAR.Name = "qAR";
			this.qAR.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irAR
			// 
			this.irAR.Bounds = new NxtControl.Drawing.RectF(((float)(961D)), ((float)(342D)), ((float)(250D)), ((float)(26D)));
			this.irAR.CanvasName = "AGUA_REUSO";
			this.irAR.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irAR.Name = "irAR";
			this.irAR.Text = "ÁGUA DE REÚSO (1000)  ›";
			// 
			// or57
			// 
			this.or57.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or57.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or57.Location = new NxtControl.Drawing.PointF(967D, 376D);
			this.or57.Name = "or57";
			this.or57.Text = "MOTORES";
			// 
			// or58
			// 
			this.or58.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or58.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.or58.Location = new NxtControl.Drawing.PointF(967D, 544D);
			this.or58.Name = "or58";
			this.or58.Text = "MEDIÇÕES";
			// 
			// or59
			// 
			this.or59.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.or59.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.or59.Location = new NxtControl.Drawing.PointF(967D, 408D);
			this.or59.Name = "or59";
			this.or59.Text = "sem motores nesta área";
			// 
			// mpit100001
			// 
			this.mpit100001.Bounds = new NxtControl.Drawing.RectF(((float)(967D)), ((float)(560D)), ((float)(86D)), ((float)(24D)));
			this.mpit100001.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mpit100001.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mpit100001.Name = "mpit100001";
			this.mpit100001.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or60
			// 
			this.or60.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or60.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or60.Location = new NxtControl.Drawing.PointF(973D, 566D);
			this.or60.Name = "or60";
			this.or60.Text = "1000-PIT-01";
			// 
			// mpit100002
			// 
			this.mpit100002.Bounds = new NxtControl.Drawing.RectF(((float)(967D)), ((float)(588D)), ((float)(86D)), ((float)(24D)));
			this.mpit100002.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(226)), ((byte)(226))));
			this.mpit100002.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mpit100002.Name = "mpit100002";
			this.mpit100002.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// or61
			// 
			this.or61.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.or61.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.or61.Location = new NxtControl.Drawing.PointF(973D, 594D);
			this.or61.Name = "or61";
			this.or61.Text = "1000-PIT-02";
			// 
			// os62
			// 
			this.os62.Bounds = new NxtControl.Drawing.RectF(((float)(412D)), ((float)(488D)), ((float)(10D)), ((float)(10D)));
			this.os62.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.os62.Closed = true;
			this.os62.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.os62.Name = "os62";
			this.os62.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.os62.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(412D, 488D),
			new NxtControl.Drawing.PointF(422D, 493D),
			new NxtControl.Drawing.PointF(412D, 498D)});
			// 
			// os63
			// 
			this.os63.Bounds = new NxtControl.Drawing.RectF(((float)(681D)), ((float)(488D)), ((float)(10D)), ((float)(10D)));
			this.os63.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.os63.Closed = true;
			this.os63.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.os63.Name = "os63";
			this.os63.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.os63.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(681D, 488D),
			new NxtControl.Drawing.PointF(691D, 493D),
			new NxtControl.Drawing.PointF(681D, 498D)});
			// 
			// btnResetGeral
			// 
			this.btnResetGeral.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(662D)), ((float)(126D)), ((float)(30D)));
			this.btnResetGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnResetGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnResetGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnResetGeral.Name = "btnResetGeral";
			this.btnResetGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnResetGeral.Radius = 2D;
			this.btnResetGeral.Text = "Reset geral";
			this.btnResetGeral.Use3DEffect = false;
			this.btnResetGeral.Click += new System.EventHandler(this.BtnResetGeralClick);
			// 
			// bs101
			// 
			this.bs101.BeginInit();
			this.bs101.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 40.84D, 66D);
			this.bs101.Name = "bs101";
			this.bs101.SecurityToken = ((uint)(4294967295u));
			this.bs101.TagName = "F8F84A6966B68EF2.BS_100_01";
			this.bs101.EndInit();
			// 
			// bs102
			// 
			this.bs102.BeginInit();
			this.bs102.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 120.18D, 66D);
			this.bs102.Name = "bs102";
			this.bs102.SecurityToken = ((uint)(4294967295u));
			this.bs102.TagName = "F8F84A6966B68EF2.BS_100_02";
			this.bs102.EndInit();
			// 
			// bs103
			// 
			this.bs103.BeginInit();
			this.bs103.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 199.51D, 66D);
			this.bs103.Name = "bs103";
			this.bs103.SecurityToken = ((uint)(4294967295u));
			this.bs103.TagName = "F8F84A6966B68EF2.BS_100_03";
			this.bs103.EndInit();
			// 
			// gm10001
			// 
			this.gm10001.BeginInit();
			this.gm10001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4375D, 0D, 0D, 0.4375D, 49.92D, 142D);
			this.gm10001.Name = "gm10001";
			this.gm10001.SecurityToken = ((uint)(4294967295u));
			this.gm10001.TagName = "D8ECF975D72A6254.GM_100_01.Grade_Mecanizada_Inovaisa1";
			this.gm10001.EndInit();
			// 
			// gm10002
			// 
			this.gm10002.BeginInit();
			this.gm10002.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4375D, 0D, 0D, 0.4375D, 129.25D, 142D);
			this.gm10002.Name = "gm10002";
			this.gm10002.SecurityToken = ((uint)(4294967295u));
			this.gm10002.TagName = "D8ECF975D72A6254.GM_100_02.Grade_Mecanizada_Inovaisa1";
			this.gm10002.EndInit();
			// 
			// rt10001
			// 
			this.rt10001.BeginInit();
			this.rt10001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.327536D, 0D, 0D, 0.327536D, 186.67D, 183.59D);
			this.rt10001.Name = "rt10001";
			this.rt10001.SecurityToken = ((uint)(4294967295u));
			this.rt10001.TagName = "D8ECF975D72A6254.RT_100_01";
			this.rt10001.EndInit();
			// 
			// lit10003
			// 
			this.lit10003.BeginInit();
			this.lit10003.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 114D, 238D);
			this.lit10003.Name = "lit10003";
			this.lit10003.SecurityToken = ((uint)(4294967295u));
			this.lit10003.TagName = "F8F84A6966B68EF2.LIT_100_03";
			this.lit10003.EndInit();
			// 
			// gm1dif
			// 
			this.gm1dif.BeginInit();
			this.gm1dif.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 114D, 266D);
			this.gm1dif.Name = "gm1dif";
			this.gm1dif.SecurityToken = ((uint)(4294967295u));
			this.gm1dif.TagName = "D8ECF975D72A6254.GM_100_01.SensorDiferencial";
			this.gm1dif.EndInit();
			// 
			// gm2dif
			// 
			this.gm2dif.BeginInit();
			this.gm2dif.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 114D, 294D);
			this.gm2dif.Name = "gm2dif";
			this.gm2dif.SecurityToken = ((uint)(4294967295u));
			this.gm2dif.TagName = "D8ECF975D72A6254.GM_100_02.SensorDiferencial";
			this.gm2dif.EndInit();
			// 
			// gord1
			// 
			this.gord1.BeginInit();
			this.gord1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 309.84D, 66D);
			this.gord1.Name = "gord1";
			this.gord1.SecurityToken = ((uint)(4294967295u));
			this.gord1.TagName = "8562B7A48F2304C1.BombaGordura";
			this.gord1.EndInit();
			// 
			// gord2
			// 
			this.gord2.BeginInit();
			this.gord2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 389.18D, 66D);
			this.gord2.Name = "gord2";
			this.gord2.SecurityToken = ((uint)(4294967295u));
			this.gord2.TagName = "1FBDCF6E96E37765.BombaGordura";
			this.gord2.EndInit();
			// 
			// gord3
			// 
			this.gord3.BeginInit();
			this.gord3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 468.51D, 66D);
			this.gord3.Name = "gord3";
			this.gord3.SecurityToken = ((uint)(4294967295u));
			this.gord3.TagName = "EB77BC463289AB0B.BombaGordura";
			this.gord3.EndInit();
			// 
			// ft4002
			// 
			this.ft4002.BeginInit();
			this.ft4002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 383D, 238D);
			this.ft4002.Name = "ft4002";
			this.ft4002.SecurityToken = ((uint)(4294967295u));
			this.ft4002.TagName = "1A8A218FB56FB248";
			this.ft4002.EndInit();
			// 
			// p4001
			// 
			this.p4001.BeginInit();
			this.p4001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 575.67D, 76.28D);
			this.p4001.Name = "p4001";
			this.p4001.SecurityToken = ((uint)(4294967295u));
			this.p4001.TagName = "DE5E3E2FE4C5E300.Actuators.FeedReactorPump01";
			this.p4001.EndInit();
			// 
			// p4002
			// 
			this.p4002.BeginInit();
			this.p4002.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 655D, 76.28D);
			this.p4002.Name = "p4002";
			this.p4002.SecurityToken = ((uint)(4294967295u));
			this.p4002.TagName = "DE5E3E2FE4C5E300.Actuators.FeedReactorPump02";
			this.p4002.EndInit();
			// 
			// p4003
			// 
			this.p4003.BeginInit();
			this.p4003.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 734.33D, 76.28D);
			this.p4003.Name = "p4003";
			this.p4003.SecurityToken = ((uint)(4294967295u));
			this.p4003.TagName = "DE5E3E2FE4C5E300.Actuators.FeedReactorPump03";
			this.p4003.EndInit();
			// 
			// infNivel
			// 
			this.infNivel.BeginInit();
			this.infNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.959677D, 0D, 0D, 0.959677D, 564D, 238D);
			this.infNivel.Name = "infNivel";
			this.infNivel.SecurityToken = ((uint)(4294967295u));
			this.infNivel.TagName = "DE5E3E2FE4C5E300.Sensors.LevelPvInfluentBuffer";
			this.infNivel.EndInit();
			// 
			// infVazao
			// 
			this.infVazao.BeginInit();
			this.infVazao.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.959677D, 0D, 0D, 0.959677D, 564D, 266D);
			this.infVazao.Name = "infVazao";
			this.infVazao.SecurityToken = ((uint)(4294967295u));
			this.infVazao.TagName = "DE5E3E2FE4C5E300.Sensors.FeedReactorFlowPv";
			this.infVazao.EndInit();
			// 
			// v4601
			// 
			this.v4601.BeginInit();
			this.v4601.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 845.24D, 66D);
			this.v4601.Name = "v4601";
			this.v4601.SecurityToken = ((uint)(4294967295u));
			this.v4601.TagName = "6307B68BAFBA5753.Actuators.V4601";
			this.v4601.EndInit();
			// 
			// v4602
			// 
			this.v4602.BeginInit();
			this.v4602.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 924.57D, 66D);
			this.v4602.Name = "v4602";
			this.v4602.SecurityToken = ((uint)(4294967295u));
			this.v4602.TagName = "6307B68BAFBA5753.Actuators.V4602";
			this.v4602.EndInit();
			// 
			// v4603
			// 
			this.v4603.BeginInit();
			this.v4603.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 1003.9D, 66D);
			this.v4603.Name = "v4603";
			this.v4603.SecurityToken = ((uint)(4294967295u));
			this.v4603.TagName = "6307B68BAFBA5753.Actuators.V4603";
			this.v4603.EndInit();
			// 
			// v4604
			// 
			this.v4604.BeginInit();
			this.v4604.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 845.24D, 142D);
			this.v4604.Name = "v4604";
			this.v4604.SecurityToken = ((uint)(4294967295u));
			this.v4604.TagName = "6307B68BAFBA5753.Actuators.V4604";
			this.v4604.EndInit();
			// 
			// r1Nivel
			// 
			this.r1Nivel.BeginInit();
			this.r1Nivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.959677D, 0D, 0D, 0.959677D, 833D, 238D);
			this.r1Nivel.Name = "r1Nivel";
			this.r1Nivel.SecurityToken = ((uint)(4294967295u));
			this.r1Nivel.TagName = "D41247DF3E1D30DC.Sensors.LevelMeasurementReactor";
			this.r1Nivel.EndInit();
			// 
			// r2Nivel
			// 
			this.r2Nivel.BeginInit();
			this.r2Nivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.959677D, 0D, 0D, 0.959677D, 833D, 266D);
			this.r2Nivel.Name = "r2Nivel";
			this.r2Nivel.SecurityToken = ((uint)(4294967295u));
			this.r2Nivel.TagName = "1D81A826384C2197.Sensors.LevelMeasurementReactor";
			this.r2Nivel.EndInit();
			// 
			// vc70001
			// 
			this.vc70001.BeginInit();
			this.vc70001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.430769D, 0D, 0D, 0.430769D, 1113.67D, 68.58D);
			this.vc70001.Name = "vc70001";
			this.vc70001.SecurityToken = ((uint)(4294967295u));
			this.vc70001.TagName = "8005CB77235157DB.VC_700_01";
			this.vc70001.EndInit();
			// 
			// ft70001
			// 
			this.ft70001.BeginInit();
			this.ft70001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1190D, 238D);
			this.ft70001.Name = "ft70001";
			this.ft70001.SecurityToken = ((uint)(4294967295u));
			this.ft70001.TagName = "8005CB77235157DB.FT_700_01";
			this.ft70001.EndInit();
			// 
			// p4901
			// 
			this.p4901.BeginInit();
			this.p4901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 171.67D, 398.28D);
			this.p4901.Name = "p4901";
			this.p4901.SecurityToken = ((uint)(4294967295u));
			this.p4901.TagName = "9AA3696311BF0C3E.Actuators.Pump1";
			this.p4901.EndInit();
			// 
			// p4902
			// 
			this.p4902.BeginInit();
			this.p4902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 251D, 398.28D);
			this.p4902.Name = "p4902";
			this.p4902.SecurityToken = ((uint)(4294967295u));
			this.p4902.TagName = "9AA3696311BF0C3E.Actuators.Pump2";
			this.p4902.EndInit();
			// 
			// p4903
			// 
			this.p4903.BeginInit();
			this.p4903.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 330.33D, 398.28D);
			this.p4903.Name = "p4903";
			this.p4903.SecurityToken = ((uint)(4294967295u));
			this.p4903.TagName = "9AA3696311BF0C3E.Actuators.Pump3";
			this.p4903.EndInit();
			// 
			// slbNivel
			// 
			this.slbNivel.BeginInit();
			this.slbNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.959677D, 0D, 0D, 0.959677D, 160D, 560D);
			this.slbNivel.Name = "slbNivel";
			this.slbNivel.SecurityToken = ((uint)(4294967295u));
			this.slbNivel.TagName = "9AA3696311BF0C3E.Sensors.LevelMeasurementSludgeBuffer";
			this.slbNivel.EndInit();
			// 
			// slbVazao
			// 
			this.slbVazao.BeginInit();
			this.slbVazao.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.959677D, 0D, 0D, 0.959677D, 160D, 588D);
			this.slbVazao.Name = "slbVazao";
			this.slbVazao.SecurityToken = ((uint)(4294967295u));
			this.slbVazao.TagName = "9AA3696311BF0C3E.Sensors.FlowMeasurementDischargeSludge";
			this.slbVazao.EndInit();
			// 
			// so901
			// 
			this.so901.BeginInit();
			this.so901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.370861D, 0D, 0D, 0.370861D, 444.93D, 388D);
			this.so901.Name = "so901";
			this.so901.SecurityToken = ((uint)(4294967295u));
			this.so901.TagName = "91957488A3380C04.SO_900_01";
			this.so901.EndInit();
			// 
			// so902
			// 
			this.so902.BeginInit();
			this.so902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.370861D, 0D, 0D, 0.370861D, 524.26D, 388D);
			this.so902.Name = "so902";
			this.so902.SecurityToken = ((uint)(4294967295u));
			this.so902.TagName = "91957488A3380C04.SO_900_02";
			this.so902.EndInit();
			// 
			// lit90001
			// 
			this.lit90001.BeginInit();
			this.lit90001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 517D, 560D);
			this.lit90001.Name = "lit90001";
			this.lit90001.SecurityToken = ((uint)(4294967295u));
			this.lit90001.TagName = "91957488A3380C04.LIT_900_01";
			this.lit90001.EndInit();
			// 
			// lit90002
			// 
			this.lit90002.BeginInit();
			this.lit90002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 517D, 588D);
			this.lit90002.Name = "lit90002";
			this.lit90002.SecurityToken = ((uint)(4294967295u));
			this.lit90002.TagName = "91957488A3380C04.LIT_900_02";
			this.lit90002.EndInit();
			// 
			// bo901
			// 
			this.bo901.BeginInit();
			this.bo901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.339339D, 0D, 0D, 0.339339D, 700D, 401.24D);
			this.bo901.Name = "bo901";
			this.bo901.SecurityToken = ((uint)(4294967295u));
			this.bo901.TagName = "91957488A3380C04.BO_900_01";
			this.bo901.EndInit();
			// 
			// bo902
			// 
			this.bo902.BeginInit();
			this.bo902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.339339D, 0D, 0D, 0.339339D, 779.33D, 401.24D);
			this.bo902.Name = "bo902";
			this.bo902.SecurityToken = ((uint)(4294967295u));
			this.bo902.TagName = "91957488A3380C04.BO_900_02";
			this.bo902.EndInit();
			// 
			// bo903
			// 
			this.bo903.BeginInit();
			this.bo903.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.339339D, 0D, 0D, 0.339339D, 858.67D, 401.24D);
			this.bo903.Name = "bo903";
			this.bo903.SecurityToken = ((uint)(4294967295u));
			this.bo903.TagName = "91957488A3380C04.BO_900_03";
			this.bo903.EndInit();
			// 
			// br901
			// 
			this.br901.BeginInit();
			this.br901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 712.84D, 464D);
			this.br901.Name = "br901";
			this.br901.SecurityToken = ((uint)(4294967295u));
			this.br901.TagName = "91957488A3380C04.BR_900_01";
			this.br901.EndInit();
			// 
			// br902
			// 
			this.br902.BeginInit();
			this.br902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 792.18D, 464D);
			this.br902.Name = "br902";
			this.br902.SecurityToken = ((uint)(4294967295u));
			this.br902.TagName = "91957488A3380C04.BR_900_02";
			this.br902.EndInit();
			// 
			// ft90001
			// 
			this.ft90001.BeginInit();
			this.ft90001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 786D, 560D);
			this.ft90001.Name = "ft90001";
			this.ft90001.SecurityToken = ((uint)(4294967295u));
			this.ft90001.TagName = "91957488A3380C04.FT_900_01";
			this.ft90001.EndInit();
			// 
			// ft90002
			// 
			this.ft90002.BeginInit();
			this.ft90002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 786D, 588D);
			this.ft90002.Name = "ft90002";
			this.ft90002.SecurityToken = ((uint)(4294967295u));
			this.ft90002.TagName = "91957488A3380C04.FT_900_02";
			this.ft90002.EndInit();
			// 
			// pit100001
			// 
			this.pit100001.BeginInit();
			this.pit100001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1055D, 560D);
			this.pit100001.Name = "pit100001";
			this.pit100001.SecurityToken = ((uint)(4294967295u));
			this.pit100001.TagName = "F134E1AF157DF837.PIT_1000_01";
			this.pit100001.EndInit();
			// 
			// pit100002
			// 
			this.pit100002.BeginInit();
			this.pit100002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1055D, 588D);
			this.pit100002.Name = "pit100002";
			this.pit100002.SecurityToken = ((uint)(4294967295u));
			this.pit100002.TagName = "F134E1AF157DF837.PIT_1000_02";
			this.pit100002.EndInit();
			// 
			// VISAO_GERAL
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.qEEE,
			this.irEEE,
			this.or1,
			this.or2,
			this.or3,
			this.or4,
			this.or5,
			this.or6,
			this.or7,
			this.or8,
			this.mlit10003,
			this.or9,
			this.mgm1dif,
			this.or10,
			this.mgm2dif,
			this.or11,
			this.qPRE,
			this.irPRE,
			this.or12,
			this.or13,
			this.or14,
			this.or15,
			this.or16,
			this.mft4002,
			this.or17,
			this.qINF,
			this.irINF,
			this.or18,
			this.or19,
			this.or20,
			this.or21,
			this.or22,
			this.qREA,
			this.irREA,
			this.or23,
			this.or24,
			this.or25,
			this.or26,
			this.or27,
			this.or28,
			this.qDES,
			this.irDES,
			this.or29,
			this.or30,
			this.or31,
			this.mft70001,
			this.or32,
			this.os33,
			this.os34,
			this.os35,
			this.os36,
			this.qSLB,
			this.irSLB,
			this.or37,
			this.or38,
			this.or39,
			this.or40,
			this.or41,
			this.qEST,
			this.irEST,
			this.or42,
			this.or43,
			this.or44,
			this.or45,
			this.mlit90001,
			this.or46,
			this.mlit90002,
			this.or47,
			this.qFS,
			this.irFS,
			this.or48,
			this.or49,
			this.or50,
			this.or51,
			this.or52,
			this.or53,
			this.or54,
			this.mft90001,
			this.or55,
			this.mft90002,
			this.or56,
			this.qAR,
			this.irAR,
			this.or57,
			this.or58,
			this.or59,
			this.mpit100001,
			this.or60,
			this.mpit100002,
			this.or61,
			this.os62,
			this.os63,
			this.bs101,
			this.bs102,
			this.bs103,
			this.gm10001,
			this.gm10002,
			this.rt10001,
			this.lit10003,
			this.gm1dif,
			this.gm2dif,
			this.gord1,
			this.gord2,
			this.gord3,
			this.ft4002,
			this.p4001,
			this.p4002,
			this.p4003,
			this.infNivel,
			this.infVazao,
			this.v4601,
			this.v4602,
			this.v4603,
			this.v4604,
			this.r1Nivel,
			this.r2Nivel,
			this.vc70001,
			this.ft70001,
			this.p4901,
			this.p4902,
			this.p4903,
			this.slbNivel,
			this.slbVazao,
			this.so901,
			this.so902,
			this.lit90001,
			this.lit90002,
			this.bo901,
			this.bo902,
			this.bo903,
			this.br901,
			this.br902,
			this.ft90001,
			this.ft90002,
			this.pit100001,
			this.pit100002,
			this.btnResetGeral});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.Rectangle qEEE;
		private NxtControl.GuiFramework.ChangeCanvasButton irEEE;
		private NxtControl.GuiFramework.FreeText or1;
		private NxtControl.GuiFramework.FreeText or2;
		private NxtControl.GuiFramework.FreeText or3;
		private NxtControl.GuiFramework.FreeText or4;
		private NxtControl.GuiFramework.FreeText or5;
		private NxtControl.GuiFramework.FreeText or6;
		private NxtControl.GuiFramework.FreeText or7;
		private NxtControl.GuiFramework.FreeText or8;
		private NxtControl.GuiFramework.Rectangle mlit10003;
		private NxtControl.GuiFramework.FreeText or9;
		private NxtControl.GuiFramework.Rectangle mgm1dif;
		private NxtControl.GuiFramework.FreeText or10;
		private NxtControl.GuiFramework.Rectangle mgm2dif;
		private NxtControl.GuiFramework.FreeText or11;
		private NxtControl.GuiFramework.Rectangle qPRE;
		private NxtControl.GuiFramework.ChangeCanvasButton irPRE;
		private NxtControl.GuiFramework.FreeText or12;
		private NxtControl.GuiFramework.FreeText or13;
		private NxtControl.GuiFramework.FreeText or14;
		private NxtControl.GuiFramework.FreeText or15;
		private NxtControl.GuiFramework.FreeText or16;
		private NxtControl.GuiFramework.Rectangle mft4002;
		private NxtControl.GuiFramework.FreeText or17;
		private NxtControl.GuiFramework.Rectangle qINF;
		private NxtControl.GuiFramework.ChangeCanvasButton irINF;
		private NxtControl.GuiFramework.FreeText or18;
		private NxtControl.GuiFramework.FreeText or19;
		private NxtControl.GuiFramework.FreeText or20;
		private NxtControl.GuiFramework.FreeText or21;
		private NxtControl.GuiFramework.FreeText or22;
		private NxtControl.GuiFramework.Rectangle qREA;
		private NxtControl.GuiFramework.ChangeCanvasButton irREA;
		private NxtControl.GuiFramework.FreeText or23;
		private NxtControl.GuiFramework.FreeText or24;
		private NxtControl.GuiFramework.FreeText or25;
		private NxtControl.GuiFramework.FreeText or26;
		private NxtControl.GuiFramework.FreeText or27;
		private NxtControl.GuiFramework.FreeText or28;
		private NxtControl.GuiFramework.Rectangle qDES;
		private NxtControl.GuiFramework.ChangeCanvasButton irDES;
		private NxtControl.GuiFramework.FreeText or29;
		private NxtControl.GuiFramework.FreeText or30;
		private NxtControl.GuiFramework.FreeText or31;
		private NxtControl.GuiFramework.Rectangle mft70001;
		private NxtControl.GuiFramework.FreeText or32;
		private NxtControl.GuiFramework.Polygon os33;
		private NxtControl.GuiFramework.Polygon os34;
		private NxtControl.GuiFramework.Polygon os35;
		private NxtControl.GuiFramework.Polygon os36;
		private NxtControl.GuiFramework.Rectangle qSLB;
		private NxtControl.GuiFramework.ChangeCanvasButton irSLB;
		private NxtControl.GuiFramework.FreeText or37;
		private NxtControl.GuiFramework.FreeText or38;
		private NxtControl.GuiFramework.FreeText or39;
		private NxtControl.GuiFramework.FreeText or40;
		private NxtControl.GuiFramework.FreeText or41;
		private NxtControl.GuiFramework.Rectangle qEST;
		private NxtControl.GuiFramework.ChangeCanvasButton irEST;
		private NxtControl.GuiFramework.FreeText or42;
		private NxtControl.GuiFramework.FreeText or43;
		private NxtControl.GuiFramework.FreeText or44;
		private NxtControl.GuiFramework.FreeText or45;
		private NxtControl.GuiFramework.Rectangle mlit90001;
		private NxtControl.GuiFramework.FreeText or46;
		private NxtControl.GuiFramework.Rectangle mlit90002;
		private NxtControl.GuiFramework.FreeText or47;
		private NxtControl.GuiFramework.Rectangle qFS;
		private NxtControl.GuiFramework.ChangeCanvasButton irFS;
		private NxtControl.GuiFramework.FreeText or48;
		private NxtControl.GuiFramework.FreeText or49;
		private NxtControl.GuiFramework.FreeText or50;
		private NxtControl.GuiFramework.FreeText or51;
		private NxtControl.GuiFramework.FreeText or52;
		private NxtControl.GuiFramework.FreeText or53;
		private NxtControl.GuiFramework.FreeText or54;
		private NxtControl.GuiFramework.Rectangle mft90001;
		private NxtControl.GuiFramework.FreeText or55;
		private NxtControl.GuiFramework.Rectangle mft90002;
		private NxtControl.GuiFramework.FreeText or56;
		private NxtControl.GuiFramework.Rectangle qAR;
		private NxtControl.GuiFramework.ChangeCanvasButton irAR;
		private NxtControl.GuiFramework.FreeText or57;
		private NxtControl.GuiFramework.FreeText or58;
		private NxtControl.GuiFramework.FreeText or59;
		private NxtControl.GuiFramework.Rectangle mpit100001;
		private NxtControl.GuiFramework.FreeText or60;
		private NxtControl.GuiFramework.Rectangle mpit100002;
		private NxtControl.GuiFramework.FreeText or61;
		private NxtControl.GuiFramework.Polygon os62;
		private NxtControl.GuiFramework.Polygon os63;
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bs101;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bs102;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bs103;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade gm10001;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade gm10002;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca rt10001;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto lit10003;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto gm1dif;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto gm2dif;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba gord1;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba gord2;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba gord3;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft4002;
		private SE.Nereda.Symbols.Motor_VS.sPump p4001;
		private SE.Nereda.Symbols.Motor_VS.sPump p4002;
		private SE.Nereda.Symbols.Motor_VS.sPump p4003;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 infNivel;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 infVazao;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4601;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4602;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4603;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4604;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 r1Nivel;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 r2Nivel;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula vc70001;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft70001;
		private SE.Nereda.Symbols.Motor_VS.sPump p4901;
		private SE.Nereda.Symbols.Motor_VS.sPump p4902;
		private SE.Nereda.Symbols.Motor_VS.sPump p4903;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 slbNivel;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 slbVazao;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador so901;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador so902;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto lit90001;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto lit90002;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal bo901;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal bo902;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal bo903;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba br901;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba br902;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft90001;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft90002;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto pit100001;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto pit100002;
		#endregion
	}
}
