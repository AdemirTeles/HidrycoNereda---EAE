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

namespace Hidryco.HidrycoLib.Symbols.Valvula_Saida_Digital
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.aliasDisplayLabel1 = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.alarme_icon1 = new Hidryco.HidrycoLib.Graphics.alarme_icon();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.stsFalhaComunicacao = new System.HMI.Symbols.Base.Execute<bool>();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.stsRemoto = new System.HMI.Symbols.Base.FreeText<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(69D)), ((float)(24D)), ((float)(72D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(87D)), ((float)(52D)), ((float)(10D)), ((float)(17D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(75D)), ((float)(40D)), ((float)(34D)), ((float)(12D)));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(66D)), ((float)(78D)), ((float)(8D)), ((float)(74D)));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(66D)), ((float)(144D)), ((float)(51D)), ((float)(8D)));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(109D)), ((float)(78D)), ((float)(8D)), ((float)(74D)));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// aliasDisplayLabel1
			// 
			this.aliasDisplayLabel1.AngleIgnore = true;
			this.aliasDisplayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aliasDisplayLabel1.Bounds = new NxtControl.Drawing.RectF(((float)(66D)), ((float)(8D)), ((float)(128D)), ((float)(24D)));
			this.aliasDisplayLabel1.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.aliasDisplayLabel1.CustomInstanceName = null;
			this.aliasDisplayLabel1.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.aliasDisplayLabel1.FontScale = true;
			this.aliasDisplayLabel1.Name = "aliasDisplayLabel1";
			this.aliasDisplayLabel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.aliasDisplayLabel1.Text = "Label";
			this.aliasDisplayLabel1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// alarme_icon1
			// 
			this.alarme_icon1.BeginInit();
			this.alarme_icon1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8571428571428571D, 0D, 0D, 0.8571428571428571D, 35D, 8.0000000000000071D);
			this.alarme_icon1.Name = "alarme_icon1";
			this.alarme_icon1.EndInit();
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
			this.stsFalhaComunicacao.Location = new NxtControl.Drawing.PointF(0D, 0D);
			this.stsFalhaComunicacao.Name = "stsFalhaComunicacao";
			this.stsFalhaComunicacao.Size = new NxtControl.Drawing.SizeF(0D, 0D);
			this.stsFalhaComunicacao.TagName = "";
			this.stsFalhaComunicacao.Value = false;
			this.stsFalhaComunicacao.EndInit();
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(124D)), ((float)(34D)), ((float)(24D)), ((float)(40D)));
			this.rectangle7.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 124D, 35D);
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
			this.stsRemoto.TagName = "stsRemoto";
			this.stsRemoto.TextAngle = 0F;
			this.stsRemoto.EndInit();
			// 
			// fbkStsAutomatico
			// 
			this.fbkStsAutomatico.BeginInit();
			this.fbkStsAutomatico.DecimalPlacesCount = ((uint)(2u));
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 123D, 55D);
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
			this.line2.EndPoint = new NxtControl.Drawing.PointF(148D, 54D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(124D, 54D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle7,
			this.stsRemoto,
			this.fbkStsAutomatico,
			this.line2});
			this.group2.EndInit();
			// 
			// Comporta
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.rectangle2,
			this.rectangle3,
			this.rectangle4,
			this.rectangle6,
			this.rectangle5,
			this.aliasDisplayLabel1,
			this.alarme_icon1,
			this.stsAnimacao,
			this.stsFalhaComunicacao,
			this.group2});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.AliasDisplayLabel aliasDisplayLabel1;
		private Hidryco.HidrycoLib.Graphics.alarme_icon alarme_icon1;
		private System.HMI.Symbols.Base.Execute<System.Int16> stsAnimacao;
		private System.HMI.Symbols.Base.Execute<bool> stsFalhaComunicacao;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private System.HMI.Symbols.Base.FreeText<bool> stsRemoto;
		private System.HMI.Symbols.Base.FreeText<bool> fbkStsAutomatico;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
