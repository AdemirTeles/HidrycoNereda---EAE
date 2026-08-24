/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/23/2026
 * Time: 2:08 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inversor_Automatico_Unico
{
	/// <summary>
	/// Summary description for Faceplate4.
	/// </summary>
	partial class Faceplate4
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.STS_VELOCIDADE = new System.HMI.Symbols.Base.Label<short>();
			this.STS_CORRENTE = new System.HMI.Symbols.Base.Label<short>();
			this.STS_FREQUENCIA = new System.HMI.Symbols.Base.Label<short>();
			this.STS_TENSAO = new System.HMI.Symbols.Base.Label<short>();
			this.STS_TORQUE = new System.HMI.Symbols.Base.Label<short>();
			this.STS_POTENCIA = new System.HMI.Symbols.Base.Label<short>();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 20D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Velocidade";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 72D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Corrente";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(8D, 124D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Frequência";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(8D, 176D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Tensão";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(8D, 228D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Torque";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText6.Location = new NxtControl.Drawing.PointF(8D, 280D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Potência";
			// 
			// STS_VELOCIDADE
			// 
			this.STS_VELOCIDADE.BeginInit();
			this.STS_VELOCIDADE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.STS_VELOCIDADE.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49333333333333335D, 0D, 0D, 1D, 112D, 20D);
			this.STS_VELOCIDADE.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.STS_VELOCIDADE.FontScale = false;
			this.STS_VELOCIDADE.IsOnlyInput = true;
			this.STS_VELOCIDADE.LeadingZeros = ((uint)(0u));
			this.STS_VELOCIDADE.Name = "STS_VELOCIDADE";
			this.STS_VELOCIDADE.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.STS_VELOCIDADE.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.STS_VELOCIDADE.Suffix = "rpm";
			this.STS_VELOCIDADE.TagName = "STS_VELOCIDADE";
			this.STS_VELOCIDADE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.STS_VELOCIDADE.EndInit();
			// 
			// STS_CORRENTE
			// 
			this.STS_CORRENTE.BeginInit();
			this.STS_CORRENTE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.STS_CORRENTE.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49333333333333335D, 0D, 0D, 1D, 112D, 73D);
			this.STS_CORRENTE.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.STS_CORRENTE.FontScale = false;
			this.STS_CORRENTE.IsOnlyInput = true;
			this.STS_CORRENTE.LeadingZeros = ((uint)(0u));
			this.STS_CORRENTE.Name = "STS_CORRENTE";
			this.STS_CORRENTE.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.STS_CORRENTE.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.STS_CORRENTE.Suffix = "A";
			this.STS_CORRENTE.TagName = "STS_CORRENTE";
			this.STS_CORRENTE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.STS_CORRENTE.EndInit();
			// 
			// STS_FREQUENCIA
			// 
			this.STS_FREQUENCIA.BeginInit();
			this.STS_FREQUENCIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.STS_FREQUENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49333333333333335D, 0D, 0D, 1D, 112D, 126D);
			this.STS_FREQUENCIA.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.STS_FREQUENCIA.FontScale = false;
			this.STS_FREQUENCIA.IsOnlyInput = true;
			this.STS_FREQUENCIA.LeadingZeros = ((uint)(0u));
			this.STS_FREQUENCIA.Name = "STS_FREQUENCIA";
			this.STS_FREQUENCIA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.STS_FREQUENCIA.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.STS_FREQUENCIA.Suffix = "Hz";
			this.STS_FREQUENCIA.TagName = "STS_FREQUENCIA";
			this.STS_FREQUENCIA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.STS_FREQUENCIA.EndInit();
			// 
			// STS_TENSAO
			// 
			this.STS_TENSAO.BeginInit();
			this.STS_TENSAO.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.STS_TENSAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49333333333333335D, 0D, 0D, 1D, 112D, 179D);
			this.STS_TENSAO.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.STS_TENSAO.FontScale = false;
			this.STS_TENSAO.IsOnlyInput = true;
			this.STS_TENSAO.LeadingZeros = ((uint)(0u));
			this.STS_TENSAO.Name = "STS_TENSAO";
			this.STS_TENSAO.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.STS_TENSAO.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.STS_TENSAO.Suffix = "V";
			this.STS_TENSAO.TagName = "STS_TENSAO";
			this.STS_TENSAO.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.STS_TENSAO.EndInit();
			// 
			// STS_TORQUE
			// 
			this.STS_TORQUE.BeginInit();
			this.STS_TORQUE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.STS_TORQUE.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49333333333333335D, 0D, 0D, 1D, 112D, 232D);
			this.STS_TORQUE.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.STS_TORQUE.FontScale = false;
			this.STS_TORQUE.IsOnlyInput = true;
			this.STS_TORQUE.LeadingZeros = ((uint)(0u));
			this.STS_TORQUE.Name = "STS_TORQUE";
			this.STS_TORQUE.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.STS_TORQUE.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.STS_TORQUE.TagName = "STS_TORQUE";
			this.STS_TORQUE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.STS_TORQUE.EndInit();
			// 
			// STS_POTENCIA
			// 
			this.STS_POTENCIA.BeginInit();
			this.STS_POTENCIA.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.STS_POTENCIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49333333333333335D, 0D, 0D, 1D, 112D, 285D);
			this.STS_POTENCIA.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.STS_POTENCIA.FontScale = false;
			this.STS_POTENCIA.IsOnlyInput = true;
			this.STS_POTENCIA.LeadingZeros = ((uint)(0u));
			this.STS_POTENCIA.Name = "STS_POTENCIA";
			this.STS_POTENCIA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary6.Add("Text", "${Value}");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary6.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary6.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.STS_POTENCIA.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.STS_POTENCIA.Suffix = "kW";
			this.STS_POTENCIA.TagName = "STS_POTENCIA";
			this.STS_POTENCIA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.STS_POTENCIA.EndInit();
			// 
			// Faceplate4
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(242D)), ((float)(332D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText2,
			this.freeText1,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.STS_VELOCIDADE,
			this.STS_CORRENTE,
			this.STS_FREQUENCIA,
			this.STS_TENSAO,
			this.STS_TORQUE,
			this.STS_POTENCIA});
			this.Size = new System.Drawing.Size(242, 332);

		}
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private System.HMI.Symbols.Base.Label<short> STS_VELOCIDADE;
		private System.HMI.Symbols.Base.Label<short> STS_CORRENTE;
		private System.HMI.Symbols.Base.Label<short> STS_FREQUENCIA;
		private System.HMI.Symbols.Base.Label<short> STS_TENSAO;
		private System.HMI.Symbols.Base.Label<short> STS_TORQUE;
		private System.HMI.Symbols.Base.Label<short> STS_POTENCIA;
		#endregion
	}
}
