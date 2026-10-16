/*
 * Hidryco - Sensor_Generico - fpAlarm
 * ISA-101: alarmes HH/H/L/LL (monitorar, setpoint, tempo, estado com forma+prioridade). Sem histerese; memorizados ate o reset.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Generico
{
	/// <summary>
	/// Summary description for fpAlarm.
	/// </summary>
	partial class fpAlarm
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.ajuda = new NxtControl.GuiFramework.FreeText();
			this.colAlarme = new NxtControl.GuiFramework.FreeText();
			this.colMonitorar = new NxtControl.GuiFramework.FreeText();
			this.colSetpoint = new NxtControl.GuiFramework.FreeText();
			this.colTempo = new NxtControl.GuiFramework.FreeText();
			this.colEstado = new NxtControl.GuiFramework.FreeText();
			this.linhaHH = new NxtControl.GuiFramework.Rectangle();
			this.nomeHH = new NxtControl.GuiFramework.FreeText();
			this.habHH = new System.HMI.Symbols.Base.CheckButton();
			this.spHH = new System.HMI.Symbols.Base.TextBox<float>();
			this.tempoHH = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.normalHH = new NxtControl.GuiFramework.FreeText();
			this.estHHP1 = new NxtControl.GuiFramework.Rectangle();
			this.estHHP1n = new NxtControl.GuiFramework.FreeText();
			this.estHHP2 = new NxtControl.GuiFramework.Polygon();
			this.estHHP2n = new NxtControl.GuiFramework.FreeText();
			this.estHHTxt = new NxtControl.GuiFramework.FreeText();
			this.linhaH = new NxtControl.GuiFramework.Rectangle();
			this.nomeH = new NxtControl.GuiFramework.FreeText();
			this.habH = new System.HMI.Symbols.Base.CheckButton();
			this.spH = new System.HMI.Symbols.Base.TextBox<float>();
			this.tempoH = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.normalH = new NxtControl.GuiFramework.FreeText();
			this.estHP1 = new NxtControl.GuiFramework.Rectangle();
			this.estHP1n = new NxtControl.GuiFramework.FreeText();
			this.estHP2 = new NxtControl.GuiFramework.Polygon();
			this.estHP2n = new NxtControl.GuiFramework.FreeText();
			this.estHTxt = new NxtControl.GuiFramework.FreeText();
			this.linhaL = new NxtControl.GuiFramework.Rectangle();
			this.nomeL = new NxtControl.GuiFramework.FreeText();
			this.habL = new System.HMI.Symbols.Base.CheckButton();
			this.spL = new System.HMI.Symbols.Base.TextBox<float>();
			this.tempoL = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.normalL = new NxtControl.GuiFramework.FreeText();
			this.estLP1 = new NxtControl.GuiFramework.Rectangle();
			this.estLP1n = new NxtControl.GuiFramework.FreeText();
			this.estLP2 = new NxtControl.GuiFramework.Polygon();
			this.estLP2n = new NxtControl.GuiFramework.FreeText();
			this.estLTxt = new NxtControl.GuiFramework.FreeText();
			this.linhaLL = new NxtControl.GuiFramework.Rectangle();
			this.nomeLL = new NxtControl.GuiFramework.FreeText();
			this.habLL = new System.HMI.Symbols.Base.CheckButton();
			this.spLL = new System.HMI.Symbols.Base.TextBox<float>();
			this.tempoLL = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.normalLL = new NxtControl.GuiFramework.FreeText();
			this.estLLP1 = new NxtControl.GuiFramework.Rectangle();
			this.estLLP1n = new NxtControl.GuiFramework.FreeText();
			this.estLLP2 = new NxtControl.GuiFramework.Polygon();
			this.estLLP2n = new NxtControl.GuiFramework.FreeText();
			this.estLLTxt = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.xUnidade = new System.HMI.Symbols.Base.Execute<string>();
			this.xAlHH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAlH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAlL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAlLL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEHH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xELL = new System.HMI.Symbols.Base.Execute<byte>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Alarmes";
			// 
			// ajuda
			// 
			this.ajuda.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ajuda.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda.Location = new NxtControl.Drawing.PointF(20D, 36D);
			this.ajuda.Name = "ajuda";
			this.ajuda.Text = "Atua após o tempo com o valor além do setpoint. Fica memorizado até o reset.";
			// 
			// colAlarme
			// 
			this.colAlarme.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colAlarme.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colAlarme.Location = new NxtControl.Drawing.PointF(20D, 62D);
			this.colAlarme.Name = "colAlarme";
			this.colAlarme.Text = "Alarme";
			// 
			// colMonitorar
			// 
			this.colMonitorar.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colMonitorar.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colMonitorar.Location = new NxtControl.Drawing.PointF(76D, 62D);
			this.colMonitorar.Name = "colMonitorar";
			this.colMonitorar.Text = "Monitorar";
			// 
			// colSetpoint
			// 
			this.colSetpoint.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colSetpoint.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colSetpoint.Location = new NxtControl.Drawing.PointF(196D, 62D);
			this.colSetpoint.Name = "colSetpoint";
			this.colSetpoint.Text = "Setpoint";
			// 
			// colTempo
			// 
			this.colTempo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colTempo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colTempo.Location = new NxtControl.Drawing.PointF(300D, 62D);
			this.colTempo.Name = "colTempo";
			this.colTempo.Text = "Tempo (s)";
			// 
			// colEstado
			// 
			this.colEstado.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.colEstado.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.colEstado.Location = new NxtControl.Drawing.PointF(380D, 62D);
			this.colEstado.Name = "colEstado";
			this.colEstado.Text = "Estado";
			// 
			// linhaHH
			// 
			this.linhaHH.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(81D)), ((float)(426D)), ((float)(34D)));
			this.linhaHH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaHH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaHH.Name = "linhaHH";
			this.linhaHH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeHH
			// 
			this.nomeHH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeHH.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.nomeHH.Location = new NxtControl.Drawing.PointF(24D, 88D);
			this.nomeHH.Name = "nomeHH";
			this.nomeHH.Text = "HH";
			// 
			// habHH
			// 
			this.habHH.BeginInit();
			this.habHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 84D);
			this.habHH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.habHH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habHH.FalseText = "Não";
			this.habHH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.habHH.FontScale = false;
			this.habHH.Name = "habHH";
			this.habHH.TagName = "CMD_HABILITA_ALARME_HH";
			this.habHH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.habHH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habHH.TrueText = "Sim";
			this.habHH.Value = false;
			this.habHH.EndInit();
			// 
			// spHH
			// 
			this.spHH.BeginInit();
			this.spHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 86D);
			this.spHH.MaximumTag = null;
			this.spHH.MinimumTag = null;
			this.spHH.Name = "spHH";
			this.spHH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.spHH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.spHH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.spHH.TagName = "STP_ALARME_HH";
			this.spHH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.spHH.UseInputPad = true;
			this.spHH.Value = 0F;
			this.spHH.EndInit();
			// 
			// tempoHH
			// 
			this.tempoHH.BeginInit();
			this.tempoHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 86D);
			this.tempoHH.MaximumTag = null;
			this.tempoHH.MinimumTag = null;
			this.tempoHH.Name = "tempoHH";
			this.tempoHH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tempoHH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tempoHH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tempoHH.TagName = "STP_TEMPO_ALARME_HH";
			this.tempoHH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tempoHH.UseInputPad = true;
			this.tempoHH.Value = ((ushort)(0));
			this.tempoHH.EndInit();
			// 
			// normalHH
			// 
			this.normalHH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalHH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalHH.Location = new NxtControl.Drawing.PointF(384D, 90D);
			this.normalHH.Name = "normalHH";
			this.normalHH.Text = "—";
			// 
			// estHHP1
			// 
			this.estHHP1.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(90D)), ((float)(16D)), ((float)(16D)));
			this.estHHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estHHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHHP1.Name = "estHHP1";
			this.estHHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estHHP1.Visible = false;
			// 
			// estHHP1n
			// 
			this.estHHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estHHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estHHP1n.Location = new NxtControl.Drawing.PointF(384D, 91D);
			this.estHHP1n.Name = "estHHP1n";
			this.estHHP1n.Text = "1";
			this.estHHP1n.Visible = false;
			// 
			// estHHP2
			// 
			this.estHHP2.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(90D)), ((float)(16D)), ((float)(16D)));
			this.estHHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estHHP2.Closed = true;
			this.estHHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHHP2.Name = "estHHP2";
			this.estHHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estHHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(380D, 106D),
			new NxtControl.Drawing.PointF(388D, 90D),
			new NxtControl.Drawing.PointF(396D, 106D)});
			this.estHHP2.Visible = false;
			// 
			// estHHP2n
			// 
			this.estHHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estHHP2n.Location = new NxtControl.Drawing.PointF(385D, 94D);
			this.estHHP2n.Name = "estHHP2n";
			this.estHHP2n.Text = "2";
			this.estHHP2n.Visible = false;
			// 
			// estHHTxt
			// 
			this.estHHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHHTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estHHTxt.Location = new NxtControl.Drawing.PointF(400D, 90D);
			this.estHHTxt.Name = "estHHTxt";
			this.estHHTxt.Text = "";
			this.estHHTxt.Visible = false;
			// 
			// linhaH
			// 
			this.linhaH.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(121D)), ((float)(426D)), ((float)(34D)));
			this.linhaH.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaH.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaH.Name = "linhaH";
			this.linhaH.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeH
			// 
			this.nomeH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeH.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.nomeH.Location = new NxtControl.Drawing.PointF(24D, 128D);
			this.nomeH.Name = "nomeH";
			this.nomeH.Text = "H";
			// 
			// habH
			// 
			this.habH.BeginInit();
			this.habH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 124D);
			this.habH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.habH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habH.FalseText = "Não";
			this.habH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.habH.FontScale = false;
			this.habH.Name = "habH";
			this.habH.TagName = "CMD_HABILITA_ALARME_H";
			this.habH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.habH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habH.TrueText = "Sim";
			this.habH.Value = false;
			this.habH.EndInit();
			// 
			// spH
			// 
			this.spH.BeginInit();
			this.spH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 126D);
			this.spH.MaximumTag = null;
			this.spH.MinimumTag = null;
			this.spH.Name = "spH";
			this.spH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.spH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.spH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.spH.TagName = "STP_ALARME_H";
			this.spH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.spH.UseInputPad = true;
			this.spH.Value = 0F;
			this.spH.EndInit();
			// 
			// tempoH
			// 
			this.tempoH.BeginInit();
			this.tempoH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 126D);
			this.tempoH.MaximumTag = null;
			this.tempoH.MinimumTag = null;
			this.tempoH.Name = "tempoH";
			this.tempoH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tempoH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tempoH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tempoH.TagName = "STP_TEMPO_ALARME_H";
			this.tempoH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tempoH.UseInputPad = true;
			this.tempoH.Value = ((ushort)(0));
			this.tempoH.EndInit();
			// 
			// normalH
			// 
			this.normalH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalH.Location = new NxtControl.Drawing.PointF(384D, 130D);
			this.normalH.Name = "normalH";
			this.normalH.Text = "—";
			// 
			// estHP1
			// 
			this.estHP1.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(130D)), ((float)(16D)), ((float)(16D)));
			this.estHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHP1.Name = "estHP1";
			this.estHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estHP1.Visible = false;
			// 
			// estHP1n
			// 
			this.estHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estHP1n.Location = new NxtControl.Drawing.PointF(384D, 131D);
			this.estHP1n.Name = "estHP1n";
			this.estHP1n.Text = "1";
			this.estHP1n.Visible = false;
			// 
			// estHP2
			// 
			this.estHP2.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(130D)), ((float)(16D)), ((float)(16D)));
			this.estHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estHP2.Closed = true;
			this.estHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estHP2.Name = "estHP2";
			this.estHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(380D, 146D),
			new NxtControl.Drawing.PointF(388D, 130D),
			new NxtControl.Drawing.PointF(396D, 146D)});
			this.estHP2.Visible = false;
			// 
			// estHP2n
			// 
			this.estHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estHP2n.Location = new NxtControl.Drawing.PointF(385D, 134D);
			this.estHP2n.Name = "estHP2n";
			this.estHP2n.Text = "2";
			this.estHP2n.Visible = false;
			// 
			// estHTxt
			// 
			this.estHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estHTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estHTxt.Location = new NxtControl.Drawing.PointF(400D, 130D);
			this.estHTxt.Name = "estHTxt";
			this.estHTxt.Text = "";
			this.estHTxt.Visible = false;
			// 
			// linhaL
			// 
			this.linhaL.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(161D)), ((float)(426D)), ((float)(34D)));
			this.linhaL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaL.Name = "linhaL";
			this.linhaL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeL
			// 
			this.nomeL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeL.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.nomeL.Location = new NxtControl.Drawing.PointF(24D, 168D);
			this.nomeL.Name = "nomeL";
			this.nomeL.Text = "L";
			// 
			// habL
			// 
			this.habL.BeginInit();
			this.habL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 164D);
			this.habL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.habL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habL.FalseText = "Não";
			this.habL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.habL.FontScale = false;
			this.habL.Name = "habL";
			this.habL.TagName = "CMD_HABILITA_ALARME_L";
			this.habL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.habL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habL.TrueText = "Sim";
			this.habL.Value = false;
			this.habL.EndInit();
			// 
			// spL
			// 
			this.spL.BeginInit();
			this.spL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 166D);
			this.spL.MaximumTag = null;
			this.spL.MinimumTag = null;
			this.spL.Name = "spL";
			this.spL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.spL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.spL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.spL.TagName = "STP_ALARME_L";
			this.spL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.spL.UseInputPad = true;
			this.spL.Value = 0F;
			this.spL.EndInit();
			// 
			// tempoL
			// 
			this.tempoL.BeginInit();
			this.tempoL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 166D);
			this.tempoL.MaximumTag = null;
			this.tempoL.MinimumTag = null;
			this.tempoL.Name = "tempoL";
			this.tempoL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tempoL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tempoL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tempoL.TagName = "STP_TEMPO_ALARME_L";
			this.tempoL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tempoL.UseInputPad = true;
			this.tempoL.Value = ((ushort)(0));
			this.tempoL.EndInit();
			// 
			// normalL
			// 
			this.normalL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalL.Location = new NxtControl.Drawing.PointF(384D, 170D);
			this.normalL.Name = "normalL";
			this.normalL.Text = "—";
			// 
			// estLP1
			// 
			this.estLP1.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(170D)), ((float)(16D)), ((float)(16D)));
			this.estLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLP1.Name = "estLP1";
			this.estLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estLP1.Visible = false;
			// 
			// estLP1n
			// 
			this.estLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estLP1n.Location = new NxtControl.Drawing.PointF(384D, 171D);
			this.estLP1n.Name = "estLP1n";
			this.estLP1n.Text = "1";
			this.estLP1n.Visible = false;
			// 
			// estLP2
			// 
			this.estLP2.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(170D)), ((float)(16D)), ((float)(16D)));
			this.estLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estLP2.Closed = true;
			this.estLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLP2.Name = "estLP2";
			this.estLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(380D, 186D),
			new NxtControl.Drawing.PointF(388D, 170D),
			new NxtControl.Drawing.PointF(396D, 186D)});
			this.estLP2.Visible = false;
			// 
			// estLP2n
			// 
			this.estLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estLP2n.Location = new NxtControl.Drawing.PointF(385D, 174D);
			this.estLP2n.Name = "estLP2n";
			this.estLP2n.Text = "2";
			this.estLP2n.Visible = false;
			// 
			// estLTxt
			// 
			this.estLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estLTxt.Location = new NxtControl.Drawing.PointF(400D, 170D);
			this.estLTxt.Name = "estLTxt";
			this.estLTxt.Text = "";
			this.estLTxt.Visible = false;
			// 
			// linhaLL
			// 
			this.linhaLL.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(201D)), ((float)(426D)), ((float)(34D)));
			this.linhaLL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linhaLL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linhaLL.Name = "linhaLL";
			this.linhaLL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nomeLL
			// 
			this.nomeLL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nomeLL.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.nomeLL.Location = new NxtControl.Drawing.PointF(24D, 208D);
			this.nomeLL.Name = "nomeLL";
			this.nomeLL.Text = "LL";
			// 
			// habLL
			// 
			this.habLL.BeginInit();
			this.habLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 70D, 204D);
			this.habLL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.habLL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habLL.FalseText = "Não";
			this.habLL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.habLL.FontScale = false;
			this.habLL.Name = "habLL";
			this.habLL.TagName = "CMD_HABILITA_ALARME_LL";
			this.habLL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.habLL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.habLL.TrueText = "Sim";
			this.habLL.Value = false;
			this.habLL.EndInit();
			// 
			// spLL
			// 
			this.spLL.BeginInit();
			this.spLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.62D, 0D, 0D, 1D, 196D, 206D);
			this.spLL.MaximumTag = null;
			this.spLL.MinimumTag = null;
			this.spLL.Name = "spLL";
			this.spLL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.spLL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.spLL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.spLL.TagName = "STP_ALARME_LL";
			this.spLL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.spLL.UseInputPad = true;
			this.spLL.Value = 0F;
			this.spLL.EndInit();
			// 
			// tempoLL
			// 
			this.tempoLL.BeginInit();
			this.tempoLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 1D, 300D, 206D);
			this.tempoLL.MaximumTag = null;
			this.tempoLL.MinimumTag = null;
			this.tempoLL.Name = "tempoLL";
			this.tempoLL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tempoLL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tempoLL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tempoLL.TagName = "STP_TEMPO_ALARME_LL";
			this.tempoLL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tempoLL.UseInputPad = true;
			this.tempoLL.Value = ((ushort)(0));
			this.tempoLL.EndInit();
			// 
			// normalLL
			// 
			this.normalLL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.normalLL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.normalLL.Location = new NxtControl.Drawing.PointF(384D, 210D);
			this.normalLL.Name = "normalLL";
			this.normalLL.Text = "—";
			// 
			// estLLP1
			// 
			this.estLLP1.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(210D)), ((float)(16D)), ((float)(16D)));
			this.estLLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.estLLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLLP1.Name = "estLLP1";
			this.estLLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estLLP1.Visible = false;
			// 
			// estLLP1n
			// 
			this.estLLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.estLLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.estLLP1n.Location = new NxtControl.Drawing.PointF(384D, 211D);
			this.estLLP1n.Name = "estLLP1n";
			this.estLLP1n.Text = "1";
			this.estLLP1n.Visible = false;
			// 
			// estLLP2
			// 
			this.estLLP2.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(210D)), ((float)(16D)), ((float)(16D)));
			this.estLLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.estLLP2.Closed = true;
			this.estLLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.estLLP2.Name = "estLLP2";
			this.estLLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.estLLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(380D, 226D),
			new NxtControl.Drawing.PointF(388D, 210D),
			new NxtControl.Drawing.PointF(396D, 226D)});
			this.estLLP2.Visible = false;
			// 
			// estLLP2n
			// 
			this.estLLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.estLLP2n.Location = new NxtControl.Drawing.PointF(385D, 214D);
			this.estLLP2n.Name = "estLLP2n";
			this.estLLP2n.Text = "2";
			this.estLLP2n.Visible = false;
			// 
			// estLLTxt
			// 
			this.estLLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.estLLTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.estLLTxt.Location = new NxtControl.Drawing.PointF(400D, 210D);
			this.estLLTxt.Name = "estLLTxt";
			this.estLLTxt.Text = "";
			this.estLLTxt.Visible = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(250D)), ((float)(150D)), ((float)(32D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
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
			// xUnidade
			// 
			this.xUnidade.BeginInit();
			this.xUnidade.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xUnidade.IsOnlyInput = true;
			this.xUnidade.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xUnidade.Name = "xUnidade";
			this.xUnidade.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xUnidade.TagName = "CFG_UNIDADE";
			this.xUnidade.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.UnidadeValueChanged);
			this.xUnidade.EndInit();
			// 
			// xAlHH
			// 
			this.xAlHH.BeginInit();
			this.xAlHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlHH.IsOnlyInput = true;
			this.xAlHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlHH.Name = "xAlHH";
			this.xAlHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlHH.TagName = "STS_ALARME_HH";
			this.xAlHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlHHValueChanged);
			this.xAlHH.EndInit();
			// 
			// xAlH
			// 
			this.xAlH.BeginInit();
			this.xAlH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlH.IsOnlyInput = true;
			this.xAlH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlH.Name = "xAlH";
			this.xAlH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlH.TagName = "STS_ALARME_H";
			this.xAlH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlHValueChanged);
			this.xAlH.EndInit();
			// 
			// xAlL
			// 
			this.xAlL.BeginInit();
			this.xAlL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlL.IsOnlyInput = true;
			this.xAlL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlL.Name = "xAlL";
			this.xAlL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlL.TagName = "STS_ALARME_L";
			this.xAlL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlLValueChanged);
			this.xAlL.EndInit();
			// 
			// xAlLL
			// 
			this.xAlLL.BeginInit();
			this.xAlLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAlLL.IsOnlyInput = true;
			this.xAlLL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAlLL.Name = "xAlLL";
			this.xAlLL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAlLL.TagName = "STS_ALARME_LL";
			this.xAlLL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AlLLValueChanged);
			this.xAlLL.EndInit();
			// 
			// xEHH
			// 
			this.xEHH.BeginInit();
			this.xEHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEHH.IsOnlyInput = true;
			this.xEHH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEHH.Name = "xEHH";
			this.xEHH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEHH.TagName = "STS_ALM_HH_EST";
			this.xEHH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EHHValueChanged);
			this.xEHH.EndInit();
			// 
			// xEH
			// 
			this.xEH.BeginInit();
			this.xEH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEH.IsOnlyInput = true;
			this.xEH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEH.Name = "xEH";
			this.xEH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEH.TagName = "STS_ALM_H_EST";
			this.xEH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EHValueChanged);
			this.xEH.EndInit();
			// 
			// xEL
			// 
			this.xEL.BeginInit();
			this.xEL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEL.IsOnlyInput = true;
			this.xEL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEL.Name = "xEL";
			this.xEL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEL.TagName = "STS_ALM_L_EST";
			this.xEL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ELValueChanged);
			this.xEL.EndInit();
			// 
			// xELL
			// 
			this.xELL.BeginInit();
			this.xELL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xELL.IsOnlyInput = true;
			this.xELL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xELL.Name = "xELL";
			this.xELL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xELL.TagName = "STS_ALM_LL_EST";
			this.xELL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ELLValueChanged);
			this.xELL.EndInit();
			// 
			// fpAlarm
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(450D)), ((float)(296D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpAlarm";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.ajuda,
			this.colAlarme,
			this.colMonitorar,
			this.colSetpoint,
			this.colTempo,
			this.colEstado,
			this.linhaHH,
			this.nomeHH,
			this.habHH,
			this.spHH,
			this.tempoHH,
			this.normalHH,
			this.estHHP1,
			this.estHHP1n,
			this.estHHP2,
			this.estHHP2n,
			this.estHHTxt,
			this.linhaH,
			this.nomeH,
			this.habH,
			this.spH,
			this.tempoH,
			this.normalH,
			this.estHP1,
			this.estHP1n,
			this.estHP2,
			this.estHP2n,
			this.estHTxt,
			this.linhaL,
			this.nomeL,
			this.habL,
			this.spL,
			this.tempoL,
			this.normalL,
			this.estLP1,
			this.estLP1n,
			this.estLP2,
			this.estLP2n,
			this.estLTxt,
			this.linhaLL,
			this.nomeLL,
			this.habLL,
			this.spLL,
			this.tempoLL,
			this.normalLL,
			this.estLLP1,
			this.estLLP1n,
			this.estLLP2,
			this.estLLP2n,
			this.estLLTxt,
			this.btnReset,
			this.xUnidade,
			this.xAlHH,
			this.xAlH,
			this.xAlL,
			this.xAlLL,
			this.xEHH,
			this.xEH,
			this.xEL,
			this.xELL});
			this.Size = new System.Drawing.Size(450, 296);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText ajuda;
		private NxtControl.GuiFramework.FreeText colAlarme;
		private NxtControl.GuiFramework.FreeText colMonitorar;
		private NxtControl.GuiFramework.FreeText colSetpoint;
		private NxtControl.GuiFramework.FreeText colTempo;
		private NxtControl.GuiFramework.FreeText colEstado;
		private NxtControl.GuiFramework.Rectangle linhaHH;
		private NxtControl.GuiFramework.FreeText nomeHH;
		private System.HMI.Symbols.Base.CheckButton habHH;
		private System.HMI.Symbols.Base.TextBox<float> spHH;
		private System.HMI.Symbols.Base.TextBox<ushort> tempoHH;
		private NxtControl.GuiFramework.FreeText normalHH;
		private NxtControl.GuiFramework.Rectangle estHHP1;
		private NxtControl.GuiFramework.FreeText estHHP1n;
		private NxtControl.GuiFramework.Polygon estHHP2;
		private NxtControl.GuiFramework.FreeText estHHP2n;
		private NxtControl.GuiFramework.FreeText estHHTxt;
		private NxtControl.GuiFramework.Rectangle linhaH;
		private NxtControl.GuiFramework.FreeText nomeH;
		private System.HMI.Symbols.Base.CheckButton habH;
		private System.HMI.Symbols.Base.TextBox<float> spH;
		private System.HMI.Symbols.Base.TextBox<ushort> tempoH;
		private NxtControl.GuiFramework.FreeText normalH;
		private NxtControl.GuiFramework.Rectangle estHP1;
		private NxtControl.GuiFramework.FreeText estHP1n;
		private NxtControl.GuiFramework.Polygon estHP2;
		private NxtControl.GuiFramework.FreeText estHP2n;
		private NxtControl.GuiFramework.FreeText estHTxt;
		private NxtControl.GuiFramework.Rectangle linhaL;
		private NxtControl.GuiFramework.FreeText nomeL;
		private System.HMI.Symbols.Base.CheckButton habL;
		private System.HMI.Symbols.Base.TextBox<float> spL;
		private System.HMI.Symbols.Base.TextBox<ushort> tempoL;
		private NxtControl.GuiFramework.FreeText normalL;
		private NxtControl.GuiFramework.Rectangle estLP1;
		private NxtControl.GuiFramework.FreeText estLP1n;
		private NxtControl.GuiFramework.Polygon estLP2;
		private NxtControl.GuiFramework.FreeText estLP2n;
		private NxtControl.GuiFramework.FreeText estLTxt;
		private NxtControl.GuiFramework.Rectangle linhaLL;
		private NxtControl.GuiFramework.FreeText nomeLL;
		private System.HMI.Symbols.Base.CheckButton habLL;
		private System.HMI.Symbols.Base.TextBox<float> spLL;
		private System.HMI.Symbols.Base.TextBox<ushort> tempoLL;
		private NxtControl.GuiFramework.FreeText normalLL;
		private NxtControl.GuiFramework.Rectangle estLLP1;
		private NxtControl.GuiFramework.FreeText estLLP1n;
		private NxtControl.GuiFramework.Polygon estLLP2;
		private NxtControl.GuiFramework.FreeText estLLP2n;
		private NxtControl.GuiFramework.FreeText estLLTxt;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private System.HMI.Symbols.Base.Execute<string> xUnidade;
		private System.HMI.Symbols.Base.Execute<bool> xAlHH;
		private System.HMI.Symbols.Base.Execute<bool> xAlH;
		private System.HMI.Symbols.Base.Execute<bool> xAlL;
		private System.HMI.Symbols.Base.Execute<bool> xAlLL;
		private System.HMI.Symbols.Base.Execute<byte> xEHH;
		private System.HMI.Symbols.Base.Execute<byte> xEH;
		private System.HMI.Symbols.Base.Execute<byte> xEL;
		private System.HMI.Symbols.Base.Execute<byte> xELL;
		#endregion
	}
}
