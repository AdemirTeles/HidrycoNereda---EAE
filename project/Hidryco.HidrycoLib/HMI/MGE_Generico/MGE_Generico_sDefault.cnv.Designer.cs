/*
 * Hidryco - MGE_Generico - sDefault
 * ISA-101: multimedidor - potencia ativa e reativa, FP, frequencia e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.MGE_Generico
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.rP = new NxtControl.GuiFramework.FreeText();
			this.vP = new System.HMI.Symbols.Base.Label<System.Single>();
			this.rFP = new NxtControl.GuiFramework.FreeText();
			this.vFP = new System.HMI.Symbols.Base.Label<System.Single>();
			this.rQ = new NxtControl.GuiFramework.FreeText();
			this.vQ = new System.HMI.Symbols.Base.Label<System.Single>();
			this.rF = new NxtControl.GuiFramework.FreeText();
			this.vF = new System.HMI.Symbols.Base.Label<System.Single>();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.xACom = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAFPL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVFH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVFL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVNH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVNL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAIAH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAIBH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAICH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAIAL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAIBL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAICL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAFRH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAFRL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECom = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFPL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVFH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVFL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVNH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVNL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEIAH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEIBH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEICH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEIAL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEIBL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEICL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFRH = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFRL = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(86D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(140D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.alP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP1.Name = "alP1";
			this.alP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP1.Visible = false;
			// 
			// alP1n
			// 
			this.alP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.alP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alP1n.Location = new NxtControl.Drawing.PointF(154D, 4D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(150D, 19D),
			new NxtControl.Drawing.PointF(158D, 3D),
			new NxtControl.Drawing.PointF(166D, 19D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(155D, 7D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(170D, 3D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// rP
			// 
			this.rP.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rP.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rP.Location = new NxtControl.Drawing.PointF(8D, 22D);
			this.rP.Name = "rP";
			this.rP.Text = "P";
			// 
			// vP
			// 
			this.vP.BeginInit();
			this.vP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vP.DecimalPlacesCount = ((uint)(1u));
			this.vP.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 1D, 22D, 18D);
			this.vP.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vP.FontScale = false;
			this.vP.IsOnlyInput = true;
			this.vP.IsPrefixSuffixOutside = false;
			this.vP.LeadingZeros = ((uint)(0u));
			this.vP.Name = "vP";
			this.vP.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vP.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vP.Suffix = " kW";
			this.vP.TagName = "STS_POTENCIA_ATIVA_TOTAL";
			this.vP.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vP.EndInit();
			// 
			// rFP
			// 
			this.rFP.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rFP.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rFP.Location = new NxtControl.Drawing.PointF(134D, 22D);
			this.rFP.Name = "rFP";
			this.rFP.Text = "FP";
			// 
			// vFP
			// 
			this.vFP.BeginInit();
			this.vFP.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vFP.DecimalPlacesCount = ((uint)(2u));
			this.vFP.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58D, 0D, 0D, 1D, 156D, 18D);
			this.vFP.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vFP.FontScale = false;
			this.vFP.IsOnlyInput = true;
			this.vFP.IsPrefixSuffixOutside = false;
			this.vFP.LeadingZeros = ((uint)(0u));
			this.vFP.Name = "vFP";
			this.vFP.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vFP.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.vFP.Suffix = "";
			this.vFP.TagName = "STS_FATOR_POTENCIAL_TOTAL";
			this.vFP.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vFP.EndInit();
			// 
			// rQ
			// 
			this.rQ.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rQ.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rQ.Location = new NxtControl.Drawing.PointF(8D, 42D);
			this.rQ.Name = "rQ";
			this.rQ.Text = "Q";
			// 
			// vQ
			// 
			this.vQ.BeginInit();
			this.vQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vQ.DecimalPlacesCount = ((uint)(1u));
			this.vQ.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 1D, 22D, 38D);
			this.vQ.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vQ.FontScale = false;
			this.vQ.IsOnlyInput = true;
			this.vQ.IsPrefixSuffixOutside = false;
			this.vQ.LeadingZeros = ((uint)(0u));
			this.vQ.Name = "vQ";
			this.vQ.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vQ.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.vQ.Suffix = " kVAr";
			this.vQ.TagName = "STS_POTENCIA_REATIVA_TOTAL";
			this.vQ.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vQ.EndInit();
			// 
			// rF
			// 
			this.rF.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rF.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rF.Location = new NxtControl.Drawing.PointF(134D, 42D);
			this.rF.Name = "rF";
			this.rF.Text = "f";
			// 
			// vF
			// 
			this.vF.BeginInit();
			this.vF.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vF.DecimalPlacesCount = ((uint)(0u));
			this.vF.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58D, 0D, 0D, 1D, 156D, 38D);
			this.vF.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vF.FontScale = false;
			this.vF.IsOnlyInput = true;
			this.vF.IsPrefixSuffixOutside = false;
			this.vF.LeadingZeros = ((uint)(0u));
			this.vF.Name = "vF";
			this.vF.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vF.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.vF.Suffix = " Hz";
			this.vF.TagName = "STS_FREQUENCIA";
			this.vF.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vF.EndInit();
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(8D, 62D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "normal";
			// 
			// xACom
			// 
			this.xACom.BeginInit();
			this.xACom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xACom.IsOnlyInput = true;
			this.xACom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xACom.Name = "xACom";
			this.xACom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xACom.TagName = "STS_FALHA_COMUNICACAO";
			this.xACom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AComValueChanged);
			this.xACom.EndInit();
			// 
			// xAFPL
			// 
			this.xAFPL.BeginInit();
			this.xAFPL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAFPL.IsOnlyInput = true;
			this.xAFPL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAFPL.Name = "xAFPL";
			this.xAFPL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAFPL.TagName = "STS_ALARME_FP_BAIXO";
			this.xAFPL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AFPLValueChanged);
			this.xAFPL.EndInit();
			// 
			// xAVFH
			// 
			this.xAVFH.BeginInit();
			this.xAVFH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVFH.IsOnlyInput = true;
			this.xAVFH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVFH.Name = "xAVFH";
			this.xAVFH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVFH.TagName = "STS_ALARME_TENSAO_FF_H";
			this.xAVFH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AVFHValueChanged);
			this.xAVFH.EndInit();
			// 
			// xAVFL
			// 
			this.xAVFL.BeginInit();
			this.xAVFL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVFL.IsOnlyInput = true;
			this.xAVFL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVFL.Name = "xAVFL";
			this.xAVFL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVFL.TagName = "STS_ALARME_TENSAO_FF_L";
			this.xAVFL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AVFLValueChanged);
			this.xAVFL.EndInit();
			// 
			// xAVNH
			// 
			this.xAVNH.BeginInit();
			this.xAVNH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVNH.IsOnlyInput = true;
			this.xAVNH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVNH.Name = "xAVNH";
			this.xAVNH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVNH.TagName = "STS_ALARME_TENSAO_FN_H";
			this.xAVNH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AVNHValueChanged);
			this.xAVNH.EndInit();
			// 
			// xAVNL
			// 
			this.xAVNL.BeginInit();
			this.xAVNL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVNL.IsOnlyInput = true;
			this.xAVNL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVNL.Name = "xAVNL";
			this.xAVNL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVNL.TagName = "STS_ALARME_TENSAO_FN_L";
			this.xAVNL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AVNLValueChanged);
			this.xAVNL.EndInit();
			// 
			// xAIAH
			// 
			this.xAIAH.BeginInit();
			this.xAIAH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAIAH.IsOnlyInput = true;
			this.xAIAH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAIAH.Name = "xAIAH";
			this.xAIAH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAIAH.TagName = "STS_ALARME_CORRENTE_A_H";
			this.xAIAH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AIAHValueChanged);
			this.xAIAH.EndInit();
			// 
			// xAIBH
			// 
			this.xAIBH.BeginInit();
			this.xAIBH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAIBH.IsOnlyInput = true;
			this.xAIBH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAIBH.Name = "xAIBH";
			this.xAIBH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAIBH.TagName = "STS_ALARME_CORRENTE_B_H";
			this.xAIBH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AIBHValueChanged);
			this.xAIBH.EndInit();
			// 
			// xAICH
			// 
			this.xAICH.BeginInit();
			this.xAICH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAICH.IsOnlyInput = true;
			this.xAICH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAICH.Name = "xAICH";
			this.xAICH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAICH.TagName = "STS_ALARME_CORRENTE_C_H";
			this.xAICH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AICHValueChanged);
			this.xAICH.EndInit();
			// 
			// xAIAL
			// 
			this.xAIAL.BeginInit();
			this.xAIAL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAIAL.IsOnlyInput = true;
			this.xAIAL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAIAL.Name = "xAIAL";
			this.xAIAL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAIAL.TagName = "STS_ALARME_CORRENTE_A_L";
			this.xAIAL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AIALValueChanged);
			this.xAIAL.EndInit();
			// 
			// xAIBL
			// 
			this.xAIBL.BeginInit();
			this.xAIBL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAIBL.IsOnlyInput = true;
			this.xAIBL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAIBL.Name = "xAIBL";
			this.xAIBL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAIBL.TagName = "STS_ALARME_CORRENTE_B_L";
			this.xAIBL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AIBLValueChanged);
			this.xAIBL.EndInit();
			// 
			// xAICL
			// 
			this.xAICL.BeginInit();
			this.xAICL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAICL.IsOnlyInput = true;
			this.xAICL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAICL.Name = "xAICL";
			this.xAICL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAICL.TagName = "STS_ALARME_CORRENTE_C_L";
			this.xAICL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AICLValueChanged);
			this.xAICL.EndInit();
			// 
			// xAFRH
			// 
			this.xAFRH.BeginInit();
			this.xAFRH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAFRH.IsOnlyInput = true;
			this.xAFRH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAFRH.Name = "xAFRH";
			this.xAFRH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAFRH.TagName = "STS_ALARME_FREQUENCIA_H";
			this.xAFRH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AFRHValueChanged);
			this.xAFRH.EndInit();
			// 
			// xAFRL
			// 
			this.xAFRL.BeginInit();
			this.xAFRL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAFRL.IsOnlyInput = true;
			this.xAFRL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAFRL.Name = "xAFRL";
			this.xAFRL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAFRL.TagName = "STS_ALARME_FREQUENCIA_L";
			this.xAFRL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AFRLValueChanged);
			this.xAFRL.EndInit();
			// 
			// xECom
			// 
			this.xECom.BeginInit();
			this.xECom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECom.IsOnlyInput = true;
			this.xECom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECom.Name = "xECom";
			this.xECom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECom.TagName = "STS_ALM_COMUNICACAO_EST";
			this.xECom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EComValueChanged);
			this.xECom.EndInit();
			// 
			// xEFPL
			// 
			this.xEFPL.BeginInit();
			this.xEFPL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFPL.IsOnlyInput = true;
			this.xEFPL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFPL.Name = "xEFPL";
			this.xEFPL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFPL.TagName = "STS_ALM_FP_BAIXO_EST";
			this.xEFPL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFPLValueChanged);
			this.xEFPL.EndInit();
			// 
			// xEVFH
			// 
			this.xEVFH.BeginInit();
			this.xEVFH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVFH.IsOnlyInput = true;
			this.xEVFH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVFH.Name = "xEVFH";
			this.xEVFH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVFH.TagName = "STS_ALM_TENSAO_FF_H_EST";
			this.xEVFH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EVFHValueChanged);
			this.xEVFH.EndInit();
			// 
			// xEVFL
			// 
			this.xEVFL.BeginInit();
			this.xEVFL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVFL.IsOnlyInput = true;
			this.xEVFL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVFL.Name = "xEVFL";
			this.xEVFL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVFL.TagName = "STS_ALM_TENSAO_FF_L_EST";
			this.xEVFL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EVFLValueChanged);
			this.xEVFL.EndInit();
			// 
			// xEVNH
			// 
			this.xEVNH.BeginInit();
			this.xEVNH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVNH.IsOnlyInput = true;
			this.xEVNH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVNH.Name = "xEVNH";
			this.xEVNH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVNH.TagName = "STS_ALM_TENSAO_FN_H_EST";
			this.xEVNH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EVNHValueChanged);
			this.xEVNH.EndInit();
			// 
			// xEVNL
			// 
			this.xEVNL.BeginInit();
			this.xEVNL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVNL.IsOnlyInput = true;
			this.xEVNL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVNL.Name = "xEVNL";
			this.xEVNL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVNL.TagName = "STS_ALM_TENSAO_FN_L_EST";
			this.xEVNL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EVNLValueChanged);
			this.xEVNL.EndInit();
			// 
			// xEIAH
			// 
			this.xEIAH.BeginInit();
			this.xEIAH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEIAH.IsOnlyInput = true;
			this.xEIAH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEIAH.Name = "xEIAH";
			this.xEIAH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEIAH.TagName = "STS_ALM_CORRENTE_A_H_EST";
			this.xEIAH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EIAHValueChanged);
			this.xEIAH.EndInit();
			// 
			// xEIBH
			// 
			this.xEIBH.BeginInit();
			this.xEIBH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEIBH.IsOnlyInput = true;
			this.xEIBH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEIBH.Name = "xEIBH";
			this.xEIBH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEIBH.TagName = "STS_ALM_CORRENTE_B_H_EST";
			this.xEIBH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EIBHValueChanged);
			this.xEIBH.EndInit();
			// 
			// xEICH
			// 
			this.xEICH.BeginInit();
			this.xEICH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEICH.IsOnlyInput = true;
			this.xEICH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEICH.Name = "xEICH";
			this.xEICH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEICH.TagName = "STS_ALM_CORRENTE_C_H_EST";
			this.xEICH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EICHValueChanged);
			this.xEICH.EndInit();
			// 
			// xEIAL
			// 
			this.xEIAL.BeginInit();
			this.xEIAL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEIAL.IsOnlyInput = true;
			this.xEIAL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEIAL.Name = "xEIAL";
			this.xEIAL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEIAL.TagName = "STS_ALM_CORRENTE_A_L_EST";
			this.xEIAL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EIALValueChanged);
			this.xEIAL.EndInit();
			// 
			// xEIBL
			// 
			this.xEIBL.BeginInit();
			this.xEIBL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEIBL.IsOnlyInput = true;
			this.xEIBL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEIBL.Name = "xEIBL";
			this.xEIBL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEIBL.TagName = "STS_ALM_CORRENTE_B_L_EST";
			this.xEIBL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EIBLValueChanged);
			this.xEIBL.EndInit();
			// 
			// xEICL
			// 
			this.xEICL.BeginInit();
			this.xEICL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEICL.IsOnlyInput = true;
			this.xEICL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEICL.Name = "xEICL";
			this.xEICL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEICL.TagName = "STS_ALM_CORRENTE_C_L_EST";
			this.xEICL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EICLValueChanged);
			this.xEICL.EndInit();
			// 
			// xEFRH
			// 
			this.xEFRH.BeginInit();
			this.xEFRH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFRH.IsOnlyInput = true;
			this.xEFRH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFRH.Name = "xEFRH";
			this.xEFRH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFRH.TagName = "STS_ALM_FREQUENCIA_H_EST";
			this.xEFRH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFRHValueChanged);
			this.xEFRH.EndInit();
			// 
			// xEFRL
			// 
			this.xEFRL.BeginInit();
			this.xEFRL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFRL.IsOnlyInput = true;
			this.xEFRL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFRL.Name = "xEFRL";
			this.xEFRL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFRL.TagName = "STS_ALM_FREQUENCIA_L_EST";
			this.xEFRL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFRLValueChanged);
			this.xEFRL.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(86D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Text = "";
			this.abrir.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.Use3DEffect = false;
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.InstanceName,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.rP,
			this.vP,
			this.rFP,
			this.vFP,
			this.rQ,
			this.vQ,
			this.rF,
			this.vF,
			this.textoEstado,
			this.xACom,
			this.xAFPL,
			this.xAVFH,
			this.xAVFL,
			this.xAVNH,
			this.xAVNL,
			this.xAIAH,
			this.xAIBH,
			this.xAICH,
			this.xAIAL,
			this.xAIBL,
			this.xAICL,
			this.xAFRH,
			this.xAFRL,
			this.xECom,
			this.xEFPL,
			this.xEVFH,
			this.xEVFL,
			this.xEVNH,
			this.xEVNL,
			this.xEIAH,
			this.xEIBH,
			this.xEICH,
			this.xEIAL,
			this.xEIBL,
			this.xEICL,
			this.xEFRH,
			this.xEFRL,
			this.abrir});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText rP;
		private System.HMI.Symbols.Base.Label<System.Single> vP;
		private NxtControl.GuiFramework.FreeText rFP;
		private System.HMI.Symbols.Base.Label<System.Single> vFP;
		private NxtControl.GuiFramework.FreeText rQ;
		private System.HMI.Symbols.Base.Label<System.Single> vQ;
		private NxtControl.GuiFramework.FreeText rF;
		private System.HMI.Symbols.Base.Label<System.Single> vF;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private System.HMI.Symbols.Base.Execute<bool> xACom;
		private System.HMI.Symbols.Base.Execute<bool> xAFPL;
		private System.HMI.Symbols.Base.Execute<bool> xAVFH;
		private System.HMI.Symbols.Base.Execute<bool> xAVFL;
		private System.HMI.Symbols.Base.Execute<bool> xAVNH;
		private System.HMI.Symbols.Base.Execute<bool> xAVNL;
		private System.HMI.Symbols.Base.Execute<bool> xAIAH;
		private System.HMI.Symbols.Base.Execute<bool> xAIBH;
		private System.HMI.Symbols.Base.Execute<bool> xAICH;
		private System.HMI.Symbols.Base.Execute<bool> xAIAL;
		private System.HMI.Symbols.Base.Execute<bool> xAIBL;
		private System.HMI.Symbols.Base.Execute<bool> xAICL;
		private System.HMI.Symbols.Base.Execute<bool> xAFRH;
		private System.HMI.Symbols.Base.Execute<bool> xAFRL;
		private System.HMI.Symbols.Base.Execute<byte> xECom;
		private System.HMI.Symbols.Base.Execute<byte> xEFPL;
		private System.HMI.Symbols.Base.Execute<byte> xEVFH;
		private System.HMI.Symbols.Base.Execute<byte> xEVFL;
		private System.HMI.Symbols.Base.Execute<byte> xEVNH;
		private System.HMI.Symbols.Base.Execute<byte> xEVNL;
		private System.HMI.Symbols.Base.Execute<byte> xEIAH;
		private System.HMI.Symbols.Base.Execute<byte> xEIBH;
		private System.HMI.Symbols.Base.Execute<byte> xEICH;
		private System.HMI.Symbols.Base.Execute<byte> xEIAL;
		private System.HMI.Symbols.Base.Execute<byte> xEIBL;
		private System.HMI.Symbols.Base.Execute<byte> xEICL;
		private System.HMI.Symbols.Base.Execute<byte> xEFRH;
		private System.HMI.Symbols.Base.Execute<byte> xEFRL;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
