/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 21/05/2026
 * Tempo: 12:46
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Gerador
{
	/// <summary>
	/// Summary description for fpAlimentados.
	/// </summary>
	partial class fpAlimentados
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.h_QGBT_440V___Sopradores = new NxtControl.GuiFramework.FreeText();
			this.ln_QGBT_440V___Sopradores = new NxtControl.GuiFramework.Line();
			this.tag_QGBT_440V___Sopradores_V4601 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Sopradores_V4601 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Sopradores_V4602 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Sopradores_V4602 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Sopradores_V4603 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Sopradores_V4603 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Sopradores_V4604 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Sopradores_V4604 = new NxtControl.GuiFramework.FreeText();
			this.h_QGBT_440V___Exaustores = new NxtControl.GuiFramework.FreeText();
			this.ln_QGBT_440V___Exaustores = new NxtControl.GuiFramework.Line();
			this.tag_QGBT_440V___Exaustores_500_EX_01 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Exaustores_500_EX_01 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Exaustores_500_EX_02 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Exaustores_500_EX_02 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Exaustores_500_EX_03 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Exaustores_500_EX_03 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Exaustores_500_EX_04 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Exaustores_500_EX_04 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Exaustores_500_EX_05 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Exaustores_500_EX_05 = new NxtControl.GuiFramework.FreeText();
			this.h_QGBT_440V___Compressores = new NxtControl.GuiFramework.FreeText();
			this.ln_QGBT_440V___Compressores = new NxtControl.GuiFramework.Line();
			this.tag_QGBT_440V___Compressores_500_COMP_01 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Compressores_500_COMP_01 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Compressores_500_COMP_02 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Compressores_500_COMP_02 = new NxtControl.GuiFramework.FreeText();
			this.h_QGBT_440V___Tratamento_Preliminar = new NxtControl.GuiFramework.FreeText();
			this.ln_QGBT_440V___Tratamento_Preliminar = new NxtControl.GuiFramework.Line();
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02 = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03 = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03 = new NxtControl.GuiFramework.FreeText();
			this.h_PCM_Nereda = new NxtControl.GuiFramework.FreeText();
			this.ln_PCM_Nereda = new NxtControl.GuiFramework.Line();
			this.tag_PCM_Nereda_P4901 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Nereda_P4901 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_Nereda_P4902 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Nereda_P4902 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_Nereda_P4903 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Nereda_P4903 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_Nereda_R4005A = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Nereda_R4005A = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_Nereda_R4005B = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Nereda_R4005B = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_Nereda_300_MO_01 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Nereda_300_MO_01 = new NxtControl.GuiFramework.FreeText();
			this.h_PCM_EEE_Bruto = new NxtControl.GuiFramework.FreeText();
			this.ln_PCM_EEE_Bruto = new NxtControl.GuiFramework.Line();
			this.tag_PCM_EEE_Bruto_100_BS_01 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_EEE_Bruto_100_BS_01 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_EEE_Bruto_100_BS_02 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_EEE_Bruto_100_BS_02 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_EEE_Bruto_100_BS_03 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_EEE_Bruto_100_BS_03 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_EEE_Bruto_100_GM_01 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_EEE_Bruto_100_GM_01 = new NxtControl.GuiFramework.FreeText();
			this.h_PCM_Desinfeccao = new NxtControl.GuiFramework.FreeText();
			this.ln_PCM_Desinfeccao = new NxtControl.GuiFramework.Line();
			this.tag_PCM_Desinfeccao_700_UV_01 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Desinfeccao_700_UV_01 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_Desinfeccao_700_UV_02 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Desinfeccao_700_UV_02 = new NxtControl.GuiFramework.FreeText();
			this.h_PCM_Agua_Reuso = new NxtControl.GuiFramework.FreeText();
			this.ln_PCM_Agua_Reuso = new NxtControl.GuiFramework.Line();
			this.tag_PCM_Agua_Reuso_800_DO_04 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Agua_Reuso_800_DO_04 = new NxtControl.GuiFramework.FreeText();
			this.tag_PCM_Agua_Reuso_800_DO_05 = new NxtControl.GuiFramework.FreeText();
			this.desc_PCM_Agua_Reuso_800_DO_05 = new NxtControl.GuiFramework.FreeText();
			this.h_QGBT_220V = new NxtControl.GuiFramework.FreeText();
			this.ln_QGBT_220V = new NxtControl.GuiFramework.Line();
			this.tag_QGBT_220V_QL_PORTARIA = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_220V_QL_PORTARIA = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_220V_QL_ADM = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_220V_QL_ADM = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_220V_QL_LODO = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_220V_QL_LODO = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_220V_QLSL = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_220V_QLSL = new NxtControl.GuiFramework.FreeText();
			this.tag_QGBT_220V_QL_ILUMINACAO = new NxtControl.GuiFramework.FreeText();
			this.desc_QGBT_220V_QL_ILUMINACAO = new NxtControl.GuiFramework.FreeText();
			this.swHab_01 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_02 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_03 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_04 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_05 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_06 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_07 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_08 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_09 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_10 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_11 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_12 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_13 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_14 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_15 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_16 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_17 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_18 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_19 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_20 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_21 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_22 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_23 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_24 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_25 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_26 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_27 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_28 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_29 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_30 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_31 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_32 = new System.HMI.Symbols.Base.SwitchButton();
			this.swHab_33 = new System.HMI.Symbols.Base.SwitchButton();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.group3 = new NxtControl.GuiFramework.Group();
			this.group4 = new NxtControl.GuiFramework.Group();
			this.group5 = new NxtControl.GuiFramework.Group();
			this.group6 = new NxtControl.GuiFramework.Group();
			this.group7 = new NxtControl.GuiFramework.Group();
			this.group8 = new NxtControl.GuiFramework.Group();
			this.group9 = new NxtControl.GuiFramework.Group();
			// 
			// h_QGBT_440V___Sopradores
			// 
			this.h_QGBT_440V___Sopradores.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_QGBT_440V___Sopradores.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_QGBT_440V___Sopradores.Location = new NxtControl.Drawing.PointF(8D, 10D);
			this.h_QGBT_440V___Sopradores.Name = "h_QGBT_440V___Sopradores";
			this.h_QGBT_440V___Sopradores.Text = "QGBT 440V - Ner - Sopradores";
			// 
			// ln_QGBT_440V___Sopradores
			// 
			this.ln_QGBT_440V___Sopradores.EndPoint = new NxtControl.Drawing.PointF(370D, 32D);
			this.ln_QGBT_440V___Sopradores.Name = "ln_QGBT_440V___Sopradores";
			this.ln_QGBT_440V___Sopradores.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_QGBT_440V___Sopradores.StartPoint = new NxtControl.Drawing.PointF(0D, 32D);
			// 
			// tag_QGBT_440V___Sopradores_V4601
			// 
			this.tag_QGBT_440V___Sopradores_V4601.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Sopradores_V4601.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Sopradores_V4601.Location = new NxtControl.Drawing.PointF(12D, 40D);
			this.tag_QGBT_440V___Sopradores_V4601.Name = "tag_QGBT_440V___Sopradores_V4601";
			this.tag_QGBT_440V___Sopradores_V4601.Text = "V4601";
			// 
			// desc_QGBT_440V___Sopradores_V4601
			// 
			this.desc_QGBT_440V___Sopradores_V4601.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Sopradores_V4601.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Sopradores_V4601.Location = new NxtControl.Drawing.PointF(155D, 40D);
			this.desc_QGBT_440V___Sopradores_V4601.Name = "desc_QGBT_440V___Sopradores_V4601";
			this.desc_QGBT_440V___Sopradores_V4601.Text = "Soprador 01";
			// 
			// tag_QGBT_440V___Sopradores_V4602
			// 
			this.tag_QGBT_440V___Sopradores_V4602.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Sopradores_V4602.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Sopradores_V4602.Location = new NxtControl.Drawing.PointF(12D, 68D);
			this.tag_QGBT_440V___Sopradores_V4602.Name = "tag_QGBT_440V___Sopradores_V4602";
			this.tag_QGBT_440V___Sopradores_V4602.Text = "V4602";
			// 
			// desc_QGBT_440V___Sopradores_V4602
			// 
			this.desc_QGBT_440V___Sopradores_V4602.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Sopradores_V4602.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Sopradores_V4602.Location = new NxtControl.Drawing.PointF(155D, 68D);
			this.desc_QGBT_440V___Sopradores_V4602.Name = "desc_QGBT_440V___Sopradores_V4602";
			this.desc_QGBT_440V___Sopradores_V4602.Text = "Soprador 02";
			// 
			// tag_QGBT_440V___Sopradores_V4603
			// 
			this.tag_QGBT_440V___Sopradores_V4603.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Sopradores_V4603.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Sopradores_V4603.Location = new NxtControl.Drawing.PointF(12D, 96D);
			this.tag_QGBT_440V___Sopradores_V4603.Name = "tag_QGBT_440V___Sopradores_V4603";
			this.tag_QGBT_440V___Sopradores_V4603.Text = "V4603";
			// 
			// desc_QGBT_440V___Sopradores_V4603
			// 
			this.desc_QGBT_440V___Sopradores_V4603.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Sopradores_V4603.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Sopradores_V4603.Location = new NxtControl.Drawing.PointF(155D, 96D);
			this.desc_QGBT_440V___Sopradores_V4603.Name = "desc_QGBT_440V___Sopradores_V4603";
			this.desc_QGBT_440V___Sopradores_V4603.Text = "Soprador 03";
			// 
			// tag_QGBT_440V___Sopradores_V4604
			// 
			this.tag_QGBT_440V___Sopradores_V4604.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Sopradores_V4604.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Sopradores_V4604.Location = new NxtControl.Drawing.PointF(12D, 124D);
			this.tag_QGBT_440V___Sopradores_V4604.Name = "tag_QGBT_440V___Sopradores_V4604";
			this.tag_QGBT_440V___Sopradores_V4604.Text = "V4604";
			// 
			// desc_QGBT_440V___Sopradores_V4604
			// 
			this.desc_QGBT_440V___Sopradores_V4604.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Sopradores_V4604.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Sopradores_V4604.Location = new NxtControl.Drawing.PointF(155D, 124D);
			this.desc_QGBT_440V___Sopradores_V4604.Name = "desc_QGBT_440V___Sopradores_V4604";
			this.desc_QGBT_440V___Sopradores_V4604.Text = "Soprador 04";
			// 
			// h_QGBT_440V___Exaustores
			// 
			this.h_QGBT_440V___Exaustores.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_QGBT_440V___Exaustores.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_QGBT_440V___Exaustores.Location = new NxtControl.Drawing.PointF(8D, 154D);
			this.h_QGBT_440V___Exaustores.Name = "h_QGBT_440V___Exaustores";
			this.h_QGBT_440V___Exaustores.Text = "QGBT 440V - Ner - Exaustores";
			// 
			// ln_QGBT_440V___Exaustores
			// 
			this.ln_QGBT_440V___Exaustores.EndPoint = new NxtControl.Drawing.PointF(370D, 176D);
			this.ln_QGBT_440V___Exaustores.Name = "ln_QGBT_440V___Exaustores";
			this.ln_QGBT_440V___Exaustores.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_QGBT_440V___Exaustores.StartPoint = new NxtControl.Drawing.PointF(0D, 176D);
			// 
			// tag_QGBT_440V___Exaustores_500_EX_01
			// 
			this.tag_QGBT_440V___Exaustores_500_EX_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Exaustores_500_EX_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Exaustores_500_EX_01.Location = new NxtControl.Drawing.PointF(12D, 184D);
			this.tag_QGBT_440V___Exaustores_500_EX_01.Name = "tag_QGBT_440V___Exaustores_500_EX_01";
			this.tag_QGBT_440V___Exaustores_500_EX_01.Text = "500-EX-01";
			// 
			// desc_QGBT_440V___Exaustores_500_EX_01
			// 
			this.desc_QGBT_440V___Exaustores_500_EX_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Exaustores_500_EX_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Exaustores_500_EX_01.Location = new NxtControl.Drawing.PointF(155D, 184D);
			this.desc_QGBT_440V___Exaustores_500_EX_01.Name = "desc_QGBT_440V___Exaustores_500_EX_01";
			this.desc_QGBT_440V___Exaustores_500_EX_01.Text = "Exaustor 01";
			// 
			// tag_QGBT_440V___Exaustores_500_EX_02
			// 
			this.tag_QGBT_440V___Exaustores_500_EX_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Exaustores_500_EX_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Exaustores_500_EX_02.Location = new NxtControl.Drawing.PointF(12D, 212D);
			this.tag_QGBT_440V___Exaustores_500_EX_02.Name = "tag_QGBT_440V___Exaustores_500_EX_02";
			this.tag_QGBT_440V___Exaustores_500_EX_02.Text = "500-EX-02";
			// 
			// desc_QGBT_440V___Exaustores_500_EX_02
			// 
			this.desc_QGBT_440V___Exaustores_500_EX_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Exaustores_500_EX_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Exaustores_500_EX_02.Location = new NxtControl.Drawing.PointF(155D, 212D);
			this.desc_QGBT_440V___Exaustores_500_EX_02.Name = "desc_QGBT_440V___Exaustores_500_EX_02";
			this.desc_QGBT_440V___Exaustores_500_EX_02.Text = "Exaustor 02";
			// 
			// tag_QGBT_440V___Exaustores_500_EX_03
			// 
			this.tag_QGBT_440V___Exaustores_500_EX_03.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Exaustores_500_EX_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Exaustores_500_EX_03.Location = new NxtControl.Drawing.PointF(12D, 240D);
			this.tag_QGBT_440V___Exaustores_500_EX_03.Name = "tag_QGBT_440V___Exaustores_500_EX_03";
			this.tag_QGBT_440V___Exaustores_500_EX_03.Text = "500-EX-03";
			// 
			// desc_QGBT_440V___Exaustores_500_EX_03
			// 
			this.desc_QGBT_440V___Exaustores_500_EX_03.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Exaustores_500_EX_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Exaustores_500_EX_03.Location = new NxtControl.Drawing.PointF(155D, 240D);
			this.desc_QGBT_440V___Exaustores_500_EX_03.Name = "desc_QGBT_440V___Exaustores_500_EX_03";
			this.desc_QGBT_440V___Exaustores_500_EX_03.Text = "Exaustor 03";
			// 
			// tag_QGBT_440V___Exaustores_500_EX_04
			// 
			this.tag_QGBT_440V___Exaustores_500_EX_04.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Exaustores_500_EX_04.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Exaustores_500_EX_04.Location = new NxtControl.Drawing.PointF(12D, 268D);
			this.tag_QGBT_440V___Exaustores_500_EX_04.Name = "tag_QGBT_440V___Exaustores_500_EX_04";
			this.tag_QGBT_440V___Exaustores_500_EX_04.Text = "500-EX-04";
			// 
			// desc_QGBT_440V___Exaustores_500_EX_04
			// 
			this.desc_QGBT_440V___Exaustores_500_EX_04.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Exaustores_500_EX_04.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Exaustores_500_EX_04.Location = new NxtControl.Drawing.PointF(155D, 268D);
			this.desc_QGBT_440V___Exaustores_500_EX_04.Name = "desc_QGBT_440V___Exaustores_500_EX_04";
			this.desc_QGBT_440V___Exaustores_500_EX_04.Text = "Exaustor 04";
			// 
			// tag_QGBT_440V___Exaustores_500_EX_05
			// 
			this.tag_QGBT_440V___Exaustores_500_EX_05.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Exaustores_500_EX_05.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Exaustores_500_EX_05.Location = new NxtControl.Drawing.PointF(12D, 296D);
			this.tag_QGBT_440V___Exaustores_500_EX_05.Name = "tag_QGBT_440V___Exaustores_500_EX_05";
			this.tag_QGBT_440V___Exaustores_500_EX_05.Text = "500-EX-05";
			// 
			// desc_QGBT_440V___Exaustores_500_EX_05
			// 
			this.desc_QGBT_440V___Exaustores_500_EX_05.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Exaustores_500_EX_05.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Exaustores_500_EX_05.Location = new NxtControl.Drawing.PointF(155D, 296D);
			this.desc_QGBT_440V___Exaustores_500_EX_05.Name = "desc_QGBT_440V___Exaustores_500_EX_05";
			this.desc_QGBT_440V___Exaustores_500_EX_05.Text = "Exaustor 05";
			// 
			// h_QGBT_440V___Compressores
			// 
			this.h_QGBT_440V___Compressores.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_QGBT_440V___Compressores.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_QGBT_440V___Compressores.Location = new NxtControl.Drawing.PointF(8D, 326D);
			this.h_QGBT_440V___Compressores.Name = "h_QGBT_440V___Compressores";
			this.h_QGBT_440V___Compressores.Text = "QGBT 440V - Ner - Compressores";
			// 
			// ln_QGBT_440V___Compressores
			// 
			this.ln_QGBT_440V___Compressores.EndPoint = new NxtControl.Drawing.PointF(370D, 348D);
			this.ln_QGBT_440V___Compressores.Name = "ln_QGBT_440V___Compressores";
			this.ln_QGBT_440V___Compressores.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_QGBT_440V___Compressores.StartPoint = new NxtControl.Drawing.PointF(0D, 348D);
			// 
			// tag_QGBT_440V___Compressores_500_COMP_01
			// 
			this.tag_QGBT_440V___Compressores_500_COMP_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Compressores_500_COMP_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Compressores_500_COMP_01.Location = new NxtControl.Drawing.PointF(12D, 356D);
			this.tag_QGBT_440V___Compressores_500_COMP_01.Name = "tag_QGBT_440V___Compressores_500_COMP_01";
			this.tag_QGBT_440V___Compressores_500_COMP_01.Text = "500-COMP-01";
			// 
			// desc_QGBT_440V___Compressores_500_COMP_01
			// 
			this.desc_QGBT_440V___Compressores_500_COMP_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Compressores_500_COMP_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Compressores_500_COMP_01.Location = new NxtControl.Drawing.PointF(155D, 356D);
			this.desc_QGBT_440V___Compressores_500_COMP_01.Name = "desc_QGBT_440V___Compressores_500_COMP_01";
			this.desc_QGBT_440V___Compressores_500_COMP_01.Text = "Compressor 01";
			// 
			// tag_QGBT_440V___Compressores_500_COMP_02
			// 
			this.tag_QGBT_440V___Compressores_500_COMP_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Compressores_500_COMP_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Compressores_500_COMP_02.Location = new NxtControl.Drawing.PointF(12D, 384D);
			this.tag_QGBT_440V___Compressores_500_COMP_02.Name = "tag_QGBT_440V___Compressores_500_COMP_02";
			this.tag_QGBT_440V___Compressores_500_COMP_02.Text = "500-COMP-02";
			// 
			// desc_QGBT_440V___Compressores_500_COMP_02
			// 
			this.desc_QGBT_440V___Compressores_500_COMP_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Compressores_500_COMP_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Compressores_500_COMP_02.Location = new NxtControl.Drawing.PointF(155D, 384D);
			this.desc_QGBT_440V___Compressores_500_COMP_02.Name = "desc_QGBT_440V___Compressores_500_COMP_02";
			this.desc_QGBT_440V___Compressores_500_COMP_02.Text = "Compressor 02";
			// 
			// h_QGBT_440V___Tratamento_Preliminar
			// 
			this.h_QGBT_440V___Tratamento_Preliminar.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_QGBT_440V___Tratamento_Preliminar.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_QGBT_440V___Tratamento_Preliminar.Location = new NxtControl.Drawing.PointF(8D, 414D);
			this.h_QGBT_440V___Tratamento_Preliminar.Name = "h_QGBT_440V___Tratamento_Preliminar";
			this.h_QGBT_440V___Tratamento_Preliminar.Text = "QGBT 440V - Trat. Preliminar";
			// 
			// ln_QGBT_440V___Tratamento_Preliminar
			// 
			this.ln_QGBT_440V___Tratamento_Preliminar.EndPoint = new NxtControl.Drawing.PointF(370D, 436D);
			this.ln_QGBT_440V___Tratamento_Preliminar.Name = "ln_QGBT_440V___Tratamento_Preliminar";
			this.ln_QGBT_440V___Tratamento_Preliminar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_QGBT_440V___Tratamento_Preliminar.StartPoint = new NxtControl.Drawing.PointF(0D, 436D);
			// 
			// tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01
			// 
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Location = new NxtControl.Drawing.PointF(12D, 444D);
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Name = "tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01";
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Text = "200-UCT-01";
			// 
			// desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01
			// 
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Location = new NxtControl.Drawing.PointF(155D, 444D);
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Name = "desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01";
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01.Text = "Unid. Compacta Trat. 01";
			// 
			// tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02
			// 
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Location = new NxtControl.Drawing.PointF(12D, 472D);
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Name = "tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02";
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Text = "200-UCT-02";
			// 
			// desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02
			// 
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Location = new NxtControl.Drawing.PointF(155D, 472D);
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Name = "desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02";
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02.Text = "Unid. Compacta Trat. 02";
			// 
			// tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03
			// 
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Location = new NxtControl.Drawing.PointF(12D, 500D);
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Name = "tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03";
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Text = "200-UCT-03";
			// 
			// desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03
			// 
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Location = new NxtControl.Drawing.PointF(155D, 500D);
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Name = "desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03";
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03.Text = "Unid. Compacta Trat. 03";
			// 
			// h_PCM_Nereda
			// 
			this.h_PCM_Nereda.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_PCM_Nereda.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_PCM_Nereda.Location = new NxtControl.Drawing.PointF(8D, 529D);
			this.h_PCM_Nereda.Name = "h_PCM_Nereda";
			this.h_PCM_Nereda.Text = "PCM Nereda";
			// 
			// ln_PCM_Nereda
			// 
			this.ln_PCM_Nereda.EndPoint = new NxtControl.Drawing.PointF(370D, 551D);
			this.ln_PCM_Nereda.Name = "ln_PCM_Nereda";
			this.ln_PCM_Nereda.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_PCM_Nereda.StartPoint = new NxtControl.Drawing.PointF(0D, 551D);
			// 
			// tag_PCM_Nereda_P4901
			// 
			this.tag_PCM_Nereda_P4901.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Nereda_P4901.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Nereda_P4901.Location = new NxtControl.Drawing.PointF(12D, 559D);
			this.tag_PCM_Nereda_P4901.Name = "tag_PCM_Nereda_P4901";
			this.tag_PCM_Nereda_P4901.Text = "P4901";
			// 
			// desc_PCM_Nereda_P4901
			// 
			this.desc_PCM_Nereda_P4901.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Nereda_P4901.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Nereda_P4901.Location = new NxtControl.Drawing.PointF(155D, 559D);
			this.desc_PCM_Nereda_P4901.Name = "desc_PCM_Nereda_P4901";
			this.desc_PCM_Nereda_P4901.Text = "Bomba Submersivel 01";
			// 
			// tag_PCM_Nereda_P4902
			// 
			this.tag_PCM_Nereda_P4902.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Nereda_P4902.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Nereda_P4902.Location = new NxtControl.Drawing.PointF(12D, 587D);
			this.tag_PCM_Nereda_P4902.Name = "tag_PCM_Nereda_P4902";
			this.tag_PCM_Nereda_P4902.Text = "P4902";
			// 
			// desc_PCM_Nereda_P4902
			// 
			this.desc_PCM_Nereda_P4902.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Nereda_P4902.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Nereda_P4902.Location = new NxtControl.Drawing.PointF(155D, 587D);
			this.desc_PCM_Nereda_P4902.Name = "desc_PCM_Nereda_P4902";
			this.desc_PCM_Nereda_P4902.Text = "Bomba Submersivel 02";
			// 
			// tag_PCM_Nereda_P4903
			// 
			this.tag_PCM_Nereda_P4903.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Nereda_P4903.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Nereda_P4903.Location = new NxtControl.Drawing.PointF(12D, 615D);
			this.tag_PCM_Nereda_P4903.Name = "tag_PCM_Nereda_P4903";
			this.tag_PCM_Nereda_P4903.Text = "P4903";
			// 
			// desc_PCM_Nereda_P4903
			// 
			this.desc_PCM_Nereda_P4903.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Nereda_P4903.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Nereda_P4903.Location = new NxtControl.Drawing.PointF(155D, 615D);
			this.desc_PCM_Nereda_P4903.Name = "desc_PCM_Nereda_P4903";
			this.desc_PCM_Nereda_P4903.Text = "Bomba Submersivel 03";
			// 
			// tag_PCM_Nereda_R4005A
			// 
			this.tag_PCM_Nereda_R4005A.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Nereda_R4005A.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Nereda_R4005A.Location = new NxtControl.Drawing.PointF(12D, 643D);
			this.tag_PCM_Nereda_R4005A.Name = "tag_PCM_Nereda_R4005A";
			this.tag_PCM_Nereda_R4005A.Text = "R4005A";
			// 
			// desc_PCM_Nereda_R4005A
			// 
			this.desc_PCM_Nereda_R4005A.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Nereda_R4005A.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Nereda_R4005A.Location = new NxtControl.Drawing.PointF(155D, 643D);
			this.desc_PCM_Nereda_R4005A.Name = "desc_PCM_Nereda_R4005A";
			this.desc_PCM_Nereda_R4005A.Text = "Bomba Horizontal A";
			// 
			// tag_PCM_Nereda_R4005B
			// 
			this.tag_PCM_Nereda_R4005B.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Nereda_R4005B.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Nereda_R4005B.Location = new NxtControl.Drawing.PointF(12D, 671D);
			this.tag_PCM_Nereda_R4005B.Name = "tag_PCM_Nereda_R4005B";
			this.tag_PCM_Nereda_R4005B.Text = "R4005B";
			// 
			// desc_PCM_Nereda_R4005B
			// 
			this.desc_PCM_Nereda_R4005B.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Nereda_R4005B.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Nereda_R4005B.Location = new NxtControl.Drawing.PointF(155D, 671D);
			this.desc_PCM_Nereda_R4005B.Name = "desc_PCM_Nereda_R4005B";
			this.desc_PCM_Nereda_R4005B.Text = "Bomba Horizontal B";
			// 
			// tag_PCM_Nereda_300_MO_01
			// 
			this.tag_PCM_Nereda_300_MO_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Nereda_300_MO_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Nereda_300_MO_01.Location = new NxtControl.Drawing.PointF(12D, 699D);
			this.tag_PCM_Nereda_300_MO_01.Name = "tag_PCM_Nereda_300_MO_01";
			this.tag_PCM_Nereda_300_MO_01.Text = "300-MO-01";
			// 
			// desc_PCM_Nereda_300_MO_01
			// 
			this.desc_PCM_Nereda_300_MO_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Nereda_300_MO_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Nereda_300_MO_01.Location = new NxtControl.Drawing.PointF(155D, 699D);
			this.desc_PCM_Nereda_300_MO_01.Name = "desc_PCM_Nereda_300_MO_01";
			this.desc_PCM_Nereda_300_MO_01.Text = "Misturador Sub 01";
			// 
			// h_PCM_EEE_Bruto
			// 
			this.h_PCM_EEE_Bruto.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_PCM_EEE_Bruto.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_PCM_EEE_Bruto.Location = new NxtControl.Drawing.PointF(398D, 10D);
			this.h_PCM_EEE_Bruto.Name = "h_PCM_EEE_Bruto";
			this.h_PCM_EEE_Bruto.Text = "PCM EEE Bruto";
			// 
			// ln_PCM_EEE_Bruto
			// 
			this.ln_PCM_EEE_Bruto.EndPoint = new NxtControl.Drawing.PointF(760D, 32D);
			this.ln_PCM_EEE_Bruto.Name = "ln_PCM_EEE_Bruto";
			this.ln_PCM_EEE_Bruto.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_PCM_EEE_Bruto.StartPoint = new NxtControl.Drawing.PointF(390D, 32D);
			// 
			// tag_PCM_EEE_Bruto_100_BS_01
			// 
			this.tag_PCM_EEE_Bruto_100_BS_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_EEE_Bruto_100_BS_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_EEE_Bruto_100_BS_01.Location = new NxtControl.Drawing.PointF(402D, 40D);
			this.tag_PCM_EEE_Bruto_100_BS_01.Name = "tag_PCM_EEE_Bruto_100_BS_01";
			this.tag_PCM_EEE_Bruto_100_BS_01.Text = "100-BS-01";
			// 
			// desc_PCM_EEE_Bruto_100_BS_01
			// 
			this.desc_PCM_EEE_Bruto_100_BS_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_EEE_Bruto_100_BS_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_EEE_Bruto_100_BS_01.Location = new NxtControl.Drawing.PointF(545D, 40D);
			this.desc_PCM_EEE_Bruto_100_BS_01.Name = "desc_PCM_EEE_Bruto_100_BS_01";
			this.desc_PCM_EEE_Bruto_100_BS_01.Text = "Bomba Submersivel 01";
			// 
			// tag_PCM_EEE_Bruto_100_BS_02
			// 
			this.tag_PCM_EEE_Bruto_100_BS_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_EEE_Bruto_100_BS_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_EEE_Bruto_100_BS_02.Location = new NxtControl.Drawing.PointF(402D, 68D);
			this.tag_PCM_EEE_Bruto_100_BS_02.Name = "tag_PCM_EEE_Bruto_100_BS_02";
			this.tag_PCM_EEE_Bruto_100_BS_02.Text = "100-BS-02";
			// 
			// desc_PCM_EEE_Bruto_100_BS_02
			// 
			this.desc_PCM_EEE_Bruto_100_BS_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_EEE_Bruto_100_BS_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_EEE_Bruto_100_BS_02.Location = new NxtControl.Drawing.PointF(545D, 68D);
			this.desc_PCM_EEE_Bruto_100_BS_02.Name = "desc_PCM_EEE_Bruto_100_BS_02";
			this.desc_PCM_EEE_Bruto_100_BS_02.Text = "Bomba Submersivel 02";
			// 
			// tag_PCM_EEE_Bruto_100_BS_03
			// 
			this.tag_PCM_EEE_Bruto_100_BS_03.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_EEE_Bruto_100_BS_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_EEE_Bruto_100_BS_03.Location = new NxtControl.Drawing.PointF(402D, 96D);
			this.tag_PCM_EEE_Bruto_100_BS_03.Name = "tag_PCM_EEE_Bruto_100_BS_03";
			this.tag_PCM_EEE_Bruto_100_BS_03.Text = "100-BS-03";
			// 
			// desc_PCM_EEE_Bruto_100_BS_03
			// 
			this.desc_PCM_EEE_Bruto_100_BS_03.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_EEE_Bruto_100_BS_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_EEE_Bruto_100_BS_03.Location = new NxtControl.Drawing.PointF(545D, 96D);
			this.desc_PCM_EEE_Bruto_100_BS_03.Name = "desc_PCM_EEE_Bruto_100_BS_03";
			this.desc_PCM_EEE_Bruto_100_BS_03.Text = "Bomba Submersivel 03";
			// 
			// tag_PCM_EEE_Bruto_100_GM_01
			// 
			this.tag_PCM_EEE_Bruto_100_GM_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_EEE_Bruto_100_GM_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_EEE_Bruto_100_GM_01.Location = new NxtControl.Drawing.PointF(402D, 124D);
			this.tag_PCM_EEE_Bruto_100_GM_01.Name = "tag_PCM_EEE_Bruto_100_GM_01";
			this.tag_PCM_EEE_Bruto_100_GM_01.Text = "100-GM-01";
			// 
			// desc_PCM_EEE_Bruto_100_GM_01
			// 
			this.desc_PCM_EEE_Bruto_100_GM_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_EEE_Bruto_100_GM_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_EEE_Bruto_100_GM_01.Location = new NxtControl.Drawing.PointF(545D, 124D);
			this.desc_PCM_EEE_Bruto_100_GM_01.Name = "desc_PCM_EEE_Bruto_100_GM_01";
			this.desc_PCM_EEE_Bruto_100_GM_01.Text = "Grade Mecanizada 01";
			// 
			// h_PCM_Desinfeccao
			// 
			this.h_PCM_Desinfeccao.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_PCM_Desinfeccao.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_PCM_Desinfeccao.Location = new NxtControl.Drawing.PointF(398D, 414D);
			this.h_PCM_Desinfeccao.Name = "h_PCM_Desinfeccao";
			this.h_PCM_Desinfeccao.Text = "PCM Desinfeccao";
			// 
			// ln_PCM_Desinfeccao
			// 
			this.ln_PCM_Desinfeccao.EndPoint = new NxtControl.Drawing.PointF(760D, 436D);
			this.ln_PCM_Desinfeccao.Name = "ln_PCM_Desinfeccao";
			this.ln_PCM_Desinfeccao.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_PCM_Desinfeccao.StartPoint = new NxtControl.Drawing.PointF(390D, 436D);
			// 
			// tag_PCM_Desinfeccao_700_UV_01
			// 
			this.tag_PCM_Desinfeccao_700_UV_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Desinfeccao_700_UV_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Desinfeccao_700_UV_01.Location = new NxtControl.Drawing.PointF(402D, 444D);
			this.tag_PCM_Desinfeccao_700_UV_01.Name = "tag_PCM_Desinfeccao_700_UV_01";
			this.tag_PCM_Desinfeccao_700_UV_01.Text = "700-UV-01";
			// 
			// desc_PCM_Desinfeccao_700_UV_01
			// 
			this.desc_PCM_Desinfeccao_700_UV_01.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Desinfeccao_700_UV_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Desinfeccao_700_UV_01.Location = new NxtControl.Drawing.PointF(545D, 444D);
			this.desc_PCM_Desinfeccao_700_UV_01.Name = "desc_PCM_Desinfeccao_700_UV_01";
			this.desc_PCM_Desinfeccao_700_UV_01.Text = "Sistema UV 01";
			// 
			// tag_PCM_Desinfeccao_700_UV_02
			// 
			this.tag_PCM_Desinfeccao_700_UV_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Desinfeccao_700_UV_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Desinfeccao_700_UV_02.Location = new NxtControl.Drawing.PointF(402D, 472D);
			this.tag_PCM_Desinfeccao_700_UV_02.Name = "tag_PCM_Desinfeccao_700_UV_02";
			this.tag_PCM_Desinfeccao_700_UV_02.Text = "700-UV-02";
			// 
			// desc_PCM_Desinfeccao_700_UV_02
			// 
			this.desc_PCM_Desinfeccao_700_UV_02.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Desinfeccao_700_UV_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Desinfeccao_700_UV_02.Location = new NxtControl.Drawing.PointF(545D, 472D);
			this.desc_PCM_Desinfeccao_700_UV_02.Name = "desc_PCM_Desinfeccao_700_UV_02";
			this.desc_PCM_Desinfeccao_700_UV_02.Text = "Sistema UV 02";
			// 
			// h_PCM_Agua_Reuso
			// 
			this.h_PCM_Agua_Reuso.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_PCM_Agua_Reuso.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_PCM_Agua_Reuso.Location = new NxtControl.Drawing.PointF(398D, 326D);
			this.h_PCM_Agua_Reuso.Name = "h_PCM_Agua_Reuso";
			this.h_PCM_Agua_Reuso.Text = "PCM Agua Reuso";
			// 
			// ln_PCM_Agua_Reuso
			// 
			this.ln_PCM_Agua_Reuso.EndPoint = new NxtControl.Drawing.PointF(760D, 348D);
			this.ln_PCM_Agua_Reuso.Name = "ln_PCM_Agua_Reuso";
			this.ln_PCM_Agua_Reuso.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_PCM_Agua_Reuso.StartPoint = new NxtControl.Drawing.PointF(390D, 348D);
			// 
			// tag_PCM_Agua_Reuso_800_DO_04
			// 
			this.tag_PCM_Agua_Reuso_800_DO_04.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Agua_Reuso_800_DO_04.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Agua_Reuso_800_DO_04.Location = new NxtControl.Drawing.PointF(402D, 356D);
			this.tag_PCM_Agua_Reuso_800_DO_04.Name = "tag_PCM_Agua_Reuso_800_DO_04";
			this.tag_PCM_Agua_Reuso_800_DO_04.Text = "800-DO-04";
			// 
			// desc_PCM_Agua_Reuso_800_DO_04
			// 
			this.desc_PCM_Agua_Reuso_800_DO_04.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Agua_Reuso_800_DO_04.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Agua_Reuso_800_DO_04.Location = new NxtControl.Drawing.PointF(545D, 356D);
			this.desc_PCM_Agua_Reuso_800_DO_04.Name = "desc_PCM_Agua_Reuso_800_DO_04";
			this.desc_PCM_Agua_Reuso_800_DO_04.Text = "Bomba Dosadora 04";
			// 
			// tag_PCM_Agua_Reuso_800_DO_05
			// 
			this.tag_PCM_Agua_Reuso_800_DO_05.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_PCM_Agua_Reuso_800_DO_05.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_PCM_Agua_Reuso_800_DO_05.Location = new NxtControl.Drawing.PointF(402D, 384D);
			this.tag_PCM_Agua_Reuso_800_DO_05.Name = "tag_PCM_Agua_Reuso_800_DO_05";
			this.tag_PCM_Agua_Reuso_800_DO_05.Text = "800-DO-05";
			// 
			// desc_PCM_Agua_Reuso_800_DO_05
			// 
			this.desc_PCM_Agua_Reuso_800_DO_05.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_PCM_Agua_Reuso_800_DO_05.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_PCM_Agua_Reuso_800_DO_05.Location = new NxtControl.Drawing.PointF(545D, 384D);
			this.desc_PCM_Agua_Reuso_800_DO_05.Name = "desc_PCM_Agua_Reuso_800_DO_05";
			this.desc_PCM_Agua_Reuso_800_DO_05.Text = "Bomba Dosadora 05";
			// 
			// h_QGBT_220V
			// 
			this.h_QGBT_220V.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.h_QGBT_220V.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.h_QGBT_220V.Location = new NxtControl.Drawing.PointF(398D, 154D);
			this.h_QGBT_220V.Name = "h_QGBT_220V";
			this.h_QGBT_220V.Text = "QGBT 220V";
			// 
			// ln_QGBT_220V
			// 
			this.ln_QGBT_220V.EndPoint = new NxtControl.Drawing.PointF(760D, 176D);
			this.ln_QGBT_220V.Name = "ln_QGBT_220V";
			this.ln_QGBT_220V.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ln_QGBT_220V.StartPoint = new NxtControl.Drawing.PointF(390D, 176D);
			// 
			// tag_QGBT_220V_QL_PORTARIA
			// 
			this.tag_QGBT_220V_QL_PORTARIA.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_220V_QL_PORTARIA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_220V_QL_PORTARIA.Location = new NxtControl.Drawing.PointF(402D, 184D);
			this.tag_QGBT_220V_QL_PORTARIA.Name = "tag_QGBT_220V_QL_PORTARIA";
			this.tag_QGBT_220V_QL_PORTARIA.Text = "QL_PORTARIA";
			// 
			// desc_QGBT_220V_QL_PORTARIA
			// 
			this.desc_QGBT_220V_QL_PORTARIA.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_220V_QL_PORTARIA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_220V_QL_PORTARIA.Location = new NxtControl.Drawing.PointF(545D, 184D);
			this.desc_QGBT_220V_QL_PORTARIA.Name = "desc_QGBT_220V_QL_PORTARIA";
			this.desc_QGBT_220V_QL_PORTARIA.Text = "QL Portaria";
			// 
			// tag_QGBT_220V_QL_ADM
			// 
			this.tag_QGBT_220V_QL_ADM.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_220V_QL_ADM.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_220V_QL_ADM.Location = new NxtControl.Drawing.PointF(402D, 212D);
			this.tag_QGBT_220V_QL_ADM.Name = "tag_QGBT_220V_QL_ADM";
			this.tag_QGBT_220V_QL_ADM.Text = "QL_ADM";
			// 
			// desc_QGBT_220V_QL_ADM
			// 
			this.desc_QGBT_220V_QL_ADM.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_220V_QL_ADM.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_220V_QL_ADM.Location = new NxtControl.Drawing.PointF(545D, 212D);
			this.desc_QGBT_220V_QL_ADM.Name = "desc_QGBT_220V_QL_ADM";
			this.desc_QGBT_220V_QL_ADM.Text = "QL Administracao";
			// 
			// tag_QGBT_220V_QL_LODO
			// 
			this.tag_QGBT_220V_QL_LODO.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_220V_QL_LODO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_220V_QL_LODO.Location = new NxtControl.Drawing.PointF(402D, 240D);
			this.tag_QGBT_220V_QL_LODO.Name = "tag_QGBT_220V_QL_LODO";
			this.tag_QGBT_220V_QL_LODO.Text = "QL_LODO";
			// 
			// desc_QGBT_220V_QL_LODO
			// 
			this.desc_QGBT_220V_QL_LODO.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_220V_QL_LODO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_220V_QL_LODO.Location = new NxtControl.Drawing.PointF(545D, 240D);
			this.desc_QGBT_220V_QL_LODO.Name = "desc_QGBT_220V_QL_LODO";
			this.desc_QGBT_220V_QL_LODO.Text = "QL Lodo";
			// 
			// tag_QGBT_220V_QLSL
			// 
			this.tag_QGBT_220V_QLSL.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_220V_QLSL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_220V_QLSL.Location = new NxtControl.Drawing.PointF(402D, 268D);
			this.tag_QGBT_220V_QLSL.Name = "tag_QGBT_220V_QLSL";
			this.tag_QGBT_220V_QLSL.Text = "QLSL";
			// 
			// desc_QGBT_220V_QLSL
			// 
			this.desc_QGBT_220V_QLSL.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_220V_QLSL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_220V_QLSL.Location = new NxtControl.Drawing.PointF(545D, 268D);
			this.desc_QGBT_220V_QLSL.Name = "desc_QGBT_220V_QLSL";
			this.desc_QGBT_220V_QLSL.Text = "QL Sala Quadros";
			// 
			// tag_QGBT_220V_QL_ILUMINACAO
			// 
			this.tag_QGBT_220V_QL_ILUMINACAO.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.tag_QGBT_220V_QL_ILUMINACAO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tag_QGBT_220V_QL_ILUMINACAO.Location = new NxtControl.Drawing.PointF(402D, 296D);
			this.tag_QGBT_220V_QL_ILUMINACAO.Name = "tag_QGBT_220V_QL_ILUMINACAO";
			this.tag_QGBT_220V_QL_ILUMINACAO.Text = "QL_ILUMINACAO";
			// 
			// desc_QGBT_220V_QL_ILUMINACAO
			// 
			this.desc_QGBT_220V_QL_ILUMINACAO.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.desc_QGBT_220V_QL_ILUMINACAO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.desc_QGBT_220V_QL_ILUMINACAO.Location = new NxtControl.Drawing.PointF(545D, 296D);
			this.desc_QGBT_220V_QL_ILUMINACAO.Name = "desc_QGBT_220V_QL_ILUMINACAO";
			this.desc_QGBT_220V_QL_ILUMINACAO.Text = "QL Iluminacao Externa";
			// 
			// swHab_01
			// 
			this.swHab_01.BeginInit();
			this.swHab_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 38D);
			this.swHab_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_01.Name = "swHab_01";
			this.swHab_01.TagName = "HAB_GERADOR_EQUIP_1";
			this.swHab_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_01.Value = false;
			this.swHab_01.EndInit();
			// 
			// swHab_02
			// 
			this.swHab_02.BeginInit();
			this.swHab_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 64D);
			this.swHab_02.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_02.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_02.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_02.Name = "swHab_02";
			this.swHab_02.TagName = "HAB_GERADOR_EQUIP_2";
			this.swHab_02.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_02.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_02.Value = false;
			this.swHab_02.EndInit();
			// 
			// swHab_03
			// 
			this.swHab_03.BeginInit();
			this.swHab_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 93D);
			this.swHab_03.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_03.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_03.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_03.Name = "swHab_03";
			this.swHab_03.TagName = "HAB_GERADOR_EQUIP_3";
			this.swHab_03.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_03.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_03.Value = false;
			this.swHab_03.EndInit();
			// 
			// swHab_04
			// 
			this.swHab_04.BeginInit();
			this.swHab_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 122D);
			this.swHab_04.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_04.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_04.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_04.Name = "swHab_04";
			this.swHab_04.TagName = "HAB_GERADOR_EQUIP_4";
			this.swHab_04.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_04.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_04.Value = false;
			this.swHab_04.EndInit();
			// 
			// swHab_05
			// 
			this.swHab_05.BeginInit();
			this.swHab_05.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 182D);
			this.swHab_05.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_05.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_05.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_05.Name = "swHab_05";
			this.swHab_05.TagName = "HAB_GERADOR_EQUIP_5";
			this.swHab_05.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_05.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_05.Value = false;
			this.swHab_05.EndInit();
			// 
			// swHab_06
			// 
			this.swHab_06.BeginInit();
			this.swHab_06.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 210D);
			this.swHab_06.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_06.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_06.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_06.Name = "swHab_06";
			this.swHab_06.TagName = "HAB_GERADOR_EQUIP_6";
			this.swHab_06.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_06.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_06.Value = false;
			this.swHab_06.EndInit();
			// 
			// swHab_07
			// 
			this.swHab_07.BeginInit();
			this.swHab_07.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 238D);
			this.swHab_07.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_07.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_07.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_07.Name = "swHab_07";
			this.swHab_07.TagName = "HAB_GERADOR_EQUIP_7";
			this.swHab_07.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_07.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_07.Value = false;
			this.swHab_07.EndInit();
			// 
			// swHab_08
			// 
			this.swHab_08.BeginInit();
			this.swHab_08.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 266D);
			this.swHab_08.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_08.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_08.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_08.Name = "swHab_08";
			this.swHab_08.TagName = "HAB_GERADOR_EQUIP_8";
			this.swHab_08.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_08.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_08.Value = false;
			this.swHab_08.EndInit();
			// 
			// swHab_09
			// 
			this.swHab_09.BeginInit();
			this.swHab_09.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 294D);
			this.swHab_09.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_09.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_09.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_09.Name = "swHab_09";
			this.swHab_09.TagName = "HAB_GERADOR_EQUIP_9";
			this.swHab_09.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_09.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_09.Value = false;
			this.swHab_09.EndInit();
			// 
			// swHab_10
			// 
			this.swHab_10.BeginInit();
			this.swHab_10.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 354D);
			this.swHab_10.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_10.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_10.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_10.Name = "swHab_10";
			this.swHab_10.TagName = "HAB_GERADOR_EQUIP_10";
			this.swHab_10.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_10.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_10.Value = false;
			this.swHab_10.EndInit();
			// 
			// swHab_11
			// 
			this.swHab_11.BeginInit();
			this.swHab_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 382D);
			this.swHab_11.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_11.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_11.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_11.Name = "swHab_11";
			this.swHab_11.TagName = "HAB_GERADOR_EQUIP_11";
			this.swHab_11.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_11.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_11.Value = false;
			this.swHab_11.EndInit();
			// 
			// swHab_12
			// 
			this.swHab_12.BeginInit();
			this.swHab_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 442D);
			this.swHab_12.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_12.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_12.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_12.Name = "swHab_12";
			this.swHab_12.TagName = "HAB_GERADOR_EQUIP_12";
			this.swHab_12.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_12.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_12.Value = false;
			this.swHab_12.EndInit();
			// 
			// swHab_13
			// 
			this.swHab_13.BeginInit();
			this.swHab_13.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 470D);
			this.swHab_13.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_13.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_13.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_13.Name = "swHab_13";
			this.swHab_13.TagName = "HAB_GERADOR_EQUIP_13";
			this.swHab_13.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_13.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_13.Value = false;
			this.swHab_13.EndInit();
			// 
			// swHab_14
			// 
			this.swHab_14.BeginInit();
			this.swHab_14.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 498D);
			this.swHab_14.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_14.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_14.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_14.Name = "swHab_14";
			this.swHab_14.TagName = "HAB_GERADOR_EQUIP_14";
			this.swHab_14.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_14.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_14.Value = false;
			this.swHab_14.EndInit();
			// 
			// swHab_15
			// 
			this.swHab_15.BeginInit();
			this.swHab_15.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 557D);
			this.swHab_15.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_15.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_15.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_15.Name = "swHab_15";
			this.swHab_15.TagName = "HAB_GERADOR_EQUIP_15";
			this.swHab_15.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_15.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_15.Value = false;
			this.swHab_15.EndInit();
			// 
			// swHab_16
			// 
			this.swHab_16.BeginInit();
			this.swHab_16.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 585D);
			this.swHab_16.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_16.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_16.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_16.Name = "swHab_16";
			this.swHab_16.TagName = "HAB_GERADOR_EQUIP_16";
			this.swHab_16.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_16.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_16.Value = false;
			this.swHab_16.EndInit();
			// 
			// swHab_17
			// 
			this.swHab_17.BeginInit();
			this.swHab_17.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 613D);
			this.swHab_17.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_17.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_17.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_17.Name = "swHab_17";
			this.swHab_17.TagName = "HAB_GERADOR_EQUIP_17";
			this.swHab_17.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_17.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_17.Value = false;
			this.swHab_17.EndInit();
			// 
			// swHab_18
			// 
			this.swHab_18.BeginInit();
			this.swHab_18.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 641D);
			this.swHab_18.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_18.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_18.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_18.Name = "swHab_18";
			this.swHab_18.TagName = "HAB_GERADOR_EQUIP_18";
			this.swHab_18.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_18.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_18.Value = false;
			this.swHab_18.EndInit();
			// 
			// swHab_19
			// 
			this.swHab_19.BeginInit();
			this.swHab_19.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 669D);
			this.swHab_19.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_19.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_19.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_19.Name = "swHab_19";
			this.swHab_19.TagName = "HAB_GERADOR_EQUIP_19";
			this.swHab_19.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_19.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_19.Value = false;
			this.swHab_19.EndInit();
			// 
			// swHab_20
			// 
			this.swHab_20.BeginInit();
			this.swHab_20.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 296D, 697D);
			this.swHab_20.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_20.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_20.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_20.Name = "swHab_20";
			this.swHab_20.TagName = "HAB_GERADOR_EQUIP_20";
			this.swHab_20.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_20.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_20.Value = false;
			this.swHab_20.EndInit();
			// 
			// swHab_21
			// 
			this.swHab_21.BeginInit();
			this.swHab_21.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 38D);
			this.swHab_21.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_21.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_21.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_21.Name = "swHab_21";
			this.swHab_21.TagName = "HAB_GERADOR_EQUIP_21";
			this.swHab_21.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_21.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_21.Value = false;
			this.swHab_21.EndInit();
			// 
			// swHab_22
			// 
			this.swHab_22.BeginInit();
			this.swHab_22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 66D);
			this.swHab_22.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_22.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_22.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_22.Name = "swHab_22";
			this.swHab_22.TagName = "HAB_GERADOR_EQUIP_22";
			this.swHab_22.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_22.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_22.Value = false;
			this.swHab_22.EndInit();
			// 
			// swHab_23
			// 
			this.swHab_23.BeginInit();
			this.swHab_23.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 94D);
			this.swHab_23.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_23.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_23.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_23.Name = "swHab_23";
			this.swHab_23.TagName = "HAB_GERADOR_EQUIP_23";
			this.swHab_23.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_23.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_23.Value = false;
			this.swHab_23.EndInit();
			// 
			// swHab_24
			// 
			this.swHab_24.BeginInit();
			this.swHab_24.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 122D);
			this.swHab_24.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_24.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_24.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_24.Name = "swHab_24";
			this.swHab_24.TagName = "HAB_GERADOR_EQUIP_24";
			this.swHab_24.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_24.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_24.Value = false;
			this.swHab_24.EndInit();
			// 
			// swHab_25
			// 
			this.swHab_25.BeginInit();
			this.swHab_25.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 442D);
			this.swHab_25.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_25.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_25.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_25.Name = "swHab_25";
			this.swHab_25.TagName = "HAB_GERADOR_EQUIP_25";
			this.swHab_25.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_25.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_25.Value = false;
			this.swHab_25.EndInit();
			// 
			// swHab_26
			// 
			this.swHab_26.BeginInit();
			this.swHab_26.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 470D);
			this.swHab_26.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_26.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_26.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_26.Name = "swHab_26";
			this.swHab_26.TagName = "HAB_GERADOR_EQUIP_26";
			this.swHab_26.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_26.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_26.Value = false;
			this.swHab_26.EndInit();
			// 
			// swHab_27
			// 
			this.swHab_27.BeginInit();
			this.swHab_27.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 354D);
			this.swHab_27.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_27.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_27.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_27.Name = "swHab_27";
			this.swHab_27.TagName = "HAB_GERADOR_EQUIP_27";
			this.swHab_27.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_27.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_27.Value = false;
			this.swHab_27.EndInit();
			// 
			// swHab_28
			// 
			this.swHab_28.BeginInit();
			this.swHab_28.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 382D);
			this.swHab_28.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_28.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_28.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_28.Name = "swHab_28";
			this.swHab_28.TagName = "HAB_GERADOR_EQUIP_28";
			this.swHab_28.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_28.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_28.Value = false;
			this.swHab_28.EndInit();
			// 
			// swHab_29
			// 
			this.swHab_29.BeginInit();
			this.swHab_29.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 182D);
			this.swHab_29.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_29.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_29.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_29.Name = "swHab_29";
			this.swHab_29.TagName = "HAB_GERADOR_EQUIP_29";
			this.swHab_29.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_29.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_29.Value = false;
			this.swHab_29.EndInit();
			// 
			// swHab_30
			// 
			this.swHab_30.BeginInit();
			this.swHab_30.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 210D);
			this.swHab_30.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_30.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_30.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_30.Name = "swHab_30";
			this.swHab_30.TagName = "HAB_GERADOR_EQUIP_30";
			this.swHab_30.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_30.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_30.Value = false;
			this.swHab_30.EndInit();
			// 
			// swHab_31
			// 
			this.swHab_31.BeginInit();
			this.swHab_31.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 238D);
			this.swHab_31.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_31.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_31.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_31.Name = "swHab_31";
			this.swHab_31.TagName = "HAB_GERADOR_EQUIP_31";
			this.swHab_31.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_31.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_31.Value = false;
			this.swHab_31.EndInit();
			// 
			// swHab_32
			// 
			this.swHab_32.BeginInit();
			this.swHab_32.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 266D);
			this.swHab_32.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_32.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_32.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_32.Name = "swHab_32";
			this.swHab_32.TagName = "HAB_GERADOR_EQUIP_32";
			this.swHab_32.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_32.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_32.Value = false;
			this.swHab_32.EndInit();
			// 
			// swHab_33
			// 
			this.swHab_33.BeginInit();
			this.swHab_33.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.66666666666666663D, 680D, 294D);
			this.swHab_33.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_33.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_33.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.swHab_33.Name = "swHab_33";
			this.swHab_33.TagName = "HAB_GERADOR_EQUIP_33";
			this.swHab_33.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.swHab_33.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.swHab_33.Value = false;
			this.swHab_33.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(278D, 10D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Hab. Gerador";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(278D, 156D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Hab. Gerador";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(278D, 327D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Hab. Gerador";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(278D, 415D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Hab. Gerador";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(278D, 528D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Hab. Gerador";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(666D, 10D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Hab. Gerador";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(666D, 414D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Hab. Gerador";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(666D, 326D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Hab. Gerador";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(100)), ((byte)(180)));
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(666D, 156D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Hab. Gerador";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_PCM_Nereda,
			this.ln_PCM_Nereda,
			this.tag_PCM_Nereda_P4901,
			this.desc_PCM_Nereda_P4901,
			this.tag_PCM_Nereda_P4902,
			this.desc_PCM_Nereda_P4902,
			this.tag_PCM_Nereda_P4903,
			this.desc_PCM_Nereda_P4903,
			this.tag_PCM_Nereda_R4005A,
			this.desc_PCM_Nereda_R4005A,
			this.tag_PCM_Nereda_R4005B,
			this.desc_PCM_Nereda_R4005B,
			this.tag_PCM_Nereda_300_MO_01,
			this.desc_PCM_Nereda_300_MO_01,
			this.swHab_15,
			this.swHab_16,
			this.swHab_17,
			this.swHab_18,
			this.swHab_19,
			this.swHab_20,
			this.freeText5});
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_QGBT_440V___Tratamento_Preliminar,
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01,
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01,
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02,
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02,
			this.tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03,
			this.desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03,
			this.swHab_12,
			this.swHab_13,
			this.swHab_14,
			this.freeText4});
			this.group2.EndInit();
			// 
			// group3
			// 
			this.group3.BeginInit();
			this.group3.Name = "group3";
			this.group3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_QGBT_440V___Compressores,
			this.tag_QGBT_440V___Compressores_500_COMP_01,
			this.desc_QGBT_440V___Compressores_500_COMP_01,
			this.tag_QGBT_440V___Compressores_500_COMP_02,
			this.desc_QGBT_440V___Compressores_500_COMP_02,
			this.swHab_10,
			this.swHab_11,
			this.freeText3});
			this.group3.EndInit();
			// 
			// group4
			// 
			this.group4.BeginInit();
			this.group4.Name = "group4";
			this.group4.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_QGBT_440V___Exaustores,
			this.ln_QGBT_440V___Exaustores,
			this.tag_QGBT_440V___Exaustores_500_EX_01,
			this.desc_QGBT_440V___Exaustores_500_EX_01,
			this.tag_QGBT_440V___Exaustores_500_EX_02,
			this.desc_QGBT_440V___Exaustores_500_EX_02,
			this.tag_QGBT_440V___Exaustores_500_EX_03,
			this.desc_QGBT_440V___Exaustores_500_EX_03,
			this.tag_QGBT_440V___Exaustores_500_EX_04,
			this.desc_QGBT_440V___Exaustores_500_EX_04,
			this.tag_QGBT_440V___Exaustores_500_EX_05,
			this.desc_QGBT_440V___Exaustores_500_EX_05,
			this.swHab_05,
			this.swHab_06,
			this.swHab_07,
			this.swHab_08,
			this.swHab_09,
			this.freeText2});
			this.group4.EndInit();
			// 
			// group5
			// 
			this.group5.BeginInit();
			this.group5.Name = "group5";
			this.group5.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_QGBT_440V___Sopradores,
			this.tag_QGBT_440V___Sopradores_V4601,
			this.desc_QGBT_440V___Sopradores_V4601,
			this.tag_QGBT_440V___Sopradores_V4602,
			this.desc_QGBT_440V___Sopradores_V4602,
			this.tag_QGBT_440V___Sopradores_V4603,
			this.desc_QGBT_440V___Sopradores_V4603,
			this.tag_QGBT_440V___Sopradores_V4604,
			this.desc_QGBT_440V___Sopradores_V4604,
			this.swHab_01,
			this.swHab_02,
			this.swHab_03,
			this.swHab_04,
			this.freeText1});
			this.group5.EndInit();
			// 
			// group6
			// 
			this.group6.BeginInit();
			this.group6.Name = "group6";
			this.group6.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_QGBT_220V,
			this.ln_QGBT_220V,
			this.tag_QGBT_220V_QL_PORTARIA,
			this.desc_QGBT_220V_QL_PORTARIA,
			this.tag_QGBT_220V_QL_ADM,
			this.desc_QGBT_220V_QL_ADM,
			this.tag_QGBT_220V_QL_LODO,
			this.desc_QGBT_220V_QL_LODO,
			this.tag_QGBT_220V_QLSL,
			this.desc_QGBT_220V_QLSL,
			this.tag_QGBT_220V_QL_ILUMINACAO,
			this.desc_QGBT_220V_QL_ILUMINACAO,
			this.swHab_29,
			this.swHab_30,
			this.swHab_31,
			this.swHab_32,
			this.swHab_33,
			this.freeText9});
			this.group6.EndInit();
			// 
			// group7
			// 
			this.group7.BeginInit();
			this.group7.Name = "group7";
			this.group7.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_PCM_Agua_Reuso,
			this.ln_PCM_Agua_Reuso,
			this.tag_PCM_Agua_Reuso_800_DO_04,
			this.desc_PCM_Agua_Reuso_800_DO_04,
			this.tag_PCM_Agua_Reuso_800_DO_05,
			this.desc_PCM_Agua_Reuso_800_DO_05,
			this.swHab_27,
			this.swHab_28,
			this.freeText8});
			this.group7.EndInit();
			// 
			// group8
			// 
			this.group8.BeginInit();
			this.group8.Name = "group8";
			this.group8.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_PCM_Desinfeccao,
			this.ln_PCM_Desinfeccao,
			this.tag_PCM_Desinfeccao_700_UV_01,
			this.desc_PCM_Desinfeccao_700_UV_01,
			this.tag_PCM_Desinfeccao_700_UV_02,
			this.desc_PCM_Desinfeccao_700_UV_02,
			this.swHab_25,
			this.swHab_26});
			this.group8.EndInit();
			// 
			// group9
			// 
			this.group9.BeginInit();
			this.group9.Name = "group9";
			this.group9.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.h_PCM_EEE_Bruto,
			this.ln_PCM_EEE_Bruto,
			this.tag_PCM_EEE_Bruto_100_BS_01,
			this.desc_PCM_EEE_Bruto_100_BS_01,
			this.tag_PCM_EEE_Bruto_100_BS_02,
			this.desc_PCM_EEE_Bruto_100_BS_02,
			this.tag_PCM_EEE_Bruto_100_BS_03,
			this.desc_PCM_EEE_Bruto_100_BS_03,
			this.tag_PCM_EEE_Bruto_100_GM_01,
			this.desc_PCM_EEE_Bruto_100_GM_01,
			this.swHab_21,
			this.swHab_22,
			this.swHab_23,
			this.swHab_24,
			this.freeText6});
			this.group9.EndInit();
			// 
			// fpAlimentados
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(776D)), ((float)(740D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ln_QGBT_440V___Sopradores,
			this.ln_QGBT_440V___Compressores,
			this.ln_QGBT_440V___Tratamento_Preliminar,
			this.freeText7,
			this.group1,
			this.group2,
			this.group3,
			this.group4,
			this.group5,
			this.group6,
			this.group7,
			this.group8,
			this.group9});
			this.Size = new System.Drawing.Size(776, 740);

		}
		private NxtControl.GuiFramework.FreeText h_QGBT_440V___Sopradores;
		private NxtControl.GuiFramework.Line ln_QGBT_440V___Sopradores;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Sopradores_V4601;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Sopradores_V4601;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Sopradores_V4602;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Sopradores_V4602;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Sopradores_V4603;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Sopradores_V4603;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Sopradores_V4604;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Sopradores_V4604;
		private NxtControl.GuiFramework.FreeText h_QGBT_440V___Exaustores;
		private NxtControl.GuiFramework.Line ln_QGBT_440V___Exaustores;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Exaustores_500_EX_01;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Exaustores_500_EX_01;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Exaustores_500_EX_02;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Exaustores_500_EX_02;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Exaustores_500_EX_03;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Exaustores_500_EX_03;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Exaustores_500_EX_04;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Exaustores_500_EX_04;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Exaustores_500_EX_05;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Exaustores_500_EX_05;
		private NxtControl.GuiFramework.FreeText h_QGBT_440V___Compressores;
		private NxtControl.GuiFramework.Line ln_QGBT_440V___Compressores;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Compressores_500_COMP_01;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Compressores_500_COMP_01;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Compressores_500_COMP_02;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Compressores_500_COMP_02;
		private NxtControl.GuiFramework.FreeText h_QGBT_440V___Tratamento_Preliminar;
		private NxtControl.GuiFramework.Line ln_QGBT_440V___Tratamento_Preliminar;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Tratamento_Preliminar_200_UCT_01;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Tratamento_Preliminar_200_UCT_01;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Tratamento_Preliminar_200_UCT_02;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Tratamento_Preliminar_200_UCT_02;
		private NxtControl.GuiFramework.FreeText tag_QGBT_440V___Tratamento_Preliminar_200_UCT_03;
		private NxtControl.GuiFramework.FreeText desc_QGBT_440V___Tratamento_Preliminar_200_UCT_03;
		private NxtControl.GuiFramework.FreeText h_PCM_Nereda;
		private NxtControl.GuiFramework.Line ln_PCM_Nereda;
		private NxtControl.GuiFramework.FreeText tag_PCM_Nereda_P4901;
		private NxtControl.GuiFramework.FreeText desc_PCM_Nereda_P4901;
		private NxtControl.GuiFramework.FreeText tag_PCM_Nereda_P4902;
		private NxtControl.GuiFramework.FreeText desc_PCM_Nereda_P4902;
		private NxtControl.GuiFramework.FreeText tag_PCM_Nereda_P4903;
		private NxtControl.GuiFramework.FreeText desc_PCM_Nereda_P4903;
		private NxtControl.GuiFramework.FreeText tag_PCM_Nereda_R4005A;
		private NxtControl.GuiFramework.FreeText desc_PCM_Nereda_R4005A;
		private NxtControl.GuiFramework.FreeText tag_PCM_Nereda_R4005B;
		private NxtControl.GuiFramework.FreeText desc_PCM_Nereda_R4005B;
		private NxtControl.GuiFramework.FreeText tag_PCM_Nereda_300_MO_01;
		private NxtControl.GuiFramework.FreeText desc_PCM_Nereda_300_MO_01;
		private NxtControl.GuiFramework.FreeText h_PCM_EEE_Bruto;
		private NxtControl.GuiFramework.Line ln_PCM_EEE_Bruto;
		private NxtControl.GuiFramework.FreeText tag_PCM_EEE_Bruto_100_BS_01;
		private NxtControl.GuiFramework.FreeText desc_PCM_EEE_Bruto_100_BS_01;
		private NxtControl.GuiFramework.FreeText tag_PCM_EEE_Bruto_100_BS_02;
		private NxtControl.GuiFramework.FreeText desc_PCM_EEE_Bruto_100_BS_02;
		private NxtControl.GuiFramework.FreeText tag_PCM_EEE_Bruto_100_BS_03;
		private NxtControl.GuiFramework.FreeText desc_PCM_EEE_Bruto_100_BS_03;
		private NxtControl.GuiFramework.FreeText tag_PCM_EEE_Bruto_100_GM_01;
		private NxtControl.GuiFramework.FreeText desc_PCM_EEE_Bruto_100_GM_01;
		private NxtControl.GuiFramework.FreeText h_PCM_Desinfeccao;
		private NxtControl.GuiFramework.Line ln_PCM_Desinfeccao;
		private NxtControl.GuiFramework.FreeText tag_PCM_Desinfeccao_700_UV_01;
		private NxtControl.GuiFramework.FreeText desc_PCM_Desinfeccao_700_UV_01;
		private NxtControl.GuiFramework.FreeText tag_PCM_Desinfeccao_700_UV_02;
		private NxtControl.GuiFramework.FreeText desc_PCM_Desinfeccao_700_UV_02;
		private NxtControl.GuiFramework.FreeText h_PCM_Agua_Reuso;
		private NxtControl.GuiFramework.Line ln_PCM_Agua_Reuso;
		private NxtControl.GuiFramework.FreeText tag_PCM_Agua_Reuso_800_DO_04;
		private NxtControl.GuiFramework.FreeText desc_PCM_Agua_Reuso_800_DO_04;
		private NxtControl.GuiFramework.FreeText tag_PCM_Agua_Reuso_800_DO_05;
		private NxtControl.GuiFramework.FreeText desc_PCM_Agua_Reuso_800_DO_05;
		private NxtControl.GuiFramework.FreeText h_QGBT_220V;
		private NxtControl.GuiFramework.Line ln_QGBT_220V;
		private NxtControl.GuiFramework.FreeText tag_QGBT_220V_QL_PORTARIA;
		private NxtControl.GuiFramework.FreeText desc_QGBT_220V_QL_PORTARIA;
		private NxtControl.GuiFramework.FreeText tag_QGBT_220V_QL_ADM;
		private NxtControl.GuiFramework.FreeText desc_QGBT_220V_QL_ADM;
		private NxtControl.GuiFramework.FreeText tag_QGBT_220V_QL_LODO;
		private NxtControl.GuiFramework.FreeText desc_QGBT_220V_QL_LODO;
		private NxtControl.GuiFramework.FreeText tag_QGBT_220V_QLSL;
		private NxtControl.GuiFramework.FreeText desc_QGBT_220V_QLSL;
		private NxtControl.GuiFramework.FreeText tag_QGBT_220V_QL_ILUMINACAO;
		private NxtControl.GuiFramework.FreeText desc_QGBT_220V_QL_ILUMINACAO;
		private System.HMI.Symbols.Base.SwitchButton swHab_01;
		private System.HMI.Symbols.Base.SwitchButton swHab_02;
		private System.HMI.Symbols.Base.SwitchButton swHab_03;
		private System.HMI.Symbols.Base.SwitchButton swHab_04;
		private System.HMI.Symbols.Base.SwitchButton swHab_05;
		private System.HMI.Symbols.Base.SwitchButton swHab_06;
		private System.HMI.Symbols.Base.SwitchButton swHab_07;
		private System.HMI.Symbols.Base.SwitchButton swHab_08;
		private System.HMI.Symbols.Base.SwitchButton swHab_09;
		private System.HMI.Symbols.Base.SwitchButton swHab_10;
		private System.HMI.Symbols.Base.SwitchButton swHab_11;
		private System.HMI.Symbols.Base.SwitchButton swHab_12;
		private System.HMI.Symbols.Base.SwitchButton swHab_13;
		private System.HMI.Symbols.Base.SwitchButton swHab_14;
		private System.HMI.Symbols.Base.SwitchButton swHab_15;
		private System.HMI.Symbols.Base.SwitchButton swHab_16;
		private System.HMI.Symbols.Base.SwitchButton swHab_17;
		private System.HMI.Symbols.Base.SwitchButton swHab_18;
		private System.HMI.Symbols.Base.SwitchButton swHab_19;
		private System.HMI.Symbols.Base.SwitchButton swHab_20;
		private System.HMI.Symbols.Base.SwitchButton swHab_21;
		private System.HMI.Symbols.Base.SwitchButton swHab_22;
		private System.HMI.Symbols.Base.SwitchButton swHab_23;
		private System.HMI.Symbols.Base.SwitchButton swHab_24;
		private System.HMI.Symbols.Base.SwitchButton swHab_25;
		private System.HMI.Symbols.Base.SwitchButton swHab_26;
		private System.HMI.Symbols.Base.SwitchButton swHab_27;
		private System.HMI.Symbols.Base.SwitchButton swHab_28;
		private System.HMI.Symbols.Base.SwitchButton swHab_29;
		private System.HMI.Symbols.Base.SwitchButton swHab_30;
		private System.HMI.Symbols.Base.SwitchButton swHab_31;
		private System.HMI.Symbols.Base.SwitchButton swHab_32;
		private System.HMI.Symbols.Base.SwitchButton swHab_33;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Group group3;
		private NxtControl.GuiFramework.Group group4;
		private NxtControl.GuiFramework.Group group5;
		private NxtControl.GuiFramework.Group group6;
		private NxtControl.GuiFramework.Group group7;
		private NxtControl.GuiFramework.Group group8;
		private NxtControl.GuiFramework.Group group9;
		#endregion
	}
}
