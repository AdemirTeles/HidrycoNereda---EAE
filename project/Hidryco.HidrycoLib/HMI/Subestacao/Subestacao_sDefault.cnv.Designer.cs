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
			this.rF1q1 = new NxtControl.GuiFramework.FreeText();
			this.nF1q1 = new NxtControl.GuiFramework.FreeText();
			this.iF1q1P1 = new NxtControl.GuiFramework.Rectangle();
			this.iF1q1P1n = new NxtControl.GuiFramework.FreeText();
			this.iF1q1P2 = new NxtControl.GuiFramework.Polygon();
			this.iF1q1P2n = new NxtControl.GuiFramework.FreeText();
			this.iF1q1Txt = new NxtControl.GuiFramework.FreeText();
			this.rF1q0 = new NxtControl.GuiFramework.FreeText();
			this.nF1q0 = new NxtControl.GuiFramework.FreeText();
			this.iF1q0P1 = new NxtControl.GuiFramework.Rectangle();
			this.iF1q0P1n = new NxtControl.GuiFramework.FreeText();
			this.iF1q0P2 = new NxtControl.GuiFramework.Polygon();
			this.iF1q0P2n = new NxtControl.GuiFramework.FreeText();
			this.iF1q0Txt = new NxtControl.GuiFramework.FreeText();
			this.rF1q2 = new NxtControl.GuiFramework.FreeText();
			this.nF1q2 = new NxtControl.GuiFramework.FreeText();
			this.iF1q2P1 = new NxtControl.GuiFramework.Rectangle();
			this.iF1q2P1n = new NxtControl.GuiFramework.FreeText();
			this.iF1q2P2 = new NxtControl.GuiFramework.Polygon();
			this.iF1q2P2n = new NxtControl.GuiFramework.FreeText();
			this.iF1q2Txt = new NxtControl.GuiFramework.FreeText();
			this.rD1q1 = new NxtControl.GuiFramework.FreeText();
			this.nD1q1 = new NxtControl.GuiFramework.FreeText();
			this.iD1q1P1 = new NxtControl.GuiFramework.Rectangle();
			this.iD1q1P1n = new NxtControl.GuiFramework.FreeText();
			this.iD1q1P2 = new NxtControl.GuiFramework.Polygon();
			this.iD1q1P2n = new NxtControl.GuiFramework.FreeText();
			this.iD1q1Txt = new NxtControl.GuiFramework.FreeText();
			this.rD1q0 = new NxtControl.GuiFramework.FreeText();
			this.nD1q0 = new NxtControl.GuiFramework.FreeText();
			this.iD1q0P1 = new NxtControl.GuiFramework.Rectangle();
			this.iD1q0P1n = new NxtControl.GuiFramework.FreeText();
			this.iD1q0P2 = new NxtControl.GuiFramework.Polygon();
			this.iD1q0P2n = new NxtControl.GuiFramework.FreeText();
			this.iD1q0Txt = new NxtControl.GuiFramework.FreeText();
			this.rD1q2 = new NxtControl.GuiFramework.FreeText();
			this.nD1q2 = new NxtControl.GuiFramework.FreeText();
			this.iD1q2P1 = new NxtControl.GuiFramework.Rectangle();
			this.iD1q2P1n = new NxtControl.GuiFramework.FreeText();
			this.iD1q2P2 = new NxtControl.GuiFramework.Polygon();
			this.iD1q2P2n = new NxtControl.GuiFramework.FreeText();
			this.iD1q2Txt = new NxtControl.GuiFramework.FreeText();
			this.rC1q1 = new NxtControl.GuiFramework.FreeText();
			this.nC1q1 = new NxtControl.GuiFramework.FreeText();
			this.iC1q1P1 = new NxtControl.GuiFramework.Rectangle();
			this.iC1q1P1n = new NxtControl.GuiFramework.FreeText();
			this.iC1q1P2 = new NxtControl.GuiFramework.Polygon();
			this.iC1q1P2n = new NxtControl.GuiFramework.FreeText();
			this.iC1q1Txt = new NxtControl.GuiFramework.FreeText();
			this.rC1q0 = new NxtControl.GuiFramework.FreeText();
			this.nC1q0 = new NxtControl.GuiFramework.FreeText();
			this.iC1q0P1 = new NxtControl.GuiFramework.Rectangle();
			this.iC1q0P1n = new NxtControl.GuiFramework.FreeText();
			this.iC1q0P2 = new NxtControl.GuiFramework.Polygon();
			this.iC1q0P2n = new NxtControl.GuiFramework.FreeText();
			this.iC1q0Txt = new NxtControl.GuiFramework.FreeText();
			this.rC1q2 = new NxtControl.GuiFramework.FreeText();
			this.nC1q2 = new NxtControl.GuiFramework.FreeText();
			this.iC1q2P1 = new NxtControl.GuiFramework.Rectangle();
			this.iC1q2P1n = new NxtControl.GuiFramework.FreeText();
			this.iC1q2P2 = new NxtControl.GuiFramework.Polygon();
			this.iC1q2P2n = new NxtControl.GuiFramework.FreeText();
			this.iC1q2Txt = new NxtControl.GuiFramework.FreeText();
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
			this.tPCM_EEE_BRUTO.Location = new NxtControl.Drawing.PointF(155.463D, 390D);
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
			this.tPCM_DESINFECCAO.Location = new NxtControl.Drawing.PointF(214.963D, 390D);
			this.tPCM_DESINFECCAO.Name = "tPCM_DESINFECCAO";
			this.tPCM_DESINFECCAO.Text = "PCM\r\nDESINFEC.";
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
			this.tPCM_AGUA_REUSO.Location = new NxtControl.Drawing.PointF(1025.81D, 390D);
			this.tPCM_AGUA_REUSO.Name = "tPCM_AGUA_REUSO";
			this.tPCM_AGUA_REUSO.Text = "PCM ÁGUA\r\nREÚSO";
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
			this.tRES_B1.Location = new NxtControl.Drawing.PointF(1198.05D, 390D);
			this.tRES_B1.Name = "tRES_B1";
			this.tRES_B1.Text = "RESERVA";
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
			this.tRES_B2.Location = new NxtControl.Drawing.PointF(1240.55D, 390D);
			this.tRES_B2.Name = "tRES_B2";
			this.tRES_B2.Text = "RESERVA";
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
			this.tRES_B3.Location = new NxtControl.Drawing.PointF(1283.05D, 390D);
			this.tRES_B3.Name = "tRES_B3";
			this.tRES_B3.Text = "RESERVA";
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
			this.tPCE_SOPRADORES.Location = new NxtControl.Drawing.PointF(238.2D, 614D);
			this.tPCE_SOPRADORES.Name = "tPCE_SOPRADORES";
			this.tPCE_SOPRADORES.Text = "PCE\r\nSOPRADORES";
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
			this.painel.Bounds = new NxtControl.Drawing.RectF(((float)(695D)), ((float)(470D)), ((float)(635D)), ((float)(200D)));
			this.painel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.painel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.painel.Name = "painel";
			this.painel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tPlanta
			// 
			this.tPlanta.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPlanta.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tPlanta.Location = new NxtControl.Drawing.PointF(705D, 478D);
			this.tPlanta.Name = "tPlanta";
			this.tPlanta.Text = "Planta na rede";
			// 
			// tRemota
			// 
			this.tRemota.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRemota.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tRemota.Location = new NxtControl.Drawing.PointF(705D, 500D);
			this.tRemota.Name = "tRemota";
			this.tRemota.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(1025D)), ((float)(478D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(1029D, 479D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(1025D)), ((float)(478D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1025D, 494D),
			new NxtControl.Drawing.PointF(1033D, 478D),
			new NxtControl.Drawing.PointF(1041D, 494D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(1030D, 482D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(1045D, 478D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// rF1q1
			// 
			this.rF1q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rF1q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rF1q1.Location = new NxtControl.Drawing.PointF(705D, 526D);
			this.rF1q1.Name = "rF1q1";
			this.rF1q1.Text = "Falha 1Q1";
			// 
			// nF1q1
			// 
			this.nF1q1.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nF1q1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nF1q1.Location = new NxtControl.Drawing.PointF(837D, 526D);
			this.nF1q1.Name = "nF1q1";
			this.nF1q1.Text = "—";
			// 
			// iF1q1P1
			// 
			this.iF1q1P1.Bounds = new NxtControl.Drawing.RectF(((float)(833D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iF1q1P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iF1q1P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iF1q1P1.Name = "iF1q1P1";
			this.iF1q1P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iF1q1P1.Visible = false;
			// 
			// iF1q1P1n
			// 
			this.iF1q1P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iF1q1P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iF1q1P1n.Location = new NxtControl.Drawing.PointF(837D, 527D);
			this.iF1q1P1n.Name = "iF1q1P1n";
			this.iF1q1P1n.Text = "1";
			this.iF1q1P1n.Visible = false;
			// 
			// iF1q1P2
			// 
			this.iF1q1P2.Bounds = new NxtControl.Drawing.RectF(((float)(833D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iF1q1P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iF1q1P2.Closed = true;
			this.iF1q1P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iF1q1P2.Name = "iF1q1P2";
			this.iF1q1P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iF1q1P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(833D, 542D),
			new NxtControl.Drawing.PointF(841D, 526D),
			new NxtControl.Drawing.PointF(849D, 542D)});
			this.iF1q1P2.Visible = false;
			// 
			// iF1q1P2n
			// 
			this.iF1q1P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iF1q1P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iF1q1P2n.Location = new NxtControl.Drawing.PointF(838D, 530D);
			this.iF1q1P2n.Name = "iF1q1P2n";
			this.iF1q1P2n.Text = "2";
			this.iF1q1P2n.Visible = false;
			// 
			// iF1q1Txt
			// 
			this.iF1q1Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iF1q1Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iF1q1Txt.Location = new NxtControl.Drawing.PointF(853D, 526D);
			this.iF1q1Txt.Name = "iF1q1Txt";
			this.iF1q1Txt.Text = "";
			this.iF1q1Txt.Visible = false;
			// 
			// rF1q0
			// 
			this.rF1q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rF1q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rF1q0.Location = new NxtControl.Drawing.PointF(705D, 550D);
			this.rF1q0.Name = "rF1q0";
			this.rF1q0.Text = "Falha 1Q0";
			// 
			// nF1q0
			// 
			this.nF1q0.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nF1q0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nF1q0.Location = new NxtControl.Drawing.PointF(837D, 550D);
			this.nF1q0.Name = "nF1q0";
			this.nF1q0.Text = "—";
			// 
			// iF1q0P1
			// 
			this.iF1q0P1.Bounds = new NxtControl.Drawing.RectF(((float)(833D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iF1q0P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iF1q0P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iF1q0P1.Name = "iF1q0P1";
			this.iF1q0P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iF1q0P1.Visible = false;
			// 
			// iF1q0P1n
			// 
			this.iF1q0P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iF1q0P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iF1q0P1n.Location = new NxtControl.Drawing.PointF(837D, 551D);
			this.iF1q0P1n.Name = "iF1q0P1n";
			this.iF1q0P1n.Text = "1";
			this.iF1q0P1n.Visible = false;
			// 
			// iF1q0P2
			// 
			this.iF1q0P2.Bounds = new NxtControl.Drawing.RectF(((float)(833D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iF1q0P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iF1q0P2.Closed = true;
			this.iF1q0P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iF1q0P2.Name = "iF1q0P2";
			this.iF1q0P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iF1q0P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(833D, 566D),
			new NxtControl.Drawing.PointF(841D, 550D),
			new NxtControl.Drawing.PointF(849D, 566D)});
			this.iF1q0P2.Visible = false;
			// 
			// iF1q0P2n
			// 
			this.iF1q0P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iF1q0P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iF1q0P2n.Location = new NxtControl.Drawing.PointF(838D, 554D);
			this.iF1q0P2n.Name = "iF1q0P2n";
			this.iF1q0P2n.Text = "2";
			this.iF1q0P2n.Visible = false;
			// 
			// iF1q0Txt
			// 
			this.iF1q0Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iF1q0Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iF1q0Txt.Location = new NxtControl.Drawing.PointF(853D, 550D);
			this.iF1q0Txt.Name = "iF1q0Txt";
			this.iF1q0Txt.Text = "";
			this.iF1q0Txt.Visible = false;
			// 
			// rF1q2
			// 
			this.rF1q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rF1q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rF1q2.Location = new NxtControl.Drawing.PointF(705D, 574D);
			this.rF1q2.Name = "rF1q2";
			this.rF1q2.Text = "Falha 1Q2";
			// 
			// nF1q2
			// 
			this.nF1q2.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nF1q2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nF1q2.Location = new NxtControl.Drawing.PointF(837D, 574D);
			this.nF1q2.Name = "nF1q2";
			this.nF1q2.Text = "—";
			// 
			// iF1q2P1
			// 
			this.iF1q2P1.Bounds = new NxtControl.Drawing.RectF(((float)(833D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iF1q2P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iF1q2P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iF1q2P1.Name = "iF1q2P1";
			this.iF1q2P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iF1q2P1.Visible = false;
			// 
			// iF1q2P1n
			// 
			this.iF1q2P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iF1q2P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iF1q2P1n.Location = new NxtControl.Drawing.PointF(837D, 575D);
			this.iF1q2P1n.Name = "iF1q2P1n";
			this.iF1q2P1n.Text = "1";
			this.iF1q2P1n.Visible = false;
			// 
			// iF1q2P2
			// 
			this.iF1q2P2.Bounds = new NxtControl.Drawing.RectF(((float)(833D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iF1q2P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iF1q2P2.Closed = true;
			this.iF1q2P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iF1q2P2.Name = "iF1q2P2";
			this.iF1q2P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iF1q2P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(833D, 590D),
			new NxtControl.Drawing.PointF(841D, 574D),
			new NxtControl.Drawing.PointF(849D, 590D)});
			this.iF1q2P2.Visible = false;
			// 
			// iF1q2P2n
			// 
			this.iF1q2P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iF1q2P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iF1q2P2n.Location = new NxtControl.Drawing.PointF(838D, 578D);
			this.iF1q2P2n.Name = "iF1q2P2n";
			this.iF1q2P2n.Text = "2";
			this.iF1q2P2n.Visible = false;
			// 
			// iF1q2Txt
			// 
			this.iF1q2Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iF1q2Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iF1q2Txt.Location = new NxtControl.Drawing.PointF(853D, 574D);
			this.iF1q2Txt.Name = "iF1q2Txt";
			this.iF1q2Txt.Text = "";
			this.iF1q2Txt.Visible = false;
			// 
			// rD1q1
			// 
			this.rD1q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rD1q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rD1q1.Location = new NxtControl.Drawing.PointF(913D, 526D);
			this.rD1q1.Name = "rD1q1";
			this.rD1q1.Text = "Indefinido 1Q1";
			// 
			// nD1q1
			// 
			this.nD1q1.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nD1q1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nD1q1.Location = new NxtControl.Drawing.PointF(1045D, 526D);
			this.nD1q1.Name = "nD1q1";
			this.nD1q1.Text = "—";
			// 
			// iD1q1P1
			// 
			this.iD1q1P1.Bounds = new NxtControl.Drawing.RectF(((float)(1041D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iD1q1P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iD1q1P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iD1q1P1.Name = "iD1q1P1";
			this.iD1q1P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iD1q1P1.Visible = false;
			// 
			// iD1q1P1n
			// 
			this.iD1q1P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iD1q1P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iD1q1P1n.Location = new NxtControl.Drawing.PointF(1045D, 527D);
			this.iD1q1P1n.Name = "iD1q1P1n";
			this.iD1q1P1n.Text = "1";
			this.iD1q1P1n.Visible = false;
			// 
			// iD1q1P2
			// 
			this.iD1q1P2.Bounds = new NxtControl.Drawing.RectF(((float)(1041D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iD1q1P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iD1q1P2.Closed = true;
			this.iD1q1P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iD1q1P2.Name = "iD1q1P2";
			this.iD1q1P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iD1q1P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1041D, 542D),
			new NxtControl.Drawing.PointF(1049D, 526D),
			new NxtControl.Drawing.PointF(1057D, 542D)});
			this.iD1q1P2.Visible = false;
			// 
			// iD1q1P2n
			// 
			this.iD1q1P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iD1q1P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iD1q1P2n.Location = new NxtControl.Drawing.PointF(1046D, 530D);
			this.iD1q1P2n.Name = "iD1q1P2n";
			this.iD1q1P2n.Text = "2";
			this.iD1q1P2n.Visible = false;
			// 
			// iD1q1Txt
			// 
			this.iD1q1Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iD1q1Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iD1q1Txt.Location = new NxtControl.Drawing.PointF(1061D, 526D);
			this.iD1q1Txt.Name = "iD1q1Txt";
			this.iD1q1Txt.Text = "";
			this.iD1q1Txt.Visible = false;
			// 
			// rD1q0
			// 
			this.rD1q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rD1q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rD1q0.Location = new NxtControl.Drawing.PointF(913D, 550D);
			this.rD1q0.Name = "rD1q0";
			this.rD1q0.Text = "Indefinido 1Q0";
			// 
			// nD1q0
			// 
			this.nD1q0.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nD1q0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nD1q0.Location = new NxtControl.Drawing.PointF(1045D, 550D);
			this.nD1q0.Name = "nD1q0";
			this.nD1q0.Text = "—";
			// 
			// iD1q0P1
			// 
			this.iD1q0P1.Bounds = new NxtControl.Drawing.RectF(((float)(1041D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iD1q0P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iD1q0P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iD1q0P1.Name = "iD1q0P1";
			this.iD1q0P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iD1q0P1.Visible = false;
			// 
			// iD1q0P1n
			// 
			this.iD1q0P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iD1q0P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iD1q0P1n.Location = new NxtControl.Drawing.PointF(1045D, 551D);
			this.iD1q0P1n.Name = "iD1q0P1n";
			this.iD1q0P1n.Text = "1";
			this.iD1q0P1n.Visible = false;
			// 
			// iD1q0P2
			// 
			this.iD1q0P2.Bounds = new NxtControl.Drawing.RectF(((float)(1041D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iD1q0P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iD1q0P2.Closed = true;
			this.iD1q0P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iD1q0P2.Name = "iD1q0P2";
			this.iD1q0P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iD1q0P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1041D, 566D),
			new NxtControl.Drawing.PointF(1049D, 550D),
			new NxtControl.Drawing.PointF(1057D, 566D)});
			this.iD1q0P2.Visible = false;
			// 
			// iD1q0P2n
			// 
			this.iD1q0P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iD1q0P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iD1q0P2n.Location = new NxtControl.Drawing.PointF(1046D, 554D);
			this.iD1q0P2n.Name = "iD1q0P2n";
			this.iD1q0P2n.Text = "2";
			this.iD1q0P2n.Visible = false;
			// 
			// iD1q0Txt
			// 
			this.iD1q0Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iD1q0Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iD1q0Txt.Location = new NxtControl.Drawing.PointF(1061D, 550D);
			this.iD1q0Txt.Name = "iD1q0Txt";
			this.iD1q0Txt.Text = "";
			this.iD1q0Txt.Visible = false;
			// 
			// rD1q2
			// 
			this.rD1q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rD1q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rD1q2.Location = new NxtControl.Drawing.PointF(913D, 574D);
			this.rD1q2.Name = "rD1q2";
			this.rD1q2.Text = "Indefinido 1Q2";
			// 
			// nD1q2
			// 
			this.nD1q2.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nD1q2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nD1q2.Location = new NxtControl.Drawing.PointF(1045D, 574D);
			this.nD1q2.Name = "nD1q2";
			this.nD1q2.Text = "—";
			// 
			// iD1q2P1
			// 
			this.iD1q2P1.Bounds = new NxtControl.Drawing.RectF(((float)(1041D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iD1q2P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iD1q2P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iD1q2P1.Name = "iD1q2P1";
			this.iD1q2P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iD1q2P1.Visible = false;
			// 
			// iD1q2P1n
			// 
			this.iD1q2P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iD1q2P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iD1q2P1n.Location = new NxtControl.Drawing.PointF(1045D, 575D);
			this.iD1q2P1n.Name = "iD1q2P1n";
			this.iD1q2P1n.Text = "1";
			this.iD1q2P1n.Visible = false;
			// 
			// iD1q2P2
			// 
			this.iD1q2P2.Bounds = new NxtControl.Drawing.RectF(((float)(1041D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iD1q2P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iD1q2P2.Closed = true;
			this.iD1q2P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iD1q2P2.Name = "iD1q2P2";
			this.iD1q2P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iD1q2P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1041D, 590D),
			new NxtControl.Drawing.PointF(1049D, 574D),
			new NxtControl.Drawing.PointF(1057D, 590D)});
			this.iD1q2P2.Visible = false;
			// 
			// iD1q2P2n
			// 
			this.iD1q2P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iD1q2P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iD1q2P2n.Location = new NxtControl.Drawing.PointF(1046D, 578D);
			this.iD1q2P2n.Name = "iD1q2P2n";
			this.iD1q2P2n.Text = "2";
			this.iD1q2P2n.Visible = false;
			// 
			// iD1q2Txt
			// 
			this.iD1q2Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iD1q2Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iD1q2Txt.Location = new NxtControl.Drawing.PointF(1061D, 574D);
			this.iD1q2Txt.Name = "iD1q2Txt";
			this.iD1q2Txt.Text = "";
			this.iD1q2Txt.Visible = false;
			// 
			// rC1q1
			// 
			this.rC1q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rC1q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rC1q1.Location = new NxtControl.Drawing.PointF(1121D, 526D);
			this.rC1q1.Name = "rC1q1";
			this.rC1q1.Text = "Sem resposta 1Q1";
			// 
			// nC1q1
			// 
			this.nC1q1.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nC1q1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nC1q1.Location = new NxtControl.Drawing.PointF(1253D, 526D);
			this.nC1q1.Name = "nC1q1";
			this.nC1q1.Text = "—";
			// 
			// iC1q1P1
			// 
			this.iC1q1P1.Bounds = new NxtControl.Drawing.RectF(((float)(1249D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iC1q1P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iC1q1P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iC1q1P1.Name = "iC1q1P1";
			this.iC1q1P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iC1q1P1.Visible = false;
			// 
			// iC1q1P1n
			// 
			this.iC1q1P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iC1q1P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iC1q1P1n.Location = new NxtControl.Drawing.PointF(1253D, 527D);
			this.iC1q1P1n.Name = "iC1q1P1n";
			this.iC1q1P1n.Text = "1";
			this.iC1q1P1n.Visible = false;
			// 
			// iC1q1P2
			// 
			this.iC1q1P2.Bounds = new NxtControl.Drawing.RectF(((float)(1249D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iC1q1P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iC1q1P2.Closed = true;
			this.iC1q1P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iC1q1P2.Name = "iC1q1P2";
			this.iC1q1P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iC1q1P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1249D, 542D),
			new NxtControl.Drawing.PointF(1257D, 526D),
			new NxtControl.Drawing.PointF(1265D, 542D)});
			this.iC1q1P2.Visible = false;
			// 
			// iC1q1P2n
			// 
			this.iC1q1P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iC1q1P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iC1q1P2n.Location = new NxtControl.Drawing.PointF(1254D, 530D);
			this.iC1q1P2n.Name = "iC1q1P2n";
			this.iC1q1P2n.Text = "2";
			this.iC1q1P2n.Visible = false;
			// 
			// iC1q1Txt
			// 
			this.iC1q1Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iC1q1Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iC1q1Txt.Location = new NxtControl.Drawing.PointF(1269D, 526D);
			this.iC1q1Txt.Name = "iC1q1Txt";
			this.iC1q1Txt.Text = "";
			this.iC1q1Txt.Visible = false;
			// 
			// rC1q0
			// 
			this.rC1q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rC1q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rC1q0.Location = new NxtControl.Drawing.PointF(1121D, 550D);
			this.rC1q0.Name = "rC1q0";
			this.rC1q0.Text = "Sem resposta 1Q0";
			// 
			// nC1q0
			// 
			this.nC1q0.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nC1q0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nC1q0.Location = new NxtControl.Drawing.PointF(1253D, 550D);
			this.nC1q0.Name = "nC1q0";
			this.nC1q0.Text = "—";
			// 
			// iC1q0P1
			// 
			this.iC1q0P1.Bounds = new NxtControl.Drawing.RectF(((float)(1249D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iC1q0P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iC1q0P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iC1q0P1.Name = "iC1q0P1";
			this.iC1q0P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iC1q0P1.Visible = false;
			// 
			// iC1q0P1n
			// 
			this.iC1q0P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iC1q0P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iC1q0P1n.Location = new NxtControl.Drawing.PointF(1253D, 551D);
			this.iC1q0P1n.Name = "iC1q0P1n";
			this.iC1q0P1n.Text = "1";
			this.iC1q0P1n.Visible = false;
			// 
			// iC1q0P2
			// 
			this.iC1q0P2.Bounds = new NxtControl.Drawing.RectF(((float)(1249D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iC1q0P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iC1q0P2.Closed = true;
			this.iC1q0P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iC1q0P2.Name = "iC1q0P2";
			this.iC1q0P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iC1q0P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1249D, 566D),
			new NxtControl.Drawing.PointF(1257D, 550D),
			new NxtControl.Drawing.PointF(1265D, 566D)});
			this.iC1q0P2.Visible = false;
			// 
			// iC1q0P2n
			// 
			this.iC1q0P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iC1q0P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iC1q0P2n.Location = new NxtControl.Drawing.PointF(1254D, 554D);
			this.iC1q0P2n.Name = "iC1q0P2n";
			this.iC1q0P2n.Text = "2";
			this.iC1q0P2n.Visible = false;
			// 
			// iC1q0Txt
			// 
			this.iC1q0Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iC1q0Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iC1q0Txt.Location = new NxtControl.Drawing.PointF(1269D, 550D);
			this.iC1q0Txt.Name = "iC1q0Txt";
			this.iC1q0Txt.Text = "";
			this.iC1q0Txt.Visible = false;
			// 
			// rC1q2
			// 
			this.rC1q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rC1q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rC1q2.Location = new NxtControl.Drawing.PointF(1121D, 574D);
			this.rC1q2.Name = "rC1q2";
			this.rC1q2.Text = "Sem resposta 1Q2";
			// 
			// nC1q2
			// 
			this.nC1q2.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nC1q2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nC1q2.Location = new NxtControl.Drawing.PointF(1253D, 574D);
			this.nC1q2.Name = "nC1q2";
			this.nC1q2.Text = "—";
			// 
			// iC1q2P1
			// 
			this.iC1q2P1.Bounds = new NxtControl.Drawing.RectF(((float)(1249D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iC1q2P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iC1q2P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iC1q2P1.Name = "iC1q2P1";
			this.iC1q2P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iC1q2P1.Visible = false;
			// 
			// iC1q2P1n
			// 
			this.iC1q2P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iC1q2P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iC1q2P1n.Location = new NxtControl.Drawing.PointF(1253D, 575D);
			this.iC1q2P1n.Name = "iC1q2P1n";
			this.iC1q2P1n.Text = "1";
			this.iC1q2P1n.Visible = false;
			// 
			// iC1q2P2
			// 
			this.iC1q2P2.Bounds = new NxtControl.Drawing.RectF(((float)(1249D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iC1q2P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iC1q2P2.Closed = true;
			this.iC1q2P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iC1q2P2.Name = "iC1q2P2";
			this.iC1q2P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iC1q2P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1249D, 590D),
			new NxtControl.Drawing.PointF(1257D, 574D),
			new NxtControl.Drawing.PointF(1265D, 590D)});
			this.iC1q2P2.Visible = false;
			// 
			// iC1q2P2n
			// 
			this.iC1q2P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iC1q2P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iC1q2P2n.Location = new NxtControl.Drawing.PointF(1254D, 578D);
			this.iC1q2P2n.Name = "iC1q2P2n";
			this.iC1q2P2n.Text = "2";
			this.iC1q2P2n.Visible = false;
			// 
			// iC1q2Txt
			// 
			this.iC1q2Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iC1q2Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iC1q2Txt.Location = new NxtControl.Drawing.PointF(1269D, 574D);
			this.iC1q2Txt.Name = "iC1q2Txt";
			this.iC1q2Txt.Text = "";
			this.iC1q2Txt.Visible = false;
			// 
			// btnCargas
			// 
			this.btnCargas.Bounds = new NxtControl.Drawing.RectF(((float)(705D)), ((float)(610D)), ((float)(200D)), ((float)(40D)));
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
			this.btnComandos.Bounds = new NxtControl.Drawing.RectF(((float)(915D)), ((float)(610D)), ((float)(200D)), ((float)(40D)));
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
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(1125D)), ((float)(610D)), ((float)(160D)), ((float)(40D)));
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
			this.rF1q1,
			this.nF1q1,
			this.iF1q1P1,
			this.iF1q1P1n,
			this.iF1q1P2,
			this.iF1q1P2n,
			this.iF1q1Txt,
			this.rF1q0,
			this.nF1q0,
			this.iF1q0P1,
			this.iF1q0P1n,
			this.iF1q0P2,
			this.iF1q0P2n,
			this.iF1q0Txt,
			this.rF1q2,
			this.nF1q2,
			this.iF1q2P1,
			this.iF1q2P1n,
			this.iF1q2P2,
			this.iF1q2P2n,
			this.iF1q2Txt,
			this.rD1q1,
			this.nD1q1,
			this.iD1q1P1,
			this.iD1q1P1n,
			this.iD1q1P2,
			this.iD1q1P2n,
			this.iD1q1Txt,
			this.rD1q0,
			this.nD1q0,
			this.iD1q0P1,
			this.iD1q0P1n,
			this.iD1q0P2,
			this.iD1q0P2n,
			this.iD1q0Txt,
			this.rD1q2,
			this.nD1q2,
			this.iD1q2P1,
			this.iD1q2P1n,
			this.iD1q2P2,
			this.iD1q2P2n,
			this.iD1q2Txt,
			this.rC1q1,
			this.nC1q1,
			this.iC1q1P1,
			this.iC1q1P1n,
			this.iC1q1P2,
			this.iC1q1P2n,
			this.iC1q1Txt,
			this.rC1q0,
			this.nC1q0,
			this.iC1q0P1,
			this.iC1q0P1n,
			this.iC1q0P2,
			this.iC1q0P2n,
			this.iC1q0Txt,
			this.rC1q2,
			this.nC1q2,
			this.iC1q2P1,
			this.iC1q2P1n,
			this.iC1q2P2,
			this.iC1q2P2n,
			this.iC1q2Txt,
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
			this.xEC1q2});

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
		private NxtControl.GuiFramework.FreeText rF1q1;
		private NxtControl.GuiFramework.FreeText nF1q1;
		private NxtControl.GuiFramework.Rectangle iF1q1P1;
		private NxtControl.GuiFramework.FreeText iF1q1P1n;
		private NxtControl.GuiFramework.Polygon iF1q1P2;
		private NxtControl.GuiFramework.FreeText iF1q1P2n;
		private NxtControl.GuiFramework.FreeText iF1q1Txt;
		private NxtControl.GuiFramework.FreeText rF1q0;
		private NxtControl.GuiFramework.FreeText nF1q0;
		private NxtControl.GuiFramework.Rectangle iF1q0P1;
		private NxtControl.GuiFramework.FreeText iF1q0P1n;
		private NxtControl.GuiFramework.Polygon iF1q0P2;
		private NxtControl.GuiFramework.FreeText iF1q0P2n;
		private NxtControl.GuiFramework.FreeText iF1q0Txt;
		private NxtControl.GuiFramework.FreeText rF1q2;
		private NxtControl.GuiFramework.FreeText nF1q2;
		private NxtControl.GuiFramework.Rectangle iF1q2P1;
		private NxtControl.GuiFramework.FreeText iF1q2P1n;
		private NxtControl.GuiFramework.Polygon iF1q2P2;
		private NxtControl.GuiFramework.FreeText iF1q2P2n;
		private NxtControl.GuiFramework.FreeText iF1q2Txt;
		private NxtControl.GuiFramework.FreeText rD1q1;
		private NxtControl.GuiFramework.FreeText nD1q1;
		private NxtControl.GuiFramework.Rectangle iD1q1P1;
		private NxtControl.GuiFramework.FreeText iD1q1P1n;
		private NxtControl.GuiFramework.Polygon iD1q1P2;
		private NxtControl.GuiFramework.FreeText iD1q1P2n;
		private NxtControl.GuiFramework.FreeText iD1q1Txt;
		private NxtControl.GuiFramework.FreeText rD1q0;
		private NxtControl.GuiFramework.FreeText nD1q0;
		private NxtControl.GuiFramework.Rectangle iD1q0P1;
		private NxtControl.GuiFramework.FreeText iD1q0P1n;
		private NxtControl.GuiFramework.Polygon iD1q0P2;
		private NxtControl.GuiFramework.FreeText iD1q0P2n;
		private NxtControl.GuiFramework.FreeText iD1q0Txt;
		private NxtControl.GuiFramework.FreeText rD1q2;
		private NxtControl.GuiFramework.FreeText nD1q2;
		private NxtControl.GuiFramework.Rectangle iD1q2P1;
		private NxtControl.GuiFramework.FreeText iD1q2P1n;
		private NxtControl.GuiFramework.Polygon iD1q2P2;
		private NxtControl.GuiFramework.FreeText iD1q2P2n;
		private NxtControl.GuiFramework.FreeText iD1q2Txt;
		private NxtControl.GuiFramework.FreeText rC1q1;
		private NxtControl.GuiFramework.FreeText nC1q1;
		private NxtControl.GuiFramework.Rectangle iC1q1P1;
		private NxtControl.GuiFramework.FreeText iC1q1P1n;
		private NxtControl.GuiFramework.Polygon iC1q1P2;
		private NxtControl.GuiFramework.FreeText iC1q1P2n;
		private NxtControl.GuiFramework.FreeText iC1q1Txt;
		private NxtControl.GuiFramework.FreeText rC1q0;
		private NxtControl.GuiFramework.FreeText nC1q0;
		private NxtControl.GuiFramework.Rectangle iC1q0P1;
		private NxtControl.GuiFramework.FreeText iC1q0P1n;
		private NxtControl.GuiFramework.Polygon iC1q0P2;
		private NxtControl.GuiFramework.FreeText iC1q0P2n;
		private NxtControl.GuiFramework.FreeText iC1q0Txt;
		private NxtControl.GuiFramework.FreeText rC1q2;
		private NxtControl.GuiFramework.FreeText nC1q2;
		private NxtControl.GuiFramework.Rectangle iC1q2P1;
		private NxtControl.GuiFramework.FreeText iC1q2P1n;
		private NxtControl.GuiFramework.Polygon iC1q2P2;
		private NxtControl.GuiFramework.FreeText iC1q2P2n;
		private NxtControl.GuiFramework.FreeText iC1q2Txt;
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
		#endregion
	}
}
