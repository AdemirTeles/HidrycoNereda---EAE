/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/5/2026
 * Time: 11:52 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
{
	/// <summary>
	/// Summary description for Comporta.
	/// </summary>
	partial class Comporta
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
			this.aliasDisplayLabel1 = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.freeText_11 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.freeText_12 = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.comporta1 = new Hidryco.HidrycoLib.Graphics.Comporta();
			this.alarme_icon1 = new Hidryco.HidrycoLib.Graphics.alarme_icon();
			this.falha_comunicacao1 = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.stsFalhaComunicacao = new System.HMI.Symbols.Base.Execute<bool>();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.configShowPositioner = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// aliasDisplayLabel1
			// 
			this.aliasDisplayLabel1.AngleIgnore = true;
			this.aliasDisplayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aliasDisplayLabel1.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(8D)), ((float)(128D)), ((float)(24D)));
			this.aliasDisplayLabel1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.aliasDisplayLabel1.CustomInstanceName = null;
			this.aliasDisplayLabel1.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.aliasDisplayLabel1.FontScale = true;
			this.aliasDisplayLabel1.Name = "aliasDisplayLabel1";
			this.aliasDisplayLabel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.aliasDisplayLabel1.Text = "Label";
			this.aliasDisplayLabel1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(119D)), ((float)(68D)), ((float)(24D)), ((float)(40D)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// freeText_11
			// 
			this.freeText_11.BeginInit();
			this.freeText_11.DecimalPlacesCount = ((uint)(2u));
			this.freeText_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 119D, 69D);
			this.freeText_11.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText_11.IsOnlyInput = true;
			this.freeText_11.Name = "freeText_11";
			propertyDictionary2.Add("Text", "L");
			propertyDictionary3.Add("Text", "R");
			this.freeText_11.Ranges.Clear();
			this.freeText_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.freeText_11.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "false");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.freeText_11.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.freeText_11.TagName = "stsRemoto";
			this.freeText_11.TextAngle = 0F;
			this.freeText_11.EndInit();
			// 
			// freeText_12
			// 
			this.freeText_12.BeginInit();
			this.freeText_12.DecimalPlacesCount = ((uint)(2u));
			this.freeText_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 118D, 89D);
			this.freeText_12.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.freeText_12.IsOnlyInput = true;
			this.freeText_12.Name = "freeText_12";
			propertyDictionary5.Add("Text", "M");
			propertyDictionary6.Add("Text", "A");
			this.freeText_12.Ranges.Clear();
			this.freeText_12.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.freeText_12.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Text", "false");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.freeText_12.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.freeText_12.TagName = "fbkStsAutomatico";
			this.freeText_12.TextAngle = 0F;
			this.freeText_12.EndInit();
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(143D, 88D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(119D, 88D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle7,
			this.freeText_11,
			this.freeText_12,
			this.line2});
			this.group2.EndInit();
			// 
			// comporta1
			// 
			this.comporta1.BeginInit();
			this.comporta1.Animacao = 0;
			this.comporta1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5161290322580645D, 0D, 0D, 1.5161290322580649D, 68D, 29.895003780241936D);
			this.comporta1.Name = "comporta1";
			this.comporta1.EndInit();
			// 
			// alarme_icon1
			// 
			this.alarme_icon1.BeginInit();
			this.alarme_icon1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8571428571428571D, 0D, 0D, 0.8571428571428571D, 42D, 37D);
			this.alarme_icon1.Name = "alarme_icon1";
			this.alarme_icon1.EndInit();
			// 
			// falha_comunicacao1
			// 
			this.falha_comunicacao1.BeginInit();
			this.falha_comunicacao1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 42D, 8D);
			this.falha_comunicacao1.Name = "falha_comunicacao1";
			this.falha_comunicacao1.EndInit();
			// 
			// stsAnimacao
			// 
			this.stsAnimacao.BeginInit();
			this.stsAnimacao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsAnimacao.IsOnlyInput = true;
			this.stsAnimacao.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsAnimacao.Name = "stsAnimacao";
			this.stsAnimacao.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsAnimacao.TagName = "stsAnimacao";
			this.stsAnimacao.Value = ((short)(0));
			this.stsAnimacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsAnimacaoValueChanged);
			this.stsAnimacao.EndInit();
			// 
			// stsFalhaComunicacao
			// 
			this.stsFalhaComunicacao.BeginInit();
			this.stsFalhaComunicacao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsFalhaComunicacao.IsOnlyInput = true;
			this.stsFalhaComunicacao.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsFalhaComunicacao.Name = "stsFalhaComunicacao";
			this.stsFalhaComunicacao.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsFalhaComunicacao.TagName = "stsFalhaComunicacao";
			this.stsFalhaComunicacao.Value = false;
			this.stsFalhaComunicacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsFalhaComunicacaoValueChanged);
			this.stsFalhaComunicacao.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSemPosicionar", NxtControl.GuiFramework.MouseButtonType.None));
			this.group1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpPosicionador", NxtControl.GuiFramework.MouseButtonType.None));
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2,
			this.comporta1,
			this.alarme_icon1,
			this.falha_comunicacao1});
			this.group1.Click += new System.EventHandler(this.Group1Click);
			this.group1.EndInit();
			// 
			// configShowPositioner
			// 
			this.configShowPositioner.BeginInit();
			this.configShowPositioner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 74D, 236D);
			this.configShowPositioner.IsOnlyInput = true;
			this.configShowPositioner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.configShowPositioner.Name = "configShowPositioner";
			this.configShowPositioner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.configShowPositioner.TagName = "configShowPositioner";
			this.configShowPositioner.Value = ((short)(0));
			this.configShowPositioner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ConfigShowPositionerValueChanged);
			this.configShowPositioner.EndInit();
			// 
			// Comporta
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.aliasDisplayLabel1,
			this.stsAnimacao,
			this.stsFalhaComunicacao,
			this.group1,
			this.configShowPositioner});
			this.SymbolSize = new System.Drawing.Size(196, 153);

		}
		private NxtControl.GuiFramework.AliasDisplayLabel aliasDisplayLabel1;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falha_comunicacao1;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private System.HMI.Symbols.Base.FreeText<bool> freeText_11;
		private System.HMI.Symbols.Base.FreeText<bool> freeText_12;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group group2;
		private Hidryco.HidrycoLib.Graphics.Comporta comporta1;
		private Hidryco.HidrycoLib.Graphics.alarme_icon alarme_icon1;
		private System.HMI.Symbols.Base.Execute<short> stsAnimacao;
		private System.HMI.Symbols.Base.Execute<bool> stsFalhaComunicacao;
		private NxtControl.GuiFramework.Group group1;
		private System.HMI.Symbols.Base.Execute<short> configShowPositioner;
		#endregion
	}
}
