/*
 * Hidryco - UCT_Equipamento - sRoscaInclinada
 * Simbolo da rosca inclinada da UCT no padrao do Motor_Generico (cores HidrycoColors, falha de comunicacao, A/M, nome).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
	/// <summary>
	/// Summary description for sRoscaInclinada.
	/// </summary>
	partial class sRoscaInclinada
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.corpo1 = new NxtControl.GuiFramework.Polygon();
			this.helice1 = new NxtControl.GuiFramework.Line();
			this.helice2 = new NxtControl.GuiFramework.Line();
			this.helice3 = new NxtControl.GuiFramework.Line();
			this.helice4 = new NxtControl.GuiFramework.Line();
			this.helice5 = new NxtControl.GuiFramework.Line();
			this.helice6 = new NxtControl.GuiFramework.Line();
			this.helice7 = new NxtControl.GuiFramework.Line();
			this.helice8 = new NxtControl.GuiFramework.Line();
			this.helice9 = new NxtControl.GuiFramework.Line();
			this.helice10 = new NxtControl.GuiFramework.Line();
			this.helice11 = new NxtControl.GuiFramework.Line();
			this.helice12 = new NxtControl.GuiFramework.Line();
			this.helice13 = new NxtControl.GuiFramework.Line();
			this.helice14 = new NxtControl.GuiFramework.Line();
			this.helice15 = new NxtControl.GuiFramework.Line();
			this.motorEixo = new NxtControl.GuiFramework.Rectangle();
			this.motorFlange = new NxtControl.GuiFramework.Rectangle();
			this.motorCorpo = new NxtControl.GuiFramework.Rectangle();
			this.caixaAM = new NxtControl.GuiFramework.Rectangle();
			this.textoAM = new System.HMI.Symbols.Base.FreeText<bool>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.textoManut = new NxtControl.GuiFramework.FreeText();
			this.falhaCom = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.x_anim = new System.HMI.Symbols.Base.Execute<short>();
			this.x_defeito = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_auto = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbLiga = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbInt = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgVel = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgInt = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// corpo1
			// 
			this.corpo1.Bounds = new NxtControl.Drawing.RectF(((float)(23.0732D)), ((float)(36.2011D)), ((float)(245.85380000000004D)), ((float)(183.5979D)));
			this.corpo1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.corpo1.Closed = true;
			this.corpo1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpo1.Name = "corpo1";
			this.corpo1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.corpo1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(36.9268D, 219.799D),
			new NxtControl.Drawing.PointF(268.927D, 55.7989D),
			new NxtControl.Drawing.PointF(255.073D, 36.2011D),
			new NxtControl.Drawing.PointF(23.0732D, 200.201D)});
			// 
			// helice1
			// 
			this.helice1.EndPoint = new NxtControl.Drawing.PointF(46.3077D, 186.716D);
			this.helice1.Name = "helice1";
			this.helice1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice1.StartPoint = new NxtControl.Drawing.PointF(50.0415D, 207.589D);
			// 
			// helice2
			// 
			this.helice2.EndPoint = new NxtControl.Drawing.PointF(60.8077D, 176.466D);
			this.helice2.Name = "helice2";
			this.helice2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice2.StartPoint = new NxtControl.Drawing.PointF(64.5415D, 197.339D);
			// 
			// helice3
			// 
			this.helice3.EndPoint = new NxtControl.Drawing.PointF(75.3077D, 166.216D);
			this.helice3.Name = "helice3";
			this.helice3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice3.StartPoint = new NxtControl.Drawing.PointF(79.0415D, 187.089D);
			// 
			// helice4
			// 
			this.helice4.EndPoint = new NxtControl.Drawing.PointF(89.8077D, 155.966D);
			this.helice4.Name = "helice4";
			this.helice4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice4.StartPoint = new NxtControl.Drawing.PointF(93.5415D, 176.839D);
			// 
			// helice5
			// 
			this.helice5.EndPoint = new NxtControl.Drawing.PointF(104.308D, 145.716D);
			this.helice5.Name = "helice5";
			this.helice5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice5.StartPoint = new NxtControl.Drawing.PointF(108.041D, 166.589D);
			// 
			// helice6
			// 
			this.helice6.EndPoint = new NxtControl.Drawing.PointF(118.808D, 135.466D);
			this.helice6.Name = "helice6";
			this.helice6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice6.StartPoint = new NxtControl.Drawing.PointF(122.541D, 156.339D);
			// 
			// helice7
			// 
			this.helice7.EndPoint = new NxtControl.Drawing.PointF(133.308D, 125.216D);
			this.helice7.Name = "helice7";
			this.helice7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice7.StartPoint = new NxtControl.Drawing.PointF(137.041D, 146.089D);
			// 
			// helice8
			// 
			this.helice8.EndPoint = new NxtControl.Drawing.PointF(147.808D, 114.966D);
			this.helice8.Name = "helice8";
			this.helice8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice8.StartPoint = new NxtControl.Drawing.PointF(151.541D, 135.839D);
			// 
			// helice9
			// 
			this.helice9.EndPoint = new NxtControl.Drawing.PointF(162.308D, 104.716D);
			this.helice9.Name = "helice9";
			this.helice9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice9.StartPoint = new NxtControl.Drawing.PointF(166.041D, 125.589D);
			// 
			// helice10
			// 
			this.helice10.EndPoint = new NxtControl.Drawing.PointF(176.808D, 94.4657D);
			this.helice10.Name = "helice10";
			this.helice10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice10.StartPoint = new NxtControl.Drawing.PointF(180.541D, 115.339D);
			// 
			// helice11
			// 
			this.helice11.EndPoint = new NxtControl.Drawing.PointF(191.308D, 84.2157D);
			this.helice11.Name = "helice11";
			this.helice11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice11.StartPoint = new NxtControl.Drawing.PointF(195.041D, 105.089D);
			// 
			// helice12
			// 
			this.helice12.EndPoint = new NxtControl.Drawing.PointF(205.808D, 73.9657D);
			this.helice12.Name = "helice12";
			this.helice12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice12.StartPoint = new NxtControl.Drawing.PointF(209.541D, 94.8391D);
			// 
			// helice13
			// 
			this.helice13.EndPoint = new NxtControl.Drawing.PointF(220.308D, 63.7157D);
			this.helice13.Name = "helice13";
			this.helice13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice13.StartPoint = new NxtControl.Drawing.PointF(224.041D, 84.5891D);
			// 
			// helice14
			// 
			this.helice14.EndPoint = new NxtControl.Drawing.PointF(234.808D, 53.4657D);
			this.helice14.Name = "helice14";
			this.helice14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice14.StartPoint = new NxtControl.Drawing.PointF(238.541D, 74.3391D);
			// 
			// helice15
			// 
			this.helice15.EndPoint = new NxtControl.Drawing.PointF(249.308D, 43.2157D);
			this.helice15.Name = "helice15";
			this.helice15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice15.StartPoint = new NxtControl.Drawing.PointF(253.041D, 64.0891D);
			// 
			// motorEixo
			// 
			this.motorEixo.Bounds = new NxtControl.Drawing.RectF(((float)(262D)), ((float)(42.400001525878906D)), ((float)(2.4000000953674316D)), ((float)(7.1999998092651367D)));
			this.motorEixo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.motorEixo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.motorEixo.Name = "motorEixo";
			this.motorEixo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// motorFlange
			// 
			this.motorFlange.Bounds = new NxtControl.Drawing.RectF(((float)(264.39999389648438D)), ((float)(37.200000762939453D)), ((float)(3.2000000476837158D)), ((float)(17.600000381469727D)));
			this.motorFlange.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.motorFlange.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.motorFlange.Name = "motorFlange";
			this.motorFlange.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// motorCorpo
			// 
			this.motorCorpo.Bounds = new NxtControl.Drawing.RectF(((float)(267.60000610351563D)), ((float)(32.799999237060547D)), ((float)(35.200000762939453D)), ((float)(26.399999618530273D)));
			this.motorCorpo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.motorCorpo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.motorCorpo.Name = "motorCorpo";
			this.motorCorpo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaAM
			// 
			this.caixaAM.Bounds = new NxtControl.Drawing.RectF(((float)(180D)), ((float)(30D)), ((float)(22D)), ((float)(20D)));
			this.caixaAM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaAM.Name = "caixaAM";
			this.caixaAM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoAM
			// 
			this.textoAM.BeginInit();
			this.textoAM.DecimalPlacesCount = ((uint)(2u));
			this.textoAM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 178D, 31D);
			this.textoAM.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.textoAM.IsOnlyInput = true;
			this.textoAM.Name = "textoAM";
			propertyDictionary2.Add("Text", "M");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Text", "A");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.textoAM.Ranges.Clear();
			this.textoAM.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.textoAM.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "-");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.textoAM.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.textoAM.TagName = "STS_AUTOMATICO_SUBSISTEMA";
			this.textoAM.TextAngle = 0F;
			this.textoAM.EndInit();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(110D)), ((float)(190D)), ((float)(180D)), ((float)(20D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			// 
			// textoManut
			// 
			this.textoManut.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoManut.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.textoManut.Location = new NxtControl.Drawing.PointF(110D, 208D);
			this.textoManut.Name = "textoManut";
			this.textoManut.Text = "MANUTENÇÃO";
			this.textoManut.Visible = false;
			// 
			// falhaCom
			// 
			this.falhaCom.BeginInit();
			this.falhaCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 140D, 112D);
			this.falhaCom.Name = "falhaCom";
			this.falhaCom.Visible = false;
			this.falhaCom.EndInit();
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
			this.x_anim.Value = ((short)(0));
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
			this.x_defeito.Value = false;
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
			this.x_auto.Value = false;
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
			this.x_fbLiga.Value = false;
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
			this.x_fbInt.Value = false;
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
			this.x_fbRev.Value = false;
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
			this.x_cfgVel.Value = false;
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
			this.x_cfgInt.Value = false;
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
			this.x_cfgRev.Value = false;
			this.x_cfgRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_cfgRevChanged);
			this.x_cfgRev.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(310D)), ((float)(214D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Use3DEffect = false;
			// 
			// sRoscaInclinada
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.corpo1,
			this.helice1,
			this.helice2,
			this.helice3,
			this.helice4,
			this.helice5,
			this.helice6,
			this.helice7,
			this.helice8,
			this.helice9,
			this.helice10,
			this.helice11,
			this.helice12,
			this.helice13,
			this.helice14,
			this.helice15,
			this.motorEixo,
			this.motorFlange,
			this.motorCorpo,
			this.caixaAM,
			this.textoAM,
			this.InstanceName,
			this.textoManut,
			this.falhaCom,
			this.x_anim,
			this.x_defeito,
			this.x_auto,
			this.x_fbLiga,
			this.x_fbInt,
			this.x_fbRev,
			this.x_cfgVel,
			this.x_cfgInt,
			this.x_cfgRev,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(310, 214);

		}
		private NxtControl.GuiFramework.Polygon corpo1;
		private NxtControl.GuiFramework.Line helice1;
		private NxtControl.GuiFramework.Line helice2;
		private NxtControl.GuiFramework.Line helice3;
		private NxtControl.GuiFramework.Line helice4;
		private NxtControl.GuiFramework.Line helice5;
		private NxtControl.GuiFramework.Line helice6;
		private NxtControl.GuiFramework.Line helice7;
		private NxtControl.GuiFramework.Line helice8;
		private NxtControl.GuiFramework.Line helice9;
		private NxtControl.GuiFramework.Line helice10;
		private NxtControl.GuiFramework.Line helice11;
		private NxtControl.GuiFramework.Line helice12;
		private NxtControl.GuiFramework.Line helice13;
		private NxtControl.GuiFramework.Line helice14;
		private NxtControl.GuiFramework.Line helice15;
		private NxtControl.GuiFramework.Rectangle motorEixo;
		private NxtControl.GuiFramework.Rectangle motorFlange;
		private NxtControl.GuiFramework.Rectangle motorCorpo;
		private NxtControl.GuiFramework.Rectangle caixaAM;
		private System.HMI.Symbols.Base.FreeText<bool> textoAM;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.FreeText textoManut;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falhaCom;
		private System.HMI.Symbols.Base.Execute<short> x_anim;
		private System.HMI.Symbols.Base.Execute<bool> x_defeito;
		private System.HMI.Symbols.Base.Execute<bool> x_auto;
		private System.HMI.Symbols.Base.Execute<bool> x_fbLiga;
		private System.HMI.Symbols.Base.Execute<bool> x_fbInt;
		private System.HMI.Symbols.Base.Execute<bool> x_fbRev;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgVel;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgInt;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgRev;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
