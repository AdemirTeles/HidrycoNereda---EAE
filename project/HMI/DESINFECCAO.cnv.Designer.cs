/*
 * Hidryco - tela DESINFECCAO (desinfeccao UV e efluente final - serie 700)
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs (DESINFECCAO, VC-01, canais UV, FT-01, AITs); arranjo do P&ID HID-PE-DE-ETE-FLX-001.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for DESINFECCAO.
	/// </summary>
	partial class DESINFECCAO
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.cardProcesso = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.rEntrada = new NxtControl.GuiFramework.FreeText();
			this.tEntrada = new NxtControl.GuiFramework.Rectangle();
			this.sEntrada = new NxtControl.GuiFramework.Polygon();
			this.tanqueParede = new NxtControl.GuiFramework.Rectangle();
			this.tanqueAgua = new NxtControl.GuiFramework.Rectangle();
			this.rTanque = new NxtControl.GuiFramework.FreeText();
			this.rTanque2 = new NxtControl.GuiFramework.FreeText();
			this.tSaidaTanque = new NxtControl.GuiFramework.Rectangle();
			this.tPosVC = new NxtControl.GuiFramework.Rectangle();
			this.tSobe = new NxtControl.GuiFramework.Rectangle();
			this.tVolta = new NxtControl.GuiFramework.Rectangle();
			this.tColetorEnt = new NxtControl.GuiFramework.Rectangle();
			this.tEntCanal1 = new NxtControl.GuiFramework.Rectangle();
			this.sCanal1 = new NxtControl.GuiFramework.Polygon();
			this.tEntCanal2 = new NxtControl.GuiFramework.Rectangle();
			this.sCanal2 = new NxtControl.GuiFramework.Polygon();
			this.rVC = new NxtControl.GuiFramework.FreeText();
			this.rUV = new NxtControl.GuiFramework.FreeText();
			this.tSai1 = new NxtControl.GuiFramework.Rectangle();
			this.tSai2 = new NxtControl.GuiFramework.Rectangle();
			this.tColetorSai = new NxtControl.GuiFramework.Rectangle();
			this.tParaParshall = new NxtControl.GuiFramework.Rectangle();
			this.sParshall = new NxtControl.GuiFramework.Polygon();
			this.parshall = new NxtControl.GuiFramework.Rectangle();
			this.garganta = new NxtControl.GuiFramework.Polygon();
			this.rParshall = new NxtControl.GuiFramework.FreeText();
			this.rParshall2 = new NxtControl.GuiFramework.FreeText();
			this.tapFT = new NxtControl.GuiFramework.Rectangle();
			this.tapA1 = new NxtControl.GuiFramework.Rectangle();
			this.tapA3 = new NxtControl.GuiFramework.Rectangle();
			this.tEfluente = new NxtControl.GuiFramework.Rectangle();
			this.rEfluente = new NxtControl.GuiFramework.FreeText();
			this.degrau0 = new NxtControl.GuiFramework.Rectangle();
			this.degrau1 = new NxtControl.GuiFramework.Rectangle();
			this.degrau2 = new NxtControl.GuiFramework.Rectangle();
			this.degrau3 = new NxtControl.GuiFramework.Rectangle();
			this.degrau4 = new NxtControl.GuiFramework.Rectangle();
			this.rEscada = new NxtControl.GuiFramework.FreeText();
			this.tAposEscada = new NxtControl.GuiFramework.Rectangle();
			this.tapA4 = new NxtControl.GuiFramework.Rectangle();
			this.setaReceptor = new NxtControl.GuiFramework.Polygon();
			this.rReceptor = new NxtControl.GuiFramework.FreeText();
			this.rReceptor2 = new NxtControl.GuiFramework.FreeText();
			this.rMax = new NxtControl.GuiFramework.FreeText();
			this.rio = new NxtControl.GuiFramework.Polygon();
			this.rRio = new NxtControl.GuiFramework.FreeText();
			this.rRio2 = new NxtControl.GuiFramework.FreeText();
			this.rCtl = new NxtControl.GuiFramework.FreeText();
			this.rUVsis = new NxtControl.GuiFramework.FreeText();
			this.valvula = new Hidryco.HidrycoLib.Symbols.Valvula_Coester.sValvula();
			this.canal1 = new Hidryco.HidrycoLib.Symbols.UV_Trojan.sCanal1();
			this.canal2 = new Hidryco.HidrycoLib.Symbols.UV_Trojan.sCanal2();
			this.ft = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sDefault();
			this.ait1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.ait3 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.ait4 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.controle = new Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.sDefault();
			this.uvSistema = new Hidryco.HidrycoLib.Symbols.UV_Trojan.sDefault();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cardProcesso
			// 
			this.cardProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(1350D)), ((float)(682D)));
			this.cardProcesso.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(242)), ((byte)(242)), ((byte)(242))));
			this.cardProcesso.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cardProcesso.Name = "cardProcesso";
			this.cardProcesso.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(24D, 14D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "DESINFECÇÃO UV E EFLUENTE FINAL (700)";
			// 
			// rEntrada
			// 
			this.rEntrada.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rEntrada.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rEntrada.Location = new NxtControl.Drawing.PointF(24D, 470D);
			this.rEntrada.Name = "rEntrada";
			this.rEntrada.Text = "Decante dos reatores Nereda (até 650 L/s)";
			// 
			// tEntrada
			// 
			this.tEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(492D)), ((float)(40D)), ((float)(5D)));
			this.tEntrada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tEntrada.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tEntrada.Name = "tEntrada";
			this.tEntrada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sEntrada
			// 
			this.sEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(487D)), ((float)(12D)), ((float)(14D)));
			this.sEntrada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.sEntrada.Closed = true;
			this.sEntrada.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sEntrada.Name = "sEntrada";
			this.sEntrada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sEntrada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(56D, 487D),
			new NxtControl.Drawing.PointF(68D, 494D),
			new NxtControl.Drawing.PointF(56D, 501D)});
			// 
			// tanqueParede
			// 
			this.tanqueParede.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(486D)), ((float)(230D)), ((float)(170D)));
			this.tanqueParede.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.tanqueParede.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tanqueParede.Name = "tanqueParede";
			this.tanqueParede.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tanqueAgua
			// 
			this.tanqueAgua.Bounds = new NxtControl.Drawing.RectF(((float)(66D)), ((float)(540D)), ((float)(226D)), ((float)(114D)));
			this.tanqueAgua.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(205)), ((byte)(235))));
			this.tanqueAgua.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tanqueAgua.Name = "tanqueAgua";
			this.tanqueAgua.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(205)), ((byte)(235))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rTanque
			// 
			this.rTanque.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rTanque.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rTanque.Location = new NxtControl.Drawing.PointF(74D, 566D);
			this.rTanque.Name = "rTanque";
			this.rTanque.Text = "TANQUE DE AMORTECIMENTO";
			// 
			// rTanque2
			// 
			this.rTanque2.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rTanque2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rTanque2.Location = new NxtControl.Drawing.PointF(74D, 584D);
			this.rTanque2.Name = "rTanque2";
			this.rTanque2.Text = "DE VAZÃO   V = 1500 m³";
			// 
			// tSaidaTanque
			// 
			this.tSaidaTanque.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(641D)), ((float)(40D)), ((float)(5D)));
			this.tSaidaTanque.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tSaidaTanque.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tSaidaTanque.Name = "tSaidaTanque";
			this.tSaidaTanque.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tPosVC
			// 
			this.tPosVC.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(641D)), ((float)(36D)), ((float)(5D)));
			this.tPosVC.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tPosVC.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tPosVC.Name = "tPosVC";
			this.tPosVC.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSobe
			// 
			this.tSobe.Bounds = new NxtControl.Drawing.RectF(((float)(441D)), ((float)(446D)), ((float)(5D)), ((float)(200D)));
			this.tSobe.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tSobe.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tSobe.Name = "tSobe";
			this.tSobe.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tVolta
			// 
			this.tVolta.Bounds = new NxtControl.Drawing.RectF(((float)(36D)), ((float)(446D)), ((float)(410D)), ((float)(5D)));
			this.tVolta.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tVolta.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tVolta.Name = "tVolta";
			this.tVolta.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tColetorEnt
			// 
			this.tColetorEnt.Bounds = new NxtControl.Drawing.RectF(((float)(36D)), ((float)(100D)), ((float)(5D)), ((float)(351D)));
			this.tColetorEnt.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tColetorEnt.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tColetorEnt.Name = "tColetorEnt";
			this.tColetorEnt.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tEntCanal1
			// 
			this.tEntCanal1.Bounds = new NxtControl.Drawing.RectF(((float)(36D)), ((float)(100D)), ((float)(30D)), ((float)(5D)));
			this.tEntCanal1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tEntCanal1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tEntCanal1.Name = "tEntCanal1";
			this.tEntCanal1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sCanal1
			// 
			this.sCanal1.Bounds = new NxtControl.Drawing.RectF(((float)(58D)), ((float)(95D)), ((float)(12D)), ((float)(14D)));
			this.sCanal1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.sCanal1.Closed = true;
			this.sCanal1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sCanal1.Name = "sCanal1";
			this.sCanal1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sCanal1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(58D, 95D),
			new NxtControl.Drawing.PointF(70D, 102D),
			new NxtControl.Drawing.PointF(58D, 109D)});
			// 
			// tEntCanal2
			// 
			this.tEntCanal2.Bounds = new NxtControl.Drawing.RectF(((float)(36D)), ((float)(290D)), ((float)(30D)), ((float)(5D)));
			this.tEntCanal2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tEntCanal2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tEntCanal2.Name = "tEntCanal2";
			this.tEntCanal2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sCanal2
			// 
			this.sCanal2.Bounds = new NxtControl.Drawing.RectF(((float)(58D)), ((float)(285D)), ((float)(12D)), ((float)(14D)));
			this.sCanal2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.sCanal2.Closed = true;
			this.sCanal2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sCanal2.Name = "sCanal2";
			this.sCanal2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sCanal2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(58D, 285D),
			new NxtControl.Drawing.PointF(70D, 292D),
			new NxtControl.Drawing.PointF(58D, 299D)});
			// 
			// rVC
			// 
			this.rVC.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rVC.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rVC.Location = new NxtControl.Drawing.PointF(64D, 662D);
			this.rVC.Name = "rVC";
			this.rVC.Text = "700-VC-01  borboleta modulante DN600";
			// 
			// rUV
			// 
			this.rUV.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rUV.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rUV.Location = new NxtControl.Drawing.PointF(76D, 214D);
			this.rUV.Name = "rUV";
			this.rUV.Text = "DESINFECÇÃO COM U.V.  -  Capacidade 345 L/s por canal";
			// 
			// tSai1
			// 
			this.tSai1.Bounds = new NxtControl.Drawing.RectF(((float)(446D)), ((float)(152D)), ((float)(30D)), ((float)(5D)));
			this.tSai1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tSai1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tSai1.Name = "tSai1";
			this.tSai1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSai2
			// 
			this.tSai2.Bounds = new NxtControl.Drawing.RectF(((float)(446D)), ((float)(342D)), ((float)(30D)), ((float)(5D)));
			this.tSai2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tSai2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tSai2.Name = "tSai2";
			this.tSai2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tColetorSai
			// 
			this.tColetorSai.Bounds = new NxtControl.Drawing.RectF(((float)(471D)), ((float)(152D)), ((float)(5D)), ((float)(195D)));
			this.tColetorSai.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tColetorSai.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tColetorSai.Name = "tColetorSai";
			this.tColetorSai.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tParaParshall
			// 
			this.tParaParshall.Bounds = new NxtControl.Drawing.RectF(((float)(471D)), ((float)(236D)), ((float)(50D)), ((float)(5D)));
			this.tParaParshall.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tParaParshall.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tParaParshall.Name = "tParaParshall";
			this.tParaParshall.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sParshall
			// 
			this.sParshall.Bounds = new NxtControl.Drawing.RectF(((float)(513D)), ((float)(231D)), ((float)(12D)), ((float)(14D)));
			this.sParshall.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.sParshall.Closed = true;
			this.sParshall.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sParshall.Name = "sParshall";
			this.sParshall.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.sParshall.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(513D, 231D),
			new NxtControl.Drawing.PointF(525D, 238D),
			new NxtControl.Drawing.PointF(513D, 245D)});
			// 
			// parshall
			// 
			this.parshall.Bounds = new NxtControl.Drawing.RectF(((float)(525D)), ((float)(222D)), ((float)(160D)), ((float)(34D)));
			this.parshall.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.parshall.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.parshall.Name = "parshall";
			this.parshall.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// garganta
			// 
			this.garganta.Bounds = new NxtControl.Drawing.RectF(((float)(585D)), ((float)(222D)), ((float)(40D)), ((float)(18D)));
			this.garganta.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.garganta.Closed = true;
			this.garganta.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.garganta.Name = "garganta";
			this.garganta.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.garganta.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(585D, 222D),
			new NxtControl.Drawing.PointF(605D, 240D),
			new NxtControl.Drawing.PointF(625D, 222D)});
			// 
			// rParshall
			// 
			this.rParshall.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rParshall.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rParshall.Location = new NxtControl.Drawing.PointF(528D, 260D);
			this.rParshall.Name = "rParshall";
			this.rParshall.Text = "CALHA PARSHALL 700-PA-01";
			// 
			// rParshall2
			// 
			this.rParshall2.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rParshall2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rParshall2.Location = new NxtControl.Drawing.PointF(528D, 276D);
			this.rParshall2.Name = "rParshall2";
			this.rParshall2.Text = "garganta 1,5\"  -  até 692 L/s";
			// 
			// tapFT
			// 
			this.tapFT.Bounds = new NxtControl.Drawing.RectF(((float)(604D)), ((float)(160D)), ((float)(1D)), ((float)(62D)));
			this.tapFT.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))));
			this.tapFT.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tapFT.Name = "tapFT";
			this.tapFT.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tapA1
			// 
			this.tapA1.Bounds = new NxtControl.Drawing.RectF(((float)(714D)), ((float)(104D)), ((float)(1D)), ((float)(134D)));
			this.tapA1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))));
			this.tapA1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tapA1.Name = "tapA1";
			this.tapA1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tapA3
			// 
			this.tapA3.Bounds = new NxtControl.Drawing.RectF(((float)(744D)), ((float)(134D)), ((float)(1D)), ((float)(104D)));
			this.tapA3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))));
			this.tapA3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tapA3.Name = "tapA3";
			this.tapA3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tEfluente
			// 
			this.tEfluente.Bounds = new NxtControl.Drawing.RectF(((float)(685D)), ((float)(236D)), ((float)(225D)), ((float)(5D)));
			this.tEfluente.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tEfluente.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tEfluente.Name = "tEfluente";
			this.tEfluente.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rEfluente
			// 
			this.rEfluente.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rEfluente.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rEfluente.Location = new NxtControl.Drawing.PointF(760D, 246D);
			this.rEfluente.Name = "rEfluente";
			this.rEfluente.Text = "EFLUENTE FINAL  ø800";
			// 
			// degrau0
			// 
			this.degrau0.Bounds = new NxtControl.Drawing.RectF(((float)(910D)), ((float)(236D)), ((float)(22D)), ((float)(10D)));
			this.degrau0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.degrau0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.degrau0.Name = "degrau0";
			this.degrau0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// degrau1
			// 
			this.degrau1.Bounds = new NxtControl.Drawing.RectF(((float)(932D)), ((float)(246D)), ((float)(22D)), ((float)(10D)));
			this.degrau1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.degrau1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.degrau1.Name = "degrau1";
			this.degrau1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// degrau2
			// 
			this.degrau2.Bounds = new NxtControl.Drawing.RectF(((float)(954D)), ((float)(256D)), ((float)(22D)), ((float)(10D)));
			this.degrau2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.degrau2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.degrau2.Name = "degrau2";
			this.degrau2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// degrau3
			// 
			this.degrau3.Bounds = new NxtControl.Drawing.RectF(((float)(976D)), ((float)(266D)), ((float)(22D)), ((float)(10D)));
			this.degrau3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.degrau3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.degrau3.Name = "degrau3";
			this.degrau3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// degrau4
			// 
			this.degrau4.Bounds = new NxtControl.Drawing.RectF(((float)(998D)), ((float)(276D)), ((float)(22D)), ((float)(10D)));
			this.degrau4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.degrau4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.degrau4.Name = "degrau4";
			this.degrau4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rEscada
			// 
			this.rEscada.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rEscada.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rEscada.Location = new NxtControl.Drawing.PointF(900D, 300D);
			this.rEscada.Name = "rEscada";
			this.rEscada.Text = "ESCADA DE AERAÇÃO";
			// 
			// tAposEscada
			// 
			this.tAposEscada.Bounds = new NxtControl.Drawing.RectF(((float)(1020D)), ((float)(286D)), ((float)(140D)), ((float)(5D)));
			this.tAposEscada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tAposEscada.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tAposEscada.Name = "tAposEscada";
			this.tAposEscada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tapA4
			// 
			this.tapA4.Bounds = new NxtControl.Drawing.RectF(((float)(1060D)), ((float)(196D)), ((float)(1D)), ((float)(90D)));
			this.tapA4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))));
			this.tapA4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tapA4.Name = "tapA4";
			this.tapA4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(80)), ((byte)(80)), ((byte)(80))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// setaReceptor
			// 
			this.setaReceptor.Bounds = new NxtControl.Drawing.RectF(((float)(1160D)), ((float)(274D)), ((float)(106D)), ((float)(30D)));
			this.setaReceptor.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.setaReceptor.Closed = true;
			this.setaReceptor.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.setaReceptor.Name = "setaReceptor";
			this.setaReceptor.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(60)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.setaReceptor.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1160D, 274D),
			new NxtControl.Drawing.PointF(1250D, 274D),
			new NxtControl.Drawing.PointF(1266D, 289D),
			new NxtControl.Drawing.PointF(1250D, 304D),
			new NxtControl.Drawing.PointF(1160D, 304D)});
			// 
			// rReceptor
			// 
			this.rReceptor.Color = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(60)), ((byte)(160)));
			this.rReceptor.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rReceptor.Location = new NxtControl.Drawing.PointF(1166D, 279D);
			this.rReceptor.Name = "rReceptor";
			this.rReceptor.Text = "EFLUENTE FINAL";
			// 
			// rReceptor2
			// 
			this.rReceptor2.Color = new NxtControl.Drawing.Color(((byte)(120)), ((byte)(60)), ((byte)(160)));
			this.rReceptor2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.rReceptor2.Location = new NxtControl.Drawing.PointF(1166D, 291D);
			this.rReceptor2.Name = "rReceptor2";
			this.rReceptor2.Text = "CORPO RECEPTOR";
			// 
			// rMax
			// 
			this.rMax.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rMax.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rMax.Location = new NxtControl.Drawing.PointF(1150D, 312D);
			this.rMax.Name = "rMax";
			this.rMax.Text = "Vazão máxima 345 L/s";
			// 
			// rio
			// 
			this.rio.Bounds = new NxtControl.Drawing.RectF(((float)(1276D)), ((float)(300D)), ((float)(64D)), ((float)(40D)));
			this.rio.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(195)), ((byte)(235))));
			this.rio.Closed = true;
			this.rio.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rio.Name = "rio";
			this.rio.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(140)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.rio.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1276D, 300D),
			new NxtControl.Drawing.PointF(1340D, 300D),
			new NxtControl.Drawing.PointF(1328D, 340D),
			new NxtControl.Drawing.PointF(1288D, 340D)});
			// 
			// rRio
			// 
			this.rRio.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rRio.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rRio.Location = new NxtControl.Drawing.PointF(1272D, 346D);
			this.rRio.Name = "rRio";
			this.rRio.Text = "RIBEIRÃO DO";
			// 
			// rRio2
			// 
			this.rRio2.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rRio2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rRio2.Location = new NxtControl.Drawing.PointF(1272D, 360D);
			this.rRio2.Name = "rRio2";
			this.rRio2.Text = "QUILOMBO";
			// 
			// rCtl
			// 
			this.rCtl.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rCtl.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rCtl.Location = new NxtControl.Drawing.PointF(520D, 446D);
			this.rCtl.Name = "rCtl";
			this.rCtl.Text = "CONTROLE DA VAZÃO DE LANÇAMENTO (700-VC-01 x 700-FT-01)";
			// 
			// rUVsis
			// 
			this.rUVsis.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rUVsis.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rUVsis.Location = new NxtControl.Drawing.PointF(960D, 446D);
			this.rUVsis.Name = "rUVsis";
			this.rUVsis.Text = "SISTEMA UV (TROJAN UV3000Plus)";
			// 
			// valvula
			// 
			this.valvula.BeginInit();
			this.valvula.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 300D, 570D);
			this.valvula.Name = "valvula";
			this.valvula.SecurityToken = ((uint)(4294967295u));
			this.valvula.TagName = "8005CB77235157DB.VC_700_01";
			this.valvula.EndInit();
			// 
			// canal1
			// 
			this.canal1.BeginInit();
			this.canal1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 66D, 50D);
			this.canal1.Name = "canal1";
			this.canal1.SecurityToken = ((uint)(4294967295u));
			this.canal1.TagName = "8005CB77235157DB.UV";
			this.canal1.EndInit();
			// 
			// canal2
			// 
			this.canal2.BeginInit();
			this.canal2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 66D, 240D);
			this.canal2.Name = "canal2";
			this.canal2.SecurityToken = ((uint)(4294967295u));
			this.canal2.TagName = "8005CB77235157DB.UV";
			this.canal2.EndInit();
			// 
			// ft
			// 
			this.ft.BeginInit();
			this.ft.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 520D, 98D);
			this.ft.Name = "ft";
			this.ft.SecurityToken = ((uint)(4294967295u));
			this.ft.TagName = "8005CB77235157DB.FT_700_01";
			this.ft.EndInit();
			// 
			// ait1
			// 
			this.ait1.BeginInit();
			this.ait1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 706D, 80D);
			this.ait1.Name = "ait1";
			this.ait1.SecurityToken = ((uint)(4294967295u));
			this.ait1.TagName = "8005CB77235157DB.AIT_700_001";
			this.ait1.EndInit();
			// 
			// ait3
			// 
			this.ait3.BeginInit();
			this.ait3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 736D, 110D);
			this.ait3.Name = "ait3";
			this.ait3.SecurityToken = ((uint)(4294967295u));
			this.ait3.TagName = "8005CB77235157DB.AIT_700_003";
			this.ait3.EndInit();
			// 
			// ait4
			// 
			this.ait4.BeginInit();
			this.ait4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1010D, 172D);
			this.ait4.Name = "ait4";
			this.ait4.SecurityToken = ((uint)(4294967295u));
			this.ait4.TagName = "8005CB77235157DB.AIT_700_004";
			this.ait4.EndInit();
			// 
			// controle
			// 
			this.controle.BeginInit();
			this.controle.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 520D, 470D);
			this.controle.Name = "controle";
			this.controle.SecurityToken = ((uint)(4294967295u));
			this.controle.TagName = "8005CB77235157DB";
			this.controle.EndInit();
			// 
			// uvSistema
			// 
			this.uvSistema.BeginInit();
			this.uvSistema.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 960D, 470D);
			this.uvSistema.Name = "uvSistema";
			this.uvSistema.SecurityToken = ((uint)(4294967295u));
			this.uvSistema.TagName = "8005CB77235157DB.UV";
			this.uvSistema.EndInit();
			// 
			// DESINFECCAO
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.titulo,
			this.rEntrada,
			this.tEntrada,
			this.sEntrada,
			this.tanqueParede,
			this.tanqueAgua,
			this.rTanque,
			this.rTanque2,
			this.tSaidaTanque,
			this.tPosVC,
			this.tSobe,
			this.tVolta,
			this.tColetorEnt,
			this.tEntCanal1,
			this.sCanal1,
			this.tEntCanal2,
			this.sCanal2,
			this.rVC,
			this.rUV,
			this.tSai1,
			this.tSai2,
			this.tColetorSai,
			this.tParaParshall,
			this.sParshall,
			this.parshall,
			this.garganta,
			this.rParshall,
			this.rParshall2,
			this.tapFT,
			this.tapA1,
			this.tapA3,
			this.tEfluente,
			this.rEfluente,
			this.degrau0,
			this.degrau1,
			this.degrau2,
			this.degrau3,
			this.degrau4,
			this.rEscada,
			this.tAposEscada,
			this.tapA4,
			this.setaReceptor,
			this.rReceptor,
			this.rReceptor2,
			this.rMax,
			this.rio,
			this.rRio,
			this.rRio2,
			this.rCtl,
			this.rUVsis,
			this.valvula,
			this.canal1,
			this.canal2,
			this.ft,
			this.ait1,
			this.ait3,
			this.ait4,
			this.controle,
			this.uvSistema});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText rEntrada;
		private NxtControl.GuiFramework.Rectangle tEntrada;
		private NxtControl.GuiFramework.Polygon sEntrada;
		private NxtControl.GuiFramework.Rectangle tanqueParede;
		private NxtControl.GuiFramework.Rectangle tanqueAgua;
		private NxtControl.GuiFramework.FreeText rTanque;
		private NxtControl.GuiFramework.FreeText rTanque2;
		private NxtControl.GuiFramework.Rectangle tSaidaTanque;
		private NxtControl.GuiFramework.Rectangle tPosVC;
		private NxtControl.GuiFramework.Rectangle tSobe;
		private NxtControl.GuiFramework.Rectangle tVolta;
		private NxtControl.GuiFramework.Rectangle tColetorEnt;
		private NxtControl.GuiFramework.Rectangle tEntCanal1;
		private NxtControl.GuiFramework.Polygon sCanal1;
		private NxtControl.GuiFramework.Rectangle tEntCanal2;
		private NxtControl.GuiFramework.Polygon sCanal2;
		private NxtControl.GuiFramework.FreeText rVC;
		private NxtControl.GuiFramework.FreeText rUV;
		private NxtControl.GuiFramework.Rectangle tSai1;
		private NxtControl.GuiFramework.Rectangle tSai2;
		private NxtControl.GuiFramework.Rectangle tColetorSai;
		private NxtControl.GuiFramework.Rectangle tParaParshall;
		private NxtControl.GuiFramework.Polygon sParshall;
		private NxtControl.GuiFramework.Rectangle parshall;
		private NxtControl.GuiFramework.Polygon garganta;
		private NxtControl.GuiFramework.FreeText rParshall;
		private NxtControl.GuiFramework.FreeText rParshall2;
		private NxtControl.GuiFramework.Rectangle tapFT;
		private NxtControl.GuiFramework.Rectangle tapA1;
		private NxtControl.GuiFramework.Rectangle tapA3;
		private NxtControl.GuiFramework.Rectangle tEfluente;
		private NxtControl.GuiFramework.FreeText rEfluente;
		private NxtControl.GuiFramework.Rectangle degrau0;
		private NxtControl.GuiFramework.Rectangle degrau1;
		private NxtControl.GuiFramework.Rectangle degrau2;
		private NxtControl.GuiFramework.Rectangle degrau3;
		private NxtControl.GuiFramework.Rectangle degrau4;
		private NxtControl.GuiFramework.FreeText rEscada;
		private NxtControl.GuiFramework.Rectangle tAposEscada;
		private NxtControl.GuiFramework.Rectangle tapA4;
		private NxtControl.GuiFramework.Polygon setaReceptor;
		private NxtControl.GuiFramework.FreeText rReceptor;
		private NxtControl.GuiFramework.FreeText rReceptor2;
		private NxtControl.GuiFramework.FreeText rMax;
		private NxtControl.GuiFramework.Polygon rio;
		private NxtControl.GuiFramework.FreeText rRio;
		private NxtControl.GuiFramework.FreeText rRio2;
		private NxtControl.GuiFramework.FreeText rCtl;
		private NxtControl.GuiFramework.FreeText rUVsis;
		private Hidryco.HidrycoLib.Symbols.Valvula_Coester.sValvula valvula;
		private Hidryco.HidrycoLib.Symbols.UV_Trojan.sCanal1 canal1;
		private Hidryco.HidrycoLib.Symbols.UV_Trojan.sCanal2 canal2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sDefault ft;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ait1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ait3;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ait4;
		private Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.sDefault controle;
		private Hidryco.HidrycoLib.Symbols.UV_Trojan.sDefault uvSistema;
		#endregion
	}
}
