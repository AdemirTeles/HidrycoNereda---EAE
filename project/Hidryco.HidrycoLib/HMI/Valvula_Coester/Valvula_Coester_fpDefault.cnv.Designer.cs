/*
 * Hidryco - Valvula_Coester - fpDefault
 * ISA-101: estado, posicao (barra e referencia), alarme por prioridade, chave/modo/disponibilidade, comando manual, reset e diagnostico.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Valvula_Coester
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
			this.caixaEstado = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.rPos = new NxtControl.GuiFramework.FreeText();
			this.barraFundo = new NxtControl.GuiFramework.Rectangle();
			this.barra = new NxtControl.GuiFramework.Rectangle();
			this.marcaRef = new NxtControl.GuiFramework.Polygon();
			this.vPos = new NxtControl.GuiFramework.FreeText();
			this.vRef = new NxtControl.GuiFramework.FreeText();
			this.textoChave = new NxtControl.GuiFramework.FreeText();
			this.textoDisp = new NxtControl.GuiFramework.FreeText();
			this.rModo = new NxtControl.GuiFramework.FreeText();
			this.btnManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutomatico = new NxtControl.GuiFramework.DrawnButton();
			this.rCmd = new NxtControl.GuiFramework.FreeText();
			this.btnAbrir = new NxtControl.GuiFramework.DrawnButton();
			this.btnParar = new NxtControl.GuiFramework.DrawnButton();
			this.btnFechar = new NxtControl.GuiFramework.DrawnButton();
			this.rSp = new NxtControl.GuiFramework.FreeText();
			this.vSpMan = new System.HMI.Symbols.Base.TextBox<float>();
			this.btnPosicionar = new NxtControl.GuiFramework.DrawnButton();
			this.textoCmd = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnDiag = new NxtControl.GuiFramework.DrawnButton();
			this.textoBloq = new NxtControl.GuiFramework.FreeText();
			this.xANIM = new System.HMI.Symbols.Base.Execute<short>();
			this.xPOS = new System.HMI.Symbols.Base.Execute<float>();
			this.xREF = new System.HMI.Symbols.Base.Execute<float>();
			this.xAUTO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLOC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDESL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFATU = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFPOS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCOD = new System.HMI.Symbols.Base.Execute<short>();
			this.xACFG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAPART = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBLOQ = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDISP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMOD = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCMDM = new System.HMI.Symbols.Base.Execute<short>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEATU = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPOS = new System.HMI.Symbols.Base.Execute<byte>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(150D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaEstado
			// 
			this.caixaEstado.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(14D)), ((float)(180D)), ((float)(30D)));
			this.caixaEstado.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.caixaEstado.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaEstado.Name = "caixaEstado";
			this.caixaEstado.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(28D, 20D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(210D)), ((float)(20D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(214D, 21D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(210D)), ((float)(20D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(210D, 36D),
			new NxtControl.Drawing.PointF(218D, 20D),
			new NxtControl.Drawing.PointF(226D, 36D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(215D, 23D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(230D, 20D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// rPos
			// 
			this.rPos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rPos.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rPos.Location = new NxtControl.Drawing.PointF(20D, 54D);
			this.rPos.Name = "rPos";
			this.rPos.Text = "Posição";
			// 
			// barraFundo
			// 
			this.barraFundo.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(72D)), ((float)(320D)), ((float)(18D)));
			this.barraFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.barraFundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barraFundo.Name = "barraFundo";
			this.barraFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(128)), ((byte)(128))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barra
			// 
			this.barra.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(72D)), ((float)(0D)), ((float)(18D)));
			this.barra.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))));
			this.barra.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barra.Name = "barra";
			this.barra.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// marcaRef
			// 
			this.marcaRef.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(92D)), ((float)(12D)), ((float)(8D)));
			this.marcaRef.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.marcaRef.Closed = true;
			this.marcaRef.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.marcaRef.Name = "marcaRef";
			this.marcaRef.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.marcaRef.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(14D, 92D),
			new NxtControl.Drawing.PointF(20D, 100D),
			new NxtControl.Drawing.PointF(26D, 92D)});
			// 
			// vPos
			// 
			this.vPos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vPos.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vPos.Location = new NxtControl.Drawing.PointF(20D, 104D);
			this.vPos.Name = "vPos";
			this.vPos.Text = "";
			// 
			// vRef
			// 
			this.vRef.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vRef.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.vRef.Location = new NxtControl.Drawing.PointF(190D, 104D);
			this.vRef.Name = "vRef";
			this.vRef.Text = "";
			// 
			// textoChave
			// 
			this.textoChave.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoChave.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoChave.Location = new NxtControl.Drawing.PointF(20D, 126D);
			this.textoChave.Name = "textoChave";
			this.textoChave.Text = "";
			// 
			// textoDisp
			// 
			this.textoDisp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoDisp.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoDisp.Location = new NxtControl.Drawing.PointF(190D, 126D);
			this.textoDisp.Name = "textoDisp";
			this.textoDisp.Text = "";
			// 
			// rModo
			// 
			this.rModo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rModo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rModo.Location = new NxtControl.Drawing.PointF(20D, 160D);
			this.rModo.Name = "rModo";
			this.rModo.Text = "Modo";
			// 
			// btnManual
			// 
			this.btnManual.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(178D)), ((float)(150D)), ((float)(34D)));
			this.btnManual.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManual.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManual.Name = "btnManual";
			this.btnManual.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManual.Radius = 2D;
			this.btnManual.Text = "Manual";
			this.btnManual.Use3DEffect = false;
			this.btnManual.Click += new System.EventHandler(this.BtnManualClick);
			// 
			// btnAutomatico
			// 
			this.btnAutomatico.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(178D)), ((float)(150D)), ((float)(34D)));
			this.btnAutomatico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutomatico.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAutomatico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAutomatico.Name = "btnAutomatico";
			this.btnAutomatico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAutomatico.Radius = 2D;
			this.btnAutomatico.Text = "Automático";
			this.btnAutomatico.Use3DEffect = false;
			this.btnAutomatico.Click += new System.EventHandler(this.BtnAutomaticoClick);
			// 
			// rCmd
			// 
			this.rCmd.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rCmd.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rCmd.Location = new NxtControl.Drawing.PointF(20D, 222D);
			this.rCmd.Name = "rCmd";
			this.rCmd.Text = "Comando manual";
			// 
			// btnAbrir
			// 
			this.btnAbrir.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(240D)), ((float)(96D)), ((float)(34D)));
			this.btnAbrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAbrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAbrir.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAbrir.Radius = 2D;
			this.btnAbrir.Text = "Abrir";
			this.btnAbrir.Use3DEffect = false;
			this.btnAbrir.Click += new System.EventHandler(this.BtnAbrirClick);
			// 
			// btnParar
			// 
			this.btnParar.Bounds = new NxtControl.Drawing.RectF(((float)(132D)), ((float)(240D)), ((float)(96D)), ((float)(34D)));
			this.btnParar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnParar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnParar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnParar.Name = "btnParar";
			this.btnParar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnParar.Radius = 2D;
			this.btnParar.Text = "Parar";
			this.btnParar.Use3DEffect = false;
			this.btnParar.Click += new System.EventHandler(this.BtnPararClick);
			// 
			// btnFechar
			// 
			this.btnFechar.Bounds = new NxtControl.Drawing.RectF(((float)(244D)), ((float)(240D)), ((float)(96D)), ((float)(34D)));
			this.btnFechar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnFechar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnFechar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnFechar.Radius = 2D;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.Use3DEffect = false;
			this.btnFechar.Click += new System.EventHandler(this.BtnFecharClick);
			// 
			// rSp
			// 
			this.rSp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rSp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rSp.Location = new NxtControl.Drawing.PointF(20D, 292D);
			this.rSp.Name = "rSp";
			this.rSp.Text = "Posição manual";
			// 
			// vSpMan
			// 
			this.vSpMan.BeginInit();
			this.vSpMan.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 150D, 286D);
			this.vSpMan.MaximumTag = null;
			this.vSpMan.MinimumTag = null;
			this.vSpMan.Name = "vSpMan";
			this.vSpMan.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.vSpMan.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.vSpMan.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.vSpMan.Suffix = " %";
			this.vSpMan.TagName = "STP_POSICAO_MANUAL";
			this.vSpMan.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vSpMan.UseInputPad = true;
			this.vSpMan.Value = 0F;
			this.vSpMan.EndInit();
			// 
			// btnPosicionar
			// 
			this.btnPosicionar.Bounds = new NxtControl.Drawing.RectF(((float)(244D)), ((float)(284D)), ((float)(96D)), ((float)(34D)));
			this.btnPosicionar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnPosicionar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnPosicionar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnPosicionar.Name = "btnPosicionar";
			this.btnPosicionar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnPosicionar.Radius = 2D;
			this.btnPosicionar.Text = "Posicionar";
			this.btnPosicionar.Use3DEffect = false;
			this.btnPosicionar.Click += new System.EventHandler(this.BtnPosicionarClick);
			// 
			// textoCmd
			// 
			this.textoCmd.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoCmd.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoCmd.Location = new NxtControl.Drawing.PointF(20D, 326D);
			this.textoCmd.Name = "textoCmd";
			this.textoCmd.Text = "";
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(350D)), ((float)(150D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reset / Reconhecer";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnDiag
			// 
			this.btnDiag.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(350D)), ((float)(150D)), ((float)(34D)));
			this.btnDiag.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDiag.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnDiag.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDiag.Name = "btnDiag";
			this.btnDiag.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDiagnostico", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnDiag.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDiag.Radius = 2D;
			this.btnDiag.Text = "Diagnóstico";
			this.btnDiag.Use3DEffect = false;
			// 
			// textoBloq
			// 
			this.textoBloq.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoBloq.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.textoBloq.Location = new NxtControl.Drawing.PointF(20D, 398D);
			this.textoBloq.Name = "textoBloq";
			this.textoBloq.Text = "";
			// 
			// xANIM
			// 
			this.xANIM.BeginInit();
			this.xANIM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xANIM.IsOnlyInput = true;
			this.xANIM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xANIM.Name = "xANIM";
			this.xANIM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xANIM.TagName = "STS_ANIMACAO";
			this.xANIM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XANIMValueChanged);
			this.xANIM.EndInit();
			// 
			// xPOS
			// 
			this.xPOS.BeginInit();
			this.xPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPOS.IsOnlyInput = true;
			this.xPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPOS.Name = "xPOS";
			this.xPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPOS.TagName = "STS_POSICAO";
			this.xPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XPOSValueChanged);
			this.xPOS.EndInit();
			// 
			// xREF
			// 
			this.xREF.BeginInit();
			this.xREF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xREF.IsOnlyInput = true;
			this.xREF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xREF.Name = "xREF";
			this.xREF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xREF.TagName = "STS_POSICAO_REFERENCIA";
			this.xREF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XREFValueChanged);
			this.xREF.EndInit();
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
			// xREM
			// 
			this.xREM.BeginInit();
			this.xREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xREM.IsOnlyInput = true;
			this.xREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xREM.Name = "xREM";
			this.xREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xREM.TagName = "STS_REMOTO";
			this.xREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XREMValueChanged);
			this.xREM.EndInit();
			// 
			// xLOC
			// 
			this.xLOC.BeginInit();
			this.xLOC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLOC.IsOnlyInput = true;
			this.xLOC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLOC.Name = "xLOC";
			this.xLOC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLOC.TagName = "STS_LOCAL";
			this.xLOC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XLOCValueChanged);
			this.xLOC.EndInit();
			// 
			// xDESL
			// 
			this.xDESL.BeginInit();
			this.xDESL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDESL.IsOnlyInput = true;
			this.xDESL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDESL.Name = "xDESL";
			this.xDESL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDESL.TagName = "STS_DESLIGADO";
			this.xDESL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDESLValueChanged);
			this.xDESL.EndInit();
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
			// xFPOS
			// 
			this.xFPOS.BeginInit();
			this.xFPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFPOS.IsOnlyInput = true;
			this.xFPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFPOS.Name = "xFPOS";
			this.xFPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFPOS.TagName = "STS_FALHA_POSICAO";
			this.xFPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFPOSValueChanged);
			this.xFPOS.EndInit();
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
			// xACFG
			// 
			this.xACFG.BeginInit();
			this.xACFG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xACFG.IsOnlyInput = true;
			this.xACFG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xACFG.Name = "xACFG";
			this.xACFG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xACFG.TagName = "STS_AVISO_CONFIG";
			this.xACFG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XACFGValueChanged);
			this.xACFG.EndInit();
			// 
			// xAPART
			// 
			this.xAPART.BeginInit();
			this.xAPART.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAPART.IsOnlyInput = true;
			this.xAPART.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAPART.Name = "xAPART";
			this.xAPART.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAPART.TagName = "STS_AVISO_PARTIDAS";
			this.xAPART.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAPARTValueChanged);
			this.xAPART.EndInit();
			// 
			// xBLOQ
			// 
			this.xBLOQ.BeginInit();
			this.xBLOQ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBLOQ.IsOnlyInput = true;
			this.xBLOQ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBLOQ.Name = "xBLOQ";
			this.xBLOQ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBLOQ.TagName = "STS_BLOQUEADO";
			this.xBLOQ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XBLOQValueChanged);
			this.xBLOQ.EndInit();
			// 
			// xDISP
			// 
			this.xDISP.BeginInit();
			this.xDISP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDISP.IsOnlyInput = true;
			this.xDISP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDISP.Name = "xDISP";
			this.xDISP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDISP.TagName = "STS_DISPONIVEL_AUTOMATICO";
			this.xDISP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDISPValueChanged);
			this.xDISP.EndInit();
			// 
			// xMOD
			// 
			this.xMOD.BeginInit();
			this.xMOD.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMOD.IsOnlyInput = true;
			this.xMOD.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMOD.Name = "xMOD";
			this.xMOD.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMOD.TagName = "STS_MODULANTE";
			this.xMOD.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XMODValueChanged);
			this.xMOD.EndInit();
			// 
			// xCMDM
			// 
			this.xCMDM.BeginInit();
			this.xCMDM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCMDM.IsOnlyInput = true;
			this.xCMDM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCMDM.Name = "xCMDM";
			this.xCMDM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCMDM.TagName = "STS_CMD_MANUAL";
			this.xCMDM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCMDMValueChanged);
			this.xCMDM.EndInit();
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
			// xEATU
			// 
			this.xEATU.BeginInit();
			this.xEATU.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEATU.IsOnlyInput = true;
			this.xEATU.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEATU.Name = "xEATU";
			this.xEATU.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEATU.TagName = "STS_ALM_ATUADOR_EST";
			this.xEATU.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEATUValueChanged);
			this.xEATU.EndInit();
			// 
			// xEPOS
			// 
			this.xEPOS.BeginInit();
			this.xEPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPOS.IsOnlyInput = true;
			this.xEPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPOS.Name = "xEPOS";
			this.xEPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPOS.TagName = "STS_ALM_POSICAO_EST";
			this.xEPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEPOSValueChanged);
			this.xEPOS.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(446D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.caixaEstado,
			this.textoEstado,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.rPos,
			this.barraFundo,
			this.barra,
			this.marcaRef,
			this.vPos,
			this.vRef,
			this.textoChave,
			this.textoDisp,
			this.rModo,
			this.btnManual,
			this.btnAutomatico,
			this.rCmd,
			this.btnAbrir,
			this.btnParar,
			this.btnFechar,
			this.rSp,
			this.vSpMan,
			this.btnPosicionar,
			this.textoCmd,
			this.btnReset,
			this.btnDiag,
			this.textoBloq,
			this.xANIM,
			this.xPOS,
			this.xREF,
			this.xAUTO,
			this.xREM,
			this.xLOC,
			this.xDESL,
			this.xFCOM,
			this.xFATU,
			this.xFPOS,
			this.xCOD,
			this.xACFG,
			this.xAPART,
			this.xBLOQ,
			this.xDISP,
			this.xMOD,
			this.xCMDM,
			this.xECOM,
			this.xEATU,
			this.xEPOS});
			this.Size = new System.Drawing.Size(360, 446);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle caixaEstado;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText rPos;
		private NxtControl.GuiFramework.Rectangle barraFundo;
		private NxtControl.GuiFramework.Rectangle barra;
		private NxtControl.GuiFramework.Polygon marcaRef;
		private NxtControl.GuiFramework.FreeText vPos;
		private NxtControl.GuiFramework.FreeText vRef;
		private NxtControl.GuiFramework.FreeText textoChave;
		private NxtControl.GuiFramework.FreeText textoDisp;
		private NxtControl.GuiFramework.FreeText rModo;
		private NxtControl.GuiFramework.DrawnButton btnManual;
		private NxtControl.GuiFramework.DrawnButton btnAutomatico;
		private NxtControl.GuiFramework.FreeText rCmd;
		private NxtControl.GuiFramework.DrawnButton btnAbrir;
		private NxtControl.GuiFramework.DrawnButton btnParar;
		private NxtControl.GuiFramework.DrawnButton btnFechar;
		private NxtControl.GuiFramework.FreeText rSp;
		private System.HMI.Symbols.Base.TextBox<float> vSpMan;
		private NxtControl.GuiFramework.DrawnButton btnPosicionar;
		private NxtControl.GuiFramework.FreeText textoCmd;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnDiag;
		private NxtControl.GuiFramework.FreeText textoBloq;
		private System.HMI.Symbols.Base.Execute<short> xANIM;
		private System.HMI.Symbols.Base.Execute<float> xPOS;
		private System.HMI.Symbols.Base.Execute<float> xREF;
		private System.HMI.Symbols.Base.Execute<bool> xAUTO;
		private System.HMI.Symbols.Base.Execute<bool> xREM;
		private System.HMI.Symbols.Base.Execute<bool> xLOC;
		private System.HMI.Symbols.Base.Execute<bool> xDESL;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xFATU;
		private System.HMI.Symbols.Base.Execute<bool> xFPOS;
		private System.HMI.Symbols.Base.Execute<short> xCOD;
		private System.HMI.Symbols.Base.Execute<bool> xACFG;
		private System.HMI.Symbols.Base.Execute<bool> xAPART;
		private System.HMI.Symbols.Base.Execute<bool> xBLOQ;
		private System.HMI.Symbols.Base.Execute<bool> xDISP;
		private System.HMI.Symbols.Base.Execute<bool> xMOD;
		private System.HMI.Symbols.Base.Execute<short> xCMDM;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xEATU;
		private System.HMI.Symbols.Base.Execute<byte> xEPOS;
		#endregion
	}
}
