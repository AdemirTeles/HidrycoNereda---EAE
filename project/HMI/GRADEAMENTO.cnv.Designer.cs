/*
 * Hidryco - tela GRADEAMENTO (fase solida - serie 900)
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs; arranjo do P&ID HID-PE-DE-ETE-FLX-002.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for GRADEAMENTO.
	/// </summary>
	partial class GRADEAMENTO
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnResetGeral = new NxtControl.GuiFramework.DrawnButton();
			this.btnReconhecerGeral = new NxtControl.GuiFramework.DrawnButton();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.cardProcesso = new NxtControl.GuiFramework.Rectangle();
			this.canal2 = new NxtControl.GuiFramework.Rectangle();
			this.mur2a = new NxtControl.GuiFramework.Rectangle();
			this.mur2b = new NxtControl.GuiFramework.Rectangle();
			this.gr1 = new NxtControl.GuiFramework.FreeText();
			this.canal1 = new NxtControl.GuiFramework.Rectangle();
			this.mur1a = new NxtControl.GuiFramework.Rectangle();
			this.mur1b = new NxtControl.GuiFramework.Rectangle();
			this.gr2 = new NxtControl.GuiFramework.FreeText();
			this.chegada = new NxtControl.GuiFramework.Rectangle();
			this.murCh = new NxtControl.GuiFramework.Rectangle();
			this.murMeio = new NxtControl.GuiFramework.Rectangle();
			this.gt3 = new NxtControl.GuiFramework.Rectangle();
			this.gt4 = new NxtControl.GuiFramework.Rectangle();
			this.gt5 = new NxtControl.GuiFramework.Rectangle();
			this.gs6 = new NxtControl.GuiFramework.Polygon();
			this.gr7 = new NxtControl.GuiFramework.FreeText();
			this.saida = new NxtControl.GuiFramework.Rectangle();
			this.murSai = new NxtControl.GuiFramework.Rectangle();
			this.murMeioS = new NxtControl.GuiFramework.Rectangle();
			this.gt8 = new NxtControl.GuiFramework.Rectangle();
			this.gs9 = new NxtControl.GuiFramework.Polygon();
			this.irEEE = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.gr10 = new NxtControl.GuiFramework.FreeText();
			this.gr11 = new NxtControl.GuiFramework.FreeText();
			this.gr12 = new NxtControl.GuiFramework.FreeText();
			this.gr13 = new NxtControl.GuiFramework.FreeText();
			this.gr14 = new NxtControl.GuiFramework.FreeText();
			this.gr15 = new NxtControl.GuiFramework.FreeText();
			this.gr16 = new NxtControl.GuiFramework.FreeText();
			this.gr17 = new NxtControl.GuiFramework.FreeText();
			this.gr18 = new NxtControl.GuiFramework.FreeText();
			this.gr19 = new NxtControl.GuiFramework.FreeText();
			this.gr20 = new NxtControl.GuiFramework.FreeText();
			this.gr21 = new NxtControl.GuiFramework.FreeText();
			this.roscaCalha = new NxtControl.GuiFramework.Rectangle();
			this.roscaH0 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH1 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH2 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH3 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH4 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH5 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH6 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH7 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH8 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH9 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH10 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH11 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH12 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH13 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH14 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH15 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH16 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH17 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH18 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH19 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH20 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH21 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH22 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH23 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH24 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH25 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH26 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH27 = new NxtControl.GuiFramework.Rectangle();
			this.roscaH28 = new NxtControl.GuiFramework.Rectangle();
			this.gr22 = new NxtControl.GuiFramework.FreeText();
			this.cac1 = new NxtControl.GuiFramework.Polygon();
			this.cac2 = new NxtControl.GuiFramework.Polygon();
			this.gr23 = new NxtControl.GuiFramework.FreeText();
			this.gr24 = new NxtControl.GuiFramework.FreeText();
			this.gr25 = new NxtControl.GuiFramework.FreeText();
			this.gr26 = new NxtControl.GuiFramework.FreeText();
			this.co_100_03 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta();
			this.co_100_04 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta();
			this.grade2 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.mont2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.jus2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.dif2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.co_100_01 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta();
			this.co_100_02 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta();
			this.grade1 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.mont1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.jus1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.dif1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.rosca = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca();
			this.processo = new Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.sDefault();
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
			// canal2
			// 
			this.canal2.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(170D)), ((float)(780D)), ((float)(120D)));
			this.canal2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(220)), ((byte)(236))));
			this.canal2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.canal2.Name = "canal2";
			this.canal2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// mur2a
			// 
			this.mur2a.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(164D)), ((float)(780D)), ((float)(6D)));
			this.mur2a.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.mur2a.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mur2a.Name = "mur2a";
			this.mur2a.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// mur2b
			// 
			this.mur2b.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(290D)), ((float)(780D)), ((float)(6D)));
			this.mur2b.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.mur2b.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mur2b.Name = "mur2b";
			this.mur2b.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gr1
			// 
			this.gr1.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.gr1.Location = new NxtControl.Drawing.PointF(330D, 272D);
			this.gr1.Name = "gr1";
			this.gr1.Text = "CANAL 2";
			// 
			// canal1
			// 
			this.canal1.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(400D)), ((float)(780D)), ((float)(120D)));
			this.canal1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(220)), ((byte)(236))));
			this.canal1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.canal1.Name = "canal1";
			this.canal1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// mur1a
			// 
			this.mur1a.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(394D)), ((float)(780D)), ((float)(6D)));
			this.mur1a.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.mur1a.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mur1a.Name = "mur1a";
			this.mur1a.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// mur1b
			// 
			this.mur1b.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(520D)), ((float)(780D)), ((float)(6D)));
			this.mur1b.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.mur1b.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mur1b.Name = "mur1b";
			this.mur1b.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gr2
			// 
			this.gr2.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.gr2.Location = new NxtControl.Drawing.PointF(330D, 502D);
			this.gr2.Name = "gr2";
			this.gr2.Text = "CANAL 1";
			// 
			// chegada
			// 
			this.chegada.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(164D)), ((float)(80D)), ((float)(362D)));
			this.chegada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(220)), ((byte)(236))));
			this.chegada.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.chegada.Name = "chegada";
			this.chegada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// murCh
			// 
			this.murCh.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(164D)), ((float)(6D)), ((float)(362D)));
			this.murCh.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.murCh.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.murCh.Name = "murCh";
			this.murCh.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// murMeio
			// 
			this.murMeio.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(290D)), ((float)(80D)), ((float)(110D)));
			this.murMeio.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(242)), ((byte)(242)), ((byte)(242))));
			this.murMeio.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.murMeio.Name = "murMeio";
			this.murMeio.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gt3
			// 
			this.gt3.Bounds = new NxtControl.Drawing.RectF(((float)(36D)), ((float)(596D)), ((float)(118D)), ((float)(8D)));
			this.gt3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.gt3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.gt3.Name = "gt3";
			this.gt3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gt4
			// 
			this.gt4.Bounds = new NxtControl.Drawing.RectF(((float)(106D)), ((float)(341D)), ((float)(8D)), ((float)(263D)));
			this.gt4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.gt4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.gt4.Name = "gt4";
			this.gt4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gt5
			// 
			this.gt5.Bounds = new NxtControl.Drawing.RectF(((float)(106D)), ((float)(341D)), ((float)(48D)), ((float)(8D)));
			this.gt5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.gt5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.gt5.Name = "gt5";
			this.gt5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gs6
			// 
			this.gs6.Bounds = new NxtControl.Drawing.RectF(((float)(133D)), ((float)(338D)), ((float)(14D)), ((float)(14D)));
			this.gs6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.gs6.Closed = true;
			this.gs6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.gs6.Name = "gs6";
			this.gs6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.gs6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(133D, 338D),
			new NxtControl.Drawing.PointF(147D, 345D),
			new NxtControl.Drawing.PointF(133D, 352D)});
			// 
			// gr7
			// 
			this.gr7.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.gr7.Location = new NxtControl.Drawing.PointF(30D, 610D);
			this.gr7.Name = "gr7";
			this.gr7.Text = "Esgoto bruto (chegada)";
			// 
			// saida
			// 
			this.saida.Bounds = new NxtControl.Drawing.RectF(((float)(1010D)), ((float)(164D)), ((float)(70D)), ((float)(362D)));
			this.saida.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(220)), ((byte)(236))));
			this.saida.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.saida.Name = "saida";
			this.saida.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// murSai
			// 
			this.murSai.Bounds = new NxtControl.Drawing.RectF(((float)(1080D)), ((float)(164D)), ((float)(6D)), ((float)(362D)));
			this.murSai.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.murSai.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.murSai.Name = "murSai";
			this.murSai.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// murMeioS
			// 
			this.murMeioS.Bounds = new NxtControl.Drawing.RectF(((float)(1010D)), ((float)(290D)), ((float)(70D)), ((float)(110D)));
			this.murMeioS.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(242)), ((byte)(242)), ((byte)(242))));
			this.murMeioS.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.murMeioS.Name = "murMeioS";
			this.murMeioS.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gt8
			// 
			this.gt8.Bounds = new NxtControl.Drawing.RectF(((float)(1082D)), ((float)(341D)), ((float)(72D)), ((float)(8D)));
			this.gt8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.gt8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.gt8.Name = "gt8";
			this.gt8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gs9
			// 
			this.gs9.Bounds = new NxtControl.Drawing.RectF(((float)(1149D)), ((float)(338D)), ((float)(14D)), ((float)(14D)));
			this.gs9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.gs9.Closed = true;
			this.gs9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.gs9.Name = "gs9";
			this.gs9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.gs9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1149D, 338D),
			new NxtControl.Drawing.PointF(1163D, 345D),
			new NxtControl.Drawing.PointF(1149D, 352D)});
			// 
			// irEEE
			// 
			this.irEEE.Bounds = new NxtControl.Drawing.RectF(((float)(1170D)), ((float)(330D)), ((float)(170D)), ((float)(30D)));
			this.irEEE.CanvasName = "EEE_BRUTO";
			this.irEEE.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irEEE.Name = "irEEE";
			this.irEEE.Text = "Poço da EEE ›";
			// 
			// gr10
			// 
			this.gr10.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr10.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.gr10.Location = new NxtControl.Drawing.PointF(278D, 300D);
			this.gr10.Name = "gr10";
			this.gr10.Text = "CO-03";
			// 
			// gr11
			// 
			this.gr11.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr11.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.gr11.Location = new NxtControl.Drawing.PointF(918D, 300D);
			this.gr11.Name = "gr11";
			this.gr11.Text = "CO-04";
			// 
			// gr12
			// 
			this.gr12.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.gr12.Location = new NxtControl.Drawing.PointF(522D, 300D);
			this.gr12.Name = "gr12";
			this.gr12.Text = "GM-02";
			// 
			// gr13
			// 
			this.gr13.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr13.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr13.Location = new NxtControl.Drawing.PointF(380D, 182D);
			this.gr13.Name = "gr13";
			this.gr13.Text = "montante (LSH3)";
			// 
			// gr14
			// 
			this.gr14.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr14.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr14.Location = new NxtControl.Drawing.PointF(690D, 182D);
			this.gr14.Name = "gr14";
			this.gr14.Text = "jusante (LSH4)";
			// 
			// gr15
			// 
			this.gr15.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr15.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr15.Location = new NxtControl.Drawing.PointF(690D, 242D);
			this.gr15.Name = "gr15";
			this.gr15.Text = "diferencial";
			// 
			// gr16
			// 
			this.gr16.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr16.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.gr16.Location = new NxtControl.Drawing.PointF(278D, 530D);
			this.gr16.Name = "gr16";
			this.gr16.Text = "CO-01";
			// 
			// gr17
			// 
			this.gr17.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr17.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.gr17.Location = new NxtControl.Drawing.PointF(918D, 530D);
			this.gr17.Name = "gr17";
			this.gr17.Text = "CO-02";
			// 
			// gr18
			// 
			this.gr18.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr18.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.gr18.Location = new NxtControl.Drawing.PointF(522D, 530D);
			this.gr18.Name = "gr18";
			this.gr18.Text = "GM-01";
			// 
			// gr19
			// 
			this.gr19.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr19.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr19.Location = new NxtControl.Drawing.PointF(380D, 412D);
			this.gr19.Name = "gr19";
			this.gr19.Text = "montante (LSH1)";
			// 
			// gr20
			// 
			this.gr20.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr20.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr20.Location = new NxtControl.Drawing.PointF(690D, 412D);
			this.gr20.Name = "gr20";
			this.gr20.Text = "jusante (LSH2)";
			// 
			// gr21
			// 
			this.gr21.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr21.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr21.Location = new NxtControl.Drawing.PointF(690D, 472D);
			this.gr21.Name = "gr21";
			this.gr21.Text = "diferencial";
			// 
			// roscaCalha
			// 
			this.roscaCalha.Bounds = new NxtControl.Drawing.RectF(((float)(628D)), ((float)(140D)), ((float)(22D)), ((float)(446D)));
			this.roscaCalha.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.roscaCalha.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaCalha.Name = "roscaCalha";
			this.roscaCalha.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH0
			// 
			this.roscaH0.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(146D)), ((float)(18D)), ((float)(2D)));
			this.roscaH0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH0.Name = "roscaH0";
			this.roscaH0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH1
			// 
			this.roscaH1.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(161D)), ((float)(18D)), ((float)(2D)));
			this.roscaH1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH1.Name = "roscaH1";
			this.roscaH1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH2
			// 
			this.roscaH2.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(176D)), ((float)(18D)), ((float)(2D)));
			this.roscaH2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH2.Name = "roscaH2";
			this.roscaH2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH3
			// 
			this.roscaH3.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(191D)), ((float)(18D)), ((float)(2D)));
			this.roscaH3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH3.Name = "roscaH3";
			this.roscaH3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH4
			// 
			this.roscaH4.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(206D)), ((float)(18D)), ((float)(2D)));
			this.roscaH4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH4.Name = "roscaH4";
			this.roscaH4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH5
			// 
			this.roscaH5.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(221D)), ((float)(18D)), ((float)(2D)));
			this.roscaH5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH5.Name = "roscaH5";
			this.roscaH5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH6
			// 
			this.roscaH6.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(236D)), ((float)(18D)), ((float)(2D)));
			this.roscaH6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH6.Name = "roscaH6";
			this.roscaH6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH7
			// 
			this.roscaH7.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(251D)), ((float)(18D)), ((float)(2D)));
			this.roscaH7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH7.Name = "roscaH7";
			this.roscaH7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH8
			// 
			this.roscaH8.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(266D)), ((float)(18D)), ((float)(2D)));
			this.roscaH8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH8.Name = "roscaH8";
			this.roscaH8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH9
			// 
			this.roscaH9.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(281D)), ((float)(18D)), ((float)(2D)));
			this.roscaH9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH9.Name = "roscaH9";
			this.roscaH9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH10
			// 
			this.roscaH10.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(296D)), ((float)(18D)), ((float)(2D)));
			this.roscaH10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH10.Name = "roscaH10";
			this.roscaH10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH11
			// 
			this.roscaH11.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(311D)), ((float)(18D)), ((float)(2D)));
			this.roscaH11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH11.Name = "roscaH11";
			this.roscaH11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH12
			// 
			this.roscaH12.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(326D)), ((float)(18D)), ((float)(2D)));
			this.roscaH12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH12.Name = "roscaH12";
			this.roscaH12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH13
			// 
			this.roscaH13.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(341D)), ((float)(18D)), ((float)(2D)));
			this.roscaH13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH13.Name = "roscaH13";
			this.roscaH13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH14
			// 
			this.roscaH14.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(356D)), ((float)(18D)), ((float)(2D)));
			this.roscaH14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH14.Name = "roscaH14";
			this.roscaH14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH15
			// 
			this.roscaH15.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(371D)), ((float)(18D)), ((float)(2D)));
			this.roscaH15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH15.Name = "roscaH15";
			this.roscaH15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH16
			// 
			this.roscaH16.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(386D)), ((float)(18D)), ((float)(2D)));
			this.roscaH16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH16.Name = "roscaH16";
			this.roscaH16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH17
			// 
			this.roscaH17.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(401D)), ((float)(18D)), ((float)(2D)));
			this.roscaH17.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH17.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH17.Name = "roscaH17";
			this.roscaH17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH18
			// 
			this.roscaH18.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(416D)), ((float)(18D)), ((float)(2D)));
			this.roscaH18.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH18.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH18.Name = "roscaH18";
			this.roscaH18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH19
			// 
			this.roscaH19.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(431D)), ((float)(18D)), ((float)(2D)));
			this.roscaH19.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH19.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH19.Name = "roscaH19";
			this.roscaH19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH20
			// 
			this.roscaH20.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(446D)), ((float)(18D)), ((float)(2D)));
			this.roscaH20.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH20.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH20.Name = "roscaH20";
			this.roscaH20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH21
			// 
			this.roscaH21.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(461D)), ((float)(18D)), ((float)(2D)));
			this.roscaH21.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH21.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH21.Name = "roscaH21";
			this.roscaH21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH22
			// 
			this.roscaH22.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(476D)), ((float)(18D)), ((float)(2D)));
			this.roscaH22.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH22.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH22.Name = "roscaH22";
			this.roscaH22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH23
			// 
			this.roscaH23.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(491D)), ((float)(18D)), ((float)(2D)));
			this.roscaH23.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH23.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH23.Name = "roscaH23";
			this.roscaH23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH24
			// 
			this.roscaH24.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(506D)), ((float)(18D)), ((float)(2D)));
			this.roscaH24.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH24.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH24.Name = "roscaH24";
			this.roscaH24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH25
			// 
			this.roscaH25.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(521D)), ((float)(18D)), ((float)(2D)));
			this.roscaH25.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH25.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH25.Name = "roscaH25";
			this.roscaH25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH26
			// 
			this.roscaH26.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(536D)), ((float)(18D)), ((float)(2D)));
			this.roscaH26.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH26.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH26.Name = "roscaH26";
			this.roscaH26.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH27
			// 
			this.roscaH27.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(551D)), ((float)(18D)), ((float)(2D)));
			this.roscaH27.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH27.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH27.Name = "roscaH27";
			this.roscaH27.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// roscaH28
			// 
			this.roscaH28.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(566D)), ((float)(18D)), ((float)(2D)));
			this.roscaH28.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.roscaH28.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roscaH28.Name = "roscaH28";
			this.roscaH28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gr22
			// 
			this.gr22.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr22.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.gr22.Location = new NxtControl.Drawing.PointF(660D, 556D);
			this.gr22.Name = "gr22";
			this.gr22.Text = "ROSCA TRANSPORTADORA 100-RT-01";
			// 
			// cac1
			// 
			this.cac1.Bounds = new NxtControl.Drawing.RectF(((float)(700D)), ((float)(628D)), ((float)(90D)), ((float)(48D)));
			this.cac1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.cac1.Closed = true;
			this.cac1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cac1.Name = "cac1";
			this.cac1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.cac1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(700D, 628D),
			new NxtControl.Drawing.PointF(790D, 628D),
			new NxtControl.Drawing.PointF(782D, 676D),
			new NxtControl.Drawing.PointF(708D, 676D)});
			// 
			// cac2
			// 
			this.cac2.Bounds = new NxtControl.Drawing.RectF(((float)(800D)), ((float)(628D)), ((float)(90D)), ((float)(48D)));
			this.cac2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.cac2.Closed = true;
			this.cac2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cac2.Name = "cac2";
			this.cac2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.cac2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(800D, 628D),
			new NxtControl.Drawing.PointF(890D, 628D),
			new NxtControl.Drawing.PointF(882D, 676D),
			new NxtControl.Drawing.PointF(808D, 676D)});
			// 
			// gr23
			// 
			this.gr23.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr23.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.gr23.Location = new NxtControl.Drawing.PointF(720D, 644D);
			this.gr23.Name = "gr23";
			this.gr23.Text = "CAÇAMBA";
			// 
			// gr24
			// 
			this.gr24.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr24.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.gr24.Location = new NxtControl.Drawing.PointF(820D, 644D);
			this.gr24.Name = "gr24";
			this.gr24.Text = "CAÇAMBA";
			// 
			// gr25
			// 
			this.gr25.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr25.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr25.Location = new NxtControl.Drawing.PointF(1090D, 146D);
			this.gr25.Name = "gr25";
			this.gr25.Text = "Clique no resumo para os comandos";
			// 
			// gr26
			// 
			this.gr26.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.gr26.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.gr26.Location = new NxtControl.Drawing.PointF(1090D, 160D);
			this.gr26.Name = "gr26";
			this.gr26.Text = "do painel e o skid do gradeamento.";
			// 
			// co_100_03
			// 
			this.co_100_03.BeginInit();
			this.co_100_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.75D, 0D, 0D, 0.75D, 266.25D, 168.5D);
			this.co_100_03.Name = "co_100_03";
			this.co_100_03.SecurityToken = ((uint)(4294967295u));
			this.co_100_03.TagName = "D8ECF975D72A6254.CO_100_03";
			this.co_100_03.EndInit();
			// 
			// co_100_04
			// 
			this.co_100_04.BeginInit();
			this.co_100_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.75D, 0D, 0D, 0.75D, 906.25D, 168.5D);
			this.co_100_04.Name = "co_100_04";
			this.co_100_04.SecurityToken = ((uint)(4294967295u));
			this.co_100_04.TagName = "D8ECF975D72A6254.CO_100_04";
			this.co_100_04.EndInit();
			// 
			// grade2
			// 
			this.grade2.BeginInit();
			this.grade2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.85D, 0D, 0D, 0.85D, 530.25D, 162D);
			this.grade2.Name = "grade2";
			this.grade2.SecurityToken = ((uint)(4294967295u));
			this.grade2.TagName = "D8ECF975D72A6254.GM_100_02.Grade_Mecanizada_Inovaisa1";
			this.grade2.EndInit();
			// 
			// mont2
			// 
			this.mont2.BeginInit();
			this.mont2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 380D, 196D);
			this.mont2.Name = "mont2";
			this.mont2.SecurityToken = ((uint)(4294967295u));
			this.mont2.TagName = "D8ECF975D72A6254.GM_100_02.SensorMontante";
			this.mont2.EndInit();
			// 
			// jus2
			// 
			this.jus2.BeginInit();
			this.jus2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 690D, 196D);
			this.jus2.Name = "jus2";
			this.jus2.SecurityToken = ((uint)(4294967295u));
			this.jus2.TagName = "D8ECF975D72A6254.GM_100_02.SensorJusante";
			this.jus2.EndInit();
			// 
			// dif2
			// 
			this.dif2.BeginInit();
			this.dif2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 690D, 256D);
			this.dif2.Name = "dif2";
			this.dif2.SecurityToken = ((uint)(4294967295u));
			this.dif2.TagName = "D8ECF975D72A6254.GM_100_02.SensorDiferencial";
			this.dif2.EndInit();
			// 
			// co_100_01
			// 
			this.co_100_01.BeginInit();
			this.co_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.75D, 0D, 0D, 0.75D, 266.25D, 398.5D);
			this.co_100_01.Name = "co_100_01";
			this.co_100_01.SecurityToken = ((uint)(4294967295u));
			this.co_100_01.TagName = "D8ECF975D72A6254.CO_100_01";
			this.co_100_01.EndInit();
			// 
			// co_100_02
			// 
			this.co_100_02.BeginInit();
			this.co_100_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.75D, 0D, 0D, 0.75D, 906.25D, 398.5D);
			this.co_100_02.Name = "co_100_02";
			this.co_100_02.SecurityToken = ((uint)(4294967295u));
			this.co_100_02.TagName = "D8ECF975D72A6254.CO_100_02";
			this.co_100_02.EndInit();
			// 
			// grade1
			// 
			this.grade1.BeginInit();
			this.grade1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.85D, 0D, 0D, 0.85D, 530.25D, 392D);
			this.grade1.Name = "grade1";
			this.grade1.SecurityToken = ((uint)(4294967295u));
			this.grade1.TagName = "D8ECF975D72A6254.GM_100_01.Grade_Mecanizada_Inovaisa1";
			this.grade1.EndInit();
			// 
			// mont1
			// 
			this.mont1.BeginInit();
			this.mont1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 380D, 426D);
			this.mont1.Name = "mont1";
			this.mont1.SecurityToken = ((uint)(4294967295u));
			this.mont1.TagName = "D8ECF975D72A6254.GM_100_01.SensorMontante";
			this.mont1.EndInit();
			// 
			// jus1
			// 
			this.jus1.BeginInit();
			this.jus1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 690D, 426D);
			this.jus1.Name = "jus1";
			this.jus1.SecurityToken = ((uint)(4294967295u));
			this.jus1.TagName = "D8ECF975D72A6254.GM_100_01.SensorJusante";
			this.jus1.EndInit();
			// 
			// dif1
			// 
			this.dif1.BeginInit();
			this.dif1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 690D, 486D);
			this.dif1.Name = "dif1";
			this.dif1.SecurityToken = ((uint)(4294967295u));
			this.dif1.TagName = "D8ECF975D72A6254.GM_100_01.SensorDiferencial";
			this.dif1.EndInit();
			// 
			// rosca
			// 
			this.rosca.BeginInit();
			this.rosca.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 624D, 558D);
			this.rosca.Name = "rosca";
			this.rosca.SecurityToken = ((uint)(4294967295u));
			this.rosca.TagName = "D8ECF975D72A6254.RT_100_01";
			this.rosca.EndInit();
			// 
			// processo
			// 
			this.processo.BeginInit();
			this.processo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 40D);
			this.processo.Name = "processo";
			this.processo.SecurityToken = ((uint)(4294967295u));
			this.processo.TagName = "D8ECF975D72A6254";
			this.processo.EndInit();
			// 
			// GRADEAMENTO
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			// 
			// btnResetGeral
			// 
			this.btnResetGeral.Bounds = new NxtControl.Drawing.RectF(((float)(1220D)), ((float)(650D)), ((float)(126D)), ((float)(30D)));
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
			this.btnReconhecerGeral.Bounds = new NxtControl.Drawing.RectF(((float)(1064D)), ((float)(650D)), ((float)(150D)), ((float)(30D)));
			this.btnReconhecerGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReconhecerGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnReconhecerGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReconhecerGeral.Name = "btnReconhecerGeral";
			this.btnReconhecerGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReconhecerGeral.Radius = 2D;
			this.btnReconhecerGeral.Text = "Reconhecer geral";
			this.btnReconhecerGeral.Use3DEffect = false;
			this.btnReconhecerGeral.Click += new System.EventHandler(this.BtnReconhecerGeralClick);
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.canal2,
			this.mur2a,
			this.mur2b,
			this.gr1,
			this.canal1,
			this.mur1a,
			this.mur1b,
			this.gr2,
			this.chegada,
			this.murCh,
			this.murMeio,
			this.gt3,
			this.gt4,
			this.gt5,
			this.gs6,
			this.gr7,
			this.saida,
			this.murSai,
			this.murMeioS,
			this.gt8,
			this.gs9,
			this.irEEE,
			this.gr10,
			this.gr11,
			this.gr12,
			this.gr13,
			this.gr14,
			this.gr15,
			this.gr16,
			this.gr17,
			this.gr18,
			this.gr19,
			this.gr20,
			this.gr21,
			this.roscaCalha,
			this.roscaH0,
			this.roscaH1,
			this.roscaH2,
			this.roscaH3,
			this.roscaH4,
			this.roscaH5,
			this.roscaH6,
			this.roscaH7,
			this.roscaH8,
			this.roscaH9,
			this.roscaH10,
			this.roscaH11,
			this.roscaH12,
			this.roscaH13,
			this.roscaH14,
			this.roscaH15,
			this.roscaH16,
			this.roscaH17,
			this.roscaH18,
			this.roscaH19,
			this.roscaH20,
			this.roscaH21,
			this.roscaH22,
			this.roscaH23,
			this.roscaH24,
			this.roscaH25,
			this.roscaH26,
			this.roscaH27,
			this.roscaH28,
			this.gr22,
			this.cac1,
			this.cac2,
			this.gr23,
			this.gr24,
			this.gr25,
			this.gr26,
			this.co_100_03,
			this.co_100_04,
			this.grade2,
			this.mont2,
			this.jus2,
			this.dif2,
			this.co_100_01,
			this.co_100_02,
			this.grade1,
			this.mont1,
			this.jus1,
			this.dif1,
			this.rosca,
			this.btnResetGeral,
			this.processo,
			this.btnReconhecerGeral});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.Rectangle canal2;
		private NxtControl.GuiFramework.Rectangle mur2a;
		private NxtControl.GuiFramework.Rectangle mur2b;
		private NxtControl.GuiFramework.FreeText gr1;
		private NxtControl.GuiFramework.Rectangle canal1;
		private NxtControl.GuiFramework.Rectangle mur1a;
		private NxtControl.GuiFramework.Rectangle mur1b;
		private NxtControl.GuiFramework.FreeText gr2;
		private NxtControl.GuiFramework.Rectangle chegada;
		private NxtControl.GuiFramework.Rectangle murCh;
		private NxtControl.GuiFramework.Rectangle murMeio;
		private NxtControl.GuiFramework.Rectangle gt3;
		private NxtControl.GuiFramework.Rectangle gt4;
		private NxtControl.GuiFramework.Rectangle gt5;
		private NxtControl.GuiFramework.Polygon gs6;
		private NxtControl.GuiFramework.FreeText gr7;
		private NxtControl.GuiFramework.Rectangle saida;
		private NxtControl.GuiFramework.Rectangle murSai;
		private NxtControl.GuiFramework.Rectangle murMeioS;
		private NxtControl.GuiFramework.Rectangle gt8;
		private NxtControl.GuiFramework.Polygon gs9;
		private NxtControl.GuiFramework.ChangeCanvasButton irEEE;
		private NxtControl.GuiFramework.FreeText gr10;
		private NxtControl.GuiFramework.FreeText gr11;
		private NxtControl.GuiFramework.FreeText gr12;
		private NxtControl.GuiFramework.FreeText gr13;
		private NxtControl.GuiFramework.FreeText gr14;
		private NxtControl.GuiFramework.FreeText gr15;
		private NxtControl.GuiFramework.FreeText gr16;
		private NxtControl.GuiFramework.FreeText gr17;
		private NxtControl.GuiFramework.FreeText gr18;
		private NxtControl.GuiFramework.FreeText gr19;
		private NxtControl.GuiFramework.FreeText gr20;
		private NxtControl.GuiFramework.FreeText gr21;
		private NxtControl.GuiFramework.Rectangle roscaCalha;
		private NxtControl.GuiFramework.Rectangle roscaH0;
		private NxtControl.GuiFramework.Rectangle roscaH1;
		private NxtControl.GuiFramework.Rectangle roscaH2;
		private NxtControl.GuiFramework.Rectangle roscaH3;
		private NxtControl.GuiFramework.Rectangle roscaH4;
		private NxtControl.GuiFramework.Rectangle roscaH5;
		private NxtControl.GuiFramework.Rectangle roscaH6;
		private NxtControl.GuiFramework.Rectangle roscaH7;
		private NxtControl.GuiFramework.Rectangle roscaH8;
		private NxtControl.GuiFramework.Rectangle roscaH9;
		private NxtControl.GuiFramework.Rectangle roscaH10;
		private NxtControl.GuiFramework.Rectangle roscaH11;
		private NxtControl.GuiFramework.Rectangle roscaH12;
		private NxtControl.GuiFramework.Rectangle roscaH13;
		private NxtControl.GuiFramework.Rectangle roscaH14;
		private NxtControl.GuiFramework.Rectangle roscaH15;
		private NxtControl.GuiFramework.Rectangle roscaH16;
		private NxtControl.GuiFramework.Rectangle roscaH17;
		private NxtControl.GuiFramework.Rectangle roscaH18;
		private NxtControl.GuiFramework.Rectangle roscaH19;
		private NxtControl.GuiFramework.Rectangle roscaH20;
		private NxtControl.GuiFramework.Rectangle roscaH21;
		private NxtControl.GuiFramework.Rectangle roscaH22;
		private NxtControl.GuiFramework.Rectangle roscaH23;
		private NxtControl.GuiFramework.Rectangle roscaH24;
		private NxtControl.GuiFramework.Rectangle roscaH25;
		private NxtControl.GuiFramework.Rectangle roscaH26;
		private NxtControl.GuiFramework.Rectangle roscaH27;
		private NxtControl.GuiFramework.Rectangle roscaH28;
		private NxtControl.GuiFramework.FreeText gr22;
		private NxtControl.GuiFramework.Polygon cac1;
		private NxtControl.GuiFramework.Polygon cac2;
		private NxtControl.GuiFramework.FreeText gr23;
		private NxtControl.GuiFramework.FreeText gr24;
		private NxtControl.GuiFramework.FreeText gr25;
		private NxtControl.GuiFramework.FreeText gr26;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta co_100_03;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta co_100_04;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade grade2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto mont2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto jus2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto dif2;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta co_100_01;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sComporta co_100_02;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade grade1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto mont1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto jus1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto dif1;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca rosca;
		private Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa.sDefault processo;
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		private NxtControl.GuiFramework.DrawnButton btnReconhecerGeral;
		#endregion
	}
}
