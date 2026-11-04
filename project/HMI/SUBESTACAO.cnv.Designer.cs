/*
 * Hidryco - tela SUBESTACAO (unifilar QGBT 440 V e geradores)
 * ISA-101: o unifilar e o simbolo do CAT Subestacao (disjuntores, barras, GMG G1/G2).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for SUBESTACAO.
	/// </summary>
	partial class SUBESTACAO
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnResetGeral = new NxtControl.GuiFramework.DrawnButton();
			this.btnReconhecerGeral = new NxtControl.GuiFramework.DrawnButton();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.unifilar = new Hidryco.HidrycoLib.Symbols.Subestacao.sDefault();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// unifilar
			// 
			this.unifilar.BeginInit();
			this.unifilar.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.unifilar.Name = "unifilar";
			this.unifilar.SecurityToken = ((uint)(4294967295u));
			this.unifilar.TagName = "50EC4DF6BD818E0D";
			this.unifilar.EndInit();
			// 
			// SUBESTACAO
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "SUBESTACAO";
			// 
			// btnResetGeral
			// 
			this.btnResetGeral.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(662D)), ((float)(126D)), ((float)(30D)));
			this.btnResetGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnResetGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnResetGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnResetGeral.Name = "btnResetGeral";
			this.btnResetGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnResetGeral.Radius = 2D;
			this.btnResetGeral.Text = "Reset geral";
			this.btnResetGeral.Use3DEffect = false;
			this.btnResetGeral.Click += new System.EventHandler(this.BtnResetGeralClick);
			// 
			// btnReconhecerGeral
			// 
			this.btnReconhecerGeral.Bounds = new NxtControl.Drawing.RectF(((float)(138D)), ((float)(662D)), ((float)(150D)), ((float)(30D)));
			this.btnReconhecerGeral.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReconhecerGeral.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnReconhecerGeral.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReconhecerGeral.Name = "btnReconhecerGeral";
			this.btnReconhecerGeral.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReconhecerGeral.Radius = 2D;
			this.btnReconhecerGeral.Text = "Reconhecer geral";
			this.btnReconhecerGeral.Use3DEffect = false;
			this.btnReconhecerGeral.Click += new System.EventHandler(this.BtnReconhecerGeralClick);
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.unifilar,
			this.btnResetGeral,
			this.btnReconhecerGeral});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private Hidryco.HidrycoLib.Symbols.Subestacao.sDefault unifilar;
		private NxtControl.GuiFramework.DrawnButton btnResetGeral;
		private NxtControl.GuiFramework.DrawnButton btnReconhecerGeral;
		#endregion
	}
}
