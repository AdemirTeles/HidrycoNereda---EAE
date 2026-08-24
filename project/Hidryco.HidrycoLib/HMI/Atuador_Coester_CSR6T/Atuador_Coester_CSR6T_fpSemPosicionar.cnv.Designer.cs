/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 18/08/2026
 * Tempo: 13:43
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Atuador_Coester_CSR6T
{
	/// <summary>
	/// Summary description for fpSemPosicionar.
	/// </summary>
	partial class fpSemPosicionar
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.btnManual = new NxtControl.GuiFramework.DrawnButton();
			this.btnAutomatico = new NxtControl.GuiFramework.DrawnButton();
			this.btnAbrir = new NxtControl.GuiFramework.DrawnButton();
			this.btnFechar = new NxtControl.GuiFramework.DrawnButton();
			this.fbkAutomatico = new System.HMI.Symbols.Base.Execute<bool>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.stsRemoto = new System.HMI.Symbols.Base.Label<bool>();
			this.fbkStsAutomatico = new System.HMI.Symbols.Base.Label<bool>();
			this.stsPosicaoAtual = new System.HMI.Symbols.Base.Label<short>();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(208D, 112D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(-67D, 112D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(0D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Operação";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(0D, 40D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Status";
			// 
			// btnManual
			// 
			this.btnManual.Bounds = new NxtControl.Drawing.RectF(((float)(11D)), ((float)(128D)), ((float)(80D)), ((float)(30D)));
			this.btnManual.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnManual.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnManual.InnerBorderColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonInnerBorderColor");
			this.btnManual.Name = "btnManual";
			this.btnManual.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnManual.Radius = 4D;
			this.btnManual.Text = "Manual";
			this.btnManual.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.btnManual.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.btnManual.Use3DEffect = false;
			this.btnManual.Click += new System.EventHandler(this.BtnManualClick);
			// 
			// btnAutomatico
			// 
			this.btnAutomatico.Bounds = new NxtControl.Drawing.RectF(((float)(115D)), ((float)(128D)), ((float)(80D)), ((float)(30D)));
			this.btnAutomatico.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnAutomatico.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnAutomatico.InnerBorderColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonInnerBorderColor");
			this.btnAutomatico.Name = "btnAutomatico";
			this.btnAutomatico.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnAutomatico.Radius = 4D;
			this.btnAutomatico.Text = "Automático";
			this.btnAutomatico.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.btnAutomatico.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.btnAutomatico.Use3DEffect = false;
			this.btnAutomatico.Click += new System.EventHandler(this.BtnAutomaticoClick);
			// 
			// btnAbrir
			// 
			this.btnAbrir.Bounds = new NxtControl.Drawing.RectF(((float)(115D)), ((float)(179D)), ((float)(80D)), ((float)(30D)));
			this.btnAbrir.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnAbrir.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnAbrir.InnerBorderColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonInnerBorderColor");
			this.btnAbrir.Name = "btnAbrir";
			this.btnAbrir.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnAbrir.Radius = 4D;
			this.btnAbrir.Text = "Abrir";
			this.btnAbrir.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.btnAbrir.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.btnAbrir.Use3DEffect = false;
			this.btnAbrir.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnAbrirMouseDown);
			this.btnAbrir.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnAbrirMouseUp);
			// 
			// btnFechar
			// 
			this.btnFechar.Bounds = new NxtControl.Drawing.RectF(((float)(11D)), ((float)(179D)), ((float)(80D)), ((float)(30D)));
			this.btnFechar.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnFechar.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnFechar.InnerBorderColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonInnerBorderColor");
			this.btnFechar.Name = "btnFechar";
			this.btnFechar.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnFechar.Radius = 4D;
			this.btnFechar.Text = "Fechar";
			this.btnFechar.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.btnFechar.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.btnFechar.Use3DEffect = false;
			this.btnFechar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BtnFecharMouseDown);
			this.btnFechar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.BtnFecharMouseUp);
			// 
			// fbkAutomatico
			// 
			this.fbkAutomatico.BeginInit();
			this.fbkAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.fbkAutomatico.IsOnlyInput = true;
			this.fbkAutomatico.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.fbkAutomatico.Name = "fbkAutomatico";
			this.fbkAutomatico.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.fbkAutomatico.TagName = "fbkStsAutomatico";
			this.fbkAutomatico.Value = false;
			this.fbkAutomatico.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbkAutomaticoValueChanged);
			this.fbkAutomatico.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(0D, 72D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Posição Atual";
			// 
			// stsRemoto
			// 
			this.stsRemoto.BeginInit();
			this.stsRemoto.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64666666666666661D, 0D, 0D, 1D, 112D, 8D);
			this.stsRemoto.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsRemoto.FontScale = false;
			this.stsRemoto.IsOnlyInput = true;
			this.stsRemoto.LeadingZeros = ((uint)(0u));
			this.stsRemoto.Name = "stsRemoto";
			this.stsRemoto.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "Local");
			propertyDictionary3.Add("Text", "Remoto");
			this.stsRemoto.Ranges.Clear();
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.stsRemoto.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "false");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsRemoto.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsRemoto.TagName = "stsRemoto";
			this.stsRemoto.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsRemoto.EndInit();
			// 
			// fbkStsAutomatico
			// 
			this.fbkStsAutomatico.BeginInit();
			this.fbkStsAutomatico.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.fbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.84666666666666668D, 0D, 0D, 1D, 80D, 40D);
			this.fbkStsAutomatico.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.fbkStsAutomatico.FontScale = false;
			this.fbkStsAutomatico.IsOnlyInput = true;
			this.fbkStsAutomatico.LeadingZeros = ((uint)(0u));
			this.fbkStsAutomatico.Name = "fbkStsAutomatico";
			this.fbkStsAutomatico.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "Manual");
			propertyDictionary6.Add("Text", "Automático");
			this.fbkStsAutomatico.Ranges.Clear();
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.fbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Text", "false");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.fbkStsAutomatico.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.fbkStsAutomatico.TagName = "fbkStsAutomatico";
			this.fbkStsAutomatico.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.fbkStsAutomatico.EndInit();
			// 
			// stsPosicaoAtual
			// 
			this.stsPosicaoAtual.BeginInit();
			this.stsPosicaoAtual.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsPosicaoAtual.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.57333333333333336D, 0D, 0D, 1D, 121D, 72D);
			this.stsPosicaoAtual.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsPosicaoAtual.FontScale = false;
			this.stsPosicaoAtual.IsOnlyInput = true;
			this.stsPosicaoAtual.IsPrefixSuffixOutside = false;
			this.stsPosicaoAtual.LeadingZeros = ((uint)(0u));
			this.stsPosicaoAtual.Name = "stsPosicaoAtual";
			this.stsPosicaoAtual.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color("LabelTextColor"));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsPosicaoAtual.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.stsPosicaoAtual.Suffix = "%";
			this.stsPosicaoAtual.TagName = "stsPosicaoAtual";
			this.stsPosicaoAtual.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsPosicaoAtual.EndInit();
			// 
			// fpSemPosicionar
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(208D)), ((float)(224D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.freeText1,
			this.freeText2,
			this.btnManual,
			this.btnAutomatico,
			this.btnAbrir,
			this.btnFechar,
			this.fbkAutomatico,
			this.freeText3,
			this.stsRemoto,
			this.fbkStsAutomatico,
			this.stsPosicaoAtual});
			this.Size = new System.Drawing.Size(208, 224);

		}
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.DrawnButton btnManual;
		private NxtControl.GuiFramework.DrawnButton btnAutomatico;
		private NxtControl.GuiFramework.DrawnButton btnAbrir;
		private NxtControl.GuiFramework.DrawnButton btnFechar;
		private System.HMI.Symbols.Base.Execute<bool> fbkAutomatico;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.Label<bool> stsRemoto;
		private System.HMI.Symbols.Base.Label<bool> fbkStsAutomatico;
		private System.HMI.Symbols.Base.Label<short> stsPosicaoAtual;
		#endregion
	}
}
