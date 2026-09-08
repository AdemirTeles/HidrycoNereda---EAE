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

namespace Hidryco.HidrycoLib.Faceplates.Motor_Dosagem
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
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.STS_VELOCIDADE = new System.HMI.Symbols.Base.Label<System.Single>();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 20D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Vazão";
			// 
			// STS_VELOCIDADE
			// 
			this.STS_VELOCIDADE.BeginInit();
			this.STS_VELOCIDADE.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.STS_VELOCIDADE.DecimalPlacesCount = ((uint)(2u));
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
			this.STS_VELOCIDADE.Suffix = "L/s";
			this.STS_VELOCIDADE.TagName = "STS_ENTRADA_MEDICAO";
			this.STS_VELOCIDADE.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.STS_VELOCIDADE.EndInit();
			// 
			// Faceplate4
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(242D)), ((float)(68D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText2,
			this.STS_VELOCIDADE});
			this.Size = new System.Drawing.Size(242, 68);

		}
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.Label<System.Single> STS_VELOCIDADE;
		#endregion
	}
}
