/*
 * Hidryco - Gerador_Generico - fpDefault
 * ISA-101: grandezas do gerador, estado do QTA, motor, alarmes (forma + prioridade, piscando ate reconhecer).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Gerador_Generico
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary21 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary22 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary23 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary24 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.rtGB = new NxtControl.GuiFramework.FreeText();
			this.tGB = new NxtControl.GuiFramework.FreeText();
			this.rtMB = new NxtControl.GuiFramework.FreeText();
			this.tMB = new NxtControl.GuiFramework.FreeText();
			this.rtModo = new NxtControl.GuiFramework.FreeText();
			this.tModo = new NxtControl.GuiFramework.FreeText();
			this.rtFonte = new NxtControl.GuiFramework.FreeText();
			this.tFonte = new NxtControl.GuiFramework.FreeText();
			this.lin0 = new NxtControl.GuiFramework.Rectangle();
			this.rot0 = new NxtControl.GuiFramework.FreeText();
			this.v0_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v0_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v0_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin1 = new NxtControl.GuiFramework.Rectangle();
			this.rot1 = new NxtControl.GuiFramework.FreeText();
			this.v1_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v1_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v1_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin2 = new NxtControl.GuiFramework.Rectangle();
			this.rot2 = new NxtControl.GuiFramework.FreeText();
			this.v2_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v2_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v2_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin3 = new NxtControl.GuiFramework.Rectangle();
			this.rot3 = new NxtControl.GuiFramework.FreeText();
			this.v3_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v3_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v3_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin4 = new NxtControl.GuiFramework.Rectangle();
			this.rot4 = new NxtControl.GuiFramework.FreeText();
			this.v4_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v4_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin5 = new NxtControl.GuiFramework.Rectangle();
			this.rot5 = new NxtControl.GuiFramework.FreeText();
			this.v5_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin6 = new NxtControl.GuiFramework.Rectangle();
			this.rot6 = new NxtControl.GuiFramework.FreeText();
			this.v6_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v6_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin7 = new NxtControl.GuiFramework.Rectangle();
			this.rot7 = new NxtControl.GuiFramework.FreeText();
			this.v7_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v7_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v7_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin8 = new NxtControl.GuiFramework.Rectangle();
			this.rot8 = new NxtControl.GuiFramework.FreeText();
			this.v8_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v8_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin9 = new NxtControl.GuiFramework.Rectangle();
			this.rot9 = new NxtControl.GuiFramework.FreeText();
			this.v9_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v9_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.tituloAlm = new NxtControl.GuiFramework.FreeText();
			this.rCom = new NxtControl.GuiFramework.FreeText();
			this.nCom = new NxtControl.GuiFramework.FreeText();
			this.iComP1 = new NxtControl.GuiFramework.Rectangle();
			this.iComP1n = new NxtControl.GuiFramework.FreeText();
			this.iComP2 = new NxtControl.GuiFramework.Polygon();
			this.iComP2n = new NxtControl.GuiFramework.FreeText();
			this.iComTxt = new NxtControl.GuiFramework.FreeText();
			this.rAGC = new NxtControl.GuiFramework.FreeText();
			this.nAGC = new NxtControl.GuiFramework.FreeText();
			this.iAGCP1 = new NxtControl.GuiFramework.Rectangle();
			this.iAGCP1n = new NxtControl.GuiFramework.FreeText();
			this.iAGCP2 = new NxtControl.GuiFramework.Polygon();
			this.iAGCP2n = new NxtControl.GuiFramework.FreeText();
			this.iAGCTxt = new NxtControl.GuiFramework.FreeText();
			this.rPartida = new NxtControl.GuiFramework.FreeText();
			this.nPartida = new NxtControl.GuiFramework.FreeText();
			this.iPartidaP1 = new NxtControl.GuiFramework.Rectangle();
			this.iPartidaP1n = new NxtControl.GuiFramework.FreeText();
			this.iPartidaP2 = new NxtControl.GuiFramework.Polygon();
			this.iPartidaP2n = new NxtControl.GuiFramework.FreeText();
			this.iPartidaTxt = new NxtControl.GuiFramework.FreeText();
			this.rMotor = new NxtControl.GuiFramework.FreeText();
			this.nMotor = new NxtControl.GuiFramework.FreeText();
			this.iMotorP1 = new NxtControl.GuiFramework.Rectangle();
			this.iMotorP1n = new NxtControl.GuiFramework.FreeText();
			this.iMotorP2 = new NxtControl.GuiFramework.Polygon();
			this.iMotorP2n = new NxtControl.GuiFramework.FreeText();
			this.iMotorTxt = new NxtControl.GuiFramework.FreeText();
			this.rEmergencia = new NxtControl.GuiFramework.FreeText();
			this.nEmergencia = new NxtControl.GuiFramework.FreeText();
			this.iEmergenciaP1 = new NxtControl.GuiFramework.Rectangle();
			this.iEmergenciaP1n = new NxtControl.GuiFramework.FreeText();
			this.iEmergenciaP2 = new NxtControl.GuiFramework.Polygon();
			this.iEmergenciaP2n = new NxtControl.GuiFramework.FreeText();
			this.iEmergenciaTxt = new NxtControl.GuiFramework.FreeText();
			this.rDisjuntor = new NxtControl.GuiFramework.FreeText();
			this.nDisjuntor = new NxtControl.GuiFramework.FreeText();
			this.iDisjuntorP1 = new NxtControl.GuiFramework.Rectangle();
			this.iDisjuntorP1n = new NxtControl.GuiFramework.FreeText();
			this.iDisjuntorP2 = new NxtControl.GuiFramework.Polygon();
			this.iDisjuntorP2n = new NxtControl.GuiFramework.FreeText();
			this.iDisjuntorTxt = new NxtControl.GuiFramework.FreeText();
			this.rFaltaRede = new NxtControl.GuiFramework.FreeText();
			this.nFaltaRede = new NxtControl.GuiFramework.FreeText();
			this.iFaltaRedeP1 = new NxtControl.GuiFramework.Rectangle();
			this.iFaltaRedeP1n = new NxtControl.GuiFramework.FreeText();
			this.iFaltaRedeP2 = new NxtControl.GuiFramework.Polygon();
			this.iFaltaRedeP2n = new NxtControl.GuiFramework.FreeText();
			this.iFaltaRedeTxt = new NxtControl.GuiFramework.FreeText();
			this.rForaAuto = new NxtControl.GuiFramework.FreeText();
			this.nForaAuto = new NxtControl.GuiFramework.FreeText();
			this.iForaAutoP1 = new NxtControl.GuiFramework.Rectangle();
			this.iForaAutoP1n = new NxtControl.GuiFramework.FreeText();
			this.iForaAutoP2 = new NxtControl.GuiFramework.Polygon();
			this.iForaAutoP2n = new NxtControl.GuiFramework.FreeText();
			this.iForaAutoTxt = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.tituloCmd = new NxtControl.GuiFramework.FreeText();
			this.btnAuto = new NxtControl.GuiFramework.DrawnButton();
			this.btnSemi = new NxtControl.GuiFramework.DrawnButton();
			this.btnPartir = new NxtControl.GuiFramework.DrawnButton();
			this.btnParar = new NxtControl.GuiFramework.DrawnButton();
			this.btnRecAGC = new NxtControl.GuiFramework.DrawnButton();
			this.tCmdInfo = new NxtControl.GuiFramework.FreeText();
			this.confFundo = new NxtControl.GuiFramework.Rectangle();
			this.confTexto = new NxtControl.GuiFramework.FreeText();
			this.btnConfirmar = new NxtControl.GuiFramework.DrawnButton();
			this.btnCancelar = new NxtControl.GuiFramework.DrawnButton();
			this.xACom = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAAGC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAPartida = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAMotor = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAEmergencia = new System.HMI.Symbols.Base.Execute<bool>();
			this.xADisjuntor = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAFaltaRede = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAForaAuto = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECom = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEAGC = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPartida = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMotor = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEEmergencia = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEDisjuntor = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFaltaRede = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEForaAuto = new System.HMI.Symbols.Base.Execute<byte>();
			this.xSGB = new System.HMI.Symbols.Base.Execute<short>();
			this.xSMB = new System.HMI.Symbols.Base.Execute<short>();
			this.xSModo = new System.HMI.Symbols.Base.Execute<short>();
			this.xSFonte = new System.HMI.Symbols.Base.Execute<short>();
			this.xOperando = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPAuto = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPSemi = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPPartir = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPParar = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPRec = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCmdAtivo = new System.HMI.Symbols.Base.Execute<bool>();
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
			this.textoEstado.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "Parado";
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
			// rtGB
			// 
			this.rtGB.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rtGB.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rtGB.Location = new NxtControl.Drawing.PointF(22D, 72D);
			this.rtGB.Name = "rtGB";
			this.rtGB.Text = "Disjuntor do gerador";
			// 
			// tGB
			// 
			this.tGB.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tGB.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tGB.Location = new NxtControl.Drawing.PointF(182D, 72D);
			this.tGB.Name = "tGB";
			this.tGB.Text = "—";
			// 
			// rtMB
			// 
			this.rtMB.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rtMB.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rtMB.Location = new NxtControl.Drawing.PointF(312D, 72D);
			this.rtMB.Name = "rtMB";
			this.rtMB.Text = "Disjuntor de rede";
			// 
			// tMB
			// 
			this.tMB.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tMB.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tMB.Location = new NxtControl.Drawing.PointF(472D, 72D);
			this.tMB.Name = "tMB";
			this.tMB.Text = "—";
			// 
			// rtModo
			// 
			this.rtModo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rtModo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rtModo.Location = new NxtControl.Drawing.PointF(22D, 98D);
			this.rtModo.Name = "rtModo";
			this.rtModo.Text = "Modo do AGC";
			// 
			// tModo
			// 
			this.tModo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tModo.Location = new NxtControl.Drawing.PointF(182D, 98D);
			this.tModo.Name = "tModo";
			this.tModo.Text = "—";
			// 
			// rtFonte
			// 
			this.rtFonte.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rtFonte.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rtFonte.Location = new NxtControl.Drawing.PointF(312D, 98D);
			this.rtFonte.Name = "rtFonte";
			this.rtFonte.Text = "Fonte da saída do QTA";
			// 
			// tFonte
			// 
			this.tFonte.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tFonte.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tFonte.Location = new NxtControl.Drawing.PointF(472D, 98D);
			this.tFonte.Name = "tFonte";
			this.tFonte.Text = "—";
			// 
			// lin0
			// 
			this.lin0.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(127D)), ((float)(576D)), ((float)(26D)));
			this.lin0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin0.Name = "lin0";
			this.lin0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot0
			// 
			this.rot0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot0.Location = new NxtControl.Drawing.PointF(22D, 131D);
			this.rot0.Name = "rot0";
			this.rot0.Text = "Tensão A-B / B-C / C-A";
			// 
			// v0_0
			// 
			this.v0_0.BeginInit();
			this.v0_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v0_0.DecimalPlacesCount = ((uint)(0u));
			this.v0_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 128D);
			this.v0_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v0_0.FontScale = false;
			this.v0_0.IsOnlyInput = true;
			this.v0_0.IsPrefixSuffixOutside = false;
			this.v0_0.LeadingZeros = ((uint)(0u));
			this.v0_0.Name = "v0_0";
			this.v0_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v0_0.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.v0_0.Suffix = " V";
			this.v0_0.TagName = "TENSAO_AB";
			this.v0_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v0_0.EndInit();
			// 
			// v0_1
			// 
			this.v0_1.BeginInit();
			this.v0_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v0_1.DecimalPlacesCount = ((uint)(0u));
			this.v0_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 128D);
			this.v0_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v0_1.FontScale = false;
			this.v0_1.IsOnlyInput = true;
			this.v0_1.IsPrefixSuffixOutside = false;
			this.v0_1.LeadingZeros = ((uint)(0u));
			this.v0_1.Name = "v0_1";
			this.v0_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v0_1.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.v0_1.Suffix = " V";
			this.v0_1.TagName = "TENSAO_BC";
			this.v0_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v0_1.EndInit();
			// 
			// v0_2
			// 
			this.v0_2.BeginInit();
			this.v0_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v0_2.DecimalPlacesCount = ((uint)(0u));
			this.v0_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 482D, 128D);
			this.v0_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v0_2.FontScale = false;
			this.v0_2.IsOnlyInput = true;
			this.v0_2.IsPrefixSuffixOutside = false;
			this.v0_2.LeadingZeros = ((uint)(0u));
			this.v0_2.Name = "v0_2";
			this.v0_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v0_2.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.v0_2.Suffix = " V";
			this.v0_2.TagName = "TENSAO_CA";
			this.v0_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v0_2.EndInit();
			// 
			// lin1
			// 
			this.lin1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(157D)), ((float)(576D)), ((float)(26D)));
			this.lin1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin1.Name = "lin1";
			this.lin1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot1
			// 
			this.rot1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot1.Location = new NxtControl.Drawing.PointF(22D, 161D);
			this.rot1.Name = "rot1";
			this.rot1.Text = "Tensão A-N / B-N / C-N";
			// 
			// v1_0
			// 
			this.v1_0.BeginInit();
			this.v1_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v1_0.DecimalPlacesCount = ((uint)(0u));
			this.v1_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 158D);
			this.v1_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v1_0.FontScale = false;
			this.v1_0.IsOnlyInput = true;
			this.v1_0.IsPrefixSuffixOutside = false;
			this.v1_0.LeadingZeros = ((uint)(0u));
			this.v1_0.Name = "v1_0";
			this.v1_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v1_0.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.v1_0.Suffix = " V";
			this.v1_0.TagName = "TENSAO_AN";
			this.v1_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v1_0.EndInit();
			// 
			// v1_1
			// 
			this.v1_1.BeginInit();
			this.v1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v1_1.DecimalPlacesCount = ((uint)(0u));
			this.v1_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 158D);
			this.v1_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v1_1.FontScale = false;
			this.v1_1.IsOnlyInput = true;
			this.v1_1.IsPrefixSuffixOutside = false;
			this.v1_1.LeadingZeros = ((uint)(0u));
			this.v1_1.Name = "v1_1";
			this.v1_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v1_1.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.v1_1.Suffix = " V";
			this.v1_1.TagName = "TENSAO_BN";
			this.v1_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v1_1.EndInit();
			// 
			// v1_2
			// 
			this.v1_2.BeginInit();
			this.v1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v1_2.DecimalPlacesCount = ((uint)(0u));
			this.v1_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 482D, 158D);
			this.v1_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v1_2.FontScale = false;
			this.v1_2.IsOnlyInput = true;
			this.v1_2.IsPrefixSuffixOutside = false;
			this.v1_2.LeadingZeros = ((uint)(0u));
			this.v1_2.Name = "v1_2";
			this.v1_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary6.Add("Text", "${Value}");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary6.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary6.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v1_2.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.v1_2.Suffix = " V";
			this.v1_2.TagName = "TENSAO_CN";
			this.v1_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v1_2.EndInit();
			// 
			// lin2
			// 
			this.lin2.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(187D)), ((float)(576D)), ((float)(26D)));
			this.lin2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin2.Name = "lin2";
			this.lin2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot2
			// 
			this.rot2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot2.Location = new NxtControl.Drawing.PointF(22D, 191D);
			this.rot2.Name = "rot2";
			this.rot2.Text = "Corrente A / B / C";
			// 
			// v2_0
			// 
			this.v2_0.BeginInit();
			this.v2_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v2_0.DecimalPlacesCount = ((uint)(0u));
			this.v2_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 188D);
			this.v2_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v2_0.FontScale = false;
			this.v2_0.IsOnlyInput = true;
			this.v2_0.IsPrefixSuffixOutside = false;
			this.v2_0.LeadingZeros = ((uint)(0u));
			this.v2_0.Name = "v2_0";
			this.v2_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v2_0.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.v2_0.Suffix = " A";
			this.v2_0.TagName = "CORRENTE_A";
			this.v2_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v2_0.EndInit();
			// 
			// v2_1
			// 
			this.v2_1.BeginInit();
			this.v2_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v2_1.DecimalPlacesCount = ((uint)(0u));
			this.v2_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 188D);
			this.v2_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v2_1.FontScale = false;
			this.v2_1.IsOnlyInput = true;
			this.v2_1.IsPrefixSuffixOutside = false;
			this.v2_1.LeadingZeros = ((uint)(0u));
			this.v2_1.Name = "v2_1";
			this.v2_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary8.Add("Text", "${Value}");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary8.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary8.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v2_1.Ranges.DefaultPropertyValues = propertyDictionary8;
			this.v2_1.Suffix = " A";
			this.v2_1.TagName = "CORRENTE_B";
			this.v2_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v2_1.EndInit();
			// 
			// v2_2
			// 
			this.v2_2.BeginInit();
			this.v2_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v2_2.DecimalPlacesCount = ((uint)(0u));
			this.v2_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 482D, 188D);
			this.v2_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v2_2.FontScale = false;
			this.v2_2.IsOnlyInput = true;
			this.v2_2.IsPrefixSuffixOutside = false;
			this.v2_2.LeadingZeros = ((uint)(0u));
			this.v2_2.Name = "v2_2";
			this.v2_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary9.Add("Text", "${Value}");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary9.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary9.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v2_2.Ranges.DefaultPropertyValues = propertyDictionary9;
			this.v2_2.Suffix = " A";
			this.v2_2.TagName = "CORRENTE_C";
			this.v2_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v2_2.EndInit();
			// 
			// lin3
			// 
			this.lin3.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(217D)), ((float)(576D)), ((float)(26D)));
			this.lin3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin3.Name = "lin3";
			this.lin3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot3
			// 
			this.rot3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot3.Location = new NxtControl.Drawing.PointF(22D, 221D);
			this.rot3.Name = "rot3";
			this.rot3.Text = "Potência ativa / reativa / aparente";
			// 
			// v3_0
			// 
			this.v3_0.BeginInit();
			this.v3_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v3_0.DecimalPlacesCount = ((uint)(0u));
			this.v3_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 218D);
			this.v3_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v3_0.FontScale = false;
			this.v3_0.IsOnlyInput = true;
			this.v3_0.IsPrefixSuffixOutside = false;
			this.v3_0.LeadingZeros = ((uint)(0u));
			this.v3_0.Name = "v3_0";
			this.v3_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary10.Add("Text", "${Value}");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary10.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary10.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v3_0.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.v3_0.Suffix = " kW";
			this.v3_0.TagName = "POTENCIA_ATIVA";
			this.v3_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v3_0.EndInit();
			// 
			// v3_1
			// 
			this.v3_1.BeginInit();
			this.v3_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v3_1.DecimalPlacesCount = ((uint)(0u));
			this.v3_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 218D);
			this.v3_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v3_1.FontScale = false;
			this.v3_1.IsOnlyInput = true;
			this.v3_1.IsPrefixSuffixOutside = false;
			this.v3_1.LeadingZeros = ((uint)(0u));
			this.v3_1.Name = "v3_1";
			this.v3_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary11.Add("Text", "${Value}");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary11.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary11.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v3_1.Ranges.DefaultPropertyValues = propertyDictionary11;
			this.v3_1.Suffix = " kVAr";
			this.v3_1.TagName = "POTENCIA_REATIVA";
			this.v3_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v3_1.EndInit();
			// 
			// v3_2
			// 
			this.v3_2.BeginInit();
			this.v3_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v3_2.DecimalPlacesCount = ((uint)(0u));
			this.v3_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 482D, 218D);
			this.v3_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v3_2.FontScale = false;
			this.v3_2.IsOnlyInput = true;
			this.v3_2.IsPrefixSuffixOutside = false;
			this.v3_2.LeadingZeros = ((uint)(0u));
			this.v3_2.Name = "v3_2";
			this.v3_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary12.Add("Text", "${Value}");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary12.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary12.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v3_2.Ranges.DefaultPropertyValues = propertyDictionary12;
			this.v3_2.Suffix = " kVA";
			this.v3_2.TagName = "POTENCIA_APARENTE";
			this.v3_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v3_2.EndInit();
			// 
			// lin4
			// 
			this.lin4.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(247D)), ((float)(576D)), ((float)(26D)));
			this.lin4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin4.Name = "lin4";
			this.lin4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot4
			// 
			this.rot4.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot4.Location = new NxtControl.Drawing.PointF(22D, 251D);
			this.rot4.Name = "rot4";
			this.rot4.Text = "Fator de potência / frequência";
			// 
			// v4_0
			// 
			this.v4_0.BeginInit();
			this.v4_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v4_0.DecimalPlacesCount = ((uint)(2u));
			this.v4_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 248D);
			this.v4_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v4_0.FontScale = false;
			this.v4_0.IsOnlyInput = true;
			this.v4_0.IsPrefixSuffixOutside = false;
			this.v4_0.LeadingZeros = ((uint)(0u));
			this.v4_0.Name = "v4_0";
			this.v4_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary13.Add("Text", "${Value}");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary13.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary13.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v4_0.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.v4_0.Suffix = "";
			this.v4_0.TagName = "FATOR_POTENCIA";
			this.v4_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v4_0.EndInit();
			// 
			// v4_1
			// 
			this.v4_1.BeginInit();
			this.v4_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v4_1.DecimalPlacesCount = ((uint)(2u));
			this.v4_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 248D);
			this.v4_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v4_1.FontScale = false;
			this.v4_1.IsOnlyInput = true;
			this.v4_1.IsPrefixSuffixOutside = false;
			this.v4_1.LeadingZeros = ((uint)(0u));
			this.v4_1.Name = "v4_1";
			this.v4_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary14.Add("Text", "${Value}");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary14.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary14.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v4_1.Ranges.DefaultPropertyValues = propertyDictionary14;
			this.v4_1.Suffix = " Hz";
			this.v4_1.TagName = "FREQUENCIA";
			this.v4_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v4_1.EndInit();
			// 
			// lin5
			// 
			this.lin5.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(277D)), ((float)(576D)), ((float)(26D)));
			this.lin5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin5.Name = "lin5";
			this.lin5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot5
			// 
			this.rot5.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot5.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot5.Location = new NxtControl.Drawing.PointF(22D, 281D);
			this.rot5.Name = "rot5";
			this.rot5.Text = "Tensão do barramento (lado B)";
			// 
			// v5_0
			// 
			this.v5_0.BeginInit();
			this.v5_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v5_0.DecimalPlacesCount = ((uint)(0u));
			this.v5_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 278D);
			this.v5_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v5_0.FontScale = false;
			this.v5_0.IsOnlyInput = true;
			this.v5_0.IsPrefixSuffixOutside = false;
			this.v5_0.LeadingZeros = ((uint)(0u));
			this.v5_0.Name = "v5_0";
			this.v5_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary15.Add("Text", "${Value}");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary15.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary15.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v5_0.Ranges.DefaultPropertyValues = propertyDictionary15;
			this.v5_0.Suffix = " V";
			this.v5_0.TagName = "TENSAO_BARRA";
			this.v5_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v5_0.EndInit();
			// 
			// lin6
			// 
			this.lin6.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(307D)), ((float)(576D)), ((float)(26D)));
			this.lin6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin6.Name = "lin6";
			this.lin6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot6
			// 
			this.rot6.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot6.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot6.Location = new NxtControl.Drawing.PointF(22D, 311D);
			this.rot6.Name = "rot6";
			this.rot6.Text = "Rotação / bateria";
			// 
			// v6_0
			// 
			this.v6_0.BeginInit();
			this.v6_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v6_0.DecimalPlacesCount = ((uint)(0u));
			this.v6_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 308D);
			this.v6_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v6_0.FontScale = false;
			this.v6_0.IsOnlyInput = true;
			this.v6_0.IsPrefixSuffixOutside = false;
			this.v6_0.LeadingZeros = ((uint)(0u));
			this.v6_0.Name = "v6_0";
			this.v6_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary16.Add("Text", "${Value}");
			propertyDictionary16.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary16.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary16.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v6_0.Ranges.DefaultPropertyValues = propertyDictionary16;
			this.v6_0.Suffix = " rpm";
			this.v6_0.TagName = "ROTACAO";
			this.v6_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v6_0.EndInit();
			// 
			// v6_1
			// 
			this.v6_1.BeginInit();
			this.v6_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v6_1.DecimalPlacesCount = ((uint)(1u));
			this.v6_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 308D);
			this.v6_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v6_1.FontScale = false;
			this.v6_1.IsOnlyInput = true;
			this.v6_1.IsPrefixSuffixOutside = false;
			this.v6_1.LeadingZeros = ((uint)(0u));
			this.v6_1.Name = "v6_1";
			this.v6_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary17.Add("Text", "${Value}");
			propertyDictionary17.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary17.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary17.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v6_1.Ranges.DefaultPropertyValues = propertyDictionary17;
			this.v6_1.Suffix = " V";
			this.v6_1.TagName = "TENSAO_BATERIA";
			this.v6_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v6_1.EndInit();
			// 
			// lin7
			// 
			this.lin7.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(337D)), ((float)(576D)), ((float)(26D)));
			this.lin7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin7.Name = "lin7";
			this.lin7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot7
			// 
			this.rot7.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot7.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot7.Location = new NxtControl.Drawing.PointF(22D, 341D);
			this.rot7.Name = "rot7";
			this.rot7.Text = "Temp. água / temp. óleo / pressão óleo";
			// 
			// v7_0
			// 
			this.v7_0.BeginInit();
			this.v7_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v7_0.DecimalPlacesCount = ((uint)(1u));
			this.v7_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 338D);
			this.v7_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v7_0.FontScale = false;
			this.v7_0.IsOnlyInput = true;
			this.v7_0.IsPrefixSuffixOutside = false;
			this.v7_0.LeadingZeros = ((uint)(0u));
			this.v7_0.Name = "v7_0";
			this.v7_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary18.Add("Text", "${Value}");
			propertyDictionary18.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary18.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary18.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v7_0.Ranges.DefaultPropertyValues = propertyDictionary18;
			this.v7_0.Suffix = " °C";
			this.v7_0.TagName = "TEMP_ARREFECIMENTO";
			this.v7_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v7_0.EndInit();
			// 
			// v7_1
			// 
			this.v7_1.BeginInit();
			this.v7_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v7_1.DecimalPlacesCount = ((uint)(1u));
			this.v7_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 338D);
			this.v7_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v7_1.FontScale = false;
			this.v7_1.IsOnlyInput = true;
			this.v7_1.IsPrefixSuffixOutside = false;
			this.v7_1.LeadingZeros = ((uint)(0u));
			this.v7_1.Name = "v7_1";
			this.v7_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary19.Add("Text", "${Value}");
			propertyDictionary19.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary19.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary19.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v7_1.Ranges.DefaultPropertyValues = propertyDictionary19;
			this.v7_1.Suffix = " °C";
			this.v7_1.TagName = "TEMP_OLEO";
			this.v7_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v7_1.EndInit();
			// 
			// v7_2
			// 
			this.v7_2.BeginInit();
			this.v7_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v7_2.DecimalPlacesCount = ((uint)(2u));
			this.v7_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 482D, 338D);
			this.v7_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v7_2.FontScale = false;
			this.v7_2.IsOnlyInput = true;
			this.v7_2.IsPrefixSuffixOutside = false;
			this.v7_2.LeadingZeros = ((uint)(0u));
			this.v7_2.Name = "v7_2";
			this.v7_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary20.Add("Text", "${Value}");
			propertyDictionary20.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary20.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary20.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v7_2.Ranges.DefaultPropertyValues = propertyDictionary20;
			this.v7_2.Suffix = " bar";
			this.v7_2.TagName = "PRESSAO_OLEO";
			this.v7_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v7_2.EndInit();
			// 
			// lin8
			// 
			this.lin8.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(367D)), ((float)(576D)), ((float)(26D)));
			this.lin8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin8.Name = "lin8";
			this.lin8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot8
			// 
			this.rot8.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot8.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot8.Location = new NxtControl.Drawing.PointF(22D, 371D);
			this.rot8.Name = "rot8";
			this.rot8.Text = "Horas de operação / energia";
			// 
			// v8_0
			// 
			this.v8_0.BeginInit();
			this.v8_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v8_0.DecimalPlacesCount = ((uint)(0u));
			this.v8_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 368D);
			this.v8_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v8_0.FontScale = false;
			this.v8_0.IsOnlyInput = true;
			this.v8_0.IsPrefixSuffixOutside = false;
			this.v8_0.LeadingZeros = ((uint)(0u));
			this.v8_0.Name = "v8_0";
			this.v8_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary21.Add("Text", "${Value}");
			propertyDictionary21.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary21.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary21.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v8_0.Ranges.DefaultPropertyValues = propertyDictionary21;
			this.v8_0.Suffix = " h";
			this.v8_0.TagName = "HORAS_OPERACAO";
			this.v8_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v8_0.EndInit();
			// 
			// v8_1
			// 
			this.v8_1.BeginInit();
			this.v8_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v8_1.DecimalPlacesCount = ((uint)(0u));
			this.v8_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 368D);
			this.v8_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v8_1.FontScale = false;
			this.v8_1.IsOnlyInput = true;
			this.v8_1.IsPrefixSuffixOutside = false;
			this.v8_1.LeadingZeros = ((uint)(0u));
			this.v8_1.Name = "v8_1";
			this.v8_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary22.Add("Text", "${Value}");
			propertyDictionary22.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary22.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary22.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v8_1.Ranges.DefaultPropertyValues = propertyDictionary22;
			this.v8_1.Suffix = " kWh";
			this.v8_1.TagName = "ENERGIA_ATIVA";
			this.v8_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v8_1.EndInit();
			// 
			// lin9
			// 
			this.lin9.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(397D)), ((float)(576D)), ((float)(26D)));
			this.lin9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin9.Name = "lin9";
			this.lin9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot9
			// 
			this.rot9.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot9.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot9.Location = new NxtControl.Drawing.PointF(22D, 401D);
			this.rot9.Name = "rot9";
			this.rot9.Text = "Alarmes no AGC (ativos / não rec.)";
			// 
			// v9_0
			// 
			this.v9_0.BeginInit();
			this.v9_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v9_0.DecimalPlacesCount = ((uint)(0u));
			this.v9_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 262D, 398D);
			this.v9_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v9_0.FontScale = false;
			this.v9_0.IsOnlyInput = true;
			this.v9_0.IsPrefixSuffixOutside = false;
			this.v9_0.LeadingZeros = ((uint)(0u));
			this.v9_0.Name = "v9_0";
			this.v9_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary23.Add("Text", "${Value}");
			propertyDictionary23.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary23.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary23.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v9_0.Ranges.DefaultPropertyValues = propertyDictionary23;
			this.v9_0.Suffix = "";
			this.v9_0.TagName = "NUM_ALARMES_AGC";
			this.v9_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v9_0.EndInit();
			// 
			// v9_1
			// 
			this.v9_1.BeginInit();
			this.v9_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v9_1.DecimalPlacesCount = ((uint)(0u));
			this.v9_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 0.95D, 372D, 398D);
			this.v9_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v9_1.FontScale = false;
			this.v9_1.IsOnlyInput = true;
			this.v9_1.IsPrefixSuffixOutside = false;
			this.v9_1.LeadingZeros = ((uint)(0u));
			this.v9_1.Name = "v9_1";
			this.v9_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary24.Add("Text", "${Value}");
			propertyDictionary24.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary24.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary24.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v9_1.Ranges.DefaultPropertyValues = propertyDictionary24;
			this.v9_1.Suffix = "";
			this.v9_1.TagName = "NUM_ALARMES_NAO_REC_AGC";
			this.v9_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v9_1.EndInit();
			// 
			// tituloAlm
			// 
			this.tituloAlm.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloAlm.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloAlm.Location = new NxtControl.Drawing.PointF(20D, 436D);
			this.tituloAlm.Name = "tituloAlm";
			this.tituloAlm.Text = "Alarmes";
			// 
			// rCom
			// 
			this.rCom.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rCom.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rCom.Location = new NxtControl.Drawing.PointF(22D, 460D);
			this.rCom.Name = "rCom";
			this.rCom.Text = "Falha de comunicação";
			// 
			// nCom
			// 
			this.nCom.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nCom.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nCom.Location = new NxtControl.Drawing.PointF(208D, 460D);
			this.nCom.Name = "nCom";
			this.nCom.Text = "—";
			// 
			// iComP1
			// 
			this.iComP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(460D)), ((float)(16D)), ((float)(16D)));
			this.iComP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iComP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iComP1.Name = "iComP1";
			this.iComP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iComP1.Visible = false;
			// 
			// iComP1n
			// 
			this.iComP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iComP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iComP1n.Location = new NxtControl.Drawing.PointF(208D, 461D);
			this.iComP1n.Name = "iComP1n";
			this.iComP1n.Text = "1";
			this.iComP1n.Visible = false;
			// 
			// iComP2
			// 
			this.iComP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(460D)), ((float)(16D)), ((float)(16D)));
			this.iComP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iComP2.Closed = true;
			this.iComP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iComP2.Name = "iComP2";
			this.iComP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iComP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 476D),
			new NxtControl.Drawing.PointF(212D, 460D),
			new NxtControl.Drawing.PointF(220D, 476D)});
			this.iComP2.Visible = false;
			// 
			// iComP2n
			// 
			this.iComP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iComP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iComP2n.Location = new NxtControl.Drawing.PointF(209D, 464D);
			this.iComP2n.Name = "iComP2n";
			this.iComP2n.Text = "2";
			this.iComP2n.Visible = false;
			// 
			// iComTxt
			// 
			this.iComTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iComTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iComTxt.Location = new NxtControl.Drawing.PointF(224D, 460D);
			this.iComTxt.Name = "iComTxt";
			this.iComTxt.Text = "";
			this.iComTxt.Visible = false;
			// 
			// rAGC
			// 
			this.rAGC.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rAGC.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rAGC.Location = new NxtControl.Drawing.PointF(22D, 486D);
			this.rAGC.Name = "rAGC";
			this.rAGC.Text = "Alarme no AGC";
			// 
			// nAGC
			// 
			this.nAGC.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nAGC.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nAGC.Location = new NxtControl.Drawing.PointF(208D, 486D);
			this.nAGC.Name = "nAGC";
			this.nAGC.Text = "—";
			// 
			// iAGCP1
			// 
			this.iAGCP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(486D)), ((float)(16D)), ((float)(16D)));
			this.iAGCP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iAGCP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iAGCP1.Name = "iAGCP1";
			this.iAGCP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iAGCP1.Visible = false;
			// 
			// iAGCP1n
			// 
			this.iAGCP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iAGCP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iAGCP1n.Location = new NxtControl.Drawing.PointF(208D, 487D);
			this.iAGCP1n.Name = "iAGCP1n";
			this.iAGCP1n.Text = "1";
			this.iAGCP1n.Visible = false;
			// 
			// iAGCP2
			// 
			this.iAGCP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(486D)), ((float)(16D)), ((float)(16D)));
			this.iAGCP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iAGCP2.Closed = true;
			this.iAGCP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iAGCP2.Name = "iAGCP2";
			this.iAGCP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iAGCP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 502D),
			new NxtControl.Drawing.PointF(212D, 486D),
			new NxtControl.Drawing.PointF(220D, 502D)});
			this.iAGCP2.Visible = false;
			// 
			// iAGCP2n
			// 
			this.iAGCP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iAGCP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iAGCP2n.Location = new NxtControl.Drawing.PointF(209D, 490D);
			this.iAGCP2n.Name = "iAGCP2n";
			this.iAGCP2n.Text = "2";
			this.iAGCP2n.Visible = false;
			// 
			// iAGCTxt
			// 
			this.iAGCTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iAGCTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iAGCTxt.Location = new NxtControl.Drawing.PointF(224D, 486D);
			this.iAGCTxt.Name = "iAGCTxt";
			this.iAGCTxt.Text = "";
			this.iAGCTxt.Visible = false;
			// 
			// rPartida
			// 
			this.rPartida.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rPartida.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rPartida.Location = new NxtControl.Drawing.PointF(22D, 512D);
			this.rPartida.Name = "rPartida";
			this.rPartida.Text = "Falha na partida";
			// 
			// nPartida
			// 
			this.nPartida.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nPartida.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nPartida.Location = new NxtControl.Drawing.PointF(208D, 512D);
			this.nPartida.Name = "nPartida";
			this.nPartida.Text = "—";
			// 
			// iPartidaP1
			// 
			this.iPartidaP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(512D)), ((float)(16D)), ((float)(16D)));
			this.iPartidaP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iPartidaP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iPartidaP1.Name = "iPartidaP1";
			this.iPartidaP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iPartidaP1.Visible = false;
			// 
			// iPartidaP1n
			// 
			this.iPartidaP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iPartidaP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iPartidaP1n.Location = new NxtControl.Drawing.PointF(208D, 513D);
			this.iPartidaP1n.Name = "iPartidaP1n";
			this.iPartidaP1n.Text = "1";
			this.iPartidaP1n.Visible = false;
			// 
			// iPartidaP2
			// 
			this.iPartidaP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(512D)), ((float)(16D)), ((float)(16D)));
			this.iPartidaP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iPartidaP2.Closed = true;
			this.iPartidaP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iPartidaP2.Name = "iPartidaP2";
			this.iPartidaP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iPartidaP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 528D),
			new NxtControl.Drawing.PointF(212D, 512D),
			new NxtControl.Drawing.PointF(220D, 528D)});
			this.iPartidaP2.Visible = false;
			// 
			// iPartidaP2n
			// 
			this.iPartidaP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iPartidaP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iPartidaP2n.Location = new NxtControl.Drawing.PointF(209D, 516D);
			this.iPartidaP2n.Name = "iPartidaP2n";
			this.iPartidaP2n.Text = "2";
			this.iPartidaP2n.Visible = false;
			// 
			// iPartidaTxt
			// 
			this.iPartidaTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iPartidaTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iPartidaTxt.Location = new NxtControl.Drawing.PointF(224D, 512D);
			this.iPartidaTxt.Name = "iPartidaTxt";
			this.iPartidaTxt.Text = "";
			this.iPartidaTxt.Visible = false;
			// 
			// rMotor
			// 
			this.rMotor.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rMotor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rMotor.Location = new NxtControl.Drawing.PointF(22D, 538D);
			this.rMotor.Name = "rMotor";
			this.rMotor.Text = "Desligamento do motor";
			// 
			// nMotor
			// 
			this.nMotor.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nMotor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nMotor.Location = new NxtControl.Drawing.PointF(208D, 538D);
			this.nMotor.Name = "nMotor";
			this.nMotor.Text = "—";
			// 
			// iMotorP1
			// 
			this.iMotorP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.iMotorP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iMotorP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iMotorP1.Name = "iMotorP1";
			this.iMotorP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iMotorP1.Visible = false;
			// 
			// iMotorP1n
			// 
			this.iMotorP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iMotorP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iMotorP1n.Location = new NxtControl.Drawing.PointF(208D, 539D);
			this.iMotorP1n.Name = "iMotorP1n";
			this.iMotorP1n.Text = "1";
			this.iMotorP1n.Visible = false;
			// 
			// iMotorP2
			// 
			this.iMotorP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.iMotorP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iMotorP2.Closed = true;
			this.iMotorP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iMotorP2.Name = "iMotorP2";
			this.iMotorP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iMotorP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 554D),
			new NxtControl.Drawing.PointF(212D, 538D),
			new NxtControl.Drawing.PointF(220D, 554D)});
			this.iMotorP2.Visible = false;
			// 
			// iMotorP2n
			// 
			this.iMotorP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iMotorP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iMotorP2n.Location = new NxtControl.Drawing.PointF(209D, 542D);
			this.iMotorP2n.Name = "iMotorP2n";
			this.iMotorP2n.Text = "2";
			this.iMotorP2n.Visible = false;
			// 
			// iMotorTxt
			// 
			this.iMotorTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iMotorTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iMotorTxt.Location = new NxtControl.Drawing.PointF(224D, 538D);
			this.iMotorTxt.Name = "iMotorTxt";
			this.iMotorTxt.Text = "";
			this.iMotorTxt.Visible = false;
			// 
			// rEmergencia
			// 
			this.rEmergencia.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rEmergencia.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rEmergencia.Location = new NxtControl.Drawing.PointF(312D, 460D);
			this.rEmergencia.Name = "rEmergencia";
			this.rEmergencia.Text = "Parada de emergência";
			// 
			// nEmergencia
			// 
			this.nEmergencia.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nEmergencia.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nEmergencia.Location = new NxtControl.Drawing.PointF(498D, 460D);
			this.nEmergencia.Name = "nEmergencia";
			this.nEmergencia.Text = "—";
			// 
			// iEmergenciaP1
			// 
			this.iEmergenciaP1.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(460D)), ((float)(16D)), ((float)(16D)));
			this.iEmergenciaP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iEmergenciaP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iEmergenciaP1.Name = "iEmergenciaP1";
			this.iEmergenciaP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iEmergenciaP1.Visible = false;
			// 
			// iEmergenciaP1n
			// 
			this.iEmergenciaP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iEmergenciaP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iEmergenciaP1n.Location = new NxtControl.Drawing.PointF(498D, 461D);
			this.iEmergenciaP1n.Name = "iEmergenciaP1n";
			this.iEmergenciaP1n.Text = "1";
			this.iEmergenciaP1n.Visible = false;
			// 
			// iEmergenciaP2
			// 
			this.iEmergenciaP2.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(460D)), ((float)(16D)), ((float)(16D)));
			this.iEmergenciaP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iEmergenciaP2.Closed = true;
			this.iEmergenciaP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iEmergenciaP2.Name = "iEmergenciaP2";
			this.iEmergenciaP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iEmergenciaP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(494D, 476D),
			new NxtControl.Drawing.PointF(502D, 460D),
			new NxtControl.Drawing.PointF(510D, 476D)});
			this.iEmergenciaP2.Visible = false;
			// 
			// iEmergenciaP2n
			// 
			this.iEmergenciaP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iEmergenciaP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iEmergenciaP2n.Location = new NxtControl.Drawing.PointF(499D, 464D);
			this.iEmergenciaP2n.Name = "iEmergenciaP2n";
			this.iEmergenciaP2n.Text = "2";
			this.iEmergenciaP2n.Visible = false;
			// 
			// iEmergenciaTxt
			// 
			this.iEmergenciaTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iEmergenciaTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iEmergenciaTxt.Location = new NxtControl.Drawing.PointF(514D, 460D);
			this.iEmergenciaTxt.Name = "iEmergenciaTxt";
			this.iEmergenciaTxt.Text = "";
			this.iEmergenciaTxt.Visible = false;
			// 
			// rDisjuntor
			// 
			this.rDisjuntor.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rDisjuntor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDisjuntor.Location = new NxtControl.Drawing.PointF(312D, 486D);
			this.rDisjuntor.Name = "rDisjuntor";
			this.rDisjuntor.Text = "Falha de disjuntor";
			// 
			// nDisjuntor
			// 
			this.nDisjuntor.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nDisjuntor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nDisjuntor.Location = new NxtControl.Drawing.PointF(498D, 486D);
			this.nDisjuntor.Name = "nDisjuntor";
			this.nDisjuntor.Text = "—";
			// 
			// iDisjuntorP1
			// 
			this.iDisjuntorP1.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(486D)), ((float)(16D)), ((float)(16D)));
			this.iDisjuntorP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iDisjuntorP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDisjuntorP1.Name = "iDisjuntorP1";
			this.iDisjuntorP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDisjuntorP1.Visible = false;
			// 
			// iDisjuntorP1n
			// 
			this.iDisjuntorP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iDisjuntorP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDisjuntorP1n.Location = new NxtControl.Drawing.PointF(498D, 487D);
			this.iDisjuntorP1n.Name = "iDisjuntorP1n";
			this.iDisjuntorP1n.Text = "1";
			this.iDisjuntorP1n.Visible = false;
			// 
			// iDisjuntorP2
			// 
			this.iDisjuntorP2.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(486D)), ((float)(16D)), ((float)(16D)));
			this.iDisjuntorP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iDisjuntorP2.Closed = true;
			this.iDisjuntorP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iDisjuntorP2.Name = "iDisjuntorP2";
			this.iDisjuntorP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iDisjuntorP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(494D, 502D),
			new NxtControl.Drawing.PointF(502D, 486D),
			new NxtControl.Drawing.PointF(510D, 502D)});
			this.iDisjuntorP2.Visible = false;
			// 
			// iDisjuntorP2n
			// 
			this.iDisjuntorP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDisjuntorP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iDisjuntorP2n.Location = new NxtControl.Drawing.PointF(499D, 490D);
			this.iDisjuntorP2n.Name = "iDisjuntorP2n";
			this.iDisjuntorP2n.Text = "2";
			this.iDisjuntorP2n.Visible = false;
			// 
			// iDisjuntorTxt
			// 
			this.iDisjuntorTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iDisjuntorTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iDisjuntorTxt.Location = new NxtControl.Drawing.PointF(514D, 486D);
			this.iDisjuntorTxt.Name = "iDisjuntorTxt";
			this.iDisjuntorTxt.Text = "";
			this.iDisjuntorTxt.Visible = false;
			// 
			// rFaltaRede
			// 
			this.rFaltaRede.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rFaltaRede.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rFaltaRede.Location = new NxtControl.Drawing.PointF(312D, 512D);
			this.rFaltaRede.Name = "rFaltaRede";
			this.rFaltaRede.Text = "Falta de rede";
			// 
			// nFaltaRede
			// 
			this.nFaltaRede.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nFaltaRede.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nFaltaRede.Location = new NxtControl.Drawing.PointF(498D, 512D);
			this.nFaltaRede.Name = "nFaltaRede";
			this.nFaltaRede.Text = "—";
			// 
			// iFaltaRedeP1
			// 
			this.iFaltaRedeP1.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(512D)), ((float)(16D)), ((float)(16D)));
			this.iFaltaRedeP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iFaltaRedeP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFaltaRedeP1.Name = "iFaltaRedeP1";
			this.iFaltaRedeP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFaltaRedeP1.Visible = false;
			// 
			// iFaltaRedeP1n
			// 
			this.iFaltaRedeP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iFaltaRedeP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFaltaRedeP1n.Location = new NxtControl.Drawing.PointF(498D, 513D);
			this.iFaltaRedeP1n.Name = "iFaltaRedeP1n";
			this.iFaltaRedeP1n.Text = "1";
			this.iFaltaRedeP1n.Visible = false;
			// 
			// iFaltaRedeP2
			// 
			this.iFaltaRedeP2.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(512D)), ((float)(16D)), ((float)(16D)));
			this.iFaltaRedeP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iFaltaRedeP2.Closed = true;
			this.iFaltaRedeP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFaltaRedeP2.Name = "iFaltaRedeP2";
			this.iFaltaRedeP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFaltaRedeP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(494D, 528D),
			new NxtControl.Drawing.PointF(502D, 512D),
			new NxtControl.Drawing.PointF(510D, 528D)});
			this.iFaltaRedeP2.Visible = false;
			// 
			// iFaltaRedeP2n
			// 
			this.iFaltaRedeP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFaltaRedeP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iFaltaRedeP2n.Location = new NxtControl.Drawing.PointF(499D, 516D);
			this.iFaltaRedeP2n.Name = "iFaltaRedeP2n";
			this.iFaltaRedeP2n.Text = "2";
			this.iFaltaRedeP2n.Visible = false;
			// 
			// iFaltaRedeTxt
			// 
			this.iFaltaRedeTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFaltaRedeTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFaltaRedeTxt.Location = new NxtControl.Drawing.PointF(514D, 512D);
			this.iFaltaRedeTxt.Name = "iFaltaRedeTxt";
			this.iFaltaRedeTxt.Text = "";
			this.iFaltaRedeTxt.Visible = false;
			// 
			// rForaAuto
			// 
			this.rForaAuto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rForaAuto.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rForaAuto.Location = new NxtControl.Drawing.PointF(312D, 538D);
			this.rForaAuto.Name = "rForaAuto";
			this.rForaAuto.Text = "Fora do automático";
			// 
			// nForaAuto
			// 
			this.nForaAuto.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nForaAuto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nForaAuto.Location = new NxtControl.Drawing.PointF(498D, 538D);
			this.nForaAuto.Name = "nForaAuto";
			this.nForaAuto.Text = "—";
			// 
			// iForaAutoP1
			// 
			this.iForaAutoP1.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.iForaAutoP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iForaAutoP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iForaAutoP1.Name = "iForaAutoP1";
			this.iForaAutoP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iForaAutoP1.Visible = false;
			// 
			// iForaAutoP1n
			// 
			this.iForaAutoP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iForaAutoP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iForaAutoP1n.Location = new NxtControl.Drawing.PointF(498D, 539D);
			this.iForaAutoP1n.Name = "iForaAutoP1n";
			this.iForaAutoP1n.Text = "1";
			this.iForaAutoP1n.Visible = false;
			// 
			// iForaAutoP2
			// 
			this.iForaAutoP2.Bounds = new NxtControl.Drawing.RectF(((float)(494D)), ((float)(538D)), ((float)(16D)), ((float)(16D)));
			this.iForaAutoP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iForaAutoP2.Closed = true;
			this.iForaAutoP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iForaAutoP2.Name = "iForaAutoP2";
			this.iForaAutoP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iForaAutoP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(494D, 554D),
			new NxtControl.Drawing.PointF(502D, 538D),
			new NxtControl.Drawing.PointF(510D, 554D)});
			this.iForaAutoP2.Visible = false;
			// 
			// iForaAutoP2n
			// 
			this.iForaAutoP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iForaAutoP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iForaAutoP2n.Location = new NxtControl.Drawing.PointF(499D, 542D);
			this.iForaAutoP2n.Name = "iForaAutoP2n";
			this.iForaAutoP2n.Text = "2";
			this.iForaAutoP2n.Visible = false;
			// 
			// iForaAutoTxt
			// 
			this.iForaAutoTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iForaAutoTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iForaAutoTxt.Location = new NxtControl.Drawing.PointF(514D, 538D);
			this.iForaAutoTxt.Name = "iForaAutoTxt";
			this.iForaAutoTxt.Text = "";
			this.iForaAutoTxt.Visible = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(574D)), ((float)(200D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer";
			this.btnReset.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// tituloCmd
			// 
			this.tituloCmd.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloCmd.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloCmd.Location = new NxtControl.Drawing.PointF(20D, 622D);
			this.tituloCmd.Name = "tituloCmd";
			this.tituloCmd.Text = "Comandos do AGC";
			// 
			// btnAuto
			// 
			this.btnAuto.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(646D)), ((float)(104D)), ((float)(34D)));
			this.btnAuto.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAuto.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnAuto.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAuto.Radius = 2D;
			this.btnAuto.Text = "Automático";
			this.btnAuto.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAuto.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAuto.Use3DEffect = false;
			this.btnAuto.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// btnSemi
			// 
			this.btnSemi.Bounds = new NxtControl.Drawing.RectF(((float)(132D)), ((float)(646D)), ((float)(104D)), ((float)(34D)));
			this.btnSemi.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSemi.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSemi.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSemi.Name = "btnSemi";
			this.btnSemi.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSemi.Radius = 2D;
			this.btnSemi.Text = "Semiautomático";
			this.btnSemi.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnSemi.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnSemi.Use3DEffect = false;
			this.btnSemi.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// btnPartir
			// 
			this.btnPartir.Bounds = new NxtControl.Drawing.RectF(((float)(244D)), ((float)(646D)), ((float)(104D)), ((float)(34D)));
			this.btnPartir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnPartir.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnPartir.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnPartir.Name = "btnPartir";
			this.btnPartir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnPartir.Radius = 2D;
			this.btnPartir.Text = "Partir";
			this.btnPartir.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnPartir.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnPartir.Use3DEffect = false;
			this.btnPartir.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// btnParar
			// 
			this.btnParar.Bounds = new NxtControl.Drawing.RectF(((float)(356D)), ((float)(646D)), ((float)(104D)), ((float)(34D)));
			this.btnParar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnParar.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnParar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnParar.Name = "btnParar";
			this.btnParar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnParar.Radius = 2D;
			this.btnParar.Text = "Parar";
			this.btnParar.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnParar.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnParar.Use3DEffect = false;
			this.btnParar.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// btnRecAGC
			// 
			this.btnRecAGC.Bounds = new NxtControl.Drawing.RectF(((float)(468D)), ((float)(646D)), ((float)(104D)), ((float)(34D)));
			this.btnRecAGC.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnRecAGC.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnRecAGC.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnRecAGC.Name = "btnRecAGC";
			this.btnRecAGC.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnRecAGC.Radius = 2D;
			this.btnRecAGC.Text = "Reconhecer AGC";
			this.btnRecAGC.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnRecAGC.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnRecAGC.Use3DEffect = false;
			this.btnRecAGC.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// tCmdInfo
			// 
			this.tCmdInfo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tCmdInfo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tCmdInfo.Location = new NxtControl.Drawing.PointF(20D, 686D);
			this.tCmdInfo.Name = "tCmdInfo";
			this.tCmdInfo.Text = "Partir e parar só em semiautomático.";
			// 
			// confFundo
			// 
			this.confFundo.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(572D)), ((float)(560D)), ((float)(120D)));
			this.confFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.confFundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.confFundo.Name = "confFundo";
			this.confFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.confFundo.Visible = false;
			// 
			// confTexto
			// 
			this.confTexto.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.confTexto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.confTexto.Location = new NxtControl.Drawing.PointF(36D, 584D);
			this.confTexto.Name = "confTexto";
			this.confTexto.Text = "";
			this.confTexto.Visible = false;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Bounds = new NxtControl.Drawing.RectF(((float)(36D)), ((float)(642D)), ((float)(160D)), ((float)(36D)));
			this.btnConfirmar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnConfirmar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnConfirmar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnConfirmar.Radius = 2D;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnConfirmar.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnConfirmar.Use3DEffect = false;
			this.btnConfirmar.Visible = false;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Bounds = new NxtControl.Drawing.RectF(((float)(210D)), ((float)(642D)), ((float)(160D)), ((float)(36D)));
			this.btnCancelar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnCancelar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnCancelar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnCancelar.Radius = 2D;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnCancelar.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnCancelar.Use3DEffect = false;
			this.btnCancelar.Visible = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// xACom
			// 
			this.xACom.BeginInit();
			this.xACom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xACom.IsOnlyInput = true;
			this.xACom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xACom.Name = "xACom";
			this.xACom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xACom.TagName = "STS_FALHA_COMUNICACAO";
			this.xACom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AComValueChanged);
			this.xACom.EndInit();
			// 
			// xAAGC
			// 
			this.xAAGC.BeginInit();
			this.xAAGC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAAGC.IsOnlyInput = true;
			this.xAAGC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAAGC.Name = "xAAGC";
			this.xAAGC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAAGC.TagName = "STS_ALARME_AGC";
			this.xAAGC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AAGCValueChanged);
			this.xAAGC.EndInit();
			// 
			// xAPartida
			// 
			this.xAPartida.BeginInit();
			this.xAPartida.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAPartida.IsOnlyInput = true;
			this.xAPartida.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAPartida.Name = "xAPartida";
			this.xAPartida.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAPartida.TagName = "STS_ALARME_PARTIDA";
			this.xAPartida.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.APartidaValueChanged);
			this.xAPartida.EndInit();
			// 
			// xAMotor
			// 
			this.xAMotor.BeginInit();
			this.xAMotor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAMotor.IsOnlyInput = true;
			this.xAMotor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAMotor.Name = "xAMotor";
			this.xAMotor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAMotor.TagName = "STS_ALARME_MOTOR";
			this.xAMotor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AMotorValueChanged);
			this.xAMotor.EndInit();
			// 
			// xAEmergencia
			// 
			this.xAEmergencia.BeginInit();
			this.xAEmergencia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAEmergencia.IsOnlyInput = true;
			this.xAEmergencia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAEmergencia.Name = "xAEmergencia";
			this.xAEmergencia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAEmergencia.TagName = "STS_ALARME_EMERGENCIA";
			this.xAEmergencia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AEmergenciaValueChanged);
			this.xAEmergencia.EndInit();
			// 
			// xADisjuntor
			// 
			this.xADisjuntor.BeginInit();
			this.xADisjuntor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xADisjuntor.IsOnlyInput = true;
			this.xADisjuntor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xADisjuntor.Name = "xADisjuntor";
			this.xADisjuntor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xADisjuntor.TagName = "STS_ALARME_DISJUNTOR";
			this.xADisjuntor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ADisjuntorValueChanged);
			this.xADisjuntor.EndInit();
			// 
			// xAFaltaRede
			// 
			this.xAFaltaRede.BeginInit();
			this.xAFaltaRede.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAFaltaRede.IsOnlyInput = true;
			this.xAFaltaRede.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAFaltaRede.Name = "xAFaltaRede";
			this.xAFaltaRede.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAFaltaRede.TagName = "STS_ALARME_FALTA_REDE";
			this.xAFaltaRede.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AFaltaRedeValueChanged);
			this.xAFaltaRede.EndInit();
			// 
			// xAForaAuto
			// 
			this.xAForaAuto.BeginInit();
			this.xAForaAuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAForaAuto.IsOnlyInput = true;
			this.xAForaAuto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAForaAuto.Name = "xAForaAuto";
			this.xAForaAuto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAForaAuto.TagName = "STS_ALARME_FORA_AUTOMATICO";
			this.xAForaAuto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AForaAutoValueChanged);
			this.xAForaAuto.EndInit();
			// 
			// xECom
			// 
			this.xECom.BeginInit();
			this.xECom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECom.IsOnlyInput = true;
			this.xECom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECom.Name = "xECom";
			this.xECom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECom.TagName = "STS_ALM_COMUNICACAO_EST";
			this.xECom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EComValueChanged);
			this.xECom.EndInit();
			// 
			// xEAGC
			// 
			this.xEAGC.BeginInit();
			this.xEAGC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEAGC.IsOnlyInput = true;
			this.xEAGC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEAGC.Name = "xEAGC";
			this.xEAGC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEAGC.TagName = "STS_ALM_AGC_EST";
			this.xEAGC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EAGCValueChanged);
			this.xEAGC.EndInit();
			// 
			// xEPartida
			// 
			this.xEPartida.BeginInit();
			this.xEPartida.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPartida.IsOnlyInput = true;
			this.xEPartida.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPartida.Name = "xEPartida";
			this.xEPartida.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPartida.TagName = "STS_ALM_PARTIDA_EST";
			this.xEPartida.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EPartidaValueChanged);
			this.xEPartida.EndInit();
			// 
			// xEMotor
			// 
			this.xEMotor.BeginInit();
			this.xEMotor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMotor.IsOnlyInput = true;
			this.xEMotor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMotor.Name = "xEMotor";
			this.xEMotor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMotor.TagName = "STS_ALM_MOTOR_EST";
			this.xEMotor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EMotorValueChanged);
			this.xEMotor.EndInit();
			// 
			// xEEmergencia
			// 
			this.xEEmergencia.BeginInit();
			this.xEEmergencia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEmergencia.IsOnlyInput = true;
			this.xEEmergencia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEmergencia.Name = "xEEmergencia";
			this.xEEmergencia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEmergencia.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEmergencia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EEmergenciaValueChanged);
			this.xEEmergencia.EndInit();
			// 
			// xEDisjuntor
			// 
			this.xEDisjuntor.BeginInit();
			this.xEDisjuntor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEDisjuntor.IsOnlyInput = true;
			this.xEDisjuntor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEDisjuntor.Name = "xEDisjuntor";
			this.xEDisjuntor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEDisjuntor.TagName = "STS_ALM_DISJUNTOR_EST";
			this.xEDisjuntor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EDisjuntorValueChanged);
			this.xEDisjuntor.EndInit();
			// 
			// xEFaltaRede
			// 
			this.xEFaltaRede.BeginInit();
			this.xEFaltaRede.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFaltaRede.IsOnlyInput = true;
			this.xEFaltaRede.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFaltaRede.Name = "xEFaltaRede";
			this.xEFaltaRede.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFaltaRede.TagName = "STS_ALM_FALTA_REDE_EST";
			this.xEFaltaRede.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFaltaRedeValueChanged);
			this.xEFaltaRede.EndInit();
			// 
			// xEForaAuto
			// 
			this.xEForaAuto.BeginInit();
			this.xEForaAuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEForaAuto.IsOnlyInput = true;
			this.xEForaAuto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEForaAuto.Name = "xEForaAuto";
			this.xEForaAuto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEForaAuto.TagName = "STS_ALM_FORA_AUTOMATICO_EST";
			this.xEForaAuto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EForaAutoValueChanged);
			this.xEForaAuto.EndInit();
			// 
			// xSGB
			// 
			this.xSGB.BeginInit();
			this.xSGB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSGB.IsOnlyInput = true;
			this.xSGB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSGB.Name = "xSGB";
			this.xSGB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSGB.TagName = "STS_DISJUNTOR_GERADOR";
			this.xSGB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SGBValueChanged);
			this.xSGB.EndInit();
			// 
			// xSMB
			// 
			this.xSMB.BeginInit();
			this.xSMB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSMB.IsOnlyInput = true;
			this.xSMB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSMB.Name = "xSMB";
			this.xSMB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSMB.TagName = "STS_DISJUNTOR_REDE";
			this.xSMB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SMBValueChanged);
			this.xSMB.EndInit();
			// 
			// xSModo
			// 
			this.xSModo.BeginInit();
			this.xSModo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSModo.IsOnlyInput = true;
			this.xSModo.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSModo.Name = "xSModo";
			this.xSModo.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSModo.TagName = "STS_MODO";
			this.xSModo.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SModoValueChanged);
			this.xSModo.EndInit();
			// 
			// xSFonte
			// 
			this.xSFonte.BeginInit();
			this.xSFonte.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSFonte.IsOnlyInput = true;
			this.xSFonte.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSFonte.Name = "xSFonte";
			this.xSFonte.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSFonte.TagName = "STS_FONTE";
			this.xSFonte.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SFonteValueChanged);
			this.xSFonte.EndInit();
			// 
			// xOperando
			// 
			this.xOperando.BeginInit();
			this.xOperando.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xOperando.IsOnlyInput = true;
			this.xOperando.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xOperando.Name = "xOperando";
			this.xOperando.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xOperando.TagName = "STS_MOTOR_OPERANDO";
			this.xOperando.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OperandoValueChanged);
			this.xOperando.EndInit();
			// 
			// xPAuto
			// 
			this.xPAuto.BeginInit();
			this.xPAuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPAuto.IsOnlyInput = true;
			this.xPAuto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPAuto.Name = "xPAuto";
			this.xPAuto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPAuto.TagName = "STS_PERM_AUTO";
			this.xPAuto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermChanged);
			this.xPAuto.EndInit();
			// 
			// xPSemi
			// 
			this.xPSemi.BeginInit();
			this.xPSemi.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPSemi.IsOnlyInput = true;
			this.xPSemi.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPSemi.Name = "xPSemi";
			this.xPSemi.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPSemi.TagName = "STS_PERM_SEMI";
			this.xPSemi.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermChanged);
			this.xPSemi.EndInit();
			// 
			// xPPartir
			// 
			this.xPPartir.BeginInit();
			this.xPPartir.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPPartir.IsOnlyInput = true;
			this.xPPartir.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPPartir.Name = "xPPartir";
			this.xPPartir.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPPartir.TagName = "STS_PERM_PARTIR";
			this.xPPartir.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermChanged);
			this.xPPartir.EndInit();
			// 
			// xPParar
			// 
			this.xPParar.BeginInit();
			this.xPParar.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPParar.IsOnlyInput = true;
			this.xPParar.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPParar.Name = "xPParar";
			this.xPParar.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPParar.TagName = "STS_PERM_PARAR";
			this.xPParar.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermChanged);
			this.xPParar.EndInit();
			// 
			// xPRec
			// 
			this.xPRec.BeginInit();
			this.xPRec.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPRec.IsOnlyInput = true;
			this.xPRec.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPRec.Name = "xPRec";
			this.xPRec.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPRec.TagName = "STS_PERM_RECONHECERAGC";
			this.xPRec.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermChanged);
			this.xPRec.EndInit();
			// 
			// xCmdAtivo
			// 
			this.xCmdAtivo.BeginInit();
			this.xCmdAtivo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCmdAtivo.IsOnlyInput = true;
			this.xCmdAtivo.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCmdAtivo.Name = "xCmdAtivo";
			this.xCmdAtivo.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCmdAtivo.TagName = "STS_COMANDO_ATIVO";
			this.xCmdAtivo.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermChanged);
			this.xCmdAtivo.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(600D)), ((float)(722D)));
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
			this.rtGB,
			this.tGB,
			this.rtMB,
			this.tMB,
			this.rtModo,
			this.tModo,
			this.rtFonte,
			this.tFonte,
			this.lin0,
			this.rot0,
			this.v0_0,
			this.v0_1,
			this.v0_2,
			this.lin1,
			this.rot1,
			this.v1_0,
			this.v1_1,
			this.v1_2,
			this.lin2,
			this.rot2,
			this.v2_0,
			this.v2_1,
			this.v2_2,
			this.lin3,
			this.rot3,
			this.v3_0,
			this.v3_1,
			this.v3_2,
			this.lin4,
			this.rot4,
			this.v4_0,
			this.v4_1,
			this.lin5,
			this.rot5,
			this.v5_0,
			this.lin6,
			this.rot6,
			this.v6_0,
			this.v6_1,
			this.lin7,
			this.rot7,
			this.v7_0,
			this.v7_1,
			this.v7_2,
			this.lin8,
			this.rot8,
			this.v8_0,
			this.v8_1,
			this.lin9,
			this.rot9,
			this.v9_0,
			this.v9_1,
			this.tituloAlm,
			this.rCom,
			this.nCom,
			this.iComP1,
			this.iComP1n,
			this.iComP2,
			this.iComP2n,
			this.iComTxt,
			this.rAGC,
			this.nAGC,
			this.iAGCP1,
			this.iAGCP1n,
			this.iAGCP2,
			this.iAGCP2n,
			this.iAGCTxt,
			this.rPartida,
			this.nPartida,
			this.iPartidaP1,
			this.iPartidaP1n,
			this.iPartidaP2,
			this.iPartidaP2n,
			this.iPartidaTxt,
			this.rMotor,
			this.nMotor,
			this.iMotorP1,
			this.iMotorP1n,
			this.iMotorP2,
			this.iMotorP2n,
			this.iMotorTxt,
			this.rEmergencia,
			this.nEmergencia,
			this.iEmergenciaP1,
			this.iEmergenciaP1n,
			this.iEmergenciaP2,
			this.iEmergenciaP2n,
			this.iEmergenciaTxt,
			this.rDisjuntor,
			this.nDisjuntor,
			this.iDisjuntorP1,
			this.iDisjuntorP1n,
			this.iDisjuntorP2,
			this.iDisjuntorP2n,
			this.iDisjuntorTxt,
			this.rFaltaRede,
			this.nFaltaRede,
			this.iFaltaRedeP1,
			this.iFaltaRedeP1n,
			this.iFaltaRedeP2,
			this.iFaltaRedeP2n,
			this.iFaltaRedeTxt,
			this.rForaAuto,
			this.nForaAuto,
			this.iForaAutoP1,
			this.iForaAutoP1n,
			this.iForaAutoP2,
			this.iForaAutoP2n,
			this.iForaAutoTxt,
			this.btnReset,
			this.tituloCmd,
			this.btnAuto,
			this.btnSemi,
			this.btnPartir,
			this.btnParar,
			this.btnRecAGC,
			this.tCmdInfo,
			this.confFundo,
			this.confTexto,
			this.btnConfirmar,
			this.btnCancelar,
			this.xACom,
			this.xAAGC,
			this.xAPartida,
			this.xAMotor,
			this.xAEmergencia,
			this.xADisjuntor,
			this.xAFaltaRede,
			this.xAForaAuto,
			this.xECom,
			this.xEAGC,
			this.xEPartida,
			this.xEMotor,
			this.xEEmergencia,
			this.xEDisjuntor,
			this.xEFaltaRede,
			this.xEForaAuto,
			this.xSGB,
			this.xSMB,
			this.xSModo,
			this.xSFonte,
			this.xOperando,
			this.xPAuto,
			this.xPSemi,
			this.xPPartir,
			this.xPParar,
			this.xPRec,
			this.xCmdAtivo});
			this.Size = new System.Drawing.Size(600, 722);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText rtGB;
		private NxtControl.GuiFramework.FreeText tGB;
		private NxtControl.GuiFramework.FreeText rtMB;
		private NxtControl.GuiFramework.FreeText tMB;
		private NxtControl.GuiFramework.FreeText rtModo;
		private NxtControl.GuiFramework.FreeText tModo;
		private NxtControl.GuiFramework.FreeText rtFonte;
		private NxtControl.GuiFramework.FreeText tFonte;
		private NxtControl.GuiFramework.Rectangle lin0;
		private NxtControl.GuiFramework.FreeText rot0;
		private System.HMI.Symbols.Base.Label<System.Single> v0_0;
		private System.HMI.Symbols.Base.Label<System.Single> v0_1;
		private System.HMI.Symbols.Base.Label<System.Single> v0_2;
		private NxtControl.GuiFramework.Rectangle lin1;
		private NxtControl.GuiFramework.FreeText rot1;
		private System.HMI.Symbols.Base.Label<System.Single> v1_0;
		private System.HMI.Symbols.Base.Label<System.Single> v1_1;
		private System.HMI.Symbols.Base.Label<System.Single> v1_2;
		private NxtControl.GuiFramework.Rectangle lin2;
		private NxtControl.GuiFramework.FreeText rot2;
		private System.HMI.Symbols.Base.Label<System.Single> v2_0;
		private System.HMI.Symbols.Base.Label<System.Single> v2_1;
		private System.HMI.Symbols.Base.Label<System.Single> v2_2;
		private NxtControl.GuiFramework.Rectangle lin3;
		private NxtControl.GuiFramework.FreeText rot3;
		private System.HMI.Symbols.Base.Label<System.Single> v3_0;
		private System.HMI.Symbols.Base.Label<System.Single> v3_1;
		private System.HMI.Symbols.Base.Label<System.Single> v3_2;
		private NxtControl.GuiFramework.Rectangle lin4;
		private NxtControl.GuiFramework.FreeText rot4;
		private System.HMI.Symbols.Base.Label<System.Single> v4_0;
		private System.HMI.Symbols.Base.Label<System.Single> v4_1;
		private NxtControl.GuiFramework.Rectangle lin5;
		private NxtControl.GuiFramework.FreeText rot5;
		private System.HMI.Symbols.Base.Label<System.Single> v5_0;
		private NxtControl.GuiFramework.Rectangle lin6;
		private NxtControl.GuiFramework.FreeText rot6;
		private System.HMI.Symbols.Base.Label<System.Single> v6_0;
		private System.HMI.Symbols.Base.Label<System.Single> v6_1;
		private NxtControl.GuiFramework.Rectangle lin7;
		private NxtControl.GuiFramework.FreeText rot7;
		private System.HMI.Symbols.Base.Label<System.Single> v7_0;
		private System.HMI.Symbols.Base.Label<System.Single> v7_1;
		private System.HMI.Symbols.Base.Label<System.Single> v7_2;
		private NxtControl.GuiFramework.Rectangle lin8;
		private NxtControl.GuiFramework.FreeText rot8;
		private System.HMI.Symbols.Base.Label<System.Single> v8_0;
		private System.HMI.Symbols.Base.Label<System.Single> v8_1;
		private NxtControl.GuiFramework.Rectangle lin9;
		private NxtControl.GuiFramework.FreeText rot9;
		private System.HMI.Symbols.Base.Label<System.Single> v9_0;
		private System.HMI.Symbols.Base.Label<System.Single> v9_1;
		private NxtControl.GuiFramework.FreeText tituloAlm;
		private NxtControl.GuiFramework.FreeText rCom;
		private NxtControl.GuiFramework.FreeText nCom;
		private NxtControl.GuiFramework.Rectangle iComP1;
		private NxtControl.GuiFramework.FreeText iComP1n;
		private NxtControl.GuiFramework.Polygon iComP2;
		private NxtControl.GuiFramework.FreeText iComP2n;
		private NxtControl.GuiFramework.FreeText iComTxt;
		private NxtControl.GuiFramework.FreeText rAGC;
		private NxtControl.GuiFramework.FreeText nAGC;
		private NxtControl.GuiFramework.Rectangle iAGCP1;
		private NxtControl.GuiFramework.FreeText iAGCP1n;
		private NxtControl.GuiFramework.Polygon iAGCP2;
		private NxtControl.GuiFramework.FreeText iAGCP2n;
		private NxtControl.GuiFramework.FreeText iAGCTxt;
		private NxtControl.GuiFramework.FreeText rPartida;
		private NxtControl.GuiFramework.FreeText nPartida;
		private NxtControl.GuiFramework.Rectangle iPartidaP1;
		private NxtControl.GuiFramework.FreeText iPartidaP1n;
		private NxtControl.GuiFramework.Polygon iPartidaP2;
		private NxtControl.GuiFramework.FreeText iPartidaP2n;
		private NxtControl.GuiFramework.FreeText iPartidaTxt;
		private NxtControl.GuiFramework.FreeText rMotor;
		private NxtControl.GuiFramework.FreeText nMotor;
		private NxtControl.GuiFramework.Rectangle iMotorP1;
		private NxtControl.GuiFramework.FreeText iMotorP1n;
		private NxtControl.GuiFramework.Polygon iMotorP2;
		private NxtControl.GuiFramework.FreeText iMotorP2n;
		private NxtControl.GuiFramework.FreeText iMotorTxt;
		private NxtControl.GuiFramework.FreeText rEmergencia;
		private NxtControl.GuiFramework.FreeText nEmergencia;
		private NxtControl.GuiFramework.Rectangle iEmergenciaP1;
		private NxtControl.GuiFramework.FreeText iEmergenciaP1n;
		private NxtControl.GuiFramework.Polygon iEmergenciaP2;
		private NxtControl.GuiFramework.FreeText iEmergenciaP2n;
		private NxtControl.GuiFramework.FreeText iEmergenciaTxt;
		private NxtControl.GuiFramework.FreeText rDisjuntor;
		private NxtControl.GuiFramework.FreeText nDisjuntor;
		private NxtControl.GuiFramework.Rectangle iDisjuntorP1;
		private NxtControl.GuiFramework.FreeText iDisjuntorP1n;
		private NxtControl.GuiFramework.Polygon iDisjuntorP2;
		private NxtControl.GuiFramework.FreeText iDisjuntorP2n;
		private NxtControl.GuiFramework.FreeText iDisjuntorTxt;
		private NxtControl.GuiFramework.FreeText rFaltaRede;
		private NxtControl.GuiFramework.FreeText nFaltaRede;
		private NxtControl.GuiFramework.Rectangle iFaltaRedeP1;
		private NxtControl.GuiFramework.FreeText iFaltaRedeP1n;
		private NxtControl.GuiFramework.Polygon iFaltaRedeP2;
		private NxtControl.GuiFramework.FreeText iFaltaRedeP2n;
		private NxtControl.GuiFramework.FreeText iFaltaRedeTxt;
		private NxtControl.GuiFramework.FreeText rForaAuto;
		private NxtControl.GuiFramework.FreeText nForaAuto;
		private NxtControl.GuiFramework.Rectangle iForaAutoP1;
		private NxtControl.GuiFramework.FreeText iForaAutoP1n;
		private NxtControl.GuiFramework.Polygon iForaAutoP2;
		private NxtControl.GuiFramework.FreeText iForaAutoP2n;
		private NxtControl.GuiFramework.FreeText iForaAutoTxt;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.FreeText tituloCmd;
		private NxtControl.GuiFramework.DrawnButton btnAuto;
		private NxtControl.GuiFramework.DrawnButton btnSemi;
		private NxtControl.GuiFramework.DrawnButton btnPartir;
		private NxtControl.GuiFramework.DrawnButton btnParar;
		private NxtControl.GuiFramework.DrawnButton btnRecAGC;
		private NxtControl.GuiFramework.FreeText tCmdInfo;
		private NxtControl.GuiFramework.Rectangle confFundo;
		private NxtControl.GuiFramework.FreeText confTexto;
		private NxtControl.GuiFramework.DrawnButton btnConfirmar;
		private NxtControl.GuiFramework.DrawnButton btnCancelar;
		private System.HMI.Symbols.Base.Execute<bool> xACom;
		private System.HMI.Symbols.Base.Execute<bool> xAAGC;
		private System.HMI.Symbols.Base.Execute<bool> xAPartida;
		private System.HMI.Symbols.Base.Execute<bool> xAMotor;
		private System.HMI.Symbols.Base.Execute<bool> xAEmergencia;
		private System.HMI.Symbols.Base.Execute<bool> xADisjuntor;
		private System.HMI.Symbols.Base.Execute<bool> xAFaltaRede;
		private System.HMI.Symbols.Base.Execute<bool> xAForaAuto;
		private System.HMI.Symbols.Base.Execute<byte> xECom;
		private System.HMI.Symbols.Base.Execute<byte> xEAGC;
		private System.HMI.Symbols.Base.Execute<byte> xEPartida;
		private System.HMI.Symbols.Base.Execute<byte> xEMotor;
		private System.HMI.Symbols.Base.Execute<byte> xEEmergencia;
		private System.HMI.Symbols.Base.Execute<byte> xEDisjuntor;
		private System.HMI.Symbols.Base.Execute<byte> xEFaltaRede;
		private System.HMI.Symbols.Base.Execute<byte> xEForaAuto;
		private System.HMI.Symbols.Base.Execute<short> xSGB;
		private System.HMI.Symbols.Base.Execute<short> xSMB;
		private System.HMI.Symbols.Base.Execute<short> xSModo;
		private System.HMI.Symbols.Base.Execute<short> xSFonte;
		private System.HMI.Symbols.Base.Execute<bool> xOperando;
		private System.HMI.Symbols.Base.Execute<bool> xPAuto;
		private System.HMI.Symbols.Base.Execute<bool> xPSemi;
		private System.HMI.Symbols.Base.Execute<bool> xPPartir;
		private System.HMI.Symbols.Base.Execute<bool> xPParar;
		private System.HMI.Symbols.Base.Execute<bool> xPRec;
		private System.HMI.Symbols.Base.Execute<bool> xCmdAtivo;
		#endregion
	}
}
