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

namespace Hidryco.HidrycoLib.Symbols.Bomba_Higienizacao
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
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.stsDefeito = new System.HMI.Symbols.Base.Execute<bool>();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.stsAutomaticoSubsistema = new System.HMI.Symbols.Base.FreeText<bool>();
			this.bomba1 = new Hidryco.HidrycoLib.Graphics.Bomba();
			this.group1 = new NxtControl.GuiFramework.Group();
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
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(54D)), ((float)(52D)), ((float)(72D)), ((float)(22D)));
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
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(128D)), ((float)(97D)), ((float)(23D)), ((float)(20.125D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// stsAutomaticoSubsistema
			// 
			this.stsAutomaticoSubsistema.BeginInit();
			this.stsAutomaticoSubsistema.DecimalPlacesCount = ((uint)(2u));
			this.stsAutomaticoSubsistema.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 126D, 98D);
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
			this.stsAutomaticoSubsistema.TagName = "STS_AUTOMATICO_SUBSISTEMA";
			this.stsAutomaticoSubsistema.TextAngle = 0F;
			this.stsAutomaticoSubsistema.EndInit();
			// 
			// bomba1
			// 
			this.bomba1.BeginInit();
			this.bomba1.Animacao = 0;
			this.bomba1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3392857142857144D, 0D, 0D, 1.339285714285714D, 56D, 72.325000000000017D);
			this.bomba1.Name = "bomba1";
			this.bomba1.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.stsAutomaticoSubsistema});
			this.group1.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsAnimacao,
			this.stsDefeito,
			this.InstanceName,
			this.bomba1,
			this.group1});
			this.SymbolSize = new System.Drawing.Size(288, 224);

		}
		private System.HMI.Symbols.Base.Execute<short> stsAnimacao;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Group group1;
		private System.HMI.Symbols.Base.Execute<bool> stsDefeito;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private System.HMI.Symbols.Base.FreeText<bool> stsAutomaticoSubsistema;
		private Hidryco.HidrycoLib.Graphics.Bomba bomba1;
		#endregion
	}
}
