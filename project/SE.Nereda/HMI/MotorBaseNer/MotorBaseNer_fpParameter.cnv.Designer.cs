/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA397657
 * Date: 08/04/2021
 * Time: 3:24 pm
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.MotorBaseNer
{
	/// <summary>
	/// Summary description for fpParamater.
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
			this.sec0_Supervis = new NxtControl.GuiFramework.FreeText();
			this.lMon = new NxtControl.GuiFramework.FreeText();
			this.txtMonTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.lTrip = new NxtControl.GuiFramework.FreeText();
			this.txtTripTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.lFbReset = new NxtControl.GuiFramework.FreeText();
			this.ConfResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.lFailReset = new NxtControl.GuiFramework.FreeText();
			this.FailResetReq = new System.HMI.Symbols.Base.SwitchButton();
			this.sec0_Modosesp = new NxtControl.GuiFramework.FreeText();
			this.lSim = new NxtControl.GuiFramework.FreeText();
			this.Sim = new System.HMI.Symbols.Base.SwitchButton();
			this.lOver = new NxtControl.GuiFramework.FreeText();
			this.Over = new System.HMI.Symbols.Base.SwitchButton();
			this.lMaint = new NxtControl.GuiFramework.FreeText();
			this.Maint = new System.HMI.Symbols.Base.SwitchButton();
			this.lOos = new NxtControl.GuiFramework.FreeText();
			this.SwOos = new System.HMI.Symbols.Base.SwitchButton();
			this.Pv = new System.HMI.Symbols.Base.Execute<short>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<bool>();
			this.execute_13 = new System.HMI.Symbols.Base.Execute<bool>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes do motor";
			// 
			// sec0_Supervis
			// 
			this.sec0_Supervis.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec0_Supervis.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec0_Supervis.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.sec0_Supervis.Name = "sec0_Supervis";
			this.sec0_Supervis.Text = "Supervis\u00e3o";
			// 
			// lMon
			// 
			this.lMon.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMon.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMon.Location = new NxtControl.Drawing.PointF(20D, 77D);
			this.lMon.Name = "lMon";
			this.lMon.Text = "Tempo de monitoramento";
			// 
			// txtMonTime
			// 
			this.txtMonTime.BeginInit();
			this.txtMonTime.DecimalPlacesCount = ((uint)(0u));
			this.txtMonTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 72D);
			this.txtMonTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtMonTime.MaximumTag = null;
			this.txtMonTime.MinimumTag = null;
			this.txtMonTime.Name = "txtMonTime";
			this.txtMonTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMonTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMonTime.SecurityLevel = 6;
			this.txtMonTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMonTime.Suffix = "s";
			this.txtMonTime.TagName = "MonTime";
			this.txtMonTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMonTime.UseInputPad = true;
			this.txtMonTime.UseRange = true;
			this.txtMonTime.Value = 0;
			this.txtMonTime.EndInit();
			// 
			// lTrip
			// 
			this.lTrip.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTrip.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lTrip.Location = new NxtControl.Drawing.PointF(20D, 111D);
			this.lTrip.Name = "lTrip";
			this.lTrip.Text = "Tempo de disparo";
			// 
			// txtTripTime
			// 
			this.txtTripTime.BeginInit();
			this.txtTripTime.DecimalPlacesCount = ((uint)(0u));
			this.txtTripTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 106D);
			this.txtTripTime.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtTripTime.MaximumTag = null;
			this.txtTripTime.MinimumTag = null;
			this.txtTripTime.Name = "txtTripTime";
			this.txtTripTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtTripTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtTripTime.SecurityLevel = 6;
			this.txtTripTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtTripTime.Suffix = "s";
			this.txtTripTime.TagName = "TripTime";
			this.txtTripTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtTripTime.UseInputPad = true;
			this.txtTripTime.UseRange = true;
			this.txtTripTime.Value = 0;
			this.txtTripTime.EndInit();
			// 
			// lFbReset
			// 
			this.lFbReset.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFbReset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lFbReset.Location = new NxtControl.Drawing.PointF(20D, 145D);
			this.lFbReset.Name = "lFbReset";
			this.lFbReset.Text = "Exige reset: falha de realim.";
			// 
			// ConfResetReq
			// 
			this.ConfResetReq.BeginInit();
			this.ConfResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 140D);
			this.ConfResetReq.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.FalseText = "N\u00e3o";
			this.ConfResetReq.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ConfResetReq.Name = "ConfResetReq";
			this.ConfResetReq.SecurityLevel = 12;
			this.ConfResetReq.TagName = "ConfResetReq";
			this.ConfResetReq.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.ConfResetReq.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ConfResetReq.TrueText = "Sim";
			this.ConfResetReq.Value = false;
			this.ConfResetReq.EndInit();
			// 
			// lFailReset
			// 
			this.lFailReset.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFailReset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lFailReset.Location = new NxtControl.Drawing.PointF(20D, 179D);
			this.lFailReset.Name = "lFailReset";
			this.lFailReset.Text = "Exige reset: falha do equip.";
			// 
			// FailResetReq
			// 
			this.FailResetReq.BeginInit();
			this.FailResetReq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 174D);
			this.FailResetReq.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FailResetReq.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.FalseText = "N\u00e3o";
			this.FailResetReq.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.FailResetReq.Name = "FailResetReq";
			this.FailResetReq.SecurityLevel = 12;
			this.FailResetReq.TagName = "FailResetReq";
			this.FailResetReq.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.FailResetReq.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.FailResetReq.TrueText = "Sim";
			this.FailResetReq.Value = false;
			this.FailResetReq.EndInit();
			// 
			// sec0_Modosesp
			// 
			this.sec0_Modosesp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec0_Modosesp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec0_Modosesp.Location = new NxtControl.Drawing.PointF(20D, 218D);
			this.sec0_Modosesp.Name = "sec0_Modosesp";
			this.sec0_Modosesp.Text = "Modos especiais";
			// 
			// lSim
			// 
			this.lSim.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSim.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSim.Location = new NxtControl.Drawing.PointF(20D, 247D);
			this.lSim.Name = "lSim";
			this.lSim.Text = "Simula\u00e7\u00e3o";
			// 
			// Sim
			// 
			this.Sim.BeginInit();
			this.Sim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 242D);
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
			this.lOver.Location = new NxtControl.Drawing.PointF(20D, 281D);
			this.lOver.Name = "lOver";
			this.lOver.Text = "Realimenta\u00e7\u00e3o for\u00e7ada";
			// 
			// Over
			// 
			this.Over.BeginInit();
			this.Over.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 276D);
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
			this.lMaint.Location = new NxtControl.Drawing.PointF(20D, 315D);
			this.lMaint.Name = "lMaint";
			this.lMaint.Text = "Manuten\u00e7\u00e3o";
			// 
			// Maint
			// 
			this.Maint.BeginInit();
			this.Maint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 310D);
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
			this.lOos.Location = new NxtControl.Drawing.PointF(20D, 349D);
			this.lOos.Name = "lOos";
			this.lOos.Text = "Fora de servi\u00e7o";
			// 
			// SwOos
			// 
			this.SwOos.BeginInit();
			this.SwOos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 344D);
			this.SwOos.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.SwOos.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.SwOos.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.SwOos.FalseText = "N\u00e3o";
			this.SwOos.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.SwOos.Name = "SwOos";
			this.SwOos.SecurityLevel = 0;
			this.SwOos.TagName = "OutOfService";
			this.SwOos.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.SwOos.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.SwOos.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.SwOos.TrueText = "Sim";
			this.SwOos.Value = false;
			this.SwOos.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv.IsOnlyInput = true;
			this.Pv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv.Name = "Pv";
			this.Pv.SecurityLevel = 0;
			this.Pv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv.TagName = "FbStatus";
			this.Pv.Value = ((short)(0));
			this.Pv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvValueChanged);
			this.Pv.EndInit();
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
			// OutOfService
			// 
			this.OutOfService.BeginInit();
			this.OutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutOfService.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutOfService.Name = "OutOfService";
			this.OutOfService.SecurityLevel = 0;
			this.OutOfService.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutOfService.TagName = "OutOfService";
			this.OutOfService.Value = false;
			this.OutOfService.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutOfServiceValueChanged);
			this.OutOfService.EndInit();
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
			// TransFbStatus
			// 
			this.TransFbStatus.BeginInit();
			this.TransFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TransFbStatus.IsOnlyInput = true;
			this.TransFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TransFbStatus.Name = "TransFbStatus";
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusValueChanged);
			this.TransFbStatus.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(388D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.sec0_Supervis,
			this.lMon,
			this.txtMonTime,
			this.lTrip,
			this.txtTripTime,
			this.lFbReset,
			this.ConfResetReq,
			this.lFailReset,
			this.FailResetReq,
			this.sec0_Modosesp,
			this.lSim,
			this.Sim,
			this.lOver,
			this.Over,
			this.lMaint,
			this.Maint,
			this.lOos,
			this.SwOos,
			this.Pv,
			this.execute_11,
			this.execute_13,
			this.OutOfService,
			this.FbOverride,
			this.TransFbStatus});
			this.Size = new System.Drawing.Size(360, 388);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpParameterSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);
			this.SecurityModeChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityModeChanged(this.FpParameterSecurityModeChanged);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText sec0_Supervis;
		private NxtControl.GuiFramework.FreeText lMon;
		private System.HMI.Symbols.Base.TextBox<int> txtMonTime;
		private NxtControl.GuiFramework.FreeText lTrip;
		private System.HMI.Symbols.Base.TextBox<int> txtTripTime;
		private NxtControl.GuiFramework.FreeText lFbReset;
		private System.HMI.Symbols.Base.SwitchButton ConfResetReq;
		private NxtControl.GuiFramework.FreeText lFailReset;
		private System.HMI.Symbols.Base.SwitchButton FailResetReq;
		private NxtControl.GuiFramework.FreeText sec0_Modosesp;
		private NxtControl.GuiFramework.FreeText lSim;
		private System.HMI.Symbols.Base.SwitchButton Sim;
		private NxtControl.GuiFramework.FreeText lOver;
		private System.HMI.Symbols.Base.SwitchButton Over;
		private NxtControl.GuiFramework.FreeText lMaint;
		private System.HMI.Symbols.Base.SwitchButton Maint;
		private NxtControl.GuiFramework.FreeText lOos;
		private System.HMI.Symbols.Base.SwitchButton SwOos;
		private System.HMI.Symbols.Base.Execute<short> Pv;
		private System.HMI.Symbols.Base.Execute<bool> execute_11;
		private System.HMI.Symbols.Base.Execute<bool> execute_13;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;

		#endregion
	}
}
