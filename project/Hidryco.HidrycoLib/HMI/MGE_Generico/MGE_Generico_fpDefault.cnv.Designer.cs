/*
 * Hidryco - MGE_Generico - fpDefault
 * ISA-101: grandezas do medidor, alarmes (forma + prioridade, piscando ate reconhecer), reconhecimento e ajustes.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.MGE_Generico
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
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
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.lin0 = new NxtControl.GuiFramework.Rectangle();
			this.rot0 = new NxtControl.GuiFramework.FreeText();
			this.v0_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v0_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v0_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin1 = new NxtControl.GuiFramework.Rectangle();
			this.rot1 = new NxtControl.GuiFramework.FreeText();
			this.v1_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v1_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v1_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin2 = new NxtControl.GuiFramework.Rectangle();
			this.rot2 = new NxtControl.GuiFramework.FreeText();
			this.v2_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v2_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v2_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin3 = new NxtControl.GuiFramework.Rectangle();
			this.rot3 = new NxtControl.GuiFramework.FreeText();
			this.v3_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v3_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v3_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin4 = new NxtControl.GuiFramework.Rectangle();
			this.rot4 = new NxtControl.GuiFramework.FreeText();
			this.v4_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v4_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v4_2 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin5 = new NxtControl.GuiFramework.Rectangle();
			this.rot5 = new NxtControl.GuiFramework.FreeText();
			this.v5_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v5_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin6 = new NxtControl.GuiFramework.Rectangle();
			this.rot6 = new NxtControl.GuiFramework.FreeText();
			this.v6_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin7 = new NxtControl.GuiFramework.Rectangle();
			this.rot7 = new NxtControl.GuiFramework.FreeText();
			this.v7_0 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.v7_1 = new System.HMI.Symbols.Base.Label<System.Single>();
			this.tituloAlm = new NxtControl.GuiFramework.FreeText();
			this.rCom = new NxtControl.GuiFramework.FreeText();
			this.nCom = new NxtControl.GuiFramework.FreeText();
			this.iComP1 = new NxtControl.GuiFramework.Rectangle();
			this.iComP1n = new NxtControl.GuiFramework.FreeText();
			this.iComP2 = new NxtControl.GuiFramework.Polygon();
			this.iComP2n = new NxtControl.GuiFramework.FreeText();
			this.iComTxt = new NxtControl.GuiFramework.FreeText();
			this.rFPL = new NxtControl.GuiFramework.FreeText();
			this.nFPL = new NxtControl.GuiFramework.FreeText();
			this.iFPLP1 = new NxtControl.GuiFramework.Rectangle();
			this.iFPLP1n = new NxtControl.GuiFramework.FreeText();
			this.iFPLP2 = new NxtControl.GuiFramework.Polygon();
			this.iFPLP2n = new NxtControl.GuiFramework.FreeText();
			this.iFPLTxt = new NxtControl.GuiFramework.FreeText();
			this.rVFH = new NxtControl.GuiFramework.FreeText();
			this.nVFH = new NxtControl.GuiFramework.FreeText();
			this.iVFHP1 = new NxtControl.GuiFramework.Rectangle();
			this.iVFHP1n = new NxtControl.GuiFramework.FreeText();
			this.iVFHP2 = new NxtControl.GuiFramework.Polygon();
			this.iVFHP2n = new NxtControl.GuiFramework.FreeText();
			this.iVFHTxt = new NxtControl.GuiFramework.FreeText();
			this.rVFL = new NxtControl.GuiFramework.FreeText();
			this.nVFL = new NxtControl.GuiFramework.FreeText();
			this.iVFLP1 = new NxtControl.GuiFramework.Rectangle();
			this.iVFLP1n = new NxtControl.GuiFramework.FreeText();
			this.iVFLP2 = new NxtControl.GuiFramework.Polygon();
			this.iVFLP2n = new NxtControl.GuiFramework.FreeText();
			this.iVFLTxt = new NxtControl.GuiFramework.FreeText();
			this.rVNH = new NxtControl.GuiFramework.FreeText();
			this.nVNH = new NxtControl.GuiFramework.FreeText();
			this.iVNHP1 = new NxtControl.GuiFramework.Rectangle();
			this.iVNHP1n = new NxtControl.GuiFramework.FreeText();
			this.iVNHP2 = new NxtControl.GuiFramework.Polygon();
			this.iVNHP2n = new NxtControl.GuiFramework.FreeText();
			this.iVNHTxt = new NxtControl.GuiFramework.FreeText();
			this.rVNL = new NxtControl.GuiFramework.FreeText();
			this.nVNL = new NxtControl.GuiFramework.FreeText();
			this.iVNLP1 = new NxtControl.GuiFramework.Rectangle();
			this.iVNLP1n = new NxtControl.GuiFramework.FreeText();
			this.iVNLP2 = new NxtControl.GuiFramework.Polygon();
			this.iVNLP2n = new NxtControl.GuiFramework.FreeText();
			this.iVNLTxt = new NxtControl.GuiFramework.FreeText();
			this.rIAH = new NxtControl.GuiFramework.FreeText();
			this.nIAH = new NxtControl.GuiFramework.FreeText();
			this.iIAHP1 = new NxtControl.GuiFramework.Rectangle();
			this.iIAHP1n = new NxtControl.GuiFramework.FreeText();
			this.iIAHP2 = new NxtControl.GuiFramework.Polygon();
			this.iIAHP2n = new NxtControl.GuiFramework.FreeText();
			this.iIAHTxt = new NxtControl.GuiFramework.FreeText();
			this.rIBH = new NxtControl.GuiFramework.FreeText();
			this.nIBH = new NxtControl.GuiFramework.FreeText();
			this.iIBHP1 = new NxtControl.GuiFramework.Rectangle();
			this.iIBHP1n = new NxtControl.GuiFramework.FreeText();
			this.iIBHP2 = new NxtControl.GuiFramework.Polygon();
			this.iIBHP2n = new NxtControl.GuiFramework.FreeText();
			this.iIBHTxt = new NxtControl.GuiFramework.FreeText();
			this.rICH = new NxtControl.GuiFramework.FreeText();
			this.nICH = new NxtControl.GuiFramework.FreeText();
			this.iICHP1 = new NxtControl.GuiFramework.Rectangle();
			this.iICHP1n = new NxtControl.GuiFramework.FreeText();
			this.iICHP2 = new NxtControl.GuiFramework.Polygon();
			this.iICHP2n = new NxtControl.GuiFramework.FreeText();
			this.iICHTxt = new NxtControl.GuiFramework.FreeText();
			this.rIAL = new NxtControl.GuiFramework.FreeText();
			this.nIAL = new NxtControl.GuiFramework.FreeText();
			this.iIALP1 = new NxtControl.GuiFramework.Rectangle();
			this.iIALP1n = new NxtControl.GuiFramework.FreeText();
			this.iIALP2 = new NxtControl.GuiFramework.Polygon();
			this.iIALP2n = new NxtControl.GuiFramework.FreeText();
			this.iIALTxt = new NxtControl.GuiFramework.FreeText();
			this.rIBL = new NxtControl.GuiFramework.FreeText();
			this.nIBL = new NxtControl.GuiFramework.FreeText();
			this.iIBLP1 = new NxtControl.GuiFramework.Rectangle();
			this.iIBLP1n = new NxtControl.GuiFramework.FreeText();
			this.iIBLP2 = new NxtControl.GuiFramework.Polygon();
			this.iIBLP2n = new NxtControl.GuiFramework.FreeText();
			this.iIBLTxt = new NxtControl.GuiFramework.FreeText();
			this.rICL = new NxtControl.GuiFramework.FreeText();
			this.nICL = new NxtControl.GuiFramework.FreeText();
			this.iICLP1 = new NxtControl.GuiFramework.Rectangle();
			this.iICLP1n = new NxtControl.GuiFramework.FreeText();
			this.iICLP2 = new NxtControl.GuiFramework.Polygon();
			this.iICLP2n = new NxtControl.GuiFramework.FreeText();
			this.iICLTxt = new NxtControl.GuiFramework.FreeText();
			this.rFRH = new NxtControl.GuiFramework.FreeText();
			this.nFRH = new NxtControl.GuiFramework.FreeText();
			this.iFRHP1 = new NxtControl.GuiFramework.Rectangle();
			this.iFRHP1n = new NxtControl.GuiFramework.FreeText();
			this.iFRHP2 = new NxtControl.GuiFramework.Polygon();
			this.iFRHP2n = new NxtControl.GuiFramework.FreeText();
			this.iFRHTxt = new NxtControl.GuiFramework.FreeText();
			this.rFRL = new NxtControl.GuiFramework.FreeText();
			this.nFRL = new NxtControl.GuiFramework.FreeText();
			this.iFRLP1 = new NxtControl.GuiFramework.Rectangle();
			this.iFRLP1n = new NxtControl.GuiFramework.FreeText();
			this.iFRLP2 = new NxtControl.GuiFramework.Polygon();
			this.iFRLP2n = new NxtControl.GuiFramework.FreeText();
			this.iFRLTxt = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnAjustes = new NxtControl.GuiFramework.DrawnButton();
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
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(560D)), ((float)(64D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "Normal";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 39D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 54D),
			new NxtControl.Drawing.PointF(28D, 38D),
			new NxtControl.Drawing.PointF(36D, 54D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 42D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 38D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// lin0
			// 
			this.lin0.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(73D)), ((float)(536D)), ((float)(26D)));
			this.lin0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin0.Name = "lin0";
			this.lin0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot0
			// 
			this.rot0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot0.Location = new NxtControl.Drawing.PointF(22D, 77D);
			this.rot0.Name = "rot0";
			this.rot0.Text = "Tensão A-B / B-C / C-A";
			// 
			// v0_0
			// 
			this.v0_0.BeginInit();
			this.v0_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v0_0.DecimalPlacesCount = ((uint)(0u));
			this.v0_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 74D);
			this.v0_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v0_0.FontScale = false;
			this.v0_0.IsOnlyInput = true;
			this.v0_0.IsPrefixSuffixOutside = false;
			this.v0_0.LeadingZeros = ((uint)(0u));
			this.v0_0.Name = "v0_0";
			this.v0_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v0_0.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.v0_0.Suffix = " V";
			this.v0_0.TagName = "STS_TENSAO_AB";
			this.v0_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v0_0.EndInit();
			// 
			// v0_1
			// 
			this.v0_1.BeginInit();
			this.v0_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v0_1.DecimalPlacesCount = ((uint)(0u));
			this.v0_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 340D, 74D);
			this.v0_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v0_1.FontScale = false;
			this.v0_1.IsOnlyInput = true;
			this.v0_1.IsPrefixSuffixOutside = false;
			this.v0_1.LeadingZeros = ((uint)(0u));
			this.v0_1.Name = "v0_1";
			this.v0_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v0_1.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.v0_1.Suffix = " V";
			this.v0_1.TagName = "STS_TENSAO_BC";
			this.v0_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v0_1.EndInit();
			// 
			// v0_2
			// 
			this.v0_2.BeginInit();
			this.v0_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v0_2.DecimalPlacesCount = ((uint)(0u));
			this.v0_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 444D, 74D);
			this.v0_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v0_2.FontScale = false;
			this.v0_2.IsOnlyInput = true;
			this.v0_2.IsPrefixSuffixOutside = false;
			this.v0_2.LeadingZeros = ((uint)(0u));
			this.v0_2.Name = "v0_2";
			this.v0_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v0_2.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.v0_2.Suffix = " V";
			this.v0_2.TagName = "STS_TENSAO_CA";
			this.v0_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v0_2.EndInit();
			// 
			// lin1
			// 
			this.lin1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(103D)), ((float)(536D)), ((float)(26D)));
			this.lin1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin1.Name = "lin1";
			this.lin1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot1
			// 
			this.rot1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot1.Location = new NxtControl.Drawing.PointF(22D, 107D);
			this.rot1.Name = "rot1";
			this.rot1.Text = "Tensão A-N / B-N / C-N";
			// 
			// v1_0
			// 
			this.v1_0.BeginInit();
			this.v1_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v1_0.DecimalPlacesCount = ((uint)(0u));
			this.v1_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 104D);
			this.v1_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v1_0.FontScale = false;
			this.v1_0.IsOnlyInput = true;
			this.v1_0.IsPrefixSuffixOutside = false;
			this.v1_0.LeadingZeros = ((uint)(0u));
			this.v1_0.Name = "v1_0";
			this.v1_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary4.Add("Text", "${Value}");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary4.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary4.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v1_0.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.v1_0.Suffix = " V";
			this.v1_0.TagName = "STS_TENSAO_AN";
			this.v1_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v1_0.EndInit();
			// 
			// v1_1
			// 
			this.v1_1.BeginInit();
			this.v1_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v1_1.DecimalPlacesCount = ((uint)(0u));
			this.v1_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 340D, 104D);
			this.v1_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v1_1.FontScale = false;
			this.v1_1.IsOnlyInput = true;
			this.v1_1.IsPrefixSuffixOutside = false;
			this.v1_1.LeadingZeros = ((uint)(0u));
			this.v1_1.Name = "v1_1";
			this.v1_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v1_1.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.v1_1.Suffix = " V";
			this.v1_1.TagName = "STS_TENSAO_BN";
			this.v1_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v1_1.EndInit();
			// 
			// v1_2
			// 
			this.v1_2.BeginInit();
			this.v1_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v1_2.DecimalPlacesCount = ((uint)(0u));
			this.v1_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 444D, 104D);
			this.v1_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v1_2.FontScale = false;
			this.v1_2.IsOnlyInput = true;
			this.v1_2.IsPrefixSuffixOutside = false;
			this.v1_2.LeadingZeros = ((uint)(0u));
			this.v1_2.Name = "v1_2";
			this.v1_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary6.Add("Text", "${Value}");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary6.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary6.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v1_2.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.v1_2.Suffix = " V";
			this.v1_2.TagName = "STS_TENSAO_CN";
			this.v1_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v1_2.EndInit();
			// 
			// lin2
			// 
			this.lin2.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(133D)), ((float)(536D)), ((float)(26D)));
			this.lin2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin2.Name = "lin2";
			this.lin2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot2
			// 
			this.rot2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot2.Location = new NxtControl.Drawing.PointF(22D, 137D);
			this.rot2.Name = "rot2";
			this.rot2.Text = "Corrente A / B / C";
			// 
			// v2_0
			// 
			this.v2_0.BeginInit();
			this.v2_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v2_0.DecimalPlacesCount = ((uint)(1u));
			this.v2_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 134D);
			this.v2_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v2_0.FontScale = false;
			this.v2_0.IsOnlyInput = true;
			this.v2_0.IsPrefixSuffixOutside = false;
			this.v2_0.LeadingZeros = ((uint)(0u));
			this.v2_0.Name = "v2_0";
			this.v2_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary7.Add("Text", "${Value}");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary7.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary7.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v2_0.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.v2_0.Suffix = " A";
			this.v2_0.TagName = "STS_CORRENTE_A";
			this.v2_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v2_0.EndInit();
			// 
			// v2_1
			// 
			this.v2_1.BeginInit();
			this.v2_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v2_1.DecimalPlacesCount = ((uint)(1u));
			this.v2_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 340D, 134D);
			this.v2_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v2_1.FontScale = false;
			this.v2_1.IsOnlyInput = true;
			this.v2_1.IsPrefixSuffixOutside = false;
			this.v2_1.LeadingZeros = ((uint)(0u));
			this.v2_1.Name = "v2_1";
			this.v2_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary8.Add("Text", "${Value}");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary8.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary8.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v2_1.Ranges.DefaultPropertyValues = propertyDictionary8;
			this.v2_1.Suffix = " A";
			this.v2_1.TagName = "STS_CORRENTE_B";
			this.v2_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v2_1.EndInit();
			// 
			// v2_2
			// 
			this.v2_2.BeginInit();
			this.v2_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v2_2.DecimalPlacesCount = ((uint)(1u));
			this.v2_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 444D, 134D);
			this.v2_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v2_2.FontScale = false;
			this.v2_2.IsOnlyInput = true;
			this.v2_2.IsPrefixSuffixOutside = false;
			this.v2_2.LeadingZeros = ((uint)(0u));
			this.v2_2.Name = "v2_2";
			this.v2_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary9.Add("Text", "${Value}");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary9.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary9.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v2_2.Ranges.DefaultPropertyValues = propertyDictionary9;
			this.v2_2.Suffix = " A";
			this.v2_2.TagName = "STS_CORRENTE_C";
			this.v2_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v2_2.EndInit();
			// 
			// lin3
			// 
			this.lin3.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(163D)), ((float)(536D)), ((float)(26D)));
			this.lin3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin3.Name = "lin3";
			this.lin3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot3
			// 
			this.rot3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot3.Location = new NxtControl.Drawing.PointF(22D, 167D);
			this.rot3.Name = "rot3";
			this.rot3.Text = "Potência ativa A / B / C";
			// 
			// v3_0
			// 
			this.v3_0.BeginInit();
			this.v3_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v3_0.DecimalPlacesCount = ((uint)(1u));
			this.v3_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 164D);
			this.v3_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v3_0.FontScale = false;
			this.v3_0.IsOnlyInput = true;
			this.v3_0.IsPrefixSuffixOutside = false;
			this.v3_0.LeadingZeros = ((uint)(0u));
			this.v3_0.Name = "v3_0";
			this.v3_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary10.Add("Text", "${Value}");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary10.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary10.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v3_0.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.v3_0.Suffix = " kW";
			this.v3_0.TagName = "STS_POTENCIA_ATIVA_A";
			this.v3_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v3_0.EndInit();
			// 
			// v3_1
			// 
			this.v3_1.BeginInit();
			this.v3_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v3_1.DecimalPlacesCount = ((uint)(1u));
			this.v3_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 340D, 164D);
			this.v3_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v3_1.FontScale = false;
			this.v3_1.IsOnlyInput = true;
			this.v3_1.IsPrefixSuffixOutside = false;
			this.v3_1.LeadingZeros = ((uint)(0u));
			this.v3_1.Name = "v3_1";
			this.v3_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary11.Add("Text", "${Value}");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary11.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary11.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v3_1.Ranges.DefaultPropertyValues = propertyDictionary11;
			this.v3_1.Suffix = " kW";
			this.v3_1.TagName = "STS_POTENCIA_ATIVA_B";
			this.v3_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v3_1.EndInit();
			// 
			// v3_2
			// 
			this.v3_2.BeginInit();
			this.v3_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v3_2.DecimalPlacesCount = ((uint)(1u));
			this.v3_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 444D, 164D);
			this.v3_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v3_2.FontScale = false;
			this.v3_2.IsOnlyInput = true;
			this.v3_2.IsPrefixSuffixOutside = false;
			this.v3_2.LeadingZeros = ((uint)(0u));
			this.v3_2.Name = "v3_2";
			this.v3_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary12.Add("Text", "${Value}");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary12.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary12.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v3_2.Ranges.DefaultPropertyValues = propertyDictionary12;
			this.v3_2.Suffix = " kW";
			this.v3_2.TagName = "STS_POTENCIA_ATIVA_C";
			this.v3_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v3_2.EndInit();
			// 
			// lin4
			// 
			this.lin4.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(193D)), ((float)(536D)), ((float)(26D)));
			this.lin4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin4.Name = "lin4";
			this.lin4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot4
			// 
			this.rot4.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot4.Location = new NxtControl.Drawing.PointF(22D, 197D);
			this.rot4.Name = "rot4";
			this.rot4.Text = "Potência reativa A / B / C";
			// 
			// v4_0
			// 
			this.v4_0.BeginInit();
			this.v4_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v4_0.DecimalPlacesCount = ((uint)(1u));
			this.v4_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 194D);
			this.v4_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v4_0.FontScale = false;
			this.v4_0.IsOnlyInput = true;
			this.v4_0.IsPrefixSuffixOutside = false;
			this.v4_0.LeadingZeros = ((uint)(0u));
			this.v4_0.Name = "v4_0";
			this.v4_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary13.Add("Text", "${Value}");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary13.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary13.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v4_0.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.v4_0.Suffix = " kVAr";
			this.v4_0.TagName = "STS_POTENCIA_REATIVA_A";
			this.v4_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v4_0.EndInit();
			// 
			// v4_1
			// 
			this.v4_1.BeginInit();
			this.v4_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v4_1.DecimalPlacesCount = ((uint)(1u));
			this.v4_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 340D, 194D);
			this.v4_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v4_1.FontScale = false;
			this.v4_1.IsOnlyInput = true;
			this.v4_1.IsPrefixSuffixOutside = false;
			this.v4_1.LeadingZeros = ((uint)(0u));
			this.v4_1.Name = "v4_1";
			this.v4_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary14.Add("Text", "${Value}");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary14.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary14.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v4_1.Ranges.DefaultPropertyValues = propertyDictionary14;
			this.v4_1.Suffix = " kVAr";
			this.v4_1.TagName = "STS_POTENCIA_REATIVA_B";
			this.v4_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v4_1.EndInit();
			// 
			// v4_2
			// 
			this.v4_2.BeginInit();
			this.v4_2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v4_2.DecimalPlacesCount = ((uint)(1u));
			this.v4_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 444D, 194D);
			this.v4_2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v4_2.FontScale = false;
			this.v4_2.IsOnlyInput = true;
			this.v4_2.IsPrefixSuffixOutside = false;
			this.v4_2.LeadingZeros = ((uint)(0u));
			this.v4_2.Name = "v4_2";
			this.v4_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary15.Add("Text", "${Value}");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary15.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary15.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v4_2.Ranges.DefaultPropertyValues = propertyDictionary15;
			this.v4_2.Suffix = " kVAr";
			this.v4_2.TagName = "STS_POTENCIA_REATIVA_C";
			this.v4_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v4_2.EndInit();
			// 
			// lin5
			// 
			this.lin5.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(223D)), ((float)(536D)), ((float)(26D)));
			this.lin5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin5.Name = "lin5";
			this.lin5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot5
			// 
			this.rot5.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot5.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot5.Location = new NxtControl.Drawing.PointF(22D, 227D);
			this.rot5.Name = "rot5";
			this.rot5.Text = "Potência ativa / reativa total";
			// 
			// v5_0
			// 
			this.v5_0.BeginInit();
			this.v5_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v5_0.DecimalPlacesCount = ((uint)(1u));
			this.v5_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 224D);
			this.v5_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v5_0.FontScale = false;
			this.v5_0.IsOnlyInput = true;
			this.v5_0.IsPrefixSuffixOutside = false;
			this.v5_0.LeadingZeros = ((uint)(0u));
			this.v5_0.Name = "v5_0";
			this.v5_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary16.Add("Text", "${Value}");
			propertyDictionary16.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary16.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary16.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v5_0.Ranges.DefaultPropertyValues = propertyDictionary16;
			this.v5_0.Suffix = " kW";
			this.v5_0.TagName = "STS_POTENCIA_ATIVA_TOTAL";
			this.v5_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v5_0.EndInit();
			// 
			// v5_1
			// 
			this.v5_1.BeginInit();
			this.v5_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v5_1.DecimalPlacesCount = ((uint)(1u));
			this.v5_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 340D, 224D);
			this.v5_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v5_1.FontScale = false;
			this.v5_1.IsOnlyInput = true;
			this.v5_1.IsPrefixSuffixOutside = false;
			this.v5_1.LeadingZeros = ((uint)(0u));
			this.v5_1.Name = "v5_1";
			this.v5_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary17.Add("Text", "${Value}");
			propertyDictionary17.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary17.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary17.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v5_1.Ranges.DefaultPropertyValues = propertyDictionary17;
			this.v5_1.Suffix = " kVAr";
			this.v5_1.TagName = "STS_POTENCIA_REATIVA_TOTAL";
			this.v5_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v5_1.EndInit();
			// 
			// lin6
			// 
			this.lin6.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(253D)), ((float)(536D)), ((float)(26D)));
			this.lin6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin6.Name = "lin6";
			this.lin6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot6
			// 
			this.rot6.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot6.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot6.Location = new NxtControl.Drawing.PointF(22D, 257D);
			this.rot6.Name = "rot6";
			this.rot6.Text = "Potência aparente total";
			// 
			// v6_0
			// 
			this.v6_0.BeginInit();
			this.v6_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v6_0.DecimalPlacesCount = ((uint)(1u));
			this.v6_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 254D);
			this.v6_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v6_0.FontScale = false;
			this.v6_0.IsOnlyInput = true;
			this.v6_0.IsPrefixSuffixOutside = false;
			this.v6_0.LeadingZeros = ((uint)(0u));
			this.v6_0.Name = "v6_0";
			this.v6_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary18.Add("Text", "${Value}");
			propertyDictionary18.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary18.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary18.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v6_0.Ranges.DefaultPropertyValues = propertyDictionary18;
			this.v6_0.Suffix = " kVA";
			this.v6_0.TagName = "STS_POTENCIA_APARENTE_TOTAL";
			this.v6_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v6_0.EndInit();
			// 
			// lin7
			// 
			this.lin7.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(283D)), ((float)(536D)), ((float)(26D)));
			this.lin7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin7.Name = "lin7";
			this.lin7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot7
			// 
			this.rot7.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot7.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rot7.Location = new NxtControl.Drawing.PointF(22D, 287D);
			this.rot7.Name = "rot7";
			this.rot7.Text = "Fator de potência / frequência";
			// 
			// v7_0
			// 
			this.v7_0.BeginInit();
			this.v7_0.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v7_0.DecimalPlacesCount = ((uint)(2u));
			this.v7_0.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 236D, 284D);
			this.v7_0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v7_0.FontScale = false;
			this.v7_0.IsOnlyInput = true;
			this.v7_0.IsPrefixSuffixOutside = false;
			this.v7_0.LeadingZeros = ((uint)(0u));
			this.v7_0.Name = "v7_0";
			this.v7_0.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary19.Add("Text", "${Value}");
			propertyDictionary19.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary19.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary19.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v7_0.Ranges.DefaultPropertyValues = propertyDictionary19;
			this.v7_0.Suffix = "";
			this.v7_0.TagName = "STS_FATOR_POTENCIAL_TOTAL";
			this.v7_0.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v7_0.EndInit();
			// 
			// v7_1
			// 
			this.v7_1.BeginInit();
			this.v7_1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.v7_1.DecimalPlacesCount = ((uint)(0u));
			this.v7_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.66D, 0D, 0D, 0.95D, 340D, 284D);
			this.v7_1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.v7_1.FontScale = false;
			this.v7_1.IsOnlyInput = true;
			this.v7_1.IsPrefixSuffixOutside = false;
			this.v7_1.LeadingZeros = ((uint)(0u));
			this.v7_1.Name = "v7_1";
			this.v7_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary20.Add("Text", "${Value}");
			propertyDictionary20.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary20.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary20.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.v7_1.Ranges.DefaultPropertyValues = propertyDictionary20;
			this.v7_1.Suffix = " Hz";
			this.v7_1.TagName = "STS_FREQUENCIA";
			this.v7_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.v7_1.EndInit();
			// 
			// tituloAlm
			// 
			this.tituloAlm.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloAlm.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloAlm.Location = new NxtControl.Drawing.PointF(20D, 322D);
			this.tituloAlm.Name = "tituloAlm";
			this.tituloAlm.Text = "Alarmes";
			// 
			// rCom
			// 
			this.rCom.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rCom.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rCom.Location = new NxtControl.Drawing.PointF(22D, 346D);
			this.rCom.Name = "rCom";
			this.rCom.Text = "Falha de comunicação";
			// 
			// nCom
			// 
			this.nCom.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nCom.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nCom.Location = new NxtControl.Drawing.PointF(208D, 346D);
			this.nCom.Name = "nCom";
			this.nCom.Text = "—";
			// 
			// iComP1
			// 
			this.iComP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(346D)), ((float)(16D)), ((float)(16D)));
			this.iComP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iComP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iComP1.Name = "iComP1";
			this.iComP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iComP1.Visible = false;
			// 
			// iComP1n
			// 
			this.iComP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iComP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iComP1n.Location = new NxtControl.Drawing.PointF(208D, 347D);
			this.iComP1n.Name = "iComP1n";
			this.iComP1n.Text = "1";
			this.iComP1n.Visible = false;
			// 
			// iComP2
			// 
			this.iComP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(346D)), ((float)(16D)), ((float)(16D)));
			this.iComP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iComP2.Closed = true;
			this.iComP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iComP2.Name = "iComP2";
			this.iComP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iComP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 362D),
			new NxtControl.Drawing.PointF(212D, 346D),
			new NxtControl.Drawing.PointF(220D, 362D)});
			this.iComP2.Visible = false;
			// 
			// iComP2n
			// 
			this.iComP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iComP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iComP2n.Location = new NxtControl.Drawing.PointF(209D, 350D);
			this.iComP2n.Name = "iComP2n";
			this.iComP2n.Text = "2";
			this.iComP2n.Visible = false;
			// 
			// iComTxt
			// 
			this.iComTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iComTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iComTxt.Location = new NxtControl.Drawing.PointF(224D, 346D);
			this.iComTxt.Name = "iComTxt";
			this.iComTxt.Text = "";
			this.iComTxt.Visible = false;
			// 
			// rFPL
			// 
			this.rFPL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rFPL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rFPL.Location = new NxtControl.Drawing.PointF(22D, 372D);
			this.rFPL.Name = "rFPL";
			this.rFPL.Text = "Fator de potência baixo";
			// 
			// nFPL
			// 
			this.nFPL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nFPL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nFPL.Location = new NxtControl.Drawing.PointF(208D, 372D);
			this.nFPL.Name = "nFPL";
			this.nFPL.Text = "—";
			// 
			// iFPLP1
			// 
			this.iFPLP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(372D)), ((float)(16D)), ((float)(16D)));
			this.iFPLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iFPLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFPLP1.Name = "iFPLP1";
			this.iFPLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFPLP1.Visible = false;
			// 
			// iFPLP1n
			// 
			this.iFPLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iFPLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFPLP1n.Location = new NxtControl.Drawing.PointF(208D, 373D);
			this.iFPLP1n.Name = "iFPLP1n";
			this.iFPLP1n.Text = "1";
			this.iFPLP1n.Visible = false;
			// 
			// iFPLP2
			// 
			this.iFPLP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(372D)), ((float)(16D)), ((float)(16D)));
			this.iFPLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iFPLP2.Closed = true;
			this.iFPLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFPLP2.Name = "iFPLP2";
			this.iFPLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFPLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 388D),
			new NxtControl.Drawing.PointF(212D, 372D),
			new NxtControl.Drawing.PointF(220D, 388D)});
			this.iFPLP2.Visible = false;
			// 
			// iFPLP2n
			// 
			this.iFPLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFPLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iFPLP2n.Location = new NxtControl.Drawing.PointF(209D, 376D);
			this.iFPLP2n.Name = "iFPLP2n";
			this.iFPLP2n.Text = "2";
			this.iFPLP2n.Visible = false;
			// 
			// iFPLTxt
			// 
			this.iFPLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFPLTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFPLTxt.Location = new NxtControl.Drawing.PointF(224D, 372D);
			this.iFPLTxt.Name = "iFPLTxt";
			this.iFPLTxt.Text = "";
			this.iFPLTxt.Visible = false;
			// 
			// rVFH
			// 
			this.rVFH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rVFH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rVFH.Location = new NxtControl.Drawing.PointF(22D, 398D);
			this.rVFH.Name = "rVFH";
			this.rVFH.Text = "Tensão entre fases alta";
			// 
			// nVFH
			// 
			this.nVFH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nVFH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nVFH.Location = new NxtControl.Drawing.PointF(208D, 398D);
			this.nVFH.Name = "nVFH";
			this.nVFH.Text = "—";
			// 
			// iVFHP1
			// 
			this.iVFHP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(398D)), ((float)(16D)), ((float)(16D)));
			this.iVFHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iVFHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVFHP1.Name = "iVFHP1";
			this.iVFHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVFHP1.Visible = false;
			// 
			// iVFHP1n
			// 
			this.iVFHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iVFHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVFHP1n.Location = new NxtControl.Drawing.PointF(208D, 399D);
			this.iVFHP1n.Name = "iVFHP1n";
			this.iVFHP1n.Text = "1";
			this.iVFHP1n.Visible = false;
			// 
			// iVFHP2
			// 
			this.iVFHP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(398D)), ((float)(16D)), ((float)(16D)));
			this.iVFHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iVFHP2.Closed = true;
			this.iVFHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVFHP2.Name = "iVFHP2";
			this.iVFHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVFHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 414D),
			new NxtControl.Drawing.PointF(212D, 398D),
			new NxtControl.Drawing.PointF(220D, 414D)});
			this.iVFHP2.Visible = false;
			// 
			// iVFHP2n
			// 
			this.iVFHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVFHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iVFHP2n.Location = new NxtControl.Drawing.PointF(209D, 402D);
			this.iVFHP2n.Name = "iVFHP2n";
			this.iVFHP2n.Text = "2";
			this.iVFHP2n.Visible = false;
			// 
			// iVFHTxt
			// 
			this.iVFHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVFHTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVFHTxt.Location = new NxtControl.Drawing.PointF(224D, 398D);
			this.iVFHTxt.Name = "iVFHTxt";
			this.iVFHTxt.Text = "";
			this.iVFHTxt.Visible = false;
			// 
			// rVFL
			// 
			this.rVFL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rVFL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rVFL.Location = new NxtControl.Drawing.PointF(22D, 424D);
			this.rVFL.Name = "rVFL";
			this.rVFL.Text = "Tensão entre fases baixa";
			// 
			// nVFL
			// 
			this.nVFL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nVFL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nVFL.Location = new NxtControl.Drawing.PointF(208D, 424D);
			this.nVFL.Name = "nVFL";
			this.nVFL.Text = "—";
			// 
			// iVFLP1
			// 
			this.iVFLP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(424D)), ((float)(16D)), ((float)(16D)));
			this.iVFLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iVFLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVFLP1.Name = "iVFLP1";
			this.iVFLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVFLP1.Visible = false;
			// 
			// iVFLP1n
			// 
			this.iVFLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iVFLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVFLP1n.Location = new NxtControl.Drawing.PointF(208D, 425D);
			this.iVFLP1n.Name = "iVFLP1n";
			this.iVFLP1n.Text = "1";
			this.iVFLP1n.Visible = false;
			// 
			// iVFLP2
			// 
			this.iVFLP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(424D)), ((float)(16D)), ((float)(16D)));
			this.iVFLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iVFLP2.Closed = true;
			this.iVFLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVFLP2.Name = "iVFLP2";
			this.iVFLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVFLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 440D),
			new NxtControl.Drawing.PointF(212D, 424D),
			new NxtControl.Drawing.PointF(220D, 440D)});
			this.iVFLP2.Visible = false;
			// 
			// iVFLP2n
			// 
			this.iVFLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVFLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iVFLP2n.Location = new NxtControl.Drawing.PointF(209D, 428D);
			this.iVFLP2n.Name = "iVFLP2n";
			this.iVFLP2n.Text = "2";
			this.iVFLP2n.Visible = false;
			// 
			// iVFLTxt
			// 
			this.iVFLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVFLTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVFLTxt.Location = new NxtControl.Drawing.PointF(224D, 424D);
			this.iVFLTxt.Name = "iVFLTxt";
			this.iVFLTxt.Text = "";
			this.iVFLTxt.Visible = false;
			// 
			// rVNH
			// 
			this.rVNH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rVNH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rVNH.Location = new NxtControl.Drawing.PointF(22D, 450D);
			this.rVNH.Name = "rVNH";
			this.rVNH.Text = "Tensão fase-neutro alta";
			// 
			// nVNH
			// 
			this.nVNH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nVNH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nVNH.Location = new NxtControl.Drawing.PointF(208D, 450D);
			this.nVNH.Name = "nVNH";
			this.nVNH.Text = "—";
			// 
			// iVNHP1
			// 
			this.iVNHP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(450D)), ((float)(16D)), ((float)(16D)));
			this.iVNHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iVNHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVNHP1.Name = "iVNHP1";
			this.iVNHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVNHP1.Visible = false;
			// 
			// iVNHP1n
			// 
			this.iVNHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iVNHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVNHP1n.Location = new NxtControl.Drawing.PointF(208D, 451D);
			this.iVNHP1n.Name = "iVNHP1n";
			this.iVNHP1n.Text = "1";
			this.iVNHP1n.Visible = false;
			// 
			// iVNHP2
			// 
			this.iVNHP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(450D)), ((float)(16D)), ((float)(16D)));
			this.iVNHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iVNHP2.Closed = true;
			this.iVNHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVNHP2.Name = "iVNHP2";
			this.iVNHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVNHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 466D),
			new NxtControl.Drawing.PointF(212D, 450D),
			new NxtControl.Drawing.PointF(220D, 466D)});
			this.iVNHP2.Visible = false;
			// 
			// iVNHP2n
			// 
			this.iVNHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVNHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iVNHP2n.Location = new NxtControl.Drawing.PointF(209D, 454D);
			this.iVNHP2n.Name = "iVNHP2n";
			this.iVNHP2n.Text = "2";
			this.iVNHP2n.Visible = false;
			// 
			// iVNHTxt
			// 
			this.iVNHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVNHTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVNHTxt.Location = new NxtControl.Drawing.PointF(224D, 450D);
			this.iVNHTxt.Name = "iVNHTxt";
			this.iVNHTxt.Text = "";
			this.iVNHTxt.Visible = false;
			// 
			// rVNL
			// 
			this.rVNL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rVNL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rVNL.Location = new NxtControl.Drawing.PointF(22D, 476D);
			this.rVNL.Name = "rVNL";
			this.rVNL.Text = "Tensão fase-neutro baixa";
			// 
			// nVNL
			// 
			this.nVNL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nVNL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nVNL.Location = new NxtControl.Drawing.PointF(208D, 476D);
			this.nVNL.Name = "nVNL";
			this.nVNL.Text = "—";
			// 
			// iVNLP1
			// 
			this.iVNLP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(476D)), ((float)(16D)), ((float)(16D)));
			this.iVNLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iVNLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVNLP1.Name = "iVNLP1";
			this.iVNLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVNLP1.Visible = false;
			// 
			// iVNLP1n
			// 
			this.iVNLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iVNLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVNLP1n.Location = new NxtControl.Drawing.PointF(208D, 477D);
			this.iVNLP1n.Name = "iVNLP1n";
			this.iVNLP1n.Text = "1";
			this.iVNLP1n.Visible = false;
			// 
			// iVNLP2
			// 
			this.iVNLP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(476D)), ((float)(16D)), ((float)(16D)));
			this.iVNLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iVNLP2.Closed = true;
			this.iVNLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iVNLP2.Name = "iVNLP2";
			this.iVNLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iVNLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 492D),
			new NxtControl.Drawing.PointF(212D, 476D),
			new NxtControl.Drawing.PointF(220D, 492D)});
			this.iVNLP2.Visible = false;
			// 
			// iVNLP2n
			// 
			this.iVNLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVNLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iVNLP2n.Location = new NxtControl.Drawing.PointF(209D, 480D);
			this.iVNLP2n.Name = "iVNLP2n";
			this.iVNLP2n.Text = "2";
			this.iVNLP2n.Visible = false;
			// 
			// iVNLTxt
			// 
			this.iVNLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iVNLTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iVNLTxt.Location = new NxtControl.Drawing.PointF(224D, 476D);
			this.iVNLTxt.Name = "iVNLTxt";
			this.iVNLTxt.Text = "";
			this.iVNLTxt.Visible = false;
			// 
			// rIAH
			// 
			this.rIAH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rIAH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rIAH.Location = new NxtControl.Drawing.PointF(22D, 502D);
			this.rIAH.Name = "rIAH";
			this.rIAH.Text = "Corrente fase A alta";
			// 
			// nIAH
			// 
			this.nIAH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nIAH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nIAH.Location = new NxtControl.Drawing.PointF(208D, 502D);
			this.nIAH.Name = "nIAH";
			this.nIAH.Text = "—";
			// 
			// iIAHP1
			// 
			this.iIAHP1.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iIAHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iIAHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIAHP1.Name = "iIAHP1";
			this.iIAHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIAHP1.Visible = false;
			// 
			// iIAHP1n
			// 
			this.iIAHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iIAHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIAHP1n.Location = new NxtControl.Drawing.PointF(208D, 503D);
			this.iIAHP1n.Name = "iIAHP1n";
			this.iIAHP1n.Text = "1";
			this.iIAHP1n.Visible = false;
			// 
			// iIAHP2
			// 
			this.iIAHP2.Bounds = new NxtControl.Drawing.RectF(((float)(204D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iIAHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iIAHP2.Closed = true;
			this.iIAHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIAHP2.Name = "iIAHP2";
			this.iIAHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIAHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(204D, 518D),
			new NxtControl.Drawing.PointF(212D, 502D),
			new NxtControl.Drawing.PointF(220D, 518D)});
			this.iIAHP2.Visible = false;
			// 
			// iIAHP2n
			// 
			this.iIAHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIAHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iIAHP2n.Location = new NxtControl.Drawing.PointF(209D, 506D);
			this.iIAHP2n.Name = "iIAHP2n";
			this.iIAHP2n.Text = "2";
			this.iIAHP2n.Visible = false;
			// 
			// iIAHTxt
			// 
			this.iIAHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIAHTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIAHTxt.Location = new NxtControl.Drawing.PointF(224D, 502D);
			this.iIAHTxt.Name = "iIAHTxt";
			this.iIAHTxt.Text = "";
			this.iIAHTxt.Visible = false;
			// 
			// rIBH
			// 
			this.rIBH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rIBH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rIBH.Location = new NxtControl.Drawing.PointF(292D, 346D);
			this.rIBH.Name = "rIBH";
			this.rIBH.Text = "Corrente fase B alta";
			// 
			// nIBH
			// 
			this.nIBH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nIBH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nIBH.Location = new NxtControl.Drawing.PointF(478D, 346D);
			this.nIBH.Name = "nIBH";
			this.nIBH.Text = "—";
			// 
			// iIBHP1
			// 
			this.iIBHP1.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(346D)), ((float)(16D)), ((float)(16D)));
			this.iIBHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iIBHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIBHP1.Name = "iIBHP1";
			this.iIBHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIBHP1.Visible = false;
			// 
			// iIBHP1n
			// 
			this.iIBHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iIBHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIBHP1n.Location = new NxtControl.Drawing.PointF(478D, 347D);
			this.iIBHP1n.Name = "iIBHP1n";
			this.iIBHP1n.Text = "1";
			this.iIBHP1n.Visible = false;
			// 
			// iIBHP2
			// 
			this.iIBHP2.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(346D)), ((float)(16D)), ((float)(16D)));
			this.iIBHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iIBHP2.Closed = true;
			this.iIBHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIBHP2.Name = "iIBHP2";
			this.iIBHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIBHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(474D, 362D),
			new NxtControl.Drawing.PointF(482D, 346D),
			new NxtControl.Drawing.PointF(490D, 362D)});
			this.iIBHP2.Visible = false;
			// 
			// iIBHP2n
			// 
			this.iIBHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIBHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iIBHP2n.Location = new NxtControl.Drawing.PointF(479D, 350D);
			this.iIBHP2n.Name = "iIBHP2n";
			this.iIBHP2n.Text = "2";
			this.iIBHP2n.Visible = false;
			// 
			// iIBHTxt
			// 
			this.iIBHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIBHTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIBHTxt.Location = new NxtControl.Drawing.PointF(494D, 346D);
			this.iIBHTxt.Name = "iIBHTxt";
			this.iIBHTxt.Text = "";
			this.iIBHTxt.Visible = false;
			// 
			// rICH
			// 
			this.rICH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rICH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rICH.Location = new NxtControl.Drawing.PointF(292D, 372D);
			this.rICH.Name = "rICH";
			this.rICH.Text = "Corrente fase C alta";
			// 
			// nICH
			// 
			this.nICH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nICH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nICH.Location = new NxtControl.Drawing.PointF(478D, 372D);
			this.nICH.Name = "nICH";
			this.nICH.Text = "—";
			// 
			// iICHP1
			// 
			this.iICHP1.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(372D)), ((float)(16D)), ((float)(16D)));
			this.iICHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iICHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iICHP1.Name = "iICHP1";
			this.iICHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iICHP1.Visible = false;
			// 
			// iICHP1n
			// 
			this.iICHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iICHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iICHP1n.Location = new NxtControl.Drawing.PointF(478D, 373D);
			this.iICHP1n.Name = "iICHP1n";
			this.iICHP1n.Text = "1";
			this.iICHP1n.Visible = false;
			// 
			// iICHP2
			// 
			this.iICHP2.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(372D)), ((float)(16D)), ((float)(16D)));
			this.iICHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iICHP2.Closed = true;
			this.iICHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iICHP2.Name = "iICHP2";
			this.iICHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iICHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(474D, 388D),
			new NxtControl.Drawing.PointF(482D, 372D),
			new NxtControl.Drawing.PointF(490D, 388D)});
			this.iICHP2.Visible = false;
			// 
			// iICHP2n
			// 
			this.iICHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iICHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iICHP2n.Location = new NxtControl.Drawing.PointF(479D, 376D);
			this.iICHP2n.Name = "iICHP2n";
			this.iICHP2n.Text = "2";
			this.iICHP2n.Visible = false;
			// 
			// iICHTxt
			// 
			this.iICHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iICHTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iICHTxt.Location = new NxtControl.Drawing.PointF(494D, 372D);
			this.iICHTxt.Name = "iICHTxt";
			this.iICHTxt.Text = "";
			this.iICHTxt.Visible = false;
			// 
			// rIAL
			// 
			this.rIAL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rIAL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rIAL.Location = new NxtControl.Drawing.PointF(292D, 398D);
			this.rIAL.Name = "rIAL";
			this.rIAL.Text = "Corrente fase A baixa";
			// 
			// nIAL
			// 
			this.nIAL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nIAL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nIAL.Location = new NxtControl.Drawing.PointF(478D, 398D);
			this.nIAL.Name = "nIAL";
			this.nIAL.Text = "—";
			// 
			// iIALP1
			// 
			this.iIALP1.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(398D)), ((float)(16D)), ((float)(16D)));
			this.iIALP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iIALP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIALP1.Name = "iIALP1";
			this.iIALP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIALP1.Visible = false;
			// 
			// iIALP1n
			// 
			this.iIALP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iIALP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIALP1n.Location = new NxtControl.Drawing.PointF(478D, 399D);
			this.iIALP1n.Name = "iIALP1n";
			this.iIALP1n.Text = "1";
			this.iIALP1n.Visible = false;
			// 
			// iIALP2
			// 
			this.iIALP2.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(398D)), ((float)(16D)), ((float)(16D)));
			this.iIALP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iIALP2.Closed = true;
			this.iIALP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIALP2.Name = "iIALP2";
			this.iIALP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIALP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(474D, 414D),
			new NxtControl.Drawing.PointF(482D, 398D),
			new NxtControl.Drawing.PointF(490D, 414D)});
			this.iIALP2.Visible = false;
			// 
			// iIALP2n
			// 
			this.iIALP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIALP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iIALP2n.Location = new NxtControl.Drawing.PointF(479D, 402D);
			this.iIALP2n.Name = "iIALP2n";
			this.iIALP2n.Text = "2";
			this.iIALP2n.Visible = false;
			// 
			// iIALTxt
			// 
			this.iIALTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIALTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIALTxt.Location = new NxtControl.Drawing.PointF(494D, 398D);
			this.iIALTxt.Name = "iIALTxt";
			this.iIALTxt.Text = "";
			this.iIALTxt.Visible = false;
			// 
			// rIBL
			// 
			this.rIBL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rIBL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rIBL.Location = new NxtControl.Drawing.PointF(292D, 424D);
			this.rIBL.Name = "rIBL";
			this.rIBL.Text = "Corrente fase B baixa";
			// 
			// nIBL
			// 
			this.nIBL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nIBL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nIBL.Location = new NxtControl.Drawing.PointF(478D, 424D);
			this.nIBL.Name = "nIBL";
			this.nIBL.Text = "—";
			// 
			// iIBLP1
			// 
			this.iIBLP1.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(424D)), ((float)(16D)), ((float)(16D)));
			this.iIBLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iIBLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIBLP1.Name = "iIBLP1";
			this.iIBLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIBLP1.Visible = false;
			// 
			// iIBLP1n
			// 
			this.iIBLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iIBLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIBLP1n.Location = new NxtControl.Drawing.PointF(478D, 425D);
			this.iIBLP1n.Name = "iIBLP1n";
			this.iIBLP1n.Text = "1";
			this.iIBLP1n.Visible = false;
			// 
			// iIBLP2
			// 
			this.iIBLP2.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(424D)), ((float)(16D)), ((float)(16D)));
			this.iIBLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iIBLP2.Closed = true;
			this.iIBLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iIBLP2.Name = "iIBLP2";
			this.iIBLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iIBLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(474D, 440D),
			new NxtControl.Drawing.PointF(482D, 424D),
			new NxtControl.Drawing.PointF(490D, 440D)});
			this.iIBLP2.Visible = false;
			// 
			// iIBLP2n
			// 
			this.iIBLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIBLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iIBLP2n.Location = new NxtControl.Drawing.PointF(479D, 428D);
			this.iIBLP2n.Name = "iIBLP2n";
			this.iIBLP2n.Text = "2";
			this.iIBLP2n.Visible = false;
			// 
			// iIBLTxt
			// 
			this.iIBLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iIBLTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iIBLTxt.Location = new NxtControl.Drawing.PointF(494D, 424D);
			this.iIBLTxt.Name = "iIBLTxt";
			this.iIBLTxt.Text = "";
			this.iIBLTxt.Visible = false;
			// 
			// rICL
			// 
			this.rICL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rICL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rICL.Location = new NxtControl.Drawing.PointF(292D, 450D);
			this.rICL.Name = "rICL";
			this.rICL.Text = "Corrente fase C baixa";
			// 
			// nICL
			// 
			this.nICL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nICL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nICL.Location = new NxtControl.Drawing.PointF(478D, 450D);
			this.nICL.Name = "nICL";
			this.nICL.Text = "—";
			// 
			// iICLP1
			// 
			this.iICLP1.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(450D)), ((float)(16D)), ((float)(16D)));
			this.iICLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iICLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iICLP1.Name = "iICLP1";
			this.iICLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iICLP1.Visible = false;
			// 
			// iICLP1n
			// 
			this.iICLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iICLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iICLP1n.Location = new NxtControl.Drawing.PointF(478D, 451D);
			this.iICLP1n.Name = "iICLP1n";
			this.iICLP1n.Text = "1";
			this.iICLP1n.Visible = false;
			// 
			// iICLP2
			// 
			this.iICLP2.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(450D)), ((float)(16D)), ((float)(16D)));
			this.iICLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iICLP2.Closed = true;
			this.iICLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iICLP2.Name = "iICLP2";
			this.iICLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iICLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(474D, 466D),
			new NxtControl.Drawing.PointF(482D, 450D),
			new NxtControl.Drawing.PointF(490D, 466D)});
			this.iICLP2.Visible = false;
			// 
			// iICLP2n
			// 
			this.iICLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iICLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iICLP2n.Location = new NxtControl.Drawing.PointF(479D, 454D);
			this.iICLP2n.Name = "iICLP2n";
			this.iICLP2n.Text = "2";
			this.iICLP2n.Visible = false;
			// 
			// iICLTxt
			// 
			this.iICLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iICLTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iICLTxt.Location = new NxtControl.Drawing.PointF(494D, 450D);
			this.iICLTxt.Name = "iICLTxt";
			this.iICLTxt.Text = "";
			this.iICLTxt.Visible = false;
			// 
			// rFRH
			// 
			this.rFRH.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rFRH.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rFRH.Location = new NxtControl.Drawing.PointF(292D, 476D);
			this.rFRH.Name = "rFRH";
			this.rFRH.Text = "Frequência alta";
			// 
			// nFRH
			// 
			this.nFRH.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nFRH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nFRH.Location = new NxtControl.Drawing.PointF(478D, 476D);
			this.nFRH.Name = "nFRH";
			this.nFRH.Text = "—";
			// 
			// iFRHP1
			// 
			this.iFRHP1.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(476D)), ((float)(16D)), ((float)(16D)));
			this.iFRHP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iFRHP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFRHP1.Name = "iFRHP1";
			this.iFRHP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFRHP1.Visible = false;
			// 
			// iFRHP1n
			// 
			this.iFRHP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iFRHP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFRHP1n.Location = new NxtControl.Drawing.PointF(478D, 477D);
			this.iFRHP1n.Name = "iFRHP1n";
			this.iFRHP1n.Text = "1";
			this.iFRHP1n.Visible = false;
			// 
			// iFRHP2
			// 
			this.iFRHP2.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(476D)), ((float)(16D)), ((float)(16D)));
			this.iFRHP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iFRHP2.Closed = true;
			this.iFRHP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFRHP2.Name = "iFRHP2";
			this.iFRHP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFRHP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(474D, 492D),
			new NxtControl.Drawing.PointF(482D, 476D),
			new NxtControl.Drawing.PointF(490D, 492D)});
			this.iFRHP2.Visible = false;
			// 
			// iFRHP2n
			// 
			this.iFRHP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFRHP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iFRHP2n.Location = new NxtControl.Drawing.PointF(479D, 480D);
			this.iFRHP2n.Name = "iFRHP2n";
			this.iFRHP2n.Text = "2";
			this.iFRHP2n.Visible = false;
			// 
			// iFRHTxt
			// 
			this.iFRHTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFRHTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFRHTxt.Location = new NxtControl.Drawing.PointF(494D, 476D);
			this.iFRHTxt.Name = "iFRHTxt";
			this.iFRHTxt.Text = "";
			this.iFRHTxt.Visible = false;
			// 
			// rFRL
			// 
			this.rFRL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rFRL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rFRL.Location = new NxtControl.Drawing.PointF(292D, 502D);
			this.rFRL.Name = "rFRL";
			this.rFRL.Text = "Frequência baixa";
			// 
			// nFRL
			// 
			this.nFRL.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nFRL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nFRL.Location = new NxtControl.Drawing.PointF(478D, 502D);
			this.nFRL.Name = "nFRL";
			this.nFRL.Text = "—";
			// 
			// iFRLP1
			// 
			this.iFRLP1.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iFRLP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iFRLP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFRLP1.Name = "iFRLP1";
			this.iFRLP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFRLP1.Visible = false;
			// 
			// iFRLP1n
			// 
			this.iFRLP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iFRLP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFRLP1n.Location = new NxtControl.Drawing.PointF(478D, 503D);
			this.iFRLP1n.Name = "iFRLP1n";
			this.iFRLP1n.Text = "1";
			this.iFRLP1n.Visible = false;
			// 
			// iFRLP2
			// 
			this.iFRLP2.Bounds = new NxtControl.Drawing.RectF(((float)(474D)), ((float)(502D)), ((float)(16D)), ((float)(16D)));
			this.iFRLP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iFRLP2.Closed = true;
			this.iFRLP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFRLP2.Name = "iFRLP2";
			this.iFRLP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFRLP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(474D, 518D),
			new NxtControl.Drawing.PointF(482D, 502D),
			new NxtControl.Drawing.PointF(490D, 518D)});
			this.iFRLP2.Visible = false;
			// 
			// iFRLP2n
			// 
			this.iFRLP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFRLP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iFRLP2n.Location = new NxtControl.Drawing.PointF(479D, 506D);
			this.iFRLP2n.Name = "iFRLP2n";
			this.iFRLP2n.Text = "2";
			this.iFRLP2n.Visible = false;
			// 
			// iFRLTxt
			// 
			this.iFRLTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFRLTxt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFRLTxt.Location = new NxtControl.Drawing.PointF(494D, 502D);
			this.iFRLTxt.Name = "iFRLTxt";
			this.iFRLTxt.Text = "";
			this.iFRLTxt.Visible = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(538D)), ((float)(200D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer / Reset";
			this.btnReset.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnAjustes
			// 
			this.btnAjustes.Bounds = new NxtControl.Drawing.RectF(((float)(340D)), ((float)(538D)), ((float)(200D)), ((float)(34D)));
			this.btnAjustes.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAjustes.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnAjustes.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAjustes.Name = "btnAjustes";
			this.btnAjustes.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpParameter", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnAjustes.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAjustes.Radius = 2D;
			this.btnAjustes.Text = "Ajustes";
			this.btnAjustes.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAjustes.Use3DEffect = false;
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
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(560D)), ((float)(588D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.textoEstado,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.lin0,
			this.rot0,
			this.v0_0,
			this.v0_1,
			this.v0_2,
			this.lin1,
			this.rot1,
			this.v1_0,
			this.v1_1,
			this.v1_2,
			this.lin2,
			this.rot2,
			this.v2_0,
			this.v2_1,
			this.v2_2,
			this.lin3,
			this.rot3,
			this.v3_0,
			this.v3_1,
			this.v3_2,
			this.lin4,
			this.rot4,
			this.v4_0,
			this.v4_1,
			this.v4_2,
			this.lin5,
			this.rot5,
			this.v5_0,
			this.v5_1,
			this.lin6,
			this.rot6,
			this.v6_0,
			this.lin7,
			this.rot7,
			this.v7_0,
			this.v7_1,
			this.tituloAlm,
			this.rCom,
			this.nCom,
			this.iComP1,
			this.iComP1n,
			this.iComP2,
			this.iComP2n,
			this.iComTxt,
			this.rFPL,
			this.nFPL,
			this.iFPLP1,
			this.iFPLP1n,
			this.iFPLP2,
			this.iFPLP2n,
			this.iFPLTxt,
			this.rVFH,
			this.nVFH,
			this.iVFHP1,
			this.iVFHP1n,
			this.iVFHP2,
			this.iVFHP2n,
			this.iVFHTxt,
			this.rVFL,
			this.nVFL,
			this.iVFLP1,
			this.iVFLP1n,
			this.iVFLP2,
			this.iVFLP2n,
			this.iVFLTxt,
			this.rVNH,
			this.nVNH,
			this.iVNHP1,
			this.iVNHP1n,
			this.iVNHP2,
			this.iVNHP2n,
			this.iVNHTxt,
			this.rVNL,
			this.nVNL,
			this.iVNLP1,
			this.iVNLP1n,
			this.iVNLP2,
			this.iVNLP2n,
			this.iVNLTxt,
			this.rIAH,
			this.nIAH,
			this.iIAHP1,
			this.iIAHP1n,
			this.iIAHP2,
			this.iIAHP2n,
			this.iIAHTxt,
			this.rIBH,
			this.nIBH,
			this.iIBHP1,
			this.iIBHP1n,
			this.iIBHP2,
			this.iIBHP2n,
			this.iIBHTxt,
			this.rICH,
			this.nICH,
			this.iICHP1,
			this.iICHP1n,
			this.iICHP2,
			this.iICHP2n,
			this.iICHTxt,
			this.rIAL,
			this.nIAL,
			this.iIALP1,
			this.iIALP1n,
			this.iIALP2,
			this.iIALP2n,
			this.iIALTxt,
			this.rIBL,
			this.nIBL,
			this.iIBLP1,
			this.iIBLP1n,
			this.iIBLP2,
			this.iIBLP2n,
			this.iIBLTxt,
			this.rICL,
			this.nICL,
			this.iICLP1,
			this.iICLP1n,
			this.iICLP2,
			this.iICLP2n,
			this.iICLTxt,
			this.rFRH,
			this.nFRH,
			this.iFRHP1,
			this.iFRHP1n,
			this.iFRHP2,
			this.iFRHP2n,
			this.iFRHTxt,
			this.rFRL,
			this.nFRL,
			this.iFRLP1,
			this.iFRLP1n,
			this.iFRLP2,
			this.iFRLP2n,
			this.iFRLTxt,
			this.btnReset,
			this.btnAjustes,
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
			this.xEFRL});
			this.Size = new System.Drawing.Size(560, 588);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.Rectangle lin0;
		private NxtControl.GuiFramework.FreeText rot0;
		private System.HMI.Symbols.Base.Label<System.Single> v0_0;
		private System.HMI.Symbols.Base.Label<System.Single> v0_1;
		private System.HMI.Symbols.Base.Label<System.Single> v0_2;
		private NxtControl.GuiFramework.Rectangle lin1;
		private NxtControl.GuiFramework.FreeText rot1;
		private System.HMI.Symbols.Base.Label<System.Single> v1_0;
		private System.HMI.Symbols.Base.Label<System.Single> v1_1;
		private System.HMI.Symbols.Base.Label<System.Single> v1_2;
		private NxtControl.GuiFramework.Rectangle lin2;
		private NxtControl.GuiFramework.FreeText rot2;
		private System.HMI.Symbols.Base.Label<System.Single> v2_0;
		private System.HMI.Symbols.Base.Label<System.Single> v2_1;
		private System.HMI.Symbols.Base.Label<System.Single> v2_2;
		private NxtControl.GuiFramework.Rectangle lin3;
		private NxtControl.GuiFramework.FreeText rot3;
		private System.HMI.Symbols.Base.Label<System.Single> v3_0;
		private System.HMI.Symbols.Base.Label<System.Single> v3_1;
		private System.HMI.Symbols.Base.Label<System.Single> v3_2;
		private NxtControl.GuiFramework.Rectangle lin4;
		private NxtControl.GuiFramework.FreeText rot4;
		private System.HMI.Symbols.Base.Label<System.Single> v4_0;
		private System.HMI.Symbols.Base.Label<System.Single> v4_1;
		private System.HMI.Symbols.Base.Label<System.Single> v4_2;
		private NxtControl.GuiFramework.Rectangle lin5;
		private NxtControl.GuiFramework.FreeText rot5;
		private System.HMI.Symbols.Base.Label<System.Single> v5_0;
		private System.HMI.Symbols.Base.Label<System.Single> v5_1;
		private NxtControl.GuiFramework.Rectangle lin6;
		private NxtControl.GuiFramework.FreeText rot6;
		private System.HMI.Symbols.Base.Label<System.Single> v6_0;
		private NxtControl.GuiFramework.Rectangle lin7;
		private NxtControl.GuiFramework.FreeText rot7;
		private System.HMI.Symbols.Base.Label<System.Single> v7_0;
		private System.HMI.Symbols.Base.Label<System.Single> v7_1;
		private NxtControl.GuiFramework.FreeText tituloAlm;
		private NxtControl.GuiFramework.FreeText rCom;
		private NxtControl.GuiFramework.FreeText nCom;
		private NxtControl.GuiFramework.Rectangle iComP1;
		private NxtControl.GuiFramework.FreeText iComP1n;
		private NxtControl.GuiFramework.Polygon iComP2;
		private NxtControl.GuiFramework.FreeText iComP2n;
		private NxtControl.GuiFramework.FreeText iComTxt;
		private NxtControl.GuiFramework.FreeText rFPL;
		private NxtControl.GuiFramework.FreeText nFPL;
		private NxtControl.GuiFramework.Rectangle iFPLP1;
		private NxtControl.GuiFramework.FreeText iFPLP1n;
		private NxtControl.GuiFramework.Polygon iFPLP2;
		private NxtControl.GuiFramework.FreeText iFPLP2n;
		private NxtControl.GuiFramework.FreeText iFPLTxt;
		private NxtControl.GuiFramework.FreeText rVFH;
		private NxtControl.GuiFramework.FreeText nVFH;
		private NxtControl.GuiFramework.Rectangle iVFHP1;
		private NxtControl.GuiFramework.FreeText iVFHP1n;
		private NxtControl.GuiFramework.Polygon iVFHP2;
		private NxtControl.GuiFramework.FreeText iVFHP2n;
		private NxtControl.GuiFramework.FreeText iVFHTxt;
		private NxtControl.GuiFramework.FreeText rVFL;
		private NxtControl.GuiFramework.FreeText nVFL;
		private NxtControl.GuiFramework.Rectangle iVFLP1;
		private NxtControl.GuiFramework.FreeText iVFLP1n;
		private NxtControl.GuiFramework.Polygon iVFLP2;
		private NxtControl.GuiFramework.FreeText iVFLP2n;
		private NxtControl.GuiFramework.FreeText iVFLTxt;
		private NxtControl.GuiFramework.FreeText rVNH;
		private NxtControl.GuiFramework.FreeText nVNH;
		private NxtControl.GuiFramework.Rectangle iVNHP1;
		private NxtControl.GuiFramework.FreeText iVNHP1n;
		private NxtControl.GuiFramework.Polygon iVNHP2;
		private NxtControl.GuiFramework.FreeText iVNHP2n;
		private NxtControl.GuiFramework.FreeText iVNHTxt;
		private NxtControl.GuiFramework.FreeText rVNL;
		private NxtControl.GuiFramework.FreeText nVNL;
		private NxtControl.GuiFramework.Rectangle iVNLP1;
		private NxtControl.GuiFramework.FreeText iVNLP1n;
		private NxtControl.GuiFramework.Polygon iVNLP2;
		private NxtControl.GuiFramework.FreeText iVNLP2n;
		private NxtControl.GuiFramework.FreeText iVNLTxt;
		private NxtControl.GuiFramework.FreeText rIAH;
		private NxtControl.GuiFramework.FreeText nIAH;
		private NxtControl.GuiFramework.Rectangle iIAHP1;
		private NxtControl.GuiFramework.FreeText iIAHP1n;
		private NxtControl.GuiFramework.Polygon iIAHP2;
		private NxtControl.GuiFramework.FreeText iIAHP2n;
		private NxtControl.GuiFramework.FreeText iIAHTxt;
		private NxtControl.GuiFramework.FreeText rIBH;
		private NxtControl.GuiFramework.FreeText nIBH;
		private NxtControl.GuiFramework.Rectangle iIBHP1;
		private NxtControl.GuiFramework.FreeText iIBHP1n;
		private NxtControl.GuiFramework.Polygon iIBHP2;
		private NxtControl.GuiFramework.FreeText iIBHP2n;
		private NxtControl.GuiFramework.FreeText iIBHTxt;
		private NxtControl.GuiFramework.FreeText rICH;
		private NxtControl.GuiFramework.FreeText nICH;
		private NxtControl.GuiFramework.Rectangle iICHP1;
		private NxtControl.GuiFramework.FreeText iICHP1n;
		private NxtControl.GuiFramework.Polygon iICHP2;
		private NxtControl.GuiFramework.FreeText iICHP2n;
		private NxtControl.GuiFramework.FreeText iICHTxt;
		private NxtControl.GuiFramework.FreeText rIAL;
		private NxtControl.GuiFramework.FreeText nIAL;
		private NxtControl.GuiFramework.Rectangle iIALP1;
		private NxtControl.GuiFramework.FreeText iIALP1n;
		private NxtControl.GuiFramework.Polygon iIALP2;
		private NxtControl.GuiFramework.FreeText iIALP2n;
		private NxtControl.GuiFramework.FreeText iIALTxt;
		private NxtControl.GuiFramework.FreeText rIBL;
		private NxtControl.GuiFramework.FreeText nIBL;
		private NxtControl.GuiFramework.Rectangle iIBLP1;
		private NxtControl.GuiFramework.FreeText iIBLP1n;
		private NxtControl.GuiFramework.Polygon iIBLP2;
		private NxtControl.GuiFramework.FreeText iIBLP2n;
		private NxtControl.GuiFramework.FreeText iIBLTxt;
		private NxtControl.GuiFramework.FreeText rICL;
		private NxtControl.GuiFramework.FreeText nICL;
		private NxtControl.GuiFramework.Rectangle iICLP1;
		private NxtControl.GuiFramework.FreeText iICLP1n;
		private NxtControl.GuiFramework.Polygon iICLP2;
		private NxtControl.GuiFramework.FreeText iICLP2n;
		private NxtControl.GuiFramework.FreeText iICLTxt;
		private NxtControl.GuiFramework.FreeText rFRH;
		private NxtControl.GuiFramework.FreeText nFRH;
		private NxtControl.GuiFramework.Rectangle iFRHP1;
		private NxtControl.GuiFramework.FreeText iFRHP1n;
		private NxtControl.GuiFramework.Polygon iFRHP2;
		private NxtControl.GuiFramework.FreeText iFRHP2n;
		private NxtControl.GuiFramework.FreeText iFRHTxt;
		private NxtControl.GuiFramework.FreeText rFRL;
		private NxtControl.GuiFramework.FreeText nFRL;
		private NxtControl.GuiFramework.Rectangle iFRLP1;
		private NxtControl.GuiFramework.FreeText iFRLP1n;
		private NxtControl.GuiFramework.Polygon iFRLP2;
		private NxtControl.GuiFramework.FreeText iFRLP2n;
		private NxtControl.GuiFramework.FreeText iFRLTxt;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnAjustes;
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
		#endregion
	}
}
