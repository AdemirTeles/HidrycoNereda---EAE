/*
 * Hidryco - Motor_Generico - fpDefault
 * ISA-101: estado (texto + caixa cheia/vazada), falha com indicador de prioridade, chave/disponibilidade em texto, velocidade (inversor), modo, comando manual, reset e navegacao.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
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
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.caixaEstado = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.textoChave = new NxtControl.GuiFramework.FreeText();
			this.textoDisp = new NxtControl.GuiFramework.FreeText();
			this.textoGerador = new NxtControl.GuiFramework.FreeText();
			this.tituloVel = new NxtControl.GuiFramework.FreeText();
			this.vel = new System.HMI.Symbols.Base.Label<float>();
			this.velBarra = new NxtControl.GuiFramework.Rectangle();
			this.velRef = new NxtControl.GuiFramework.Polygon();
			this.velPonteiro = new NxtControl.GuiFramework.Polygon();
			this.tituloModo = new NxtControl.GuiFramework.FreeText();
			this.btnManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutomatico = new NxtControl.GuiFramework.DrawnButton();
			this.tituloComando = new NxtControl.GuiFramework.FreeText();
			this.btnDesligar = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigar = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.btnAjustes = new NxtControl.GuiFramework.DrawnButton();
			this.btnManutencao = new NxtControl.GuiFramework.DrawnButton();
			this.btnMedicoes = new NxtControl.GuiFramework.DrawnButton();
			this.btnDiagnostico = new NxtControl.GuiFramework.DrawnButton();
			this.xLigado = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAuto = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCmdManual = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRemoto = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLocal = new System.HMI.Symbols.Base.Execute<bool>();
			this.xManut = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDisp = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBloq = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBloqGer = new System.HMI.Symbols.Base.Execute<bool>();
			this.xInversor = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAnimGer = new System.HMI.Symbols.Base.Execute<short>();
			this.xVel = new System.HMI.Symbols.Base.Execute<float>();
			this.xRef = new System.HMI.Symbols.Base.Execute<float>();
			this.xEmerg = new System.HMI.Symbols.Base.Execute<bool>();
			this.xTerm = new System.HMI.Symbols.Base.Execute<bool>();
			this.xInv = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPart = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPara = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCom = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEEmerg = new System.HMI.Symbols.Base.Execute<byte>();
			this.xETerm = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEInv = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPart = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPara = new System.HMI.Symbols.Base.Execute<byte>();
			this.xECom = new System.HMI.Symbols.Base.Execute<byte>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(136D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaEstado
			// 
			this.caixaEstado.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(14D)), ((float)(22D)), ((float)(22D)));
			this.caixaEstado.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaEstado.Name = "caixaEstado";
			this.caixaEstado.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(50D, 14D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "DESLIGADO";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(16D)), ((float)(16D)), ((float)(16D)));
			this.alP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.alP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP1.Name = "alP1";
			this.alP1.Visible = false;
			// 
			// alP1n
			// 
			this.alP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.alP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alP1n.Location = new NxtControl.Drawing.PointF(204D, 17D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(16D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(200D, 32D),
			new NxtControl.Drawing.PointF(208D, 16D),
			new NxtControl.Drawing.PointF(216D, 32D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(205D, 20D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(220D, 16D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Visible = false;
			// 
			// textoChave
			// 
			this.textoChave.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoChave.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoChave.Location = new NxtControl.Drawing.PointF(20D, 46D);
			this.textoChave.Name = "textoChave";
			this.textoChave.Text = "Remoto";
			// 
			// textoDisp
			// 
			this.textoDisp.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoDisp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoDisp.Location = new NxtControl.Drawing.PointF(20D, 64D);
			this.textoDisp.Name = "textoDisp";
			this.textoDisp.Text = "Disponível para o automático";
			// 
			// textoGerador
			// 
			this.textoGerador.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoGerador.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoGerador.Location = new NxtControl.Drawing.PointF(20D, 82D);
			this.textoGerador.Name = "textoGerador";
			this.textoGerador.Visible = false;
			// 
			// tituloVel
			// 
			this.tituloVel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tituloVel.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tituloVel.Location = new NxtControl.Drawing.PointF(20D, 104D);
			this.tituloVel.Name = "tituloVel";
			this.tituloVel.Text = "Velocidade";
			this.tituloVel.Visible = false;
			// 
			// vel
			// 
			this.vel.BeginInit();
			this.vel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vel.DecimalPlacesCount = ((uint)(1u));
			this.vel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.3671D, 0D, 0D, 1D, 90D, 99D);
			this.vel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vel.FontScale = false;
			this.vel.IsOnlyInput = true;
			this.vel.IsPrefixSuffixOutside = false;
			this.vel.LeadingZeros = ((uint)(0u));
			this.vel.Name = "vel";
			this.vel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vel.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vel.Suffix = " %";
			this.vel.TagName = "STS_VELOCIDADE";
			this.vel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vel.Visible = false;
			this.vel.EndInit();
			// 
			// velBarra
			// 
			this.velBarra.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(106D)), ((float)(180D)), ((float)(10D)));
			this.velBarra.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.velBarra.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.velBarra.Name = "velBarra";
			this.velBarra.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.velBarra.Visible = false;
			// 
			// velRef
			// 
			this.velRef.Bounds = new NxtControl.Drawing.RectF(((float)(245D)), ((float)(98D)), ((float)(10D)), ((float)(8D)));
			this.velRef.Closed = true;
			this.velRef.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.velRef.Name = "velRef";
			this.velRef.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(245D, 98D),
			new NxtControl.Drawing.PointF(250D, 106D),
			new NxtControl.Drawing.PointF(255D, 98D)});
			this.velRef.Visible = false;
			// 
			// velPonteiro
			// 
			this.velPonteiro.Bounds = new NxtControl.Drawing.RectF(((float)(245D)), ((float)(116D)), ((float)(10D)), ((float)(7D)));
			this.velPonteiro.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.velPonteiro.Closed = true;
			this.velPonteiro.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.velPonteiro.Name = "velPonteiro";
			this.velPonteiro.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			this.velPonteiro.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(245D, 123D),
			new NxtControl.Drawing.PointF(250D, 116D),
			new NxtControl.Drawing.PointF(255D, 123D)});
			this.velPonteiro.Visible = false;
			// 
			// tituloModo
			// 
			this.tituloModo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloModo.Location = new NxtControl.Drawing.PointF(20D, 150D);
			this.tituloModo.Name = "tituloModo";
			this.tituloModo.Text = "Modo de operação";
			// 
			// btnManual
			// 
			this.btnManual.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(172D)), ((float)(150D)), ((float)(34D)));
			this.btnManual.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManual.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnManual.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManual.Name = "btnManual";
			this.btnManual.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManual.Radius = 2D;
			this.btnManual.Text = "Manual";
			this.btnManual.Use3DEffect = false;
			this.btnManual.Click += new System.EventHandler(this.BtnManualClick);
			// 
			// btnAutomatico
			// 
			this.btnAutomatico.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(172D)), ((float)(150D)), ((float)(34D)));
			this.btnAutomatico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAutomatico.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAutomatico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAutomatico.Name = "btnAutomatico";
			this.btnAutomatico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAutomatico.Radius = 2D;
			this.btnAutomatico.Text = "Automático";
			this.btnAutomatico.Use3DEffect = false;
			this.btnAutomatico.Click += new System.EventHandler(this.BtnAutomaticoClick);
			// 
			// tituloComando
			// 
			this.tituloComando.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloComando.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloComando.Location = new NxtControl.Drawing.PointF(20D, 220D);
			this.tituloComando.Name = "tituloComando";
			this.tituloComando.Text = "Comando manual";
			// 
			// btnDesligar
			// 
			this.btnDesligar.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(242D)), ((float)(150D)), ((float)(34D)));
			this.btnDesligar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesligar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnDesligar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesligar.Name = "btnDesligar";
			this.btnDesligar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesligar.Radius = 2D;
			this.btnDesligar.Text = "Desligar";
			this.btnDesligar.Use3DEffect = false;
			this.btnDesligar.Click += new System.EventHandler(this.BtnDesligarClick);
			// 
			// btnLigar
			// 
			this.btnLigar.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(242D)), ((float)(150D)), ((float)(34D)));
			this.btnLigar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnLigar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLigar.Name = "btnLigar";
			this.btnLigar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLigar.Radius = 2D;
			this.btnLigar.Text = "Ligar";
			this.btnLigar.Use3DEffect = false;
			this.btnLigar.Click += new System.EventHandler(this.BtnLigarClick);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(296D)), ((float)(150D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer / Reset";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(346D)), ((float)(320D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// btnAjustes
			// 
			this.btnAjustes.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(358D)), ((float)(74D)), ((float)(32D)));
			this.btnAjustes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAjustes.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnAjustes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAjustes.Name = "btnAjustes";
			this.btnAjustes.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpParameter", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnAjustes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAjustes.Radius = 2D;
			this.btnAjustes.Text = "Ajustes";
			this.btnAjustes.Use3DEffect = false;
			// 
			// btnManutencao
			// 
			this.btnManutencao.Bounds = new NxtControl.Drawing.RectF(((float)(102D)), ((float)(358D)), ((float)(74D)), ((float)(32D)));
			this.btnManutencao.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnManutencao.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnManutencao.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnManutencao.Name = "btnManutencao";
			this.btnManutencao.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpMaintenance", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnManutencao.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnManutencao.Radius = 2D;
			this.btnManutencao.Text = "Horímetro";
			this.btnManutencao.Use3DEffect = false;
			// 
			// btnMedicoes
			// 
			this.btnMedicoes.Bounds = new NxtControl.Drawing.RectF(((float)(184D)), ((float)(358D)), ((float)(74D)), ((float)(32D)));
			this.btnMedicoes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnMedicoes.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnMedicoes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnMedicoes.Name = "btnMedicoes";
			this.btnMedicoes.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpMeasures", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnMedicoes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnMedicoes.Radius = 2D;
			this.btnMedicoes.Text = "Medições";
			this.btnMedicoes.Use3DEffect = false;
			this.btnMedicoes.Visible = false;
			// 
			// btnDiagnostico
			// 
			this.btnDiagnostico.Bounds = new NxtControl.Drawing.RectF(((float)(266D)), ((float)(358D)), ((float)(74D)), ((float)(32D)));
			this.btnDiagnostico.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDiagnostico.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.btnDiagnostico.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDiagnostico.Name = "btnDiagnostico";
			this.btnDiagnostico.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDiagnostic", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnDiagnostico.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDiagnostico.Radius = 2D;
			this.btnDiagnostico.Text = "Diagnóstico";
			this.btnDiagnostico.Use3DEffect = false;
			// 
			// xLigado
			// 
			this.xLigado.BeginInit();
			this.xLigado.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLigado.IsOnlyInput = true;
			this.xLigado.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLigado.Name = "xLigado";
			this.xLigado.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLigado.TagName = "STS_LIGADO";
			this.xLigado.Value = false;
			this.xLigado.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LigadoValueChanged);
			this.xLigado.EndInit();
			// 
			// xAuto
			// 
			this.xAuto.BeginInit();
			this.xAuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAuto.IsOnlyInput = true;
			this.xAuto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAuto.Name = "xAuto";
			this.xAuto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAuto.TagName = "fbkStsAutomatico";
			this.xAuto.Value = false;
			this.xAuto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AutomaticoValueChanged);
			this.xAuto.EndInit();
			// 
			// xCmdManual
			// 
			this.xCmdManual.BeginInit();
			this.xCmdManual.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCmdManual.IsOnlyInput = true;
			this.xCmdManual.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCmdManual.Name = "xCmdManual";
			this.xCmdManual.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCmdManual.TagName = "fbkCmdManual";
			this.xCmdManual.Value = false;
			this.xCmdManual.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CmdManualValueChanged);
			this.xCmdManual.EndInit();
			// 
			// xRemoto
			// 
			this.xRemoto.BeginInit();
			this.xRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRemoto.IsOnlyInput = true;
			this.xRemoto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRemoto.Name = "xRemoto";
			this.xRemoto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRemoto.TagName = "STS_REMOTO";
			this.xRemoto.Value = false;
			this.xRemoto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RemotoValueChanged);
			this.xRemoto.EndInit();
			// 
			// xLocal
			// 
			this.xLocal.BeginInit();
			this.xLocal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLocal.IsOnlyInput = true;
			this.xLocal.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLocal.Name = "xLocal";
			this.xLocal.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLocal.TagName = "STS_LOCAL";
			this.xLocal.Value = false;
			this.xLocal.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LocalValueChanged);
			this.xLocal.EndInit();
			// 
			// xManut
			// 
			this.xManut.BeginInit();
			this.xManut.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xManut.IsOnlyInput = true;
			this.xManut.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xManut.Name = "xManut";
			this.xManut.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xManut.TagName = "STS_MANUTENCAO";
			this.xManut.Value = false;
			this.xManut.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ManutencaoValueChanged);
			this.xManut.EndInit();
			// 
			// xDisp
			// 
			this.xDisp.BeginInit();
			this.xDisp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDisp.IsOnlyInput = true;
			this.xDisp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDisp.Name = "xDisp";
			this.xDisp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDisp.TagName = "STS_DISPONIVEL_AUTOMATICO";
			this.xDisp.Value = false;
			this.xDisp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DisponivelValueChanged);
			this.xDisp.EndInit();
			// 
			// xBloq
			// 
			this.xBloq.BeginInit();
			this.xBloq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBloq.IsOnlyInput = true;
			this.xBloq.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBloq.Name = "xBloq";
			this.xBloq.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBloq.TagName = "STS_BLOQUEADO";
			this.xBloq.Value = false;
			this.xBloq.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BloqueadoValueChanged);
			this.xBloq.EndInit();
			// 
			// xBloqGer
			// 
			this.xBloqGer.BeginInit();
			this.xBloqGer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBloqGer.IsOnlyInput = true;
			this.xBloqGer.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBloqGer.Name = "xBloqGer";
			this.xBloqGer.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBloqGer.TagName = "STS_BLOQUEIO_GERADOR";
			this.xBloqGer.Value = false;
			this.xBloqGer.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BloqGeradorValueChanged);
			this.xBloqGer.EndInit();
			// 
			// xInversor
			// 
			this.xInversor.BeginInit();
			this.xInversor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xInversor.IsOnlyInput = true;
			this.xInversor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xInversor.Name = "xInversor";
			this.xInversor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xInversor.TagName = "STS_INVERSOR";
			this.xInversor.Value = false;
			this.xInversor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InversorValueChanged);
			this.xInversor.EndInit();
			// 
			// xAnimGer
			// 
			this.xAnimGer.BeginInit();
			this.xAnimGer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAnimGer.IsOnlyInput = true;
			this.xAnimGer.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAnimGer.Name = "xAnimGer";
			this.xAnimGer.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAnimGer.TagName = "STS_ANIMACAO_GERADOR";
			this.xAnimGer.Value = ((short)(0));
			this.xAnimGer.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AnimGeradorValueChanged);
			this.xAnimGer.EndInit();
			// 
			// xVel
			// 
			this.xVel.BeginInit();
			this.xVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVel.IsOnlyInput = true;
			this.xVel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVel.Name = "xVel";
			this.xVel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVel.TagName = "STS_VELOCIDADE";
			this.xVel.Value = 0F;
			this.xVel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.VelocidadeValueChanged);
			this.xVel.EndInit();
			// 
			// xRef
			// 
			this.xRef.BeginInit();
			this.xRef.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRef.IsOnlyInput = true;
			this.xRef.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRef.Name = "xRef";
			this.xRef.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRef.TagName = "STS_VELOCIDADE_REFERENCIA";
			this.xRef.Value = 0F;
			this.xRef.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ReferenciaValueChanged);
			this.xRef.EndInit();
			// 
			// xEmerg
			// 
			this.xEmerg.BeginInit();
			this.xEmerg.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEmerg.IsOnlyInput = true;
			this.xEmerg.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEmerg.Name = "xEmerg";
			this.xEmerg.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEmerg.TagName = "STS_EMERGENCIA";
			this.xEmerg.Value = false;
			this.xEmerg.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EmergValueChanged);
			this.xEmerg.EndInit();
			// 
			// xTerm
			// 
			this.xTerm.BeginInit();
			this.xTerm.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTerm.IsOnlyInput = true;
			this.xTerm.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTerm.Name = "xTerm";
			this.xTerm.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTerm.TagName = "STS_PROTECAO_TERMICA";
			this.xTerm.Value = false;
			this.xTerm.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TermValueChanged);
			this.xTerm.EndInit();
			// 
			// xInv
			// 
			this.xInv.BeginInit();
			this.xInv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xInv.IsOnlyInput = true;
			this.xInv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xInv.Name = "xInv";
			this.xInv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xInv.TagName = "STS_FALHA_INVERSOR";
			this.xInv.Value = false;
			this.xInv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InvValueChanged);
			this.xInv.EndInit();
			// 
			// xPart
			// 
			this.xPart.BeginInit();
			this.xPart.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPart.IsOnlyInput = true;
			this.xPart.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPart.Name = "xPart";
			this.xPart.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPart.TagName = "STS_FALHA_PARTIDA";
			this.xPart.Value = false;
			this.xPart.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PartValueChanged);
			this.xPart.EndInit();
			// 
			// xPara
			// 
			this.xPara.BeginInit();
			this.xPara.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPara.IsOnlyInput = true;
			this.xPara.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPara.Name = "xPara";
			this.xPara.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPara.TagName = "STS_FALHA_PARADA";
			this.xPara.Value = false;
			this.xPara.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ParaValueChanged);
			this.xPara.EndInit();
			// 
			// xCom
			// 
			this.xCom.BeginInit();
			this.xCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCom.IsOnlyInput = true;
			this.xCom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCom.Name = "xCom";
			this.xCom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCom.TagName = "STS_FALHA_COMUNICACAO";
			this.xCom.Value = false;
			this.xCom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ComValueChanged);
			this.xCom.EndInit();
			// 
			// xEEmerg
			// 
			this.xEEmerg.BeginInit();
			this.xEEmerg.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEmerg.IsOnlyInput = true;
			this.xEEmerg.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEmerg.Name = "xEEmerg";
			this.xEEmerg.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEmerg.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEmerg.Value = ((byte)(0));
			this.xEEmerg.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EEmergValueChanged);
			this.xEEmerg.EndInit();
			// 
			// xETerm
			// 
			this.xETerm.BeginInit();
			this.xETerm.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xETerm.IsOnlyInput = true;
			this.xETerm.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xETerm.Name = "xETerm";
			this.xETerm.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xETerm.TagName = "STS_ALM_TERMICA_EST";
			this.xETerm.Value = ((byte)(0));
			this.xETerm.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ETermValueChanged);
			this.xETerm.EndInit();
			// 
			// xEInv
			// 
			this.xEInv.BeginInit();
			this.xEInv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEInv.IsOnlyInput = true;
			this.xEInv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEInv.Name = "xEInv";
			this.xEInv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEInv.TagName = "STS_ALM_ACIONAMENTO_EST";
			this.xEInv.Value = ((byte)(0));
			this.xEInv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EInvValueChanged);
			this.xEInv.EndInit();
			// 
			// xEPart
			// 
			this.xEPart.BeginInit();
			this.xEPart.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPart.IsOnlyInput = true;
			this.xEPart.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPart.Name = "xEPart";
			this.xEPart.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPart.TagName = "STS_ALM_PARTIDA_EST";
			this.xEPart.Value = ((byte)(0));
			this.xEPart.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EPartValueChanged);
			this.xEPart.EndInit();
			// 
			// xEPara
			// 
			this.xEPara.BeginInit();
			this.xEPara.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPara.IsOnlyInput = true;
			this.xEPara.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPara.Name = "xEPara";
			this.xEPara.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPara.TagName = "STS_ALM_PARADA_EST";
			this.xEPara.Value = ((byte)(0));
			this.xEPara.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EParaValueChanged);
			this.xEPara.EndInit();
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
			this.xECom.Value = ((byte)(0));
			this.xECom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EComValueChanged);
			this.xECom.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(406D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.caixaEstado,
			this.textoEstado,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.textoChave,
			this.textoDisp,
			this.textoGerador,
			this.tituloVel,
			this.vel,
			this.velBarra,
			this.velRef,
			this.velPonteiro,
			this.tituloModo,
			this.btnManual,
			this.btnAutomatico,
			this.tituloComando,
			this.btnDesligar,
			this.btnLigar,
			this.btnReset,
			this.sep,
			this.btnAjustes,
			this.btnManutencao,
			this.btnMedicoes,
			this.btnDiagnostico,
			this.xLigado,
			this.xAuto,
			this.xCmdManual,
			this.xRemoto,
			this.xLocal,
			this.xManut,
			this.xDisp,
			this.xBloq,
			this.xBloqGer,
			this.xInversor,
			this.xAnimGer,
			this.xVel,
			this.xRef,
			this.xEmerg,
			this.xTerm,
			this.xInv,
			this.xPart,
			this.xPara,
			this.xCom,
			this.xEEmerg,
			this.xETerm,
			this.xEInv,
			this.xEPart,
			this.xEPara,
			this.xECom});
			this.Size = new System.Drawing.Size(360, 406);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle caixaEstado;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText textoChave;
		private NxtControl.GuiFramework.FreeText textoDisp;
		private NxtControl.GuiFramework.FreeText textoGerador;
		private NxtControl.GuiFramework.FreeText tituloVel;
		private System.HMI.Symbols.Base.Label<System.Single> vel;
		private NxtControl.GuiFramework.Rectangle velBarra;
		private NxtControl.GuiFramework.Polygon velRef;
		private NxtControl.GuiFramework.Polygon velPonteiro;
		private NxtControl.GuiFramework.FreeText tituloModo;
		private NxtControl.GuiFramework.DrawnButton btnManual;
		private NxtControl.GuiFramework.DrawnButton btnAutomatico;
		private NxtControl.GuiFramework.FreeText tituloComando;
		private NxtControl.GuiFramework.DrawnButton btnDesligar;
		private NxtControl.GuiFramework.DrawnButton btnLigar;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.DrawnButton btnAjustes;
		private NxtControl.GuiFramework.DrawnButton btnManutencao;
		private NxtControl.GuiFramework.DrawnButton btnMedicoes;
		private NxtControl.GuiFramework.DrawnButton btnDiagnostico;
		private System.HMI.Symbols.Base.Execute<bool> xLigado;
		private System.HMI.Symbols.Base.Execute<bool> xAuto;
		private System.HMI.Symbols.Base.Execute<bool> xCmdManual;
		private System.HMI.Symbols.Base.Execute<bool> xRemoto;
		private System.HMI.Symbols.Base.Execute<bool> xLocal;
		private System.HMI.Symbols.Base.Execute<bool> xManut;
		private System.HMI.Symbols.Base.Execute<bool> xDisp;
		private System.HMI.Symbols.Base.Execute<bool> xBloq;
		private System.HMI.Symbols.Base.Execute<bool> xBloqGer;
		private System.HMI.Symbols.Base.Execute<bool> xInversor;
		private System.HMI.Symbols.Base.Execute<short> xAnimGer;
		private System.HMI.Symbols.Base.Execute<float> xVel;
		private System.HMI.Symbols.Base.Execute<float> xRef;
		private System.HMI.Symbols.Base.Execute<bool> xEmerg;
		private System.HMI.Symbols.Base.Execute<bool> xTerm;
		private System.HMI.Symbols.Base.Execute<bool> xInv;
		private System.HMI.Symbols.Base.Execute<bool> xPart;
		private System.HMI.Symbols.Base.Execute<bool> xPara;
		private System.HMI.Symbols.Base.Execute<bool> xCom;
		private System.HMI.Symbols.Base.Execute<byte> xEEmerg;
		private System.HMI.Symbols.Base.Execute<byte> xETerm;
		private System.HMI.Symbols.Base.Execute<byte> xEInv;
		private System.HMI.Symbols.Base.Execute<byte> xEPart;
		private System.HMI.Symbols.Base.Execute<byte> xEPara;
		private System.HMI.Symbols.Base.Execute<byte> xECom;
		#endregion
	}
}
