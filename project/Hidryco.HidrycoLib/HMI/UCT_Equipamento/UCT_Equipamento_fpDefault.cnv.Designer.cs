/*
 * Hidryco - UCT_Equipamento - fpDefault
 * ISA-101: estado, horimetro e comandos do equipamento da UCT (liga manual, intermitente, reversao, velocidade). Em automatico do subsistema os comandos so indicam.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UCT_Equipamento
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
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.caixaEstado = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.textoModo = new NxtControl.GuiFramework.FreeText();
			this.rotHor = new NxtControl.GuiFramework.FreeText();
			this.vHor = new System.HMI.Symbols.Base.Label<System.Int32>();
			this.tituloComando = new NxtControl.GuiFramework.FreeText();
			this.btnDesligar = new NxtControl.GuiFramework.DrawnButton();
			this.btnLigar = new NxtControl.GuiFramework.DrawnButton();
			this.tituloInt = new NxtControl.GuiFramework.FreeText();
			this.btnIntOff = new NxtControl.GuiFramework.DrawnButton();
			this.btnIntOn = new NxtControl.GuiFramework.DrawnButton();
			this.tituloRev = new NxtControl.GuiFramework.FreeText();
			this.btnRevOff = new NxtControl.GuiFramework.DrawnButton();
			this.btnRevOn = new NxtControl.GuiFramework.DrawnButton();
			this.tituloVel = new NxtControl.GuiFramework.FreeText();
			this.rotVelAtual = new NxtControl.GuiFramework.FreeText();
			this.vVel = new System.HMI.Symbols.Base.Label<System.Single>();
			this.rotVelRef = new NxtControl.GuiFramework.FreeText();
			this.tVel = new System.HMI.Symbols.Base.TextBox<float>();
			this.x_anim = new System.HMI.Symbols.Base.Execute<short>();
			this.x_defeito = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_auto = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbLiga = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbInt = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgVel = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgInt = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgRev = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(96D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaEstado
			// 
			this.caixaEstado.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(14D)), ((float)(22D)), ((float)(22D)));
			this.caixaEstado.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
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
			// textoModo
			// 
			this.textoModo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.textoModo.Location = new NxtControl.Drawing.PointF(20D, 46D);
			this.textoModo.Name = "textoModo";
			this.textoModo.Text = "Subsistema em manual";
			// 
			// rotHor
			// 
			this.rotHor.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rotHor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotHor.Location = new NxtControl.Drawing.PointF(20D, 68D);
			this.rotHor.Name = "rotHor";
			this.rotHor.Text = "Horímetro";
			// 
			// vHor
			// 
			this.vHor.BeginInit();
			this.vHor.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vHor.DecimalPlacesCount = ((uint)(0u));
			this.vHor.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 110D, 63D);
			this.vHor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vHor.FontScale = false;
			this.vHor.IsOnlyInput = true;
			this.vHor.IsPrefixSuffixOutside = false;
			this.vHor.LeadingZeros = ((uint)(0u));
			this.vHor.Name = "vHor";
			this.vHor.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vHor.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vHor.Suffix = " h";
			this.vHor.TagName = "STS_HORIMETRO_HORA";
			this.vHor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vHor.EndInit();
			// 
			// tituloComando
			// 
			this.tituloComando.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloComando.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloComando.Location = new NxtControl.Drawing.PointF(20D, 110D);
			this.tituloComando.Name = "tituloComando";
			this.tituloComando.Text = "Comando manual";
			// 
			// btnDesligar
			// 
			this.btnDesligar.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(132D)), ((float)(150D)), ((float)(34D)));
			this.btnDesligar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesligar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnDesligar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesligar.Name = "btnDesligar";
			this.btnDesligar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesligar.Radius = 2D;
			this.btnDesligar.Text = "Desligar";
			this.btnDesligar.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesligar.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnDesligar.Use3DEffect = false;
			this.btnDesligar.Click += new System.EventHandler(this.BtnDesligarClick);
			// 
			// btnLigar
			// 
			this.btnLigar.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(132D)), ((float)(150D)), ((float)(34D)));
			this.btnLigar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLigar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnLigar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLigar.Name = "btnLigar";
			this.btnLigar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLigar.Radius = 2D;
			this.btnLigar.Text = "Ligar";
			this.btnLigar.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigar.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnLigar.Use3DEffect = false;
			this.btnLigar.Click += new System.EventHandler(this.BtnLigarClick);
			// 
			// tituloInt
			// 
			this.tituloInt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloInt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloInt.Location = new NxtControl.Drawing.PointF(20D, 180D);
			this.tituloInt.Name = "tituloInt";
			this.tituloInt.Text = "Intermitente";
			this.tituloInt.Visible = false;
			// 
			// btnIntOff
			// 
			this.btnIntOff.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(202D)), ((float)(150D)), ((float)(34D)));
			this.btnIntOff.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnIntOff.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnIntOff.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnIntOff.Name = "btnIntOff";
			this.btnIntOff.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnIntOff.Radius = 2D;
			this.btnIntOff.Text = "Contínuo";
			this.btnIntOff.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnIntOff.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnIntOff.Use3DEffect = false;
			this.btnIntOff.Visible = false;
			this.btnIntOff.Click += new System.EventHandler(this.BtnIntOffClick);
			// 
			// btnIntOn
			// 
			this.btnIntOn.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(202D)), ((float)(150D)), ((float)(34D)));
			this.btnIntOn.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnIntOn.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnIntOn.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnIntOn.Name = "btnIntOn";
			this.btnIntOn.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnIntOn.Radius = 2D;
			this.btnIntOn.Text = "Intermitente";
			this.btnIntOn.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnIntOn.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnIntOn.Use3DEffect = false;
			this.btnIntOn.Visible = false;
			this.btnIntOn.Click += new System.EventHandler(this.BtnIntOnClick);
			// 
			// tituloRev
			// 
			this.tituloRev.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloRev.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloRev.Location = new NxtControl.Drawing.PointF(20D, 250D);
			this.tituloRev.Name = "tituloRev";
			this.tituloRev.Text = "Reversão";
			this.tituloRev.Visible = false;
			// 
			// btnRevOff
			// 
			this.btnRevOff.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(272D)), ((float)(150D)), ((float)(34D)));
			this.btnRevOff.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnRevOff.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnRevOff.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnRevOff.Name = "btnRevOff";
			this.btnRevOff.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnRevOff.Radius = 2D;
			this.btnRevOff.Text = "Desabilitada";
			this.btnRevOff.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnRevOff.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnRevOff.Use3DEffect = false;
			this.btnRevOff.Visible = false;
			this.btnRevOff.Click += new System.EventHandler(this.BtnRevOffClick);
			// 
			// btnRevOn
			// 
			this.btnRevOn.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(272D)), ((float)(150D)), ((float)(34D)));
			this.btnRevOn.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnRevOn.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnRevOn.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnRevOn.Name = "btnRevOn";
			this.btnRevOn.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnRevOn.Radius = 2D;
			this.btnRevOn.Text = "Habilitada";
			this.btnRevOn.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnRevOn.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnRevOn.Use3DEffect = false;
			this.btnRevOn.Visible = false;
			this.btnRevOn.Click += new System.EventHandler(this.BtnRevOnClick);
			// 
			// tituloVel
			// 
			this.tituloVel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloVel.Location = new NxtControl.Drawing.PointF(20D, 320D);
			this.tituloVel.Name = "tituloVel";
			this.tituloVel.Text = "Velocidade";
			this.tituloVel.Visible = false;
			// 
			// rotVelAtual
			// 
			this.rotVelAtual.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rotVelAtual.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotVelAtual.Location = new NxtControl.Drawing.PointF(20D, 348D);
			this.rotVelAtual.Name = "rotVelAtual";
			this.rotVelAtual.Text = "Atual";
			this.rotVelAtual.Visible = false;
			// 
			// vVel
			// 
			this.vVel.BeginInit();
			this.vVel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vVel.DecimalPlacesCount = ((uint)(1u));
			this.vVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 64D, 343D);
			this.vVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vVel.FontScale = false;
			this.vVel.IsOnlyInput = true;
			this.vVel.IsPrefixSuffixOutside = false;
			this.vVel.LeadingZeros = ((uint)(0u));
			this.vVel.Name = "vVel";
			this.vVel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vVel.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.vVel.Suffix = " %";
			this.vVel.TagName = "STS_VELOCIDADE";
			this.vVel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vVel.Visible = false;
			this.vVel.EndInit();
			// 
			// rotVelRef
			// 
			this.rotVelRef.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rotVelRef.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rotVelRef.Location = new NxtControl.Drawing.PointF(170D, 348D);
			this.rotVelRef.Name = "rotVelRef";
			this.rotVelRef.Text = "Ajuste";
			this.rotVelRef.Visible = false;
			// 
			// tVel
			// 
			this.tVel.BeginInit();
			this.tVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 220D, 342D);
			this.tVel.MaximumTag = null;
			this.tVel.MinimumTag = null;
			this.tVel.Name = "tVel";
			this.tVel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tVel.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tVel.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tVel.Suffix = " %";
			this.tVel.TagName = "stpVelocidade";
			this.tVel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tVel.UseInputPad = true;
			this.tVel.Value = 0F;
			this.tVel.Visible = false;
			this.tVel.EndInit();
			// 
			// x_anim
			// 
			this.x_anim.BeginInit();
			this.x_anim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_anim.IsOnlyInput = true;
			this.x_anim.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_anim.Name = "x_anim";
			this.x_anim.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_anim.TagName = "STS_ANIMACAO";
			this.x_anim.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_animChanged);
			this.x_anim.EndInit();
			// 
			// x_defeito
			// 
			this.x_defeito.BeginInit();
			this.x_defeito.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_defeito.IsOnlyInput = true;
			this.x_defeito.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_defeito.Name = "x_defeito";
			this.x_defeito.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_defeito.TagName = "STS_DEFEITO";
			this.x_defeito.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_defeitoChanged);
			this.x_defeito.EndInit();
			// 
			// x_auto
			// 
			this.x_auto.BeginInit();
			this.x_auto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_auto.IsOnlyInput = true;
			this.x_auto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_auto.Name = "x_auto";
			this.x_auto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_auto.TagName = "STS_AUTOMATICO_SUBSISTEMA";
			this.x_auto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoChanged);
			this.x_auto.EndInit();
			// 
			// x_fbLiga
			// 
			this.x_fbLiga.BeginInit();
			this.x_fbLiga.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_fbLiga.IsOnlyInput = true;
			this.x_fbLiga.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_fbLiga.Name = "x_fbLiga";
			this.x_fbLiga.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_fbLiga.TagName = "fbkCmdLigaManual";
			this.x_fbLiga.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_fbLigaChanged);
			this.x_fbLiga.EndInit();
			// 
			// x_fbInt
			// 
			this.x_fbInt.BeginInit();
			this.x_fbInt.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_fbInt.IsOnlyInput = true;
			this.x_fbInt.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_fbInt.Name = "x_fbInt";
			this.x_fbInt.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_fbInt.TagName = "fbkCmdLigaIntermitente";
			this.x_fbInt.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_fbIntChanged);
			this.x_fbInt.EndInit();
			// 
			// x_fbRev
			// 
			this.x_fbRev.BeginInit();
			this.x_fbRev.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_fbRev.IsOnlyInput = true;
			this.x_fbRev.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_fbRev.Name = "x_fbRev";
			this.x_fbRev.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_fbRev.TagName = "fbkHabilitaReversao";
			this.x_fbRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_fbRevChanged);
			this.x_fbRev.EndInit();
			// 
			// x_cfgVel
			// 
			this.x_cfgVel.BeginInit();
			this.x_cfgVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_cfgVel.IsOnlyInput = true;
			this.x_cfgVel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_cfgVel.Name = "x_cfgVel";
			this.x_cfgVel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_cfgVel.TagName = "CFG_VELOCIDADE";
			this.x_cfgVel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_cfgVelChanged);
			this.x_cfgVel.EndInit();
			// 
			// x_cfgInt
			// 
			this.x_cfgInt.BeginInit();
			this.x_cfgInt.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_cfgInt.IsOnlyInput = true;
			this.x_cfgInt.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_cfgInt.Name = "x_cfgInt";
			this.x_cfgInt.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_cfgInt.TagName = "CFG_INTERMITENTE";
			this.x_cfgInt.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_cfgIntChanged);
			this.x_cfgInt.EndInit();
			// 
			// x_cfgRev
			// 
			this.x_cfgRev.BeginInit();
			this.x_cfgRev.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_cfgRev.IsOnlyInput = true;
			this.x_cfgRev.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_cfgRev.Name = "x_cfgRev";
			this.x_cfgRev.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_cfgRev.TagName = "CFG_REVERSAO";
			this.x_cfgRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_cfgRevChanged);
			this.x_cfgRev.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(386D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.caixaEstado,
			this.textoEstado,
			this.textoModo,
			this.rotHor,
			this.vHor,
			this.tituloComando,
			this.btnDesligar,
			this.btnLigar,
			this.tituloInt,
			this.btnIntOff,
			this.btnIntOn,
			this.tituloRev,
			this.btnRevOff,
			this.btnRevOn,
			this.tituloVel,
			this.rotVelAtual,
			this.vVel,
			this.rotVelRef,
			this.tVel,
			this.x_anim,
			this.x_defeito,
			this.x_auto,
			this.x_fbLiga,
			this.x_fbInt,
			this.x_fbRev,
			this.x_cfgVel,
			this.x_cfgInt,
			this.x_cfgRev});
			this.Size = new System.Drawing.Size(360, 386);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle caixaEstado;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.FreeText textoModo;
		private NxtControl.GuiFramework.FreeText rotHor;
		private System.HMI.Symbols.Base.Label<System.Int32> vHor;
		private NxtControl.GuiFramework.FreeText tituloComando;
		private NxtControl.GuiFramework.DrawnButton btnDesligar;
		private NxtControl.GuiFramework.DrawnButton btnLigar;
		private NxtControl.GuiFramework.FreeText tituloInt;
		private NxtControl.GuiFramework.DrawnButton btnIntOff;
		private NxtControl.GuiFramework.DrawnButton btnIntOn;
		private NxtControl.GuiFramework.FreeText tituloRev;
		private NxtControl.GuiFramework.DrawnButton btnRevOff;
		private NxtControl.GuiFramework.DrawnButton btnRevOn;
		private NxtControl.GuiFramework.FreeText tituloVel;
		private NxtControl.GuiFramework.FreeText rotVelAtual;
		private System.HMI.Symbols.Base.Label<System.Single> vVel;
		private NxtControl.GuiFramework.FreeText rotVelRef;
		private System.HMI.Symbols.Base.TextBox<float> tVel;
		private System.HMI.Symbols.Base.Execute<short> x_anim;
		private System.HMI.Symbols.Base.Execute<bool> x_defeito;
		private System.HMI.Symbols.Base.Execute<bool> x_auto;
		private System.HMI.Symbols.Base.Execute<bool> x_fbLiga;
		private System.HMI.Symbols.Base.Execute<bool> x_fbInt;
		private System.HMI.Symbols.Base.Execute<bool> x_fbRev;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgVel;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgInt;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgRev;
		#endregion
	}
}
