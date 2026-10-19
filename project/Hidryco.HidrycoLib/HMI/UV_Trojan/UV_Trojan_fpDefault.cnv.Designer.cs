/*
 * Hidryco - UV_Trojan - fpDefault
 * UV: valores do sistema, canais (potencia, intensidade, horas), limpeza, alarme e reconhecimento.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UV_Trojan
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.rSis = new NxtControl.GuiFramework.FreeText();
			this.vSis1 = new NxtControl.GuiFramework.FreeText();
			this.vSis2 = new NxtControl.GuiFramework.FreeText();
			this.b1 = new NxtControl.GuiFramework.Rectangle();
			this.r1 = new NxtControl.GuiFramework.FreeText();
			this.v1a = new NxtControl.GuiFramework.FreeText();
			this.v1b = new NxtControl.GuiFramework.FreeText();
			this.v1c = new NxtControl.GuiFramework.FreeText();
			this.b2 = new NxtControl.GuiFramework.Rectangle();
			this.r2 = new NxtControl.GuiFramework.FreeText();
			this.v2a = new NxtControl.GuiFramework.FreeText();
			this.v2b = new NxtControl.GuiFramework.FreeText();
			this.v2c = new NxtControl.GuiFramework.FreeText();
			this.rLimp = new NxtControl.GuiFramework.FreeText();
			this.vLimp = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnDet = new NxtControl.GuiFramework.DrawnButton();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAMEN = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAMAI = new System.HMI.Symbols.Base.Execute<bool>();
			this.xACRI = new System.HMI.Symbols.Base.Execute<bool>();
			this.xALIM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDBX = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCINS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xVAZ = new System.HMI.Symbols.Base.Execute<float>();
			this.xDOSE = new System.HMI.Symbols.Base.Execute<float>();
			this.xUVT = new System.HMI.Symbols.Base.Execute<float>();
			this.xC1OP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2OP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1AL = new System.HMI.Symbols.Base.Execute<short>();
			this.xC2AL = new System.HMI.Symbols.Base.Execute<short>();
			this.xC1NB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2NB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1OF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2OF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1MA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2MA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1NR = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2NR = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLCIC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xECRI = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMAI = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMEN = new System.HMI.Symbols.Base.Execute<byte>();
			this.xELIM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xC1PO = new System.HMI.Symbols.Base.Execute<short>();
			this.xC2PO = new System.HMI.Symbols.Base.Execute<short>();
			this.xC1IN = new System.HMI.Symbols.Base.Execute<float>();
			this.xC2IN = new System.HMI.Symbols.Base.Execute<float>();
			this.xUVMW = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLC1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xLC2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xC1HO = new System.HMI.Symbols.Base.Execute<int>();
			this.xC2HO = new System.HMI.Symbols.Base.Execute<int>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(46D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(15D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 16D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(15D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 31D),
			new NxtControl.Drawing.PointF(28D, 15D),
			new NxtControl.Drawing.PointF(36D, 31D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 18D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 15D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// rSis
			// 
			this.rSis.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rSis.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rSis.Location = new NxtControl.Drawing.PointF(20D, 56D);
			this.rSis.Name = "rSis";
			this.rSis.Text = "Sistema";
			// 
			// vSis1
			// 
			this.vSis1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vSis1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.vSis1.Location = new NxtControl.Drawing.PointF(20D, 78D);
			this.vSis1.Name = "vSis1";
			this.vSis1.Text = "";
			// 
			// vSis2
			// 
			this.vSis2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vSis2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.vSis2.Location = new NxtControl.Drawing.PointF(20D, 100D);
			this.vSis2.Name = "vSis2";
			this.vSis2.Text = "";
			// 
			// b1
			// 
			this.b1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(134D)), ((float)(14D)), ((float)(14D)));
			this.b1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.b1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b1.Name = "b1";
			this.b1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// r1
			// 
			this.r1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.r1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.r1.Location = new NxtControl.Drawing.PointF(40D, 132D);
			this.r1.Name = "r1";
			this.r1.Text = "Canal 1 (banco 1A)";
			// 
			// v1a
			// 
			this.v1a.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v1a.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.v1a.Location = new NxtControl.Drawing.PointF(20D, 156D);
			this.v1a.Name = "v1a";
			this.v1a.Text = "";
			// 
			// v1b
			// 
			this.v1b.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v1b.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.v1b.Location = new NxtControl.Drawing.PointF(20D, 178D);
			this.v1b.Name = "v1b";
			this.v1b.Text = "";
			// 
			// v1c
			// 
			this.v1c.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v1c.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.v1c.Location = new NxtControl.Drawing.PointF(20D, 200D);
			this.v1c.Name = "v1c";
			this.v1c.Text = "";
			// 
			// b2
			// 
			this.b2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(224D)), ((float)(14D)), ((float)(14D)));
			this.b2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.b2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b2.Name = "b2";
			this.b2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// r2
			// 
			this.r2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.r2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.r2.Location = new NxtControl.Drawing.PointF(40D, 222D);
			this.r2.Name = "r2";
			this.r2.Text = "Canal 2 (banco 2A)";
			// 
			// v2a
			// 
			this.v2a.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v2a.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.v2a.Location = new NxtControl.Drawing.PointF(20D, 246D);
			this.v2a.Name = "v2a";
			this.v2a.Text = "";
			// 
			// v2b
			// 
			this.v2b.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v2b.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.v2b.Location = new NxtControl.Drawing.PointF(20D, 268D);
			this.v2b.Name = "v2b";
			this.v2b.Text = "";
			// 
			// v2c
			// 
			this.v2c.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v2c.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.v2c.Location = new NxtControl.Drawing.PointF(20D, 290D);
			this.v2c.Name = "v2c";
			this.v2c.Text = "";
			// 
			// rLimp
			// 
			this.rLimp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rLimp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rLimp.Location = new NxtControl.Drawing.PointF(20D, 312D);
			this.rLimp.Name = "rLimp";
			this.rLimp.Text = "Limpeza (ActiClean)";
			// 
			// vLimp
			// 
			this.vLimp.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vLimp.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.vLimp.Location = new NxtControl.Drawing.PointF(20D, 334D);
			this.vLimp.Name = "vLimp";
			this.vLimp.Text = "";
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(366D)), ((float)(160D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer alarmes";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnDet
			// 
			this.btnDet.Bounds = new NxtControl.Drawing.RectF(((float)(200D)), ((float)(366D)), ((float)(160D)), ((float)(34D)));
			this.btnDet.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDet.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnDet.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDet.Name = "btnDet";
			this.btnDet.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDetalhes", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnDet.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDet.Radius = 2D;
			this.btnDet.Text = "Detalhes";
			this.btnDet.Use3DEffect = false;
			// 
			// xFCOM
			// 
			this.xFCOM.BeginInit();
			this.xFCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFCOM.IsOnlyInput = true;
			this.xFCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFCOM.Name = "xFCOM";
			this.xFCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFCOM.TagName = "STS_FALHA_COMUNICACAO";
			this.xFCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFCOMValueChanged);
			this.xFCOM.EndInit();
			// 
			// xAMEN
			// 
			this.xAMEN.BeginInit();
			this.xAMEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAMEN.IsOnlyInput = true;
			this.xAMEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAMEN.Name = "xAMEN";
			this.xAMEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAMEN.TagName = "STS_ALM_MENOR";
			this.xAMEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAMENValueChanged);
			this.xAMEN.EndInit();
			// 
			// xAMAI
			// 
			this.xAMAI.BeginInit();
			this.xAMAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAMAI.IsOnlyInput = true;
			this.xAMAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAMAI.Name = "xAMAI";
			this.xAMAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAMAI.TagName = "STS_ALM_MAIOR";
			this.xAMAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAMAIValueChanged);
			this.xAMAI.EndInit();
			// 
			// xACRI
			// 
			this.xACRI.BeginInit();
			this.xACRI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xACRI.IsOnlyInput = true;
			this.xACRI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xACRI.Name = "xACRI";
			this.xACRI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xACRI.TagName = "STS_ALM_CRITICO";
			this.xACRI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XACRIValueChanged);
			this.xACRI.EndInit();
			// 
			// xALIM
			// 
			this.xALIM.BeginInit();
			this.xALIM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xALIM.IsOnlyInput = true;
			this.xALIM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xALIM.Name = "xALIM";
			this.xALIM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xALIM.TagName = "STS_ALM_LIMPEZA";
			this.xALIM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XALIMValueChanged);
			this.xALIM.EndInit();
			// 
			// xSCOM
			// 
			this.xSCOM.BeginInit();
			this.xSCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSCOM.IsOnlyInput = true;
			this.xSCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSCOM.Name = "xSCOM";
			this.xSCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSCOM.TagName = "STS_SCADA_COM_FALHA";
			this.xSCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSCOMValueChanged);
			this.xSCOM.EndInit();
			// 
			// xDBX
			// 
			this.xDBX.BeginInit();
			this.xDBX.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDBX.IsOnlyInput = true;
			this.xDBX.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDBX.Name = "xDBX";
			this.xDBX.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDBX.TagName = "STS_DOSE_BAIXA";
			this.xDBX.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDBXValueChanged);
			this.xDBX.EndInit();
			// 
			// xCINS
			// 
			this.xCINS.BeginInit();
			this.xCINS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCINS.IsOnlyInput = true;
			this.xCINS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCINS.Name = "xCINS";
			this.xCINS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCINS.TagName = "STS_CANAIS_INSUFICIENTES";
			this.xCINS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCINSValueChanged);
			this.xCINS.EndInit();
			// 
			// xVAZ
			// 
			this.xVAZ.BeginInit();
			this.xVAZ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVAZ.IsOnlyInput = true;
			this.xVAZ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVAZ.Name = "xVAZ";
			this.xVAZ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVAZ.TagName = "STS_VAZAO";
			this.xVAZ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVAZValueChanged);
			this.xVAZ.EndInit();
			// 
			// xDOSE
			// 
			this.xDOSE.BeginInit();
			this.xDOSE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDOSE.IsOnlyInput = true;
			this.xDOSE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDOSE.Name = "xDOSE";
			this.xDOSE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDOSE.TagName = "STS_DOSE";
			this.xDOSE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDOSEValueChanged);
			this.xDOSE.EndInit();
			// 
			// xUVT
			// 
			this.xUVT.BeginInit();
			this.xUVT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xUVT.IsOnlyInput = true;
			this.xUVT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xUVT.Name = "xUVT";
			this.xUVT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xUVT.TagName = "STS_UVT";
			this.xUVT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XUVTValueChanged);
			this.xUVT.EndInit();
			// 
			// xC1OP
			// 
			this.xC1OP.BeginInit();
			this.xC1OP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1OP.IsOnlyInput = true;
			this.xC1OP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1OP.Name = "xC1OP";
			this.xC1OP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1OP.TagName = "STS_CH1_OPERANDO";
			this.xC1OP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1OPValueChanged);
			this.xC1OP.EndInit();
			// 
			// xC2OP
			// 
			this.xC2OP.BeginInit();
			this.xC2OP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2OP.IsOnlyInput = true;
			this.xC2OP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2OP.Name = "xC2OP";
			this.xC2OP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2OP.TagName = "STS_CH2_OPERANDO";
			this.xC2OP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2OPValueChanged);
			this.xC2OP.EndInit();
			// 
			// xC1AL
			// 
			this.xC1AL.BeginInit();
			this.xC1AL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1AL.IsOnlyInput = true;
			this.xC1AL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1AL.Name = "xC1AL";
			this.xC1AL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1AL.TagName = "STS_CH1_ALARME";
			this.xC1AL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1ALValueChanged);
			this.xC1AL.EndInit();
			// 
			// xC2AL
			// 
			this.xC2AL.BeginInit();
			this.xC2AL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2AL.IsOnlyInput = true;
			this.xC2AL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2AL.Name = "xC2AL";
			this.xC2AL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2AL.TagName = "STS_CH2_ALARME";
			this.xC2AL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2ALValueChanged);
			this.xC2AL.EndInit();
			// 
			// xC1NB
			// 
			this.xC1NB.BeginInit();
			this.xC1NB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1NB.IsOnlyInput = true;
			this.xC1NB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1NB.Name = "xC1NB";
			this.xC1NB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1NB.TagName = "STS_CH1_NIVEL_BAIXO";
			this.xC1NB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1NBValueChanged);
			this.xC1NB.EndInit();
			// 
			// xC2NB
			// 
			this.xC2NB.BeginInit();
			this.xC2NB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2NB.IsOnlyInput = true;
			this.xC2NB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2NB.Name = "xC2NB";
			this.xC2NB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2NB.TagName = "STS_CH2_NIVEL_BAIXO";
			this.xC2NB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2NBValueChanged);
			this.xC2NB.EndInit();
			// 
			// xC1OF
			// 
			this.xC1OF.BeginInit();
			this.xC1OF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1OF.IsOnlyInput = true;
			this.xC1OF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1OF.Name = "xC1OF";
			this.xC1OF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1OF.TagName = "STS_CH1_OFFLINE";
			this.xC1OF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1OFValueChanged);
			this.xC1OF.EndInit();
			// 
			// xC2OF
			// 
			this.xC2OF.BeginInit();
			this.xC2OF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2OF.IsOnlyInput = true;
			this.xC2OF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2OF.Name = "xC2OF";
			this.xC2OF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2OF.TagName = "STS_CH2_OFFLINE";
			this.xC2OF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2OFValueChanged);
			this.xC2OF.EndInit();
			// 
			// xC1MA
			// 
			this.xC1MA.BeginInit();
			this.xC1MA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1MA.IsOnlyInput = true;
			this.xC1MA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1MA.Name = "xC1MA";
			this.xC1MA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1MA.TagName = "STS_CH1_MANUTENCAO";
			this.xC1MA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1MAValueChanged);
			this.xC1MA.EndInit();
			// 
			// xC2MA
			// 
			this.xC2MA.BeginInit();
			this.xC2MA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2MA.IsOnlyInput = true;
			this.xC2MA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2MA.Name = "xC2MA";
			this.xC2MA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2MA.TagName = "STS_CH2_MANUTENCAO";
			this.xC2MA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2MAValueChanged);
			this.xC2MA.EndInit();
			// 
			// xC1NR
			// 
			this.xC1NR.BeginInit();
			this.xC1NR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1NR.IsOnlyInput = true;
			this.xC1NR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1NR.Name = "xC1NR";
			this.xC1NR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1NR.TagName = "STS_CH1_NAO_REMOTO";
			this.xC1NR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1NRValueChanged);
			this.xC1NR.EndInit();
			// 
			// xC2NR
			// 
			this.xC2NR.BeginInit();
			this.xC2NR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2NR.IsOnlyInput = true;
			this.xC2NR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2NR.Name = "xC2NR";
			this.xC2NR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2NR.TagName = "STS_CH2_NAO_REMOTO";
			this.xC2NR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2NRValueChanged);
			this.xC2NR.EndInit();
			// 
			// xLCIC
			// 
			this.xLCIC.BeginInit();
			this.xLCIC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLCIC.IsOnlyInput = true;
			this.xLCIC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLCIC.Name = "xLCIC";
			this.xLCIC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLCIC.TagName = "STS_LIMP_EM_CICLO";
			this.xLCIC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XLCICValueChanged);
			this.xLCIC.EndInit();
			// 
			// xECOM
			// 
			this.xECOM.BeginInit();
			this.xECOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECOM.IsOnlyInput = true;
			this.xECOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECOM.Name = "xECOM";
			this.xECOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECOM.TagName = "STS_ALM_COMUNICACAO_EST";
			this.xECOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XECOMValueChanged);
			this.xECOM.EndInit();
			// 
			// xECRI
			// 
			this.xECRI.BeginInit();
			this.xECRI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECRI.IsOnlyInput = true;
			this.xECRI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECRI.Name = "xECRI";
			this.xECRI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECRI.TagName = "STS_ALM_CRITICO_EST";
			this.xECRI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XECRIValueChanged);
			this.xECRI.EndInit();
			// 
			// xEMAI
			// 
			this.xEMAI.BeginInit();
			this.xEMAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMAI.IsOnlyInput = true;
			this.xEMAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMAI.Name = "xEMAI";
			this.xEMAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMAI.TagName = "STS_ALM_MAIOR_EST";
			this.xEMAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMAIValueChanged);
			this.xEMAI.EndInit();
			// 
			// xEMEN
			// 
			this.xEMEN.BeginInit();
			this.xEMEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMEN.IsOnlyInput = true;
			this.xEMEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMEN.Name = "xEMEN";
			this.xEMEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMEN.TagName = "STS_ALM_MENOR_EST";
			this.xEMEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMENValueChanged);
			this.xEMEN.EndInit();
			// 
			// xELIM
			// 
			this.xELIM.BeginInit();
			this.xELIM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xELIM.IsOnlyInput = true;
			this.xELIM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xELIM.Name = "xELIM";
			this.xELIM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xELIM.TagName = "STS_ALM_LIMPEZA_EST";
			this.xELIM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XELIMValueChanged);
			this.xELIM.EndInit();
			// 
			// xC1PO
			// 
			this.xC1PO.BeginInit();
			this.xC1PO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1PO.IsOnlyInput = true;
			this.xC1PO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1PO.Name = "xC1PO";
			this.xC1PO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1PO.TagName = "STS_CH1_POTENCIA";
			this.xC1PO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1POValueChanged);
			this.xC1PO.EndInit();
			// 
			// xC2PO
			// 
			this.xC2PO.BeginInit();
			this.xC2PO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2PO.IsOnlyInput = true;
			this.xC2PO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2PO.Name = "xC2PO";
			this.xC2PO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2PO.TagName = "STS_CH2_POTENCIA";
			this.xC2PO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2POValueChanged);
			this.xC2PO.EndInit();
			// 
			// xC1IN
			// 
			this.xC1IN.BeginInit();
			this.xC1IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1IN.IsOnlyInput = true;
			this.xC1IN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1IN.Name = "xC1IN";
			this.xC1IN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1IN.TagName = "STS_CH1_INTENSIDADE";
			this.xC1IN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1INValueChanged);
			this.xC1IN.EndInit();
			// 
			// xC2IN
			// 
			this.xC2IN.BeginInit();
			this.xC2IN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2IN.IsOnlyInput = true;
			this.xC2IN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2IN.Name = "xC2IN";
			this.xC2IN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2IN.TagName = "STS_CH2_INTENSIDADE";
			this.xC2IN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2INValueChanged);
			this.xC2IN.EndInit();
			// 
			// xUVMW
			// 
			this.xUVMW.BeginInit();
			this.xUVMW.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xUVMW.IsOnlyInput = true;
			this.xUVMW.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xUVMW.Name = "xUVMW";
			this.xUVMW.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xUVMW.TagName = "STS_UVI_MW";
			this.xUVMW.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XUVMWValueChanged);
			this.xUVMW.EndInit();
			// 
			// xLC1
			// 
			this.xLC1.BeginInit();
			this.xLC1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLC1.IsOnlyInput = true;
			this.xLC1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLC1.Name = "xLC1";
			this.xLC1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLC1.TagName = "STS_LIMP_CICLOS1";
			this.xLC1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XLC1ValueChanged);
			this.xLC1.EndInit();
			// 
			// xLC2
			// 
			this.xLC2.BeginInit();
			this.xLC2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLC2.IsOnlyInput = true;
			this.xLC2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLC2.Name = "xLC2";
			this.xLC2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLC2.TagName = "STS_LIMP_CICLOS2";
			this.xLC2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XLC2ValueChanged);
			this.xLC2.EndInit();
			// 
			// xC1HO
			// 
			this.xC1HO.BeginInit();
			this.xC1HO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1HO.IsOnlyInput = true;
			this.xC1HO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1HO.Name = "xC1HO";
			this.xC1HO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1HO.TagName = "STS_CH1_HORAS";
			this.xC1HO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1HOValueChanged);
			this.xC1HO.EndInit();
			// 
			// xC2HO
			// 
			this.xC2HO.BeginInit();
			this.xC2HO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2HO.IsOnlyInput = true;
			this.xC2HO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2HO.Name = "xC2HO";
			this.xC2HO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2HO.TagName = "STS_CH2_HORAS";
			this.xC2HO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2HOValueChanged);
			this.xC2HO.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(420D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.rSis,
			this.vSis1,
			this.vSis2,
			this.b1,
			this.r1,
			this.v1a,
			this.v1b,
			this.v1c,
			this.b2,
			this.r2,
			this.v2a,
			this.v2b,
			this.v2c,
			this.rLimp,
			this.vLimp,
			this.btnReset,
			this.btnDet,
			this.xFCOM,
			this.xAMEN,
			this.xAMAI,
			this.xACRI,
			this.xALIM,
			this.xSCOM,
			this.xDBX,
			this.xCINS,
			this.xVAZ,
			this.xDOSE,
			this.xUVT,
			this.xC1OP,
			this.xC2OP,
			this.xC1AL,
			this.xC2AL,
			this.xC1NB,
			this.xC2NB,
			this.xC1OF,
			this.xC2OF,
			this.xC1MA,
			this.xC2MA,
			this.xC1NR,
			this.xC2NR,
			this.xLCIC,
			this.xECOM,
			this.xECRI,
			this.xEMAI,
			this.xEMEN,
			this.xELIM,
			this.xC1PO,
			this.xC2PO,
			this.xC1IN,
			this.xC2IN,
			this.xUVMW,
			this.xLC1,
			this.xLC2,
			this.xC1HO,
			this.xC2HO});
			this.Size = new System.Drawing.Size(380, 420);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText rSis;
		private NxtControl.GuiFramework.FreeText vSis1;
		private NxtControl.GuiFramework.FreeText vSis2;
		private NxtControl.GuiFramework.Rectangle b1;
		private NxtControl.GuiFramework.FreeText r1;
		private NxtControl.GuiFramework.FreeText v1a;
		private NxtControl.GuiFramework.FreeText v1b;
		private NxtControl.GuiFramework.FreeText v1c;
		private NxtControl.GuiFramework.Rectangle b2;
		private NxtControl.GuiFramework.FreeText r2;
		private NxtControl.GuiFramework.FreeText v2a;
		private NxtControl.GuiFramework.FreeText v2b;
		private NxtControl.GuiFramework.FreeText v2c;
		private NxtControl.GuiFramework.FreeText rLimp;
		private NxtControl.GuiFramework.FreeText vLimp;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnDet;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xAMEN;
		private System.HMI.Symbols.Base.Execute<bool> xAMAI;
		private System.HMI.Symbols.Base.Execute<bool> xACRI;
		private System.HMI.Symbols.Base.Execute<bool> xALIM;
		private System.HMI.Symbols.Base.Execute<bool> xSCOM;
		private System.HMI.Symbols.Base.Execute<bool> xDBX;
		private System.HMI.Symbols.Base.Execute<bool> xCINS;
		private System.HMI.Symbols.Base.Execute<float> xVAZ;
		private System.HMI.Symbols.Base.Execute<float> xDOSE;
		private System.HMI.Symbols.Base.Execute<float> xUVT;
		private System.HMI.Symbols.Base.Execute<bool> xC1OP;
		private System.HMI.Symbols.Base.Execute<bool> xC2OP;
		private System.HMI.Symbols.Base.Execute<short> xC1AL;
		private System.HMI.Symbols.Base.Execute<short> xC2AL;
		private System.HMI.Symbols.Base.Execute<bool> xC1NB;
		private System.HMI.Symbols.Base.Execute<bool> xC2NB;
		private System.HMI.Symbols.Base.Execute<bool> xC1OF;
		private System.HMI.Symbols.Base.Execute<bool> xC2OF;
		private System.HMI.Symbols.Base.Execute<bool> xC1MA;
		private System.HMI.Symbols.Base.Execute<bool> xC2MA;
		private System.HMI.Symbols.Base.Execute<bool> xC1NR;
		private System.HMI.Symbols.Base.Execute<bool> xC2NR;
		private System.HMI.Symbols.Base.Execute<bool> xLCIC;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xECRI;
		private System.HMI.Symbols.Base.Execute<byte> xEMAI;
		private System.HMI.Symbols.Base.Execute<byte> xEMEN;
		private System.HMI.Symbols.Base.Execute<byte> xELIM;
		private System.HMI.Symbols.Base.Execute<short> xC1PO;
		private System.HMI.Symbols.Base.Execute<short> xC2PO;
		private System.HMI.Symbols.Base.Execute<float> xC1IN;
		private System.HMI.Symbols.Base.Execute<float> xC2IN;
		private System.HMI.Symbols.Base.Execute<bool> xUVMW;
		private System.HMI.Symbols.Base.Execute<short> xLC1;
		private System.HMI.Symbols.Base.Execute<short> xLC2;
		private System.HMI.Symbols.Base.Execute<int> xC1HO;
		private System.HMI.Symbols.Base.Execute<int> xC2HO;
		#endregion
	}
}
