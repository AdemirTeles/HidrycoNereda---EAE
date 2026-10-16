/*
 * Hidryco - EEE_Bruto - fpDefault
 * ISA-101: estado, alarmes (forma + prioridade, piscando ate reconhecer), bombas, revezamento, velocidade, boias e HH do Nereda.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.EEE_Bruto
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
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.lin0 = new NxtControl.GuiFramework.Rectangle();
			this.rot0 = new NxtControl.GuiFramework.FreeText();
			this.nivel = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin1 = new NxtControl.GuiFramework.Rectangle();
			this.rot1 = new NxtControl.GuiFramework.FreeText();
			this.textoBombas = new NxtControl.GuiFramework.FreeText();
			this.lin2 = new NxtControl.GuiFramework.Rectangle();
			this.rot2 = new NxtControl.GuiFramework.FreeText();
			this.textoPrincipal = new NxtControl.GuiFramework.FreeText();
			this.lin3 = new NxtControl.GuiFramework.Rectangle();
			this.rot3 = new NxtControl.GuiFramework.FreeText();
			this.textoTroca = new NxtControl.GuiFramework.FreeText();
			this.lin4 = new NxtControl.GuiFramework.Rectangle();
			this.rot4 = new NxtControl.GuiFramework.FreeText();
			this.velocidade = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin5 = new NxtControl.GuiFramework.Rectangle();
			this.rot5 = new NxtControl.GuiFramework.FreeText();
			this.saidaPid = new System.HMI.Symbols.Base.Label<System.Single>();
			this.lin6 = new NxtControl.GuiFramework.Rectangle();
			this.rot6 = new NxtControl.GuiFramework.FreeText();
			this.textoLSL = new NxtControl.GuiFramework.FreeText();
			this.lin7 = new NxtControl.GuiFramework.Rectangle();
			this.rot7 = new NxtControl.GuiFramework.FreeText();
			this.textoLSH = new NxtControl.GuiFramework.FreeText();
			this.lin8 = new NxtControl.GuiFramework.Rectangle();
			this.rot8 = new NxtControl.GuiFramework.FreeText();
			this.textoBuffer = new NxtControl.GuiFramework.FreeText();
			this.tituloAlm = new NxtControl.GuiFramework.FreeText();
			this.rRecalque = new NxtControl.GuiFramework.FreeText();
			this.nRecalque = new NxtControl.GuiFramework.FreeText();
			this.iRecalqueP1 = new NxtControl.GuiFramework.Rectangle();
			this.iRecalqueP1n = new NxtControl.GuiFramework.FreeText();
			this.iRecalqueP2 = new NxtControl.GuiFramework.Polygon();
			this.iRecalqueP2n = new NxtControl.GuiFramework.FreeText();
			this.iRecalqueTxt = new NxtControl.GuiFramework.FreeText();
			this.rNivelAlto = new NxtControl.GuiFramework.FreeText();
			this.nNivelAlto = new NxtControl.GuiFramework.FreeText();
			this.iNivelAltoP1 = new NxtControl.GuiFramework.Rectangle();
			this.iNivelAltoP1n = new NxtControl.GuiFramework.FreeText();
			this.iNivelAltoP2 = new NxtControl.GuiFramework.Polygon();
			this.iNivelAltoP2n = new NxtControl.GuiFramework.FreeText();
			this.iNivelAltoTxt = new NxtControl.GuiFramework.FreeText();
			this.rFalhaBoia = new NxtControl.GuiFramework.FreeText();
			this.nFalhaBoia = new NxtControl.GuiFramework.FreeText();
			this.iFalhaBoiaP1 = new NxtControl.GuiFramework.Rectangle();
			this.iFalhaBoiaP1n = new NxtControl.GuiFramework.FreeText();
			this.iFalhaBoiaP2 = new NxtControl.GuiFramework.Polygon();
			this.iFalhaBoiaP2n = new NxtControl.GuiFramework.FreeText();
			this.iFalhaBoiaTxt = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnAjustes = new NxtControl.GuiFramework.DrawnButton();
			this.xEstado = new System.HMI.Symbols.Base.Execute<short>();
			this.xNec = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xLigadas = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xPrincipal = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xSegunda = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRh = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRm = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRs = new System.HMI.Symbols.Base.Execute<ushort>();
			this.xRecalque = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBoiaH = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBoiaL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFalhaBoia = new System.HMI.Symbols.Base.Execute<bool>();
			this.xNivelBaixo = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBuffer = new System.HMI.Symbols.Base.Execute<bool>();
			this.xERecalque = new System.HMI.Symbols.Base.Execute<byte>();
			this.xENivelAlto = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFalhaBoia = new System.HMI.Symbols.Base.Execute<byte>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(64D)));
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
			this.textoEstado.Text = "Parada";
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
			this.lin0.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(75D)), ((float)(376D)), ((float)(26D)));
			this.lin0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin0.Name = "lin0";
			this.lin0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot0
			// 
			this.rot0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot0.Location = new NxtControl.Drawing.PointF(22D, 79D);
			this.rot0.Name = "rot0";
			this.rot0.Text = "Nível do poço (LIT-03)";
			// 
			// nivel
			// 
			this.nivel.BeginInit();
			this.nivel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.nivel.DecimalPlacesCount = ((uint)(2u));
			this.nivel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.95D, 0D, 0D, 0.95D, 230D, 76D);
			this.nivel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.nivel.FontScale = false;
			this.nivel.IsOnlyInput = true;
			this.nivel.IsPrefixSuffixOutside = false;
			this.nivel.LeadingZeros = ((uint)(0u));
			this.nivel.Name = "nivel";
			this.nivel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.nivel.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.nivel.Suffix = "";
			this.nivel.TagName = "STS_NIVEL";
			this.nivel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.nivel.EndInit();
			// 
			// lin1
			// 
			this.lin1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(105D)), ((float)(376D)), ((float)(26D)));
			this.lin1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin1.Name = "lin1";
			this.lin1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot1
			// 
			this.rot1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot1.Location = new NxtControl.Drawing.PointF(22D, 109D);
			this.rot1.Name = "rot1";
			this.rot1.Text = "Bombas pedidas / ligadas";
			// 
			// textoBombas
			// 
			this.textoBombas.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoBombas.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoBombas.Location = new NxtControl.Drawing.PointF(240D, 109D);
			this.textoBombas.Name = "textoBombas";
			this.textoBombas.Text = "0 / 0";
			// 
			// lin2
			// 
			this.lin2.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(135D)), ((float)(376D)), ((float)(26D)));
			this.lin2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin2.Name = "lin2";
			this.lin2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot2
			// 
			this.rot2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot2.Location = new NxtControl.Drawing.PointF(22D, 139D);
			this.rot2.Name = "rot2";
			this.rot2.Text = "Principal / 2ª bomba";
			// 
			// textoPrincipal
			// 
			this.textoPrincipal.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoPrincipal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoPrincipal.Location = new NxtControl.Drawing.PointF(240D, 139D);
			this.textoPrincipal.Name = "textoPrincipal";
			this.textoPrincipal.Text = "BS-01 / BS-02";
			// 
			// lin3
			// 
			this.lin3.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(165D)), ((float)(376D)), ((float)(26D)));
			this.lin3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin3.Name = "lin3";
			this.lin3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot3
			// 
			this.rot3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot3.Location = new NxtControl.Drawing.PointF(22D, 169D);
			this.rot3.Name = "rot3";
			this.rot3.Text = "Troca da principal em";
			// 
			// textoTroca
			// 
			this.textoTroca.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoTroca.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoTroca.Location = new NxtControl.Drawing.PointF(240D, 169D);
			this.textoTroca.Name = "textoTroca";
			this.textoTroca.Text = "-";
			// 
			// lin4
			// 
			this.lin4.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(195D)), ((float)(376D)), ((float)(26D)));
			this.lin4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin4.Name = "lin4";
			this.lin4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot4
			// 
			this.rot4.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot4.Location = new NxtControl.Drawing.PointF(22D, 199D);
			this.rot4.Name = "rot4";
			this.rot4.Text = "Velocidade das bombas";
			// 
			// velocidade
			// 
			this.velocidade.BeginInit();
			this.velocidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.velocidade.DecimalPlacesCount = ((uint)(1u));
			this.velocidade.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0671D, 0D, 0D, 0.95D, 230D, 196D);
			this.velocidade.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.velocidade.FontScale = false;
			this.velocidade.IsOnlyInput = true;
			this.velocidade.IsPrefixSuffixOutside = false;
			this.velocidade.LeadingZeros = ((uint)(0u));
			this.velocidade.Name = "velocidade";
			this.velocidade.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary2.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary2.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.velocidade.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.velocidade.Suffix = " %";
			this.velocidade.TagName = "STS_VELOCIDADE";
			this.velocidade.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.velocidade.EndInit();
			// 
			// lin5
			// 
			this.lin5.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(225D)), ((float)(376D)), ((float)(26D)));
			this.lin5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin5.Name = "lin5";
			this.lin5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot5
			// 
			this.rot5.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot5.Location = new NxtControl.Drawing.PointF(22D, 229D);
			this.rot5.Name = "rot5";
			this.rot5.Text = "Saída do PID";
			// 
			// saidaPid
			// 
			this.saidaPid.BeginInit();
			this.saidaPid.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.saidaPid.DecimalPlacesCount = ((uint)(1u));
			this.saidaPid.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0671D, 0D, 0D, 0.95D, 230D, 226D);
			this.saidaPid.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.saidaPid.FontScale = false;
			this.saidaPid.IsOnlyInput = true;
			this.saidaPid.IsPrefixSuffixOutside = false;
			this.saidaPid.LeadingZeros = ((uint)(0u));
			this.saidaPid.Name = "saidaPid";
			this.saidaPid.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.saidaPid.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.saidaPid.Suffix = " %";
			this.saidaPid.TagName = "stsSaidaPID";
			this.saidaPid.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.saidaPid.EndInit();
			// 
			// lin6
			// 
			this.lin6.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(255D)), ((float)(376D)), ((float)(26D)));
			this.lin6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin6.Name = "lin6";
			this.lin6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot6
			// 
			this.rot6.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot6.Location = new NxtControl.Drawing.PointF(22D, 259D);
			this.rot6.Name = "rot6";
			this.rot6.Text = "Boia LSL-04 (nível baixo)";
			// 
			// textoLSL
			// 
			this.textoLSL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoLSL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoLSL.Location = new NxtControl.Drawing.PointF(240D, 259D);
			this.textoLSL.Name = "textoLSL";
			this.textoLSL.Text = "levantada";
			// 
			// lin7
			// 
			this.lin7.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(285D)), ((float)(376D)), ((float)(26D)));
			this.lin7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin7.Name = "lin7";
			this.lin7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot7
			// 
			this.rot7.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot7.Location = new NxtControl.Drawing.PointF(22D, 289D);
			this.rot7.Name = "rot7";
			this.rot7.Text = "Boia LSH-05 (nível alto)";
			// 
			// textoLSH
			// 
			this.textoLSH.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoLSH.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoLSH.Location = new NxtControl.Drawing.PointF(240D, 289D);
			this.textoLSH.Name = "textoLSH";
			this.textoLSH.Text = "abaixada";
			// 
			// lin8
			// 
			this.lin8.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(315D)), ((float)(376D)), ((float)(26D)));
			this.lin8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin8.Name = "lin8";
			this.lin8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot8
			// 
			this.rot8.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot8.Location = new NxtControl.Drawing.PointF(22D, 319D);
			this.rot8.Name = "rot8";
			this.rot8.Text = "Tanque do Nereda (40-LT-0001)";
			// 
			// textoBuffer
			// 
			this.textoBuffer.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoBuffer.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.textoBuffer.Location = new NxtControl.Drawing.PointF(240D, 319D);
			this.textoBuffer.Name = "textoBuffer";
			this.textoBuffer.Text = "normal";
			// 
			// tituloAlm
			// 
			this.tituloAlm.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloAlm.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloAlm.Location = new NxtControl.Drawing.PointF(20D, 354D);
			this.tituloAlm.Name = "tituloAlm";
			this.tituloAlm.Text = "Alarmes";
			// 
			// rRecalque
			// 
			this.rRecalque.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rRecalque.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rRecalque.Location = new NxtControl.Drawing.PointF(22D, 378D);
			this.rRecalque.Name = "rRecalque";
			this.rRecalque.Text = "Falha de recalque (PIT-01)";
			// 
			// nRecalque
			// 
			this.nRecalque.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nRecalque.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nRecalque.Location = new NxtControl.Drawing.PointF(304D, 378D);
			this.nRecalque.Name = "nRecalque";
			this.nRecalque.Text = "—";
			// 
			// iRecalqueP1
			// 
			this.iRecalqueP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(378D)), ((float)(16D)), ((float)(16D)));
			this.iRecalqueP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iRecalqueP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iRecalqueP1.Name = "iRecalqueP1";
			this.iRecalqueP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iRecalqueP1.Visible = false;
			// 
			// iRecalqueP1n
			// 
			this.iRecalqueP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iRecalqueP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iRecalqueP1n.Location = new NxtControl.Drawing.PointF(304D, 379D);
			this.iRecalqueP1n.Name = "iRecalqueP1n";
			this.iRecalqueP1n.Text = "1";
			this.iRecalqueP1n.Visible = false;
			// 
			// iRecalqueP2
			// 
			this.iRecalqueP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(378D)), ((float)(16D)), ((float)(16D)));
			this.iRecalqueP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iRecalqueP2.Closed = true;
			this.iRecalqueP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iRecalqueP2.Name = "iRecalqueP2";
			this.iRecalqueP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iRecalqueP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 394D),
			new NxtControl.Drawing.PointF(308D, 378D),
			new NxtControl.Drawing.PointF(316D, 394D)});
			this.iRecalqueP2.Visible = false;
			// 
			// iRecalqueP2n
			// 
			this.iRecalqueP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iRecalqueP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iRecalqueP2n.Location = new NxtControl.Drawing.PointF(305D, 382D);
			this.iRecalqueP2n.Name = "iRecalqueP2n";
			this.iRecalqueP2n.Text = "2";
			this.iRecalqueP2n.Visible = false;
			// 
			// iRecalqueTxt
			// 
			this.iRecalqueTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iRecalqueTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iRecalqueTxt.Location = new NxtControl.Drawing.PointF(320D, 378D);
			this.iRecalqueTxt.Name = "iRecalqueTxt";
			this.iRecalqueTxt.Text = "";
			this.iRecalqueTxt.Visible = false;
			// 
			// rNivelAlto
			// 
			this.rNivelAlto.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rNivelAlto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rNivelAlto.Location = new NxtControl.Drawing.PointF(22D, 404D);
			this.rNivelAlto.Name = "rNivelAlto";
			this.rNivelAlto.Text = "Nível alto (LSH-05)";
			// 
			// nNivelAlto
			// 
			this.nNivelAlto.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nNivelAlto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nNivelAlto.Location = new NxtControl.Drawing.PointF(304D, 404D);
			this.nNivelAlto.Name = "nNivelAlto";
			this.nNivelAlto.Text = "—";
			// 
			// iNivelAltoP1
			// 
			this.iNivelAltoP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(404D)), ((float)(16D)), ((float)(16D)));
			this.iNivelAltoP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iNivelAltoP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNivelAltoP1.Name = "iNivelAltoP1";
			this.iNivelAltoP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNivelAltoP1.Visible = false;
			// 
			// iNivelAltoP1n
			// 
			this.iNivelAltoP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iNivelAltoP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iNivelAltoP1n.Location = new NxtControl.Drawing.PointF(304D, 405D);
			this.iNivelAltoP1n.Name = "iNivelAltoP1n";
			this.iNivelAltoP1n.Text = "1";
			this.iNivelAltoP1n.Visible = false;
			// 
			// iNivelAltoP2
			// 
			this.iNivelAltoP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(404D)), ((float)(16D)), ((float)(16D)));
			this.iNivelAltoP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iNivelAltoP2.Closed = true;
			this.iNivelAltoP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNivelAltoP2.Name = "iNivelAltoP2";
			this.iNivelAltoP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNivelAltoP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 420D),
			new NxtControl.Drawing.PointF(308D, 404D),
			new NxtControl.Drawing.PointF(316D, 420D)});
			this.iNivelAltoP2.Visible = false;
			// 
			// iNivelAltoP2n
			// 
			this.iNivelAltoP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNivelAltoP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iNivelAltoP2n.Location = new NxtControl.Drawing.PointF(305D, 408D);
			this.iNivelAltoP2n.Name = "iNivelAltoP2n";
			this.iNivelAltoP2n.Text = "2";
			this.iNivelAltoP2n.Visible = false;
			// 
			// iNivelAltoTxt
			// 
			this.iNivelAltoTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNivelAltoTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iNivelAltoTxt.Location = new NxtControl.Drawing.PointF(320D, 404D);
			this.iNivelAltoTxt.Name = "iNivelAltoTxt";
			this.iNivelAltoTxt.Text = "";
			this.iNivelAltoTxt.Visible = false;
			// 
			// rFalhaBoia
			// 
			this.rFalhaBoia.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rFalhaBoia.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rFalhaBoia.Location = new NxtControl.Drawing.PointF(22D, 430D);
			this.rFalhaBoia.Name = "rFalhaBoia";
			this.rFalhaBoia.Text = "Defeito da boia LSL-04";
			// 
			// nFalhaBoia
			// 
			this.nFalhaBoia.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nFalhaBoia.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nFalhaBoia.Location = new NxtControl.Drawing.PointF(304D, 430D);
			this.nFalhaBoia.Name = "nFalhaBoia";
			this.nFalhaBoia.Text = "—";
			// 
			// iFalhaBoiaP1
			// 
			this.iFalhaBoiaP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(430D)), ((float)(16D)), ((float)(16D)));
			this.iFalhaBoiaP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iFalhaBoiaP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFalhaBoiaP1.Name = "iFalhaBoiaP1";
			this.iFalhaBoiaP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFalhaBoiaP1.Visible = false;
			// 
			// iFalhaBoiaP1n
			// 
			this.iFalhaBoiaP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iFalhaBoiaP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iFalhaBoiaP1n.Location = new NxtControl.Drawing.PointF(304D, 431D);
			this.iFalhaBoiaP1n.Name = "iFalhaBoiaP1n";
			this.iFalhaBoiaP1n.Text = "1";
			this.iFalhaBoiaP1n.Visible = false;
			// 
			// iFalhaBoiaP2
			// 
			this.iFalhaBoiaP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(430D)), ((float)(16D)), ((float)(16D)));
			this.iFalhaBoiaP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iFalhaBoiaP2.Closed = true;
			this.iFalhaBoiaP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iFalhaBoiaP2.Name = "iFalhaBoiaP2";
			this.iFalhaBoiaP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iFalhaBoiaP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 446D),
			new NxtControl.Drawing.PointF(308D, 430D),
			new NxtControl.Drawing.PointF(316D, 446D)});
			this.iFalhaBoiaP2.Visible = false;
			// 
			// iFalhaBoiaP2n
			// 
			this.iFalhaBoiaP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFalhaBoiaP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iFalhaBoiaP2n.Location = new NxtControl.Drawing.PointF(305D, 434D);
			this.iFalhaBoiaP2n.Name = "iFalhaBoiaP2n";
			this.iFalhaBoiaP2n.Text = "2";
			this.iFalhaBoiaP2n.Visible = false;
			// 
			// iFalhaBoiaTxt
			// 
			this.iFalhaBoiaTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iFalhaBoiaTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iFalhaBoiaTxt.Location = new NxtControl.Drawing.PointF(320D, 430D);
			this.iFalhaBoiaTxt.Name = "iFalhaBoiaTxt";
			this.iFalhaBoiaTxt.Text = "";
			this.iFalhaBoiaTxt.Visible = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(468D)), ((float)(170D)), ((float)(34D)));
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
			this.btnAjustes.Bounds = new NxtControl.Drawing.RectF(((float)(210D)), ((float)(468D)), ((float)(170D)), ((float)(34D)));
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
			// xEstado
			// 
			this.xEstado.BeginInit();
			this.xEstado.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEstado.IsOnlyInput = true;
			this.xEstado.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEstado.Name = "xEstado";
			this.xEstado.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEstado.TagName = "STS_ESTADO";
			this.xEstado.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EstadoValueChanged);
			this.xEstado.EndInit();
			// 
			// xNec
			// 
			this.xNec.BeginInit();
			this.xNec.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNec.IsOnlyInput = true;
			this.xNec.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNec.Name = "xNec";
			this.xNec.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNec.TagName = "STS_NECESSIDADE_EQUIPAMENTO";
			this.xNec.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NecessidadeValueChanged);
			this.xNec.EndInit();
			// 
			// xLigadas
			// 
			this.xLigadas.BeginInit();
			this.xLigadas.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLigadas.IsOnlyInput = true;
			this.xLigadas.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLigadas.Name = "xLigadas";
			this.xLigadas.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLigadas.TagName = "STS_BOMBAS_LIGADAS";
			this.xLigadas.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LigadasValueChanged);
			this.xLigadas.EndInit();
			// 
			// xPrincipal
			// 
			this.xPrincipal.BeginInit();
			this.xPrincipal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPrincipal.IsOnlyInput = true;
			this.xPrincipal.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPrincipal.Name = "xPrincipal";
			this.xPrincipal.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPrincipal.TagName = "STS_PRINCIPAL";
			this.xPrincipal.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PrincipalValueChanged);
			this.xPrincipal.EndInit();
			// 
			// xSegunda
			// 
			this.xSegunda.BeginInit();
			this.xSegunda.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSegunda.IsOnlyInput = true;
			this.xSegunda.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSegunda.Name = "xSegunda";
			this.xSegunda.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSegunda.TagName = "STS_SEGUNDA";
			this.xSegunda.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SegundaValueChanged);
			this.xSegunda.EndInit();
			// 
			// xRh
			// 
			this.xRh.BeginInit();
			this.xRh.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRh.IsOnlyInput = true;
			this.xRh.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRh.Name = "xRh";
			this.xRh.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRh.TagName = "STS_RESTANTE_HOR";
			this.xRh.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RhValueChanged);
			this.xRh.EndInit();
			// 
			// xRm
			// 
			this.xRm.BeginInit();
			this.xRm.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRm.IsOnlyInput = true;
			this.xRm.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRm.Name = "xRm";
			this.xRm.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRm.TagName = "STS_RESTANTE_MIN";
			this.xRm.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RmValueChanged);
			this.xRm.EndInit();
			// 
			// xRs
			// 
			this.xRs.BeginInit();
			this.xRs.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRs.IsOnlyInput = true;
			this.xRs.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRs.Name = "xRs";
			this.xRs.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRs.TagName = "STS_RESTANTE_SEG";
			this.xRs.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RsValueChanged);
			this.xRs.EndInit();
			// 
			// xRecalque
			// 
			this.xRecalque.BeginInit();
			this.xRecalque.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRecalque.IsOnlyInput = true;
			this.xRecalque.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRecalque.Name = "xRecalque";
			this.xRecalque.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRecalque.TagName = "STS_FALHA_RECALQUE";
			this.xRecalque.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RecalqueValueChanged);
			this.xRecalque.EndInit();
			// 
			// xBoiaH
			// 
			this.xBoiaH.BeginInit();
			this.xBoiaH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBoiaH.IsOnlyInput = true;
			this.xBoiaH.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBoiaH.Name = "xBoiaH";
			this.xBoiaH.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBoiaH.TagName = "STS_BOIA_H";
			this.xBoiaH.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BoiaHValueChanged);
			this.xBoiaH.EndInit();
			// 
			// xBoiaL
			// 
			this.xBoiaL.BeginInit();
			this.xBoiaL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBoiaL.IsOnlyInput = true;
			this.xBoiaL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBoiaL.Name = "xBoiaL";
			this.xBoiaL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBoiaL.TagName = "STS_BOIA_L";
			this.xBoiaL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BoiaLValueChanged);
			this.xBoiaL.EndInit();
			// 
			// xFalhaBoia
			// 
			this.xFalhaBoia.BeginInit();
			this.xFalhaBoia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFalhaBoia.IsOnlyInput = true;
			this.xFalhaBoia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFalhaBoia.Name = "xFalhaBoia";
			this.xFalhaBoia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFalhaBoia.TagName = "STS_FALHA_BOIA_L";
			this.xFalhaBoia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FalhaBoiaValueChanged);
			this.xFalhaBoia.EndInit();
			// 
			// xNivelBaixo
			// 
			this.xNivelBaixo.BeginInit();
			this.xNivelBaixo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNivelBaixo.IsOnlyInput = true;
			this.xNivelBaixo.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNivelBaixo.Name = "xNivelBaixo";
			this.xNivelBaixo.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNivelBaixo.TagName = "STS_NIVEL_BAIXO";
			this.xNivelBaixo.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NivelBaixoValueChanged);
			this.xNivelBaixo.EndInit();
			// 
			// xBuffer
			// 
			this.xBuffer.BeginInit();
			this.xBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBuffer.IsOnlyInput = true;
			this.xBuffer.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBuffer.Name = "xBuffer";
			this.xBuffer.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBuffer.TagName = "STS_BUFFER_HH";
			this.xBuffer.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BufferValueChanged);
			this.xBuffer.EndInit();
			// 
			// xERecalque
			// 
			this.xERecalque.BeginInit();
			this.xERecalque.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xERecalque.IsOnlyInput = true;
			this.xERecalque.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xERecalque.Name = "xERecalque";
			this.xERecalque.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xERecalque.TagName = "STS_ALM_RECALQUE_EST";
			this.xERecalque.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ERecalqueValueChanged);
			this.xERecalque.EndInit();
			// 
			// xENivelAlto
			// 
			this.xENivelAlto.BeginInit();
			this.xENivelAlto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xENivelAlto.IsOnlyInput = true;
			this.xENivelAlto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xENivelAlto.Name = "xENivelAlto";
			this.xENivelAlto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xENivelAlto.TagName = "STS_ALM_NIVEL_ALTO_EST";
			this.xENivelAlto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ENivelAltoValueChanged);
			this.xENivelAlto.EndInit();
			// 
			// xEFalhaBoia
			// 
			this.xEFalhaBoia.BeginInit();
			this.xEFalhaBoia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFalhaBoia.IsOnlyInput = true;
			this.xEFalhaBoia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFalhaBoia.Name = "xEFalhaBoia";
			this.xEFalhaBoia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFalhaBoia.TagName = "STS_ALM_FALHA_BOIA_EST";
			this.xEFalhaBoia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EFalhaBoiaValueChanged);
			this.xEFalhaBoia.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(518D)));
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
			this.nivel,
			this.lin1,
			this.rot1,
			this.textoBombas,
			this.lin2,
			this.rot2,
			this.textoPrincipal,
			this.lin3,
			this.rot3,
			this.textoTroca,
			this.lin4,
			this.rot4,
			this.velocidade,
			this.lin5,
			this.rot5,
			this.saidaPid,
			this.lin6,
			this.rot6,
			this.textoLSL,
			this.lin7,
			this.rot7,
			this.textoLSH,
			this.lin8,
			this.rot8,
			this.textoBuffer,
			this.tituloAlm,
			this.rRecalque,
			this.nRecalque,
			this.iRecalqueP1,
			this.iRecalqueP1n,
			this.iRecalqueP2,
			this.iRecalqueP2n,
			this.iRecalqueTxt,
			this.rNivelAlto,
			this.nNivelAlto,
			this.iNivelAltoP1,
			this.iNivelAltoP1n,
			this.iNivelAltoP2,
			this.iNivelAltoP2n,
			this.iNivelAltoTxt,
			this.rFalhaBoia,
			this.nFalhaBoia,
			this.iFalhaBoiaP1,
			this.iFalhaBoiaP1n,
			this.iFalhaBoiaP2,
			this.iFalhaBoiaP2n,
			this.iFalhaBoiaTxt,
			this.btnReset,
			this.btnAjustes,
			this.xEstado,
			this.xNec,
			this.xLigadas,
			this.xPrincipal,
			this.xSegunda,
			this.xRh,
			this.xRm,
			this.xRs,
			this.xRecalque,
			this.xBoiaH,
			this.xBoiaL,
			this.xFalhaBoia,
			this.xNivelBaixo,
			this.xBuffer,
			this.xERecalque,
			this.xENivelAlto,
			this.xEFalhaBoia});
			this.Size = new System.Drawing.Size(400, 518);

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
		private System.HMI.Symbols.Base.Label<System.Single> nivel;
		private NxtControl.GuiFramework.Rectangle lin1;
		private NxtControl.GuiFramework.FreeText rot1;
		private NxtControl.GuiFramework.FreeText textoBombas;
		private NxtControl.GuiFramework.Rectangle lin2;
		private NxtControl.GuiFramework.FreeText rot2;
		private NxtControl.GuiFramework.FreeText textoPrincipal;
		private NxtControl.GuiFramework.Rectangle lin3;
		private NxtControl.GuiFramework.FreeText rot3;
		private NxtControl.GuiFramework.FreeText textoTroca;
		private NxtControl.GuiFramework.Rectangle lin4;
		private NxtControl.GuiFramework.FreeText rot4;
		private System.HMI.Symbols.Base.Label<System.Single> velocidade;
		private NxtControl.GuiFramework.Rectangle lin5;
		private NxtControl.GuiFramework.FreeText rot5;
		private System.HMI.Symbols.Base.Label<System.Single> saidaPid;
		private NxtControl.GuiFramework.Rectangle lin6;
		private NxtControl.GuiFramework.FreeText rot6;
		private NxtControl.GuiFramework.FreeText textoLSL;
		private NxtControl.GuiFramework.Rectangle lin7;
		private NxtControl.GuiFramework.FreeText rot7;
		private NxtControl.GuiFramework.FreeText textoLSH;
		private NxtControl.GuiFramework.Rectangle lin8;
		private NxtControl.GuiFramework.FreeText rot8;
		private NxtControl.GuiFramework.FreeText textoBuffer;
		private NxtControl.GuiFramework.FreeText tituloAlm;
		private NxtControl.GuiFramework.FreeText rRecalque;
		private NxtControl.GuiFramework.FreeText nRecalque;
		private NxtControl.GuiFramework.Rectangle iRecalqueP1;
		private NxtControl.GuiFramework.FreeText iRecalqueP1n;
		private NxtControl.GuiFramework.Polygon iRecalqueP2;
		private NxtControl.GuiFramework.FreeText iRecalqueP2n;
		private NxtControl.GuiFramework.FreeText iRecalqueTxt;
		private NxtControl.GuiFramework.FreeText rNivelAlto;
		private NxtControl.GuiFramework.FreeText nNivelAlto;
		private NxtControl.GuiFramework.Rectangle iNivelAltoP1;
		private NxtControl.GuiFramework.FreeText iNivelAltoP1n;
		private NxtControl.GuiFramework.Polygon iNivelAltoP2;
		private NxtControl.GuiFramework.FreeText iNivelAltoP2n;
		private NxtControl.GuiFramework.FreeText iNivelAltoTxt;
		private NxtControl.GuiFramework.FreeText rFalhaBoia;
		private NxtControl.GuiFramework.FreeText nFalhaBoia;
		private NxtControl.GuiFramework.Rectangle iFalhaBoiaP1;
		private NxtControl.GuiFramework.FreeText iFalhaBoiaP1n;
		private NxtControl.GuiFramework.Polygon iFalhaBoiaP2;
		private NxtControl.GuiFramework.FreeText iFalhaBoiaP2n;
		private NxtControl.GuiFramework.FreeText iFalhaBoiaTxt;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnAjustes;
		private System.HMI.Symbols.Base.Execute<short> xEstado;
		private System.HMI.Symbols.Base.Execute<ushort> xNec;
		private System.HMI.Symbols.Base.Execute<ushort> xLigadas;
		private System.HMI.Symbols.Base.Execute<ushort> xPrincipal;
		private System.HMI.Symbols.Base.Execute<ushort> xSegunda;
		private System.HMI.Symbols.Base.Execute<ushort> xRh;
		private System.HMI.Symbols.Base.Execute<ushort> xRm;
		private System.HMI.Symbols.Base.Execute<ushort> xRs;
		private System.HMI.Symbols.Base.Execute<bool> xRecalque;
		private System.HMI.Symbols.Base.Execute<bool> xBoiaH;
		private System.HMI.Symbols.Base.Execute<bool> xBoiaL;
		private System.HMI.Symbols.Base.Execute<bool> xFalhaBoia;
		private System.HMI.Symbols.Base.Execute<bool> xNivelBaixo;
		private System.HMI.Symbols.Base.Execute<bool> xBuffer;
		private System.HMI.Symbols.Base.Execute<byte> xERecalque;
		private System.HMI.Symbols.Base.Execute<byte> xENivelAlto;
		private System.HMI.Symbols.Base.Execute<byte> xEFalhaBoia;
		#endregion
	}
}
