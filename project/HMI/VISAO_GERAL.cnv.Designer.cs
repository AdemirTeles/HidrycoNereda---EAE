/*
 * Hidryco - tela VISAO_GERAL: fluxograma da ETE (agua em cima, lodo embaixo), fase dos reatores e medicoes-chave
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
			this.irEEE = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irPRE = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irINF = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irREA = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irDES = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irSLB = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irEST = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irFS = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irAR = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.bs101 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.bs102 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.bs103 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.gm10001 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.gm10002 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.rt10001 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca();
			this.lit10003 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.gord1 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.gord2 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.gord3 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.ft4002 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.p4001 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4002 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4003 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.infNivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.infVazao = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.r1Nivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.r2Nivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.v4601 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.v4602 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.v4603 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.v4604 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.vc70001 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.ft70001 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.slbNivel = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.slbVazao = new SE.Nereda.Symbols.AnalogInput.sDisplayPv1();
			this.p4901 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4902 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.p4903 = new SE.Nereda.Symbols.Motor_VS.sPump();
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
			this.btnResetGeral = new NxtControl.GuiFramework.DrawnButton();
			this.btnReconhecerGeral = new NxtControl.GuiFramework.DrawnButton();
			this.repAI1 = new SE.Nereda.Symbols.AnalogInputBase.sInstanceName();
			this.repHH1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repH1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repL1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repLL1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repAI2 = new SE.Nereda.Symbols.AnalogInputBase.sInstanceName();
			this.repHH2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repH2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repL2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repLL2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repAIft = new SE.Nereda.Symbols.AnalogInputBase.sInstanceName();
			this.repHHft = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repHft = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repLft = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repLLft = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.qEEE = new NxtControl.GuiFramework.Rectangle();
			this.tx1 = new NxtControl.GuiFramework.Rectangle();
			this.tx2 = new NxtControl.GuiFramework.Rectangle();
			this.lgP4001 = new NxtControl.GuiFramework.Rectangle();
			this.lgP4002 = new NxtControl.GuiFramework.Rectangle();
			this.lgP4003 = new NxtControl.GuiFramework.Rectangle();
			this.lgV4601 = new NxtControl.GuiFramework.Rectangle();
			this.lgV4602 = new NxtControl.GuiFramework.Rectangle();
			this.lgV4603 = new NxtControl.GuiFramework.Rectangle();
			this.lgV4604 = new NxtControl.GuiFramework.Rectangle();
			this.lgP4901 = new NxtControl.GuiFramework.Rectangle();
			this.lgP4902 = new NxtControl.GuiFramework.Rectangle();
			this.lgP4903 = new NxtControl.GuiFramework.Rectangle();
			this.tx3 = new NxtControl.GuiFramework.Rectangle();
			this.tx4 = new NxtControl.GuiFramework.Rectangle();
			this.tx5 = new NxtControl.GuiFramework.Rectangle();
			this.tx6 = new NxtControl.GuiFramework.Rectangle();
			this.tx7 = new NxtControl.GuiFramework.Rectangle();
			this.tx8 = new NxtControl.GuiFramework.Rectangle();
			this.tx9 = new NxtControl.GuiFramework.Rectangle();
			this.qPRE = new NxtControl.GuiFramework.Rectangle();
			this.tx10 = new NxtControl.GuiFramework.Rectangle();
			this.tx11 = new NxtControl.GuiFramework.Rectangle();
			this.tx12 = new NxtControl.GuiFramework.Rectangle();
			this.tx13 = new NxtControl.GuiFramework.Rectangle();
			this.tx14 = new NxtControl.GuiFramework.Rectangle();
			this.tx15 = new NxtControl.GuiFramework.Rectangle();
			this.qINF = new NxtControl.GuiFramework.Rectangle();
			this.tx16 = new NxtControl.GuiFramework.Rectangle();
			this.tx17 = new NxtControl.GuiFramework.Rectangle();
			this.tx18 = new NxtControl.GuiFramework.Rectangle();
			this.pctInf = new SE.Nereda.Symbols.AnalogInput.sPorcentagem();
			this.tx19 = new NxtControl.GuiFramework.Rectangle();
			this.qREA = new NxtControl.GuiFramework.Rectangle();
			this.tx20 = new NxtControl.GuiFramework.Rectangle();
			this.faseR1 = new SE.Nereda.Symbols.NeredaReactor.sFase();
			this.tx21 = new NxtControl.GuiFramework.Rectangle();
			this.pctR1 = new SE.Nereda.Symbols.AnalogInput.sPorcentagem();
			this.faseR2 = new SE.Nereda.Symbols.NeredaReactor.sFase();
			this.tx22 = new NxtControl.GuiFramework.Rectangle();
			this.pctR2 = new SE.Nereda.Symbols.AnalogInput.sPorcentagem();
			this.tx23 = new NxtControl.GuiFramework.Rectangle();
			this.qDES = new NxtControl.GuiFramework.Rectangle();
			this.tx24 = new NxtControl.GuiFramework.Rectangle();
			this.tx25 = new NxtControl.GuiFramework.Rectangle();
			this.tx26 = new NxtControl.GuiFramework.Rectangle();
			this.tx27 = new NxtControl.GuiFramework.Rectangle();
			this.qSLB = new NxtControl.GuiFramework.Rectangle();
			this.tx28 = new NxtControl.GuiFramework.Rectangle();
			this.faseSB = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sFase();
			this.tx29 = new NxtControl.GuiFramework.Rectangle();
			this.pctSB = new SE.Nereda.Symbols.AnalogInput.sPorcentagem();
			this.tx30 = new NxtControl.GuiFramework.Rectangle();
			this.tx31 = new NxtControl.GuiFramework.Rectangle();
			this.qEST = new NxtControl.GuiFramework.Rectangle();
			this.tx32 = new NxtControl.GuiFramework.Rectangle();
			this.tx33 = new NxtControl.GuiFramework.Rectangle();
			this.tx34 = new NxtControl.GuiFramework.Rectangle();
			this.tx35 = new NxtControl.GuiFramework.Rectangle();
			this.tx36 = new NxtControl.GuiFramework.Rectangle();
			this.tx37 = new NxtControl.GuiFramework.Rectangle();
			this.qFS = new NxtControl.GuiFramework.Rectangle();
			this.tx38 = new NxtControl.GuiFramework.Rectangle();
			this.tx39 = new NxtControl.GuiFramework.Rectangle();
			this.tx40 = new NxtControl.GuiFramework.Rectangle();
			this.tx41 = new NxtControl.GuiFramework.Rectangle();
			this.tx42 = new NxtControl.GuiFramework.Rectangle();
			this.tx43 = new NxtControl.GuiFramework.Rectangle();
			this.tx44 = new NxtControl.GuiFramework.Rectangle();
			this.tx45 = new NxtControl.GuiFramework.Rectangle();
			this.tx46 = new NxtControl.GuiFramework.Rectangle();
			this.qAR = new NxtControl.GuiFramework.Rectangle();
			this.tx47 = new NxtControl.GuiFramework.Rectangle();
			this.tx48 = new NxtControl.GuiFramework.Rectangle();
			this.tx49 = new NxtControl.GuiFramework.Rectangle();
			this.tb1 = new NxtControl.GuiFramework.Pipe();
			this.sa1 = new NxtControl.GuiFramework.Polygon();
			this.tb2 = new NxtControl.GuiFramework.Pipe();
			this.sa2 = new NxtControl.GuiFramework.Polygon();
			this.tb3 = new NxtControl.GuiFramework.Pipe();
			this.sa3 = new NxtControl.GuiFramework.Polygon();
			this.tb4 = new NxtControl.GuiFramework.Pipe();
			this.sa4 = new NxtControl.GuiFramework.Polygon();
			this.tb5 = new NxtControl.GuiFramework.Pipe();
			this.sa5 = new NxtControl.GuiFramework.Polygon();
			this.tb6 = new NxtControl.GuiFramework.Pipe();
			this.sa6 = new NxtControl.GuiFramework.Polygon();
			this.tb7 = new NxtControl.GuiFramework.Pipe();
			this.sa7 = new NxtControl.GuiFramework.Polygon();
			this.tb8 = new NxtControl.GuiFramework.Pipe();
			this.sa8 = new NxtControl.GuiFramework.Polygon();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irEEE
			// 
			this.irEEE.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(250D)), ((float)(26D)));
			this.irEEE.CanvasName = "EEE_BRUTO";
			this.irEEE.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irEEE.Name = "irEEE";
			this.irEEE.Text = "EEE BRUTO E GRADEAMENTO (100)  ›";
			// 
			// irPRE
			// 
			this.irPRE.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(16D)), ((float)(184D)), ((float)(26D)));
			this.irPRE.CanvasName = "PRE_TRATAMENTO";
			this.irPRE.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irPRE.Name = "irPRE";
			this.irPRE.Text = "PRÉ-TRATAMENTO (200)  ›";
			// 
			// irINF
			// 
			this.irINF.Bounds = new NxtControl.Drawing.RectF(((float)(506D)), ((float)(16D)), ((float)(236D)), ((float)(26D)));
			this.irINF.CanvasName = "INFLUENT_FEED";
			this.irINF.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irINF.Name = "irINF";
			this.irINF.Text = "NEREDA - ALIMENTAÇÃO  ›";
			// 
			// irREA
			// 
			this.irREA.Bounds = new NxtControl.Drawing.RectF(((float)(770D)), ((float)(16D)), ((float)(380D)), ((float)(26D)));
			this.irREA.CanvasName = "OVER_VIEW";
			this.irREA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irREA.Name = "irREA";
			this.irREA.Text = "NEREDA - REATORES E AERAÇÃO  ›";
			// 
			// irDES
			// 
			this.irDES.Bounds = new NxtControl.Drawing.RectF(((float)(1178D)), ((float)(16D)), ((float)(172D)), ((float)(26D)));
			this.irDES.CanvasName = "DESINFECCAO";
			this.irDES.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irDES.Name = "irDES";
			this.irDES.Text = "DESINFECÇÃO UV  ›";
			// 
			// irSLB
			// 
			this.irSLB.Bounds = new NxtControl.Drawing.RectF(((float)(770D)), ((float)(398D)), ((float)(380D)), ((float)(26D)));
			this.irSLB.CanvasName = "SLUDGE_BUFFER";
			this.irSLB.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irSLB.Name = "irSLB";
			this.irSLB.Text = "NEREDA - BUFFER DE LODO  ›";
			// 
			// irEST
			// 
			this.irEST.Bounds = new NxtControl.Drawing.RectF(((float)(506D)), ((float)(398D)), ((float)(236D)), ((float)(26D)));
			this.irEST.CanvasName = "ESTOCAGEM_LODO";
			this.irEST.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irEST.Name = "irEST";
			this.irEST.Text = "ESTOCAGEM DE LODO (900)  ›";
			// 
			// irFS
			// 
			this.irFS.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(398D)), ((float)(462D)), ((float)(26D)));
			this.irFS.CanvasName = "FASE_SOLIDA";
			this.irFS.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irFS.Name = "irFS";
			this.irFS.Text = "DESIDRATAÇÃO DE LODO (900)  ›";
			// 
			// irAR
			// 
			this.irAR.Bounds = new NxtControl.Drawing.RectF(((float)(1178D)), ((float)(398D)), ((float)(172D)), ((float)(26D)));
			this.irAR.CanvasName = "AGUA_REUSO";
			this.irAR.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irAR.Name = "irAR";
			this.irAR.Text = "ÁGUA DE REÚSO  ›";
			// 
			// bs101
			// 
			this.bs101.BeginInit();
			this.bs101.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 38.3D, 68D);
			this.bs101.Name = "bs101";
			this.bs101.SecurityToken = ((uint)(4294967295u));
			this.bs101.TagName = "F8F84A6966B68EF2.BS_100_01";
			this.bs101.EndInit();
			// 
			// bs102
			// 
			this.bs102.BeginInit();
			this.bs102.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 116.2D, 68D);
			this.bs102.Name = "bs102";
			this.bs102.SecurityToken = ((uint)(4294967295u));
			this.bs102.TagName = "F8F84A6966B68EF2.BS_100_02";
			this.bs102.EndInit();
			// 
			// bs103
			// 
			this.bs103.BeginInit();
			this.bs103.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 194.1D, 68D);
			this.bs103.Name = "bs103";
			this.bs103.SecurityToken = ((uint)(4294967295u));
			this.bs103.TagName = "F8F84A6966B68EF2.BS_100_03";
			this.bs103.EndInit();
			// 
			// gm10001
			// 
			this.gm10001.BeginInit();
			this.gm10001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4375D, 0D, 0D, 0.4375D, 42.75D, 154D);
			this.gm10001.Name = "gm10001";
			this.gm10001.SecurityToken = ((uint)(4294967295u));
			this.gm10001.TagName = "D8ECF975D72A6254.GM_100_01.Grade_Mecanizada_Inovaisa1";
			this.gm10001.EndInit();
			// 
			// gm10002
			// 
			this.gm10002.BeginInit();
			this.gm10002.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4375D, 0D, 0D, 0.4375D, 103.35D, 154D);
			this.gm10002.Name = "gm10002";
			this.gm10002.SecurityToken = ((uint)(4294967295u));
			this.gm10002.TagName = "D8ECF975D72A6254.GM_100_02.Grade_Mecanizada_Inovaisa1";
			this.gm10002.EndInit();
			// 
			// rt10001
			// 
			this.rt10001.BeginInit();
			this.rt10001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.327536D, 0D, 0D, 0.327536D, 163.95D, 195.6D);
			this.rt10001.Name = "rt10001";
			this.rt10001.SecurityToken = ((uint)(4294967295u));
			this.rt10001.TagName = "D8ECF975D72A6254.RT_100_01";
			this.rt10001.EndInit();
			// 
			// lit10003
			// 
			this.lit10003.BeginInit();
			this.lit10003._iPorcentagem = true;
			this.lit10003.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 66D, 308D);
			this.lit10003.Name = "lit10003";
			this.lit10003.SecurityToken = ((uint)(4294967295u));
			this.lit10003.TagName = "F8F84A6966B68EF2.LIT_100_03";
			this.lit10003.EndInit();
			// 
			// gord1
			// 
			this.gord1.BeginInit();
			this.gord1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 299.8D, 68D);
			this.gord1.Name = "gord1";
			this.gord1.SecurityToken = ((uint)(4294967295u));
			this.gord1.TagName = "8562B7A48F2304C1.BombaGordura";
			this.gord1.EndInit();
			// 
			// gord2
			// 
			this.gord2.BeginInit();
			this.gord2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 361.2D, 68D);
			this.gord2.Name = "gord2";
			this.gord2.SecurityToken = ((uint)(4294967295u));
			this.gord2.TagName = "1FBDCF6E96E37765.BombaGordura";
			this.gord2.EndInit();
			// 
			// gord3
			// 
			this.gord3.BeginInit();
			this.gord3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 422.6D, 68D);
			this.gord3.Name = "gord3";
			this.gord3.SecurityToken = ((uint)(4294967295u));
			this.gord3.TagName = "EB77BC463289AB0B.BombaGordura";
			this.gord3.EndInit();
			// 
			// ft4002
			// 
			this.ft4002.BeginInit();
			this.ft4002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 311D, 308D);
			this.ft4002.Name = "ft4002";
			this.ft4002.SecurityToken = ((uint)(4294967295u));
			this.ft4002.TagName = "1A8A218FB56FB248";
			this.ft4002.EndInit();
			// 
			// p4001
			// 
			this.p4001.BeginInit();
			this.p4001._iMotName = "P4001";
			this.p4001._iUnit = "%";
			this.p4001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 520D, 68D);
			this.p4001.Name = "p4001";
			this.p4001.SecurityToken = ((uint)(4294967295u));
			this.p4001.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.p4001.TagName = "B949570768DD3945.Actuators.FeedReactorPump01";
			this.p4001.EndInit();
			// 
			// p4002
			// 
			this.p4002.BeginInit();
			this.p4002._iMotName = "P4002";
			this.p4002._iUnit = "%";
			this.p4002.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 596D, 68D);
			this.p4002.Name = "p4002";
			this.p4002.SecurityToken = ((uint)(4294967295u));
			this.p4002.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.p4002.TagName = "B949570768DD3945.Actuators.FeedReactorPump02";
			this.p4002.EndInit();
			// 
			// p4003
			// 
			this.p4003.BeginInit();
			this.p4003._iMotName = "P4003";
			this.p4003._iUnit = "%";
			this.p4003.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 672D, 68D);
			this.p4003.Name = "p4003";
			this.p4003.SecurityToken = ((uint)(4294967295u));
			this.p4003.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.p4003.TagName = "B949570768DD3945.Actuators.FeedReactorPump03";
			this.p4003.EndInit();
			// 
			// infNivel
			// 
			this.infNivel.BeginInit();
			this.infNivel._iUnit = "m";
			this.infNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74D, 0D, 0D, 0.74D, 503D, 278D);
			this.infNivel.Name = "infNivel";
			this.infNivel.SecurityToken = ((uint)(4294967295u));
			this.infNivel.TagName = "B949570768DD3945.Sensors.LevelPvInfluentBuffer";
			this.infNivel.EndInit();
			// 
			// infVazao
			// 
			this.infVazao.BeginInit();
			this.infVazao._iUnit = "";
			this.infVazao.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74D, 0D, 0D, 0.74D, 532.24D, 326D);
			this.infVazao.Name = "infVazao";
			this.infVazao.SecurityToken = ((uint)(4294967295u));
			this.infVazao.TagName = "B949570768DD3945.Sensors.FeedReactorFlowPv";
			this.infVazao.EndInit();
			// 
			// r1Nivel
			// 
			this.r1Nivel.BeginInit();
			this.r1Nivel._iUnit = "m";
			this.r1Nivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74D, 0D, 0D, 0.74D, 964D, 88D);
			this.r1Nivel.Name = "r1Nivel";
			this.r1Nivel.SecurityToken = ((uint)(4294967295u));
			this.r1Nivel.TagName = "0F513B831BAFCB32.Sensors.LevelMeasurementReactor";
			this.r1Nivel.EndInit();
			// 
			// r2Nivel
			// 
			this.r2Nivel.BeginInit();
			this.r2Nivel._iUnit = "m";
			this.r2Nivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74D, 0D, 0D, 0.74D, 964D, 152D);
			this.r2Nivel.Name = "r2Nivel";
			this.r2Nivel.SecurityToken = ((uint)(4294967295u));
			this.r2Nivel.TagName = "19E8555E9622C1D3.Sensors.LevelMeasurementReactor";
			this.r2Nivel.EndInit();
			// 
			// v4601
			// 
			this.v4601.BeginInit();
			this.v4601._iMotName = "V4601";
			this.v4601._iUnit = "%";
			this.v4601.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 805.2D, 224D);
			this.v4601.Name = "v4601";
			this.v4601.SecurityToken = ((uint)(4294967295u));
			this.v4601.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.v4601.TagName = "35A194BD3A715270.Actuators.V4601";
			this.v4601.EndInit();
			// 
			// v4602
			// 
			this.v4602.BeginInit();
			this.v4602._iMotName = "V4602";
			this.v4602._iUnit = "%";
			this.v4602.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 890.1D, 224D);
			this.v4602.Name = "v4602";
			this.v4602.SecurityToken = ((uint)(4294967295u));
			this.v4602.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.v4602.TagName = "35A194BD3A715270.Actuators.V4602";
			this.v4602.EndInit();
			// 
			// v4603
			// 
			this.v4603.BeginInit();
			this.v4603._iMotName = "V4603";
			this.v4603._iUnit = "%";
			this.v4603.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 975D, 224D);
			this.v4603.Name = "v4603";
			this.v4603.SecurityToken = ((uint)(4294967295u));
			this.v4603.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.v4603.TagName = "35A194BD3A715270.Actuators.V4603";
			this.v4603.EndInit();
			// 
			// v4604
			// 
			this.v4604.BeginInit();
			this.v4604._iMotName = "V4604";
			this.v4604._iUnit = "%";
			this.v4604.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.571429D, 0D, 0D, 0.571429D, 1059.9D, 224D);
			this.v4604.Name = "v4604";
			this.v4604.SecurityToken = ((uint)(4294967295u));
			this.v4604.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.v4604.TagName = "35A194BD3A715270.Actuators.V4604";
			this.v4604.EndInit();
			// 
			// vc70001
			// 
			this.vc70001.BeginInit();
			this.vc70001.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.430769D, 0D, 0D, 0.430769D, 1236D, 68D);
			this.vc70001.Name = "vc70001";
			this.vc70001.SecurityToken = ((uint)(4294967295u));
			this.vc70001.TagName = "8005CB77235157DB.VC_700_01";
			this.vc70001.EndInit();
			// 
			// ft70001
			// 
			this.ft70001.BeginInit();
			this.ft70001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1189D, 308D);
			this.ft70001.Name = "ft70001";
			this.ft70001.SecurityToken = ((uint)(4294967295u));
			this.ft70001.TagName = "8005CB77235157DB.FT_700_01";
			this.ft70001.EndInit();
			// 
			// slbNivel
			// 
			this.slbNivel.BeginInit();
			this.slbNivel._iUnit = "m";
			this.slbNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74D, 0D, 0D, 0.74D, 964D, 466D);
			this.slbNivel.Name = "slbNivel";
			this.slbNivel.SecurityToken = ((uint)(4294967295u));
			this.slbNivel.TagName = "2EDD2709EE346B30.Sensors.LevelMeasurementSludgeBuffer";
			this.slbNivel.EndInit();
			// 
			// slbVazao
			// 
			this.slbVazao.BeginInit();
			this.slbVazao._iUnit = "";
			this.slbVazao.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74D, 0D, 0D, 0.74D, 964D, 512D);
			this.slbVazao.Name = "slbVazao";
			this.slbVazao.SecurityToken = ((uint)(4294967295u));
			this.slbVazao.TagName = "2EDD2709EE346B30.Sensors.FlowMeasurementDischargeSludge";
			this.slbVazao.EndInit();
			// 
			// p4901
			// 
			this.p4901.BeginInit();
			this.p4901._iMotName = "P4901";
			this.p4901._iUnit = "%";
			this.p4901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 846D, 566D);
			this.p4901.Name = "p4901";
			this.p4901.SecurityToken = ((uint)(4294967295u));
			this.p4901.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.p4901.TagName = "2EDD2709EE346B30.Actuators.Pump1";
			this.p4901.EndInit();
			// 
			// p4902
			// 
			this.p4902.BeginInit();
			this.p4902._iMotName = "P4902";
			this.p4902._iUnit = "%";
			this.p4902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 932D, 566D);
			this.p4902.Name = "p4902";
			this.p4902.SecurityToken = ((uint)(4294967295u));
			this.p4902.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.p4902.TagName = "2EDD2709EE346B30.Actuators.Pump2";
			this.p4902.EndInit();
			// 
			// p4903
			// 
			this.p4903.BeginInit();
			this.p4903._iMotName = "P4903";
			this.p4903._iUnit = "%";
			this.p4903.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.513761D, 0D, 0D, 0.513761D, 1018D, 566D);
			this.p4903.Name = "p4903";
			this.p4903.SecurityToken = ((uint)(4294967295u));
			this.p4903.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.p4903.TagName = "2EDD2709EE346B30.Actuators.Pump3";
			this.p4903.EndInit();
			// 
			// so901
			// 
			this.so901.BeginInit();
			this.so901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.370861D, 0D, 0D, 0.370861D, 561.5D, 450D);
			this.so901.Name = "so901";
			this.so901.SecurityToken = ((uint)(4294967295u));
			this.so901.TagName = "A03873967E84DB27.SO_900_01";
			this.so901.EndInit();
			// 
			// so902
			// 
			this.so902.BeginInit();
			this.so902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.370861D, 0D, 0D, 0.370861D, 639D, 450D);
			this.so902.Name = "so902";
			this.so902.SecurityToken = ((uint)(4294967295u));
			this.so902.TagName = "A03873967E84DB27.SO_900_02";
			this.so902.EndInit();
			// 
			// lit90001
			// 
			this.lit90001.BeginInit();
			this.lit90001._iPorcentagem = true;
			this.lit90001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 549D, 574D);
			this.lit90001.Name = "lit90001";
			this.lit90001.SecurityToken = ((uint)(4294967295u));
			this.lit90001.TagName = "A03873967E84DB27.LIT_900_01";
			this.lit90001.EndInit();
			// 
			// lit90002
			// 
			this.lit90002.BeginInit();
			this.lit90002._iPorcentagem = true;
			this.lit90002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 549D, 620D);
			this.lit90002.Name = "lit90002";
			this.lit90002.SecurityToken = ((uint)(4294967295u));
			this.lit90002.TagName = "A03873967E84DB27.LIT_900_02";
			this.lit90002.EndInit();
			// 
			// bo901
			// 
			this.bo901.BeginInit();
			this.bo901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.339339D, 0D, 0D, 0.339339D, 40.45D, 463.2D);
			this.bo901.Name = "bo901";
			this.bo901.SecurityToken = ((uint)(4294967295u));
			this.bo901.TagName = "91957488A3380C04.BO_900_01";
			this.bo901.EndInit();
			// 
			// bo902
			// 
			this.bo902.BeginInit();
			this.bo902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.339339D, 0D, 0D, 0.339339D, 137.75D, 463.2D);
			this.bo902.Name = "bo902";
			this.bo902.SecurityToken = ((uint)(4294967295u));
			this.bo902.TagName = "91957488A3380C04.BO_900_02";
			this.bo902.EndInit();
			// 
			// bo903
			// 
			this.bo903.BeginInit();
			this.bo903.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.339339D, 0D, 0D, 0.339339D, 235.05D, 463.2D);
			this.bo903.Name = "bo903";
			this.bo903.SecurityToken = ((uint)(4294967295u));
			this.bo903.TagName = "91957488A3380C04.BO_900_03";
			this.bo903.EndInit();
			// 
			// br901
			// 
			this.br901.BeginInit();
			this.br901.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 332.35D, 450D);
			this.br901.Name = "br901";
			this.br901.SecurityToken = ((uint)(4294967295u));
			this.br901.TagName = "91957488A3380C04.BR_900_01";
			this.br901.EndInit();
			// 
			// br902
			// 
			this.br902.BeginInit();
			this.br902.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.397163D, 0D, 0D, 0.397163D, 403.95D, 450D);
			this.br902.Name = "br902";
			this.br902.SecurityToken = ((uint)(4294967295u));
			this.br902.TagName = "91957488A3380C04.BR_900_02";
			this.br902.EndInit();
			// 
			// ft90001
			// 
			this.ft90001.BeginInit();
			this.ft90001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 20D, 574D);
			this.ft90001.Name = "ft90001";
			this.ft90001.SecurityToken = ((uint)(4294967295u));
			this.ft90001.TagName = "91957488A3380C04.FT_900_01";
			this.ft90001.EndInit();
			// 
			// ft90002
			// 
			this.ft90002.BeginInit();
			this.ft90002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 254D, 574D);
			this.ft90002.Name = "ft90002";
			this.ft90002.SecurityToken = ((uint)(4294967295u));
			this.ft90002.TagName = "91957488A3380C04.FT_900_02";
			this.ft90002.EndInit();
			// 
			// pit100001
			// 
			this.pit100001.BeginInit();
			this.pit100001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1189D, 464D);
			this.pit100001.Name = "pit100001";
			this.pit100001.SecurityToken = ((uint)(4294967295u));
			this.pit100001.TagName = "F134E1AF157DF837.PIT_1000_01";
			this.pit100001.EndInit();
			// 
			// pit100002
			// 
			this.pit100002.BeginInit();
			this.pit100002.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1189D, 510D);
			this.pit100002.Name = "pit100002";
			this.pit100002.SecurityToken = ((uint)(4294967295u));
			this.pit100002.TagName = "F134E1AF157DF837.PIT_1000_02";
			this.pit100002.EndInit();
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
			// btnReconhecerGeral
			// 
			this.btnReconhecerGeral.Bounds = new NxtControl.Drawing.RectF(((float)(138D)), ((float)(662D)), ((float)(150D)), ((float)(30D)));
			this.btnReconhecerGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReconhecerGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnReconhecerGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReconhecerGeral.Name = "btnReconhecerGeral";
			this.btnReconhecerGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReconhecerGeral.Radius = 2D;
			this.btnReconhecerGeral.Text = "Reconhecer geral";
			this.btnReconhecerGeral.Use3DEffect = false;
			this.btnReconhecerGeral.Click += new System.EventHandler(this.BtnReconhecerGeralClick);
			// 
			// repAI1
			// 
			this.repAI1.BeginInit();
			this.repAI1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repAI1.Name = "repAI1";
			this.repAI1.SecurityToken = ((uint)(4294967295u));
			this.repAI1.TagName = "428D497DE5BC46AE.LevelMeasurementReactor.AnalogInput";
			this.repAI1.Visible = false;
			this.repAI1.EndInit();
			// 
			// repHH1
			// 
			this.repHH1.BeginInit();
			this.repHH1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repHH1.Name = "repHH1";
			this.repHH1.SecurityToken = ((uint)(4294967295u));
			this.repHH1.TagName = "428D497DE5BC46AE.LevelMeasurementReactor.highHigh";
			this.repHH1.Visible = false;
			this.repHH1.EndInit();
			// 
			// repH1
			// 
			this.repH1.BeginInit();
			this.repH1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repH1.Name = "repH1";
			this.repH1.SecurityToken = ((uint)(4294967295u));
			this.repH1.TagName = "428D497DE5BC46AE.LevelMeasurementReactor.high";
			this.repH1.Visible = false;
			this.repH1.EndInit();
			// 
			// repL1
			// 
			this.repL1.BeginInit();
			this.repL1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repL1.Name = "repL1";
			this.repL1.SecurityToken = ((uint)(4294967295u));
			this.repL1.TagName = "428D497DE5BC46AE.LevelMeasurementReactor.low";
			this.repL1.Visible = false;
			this.repL1.EndInit();
			// 
			// repLL1
			// 
			this.repLL1.BeginInit();
			this.repLL1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repLL1.Name = "repLL1";
			this.repLL1.SecurityToken = ((uint)(4294967295u));
			this.repLL1.TagName = "428D497DE5BC46AE.LevelMeasurementReactor.lowLow";
			this.repLL1.Visible = false;
			this.repLL1.EndInit();
			// 
			// repAI2
			// 
			this.repAI2.BeginInit();
			this.repAI2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repAI2.Name = "repAI2";
			this.repAI2.SecurityToken = ((uint)(4294967295u));
			this.repAI2.TagName = "15BC11099FA14F71.LevelMeasurementReactor.AnalogInput";
			this.repAI2.Visible = false;
			this.repAI2.EndInit();
			// 
			// repHH2
			// 
			this.repHH2.BeginInit();
			this.repHH2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repHH2.Name = "repHH2";
			this.repHH2.SecurityToken = ((uint)(4294967295u));
			this.repHH2.TagName = "15BC11099FA14F71.LevelMeasurementReactor.highHigh";
			this.repHH2.Visible = false;
			this.repHH2.EndInit();
			// 
			// repH2
			// 
			this.repH2.BeginInit();
			this.repH2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repH2.Name = "repH2";
			this.repH2.SecurityToken = ((uint)(4294967295u));
			this.repH2.TagName = "15BC11099FA14F71.LevelMeasurementReactor.high";
			this.repH2.Visible = false;
			this.repH2.EndInit();
			// 
			// repL2
			// 
			this.repL2.BeginInit();
			this.repL2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repL2.Name = "repL2";
			this.repL2.SecurityToken = ((uint)(4294967295u));
			this.repL2.TagName = "15BC11099FA14F71.LevelMeasurementReactor.low";
			this.repL2.Visible = false;
			this.repL2.EndInit();
			// 
			// repLL2
			// 
			this.repLL2.BeginInit();
			this.repLL2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repLL2.Name = "repLL2";
			this.repLL2.SecurityToken = ((uint)(4294967295u));
			this.repLL2.TagName = "15BC11099FA14F71.LevelMeasurementReactor.lowLow";
			this.repLL2.Visible = false;
			this.repLL2.EndInit();
			// 
			// repAIft
			// 
			this.repAIft.BeginInit();
			this.repAIft.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repAIft.Name = "repAIft";
			this.repAIft.SecurityToken = ((uint)(4294967295u));
			this.repAIft.TagName = "B949570768DD3945.Sensors.FeedInfluentFlowPv.AnalogInput";
			this.repAIft.Visible = false;
			this.repAIft.EndInit();
			// 
			// repHHft
			// 
			this.repHHft.BeginInit();
			this.repHHft.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repHHft.Name = "repHHft";
			this.repHHft.SecurityToken = ((uint)(4294967295u));
			this.repHHft.TagName = "B949570768DD3945.Sensors.FeedInfluentFlowPv.highHigh";
			this.repHHft.Visible = false;
			this.repHHft.EndInit();
			// 
			// repHft
			// 
			this.repHft.BeginInit();
			this.repHft.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repHft.Name = "repHft";
			this.repHft.SecurityToken = ((uint)(4294967295u));
			this.repHft.TagName = "B949570768DD3945.Sensors.FeedInfluentFlowPv.high";
			this.repHft.Visible = false;
			this.repHft.EndInit();
			// 
			// repLft
			// 
			this.repLft.BeginInit();
			this.repLft.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repLft.Name = "repLft";
			this.repLft.SecurityToken = ((uint)(4294967295u));
			this.repLft.TagName = "B949570768DD3945.Sensors.FeedInfluentFlowPv.low";
			this.repLft.Visible = false;
			this.repLft.EndInit();
			// 
			// repLLft
			// 
			this.repLLft.BeginInit();
			this.repLLft.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repLLft.Name = "repLLft";
			this.repLLft.SecurityToken = ((uint)(4294967295u));
			this.repLLft.TagName = "B949570768DD3945.Sensors.FeedInfluentFlowPv.lowLow";
			this.repLLft.Visible = false;
			this.repLLft.EndInit();
			// 
			// qEEE
			// 
			this.qEEE.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(10D)), ((float)(262D)), ((float)(360D)));
			this.qEEE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qEEE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qEEE.Name = "qEEE";
			this.qEEE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx1
			// 
			this.tx1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(50D)), ((float)(200D)), ((float)(12D)));
			this.tx1.Brush = new NxtControl.Drawing.Brush(true);
			this.tx1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx1.Name = "tx1";
			this.tx1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx1.Text = "EQUIPAMENTOS";
			this.tx1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx1.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx2
			// 
			this.tx2.Bounds = new NxtControl.Drawing.RectF(((float)(23.3D)), ((float)(126D)), ((float)(79.6D)), ((float)(14D)));
			this.tx2.Brush = new NxtControl.Drawing.Brush(true);
			this.tx2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx2.Name = "tx2";
			this.tx2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx2.Text = "100-BS-01";
			this.tx2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx2.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgP4001
			// 
			this.lgP4001.Bounds = new NxtControl.Drawing.RectF(((float)(508.0D)), ((float)(117.8D)), ((float)(80D)), ((float)(14D)));
			this.lgP4001.Brush = new NxtControl.Drawing.Brush(true);
			this.lgP4001.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgP4001.Name = "lgP4001";
			this.lgP4001.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgP4001.Text = "P4001";
			this.lgP4001.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgP4001.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgP4002
			// 
			this.lgP4002.Bounds = new NxtControl.Drawing.RectF(((float)(584.0D)), ((float)(117.8D)), ((float)(80D)), ((float)(14D)));
			this.lgP4002.Brush = new NxtControl.Drawing.Brush(true);
			this.lgP4002.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgP4002.Name = "lgP4002";
			this.lgP4002.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgP4002.Text = "P4002";
			this.lgP4002.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgP4002.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgP4003
			// 
			this.lgP4003.Bounds = new NxtControl.Drawing.RectF(((float)(660.0D)), ((float)(117.8D)), ((float)(80D)), ((float)(14D)));
			this.lgP4003.Brush = new NxtControl.Drawing.Brush(true);
			this.lgP4003.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgP4003.Name = "lgP4003";
			this.lgP4003.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgP4003.Text = "P4003";
			this.lgP4003.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgP4003.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgV4601
			// 
			this.lgV4601.Bounds = new NxtControl.Drawing.RectF(((float)(792.7D)), ((float)(283.7D)), ((float)(80D)), ((float)(14D)));
			this.lgV4601.Brush = new NxtControl.Drawing.Brush(true);
			this.lgV4601.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgV4601.Name = "lgV4601";
			this.lgV4601.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgV4601.Text = "V4601";
			this.lgV4601.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgV4601.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgV4602
			// 
			this.lgV4602.Bounds = new NxtControl.Drawing.RectF(((float)(877.6D)), ((float)(283.7D)), ((float)(80D)), ((float)(14D)));
			this.lgV4602.Brush = new NxtControl.Drawing.Brush(true);
			this.lgV4602.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgV4602.Name = "lgV4602";
			this.lgV4602.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgV4602.Text = "V4602";
			this.lgV4602.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgV4602.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgV4603
			// 
			this.lgV4603.Bounds = new NxtControl.Drawing.RectF(((float)(962.5D)), ((float)(283.7D)), ((float)(80D)), ((float)(14D)));
			this.lgV4603.Brush = new NxtControl.Drawing.Brush(true);
			this.lgV4603.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgV4603.Name = "lgV4603";
			this.lgV4603.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgV4603.Text = "V4603";
			this.lgV4603.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgV4603.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgV4604
			// 
			this.lgV4604.Bounds = new NxtControl.Drawing.RectF(((float)(1047.4D)), ((float)(283.7D)), ((float)(80D)), ((float)(14D)));
			this.lgV4604.Brush = new NxtControl.Drawing.Brush(true);
			this.lgV4604.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgV4604.Name = "lgV4604";
			this.lgV4604.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgV4604.Text = "V4604";
			this.lgV4604.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgV4604.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgP4901
			// 
			this.lgP4901.Bounds = new NxtControl.Drawing.RectF(((float)(834.0D)), ((float)(615.8D)), ((float)(80D)), ((float)(14D)));
			this.lgP4901.Brush = new NxtControl.Drawing.Brush(true);
			this.lgP4901.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgP4901.Name = "lgP4901";
			this.lgP4901.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgP4901.Text = "P4901";
			this.lgP4901.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgP4901.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgP4902
			// 
			this.lgP4902.Bounds = new NxtControl.Drawing.RectF(((float)(920.0D)), ((float)(615.8D)), ((float)(80D)), ((float)(14D)));
			this.lgP4902.Brush = new NxtControl.Drawing.Brush(true);
			this.lgP4902.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgP4902.Name = "lgP4902";
			this.lgP4902.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgP4902.Text = "P4902";
			this.lgP4902.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgP4902.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// lgP4903
			// 
			this.lgP4903.Bounds = new NxtControl.Drawing.RectF(((float)(1006.0D)), ((float)(615.8D)), ((float)(80D)), ((float)(14D)));
			this.lgP4903.Brush = new NxtControl.Drawing.Brush(true);
			this.lgP4903.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lgP4903.Name = "lgP4903";
			this.lgP4903.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lgP4903.Text = "P4903";
			this.lgP4903.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.lgP4903.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx3
			// 
			this.tx3.Bounds = new NxtControl.Drawing.RectF(((float)(101.2D)), ((float)(126D)), ((float)(79.6D)), ((float)(14D)));
			this.tx3.Brush = new NxtControl.Drawing.Brush(true);
			this.tx3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx3.Name = "tx3";
			this.tx3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx3.Text = "100-BS-02";
			this.tx3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx3.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx4
			// 
			this.tx4.Bounds = new NxtControl.Drawing.RectF(((float)(179.1D)), ((float)(126D)), ((float)(79.6D)), ((float)(14D)));
			this.tx4.Brush = new NxtControl.Drawing.Brush(true);
			this.tx4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx4.Name = "tx4";
			this.tx4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx4.Text = "100-BS-03";
			this.tx4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx4.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx5
			// 
			this.tx5.Bounds = new NxtControl.Drawing.RectF(((float)(27.75D)), ((float)(212D)), ((float)(60.6D)), ((float)(14D)));
			this.tx5.Brush = new NxtControl.Drawing.Brush(true);
			this.tx5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx5.Name = "tx5";
			this.tx5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx5.Text = "100-GM-01";
			this.tx5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx5.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx6
			// 
			this.tx6.Bounds = new NxtControl.Drawing.RectF(((float)(88.35D)), ((float)(212D)), ((float)(60.6D)), ((float)(14D)));
			this.tx6.Brush = new NxtControl.Drawing.Brush(true);
			this.tx6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx6.Name = "tx6";
			this.tx6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx6.Text = "100-GM-02";
			this.tx6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx6.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx7
			// 
			this.tx7.Bounds = new NxtControl.Drawing.RectF(((float)(148.95D)), ((float)(212D)), ((float)(105.3D)), ((float)(14D)));
			this.tx7.Brush = new NxtControl.Drawing.Brush(true);
			this.tx7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx7.Name = "tx7";
			this.tx7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx7.Text = "100-RT-01";
			this.tx7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx7.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx8
			// 
			this.tx8.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(272D)), ((float)(200D)), ((float)(12D)));
			this.tx8.Brush = new NxtControl.Drawing.Brush(true);
			this.tx8.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx8.Name = "tx8";
			this.tx8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx8.Text = "MEDIÇÕES";
			this.tx8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx8.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx9
			// 
			this.tx9.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(290D)), ((float)(242D)), ((float)(14D)));
			this.tx9.Brush = new NxtControl.Drawing.Brush(true);
			this.tx9.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx9.Name = "tx9";
			this.tx9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx9.Text = "100-LIT-03 – Nível do poço de bombas (%)";
			this.tx9.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx9.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// qPRE
			// 
			this.qPRE.Bounds = new NxtControl.Drawing.RectF(((float)(288D)), ((float)(10D)), ((float)(196D)), ((float)(360D)));
			this.qPRE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qPRE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qPRE.Name = "qPRE";
			this.qPRE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx10
			// 
			this.tx10.Bounds = new NxtControl.Drawing.RectF(((float)(298D)), ((float)(50D)), ((float)(200D)), ((float)(12D)));
			this.tx10.Brush = new NxtControl.Drawing.Brush(true);
			this.tx10.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx10.Name = "tx10";
			this.tx10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx10.Text = "EQUIPAMENTOS";
			this.tx10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx10.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx11
			// 
			this.tx11.Bounds = new NxtControl.Drawing.RectF(((float)(284.8D)), ((float)(126D)), ((float)(79.6D)), ((float)(14D)));
			this.tx11.Brush = new NxtControl.Drawing.Brush(true);
			this.tx11.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx11.Name = "tx11";
			this.tx11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx11.Text = "200-BR-03";
			this.tx11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx11.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx12
			// 
			this.tx12.Bounds = new NxtControl.Drawing.RectF(((float)(346.2D)), ((float)(126D)), ((float)(79.6D)), ((float)(14D)));
			this.tx12.Brush = new NxtControl.Drawing.Brush(true);
			this.tx12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx12.Name = "tx12";
			this.tx12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx12.Text = "200-BR-04";
			this.tx12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx12.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx13
			// 
			this.tx13.Bounds = new NxtControl.Drawing.RectF(((float)(407.6D)), ((float)(126D)), ((float)(79.6D)), ((float)(14D)));
			this.tx13.Brush = new NxtControl.Drawing.Brush(true);
			this.tx13.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx13.Name = "tx13";
			this.tx13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx13.Text = "200-BR-05";
			this.tx13.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx13.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx14
			// 
			this.tx14.Bounds = new NxtControl.Drawing.RectF(((float)(298D)), ((float)(272D)), ((float)(200D)), ((float)(12D)));
			this.tx14.Brush = new NxtControl.Drawing.Brush(true);
			this.tx14.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx14.Name = "tx14";
			this.tx14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx14.Text = "MEDIÇÕES";
			this.tx14.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx14.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx15
			// 
			this.tx15.Bounds = new NxtControl.Drawing.RectF(((float)(298D)), ((float)(290D)), ((float)(176D)), ((float)(14D)));
			this.tx15.Brush = new NxtControl.Drawing.Brush(true);
			this.tx15.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx15.Name = "tx15";
			this.tx15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx15.Text = "40FT02 – Vazão de entrada";
			this.tx15.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx15.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// qINF
			// 
			this.qINF.Bounds = new NxtControl.Drawing.RectF(((float)(500D)), ((float)(10D)), ((float)(248D)), ((float)(360D)));
			this.qINF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qINF.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qINF.Name = "qINF";
			this.qINF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx16
			// 
			this.tx16.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(50D)), ((float)(200D)), ((float)(12D)));
			this.tx16.Brush = new NxtControl.Drawing.Brush(true);
			this.tx16.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx16.Name = "tx16";
			this.tx16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx16.Text = "BOMBAS DE ALIMENTAÇÃO";
			this.tx16.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx16.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx17
			// 
			this.tx17.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(246D)), ((float)(200D)), ((float)(12D)));
			this.tx17.Brush = new NxtControl.Drawing.Brush(true);
			this.tx17.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx17.Name = "tx17";
			this.tx17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx17.Text = "MEDIÇÕES";
			this.tx17.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx17.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx18
			// 
			this.tx18.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(262D)), ((float)(228D)), ((float)(14D)));
			this.tx18.Brush = new NxtControl.Drawing.Brush(true);
			this.tx18.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx18.Name = "tx18";
			this.tx18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx18.Text = "40LIT0001 – Nível do buffer de alimentação";
			this.tx18.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx18.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// pctInf
			// 
			this.pctInf.BeginInit();
			this.pctInf.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 688.52D, 278D);
			this.pctInf.Name = "pctInf";
			this.pctInf.SecurityToken = ((uint)(4294967295u));
			this.pctInf.TagName = "B949570768DD3945.Sensors.LevelPvInfluentBuffer";
			this.pctInf.EndInit();
			// 
			// tx19
			// 
			this.tx19.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(310D)), ((float)(228D)), ((float)(14D)));
			this.tx19.Brush = new NxtControl.Drawing.Brush(true);
			this.tx19.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx19.Name = "tx19";
			this.tx19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx19.Text = "Vazão de alimentação dos reatores";
			this.tx19.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx19.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// qREA
			// 
			this.qREA.Bounds = new NxtControl.Drawing.RectF(((float)(764D)), ((float)(10D)), ((float)(392D)), ((float)(360D)));
			this.qREA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qREA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qREA.Name = "qREA";
			this.qREA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx20
			// 
			this.tx20.Bounds = new NxtControl.Drawing.RectF(((float)(774D)), ((float)(50D)), ((float)(200D)), ((float)(12D)));
			this.tx20.Brush = new NxtControl.Drawing.Brush(true);
			this.tx20.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx20.Name = "tx20";
			this.tx20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx20.Text = "FASE E NÍVEL";
			this.tx20.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx20.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// faseR1
			// 
			this.faseR1.BeginInit();
			this.faseR1._iNome = "Reator 1";
			this.faseR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 774D, 66D);
			this.faseR1.Name = "faseR1";
			this.faseR1.SecurityToken = ((uint)(4294967295u));
			this.faseR1.TagName = "0F513B831BAFCB32";
			this.faseR1.EndInit();
			// 
			// tx21
			// 
			this.tx21.Bounds = new NxtControl.Drawing.RectF(((float)(964D)), ((float)(68D)), ((float)(120D)), ((float)(14D)));
			this.tx21.Brush = new NxtControl.Drawing.Brush(true);
			this.tx21.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx21.Name = "tx21";
			this.tx21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx21.Text = "41LT1005 – Nível";
			this.tx21.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx21.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// pctR1
			// 
			this.pctR1.BeginInit();
			this.pctR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 66D);
			this.pctR1.Name = "pctR1";
			this.pctR1.SecurityToken = ((uint)(4294967295u));
			this.pctR1.TagName = "0F513B831BAFCB32.Sensors.LevelMeasurementReactor";
			this.pctR1.EndInit();
			// 
			// faseR2
			// 
			this.faseR2.BeginInit();
			this.faseR2._iNome = "Reator 2";
			this.faseR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 774D, 130D);
			this.faseR2.Name = "faseR2";
			this.faseR2.SecurityToken = ((uint)(4294967295u));
			this.faseR2.TagName = "19E8555E9622C1D3";
			this.faseR2.EndInit();
			// 
			// tx22
			// 
			this.tx22.Bounds = new NxtControl.Drawing.RectF(((float)(964D)), ((float)(132D)), ((float)(120D)), ((float)(14D)));
			this.tx22.Brush = new NxtControl.Drawing.Brush(true);
			this.tx22.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx22.Name = "tx22";
			this.tx22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx22.Text = "42LT1005 – Nível";
			this.tx22.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx22.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// pctR2
			// 
			this.pctR2.BeginInit();
			this.pctR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 130D);
			this.pctR2.Name = "pctR2";
			this.pctR2.SecurityToken = ((uint)(4294967295u));
			this.pctR2.TagName = "19E8555E9622C1D3.Sensors.LevelMeasurementReactor";
			this.pctR2.EndInit();
			// 
			// tx23
			// 
			this.tx23.Bounds = new NxtControl.Drawing.RectF(((float)(774D)), ((float)(206D)), ((float)(200D)), ((float)(12D)));
			this.tx23.Brush = new NxtControl.Drawing.Brush(true);
			this.tx23.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx23.Name = "tx23";
			this.tx23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx23.Text = "SOPRADORES";
			this.tx23.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx23.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// qDES
			// 
			this.qDES.Bounds = new NxtControl.Drawing.RectF(((float)(1172D)), ((float)(10D)), ((float)(184D)), ((float)(360D)));
			this.qDES.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qDES.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qDES.Name = "qDES";
			this.qDES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx24
			// 
			this.tx24.Bounds = new NxtControl.Drawing.RectF(((float)(1182D)), ((float)(50D)), ((float)(200D)), ((float)(12D)));
			this.tx24.Brush = new NxtControl.Drawing.Brush(true);
			this.tx24.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx24.Name = "tx24";
			this.tx24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx24.Text = "EQUIPAMENTOS";
			this.tx24.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx24.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx25
			// 
			this.tx25.Bounds = new NxtControl.Drawing.RectF(((float)(1221D)), ((float)(123.4D)), ((float)(86D)), ((float)(14D)));
			this.tx25.Brush = new NxtControl.Drawing.Brush(true);
			this.tx25.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx25.Name = "tx25";
			this.tx25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx25.Text = "700-VC-01";
			this.tx25.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx25.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx26
			// 
			this.tx26.Bounds = new NxtControl.Drawing.RectF(((float)(1182D)), ((float)(272D)), ((float)(200D)), ((float)(12D)));
			this.tx26.Brush = new NxtControl.Drawing.Brush(true);
			this.tx26.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx26.Name = "tx26";
			this.tx26.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx26.Text = "MEDIÇÕES";
			this.tx26.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx26.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx27
			// 
			this.tx27.Bounds = new NxtControl.Drawing.RectF(((float)(1178D)), ((float)(290D)), ((float)(172D)), ((float)(14D)));
			this.tx27.Brush = new NxtControl.Drawing.Brush(true);
			this.tx27.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx27.Name = "tx27";
			this.tx27.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx27.Text = "700-FT-01 – Vazão de saída";
			this.tx27.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx27.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// qSLB
			// 
			this.qSLB.Bounds = new NxtControl.Drawing.RectF(((float)(764D)), ((float)(392D)), ((float)(392D)), ((float)(262D)));
			this.qSLB.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qSLB.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qSLB.Name = "qSLB";
			this.qSLB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx28
			// 
			this.tx28.Bounds = new NxtControl.Drawing.RectF(((float)(774D)), ((float)(432D)), ((float)(200D)), ((float)(12D)));
			this.tx28.Brush = new NxtControl.Drawing.Brush(true);
			this.tx28.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx28.Name = "tx28";
			this.tx28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx28.Text = "FASE E MEDIÇÕES";
			this.tx28.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx28.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// faseSB
			// 
			this.faseSB.BeginInit();
			this.faseSB._iNome = "Buffer de lodo";
			this.faseSB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 774D, 448D);
			this.faseSB.Name = "faseSB";
			this.faseSB.SecurityToken = ((uint)(4294967295u));
			this.faseSB.TagName = "2EDD2709EE346B30";
			this.faseSB.EndInit();
			// 
			// tx29
			// 
			this.tx29.Bounds = new NxtControl.Drawing.RectF(((float)(964D)), ((float)(448D)), ((float)(120D)), ((float)(14D)));
			this.tx29.Brush = new NxtControl.Drawing.Brush(true);
			this.tx29.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx29.Name = "tx29";
			this.tx29.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx29.Text = "49LIT0001 – Nível";
			this.tx29.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx29.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// pctSB
			// 
			this.pctSB.BeginInit();
			this.pctSB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 446D);
			this.pctSB.Name = "pctSB";
			this.pctSB.SecurityToken = ((uint)(4294967295u));
			this.pctSB.TagName = "2EDD2709EE346B30.Sensors.LevelMeasurementSludgeBuffer";
			this.pctSB.EndInit();
			// 
			// tx30
			// 
			this.tx30.Bounds = new NxtControl.Drawing.RectF(((float)(964D)), ((float)(494D)), ((float)(182D)), ((float)(14D)));
			this.tx30.Brush = new NxtControl.Drawing.Brush(true);
			this.tx30.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx30.Name = "tx30";
			this.tx30.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx30.Text = "Vazão de descarte de lodo";
			this.tx30.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx30.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// tx31
			// 
			this.tx31.Bounds = new NxtControl.Drawing.RectF(((float)(774D)), ((float)(548D)), ((float)(200D)), ((float)(12D)));
			this.tx31.Brush = new NxtControl.Drawing.Brush(true);
			this.tx31.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx31.Name = "tx31";
			this.tx31.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx31.Text = "BOMBAS DE LODO";
			this.tx31.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx31.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// qEST
			// 
			this.qEST.Bounds = new NxtControl.Drawing.RectF(((float)(500D)), ((float)(392D)), ((float)(248D)), ((float)(262D)));
			this.qEST.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qEST.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qEST.Name = "qEST";
			this.qEST.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx32
			// 
			this.tx32.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(432D)), ((float)(200D)), ((float)(12D)));
			this.tx32.Brush = new NxtControl.Drawing.Brush(true);
			this.tx32.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx32.Name = "tx32";
			this.tx32.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx32.Text = "EQUIPAMENTOS";
			this.tx32.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx32.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx33
			// 
			this.tx33.Bounds = new NxtControl.Drawing.RectF(((float)(546.5D)), ((float)(508D)), ((float)(77.5D)), ((float)(14D)));
			this.tx33.Brush = new NxtControl.Drawing.Brush(true);
			this.tx33.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx33.Name = "tx33";
			this.tx33.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx33.Text = "900-SO-01";
			this.tx33.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx33.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx34
			// 
			this.tx34.Bounds = new NxtControl.Drawing.RectF(((float)(624D)), ((float)(508D)), ((float)(77.5D)), ((float)(14D)));
			this.tx34.Brush = new NxtControl.Drawing.Brush(true);
			this.tx34.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx34.Name = "tx34";
			this.tx34.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx34.Text = "900-SO-02";
			this.tx34.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx34.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx35
			// 
			this.tx35.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(542D)), ((float)(200D)), ((float)(12D)));
			this.tx35.Brush = new NxtControl.Drawing.Brush(true);
			this.tx35.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx35.Name = "tx35";
			this.tx35.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx35.Text = "MEDIÇÕES";
			this.tx35.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx35.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx36
			// 
			this.tx36.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(558D)), ((float)(228D)), ((float)(14D)));
			this.tx36.Brush = new NxtControl.Drawing.Brush(true);
			this.tx36.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx36.Name = "tx36";
			this.tx36.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx36.Text = "900-LIT-01 – Nível do tanque 1 (%)";
			this.tx36.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx36.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// tx37
			// 
			this.tx37.Bounds = new NxtControl.Drawing.RectF(((float)(510D)), ((float)(604D)), ((float)(228D)), ((float)(14D)));
			this.tx37.Brush = new NxtControl.Drawing.Brush(true);
			this.tx37.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx37.Name = "tx37";
			this.tx37.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx37.Text = "900-LIT-02 – Nível do tanque 2 (%)";
			this.tx37.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx37.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// qFS
			// 
			this.qFS.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(392D)), ((float)(474D)), ((float)(262D)));
			this.qFS.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qFS.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qFS.Name = "qFS";
			this.qFS.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx38
			// 
			this.tx38.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(432D)), ((float)(200D)), ((float)(12D)));
			this.tx38.Brush = new NxtControl.Drawing.Brush(true);
			this.tx38.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx38.Name = "tx38";
			this.tx38.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx38.Text = "EQUIPAMENTOS";
			this.tx38.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx38.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx39
			// 
			this.tx39.Bounds = new NxtControl.Drawing.RectF(((float)(25.45D)), ((float)(508D)), ((float)(105.3D)), ((float)(14D)));
			this.tx39.Brush = new NxtControl.Drawing.Brush(true);
			this.tx39.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx39.Name = "tx39";
			this.tx39.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx39.Text = "900-BO-01";
			this.tx39.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx39.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx40
			// 
			this.tx40.Bounds = new NxtControl.Drawing.RectF(((float)(122.75D)), ((float)(508D)), ((float)(105.3D)), ((float)(14D)));
			this.tx40.Brush = new NxtControl.Drawing.Brush(true);
			this.tx40.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx40.Name = "tx40";
			this.tx40.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx40.Text = "900-BO-02";
			this.tx40.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx40.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx41
			// 
			this.tx41.Bounds = new NxtControl.Drawing.RectF(((float)(220.05D)), ((float)(508D)), ((float)(105.3D)), ((float)(14D)));
			this.tx41.Brush = new NxtControl.Drawing.Brush(true);
			this.tx41.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx41.Name = "tx41";
			this.tx41.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx41.Text = "900-BO-03";
			this.tx41.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx41.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx42
			// 
			this.tx42.Bounds = new NxtControl.Drawing.RectF(((float)(317.35D)), ((float)(508D)), ((float)(79.6D)), ((float)(14D)));
			this.tx42.Brush = new NxtControl.Drawing.Brush(true);
			this.tx42.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx42.Name = "tx42";
			this.tx42.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx42.Text = "900-BR-01";
			this.tx42.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx42.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx43
			// 
			this.tx43.Bounds = new NxtControl.Drawing.RectF(((float)(388.95D)), ((float)(508D)), ((float)(79.6D)), ((float)(14D)));
			this.tx43.Brush = new NxtControl.Drawing.Brush(true);
			this.tx43.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tx43.Name = "tx43";
			this.tx43.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx43.Text = "900-BR-02";
			this.tx43.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.tx43.TextColor = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			// 
			// tx44
			// 
			this.tx44.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(542D)), ((float)(200D)), ((float)(12D)));
			this.tx44.Brush = new NxtControl.Drawing.Brush(true);
			this.tx44.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx44.Name = "tx44";
			this.tx44.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx44.Text = "MEDIÇÕES";
			this.tx44.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx44.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx45
			// 
			this.tx45.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(558D)), ((float)(220D)), ((float)(14D)));
			this.tx45.Brush = new NxtControl.Drawing.Brush(true);
			this.tx45.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx45.Name = "tx45";
			this.tx45.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx45.Text = "900-FT-01 – Vazão";
			this.tx45.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx45.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// tx46
			// 
			this.tx46.Bounds = new NxtControl.Drawing.RectF(((float)(254D)), ((float)(558D)), ((float)(220D)), ((float)(14D)));
			this.tx46.Brush = new NxtControl.Drawing.Brush(true);
			this.tx46.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx46.Name = "tx46";
			this.tx46.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx46.Text = "900-FT-02 – Vazão";
			this.tx46.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx46.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// qAR
			// 
			this.qAR.Bounds = new NxtControl.Drawing.RectF(((float)(1172D)), ((float)(392D)), ((float)(184D)), ((float)(150D)));
			this.qAR.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.qAR.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qAR.Name = "qAR";
			this.qAR.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tx47
			// 
			this.tx47.Bounds = new NxtControl.Drawing.RectF(((float)(1182D)), ((float)(432D)), ((float)(200D)), ((float)(12D)));
			this.tx47.Brush = new NxtControl.Drawing.Brush(true);
			this.tx47.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tx47.Name = "tx47";
			this.tx47.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx47.Text = "MEDIÇÕES";
			this.tx47.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx47.TextColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120)));
			// 
			// tx48
			// 
			this.tx48.Bounds = new NxtControl.Drawing.RectF(((float)(1178D)), ((float)(448D)), ((float)(172D)), ((float)(14D)));
			this.tx48.Brush = new NxtControl.Drawing.Brush(true);
			this.tx48.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx48.Name = "tx48";
			this.tx48.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx48.Text = "1000-PIT-01 – Pressão";
			this.tx48.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx48.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// tx49
			// 
			this.tx49.Bounds = new NxtControl.Drawing.RectF(((float)(1178D)), ((float)(494D)), ((float)(172D)), ((float)(14D)));
			this.tx49.Brush = new NxtControl.Drawing.Brush(true);
			this.tx49.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tx49.Name = "tx49";
			this.tx49.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tx49.Text = "1000-PIT-02 – Pressão";
			this.tx49.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tx49.TextColor = new NxtControl.Drawing.Color(((byte)(70)), ((byte)(70)), ((byte)(70)));
			// 
			// tb1
			// 
			this.tb1.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(160D)), ((float)(16D)), ((float)(0D)));
			this.tb1.InnerColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230)));
			this.tb1.Name = "tb1";
			this.tb1.OuterColor = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170)));
			this.tb1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(272D, 160D),
			new NxtControl.Drawing.PointF(288D, 160D)});
			this.tb1.Width = 8;
			// 
			// sa1
			// 
			this.sa1.Bounds = new NxtControl.Drawing.RectF(((float)(279D)), ((float)(153D)), ((float)(9D)), ((float)(14D)));
			this.sa1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))));
			this.sa1.Closed = true;
			this.sa1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa1.Name = "sa1";
			this.sa1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(279D, 153D),
			new NxtControl.Drawing.PointF(279D, 167D),
			new NxtControl.Drawing.PointF(288D, 160D)});
			// 
			// tb2
			// 
			this.tb2.Bounds = new NxtControl.Drawing.RectF(((float)(484D)), ((float)(160D)), ((float)(16D)), ((float)(0D)));
			this.tb2.InnerColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230)));
			this.tb2.Name = "tb2";
			this.tb2.OuterColor = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170)));
			this.tb2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(484D, 160D),
			new NxtControl.Drawing.PointF(500D, 160D)});
			this.tb2.Width = 8;
			// 
			// sa2
			// 
			this.sa2.Bounds = new NxtControl.Drawing.RectF(((float)(491D)), ((float)(153D)), ((float)(9D)), ((float)(14D)));
			this.sa2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))));
			this.sa2.Closed = true;
			this.sa2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa2.Name = "sa2";
			this.sa2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(491D, 153D),
			new NxtControl.Drawing.PointF(491D, 167D),
			new NxtControl.Drawing.PointF(500D, 160D)});
			// 
			// tb3
			// 
			this.tb3.Bounds = new NxtControl.Drawing.RectF(((float)(748D)), ((float)(160D)), ((float)(16D)), ((float)(0D)));
			this.tb3.InnerColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230)));
			this.tb3.Name = "tb3";
			this.tb3.OuterColor = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170)));
			this.tb3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(748D, 160D),
			new NxtControl.Drawing.PointF(764D, 160D)});
			this.tb3.Width = 8;
			// 
			// sa3
			// 
			this.sa3.Bounds = new NxtControl.Drawing.RectF(((float)(755D)), ((float)(153D)), ((float)(9D)), ((float)(14D)));
			this.sa3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))));
			this.sa3.Closed = true;
			this.sa3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa3.Name = "sa3";
			this.sa3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(755D, 153D),
			new NxtControl.Drawing.PointF(755D, 167D),
			new NxtControl.Drawing.PointF(764D, 160D)});
			// 
			// tb4
			// 
			this.tb4.Bounds = new NxtControl.Drawing.RectF(((float)(1156D)), ((float)(160D)), ((float)(16D)), ((float)(0D)));
			this.tb4.InnerColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230)));
			this.tb4.Name = "tb4";
			this.tb4.OuterColor = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170)));
			this.tb4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1156D, 160D),
			new NxtControl.Drawing.PointF(1172D, 160D)});
			this.tb4.Width = 8;
			// 
			// sa4
			// 
			this.sa4.Bounds = new NxtControl.Drawing.RectF(((float)(1163D)), ((float)(153D)), ((float)(9D)), ((float)(14D)));
			this.sa4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))));
			this.sa4.Closed = true;
			this.sa4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa4.Name = "sa4";
			this.sa4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1163D, 153D),
			new NxtControl.Drawing.PointF(1163D, 167D),
			new NxtControl.Drawing.PointF(1172D, 160D)});
			// 
			// tb5
			// 
			this.tb5.Bounds = new NxtControl.Drawing.RectF(((float)(1264D)), ((float)(370D)), ((float)(0D)), ((float)(22D)));
			this.tb5.InnerColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230)));
			this.tb5.Name = "tb5";
			this.tb5.OuterColor = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170)));
			this.tb5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1264D, 370D),
			new NxtControl.Drawing.PointF(1264D, 392D)});
			this.tb5.Width = 8;
			// 
			// sa5
			// 
			this.sa5.Bounds = new NxtControl.Drawing.RectF(((float)(1257D)), ((float)(383D)), ((float)(14D)), ((float)(9D)));
			this.sa5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))));
			this.sa5.Closed = true;
			this.sa5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa5.Name = "sa5";
			this.sa5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(100)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1257D, 383D),
			new NxtControl.Drawing.PointF(1271D, 383D),
			new NxtControl.Drawing.PointF(1264D, 392D)});
			// 
			// tb6
			// 
			this.tb6.Bounds = new NxtControl.Drawing.RectF(((float)(960D)), ((float)(370D)), ((float)(0D)), ((float)(22D)));
			this.tb6.InnerColor = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(150)), ((byte)(80)));
			this.tb6.Name = "tb6";
			this.tb6.OuterColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30)));
			this.tb6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(960D, 370D),
			new NxtControl.Drawing.PointF(960D, 392D)});
			this.tb6.Width = 8;
			// 
			// sa6
			// 
			this.sa6.Bounds = new NxtControl.Drawing.RectF(((float)(953D)), ((float)(383D)), ((float)(14D)), ((float)(9D)));
			this.sa6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30))));
			this.sa6.Closed = true;
			this.sa6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa6.Name = "sa6";
			this.sa6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(953D, 383D),
			new NxtControl.Drawing.PointF(967D, 383D),
			new NxtControl.Drawing.PointF(960D, 392D)});
			// 
			// tb7
			// 
			this.tb7.Bounds = new NxtControl.Drawing.RectF(((float)(748D)), ((float)(512D)), ((float)(16D)), ((float)(0D)));
			this.tb7.InnerColor = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(150)), ((byte)(80)));
			this.tb7.Name = "tb7";
			this.tb7.OuterColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30)));
			this.tb7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(764D, 512D),
			new NxtControl.Drawing.PointF(748D, 512D)});
			this.tb7.Width = 8;
			// 
			// sa7
			// 
			this.sa7.Bounds = new NxtControl.Drawing.RectF(((float)(748D)), ((float)(505D)), ((float)(9D)), ((float)(14D)));
			this.sa7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30))));
			this.sa7.Closed = true;
			this.sa7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa7.Name = "sa7";
			this.sa7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(757D, 505D),
			new NxtControl.Drawing.PointF(757D, 519D),
			new NxtControl.Drawing.PointF(748D, 512D)});
			// 
			// tb8
			// 
			this.tb8.Bounds = new NxtControl.Drawing.RectF(((float)(484D)), ((float)(512D)), ((float)(16D)), ((float)(0D)));
			this.tb8.InnerColor = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(150)), ((byte)(80)));
			this.tb8.Name = "tb8";
			this.tb8.OuterColor = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30)));
			this.tb8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(500D, 512D),
			new NxtControl.Drawing.PointF(484D, 512D)});
			this.tb8.Width = 8;
			// 
			// sa8
			// 
			this.sa8.Bounds = new NxtControl.Drawing.RectF(((float)(484D)), ((float)(505D)), ((float)(9D)), ((float)(14D)));
			this.sa8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30))));
			this.sa8.Closed = true;
			this.sa8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sa8.Name = "sa8";
			this.sa8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(80)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sa8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(493D, 505D),
			new NxtControl.Drawing.PointF(493D, 519D),
			new NxtControl.Drawing.PointF(484D, 512D)});
			// 
			// VISAO_GERAL
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.qEEE,
			this.qPRE,
			this.qINF,
			this.qREA,
			this.qDES,
			this.qSLB,
			this.qEST,
			this.qFS,
			this.qAR,
			this.tb1,
			this.sa1,
			this.tb2,
			this.sa2,
			this.tb3,
			this.sa3,
			this.tb4,
			this.sa4,
			this.tb5,
			this.sa5,
			this.tb6,
			this.sa6,
			this.tb7,
			this.sa7,
			this.tb8,
			this.sa8,
			this.irEEE,
			this.irPRE,
			this.irINF,
			this.irREA,
			this.irDES,
			this.irSLB,
			this.irEST,
			this.irFS,
			this.irAR,
			this.tx1,
			this.tx2,
			this.tx3,
			this.tx4,
			this.tx5,
			this.tx6,
			this.tx7,
			this.tx8,
			this.tx9,
			this.tx10,
			this.tx11,
			this.tx12,
			this.tx13,
			this.tx14,
			this.tx15,
			this.tx16,
			this.tx17,
			this.tx18,
			this.tx19,
			this.tx20,
			this.tx21,
			this.tx22,
			this.tx23,
			this.tx24,
			this.tx25,
			this.tx26,
			this.tx27,
			this.tx28,
			this.tx29,
			this.tx30,
			this.tx31,
			this.tx32,
			this.tx33,
			this.tx34,
			this.tx35,
			this.tx36,
			this.tx37,
			this.tx38,
			this.tx39,
			this.tx40,
			this.tx41,
			this.tx42,
			this.tx43,
			this.tx44,
			this.tx45,
			this.tx46,
			this.tx47,
			this.tx48,
			this.tx49,
			this.pctInf,
			this.faseR1,
			this.pctR1,
			this.faseR2,
			this.pctR2,
			this.faseSB,
			this.pctSB,
			this.bs101,
			this.bs102,
			this.bs103,
			this.gm10001,
			this.gm10002,
			this.rt10001,
			this.lit10003,
			this.gord1,
			this.gord2,
			this.gord3,
			this.ft4002,
			this.p4001,
			this.p4002,
			this.p4003,
			this.infNivel,
			this.infVazao,
			this.r1Nivel,
			this.r2Nivel,
			this.v4601,
			this.v4602,
			this.v4603,
			this.v4604,
			this.vc70001,
			this.ft70001,
			this.slbNivel,
			this.slbVazao,
			this.p4901,
			this.p4902,
			this.p4903,
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
			this.btnResetGeral,
			this.btnReconhecerGeral,
			this.repAI1,
			this.repHH1,
			this.repH1,
			this.repL1,
			this.repLL1,
			this.repAI2,
			this.repHH2,
			this.repH2,
			this.repL2,
			this.repLL2,
			this.repAIft,
			this.repHHft,
			this.repHft,
			this.repLft,
			this.repLLft,
			this.lgP4001,
			this.lgP4002,
			this.lgP4003,
			this.lgV4601,
			this.lgV4602,
			this.lgV4603,
			this.lgV4604,
			this.lgP4901,
			this.lgP4902,
			this.lgP4903});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.ChangeCanvasButton irEEE;
		private NxtControl.GuiFramework.ChangeCanvasButton irPRE;
		private NxtControl.GuiFramework.ChangeCanvasButton irINF;
		private NxtControl.GuiFramework.ChangeCanvasButton irREA;
		private NxtControl.GuiFramework.ChangeCanvasButton irDES;
		private NxtControl.GuiFramework.ChangeCanvasButton irSLB;
		private NxtControl.GuiFramework.ChangeCanvasButton irEST;
		private NxtControl.GuiFramework.ChangeCanvasButton irFS;
		private NxtControl.GuiFramework.ChangeCanvasButton irAR;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bs101;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bs102;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bs103;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade gm10001;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade gm10002;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca rt10001;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto lit10003;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba gord1;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba gord2;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba gord3;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft4002;
		private SE.Nereda.Symbols.Motor_VS.sPump p4001;
		private SE.Nereda.Symbols.Motor_VS.sPump p4002;
		private SE.Nereda.Symbols.Motor_VS.sPump p4003;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 infNivel;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 infVazao;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 r1Nivel;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 r2Nivel;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4601;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4602;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4603;
		private SE.Nereda.Symbols.Motor_VS.sBlower v4604;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula vc70001;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft70001;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 slbNivel;
		private SE.Nereda.Symbols.AnalogInput.sDisplayPv1 slbVazao;
		private SE.Nereda.Symbols.Motor_VS.sPump p4901;
		private SE.Nereda.Symbols.Motor_VS.sPump p4902;
		private SE.Nereda.Symbols.Motor_VS.sPump p4903;
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
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		private NxtControl.GuiFramework.DrawnButton btnReconhecerGeral;
		private SE.Nereda.Symbols.AnalogInputBase.sInstanceName repAI1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repHH1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repH1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repL1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repLL1;
		private SE.Nereda.Symbols.AnalogInputBase.sInstanceName repAI2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repHH2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repH2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repL2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repLL2;
		private SE.Nereda.Symbols.AnalogInputBase.sInstanceName repAIft;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repHHft;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repHft;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repLft;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repLLft;
		private NxtControl.GuiFramework.Rectangle qEEE;
		private NxtControl.GuiFramework.Rectangle tx1;
		private NxtControl.GuiFramework.Rectangle tx2;
		private NxtControl.GuiFramework.Rectangle lgP4001;
		private NxtControl.GuiFramework.Rectangle lgP4002;
		private NxtControl.GuiFramework.Rectangle lgP4003;
		private NxtControl.GuiFramework.Rectangle lgV4601;
		private NxtControl.GuiFramework.Rectangle lgV4602;
		private NxtControl.GuiFramework.Rectangle lgV4603;
		private NxtControl.GuiFramework.Rectangle lgV4604;
		private NxtControl.GuiFramework.Rectangle lgP4901;
		private NxtControl.GuiFramework.Rectangle lgP4902;
		private NxtControl.GuiFramework.Rectangle lgP4903;
		private NxtControl.GuiFramework.Rectangle tx3;
		private NxtControl.GuiFramework.Rectangle tx4;
		private NxtControl.GuiFramework.Rectangle tx5;
		private NxtControl.GuiFramework.Rectangle tx6;
		private NxtControl.GuiFramework.Rectangle tx7;
		private NxtControl.GuiFramework.Rectangle tx8;
		private NxtControl.GuiFramework.Rectangle tx9;
		private NxtControl.GuiFramework.Rectangle qPRE;
		private NxtControl.GuiFramework.Rectangle tx10;
		private NxtControl.GuiFramework.Rectangle tx11;
		private NxtControl.GuiFramework.Rectangle tx12;
		private NxtControl.GuiFramework.Rectangle tx13;
		private NxtControl.GuiFramework.Rectangle tx14;
		private NxtControl.GuiFramework.Rectangle tx15;
		private NxtControl.GuiFramework.Rectangle qINF;
		private NxtControl.GuiFramework.Rectangle tx16;
		private NxtControl.GuiFramework.Rectangle tx17;
		private NxtControl.GuiFramework.Rectangle tx18;
		private SE.Nereda.Symbols.AnalogInput.sPorcentagem pctInf;
		private NxtControl.GuiFramework.Rectangle tx19;
		private NxtControl.GuiFramework.Rectangle qREA;
		private NxtControl.GuiFramework.Rectangle tx20;
		private SE.Nereda.Symbols.NeredaReactor.sFase faseR1;
		private NxtControl.GuiFramework.Rectangle tx21;
		private SE.Nereda.Symbols.AnalogInput.sPorcentagem pctR1;
		private SE.Nereda.Symbols.NeredaReactor.sFase faseR2;
		private NxtControl.GuiFramework.Rectangle tx22;
		private SE.Nereda.Symbols.AnalogInput.sPorcentagem pctR2;
		private NxtControl.GuiFramework.Rectangle tx23;
		private NxtControl.GuiFramework.Rectangle qDES;
		private NxtControl.GuiFramework.Rectangle tx24;
		private NxtControl.GuiFramework.Rectangle tx25;
		private NxtControl.GuiFramework.Rectangle tx26;
		private NxtControl.GuiFramework.Rectangle tx27;
		private NxtControl.GuiFramework.Rectangle qSLB;
		private NxtControl.GuiFramework.Rectangle tx28;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sFase faseSB;
		private NxtControl.GuiFramework.Rectangle tx29;
		private SE.Nereda.Symbols.AnalogInput.sPorcentagem pctSB;
		private NxtControl.GuiFramework.Rectangle tx30;
		private NxtControl.GuiFramework.Rectangle tx31;
		private NxtControl.GuiFramework.Rectangle qEST;
		private NxtControl.GuiFramework.Rectangle tx32;
		private NxtControl.GuiFramework.Rectangle tx33;
		private NxtControl.GuiFramework.Rectangle tx34;
		private NxtControl.GuiFramework.Rectangle tx35;
		private NxtControl.GuiFramework.Rectangle tx36;
		private NxtControl.GuiFramework.Rectangle tx37;
		private NxtControl.GuiFramework.Rectangle qFS;
		private NxtControl.GuiFramework.Rectangle tx38;
		private NxtControl.GuiFramework.Rectangle tx39;
		private NxtControl.GuiFramework.Rectangle tx40;
		private NxtControl.GuiFramework.Rectangle tx41;
		private NxtControl.GuiFramework.Rectangle tx42;
		private NxtControl.GuiFramework.Rectangle tx43;
		private NxtControl.GuiFramework.Rectangle tx44;
		private NxtControl.GuiFramework.Rectangle tx45;
		private NxtControl.GuiFramework.Rectangle tx46;
		private NxtControl.GuiFramework.Rectangle qAR;
		private NxtControl.GuiFramework.Rectangle tx47;
		private NxtControl.GuiFramework.Rectangle tx48;
		private NxtControl.GuiFramework.Rectangle tx49;
		private NxtControl.GuiFramework.Pipe tb1;
		private NxtControl.GuiFramework.Polygon sa1;
		private NxtControl.GuiFramework.Pipe tb2;
		private NxtControl.GuiFramework.Polygon sa2;
		private NxtControl.GuiFramework.Pipe tb3;
		private NxtControl.GuiFramework.Polygon sa3;
		private NxtControl.GuiFramework.Pipe tb4;
		private NxtControl.GuiFramework.Polygon sa4;
		private NxtControl.GuiFramework.Pipe tb5;
		private NxtControl.GuiFramework.Polygon sa5;
		private NxtControl.GuiFramework.Pipe tb6;
		private NxtControl.GuiFramework.Polygon sa6;
		private NxtControl.GuiFramework.Pipe tb7;
		private NxtControl.GuiFramework.Polygon sa7;
		private NxtControl.GuiFramework.Pipe tb8;
		private NxtControl.GuiFramework.Polygon sa8;
		#endregion
	}
}
