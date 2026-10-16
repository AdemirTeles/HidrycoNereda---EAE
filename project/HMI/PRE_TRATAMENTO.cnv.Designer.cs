/*
 * Hidryco - tela PRE_TRATAMENTO
 * ISA-101: estados e alarmes vem dos simbolos dos CATs.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for PRE_TRATAMENTO.
	/// </summary>
	partial class PRE_TRATAMENTO
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.tbColetor = new NxtControl.GuiFramework.Pipe();
			this.tbGordura = new NxtControl.GuiFramework.Pipe();
			this.tbEntrada1 = new NxtControl.GuiFramework.Pipe();
			this.tbSaida1 = new NxtControl.GuiFramework.Pipe();
			this.tbRecalque1 = new NxtControl.GuiFramework.Pipe();
			this.tbEntrada2 = new NxtControl.GuiFramework.Pipe();
			this.tbSaida2 = new NxtControl.GuiFramework.Pipe();
			this.tbRecalque2 = new NxtControl.GuiFramework.Pipe();
			this.tbEntrada3 = new NxtControl.GuiFramework.Pipe();
			this.tbSaida3 = new NxtControl.GuiFramework.Pipe();
			this.rColetor = new NxtControl.GuiFramework.FreeText();
			this.rGordura = new NxtControl.GuiFramework.FreeText();
			this.rEntrada1 = new NxtControl.GuiFramework.FreeText();
			this.irSkid1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.uct1 = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sDefault();
			this.gordura1 = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sGordura();
			this.bomba1 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.rBomba1 = new NxtControl.GuiFramework.FreeText();
			this.rEntrada2 = new NxtControl.GuiFramework.FreeText();
			this.irSkid2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.uct2 = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sDefault();
			this.gordura2 = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sGordura();
			this.bomba2 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.rBomba2 = new NxtControl.GuiFramework.FreeText();
			this.rEntrada3 = new NxtControl.GuiFramework.FreeText();
			this.irSkid3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.uct3 = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sDefault();
			this.gordura3 = new Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sGordura();
			this.bomba3 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.rBomba3 = new NxtControl.GuiFramework.FreeText();
			this.naoInst3 = new NxtControl.GuiFramework.Rectangle();
			this.rNaoInst3 = new NxtControl.GuiFramework.FreeText();
			this.rNaoInst3b = new NxtControl.GuiFramework.FreeText();
			this.ftBolha = new NxtControl.GuiFramework.Ellipse();
			this.ftTxt = new NxtControl.GuiFramework.FreeText();
			this.rFT = new NxtControl.GuiFramework.FreeText();
			this.ft02 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.tqBuffer = new NxtControl.GuiFramework.Rectangle();
			this.rBuffer = new NxtControl.GuiFramework.FreeText();
			this.irBuffer = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.tqLodo = new NxtControl.GuiFramework.Rectangle();
			this.rLodo = new NxtControl.GuiFramework.FreeText();
			this.rLodo2 = new NxtControl.GuiFramework.FreeText();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tbColetor
			// 
			this.tbColetor.Bounds = new NxtControl.Drawing.RectF(((float)(286D)), ((float)(100D)), ((float)(1014D)), ((float)(40D)));
			this.tbColetor.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbColetor.Name = "tbColetor";
			this.tbColetor.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbColetor.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(286D, 100D),
			new NxtControl.Drawing.PointF(1300D, 100D),
			new NxtControl.Drawing.PointF(1300D, 140D)});
			this.tbColetor.Width = 10;
			// 
			// tbGordura
			// 
			this.tbGordura.Bounds = new NxtControl.Drawing.RectF(((float)(372D)), ((float)(560D)), ((float)(928D)), ((float)(30D)));
			this.tbGordura.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbGordura.Name = "tbGordura";
			this.tbGordura.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbGordura.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(372D, 560D),
			new NxtControl.Drawing.PointF(1300D, 560D),
			new NxtControl.Drawing.PointF(1300D, 590D)});
			this.tbGordura.Width = 6;
			// 
			// tbEntrada1
			// 
			this.tbEntrada1.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(208D)), ((float)(76D)), ((float)(0D)));
			this.tbEntrada1.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbEntrada1.Name = "tbEntrada1";
			this.tbEntrada1.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbEntrada1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(10D, 208D),
			new NxtControl.Drawing.PointF(86D, 208D)});
			this.tbEntrada1.Width = 10;
			// 
			// tbSaida1
			// 
			this.tbSaida1.Bounds = new NxtControl.Drawing.RectF(((float)(286D)), ((float)(100D)), ((float)(0D)), ((float)(60D)));
			this.tbSaida1.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSaida1.Name = "tbSaida1";
			this.tbSaida1.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSaida1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(286D, 160D),
			new NxtControl.Drawing.PointF(286D, 100D)});
			this.tbSaida1.Width = 10;
			// 
			// tbRecalque1
			// 
			this.tbRecalque1.Bounds = new NxtControl.Drawing.RectF(((float)(306D)), ((float)(365.6D)), ((float)(66D)), ((float)(194.4D)));
			this.tbRecalque1.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbRecalque1.Name = "tbRecalque1";
			this.tbRecalque1.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbRecalque1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(306D, 365.6D),
			new NxtControl.Drawing.PointF(372D, 365.6D),
			new NxtControl.Drawing.PointF(372D, 560D)});
			this.tbRecalque1.Width = 6;
			// 
			// tbEntrada2
			// 
			this.tbEntrada2.Bounds = new NxtControl.Drawing.RectF(((float)(360D)), ((float)(208D)), ((float)(76D)), ((float)(0D)));
			this.tbEntrada2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbEntrada2.Name = "tbEntrada2";
			this.tbEntrada2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbEntrada2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(360D, 208D),
			new NxtControl.Drawing.PointF(436D, 208D)});
			this.tbEntrada2.Width = 10;
			// 
			// tbSaida2
			// 
			this.tbSaida2.Bounds = new NxtControl.Drawing.RectF(((float)(636D)), ((float)(100D)), ((float)(0D)), ((float)(60D)));
			this.tbSaida2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSaida2.Name = "tbSaida2";
			this.tbSaida2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSaida2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(636D, 160D),
			new NxtControl.Drawing.PointF(636D, 100D)});
			this.tbSaida2.Width = 10;
			// 
			// tbRecalque2
			// 
			this.tbRecalque2.Bounds = new NxtControl.Drawing.RectF(((float)(656D)), ((float)(365.6D)), ((float)(66D)), ((float)(194.4D)));
			this.tbRecalque2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbRecalque2.Name = "tbRecalque2";
			this.tbRecalque2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbRecalque2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(656D, 365.6D),
			new NxtControl.Drawing.PointF(722D, 365.6D),
			new NxtControl.Drawing.PointF(722D, 560D)});
			this.tbRecalque2.Width = 6;
			// 
			// tbEntrada3
			// 
			this.tbEntrada3.Bounds = new NxtControl.Drawing.RectF(((float)(710D)), ((float)(208D)), ((float)(76D)), ((float)(0D)));
			this.tbEntrada3.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbEntrada3.Name = "tbEntrada3";
			this.tbEntrada3.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbEntrada3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(710D, 208D),
			new NxtControl.Drawing.PointF(786D, 208D)});
			this.tbEntrada3.Width = 10;
			// 
			// tbSaida3
			// 
			this.tbSaida3.Bounds = new NxtControl.Drawing.RectF(((float)(986D)), ((float)(100D)), ((float)(0D)), ((float)(60D)));
			this.tbSaida3.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSaida3.Name = "tbSaida3";
			this.tbSaida3.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSaida3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(986D, 160D),
			new NxtControl.Drawing.PointF(986D, 100D)});
			this.tbSaida3.Width = 10;
			// 
			// rColetor
			// 
			this.rColetor.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rColetor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rColetor.Location = new NxtControl.Drawing.PointF(296D, 78D);
			this.rColetor.Name = "rColetor";
			this.rColetor.Text = "Esgoto peneirado";
			// 
			// rGordura
			// 
			this.rGordura.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rGordura.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rGordura.Location = new NxtControl.Drawing.PointF(382D, 538D);
			this.rGordura.Name = "rGordura";
			this.rGordura.Text = "Gordura";
			// 
			// rEntrada1
			// 
			this.rEntrada1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rEntrada1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rEntrada1.Location = new NxtControl.Drawing.PointF(10D, 186D);
			this.rEntrada1.Name = "rEntrada1";
			this.rEntrada1.Text = "Esgoto bruto";
			// 
			// irSkid1
			// 
			this.irSkid1.Bounds = new NxtControl.Drawing.RectF(((float)(86D)), ((float)(120D)), ((float)(150D)), ((float)(30D)));
			this.irSkid1.CanvasName = "UCT_200_01";
			this.irSkid1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.irSkid1.Name = "irSkid1";
			this.irSkid1.Text = "Skid da UCT-01 ›";
			// 
			// uct1
			// 
			this.uct1.BeginInit();
			this.uct1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 86D, 160D);
			this.uct1.Name = "uct1";
			this.uct1.SecurityToken = ((uint)(4294967295u));
			this.uct1.TagName = "8562B7A48F2304C1";
			this.uct1.EndInit();
			// 
			// gordura1
			// 
			this.gordura1.BeginInit();
			this.gordura1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 86D, 270D);
			this.gordura1.Name = "gordura1";
			this.gordura1.SecurityToken = ((uint)(4294967295u));
			this.gordura1.TagName = "8562B7A48F2304C1";
			this.gordura1.EndInit();
			// 
			// bomba1
			// 
			this.bomba1.BeginInit();
			this.bomba1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 237.2D, 334.88D);
			this.bomba1.Name = "bomba1";
			this.bomba1.SecurityToken = ((uint)(4294967295u));
			this.bomba1.TagName = "8562B7A48F2304C1.BombaGordura";
			this.bomba1.EndInit();
			// 
			// rBomba1
			// 
			this.rBomba1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rBomba1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rBomba1.Location = new NxtControl.Drawing.PointF(253D, 444.88D);
			this.rBomba1.Name = "rBomba1";
			this.rBomba1.Text = "200-BR-03";
			// 
			// rEntrada2
			// 
			this.rEntrada2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rEntrada2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rEntrada2.Location = new NxtControl.Drawing.PointF(360D, 186D);
			this.rEntrada2.Name = "rEntrada2";
			this.rEntrada2.Text = "Esgoto bruto";
			// 
			// irSkid2
			// 
			this.irSkid2.Bounds = new NxtControl.Drawing.RectF(((float)(436D)), ((float)(120D)), ((float)(150D)), ((float)(30D)));
			this.irSkid2.CanvasName = "UCT_200_02";
			this.irSkid2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.irSkid2.Name = "irSkid2";
			this.irSkid2.Text = "Skid da UCT-02 ›";
			// 
			// uct2
			// 
			this.uct2.BeginInit();
			this.uct2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 436D, 160D);
			this.uct2.Name = "uct2";
			this.uct2.SecurityToken = ((uint)(4294967295u));
			this.uct2.TagName = "1FBDCF6E96E37765";
			this.uct2.EndInit();
			// 
			// gordura2
			// 
			this.gordura2.BeginInit();
			this.gordura2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 436D, 270D);
			this.gordura2.Name = "gordura2";
			this.gordura2.SecurityToken = ((uint)(4294967295u));
			this.gordura2.TagName = "1FBDCF6E96E37765";
			this.gordura2.EndInit();
			// 
			// bomba2
			// 
			this.bomba2.BeginInit();
			this.bomba2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 587.2D, 334.88D);
			this.bomba2.Name = "bomba2";
			this.bomba2.SecurityToken = ((uint)(4294967295u));
			this.bomba2.TagName = "1FBDCF6E96E37765.BombaGordura";
			this.bomba2.EndInit();
			// 
			// rBomba2
			// 
			this.rBomba2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rBomba2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rBomba2.Location = new NxtControl.Drawing.PointF(603D, 444.88D);
			this.rBomba2.Name = "rBomba2";
			this.rBomba2.Text = "200-BR-04";
			// 
			// rEntrada3
			// 
			this.rEntrada3.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rEntrada3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rEntrada3.Location = new NxtControl.Drawing.PointF(710D, 186D);
			this.rEntrada3.Name = "rEntrada3";
			this.rEntrada3.Text = "Esgoto bruto";
			// 
			// irSkid3
			// 
			this.irSkid3.Bounds = new NxtControl.Drawing.RectF(((float)(786D)), ((float)(120D)), ((float)(150D)), ((float)(30D)));
			this.irSkid3.CanvasName = "UCT_200_03";
			this.irSkid3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.irSkid3.Name = "irSkid3";
			this.irSkid3.Text = "Skid da UCT-03 ›";
			// 
			// uct3
			// 
			this.uct3.BeginInit();
			this.uct3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 786D, 160D);
			this.uct3.Name = "uct3";
			this.uct3.SecurityToken = ((uint)(4294967295u));
			this.uct3.TagName = "EB77BC463289AB0B";
			this.uct3.EndInit();
			// 
			// gordura3
			// 
			this.gordura3.BeginInit();
			this.gordura3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 786D, 270D);
			this.gordura3.Name = "gordura3";
			this.gordura3.SecurityToken = ((uint)(4294967295u));
			this.gordura3.TagName = "EB77BC463289AB0B";
			this.gordura3.EndInit();
			// 
			// bomba3
			// 
			this.bomba3.BeginInit();
			this.bomba3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 937.2D, 334.88D);
			this.bomba3.Name = "bomba3";
			this.bomba3.SecurityToken = ((uint)(4294967295u));
			this.bomba3.TagName = "EB77BC463289AB0B.BombaGordura";
			this.bomba3.EndInit();
			// 
			// rBomba3
			// 
			this.rBomba3.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rBomba3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rBomba3.Location = new NxtControl.Drawing.PointF(953D, 444.88D);
			this.rBomba3.Name = "rBomba3";
			this.rBomba3.Text = "200-BR-05";
			// 
			// naoInst3
			// 
			this.naoInst3.Bounds = new NxtControl.Drawing.RectF(((float)(780D)), ((float)(264D)), ((float)(296D)), ((float)(198.88D)));
			this.naoInst3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(237)), ((byte)(238))));
			this.naoInst3.Name = "naoInst3";
			this.naoInst3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(202)), ((byte)(205))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rNaoInst3
			// 
			this.rNaoInst3.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rNaoInst3.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.rNaoInst3.Location = new NxtControl.Drawing.PointF(872D, 330D);
			this.rNaoInst3.Name = "rNaoInst3";
			this.rNaoInst3.Text = "Não instalada";
			// 
			// rNaoInst3b
			// 
			this.rNaoInst3b.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rNaoInst3b.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rNaoInst3b.Location = new NxtControl.Drawing.PointF(822D, 352D);
			this.rNaoInst3b.Name = "rNaoInst3b";
			this.rNaoInst3b.Text = "tanque, válvula e bomba de gordura";
			// 
			// ftBolha
			// 
			this.ftBolha.Bounds = new NxtControl.Drawing.RectF(((float)(1136D)), ((float)(84D)), ((float)(32D)), ((float)(32D)));
			this.ftBolha.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.ftBolha.Name = "ftBolha";
			this.ftBolha.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ftTxt
			// 
			this.ftTxt.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.ftTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.ftTxt.Location = new NxtControl.Drawing.PointF(1142D, 92D);
			this.ftTxt.Name = "ftTxt";
			this.ftTxt.Text = "FT";
			// 
			// rFT
			// 
			this.rFT.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rFT.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rFT.Location = new NxtControl.Drawing.PointF(1090D, 32D);
			this.rFT.Name = "rFT";
			this.rFT.Text = "40FT02 - vazão para o buffer";
			// 
			// ft02
			// 
			this.ft02.BeginInit();
			this.ft02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 50D);
			this.ft02.Name = "ft02";
			this.ft02.SecurityToken = ((uint)(4294967295u));
			this.ft02.TagName = "1A8A218FB56FB248";
			this.ft02.EndInit();
			// 
			// tqBuffer
			// 
			this.tqBuffer.Bounds = new NxtControl.Drawing.RectF(((float)(1190D)), ((float)(140D)), ((float)(166D)), ((float)(100D)));
			this.tqBuffer.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.tqBuffer.Name = "tqBuffer";
			this.tqBuffer.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rBuffer
			// 
			this.rBuffer.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rBuffer.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rBuffer.Location = new NxtControl.Drawing.PointF(1198D, 148D);
			this.rBuffer.Name = "rBuffer";
			this.rBuffer.Text = "Buffer de influente";
			// 
			// irBuffer
			// 
			this.irBuffer.Bounds = new NxtControl.Drawing.RectF(((float)(1190D)), ((float)(250D)), ((float)(166D)), ((float)(30D)));
			this.irBuffer.CanvasName = "INFLUENT_FEED";
			this.irBuffer.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.irBuffer.Name = "irBuffer";
			this.irBuffer.Text = "Buffer de influente ›";
			// 
			// tqLodo
			// 
			this.tqLodo.Bounds = new NxtControl.Drawing.RectF(((float)(1190D)), ((float)(590D)), ((float)(166D)), ((float)(90D)));
			this.tqLodo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.tqLodo.Name = "tqLodo";
			this.tqLodo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rLodo
			// 
			this.rLodo.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rLodo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rLodo.Location = new NxtControl.Drawing.PointF(1198D, 598D);
			this.rLodo.Name = "rLodo";
			this.rLodo.Text = "Tanques de estocagem";
			// 
			// rLodo2
			// 
			this.rLodo2.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rLodo2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rLodo2.Location = new NxtControl.Drawing.PointF(1198D, 616D);
			this.rLodo2.Name = "rLodo2";
			this.rLodo2.Text = "de lodo (sólidos)";
			// 
			// PRE_TRATAMENTO
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "PRE_TRATAMENTO";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.tbColetor,
			this.tbGordura,
			this.tbEntrada1,
			this.tbSaida1,
			this.tbRecalque1,
			this.tbEntrada2,
			this.tbSaida2,
			this.tbRecalque2,
			this.tbEntrada3,
			this.tbSaida3,
			this.rColetor,
			this.rGordura,
			this.rEntrada1,
			this.irSkid1,
			this.uct1,
			this.gordura1,
			this.bomba1,
			this.rBomba1,
			this.rEntrada2,
			this.irSkid2,
			this.uct2,
			this.gordura2,
			this.bomba2,
			this.rBomba2,
			this.rEntrada3,
			this.irSkid3,
			this.uct3,
			this.gordura3,
			this.bomba3,
			this.rBomba3,
			this.naoInst3,
			this.rNaoInst3,
			this.rNaoInst3b,
			this.ftBolha,
			this.ftTxt,
			this.rFT,
			this.ft02,
			this.tqBuffer,
			this.rBuffer,
			this.irBuffer,
			this.tqLodo,
			this.rLodo,
			this.rLodo2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Pipe tbColetor;
		private NxtControl.GuiFramework.Pipe tbGordura;
		private NxtControl.GuiFramework.Pipe tbEntrada1;
		private NxtControl.GuiFramework.Pipe tbSaida1;
		private NxtControl.GuiFramework.Pipe tbRecalque1;
		private NxtControl.GuiFramework.Pipe tbEntrada2;
		private NxtControl.GuiFramework.Pipe tbSaida2;
		private NxtControl.GuiFramework.Pipe tbRecalque2;
		private NxtControl.GuiFramework.Pipe tbEntrada3;
		private NxtControl.GuiFramework.Pipe tbSaida3;
		private NxtControl.GuiFramework.FreeText rColetor;
		private NxtControl.GuiFramework.FreeText rGordura;
		private NxtControl.GuiFramework.FreeText rEntrada1;
		private NxtControl.GuiFramework.ChangeCanvasButton irSkid1;
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sDefault uct1;
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sGordura gordura1;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bomba1;
		private NxtControl.GuiFramework.FreeText rBomba1;
		private NxtControl.GuiFramework.FreeText rEntrada2;
		private NxtControl.GuiFramework.ChangeCanvasButton irSkid2;
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sDefault uct2;
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sGordura gordura2;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bomba2;
		private NxtControl.GuiFramework.FreeText rBomba2;
		private NxtControl.GuiFramework.FreeText rEntrada3;
		private NxtControl.GuiFramework.ChangeCanvasButton irSkid3;
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sDefault uct3;
		private Hidryco.HidrycoLib.Symbols.UCT_PreTratamento.sGordura gordura3;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bomba3;
		private NxtControl.GuiFramework.FreeText rBomba3;
		private NxtControl.GuiFramework.Rectangle naoInst3;
		private NxtControl.GuiFramework.FreeText rNaoInst3;
		private NxtControl.GuiFramework.FreeText rNaoInst3b;
		private NxtControl.GuiFramework.Ellipse ftBolha;
		private NxtControl.GuiFramework.FreeText ftTxt;
		private NxtControl.GuiFramework.FreeText rFT;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft02;
		private NxtControl.GuiFramework.Rectangle tqBuffer;
		private NxtControl.GuiFramework.FreeText rBuffer;
		private NxtControl.GuiFramework.ChangeCanvasButton irBuffer;
		private NxtControl.GuiFramework.Rectangle tqLodo;
		private NxtControl.GuiFramework.FreeText rLodo;
		private NxtControl.GuiFramework.FreeText rLodo2;
		#endregion
	}
}
