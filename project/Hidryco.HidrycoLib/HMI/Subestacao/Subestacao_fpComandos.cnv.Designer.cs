/*
 * Hidryco - Subestacao - fpComandos
 * Comandos de abrir/fechar dos Masterpact 1Q1, 1Q0 e 1Q2 com intertravamentos e confirmacao.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Subestacao
{
	/// <summary>
	/// Summary description for fpComandos.
	/// </summary>
	partial class fpComandos
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.tRemota = new NxtControl.GuiFramework.FreeText();
			this.col1Q1 = new NxtControl.GuiFramework.Rectangle();
			this.n1Q1 = new NxtControl.GuiFramework.FreeText();
			this.d1Q1 = new NxtControl.GuiFramework.FreeText();
			this.b1Q1 = new NxtControl.GuiFramework.Rectangle();
			this.e1Q1 = new NxtControl.GuiFramework.FreeText();
			this.rL_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.vL_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.rP_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.vP_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.rC_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.vC_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.rSF_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.vSF_1Q1 = new NxtControl.GuiFramework.FreeText();
			this.c1Q1 = new NxtControl.GuiFramework.FreeText();
			this.btnAbrir1Q1 = new NxtControl.GuiFramework.DrawnButton();
			this.btnFechar1Q1 = new NxtControl.GuiFramework.DrawnButton();
			this.m1Q1 = new NxtControl.GuiFramework.FreeText();
			this.col1Q0 = new NxtControl.GuiFramework.Rectangle();
			this.n1Q0 = new NxtControl.GuiFramework.FreeText();
			this.d1Q0 = new NxtControl.GuiFramework.FreeText();
			this.b1Q0 = new NxtControl.GuiFramework.Rectangle();
			this.e1Q0 = new NxtControl.GuiFramework.FreeText();
			this.rL_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.vL_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.rP_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.vP_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.rC_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.vC_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.rSF_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.vSF_1Q0 = new NxtControl.GuiFramework.FreeText();
			this.c1Q0 = new NxtControl.GuiFramework.FreeText();
			this.btnAbrir1Q0 = new NxtControl.GuiFramework.DrawnButton();
			this.btnFechar1Q0 = new NxtControl.GuiFramework.DrawnButton();
			this.m1Q0 = new NxtControl.GuiFramework.FreeText();
			this.col1Q2 = new NxtControl.GuiFramework.Rectangle();
			this.n1Q2 = new NxtControl.GuiFramework.FreeText();
			this.d1Q2 = new NxtControl.GuiFramework.FreeText();
			this.b1Q2 = new NxtControl.GuiFramework.Rectangle();
			this.e1Q2 = new NxtControl.GuiFramework.FreeText();
			this.rL_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.vL_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.rP_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.vP_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.rC_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.vC_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.rSF_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.vSF_1Q2 = new NxtControl.GuiFramework.FreeText();
			this.c1Q2 = new NxtControl.GuiFramework.FreeText();
			this.btnAbrir1Q2 = new NxtControl.GuiFramework.DrawnButton();
			this.btnFechar1Q2 = new NxtControl.GuiFramework.DrawnButton();
			this.m1Q2 = new NxtControl.GuiFramework.FreeText();
			this.confFundo = new NxtControl.GuiFramework.Rectangle();
			this.confTexto = new NxtControl.GuiFramework.FreeText();
			this.btnConfirmar = new NxtControl.GuiFramework.DrawnButton();
			this.btnCancelar = new NxtControl.GuiFramework.DrawnButton();
			this.xL_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xR_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xP_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSF_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xE_1Q1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xPA_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPF_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCA_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCF_1Q1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xL_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xR_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xP_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSF_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xE_1Q0 = new System.HMI.Symbols.Base.Execute<short>();
			this.xPA_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPF_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCA_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCF_1Q0 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xL_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xR_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xP_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSF_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xE_1Q2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xPA_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPF_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCA_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCF_1Q2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRemota = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(900D)), ((float)(50D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Masterpact do QGBT 440 V";
			// 
			// tRemota
			// 
			this.tRemota.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRemota.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tRemota.Location = new NxtControl.Drawing.PointF(380D, 16D);
			this.tRemota.Name = "tRemota";
			this.tRemota.Text = "";
			// 
			// col1Q1
			// 
			this.col1Q1.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(60D)), ((float)(280D)), ((float)(330D)));
			this.col1Q1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.col1Q1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.col1Q1.Name = "col1Q1";
			this.col1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// n1Q1
			// 
			this.n1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n1Q1.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.n1Q1.Location = new NxtControl.Drawing.PointF(26D, 66D);
			this.n1Q1.Name = "n1Q1";
			this.n1Q1.Text = "1Q1";
			// 
			// d1Q1
			// 
			this.d1Q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.d1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.d1Q1.Location = new NxtControl.Drawing.PointF(80D, 70D);
			this.d1Q1.Name = "d1Q1";
			this.d1Q1.Text = "Entrada barra A (QTAM 1)";
			// 
			// b1Q1
			// 
			this.b1Q1.Bounds = new NxtControl.Drawing.RectF(((float)(249D)), ((float)(67D)), ((float)(22D)), ((float)(22D)));
			this.b1Q1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.b1Q1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b1Q1.Name = "b1Q1";
			this.b1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// e1Q1
			// 
			this.e1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1Q1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.e1Q1.Location = new NxtControl.Drawing.PointF(26D, 96D);
			this.e1Q1.Name = "e1Q1";
			this.e1Q1.Text = "—";
			// 
			// rL_1Q1
			// 
			this.rL_1Q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rL_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rL_1Q1.Location = new NxtControl.Drawing.PointF(26D, 128D);
			this.rL_1Q1.Name = "rL_1Q1";
			this.rL_1Q1.Text = "Local / remoto";
			// 
			// vL_1Q1
			// 
			this.vL_1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vL_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vL_1Q1.Location = new NxtControl.Drawing.PointF(160D, 128D);
			this.vL_1Q1.Name = "vL_1Q1";
			this.vL_1Q1.Text = "—";
			// 
			// rP_1Q1
			// 
			this.rP_1Q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rP_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rP_1Q1.Location = new NxtControl.Drawing.PointF(26D, 152D);
			this.rP_1Q1.Name = "rP_1Q1";
			this.rP_1Q1.Text = "Pronto para fechar";
			// 
			// vP_1Q1
			// 
			this.vP_1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vP_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vP_1Q1.Location = new NxtControl.Drawing.PointF(160D, 152D);
			this.vP_1Q1.Name = "vP_1Q1";
			this.vP_1Q1.Text = "—";
			// 
			// rC_1Q1
			// 
			this.rC_1Q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rC_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rC_1Q1.Location = new NxtControl.Drawing.PointF(26D, 176D);
			this.rC_1Q1.Name = "rC_1Q1";
			this.rC_1Q1.Text = "Mola";
			// 
			// vC_1Q1
			// 
			this.vC_1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vC_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vC_1Q1.Location = new NxtControl.Drawing.PointF(160D, 176D);
			this.vC_1Q1.Name = "vC_1Q1";
			this.vC_1Q1.Text = "—";
			// 
			// rSF_1Q1
			// 
			this.rSF_1Q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rSF_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rSF_1Q1.Location = new NxtControl.Drawing.PointF(26D, 200D);
			this.rSF_1Q1.Name = "rSF_1Q1";
			this.rSF_1Q1.Text = "Proteção";
			// 
			// vSF_1Q1
			// 
			this.vSF_1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vSF_1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vSF_1Q1.Location = new NxtControl.Drawing.PointF(160D, 200D);
			this.vSF_1Q1.Name = "vSF_1Q1";
			this.vSF_1Q1.Text = "—";
			// 
			// c1Q1
			// 
			this.c1Q1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.c1Q1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.c1Q1.Location = new NxtControl.Drawing.PointF(26D, 232D);
			this.c1Q1.Name = "c1Q1";
			this.c1Q1.Text = "";
			// 
			// btnAbrir1Q1
			// 
			this.btnAbrir1Q1.Bounds = new NxtControl.Drawing.RectF(((float)(26D)), ((float)(256D)), ((float)(124D)), ((float)(40D)));
			this.btnAbrir1Q1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAbrir1Q1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAbrir1Q1.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAbrir1Q1.Name = "btnAbrir1Q1";
			this.btnAbrir1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAbrir1Q1.Radius = 2D;
			this.btnAbrir1Q1.Text = "Abrir";
			this.btnAbrir1Q1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAbrir1Q1.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAbrir1Q1.Use3DEffect = false;
			this.btnAbrir1Q1.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// btnFechar1Q1
			// 
			this.btnFechar1Q1.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(256D)), ((float)(124D)), ((float)(40D)));
			this.btnFechar1Q1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnFechar1Q1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnFechar1Q1.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnFechar1Q1.Name = "btnFechar1Q1";
			this.btnFechar1Q1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnFechar1Q1.Radius = 2D;
			this.btnFechar1Q1.Text = "Fechar";
			this.btnFechar1Q1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnFechar1Q1.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnFechar1Q1.Use3DEffect = false;
			this.btnFechar1Q1.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// m1Q1
			// 
			this.m1Q1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.m1Q1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m1Q1.Location = new NxtControl.Drawing.PointF(26D, 306D);
			this.m1Q1.Name = "m1Q1";
			this.m1Q1.Text = "";
			// 
			// col1Q0
			// 
			this.col1Q0.Bounds = new NxtControl.Drawing.RectF(((float)(306D)), ((float)(60D)), ((float)(280D)), ((float)(330D)));
			this.col1Q0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.col1Q0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.col1Q0.Name = "col1Q0";
			this.col1Q0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// n1Q0
			// 
			this.n1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n1Q0.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.n1Q0.Location = new NxtControl.Drawing.PointF(318D, 66D);
			this.n1Q0.Name = "n1Q0";
			this.n1Q0.Text = "1Q0";
			// 
			// d1Q0
			// 
			this.d1Q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.d1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.d1Q0.Location = new NxtControl.Drawing.PointF(372D, 70D);
			this.d1Q0.Name = "d1Q0";
			this.d1Q0.Text = "Acoplamento das barras";
			// 
			// b1Q0
			// 
			this.b1Q0.Bounds = new NxtControl.Drawing.RectF(((float)(541D)), ((float)(67D)), ((float)(22D)), ((float)(22D)));
			this.b1Q0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.b1Q0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b1Q0.Name = "b1Q0";
			this.b1Q0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// e1Q0
			// 
			this.e1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1Q0.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.e1Q0.Location = new NxtControl.Drawing.PointF(318D, 96D);
			this.e1Q0.Name = "e1Q0";
			this.e1Q0.Text = "—";
			// 
			// rL_1Q0
			// 
			this.rL_1Q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rL_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rL_1Q0.Location = new NxtControl.Drawing.PointF(318D, 128D);
			this.rL_1Q0.Name = "rL_1Q0";
			this.rL_1Q0.Text = "Local / remoto";
			// 
			// vL_1Q0
			// 
			this.vL_1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vL_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vL_1Q0.Location = new NxtControl.Drawing.PointF(452D, 128D);
			this.vL_1Q0.Name = "vL_1Q0";
			this.vL_1Q0.Text = "—";
			// 
			// rP_1Q0
			// 
			this.rP_1Q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rP_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rP_1Q0.Location = new NxtControl.Drawing.PointF(318D, 152D);
			this.rP_1Q0.Name = "rP_1Q0";
			this.rP_1Q0.Text = "Pronto para fechar";
			// 
			// vP_1Q0
			// 
			this.vP_1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vP_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vP_1Q0.Location = new NxtControl.Drawing.PointF(452D, 152D);
			this.vP_1Q0.Name = "vP_1Q0";
			this.vP_1Q0.Text = "—";
			// 
			// rC_1Q0
			// 
			this.rC_1Q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rC_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rC_1Q0.Location = new NxtControl.Drawing.PointF(318D, 176D);
			this.rC_1Q0.Name = "rC_1Q0";
			this.rC_1Q0.Text = "Mola";
			// 
			// vC_1Q0
			// 
			this.vC_1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vC_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vC_1Q0.Location = new NxtControl.Drawing.PointF(452D, 176D);
			this.vC_1Q0.Name = "vC_1Q0";
			this.vC_1Q0.Text = "—";
			// 
			// rSF_1Q0
			// 
			this.rSF_1Q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rSF_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rSF_1Q0.Location = new NxtControl.Drawing.PointF(318D, 200D);
			this.rSF_1Q0.Name = "rSF_1Q0";
			this.rSF_1Q0.Text = "Proteção";
			// 
			// vSF_1Q0
			// 
			this.vSF_1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vSF_1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vSF_1Q0.Location = new NxtControl.Drawing.PointF(452D, 200D);
			this.vSF_1Q0.Name = "vSF_1Q0";
			this.vSF_1Q0.Text = "—";
			// 
			// c1Q0
			// 
			this.c1Q0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.c1Q0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.c1Q0.Location = new NxtControl.Drawing.PointF(318D, 232D);
			this.c1Q0.Name = "c1Q0";
			this.c1Q0.Text = "";
			// 
			// btnAbrir1Q0
			// 
			this.btnAbrir1Q0.Bounds = new NxtControl.Drawing.RectF(((float)(318D)), ((float)(256D)), ((float)(124D)), ((float)(40D)));
			this.btnAbrir1Q0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAbrir1Q0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAbrir1Q0.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAbrir1Q0.Name = "btnAbrir1Q0";
			this.btnAbrir1Q0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAbrir1Q0.Radius = 2D;
			this.btnAbrir1Q0.Text = "Abrir";
			this.btnAbrir1Q0.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAbrir1Q0.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAbrir1Q0.Use3DEffect = false;
			this.btnAbrir1Q0.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// btnFechar1Q0
			// 
			this.btnFechar1Q0.Bounds = new NxtControl.Drawing.RectF(((float)(452D)), ((float)(256D)), ((float)(124D)), ((float)(40D)));
			this.btnFechar1Q0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnFechar1Q0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnFechar1Q0.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnFechar1Q0.Name = "btnFechar1Q0";
			this.btnFechar1Q0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnFechar1Q0.Radius = 2D;
			this.btnFechar1Q0.Text = "Fechar";
			this.btnFechar1Q0.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnFechar1Q0.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnFechar1Q0.Use3DEffect = false;
			this.btnFechar1Q0.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// m1Q0
			// 
			this.m1Q0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.m1Q0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m1Q0.Location = new NxtControl.Drawing.PointF(318D, 306D);
			this.m1Q0.Name = "m1Q0";
			this.m1Q0.Text = "";
			// 
			// col1Q2
			// 
			this.col1Q2.Bounds = new NxtControl.Drawing.RectF(((float)(598D)), ((float)(60D)), ((float)(280D)), ((float)(330D)));
			this.col1Q2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.col1Q2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.col1Q2.Name = "col1Q2";
			this.col1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// n1Q2
			// 
			this.n1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n1Q2.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.n1Q2.Location = new NxtControl.Drawing.PointF(610D, 66D);
			this.n1Q2.Name = "n1Q2";
			this.n1Q2.Text = "1Q2";
			// 
			// d1Q2
			// 
			this.d1Q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.d1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.d1Q2.Location = new NxtControl.Drawing.PointF(664D, 70D);
			this.d1Q2.Name = "d1Q2";
			this.d1Q2.Text = "Entrada barra B (QTAM 2)";
			// 
			// b1Q2
			// 
			this.b1Q2.Bounds = new NxtControl.Drawing.RectF(((float)(833D)), ((float)(67D)), ((float)(22D)), ((float)(22D)));
			this.b1Q2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.b1Q2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.b1Q2.Name = "b1Q2";
			this.b1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// e1Q2
			// 
			this.e1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1Q2.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.e1Q2.Location = new NxtControl.Drawing.PointF(610D, 96D);
			this.e1Q2.Name = "e1Q2";
			this.e1Q2.Text = "—";
			// 
			// rL_1Q2
			// 
			this.rL_1Q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rL_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rL_1Q2.Location = new NxtControl.Drawing.PointF(610D, 128D);
			this.rL_1Q2.Name = "rL_1Q2";
			this.rL_1Q2.Text = "Local / remoto";
			// 
			// vL_1Q2
			// 
			this.vL_1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vL_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vL_1Q2.Location = new NxtControl.Drawing.PointF(744D, 128D);
			this.vL_1Q2.Name = "vL_1Q2";
			this.vL_1Q2.Text = "—";
			// 
			// rP_1Q2
			// 
			this.rP_1Q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rP_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rP_1Q2.Location = new NxtControl.Drawing.PointF(610D, 152D);
			this.rP_1Q2.Name = "rP_1Q2";
			this.rP_1Q2.Text = "Pronto para fechar";
			// 
			// vP_1Q2
			// 
			this.vP_1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vP_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vP_1Q2.Location = new NxtControl.Drawing.PointF(744D, 152D);
			this.vP_1Q2.Name = "vP_1Q2";
			this.vP_1Q2.Text = "—";
			// 
			// rC_1Q2
			// 
			this.rC_1Q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rC_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rC_1Q2.Location = new NxtControl.Drawing.PointF(610D, 176D);
			this.rC_1Q2.Name = "rC_1Q2";
			this.rC_1Q2.Text = "Mola";
			// 
			// vC_1Q2
			// 
			this.vC_1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vC_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vC_1Q2.Location = new NxtControl.Drawing.PointF(744D, 176D);
			this.vC_1Q2.Name = "vC_1Q2";
			this.vC_1Q2.Text = "—";
			// 
			// rSF_1Q2
			// 
			this.rSF_1Q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rSF_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rSF_1Q2.Location = new NxtControl.Drawing.PointF(610D, 200D);
			this.rSF_1Q2.Name = "rSF_1Q2";
			this.rSF_1Q2.Text = "Proteção";
			// 
			// vSF_1Q2
			// 
			this.vSF_1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vSF_1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vSF_1Q2.Location = new NxtControl.Drawing.PointF(744D, 200D);
			this.vSF_1Q2.Name = "vSF_1Q2";
			this.vSF_1Q2.Text = "—";
			// 
			// c1Q2
			// 
			this.c1Q2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.c1Q2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.c1Q2.Location = new NxtControl.Drawing.PointF(610D, 232D);
			this.c1Q2.Name = "c1Q2";
			this.c1Q2.Text = "";
			// 
			// btnAbrir1Q2
			// 
			this.btnAbrir1Q2.Bounds = new NxtControl.Drawing.RectF(((float)(610D)), ((float)(256D)), ((float)(124D)), ((float)(40D)));
			this.btnAbrir1Q2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAbrir1Q2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAbrir1Q2.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAbrir1Q2.Name = "btnAbrir1Q2";
			this.btnAbrir1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAbrir1Q2.Radius = 2D;
			this.btnAbrir1Q2.Text = "Abrir";
			this.btnAbrir1Q2.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAbrir1Q2.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnAbrir1Q2.Use3DEffect = false;
			this.btnAbrir1Q2.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// btnFechar1Q2
			// 
			this.btnFechar1Q2.Bounds = new NxtControl.Drawing.RectF(((float)(744D)), ((float)(256D)), ((float)(124D)), ((float)(40D)));
			this.btnFechar1Q2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnFechar1Q2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnFechar1Q2.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnFechar1Q2.Name = "btnFechar1Q2";
			this.btnFechar1Q2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnFechar1Q2.Radius = 2D;
			this.btnFechar1Q2.Text = "Fechar";
			this.btnFechar1Q2.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnFechar1Q2.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnFechar1Q2.Use3DEffect = false;
			this.btnFechar1Q2.Click += new System.EventHandler(this.BtnCmdClick);
			// 
			// m1Q2
			// 
			this.m1Q2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.m1Q2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.m1Q2.Location = new NxtControl.Drawing.PointF(610D, 306D);
			this.m1Q2.Name = "m1Q2";
			this.m1Q2.Text = "";
			// 
			// confFundo
			// 
			this.confFundo.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(120D)), ((float)(600D)), ((float)(170D)));
			this.confFundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.confFundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.confFundo.Name = "confFundo";
			this.confFundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.confFundo.Visible = false;
			// 
			// confTexto
			// 
			this.confTexto.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.confTexto.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.confTexto.Location = new NxtControl.Drawing.PointF(170D, 136D);
			this.confTexto.Name = "confTexto";
			this.confTexto.Text = "";
			this.confTexto.Visible = false;
			// 
			// btnConfirmar
			// 
			this.btnConfirmar.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(226D)), ((float)(180D)), ((float)(44D)));
			this.btnConfirmar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnConfirmar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnConfirmar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnConfirmar.Name = "btnConfirmar";
			this.btnConfirmar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnConfirmar.Radius = 2D;
			this.btnConfirmar.Text = "Confirmar";
			this.btnConfirmar.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnConfirmar.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnConfirmar.Use3DEffect = false;
			this.btnConfirmar.Visible = false;
			this.btnConfirmar.Click += new System.EventHandler(this.BtnConfirmarClick);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Bounds = new NxtControl.Drawing.RectF(((float)(370D)), ((float)(226D)), ((float)(180D)), ((float)(44D)));
			this.btnCancelar.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnCancelar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnCancelar.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnCancelar.Radius = 2D;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnCancelar.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnCancelar.Use3DEffect = false;
			this.btnCancelar.Visible = false;
			this.btnCancelar.Click += new System.EventHandler(this.BtnCancelarClick);
			// 
			// xL_1Q1
			// 
			this.xL_1Q1.BeginInit();
			this.xL_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL_1Q1.IsOnlyInput = true;
			this.xL_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL_1Q1.Name = "xL_1Q1";
			this.xL_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL_1Q1.TagName = "MPL_1Q1";
			this.xL_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xL_1Q1.EndInit();
			// 
			// xR_1Q1
			// 
			this.xR_1Q1.BeginInit();
			this.xR_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xR_1Q1.IsOnlyInput = true;
			this.xR_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xR_1Q1.Name = "xR_1Q1";
			this.xR_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xR_1Q1.TagName = "MPR_1Q1";
			this.xR_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xR_1Q1.EndInit();
			// 
			// xP_1Q1
			// 
			this.xP_1Q1.BeginInit();
			this.xP_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xP_1Q1.IsOnlyInput = true;
			this.xP_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xP_1Q1.Name = "xP_1Q1";
			this.xP_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xP_1Q1.TagName = "MPP_1Q1";
			this.xP_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xP_1Q1.EndInit();
			// 
			// xC_1Q1
			// 
			this.xC_1Q1.BeginInit();
			this.xC_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC_1Q1.IsOnlyInput = true;
			this.xC_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC_1Q1.Name = "xC_1Q1";
			this.xC_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC_1Q1.TagName = "MPC_1Q1";
			this.xC_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xC_1Q1.EndInit();
			// 
			// xSF_1Q1
			// 
			this.xSF_1Q1.BeginInit();
			this.xSF_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSF_1Q1.IsOnlyInput = true;
			this.xSF_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSF_1Q1.Name = "xSF_1Q1";
			this.xSF_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSF_1Q1.TagName = "MPSF_1Q1";
			this.xSF_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xSF_1Q1.EndInit();
			// 
			// xE_1Q1
			// 
			this.xE_1Q1.BeginInit();
			this.xE_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xE_1Q1.IsOnlyInput = true;
			this.xE_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xE_1Q1.Name = "xE_1Q1";
			this.xE_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xE_1Q1.TagName = "EST_1Q1";
			this.xE_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xE_1Q1.EndInit();
			// 
			// xPA_1Q1
			// 
			this.xPA_1Q1.BeginInit();
			this.xPA_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPA_1Q1.IsOnlyInput = true;
			this.xPA_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPA_1Q1.Name = "xPA_1Q1";
			this.xPA_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPA_1Q1.TagName = "PERM_ABRIR1Q1";
			this.xPA_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xPA_1Q1.EndInit();
			// 
			// xPF_1Q1
			// 
			this.xPF_1Q1.BeginInit();
			this.xPF_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPF_1Q1.IsOnlyInput = true;
			this.xPF_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPF_1Q1.Name = "xPF_1Q1";
			this.xPF_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPF_1Q1.TagName = "PERM_FECHAR1Q1";
			this.xPF_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xPF_1Q1.EndInit();
			// 
			// xCA_1Q1
			// 
			this.xCA_1Q1.BeginInit();
			this.xCA_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCA_1Q1.IsOnlyInput = true;
			this.xCA_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCA_1Q1.Name = "xCA_1Q1";
			this.xCA_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCA_1Q1.TagName = "CMD_ABRIR1Q1";
			this.xCA_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xCA_1Q1.EndInit();
			// 
			// xCF_1Q1
			// 
			this.xCF_1Q1.BeginInit();
			this.xCF_1Q1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCF_1Q1.IsOnlyInput = true;
			this.xCF_1Q1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCF_1Q1.Name = "xCF_1Q1";
			this.xCF_1Q1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCF_1Q1.TagName = "CMD_FECHAR1Q1";
			this.xCF_1Q1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xCF_1Q1.EndInit();
			// 
			// xL_1Q0
			// 
			this.xL_1Q0.BeginInit();
			this.xL_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL_1Q0.IsOnlyInput = true;
			this.xL_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL_1Q0.Name = "xL_1Q0";
			this.xL_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL_1Q0.TagName = "MPL_1Q0";
			this.xL_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xL_1Q0.EndInit();
			// 
			// xR_1Q0
			// 
			this.xR_1Q0.BeginInit();
			this.xR_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xR_1Q0.IsOnlyInput = true;
			this.xR_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xR_1Q0.Name = "xR_1Q0";
			this.xR_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xR_1Q0.TagName = "MPR_1Q0";
			this.xR_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xR_1Q0.EndInit();
			// 
			// xP_1Q0
			// 
			this.xP_1Q0.BeginInit();
			this.xP_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xP_1Q0.IsOnlyInput = true;
			this.xP_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xP_1Q0.Name = "xP_1Q0";
			this.xP_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xP_1Q0.TagName = "MPP_1Q0";
			this.xP_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xP_1Q0.EndInit();
			// 
			// xC_1Q0
			// 
			this.xC_1Q0.BeginInit();
			this.xC_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC_1Q0.IsOnlyInput = true;
			this.xC_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC_1Q0.Name = "xC_1Q0";
			this.xC_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC_1Q0.TagName = "MPC_1Q0";
			this.xC_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xC_1Q0.EndInit();
			// 
			// xSF_1Q0
			// 
			this.xSF_1Q0.BeginInit();
			this.xSF_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSF_1Q0.IsOnlyInput = true;
			this.xSF_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSF_1Q0.Name = "xSF_1Q0";
			this.xSF_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSF_1Q0.TagName = "MPSF_1Q0";
			this.xSF_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xSF_1Q0.EndInit();
			// 
			// xE_1Q0
			// 
			this.xE_1Q0.BeginInit();
			this.xE_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xE_1Q0.IsOnlyInput = true;
			this.xE_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xE_1Q0.Name = "xE_1Q0";
			this.xE_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xE_1Q0.TagName = "EST_1Q0";
			this.xE_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xE_1Q0.EndInit();
			// 
			// xPA_1Q0
			// 
			this.xPA_1Q0.BeginInit();
			this.xPA_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPA_1Q0.IsOnlyInput = true;
			this.xPA_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPA_1Q0.Name = "xPA_1Q0";
			this.xPA_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPA_1Q0.TagName = "PERM_ABRIR1Q0";
			this.xPA_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xPA_1Q0.EndInit();
			// 
			// xPF_1Q0
			// 
			this.xPF_1Q0.BeginInit();
			this.xPF_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPF_1Q0.IsOnlyInput = true;
			this.xPF_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPF_1Q0.Name = "xPF_1Q0";
			this.xPF_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPF_1Q0.TagName = "PERM_FECHAR1Q0";
			this.xPF_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xPF_1Q0.EndInit();
			// 
			// xCA_1Q0
			// 
			this.xCA_1Q0.BeginInit();
			this.xCA_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCA_1Q0.IsOnlyInput = true;
			this.xCA_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCA_1Q0.Name = "xCA_1Q0";
			this.xCA_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCA_1Q0.TagName = "CMD_ABRIR1Q0";
			this.xCA_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xCA_1Q0.EndInit();
			// 
			// xCF_1Q0
			// 
			this.xCF_1Q0.BeginInit();
			this.xCF_1Q0.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCF_1Q0.IsOnlyInput = true;
			this.xCF_1Q0.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCF_1Q0.Name = "xCF_1Q0";
			this.xCF_1Q0.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCF_1Q0.TagName = "CMD_FECHAR1Q0";
			this.xCF_1Q0.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xCF_1Q0.EndInit();
			// 
			// xL_1Q2
			// 
			this.xL_1Q2.BeginInit();
			this.xL_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL_1Q2.IsOnlyInput = true;
			this.xL_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL_1Q2.Name = "xL_1Q2";
			this.xL_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL_1Q2.TagName = "MPL_1Q2";
			this.xL_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xL_1Q2.EndInit();
			// 
			// xR_1Q2
			// 
			this.xR_1Q2.BeginInit();
			this.xR_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xR_1Q2.IsOnlyInput = true;
			this.xR_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xR_1Q2.Name = "xR_1Q2";
			this.xR_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xR_1Q2.TagName = "MPR_1Q2";
			this.xR_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xR_1Q2.EndInit();
			// 
			// xP_1Q2
			// 
			this.xP_1Q2.BeginInit();
			this.xP_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xP_1Q2.IsOnlyInput = true;
			this.xP_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xP_1Q2.Name = "xP_1Q2";
			this.xP_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xP_1Q2.TagName = "MPP_1Q2";
			this.xP_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xP_1Q2.EndInit();
			// 
			// xC_1Q2
			// 
			this.xC_1Q2.BeginInit();
			this.xC_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC_1Q2.IsOnlyInput = true;
			this.xC_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC_1Q2.Name = "xC_1Q2";
			this.xC_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC_1Q2.TagName = "MPC_1Q2";
			this.xC_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xC_1Q2.EndInit();
			// 
			// xSF_1Q2
			// 
			this.xSF_1Q2.BeginInit();
			this.xSF_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSF_1Q2.IsOnlyInput = true;
			this.xSF_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSF_1Q2.Name = "xSF_1Q2";
			this.xSF_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSF_1Q2.TagName = "MPSF_1Q2";
			this.xSF_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xSF_1Q2.EndInit();
			// 
			// xE_1Q2
			// 
			this.xE_1Q2.BeginInit();
			this.xE_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xE_1Q2.IsOnlyInput = true;
			this.xE_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xE_1Q2.Name = "xE_1Q2";
			this.xE_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xE_1Q2.TagName = "EST_1Q2";
			this.xE_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xE_1Q2.EndInit();
			// 
			// xPA_1Q2
			// 
			this.xPA_1Q2.BeginInit();
			this.xPA_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPA_1Q2.IsOnlyInput = true;
			this.xPA_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPA_1Q2.Name = "xPA_1Q2";
			this.xPA_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPA_1Q2.TagName = "PERM_ABRIR1Q2";
			this.xPA_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xPA_1Q2.EndInit();
			// 
			// xPF_1Q2
			// 
			this.xPF_1Q2.BeginInit();
			this.xPF_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPF_1Q2.IsOnlyInput = true;
			this.xPF_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPF_1Q2.Name = "xPF_1Q2";
			this.xPF_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPF_1Q2.TagName = "PERM_FECHAR1Q2";
			this.xPF_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xPF_1Q2.EndInit();
			// 
			// xCA_1Q2
			// 
			this.xCA_1Q2.BeginInit();
			this.xCA_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCA_1Q2.IsOnlyInput = true;
			this.xCA_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCA_1Q2.Name = "xCA_1Q2";
			this.xCA_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCA_1Q2.TagName = "CMD_ABRIR1Q2";
			this.xCA_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xCA_1Q2.EndInit();
			// 
			// xCF_1Q2
			// 
			this.xCF_1Q2.BeginInit();
			this.xCF_1Q2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCF_1Q2.IsOnlyInput = true;
			this.xCF_1Q2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCF_1Q2.Name = "xCF_1Q2";
			this.xCF_1Q2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCF_1Q2.TagName = "CMD_FECHAR1Q2";
			this.xCF_1Q2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xCF_1Q2.EndInit();
			// 
			// xRemota
			// 
			this.xRemota.BeginInit();
			this.xRemota.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRemota.IsOnlyInput = true;
			this.xRemota.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRemota.Name = "xRemota";
			this.xRemota.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRemota.TagName = "FALHA_REMOTA1";
			this.xRemota.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xRemota.EndInit();
			// 
			// fpComandos
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(900D)), ((float)(420D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpComandos";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.titulo,
			this.tRemota,
			this.col1Q1,
			this.n1Q1,
			this.d1Q1,
			this.b1Q1,
			this.e1Q1,
			this.rL_1Q1,
			this.vL_1Q1,
			this.rP_1Q1,
			this.vP_1Q1,
			this.rC_1Q1,
			this.vC_1Q1,
			this.rSF_1Q1,
			this.vSF_1Q1,
			this.c1Q1,
			this.btnAbrir1Q1,
			this.btnFechar1Q1,
			this.m1Q1,
			this.col1Q0,
			this.n1Q0,
			this.d1Q0,
			this.b1Q0,
			this.e1Q0,
			this.rL_1Q0,
			this.vL_1Q0,
			this.rP_1Q0,
			this.vP_1Q0,
			this.rC_1Q0,
			this.vC_1Q0,
			this.rSF_1Q0,
			this.vSF_1Q0,
			this.c1Q0,
			this.btnAbrir1Q0,
			this.btnFechar1Q0,
			this.m1Q0,
			this.col1Q2,
			this.n1Q2,
			this.d1Q2,
			this.b1Q2,
			this.e1Q2,
			this.rL_1Q2,
			this.vL_1Q2,
			this.rP_1Q2,
			this.vP_1Q2,
			this.rC_1Q2,
			this.vC_1Q2,
			this.rSF_1Q2,
			this.vSF_1Q2,
			this.c1Q2,
			this.btnAbrir1Q2,
			this.btnFechar1Q2,
			this.m1Q2,
			this.confFundo,
			this.confTexto,
			this.btnConfirmar,
			this.btnCancelar,
			this.xL_1Q1,
			this.xR_1Q1,
			this.xP_1Q1,
			this.xC_1Q1,
			this.xSF_1Q1,
			this.xE_1Q1,
			this.xPA_1Q1,
			this.xPF_1Q1,
			this.xCA_1Q1,
			this.xCF_1Q1,
			this.xL_1Q0,
			this.xR_1Q0,
			this.xP_1Q0,
			this.xC_1Q0,
			this.xSF_1Q0,
			this.xE_1Q0,
			this.xPA_1Q0,
			this.xPF_1Q0,
			this.xCA_1Q0,
			this.xCF_1Q0,
			this.xL_1Q2,
			this.xR_1Q2,
			this.xP_1Q2,
			this.xC_1Q2,
			this.xSF_1Q2,
			this.xE_1Q2,
			this.xPA_1Q2,
			this.xPF_1Q2,
			this.xCA_1Q2,
			this.xCF_1Q2,
			this.xRemota});
			this.Size = new System.Drawing.Size(900, 420);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText tRemota;
		private NxtControl.GuiFramework.Rectangle col1Q1;
		private NxtControl.GuiFramework.FreeText n1Q1;
		private NxtControl.GuiFramework.FreeText d1Q1;
		private NxtControl.GuiFramework.Rectangle b1Q1;
		private NxtControl.GuiFramework.FreeText e1Q1;
		private NxtControl.GuiFramework.FreeText rL_1Q1;
		private NxtControl.GuiFramework.FreeText vL_1Q1;
		private NxtControl.GuiFramework.FreeText rP_1Q1;
		private NxtControl.GuiFramework.FreeText vP_1Q1;
		private NxtControl.GuiFramework.FreeText rC_1Q1;
		private NxtControl.GuiFramework.FreeText vC_1Q1;
		private NxtControl.GuiFramework.FreeText rSF_1Q1;
		private NxtControl.GuiFramework.FreeText vSF_1Q1;
		private NxtControl.GuiFramework.FreeText c1Q1;
		private NxtControl.GuiFramework.DrawnButton btnAbrir1Q1;
		private NxtControl.GuiFramework.DrawnButton btnFechar1Q1;
		private NxtControl.GuiFramework.FreeText m1Q1;
		private NxtControl.GuiFramework.Rectangle col1Q0;
		private NxtControl.GuiFramework.FreeText n1Q0;
		private NxtControl.GuiFramework.FreeText d1Q0;
		private NxtControl.GuiFramework.Rectangle b1Q0;
		private NxtControl.GuiFramework.FreeText e1Q0;
		private NxtControl.GuiFramework.FreeText rL_1Q0;
		private NxtControl.GuiFramework.FreeText vL_1Q0;
		private NxtControl.GuiFramework.FreeText rP_1Q0;
		private NxtControl.GuiFramework.FreeText vP_1Q0;
		private NxtControl.GuiFramework.FreeText rC_1Q0;
		private NxtControl.GuiFramework.FreeText vC_1Q0;
		private NxtControl.GuiFramework.FreeText rSF_1Q0;
		private NxtControl.GuiFramework.FreeText vSF_1Q0;
		private NxtControl.GuiFramework.FreeText c1Q0;
		private NxtControl.GuiFramework.DrawnButton btnAbrir1Q0;
		private NxtControl.GuiFramework.DrawnButton btnFechar1Q0;
		private NxtControl.GuiFramework.FreeText m1Q0;
		private NxtControl.GuiFramework.Rectangle col1Q2;
		private NxtControl.GuiFramework.FreeText n1Q2;
		private NxtControl.GuiFramework.FreeText d1Q2;
		private NxtControl.GuiFramework.Rectangle b1Q2;
		private NxtControl.GuiFramework.FreeText e1Q2;
		private NxtControl.GuiFramework.FreeText rL_1Q2;
		private NxtControl.GuiFramework.FreeText vL_1Q2;
		private NxtControl.GuiFramework.FreeText rP_1Q2;
		private NxtControl.GuiFramework.FreeText vP_1Q2;
		private NxtControl.GuiFramework.FreeText rC_1Q2;
		private NxtControl.GuiFramework.FreeText vC_1Q2;
		private NxtControl.GuiFramework.FreeText rSF_1Q2;
		private NxtControl.GuiFramework.FreeText vSF_1Q2;
		private NxtControl.GuiFramework.FreeText c1Q2;
		private NxtControl.GuiFramework.DrawnButton btnAbrir1Q2;
		private NxtControl.GuiFramework.DrawnButton btnFechar1Q2;
		private NxtControl.GuiFramework.FreeText m1Q2;
		private NxtControl.GuiFramework.Rectangle confFundo;
		private NxtControl.GuiFramework.FreeText confTexto;
		private NxtControl.GuiFramework.DrawnButton btnConfirmar;
		private NxtControl.GuiFramework.DrawnButton btnCancelar;
		private System.HMI.Symbols.Base.Execute<bool> xL_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xR_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xP_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xC_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xSF_1Q1;
		private System.HMI.Symbols.Base.Execute<short> xE_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xPA_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xPF_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xCA_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xCF_1Q1;
		private System.HMI.Symbols.Base.Execute<bool> xL_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xR_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xP_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xC_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xSF_1Q0;
		private System.HMI.Symbols.Base.Execute<short> xE_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xPA_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xPF_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xCA_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xCF_1Q0;
		private System.HMI.Symbols.Base.Execute<bool> xL_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xR_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xP_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xC_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xSF_1Q2;
		private System.HMI.Symbols.Base.Execute<short> xE_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xPA_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xPF_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xCA_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xCF_1Q2;
		private System.HMI.Symbols.Base.Execute<bool> xRemota;
		#endregion
	}
}
