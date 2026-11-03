/*
 * Hidryco - Preparador_Vibropac - sPolimero
 * ISA-101: preparador de polimero e dosadoras DO-01/DO-02 (M4/M5) como no fluxograma do skid; cores dos motores, nivel LS1, estado e alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Preparador_Vibropac
{
	/// <summary>
	/// Summary description for sPolimero.
	/// </summary>
	partial class sPolimero
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.qt1 = new NxtControl.GuiFramework.Rectangle();
			this.qt2 = new NxtControl.GuiFramework.Rectangle();
			this.vsE = new NxtControl.GuiFramework.Polygon();
			this.vsD = new NxtControl.GuiFramework.Polygon();
			this.vsS = new NxtControl.GuiFramework.Rectangle();
			this.fSilo = new NxtControl.GuiFramework.Polygon();
			this.rosca = new NxtControl.GuiFramework.Rectangle();
			this.zz0 = new NxtControl.GuiFramework.Polygon();
			this.zz1 = new NxtControl.GuiFramework.Polygon();
			this.zz2 = new NxtControl.GuiFramework.Polygon();
			this.zz3 = new NxtControl.GuiFramework.Polygon();
			this.zz4 = new NxtControl.GuiFramework.Polygon();
			this.zz5 = new NxtControl.GuiFramework.Polygon();
			this.fM3 = new NxtControl.GuiFramework.Rectangle();
			this.qt3 = new NxtControl.GuiFramework.Rectangle();
			this.tanque = new NxtControl.GuiFramework.Rectangle();
			this.qt4 = new NxtControl.GuiFramework.Rectangle();
			this.qt5 = new NxtControl.GuiFramework.Rectangle();
			this.fM1 = new NxtControl.GuiFramework.Rectangle();
			this.qt6 = new NxtControl.GuiFramework.Rectangle();
			this.fM1h = new NxtControl.GuiFramework.Polygon();
			this.fM2 = new NxtControl.GuiFramework.Rectangle();
			this.qt7 = new NxtControl.GuiFramework.Rectangle();
			this.fM2h = new NxtControl.GuiFramework.Polygon();
			this.nivFundo = new NxtControl.GuiFramework.Rectangle();
			this.nivBarra = new NxtControl.GuiFramework.Rectangle();
			this.qt8 = new NxtControl.GuiFramework.Rectangle();
			this.qt9 = new NxtControl.GuiFramework.Rectangle();
			this.qt10 = new NxtControl.GuiFramework.Rectangle();
			this.qt11 = new NxtControl.GuiFramework.Rectangle();
			this.do1 = new Hidryco.HidrycoLib.Graphics.BombaHelicoidal();
			this.qt12 = new NxtControl.GuiFramework.Rectangle();
			this.qt13 = new NxtControl.GuiFramework.Rectangle();
			this.qvm14 = new NxtControl.GuiFramework.Polygon();
			this.qvm15 = new NxtControl.GuiFramework.Polygon();
			this.qvm16 = new NxtControl.GuiFramework.Rectangle();
			this.qt17 = new NxtControl.GuiFramework.Rectangle();
			this.qvr18 = new NxtControl.GuiFramework.Polygon();
			this.qvr19 = new NxtControl.GuiFramework.Rectangle();
			this.qr20 = new NxtControl.GuiFramework.FreeText();
			this.do2 = new Hidryco.HidrycoLib.Graphics.BombaHelicoidal();
			this.qt21 = new NxtControl.GuiFramework.Rectangle();
			this.qt22 = new NxtControl.GuiFramework.Rectangle();
			this.qvm23 = new NxtControl.GuiFramework.Polygon();
			this.qvm24 = new NxtControl.GuiFramework.Polygon();
			this.qvm25 = new NxtControl.GuiFramework.Rectangle();
			this.qt26 = new NxtControl.GuiFramework.Rectangle();
			this.qvr27 = new NxtControl.GuiFramework.Polygon();
			this.qvr28 = new NxtControl.GuiFramework.Rectangle();
			this.qr29 = new NxtControl.GuiFramework.FreeText();
			this.qt30 = new NxtControl.GuiFramework.Rectangle();
			this.qt31 = new NxtControl.GuiFramework.Rectangle();
			this.qr32 = new NxtControl.GuiFramework.FreeText();
			this.tFT2 = new NxtControl.GuiFramework.FreeText();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
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
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(392D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt1
			// 
			this.qt1.Bounds = new NxtControl.Drawing.RectF(((float)(-1.5D)), ((float)(64.5D)), ((float)(27D)), ((float)(3D)));
			this.qt1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.qt1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt1.Name = "qt1";
			this.qt1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt2
			// 
			this.qt2.Bounds = new NxtControl.Drawing.RectF(((float)(22.5D)), ((float)(64.5D)), ((float)(3D)), ((float)(21D)));
			this.qt2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.qt2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt2.Name = "qt2";
			this.qt2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// vsE
			// 
			this.vsE.Bounds = new NxtControl.Drawing.RectF(((float)(5D)), ((float)(61D)), ((float)(5D)), ((float)(10D)));
			this.vsE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.vsE.Closed = true;
			this.vsE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vsE.Name = "vsE";
			this.vsE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vsE.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(5D, 61D),
			new NxtControl.Drawing.PointF(5D, 71D),
			new NxtControl.Drawing.PointF(10D, 66D)});
			// 
			// vsD
			// 
			this.vsD.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(61D)), ((float)(5D)), ((float)(10D)));
			this.vsD.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.vsD.Closed = true;
			this.vsD.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vsD.Name = "vsD";
			this.vsD.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vsD.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(15D, 61D),
			new NxtControl.Drawing.PointF(15D, 71D),
			new NxtControl.Drawing.PointF(10D, 66D)});
			// 
			// vsS
			// 
			this.vsS.Bounds = new NxtControl.Drawing.RectF(((float)(7D)), ((float)(52D)), ((float)(7D)), ((float)(7D)));
			this.vsS.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))));
			this.vsS.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vsS.Name = "vsS";
			this.vsS.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fSilo
			// 
			this.fSilo.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(4D)), ((float)(50D)), ((float)(36D)));
			this.fSilo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.fSilo.Closed = true;
			this.fSilo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fSilo.Name = "fSilo";
			this.fSilo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fSilo.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(46D, 4D),
			new NxtControl.Drawing.PointF(96D, 4D),
			new NxtControl.Drawing.PointF(96D, 24D),
			new NxtControl.Drawing.PointF(80D, 40D),
			new NxtControl.Drawing.PointF(62D, 40D),
			new NxtControl.Drawing.PointF(46D, 24D)});
			// 
			// rosca
			// 
			this.rosca.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(40D)), ((float)(52D)), ((float)(10D)));
			this.rosca.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.rosca.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rosca.Name = "rosca";
			this.rosca.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// zz0
			// 
			this.zz0.Bounds = new NxtControl.Drawing.RectF(((float)(58D)), ((float)(41D)), ((float)(5D)), ((float)(8D)));
			this.zz0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.zz0.Closed = true;
			this.zz0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.zz0.Name = "zz0";
			this.zz0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.zz0.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(58D, 49D),
			new NxtControl.Drawing.PointF(62D, 41D),
			new NxtControl.Drawing.PointF(63D, 41D),
			new NxtControl.Drawing.PointF(59D, 49D)});
			// 
			// zz1
			// 
			this.zz1.Bounds = new NxtControl.Drawing.RectF(((float)(66D)), ((float)(41D)), ((float)(5D)), ((float)(8D)));
			this.zz1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.zz1.Closed = true;
			this.zz1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.zz1.Name = "zz1";
			this.zz1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.zz1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(66D, 49D),
			new NxtControl.Drawing.PointF(70D, 41D),
			new NxtControl.Drawing.PointF(71D, 41D),
			new NxtControl.Drawing.PointF(67D, 49D)});
			// 
			// zz2
			// 
			this.zz2.Bounds = new NxtControl.Drawing.RectF(((float)(74D)), ((float)(41D)), ((float)(5D)), ((float)(8D)));
			this.zz2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.zz2.Closed = true;
			this.zz2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.zz2.Name = "zz2";
			this.zz2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.zz2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(74D, 49D),
			new NxtControl.Drawing.PointF(78D, 41D),
			new NxtControl.Drawing.PointF(79D, 41D),
			new NxtControl.Drawing.PointF(75D, 49D)});
			// 
			// zz3
			// 
			this.zz3.Bounds = new NxtControl.Drawing.RectF(((float)(82D)), ((float)(41D)), ((float)(5D)), ((float)(8D)));
			this.zz3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.zz3.Closed = true;
			this.zz3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.zz3.Name = "zz3";
			this.zz3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.zz3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(82D, 49D),
			new NxtControl.Drawing.PointF(86D, 41D),
			new NxtControl.Drawing.PointF(87D, 41D),
			new NxtControl.Drawing.PointF(83D, 49D)});
			// 
			// zz4
			// 
			this.zz4.Bounds = new NxtControl.Drawing.RectF(((float)(90D)), ((float)(41D)), ((float)(5D)), ((float)(8D)));
			this.zz4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.zz4.Closed = true;
			this.zz4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.zz4.Name = "zz4";
			this.zz4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.zz4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(90D, 49D),
			new NxtControl.Drawing.PointF(94D, 41D),
			new NxtControl.Drawing.PointF(95D, 41D),
			new NxtControl.Drawing.PointF(91D, 49D)});
			// 
			// zz5
			// 
			this.zz5.Bounds = new NxtControl.Drawing.RectF(((float)(98D)), ((float)(41D)), ((float)(5D)), ((float)(8D)));
			this.zz5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.zz5.Closed = true;
			this.zz5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.zz5.Name = "zz5";
			this.zz5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.zz5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(98D, 49D),
			new NxtControl.Drawing.PointF(102D, 41D),
			new NxtControl.Drawing.PointF(103D, 41D),
			new NxtControl.Drawing.PointF(99D, 49D)});
			// 
			// fM3
			// 
			this.fM3.Bounds = new NxtControl.Drawing.RectF(((float)(108D)), ((float)(38D)), ((float)(16D)), ((float)(14D)));
			this.fM3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.fM3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fM3.Name = "fM3";
			this.fM3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt3
			// 
			this.qt3.Bounds = new NxtControl.Drawing.RectF(((float)(61D)), ((float)(49D)), ((float)(2D)), ((float)(36D)));
			this.qt3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.qt3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt3.Name = "qt3";
			this.qt3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tanque
			// 
			this.tanque.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(84D)), ((float)(228D)), ((float)(92D)));
			this.tanque.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.tanque.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tanque.Name = "tanque";
			this.tanque.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt4
			// 
			this.qt4.Bounds = new NxtControl.Drawing.RectF(((float)(85.5D)), ((float)(83.5D)), ((float)(1D)), ((float)(93D)));
			this.qt4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.qt4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt4.Name = "qt4";
			this.qt4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt5
			// 
			this.qt5.Bounds = new NxtControl.Drawing.RectF(((float)(161.5D)), ((float)(83.5D)), ((float)(1D)), ((float)(93D)));
			this.qt5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.qt5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt5.Name = "qt5";
			this.qt5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fM1
			// 
			this.fM1.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(64D)), ((float)(16D)), ((float)(14D)));
			this.fM1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.fM1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fM1.Name = "fM1";
			this.fM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt6
			// 
			this.qt6.Bounds = new NxtControl.Drawing.RectF(((float)(39D)), ((float)(77D)), ((float)(2D)), ((float)(80D)));
			this.qt6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.qt6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt6.Name = "qt6";
			this.qt6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fM1h
			// 
			this.fM1h.Bounds = new NxtControl.Drawing.RectF(((float)(28D)), ((float)(152D)), ((float)(24D)), ((float)(8D)));
			this.fM1h.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))));
			this.fM1h.Closed = true;
			this.fM1h.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fM1h.Name = "fM1h";
			this.fM1h.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fM1h.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 152D),
			new NxtControl.Drawing.PointF(40D, 156D),
			new NxtControl.Drawing.PointF(52D, 152D),
			new NxtControl.Drawing.PointF(52D, 160D),
			new NxtControl.Drawing.PointF(40D, 156D),
			new NxtControl.Drawing.PointF(28D, 160D)});
			// 
			// fM2
			// 
			this.fM2.Bounds = new NxtControl.Drawing.RectF(((float)(116D)), ((float)(64D)), ((float)(16D)), ((float)(14D)));
			this.fM2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.fM2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fM2.Name = "fM2";
			this.fM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt7
			// 
			this.qt7.Bounds = new NxtControl.Drawing.RectF(((float)(123D)), ((float)(77D)), ((float)(2D)), ((float)(80D)));
			this.qt7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.qt7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt7.Name = "qt7";
			this.qt7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fM2h
			// 
			this.fM2h.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(152D)), ((float)(24D)), ((float)(8D)));
			this.fM2h.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))));
			this.fM2h.Closed = true;
			this.fM2h.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fM2h.Name = "fM2h";
			this.fM2h.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fM2h.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(112D, 152D),
			new NxtControl.Drawing.PointF(124D, 156D),
			new NxtControl.Drawing.PointF(136D, 152D),
			new NxtControl.Drawing.PointF(136D, 160D),
			new NxtControl.Drawing.PointF(124D, 156D),
			new NxtControl.Drawing.PointF(112D, 160D)});
			// 
			// nivFundo
			// 
			this.nivFundo.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(92D)), ((float)(8D)), ((float)(76D)));
			this.nivFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.nivFundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nivFundo.Name = "nivFundo";
			this.nivFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(128)), ((byte)(128))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nivBarra
			// 
			this.nivBarra.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(168D)), ((float)(8D)), ((float)(0D)));
			this.nivBarra.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(166)), ((byte)(186)), ((byte)(214))));
			this.nivBarra.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nivBarra.Name = "nivBarra";
			this.nivBarra.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt8
			// 
			this.qt8.Bounds = new NxtControl.Drawing.RectF(((float)(236.5D)), ((float)(168.5D)), ((float)(11D)), ((float)(3D)));
			this.qt8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt8.Name = "qt8";
			this.qt8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt9
			// 
			this.qt9.Bounds = new NxtControl.Drawing.RectF(((float)(244.5D)), ((float)(168.5D)), ((float)(3D)), ((float)(29D)));
			this.qt9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt9.Name = "qt9";
			this.qt9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt10
			// 
			this.qt10.Bounds = new NxtControl.Drawing.RectF(((float)(18.5D)), ((float)(194.5D)), ((float)(229D)), ((float)(3D)));
			this.qt10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt10.Name = "qt10";
			this.qt10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt11
			// 
			this.qt11.Bounds = new NxtControl.Drawing.RectF(((float)(18.5D)), ((float)(194.5D)), ((float)(3D)), ((float)(91D)));
			this.qt11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt11.Name = "qt11";
			this.qt11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// do1
			// 
			this.do1.BeginInit();
			this.do1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55D, 0D, 0D, 0.55D, 60D, 230D);
			this.do1.Name = "do1";
			this.do1.EndInit();
			// 
			// qt12
			// 
			this.qt12.Bounds = new NxtControl.Drawing.RectF(((float)(18.5D)), ((float)(212.5D)), ((float)(87D)), ((float)(3D)));
			this.qt12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt12.Name = "qt12";
			this.qt12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt13
			// 
			this.qt13.Bounds = new NxtControl.Drawing.RectF(((float)(102.5D)), ((float)(212.5D)), ((float)(3D)), ((float)(19D)));
			this.qt13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt13.Name = "qt13";
			this.qt13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qvm14
			// 
			this.qvm14.Bounds = new NxtControl.Drawing.RectF(((float)(37D)), ((float)(209D)), ((float)(5D)), ((float)(10D)));
			this.qvm14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.qvm14.Closed = true;
			this.qvm14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvm14.Name = "qvm14";
			this.qvm14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.qvm14.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(37D, 209D),
			new NxtControl.Drawing.PointF(37D, 219D),
			new NxtControl.Drawing.PointF(42D, 214D)});
			// 
			// qvm15
			// 
			this.qvm15.Bounds = new NxtControl.Drawing.RectF(((float)(42D)), ((float)(209D)), ((float)(5D)), ((float)(10D)));
			this.qvm15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.qvm15.Closed = true;
			this.qvm15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvm15.Name = "qvm15";
			this.qvm15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.qvm15.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(47D, 209D),
			new NxtControl.Drawing.PointF(47D, 219D),
			new NxtControl.Drawing.PointF(42D, 214D)});
			// 
			// qvm16
			// 
			this.qvm16.Bounds = new NxtControl.Drawing.RectF(((float)(41.25D)), ((float)(210D)), ((float)(1.5D)), ((float)(8D)));
			this.qvm16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.qvm16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvm16.Name = "qvm16";
			this.qvm16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt17
			// 
			this.qt17.Bounds = new NxtControl.Drawing.RectF(((float)(170.7D)), ((float)(246.1D)), ((float)(44.8D)), ((float)(3D)));
			this.qt17.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt17.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt17.Name = "qt17";
			this.qt17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qvr18
			// 
			this.qvr18.Bounds = new NxtControl.Drawing.RectF(((float)(189D)), ((float)(242.6D)), ((float)(8D)), ((float)(10D)));
			this.qvr18.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.qvr18.Closed = true;
			this.qvr18.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvr18.Name = "qvr18";
			this.qvr18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.qvr18.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(189D, 242.6D),
			new NxtControl.Drawing.PointF(189D, 252.6D),
			new NxtControl.Drawing.PointF(197D, 247.6D)});
			// 
			// qvr19
			// 
			this.qvr19.Bounds = new NxtControl.Drawing.RectF(((float)(197D)), ((float)(242.6D)), ((float)(2D)), ((float)(10D)));
			this.qvr19.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.qvr19.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvr19.Name = "qvr19";
			this.qvr19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qr20
			// 
			this.qr20.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.qr20.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.qr20.Location = new NxtControl.Drawing.PointF(66D, 268D);
			this.qr20.Name = "qr20";
			this.qr20.Text = "DO-01";
			// 
			// do2
			// 
			this.do2.BeginInit();
			this.do2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55D, 0D, 0D, 0.55D, 60D, 300D);
			this.do2.Name = "do2";
			this.do2.EndInit();
			// 
			// qt21
			// 
			this.qt21.Bounds = new NxtControl.Drawing.RectF(((float)(18.5D)), ((float)(282.5D)), ((float)(87D)), ((float)(3D)));
			this.qt21.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt21.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt21.Name = "qt21";
			this.qt21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt22
			// 
			this.qt22.Bounds = new NxtControl.Drawing.RectF(((float)(102.5D)), ((float)(282.5D)), ((float)(3D)), ((float)(19D)));
			this.qt22.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt22.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt22.Name = "qt22";
			this.qt22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qvm23
			// 
			this.qvm23.Bounds = new NxtControl.Drawing.RectF(((float)(37D)), ((float)(279D)), ((float)(5D)), ((float)(10D)));
			this.qvm23.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.qvm23.Closed = true;
			this.qvm23.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvm23.Name = "qvm23";
			this.qvm23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.qvm23.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(37D, 279D),
			new NxtControl.Drawing.PointF(37D, 289D),
			new NxtControl.Drawing.PointF(42D, 284D)});
			// 
			// qvm24
			// 
			this.qvm24.Bounds = new NxtControl.Drawing.RectF(((float)(42D)), ((float)(279D)), ((float)(5D)), ((float)(10D)));
			this.qvm24.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.qvm24.Closed = true;
			this.qvm24.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvm24.Name = "qvm24";
			this.qvm24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.qvm24.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(47D, 279D),
			new NxtControl.Drawing.PointF(47D, 289D),
			new NxtControl.Drawing.PointF(42D, 284D)});
			// 
			// qvm25
			// 
			this.qvm25.Bounds = new NxtControl.Drawing.RectF(((float)(41.25D)), ((float)(280D)), ((float)(1.5D)), ((float)(8D)));
			this.qvm25.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.qvm25.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvm25.Name = "qvm25";
			this.qvm25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt26
			// 
			this.qt26.Bounds = new NxtControl.Drawing.RectF(((float)(170.7D)), ((float)(316.1D)), ((float)(44.8D)), ((float)(3D)));
			this.qt26.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt26.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt26.Name = "qt26";
			this.qt26.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qvr27
			// 
			this.qvr27.Bounds = new NxtControl.Drawing.RectF(((float)(189D)), ((float)(312.6D)), ((float)(8D)), ((float)(10D)));
			this.qvr27.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.qvr27.Closed = true;
			this.qvr27.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvr27.Name = "qvr27";
			this.qvr27.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.qvr27.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(189D, 312.6D),
			new NxtControl.Drawing.PointF(189D, 322.6D),
			new NxtControl.Drawing.PointF(197D, 317.6D)});
			// 
			// qvr28
			// 
			this.qvr28.Bounds = new NxtControl.Drawing.RectF(((float)(197D)), ((float)(312.6D)), ((float)(2D)), ((float)(10D)));
			this.qvr28.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.qvr28.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qvr28.Name = "qvr28";
			this.qvr28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qr29
			// 
			this.qr29.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.qr29.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.qr29.Location = new NxtControl.Drawing.PointF(66D, 338D);
			this.qr29.Name = "qr29";
			this.qr29.Text = "DO-02";
			// 
			// qt30
			// 
			this.qt30.Bounds = new NxtControl.Drawing.RectF(((float)(212.5D)), ((float)(246.1D)), ((float)(3D)), ((float)(73D)));
			this.qt30.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt30.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt30.Name = "qt30";
			this.qt30.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qt31
			// 
			this.qt31.Bounds = new NxtControl.Drawing.RectF(((float)(212.5D)), ((float)(280.5D)), ((float)(39D)), ((float)(3D)));
			this.qt31.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.qt31.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.qt31.Name = "qt31";
			this.qt31.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// qr32
			// 
			this.qr32.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.qr32.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.qr32.Location = new NxtControl.Drawing.PointF(186D, 334D);
			this.qr32.Name = "qr32";
			this.qr32.Text = "FT-2";
			// 
			// tFT2
			// 
			this.tFT2.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.tFT2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.tFT2.Location = new NxtControl.Drawing.PointF(210D, 334D);
			this.tFT2.Name = "tFT2";
			this.tFT2.Text = "";
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.l1.Location = new NxtControl.Drawing.PointF(0D, 354D);
			this.l1.Name = "l1";
			this.l1.Text = "";
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(0D, 372D);
			this.l2.Name = "l2";
			this.l2.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(6D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(144D, 7D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(6D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(140D, 22D),
			new NxtControl.Drawing.PointF(148D, 6D),
			new NxtControl.Drawing.PointF(156D, 22D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(145D, 9D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(160D, 6D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
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
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(392D)));
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
			// sPolimero
			// 
			this.Name = "sPolimero";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.qt1,
			this.qt2,
			this.vsE,
			this.vsD,
			this.vsS,
			this.fSilo,
			this.rosca,
			this.zz0,
			this.zz1,
			this.zz2,
			this.zz3,
			this.zz4,
			this.zz5,
			this.fM3,
			this.qt3,
			this.tanque,
			this.qt4,
			this.qt5,
			this.fM1,
			this.qt6,
			this.fM1h,
			this.fM2,
			this.qt7,
			this.fM2h,
			this.nivFundo,
			this.nivBarra,
			this.qt8,
			this.qt9,
			this.qt10,
			this.qt11,
			this.do1,
			this.qt12,
			this.qt13,
			this.qvm14,
			this.qvm15,
			this.qvm16,
			this.qt17,
			this.qvr18,
			this.qvr19,
			this.qr20,
			this.do2,
			this.qt21,
			this.qt22,
			this.qvm23,
			this.qvm24,
			this.qvm25,
			this.qt26,
			this.qvr27,
			this.qvr28,
			this.qr29,
			this.qt30,
			this.qt31,
			this.qr32,
			this.tFT2,
			this.l1,
			this.l2,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
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
			this.SymbolSize = new System.Drawing.Size(250, 392);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle qt1;
		private NxtControl.GuiFramework.Rectangle qt2;
		private NxtControl.GuiFramework.Polygon vsE;
		private NxtControl.GuiFramework.Polygon vsD;
		private NxtControl.GuiFramework.Rectangle vsS;
		private NxtControl.GuiFramework.Polygon fSilo;
		private NxtControl.GuiFramework.Rectangle rosca;
		private NxtControl.GuiFramework.Polygon zz0;
		private NxtControl.GuiFramework.Polygon zz1;
		private NxtControl.GuiFramework.Polygon zz2;
		private NxtControl.GuiFramework.Polygon zz3;
		private NxtControl.GuiFramework.Polygon zz4;
		private NxtControl.GuiFramework.Polygon zz5;
		private NxtControl.GuiFramework.Rectangle fM3;
		private NxtControl.GuiFramework.Rectangle qt3;
		private NxtControl.GuiFramework.Rectangle tanque;
		private NxtControl.GuiFramework.Rectangle qt4;
		private NxtControl.GuiFramework.Rectangle qt5;
		private NxtControl.GuiFramework.Rectangle fM1;
		private NxtControl.GuiFramework.Rectangle qt6;
		private NxtControl.GuiFramework.Polygon fM1h;
		private NxtControl.GuiFramework.Rectangle fM2;
		private NxtControl.GuiFramework.Rectangle qt7;
		private NxtControl.GuiFramework.Polygon fM2h;
		private NxtControl.GuiFramework.Rectangle nivFundo;
		private NxtControl.GuiFramework.Rectangle nivBarra;
		private NxtControl.GuiFramework.Rectangle qt8;
		private NxtControl.GuiFramework.Rectangle qt9;
		private NxtControl.GuiFramework.Rectangle qt10;
		private NxtControl.GuiFramework.Rectangle qt11;
		private Hidryco.HidrycoLib.Graphics.BombaHelicoidal do1;
		private NxtControl.GuiFramework.Rectangle qt12;
		private NxtControl.GuiFramework.Rectangle qt13;
		private NxtControl.GuiFramework.Polygon qvm14;
		private NxtControl.GuiFramework.Polygon qvm15;
		private NxtControl.GuiFramework.Rectangle qvm16;
		private NxtControl.GuiFramework.Rectangle qt17;
		private NxtControl.GuiFramework.Polygon qvr18;
		private NxtControl.GuiFramework.Rectangle qvr19;
		private NxtControl.GuiFramework.FreeText qr20;
		private Hidryco.HidrycoLib.Graphics.BombaHelicoidal do2;
		private NxtControl.GuiFramework.Rectangle qt21;
		private NxtControl.GuiFramework.Rectangle qt22;
		private NxtControl.GuiFramework.Polygon qvm23;
		private NxtControl.GuiFramework.Polygon qvm24;
		private NxtControl.GuiFramework.Rectangle qvm25;
		private NxtControl.GuiFramework.Rectangle qt26;
		private NxtControl.GuiFramework.Polygon qvr27;
		private NxtControl.GuiFramework.Rectangle qvr28;
		private NxtControl.GuiFramework.FreeText qr29;
		private NxtControl.GuiFramework.Rectangle qt30;
		private NxtControl.GuiFramework.Rectangle qt31;
		private NxtControl.GuiFramework.FreeText qr32;
		private NxtControl.GuiFramework.FreeText tFT2;
		private NxtControl.GuiFramework.FreeText l1;
		private NxtControl.GuiFramework.FreeText l2;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
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
