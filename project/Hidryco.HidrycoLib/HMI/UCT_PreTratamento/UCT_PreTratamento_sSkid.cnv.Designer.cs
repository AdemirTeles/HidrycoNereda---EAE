/*
 * Hidryco - UCT_PreTratamento - sSkid
 * Desenho do skid da UCT (arranjo do Pre_Tratamento antigo) com os simbolos dos equipamentos, subsistemas, niveis, bomba de gordura e valvula de lavagem.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_PreTratamento
{
	/// <summary>
	/// Summary description for sSkid.
	/// </summary>
	partial class sSkid
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.pnlHig = new NxtControl.GuiFramework.Rectangle();
			this.tHig = new NxtControl.GuiFramework.FreeText();
			this.tbSuc = new NxtControl.GuiFramework.Pipe();
			this.tbSuc2 = new NxtControl.GuiFramework.Pipe();
			this.tbRec1 = new NxtControl.GuiFramework.Pipe();
			this.tbRec2 = new NxtControl.GuiFramework.Pipe();
			this.tbRecTie = new NxtControl.GuiFramework.Pipe();
			this.tqAgua = new NxtControl.GuiFramework.Rectangle();
			this.rTqAgua = new NxtControl.GuiFramework.FreeText();
			this.Bomba1 = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sBomba();
			this.Bomba2 = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sBomba();
			this.Valvula1 = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sValvula();
			this.Valvula2 = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sValvula();
			this.rSel = new NxtControl.GuiFramework.FreeText();
			this.btnB1 = new NxtControl.GuiFramework.DrawnButton();
			this.btnB2 = new NxtControl.GuiFramework.DrawnButton();
			this.pnlSub = new NxtControl.GuiFramework.Rectangle();
			this.tSub = new NxtControl.GuiFramework.FreeText();
			this.rPen = new NxtControl.GuiFramework.FreeText();
			this.btnManPen = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutoPen = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesPen = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigPen = new NxtControl.GuiFramework.DrawnButton();
			this.rRos = new NxtControl.GuiFramework.FreeText();
			this.btnManRos = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutoRos = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesRos = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigRos = new NxtControl.GuiFramework.DrawnButton();
			this.rRc = new NxtControl.GuiFramework.FreeText();
			this.btnManRc = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutoRc = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesRc = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigRc = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnDetalhes = new NxtControl.GuiFramework.DrawnButton();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.textoBloq = new NxtControl.GuiFramework.FreeText();
			this.tbChegada = new NxtControl.GuiFramework.Pipe();
			this.rChegada = new NxtControl.GuiFramework.FreeText();
			this.tbCesto = new NxtControl.GuiFramework.Pipe();
			this.rCesto = new NxtControl.GuiFramework.FreeText();
			this.tbRoscaPen = new NxtControl.GuiFramework.Pipe();
			this.rRoscaPen = new NxtControl.GuiFramework.FreeText();
			this.tbQueda = new NxtControl.GuiFramework.Pipe();
			this.tanque = new NxtControl.GuiFramework.Polygon();
			this.pe0 = new NxtControl.GuiFramework.Rectangle();
			this.pe1 = new NxtControl.GuiFramework.Rectangle();
			this.pe2 = new NxtControl.GuiFramework.Rectangle();
			this.tbSaidaEsgoto = new NxtControl.GuiFramework.Pipe();
			this.rSaidaEsgoto = new NxtControl.GuiFramework.FreeText();
			this.tbAr = new NxtControl.GuiFramework.Pipe();
			this.tbGordura = new NxtControl.GuiFramework.Pipe();
			this.tbLavagem = new NxtControl.GuiFramework.Pipe();
			this.tbSucG = new NxtControl.GuiFramework.Pipe();
			this.tbRecG = new NxtControl.GuiFramework.Pipe();
			this.cacamba = new NxtControl.GuiFramework.Rectangle();
			this.rCacamba = new NxtControl.GuiFramework.FreeText();
			this.Peneira = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sPeneira();
			this.rNivel = new NxtControl.GuiFramework.FreeText();
			this.vNivel = new System.HMI.Symbols.Base.Label<System.Single>();
			this.Raspador = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sRaspador();
			this.Rosca1 = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sRosca();
			this.Rosca2 = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sRoscaInclinada();
			this.Compressor = new Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sCompressor();
			this.tqGordura = new NxtControl.GuiFramework.Rectangle();
			this.rTqGordura = new NxtControl.GuiFramework.FreeText();
			this.rTqGordura2 = new NxtControl.GuiFramework.FreeText();
			this.vNivelG = new System.HMI.Symbols.Base.FreeText<bool>();
			this.rLavagem = new NxtControl.GuiFramework.FreeText();
			this.vl1 = new NxtControl.GuiFramework.Polygon();
			this.vl2 = new NxtControl.GuiFramework.Polygon();
			this.vlHaste = new NxtControl.GuiFramework.Line();
			this.vlAtuador = new NxtControl.GuiFramework.Rectangle();
			this.textoValv = new NxtControl.GuiFramework.FreeText();
			this.abrirValv = new NxtControl.GuiFramework.DrawnButton();
			this.BombaGordura = new Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba();
			this.rSaidaG = new NxtControl.GuiFramework.FreeText();
			this.textoEtapa = new NxtControl.GuiFramework.FreeText();
			this.vRest = new System.HMI.Symbols.Base.Label<System.Int16>();
			this.pnlNiv = new NxtControl.GuiFramework.Rectangle();
			this.tNiv = new NxtControl.GuiFramework.FreeText();
			this.rn0 = new NxtControl.GuiFramework.FreeText();
			this.vn0 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.rn1 = new NxtControl.GuiFramework.FreeText();
			this.vn1 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.rn2 = new NxtControl.GuiFramework.FreeText();
			this.vn2 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.x_aCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aEMERGENCIA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFPEN = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFB1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFB2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFCMP = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFRSP = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFR1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aDEFR2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aNIVELAGUA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_aNIVELPENEIRA = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_eCOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eEMERGENCIA = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFPEN = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFB1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFB2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFCMP = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFRSP = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFR1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eDEFR2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eNIVELAGUA = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_eNIVELPENEIRA = new System.HMI.Symbols.Base.Execute<byte>();
			this.x_disp = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_hab = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_bloq = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_autoPen = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_autoRos = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_autoRc = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_ligPen = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_ligRos = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_ligRc = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_selB2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_valv = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_etapa = new System.HMI.Symbols.Base.Execute<short>();
			this.x_nAltoG = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pnlHig
			// 
			this.pnlHig.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(10D)), ((float)(300D)), ((float)(330D)));
			this.pnlHig.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.pnlHig.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pnlHig.Name = "pnlHig";
			this.pnlHig.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tHig
			// 
			this.tHig.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tHig.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tHig.Location = new NxtControl.Drawing.PointF(20D, 16D);
			this.tHig.Name = "tHig";
			this.tHig.Text = "Higienização";
			// 
			// tbSuc
			// 
			this.tbSuc.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(87D)), ((float)(31D)), ((float)(203D)));
			this.tbSuc.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSuc.Name = "tbSuc";
			this.tbSuc.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSuc.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(55D, 290D),
			new NxtControl.Drawing.PointF(55D, 272D),
			new NxtControl.Drawing.PointF(24D, 272D),
			new NxtControl.Drawing.PointF(24D, 87D),
			new NxtControl.Drawing.PointF(50D, 87D)});
			this.tbSuc.Width = 5;
			// 
			// tbSuc2
			// 
			this.tbSuc2.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(217D)), ((float)(26D)), ((float)(0D)));
			this.tbSuc2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSuc2.Name = "tbSuc2";
			this.tbSuc2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSuc2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 217D),
			new NxtControl.Drawing.PointF(50D, 217D)});
			this.tbSuc2.Width = 5;
			// 
			// tbRec1
			// 
			this.tbRec1.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(58.5D)), ((float)(72D)), ((float)(0D)));
			this.tbRec1.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbRec1.Name = "tbRec1";
			this.tbRec1.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbRec1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(120D, 58.5D),
			new NxtControl.Drawing.PointF(192D, 58.5D)});
			this.tbRec1.Width = 5;
			// 
			// tbRec2
			// 
			this.tbRec2.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(188.5D)), ((float)(72D)), ((float)(0D)));
			this.tbRec2.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbRec2.Name = "tbRec2";
			this.tbRec2.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbRec2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(120D, 188.5D),
			new NxtControl.Drawing.PointF(192D, 188.5D)});
			this.tbRec2.Width = 5;
			// 
			// tbRecTie
			// 
			this.tbRecTie.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(58.5D)), ((float)(0D)), ((float)(130D)));
			this.tbRecTie.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbRecTie.Name = "tbRecTie";
			this.tbRecTie.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbRecTie.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(150D, 58.5D),
			new NxtControl.Drawing.PointF(150D, 188.5D)});
			this.tbRecTie.Width = 5;
			// 
			// tqAgua
			// 
			this.tqAgua.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(290D)), ((float)(70D)), ((float)(40D)));
			this.tqAgua.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.tqAgua.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tqAgua.Name = "tqAgua";
			this.tqAgua.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rTqAgua
			// 
			this.rTqAgua.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rTqAgua.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rTqAgua.Location = new NxtControl.Drawing.PointF(26D, 302D);
			this.rTqAgua.Name = "rTqAgua";
			this.rTqAgua.Text = "Água";
			// 
			// Bomba1
			// 
			this.Bomba1.BeginInit();
			this.Bomba1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 40D);
			this.Bomba1.Name = "Bomba1";
			this.Bomba1.SecurityToken = ((uint)(4294967295u));
			this.Bomba1.TagName = "Bomba1";
			this.Bomba1.EndInit();
			// 
			// Bomba2
			// 
			this.Bomba2.BeginInit();
			this.Bomba2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 170D);
			this.Bomba2.Name = "Bomba2";
			this.Bomba2.SecurityToken = ((uint)(4294967295u));
			this.Bomba2.TagName = "Bomba2";
			this.Bomba2.EndInit();
			// 
			// Valvula1
			// 
			this.Valvula1.BeginInit();
			this.Valvula1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 180D, 11D);
			this.Valvula1.Name = "Valvula1";
			this.Valvula1.SecurityToken = ((uint)(4294967295u));
			this.Valvula1.TagName = "Valvula1";
			this.Valvula1.EndInit();
			// 
			// Valvula2
			// 
			this.Valvula2.BeginInit();
			this.Valvula2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 180D, 141D);
			this.Valvula2.Name = "Valvula2";
			this.Valvula2.SecurityToken = ((uint)(4294967295u));
			this.Valvula2.TagName = "Valvula2";
			this.Valvula2.EndInit();
			// 
			// rSel
			// 
			this.rSel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rSel.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rSel.Location = new NxtControl.Drawing.PointF(110D, 280D);
			this.rSel.Name = "rSel";
			this.rSel.Text = "Bomba em uso";
			// 
			// btnB1
			// 
			this.btnB1.Bounds = new NxtControl.Drawing.RectF(((float)(110D)), ((float)(296D)), ((float)(92D)), ((float)(32D)));
			this.btnB1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnB1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnB1.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnB1.Name = "btnB1";
			this.btnB1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnB1.Radius = 2D;
			this.btnB1.Text = "Bomba 1";
			this.btnB1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnB1.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnB1.Use3DEffect = false;
			this.btnB1.Click += new System.EventHandler(this.BtnB1Click);
			// 
			// btnB2
			// 
			this.btnB2.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(296D)), ((float)(92D)), ((float)(32D)));
			this.btnB2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnB2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnB2.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnB2.Name = "btnB2";
			this.btnB2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnB2.Radius = 2D;
			this.btnB2.Text = "Bomba 2";
			this.btnB2.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnB2.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnB2.Use3DEffect = false;
			this.btnB2.Click += new System.EventHandler(this.BtnB2Click);
			// 
			// pnlSub
			// 
			this.pnlSub.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(350D)), ((float)(300D)), ((float)(262D)));
			this.pnlSub.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.pnlSub.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pnlSub.Name = "pnlSub";
			this.pnlSub.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSub
			// 
			this.tSub.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tSub.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tSub.Location = new NxtControl.Drawing.PointF(20D, 356D);
			this.tSub.Name = "tSub";
			this.tSub.Text = "Subsistemas";
			// 
			// rPen
			// 
			this.rPen.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rPen.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rPen.Location = new NxtControl.Drawing.PointF(20D, 380D);
			this.rPen.Name = "rPen";
			this.rPen.Text = "Peneira e higienização";
			// 
			// btnManPen
			// 
			this.btnManPen.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(398D)), ((float)(66D)), ((float)(30D)));
			this.btnManPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManPen.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnManPen.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManPen.Name = "btnManPen";
			this.btnManPen.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManPen.Radius = 2D;
			this.btnManPen.Text = "Manual";
			this.btnManPen.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManPen.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManPen.Use3DEffect = false;
			this.btnManPen.Click += new System.EventHandler(this.BtnManPenClick);
			// 
			// btnAutoPen
			// 
			this.btnAutoPen.Bounds = new NxtControl.Drawing.RectF(((float)(90D)), ((float)(398D)), ((float)(76D)), ((float)(30D)));
			this.btnAutoPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutoPen.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnAutoPen.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAutoPen.Name = "btnAutoPen";
			this.btnAutoPen.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAutoPen.Radius = 2D;
			this.btnAutoPen.Text = "Automático";
			this.btnAutoPen.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutoPen.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutoPen.Use3DEffect = false;
			this.btnAutoPen.Click += new System.EventHandler(this.BtnAutoPenClick);
			// 
			// btnDesPen
			// 
			this.btnDesPen.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(398D)), ((float)(62D)), ((float)(30D)));
			this.btnDesPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesPen.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnDesPen.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesPen.Name = "btnDesPen";
			this.btnDesPen.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesPen.Radius = 2D;
			this.btnDesPen.Text = "Desliga";
			this.btnDesPen.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesPen.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesPen.Use3DEffect = false;
			this.btnDesPen.Click += new System.EventHandler(this.BtnDesPenClick);
			// 
			// btnLigPen
			// 
			this.btnLigPen.Bounds = new NxtControl.Drawing.RectF(((float)(242D)), ((float)(398D)), ((float)(58D)), ((float)(30D)));
			this.btnLigPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigPen.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnLigPen.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLigPen.Name = "btnLigPen";
			this.btnLigPen.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLigPen.Radius = 2D;
			this.btnLigPen.Text = "Liga";
			this.btnLigPen.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigPen.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigPen.Use3DEffect = false;
			this.btnLigPen.Click += new System.EventHandler(this.BtnLigPenClick);
			// 
			// rRos
			// 
			this.rRos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rRos.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rRos.Location = new NxtControl.Drawing.PointF(20D, 456D);
			this.rRos.Name = "rRos";
			this.rRos.Text = "Roscas";
			// 
			// btnManRos
			// 
			this.btnManRos.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(474D)), ((float)(66D)), ((float)(30D)));
			this.btnManRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManRos.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnManRos.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManRos.Name = "btnManRos";
			this.btnManRos.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManRos.Radius = 2D;
			this.btnManRos.Text = "Manual";
			this.btnManRos.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManRos.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManRos.Use3DEffect = false;
			this.btnManRos.Click += new System.EventHandler(this.BtnManRosClick);
			// 
			// btnAutoRos
			// 
			this.btnAutoRos.Bounds = new NxtControl.Drawing.RectF(((float)(90D)), ((float)(474D)), ((float)(76D)), ((float)(30D)));
			this.btnAutoRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutoRos.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnAutoRos.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAutoRos.Name = "btnAutoRos";
			this.btnAutoRos.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAutoRos.Radius = 2D;
			this.btnAutoRos.Text = "Automático";
			this.btnAutoRos.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutoRos.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutoRos.Use3DEffect = false;
			this.btnAutoRos.Click += new System.EventHandler(this.BtnAutoRosClick);
			// 
			// btnDesRos
			// 
			this.btnDesRos.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(474D)), ((float)(62D)), ((float)(30D)));
			this.btnDesRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesRos.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnDesRos.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesRos.Name = "btnDesRos";
			this.btnDesRos.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesRos.Radius = 2D;
			this.btnDesRos.Text = "Desliga";
			this.btnDesRos.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesRos.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesRos.Use3DEffect = false;
			this.btnDesRos.Click += new System.EventHandler(this.BtnDesRosClick);
			// 
			// btnLigRos
			// 
			this.btnLigRos.Bounds = new NxtControl.Drawing.RectF(((float)(242D)), ((float)(474D)), ((float)(58D)), ((float)(30D)));
			this.btnLigRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigRos.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnLigRos.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLigRos.Name = "btnLigRos";
			this.btnLigRos.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLigRos.Radius = 2D;
			this.btnLigRos.Text = "Liga";
			this.btnLigRos.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigRos.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigRos.Use3DEffect = false;
			this.btnLigRos.Click += new System.EventHandler(this.BtnLigRosClick);
			// 
			// rRc
			// 
			this.rRc.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rRc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rRc.Location = new NxtControl.Drawing.PointF(20D, 532D);
			this.rRc.Name = "rRc";
			this.rRc.Text = "Raspador e compressor";
			// 
			// btnManRc
			// 
			this.btnManRc.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(550D)), ((float)(66D)), ((float)(30D)));
			this.btnManRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManRc.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnManRc.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManRc.Name = "btnManRc";
			this.btnManRc.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManRc.Radius = 2D;
			this.btnManRc.Text = "Manual";
			this.btnManRc.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManRc.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnManRc.Use3DEffect = false;
			this.btnManRc.Click += new System.EventHandler(this.BtnManRcClick);
			// 
			// btnAutoRc
			// 
			this.btnAutoRc.Bounds = new NxtControl.Drawing.RectF(((float)(90D)), ((float)(550D)), ((float)(76D)), ((float)(30D)));
			this.btnAutoRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutoRc.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnAutoRc.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAutoRc.Name = "btnAutoRc";
			this.btnAutoRc.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAutoRc.Radius = 2D;
			this.btnAutoRc.Text = "Automático";
			this.btnAutoRc.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutoRc.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAutoRc.Use3DEffect = false;
			this.btnAutoRc.Click += new System.EventHandler(this.BtnAutoRcClick);
			// 
			// btnDesRc
			// 
			this.btnDesRc.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(550D)), ((float)(62D)), ((float)(30D)));
			this.btnDesRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesRc.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnDesRc.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesRc.Name = "btnDesRc";
			this.btnDesRc.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesRc.Radius = 2D;
			this.btnDesRc.Text = "Desliga";
			this.btnDesRc.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesRc.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesRc.Use3DEffect = false;
			this.btnDesRc.Click += new System.EventHandler(this.BtnDesRcClick);
			// 
			// btnLigRc
			// 
			this.btnLigRc.Bounds = new NxtControl.Drawing.RectF(((float)(242D)), ((float)(550D)), ((float)(58D)), ((float)(30D)));
			this.btnLigRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigRc.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnLigRc.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLigRc.Name = "btnLigRc";
			this.btnLigRc.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLigRc.Radius = 2D;
			this.btnLigRc.Text = "Liga";
			this.btnLigRc.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigRc.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigRc.Use3DEffect = false;
			this.btnLigRc.Click += new System.EventHandler(this.BtnLigRcClick);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(622D)), ((float)(146D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer / Reset";
			this.btnReset.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnDetalhes
			// 
			this.btnDetalhes.Bounds = new NxtControl.Drawing.RectF(((float)(164D)), ((float)(622D)), ((float)(146D)), ((float)(34D)));
			this.btnDetalhes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDetalhes.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnDetalhes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDetalhes.Name = "btnDetalhes";
			this.btnDetalhes.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnDetalhes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDetalhes.Radius = 2D;
			this.btnDetalhes.Text = "Detalhes";
			this.btnDetalhes.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDetalhes.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDetalhes.Use3DEffect = false;
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(330D, 12D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "DISPONÍVEL";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(330D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(334D, 39D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(330D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(330D, 54D),
			new NxtControl.Drawing.PointF(338D, 38D),
			new NxtControl.Drawing.PointF(346D, 54D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(335D, 42D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(350D, 38D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// textoBloq
			// 
			this.textoBloq.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoBloq.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.textoBloq.Location = new NxtControl.Drawing.PointF(560D, 16D);
			this.textoBloq.Name = "textoBloq";
			this.textoBloq.Text = "EEE Bruto bloqueada (nenhuma UCT disponível)";
			this.textoBloq.Visible = false;
			// 
			// tbChegada
			// 
			this.tbChegada.Bounds = new NxtControl.Drawing.RectF(((float)(330D)), ((float)(76D)), ((float)(210D)), ((float)(34D)));
			this.tbChegada.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbChegada.Name = "tbChegada";
			this.tbChegada.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbChegada.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(330D, 76D),
			new NxtControl.Drawing.PointF(540D, 76D),
			new NxtControl.Drawing.PointF(540D, 110D)});
			this.tbChegada.Width = 10;
			// 
			// rChegada
			// 
			this.rChegada.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rChegada.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rChegada.Location = new NxtControl.Drawing.PointF(336D, 82D);
			this.rChegada.Name = "rChegada";
			this.rChegada.Text = "Esgoto (EEE Bruto)";
			// 
			// tbCesto
			// 
			this.tbCesto.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(58.5D)), ((float)(390D)), ((float)(51.5D)));
			this.tbCesto.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbCesto.Name = "tbCesto";
			this.tbCesto.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbCesto.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 58.5D),
			new NxtControl.Drawing.PointF(630D, 58.5D),
			new NxtControl.Drawing.PointF(630D, 110D)});
			this.tbCesto.Width = 4;
			// 
			// rCesto
			// 
			this.rCesto.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.rCesto.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rCesto.Location = new NxtControl.Drawing.PointF(560D, 40D);
			this.rCesto.Name = "rCesto";
			this.rCesto.Text = "lavagem do cesto";
			// 
			// tbRoscaPen
			// 
			this.tbRoscaPen.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(152D)), ((float)(250D)), ((float)(36.5D)));
			this.tbRoscaPen.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbRoscaPen.Name = "tbRoscaPen";
			this.tbRoscaPen.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbRoscaPen.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 188.5D),
			new NxtControl.Drawing.PointF(470D, 188.5D),
			new NxtControl.Drawing.PointF(470D, 152D),
			new NxtControl.Drawing.PointF(490D, 152D)});
			this.tbRoscaPen.Width = 4;
			// 
			// rRoscaPen
			// 
			this.rRoscaPen.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.rRoscaPen.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rRoscaPen.Location = new NxtControl.Drawing.PointF(330D, 194D);
			this.rRoscaPen.Name = "rRoscaPen";
			this.rRoscaPen.Text = "lavagem da rosca da peneira";
			// 
			// tbQueda
			// 
			this.tbQueda.Bounds = new NxtControl.Drawing.RectF(((float)(650D)), ((float)(158D)), ((float)(0D)), ((float)(104D)));
			this.tbQueda.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbQueda.Name = "tbQueda";
			this.tbQueda.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbQueda.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(650D, 158D),
			new NxtControl.Drawing.PointF(650D, 262D)});
			this.tbQueda.Width = 10;
			// 
			// tanque
			// 
			this.tanque.Bounds = new NxtControl.Drawing.RectF(((float)(400D)), ((float)(230D)), ((float)(600D)), ((float)(240D)));
			this.tanque.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.tanque.Closed = true;
			this.tanque.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tanque.Name = "tanque";
			this.tanque.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.tanque.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(400D, 230D),
			new NxtControl.Drawing.PointF(520D, 230D),
			new NxtControl.Drawing.PointF(520D, 262D),
			new NxtControl.Drawing.PointF(1000D, 262D),
			new NxtControl.Drawing.PointF(1000D, 470D),
			new NxtControl.Drawing.PointF(460D, 470D),
			new NxtControl.Drawing.PointF(460D, 350D),
			new NxtControl.Drawing.PointF(400D, 350D)});
			// 
			// pe0
			// 
			this.pe0.Bounds = new NxtControl.Drawing.RectF(((float)(462D)), ((float)(470D)), ((float)(10D)), ((float)(64D)));
			this.pe0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.pe0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pe0.Name = "pe0";
			this.pe0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pe1
			// 
			this.pe1.Bounds = new NxtControl.Drawing.RectF(((float)(725D)), ((float)(470D)), ((float)(10D)), ((float)(64D)));
			this.pe1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.pe1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pe1.Name = "pe1";
			this.pe1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pe2
			// 
			this.pe2.Bounds = new NxtControl.Drawing.RectF(((float)(986D)), ((float)(470D)), ((float)(10D)), ((float)(64D)));
			this.pe2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.pe2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pe2.Name = "pe2";
			this.pe2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tbSaidaEsgoto
			// 
			this.tbSaidaEsgoto.Bounds = new NxtControl.Drawing.RectF(((float)(330D)), ((float)(440D)), ((float)(130D)), ((float)(200D)));
			this.tbSaidaEsgoto.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSaidaEsgoto.Name = "tbSaidaEsgoto";
			this.tbSaidaEsgoto.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSaidaEsgoto.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(460D, 440D),
			new NxtControl.Drawing.PointF(420D, 440D),
			new NxtControl.Drawing.PointF(420D, 640D),
			new NxtControl.Drawing.PointF(330D, 640D)});
			this.tbSaidaEsgoto.Width = 10;
			// 
			// rSaidaEsgoto
			// 
			this.rSaidaEsgoto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rSaidaEsgoto.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rSaidaEsgoto.Location = new NxtControl.Drawing.PointF(330D, 648D);
			this.rSaidaEsgoto.Name = "rSaidaEsgoto";
			this.rSaidaEsgoto.Text = "Esgoto peneirado";
			// 
			// tbAr
			// 
			this.tbAr.Bounds = new NxtControl.Drawing.RectF(((float)(658D)), ((float)(470D)), ((float)(0D)), ((float)(74D)));
			this.tbAr.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbAr.Name = "tbAr";
			this.tbAr.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbAr.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(658D, 544D),
			new NxtControl.Drawing.PointF(658D, 470D)});
			this.tbAr.Width = 4;
			// 
			// tbGordura
			// 
			this.tbGordura.Bounds = new NxtControl.Drawing.RectF(((float)(1000D)), ((float)(455D)), ((float)(50D)), ((float)(65D)));
			this.tbGordura.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbGordura.Name = "tbGordura";
			this.tbGordura.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbGordura.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1000D, 455D),
			new NxtControl.Drawing.PointF(1022D, 455D),
			new NxtControl.Drawing.PointF(1022D, 520D),
			new NxtControl.Drawing.PointF(1050D, 520D)});
			this.tbGordura.Width = 6;
			// 
			// tbLavagem
			// 
			this.tbLavagem.Bounds = new NxtControl.Drawing.RectF(((float)(1100D)), ((float)(440D)), ((float)(256D)), ((float)(30D)));
			this.tbLavagem.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbLavagem.Name = "tbLavagem";
			this.tbLavagem.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbLavagem.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1356D, 440D),
			new NxtControl.Drawing.PointF(1100D, 440D),
			new NxtControl.Drawing.PointF(1100D, 470D)});
			this.tbLavagem.Width = 4;
			// 
			// tbSucG
			// 
			this.tbSucG.Bounds = new NxtControl.Drawing.RectF(((float)(1160D)), ((float)(564D)), ((float)(37D)), ((float)(0D)));
			this.tbSucG.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbSucG.Name = "tbSucG";
			this.tbSucG.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbSucG.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1160D, 564D),
			new NxtControl.Drawing.PointF(1197D, 564D)});
			this.tbSucG.Width = 6;
			// 
			// tbRecG
			// 
			this.tbRecG.Bounds = new NxtControl.Drawing.RectF(((float)(1272D)), ((float)(538D)), ((float)(68D)), ((float)(102D)));
			this.tbRecG.InnerColor = new NxtControl.Drawing.Color(((byte)(176)), ((byte)(184)), ((byte)(192)));
			this.tbRecG.Name = "tbRecG";
			this.tbRecG.OuterColor = new NxtControl.Drawing.Color(((byte)(84)), ((byte)(88)), ((byte)(92)));
			this.tbRecG.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1272D, 538D),
			new NxtControl.Drawing.PointF(1340D, 538D),
			new NxtControl.Drawing.PointF(1340D, 640D)});
			this.tbRecG.Width = 6;
			// 
			// cacamba
			// 
			this.cacamba.Bounds = new NxtControl.Drawing.RectF(((float)(1104D)), ((float)(314D)), ((float)(70D)), ((float)(40D)));
			this.cacamba.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.cacamba.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cacamba.Name = "cacamba";
			this.cacamba.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rCacamba
			// 
			this.rCacamba.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rCacamba.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rCacamba.Location = new NxtControl.Drawing.PointF(1114D, 326D);
			this.rCacamba.Name = "rCacamba";
			this.rCacamba.Text = "Caçamba";
			// 
			// Peneira
			// 
			this.Peneira.BeginInit();
			this.Peneira.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 450D, 90D);
			this.Peneira.Name = "Peneira";
			this.Peneira.SecurityToken = ((uint)(4294967295u));
			this.Peneira.TagName = "Peneira";
			this.Peneira.EndInit();
			// 
			// rNivel
			// 
			this.rNivel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rNivel.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rNivel.Location = new NxtControl.Drawing.PointF(760D, 92D);
			this.rNivel.Name = "rNivel";
			this.rNivel.Text = "Nível da peneira";
			// 
			// vNivel
			// 
			this.vNivel.BeginInit();
			this.vNivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vNivel.DecimalPlacesCount = ((uint)(1u));
			this.vNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 760D, 108D);
			this.vNivel.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.vNivel.FontScale = false;
			this.vNivel.IsOnlyInput = true;
			this.vNivel.IsPrefixSuffixOutside = false;
			this.vNivel.LeadingZeros = ((uint)(0u));
			this.vNivel.Name = "vNivel";
			this.vNivel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vNivel.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vNivel.Suffix = " %";
			this.vNivel.TagName = "STS_NIVEL_PENEIRA";
			this.vNivel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vNivel.EndInit();
			// 
			// Raspador
			// 
			this.Raspador.BeginInit();
			this.Raspador.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 560D, 262D);
			this.Raspador.Name = "Raspador";
			this.Raspador.SecurityToken = ((uint)(4294967295u));
			this.Raspador.TagName = "Raspador";
			this.Raspador.EndInit();
			// 
			// Rosca1
			// 
			this.Rosca1.BeginInit();
			this.Rosca1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 480D, 410D);
			this.Rosca1.Name = "Rosca1";
			this.Rosca1.SecurityToken = ((uint)(4294967295u));
			this.Rosca1.TagName = "Rosca1";
			this.Rosca1.EndInit();
			// 
			// Rosca2
			// 
			this.Rosca2.BeginInit();
			this.Rosca2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 870D, 230D);
			this.Rosca2.Name = "Rosca2";
			this.Rosca2.SecurityToken = ((uint)(4294967295u));
			this.Rosca2.TagName = "Rosca2";
			this.Rosca2.EndInit();
			// 
			// Compressor
			// 
			this.Compressor.BeginInit();
			this.Compressor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 640D, 540D);
			this.Compressor.Name = "Compressor";
			this.Compressor.SecurityToken = ((uint)(4294967295u));
			this.Compressor.TagName = "Compressor";
			this.Compressor.EndInit();
			// 
			// tqGordura
			// 
			this.tqGordura.Bounds = new NxtControl.Drawing.RectF(((float)(1050D)), ((float)(470D)), ((float)(110D)), ((float)(110D)));
			this.tqGordura.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.tqGordura.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tqGordura.Name = "tqGordura";
			this.tqGordura.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rTqGordura
			// 
			this.rTqGordura.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rTqGordura.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rTqGordura.Location = new NxtControl.Drawing.PointF(1056D, 476D);
			this.rTqGordura.Name = "rTqGordura";
			this.rTqGordura.Text = "Tanque de";
			// 
			// rTqGordura2
			// 
			this.rTqGordura2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rTqGordura2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rTqGordura2.Location = new NxtControl.Drawing.PointF(1056D, 490D);
			this.rTqGordura2.Name = "rTqGordura2";
			this.rTqGordura2.Text = "gordura";
			// 
			// vNivelG
			// 
			this.vNivelG.BeginInit();
			this.vNivelG.DecimalPlacesCount = ((uint)(2u));
			this.vNivelG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1056D, 550D);
			this.vNivelG.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.vNivelG.IsOnlyInput = true;
			this.vNivelG.Name = "vNivelG";
			propertyDictionary3.Add("Text", "");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary4.Add("Text", "NÍVEL ALTO");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vNivelG.Ranges.Clear();
			this.vNivelG.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary3));
			this.vNivelG.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary4));
			propertyDictionary2.Add("Text", "-");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vNivelG.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.vNivelG.TagName = "STS_NIVEL_ALTO_TANQUE_GORDURA";
			this.vNivelG.TextAngle = 0F;
			this.vNivelG.EndInit();
			// 
			// rLavagem
			// 
			this.rLavagem.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rLavagem.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rLavagem.Location = new NxtControl.Drawing.PointF(1240D, 420D);
			this.rLavagem.Name = "rLavagem";
			this.rLavagem.Text = "Água de lavagem";
			// 
			// vl1
			// 
			this.vl1.Bounds = new NxtControl.Drawing.RectF(((float)(1180D)), ((float)(430D)), ((float)(20D)), ((float)(20D)));
			this.vl1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.vl1.Closed = true;
			this.vl1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vl1.Name = "vl1";
			this.vl1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vl1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1180D, 430D),
			new NxtControl.Drawing.PointF(1180D, 450D),
			new NxtControl.Drawing.PointF(1200D, 440D)});
			// 
			// vl2
			// 
			this.vl2.Bounds = new NxtControl.Drawing.RectF(((float)(1200D)), ((float)(430D)), ((float)(20D)), ((float)(20D)));
			this.vl2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.vl2.Closed = true;
			this.vl2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vl2.Name = "vl2";
			this.vl2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vl2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1220D, 430D),
			new NxtControl.Drawing.PointF(1220D, 450D),
			new NxtControl.Drawing.PointF(1200D, 440D)});
			// 
			// vlHaste
			// 
			this.vlHaste.EndPoint = new NxtControl.Drawing.PointF(1200D, 424D);
			this.vlHaste.Name = "vlHaste";
			this.vlHaste.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.vlHaste.StartPoint = new NxtControl.Drawing.PointF(1200D, 440D);
			// 
			// vlAtuador
			// 
			this.vlAtuador.Bounds = new NxtControl.Drawing.RectF(((float)(1191D)), ((float)(416D)), ((float)(18D)), ((float)(8D)));
			this.vlAtuador.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.vlAtuador.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vlAtuador.Name = "vlAtuador";
			this.vlAtuador.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoValv
			// 
			this.textoValv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoValv.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.textoValv.Location = new NxtControl.Drawing.PointF(1180D, 454D);
			this.textoValv.Name = "textoValv";
			this.textoValv.Text = "fechada";
			// 
			// abrirValv
			// 
			this.abrirValv.Bounds = new NxtControl.Drawing.RectF(((float)(1176D)), ((float)(412D)), ((float)(50D)), ((float)(56D)));
			this.abrirValv.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrirValv.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrirValv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrirValv.Name = "abrirValv";
			this.abrirValv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrirValv.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrirValv.Radius = 2D;
			this.abrirValv.Text = "";
			this.abrirValv.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrirValv.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrirValv.Use3DEffect = false;
			// 
			// BombaGordura
			// 
			this.BombaGordura.BeginInit();
			this.BombaGordura.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1190D, 500D);
			this.BombaGordura.Name = "BombaGordura";
			this.BombaGordura.SecurityToken = ((uint)(4294967295u));
			this.BombaGordura.TagName = "BombaGordura";
			this.BombaGordura.EndInit();
			// 
			// rSaidaG
			// 
			this.rSaidaG.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rSaidaG.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rSaidaG.Location = new NxtControl.Drawing.PointF(1262D, 648D);
			this.rSaidaG.Name = "rSaidaG";
			this.rSaidaG.Text = "Saída de gordura";
			// 
			// textoEtapa
			// 
			this.textoEtapa.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEtapa.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.textoEtapa.Location = new NxtControl.Drawing.PointF(1050D, 600D);
			this.textoEtapa.Name = "textoEtapa";
			this.textoEtapa.Text = "Bomba de gordura: parada";
			// 
			// vRest
			// 
			this.vRest.BeginInit();
			this.vRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vRest.DecimalPlacesCount = ((uint)(0u));
			this.vRest.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4D, 0D, 0D, 1D, 1050D, 616D);
			this.vRest.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vRest.FontScale = false;
			this.vRest.IsOnlyInput = true;
			this.vRest.IsPrefixSuffixOutside = false;
			this.vRest.LeadingZeros = ((uint)(0u));
			this.vRest.Name = "vRest";
			this.vRest.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vRest.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.vRest.Suffix = " s";
			this.vRest.TagName = "STS_TEMPO_RESTANTE";
			this.vRest.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vRest.EndInit();
			// 
			// pnlNiv
			// 
			this.pnlNiv.Bounds = new NxtControl.Drawing.RectF(((float)(1130D)), ((float)(60D)), ((float)(226D)), ((float)(110D)));
			this.pnlNiv.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.pnlNiv.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.pnlNiv.Name = "pnlNiv";
			this.pnlNiv.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tNiv
			// 
			this.tNiv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tNiv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tNiv.Location = new NxtControl.Drawing.PointF(1140D, 66D);
			this.tNiv.Name = "tNiv";
			this.tNiv.Text = "Níveis";
			// 
			// rn0
			// 
			this.rn0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rn0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rn0.Location = new NxtControl.Drawing.PointF(1140D, 90D);
			this.rn0.Name = "rn0";
			this.rn0.Text = "Nível baixo da peneira";
			// 
			// vn0
			// 
			this.vn0.BeginInit();
			this.vn0.DecimalPlacesCount = ((uint)(2u));
			this.vn0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1316D, 90D);
			this.vn0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.vn0.IsOnlyInput = true;
			this.vn0.Name = "vn0";
			propertyDictionary7.Add("Text", "não");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary8.Add("Text", "SIM");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vn0.Ranges.Clear();
			this.vn0.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary7));
			this.vn0.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary8));
			propertyDictionary6.Add("Text", "-");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vn0.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.vn0.TagName = "STS_NIVEL_BAIXO_PENEIRA";
			this.vn0.TextAngle = 0F;
			this.vn0.EndInit();
			// 
			// rn1
			// 
			this.rn1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rn1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rn1.Location = new NxtControl.Drawing.PointF(1140D, 114D);
			this.rn1.Name = "rn1";
			this.rn1.Text = "Nível alto da peneira";
			// 
			// vn1
			// 
			this.vn1.BeginInit();
			this.vn1.DecimalPlacesCount = ((uint)(2u));
			this.vn1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1316D, 114D);
			this.vn1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.vn1.IsOnlyInput = true;
			this.vn1.Name = "vn1";
			propertyDictionary10.Add("Text", "não");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary11.Add("Text", "SIM");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vn1.Ranges.Clear();
			this.vn1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary10));
			this.vn1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary11));
			propertyDictionary9.Add("Text", "-");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vn1.Ranges.DefaultPropertyValues = propertyDictionary9;
			this.vn1.TagName = "STS_NIVEL_ALTO_PENEIRA";
			this.vn1.TextAngle = 0F;
			this.vn1.EndInit();
			// 
			// rn2
			// 
			this.rn2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rn2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rn2.Location = new NxtControl.Drawing.PointF(1140D, 138D);
			this.rn2.Name = "rn2";
			this.rn2.Text = "Nível baixo do tanque de água";
			// 
			// vn2
			// 
			this.vn2.BeginInit();
			this.vn2.DecimalPlacesCount = ((uint)(2u));
			this.vn2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1316D, 138D);
			this.vn2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.vn2.IsOnlyInput = true;
			this.vn2.Name = "vn2";
			propertyDictionary13.Add("Text", "não");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary14.Add("Text", "SIM");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vn2.Ranges.Clear();
			this.vn2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary13));
			this.vn2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary14));
			propertyDictionary12.Add("Text", "-");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vn2.Ranges.DefaultPropertyValues = propertyDictionary12;
			this.vn2.TagName = "STS_NIVEL_BAIXO_TANQUE_AGUA";
			this.vn2.TextAngle = 0F;
			this.vn2.EndInit();
			// 
			// x_aCOM
			// 
			this.x_aCOM.BeginInit();
			this.x_aCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aCOM.IsOnlyInput = true;
			this.x_aCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aCOM.Name = "x_aCOM";
			this.x_aCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aCOM.TagName = "STS_ALARME_COM";
			this.x_aCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aCOMChanged);
			this.x_aCOM.EndInit();
			// 
			// x_aEMERGENCIA
			// 
			this.x_aEMERGENCIA.BeginInit();
			this.x_aEMERGENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aEMERGENCIA.IsOnlyInput = true;
			this.x_aEMERGENCIA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aEMERGENCIA.Name = "x_aEMERGENCIA";
			this.x_aEMERGENCIA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aEMERGENCIA.TagName = "STS_ALARME_EMERGENCIA";
			this.x_aEMERGENCIA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aEMERGENCIAChanged);
			this.x_aEMERGENCIA.EndInit();
			// 
			// x_aDEFPEN
			// 
			this.x_aDEFPEN.BeginInit();
			this.x_aDEFPEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFPEN.IsOnlyInput = true;
			this.x_aDEFPEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFPEN.Name = "x_aDEFPEN";
			this.x_aDEFPEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFPEN.TagName = "STS_ALARME_DEFPEN";
			this.x_aDEFPEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFPENChanged);
			this.x_aDEFPEN.EndInit();
			// 
			// x_aDEFB1
			// 
			this.x_aDEFB1.BeginInit();
			this.x_aDEFB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFB1.IsOnlyInput = true;
			this.x_aDEFB1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFB1.Name = "x_aDEFB1";
			this.x_aDEFB1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFB1.TagName = "STS_ALARME_DEFB1";
			this.x_aDEFB1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFB1Changed);
			this.x_aDEFB1.EndInit();
			// 
			// x_aDEFB2
			// 
			this.x_aDEFB2.BeginInit();
			this.x_aDEFB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFB2.IsOnlyInput = true;
			this.x_aDEFB2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFB2.Name = "x_aDEFB2";
			this.x_aDEFB2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFB2.TagName = "STS_ALARME_DEFB2";
			this.x_aDEFB2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFB2Changed);
			this.x_aDEFB2.EndInit();
			// 
			// x_aDEFCMP
			// 
			this.x_aDEFCMP.BeginInit();
			this.x_aDEFCMP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFCMP.IsOnlyInput = true;
			this.x_aDEFCMP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFCMP.Name = "x_aDEFCMP";
			this.x_aDEFCMP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFCMP.TagName = "STS_ALARME_DEFCMP";
			this.x_aDEFCMP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFCMPChanged);
			this.x_aDEFCMP.EndInit();
			// 
			// x_aDEFRSP
			// 
			this.x_aDEFRSP.BeginInit();
			this.x_aDEFRSP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFRSP.IsOnlyInput = true;
			this.x_aDEFRSP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFRSP.Name = "x_aDEFRSP";
			this.x_aDEFRSP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFRSP.TagName = "STS_ALARME_DEFRSP";
			this.x_aDEFRSP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFRSPChanged);
			this.x_aDEFRSP.EndInit();
			// 
			// x_aDEFR1
			// 
			this.x_aDEFR1.BeginInit();
			this.x_aDEFR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFR1.IsOnlyInput = true;
			this.x_aDEFR1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFR1.Name = "x_aDEFR1";
			this.x_aDEFR1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFR1.TagName = "STS_ALARME_DEFR1";
			this.x_aDEFR1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFR1Changed);
			this.x_aDEFR1.EndInit();
			// 
			// x_aDEFR2
			// 
			this.x_aDEFR2.BeginInit();
			this.x_aDEFR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aDEFR2.IsOnlyInput = true;
			this.x_aDEFR2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aDEFR2.Name = "x_aDEFR2";
			this.x_aDEFR2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aDEFR2.TagName = "STS_ALARME_DEFR2";
			this.x_aDEFR2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aDEFR2Changed);
			this.x_aDEFR2.EndInit();
			// 
			// x_aNIVELAGUA
			// 
			this.x_aNIVELAGUA.BeginInit();
			this.x_aNIVELAGUA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aNIVELAGUA.IsOnlyInput = true;
			this.x_aNIVELAGUA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aNIVELAGUA.Name = "x_aNIVELAGUA";
			this.x_aNIVELAGUA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aNIVELAGUA.TagName = "STS_ALARME_NIVELAGUA";
			this.x_aNIVELAGUA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aNIVELAGUAChanged);
			this.x_aNIVELAGUA.EndInit();
			// 
			// x_aNIVELPENEIRA
			// 
			this.x_aNIVELPENEIRA.BeginInit();
			this.x_aNIVELPENEIRA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_aNIVELPENEIRA.IsOnlyInput = true;
			this.x_aNIVELPENEIRA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_aNIVELPENEIRA.Name = "x_aNIVELPENEIRA";
			this.x_aNIVELPENEIRA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_aNIVELPENEIRA.TagName = "STS_ALARME_NIVELPENEIRA";
			this.x_aNIVELPENEIRA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_aNIVELPENEIRAChanged);
			this.x_aNIVELPENEIRA.EndInit();
			// 
			// x_eCOM
			// 
			this.x_eCOM.BeginInit();
			this.x_eCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eCOM.IsOnlyInput = true;
			this.x_eCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eCOM.Name = "x_eCOM";
			this.x_eCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eCOM.TagName = "STS_ALM_COM_EST";
			this.x_eCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eCOMChanged);
			this.x_eCOM.EndInit();
			// 
			// x_eEMERGENCIA
			// 
			this.x_eEMERGENCIA.BeginInit();
			this.x_eEMERGENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eEMERGENCIA.IsOnlyInput = true;
			this.x_eEMERGENCIA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eEMERGENCIA.Name = "x_eEMERGENCIA";
			this.x_eEMERGENCIA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eEMERGENCIA.TagName = "STS_ALM_EMERGENCIA_EST";
			this.x_eEMERGENCIA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eEMERGENCIAChanged);
			this.x_eEMERGENCIA.EndInit();
			// 
			// x_eDEFPEN
			// 
			this.x_eDEFPEN.BeginInit();
			this.x_eDEFPEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFPEN.IsOnlyInput = true;
			this.x_eDEFPEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFPEN.Name = "x_eDEFPEN";
			this.x_eDEFPEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFPEN.TagName = "STS_ALM_DEFPEN_EST";
			this.x_eDEFPEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFPENChanged);
			this.x_eDEFPEN.EndInit();
			// 
			// x_eDEFB1
			// 
			this.x_eDEFB1.BeginInit();
			this.x_eDEFB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFB1.IsOnlyInput = true;
			this.x_eDEFB1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFB1.Name = "x_eDEFB1";
			this.x_eDEFB1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFB1.TagName = "STS_ALM_DEFB1_EST";
			this.x_eDEFB1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFB1Changed);
			this.x_eDEFB1.EndInit();
			// 
			// x_eDEFB2
			// 
			this.x_eDEFB2.BeginInit();
			this.x_eDEFB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFB2.IsOnlyInput = true;
			this.x_eDEFB2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFB2.Name = "x_eDEFB2";
			this.x_eDEFB2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFB2.TagName = "STS_ALM_DEFB2_EST";
			this.x_eDEFB2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFB2Changed);
			this.x_eDEFB2.EndInit();
			// 
			// x_eDEFCMP
			// 
			this.x_eDEFCMP.BeginInit();
			this.x_eDEFCMP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFCMP.IsOnlyInput = true;
			this.x_eDEFCMP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFCMP.Name = "x_eDEFCMP";
			this.x_eDEFCMP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFCMP.TagName = "STS_ALM_DEFCMP_EST";
			this.x_eDEFCMP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFCMPChanged);
			this.x_eDEFCMP.EndInit();
			// 
			// x_eDEFRSP
			// 
			this.x_eDEFRSP.BeginInit();
			this.x_eDEFRSP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFRSP.IsOnlyInput = true;
			this.x_eDEFRSP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFRSP.Name = "x_eDEFRSP";
			this.x_eDEFRSP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFRSP.TagName = "STS_ALM_DEFRSP_EST";
			this.x_eDEFRSP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFRSPChanged);
			this.x_eDEFRSP.EndInit();
			// 
			// x_eDEFR1
			// 
			this.x_eDEFR1.BeginInit();
			this.x_eDEFR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFR1.IsOnlyInput = true;
			this.x_eDEFR1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFR1.Name = "x_eDEFR1";
			this.x_eDEFR1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFR1.TagName = "STS_ALM_DEFR1_EST";
			this.x_eDEFR1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFR1Changed);
			this.x_eDEFR1.EndInit();
			// 
			// x_eDEFR2
			// 
			this.x_eDEFR2.BeginInit();
			this.x_eDEFR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eDEFR2.IsOnlyInput = true;
			this.x_eDEFR2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eDEFR2.Name = "x_eDEFR2";
			this.x_eDEFR2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eDEFR2.TagName = "STS_ALM_DEFR2_EST";
			this.x_eDEFR2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eDEFR2Changed);
			this.x_eDEFR2.EndInit();
			// 
			// x_eNIVELAGUA
			// 
			this.x_eNIVELAGUA.BeginInit();
			this.x_eNIVELAGUA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eNIVELAGUA.IsOnlyInput = true;
			this.x_eNIVELAGUA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eNIVELAGUA.Name = "x_eNIVELAGUA";
			this.x_eNIVELAGUA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eNIVELAGUA.TagName = "STS_ALM_NIVELAGUA_EST";
			this.x_eNIVELAGUA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eNIVELAGUAChanged);
			this.x_eNIVELAGUA.EndInit();
			// 
			// x_eNIVELPENEIRA
			// 
			this.x_eNIVELPENEIRA.BeginInit();
			this.x_eNIVELPENEIRA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_eNIVELPENEIRA.IsOnlyInput = true;
			this.x_eNIVELPENEIRA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_eNIVELPENEIRA.Name = "x_eNIVELPENEIRA";
			this.x_eNIVELPENEIRA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_eNIVELPENEIRA.TagName = "STS_ALM_NIVELPENEIRA_EST";
			this.x_eNIVELPENEIRA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_eNIVELPENEIRAChanged);
			this.x_eNIVELPENEIRA.EndInit();
			// 
			// x_disp
			// 
			this.x_disp.BeginInit();
			this.x_disp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_disp.IsOnlyInput = true;
			this.x_disp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_disp.Name = "x_disp";
			this.x_disp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_disp.TagName = "STS_DISPONIVEL";
			this.x_disp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_dispChanged);
			this.x_disp.EndInit();
			// 
			// x_hab
			// 
			this.x_hab.BeginInit();
			this.x_hab.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_hab.IsOnlyInput = true;
			this.x_hab.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_hab.Name = "x_hab";
			this.x_hab.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_hab.TagName = "STS_HABILITADA";
			this.x_hab.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_habChanged);
			this.x_hab.EndInit();
			// 
			// x_bloq
			// 
			this.x_bloq.BeginInit();
			this.x_bloq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_bloq.IsOnlyInput = true;
			this.x_bloq.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_bloq.Name = "x_bloq";
			this.x_bloq.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_bloq.TagName = "STS_BLOQUEIO_EEE";
			this.x_bloq.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_bloqChanged);
			this.x_bloq.EndInit();
			// 
			// x_autoPen
			// 
			this.x_autoPen.BeginInit();
			this.x_autoPen.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_autoPen.IsOnlyInput = true;
			this.x_autoPen.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_autoPen.Name = "x_autoPen";
			this.x_autoPen.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_autoPen.TagName = "STS_AUTOMATICO_PENEIRA";
			this.x_autoPen.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoPenChanged);
			this.x_autoPen.EndInit();
			// 
			// x_autoRos
			// 
			this.x_autoRos.BeginInit();
			this.x_autoRos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_autoRos.IsOnlyInput = true;
			this.x_autoRos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_autoRos.Name = "x_autoRos";
			this.x_autoRos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_autoRos.TagName = "STS_AUTOMATICO_ROSCAS";
			this.x_autoRos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoRosChanged);
			this.x_autoRos.EndInit();
			// 
			// x_autoRc
			// 
			this.x_autoRc.BeginInit();
			this.x_autoRc.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_autoRc.IsOnlyInput = true;
			this.x_autoRc.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_autoRc.Name = "x_autoRc";
			this.x_autoRc.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_autoRc.TagName = "STS_AUTOMATICO_RASPCOMP";
			this.x_autoRc.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoRcChanged);
			this.x_autoRc.EndInit();
			// 
			// x_ligPen
			// 
			this.x_ligPen.BeginInit();
			this.x_ligPen.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_ligPen.IsOnlyInput = true;
			this.x_ligPen.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_ligPen.Name = "x_ligPen";
			this.x_ligPen.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_ligPen.TagName = "STS_LIGA_AUTOMATICO_PENEIRA";
			this.x_ligPen.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_ligPenChanged);
			this.x_ligPen.EndInit();
			// 
			// x_ligRos
			// 
			this.x_ligRos.BeginInit();
			this.x_ligRos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_ligRos.IsOnlyInput = true;
			this.x_ligRos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_ligRos.Name = "x_ligRos";
			this.x_ligRos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_ligRos.TagName = "STS_LIGA_AUTOMATICO_ROSCAS";
			this.x_ligRos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_ligRosChanged);
			this.x_ligRos.EndInit();
			// 
			// x_ligRc
			// 
			this.x_ligRc.BeginInit();
			this.x_ligRc.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_ligRc.IsOnlyInput = true;
			this.x_ligRc.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_ligRc.Name = "x_ligRc";
			this.x_ligRc.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_ligRc.TagName = "STS_LIGA_AUTOMATICO_RASPCOMP";
			this.x_ligRc.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_ligRcChanged);
			this.x_ligRc.EndInit();
			// 
			// x_selB2
			// 
			this.x_selB2.BeginInit();
			this.x_selB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_selB2.IsOnlyInput = true;
			this.x_selB2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_selB2.Name = "x_selB2";
			this.x_selB2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_selB2.TagName = "STS_SELECAO_BOMBA";
			this.x_selB2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_selB2Changed);
			this.x_selB2.EndInit();
			// 
			// x_valv
			// 
			this.x_valv.BeginInit();
			this.x_valv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_valv.IsOnlyInput = true;
			this.x_valv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_valv.Name = "x_valv";
			this.x_valv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_valv.TagName = "STS_VALVULA_LAVAGEM";
			this.x_valv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_valvChanged);
			this.x_valv.EndInit();
			// 
			// x_etapa
			// 
			this.x_etapa.BeginInit();
			this.x_etapa.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_etapa.IsOnlyInput = true;
			this.x_etapa.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_etapa.Name = "x_etapa";
			this.x_etapa.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_etapa.TagName = "STS_ETAPA_GORDURA";
			this.x_etapa.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_etapaChanged);
			this.x_etapa.EndInit();
			// 
			// x_nAltoG
			// 
			this.x_nAltoG.BeginInit();
			this.x_nAltoG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_nAltoG.IsOnlyInput = true;
			this.x_nAltoG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_nAltoG.Name = "x_nAltoG";
			this.x_nAltoG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_nAltoG.TagName = "STS_NIVEL_ALTO_TANQUE_GORDURA";
			this.x_nAltoG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_nAltoGChanged);
			this.x_nAltoG.EndInit();
			// 
			// sSkid
			// 
			this.Name = "sSkid";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.pnlHig,
			this.tHig,
			this.tbSuc,
			this.tbSuc2,
			this.tbRec1,
			this.tbRec2,
			this.tbRecTie,
			this.tqAgua,
			this.rTqAgua,
			this.Bomba1,
			this.Bomba2,
			this.Valvula1,
			this.Valvula2,
			this.rSel,
			this.btnB1,
			this.btnB2,
			this.pnlSub,
			this.tSub,
			this.rPen,
			this.btnManPen,
			this.btnAutoPen,
			this.btnDesPen,
			this.btnLigPen,
			this.rRos,
			this.btnManRos,
			this.btnAutoRos,
			this.btnDesRos,
			this.btnLigRos,
			this.rRc,
			this.btnManRc,
			this.btnAutoRc,
			this.btnDesRc,
			this.btnLigRc,
			this.btnReset,
			this.btnDetalhes,
			this.textoEstado,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.textoBloq,
			this.tbChegada,
			this.rChegada,
			this.tbCesto,
			this.rCesto,
			this.tbRoscaPen,
			this.rRoscaPen,
			this.tbQueda,
			this.tanque,
			this.pe0,
			this.pe1,
			this.pe2,
			this.tbSaidaEsgoto,
			this.rSaidaEsgoto,
			this.tbAr,
			this.tbGordura,
			this.tbLavagem,
			this.tbSucG,
			this.tbRecG,
			this.cacamba,
			this.rCacamba,
			this.Peneira,
			this.rNivel,
			this.vNivel,
			this.Raspador,
			this.Rosca1,
			this.Rosca2,
			this.Compressor,
			this.tqGordura,
			this.rTqGordura,
			this.rTqGordura2,
			this.vNivelG,
			this.rLavagem,
			this.vl1,
			this.vl2,
			this.vlHaste,
			this.vlAtuador,
			this.textoValv,
			this.abrirValv,
			this.BombaGordura,
			this.rSaidaG,
			this.textoEtapa,
			this.vRest,
			this.pnlNiv,
			this.tNiv,
			this.rn0,
			this.vn0,
			this.rn1,
			this.vn1,
			this.rn2,
			this.vn2,
			this.x_aCOM,
			this.x_aEMERGENCIA,
			this.x_aDEFPEN,
			this.x_aDEFB1,
			this.x_aDEFB2,
			this.x_aDEFCMP,
			this.x_aDEFRSP,
			this.x_aDEFR1,
			this.x_aDEFR2,
			this.x_aNIVELAGUA,
			this.x_aNIVELPENEIRA,
			this.x_eCOM,
			this.x_eEMERGENCIA,
			this.x_eDEFPEN,
			this.x_eDEFB1,
			this.x_eDEFB2,
			this.x_eDEFCMP,
			this.x_eDEFRSP,
			this.x_eDEFR1,
			this.x_eDEFR2,
			this.x_eNIVELAGUA,
			this.x_eNIVELPENEIRA,
			this.x_disp,
			this.x_hab,
			this.x_bloq,
			this.x_autoPen,
			this.x_autoRos,
			this.x_autoRc,
			this.x_ligPen,
			this.x_ligRos,
			this.x_ligRc,
			this.x_selB2,
			this.x_valv,
			this.x_etapa,
			this.x_nAltoG});
			this.SymbolSize = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle pnlHig;
		private NxtControl.GuiFramework.FreeText tHig;
		private NxtControl.GuiFramework.Pipe tbSuc;
		private NxtControl.GuiFramework.Pipe tbSuc2;
		private NxtControl.GuiFramework.Pipe tbRec1;
		private NxtControl.GuiFramework.Pipe tbRec2;
		private NxtControl.GuiFramework.Pipe tbRecTie;
		private NxtControl.GuiFramework.Rectangle tqAgua;
		private NxtControl.GuiFramework.FreeText rTqAgua;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sBomba Bomba1;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sBomba Bomba2;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sValvula Valvula1;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sValvula Valvula2;
		private NxtControl.GuiFramework.FreeText rSel;
		private NxtControl.GuiFramework.DrawnButton btnB1;
		private NxtControl.GuiFramework.DrawnButton btnB2;
		private NxtControl.GuiFramework.Rectangle pnlSub;
		private NxtControl.GuiFramework.FreeText tSub;
		private NxtControl.GuiFramework.FreeText rPen;
		private NxtControl.GuiFramework.DrawnButton btnManPen;
		private NxtControl.GuiFramework.DrawnButton btnAutoPen;
		private NxtControl.GuiFramework.DrawnButton btnDesPen;
		private NxtControl.GuiFramework.DrawnButton btnLigPen;
		private NxtControl.GuiFramework.FreeText rRos;
		private NxtControl.GuiFramework.DrawnButton btnManRos;
		private NxtControl.GuiFramework.DrawnButton btnAutoRos;
		private NxtControl.GuiFramework.DrawnButton btnDesRos;
		private NxtControl.GuiFramework.DrawnButton btnLigRos;
		private NxtControl.GuiFramework.FreeText rRc;
		private NxtControl.GuiFramework.DrawnButton btnManRc;
		private NxtControl.GuiFramework.DrawnButton btnAutoRc;
		private NxtControl.GuiFramework.DrawnButton btnDesRc;
		private NxtControl.GuiFramework.DrawnButton btnLigRc;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnDetalhes;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText textoBloq;
		private NxtControl.GuiFramework.Pipe tbChegada;
		private NxtControl.GuiFramework.FreeText rChegada;
		private NxtControl.GuiFramework.Pipe tbCesto;
		private NxtControl.GuiFramework.FreeText rCesto;
		private NxtControl.GuiFramework.Pipe tbRoscaPen;
		private NxtControl.GuiFramework.FreeText rRoscaPen;
		private NxtControl.GuiFramework.Pipe tbQueda;
		private NxtControl.GuiFramework.Polygon tanque;
		private NxtControl.GuiFramework.Rectangle pe0;
		private NxtControl.GuiFramework.Rectangle pe1;
		private NxtControl.GuiFramework.Rectangle pe2;
		private NxtControl.GuiFramework.Pipe tbSaidaEsgoto;
		private NxtControl.GuiFramework.FreeText rSaidaEsgoto;
		private NxtControl.GuiFramework.Pipe tbAr;
		private NxtControl.GuiFramework.Pipe tbGordura;
		private NxtControl.GuiFramework.Pipe tbLavagem;
		private NxtControl.GuiFramework.Pipe tbSucG;
		private NxtControl.GuiFramework.Pipe tbRecG;
		private NxtControl.GuiFramework.Rectangle cacamba;
		private NxtControl.GuiFramework.FreeText rCacamba;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sPeneira Peneira;
		private NxtControl.GuiFramework.FreeText rNivel;
		private System.HMI.Symbols.Base.Label<System.Single> vNivel;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sRaspador Raspador;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sRosca Rosca1;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sRoscaInclinada Rosca2;
		private Hidryco.HidrycoLib.Symbols.UCT_Equipamento.sCompressor Compressor;
		private NxtControl.GuiFramework.Rectangle tqGordura;
		private NxtControl.GuiFramework.FreeText rTqGordura;
		private NxtControl.GuiFramework.FreeText rTqGordura2;
		private System.HMI.Symbols.Base.FreeText<bool> vNivelG;
		private NxtControl.GuiFramework.FreeText rLavagem;
		private NxtControl.GuiFramework.Polygon vl1;
		private NxtControl.GuiFramework.Polygon vl2;
		private NxtControl.GuiFramework.Line vlHaste;
		private NxtControl.GuiFramework.Rectangle vlAtuador;
		private NxtControl.GuiFramework.FreeText textoValv;
		private NxtControl.GuiFramework.DrawnButton abrirValv;
		private Hidryco.HidrycoLib.Symbols.Motor_Generico.sBomba BombaGordura;
		private NxtControl.GuiFramework.FreeText rSaidaG;
		private NxtControl.GuiFramework.FreeText textoEtapa;
		private System.HMI.Symbols.Base.Label<System.Int16> vRest;
		private NxtControl.GuiFramework.Rectangle pnlNiv;
		private NxtControl.GuiFramework.FreeText tNiv;
		private NxtControl.GuiFramework.FreeText rn0;
		private System.HMI.Symbols.Base.FreeText<bool> vn0;
		private NxtControl.GuiFramework.FreeText rn1;
		private System.HMI.Symbols.Base.FreeText<bool> vn1;
		private NxtControl.GuiFramework.FreeText rn2;
		private System.HMI.Symbols.Base.FreeText<bool> vn2;
		private System.HMI.Symbols.Base.Execute<bool> x_aCOM;
		private System.HMI.Symbols.Base.Execute<bool> x_aEMERGENCIA;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFPEN;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFB1;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFB2;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFCMP;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFRSP;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFR1;
		private System.HMI.Symbols.Base.Execute<bool> x_aDEFR2;
		private System.HMI.Symbols.Base.Execute<bool> x_aNIVELAGUA;
		private System.HMI.Symbols.Base.Execute<bool> x_aNIVELPENEIRA;
		private System.HMI.Symbols.Base.Execute<byte> x_eCOM;
		private System.HMI.Symbols.Base.Execute<byte> x_eEMERGENCIA;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFPEN;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFB1;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFB2;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFCMP;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFRSP;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFR1;
		private System.HMI.Symbols.Base.Execute<byte> x_eDEFR2;
		private System.HMI.Symbols.Base.Execute<byte> x_eNIVELAGUA;
		private System.HMI.Symbols.Base.Execute<byte> x_eNIVELPENEIRA;
		private System.HMI.Symbols.Base.Execute<bool> x_disp;
		private System.HMI.Symbols.Base.Execute<bool> x_hab;
		private System.HMI.Symbols.Base.Execute<bool> x_bloq;
		private System.HMI.Symbols.Base.Execute<bool> x_autoPen;
		private System.HMI.Symbols.Base.Execute<bool> x_autoRos;
		private System.HMI.Symbols.Base.Execute<bool> x_autoRc;
		private System.HMI.Symbols.Base.Execute<bool> x_ligPen;
		private System.HMI.Symbols.Base.Execute<bool> x_ligRos;
		private System.HMI.Symbols.Base.Execute<bool> x_ligRc;
		private System.HMI.Symbols.Base.Execute<bool> x_selB2;
		private System.HMI.Symbols.Base.Execute<bool> x_valv;
		private System.HMI.Symbols.Base.Execute<short> x_etapa;
		private System.HMI.Symbols.Base.Execute<bool> x_nAltoG;
		#endregion
	}
}
