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

namespace Hidryco.HidrycoLib.Symbols.Motor_Inversor_Automatico_Unico
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sSoprador
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
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.falha_comunicacao1 = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.stsProtecaoTermica = new System.HMI.Symbols.Base.Execute<bool>();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.stsRemoto = new System.HMI.Symbols.Base.FreeText<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.unidade_Portecao_Termica1 = new Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica();
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
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(67.428573608398438D)), ((float)(122.47058868408203D)), ((float)(60.9523811340332D)), ((float)(15.529411315917969D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(82.666668891906738D, 124.41176509857178D),
			new NxtControl.Drawing.PointF(67.428573608398438D, 138D),
			new NxtControl.Drawing.PointF(128.38095474243164D, 138D),
			new NxtControl.Drawing.PointF(113.14285945892334D, 122.47058868408203D)});
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(67.428573608398438D)), ((float)(72D)), ((float)(60.9523811340332D)), ((float)(62.117645263671875D)));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(63D)), ((float)(140D)), ((float)(89D)), ((float)(22D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// falha_comunicacao1
			// 
			this.falha_comunicacao1.BeginInit();
			this.falha_comunicacao1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 43D, 64D);
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
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(69D)), ((float)(64D)), ((float)(15.529411315917969D)), ((float)(44.476188659667969D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(131D)), ((float)(84D)), ((float)(24D)), ((float)(40D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 131D, 85D);
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
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 130D, 105D);
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
			this.line2.EndPoint = new NxtControl.Drawing.PointF(155D, 104D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(131D, 104D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.stsRemoto,
			this.fbkStsAutomatico,
			this.line2});
			this.group1.EndInit();
			// 
			// unidade_Portecao_Termica1
			// 
			this.unidade_Portecao_Termica1.BeginInit();
			this.unidade_Portecao_Termica1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.87431816598835133D, 0D, 0D, 0.83268396760795349D, 45D, 95D);
			this.unidade_Portecao_Termica1.Name = "unidade_Portecao_Termica1";
			this.unidade_Portecao_Termica1.EndInit();
			// 
			// sSoprador
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsFalhaComunicacao,
			this.stsAnimacao,
			this.InstanceName,
			this.falha_comunicacao1,
			this.stsProtecaoTermica,
			this.polygon1,
			this.rectangle2,
			this.ellipse1,
			this.group1,
			this.unidade_Portecao_Termica1});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Execute<bool> stsFalhaComunicacao;
		private System.HMI.Symbols.Base.Execute<System.Int16> stsAnimacao;
		private Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica unidade_Portecao_Termica1;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falha_comunicacao1;
		private System.HMI.Symbols.Base.Execute<bool> stsProtecaoTermica;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.FreeText<bool> stsRemoto;
		private System.HMI.Symbols.Base.FreeText<bool> fbkStsAutomatico;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
