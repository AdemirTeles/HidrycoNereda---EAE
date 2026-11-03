/*
 * Hidryco - Preparador_Vibropac - fpSkid
 * Skid preparador VIB-3000 + dosagem (fluxograma DE-36142-VCE-001): M1..M5, VS-01, FIT-01/02, LSL silo, LS1, resistencia, alarmes.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Preparador_Vibropac
{
	/// <summary>
	/// Summary description for fpSkid.
	/// </summary>
	partial class fpSkid
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.group3 = new NxtControl.GuiFramework.Group();
			this.group4 = new NxtControl.GuiFramework.Group();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.line16 = new NxtControl.GuiFramework.Line();
			this.line26 = new NxtControl.GuiFramework.Line();
			this.line27 = new NxtControl.GuiFramework.Line();
			this.line28 = new NxtControl.GuiFramework.Line();
			this.line29 = new NxtControl.GuiFramework.Line();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.line60 = new NxtControl.GuiFramework.Line();
			this.line61 = new NxtControl.GuiFramework.Line();
			this.line62 = new NxtControl.GuiFramework.Line();
			this.line63 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.vs01_01 = new NxtControl.GuiFramework.Polygon();
			this.vs01_03 = new NxtControl.GuiFramework.Polygon();
			this.vs01_02 = new NxtControl.GuiFramework.Ellipse();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.rectangle19 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle20 = new NxtControl.GuiFramework.Rectangle();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.line64 = new NxtControl.GuiFramework.Line();
			this.line65 = new NxtControl.GuiFramework.Line();
			this.line66 = new NxtControl.GuiFramework.Line();
			this.line67 = new NxtControl.GuiFramework.Line();
			this.line68 = new NxtControl.GuiFramework.Line();
			this.line69 = new NxtControl.GuiFramework.Line();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.line17 = new NxtControl.GuiFramework.Line();
			this.line18 = new NxtControl.GuiFramework.Line();
			this.line19 = new NxtControl.GuiFramework.Line();
			this.line20 = new NxtControl.GuiFramework.Line();
			this.line21 = new NxtControl.GuiFramework.Line();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.line23 = new NxtControl.GuiFramework.Line();
			this.line24 = new NxtControl.GuiFramework.Line();
			this.line25 = new NxtControl.GuiFramework.Line();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.unidade_Portecao_Termica1 = new Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica();
			this.group17 = new NxtControl.GuiFramework.Group();
			this.alarme_acionado1 = new Hidryco.HidrycoLib.Graphics.alarme_acionado();
			this.emergencia_acionada1 = new Hidryco.HidrycoLib.Graphics.emergencia_acionada();
			this.m3_3 = new NxtControl.GuiFramework.Rectangle();
			this.m3_2 = new NxtControl.GuiFramework.Rectangle();
			this.m3_1 = new NxtControl.GuiFramework.Rectangle();
			this.m1_3 = new NxtControl.GuiFramework.Rectangle();
			this.m1_2 = new NxtControl.GuiFramework.Rectangle();
			this.m1_1 = new NxtControl.GuiFramework.Rectangle();
			this.m2_3 = new NxtControl.GuiFramework.Rectangle();
			this.m2_2 = new NxtControl.GuiFramework.Rectangle();
			this.m2_1 = new NxtControl.GuiFramework.Rectangle();
			this.m4_3 = new NxtControl.GuiFramework.Rectangle();
			this.m4_2 = new NxtControl.GuiFramework.Rectangle();
			this.m4_1 = new NxtControl.GuiFramework.Rectangle();
			this.m5_3 = new NxtControl.GuiFramework.Rectangle();
			this.m5_2 = new NxtControl.GuiFramework.Rectangle();
			this.m5_1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.line80 = new NxtControl.GuiFramework.Line();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.lslOn = new NxtControl.GuiFramework.Group();
			this.lslOff = new NxtControl.GuiFramework.Group();
			this.cmLsLLOff = new NxtControl.GuiFramework.Group();
			this.cmLsLLOn = new NxtControl.GuiFramework.Group();
			this.cmLsLOff = new NxtControl.GuiFramework.Group();
			this.cmLsLOn = new NxtControl.GuiFramework.Group();
			this.cmLsHOff = new NxtControl.GuiFramework.Group();
			this.cmLsHOn = new NxtControl.GuiFramework.Group();
			this.cmLsHhOff = new NxtControl.GuiFramework.Group();
			this.cmLsHhOn = new NxtControl.GuiFramework.Group();
			this.helicoidal1 = new Hidryco.HidrycoLib.Graphics.Helicoidal();
			this.helicoidal2 = new Hidryco.HidrycoLib.Graphics.Helicoidal();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.line14 = new NxtControl.GuiFramework.Line();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.lineHSilo = new NxtControl.GuiFramework.Line();
			this.bolinhaHSilo = new NxtControl.GuiFramework.Ellipse();
			this.bolinhaLSilo = new NxtControl.GuiFramework.Ellipse();
			this.lineLSilo = new NxtControl.GuiFramework.Line();
			this.line72 = new NxtControl.GuiFramework.Line();
			this.ellipse5 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse6 = new NxtControl.GuiFramework.Ellipse();
			this.line73 = new NxtControl.GuiFramework.Line();
			this.line74 = new NxtControl.GuiFramework.Line();
			this.ellipse7 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse8 = new NxtControl.GuiFramework.Ellipse();
			this.line75 = new NxtControl.GuiFramework.Line();
			this.line76 = new NxtControl.GuiFramework.Line();
			this.ellipse9 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse10 = new NxtControl.GuiFramework.Ellipse();
			this.line77 = new NxtControl.GuiFramework.Line();
			this.line78 = new NxtControl.GuiFramework.Line();
			this.ellipse11 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse12 = new NxtControl.GuiFramework.Ellipse();
			this.line79 = new NxtControl.GuiFramework.Line();
			this.label11 = new NxtControl.GuiFramework.Label();
			this.label12 = new NxtControl.GuiFramework.Label();
			this.rectangle21 = new NxtControl.GuiFramework.Rectangle();
			this.tFIT1 = new NxtControl.GuiFramework.FreeText();
			this.tFIT2 = new NxtControl.GuiFramework.FreeText();
			this.tAgua = new NxtControl.GuiFramework.FreeText();
			this.tVaz = new NxtControl.GuiFramework.FreeText();
			this.tDO1 = new NxtControl.GuiFramework.FreeText();
			this.tDO2 = new NxtControl.GuiFramework.FreeText();
			this.rodape = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.e1 = new NxtControl.GuiFramework.FreeText();
			this.e2 = new NxtControl.GuiFramework.FreeText();
			this.btnCmd = new NxtControl.GuiFramework.DrawnButton();
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
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(215D)), ((float)(271D)), ((float)(108D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(175D, 222D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(175D, 323D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(263D, 222D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(263D, 323D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(128D, 300D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(128D, 215D);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(122D)), ((float)(259D)), ((float)(12D)), ((float)(8D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(122D)), ((float)(296D)), ((float)(12D)), ((float)(8D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line7,
			this.line8,
			this.line9});
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line10,
			this.line11,
			this.line12});
			this.group2.EndInit();
			// 
			// group3
			// 
			this.group3.BeginInit();
			this.group3.Name = "group3";
			this.group3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line4,
			this.line5,
			this.line6});
			this.group3.EndInit();
			// 
			// group4
			// 
			this.group4.BeginInit();
			this.group4.Name = "group4";
			this.group4.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line13,
			this.line14,
			this.line15});
			this.group4.EndInit();
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(223D)), ((float)(294D)), ((float)(25D)), ((float)(10D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(true);
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(188D)), ((float)(294D)), ((float)(25D)), ((float)(10D)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(true);
			this.ellipse2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(212D)), ((float)(295D)), ((float)(12D)), ((float)(8D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// line16
			// 
			this.line16.EndPoint = new NxtControl.Drawing.PointF(218D, 299D);
			this.line16.Name = "line16";
			this.line16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line16.StartPoint = new NxtControl.Drawing.PointF(218D, 215D);
			// 
			// line26
			// 
			this.line26.EndPoint = new NxtControl.Drawing.PointF(587D, 221D);
			this.line26.Name = "line26";
			this.line26.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line26.StartPoint = new NxtControl.Drawing.PointF(539D, 221D);
			// 
			// line27
			// 
			this.line27.EndPoint = new NxtControl.Drawing.PointF(587D, 286D);
			this.line27.Name = "line27";
			this.line27.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line27.StartPoint = new NxtControl.Drawing.PointF(540D, 286D);
			// 
			// line28
			// 
			this.line28.EndPoint = new NxtControl.Drawing.PointF(587D, 287D);
			this.line28.Name = "line28";
			this.line28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line28.StartPoint = new NxtControl.Drawing.PointF(587D, 221D);
			// 
			// line29
			// 
			this.line29.EndPoint = new NxtControl.Drawing.PointF(675D, 256D);
			this.line29.Name = "line29";
			this.line29.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line29.StartPoint = new NxtControl.Drawing.PointF(588D, 256D);
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(608D, 218D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "FT2";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
			this.freeText1.Location = new NxtControl.Drawing.PointF(174D, 350D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "ENTRADA DE \r\nÁGUA";
			// 
			// line60
			// 
			this.line60.EndPoint = new NxtControl.Drawing.PointF(45D, 362D);
			this.line60.Name = "line60";
			this.line60.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line60.StartPoint = new NxtControl.Drawing.PointF(174D, 362D);
			// 
			// line61
			// 
			this.line61.EndPoint = new NxtControl.Drawing.PointF(46D, 196D);
			this.line61.Name = "line61";
			this.line61.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line61.StartPoint = new NxtControl.Drawing.PointF(45D, 362D);
			// 
			// line62
			// 
			this.line62.EndPoint = new NxtControl.Drawing.PointF(85D, 196D);
			this.line62.Name = "line62";
			this.line62.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line62.StartPoint = new NxtControl.Drawing.PointF(46D, 196D);
			// 
			// line63
			// 
			this.line63.EndPoint = new NxtControl.Drawing.PointF(85D, 215D);
			this.line63.Name = "line63";
			this.line63.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line63.StartPoint = new NxtControl.Drawing.PointF(85D, 196D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(153D)), ((float)(350D)), ((float)(8D)), ((float)(8D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(161D, 358D),
			new NxtControl.Drawing.PointF(153D, 354.57142857142856D),
			new NxtControl.Drawing.PointF(161D, 350D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(146D)), ((float)(350D)), ((float)(7D)), ((float)(8D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(153D, 358D),
			new NxtControl.Drawing.PointF(146D, 354.57142857142856D),
			new NxtControl.Drawing.PointF(153D, 350D)});
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(12D, 294D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "VS1";
			// 
			// vs01_01
			// 
			this.vs01_01.Bounds = new NxtControl.Drawing.RectF(((float)(38.5D)), ((float)(287D)), ((float)(14.5D)), ((float)(14.5D)));
			this.vs01_01.Closed = true;
			this.vs01_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vs01_01.Name = "vs01_01";
			this.vs01_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(53D, 287D),
			new NxtControl.Drawing.PointF(38.5D, 287D),
			new NxtControl.Drawing.PointF(45.75D, 301.5D)});
			// 
			// vs01_03
			// 
			this.vs01_03.Bounds = new NxtControl.Drawing.RectF(((float)(38.5D)), ((float)(300.5D)), ((float)(14.5D)), ((float)(14.5D)));
			this.vs01_03.Closed = true;
			this.vs01_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vs01_03.Name = "vs01_03";
			this.vs01_03.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(53D, 315D),
			new NxtControl.Drawing.PointF(38.5D, 315D),
			new NxtControl.Drawing.PointF(45.75D, 300.5D)});
			// 
			// vs01_02
			// 
			this.vs01_02.Bounds = new NxtControl.Drawing.RectF(((float)(40.3125D)), ((float)(295.66668701171875D)), ((float)(10.875D)), ((float)(10.875D)));
			this.vs01_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vs01_02.Name = "vs01_02";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(15D, 212D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "FT1";
			// 
			// rectangle19
			// 
			this.rectangle19.Bounds = new NxtControl.Drawing.RectF(((float)(39D)), ((float)(228D)), ((float)(14D)), ((float)(14D)));
			this.rectangle19.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle19.Name = "rectangle19";
			// 
			// rectangle20
			// 
			this.rectangle20.Bounds = new NxtControl.Drawing.RectF(((float)(613D)), ((float)(248D)), ((float)(14D)), ((float)(14D)));
			this.rectangle20.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle20.Name = "rectangle20";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(1D, 136D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "M3";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(113D, 158D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "M1";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(203D, 159D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "M2";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(409D, 194D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "M4";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(409D, 258D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "M5";
			// 
			// line64
			// 
			this.line64.EndPoint = new NxtControl.Drawing.PointF(357D, 250D);
			this.line64.Name = "line64";
			this.line64.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line64.StartPoint = new NxtControl.Drawing.PointF(357D, 250D);
			// 
			// line65
			// 
			this.line65.EndPoint = new NxtControl.Drawing.PointF(476D, 250D);
			this.line65.Name = "line65";
			this.line65.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line65.StartPoint = new NxtControl.Drawing.PointF(352D, 250D);
			// 
			// line66
			// 
			this.line66.EndPoint = new NxtControl.Drawing.PointF(389D, 161D);
			this.line66.Name = "line66";
			this.line66.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line66.StartPoint = new NxtControl.Drawing.PointF(389D, 250D);
			// 
			// line67
			// 
			this.line67.EndPoint = new NxtControl.Drawing.PointF(474D, 161D);
			this.line67.Name = "line67";
			this.line67.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line67.StartPoint = new NxtControl.Drawing.PointF(389D, 161D);
			// 
			// line68
			// 
			this.line68.EndPoint = new NxtControl.Drawing.PointF(475D, 211D);
			this.line68.Name = "line68";
			this.line68.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line68.StartPoint = new NxtControl.Drawing.PointF(475D, 161D);
			// 
			// line69
			// 
			this.line69.EndPoint = new NxtControl.Drawing.PointF(475D, 276D);
			this.line69.Name = "line69";
			this.line69.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line69.StartPoint = new NxtControl.Drawing.PointF(475D, 250D);
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(86.125D)), ((float)(171.45832824707031D)), ((float)(6.875D)), ((float)(43.541667938232422D)));
			this.rectangle5.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(42.583335876464844D)), ((float)(156.70832824707031D)), ((float)(50.416667938232422D)), ((float)(13.75D)));
			this.rectangle6.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// line17
			// 
			this.line17.EndPoint = new NxtControl.Drawing.PointF(45.638888888888886D, 156.70833333333337D);
			this.line17.Name = "line17";
			this.line17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line17.StartPoint = new NxtControl.Drawing.PointF(42.583333333333329D, 163.58333333333337D);
			// 
			// line18
			// 
			this.line18.EndPoint = new NxtControl.Drawing.PointF(45.638888888888886D, 156.70833333333337D);
			this.line18.Name = "line18";
			this.line18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line18.StartPoint = new NxtControl.Drawing.PointF(51.75D, 170.45833333333337D);
			// 
			// line19
			// 
			this.line19.EndPoint = new NxtControl.Drawing.PointF(51.75D, 170.45833333333337D);
			this.line19.Name = "line19";
			this.line19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line19.StartPoint = new NxtControl.Drawing.PointF(57.861111111111114D, 156.70833333333337D);
			// 
			// line20
			// 
			this.line20.EndPoint = new NxtControl.Drawing.PointF(57.861111111111114D, 156.70833333333337D);
			this.line20.Name = "line20";
			this.line20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line20.StartPoint = new NxtControl.Drawing.PointF(63.972222222222229D, 170.45833333333337D);
			// 
			// line21
			// 
			this.line21.EndPoint = new NxtControl.Drawing.PointF(63.972222222222229D, 170.45833333333337D);
			this.line21.Name = "line21";
			this.line21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line21.StartPoint = new NxtControl.Drawing.PointF(70.083333333333329D, 156.70833333333337D);
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(70.083333333333329D, 156.70833333333337D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(76.194444444444443D, 170.45833333333337D);
			// 
			// line23
			// 
			this.line23.EndPoint = new NxtControl.Drawing.PointF(76.194444444444443D, 170.45833333333337D);
			this.line23.Name = "line23";
			this.line23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line23.StartPoint = new NxtControl.Drawing.PointF(82.305555555555543D, 156.70833333333337D);
			// 
			// line24
			// 
			this.line24.EndPoint = new NxtControl.Drawing.PointF(82.305555555555543D, 156.70833333333337D);
			this.line24.Name = "line24";
			this.line24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line24.StartPoint = new NxtControl.Drawing.PointF(88.416666666666657D, 170.45833333333337D);
			// 
			// line25
			// 
			this.line25.EndPoint = new NxtControl.Drawing.PointF(88.416666666666657D, 170.45833333333337D);
			this.line25.Name = "line25";
			this.line25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line25.StartPoint = new NxtControl.Drawing.PointF(93D, 160.52777777777777D);
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(49.458335876464844D)), ((float)(132.5D)), ((float)(9.1666669845581055D)), ((float)(25.208333969116211D)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(31D)), ((float)(101.63888888888891D)), ((float)(44D)), ((float)(30D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(31D, 115.48504273504264D),
			new NxtControl.Drawing.PointF(37.439024390243887D, 131.63888888888891D),
			new NxtControl.Drawing.PointF(68.560975609756113D, 131.63888888888891D),
			new NxtControl.Drawing.PointF(75D, 115.48504273504264D),
			new NxtControl.Drawing.PointF(75D, 101.63888888888891D),
			new NxtControl.Drawing.PointF(31D, 101.63888888888891D),
			new NxtControl.Drawing.PointF(31D, 115.48504273504264D)});
			// 
			// unidade_Portecao_Termica1
			// 
			this.unidade_Portecao_Termica1.BeginInit();
			this.unidade_Portecao_Termica1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.714835634099462D, 0D, 0D, 0.73989041822826074D, 78.988451683911308D, 114.00000000000003D);
			this.unidade_Portecao_Termica1.Name = "unidade_Portecao_Termica1";
			this.unidade_Portecao_Termica1.EndInit();
			// 
			// group17
			// 
			this.group17.BeginInit();
			this.group17.Name = "group17";
			this.group17.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.label11,
			this.label12,
			this.rectangle21});
			this.group17.EndInit();
			// 
			// alarme_acionado1
			// 
			this.alarme_acionado1.BeginInit();
			this.alarme_acionado1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49184782608695654D, 0D, 0D, 0.49184782608695649D, 244D, 95.586956521739125D);
			this.alarme_acionado1.Name = "alarme_acionado1";
			this.alarme_acionado1.EndInit();
			// 
			// emergencia_acionada1
			// 
			this.emergencia_acionada1.BeginInit();
			this.emergencia_acionada1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4918478260869566D, 0D, 0D, 0.49184782608695654D, 244D, 96.586956521739125D);
			this.emergencia_acionada1.Name = "emergencia_acionada1";
			this.emergencia_acionada1.EndInit();
			// 
			// m3_3
			// 
			this.m3_3.Bounds = new NxtControl.Drawing.RectF(((float)(43.18310546875D)), ((float)(158.69015502929688D)), ((float)(1.8169014453887939D)), ((float)(10.690140724182129D)));
			this.m3_3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m3_3.Name = "m3_3";
			// 
			// m3_2
			// 
			this.m3_2.Bounds = new NxtControl.Drawing.RectF(((float)(39.76055908203125D)), ((float)(154.8450927734375D)), ((float)(3.4225351810455322D)), ((float)(19.380281448364258D)));
			this.m3_2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m3_2.Name = "m3_2";
			// 
			// m3_1
			// 
			this.m3_1.Bounds = new NxtControl.Drawing.RectF(((float)(1D)), ((float)(149D)), ((float)(38.760562896728516D)), ((float)(29.070423126220703D)));
			this.m3_1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m3_1.Name = "m3_1";
			// 
			// m1_3
			// 
			this.m1_3.Bounds = new NxtControl.Drawing.RectF(((float)(123D)), ((float)(213D)), ((float)(10.690140724182129D)), ((float)(1.8169014453887939D)));
			this.m1_3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m1_3.Name = "m1_3";
			// 
			// m1_2
			// 
			this.m1_2.Bounds = new NxtControl.Drawing.RectF(((float)(119D)), ((float)(210D)), ((float)(19.380281448364258D)), ((float)(3.4225351810455322D)));
			this.m1_2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m1_2.Name = "m1_2";
			// 
			// m1_1
			// 
			this.m1_1.Bounds = new NxtControl.Drawing.RectF(((float)(113D)), ((float)(171D)), ((float)(29.070423126220703D)), ((float)(38.760562896728516D)));
			this.m1_1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m1_1.Name = "m1_1";
			// 
			// m2_3
			// 
			this.m2_3.Bounds = new NxtControl.Drawing.RectF(((float)(213D)), ((float)(213D)), ((float)(10.690140724182129D)), ((float)(1.8169014453887939D)));
			this.m2_3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m2_3.Name = "m2_3";
			// 
			// m2_2
			// 
			this.m2_2.Bounds = new NxtControl.Drawing.RectF(((float)(209D)), ((float)(210D)), ((float)(19.380281448364258D)), ((float)(3.4225351810455322D)));
			this.m2_2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m2_2.Name = "m2_2";
			// 
			// m2_1
			// 
			this.m2_1.Bounds = new NxtControl.Drawing.RectF(((float)(203D)), ((float)(171D)), ((float)(29.070423126220703D)), ((float)(38.760562896728516D)));
			this.m2_1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m2_1.Name = "m2_1";
			// 
			// m4_3
			// 
			this.m4_3.Bounds = new NxtControl.Drawing.RectF(((float)(451.18310546875D)), ((float)(216.61972045898438D)), ((float)(1.8169014453887939D)), ((float)(10.690140724182129D)));
			this.m4_3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m4_3.Name = "m4_3";
			// 
			// m4_2
			// 
			this.m4_2.Bounds = new NxtControl.Drawing.RectF(((float)(447.76055908203125D)), ((float)(212.774658203125D)), ((float)(3.4225351810455322D)), ((float)(19.380281448364258D)));
			this.m4_2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m4_2.Name = "m4_2";
			// 
			// m4_1
			// 
			this.m4_1.Bounds = new NxtControl.Drawing.RectF(((float)(409D)), ((float)(206.9295654296875D)), ((float)(38.760562896728516D)), ((float)(29.070423126220703D)));
			this.m4_1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m4_1.Name = "m4_1";
			// 
			// m5_3
			// 
			this.m5_3.Bounds = new NxtControl.Drawing.RectF(((float)(451.18310546875D)), ((float)(280.69015502929688D)), ((float)(1.8169014453887939D)), ((float)(10.690140724182129D)));
			this.m5_3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m5_3.Name = "m5_3";
			// 
			// m5_2
			// 
			this.m5_2.Bounds = new NxtControl.Drawing.RectF(((float)(447.76055908203125D)), ((float)(276.8450927734375D)), ((float)(3.4225351810455322D)), ((float)(19.380281448364258D)));
			this.m5_2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m5_2.Name = "m5_2";
			// 
			// m5_1
			// 
			this.m5_1.Bounds = new NxtControl.Drawing.RectF(((float)(409D)), ((float)(271D)), ((float)(38.760562896728516D)), ((float)(29.070423126220703D)));
			this.m5_1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m5_1.Name = "m5_1";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))));
			this.freeText10.Location = new NxtControl.Drawing.PointF(13D, 28D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "ENTRADA DE \r\nPOLÍMERO";
			// 
			// line80
			// 
			this.line80.EndPoint = new NxtControl.Drawing.PointF(52D, 102D);
			this.line80.Name = "line80";
			this.line80.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line80.StartPoint = new NxtControl.Drawing.PointF(52D, 52D);
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(69D)), ((float)(8D)), ((float)(9D)));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(64D, 69D),
			new NxtControl.Drawing.PointF(60D, 78D),
			new NxtControl.Drawing.PointF(56D, 69D)});
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(76D)), ((float)(8D)), ((float)(8D)));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(64D, 76D),
			new NxtControl.Drawing.PointF(60D, 84D),
			new NxtControl.Drawing.PointF(56D, 76D)});
			// 
			// lslOn
			// 
			this.lslOn.BeginInit();
			this.lslOn.Name = "lslOn";
			this.lslOn.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.lineHSilo,
			this.bolinhaHSilo});
			this.lslOn.EndInit();
			// 
			// lslOff
			// 
			this.lslOff.BeginInit();
			this.lslOff.Name = "lslOff";
			this.lslOff.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.bolinhaLSilo,
			this.lineLSilo});
			this.lslOff.EndInit();
			// 
			// cmLsLLOff
			// 
			this.cmLsLLOff.BeginInit();
			this.cmLsLLOff.Name = "cmLsLLOff";
			this.cmLsLLOff.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse12,
			this.line79});
			this.cmLsLLOff.EndInit();
			// 
			// cmLsLLOn
			// 
			this.cmLsLLOn.BeginInit();
			this.cmLsLLOn.Name = "cmLsLLOn";
			this.cmLsLLOn.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line78,
			this.ellipse11});
			this.cmLsLLOn.EndInit();
			// 
			// cmLsLOff
			// 
			this.cmLsLOff.BeginInit();
			this.cmLsLOff.Name = "cmLsLOff";
			this.cmLsLOff.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse10,
			this.line77});
			this.cmLsLOff.EndInit();
			// 
			// cmLsLOn
			// 
			this.cmLsLOn.BeginInit();
			this.cmLsLOn.Name = "cmLsLOn";
			this.cmLsLOn.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line76,
			this.ellipse9});
			this.cmLsLOn.EndInit();
			// 
			// cmLsHOff
			// 
			this.cmLsHOff.BeginInit();
			this.cmLsHOff.Name = "cmLsHOff";
			this.cmLsHOff.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse8,
			this.line75});
			this.cmLsHOff.EndInit();
			// 
			// cmLsHOn
			// 
			this.cmLsHOn.BeginInit();
			this.cmLsHOn.Name = "cmLsHOn";
			this.cmLsHOn.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line74,
			this.ellipse7});
			this.cmLsHOn.EndInit();
			// 
			// cmLsHhOff
			// 
			this.cmLsHhOff.BeginInit();
			this.cmLsHhOff.Name = "cmLsHhOff";
			this.cmLsHhOff.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ellipse6,
			this.line73});
			this.cmLsHhOff.EndInit();
			// 
			// cmLsHhOn
			// 
			this.cmLsHhOn.BeginInit();
			this.cmLsHhOn.Name = "cmLsHhOn";
			this.cmLsHhOn.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line72,
			this.ellipse5});
			this.cmLsHhOn.EndInit();
			// 
			// helicoidal1
			// 
			this.helicoidal1.BeginInit();
			this.helicoidal1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.43749999999999994D, 0D, 0D, 0.43749999999999989D, 446D, 206.00000000000003D);
			this.helicoidal1.Name = "helicoidal1";
			this.helicoidal1.EndInit();
			// 
			// helicoidal2
			// 
			this.helicoidal2.BeginInit();
			this.helicoidal2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.43749999999999994D, 0D, 0D, 0.43749999999999989D, 446D, 270D);
			this.helicoidal2.Name = "helicoidal2";
			this.helicoidal2.EndInit();
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(156D, 254D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(134D, 260D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(156D, 272D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(134D, 266D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(156D, 272D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(156D, 254D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(100D, 254D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(122D, 260D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(100D, 272D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(122D, 266D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(101D, 272D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(101D, 254D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(100D, 291D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(122D, 297D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(100D, 309D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(122D, 303D);
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(101D, 309D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(101D, 291D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(156D, 291D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(134D, 297D);
			// 
			// line14
			// 
			this.line14.EndPoint = new NxtControl.Drawing.PointF(156D, 309D);
			this.line14.Name = "line14";
			this.line14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line14.StartPoint = new NxtControl.Drawing.PointF(134D, 303D);
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(156D, 309D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(156D, 291D);
			// 
			// lineHSilo
			// 
			this.lineHSilo.EndPoint = new NxtControl.Drawing.PointF(62.857521983507056D, 108.17628652402735D);
			this.lineHSilo.Name = "lineHSilo";
			this.lineHSilo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lineHSilo.StartPoint = new NxtControl.Drawing.PointF(75D, 116.30301690892196D);
			// 
			// bolinhaHSilo
			// 
			this.bolinhaHSilo.Bounds = new NxtControl.Drawing.RectF(((float)(56.390830993652344D)), ((float)(103.29412841796875D)), ((float)(7.3692278861999512D)), ((float)(7.3692278861999512D)));
			this.bolinhaHSilo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.bolinhaHSilo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bolinhaHSilo.Name = "bolinhaHSilo";
			// 
			// bolinhaLSilo
			// 
			this.bolinhaLSilo.Bounds = new NxtControl.Drawing.RectF(((float)(56.167526245117188D)), ((float)(123.03804016113281D)), ((float)(7.3692278861999512D)), ((float)(7.3692278861999512D)));
			this.bolinhaLSilo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.bolinhaLSilo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bolinhaLSilo.Name = "bolinhaLSilo";
			// 
			// lineLSilo
			// 
			this.lineLSilo.EndPoint = new NxtControl.Drawing.PointF(62.857521983507056D, 124.49104806180608D);
			this.lineLSilo.Name = "lineLSilo";
			this.lineLSilo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lineLSilo.StartPoint = new NxtControl.Drawing.PointF(75D, 116.36431767691147D);
			// 
			// line72
			// 
			this.line72.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 223.60399801145945D);
			this.line72.Name = "line72";
			this.line72.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line72.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 230.0046183822011D);
			// 
			// ellipse5
			// 
			this.ellipse5.Bounds = new NxtControl.Drawing.RectF(((float)(336.17587280273438D)), ((float)(219.75881958007813D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.ellipse5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse5.Name = "ellipse5";
			// 
			// ellipse6
			// 
			this.ellipse6.Bounds = new NxtControl.Drawing.RectF(((float)(336D)), ((float)(235.30914306640625D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.ellipse6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse6.Name = "ellipse6";
			// 
			// line73
			// 
			this.line73.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 236.45351929453216D);
			this.line73.Name = "line73";
			this.line73.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line73.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 230.05289892379074D);
			// 
			// line74
			// 
			this.line74.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 250.84519224175352D);
			this.line74.Name = "line74";
			this.line74.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line74.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 257.24581261249506D);
			// 
			// ellipse7
			// 
			this.ellipse7.Bounds = new NxtControl.Drawing.RectF(((float)(336.17587280273438D)), ((float)(247D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.ellipse7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse7.Name = "ellipse7";
			// 
			// ellipse8
			// 
			this.ellipse8.Bounds = new NxtControl.Drawing.RectF(((float)(336D)), ((float)(262.55032348632813D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.ellipse8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse8.Name = "ellipse8";
			// 
			// line75
			// 
			this.line75.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 263.69471352482623D);
			this.line75.Name = "line75";
			this.line75.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line75.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 257.29409315408469D);
			// 
			// line76
			// 
			this.line76.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 277.84519224175347D);
			this.line76.Name = "line76";
			this.line76.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line76.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 284.245812612495D);
			// 
			// ellipse9
			// 
			this.ellipse9.Bounds = new NxtControl.Drawing.RectF(((float)(336.17587280273438D)), ((float)(274D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.ellipse9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse9.Name = "ellipse9";
			// 
			// ellipse10
			// 
			this.ellipse10.Bounds = new NxtControl.Drawing.RectF(((float)(336D)), ((float)(289.55032348632813D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.ellipse10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse10.Name = "ellipse10";
			// 
			// line77
			// 
			this.line77.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 290.69471352482617D);
			this.line77.Name = "line77";
			this.line77.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line77.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 284.29409315408469D);
			// 
			// line78
			// 
			this.line78.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 304.6039947705068D);
			this.line78.Name = "line78";
			this.line78.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line78.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 311.00461514124834D);
			// 
			// ellipse11
			// 
			this.ellipse11.Bounds = new NxtControl.Drawing.RectF(((float)(336.17587280273438D)), ((float)(300.7587890625D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.ellipse11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse11.Name = "ellipse11";
			// 
			// ellipse12
			// 
			this.ellipse12.Bounds = new NxtControl.Drawing.RectF(((float)(336D)), ((float)(316.30911254882813D)), ((float)(5.80401086807251D)), ((float)(5.80401086807251D)));
			this.ellipse12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			this.ellipse12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse12.Name = "ellipse12";
			// 
			// line79
			// 
			this.line79.EndPoint = new NxtControl.Drawing.PointF(341.26904683375528D, 317.45351605357945D);
			this.line79.Name = "line79";
			this.line79.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line79.StartPoint = new NxtControl.Drawing.PointF(350.83247375488281D, 311.05289568283797D);
			// 
			// label11
			// 
			this.label11.AngleIgnore = true;
			this.label11.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label11.Bounds = new NxtControl.Drawing.RectF(((float)(496D)), ((float)(103D)), ((float)(90D)), ((float)(37D)));
			this.label11.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label11.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.label11.FontScale = true;
			this.label11.Name = "label11";
			this.label11.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label11.Text = "Alarme Falta\r\nde Água";
			this.label11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label11.TextAutoSizeHorizontalOffset = 10;
			this.label11.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label11.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// label12
			// 
			this.label12.AngleIgnore = true;
			this.label12.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label12.Bounds = new NxtControl.Drawing.RectF(((float)(496D)), ((float)(142D)), ((float)(86D)), ((float)(37D)));
			this.label12.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.label12.FontScale = true;
			this.label12.Name = "label12";
			this.label12.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label12.Text = "Alarme Vazão\r\nPolímero";
			this.label12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label12.TextAutoSizeHorizontalOffset = 10;
			this.label12.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label12.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// rectangle21
			// 
			this.rectangle21.Bounds = new NxtControl.Drawing.RectF(((float)(483D)), ((float)(95D)), ((float)(188D)), ((float)(93D)));
			this.rectangle21.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle21.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle21.Name = "rectangle21";
			// 
			// tFIT1
			// 
			this.tFIT1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tFIT1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tFIT1.Location = new NxtControl.Drawing.PointF(4D, 240D);
			this.tFIT1.Name = "tFIT1";
			this.tFIT1.Text = "";
			// 
			// tFIT2
			// 
			this.tFIT2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tFIT2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tFIT2.Location = new NxtControl.Drawing.PointF(636D, 232D);
			this.tFIT2.Name = "tFIT2";
			this.tFIT2.Text = "";
			// 
			// tAgua
			// 
			this.tAgua.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tAgua.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tAgua.Location = new NxtControl.Drawing.PointF(590D, 114D);
			this.tAgua.Name = "tAgua";
			this.tAgua.Text = "";
			// 
			// tVaz
			// 
			this.tVaz.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tVaz.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tVaz.Location = new NxtControl.Drawing.PointF(590D, 156D);
			this.tVaz.Name = "tVaz";
			this.tVaz.Text = "";
			// 
			// tDO1
			// 
			this.tDO1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tDO1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tDO1.Location = new NxtControl.Drawing.PointF(516D, 196D);
			this.tDO1.Name = "tDO1";
			this.tDO1.Text = "DO-01";
			// 
			// tDO2
			// 
			this.tDO2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tDO2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tDO2.Location = new NxtControl.Drawing.PointF(516D, 262D);
			this.tDO2.Name = "tDO2";
			this.tDO2.Text = "DO-02";
			// 
			// rodape
			// 
			this.rodape.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(392D)), ((float)(682D)), ((float)(78D)));
			this.rodape.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.rodape.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rodape.Name = "rodape";
			this.rodape.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(400D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 401D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(400D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 416D),
			new NxtControl.Drawing.PointF(28D, 400D),
			new NxtControl.Drawing.PointF(36D, 416D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 403D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 400D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 422D);
			this.e1.Name = "e1";
			this.e1.Text = "";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(20D, 442D);
			this.e2.Name = "e2";
			this.e2.Text = "";
			// 
			// btnCmd
			// 
			this.btnCmd.Bounds = new NxtControl.Drawing.RectF(((float)(502D)), ((float)(418D)), ((float)(160D)), ((float)(34D)));
			this.btnCmd.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnCmd.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnCmd.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnCmd.Name = "btnCmd";
			this.btnCmd.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnCmd.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnCmd.Radius = 2D;
			this.btnCmd.Text = "Comandos";
			this.btnCmd.Use3DEffect = false;
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
			// fpSkid
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(682D)), ((float)(470D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.line1,
			this.line2,
			this.line3,
			this.rectangle2,
			this.rectangle3,
			this.group1,
			this.group2,
			this.group3,
			this.group4,
			this.ellipse1,
			this.ellipse2,
			this.rectangle4,
			this.line16,
			this.line26,
			this.line27,
			this.line28,
			this.line29,
			this.freeText8,
			this.freeText1,
			this.line60,
			this.line61,
			this.line62,
			this.line63,
			this.polygon1,
			this.polygon2,
			this.freeText2,
			this.vs01_01,
			this.vs01_03,
			this.vs01_02,
			this.freeText3,
			this.rectangle19,
			this.rectangle20,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.freeText9,
			this.line64,
			this.line65,
			this.line66,
			this.line67,
			this.line68,
			this.line69,
			this.rectangle5,
			this.rectangle6,
			this.line17,
			this.line18,
			this.line19,
			this.line20,
			this.line21,
			this.line22,
			this.line23,
			this.line24,
			this.line25,
			this.rectangle7,
			this.polyline1,
			this.unidade_Portecao_Termica1,
			this.group17,
			this.alarme_acionado1,
			this.emergencia_acionada1,
			this.m3_3,
			this.m3_2,
			this.m3_1,
			this.m1_3,
			this.m1_2,
			this.m1_1,
			this.m2_3,
			this.m2_2,
			this.m2_1,
			this.m4_3,
			this.m4_2,
			this.m4_1,
			this.m5_3,
			this.m5_2,
			this.m5_1,
			this.freeText10,
			this.line80,
			this.polygon3,
			this.polygon4,
			this.lslOn,
			this.lslOff,
			this.cmLsLLOff,
			this.cmLsLLOn,
			this.cmLsLOff,
			this.cmLsLOn,
			this.cmLsHOff,
			this.cmLsHOn,
			this.cmLsHhOff,
			this.cmLsHhOn,
			this.helicoidal1,
			this.helicoidal2,
			this.tFIT1,
			this.tFIT2,
			this.tAgua,
			this.tVaz,
			this.tDO1,
			this.tDO2,
			this.rodape,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.e1,
			this.e2,
			this.btnCmd,
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
			this.xEVAZ});
			this.Size = new System.Drawing.Size(682, 470);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Group group3;
		private NxtControl.GuiFramework.Group group4;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Line line16;
		private NxtControl.GuiFramework.Line line26;
		private NxtControl.GuiFramework.Line line27;
		private NxtControl.GuiFramework.Line line28;
		private NxtControl.GuiFramework.Line line29;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Line line60;
		private NxtControl.GuiFramework.Line line61;
		private NxtControl.GuiFramework.Line line62;
		private NxtControl.GuiFramework.Line line63;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Polygon vs01_01;
		private NxtControl.GuiFramework.Polygon vs01_03;
		private NxtControl.GuiFramework.Ellipse vs01_02;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Rectangle rectangle19;
		private NxtControl.GuiFramework.Rectangle rectangle20;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.Line line64;
		private NxtControl.GuiFramework.Line line65;
		private NxtControl.GuiFramework.Line line66;
		private NxtControl.GuiFramework.Line line67;
		private NxtControl.GuiFramework.Line line68;
		private NxtControl.GuiFramework.Line line69;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Line line17;
		private NxtControl.GuiFramework.Line line18;
		private NxtControl.GuiFramework.Line line19;
		private NxtControl.GuiFramework.Line line20;
		private NxtControl.GuiFramework.Line line21;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.Line line23;
		private NxtControl.GuiFramework.Line line24;
		private NxtControl.GuiFramework.Line line25;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Polyline polyline1;
		private Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica unidade_Portecao_Termica1;
		private NxtControl.GuiFramework.Group group17;
		private Hidryco.HidrycoLib.Graphics.alarme_acionado alarme_acionado1;
		private Hidryco.HidrycoLib.Graphics.emergencia_acionada emergencia_acionada1;
		private NxtControl.GuiFramework.Rectangle m3_3;
		private NxtControl.GuiFramework.Rectangle m3_2;
		private NxtControl.GuiFramework.Rectangle m3_1;
		private NxtControl.GuiFramework.Rectangle m1_3;
		private NxtControl.GuiFramework.Rectangle m1_2;
		private NxtControl.GuiFramework.Rectangle m1_1;
		private NxtControl.GuiFramework.Rectangle m2_3;
		private NxtControl.GuiFramework.Rectangle m2_2;
		private NxtControl.GuiFramework.Rectangle m2_1;
		private NxtControl.GuiFramework.Rectangle m4_3;
		private NxtControl.GuiFramework.Rectangle m4_2;
		private NxtControl.GuiFramework.Rectangle m4_1;
		private NxtControl.GuiFramework.Rectangle m5_3;
		private NxtControl.GuiFramework.Rectangle m5_2;
		private NxtControl.GuiFramework.Rectangle m5_1;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.Line line80;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Group lslOn;
		private NxtControl.GuiFramework.Group lslOff;
		private NxtControl.GuiFramework.Group cmLsLLOff;
		private NxtControl.GuiFramework.Group cmLsLLOn;
		private NxtControl.GuiFramework.Group cmLsLOff;
		private NxtControl.GuiFramework.Group cmLsLOn;
		private NxtControl.GuiFramework.Group cmLsHOff;
		private NxtControl.GuiFramework.Group cmLsHOn;
		private NxtControl.GuiFramework.Group cmLsHhOff;
		private NxtControl.GuiFramework.Group cmLsHhOn;
		private Hidryco.HidrycoLib.Graphics.Helicoidal helicoidal1;
		private Hidryco.HidrycoLib.Graphics.Helicoidal helicoidal2;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.Line line14;
		private NxtControl.GuiFramework.Line line15;
		private NxtControl.GuiFramework.Line lineHSilo;
		private NxtControl.GuiFramework.Ellipse bolinhaHSilo;
		private NxtControl.GuiFramework.Ellipse bolinhaLSilo;
		private NxtControl.GuiFramework.Line lineLSilo;
		private NxtControl.GuiFramework.Line line72;
		private NxtControl.GuiFramework.Ellipse ellipse5;
		private NxtControl.GuiFramework.Ellipse ellipse6;
		private NxtControl.GuiFramework.Line line73;
		private NxtControl.GuiFramework.Line line74;
		private NxtControl.GuiFramework.Ellipse ellipse7;
		private NxtControl.GuiFramework.Ellipse ellipse8;
		private NxtControl.GuiFramework.Line line75;
		private NxtControl.GuiFramework.Line line76;
		private NxtControl.GuiFramework.Ellipse ellipse9;
		private NxtControl.GuiFramework.Ellipse ellipse10;
		private NxtControl.GuiFramework.Line line77;
		private NxtControl.GuiFramework.Line line78;
		private NxtControl.GuiFramework.Ellipse ellipse11;
		private NxtControl.GuiFramework.Ellipse ellipse12;
		private NxtControl.GuiFramework.Line line79;
		private NxtControl.GuiFramework.Label label11;
		private NxtControl.GuiFramework.Label label12;
		private NxtControl.GuiFramework.Rectangle rectangle21;
		private NxtControl.GuiFramework.FreeText tFIT1;
		private NxtControl.GuiFramework.FreeText tFIT2;
		private NxtControl.GuiFramework.FreeText tAgua;
		private NxtControl.GuiFramework.FreeText tVaz;
		private NxtControl.GuiFramework.FreeText tDO1;
		private NxtControl.GuiFramework.FreeText tDO2;
		private NxtControl.GuiFramework.Rectangle rodape;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText e1;
		private NxtControl.GuiFramework.FreeText e2;
		private NxtControl.GuiFramework.DrawnButton btnCmd;
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
		#endregion
	}
}
