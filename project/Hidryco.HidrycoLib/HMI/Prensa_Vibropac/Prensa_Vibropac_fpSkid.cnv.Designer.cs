/*
 * Hidryco - Prensa_Vibropac - fpSkid
 * Skid C-Press (fluxograma DE-35525-VCE-001): motores M01..M05, LT01, VS1, FS01, ZSAH01/02, alarme e emergencia.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Prensa_Vibropac
{
	/// <summary>
	/// Summary description for fpSkid.
	/// </summary>
	partial class fpSkid
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
			this.cpress_11 = new Hidryco.HidrycoLib.Graphics.Cpress_1();
			this.cpress_22 = new Hidryco.HidrycoLib.Graphics.Cpress_2();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.line10 = new NxtControl.GuiFramework.Line();
			this.line11 = new NxtControl.GuiFramework.Line();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.line12 = new NxtControl.GuiFramework.Line();
			this.line13 = new NxtControl.GuiFramework.Line();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.alarme_acionado1 = new Hidryco.HidrycoLib.Graphics.alarme_acionado();
			this.emergencia_acionada1 = new Hidryco.HidrycoLib.Graphics.emergencia_acionada();
			this.m04_03 = new NxtControl.GuiFramework.Polygon();
			this.m04_01 = new NxtControl.GuiFramework.Rectangle();
			this.m04_02 = new NxtControl.GuiFramework.Ellipse();
			this.m05_01 = new NxtControl.GuiFramework.Rectangle();
			this.m05_02 = new NxtControl.GuiFramework.Ellipse();
			this.m01_03 = new NxtControl.GuiFramework.Rectangle();
			this.m01_02 = new NxtControl.GuiFramework.Rectangle();
			this.m01_01 = new NxtControl.GuiFramework.Rectangle();
			this.m02_03 = new NxtControl.GuiFramework.Rectangle();
			this.m02_02 = new NxtControl.GuiFramework.Rectangle();
			this.m02_01 = new NxtControl.GuiFramework.Rectangle();
			this.m03_03 = new NxtControl.GuiFramework.Rectangle();
			this.m03_02 = new NxtControl.GuiFramework.Rectangle();
			this.m03_01 = new NxtControl.GuiFramework.Rectangle();
			this.vs01_01 = new NxtControl.GuiFramework.Polygon();
			this.vs01_03 = new NxtControl.GuiFramework.Polygon();
			this.vs01_02 = new NxtControl.GuiFramework.Ellipse();
			this.nivFundo = new NxtControl.GuiFramework.Rectangle();
			this.nivBarra = new NxtControl.GuiFramework.Rectangle();
			this.tNiv = new NxtControl.GuiFramework.FreeText();
			this.indFS1 = new NxtControl.GuiFramework.Ellipse();
			this.tFS1 = new NxtControl.GuiFramework.FreeText();
			this.indZS1 = new NxtControl.GuiFramework.Ellipse();
			this.tZS1 = new NxtControl.GuiFramework.FreeText();
			this.indZS2 = new NxtControl.GuiFramework.Ellipse();
			this.tZS2 = new NxtControl.GuiFramework.FreeText();
			this.tM2 = new NxtControl.GuiFramework.FreeText();
			this.tMot = new NxtControl.GuiFramework.FreeText();
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
			this.xNIV = new System.HMI.Symbols.Base.Execute<float>();
			this.xFUN = new System.HMI.Symbols.Base.Execute<bool>();
			this.xVS1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFS1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xZS1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xZS2 = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(720D)), ((float)(60D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 11D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 26D),
			new NxtControl.Drawing.PointF(28D, 10D),
			new NxtControl.Drawing.PointF(36D, 26D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 13D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 10D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 32D);
			this.e1.Name = "e1";
			this.e1.Text = "";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(300D, 32D);
			this.e2.Name = "e2";
			this.e2.Text = "";
			// 
			// cpress_11
			// 
			this.cpress_11.BeginInit();
			this.cpress_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 89D, 319D);
			this.cpress_11.Name = "cpress_11";
			this.cpress_11.EndInit();
			// 
			// cpress_22
			// 
			this.cpress_22.BeginInit();
			this.cpress_22.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1776649746192893D, 0D, 0D, 1.1776649746192893D, 258.00000000000006D, 239D);
			this.cpress_22.Name = "cpress_22";
			this.cpress_22.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(279D, 157D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(103D, 157D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(278D, 298D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(278D, 157D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(245D, 214D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "VS1";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(75D, 198D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "M04";
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(525D, 101D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(534D, 101D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(525D, 270D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(525D, 101D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(478D, 270D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(525D, 270D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(473D, 240D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(468D, 240D);
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(473D, 247D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(473D, 239D);
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(470D, 247D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(473D, 247D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(488D, 288D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(483D, 288D);
			// 
			// line10
			// 
			this.line10.EndPoint = new NxtControl.Drawing.PointF(488D, 295D);
			this.line10.Name = "line10";
			this.line10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line10.StartPoint = new NxtControl.Drawing.PointF(488D, 288D);
			// 
			// line11
			// 
			this.line11.EndPoint = new NxtControl.Drawing.PointF(485D, 295D);
			this.line11.Name = "line11";
			this.line11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line11.StartPoint = new NxtControl.Drawing.PointF(488D, 295D);
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(118D, 445D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "LT01";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(166D, 122D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "FS01";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(492D, 214D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "M02";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(511D, 307D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "M01";
			// 
			// line12
			// 
			this.line12.EndPoint = new NxtControl.Drawing.PointF(309D, 185D);
			this.line12.Name = "line12";
			this.line12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line12.StartPoint = new NxtControl.Drawing.PointF(309D, 287D);
			// 
			// line13
			// 
			this.line13.EndPoint = new NxtControl.Drawing.PointF(426D, 183D);
			this.line13.Name = "line13";
			this.line13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line13.StartPoint = new NxtControl.Drawing.PointF(426D, 252D);
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText7.Location = new NxtControl.Drawing.PointF(289D, 147D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "ZSAH01";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText8.Location = new NxtControl.Drawing.PointF(407D, 147D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "ZSAH02";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText9.Location = new NxtControl.Drawing.PointF(122D, 260D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "M03";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.freeText10.Location = new NxtControl.Drawing.PointF(558D, 82D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "M05";
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(179D)), ((float)(287D)), ((float)(81D)), ((float)(47D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(179D, 334D),
			new NxtControl.Drawing.PointF(198D, 334D),
			new NxtControl.Drawing.PointF(198D, 287D),
			new NxtControl.Drawing.PointF(260D, 287D)});
			// 
			// alarme_acionado1
			// 
			this.alarme_acionado1.BeginInit();
			this.alarme_acionado1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49184782608695654D, 0D, 0D, 0.49184782608695649D, 293D, 385.58695652173913D);
			this.alarme_acionado1.Name = "alarme_acionado1";
			this.alarme_acionado1.EndInit();
			// 
			// emergencia_acionada1
			// 
			this.emergencia_acionada1.BeginInit();
			this.emergencia_acionada1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4918478260869566D, 0D, 0D, 0.49184782608695654D, 294D, 385.58695652173913D);
			this.emergencia_acionada1.Name = "emergencia_acionada1";
			this.emergencia_acionada1.EndInit();
			// 
			// m04_03
			// 
			this.m04_03.Bounds = new NxtControl.Drawing.RectF(((float)(54.000001525878929D)), ((float)(186.32941207885744D)), ((float)(42.6666667938232D)), ((float)(10.870587921142544D)));
			this.m04_03.Closed = true;
			this.m04_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.m04_03.Name = "m04_03";
			this.m04_03.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(64.666668224334671D, 187.68823556900026D),
			new NxtControl.Drawing.PointF(54.000001525878929D, 197.2D),
			new NxtControl.Drawing.PointF(96.666668319702126D, 197.2D),
			new NxtControl.Drawing.PointF(86.00000162124627D, 186.32941207885744D)});
			// 
			// m04_01
			// 
			this.m04_01.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(152.35882568359375D)), ((float)(32D)), ((float)(10.870588302612305D)));
			this.m04_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.m04_01.Name = "m04_01";
			// 
			// m04_02
			// 
			this.m04_02.Bounds = new NxtControl.Drawing.RectF(((float)(54D)), ((float)(151D)), ((float)(42.666667938232422D)), ((float)(43.482353210449219D)));
			this.m04_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.m04_02.Name = "m04_02";
			// 
			// m05_01
			// 
			this.m05_01.Bounds = new NxtControl.Drawing.RectF(((float)(534D)), ((float)(96.35882568359375D)), ((float)(32D)), ((float)(10.870588302612305D)));
			this.m05_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.m05_01.Name = "m05_01";
			// 
			// m05_02
			// 
			this.m05_02.Bounds = new NxtControl.Drawing.RectF(((float)(542D)), ((float)(95D)), ((float)(42.666667938232422D)), ((float)(43.482353210449219D)));
			this.m05_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.m05_02.Name = "m05_02";
			// 
			// m01_03
			// 
			this.m01_03.Bounds = new NxtControl.Drawing.RectF(((float)(488.18310546875D)), ((float)(285.61972045898438D)), ((float)(1.8169014453887939D)), ((float)(10.690140724182129D)));
			this.m01_03.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m01_03.Name = "m01_03";
			// 
			// m01_02
			// 
			this.m01_02.Bounds = new NxtControl.Drawing.RectF(((float)(489.76055908203125D)), ((float)(281.774658203125D)), ((float)(3.4225351810455322D)), ((float)(19.380281448364258D)));
			this.m01_02.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m01_02.Name = "m01_02";
			// 
			// m01_01
			// 
			this.m01_01.Bounds = new NxtControl.Drawing.RectF(((float)(493D)), ((float)(275.9295654296875D)), ((float)(38.760562896728516D)), ((float)(29.070423126220703D)));
			this.m01_01.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m01_01.Name = "m01_01";
			// 
			// m02_03
			// 
			this.m02_03.Bounds = new NxtControl.Drawing.RectF(((float)(473D)), ((float)(237.69015502929688D)), ((float)(1.8169014453887939D)), ((float)(10.690140724182129D)));
			this.m02_03.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m02_03.Name = "m02_03";
			// 
			// m02_02
			// 
			this.m02_02.Bounds = new NxtControl.Drawing.RectF(((float)(474.57745361328125D)), ((float)(233.8450927734375D)), ((float)(3.4225351810455322D)), ((float)(19.380281448364258D)));
			this.m02_02.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m02_02.Name = "m02_02";
			// 
			// m02_01
			// 
			this.m02_01.Bounds = new NxtControl.Drawing.RectF(((float)(477.81689453125D)), ((float)(228D)), ((float)(38.760562896728516D)), ((float)(29.070423126220703D)));
			this.m02_01.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m02_01.Name = "m02_01";
			// 
			// m03_03
			// 
			this.m03_03.Bounds = new NxtControl.Drawing.RectF(((float)(124D)), ((float)(317D)), ((float)(10.690140724182129D)), ((float)(1.8169014453887939D)));
			this.m03_03.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m03_03.Name = "m03_03";
			// 
			// m03_02
			// 
			this.m03_02.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(314D)), ((float)(19.380281448364258D)), ((float)(3.4225351810455322D)));
			this.m03_02.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m03_02.Name = "m03_02";
			// 
			// m03_01
			// 
			this.m03_01.Bounds = new NxtControl.Drawing.RectF(((float)(114D)), ((float)(275D)), ((float)(29.070423126220703D)), ((float)(38.760562896728516D)));
			this.m03_01.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m03_01.Name = "m03_01";
			// 
			// vs01_01
			// 
			this.vs01_01.Bounds = new NxtControl.Drawing.RectF(((float)(271.5D)), ((float)(207D)), ((float)(14.5D)), ((float)(14.5D)));
			this.vs01_01.Closed = true;
			this.vs01_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vs01_01.Name = "vs01_01";
			this.vs01_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(286D, 207D),
			new NxtControl.Drawing.PointF(271.5D, 207D),
			new NxtControl.Drawing.PointF(278.75D, 221.5D)});
			// 
			// vs01_03
			// 
			this.vs01_03.Bounds = new NxtControl.Drawing.RectF(((float)(271.5D)), ((float)(220.5D)), ((float)(14.5D)), ((float)(14.5D)));
			this.vs01_03.Closed = true;
			this.vs01_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vs01_03.Name = "vs01_03";
			this.vs01_03.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(286D, 235D),
			new NxtControl.Drawing.PointF(271.5D, 235D),
			new NxtControl.Drawing.PointF(278.75D, 220.5D)});
			// 
			// vs01_02
			// 
			this.vs01_02.Bounds = new NxtControl.Drawing.RectF(((float)(273.3125D)), ((float)(215.66667175292969D)), ((float)(10.875D)), ((float)(10.875D)));
			this.vs01_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vs01_02.Name = "vs01_02";
			// 
			// nivFundo
			// 
			this.nivFundo.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(318D)), ((float)(14D)), ((float)(112D)));
			this.nivFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.nivFundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nivFundo.Name = "nivFundo";
			this.nivFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(128)), ((byte)(128))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nivBarra
			// 
			this.nivBarra.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(430D)), ((float)(14D)), ((float)(0D)));
			this.nivBarra.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(166)), ((byte)(186)), ((byte)(214))));
			this.nivBarra.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nivBarra.Name = "nivBarra";
			this.nivBarra.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tNiv
			// 
			this.tNiv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tNiv.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tNiv.Location = new NxtControl.Drawing.PointF(150D, 445D);
			this.tNiv.Name = "tNiv";
			this.tNiv.Text = "";
			// 
			// indFS1
			// 
			this.indFS1.Bounds = new NxtControl.Drawing.RectF(((float)(166D)), ((float)(137D)), ((float)(12D)), ((float)(12D)));
			this.indFS1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.indFS1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.indFS1.Name = "indFS1";
			this.indFS1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tFS1
			// 
			this.tFS1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tFS1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tFS1.Location = new NxtControl.Drawing.PointF(182D, 136D);
			this.tFS1.Name = "tFS1";
			this.tFS1.Text = "";
			// 
			// indZS1
			// 
			this.indZS1.Bounds = new NxtControl.Drawing.RectF(((float)(292D)), ((float)(160D)), ((float)(12D)), ((float)(12D)));
			this.indZS1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.indZS1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.indZS1.Name = "indZS1";
			this.indZS1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tZS1
			// 
			this.tZS1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tZS1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tZS1.Location = new NxtControl.Drawing.PointF(317D, 160D);
			this.tZS1.Name = "tZS1";
			this.tZS1.Text = "";
			// 
			// indZS2
			// 
			this.indZS2.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(160D)), ((float)(12D)), ((float)(12D)));
			this.indZS2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.indZS2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.indZS2.Name = "indZS2";
			this.indZS2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tZS2
			// 
			this.tZS2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tZS2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tZS2.Location = new NxtControl.Drawing.PointF(435D, 160D);
			this.tZS2.Name = "tZS2";
			this.tZS2.Text = "";
			// 
			// tM2
			// 
			this.tM2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tM2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tM2.Location = new NxtControl.Drawing.PointF(427D, 206D);
			this.tM2.Name = "tM2";
			this.tM2.Text = "";
			// 
			// tMot
			// 
			this.tMot.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tMot.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tMot.Location = new NxtControl.Drawing.PointF(20D, 470D);
			this.tMot.Name = "tMot";
			this.tMot.Text = "";
			// 
			// btnCmd
			// 
			this.btnCmd.Bounds = new NxtControl.Drawing.RectF(((float)(540D)), ((float)(506D)), ((float)(160D)), ((float)(34D)));
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
			// xNIV
			// 
			this.xNIV.BeginInit();
			this.xNIV.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNIV.IsOnlyInput = true;
			this.xNIV.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNIV.Name = "xNIV";
			this.xNIV.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNIV.TagName = "STS_NIVEL_FLOCULADOR";
			this.xNIV.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNIVValueChanged);
			this.xNIV.EndInit();
			// 
			// xFUN
			// 
			this.xFUN.BeginInit();
			this.xFUN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFUN.IsOnlyInput = true;
			this.xFUN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFUN.Name = "xFUN";
			this.xFUN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFUN.TagName = "STS_FUNCIONANDO";
			this.xFUN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFUNValueChanged);
			this.xFUN.EndInit();
			// 
			// xVS1
			// 
			this.xVS1.BeginInit();
			this.xVS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVS1.IsOnlyInput = true;
			this.xVS1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVS1.Name = "xVS1";
			this.xVS1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVS1.TagName = "STS_VS1_ABERTA";
			this.xVS1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVS1ValueChanged);
			this.xVS1.EndInit();
			// 
			// xFS1
			// 
			this.xFS1.BeginInit();
			this.xFS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFS1.IsOnlyInput = true;
			this.xFS1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFS1.Name = "xFS1";
			this.xFS1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFS1.TagName = "STS_FS1_FLUXO";
			this.xFS1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFS1ValueChanged);
			this.xFS1.EndInit();
			// 
			// xZS1
			// 
			this.xZS1.BeginInit();
			this.xZS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xZS1.IsOnlyInput = true;
			this.xZS1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xZS1.Name = "xZS1";
			this.xZS1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xZS1.TagName = "STS_ZSAH1";
			this.xZS1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XZS1ValueChanged);
			this.xZS1.EndInit();
			// 
			// xZS2
			// 
			this.xZS2.BeginInit();
			this.xZS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xZS2.IsOnlyInput = true;
			this.xZS2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xZS2.Name = "xZS2";
			this.xZS2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xZS2.TagName = "STS_ZSAH2";
			this.xZS2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XZS2ValueChanged);
			this.xZS2.EndInit();
			// 
			// fpSkid
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(720D)), ((float)(560D)));
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
			this.cpress_11,
			this.cpress_22,
			this.line1,
			this.line2,
			this.freeText1,
			this.freeText2,
			this.line3,
			this.line4,
			this.line5,
			this.line6,
			this.line7,
			this.line8,
			this.line9,
			this.line10,
			this.line11,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.line12,
			this.line13,
			this.freeText7,
			this.freeText8,
			this.freeText9,
			this.freeText10,
			this.polyline1,
			this.alarme_acionado1,
			this.emergencia_acionada1,
			this.m04_03,
			this.m04_01,
			this.m04_02,
			this.m05_01,
			this.m05_02,
			this.m01_03,
			this.m01_02,
			this.m01_01,
			this.m02_03,
			this.m02_02,
			this.m02_01,
			this.m03_03,
			this.m03_02,
			this.m03_01,
			this.vs01_01,
			this.vs01_03,
			this.vs01_02,
			this.nivFundo,
			this.nivBarra,
			this.tNiv,
			this.indFS1,
			this.tFS1,
			this.indZS1,
			this.tZS1,
			this.indZS2,
			this.tZS2,
			this.tM2,
			this.tMot,
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
			this.xNIV,
			this.xFUN,
			this.xVS1,
			this.xFS1,
			this.xZS1,
			this.xZS2});
			this.Size = new System.Drawing.Size(720, 560);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText e1;
		private NxtControl.GuiFramework.FreeText e2;
		private Hidryco.HidrycoLib.Graphics.Cpress_1 cpress_11;
		private Hidryco.HidrycoLib.Graphics.Cpress_2 cpress_22;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private NxtControl.GuiFramework.Line line10;
		private NxtControl.GuiFramework.Line line11;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.Line line12;
		private NxtControl.GuiFramework.Line line13;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.Polyline polyline1;
		private Hidryco.HidrycoLib.Graphics.alarme_acionado alarme_acionado1;
		private Hidryco.HidrycoLib.Graphics.emergencia_acionada emergencia_acionada1;
		private NxtControl.GuiFramework.Polygon m04_03;
		private NxtControl.GuiFramework.Rectangle m04_01;
		private NxtControl.GuiFramework.Ellipse m04_02;
		private NxtControl.GuiFramework.Rectangle m05_01;
		private NxtControl.GuiFramework.Ellipse m05_02;
		private NxtControl.GuiFramework.Rectangle m01_03;
		private NxtControl.GuiFramework.Rectangle m01_02;
		private NxtControl.GuiFramework.Rectangle m01_01;
		private NxtControl.GuiFramework.Rectangle m02_03;
		private NxtControl.GuiFramework.Rectangle m02_02;
		private NxtControl.GuiFramework.Rectangle m02_01;
		private NxtControl.GuiFramework.Rectangle m03_03;
		private NxtControl.GuiFramework.Rectangle m03_02;
		private NxtControl.GuiFramework.Rectangle m03_01;
		private NxtControl.GuiFramework.Polygon vs01_01;
		private NxtControl.GuiFramework.Polygon vs01_03;
		private NxtControl.GuiFramework.Ellipse vs01_02;
		private NxtControl.GuiFramework.Rectangle nivFundo;
		private NxtControl.GuiFramework.Rectangle nivBarra;
		private NxtControl.GuiFramework.FreeText tNiv;
		private NxtControl.GuiFramework.Ellipse indFS1;
		private NxtControl.GuiFramework.FreeText tFS1;
		private NxtControl.GuiFramework.Ellipse indZS1;
		private NxtControl.GuiFramework.FreeText tZS1;
		private NxtControl.GuiFramework.Ellipse indZS2;
		private NxtControl.GuiFramework.FreeText tZS2;
		private NxtControl.GuiFramework.FreeText tM2;
		private NxtControl.GuiFramework.FreeText tMot;
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
		private System.HMI.Symbols.Base.Execute<float> xNIV;
		private System.HMI.Symbols.Base.Execute<bool> xFUN;
		private System.HMI.Symbols.Base.Execute<bool> xVS1;
		private System.HMI.Symbols.Base.Execute<bool> xFS1;
		private System.HMI.Symbols.Base.Execute<bool> xZS1;
		private System.HMI.Symbols.Base.Execute<bool> xZS2;
		#endregion
	}
}
