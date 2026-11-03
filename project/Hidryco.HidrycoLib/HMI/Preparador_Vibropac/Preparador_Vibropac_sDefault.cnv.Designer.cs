/*
 * Hidryco - Preparador_Vibropac - sDefault
 * ISA-101: Preparador de polimero Vibropac VIB-3000 - estado do ciclo, modo e alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Preparador_Vibropac
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
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.stCiclo = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xHAB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAUTO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCIC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCMAN = new System.HMI.Symbols.Base.Execute<bool>();
			this.xALS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEMG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFMOT = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDISP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEEMG = new System.HMI.Symbols.Base.Execute<byte>();
			this.xESKD = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMOT = new System.HMI.Symbols.Base.Execute<byte>();
			this.xM1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM3 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM4 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM5 = new System.HMI.Symbols.Base.Execute<short>();
			this.xDOS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSILO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xNIVP = new System.HMI.Symbols.Base.Execute<short>();
			this.xVAG = new System.HMI.Symbols.Base.Execute<float>();
			this.xVPO = new System.HMI.Symbols.Base.Execute<float>();
			this.xFAG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVZ = new System.HMI.Symbols.Base.Execute<short>();
			this.xVS01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRES = new System.HMI.Symbols.Base.Execute<bool>();
			this.xESIL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEAGU = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVAZ = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(230D)), ((float)(96D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(120D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// stCiclo
			// 
			this.stCiclo.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(4D)), ((float)(16D)), ((float)(16D)));
			this.stCiclo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.stCiclo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.stCiclo.Name = "stCiclo";
			this.stCiclo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(74D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(10D, 75D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(74D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(6D, 90D),
			new NxtControl.Drawing.PointF(14D, 74D),
			new NxtControl.Drawing.PointF(22D, 90D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(11D, 77D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(26D, 74D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.l1.Location = new NxtControl.Drawing.PointF(6D, 24D);
			this.l1.Name = "l1";
			this.l1.Text = "";
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(6D, 44D);
			this.l2.Name = "l2";
			this.l2.Text = "";
			// 
			// xFCOM
			// 
			this.xFCOM.BeginInit();
			this.xFCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFCOM.IsOnlyInput = true;
			this.xFCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFCOM.Name = "xFCOM";
			this.xFCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFCOM.TagName = "STS_FALHA_COMUNICACAO";
			this.xFCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFCOMValueChanged);
			this.xFCOM.EndInit();
			// 
			// xHAB
			// 
			this.xHAB.BeginInit();
			this.xHAB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHAB.IsOnlyInput = true;
			this.xHAB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHAB.Name = "xHAB";
			this.xHAB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHAB.TagName = "STS_HABILITADO";
			this.xHAB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XHABValueChanged);
			this.xHAB.EndInit();
			// 
			// xAUTO
			// 
			this.xAUTO.BeginInit();
			this.xAUTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAUTO.IsOnlyInput = true;
			this.xAUTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAUTO.Name = "xAUTO";
			this.xAUTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAUTO.TagName = "STS_AUTOMATICO";
			this.xAUTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAUTOValueChanged);
			this.xAUTO.EndInit();
			// 
			// xCIC
			// 
			this.xCIC.BeginInit();
			this.xCIC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCIC.IsOnlyInput = true;
			this.xCIC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCIC.Name = "xCIC";
			this.xCIC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCIC.TagName = "STS_CICLO_LIGADO";
			this.xCIC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCICValueChanged);
			this.xCIC.EndInit();
			// 
			// xCMAN
			// 
			this.xCMAN.BeginInit();
			this.xCMAN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCMAN.IsOnlyInput = true;
			this.xCMAN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCMAN.Name = "xCMAN";
			this.xCMAN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCMAN.TagName = "STS_CMD_MANUAL";
			this.xCMAN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCMANValueChanged);
			this.xCMAN.EndInit();
			// 
			// xALS
			// 
			this.xALS.BeginInit();
			this.xALS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xALS.IsOnlyInput = true;
			this.xALS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xALS.Name = "xALS";
			this.xALS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xALS.TagName = "STS_ALARME_ACIONADO";
			this.xALS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XALSValueChanged);
			this.xALS.EndInit();
			// 
			// xEMG
			// 
			this.xEMG.BeginInit();
			this.xEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMG.IsOnlyInput = true;
			this.xEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMG.Name = "xEMG";
			this.xEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMG.TagName = "STS_EMERGENCIA";
			this.xEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMGValueChanged);
			this.xEMG.EndInit();
			// 
			// xFMOT
			// 
			this.xFMOT.BeginInit();
			this.xFMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFMOT.IsOnlyInput = true;
			this.xFMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFMOT.Name = "xFMOT";
			this.xFMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFMOT.TagName = "STS_FALHA_MOTOR";
			this.xFMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFMOTValueChanged);
			this.xFMOT.EndInit();
			// 
			// xDISP
			// 
			this.xDISP.BeginInit();
			this.xDISP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDISP.IsOnlyInput = true;
			this.xDISP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDISP.Name = "xDISP";
			this.xDISP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDISP.TagName = "STS_DISPONIVEL";
			this.xDISP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDISPValueChanged);
			this.xDISP.EndInit();
			// 
			// xECOM
			// 
			this.xECOM.BeginInit();
			this.xECOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECOM.IsOnlyInput = true;
			this.xECOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECOM.Name = "xECOM";
			this.xECOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECOM.TagName = "STS_ALM_COMUNICACAO_EST";
			this.xECOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XECOMValueChanged);
			this.xECOM.EndInit();
			// 
			// xEEMG
			// 
			this.xEEMG.BeginInit();
			this.xEEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEMG.IsOnlyInput = true;
			this.xEEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEMG.Name = "xEEMG";
			this.xEEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEMG.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEEMGValueChanged);
			this.xEEMG.EndInit();
			// 
			// xESKD
			// 
			this.xESKD.BeginInit();
			this.xESKD.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESKD.IsOnlyInput = true;
			this.xESKD.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESKD.Name = "xESKD";
			this.xESKD.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESKD.TagName = "STS_ALM_SKID_EST";
			this.xESKD.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESKDValueChanged);
			this.xESKD.EndInit();
			// 
			// xEMOT
			// 
			this.xEMOT.BeginInit();
			this.xEMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMOT.IsOnlyInput = true;
			this.xEMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMOT.Name = "xEMOT";
			this.xEMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMOT.TagName = "STS_ALM_MOTOR_EST";
			this.xEMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMOTValueChanged);
			this.xEMOT.EndInit();
			// 
			// xM1
			// 
			this.xM1.BeginInit();
			this.xM1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM1.IsOnlyInput = true;
			this.xM1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM1.Name = "xM1";
			this.xM1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM1.TagName = "STS_M1";
			this.xM1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM1ValueChanged);
			this.xM1.EndInit();
			// 
			// xM2
			// 
			this.xM2.BeginInit();
			this.xM2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM2.IsOnlyInput = true;
			this.xM2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM2.Name = "xM2";
			this.xM2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM2.TagName = "STS_M2";
			this.xM2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM2ValueChanged);
			this.xM2.EndInit();
			// 
			// xM3
			// 
			this.xM3.BeginInit();
			this.xM3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM3.IsOnlyInput = true;
			this.xM3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM3.Name = "xM3";
			this.xM3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM3.TagName = "STS_M3";
			this.xM3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM3ValueChanged);
			this.xM3.EndInit();
			// 
			// xM4
			// 
			this.xM4.BeginInit();
			this.xM4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM4.IsOnlyInput = true;
			this.xM4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM4.Name = "xM4";
			this.xM4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM4.TagName = "STS_M4";
			this.xM4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM4ValueChanged);
			this.xM4.EndInit();
			// 
			// xM5
			// 
			this.xM5.BeginInit();
			this.xM5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM5.IsOnlyInput = true;
			this.xM5.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM5.Name = "xM5";
			this.xM5.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM5.TagName = "STS_M5";
			this.xM5.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM5ValueChanged);
			this.xM5.EndInit();
			// 
			// xDOS
			// 
			this.xDOS.BeginInit();
			this.xDOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDOS.IsOnlyInput = true;
			this.xDOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDOS.Name = "xDOS";
			this.xDOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDOS.TagName = "STS_DOSANDO";
			this.xDOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDOSValueChanged);
			this.xDOS.EndInit();
			// 
			// xSILO
			// 
			this.xSILO.BeginInit();
			this.xSILO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSILO.IsOnlyInput = true;
			this.xSILO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSILO.Name = "xSILO";
			this.xSILO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSILO.TagName = "STS_SILO_BAIXO";
			this.xSILO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSILOValueChanged);
			this.xSILO.EndInit();
			// 
			// xNIVP
			// 
			this.xNIVP.BeginInit();
			this.xNIVP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNIVP.IsOnlyInput = true;
			this.xNIVP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNIVP.Name = "xNIVP";
			this.xNIVP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNIVP.TagName = "STS_NIVEL_PREPARO";
			this.xNIVP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNIVPValueChanged);
			this.xNIVP.EndInit();
			// 
			// xVAG
			// 
			this.xVAG.BeginInit();
			this.xVAG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVAG.IsOnlyInput = true;
			this.xVAG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVAG.Name = "xVAG";
			this.xVAG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVAG.TagName = "STS_VAZAO_AGUA";
			this.xVAG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVAGValueChanged);
			this.xVAG.EndInit();
			// 
			// xVPO
			// 
			this.xVPO.BeginInit();
			this.xVPO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVPO.IsOnlyInput = true;
			this.xVPO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVPO.Name = "xVPO";
			this.xVPO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVPO.TagName = "STS_VAZAO_POLIMERO";
			this.xVPO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVPOValueChanged);
			this.xVPO.EndInit();
			// 
			// xFAG
			// 
			this.xFAG.BeginInit();
			this.xFAG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFAG.IsOnlyInput = true;
			this.xFAG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFAG.Name = "xFAG";
			this.xFAG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFAG.TagName = "STS_FALTA_AGUA";
			this.xFAG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFAGValueChanged);
			this.xFAG.EndInit();
			// 
			// xAVZ
			// 
			this.xAVZ.BeginInit();
			this.xAVZ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVZ.IsOnlyInput = true;
			this.xAVZ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVZ.Name = "xAVZ";
			this.xAVZ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVZ.TagName = "STS_ALARME_VAZAO";
			this.xAVZ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAVZValueChanged);
			this.xAVZ.EndInit();
			// 
			// xVS01
			// 
			this.xVS01.BeginInit();
			this.xVS01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVS01.IsOnlyInput = true;
			this.xVS01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVS01.Name = "xVS01";
			this.xVS01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVS01.TagName = "STS_VS01_ABERTA";
			this.xVS01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVS01ValueChanged);
			this.xVS01.EndInit();
			// 
			// xRES
			// 
			this.xRES.BeginInit();
			this.xRES.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRES.IsOnlyInput = true;
			this.xRES.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRES.Name = "xRES";
			this.xRES.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRES.TagName = "STS_RESISTENCIA";
			this.xRES.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XRESValueChanged);
			this.xRES.EndInit();
			// 
			// xESIL
			// 
			this.xESIL.BeginInit();
			this.xESIL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESIL.IsOnlyInput = true;
			this.xESIL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESIL.Name = "xESIL";
			this.xESIL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESIL.TagName = "STS_ALM_SILO_EST";
			this.xESIL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESILValueChanged);
			this.xESIL.EndInit();
			// 
			// xEAGU
			// 
			this.xEAGU.BeginInit();
			this.xEAGU.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEAGU.IsOnlyInput = true;
			this.xEAGU.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEAGU.Name = "xEAGU";
			this.xEAGU.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEAGU.TagName = "STS_ALM_AGUA_EST";
			this.xEAGU.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEAGUValueChanged);
			this.xEAGU.EndInit();
			// 
			// xEVAZ
			// 
			this.xEVAZ.BeginInit();
			this.xEVAZ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVAZ.IsOnlyInput = true;
			this.xEVAZ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVAZ.Name = "xEVAZ";
			this.xEVAZ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVAZ.TagName = "STS_ALM_VAZAO_EST";
			this.xEVAZ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEVAZValueChanged);
			this.xEVAZ.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(230D)), ((float)(96D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Text = "";
			this.abrir.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.Use3DEffect = false;
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.InstanceName,
			this.stCiclo,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.l1,
			this.l2,
			this.xFCOM,
			this.xHAB,
			this.xAUTO,
			this.xCIC,
			this.xCMAN,
			this.xALS,
			this.xEMG,
			this.xFMOT,
			this.xDISP,
			this.xECOM,
			this.xEEMG,
			this.xESKD,
			this.xEMOT,
			this.xM1,
			this.xM2,
			this.xM3,
			this.xM4,
			this.xM5,
			this.xDOS,
			this.xSILO,
			this.xNIVP,
			this.xVAG,
			this.xVPO,
			this.xFAG,
			this.xAVZ,
			this.xVS01,
			this.xRES,
			this.xESIL,
			this.xEAGU,
			this.xEVAZ,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(230, 96);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle stCiclo;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText l1;
		private NxtControl.GuiFramework.FreeText l2;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xHAB;
		private System.HMI.Symbols.Base.Execute<bool> xAUTO;
		private System.HMI.Symbols.Base.Execute<bool> xCIC;
		private System.HMI.Symbols.Base.Execute<bool> xCMAN;
		private System.HMI.Symbols.Base.Execute<bool> xALS;
		private System.HMI.Symbols.Base.Execute<bool> xEMG;
		private System.HMI.Symbols.Base.Execute<bool> xFMOT;
		private System.HMI.Symbols.Base.Execute<bool> xDISP;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xEEMG;
		private System.HMI.Symbols.Base.Execute<byte> xESKD;
		private System.HMI.Symbols.Base.Execute<byte> xEMOT;
		private System.HMI.Symbols.Base.Execute<short> xM1;
		private System.HMI.Symbols.Base.Execute<short> xM2;
		private System.HMI.Symbols.Base.Execute<short> xM3;
		private System.HMI.Symbols.Base.Execute<short> xM4;
		private System.HMI.Symbols.Base.Execute<short> xM5;
		private System.HMI.Symbols.Base.Execute<bool> xDOS;
		private System.HMI.Symbols.Base.Execute<bool> xSILO;
		private System.HMI.Symbols.Base.Execute<short> xNIVP;
		private System.HMI.Symbols.Base.Execute<float> xVAG;
		private System.HMI.Symbols.Base.Execute<float> xVPO;
		private System.HMI.Symbols.Base.Execute<bool> xFAG;
		private System.HMI.Symbols.Base.Execute<short> xAVZ;
		private System.HMI.Symbols.Base.Execute<bool> xVS01;
		private System.HMI.Symbols.Base.Execute<bool> xRES;
		private System.HMI.Symbols.Base.Execute<byte> xESIL;
		private System.HMI.Symbols.Base.Execute<byte> xEAGU;
		private System.HMI.Symbols.Base.Execute<byte> xEVAZ;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
