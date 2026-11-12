/*
 * Hidryco - tela DOSAGEM_ALCALINIZANTE (Dosagem de alcalinizante - serie 800)
 * Fonte: FLX-001 R05 (800 Quimicos - Reatores Nereda): soda do caminhao -> 800-BO-02 -> 800-TQ-03 (LIT-800-03) -> 800-DO-04/05 (1 operando + 1 reserva) -> reatores Nereda.
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for DOSAGEM_ALCALINIZANTE.
	/// </summary>
	partial class DOSAGEM_ALCALINIZANTE
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
			this.chao = new NxtControl.GuiFramework.Line();
			this.tuboEntrada = new NxtControl.GuiFramework.Pipe();
			this.setaEntrada = new NxtControl.GuiFramework.Polygon();
			this.rotEntrada = new NxtControl.GuiFramework.FreeText();
			this.rotEntrada2 = new NxtControl.GuiFramework.FreeText();
			this.tuboTanque = new NxtControl.GuiFramework.Pipe();
			this.tqInterior = new NxtControl.GuiFramework.Rectangle();
			this.liqTanque = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sLiquido();
			this.tqParedeEsq = new NxtControl.GuiFramework.Rectangle();
			this.tqParedeDir = new NxtControl.GuiFramework.Rectangle();
			this.tqFundo = new NxtControl.GuiFramework.Rectangle();
			this.tqTampa = new NxtControl.GuiFramework.Rectangle();
			this.tqBase = new NxtControl.GuiFramework.Rectangle();
			this.tuboSaidaTq = new NxtControl.GuiFramework.Pipe();
			this.tqApoio = new NxtControl.GuiFramework.Rectangle();
			this.rotTq = new NxtControl.GuiFramework.FreeText();
			this.rotTq2 = new NxtControl.GuiFramework.FreeText();
			this.tomadaLIT = new NxtControl.GuiFramework.Line();
			this.nivelLIT = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel();
			this.rotLIT = new NxtControl.GuiFramework.FreeText();
			this.rotLIT2 = new NxtControl.GuiFramework.FreeText();
			this.bo02 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.rotBO = new NxtControl.GuiFramework.FreeText();
			this.tuboColetorSuccao = new NxtControl.GuiFramework.Pipe();
			this.tuboSuccaoDO04 = new NxtControl.GuiFramework.Pipe();
			this.tuboSuccaoDO05 = new NxtControl.GuiFramework.Pipe();
			this.do04 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.do05 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.rotDO = new NxtControl.GuiFramework.FreeText();
			this.rotDO2 = new NxtControl.GuiFramework.FreeText();
			this.rotDO04 = new NxtControl.GuiFramework.FreeText();
			this.rotDO05 = new NxtControl.GuiFramework.FreeText();
			this.tuboRecalqueDO04 = new NxtControl.GuiFramework.Pipe();
			this.tuboRecalqueDO05 = new NxtControl.GuiFramework.Pipe();
			this.tuboColetorRecalque = new NxtControl.GuiFramework.Pipe();
			this.tuboReatores = new NxtControl.GuiFramework.Pipe();
			this.setaReatores = new NxtControl.GuiFramework.Polygon();
			this.rotReatores = new NxtControl.GuiFramework.FreeText();
			this.rotReatores2 = new NxtControl.GuiFramework.FreeText();
			this.btnResetGeral = new NxtControl.GuiFramework.DrawnButton();
			this.btnReconhecerGeral = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.fundo.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cardProcesso
			// 
			this.cardProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(1350D)), ((float)(682D)));
			this.cardProcesso.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardProcesso.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.cardProcesso.Name = "cardProcesso";
			this.cardProcesso.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(24D, 20D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "800 - DOSAGEM DE ALCALINIZANTE (SODA CÁUSTICA) PARA OS REATORES NEREDA";
			// 
			// chao
			// 
			this.chao.EndPoint = new NxtControl.Drawing.PointF(1340D, 640D);
			this.chao.Name = "chao";
			this.chao.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.chao.StartPoint = new NxtControl.Drawing.PointF(24D, 640D);
			// 
			// tuboEntrada
			// 
			this.tuboEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(518.7D)), ((float)(137D)), ((float)(0D)));
			this.tuboEntrada.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboEntrada.Name = "tuboEntrada";
			this.tuboEntrada.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboEntrada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 518.7D),
			new NxtControl.Drawing.PointF(161D, 518.7D)});
			this.tuboEntrada.Width = 8;
			// 
			// setaEntrada
			// 
			this.setaEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(511.7D)), ((float)(14D)), ((float)(14D)));
			this.setaEntrada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaEntrada.Closed = true;
			this.setaEntrada.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.setaEntrada.Name = "setaEntrada";
			this.setaEntrada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaEntrada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(60D, 511.7D),
			new NxtControl.Drawing.PointF(74D, 518.7D),
			new NxtControl.Drawing.PointF(60D, 525.7D)});
			// 
			// rotEntrada
			// 
			this.rotEntrada.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotEntrada.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotEntrada.Location = new NxtControl.Drawing.PointF(26D, 472.7D);
			this.rotEntrada.Name = "rotEntrada";
			this.rotEntrada.Text = "Soda cáustica";
			// 
			// rotEntrada2
			// 
			this.rotEntrada2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotEntrada2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotEntrada2.Location = new NxtControl.Drawing.PointF(26D, 488.7D);
			this.rotEntrada2.Name = "rotEntrada2";
			this.rotEntrada2.Text = "descarga do caminhão";
			// 
			// tuboTanque
			// 
			this.tuboTanque.Bounds = new NxtControl.Drawing.RectF(((float)(236D)), ((float)(120D)), ((float)(284D)), ((float)(368.4D)));
			this.tuboTanque.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboTanque.Name = "tuboTanque";
			this.tuboTanque.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboTanque.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(236D, 488.4D),
			new NxtControl.Drawing.PointF(300D, 488.4D),
			new NxtControl.Drawing.PointF(300D, 120D),
			new NxtControl.Drawing.PointF(520D, 120D),
			new NxtControl.Drawing.PointF(520D, 150D)});
			this.tuboTanque.Width = 8;
			// 
			// tqInterior
			// 
			this.tqInterior.Bounds = new NxtControl.Drawing.RectF(((float)(440D)), ((float)(158D)), ((float)(200D)), ((float)(362D)));
			this.tqInterior.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(214)), ((byte)(218)), ((byte)(222))));
			this.tqInterior.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.tqInterior.Name = "tqInterior";
			this.tqInterior.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// liqTanque
			// 
			this.liqTanque.BeginInit();
			this.liqTanque._iFluido = Hidryco.HidrycoLib.Symbols.Sensor_Generico.sLiquido.FluidoOption.Agua;
			this.liqTanque.DesignMatrix = new NxtControl.Drawing.Matrix2D(2D, 0D, 0D, 3.62D, 440D, 158D);
			this.liqTanque.Name = "liqTanque";
			this.liqTanque.SecurityToken = ((uint)(4294967295u));
			this.liqTanque.TagName = "4B0DB7D36D8ED12B.LIT_800_03";
			this.liqTanque.EndInit();
			// 
			// tqParedeEsq
			// 
			this.tqParedeEsq.Bounds = new NxtControl.Drawing.RectF(((float)(430D)), ((float)(150D)), ((float)(10D)), ((float)(380D)));
			this.tqParedeEsq.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.tqParedeEsq.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.tqParedeEsq.Name = "tqParedeEsq";
			this.tqParedeEsq.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tqParedeDir
			// 
			this.tqParedeDir.Bounds = new NxtControl.Drawing.RectF(((float)(640D)), ((float)(150D)), ((float)(10D)), ((float)(380D)));
			this.tqParedeDir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.tqParedeDir.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.tqParedeDir.Name = "tqParedeDir";
			this.tqParedeDir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tqFundo
			// 
			this.tqFundo.Bounds = new NxtControl.Drawing.RectF(((float)(430D)), ((float)(520D)), ((float)(220D)), ((float)(10D)));
			this.tqFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.tqFundo.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.tqFundo.Name = "tqFundo";
			this.tqFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tqTampa
			// 
			this.tqTampa.Bounds = new NxtControl.Drawing.RectF(((float)(430D)), ((float)(150D)), ((float)(220D)), ((float)(8D)));
			this.tqTampa.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.tqTampa.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.tqTampa.Name = "tqTampa";
			this.tqTampa.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tqBase
			// 
			this.tqBase.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(630D)), ((float)(260D)), ((float)(10D)));
			this.tqBase.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.tqBase.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.tqBase.Name = "tqBase";
			this.tqBase.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tuboSaidaTq
			// 
			this.tuboSaidaTq.Bounds = new NxtControl.Drawing.RectF(((float)(600D)), ((float)(530D)), ((float)(180D)), ((float)(70D)));
			this.tuboSaidaTq.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboSaidaTq.Name = "tuboSaidaTq";
			this.tuboSaidaTq.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboSaidaTq.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(600D, 530D),
			new NxtControl.Drawing.PointF(600D, 600D),
			new NxtControl.Drawing.PointF(780D, 600D)});
			this.tuboSaidaTq.Width = 8;
			// 
			// tqApoio
			// 
			this.tqApoio.Bounds = new NxtControl.Drawing.RectF(((float)(430D)), ((float)(530D)), ((float)(220D)), ((float)(100D)));
			this.tqApoio.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(204)), ((byte)(208))));
			this.tqApoio.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.tqApoio.Name = "tqApoio";
			this.tqApoio.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rotTq
			// 
			this.rotTq.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotTq.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rotTq.Location = new NxtControl.Drawing.PointF(664D, 160D);
			this.rotTq.Name = "rotTq";
			this.rotTq.Text = "800-TQ-03";
			// 
			// rotTq2
			// 
			this.rotTq2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotTq2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotTq2.Location = new NxtControl.Drawing.PointF(664D, 176D);
			this.rotTq2.Name = "rotTq2";
			this.rotTq2.Text = "Tanque de alcalinizante";
			// 
			// tomadaLIT
			// 
			this.tomadaLIT.EndPoint = new NxtControl.Drawing.PointF(690D, 500D);
			this.tomadaLIT.Name = "tomadaLIT";
			this.tomadaLIT.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.tomadaLIT.StartPoint = new NxtControl.Drawing.PointF(650D, 500D);
			// 
			// nivelLIT
			// 
			this.nivelLIT.BeginInit();
			this.nivelLIT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 690D, 380D);
			this.nivelLIT.Name = "nivelLIT";
			this.nivelLIT.SecurityToken = ((uint)(4294967295u));
			this.nivelLIT.TagName = "4B0DB7D36D8ED12B.LIT_800_03";
			this.nivelLIT.EndInit();
			// 
			// rotLIT
			// 
			this.rotLIT.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotLIT.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotLIT.Location = new NxtControl.Drawing.PointF(690D, 548D);
			this.rotLIT.Name = "rotLIT";
			this.rotLIT.Text = "LIT-800-03";
			// 
			// rotLIT2
			// 
			this.rotLIT2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotLIT2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotLIT2.Location = new NxtControl.Drawing.PointF(690D, 564D);
			this.rotLIT2.Name = "rotLIT2";
			this.rotLIT2.Text = "Nível do tanque";
			// 
			// bo02
			// 
			this.bo02.BeginInit();
			this.bo02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 150D, 450D);
			this.bo02.Name = "bo02";
			this.bo02.SecurityToken = ((uint)(4294967295u));
			this.bo02.TagName = "4B0DB7D36D8ED12B.BO_800_02";
			this.bo02.EndInit();
			// 
			// rotBO
			// 
			this.rotBO.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotBO.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotBO.Location = new NxtControl.Drawing.PointF(156D, 594D);
			this.rotBO.Name = "rotBO";
			this.rotBO.Text = "Transferência de soda";
			// 
			// tuboColetorSuccao
			// 
			this.tuboColetorSuccao.Bounds = new NxtControl.Drawing.RectF(((float)(780D)), ((float)(238.7D)), ((float)(0D)), ((float)(361.3D)));
			this.tuboColetorSuccao.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboColetorSuccao.Name = "tuboColetorSuccao";
			this.tuboColetorSuccao.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboColetorSuccao.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(780D, 600D),
			new NxtControl.Drawing.PointF(780D, 238.7D)});
			this.tuboColetorSuccao.Width = 8;
			// 
			// tuboSuccaoDO04
			// 
			this.tuboSuccaoDO04.Bounds = new NxtControl.Drawing.RectF(((float)(780D)), ((float)(238.7D)), ((float)(81D)), ((float)(0D)));
			this.tuboSuccaoDO04.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboSuccaoDO04.Name = "tuboSuccaoDO04";
			this.tuboSuccaoDO04.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboSuccaoDO04.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(780D, 238.7D),
			new NxtControl.Drawing.PointF(861D, 238.7D)});
			this.tuboSuccaoDO04.Width = 8;
			// 
			// tuboSuccaoDO05
			// 
			this.tuboSuccaoDO05.Bounds = new NxtControl.Drawing.RectF(((float)(780D)), ((float)(468.7D)), ((float)(81D)), ((float)(0D)));
			this.tuboSuccaoDO05.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboSuccaoDO05.Name = "tuboSuccaoDO05";
			this.tuboSuccaoDO05.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboSuccaoDO05.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(780D, 468.7D),
			new NxtControl.Drawing.PointF(861D, 468.7D)});
			this.tuboSuccaoDO05.Width = 8;
			// 
			// do04
			// 
			this.do04.BeginInit();
			this.do04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 850D, 170D);
			this.do04.Name = "do04";
			this.do04.SecurityToken = ((uint)(4294967295u));
			this.do04.TagName = "4B0DB7D36D8ED12B.DO_800_04";
			this.do04.EndInit();
			// 
			// do05
			// 
			this.do05.BeginInit();
			this.do05.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 850D, 400D);
			this.do05.Name = "do05";
			this.do05.SecurityToken = ((uint)(4294967295u));
			this.do05.TagName = "4B0DB7D36D8ED12B.DO_800_05";
			this.do05.EndInit();
			// 
			// rotDO
			// 
			this.rotDO.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotDO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotDO.Location = new NxtControl.Drawing.PointF(800D, 120D);
			this.rotDO.Name = "rotDO";
			this.rotDO.Text = "Bombas dosadoras";
			// 
			// rotDO2
			// 
			this.rotDO2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotDO2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotDO2.Location = new NxtControl.Drawing.PointF(800D, 136D);
			this.rotDO2.Name = "rotDO2";
			this.rotDO2.Text = "1 operando + 1 reserva";
			// 
			// rotDO04
			// 
			this.rotDO04.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotDO04.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotDO04.Location = new NxtControl.Drawing.PointF(856D, 314D);
			this.rotDO04.Name = "rotDO04";
			this.rotDO04.Text = "Dosadora de soda";
			// 
			// rotDO05
			// 
			this.rotDO05.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotDO05.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotDO05.Location = new NxtControl.Drawing.PointF(856D, 544D);
			this.rotDO05.Name = "rotDO05";
			this.rotDO05.Text = "Dosadora de soda";
			// 
			// tuboRecalqueDO04
			// 
			this.tuboRecalqueDO04.Bounds = new NxtControl.Drawing.RectF(((float)(936D)), ((float)(208.4D)), ((float)(104D)), ((float)(0D)));
			this.tuboRecalqueDO04.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboRecalqueDO04.Name = "tuboRecalqueDO04";
			this.tuboRecalqueDO04.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboRecalqueDO04.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(936D, 208.4D),
			new NxtControl.Drawing.PointF(1040D, 208.4D)});
			this.tuboRecalqueDO04.Width = 8;
			// 
			// tuboRecalqueDO05
			// 
			this.tuboRecalqueDO05.Bounds = new NxtControl.Drawing.RectF(((float)(936D)), ((float)(438.4D)), ((float)(104D)), ((float)(0D)));
			this.tuboRecalqueDO05.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboRecalqueDO05.Name = "tuboRecalqueDO05";
			this.tuboRecalqueDO05.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboRecalqueDO05.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(936D, 438.4D),
			new NxtControl.Drawing.PointF(1040D, 438.4D)});
			this.tuboRecalqueDO05.Width = 8;
			// 
			// tuboColetorRecalque
			// 
			this.tuboColetorRecalque.Bounds = new NxtControl.Drawing.RectF(((float)(1040D)), ((float)(208.4D)), ((float)(0D)), ((float)(230D)));
			this.tuboColetorRecalque.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboColetorRecalque.Name = "tuboColetorRecalque";
			this.tuboColetorRecalque.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboColetorRecalque.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1040D, 208.4D),
			new NxtControl.Drawing.PointF(1040D, 438.4D)});
			this.tuboColetorRecalque.Width = 8;
			// 
			// tuboReatores
			// 
			this.tuboReatores.Bounds = new NxtControl.Drawing.RectF(((float)(1040D)), ((float)(323D)), ((float)(290D)), ((float)(0D)));
			this.tuboReatores.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboReatores.Name = "tuboReatores";
			this.tuboReatores.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboReatores.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1040D, 323D),
			new NxtControl.Drawing.PointF(1330D, 323D)});
			this.tuboReatores.Width = 8;
			// 
			// setaReatores
			// 
			this.setaReatores.Bounds = new NxtControl.Drawing.RectF(((float)(1290D)), ((float)(316D)), ((float)(14D)), ((float)(14D)));
			this.setaReatores.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaReatores.Closed = true;
			this.setaReatores.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.setaReatores.Name = "setaReatores";
			this.setaReatores.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaReatores.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1290D, 316D),
			new NxtControl.Drawing.PointF(1304D, 323D),
			new NxtControl.Drawing.PointF(1290D, 330D)});
			// 
			// rotReatores
			// 
			this.rotReatores.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotReatores.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotReatores.Location = new NxtControl.Drawing.PointF(1080D, 277D);
			this.rotReatores.Name = "rotReatores";
			this.rotReatores.Text = "Para os reatores Nereda";
			// 
			// rotReatores2
			// 
			this.rotReatores2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotReatores2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotReatores2.Location = new NxtControl.Drawing.PointF(1080D, 293D);
			this.rotReatores2.Name = "rotReatores2";
			this.rotReatores2.Text = "soda cáustica dosada";
			// 
			// btnResetGeral
			// 
			this.btnResetGeral.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(662D)), ((float)(126D)), ((float)(30D)));
			this.btnResetGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnResetGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnResetGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnResetGeral.Name = "btnResetGeral";
			this.btnResetGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnResetGeral.Radius = 2D;
			this.btnResetGeral.Text = "Reset geral";
			this.btnResetGeral.Use3DEffect = false;
			this.btnResetGeral.Click += new System.EventHandler(this.BtnResetGeralClick);
			// 
			// btnReconhecerGeral
			// 
			this.btnReconhecerGeral.Bounds = new NxtControl.Drawing.RectF(((float)(138D)), ((float)(662D)), ((float)(150D)), ((float)(30D)));
			this.btnReconhecerGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReconhecerGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnReconhecerGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReconhecerGeral.Name = "btnReconhecerGeral";
			this.btnReconhecerGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReconhecerGeral.Radius = 2D;
			this.btnReconhecerGeral.Text = "Reconhecer geral";
			this.btnReconhecerGeral.Use3DEffect = false;
			this.btnReconhecerGeral.Click += new System.EventHandler(this.BtnReconhecerGeralClick);
			// 
			// DOSAGEM_ALCALINIZANTE
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.titulo,
			this.chao,
			this.tuboEntrada,
			this.setaEntrada,
			this.rotEntrada,
			this.rotEntrada2,
			this.tuboTanque,
			this.tqInterior,
			this.liqTanque,
			this.tqParedeEsq,
			this.tqParedeDir,
			this.tqFundo,
			this.tqTampa,
			this.tqBase,
			this.tqApoio,
			this.tuboSaidaTq,
			this.rotTq,
			this.rotTq2,
			this.tomadaLIT,
			this.nivelLIT,
			this.rotLIT,
			this.rotLIT2,
			this.bo02,
			this.rotBO,
			this.tuboColetorSuccao,
			this.tuboSuccaoDO04,
			this.tuboSuccaoDO05,
			this.do04,
			this.do05,
			this.rotDO,
			this.rotDO2,
			this.rotDO04,
			this.rotDO05,
			this.tuboRecalqueDO04,
			this.tuboRecalqueDO05,
			this.tuboColetorRecalque,
			this.tuboReatores,
			this.setaReatores,
			this.rotReatores,
			this.rotReatores2,
			this.btnResetGeral,
			this.btnReconhecerGeral});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.Line chao;
		private NxtControl.GuiFramework.Pipe tuboEntrada;
		private NxtControl.GuiFramework.Polygon setaEntrada;
		private NxtControl.GuiFramework.FreeText rotEntrada;
		private NxtControl.GuiFramework.FreeText rotEntrada2;
		private NxtControl.GuiFramework.Pipe tuboTanque;
		private NxtControl.GuiFramework.Rectangle tqInterior;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sLiquido liqTanque;
		private NxtControl.GuiFramework.Rectangle tqParedeEsq;
		private NxtControl.GuiFramework.Rectangle tqParedeDir;
		private NxtControl.GuiFramework.Rectangle tqFundo;
		private NxtControl.GuiFramework.Rectangle tqTampa;
		private NxtControl.GuiFramework.Rectangle tqBase;
		private NxtControl.GuiFramework.Pipe tuboSaidaTq;
		private NxtControl.GuiFramework.Rectangle tqApoio;
		private NxtControl.GuiFramework.FreeText rotTq;
		private NxtControl.GuiFramework.FreeText rotTq2;
		private NxtControl.GuiFramework.Line tomadaLIT;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel nivelLIT;
		private NxtControl.GuiFramework.FreeText rotLIT;
		private NxtControl.GuiFramework.FreeText rotLIT2;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bo02;
		private NxtControl.GuiFramework.FreeText rotBO;
		private NxtControl.GuiFramework.Pipe tuboColetorSuccao;
		private NxtControl.GuiFramework.Pipe tuboSuccaoDO04;
		private NxtControl.GuiFramework.Pipe tuboSuccaoDO05;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba do04;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba do05;
		private NxtControl.GuiFramework.FreeText rotDO;
		private NxtControl.GuiFramework.FreeText rotDO2;
		private NxtControl.GuiFramework.FreeText rotDO04;
		private NxtControl.GuiFramework.FreeText rotDO05;
		private NxtControl.GuiFramework.Pipe tuboRecalqueDO04;
		private NxtControl.GuiFramework.Pipe tuboRecalqueDO05;
		private NxtControl.GuiFramework.Pipe tuboColetorRecalque;
		private NxtControl.GuiFramework.Pipe tuboReatores;
		private NxtControl.GuiFramework.Polygon setaReatores;
		private NxtControl.GuiFramework.FreeText rotReatores;
		private NxtControl.GuiFramework.FreeText rotReatores2;
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		private NxtControl.GuiFramework.DrawnButton btnReconhecerGeral;
		#endregion
	}
}
