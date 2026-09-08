/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/26/2026
 * Time: 1:13 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Equipamento_On_Off
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sValvulaHorizontal
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
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.alarme_icon1 = new Hidryco.HidrycoLib.Graphics.alarme_icon();
			this.falha_comunicacao1 = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.stsFalhaComunicacao = new System.HMI.Symbols.Base.Execute<bool>();
			this.stsRemoto = new System.HMI.Symbols.Base.FreeText<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.Disponibilidade = new NxtControl.GuiFramework.Group();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(136D)), ((float)(96D)), ((float)(24D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
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
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(111.1111111111111D)), ((float)(24D)), ((float)(24.8888888888889D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72D, 111.1111111111111D),
			new NxtControl.Drawing.PointF(72D, 136D),
			new NxtControl.Drawing.PointF(96D, 123.55555555555554D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(96D)), ((float)(111.1111111111111D)), ((float)(24D)), ((float)(24.8888888888889D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(120D, 111.1111111111111D),
			new NxtControl.Drawing.PointF(120D, 136D),
			new NxtControl.Drawing.PointF(96D, 123.55555555555554D)});
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(96D, 123.55555555555557D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(96D, 98.666666666666657D);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(78D)), ((float)(88D)), ((float)(36D)), ((float)(18.666666030883789D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// alarme_icon1
			// 
			this.alarme_icon1.BeginInit();
			this.alarme_icon1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8571428571428571D, 0D, 0D, 0.8571428571428571D, 88D, 56.000000000000007D);
			this.alarme_icon1.Name = "alarme_icon1";
			this.alarme_icon1.EndInit();
			// 
			// falha_comunicacao1
			// 
			this.falha_comunicacao1.BeginInit();
			this.falha_comunicacao1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 56D, 56D);
			this.falha_comunicacao1.Name = "falha_comunicacao1";
			this.falha_comunicacao1.EndInit();
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
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 121D, 65D);
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
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 85D);
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
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(121D)), ((float)(64D)), ((float)(24D)), ((float)(40D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(145D, 84D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(121D, 84D);
			// 
			// Disponibilidade
			// 
			this.Disponibilidade.BeginInit();
			this.Disponibilidade.Name = "Disponibilidade";
			this.Disponibilidade.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.stsRemoto,
			this.fbkStsAutomatico,
			this.line2});
			this.Disponibilidade.EndInit();
			// 
			// sValvulaHorizontal
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InstanceName,
			this.stsAnimacao,
			this.alarme_icon1,
			this.polygon1,
			this.polygon2,
			this.line1,
			this.rectangle1,
			this.falha_comunicacao1,
			this.stsFalhaComunicacao,
			this.Disponibilidade});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Execute<System.Int16> stsAnimacao;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private Hidryco.HidrycoLib.Graphics.alarme_icon alarme_icon1;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falha_comunicacao1;
		private System.HMI.Symbols.Base.Execute<bool> stsFalhaComunicacao;
		private System.HMI.Symbols.Base.FreeText<bool> stsRemoto;
		private System.HMI.Symbols.Base.FreeText<bool> fbkStsAutomatico;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group Disponibilidade;
		#endregion
	}
}
