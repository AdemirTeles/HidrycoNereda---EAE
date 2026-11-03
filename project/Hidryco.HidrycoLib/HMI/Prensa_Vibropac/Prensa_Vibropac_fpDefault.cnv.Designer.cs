/*
 * Hidryco - Prensa_Vibropac - fpDefault
 * Prensa desaguadora Vibropac C-Press (VSD-1200): estado, motores, modo, comando manual do ciclo e reset.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Prensa_Vibropac
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
			this.xNIV = new System.HMI.Symbols.Base.Execute<float>();
			this.xFUN = new System.HMI.Symbols.Base.Execute<bool>();
			this.xVS1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFS1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xZS1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xZS2 = new System.HMI.Symbols.Base.Execute<bool>();
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
			this.alTxt.Visible = false;
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 32D);
			this.e1.Name = "e1";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(20D, 52D);
			this.e2.Name = "e2";
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
			// 
			// vm0
			// 
			this.vm0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm0.Location = new NxtControl.Drawing.PointF(220D, 108D);
			this.vm0.Name = "vm0";
			// 
			// nm1
			// 
			this.nm1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm1.Location = new NxtControl.Drawing.PointF(20D, 130D);
			this.nm1.Name = "nm1";
			// 
			// vm1
			// 
			this.vm1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm1.Location = new NxtControl.Drawing.PointF(220D, 130D);
			this.vm1.Name = "vm1";
			// 
			// nm2
			// 
			this.nm2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm2.Location = new NxtControl.Drawing.PointF(20D, 152D);
			this.nm2.Name = "nm2";
			// 
			// vm2
			// 
			this.vm2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm2.Location = new NxtControl.Drawing.PointF(220D, 152D);
			this.vm2.Name = "vm2";
			// 
			// nm3
			// 
			this.nm3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm3.Location = new NxtControl.Drawing.PointF(20D, 174D);
			this.nm3.Name = "nm3";
			// 
			// vm3
			// 
			this.vm3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm3.Location = new NxtControl.Drawing.PointF(220D, 174D);
			this.vm3.Name = "vm3";
			// 
			// nm4
			// 
			this.nm4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nm4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.nm4.Location = new NxtControl.Drawing.PointF(20D, 196D);
			this.nm4.Name = "nm4";
			// 
			// vm4
			// 
			this.vm4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vm4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vm4.Location = new NxtControl.Drawing.PointF(220D, 196D);
			this.vm4.Name = "vm4";
			// 
			// rDet
			// 
			this.rDet.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rDet.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDet.Location = new NxtControl.Drawing.PointF(20D, 222D);
			this.rDet.Name = "rDet";
			// 
			// rDet2
			// 
			this.rDet2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rDet2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDet2.Location = new NxtControl.Drawing.PointF(20D, 242D);
			this.rDet2.Name = "rDet2";
			// 
			// rDet3
			// 
			this.rDet3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rDet3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rDet3.Location = new NxtControl.Drawing.PointF(20D, 262D);
			this.rDet3.Name = "rDet3";
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
			this.xFCOM.Value = false;
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
			this.xHAB.Value = false;
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
			this.xAUTO.Value = false;
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
			this.xCIC.Value = false;
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
			this.xCMAN.Value = false;
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
			this.xALS.Value = false;
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
			this.xEMG.Value = false;
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
			this.xFMOT.Value = false;
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
			this.xDISP.Value = false;
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
			this.xECOM.Value = ((byte)(0));
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
			this.xEEMG.Value = ((byte)(0));
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
			this.xESKD.Value = ((byte)(0));
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
			this.xEMOT.Value = ((byte)(0));
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
			this.xM1.Value = ((short)(0));
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
			this.xM2.Value = ((short)(0));
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
			this.xM3.Value = ((short)(0));
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
			this.xM4.Value = ((short)(0));
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
			this.xM5.Value = ((short)(0));
			this.xM5.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XM5ValueChanged);
			this.xM5.EndInit();
			// 
			// xNIV
			// 
			this.xNIV.BeginInit();
			this.xNIV.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNIV.IsOnlyInput = true;
			this.xNIV.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNIV.Name = "xNIV";
			this.xNIV.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNIV.TagName = "STS_NIVEL_FLOCULADOR";
			this.xNIV.Value = 0F;
			this.xNIV.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNIVValueChanged);
			this.xNIV.EndInit();
			// 
			// xFUN
			// 
			this.xFUN.BeginInit();
			this.xFUN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFUN.IsOnlyInput = true;
			this.xFUN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFUN.Name = "xFUN";
			this.xFUN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFUN.TagName = "STS_FUNCIONANDO";
			this.xFUN.Value = false;
			this.xFUN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFUNValueChanged);
			this.xFUN.EndInit();
			// 
			// xVS1
			// 
			this.xVS1.BeginInit();
			this.xVS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVS1.IsOnlyInput = true;
			this.xVS1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVS1.Name = "xVS1";
			this.xVS1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVS1.TagName = "STS_VS1_ABERTA";
			this.xVS1.Value = false;
			this.xVS1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVS1ValueChanged);
			this.xVS1.EndInit();
			// 
			// xFS1
			// 
			this.xFS1.BeginInit();
			this.xFS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFS1.IsOnlyInput = true;
			this.xFS1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFS1.Name = "xFS1";
			this.xFS1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFS1.TagName = "STS_FS1_FLUXO";
			this.xFS1.Value = false;
			this.xFS1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFS1ValueChanged);
			this.xFS1.EndInit();
			// 
			// xZS1
			// 
			this.xZS1.BeginInit();
			this.xZS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xZS1.IsOnlyInput = true;
			this.xZS1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xZS1.Name = "xZS1";
			this.xZS1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xZS1.TagName = "STS_ZSAH1";
			this.xZS1.Value = false;
			this.xZS1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XZS1ValueChanged);
			this.xZS1.EndInit();
			// 
			// xZS2
			// 
			this.xZS2.BeginInit();
			this.xZS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xZS2.IsOnlyInput = true;
			this.xZS2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xZS2.Name = "xZS2";
			this.xZS2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xZS2.TagName = "STS_ZSAH2";
			this.xZS2.Value = false;
			this.xZS2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XZS2ValueChanged);
			this.xZS2.EndInit();
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
			this.xNIV,
			this.xFUN,
			this.xVS1,
			this.xFS1,
			this.xZS1,
			this.xZS2});
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
		private System.HMI.Symbols.Base.Execute<float> xNIV;
		private System.HMI.Symbols.Base.Execute<bool> xFUN;
		private System.HMI.Symbols.Base.Execute<bool> xVS1;
		private System.HMI.Symbols.Base.Execute<bool> xFS1;
		private System.HMI.Symbols.Base.Execute<bool> xZS1;
		private System.HMI.Symbols.Base.Execute<bool> xZS2;
		#endregion
	}
}
