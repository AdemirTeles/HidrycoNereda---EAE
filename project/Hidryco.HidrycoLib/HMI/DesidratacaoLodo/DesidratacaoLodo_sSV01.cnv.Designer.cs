/*
 * Hidryco - DesidratacaoLodo - sSV01
 * ISA-101: solenoide SV-01 (corpo cheio = aberta, vazio = fechada); clique abre o faceplate da fase solida.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.DesidratacaoLodo
{
	/// <summary>
	/// Summary description for sSV01.
	/// </summary>
	partial class sSV01
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.haste = new NxtControl.GuiFramework.Rectangle();
			this.caixaS = new NxtControl.GuiFramework.Rectangle();
			this.tS = new NxtControl.GuiFramework.FreeText();
			this.corpoE = new NxtControl.GuiFramework.Polygon();
			this.corpoD = new NxtControl.GuiFramework.Polygon();
			this.xSV = new System.HMI.Symbols.Base.Execute<short>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(50D)), ((float)(52D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// haste
			// 
			this.haste.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(25D)), ((float)(12D)), ((float)(2D)));
			this.haste.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.haste.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.haste.Name = "haste";
			this.haste.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaS
			// 
			this.caixaS.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(17D)), ((float)(16D)), ((float)(18D)));
			this.caixaS.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(230)), ((byte)(230))));
			this.caixaS.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaS.Name = "caixaS";
			this.caixaS.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tS
			// 
			this.tS.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.tS.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tS.Location = new NxtControl.Drawing.PointF(35D, 18D);
			this.tS.Name = "tS";
			this.tS.Text = "S";
			// 
			// corpoE
			// 
			this.corpoE.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(4D)), ((float)(28D)), ((float)(22D)));
			this.corpoE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.corpoE.Closed = true;
			this.corpoE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpoE.Name = "corpoE";
			this.corpoE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.corpoE.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(6D, 4D),
			new NxtControl.Drawing.PointF(34D, 4D),
			new NxtControl.Drawing.PointF(20D, 26D)});
			// 
			// corpoD
			// 
			this.corpoD.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(26D)), ((float)(28D)), ((float)(22D)));
			this.corpoD.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.corpoD.Closed = true;
			this.corpoD.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpoD.Name = "corpoD";
			this.corpoD.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.corpoD.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(6D, 48D),
			new NxtControl.Drawing.PointF(34D, 48D),
			new NxtControl.Drawing.PointF(20D, 26D)});
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
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(50D)), ((float)(52D)));
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
			// sSV01
			// 
			this.Name = "sSV01";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.haste,
			this.caixaS,
			this.tS,
			this.corpoE,
			this.corpoD,
			this.xSV,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(50, 52);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle haste;
		private NxtControl.GuiFramework.Rectangle caixaS;
		private NxtControl.GuiFramework.FreeText tS;
		private NxtControl.GuiFramework.Polygon corpoE;
		private NxtControl.GuiFramework.Polygon corpoD;
		private System.HMI.Symbols.Base.Execute<short> xSV;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
