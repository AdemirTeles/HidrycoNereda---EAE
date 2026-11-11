/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA397657
 * Date: 09/04/2021
 * Time: 2:17 pm
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
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.secReal = new NxtControl.GuiFramework.FreeText();
			this.lFbMode = new NxtControl.GuiFramework.FreeText();
			this.combofbmode = new System.HMI.Symbols.Base.DropDown<byte>();
			this.lMon = new NxtControl.GuiFramework.FreeText();
			this.txtMonitorTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.lTrip = new NxtControl.GuiFramework.FreeText();
			this.txtTripTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.lReset = new NxtControl.GuiFramework.FreeText();
			this.ConfResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.secModos = new NxtControl.GuiFramework.FreeText();
			this.lSim = new NxtControl.GuiFramework.FreeText();
			this.Sim = new System.HMI.Symbols.Base.SwitchButton();
			this.lOver = new NxtControl.GuiFramework.FreeText();
			this.Over = new System.HMI.Symbols.Base.SwitchButton();
			this.lMaint = new NxtControl.GuiFramework.FreeText();
			this.Maint = new System.HMI.Symbols.Base.SwitchButton();
			this.lOos = new NxtControl.GuiFramework.FreeText();
			this.Oos = new System.HMI.Symbols.Base.SwitchButton();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<bool>();
			this.execute_12 = new System.HMI.Symbols.Base.Execute<bool>();
			this.execute_13 = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.ValveCmdType = new System.HMI.Symbols.Base.Execute<bool>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes da v\u00e1lvula";
			// 
			// secReal
			// 
			this.secReal.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.secReal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.secReal.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.secReal.Name = "secReal";
			this.secReal.Text = "Supervis\u00e3o da realimenta\u00e7\u00e3o";
			// 
			// lFbMode
			// 
			this.lFbMode.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFbMode.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lFbMode.Location = new NxtControl.Drawing.PointF(20D, 77D);
			this.lFbMode.Name = "lFbMode";
			this.lFbMode.Text = "Modo de realimenta\u00e7\u00e3o";
			// 
			// combofbmode
			// 
			this.combofbmode.BeginInit();
			this.combofbmode.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.combofbmode.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.9D, 220D, 72D);
			this.combofbmode.Font = new NxtControl.Drawing.Font("ComboBoxFont");
			this.combofbmode.Name = "combofbmode";
			this.combofbmode.SecurityLevel = 12;
			this.combofbmode.TagName = "FbMode";
			this.combofbmode.TextColor = new NxtControl.Drawing.Color("ComboBoxTextColor");
			this.combofbmode.TextPadding = new NxtControl.Drawing.Padding(2);
			this.combofbmode.Value = ((byte)(0));
			this.combofbmode.EndInit();
			// 
			// lMon
			// 
			this.lMon.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMon.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMon.Location = new NxtControl.Drawing.PointF(20D, 113D);
			this.lMon.Name = "lMon";
			this.lMon.Text = "Tempo de monitoramento";
			// 
			// txtMonitorTime
			// 
			this.txtMonitorTime.BeginInit();
			this.txtMonitorTime.DecimalPlacesCount = ((uint)(0u));
			this.txtMonitorTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 108D);
			this.txtMonitorTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtMonitorTime.MaximumTag = null;
			this.txtMonitorTime.Minimum = 1;
			this.txtMonitorTime.MinimumTag = null;
			this.txtMonitorTime.Name = "txtMonitorTime";
			this.txtMonitorTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMonitorTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMonitorTime.SecurityLevel = 12;
			this.txtMonitorTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMonitorTime.Suffix = "s";
			this.txtMonitorTime.TagName = "MonTime";
			this.txtMonitorTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMonitorTime.UseInputPad = true;
			this.txtMonitorTime.UseRange = true;
			this.txtMonitorTime.Value = 0;
			this.txtMonitorTime.EndInit();
			// 
			// lTrip
			// 
			this.lTrip.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTrip.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lTrip.Location = new NxtControl.Drawing.PointF(20D, 149D);
			this.lTrip.Name = "lTrip";
			this.lTrip.Text = "Tempo de disparo";
			// 
			// txtTripTime
			// 
			this.txtTripTime.BeginInit();
			this.txtTripTime.DecimalPlacesCount = ((uint)(0u));
			this.txtTripTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 144D);
			this.txtTripTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtTripTime.MaximumTag = null;
			this.txtTripTime.Minimum = 1;
			this.txtTripTime.MinimumTag = null;
			this.txtTripTime.Name = "txtTripTime";
			this.txtTripTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtTripTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtTripTime.SecurityLevel = 12;
			this.txtTripTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtTripTime.Suffix = "s";
			this.txtTripTime.TagName = "TripTime";
			this.txtTripTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtTripTime.UseInputPad = true;
			this.txtTripTime.UseRange = true;
			this.txtTripTime.Value = 0;
			this.txtTripTime.EndInit();
			// 
			// lReset
			// 
			this.lReset.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lReset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lReset.Location = new NxtControl.Drawing.PointF(20D, 185D);
			this.lReset.Name = "lReset";
			this.lReset.Text = "Exige reset: falha de realim.";
			// 
			// ConfResetReq
			// 
			this.ConfResetReq.BeginInit();
			this.ConfResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 180D);
			this.ConfResetReq.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseText = "N\u00e3o";
			this.ConfResetReq.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ConfResetReq.Name = "ConfResetReq";
			this.ConfResetReq.SecurityLevel = 0;
			this.ConfResetReq.TagName = "ConfResetReq";
			this.ConfResetReq.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueText = "Sim";
			this.ConfResetReq.Value = false;
			this.ConfResetReq.EndInit();
			// 
			// secModos
			// 
			this.secModos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.secModos.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.secModos.Location = new NxtControl.Drawing.PointF(20D, 224D);
			this.secModos.Name = "secModos";
			this.secModos.Text = "Modos especiais";
			// 
			// lSim
			// 
			this.lSim.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSim.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSim.Location = new NxtControl.Drawing.PointF(20D, 253D);
			this.lSim.Name = "lSim";
			this.lSim.Text = "Simula\u00e7\u00e3o";
			// 
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 248D);
			this.Sim.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.FalseText = "N\u00e3o";
			this.Sim.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Sim.Name = "Sim";
			this.Sim.SecurityLevel = 0;
			this.Sim.TagName = "Simulation";
			this.Sim.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Sim.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Sim.TrueText = "Sim";
			this.Sim.Value = false;
			this.Sim.EndInit();
			// 
			// lOver
			// 
			this.lOver.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lOver.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lOver.Location = new NxtControl.Drawing.PointF(20D, 289D);
			this.lOver.Name = "lOver";
			this.lOver.Text = "Realimenta\u00e7\u00e3o for\u00e7ada";
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 284D);
			this.Over.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.FalseText = "N\u00e3o";
			this.Over.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Over.Name = "Over";
			this.Over.SecurityLevel = 0;
			this.Over.TagName = "FbOverride";
			this.Over.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Over.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Over.TrueText = "Sim";
			this.Over.Value = false;
			this.Over.EndInit();
			// 
			// lMaint
			// 
			this.lMaint.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMaint.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMaint.Location = new NxtControl.Drawing.PointF(20D, 325D);
			this.lMaint.Name = "lMaint";
			this.lMaint.Text = "Manuten\u00e7\u00e3o";
			// 
			// Maint
			// 
			this.Maint.BeginInit();
			this.Maint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 320D);
			this.Maint.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.FalseText = "N\u00e3o";
			this.Maint.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Maint.Name = "Maint";
			this.Maint.SecurityLevel = 0;
			this.Maint.TagName = "Maintenance";
			this.Maint.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Maint.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Maint.TrueText = "Sim";
			this.Maint.Value = false;
			this.Maint.EndInit();
			// 
			// lOos
			// 
			this.lOos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lOos.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lOos.Location = new NxtControl.Drawing.PointF(20D, 361D);
			this.lOos.Name = "lOos";
			this.lOos.Text = "Fora de servi\u00e7o";
			// 
			// Oos
			// 
			this.Oos.BeginInit();
			this.Oos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 356D);
			this.Oos.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Oos.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Oos.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Oos.FalseText = "N\u00e3o";
			this.Oos.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Oos.Name = "Oos";
			this.Oos.SecurityLevel = 0;
			this.Oos.TagName = "OutOfService";
			this.Oos.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Oos.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Oos.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Oos.TrueText = "Sim";
			this.Oos.Value = false;
			this.Oos.EndInit();
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.SecurityLevel = 0;
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "Simulation";
			this.execute_11.Value = false;
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SimValueChanged);
			this.execute_11.EndInit();
			// 
			// execute_12
			// 
			this.execute_12.BeginInit();
			this.execute_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_12.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_12.Name = "execute_12";
			this.execute_12.SecurityLevel = 0;
			this.execute_12.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_12.TagName = "FbOverride";
			this.execute_12.Value = false;
			this.execute_12.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OverValueChanged);
			this.execute_12.EndInit();
			// 
			// execute_13
			// 
			this.execute_13.BeginInit();
			this.execute_13.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_13.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_13.Name = "execute_13";
			this.execute_13.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_13.TagName = "Maintenance";
			this.execute_13.Value = false;
			this.execute_13.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintValueChanged);
			this.execute_13.EndInit();
			// 
			// FbStatus
			// 
			this.FbStatus.BeginInit();
			this.FbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbStatus.IsOnlyInput = true;
			this.FbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbStatus.Name = "FbStatus";
			this.FbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbStatus.TagName = "FbStatus";
			this.FbStatus.Value = ((short)(0));
			this.FbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbStatusValueChanged);
			this.FbStatus.EndInit();
			// 
			// ValveCmdType
			// 
			this.ValveCmdType.BeginInit();
			this.ValveCmdType.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 238D, 544D);
			this.ValveCmdType.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ValveCmdType.Name = "ValveCmdType";
			this.ValveCmdType.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ValveCmdType.TagName = "ValveCmdType";
			this.ValveCmdType.Value = false;
			this.ValveCmdType.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ValveTypeValueChanged);
			this.ValveCmdType.EndInit();
			// 
			// TransFbStatus
			// 
			this.TransFbStatus.BeginInit();
			this.TransFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 134D, 218D);
			this.TransFbStatus.IsOnlyInput = true;
			this.TransFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TransFbStatus.Name = "TransFbStatus";
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusValueChanged);
			this.TransFbStatus.EndInit();
			// 
			// OutOfService
			// 
			this.OutOfService.BeginInit();
			this.OutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 197D, 281D);
			this.OutOfService.Location = new NxtControl.Drawing.PointF(197D, 281D);
			this.OutOfService.Name = "OutOfService";
			this.OutOfService.Size = new NxtControl.Drawing.SizeF(100D, 20D);
			this.OutOfService.TagName = "OutOfService";
			this.OutOfService.Value = false;
			this.OutOfService.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OosOutputValueChanged);
			this.OutOfService.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(400D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.secReal,
			this.lFbMode,
			this.combofbmode,
			this.lMon,
			this.txtMonitorTime,
			this.lTrip,
			this.txtTripTime,
			this.lReset,
			this.ConfResetReq,
			this.secModos,
			this.lSim,
			this.Sim,
			this.lOver,
			this.Over,
			this.lMaint,
			this.Maint,
			this.lOos,
			this.Oos,
			this.execute_11,
			this.execute_12,
			this.execute_13,
			this.FbStatus,
			this.ValveCmdType,
			this.TransFbStatus,
			this.OutOfService});
			this.Size = new System.Drawing.Size(360, 400);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpParameterSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);
			this.SecurityModeChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityModeChanged(this.FpParameterSecurityModeChanged);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText secReal;
		private NxtControl.GuiFramework.FreeText lFbMode;
		private System.HMI.Symbols.Base.DropDown<byte> combofbmode;
		private NxtControl.GuiFramework.FreeText lMon;
		private System.HMI.Symbols.Base.TextBox<int> txtMonitorTime;
		private NxtControl.GuiFramework.FreeText lTrip;
		private System.HMI.Symbols.Base.TextBox<int> txtTripTime;
		private NxtControl.GuiFramework.FreeText lReset;
		private System.HMI.Symbols.Base.SwitchButton ConfResetReq;
		private NxtControl.GuiFramework.FreeText secModos;
		private NxtControl.GuiFramework.FreeText lSim;
		private System.HMI.Symbols.Base.SwitchButton Sim;
		private NxtControl.GuiFramework.FreeText lOver;
		private System.HMI.Symbols.Base.SwitchButton Over;
		private NxtControl.GuiFramework.FreeText lMaint;
		private System.HMI.Symbols.Base.SwitchButton Maint;
		private NxtControl.GuiFramework.FreeText lOos;
		private System.HMI.Symbols.Base.SwitchButton Oos;
		private System.HMI.Symbols.Base.Execute<bool> execute_11;
		private System.HMI.Symbols.Base.Execute<bool> execute_12;
		private System.HMI.Symbols.Base.Execute<bool> execute_13;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<bool> ValveCmdType;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;

		#endregion
	}
}
