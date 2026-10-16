/*
 * Hidryco - tela EEE_BRUTO (Elevatoria de Esgoto Bruto)
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs (EEEB, bombas, LIT-03, PIT-01).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for EEE_BRUTO.
	/// </summary>
	partial class EEE_BRUTO
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
			this.tuboChegada = new NxtControl.GuiFramework.Pipe();
			this.grade = new NxtControl.GuiFramework.Rectangle();
			this.gradeBarra0 = new NxtControl.GuiFramework.Line();
			this.gradeBarra1 = new NxtControl.GuiFramework.Line();
			this.gradeBarra2 = new NxtControl.GuiFramework.Line();
			this.gradeBarra3 = new NxtControl.GuiFramework.Line();
			this.gradeBarra4 = new NxtControl.GuiFramework.Line();
			this.rotGrade = new NxtControl.GuiFramework.FreeText();
			this.rotChegada = new NxtControl.GuiFramework.FreeText();
			this.rotChegada2 = new NxtControl.GuiFramework.FreeText();
			this.setaChegada = new NxtControl.GuiFramework.Polygon();
			this.pocoInterior = new NxtControl.GuiFramework.Rectangle();
			this.paredeEsq = new NxtControl.GuiFramework.Rectangle();
			this.paredeDir = new NxtControl.GuiFramework.Rectangle();
			this.paredeFundo = new NxtControl.GuiFramework.Rectangle();
			this.rotPoco = new NxtControl.GuiFramework.FreeText();
			this.boiaCabo0 = new NxtControl.GuiFramework.Line();
			this.boia0 = new NxtControl.GuiFramework.Ellipse();
			this.boiaGuia0 = new NxtControl.GuiFramework.Line();
			this.boiaTag0 = new NxtControl.GuiFramework.FreeText();
			this.boiaTxt0 = new NxtControl.GuiFramework.FreeText();
			this.boiaTxu0 = new NxtControl.GuiFramework.FreeText();
			this.boiaCabo1 = new NxtControl.GuiFramework.Line();
			this.boia1 = new NxtControl.GuiFramework.Ellipse();
			this.boiaGuia1 = new NxtControl.GuiFramework.Line();
			this.boiaTag1 = new NxtControl.GuiFramework.FreeText();
			this.boiaTxt1 = new NxtControl.GuiFramework.FreeText();
			this.boiaTxu1 = new NxtControl.GuiFramework.FreeText();
			this.tuboRecalque1 = new NxtControl.GuiFramework.Pipe();
			this.retencao1 = new NxtControl.GuiFramework.Polygon();
			this.tuboRecalque2 = new NxtControl.GuiFramework.Pipe();
			this.retencao2 = new NxtControl.GuiFramework.Polygon();
			this.tuboRecalque3 = new NxtControl.GuiFramework.Pipe();
			this.retencao3 = new NxtControl.GuiFramework.Polygon();
			this.bomba1 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.bomba2 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.bomba3 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.barrilete = new NxtControl.GuiFramework.Pipe();
			this.setaBarrilete1 = new NxtControl.GuiFramework.Polygon();
			this.setaBarrilete2 = new NxtControl.GuiFramework.Polygon();
			this.rotBarrilete = new NxtControl.GuiFramework.FreeText();
			this.rotDestino = new NxtControl.GuiFramework.FreeText();
			this.irInfluente = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.tomadaPIT = new NxtControl.GuiFramework.Line();
			this.pit = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sDefault();
			this.sinalLIT = new NxtControl.GuiFramework.Line();
			this.lit = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel();
			this.rotLIT = new NxtControl.GuiFramework.FreeText();
			this.elevatoria = new Hidryco.HidrycoLib.Symbols.EEE_Bruto.sDefault();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cardProcesso
			// 
			this.cardProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(1350D)), ((float)(682D)));
			this.cardProcesso.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardProcesso.Name = "cardProcesso";
			this.cardProcesso.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tuboChegada
			// 
			this.tuboChegada.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(166D)), ((float)(134D)), ((float)(0D)));
			this.tuboChegada.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboChegada.Name = "tuboChegada";
			this.tuboChegada.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboChegada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 166D),
			new NxtControl.Drawing.PointF(158D, 166D)});
			this.tuboChegada.Width = 12;
			// 
			// grade
			// 
			this.grade.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(148D)), ((float)(54D)), ((float)(36D)));
			this.grade.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(204)), ((byte)(208))));
			this.grade.Name = "grade";
			this.grade.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// gradeBarra0
			// 
			this.gradeBarra0.EndPoint = new NxtControl.Drawing.PointF(68D, 180D);
			this.gradeBarra0.Name = "gradeBarra0";
			this.gradeBarra0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.gradeBarra0.StartPoint = new NxtControl.Drawing.PointF(68D, 152D);
			// 
			// gradeBarra1
			// 
			this.gradeBarra1.EndPoint = new NxtControl.Drawing.PointF(77.5D, 180D);
			this.gradeBarra1.Name = "gradeBarra1";
			this.gradeBarra1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.gradeBarra1.StartPoint = new NxtControl.Drawing.PointF(77.5D, 152D);
			// 
			// gradeBarra2
			// 
			this.gradeBarra2.EndPoint = new NxtControl.Drawing.PointF(87D, 180D);
			this.gradeBarra2.Name = "gradeBarra2";
			this.gradeBarra2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.gradeBarra2.StartPoint = new NxtControl.Drawing.PointF(87D, 152D);
			// 
			// gradeBarra3
			// 
			this.gradeBarra3.EndPoint = new NxtControl.Drawing.PointF(96.5D, 180D);
			this.gradeBarra3.Name = "gradeBarra3";
			this.gradeBarra3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.gradeBarra3.StartPoint = new NxtControl.Drawing.PointF(96.5D, 152D);
			// 
			// gradeBarra4
			// 
			this.gradeBarra4.EndPoint = new NxtControl.Drawing.PointF(106D, 180D);
			this.gradeBarra4.Name = "gradeBarra4";
			this.gradeBarra4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.gradeBarra4.StartPoint = new NxtControl.Drawing.PointF(106D, 152D);
			// 
			// rotGrade
			// 
			this.rotGrade.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotGrade.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rotGrade.Location = new NxtControl.Drawing.PointF(44D, 190D);
			this.rotGrade.Name = "rotGrade";
			this.rotGrade.Text = "100-GM-01/02";
			// 
			// rotChegada
			// 
			this.rotChegada.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotChegada.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotChegada.Location = new NxtControl.Drawing.PointF(26D, 102D);
			this.rotChegada.Name = "rotChegada";
			this.rotChegada.Text = "Esgoto bruto";
			// 
			// rotChegada2
			// 
			this.rotChegada2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotChegada2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotChegada2.Location = new NxtControl.Drawing.PointF(26D, 118D);
			this.rotChegada2.Name = "rotChegada2";
			this.rotChegada2.Text = "(chegada / comportas)";
			// 
			// setaChegada
			// 
			this.setaChegada.Bounds = new NxtControl.Drawing.RectF(((float)(132D)), ((float)(159D)), ((float)(14D)), ((float)(14D)));
			this.setaChegada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaChegada.Closed = true;
			this.setaChegada.Name = "setaChegada";
			this.setaChegada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaChegada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(132D, 159D),
			new NxtControl.Drawing.PointF(146D, 166D),
			new NxtControl.Drawing.PointF(132D, 173D)});
			// 
			// pocoInterior
			// 
			this.pocoInterior.Bounds = new NxtControl.Drawing.RectF(((float)(158D)), ((float)(120D)), ((float)(600D)), ((float)(532D)));
			this.pocoInterior.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(214)), ((byte)(218)), ((byte)(222))));
			this.pocoInterior.Name = "pocoInterior";
			this.pocoInterior.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// paredeEsq
			// 
			this.paredeEsq.Bounds = new NxtControl.Drawing.RectF(((float)(146D)), ((float)(110D)), ((float)(12D)), ((float)(554D)));
			this.paredeEsq.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.paredeEsq.Name = "paredeEsq";
			this.paredeEsq.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// paredeDir
			// 
			this.paredeDir.Bounds = new NxtControl.Drawing.RectF(((float)(758D)), ((float)(110D)), ((float)(12D)), ((float)(554D)));
			this.paredeDir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.paredeDir.Name = "paredeDir";
			this.paredeDir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// paredeFundo
			// 
			this.paredeFundo.Bounds = new NxtControl.Drawing.RectF(((float)(146D)), ((float)(652D)), ((float)(624D)), ((float)(12D)));
			this.paredeFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(128)), ((byte)(132)), ((byte)(136))));
			this.paredeFundo.Name = "paredeFundo";
			this.paredeFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rotPoco
			// 
			this.rotPoco.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotPoco.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rotPoco.Location = new NxtControl.Drawing.PointF(172D, 624D);
			this.rotPoco.Name = "rotPoco";
			this.rotPoco.Text = "POÇO ÚMIDO";
			// 
			// boiaCabo0
			// 
			this.boiaCabo0.EndPoint = new NxtControl.Drawing.PointF(178D, 252D);
			this.boiaCabo0.Name = "boiaCabo0";
			this.boiaCabo0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.boiaCabo0.StartPoint = new NxtControl.Drawing.PointF(178D, 120D);
			// 
			// boia0
			// 
			this.boia0.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(252D)), ((float)(16D)), ((float)(16D)));
			this.boia0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.boia0.Name = "boia0";
			this.boia0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// boiaGuia0
			// 
			this.boiaGuia0.EndPoint = new NxtControl.Drawing.PointF(170D, 260D);
			this.boiaGuia0.Name = "boiaGuia0";
			this.boiaGuia0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.boiaGuia0.StartPoint = new NxtControl.Drawing.PointF(122D, 260D);
			// 
			// boiaTag0
			// 
			this.boiaTag0.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.boiaTag0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.boiaTag0.Location = new NxtControl.Drawing.PointF(24D, 238D);
			this.boiaTag0.Name = "boiaTag0";
			this.boiaTag0.Text = "LSH-05";
			// 
			// boiaTxt0
			// 
			this.boiaTxt0.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.boiaTxt0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.boiaTxt0.Location = new NxtControl.Drawing.PointF(24D, 254D);
			this.boiaTxt0.Name = "boiaTxt0";
			this.boiaTxt0.Text = "nível alto";
			// 
			// boiaTxu0
			// 
			this.boiaTxu0.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.boiaTxu0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.boiaTxu0.Location = new NxtControl.Drawing.PointF(24D, 268D);
			this.boiaTxu0.Name = "boiaTxu0";
			this.boiaTxu0.Text = "alarme / emergência";
			// 
			// boiaCabo1
			// 
			this.boiaCabo1.EndPoint = new NxtControl.Drawing.PointF(178D, 572D);
			this.boiaCabo1.Name = "boiaCabo1";
			this.boiaCabo1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.boiaCabo1.StartPoint = new NxtControl.Drawing.PointF(178D, 120D);
			// 
			// boia1
			// 
			this.boia1.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(572D)), ((float)(16D)), ((float)(16D)));
			this.boia1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.boia1.Name = "boia1";
			this.boia1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// boiaGuia1
			// 
			this.boiaGuia1.EndPoint = new NxtControl.Drawing.PointF(170D, 580D);
			this.boiaGuia1.Name = "boiaGuia1";
			this.boiaGuia1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1F, NxtControl.Drawing.DashStyle.Dash);
			this.boiaGuia1.StartPoint = new NxtControl.Drawing.PointF(122D, 580D);
			// 
			// boiaTag1
			// 
			this.boiaTag1.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.boiaTag1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.boiaTag1.Location = new NxtControl.Drawing.PointF(24D, 558D);
			this.boiaTag1.Name = "boiaTag1";
			this.boiaTag1.Text = "LSL-04";
			// 
			// boiaTxt1
			// 
			this.boiaTxt1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.boiaTxt1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.boiaTxt1.Location = new NxtControl.Drawing.PointF(24D, 574D);
			this.boiaTxt1.Name = "boiaTxt1";
			this.boiaTxt1.Text = "nível baixo";
			// 
			// boiaTxu1
			// 
			this.boiaTxu1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.boiaTxu1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.boiaTxu1.Location = new NxtControl.Drawing.PointF(24D, 588D);
			this.boiaTxu1.Name = "boiaTxu1";
			this.boiaTxu1.Text = "bloqueia as bombas";
			// 
			// tuboRecalque1
			// 
			this.tuboRecalque1.Bounds = new NxtControl.Drawing.RectF(((float)(356D)), ((float)(64D)), ((float)(16D)), ((float)(426D)));
			this.tuboRecalque1.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboRecalque1.Name = "tuboRecalque1";
			this.tuboRecalque1.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboRecalque1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(356D, 490D),
			new NxtControl.Drawing.PointF(372D, 490D),
			new NxtControl.Drawing.PointF(372D, 64D)});
			this.tuboRecalque1.Width = 8;
			// 
			// retencao1
			// 
			this.retencao1.Bounds = new NxtControl.Drawing.RectF(((float)(363D)), ((float)(80D)), ((float)(18D)), ((float)(18D)));
			this.retencao1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.retencao1.Closed = true;
			this.retencao1.Name = "retencao1";
			this.retencao1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.retencao1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(363D, 80D),
			new NxtControl.Drawing.PointF(381D, 80D),
			new NxtControl.Drawing.PointF(363D, 98D),
			new NxtControl.Drawing.PointF(381D, 98D)});
			// 
			// tuboRecalque2
			// 
			this.tuboRecalque2.Bounds = new NxtControl.Drawing.RectF(((float)(521D)), ((float)(64D)), ((float)(16D)), ((float)(426D)));
			this.tuboRecalque2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboRecalque2.Name = "tuboRecalque2";
			this.tuboRecalque2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboRecalque2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(521D, 490D),
			new NxtControl.Drawing.PointF(537D, 490D),
			new NxtControl.Drawing.PointF(537D, 64D)});
			this.tuboRecalque2.Width = 8;
			// 
			// retencao2
			// 
			this.retencao2.Bounds = new NxtControl.Drawing.RectF(((float)(528D)), ((float)(80D)), ((float)(18D)), ((float)(18D)));
			this.retencao2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.retencao2.Closed = true;
			this.retencao2.Name = "retencao2";
			this.retencao2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.retencao2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(528D, 80D),
			new NxtControl.Drawing.PointF(546D, 80D),
			new NxtControl.Drawing.PointF(528D, 98D),
			new NxtControl.Drawing.PointF(546D, 98D)});
			// 
			// tuboRecalque3
			// 
			this.tuboRecalque3.Bounds = new NxtControl.Drawing.RectF(((float)(686D)), ((float)(64D)), ((float)(16D)), ((float)(426D)));
			this.tuboRecalque3.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tuboRecalque3.Name = "tuboRecalque3";
			this.tuboRecalque3.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tuboRecalque3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(686D, 490D),
			new NxtControl.Drawing.PointF(702D, 490D),
			new NxtControl.Drawing.PointF(702D, 64D)});
			this.tuboRecalque3.Width = 8;
			// 
			// retencao3
			// 
			this.retencao3.Bounds = new NxtControl.Drawing.RectF(((float)(693D)), ((float)(80D)), ((float)(18D)), ((float)(18D)));
			this.retencao3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.retencao3.Closed = true;
			this.retencao3.Name = "retencao3";
			this.retencao3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.retencao3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(693D, 80D),
			new NxtControl.Drawing.PointF(711D, 80D),
			new NxtControl.Drawing.PointF(693D, 98D),
			new NxtControl.Drawing.PointF(711D, 98D)});
			// 
			// bomba1
			// 
			this.bomba1.BeginInit();
			this.bomba1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 270D, 452D);
			this.bomba1.Name = "bomba1";
			this.bomba1.SecurityToken = ((uint)(4294967295u));
			this.bomba1.TagName = "F8F84A6966B68EF2.BS_100_01";
			this.bomba1.EndInit();
			// 
			// bomba2
			// 
			this.bomba2.BeginInit();
			this.bomba2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 435D, 452D);
			this.bomba2.Name = "bomba2";
			this.bomba2.SecurityToken = ((uint)(4294967295u));
			this.bomba2.TagName = "F8F84A6966B68EF2.BS_100_02";
			this.bomba2.EndInit();
			// 
			// bomba3
			// 
			this.bomba3.BeginInit();
			this.bomba3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 600D, 452D);
			this.bomba3.Name = "bomba3";
			this.bomba3.SecurityToken = ((uint)(4294967295u));
			this.bomba3.TagName = "F8F84A6966B68EF2.BS_100_03";
			this.bomba3.EndInit();
			// 
			// barrilete
			// 
			this.barrilete.Bounds = new NxtControl.Drawing.RectF(((float)(372D)), ((float)(64D)), ((float)(558D)), ((float)(0D)));
			this.barrilete.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.barrilete.Name = "barrilete";
			this.barrilete.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.barrilete.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(372D, 64D),
			new NxtControl.Drawing.PointF(930D, 64D)});
			this.barrilete.Width = 12;
			// 
			// setaBarrilete1
			// 
			this.setaBarrilete1.Bounds = new NxtControl.Drawing.RectF(((float)(880D)), ((float)(56D)), ((float)(16D)), ((float)(16D)));
			this.setaBarrilete1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaBarrilete1.Closed = true;
			this.setaBarrilete1.Name = "setaBarrilete1";
			this.setaBarrilete1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaBarrilete1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(880D, 56D),
			new NxtControl.Drawing.PointF(896D, 64D),
			new NxtControl.Drawing.PointF(880D, 72D)});
			// 
			// setaBarrilete2
			// 
			this.setaBarrilete2.Bounds = new NxtControl.Drawing.RectF(((float)(916D)), ((float)(56D)), ((float)(16D)), ((float)(16D)));
			this.setaBarrilete2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))));
			this.setaBarrilete2.Closed = true;
			this.setaBarrilete2.Name = "setaBarrilete2";
			this.setaBarrilete2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.setaBarrilete2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(916D, 56D),
			new NxtControl.Drawing.PointF(932D, 64D),
			new NxtControl.Drawing.PointF(916D, 72D)});
			// 
			// rotBarrilete
			// 
			this.rotBarrilete.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.rotBarrilete.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rotBarrilete.Location = new NxtControl.Drawing.PointF(382D, 40D);
			this.rotBarrilete.Name = "rotBarrilete";
			this.rotBarrilete.Text = "Recalque";
			// 
			// rotDestino
			// 
			this.rotDestino.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotDestino.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotDestino.Location = new NxtControl.Drawing.PointF(798D, 32D);
			this.rotDestino.Name = "rotDestino";
			this.rotDestino.Text = "para o pré-tratamento (UCT-01/02)";
			// 
			// irInfluente
			// 
			this.irInfluente.Bounds = new NxtControl.Drawing.RectF(((float)(940D)), ((float)(48D)), ((float)(128D)), ((float)(32D)));
			this.irInfluente.CanvasName = "INFLUENT_FEED";
			this.irInfluente.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.irInfluente.Name = "irInfluente";
			this.irInfluente.Text = "Influent Feed ›";
			// 
			// tomadaPIT
			// 
			this.tomadaPIT.EndPoint = new NxtControl.Drawing.PointF(880D, 120D);
			this.tomadaPIT.Name = "tomadaPIT";
			this.tomadaPIT.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.tomadaPIT.StartPoint = new NxtControl.Drawing.PointF(880D, 70D);
			// 
			// pit
			// 
			this.pit.BeginInit();
			this.pit.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 792D, 120D);
			this.pit.Name = "pit";
			this.pit.SecurityToken = ((uint)(4294967295u));
			this.pit.TagName = "F8F84A6966B68EF2.PIT_100_01";
			this.pit.EndInit();
			// 
			// sinalLIT
			// 
			this.sinalLIT.EndPoint = new NxtControl.Drawing.PointF(800D, 512D);
			this.sinalLIT.Name = "sinalLIT";
			this.sinalLIT.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(140)), ((byte)(144)), ((byte)(148))), 1.5F, NxtControl.Drawing.DashStyle.Dash);
			this.sinalLIT.StartPoint = new NxtControl.Drawing.PointF(770D, 512D);
			// 
			// lit
			// 
			this.lit.BeginInit();
			this.lit.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 806D, 372D);
			this.lit.Name = "lit";
			this.lit.SecurityToken = ((uint)(4294967295u));
			this.lit.TagName = "F8F84A6966B68EF2.LIT_100_03";
			this.lit.EndInit();
			// 
			// rotLIT
			// 
			this.rotLIT.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.rotLIT.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rotLIT.Location = new NxtControl.Drawing.PointF(806D, 542D);
			this.rotLIT.Name = "rotLIT";
			this.rotLIT.Text = "Nível do poço";
			// 
			// elevatoria
			// 
			this.elevatoria.BeginInit();
			this.elevatoria.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1090D, 24D);
			this.elevatoria.Name = "elevatoria";
			this.elevatoria.SecurityToken = ((uint)(4294967295u));
			this.elevatoria.TagName = "F8F84A6966B68EF2";
			this.elevatoria.EndInit();
			// 
			// EEE_BRUTO
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "EEE_BRUTO";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.tuboChegada,
			this.grade,
			this.gradeBarra0,
			this.gradeBarra1,
			this.gradeBarra2,
			this.gradeBarra3,
			this.gradeBarra4,
			this.rotGrade,
			this.rotChegada,
			this.rotChegada2,
			this.setaChegada,
			this.pocoInterior,
			this.paredeEsq,
			this.paredeDir,
			this.paredeFundo,
			this.rotPoco,
			this.boiaCabo0,
			this.boia0,
			this.boiaGuia0,
			this.boiaTag0,
			this.boiaTxt0,
			this.boiaTxu0,
			this.boiaCabo1,
			this.boia1,
			this.boiaGuia1,
			this.boiaTag1,
			this.boiaTxt1,
			this.boiaTxu1,
			this.tuboRecalque1,
			this.retencao1,
			this.tuboRecalque2,
			this.retencao2,
			this.tuboRecalque3,
			this.retencao3,
			this.bomba1,
			this.bomba2,
			this.bomba3,
			this.barrilete,
			this.setaBarrilete1,
			this.setaBarrilete2,
			this.rotBarrilete,
			this.rotDestino,
			this.irInfluente,
			this.tomadaPIT,
			this.pit,
			this.sinalLIT,
			this.lit,
			this.rotLIT,
			this.elevatoria});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.Pipe tuboChegada;
		private NxtControl.GuiFramework.Rectangle grade;
		private NxtControl.GuiFramework.Line gradeBarra0;
		private NxtControl.GuiFramework.Line gradeBarra1;
		private NxtControl.GuiFramework.Line gradeBarra2;
		private NxtControl.GuiFramework.Line gradeBarra3;
		private NxtControl.GuiFramework.Line gradeBarra4;
		private NxtControl.GuiFramework.FreeText rotGrade;
		private NxtControl.GuiFramework.FreeText rotChegada;
		private NxtControl.GuiFramework.FreeText rotChegada2;
		private NxtControl.GuiFramework.Polygon setaChegada;
		private NxtControl.GuiFramework.Rectangle pocoInterior;
		private NxtControl.GuiFramework.Rectangle paredeEsq;
		private NxtControl.GuiFramework.Rectangle paredeDir;
		private NxtControl.GuiFramework.Rectangle paredeFundo;
		private NxtControl.GuiFramework.FreeText rotPoco;
		private NxtControl.GuiFramework.Line boiaCabo0;
		private NxtControl.GuiFramework.Ellipse boia0;
		private NxtControl.GuiFramework.Line boiaGuia0;
		private NxtControl.GuiFramework.FreeText boiaTag0;
		private NxtControl.GuiFramework.FreeText boiaTxt0;
		private NxtControl.GuiFramework.FreeText boiaTxu0;
		private NxtControl.GuiFramework.Line boiaCabo1;
		private NxtControl.GuiFramework.Ellipse boia1;
		private NxtControl.GuiFramework.Line boiaGuia1;
		private NxtControl.GuiFramework.FreeText boiaTag1;
		private NxtControl.GuiFramework.FreeText boiaTxt1;
		private NxtControl.GuiFramework.FreeText boiaTxu1;
		private NxtControl.GuiFramework.Pipe tuboRecalque1;
		private NxtControl.GuiFramework.Polygon retencao1;
		private NxtControl.GuiFramework.Pipe tuboRecalque2;
		private NxtControl.GuiFramework.Polygon retencao2;
		private NxtControl.GuiFramework.Pipe tuboRecalque3;
		private NxtControl.GuiFramework.Polygon retencao3;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bomba1;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bomba2;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba bomba3;
		private NxtControl.GuiFramework.Pipe barrilete;
		private NxtControl.GuiFramework.Polygon setaBarrilete1;
		private NxtControl.GuiFramework.Polygon setaBarrilete2;
		private NxtControl.GuiFramework.FreeText rotBarrilete;
		private NxtControl.GuiFramework.FreeText rotDestino;
		private NxtControl.GuiFramework.ChangeCanvasButton irInfluente;
		private NxtControl.GuiFramework.Line tomadaPIT;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sDefault pit;
		private NxtControl.GuiFramework.Line sinalLIT;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel lit;
		private NxtControl.GuiFramework.FreeText rotLIT;
		private Hidryco.HidrycoLib.Symbols.EEE_Bruto.sDefault elevatoria;
		#endregion
	}
}
