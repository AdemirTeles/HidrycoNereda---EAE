/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 04/03/2026
 * Tempo: 12:01
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Compressor
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
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
			this.stsAutomatico_1 = new System.HMI.Symbols.Base.Label<bool>();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.stsDefeito = new System.HMI.Symbols.Base.Execute<bool>();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// stsAutomatico_1
			// 
			this.stsAutomatico_1.BeginInit();
			this.stsAutomatico_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsAutomatico_1.DecimalPlacesCount = ((uint)(2u));
			this.stsAutomatico_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.74666666666666659D, 0D, 0D, 0.76190476190476186D, 144D, 88D);
			this.stsAutomatico_1.Font = new NxtControl.Drawing.Font("HMI Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.stsAutomatico_1.FontScale = false;
			this.stsAutomatico_1.IsOnlyInput = true;
			this.stsAutomatico_1.LeadingZeros = ((uint)(0u));
			this.stsAutomatico_1.Name = "stsAutomatico_1";
			this.stsAutomatico_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "Manual");
			propertyDictionary3.Add("Text", "Automatico");
			this.stsAutomatico_1.Ranges.Clear();
			this.stsAutomatico_1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.stsAutomatico_1.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "Manual");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsAutomatico_1.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsAutomatico_1.TagName = "STS_AUTOMATICO_SUBSISTEMA";
			this.stsAutomatico_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stsAutomatico_1.EndInit();
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
			this.stsAnimacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.STS_ANIMACAOValueChanged);
			this.stsAnimacao.EndInit();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(40D)), ((float)(72D)), ((float)(22D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// stsDefeito
			// 
			this.stsDefeito.BeginInit();
			this.stsDefeito.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsDefeito.IsOnlyInput = true;
			this.stsDefeito.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsDefeito.Name = "stsDefeito";
			this.stsDefeito.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsDefeito.TagName = "STS_DEFEITO";
			this.stsDefeito.Value = false;
			this.stsDefeito.EndInit();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(72D)), ((float)(88D)), ((float)(48D)));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(120D, 120D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(120D, 72D);
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(80D)), ((float)(8D)), ((float)(8D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(96D)), ((float)(16D)), ((float)(16D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(76D)), ((float)(112D)), ((float)(40D)), ((float)(16D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(76D, 112D),
			new NxtControl.Drawing.PointF(76D, 128D),
			new NxtControl.Drawing.PointF(116D, 128D),
			new NxtControl.Drawing.PointF(116D, 120D),
			new NxtControl.Drawing.PointF(84D, 120D),
			new NxtControl.Drawing.PointF(84D, 112D)});
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("Faceplate1", NxtControl.GuiFramework.MouseButtonType.Click));
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsAutomatico_1,
			this.InstanceName,
			this.roundedRectangle1,
			this.line1,
			this.rectangle1,
			this.rectangle2,
			this.polygon1});
			this.group1.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsAnimacao,
			this.stsDefeito,
			this.group1});
			this.SymbolSize = new System.Drawing.Size(288, 224);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.Label<bool> stsAutomatico_1;
		private System.HMI.Symbols.Base.Execute<short> stsAnimacao;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Execute<bool> stsDefeito;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
