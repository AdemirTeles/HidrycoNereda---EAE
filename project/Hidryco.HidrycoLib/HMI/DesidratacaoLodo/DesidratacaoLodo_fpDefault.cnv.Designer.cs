/*
 * Hidryco - DesidratacaoLodo - fpDefault
 * Fase solida: liga/desliga o desaguamento por prensa, estado da alimentacao, solenoides manuais e reconhecimento.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.DesidratacaoLodo
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
			this.nAD1 = new NxtControl.GuiFramework.FreeText();
			this.eAD1 = new NxtControl.GuiFramework.FreeText();
			this.btnLiga1 = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesl1 = new NxtControl.GuiFramework.DrawnButton();
			this.nAD2 = new NxtControl.GuiFramework.FreeText();
			this.eAD2 = new NxtControl.GuiFramework.FreeText();
			this.btnLiga2 = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesl2 = new NxtControl.GuiFramework.DrawnButton();
			this.nAD3 = new NxtControl.GuiFramework.FreeText();
			this.eAD3 = new NxtControl.GuiFramework.FreeText();
			this.btnLiga3 = new NxtControl.GuiFramework.DrawnButton();
			this.btnDesl3 = new NxtControl.GuiFramework.DrawnButton();
			this.rSv = new NxtControl.GuiFramework.FreeText();
			this.btnSv01 = new NxtControl.GuiFramework.DrawnButton();
			this.btnSv02 = new NxtControl.GuiFramework.DrawnButton();
			this.btnSv03 = new NxtControl.GuiFramework.DrawnButton();
			this.btnSv04 = new NxtControl.GuiFramework.DrawnButton();
			this.btnSv06 = new NxtControl.GuiFramework.DrawnButton();
			this.btnSv08 = new NxtControl.GuiFramework.DrawnButton();
			this.btnPar = new NxtControl.GuiFramework.DrawnButton();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
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
			this.xSV = new System.HMI.Symbols.Base.Execute<short>();
			this.xC1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC3 = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(460D)), ((float)(50D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(16D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 17D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(16D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 32D),
			new NxtControl.Drawing.PointF(28D, 16D),
			new NxtControl.Drawing.PointF(36D, 32D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 19D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 16D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// nAD1
			// 
			this.nAD1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nAD1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.nAD1.Location = new NxtControl.Drawing.PointF(20D, 60D);
			this.nAD1.Name = "nAD1";
			this.nAD1.Text = "Prensa 900-AD-01";
			// 
			// eAD1
			// 
			this.eAD1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.eAD1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.eAD1.Location = new NxtControl.Drawing.PointF(20D, 82D);
			this.eAD1.Name = "eAD1";
			this.eAD1.Text = "";
			// 
			// btnLiga1
			// 
			this.btnLiga1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(106D)), ((float)(200D)), ((float)(34D)));
			this.btnLiga1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLiga1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnLiga1.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLiga1.Name = "btnLiga1";
			this.btnLiga1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLiga1.Radius = 2D;
			this.btnLiga1.Text = "Ligar desaguamento";
			this.btnLiga1.Use3DEffect = false;
			this.btnLiga1.Click += new System.EventHandler(this.BtnLiga1Click);
			// 
			// btnDesl1
			// 
			this.btnDesl1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(106D)), ((float)(200D)), ((float)(34D)));
			this.btnDesl1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesl1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnDesl1.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesl1.Name = "btnDesl1";
			this.btnDesl1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesl1.Radius = 2D;
			this.btnDesl1.Text = "Desligar";
			this.btnDesl1.Use3DEffect = false;
			this.btnDesl1.Click += new System.EventHandler(this.BtnDesl1Click);
			// 
			// nAD2
			// 
			this.nAD2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nAD2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.nAD2.Location = new NxtControl.Drawing.PointF(20D, 165D);
			this.nAD2.Name = "nAD2";
			this.nAD2.Text = "Prensa 900-AD-02";
			// 
			// eAD2
			// 
			this.eAD2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.eAD2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.eAD2.Location = new NxtControl.Drawing.PointF(20D, 187D);
			this.eAD2.Name = "eAD2";
			this.eAD2.Text = "";
			// 
			// btnLiga2
			// 
			this.btnLiga2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(211D)), ((float)(200D)), ((float)(34D)));
			this.btnLiga2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLiga2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnLiga2.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLiga2.Name = "btnLiga2";
			this.btnLiga2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLiga2.Radius = 2D;
			this.btnLiga2.Text = "Ligar desaguamento";
			this.btnLiga2.Use3DEffect = false;
			this.btnLiga2.Click += new System.EventHandler(this.BtnLiga2Click);
			// 
			// btnDesl2
			// 
			this.btnDesl2.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(211D)), ((float)(200D)), ((float)(34D)));
			this.btnDesl2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesl2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnDesl2.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesl2.Name = "btnDesl2";
			this.btnDesl2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesl2.Radius = 2D;
			this.btnDesl2.Text = "Desligar";
			this.btnDesl2.Use3DEffect = false;
			this.btnDesl2.Click += new System.EventHandler(this.BtnDesl2Click);
			// 
			// nAD3
			// 
			this.nAD3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.nAD3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.nAD3.Location = new NxtControl.Drawing.PointF(20D, 270D);
			this.nAD3.Name = "nAD3";
			this.nAD3.Text = "Prensa 900-AD-03 (futura)";
			// 
			// eAD3
			// 
			this.eAD3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.eAD3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.eAD3.Location = new NxtControl.Drawing.PointF(20D, 292D);
			this.eAD3.Name = "eAD3";
			this.eAD3.Text = "";
			// 
			// btnLiga3
			// 
			this.btnLiga3.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(316D)), ((float)(200D)), ((float)(34D)));
			this.btnLiga3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnLiga3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnLiga3.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnLiga3.Name = "btnLiga3";
			this.btnLiga3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnLiga3.Radius = 2D;
			this.btnLiga3.Text = "Ligar desaguamento";
			this.btnLiga3.Use3DEffect = false;
			this.btnLiga3.Click += new System.EventHandler(this.BtnLiga3Click);
			// 
			// btnDesl3
			// 
			this.btnDesl3.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(316D)), ((float)(200D)), ((float)(34D)));
			this.btnDesl3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnDesl3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnDesl3.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnDesl3.Name = "btnDesl3";
			this.btnDesl3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnDesl3.Radius = 2D;
			this.btnDesl3.Text = "Desligar";
			this.btnDesl3.Use3DEffect = false;
			this.btnDesl3.Click += new System.EventHandler(this.BtnDesl3Click);
			// 
			// rSv
			// 
			this.rSv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rSv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rSv.Location = new NxtControl.Drawing.PointF(20D, 380D);
			this.rSv.Name = "rSv";
			this.rSv.Text = "Solenoides (manual): clique para abrir/fechar";
			// 
			// btnSv01
			// 
			this.btnSv01.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(404D)), ((float)(66D)), ((float)(34D)));
			this.btnSv01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSv01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSv01.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSv01.Name = "btnSv01";
			this.btnSv01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSv01.Radius = 2D;
			this.btnSv01.Text = "SV-01";
			this.btnSv01.Use3DEffect = false;
			this.btnSv01.Click += new System.EventHandler(this.BtnSvClick);
			// 
			// btnSv02
			// 
			this.btnSv02.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(404D)), ((float)(66D)), ((float)(34D)));
			this.btnSv02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSv02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSv02.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSv02.Name = "btnSv02";
			this.btnSv02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSv02.Radius = 2D;
			this.btnSv02.Text = "SV-02";
			this.btnSv02.Use3DEffect = false;
			this.btnSv02.Click += new System.EventHandler(this.BtnSvClick);
			// 
			// btnSv03
			// 
			this.btnSv03.Bounds = new NxtControl.Drawing.RectF(((float)(164D)), ((float)(404D)), ((float)(66D)), ((float)(34D)));
			this.btnSv03.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSv03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSv03.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSv03.Name = "btnSv03";
			this.btnSv03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSv03.Radius = 2D;
			this.btnSv03.Text = "SV-03";
			this.btnSv03.Use3DEffect = false;
			this.btnSv03.Click += new System.EventHandler(this.BtnSvClick);
			// 
			// btnSv04
			// 
			this.btnSv04.Bounds = new NxtControl.Drawing.RectF(((float)(236D)), ((float)(404D)), ((float)(66D)), ((float)(34D)));
			this.btnSv04.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSv04.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSv04.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSv04.Name = "btnSv04";
			this.btnSv04.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSv04.Radius = 2D;
			this.btnSv04.Text = "SV-04";
			this.btnSv04.Use3DEffect = false;
			this.btnSv04.Click += new System.EventHandler(this.BtnSvClick);
			// 
			// btnSv06
			// 
			this.btnSv06.Bounds = new NxtControl.Drawing.RectF(((float)(308D)), ((float)(404D)), ((float)(66D)), ((float)(34D)));
			this.btnSv06.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSv06.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSv06.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSv06.Name = "btnSv06";
			this.btnSv06.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSv06.Radius = 2D;
			this.btnSv06.Text = "SV-06";
			this.btnSv06.Use3DEffect = false;
			this.btnSv06.Click += new System.EventHandler(this.BtnSvClick);
			// 
			// btnSv08
			// 
			this.btnSv08.Bounds = new NxtControl.Drawing.RectF(((float)(380D)), ((float)(404D)), ((float)(66D)), ((float)(34D)));
			this.btnSv08.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSv08.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSv08.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSv08.Name = "btnSv08";
			this.btnSv08.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSv08.Radius = 2D;
			this.btnSv08.Text = "SV-08";
			this.btnSv08.Use3DEffect = false;
			this.btnSv08.Click += new System.EventHandler(this.BtnSvClick);
			// 
			// btnPar
			// 
			this.btnPar.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(460D)), ((float)(200D)), ((float)(40D)));
			this.btnPar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnPar.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnPar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnPar.Name = "btnPar";
			this.btnPar.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpParametros", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnPar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnPar.Radius = 2D;
			this.btnPar.Text = "Parâmetros";
			this.btnPar.Use3DEffect = false;
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(460D)), ((float)(200D)), ((float)(40D)));
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
			// xSV
			// 
			this.xSV.BeginInit();
			this.xSV.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSV.IsOnlyInput = true;
			this.xSV.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSV.Name = "xSV";
			this.xSV.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSV.TagName = "STS_SV";
			this.xSV.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSVValueChanged);
			this.xSV.EndInit();
			// 
			// xC1
			// 
			this.xC1.BeginInit();
			this.xC1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1.IsOnlyInput = true;
			this.xC1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1.Name = "xC1";
			this.xC1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1.TagName = "CMD_AD1";
			this.xC1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCValueChanged);
			this.xC1.EndInit();
			// 
			// xC2
			// 
			this.xC2.BeginInit();
			this.xC2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2.IsOnlyInput = true;
			this.xC2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2.Name = "xC2";
			this.xC2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2.TagName = "CMD_AD2";
			this.xC2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCValueChanged);
			this.xC2.EndInit();
			// 
			// xC3
			// 
			this.xC3.BeginInit();
			this.xC3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC3.IsOnlyInput = true;
			this.xC3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC3.Name = "xC3";
			this.xC3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC3.TagName = "CMD_AD3";
			this.xC3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCValueChanged);
			this.xC3.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(460D)), ((float)(520D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.nAD1,
			this.eAD1,
			this.btnLiga1,
			this.btnDesl1,
			this.nAD2,
			this.eAD2,
			this.btnLiga2,
			this.btnDesl2,
			this.nAD3,
			this.eAD3,
			this.btnLiga3,
			this.btnDesl3,
			this.rSv,
			this.btnSv01,
			this.btnSv02,
			this.btnSv03,
			this.btnSv04,
			this.btnSv06,
			this.btnSv08,
			this.btnPar,
			this.btnReset,
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
			this.xSV,
			this.xC1,
			this.xC2,
			this.xC3});
			this.Size = new System.Drawing.Size(460, 520);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText nAD1;
		private NxtControl.GuiFramework.FreeText eAD1;
		private NxtControl.GuiFramework.DrawnButton btnLiga1;
		private NxtControl.GuiFramework.DrawnButton btnDesl1;
		private NxtControl.GuiFramework.FreeText nAD2;
		private NxtControl.GuiFramework.FreeText eAD2;
		private NxtControl.GuiFramework.DrawnButton btnLiga2;
		private NxtControl.GuiFramework.DrawnButton btnDesl2;
		private NxtControl.GuiFramework.FreeText nAD3;
		private NxtControl.GuiFramework.FreeText eAD3;
		private NxtControl.GuiFramework.DrawnButton btnLiga3;
		private NxtControl.GuiFramework.DrawnButton btnDesl3;
		private NxtControl.GuiFramework.FreeText rSv;
		private NxtControl.GuiFramework.DrawnButton btnSv01;
		private NxtControl.GuiFramework.DrawnButton btnSv02;
		private NxtControl.GuiFramework.DrawnButton btnSv03;
		private NxtControl.GuiFramework.DrawnButton btnSv04;
		private NxtControl.GuiFramework.DrawnButton btnSv06;
		private NxtControl.GuiFramework.DrawnButton btnSv08;
		private NxtControl.GuiFramework.DrawnButton btnPar;
		private NxtControl.GuiFramework.DrawnButton btnReset;
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
		private System.HMI.Symbols.Base.Execute<short> xSV;
		private System.HMI.Symbols.Base.Execute<bool> xC1;
		private System.HMI.Symbols.Base.Execute<bool> xC2;
		private System.HMI.Symbols.Base.Execute<bool> xC3;
		#endregion
	}
}
