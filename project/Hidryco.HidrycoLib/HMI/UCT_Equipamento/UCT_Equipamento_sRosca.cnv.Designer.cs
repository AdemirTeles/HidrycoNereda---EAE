/*
 * Hidryco - UCT_Equipamento - sRosca
 * Simbolo da rosca horizontal da UCT no padrao do Motor_Generico (cores HidrycoColors, falha de comunicacao, A/M, nome).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
	/// <summary>
	/// Summary description for sRosca.
	/// </summary>
	partial class sRosca
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.corpo1 = new NxtControl.GuiFramework.Rectangle();
			this.helice0 = new NxtControl.GuiFramework.Line();
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
			this.motor1 = new Hidryco.HidrycoLib.Graphics.Motor();
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
			this.corpo1.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(10D)), ((float)(230D)), ((float)(22D)));
			this.corpo1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(205)), ((byte)(207)), ((byte)(210))));
			this.corpo1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpo1.Name = "corpo1";
			this.corpo1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// helice0
			// 
			this.helice0.EndPoint = new NxtControl.Drawing.PointF(60D, 30D);
			this.helice0.Name = "helice0";
			this.helice0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice0.StartPoint = new NxtControl.Drawing.PointF(52D, 12D);
			// 
			// helice1
			// 
			this.helice1.EndPoint = new NxtControl.Drawing.PointF(74D, 30D);
			this.helice1.Name = "helice1";
			this.helice1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice1.StartPoint = new NxtControl.Drawing.PointF(66D, 12D);
			// 
			// helice2
			// 
			this.helice2.EndPoint = new NxtControl.Drawing.PointF(88D, 30D);
			this.helice2.Name = "helice2";
			this.helice2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice2.StartPoint = new NxtControl.Drawing.PointF(80D, 12D);
			// 
			// helice3
			// 
			this.helice3.EndPoint = new NxtControl.Drawing.PointF(102D, 30D);
			this.helice3.Name = "helice3";
			this.helice3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice3.StartPoint = new NxtControl.Drawing.PointF(94D, 12D);
			// 
			// helice4
			// 
			this.helice4.EndPoint = new NxtControl.Drawing.PointF(116D, 30D);
			this.helice4.Name = "helice4";
			this.helice4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice4.StartPoint = new NxtControl.Drawing.PointF(108D, 12D);
			// 
			// helice5
			// 
			this.helice5.EndPoint = new NxtControl.Drawing.PointF(130D, 30D);
			this.helice5.Name = "helice5";
			this.helice5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice5.StartPoint = new NxtControl.Drawing.PointF(122D, 12D);
			// 
			// helice6
			// 
			this.helice6.EndPoint = new NxtControl.Drawing.PointF(144D, 30D);
			this.helice6.Name = "helice6";
			this.helice6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice6.StartPoint = new NxtControl.Drawing.PointF(136D, 12D);
			// 
			// helice7
			// 
			this.helice7.EndPoint = new NxtControl.Drawing.PointF(158D, 30D);
			this.helice7.Name = "helice7";
			this.helice7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice7.StartPoint = new NxtControl.Drawing.PointF(150D, 12D);
			// 
			// helice8
			// 
			this.helice8.EndPoint = new NxtControl.Drawing.PointF(172D, 30D);
			this.helice8.Name = "helice8";
			this.helice8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice8.StartPoint = new NxtControl.Drawing.PointF(164D, 12D);
			// 
			// helice9
			// 
			this.helice9.EndPoint = new NxtControl.Drawing.PointF(186D, 30D);
			this.helice9.Name = "helice9";
			this.helice9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice9.StartPoint = new NxtControl.Drawing.PointF(178D, 12D);
			// 
			// helice10
			// 
			this.helice10.EndPoint = new NxtControl.Drawing.PointF(200D, 30D);
			this.helice10.Name = "helice10";
			this.helice10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice10.StartPoint = new NxtControl.Drawing.PointF(192D, 12D);
			// 
			// helice11
			// 
			this.helice11.EndPoint = new NxtControl.Drawing.PointF(214D, 30D);
			this.helice11.Name = "helice11";
			this.helice11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice11.StartPoint = new NxtControl.Drawing.PointF(206D, 12D);
			// 
			// helice12
			// 
			this.helice12.EndPoint = new NxtControl.Drawing.PointF(228D, 30D);
			this.helice12.Name = "helice12";
			this.helice12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice12.StartPoint = new NxtControl.Drawing.PointF(220D, 12D);
			// 
			// helice13
			// 
			this.helice13.EndPoint = new NxtControl.Drawing.PointF(242D, 30D);
			this.helice13.Name = "helice13";
			this.helice13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice13.StartPoint = new NxtControl.Drawing.PointF(234D, 12D);
			// 
			// helice14
			// 
			this.helice14.EndPoint = new NxtControl.Drawing.PointF(256D, 30D);
			this.helice14.Name = "helice14";
			this.helice14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice14.StartPoint = new NxtControl.Drawing.PointF(248D, 12D);
			// 
			// helice15
			// 
			this.helice15.EndPoint = new NxtControl.Drawing.PointF(270D, 30D);
			this.helice15.Name = "helice15";
			this.helice15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 0.75F, NxtControl.Drawing.DashStyle.Solid);
			this.helice15.StartPoint = new NxtControl.Drawing.PointF(262D, 12D);
			// 
			// motor1
			// 
			this.motor1.BeginInit();
			this.motor1.Animacao = 0;
			this.motor1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 4D, 8D);
			this.motor1.Name = "motor1";
			this.motor1.EndInit();
			// 
			// caixaAM
			// 
			this.caixaAM.Bounds = new NxtControl.Drawing.RectF(((float)(282D)), ((float)(11D)), ((float)(22D)), ((float)(20D)));
			this.caixaAM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaAM.Name = "caixaAM";
			this.caixaAM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoAM
			// 
			this.textoAM.BeginInit();
			this.textoAM.DecimalPlacesCount = ((uint)(2u));
			this.textoAM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 281D, 12D);
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
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(36D)), ((float)(230D)), ((float)(20D)));
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
			this.textoManut.Location = new NxtControl.Drawing.PointF(46D, 54D);
			this.textoManut.Name = "textoManut";
			this.textoManut.Text = "MANUTENÇÃO";
			this.textoManut.Visible = false;
			// 
			// falhaCom
			// 
			this.falhaCom.BeginInit();
			this.falhaCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 150D, 9D);
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
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(306D)), ((float)(58D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Use3DEffect = false;
			// 
			// sRosca
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.corpo1,
			this.helice0,
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
			this.motor1,
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
			this.SymbolSize = new System.Drawing.Size(354, 200);

		}
		private NxtControl.GuiFramework.Rectangle corpo1;
		private NxtControl.GuiFramework.Line helice0;
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
		private Hidryco.HidrycoLib.Graphics.Motor motor1;
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
