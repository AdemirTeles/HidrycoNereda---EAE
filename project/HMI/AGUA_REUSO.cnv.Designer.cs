/*
 * Hidryco - tela AGUA_REUSO (Agua de reuso - serie 1000)
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs (AGUA_REUSO, PIT-01/02, MGE).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for AGUA_REUSO.
	/// </summary>
	partial class AGUA_REUSO
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
			this.tuboEntrada = new NxtControl.GuiFramework.Pipe();
			this.setaEntrada = new NxtControl.GuiFramework.Polygon();
			this.rotEntrada = new NxtControl.GuiFramework.FreeText();
			this.chao = new NxtControl.GuiFramework.Line();
			this.tuboEntradaR1 = new NxtControl.GuiFramework.Pipe();
			this.resInterior1 = new NxtControl.GuiFramework.Rectangle();
			this.resParedeEsq1 = new NxtControl.GuiFramework.Rectangle();
			this.resParedeDir1 = new NxtControl.GuiFramework.Rectangle();
			this.resFundo1 = new NxtControl.GuiFramework.Rectangle();
			this.resTampa1 = new NxtControl.GuiFramework.Rectangle();
			this.pilarEsq1 = new NxtControl.GuiFramework.Rectangle();
			this.pilarDir1 = new NxtControl.GuiFramework.Rectangle();
			this.travessa1 = new NxtControl.GuiFramework.Line();
			this.rotRes1 = new NxtControl.GuiFramework.FreeText();
			this.tuboSaida1 = new NxtControl.GuiFramework.Pipe();
			this.tomadaPIT1 = new NxtControl.GuiFramework.Line();
			this.nivel1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel();
			this.rotPIT1 = new NxtControl.GuiFramework.FreeText();
			this.rotPITb1 = new NxtControl.GuiFramework.FreeText();
			this.tuboEntradaR2 = new NxtControl.GuiFramework.Pipe();
			this.resInterior2 = new NxtControl.GuiFramework.Rectangle();
			this.resParedeEsq2 = new NxtControl.GuiFramework.Rectangle();
			this.resParedeDir2 = new NxtControl.GuiFramework.Rectangle();
			this.resFundo2 = new NxtControl.GuiFramework.Rectangle();
			this.resTampa2 = new NxtControl.GuiFramework.Rectangle();
			this.pilarEsq2 = new NxtControl.GuiFramework.Rectangle();
			this.pilarDir2 = new NxtControl.GuiFramework.Rectangle();
			this.travessa2 = new NxtControl.GuiFramework.Line();
			this.rotRes2 = new NxtControl.GuiFramework.FreeText();
			this.tuboSaida2 = new NxtControl.GuiFramework.Pipe();
			this.tomadaPIT2 = new NxtControl.GuiFramework.Line();
			this.nivel2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel();
			this.rotPIT2 = new NxtControl.GuiFramework.FreeText();
			this.rotPITb2 = new NxtControl.GuiFramework.FreeText();
			this.boiaCabo = new NxtControl.GuiFramework.Line();
			this.boia = new NxtControl.GuiFramework.Ellipse();
			this.boiaTag = new NxtControl.GuiFramework.FreeText();
			this.boiaTxt = new NxtControl.GuiFramework.FreeText();
			this.tuboDistribuicao = new NxtControl.GuiFramework.Pipe();
			this.setaDist1 = new NxtControl.GuiFramework.Polygon();
			this.setaDist2 = new NxtControl.GuiFramework.Polygon();
			this.rotDist = new NxtControl.GuiFramework.FreeText();
			this.rotDist2 = new NxtControl.GuiFramework.FreeText();
			this.aguaReuso = new Hidryco.HidrycoLib.Symbols.Agua_Reuso.sDefault();
			this.cardPCM = new NxtControl.GuiFramework.Rectangle();
			this.rotPCM = new NxtControl.GuiFramework.FreeText();
			this.rotPCM2 = new NxtControl.GuiFramework.FreeText();
			this.mge = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
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
			// tuboEntrada
			// 
			this.tuboEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(64D)), ((float)(696D)), ((float)(0D)));
			this.tuboEntrada.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboEntrada.Name = "tuboEntrada";
			this.tuboEntrada.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboEntrada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 64D),
			new NxtControl.Drawing.PointF(720D, 64D)});
			this.tuboEntrada.Width = 10;
			// 
			// setaEntrada
			// 
			this.setaEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(57D)), ((float)(14D)), ((float)(14D)));
			this.setaEntrada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaEntrada.Closed = true;
			this.setaEntrada.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.setaEntrada.Name = "setaEntrada";
			this.setaEntrada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaEntrada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(60D, 57D),
			new NxtControl.Drawing.PointF(74D, 64D),
			new NxtControl.Drawing.PointF(60D, 71D)});
			// 
			// rotEntrada
			// 
			this.rotEntrada.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotEntrada.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotEntrada.Location = new NxtControl.Drawing.PointF(26D, 30D);
			this.rotEntrada.Name = "rotEntrada";
			this.rotEntrada.Text = "Entrada";
			// 
			// chao
			// 
			this.chao.EndPoint = new NxtControl.Drawing.PointF(1040D, 640D);
			this.chao.Name = "chao";
			this.chao.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.chao.StartPoint = new NxtControl.Drawing.PointF(24D, 640D);
			// 
			// tuboEntradaR1
			// 
			this.tuboEntradaR1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(64D)), ((float)(0D)), ((float)(40D)));
			this.tuboEntradaR1.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboEntradaR1.Name = "tuboEntradaR1";
			this.tuboEntradaR1.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboEntradaR1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 64D),
			new NxtControl.Drawing.PointF(300D, 104D)});
			this.tuboEntradaR1.Width = 8;
			// 
			// resInterior1
			// 
			this.resInterior1.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(100D)), ((float)(210D)), ((float)(220D)));
			this.resInterior1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(214)), ((byte)(218)), ((byte)(222))));
			this.resInterior1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resInterior1.Name = "resInterior1";
			this.resInterior1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resParedeEsq1
			// 
			this.resParedeEsq1.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(92D)), ((float)(10D)), ((float)(238D)));
			this.resParedeEsq1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resParedeEsq1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resParedeEsq1.Name = "resParedeEsq1";
			this.resParedeEsq1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resParedeDir1
			// 
			this.resParedeDir1.Bounds = new NxtControl.Drawing.RectF(((float)(370D)), ((float)(92D)), ((float)(10D)), ((float)(238D)));
			this.resParedeDir1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resParedeDir1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resParedeDir1.Name = "resParedeDir1";
			this.resParedeDir1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resFundo1
			// 
			this.resFundo1.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(320D)), ((float)(230D)), ((float)(10D)));
			this.resFundo1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resFundo1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resFundo1.Name = "resFundo1";
			this.resFundo1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resTampa1
			// 
			this.resTampa1.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(92D)), ((float)(230D)), ((float)(8D)));
			this.resTampa1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resTampa1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resTampa1.Name = "resTampa1";
			this.resTampa1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pilarEsq1
			// 
			this.pilarEsq1.Bounds = new NxtControl.Drawing.RectF(((float)(172D)), ((float)(330D)), ((float)(14D)), ((float)(310D)));
			this.pilarEsq1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.pilarEsq1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.pilarEsq1.Name = "pilarEsq1";
			this.pilarEsq1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pilarDir1
			// 
			this.pilarDir1.Bounds = new NxtControl.Drawing.RectF(((float)(344D)), ((float)(330D)), ((float)(14D)), ((float)(310D)));
			this.pilarDir1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.pilarDir1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.pilarDir1.Name = "pilarDir1";
			this.pilarDir1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// travessa1
			// 
			this.travessa1.EndPoint = new NxtControl.Drawing.PointF(344D, 480D);
			this.travessa1.Name = "travessa1";
			this.travessa1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.travessa1.StartPoint = new NxtControl.Drawing.PointF(186D, 480D);
			// 
			// rotRes1
			// 
			this.rotRes1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotRes1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rotRes1.Location = new NxtControl.Drawing.PointF(168D, 108D);
			this.rotRes1.Name = "rotRes1";
			this.rotRes1.Text = "RESERVATÓRIO 1";
			// 
			// tuboSaida1
			// 
			this.tuboSaida1.Bounds = new NxtControl.Drawing.RectF(((float)(265D)), ((float)(330D)), ((float)(0D)), ((float)(270D)));
			this.tuboSaida1.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboSaida1.Name = "tuboSaida1";
			this.tuboSaida1.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboSaida1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(265D, 330D),
			new NxtControl.Drawing.PointF(265D, 600D)});
			this.tuboSaida1.Width = 8;
			// 
			// tomadaPIT1
			// 
			this.tomadaPIT1.EndPoint = new NxtControl.Drawing.PointF(412D, 312D);
			this.tomadaPIT1.Name = "tomadaPIT1";
			this.tomadaPIT1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1.5F, NxtControl.Drawing.DashStyle.Dash);
			this.tomadaPIT1.StartPoint = new NxtControl.Drawing.PointF(380D, 312D);
			// 
			// nivel1
			// 
			this.nivel1.BeginInit();
			this.nivel1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 412D, 190D);
			this.nivel1.Name = "nivel1";
			this.nivel1.SecurityToken = ((uint)(4294967295u));
			this.nivel1.TagName = "F134E1AF157DF837.PIT_1000_01";
			this.nivel1.EndInit();
			// 
			// rotPIT1
			// 
			this.rotPIT1.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotPIT1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotPIT1.Location = new NxtControl.Drawing.PointF(412D, 360D);
			this.rotPIT1.Name = "rotPIT1";
			this.rotPIT1.Text = "1000-PIT-01";
			// 
			// rotPITb1
			// 
			this.rotPITb1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotPITb1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotPITb1.Location = new NxtControl.Drawing.PointF(412D, 376D);
			this.rotPITb1.Name = "rotPITb1";
			this.rotPITb1.Text = "nível pelo transmissor de pressão";
			// 
			// tuboEntradaR2
			// 
			this.tuboEntradaR2.Bounds = new NxtControl.Drawing.RectF(((float)(710D)), ((float)(64D)), ((float)(0D)), ((float)(40D)));
			this.tuboEntradaR2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboEntradaR2.Name = "tuboEntradaR2";
			this.tuboEntradaR2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboEntradaR2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(710D, 64D),
			new NxtControl.Drawing.PointF(710D, 104D)});
			this.tuboEntradaR2.Width = 8;
			// 
			// resInterior2
			// 
			this.resInterior2.Bounds = new NxtControl.Drawing.RectF(((float)(570D)), ((float)(100D)), ((float)(210D)), ((float)(220D)));
			this.resInterior2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(214)), ((byte)(218)), ((byte)(222))));
			this.resInterior2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resInterior2.Name = "resInterior2";
			this.resInterior2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resParedeEsq2
			// 
			this.resParedeEsq2.Bounds = new NxtControl.Drawing.RectF(((float)(560D)), ((float)(92D)), ((float)(10D)), ((float)(238D)));
			this.resParedeEsq2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resParedeEsq2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resParedeEsq2.Name = "resParedeEsq2";
			this.resParedeEsq2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resParedeDir2
			// 
			this.resParedeDir2.Bounds = new NxtControl.Drawing.RectF(((float)(780D)), ((float)(92D)), ((float)(10D)), ((float)(238D)));
			this.resParedeDir2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resParedeDir2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resParedeDir2.Name = "resParedeDir2";
			this.resParedeDir2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resFundo2
			// 
			this.resFundo2.Bounds = new NxtControl.Drawing.RectF(((float)(560D)), ((float)(320D)), ((float)(230D)), ((float)(10D)));
			this.resFundo2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resFundo2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resFundo2.Name = "resFundo2";
			this.resFundo2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// resTampa2
			// 
			this.resTampa2.Bounds = new NxtControl.Drawing.RectF(((float)(560D)), ((float)(92D)), ((float)(230D)), ((float)(8D)));
			this.resTampa2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.resTampa2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.resTampa2.Name = "resTampa2";
			this.resTampa2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pilarEsq2
			// 
			this.pilarEsq2.Bounds = new NxtControl.Drawing.RectF(((float)(582D)), ((float)(330D)), ((float)(14D)), ((float)(310D)));
			this.pilarEsq2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.pilarEsq2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.pilarEsq2.Name = "pilarEsq2";
			this.pilarEsq2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pilarDir2
			// 
			this.pilarDir2.Bounds = new NxtControl.Drawing.RectF(((float)(754D)), ((float)(330D)), ((float)(14D)), ((float)(310D)));
			this.pilarDir2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.pilarDir2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.pilarDir2.Name = "pilarDir2";
			this.pilarDir2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// travessa2
			// 
			this.travessa2.EndPoint = new NxtControl.Drawing.PointF(754D, 480D);
			this.travessa2.Name = "travessa2";
			this.travessa2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.travessa2.StartPoint = new NxtControl.Drawing.PointF(596D, 480D);
			// 
			// rotRes2
			// 
			this.rotRes2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotRes2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rotRes2.Location = new NxtControl.Drawing.PointF(578D, 108D);
			this.rotRes2.Name = "rotRes2";
			this.rotRes2.Text = "RESERVATÓRIO 2";
			// 
			// tuboSaida2
			// 
			this.tuboSaida2.Bounds = new NxtControl.Drawing.RectF(((float)(675D)), ((float)(330D)), ((float)(0D)), ((float)(270D)));
			this.tuboSaida2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboSaida2.Name = "tuboSaida2";
			this.tuboSaida2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboSaida2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(675D, 330D),
			new NxtControl.Drawing.PointF(675D, 600D)});
			this.tuboSaida2.Width = 8;
			// 
			// tomadaPIT2
			// 
			this.tomadaPIT2.EndPoint = new NxtControl.Drawing.PointF(822D, 312D);
			this.tomadaPIT2.Name = "tomadaPIT2";
			this.tomadaPIT2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1.5F, NxtControl.Drawing.DashStyle.Dash);
			this.tomadaPIT2.StartPoint = new NxtControl.Drawing.PointF(790D, 312D);
			// 
			// nivel2
			// 
			this.nivel2.BeginInit();
			this.nivel2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 822D, 190D);
			this.nivel2.Name = "nivel2";
			this.nivel2.SecurityToken = ((uint)(4294967295u));
			this.nivel2.TagName = "F134E1AF157DF837.PIT_1000_02";
			this.nivel2.EndInit();
			// 
			// rotPIT2
			// 
			this.rotPIT2.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotPIT2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotPIT2.Location = new NxtControl.Drawing.PointF(822D, 360D);
			this.rotPIT2.Name = "rotPIT2";
			this.rotPIT2.Text = "1000-PIT-02";
			// 
			// rotPITb2
			// 
			this.rotPITb2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotPITb2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotPITb2.Location = new NxtControl.Drawing.PointF(822D, 376D);
			this.rotPITb2.Name = "rotPITb2";
			this.rotPITb2.Text = "nível pelo transmissor de pressão";
			// 
			// boiaCabo
			// 
			this.boiaCabo.EndPoint = new NxtControl.Drawing.PointF(186D, 284D);
			this.boiaCabo.Name = "boiaCabo";
			this.boiaCabo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.boiaCabo.StartPoint = new NxtControl.Drawing.PointF(186D, 100D);
			// 
			// boia
			// 
			this.boia.Bounds = new NxtControl.Drawing.RectF(((float)(178D)), ((float)(284D)), ((float)(16D)), ((float)(16D)));
			this.boia.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.boia.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.boia.Name = "boia";
			this.boia.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// boiaTag
			// 
			this.boiaTag.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.boiaTag.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.boiaTag.Location = new NxtControl.Drawing.PointF(200D, 270D);
			this.boiaTag.Name = "boiaTag";
			this.boiaTag.Text = "1000-LSL-01";
			// 
			// boiaTxt
			// 
			this.boiaTxt.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.boiaTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.boiaTxt.Location = new NxtControl.Drawing.PointF(200D, 286D);
			this.boiaTxt.Name = "boiaTxt";
			this.boiaTxt.Text = "nível baixo";
			// 
			// tuboDistribuicao
			// 
			this.tuboDistribuicao.Bounds = new NxtControl.Drawing.RectF(((float)(265D)), ((float)(600D)), ((float)(735D)), ((float)(0D)));
			this.tuboDistribuicao.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboDistribuicao.Name = "tuboDistribuicao";
			this.tuboDistribuicao.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboDistribuicao.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(265D, 600D),
			new NxtControl.Drawing.PointF(1000D, 600D)});
			this.tuboDistribuicao.Width = 12;
			// 
			// setaDist1
			// 
			this.setaDist1.Bounds = new NxtControl.Drawing.RectF(((float)(940D)), ((float)(592D)), ((float)(16D)), ((float)(16D)));
			this.setaDist1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaDist1.Closed = true;
			this.setaDist1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.setaDist1.Name = "setaDist1";
			this.setaDist1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaDist1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(940D, 592D),
			new NxtControl.Drawing.PointF(956D, 600D),
			new NxtControl.Drawing.PointF(940D, 608D)});
			// 
			// setaDist2
			// 
			this.setaDist2.Bounds = new NxtControl.Drawing.RectF(((float)(976D)), ((float)(592D)), ((float)(16D)), ((float)(16D)));
			this.setaDist2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaDist2.Closed = true;
			this.setaDist2.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.setaDist2.Name = "setaDist2";
			this.setaDist2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaDist2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(976D, 592D),
			new NxtControl.Drawing.PointF(992D, 600D),
			new NxtControl.Drawing.PointF(976D, 608D)});
			// 
			// rotDist
			// 
			this.rotDist.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotDist.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotDist.Location = new NxtControl.Drawing.PointF(800D, 572D);
			this.rotDist.Name = "rotDist";
			this.rotDist.Text = "Distribuição";
			// 
			// rotDist2
			// 
			this.rotDist2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotDist2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotDist2.Location = new NxtControl.Drawing.PointF(800D, 616D);
			this.rotDist2.Name = "rotDist2";
			this.rotDist2.Text = "água potável / serviço";
			// 
			// aguaReuso
			// 
			this.aguaReuso.BeginInit();
			this.aguaReuso.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 24D);
			this.aguaReuso.Name = "aguaReuso";
			this.aguaReuso.SecurityToken = ((uint)(4294967295u));
			this.aguaReuso.TagName = "F134E1AF157DF837";
			this.aguaReuso.EndInit();
			// 
			// cardPCM
			// 
			this.cardPCM.Bounds = new NxtControl.Drawing.RectF(((float)(1074D)), ((float)(150D)), ((float)(282D)), ((float)(150D)));
			this.cardPCM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(234)), ((byte)(236))));
			this.cardPCM.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 9F, System.Drawing.FontStyle.Regular);
			this.cardPCM.Name = "cardPCM";
			this.cardPCM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rotPCM
			// 
			this.rotPCM.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotPCM.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rotPCM.Location = new NxtControl.Drawing.PointF(1090D, 160D);
			this.rotPCM.Name = "rotPCM";
			this.rotPCM.Text = "PCM ÁGUA REUSO";
			// 
			// rotPCM2
			// 
			this.rotPCM2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotPCM2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotPCM2.Location = new NxtControl.Drawing.PointF(1090D, 178D);
			this.rotPCM2.Name = "rotPCM2";
			this.rotPCM2.Text = "multimedidor PM5300 (10.26.208.190)";
			// 
			// mge
			// 
			this.mge.BeginInit();
			this.mge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 200D);
			this.mge.Name = "mge";
			this.mge.SecurityToken = ((uint)(4294967295u));
			this.mge.TagName = "FB91426C191C180F";
			this.mge.EndInit();
			// 
			// AGUA_REUSO
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.tuboEntrada,
			this.setaEntrada,
			this.rotEntrada,
			this.chao,
			this.tuboEntradaR1,
			this.resInterior1,
			this.resParedeEsq1,
			this.resParedeDir1,
			this.resFundo1,
			this.resTampa1,
			this.pilarEsq1,
			this.pilarDir1,
			this.travessa1,
			this.rotRes1,
			this.tuboSaida1,
			this.tomadaPIT1,
			this.nivel1,
			this.rotPIT1,
			this.rotPITb1,
			this.tuboEntradaR2,
			this.resInterior2,
			this.resParedeEsq2,
			this.resParedeDir2,
			this.resFundo2,
			this.resTampa2,
			this.pilarEsq2,
			this.pilarDir2,
			this.travessa2,
			this.rotRes2,
			this.tuboSaida2,
			this.tomadaPIT2,
			this.nivel2,
			this.rotPIT2,
			this.rotPITb2,
			this.boiaCabo,
			this.boia,
			this.boiaTag,
			this.boiaTxt,
			this.tuboDistribuicao,
			this.setaDist1,
			this.setaDist2,
			this.rotDist,
			this.rotDist2,
			this.aguaReuso,
			this.cardPCM,
			this.rotPCM,
			this.rotPCM2,
			this.mge});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.Pipe tuboEntrada;
		private NxtControl.GuiFramework.Polygon setaEntrada;
		private NxtControl.GuiFramework.FreeText rotEntrada;
		private NxtControl.GuiFramework.Line chao;
		private NxtControl.GuiFramework.Pipe tuboEntradaR1;
		private NxtControl.GuiFramework.Rectangle resInterior1;
		private NxtControl.GuiFramework.Rectangle resParedeEsq1;
		private NxtControl.GuiFramework.Rectangle resParedeDir1;
		private NxtControl.GuiFramework.Rectangle resFundo1;
		private NxtControl.GuiFramework.Rectangle resTampa1;
		private NxtControl.GuiFramework.Rectangle pilarEsq1;
		private NxtControl.GuiFramework.Rectangle pilarDir1;
		private NxtControl.GuiFramework.Line travessa1;
		private NxtControl.GuiFramework.FreeText rotRes1;
		private NxtControl.GuiFramework.Pipe tuboSaida1;
		private NxtControl.GuiFramework.Line tomadaPIT1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel nivel1;
		private NxtControl.GuiFramework.FreeText rotPIT1;
		private NxtControl.GuiFramework.FreeText rotPITb1;
		private NxtControl.GuiFramework.Pipe tuboEntradaR2;
		private NxtControl.GuiFramework.Rectangle resInterior2;
		private NxtControl.GuiFramework.Rectangle resParedeEsq2;
		private NxtControl.GuiFramework.Rectangle resParedeDir2;
		private NxtControl.GuiFramework.Rectangle resFundo2;
		private NxtControl.GuiFramework.Rectangle resTampa2;
		private NxtControl.GuiFramework.Rectangle pilarEsq2;
		private NxtControl.GuiFramework.Rectangle pilarDir2;
		private NxtControl.GuiFramework.Line travessa2;
		private NxtControl.GuiFramework.FreeText rotRes2;
		private NxtControl.GuiFramework.Pipe tuboSaida2;
		private NxtControl.GuiFramework.Line tomadaPIT2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel nivel2;
		private NxtControl.GuiFramework.FreeText rotPIT2;
		private NxtControl.GuiFramework.FreeText rotPITb2;
		private NxtControl.GuiFramework.Line boiaCabo;
		private NxtControl.GuiFramework.Ellipse boia;
		private NxtControl.GuiFramework.FreeText boiaTag;
		private NxtControl.GuiFramework.FreeText boiaTxt;
		private NxtControl.GuiFramework.Pipe tuboDistribuicao;
		private NxtControl.GuiFramework.Polygon setaDist1;
		private NxtControl.GuiFramework.Polygon setaDist2;
		private NxtControl.GuiFramework.FreeText rotDist;
		private NxtControl.GuiFramework.FreeText rotDist2;
		private Hidryco.HidrycoLib.Symbols.Agua_Reuso.sDefault aguaReuso;
		private NxtControl.GuiFramework.Rectangle cardPCM;
		private NxtControl.GuiFramework.FreeText rotPCM;
		private NxtControl.GuiFramework.FreeText rotPCM2;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mge;
		#endregion
	}
}
