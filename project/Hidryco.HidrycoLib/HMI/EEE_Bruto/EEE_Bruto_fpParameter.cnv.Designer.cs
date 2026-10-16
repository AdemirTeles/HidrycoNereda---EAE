/*
 * Hidryco - EEE_Bruto - fpParameter
 * ISA-101: ajustes da elevatoria - faixas de nivel, revezamento e PID de velocidade (mesmas tags dos CATs antigos).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.EEE_Bruto
{
	/// <summary>
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.sepNec = new NxtControl.GuiFramework.Rectangle();
			this.titNec = new NxtControl.GuiFramework.FreeText();
			this.lNec = new NxtControl.GuiFramework.FreeText();
			this.cNec = new System.HMI.Symbols.Base.CheckButton();
			this.lF3 = new NxtControl.GuiFramework.FreeText();
			this.tF3 = new System.HMI.Symbols.Base.TextBox<float>();
			this.lF4 = new NxtControl.GuiFramework.FreeText();
			this.tF4 = new System.HMI.Symbols.Base.TextBox<float>();
			this.lF2 = new NxtControl.GuiFramework.FreeText();
			this.tF2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.lF1 = new NxtControl.GuiFramework.FreeText();
			this.tF1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.sepRev = new NxtControl.GuiFramework.Rectangle();
			this.titRev = new NxtControl.GuiFramework.FreeText();
			this.lRev = new NxtControl.GuiFramework.FreeText();
			this.cRev = new System.HMI.Symbols.Base.CheckButton();
			this.lB1 = new NxtControl.GuiFramework.FreeText();
			this.tB1 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lB2 = new NxtControl.GuiFramework.FreeText();
			this.tB2 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lB3 = new NxtControl.GuiFramework.FreeText();
			this.tB3 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lSel = new NxtControl.GuiFramework.FreeText();
			this.tSel = new System.HMI.Symbols.Base.TextBox<short>();
			this.sepPid = new NxtControl.GuiFramework.Rectangle();
			this.titPid = new NxtControl.GuiFramework.FreeText();
			this.lPid = new NxtControl.GuiFramework.FreeText();
			this.cPid = new System.HMI.Symbols.Base.CheckButton();
			this.lSp = new NxtControl.GuiFramework.FreeText();
			this.tSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.lKp = new NxtControl.GuiFramework.FreeText();
			this.tKp = new System.HMI.Symbols.Base.TextBox<float>();
			this.lKi = new NxtControl.GuiFramework.FreeText();
			this.tKi = new System.HMI.Symbols.Base.TextBox<float>();
			this.lKd = new NxtControl.GuiFramework.FreeText();
			this.tKd = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMin = new NxtControl.GuiFramework.FreeText();
			this.tMin = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMax = new NxtControl.GuiFramework.FreeText();
			this.tMax = new System.HMI.Symbols.Base.TextBox<float>();
			this.ajuda = new NxtControl.GuiFramework.FreeText();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes da elevatória";
			// 
			// sepNec
			// 
			this.sepNec.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(46D)), ((float)(430D)), ((float)(1D)));
			this.sepNec.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sepNec.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepNec.Name = "sepNec";
			this.sepNec.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titNec
			// 
			this.titNec.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titNec.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titNec.Location = new NxtControl.Drawing.PointF(20D, 54D);
			this.titNec.Name = "titNec";
			this.titNec.Text = "Faixas de nível (LIT-03) - número de bombas";
			// 
			// lNec
			// 
			this.lNec.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lNec.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lNec.Location = new NxtControl.Drawing.PointF(30D, 86D);
			this.lNec.Name = "lNec";
			this.lNec.Text = "Automático da elevatória";
			// 
			// cNec
			// 
			this.cNec.BeginInit();
			this.cNec.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 330D, 80D);
			this.cNec.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cNec.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cNec.FalseText = "Desabilitado";
			this.cNec.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cNec.FontScale = false;
			this.cNec.Name = "cNec";
			this.cNec.TagName = "NEC_CMD_HABILITA";
			this.cNec.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cNec.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cNec.TrueText = "Habilitado";
			this.cNec.Value = false;
			this.cNec.EndInit();
			// 
			// lF3
			// 
			this.lF3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lF3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lF3.Location = new NxtControl.Drawing.PointF(30D, 122D);
			this.lF3.Name = "lF3";
			this.lF3.Text = "Parada: liga a 1ª bomba no nível";
			// 
			// tF3
			// 
			this.tF3.BeginInit();
			this.tF3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 118D);
			this.tF3.MaximumTag = null;
			this.tF3.MinimumTag = null;
			this.tF3.Name = "tF3";
			this.tF3.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tF3.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tF3.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tF3.Suffix = "";
			this.tF3.TagName = "STP_LIMITE_FAIXA_3";
			this.tF3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tF3.UseInputPad = true;
			this.tF3.Value = 0F;
			this.tF3.EndInit();
			// 
			// lF4
			// 
			this.lF4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lF4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lF4.Location = new NxtControl.Drawing.PointF(30D, 156D);
			this.lF4.Name = "lF4";
			this.lF4.Text = "Com 1 bomba: liga a 2ª no nível";
			// 
			// tF4
			// 
			this.tF4.BeginInit();
			this.tF4.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 152D);
			this.tF4.MaximumTag = null;
			this.tF4.MinimumTag = null;
			this.tF4.Name = "tF4";
			this.tF4.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tF4.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tF4.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tF4.Suffix = "";
			this.tF4.TagName = "STP_LIMITE_FAIXA_4";
			this.tF4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tF4.UseInputPad = true;
			this.tF4.Value = 0F;
			this.tF4.EndInit();
			// 
			// lF2
			// 
			this.lF2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lF2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lF2.Location = new NxtControl.Drawing.PointF(30D, 190D);
			this.lF2.Name = "lF2";
			this.lF2.Text = "Com 2 bombas: desliga a 2ª abaixo de";
			// 
			// tF2
			// 
			this.tF2.BeginInit();
			this.tF2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 186D);
			this.tF2.MaximumTag = null;
			this.tF2.MinimumTag = null;
			this.tF2.Name = "tF2";
			this.tF2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tF2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tF2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tF2.Suffix = "";
			this.tF2.TagName = "STP_LIMITE_FAIXA_2";
			this.tF2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tF2.UseInputPad = true;
			this.tF2.Value = 0F;
			this.tF2.EndInit();
			// 
			// lF1
			// 
			this.lF1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lF1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lF1.Location = new NxtControl.Drawing.PointF(30D, 224D);
			this.lF1.Name = "lF1";
			this.lF1.Text = "Com 1 bomba: desliga abaixo de";
			// 
			// tF1
			// 
			this.tF1.BeginInit();
			this.tF1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 220D);
			this.tF1.MaximumTag = null;
			this.tF1.MinimumTag = null;
			this.tF1.Name = "tF1";
			this.tF1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tF1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tF1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tF1.Suffix = "";
			this.tF1.TagName = "STP_LIMITE_FAIXA_1";
			this.tF1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tF1.UseInputPad = true;
			this.tF1.Value = 0F;
			this.tF1.EndInit();
			// 
			// sepRev
			// 
			this.sepRev.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(254D)), ((float)(430D)), ((float)(1D)));
			this.sepRev.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sepRev.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepRev.Name = "sepRev";
			this.sepRev.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titRev
			// 
			this.titRev.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titRev.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titRev.Location = new NxtControl.Drawing.PointF(20D, 262D);
			this.titRev.Name = "titRev";
			this.titRev.Text = "Revezamento";
			// 
			// lRev
			// 
			this.lRev.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lRev.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lRev.Location = new NxtControl.Drawing.PointF(30D, 294D);
			this.lRev.Name = "lRev";
			this.lRev.Text = "Troca da principal por tempo";
			// 
			// cRev
			// 
			this.cRev.BeginInit();
			this.cRev.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 330D, 288D);
			this.cRev.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cRev.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cRev.FalseText = "Desabilitado";
			this.cRev.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cRev.FontScale = false;
			this.cRev.Name = "cRev";
			this.cRev.TagName = "REV_CMD_HABILITA";
			this.cRev.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cRev.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cRev.TrueText = "Habilitado";
			this.cRev.Value = false;
			this.cRev.EndInit();
			// 
			// lB1
			// 
			this.lB1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lB1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lB1.Location = new NxtControl.Drawing.PointF(30D, 330D);
			this.lB1.Name = "lB1";
			this.lB1.Text = "Horas da BS-01 como principal";
			// 
			// tB1
			// 
			this.tB1.BeginInit();
			this.tB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 326D);
			this.tB1.MaximumTag = null;
			this.tB1.MinimumTag = null;
			this.tB1.Name = "tB1";
			this.tB1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tB1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tB1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tB1.Suffix = " h";
			this.tB1.TagName = "STP_TEMPO_B1";
			this.tB1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tB1.UseInputPad = true;
			this.tB1.Value = ((ushort)(0));
			this.tB1.EndInit();
			// 
			// lB2
			// 
			this.lB2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lB2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lB2.Location = new NxtControl.Drawing.PointF(30D, 364D);
			this.lB2.Name = "lB2";
			this.lB2.Text = "Horas da BS-02 como principal";
			// 
			// tB2
			// 
			this.tB2.BeginInit();
			this.tB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 360D);
			this.tB2.MaximumTag = null;
			this.tB2.MinimumTag = null;
			this.tB2.Name = "tB2";
			this.tB2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tB2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tB2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tB2.Suffix = " h";
			this.tB2.TagName = "STP_TEMPO_B2";
			this.tB2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tB2.UseInputPad = true;
			this.tB2.Value = ((ushort)(0));
			this.tB2.EndInit();
			// 
			// lB3
			// 
			this.lB3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lB3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lB3.Location = new NxtControl.Drawing.PointF(30D, 398D);
			this.lB3.Name = "lB3";
			this.lB3.Text = "Horas da BS-03 como principal";
			// 
			// tB3
			// 
			this.tB3.BeginInit();
			this.tB3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 394D);
			this.tB3.MaximumTag = null;
			this.tB3.MinimumTag = null;
			this.tB3.Name = "tB3";
			this.tB3.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tB3.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tB3.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tB3.Suffix = " h";
			this.tB3.TagName = "STP_TEMPO_B3";
			this.tB3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tB3.UseInputPad = true;
			this.tB3.Value = ((ushort)(0));
			this.tB3.EndInit();
			// 
			// lSel
			// 
			this.lSel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSel.Location = new NxtControl.Drawing.PointF(30D, 432D);
			this.lSel.Name = "lSel";
			this.lSel.Text = "Principal: 0 = automática, 1-2-3 = fixa";
			// 
			// tSel
			// 
			this.tSel.BeginInit();
			this.tSel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 428D);
			this.tSel.MaximumTag = null;
			this.tSel.MinimumTag = null;
			this.tSel.Name = "tSel";
			this.tSel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tSel.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tSel.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tSel.Suffix = "";
			this.tSel.TagName = "CMD_SELECAO_BOMBA";
			this.tSel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tSel.UseInputPad = true;
			this.tSel.Value = ((short)(0));
			this.tSel.EndInit();
			// 
			// sepPid
			// 
			this.sepPid.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(462D)), ((float)(430D)), ((float)(1D)));
			this.sepPid.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sepPid.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepPid.Name = "sepPid";
			this.sepPid.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titPid
			// 
			this.titPid.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titPid.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titPid.Location = new NxtControl.Drawing.PointF(20D, 470D);
			this.titPid.Name = "titPid";
			this.titPid.Text = "Velocidade (PID de nível)";
			// 
			// lPid
			// 
			this.lPid.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lPid.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lPid.Location = new NxtControl.Drawing.PointF(30D, 502D);
			this.lPid.Name = "lPid";
			this.lPid.Text = "Velocidade pelo PID (desligado = máxima)";
			// 
			// cPid
			// 
			this.cPid.BeginInit();
			this.cPid.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 330D, 496D);
			this.cPid.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cPid.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cPid.FalseText = "Desabilitado";
			this.cPid.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cPid.FontScale = false;
			this.cPid.Name = "cPid";
			this.cPid.TagName = "PID_CMD_HABILITA";
			this.cPid.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cPid.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cPid.TrueText = "Habilitado";
			this.cPid.Value = false;
			this.cPid.EndInit();
			// 
			// lSp
			// 
			this.lSp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSp.Location = new NxtControl.Drawing.PointF(30D, 538D);
			this.lSp.Name = "lSp";
			this.lSp.Text = "Nível desejado do poço";
			// 
			// tSp
			// 
			this.tSp.BeginInit();
			this.tSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 534D);
			this.tSp.MaximumTag = null;
			this.tSp.MinimumTag = null;
			this.tSp.Name = "tSp";
			this.tSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tSp.Suffix = "";
			this.tSp.TagName = "STP_DESEJADO";
			this.tSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tSp.UseInputPad = true;
			this.tSp.Value = 0F;
			this.tSp.EndInit();
			// 
			// lKp
			// 
			this.lKp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lKp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lKp.Location = new NxtControl.Drawing.PointF(30D, 572D);
			this.lKp.Name = "lKp";
			this.lKp.Text = "Ganho (Kp)";
			// 
			// tKp
			// 
			this.tKp.BeginInit();
			this.tKp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 568D);
			this.tKp.MaximumTag = null;
			this.tKp.MinimumTag = null;
			this.tKp.Name = "tKp";
			this.tKp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tKp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tKp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tKp.Suffix = "";
			this.tKp.TagName = "STP_PARAMETRO_KP";
			this.tKp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tKp.UseInputPad = true;
			this.tKp.Value = 0F;
			this.tKp.EndInit();
			// 
			// lKi
			// 
			this.lKi.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lKi.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lKi.Location = new NxtControl.Drawing.PointF(30D, 606D);
			this.lKi.Name = "lKi";
			this.lKi.Text = "Tempo integral (s)";
			// 
			// tKi
			// 
			this.tKi.BeginInit();
			this.tKi.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 602D);
			this.tKi.MaximumTag = null;
			this.tKi.MinimumTag = null;
			this.tKi.Name = "tKi";
			this.tKi.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tKi.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tKi.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tKi.Suffix = " s";
			this.tKi.TagName = "STP_PARAMETRO_KI";
			this.tKi.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tKi.UseInputPad = true;
			this.tKi.Value = 0F;
			this.tKi.EndInit();
			// 
			// lKd
			// 
			this.lKd.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lKd.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lKd.Location = new NxtControl.Drawing.PointF(30D, 640D);
			this.lKd.Name = "lKd";
			this.lKd.Text = "Tempo derivativo (s)";
			// 
			// tKd
			// 
			this.tKd.BeginInit();
			this.tKd.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 636D);
			this.tKd.MaximumTag = null;
			this.tKd.MinimumTag = null;
			this.tKd.Name = "tKd";
			this.tKd.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tKd.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tKd.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tKd.Suffix = " s";
			this.tKd.TagName = "STP_PARAMETRO_KD";
			this.tKd.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tKd.UseInputPad = true;
			this.tKd.Value = 0F;
			this.tKd.EndInit();
			// 
			// lMin
			// 
			this.lMin.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMin.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMin.Location = new NxtControl.Drawing.PointF(30D, 674D);
			this.lMin.Name = "lMin";
			this.lMin.Text = "Velocidade mínima";
			// 
			// tMin
			// 
			this.tMin.BeginInit();
			this.tMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 670D);
			this.tMin.MaximumTag = null;
			this.tMin.MinimumTag = null;
			this.tMin.Name = "tMin";
			this.tMin.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tMin.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tMin.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tMin.Suffix = " %";
			this.tMin.TagName = "STP_MINIMO";
			this.tMin.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tMin.UseInputPad = true;
			this.tMin.Value = 0F;
			this.tMin.EndInit();
			// 
			// lMax
			// 
			this.lMax.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMax.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMax.Location = new NxtControl.Drawing.PointF(30D, 708D);
			this.lMax.Name = "lMax";
			this.lMax.Text = "Velocidade máxima";
			// 
			// tMax
			// 
			this.tMax.BeginInit();
			this.tMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 330D, 704D);
			this.tMax.MaximumTag = null;
			this.tMax.MinimumTag = null;
			this.tMax.Name = "tMax";
			this.tMax.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tMax.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tMax.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tMax.Suffix = " %";
			this.tMax.TagName = "STP_MAXIMO";
			this.tMax.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tMax.UseInputPad = true;
			this.tMax.Value = 0F;
			this.tMax.EndInit();
			// 
			// ajuda
			// 
			this.ajuda.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ajuda.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda.Location = new NxtControl.Drawing.PointF(30D, 740D);
			this.ajuda.Name = "ajuda";
			this.ajuda.Text = "Faixas e nível desejado na unidade do LIT-03. 0 h = sem troca por tempo.";
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(470D)), ((float)(768D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpParameter";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.sepNec,
			this.titNec,
			this.lNec,
			this.cNec,
			this.lF3,
			this.tF3,
			this.lF4,
			this.tF4,
			this.lF2,
			this.tF2,
			this.lF1,
			this.tF1,
			this.sepRev,
			this.titRev,
			this.lRev,
			this.cRev,
			this.lB1,
			this.tB1,
			this.lB2,
			this.tB2,
			this.lB3,
			this.tB3,
			this.lSel,
			this.tSel,
			this.sepPid,
			this.titPid,
			this.lPid,
			this.cPid,
			this.lSp,
			this.tSp,
			this.lKp,
			this.tKp,
			this.lKi,
			this.tKi,
			this.lKd,
			this.tKd,
			this.lMin,
			this.tMin,
			this.lMax,
			this.tMax,
			this.ajuda});
			this.Size = new System.Drawing.Size(470, 768);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.Rectangle sepNec;
		private NxtControl.GuiFramework.FreeText titNec;
		private NxtControl.GuiFramework.FreeText lNec;
		private System.HMI.Symbols.Base.CheckButton cNec;
		private NxtControl.GuiFramework.FreeText lF3;
		private System.HMI.Symbols.Base.TextBox<float> tF3;
		private NxtControl.GuiFramework.FreeText lF4;
		private System.HMI.Symbols.Base.TextBox<float> tF4;
		private NxtControl.GuiFramework.FreeText lF2;
		private System.HMI.Symbols.Base.TextBox<float> tF2;
		private NxtControl.GuiFramework.FreeText lF1;
		private System.HMI.Symbols.Base.TextBox<float> tF1;
		private NxtControl.GuiFramework.Rectangle sepRev;
		private NxtControl.GuiFramework.FreeText titRev;
		private NxtControl.GuiFramework.FreeText lRev;
		private System.HMI.Symbols.Base.CheckButton cRev;
		private NxtControl.GuiFramework.FreeText lB1;
		private System.HMI.Symbols.Base.TextBox<ushort> tB1;
		private NxtControl.GuiFramework.FreeText lB2;
		private System.HMI.Symbols.Base.TextBox<ushort> tB2;
		private NxtControl.GuiFramework.FreeText lB3;
		private System.HMI.Symbols.Base.TextBox<ushort> tB3;
		private NxtControl.GuiFramework.FreeText lSel;
		private System.HMI.Symbols.Base.TextBox<short> tSel;
		private NxtControl.GuiFramework.Rectangle sepPid;
		private NxtControl.GuiFramework.FreeText titPid;
		private NxtControl.GuiFramework.FreeText lPid;
		private System.HMI.Symbols.Base.CheckButton cPid;
		private NxtControl.GuiFramework.FreeText lSp;
		private System.HMI.Symbols.Base.TextBox<float> tSp;
		private NxtControl.GuiFramework.FreeText lKp;
		private System.HMI.Symbols.Base.TextBox<float> tKp;
		private NxtControl.GuiFramework.FreeText lKi;
		private System.HMI.Symbols.Base.TextBox<float> tKi;
		private NxtControl.GuiFramework.FreeText lKd;
		private System.HMI.Symbols.Base.TextBox<float> tKd;
		private NxtControl.GuiFramework.FreeText lMin;
		private System.HMI.Symbols.Base.TextBox<float> tMin;
		private NxtControl.GuiFramework.FreeText lMax;
		private System.HMI.Symbols.Base.TextBox<float> tMax;
		private NxtControl.GuiFramework.FreeText ajuda;
		#endregion
	}
}
