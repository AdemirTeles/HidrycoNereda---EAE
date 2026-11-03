/*
 * Hidryco - Preparador_Vibropac - fpDefault
 * Preparador de polimero Vibropac VIB-3000: estado, motores, modo, comando manual do ciclo e reset.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Preparador_Vibropac
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
			this.e1 = new NxtControl.GuiFramework.FreeText();
			this.e2 = new NxtControl.GuiFramework.FreeText();
			this.rMot = new NxtControl.GuiFramework.FreeText();
			this.nm0 = new NxtControl.GuiFramework.FreeText();
			this.vm0 = new NxtControl.GuiFramework.FreeText();
			this.nm1 = new NxtControl.GuiFramework.FreeText();
			this.vm1 = new NxtControl.GuiFramework.FreeText();
			this.nm2 = new NxtControl.GuiFramework.FreeText();
			this.vm2 = new NxtControl.GuiFramework.FreeText();
			this.nm3 = new NxtControl.GuiFramework.FreeText();
			this.vm3 = new NxtControl.GuiFramework.FreeText();
			this.nm4 = new NxtControl.GuiFramework.FreeText();
			this.vm4 = new NxtControl.GuiFramework.FreeText();
			this.rDet = new NxtControl.GuiFramework.FreeText();
			this.rDet2 = new NxtControl.GuiFramework.FreeText();
			this.rDet3 = new NxtControl.GuiFramework.FreeText();
			this.rModo = new NxtControl.GuiFramework.FreeText();
			this.btnAuto = new NxtControl.GuiFramework.DrawnButton();
			this.btnMan = new NxtControl.GuiFramework.DrawnButton();
			this.rCic = new NxtControl.GuiFramework.FreeText();
			this.btnLiga = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesl = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnSkid = new NxtControl.GuiFramework.DrawnButton();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xHAB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAUTO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCIC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCMAN = new System.HMI.Symbols.Base.Execute<bool>();
			this.xALS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEMG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFMOT = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDISP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEEMG = new System.HMI.Symbols.Base.Execute<byte>();
			this.xESKD = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMOT = new System.HMI.Symbols.Base.Execute<byte>();
			this.xM1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM3 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM4 = new System.HMI.Symbols.Base.Execute<short>();
			this.xM5 = new System.HMI.Symbols.Base.Execute<short>();
			this.xDOS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSILO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xNIVP = new System.HMI.Symbols.Base.Execute<short>();
			this.xVAG = new System.HMI.Symbols.Base.Execute<float>();
			this.xVPO = new System.HMI.Symbols.Base.Execute<float>();
			this.xFAG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVZ = new System.HMI.Symbols.Base.Execute<short>();
			this.xVS01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRES = new System.HMI.Symbols.Base.Execute<bool>();
			this.xESIL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEAGU = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVAZ = new System.HMI.Symbols.Base.Execute<byte>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(74D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 11D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 26D),
			new NxtControl.Drawing.PointF(28D, 10D),
			new NxtControl.Drawing.PointF(36D, 26D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 13D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 10D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 32D);
			this.e1.Name = "e1";
			this.e1.Text = "";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(20D, 52D);
			this.e2.Name = "e2";
			this.e2.Text = "";
			// 
			// rMot
			// 
			this.rMot.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rMot.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rMot.Location = new NxtControl.Drawing.PointF(20D, 84D);
			this.rMot.Name = "rMot";
			this.rMot.Text = "Motores do skid";
			// 
			// nm0
			// 
			this.nm0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm0.Location = new NxtControl.Drawing.PointF(20D, 108D);
			this.nm0.Name = "nm0";
			this.nm0.Text = "";
			// 
			// vm0
			// 
			this.vm0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm0.Location = new NxtControl.Drawing.PointF(220D, 108D);
			this.vm0.Name = "vm0";
			this.vm0.Text = "";
			// 
			// nm1
			// 
			this.nm1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm1.Location = new NxtControl.Drawing.PointF(20D, 130D);
			this.nm1.Name = "nm1";
			this.nm1.Text = "";
			// 
			// vm1
			// 
			this.vm1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm1.Location = new NxtControl.Drawing.PointF(220D, 130D);
			this.vm1.Name = "vm1";
			this.vm1.Text = "";
			// 
			// nm2
			// 
			this.nm2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm2.Location = new NxtControl.Drawing.PointF(20D, 152D);
			this.nm2.Name = "nm2";
			this.nm2.Text = "";
			// 
			// vm2
			// 
			this.vm2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm2.Location = new NxtControl.Drawing.PointF(220D, 152D);
			this.vm2.Name = "vm2";
			this.vm2.Text = "";
			// 
			// nm3
			// 
			this.nm3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm3.Location = new NxtControl.Drawing.PointF(20D, 174D);
			this.nm3.Name = "nm3";
			this.nm3.Text = "";
			// 
			// vm3
			// 
			this.vm3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm3.Location = new NxtControl.Drawing.PointF(220D, 174D);
			this.vm3.Name = "vm3";
			this.vm3.Text = "";
			// 
			// nm4
			// 
			this.nm4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm4.Location = new NxtControl.Drawing.PointF(20D, 196D);
			this.nm4.Name = "nm4";
			this.nm4.Text = "";
			// 
			// vm4
			// 
			this.vm4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm4.Location = new NxtControl.Drawing.PointF(220D, 196D);
			this.vm4.Name = "vm4";
			this.vm4.Text = "";
			// 
			// rDet
			// 
			this.rDet.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rDet.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDet.Location = new NxtControl.Drawing.PointF(20D, 222D);
			this.rDet.Name = "rDet";
			this.rDet.Text = "";
			// 
			// rDet2
			// 
			this.rDet2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rDet2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDet2.Location = new NxtControl.Drawing.PointF(20D, 242D);
			this.rDet2.Name = "rDet2";
			this.rDet2.Text = "";
			// 
			// rDet3
			// 
			this.rDet3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rDet3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDet3.Location = new NxtControl.Drawing.PointF(20D, 262D);
			this.rDet3.Name = "rDet3";
			this.rDet3.Text = "";
			// 
			// rModo
			// 
			this.rModo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rModo.Location = new NxtControl.Drawing.PointF(20D, 292D);
			this.rModo.Name = "rModo";
			this.rModo.Text = "Modo";
			// 
			// btnAuto
			// 
			this.btnAuto.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(314D)), ((float)(165D)), ((float)(34D)));
			this.btnAuto.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAuto.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAuto.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAuto.Name = "btnAuto";
			this.btnAuto.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAuto.Radius = 2D;
			this.btnAuto.Text = "Automático";
			this.btnAuto.Use3DEffect = false;
			this.btnAuto.Click += new System.EventHandler(this.BtnAutoClick);
			// 
			// btnMan
			// 
			this.btnMan.Bounds = new NxtControl.Drawing.RectF(((float)(195D)), ((float)(314D)), ((float)(165D)), ((float)(34D)));
			this.btnMan.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnMan.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnMan.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnMan.Name = "btnMan";
			this.btnMan.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnMan.Radius = 2D;
			this.btnMan.Text = "Manual";
			this.btnMan.Use3DEffect = false;
			this.btnMan.Click += new System.EventHandler(this.BtnManClick);
			// 
			// rCic
			// 
			this.rCic.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rCic.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rCic.Location = new NxtControl.Drawing.PointF(20D, 360D);
			this.rCic.Name = "rCic";
			this.rCic.Text = "Ciclo remoto (manual)";
			// 
			// btnLiga
			// 
			this.btnLiga.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(382D)), ((float)(165D)), ((float)(34D)));
			this.btnLiga.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLiga.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnLiga.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLiga.Name = "btnLiga";
			this.btnLiga.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLiga.Radius = 2D;
			this.btnLiga.Text = "Ligar ciclo";
			this.btnLiga.Use3DEffect = false;
			this.btnLiga.Click += new System.EventHandler(this.BtnLigaClick);
			// 
			// btnDesl
			// 
			this.btnDesl.Bounds = new NxtControl.Drawing.RectF(((float)(195D)), ((float)(382D)), ((float)(165D)), ((float)(34D)));
			this.btnDesl.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesl.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnDesl.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesl.Name = "btnDesl";
			this.btnDesl.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesl.Radius = 2D;
			this.btnDesl.Text = "Desligar ciclo";
			this.btnDesl.Use3DEffect = false;
			this.btnDesl.Click += new System.EventHandler(this.BtnDeslClick);
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(426D)), ((float)(340D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reset do skid / reconhecer alarmes";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnSkid
			// 
			this.btnSkid.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(470D)), ((float)(340D)), ((float)(34D)));
			this.btnSkid.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSkid.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnSkid.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSkid.Name = "btnSkid";
			this.btnSkid.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSkid", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnSkid.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSkid.Radius = 2D;
			this.btnSkid.Text = "Ver skid";
			this.btnSkid.Use3DEffect = false;
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
			// xHAB
			// 
			this.xHAB.BeginInit();
			this.xHAB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHAB.IsOnlyInput = true;
			this.xHAB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHAB.Name = "xHAB";
			this.xHAB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHAB.TagName = "STS_HABILITADO";
			this.xHAB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XHABValueChanged);
			this.xHAB.EndInit();
			// 
			// xAUTO
			// 
			this.xAUTO.BeginInit();
			this.xAUTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAUTO.IsOnlyInput = true;
			this.xAUTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAUTO.Name = "xAUTO";
			this.xAUTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAUTO.TagName = "STS_AUTOMATICO";
			this.xAUTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAUTOValueChanged);
			this.xAUTO.EndInit();
			// 
			// xCIC
			// 
			this.xCIC.BeginInit();
			this.xCIC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCIC.IsOnlyInput = true;
			this.xCIC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCIC.Name = "xCIC";
			this.xCIC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCIC.TagName = "STS_CICLO_LIGADO";
			this.xCIC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCICValueChanged);
			this.xCIC.EndInit();
			// 
			// xCMAN
			// 
			this.xCMAN.BeginInit();
			this.xCMAN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCMAN.IsOnlyInput = true;
			this.xCMAN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCMAN.Name = "xCMAN";
			this.xCMAN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCMAN.TagName = "STS_CMD_MANUAL";
			this.xCMAN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCMANValueChanged);
			this.xCMAN.EndInit();
			// 
			// xALS
			// 
			this.xALS.BeginInit();
			this.xALS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xALS.IsOnlyInput = true;
			this.xALS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xALS.Name = "xALS";
			this.xALS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xALS.TagName = "STS_ALARME_ACIONADO";
			this.xALS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XALSValueChanged);
			this.xALS.EndInit();
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
			// xFMOT
			// 
			this.xFMOT.BeginInit();
			this.xFMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFMOT.IsOnlyInput = true;
			this.xFMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFMOT.Name = "xFMOT";
			this.xFMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFMOT.TagName = "STS_FALHA_MOTOR";
			this.xFMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFMOTValueChanged);
			this.xFMOT.EndInit();
			// 
			// xDISP
			// 
			this.xDISP.BeginInit();
			this.xDISP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDISP.IsOnlyInput = true;
			this.xDISP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDISP.Name = "xDISP";
			this.xDISP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDISP.TagName = "STS_DISPONIVEL";
			this.xDISP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDISPValueChanged);
			this.xDISP.EndInit();
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
			// xEEMG
			// 
			this.xEEMG.BeginInit();
			this.xEEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEMG.IsOnlyInput = true;
			this.xEEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEMG.Name = "xEEMG";
			this.xEEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEMG.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEEMGValueChanged);
			this.xEEMG.EndInit();
			// 
			// xESKD
			// 
			this.xESKD.BeginInit();
			this.xESKD.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESKD.IsOnlyInput = true;
			this.xESKD.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESKD.Name = "xESKD";
			this.xESKD.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESKD.TagName = "STS_ALM_SKID_EST";
			this.xESKD.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESKDValueChanged);
			this.xESKD.EndInit();
			// 
			// xEMOT
			// 
			this.xEMOT.BeginInit();
			this.xEMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMOT.IsOnlyInput = true;
			this.xEMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMOT.Name = "xEMOT";
			this.xEMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMOT.TagName = "STS_ALM_MOTOR_EST";
			this.xEMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMOTValueChanged);
			this.xEMOT.EndInit();
			// 
			// xM1
			// 
			this.xM1.BeginInit();
			this.xM1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM1.IsOnlyInput = true;
			this.xM1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM1.Name = "xM1";
			this.xM1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM1.TagName = "STS_M1";
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
			this.xM2.TagName = "STS_M2";
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
			this.xM3.TagName = "STS_M3";
			this.xM3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM3ValueChanged);
			this.xM3.EndInit();
			// 
			// xM4
			// 
			this.xM4.BeginInit();
			this.xM4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM4.IsOnlyInput = true;
			this.xM4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM4.Name = "xM4";
			this.xM4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM4.TagName = "STS_M4";
			this.xM4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM4ValueChanged);
			this.xM4.EndInit();
			// 
			// xM5
			// 
			this.xM5.BeginInit();
			this.xM5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xM5.IsOnlyInput = true;
			this.xM5.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xM5.Name = "xM5";
			this.xM5.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xM5.TagName = "STS_M5";
			this.xM5.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM5ValueChanged);
			this.xM5.EndInit();
			// 
			// xDOS
			// 
			this.xDOS.BeginInit();
			this.xDOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDOS.IsOnlyInput = true;
			this.xDOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDOS.Name = "xDOS";
			this.xDOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDOS.TagName = "STS_DOSANDO";
			this.xDOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDOSValueChanged);
			this.xDOS.EndInit();
			// 
			// xSILO
			// 
			this.xSILO.BeginInit();
			this.xSILO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSILO.IsOnlyInput = true;
			this.xSILO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSILO.Name = "xSILO";
			this.xSILO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSILO.TagName = "STS_SILO_BAIXO";
			this.xSILO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSILOValueChanged);
			this.xSILO.EndInit();
			// 
			// xNIVP
			// 
			this.xNIVP.BeginInit();
			this.xNIVP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNIVP.IsOnlyInput = true;
			this.xNIVP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNIVP.Name = "xNIVP";
			this.xNIVP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNIVP.TagName = "STS_NIVEL_PREPARO";
			this.xNIVP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNIVPValueChanged);
			this.xNIVP.EndInit();
			// 
			// xVAG
			// 
			this.xVAG.BeginInit();
			this.xVAG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVAG.IsOnlyInput = true;
			this.xVAG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVAG.Name = "xVAG";
			this.xVAG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVAG.TagName = "STS_VAZAO_AGUA";
			this.xVAG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVAGValueChanged);
			this.xVAG.EndInit();
			// 
			// xVPO
			// 
			this.xVPO.BeginInit();
			this.xVPO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVPO.IsOnlyInput = true;
			this.xVPO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVPO.Name = "xVPO";
			this.xVPO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVPO.TagName = "STS_VAZAO_POLIMERO";
			this.xVPO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVPOValueChanged);
			this.xVPO.EndInit();
			// 
			// xFAG
			// 
			this.xFAG.BeginInit();
			this.xFAG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFAG.IsOnlyInput = true;
			this.xFAG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFAG.Name = "xFAG";
			this.xFAG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFAG.TagName = "STS_FALTA_AGUA";
			this.xFAG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFAGValueChanged);
			this.xFAG.EndInit();
			// 
			// xAVZ
			// 
			this.xAVZ.BeginInit();
			this.xAVZ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVZ.IsOnlyInput = true;
			this.xAVZ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVZ.Name = "xAVZ";
			this.xAVZ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVZ.TagName = "STS_ALARME_VAZAO";
			this.xAVZ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAVZValueChanged);
			this.xAVZ.EndInit();
			// 
			// xVS01
			// 
			this.xVS01.BeginInit();
			this.xVS01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVS01.IsOnlyInput = true;
			this.xVS01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVS01.Name = "xVS01";
			this.xVS01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVS01.TagName = "STS_VS01_ABERTA";
			this.xVS01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVS01ValueChanged);
			this.xVS01.EndInit();
			// 
			// xRES
			// 
			this.xRES.BeginInit();
			this.xRES.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRES.IsOnlyInput = true;
			this.xRES.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRES.Name = "xRES";
			this.xRES.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRES.TagName = "STS_RESISTENCIA";
			this.xRES.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XRESValueChanged);
			this.xRES.EndInit();
			// 
			// xESIL
			// 
			this.xESIL.BeginInit();
			this.xESIL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESIL.IsOnlyInput = true;
			this.xESIL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESIL.Name = "xESIL";
			this.xESIL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESIL.TagName = "STS_ALM_SILO_EST";
			this.xESIL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESILValueChanged);
			this.xESIL.EndInit();
			// 
			// xEAGU
			// 
			this.xEAGU.BeginInit();
			this.xEAGU.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEAGU.IsOnlyInput = true;
			this.xEAGU.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEAGU.Name = "xEAGU";
			this.xEAGU.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEAGU.TagName = "STS_ALM_AGUA_EST";
			this.xEAGU.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEAGUValueChanged);
			this.xEAGU.EndInit();
			// 
			// xEVAZ
			// 
			this.xEVAZ.BeginInit();
			this.xEVAZ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVAZ.IsOnlyInput = true;
			this.xEVAZ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVAZ.Name = "xEVAZ";
			this.xEVAZ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVAZ.TagName = "STS_ALM_VAZAO_EST";
			this.xEVAZ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEVAZValueChanged);
			this.xEVAZ.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(514D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.e1,
			this.e2,
			this.rMot,
			this.nm0,
			this.vm0,
			this.nm1,
			this.vm1,
			this.nm2,
			this.vm2,
			this.nm3,
			this.vm3,
			this.nm4,
			this.vm4,
			this.rDet,
			this.rDet2,
			this.rDet3,
			this.rModo,
			this.btnAuto,
			this.btnMan,
			this.rCic,
			this.btnLiga,
			this.btnDesl,
			this.btnReset,
			this.btnSkid,
			this.xFCOM,
			this.xHAB,
			this.xAUTO,
			this.xCIC,
			this.xCMAN,
			this.xALS,
			this.xEMG,
			this.xFMOT,
			this.xDISP,
			this.xECOM,
			this.xEEMG,
			this.xESKD,
			this.xEMOT,
			this.xM1,
			this.xM2,
			this.xM3,
			this.xM4,
			this.xM5,
			this.xDOS,
			this.xSILO,
			this.xNIVP,
			this.xVAG,
			this.xVPO,
			this.xFAG,
			this.xAVZ,
			this.xVS01,
			this.xRES,
			this.xESIL,
			this.xEAGU,
			this.xEVAZ});
			this.Size = new System.Drawing.Size(380, 514);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText e1;
		private NxtControl.GuiFramework.FreeText e2;
		private NxtControl.GuiFramework.FreeText rMot;
		private NxtControl.GuiFramework.FreeText nm0;
		private NxtControl.GuiFramework.FreeText vm0;
		private NxtControl.GuiFramework.FreeText nm1;
		private NxtControl.GuiFramework.FreeText vm1;
		private NxtControl.GuiFramework.FreeText nm2;
		private NxtControl.GuiFramework.FreeText vm2;
		private NxtControl.GuiFramework.FreeText nm3;
		private NxtControl.GuiFramework.FreeText vm3;
		private NxtControl.GuiFramework.FreeText nm4;
		private NxtControl.GuiFramework.FreeText vm4;
		private NxtControl.GuiFramework.FreeText rDet;
		private NxtControl.GuiFramework.FreeText rDet2;
		private NxtControl.GuiFramework.FreeText rDet3;
		private NxtControl.GuiFramework.FreeText rModo;
		private NxtControl.GuiFramework.DrawnButton btnAuto;
		private NxtControl.GuiFramework.DrawnButton btnMan;
		private NxtControl.GuiFramework.FreeText rCic;
		private NxtControl.GuiFramework.DrawnButton btnLiga;
		private NxtControl.GuiFramework.DrawnButton btnDesl;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnSkid;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xHAB;
		private System.HMI.Symbols.Base.Execute<bool> xAUTO;
		private System.HMI.Symbols.Base.Execute<bool> xCIC;
		private System.HMI.Symbols.Base.Execute<bool> xCMAN;
		private System.HMI.Symbols.Base.Execute<bool> xALS;
		private System.HMI.Symbols.Base.Execute<bool> xEMG;
		private System.HMI.Symbols.Base.Execute<bool> xFMOT;
		private System.HMI.Symbols.Base.Execute<bool> xDISP;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xEEMG;
		private System.HMI.Symbols.Base.Execute<byte> xESKD;
		private System.HMI.Symbols.Base.Execute<byte> xEMOT;
		private System.HMI.Symbols.Base.Execute<short> xM1;
		private System.HMI.Symbols.Base.Execute<short> xM2;
		private System.HMI.Symbols.Base.Execute<short> xM3;
		private System.HMI.Symbols.Base.Execute<short> xM4;
		private System.HMI.Symbols.Base.Execute<short> xM5;
		private System.HMI.Symbols.Base.Execute<bool> xDOS;
		private System.HMI.Symbols.Base.Execute<bool> xSILO;
		private System.HMI.Symbols.Base.Execute<short> xNIVP;
		private System.HMI.Symbols.Base.Execute<float> xVAG;
		private System.HMI.Symbols.Base.Execute<float> xVPO;
		private System.HMI.Symbols.Base.Execute<bool> xFAG;
		private System.HMI.Symbols.Base.Execute<short> xAVZ;
		private System.HMI.Symbols.Base.Execute<bool> xVS01;
		private System.HMI.Symbols.Base.Execute<bool> xRES;
		private System.HMI.Symbols.Base.Execute<byte> xESIL;
		private System.HMI.Symbols.Base.Execute<byte> xEAGU;
		private System.HMI.Symbols.Base.Execute<byte> xEVAZ;
		#endregion
	}
}
