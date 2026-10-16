/*
 * Hidryco - UCT_PreTratamento - fpDefault
 * ISA-101: UCT - disponibilidade, subsistemas (manual/automatico, liga), selecao da bomba de higienizacao, niveis, bomba de gordura e valvula de lavagem, alarmes e reset.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UCT_PreTratamento
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
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
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.textoBloq = new NxtControl.GuiFramework.FreeText();
			this.tituloSub = new NxtControl.GuiFramework.FreeText();
			this.cabModo = new NxtControl.GuiFramework.FreeText();
			this.cabLiga = new NxtControl.GuiFramework.FreeText();
			this.linPen = new NxtControl.GuiFramework.Rectangle();
			this.rotPen = new NxtControl.GuiFramework.FreeText();
			this.btnManPen = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutoPen = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesPen = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigPen = new NxtControl.GuiFramework.DrawnButton();
			this.linRos = new NxtControl.GuiFramework.Rectangle();
			this.rotRos = new NxtControl.GuiFramework.FreeText();
			this.btnManRos = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutoRos = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesRos = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigRos = new NxtControl.GuiFramework.DrawnButton();
			this.linRc = new NxtControl.GuiFramework.Rectangle();
			this.rotRc = new NxtControl.GuiFramework.FreeText();
			this.btnManRc = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutoRc = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesRc = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigRc = new NxtControl.GuiFramework.DrawnButton();
			this.linBomba = new NxtControl.GuiFramework.Rectangle();
			this.rotBomba = new NxtControl.GuiFramework.FreeText();
			this.btnB1 = new NxtControl.GuiFramework.DrawnButton();
			this.btnB2 = new NxtControl.GuiFramework.DrawnButton();
			this.tituloNiveis = new NxtControl.GuiFramework.FreeText();
			this.rotNivel = new NxtControl.GuiFramework.FreeText();
			this.vNivel = new System.HMI.Symbols.Base.Label<System.Single>();
			this.rn0 = new NxtControl.GuiFramework.FreeText();
			this.vn0 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.rn1 = new NxtControl.GuiFramework.FreeText();
			this.vn1 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.rn2 = new NxtControl.GuiFramework.FreeText();
			this.vn2 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.rn3 = new NxtControl.GuiFramework.FreeText();
			this.vn3 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.tituloGordura = new NxtControl.GuiFramework.FreeText();
			this.textoEtapa = new NxtControl.GuiFramework.FreeText();
			this.rotRest = new NxtControl.GuiFramework.FreeText();
			this.vRest = new System.HMI.Symbols.Base.Label<System.Int16>();
			this.textoValv = new NxtControl.GuiFramework.FreeText();
			this.btnValvFecha = new NxtControl.GuiFramework.DrawnButton();
			this.btnValvAbre = new NxtControl.GuiFramework.DrawnButton();
			this.textoValvAuto = new NxtControl.GuiFramework.FreeText();
			this.tituloAlm = new NxtControl.GuiFramework.FreeText();
			this.rCOM = new NxtControl.GuiFramework.FreeText();
			this.nCOM = new NxtControl.GuiFramework.FreeText();
			this.iCOMP1 = new NxtControl.GuiFramework.Rectangle();
			this.iCOMP1n = new NxtControl.GuiFramework.FreeText();
			this.iCOMP2 = new NxtControl.GuiFramework.Polygon();
			this.iCOMP2n = new NxtControl.GuiFramework.FreeText();
			this.iCOMTxt = new NxtControl.GuiFramework.FreeText();
			this.rEMERGENCIA = new NxtControl.GuiFramework.FreeText();
			this.nEMERGENCIA = new NxtControl.GuiFramework.FreeText();
			this.iEMERGENCIAP1 = new NxtControl.GuiFramework.Rectangle();
			this.iEMERGENCIAP1n = new NxtControl.GuiFramework.FreeText();
			this.iEMERGENCIAP2 = new NxtControl.GuiFramework.Polygon();
			this.iEMERGENCIAP2n = new NxtControl.GuiFramework.FreeText();
			this.iEMERGENCIATxt = new NxtControl.GuiFramework.FreeText();
			this.rDEFPEN = new NxtControl.GuiFramework.FreeText();
			this.nDEFPEN = new NxtControl.GuiFramework.FreeText();
			this.iDEFPENP1 = new NxtControl.GuiFramework.Rectangle();
			this.iDEFPENP1n = new NxtControl.GuiFramework.FreeText();
			this.iDEFPENP2 = new NxtControl.GuiFramework.Polygon();
			this.iDEFPENP2n = new NxtControl.GuiFramework.FreeText();
			this.iDEFPENTxt = new NxtControl.GuiFramework.FreeText();
			this.rDEFB1 = new NxtControl.GuiFramework.FreeText();
			this.nDEFB1 = new NxtControl.GuiFramework.FreeText();
			this.iDEFB1P1 = new NxtControl.GuiFramework.Rectangle();
			this.iDEFB1P1n = new NxtControl.GuiFramework.FreeText();
			this.iDEFB1P2 = new NxtControl.GuiFramework.Polygon();
			this.iDEFB1P2n = new NxtControl.GuiFramework.FreeText();
			this.iDEFB1Txt = new NxtControl.GuiFramework.FreeText();
			this.rDEFB2 = new NxtControl.GuiFramework.FreeText();
			this.nDEFB2 = new NxtControl.GuiFramework.FreeText();
			this.iDEFB2P1 = new NxtControl.GuiFramework.Rectangle();
			this.iDEFB2P1n = new NxtControl.GuiFramework.FreeText();
			this.iDEFB2P2 = new NxtControl.GuiFramework.Polygon();
			this.iDEFB2P2n = new NxtControl.GuiFramework.FreeText();
			this.iDEFB2Txt = new NxtControl.GuiFramework.FreeText();
			this.rDEFCMP = new NxtControl.GuiFramework.FreeText();
			this.nDEFCMP = new NxtControl.GuiFramework.FreeText();
			this.iDEFCMPP1 = new NxtControl.GuiFramework.Rectangle();
			this.iDEFCMPP1n = new NxtControl.GuiFramework.FreeText();
			this.iDEFCMPP2 = new NxtControl.GuiFramework.Polygon();
			this.iDEFCMPP2n = new NxtControl.GuiFramework.FreeText();
			this.iDEFCMPTxt = new NxtControl.GuiFramework.FreeText();
			this.rDEFRSP = new NxtControl.GuiFramework.FreeText();
			this.nDEFRSP = new NxtControl.GuiFramework.FreeText();
			this.iDEFRSPP1 = new NxtControl.GuiFramework.Rectangle();
			this.iDEFRSPP1n = new NxtControl.GuiFramework.FreeText();
			this.iDEFRSPP2 = new NxtControl.GuiFramework.Polygon();
			this.iDEFRSPP2n = new NxtControl.GuiFramework.FreeText();
			this.iDEFRSPTxt = new NxtControl.GuiFramework.FreeText();
			this.rDEFR1 = new NxtControl.GuiFramework.FreeText();
			this.nDEFR1 = new NxtControl.GuiFramework.FreeText();
			this.iDEFR1P1 = new NxtControl.GuiFramework.Rectangle();
			this.iDEFR1P1n = new NxtControl.GuiFramework.FreeText();
			this.iDEFR1P2 = new NxtControl.GuiFramework.Polygon();
			this.iDEFR1P2n = new NxtControl.GuiFramework.FreeText();
			this.iDEFR1Txt = new NxtControl.GuiFramework.FreeText();
			this.rDEFR2 = new NxtControl.GuiFramework.FreeText();
			this.nDEFR2 = new NxtControl.GuiFramework.FreeText();
			this.iDEFR2P1 = new NxtControl.GuiFramework.Rectangle();
			this.iDEFR2P1n = new NxtControl.GuiFramework.FreeText();
			this.iDEFR2P2 = new NxtControl.GuiFramework.Polygon();
			this.iDEFR2P2n = new NxtControl.GuiFramework.FreeText();
			this.iDEFR2Txt = new NxtControl.GuiFramework.FreeText();
			this.rNIVELAGUA = new NxtControl.GuiFramework.FreeText();
			this.nNIVELAGUA = new NxtControl.GuiFramework.FreeText();
			this.iNIVELAGUAP1 = new NxtControl.GuiFramework.Rectangle();
			this.iNIVELAGUAP1n = new NxtControl.GuiFramework.FreeText();
			this.iNIVELAGUAP2 = new NxtControl.GuiFramework.Polygon();
			this.iNIVELAGUAP2n = new NxtControl.GuiFramework.FreeText();
			this.iNIVELAGUATxt = new NxtControl.GuiFramework.FreeText();
			this.rNIVELPENEIRA = new NxtControl.GuiFramework.FreeText();
			this.nNIVELPENEIRA = new NxtControl.GuiFramework.FreeText();
			this.iNIVELPENEIRAP1 = new NxtControl.GuiFramework.Rectangle();
			this.iNIVELPENEIRAP1n = new NxtControl.GuiFramework.FreeText();
			this.iNIVELPENEIRAP2 = new NxtControl.GuiFramework.Polygon();
			this.iNIVELPENEIRAP2n = new NxtControl.GuiFramework.FreeText();
			this.iNIVELPENEIRATxt = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnAjustes = new NxtControl.GuiFramework.DrawnButton();
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
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(64D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(20D, 10D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "DISPONÍVEL";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 39D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 54D),
			new NxtControl.Drawing.PointF(28D, 38D),
			new NxtControl.Drawing.PointF(36D, 54D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 42D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 38D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// textoBloq
			// 
			this.textoBloq.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoBloq.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.textoBloq.Location = new NxtControl.Drawing.PointF(330D, 14D);
			this.textoBloq.Name = "textoBloq";
			this.textoBloq.Text = "EEE Bruto bloqueada (nenhuma UCT disponível)";
			this.textoBloq.Visible = false;
			// 
			// tituloSub
			// 
			this.tituloSub.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloSub.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloSub.Location = new NxtControl.Drawing.PointF(20D, 76D);
			this.tituloSub.Name = "tituloSub";
			this.tituloSub.Text = "Subsistemas";
			// 
			// cabModo
			// 
			this.cabModo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.cabModo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.cabModo.Location = new NxtControl.Drawing.PointF(220D, 78D);
			this.cabModo.Name = "cabModo";
			this.cabModo.Text = "Modo";
			// 
			// cabLiga
			// 
			this.cabLiga.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.cabLiga.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.cabLiga.Location = new NxtControl.Drawing.PointF(420D, 78D);
			this.cabLiga.Name = "cabLiga";
			this.cabLiga.Text = "Automático";
			// 
			// linPen
			// 
			this.linPen.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(97D)), ((float)(576D)), ((float)(40D)));
			this.linPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linPen.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linPen.Name = "linPen";
			this.linPen.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rotPen
			// 
			this.rotPen.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rotPen.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotPen.Location = new NxtControl.Drawing.PointF(22D, 109D);
			this.rotPen.Name = "rotPen";
			this.rotPen.Text = "Peneira e higienização";
			// 
			// btnManPen
			// 
			this.btnManPen.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(100D)), ((float)(90D)), ((float)(34D)));
			this.btnManPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManPen.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnAutoPen.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(100D)), ((float)(100D)), ((float)(34D)));
			this.btnAutoPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutoPen.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnDesPen.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(100D)), ((float)(84D)), ((float)(34D)));
			this.btnDesPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesPen.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnLigPen.Bounds = new NxtControl.Drawing.RectF(((float)(500D)), ((float)(100D)), ((float)(84D)), ((float)(34D)));
			this.btnLigPen.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigPen.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			// linRos
			// 
			this.linRos.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(141D)), ((float)(576D)), ((float)(40D)));
			this.linRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linRos.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linRos.Name = "linRos";
			this.linRos.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rotRos
			// 
			this.rotRos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rotRos.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotRos.Location = new NxtControl.Drawing.PointF(22D, 153D);
			this.rotRos.Name = "rotRos";
			this.rotRos.Text = "Roscas";
			// 
			// btnManRos
			// 
			this.btnManRos.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(144D)), ((float)(90D)), ((float)(34D)));
			this.btnManRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManRos.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnAutoRos.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(144D)), ((float)(100D)), ((float)(34D)));
			this.btnAutoRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutoRos.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnDesRos.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(144D)), ((float)(84D)), ((float)(34D)));
			this.btnDesRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesRos.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnLigRos.Bounds = new NxtControl.Drawing.RectF(((float)(500D)), ((float)(144D)), ((float)(84D)), ((float)(34D)));
			this.btnLigRos.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigRos.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			// linRc
			// 
			this.linRc.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(185D)), ((float)(576D)), ((float)(40D)));
			this.linRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linRc.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linRc.Name = "linRc";
			this.linRc.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rotRc
			// 
			this.rotRc.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rotRc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotRc.Location = new NxtControl.Drawing.PointF(22D, 197D);
			this.rotRc.Name = "rotRc";
			this.rotRc.Text = "Raspador e compressor";
			// 
			// btnManRc
			// 
			this.btnManRc.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(188D)), ((float)(90D)), ((float)(34D)));
			this.btnManRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManRc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnAutoRc.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(188D)), ((float)(100D)), ((float)(34D)));
			this.btnAutoRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutoRc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnDesRc.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(188D)), ((float)(84D)), ((float)(34D)));
			this.btnDesRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesRc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			this.btnLigRc.Bounds = new NxtControl.Drawing.RectF(((float)(500D)), ((float)(188D)), ((float)(84D)), ((float)(34D)));
			this.btnLigRc.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigRc.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
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
			// linBomba
			// 
			this.linBomba.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(229D)), ((float)(576D)), ((float)(40D)));
			this.linBomba.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linBomba.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linBomba.Name = "linBomba";
			this.linBomba.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rotBomba
			// 
			this.rotBomba.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rotBomba.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotBomba.Location = new NxtControl.Drawing.PointF(22D, 241D);
			this.rotBomba.Name = "rotBomba";
			this.rotBomba.Text = "Bomba de higienização";
			// 
			// btnB1
			// 
			this.btnB1.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(232D)), ((float)(90D)), ((float)(34D)));
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
			this.btnB2.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(232D)), ((float)(100D)), ((float)(34D)));
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
			// tituloNiveis
			// 
			this.tituloNiveis.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloNiveis.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloNiveis.Location = new NxtControl.Drawing.PointF(20D, 284D);
			this.tituloNiveis.Name = "tituloNiveis";
			this.tituloNiveis.Text = "Níveis";
			// 
			// rotNivel
			// 
			this.rotNivel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rotNivel.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotNivel.Location = new NxtControl.Drawing.PointF(300D, 286D);
			this.rotNivel.Name = "rotNivel";
			this.rotNivel.Text = "Nível da peneira";
			// 
			// vNivel
			// 
			this.vNivel.BeginInit();
			this.vNivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vNivel.DecimalPlacesCount = ((uint)(1u));
			this.vNivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 420D, 281D);
			this.vNivel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
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
			// rn0
			// 
			this.rn0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rn0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rn0.Location = new NxtControl.Drawing.PointF(22D, 308D);
			this.rn0.Name = "rn0";
			this.rn0.Text = "Nível baixo da peneira";
			// 
			// vn0
			// 
			this.vn0.BeginInit();
			this.vn0.DecimalPlacesCount = ((uint)(2u));
			this.vn0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 222D, 308D);
			this.vn0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vn0.IsOnlyInput = true;
			this.vn0.Name = "vn0";
			propertyDictionary3.Add("Text", "não");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary4.Add("Text", "SIM");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vn0.Ranges.Clear();
			this.vn0.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary3));
			this.vn0.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary4));
			propertyDictionary2.Add("Text", "-");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vn0.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.vn0.TagName = "STS_NIVEL_BAIXO_PENEIRA";
			this.vn0.TextAngle = 0F;
			this.vn0.EndInit();
			// 
			// rn1
			// 
			this.rn1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rn1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rn1.Location = new NxtControl.Drawing.PointF(312D, 308D);
			this.rn1.Name = "rn1";
			this.rn1.Text = "Nível alto da peneira";
			// 
			// vn1
			// 
			this.vn1.BeginInit();
			this.vn1.DecimalPlacesCount = ((uint)(2u));
			this.vn1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 512D, 308D);
			this.vn1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vn1.IsOnlyInput = true;
			this.vn1.Name = "vn1";
			propertyDictionary6.Add("Text", "não");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary7.Add("Text", "SIM");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vn1.Ranges.Clear();
			this.vn1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary6));
			this.vn1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary7));
			propertyDictionary5.Add("Text", "-");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vn1.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.vn1.TagName = "STS_NIVEL_ALTO_PENEIRA";
			this.vn1.TextAngle = 0F;
			this.vn1.EndInit();
			// 
			// rn2
			// 
			this.rn2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rn2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rn2.Location = new NxtControl.Drawing.PointF(22D, 330D);
			this.rn2.Name = "rn2";
			this.rn2.Text = "Nível baixo do tanque de água";
			// 
			// vn2
			// 
			this.vn2.BeginInit();
			this.vn2.DecimalPlacesCount = ((uint)(2u));
			this.vn2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 222D, 330D);
			this.vn2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vn2.IsOnlyInput = true;
			this.vn2.Name = "vn2";
			propertyDictionary9.Add("Text", "não");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary10.Add("Text", "SIM");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vn2.Ranges.Clear();
			this.vn2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary9));
			this.vn2.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary10));
			propertyDictionary8.Add("Text", "-");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vn2.Ranges.DefaultPropertyValues = propertyDictionary8;
			this.vn2.TagName = "STS_NIVEL_BAIXO_TANQUE_AGUA";
			this.vn2.TextAngle = 0F;
			this.vn2.EndInit();
			// 
			// rn3
			// 
			this.rn3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rn3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rn3.Location = new NxtControl.Drawing.PointF(312D, 330D);
			this.rn3.Name = "rn3";
			this.rn3.Text = "Nível alto do tanque de gordura";
			// 
			// vn3
			// 
			this.vn3.BeginInit();
			this.vn3.DecimalPlacesCount = ((uint)(2u));
			this.vn3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 512D, 330D);
			this.vn3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vn3.IsOnlyInput = true;
			this.vn3.Name = "vn3";
			propertyDictionary12.Add("Text", "não");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary13.Add("Text", "SIM");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vn3.Ranges.Clear();
			this.vn3.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary12));
			this.vn3.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary13));
			propertyDictionary11.Add("Text", "-");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vn3.Ranges.DefaultPropertyValues = propertyDictionary11;
			this.vn3.TagName = "STS_NIVEL_ALTO_TANQUE_GORDURA";
			this.vn3.TextAngle = 0F;
			this.vn3.EndInit();
			// 
			// tituloGordura
			// 
			this.tituloGordura.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloGordura.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloGordura.Location = new NxtControl.Drawing.PointF(20D, 360D);
			this.tituloGordura.Name = "tituloGordura";
			this.tituloGordura.Text = "Bomba de gordura e válvula de lavagem";
			// 
			// textoEtapa
			// 
			this.textoEtapa.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEtapa.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoEtapa.Location = new NxtControl.Drawing.PointF(22D, 384D);
			this.textoEtapa.Name = "textoEtapa";
			this.textoEtapa.Text = "Parada";
			// 
			// rotRest
			// 
			this.rotRest.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rotRest.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotRest.Location = new NxtControl.Drawing.PointF(300D, 384D);
			this.rotRest.Name = "rotRest";
			this.rotRest.Text = "Tempo restante";
			// 
			// vRest
			// 
			this.vRest.BeginInit();
			this.vRest.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vRest.DecimalPlacesCount = ((uint)(0u));
			this.vRest.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4D, 0D, 0D, 1D, 400D, 379D);
			this.vRest.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vRest.FontScale = false;
			this.vRest.IsOnlyInput = true;
			this.vRest.IsPrefixSuffixOutside = false;
			this.vRest.LeadingZeros = ((uint)(0u));
			this.vRest.Name = "vRest";
			this.vRest.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary14.Add("Text", "${Value}");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary14.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary14.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vRest.Ranges.DefaultPropertyValues = propertyDictionary14;
			this.vRest.Suffix = " s";
			this.vRest.TagName = "STS_TEMPO_RESTANTE";
			this.vRest.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vRest.EndInit();
			// 
			// textoValv
			// 
			this.textoValv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoValv.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoValv.Location = new NxtControl.Drawing.PointF(22D, 417D);
			this.textoValv.Name = "textoValv";
			this.textoValv.Text = "Válvula fechada";
			// 
			// btnValvFecha
			// 
			this.btnValvFecha.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(408D)), ((float)(100D)), ((float)(34D)));
			this.btnValvFecha.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnValvFecha.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnValvFecha.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnValvFecha.Name = "btnValvFecha";
			this.btnValvFecha.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnValvFecha.Radius = 2D;
			this.btnValvFecha.Text = "Fechar";
			this.btnValvFecha.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnValvFecha.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnValvFecha.Use3DEffect = false;
			this.btnValvFecha.Click += new System.EventHandler(this.BtnValvFechaClick);
			// 
			// btnValvAbre
			// 
			this.btnValvAbre.Bounds = new NxtControl.Drawing.RectF(((float)(410D)), ((float)(408D)), ((float)(100D)), ((float)(34D)));
			this.btnValvAbre.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnValvAbre.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnValvAbre.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnValvAbre.Name = "btnValvAbre";
			this.btnValvAbre.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnValvAbre.Radius = 2D;
			this.btnValvAbre.Text = "Abrir";
			this.btnValvAbre.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnValvAbre.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnValvAbre.Use3DEffect = false;
			this.btnValvAbre.Click += new System.EventHandler(this.BtnValvAbreClick);
			// 
			// textoValvAuto
			// 
			this.textoValvAuto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoValvAuto.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.textoValvAuto.Location = new NxtControl.Drawing.PointF(296D, 417D);
			this.textoValvAuto.Name = "textoValvAuto";
			this.textoValvAuto.Text = "Válvula comandada pela sequência automática";
			this.textoValvAuto.Visible = false;
			// 
			// tituloAlm
			// 
			this.tituloAlm.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloAlm.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloAlm.Location = new NxtControl.Drawing.PointF(20D, 454D);
			this.tituloAlm.Name = "tituloAlm";
			this.tituloAlm.Text = "Alarmes";
			// 
			// rCOM
			// 
			this.rCOM.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rCOM.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rCOM.Location = new NxtControl.Drawing.PointF(22D, 478D);
			this.rCOM.Name = "rCOM";
			this.rCOM.Text = "Comunicação";
			// 
			// nCOM
			// 
			this.nCOM.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nCOM.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nCOM.Location = new NxtControl.Drawing.PointF(212D, 478D);
			this.nCOM.Name = "nCOM";
			this.nCOM.Text = "—";
			// 
			// iCOMP1
			// 
			this.iCOMP1.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(478D)), ((float)(16D)), ((float)(16D)));
			this.iCOMP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iCOMP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iCOMP1.Name = "iCOMP1";
			this.iCOMP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iCOMP1.Visible = false;
			// 
			// iCOMP1n
			// 
			this.iCOMP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iCOMP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iCOMP1n.Location = new NxtControl.Drawing.PointF(212D, 479D);
			this.iCOMP1n.Name = "iCOMP1n";
			this.iCOMP1n.Text = "1";
			this.iCOMP1n.Visible = false;
			// 
			// iCOMP2
			// 
			this.iCOMP2.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(478D)), ((float)(16D)), ((float)(16D)));
			this.iCOMP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iCOMP2.Closed = true;
			this.iCOMP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iCOMP2.Name = "iCOMP2";
			this.iCOMP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iCOMP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 494D),
			new NxtControl.Drawing.PointF(216D, 478D),
			new NxtControl.Drawing.PointF(224D, 494D)});
			this.iCOMP2.Visible = false;
			// 
			// iCOMP2n
			// 
			this.iCOMP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iCOMP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iCOMP2n.Location = new NxtControl.Drawing.PointF(213D, 482D);
			this.iCOMP2n.Name = "iCOMP2n";
			this.iCOMP2n.Text = "2";
			this.iCOMP2n.Visible = false;
			// 
			// iCOMTxt
			// 
			this.iCOMTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iCOMTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iCOMTxt.Location = new NxtControl.Drawing.PointF(228D, 478D);
			this.iCOMTxt.Name = "iCOMTxt";
			this.iCOMTxt.Text = "";
			this.iCOMTxt.Visible = false;
			// 
			// rEMERGENCIA
			// 
			this.rEMERGENCIA.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rEMERGENCIA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rEMERGENCIA.Location = new NxtControl.Drawing.PointF(22D, 502D);
			this.rEMERGENCIA.Name = "rEMERGENCIA";
			this.rEMERGENCIA.Text = "Emergência";
			// 
			// nEMERGENCIA
			// 
			this.nEMERGENCIA.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nEMERGENCIA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nEMERGENCIA.Location = new NxtControl.Drawing.PointF(212D, 502D);
			this.nEMERGENCIA.Name = "nEMERGENCIA";
			this.nEMERGENCIA.Text = "—";
			// 
			// iEMERGENCIAP1
			// 
			this.iEMERGENCIAP1.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iEMERGENCIAP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iEMERGENCIAP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iEMERGENCIAP1.Name = "iEMERGENCIAP1";
			this.iEMERGENCIAP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iEMERGENCIAP1.Visible = false;
			// 
			// iEMERGENCIAP1n
			// 
			this.iEMERGENCIAP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iEMERGENCIAP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iEMERGENCIAP1n.Location = new NxtControl.Drawing.PointF(212D, 503D);
			this.iEMERGENCIAP1n.Name = "iEMERGENCIAP1n";
			this.iEMERGENCIAP1n.Text = "1";
			this.iEMERGENCIAP1n.Visible = false;
			// 
			// iEMERGENCIAP2
			// 
			this.iEMERGENCIAP2.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iEMERGENCIAP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iEMERGENCIAP2.Closed = true;
			this.iEMERGENCIAP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iEMERGENCIAP2.Name = "iEMERGENCIAP2";
			this.iEMERGENCIAP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iEMERGENCIAP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 518D),
			new NxtControl.Drawing.PointF(216D, 502D),
			new NxtControl.Drawing.PointF(224D, 518D)});
			this.iEMERGENCIAP2.Visible = false;
			// 
			// iEMERGENCIAP2n
			// 
			this.iEMERGENCIAP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iEMERGENCIAP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iEMERGENCIAP2n.Location = new NxtControl.Drawing.PointF(213D, 506D);
			this.iEMERGENCIAP2n.Name = "iEMERGENCIAP2n";
			this.iEMERGENCIAP2n.Text = "2";
			this.iEMERGENCIAP2n.Visible = false;
			// 
			// iEMERGENCIATxt
			// 
			this.iEMERGENCIATxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iEMERGENCIATxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iEMERGENCIATxt.Location = new NxtControl.Drawing.PointF(228D, 502D);
			this.iEMERGENCIATxt.Name = "iEMERGENCIATxt";
			this.iEMERGENCIATxt.Text = "";
			this.iEMERGENCIATxt.Visible = false;
			// 
			// rDEFPEN
			// 
			this.rDEFPEN.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDEFPEN.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDEFPEN.Location = new NxtControl.Drawing.PointF(22D, 526D);
			this.rDEFPEN.Name = "rDEFPEN";
			this.rDEFPEN.Text = "Peneira";
			// 
			// nDEFPEN
			// 
			this.nDEFPEN.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDEFPEN.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDEFPEN.Location = new NxtControl.Drawing.PointF(212D, 526D);
			this.nDEFPEN.Name = "nDEFPEN";
			this.nDEFPEN.Text = "—";
			// 
			// iDEFPENP1
			// 
			this.iDEFPENP1.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iDEFPENP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDEFPENP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFPENP1.Name = "iDEFPENP1";
			this.iDEFPENP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFPENP1.Visible = false;
			// 
			// iDEFPENP1n
			// 
			this.iDEFPENP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDEFPENP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFPENP1n.Location = new NxtControl.Drawing.PointF(212D, 527D);
			this.iDEFPENP1n.Name = "iDEFPENP1n";
			this.iDEFPENP1n.Text = "1";
			this.iDEFPENP1n.Visible = false;
			// 
			// iDEFPENP2
			// 
			this.iDEFPENP2.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iDEFPENP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDEFPENP2.Closed = true;
			this.iDEFPENP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFPENP2.Name = "iDEFPENP2";
			this.iDEFPENP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFPENP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 542D),
			new NxtControl.Drawing.PointF(216D, 526D),
			new NxtControl.Drawing.PointF(224D, 542D)});
			this.iDEFPENP2.Visible = false;
			// 
			// iDEFPENP2n
			// 
			this.iDEFPENP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFPENP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDEFPENP2n.Location = new NxtControl.Drawing.PointF(213D, 530D);
			this.iDEFPENP2n.Name = "iDEFPENP2n";
			this.iDEFPENP2n.Text = "2";
			this.iDEFPENP2n.Visible = false;
			// 
			// iDEFPENTxt
			// 
			this.iDEFPENTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFPENTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFPENTxt.Location = new NxtControl.Drawing.PointF(228D, 526D);
			this.iDEFPENTxt.Name = "iDEFPENTxt";
			this.iDEFPENTxt.Text = "";
			this.iDEFPENTxt.Visible = false;
			// 
			// rDEFB1
			// 
			this.rDEFB1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDEFB1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDEFB1.Location = new NxtControl.Drawing.PointF(22D, 550D);
			this.rDEFB1.Name = "rDEFB1";
			this.rDEFB1.Text = "Bomba de higienização 1";
			// 
			// nDEFB1
			// 
			this.nDEFB1.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDEFB1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDEFB1.Location = new NxtControl.Drawing.PointF(212D, 550D);
			this.nDEFB1.Name = "nDEFB1";
			this.nDEFB1.Text = "—";
			// 
			// iDEFB1P1
			// 
			this.iDEFB1P1.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iDEFB1P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDEFB1P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFB1P1.Name = "iDEFB1P1";
			this.iDEFB1P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFB1P1.Visible = false;
			// 
			// iDEFB1P1n
			// 
			this.iDEFB1P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDEFB1P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFB1P1n.Location = new NxtControl.Drawing.PointF(212D, 551D);
			this.iDEFB1P1n.Name = "iDEFB1P1n";
			this.iDEFB1P1n.Text = "1";
			this.iDEFB1P1n.Visible = false;
			// 
			// iDEFB1P2
			// 
			this.iDEFB1P2.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iDEFB1P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDEFB1P2.Closed = true;
			this.iDEFB1P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFB1P2.Name = "iDEFB1P2";
			this.iDEFB1P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFB1P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 566D),
			new NxtControl.Drawing.PointF(216D, 550D),
			new NxtControl.Drawing.PointF(224D, 566D)});
			this.iDEFB1P2.Visible = false;
			// 
			// iDEFB1P2n
			// 
			this.iDEFB1P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFB1P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDEFB1P2n.Location = new NxtControl.Drawing.PointF(213D, 554D);
			this.iDEFB1P2n.Name = "iDEFB1P2n";
			this.iDEFB1P2n.Text = "2";
			this.iDEFB1P2n.Visible = false;
			// 
			// iDEFB1Txt
			// 
			this.iDEFB1Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFB1Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFB1Txt.Location = new NxtControl.Drawing.PointF(228D, 550D);
			this.iDEFB1Txt.Name = "iDEFB1Txt";
			this.iDEFB1Txt.Text = "";
			this.iDEFB1Txt.Visible = false;
			// 
			// rDEFB2
			// 
			this.rDEFB2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDEFB2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDEFB2.Location = new NxtControl.Drawing.PointF(22D, 574D);
			this.rDEFB2.Name = "rDEFB2";
			this.rDEFB2.Text = "Bomba de higienização 2";
			// 
			// nDEFB2
			// 
			this.nDEFB2.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDEFB2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDEFB2.Location = new NxtControl.Drawing.PointF(212D, 574D);
			this.nDEFB2.Name = "nDEFB2";
			this.nDEFB2.Text = "—";
			// 
			// iDEFB2P1
			// 
			this.iDEFB2P1.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iDEFB2P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDEFB2P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFB2P1.Name = "iDEFB2P1";
			this.iDEFB2P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFB2P1.Visible = false;
			// 
			// iDEFB2P1n
			// 
			this.iDEFB2P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDEFB2P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFB2P1n.Location = new NxtControl.Drawing.PointF(212D, 575D);
			this.iDEFB2P1n.Name = "iDEFB2P1n";
			this.iDEFB2P1n.Text = "1";
			this.iDEFB2P1n.Visible = false;
			// 
			// iDEFB2P2
			// 
			this.iDEFB2P2.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iDEFB2P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDEFB2P2.Closed = true;
			this.iDEFB2P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFB2P2.Name = "iDEFB2P2";
			this.iDEFB2P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFB2P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 590D),
			new NxtControl.Drawing.PointF(216D, 574D),
			new NxtControl.Drawing.PointF(224D, 590D)});
			this.iDEFB2P2.Visible = false;
			// 
			// iDEFB2P2n
			// 
			this.iDEFB2P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFB2P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDEFB2P2n.Location = new NxtControl.Drawing.PointF(213D, 578D);
			this.iDEFB2P2n.Name = "iDEFB2P2n";
			this.iDEFB2P2n.Text = "2";
			this.iDEFB2P2n.Visible = false;
			// 
			// iDEFB2Txt
			// 
			this.iDEFB2Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFB2Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFB2Txt.Location = new NxtControl.Drawing.PointF(228D, 574D);
			this.iDEFB2Txt.Name = "iDEFB2Txt";
			this.iDEFB2Txt.Text = "";
			this.iDEFB2Txt.Visible = false;
			// 
			// rDEFCMP
			// 
			this.rDEFCMP.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDEFCMP.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDEFCMP.Location = new NxtControl.Drawing.PointF(22D, 598D);
			this.rDEFCMP.Name = "rDEFCMP";
			this.rDEFCMP.Text = "Compressor";
			// 
			// nDEFCMP
			// 
			this.nDEFCMP.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDEFCMP.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDEFCMP.Location = new NxtControl.Drawing.PointF(212D, 598D);
			this.nDEFCMP.Name = "nDEFCMP";
			this.nDEFCMP.Text = "—";
			// 
			// iDEFCMPP1
			// 
			this.iDEFCMPP1.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(598D)), ((float)(16D)), ((float)(16D)));
			this.iDEFCMPP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDEFCMPP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFCMPP1.Name = "iDEFCMPP1";
			this.iDEFCMPP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFCMPP1.Visible = false;
			// 
			// iDEFCMPP1n
			// 
			this.iDEFCMPP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDEFCMPP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFCMPP1n.Location = new NxtControl.Drawing.PointF(212D, 599D);
			this.iDEFCMPP1n.Name = "iDEFCMPP1n";
			this.iDEFCMPP1n.Text = "1";
			this.iDEFCMPP1n.Visible = false;
			// 
			// iDEFCMPP2
			// 
			this.iDEFCMPP2.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(598D)), ((float)(16D)), ((float)(16D)));
			this.iDEFCMPP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDEFCMPP2.Closed = true;
			this.iDEFCMPP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFCMPP2.Name = "iDEFCMPP2";
			this.iDEFCMPP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFCMPP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(208D, 614D),
			new NxtControl.Drawing.PointF(216D, 598D),
			new NxtControl.Drawing.PointF(224D, 614D)});
			this.iDEFCMPP2.Visible = false;
			// 
			// iDEFCMPP2n
			// 
			this.iDEFCMPP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFCMPP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDEFCMPP2n.Location = new NxtControl.Drawing.PointF(213D, 602D);
			this.iDEFCMPP2n.Name = "iDEFCMPP2n";
			this.iDEFCMPP2n.Text = "2";
			this.iDEFCMPP2n.Visible = false;
			// 
			// iDEFCMPTxt
			// 
			this.iDEFCMPTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFCMPTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFCMPTxt.Location = new NxtControl.Drawing.PointF(228D, 598D);
			this.iDEFCMPTxt.Name = "iDEFCMPTxt";
			this.iDEFCMPTxt.Text = "";
			this.iDEFCMPTxt.Visible = false;
			// 
			// rDEFRSP
			// 
			this.rDEFRSP.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDEFRSP.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDEFRSP.Location = new NxtControl.Drawing.PointF(312D, 478D);
			this.rDEFRSP.Name = "rDEFRSP";
			this.rDEFRSP.Text = "Raspador";
			// 
			// nDEFRSP
			// 
			this.nDEFRSP.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDEFRSP.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDEFRSP.Location = new NxtControl.Drawing.PointF(502D, 478D);
			this.nDEFRSP.Name = "nDEFRSP";
			this.nDEFRSP.Text = "—";
			// 
			// iDEFRSPP1
			// 
			this.iDEFRSPP1.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(478D)), ((float)(16D)), ((float)(16D)));
			this.iDEFRSPP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDEFRSPP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFRSPP1.Name = "iDEFRSPP1";
			this.iDEFRSPP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFRSPP1.Visible = false;
			// 
			// iDEFRSPP1n
			// 
			this.iDEFRSPP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDEFRSPP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFRSPP1n.Location = new NxtControl.Drawing.PointF(502D, 479D);
			this.iDEFRSPP1n.Name = "iDEFRSPP1n";
			this.iDEFRSPP1n.Text = "1";
			this.iDEFRSPP1n.Visible = false;
			// 
			// iDEFRSPP2
			// 
			this.iDEFRSPP2.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(478D)), ((float)(16D)), ((float)(16D)));
			this.iDEFRSPP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDEFRSPP2.Closed = true;
			this.iDEFRSPP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFRSPP2.Name = "iDEFRSPP2";
			this.iDEFRSPP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFRSPP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(498D, 494D),
			new NxtControl.Drawing.PointF(506D, 478D),
			new NxtControl.Drawing.PointF(514D, 494D)});
			this.iDEFRSPP2.Visible = false;
			// 
			// iDEFRSPP2n
			// 
			this.iDEFRSPP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFRSPP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDEFRSPP2n.Location = new NxtControl.Drawing.PointF(503D, 482D);
			this.iDEFRSPP2n.Name = "iDEFRSPP2n";
			this.iDEFRSPP2n.Text = "2";
			this.iDEFRSPP2n.Visible = false;
			// 
			// iDEFRSPTxt
			// 
			this.iDEFRSPTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFRSPTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFRSPTxt.Location = new NxtControl.Drawing.PointF(518D, 478D);
			this.iDEFRSPTxt.Name = "iDEFRSPTxt";
			this.iDEFRSPTxt.Text = "";
			this.iDEFRSPTxt.Visible = false;
			// 
			// rDEFR1
			// 
			this.rDEFR1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDEFR1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDEFR1.Location = new NxtControl.Drawing.PointF(312D, 502D);
			this.rDEFR1.Name = "rDEFR1";
			this.rDEFR1.Text = "Rosca 1";
			// 
			// nDEFR1
			// 
			this.nDEFR1.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDEFR1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDEFR1.Location = new NxtControl.Drawing.PointF(502D, 502D);
			this.nDEFR1.Name = "nDEFR1";
			this.nDEFR1.Text = "—";
			// 
			// iDEFR1P1
			// 
			this.iDEFR1P1.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iDEFR1P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDEFR1P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFR1P1.Name = "iDEFR1P1";
			this.iDEFR1P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFR1P1.Visible = false;
			// 
			// iDEFR1P1n
			// 
			this.iDEFR1P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDEFR1P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFR1P1n.Location = new NxtControl.Drawing.PointF(502D, 503D);
			this.iDEFR1P1n.Name = "iDEFR1P1n";
			this.iDEFR1P1n.Text = "1";
			this.iDEFR1P1n.Visible = false;
			// 
			// iDEFR1P2
			// 
			this.iDEFR1P2.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iDEFR1P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDEFR1P2.Closed = true;
			this.iDEFR1P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFR1P2.Name = "iDEFR1P2";
			this.iDEFR1P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFR1P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(498D, 518D),
			new NxtControl.Drawing.PointF(506D, 502D),
			new NxtControl.Drawing.PointF(514D, 518D)});
			this.iDEFR1P2.Visible = false;
			// 
			// iDEFR1P2n
			// 
			this.iDEFR1P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFR1P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDEFR1P2n.Location = new NxtControl.Drawing.PointF(503D, 506D);
			this.iDEFR1P2n.Name = "iDEFR1P2n";
			this.iDEFR1P2n.Text = "2";
			this.iDEFR1P2n.Visible = false;
			// 
			// iDEFR1Txt
			// 
			this.iDEFR1Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFR1Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFR1Txt.Location = new NxtControl.Drawing.PointF(518D, 502D);
			this.iDEFR1Txt.Name = "iDEFR1Txt";
			this.iDEFR1Txt.Text = "";
			this.iDEFR1Txt.Visible = false;
			// 
			// rDEFR2
			// 
			this.rDEFR2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDEFR2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDEFR2.Location = new NxtControl.Drawing.PointF(312D, 526D);
			this.rDEFR2.Name = "rDEFR2";
			this.rDEFR2.Text = "Rosca 2";
			// 
			// nDEFR2
			// 
			this.nDEFR2.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDEFR2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDEFR2.Location = new NxtControl.Drawing.PointF(502D, 526D);
			this.nDEFR2.Name = "nDEFR2";
			this.nDEFR2.Text = "—";
			// 
			// iDEFR2P1
			// 
			this.iDEFR2P1.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iDEFR2P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDEFR2P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFR2P1.Name = "iDEFR2P1";
			this.iDEFR2P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFR2P1.Visible = false;
			// 
			// iDEFR2P1n
			// 
			this.iDEFR2P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDEFR2P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFR2P1n.Location = new NxtControl.Drawing.PointF(502D, 527D);
			this.iDEFR2P1n.Name = "iDEFR2P1n";
			this.iDEFR2P1n.Text = "1";
			this.iDEFR2P1n.Visible = false;
			// 
			// iDEFR2P2
			// 
			this.iDEFR2P2.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(526D)), ((float)(16D)), ((float)(16D)));
			this.iDEFR2P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDEFR2P2.Closed = true;
			this.iDEFR2P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDEFR2P2.Name = "iDEFR2P2";
			this.iDEFR2P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDEFR2P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(498D, 542D),
			new NxtControl.Drawing.PointF(506D, 526D),
			new NxtControl.Drawing.PointF(514D, 542D)});
			this.iDEFR2P2.Visible = false;
			// 
			// iDEFR2P2n
			// 
			this.iDEFR2P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFR2P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDEFR2P2n.Location = new NxtControl.Drawing.PointF(503D, 530D);
			this.iDEFR2P2n.Name = "iDEFR2P2n";
			this.iDEFR2P2n.Text = "2";
			this.iDEFR2P2n.Visible = false;
			// 
			// iDEFR2Txt
			// 
			this.iDEFR2Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDEFR2Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDEFR2Txt.Location = new NxtControl.Drawing.PointF(518D, 526D);
			this.iDEFR2Txt.Name = "iDEFR2Txt";
			this.iDEFR2Txt.Text = "";
			this.iDEFR2Txt.Visible = false;
			// 
			// rNIVELAGUA
			// 
			this.rNIVELAGUA.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rNIVELAGUA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rNIVELAGUA.Location = new NxtControl.Drawing.PointF(312D, 550D);
			this.rNIVELAGUA.Name = "rNIVELAGUA";
			this.rNIVELAGUA.Text = "Nível baixo do tanque de água";
			// 
			// nNIVELAGUA
			// 
			this.nNIVELAGUA.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nNIVELAGUA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nNIVELAGUA.Location = new NxtControl.Drawing.PointF(502D, 550D);
			this.nNIVELAGUA.Name = "nNIVELAGUA";
			this.nNIVELAGUA.Text = "—";
			// 
			// iNIVELAGUAP1
			// 
			this.iNIVELAGUAP1.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iNIVELAGUAP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iNIVELAGUAP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNIVELAGUAP1.Name = "iNIVELAGUAP1";
			this.iNIVELAGUAP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNIVELAGUAP1.Visible = false;
			// 
			// iNIVELAGUAP1n
			// 
			this.iNIVELAGUAP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iNIVELAGUAP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iNIVELAGUAP1n.Location = new NxtControl.Drawing.PointF(502D, 551D);
			this.iNIVELAGUAP1n.Name = "iNIVELAGUAP1n";
			this.iNIVELAGUAP1n.Text = "1";
			this.iNIVELAGUAP1n.Visible = false;
			// 
			// iNIVELAGUAP2
			// 
			this.iNIVELAGUAP2.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(550D)), ((float)(16D)), ((float)(16D)));
			this.iNIVELAGUAP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iNIVELAGUAP2.Closed = true;
			this.iNIVELAGUAP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNIVELAGUAP2.Name = "iNIVELAGUAP2";
			this.iNIVELAGUAP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNIVELAGUAP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(498D, 566D),
			new NxtControl.Drawing.PointF(506D, 550D),
			new NxtControl.Drawing.PointF(514D, 566D)});
			this.iNIVELAGUAP2.Visible = false;
			// 
			// iNIVELAGUAP2n
			// 
			this.iNIVELAGUAP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNIVELAGUAP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iNIVELAGUAP2n.Location = new NxtControl.Drawing.PointF(503D, 554D);
			this.iNIVELAGUAP2n.Name = "iNIVELAGUAP2n";
			this.iNIVELAGUAP2n.Text = "2";
			this.iNIVELAGUAP2n.Visible = false;
			// 
			// iNIVELAGUATxt
			// 
			this.iNIVELAGUATxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNIVELAGUATxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iNIVELAGUATxt.Location = new NxtControl.Drawing.PointF(518D, 550D);
			this.iNIVELAGUATxt.Name = "iNIVELAGUATxt";
			this.iNIVELAGUATxt.Text = "";
			this.iNIVELAGUATxt.Visible = false;
			// 
			// rNIVELPENEIRA
			// 
			this.rNIVELPENEIRA.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rNIVELPENEIRA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rNIVELPENEIRA.Location = new NxtControl.Drawing.PointF(312D, 574D);
			this.rNIVELPENEIRA.Name = "rNIVELPENEIRA";
			this.rNIVELPENEIRA.Text = "Nível alto na peneira";
			// 
			// nNIVELPENEIRA
			// 
			this.nNIVELPENEIRA.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nNIVELPENEIRA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nNIVELPENEIRA.Location = new NxtControl.Drawing.PointF(502D, 574D);
			this.nNIVELPENEIRA.Name = "nNIVELPENEIRA";
			this.nNIVELPENEIRA.Text = "—";
			// 
			// iNIVELPENEIRAP1
			// 
			this.iNIVELPENEIRAP1.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iNIVELPENEIRAP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iNIVELPENEIRAP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNIVELPENEIRAP1.Name = "iNIVELPENEIRAP1";
			this.iNIVELPENEIRAP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNIVELPENEIRAP1.Visible = false;
			// 
			// iNIVELPENEIRAP1n
			// 
			this.iNIVELPENEIRAP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iNIVELPENEIRAP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iNIVELPENEIRAP1n.Location = new NxtControl.Drawing.PointF(502D, 575D);
			this.iNIVELPENEIRAP1n.Name = "iNIVELPENEIRAP1n";
			this.iNIVELPENEIRAP1n.Text = "1";
			this.iNIVELPENEIRAP1n.Visible = false;
			// 
			// iNIVELPENEIRAP2
			// 
			this.iNIVELPENEIRAP2.Bounds = new NxtControl.Drawing.RectF(((float)(498D)), ((float)(574D)), ((float)(16D)), ((float)(16D)));
			this.iNIVELPENEIRAP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iNIVELPENEIRAP2.Closed = true;
			this.iNIVELPENEIRAP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNIVELPENEIRAP2.Name = "iNIVELPENEIRAP2";
			this.iNIVELPENEIRAP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNIVELPENEIRAP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(498D, 590D),
			new NxtControl.Drawing.PointF(506D, 574D),
			new NxtControl.Drawing.PointF(514D, 590D)});
			this.iNIVELPENEIRAP2.Visible = false;
			// 
			// iNIVELPENEIRAP2n
			// 
			this.iNIVELPENEIRAP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNIVELPENEIRAP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iNIVELPENEIRAP2n.Location = new NxtControl.Drawing.PointF(503D, 578D);
			this.iNIVELPENEIRAP2n.Name = "iNIVELPENEIRAP2n";
			this.iNIVELPENEIRAP2n.Text = "2";
			this.iNIVELPENEIRAP2n.Visible = false;
			// 
			// iNIVELPENEIRATxt
			// 
			this.iNIVELPENEIRATxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNIVELPENEIRATxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iNIVELPENEIRATxt.Location = new NxtControl.Drawing.PointF(518D, 574D);
			this.iNIVELPENEIRATxt.Name = "iNIVELPENEIRATxt";
			this.iNIVELPENEIRATxt.Text = "";
			this.iNIVELPENEIRATxt.Visible = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(630D)), ((float)(200D)), ((float)(34D)));
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
			// btnAjustes
			// 
			this.btnAjustes.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(630D)), ((float)(200D)), ((float)(34D)));
			this.btnAjustes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAjustes.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnAjustes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAjustes.Name = "btnAjustes";
			this.btnAjustes.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpParameter", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnAjustes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAjustes.Radius = 2D;
			this.btnAjustes.Text = "Ajustes";
			this.btnAjustes.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.Use3DEffect = false;
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
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(680D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.textoEstado,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.textoBloq,
			this.tituloSub,
			this.cabModo,
			this.cabLiga,
			this.linPen,
			this.rotPen,
			this.btnManPen,
			this.btnAutoPen,
			this.btnDesPen,
			this.btnLigPen,
			this.linRos,
			this.rotRos,
			this.btnManRos,
			this.btnAutoRos,
			this.btnDesRos,
			this.btnLigRos,
			this.linRc,
			this.rotRc,
			this.btnManRc,
			this.btnAutoRc,
			this.btnDesRc,
			this.btnLigRc,
			this.linBomba,
			this.rotBomba,
			this.btnB1,
			this.btnB2,
			this.tituloNiveis,
			this.rotNivel,
			this.vNivel,
			this.rn0,
			this.vn0,
			this.rn1,
			this.vn1,
			this.rn2,
			this.vn2,
			this.rn3,
			this.vn3,
			this.tituloGordura,
			this.textoEtapa,
			this.rotRest,
			this.vRest,
			this.textoValv,
			this.btnValvFecha,
			this.btnValvAbre,
			this.textoValvAuto,
			this.tituloAlm,
			this.rCOM,
			this.nCOM,
			this.iCOMP1,
			this.iCOMP1n,
			this.iCOMP2,
			this.iCOMP2n,
			this.iCOMTxt,
			this.rEMERGENCIA,
			this.nEMERGENCIA,
			this.iEMERGENCIAP1,
			this.iEMERGENCIAP1n,
			this.iEMERGENCIAP2,
			this.iEMERGENCIAP2n,
			this.iEMERGENCIATxt,
			this.rDEFPEN,
			this.nDEFPEN,
			this.iDEFPENP1,
			this.iDEFPENP1n,
			this.iDEFPENP2,
			this.iDEFPENP2n,
			this.iDEFPENTxt,
			this.rDEFB1,
			this.nDEFB1,
			this.iDEFB1P1,
			this.iDEFB1P1n,
			this.iDEFB1P2,
			this.iDEFB1P2n,
			this.iDEFB1Txt,
			this.rDEFB2,
			this.nDEFB2,
			this.iDEFB2P1,
			this.iDEFB2P1n,
			this.iDEFB2P2,
			this.iDEFB2P2n,
			this.iDEFB2Txt,
			this.rDEFCMP,
			this.nDEFCMP,
			this.iDEFCMPP1,
			this.iDEFCMPP1n,
			this.iDEFCMPP2,
			this.iDEFCMPP2n,
			this.iDEFCMPTxt,
			this.rDEFRSP,
			this.nDEFRSP,
			this.iDEFRSPP1,
			this.iDEFRSPP1n,
			this.iDEFRSPP2,
			this.iDEFRSPP2n,
			this.iDEFRSPTxt,
			this.rDEFR1,
			this.nDEFR1,
			this.iDEFR1P1,
			this.iDEFR1P1n,
			this.iDEFR1P2,
			this.iDEFR1P2n,
			this.iDEFR1Txt,
			this.rDEFR2,
			this.nDEFR2,
			this.iDEFR2P1,
			this.iDEFR2P1n,
			this.iDEFR2P2,
			this.iDEFR2P2n,
			this.iDEFR2Txt,
			this.rNIVELAGUA,
			this.nNIVELAGUA,
			this.iNIVELAGUAP1,
			this.iNIVELAGUAP1n,
			this.iNIVELAGUAP2,
			this.iNIVELAGUAP2n,
			this.iNIVELAGUATxt,
			this.rNIVELPENEIRA,
			this.nNIVELPENEIRA,
			this.iNIVELPENEIRAP1,
			this.iNIVELPENEIRAP1n,
			this.iNIVELPENEIRAP2,
			this.iNIVELPENEIRAP2n,
			this.iNIVELPENEIRATxt,
			this.btnReset,
			this.btnAjustes,
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
			this.Size = new System.Drawing.Size(600, 680);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText textoBloq;
		private NxtControl.GuiFramework.FreeText tituloSub;
		private NxtControl.GuiFramework.FreeText cabModo;
		private NxtControl.GuiFramework.FreeText cabLiga;
		private NxtControl.GuiFramework.Rectangle linPen;
		private NxtControl.GuiFramework.FreeText rotPen;
		private NxtControl.GuiFramework.DrawnButton btnManPen;
		private NxtControl.GuiFramework.DrawnButton btnAutoPen;
		private NxtControl.GuiFramework.DrawnButton btnDesPen;
		private NxtControl.GuiFramework.DrawnButton btnLigPen;
		private NxtControl.GuiFramework.Rectangle linRos;
		private NxtControl.GuiFramework.FreeText rotRos;
		private NxtControl.GuiFramework.DrawnButton btnManRos;
		private NxtControl.GuiFramework.DrawnButton btnAutoRos;
		private NxtControl.GuiFramework.DrawnButton btnDesRos;
		private NxtControl.GuiFramework.DrawnButton btnLigRos;
		private NxtControl.GuiFramework.Rectangle linRc;
		private NxtControl.GuiFramework.FreeText rotRc;
		private NxtControl.GuiFramework.DrawnButton btnManRc;
		private NxtControl.GuiFramework.DrawnButton btnAutoRc;
		private NxtControl.GuiFramework.DrawnButton btnDesRc;
		private NxtControl.GuiFramework.DrawnButton btnLigRc;
		private NxtControl.GuiFramework.Rectangle linBomba;
		private NxtControl.GuiFramework.FreeText rotBomba;
		private NxtControl.GuiFramework.DrawnButton btnB1;
		private NxtControl.GuiFramework.DrawnButton btnB2;
		private NxtControl.GuiFramework.FreeText tituloNiveis;
		private NxtControl.GuiFramework.FreeText rotNivel;
		private System.HMI.Symbols.Base.Label<System.Single> vNivel;
		private NxtControl.GuiFramework.FreeText rn0;
		private System.HMI.Symbols.Base.FreeText<bool> vn0;
		private NxtControl.GuiFramework.FreeText rn1;
		private System.HMI.Symbols.Base.FreeText<bool> vn1;
		private NxtControl.GuiFramework.FreeText rn2;
		private System.HMI.Symbols.Base.FreeText<bool> vn2;
		private NxtControl.GuiFramework.FreeText rn3;
		private System.HMI.Symbols.Base.FreeText<bool> vn3;
		private NxtControl.GuiFramework.FreeText tituloGordura;
		private NxtControl.GuiFramework.FreeText textoEtapa;
		private NxtControl.GuiFramework.FreeText rotRest;
		private System.HMI.Symbols.Base.Label<System.Int16> vRest;
		private NxtControl.GuiFramework.FreeText textoValv;
		private NxtControl.GuiFramework.DrawnButton btnValvFecha;
		private NxtControl.GuiFramework.DrawnButton btnValvAbre;
		private NxtControl.GuiFramework.FreeText textoValvAuto;
		private NxtControl.GuiFramework.FreeText tituloAlm;
		private NxtControl.GuiFramework.FreeText rCOM;
		private NxtControl.GuiFramework.FreeText nCOM;
		private NxtControl.GuiFramework.Rectangle iCOMP1;
		private NxtControl.GuiFramework.FreeText iCOMP1n;
		private NxtControl.GuiFramework.Polygon iCOMP2;
		private NxtControl.GuiFramework.FreeText iCOMP2n;
		private NxtControl.GuiFramework.FreeText iCOMTxt;
		private NxtControl.GuiFramework.FreeText rEMERGENCIA;
		private NxtControl.GuiFramework.FreeText nEMERGENCIA;
		private NxtControl.GuiFramework.Rectangle iEMERGENCIAP1;
		private NxtControl.GuiFramework.FreeText iEMERGENCIAP1n;
		private NxtControl.GuiFramework.Polygon iEMERGENCIAP2;
		private NxtControl.GuiFramework.FreeText iEMERGENCIAP2n;
		private NxtControl.GuiFramework.FreeText iEMERGENCIATxt;
		private NxtControl.GuiFramework.FreeText rDEFPEN;
		private NxtControl.GuiFramework.FreeText nDEFPEN;
		private NxtControl.GuiFramework.Rectangle iDEFPENP1;
		private NxtControl.GuiFramework.FreeText iDEFPENP1n;
		private NxtControl.GuiFramework.Polygon iDEFPENP2;
		private NxtControl.GuiFramework.FreeText iDEFPENP2n;
		private NxtControl.GuiFramework.FreeText iDEFPENTxt;
		private NxtControl.GuiFramework.FreeText rDEFB1;
		private NxtControl.GuiFramework.FreeText nDEFB1;
		private NxtControl.GuiFramework.Rectangle iDEFB1P1;
		private NxtControl.GuiFramework.FreeText iDEFB1P1n;
		private NxtControl.GuiFramework.Polygon iDEFB1P2;
		private NxtControl.GuiFramework.FreeText iDEFB1P2n;
		private NxtControl.GuiFramework.FreeText iDEFB1Txt;
		private NxtControl.GuiFramework.FreeText rDEFB2;
		private NxtControl.GuiFramework.FreeText nDEFB2;
		private NxtControl.GuiFramework.Rectangle iDEFB2P1;
		private NxtControl.GuiFramework.FreeText iDEFB2P1n;
		private NxtControl.GuiFramework.Polygon iDEFB2P2;
		private NxtControl.GuiFramework.FreeText iDEFB2P2n;
		private NxtControl.GuiFramework.FreeText iDEFB2Txt;
		private NxtControl.GuiFramework.FreeText rDEFCMP;
		private NxtControl.GuiFramework.FreeText nDEFCMP;
		private NxtControl.GuiFramework.Rectangle iDEFCMPP1;
		private NxtControl.GuiFramework.FreeText iDEFCMPP1n;
		private NxtControl.GuiFramework.Polygon iDEFCMPP2;
		private NxtControl.GuiFramework.FreeText iDEFCMPP2n;
		private NxtControl.GuiFramework.FreeText iDEFCMPTxt;
		private NxtControl.GuiFramework.FreeText rDEFRSP;
		private NxtControl.GuiFramework.FreeText nDEFRSP;
		private NxtControl.GuiFramework.Rectangle iDEFRSPP1;
		private NxtControl.GuiFramework.FreeText iDEFRSPP1n;
		private NxtControl.GuiFramework.Polygon iDEFRSPP2;
		private NxtControl.GuiFramework.FreeText iDEFRSPP2n;
		private NxtControl.GuiFramework.FreeText iDEFRSPTxt;
		private NxtControl.GuiFramework.FreeText rDEFR1;
		private NxtControl.GuiFramework.FreeText nDEFR1;
		private NxtControl.GuiFramework.Rectangle iDEFR1P1;
		private NxtControl.GuiFramework.FreeText iDEFR1P1n;
		private NxtControl.GuiFramework.Polygon iDEFR1P2;
		private NxtControl.GuiFramework.FreeText iDEFR1P2n;
		private NxtControl.GuiFramework.FreeText iDEFR1Txt;
		private NxtControl.GuiFramework.FreeText rDEFR2;
		private NxtControl.GuiFramework.FreeText nDEFR2;
		private NxtControl.GuiFramework.Rectangle iDEFR2P1;
		private NxtControl.GuiFramework.FreeText iDEFR2P1n;
		private NxtControl.GuiFramework.Polygon iDEFR2P2;
		private NxtControl.GuiFramework.FreeText iDEFR2P2n;
		private NxtControl.GuiFramework.FreeText iDEFR2Txt;
		private NxtControl.GuiFramework.FreeText rNIVELAGUA;
		private NxtControl.GuiFramework.FreeText nNIVELAGUA;
		private NxtControl.GuiFramework.Rectangle iNIVELAGUAP1;
		private NxtControl.GuiFramework.FreeText iNIVELAGUAP1n;
		private NxtControl.GuiFramework.Polygon iNIVELAGUAP2;
		private NxtControl.GuiFramework.FreeText iNIVELAGUAP2n;
		private NxtControl.GuiFramework.FreeText iNIVELAGUATxt;
		private NxtControl.GuiFramework.FreeText rNIVELPENEIRA;
		private NxtControl.GuiFramework.FreeText nNIVELPENEIRA;
		private NxtControl.GuiFramework.Rectangle iNIVELPENEIRAP1;
		private NxtControl.GuiFramework.FreeText iNIVELPENEIRAP1n;
		private NxtControl.GuiFramework.Polygon iNIVELPENEIRAP2;
		private NxtControl.GuiFramework.FreeText iNIVELPENEIRAP2n;
		private NxtControl.GuiFramework.FreeText iNIVELPENEIRATxt;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnAjustes;
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
