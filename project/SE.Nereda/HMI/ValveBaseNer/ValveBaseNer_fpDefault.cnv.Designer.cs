/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA489241
 * Date: 08/04/2021
 * Time: 12:10 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.ValveBaseNer
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
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.caixaEstado = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.textoComando = new NxtControl.GuiFramework.FreeText();
			this.textoSaida = new NxtControl.GuiFramework.FreeText();
			this.textoSituacao = new NxtControl.GuiFramework.FreeText();
			this.tituloModo = new NxtControl.GuiFramework.FreeText();
			this.btnManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutomatico = new NxtControl.GuiFramework.DrawnButton();
			this.tituloComando = new NxtControl.GuiFramework.FreeText();
			this.btnManOff = new NxtControl.GuiFramework.DrawnButton();
			this.btnManOn = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.btnAjustes = new NxtControl.GuiFramework.DrawnButton();
			this.fpNavigationPane = new SE.App2Base.Graphics.FpNavigationPane();
			this.ownerSwitch = new SE.App2Base.Graphics.OwnerSwitchBasic();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.Fb = new System.HMI.Symbols.Base.Execute<short>();
			this.CurrentSp = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.Sim = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maint = new System.HMI.Symbols.Base.Execute<bool>();
			this.Oos = new System.HMI.Symbols.Base.Execute<bool>();
			this.ExtOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOwnerBasic = new System.HMI.Symbols.Base.Execute<ushort>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<System.Int16>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(124D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaEstado
			// 
			this.caixaEstado.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(14D)), ((float)(22D)), ((float)(22D)));
			this.caixaEstado.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.caixaEstado.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaEstado.Name = "caixaEstado";
			this.caixaEstado.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(50D, 14D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "DESCONHECIDA";
			// 
			// textoComando
			// 
			this.textoComando.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoComando.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoComando.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.textoComando.Name = "textoComando";
			this.textoComando.Text = "Comando atual: -";
			// 
			// textoSaida
			// 
			this.textoSaida.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoSaida.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoSaida.Location = new NxtControl.Drawing.PointF(20D, 68D);
			this.textoSaida.Name = "textoSaida";
			this.textoSaida.Text = "Sa\u00edda atual: -";
			// 
			// textoSituacao
			// 
			this.textoSituacao.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoSituacao.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoSituacao.Location = new NxtControl.Drawing.PointF(20D, 92D);
			this.textoSituacao.Name = "textoSituacao";
			this.textoSituacao.Text = "";
			// 
			// tituloModo
			// 
			this.tituloModo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloModo.Location = new NxtControl.Drawing.PointF(20D, 136D);
			this.tituloModo.Name = "tituloModo";
			this.tituloModo.Text = "Modo de opera\u00e7\u00e3o";
			// 
			// btnManual
			// 
			this.btnManual.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(158D)), ((float)(150D)), ((float)(34D)));
			this.btnManual.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManual.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManual.Name = "btnManual";
			this.btnManual.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManual.Radius = 2D;
			this.btnManual.Text = "Manual";
			this.btnManual.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManual.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManual.Use3DEffect = false;
			this.btnManual.Click += new System.EventHandler(this.BtnManualClick);
			// 
			// btnAutomatico
			// 
			this.btnAutomatico.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(158D)), ((float)(150D)), ((float)(34D)));
			this.btnAutomatico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutomatico.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAutomatico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAutomatico.Name = "btnAutomatico";
			this.btnAutomatico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAutomatico.Radius = 2D;
			this.btnAutomatico.Text = "Autom\u00e1tico";
			this.btnAutomatico.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutomatico.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutomatico.Use3DEffect = false;
			this.btnAutomatico.Click += new System.EventHandler(this.BtnAutomaticoClick);
			// 
			// tituloComando
			// 
			this.tituloComando.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloComando.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloComando.Location = new NxtControl.Drawing.PointF(20D, 206D);
			this.tituloComando.Name = "tituloComando";
			this.tituloComando.Text = "Comando manual";
			// 
			// btnManOff
			// 
			this.btnManOff.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(228D)), ((float)(150D)), ((float)(34D)));
			this.btnManOff.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManOff.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManOff.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManOff.Name = "btnManOff";
			this.btnManOff.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManOff.Radius = 2D;
			this.btnManOff.Text = "Fechar";
			this.btnManOff.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManOff.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManOff.Use3DEffect = false;
			this.btnManOff.Click += new System.EventHandler(this.BtnManOffClick);
			// 
			// btnManOn
			// 
			this.btnManOn.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(228D)), ((float)(150D)), ((float)(34D)));
			this.btnManOn.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManOn.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManOn.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManOn.Name = "btnManOn";
			this.btnManOn.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManOn.Radius = 2D;
			this.btnManOn.Text = "Abrir";
			this.btnManOn.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManOn.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManOn.Use3DEffect = false;
			this.btnManOn.Click += new System.EventHandler(this.BtnManOnClick);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(280D)), ((float)(150D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer / Reset";
			this.btnReset.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(330D)), ((float)(320D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// btnAjustes
			// 
			this.btnAjustes.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(342D)), ((float)(150D)), ((float)(32D)));
			this.btnAjustes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAjustes.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnAjustes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAjustes.Name = "btnAjustes";
			this.btnAjustes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAjustes.Radius = 2D;
			this.btnAjustes.Text = "Ajustes";
			this.btnAjustes.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.Use3DEffect = false;
			this.btnAjustes.Click += new System.EventHandler(this.BtnAjustesClick);
			// 
			// fpNavigationPane
			// 
			this.fpNavigationPane.BeginInit();
			this.fpNavigationPane.Backwash.AliasName = "";
			this.fpNavigationPane.Backwash.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Backwash.InstanceName = null;
			this.fpNavigationPane.Backwash.ParentTitle = "Title";
			this.fpNavigationPane.Backwash.SymbolType = "SE.AppWWW.Symbols.Backwash.sDefault";
			this.fpNavigationPane.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 360D, 0D);
			this.fpNavigationPane.Failure.AliasName = "";
			this.fpNavigationPane.Failure.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Failure.InstanceName = null;
			this.fpNavigationPane.Failure.ParentTitle = "Title";
			this.fpNavigationPane.Failure.SymbolType = "SE.AppCommonProcess.Symbols.CondSum.sFailure";
			this.fpNavigationPane.Filtration.AliasName = "";
			this.fpNavigationPane.Filtration.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Filtration.InstanceName = null;
			this.fpNavigationPane.Filtration.ParentTitle = "Title";
			this.fpNavigationPane.Filtration.SymbolType = "SE.AppWWW.Symbols.Filtration.sDefault";
			this.fpNavigationPane.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.fpNavigationPane.HideSlider = false;
			this.fpNavigationPane.InputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Interlock.AliasName = "";
			this.fpNavigationPane.Interlock.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2L;
			this.fpNavigationPane.Interlock.InstanceName = null;
			this.fpNavigationPane.Interlock.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Open;
			this.fpNavigationPane.Interlock.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Close;
			this.fpNavigationPane.Interlock.ParentTitle = "Title";
			this.fpNavigationPane.Interlock.SymbolType = "SE.AppCommonProcess.Symbols.IlckCondSum.sInterlock";
			this.fpNavigationPane.IsBasic = false;
			this.fpNavigationPane.LocalPanel.AliasName = "";
			this.fpNavigationPane.LocalPanel.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot4R;
			this.fpNavigationPane.LocalPanel.InstanceName = null;
			this.fpNavigationPane.LocalPanel.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Open;
			this.fpNavigationPane.LocalPanel.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Close;
			this.fpNavigationPane.LocalPanel.ParentTitle = "Title";
			this.fpNavigationPane.LocalPanel.SymbolType = "SE.AppCommonProcess.Symbols.DevLp.sDefault";
			this.fpNavigationPane.Maintenance.AliasName = "";
			this.fpNavigationPane.Maintenance.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1L;
			this.fpNavigationPane.Maintenance.InstanceName = null;
			this.fpNavigationPane.Maintenance.ParentTitle = "Title";
			this.fpNavigationPane.Maintenance.SymbolType = "SE.AppCommonProcess.Symbols.DevMnt.sDefault";
			this.fpNavigationPane.Measures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Name = "fpNavigationPane";
			this.fpNavigationPane.OutputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Owner.AliasName = "";
			this.fpNavigationPane.Owner.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1R;
			this.fpNavigationPane.Owner.InstanceName = null;
			this.fpNavigationPane.Owner.ParentTitle = "Title";
			this.fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
			this.fpNavigationPane.Parameter.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ParentTitle = "";
			this.fpNavigationPane.Permissive.AliasName = "";
			this.fpNavigationPane.Permissive.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot3L;
			this.fpNavigationPane.Permissive.InstanceName = null;
			this.fpNavigationPane.Permissive.LabelActive1 = SE.App2Base.SupportClasses.CondActive1LabelText.Open;
			this.fpNavigationPane.Permissive.LabelPassive = SE.App2Base.SupportClasses.CondPassiveLabelText.Close;
			this.fpNavigationPane.Permissive.ParentTitle = "Title";
			this.fpNavigationPane.Permissive.SymbolType = "SE.AppCommonProcess.Symbols.PermCondSum.sPermissive";
			this.fpNavigationPane.SecMode = 6;
			this.fpNavigationPane.SecOwner = 3;
			this.fpNavigationPane.SecParameter = 12;
			this.fpNavigationPane.SecSetpoint = 3;
			this.fpNavigationPane.ShortFlush.AliasName = "";
			this.fpNavigationPane.ShortFlush.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ShortFlush.InstanceName = null;
			this.fpNavigationPane.ShortFlush.ParentTitle = "Title";
			this.fpNavigationPane.ShortFlush.SymbolType = "SE.AppWWW.Symbols.ShortFlush.sDefault";
			this.fpNavigationPane.Trend.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.OnParameterClick += new SE.App2Base.Graphics.FpNavigationPane.ParameterClicked(this.FpNavigationPaneOnParameterClick);
			this.fpNavigationPane.OnTrendClick += new SE.App2Base.Graphics.FpNavigationPane.TrendClicked(this.FpNavigationPaneOnTrendClick);
			this.fpNavigationPane.EndInit();
			// 
			// ownerSwitch
			// 
			this.ownerSwitch.BeginInit();
			this.ownerSwitch.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.05D, 0D, 0D, 0.05D, -60D, -60D);
			this.ownerSwitch.ExternalAvailable = false;
			this.ownerSwitch.InstanceName = "";
			this.ownerSwitch.Name = "ownerSwitch";
			this.ownerSwitch.SecOwner = 0;
			this.ownerSwitch.SecurityToken = ((uint)(4294967295u));
			this.ownerSwitch.EndInit();
			// 
			// NeedReset
			// 
			this.NeedReset.BeginInit();
			this.NeedReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.NeedReset.IsOnlyInput = true;
			this.NeedReset.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedReset.Name = "NeedReset";
			this.NeedReset.SecurityLevel = 0;
			this.NeedReset.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedReset.TagName = "NeedReset";
			this.NeedReset.Value = false;
			this.NeedReset.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NeedResetValueChanged);
			this.NeedReset.EndInit();
			// 
			// Fb
			// 
			this.Fb.BeginInit();
			this.Fb.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Fb.IsOnlyInput = true;
			this.Fb.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Fb.Name = "Fb";
			this.Fb.SecurityLevel = 0;
			this.Fb.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Fb.TagName = "FbStatus";
			this.Fb.Value = ((short)(0));
			this.Fb.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvValueChanged);
			this.Fb.EndInit();
			// 
			// CurrentSp
			// 
			this.CurrentSp.BeginInit();
			this.CurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSp.IsOnlyInput = true;
			this.CurrentSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSp.Name = "CurrentSp";
			this.CurrentSp.SecurityLevel = 0;
			this.CurrentSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSp.TagName = "CurrentSp";
			this.CurrentSp.Value = ((short)(0));
			this.CurrentSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpValueChanged);
			this.CurrentSp.EndInit();
			// 
			// TransFbStatus
			// 
			this.TransFbStatus.BeginInit();
			this.TransFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TransFbStatus.IsOnlyInput = true;
			this.TransFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TransFbStatus.Name = "TransFbStatus";
			this.TransFbStatus.SecurityLevel = 0;
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusChanged);
			this.TransFbStatus.EndInit();
			// 
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Sim.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Sim.Name = "Sim";
			this.Sim.SecurityLevel = 0;
			this.Sim.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Sim.TagName = "Simulation";
			this.Sim.Value = false;
			this.Sim.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SimValueChanged);
			this.Sim.EndInit();
			// 
			// Maint
			// 
			this.Maint.BeginInit();
			this.Maint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Maint.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Maint.Name = "Maint";
			this.Maint.SecurityLevel = 0;
			this.Maint.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Maint.TagName = "Maintenance";
			this.Maint.Value = false;
			this.Maint.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintValueChanged);
			this.Maint.EndInit();
			// 
			// Oos
			// 
			this.Oos.BeginInit();
			this.Oos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Oos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Oos.Name = "Oos";
			this.Oos.SecurityLevel = 0;
			this.Oos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Oos.TagName = "OutOfService";
			this.Oos.Value = false;
			this.Oos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OosValueChanged);
			this.Oos.EndInit();
			// 
			// ExtOwnerConnected
			// 
			this.ExtOwnerConnected.BeginInit();
			this.ExtOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ExtOwnerConnected.IsOnlyInput = true;
			this.ExtOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ExtOwnerConnected.Name = "ExtOwnerConnected";
			this.ExtOwnerConnected.SecurityLevel = 0;
			this.ExtOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ExtOwnerConnected.TagName = "";
			this.ExtOwnerConnected.Value = false;
			this.ExtOwnerConnected.EndInit();
			// 
			// CurrentOwnerBasic
			// 
			this.CurrentOwnerBasic.BeginInit();
			this.CurrentOwnerBasic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwnerBasic.IsOnlyInput = true;
			this.CurrentOwnerBasic.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwnerBasic.Name = "CurrentOwnerBasic";
			this.CurrentOwnerBasic.SecurityLevel = 0;
			this.CurrentOwnerBasic.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwnerBasic.TagName = "CurrentOwner";
			this.CurrentOwnerBasic.Value = ((ushort)(0));
			this.CurrentOwnerBasic.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerBasicValueChanged);
			this.CurrentOwnerBasic.EndInit();
			// 
			// CurrentOp
			// 
			this.CurrentOp.BeginInit();
			this.CurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOp.IsOnlyInput = true;
			this.CurrentOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOp.Name = "CurrentOp";
			this.CurrentOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOp.TagName = "CurrentOp";
			this.CurrentOp.Value = ((short)(0));
			this.CurrentOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOpValueChanged);
			this.CurrentOp.EndInit();
			// 
			// StdOwnerConnected
			// 
			this.StdOwnerConnected.BeginInit();
			this.StdOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.StdOwnerConnected.IsOnlyInput = true;
			this.StdOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StdOwnerConnected.Name = "StdOwnerConnected";
			this.StdOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.StdOwnerConnected.TagName = "StdOwnerConnected";
			this.StdOwnerConnected.Value = false;
			this.StdOwnerConnected.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StdOwnerConnectedValueChanged);
			this.StdOwnerConnected.EndInit();
			// 
			// FbOverride
			// 
			this.FbOverride.BeginInit();
			this.FbOverride.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbOverride.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbOverride.Name = "FbOverride";
			this.FbOverride.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbOverride.TagName = "FbOverride";
			this.FbOverride.Value = false;
			this.FbOverride.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverValueChanged);
			this.FbOverride.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(420D)), ((float)(386D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.caixaEstado,
			this.textoEstado,
			this.textoComando,
			this.textoSaida,
			this.textoSituacao,
			this.tituloModo,
			this.btnManual,
			this.btnAutomatico,
			this.tituloComando,
			this.btnManOff,
			this.btnManOn,
			this.btnReset,
			this.sep,
			this.btnAjustes,
			this.fpNavigationPane,
			this.ownerSwitch,
			this.NeedReset,
			this.Fb,
			this.CurrentSp,
			this.TransFbStatus,
			this.Sim,
			this.Maint,
			this.Oos,
			this.ExtOwnerConnected,
			this.CurrentOwnerBasic,
			this.CurrentOp,
			this.StdOwnerConnected,
			this.FbOverride});
			this.Size = new System.Drawing.Size(420, 386);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpDefaultSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpDefaultSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecuritySetpointChanged(this.FpDefaultSecuritySetpointChanged);
			this.UpdateOptionalService += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnUpdateOptionalService(this.FpDefaultUpdateOptionalService);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle caixaEstado;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.FreeText textoComando;
		private NxtControl.GuiFramework.FreeText textoSaida;
		private NxtControl.GuiFramework.FreeText textoSituacao;
		private NxtControl.GuiFramework.FreeText tituloModo;
		private NxtControl.GuiFramework.DrawnButton btnManual;
		private NxtControl.GuiFramework.DrawnButton btnAutomatico;
		private NxtControl.GuiFramework.FreeText tituloComando;
		private NxtControl.GuiFramework.DrawnButton btnManOff;
		private NxtControl.GuiFramework.DrawnButton btnManOn;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.DrawnButton btnAjustes;
		private SE.App2Base.Graphics.FpNavigationPane fpNavigationPane;
		private SE.App2Base.Graphics.OwnerSwitchBasic ownerSwitch;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private System.HMI.Symbols.Base.Execute<short> Fb;
		private System.HMI.Symbols.Base.Execute<short> CurrentSp;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private System.HMI.Symbols.Base.Execute<bool> Sim;
		private System.HMI.Symbols.Base.Execute<bool> Maint;
		private System.HMI.Symbols.Base.Execute<bool> Oos;
		private System.HMI.Symbols.Base.Execute<bool> ExtOwnerConnected;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwnerBasic;
		private System.HMI.Symbols.Base.Execute<System.Int16> CurrentOp;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;

		#endregion
	}
}
