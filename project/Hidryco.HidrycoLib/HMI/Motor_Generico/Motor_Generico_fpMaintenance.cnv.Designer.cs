/*
 * Hidryco - Motor_Generico - fpMaintenance
 * ISA-101: horimetro (h e min; contado no CAT com resolucao de 1 s, gravado na persistencia) e numero de partidas, com reset.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	/// <summary>
	/// Summary description for fpMaintenance.
	/// </summary>
	partial class fpMaintenance
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.linha1 = new NxtControl.GuiFramework.Rectangle();
			this.lblHor = new NxtControl.GuiFramework.FreeText();
			this.horas = new System.HMI.Symbols.Base.Label<uint>();
			this.minutos = new System.HMI.Symbols.Base.Label<ushort>();
			this.btnResetHor = new NxtControl.GuiFramework.DrawnButton();
			this.linha2 = new NxtControl.GuiFramework.Rectangle();
			this.lblPart = new NxtControl.GuiFramework.FreeText();
			this.partidas = new System.HMI.Symbols.Base.Label<uint>();
			this.btnResetPart = new NxtControl.GuiFramework.DrawnButton();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Manutenção";
			// 
			// linha1
			// 
			this.linha1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(46D)), ((float)(336D)), ((float)(56D)));
			this.linha1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linha1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linha1.Name = "linha1";
			this.linha1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lblHor
			// 
			this.lblHor.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lblHor.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lblHor.Location = new NxtControl.Drawing.PointF(24D, 52D);
			this.lblHor.Name = "lblHor";
			this.lblHor.Text = "Horímetro";
			// 
			// horas
			// 
			this.horas.BeginInit();
			this.horas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.horas.DecimalPlacesCount = ((uint)(0u));
			this.horas.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7243D, 0D, 0D, 1.1D, 24D, 68D);
			this.horas.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.horas.FontScale = false;
			this.horas.IsOnlyInput = true;
			this.horas.IsPrefixSuffixOutside = false;
			this.horas.LeadingZeros = ((uint)(0u));
			this.horas.Name = "horas";
			this.horas.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.horas.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.horas.Suffix = " h";
			this.horas.TagName = "STS_HORIMETRO_HORA";
			this.horas.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.horas.EndInit();
			// 
			// minutos
			// 
			this.minutos.BeginInit();
			this.minutos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.minutos.DecimalPlacesCount = ((uint)(0u));
			this.minutos.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.603D, 0D, 0D, 1.1D, 144D, 68D);
			this.minutos.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.minutos.FontScale = false;
			this.minutos.IsOnlyInput = true;
			this.minutos.IsPrefixSuffixOutside = false;
			this.minutos.LeadingZeros = ((uint)(0u));
			this.minutos.Name = "minutos";
			this.minutos.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.minutos.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.minutos.Suffix = " min";
			this.minutos.TagName = "STS_HORIMETRO_MINUTO";
			this.minutos.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.minutos.EndInit();
			// 
			// btnResetHor
			// 
			this.btnResetHor.Bounds = new NxtControl.Drawing.RectF(((float)(250D)), ((float)(58D)), ((float)(90D)), ((float)(32D)));
			this.btnResetHor.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnResetHor.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnResetHor.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnResetHor.Name = "btnResetHor";
			this.btnResetHor.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnResetHor.Radius = 2D;
			this.btnResetHor.Text = "Zerar";
			this.btnResetHor.Use3DEffect = false;
			this.btnResetHor.Click += new System.EventHandler(this.BtnResetHorClick);
			// 
			// linha2
			// 
			this.linha2.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(112D)), ((float)(336D)), ((float)(56D)));
			this.linha2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.linha2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.linha2.Name = "linha2";
			this.linha2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lblPart
			// 
			this.lblPart.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lblPart.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lblPart.Location = new NxtControl.Drawing.PointF(24D, 118D);
			this.lblPart.Name = "lblPart";
			this.lblPart.Text = "Número de partidas";
			// 
			// partidas
			// 
			this.partidas.BeginInit();
			this.partidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.partidas.DecimalPlacesCount = ((uint)(0u));
			this.partidas.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.55D, 0D, 0D, 1.1D, 24D, 134D);
			this.partidas.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.partidas.FontScale = false;
			this.partidas.IsOnlyInput = true;
			this.partidas.IsPrefixSuffixOutside = false;
			this.partidas.LeadingZeros = ((uint)(0u));
			this.partidas.Name = "partidas";
			this.partidas.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.partidas.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.partidas.TagName = "STS_NUMERO_PARTIDA";
			this.partidas.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.partidas.EndInit();
			// 
			// btnResetPart
			// 
			this.btnResetPart.Bounds = new NxtControl.Drawing.RectF(((float)(250D)), ((float)(124D)), ((float)(90D)), ((float)(32D)));
			this.btnResetPart.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnResetPart.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnResetPart.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnResetPart.Name = "btnResetPart";
			this.btnResetPart.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnResetPart.Radius = 2D;
			this.btnResetPart.Text = "Zerar";
			this.btnResetPart.Use3DEffect = false;
			this.btnResetPart.Click += new System.EventHandler(this.BtnResetPartClick);
			// 
			// fpMaintenance
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(182D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.linha1,
			this.lblHor,
			this.horas,
			this.minutos,
			this.btnResetHor,
			this.linha2,
			this.lblPart,
			this.partidas,
			this.btnResetPart});
			this.Size = new System.Drawing.Size(360, 182);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.Rectangle linha1;
		private NxtControl.GuiFramework.FreeText lblHor;
		private System.HMI.Symbols.Base.Label<uint> horas;
		private System.HMI.Symbols.Base.Label<ushort> minutos;
		private NxtControl.GuiFramework.DrawnButton btnResetHor;
		private NxtControl.GuiFramework.Rectangle linha2;
		private NxtControl.GuiFramework.FreeText lblPart;
		private System.HMI.Symbols.Base.Label<uint> partidas;
		private NxtControl.GuiFramework.DrawnButton btnResetPart;
		#endregion
	}
}
