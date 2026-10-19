/*
 * Hidryco - UV_Trojan - fpDetalhes
 * UV: falhas ativas decodificadas (sistema, bancos 1A/2A, limpeza).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UV_Trojan
{
	/// <summary>
	/// Summary description for fpDetalhes.
	/// </summary>
	partial class fpDetalhes
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.tSis = new NxtControl.GuiFramework.FreeText();
			this.tSisv = new NxtControl.GuiFramework.FreeText();
			this.tB1 = new NxtControl.GuiFramework.FreeText();
			this.tB1v = new NxtControl.GuiFramework.FreeText();
			this.tB2 = new NxtControl.GuiFramework.FreeText();
			this.tB2v = new NxtControl.GuiFramework.FreeText();
			this.tLim = new NxtControl.GuiFramework.FreeText();
			this.tLimv = new NxtControl.GuiFramework.FreeText();
			this.xSYS3 = new System.HMI.Symbols.Base.Execute<short>();
			this.xSYS4 = new System.HMI.Symbols.Base.Execute<short>();
			this.xC1W33 = new System.HMI.Symbols.Base.Execute<short>();
			this.xC1W34 = new System.HMI.Symbols.Base.Execute<short>();
			this.xC2W33 = new System.HMI.Symbols.Base.Execute<short>();
			this.xC2W34 = new System.HMI.Symbols.Base.Execute<short>();
			this.xL83 = new System.HMI.Symbols.Base.Execute<short>();
			this.xL85 = new System.HMI.Symbols.Base.Execute<short>();
			this.xL86 = new System.HMI.Symbols.Base.Execute<short>();
			this.xL89 = new System.HMI.Symbols.Base.Execute<short>();
			this.xL90 = new System.HMI.Symbols.Base.Execute<short>();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(420D)), ((float)(36D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 10D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Falhas ativas no painel UV";
			// 
			// tSis
			// 
			this.tSis.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tSis.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tSis.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.tSis.Name = "tSis";
			this.tSis.Text = "Sistema";
			// 
			// tSisv
			// 
			this.tSisv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tSisv.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tSisv.Location = new NxtControl.Drawing.PointF(20D, 70D);
			this.tSisv.Name = "tSisv";
			this.tSisv.Text = "";
			// 
			// tB1
			// 
			this.tB1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tB1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tB1.Location = new NxtControl.Drawing.PointF(20D, 140D);
			this.tB1.Name = "tB1";
			this.tB1.Text = "Banco 1A (canal 1)";
			// 
			// tB1v
			// 
			this.tB1v.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tB1v.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tB1v.Location = new NxtControl.Drawing.PointF(20D, 162D);
			this.tB1v.Name = "tB1v";
			this.tB1v.Text = "";
			// 
			// tB2
			// 
			this.tB2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tB2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tB2.Location = new NxtControl.Drawing.PointF(20D, 232D);
			this.tB2.Name = "tB2";
			this.tB2.Text = "Banco 2A (canal 2)";
			// 
			// tB2v
			// 
			this.tB2v.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tB2v.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tB2v.Location = new NxtControl.Drawing.PointF(20D, 254D);
			this.tB2v.Name = "tB2v";
			this.tB2v.Text = "";
			// 
			// tLim
			// 
			this.tLim.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tLim.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tLim.Location = new NxtControl.Drawing.PointF(20D, 324D);
			this.tLim.Name = "tLim";
			this.tLim.Text = "Limpeza";
			// 
			// tLimv
			// 
			this.tLimv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tLimv.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.tLimv.Location = new NxtControl.Drawing.PointF(20D, 346D);
			this.tLimv.Name = "tLimv";
			this.tLimv.Text = "";
			// 
			// xSYS3
			// 
			this.xSYS3.BeginInit();
			this.xSYS3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSYS3.IsOnlyInput = true;
			this.xSYS3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSYS3.Name = "xSYS3";
			this.xSYS3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSYS3.TagName = "STS_SYS_W1003";
			this.xSYS3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSYS3ValueChanged);
			this.xSYS3.EndInit();
			// 
			// xSYS4
			// 
			this.xSYS4.BeginInit();
			this.xSYS4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSYS4.IsOnlyInput = true;
			this.xSYS4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSYS4.Name = "xSYS4";
			this.xSYS4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSYS4.TagName = "STS_SYS_W1004";
			this.xSYS4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSYS4ValueChanged);
			this.xSYS4.EndInit();
			// 
			// xC1W33
			// 
			this.xC1W33.BeginInit();
			this.xC1W33.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1W33.IsOnlyInput = true;
			this.xC1W33.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1W33.Name = "xC1W33";
			this.xC1W33.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1W33.TagName = "STS_CH1_W33";
			this.xC1W33.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1W33ValueChanged);
			this.xC1W33.EndInit();
			// 
			// xC1W34
			// 
			this.xC1W34.BeginInit();
			this.xC1W34.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1W34.IsOnlyInput = true;
			this.xC1W34.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1W34.Name = "xC1W34";
			this.xC1W34.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1W34.TagName = "STS_CH1_W34";
			this.xC1W34.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1W34ValueChanged);
			this.xC1W34.EndInit();
			// 
			// xC2W33
			// 
			this.xC2W33.BeginInit();
			this.xC2W33.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2W33.IsOnlyInput = true;
			this.xC2W33.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2W33.Name = "xC2W33";
			this.xC2W33.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2W33.TagName = "STS_CH2_W33";
			this.xC2W33.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2W33ValueChanged);
			this.xC2W33.EndInit();
			// 
			// xC2W34
			// 
			this.xC2W34.BeginInit();
			this.xC2W34.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2W34.IsOnlyInput = true;
			this.xC2W34.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2W34.Name = "xC2W34";
			this.xC2W34.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2W34.TagName = "STS_CH2_W34";
			this.xC2W34.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2W34ValueChanged);
			this.xC2W34.EndInit();
			// 
			// xL83
			// 
			this.xL83.BeginInit();
			this.xL83.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL83.IsOnlyInput = true;
			this.xL83.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL83.Name = "xL83";
			this.xL83.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL83.TagName = "STS_LIMP_W1183";
			this.xL83.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XL83ValueChanged);
			this.xL83.EndInit();
			// 
			// xL85
			// 
			this.xL85.BeginInit();
			this.xL85.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL85.IsOnlyInput = true;
			this.xL85.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL85.Name = "xL85";
			this.xL85.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL85.TagName = "STS_LIMP_W1185";
			this.xL85.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XL85ValueChanged);
			this.xL85.EndInit();
			// 
			// xL86
			// 
			this.xL86.BeginInit();
			this.xL86.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL86.IsOnlyInput = true;
			this.xL86.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL86.Name = "xL86";
			this.xL86.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL86.TagName = "STS_LIMP_W1186";
			this.xL86.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XL86ValueChanged);
			this.xL86.EndInit();
			// 
			// xL89
			// 
			this.xL89.BeginInit();
			this.xL89.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL89.IsOnlyInput = true;
			this.xL89.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL89.Name = "xL89";
			this.xL89.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL89.TagName = "STS_LIMP_W1189";
			this.xL89.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XL89ValueChanged);
			this.xL89.EndInit();
			// 
			// xL90
			// 
			this.xL90.BeginInit();
			this.xL90.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xL90.IsOnlyInput = true;
			this.xL90.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xL90.Name = "xL90";
			this.xL90.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xL90.TagName = "STS_LIMP_W1190";
			this.xL90.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XL90ValueChanged);
			this.xL90.EndInit();
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
			// fpDetalhes
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(420D)), ((float)(470D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.titulo,
			this.tSis,
			this.tSisv,
			this.tB1,
			this.tB1v,
			this.tB2,
			this.tB2v,
			this.tLim,
			this.tLimv,
			this.xSYS3,
			this.xSYS4,
			this.xC1W33,
			this.xC1W34,
			this.xC2W33,
			this.xC2W34,
			this.xL83,
			this.xL85,
			this.xL86,
			this.xL89,
			this.xL90,
			this.xFCOM});
			this.Size = new System.Drawing.Size(420, 470);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText tSis;
		private NxtControl.GuiFramework.FreeText tSisv;
		private NxtControl.GuiFramework.FreeText tB1;
		private NxtControl.GuiFramework.FreeText tB1v;
		private NxtControl.GuiFramework.FreeText tB2;
		private NxtControl.GuiFramework.FreeText tB2v;
		private NxtControl.GuiFramework.FreeText tLim;
		private NxtControl.GuiFramework.FreeText tLimv;
		private System.HMI.Symbols.Base.Execute<short> xSYS3;
		private System.HMI.Symbols.Base.Execute<short> xSYS4;
		private System.HMI.Symbols.Base.Execute<short> xC1W33;
		private System.HMI.Symbols.Base.Execute<short> xC1W34;
		private System.HMI.Symbols.Base.Execute<short> xC2W33;
		private System.HMI.Symbols.Base.Execute<short> xC2W34;
		private System.HMI.Symbols.Base.Execute<short> xL83;
		private System.HMI.Symbols.Base.Execute<short> xL85;
		private System.HMI.Symbols.Base.Execute<short> xL86;
		private System.HMI.Symbols.Base.Execute<short> xL89;
		private System.HMI.Symbols.Base.Execute<short> xL90;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		#endregion
	}
}
