/*
 * Hidryco - tela HARDWARE (fase solida - serie 900)
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
	/// Summary description for HARDWARE.
	/// </summary>
	partial class HARDWARE
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
			this.cardNER = new NxtControl.GuiFramework.Rectangle();
			this.titNER = new NxtControl.GuiFramework.FreeText();
			this.ipNER = new NxtControl.GuiFramework.FreeText();
			this.sepNER = new NxtControl.GuiFramework.Rectangle();
			this.tremNER = new NxtControl.GuiFramework.FreeText();
			this.nNER0 = new NxtControl.GuiFramework.FreeText();
			this.iNER0 = new NxtControl.GuiFramework.FreeText();
			this.nNER1 = new NxtControl.GuiFramework.FreeText();
			this.iNER1 = new NxtControl.GuiFramework.FreeText();
			this.nNER2 = new NxtControl.GuiFramework.FreeText();
			this.iNER2 = new NxtControl.GuiFramework.FreeText();
			this.nNER3 = new NxtControl.GuiFramework.FreeText();
			this.iNER3 = new NxtControl.GuiFramework.FreeText();
			this.cardSUB = new NxtControl.GuiFramework.Rectangle();
			this.titSUB = new NxtControl.GuiFramework.FreeText();
			this.ipSUB = new NxtControl.GuiFramework.FreeText();
			this.sepSUB = new NxtControl.GuiFramework.Rectangle();
			this.tremSUB = new NxtControl.GuiFramework.FreeText();
			this.nSUB0 = new NxtControl.GuiFramework.FreeText();
			this.iSUB0 = new NxtControl.GuiFramework.FreeText();
			this.nSUB1 = new NxtControl.GuiFramework.FreeText();
			this.iSUB1 = new NxtControl.GuiFramework.FreeText();
			this.nSUB2 = new NxtControl.GuiFramework.FreeText();
			this.iSUB2 = new NxtControl.GuiFramework.FreeText();
			this.nSUB3 = new NxtControl.GuiFramework.FreeText();
			this.iSUB3 = new NxtControl.GuiFramework.FreeText();
			this.nSUB4 = new NxtControl.GuiFramework.FreeText();
			this.iSUB4 = new NxtControl.GuiFramework.FreeText();
			this.nSUB5 = new NxtControl.GuiFramework.FreeText();
			this.iSUB5 = new NxtControl.GuiFramework.FreeText();
			this.nSUB6 = new NxtControl.GuiFramework.FreeText();
			this.iSUB6 = new NxtControl.GuiFramework.FreeText();
			this.cardLODO = new NxtControl.GuiFramework.Rectangle();
			this.titLODO = new NxtControl.GuiFramework.FreeText();
			this.ipLODO = new NxtControl.GuiFramework.FreeText();
			this.sepLODO = new NxtControl.GuiFramework.Rectangle();
			this.tremLODO = new NxtControl.GuiFramework.FreeText();
			this.nLODO0 = new NxtControl.GuiFramework.FreeText();
			this.iLODO0 = new NxtControl.GuiFramework.FreeText();
			this.nLODO1 = new NxtControl.GuiFramework.FreeText();
			this.iLODO1 = new NxtControl.GuiFramework.FreeText();
			this.nLODO2 = new NxtControl.GuiFramework.FreeText();
			this.iLODO2 = new NxtControl.GuiFramework.FreeText();
			this.cpuNER = new SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault();
			this.srNER0 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srNER1 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srNER2 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srNER3 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.cpuSUB = new SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault();
			this.srSUB0 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srSUB1 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srSUB2 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srSUB3 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srSUB4 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srSUB5 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srSUB6 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.cpuLODO = new SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault();
			this.srLODO0 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srLODO1 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
			this.srLODO2 = new Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault();
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
			// cardNER
			// 
			this.cardNER.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(436D)), ((float)(666D)));
			this.cardNER.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.cardNER.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cardNER.Name = "cardNER";
			this.cardNER.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titNER
			// 
			this.titNER.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.titNER.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.titNER.Location = new NxtControl.Drawing.PointF(28D, 24D);
			this.titNER.Name = "titNER";
			this.titNER.Text = "CLP NEREDA";
			// 
			// ipNER
			// 
			this.ipNER.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.ipNER.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.ipNER.Location = new NxtControl.Drawing.PointF(28D, 44D);
			this.ipNER.Name = "ipNER";
			this.ipNER.Text = "M262 (TM262L01MDESE8T) - 10.26.208.141";
			// 
			// sepNER
			// 
			this.sepNER.Bounds = new NxtControl.Drawing.RectF(((float)(28D)), ((float)(309.79998779296875D)), ((float)(412D)), ((float)(1D)));
			this.sepNER.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.sepNER.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepNER.Name = "sepNER";
			this.sepNER.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tremNER
			// 
			this.tremNER.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.tremNER.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tremNER.Location = new NxtControl.Drawing.PointF(28D, 317.8D);
			this.tremNER.Name = "tremNER";
			this.tremNER.Text = "COMUNICAÇÃO COM AS REMOTAS";
			// 
			// nNER0
			// 
			this.nNER0.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nNER0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nNER0.Location = new NxtControl.Drawing.PointF(28D, 341.8D);
			this.nNER0.Name = "nNER0";
			this.nNER0.Text = "Remota 1 Nereda";
			// 
			// iNER0
			// 
			this.iNER0.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iNER0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iNER0.Location = new NxtControl.Drawing.PointF(28D, 356.8D);
			this.iNER0.Name = "iNER0";
			this.iNER0.Text = "10.26.208.160";
			// 
			// nNER1
			// 
			this.nNER1.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nNER1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nNER1.Location = new NxtControl.Drawing.PointF(28D, 377.8D);
			this.nNER1.Name = "nNER1";
			this.nNER1.Text = "Remota 2 Nereda";
			// 
			// iNER1
			// 
			this.iNER1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iNER1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iNER1.Location = new NxtControl.Drawing.PointF(28D, 392.8D);
			this.iNER1.Name = "iNER1";
			this.iNER1.Text = "10.26.208.161";
			// 
			// nNER2
			// 
			this.nNER2.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nNER2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nNER2.Location = new NxtControl.Drawing.PointF(28D, 413.8D);
			this.nNER2.Name = "nNER2";
			this.nNER2.Text = "Remota 1 Subestação";
			// 
			// iNER2
			// 
			this.iNER2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iNER2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iNER2.Location = new NxtControl.Drawing.PointF(28D, 428.8D);
			this.iNER2.Name = "iNER2";
			this.iNER2.Text = "10.26.208.192";
			// 
			// nNER3
			// 
			this.nNER3.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nNER3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nNER3.Location = new NxtControl.Drawing.PointF(28D, 449.8D);
			this.nNER3.Name = "nNER3";
			this.nNER3.Text = "Remota 2 PCE Lodo";
			// 
			// iNER3
			// 
			this.iNER3.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iNER3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iNER3.Location = new NxtControl.Drawing.PointF(28D, 464.8D);
			this.iNER3.Name = "iNER3";
			this.iNER3.Text = "10.26.208.136";
			// 
			// cardSUB
			// 
			this.cardSUB.Bounds = new NxtControl.Drawing.RectF(((float)(463D)), ((float)(16D)), ((float)(436D)), ((float)(666D)));
			this.cardSUB.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.cardSUB.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cardSUB.Name = "cardSUB";
			this.cardSUB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titSUB
			// 
			this.titSUB.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.titSUB.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.titSUB.Location = new NxtControl.Drawing.PointF(475D, 24D);
			this.titSUB.Name = "titSUB";
			this.titSUB.Text = "CLP SUBESTAÇÃO";
			// 
			// ipSUB
			// 
			this.ipSUB.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.ipSUB.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.ipSUB.Location = new NxtControl.Drawing.PointF(475D, 44D);
			this.ipSUB.Name = "ipSUB";
			this.ipSUB.Text = "M262 (TM262L01MDESE8T) - 10.26.208.171";
			// 
			// sepSUB
			// 
			this.sepSUB.Bounds = new NxtControl.Drawing.RectF(((float)(475D)), ((float)(309.79998779296875D)), ((float)(412D)), ((float)(1D)));
			this.sepSUB.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.sepSUB.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepSUB.Name = "sepSUB";
			this.sepSUB.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tremSUB
			// 
			this.tremSUB.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.tremSUB.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tremSUB.Location = new NxtControl.Drawing.PointF(475D, 317.8D);
			this.tremSUB.Name = "tremSUB";
			this.tremSUB.Text = "COMUNICAÇÃO COM AS REMOTAS";
			// 
			// nSUB0
			// 
			this.nSUB0.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nSUB0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nSUB0.Location = new NxtControl.Drawing.PointF(475D, 341.8D);
			this.nSUB0.Name = "nSUB0";
			this.nSUB0.Text = "Remota 1 Subestação";
			// 
			// iSUB0
			// 
			this.iSUB0.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iSUB0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iSUB0.Location = new NxtControl.Drawing.PointF(475D, 356.8D);
			this.iSUB0.Name = "iSUB0";
			this.iSUB0.Text = "10.26.208.192";
			// 
			// nSUB1
			// 
			this.nSUB1.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nSUB1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nSUB1.Location = new NxtControl.Drawing.PointF(475D, 377.8D);
			this.nSUB1.Name = "nSUB1";
			this.nSUB1.Text = "Remota 2 Subestação";
			// 
			// iSUB1
			// 
			this.iSUB1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iSUB1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iSUB1.Location = new NxtControl.Drawing.PointF(475D, 392.8D);
			this.iSUB1.Name = "iSUB1";
			this.iSUB1.Text = "10.26.208.193";
			// 
			// nSUB2
			// 
			this.nSUB2.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nSUB2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nSUB2.Location = new NxtControl.Drawing.PointF(475D, 413.8D);
			this.nSUB2.Name = "nSUB2";
			this.nSUB2.Text = "Remota 1 Nereda";
			// 
			// iSUB2
			// 
			this.iSUB2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iSUB2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iSUB2.Location = new NxtControl.Drawing.PointF(475D, 428.8D);
			this.iSUB2.Name = "iSUB2";
			this.iSUB2.Text = "10.26.208.160";
			// 
			// nSUB3
			// 
			this.nSUB3.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nSUB3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nSUB3.Location = new NxtControl.Drawing.PointF(475D, 449.8D);
			this.nSUB3.Name = "nSUB3";
			this.nSUB3.Text = "Remota 2 Nereda";
			// 
			// iSUB3
			// 
			this.iSUB3.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iSUB3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iSUB3.Location = new NxtControl.Drawing.PointF(475D, 464.8D);
			this.iSUB3.Name = "iSUB3";
			this.iSUB3.Text = "10.26.208.161";
			// 
			// nSUB4
			// 
			this.nSUB4.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nSUB4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nSUB4.Location = new NxtControl.Drawing.PointF(475D, 485.8D);
			this.nSUB4.Name = "nSUB4";
			this.nSUB4.Text = "Remota EEE Bruto";
			// 
			// iSUB4
			// 
			this.iSUB4.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iSUB4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iSUB4.Location = new NxtControl.Drawing.PointF(475D, 500.8D);
			this.iSUB4.Name = "iSUB4";
			this.iSUB4.Text = "10.26.208.197";
			// 
			// nSUB5
			// 
			this.nSUB5.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nSUB5.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nSUB5.Location = new NxtControl.Drawing.PointF(475D, 521.8D);
			this.nSUB5.Name = "nSUB5";
			this.nSUB5.Text = "Remota EEE Bruto (disjuntores)";
			// 
			// iSUB5
			// 
			this.iSUB5.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iSUB5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iSUB5.Location = new NxtControl.Drawing.PointF(475D, 536.8D);
			this.iSUB5.Name = "iSUB5";
			this.iSUB5.Text = "10.26.208.197";
			// 
			// nSUB6
			// 
			this.nSUB6.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nSUB6.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nSUB6.Location = new NxtControl.Drawing.PointF(475D, 557.8D);
			this.nSUB6.Name = "nSUB6";
			this.nSUB6.Text = "Remota Desinfecção (disjuntores)";
			// 
			// iSUB6
			// 
			this.iSUB6.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iSUB6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iSUB6.Location = new NxtControl.Drawing.PointF(475D, 572.8D);
			this.iSUB6.Name = "iSUB6";
			this.iSUB6.Text = "10.26.208.137";
			// 
			// cardLODO
			// 
			this.cardLODO.Bounds = new NxtControl.Drawing.RectF(((float)(910D)), ((float)(16D)), ((float)(436D)), ((float)(666D)));
			this.cardLODO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.cardLODO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cardLODO.Name = "cardLODO";
			this.cardLODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titLODO
			// 
			this.titLODO.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.titLODO.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.titLODO.Location = new NxtControl.Drawing.PointF(922D, 24D);
			this.titLODO.Name = "titLODO";
			this.titLODO.Text = "CLP LODO";
			// 
			// ipLODO
			// 
			this.ipLODO.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.ipLODO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.ipLODO.Location = new NxtControl.Drawing.PointF(922D, 44D);
			this.ipLODO.Name = "ipLODO";
			this.ipLODO.Text = "M262 (TM262L01MDESE8T) - 10.26.208.233";
			// 
			// sepLODO
			// 
			this.sepLODO.Bounds = new NxtControl.Drawing.RectF(((float)(922D)), ((float)(309.79998779296875D)), ((float)(412D)), ((float)(1D)));
			this.sepLODO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.sepLODO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sepLODO.Name = "sepLODO";
			this.sepLODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tremLODO
			// 
			this.tremLODO.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.tremLODO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.tremLODO.Location = new NxtControl.Drawing.PointF(922D, 317.8D);
			this.tremLODO.Name = "tremLODO";
			this.tremLODO.Text = "COMUNICAÇÃO COM AS REMOTAS";
			// 
			// nLODO0
			// 
			this.nLODO0.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nLODO0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nLODO0.Location = new NxtControl.Drawing.PointF(922D, 341.8D);
			this.nLODO0.Name = "nLODO0";
			this.nLODO0.Text = "Remota 1 PCE Lodo";
			// 
			// iLODO0
			// 
			this.iLODO0.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iLODO0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iLODO0.Location = new NxtControl.Drawing.PointF(922D, 356.8D);
			this.iLODO0.Name = "iLODO0";
			this.iLODO0.Text = "10.26.208.135";
			// 
			// nLODO1
			// 
			this.nLODO1.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nLODO1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nLODO1.Location = new NxtControl.Drawing.PointF(922D, 377.8D);
			this.nLODO1.Name = "nLODO1";
			this.nLODO1.Text = "Remota 2 PCE Lodo";
			// 
			// iLODO1
			// 
			this.iLODO1.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iLODO1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iLODO1.Location = new NxtControl.Drawing.PointF(922D, 392.8D);
			this.iLODO1.Name = "iLODO1";
			this.iLODO1.Text = "10.26.208.136";
			// 
			// nLODO2
			// 
			this.nLODO2.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.nLODO2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.nLODO2.Location = new NxtControl.Drawing.PointF(922D, 413.8D);
			this.nLODO2.Name = "nLODO2";
			this.nLODO2.Text = "Remota Desinfecção";
			// 
			// iLODO2
			// 
			this.iLODO2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.iLODO2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.iLODO2.Location = new NxtControl.Drawing.PointF(922D, 428.8D);
			this.iLODO2.Name = "iLODO2";
			this.iLODO2.Text = "10.26.208.137";
			// 
			// cpuNER
			// 
			this.cpuNER.BeginInit();
			this.cpuNER.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.6D, 102D, 68D);
			this.cpuNER.HeaderText = "";
			this.cpuNER.Name = "cpuNER";
			this.cpuNER.SecurityToken = ((uint)(4294967295u));
			this.cpuNER.TagName = "F903885E680FD8F5";
			this.cpuNER.EndInit();
			// 
			// srNER0
			// 
			this.srNER0.BeginInit();
			this.srNER0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 290D, 343.8D);
			this.srNER0.Name = "srNER0";
			this.srNER0.SecurityToken = ((uint)(4294967295u));
			this.srNER0.TagName = "E57026332EC0CF01";
			this.srNER0.EndInit();
			// 
			// srNER1
			// 
			this.srNER1.BeginInit();
			this.srNER1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 290D, 379.8D);
			this.srNER1.Name = "srNER1";
			this.srNER1.SecurityToken = ((uint)(4294967295u));
			this.srNER1.TagName = "9C3050DACF8431CE";
			this.srNER1.EndInit();
			// 
			// srNER2
			// 
			this.srNER2.BeginInit();
			this.srNER2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 290D, 415.8D);
			this.srNER2.Name = "srNER2";
			this.srNER2.SecurityToken = ((uint)(4294967295u));
			this.srNER2.TagName = "88AE0F64351B6093";
			this.srNER2.EndInit();
			// 
			// srNER3
			// 
			this.srNER3.BeginInit();
			this.srNER3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 290D, 451.8D);
			this.srNER3.Name = "srNER3";
			this.srNER3.SecurityToken = ((uint)(4294967295u));
			this.srNER3.TagName = "0907E87DC9E1E380";
			this.srNER3.EndInit();
			// 
			// cpuSUB
			// 
			this.cpuSUB.BeginInit();
			this.cpuSUB.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.6D, 549D, 68D);
			this.cpuSUB.HeaderText = "";
			this.cpuSUB.Name = "cpuSUB";
			this.cpuSUB.SecurityToken = ((uint)(4294967295u));
			this.cpuSUB.TagName = "A23BEDB2E110854E";
			this.cpuSUB.EndInit();
			// 
			// srSUB0
			// 
			this.srSUB0.BeginInit();
			this.srSUB0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 737D, 343.8D);
			this.srSUB0.Name = "srSUB0";
			this.srSUB0.SecurityToken = ((uint)(4294967295u));
			this.srSUB0.TagName = "294781865734AD7D";
			this.srSUB0.EndInit();
			// 
			// srSUB1
			// 
			this.srSUB1.BeginInit();
			this.srSUB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 737D, 379.8D);
			this.srSUB1.Name = "srSUB1";
			this.srSUB1.SecurityToken = ((uint)(4294967295u));
			this.srSUB1.TagName = "E0B25410AE7B3070";
			this.srSUB1.EndInit();
			// 
			// srSUB2
			// 
			this.srSUB2.BeginInit();
			this.srSUB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 737D, 415.8D);
			this.srSUB2.Name = "srSUB2";
			this.srSUB2.SecurityToken = ((uint)(4294967295u));
			this.srSUB2.TagName = "E241FC016E76FED3";
			this.srSUB2.EndInit();
			// 
			// srSUB3
			// 
			this.srSUB3.BeginInit();
			this.srSUB3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 737D, 451.8D);
			this.srSUB3.Name = "srSUB3";
			this.srSUB3.SecurityToken = ((uint)(4294967295u));
			this.srSUB3.TagName = "C5E3911A48E94342";
			this.srSUB3.EndInit();
			// 
			// srSUB4
			// 
			this.srSUB4.BeginInit();
			this.srSUB4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 737D, 487.8D);
			this.srSUB4.Name = "srSUB4";
			this.srSUB4.SecurityToken = ((uint)(4294967295u));
			this.srSUB4.TagName = "9D869F3B338DF2C5";
			this.srSUB4.EndInit();
			// 
			// srSUB5
			// 
			this.srSUB5.BeginInit();
			this.srSUB5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 737D, 523.8D);
			this.srSUB5.Name = "srSUB5";
			this.srSUB5.SecurityToken = ((uint)(4294967295u));
			this.srSUB5.TagName = "BE9921D35E7FDA37";
			this.srSUB5.EndInit();
			// 
			// srSUB6
			// 
			this.srSUB6.BeginInit();
			this.srSUB6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 737D, 559.8D);
			this.srSUB6.Name = "srSUB6";
			this.srSUB6.SecurityToken = ((uint)(4294967295u));
			this.srSUB6.TagName = "B273AE8F8D95673F";
			this.srSUB6.EndInit();
			// 
			// cpuLODO
			// 
			this.cpuLODO.BeginInit();
			this.cpuLODO.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.6D, 996D, 68D);
			this.cpuLODO.HeaderText = "";
			this.cpuLODO.Name = "cpuLODO";
			this.cpuLODO.SecurityToken = ((uint)(4294967295u));
			this.cpuLODO.TagName = "FD385B7D036577B0";
			this.cpuLODO.EndInit();
			// 
			// srLODO0
			// 
			this.srLODO0.BeginInit();
			this.srLODO0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1184D, 343.8D);
			this.srLODO0.Name = "srLODO0";
			this.srLODO0.SecurityToken = ((uint)(4294967295u));
			this.srLODO0.TagName = "66435548ACD30686";
			this.srLODO0.EndInit();
			// 
			// srLODO1
			// 
			this.srLODO1.BeginInit();
			this.srLODO1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1184D, 379.8D);
			this.srLODO1.Name = "srLODO1";
			this.srLODO1.SecurityToken = ((uint)(4294967295u));
			this.srLODO1.TagName = "1BB124F2883B68FB";
			this.srLODO1.EndInit();
			// 
			// srLODO2
			// 
			this.srLODO2.BeginInit();
			this.srLODO2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1184D, 415.8D);
			this.srLODO2.Name = "srLODO2";
			this.srLODO2.SecurityToken = ((uint)(4294967295u));
			this.srLODO2.TagName = "265BB641B3F671EF";
			this.srLODO2.EndInit();
			// 
			// HARDWARE
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.cardNER,
			this.titNER,
			this.ipNER,
			this.sepNER,
			this.tremNER,
			this.nNER0,
			this.iNER0,
			this.nNER1,
			this.iNER1,
			this.nNER2,
			this.iNER2,
			this.nNER3,
			this.iNER3,
			this.cardSUB,
			this.titSUB,
			this.ipSUB,
			this.sepSUB,
			this.tremSUB,
			this.nSUB0,
			this.iSUB0,
			this.nSUB1,
			this.iSUB1,
			this.nSUB2,
			this.iSUB2,
			this.nSUB3,
			this.iSUB3,
			this.nSUB4,
			this.iSUB4,
			this.nSUB5,
			this.iSUB5,
			this.nSUB6,
			this.iSUB6,
			this.cardLODO,
			this.titLODO,
			this.ipLODO,
			this.sepLODO,
			this.tremLODO,
			this.nLODO0,
			this.iLODO0,
			this.nLODO1,
			this.iLODO1,
			this.nLODO2,
			this.iLODO2,
			this.cpuNER,
			this.srNER0,
			this.srNER1,
			this.srNER2,
			this.srNER3,
			this.cpuSUB,
			this.srSUB0,
			this.srSUB1,
			this.srSUB2,
			this.srSUB3,
			this.srSUB4,
			this.srSUB5,
			this.srSUB6,
			this.cpuLODO,
			this.srLODO0,
			this.srLODO1,
			this.srLODO2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.Rectangle cardNER;
		private NxtControl.GuiFramework.FreeText titNER;
		private NxtControl.GuiFramework.FreeText ipNER;
		private NxtControl.GuiFramework.Rectangle sepNER;
		private NxtControl.GuiFramework.FreeText tremNER;
		private NxtControl.GuiFramework.FreeText nNER0;
		private NxtControl.GuiFramework.FreeText iNER0;
		private NxtControl.GuiFramework.FreeText nNER1;
		private NxtControl.GuiFramework.FreeText iNER1;
		private NxtControl.GuiFramework.FreeText nNER2;
		private NxtControl.GuiFramework.FreeText iNER2;
		private NxtControl.GuiFramework.FreeText nNER3;
		private NxtControl.GuiFramework.FreeText iNER3;
		private NxtControl.GuiFramework.Rectangle cardSUB;
		private NxtControl.GuiFramework.FreeText titSUB;
		private NxtControl.GuiFramework.FreeText ipSUB;
		private NxtControl.GuiFramework.Rectangle sepSUB;
		private NxtControl.GuiFramework.FreeText tremSUB;
		private NxtControl.GuiFramework.FreeText nSUB0;
		private NxtControl.GuiFramework.FreeText iSUB0;
		private NxtControl.GuiFramework.FreeText nSUB1;
		private NxtControl.GuiFramework.FreeText iSUB1;
		private NxtControl.GuiFramework.FreeText nSUB2;
		private NxtControl.GuiFramework.FreeText iSUB2;
		private NxtControl.GuiFramework.FreeText nSUB3;
		private NxtControl.GuiFramework.FreeText iSUB3;
		private NxtControl.GuiFramework.FreeText nSUB4;
		private NxtControl.GuiFramework.FreeText iSUB4;
		private NxtControl.GuiFramework.FreeText nSUB5;
		private NxtControl.GuiFramework.FreeText iSUB5;
		private NxtControl.GuiFramework.FreeText nSUB6;
		private NxtControl.GuiFramework.FreeText iSUB6;
		private NxtControl.GuiFramework.Rectangle cardLODO;
		private NxtControl.GuiFramework.FreeText titLODO;
		private NxtControl.GuiFramework.FreeText ipLODO;
		private NxtControl.GuiFramework.Rectangle sepLODO;
		private NxtControl.GuiFramework.FreeText tremLODO;
		private NxtControl.GuiFramework.FreeText nLODO0;
		private NxtControl.GuiFramework.FreeText iLODO0;
		private NxtControl.GuiFramework.FreeText nLODO1;
		private NxtControl.GuiFramework.FreeText iLODO1;
		private NxtControl.GuiFramework.FreeText nLODO2;
		private NxtControl.GuiFramework.FreeText iLODO2;
		private SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault cpuNER;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srNER0;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srNER1;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srNER2;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srNER3;
		private SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault cpuSUB;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srSUB0;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srSUB1;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srSUB2;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srSUB3;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srSUB4;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srSUB5;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srSUB6;
		private SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault cpuLODO;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srLODO0;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srLODO1;
		private Hidryco.HidrycoLib.Symbols.Status_Remota.sDefault srLODO2;
		#endregion
	}
}
