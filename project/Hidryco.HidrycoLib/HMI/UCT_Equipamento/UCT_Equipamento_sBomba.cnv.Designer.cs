/*
 * Hidryco - UCT_Equipamento - sBomba
 * Simbolo da bomba da UCT no padrao do Motor_Generico (cores HidrycoColors, falha de comunicacao, A/M, nome).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
	/// <summary>
	/// Summary description for sBomba.
	/// </summary>
	partial class sBomba
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.bomba1 = new Hidryco.HidrycoLib.Graphics.Bomba();
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
			// bomba1
			// 
			this.bomba1.BeginInit();
			this.bomba1.Animacao = 0;
			this.bomba1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.25D, 0D, 0D, 1.25D, 10D, 10D);
			this.bomba1.Name = "bomba1";
			this.bomba1.EndInit();
			// 
			// caixaAM
			// 
			this.caixaAM.Bounds = new NxtControl.Drawing.RectF(((float)(86D)), ((float)(40D)), ((float)(22D)), ((float)(20D)));
			this.caixaAM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaAM.Name = "caixaAM";
			this.caixaAM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoAM
			// 
			this.textoAM.BeginInit();
			this.textoAM.DecimalPlacesCount = ((uint)(2u));
			this.textoAM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 84D, 42D);
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
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(72D)), ((float)(110D)), ((float)(20D)));
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
			this.textoManut.Location = new NxtControl.Drawing.PointF(0D, 90D);
			this.textoManut.Name = "textoManut";
			this.textoManut.Text = "MANUTENÇÃO";
			this.textoManut.Visible = false;
			// 
			// falhaCom
			// 
			this.falhaCom.BeginInit();
			this.falhaCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 33D, 24D);
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
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(110D)), ((float)(94D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Use3DEffect = false;
			// 
			// sBomba
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.bomba1,
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
			this.SymbolSize = new System.Drawing.Size(110, 94);

		}
		private Hidryco.HidrycoLib.Graphics.Bomba bomba1;
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
