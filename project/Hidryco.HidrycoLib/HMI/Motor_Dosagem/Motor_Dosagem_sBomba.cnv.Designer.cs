/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/22/2026
 * Time: 5:25 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Dosagem
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sBomba
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.stsFalhaComunicacao = new System.HMI.Symbols.Base.Execute<bool>();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.stsProtecaoTermica = new System.HMI.Symbols.Base.Execute<bool>();
			this.bomba1 = new Hidryco.HidrycoLib.Graphics.Bomba();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.stsRemoto = new System.HMI.Symbols.Base.FreeText<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.aliasDisplayLabel1 = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.falha_comunicacao1 = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.unidade_Portecao_Termica1 = new Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica();
			this.energizado_por_Gerador1 = new Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador();
			// 
			// stsFalhaComunicacao
			// 
			this.stsFalhaComunicacao.BeginInit();
			this.stsFalhaComunicacao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsFalhaComunicacao.IsOnlyInput = true;
			this.stsFalhaComunicacao.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsFalhaComunicacao.Name = "stsFalhaComunicacao";
			this.stsFalhaComunicacao.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsFalhaComunicacao.TagName = "STS_FALHA_COMUNICACAO";
			this.stsFalhaComunicacao.Value = false;
			this.stsFalhaComunicacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsFalhaComunicacaoValueChanged);
			this.stsFalhaComunicacao.EndInit();
			// 
			// stsAnimacao
			// 
			this.stsAnimacao.BeginInit();
			this.stsAnimacao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsAnimacao.IsOnlyInput = true;
			this.stsAnimacao.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsAnimacao.Name = "stsAnimacao";
			this.stsAnimacao.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsAnimacao.TagName = "STS_ANIMACAO";
			this.stsAnimacao.Value = ((short)(0));
			this.stsAnimacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsAnimacaoValueChanged);
			this.stsAnimacao.EndInit();
			// 
			// stsProtecaoTermica
			// 
			this.stsProtecaoTermica.BeginInit();
			this.stsProtecaoTermica.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsProtecaoTermica.IsOnlyInput = true;
			this.stsProtecaoTermica.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsProtecaoTermica.Name = "stsProtecaoTermica";
			this.stsProtecaoTermica.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsProtecaoTermica.TagName = "STS_PROTECAO_TERMICA";
			this.stsProtecaoTermica.Value = false;
			this.stsProtecaoTermica.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsProtecaoTermicaValueChanged);
			this.stsProtecaoTermica.EndInit();
			// 
			// bomba1
			// 
			this.bomba1.BeginInit();
			this.bomba1.Animacao = 0;
			this.bomba1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.375D, 0D, 0D, 1.375D, 56D, 68D);
			this.bomba1.Name = "bomba1";
			this.bomba1.EndInit();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(130D)), ((float)(88D)), ((float)(24D)), ((float)(40D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 130D, 89D);
			this.stsRemoto.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsRemoto.IsOnlyInput = true;
			this.stsRemoto.Name = "stsRemoto";
			propertyDictionary2.Add("Text", "L");
			propertyDictionary3.Add("Text", "R");
			this.stsRemoto.Ranges.Clear();
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "false");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.stsRemoto.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsRemoto.TagName = "STS_REMOTO";
			this.stsRemoto.TextAngle = 0F;
			this.stsRemoto.EndInit();
			// 
			// fbkStsAutomatico
			// 
			this.fbkStsAutomatico.BeginInit();
			this.fbkStsAutomatico.DecimalPlacesCount = ((uint)(2u));
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 129D, 109D);
			this.fbkStsAutomatico.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.fbkStsAutomatico.IsOnlyInput = true;
			this.fbkStsAutomatico.Name = "fbkStsAutomatico";
			propertyDictionary5.Add("Text", "M");
			propertyDictionary6.Add("Text", "A");
			this.fbkStsAutomatico.Ranges.Clear();
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Text", "false");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.fbkStsAutomatico.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.fbkStsAutomatico.TagName = "fbkStsAutomatico";
			this.fbkStsAutomatico.TextAngle = 0F;
			this.fbkStsAutomatico.EndInit();
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(154D, 108D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(130D, 108D);
			// 
			// aliasDisplayLabel1
			// 
			this.aliasDisplayLabel1.AngleIgnore = true;
			this.aliasDisplayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aliasDisplayLabel1.Bounds = new NxtControl.Drawing.RectF(((float)(61D)), ((float)(131D)), ((float)(101D)), ((float)(22D)));
			this.aliasDisplayLabel1.Brush = new NxtControl.Drawing.Brush(true);
			this.aliasDisplayLabel1.CustomInstanceName = null;
			this.aliasDisplayLabel1.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.aliasDisplayLabel1.FontScale = true;
			this.aliasDisplayLabel1.Name = "aliasDisplayLabel1";
			this.aliasDisplayLabel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.aliasDisplayLabel1.Text = "Label";
			this.aliasDisplayLabel1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// falha_comunicacao1
			// 
			this.falha_comunicacao1.BeginInit();
			this.falha_comunicacao1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 82D, 43D);
			this.falha_comunicacao1.Name = "falha_comunicacao1";
			this.falha_comunicacao1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.stsRemoto,
			this.fbkStsAutomatico,
			this.line2});
			this.group2.EndInit();
			// 
			// unidade_Portecao_Termica1
			// 
			this.unidade_Portecao_Termica1.BeginInit();
			this.unidade_Portecao_Termica1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.80952380952380953D, 0D, 0D, 0.80952380952380953D, 49D, 60.107373047425682D);
			this.unidade_Portecao_Termica1.Name = "unidade_Portecao_Termica1";
			this.unidade_Portecao_Termica1.EndInit();
			// 
			// energizado_por_Gerador1
			// 
			this.energizado_por_Gerador1.BeginInit();
			this.energizado_por_Gerador1.Animacao = 1;
			this.energizado_por_Gerador1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 109D, 43D);
			this.energizado_por_Gerador1.Name = "energizado_por_Gerador1";
			this.energizado_por_Gerador1.EndInit();
			// 
			// sBomba
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsFalhaComunicacao,
			this.stsAnimacao,
			this.stsProtecaoTermica,
			this.bomba1,
			this.aliasDisplayLabel1,
			this.falha_comunicacao1,
			this.group2,
			this.unidade_Portecao_Termica1,
			this.energizado_por_Gerador1});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private System.HMI.Symbols.Base.Execute<bool> stsFalhaComunicacao;
		private System.HMI.Symbols.Base.Execute<System.Int16> stsAnimacao;
		private Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica unidade_Portecao_Termica1;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falha_comunicacao1;
		private System.HMI.Symbols.Base.Execute<bool> stsProtecaoTermica;
		private Hidryco.HidrycoLib.Graphics.Bomba bomba1;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private System.HMI.Symbols.Base.FreeText<bool> stsRemoto;
		private System.HMI.Symbols.Base.FreeText<bool> fbkStsAutomatico;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.AliasDisplayLabel aliasDisplayLabel1;
		private NxtControl.GuiFramework.Group group2;
		private Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador energizado_por_Gerador1;
		#endregion
	}
}
