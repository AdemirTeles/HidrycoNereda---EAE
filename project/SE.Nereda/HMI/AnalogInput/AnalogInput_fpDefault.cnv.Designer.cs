/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 4:25 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInput
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.tituloValor = new NxtControl.GuiFramework.FreeText();
			this.Pv = new System.HMI.Symbols.Base.FreeText<float>();
			this.Unit = new NxtControl.GuiFramework.FreeText();
			this.LevelStatus = new NxtControl.GuiFramework.FreeText();
			this.Override = new NxtControl.GuiFramework.FreeText();
			this.barFundo = new NxtControl.GuiFramework.Rectangle();
			this.ShowLevel = new NxtControl.GuiFramework.Rectangle();
			this.mLL = new NxtControl.GuiFramework.Rectangle();
			this.mL = new NxtControl.GuiFramework.Rectangle();
			this.mH = new NxtControl.GuiFramework.Rectangle();
			this.mHH = new NxtControl.GuiFramework.Rectangle();
			this.PvMin = new System.HMI.Symbols.Base.FreeText<float>();
			this.PvMax = new System.HMI.Symbols.Base.FreeText<float>();
			this.Unit2 = new NxtControl.GuiFramework.FreeText();
			this.Unit3 = new NxtControl.GuiFramework.FreeText();
			this.tituloAlarmes = new NxtControl.GuiFramework.FreeText();
			this.colLimite = new NxtControl.GuiFramework.FreeText();
			this.colEstado = new NxtControl.GuiFramework.FreeText();
			this.linhaHH = new NxtControl.GuiFramework.Rectangle();
			this.nomeHH = new NxtControl.GuiFramework.FreeText();
			this.fundoHH = new NxtControl.GuiFramework.Rectangle();
			this.highHighBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.estHH = new NxtControl.GuiFramework.FreeText();
			this.linhaH = new NxtControl.GuiFramework.Rectangle();
			this.nomeH = new NxtControl.GuiFramework.FreeText();
			this.fundoH = new NxtControl.GuiFramework.Rectangle();
			this.highBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.estH = new NxtControl.GuiFramework.FreeText();
			this.linhaL = new NxtControl.GuiFramework.Rectangle();
			this.nomeL = new NxtControl.GuiFramework.FreeText();
			this.fundoL = new NxtControl.GuiFramework.Rectangle();
			this.lowBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.estL = new NxtControl.GuiFramework.FreeText();
			this.linhaLL = new NxtControl.GuiFramework.Rectangle();
			this.nomeLL = new NxtControl.GuiFramework.FreeText();
			this.fundoLL = new NxtControl.GuiFramework.Rectangle();
			this.lowLowBtn = new SE.App2Base.Symbols.LimitAlarm.sButton();
			this.estLL = new NxtControl.GuiFramework.FreeText();
			this.linhaDesvio = new NxtControl.GuiFramework.Rectangle();
			this.nomeDesvio = new NxtControl.GuiFramework.FreeText();
			this.fundoDesvio = new NxtControl.GuiFramework.Rectangle();
			this.deviationBtn = new SE.App2Base.Symbols.DeviationAlarm.sButton();
			this.linhaTaxade = new NxtControl.GuiFramework.Rectangle();
			this.nomeTaxade = new NxtControl.GuiFramework.FreeText();
			this.fundoTaxade = new NxtControl.GuiFramework.Rectangle();
			this.rateOfChangeBtn = new SE.App2Base.Symbols.ROCAlarm.sButton();
			this.linhaFalha = new NxtControl.GuiFramework.Rectangle();
			this.nomeFalha = new NxtControl.GuiFramework.FreeText();
			this.estFalha = new NxtControl.GuiFramework.FreeText();
			this.tituloPontos = new NxtControl.GuiFramework.FreeText();
			this.lL1 = new NxtControl.GuiFramework.FreeText();
			this.LevelSp1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.L1v = new NxtControl.GuiFramework.Rectangle();
			this.lL1v = new NxtControl.GuiFramework.FreeText();
			this.lL2 = new NxtControl.GuiFramework.FreeText();
			this.LevelSp2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.L2v = new NxtControl.GuiFramework.Rectangle();
			this.lL2v = new NxtControl.GuiFramework.FreeText();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.btnAjustes = new NxtControl.GuiFramework.DrawnButton();
			this.btnGrafico = new NxtControl.GuiFramework.DrawnButton();
			this.AnalogInput = new SE.Nereda.Symbols.AnalogInputBase.sDefault();
			this.iUnit = new System.HMI.Symbols.Base.Execute<string>();
			this.iFlowSensor = new System.HMI.Symbols.Base.Execute<bool>();
			this.HiHiDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			this.HiDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			this.LoDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			this.LoLoDisabled = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(142D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tituloValor
			// 
			this.tituloValor.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tituloValor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tituloValor.Location = new NxtControl.Drawing.PointF(20D, 8D);
			this.tituloValor.Name = "tituloValor";
			this.tituloValor.Text = "Valor";
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DecimalPlacesCount = ((uint)(2u));
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 20D, 26D);
			this.Pv.Font = new NxtControl.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Bold);
			this.Pv.IsOnlyInput = true;
			this.Pv.Name = "Pv";
			this.Pv.Ranges.Clear();
			this.Pv.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.Pv.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.Pv.TagName = "Pv";
			this.Pv.TextAngle = 0F;
			this.Pv.EndInit();
			// 
			// Unit
			// 
			this.Unit.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.Unit.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.Unit.Location = new NxtControl.Drawing.PointF(190D, 36D);
			this.Unit.Name = "Unit";
			this.Unit.Text = "%";
			// 
			// LevelStatus
			// 
			this.LevelStatus.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.LevelStatus.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.LevelStatus.Location = new NxtControl.Drawing.PointF(20D, 70D);
			this.LevelStatus.Name = "LevelStatus";
			this.LevelStatus.Text = "";
			// 
			// Override
			// 
			this.Override.Color = new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite");
			this.Override.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.Override.Location = new NxtControl.Drawing.PointF(236D, 12D);
			this.Override.Name = "Override";
			this.Override.Text = "For\u00e7ado: habilitado";
			// 
			// barFundo
			// 
			this.barFundo.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(340D)), ((float)(14D)));
			this.barFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.barFundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barFundo.Name = "barFundo";
			this.barFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ShowLevel
			// 
			this.ShowLevel.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(340D)), ((float)(14D)));
			this.ShowLevel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(61)), ((byte)(61)), ((byte)(61))));
			this.ShowLevel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ShowLevel.Name = "ShowLevel";
			this.ShowLevel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ShowLevel.FillDirection = NxtControl.Drawing.FillDirection.LeftToRight;
			this.ShowLevel.FillPercent = 0F;
			// 
			// mLL
			// 
			this.mLL.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(94D)), ((float)(2D)), ((float)(22D)));
			this.mLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.mLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mLL.Name = "mLL";
			this.mLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// mL
			// 
			this.mL.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(94D)), ((float)(2D)), ((float)(22D)));
			this.mL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.mL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mL.Name = "mL";
			this.mL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// mH
			// 
			this.mH.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(94D)), ((float)(2D)), ((float)(22D)));
			this.mH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.mH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mH.Name = "mH";
			this.mH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// mHH
			// 
			this.mHH.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(94D)), ((float)(2D)), ((float)(22D)));
			this.mHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.mHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mHH.Name = "mHH";
			this.mHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DecimalPlacesCount = ((uint)(2u));
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 118D);
			this.PvMin.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.PvMin.IsOnlyInput = true;
			this.PvMin.Name = "PvMin";
			this.PvMin.Ranges.Clear();
			this.PvMin.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.PvMin.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.PvMin.TagName = "PvMin";
			this.PvMin.TextAngle = 0F;
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DecimalPlacesCount = ((uint)(2u));
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 300D, 118D);
			this.PvMax.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.PvMax.IsOnlyInput = true;
			this.PvMax.Name = "PvMax";
			this.PvMax.Ranges.Clear();
			this.PvMax.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary6));
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.PvMax.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.PvMax.TagName = "PvMax";
			this.PvMax.TextAngle = 0F;
			this.PvMax.EndInit();
			// 
			// Unit2
			// 
			this.Unit2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.Unit2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Unit2.Location = new NxtControl.Drawing.PointF(92D, 120D);
			this.Unit2.Name = "Unit2";
			this.Unit2.Text = "%";
			// 
			// Unit3
			// 
			this.Unit3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.Unit3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Unit3.Location = new NxtControl.Drawing.PointF(350D, 120D);
			this.Unit3.Name = "Unit3";
			this.Unit3.Text = "%";
			// 
			// tituloAlarmes
			// 
			this.tituloAlarmes.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloAlarmes.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloAlarmes.Location = new NxtControl.Drawing.PointF(20D, 154D);
			this.tituloAlarmes.Name = "tituloAlarmes";
			this.tituloAlarmes.Text = "Alarmes";
			// 
			// colLimite
			// 
			this.colLimite.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colLimite.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colLimite.Location = new NxtControl.Drawing.PointF(150D, 156D);
			this.colLimite.Name = "colLimite";
			this.colLimite.Text = "Limite (abrir)";
			// 
			// colEstado
			// 
			this.colEstado.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colEstado.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colEstado.Location = new NxtControl.Drawing.PointF(280D, 156D);
			this.colEstado.Name = "colEstado";
			this.colEstado.Text = "Estado";
			// 
			// linhaHH
			// 
			this.linhaHH.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(176D)), ((float)(356D)), ((float)(28D)));
			this.linhaHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaHH.Name = "linhaHH";
			this.linhaHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeHH
			// 
			this.nomeHH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeHH.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeHH.Location = new NxtControl.Drawing.PointF(24D, 181D);
			this.nomeHH.Name = "nomeHH";
			this.nomeHH.Text = "HH";
			// 
			// fundoHH
			// 
			this.fundoHH.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(178D)), ((float)(90D)), ((float)(24D)));
			this.fundoHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))));
			this.fundoHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundoHH.Name = "fundoHH";
			this.fundoHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// highHighBtn
			// 
			this.highHighBtn.BeginInit();
			this.highHighBtn.AlarmName = "HiHi";
			this.highHighBtn.DefaultInstanceName = null;
			this.highHighBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2D, 150D, 178D);
			this.highHighBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.highHighBtn.MyTagDisplayName = null;
			this.highHighBtn.Name = "highHighBtn";
			this.highHighBtn.SecurityToken = ((uint)(4294967295u));
			this.highHighBtn.TagName = "highHigh";
			this.highHighBtn.Unit = "";
			this.highHighBtn.EndInit();
			// 
			// estHH
			// 
			this.estHH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.estHH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estHH.Location = new NxtControl.Drawing.PointF(280D, 181D);
			this.estHH.Name = "estHH";
			this.estHH.Text = "\u2014";
			// 
			// linhaH
			// 
			this.linhaH.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(208D)), ((float)(356D)), ((float)(28D)));
			this.linhaH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaH.Name = "linhaH";
			this.linhaH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeH
			// 
			this.nomeH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeH.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeH.Location = new NxtControl.Drawing.PointF(24D, 213D);
			this.nomeH.Name = "nomeH";
			this.nomeH.Text = "H";
			// 
			// fundoH
			// 
			this.fundoH.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(210D)), ((float)(90D)), ((float)(24D)));
			this.fundoH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))));
			this.fundoH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundoH.Name = "fundoH";
			this.fundoH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// highBtn
			// 
			this.highBtn.BeginInit();
			this.highBtn.AlarmName = "Hi";
			this.highBtn.DefaultInstanceName = null;
			this.highBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2D, 150D, 210D);
			this.highBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.highBtn.MyTagDisplayName = null;
			this.highBtn.Name = "highBtn";
			this.highBtn.SecurityToken = ((uint)(4294967295u));
			this.highBtn.TagName = "high";
			this.highBtn.Unit = "";
			this.highBtn.EndInit();
			// 
			// estH
			// 
			this.estH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.estH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estH.Location = new NxtControl.Drawing.PointF(280D, 213D);
			this.estH.Name = "estH";
			this.estH.Text = "\u2014";
			// 
			// linhaL
			// 
			this.linhaL.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(240D)), ((float)(356D)), ((float)(28D)));
			this.linhaL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaL.Name = "linhaL";
			this.linhaL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeL
			// 
			this.nomeL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeL.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeL.Location = new NxtControl.Drawing.PointF(24D, 245D);
			this.nomeL.Name = "nomeL";
			this.nomeL.Text = "L";
			// 
			// fundoL
			// 
			this.fundoL.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(242D)), ((float)(90D)), ((float)(24D)));
			this.fundoL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))));
			this.fundoL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundoL.Name = "fundoL";
			this.fundoL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lowBtn
			// 
			this.lowBtn.BeginInit();
			this.lowBtn.AlarmName = "Lo";
			this.lowBtn.DefaultInstanceName = null;
			this.lowBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2D, 150D, 242D);
			this.lowBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.lowBtn.MyTagDisplayName = null;
			this.lowBtn.Name = "lowBtn";
			this.lowBtn.SecurityToken = ((uint)(4294967295u));
			this.lowBtn.TagName = "low";
			this.lowBtn.Unit = "";
			this.lowBtn.EndInit();
			// 
			// estL
			// 
			this.estL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.estL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estL.Location = new NxtControl.Drawing.PointF(280D, 245D);
			this.estL.Name = "estL";
			this.estL.Text = "\u2014";
			// 
			// linhaLL
			// 
			this.linhaLL.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(272D)), ((float)(356D)), ((float)(28D)));
			this.linhaLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaLL.Name = "linhaLL";
			this.linhaLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeLL
			// 
			this.nomeLL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeLL.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeLL.Location = new NxtControl.Drawing.PointF(24D, 277D);
			this.nomeLL.Name = "nomeLL";
			this.nomeLL.Text = "LL";
			// 
			// fundoLL
			// 
			this.fundoLL.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(274D)), ((float)(90D)), ((float)(24D)));
			this.fundoLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))));
			this.fundoLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundoLL.Name = "fundoLL";
			this.fundoLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lowLowBtn
			// 
			this.lowLowBtn.BeginInit();
			this.lowLowBtn.AlarmName = "LoLo";
			this.lowLowBtn.DefaultInstanceName = null;
			this.lowLowBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2D, 150D, 274D);
			this.lowLowBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.lowLowBtn.MyTagDisplayName = null;
			this.lowLowBtn.Name = "lowLowBtn";
			this.lowLowBtn.SecurityToken = ((uint)(4294967295u));
			this.lowLowBtn.TagName = "lowLow";
			this.lowLowBtn.Unit = "";
			this.lowLowBtn.EndInit();
			// 
			// estLL
			// 
			this.estLL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.estLL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estLL.Location = new NxtControl.Drawing.PointF(280D, 277D);
			this.estLL.Name = "estLL";
			this.estLL.Text = "\u2014";
			// 
			// linhaDesvio
			// 
			this.linhaDesvio.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(304D)), ((float)(356D)), ((float)(28D)));
			this.linhaDesvio.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaDesvio.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaDesvio.Name = "linhaDesvio";
			this.linhaDesvio.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeDesvio
			// 
			this.nomeDesvio.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeDesvio.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nomeDesvio.Location = new NxtControl.Drawing.PointF(24D, 309D);
			this.nomeDesvio.Name = "nomeDesvio";
			this.nomeDesvio.Text = "Desvio";
			// 
			// fundoDesvio
			// 
			this.fundoDesvio.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(306D)), ((float)(90D)), ((float)(24D)));
			this.fundoDesvio.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))));
			this.fundoDesvio.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundoDesvio.Name = "fundoDesvio";
			this.fundoDesvio.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// deviationBtn
			// 
			this.deviationBtn.BeginInit();
			this.deviationBtn.AlarmName = "TxtDeviation";
			this.deviationBtn.DefaultInstanceName = null;
			this.deviationBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2D, 150D, 306D);
			this.deviationBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.deviationBtn.MyTagDisplayName = null;
			this.deviationBtn.Name = "deviationBtn";
			this.deviationBtn.SecurityToken = ((uint)(4294967295u));
			this.deviationBtn.TagName = "deviation";
			this.deviationBtn.Unit = "";
			this.deviationBtn.EndInit();
			// 
			// linhaTaxade
			// 
			this.linhaTaxade.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(336D)), ((float)(356D)), ((float)(28D)));
			this.linhaTaxade.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaTaxade.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaTaxade.Name = "linhaTaxade";
			this.linhaTaxade.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeTaxade
			// 
			this.nomeTaxade.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeTaxade.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nomeTaxade.Location = new NxtControl.Drawing.PointF(24D, 341D);
			this.nomeTaxade.Name = "nomeTaxade";
			this.nomeTaxade.Text = "Taxa de varia\u00e7\u00e3o";
			// 
			// fundoTaxade
			// 
			this.fundoTaxade.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(338D)), ((float)(90D)), ((float)(24D)));
			this.fundoTaxade.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))));
			this.fundoTaxade.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundoTaxade.Name = "fundoTaxade";
			this.fundoTaxade.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rateOfChangeBtn
			// 
			this.rateOfChangeBtn.BeginInit();
			this.rateOfChangeBtn.AlarmName = "TxtROC";
			this.rateOfChangeBtn.DecimalPlacesCount = ((uint)(1u));
			this.rateOfChangeBtn.DefaultInstanceName = null;
			this.rateOfChangeBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2D, 150D, 338D);
			this.rateOfChangeBtn.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.rateOfChangeBtn.MaxLimitValue = 100F;
			this.rateOfChangeBtn.MinLimitValue = -100F;
			this.rateOfChangeBtn.MyTagDisplayName = null;
			this.rateOfChangeBtn.Name = "rateOfChangeBtn";
			this.rateOfChangeBtn.SecurityToken = ((uint)(4294967175u));
			this.rateOfChangeBtn.TagName = "rateOfChange";
			this.rateOfChangeBtn.Unit = "";
			this.rateOfChangeBtn.EndInit();
			// 
			// linhaFalha
			// 
			this.linhaFalha.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(368D)), ((float)(356D)), ((float)(28D)));
			this.linhaFalha.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaFalha.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaFalha.Name = "linhaFalha";
			this.linhaFalha.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeFalha
			// 
			this.nomeFalha.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeFalha.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.nomeFalha.Location = new NxtControl.Drawing.PointF(24D, 373D);
			this.nomeFalha.Name = "nomeFalha";
			this.nomeFalha.Text = "Falha do sensor";
			// 
			// estFalha
			// 
			this.estFalha.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.estFalha.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estFalha.Location = new NxtControl.Drawing.PointF(280D, 373D);
			this.estFalha.Name = "estFalha";
			this.estFalha.Text = "\u2014";
			// 
			// tituloPontos
			// 
			this.tituloPontos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloPontos.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloPontos.Location = new NxtControl.Drawing.PointF(20D, 408D);
			this.tituloPontos.Name = "tituloPontos";
			this.tituloPontos.Text = "Pontos de comuta\u00e7\u00e3o";
			// 
			// lL1
			// 
			this.lL1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lL1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.lL1.Location = new NxtControl.Drawing.PointF(24D, 437D);
			this.lL1.Name = "lL1";
			this.lL1.Text = "L1";
			// 
			// LevelSp1
			// 
			this.LevelSp1.BeginInit();
			this.LevelSp1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 110D, 432D);
			this.LevelSp1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.LevelSp1.MaximumTag = null;
			this.LevelSp1.MinimumTag = null;
			this.LevelSp1.Name = "LevelSp1";
			this.LevelSp1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.LevelSp1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.LevelSp1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.LevelSp1.TagName = "LevelSp1";
			this.LevelSp1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.LevelSp1.UseInputPad = true;
			this.LevelSp1.Value = 0F;
			this.LevelSp1.EndInit();
			// 
			// L1v
			// 
			this.L1v.Bounds = new NxtControl.Drawing.RectF(((float)(250D)), ((float)(437D)), ((float)(16D)), ((float)(16D)));
			this.L1v.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))));
			this.L1v.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.L1v.Name = "L1v";
			this.L1v.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lL1v
			// 
			this.lL1v.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lL1v.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lL1v.Location = new NxtControl.Drawing.PointF(274D, 437D);
			this.lL1v.Name = "lL1v";
			this.lL1v.Text = "atuado";
			// 
			// lL2
			// 
			this.lL2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lL2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.lL2.Location = new NxtControl.Drawing.PointF(24D, 469D);
			this.lL2.Name = "lL2";
			this.lL2.Text = "L2";
			// 
			// LevelSp2
			// 
			this.LevelSp2.BeginInit();
			this.LevelSp2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 110D, 464D);
			this.LevelSp2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.LevelSp2.MaximumTag = null;
			this.LevelSp2.MinimumTag = null;
			this.LevelSp2.Name = "LevelSp2";
			this.LevelSp2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.LevelSp2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.LevelSp2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.LevelSp2.TagName = "LevelSp2";
			this.LevelSp2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.LevelSp2.UseInputPad = true;
			this.LevelSp2.Value = 0F;
			this.LevelSp2.EndInit();
			// 
			// L2v
			// 
			this.L2v.Bounds = new NxtControl.Drawing.RectF(((float)(250D)), ((float)(469D)), ((float)(16D)), ((float)(16D)));
			this.L2v.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(54)), ((byte)(54)), ((byte)(54))));
			this.L2v.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.L2v.Name = "L2v";
			this.L2v.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lL2v
			// 
			this.lL2v.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lL2v.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lL2v.Location = new NxtControl.Drawing.PointF(274D, 469D);
			this.lL2v.Name = "lL2v";
			this.lL2v.Text = "atuado";
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(502D)), ((float)(340D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// btnAjustes
			// 
			this.btnAjustes.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(514D)), ((float)(165D)), ((float)(32D)));
			this.btnAjustes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAjustes.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnAjustes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAjustes.Name = "btnAjustes";
			this.btnAjustes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAjustes.Radius = 2D;
			this.btnAjustes.Text = "Ajustes";
			this.btnAjustes.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.Use3DEffect = false;
			this.btnAjustes.Click += new System.EventHandler(this.SettingsClick);
			// 
			// btnGrafico
			// 
			this.btnGrafico.Bounds = new NxtControl.Drawing.RectF(((float)(195D)), ((float)(514D)), ((float)(165D)), ((float)(32D)));
			this.btnGrafico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnGrafico.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnGrafico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnGrafico.Name = "btnGrafico";
			this.btnGrafico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnGrafico.Radius = 2D;
			this.btnGrafico.Text = "Gr\u00e1fico";
			this.btnGrafico.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnGrafico.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnGrafico.Use3DEffect = false;
			this.btnGrafico.Click += new System.EventHandler(this.TrendsClick);
			// 
			// AnalogInput
			// 
			this.AnalogInput.BeginInit();
			this.AnalogInput.DefaultInstanceName = null;
			this.AnalogInput.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.1431221705371972D, 0D, 0D, 0.13525045115765141D, -30D, 184D);
			this.AnalogInput.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.AnalogInput.MyTagDisplayName = null;
			this.AnalogInput.Name = "AnalogInput";
			this.AnalogInput.SecurityToken = ((uint)(4294967175u));
			this.AnalogInput.TagName = "AnalogInput";
			this.AnalogInput.EndInit();
			// 
			// iUnit
			// 
			this.iUnit.BeginInit();
			this.iUnit.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.iUnit.IsOnlyInput = true;
			this.iUnit.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.iUnit.Name = "iUnit";
			this.iUnit.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.iUnit.TagName = "iUnit";
			this.iUnit.Value = null;
			this.iUnit.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IUnitValueChanged);
			this.iUnit.EndInit();
			// 
			// iFlowSensor
			// 
			this.iFlowSensor.BeginInit();
			this.iFlowSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.iFlowSensor.IsOnlyInput = true;
			this.iFlowSensor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.iFlowSensor.Name = "iFlowSensor";
			this.iFlowSensor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.iFlowSensor.TagName = "iFlowSensor";
			this.iFlowSensor.Value = false;
			this.iFlowSensor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IFlowSensorValueChanged);
			this.iFlowSensor.EndInit();
			// 
			// HiHiDisabled
			// 
			this.HiHiDisabled.BeginInit();
			this.HiHiDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.HiHiDisabled.IsOnlyInput = true;
			this.HiHiDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.HiHiDisabled.Name = "HiHiDisabled";
			this.HiHiDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.HiHiDisabled.TagName = "HiHiDisabled";
			this.HiHiDisabled.Value = false;
			this.HiHiDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HiHiDisabledValueChanged);
			this.HiHiDisabled.EndInit();
			// 
			// HiDisabled
			// 
			this.HiDisabled.BeginInit();
			this.HiDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.HiDisabled.IsOnlyInput = true;
			this.HiDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.HiDisabled.Name = "HiDisabled";
			this.HiDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.HiDisabled.TagName = "HiDisabled";
			this.HiDisabled.Value = false;
			this.HiDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HiDisabledValueChanged);
			this.HiDisabled.EndInit();
			// 
			// LoDisabled
			// 
			this.LoDisabled.BeginInit();
			this.LoDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.LoDisabled.IsOnlyInput = true;
			this.LoDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LoDisabled.Name = "LoDisabled";
			this.LoDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LoDisabled.TagName = "LoDisabled";
			this.LoDisabled.Value = false;
			this.LoDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LoDisabledValueChanged);
			this.LoDisabled.EndInit();
			// 
			// LoLoDisabled
			// 
			this.LoLoDisabled.BeginInit();
			this.LoLoDisabled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.LoLoDisabled.IsOnlyInput = true;
			this.LoLoDisabled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.LoLoDisabled.Name = "LoLoDisabled";
			this.LoLoDisabled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.LoLoDisabled.TagName = "LoLoDisabled";
			this.LoLoDisabled.Value = false;
			this.LoLoDisabled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LoLoDisabledValueChanged);
			this.LoLoDisabled.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(560D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.tituloValor,
			this.Pv,
			this.Unit,
			this.LevelStatus,
			this.Override,
			this.barFundo,
			this.ShowLevel,
			this.mLL,
			this.mL,
			this.mH,
			this.mHH,
			this.PvMin,
			this.PvMax,
			this.Unit2,
			this.Unit3,
			this.tituloAlarmes,
			this.colLimite,
			this.colEstado,
			this.linhaHH,
			this.nomeHH,
			this.fundoHH,
			this.highHighBtn,
			this.estHH,
			this.linhaH,
			this.nomeH,
			this.fundoH,
			this.highBtn,
			this.estH,
			this.linhaL,
			this.nomeL,
			this.fundoL,
			this.lowBtn,
			this.estL,
			this.linhaLL,
			this.nomeLL,
			this.fundoLL,
			this.lowLowBtn,
			this.estLL,
			this.linhaDesvio,
			this.nomeDesvio,
			this.fundoDesvio,
			this.deviationBtn,
			this.linhaTaxade,
			this.nomeTaxade,
			this.fundoTaxade,
			this.rateOfChangeBtn,
			this.linhaFalha,
			this.nomeFalha,
			this.estFalha,
			this.tituloPontos,
			this.lL1,
			this.LevelSp1,
			this.L1v,
			this.lL1v,
			this.lL2,
			this.LevelSp2,
			this.L2v,
			this.lL2v,
			this.sep,
			this.btnAjustes,
			this.btnGrafico,
			this.AnalogInput,
			this.iUnit,
			this.iFlowSensor,
			this.HiHiDisabled,
			this.HiDisabled,
			this.LoDisabled,
			this.LoLoDisabled});
			this.Size = new System.Drawing.Size(380, 560);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText tituloValor;
		private System.HMI.Symbols.Base.FreeText<float> Pv;
		private NxtControl.GuiFramework.FreeText Unit;
		private NxtControl.GuiFramework.FreeText LevelStatus;
		private NxtControl.GuiFramework.FreeText Override;
		private NxtControl.GuiFramework.Rectangle barFundo;
		private NxtControl.GuiFramework.Rectangle ShowLevel;
		private NxtControl.GuiFramework.Rectangle mLL;
		private NxtControl.GuiFramework.Rectangle mL;
		private NxtControl.GuiFramework.Rectangle mH;
		private NxtControl.GuiFramework.Rectangle mHH;
		private System.HMI.Symbols.Base.FreeText<float> PvMin;
		private System.HMI.Symbols.Base.FreeText<float> PvMax;
		private NxtControl.GuiFramework.FreeText Unit2;
		private NxtControl.GuiFramework.FreeText Unit3;
		private NxtControl.GuiFramework.FreeText tituloAlarmes;
		private NxtControl.GuiFramework.FreeText colLimite;
		private NxtControl.GuiFramework.FreeText colEstado;
		private NxtControl.GuiFramework.Rectangle linhaHH;
		private NxtControl.GuiFramework.FreeText nomeHH;
		private NxtControl.GuiFramework.Rectangle fundoHH;
		private SE.App2Base.Symbols.LimitAlarm.sButton highHighBtn;
		private NxtControl.GuiFramework.FreeText estHH;
		private NxtControl.GuiFramework.Rectangle linhaH;
		private NxtControl.GuiFramework.FreeText nomeH;
		private NxtControl.GuiFramework.Rectangle fundoH;
		private SE.App2Base.Symbols.LimitAlarm.sButton highBtn;
		private NxtControl.GuiFramework.FreeText estH;
		private NxtControl.GuiFramework.Rectangle linhaL;
		private NxtControl.GuiFramework.FreeText nomeL;
		private NxtControl.GuiFramework.Rectangle fundoL;
		private SE.App2Base.Symbols.LimitAlarm.sButton lowBtn;
		private NxtControl.GuiFramework.FreeText estL;
		private NxtControl.GuiFramework.Rectangle linhaLL;
		private NxtControl.GuiFramework.FreeText nomeLL;
		private NxtControl.GuiFramework.Rectangle fundoLL;
		private SE.App2Base.Symbols.LimitAlarm.sButton lowLowBtn;
		private NxtControl.GuiFramework.FreeText estLL;
		private NxtControl.GuiFramework.Rectangle linhaDesvio;
		private NxtControl.GuiFramework.FreeText nomeDesvio;
		private NxtControl.GuiFramework.Rectangle fundoDesvio;
		private SE.App2Base.Symbols.DeviationAlarm.sButton deviationBtn;
		private NxtControl.GuiFramework.Rectangle linhaTaxade;
		private NxtControl.GuiFramework.FreeText nomeTaxade;
		private NxtControl.GuiFramework.Rectangle fundoTaxade;
		private SE.App2Base.Symbols.ROCAlarm.sButton rateOfChangeBtn;
		private NxtControl.GuiFramework.Rectangle linhaFalha;
		private NxtControl.GuiFramework.FreeText nomeFalha;
		private NxtControl.GuiFramework.FreeText estFalha;
		private NxtControl.GuiFramework.FreeText tituloPontos;
		private NxtControl.GuiFramework.FreeText lL1;
		private System.HMI.Symbols.Base.TextBox<float> LevelSp1;
		private NxtControl.GuiFramework.Rectangle L1v;
		private NxtControl.GuiFramework.FreeText lL1v;
		private NxtControl.GuiFramework.FreeText lL2;
		private System.HMI.Symbols.Base.TextBox<float> LevelSp2;
		private NxtControl.GuiFramework.Rectangle L2v;
		private NxtControl.GuiFramework.FreeText lL2v;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.DrawnButton btnAjustes;
		private NxtControl.GuiFramework.DrawnButton btnGrafico;
		private SE.Nereda.Symbols.AnalogInputBase.sDefault AnalogInput;
		private System.HMI.Symbols.Base.Execute<string> iUnit;
		private System.HMI.Symbols.Base.Execute<bool> iFlowSensor;
		private System.HMI.Symbols.Base.Execute<bool> HiHiDisabled;
		private System.HMI.Symbols.Base.Execute<bool> HiDisabled;
		private System.HMI.Symbols.Base.Execute<bool> LoDisabled;
		private System.HMI.Symbols.Base.Execute<bool> LoLoDisabled;

		#endregion
	}
}
