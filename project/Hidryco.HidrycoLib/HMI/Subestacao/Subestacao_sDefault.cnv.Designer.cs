/*
 * Hidryco - Subestacao - sDefault
 * Unifilar do QGBT 440 V: QTAM 1 (G2) e QTAM 2 (G1), 1Q1/1Q0/1Q2, barras A e B, saidas e QGBT 220 V. Vermelho = fechado, verde = aberto.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Subestacao
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.tRede = new NxtControl.GuiFramework.FreeText();
			this.trafoA = new NxtControl.GuiFramework.Ellipse();
			this.trafoB = new NxtControl.GuiFramework.Ellipse();
			this.tTrafo = new NxtControl.GuiFramework.FreeText();
			this.lRedeTopo = new NxtControl.GuiFramework.Line();
			this.lTrafoQ1 = new NxtControl.GuiFramework.Line();
			this.lTrafoQ2 = new NxtControl.GuiFramework.Line();
			this.lTrafoMeio = new NxtControl.GuiFramework.Line();
			this.lTrafoMeio2 = new NxtControl.GuiFramework.Line();
			this.caixaQTAM1 = new NxtControl.GuiFramework.Rectangle();
			this.tQTAM1 = new NxtControl.GuiFramework.FreeText();
			this.symG2 = new Hidryco.HidrycoLib.Symbols.Gerador_Generico.sDefault();
			this.lGQTAM1 = new NxtControl.GuiFramework.Line();
			this.lQ2QTAM1 = new NxtControl.GuiFramework.Line();
			this.lQ1QTAM1 = new NxtControl.GuiFramework.Line();
			this.bQ2QTAM1 = new NxtControl.GuiFramework.Rectangle();
			this.tQ2QTAM1 = new NxtControl.GuiFramework.FreeText();
			this.bQ1QTAM1 = new NxtControl.GuiFramework.Rectangle();
			this.tQ1QTAM1 = new NxtControl.GuiFramework.FreeText();
			this.noQTAM1 = new NxtControl.GuiFramework.Rectangle();
			this.tFonteQTAM1 = new NxtControl.GuiFramework.FreeText();
			this.caixaQTAM2 = new NxtControl.GuiFramework.Rectangle();
			this.tQTAM2 = new NxtControl.GuiFramework.FreeText();
			this.symG1 = new Hidryco.HidrycoLib.Symbols.Gerador_Generico.sDefault();
			this.lQ1QTAM2 = new NxtControl.GuiFramework.Line();
			this.lQ2QTAM2 = new NxtControl.GuiFramework.Line();
			this.lGQTAM2 = new NxtControl.GuiFramework.Line();
			this.bQ2QTAM2 = new NxtControl.GuiFramework.Rectangle();
			this.tQ2QTAM2 = new NxtControl.GuiFramework.FreeText();
			this.bQ1QTAM2 = new NxtControl.GuiFramework.Rectangle();
			this.tQ1QTAM2 = new NxtControl.GuiFramework.FreeText();
			this.noQTAM2 = new NxtControl.GuiFramework.Rectangle();
			this.tFonteQTAM2 = new NxtControl.GuiFramework.FreeText();
			this.lSai1Q1 = new NxtControl.GuiFramework.Line();
			this.b1Q1 = new NxtControl.GuiFramework.Rectangle();
			this.abrir1Q1 = new NxtControl.GuiFramework.DrawnButton();
			this.lEnt1Q1 = new NxtControl.GuiFramework.Line();
			this.tNome1Q1 = new NxtControl.GuiFramework.FreeText();
			this.tEst1Q1 = new NxtControl.GuiFramework.FreeText();
			this.tSt1Q1 = new NxtControl.GuiFramework.FreeText();
			this.lSai1Q2 = new NxtControl.GuiFramework.Line();
			this.b1Q2 = new NxtControl.GuiFramework.Rectangle();
			this.abrir1Q2 = new NxtControl.GuiFramework.DrawnButton();
			this.lEnt1Q2 = new NxtControl.GuiFramework.Line();
			this.tNome1Q2 = new NxtControl.GuiFramework.FreeText();
			this.tEst1Q2 = new NxtControl.GuiFramework.FreeText();
			this.tSt1Q2 = new NxtControl.GuiFramework.FreeText();
			this.barraA = new NxtControl.GuiFramework.Rectangle();
			this.barraB = new NxtControl.GuiFramework.Rectangle();
			this.tBarraA = new NxtControl.GuiFramework.FreeText();
			this.tBarraB = new NxtControl.GuiFramework.FreeText();
			this.lAcopA = new NxtControl.GuiFramework.Line();
			this.lAcopA2 = new NxtControl.GuiFramework.Line();
			this.b1Q0 = new NxtControl.GuiFramework.Rectangle();
			this.abrir1Q0 = new NxtControl.GuiFramework.DrawnButton();
			this.lAcopB2 = new NxtControl.GuiFramework.Line();
			this.lAcopB = new NxtControl.GuiFramework.Line();
			this.tNome1Q0 = new NxtControl.GuiFramework.FreeText();
			this.tEst1Q0 = new NxtControl.GuiFramework.FreeText();
			this.tSt1Q0 = new NxtControl.GuiFramework.FreeText();
			this.lARES_A1 = new NxtControl.GuiFramework.Line();
			this.bRES_A1 = new NxtControl.GuiFramework.Rectangle();
			this.l2ARES_A1 = new NxtControl.GuiFramework.Line();
			this.tRES_A1 = new NxtControl.GuiFramework.FreeText();
			this.lARES_A2 = new NxtControl.GuiFramework.Line();
			this.bRES_A2 = new NxtControl.GuiFramework.Rectangle();
			this.l2ARES_A2 = new NxtControl.GuiFramework.Line();
			this.tRES_A2 = new NxtControl.GuiFramework.FreeText();
			this.lAPCM_EEE_BRUTO = new NxtControl.GuiFramework.Line();
			this.bPCM_EEE_BRUTO = new NxtControl.GuiFramework.Rectangle();
			this.l2APCM_EEE_BRUTO = new NxtControl.GuiFramework.Line();
			this.tPCM_EEE_BRUTO = new NxtControl.GuiFramework.FreeText();
			this.lAPCM_DESINFECCAO = new NxtControl.GuiFramework.Line();
			this.bPCM_DESINFECCAO = new NxtControl.GuiFramework.Rectangle();
			this.l2APCM_DESINFECCAO = new NxtControl.GuiFramework.Line();
			this.tPCM_DESINFECCAO = new NxtControl.GuiFramework.FreeText();
			this.lAQGBT_220V = new NxtControl.GuiFramework.Line();
			this.bQGBT_220V = new NxtControl.GuiFramework.Rectangle();
			this.l2AQGBT_220V = new NxtControl.GuiFramework.Line();
			this.tQGBT_220V = new NxtControl.GuiFramework.FreeText();
			this.lAUCT_200_01 = new NxtControl.GuiFramework.Line();
			this.bUCT_200_01 = new NxtControl.GuiFramework.Rectangle();
			this.l2AUCT_200_01 = new NxtControl.GuiFramework.Line();
			this.tUCT_200_01 = new NxtControl.GuiFramework.FreeText();
			this.lACOMP_500_02 = new NxtControl.GuiFramework.Line();
			this.bCOMP_500_02 = new NxtControl.GuiFramework.Rectangle();
			this.l2ACOMP_500_02 = new NxtControl.GuiFramework.Line();
			this.tCOMP_500_02 = new NxtControl.GuiFramework.FreeText();
			this.lAV4603 = new NxtControl.GuiFramework.Line();
			this.bV4603 = new NxtControl.GuiFramework.Rectangle();
			this.l2AV4603 = new NxtControl.GuiFramework.Line();
			this.tV4603 = new NxtControl.GuiFramework.FreeText();
			this.lAV4604 = new NxtControl.GuiFramework.Line();
			this.bV4604 = new NxtControl.GuiFramework.Rectangle();
			this.l2AV4604 = new NxtControl.GuiFramework.Line();
			this.tV4604 = new NxtControl.GuiFramework.FreeText();
			this.lABANCO_CAPACITORES = new NxtControl.GuiFramework.Line();
			this.bBANCO_CAPACITORES = new NxtControl.GuiFramework.Rectangle();
			this.l2ABANCO_CAPACITORES = new NxtControl.GuiFramework.Line();
			this.tBANCO_CAPACITORES = new NxtControl.GuiFramework.FreeText();
			this.lBPCE_SUBESTACAO = new NxtControl.GuiFramework.Line();
			this.bPCE_SUBESTACAO = new NxtControl.GuiFramework.Rectangle();
			this.l2BPCE_SUBESTACAO = new NxtControl.GuiFramework.Line();
			this.tPCE_SUBESTACAO = new NxtControl.GuiFramework.FreeText();
			this.lBCOMP_500_01 = new NxtControl.GuiFramework.Line();
			this.bCOMP_500_01 = new NxtControl.GuiFramework.Rectangle();
			this.l2BCOMP_500_01 = new NxtControl.GuiFramework.Line();
			this.tCOMP_500_01 = new NxtControl.GuiFramework.FreeText();
			this.lBUCT_200_02 = new NxtControl.GuiFramework.Line();
			this.bUCT_200_02 = new NxtControl.GuiFramework.Rectangle();
			this.l2BUCT_200_02 = new NxtControl.GuiFramework.Line();
			this.tUCT_200_02 = new NxtControl.GuiFramework.FreeText();
			this.lBUCT_200_03 = new NxtControl.GuiFramework.Line();
			this.bUCT_200_03 = new NxtControl.GuiFramework.Rectangle();
			this.l2BUCT_200_03 = new NxtControl.GuiFramework.Line();
			this.tUCT_200_03 = new NxtControl.GuiFramework.FreeText();
			this.lBPCM_NEREDA = new NxtControl.GuiFramework.Line();
			this.bPCM_NEREDA = new NxtControl.GuiFramework.Rectangle();
			this.l2BPCM_NEREDA = new NxtControl.GuiFramework.Line();
			this.tPCM_NEREDA = new NxtControl.GuiFramework.FreeText();
			this.lBPCM_LODO = new NxtControl.GuiFramework.Line();
			this.bPCM_LODO = new NxtControl.GuiFramework.Rectangle();
			this.l2BPCM_LODO = new NxtControl.GuiFramework.Line();
			this.tPCM_LODO = new NxtControl.GuiFramework.FreeText();
			this.lBCAP2 = new NxtControl.GuiFramework.Line();
			this.bCAP2 = new NxtControl.GuiFramework.Rectangle();
			this.l2BCAP2 = new NxtControl.GuiFramework.Line();
			this.tCAP2 = new NxtControl.GuiFramework.FreeText();
			this.lBPCM_AGUA_REUSO = new NxtControl.GuiFramework.Line();
			this.bPCM_AGUA_REUSO = new NxtControl.GuiFramework.Rectangle();
			this.l2BPCM_AGUA_REUSO = new NxtControl.GuiFramework.Line();
			this.tPCM_AGUA_REUSO = new NxtControl.GuiFramework.FreeText();
			this.lBMO_500_01 = new NxtControl.GuiFramework.Line();
			this.bMO_500_01 = new NxtControl.GuiFramework.Rectangle();
			this.l2BMO_500_01 = new NxtControl.GuiFramework.Line();
			this.tMO_500_01 = new NxtControl.GuiFramework.FreeText();
			this.lBV4601 = new NxtControl.GuiFramework.Line();
			this.bV4601 = new NxtControl.GuiFramework.Rectangle();
			this.l2BV4601 = new NxtControl.GuiFramework.Line();
			this.tV4601 = new NxtControl.GuiFramework.FreeText();
			this.lBV4602 = new NxtControl.GuiFramework.Line();
			this.bV4602 = new NxtControl.GuiFramework.Rectangle();
			this.l2BV4602 = new NxtControl.GuiFramework.Line();
			this.tV4602 = new NxtControl.GuiFramework.FreeText();
			this.lBRES_B1 = new NxtControl.GuiFramework.Line();
			this.bRES_B1 = new NxtControl.GuiFramework.Rectangle();
			this.l2BRES_B1 = new NxtControl.GuiFramework.Line();
			this.tRES_B1 = new NxtControl.GuiFramework.FreeText();
			this.lBRES_B2 = new NxtControl.GuiFramework.Line();
			this.bRES_B2 = new NxtControl.GuiFramework.Rectangle();
			this.l2BRES_B2 = new NxtControl.GuiFramework.Line();
			this.tRES_B2 = new NxtControl.GuiFramework.FreeText();
			this.lBRES_B3 = new NxtControl.GuiFramework.Line();
			this.bRES_B3 = new NxtControl.GuiFramework.Rectangle();
			this.l2BRES_B3 = new NxtControl.GuiFramework.Line();
			this.tRES_B3 = new NxtControl.GuiFramework.FreeText();
			this.l220a = new NxtControl.GuiFramework.Line();
			this.t220a = new NxtControl.GuiFramework.Ellipse();
			this.t220b = new NxtControl.GuiFramework.Ellipse();
			this.tTr220 = new NxtControl.GuiFramework.FreeText();
			this.l220b = new NxtControl.GuiFramework.Line();
			this.bQGBT_220V_ENTRADA = new NxtControl.GuiFramework.Rectangle();
			this.tQGBT_220V_ENTRADA = new NxtControl.GuiFramework.FreeText();
			this.l220c = new NxtControl.GuiFramework.Line();
			this.barra220 = new NxtControl.GuiFramework.Rectangle();
			this.tBarra220 = new NxtControl.GuiFramework.FreeText();
			this.lCQL_ADM = new NxtControl.GuiFramework.Line();
			this.bQL_ADM = new NxtControl.GuiFramework.Rectangle();
			this.l2CQL_ADM = new NxtControl.GuiFramework.Line();
			this.tQL_ADM = new NxtControl.GuiFramework.FreeText();
			this.lCQL_PORTARIA = new NxtControl.GuiFramework.Line();
			this.bQL_PORTARIA = new NxtControl.GuiFramework.Rectangle();
			this.l2CQL_PORTARIA = new NxtControl.GuiFramework.Line();
			this.tQL_PORTARIA = new NxtControl.GuiFramework.FreeText();
			this.lCQLSL = new NxtControl.GuiFramework.Line();
			this.bQLSL = new NxtControl.GuiFramework.Rectangle();
			this.l2CQLSL = new NxtControl.GuiFramework.Line();
			this.tQLSL = new NxtControl.GuiFramework.FreeText();
			this.lCQL_ILUMINACAO = new NxtControl.GuiFramework.Line();
			this.bQL_ILUMINACAO = new NxtControl.GuiFramework.Rectangle();
			this.l2CQL_ILUMINACAO = new NxtControl.GuiFramework.Line();
			this.tQL_ILUMINACAO = new NxtControl.GuiFramework.FreeText();
			this.lCPCE_SOPRADORES = new NxtControl.GuiFramework.Line();
			this.bPCE_SOPRADORES = new NxtControl.GuiFramework.Rectangle();
			this.l2CPCE_SOPRADORES = new NxtControl.GuiFramework.Line();
			this.tPCE_SOPRADORES = new NxtControl.GuiFramework.FreeText();
			this.lCQL_LODO = new NxtControl.GuiFramework.Line();
			this.bQL_LODO = new NxtControl.GuiFramework.Rectangle();
			this.l2CQL_LODO = new NxtControl.GuiFramework.Line();
			this.tQL_LODO = new NxtControl.GuiFramework.FreeText();
			this.lCRES_C1 = new NxtControl.GuiFramework.Line();
			this.bRES_C1 = new NxtControl.GuiFramework.Rectangle();
			this.l2CRES_C1 = new NxtControl.GuiFramework.Line();
			this.tRES_C1 = new NxtControl.GuiFramework.FreeText();
			this.lCRES_C2 = new NxtControl.GuiFramework.Line();
			this.bRES_C2 = new NxtControl.GuiFramework.Rectangle();
			this.l2CRES_C2 = new NxtControl.GuiFramework.Line();
			this.tRES_C2 = new NxtControl.GuiFramework.FreeText();
			this.lCRES_C3 = new NxtControl.GuiFramework.Line();
			this.bRES_C3 = new NxtControl.GuiFramework.Rectangle();
			this.l2CRES_C3 = new NxtControl.GuiFramework.Line();
			this.tRES_C3 = new NxtControl.GuiFramework.FreeText();
			this.lCRES_C4 = new NxtControl.GuiFramework.Line();
			this.bRES_C4 = new NxtControl.GuiFramework.Rectangle();
			this.l2CRES_C4 = new NxtControl.GuiFramework.Line();
			this.tRES_C4 = new NxtControl.GuiFramework.FreeText();
			this.lCRES_C5 = new NxtControl.GuiFramework.Line();
			this.bRES_C5 = new NxtControl.GuiFramework.Rectangle();
			this.l2CRES_C5 = new NxtControl.GuiFramework.Line();
			this.tRES_C5 = new NxtControl.GuiFramework.FreeText();
			this.lCRES_C6 = new NxtControl.GuiFramework.Line();
			this.bRES_C6 = new NxtControl.GuiFramework.Rectangle();
			this.l2CRES_C6 = new NxtControl.GuiFramework.Line();
			this.tRES_C6 = new NxtControl.GuiFramework.FreeText();
			this.painel = new NxtControl.GuiFramework.Rectangle();
			this.tPlanta = new NxtControl.GuiFramework.FreeText();
			this.tRemota = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.btnCargas = new NxtControl.GuiFramework.DrawnButton();
			this.btnComandos = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.xDJ_RES_A1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_A2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_PCM_EEE_BRUTO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_PCM_DESINFECCAO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_QGBT_220V = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_UCT_200_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_COMP_500_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_V4603 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_V4604 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_BANCO_CAPACITORES = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_PCE_SUBESTACAO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_COMP_500_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_UCT_200_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_UCT_200_03 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_PCM_NEREDA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_PCM_LODO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_CAP2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_PCM_AGUA_REUSO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_MO_500_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_V4601 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_V4602 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_B1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_B2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_B3 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_QGBT_220V_ENTRADA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_QL_ADM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_QL_PORTARIA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_QLSL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_QL_ILUMINACAO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_PCE_SOPRADORES = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_QL_LODO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_C1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_C2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_C3 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_C4 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_C5 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_RES_C6 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPL_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPR_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPP_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPC_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPSF_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPL_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPR_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPP_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPC_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPSF_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPL_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPR_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPP_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPC_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMPSF_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEST_1Q1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xEST_1Q0 = new System.HMI.Symbols.Base.Execute<short>();
			this.xEST_1Q2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xFA = new System.HMI.Symbols.Base.Execute<short>();
			this.xFB = new System.HMI.Symbols.Base.Execute<short>();
			this.xPlanta = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRemota = new System.HMI.Symbols.Base.Execute<bool>();
			this.xQTAM1_GERADOR = new System.HMI.Symbols.Base.Execute<short>();
			this.xQTAM1_REDE = new System.HMI.Symbols.Base.Execute<short>();
			this.xQTAM2_GERADOR = new System.HMI.Symbols.Base.Execute<short>();
			this.xQTAM2_REDE = new System.HMI.Symbols.Base.Execute<short>();
			this.xAF1q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAF1q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAF1q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAD1q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAD1q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAD1q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAC1q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAC1q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAC1q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEF1q1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEF1q0 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEF1q2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xED1q1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xED1q0 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xED1q2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEC1q1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEC1q0 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEC1q2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.pNER = new NxtControl.GuiFramework.Rectangle();
			this.pNERt = new NxtControl.GuiFramework.FreeText();
			this.pNERc = new NxtControl.GuiFramework.FreeText();
			this.pNERbar = new NxtControl.GuiFramework.Rectangle();
			this.lpNER_PCE = new NxtControl.GuiFramework.Line();
			this.bpNER_PCE = new NxtControl.GuiFramework.Rectangle();
			this.tpNER_PCE = new NxtControl.GuiFramework.FreeText();
			this.lpNER_PCM = new NxtControl.GuiFramework.Line();
			this.bpNER_PCM = new NxtControl.GuiFramework.Rectangle();
			this.tpNER_PCM = new NxtControl.GuiFramework.FreeText();
			this.lpMO_300_01 = new NxtControl.GuiFramework.Line();
			this.bpMO_300_01 = new NxtControl.GuiFramework.Rectangle();
			this.tpMO_300_01 = new NxtControl.GuiFramework.FreeText();
			this.lpR4005A = new NxtControl.GuiFramework.Line();
			this.bpR4005A = new NxtControl.GuiFramework.Rectangle();
			this.tpR4005A = new NxtControl.GuiFramework.FreeText();
			this.lpR4005B = new NxtControl.GuiFramework.Line();
			this.bpR4005B = new NxtControl.GuiFramework.Rectangle();
			this.tpR4005B = new NxtControl.GuiFramework.FreeText();
			this.lpP4901 = new NxtControl.GuiFramework.Line();
			this.bpP4901 = new NxtControl.GuiFramework.Rectangle();
			this.tpP4901 = new NxtControl.GuiFramework.FreeText();
			this.lpP4902 = new NxtControl.GuiFramework.Line();
			this.bpP4902 = new NxtControl.GuiFramework.Rectangle();
			this.tpP4902 = new NxtControl.GuiFramework.FreeText();
			this.lpP4903 = new NxtControl.GuiFramework.Line();
			this.bpP4903 = new NxtControl.GuiFramework.Rectangle();
			this.tpP4903 = new NxtControl.GuiFramework.FreeText();
			this.pDES = new NxtControl.GuiFramework.Rectangle();
			this.pDESt = new NxtControl.GuiFramework.FreeText();
			this.pDESc = new NxtControl.GuiFramework.FreeText();
			this.pDESbar = new NxtControl.GuiFramework.Rectangle();
			this.lpDES_PCE = new NxtControl.GuiFramework.Line();
			this.bpDES_PCE = new NxtControl.GuiFramework.Rectangle();
			this.tpDES_PCE = new NxtControl.GuiFramework.FreeText();
			this.lpDES_PCM = new NxtControl.GuiFramework.Line();
			this.bpDES_PCM = new NxtControl.GuiFramework.Rectangle();
			this.tpDES_PCM = new NxtControl.GuiFramework.FreeText();
			this.lpUV_700_01 = new NxtControl.GuiFramework.Line();
			this.bpUV_700_01 = new NxtControl.GuiFramework.Rectangle();
			this.tpUV_700_01 = new NxtControl.GuiFramework.FreeText();
			this.lpUV_700_02 = new NxtControl.GuiFramework.Line();
			this.bpUV_700_02 = new NxtControl.GuiFramework.Rectangle();
			this.tpUV_700_02 = new NxtControl.GuiFramework.FreeText();
			this.lpVC_700_01 = new NxtControl.GuiFramework.Line();
			this.bpVC_700_01 = new NxtControl.GuiFramework.Rectangle();
			this.tpVC_700_01 = new NxtControl.GuiFramework.FreeText();
			this.lpMO_700_01 = new NxtControl.GuiFramework.Line();
			this.bpMO_700_01 = new NxtControl.GuiFramework.Rectangle();
			this.tpMO_700_01 = new NxtControl.GuiFramework.FreeText();
			this.pEEEB = new NxtControl.GuiFramework.Rectangle();
			this.pEEEBt = new NxtControl.GuiFramework.FreeText();
			this.pEEEBc = new NxtControl.GuiFramework.FreeText();
			this.pEEEBbar = new NxtControl.GuiFramework.Rectangle();
			this.lpEEEB_PCE = new NxtControl.GuiFramework.Line();
			this.bpEEEB_PCE = new NxtControl.GuiFramework.Rectangle();
			this.tpEEEB_PCE = new NxtControl.GuiFramework.FreeText();
			this.lpEEEB_PCM = new NxtControl.GuiFramework.Line();
			this.bpEEEB_PCM = new NxtControl.GuiFramework.Rectangle();
			this.tpEEEB_PCM = new NxtControl.GuiFramework.FreeText();
			this.lpCO_100_01 = new NxtControl.GuiFramework.Line();
			this.bpCO_100_01 = new NxtControl.GuiFramework.Rectangle();
			this.tpCO_100_01 = new NxtControl.GuiFramework.FreeText();
			this.lpCO_100_02 = new NxtControl.GuiFramework.Line();
			this.bpCO_100_02 = new NxtControl.GuiFramework.Rectangle();
			this.tpCO_100_02 = new NxtControl.GuiFramework.FreeText();
			this.lpCO_100_03 = new NxtControl.GuiFramework.Line();
			this.bpCO_100_03 = new NxtControl.GuiFramework.Rectangle();
			this.tpCO_100_03 = new NxtControl.GuiFramework.FreeText();
			this.lpCO_100_04 = new NxtControl.GuiFramework.Line();
			this.bpCO_100_04 = new NxtControl.GuiFramework.Rectangle();
			this.tpCO_100_04 = new NxtControl.GuiFramework.FreeText();
			this.lpGM_100_01_02 = new NxtControl.GuiFramework.Line();
			this.bpGM_100_01_02 = new NxtControl.GuiFramework.Rectangle();
			this.tpGM_100_01_02 = new NxtControl.GuiFramework.FreeText();
			this.lpMO_100_01 = new NxtControl.GuiFramework.Line();
			this.bpMO_100_01 = new NxtControl.GuiFramework.Rectangle();
			this.tpMO_100_01 = new NxtControl.GuiFramework.FreeText();
			this.pLeg = new NxtControl.GuiFramework.Rectangle();
			this.pLegT = new NxtControl.GuiFramework.FreeText();
			this.pLeg0 = new NxtControl.GuiFramework.Rectangle();
			this.pLeg0t = new NxtControl.GuiFramework.FreeText();
			this.pLeg1 = new NxtControl.GuiFramework.Rectangle();
			this.pLeg1t = new NxtControl.GuiFramework.FreeText();
			this.pLeg2 = new NxtControl.GuiFramework.Rectangle();
			this.pLeg2t = new NxtControl.GuiFramework.FreeText();
			this.xDJ_NER_PCE = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_NER_PCM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_MO_300_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_R4005A = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_R4005B = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_P4901 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_P4902 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_P4903 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_EEEB_PCE = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_EEEB_PCM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_CO_100_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_CO_100_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_CO_100_03 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_CO_100_04 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_GM_100_01_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_MO_100_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_DES_PCE_DESLIGADO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_DES_PCM_DESLIGADO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_UV_700_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_UV_700_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_VC_700_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDJ_MO_700_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFALHA_REMOTA_NER = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFALHA_REMOTA_EEEB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFALHA_REMOTA_DES = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1350D)), ((float)(682D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tRede
			// 
			this.tRede.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tRede.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tRede.Location = new NxtControl.Drawing.PointF(590D, 8D);
			this.tRede.Name = "tRede";
			this.tRede.Text = "REDE CPFL 13,8 kV";
			// 
			// trafoA
			// 
			this.trafoA.Bounds = new NxtControl.Drawing.RectF(((float)(655D)), ((float)(30D)), ((float)(30D)), ((float)(30D)));
			this.trafoA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.trafoA.Name = "trafoA";
			this.trafoA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// trafoB
			// 
			this.trafoB.Bounds = new NxtControl.Drawing.RectF(((float)(655D)), ((float)(50D)), ((float)(30D)), ((float)(30D)));
			this.trafoB.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.trafoB.Name = "trafoB";
			this.trafoB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tTrafo
			// 
			this.tTrafo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tTrafo.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tTrafo.Location = new NxtControl.Drawing.PointF(590D, 112D);
			this.tTrafo.Name = "tTrafo";
			this.tTrafo.Text = "TRAFOS 750 kVA\r\n13,8 kV / 440 V";
			// 
			// lRedeTopo
			// 
			this.lRedeTopo.EndPoint = new NxtControl.Drawing.PointF(670D, 30D);
			this.lRedeTopo.Name = "lRedeTopo";
			this.lRedeTopo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lRedeTopo.StartPoint = new NxtControl.Drawing.PointF(670D, 24D);
			// 
			// lTrafoQ1
			// 
			this.lTrafoQ1.EndPoint = new NxtControl.Drawing.PointF(520D, 92D);
			this.lTrafoQ1.Name = "lTrafoQ1";
			this.lTrafoQ1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lTrafoQ1.StartPoint = new NxtControl.Drawing.PointF(655D, 92D);
			// 
			// lTrafoQ2
			// 
			this.lTrafoQ2.EndPoint = new NxtControl.Drawing.PointF(830D, 92D);
			this.lTrafoQ2.Name = "lTrafoQ2";
			this.lTrafoQ2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lTrafoQ2.StartPoint = new NxtControl.Drawing.PointF(685D, 92D);
			// 
			// lTrafoMeio
			// 
			this.lTrafoMeio.EndPoint = new NxtControl.Drawing.PointF(655D, 92D);
			this.lTrafoMeio.Name = "lTrafoMeio";
			this.lTrafoMeio.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lTrafoMeio.StartPoint = new NxtControl.Drawing.PointF(655D, 80D);
			// 
			// lTrafoMeio2
			// 
			this.lTrafoMeio2.EndPoint = new NxtControl.Drawing.PointF(685D, 92D);
			this.lTrafoMeio2.Name = "lTrafoMeio2";
			this.lTrafoMeio2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lTrafoMeio2.StartPoint = new NxtControl.Drawing.PointF(685D, 80D);
			// 
			// caixaQTAM1
			// 
			this.caixaQTAM1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(18D)), ((float)(500D)), ((float)(160D)));
			this.caixaQTAM1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.caixaQTAM1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaQTAM1.Name = "caixaQTAM1";
			this.caixaQTAM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tQTAM1
			// 
			this.tQTAM1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQTAM1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tQTAM1.Location = new NxtControl.Drawing.PointF(28D, 22D);
			this.tQTAM1.Name = "tQTAM1";
			this.tQTAM1.Text = "QTAM 1 - GRUPO GERADOR G2";
			// 
			// symG2
			// 
			this.symG2.BeginInit();
			this.symG2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 30D, 44D);
			this.symG2.Name = "symG2";
			this.symG2.SecurityToken = ((uint)(4294967295u));
			this.symG2.TagName = "GMG_G2";
			this.symG2.EndInit();
			// 
			// lGQTAM1
			// 
			this.lGQTAM1.EndPoint = new NxtControl.Drawing.PointF(330D, 92D);
			this.lGQTAM1.Name = "lGQTAM1";
			this.lGQTAM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lGQTAM1.StartPoint = new NxtControl.Drawing.PointF(280D, 92D);
			// 
			// lQ2QTAM1
			// 
			this.lQ2QTAM1.EndPoint = new NxtControl.Drawing.PointF(460D, 92D);
			this.lQ2QTAM1.Name = "lQ2QTAM1";
			this.lQ2QTAM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lQ2QTAM1.StartPoint = new NxtControl.Drawing.PointF(350D, 92D);
			// 
			// lQ1QTAM1
			// 
			this.lQ1QTAM1.EndPoint = new NxtControl.Drawing.PointF(520D, 92D);
			this.lQ1QTAM1.Name = "lQ1QTAM1";
			this.lQ1QTAM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lQ1QTAM1.StartPoint = new NxtControl.Drawing.PointF(480D, 92D);
			// 
			// bQ2QTAM1
			// 
			this.bQ2QTAM1.Bounds = new NxtControl.Drawing.RectF(((float)(330D)), ((float)(82D)), ((float)(20D)), ((float)(20D)));
			this.bQ2QTAM1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQ2QTAM1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQ2QTAM1.Name = "bQ2QTAM1";
			this.bQ2QTAM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tQ2QTAM1
			// 
			this.tQ2QTAM1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tQ2QTAM1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tQ2QTAM1.Location = new NxtControl.Drawing.PointF(318D, 106D);
			this.tQ2QTAM1.Name = "tQ2QTAM1";
			this.tQ2QTAM1.Text = "Q2 gerador";
			// 
			// bQ1QTAM1
			// 
			this.bQ1QTAM1.Bounds = new NxtControl.Drawing.RectF(((float)(460D)), ((float)(82D)), ((float)(20D)), ((float)(20D)));
			this.bQ1QTAM1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQ1QTAM1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQ1QTAM1.Name = "bQ1QTAM1";
			this.bQ1QTAM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tQ1QTAM1
			// 
			this.tQ1QTAM1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tQ1QTAM1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tQ1QTAM1.Location = new NxtControl.Drawing.PointF(454D, 106D);
			this.tQ1QTAM1.Name = "tQ1QTAM1";
			this.tQ1QTAM1.Text = "Q1 rede";
			// 
			// noQTAM1
			// 
			this.noQTAM1.Bounds = new NxtControl.Drawing.RectF(((float)(407D)), ((float)(89D)), ((float)(6D)), ((float)(6D)));
			this.noQTAM1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.noQTAM1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.noQTAM1.Name = "noQTAM1";
			this.noQTAM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tFonteQTAM1
			// 
			this.tFonteQTAM1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tFonteQTAM1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tFonteQTAM1.Location = new NxtControl.Drawing.PointF(28D, 158D);
			this.tFonteQTAM1.Name = "tFonteQTAM1";
			this.tFonteQTAM1.Text = "Saída: —";
			// 
			// caixaQTAM2
			// 
			this.caixaQTAM2.Bounds = new NxtControl.Drawing.RectF(((float)(830D)), ((float)(18D)), ((float)(500D)), ((float)(160D)));
			this.caixaQTAM2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.caixaQTAM2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaQTAM2.Name = "caixaQTAM2";
			this.caixaQTAM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tQTAM2
			// 
			this.tQTAM2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQTAM2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tQTAM2.Location = new NxtControl.Drawing.PointF(838D, 22D);
			this.tQTAM2.Name = "tQTAM2";
			this.tQTAM2.Text = "QTAM 2 - GRUPO GERADOR G1";
			// 
			// symG1
			// 
			this.symG1.BeginInit();
			this.symG1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1070D, 44D);
			this.symG1.Name = "symG1";
			this.symG1.SecurityToken = ((uint)(4294967295u));
			this.symG1.TagName = "GMG_G1";
			this.symG1.EndInit();
			// 
			// lQ1QTAM2
			// 
			this.lQ1QTAM2.EndPoint = new NxtControl.Drawing.PointF(870D, 92D);
			this.lQ1QTAM2.Name = "lQ1QTAM2";
			this.lQ1QTAM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lQ1QTAM2.StartPoint = new NxtControl.Drawing.PointF(830D, 92D);
			// 
			// lQ2QTAM2
			// 
			this.lQ2QTAM2.EndPoint = new NxtControl.Drawing.PointF(1000D, 92D);
			this.lQ2QTAM2.Name = "lQ2QTAM2";
			this.lQ2QTAM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lQ2QTAM2.StartPoint = new NxtControl.Drawing.PointF(890D, 92D);
			// 
			// lGQTAM2
			// 
			this.lGQTAM2.EndPoint = new NxtControl.Drawing.PointF(1070D, 92D);
			this.lGQTAM2.Name = "lGQTAM2";
			this.lGQTAM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lGQTAM2.StartPoint = new NxtControl.Drawing.PointF(1020D, 92D);
			// 
			// bQ2QTAM2
			// 
			this.bQ2QTAM2.Bounds = new NxtControl.Drawing.RectF(((float)(1000D)), ((float)(82D)), ((float)(20D)), ((float)(20D)));
			this.bQ2QTAM2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQ2QTAM2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQ2QTAM2.Name = "bQ2QTAM2";
			this.bQ2QTAM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tQ2QTAM2
			// 
			this.tQ2QTAM2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tQ2QTAM2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tQ2QTAM2.Location = new NxtControl.Drawing.PointF(988D, 106D);
			this.tQ2QTAM2.Name = "tQ2QTAM2";
			this.tQ2QTAM2.Text = "Q2 gerador";
			// 
			// bQ1QTAM2
			// 
			this.bQ1QTAM2.Bounds = new NxtControl.Drawing.RectF(((float)(870D)), ((float)(82D)), ((float)(20D)), ((float)(20D)));
			this.bQ1QTAM2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQ1QTAM2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQ1QTAM2.Name = "bQ1QTAM2";
			this.bQ1QTAM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tQ1QTAM2
			// 
			this.tQ1QTAM2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tQ1QTAM2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tQ1QTAM2.Location = new NxtControl.Drawing.PointF(864D, 106D);
			this.tQ1QTAM2.Name = "tQ1QTAM2";
			this.tQ1QTAM2.Text = "Q1 rede";
			// 
			// noQTAM2
			// 
			this.noQTAM2.Bounds = new NxtControl.Drawing.RectF(((float)(937D)), ((float)(89D)), ((float)(6D)), ((float)(6D)));
			this.noQTAM2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.noQTAM2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.noQTAM2.Name = "noQTAM2";
			this.noQTAM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tFonteQTAM2
			// 
			this.tFonteQTAM2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tFonteQTAM2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tFonteQTAM2.Location = new NxtControl.Drawing.PointF(838D, 158D);
			this.tFonteQTAM2.Name = "tFonteQTAM2";
			this.tFonteQTAM2.Text = "Saída: —";
			// 
			// lSai1Q1
			// 
			this.lSai1Q1.EndPoint = new NxtControl.Drawing.PointF(410D, 217D);
			this.lSai1Q1.Name = "lSai1Q1";
			this.lSai1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lSai1Q1.StartPoint = new NxtControl.Drawing.PointF(410D, 92D);
			// 
			// b1Q1
			// 
			this.b1Q1.Bounds = new NxtControl.Drawing.RectF(((float)(396D)), ((float)(218D)), ((float)(28D)), ((float)(28D)));
			this.b1Q1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.b1Q1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b1Q1.Name = "b1Q1";
			this.b1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// abrir1Q1
			// 
			this.abrir1Q1.Bounds = new NxtControl.Drawing.RectF(((float)(390D)), ((float)(212D)), ((float)(40D)), ((float)(40D)));
			this.abrir1Q1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir1Q1.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir1Q1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir1Q1.Name = "abrir1Q1";
			this.abrir1Q1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpComandos", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir1Q1.Radius = 2D;
			this.abrir1Q1.Text = "";
			this.abrir1Q1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir1Q1.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir1Q1.Use3DEffect = false;
			// 
			// lEnt1Q1
			// 
			this.lEnt1Q1.EndPoint = new NxtControl.Drawing.PointF(410D, 330D);
			this.lEnt1Q1.Name = "lEnt1Q1";
			this.lEnt1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lEnt1Q1.StartPoint = new NxtControl.Drawing.PointF(410D, 246D);
			// 
			// tNome1Q1
			// 
			this.tNome1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tNome1Q1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tNome1Q1.Location = new NxtControl.Drawing.PointF(195D, 198D);
			this.tNome1Q1.Name = "tNome1Q1";
			this.tNome1Q1.Text = "1Q1";
			// 
			// tEst1Q1
			// 
			this.tEst1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tEst1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tEst1Q1.Location = new NxtControl.Drawing.PointF(195D, 214D);
			this.tEst1Q1.Name = "tEst1Q1";
			this.tEst1Q1.Text = "—";
			// 
			// tSt1Q1
			// 
			this.tSt1Q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSt1Q1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tSt1Q1.Location = new NxtControl.Drawing.PointF(195D, 230D);
			this.tSt1Q1.Name = "tSt1Q1";
			this.tSt1Q1.Text = "";
			// 
			// lSai1Q2
			// 
			this.lSai1Q2.EndPoint = new NxtControl.Drawing.PointF(940D, 217D);
			this.lSai1Q2.Name = "lSai1Q2";
			this.lSai1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lSai1Q2.StartPoint = new NxtControl.Drawing.PointF(940D, 92D);
			// 
			// b1Q2
			// 
			this.b1Q2.Bounds = new NxtControl.Drawing.RectF(((float)(926D)), ((float)(218D)), ((float)(28D)), ((float)(28D)));
			this.b1Q2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.b1Q2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b1Q2.Name = "b1Q2";
			this.b1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// abrir1Q2
			// 
			this.abrir1Q2.Bounds = new NxtControl.Drawing.RectF(((float)(920D)), ((float)(212D)), ((float)(40D)), ((float)(40D)));
			this.abrir1Q2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir1Q2.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir1Q2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir1Q2.Name = "abrir1Q2";
			this.abrir1Q2.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpComandos", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir1Q2.Radius = 2D;
			this.abrir1Q2.Text = "";
			this.abrir1Q2.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir1Q2.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir1Q2.Use3DEffect = false;
			// 
			// lEnt1Q2
			// 
			this.lEnt1Q2.EndPoint = new NxtControl.Drawing.PointF(940D, 330D);
			this.lEnt1Q2.Name = "lEnt1Q2";
			this.lEnt1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lEnt1Q2.StartPoint = new NxtControl.Drawing.PointF(940D, 246D);
			// 
			// tNome1Q2
			// 
			this.tNome1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tNome1Q2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tNome1Q2.Location = new NxtControl.Drawing.PointF(964D, 198D);
			this.tNome1Q2.Name = "tNome1Q2";
			this.tNome1Q2.Text = "1Q2";
			// 
			// tEst1Q2
			// 
			this.tEst1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tEst1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tEst1Q2.Location = new NxtControl.Drawing.PointF(964D, 214D);
			this.tEst1Q2.Name = "tEst1Q2";
			this.tEst1Q2.Text = "—";
			// 
			// tSt1Q2
			// 
			this.tSt1Q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSt1Q2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tSt1Q2.Location = new NxtControl.Drawing.PointF(964D, 230D);
			this.tSt1Q2.Name = "tSt1Q2";
			this.tSt1Q2.Text = "";
			// 
			// barraA
			// 
			this.barraA.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(327D)), ((float)(635D)), ((float)(6D)));
			this.barraA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))));
			this.barraA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barraA.Name = "barraA";
			this.barraA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barraB
			// 
			this.barraB.Bounds = new NxtControl.Drawing.RectF(((float)(695D)), ((float)(327D)), ((float)(635D)), ((float)(6D)));
			this.barraB.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))));
			this.barraB.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barraB.Name = "barraB";
			this.barraB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tBarraA
			// 
			this.tBarraA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tBarraA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tBarraA.Location = new NxtControl.Drawing.PointF(24D, 308D);
			this.tBarraA.Name = "tBarraA";
			this.tBarraA.Text = "BARRA A - —";
			// 
			// tBarraB
			// 
			this.tBarraB.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tBarraB.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tBarraB.Location = new NxtControl.Drawing.PointF(1090D, 308D);
			this.tBarraB.Name = "tBarraB";
			this.tBarraB.Text = "BARRA B - —";
			// 
			// lAcopA
			// 
			this.lAcopA.EndPoint = new NxtControl.Drawing.PointF(645D, 262D);
			this.lAcopA.Name = "lAcopA";
			this.lAcopA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAcopA.StartPoint = new NxtControl.Drawing.PointF(645D, 330D);
			// 
			// lAcopA2
			// 
			this.lAcopA2.EndPoint = new NxtControl.Drawing.PointF(661D, 262D);
			this.lAcopA2.Name = "lAcopA2";
			this.lAcopA2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAcopA2.StartPoint = new NxtControl.Drawing.PointF(645D, 262D);
			// 
			// b1Q0
			// 
			this.b1Q0.Bounds = new NxtControl.Drawing.RectF(((float)(661D)), ((float)(248D)), ((float)(28D)), ((float)(28D)));
			this.b1Q0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.b1Q0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b1Q0.Name = "b1Q0";
			this.b1Q0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// abrir1Q0
			// 
			this.abrir1Q0.Bounds = new NxtControl.Drawing.RectF(((float)(655D)), ((float)(242D)), ((float)(40D)), ((float)(40D)));
			this.abrir1Q0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir1Q0.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir1Q0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir1Q0.Name = "abrir1Q0";
			this.abrir1Q0.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpComandos", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir1Q0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir1Q0.Radius = 2D;
			this.abrir1Q0.Text = "";
			this.abrir1Q0.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir1Q0.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir1Q0.Use3DEffect = false;
			// 
			// lAcopB2
			// 
			this.lAcopB2.EndPoint = new NxtControl.Drawing.PointF(705D, 262D);
			this.lAcopB2.Name = "lAcopB2";
			this.lAcopB2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAcopB2.StartPoint = new NxtControl.Drawing.PointF(689D, 262D);
			// 
			// lAcopB
			// 
			this.lAcopB.EndPoint = new NxtControl.Drawing.PointF(705D, 330D);
			this.lAcopB.Name = "lAcopB";
			this.lAcopB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAcopB.StartPoint = new NxtControl.Drawing.PointF(705D, 262D);
			// 
			// tNome1Q0
			// 
			this.tNome1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tNome1Q0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tNome1Q0.Location = new NxtControl.Drawing.PointF(712D, 192D);
			this.tNome1Q0.Name = "tNome1Q0";
			this.tNome1Q0.Text = "1Q0 (acoplamento)";
			// 
			// tEst1Q0
			// 
			this.tEst1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tEst1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tEst1Q0.Location = new NxtControl.Drawing.PointF(712D, 208D);
			this.tEst1Q0.Name = "tEst1Q0";
			this.tEst1Q0.Text = "—";
			// 
			// tSt1Q0
			// 
			this.tSt1Q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSt1Q0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tSt1Q0.Location = new NxtControl.Drawing.PointF(712D, 224D);
			this.tSt1Q0.Name = "tSt1Q0";
			this.tSt1Q0.Text = "";
			// 
			// lARES_A1
			// 
			this.lARES_A1.EndPoint = new NxtControl.Drawing.PointF(59.75D, 362D);
			this.lARES_A1.Name = "lARES_A1";
			this.lARES_A1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lARES_A1.StartPoint = new NxtControl.Drawing.PointF(59.75D, 333D);
			// 
			// bRES_A1
			// 
			this.bRES_A1.Bounds = new NxtControl.Drawing.RectF(((float)(49.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bRES_A1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_A1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_A1.Name = "bRES_A1";
			this.bRES_A1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2ARES_A1
			// 
			this.l2ARES_A1.EndPoint = new NxtControl.Drawing.PointF(59.75D, 388D);
			this.l2ARES_A1.Name = "l2ARES_A1";
			this.l2ARES_A1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2ARES_A1.StartPoint = new NxtControl.Drawing.PointF(59.75D, 382D);
			// 
			// tRES_A1
			// 
			this.tRES_A1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_A1.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tRES_A1.Location = new NxtControl.Drawing.PointF(41.6375D, 390D);
			this.tRES_A1.Name = "tRES_A1";
			this.tRES_A1.Text = "RESERVA";
			// 
			// lARES_A2
			// 
			this.lARES_A2.EndPoint = new NxtControl.Drawing.PointF(119.25D, 362D);
			this.lARES_A2.Name = "lARES_A2";
			this.lARES_A2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lARES_A2.StartPoint = new NxtControl.Drawing.PointF(119.25D, 333D);
			// 
			// bRES_A2
			// 
			this.bRES_A2.Bounds = new NxtControl.Drawing.RectF(((float)(109.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bRES_A2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_A2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_A2.Name = "bRES_A2";
			this.bRES_A2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2ARES_A2
			// 
			this.l2ARES_A2.EndPoint = new NxtControl.Drawing.PointF(119.25D, 388D);
			this.l2ARES_A2.Name = "l2ARES_A2";
			this.l2ARES_A2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2ARES_A2.StartPoint = new NxtControl.Drawing.PointF(119.25D, 382D);
			// 
			// tRES_A2
			// 
			this.tRES_A2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_A2.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tRES_A2.Location = new NxtControl.Drawing.PointF(101.138D, 390D);
			this.tRES_A2.Name = "tRES_A2";
			this.tRES_A2.Text = "RESERVA";
			// 
			// lAPCM_EEE_BRUTO
			// 
			this.lAPCM_EEE_BRUTO.EndPoint = new NxtControl.Drawing.PointF(178.75D, 362D);
			this.lAPCM_EEE_BRUTO.Name = "lAPCM_EEE_BRUTO";
			this.lAPCM_EEE_BRUTO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAPCM_EEE_BRUTO.StartPoint = new NxtControl.Drawing.PointF(178.75D, 333D);
			// 
			// bPCM_EEE_BRUTO
			// 
			this.bPCM_EEE_BRUTO.Bounds = new NxtControl.Drawing.RectF(((float)(168.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bPCM_EEE_BRUTO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bPCM_EEE_BRUTO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bPCM_EEE_BRUTO.Name = "bPCM_EEE_BRUTO";
			this.bPCM_EEE_BRUTO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2APCM_EEE_BRUTO
			// 
			this.l2APCM_EEE_BRUTO.EndPoint = new NxtControl.Drawing.PointF(178.75D, 388D);
			this.l2APCM_EEE_BRUTO.Name = "l2APCM_EEE_BRUTO";
			this.l2APCM_EEE_BRUTO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2APCM_EEE_BRUTO.StartPoint = new NxtControl.Drawing.PointF(178.75D, 382D);
			// 
			// tPCM_EEE_BRUTO
			// 
			this.tPCM_EEE_BRUTO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPCM_EEE_BRUTO.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tPCM_EEE_BRUTO.Location = new NxtControl.Drawing.PointF(156.463D, 390D);
			this.tPCM_EEE_BRUTO.Name = "tPCM_EEE_BRUTO";
			this.tPCM_EEE_BRUTO.Text = "PCM\r\nEEE BRUTO";
			// 
			// lAPCM_DESINFECCAO
			// 
			this.lAPCM_DESINFECCAO.EndPoint = new NxtControl.Drawing.PointF(238.25D, 362D);
			this.lAPCM_DESINFECCAO.Name = "lAPCM_DESINFECCAO";
			this.lAPCM_DESINFECCAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAPCM_DESINFECCAO.StartPoint = new NxtControl.Drawing.PointF(238.25D, 333D);
			// 
			// bPCM_DESINFECCAO
			// 
			this.bPCM_DESINFECCAO.Bounds = new NxtControl.Drawing.RectF(((float)(228.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bPCM_DESINFECCAO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bPCM_DESINFECCAO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bPCM_DESINFECCAO.Name = "bPCM_DESINFECCAO";
			this.bPCM_DESINFECCAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2APCM_DESINFECCAO
			// 
			this.l2APCM_DESINFECCAO.EndPoint = new NxtControl.Drawing.PointF(238.25D, 388D);
			this.l2APCM_DESINFECCAO.Name = "l2APCM_DESINFECCAO";
			this.l2APCM_DESINFECCAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2APCM_DESINFECCAO.StartPoint = new NxtControl.Drawing.PointF(238.25D, 382D);
			// 
			// tPCM_DESINFECCAO
			// 
			this.tPCM_DESINFECCAO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPCM_DESINFECCAO.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tPCM_DESINFECCAO.Location = new NxtControl.Drawing.PointF(220.963D, 390D);
			this.tPCM_DESINFECCAO.Name = "tPCM_DESINFECCAO";
			this.tPCM_DESINFECCAO.Text = "PCM\r\nDESINF.";
			// 
			// lAQGBT_220V
			// 
			this.lAQGBT_220V.EndPoint = new NxtControl.Drawing.PointF(297.75D, 362D);
			this.lAQGBT_220V.Name = "lAQGBT_220V";
			this.lAQGBT_220V.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAQGBT_220V.StartPoint = new NxtControl.Drawing.PointF(297.75D, 333D);
			// 
			// bQGBT_220V
			// 
			this.bQGBT_220V.Bounds = new NxtControl.Drawing.RectF(((float)(287.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bQGBT_220V.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQGBT_220V.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQGBT_220V.Name = "bQGBT_220V";
			this.bQGBT_220V.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2AQGBT_220V
			// 
			this.l2AQGBT_220V.EndPoint = new NxtControl.Drawing.PointF(297.75D, 388D);
			this.l2AQGBT_220V.Name = "l2AQGBT_220V";
			this.l2AQGBT_220V.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2AQGBT_220V.StartPoint = new NxtControl.Drawing.PointF(297.75D, 382D);
			// 
			// tQGBT_220V
			// 
			this.tQGBT_220V.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQGBT_220V.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tQGBT_220V.Location = new NxtControl.Drawing.PointF(284.812D, 390D);
			this.tQGBT_220V.Name = "tQGBT_220V";
			this.tQGBT_220V.Text = "QGBT\r\n220 V";
			// 
			// lAUCT_200_01
			// 
			this.lAUCT_200_01.EndPoint = new NxtControl.Drawing.PointF(357.25D, 362D);
			this.lAUCT_200_01.Name = "lAUCT_200_01";
			this.lAUCT_200_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAUCT_200_01.StartPoint = new NxtControl.Drawing.PointF(357.25D, 333D);
			// 
			// bUCT_200_01
			// 
			this.bUCT_200_01.Bounds = new NxtControl.Drawing.RectF(((float)(347.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bUCT_200_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bUCT_200_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bUCT_200_01.Name = "bUCT_200_01";
			this.bUCT_200_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2AUCT_200_01
			// 
			this.l2AUCT_200_01.EndPoint = new NxtControl.Drawing.PointF(357.25D, 388D);
			this.l2AUCT_200_01.Name = "l2AUCT_200_01";
			this.l2AUCT_200_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2AUCT_200_01.StartPoint = new NxtControl.Drawing.PointF(357.25D, 382D);
			// 
			// tUCT_200_01
			// 
			this.tUCT_200_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tUCT_200_01.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tUCT_200_01.Location = new NxtControl.Drawing.PointF(341.725D, 390D);
			this.tUCT_200_01.Name = "tUCT_200_01";
			this.tUCT_200_01.Text = "200-\r\nUCT-01";
			// 
			// lACOMP_500_02
			// 
			this.lACOMP_500_02.EndPoint = new NxtControl.Drawing.PointF(416.75D, 362D);
			this.lACOMP_500_02.Name = "lACOMP_500_02";
			this.lACOMP_500_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lACOMP_500_02.StartPoint = new NxtControl.Drawing.PointF(416.75D, 333D);
			// 
			// bCOMP_500_02
			// 
			this.bCOMP_500_02.Bounds = new NxtControl.Drawing.RectF(((float)(406.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bCOMP_500_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bCOMP_500_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bCOMP_500_02.Name = "bCOMP_500_02";
			this.bCOMP_500_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2ACOMP_500_02
			// 
			this.l2ACOMP_500_02.EndPoint = new NxtControl.Drawing.PointF(416.75D, 388D);
			this.l2ACOMP_500_02.Name = "l2ACOMP_500_02";
			this.l2ACOMP_500_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2ACOMP_500_02.StartPoint = new NxtControl.Drawing.PointF(416.75D, 382D);
			// 
			// tCOMP_500_02
			// 
			this.tCOMP_500_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tCOMP_500_02.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tCOMP_500_02.Location = new NxtControl.Drawing.PointF(398.637D, 390D);
			this.tCOMP_500_02.Name = "tCOMP_500_02";
			this.tCOMP_500_02.Text = "500-\r\nCOMP-02";
			// 
			// lAV4603
			// 
			this.lAV4603.EndPoint = new NxtControl.Drawing.PointF(476.25D, 362D);
			this.lAV4603.Name = "lAV4603";
			this.lAV4603.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAV4603.StartPoint = new NxtControl.Drawing.PointF(476.25D, 333D);
			// 
			// bV4603
			// 
			this.bV4603.Bounds = new NxtControl.Drawing.RectF(((float)(466.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bV4603.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bV4603.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bV4603.Name = "bV4603";
			this.bV4603.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2AV4603
			// 
			this.l2AV4603.EndPoint = new NxtControl.Drawing.PointF(476.25D, 388D);
			this.l2AV4603.Name = "l2AV4603";
			this.l2AV4603.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2AV4603.StartPoint = new NxtControl.Drawing.PointF(476.25D, 382D);
			// 
			// tV4603
			// 
			this.tV4603.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tV4603.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tV4603.Location = new NxtControl.Drawing.PointF(463.312D, 390D);
			this.tV4603.Name = "tV4603";
			this.tV4603.Text = "V4603";
			// 
			// lAV4604
			// 
			this.lAV4604.EndPoint = new NxtControl.Drawing.PointF(535.75D, 362D);
			this.lAV4604.Name = "lAV4604";
			this.lAV4604.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lAV4604.StartPoint = new NxtControl.Drawing.PointF(535.75D, 333D);
			// 
			// bV4604
			// 
			this.bV4604.Bounds = new NxtControl.Drawing.RectF(((float)(525.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bV4604.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bV4604.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bV4604.Name = "bV4604";
			this.bV4604.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2AV4604
			// 
			this.l2AV4604.EndPoint = new NxtControl.Drawing.PointF(535.75D, 388D);
			this.l2AV4604.Name = "l2AV4604";
			this.l2AV4604.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2AV4604.StartPoint = new NxtControl.Drawing.PointF(535.75D, 382D);
			// 
			// tV4604
			// 
			this.tV4604.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tV4604.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tV4604.Location = new NxtControl.Drawing.PointF(522.812D, 390D);
			this.tV4604.Name = "tV4604";
			this.tV4604.Text = "V4604";
			// 
			// lABANCO_CAPACITORES
			// 
			this.lABANCO_CAPACITORES.EndPoint = new NxtControl.Drawing.PointF(595.25D, 362D);
			this.lABANCO_CAPACITORES.Name = "lABANCO_CAPACITORES";
			this.lABANCO_CAPACITORES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lABANCO_CAPACITORES.StartPoint = new NxtControl.Drawing.PointF(595.25D, 333D);
			// 
			// bBANCO_CAPACITORES
			// 
			this.bBANCO_CAPACITORES.Bounds = new NxtControl.Drawing.RectF(((float)(585.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bBANCO_CAPACITORES.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bBANCO_CAPACITORES.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bBANCO_CAPACITORES.Name = "bBANCO_CAPACITORES";
			this.bBANCO_CAPACITORES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2ABANCO_CAPACITORES
			// 
			this.l2ABANCO_CAPACITORES.EndPoint = new NxtControl.Drawing.PointF(595.25D, 388D);
			this.l2ABANCO_CAPACITORES.Name = "l2ABANCO_CAPACITORES";
			this.l2ABANCO_CAPACITORES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2ABANCO_CAPACITORES.StartPoint = new NxtControl.Drawing.PointF(595.25D, 382D);
			// 
			// tBANCO_CAPACITORES
			// 
			this.tBANCO_CAPACITORES.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tBANCO_CAPACITORES.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tBANCO_CAPACITORES.Location = new NxtControl.Drawing.PointF(574.55D, 390D);
			this.tBANCO_CAPACITORES.Name = "tBANCO_CAPACITORES";
			this.tBANCO_CAPACITORES.Text = "BANCO\r\nCAPACIT.";
			// 
			// lBPCE_SUBESTACAO
			// 
			this.lBPCE_SUBESTACAO.EndPoint = new NxtControl.Drawing.PointF(746.25D, 362D);
			this.lBPCE_SUBESTACAO.Name = "lBPCE_SUBESTACAO";
			this.lBPCE_SUBESTACAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBPCE_SUBESTACAO.StartPoint = new NxtControl.Drawing.PointF(746.25D, 333D);
			// 
			// bPCE_SUBESTACAO
			// 
			this.bPCE_SUBESTACAO.Bounds = new NxtControl.Drawing.RectF(((float)(736.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bPCE_SUBESTACAO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bPCE_SUBESTACAO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bPCE_SUBESTACAO.Name = "bPCE_SUBESTACAO";
			this.bPCE_SUBESTACAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BPCE_SUBESTACAO
			// 
			this.l2BPCE_SUBESTACAO.EndPoint = new NxtControl.Drawing.PointF(746.25D, 388D);
			this.l2BPCE_SUBESTACAO.Name = "l2BPCE_SUBESTACAO";
			this.l2BPCE_SUBESTACAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BPCE_SUBESTACAO.StartPoint = new NxtControl.Drawing.PointF(746.25D, 382D);
			// 
			// tPCE_SUBESTACAO
			// 
			this.tPCE_SUBESTACAO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPCE_SUBESTACAO.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tPCE_SUBESTACAO.Location = new NxtControl.Drawing.PointF(730.553D, 390D);
			this.tPCE_SUBESTACAO.Name = "tPCE_SUBESTACAO";
			this.tPCE_SUBESTACAO.Text = "PCE\r\nSUBEST.";
			// 
			// lBCOMP_500_01
			// 
			this.lBCOMP_500_01.EndPoint = new NxtControl.Drawing.PointF(788.75D, 362D);
			this.lBCOMP_500_01.Name = "lBCOMP_500_01";
			this.lBCOMP_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBCOMP_500_01.StartPoint = new NxtControl.Drawing.PointF(788.75D, 333D);
			// 
			// bCOMP_500_01
			// 
			this.bCOMP_500_01.Bounds = new NxtControl.Drawing.RectF(((float)(778.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bCOMP_500_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bCOMP_500_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bCOMP_500_01.Name = "bCOMP_500_01";
			this.bCOMP_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BCOMP_500_01
			// 
			this.l2BCOMP_500_01.EndPoint = new NxtControl.Drawing.PointF(788.75D, 388D);
			this.l2BCOMP_500_01.Name = "l2BCOMP_500_01";
			this.l2BCOMP_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BCOMP_500_01.StartPoint = new NxtControl.Drawing.PointF(788.75D, 382D);
			// 
			// tCOMP_500_01
			// 
			this.tCOMP_500_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tCOMP_500_01.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tCOMP_500_01.Location = new NxtControl.Drawing.PointF(773.053D, 390D);
			this.tCOMP_500_01.Name = "tCOMP_500_01";
			this.tCOMP_500_01.Text = "500-\r\nCOMP-01";
			// 
			// lBUCT_200_02
			// 
			this.lBUCT_200_02.EndPoint = new NxtControl.Drawing.PointF(831.25D, 362D);
			this.lBUCT_200_02.Name = "lBUCT_200_02";
			this.lBUCT_200_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBUCT_200_02.StartPoint = new NxtControl.Drawing.PointF(831.25D, 333D);
			// 
			// bUCT_200_02
			// 
			this.bUCT_200_02.Bounds = new NxtControl.Drawing.RectF(((float)(821.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bUCT_200_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bUCT_200_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bUCT_200_02.Name = "bUCT_200_02";
			this.bUCT_200_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BUCT_200_02
			// 
			this.l2BUCT_200_02.EndPoint = new NxtControl.Drawing.PointF(831.25D, 388D);
			this.l2BUCT_200_02.Name = "l2BUCT_200_02";
			this.l2BUCT_200_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BUCT_200_02.StartPoint = new NxtControl.Drawing.PointF(831.25D, 382D);
			// 
			// tUCT_200_02
			// 
			this.tUCT_200_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tUCT_200_02.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tUCT_200_02.Location = new NxtControl.Drawing.PointF(817.795D, 390D);
			this.tUCT_200_02.Name = "tUCT_200_02";
			this.tUCT_200_02.Text = "200-\r\nUCT-02";
			// 
			// lBUCT_200_03
			// 
			this.lBUCT_200_03.EndPoint = new NxtControl.Drawing.PointF(873.75D, 362D);
			this.lBUCT_200_03.Name = "lBUCT_200_03";
			this.lBUCT_200_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBUCT_200_03.StartPoint = new NxtControl.Drawing.PointF(873.75D, 333D);
			// 
			// bUCT_200_03
			// 
			this.bUCT_200_03.Bounds = new NxtControl.Drawing.RectF(((float)(863.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bUCT_200_03.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bUCT_200_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bUCT_200_03.Name = "bUCT_200_03";
			this.bUCT_200_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BUCT_200_03
			// 
			this.l2BUCT_200_03.EndPoint = new NxtControl.Drawing.PointF(873.75D, 388D);
			this.l2BUCT_200_03.Name = "l2BUCT_200_03";
			this.l2BUCT_200_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BUCT_200_03.StartPoint = new NxtControl.Drawing.PointF(873.75D, 382D);
			// 
			// tUCT_200_03
			// 
			this.tUCT_200_03.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tUCT_200_03.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tUCT_200_03.Location = new NxtControl.Drawing.PointF(860.295D, 390D);
			this.tUCT_200_03.Name = "tUCT_200_03";
			this.tUCT_200_03.Text = "200-\r\nUCT-03";
			// 
			// lBPCM_NEREDA
			// 
			this.lBPCM_NEREDA.EndPoint = new NxtControl.Drawing.PointF(916.25D, 362D);
			this.lBPCM_NEREDA.Name = "lBPCM_NEREDA";
			this.lBPCM_NEREDA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBPCM_NEREDA.StartPoint = new NxtControl.Drawing.PointF(916.25D, 333D);
			// 
			// bPCM_NEREDA
			// 
			this.bPCM_NEREDA.Bounds = new NxtControl.Drawing.RectF(((float)(906.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bPCM_NEREDA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bPCM_NEREDA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bPCM_NEREDA.Name = "bPCM_NEREDA";
			this.bPCM_NEREDA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BPCM_NEREDA
			// 
			this.l2BPCM_NEREDA.EndPoint = new NxtControl.Drawing.PointF(916.25D, 388D);
			this.l2BPCM_NEREDA.Name = "l2BPCM_NEREDA";
			this.l2BPCM_NEREDA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BPCM_NEREDA.StartPoint = new NxtControl.Drawing.PointF(916.25D, 382D);
			// 
			// tPCM_NEREDA
			// 
			this.tPCM_NEREDA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPCM_NEREDA.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tPCM_NEREDA.Location = new NxtControl.Drawing.PointF(902.795D, 390D);
			this.tPCM_NEREDA.Name = "tPCM_NEREDA";
			this.tPCM_NEREDA.Text = "PCM\r\nNEREDA";
			// 
			// lBPCM_LODO
			// 
			this.lBPCM_LODO.EndPoint = new NxtControl.Drawing.PointF(958.75D, 362D);
			this.lBPCM_LODO.Name = "lBPCM_LODO";
			this.lBPCM_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBPCM_LODO.StartPoint = new NxtControl.Drawing.PointF(958.75D, 333D);
			// 
			// bPCM_LODO
			// 
			this.bPCM_LODO.Bounds = new NxtControl.Drawing.RectF(((float)(948.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bPCM_LODO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bPCM_LODO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bPCM_LODO.Name = "bPCM_LODO";
			this.bPCM_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BPCM_LODO
			// 
			this.l2BPCM_LODO.EndPoint = new NxtControl.Drawing.PointF(958.75D, 388D);
			this.l2BPCM_LODO.Name = "l2BPCM_LODO";
			this.l2BPCM_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BPCM_LODO.StartPoint = new NxtControl.Drawing.PointF(958.75D, 382D);
			// 
			// tPCM_LODO
			// 
			this.tPCM_LODO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPCM_LODO.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tPCM_LODO.Location = new NxtControl.Drawing.PointF(949.78D, 390D);
			this.tPCM_LODO.Name = "tPCM_LODO";
			this.tPCM_LODO.Text = "PCM\r\nLODO";
			// 
			// lBCAP2
			// 
			this.lBCAP2.EndPoint = new NxtControl.Drawing.PointF(1001.25D, 362D);
			this.lBCAP2.Name = "lBCAP2";
			this.lBCAP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBCAP2.StartPoint = new NxtControl.Drawing.PointF(1001.25D, 333D);
			// 
			// bCAP2
			// 
			this.bCAP2.Bounds = new NxtControl.Drawing.RectF(((float)(991.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bCAP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bCAP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bCAP2.Name = "bCAP2";
			this.bCAP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BCAP2
			// 
			this.l2BCAP2.EndPoint = new NxtControl.Drawing.PointF(1001.25D, 388D);
			this.l2BCAP2.Name = "l2BCAP2";
			this.l2BCAP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BCAP2.StartPoint = new NxtControl.Drawing.PointF(1001.25D, 382D);
			// 
			// tCAP2
			// 
			this.tCAP2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tCAP2.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tCAP2.Location = new NxtControl.Drawing.PointF(992.28D, 390D);
			this.tCAP2.Name = "tCAP2";
			this.tCAP2.Text = "CAP2";
			// 
			// lBPCM_AGUA_REUSO
			// 
			this.lBPCM_AGUA_REUSO.EndPoint = new NxtControl.Drawing.PointF(1043.75D, 362D);
			this.lBPCM_AGUA_REUSO.Name = "lBPCM_AGUA_REUSO";
			this.lBPCM_AGUA_REUSO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBPCM_AGUA_REUSO.StartPoint = new NxtControl.Drawing.PointF(1043.75D, 333D);
			// 
			// bPCM_AGUA_REUSO
			// 
			this.bPCM_AGUA_REUSO.Bounds = new NxtControl.Drawing.RectF(((float)(1033.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bPCM_AGUA_REUSO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bPCM_AGUA_REUSO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bPCM_AGUA_REUSO.Name = "bPCM_AGUA_REUSO";
			this.bPCM_AGUA_REUSO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BPCM_AGUA_REUSO
			// 
			this.l2BPCM_AGUA_REUSO.EndPoint = new NxtControl.Drawing.PointF(1043.75D, 388D);
			this.l2BPCM_AGUA_REUSO.Name = "l2BPCM_AGUA_REUSO";
			this.l2BPCM_AGUA_REUSO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BPCM_AGUA_REUSO.StartPoint = new NxtControl.Drawing.PointF(1043.75D, 382D);
			// 
			// tPCM_AGUA_REUSO
			// 
			this.tPCM_AGUA_REUSO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPCM_AGUA_REUSO.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tPCM_AGUA_REUSO.Location = new NxtControl.Drawing.PointF(1031.81D, 390D);
			this.tPCM_AGUA_REUSO.Name = "tPCM_AGUA_REUSO";
			this.tPCM_AGUA_REUSO.Text = "PCM\r\nREÚSO";
			// 
			// lBMO_500_01
			// 
			this.lBMO_500_01.EndPoint = new NxtControl.Drawing.PointF(1086.25D, 362D);
			this.lBMO_500_01.Name = "lBMO_500_01";
			this.lBMO_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBMO_500_01.StartPoint = new NxtControl.Drawing.PointF(1086.25D, 333D);
			// 
			// bMO_500_01
			// 
			this.bMO_500_01.Bounds = new NxtControl.Drawing.RectF(((float)(1076.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bMO_500_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bMO_500_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bMO_500_01.Name = "bMO_500_01";
			this.bMO_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BMO_500_01
			// 
			this.l2BMO_500_01.EndPoint = new NxtControl.Drawing.PointF(1086.25D, 388D);
			this.l2BMO_500_01.Name = "l2BMO_500_01";
			this.l2BMO_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BMO_500_01.StartPoint = new NxtControl.Drawing.PointF(1086.25D, 382D);
			// 
			// tMO_500_01
			// 
			this.tMO_500_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tMO_500_01.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tMO_500_01.Location = new NxtControl.Drawing.PointF(1075.04D, 390D);
			this.tMO_500_01.Name = "tMO_500_01";
			this.tMO_500_01.Text = "500-\r\nMO-01";
			// 
			// lBV4601
			// 
			this.lBV4601.EndPoint = new NxtControl.Drawing.PointF(1128.75D, 362D);
			this.lBV4601.Name = "lBV4601";
			this.lBV4601.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBV4601.StartPoint = new NxtControl.Drawing.PointF(1128.75D, 333D);
			// 
			// bV4601
			// 
			this.bV4601.Bounds = new NxtControl.Drawing.RectF(((float)(1118.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bV4601.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bV4601.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bV4601.Name = "bV4601";
			this.bV4601.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BV4601
			// 
			this.l2BV4601.EndPoint = new NxtControl.Drawing.PointF(1128.75D, 388D);
			this.l2BV4601.Name = "l2BV4601";
			this.l2BV4601.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BV4601.StartPoint = new NxtControl.Drawing.PointF(1128.75D, 382D);
			// 
			// tV4601
			// 
			this.tV4601.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tV4601.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tV4601.Location = new NxtControl.Drawing.PointF(1117.54D, 390D);
			this.tV4601.Name = "tV4601";
			this.tV4601.Text = "V4601";
			// 
			// lBV4602
			// 
			this.lBV4602.EndPoint = new NxtControl.Drawing.PointF(1171.25D, 362D);
			this.lBV4602.Name = "lBV4602";
			this.lBV4602.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBV4602.StartPoint = new NxtControl.Drawing.PointF(1171.25D, 333D);
			// 
			// bV4602
			// 
			this.bV4602.Bounds = new NxtControl.Drawing.RectF(((float)(1161.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bV4602.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bV4602.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bV4602.Name = "bV4602";
			this.bV4602.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BV4602
			// 
			this.l2BV4602.EndPoint = new NxtControl.Drawing.PointF(1171.25D, 388D);
			this.l2BV4602.Name = "l2BV4602";
			this.l2BV4602.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BV4602.StartPoint = new NxtControl.Drawing.PointF(1171.25D, 382D);
			// 
			// tV4602
			// 
			this.tV4602.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tV4602.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tV4602.Location = new NxtControl.Drawing.PointF(1160.04D, 390D);
			this.tV4602.Name = "tV4602";
			this.tV4602.Text = "V4602";
			// 
			// lBRES_B1
			// 
			this.lBRES_B1.EndPoint = new NxtControl.Drawing.PointF(1213.75D, 362D);
			this.lBRES_B1.Name = "lBRES_B1";
			this.lBRES_B1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBRES_B1.StartPoint = new NxtControl.Drawing.PointF(1213.75D, 333D);
			// 
			// bRES_B1
			// 
			this.bRES_B1.Bounds = new NxtControl.Drawing.RectF(((float)(1203.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bRES_B1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_B1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_B1.Name = "bRES_B1";
			this.bRES_B1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BRES_B1
			// 
			this.l2BRES_B1.EndPoint = new NxtControl.Drawing.PointF(1213.75D, 388D);
			this.l2BRES_B1.Name = "l2BRES_B1";
			this.l2BRES_B1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BRES_B1.StartPoint = new NxtControl.Drawing.PointF(1213.75D, 382D);
			// 
			// tRES_B1
			// 
			this.tRES_B1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_B1.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_B1.Location = new NxtControl.Drawing.PointF(1206.05D, 390D);
			this.tRES_B1.Name = "tRES_B1";
			this.tRES_B1.Text = "RES.";
			// 
			// lBRES_B2
			// 
			this.lBRES_B2.EndPoint = new NxtControl.Drawing.PointF(1256.25D, 362D);
			this.lBRES_B2.Name = "lBRES_B2";
			this.lBRES_B2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBRES_B2.StartPoint = new NxtControl.Drawing.PointF(1256.25D, 333D);
			// 
			// bRES_B2
			// 
			this.bRES_B2.Bounds = new NxtControl.Drawing.RectF(((float)(1246.25D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bRES_B2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_B2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_B2.Name = "bRES_B2";
			this.bRES_B2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BRES_B2
			// 
			this.l2BRES_B2.EndPoint = new NxtControl.Drawing.PointF(1256.25D, 388D);
			this.l2BRES_B2.Name = "l2BRES_B2";
			this.l2BRES_B2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BRES_B2.StartPoint = new NxtControl.Drawing.PointF(1256.25D, 382D);
			// 
			// tRES_B2
			// 
			this.tRES_B2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_B2.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_B2.Location = new NxtControl.Drawing.PointF(1248.55D, 390D);
			this.tRES_B2.Name = "tRES_B2";
			this.tRES_B2.Text = "RES.";
			// 
			// lBRES_B3
			// 
			this.lBRES_B3.EndPoint = new NxtControl.Drawing.PointF(1298.75D, 362D);
			this.lBRES_B3.Name = "lBRES_B3";
			this.lBRES_B3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lBRES_B3.StartPoint = new NxtControl.Drawing.PointF(1298.75D, 333D);
			// 
			// bRES_B3
			// 
			this.bRES_B3.Bounds = new NxtControl.Drawing.RectF(((float)(1288.75D)), ((float)(362D)), ((float)(20D)), ((float)(20D)));
			this.bRES_B3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_B3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_B3.Name = "bRES_B3";
			this.bRES_B3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2BRES_B3
			// 
			this.l2BRES_B3.EndPoint = new NxtControl.Drawing.PointF(1298.75D, 388D);
			this.l2BRES_B3.Name = "l2BRES_B3";
			this.l2BRES_B3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2BRES_B3.StartPoint = new NxtControl.Drawing.PointF(1298.75D, 382D);
			// 
			// tRES_B3
			// 
			this.tRES_B3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_B3.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_B3.Location = new NxtControl.Drawing.PointF(1291.05D, 390D);
			this.tRES_B3.Name = "tRES_B3";
			this.tRES_B3.Text = "RES.";
			// 
			// l220a
			// 
			this.l220a.EndPoint = new NxtControl.Drawing.PointF(297.75D, 452D);
			this.l220a.Name = "l220a";
			this.l220a.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l220a.StartPoint = new NxtControl.Drawing.PointF(297.75D, 416D);
			// 
			// t220a
			// 
			this.t220a.Bounds = new NxtControl.Drawing.RectF(((float)(285.75D)), ((float)(452D)), ((float)(24D)), ((float)(24D)));
			this.t220a.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.t220a.Name = "t220a";
			this.t220a.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t220b
			// 
			this.t220b.Bounds = new NxtControl.Drawing.RectF(((float)(285.75D)), ((float)(466D)), ((float)(24D)), ((float)(24D)));
			this.t220b.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.t220b.Name = "t220b";
			this.t220b.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tTr220
			// 
			this.tTr220.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tTr220.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Regular);
			this.tTr220.Location = new NxtControl.Drawing.PointF(313.75D, 460D);
			this.tTr220.Name = "tTr220";
			this.tTr220.Text = "440 / 220 V";
			// 
			// l220b
			// 
			this.l220b.EndPoint = new NxtControl.Drawing.PointF(297.75D, 490D);
			this.l220b.Name = "l220b";
			this.l220b.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l220b.StartPoint = new NxtControl.Drawing.PointF(297.75D, 490D);
			// 
			// bQGBT_220V_ENTRADA
			// 
			this.bQGBT_220V_ENTRADA.Bounds = new NxtControl.Drawing.RectF(((float)(287.75D)), ((float)(490D)), ((float)(20D)), ((float)(20D)));
			this.bQGBT_220V_ENTRADA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQGBT_220V_ENTRADA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQGBT_220V_ENTRADA.Name = "bQGBT_220V_ENTRADA";
			this.bQGBT_220V_ENTRADA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tQGBT_220V_ENTRADA
			// 
			this.tQGBT_220V_ENTRADA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQGBT_220V_ENTRADA.Font = new NxtControl.Drawing.Font("Arial", 7.5F, System.Drawing.FontStyle.Bold);
			this.tQGBT_220V_ENTRADA.Location = new NxtControl.Drawing.PointF(311.75D, 492D);
			this.tQGBT_220V_ENTRADA.Name = "tQGBT_220V_ENTRADA";
			this.tQGBT_220V_ENTRADA.Text = "ENTRADA";
			// 
			// l220c
			// 
			this.l220c.EndPoint = new NxtControl.Drawing.PointF(297.75D, 560D);
			this.l220c.Name = "l220c";
			this.l220c.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l220c.StartPoint = new NxtControl.Drawing.PointF(297.75D, 510D);
			// 
			// barra220
			// 
			this.barra220.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(558D)), ((float)(635D)), ((float)(4D)));
			this.barra220.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))));
			this.barra220.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barra220.Name = "barra220";
			this.barra220.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tBarra220
			// 
			this.tBarra220.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tBarra220.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tBarra220.Location = new NxtControl.Drawing.PointF(24D, 542D);
			this.tBarra220.Name = "tBarra220";
			this.tBarra220.Text = "QGBT 220 V";
			// 
			// lCQL_ADM
			// 
			this.lCQL_ADM.EndPoint = new NxtControl.Drawing.PointF(55.625D, 586D);
			this.lCQL_ADM.Name = "lCQL_ADM";
			this.lCQL_ADM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCQL_ADM.StartPoint = new NxtControl.Drawing.PointF(55.625D, 562D);
			// 
			// bQL_ADM
			// 
			this.bQL_ADM.Bounds = new NxtControl.Drawing.RectF(((float)(45.625D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bQL_ADM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQL_ADM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQL_ADM.Name = "bQL_ADM";
			this.bQL_ADM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CQL_ADM
			// 
			this.l2CQL_ADM.EndPoint = new NxtControl.Drawing.PointF(55.625D, 612D);
			this.l2CQL_ADM.Name = "l2CQL_ADM";
			this.l2CQL_ADM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CQL_ADM.StartPoint = new NxtControl.Drawing.PointF(55.625D, 606D);
			// 
			// tQL_ADM
			// 
			this.tQL_ADM.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQL_ADM.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tQL_ADM.Location = new NxtControl.Drawing.PointF(33.2D, 614D);
			this.tQL_ADM.Name = "tQL_ADM";
			this.tQL_ADM.Text = "QL\r\nADMINISTR.";
			// 
			// lCQL_PORTARIA
			// 
			this.lCQL_PORTARIA.EndPoint = new NxtControl.Drawing.PointF(106.875D, 586D);
			this.lCQL_PORTARIA.Name = "lCQL_PORTARIA";
			this.lCQL_PORTARIA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCQL_PORTARIA.StartPoint = new NxtControl.Drawing.PointF(106.875D, 562D);
			// 
			// bQL_PORTARIA
			// 
			this.bQL_PORTARIA.Bounds = new NxtControl.Drawing.RectF(((float)(96.875D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bQL_PORTARIA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQL_PORTARIA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQL_PORTARIA.Name = "bQL_PORTARIA";
			this.bQL_PORTARIA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CQL_PORTARIA
			// 
			this.l2CQL_PORTARIA.EndPoint = new NxtControl.Drawing.PointF(106.875D, 612D);
			this.l2CQL_PORTARIA.Name = "l2CQL_PORTARIA";
			this.l2CQL_PORTARIA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CQL_PORTARIA.StartPoint = new NxtControl.Drawing.PointF(106.875D, 606D);
			// 
			// tQL_PORTARIA
			// 
			this.tQL_PORTARIA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQL_PORTARIA.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tQL_PORTARIA.Location = new NxtControl.Drawing.PointF(88.935D, 614D);
			this.tQL_PORTARIA.Name = "tQL_PORTARIA";
			this.tQL_PORTARIA.Text = "QL\r\nPORTARIA";
			// 
			// lCQLSL
			// 
			this.lCQLSL.EndPoint = new NxtControl.Drawing.PointF(158.125D, 586D);
			this.lCQLSL.Name = "lCQLSL";
			this.lCQLSL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCQLSL.StartPoint = new NxtControl.Drawing.PointF(158.125D, 562D);
			// 
			// bQLSL
			// 
			this.bQLSL.Bounds = new NxtControl.Drawing.RectF(((float)(148.125D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bQLSL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQLSL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQLSL.Name = "bQLSL";
			this.bQLSL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CQLSL
			// 
			this.l2CQLSL.EndPoint = new NxtControl.Drawing.PointF(158.125D, 612D);
			this.l2CQLSL.Name = "l2CQLSL";
			this.l2CQLSL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CQLSL.StartPoint = new NxtControl.Drawing.PointF(158.125D, 606D);
			// 
			// tQLSL
			// 
			this.tQLSL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQLSL.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tQLSL.Location = new NxtControl.Drawing.PointF(142.428D, 614D);
			this.tQLSL.Name = "tQLSL";
			this.tQLSL.Text = "QL SALA\r\nQUADROS";
			// 
			// lCQL_ILUMINACAO
			// 
			this.lCQL_ILUMINACAO.EndPoint = new NxtControl.Drawing.PointF(209.375D, 586D);
			this.lCQL_ILUMINACAO.Name = "lCQL_ILUMINACAO";
			this.lCQL_ILUMINACAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCQL_ILUMINACAO.StartPoint = new NxtControl.Drawing.PointF(209.375D, 562D);
			// 
			// bQL_ILUMINACAO
			// 
			this.bQL_ILUMINACAO.Bounds = new NxtControl.Drawing.RectF(((float)(199.375D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bQL_ILUMINACAO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQL_ILUMINACAO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQL_ILUMINACAO.Name = "bQL_ILUMINACAO";
			this.bQL_ILUMINACAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CQL_ILUMINACAO
			// 
			this.l2CQL_ILUMINACAO.EndPoint = new NxtControl.Drawing.PointF(209.375D, 612D);
			this.l2CQL_ILUMINACAO.Name = "l2CQL_ILUMINACAO";
			this.l2CQL_ILUMINACAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CQL_ILUMINACAO.StartPoint = new NxtControl.Drawing.PointF(209.375D, 606D);
			// 
			// tQL_ILUMINACAO
			// 
			this.tQL_ILUMINACAO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQL_ILUMINACAO.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tQL_ILUMINACAO.Location = new NxtControl.Drawing.PointF(191.435D, 614D);
			this.tQL_ILUMINACAO.Name = "tQL_ILUMINACAO";
			this.tQL_ILUMINACAO.Text = "QL ILUM.\r\nEXTERNA";
			// 
			// lCPCE_SOPRADORES
			// 
			this.lCPCE_SOPRADORES.EndPoint = new NxtControl.Drawing.PointF(260.625D, 586D);
			this.lCPCE_SOPRADORES.Name = "lCPCE_SOPRADORES";
			this.lCPCE_SOPRADORES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCPCE_SOPRADORES.StartPoint = new NxtControl.Drawing.PointF(260.625D, 562D);
			// 
			// bPCE_SOPRADORES
			// 
			this.bPCE_SOPRADORES.Bounds = new NxtControl.Drawing.RectF(((float)(250.625D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bPCE_SOPRADORES.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bPCE_SOPRADORES.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bPCE_SOPRADORES.Name = "bPCE_SOPRADORES";
			this.bPCE_SOPRADORES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CPCE_SOPRADORES
			// 
			this.l2CPCE_SOPRADORES.EndPoint = new NxtControl.Drawing.PointF(260.625D, 612D);
			this.l2CPCE_SOPRADORES.Name = "l2CPCE_SOPRADORES";
			this.l2CPCE_SOPRADORES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CPCE_SOPRADORES.StartPoint = new NxtControl.Drawing.PointF(260.625D, 606D);
			// 
			// tPCE_SOPRADORES
			// 
			this.tPCE_SOPRADORES.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPCE_SOPRADORES.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tPCE_SOPRADORES.Location = new NxtControl.Drawing.PointF(246.2D, 614D);
			this.tPCE_SOPRADORES.Name = "tPCE_SOPRADORES";
			this.tPCE_SOPRADORES.Text = "PCE\r\nSOPRAD.";
			// 
			// lCQL_LODO
			// 
			this.lCQL_LODO.EndPoint = new NxtControl.Drawing.PointF(311.875D, 586D);
			this.lCQL_LODO.Name = "lCQL_LODO";
			this.lCQL_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCQL_LODO.StartPoint = new NxtControl.Drawing.PointF(311.875D, 562D);
			// 
			// bQL_LODO
			// 
			this.bQL_LODO.Bounds = new NxtControl.Drawing.RectF(((float)(301.875D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bQL_LODO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bQL_LODO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bQL_LODO.Name = "bQL_LODO";
			this.bQL_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CQL_LODO
			// 
			this.l2CQL_LODO.EndPoint = new NxtControl.Drawing.PointF(311.875D, 612D);
			this.l2CQL_LODO.Name = "l2CQL_LODO";
			this.l2CQL_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CQL_LODO.StartPoint = new NxtControl.Drawing.PointF(311.875D, 606D);
			// 
			// tQL_LODO
			// 
			this.tQL_LODO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tQL_LODO.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tQL_LODO.Location = new NxtControl.Drawing.PointF(302.905D, 614D);
			this.tQL_LODO.Name = "tQL_LODO";
			this.tQL_LODO.Text = "QL\r\nLODO";
			// 
			// lCRES_C1
			// 
			this.lCRES_C1.EndPoint = new NxtControl.Drawing.PointF(363.125D, 586D);
			this.lCRES_C1.Name = "lCRES_C1";
			this.lCRES_C1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCRES_C1.StartPoint = new NxtControl.Drawing.PointF(363.125D, 562D);
			// 
			// bRES_C1
			// 
			this.bRES_C1.Bounds = new NxtControl.Drawing.RectF(((float)(353.125D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bRES_C1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_C1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_C1.Name = "bRES_C1";
			this.bRES_C1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CRES_C1
			// 
			this.l2CRES_C1.EndPoint = new NxtControl.Drawing.PointF(363.125D, 612D);
			this.l2CRES_C1.Name = "l2CRES_C1";
			this.l2CRES_C1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CRES_C1.StartPoint = new NxtControl.Drawing.PointF(363.125D, 606D);
			// 
			// tRES_C1
			// 
			this.tRES_C1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_C1.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_C1.Location = new NxtControl.Drawing.PointF(347.428D, 614D);
			this.tRES_C1.Name = "tRES_C1";
			this.tRES_C1.Text = "RESERVA";
			// 
			// lCRES_C2
			// 
			this.lCRES_C2.EndPoint = new NxtControl.Drawing.PointF(414.375D, 586D);
			this.lCRES_C2.Name = "lCRES_C2";
			this.lCRES_C2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCRES_C2.StartPoint = new NxtControl.Drawing.PointF(414.375D, 562D);
			// 
			// bRES_C2
			// 
			this.bRES_C2.Bounds = new NxtControl.Drawing.RectF(((float)(404.375D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bRES_C2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_C2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_C2.Name = "bRES_C2";
			this.bRES_C2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CRES_C2
			// 
			this.l2CRES_C2.EndPoint = new NxtControl.Drawing.PointF(414.375D, 612D);
			this.l2CRES_C2.Name = "l2CRES_C2";
			this.l2CRES_C2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CRES_C2.StartPoint = new NxtControl.Drawing.PointF(414.375D, 606D);
			// 
			// tRES_C2
			// 
			this.tRES_C2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_C2.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_C2.Location = new NxtControl.Drawing.PointF(398.678D, 614D);
			this.tRES_C2.Name = "tRES_C2";
			this.tRES_C2.Text = "RESERVA";
			// 
			// lCRES_C3
			// 
			this.lCRES_C3.EndPoint = new NxtControl.Drawing.PointF(465.625D, 586D);
			this.lCRES_C3.Name = "lCRES_C3";
			this.lCRES_C3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCRES_C3.StartPoint = new NxtControl.Drawing.PointF(465.625D, 562D);
			// 
			// bRES_C3
			// 
			this.bRES_C3.Bounds = new NxtControl.Drawing.RectF(((float)(455.625D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bRES_C3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_C3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_C3.Name = "bRES_C3";
			this.bRES_C3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CRES_C3
			// 
			this.l2CRES_C3.EndPoint = new NxtControl.Drawing.PointF(465.625D, 612D);
			this.l2CRES_C3.Name = "l2CRES_C3";
			this.l2CRES_C3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CRES_C3.StartPoint = new NxtControl.Drawing.PointF(465.625D, 606D);
			// 
			// tRES_C3
			// 
			this.tRES_C3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_C3.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_C3.Location = new NxtControl.Drawing.PointF(449.928D, 614D);
			this.tRES_C3.Name = "tRES_C3";
			this.tRES_C3.Text = "RESERVA";
			// 
			// lCRES_C4
			// 
			this.lCRES_C4.EndPoint = new NxtControl.Drawing.PointF(516.875D, 586D);
			this.lCRES_C4.Name = "lCRES_C4";
			this.lCRES_C4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCRES_C4.StartPoint = new NxtControl.Drawing.PointF(516.875D, 562D);
			// 
			// bRES_C4
			// 
			this.bRES_C4.Bounds = new NxtControl.Drawing.RectF(((float)(506.875D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bRES_C4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_C4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_C4.Name = "bRES_C4";
			this.bRES_C4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CRES_C4
			// 
			this.l2CRES_C4.EndPoint = new NxtControl.Drawing.PointF(516.875D, 612D);
			this.l2CRES_C4.Name = "l2CRES_C4";
			this.l2CRES_C4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CRES_C4.StartPoint = new NxtControl.Drawing.PointF(516.875D, 606D);
			// 
			// tRES_C4
			// 
			this.tRES_C4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_C4.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_C4.Location = new NxtControl.Drawing.PointF(501.178D, 614D);
			this.tRES_C4.Name = "tRES_C4";
			this.tRES_C4.Text = "RESERVA";
			// 
			// lCRES_C5
			// 
			this.lCRES_C5.EndPoint = new NxtControl.Drawing.PointF(568.125D, 586D);
			this.lCRES_C5.Name = "lCRES_C5";
			this.lCRES_C5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCRES_C5.StartPoint = new NxtControl.Drawing.PointF(568.125D, 562D);
			// 
			// bRES_C5
			// 
			this.bRES_C5.Bounds = new NxtControl.Drawing.RectF(((float)(558.125D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bRES_C5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_C5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_C5.Name = "bRES_C5";
			this.bRES_C5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CRES_C5
			// 
			this.l2CRES_C5.EndPoint = new NxtControl.Drawing.PointF(568.125D, 612D);
			this.l2CRES_C5.Name = "l2CRES_C5";
			this.l2CRES_C5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CRES_C5.StartPoint = new NxtControl.Drawing.PointF(568.125D, 606D);
			// 
			// tRES_C5
			// 
			this.tRES_C5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_C5.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_C5.Location = new NxtControl.Drawing.PointF(552.428D, 614D);
			this.tRES_C5.Name = "tRES_C5";
			this.tRES_C5.Text = "RESERVA";
			// 
			// lCRES_C6
			// 
			this.lCRES_C6.EndPoint = new NxtControl.Drawing.PointF(619.375D, 586D);
			this.lCRES_C6.Name = "lCRES_C6";
			this.lCRES_C6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lCRES_C6.StartPoint = new NxtControl.Drawing.PointF(619.375D, 562D);
			// 
			// bRES_C6
			// 
			this.bRES_C6.Bounds = new NxtControl.Drawing.RectF(((float)(609.375D)), ((float)(586D)), ((float)(20D)), ((float)(20D)));
			this.bRES_C6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bRES_C6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bRES_C6.Name = "bRES_C6";
			this.bRES_C6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// l2CRES_C6
			// 
			this.l2CRES_C6.EndPoint = new NxtControl.Drawing.PointF(619.375D, 612D);
			this.l2CRES_C6.Name = "l2CRES_C6";
			this.l2CRES_C6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.l2CRES_C6.StartPoint = new NxtControl.Drawing.PointF(619.375D, 606D);
			// 
			// tRES_C6
			// 
			this.tRES_C6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRES_C6.Font = new NxtControl.Drawing.Font("Arial", 6.5F, System.Drawing.FontStyle.Bold);
			this.tRES_C6.Location = new NxtControl.Drawing.PointF(603.678D, 614D);
			this.tRES_C6.Name = "tRES_C6";
			this.tRES_C6.Text = "RESERVA";
			// 
			// painel
			// 
			this.painel.Bounds = new NxtControl.Drawing.RectF(((float)(695D)), ((float)(414D)), ((float)(635D)), ((float)(84D)));
			this.painel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.painel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.painel.Name = "painel";
			this.painel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tPlanta
			// 
			this.tPlanta.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPlanta.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tPlanta.Location = new NxtControl.Drawing.PointF(705D, 420D);
			this.tPlanta.Name = "tPlanta";
			this.tPlanta.Text = "Planta na rede";
			// 
			// tRemota
			// 
			this.tRemota.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRemota.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tRemota.Location = new NxtControl.Drawing.PointF(705D, 442D);
			this.tRemota.Name = "tRemota";
			this.tRemota.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(1025D)), ((float)(420D)), ((float)(16D)), ((float)(16D)));
			this.alP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.alP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP1.Name = "alP1";
			this.alP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP1.Visible = false;
			// 
			// alP1n
			// 
			this.alP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.alP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alP1n.Location = new NxtControl.Drawing.PointF(1029D, 421D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(1025D)), ((float)(420D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1025D, 436D),
			new NxtControl.Drawing.PointF(1033D, 420D),
			new NxtControl.Drawing.PointF(1041D, 436D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(1030D, 424D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(1045D, 420D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// btnCargas
			// 
			this.btnCargas.Bounds = new NxtControl.Drawing.RectF(((float)(705D)), ((float)(460D)), ((float)(200D)), ((float)(32D)));
			this.btnCargas.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnCargas.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnCargas.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnCargas.Name = "btnCargas";
			this.btnCargas.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpCargas", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnCargas.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnCargas.Radius = 2D;
			this.btnCargas.Text = "Cargas no gerador";
			this.btnCargas.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnCargas.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnCargas.Use3DEffect = false;
			// 
			// btnComandos
			// 
			this.btnComandos.Bounds = new NxtControl.Drawing.RectF(((float)(915D)), ((float)(460D)), ((float)(200D)), ((float)(32D)));
			this.btnComandos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnComandos.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnComandos.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnComandos.Name = "btnComandos";
			this.btnComandos.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpComandos", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnComandos.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnComandos.Radius = 2D;
			this.btnComandos.Text = "Comandos 1Q1 / 1Q0 / 1Q2";
			this.btnComandos.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnComandos.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnComandos.Use3DEffect = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(1125D)), ((float)(460D)), ((float)(160D)), ((float)(32D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer";
			this.btnReset.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// xDJ_RES_A1
			// 
			this.xDJ_RES_A1.BeginInit();
			this.xDJ_RES_A1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_A1.IsOnlyInput = true;
			this.xDJ_RES_A1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_A1.Name = "xDJ_RES_A1";
			this.xDJ_RES_A1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_A1.TagName = "DJ_RES_A1";
			this.xDJ_RES_A1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_A1.EndInit();
			// 
			// xDJ_RES_A2
			// 
			this.xDJ_RES_A2.BeginInit();
			this.xDJ_RES_A2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_A2.IsOnlyInput = true;
			this.xDJ_RES_A2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_A2.Name = "xDJ_RES_A2";
			this.xDJ_RES_A2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_A2.TagName = "DJ_RES_A2";
			this.xDJ_RES_A2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_A2.EndInit();
			// 
			// xDJ_PCM_EEE_BRUTO
			// 
			this.xDJ_PCM_EEE_BRUTO.BeginInit();
			this.xDJ_PCM_EEE_BRUTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_PCM_EEE_BRUTO.IsOnlyInput = true;
			this.xDJ_PCM_EEE_BRUTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_PCM_EEE_BRUTO.Name = "xDJ_PCM_EEE_BRUTO";
			this.xDJ_PCM_EEE_BRUTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_PCM_EEE_BRUTO.TagName = "DJ_PCM_EEE_BRUTO";
			this.xDJ_PCM_EEE_BRUTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_PCM_EEE_BRUTO.EndInit();
			// 
			// xDJ_PCM_DESINFECCAO
			// 
			this.xDJ_PCM_DESINFECCAO.BeginInit();
			this.xDJ_PCM_DESINFECCAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_PCM_DESINFECCAO.IsOnlyInput = true;
			this.xDJ_PCM_DESINFECCAO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_PCM_DESINFECCAO.Name = "xDJ_PCM_DESINFECCAO";
			this.xDJ_PCM_DESINFECCAO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_PCM_DESINFECCAO.TagName = "DJ_PCM_DESINFECCAO";
			this.xDJ_PCM_DESINFECCAO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_PCM_DESINFECCAO.EndInit();
			// 
			// xDJ_QGBT_220V
			// 
			this.xDJ_QGBT_220V.BeginInit();
			this.xDJ_QGBT_220V.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_QGBT_220V.IsOnlyInput = true;
			this.xDJ_QGBT_220V.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_QGBT_220V.Name = "xDJ_QGBT_220V";
			this.xDJ_QGBT_220V.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_QGBT_220V.TagName = "DJ_QGBT_220V";
			this.xDJ_QGBT_220V.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_QGBT_220V.EndInit();
			// 
			// xDJ_UCT_200_01
			// 
			this.xDJ_UCT_200_01.BeginInit();
			this.xDJ_UCT_200_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_UCT_200_01.IsOnlyInput = true;
			this.xDJ_UCT_200_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_UCT_200_01.Name = "xDJ_UCT_200_01";
			this.xDJ_UCT_200_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_UCT_200_01.TagName = "DJ_UCT_200_01";
			this.xDJ_UCT_200_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_UCT_200_01.EndInit();
			// 
			// xDJ_COMP_500_02
			// 
			this.xDJ_COMP_500_02.BeginInit();
			this.xDJ_COMP_500_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_COMP_500_02.IsOnlyInput = true;
			this.xDJ_COMP_500_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_COMP_500_02.Name = "xDJ_COMP_500_02";
			this.xDJ_COMP_500_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_COMP_500_02.TagName = "DJ_COMP_500_02";
			this.xDJ_COMP_500_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_COMP_500_02.EndInit();
			// 
			// xDJ_V4603
			// 
			this.xDJ_V4603.BeginInit();
			this.xDJ_V4603.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_V4603.IsOnlyInput = true;
			this.xDJ_V4603.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_V4603.Name = "xDJ_V4603";
			this.xDJ_V4603.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_V4603.TagName = "DJ_V4603";
			this.xDJ_V4603.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_V4603.EndInit();
			// 
			// xDJ_V4604
			// 
			this.xDJ_V4604.BeginInit();
			this.xDJ_V4604.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_V4604.IsOnlyInput = true;
			this.xDJ_V4604.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_V4604.Name = "xDJ_V4604";
			this.xDJ_V4604.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_V4604.TagName = "DJ_V4604";
			this.xDJ_V4604.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_V4604.EndInit();
			// 
			// xDJ_BANCO_CAPACITORES
			// 
			this.xDJ_BANCO_CAPACITORES.BeginInit();
			this.xDJ_BANCO_CAPACITORES.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_BANCO_CAPACITORES.IsOnlyInput = true;
			this.xDJ_BANCO_CAPACITORES.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_BANCO_CAPACITORES.Name = "xDJ_BANCO_CAPACITORES";
			this.xDJ_BANCO_CAPACITORES.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_BANCO_CAPACITORES.TagName = "DJ_BANCO_CAPACITORES";
			this.xDJ_BANCO_CAPACITORES.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_BANCO_CAPACITORES.EndInit();
			// 
			// xDJ_PCE_SUBESTACAO
			// 
			this.xDJ_PCE_SUBESTACAO.BeginInit();
			this.xDJ_PCE_SUBESTACAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_PCE_SUBESTACAO.IsOnlyInput = true;
			this.xDJ_PCE_SUBESTACAO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_PCE_SUBESTACAO.Name = "xDJ_PCE_SUBESTACAO";
			this.xDJ_PCE_SUBESTACAO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_PCE_SUBESTACAO.TagName = "DJ_PCE_SUBESTACAO";
			this.xDJ_PCE_SUBESTACAO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_PCE_SUBESTACAO.EndInit();
			// 
			// xDJ_COMP_500_01
			// 
			this.xDJ_COMP_500_01.BeginInit();
			this.xDJ_COMP_500_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_COMP_500_01.IsOnlyInput = true;
			this.xDJ_COMP_500_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_COMP_500_01.Name = "xDJ_COMP_500_01";
			this.xDJ_COMP_500_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_COMP_500_01.TagName = "DJ_COMP_500_01";
			this.xDJ_COMP_500_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_COMP_500_01.EndInit();
			// 
			// xDJ_UCT_200_02
			// 
			this.xDJ_UCT_200_02.BeginInit();
			this.xDJ_UCT_200_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_UCT_200_02.IsOnlyInput = true;
			this.xDJ_UCT_200_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_UCT_200_02.Name = "xDJ_UCT_200_02";
			this.xDJ_UCT_200_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_UCT_200_02.TagName = "DJ_UCT_200_02";
			this.xDJ_UCT_200_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_UCT_200_02.EndInit();
			// 
			// xDJ_UCT_200_03
			// 
			this.xDJ_UCT_200_03.BeginInit();
			this.xDJ_UCT_200_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_UCT_200_03.IsOnlyInput = true;
			this.xDJ_UCT_200_03.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_UCT_200_03.Name = "xDJ_UCT_200_03";
			this.xDJ_UCT_200_03.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_UCT_200_03.TagName = "DJ_UCT_200_03";
			this.xDJ_UCT_200_03.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_UCT_200_03.EndInit();
			// 
			// xDJ_PCM_NEREDA
			// 
			this.xDJ_PCM_NEREDA.BeginInit();
			this.xDJ_PCM_NEREDA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_PCM_NEREDA.IsOnlyInput = true;
			this.xDJ_PCM_NEREDA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_PCM_NEREDA.Name = "xDJ_PCM_NEREDA";
			this.xDJ_PCM_NEREDA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_PCM_NEREDA.TagName = "DJ_PCM_NEREDA";
			this.xDJ_PCM_NEREDA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_PCM_NEREDA.EndInit();
			// 
			// xDJ_PCM_LODO
			// 
			this.xDJ_PCM_LODO.BeginInit();
			this.xDJ_PCM_LODO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_PCM_LODO.IsOnlyInput = true;
			this.xDJ_PCM_LODO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_PCM_LODO.Name = "xDJ_PCM_LODO";
			this.xDJ_PCM_LODO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_PCM_LODO.TagName = "DJ_PCM_LODO";
			this.xDJ_PCM_LODO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_PCM_LODO.EndInit();
			// 
			// xDJ_CAP2
			// 
			this.xDJ_CAP2.BeginInit();
			this.xDJ_CAP2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_CAP2.IsOnlyInput = true;
			this.xDJ_CAP2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_CAP2.Name = "xDJ_CAP2";
			this.xDJ_CAP2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_CAP2.TagName = "DJ_CAP2";
			this.xDJ_CAP2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_CAP2.EndInit();
			// 
			// xDJ_PCM_AGUA_REUSO
			// 
			this.xDJ_PCM_AGUA_REUSO.BeginInit();
			this.xDJ_PCM_AGUA_REUSO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_PCM_AGUA_REUSO.IsOnlyInput = true;
			this.xDJ_PCM_AGUA_REUSO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_PCM_AGUA_REUSO.Name = "xDJ_PCM_AGUA_REUSO";
			this.xDJ_PCM_AGUA_REUSO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_PCM_AGUA_REUSO.TagName = "DJ_PCM_AGUA_REUSO";
			this.xDJ_PCM_AGUA_REUSO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_PCM_AGUA_REUSO.EndInit();
			// 
			// xDJ_MO_500_01
			// 
			this.xDJ_MO_500_01.BeginInit();
			this.xDJ_MO_500_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_MO_500_01.IsOnlyInput = true;
			this.xDJ_MO_500_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_MO_500_01.Name = "xDJ_MO_500_01";
			this.xDJ_MO_500_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_MO_500_01.TagName = "DJ_MO_500_01";
			this.xDJ_MO_500_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_MO_500_01.EndInit();
			// 
			// xDJ_V4601
			// 
			this.xDJ_V4601.BeginInit();
			this.xDJ_V4601.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_V4601.IsOnlyInput = true;
			this.xDJ_V4601.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_V4601.Name = "xDJ_V4601";
			this.xDJ_V4601.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_V4601.TagName = "DJ_V4601";
			this.xDJ_V4601.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_V4601.EndInit();
			// 
			// xDJ_V4602
			// 
			this.xDJ_V4602.BeginInit();
			this.xDJ_V4602.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_V4602.IsOnlyInput = true;
			this.xDJ_V4602.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_V4602.Name = "xDJ_V4602";
			this.xDJ_V4602.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_V4602.TagName = "DJ_V4602";
			this.xDJ_V4602.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_V4602.EndInit();
			// 
			// xDJ_RES_B1
			// 
			this.xDJ_RES_B1.BeginInit();
			this.xDJ_RES_B1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_B1.IsOnlyInput = true;
			this.xDJ_RES_B1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_B1.Name = "xDJ_RES_B1";
			this.xDJ_RES_B1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_B1.TagName = "DJ_RES_B1";
			this.xDJ_RES_B1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_B1.EndInit();
			// 
			// xDJ_RES_B2
			// 
			this.xDJ_RES_B2.BeginInit();
			this.xDJ_RES_B2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_B2.IsOnlyInput = true;
			this.xDJ_RES_B2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_B2.Name = "xDJ_RES_B2";
			this.xDJ_RES_B2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_B2.TagName = "DJ_RES_B2";
			this.xDJ_RES_B2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_B2.EndInit();
			// 
			// xDJ_RES_B3
			// 
			this.xDJ_RES_B3.BeginInit();
			this.xDJ_RES_B3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_B3.IsOnlyInput = true;
			this.xDJ_RES_B3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_B3.Name = "xDJ_RES_B3";
			this.xDJ_RES_B3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_B3.TagName = "DJ_RES_B3";
			this.xDJ_RES_B3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_B3.EndInit();
			// 
			// xDJ_QGBT_220V_ENTRADA
			// 
			this.xDJ_QGBT_220V_ENTRADA.BeginInit();
			this.xDJ_QGBT_220V_ENTRADA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_QGBT_220V_ENTRADA.IsOnlyInput = true;
			this.xDJ_QGBT_220V_ENTRADA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_QGBT_220V_ENTRADA.Name = "xDJ_QGBT_220V_ENTRADA";
			this.xDJ_QGBT_220V_ENTRADA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_QGBT_220V_ENTRADA.TagName = "DJ_QGBT_220V_ENTRADA";
			this.xDJ_QGBT_220V_ENTRADA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_QGBT_220V_ENTRADA.EndInit();
			// 
			// xDJ_QL_ADM
			// 
			this.xDJ_QL_ADM.BeginInit();
			this.xDJ_QL_ADM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_QL_ADM.IsOnlyInput = true;
			this.xDJ_QL_ADM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_QL_ADM.Name = "xDJ_QL_ADM";
			this.xDJ_QL_ADM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_QL_ADM.TagName = "DJ_QL_ADM";
			this.xDJ_QL_ADM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_QL_ADM.EndInit();
			// 
			// xDJ_QL_PORTARIA
			// 
			this.xDJ_QL_PORTARIA.BeginInit();
			this.xDJ_QL_PORTARIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_QL_PORTARIA.IsOnlyInput = true;
			this.xDJ_QL_PORTARIA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_QL_PORTARIA.Name = "xDJ_QL_PORTARIA";
			this.xDJ_QL_PORTARIA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_QL_PORTARIA.TagName = "DJ_QL_PORTARIA";
			this.xDJ_QL_PORTARIA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_QL_PORTARIA.EndInit();
			// 
			// xDJ_QLSL
			// 
			this.xDJ_QLSL.BeginInit();
			this.xDJ_QLSL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_QLSL.IsOnlyInput = true;
			this.xDJ_QLSL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_QLSL.Name = "xDJ_QLSL";
			this.xDJ_QLSL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_QLSL.TagName = "DJ_QLSL";
			this.xDJ_QLSL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_QLSL.EndInit();
			// 
			// xDJ_QL_ILUMINACAO
			// 
			this.xDJ_QL_ILUMINACAO.BeginInit();
			this.xDJ_QL_ILUMINACAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_QL_ILUMINACAO.IsOnlyInput = true;
			this.xDJ_QL_ILUMINACAO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_QL_ILUMINACAO.Name = "xDJ_QL_ILUMINACAO";
			this.xDJ_QL_ILUMINACAO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_QL_ILUMINACAO.TagName = "DJ_QL_ILUMINACAO";
			this.xDJ_QL_ILUMINACAO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_QL_ILUMINACAO.EndInit();
			// 
			// xDJ_PCE_SOPRADORES
			// 
			this.xDJ_PCE_SOPRADORES.BeginInit();
			this.xDJ_PCE_SOPRADORES.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_PCE_SOPRADORES.IsOnlyInput = true;
			this.xDJ_PCE_SOPRADORES.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_PCE_SOPRADORES.Name = "xDJ_PCE_SOPRADORES";
			this.xDJ_PCE_SOPRADORES.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_PCE_SOPRADORES.TagName = "DJ_PCE_SOPRADORES";
			this.xDJ_PCE_SOPRADORES.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_PCE_SOPRADORES.EndInit();
			// 
			// xDJ_QL_LODO
			// 
			this.xDJ_QL_LODO.BeginInit();
			this.xDJ_QL_LODO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_QL_LODO.IsOnlyInput = true;
			this.xDJ_QL_LODO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_QL_LODO.Name = "xDJ_QL_LODO";
			this.xDJ_QL_LODO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_QL_LODO.TagName = "DJ_QL_LODO";
			this.xDJ_QL_LODO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_QL_LODO.EndInit();
			// 
			// xDJ_RES_C1
			// 
			this.xDJ_RES_C1.BeginInit();
			this.xDJ_RES_C1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_C1.IsOnlyInput = true;
			this.xDJ_RES_C1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_C1.Name = "xDJ_RES_C1";
			this.xDJ_RES_C1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_C1.TagName = "DJ_RES_C1";
			this.xDJ_RES_C1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_C1.EndInit();
			// 
			// xDJ_RES_C2
			// 
			this.xDJ_RES_C2.BeginInit();
			this.xDJ_RES_C2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_C2.IsOnlyInput = true;
			this.xDJ_RES_C2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_C2.Name = "xDJ_RES_C2";
			this.xDJ_RES_C2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_C2.TagName = "DJ_RES_C2";
			this.xDJ_RES_C2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_C2.EndInit();
			// 
			// xDJ_RES_C3
			// 
			this.xDJ_RES_C3.BeginInit();
			this.xDJ_RES_C3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_C3.IsOnlyInput = true;
			this.xDJ_RES_C3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_C3.Name = "xDJ_RES_C3";
			this.xDJ_RES_C3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_C3.TagName = "DJ_RES_C3";
			this.xDJ_RES_C3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_C3.EndInit();
			// 
			// xDJ_RES_C4
			// 
			this.xDJ_RES_C4.BeginInit();
			this.xDJ_RES_C4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_C4.IsOnlyInput = true;
			this.xDJ_RES_C4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_C4.Name = "xDJ_RES_C4";
			this.xDJ_RES_C4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_C4.TagName = "DJ_RES_C4";
			this.xDJ_RES_C4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_C4.EndInit();
			// 
			// xDJ_RES_C5
			// 
			this.xDJ_RES_C5.BeginInit();
			this.xDJ_RES_C5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_C5.IsOnlyInput = true;
			this.xDJ_RES_C5.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_C5.Name = "xDJ_RES_C5";
			this.xDJ_RES_C5.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_C5.TagName = "DJ_RES_C5";
			this.xDJ_RES_C5.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_C5.EndInit();
			// 
			// xDJ_RES_C6
			// 
			this.xDJ_RES_C6.BeginInit();
			this.xDJ_RES_C6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_RES_C6.IsOnlyInput = true;
			this.xDJ_RES_C6.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_RES_C6.Name = "xDJ_RES_C6";
			this.xDJ_RES_C6.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_RES_C6.TagName = "DJ_RES_C6";
			this.xDJ_RES_C6.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_RES_C6.EndInit();
			// 
			// xMPL_1Q1
			// 
			this.xMPL_1Q1.BeginInit();
			this.xMPL_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPL_1Q1.IsOnlyInput = true;
			this.xMPL_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPL_1Q1.Name = "xMPL_1Q1";
			this.xMPL_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPL_1Q1.TagName = "MPL_1Q1";
			this.xMPL_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPL_1Q1.EndInit();
			// 
			// xMPR_1Q1
			// 
			this.xMPR_1Q1.BeginInit();
			this.xMPR_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPR_1Q1.IsOnlyInput = true;
			this.xMPR_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPR_1Q1.Name = "xMPR_1Q1";
			this.xMPR_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPR_1Q1.TagName = "MPR_1Q1";
			this.xMPR_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPR_1Q1.EndInit();
			// 
			// xMPP_1Q1
			// 
			this.xMPP_1Q1.BeginInit();
			this.xMPP_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPP_1Q1.IsOnlyInput = true;
			this.xMPP_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPP_1Q1.Name = "xMPP_1Q1";
			this.xMPP_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPP_1Q1.TagName = "MPP_1Q1";
			this.xMPP_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPP_1Q1.EndInit();
			// 
			// xMPC_1Q1
			// 
			this.xMPC_1Q1.BeginInit();
			this.xMPC_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPC_1Q1.IsOnlyInput = true;
			this.xMPC_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPC_1Q1.Name = "xMPC_1Q1";
			this.xMPC_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPC_1Q1.TagName = "MPC_1Q1";
			this.xMPC_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPC_1Q1.EndInit();
			// 
			// xMPSF_1Q1
			// 
			this.xMPSF_1Q1.BeginInit();
			this.xMPSF_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPSF_1Q1.IsOnlyInput = true;
			this.xMPSF_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPSF_1Q1.Name = "xMPSF_1Q1";
			this.xMPSF_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPSF_1Q1.TagName = "MPSF_1Q1";
			this.xMPSF_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPSF_1Q1.EndInit();
			// 
			// xMPL_1Q0
			// 
			this.xMPL_1Q0.BeginInit();
			this.xMPL_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPL_1Q0.IsOnlyInput = true;
			this.xMPL_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPL_1Q0.Name = "xMPL_1Q0";
			this.xMPL_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPL_1Q0.TagName = "MPL_1Q0";
			this.xMPL_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPL_1Q0.EndInit();
			// 
			// xMPR_1Q0
			// 
			this.xMPR_1Q0.BeginInit();
			this.xMPR_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPR_1Q0.IsOnlyInput = true;
			this.xMPR_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPR_1Q0.Name = "xMPR_1Q0";
			this.xMPR_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPR_1Q0.TagName = "MPR_1Q0";
			this.xMPR_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPR_1Q0.EndInit();
			// 
			// xMPP_1Q0
			// 
			this.xMPP_1Q0.BeginInit();
			this.xMPP_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPP_1Q0.IsOnlyInput = true;
			this.xMPP_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPP_1Q0.Name = "xMPP_1Q0";
			this.xMPP_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPP_1Q0.TagName = "MPP_1Q0";
			this.xMPP_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPP_1Q0.EndInit();
			// 
			// xMPC_1Q0
			// 
			this.xMPC_1Q0.BeginInit();
			this.xMPC_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPC_1Q0.IsOnlyInput = true;
			this.xMPC_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPC_1Q0.Name = "xMPC_1Q0";
			this.xMPC_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPC_1Q0.TagName = "MPC_1Q0";
			this.xMPC_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPC_1Q0.EndInit();
			// 
			// xMPSF_1Q0
			// 
			this.xMPSF_1Q0.BeginInit();
			this.xMPSF_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPSF_1Q0.IsOnlyInput = true;
			this.xMPSF_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPSF_1Q0.Name = "xMPSF_1Q0";
			this.xMPSF_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPSF_1Q0.TagName = "MPSF_1Q0";
			this.xMPSF_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPSF_1Q0.EndInit();
			// 
			// xMPL_1Q2
			// 
			this.xMPL_1Q2.BeginInit();
			this.xMPL_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPL_1Q2.IsOnlyInput = true;
			this.xMPL_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPL_1Q2.Name = "xMPL_1Q2";
			this.xMPL_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPL_1Q2.TagName = "MPL_1Q2";
			this.xMPL_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPL_1Q2.EndInit();
			// 
			// xMPR_1Q2
			// 
			this.xMPR_1Q2.BeginInit();
			this.xMPR_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPR_1Q2.IsOnlyInput = true;
			this.xMPR_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPR_1Q2.Name = "xMPR_1Q2";
			this.xMPR_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPR_1Q2.TagName = "MPR_1Q2";
			this.xMPR_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPR_1Q2.EndInit();
			// 
			// xMPP_1Q2
			// 
			this.xMPP_1Q2.BeginInit();
			this.xMPP_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPP_1Q2.IsOnlyInput = true;
			this.xMPP_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPP_1Q2.Name = "xMPP_1Q2";
			this.xMPP_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPP_1Q2.TagName = "MPP_1Q2";
			this.xMPP_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPP_1Q2.EndInit();
			// 
			// xMPC_1Q2
			// 
			this.xMPC_1Q2.BeginInit();
			this.xMPC_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPC_1Q2.IsOnlyInput = true;
			this.xMPC_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPC_1Q2.Name = "xMPC_1Q2";
			this.xMPC_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPC_1Q2.TagName = "MPC_1Q2";
			this.xMPC_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPC_1Q2.EndInit();
			// 
			// xMPSF_1Q2
			// 
			this.xMPSF_1Q2.BeginInit();
			this.xMPSF_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMPSF_1Q2.IsOnlyInput = true;
			this.xMPSF_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMPSF_1Q2.Name = "xMPSF_1Q2";
			this.xMPSF_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMPSF_1Q2.TagName = "MPSF_1Q2";
			this.xMPSF_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xMPSF_1Q2.EndInit();
			// 
			// xEST_1Q1
			// 
			this.xEST_1Q1.BeginInit();
			this.xEST_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEST_1Q1.IsOnlyInput = true;
			this.xEST_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEST_1Q1.Name = "xEST_1Q1";
			this.xEST_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEST_1Q1.TagName = "EST_1Q1";
			this.xEST_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEST_1Q1.EndInit();
			// 
			// xEST_1Q0
			// 
			this.xEST_1Q0.BeginInit();
			this.xEST_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEST_1Q0.IsOnlyInput = true;
			this.xEST_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEST_1Q0.Name = "xEST_1Q0";
			this.xEST_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEST_1Q0.TagName = "EST_1Q0";
			this.xEST_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEST_1Q0.EndInit();
			// 
			// xEST_1Q2
			// 
			this.xEST_1Q2.BeginInit();
			this.xEST_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEST_1Q2.IsOnlyInput = true;
			this.xEST_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEST_1Q2.Name = "xEST_1Q2";
			this.xEST_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEST_1Q2.TagName = "EST_1Q2";
			this.xEST_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEST_1Q2.EndInit();
			// 
			// xFA
			// 
			this.xFA.BeginInit();
			this.xFA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFA.IsOnlyInput = true;
			this.xFA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFA.Name = "xFA";
			this.xFA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFA.TagName = "FONTE_BARRA_A";
			this.xFA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xFA.EndInit();
			// 
			// xFB
			// 
			this.xFB.BeginInit();
			this.xFB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFB.IsOnlyInput = true;
			this.xFB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFB.Name = "xFB";
			this.xFB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFB.TagName = "FONTE_BARRA_B";
			this.xFB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xFB.EndInit();
			// 
			// xPlanta
			// 
			this.xPlanta.BeginInit();
			this.xPlanta.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPlanta.IsOnlyInput = true;
			this.xPlanta.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPlanta.Name = "xPlanta";
			this.xPlanta.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPlanta.TagName = "PLANTA_NO_GERADOR";
			this.xPlanta.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xPlanta.EndInit();
			// 
			// xRemota
			// 
			this.xRemota.BeginInit();
			this.xRemota.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRemota.IsOnlyInput = true;
			this.xRemota.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRemota.Name = "xRemota";
			this.xRemota.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRemota.TagName = "FALHA_REMOTA1";
			this.xRemota.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xRemota.EndInit();
			// 
			// xQTAM1_GERADOR
			// 
			this.xQTAM1_GERADOR.BeginInit();
			this.xQTAM1_GERADOR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xQTAM1_GERADOR.IsOnlyInput = true;
			this.xQTAM1_GERADOR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xQTAM1_GERADOR.Name = "xQTAM1_GERADOR";
			this.xQTAM1_GERADOR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xQTAM1_GERADOR.TagName = "QTAM1_DISJ_GERADOR";
			this.xQTAM1_GERADOR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xQTAM1_GERADOR.EndInit();
			// 
			// xQTAM1_REDE
			// 
			this.xQTAM1_REDE.BeginInit();
			this.xQTAM1_REDE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xQTAM1_REDE.IsOnlyInput = true;
			this.xQTAM1_REDE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xQTAM1_REDE.Name = "xQTAM1_REDE";
			this.xQTAM1_REDE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xQTAM1_REDE.TagName = "QTAM1_DISJ_REDE";
			this.xQTAM1_REDE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xQTAM1_REDE.EndInit();
			// 
			// xQTAM2_GERADOR
			// 
			this.xQTAM2_GERADOR.BeginInit();
			this.xQTAM2_GERADOR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xQTAM2_GERADOR.IsOnlyInput = true;
			this.xQTAM2_GERADOR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xQTAM2_GERADOR.Name = "xQTAM2_GERADOR";
			this.xQTAM2_GERADOR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xQTAM2_GERADOR.TagName = "QTAM2_DISJ_GERADOR";
			this.xQTAM2_GERADOR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xQTAM2_GERADOR.EndInit();
			// 
			// xQTAM2_REDE
			// 
			this.xQTAM2_REDE.BeginInit();
			this.xQTAM2_REDE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xQTAM2_REDE.IsOnlyInput = true;
			this.xQTAM2_REDE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xQTAM2_REDE.Name = "xQTAM2_REDE";
			this.xQTAM2_REDE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xQTAM2_REDE.TagName = "QTAM2_DISJ_REDE";
			this.xQTAM2_REDE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xQTAM2_REDE.EndInit();
			// 
			// xAF1q1
			// 
			this.xAF1q1.BeginInit();
			this.xAF1q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAF1q1.IsOnlyInput = true;
			this.xAF1q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAF1q1.Name = "xAF1q1";
			this.xAF1q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAF1q1.TagName = "STS_FALHA_1Q1";
			this.xAF1q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAF1q1.EndInit();
			// 
			// xAF1q0
			// 
			this.xAF1q0.BeginInit();
			this.xAF1q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAF1q0.IsOnlyInput = true;
			this.xAF1q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAF1q0.Name = "xAF1q0";
			this.xAF1q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAF1q0.TagName = "STS_FALHA_1Q0";
			this.xAF1q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAF1q0.EndInit();
			// 
			// xAF1q2
			// 
			this.xAF1q2.BeginInit();
			this.xAF1q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAF1q2.IsOnlyInput = true;
			this.xAF1q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAF1q2.Name = "xAF1q2";
			this.xAF1q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAF1q2.TagName = "STS_FALHA_1Q2";
			this.xAF1q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAF1q2.EndInit();
			// 
			// xAD1q1
			// 
			this.xAD1q1.BeginInit();
			this.xAD1q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAD1q1.IsOnlyInput = true;
			this.xAD1q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAD1q1.Name = "xAD1q1";
			this.xAD1q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAD1q1.TagName = "STS_DISCORDANCIA_1Q1";
			this.xAD1q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAD1q1.EndInit();
			// 
			// xAD1q0
			// 
			this.xAD1q0.BeginInit();
			this.xAD1q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAD1q0.IsOnlyInput = true;
			this.xAD1q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAD1q0.Name = "xAD1q0";
			this.xAD1q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAD1q0.TagName = "STS_DISCORDANCIA_1Q0";
			this.xAD1q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAD1q0.EndInit();
			// 
			// xAD1q2
			// 
			this.xAD1q2.BeginInit();
			this.xAD1q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAD1q2.IsOnlyInput = true;
			this.xAD1q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAD1q2.Name = "xAD1q2";
			this.xAD1q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAD1q2.TagName = "STS_DISCORDANCIA_1Q2";
			this.xAD1q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAD1q2.EndInit();
			// 
			// xAC1q1
			// 
			this.xAC1q1.BeginInit();
			this.xAC1q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAC1q1.IsOnlyInput = true;
			this.xAC1q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAC1q1.Name = "xAC1q1";
			this.xAC1q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAC1q1.TagName = "STS_SEM_RESPOSTA_1Q1";
			this.xAC1q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAC1q1.EndInit();
			// 
			// xAC1q0
			// 
			this.xAC1q0.BeginInit();
			this.xAC1q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAC1q0.IsOnlyInput = true;
			this.xAC1q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAC1q0.Name = "xAC1q0";
			this.xAC1q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAC1q0.TagName = "STS_SEM_RESPOSTA_1Q0";
			this.xAC1q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAC1q0.EndInit();
			// 
			// xAC1q2
			// 
			this.xAC1q2.BeginInit();
			this.xAC1q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAC1q2.IsOnlyInput = true;
			this.xAC1q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAC1q2.Name = "xAC1q2";
			this.xAC1q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAC1q2.TagName = "STS_SEM_RESPOSTA_1Q2";
			this.xAC1q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xAC1q2.EndInit();
			// 
			// xEF1q1
			// 
			this.xEF1q1.BeginInit();
			this.xEF1q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEF1q1.IsOnlyInput = true;
			this.xEF1q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEF1q1.Name = "xEF1q1";
			this.xEF1q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEF1q1.TagName = "STS_ALM_FALHA_1Q1_EST";
			this.xEF1q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEF1q1.EndInit();
			// 
			// xEF1q0
			// 
			this.xEF1q0.BeginInit();
			this.xEF1q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEF1q0.IsOnlyInput = true;
			this.xEF1q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEF1q0.Name = "xEF1q0";
			this.xEF1q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEF1q0.TagName = "STS_ALM_FALHA_1Q0_EST";
			this.xEF1q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEF1q0.EndInit();
			// 
			// xEF1q2
			// 
			this.xEF1q2.BeginInit();
			this.xEF1q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEF1q2.IsOnlyInput = true;
			this.xEF1q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEF1q2.Name = "xEF1q2";
			this.xEF1q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEF1q2.TagName = "STS_ALM_FALHA_1Q2_EST";
			this.xEF1q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEF1q2.EndInit();
			// 
			// xED1q1
			// 
			this.xED1q1.BeginInit();
			this.xED1q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xED1q1.IsOnlyInput = true;
			this.xED1q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xED1q1.Name = "xED1q1";
			this.xED1q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xED1q1.TagName = "STS_ALM_DISCORDANCIA_1Q1_EST";
			this.xED1q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xED1q1.EndInit();
			// 
			// xED1q0
			// 
			this.xED1q0.BeginInit();
			this.xED1q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xED1q0.IsOnlyInput = true;
			this.xED1q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xED1q0.Name = "xED1q0";
			this.xED1q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xED1q0.TagName = "STS_ALM_DISCORDANCIA_1Q0_EST";
			this.xED1q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xED1q0.EndInit();
			// 
			// xED1q2
			// 
			this.xED1q2.BeginInit();
			this.xED1q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xED1q2.IsOnlyInput = true;
			this.xED1q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xED1q2.Name = "xED1q2";
			this.xED1q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xED1q2.TagName = "STS_ALM_DISCORDANCIA_1Q2_EST";
			this.xED1q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xED1q2.EndInit();
			// 
			// xEC1q1
			// 
			this.xEC1q1.BeginInit();
			this.xEC1q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEC1q1.IsOnlyInput = true;
			this.xEC1q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEC1q1.Name = "xEC1q1";
			this.xEC1q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEC1q1.TagName = "STS_ALM_SEM_RESPOSTA_1Q1_EST";
			this.xEC1q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEC1q1.EndInit();
			// 
			// xEC1q0
			// 
			this.xEC1q0.BeginInit();
			this.xEC1q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEC1q0.IsOnlyInput = true;
			this.xEC1q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEC1q0.Name = "xEC1q0";
			this.xEC1q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEC1q0.TagName = "STS_ALM_SEM_RESPOSTA_1Q0_EST";
			this.xEC1q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEC1q0.EndInit();
			// 
			// xEC1q2
			// 
			this.xEC1q2.BeginInit();
			this.xEC1q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEC1q2.IsOnlyInput = true;
			this.xEC1q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEC1q2.Name = "xEC1q2";
			this.xEC1q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEC1q2.TagName = "STS_ALM_SEM_RESPOSTA_1Q2_EST";
			this.xEC1q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MpChanged);
			this.xEC1q2.EndInit();
			// 
			// pNER
			// 
			this.pNER.Bounds = new NxtControl.Drawing.RectF(((float)(695D)), ((float)(504D)), ((float)(352D)), ((float)(80D)));
			this.pNER.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.pNER.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pNER.Name = "pNER";
			this.pNER.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pNERt
			// 
			this.pNERt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pNERt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.pNERt.Location = new NxtControl.Drawing.PointF(701D, 508D);
			this.pNERt.Name = "pNERt";
			this.pNERt.Text = "PAINEL NEREDA";
			// 
			// pNERc
			// 
			this.pNERc.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
			this.pNERc.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.pNERc.Location = new NxtControl.Drawing.PointF(835D, 508D);
			this.pNERc.Name = "pNERc";
			this.pNERc.Text = "";
			// 
			// pNERbar
			// 
			this.pNERbar.Bounds = new NxtControl.Drawing.RectF(((float)(701D)), ((float)(526D)), ((float)(340D)), ((float)(4D)));
			this.pNERbar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))));
			this.pNERbar.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pNERbar.Name = "pNERbar";
			this.pNERbar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lpNER_PCE
			// 
			this.lpNER_PCE.EndPoint = new NxtControl.Drawing.PointF(720.5D, 538D);
			this.lpNER_PCE.Name = "lpNER_PCE";
			this.lpNER_PCE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpNER_PCE.StartPoint = new NxtControl.Drawing.PointF(720.5D, 530D);
			// 
			// bpNER_PCE
			// 
			this.bpNER_PCE.Bounds = new NxtControl.Drawing.RectF(((float)(712.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpNER_PCE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpNER_PCE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpNER_PCE.Name = "bpNER_PCE";
			this.bpNER_PCE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpNER_PCE
			// 
			this.tpNER_PCE.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpNER_PCE.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpNER_PCE.Location = new NxtControl.Drawing.PointF(713.1D, 557D);
			this.tpNER_PCE.Name = "tpNER_PCE";
			this.tpNER_PCE.Text = "PCE";
			// 
			// lpNER_PCM
			// 
			this.lpNER_PCM.EndPoint = new NxtControl.Drawing.PointF(763.5D, 538D);
			this.lpNER_PCM.Name = "lpNER_PCM";
			this.lpNER_PCM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpNER_PCM.StartPoint = new NxtControl.Drawing.PointF(763.5D, 530D);
			// 
			// bpNER_PCM
			// 
			this.bpNER_PCM.Bounds = new NxtControl.Drawing.RectF(((float)(755.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpNER_PCM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpNER_PCM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpNER_PCM.Name = "bpNER_PCM";
			this.bpNER_PCM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpNER_PCM
			// 
			this.tpNER_PCM.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpNER_PCM.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpNER_PCM.Location = new NxtControl.Drawing.PointF(756.1D, 557D);
			this.tpNER_PCM.Name = "tpNER_PCM";
			this.tpNER_PCM.Text = "PCM";
			// 
			// lpMO_300_01
			// 
			this.lpMO_300_01.EndPoint = new NxtControl.Drawing.PointF(806.5D, 538D);
			this.lpMO_300_01.Name = "lpMO_300_01";
			this.lpMO_300_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpMO_300_01.StartPoint = new NxtControl.Drawing.PointF(806.5D, 530D);
			// 
			// bpMO_300_01
			// 
			this.bpMO_300_01.Bounds = new NxtControl.Drawing.RectF(((float)(798.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpMO_300_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpMO_300_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpMO_300_01.Name = "bpMO_300_01";
			this.bpMO_300_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpMO_300_01
			// 
			this.tpMO_300_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpMO_300_01.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpMO_300_01.Location = new NxtControl.Drawing.PointF(794.2D, 557D);
			this.tpMO_300_01.Name = "tpMO_300_01";
			this.tpMO_300_01.Text = "300-\r\nMO-01";
			// 
			// lpR4005A
			// 
			this.lpR4005A.EndPoint = new NxtControl.Drawing.PointF(849.5D, 538D);
			this.lpR4005A.Name = "lpR4005A";
			this.lpR4005A.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpR4005A.StartPoint = new NxtControl.Drawing.PointF(849.5D, 530D);
			// 
			// bpR4005A
			// 
			this.bpR4005A.Bounds = new NxtControl.Drawing.RectF(((float)(841.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpR4005A.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpR4005A.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpR4005A.Name = "bpR4005A";
			this.bpR4005A.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpR4005A
			// 
			this.tpR4005A.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpR4005A.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpR4005A.Location = new NxtControl.Drawing.PointF(834.8D, 557D);
			this.tpR4005A.Name = "tpR4005A";
			this.tpR4005A.Text = "R4005A";
			// 
			// lpR4005B
			// 
			this.lpR4005B.EndPoint = new NxtControl.Drawing.PointF(892.5D, 538D);
			this.lpR4005B.Name = "lpR4005B";
			this.lpR4005B.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpR4005B.StartPoint = new NxtControl.Drawing.PointF(892.5D, 530D);
			// 
			// bpR4005B
			// 
			this.bpR4005B.Bounds = new NxtControl.Drawing.RectF(((float)(884.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpR4005B.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpR4005B.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpR4005B.Name = "bpR4005B";
			this.bpR4005B.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpR4005B
			// 
			this.tpR4005B.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpR4005B.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpR4005B.Location = new NxtControl.Drawing.PointF(877.8D, 557D);
			this.tpR4005B.Name = "tpR4005B";
			this.tpR4005B.Text = "R4005B";
			// 
			// lpP4901
			// 
			this.lpP4901.EndPoint = new NxtControl.Drawing.PointF(935.5D, 538D);
			this.lpP4901.Name = "lpP4901";
			this.lpP4901.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpP4901.StartPoint = new NxtControl.Drawing.PointF(935.5D, 530D);
			// 
			// bpP4901
			// 
			this.bpP4901.Bounds = new NxtControl.Drawing.RectF(((float)(927.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpP4901.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpP4901.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpP4901.Name = "bpP4901";
			this.bpP4901.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpP4901
			// 
			this.tpP4901.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpP4901.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpP4901.Location = new NxtControl.Drawing.PointF(923.2D, 557D);
			this.tpP4901.Name = "tpP4901";
			this.tpP4901.Text = "P4901";
			// 
			// lpP4902
			// 
			this.lpP4902.EndPoint = new NxtControl.Drawing.PointF(978.5D, 538D);
			this.lpP4902.Name = "lpP4902";
			this.lpP4902.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpP4902.StartPoint = new NxtControl.Drawing.PointF(978.5D, 530D);
			// 
			// bpP4902
			// 
			this.bpP4902.Bounds = new NxtControl.Drawing.RectF(((float)(970.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpP4902.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpP4902.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpP4902.Name = "bpP4902";
			this.bpP4902.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpP4902
			// 
			this.tpP4902.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpP4902.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpP4902.Location = new NxtControl.Drawing.PointF(966.2D, 557D);
			this.tpP4902.Name = "tpP4902";
			this.tpP4902.Text = "P4902";
			// 
			// lpP4903
			// 
			this.lpP4903.EndPoint = new NxtControl.Drawing.PointF(1021.5D, 538D);
			this.lpP4903.Name = "lpP4903";
			this.lpP4903.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpP4903.StartPoint = new NxtControl.Drawing.PointF(1021.5D, 530D);
			// 
			// bpP4903
			// 
			this.bpP4903.Bounds = new NxtControl.Drawing.RectF(((float)(1013.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpP4903.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpP4903.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpP4903.Name = "bpP4903";
			this.bpP4903.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpP4903
			// 
			this.tpP4903.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpP4903.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpP4903.Location = new NxtControl.Drawing.PointF(1009.2D, 557D);
			this.tpP4903.Name = "tpP4903";
			this.tpP4903.Text = "P4903";
			// 
			// pDES
			// 
			this.pDES.Bounds = new NxtControl.Drawing.RectF(((float)(1055D)), ((float)(504D)), ((float)(275D)), ((float)(80D)));
			this.pDES.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.pDES.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pDES.Name = "pDES";
			this.pDES.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pDESt
			// 
			this.pDESt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pDESt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.pDESt.Location = new NxtControl.Drawing.PointF(1061D, 508D);
			this.pDESt.Name = "pDESt";
			this.pDESt.Text = "PAINEL DESINFECÇÃO";
			// 
			// pDESc
			// 
			this.pDESc.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
			this.pDESc.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.pDESc.Location = new NxtControl.Drawing.PointF(1195D, 508D);
			this.pDESc.Name = "pDESc";
			this.pDESc.Text = "";
			// 
			// pDESbar
			// 
			this.pDESbar.Bounds = new NxtControl.Drawing.RectF(((float)(1061D)), ((float)(526D)), ((float)(263D)), ((float)(4D)));
			this.pDESbar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))));
			this.pDESbar.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pDESbar.Name = "pDESbar";
			this.pDESbar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lpDES_PCE
			// 
			this.lpDES_PCE.EndPoint = new NxtControl.Drawing.PointF(1082.5D, 538D);
			this.lpDES_PCE.Name = "lpDES_PCE";
			this.lpDES_PCE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpDES_PCE.StartPoint = new NxtControl.Drawing.PointF(1082.5D, 530D);
			// 
			// bpDES_PCE
			// 
			this.bpDES_PCE.Bounds = new NxtControl.Drawing.RectF(((float)(1074.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpDES_PCE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpDES_PCE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpDES_PCE.Name = "bpDES_PCE";
			this.bpDES_PCE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpDES_PCE
			// 
			this.tpDES_PCE.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpDES_PCE.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpDES_PCE.Location = new NxtControl.Drawing.PointF(1075.2D, 557D);
			this.tpDES_PCE.Name = "tpDES_PCE";
			this.tpDES_PCE.Text = "PCE";
			// 
			// lpDES_PCM
			// 
			this.lpDES_PCM.EndPoint = new NxtControl.Drawing.PointF(1126.5D, 538D);
			this.lpDES_PCM.Name = "lpDES_PCM";
			this.lpDES_PCM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpDES_PCM.StartPoint = new NxtControl.Drawing.PointF(1126.5D, 530D);
			// 
			// bpDES_PCM
			// 
			this.bpDES_PCM.Bounds = new NxtControl.Drawing.RectF(((float)(1118.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpDES_PCM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpDES_PCM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpDES_PCM.Name = "bpDES_PCM";
			this.bpDES_PCM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpDES_PCM
			// 
			this.tpDES_PCM.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpDES_PCM.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpDES_PCM.Location = new NxtControl.Drawing.PointF(1119.2D, 557D);
			this.tpDES_PCM.Name = "tpDES_PCM";
			this.tpDES_PCM.Text = "PCM";
			// 
			// lpUV_700_01
			// 
			this.lpUV_700_01.EndPoint = new NxtControl.Drawing.PointF(1170.5D, 538D);
			this.lpUV_700_01.Name = "lpUV_700_01";
			this.lpUV_700_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpUV_700_01.StartPoint = new NxtControl.Drawing.PointF(1170.5D, 530D);
			// 
			// bpUV_700_01
			// 
			this.bpUV_700_01.Bounds = new NxtControl.Drawing.RectF(((float)(1162.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpUV_700_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpUV_700_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpUV_700_01.Name = "bpUV_700_01";
			this.bpUV_700_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpUV_700_01
			// 
			this.tpUV_700_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpUV_700_01.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpUV_700_01.Location = new NxtControl.Drawing.PointF(1158.2D, 557D);
			this.tpUV_700_01.Name = "tpUV_700_01";
			this.tpUV_700_01.Text = "700-\r\nUV-01";
			// 
			// lpUV_700_02
			// 
			this.lpUV_700_02.EndPoint = new NxtControl.Drawing.PointF(1214.5D, 538D);
			this.lpUV_700_02.Name = "lpUV_700_02";
			this.lpUV_700_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpUV_700_02.StartPoint = new NxtControl.Drawing.PointF(1214.5D, 530D);
			// 
			// bpUV_700_02
			// 
			this.bpUV_700_02.Bounds = new NxtControl.Drawing.RectF(((float)(1206.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpUV_700_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpUV_700_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpUV_700_02.Name = "bpUV_700_02";
			this.bpUV_700_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpUV_700_02
			// 
			this.tpUV_700_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpUV_700_02.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpUV_700_02.Location = new NxtControl.Drawing.PointF(1202.2D, 557D);
			this.tpUV_700_02.Name = "tpUV_700_02";
			this.tpUV_700_02.Text = "700-\r\nUV-02";
			// 
			// lpVC_700_01
			// 
			this.lpVC_700_01.EndPoint = new NxtControl.Drawing.PointF(1258.5D, 538D);
			this.lpVC_700_01.Name = "lpVC_700_01";
			this.lpVC_700_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpVC_700_01.StartPoint = new NxtControl.Drawing.PointF(1258.5D, 530D);
			// 
			// bpVC_700_01
			// 
			this.bpVC_700_01.Bounds = new NxtControl.Drawing.RectF(((float)(1250.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpVC_700_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpVC_700_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpVC_700_01.Name = "bpVC_700_01";
			this.bpVC_700_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpVC_700_01
			// 
			this.tpVC_700_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpVC_700_01.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpVC_700_01.Location = new NxtControl.Drawing.PointF(1246.2D, 557D);
			this.tpVC_700_01.Name = "tpVC_700_01";
			this.tpVC_700_01.Text = "700-\r\nVC-01";
			// 
			// lpMO_700_01
			// 
			this.lpMO_700_01.EndPoint = new NxtControl.Drawing.PointF(1302.5D, 538D);
			this.lpMO_700_01.Name = "lpMO_700_01";
			this.lpMO_700_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpMO_700_01.StartPoint = new NxtControl.Drawing.PointF(1302.5D, 530D);
			// 
			// bpMO_700_01
			// 
			this.bpMO_700_01.Bounds = new NxtControl.Drawing.RectF(((float)(1294.5D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.bpMO_700_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpMO_700_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpMO_700_01.Name = "bpMO_700_01";
			this.bpMO_700_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpMO_700_01
			// 
			this.tpMO_700_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpMO_700_01.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpMO_700_01.Location = new NxtControl.Drawing.PointF(1290.2D, 557D);
			this.tpMO_700_01.Name = "tpMO_700_01";
			this.tpMO_700_01.Text = "700-\r\nMO-01";
			// 
			// pEEEB
			// 
			this.pEEEB.Bounds = new NxtControl.Drawing.RectF(((float)(695D)), ((float)(590D)), ((float)(352D)), ((float)(80D)));
			this.pEEEB.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.pEEEB.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pEEEB.Name = "pEEEB";
			this.pEEEB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pEEEBt
			// 
			this.pEEEBt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pEEEBt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.pEEEBt.Location = new NxtControl.Drawing.PointF(701D, 594D);
			this.pEEEBt.Name = "pEEEBt";
			this.pEEEBt.Text = "PAINEL EEE BRUTO";
			// 
			// pEEEBc
			// 
			this.pEEEBc.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
			this.pEEEBc.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.pEEEBc.Location = new NxtControl.Drawing.PointF(835D, 594D);
			this.pEEEBc.Name = "pEEEBc";
			this.pEEEBc.Text = "";
			// 
			// pEEEBbar
			// 
			this.pEEEBbar.Bounds = new NxtControl.Drawing.RectF(((float)(701D)), ((float)(612D)), ((float)(340D)), ((float)(4D)));
			this.pEEEBbar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))));
			this.pEEEBbar.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pEEEBbar.Name = "pEEEBbar";
			this.pEEEBbar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lpEEEB_PCE
			// 
			this.lpEEEB_PCE.EndPoint = new NxtControl.Drawing.PointF(720.5D, 624D);
			this.lpEEEB_PCE.Name = "lpEEEB_PCE";
			this.lpEEEB_PCE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpEEEB_PCE.StartPoint = new NxtControl.Drawing.PointF(720.5D, 616D);
			// 
			// bpEEEB_PCE
			// 
			this.bpEEEB_PCE.Bounds = new NxtControl.Drawing.RectF(((float)(712.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpEEEB_PCE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpEEEB_PCE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpEEEB_PCE.Name = "bpEEEB_PCE";
			this.bpEEEB_PCE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpEEEB_PCE
			// 
			this.tpEEEB_PCE.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpEEEB_PCE.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpEEEB_PCE.Location = new NxtControl.Drawing.PointF(713.1D, 643D);
			this.tpEEEB_PCE.Name = "tpEEEB_PCE";
			this.tpEEEB_PCE.Text = "PCE";
			// 
			// lpEEEB_PCM
			// 
			this.lpEEEB_PCM.EndPoint = new NxtControl.Drawing.PointF(763.5D, 624D);
			this.lpEEEB_PCM.Name = "lpEEEB_PCM";
			this.lpEEEB_PCM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpEEEB_PCM.StartPoint = new NxtControl.Drawing.PointF(763.5D, 616D);
			// 
			// bpEEEB_PCM
			// 
			this.bpEEEB_PCM.Bounds = new NxtControl.Drawing.RectF(((float)(755.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpEEEB_PCM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpEEEB_PCM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpEEEB_PCM.Name = "bpEEEB_PCM";
			this.bpEEEB_PCM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpEEEB_PCM
			// 
			this.tpEEEB_PCM.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpEEEB_PCM.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpEEEB_PCM.Location = new NxtControl.Drawing.PointF(756.1D, 643D);
			this.tpEEEB_PCM.Name = "tpEEEB_PCM";
			this.tpEEEB_PCM.Text = "PCM";
			// 
			// lpCO_100_01
			// 
			this.lpCO_100_01.EndPoint = new NxtControl.Drawing.PointF(806.5D, 624D);
			this.lpCO_100_01.Name = "lpCO_100_01";
			this.lpCO_100_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpCO_100_01.StartPoint = new NxtControl.Drawing.PointF(806.5D, 616D);
			// 
			// bpCO_100_01
			// 
			this.bpCO_100_01.Bounds = new NxtControl.Drawing.RectF(((float)(798.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpCO_100_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpCO_100_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpCO_100_01.Name = "bpCO_100_01";
			this.bpCO_100_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpCO_100_01
			// 
			this.tpCO_100_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpCO_100_01.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpCO_100_01.Location = new NxtControl.Drawing.PointF(794.2D, 643D);
			this.tpCO_100_01.Name = "tpCO_100_01";
			this.tpCO_100_01.Text = "100-\r\nCO-01";
			// 
			// lpCO_100_02
			// 
			this.lpCO_100_02.EndPoint = new NxtControl.Drawing.PointF(849.5D, 624D);
			this.lpCO_100_02.Name = "lpCO_100_02";
			this.lpCO_100_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpCO_100_02.StartPoint = new NxtControl.Drawing.PointF(849.5D, 616D);
			// 
			// bpCO_100_02
			// 
			this.bpCO_100_02.Bounds = new NxtControl.Drawing.RectF(((float)(841.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpCO_100_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpCO_100_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpCO_100_02.Name = "bpCO_100_02";
			this.bpCO_100_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpCO_100_02
			// 
			this.tpCO_100_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpCO_100_02.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpCO_100_02.Location = new NxtControl.Drawing.PointF(837.2D, 643D);
			this.tpCO_100_02.Name = "tpCO_100_02";
			this.tpCO_100_02.Text = "100-\r\nCO-02";
			// 
			// lpCO_100_03
			// 
			this.lpCO_100_03.EndPoint = new NxtControl.Drawing.PointF(892.5D, 624D);
			this.lpCO_100_03.Name = "lpCO_100_03";
			this.lpCO_100_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpCO_100_03.StartPoint = new NxtControl.Drawing.PointF(892.5D, 616D);
			// 
			// bpCO_100_03
			// 
			this.bpCO_100_03.Bounds = new NxtControl.Drawing.RectF(((float)(884.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpCO_100_03.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpCO_100_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpCO_100_03.Name = "bpCO_100_03";
			this.bpCO_100_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpCO_100_03
			// 
			this.tpCO_100_03.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpCO_100_03.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpCO_100_03.Location = new NxtControl.Drawing.PointF(880.2D, 643D);
			this.tpCO_100_03.Name = "tpCO_100_03";
			this.tpCO_100_03.Text = "100-\r\nCO-03";
			// 
			// lpCO_100_04
			// 
			this.lpCO_100_04.EndPoint = new NxtControl.Drawing.PointF(935.5D, 624D);
			this.lpCO_100_04.Name = "lpCO_100_04";
			this.lpCO_100_04.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpCO_100_04.StartPoint = new NxtControl.Drawing.PointF(935.5D, 616D);
			// 
			// bpCO_100_04
			// 
			this.bpCO_100_04.Bounds = new NxtControl.Drawing.RectF(((float)(927.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpCO_100_04.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpCO_100_04.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpCO_100_04.Name = "bpCO_100_04";
			this.bpCO_100_04.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpCO_100_04
			// 
			this.tpCO_100_04.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpCO_100_04.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpCO_100_04.Location = new NxtControl.Drawing.PointF(923.2D, 643D);
			this.tpCO_100_04.Name = "tpCO_100_04";
			this.tpCO_100_04.Text = "100-\r\nCO-04";
			// 
			// lpGM_100_01_02
			// 
			this.lpGM_100_01_02.EndPoint = new NxtControl.Drawing.PointF(978.5D, 624D);
			this.lpGM_100_01_02.Name = "lpGM_100_01_02";
			this.lpGM_100_01_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpGM_100_01_02.StartPoint = new NxtControl.Drawing.PointF(978.5D, 616D);
			// 
			// bpGM_100_01_02
			// 
			this.bpGM_100_01_02.Bounds = new NxtControl.Drawing.RectF(((float)(970.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpGM_100_01_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpGM_100_01_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpGM_100_01_02.Name = "bpGM_100_01_02";
			this.bpGM_100_01_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpGM_100_01_02
			// 
			this.tpGM_100_01_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpGM_100_01_02.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpGM_100_01_02.Location = new NxtControl.Drawing.PointF(958.9D, 643D);
			this.tpGM_100_01_02.Name = "tpGM_100_01_02";
			this.tpGM_100_01_02.Text = "100-\r\nGM-01/02";
			// 
			// lpMO_100_01
			// 
			this.lpMO_100_01.EndPoint = new NxtControl.Drawing.PointF(1021.5D, 624D);
			this.lpMO_100_01.Name = "lpMO_100_01";
			this.lpMO_100_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.lpMO_100_01.StartPoint = new NxtControl.Drawing.PointF(1021.5D, 616D);
			// 
			// bpMO_100_01
			// 
			this.bpMO_100_01.Bounds = new NxtControl.Drawing.RectF(((float)(1013.5D)), ((float)(624D)), ((float)(16D)), ((float)(16D)));
			this.bpMO_100_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.bpMO_100_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bpMO_100_01.Name = "bpMO_100_01";
			this.bpMO_100_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tpMO_100_01
			// 
			this.tpMO_100_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tpMO_100_01.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tpMO_100_01.Location = new NxtControl.Drawing.PointF(1009.2D, 643D);
			this.tpMO_100_01.Name = "tpMO_100_01";
			this.tpMO_100_01.Text = "100-\r\nMO-01";
			// 
			// pLeg
			// 
			this.pLeg.Bounds = new NxtControl.Drawing.RectF(((float)(1055D)), ((float)(590D)), ((float)(275D)), ((float)(80D)));
			this.pLeg.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.pLeg.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pLeg.Name = "pLeg";
			this.pLeg.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pLegT
			// 
			this.pLegT.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pLegT.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.pLegT.Location = new NxtControl.Drawing.PointF(1061D, 594D);
			this.pLegT.Name = "pLegT";
			this.pLegT.Text = "Disjuntores dos painéis";
			// 
			// pLeg0
			// 
			this.pLeg0.Bounds = new NxtControl.Drawing.RectF(((float)(1065D)), ((float)(614D)), ((float)(12D)), ((float)(12D)));
			this.pLeg0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30))));
			this.pLeg0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pLeg0.Name = "pLeg0";
			this.pLeg0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pLeg0t
			// 
			this.pLeg0t.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pLeg0t.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.pLeg0t.Location = new NxtControl.Drawing.PointF(1083D, 613D);
			this.pLeg0t.Name = "pLeg0t";
			this.pLeg0t.Text = "Ligado";
			// 
			// pLeg1
			// 
			this.pLeg1.Bounds = new NxtControl.Drawing.RectF(((float)(1065D)), ((float)(632D)), ((float)(12D)), ((float)(12D)));
			this.pLeg1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(140)), ((byte)(60))));
			this.pLeg1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pLeg1.Name = "pLeg1";
			this.pLeg1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pLeg1t
			// 
			this.pLeg1t.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pLeg1t.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.pLeg1t.Location = new NxtControl.Drawing.PointF(1083D, 631D);
			this.pLeg1t.Name = "pLeg1t";
			this.pLeg1t.Text = "Desligado";
			// 
			// pLeg2
			// 
			this.pLeg2.Bounds = new NxtControl.Drawing.RectF(((float)(1065D)), ((float)(650D)), ((float)(12D)), ((float)(12D)));
			this.pLeg2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.pLeg2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pLeg2.Name = "pLeg2";
			this.pLeg2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pLeg2t
			// 
			this.pLeg2t.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pLeg2t.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.pLeg2t.Location = new NxtControl.Drawing.PointF(1083D, 649D);
			this.pLeg2t.Name = "pLeg2t";
			this.pLeg2t.Text = "Sem informação (remota sem comunicação)";
			// 
			// xDJ_NER_PCE
			// 
			this.xDJ_NER_PCE.BeginInit();
			this.xDJ_NER_PCE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_NER_PCE.IsOnlyInput = true;
			this.xDJ_NER_PCE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_NER_PCE.Name = "xDJ_NER_PCE";
			this.xDJ_NER_PCE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_NER_PCE.TagName = "DJ_NER_PCE";
			this.xDJ_NER_PCE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_NER_PCE.EndInit();
			// 
			// xDJ_NER_PCM
			// 
			this.xDJ_NER_PCM.BeginInit();
			this.xDJ_NER_PCM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_NER_PCM.IsOnlyInput = true;
			this.xDJ_NER_PCM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_NER_PCM.Name = "xDJ_NER_PCM";
			this.xDJ_NER_PCM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_NER_PCM.TagName = "DJ_NER_PCM";
			this.xDJ_NER_PCM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_NER_PCM.EndInit();
			// 
			// xDJ_MO_300_01
			// 
			this.xDJ_MO_300_01.BeginInit();
			this.xDJ_MO_300_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_MO_300_01.IsOnlyInput = true;
			this.xDJ_MO_300_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_MO_300_01.Name = "xDJ_MO_300_01";
			this.xDJ_MO_300_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_MO_300_01.TagName = "DJ_MO_300_01";
			this.xDJ_MO_300_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_MO_300_01.EndInit();
			// 
			// xDJ_R4005A
			// 
			this.xDJ_R4005A.BeginInit();
			this.xDJ_R4005A.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_R4005A.IsOnlyInput = true;
			this.xDJ_R4005A.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_R4005A.Name = "xDJ_R4005A";
			this.xDJ_R4005A.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_R4005A.TagName = "DJ_R4005A";
			this.xDJ_R4005A.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_R4005A.EndInit();
			// 
			// xDJ_R4005B
			// 
			this.xDJ_R4005B.BeginInit();
			this.xDJ_R4005B.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_R4005B.IsOnlyInput = true;
			this.xDJ_R4005B.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_R4005B.Name = "xDJ_R4005B";
			this.xDJ_R4005B.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_R4005B.TagName = "DJ_R4005B";
			this.xDJ_R4005B.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_R4005B.EndInit();
			// 
			// xDJ_P4901
			// 
			this.xDJ_P4901.BeginInit();
			this.xDJ_P4901.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_P4901.IsOnlyInput = true;
			this.xDJ_P4901.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_P4901.Name = "xDJ_P4901";
			this.xDJ_P4901.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_P4901.TagName = "DJ_P4901";
			this.xDJ_P4901.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_P4901.EndInit();
			// 
			// xDJ_P4902
			// 
			this.xDJ_P4902.BeginInit();
			this.xDJ_P4902.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_P4902.IsOnlyInput = true;
			this.xDJ_P4902.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_P4902.Name = "xDJ_P4902";
			this.xDJ_P4902.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_P4902.TagName = "DJ_P4902";
			this.xDJ_P4902.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_P4902.EndInit();
			// 
			// xDJ_P4903
			// 
			this.xDJ_P4903.BeginInit();
			this.xDJ_P4903.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_P4903.IsOnlyInput = true;
			this.xDJ_P4903.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_P4903.Name = "xDJ_P4903";
			this.xDJ_P4903.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_P4903.TagName = "DJ_P4903";
			this.xDJ_P4903.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_P4903.EndInit();
			// 
			// xDJ_EEEB_PCE
			// 
			this.xDJ_EEEB_PCE.BeginInit();
			this.xDJ_EEEB_PCE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_EEEB_PCE.IsOnlyInput = true;
			this.xDJ_EEEB_PCE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_EEEB_PCE.Name = "xDJ_EEEB_PCE";
			this.xDJ_EEEB_PCE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_EEEB_PCE.TagName = "DJ_EEEB_PCE";
			this.xDJ_EEEB_PCE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_EEEB_PCE.EndInit();
			// 
			// xDJ_EEEB_PCM
			// 
			this.xDJ_EEEB_PCM.BeginInit();
			this.xDJ_EEEB_PCM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_EEEB_PCM.IsOnlyInput = true;
			this.xDJ_EEEB_PCM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_EEEB_PCM.Name = "xDJ_EEEB_PCM";
			this.xDJ_EEEB_PCM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_EEEB_PCM.TagName = "DJ_EEEB_PCM";
			this.xDJ_EEEB_PCM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_EEEB_PCM.EndInit();
			// 
			// xDJ_CO_100_01
			// 
			this.xDJ_CO_100_01.BeginInit();
			this.xDJ_CO_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_CO_100_01.IsOnlyInput = true;
			this.xDJ_CO_100_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_CO_100_01.Name = "xDJ_CO_100_01";
			this.xDJ_CO_100_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_CO_100_01.TagName = "DJ_CO_100_01";
			this.xDJ_CO_100_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_CO_100_01.EndInit();
			// 
			// xDJ_CO_100_02
			// 
			this.xDJ_CO_100_02.BeginInit();
			this.xDJ_CO_100_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_CO_100_02.IsOnlyInput = true;
			this.xDJ_CO_100_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_CO_100_02.Name = "xDJ_CO_100_02";
			this.xDJ_CO_100_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_CO_100_02.TagName = "DJ_CO_100_02";
			this.xDJ_CO_100_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_CO_100_02.EndInit();
			// 
			// xDJ_CO_100_03
			// 
			this.xDJ_CO_100_03.BeginInit();
			this.xDJ_CO_100_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_CO_100_03.IsOnlyInput = true;
			this.xDJ_CO_100_03.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_CO_100_03.Name = "xDJ_CO_100_03";
			this.xDJ_CO_100_03.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_CO_100_03.TagName = "DJ_CO_100_03";
			this.xDJ_CO_100_03.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_CO_100_03.EndInit();
			// 
			// xDJ_CO_100_04
			// 
			this.xDJ_CO_100_04.BeginInit();
			this.xDJ_CO_100_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_CO_100_04.IsOnlyInput = true;
			this.xDJ_CO_100_04.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_CO_100_04.Name = "xDJ_CO_100_04";
			this.xDJ_CO_100_04.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_CO_100_04.TagName = "DJ_CO_100_04";
			this.xDJ_CO_100_04.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_CO_100_04.EndInit();
			// 
			// xDJ_GM_100_01_02
			// 
			this.xDJ_GM_100_01_02.BeginInit();
			this.xDJ_GM_100_01_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_GM_100_01_02.IsOnlyInput = true;
			this.xDJ_GM_100_01_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_GM_100_01_02.Name = "xDJ_GM_100_01_02";
			this.xDJ_GM_100_01_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_GM_100_01_02.TagName = "DJ_GM_100_01_02";
			this.xDJ_GM_100_01_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_GM_100_01_02.EndInit();
			// 
			// xDJ_MO_100_01
			// 
			this.xDJ_MO_100_01.BeginInit();
			this.xDJ_MO_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_MO_100_01.IsOnlyInput = true;
			this.xDJ_MO_100_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_MO_100_01.Name = "xDJ_MO_100_01";
			this.xDJ_MO_100_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_MO_100_01.TagName = "DJ_MO_100_01";
			this.xDJ_MO_100_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_MO_100_01.EndInit();
			// 
			// xDJ_DES_PCE_DESLIGADO
			// 
			this.xDJ_DES_PCE_DESLIGADO.BeginInit();
			this.xDJ_DES_PCE_DESLIGADO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_DES_PCE_DESLIGADO.IsOnlyInput = true;
			this.xDJ_DES_PCE_DESLIGADO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_DES_PCE_DESLIGADO.Name = "xDJ_DES_PCE_DESLIGADO";
			this.xDJ_DES_PCE_DESLIGADO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_DES_PCE_DESLIGADO.TagName = "DJ_DES_PCE_DESLIGADO";
			this.xDJ_DES_PCE_DESLIGADO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_DES_PCE_DESLIGADO.EndInit();
			// 
			// xDJ_DES_PCM_DESLIGADO
			// 
			this.xDJ_DES_PCM_DESLIGADO.BeginInit();
			this.xDJ_DES_PCM_DESLIGADO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_DES_PCM_DESLIGADO.IsOnlyInput = true;
			this.xDJ_DES_PCM_DESLIGADO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_DES_PCM_DESLIGADO.Name = "xDJ_DES_PCM_DESLIGADO";
			this.xDJ_DES_PCM_DESLIGADO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_DES_PCM_DESLIGADO.TagName = "DJ_DES_PCM_DESLIGADO";
			this.xDJ_DES_PCM_DESLIGADO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_DES_PCM_DESLIGADO.EndInit();
			// 
			// xDJ_UV_700_01
			// 
			this.xDJ_UV_700_01.BeginInit();
			this.xDJ_UV_700_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_UV_700_01.IsOnlyInput = true;
			this.xDJ_UV_700_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_UV_700_01.Name = "xDJ_UV_700_01";
			this.xDJ_UV_700_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_UV_700_01.TagName = "DJ_UV_700_01";
			this.xDJ_UV_700_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_UV_700_01.EndInit();
			// 
			// xDJ_UV_700_02
			// 
			this.xDJ_UV_700_02.BeginInit();
			this.xDJ_UV_700_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_UV_700_02.IsOnlyInput = true;
			this.xDJ_UV_700_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_UV_700_02.Name = "xDJ_UV_700_02";
			this.xDJ_UV_700_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_UV_700_02.TagName = "DJ_UV_700_02";
			this.xDJ_UV_700_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_UV_700_02.EndInit();
			// 
			// xDJ_VC_700_01
			// 
			this.xDJ_VC_700_01.BeginInit();
			this.xDJ_VC_700_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_VC_700_01.IsOnlyInput = true;
			this.xDJ_VC_700_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_VC_700_01.Name = "xDJ_VC_700_01";
			this.xDJ_VC_700_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_VC_700_01.TagName = "DJ_VC_700_01";
			this.xDJ_VC_700_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_VC_700_01.EndInit();
			// 
			// xDJ_MO_700_01
			// 
			this.xDJ_MO_700_01.BeginInit();
			this.xDJ_MO_700_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDJ_MO_700_01.IsOnlyInput = true;
			this.xDJ_MO_700_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDJ_MO_700_01.Name = "xDJ_MO_700_01";
			this.xDJ_MO_700_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDJ_MO_700_01.TagName = "DJ_MO_700_01";
			this.xDJ_MO_700_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xDJ_MO_700_01.EndInit();
			// 
			// xFALHA_REMOTA_NER
			// 
			this.xFALHA_REMOTA_NER.BeginInit();
			this.xFALHA_REMOTA_NER.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFALHA_REMOTA_NER.IsOnlyInput = true;
			this.xFALHA_REMOTA_NER.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFALHA_REMOTA_NER.Name = "xFALHA_REMOTA_NER";
			this.xFALHA_REMOTA_NER.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFALHA_REMOTA_NER.TagName = "FALHA_REMOTA_NER";
			this.xFALHA_REMOTA_NER.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xFALHA_REMOTA_NER.EndInit();
			// 
			// xFALHA_REMOTA_EEEB
			// 
			this.xFALHA_REMOTA_EEEB.BeginInit();
			this.xFALHA_REMOTA_EEEB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFALHA_REMOTA_EEEB.IsOnlyInput = true;
			this.xFALHA_REMOTA_EEEB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFALHA_REMOTA_EEEB.Name = "xFALHA_REMOTA_EEEB";
			this.xFALHA_REMOTA_EEEB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFALHA_REMOTA_EEEB.TagName = "FALHA_REMOTA_EEEB";
			this.xFALHA_REMOTA_EEEB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xFALHA_REMOTA_EEEB.EndInit();
			// 
			// xFALHA_REMOTA_DES
			// 
			this.xFALHA_REMOTA_DES.BeginInit();
			this.xFALHA_REMOTA_DES.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFALHA_REMOTA_DES.IsOnlyInput = true;
			this.xFALHA_REMOTA_DES.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFALHA_REMOTA_DES.Name = "xFALHA_REMOTA_DES";
			this.xFALHA_REMOTA_DES.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFALHA_REMOTA_DES.TagName = "FALHA_REMOTA_DES";
			this.xFALHA_REMOTA_DES.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DjChanged);
			this.xFALHA_REMOTA_DES.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.tRede,
			this.trafoA,
			this.trafoB,
			this.tTrafo,
			this.lRedeTopo,
			this.lTrafoQ1,
			this.lTrafoQ2,
			this.lTrafoMeio,
			this.lTrafoMeio2,
			this.caixaQTAM1,
			this.tQTAM1,
			this.symG2,
			this.lGQTAM1,
			this.lQ2QTAM1,
			this.lQ1QTAM1,
			this.bQ2QTAM1,
			this.tQ2QTAM1,
			this.bQ1QTAM1,
			this.tQ1QTAM1,
			this.noQTAM1,
			this.tFonteQTAM1,
			this.caixaQTAM2,
			this.tQTAM2,
			this.symG1,
			this.lQ1QTAM2,
			this.lQ2QTAM2,
			this.lGQTAM2,
			this.bQ2QTAM2,
			this.tQ2QTAM2,
			this.bQ1QTAM2,
			this.tQ1QTAM2,
			this.noQTAM2,
			this.tFonteQTAM2,
			this.lSai1Q1,
			this.b1Q1,
			this.abrir1Q1,
			this.lEnt1Q1,
			this.tNome1Q1,
			this.tEst1Q1,
			this.tSt1Q1,
			this.lSai1Q2,
			this.b1Q2,
			this.abrir1Q2,
			this.lEnt1Q2,
			this.tNome1Q2,
			this.tEst1Q2,
			this.tSt1Q2,
			this.barraA,
			this.barraB,
			this.tBarraA,
			this.tBarraB,
			this.lAcopA,
			this.lAcopA2,
			this.b1Q0,
			this.abrir1Q0,
			this.lAcopB2,
			this.lAcopB,
			this.tNome1Q0,
			this.tEst1Q0,
			this.tSt1Q0,
			this.lARES_A1,
			this.bRES_A1,
			this.l2ARES_A1,
			this.tRES_A1,
			this.lARES_A2,
			this.bRES_A2,
			this.l2ARES_A2,
			this.tRES_A2,
			this.lAPCM_EEE_BRUTO,
			this.bPCM_EEE_BRUTO,
			this.l2APCM_EEE_BRUTO,
			this.tPCM_EEE_BRUTO,
			this.lAPCM_DESINFECCAO,
			this.bPCM_DESINFECCAO,
			this.l2APCM_DESINFECCAO,
			this.tPCM_DESINFECCAO,
			this.lAQGBT_220V,
			this.bQGBT_220V,
			this.l2AQGBT_220V,
			this.tQGBT_220V,
			this.lAUCT_200_01,
			this.bUCT_200_01,
			this.l2AUCT_200_01,
			this.tUCT_200_01,
			this.lACOMP_500_02,
			this.bCOMP_500_02,
			this.l2ACOMP_500_02,
			this.tCOMP_500_02,
			this.lAV4603,
			this.bV4603,
			this.l2AV4603,
			this.tV4603,
			this.lAV4604,
			this.bV4604,
			this.l2AV4604,
			this.tV4604,
			this.lABANCO_CAPACITORES,
			this.bBANCO_CAPACITORES,
			this.l2ABANCO_CAPACITORES,
			this.tBANCO_CAPACITORES,
			this.lBPCE_SUBESTACAO,
			this.bPCE_SUBESTACAO,
			this.l2BPCE_SUBESTACAO,
			this.tPCE_SUBESTACAO,
			this.lBCOMP_500_01,
			this.bCOMP_500_01,
			this.l2BCOMP_500_01,
			this.tCOMP_500_01,
			this.lBUCT_200_02,
			this.bUCT_200_02,
			this.l2BUCT_200_02,
			this.tUCT_200_02,
			this.lBUCT_200_03,
			this.bUCT_200_03,
			this.l2BUCT_200_03,
			this.tUCT_200_03,
			this.lBPCM_NEREDA,
			this.bPCM_NEREDA,
			this.l2BPCM_NEREDA,
			this.tPCM_NEREDA,
			this.lBPCM_LODO,
			this.bPCM_LODO,
			this.l2BPCM_LODO,
			this.tPCM_LODO,
			this.lBCAP2,
			this.bCAP2,
			this.l2BCAP2,
			this.tCAP2,
			this.lBPCM_AGUA_REUSO,
			this.bPCM_AGUA_REUSO,
			this.l2BPCM_AGUA_REUSO,
			this.tPCM_AGUA_REUSO,
			this.lBMO_500_01,
			this.bMO_500_01,
			this.l2BMO_500_01,
			this.tMO_500_01,
			this.lBV4601,
			this.bV4601,
			this.l2BV4601,
			this.tV4601,
			this.lBV4602,
			this.bV4602,
			this.l2BV4602,
			this.tV4602,
			this.lBRES_B1,
			this.bRES_B1,
			this.l2BRES_B1,
			this.tRES_B1,
			this.lBRES_B2,
			this.bRES_B2,
			this.l2BRES_B2,
			this.tRES_B2,
			this.lBRES_B3,
			this.bRES_B3,
			this.l2BRES_B3,
			this.tRES_B3,
			this.l220a,
			this.t220a,
			this.t220b,
			this.tTr220,
			this.l220b,
			this.bQGBT_220V_ENTRADA,
			this.tQGBT_220V_ENTRADA,
			this.l220c,
			this.barra220,
			this.tBarra220,
			this.lCQL_ADM,
			this.bQL_ADM,
			this.l2CQL_ADM,
			this.tQL_ADM,
			this.lCQL_PORTARIA,
			this.bQL_PORTARIA,
			this.l2CQL_PORTARIA,
			this.tQL_PORTARIA,
			this.lCQLSL,
			this.bQLSL,
			this.l2CQLSL,
			this.tQLSL,
			this.lCQL_ILUMINACAO,
			this.bQL_ILUMINACAO,
			this.l2CQL_ILUMINACAO,
			this.tQL_ILUMINACAO,
			this.lCPCE_SOPRADORES,
			this.bPCE_SOPRADORES,
			this.l2CPCE_SOPRADORES,
			this.tPCE_SOPRADORES,
			this.lCQL_LODO,
			this.bQL_LODO,
			this.l2CQL_LODO,
			this.tQL_LODO,
			this.lCRES_C1,
			this.bRES_C1,
			this.l2CRES_C1,
			this.tRES_C1,
			this.lCRES_C2,
			this.bRES_C2,
			this.l2CRES_C2,
			this.tRES_C2,
			this.lCRES_C3,
			this.bRES_C3,
			this.l2CRES_C3,
			this.tRES_C3,
			this.lCRES_C4,
			this.bRES_C4,
			this.l2CRES_C4,
			this.tRES_C4,
			this.lCRES_C5,
			this.bRES_C5,
			this.l2CRES_C5,
			this.tRES_C5,
			this.lCRES_C6,
			this.bRES_C6,
			this.l2CRES_C6,
			this.tRES_C6,
			this.painel,
			this.tPlanta,
			this.tRemota,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.btnCargas,
			this.btnComandos,
			this.btnReset,
			this.xDJ_RES_A1,
			this.xDJ_RES_A2,
			this.xDJ_PCM_EEE_BRUTO,
			this.xDJ_PCM_DESINFECCAO,
			this.xDJ_QGBT_220V,
			this.xDJ_UCT_200_01,
			this.xDJ_COMP_500_02,
			this.xDJ_V4603,
			this.xDJ_V4604,
			this.xDJ_BANCO_CAPACITORES,
			this.xDJ_PCE_SUBESTACAO,
			this.xDJ_COMP_500_01,
			this.xDJ_UCT_200_02,
			this.xDJ_UCT_200_03,
			this.xDJ_PCM_NEREDA,
			this.xDJ_PCM_LODO,
			this.xDJ_CAP2,
			this.xDJ_PCM_AGUA_REUSO,
			this.xDJ_MO_500_01,
			this.xDJ_V4601,
			this.xDJ_V4602,
			this.xDJ_RES_B1,
			this.xDJ_RES_B2,
			this.xDJ_RES_B3,
			this.xDJ_QGBT_220V_ENTRADA,
			this.xDJ_QL_ADM,
			this.xDJ_QL_PORTARIA,
			this.xDJ_QLSL,
			this.xDJ_QL_ILUMINACAO,
			this.xDJ_PCE_SOPRADORES,
			this.xDJ_QL_LODO,
			this.xDJ_RES_C1,
			this.xDJ_RES_C2,
			this.xDJ_RES_C3,
			this.xDJ_RES_C4,
			this.xDJ_RES_C5,
			this.xDJ_RES_C6,
			this.xMPL_1Q1,
			this.xMPR_1Q1,
			this.xMPP_1Q1,
			this.xMPC_1Q1,
			this.xMPSF_1Q1,
			this.xMPL_1Q0,
			this.xMPR_1Q0,
			this.xMPP_1Q0,
			this.xMPC_1Q0,
			this.xMPSF_1Q0,
			this.xMPL_1Q2,
			this.xMPR_1Q2,
			this.xMPP_1Q2,
			this.xMPC_1Q2,
			this.xMPSF_1Q2,
			this.xEST_1Q1,
			this.xEST_1Q0,
			this.xEST_1Q2,
			this.xFA,
			this.xFB,
			this.xPlanta,
			this.xRemota,
			this.xQTAM1_GERADOR,
			this.xQTAM1_REDE,
			this.xQTAM2_GERADOR,
			this.xQTAM2_REDE,
			this.xAF1q1,
			this.xAF1q0,
			this.xAF1q2,
			this.xAD1q1,
			this.xAD1q0,
			this.xAD1q2,
			this.xAC1q1,
			this.xAC1q0,
			this.xAC1q2,
			this.xEF1q1,
			this.xEF1q0,
			this.xEF1q2,
			this.xED1q1,
			this.xED1q0,
			this.xED1q2,
			this.xEC1q1,
			this.xEC1q0,
			this.xEC1q2,
			this.pNER,
			this.pNERt,
			this.pNERc,
			this.pNERbar,
			this.lpNER_PCE,
			this.bpNER_PCE,
			this.tpNER_PCE,
			this.lpNER_PCM,
			this.bpNER_PCM,
			this.tpNER_PCM,
			this.lpMO_300_01,
			this.bpMO_300_01,
			this.tpMO_300_01,
			this.lpR4005A,
			this.bpR4005A,
			this.tpR4005A,
			this.lpR4005B,
			this.bpR4005B,
			this.tpR4005B,
			this.lpP4901,
			this.bpP4901,
			this.tpP4901,
			this.lpP4902,
			this.bpP4902,
			this.tpP4902,
			this.lpP4903,
			this.bpP4903,
			this.tpP4903,
			this.pDES,
			this.pDESt,
			this.pDESc,
			this.pDESbar,
			this.lpDES_PCE,
			this.bpDES_PCE,
			this.tpDES_PCE,
			this.lpDES_PCM,
			this.bpDES_PCM,
			this.tpDES_PCM,
			this.lpUV_700_01,
			this.bpUV_700_01,
			this.tpUV_700_01,
			this.lpUV_700_02,
			this.bpUV_700_02,
			this.tpUV_700_02,
			this.lpVC_700_01,
			this.bpVC_700_01,
			this.tpVC_700_01,
			this.lpMO_700_01,
			this.bpMO_700_01,
			this.tpMO_700_01,
			this.pEEEB,
			this.pEEEBt,
			this.pEEEBc,
			this.pEEEBbar,
			this.lpEEEB_PCE,
			this.bpEEEB_PCE,
			this.tpEEEB_PCE,
			this.lpEEEB_PCM,
			this.bpEEEB_PCM,
			this.tpEEEB_PCM,
			this.lpCO_100_01,
			this.bpCO_100_01,
			this.tpCO_100_01,
			this.lpCO_100_02,
			this.bpCO_100_02,
			this.tpCO_100_02,
			this.lpCO_100_03,
			this.bpCO_100_03,
			this.tpCO_100_03,
			this.lpCO_100_04,
			this.bpCO_100_04,
			this.tpCO_100_04,
			this.lpGM_100_01_02,
			this.bpGM_100_01_02,
			this.tpGM_100_01_02,
			this.lpMO_100_01,
			this.bpMO_100_01,
			this.tpMO_100_01,
			this.pLeg,
			this.pLegT,
			this.pLeg0,
			this.pLeg0t,
			this.pLeg1,
			this.pLeg1t,
			this.pLeg2,
			this.pLeg2t,
			this.xDJ_NER_PCE,
			this.xDJ_NER_PCM,
			this.xDJ_MO_300_01,
			this.xDJ_R4005A,
			this.xDJ_R4005B,
			this.xDJ_P4901,
			this.xDJ_P4902,
			this.xDJ_P4903,
			this.xDJ_EEEB_PCE,
			this.xDJ_EEEB_PCM,
			this.xDJ_CO_100_01,
			this.xDJ_CO_100_02,
			this.xDJ_CO_100_03,
			this.xDJ_CO_100_04,
			this.xDJ_GM_100_01_02,
			this.xDJ_MO_100_01,
			this.xDJ_DES_PCE_DESLIGADO,
			this.xDJ_DES_PCM_DESLIGADO,
			this.xDJ_UV_700_01,
			this.xDJ_UV_700_02,
			this.xDJ_VC_700_01,
			this.xDJ_MO_700_01,
			this.xFALHA_REMOTA_NER,
			this.xFALHA_REMOTA_EEEB,
			this.xFALHA_REMOTA_DES});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.FreeText tRede;
		private NxtControl.GuiFramework.Ellipse trafoA;
		private NxtControl.GuiFramework.Ellipse trafoB;
		private NxtControl.GuiFramework.FreeText tTrafo;
		private NxtControl.GuiFramework.Line lRedeTopo;
		private NxtControl.GuiFramework.Line lTrafoQ1;
		private NxtControl.GuiFramework.Line lTrafoQ2;
		private NxtControl.GuiFramework.Line lTrafoMeio;
		private NxtControl.GuiFramework.Line lTrafoMeio2;
		private NxtControl.GuiFramework.Rectangle caixaQTAM1;
		private NxtControl.GuiFramework.FreeText tQTAM1;
		private Hidryco.HidrycoLib.Symbols.Gerador_Generico.sDefault symG2;
		private NxtControl.GuiFramework.Line lGQTAM1;
		private NxtControl.GuiFramework.Line lQ2QTAM1;
		private NxtControl.GuiFramework.Line lQ1QTAM1;
		private NxtControl.GuiFramework.Rectangle bQ2QTAM1;
		private NxtControl.GuiFramework.FreeText tQ2QTAM1;
		private NxtControl.GuiFramework.Rectangle bQ1QTAM1;
		private NxtControl.GuiFramework.FreeText tQ1QTAM1;
		private NxtControl.GuiFramework.Rectangle noQTAM1;
		private NxtControl.GuiFramework.FreeText tFonteQTAM1;
		private NxtControl.GuiFramework.Rectangle caixaQTAM2;
		private NxtControl.GuiFramework.FreeText tQTAM2;
		private Hidryco.HidrycoLib.Symbols.Gerador_Generico.sDefault symG1;
		private NxtControl.GuiFramework.Line lQ1QTAM2;
		private NxtControl.GuiFramework.Line lQ2QTAM2;
		private NxtControl.GuiFramework.Line lGQTAM2;
		private NxtControl.GuiFramework.Rectangle bQ2QTAM2;
		private NxtControl.GuiFramework.FreeText tQ2QTAM2;
		private NxtControl.GuiFramework.Rectangle bQ1QTAM2;
		private NxtControl.GuiFramework.FreeText tQ1QTAM2;
		private NxtControl.GuiFramework.Rectangle noQTAM2;
		private NxtControl.GuiFramework.FreeText tFonteQTAM2;
		private NxtControl.GuiFramework.Line lSai1Q1;
		private NxtControl.GuiFramework.Rectangle b1Q1;
		private NxtControl.GuiFramework.DrawnButton abrir1Q1;
		private NxtControl.GuiFramework.Line lEnt1Q1;
		private NxtControl.GuiFramework.FreeText tNome1Q1;
		private NxtControl.GuiFramework.FreeText tEst1Q1;
		private NxtControl.GuiFramework.FreeText tSt1Q1;
		private NxtControl.GuiFramework.Line lSai1Q2;
		private NxtControl.GuiFramework.Rectangle b1Q2;
		private NxtControl.GuiFramework.DrawnButton abrir1Q2;
		private NxtControl.GuiFramework.Line lEnt1Q2;
		private NxtControl.GuiFramework.FreeText tNome1Q2;
		private NxtControl.GuiFramework.FreeText tEst1Q2;
		private NxtControl.GuiFramework.FreeText tSt1Q2;
		private NxtControl.GuiFramework.Rectangle barraA;
		private NxtControl.GuiFramework.Rectangle barraB;
		private NxtControl.GuiFramework.FreeText tBarraA;
		private NxtControl.GuiFramework.FreeText tBarraB;
		private NxtControl.GuiFramework.Line lAcopA;
		private NxtControl.GuiFramework.Line lAcopA2;
		private NxtControl.GuiFramework.Rectangle b1Q0;
		private NxtControl.GuiFramework.DrawnButton abrir1Q0;
		private NxtControl.GuiFramework.Line lAcopB2;
		private NxtControl.GuiFramework.Line lAcopB;
		private NxtControl.GuiFramework.FreeText tNome1Q0;
		private NxtControl.GuiFramework.FreeText tEst1Q0;
		private NxtControl.GuiFramework.FreeText tSt1Q0;
		private NxtControl.GuiFramework.Line lARES_A1;
		private NxtControl.GuiFramework.Rectangle bRES_A1;
		private NxtControl.GuiFramework.Line l2ARES_A1;
		private NxtControl.GuiFramework.FreeText tRES_A1;
		private NxtControl.GuiFramework.Line lARES_A2;
		private NxtControl.GuiFramework.Rectangle bRES_A2;
		private NxtControl.GuiFramework.Line l2ARES_A2;
		private NxtControl.GuiFramework.FreeText tRES_A2;
		private NxtControl.GuiFramework.Line lAPCM_EEE_BRUTO;
		private NxtControl.GuiFramework.Rectangle bPCM_EEE_BRUTO;
		private NxtControl.GuiFramework.Line l2APCM_EEE_BRUTO;
		private NxtControl.GuiFramework.FreeText tPCM_EEE_BRUTO;
		private NxtControl.GuiFramework.Line lAPCM_DESINFECCAO;
		private NxtControl.GuiFramework.Rectangle bPCM_DESINFECCAO;
		private NxtControl.GuiFramework.Line l2APCM_DESINFECCAO;
		private NxtControl.GuiFramework.FreeText tPCM_DESINFECCAO;
		private NxtControl.GuiFramework.Line lAQGBT_220V;
		private NxtControl.GuiFramework.Rectangle bQGBT_220V;
		private NxtControl.GuiFramework.Line l2AQGBT_220V;
		private NxtControl.GuiFramework.FreeText tQGBT_220V;
		private NxtControl.GuiFramework.Line lAUCT_200_01;
		private NxtControl.GuiFramework.Rectangle bUCT_200_01;
		private NxtControl.GuiFramework.Line l2AUCT_200_01;
		private NxtControl.GuiFramework.FreeText tUCT_200_01;
		private NxtControl.GuiFramework.Line lACOMP_500_02;
		private NxtControl.GuiFramework.Rectangle bCOMP_500_02;
		private NxtControl.GuiFramework.Line l2ACOMP_500_02;
		private NxtControl.GuiFramework.FreeText tCOMP_500_02;
		private NxtControl.GuiFramework.Line lAV4603;
		private NxtControl.GuiFramework.Rectangle bV4603;
		private NxtControl.GuiFramework.Line l2AV4603;
		private NxtControl.GuiFramework.FreeText tV4603;
		private NxtControl.GuiFramework.Line lAV4604;
		private NxtControl.GuiFramework.Rectangle bV4604;
		private NxtControl.GuiFramework.Line l2AV4604;
		private NxtControl.GuiFramework.FreeText tV4604;
		private NxtControl.GuiFramework.Line lABANCO_CAPACITORES;
		private NxtControl.GuiFramework.Rectangle bBANCO_CAPACITORES;
		private NxtControl.GuiFramework.Line l2ABANCO_CAPACITORES;
		private NxtControl.GuiFramework.FreeText tBANCO_CAPACITORES;
		private NxtControl.GuiFramework.Line lBPCE_SUBESTACAO;
		private NxtControl.GuiFramework.Rectangle bPCE_SUBESTACAO;
		private NxtControl.GuiFramework.Line l2BPCE_SUBESTACAO;
		private NxtControl.GuiFramework.FreeText tPCE_SUBESTACAO;
		private NxtControl.GuiFramework.Line lBCOMP_500_01;
		private NxtControl.GuiFramework.Rectangle bCOMP_500_01;
		private NxtControl.GuiFramework.Line l2BCOMP_500_01;
		private NxtControl.GuiFramework.FreeText tCOMP_500_01;
		private NxtControl.GuiFramework.Line lBUCT_200_02;
		private NxtControl.GuiFramework.Rectangle bUCT_200_02;
		private NxtControl.GuiFramework.Line l2BUCT_200_02;
		private NxtControl.GuiFramework.FreeText tUCT_200_02;
		private NxtControl.GuiFramework.Line lBUCT_200_03;
		private NxtControl.GuiFramework.Rectangle bUCT_200_03;
		private NxtControl.GuiFramework.Line l2BUCT_200_03;
		private NxtControl.GuiFramework.FreeText tUCT_200_03;
		private NxtControl.GuiFramework.Line lBPCM_NEREDA;
		private NxtControl.GuiFramework.Rectangle bPCM_NEREDA;
		private NxtControl.GuiFramework.Line l2BPCM_NEREDA;
		private NxtControl.GuiFramework.FreeText tPCM_NEREDA;
		private NxtControl.GuiFramework.Line lBPCM_LODO;
		private NxtControl.GuiFramework.Rectangle bPCM_LODO;
		private NxtControl.GuiFramework.Line l2BPCM_LODO;
		private NxtControl.GuiFramework.FreeText tPCM_LODO;
		private NxtControl.GuiFramework.Line lBCAP2;
		private NxtControl.GuiFramework.Rectangle bCAP2;
		private NxtControl.GuiFramework.Line l2BCAP2;
		private NxtControl.GuiFramework.FreeText tCAP2;
		private NxtControl.GuiFramework.Line lBPCM_AGUA_REUSO;
		private NxtControl.GuiFramework.Rectangle bPCM_AGUA_REUSO;
		private NxtControl.GuiFramework.Line l2BPCM_AGUA_REUSO;
		private NxtControl.GuiFramework.FreeText tPCM_AGUA_REUSO;
		private NxtControl.GuiFramework.Line lBMO_500_01;
		private NxtControl.GuiFramework.Rectangle bMO_500_01;
		private NxtControl.GuiFramework.Line l2BMO_500_01;
		private NxtControl.GuiFramework.FreeText tMO_500_01;
		private NxtControl.GuiFramework.Line lBV4601;
		private NxtControl.GuiFramework.Rectangle bV4601;
		private NxtControl.GuiFramework.Line l2BV4601;
		private NxtControl.GuiFramework.FreeText tV4601;
		private NxtControl.GuiFramework.Line lBV4602;
		private NxtControl.GuiFramework.Rectangle bV4602;
		private NxtControl.GuiFramework.Line l2BV4602;
		private NxtControl.GuiFramework.FreeText tV4602;
		private NxtControl.GuiFramework.Line lBRES_B1;
		private NxtControl.GuiFramework.Rectangle bRES_B1;
		private NxtControl.GuiFramework.Line l2BRES_B1;
		private NxtControl.GuiFramework.FreeText tRES_B1;
		private NxtControl.GuiFramework.Line lBRES_B2;
		private NxtControl.GuiFramework.Rectangle bRES_B2;
		private NxtControl.GuiFramework.Line l2BRES_B2;
		private NxtControl.GuiFramework.FreeText tRES_B2;
		private NxtControl.GuiFramework.Line lBRES_B3;
		private NxtControl.GuiFramework.Rectangle bRES_B3;
		private NxtControl.GuiFramework.Line l2BRES_B3;
		private NxtControl.GuiFramework.FreeText tRES_B3;
		private NxtControl.GuiFramework.Line l220a;
		private NxtControl.GuiFramework.Ellipse t220a;
		private NxtControl.GuiFramework.Ellipse t220b;
		private NxtControl.GuiFramework.FreeText tTr220;
		private NxtControl.GuiFramework.Line l220b;
		private NxtControl.GuiFramework.Rectangle bQGBT_220V_ENTRADA;
		private NxtControl.GuiFramework.FreeText tQGBT_220V_ENTRADA;
		private NxtControl.GuiFramework.Line l220c;
		private NxtControl.GuiFramework.Rectangle barra220;
		private NxtControl.GuiFramework.FreeText tBarra220;
		private NxtControl.GuiFramework.Line lCQL_ADM;
		private NxtControl.GuiFramework.Rectangle bQL_ADM;
		private NxtControl.GuiFramework.Line l2CQL_ADM;
		private NxtControl.GuiFramework.FreeText tQL_ADM;
		private NxtControl.GuiFramework.Line lCQL_PORTARIA;
		private NxtControl.GuiFramework.Rectangle bQL_PORTARIA;
		private NxtControl.GuiFramework.Line l2CQL_PORTARIA;
		private NxtControl.GuiFramework.FreeText tQL_PORTARIA;
		private NxtControl.GuiFramework.Line lCQLSL;
		private NxtControl.GuiFramework.Rectangle bQLSL;
		private NxtControl.GuiFramework.Line l2CQLSL;
		private NxtControl.GuiFramework.FreeText tQLSL;
		private NxtControl.GuiFramework.Line lCQL_ILUMINACAO;
		private NxtControl.GuiFramework.Rectangle bQL_ILUMINACAO;
		private NxtControl.GuiFramework.Line l2CQL_ILUMINACAO;
		private NxtControl.GuiFramework.FreeText tQL_ILUMINACAO;
		private NxtControl.GuiFramework.Line lCPCE_SOPRADORES;
		private NxtControl.GuiFramework.Rectangle bPCE_SOPRADORES;
		private NxtControl.GuiFramework.Line l2CPCE_SOPRADORES;
		private NxtControl.GuiFramework.FreeText tPCE_SOPRADORES;
		private NxtControl.GuiFramework.Line lCQL_LODO;
		private NxtControl.GuiFramework.Rectangle bQL_LODO;
		private NxtControl.GuiFramework.Line l2CQL_LODO;
		private NxtControl.GuiFramework.FreeText tQL_LODO;
		private NxtControl.GuiFramework.Line lCRES_C1;
		private NxtControl.GuiFramework.Rectangle bRES_C1;
		private NxtControl.GuiFramework.Line l2CRES_C1;
		private NxtControl.GuiFramework.FreeText tRES_C1;
		private NxtControl.GuiFramework.Line lCRES_C2;
		private NxtControl.GuiFramework.Rectangle bRES_C2;
		private NxtControl.GuiFramework.Line l2CRES_C2;
		private NxtControl.GuiFramework.FreeText tRES_C2;
		private NxtControl.GuiFramework.Line lCRES_C3;
		private NxtControl.GuiFramework.Rectangle bRES_C3;
		private NxtControl.GuiFramework.Line l2CRES_C3;
		private NxtControl.GuiFramework.FreeText tRES_C3;
		private NxtControl.GuiFramework.Line lCRES_C4;
		private NxtControl.GuiFramework.Rectangle bRES_C4;
		private NxtControl.GuiFramework.Line l2CRES_C4;
		private NxtControl.GuiFramework.FreeText tRES_C4;
		private NxtControl.GuiFramework.Line lCRES_C5;
		private NxtControl.GuiFramework.Rectangle bRES_C5;
		private NxtControl.GuiFramework.Line l2CRES_C5;
		private NxtControl.GuiFramework.FreeText tRES_C5;
		private NxtControl.GuiFramework.Line lCRES_C6;
		private NxtControl.GuiFramework.Rectangle bRES_C6;
		private NxtControl.GuiFramework.Line l2CRES_C6;
		private NxtControl.GuiFramework.FreeText tRES_C6;
		private NxtControl.GuiFramework.Rectangle painel;
		private NxtControl.GuiFramework.FreeText tPlanta;
		private NxtControl.GuiFramework.FreeText tRemota;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.DrawnButton btnCargas;
		private NxtControl.GuiFramework.DrawnButton btnComandos;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_A1;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_A2;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_PCM_EEE_BRUTO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_PCM_DESINFECCAO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_QGBT_220V;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_UCT_200_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_COMP_500_02;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_V4603;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_V4604;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_BANCO_CAPACITORES;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_PCE_SUBESTACAO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_COMP_500_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_UCT_200_02;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_UCT_200_03;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_PCM_NEREDA;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_PCM_LODO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_CAP2;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_PCM_AGUA_REUSO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_MO_500_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_V4601;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_V4602;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_B1;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_B2;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_B3;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_QGBT_220V_ENTRADA;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_QL_ADM;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_QL_PORTARIA;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_QLSL;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_QL_ILUMINACAO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_PCE_SOPRADORES;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_QL_LODO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_C1;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_C2;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_C3;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_C4;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_C5;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_RES_C6;
		private System.HMI.Symbols.Base.Execute<bool> xMPL_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xMPR_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xMPP_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xMPC_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xMPSF_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xMPL_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xMPR_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xMPP_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xMPC_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xMPSF_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xMPL_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xMPR_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xMPP_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xMPC_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xMPSF_1Q2;
		private System.HMI.Symbols.Base.Execute<short> xEST_1Q1;
		private System.HMI.Symbols.Base.Execute<short> xEST_1Q0;
		private System.HMI.Symbols.Base.Execute<short> xEST_1Q2;
		private System.HMI.Symbols.Base.Execute<short> xFA;
		private System.HMI.Symbols.Base.Execute<short> xFB;
		private System.HMI.Symbols.Base.Execute<bool> xPlanta;
		private System.HMI.Symbols.Base.Execute<bool> xRemota;
		private System.HMI.Symbols.Base.Execute<short> xQTAM1_GERADOR;
		private System.HMI.Symbols.Base.Execute<short> xQTAM1_REDE;
		private System.HMI.Symbols.Base.Execute<short> xQTAM2_GERADOR;
		private System.HMI.Symbols.Base.Execute<short> xQTAM2_REDE;
		private System.HMI.Symbols.Base.Execute<bool> xAF1q1;
		private System.HMI.Symbols.Base.Execute<bool> xAF1q0;
		private System.HMI.Symbols.Base.Execute<bool> xAF1q2;
		private System.HMI.Symbols.Base.Execute<bool> xAD1q1;
		private System.HMI.Symbols.Base.Execute<bool> xAD1q0;
		private System.HMI.Symbols.Base.Execute<bool> xAD1q2;
		private System.HMI.Symbols.Base.Execute<bool> xAC1q1;
		private System.HMI.Symbols.Base.Execute<bool> xAC1q0;
		private System.HMI.Symbols.Base.Execute<bool> xAC1q2;
		private System.HMI.Symbols.Base.Execute<byte> xEF1q1;
		private System.HMI.Symbols.Base.Execute<byte> xEF1q0;
		private System.HMI.Symbols.Base.Execute<byte> xEF1q2;
		private System.HMI.Symbols.Base.Execute<byte> xED1q1;
		private System.HMI.Symbols.Base.Execute<byte> xED1q0;
		private System.HMI.Symbols.Base.Execute<byte> xED1q2;
		private System.HMI.Symbols.Base.Execute<byte> xEC1q1;
		private System.HMI.Symbols.Base.Execute<byte> xEC1q0;
		private System.HMI.Symbols.Base.Execute<byte> xEC1q2;
		private NxtControl.GuiFramework.Rectangle pNER;
		private NxtControl.GuiFramework.FreeText pNERt;
		private NxtControl.GuiFramework.FreeText pNERc;
		private NxtControl.GuiFramework.Rectangle pNERbar;
		private NxtControl.GuiFramework.Line lpNER_PCE;
		private NxtControl.GuiFramework.Rectangle bpNER_PCE;
		private NxtControl.GuiFramework.FreeText tpNER_PCE;
		private NxtControl.GuiFramework.Line lpNER_PCM;
		private NxtControl.GuiFramework.Rectangle bpNER_PCM;
		private NxtControl.GuiFramework.FreeText tpNER_PCM;
		private NxtControl.GuiFramework.Line lpMO_300_01;
		private NxtControl.GuiFramework.Rectangle bpMO_300_01;
		private NxtControl.GuiFramework.FreeText tpMO_300_01;
		private NxtControl.GuiFramework.Line lpR4005A;
		private NxtControl.GuiFramework.Rectangle bpR4005A;
		private NxtControl.GuiFramework.FreeText tpR4005A;
		private NxtControl.GuiFramework.Line lpR4005B;
		private NxtControl.GuiFramework.Rectangle bpR4005B;
		private NxtControl.GuiFramework.FreeText tpR4005B;
		private NxtControl.GuiFramework.Line lpP4901;
		private NxtControl.GuiFramework.Rectangle bpP4901;
		private NxtControl.GuiFramework.FreeText tpP4901;
		private NxtControl.GuiFramework.Line lpP4902;
		private NxtControl.GuiFramework.Rectangle bpP4902;
		private NxtControl.GuiFramework.FreeText tpP4902;
		private NxtControl.GuiFramework.Line lpP4903;
		private NxtControl.GuiFramework.Rectangle bpP4903;
		private NxtControl.GuiFramework.FreeText tpP4903;
		private NxtControl.GuiFramework.Rectangle pDES;
		private NxtControl.GuiFramework.FreeText pDESt;
		private NxtControl.GuiFramework.FreeText pDESc;
		private NxtControl.GuiFramework.Rectangle pDESbar;
		private NxtControl.GuiFramework.Line lpDES_PCE;
		private NxtControl.GuiFramework.Rectangle bpDES_PCE;
		private NxtControl.GuiFramework.FreeText tpDES_PCE;
		private NxtControl.GuiFramework.Line lpDES_PCM;
		private NxtControl.GuiFramework.Rectangle bpDES_PCM;
		private NxtControl.GuiFramework.FreeText tpDES_PCM;
		private NxtControl.GuiFramework.Line lpUV_700_01;
		private NxtControl.GuiFramework.Rectangle bpUV_700_01;
		private NxtControl.GuiFramework.FreeText tpUV_700_01;
		private NxtControl.GuiFramework.Line lpUV_700_02;
		private NxtControl.GuiFramework.Rectangle bpUV_700_02;
		private NxtControl.GuiFramework.FreeText tpUV_700_02;
		private NxtControl.GuiFramework.Line lpVC_700_01;
		private NxtControl.GuiFramework.Rectangle bpVC_700_01;
		private NxtControl.GuiFramework.FreeText tpVC_700_01;
		private NxtControl.GuiFramework.Line lpMO_700_01;
		private NxtControl.GuiFramework.Rectangle bpMO_700_01;
		private NxtControl.GuiFramework.FreeText tpMO_700_01;
		private NxtControl.GuiFramework.Rectangle pEEEB;
		private NxtControl.GuiFramework.FreeText pEEEBt;
		private NxtControl.GuiFramework.FreeText pEEEBc;
		private NxtControl.GuiFramework.Rectangle pEEEBbar;
		private NxtControl.GuiFramework.Line lpEEEB_PCE;
		private NxtControl.GuiFramework.Rectangle bpEEEB_PCE;
		private NxtControl.GuiFramework.FreeText tpEEEB_PCE;
		private NxtControl.GuiFramework.Line lpEEEB_PCM;
		private NxtControl.GuiFramework.Rectangle bpEEEB_PCM;
		private NxtControl.GuiFramework.FreeText tpEEEB_PCM;
		private NxtControl.GuiFramework.Line lpCO_100_01;
		private NxtControl.GuiFramework.Rectangle bpCO_100_01;
		private NxtControl.GuiFramework.FreeText tpCO_100_01;
		private NxtControl.GuiFramework.Line lpCO_100_02;
		private NxtControl.GuiFramework.Rectangle bpCO_100_02;
		private NxtControl.GuiFramework.FreeText tpCO_100_02;
		private NxtControl.GuiFramework.Line lpCO_100_03;
		private NxtControl.GuiFramework.Rectangle bpCO_100_03;
		private NxtControl.GuiFramework.FreeText tpCO_100_03;
		private NxtControl.GuiFramework.Line lpCO_100_04;
		private NxtControl.GuiFramework.Rectangle bpCO_100_04;
		private NxtControl.GuiFramework.FreeText tpCO_100_04;
		private NxtControl.GuiFramework.Line lpGM_100_01_02;
		private NxtControl.GuiFramework.Rectangle bpGM_100_01_02;
		private NxtControl.GuiFramework.FreeText tpGM_100_01_02;
		private NxtControl.GuiFramework.Line lpMO_100_01;
		private NxtControl.GuiFramework.Rectangle bpMO_100_01;
		private NxtControl.GuiFramework.FreeText tpMO_100_01;
		private NxtControl.GuiFramework.Rectangle pLeg;
		private NxtControl.GuiFramework.FreeText pLegT;
		private NxtControl.GuiFramework.Rectangle pLeg0;
		private NxtControl.GuiFramework.FreeText pLeg0t;
		private NxtControl.GuiFramework.Rectangle pLeg1;
		private NxtControl.GuiFramework.FreeText pLeg1t;
		private NxtControl.GuiFramework.Rectangle pLeg2;
		private NxtControl.GuiFramework.FreeText pLeg2t;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_NER_PCE;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_NER_PCM;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_MO_300_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_R4005A;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_R4005B;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_P4901;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_P4902;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_P4903;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_EEEB_PCE;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_EEEB_PCM;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_CO_100_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_CO_100_02;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_CO_100_03;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_CO_100_04;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_GM_100_01_02;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_MO_100_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_DES_PCE_DESLIGADO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_DES_PCM_DESLIGADO;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_UV_700_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_UV_700_02;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_VC_700_01;
		private System.HMI.Symbols.Base.Execute<bool> xDJ_MO_700_01;
		private System.HMI.Symbols.Base.Execute<bool> xFALHA_REMOTA_NER;
		private System.HMI.Symbols.Base.Execute<bool> xFALHA_REMOTA_EEEB;
		private System.HMI.Symbols.Base.Execute<bool> xFALHA_REMOTA_DES;
		#endregion
	}
}
