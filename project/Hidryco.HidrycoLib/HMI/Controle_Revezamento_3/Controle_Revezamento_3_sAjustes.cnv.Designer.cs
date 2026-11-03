/*
 * Hidryco - Controle_Revezamento_3 - sAjustes
 * Painel de ajustes (Revezamento) para o faceplate do processo; rotulos por propriedade.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_3
{
	/// <summary>
	/// Summary description for sAjustes.
	/// </summary>
	partial class sAjustes
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.l_CMD_HABILITA = new NxtControl.GuiFramework.FreeText();
			this.c_CMD_HABILITA = new System.HMI.Symbols.Base.CheckButton();
			this.l_STP_TEMPO_B1 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_TEMPO_B1 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.l_STP_TEMPO_B2 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_TEMPO_B2 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.l_STP_TEMPO_B3 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_TEMPO_B3 = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.l_CMD_SELECAO_BOMBA = new NxtControl.GuiFramework.FreeText();
			this.b_sel0 = new NxtControl.GuiFramework.DrawnButton();
			this.b_sel1 = new NxtControl.GuiFramework.DrawnButton();
			this.b_sel2 = new NxtControl.GuiFramework.DrawnButton();
			this.b_sel3 = new NxtControl.GuiFramework.DrawnButton();
			this.x_SEL = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(430D)), ((float)(216D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(430D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(0D, 8D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Revezamento";
			// 
			// l_CMD_HABILITA
			// 
			this.l_CMD_HABILITA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_CMD_HABILITA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_CMD_HABILITA.Location = new NxtControl.Drawing.PointF(10D, 46D);
			this.l_CMD_HABILITA.Name = "l_CMD_HABILITA";
			this.l_CMD_HABILITA.Text = "Troca da principal por tempo";
			// 
			// c_CMD_HABILITA
			// 
			this.c_CMD_HABILITA.BeginInit();
			this.c_CMD_HABILITA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 310D, 40D);
			this.c_CMD_HABILITA.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_HABILITA.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_HABILITA.FalseText = "Desabilitado";
			this.c_CMD_HABILITA.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_CMD_HABILITA.FontScale = false;
			this.c_CMD_HABILITA.Name = "c_CMD_HABILITA";
			this.c_CMD_HABILITA.TagName = "CMD_HABILITA";
			this.c_CMD_HABILITA.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_HABILITA.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_HABILITA.TrueText = "Habilitado";
			this.c_CMD_HABILITA.Value = false;
			this.c_CMD_HABILITA.EndInit();
			// 
			// l_STP_TEMPO_B1
			// 
			this.l_STP_TEMPO_B1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_TEMPO_B1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_TEMPO_B1.Location = new NxtControl.Drawing.PointF(10D, 80D);
			this.l_STP_TEMPO_B1.Name = "l_STP_TEMPO_B1";
			this.l_STP_TEMPO_B1.Text = "Horas do equipamento 1 como principal";
			// 
			// c_STP_TEMPO_B1
			// 
			this.c_STP_TEMPO_B1.BeginInit();
			this.c_STP_TEMPO_B1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 76D);
			this.c_STP_TEMPO_B1.MaximumTag = null;
			this.c_STP_TEMPO_B1.MinimumTag = null;
			this.c_STP_TEMPO_B1.Name = "c_STP_TEMPO_B1";
			this.c_STP_TEMPO_B1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_TEMPO_B1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_TEMPO_B1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_TEMPO_B1.Suffix = "";
			this.c_STP_TEMPO_B1.TagName = "STP_TEMPO_B1";
			this.c_STP_TEMPO_B1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_TEMPO_B1.UseInputPad = true;
			this.c_STP_TEMPO_B1.Value = ((ushort)(0));
			this.c_STP_TEMPO_B1.EndInit();
			// 
			// l_STP_TEMPO_B2
			// 
			this.l_STP_TEMPO_B2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_TEMPO_B2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_TEMPO_B2.Location = new NxtControl.Drawing.PointF(10D, 114D);
			this.l_STP_TEMPO_B2.Name = "l_STP_TEMPO_B2";
			this.l_STP_TEMPO_B2.Text = "Horas do equipamento 2 como principal";
			// 
			// c_STP_TEMPO_B2
			// 
			this.c_STP_TEMPO_B2.BeginInit();
			this.c_STP_TEMPO_B2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 110D);
			this.c_STP_TEMPO_B2.MaximumTag = null;
			this.c_STP_TEMPO_B2.MinimumTag = null;
			this.c_STP_TEMPO_B2.Name = "c_STP_TEMPO_B2";
			this.c_STP_TEMPO_B2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_TEMPO_B2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_TEMPO_B2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_TEMPO_B2.Suffix = "";
			this.c_STP_TEMPO_B2.TagName = "STP_TEMPO_B2";
			this.c_STP_TEMPO_B2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_TEMPO_B2.UseInputPad = true;
			this.c_STP_TEMPO_B2.Value = ((ushort)(0));
			this.c_STP_TEMPO_B2.EndInit();
			// 
			// l_STP_TEMPO_B3
			// 
			this.l_STP_TEMPO_B3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_TEMPO_B3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_TEMPO_B3.Location = new NxtControl.Drawing.PointF(10D, 148D);
			this.l_STP_TEMPO_B3.Name = "l_STP_TEMPO_B3";
			this.l_STP_TEMPO_B3.Text = "Horas do equipamento 3 como principal";
			// 
			// c_STP_TEMPO_B3
			// 
			this.c_STP_TEMPO_B3.BeginInit();
			this.c_STP_TEMPO_B3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 144D);
			this.c_STP_TEMPO_B3.MaximumTag = null;
			this.c_STP_TEMPO_B3.MinimumTag = null;
			this.c_STP_TEMPO_B3.Name = "c_STP_TEMPO_B3";
			this.c_STP_TEMPO_B3.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_TEMPO_B3.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_TEMPO_B3.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_TEMPO_B3.Suffix = "";
			this.c_STP_TEMPO_B3.TagName = "STP_TEMPO_B3";
			this.c_STP_TEMPO_B3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_TEMPO_B3.UseInputPad = true;
			this.c_STP_TEMPO_B3.Value = ((ushort)(0));
			this.c_STP_TEMPO_B3.EndInit();
			// 
			// l_CMD_SELECAO_BOMBA
			// 
			this.l_CMD_SELECAO_BOMBA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_CMD_SELECAO_BOMBA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_CMD_SELECAO_BOMBA.Location = new NxtControl.Drawing.PointF(10D, 182D);
			this.l_CMD_SELECAO_BOMBA.Name = "l_CMD_SELECAO_BOMBA";
			this.l_CMD_SELECAO_BOMBA.Text = "Bomba principal";
			// 
			// b_sel0
			// 
			this.b_sel0.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(176D)), ((float)(88D)), ((float)(28D)));
			this.b_sel0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.b_sel0.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.b_sel0.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.b_sel0.Name = "b_sel0";
			this.b_sel0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.b_sel0.Radius = 2D;
			this.b_sel0.Text = "Automática";
			this.b_sel0.Use3DEffect = false;
			this.b_sel0.Click += new System.EventHandler(this.BtnSel0Click);
			// 
			// b_sel1
			// 
			this.b_sel1.Bounds = new NxtControl.Drawing.RectF(((float)(234D)), ((float)(176D)), ((float)(60D)), ((float)(28D)));
			this.b_sel1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.b_sel1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.b_sel1.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.b_sel1.Name = "b_sel1";
			this.b_sel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.b_sel1.Radius = 2D;
			this.b_sel1.Text = "1";
			this.b_sel1.Use3DEffect = false;
			this.b_sel1.Click += new System.EventHandler(this.BtnSel1Click);
			// 
			// b_sel2
			// 
			this.b_sel2.Bounds = new NxtControl.Drawing.RectF(((float)(298D)), ((float)(176D)), ((float)(60D)), ((float)(28D)));
			this.b_sel2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.b_sel2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.b_sel2.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.b_sel2.Name = "b_sel2";
			this.b_sel2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.b_sel2.Radius = 2D;
			this.b_sel2.Text = "2";
			this.b_sel2.Use3DEffect = false;
			this.b_sel2.Click += new System.EventHandler(this.BtnSel2Click);
			// 
			// b_sel3
			// 
			this.b_sel3.Bounds = new NxtControl.Drawing.RectF(((float)(362D)), ((float)(176D)), ((float)(60D)), ((float)(28D)));
			this.b_sel3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.b_sel3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.b_sel3.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.b_sel3.Name = "b_sel3";
			this.b_sel3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.b_sel3.Radius = 2D;
			this.b_sel3.Text = "3";
			this.b_sel3.Use3DEffect = false;
			this.b_sel3.Click += new System.EventHandler(this.BtnSel3Click);
			// 
			// x_SEL
			// 
			this.x_SEL.BeginInit();
			this.x_SEL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_SEL.IsOnlyInput = true;
			this.x_SEL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_SEL.Name = "x_SEL";
			this.x_SEL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_SEL.TagName = "CMD_SELECAO_BOMBA";
			this.x_SEL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SelValueChanged);
			this.x_SEL.EndInit();
			// 
			// sAjustes
			// 
			this.Name = "sAjustes";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.sep,
			this.titulo,
			this.l_CMD_HABILITA,
			this.c_CMD_HABILITA,
			this.l_STP_TEMPO_B1,
			this.c_STP_TEMPO_B1,
			this.l_STP_TEMPO_B2,
			this.c_STP_TEMPO_B2,
			this.l_STP_TEMPO_B3,
			this.c_STP_TEMPO_B3,
			this.l_CMD_SELECAO_BOMBA,
			this.b_sel0,
			this.b_sel1,
			this.b_sel2,
			this.b_sel3,
			this.x_SEL});
			this.SymbolSize = new System.Drawing.Size(430, 216);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText l_CMD_HABILITA;
		private System.HMI.Symbols.Base.CheckButton c_CMD_HABILITA;
		private NxtControl.GuiFramework.FreeText l_STP_TEMPO_B1;
		private System.HMI.Symbols.Base.TextBox<ushort> c_STP_TEMPO_B1;
		private NxtControl.GuiFramework.FreeText l_STP_TEMPO_B2;
		private System.HMI.Symbols.Base.TextBox<ushort> c_STP_TEMPO_B2;
		private NxtControl.GuiFramework.FreeText l_STP_TEMPO_B3;
		private System.HMI.Symbols.Base.TextBox<ushort> c_STP_TEMPO_B3;
		private NxtControl.GuiFramework.FreeText l_CMD_SELECAO_BOMBA;
		private NxtControl.GuiFramework.DrawnButton b_sel0;
		private NxtControl.GuiFramework.DrawnButton b_sel1;
		private NxtControl.GuiFramework.DrawnButton b_sel2;
		private NxtControl.GuiFramework.DrawnButton b_sel3;
		private System.HMI.Symbols.Base.Execute<short> x_SEL;
		#endregion
	}
}
