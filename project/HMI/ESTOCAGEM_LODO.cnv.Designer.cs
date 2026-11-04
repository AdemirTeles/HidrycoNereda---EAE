/*
 * Hidryco - tela ESTOCAGEM_LODO (fase solida - serie 900)
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
	/// Summary description for ESTOCAGEM_LODO.
	/// </summary>
	partial class ESTOCAGEM_LODO
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
			this.pE = new NxtControl.GuiFramework.Rectangle();
			this.pD = new NxtControl.GuiFramework.Rectangle();
			this.pF = new NxtControl.GuiFramework.Rectangle();
			this.pM = new NxtControl.GuiFramework.Rectangle();
			this.co01 = new NxtControl.GuiFramework.Rectangle();
			this.er1 = new NxtControl.GuiFramework.FreeText();
			this.er2 = new NxtControl.GuiFramework.FreeText();
			this.er3 = new NxtControl.GuiFramework.FreeText();
			this.er4 = new NxtControl.GuiFramework.FreeText();
			this.er5 = new NxtControl.GuiFramework.FreeText();
			this.di1 = new NxtControl.GuiFramework.Rectangle();
			this.dib1_0 = new NxtControl.GuiFramework.Rectangle();
			this.dib1_1 = new NxtControl.GuiFramework.Rectangle();
			this.dib1_2 = new NxtControl.GuiFramework.Rectangle();
			this.dib1_3 = new NxtControl.GuiFramework.Rectangle();
			this.dib1_4 = new NxtControl.GuiFramework.Rectangle();
			this.er6 = new NxtControl.GuiFramework.FreeText();
			this.di2 = new NxtControl.GuiFramework.Rectangle();
			this.dib2_0 = new NxtControl.GuiFramework.Rectangle();
			this.dib2_1 = new NxtControl.GuiFramework.Rectangle();
			this.dib2_2 = new NxtControl.GuiFramework.Rectangle();
			this.dib2_3 = new NxtControl.GuiFramework.Rectangle();
			this.dib2_4 = new NxtControl.GuiFramework.Rectangle();
			this.er7 = new NxtControl.GuiFramework.FreeText();
			this.et8 = new NxtControl.GuiFramework.Rectangle();
			this.et9 = new NxtControl.GuiFramework.Rectangle();
			this.es10 = new NxtControl.GuiFramework.Polygon();
			this.et11 = new NxtControl.GuiFramework.Rectangle();
			this.es12 = new NxtControl.GuiFramework.Polygon();
			this.er13 = new NxtControl.GuiFramework.FreeText();
			this.et14 = new NxtControl.GuiFramework.Rectangle();
			this.et15 = new NxtControl.GuiFramework.Rectangle();
			this.es16 = new NxtControl.GuiFramework.Polygon();
			this.er17 = new NxtControl.GuiFramework.FreeText();
			this.et18 = new NxtControl.GuiFramework.Rectangle();
			this.et19 = new NxtControl.GuiFramework.Rectangle();
			this.et20 = new NxtControl.GuiFramework.Rectangle();
			this.et21 = new NxtControl.GuiFramework.Rectangle();
			this.er22 = new NxtControl.GuiFramework.FreeText();
			this.er23 = new NxtControl.GuiFramework.FreeText();
			this.et24 = new NxtControl.GuiFramework.Rectangle();
			this.es25 = new NxtControl.GuiFramework.Polygon();
			this.irDesag = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.er26 = new NxtControl.GuiFramework.FreeText();
			this.et27 = new NxtControl.GuiFramework.Rectangle();
			this.ea28 = new NxtControl.GuiFramework.Polygon();
			this.et29 = new NxtControl.GuiFramework.Rectangle();
			this.evr30 = new NxtControl.GuiFramework.Polygon();
			this.evr31 = new NxtControl.GuiFramework.Rectangle();
			this.evm32 = new NxtControl.GuiFramework.Polygon();
			this.evm33 = new NxtControl.GuiFramework.Polygon();
			this.evm34 = new NxtControl.GuiFramework.Rectangle();
			this.er35 = new NxtControl.GuiFramework.FreeText();
			this.er36 = new NxtControl.GuiFramework.FreeText();
			this.er37 = new NxtControl.GuiFramework.FreeText();
			this.et38 = new NxtControl.GuiFramework.Rectangle();
			this.ea39 = new NxtControl.GuiFramework.Polygon();
			this.et40 = new NxtControl.GuiFramework.Rectangle();
			this.evr41 = new NxtControl.GuiFramework.Polygon();
			this.evr42 = new NxtControl.GuiFramework.Rectangle();
			this.evm43 = new NxtControl.GuiFramework.Polygon();
			this.evm44 = new NxtControl.GuiFramework.Polygon();
			this.evm45 = new NxtControl.GuiFramework.Rectangle();
			this.er46 = new NxtControl.GuiFramework.FreeText();
			this.er47 = new NxtControl.GuiFramework.FreeText();
			this.et48 = new NxtControl.GuiFramework.Rectangle();
			this.er49 = new NxtControl.GuiFramework.FreeText();
			this.lit1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel();
			this.lit2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel();
			this.va01 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.va02 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula();
			this.so1 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador();
			this.vb3 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV();
			this.so2 = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador();
			this.vb4 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV();
			this.processo = new Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sDefault();
			this.revezamento = new Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.sAjustes();
			this.repAI1 = new SE.Nereda.Symbols.AnalogInputBase.sInstanceName();
			this.repHH1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repH1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repL1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repLL1 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repAI2 = new SE.Nereda.Symbols.AnalogInputBase.sInstanceName();
			this.repHH2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repH2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repL2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
			this.repLL2 = new SE.App2Base.Symbols.LimitAlarm.sIndicator();
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
			// pE
			// 
			this.pE.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(140D)), ((float)(6D)), ((float)(266D)));
			this.pE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.pE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pE.Name = "pE";
			this.pE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pD
			// 
			this.pD.Bounds = new NxtControl.Drawing.RectF(((float)(740D)), ((float)(140D)), ((float)(6D)), ((float)(266D)));
			this.pD.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.pD.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pD.Name = "pD";
			this.pD.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pF
			// 
			this.pF.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(400D)), ((float)(452D)), ((float)(6D)));
			this.pF.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.pF.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pF.Name = "pF";
			this.pF.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pM
			// 
			this.pM.Bounds = new NxtControl.Drawing.RectF(((float)(517D)), ((float)(140D)), ((float)(6D)), ((float)(214D)));
			this.pM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.pM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pM.Name = "pM";
			this.pM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// co01
			// 
			this.co01.Bounds = new NxtControl.Drawing.RectF(((float)(517D)), ((float)(354D)), ((float)(6D)), ((float)(46D)));
			this.co01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.co01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.co01.Name = "co01";
			this.co01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// er1
			// 
			this.er1.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.er1.Location = new NxtControl.Drawing.PointF(528D, 380D);
			this.er1.Name = "er1";
			this.er1.Text = "CO-01";
			// 
			// er2
			// 
			this.er2.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.er2.Location = new NxtControl.Drawing.PointF(308D, 146D);
			this.er2.Name = "er2";
			this.er2.Text = "TQ-1";
			// 
			// er3
			// 
			this.er3.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.er3.Location = new NxtControl.Drawing.PointF(530D, 146D);
			this.er3.Name = "er3";
			this.er3.Text = "TQ-2";
			// 
			// er4
			// 
			this.er4.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er4.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.er4.Location = new NxtControl.Drawing.PointF(350D, 146D);
			this.er4.Name = "er4";
			this.er4.Text = "LIT-01";
			// 
			// er5
			// 
			this.er5.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er5.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.er5.Location = new NxtControl.Drawing.PointF(570D, 146D);
			this.er5.Name = "er5";
			this.er5.Text = "LIT-02";
			// 
			// di1
			// 
			this.di1.Bounds = new NxtControl.Drawing.RectF(((float)(388D)), ((float)(388D)), ((float)(44D)), ((float)(6D)));
			this.di1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.di1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.di1.Name = "di1";
			this.di1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib1_0
			// 
			this.dib1_0.Bounds = new NxtControl.Drawing.RectF(((float)(392D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib1_0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib1_0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib1_0.Name = "dib1_0";
			this.dib1_0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib1_1
			// 
			this.dib1_1.Bounds = new NxtControl.Drawing.RectF(((float)(401D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib1_1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib1_1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib1_1.Name = "dib1_1";
			this.dib1_1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib1_2
			// 
			this.dib1_2.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib1_2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib1_2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib1_2.Name = "dib1_2";
			this.dib1_2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib1_3
			// 
			this.dib1_3.Bounds = new NxtControl.Drawing.RectF(((float)(419D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib1_3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib1_3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib1_3.Name = "dib1_3";
			this.dib1_3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib1_4
			// 
			this.dib1_4.Bounds = new NxtControl.Drawing.RectF(((float)(428D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib1_4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib1_4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib1_4.Name = "dib1_4";
			this.dib1_4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// er6
			// 
			this.er6.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er6.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.er6.Location = new NxtControl.Drawing.PointF(350D, 384D);
			this.er6.Name = "er6";
			this.er6.Text = "DI-01";
			// 
			// di2
			// 
			this.di2.Bounds = new NxtControl.Drawing.RectF(((float)(608D)), ((float)(388D)), ((float)(44D)), ((float)(6D)));
			this.di2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.di2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.di2.Name = "di2";
			this.di2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib2_0
			// 
			this.dib2_0.Bounds = new NxtControl.Drawing.RectF(((float)(612D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib2_0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib2_0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib2_0.Name = "dib2_0";
			this.dib2_0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib2_1
			// 
			this.dib2_1.Bounds = new NxtControl.Drawing.RectF(((float)(621D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib2_1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib2_1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib2_1.Name = "dib2_1";
			this.dib2_1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib2_2
			// 
			this.dib2_2.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib2_2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib2_2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib2_2.Name = "dib2_2";
			this.dib2_2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib2_3
			// 
			this.dib2_3.Bounds = new NxtControl.Drawing.RectF(((float)(639D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib2_3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib2_3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib2_3.Name = "dib2_3";
			this.dib2_3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// dib2_4
			// 
			this.dib2_4.Bounds = new NxtControl.Drawing.RectF(((float)(648D)), ((float)(382D)), ((float)(2D)), ((float)(2D)));
			this.dib2_4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.dib2_4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.dib2_4.Name = "dib2_4";
			this.dib2_4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// er7
			// 
			this.er7.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er7.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.er7.Location = new NxtControl.Drawing.PointF(570D, 384D);
			this.er7.Name = "er7";
			this.er7.Text = "DI-02";
			// 
			// et8
			// 
			this.et8.Bounds = new NxtControl.Drawing.RectF(((float)(38D)), ((float)(74D)), ((float)(604D)), ((float)(4D)));
			this.et8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))));
			this.et8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et8.Name = "et8";
			this.et8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// et9
			// 
			this.et9.Bounds = new NxtControl.Drawing.RectF(((float)(428D)), ((float)(74D)), ((float)(4D)), ((float)(64D)));
			this.et9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))));
			this.et9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et9.Name = "et9";
			this.et9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// es10
			// 
			this.es10.Bounds = new NxtControl.Drawing.RectF(((float)(424D)), ((float)(126D)), ((float)(12D)), ((float)(12D)));
			this.es10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))));
			this.es10.Closed = true;
			this.es10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.es10.Name = "es10";
			this.es10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.es10.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(424D, 126D),
			new NxtControl.Drawing.PointF(430D, 138D),
			new NxtControl.Drawing.PointF(436D, 126D)});
			// 
			// et11
			// 
			this.et11.Bounds = new NxtControl.Drawing.RectF(((float)(638D)), ((float)(74D)), ((float)(4D)), ((float)(64D)));
			this.et11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))));
			this.et11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et11.Name = "et11";
			this.et11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// es12
			// 
			this.es12.Bounds = new NxtControl.Drawing.RectF(((float)(634D)), ((float)(126D)), ((float)(12D)), ((float)(12D)));
			this.es12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))));
			this.es12.Closed = true;
			this.es12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.es12.Name = "es12";
			this.es12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.es12.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(634D, 126D),
			new NxtControl.Drawing.PointF(640D, 138D),
			new NxtControl.Drawing.PointF(646D, 126D)});
			// 
			// er13
			// 
			this.er13.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er13.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.er13.Location = new NxtControl.Drawing.PointF(40D, 58D);
			this.er13.Name = "er13";
			this.er13.Text = "Descarte de lodo do Nereda";
			// 
			// et14
			// 
			this.et14.Bounds = new NxtControl.Drawing.RectF(((float)(38.5D)), ((float)(106.5D)), ((float)(303D)), ((float)(3D)));
			this.et14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(160)), ((byte)(90))));
			this.et14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et14.Name = "et14";
			this.et14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(160)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// et15
			// 
			this.et15.Bounds = new NxtControl.Drawing.RectF(((float)(338.5D)), ((float)(106.5D)), ((float)(3D)), ((float)(31D)));
			this.et15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(160)), ((byte)(90))));
			this.et15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et15.Name = "et15";
			this.et15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(160)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// es16
			// 
			this.es16.Bounds = new NxtControl.Drawing.RectF(((float)(335D)), ((float)(127D)), ((float)(10D)), ((float)(10D)));
			this.es16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(160)), ((byte)(90))));
			this.es16.Closed = true;
			this.es16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.es16.Name = "es16";
			this.es16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(160)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.es16.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(335D, 127D),
			new NxtControl.Drawing.PointF(340D, 137D),
			new NxtControl.Drawing.PointF(345D, 127D)});
			// 
			// er17
			// 
			this.er17.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er17.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.er17.Location = new NxtControl.Drawing.PointF(40D, 90D);
			this.er17.Name = "er17";
			this.er17.Text = "Descarte de escuma do pré-tratamento";
			// 
			// et18
			// 
			this.et18.Bounds = new NxtControl.Drawing.RectF(((float)(197.5D)), ((float)(373.5D)), ((float)(99D)), ((float)(5D)));
			this.et18.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.et18.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et18.Name = "et18";
			this.et18.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// et19
			// 
			this.et19.Bounds = new NxtControl.Drawing.RectF(((float)(743.5D)), ((float)(373.5D)), ((float)(99D)), ((float)(5D)));
			this.et19.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.et19.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et19.Name = "et19";
			this.et19.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// et20
			// 
			this.et20.Bounds = new NxtControl.Drawing.RectF(((float)(197.5D)), ((float)(373.5D)), ((float)(5D)), ((float)(81D)));
			this.et20.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.et20.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et20.Name = "et20";
			this.et20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// et21
			// 
			this.et21.Bounds = new NxtControl.Drawing.RectF(((float)(837.5D)), ((float)(373.5D)), ((float)(5D)), ((float)(81D)));
			this.et21.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.et21.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et21.Name = "et21";
			this.et21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// er22
			// 
			this.er22.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er22.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er22.Location = new NxtControl.Drawing.PointF(236D, 404D);
			this.er22.Name = "er22";
			this.er22.Text = "VA-01";
			// 
			// er23
			// 
			this.er23.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er23.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er23.Location = new NxtControl.Drawing.PointF(776D, 404D);
			this.er23.Name = "er23";
			this.er23.Text = "VA-02";
			// 
			// et24
			// 
			this.et24.Bounds = new NxtControl.Drawing.RectF(((float)(197.5D)), ((float)(449.5D)), ((float)(815D)), ((float)(5D)));
			this.et24.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.et24.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et24.Name = "et24";
			this.et24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// es25
			// 
			this.es25.Bounds = new NxtControl.Drawing.RectF(((float)(1009D)), ((float)(445D)), ((float)(14D)), ((float)(14D)));
			this.es25.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.es25.Closed = true;
			this.es25.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.es25.Name = "es25";
			this.es25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.es25.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1009D, 445D),
			new NxtControl.Drawing.PointF(1023D, 452D),
			new NxtControl.Drawing.PointF(1009D, 459D)});
			// 
			// irDesag
			// 
			this.irDesag.Bounds = new NxtControl.Drawing.RectF(((float)(1030D)), ((float)(437D)), ((float)(250D)), ((float)(30D)));
			this.irDesag.CanvasName = "FASE_SOLIDA";
			this.irDesag.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irDesag.Name = "irDesag";
			this.irDesag.Text = "Alimentação das prensas ›";
			// 
			// er26
			// 
			this.er26.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er26.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er26.Location = new NxtControl.Drawing.PointF(466.26D, 650.6D);
			this.er26.Name = "er26";
			this.er26.Text = "SO-01";
			// 
			// et27
			// 
			this.et27.Bounds = new NxtControl.Drawing.RectF(((float)(408D)), ((float)(392D)), ((float)(4D)), ((float)(55D)));
			this.et27.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.et27.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et27.Name = "et27";
			this.et27.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ea28
			// 
			this.ea28.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(443D)), ((float)(9D)), ((float)(18D)));
			this.ea28.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.ea28.Closed = true;
			this.ea28.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ea28.Name = "ea28";
			this.ea28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ea28.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(410D, 443D),
			new NxtControl.Drawing.PointF(412.33D, 443.31D),
			new NxtControl.Drawing.PointF(414.5D, 444.21D),
			new NxtControl.Drawing.PointF(416.36D, 445.64D),
			new NxtControl.Drawing.PointF(417.79D, 447.5D),
			new NxtControl.Drawing.PointF(418.69D, 449.67D),
			new NxtControl.Drawing.PointF(419D, 452D),
			new NxtControl.Drawing.PointF(418.69D, 454.33D),
			new NxtControl.Drawing.PointF(417.79D, 456.5D),
			new NxtControl.Drawing.PointF(416.36D, 458.36D),
			new NxtControl.Drawing.PointF(414.5D, 459.79D),
			new NxtControl.Drawing.PointF(412.33D, 460.69D),
			new NxtControl.Drawing.PointF(410D, 461D),
			new NxtControl.Drawing.PointF(410D, 457D),
			new NxtControl.Drawing.PointF(411.29D, 456.83D),
			new NxtControl.Drawing.PointF(412.5D, 456.33D),
			new NxtControl.Drawing.PointF(413.54D, 455.54D),
			new NxtControl.Drawing.PointF(414.33D, 454.5D),
			new NxtControl.Drawing.PointF(414.83D, 453.29D),
			new NxtControl.Drawing.PointF(415D, 452D),
			new NxtControl.Drawing.PointF(414.83D, 450.71D),
			new NxtControl.Drawing.PointF(414.33D, 449.5D),
			new NxtControl.Drawing.PointF(413.54D, 448.46D),
			new NxtControl.Drawing.PointF(412.5D, 447.67D),
			new NxtControl.Drawing.PointF(411.29D, 447.17D),
			new NxtControl.Drawing.PointF(410D, 447D)});
			// 
			// et29
			// 
			this.et29.Bounds = new NxtControl.Drawing.RectF(((float)(408D)), ((float)(457D)), ((float)(4D)), ((float)(165D)));
			this.et29.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.et29.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et29.Name = "et29";
			this.et29.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// evr30
			// 
			this.evr30.Bounds = new NxtControl.Drawing.RectF(((float)(404D)), ((float)(588.4D)), ((float)(12D)), ((float)(9.6D)));
			this.evr30.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.evr30.Closed = true;
			this.evr30.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evr30.Name = "evr30";
			this.evr30.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.evr30.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(404D, 598D),
			new NxtControl.Drawing.PointF(416D, 598D),
			new NxtControl.Drawing.PointF(410D, 588.4D)});
			// 
			// evr31
			// 
			this.evr31.Bounds = new NxtControl.Drawing.RectF(((float)(404D)), ((float)(586.4D)), ((float)(12D)), ((float)(2D)));
			this.evr31.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.evr31.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evr31.Name = "evr31";
			this.evr31.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// evm32
			// 
			this.evm32.Bounds = new NxtControl.Drawing.RectF(((float)(403D)), ((float)(557D)), ((float)(14D)), ((float)(7D)));
			this.evm32.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.evm32.Closed = true;
			this.evm32.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evm32.Name = "evm32";
			this.evm32.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.evm32.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(403D, 557D),
			new NxtControl.Drawing.PointF(417D, 557D),
			new NxtControl.Drawing.PointF(410D, 564D)});
			// 
			// evm33
			// 
			this.evm33.Bounds = new NxtControl.Drawing.RectF(((float)(403D)), ((float)(564D)), ((float)(14D)), ((float)(7D)));
			this.evm33.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.evm33.Closed = true;
			this.evm33.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evm33.Name = "evm33";
			this.evm33.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.evm33.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(403D, 571D),
			new NxtControl.Drawing.PointF(417D, 571D),
			new NxtControl.Drawing.PointF(410D, 564D)});
			// 
			// evm34
			// 
			this.evm34.Bounds = new NxtControl.Drawing.RectF(((float)(404D)), ((float)(563.25D)), ((float)(12D)), ((float)(1.5D)));
			this.evm34.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.evm34.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evm34.Name = "evm34";
			this.evm34.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// er35
			// 
			this.er35.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er35.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er35.Location = new NxtControl.Drawing.PointF(422D, 558D);
			this.er35.Name = "er35";
			this.er35.Text = "VB-01";
			// 
			// er36
			// 
			this.er36.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er36.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er36.Location = new NxtControl.Drawing.PointF(446D, 488D);
			this.er36.Name = "er36";
			this.er36.Text = "VB-03";
			// 
			// er37
			// 
			this.er37.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er37.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er37.Location = new NxtControl.Drawing.PointF(686.26D, 650.6D);
			this.er37.Name = "er37";
			this.er37.Text = "SO-02";
			// 
			// et38
			// 
			this.et38.Bounds = new NxtControl.Drawing.RectF(((float)(628D)), ((float)(392D)), ((float)(4D)), ((float)(55D)));
			this.et38.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.et38.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et38.Name = "et38";
			this.et38.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ea39
			// 
			this.ea39.Bounds = new NxtControl.Drawing.RectF(((float)(630D)), ((float)(443D)), ((float)(9D)), ((float)(18D)));
			this.ea39.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.ea39.Closed = true;
			this.ea39.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ea39.Name = "ea39";
			this.ea39.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.ea39.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(630D, 443D),
			new NxtControl.Drawing.PointF(632.33D, 443.31D),
			new NxtControl.Drawing.PointF(634.5D, 444.21D),
			new NxtControl.Drawing.PointF(636.36D, 445.64D),
			new NxtControl.Drawing.PointF(637.79D, 447.5D),
			new NxtControl.Drawing.PointF(638.69D, 449.67D),
			new NxtControl.Drawing.PointF(639D, 452D),
			new NxtControl.Drawing.PointF(638.69D, 454.33D),
			new NxtControl.Drawing.PointF(637.79D, 456.5D),
			new NxtControl.Drawing.PointF(636.36D, 458.36D),
			new NxtControl.Drawing.PointF(634.5D, 459.79D),
			new NxtControl.Drawing.PointF(632.33D, 460.69D),
			new NxtControl.Drawing.PointF(630D, 461D),
			new NxtControl.Drawing.PointF(630D, 457D),
			new NxtControl.Drawing.PointF(631.29D, 456.83D),
			new NxtControl.Drawing.PointF(632.5D, 456.33D),
			new NxtControl.Drawing.PointF(633.54D, 455.54D),
			new NxtControl.Drawing.PointF(634.33D, 454.5D),
			new NxtControl.Drawing.PointF(634.83D, 453.29D),
			new NxtControl.Drawing.PointF(635D, 452D),
			new NxtControl.Drawing.PointF(634.83D, 450.71D),
			new NxtControl.Drawing.PointF(634.33D, 449.5D),
			new NxtControl.Drawing.PointF(633.54D, 448.46D),
			new NxtControl.Drawing.PointF(632.5D, 447.67D),
			new NxtControl.Drawing.PointF(631.29D, 447.17D),
			new NxtControl.Drawing.PointF(630D, 447D)});
			// 
			// et40
			// 
			this.et40.Bounds = new NxtControl.Drawing.RectF(((float)(628D)), ((float)(457D)), ((float)(4D)), ((float)(165D)));
			this.et40.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.et40.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et40.Name = "et40";
			this.et40.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// evr41
			// 
			this.evr41.Bounds = new NxtControl.Drawing.RectF(((float)(624D)), ((float)(588.4D)), ((float)(12D)), ((float)(9.6D)));
			this.evr41.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.evr41.Closed = true;
			this.evr41.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evr41.Name = "evr41";
			this.evr41.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.evr41.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(624D, 598D),
			new NxtControl.Drawing.PointF(636D, 598D),
			new NxtControl.Drawing.PointF(630D, 588.4D)});
			// 
			// evr42
			// 
			this.evr42.Bounds = new NxtControl.Drawing.RectF(((float)(624D)), ((float)(586.4D)), ((float)(12D)), ((float)(2D)));
			this.evr42.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.evr42.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evr42.Name = "evr42";
			this.evr42.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// evm43
			// 
			this.evm43.Bounds = new NxtControl.Drawing.RectF(((float)(623D)), ((float)(557D)), ((float)(14D)), ((float)(7D)));
			this.evm43.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.evm43.Closed = true;
			this.evm43.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evm43.Name = "evm43";
			this.evm43.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.evm43.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(623D, 557D),
			new NxtControl.Drawing.PointF(637D, 557D),
			new NxtControl.Drawing.PointF(630D, 564D)});
			// 
			// evm44
			// 
			this.evm44.Bounds = new NxtControl.Drawing.RectF(((float)(623D)), ((float)(564D)), ((float)(14D)), ((float)(7D)));
			this.evm44.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.evm44.Closed = true;
			this.evm44.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evm44.Name = "evm44";
			this.evm44.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.evm44.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(623D, 571D),
			new NxtControl.Drawing.PointF(637D, 571D),
			new NxtControl.Drawing.PointF(630D, 564D)});
			// 
			// evm45
			// 
			this.evm45.Bounds = new NxtControl.Drawing.RectF(((float)(624D)), ((float)(563.25D)), ((float)(12D)), ((float)(1.5D)));
			this.evm45.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.evm45.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.evm45.Name = "evm45";
			this.evm45.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// er46
			// 
			this.er46.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er46.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er46.Location = new NxtControl.Drawing.PointF(642D, 558D);
			this.er46.Name = "er46";
			this.er46.Text = "VB-02";
			// 
			// er47
			// 
			this.er47.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er47.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er47.Location = new NxtControl.Drawing.PointF(666D, 488D);
			this.er47.Name = "er47";
			this.er47.Text = "VB-04";
			// 
			// et48
			// 
			this.et48.Bounds = new NxtControl.Drawing.RectF(((float)(408D)), ((float)(536D)), ((float)(224D)), ((float)(4D)));
			this.et48.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.et48.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.et48.Name = "et48";
			this.et48.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// er49
			// 
			this.er49.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.er49.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.er49.Location = new NxtControl.Drawing.PointF(290D, 640D);
			this.er49.Name = "er49";
			this.er49.Text = "SOPRADORES";
			// 
			// lit1
			// 
			this.lit1.BeginInit();
			this.lit1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.25D, 0D, 0D, 1.25D, 340D, 170D);
			this.lit1.Name = "lit1";
			this.lit1.SecurityToken = ((uint)(4294967295u));
			this.lit1.TagName = "A03873967E84DB27.LIT_900_01";
			this.lit1.EndInit();
			// 
			// lit2
			// 
			this.lit2.BeginInit();
			this.lit2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.25D, 0D, 0D, 1.25D, 560D, 170D);
			this.lit2.Name = "lit2";
			this.lit2.SecurityToken = ((uint)(4294967295u));
			this.lit2.TagName = "A03873967E84DB27.LIT_900_02";
			this.lit2.EndInit();
			// 
			// va01
			// 
			this.va01.BeginInit();
			this.va01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.5D, 217.5D, 340D);
			this.va01.Name = "va01";
			this.va01.SecurityToken = ((uint)(4294967295u));
			this.va01.TagName = "A03873967E84DB27.VA_900_01";
			this.va01.EndInit();
			// 
			// va02
			// 
			this.va02.BeginInit();
			this.va02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.5D, 757.5D, 340D);
			this.va02.Name = "va02";
			this.va02.SecurityToken = ((uint)(4294967295u));
			this.va02.TagName = "A03873967E84DB27.VA_900_02";
			this.va02.EndInit();
			// 
			// so1
			// 
			this.so1.BeginInit();
			this.so1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55D, 0D, 0D, 0.55D, 389.26D, 604.6D);
			this.so1.Name = "so1";
			this.so1.SecurityToken = ((uint)(4294967295u));
			this.so1.TagName = "A03873967E84DB27.SO_900_01";
			this.so1.EndInit();
			// 
			// vb3
			// 
			this.vb3.BeginInit();
			this.vb3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.5D, 387.5D, 461D);
			this.vb3.Name = "vb3";
			this.vb3.SecurityToken = ((uint)(4294967295u));
			this.vb3.TagName = "A03873967E84DB27.VB_900_03";
			this.vb3.EndInit();
			// 
			// so2
			// 
			this.so2.BeginInit();
			this.so2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55D, 0D, 0D, 0.55D, 609.26D, 604.6D);
			this.so2.Name = "so2";
			this.so2.SecurityToken = ((uint)(4294967295u));
			this.so2.TagName = "A03873967E84DB27.SO_900_02";
			this.so2.EndInit();
			// 
			// vb4
			// 
			this.vb4.BeginInit();
			this.vb4.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.5D, 607.5D, 461D);
			this.vb4.Name = "vb4";
			this.vb4.SecurityToken = ((uint)(4294967295u));
			this.vb4.TagName = "A03873967E84DB27.VB_900_04";
			this.vb4.EndInit();
			// 
			// processo
			// 
			this.processo.BeginInit();
			this.processo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 900D, 150D);
			this.processo.Name = "processo";
			this.processo.SecurityToken = ((uint)(4294967295u));
			this.processo.TagName = "91957488A3380C04";
			this.processo.EndInit();
			// 
			// revezamento
			// 
			this.revezamento.BeginInit();
			this.revezamento.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 905D, 500D);
			this.revezamento.Name = "revezamento";
			this.revezamento.SecurityToken = ((uint)(4294967295u));
			this.revezamento.TagName = "A03873967E84DB27.Revezamento";
			this.revezamento.Titulo = "Revezamento dos sopradores";
			this.revezamento.Rotulo_CMD_HABILITA = "Troca do soprador principal por tempo";
			this.revezamento.Rotulo_STP_TEMPO_B1 = "Horas do SO-01 como principal";
			this.revezamento.Rotulo_STP_TEMPO_B2 = "Horas do SO-02 como principal";
			this.revezamento.EndInit();
			// 
			// repAI1
			// 
			this.repAI1.BeginInit();
			this.repAI1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repAI1.Name = "repAI1";
			this.repAI1.SecurityToken = ((uint)(4294967295u));
			this.repAI1.TagName = "356FB76E49F87763.LevelMeasurementReactor.AnalogInput";
			this.repAI1.Visible = false;
			this.repAI1.EndInit();
			// 
			// repHH1
			// 
			this.repHH1.BeginInit();
			this.repHH1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repHH1.Name = "repHH1";
			this.repHH1.SecurityToken = ((uint)(4294967295u));
			this.repHH1.TagName = "356FB76E49F87763.LevelMeasurementReactor.highHigh";
			this.repHH1.Visible = false;
			this.repHH1.EndInit();
			// 
			// repH1
			// 
			this.repH1.BeginInit();
			this.repH1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repH1.Name = "repH1";
			this.repH1.SecurityToken = ((uint)(4294967295u));
			this.repH1.TagName = "356FB76E49F87763.LevelMeasurementReactor.high";
			this.repH1.Visible = false;
			this.repH1.EndInit();
			// 
			// repL1
			// 
			this.repL1.BeginInit();
			this.repL1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repL1.Name = "repL1";
			this.repL1.SecurityToken = ((uint)(4294967295u));
			this.repL1.TagName = "356FB76E49F87763.LevelMeasurementReactor.low";
			this.repL1.Visible = false;
			this.repL1.EndInit();
			// 
			// repLL1
			// 
			this.repLL1.BeginInit();
			this.repLL1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repLL1.Name = "repLL1";
			this.repLL1.SecurityToken = ((uint)(4294967295u));
			this.repLL1.TagName = "356FB76E49F87763.LevelMeasurementReactor.lowLow";
			this.repLL1.Visible = false;
			this.repLL1.EndInit();
			// 
			// repAI2
			// 
			this.repAI2.BeginInit();
			this.repAI2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repAI2.Name = "repAI2";
			this.repAI2.SecurityToken = ((uint)(4294967295u));
			this.repAI2.TagName = "864A57C6293E51C2.LevelMeasurementReactor.AnalogInput";
			this.repAI2.Visible = false;
			this.repAI2.EndInit();
			// 
			// repHH2
			// 
			this.repHH2.BeginInit();
			this.repHH2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repHH2.Name = "repHH2";
			this.repHH2.SecurityToken = ((uint)(4294967295u));
			this.repHH2.TagName = "864A57C6293E51C2.LevelMeasurementReactor.highHigh";
			this.repHH2.Visible = false;
			this.repHH2.EndInit();
			// 
			// repH2
			// 
			this.repH2.BeginInit();
			this.repH2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repH2.Name = "repH2";
			this.repH2.SecurityToken = ((uint)(4294967295u));
			this.repH2.TagName = "864A57C6293E51C2.LevelMeasurementReactor.high";
			this.repH2.Visible = false;
			this.repH2.EndInit();
			// 
			// repL2
			// 
			this.repL2.BeginInit();
			this.repL2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repL2.Name = "repL2";
			this.repL2.SecurityToken = ((uint)(4294967295u));
			this.repL2.TagName = "864A57C6293E51C2.LevelMeasurementReactor.low";
			this.repL2.Visible = false;
			this.repL2.EndInit();
			// 
			// repLL2
			// 
			this.repLL2.BeginInit();
			this.repLL2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 0D, 0D);
			this.repLL2.Name = "repLL2";
			this.repLL2.SecurityToken = ((uint)(4294967295u));
			this.repLL2.TagName = "864A57C6293E51C2.LevelMeasurementReactor.lowLow";
			this.repLL2.Visible = false;
			this.repLL2.EndInit();
			// 
			// ESTOCAGEM_LODO
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
			this.pE,
			this.pD,
			this.pF,
			this.pM,
			this.co01,
			this.er1,
			this.er2,
			this.er3,
			this.er4,
			this.er5,
			this.di1,
			this.dib1_0,
			this.dib1_1,
			this.dib1_2,
			this.dib1_3,
			this.dib1_4,
			this.er6,
			this.di2,
			this.dib2_0,
			this.dib2_1,
			this.dib2_2,
			this.dib2_3,
			this.dib2_4,
			this.er7,
			this.et8,
			this.et9,
			this.es10,
			this.et11,
			this.es12,
			this.er13,
			this.et14,
			this.et15,
			this.es16,
			this.er17,
			this.et18,
			this.et19,
			this.et20,
			this.et21,
			this.er22,
			this.er23,
			this.et24,
			this.es25,
			this.irDesag,
			this.er26,
			this.et27,
			this.ea28,
			this.et29,
			this.evr30,
			this.evr31,
			this.evm32,
			this.evm33,
			this.evm34,
			this.er35,
			this.er36,
			this.er37,
			this.et38,
			this.ea39,
			this.et40,
			this.evr41,
			this.evr42,
			this.evm43,
			this.evm44,
			this.evm45,
			this.er46,
			this.er47,
			this.et48,
			this.er49,
			this.lit1,
			this.lit2,
			this.va01,
			this.va02,
			this.so1,
			this.vb3,
			this.so2,
			this.vb4,
			this.processo,
			this.revezamento,
			this.btnResetGeral,
			this.repAI1,
			this.repHH1,
			this.repH1,
			this.repL1,
			this.repLL1,
			this.repAI2,
			this.repHH2,
			this.repH2,
			this.repL2,
			this.repLL2,
			this.btnReconhecerGeral});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.Rectangle pE;
		private NxtControl.GuiFramework.Rectangle pD;
		private NxtControl.GuiFramework.Rectangle pF;
		private NxtControl.GuiFramework.Rectangle pM;
		private NxtControl.GuiFramework.Rectangle co01;
		private NxtControl.GuiFramework.FreeText er1;
		private NxtControl.GuiFramework.FreeText er2;
		private NxtControl.GuiFramework.FreeText er3;
		private NxtControl.GuiFramework.FreeText er4;
		private NxtControl.GuiFramework.FreeText er5;
		private NxtControl.GuiFramework.Rectangle di1;
		private NxtControl.GuiFramework.Rectangle dib1_0;
		private NxtControl.GuiFramework.Rectangle dib1_1;
		private NxtControl.GuiFramework.Rectangle dib1_2;
		private NxtControl.GuiFramework.Rectangle dib1_3;
		private NxtControl.GuiFramework.Rectangle dib1_4;
		private NxtControl.GuiFramework.FreeText er6;
		private NxtControl.GuiFramework.Rectangle di2;
		private NxtControl.GuiFramework.Rectangle dib2_0;
		private NxtControl.GuiFramework.Rectangle dib2_1;
		private NxtControl.GuiFramework.Rectangle dib2_2;
		private NxtControl.GuiFramework.Rectangle dib2_3;
		private NxtControl.GuiFramework.Rectangle dib2_4;
		private NxtControl.GuiFramework.FreeText er7;
		private NxtControl.GuiFramework.Rectangle et8;
		private NxtControl.GuiFramework.Rectangle et9;
		private NxtControl.GuiFramework.Polygon es10;
		private NxtControl.GuiFramework.Rectangle et11;
		private NxtControl.GuiFramework.Polygon es12;
		private NxtControl.GuiFramework.FreeText er13;
		private NxtControl.GuiFramework.Rectangle et14;
		private NxtControl.GuiFramework.Rectangle et15;
		private NxtControl.GuiFramework.Polygon es16;
		private NxtControl.GuiFramework.FreeText er17;
		private NxtControl.GuiFramework.Rectangle et18;
		private NxtControl.GuiFramework.Rectangle et19;
		private NxtControl.GuiFramework.Rectangle et20;
		private NxtControl.GuiFramework.Rectangle et21;
		private NxtControl.GuiFramework.FreeText er22;
		private NxtControl.GuiFramework.FreeText er23;
		private NxtControl.GuiFramework.Rectangle et24;
		private NxtControl.GuiFramework.Polygon es25;
		private NxtControl.GuiFramework.ChangeCanvasButton irDesag;
		private NxtControl.GuiFramework.FreeText er26;
		private NxtControl.GuiFramework.Rectangle et27;
		private NxtControl.GuiFramework.Polygon ea28;
		private NxtControl.GuiFramework.Rectangle et29;
		private NxtControl.GuiFramework.Polygon evr30;
		private NxtControl.GuiFramework.Rectangle evr31;
		private NxtControl.GuiFramework.Polygon evm32;
		private NxtControl.GuiFramework.Polygon evm33;
		private NxtControl.GuiFramework.Rectangle evm34;
		private NxtControl.GuiFramework.FreeText er35;
		private NxtControl.GuiFramework.FreeText er36;
		private NxtControl.GuiFramework.FreeText er37;
		private NxtControl.GuiFramework.Rectangle et38;
		private NxtControl.GuiFramework.Polygon ea39;
		private NxtControl.GuiFramework.Rectangle et40;
		private NxtControl.GuiFramework.Polygon evr41;
		private NxtControl.GuiFramework.Rectangle evr42;
		private NxtControl.GuiFramework.Polygon evm43;
		private NxtControl.GuiFramework.Polygon evm44;
		private NxtControl.GuiFramework.Rectangle evm45;
		private NxtControl.GuiFramework.FreeText er46;
		private NxtControl.GuiFramework.FreeText er47;
		private NxtControl.GuiFramework.Rectangle et48;
		private NxtControl.GuiFramework.FreeText er49;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel lit1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sNivel lit2;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula va01;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvula va02;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador so1;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV vb3;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sSoprador so2;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester.sValvulaV vb4;
		private Hidryco.HidrycoLib.Symbols.DesidratacaoLodo.sDefault processo;
		private Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.sAjustes revezamento;
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		private NxtControl.GuiFramework.DrawnButton btnReconhecerGeral;
		private SE.Nereda.Symbols.AnalogInputBase.sInstanceName repAI1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repHH1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repH1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repL1;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repLL1;
		private SE.Nereda.Symbols.AnalogInputBase.sInstanceName repAI2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repHH2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repH2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repL2;
		private SE.App2Base.Symbols.LimitAlarm.sIndicator repLL2;
		#endregion
	}
}
