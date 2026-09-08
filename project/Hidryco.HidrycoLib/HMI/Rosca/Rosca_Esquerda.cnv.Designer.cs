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

namespace Hidryco.HidrycoLib.Symbols.Rosca
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class Esquerda
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
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.stsDefeito = new System.HMI.Symbols.Base.Execute<bool>();
			this.Base3R = new NxtControl.GuiFramework.Rectangle();
			this.Base2R = new NxtControl.GuiFramework.Rectangle();
			this.Base1R = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.stsAutomaticoSubsistema = new System.HMI.Symbols.Base.FreeText<bool>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.group2 = new NxtControl.GuiFramework.Group();
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
			this.stsAnimacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.STS_ANIMACAOValueChanged);
			this.stsAnimacao.EndInit();
			// 
			// stsDefeito
			// 
			this.stsDefeito.BeginInit();
			this.stsDefeito.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsDefeito.IsOnlyInput = true;
			this.stsDefeito.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsDefeito.Name = "stsDefeito";
			this.stsDefeito.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsDefeito.TagName = "stsDefeito";
			this.stsDefeito.Value = false;
			this.stsDefeito.EndInit();
			// 
			// Base3R
			// 
			this.Base3R.Bounds = new NxtControl.Drawing.RectF(((float)(57D)), ((float)(88D)), ((float)(3D)), ((float)(16D)));
			this.Base3R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base3R.Name = "Base3R";
			// 
			// Base2R
			// 
			this.Base2R.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(80D)), ((float)(4D)), ((float)(32D)));
			this.Base2R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base2R.Name = "Base2R";
			// 
			// Base1R
			// 
			this.Base1R.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(72D)), ((float)(64D)), ((float)(48D)));
			this.Base1R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base1R.Name = "Base1R";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(133D)), ((float)(72D)), ((float)(23D)), ((float)(20.125D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// stsAutomaticoSubsistema
			// 
			this.stsAutomaticoSubsistema.BeginInit();
			this.stsAutomaticoSubsistema.DecimalPlacesCount = ((uint)(2u));
			this.stsAutomaticoSubsistema.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 131D, 73D);
			this.stsAutomaticoSubsistema.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsAutomaticoSubsistema.IsOnlyInput = true;
			this.stsAutomaticoSubsistema.Name = "stsAutomaticoSubsistema";
			propertyDictionary2.Add("Text", "M");
			propertyDictionary3.Add("Text", "A");
			this.stsAutomaticoSubsistema.Ranges.Clear();
			this.stsAutomaticoSubsistema.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.stsAutomaticoSubsistema.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "false");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.stsAutomaticoSubsistema.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsAutomaticoSubsistema.TagName = "stsAutomaticoSubsistema";
			this.stsAutomaticoSubsistema.TextAngle = 0F;
			this.stsAutomaticoSubsistema.EndInit();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(50D)), ((float)(72D)), ((float)(22D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.stsAutomaticoSubsistema});
			this.group2.EndInit();
			// 
			// Esquerda
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsAnimacao,
			this.stsDefeito,
			this.Base3R,
			this.Base2R,
			this.Base1R,
			this.InstanceName,
			this.group2});
			this.SymbolSize = new System.Drawing.Size(288, 224);

		}
		private System.HMI.Symbols.Base.Execute<short> stsAnimacao;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Execute<bool> stsDefeito;
		private NxtControl.GuiFramework.Rectangle Base3R;
		private NxtControl.GuiFramework.Rectangle Base2R;
		private NxtControl.GuiFramework.Rectangle Base1R;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private System.HMI.Symbols.Base.FreeText<bool> stsAutomaticoSubsistema;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
