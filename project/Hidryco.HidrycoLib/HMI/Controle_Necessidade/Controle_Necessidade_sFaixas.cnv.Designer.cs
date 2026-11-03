/*
 * Hidryco - Controle_Necessidade - sFaixas
 * Faixas de nivel: barra 0-100 %, limites com setas (liga/desliga) e nivel atual; textos por propriedade.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Necessidade
{
	/// <summary>
	/// Summary description for sFaixas.
	/// </summary>
	partial class sFaixas
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.barra0 = new NxtControl.GuiFramework.Rectangle();
			this.barra1 = new NxtControl.GuiFramework.Rectangle();
			this.barra2 = new NxtControl.GuiFramework.Rectangle();
			this.barra3 = new NxtControl.GuiFramework.Rectangle();
			this.barra4 = new NxtControl.GuiFramework.Rectangle();
			this.moldura = new NxtControl.GuiFramework.Rectangle();
			this.t100 = new NxtControl.GuiFramework.FreeText();
			this.t0 = new NxtControl.GuiFramework.FreeText();
			this.lin0 = new NxtControl.GuiFramework.Line();
			this.val0 = new NxtControl.GuiFramework.FreeText();
			this.seta0 = new NxtControl.GuiFramework.Polygon();
			this.txt0 = new NxtControl.GuiFramework.FreeText();
			this.lin1 = new NxtControl.GuiFramework.Line();
			this.val1 = new NxtControl.GuiFramework.FreeText();
			this.seta1 = new NxtControl.GuiFramework.Polygon();
			this.txt1 = new NxtControl.GuiFramework.FreeText();
			this.lin2 = new NxtControl.GuiFramework.Line();
			this.val2 = new NxtControl.GuiFramework.FreeText();
			this.seta2 = new NxtControl.GuiFramework.Polygon();
			this.txt2 = new NxtControl.GuiFramework.FreeText();
			this.lin3 = new NxtControl.GuiFramework.Line();
			this.val3 = new NxtControl.GuiFramework.FreeText();
			this.seta3 = new NxtControl.GuiFramework.Polygon();
			this.txt3 = new NxtControl.GuiFramework.FreeText();
			this.nivel = new NxtControl.GuiFramework.Rectangle();
			this.nivelTxt = new NxtControl.GuiFramework.FreeText();
			this.x_F1 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_F2 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_F3 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_F4 = new System.HMI.Symbols.Base.Execute<float>();
			this.x_NIV = new System.HMI.Symbols.Base.Execute<float>();
			this.x_HAB = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(196D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barra0
			// 
			this.barra0.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(10D)), ((float)(22D)), ((float)(35.2D)));
			this.barra0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(220)), ((byte)(60)), ((byte)(40))));
			this.barra0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barra0.Name = "barra0";
			this.barra0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(220)), ((byte)(60)), ((byte)(40))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barra1
			// 
			this.barra1.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(45.2D)), ((float)(22D)), ((float)(35.2D)));
			this.barra1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(150)), ((byte)(40))));
			this.barra1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barra1.Name = "barra1";
			this.barra1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(150)), ((byte)(40))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barra2
			// 
			this.barra2.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(80.4D)), ((float)(22D)), ((float)(35.2D)));
			this.barra2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(210)), ((byte)(60))));
			this.barra2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barra2.Name = "barra2";
			this.barra2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(210)), ((byte)(60))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barra3
			// 
			this.barra3.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(115.6D)), ((float)(22D)), ((float)(35.2D)));
			this.barra3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(190)), ((byte)(90))));
			this.barra3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barra3.Name = "barra3";
			this.barra3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(190)), ((byte)(90))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barra4
			// 
			this.barra4.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(150.8D)), ((float)(22D)), ((float)(35.2D)));
			this.barra4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(140)), ((byte)(220))));
			this.barra4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.barra4.Name = "barra4";
			this.barra4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(140)), ((byte)(220))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// moldura
			// 
			this.moldura.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(10D)), ((float)(22D)), ((float)(176D)));
			this.moldura.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.moldura.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.moldura.Name = "moldura";
			this.moldura.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t100
			// 
			this.t100.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.t100.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.t100.Location = new NxtControl.Drawing.PointF(96D, 4D);
			this.t100.Name = "t100";
			this.t100.Text = "100 %";
			// 
			// t0
			// 
			this.t0.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.t0.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.t0.Location = new NxtControl.Drawing.PointF(96D, 180D);
			this.t0.Name = "t0";
			this.t0.Text = "0 %";
			// 
			// lin0
			// 
			this.lin0.EndPoint = new NxtControl.Drawing.PointF(118D, 10D);
			this.lin0.Name = "lin0";
			this.lin0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lin0.StartPoint = new NxtControl.Drawing.PointF(40D, 10D);
			// 
			// val0
			// 
			this.val0.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.val0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.val0.Location = new NxtControl.Drawing.PointF(0D, 10D);
			this.val0.Name = "val0";
			this.val0.Text = "0 %";
			// 
			// seta0
			// 
			this.seta0.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(10D)), ((float)(16D)), ((float)(14D)));
			this.seta0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(50)), ((byte)(40))));
			this.seta0.Closed = true;
			this.seta0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.seta0.Name = "seta0";
			this.seta0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.seta0.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(125D, 10D),
			new NxtControl.Drawing.PointF(131D, 10D),
			new NxtControl.Drawing.PointF(131D, 16D),
			new NxtControl.Drawing.PointF(136D, 16D),
			new NxtControl.Drawing.PointF(128D, 24D),
			new NxtControl.Drawing.PointF(120D, 16D),
			new NxtControl.Drawing.PointF(125D, 16D)});
			// 
			// txt0
			// 
			this.txt0.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.txt0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt0.Location = new NxtControl.Drawing.PointF(140D, 10D);
			this.txt0.Name = "txt0";
			this.txt0.Text = "Desliga o 1º";
			// 
			// lin1
			// 
			this.lin1.EndPoint = new NxtControl.Drawing.PointF(118D, 10D);
			this.lin1.Name = "lin1";
			this.lin1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lin1.StartPoint = new NxtControl.Drawing.PointF(40D, 10D);
			// 
			// val1
			// 
			this.val1.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.val1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.val1.Location = new NxtControl.Drawing.PointF(0D, 10D);
			this.val1.Name = "val1";
			this.val1.Text = "0 %";
			// 
			// seta1
			// 
			this.seta1.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(10D)), ((float)(16D)), ((float)(14D)));
			this.seta1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(50)), ((byte)(40))));
			this.seta1.Closed = true;
			this.seta1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.seta1.Name = "seta1";
			this.seta1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.seta1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(125D, 10D),
			new NxtControl.Drawing.PointF(131D, 10D),
			new NxtControl.Drawing.PointF(131D, 16D),
			new NxtControl.Drawing.PointF(136D, 16D),
			new NxtControl.Drawing.PointF(128D, 24D),
			new NxtControl.Drawing.PointF(120D, 16D),
			new NxtControl.Drawing.PointF(125D, 16D)});
			// 
			// txt1
			// 
			this.txt1.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.txt1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt1.Location = new NxtControl.Drawing.PointF(140D, 10D);
			this.txt1.Name = "txt1";
			this.txt1.Text = "Desliga o 2º";
			// 
			// lin2
			// 
			this.lin2.EndPoint = new NxtControl.Drawing.PointF(118D, 10D);
			this.lin2.Name = "lin2";
			this.lin2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lin2.StartPoint = new NxtControl.Drawing.PointF(40D, 10D);
			// 
			// val2
			// 
			this.val2.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.val2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.val2.Location = new NxtControl.Drawing.PointF(0D, 10D);
			this.val2.Name = "val2";
			this.val2.Text = "0 %";
			// 
			// seta2
			// 
			this.seta2.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(10D)), ((float)(16D)), ((float)(14D)));
			this.seta2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(170)), ((byte)(60))));
			this.seta2.Closed = true;
			this.seta2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.seta2.Name = "seta2";
			this.seta2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.seta2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(128D, 10D),
			new NxtControl.Drawing.PointF(136D, 18D),
			new NxtControl.Drawing.PointF(131D, 18D),
			new NxtControl.Drawing.PointF(131D, 24D),
			new NxtControl.Drawing.PointF(125D, 24D),
			new NxtControl.Drawing.PointF(125D, 18D),
			new NxtControl.Drawing.PointF(120D, 18D)});
			// 
			// txt2
			// 
			this.txt2.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.txt2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt2.Location = new NxtControl.Drawing.PointF(140D, 10D);
			this.txt2.Name = "txt2";
			this.txt2.Text = "Liga o 1º";
			// 
			// lin3
			// 
			this.lin3.EndPoint = new NxtControl.Drawing.PointF(118D, 10D);
			this.lin3.Name = "lin3";
			this.lin3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lin3.StartPoint = new NxtControl.Drawing.PointF(40D, 10D);
			// 
			// val3
			// 
			this.val3.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.val3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.val3.Location = new NxtControl.Drawing.PointF(0D, 10D);
			this.val3.Name = "val3";
			this.val3.Text = "0 %";
			// 
			// seta3
			// 
			this.seta3.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(10D)), ((float)(16D)), ((float)(14D)));
			this.seta3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(170)), ((byte)(60))));
			this.seta3.Closed = true;
			this.seta3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.seta3.Name = "seta3";
			this.seta3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.seta3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(128D, 10D),
			new NxtControl.Drawing.PointF(136D, 18D),
			new NxtControl.Drawing.PointF(131D, 18D),
			new NxtControl.Drawing.PointF(131D, 24D),
			new NxtControl.Drawing.PointF(125D, 24D),
			new NxtControl.Drawing.PointF(125D, 18D),
			new NxtControl.Drawing.PointF(120D, 18D)});
			// 
			// txt3
			// 
			this.txt3.Color = new NxtControl.Drawing.Color(((byte)(30)), ((byte)(30)), ((byte)(30)));
			this.txt3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt3.Location = new NxtControl.Drawing.PointF(140D, 10D);
			this.txt3.Name = "txt3";
			this.txt3.Text = "Liga o 2º";
			// 
			// nivel
			// 
			this.nivel.Bounds = new NxtControl.Drawing.RectF(((float)(66D)), ((float)(10D)), ((float)(30D)), ((float)(4D)));
			this.nivel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20))));
			this.nivel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nivel.Name = "nivel";
			this.nivel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20))), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// nivelTxt
			// 
			this.nivelTxt.Color = new NxtControl.Drawing.Color(((byte)(20)), ((byte)(20)), ((byte)(20)));
			this.nivelTxt.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.nivelTxt.Location = new NxtControl.Drawing.PointF(96D, 10D);
			this.nivelTxt.Name = "nivelTxt";
			this.nivelTxt.Text = "";
			// 
			// x_F1
			// 
			this.x_F1.BeginInit();
			this.x_F1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_F1.IsOnlyInput = true;
			this.x_F1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_F1.Name = "x_F1";
			this.x_F1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_F1.TagName = "STP_LIMITE_FAIXA_1";
			this.x_F1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.F1ValueChanged);
			this.x_F1.EndInit();
			// 
			// x_F2
			// 
			this.x_F2.BeginInit();
			this.x_F2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_F2.IsOnlyInput = true;
			this.x_F2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_F2.Name = "x_F2";
			this.x_F2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_F2.TagName = "STP_LIMITE_FAIXA_2";
			this.x_F2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.F2ValueChanged);
			this.x_F2.EndInit();
			// 
			// x_F3
			// 
			this.x_F3.BeginInit();
			this.x_F3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_F3.IsOnlyInput = true;
			this.x_F3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_F3.Name = "x_F3";
			this.x_F3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_F3.TagName = "STP_LIMITE_FAIXA_3";
			this.x_F3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.F3ValueChanged);
			this.x_F3.EndInit();
			// 
			// x_F4
			// 
			this.x_F4.BeginInit();
			this.x_F4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_F4.IsOnlyInput = true;
			this.x_F4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_F4.Name = "x_F4";
			this.x_F4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_F4.TagName = "STP_LIMITE_FAIXA_4";
			this.x_F4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.F4ValueChanged);
			this.x_F4.EndInit();
			// 
			// x_NIV
			// 
			this.x_NIV.BeginInit();
			this.x_NIV.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_NIV.IsOnlyInput = true;
			this.x_NIV.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_NIV.Name = "x_NIV";
			this.x_NIV.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_NIV.TagName = "STS_NIVEL";
			this.x_NIV.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NivValueChanged);
			this.x_NIV.EndInit();
			// 
			// x_HAB
			// 
			this.x_HAB.BeginInit();
			this.x_HAB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_HAB.IsOnlyInput = true;
			this.x_HAB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_HAB.Name = "x_HAB";
			this.x_HAB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_HAB.TagName = "CMD_HABILITA";
			this.x_HAB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.HabValueChanged);
			this.x_HAB.EndInit();
			// 
			// sFaixas
			// 
			this.Name = "sFaixas";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.barra0,
			this.barra1,
			this.barra2,
			this.barra3,
			this.barra4,
			this.moldura,
			this.t100,
			this.t0,
			this.lin0,
			this.val0,
			this.seta0,
			this.txt0,
			this.lin1,
			this.val1,
			this.seta1,
			this.txt1,
			this.lin2,
			this.val2,
			this.seta2,
			this.txt2,
			this.lin3,
			this.val3,
			this.seta3,
			this.txt3,
			this.nivel,
			this.nivelTxt,
			this.x_F1,
			this.x_F2,
			this.x_F3,
			this.x_F4,
			this.x_NIV,
			this.x_HAB});
			this.SymbolSize = new System.Drawing.Size(250, 196);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle barra0;
		private NxtControl.GuiFramework.Rectangle barra1;
		private NxtControl.GuiFramework.Rectangle barra2;
		private NxtControl.GuiFramework.Rectangle barra3;
		private NxtControl.GuiFramework.Rectangle barra4;
		private NxtControl.GuiFramework.Rectangle moldura;
		private NxtControl.GuiFramework.FreeText t100;
		private NxtControl.GuiFramework.FreeText t0;
		private NxtControl.GuiFramework.Line lin0;
		private NxtControl.GuiFramework.FreeText val0;
		private NxtControl.GuiFramework.Polygon seta0;
		private NxtControl.GuiFramework.FreeText txt0;
		private NxtControl.GuiFramework.Line lin1;
		private NxtControl.GuiFramework.FreeText val1;
		private NxtControl.GuiFramework.Polygon seta1;
		private NxtControl.GuiFramework.FreeText txt1;
		private NxtControl.GuiFramework.Line lin2;
		private NxtControl.GuiFramework.FreeText val2;
		private NxtControl.GuiFramework.Polygon seta2;
		private NxtControl.GuiFramework.FreeText txt2;
		private NxtControl.GuiFramework.Line lin3;
		private NxtControl.GuiFramework.FreeText val3;
		private NxtControl.GuiFramework.Polygon seta3;
		private NxtControl.GuiFramework.FreeText txt3;
		private NxtControl.GuiFramework.Rectangle nivel;
		private NxtControl.GuiFramework.FreeText nivelTxt;
		private System.HMI.Symbols.Base.Execute<float> x_F1;
		private System.HMI.Symbols.Base.Execute<float> x_F2;
		private System.HMI.Symbols.Base.Execute<float> x_F3;
		private System.HMI.Symbols.Base.Execute<float> x_F4;
		private System.HMI.Symbols.Base.Execute<float> x_NIV;
		private System.HMI.Symbols.Base.Execute<bool> x_HAB;
		#endregion
	}
}
