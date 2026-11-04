/*
 * Hidryco - tela FASE_SOLIDA (fase solida - serie 900)
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
	/// Summary description for FASE_SOLIDA.
	/// </summary>
	partial class FASE_SOLIDA
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
			this.fr1 = new NxtControl.GuiFramework.FreeText();
			this.fr2 = new NxtControl.GuiFramework.FreeText();
			this.fr3 = new NxtControl.GuiFramework.FreeText();
			this.ft4 = new NxtControl.GuiFramework.Rectangle();
			this.fa5 = new NxtControl.GuiFramework.Polygon();
			this.ft6 = new NxtControl.GuiFramework.Rectangle();
			this.fa7 = new NxtControl.GuiFramework.Polygon();
			this.ft8 = new NxtControl.GuiFramework.Rectangle();
			this.fa9 = new NxtControl.GuiFramework.Polygon();
			this.ft10 = new NxtControl.GuiFramework.Rectangle();
			this.ft11 = new NxtControl.GuiFramework.Rectangle();
			this.fr12 = new NxtControl.GuiFramework.FreeText();
			this.ft13 = new NxtControl.GuiFramework.Rectangle();
			this.fr14 = new NxtControl.GuiFramework.FreeText();
			this.ft15 = new NxtControl.GuiFramework.Rectangle();
			this.fr16 = new NxtControl.GuiFramework.FreeText();
			this.fr17 = new NxtControl.GuiFramework.FreeText();
			this.ft18 = new NxtControl.GuiFramework.Rectangle();
			this.ft19 = new NxtControl.GuiFramework.Rectangle();
			this.ft20 = new NxtControl.GuiFramework.Rectangle();
			this.ft21 = new NxtControl.GuiFramework.Rectangle();
			this.fvr22 = new NxtControl.GuiFramework.Polygon();
			this.fvr23 = new NxtControl.GuiFramework.Rectangle();
			this.fvm24 = new NxtControl.GuiFramework.Polygon();
			this.fvm25 = new NxtControl.GuiFramework.Polygon();
			this.fvm26 = new NxtControl.GuiFramework.Rectangle();
			this.fr27 = new NxtControl.GuiFramework.FreeText();
			this.fs28 = new NxtControl.GuiFramework.Polygon();
			this.ft29 = new NxtControl.GuiFramework.Rectangle();
			this.ft30 = new NxtControl.GuiFramework.Rectangle();
			this.ft31 = new NxtControl.GuiFramework.Rectangle();
			this.fvr32 = new NxtControl.GuiFramework.Polygon();
			this.fvr33 = new NxtControl.GuiFramework.Rectangle();
			this.fvm34 = new NxtControl.GuiFramework.Polygon();
			this.fvm35 = new NxtControl.GuiFramework.Polygon();
			this.fvm36 = new NxtControl.GuiFramework.Rectangle();
			this.fr37 = new NxtControl.GuiFramework.FreeText();
			this.fs38 = new NxtControl.GuiFramework.Polygon();
			this.ft39 = new NxtControl.GuiFramework.Rectangle();
			this.ft40 = new NxtControl.GuiFramework.Rectangle();
			this.ft41 = new NxtControl.GuiFramework.Rectangle();
			this.fvr42 = new NxtControl.GuiFramework.Polygon();
			this.fvr43 = new NxtControl.GuiFramework.Rectangle();
			this.fvm44 = new NxtControl.GuiFramework.Polygon();
			this.fvm45 = new NxtControl.GuiFramework.Polygon();
			this.fvm46 = new NxtControl.GuiFramework.Rectangle();
			this.fr47 = new NxtControl.GuiFramework.FreeText();
			this.fs48 = new NxtControl.GuiFramework.Polygon();
			this.ft49 = new NxtControl.GuiFramework.Rectangle();
			this.ft50 = new NxtControl.GuiFramework.Rectangle();
			this.fvm51 = new NxtControl.GuiFramework.Polygon();
			this.fvm52 = new NxtControl.GuiFramework.Polygon();
			this.fvm53 = new NxtControl.GuiFramework.Rectangle();
			this.fr54 = new NxtControl.GuiFramework.FreeText();
			this.ft55 = new NxtControl.GuiFramework.Rectangle();
			this.fvm56 = new NxtControl.GuiFramework.Polygon();
			this.fvm57 = new NxtControl.GuiFramework.Polygon();
			this.fvm58 = new NxtControl.GuiFramework.Rectangle();
			this.fmo59 = new NxtControl.GuiFramework.Rectangle();
			this.fmo60 = new NxtControl.GuiFramework.Polygon();
			this.fmo61 = new NxtControl.GuiFramework.Polygon();
			this.fmo62 = new NxtControl.GuiFramework.Polygon();
			this.ft63 = new NxtControl.GuiFramework.Rectangle();
			this.fr64 = new NxtControl.GuiFramework.FreeText();
			this.fr65 = new NxtControl.GuiFramework.FreeText();
			this.ft66 = new NxtControl.GuiFramework.Rectangle();
			this.ft67 = new NxtControl.GuiFramework.Rectangle();
			this.fvm68 = new NxtControl.GuiFramework.Polygon();
			this.fvm69 = new NxtControl.GuiFramework.Polygon();
			this.fvm70 = new NxtControl.GuiFramework.Rectangle();
			this.fr71 = new NxtControl.GuiFramework.FreeText();
			this.ft72 = new NxtControl.GuiFramework.Rectangle();
			this.fvm73 = new NxtControl.GuiFramework.Polygon();
			this.fvm74 = new NxtControl.GuiFramework.Polygon();
			this.fvm75 = new NxtControl.GuiFramework.Rectangle();
			this.fmo76 = new NxtControl.GuiFramework.Rectangle();
			this.fmo77 = new NxtControl.GuiFramework.Polygon();
			this.fmo78 = new NxtControl.GuiFramework.Polygon();
			this.fmo79 = new NxtControl.GuiFramework.Polygon();
			this.ft80 = new NxtControl.GuiFramework.Rectangle();
			this.fr81 = new NxtControl.GuiFramework.FreeText();
			this.fr82 = new NxtControl.GuiFramework.FreeText();
			this.ft83 = new NxtControl.GuiFramework.Rectangle();
			this.ft84 = new NxtControl.GuiFramework.Rectangle();
			this.fvm85 = new NxtControl.GuiFramework.Polygon();
			this.fvm86 = new NxtControl.GuiFramework.Polygon();
			this.fvm87 = new NxtControl.GuiFramework.Rectangle();
			this.fr88 = new NxtControl.GuiFramework.FreeText();
			this.ft89 = new NxtControl.GuiFramework.Rectangle();
			this.fvm90 = new NxtControl.GuiFramework.Polygon();
			this.fvm91 = new NxtControl.GuiFramework.Polygon();
			this.fvm92 = new NxtControl.GuiFramework.Rectangle();
			this.fmo93 = new NxtControl.GuiFramework.Rectangle();
			this.fmo94 = new NxtControl.GuiFramework.Polygon();
			this.fmo95 = new NxtControl.GuiFramework.Polygon();
			this.fmo96 = new NxtControl.GuiFramework.Polygon();
			this.ft97 = new NxtControl.GuiFramework.Rectangle();
			this.fr98 = new NxtControl.GuiFramework.FreeText();
			this.fr99 = new NxtControl.GuiFramework.FreeText();
			this.ft100 = new NxtControl.GuiFramework.Rectangle();
			this.ft101 = new NxtControl.GuiFramework.Rectangle();
			this.fr102 = new NxtControl.GuiFramework.FreeText();
			this.fr103 = new NxtControl.GuiFramework.FreeText();
			this.fr104 = new NxtControl.GuiFramework.FreeText();
			this.ft105 = new NxtControl.GuiFramework.Rectangle();
			this.ft106 = new NxtControl.GuiFramework.Rectangle();
			this.ft107 = new NxtControl.GuiFramework.Rectangle();
			this.ft108 = new NxtControl.GuiFramework.Rectangle();
			this.ft109 = new NxtControl.GuiFramework.Rectangle();
			this.ft110 = new NxtControl.GuiFramework.Rectangle();
			this.ft111 = new NxtControl.GuiFramework.Rectangle();
			this.ft112 = new NxtControl.GuiFramework.Rectangle();
			this.ft113 = new NxtControl.GuiFramework.Rectangle();
			this.fr114 = new NxtControl.GuiFramework.FreeText();
			this.fr115 = new NxtControl.GuiFramework.FreeText();
			this.ft116 = new NxtControl.GuiFramework.Rectangle();
			this.ft117 = new NxtControl.GuiFramework.Rectangle();
			this.fvm118 = new NxtControl.GuiFramework.Polygon();
			this.fvm119 = new NxtControl.GuiFramework.Polygon();
			this.fvm120 = new NxtControl.GuiFramework.Rectangle();
			this.fr121 = new NxtControl.GuiFramework.FreeText();
			this.ft122 = new NxtControl.GuiFramework.Rectangle();
			this.fa123 = new NxtControl.GuiFramework.Polygon();
			this.ft124 = new NxtControl.GuiFramework.Rectangle();
			this.fvm125 = new NxtControl.GuiFramework.Polygon();
			this.fvm126 = new NxtControl.GuiFramework.Polygon();
			this.fvm127 = new NxtControl.GuiFramework.Rectangle();
			this.fr128 = new NxtControl.GuiFramework.FreeText();
			this.ft129 = new NxtControl.GuiFramework.Rectangle();
			this.fa130 = new NxtControl.GuiFramework.Polygon();
			this.ft131 = new NxtControl.GuiFramework.Rectangle();
			this.fa132 = new NxtControl.GuiFramework.Polygon();
			this.ft133 = new NxtControl.GuiFramework.Rectangle();
			this.fvm134 = new NxtControl.GuiFramework.Polygon();
			this.fvm135 = new NxtControl.GuiFramework.Polygon();
			this.fvm136 = new NxtControl.GuiFramework.Rectangle();
			this.fr137 = new NxtControl.GuiFramework.FreeText();
			this.irEstoc = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.ft138 = new NxtControl.GuiFramework.Rectangle();
			this.ft139 = new NxtControl.GuiFramework.Rectangle();
			this.ft140 = new NxtControl.GuiFramework.Rectangle();
			this.fr141 = new NxtControl.GuiFramework.FreeText();
			this.ft142 = new NxtControl.GuiFramework.Rectangle();
			this.fr143 = new NxtControl.GuiFramework.FreeText();
			this.ft144 = new NxtControl.GuiFramework.Rectangle();
			this.fr145 = new NxtControl.GuiFramework.FreeText();
			this.fr146 = new NxtControl.GuiFramework.FreeText();
			this.fr147 = new NxtControl.GuiFramework.FreeText();
			this.ft148 = new NxtControl.GuiFramework.Rectangle();
			this.ft149 = new NxtControl.GuiFramework.Rectangle();
			this.ft150 = new NxtControl.GuiFramework.Rectangle();
			this.fvm151 = new NxtControl.GuiFramework.Polygon();
			this.fvm152 = new NxtControl.GuiFramework.Polygon();
			this.fvm153 = new NxtControl.GuiFramework.Rectangle();
			this.ft154 = new NxtControl.GuiFramework.Rectangle();
			this.ft155 = new NxtControl.GuiFramework.Rectangle();
			this.fvr156 = new NxtControl.GuiFramework.Polygon();
			this.fvr157 = new NxtControl.GuiFramework.Rectangle();
			this.fvm158 = new NxtControl.GuiFramework.Polygon();
			this.fvm159 = new NxtControl.GuiFramework.Polygon();
			this.fvm160 = new NxtControl.GuiFramework.Rectangle();
			this.fr161 = new NxtControl.GuiFramework.FreeText();
			this.ft162 = new NxtControl.GuiFramework.Rectangle();
			this.ft163 = new NxtControl.GuiFramework.Rectangle();
			this.fvm164 = new NxtControl.GuiFramework.Polygon();
			this.fvm165 = new NxtControl.GuiFramework.Polygon();
			this.fvm166 = new NxtControl.GuiFramework.Rectangle();
			this.ft167 = new NxtControl.GuiFramework.Rectangle();
			this.ft168 = new NxtControl.GuiFramework.Rectangle();
			this.fvr169 = new NxtControl.GuiFramework.Polygon();
			this.fvr170 = new NxtControl.GuiFramework.Rectangle();
			this.fvm171 = new NxtControl.GuiFramework.Polygon();
			this.fvm172 = new NxtControl.GuiFramework.Polygon();
			this.fvm173 = new NxtControl.GuiFramework.Rectangle();
			this.fr174 = new NxtControl.GuiFramework.FreeText();
			this.ft175 = new NxtControl.GuiFramework.Rectangle();
			this.ft176 = new NxtControl.GuiFramework.Rectangle();
			this.fr177 = new NxtControl.GuiFramework.FreeText();
			this.fr178 = new NxtControl.GuiFramework.FreeText();
			this.ad01 = new Hidryco.HidrycoLib.Symbols.Prensa_Vibropac.sCPress();
			this.ad02 = new Hidryco.HidrycoLib.Symbols.Prensa_Vibropac.sCPress();
			this.ad03 = new Hidryco.HidrycoLib.Symbols.Prensa_Vibropac.sCPress();
			this.sv04 = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV04();
			this.sv06 = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV06();
			this.sv08 = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV08();
			this.pp01 = new Hidryco.HidrycoLib.Symbols.Preparador_Vibropac.sPolimero();
			this.bo01 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal();
			this.va06 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.bo02 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal();
			this.va07 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.bo03 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal();
			this.va08 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.va09 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV();
			this.va10 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV();
			this.va12 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV();
			this.va11 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.va13 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.sv03 = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV03();
			this.sv02 = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV02();
			this.sv01 = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV01();
			this.ft01 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.ft02 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.ft03 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.br01 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.br02 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.ft07 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.processo = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sFaixa();
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
			// fr1
			// 
			this.fr1.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr1.Location = new NxtControl.Drawing.PointF(648D, 117D);
			this.fr1.Name = "fr1";
			this.fr1.Text = "AD-01";
			// 
			// fr2
			// 
			this.fr2.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr2.Location = new NxtControl.Drawing.PointF(881D, 117D);
			this.fr2.Name = "fr2";
			this.fr2.Text = "AD-02";
			// 
			// fr3
			// 
			this.fr3.Color = new NxtControl.Drawing.Color(((byte)(140)), ((byte)(140)), ((byte)(140)));
			this.fr3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr3.Location = new NxtControl.Drawing.PointF(1114D, 117D);
			this.fr3.Name = "fr3";
			this.fr3.Text = "AD-03";
			// 
			// ft4
			// 
			this.ft4.Bounds = new NxtControl.Drawing.RectF(((float)(12.5D)), ((float)(74.5D)), ((float)(616D)), ((float)(3D)));
			this.ft4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft4.Name = "ft4";
			this.ft4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fa5
			// 
			this.fa5.Bounds = new NxtControl.Drawing.RectF(((float)(625.5D)), ((float)(68.5D)), ((float)(15D)), ((float)(7.5D)));
			this.fa5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.fa5.Closed = true;
			this.fa5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fa5.Name = "fa5";
			this.fa5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fa5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(625.5D, 76D),
			new NxtControl.Drawing.PointF(625.76D, 74.06D),
			new NxtControl.Drawing.PointF(626.5D, 72.25D),
			new NxtControl.Drawing.PointF(627.7D, 70.7D),
			new NxtControl.Drawing.PointF(629.25D, 69.5D),
			new NxtControl.Drawing.PointF(631.06D, 68.76D),
			new NxtControl.Drawing.PointF(633D, 68.5D),
			new NxtControl.Drawing.PointF(634.94D, 68.76D),
			new NxtControl.Drawing.PointF(636.75D, 69.5D),
			new NxtControl.Drawing.PointF(638.3D, 70.7D),
			new NxtControl.Drawing.PointF(639.5D, 72.25D),
			new NxtControl.Drawing.PointF(640.24D, 74.06D),
			new NxtControl.Drawing.PointF(640.5D, 76D),
			new NxtControl.Drawing.PointF(637.5D, 76D),
			new NxtControl.Drawing.PointF(637.35D, 74.84D),
			new NxtControl.Drawing.PointF(636.9D, 73.75D),
			new NxtControl.Drawing.PointF(636.18D, 72.82D),
			new NxtControl.Drawing.PointF(635.25D, 72.1D),
			new NxtControl.Drawing.PointF(634.16D, 71.65D),
			new NxtControl.Drawing.PointF(633D, 71.5D),
			new NxtControl.Drawing.PointF(631.84D, 71.65D),
			new NxtControl.Drawing.PointF(630.75D, 72.1D),
			new NxtControl.Drawing.PointF(629.82D, 72.82D),
			new NxtControl.Drawing.PointF(629.1D, 73.75D),
			new NxtControl.Drawing.PointF(628.65D, 74.84D),
			new NxtControl.Drawing.PointF(628.5D, 76D)});
			// 
			// ft6
			// 
			this.ft6.Bounds = new NxtControl.Drawing.RectF(((float)(637.5D)), ((float)(74.5D)), ((float)(224D)), ((float)(3D)));
			this.ft6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft6.Name = "ft6";
			this.ft6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fa7
			// 
			this.fa7.Bounds = new NxtControl.Drawing.RectF(((float)(858.5D)), ((float)(68.5D)), ((float)(15D)), ((float)(7.5D)));
			this.fa7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.fa7.Closed = true;
			this.fa7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fa7.Name = "fa7";
			this.fa7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fa7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(858.5D, 76D),
			new NxtControl.Drawing.PointF(858.76D, 74.06D),
			new NxtControl.Drawing.PointF(859.5D, 72.25D),
			new NxtControl.Drawing.PointF(860.7D, 70.7D),
			new NxtControl.Drawing.PointF(862.25D, 69.5D),
			new NxtControl.Drawing.PointF(864.06D, 68.76D),
			new NxtControl.Drawing.PointF(866D, 68.5D),
			new NxtControl.Drawing.PointF(867.94D, 68.76D),
			new NxtControl.Drawing.PointF(869.75D, 69.5D),
			new NxtControl.Drawing.PointF(871.3D, 70.7D),
			new NxtControl.Drawing.PointF(872.5D, 72.25D),
			new NxtControl.Drawing.PointF(873.24D, 74.06D),
			new NxtControl.Drawing.PointF(873.5D, 76D),
			new NxtControl.Drawing.PointF(870.5D, 76D),
			new NxtControl.Drawing.PointF(870.35D, 74.84D),
			new NxtControl.Drawing.PointF(869.9D, 73.75D),
			new NxtControl.Drawing.PointF(869.18D, 72.82D),
			new NxtControl.Drawing.PointF(868.25D, 72.1D),
			new NxtControl.Drawing.PointF(867.16D, 71.65D),
			new NxtControl.Drawing.PointF(866D, 71.5D),
			new NxtControl.Drawing.PointF(864.84D, 71.65D),
			new NxtControl.Drawing.PointF(863.75D, 72.1D),
			new NxtControl.Drawing.PointF(862.82D, 72.82D),
			new NxtControl.Drawing.PointF(862.1D, 73.75D),
			new NxtControl.Drawing.PointF(861.65D, 74.84D),
			new NxtControl.Drawing.PointF(861.5D, 76D)});
			// 
			// ft8
			// 
			this.ft8.Bounds = new NxtControl.Drawing.RectF(((float)(870.5D)), ((float)(74.5D)), ((float)(224D)), ((float)(3D)));
			this.ft8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft8.Name = "ft8";
			this.ft8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fa9
			// 
			this.fa9.Bounds = new NxtControl.Drawing.RectF(((float)(1091.5D)), ((float)(68.5D)), ((float)(15D)), ((float)(7.5D)));
			this.fa9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.fa9.Closed = true;
			this.fa9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fa9.Name = "fa9";
			this.fa9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fa9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1091.5D, 76D),
			new NxtControl.Drawing.PointF(1091.76D, 74.06D),
			new NxtControl.Drawing.PointF(1092.5D, 72.25D),
			new NxtControl.Drawing.PointF(1093.7D, 70.7D),
			new NxtControl.Drawing.PointF(1095.25D, 69.5D),
			new NxtControl.Drawing.PointF(1097.06D, 68.76D),
			new NxtControl.Drawing.PointF(1099D, 68.5D),
			new NxtControl.Drawing.PointF(1100.94D, 68.76D),
			new NxtControl.Drawing.PointF(1102.75D, 69.5D),
			new NxtControl.Drawing.PointF(1104.3D, 70.7D),
			new NxtControl.Drawing.PointF(1105.5D, 72.25D),
			new NxtControl.Drawing.PointF(1106.24D, 74.06D),
			new NxtControl.Drawing.PointF(1106.5D, 76D),
			new NxtControl.Drawing.PointF(1103.5D, 76D),
			new NxtControl.Drawing.PointF(1103.35D, 74.84D),
			new NxtControl.Drawing.PointF(1102.9D, 73.75D),
			new NxtControl.Drawing.PointF(1102.18D, 72.82D),
			new NxtControl.Drawing.PointF(1101.25D, 72.1D),
			new NxtControl.Drawing.PointF(1100.16D, 71.65D),
			new NxtControl.Drawing.PointF(1099D, 71.5D),
			new NxtControl.Drawing.PointF(1097.84D, 71.65D),
			new NxtControl.Drawing.PointF(1096.75D, 72.1D),
			new NxtControl.Drawing.PointF(1095.82D, 72.82D),
			new NxtControl.Drawing.PointF(1095.1D, 73.75D),
			new NxtControl.Drawing.PointF(1094.65D, 74.84D),
			new NxtControl.Drawing.PointF(1094.5D, 76D)});
			// 
			// ft10
			// 
			this.ft10.Bounds = new NxtControl.Drawing.RectF(((float)(1103.5D)), ((float)(74.5D)), ((float)(120D)), ((float)(3D)));
			this.ft10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft10.Name = "ft10";
			this.ft10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft11
			// 
			this.ft11.Bounds = new NxtControl.Drawing.RectF(((float)(754.5D)), ((float)(74.5D)), ((float)(3D)), ((float)(73D)));
			this.ft11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft11.Name = "ft11";
			this.ft11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr12
			// 
			this.fr12.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr12.Location = new NxtControl.Drawing.PointF(785D, 99D);
			this.fr12.Name = "fr12";
			this.fr12.Text = "SV-04";
			// 
			// ft13
			// 
			this.ft13.Bounds = new NxtControl.Drawing.RectF(((float)(987.5D)), ((float)(74.5D)), ((float)(3D)), ((float)(73D)));
			this.ft13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft13.Name = "ft13";
			this.ft13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr14
			// 
			this.fr14.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr14.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr14.Location = new NxtControl.Drawing.PointF(1018D, 99D);
			this.fr14.Name = "fr14";
			this.fr14.Text = "SV-06";
			// 
			// ft15
			// 
			this.ft15.Bounds = new NxtControl.Drawing.RectF(((float)(1220.5D)), ((float)(74.5D)), ((float)(3D)), ((float)(73D)));
			this.ft15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft15.Name = "ft15";
			this.ft15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr16
			// 
			this.fr16.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr16.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr16.Location = new NxtControl.Drawing.PointF(1251D, 99D);
			this.fr16.Name = "fr16";
			this.fr16.Text = "SV-08";
			// 
			// fr17
			// 
			this.fr17.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr17.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr17.Location = new NxtControl.Drawing.PointF(1112D, 284D);
			this.fr17.Name = "fr17";
			this.fr17.Text = "POLÍMERO";
			// 
			// ft18
			// 
			this.ft18.Bounds = new NxtControl.Drawing.RectF(((float)(1321.76D)), ((float)(535.38D)), ((float)(27.74D)), ((float)(3D)));
			this.ft18.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft18.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft18.Name = "ft18";
			this.ft18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft19
			// 
			this.ft19.Bounds = new NxtControl.Drawing.RectF(((float)(1346.5D)), ((float)(34.5D)), ((float)(3D)), ((float)(503.88D)));
			this.ft19.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft19.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft19.Name = "ft19";
			this.ft19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft20
			// 
			this.ft20.Bounds = new NxtControl.Drawing.RectF(((float)(631.5D)), ((float)(34.5D)), ((float)(718D)), ((float)(3D)));
			this.ft20.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft20.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft20.Name = "ft20";
			this.ft20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft21
			// 
			this.ft21.Bounds = new NxtControl.Drawing.RectF(((float)(631.5D)), ((float)(34.5D)), ((float)(3D)), ((float)(181.15D)));
			this.ft21.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft21.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft21.Name = "ft21";
			this.ft21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvr22
			// 
			this.fvr22.Bounds = new NxtControl.Drawing.RectF(((float)(628D)), ((float)(157D)), ((float)(10D)), ((float)(8D)));
			this.fvr22.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr22.Closed = true;
			this.fvr22.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr22.Name = "fvr22";
			this.fvr22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvr22.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(628D, 157D),
			new NxtControl.Drawing.PointF(638D, 157D),
			new NxtControl.Drawing.PointF(633D, 165D)});
			// 
			// fvr23
			// 
			this.fvr23.Bounds = new NxtControl.Drawing.RectF(((float)(628D)), ((float)(165D)), ((float)(10D)), ((float)(2D)));
			this.fvr23.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr23.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr23.Name = "fvr23";
			this.fvr23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm24
			// 
			this.fvm24.Bounds = new NxtControl.Drawing.RectF(((float)(1285D)), ((float)(31D)), ((float)(5D)), ((float)(10D)));
			this.fvm24.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm24.Closed = true;
			this.fvm24.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm24.Name = "fvm24";
			this.fvm24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm24.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1285D, 31D),
			new NxtControl.Drawing.PointF(1285D, 41D),
			new NxtControl.Drawing.PointF(1290D, 36D)});
			// 
			// fvm25
			// 
			this.fvm25.Bounds = new NxtControl.Drawing.RectF(((float)(1290D)), ((float)(31D)), ((float)(5D)), ((float)(10D)));
			this.fvm25.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm25.Closed = true;
			this.fvm25.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm25.Name = "fvm25";
			this.fvm25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm25.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1295D, 31D),
			new NxtControl.Drawing.PointF(1295D, 41D),
			new NxtControl.Drawing.PointF(1290D, 36D)});
			// 
			// fvm26
			// 
			this.fvm26.Bounds = new NxtControl.Drawing.RectF(((float)(1289.25D)), ((float)(32D)), ((float)(1.5D)), ((float)(8D)));
			this.fvm26.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm26.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm26.Name = "fvm26";
			this.fvm26.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr27
			// 
			this.fr27.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr27.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr27.Location = new NxtControl.Drawing.PointF(1278D, 20D);
			this.fr27.Name = "fr27";
			this.fr27.Text = "VA-14";
			// 
			// fs28
			// 
			this.fs28.Bounds = new NxtControl.Drawing.RectF(((float)(669D)), ((float)(32D)), ((float)(8D)), ((float)(8D)));
			this.fs28.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.fs28.Closed = true;
			this.fs28.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fs28.Name = "fs28";
			this.fs28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fs28.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(677D, 32D),
			new NxtControl.Drawing.PointF(669D, 36D),
			new NxtControl.Drawing.PointF(677D, 40D)});
			// 
			// ft29
			// 
			this.ft29.Bounds = new NxtControl.Drawing.RectF(((float)(1336.5D)), ((float)(46.5D)), ((float)(3D)), ((float)(491.88D)));
			this.ft29.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft29.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft29.Name = "ft29";
			this.ft29.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft30
			// 
			this.ft30.Bounds = new NxtControl.Drawing.RectF(((float)(864.5D)), ((float)(46.5D)), ((float)(475D)), ((float)(3D)));
			this.ft30.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft30.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft30.Name = "ft30";
			this.ft30.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft31
			// 
			this.ft31.Bounds = new NxtControl.Drawing.RectF(((float)(864.5D)), ((float)(46.5D)), ((float)(3D)), ((float)(169.15D)));
			this.ft31.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft31.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft31.Name = "ft31";
			this.ft31.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvr32
			// 
			this.fvr32.Bounds = new NxtControl.Drawing.RectF(((float)(861D)), ((float)(157D)), ((float)(10D)), ((float)(8D)));
			this.fvr32.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr32.Closed = true;
			this.fvr32.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr32.Name = "fvr32";
			this.fvr32.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvr32.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(861D, 157D),
			new NxtControl.Drawing.PointF(871D, 157D),
			new NxtControl.Drawing.PointF(866D, 165D)});
			// 
			// fvr33
			// 
			this.fvr33.Bounds = new NxtControl.Drawing.RectF(((float)(861D)), ((float)(165D)), ((float)(10D)), ((float)(2D)));
			this.fvr33.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr33.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr33.Name = "fvr33";
			this.fvr33.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm34
			// 
			this.fvm34.Bounds = new NxtControl.Drawing.RectF(((float)(1235D)), ((float)(43D)), ((float)(5D)), ((float)(10D)));
			this.fvm34.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm34.Closed = true;
			this.fvm34.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm34.Name = "fvm34";
			this.fvm34.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm34.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1235D, 43D),
			new NxtControl.Drawing.PointF(1235D, 53D),
			new NxtControl.Drawing.PointF(1240D, 48D)});
			// 
			// fvm35
			// 
			this.fvm35.Bounds = new NxtControl.Drawing.RectF(((float)(1240D)), ((float)(43D)), ((float)(5D)), ((float)(10D)));
			this.fvm35.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm35.Closed = true;
			this.fvm35.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm35.Name = "fvm35";
			this.fvm35.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm35.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1245D, 43D),
			new NxtControl.Drawing.PointF(1245D, 53D),
			new NxtControl.Drawing.PointF(1240D, 48D)});
			// 
			// fvm36
			// 
			this.fvm36.Bounds = new NxtControl.Drawing.RectF(((float)(1239.25D)), ((float)(44D)), ((float)(1.5D)), ((float)(8D)));
			this.fvm36.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm36.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm36.Name = "fvm36";
			this.fvm36.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr37
			// 
			this.fr37.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr37.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr37.Location = new NxtControl.Drawing.PointF(1228D, 20D);
			this.fr37.Name = "fr37";
			this.fr37.Text = "VA-15";
			// 
			// fs38
			// 
			this.fs38.Bounds = new NxtControl.Drawing.RectF(((float)(902D)), ((float)(44D)), ((float)(8D)), ((float)(8D)));
			this.fs38.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.fs38.Closed = true;
			this.fs38.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fs38.Name = "fs38";
			this.fs38.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fs38.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(910D, 44D),
			new NxtControl.Drawing.PointF(902D, 48D),
			new NxtControl.Drawing.PointF(910D, 52D)});
			// 
			// ft39
			// 
			this.ft39.Bounds = new NxtControl.Drawing.RectF(((float)(1326.5D)), ((float)(58.5D)), ((float)(3D)), ((float)(479.88D)));
			this.ft39.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft39.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft39.Name = "ft39";
			this.ft39.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft40
			// 
			this.ft40.Bounds = new NxtControl.Drawing.RectF(((float)(1097.5D)), ((float)(58.5D)), ((float)(232D)), ((float)(3D)));
			this.ft40.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft40.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft40.Name = "ft40";
			this.ft40.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft41
			// 
			this.ft41.Bounds = new NxtControl.Drawing.RectF(((float)(1097.5D)), ((float)(58.5D)), ((float)(3D)), ((float)(157.15D)));
			this.ft41.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.ft41.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft41.Name = "ft41";
			this.ft41.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvr42
			// 
			this.fvr42.Bounds = new NxtControl.Drawing.RectF(((float)(1094D)), ((float)(157D)), ((float)(10D)), ((float)(8D)));
			this.fvr42.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr42.Closed = true;
			this.fvr42.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr42.Name = "fvr42";
			this.fvr42.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvr42.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1094D, 157D),
			new NxtControl.Drawing.PointF(1104D, 157D),
			new NxtControl.Drawing.PointF(1099D, 165D)});
			// 
			// fvr43
			// 
			this.fvr43.Bounds = new NxtControl.Drawing.RectF(((float)(1094D)), ((float)(165D)), ((float)(10D)), ((float)(2D)));
			this.fvr43.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr43.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr43.Name = "fvr43";
			this.fvr43.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm44
			// 
			this.fvm44.Bounds = new NxtControl.Drawing.RectF(((float)(1185D)), ((float)(55D)), ((float)(5D)), ((float)(10D)));
			this.fvm44.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm44.Closed = true;
			this.fvm44.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm44.Name = "fvm44";
			this.fvm44.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm44.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1185D, 55D),
			new NxtControl.Drawing.PointF(1185D, 65D),
			new NxtControl.Drawing.PointF(1190D, 60D)});
			// 
			// fvm45
			// 
			this.fvm45.Bounds = new NxtControl.Drawing.RectF(((float)(1190D)), ((float)(55D)), ((float)(5D)), ((float)(10D)));
			this.fvm45.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm45.Closed = true;
			this.fvm45.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm45.Name = "fvm45";
			this.fvm45.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm45.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1195D, 55D),
			new NxtControl.Drawing.PointF(1195D, 65D),
			new NxtControl.Drawing.PointF(1190D, 60D)});
			// 
			// fvm46
			// 
			this.fvm46.Bounds = new NxtControl.Drawing.RectF(((float)(1189.25D)), ((float)(56D)), ((float)(1.5D)), ((float)(8D)));
			this.fvm46.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm46.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm46.Name = "fvm46";
			this.fvm46.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr47
			// 
			this.fr47.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr47.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr47.Location = new NxtControl.Drawing.PointF(1178D, 20D);
			this.fr47.Name = "fr47";
			this.fr47.Text = "VA-16";
			// 
			// fs48
			// 
			this.fs48.Bounds = new NxtControl.Drawing.RectF(((float)(1135D)), ((float)(56D)), ((float)(8D)), ((float)(8D)));
			this.fs48.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.fs48.Closed = true;
			this.fs48.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fs48.Name = "fs48";
			this.fs48.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fs48.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1143D, 56D),
			new NxtControl.Drawing.PointF(1135D, 60D),
			new NxtControl.Drawing.PointF(1143D, 64D)});
			// 
			// ft49
			// 
			this.ft49.Bounds = new NxtControl.Drawing.RectF(((float)(102.5D)), ((float)(273.5D)), ((float)(347D)), ((float)(5D)));
			this.ft49.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft49.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft49.Name = "ft49";
			this.ft49.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft50
			// 
			this.ft50.Bounds = new NxtControl.Drawing.RectF(((float)(346.9D)), ((float)(273.5D)), ((float)(5D)), ((float)(45.2D)));
			this.ft50.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft50.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft50.Name = "ft50";
			this.ft50.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm51
			// 
			this.fvm51.Bounds = new NxtControl.Drawing.RectF(((float)(262D)), ((float)(269D)), ((float)(7D)), ((float)(14D)));
			this.fvm51.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm51.Closed = true;
			this.fvm51.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm51.Name = "fvm51";
			this.fvm51.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm51.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(262D, 269D),
			new NxtControl.Drawing.PointF(262D, 283D),
			new NxtControl.Drawing.PointF(269D, 276D)});
			// 
			// fvm52
			// 
			this.fvm52.Bounds = new NxtControl.Drawing.RectF(((float)(269D)), ((float)(269D)), ((float)(7D)), ((float)(14D)));
			this.fvm52.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm52.Closed = true;
			this.fvm52.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm52.Name = "fvm52";
			this.fvm52.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm52.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(276D, 269D),
			new NxtControl.Drawing.PointF(276D, 283D),
			new NxtControl.Drawing.PointF(269D, 276D)});
			// 
			// fvm53
			// 
			this.fvm53.Bounds = new NxtControl.Drawing.RectF(((float)(268.25D)), ((float)(270D)), ((float)(1.5D)), ((float)(12D)));
			this.fvm53.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm53.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm53.Name = "fvm53";
			this.fvm53.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr54
			// 
			this.fr54.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr54.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr54.Location = new NxtControl.Drawing.PointF(258D, 258D);
			this.fr54.Name = "fr54";
			this.fr54.Text = "VA-03";
			// 
			// ft55
			// 
			this.ft55.Bounds = new NxtControl.Drawing.RectF(((float)(445.5D)), ((float)(274.5D)), ((float)(3D)), ((float)(60D)));
			this.ft55.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft55.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft55.Name = "ft55";
			this.ft55.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm56
			// 
			this.fvm56.Bounds = new NxtControl.Drawing.RectF(((float)(442D)), ((float)(299.5D)), ((float)(10D)), ((float)(5D)));
			this.fvm56.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm56.Closed = true;
			this.fvm56.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm56.Name = "fvm56";
			this.fvm56.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm56.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(442D, 299.5D),
			new NxtControl.Drawing.PointF(452D, 299.5D),
			new NxtControl.Drawing.PointF(447D, 304.5D)});
			// 
			// fvm57
			// 
			this.fvm57.Bounds = new NxtControl.Drawing.RectF(((float)(442D)), ((float)(304.5D)), ((float)(10D)), ((float)(5D)));
			this.fvm57.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm57.Closed = true;
			this.fvm57.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm57.Name = "fvm57";
			this.fvm57.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm57.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(442D, 309.5D),
			new NxtControl.Drawing.PointF(452D, 309.5D),
			new NxtControl.Drawing.PointF(447D, 304.5D)});
			// 
			// fvm58
			// 
			this.fvm58.Bounds = new NxtControl.Drawing.RectF(((float)(443D)), ((float)(303.75D)), ((float)(8D)), ((float)(1.5D)));
			this.fvm58.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm58.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm58.Name = "fvm58";
			this.fvm58.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fmo59
			// 
			this.fmo59.Bounds = new NxtControl.Drawing.RectF(((float)(452D)), ((float)(303.5D)), ((float)(11D)), ((float)(2D)));
			this.fmo59.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo59.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo59.Name = "fmo59";
			this.fmo59.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fmo60
			// 
			this.fmo60.Bounds = new NxtControl.Drawing.RectF(((float)(454D)), ((float)(299.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo60.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo60.Closed = true;
			this.fmo60.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo60.Name = "fmo60";
			this.fmo60.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo60.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(454D, 299.5D),
			new NxtControl.Drawing.PointF(455.5D, 299.5D),
			new NxtControl.Drawing.PointF(457D, 309.5D),
			new NxtControl.Drawing.PointF(455.5D, 309.5D)});
			// 
			// fmo61
			// 
			this.fmo61.Bounds = new NxtControl.Drawing.RectF(((float)(457D)), ((float)(299.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo61.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo61.Closed = true;
			this.fmo61.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo61.Name = "fmo61";
			this.fmo61.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo61.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(457D, 299.5D),
			new NxtControl.Drawing.PointF(458.5D, 299.5D),
			new NxtControl.Drawing.PointF(460D, 309.5D),
			new NxtControl.Drawing.PointF(458.5D, 309.5D)});
			// 
			// fmo62
			// 
			this.fmo62.Bounds = new NxtControl.Drawing.RectF(((float)(460D)), ((float)(299.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo62.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo62.Closed = true;
			this.fmo62.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo62.Name = "fmo62";
			this.fmo62.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo62.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(460D, 299.5D),
			new NxtControl.Drawing.PointF(461.5D, 299.5D),
			new NxtControl.Drawing.PointF(463D, 309.5D),
			new NxtControl.Drawing.PointF(461.5D, 309.5D)});
			// 
			// ft63
			// 
			this.ft63.Bounds = new NxtControl.Drawing.RectF(((float)(412D)), ((float)(330.5D)), ((float)(136.5D)), ((float)(5D)));
			this.ft63.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft63.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft63.Name = "ft63";
			this.ft63.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr64
			// 
			this.fr64.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr64.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr64.Location = new NxtControl.Drawing.PointF(484D, 357D);
			this.fr64.Name = "fr64";
			this.fr64.Text = "VA-06";
			// 
			// fr65
			// 
			this.fr65.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr65.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr65.Location = new NxtControl.Drawing.PointF(239D, 314D);
			this.fr65.Name = "fr65";
			this.fr65.Text = "BO-01";
			// 
			// ft66
			// 
			this.ft66.Bounds = new NxtControl.Drawing.RectF(((float)(102.5D)), ((float)(385.5D)), ((float)(347D)), ((float)(5D)));
			this.ft66.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft66.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft66.Name = "ft66";
			this.ft66.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft67
			// 
			this.ft67.Bounds = new NxtControl.Drawing.RectF(((float)(346.9D)), ((float)(385.5D)), ((float)(5D)), ((float)(45.2D)));
			this.ft67.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft67.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft67.Name = "ft67";
			this.ft67.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm68
			// 
			this.fvm68.Bounds = new NxtControl.Drawing.RectF(((float)(262D)), ((float)(381D)), ((float)(7D)), ((float)(14D)));
			this.fvm68.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm68.Closed = true;
			this.fvm68.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm68.Name = "fvm68";
			this.fvm68.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm68.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(262D, 381D),
			new NxtControl.Drawing.PointF(262D, 395D),
			new NxtControl.Drawing.PointF(269D, 388D)});
			// 
			// fvm69
			// 
			this.fvm69.Bounds = new NxtControl.Drawing.RectF(((float)(269D)), ((float)(381D)), ((float)(7D)), ((float)(14D)));
			this.fvm69.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm69.Closed = true;
			this.fvm69.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm69.Name = "fvm69";
			this.fvm69.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm69.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(276D, 381D),
			new NxtControl.Drawing.PointF(276D, 395D),
			new NxtControl.Drawing.PointF(269D, 388D)});
			// 
			// fvm70
			// 
			this.fvm70.Bounds = new NxtControl.Drawing.RectF(((float)(268.25D)), ((float)(382D)), ((float)(1.5D)), ((float)(12D)));
			this.fvm70.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm70.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm70.Name = "fvm70";
			this.fvm70.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr71
			// 
			this.fr71.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr71.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr71.Location = new NxtControl.Drawing.PointF(258D, 370D);
			this.fr71.Name = "fr71";
			this.fr71.Text = "VA-04";
			// 
			// ft72
			// 
			this.ft72.Bounds = new NxtControl.Drawing.RectF(((float)(445.5D)), ((float)(386.5D)), ((float)(3D)), ((float)(60D)));
			this.ft72.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft72.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft72.Name = "ft72";
			this.ft72.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm73
			// 
			this.fvm73.Bounds = new NxtControl.Drawing.RectF(((float)(442D)), ((float)(411.5D)), ((float)(10D)), ((float)(5D)));
			this.fvm73.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm73.Closed = true;
			this.fvm73.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm73.Name = "fvm73";
			this.fvm73.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm73.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(442D, 411.5D),
			new NxtControl.Drawing.PointF(452D, 411.5D),
			new NxtControl.Drawing.PointF(447D, 416.5D)});
			// 
			// fvm74
			// 
			this.fvm74.Bounds = new NxtControl.Drawing.RectF(((float)(442D)), ((float)(416.5D)), ((float)(10D)), ((float)(5D)));
			this.fvm74.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm74.Closed = true;
			this.fvm74.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm74.Name = "fvm74";
			this.fvm74.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm74.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(442D, 421.5D),
			new NxtControl.Drawing.PointF(452D, 421.5D),
			new NxtControl.Drawing.PointF(447D, 416.5D)});
			// 
			// fvm75
			// 
			this.fvm75.Bounds = new NxtControl.Drawing.RectF(((float)(443D)), ((float)(415.75D)), ((float)(8D)), ((float)(1.5D)));
			this.fvm75.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm75.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm75.Name = "fvm75";
			this.fvm75.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fmo76
			// 
			this.fmo76.Bounds = new NxtControl.Drawing.RectF(((float)(452D)), ((float)(415.5D)), ((float)(11D)), ((float)(2D)));
			this.fmo76.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo76.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo76.Name = "fmo76";
			this.fmo76.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fmo77
			// 
			this.fmo77.Bounds = new NxtControl.Drawing.RectF(((float)(454D)), ((float)(411.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo77.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo77.Closed = true;
			this.fmo77.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo77.Name = "fmo77";
			this.fmo77.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo77.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(454D, 411.5D),
			new NxtControl.Drawing.PointF(455.5D, 411.5D),
			new NxtControl.Drawing.PointF(457D, 421.5D),
			new NxtControl.Drawing.PointF(455.5D, 421.5D)});
			// 
			// fmo78
			// 
			this.fmo78.Bounds = new NxtControl.Drawing.RectF(((float)(457D)), ((float)(411.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo78.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo78.Closed = true;
			this.fmo78.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo78.Name = "fmo78";
			this.fmo78.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo78.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(457D, 411.5D),
			new NxtControl.Drawing.PointF(458.5D, 411.5D),
			new NxtControl.Drawing.PointF(460D, 421.5D),
			new NxtControl.Drawing.PointF(458.5D, 421.5D)});
			// 
			// fmo79
			// 
			this.fmo79.Bounds = new NxtControl.Drawing.RectF(((float)(460D)), ((float)(411.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo79.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo79.Closed = true;
			this.fmo79.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo79.Name = "fmo79";
			this.fmo79.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo79.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(460D, 411.5D),
			new NxtControl.Drawing.PointF(461.5D, 411.5D),
			new NxtControl.Drawing.PointF(463D, 421.5D),
			new NxtControl.Drawing.PointF(461.5D, 421.5D)});
			// 
			// ft80
			// 
			this.ft80.Bounds = new NxtControl.Drawing.RectF(((float)(412D)), ((float)(442.5D)), ((float)(136.5D)), ((float)(5D)));
			this.ft80.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft80.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft80.Name = "ft80";
			this.ft80.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr81
			// 
			this.fr81.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr81.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr81.Location = new NxtControl.Drawing.PointF(484D, 469D);
			this.fr81.Name = "fr81";
			this.fr81.Text = "VA-07";
			// 
			// fr82
			// 
			this.fr82.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr82.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr82.Location = new NxtControl.Drawing.PointF(239D, 426D);
			this.fr82.Name = "fr82";
			this.fr82.Text = "BO-02";
			// 
			// ft83
			// 
			this.ft83.Bounds = new NxtControl.Drawing.RectF(((float)(102.5D)), ((float)(497.5D)), ((float)(347D)), ((float)(5D)));
			this.ft83.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft83.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft83.Name = "ft83";
			this.ft83.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft84
			// 
			this.ft84.Bounds = new NxtControl.Drawing.RectF(((float)(346.9D)), ((float)(497.5D)), ((float)(5D)), ((float)(45.2D)));
			this.ft84.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft84.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft84.Name = "ft84";
			this.ft84.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm85
			// 
			this.fvm85.Bounds = new NxtControl.Drawing.RectF(((float)(262D)), ((float)(493D)), ((float)(7D)), ((float)(14D)));
			this.fvm85.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm85.Closed = true;
			this.fvm85.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm85.Name = "fvm85";
			this.fvm85.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm85.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(262D, 493D),
			new NxtControl.Drawing.PointF(262D, 507D),
			new NxtControl.Drawing.PointF(269D, 500D)});
			// 
			// fvm86
			// 
			this.fvm86.Bounds = new NxtControl.Drawing.RectF(((float)(269D)), ((float)(493D)), ((float)(7D)), ((float)(14D)));
			this.fvm86.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm86.Closed = true;
			this.fvm86.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm86.Name = "fvm86";
			this.fvm86.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm86.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(276D, 493D),
			new NxtControl.Drawing.PointF(276D, 507D),
			new NxtControl.Drawing.PointF(269D, 500D)});
			// 
			// fvm87
			// 
			this.fvm87.Bounds = new NxtControl.Drawing.RectF(((float)(268.25D)), ((float)(494D)), ((float)(1.5D)), ((float)(12D)));
			this.fvm87.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm87.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm87.Name = "fvm87";
			this.fvm87.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr88
			// 
			this.fr88.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr88.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr88.Location = new NxtControl.Drawing.PointF(258D, 482D);
			this.fr88.Name = "fr88";
			this.fr88.Text = "VA-05";
			// 
			// ft89
			// 
			this.ft89.Bounds = new NxtControl.Drawing.RectF(((float)(445.5D)), ((float)(498.5D)), ((float)(3D)), ((float)(60D)));
			this.ft89.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft89.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft89.Name = "ft89";
			this.ft89.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm90
			// 
			this.fvm90.Bounds = new NxtControl.Drawing.RectF(((float)(442D)), ((float)(523.5D)), ((float)(10D)), ((float)(5D)));
			this.fvm90.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm90.Closed = true;
			this.fvm90.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm90.Name = "fvm90";
			this.fvm90.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm90.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(442D, 523.5D),
			new NxtControl.Drawing.PointF(452D, 523.5D),
			new NxtControl.Drawing.PointF(447D, 528.5D)});
			// 
			// fvm91
			// 
			this.fvm91.Bounds = new NxtControl.Drawing.RectF(((float)(442D)), ((float)(528.5D)), ((float)(10D)), ((float)(5D)));
			this.fvm91.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm91.Closed = true;
			this.fvm91.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm91.Name = "fvm91";
			this.fvm91.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm91.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(442D, 533.5D),
			new NxtControl.Drawing.PointF(452D, 533.5D),
			new NxtControl.Drawing.PointF(447D, 528.5D)});
			// 
			// fvm92
			// 
			this.fvm92.Bounds = new NxtControl.Drawing.RectF(((float)(443D)), ((float)(527.75D)), ((float)(8D)), ((float)(1.5D)));
			this.fvm92.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm92.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm92.Name = "fvm92";
			this.fvm92.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fmo93
			// 
			this.fmo93.Bounds = new NxtControl.Drawing.RectF(((float)(452D)), ((float)(527.5D)), ((float)(11D)), ((float)(2D)));
			this.fmo93.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo93.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo93.Name = "fmo93";
			this.fmo93.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fmo94
			// 
			this.fmo94.Bounds = new NxtControl.Drawing.RectF(((float)(454D)), ((float)(523.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo94.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo94.Closed = true;
			this.fmo94.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo94.Name = "fmo94";
			this.fmo94.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo94.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(454D, 523.5D),
			new NxtControl.Drawing.PointF(455.5D, 523.5D),
			new NxtControl.Drawing.PointF(457D, 533.5D),
			new NxtControl.Drawing.PointF(455.5D, 533.5D)});
			// 
			// fmo95
			// 
			this.fmo95.Bounds = new NxtControl.Drawing.RectF(((float)(457D)), ((float)(523.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo95.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo95.Closed = true;
			this.fmo95.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo95.Name = "fmo95";
			this.fmo95.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo95.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(457D, 523.5D),
			new NxtControl.Drawing.PointF(458.5D, 523.5D),
			new NxtControl.Drawing.PointF(460D, 533.5D),
			new NxtControl.Drawing.PointF(458.5D, 533.5D)});
			// 
			// fmo96
			// 
			this.fmo96.Bounds = new NxtControl.Drawing.RectF(((float)(460D)), ((float)(523.5D)), ((float)(3D)), ((float)(10D)));
			this.fmo96.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fmo96.Closed = true;
			this.fmo96.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fmo96.Name = "fmo96";
			this.fmo96.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fmo96.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(460D, 523.5D),
			new NxtControl.Drawing.PointF(461.5D, 523.5D),
			new NxtControl.Drawing.PointF(463D, 533.5D),
			new NxtControl.Drawing.PointF(461.5D, 533.5D)});
			// 
			// ft97
			// 
			this.ft97.Bounds = new NxtControl.Drawing.RectF(((float)(412D)), ((float)(554.5D)), ((float)(136.5D)), ((float)(5D)));
			this.ft97.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft97.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft97.Name = "ft97";
			this.ft97.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr98
			// 
			this.fr98.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr98.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr98.Location = new NxtControl.Drawing.PointF(484D, 581D);
			this.fr98.Name = "fr98";
			this.fr98.Text = "VA-08";
			// 
			// fr99
			// 
			this.fr99.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr99.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr99.Location = new NxtControl.Drawing.PointF(239D, 538D);
			this.fr99.Name = "fr99";
			this.fr99.Text = "BO-03";
			// 
			// ft100
			// 
			this.ft100.Bounds = new NxtControl.Drawing.RectF(((float)(543.5D)), ((float)(330.5D)), ((float)(5D)), ((float)(229D)));
			this.ft100.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft100.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft100.Name = "ft100";
			this.ft100.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft101
			// 
			this.ft101.Bounds = new NxtControl.Drawing.RectF(((float)(543.5D)), ((float)(554.5D)), ((float)(5D)), ((float)(69D)));
			this.ft101.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.ft101.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft101.Name = "ft101";
			this.ft101.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr102
			// 
			this.fr102.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr102.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr102.Location = new NxtControl.Drawing.PointF(575D, 384D);
			this.fr102.Name = "fr102";
			this.fr102.Text = "VA-09";
			// 
			// fr103
			// 
			this.fr103.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr103.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr103.Location = new NxtControl.Drawing.PointF(575D, 496D);
			this.fr103.Name = "fr103";
			this.fr103.Text = "VA-10";
			// 
			// fr104
			// 
			this.fr104.Color = new NxtControl.Drawing.Color(((byte)(140)), ((byte)(140)), ((byte)(140)));
			this.fr104.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr104.Location = new NxtControl.Drawing.PointF(575D, 584D);
			this.fr104.Name = "fr104";
			this.fr104.Text = "VA-12";
			// 
			// ft105
			// 
			this.ft105.Bounds = new NxtControl.Drawing.RectF(((float)(543.5D)), ((float)(330.5D)), ((float)(92D)), ((float)(5D)));
			this.ft105.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft105.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft105.Name = "ft105";
			this.ft105.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft106
			// 
			this.ft106.Bounds = new NxtControl.Drawing.RectF(((float)(630.5D)), ((float)(213.65D)), ((float)(5D)), ((float)(121.85D)));
			this.ft106.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft106.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft106.Name = "ft106";
			this.ft106.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft107
			// 
			this.ft107.Bounds = new NxtControl.Drawing.RectF(((float)(630.5D)), ((float)(213.65D)), ((float)(22D)), ((float)(5D)));
			this.ft107.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft107.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft107.Name = "ft107";
			this.ft107.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft108
			// 
			this.ft108.Bounds = new NxtControl.Drawing.RectF(((float)(543.5D)), ((float)(554.5D)), ((float)(325D)), ((float)(5D)));
			this.ft108.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft108.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft108.Name = "ft108";
			this.ft108.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft109
			// 
			this.ft109.Bounds = new NxtControl.Drawing.RectF(((float)(863.5D)), ((float)(213.65D)), ((float)(5D)), ((float)(345.85D)));
			this.ft109.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft109.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft109.Name = "ft109";
			this.ft109.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft110
			// 
			this.ft110.Bounds = new NxtControl.Drawing.RectF(((float)(863.5D)), ((float)(213.65D)), ((float)(22D)), ((float)(5D)));
			this.ft110.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft110.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft110.Name = "ft110";
			this.ft110.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft111
			// 
			this.ft111.Bounds = new NxtControl.Drawing.RectF(((float)(543.5D)), ((float)(618.5D)), ((float)(558D)), ((float)(5D)));
			this.ft111.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.ft111.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft111.Name = "ft111";
			this.ft111.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft112
			// 
			this.ft112.Bounds = new NxtControl.Drawing.RectF(((float)(1096.5D)), ((float)(213.65D)), ((float)(5D)), ((float)(409.85D)));
			this.ft112.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.ft112.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft112.Name = "ft112";
			this.ft112.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft113
			// 
			this.ft113.Bounds = new NxtControl.Drawing.RectF(((float)(1096.5D)), ((float)(213.65D)), ((float)(22D)), ((float)(5D)));
			this.ft113.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.ft113.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft113.Name = "ft113";
			this.ft113.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr114
			// 
			this.fr114.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr114.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr114.Location = new NxtControl.Drawing.PointF(593D, 291D);
			this.fr114.Name = "fr114";
			this.fr114.Text = "VA-11";
			// 
			// fr115
			// 
			this.fr115.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr115.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr115.Location = new NxtControl.Drawing.PointF(593D, 515D);
			this.fr115.Name = "fr115";
			this.fr115.Text = "VA-13";
			// 
			// ft116
			// 
			this.ft116.Bounds = new NxtControl.Drawing.RectF(((float)(12.5D)), ((float)(148.5D)), ((float)(219D)), ((float)(3D)));
			this.ft116.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft116.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft116.Name = "ft116";
			this.ft116.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft117
			// 
			this.ft117.Bounds = new NxtControl.Drawing.RectF(((float)(118.5D)), ((float)(148.5D)), ((float)(3D)), ((float)(129D)));
			this.ft117.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft117.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft117.Name = "ft117";
			this.ft117.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm118
			// 
			this.fvm118.Bounds = new NxtControl.Drawing.RectF(((float)(114D)), ((float)(160D)), ((float)(12D)), ((float)(6D)));
			this.fvm118.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm118.Closed = true;
			this.fvm118.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm118.Name = "fvm118";
			this.fvm118.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm118.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(114D, 160D),
			new NxtControl.Drawing.PointF(126D, 160D),
			new NxtControl.Drawing.PointF(120D, 166D)});
			// 
			// fvm119
			// 
			this.fvm119.Bounds = new NxtControl.Drawing.RectF(((float)(114D)), ((float)(166D)), ((float)(12D)), ((float)(6D)));
			this.fvm119.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm119.Closed = true;
			this.fvm119.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm119.Name = "fvm119";
			this.fvm119.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm119.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(114D, 172D),
			new NxtControl.Drawing.PointF(126D, 172D),
			new NxtControl.Drawing.PointF(120D, 166D)});
			// 
			// fvm120
			// 
			this.fvm120.Bounds = new NxtControl.Drawing.RectF(((float)(115D)), ((float)(165.25D)), ((float)(10D)), ((float)(1.5D)));
			this.fvm120.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm120.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm120.Name = "fvm120";
			this.fvm120.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr121
			// 
			this.fr121.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr121.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr121.Location = new NxtControl.Drawing.PointF(124D, 226D);
			this.fr121.Name = "fr121";
			this.fr121.Text = "SV-03";
			// 
			// ft122
			// 
			this.ft122.Bounds = new NxtControl.Drawing.RectF(((float)(173.5D)), ((float)(148.5D)), ((float)(3D)), ((float)(123D)));
			this.ft122.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft122.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft122.Name = "ft122";
			this.ft122.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fa123
			// 
			this.fa123.Bounds = new NxtControl.Drawing.RectF(((float)(175D)), ((float)(268.5D)), ((float)(7.5D)), ((float)(15D)));
			this.fa123.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.fa123.Closed = true;
			this.fa123.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fa123.Name = "fa123";
			this.fa123.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fa123.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(175D, 268.5D),
			new NxtControl.Drawing.PointF(176.94D, 268.76D),
			new NxtControl.Drawing.PointF(178.75D, 269.5D),
			new NxtControl.Drawing.PointF(180.3D, 270.7D),
			new NxtControl.Drawing.PointF(181.5D, 272.25D),
			new NxtControl.Drawing.PointF(182.24D, 274.06D),
			new NxtControl.Drawing.PointF(182.5D, 276D),
			new NxtControl.Drawing.PointF(182.24D, 277.94D),
			new NxtControl.Drawing.PointF(181.5D, 279.75D),
			new NxtControl.Drawing.PointF(180.3D, 281.3D),
			new NxtControl.Drawing.PointF(178.75D, 282.5D),
			new NxtControl.Drawing.PointF(176.94D, 283.24D),
			new NxtControl.Drawing.PointF(175D, 283.5D),
			new NxtControl.Drawing.PointF(175D, 280.5D),
			new NxtControl.Drawing.PointF(176.16D, 280.35D),
			new NxtControl.Drawing.PointF(177.25D, 279.9D),
			new NxtControl.Drawing.PointF(178.18D, 279.18D),
			new NxtControl.Drawing.PointF(178.9D, 278.25D),
			new NxtControl.Drawing.PointF(179.35D, 277.16D),
			new NxtControl.Drawing.PointF(179.5D, 276D),
			new NxtControl.Drawing.PointF(179.35D, 274.84D),
			new NxtControl.Drawing.PointF(178.9D, 273.75D),
			new NxtControl.Drawing.PointF(178.18D, 272.82D),
			new NxtControl.Drawing.PointF(177.25D, 272.1D),
			new NxtControl.Drawing.PointF(176.16D, 271.65D),
			new NxtControl.Drawing.PointF(175D, 271.5D)});
			// 
			// ft124
			// 
			this.ft124.Bounds = new NxtControl.Drawing.RectF(((float)(173.5D)), ((float)(280.5D)), ((float)(3D)), ((float)(109D)));
			this.ft124.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft124.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft124.Name = "ft124";
			this.ft124.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm125
			// 
			this.fvm125.Bounds = new NxtControl.Drawing.RectF(((float)(169D)), ((float)(160D)), ((float)(12D)), ((float)(6D)));
			this.fvm125.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm125.Closed = true;
			this.fvm125.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm125.Name = "fvm125";
			this.fvm125.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm125.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(169D, 160D),
			new NxtControl.Drawing.PointF(181D, 160D),
			new NxtControl.Drawing.PointF(175D, 166D)});
			// 
			// fvm126
			// 
			this.fvm126.Bounds = new NxtControl.Drawing.RectF(((float)(169D)), ((float)(166D)), ((float)(12D)), ((float)(6D)));
			this.fvm126.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm126.Closed = true;
			this.fvm126.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm126.Name = "fvm126";
			this.fvm126.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm126.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(169D, 172D),
			new NxtControl.Drawing.PointF(181D, 172D),
			new NxtControl.Drawing.PointF(175D, 166D)});
			// 
			// fvm127
			// 
			this.fvm127.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(165.25D)), ((float)(10D)), ((float)(1.5D)));
			this.fvm127.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm127.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm127.Name = "fvm127";
			this.fvm127.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr128
			// 
			this.fr128.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr128.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr128.Location = new NxtControl.Drawing.PointF(179D, 226D);
			this.fr128.Name = "fr128";
			this.fr128.Text = "SV-02";
			// 
			// ft129
			// 
			this.ft129.Bounds = new NxtControl.Drawing.RectF(((float)(228.5D)), ((float)(148.5D)), ((float)(3D)), ((float)(123D)));
			this.ft129.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft129.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft129.Name = "ft129";
			this.ft129.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fa130
			// 
			this.fa130.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(268.5D)), ((float)(7.5D)), ((float)(15D)));
			this.fa130.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.fa130.Closed = true;
			this.fa130.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fa130.Name = "fa130";
			this.fa130.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fa130.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(230D, 268.5D),
			new NxtControl.Drawing.PointF(231.94D, 268.76D),
			new NxtControl.Drawing.PointF(233.75D, 269.5D),
			new NxtControl.Drawing.PointF(235.3D, 270.7D),
			new NxtControl.Drawing.PointF(236.5D, 272.25D),
			new NxtControl.Drawing.PointF(237.24D, 274.06D),
			new NxtControl.Drawing.PointF(237.5D, 276D),
			new NxtControl.Drawing.PointF(237.24D, 277.94D),
			new NxtControl.Drawing.PointF(236.5D, 279.75D),
			new NxtControl.Drawing.PointF(235.3D, 281.3D),
			new NxtControl.Drawing.PointF(233.75D, 282.5D),
			new NxtControl.Drawing.PointF(231.94D, 283.24D),
			new NxtControl.Drawing.PointF(230D, 283.5D),
			new NxtControl.Drawing.PointF(230D, 280.5D),
			new NxtControl.Drawing.PointF(231.16D, 280.35D),
			new NxtControl.Drawing.PointF(232.25D, 279.9D),
			new NxtControl.Drawing.PointF(233.18D, 279.18D),
			new NxtControl.Drawing.PointF(233.9D, 278.25D),
			new NxtControl.Drawing.PointF(234.35D, 277.16D),
			new NxtControl.Drawing.PointF(234.5D, 276D),
			new NxtControl.Drawing.PointF(234.35D, 274.84D),
			new NxtControl.Drawing.PointF(233.9D, 273.75D),
			new NxtControl.Drawing.PointF(233.18D, 272.82D),
			new NxtControl.Drawing.PointF(232.25D, 272.1D),
			new NxtControl.Drawing.PointF(231.16D, 271.65D),
			new NxtControl.Drawing.PointF(230D, 271.5D)});
			// 
			// ft131
			// 
			this.ft131.Bounds = new NxtControl.Drawing.RectF(((float)(228.5D)), ((float)(280.5D)), ((float)(3D)), ((float)(103D)));
			this.ft131.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft131.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft131.Name = "ft131";
			this.ft131.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fa132
			// 
			this.fa132.Bounds = new NxtControl.Drawing.RectF(((float)(230D)), ((float)(380.5D)), ((float)(7.5D)), ((float)(15D)));
			this.fa132.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.fa132.Closed = true;
			this.fa132.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fa132.Name = "fa132";
			this.fa132.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fa132.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(230D, 380.5D),
			new NxtControl.Drawing.PointF(231.94D, 380.76D),
			new NxtControl.Drawing.PointF(233.75D, 381.5D),
			new NxtControl.Drawing.PointF(235.3D, 382.7D),
			new NxtControl.Drawing.PointF(236.5D, 384.25D),
			new NxtControl.Drawing.PointF(237.24D, 386.06D),
			new NxtControl.Drawing.PointF(237.5D, 388D),
			new NxtControl.Drawing.PointF(237.24D, 389.94D),
			new NxtControl.Drawing.PointF(236.5D, 391.75D),
			new NxtControl.Drawing.PointF(235.3D, 393.3D),
			new NxtControl.Drawing.PointF(233.75D, 394.5D),
			new NxtControl.Drawing.PointF(231.94D, 395.24D),
			new NxtControl.Drawing.PointF(230D, 395.5D),
			new NxtControl.Drawing.PointF(230D, 392.5D),
			new NxtControl.Drawing.PointF(231.16D, 392.35D),
			new NxtControl.Drawing.PointF(232.25D, 391.9D),
			new NxtControl.Drawing.PointF(233.18D, 391.18D),
			new NxtControl.Drawing.PointF(233.9D, 390.25D),
			new NxtControl.Drawing.PointF(234.35D, 389.16D),
			new NxtControl.Drawing.PointF(234.5D, 388D),
			new NxtControl.Drawing.PointF(234.35D, 386.84D),
			new NxtControl.Drawing.PointF(233.9D, 385.75D),
			new NxtControl.Drawing.PointF(233.18D, 384.82D),
			new NxtControl.Drawing.PointF(232.25D, 384.1D),
			new NxtControl.Drawing.PointF(231.16D, 383.65D),
			new NxtControl.Drawing.PointF(230D, 383.5D)});
			// 
			// ft133
			// 
			this.ft133.Bounds = new NxtControl.Drawing.RectF(((float)(228.5D)), ((float)(392.5D)), ((float)(3D)), ((float)(109D)));
			this.ft133.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft133.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft133.Name = "ft133";
			this.ft133.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm134
			// 
			this.fvm134.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(160D)), ((float)(12D)), ((float)(6D)));
			this.fvm134.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm134.Closed = true;
			this.fvm134.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm134.Name = "fvm134";
			this.fvm134.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm134.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(224D, 160D),
			new NxtControl.Drawing.PointF(236D, 160D),
			new NxtControl.Drawing.PointF(230D, 166D)});
			// 
			// fvm135
			// 
			this.fvm135.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(166D)), ((float)(12D)), ((float)(6D)));
			this.fvm135.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm135.Closed = true;
			this.fvm135.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm135.Name = "fvm135";
			this.fvm135.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm135.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(224D, 172D),
			new NxtControl.Drawing.PointF(236D, 172D),
			new NxtControl.Drawing.PointF(230D, 166D)});
			// 
			// fvm136
			// 
			this.fvm136.Bounds = new NxtControl.Drawing.RectF(((float)(225D)), ((float)(165.25D)), ((float)(10D)), ((float)(1.5D)));
			this.fvm136.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm136.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm136.Name = "fvm136";
			this.fvm136.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr137
			// 
			this.fr137.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr137.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr137.Location = new NxtControl.Drawing.PointF(234D, 226D);
			this.fr137.Name = "fr137";
			this.fr137.Text = "SV-01";
			// 
			// irEstoc
			// 
			this.irEstoc.Bounds = new NxtControl.Drawing.RectF(((float)(18D)), ((float)(263D)), ((float)(80D)), ((float)(26D)));
			this.irEstoc.CanvasName = "ESTOCAGEM_LODO";
			this.irEstoc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irEstoc.Name = "irEstoc";
			this.irEstoc.Text = "‹ Estocagem";
			// 
			// ft138
			// 
			this.ft138.Bounds = new NxtControl.Drawing.RectF(((float)(98.5D)), ((float)(273.5D)), ((float)(9D)), ((float)(5D)));
			this.ft138.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft138.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft138.Name = "ft138";
			this.ft138.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft139
			// 
			this.ft139.Bounds = new NxtControl.Drawing.RectF(((float)(102.5D)), ((float)(273.5D)), ((float)(5D)), ((float)(229D)));
			this.ft139.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.ft139.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft139.Name = "ft139";
			this.ft139.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft140
			// 
			this.ft140.Bounds = new NxtControl.Drawing.RectF(((float)(632.5D)), ((float)(287.1D)), ((float)(9D)), ((float)(1D)));
			this.ft140.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.ft140.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft140.Name = "ft140";
			this.ft140.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr141
			// 
			this.fr141.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr141.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr141.Location = new NxtControl.Drawing.PointF(641D, 265D);
			this.fr141.Name = "fr141";
			this.fr141.Text = "FT-01";
			// 
			// ft142
			// 
			this.ft142.Bounds = new NxtControl.Drawing.RectF(((float)(865.5D)), ((float)(339.1D)), ((float)(9D)), ((float)(1D)));
			this.ft142.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.ft142.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft142.Name = "ft142";
			this.ft142.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr143
			// 
			this.fr143.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr143.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr143.Location = new NxtControl.Drawing.PointF(874D, 317D);
			this.fr143.Name = "fr143";
			this.fr143.Text = "FT-02";
			// 
			// ft144
			// 
			this.ft144.Bounds = new NxtControl.Drawing.RectF(((float)(1090.5D)), ((float)(429.1D)), ((float)(9D)), ((float)(1D)));
			this.ft144.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.ft144.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft144.Name = "ft144";
			this.ft144.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr145
			// 
			this.fr145.Color = new NxtControl.Drawing.Color(((byte)(140)), ((byte)(140)), ((byte)(140)));
			this.fr145.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr145.Location = new NxtControl.Drawing.PointF(971D, 407D);
			this.fr145.Name = "fr145";
			this.fr145.Text = "FT-03";
			// 
			// fr146
			// 
			this.fr146.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr146.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr146.Location = new NxtControl.Drawing.PointF(22D, 524D);
			this.fr146.Name = "fr146";
			this.fr146.Text = "BOOSTER DE LAVAGEM";
			// 
			// fr147
			// 
			this.fr147.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr147.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.fr147.Location = new NxtControl.Drawing.PointF(242D, 646D);
			this.fr147.Name = "fr147";
			this.fr147.Text = "Água de serviço";
			// 
			// ft148
			// 
			this.ft148.Bounds = new NxtControl.Drawing.RectF(((float)(18.5D)), ((float)(650.5D)), ((float)(133D)), ((float)(3D)));
			this.ft148.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft148.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft148.Name = "ft148";
			this.ft148.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft149
			// 
			this.ft149.Bounds = new NxtControl.Drawing.RectF(((float)(34D)), ((float)(618.85D)), ((float)(3D)), ((float)(34.65D)));
			this.ft149.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft149.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft149.Name = "ft149";
			this.ft149.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft150
			// 
			this.ft150.Bounds = new NxtControl.Drawing.RectF(((float)(34D)), ((float)(618.85D)), ((float)(13D)), ((float)(3D)));
			this.ft150.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft150.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft150.Name = "ft150";
			this.ft150.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm151
			// 
			this.fvm151.Bounds = new NxtControl.Drawing.RectF(((float)(30.5D)), ((float)(631D)), ((float)(10D)), ((float)(5D)));
			this.fvm151.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm151.Closed = true;
			this.fvm151.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm151.Name = "fvm151";
			this.fvm151.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm151.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(30.5D, 631D),
			new NxtControl.Drawing.PointF(40.5D, 631D),
			new NxtControl.Drawing.PointF(35.5D, 636D)});
			// 
			// fvm152
			// 
			this.fvm152.Bounds = new NxtControl.Drawing.RectF(((float)(30.5D)), ((float)(636D)), ((float)(10D)), ((float)(5D)));
			this.fvm152.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm152.Closed = true;
			this.fvm152.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm152.Name = "fvm152";
			this.fvm152.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm152.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(30.5D, 641D),
			new NxtControl.Drawing.PointF(40.5D, 641D),
			new NxtControl.Drawing.PointF(35.5D, 636D)});
			// 
			// fvm153
			// 
			this.fvm153.Bounds = new NxtControl.Drawing.RectF(((float)(31.5D)), ((float)(635.25D)), ((float)(8D)), ((float)(1.5D)));
			this.fvm153.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm153.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm153.Name = "fvm153";
			this.fvm153.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft154
			// 
			this.ft154.Bounds = new NxtControl.Drawing.RectF(((float)(81.5D)), ((float)(603.7D)), ((float)(27D)), ((float)(3D)));
			this.ft154.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft154.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft154.Name = "ft154";
			this.ft154.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft155
			// 
			this.ft155.Bounds = new NxtControl.Drawing.RectF(((float)(105.5D)), ((float)(550.5D)), ((float)(3D)), ((float)(56.2D)));
			this.ft155.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft155.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft155.Name = "ft155";
			this.ft155.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvr156
			// 
			this.fvr156.Bounds = new NxtControl.Drawing.RectF(((float)(102D)), ((float)(586.2D)), ((float)(10D)), ((float)(8D)));
			this.fvr156.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr156.Closed = true;
			this.fvr156.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr156.Name = "fvr156";
			this.fvr156.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvr156.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(102D, 594.2D),
			new NxtControl.Drawing.PointF(112D, 594.2D),
			new NxtControl.Drawing.PointF(107D, 586.2D)});
			// 
			// fvr157
			// 
			this.fvr157.Bounds = new NxtControl.Drawing.RectF(((float)(102D)), ((float)(584.2D)), ((float)(10D)), ((float)(2D)));
			this.fvr157.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr157.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr157.Name = "fvr157";
			this.fvr157.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm158
			// 
			this.fvm158.Bounds = new NxtControl.Drawing.RectF(((float)(102D)), ((float)(559D)), ((float)(10D)), ((float)(5D)));
			this.fvm158.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm158.Closed = true;
			this.fvm158.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm158.Name = "fvm158";
			this.fvm158.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm158.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(102D, 559D),
			new NxtControl.Drawing.PointF(112D, 559D),
			new NxtControl.Drawing.PointF(107D, 564D)});
			// 
			// fvm159
			// 
			this.fvm159.Bounds = new NxtControl.Drawing.RectF(((float)(102D)), ((float)(564D)), ((float)(10D)), ((float)(5D)));
			this.fvm159.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm159.Closed = true;
			this.fvm159.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm159.Name = "fvm159";
			this.fvm159.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm159.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(102D, 569D),
			new NxtControl.Drawing.PointF(112D, 569D),
			new NxtControl.Drawing.PointF(107D, 564D)});
			// 
			// fvm160
			// 
			this.fvm160.Bounds = new NxtControl.Drawing.RectF(((float)(103D)), ((float)(563.25D)), ((float)(8D)), ((float)(1.5D)));
			this.fvm160.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm160.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm160.Name = "fvm160";
			this.fvm160.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr161
			// 
			this.fr161.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr161.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr161.Location = new NxtControl.Drawing.PointF(115D, 630D);
			this.fr161.Name = "fr161";
			this.fr161.Text = "BR-01";
			// 
			// ft162
			// 
			this.ft162.Bounds = new NxtControl.Drawing.RectF(((float)(154D)), ((float)(618.85D)), ((float)(3D)), ((float)(34.65D)));
			this.ft162.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft162.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft162.Name = "ft162";
			this.ft162.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft163
			// 
			this.ft163.Bounds = new NxtControl.Drawing.RectF(((float)(154D)), ((float)(618.85D)), ((float)(13D)), ((float)(3D)));
			this.ft163.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft163.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft163.Name = "ft163";
			this.ft163.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm164
			// 
			this.fvm164.Bounds = new NxtControl.Drawing.RectF(((float)(150.5D)), ((float)(631D)), ((float)(10D)), ((float)(5D)));
			this.fvm164.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm164.Closed = true;
			this.fvm164.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm164.Name = "fvm164";
			this.fvm164.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm164.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(150.5D, 631D),
			new NxtControl.Drawing.PointF(160.5D, 631D),
			new NxtControl.Drawing.PointF(155.5D, 636D)});
			// 
			// fvm165
			// 
			this.fvm165.Bounds = new NxtControl.Drawing.RectF(((float)(150.5D)), ((float)(636D)), ((float)(10D)), ((float)(5D)));
			this.fvm165.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm165.Closed = true;
			this.fvm165.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm165.Name = "fvm165";
			this.fvm165.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm165.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(150.5D, 641D),
			new NxtControl.Drawing.PointF(160.5D, 641D),
			new NxtControl.Drawing.PointF(155.5D, 636D)});
			// 
			// fvm166
			// 
			this.fvm166.Bounds = new NxtControl.Drawing.RectF(((float)(151.5D)), ((float)(635.25D)), ((float)(8D)), ((float)(1.5D)));
			this.fvm166.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm166.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm166.Name = "fvm166";
			this.fvm166.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft167
			// 
			this.ft167.Bounds = new NxtControl.Drawing.RectF(((float)(201.5D)), ((float)(603.7D)), ((float)(27D)), ((float)(3D)));
			this.ft167.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft167.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft167.Name = "ft167";
			this.ft167.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft168
			// 
			this.ft168.Bounds = new NxtControl.Drawing.RectF(((float)(225.5D)), ((float)(550.5D)), ((float)(3D)), ((float)(56.2D)));
			this.ft168.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft168.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft168.Name = "ft168";
			this.ft168.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvr169
			// 
			this.fvr169.Bounds = new NxtControl.Drawing.RectF(((float)(222D)), ((float)(586.2D)), ((float)(10D)), ((float)(8D)));
			this.fvr169.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr169.Closed = true;
			this.fvr169.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr169.Name = "fvr169";
			this.fvr169.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvr169.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(222D, 594.2D),
			new NxtControl.Drawing.PointF(232D, 594.2D),
			new NxtControl.Drawing.PointF(227D, 586.2D)});
			// 
			// fvr170
			// 
			this.fvr170.Bounds = new NxtControl.Drawing.RectF(((float)(222D)), ((float)(584.2D)), ((float)(10D)), ((float)(2D)));
			this.fvr170.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvr170.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvr170.Name = "fvr170";
			this.fvr170.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fvm171
			// 
			this.fvm171.Bounds = new NxtControl.Drawing.RectF(((float)(222D)), ((float)(559D)), ((float)(10D)), ((float)(5D)));
			this.fvm171.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm171.Closed = true;
			this.fvm171.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm171.Name = "fvm171";
			this.fvm171.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm171.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(222D, 559D),
			new NxtControl.Drawing.PointF(232D, 559D),
			new NxtControl.Drawing.PointF(227D, 564D)});
			// 
			// fvm172
			// 
			this.fvm172.Bounds = new NxtControl.Drawing.RectF(((float)(222D)), ((float)(564D)), ((float)(10D)), ((float)(5D)));
			this.fvm172.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.fvm172.Closed = true;
			this.fvm172.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm172.Name = "fvm172";
			this.fvm172.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.fvm172.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(222D, 569D),
			new NxtControl.Drawing.PointF(232D, 569D),
			new NxtControl.Drawing.PointF(227D, 564D)});
			// 
			// fvm173
			// 
			this.fvm173.Bounds = new NxtControl.Drawing.RectF(((float)(223D)), ((float)(563.25D)), ((float)(8D)), ((float)(1.5D)));
			this.fvm173.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.fvm173.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fvm173.Name = "fvm173";
			this.fvm173.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr174
			// 
			this.fr174.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr174.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr174.Location = new NxtControl.Drawing.PointF(235D, 630D);
			this.fr174.Name = "fr174";
			this.fr174.Text = "BR-02";
			// 
			// ft175
			// 
			this.ft175.Bounds = new NxtControl.Drawing.RectF(((float)(12.5D)), ((float)(550.5D)), ((float)(216D)), ((float)(3D)));
			this.ft175.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft175.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft175.Name = "ft175";
			this.ft175.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ft176
			// 
			this.ft176.Bounds = new NxtControl.Drawing.RectF(((float)(12.5D)), ((float)(74.5D)), ((float)(3D)), ((float)(479D)));
			this.ft176.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.ft176.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ft176.Name = "ft176";
			this.ft176.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fr177
			// 
			this.fr177.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr177.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.fr177.Location = new NxtControl.Drawing.PointF(330D, 616D);
			this.fr177.Name = "fr177";
			this.fr177.Text = "RETORNO DE SOBRENADANTE";
			// 
			// fr178
			// 
			this.fr178.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.fr178.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.fr178.Location = new NxtControl.Drawing.PointF(456D, 639D);
			this.fr178.Name = "fr178";
			this.fr178.Text = "FT-07";
			// 
			// ad01
			// 
			this.ad01.BeginInit();
			this.ad01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.45D, 0D, 0D, 0.45D, 648D, 132D);
			this.ad01.Name = "ad01";
			this.ad01.SecurityToken = ((uint)(4294967295u));
			this.ad01.TagName = "91957488A3380C04.AD_900_01";
			this.ad01.EndInit();
			// 
			// ad02
			// 
			this.ad02.BeginInit();
			this.ad02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.45D, 0D, 0D, 0.45D, 881D, 132D);
			this.ad02.Name = "ad02";
			this.ad02.SecurityToken = ((uint)(4294967295u));
			this.ad02.TagName = "91957488A3380C04.AD_900_02";
			this.ad02.EndInit();
			// 
			// ad03
			// 
			this.ad03.BeginInit();
			this.ad03.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.45D, 0D, 0D, 0.45D, 1114D, 132D);
			this.ad03.Name = "ad03";
			this.ad03.SecurityToken = ((uint)(4294967295u));
			this.ad03.TagName = "91957488A3380C04.AD_900_03";
			this.ad03.EndInit();
			// 
			// sv04
			// 
			this.sv04.BeginInit();
			this.sv04.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.9D, 738D, 80.6D);
			this.sv04.Name = "sv04";
			this.sv04.SecurityToken = ((uint)(4294967295u));
			this.sv04.TagName = "91957488A3380C04";
			this.sv04.EndInit();
			// 
			// sv06
			// 
			this.sv06.BeginInit();
			this.sv06.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.9D, 971D, 80.6D);
			this.sv06.Name = "sv06";
			this.sv06.SecurityToken = ((uint)(4294967295u));
			this.sv06.TagName = "91957488A3380C04";
			this.sv06.EndInit();
			// 
			// sv08
			// 
			this.sv08.BeginInit();
			this.sv08.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.9D, 1204D, 80.6D);
			this.sv08.Name = "sv08";
			this.sv08.SecurityToken = ((uint)(4294967295u));
			this.sv08.TagName = "91957488A3380C04";
			this.sv08.EndInit();
			// 
			// pp01
			// 
			this.pp01.BeginInit();
			this.pp01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.84D, 0D, 0D, 0.84D, 1112D, 300D);
			this.pp01.Name = "pp01";
			this.pp01.SecurityToken = ((uint)(4294967295u));
			this.pp01.TagName = "91957488A3380C04.PP_900_01";
			this.pp01.EndInit();
			// 
			// bo01
			// 
			this.bo01.BeginInit();
			this.bo01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.7D, 285D, 284D);
			this.bo01.Name = "bo01";
			this.bo01.SecurityToken = ((uint)(4294967295u));
			this.bo01.TagName = "91957488A3380C04.BO_900_01";
			this.bo01.EndInit();
			// 
			// va06
			// 
			this.va06.BeginInit();
			this.va06.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 469.7D, 302.76D);
			this.va06.Name = "va06";
			this.va06.SecurityToken = ((uint)(4294967295u));
			this.va06.TagName = "91957488A3380C04.VA_900_06";
			this.va06.EndInit();
			// 
			// bo02
			// 
			this.bo02.BeginInit();
			this.bo02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.7D, 285D, 396D);
			this.bo02.Name = "bo02";
			this.bo02.SecurityToken = ((uint)(4294967295u));
			this.bo02.TagName = "91957488A3380C04.BO_900_02";
			this.bo02.EndInit();
			// 
			// va07
			// 
			this.va07.BeginInit();
			this.va07.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 469.7D, 414.76D);
			this.va07.Name = "va07";
			this.va07.SecurityToken = ((uint)(4294967295u));
			this.va07.TagName = "91957488A3380C04.VA_900_07";
			this.va07.EndInit();
			// 
			// bo03
			// 
			this.bo03.BeginInit();
			this.bo03.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.7D, 285D, 508D);
			this.bo03.Name = "bo03";
			this.bo03.SecurityToken = ((uint)(4294967295u));
			this.bo03.TagName = "91957488A3380C04.BO_900_03";
			this.bo03.EndInit();
			// 
			// va08
			// 
			this.va08.BeginInit();
			this.va08.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 469.7D, 526.76D);
			this.va08.Name = "va08";
			this.va08.SecurityToken = ((uint)(4294967295u));
			this.va08.TagName = "91957488A3380C04.VA_900_08";
			this.va08.EndInit();
			// 
			// va09
			// 
			this.va09.BeginInit();
			this.va09.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 527.1D, 361.28D);
			this.va09.Name = "va09";
			this.va09.SecurityToken = ((uint)(4294967295u));
			this.va09.TagName = "91957488A3380C04.VA_900_09";
			this.va09.EndInit();
			// 
			// va10
			// 
			this.va10.BeginInit();
			this.va10.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 527.1D, 473.28D);
			this.va10.Name = "va10";
			this.va10.SecurityToken = ((uint)(4294967295u));
			this.va10.TagName = "91957488A3380C04.VA_900_10";
			this.va10.EndInit();
			// 
			// va12
			// 
			this.va12.BeginInit();
			this.va12.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 527.1D, 561.28D);
			this.va12.Name = "va12";
			this.va12.SecurityToken = ((uint)(4294967295u));
			this.va12.TagName = "91957488A3380C04.VA_900_12";
			this.va12.EndInit();
			// 
			// va11
			// 
			this.va11.BeginInit();
			this.va11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 578.7D, 302.76D);
			this.va11.Name = "va11";
			this.va11.SecurityToken = ((uint)(4294967295u));
			this.va11.TagName = "91957488A3380C04.VA_900_11";
			this.va11.EndInit();
			// 
			// va13
			// 
			this.va13.BeginInit();
			this.va13.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 578.7D, 526.76D);
			this.va13.Name = "va13";
			this.va13.SecurityToken = ((uint)(4294967295u));
			this.va13.TagName = "91957488A3380C04.VA_900_13";
			this.va13.EndInit();
			// 
			// sv03
			// 
			this.sv03.BeginInit();
			this.sv03.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.9D, 102D, 176.6D);
			this.sv03.Name = "sv03";
			this.sv03.SecurityToken = ((uint)(4294967295u));
			this.sv03.TagName = "91957488A3380C04";
			this.sv03.EndInit();
			// 
			// sv02
			// 
			this.sv02.BeginInit();
			this.sv02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.9D, 157D, 176.6D);
			this.sv02.Name = "sv02";
			this.sv02.SecurityToken = ((uint)(4294967295u));
			this.sv02.TagName = "91957488A3380C04";
			this.sv02.EndInit();
			// 
			// sv01
			// 
			this.sv01.BeginInit();
			this.sv01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.9D, 0D, 0D, 0.9D, 212D, 176.6D);
			this.sv01.Name = "sv01";
			this.sv01.SecurityToken = ((uint)(4294967295u));
			this.sv01.TagName = "91957488A3380C04";
			this.sv01.EndInit();
			// 
			// ft01
			// 
			this.ft01.BeginInit();
			this.ft01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 641D, 278D);
			this.ft01.Name = "ft01";
			this.ft01.SecurityToken = ((uint)(4294967295u));
			this.ft01.TagName = "91957488A3380C04.FT_900_01";
			this.ft01.EndInit();
			// 
			// ft02
			// 
			this.ft02.BeginInit();
			this.ft02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 874D, 330D);
			this.ft02.Name = "ft02";
			this.ft02.SecurityToken = ((uint)(4294967295u));
			this.ft02.TagName = "91957488A3380C04.FT_900_02";
			this.ft02.EndInit();
			// 
			// ft03
			// 
			this.ft03.BeginInit();
			this.ft03.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 971D, 420D);
			this.ft03.Name = "ft03";
			this.ft03.SecurityToken = ((uint)(4294967295u));
			this.ft03.TagName = "91957488A3380C04.FT_900_03";
			this.ft03.EndInit();
			// 
			// br01
			// 
			this.br01.BeginInit();
			this.br01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.5D, 40D, 586D);
			this.br01.Name = "br01";
			this.br01.SecurityToken = ((uint)(4294967295u));
			this.br01.TagName = "91957488A3380C04.BR_900_01";
			this.br01.EndInit();
			// 
			// br02
			// 
			this.br02.BeginInit();
			this.br02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.5D, 160D, 586D);
			this.br02.Name = "br02";
			this.br02.SecurityToken = ((uint)(4294967295u));
			this.br02.TagName = "91957488A3380C04.BR_900_02";
			this.br02.EndInit();
			// 
			// ft07
			// 
			this.ft07.BeginInit();
			this.ft07.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 330D, 636D);
			this.ft07.Name = "ft07";
			this.ft07.SecurityToken = ((uint)(4294967295u));
			this.ft07.TagName = "91957488A3380C04.FT_900_07";
			this.ft07.EndInit();
			// 
			// processo
			// 
			this.processo.BeginInit();
			this.processo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.72D, 0D, 0D, 0.72D, 560D, 628D);
			this.processo.Name = "processo";
			this.processo.SecurityToken = ((uint)(4294967295u));
			this.processo.TagName = "91957488A3380C04";
			this.processo.EndInit();
			// 
			// FASE_SOLIDA
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
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
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.fr1,
			this.fr2,
			this.fr3,
			this.ft4,
			this.fa5,
			this.ft6,
			this.fa7,
			this.ft8,
			this.fa9,
			this.ft10,
			this.ft11,
			this.fr12,
			this.ft13,
			this.fr14,
			this.ft15,
			this.fr16,
			this.fr17,
			this.ft18,
			this.ft19,
			this.ft20,
			this.ft21,
			this.fvr22,
			this.fvr23,
			this.fvm24,
			this.fvm25,
			this.fvm26,
			this.fr27,
			this.fs28,
			this.ft29,
			this.ft30,
			this.ft31,
			this.fvr32,
			this.fvr33,
			this.fvm34,
			this.fvm35,
			this.fvm36,
			this.fr37,
			this.fs38,
			this.ft39,
			this.ft40,
			this.ft41,
			this.fvr42,
			this.fvr43,
			this.fvm44,
			this.fvm45,
			this.fvm46,
			this.fr47,
			this.fs48,
			this.ft49,
			this.ft50,
			this.fvm51,
			this.fvm52,
			this.fvm53,
			this.fr54,
			this.ft55,
			this.fvm56,
			this.fvm57,
			this.fvm58,
			this.fmo59,
			this.fmo60,
			this.fmo61,
			this.fmo62,
			this.ft63,
			this.fr64,
			this.fr65,
			this.ft66,
			this.ft67,
			this.fvm68,
			this.fvm69,
			this.fvm70,
			this.fr71,
			this.ft72,
			this.fvm73,
			this.fvm74,
			this.fvm75,
			this.fmo76,
			this.fmo77,
			this.fmo78,
			this.fmo79,
			this.ft80,
			this.fr81,
			this.fr82,
			this.ft83,
			this.ft84,
			this.fvm85,
			this.fvm86,
			this.fvm87,
			this.fr88,
			this.ft89,
			this.fvm90,
			this.fvm91,
			this.fvm92,
			this.fmo93,
			this.fmo94,
			this.fmo95,
			this.fmo96,
			this.ft97,
			this.fr98,
			this.fr99,
			this.ft100,
			this.ft101,
			this.fr102,
			this.fr103,
			this.fr104,
			this.ft105,
			this.ft106,
			this.ft107,
			this.ft108,
			this.ft109,
			this.ft110,
			this.ft111,
			this.ft112,
			this.ft113,
			this.fr114,
			this.fr115,
			this.ft116,
			this.ft117,
			this.fvm118,
			this.fvm119,
			this.fvm120,
			this.fr121,
			this.ft122,
			this.fa123,
			this.ft124,
			this.fvm125,
			this.fvm126,
			this.fvm127,
			this.fr128,
			this.ft129,
			this.fa130,
			this.ft131,
			this.fa132,
			this.ft133,
			this.fvm134,
			this.fvm135,
			this.fvm136,
			this.fr137,
			this.irEstoc,
			this.ft138,
			this.ft139,
			this.ft140,
			this.fr141,
			this.ft142,
			this.fr143,
			this.ft144,
			this.fr145,
			this.fr146,
			this.fr147,
			this.ft148,
			this.ft149,
			this.ft150,
			this.fvm151,
			this.fvm152,
			this.fvm153,
			this.ft154,
			this.ft155,
			this.fvr156,
			this.fvr157,
			this.fvm158,
			this.fvm159,
			this.fvm160,
			this.fr161,
			this.ft162,
			this.ft163,
			this.fvm164,
			this.fvm165,
			this.fvm166,
			this.ft167,
			this.ft168,
			this.fvr169,
			this.fvr170,
			this.fvm171,
			this.fvm172,
			this.fvm173,
			this.fr174,
			this.ft175,
			this.ft176,
			this.fr177,
			this.fr178,
			this.ad01,
			this.ad02,
			this.ad03,
			this.sv04,
			this.sv06,
			this.sv08,
			this.pp01,
			this.bo01,
			this.va06,
			this.bo02,
			this.va07,
			this.bo03,
			this.va08,
			this.va09,
			this.va10,
			this.va12,
			this.va11,
			this.va13,
			this.sv03,
			this.sv02,
			this.sv01,
			this.ft01,
			this.ft02,
			this.ft03,
			this.br01,
			this.br02,
			this.ft07,
			this.processo,
			this.btnResetGeral,
			this.btnReconhecerGeral});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.FreeText fr1;
		private NxtControl.GuiFramework.FreeText fr2;
		private NxtControl.GuiFramework.FreeText fr3;
		private NxtControl.GuiFramework.Rectangle ft4;
		private NxtControl.GuiFramework.Polygon fa5;
		private NxtControl.GuiFramework.Rectangle ft6;
		private NxtControl.GuiFramework.Polygon fa7;
		private NxtControl.GuiFramework.Rectangle ft8;
		private NxtControl.GuiFramework.Polygon fa9;
		private NxtControl.GuiFramework.Rectangle ft10;
		private NxtControl.GuiFramework.Rectangle ft11;
		private NxtControl.GuiFramework.FreeText fr12;
		private NxtControl.GuiFramework.Rectangle ft13;
		private NxtControl.GuiFramework.FreeText fr14;
		private NxtControl.GuiFramework.Rectangle ft15;
		private NxtControl.GuiFramework.FreeText fr16;
		private NxtControl.GuiFramework.FreeText fr17;
		private NxtControl.GuiFramework.Rectangle ft18;
		private NxtControl.GuiFramework.Rectangle ft19;
		private NxtControl.GuiFramework.Rectangle ft20;
		private NxtControl.GuiFramework.Rectangle ft21;
		private NxtControl.GuiFramework.Polygon fvr22;
		private NxtControl.GuiFramework.Rectangle fvr23;
		private NxtControl.GuiFramework.Polygon fvm24;
		private NxtControl.GuiFramework.Polygon fvm25;
		private NxtControl.GuiFramework.Rectangle fvm26;
		private NxtControl.GuiFramework.FreeText fr27;
		private NxtControl.GuiFramework.Polygon fs28;
		private NxtControl.GuiFramework.Rectangle ft29;
		private NxtControl.GuiFramework.Rectangle ft30;
		private NxtControl.GuiFramework.Rectangle ft31;
		private NxtControl.GuiFramework.Polygon fvr32;
		private NxtControl.GuiFramework.Rectangle fvr33;
		private NxtControl.GuiFramework.Polygon fvm34;
		private NxtControl.GuiFramework.Polygon fvm35;
		private NxtControl.GuiFramework.Rectangle fvm36;
		private NxtControl.GuiFramework.FreeText fr37;
		private NxtControl.GuiFramework.Polygon fs38;
		private NxtControl.GuiFramework.Rectangle ft39;
		private NxtControl.GuiFramework.Rectangle ft40;
		private NxtControl.GuiFramework.Rectangle ft41;
		private NxtControl.GuiFramework.Polygon fvr42;
		private NxtControl.GuiFramework.Rectangle fvr43;
		private NxtControl.GuiFramework.Polygon fvm44;
		private NxtControl.GuiFramework.Polygon fvm45;
		private NxtControl.GuiFramework.Rectangle fvm46;
		private NxtControl.GuiFramework.FreeText fr47;
		private NxtControl.GuiFramework.Polygon fs48;
		private NxtControl.GuiFramework.Rectangle ft49;
		private NxtControl.GuiFramework.Rectangle ft50;
		private NxtControl.GuiFramework.Polygon fvm51;
		private NxtControl.GuiFramework.Polygon fvm52;
		private NxtControl.GuiFramework.Rectangle fvm53;
		private NxtControl.GuiFramework.FreeText fr54;
		private NxtControl.GuiFramework.Rectangle ft55;
		private NxtControl.GuiFramework.Polygon fvm56;
		private NxtControl.GuiFramework.Polygon fvm57;
		private NxtControl.GuiFramework.Rectangle fvm58;
		private NxtControl.GuiFramework.Rectangle fmo59;
		private NxtControl.GuiFramework.Polygon fmo60;
		private NxtControl.GuiFramework.Polygon fmo61;
		private NxtControl.GuiFramework.Polygon fmo62;
		private NxtControl.GuiFramework.Rectangle ft63;
		private NxtControl.GuiFramework.FreeText fr64;
		private NxtControl.GuiFramework.FreeText fr65;
		private NxtControl.GuiFramework.Rectangle ft66;
		private NxtControl.GuiFramework.Rectangle ft67;
		private NxtControl.GuiFramework.Polygon fvm68;
		private NxtControl.GuiFramework.Polygon fvm69;
		private NxtControl.GuiFramework.Rectangle fvm70;
		private NxtControl.GuiFramework.FreeText fr71;
		private NxtControl.GuiFramework.Rectangle ft72;
		private NxtControl.GuiFramework.Polygon fvm73;
		private NxtControl.GuiFramework.Polygon fvm74;
		private NxtControl.GuiFramework.Rectangle fvm75;
		private NxtControl.GuiFramework.Rectangle fmo76;
		private NxtControl.GuiFramework.Polygon fmo77;
		private NxtControl.GuiFramework.Polygon fmo78;
		private NxtControl.GuiFramework.Polygon fmo79;
		private NxtControl.GuiFramework.Rectangle ft80;
		private NxtControl.GuiFramework.FreeText fr81;
		private NxtControl.GuiFramework.FreeText fr82;
		private NxtControl.GuiFramework.Rectangle ft83;
		private NxtControl.GuiFramework.Rectangle ft84;
		private NxtControl.GuiFramework.Polygon fvm85;
		private NxtControl.GuiFramework.Polygon fvm86;
		private NxtControl.GuiFramework.Rectangle fvm87;
		private NxtControl.GuiFramework.FreeText fr88;
		private NxtControl.GuiFramework.Rectangle ft89;
		private NxtControl.GuiFramework.Polygon fvm90;
		private NxtControl.GuiFramework.Polygon fvm91;
		private NxtControl.GuiFramework.Rectangle fvm92;
		private NxtControl.GuiFramework.Rectangle fmo93;
		private NxtControl.GuiFramework.Polygon fmo94;
		private NxtControl.GuiFramework.Polygon fmo95;
		private NxtControl.GuiFramework.Polygon fmo96;
		private NxtControl.GuiFramework.Rectangle ft97;
		private NxtControl.GuiFramework.FreeText fr98;
		private NxtControl.GuiFramework.FreeText fr99;
		private NxtControl.GuiFramework.Rectangle ft100;
		private NxtControl.GuiFramework.Rectangle ft101;
		private NxtControl.GuiFramework.FreeText fr102;
		private NxtControl.GuiFramework.FreeText fr103;
		private NxtControl.GuiFramework.FreeText fr104;
		private NxtControl.GuiFramework.Rectangle ft105;
		private NxtControl.GuiFramework.Rectangle ft106;
		private NxtControl.GuiFramework.Rectangle ft107;
		private NxtControl.GuiFramework.Rectangle ft108;
		private NxtControl.GuiFramework.Rectangle ft109;
		private NxtControl.GuiFramework.Rectangle ft110;
		private NxtControl.GuiFramework.Rectangle ft111;
		private NxtControl.GuiFramework.Rectangle ft112;
		private NxtControl.GuiFramework.Rectangle ft113;
		private NxtControl.GuiFramework.FreeText fr114;
		private NxtControl.GuiFramework.FreeText fr115;
		private NxtControl.GuiFramework.Rectangle ft116;
		private NxtControl.GuiFramework.Rectangle ft117;
		private NxtControl.GuiFramework.Polygon fvm118;
		private NxtControl.GuiFramework.Polygon fvm119;
		private NxtControl.GuiFramework.Rectangle fvm120;
		private NxtControl.GuiFramework.FreeText fr121;
		private NxtControl.GuiFramework.Rectangle ft122;
		private NxtControl.GuiFramework.Polygon fa123;
		private NxtControl.GuiFramework.Rectangle ft124;
		private NxtControl.GuiFramework.Polygon fvm125;
		private NxtControl.GuiFramework.Polygon fvm126;
		private NxtControl.GuiFramework.Rectangle fvm127;
		private NxtControl.GuiFramework.FreeText fr128;
		private NxtControl.GuiFramework.Rectangle ft129;
		private NxtControl.GuiFramework.Polygon fa130;
		private NxtControl.GuiFramework.Rectangle ft131;
		private NxtControl.GuiFramework.Polygon fa132;
		private NxtControl.GuiFramework.Rectangle ft133;
		private NxtControl.GuiFramework.Polygon fvm134;
		private NxtControl.GuiFramework.Polygon fvm135;
		private NxtControl.GuiFramework.Rectangle fvm136;
		private NxtControl.GuiFramework.FreeText fr137;
		private NxtControl.GuiFramework.ChangeCanvasButton irEstoc;
		private NxtControl.GuiFramework.Rectangle ft138;
		private NxtControl.GuiFramework.Rectangle ft139;
		private NxtControl.GuiFramework.Rectangle ft140;
		private NxtControl.GuiFramework.FreeText fr141;
		private NxtControl.GuiFramework.Rectangle ft142;
		private NxtControl.GuiFramework.FreeText fr143;
		private NxtControl.GuiFramework.Rectangle ft144;
		private NxtControl.GuiFramework.FreeText fr145;
		private NxtControl.GuiFramework.FreeText fr146;
		private NxtControl.GuiFramework.FreeText fr147;
		private NxtControl.GuiFramework.Rectangle ft148;
		private NxtControl.GuiFramework.Rectangle ft149;
		private NxtControl.GuiFramework.Rectangle ft150;
		private NxtControl.GuiFramework.Polygon fvm151;
		private NxtControl.GuiFramework.Polygon fvm152;
		private NxtControl.GuiFramework.Rectangle fvm153;
		private NxtControl.GuiFramework.Rectangle ft154;
		private NxtControl.GuiFramework.Rectangle ft155;
		private NxtControl.GuiFramework.Polygon fvr156;
		private NxtControl.GuiFramework.Rectangle fvr157;
		private NxtControl.GuiFramework.Polygon fvm158;
		private NxtControl.GuiFramework.Polygon fvm159;
		private NxtControl.GuiFramework.Rectangle fvm160;
		private NxtControl.GuiFramework.FreeText fr161;
		private NxtControl.GuiFramework.Rectangle ft162;
		private NxtControl.GuiFramework.Rectangle ft163;
		private NxtControl.GuiFramework.Polygon fvm164;
		private NxtControl.GuiFramework.Polygon fvm165;
		private NxtControl.GuiFramework.Rectangle fvm166;
		private NxtControl.GuiFramework.Rectangle ft167;
		private NxtControl.GuiFramework.Rectangle ft168;
		private NxtControl.GuiFramework.Polygon fvr169;
		private NxtControl.GuiFramework.Rectangle fvr170;
		private NxtControl.GuiFramework.Polygon fvm171;
		private NxtControl.GuiFramework.Polygon fvm172;
		private NxtControl.GuiFramework.Rectangle fvm173;
		private NxtControl.GuiFramework.FreeText fr174;
		private NxtControl.GuiFramework.Rectangle ft175;
		private NxtControl.GuiFramework.Rectangle ft176;
		private NxtControl.GuiFramework.FreeText fr177;
		private NxtControl.GuiFramework.FreeText fr178;
		private Hidryco.HidrycoLib.Symbols.Prensa_Vibropac.sCPress ad01;
		private Hidryco.HidrycoLib.Symbols.Prensa_Vibropac.sCPress ad02;
		private Hidryco.HidrycoLib.Symbols.Prensa_Vibropac.sCPress ad03;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV04 sv04;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV06 sv06;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV08 sv08;
		private Hidryco.HidrycoLib.Symbols.Preparador_Vibropac.sPolimero pp01;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal bo01;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula va06;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal bo02;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula va07;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sHelicoidal bo03;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula va08;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV va09;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV va10;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV va12;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula va11;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula va13;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV03 sv03;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV02 sv02;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sSV01 sv01;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft01;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft02;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft03;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba br01;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba br02;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ft07;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sFaixa processo;
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		private NxtControl.GuiFramework.DrawnButton btnReconhecerGeral;
		#endregion
	}
}
