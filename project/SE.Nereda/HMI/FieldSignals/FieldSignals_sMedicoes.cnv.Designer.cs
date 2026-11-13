/*
 * Hidryco - sMedicoes
 * ISA-101: medicoes do inversor (padrao do Motor_Generico.fpMeasures).
 */
using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
{
	partial class sMedicoes
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			this.lFreq = new NxtControl.GuiFramework.Rectangle();
			this.tFreq = new NxtControl.GuiFramework.FreeText();
			this.vFreq = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lCorr = new NxtControl.GuiFramework.Rectangle();
			this.tCorr = new NxtControl.GuiFramework.FreeText();
			this.vCorr = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lTens = new NxtControl.GuiFramework.Rectangle();
			this.tTens = new NxtControl.GuiFramework.FreeText();
			this.vTens = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lPot = new NxtControl.GuiFramework.Rectangle();
			this.tPot = new NxtControl.GuiFramework.FreeText();
			this.vPot = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lTorq = new NxtControl.GuiFramework.Rectangle();
			this.tTorq = new NxtControl.GuiFramework.FreeText();
			this.vTorq = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lRpm = new NxtControl.GuiFramework.Rectangle();
			this.tRpm = new NxtControl.GuiFramework.FreeText();
			this.vRpm = new System.HMI.Symbols.Base.Label<System.Single>();
			this.vPotKw = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lFalha = new NxtControl.GuiFramework.Rectangle();
			this.tFalha = new NxtControl.GuiFramework.FreeText();
			this.vFalha = new NxtControl.GuiFramework.FreeText();
			this.vFalhaTxt = new NxtControl.GuiFramework.FreeText();
			this.vFalhaTxt2 = new NxtControl.GuiFramework.FreeText();
			// 
			// lFreq
			// 
			this.lFreq.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(296D)), ((float)(30D)));
			this.lFreq.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lFreq.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lFreq.Name = "lFreq";
			this.lFreq.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tFreq
			// 
			this.tFreq.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tFreq.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tFreq.Location = new NxtControl.Drawing.PointF(12D, 6D);
			this.tFreq.Name = "tFreq";
			this.tFreq.Text = "Frequência";
			// 
			// vFreq
			// 
			this.vFreq.BeginInit();
			this.vFreq.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vFreq.DecimalPlacesCount = ((uint)(1u));
			this.vFreq.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 180D, 2D);
			this.vFreq.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vFreq.FontScale = false;
			this.vFreq.IsOnlyInput = true;
			this.vFreq.IsPrefixSuffixOutside = false;
			this.vFreq.LeadingZeros = ((uint)(0u));
			this.vFreq.Name = "vFreq";
			this.vFreq.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vFreq.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vFreq.Suffix = " Hz";
			this.vFreq.TagName = "Frequency";
			this.vFreq.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vFreq.EndInit();
			// 
			// lCorr
			// 
			this.lCorr.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(34D)), ((float)(296D)), ((float)(30D)));
			this.lCorr.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lCorr.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lCorr.Name = "lCorr";
			this.lCorr.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tCorr
			// 
			this.tCorr.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tCorr.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tCorr.Location = new NxtControl.Drawing.PointF(12D, 40D);
			this.tCorr.Name = "tCorr";
			this.tCorr.Text = "Corrente";
			// 
			// vCorr
			// 
			this.vCorr.BeginInit();
			this.vCorr.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vCorr.DecimalPlacesCount = ((uint)(1u));
			this.vCorr.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 180D, 36D);
			this.vCorr.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vCorr.FontScale = false;
			this.vCorr.IsOnlyInput = true;
			this.vCorr.IsPrefixSuffixOutside = false;
			this.vCorr.LeadingZeros = ((uint)(0u));
			this.vCorr.Name = "vCorr";
			this.vCorr.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vCorr.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.vCorr.Suffix = " A";
			this.vCorr.TagName = "CurrentFb";
			this.vCorr.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vCorr.EndInit();
			// 
			// lTens
			// 
			this.lTens.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(68D)), ((float)(296D)), ((float)(30D)));
			this.lTens.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lTens.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lTens.Name = "lTens";
			this.lTens.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tTens
			// 
			this.tTens.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tTens.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tTens.Location = new NxtControl.Drawing.PointF(12D, 74D);
			this.tTens.Name = "tTens";
			this.tTens.Text = "Tensão";
			// 
			// vTens
			// 
			this.vTens.BeginInit();
			this.vTens.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vTens.DecimalPlacesCount = ((uint)(0u));
			this.vTens.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 180D, 70D);
			this.vTens.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vTens.FontScale = false;
			this.vTens.IsOnlyInput = true;
			this.vTens.IsPrefixSuffixOutside = false;
			this.vTens.LeadingZeros = ((uint)(0u));
			this.vTens.Name = "vTens";
			this.vTens.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vTens.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.vTens.Suffix = " V";
			this.vTens.TagName = "AtvTensaoV";
			this.vTens.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vTens.EndInit();
			// 
			// lPot
			// 
			this.lPot.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(102D)), ((float)(296D)), ((float)(30D)));
			this.lPot.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lPot.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lPot.Name = "lPot";
			this.lPot.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tPot
			// 
			this.tPot.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tPot.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tPot.Location = new NxtControl.Drawing.PointF(12D, 108D);
			this.tPot.Name = "tPot";
			this.tPot.Text = "Potência";
			// 
			// vPot
			// 
			this.vPot.BeginInit();
			this.vPot.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vPot.DecimalPlacesCount = ((uint)(0u));
			this.vPot.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 180D, 104D);
			this.vPot.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vPot.FontScale = false;
			this.vPot.IsOnlyInput = true;
			this.vPot.IsPrefixSuffixOutside = false;
			this.vPot.LeadingZeros = ((uint)(0u));
			this.vPot.Name = "vPot";
			this.vPot.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vPot.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.vPot.Suffix = " %";
			this.vPot.TagName = "AtvPotenciaPct";
			this.vPot.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vPot.EndInit();
			// 
			// lTorq
			// 
			this.lTorq.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(136D)), ((float)(296D)), ((float)(30D)));
			this.lTorq.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lTorq.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lTorq.Name = "lTorq";
			this.lTorq.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tTorq
			// 
			this.tTorq.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tTorq.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tTorq.Location = new NxtControl.Drawing.PointF(12D, 142D);
			this.tTorq.Name = "tTorq";
			this.tTorq.Text = "Torque";
			// 
			// vTorq
			// 
			this.vTorq.BeginInit();
			this.vTorq.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vTorq.DecimalPlacesCount = ((uint)(1u));
			this.vTorq.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 180D, 138D);
			this.vTorq.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vTorq.FontScale = false;
			this.vTorq.IsOnlyInput = true;
			this.vTorq.IsPrefixSuffixOutside = false;
			this.vTorq.LeadingZeros = ((uint)(0u));
			this.vTorq.Name = "vTorq";
			this.vTorq.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vTorq.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.vTorq.Suffix = " %";
			this.vTorq.TagName = "AtvTorquePct";
			this.vTorq.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vTorq.EndInit();
			// 
			// lRpm
			// 
			this.lRpm.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(170D)), ((float)(296D)), ((float)(30D)));
			this.lRpm.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lRpm.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lRpm.Name = "lRpm";
			this.lRpm.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tRpm
			// 
			this.tRpm.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tRpm.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tRpm.Location = new NxtControl.Drawing.PointF(12D, 176D);
			this.tRpm.Name = "tRpm";
			this.tRpm.Text = "Rotação";
			// 
			// vRpm
			// 
			this.vRpm.BeginInit();
			this.vRpm.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vRpm.DecimalPlacesCount = ((uint)(0u));
			this.vRpm.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 180D, 172D);
			this.vRpm.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vRpm.FontScale = false;
			this.vRpm.IsOnlyInput = true;
			this.vRpm.IsPrefixSuffixOutside = false;
			this.vRpm.LeadingZeros = ((uint)(0u));
			this.vRpm.Name = "vRpm";
			this.vRpm.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary6.Add("Text", "${Value}");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary6.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary6.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vRpm.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.vRpm.Suffix = " rpm";
			this.vRpm.TagName = "AtvSpeedRpm";
			this.vRpm.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vRpm.EndInit();
			// 
			// vPotKw
			// 
			this.vPotKw.BeginInit();
			this.vPotKw.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vPotKw.DecimalPlacesCount = ((uint)(1u));
			this.vPotKw.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 180D, 104D);
			this.vPotKw.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vPotKw.FontScale = false;
			this.vPotKw.IsOnlyInput = true;
			this.vPotKw.IsPrefixSuffixOutside = false;
			this.vPotKw.LeadingZeros = ((uint)(0u));
			this.vPotKw.Name = "vPotKw";
			this.vPotKw.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vPotKw.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.vPotKw.Suffix = " kW";
			this.vPotKw.TagName = "PowerKW";
			this.vPotKw.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vPotKw.Visible = false;
			this.vPotKw.EndInit();
			// 
			// lFalha
			// 
			this.lFalha.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(204D)), ((float)(296D)), ((float)(30D)));
			this.lFalha.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lFalha.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lFalha.Name = "lFalha";
			this.lFalha.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tFalha
			// 
			this.tFalha.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tFalha.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tFalha.Location = new NxtControl.Drawing.PointF(12D, 210D);
			this.tFalha.Name = "tFalha";
			this.tFalha.Text = "Código de falha";
			// 
			// vFalha
			// 
			this.vFalha.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vFalha.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vFalha.Location = new NxtControl.Drawing.PointF(130D, 210D);
			this.vFalha.Name = "vFalha";
			this.vFalha.Text = "nenhuma";
			// 
			// sMedicoes
			// 
			// 
			// vFalhaTxt
			// 
			this.vFalhaTxt.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.vFalhaTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.vFalhaTxt.Location = new NxtControl.Drawing.PointF(12D, 238D);
			this.vFalhaTxt.Name = "vFalhaTxt";
			this.vFalhaTxt.Text = "";
			// 
			// vFalhaTxt2
			// 
			this.vFalhaTxt2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.vFalhaTxt2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.vFalhaTxt2.Location = new NxtControl.Drawing.PointF(12D, 254D);
			this.vFalhaTxt2.Name = "vFalhaTxt2";
			this.vFalhaTxt2.Text = "";
			this.Name = "sMedicoes";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.lFreq,
			this.tFreq,
			this.vFreq,
			this.lCorr,
			this.tCorr,
			this.vCorr,
			this.lTens,
			this.tTens,
			this.vTens,
			this.lPot,
			this.tPot,
			this.vPot,
			this.lTorq,
			this.tTorq,
			this.vTorq,
			this.lRpm,
			this.tRpm,
			this.vRpm,
			this.vPotKw,
			this.lFalha,
			this.tFalha,
			this.vFalha,
			this.vFalhaTxt,
			this.vFalhaTxt2});
			this.SymbolSize = new System.Drawing.Size(296, 272);

		}
		private NxtControl.GuiFramework.Rectangle lFreq;
		private NxtControl.GuiFramework.FreeText tFreq;
		private System.HMI.Symbols.Base.Label<System.Single> vFreq;
		private NxtControl.GuiFramework.Rectangle lCorr;
		private NxtControl.GuiFramework.FreeText tCorr;
		private System.HMI.Symbols.Base.Label<System.Single> vCorr;
		private NxtControl.GuiFramework.Rectangle lTens;
		private NxtControl.GuiFramework.FreeText tTens;
		private System.HMI.Symbols.Base.Label<System.Single> vTens;
		private NxtControl.GuiFramework.Rectangle lPot;
		private NxtControl.GuiFramework.FreeText tPot;
		private System.HMI.Symbols.Base.Label<System.Single> vPot;
		private NxtControl.GuiFramework.Rectangle lTorq;
		private NxtControl.GuiFramework.FreeText tTorq;
		private System.HMI.Symbols.Base.Label<System.Single> vTorq;
		private NxtControl.GuiFramework.Rectangle lRpm;
		private NxtControl.GuiFramework.FreeText tRpm;
		private System.HMI.Symbols.Base.Label<System.Single> vRpm;
		private System.HMI.Symbols.Base.Label<System.Single> vPotKw;
		private NxtControl.GuiFramework.Rectangle lFalha;
		private NxtControl.GuiFramework.FreeText tFalha;
		private NxtControl.GuiFramework.FreeText vFalha;
		private NxtControl.GuiFramework.FreeText vFalhaTxt;
		private NxtControl.GuiFramework.FreeText vFalhaTxt2;
		#endregion
	}
}
