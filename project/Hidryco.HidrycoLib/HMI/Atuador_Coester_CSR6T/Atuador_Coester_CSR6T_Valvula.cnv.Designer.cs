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

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class Valvula
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.falha_comunicacao1 = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.alarme_icon1 = new Hidryco.HidrycoLib.Graphics.alarme_icon();
			this.stsFalhaComunicacao = new System.HMI.Symbols.Base.Execute<bool>();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.stsRemoto = new System.HMI.Symbols.Base.FreeText<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.valvula_Horizontal1 = new Hidryco.HidrycoLib.Graphics.Valvula_Horizontal();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(56D)), ((float)(87D)), ((float)(24D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
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
			this.stsAnimacao.TagName = "stsAnimacao";
			this.stsAnimacao.Value = ((short)(0));
			this.stsAnimacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsAnimacaoValueChanged);
			this.stsAnimacao.EndInit();
			// 
			// falha_comunicacao1
			// 
			this.falha_comunicacao1.BeginInit();
			this.falha_comunicacao1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 49D, 55D);
			this.falha_comunicacao1.Name = "falha_comunicacao1";
			this.falha_comunicacao1.EndInit();
			// 
			// alarme_icon1
			// 
			this.alarme_icon1.BeginInit();
			this.alarme_icon1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8571428571428571D, 0D, 0D, 0.8571428571428571D, 49D, 85D);
			this.alarme_icon1.Name = "alarme_icon1";
			this.alarme_icon1.Visible = false;
			this.alarme_icon1.EndInit();
			// 
			// stsFalhaComunicacao
			// 
			this.stsFalhaComunicacao.BeginInit();
			this.stsFalhaComunicacao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsFalhaComunicacao.IsOnlyInput = true;
			this.stsFalhaComunicacao.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsFalhaComunicacao.Name = "stsFalhaComunicacao";
			this.stsFalhaComunicacao.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsFalhaComunicacao.TagName = "stsFalhaComunicacao";
			this.stsFalhaComunicacao.Value = false;
			this.stsFalhaComunicacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsFalhaComunicacaoValueChanged);
			this.stsFalhaComunicacao.EndInit();
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(125D)), ((float)(79D)), ((float)(24D)), ((float)(40D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(true);
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.DecimalPlacesCount = ((uint)(2u));
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 125D, 80D);
			this.stsRemoto.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsRemoto.IsOnlyInput = true;
			this.stsRemoto.Name = "stsRemoto";
			propertyDictionary8.Add("Text", "L");
			propertyDictionary9.Add("Text", "R");
			this.stsRemoto.Ranges.Clear();
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Text", "false");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.stsRemoto.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.stsRemoto.TagName = "stsRemoto";
			this.stsRemoto.TextAngle = 0F;
			this.stsRemoto.EndInit();
			// 
			// fbkStsAutomatico
			// 
			this.fbkStsAutomatico.BeginInit();
			this.fbkStsAutomatico.DecimalPlacesCount = ((uint)(2u));
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 124D, 100D);
			this.fbkStsAutomatico.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.fbkStsAutomatico.IsOnlyInput = true;
			this.fbkStsAutomatico.Name = "fbkStsAutomatico";
			propertyDictionary11.Add("Text", "M");
			propertyDictionary12.Add("Text", "A");
			this.fbkStsAutomatico.Ranges.Clear();
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Text", "false");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			this.fbkStsAutomatico.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.fbkStsAutomatico.TagName = "fbkStsAutomatico";
			this.fbkStsAutomatico.TextAngle = 0F;
			this.fbkStsAutomatico.EndInit();
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(149D, 99D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(125D, 99D);
			// 
			// valvula_Horizontal1
			// 
			this.valvula_Horizontal1.BeginInit();
			this.valvula_Horizontal1.Animacao = 0;
			this.valvula_Horizontal1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5999999999999994D, 0D, 0D, 1.5999999999999999D, 72D, 80D);
			this.valvula_Horizontal1.Name = "valvula_Horizontal1";
			this.valvula_Horizontal1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle3,
			this.stsRemoto,
			this.fbkStsAutomatico,
			this.line2});
			this.group2.EndInit();
			// 
			// Valvula
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InstanceName,
			this.stsAnimacao,
			this.falha_comunicacao1,
			this.alarme_icon1,
			this.stsFalhaComunicacao,
			this.valvula_Horizontal1,
			this.group2});
			this.SymbolSize = new System.Drawing.Size(195, 200);

		}
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Execute<System.Int16> stsAnimacao;
		private Hidryco.HidrycoLib.Graphics.alarme_icon alarme_icon1;
		private System.HMI.Symbols.Base.FreeText<bool> fbkStsAutomatico;
		private System.HMI.Symbols.Base.FreeText<bool> stsRemoto;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falha_comunicacao1;
		private System.HMI.Symbols.Base.Execute<bool> stsFalhaComunicacao;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Line line2;
		private Hidryco.HidrycoLib.Graphics.Valvula_Horizontal valvula_Horizontal1;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
