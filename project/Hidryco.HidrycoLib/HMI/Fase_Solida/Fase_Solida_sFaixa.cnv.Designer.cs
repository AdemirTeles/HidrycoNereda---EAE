/*
 * Hidryco - Fase_Solida - sFaixa
 * ISA-101: fase solida em faixa - estado das prensas, soprador, tanques, polimero e alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Fase_Solida
{
	/// <summary>
	/// Summary description for sFaixa.
	/// </summary>
	partial class sFaixa
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.l3 = new NxtControl.GuiFramework.FreeText();
			this.l4 = new NxtControl.GuiFramework.FreeText();
			this.xE1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xE2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xE3 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM3 = new System.HMI.Symbols.Base.Execute<short>();
			this.xB1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xB2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xB3 = new System.HMI.Symbols.Base.Execute<short>();
			this.xSOA = new System.HMI.Symbols.Base.Execute<short>();
			this.xNTQ = new System.HMI.Symbols.Base.Execute<float>();
			this.xNBX = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSNV = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSSO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEMG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xADJ = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSBO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFROT = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSPT = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFTF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCPP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xESO = new System.HMI.Symbols.Base.Execute<byte>();
			this.xENT = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEEM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xERE = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEDJ = new System.HMI.Symbols.Base.Execute<byte>();
			this.xERO = new System.HMI.Symbols.Base.Execute<byte>();
			this.xESB = new System.HMI.Symbols.Base.Execute<byte>();
			this.xESP = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEFT = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(740D)), ((float)(80D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(8D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(14D, 9D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(10D)), ((float)(8D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(10D, 24D),
			new NxtControl.Drawing.PointF(18D, 8D),
			new NxtControl.Drawing.PointF(26D, 24D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(15D, 11D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(30D, 8D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.l1.Location = new NxtControl.Drawing.PointF(10D, 30D);
			this.l1.Name = "l1";
			this.l1.Text = "";
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.l2.Location = new NxtControl.Drawing.PointF(10D, 54D);
			this.l2.Name = "l2";
			this.l2.Text = "";
			// 
			// l3
			// 
			this.l3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l3.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.l3.Location = new NxtControl.Drawing.PointF(400D, 30D);
			this.l3.Name = "l3";
			this.l3.Text = "";
			// 
			// l4
			// 
			this.l4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l4.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular);
			this.l4.Location = new NxtControl.Drawing.PointF(400D, 54D);
			this.l4.Name = "l4";
			this.l4.Text = "";
			// 
			// xE1
			// 
			this.xE1.BeginInit();
			this.xE1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xE1.IsOnlyInput = true;
			this.xE1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xE1.Name = "xE1";
			this.xE1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xE1.TagName = "STS_AD1_ESTADO";
			this.xE1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XE1ValueChanged);
			this.xE1.EndInit();
			// 
			// xE2
			// 
			this.xE2.BeginInit();
			this.xE2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xE2.IsOnlyInput = true;
			this.xE2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xE2.Name = "xE2";
			this.xE2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xE2.TagName = "STS_AD2_ESTADO";
			this.xE2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XE2ValueChanged);
			this.xE2.EndInit();
			// 
			// xE3
			// 
			this.xE3.BeginInit();
			this.xE3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xE3.IsOnlyInput = true;
			this.xE3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xE3.Name = "xE3";
			this.xE3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xE3.TagName = "STS_AD3_ESTADO";
			this.xE3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XE3ValueChanged);
			this.xE3.EndInit();
			// 
			// xM1
			// 
			this.xM1.BeginInit();
			this.xM1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM1.IsOnlyInput = true;
			this.xM1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM1.Name = "xM1";
			this.xM1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM1.TagName = "STS_AD1_MOTIVO";
			this.xM1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM1ValueChanged);
			this.xM1.EndInit();
			// 
			// xM2
			// 
			this.xM2.BeginInit();
			this.xM2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM2.IsOnlyInput = true;
			this.xM2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM2.Name = "xM2";
			this.xM2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM2.TagName = "STS_AD2_MOTIVO";
			this.xM2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM2ValueChanged);
			this.xM2.EndInit();
			// 
			// xM3
			// 
			this.xM3.BeginInit();
			this.xM3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM3.IsOnlyInput = true;
			this.xM3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM3.Name = "xM3";
			this.xM3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM3.TagName = "STS_AD3_MOTIVO";
			this.xM3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM3ValueChanged);
			this.xM3.EndInit();
			// 
			// xB1
			// 
			this.xB1.BeginInit();
			this.xB1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xB1.IsOnlyInput = true;
			this.xB1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xB1.Name = "xB1";
			this.xB1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xB1.TagName = "STS_AD1_BOMBA";
			this.xB1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XB1ValueChanged);
			this.xB1.EndInit();
			// 
			// xB2
			// 
			this.xB2.BeginInit();
			this.xB2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xB2.IsOnlyInput = true;
			this.xB2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xB2.Name = "xB2";
			this.xB2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xB2.TagName = "STS_AD2_BOMBA";
			this.xB2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XB2ValueChanged);
			this.xB2.EndInit();
			// 
			// xB3
			// 
			this.xB3.BeginInit();
			this.xB3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xB3.IsOnlyInput = true;
			this.xB3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xB3.Name = "xB3";
			this.xB3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xB3.TagName = "STS_AD3_BOMBA";
			this.xB3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XB3ValueChanged);
			this.xB3.EndInit();
			// 
			// xSOA
			// 
			this.xSOA.BeginInit();
			this.xSOA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSOA.IsOnlyInput = true;
			this.xSOA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSOA.Name = "xSOA";
			this.xSOA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSOA.TagName = "STS_SO_ATIVO";
			this.xSOA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSOAValueChanged);
			this.xSOA.EndInit();
			// 
			// xNTQ
			// 
			this.xNTQ.BeginInit();
			this.xNTQ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNTQ.IsOnlyInput = true;
			this.xNTQ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNTQ.Name = "xNTQ";
			this.xNTQ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNTQ.TagName = "STS_NIVEL_TQ";
			this.xNTQ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNTQValueChanged);
			this.xNTQ.EndInit();
			// 
			// xNBX
			// 
			this.xNBX.BeginInit();
			this.xNBX.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNBX.IsOnlyInput = true;
			this.xNBX.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNBX.Name = "xNBX";
			this.xNBX.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNBX.TagName = "STS_NIVEL_BAIXO_TQ";
			this.xNBX.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNBXValueChanged);
			this.xNBX.EndInit();
			// 
			// xSNV
			// 
			this.xSNV.BeginInit();
			this.xSNV.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSNV.IsOnlyInput = true;
			this.xSNV.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSNV.Name = "xSNV";
			this.xSNV.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSNV.TagName = "STS_SEM_NIVEL_TQ";
			this.xSNV.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSNVValueChanged);
			this.xSNV.EndInit();
			// 
			// xSSO
			// 
			this.xSSO.BeginInit();
			this.xSSO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSSO.IsOnlyInput = true;
			this.xSSO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSSO.Name = "xSSO";
			this.xSSO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSSO.TagName = "STS_SEM_SOPRADOR";
			this.xSSO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSSOValueChanged);
			this.xSSO.EndInit();
			// 
			// xEMG
			// 
			this.xEMG.BeginInit();
			this.xEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMG.IsOnlyInput = true;
			this.xEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMG.Name = "xEMG";
			this.xEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMG.TagName = "STS_EMERGENCIA";
			this.xEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMGValueChanged);
			this.xEMG.EndInit();
			// 
			// xFREM
			// 
			this.xFREM.BeginInit();
			this.xFREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFREM.IsOnlyInput = true;
			this.xFREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFREM.Name = "xFREM";
			this.xFREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFREM.TagName = "STS_FALHA_REMOTA";
			this.xFREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFREMValueChanged);
			this.xFREM.EndInit();
			// 
			// xADJ
			// 
			this.xADJ.BeginInit();
			this.xADJ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xADJ.IsOnlyInput = true;
			this.xADJ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xADJ.Name = "xADJ";
			this.xADJ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xADJ.TagName = "STS_AVISO_DISJUNTOR";
			this.xADJ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XADJValueChanged);
			this.xADJ.EndInit();
			// 
			// xSBO
			// 
			this.xSBO.BeginInit();
			this.xSBO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSBO.IsOnlyInput = true;
			this.xSBO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSBO.Name = "xSBO";
			this.xSBO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSBO.TagName = "STS_SEM_BOMBA";
			this.xSBO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSBOValueChanged);
			this.xSBO.EndInit();
			// 
			// xFROT
			// 
			this.xFROT.BeginInit();
			this.xFROT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFROT.IsOnlyInput = true;
			this.xFROT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFROT.Name = "xFROT";
			this.xFROT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFROT.TagName = "STS_FALHA_ROTA";
			this.xFROT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFROTValueChanged);
			this.xFROT.EndInit();
			// 
			// xSPT
			// 
			this.xSPT.BeginInit();
			this.xSPT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSPT.IsOnlyInput = true;
			this.xSPT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSPT.Name = "xSPT";
			this.xSPT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSPT.TagName = "STS_SEM_PARTIR";
			this.xSPT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSPTValueChanged);
			this.xSPT.EndInit();
			// 
			// xFTF
			// 
			this.xFTF.BeginInit();
			this.xFTF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFTF.IsOnlyInput = true;
			this.xFTF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFTF.Name = "xFTF";
			this.xFTF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFTF.TagName = "STS_FT_FALHA";
			this.xFTF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFTFValueChanged);
			this.xFTF.EndInit();
			// 
			// xCPP
			// 
			this.xCPP.BeginInit();
			this.xCPP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCPP.IsOnlyInput = true;
			this.xCPP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCPP.Name = "xCPP";
			this.xCPP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCPP.TagName = "STS_CICLO_PP";
			this.xCPP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCPPValueChanged);
			this.xCPP.EndInit();
			// 
			// xESO
			// 
			this.xESO.BeginInit();
			this.xESO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESO.IsOnlyInput = true;
			this.xESO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESO.Name = "xESO";
			this.xESO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESO.TagName = "STS_ALM_SOPRADORES_EST";
			this.xESO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESOValueChanged);
			this.xESO.EndInit();
			// 
			// xENT
			// 
			this.xENT.BeginInit();
			this.xENT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xENT.IsOnlyInput = true;
			this.xENT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xENT.Name = "xENT";
			this.xENT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xENT.TagName = "STS_ALM_NIVEL_TQ_EST";
			this.xENT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XENTValueChanged);
			this.xENT.EndInit();
			// 
			// xEEM
			// 
			this.xEEM.BeginInit();
			this.xEEM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEM.IsOnlyInput = true;
			this.xEEM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEM.Name = "xEEM";
			this.xEEM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEM.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEEMValueChanged);
			this.xEEM.EndInit();
			// 
			// xERE
			// 
			this.xERE.BeginInit();
			this.xERE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xERE.IsOnlyInput = true;
			this.xERE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xERE.Name = "xERE";
			this.xERE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xERE.TagName = "STS_ALM_REMOTA_EST";
			this.xERE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEREValueChanged);
			this.xERE.EndInit();
			// 
			// xEDJ
			// 
			this.xEDJ.BeginInit();
			this.xEDJ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEDJ.IsOnlyInput = true;
			this.xEDJ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEDJ.Name = "xEDJ";
			this.xEDJ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEDJ.TagName = "STS_ALM_DISJUNTOR_EST";
			this.xEDJ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEDJValueChanged);
			this.xEDJ.EndInit();
			// 
			// xERO
			// 
			this.xERO.BeginInit();
			this.xERO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xERO.IsOnlyInput = true;
			this.xERO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xERO.Name = "xERO";
			this.xERO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xERO.TagName = "STS_ALM_ROTA_EST";
			this.xERO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEROValueChanged);
			this.xERO.EndInit();
			// 
			// xESB
			// 
			this.xESB.BeginInit();
			this.xESB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESB.IsOnlyInput = true;
			this.xESB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESB.Name = "xESB";
			this.xESB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESB.TagName = "STS_ALM_SEM_BOMBA_EST";
			this.xESB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESBValueChanged);
			this.xESB.EndInit();
			// 
			// xESP
			// 
			this.xESP.BeginInit();
			this.xESP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESP.IsOnlyInput = true;
			this.xESP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESP.Name = "xESP";
			this.xESP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESP.TagName = "STS_ALM_SEM_PARTIR_EST";
			this.xESP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESPValueChanged);
			this.xESP.EndInit();
			// 
			// xEFT
			// 
			this.xEFT.BeginInit();
			this.xEFT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFT.IsOnlyInput = true;
			this.xEFT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFT.Name = "xEFT";
			this.xEFT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFT.TagName = "STS_ALM_FT_EST";
			this.xEFT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEFTValueChanged);
			this.xEFT.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(740D)), ((float)(80D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Text = "";
			this.abrir.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.Use3DEffect = false;
			// 
			// sFaixa
			// 
			this.Name = "sFaixa";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.l1,
			this.l2,
			this.l3,
			this.l4,
			this.xE1,
			this.xE2,
			this.xE3,
			this.xM1,
			this.xM2,
			this.xM3,
			this.xB1,
			this.xB2,
			this.xB3,
			this.xSOA,
			this.xNTQ,
			this.xNBX,
			this.xSNV,
			this.xSSO,
			this.xEMG,
			this.xFREM,
			this.xADJ,
			this.xSBO,
			this.xFROT,
			this.xSPT,
			this.xFTF,
			this.xCPP,
			this.xESO,
			this.xENT,
			this.xEEM,
			this.xERE,
			this.xEDJ,
			this.xERO,
			this.xESB,
			this.xESP,
			this.xEFT,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(740, 80);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText l1;
		private NxtControl.GuiFramework.FreeText l2;
		private NxtControl.GuiFramework.FreeText l3;
		private NxtControl.GuiFramework.FreeText l4;
		private System.HMI.Symbols.Base.Execute<short> xE1;
		private System.HMI.Symbols.Base.Execute<short> xE2;
		private System.HMI.Symbols.Base.Execute<short> xE3;
		private System.HMI.Symbols.Base.Execute<short> xM1;
		private System.HMI.Symbols.Base.Execute<short> xM2;
		private System.HMI.Symbols.Base.Execute<short> xM3;
		private System.HMI.Symbols.Base.Execute<short> xB1;
		private System.HMI.Symbols.Base.Execute<short> xB2;
		private System.HMI.Symbols.Base.Execute<short> xB3;
		private System.HMI.Symbols.Base.Execute<short> xSOA;
		private System.HMI.Symbols.Base.Execute<float> xNTQ;
		private System.HMI.Symbols.Base.Execute<bool> xNBX;
		private System.HMI.Symbols.Base.Execute<bool> xSNV;
		private System.HMI.Symbols.Base.Execute<bool> xSSO;
		private System.HMI.Symbols.Base.Execute<bool> xEMG;
		private System.HMI.Symbols.Base.Execute<bool> xFREM;
		private System.HMI.Symbols.Base.Execute<bool> xADJ;
		private System.HMI.Symbols.Base.Execute<bool> xSBO;
		private System.HMI.Symbols.Base.Execute<bool> xFROT;
		private System.HMI.Symbols.Base.Execute<bool> xSPT;
		private System.HMI.Symbols.Base.Execute<bool> xFTF;
		private System.HMI.Symbols.Base.Execute<bool> xCPP;
		private System.HMI.Symbols.Base.Execute<byte> xESO;
		private System.HMI.Symbols.Base.Execute<byte> xENT;
		private System.HMI.Symbols.Base.Execute<byte> xEEM;
		private System.HMI.Symbols.Base.Execute<byte> xERE;
		private System.HMI.Symbols.Base.Execute<byte> xEDJ;
		private System.HMI.Symbols.Base.Execute<byte> xERO;
		private System.HMI.Symbols.Base.Execute<byte> xESB;
		private System.HMI.Symbols.Base.Execute<byte> xESP;
		private System.HMI.Symbols.Base.Execute<byte> xEFT;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
