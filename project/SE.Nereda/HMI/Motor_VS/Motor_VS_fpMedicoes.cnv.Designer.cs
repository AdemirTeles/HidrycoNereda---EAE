/*
 * Hidryco - fpMedicoes
 * ISA-101: medicoes do inversor (padrao do Motor_Generico.fpMeasures).
 */
using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Motor_VS
{
	partial class fpMedicoes
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.lVel = new NxtControl.GuiFramework.Rectangle();
			this.tVel = new NxtControl.GuiFramework.FreeText();
			this.vVel = new System.HMI.Symbols.Base.Label<System.Single>();
			this.medicoes = new SE.Nereda.Symbols.FieldSignals.sMedicoes();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Medições do inversor";
			// 
			// lVel
			// 
			this.lVel.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(46D)), ((float)(296D)), ((float)(30D)));
			this.lVel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lVel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lVel.Name = "lVel";
			this.lVel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tVel
			// 
			this.tVel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tVel.Location = new NxtControl.Drawing.PointF(24D, 52D);
			this.tVel.Name = "tVel";
			this.tVel.Text = "Velocidade";
			// 
			// vVel
			// 
			this.vVel.BeginInit();
			this.vVel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vVel.DecimalPlacesCount = ((uint)(1u));
			this.vVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6875D, 0D, 0D, 1D, 192D, 48D);
			this.vVel.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.vVel.FontScale = false;
			this.vVel.IsOnlyInput = true;
			this.vVel.IsPrefixSuffixOutside = false;
			this.vVel.LeadingZeros = ((uint)(0u));
			this.vVel.Name = "vVel";
			this.vVel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vVel.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vVel.Suffix = " %";
			this.vVel.TagName = "FbSpeed";
			this.vVel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.vVel.EndInit();
			// 
			// medicoes
			// 
			this.medicoes.BeginInit();
			this.medicoes.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 12D, 80D);
			this.medicoes.Name = "medicoes";
			this.medicoes.SecurityToken = ((uint)(4294967295u));
			this.medicoes.TagName = "LocalPanel";
			this.medicoes.EndInit();
			// 
			// fpMedicoes
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(320D)), ((float)(370D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpMedicoes";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.lVel,
			this.tVel,
			this.vVel,
			this.medicoes});
			this.Size = new System.Drawing.Size(320, 370);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.Rectangle lVel;
		private NxtControl.GuiFramework.FreeText tVel;
		private System.HMI.Symbols.Base.Label<System.Single> vVel;
		private SE.Nereda.Symbols.FieldSignals.sMedicoes medicoes;
		#endregion
	}
}
