/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 14:46
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
{
	/// <summary>
	/// Summary description for sMotor.
	/// </summary>
	partial class sMotor
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
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.Base3R = new NxtControl.GuiFramework.Rectangle();
			this.Base2R = new NxtControl.GuiFramework.Rectangle();
			this.Base1R = new NxtControl.GuiFramework.Rectangle();
			this.falha_comunicacao1 = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.stsProtecaoTermica = new System.HMI.Symbols.Base.Execute<bool>();
			this.stsFalhaComunicacao = new System.HMI.Symbols.Base.Execute<bool>();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.stsRemoto = new System.HMI.Symbols.Base.FreeText<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.unidade_Portecao_Termica1 = new Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica();
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
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(120D)), ((float)(72D)), ((float)(22D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// Base3R
			// 
			this.Base3R.Bounds = new NxtControl.Drawing.RectF(((float)(180D)), ((float)(88D)), ((float)(3D)), ((float)(16D)));
			this.Base3R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base3R.Name = "Base3R";
			// 
			// Base2R
			// 
			this.Base2R.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(80D)), ((float)(4D)), ((float)(32D)));
			this.Base2R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base2R.Name = "Base2R";
			// 
			// Base1R
			// 
			this.Base1R.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(72D)), ((float)(64D)), ((float)(48D)));
			this.Base1R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base1R.Name = "Base1R";
			// 
			// falha_comunicacao1
			// 
			this.falha_comunicacao1.BeginInit();
			this.falha_comunicacao1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 109D, 45D);
			this.falha_comunicacao1.Name = "falha_comunicacao1";
			this.falha_comunicacao1.EndInit();
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
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(81D)), ((float)(80D)), ((float)(24D)), ((float)(40D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 81D, 81D);
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
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 80D, 101D);
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
			this.line2.EndPoint = new NxtControl.Drawing.PointF(105D, 100D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(81D, 100D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.stsRemoto,
			this.fbkStsAutomatico,
			this.line2});
			this.group1.EndInit();
			// 
			// unidade_Portecao_Termica1
			// 
			this.unidade_Portecao_Termica1.BeginInit();
			this.unidade_Portecao_Termica1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.87431816598835133D, 0D, 0D, 0.83268396760795349D, 85D, 37.000000000000007D);
			this.unidade_Portecao_Termica1.Name = "unidade_Portecao_Termica1";
			this.unidade_Portecao_Termica1.EndInit();
			// 
			// sMotor
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsAnimacao,
			this.InstanceName,
			this.Base3R,
			this.Base2R,
			this.Base1R,
			this.falha_comunicacao1,
			this.stsProtecaoTermica,
			this.stsFalhaComunicacao,
			this.group1,
			this.unidade_Portecao_Termica1});
			this.SymbolSize = new System.Drawing.Size(256, 200);

		}
		private System.HMI.Symbols.Base.Execute<short> stsAnimacao;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle Base3R;
		private NxtControl.GuiFramework.Rectangle Base2R;
		private NxtControl.GuiFramework.Rectangle Base1R;
		private Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica unidade_Portecao_Termica1;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falha_comunicacao1;
		private System.HMI.Symbols.Base.Execute<bool> stsProtecaoTermica;
		private System.HMI.Symbols.Base.Execute<bool> stsFalhaComunicacao;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private System.HMI.Symbols.Base.FreeText<bool> stsRemoto;
		private System.HMI.Symbols.Base.FreeText<bool> fbkStsAutomatico;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
