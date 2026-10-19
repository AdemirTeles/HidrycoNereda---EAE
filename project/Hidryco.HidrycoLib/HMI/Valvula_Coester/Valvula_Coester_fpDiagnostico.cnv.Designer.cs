/*
 * Hidryco - Valvula_Coester - fpDiagnostico
 * Diagnostico do atuador: torque, temperatura, partidas, palavras de status e parametros de supervisao.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Coester
{
	/// <summary>
	/// Summary description for fpDiagnostico.
	/// </summary>
	partial class fpDiagnostico
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.lTorque = new NxtControl.GuiFramework.FreeText();
			this.vTorque = new NxtControl.GuiFramework.FreeText();
			this.lTemp = new NxtControl.GuiFramework.FreeText();
			this.vTemp = new NxtControl.GuiFramework.FreeText();
			this.lPerc = new NxtControl.GuiFramework.FreeText();
			this.vPerc = new NxtControl.GuiFramework.FreeText();
			this.lPart = new NxtControl.GuiFramework.FreeText();
			this.vPart = new NxtControl.GuiFramework.FreeText();
			this.lCont = new NxtControl.GuiFramework.FreeText();
			this.vCont = new NxtControl.GuiFramework.FreeText();
			this.lWords = new NxtControl.GuiFramework.FreeText();
			this.vWords = new NxtControl.GuiFramework.FreeText();
			this.lFalha = new NxtControl.GuiFramework.FreeText();
			this.vFalha = new NxtControl.GuiFramework.FreeText();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.rPar = new NxtControl.GuiFramework.FreeText();
			this.lTempo = new NxtControl.GuiFramework.FreeText();
			this.vTempo = new System.HMI.Symbols.Base.TextBox<short>();
			this.lTol = new NxtControl.GuiFramework.FreeText();
			this.vTol = new System.HMI.Symbols.Base.TextBox<float>();
			this.xTORQ = new System.HMI.Symbols.Base.Execute<short>();
			this.xTORQP = new System.HMI.Symbols.Base.Execute<short>();
			this.xTEMP = new System.HMI.Symbols.Base.Execute<short>();
			this.xTPERC = new System.HMI.Symbols.Base.Execute<short>();
			this.xPDIA = new System.HMI.Symbols.Base.Execute<short>();
			this.xPMAX = new System.HMI.Symbols.Base.Execute<short>();
			this.xMCONT = new System.HMI.Symbols.Base.Execute<bool>();
			this.xW2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xW3 = new System.HMI.Symbols.Base.Execute<short>();
			this.xW4 = new System.HMI.Symbols.Base.Execute<short>();
			this.xCOD = new System.HMI.Symbols.Base.Execute<short>();
			this.xFATU = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(36D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 10D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Diagnóstico do atuador";
			// 
			// lTorque
			// 
			this.lTorque.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTorque.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lTorque.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.lTorque.Name = "lTorque";
			this.lTorque.Text = "Torque do último comando";
			// 
			// vTorque
			// 
			this.vTorque.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vTorque.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vTorque.Location = new NxtControl.Drawing.PointF(230D, 48D);
			this.vTorque.Name = "vTorque";
			this.vTorque.Text = "";
			// 
			// lTemp
			// 
			this.lTemp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTemp.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lTemp.Location = new NxtControl.Drawing.PointF(20D, 74D);
			this.lTemp.Name = "lTemp";
			this.lTemp.Text = "Temperatura interna";
			// 
			// vTemp
			// 
			this.vTemp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vTemp.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vTemp.Location = new NxtControl.Drawing.PointF(230D, 74D);
			this.vTemp.Name = "vTemp";
			this.vTemp.Text = "";
			// 
			// lPerc
			// 
			this.lPerc.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lPerc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lPerc.Location = new NxtControl.Drawing.PointF(20D, 100D);
			this.lPerc.Name = "lPerc";
			this.lPerc.Text = "Tempo do último percurso";
			// 
			// vPerc
			// 
			this.vPerc.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vPerc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vPerc.Location = new NxtControl.Drawing.PointF(230D, 100D);
			this.vPerc.Name = "vPerc";
			this.vPerc.Text = "";
			// 
			// lPart
			// 
			this.lPart.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lPart.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lPart.Location = new NxtControl.Drawing.PointF(20D, 126D);
			this.lPart.Name = "lPart";
			this.lPart.Text = "Partidas no dia anterior / máximo";
			// 
			// vPart
			// 
			this.vPart.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vPart.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vPart.Location = new NxtControl.Drawing.PointF(230D, 126D);
			this.vPart.Name = "vPart";
			this.vPart.Text = "";
			// 
			// lCont
			// 
			this.lCont.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lCont.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lCont.Location = new NxtControl.Drawing.PointF(20D, 152D);
			this.lCont.Name = "lCont";
			this.lCont.Text = "Posicionamento contínuo (atuador)";
			// 
			// vCont
			// 
			this.vCont.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vCont.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vCont.Location = new NxtControl.Drawing.PointF(230D, 152D);
			this.vCont.Name = "vCont";
			this.vCont.Text = "";
			// 
			// lWords
			// 
			this.lWords.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lWords.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lWords.Location = new NxtControl.Drawing.PointF(20D, 178D);
			this.lWords.Name = "lWords";
			this.lWords.Text = "Status 2 / Alarme 1 / Alarme 2";
			// 
			// vWords
			// 
			this.vWords.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vWords.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vWords.Location = new NxtControl.Drawing.PointF(230D, 178D);
			this.vWords.Name = "vWords";
			this.vWords.Text = "";
			// 
			// lFalha
			// 
			this.lFalha.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFalha.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lFalha.Location = new NxtControl.Drawing.PointF(20D, 204D);
			this.lFalha.Name = "lFalha";
			this.lFalha.Text = "Falha do atuador";
			// 
			// vFalha
			// 
			this.vFalha.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vFalha.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vFalha.Location = new NxtControl.Drawing.PointF(230D, 204D);
			this.vFalha.Name = "vFalha";
			this.vFalha.Text = "";
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(236D)), ((float)(320D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rPar
			// 
			this.rPar.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rPar.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rPar.Location = new NxtControl.Drawing.PointF(20D, 246D);
			this.rPar.Name = "rPar";
			this.rPar.Text = "Supervisão de posição";
			// 
			// lTempo
			// 
			this.lTempo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTempo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lTempo.Location = new NxtControl.Drawing.PointF(20D, 272D);
			this.lTempo.Name = "lTempo";
			this.lTempo.Text = "Tempo máx. para atingir (0 = desliga)";
			// 
			// vTempo
			// 
			this.vTempo.BeginInit();
			this.vTempo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 260D, 266D);
			this.vTempo.MaximumTag = null;
			this.vTempo.MinimumTag = null;
			this.vTempo.Name = "vTempo";
			this.vTempo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.vTempo.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.vTempo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.vTempo.Suffix = " s";
			this.vTempo.TagName = "STP_TEMPO_FALHA_POSICAO";
			this.vTempo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vTempo.UseInputPad = true;
			this.vTempo.Value = ((short)(0));
			this.vTempo.EndInit();
			// 
			// lTol
			// 
			this.lTol.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTol.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.lTol.Location = new NxtControl.Drawing.PointF(20D, 304D);
			this.lTol.Name = "lTol";
			this.lTol.Text = "Tolerância de posição (0 = 2 %)";
			// 
			// vTol
			// 
			this.vTol.BeginInit();
			this.vTol.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 260D, 298D);
			this.vTol.MaximumTag = null;
			this.vTol.MinimumTag = null;
			this.vTol.Name = "vTol";
			this.vTol.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.vTol.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.vTol.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.vTol.Suffix = " %";
			this.vTol.TagName = "STP_TOLERANCIA_POSICAO";
			this.vTol.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vTol.UseInputPad = true;
			this.vTol.Value = 0F;
			this.vTol.EndInit();
			// 
			// xTORQ
			// 
			this.xTORQ.BeginInit();
			this.xTORQ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTORQ.IsOnlyInput = true;
			this.xTORQ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTORQ.Name = "xTORQ";
			this.xTORQ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTORQ.TagName = "STS_TORQUE";
			this.xTORQ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTORQValueChanged);
			this.xTORQ.EndInit();
			// 
			// xTORQP
			// 
			this.xTORQP.BeginInit();
			this.xTORQP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTORQP.IsOnlyInput = true;
			this.xTORQP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTORQP.Name = "xTORQP";
			this.xTORQP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTORQP.TagName = "STS_TORQUE_PCT";
			this.xTORQP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTORQPValueChanged);
			this.xTORQP.EndInit();
			// 
			// xTEMP
			// 
			this.xTEMP.BeginInit();
			this.xTEMP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTEMP.IsOnlyInput = true;
			this.xTEMP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTEMP.Name = "xTEMP";
			this.xTEMP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTEMP.TagName = "STS_TEMPERATURA";
			this.xTEMP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTEMPValueChanged);
			this.xTEMP.EndInit();
			// 
			// xTPERC
			// 
			this.xTPERC.BeginInit();
			this.xTPERC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTPERC.IsOnlyInput = true;
			this.xTPERC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTPERC.Name = "xTPERC";
			this.xTPERC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTPERC.TagName = "STS_TEMPO_PERCURSO";
			this.xTPERC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTPERCValueChanged);
			this.xTPERC.EndInit();
			// 
			// xPDIA
			// 
			this.xPDIA.BeginInit();
			this.xPDIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPDIA.IsOnlyInput = true;
			this.xPDIA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPDIA.Name = "xPDIA";
			this.xPDIA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPDIA.TagName = "STS_PARTIDAS_DIA";
			this.xPDIA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XPDIAValueChanged);
			this.xPDIA.EndInit();
			// 
			// xPMAX
			// 
			this.xPMAX.BeginInit();
			this.xPMAX.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPMAX.IsOnlyInput = true;
			this.xPMAX.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPMAX.Name = "xPMAX";
			this.xPMAX.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPMAX.TagName = "STS_PARTIDAS_DIA_MAX";
			this.xPMAX.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XPMAXValueChanged);
			this.xPMAX.EndInit();
			// 
			// xMCONT
			// 
			this.xMCONT.BeginInit();
			this.xMCONT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMCONT.IsOnlyInput = true;
			this.xMCONT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMCONT.Name = "xMCONT";
			this.xMCONT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMCONT.TagName = "STS_MODO_CONTINUO";
			this.xMCONT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XMCONTValueChanged);
			this.xMCONT.EndInit();
			// 
			// xW2
			// 
			this.xW2.BeginInit();
			this.xW2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xW2.IsOnlyInput = true;
			this.xW2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xW2.Name = "xW2";
			this.xW2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xW2.TagName = "STS_STATUS2";
			this.xW2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XW2ValueChanged);
			this.xW2.EndInit();
			// 
			// xW3
			// 
			this.xW3.BeginInit();
			this.xW3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xW3.IsOnlyInput = true;
			this.xW3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xW3.Name = "xW3";
			this.xW3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xW3.TagName = "STS_ALARME1";
			this.xW3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XW3ValueChanged);
			this.xW3.EndInit();
			// 
			// xW4
			// 
			this.xW4.BeginInit();
			this.xW4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xW4.IsOnlyInput = true;
			this.xW4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xW4.Name = "xW4";
			this.xW4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xW4.TagName = "STS_ALARME2";
			this.xW4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XW4ValueChanged);
			this.xW4.EndInit();
			// 
			// xCOD
			// 
			this.xCOD.BeginInit();
			this.xCOD.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCOD.IsOnlyInput = true;
			this.xCOD.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCOD.Name = "xCOD";
			this.xCOD.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCOD.TagName = "STS_CODIGO_FALHA";
			this.xCOD.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCODValueChanged);
			this.xCOD.EndInit();
			// 
			// xFATU
			// 
			this.xFATU.BeginInit();
			this.xFATU.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFATU.IsOnlyInput = true;
			this.xFATU.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFATU.Name = "xFATU";
			this.xFATU.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFATU.TagName = "STS_FALHA_ATUADOR";
			this.xFATU.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFATUValueChanged);
			this.xFATU.EndInit();
			// 
			// fpDiagnostico
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(360D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.titulo,
			this.lTorque,
			this.vTorque,
			this.lTemp,
			this.vTemp,
			this.lPerc,
			this.vPerc,
			this.lPart,
			this.vPart,
			this.lCont,
			this.vCont,
			this.lWords,
			this.vWords,
			this.lFalha,
			this.vFalha,
			this.sep,
			this.rPar,
			this.lTempo,
			this.vTempo,
			this.lTol,
			this.vTol,
			this.xTORQ,
			this.xTORQP,
			this.xTEMP,
			this.xTPERC,
			this.xPDIA,
			this.xPMAX,
			this.xMCONT,
			this.xW2,
			this.xW3,
			this.xW4,
			this.xCOD,
			this.xFATU});
			this.Size = new System.Drawing.Size(360, 360);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText lTorque;
		private NxtControl.GuiFramework.FreeText vTorque;
		private NxtControl.GuiFramework.FreeText lTemp;
		private NxtControl.GuiFramework.FreeText vTemp;
		private NxtControl.GuiFramework.FreeText lPerc;
		private NxtControl.GuiFramework.FreeText vPerc;
		private NxtControl.GuiFramework.FreeText lPart;
		private NxtControl.GuiFramework.FreeText vPart;
		private NxtControl.GuiFramework.FreeText lCont;
		private NxtControl.GuiFramework.FreeText vCont;
		private NxtControl.GuiFramework.FreeText lWords;
		private NxtControl.GuiFramework.FreeText vWords;
		private NxtControl.GuiFramework.FreeText lFalha;
		private NxtControl.GuiFramework.FreeText vFalha;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.FreeText rPar;
		private NxtControl.GuiFramework.FreeText lTempo;
		private System.HMI.Symbols.Base.TextBox<short> vTempo;
		private NxtControl.GuiFramework.FreeText lTol;
		private System.HMI.Symbols.Base.TextBox<float> vTol;
		private System.HMI.Symbols.Base.Execute<short> xTORQ;
		private System.HMI.Symbols.Base.Execute<short> xTORQP;
		private System.HMI.Symbols.Base.Execute<short> xTEMP;
		private System.HMI.Symbols.Base.Execute<short> xTPERC;
		private System.HMI.Symbols.Base.Execute<short> xPDIA;
		private System.HMI.Symbols.Base.Execute<short> xPMAX;
		private System.HMI.Symbols.Base.Execute<bool> xMCONT;
		private System.HMI.Symbols.Base.Execute<short> xW2;
		private System.HMI.Symbols.Base.Execute<short> xW3;
		private System.HMI.Symbols.Base.Execute<short> xW4;
		private System.HMI.Symbols.Base.Execute<short> xCOD;
		private System.HMI.Symbols.Base.Execute<bool> xFATU;
		#endregion
	}
}
