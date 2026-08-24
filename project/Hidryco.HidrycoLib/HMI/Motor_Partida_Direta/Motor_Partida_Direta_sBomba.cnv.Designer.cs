/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 19/01/2026
 * Tempo: 09:25
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Partida_Direta
{
	/// <summary>
	/// Summary description for Symbol1.
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.energizado_por_Gerador1 = new Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.stsRemoto = new System.HMI.Symbols.Base.FreeText<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.bomba1 = new Hidryco.HidrycoLib.Graphics.Bomba();
			this.unidade_Portecao_Termica1 = new Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica();
			this.stsProtecaoTermica = new System.HMI.Symbols.Base.Execute<bool>();
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
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(139D)), ((float)(104D)), ((float)(22D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// energizado_por_Gerador1
			// 
			this.energizado_por_Gerador1.BeginInit();
			this.energizado_por_Gerador1.Animacao = 1;
			this.energizado_por_Gerador1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 106D, 51D);
			this.energizado_por_Gerador1.Name = "energizado_por_Gerador1";
			this.energizado_por_Gerador1.EndInit();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(126D)), ((float)(97D)), ((float)(24D)), ((float)(40D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 126D, 98D);
			this.stsRemoto.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsRemoto.IsOnlyInput = true;
			this.stsRemoto.Name = "stsRemoto";
			propertyDictionary8.Add("Text", "L");
			propertyDictionary9.Add("Text", "R");
			this.stsRemoto.Ranges.Clear();
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Text", "false");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.stsRemoto.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.stsRemoto.TagName = "STS_REMOTO";
			this.stsRemoto.TextAngle = 0F;
			this.stsRemoto.EndInit();
			// 
			// fbkStsAutomatico
			// 
			this.fbkStsAutomatico.BeginInit();
			this.fbkStsAutomatico.DecimalPlacesCount = ((uint)(2u));
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 125D, 118D);
			this.fbkStsAutomatico.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.fbkStsAutomatico.IsOnlyInput = true;
			this.fbkStsAutomatico.Name = "fbkStsAutomatico";
			propertyDictionary11.Add("Text", "M");
			propertyDictionary12.Add("Text", "A");
			this.fbkStsAutomatico.Ranges.Clear();
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Text", "false");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.fbkStsAutomatico.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.fbkStsAutomatico.TagName = "fbkStsAutomatico";
			this.fbkStsAutomatico.TextAngle = 0F;
			this.fbkStsAutomatico.EndInit();
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(150D, 117D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(126D, 117D);
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
			// bomba1
			// 
			this.bomba1.BeginInit();
			this.bomba1.Animacao = 0;
			this.bomba1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3392857142857144D, 0D, 0D, 1.3419913419913421D, 55.000000000000014D, 76.55D);
			this.bomba1.Name = "bomba1";
			this.bomba1.EndInit();
			// 
			// unidade_Portecao_Termica1
			// 
			this.unidade_Portecao_Termica1.BeginInit();
			this.unidade_Portecao_Termica1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.80952380952380953D, 0D, 0D, 0.80952380952380953D, 48D, 68.107373047425668D);
			this.unidade_Portecao_Termica1.Name = "unidade_Portecao_Termica1";
			this.unidade_Portecao_Termica1.EndInit();
			// 
			// stsProtecaoTermica
			// 
			this.stsProtecaoTermica.BeginInit();
			this.stsProtecaoTermica.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsProtecaoTermica.IsOnlyInput = true;
			this.stsProtecaoTermica.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsProtecaoTermica.Name = "stsProtecaoTermica";
			this.stsProtecaoTermica.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsProtecaoTermica.TagName = "";
			this.stsProtecaoTermica.Value = false;
			this.stsProtecaoTermica.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsProtecaoTermicaValueChanged);
			this.stsProtecaoTermica.EndInit();
			// 
			// sBomba
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsAnimacao,
			this.InstanceName,
			this.energizado_por_Gerador1,
			this.group2,
			this.bomba1,
			this.unidade_Portecao_Termica1,
			this.stsProtecaoTermica});
			this.SymbolSize = new System.Drawing.Size(188, 190);

		}
		private System.HMI.Symbols.Base.Execute<System.Int16> stsAnimacao;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador energizado_por_Gerador1;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private System.HMI.Symbols.Base.FreeText<bool> stsRemoto;
		private System.HMI.Symbols.Base.FreeText<bool> fbkStsAutomatico;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group group2;
		private Hidryco.HidrycoLib.Graphics.Bomba bomba1;
		private Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica unidade_Portecao_Termica1;
		private System.HMI.Symbols.Base.Execute<bool> stsProtecaoTermica;
		#endregion
	}
}
