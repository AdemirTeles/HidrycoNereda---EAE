/*
 * Hidryco - tela MGES (multimedidores de todos os paineis)
 * ISA-101: um cartao por MGE com o simbolo do MGE_Generico (abre o faceplate).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for MGES.
	/// </summary>
	partial class MGES
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.cardMGE_AGUA_REUSO = new NxtControl.GuiFramework.Rectangle();
			this.tMGE_AGUA_REUSO = new NxtControl.GuiFramework.FreeText();
			this.sMGE_AGUA_REUSO = new NxtControl.GuiFramework.FreeText();
			this.mgeMGE_AGUA_REUSO = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
			this.cardMGE_QGBT_220V = new NxtControl.GuiFramework.Rectangle();
			this.tMGE_QGBT_220V = new NxtControl.GuiFramework.FreeText();
			this.sMGE_QGBT_220V = new NxtControl.GuiFramework.FreeText();
			this.mgeMGE_QGBT_220V = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
			this.cardMGE_NEREDA = new NxtControl.GuiFramework.Rectangle();
			this.tMGE_NEREDA = new NxtControl.GuiFramework.FreeText();
			this.sMGE_NEREDA = new NxtControl.GuiFramework.FreeText();
			this.mgeMGE_NEREDA = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
			this.cardMGE_EEE_BRUTO = new NxtControl.GuiFramework.Rectangle();
			this.tMGE_EEE_BRUTO = new NxtControl.GuiFramework.FreeText();
			this.sMGE_EEE_BRUTO = new NxtControl.GuiFramework.FreeText();
			this.mgeMGE_EEE_BRUTO = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
			this.cardMGE_LODO = new NxtControl.GuiFramework.Rectangle();
			this.tMGE_LODO = new NxtControl.GuiFramework.FreeText();
			this.sMGE_LODO = new NxtControl.GuiFramework.FreeText();
			this.mgeMGE_LODO = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
			this.cardMGE_DESINFECCAO = new NxtControl.GuiFramework.Rectangle();
			this.tMGE_DESINFECCAO = new NxtControl.GuiFramework.FreeText();
			this.sMGE_DESINFECCAO = new NxtControl.GuiFramework.FreeText();
			this.mgeMGE_DESINFECCAO = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(226)), ((byte)(228)), ((byte)(230))));
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cardMGE_AGUA_REUSO
			// 
			this.cardMGE_AGUA_REUSO.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(14D)), ((float)(436D)), ((float)(326D)));
			this.cardMGE_AGUA_REUSO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardMGE_AGUA_REUSO.Name = "cardMGE_AGUA_REUSO";
			this.cardMGE_AGUA_REUSO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tMGE_AGUA_REUSO
			// 
			this.tMGE_AGUA_REUSO.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.tMGE_AGUA_REUSO.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tMGE_AGUA_REUSO.Location = new NxtControl.Drawing.PointF(28D, 28D);
			this.tMGE_AGUA_REUSO.Name = "tMGE_AGUA_REUSO";
			this.tMGE_AGUA_REUSO.Text = "PCM ÁGUA DE REÚSO";
			// 
			// sMGE_AGUA_REUSO
			// 
			this.sMGE_AGUA_REUSO.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.sMGE_AGUA_REUSO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.sMGE_AGUA_REUSO.Location = new NxtControl.Drawing.PointF(28D, 50D);
			this.sMGE_AGUA_REUSO.Name = "sMGE_AGUA_REUSO";
			this.sMGE_AGUA_REUSO.Text = "10.26.208.190  -  M262_Substacao";
			// 
			// mgeMGE_AGUA_REUSO
			// 
			this.mgeMGE_AGUA_REUSO.BeginInit();
			this.mgeMGE_AGUA_REUSO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 105D, 134D);
			this.mgeMGE_AGUA_REUSO.Name = "mgeMGE_AGUA_REUSO";
			this.mgeMGE_AGUA_REUSO.SecurityToken = ((uint)(4294967295u));
			this.mgeMGE_AGUA_REUSO.TagName = "FB91426C191C180F";
			this.mgeMGE_AGUA_REUSO.EndInit();
			// 
			// cardMGE_QGBT_220V
			// 
			this.cardMGE_QGBT_220V.Bounds = new NxtControl.Drawing.RectF(((float)(461D)), ((float)(14D)), ((float)(436D)), ((float)(326D)));
			this.cardMGE_QGBT_220V.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardMGE_QGBT_220V.Name = "cardMGE_QGBT_220V";
			this.cardMGE_QGBT_220V.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tMGE_QGBT_220V
			// 
			this.tMGE_QGBT_220V.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.tMGE_QGBT_220V.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tMGE_QGBT_220V.Location = new NxtControl.Drawing.PointF(477D, 28D);
			this.tMGE_QGBT_220V.Name = "tMGE_QGBT_220V";
			this.tMGE_QGBT_220V.Text = "QGBT 220 V";
			// 
			// sMGE_QGBT_220V
			// 
			this.sMGE_QGBT_220V.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.sMGE_QGBT_220V.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.sMGE_QGBT_220V.Location = new NxtControl.Drawing.PointF(477D, 50D);
			this.sMGE_QGBT_220V.Name = "sMGE_QGBT_220V";
			this.sMGE_QGBT_220V.Text = "10.26.208.191  -  M262_Substacao";
			// 
			// mgeMGE_QGBT_220V
			// 
			this.mgeMGE_QGBT_220V.BeginInit();
			this.mgeMGE_QGBT_220V.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 554D, 134D);
			this.mgeMGE_QGBT_220V.Name = "mgeMGE_QGBT_220V";
			this.mgeMGE_QGBT_220V.SecurityToken = ((uint)(4294967295u));
			this.mgeMGE_QGBT_220V.TagName = "69674224C985914B";
			this.mgeMGE_QGBT_220V.EndInit();
			// 
			// cardMGE_NEREDA
			// 
			this.cardMGE_NEREDA.Bounds = new NxtControl.Drawing.RectF(((float)(910D)), ((float)(14D)), ((float)(436D)), ((float)(326D)));
			this.cardMGE_NEREDA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardMGE_NEREDA.Name = "cardMGE_NEREDA";
			this.cardMGE_NEREDA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tMGE_NEREDA
			// 
			this.tMGE_NEREDA.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.tMGE_NEREDA.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tMGE_NEREDA.Location = new NxtControl.Drawing.PointF(926D, 28D);
			this.tMGE_NEREDA.Name = "tMGE_NEREDA";
			this.tMGE_NEREDA.Text = "PCM NEREDA";
			// 
			// sMGE_NEREDA
			// 
			this.sMGE_NEREDA.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.sMGE_NEREDA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.sMGE_NEREDA.Location = new NxtControl.Drawing.PointF(926D, 50D);
			this.sMGE_NEREDA.Name = "sMGE_NEREDA";
			this.sMGE_NEREDA.Text = "10.26.208.143  -  M262_Nereda";
			// 
			// mgeMGE_NEREDA
			// 
			this.mgeMGE_NEREDA.BeginInit();
			this.mgeMGE_NEREDA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1003D, 134D);
			this.mgeMGE_NEREDA.Name = "mgeMGE_NEREDA";
			this.mgeMGE_NEREDA.SecurityToken = ((uint)(4294967295u));
			this.mgeMGE_NEREDA.TagName = "42A72BAA64FBD5CF";
			this.mgeMGE_NEREDA.EndInit();
			// 
			// cardMGE_EEE_BRUTO
			// 
			this.cardMGE_EEE_BRUTO.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(358D)), ((float)(436D)), ((float)(326D)));
			this.cardMGE_EEE_BRUTO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardMGE_EEE_BRUTO.Name = "cardMGE_EEE_BRUTO";
			this.cardMGE_EEE_BRUTO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tMGE_EEE_BRUTO
			// 
			this.tMGE_EEE_BRUTO.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.tMGE_EEE_BRUTO.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tMGE_EEE_BRUTO.Location = new NxtControl.Drawing.PointF(28D, 372D);
			this.tMGE_EEE_BRUTO.Name = "tMGE_EEE_BRUTO";
			this.tMGE_EEE_BRUTO.Text = "PCM EEE BRUTO";
			// 
			// sMGE_EEE_BRUTO
			// 
			this.sMGE_EEE_BRUTO.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.sMGE_EEE_BRUTO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.sMGE_EEE_BRUTO.Location = new NxtControl.Drawing.PointF(28D, 394D);
			this.sMGE_EEE_BRUTO.Name = "sMGE_EEE_BRUTO";
			this.sMGE_EEE_BRUTO.Text = "10.26.208.199  -  M262_Nereda";
			// 
			// mgeMGE_EEE_BRUTO
			// 
			this.mgeMGE_EEE_BRUTO.BeginInit();
			this.mgeMGE_EEE_BRUTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 105D, 478D);
			this.mgeMGE_EEE_BRUTO.Name = "mgeMGE_EEE_BRUTO";
			this.mgeMGE_EEE_BRUTO.SecurityToken = ((uint)(4294967295u));
			this.mgeMGE_EEE_BRUTO.TagName = "C2BC31C40971AFC7";
			this.mgeMGE_EEE_BRUTO.EndInit();
			// 
			// cardMGE_LODO
			// 
			this.cardMGE_LODO.Bounds = new NxtControl.Drawing.RectF(((float)(461D)), ((float)(358D)), ((float)(436D)), ((float)(326D)));
			this.cardMGE_LODO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardMGE_LODO.Name = "cardMGE_LODO";
			this.cardMGE_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tMGE_LODO
			// 
			this.tMGE_LODO.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.tMGE_LODO.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tMGE_LODO.Location = new NxtControl.Drawing.PointF(477D, 372D);
			this.tMGE_LODO.Name = "tMGE_LODO";
			this.tMGE_LODO.Text = "PCM LODO";
			// 
			// sMGE_LODO
			// 
			this.sMGE_LODO.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.sMGE_LODO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.sMGE_LODO.Location = new NxtControl.Drawing.PointF(477D, 394D);
			this.sMGE_LODO.Name = "sMGE_LODO";
			this.sMGE_LODO.Text = "10.26.208.246  -  M262_Lodo";
			// 
			// mgeMGE_LODO
			// 
			this.mgeMGE_LODO.BeginInit();
			this.mgeMGE_LODO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 554D, 478D);
			this.mgeMGE_LODO.Name = "mgeMGE_LODO";
			this.mgeMGE_LODO.SecurityToken = ((uint)(4294967295u));
			this.mgeMGE_LODO.TagName = "08552AC023670BDF";
			this.mgeMGE_LODO.EndInit();
			// 
			// cardMGE_DESINFECCAO
			// 
			this.cardMGE_DESINFECCAO.Bounds = new NxtControl.Drawing.RectF(((float)(910D)), ((float)(358D)), ((float)(436D)), ((float)(326D)));
			this.cardMGE_DESINFECCAO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(241)), ((byte)(242))));
			this.cardMGE_DESINFECCAO.Name = "cardMGE_DESINFECCAO";
			this.cardMGE_DESINFECCAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(206)), ((byte)(209))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tMGE_DESINFECCAO
			// 
			this.tMGE_DESINFECCAO.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.tMGE_DESINFECCAO.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tMGE_DESINFECCAO.Location = new NxtControl.Drawing.PointF(926D, 372D);
			this.tMGE_DESINFECCAO.Name = "tMGE_DESINFECCAO";
			this.tMGE_DESINFECCAO.Text = "PCE DESINFECÇÃO";
			// 
			// sMGE_DESINFECCAO
			// 
			this.sMGE_DESINFECCAO.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(100)), ((byte)(104)));
			this.sMGE_DESINFECCAO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.sMGE_DESINFECCAO.Location = new NxtControl.Drawing.PointF(926D, 394D);
			this.sMGE_DESINFECCAO.Name = "sMGE_DESINFECCAO";
			this.sMGE_DESINFECCAO.Text = "10.26.208.139  -  M262_Lodo";
			// 
			// mgeMGE_DESINFECCAO
			// 
			this.mgeMGE_DESINFECCAO.BeginInit();
			this.mgeMGE_DESINFECCAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1003D, 478D);
			this.mgeMGE_DESINFECCAO.Name = "mgeMGE_DESINFECCAO";
			this.mgeMGE_DESINFECCAO.SecurityToken = ((uint)(4294967295u));
			this.mgeMGE_DESINFECCAO.TagName = "037A106217874CC9";
			this.mgeMGE_DESINFECCAO.EndInit();
			// 
			// MGES
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Name = "MGES";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardMGE_AGUA_REUSO,
			this.tMGE_AGUA_REUSO,
			this.sMGE_AGUA_REUSO,
			this.mgeMGE_AGUA_REUSO,
			this.cardMGE_QGBT_220V,
			this.tMGE_QGBT_220V,
			this.sMGE_QGBT_220V,
			this.mgeMGE_QGBT_220V,
			this.cardMGE_NEREDA,
			this.tMGE_NEREDA,
			this.sMGE_NEREDA,
			this.mgeMGE_NEREDA,
			this.cardMGE_EEE_BRUTO,
			this.tMGE_EEE_BRUTO,
			this.sMGE_EEE_BRUTO,
			this.mgeMGE_EEE_BRUTO,
			this.cardMGE_LODO,
			this.tMGE_LODO,
			this.sMGE_LODO,
			this.mgeMGE_LODO,
			this.cardMGE_DESINFECCAO,
			this.tMGE_DESINFECCAO,
			this.sMGE_DESINFECCAO,
			this.mgeMGE_DESINFECCAO});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardMGE_AGUA_REUSO;
		private NxtControl.GuiFramework.FreeText tMGE_AGUA_REUSO;
		private NxtControl.GuiFramework.FreeText sMGE_AGUA_REUSO;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mgeMGE_AGUA_REUSO;
		private NxtControl.GuiFramework.Rectangle cardMGE_QGBT_220V;
		private NxtControl.GuiFramework.FreeText tMGE_QGBT_220V;
		private NxtControl.GuiFramework.FreeText sMGE_QGBT_220V;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mgeMGE_QGBT_220V;
		private NxtControl.GuiFramework.Rectangle cardMGE_NEREDA;
		private NxtControl.GuiFramework.FreeText tMGE_NEREDA;
		private NxtControl.GuiFramework.FreeText sMGE_NEREDA;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mgeMGE_NEREDA;
		private NxtControl.GuiFramework.Rectangle cardMGE_EEE_BRUTO;
		private NxtControl.GuiFramework.FreeText tMGE_EEE_BRUTO;
		private NxtControl.GuiFramework.FreeText sMGE_EEE_BRUTO;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mgeMGE_EEE_BRUTO;
		private NxtControl.GuiFramework.Rectangle cardMGE_LODO;
		private NxtControl.GuiFramework.FreeText tMGE_LODO;
		private NxtControl.GuiFramework.FreeText sMGE_LODO;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mgeMGE_LODO;
		private NxtControl.GuiFramework.Rectangle cardMGE_DESINFECCAO;
		private NxtControl.GuiFramework.FreeText tMGE_DESINFECCAO;
		private NxtControl.GuiFramework.FreeText sMGE_DESINFECCAO;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mgeMGE_DESINFECCAO;
		#endregion
	}
}
