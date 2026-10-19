/*
 * Hidryco - Desinfeccao_UV - fpDefault
 * Desinfeccao: estado do controle, parametros do PID e dos alarmes, totalizador e reconhecimento.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Desinfeccao_UV
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.e1 = new NxtControl.GuiFramework.FreeText();
			this.e2 = new NxtControl.GuiFramework.FreeText();
			this.rCtl = new NxtControl.GuiFramework.FreeText();
			this.btnDesab = new NxtControl.GuiFramework.DrawnButton();
			this.btnHab = new NxtControl.GuiFramework.DrawnButton();
			this.l0 = new NxtControl.GuiFramework.FreeText();
			this.t0 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.t1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.t2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l3 = new NxtControl.GuiFramework.FreeText();
			this.t3 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l4 = new NxtControl.GuiFramework.FreeText();
			this.t4 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l5 = new NxtControl.GuiFramework.FreeText();
			this.t5 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l6 = new NxtControl.GuiFramework.FreeText();
			this.t6 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l7 = new NxtControl.GuiFramework.FreeText();
			this.t7 = new System.HMI.Symbols.Base.TextBox<short>();
			this.l8 = new NxtControl.GuiFramework.FreeText();
			this.t8 = new System.HMI.Symbols.Base.TextBox<float>();
			this.rTot = new NxtControl.GuiFramework.FreeText();
			this.btnZera = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.xVAZ = new System.HMI.Symbols.Base.Execute<float>();
			this.xVMAX = new System.HMI.Symbols.Base.Execute<float>();
			this.xATIVO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMOT = new System.HMI.Symbols.Base.Execute<short>();
			this.xSPID = new System.HMI.Symbols.Base.Execute<float>();
			this.xVPOS = new System.HMI.Symbols.Base.Execute<float>();
			this.xFTF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xADJ = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVR = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDPCE = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDPCM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDUV1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDUV2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDVC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDMO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEVA = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVR = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEDJ = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEREM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xHAB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xTOT = new System.HMI.Symbols.Base.Execute<int>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(80D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(12D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 13D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(12D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 28D),
			new NxtControl.Drawing.PointF(28D, 12D),
			new NxtControl.Drawing.PointF(36D, 28D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 15D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 12D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 34D);
			this.e1.Name = "e1";
			this.e1.Text = "";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(20D, 56D);
			this.e2.Name = "e2";
			this.e2.Text = "";
			// 
			// rCtl
			// 
			this.rCtl.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rCtl.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rCtl.Location = new NxtControl.Drawing.PointF(20D, 90D);
			this.rCtl.Name = "rCtl";
			this.rCtl.Text = "Controle de vazão (700-VC-01)";
			// 
			// btnDesab
			// 
			this.btnDesab.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(110D)), ((float)(170D)), ((float)(32D)));
			this.btnDesab.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesab.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnDesab.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesab.Name = "btnDesab";
			this.btnDesab.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesab.Radius = 2D;
			this.btnDesab.Text = "Desabilitar";
			this.btnDesab.Use3DEffect = false;
			this.btnDesab.Click += new System.EventHandler(this.BtnDesabClick);
			// 
			// btnHab
			// 
			this.btnHab.Bounds = new NxtControl.Drawing.RectF(((float)(210D)), ((float)(110D)), ((float)(170D)), ((float)(32D)));
			this.btnHab.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnHab.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnHab.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnHab.Name = "btnHab";
			this.btnHab.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnHab.Radius = 2D;
			this.btnHab.Text = "Habilitar";
			this.btnHab.Use3DEffect = false;
			this.btnHab.Click += new System.EventHandler(this.BtnHabClick);
			// 
			// l0
			// 
			this.l0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l0.Location = new NxtControl.Drawing.PointF(20D, 156D);
			this.l0.Name = "l0";
			this.l0.Text = "Vazão máxima (setpoint)";
			// 
			// t0
			// 
			this.t0.BeginInit();
			this.t0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 152D);
			this.t0.MaximumTag = null;
			this.t0.MinimumTag = null;
			this.t0.Name = "t0";
			this.t0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t0.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t0.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t0.Suffix = " m³/h";
			this.t0.TagName = "STP_VAZAO_MAX";
			this.t0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t0.UseInputPad = true;
			this.t0.Value = 0F;
			this.t0.EndInit();
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l1.Location = new NxtControl.Drawing.PointF(20D, 186D);
			this.l1.Name = "l1";
			this.l1.Text = "PID ganho (% por m³/h)";
			// 
			// t1
			// 
			this.t1.BeginInit();
			this.t1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 182D);
			this.t1.MaximumTag = null;
			this.t1.MinimumTag = null;
			this.t1.Name = "t1";
			this.t1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t1.Suffix = "";
			this.t1.TagName = "STP_PARAMETRO_KP";
			this.t1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t1.UseInputPad = true;
			this.t1.Value = 0F;
			this.t1.EndInit();
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(20D, 216D);
			this.l2.Name = "l2";
			this.l2.Text = "PID tempo integral";
			// 
			// t2
			// 
			this.t2.BeginInit();
			this.t2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 212D);
			this.t2.MaximumTag = null;
			this.t2.MinimumTag = null;
			this.t2.Name = "t2";
			this.t2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t2.Suffix = " s";
			this.t2.TagName = "STP_PARAMETRO_KI";
			this.t2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t2.UseInputPad = true;
			this.t2.Value = 0F;
			this.t2.EndInit();
			// 
			// l3
			// 
			this.l3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l3.Location = new NxtControl.Drawing.PointF(20D, 246D);
			this.l3.Name = "l3";
			this.l3.Text = "PID tempo derivativo";
			// 
			// t3
			// 
			this.t3.BeginInit();
			this.t3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 242D);
			this.t3.MaximumTag = null;
			this.t3.MinimumTag = null;
			this.t3.Name = "t3";
			this.t3.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t3.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t3.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t3.Suffix = " s";
			this.t3.TagName = "STP_PARAMETRO_KD";
			this.t3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t3.UseInputPad = true;
			this.t3.Value = 0F;
			this.t3.EndInit();
			// 
			// l4
			// 
			this.l4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l4.Location = new NxtControl.Drawing.PointF(20D, 276D);
			this.l4.Name = "l4";
			this.l4.Text = "Abertura mínima";
			// 
			// t4
			// 
			this.t4.BeginInit();
			this.t4.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 272D);
			this.t4.MaximumTag = null;
			this.t4.MinimumTag = null;
			this.t4.Name = "t4";
			this.t4.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t4.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t4.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t4.Suffix = " %";
			this.t4.TagName = "STP_MINIMO";
			this.t4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t4.UseInputPad = true;
			this.t4.Value = 0F;
			this.t4.EndInit();
			// 
			// l5
			// 
			this.l5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l5.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l5.Location = new NxtControl.Drawing.PointF(20D, 306D);
			this.l5.Name = "l5";
			this.l5.Text = "Abertura máxima";
			// 
			// t5
			// 
			this.t5.BeginInit();
			this.t5.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 302D);
			this.t5.MaximumTag = null;
			this.t5.MinimumTag = null;
			this.t5.Name = "t5";
			this.t5.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t5.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t5.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t5.Suffix = " %";
			this.t5.TagName = "STP_MAXIMO";
			this.t5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t5.UseInputPad = true;
			this.t5.Value = 0F;
			this.t5.EndInit();
			// 
			// l6
			// 
			this.l6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l6.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l6.Location = new NxtControl.Drawing.PointF(20D, 336D);
			this.l6.Name = "l6";
			this.l6.Text = "Alarme: tolerância acima do limite";
			// 
			// t6
			// 
			this.t6.BeginInit();
			this.t6.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 332D);
			this.t6.MaximumTag = null;
			this.t6.MinimumTag = null;
			this.t6.Name = "t6";
			this.t6.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t6.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t6.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t6.Suffix = " %";
			this.t6.TagName = "STP_TOL_VAZAO";
			this.t6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t6.UseInputPad = true;
			this.t6.Value = 0F;
			this.t6.EndInit();
			// 
			// l7
			// 
			this.l7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l7.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l7.Location = new NxtControl.Drawing.PointF(20D, 366D);
			this.l7.Name = "l7";
			this.l7.Text = "Alarme: tempo acima do limite (0 = desl.)";
			// 
			// t7
			// 
			this.t7.BeginInit();
			this.t7.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 362D);
			this.t7.MaximumTag = null;
			this.t7.MinimumTag = null;
			this.t7.Name = "t7";
			this.t7.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t7.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t7.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t7.Suffix = " s";
			this.t7.TagName = "STP_TEMPO_VAZAO";
			this.t7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t7.UseInputPad = true;
			this.t7.Value = ((short)(0));
			this.t7.EndInit();
			// 
			// l8
			// 
			this.l8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l8.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l8.Location = new NxtControl.Drawing.PointF(20D, 396D);
			this.l8.Name = "l8";
			this.l8.Text = "Aviso: variação máx. em 1 min (0 = desl.)";
			// 
			// t8
			// 
			this.t8.BeginInit();
			this.t8.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 290D, 392D);
			this.t8.MaximumTag = null;
			this.t8.MinimumTag = null;
			this.t8.Name = "t8";
			this.t8.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t8.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t8.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t8.Suffix = " m³/h";
			this.t8.TagName = "STP_VARIACAO_MAX";
			this.t8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t8.UseInputPad = true;
			this.t8.Value = 0F;
			this.t8.EndInit();
			// 
			// rTot
			// 
			this.rTot.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rTot.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rTot.Location = new NxtControl.Drawing.PointF(20D, 430D);
			this.rTot.Name = "rTot";
			this.rTot.Text = "";
			// 
			// btnZera
			// 
			this.btnZera.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(456D)), ((float)(170D)), ((float)(34D)));
			this.btnZera.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnZera.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnZera.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnZera.Name = "btnZera";
			this.btnZera.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnZera.Radius = 2D;
			this.btnZera.Text = "Zerar totalizador";
			this.btnZera.Use3DEffect = false;
			this.btnZera.Click += new System.EventHandler(this.BtnZeraClick);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(210D)), ((float)(456D)), ((float)(170D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer alarmes";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// xVAZ
			// 
			this.xVAZ.BeginInit();
			this.xVAZ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVAZ.IsOnlyInput = true;
			this.xVAZ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVAZ.Name = "xVAZ";
			this.xVAZ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVAZ.TagName = "STS_VAZAO";
			this.xVAZ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVAZValueChanged);
			this.xVAZ.EndInit();
			// 
			// xVMAX
			// 
			this.xVMAX.BeginInit();
			this.xVMAX.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVMAX.IsOnlyInput = true;
			this.xVMAX.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVMAX.Name = "xVMAX";
			this.xVMAX.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVMAX.TagName = "STS_VAZAO_MAX";
			this.xVMAX.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVMAXValueChanged);
			this.xVMAX.EndInit();
			// 
			// xATIVO
			// 
			this.xATIVO.BeginInit();
			this.xATIVO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xATIVO.IsOnlyInput = true;
			this.xATIVO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xATIVO.Name = "xATIVO";
			this.xATIVO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xATIVO.TagName = "STS_CONTROLE_ATIVO";
			this.xATIVO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XATIVOValueChanged);
			this.xATIVO.EndInit();
			// 
			// xMOT
			// 
			this.xMOT.BeginInit();
			this.xMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMOT.IsOnlyInput = true;
			this.xMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMOT.Name = "xMOT";
			this.xMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMOT.TagName = "STS_MOTIVO";
			this.xMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XMOTValueChanged);
			this.xMOT.EndInit();
			// 
			// xSPID
			// 
			this.xSPID.BeginInit();
			this.xSPID.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSPID.IsOnlyInput = true;
			this.xSPID.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSPID.Name = "xSPID";
			this.xSPID.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSPID.TagName = "STS_SAIDA_PID";
			this.xSPID.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSPIDValueChanged);
			this.xSPID.EndInit();
			// 
			// xVPOS
			// 
			this.xVPOS.BeginInit();
			this.xVPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVPOS.IsOnlyInput = true;
			this.xVPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVPOS.Name = "xVPOS";
			this.xVPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVPOS.TagName = "STS_VC_POSICAO";
			this.xVPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVPOSValueChanged);
			this.xVPOS.EndInit();
			// 
			// xFTF
			// 
			this.xFTF.BeginInit();
			this.xFTF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFTF.IsOnlyInput = true;
			this.xFTF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFTF.Name = "xFTF";
			this.xFTF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFTF.TagName = "STS_FT_FALHA";
			this.xFTF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFTFValueChanged);
			this.xFTF.EndInit();
			// 
			// xREM
			// 
			this.xREM.BeginInit();
			this.xREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xREM.IsOnlyInput = true;
			this.xREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xREM.Name = "xREM";
			this.xREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xREM.TagName = "STS_REMOTA_OK";
			this.xREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XREMValueChanged);
			this.xREM.EndInit();
			// 
			// xADJ
			// 
			this.xADJ.BeginInit();
			this.xADJ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xADJ.IsOnlyInput = true;
			this.xADJ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xADJ.Name = "xADJ";
			this.xADJ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xADJ.TagName = "STS_AVISO_DISJUNTOR";
			this.xADJ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XADJValueChanged);
			this.xADJ.EndInit();
			// 
			// xAVA
			// 
			this.xAVA.BeginInit();
			this.xAVA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVA.IsOnlyInput = true;
			this.xAVA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVA.Name = "xAVA";
			this.xAVA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVA.TagName = "STS_ALARME_VAZAO_ALTA";
			this.xAVA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAVAValueChanged);
			this.xAVA.EndInit();
			// 
			// xAVR
			// 
			this.xAVR.BeginInit();
			this.xAVR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVR.IsOnlyInput = true;
			this.xAVR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVR.Name = "xAVR";
			this.xAVR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVR.TagName = "STS_AVISO_VARIACAO";
			this.xAVR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAVRValueChanged);
			this.xAVR.EndInit();
			// 
			// xFREM
			// 
			this.xFREM.BeginInit();
			this.xFREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFREM.IsOnlyInput = true;
			this.xFREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFREM.Name = "xFREM";
			this.xFREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFREM.TagName = "STS_FALHA_REMOTA";
			this.xFREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFREMValueChanged);
			this.xFREM.EndInit();
			// 
			// xDPCE
			// 
			this.xDPCE.BeginInit();
			this.xDPCE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDPCE.IsOnlyInput = true;
			this.xDPCE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDPCE.Name = "xDPCE";
			this.xDPCE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDPCE.TagName = "STS_DJ_PCE_DESLIGADO";
			this.xDPCE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDPCEValueChanged);
			this.xDPCE.EndInit();
			// 
			// xDPCM
			// 
			this.xDPCM.BeginInit();
			this.xDPCM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDPCM.IsOnlyInput = true;
			this.xDPCM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDPCM.Name = "xDPCM";
			this.xDPCM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDPCM.TagName = "STS_DJ_PCM_DESLIGADO";
			this.xDPCM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDPCMValueChanged);
			this.xDPCM.EndInit();
			// 
			// xDUV1
			// 
			this.xDUV1.BeginInit();
			this.xDUV1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDUV1.IsOnlyInput = true;
			this.xDUV1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDUV1.Name = "xDUV1";
			this.xDUV1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDUV1.TagName = "STS_DJ_UV01";
			this.xDUV1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDUV1ValueChanged);
			this.xDUV1.EndInit();
			// 
			// xDUV2
			// 
			this.xDUV2.BeginInit();
			this.xDUV2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDUV2.IsOnlyInput = true;
			this.xDUV2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDUV2.Name = "xDUV2";
			this.xDUV2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDUV2.TagName = "STS_DJ_UV02";
			this.xDUV2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDUV2ValueChanged);
			this.xDUV2.EndInit();
			// 
			// xDVC
			// 
			this.xDVC.BeginInit();
			this.xDVC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDVC.IsOnlyInput = true;
			this.xDVC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDVC.Name = "xDVC";
			this.xDVC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDVC.TagName = "STS_DJ_VC01";
			this.xDVC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDVCValueChanged);
			this.xDVC.EndInit();
			// 
			// xDMO
			// 
			this.xDMO.BeginInit();
			this.xDMO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDMO.IsOnlyInput = true;
			this.xDMO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDMO.Name = "xDMO";
			this.xDMO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDMO.TagName = "STS_DJ_MO01";
			this.xDMO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDMOValueChanged);
			this.xDMO.EndInit();
			// 
			// xEVA
			// 
			this.xEVA.BeginInit();
			this.xEVA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVA.IsOnlyInput = true;
			this.xEVA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVA.Name = "xEVA";
			this.xEVA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVA.TagName = "STS_ALM_VAZAO_ALTA_EST";
			this.xEVA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEVAValueChanged);
			this.xEVA.EndInit();
			// 
			// xEVR
			// 
			this.xEVR.BeginInit();
			this.xEVR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVR.IsOnlyInput = true;
			this.xEVR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVR.Name = "xEVR";
			this.xEVR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVR.TagName = "STS_ALM_VARIACAO_EST";
			this.xEVR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEVRValueChanged);
			this.xEVR.EndInit();
			// 
			// xEDJ
			// 
			this.xEDJ.BeginInit();
			this.xEDJ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEDJ.IsOnlyInput = true;
			this.xEDJ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEDJ.Name = "xEDJ";
			this.xEDJ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEDJ.TagName = "STS_ALM_DISJUNTOR_EST";
			this.xEDJ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEDJValueChanged);
			this.xEDJ.EndInit();
			// 
			// xEREM
			// 
			this.xEREM.BeginInit();
			this.xEREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEREM.IsOnlyInput = true;
			this.xEREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEREM.Name = "xEREM";
			this.xEREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEREM.TagName = "STS_ALM_REMOTA_EST";
			this.xEREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEREMValueChanged);
			this.xEREM.EndInit();
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
			// xTOT
			// 
			this.xTOT.BeginInit();
			this.xTOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTOT.IsOnlyInput = true;
			this.xTOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTOT.Name = "xTOT";
			this.xTOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTOT.TagName = "STS_TOTAL";
			this.xTOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTOTValueChanged);
			this.xTOT.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(520D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.e1,
			this.e2,
			this.rCtl,
			this.btnDesab,
			this.btnHab,
			this.l0,
			this.t0,
			this.l1,
			this.t1,
			this.l2,
			this.t2,
			this.l3,
			this.t3,
			this.l4,
			this.t4,
			this.l5,
			this.t5,
			this.l6,
			this.t6,
			this.l7,
			this.t7,
			this.l8,
			this.t8,
			this.rTot,
			this.btnZera,
			this.btnReset,
			this.xVAZ,
			this.xVMAX,
			this.xATIVO,
			this.xMOT,
			this.xSPID,
			this.xVPOS,
			this.xFTF,
			this.xREM,
			this.xADJ,
			this.xAVA,
			this.xAVR,
			this.xFREM,
			this.xDPCE,
			this.xDPCM,
			this.xDUV1,
			this.xDUV2,
			this.xDVC,
			this.xDMO,
			this.xEVA,
			this.xEVR,
			this.xEDJ,
			this.xEREM,
			this.xHAB,
			this.xTOT});
			this.Size = new System.Drawing.Size(400, 520);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText e1;
		private NxtControl.GuiFramework.FreeText e2;
		private NxtControl.GuiFramework.FreeText rCtl;
		private NxtControl.GuiFramework.DrawnButton btnDesab;
		private NxtControl.GuiFramework.DrawnButton btnHab;
		private NxtControl.GuiFramework.FreeText l0;
		private System.HMI.Symbols.Base.TextBox<float> t0;
		private NxtControl.GuiFramework.FreeText l1;
		private System.HMI.Symbols.Base.TextBox<float> t1;
		private NxtControl.GuiFramework.FreeText l2;
		private System.HMI.Symbols.Base.TextBox<float> t2;
		private NxtControl.GuiFramework.FreeText l3;
		private System.HMI.Symbols.Base.TextBox<float> t3;
		private NxtControl.GuiFramework.FreeText l4;
		private System.HMI.Symbols.Base.TextBox<float> t4;
		private NxtControl.GuiFramework.FreeText l5;
		private System.HMI.Symbols.Base.TextBox<float> t5;
		private NxtControl.GuiFramework.FreeText l6;
		private System.HMI.Symbols.Base.TextBox<float> t6;
		private NxtControl.GuiFramework.FreeText l7;
		private System.HMI.Symbols.Base.TextBox<short> t7;
		private NxtControl.GuiFramework.FreeText l8;
		private System.HMI.Symbols.Base.TextBox<float> t8;
		private NxtControl.GuiFramework.FreeText rTot;
		private NxtControl.GuiFramework.DrawnButton btnZera;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private System.HMI.Symbols.Base.Execute<float> xVAZ;
		private System.HMI.Symbols.Base.Execute<float> xVMAX;
		private System.HMI.Symbols.Base.Execute<bool> xATIVO;
		private System.HMI.Symbols.Base.Execute<short> xMOT;
		private System.HMI.Symbols.Base.Execute<float> xSPID;
		private System.HMI.Symbols.Base.Execute<float> xVPOS;
		private System.HMI.Symbols.Base.Execute<bool> xFTF;
		private System.HMI.Symbols.Base.Execute<bool> xREM;
		private System.HMI.Symbols.Base.Execute<bool> xADJ;
		private System.HMI.Symbols.Base.Execute<bool> xAVA;
		private System.HMI.Symbols.Base.Execute<bool> xAVR;
		private System.HMI.Symbols.Base.Execute<bool> xFREM;
		private System.HMI.Symbols.Base.Execute<bool> xDPCE;
		private System.HMI.Symbols.Base.Execute<bool> xDPCM;
		private System.HMI.Symbols.Base.Execute<bool> xDUV1;
		private System.HMI.Symbols.Base.Execute<bool> xDUV2;
		private System.HMI.Symbols.Base.Execute<bool> xDVC;
		private System.HMI.Symbols.Base.Execute<bool> xDMO;
		private System.HMI.Symbols.Base.Execute<byte> xEVA;
		private System.HMI.Symbols.Base.Execute<byte> xEVR;
		private System.HMI.Symbols.Base.Execute<byte> xEDJ;
		private System.HMI.Symbols.Base.Execute<byte> xEREM;
		private System.HMI.Symbols.Base.Execute<bool> xHAB;
		private System.HMI.Symbols.Base.Execute<int> xTOT;
		#endregion
	}
}
