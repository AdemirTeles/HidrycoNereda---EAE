/*
 * Hidryco - DesidratacaoLodo - fpParametros
 * Fase solida: parametros (vazao das prensas, PID, protecoes, rodizios e nivel dos tanques).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.DesidratacaoLodo
{
	/// <summary>
	/// Summary description for fpParametros.
	/// </summary>
	partial class fpParametros
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.t1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.t2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l3 = new NxtControl.GuiFramework.FreeText();
			this.t3 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l4 = new NxtControl.GuiFramework.FreeText();
			this.t4 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l5 = new NxtControl.GuiFramework.FreeText();
			this.t5 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l8 = new NxtControl.GuiFramework.FreeText();
			this.t8 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l11 = new NxtControl.GuiFramework.FreeText();
			this.t11 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l12 = new NxtControl.GuiFramework.FreeText();
			this.t12 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l13 = new NxtControl.GuiFramework.FreeText();
			this.t13 = new System.HMI.Symbols.Base.TextBox<short>();
			this.l14 = new NxtControl.GuiFramework.FreeText();
			this.t14 = new System.HMI.Symbols.Base.TextBox<short>();
			this.l15 = new NxtControl.GuiFramework.FreeText();
			this.t15 = new System.HMI.Symbols.Base.TextBox<short>();
			this.rSo = new NxtControl.GuiFramework.FreeText();
			this.btnSoOn = new NxtControl.GuiFramework.DrawnButton();
			this.btnSoOff = new NxtControl.GuiFramework.DrawnButton();
			this.xHab = new System.HMI.Symbols.Base.Execute<bool>();
			this.Revezamento = new Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.sAjustes();
			this.PID = new Hidryco.HidrycoLib.Symbols.Controle_PID.sAjustes();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(990D)), ((float)(40D)));
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
			this.titulo.Text = "Parâmetros da fase sólida";
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l1.Location = new NxtControl.Drawing.PointF(20D, 54D);
			this.l1.Name = "l1";
			this.l1.Text = "Tanques: nível mínimo p/ as bombas (0 = desl.)";
			// 
			// t1
			// 
			this.t1.BeginInit();
			this.t1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 50D);
			this.t1.MaximumTag = null;
			this.t1.MinimumTag = null;
			this.t1.Name = "t1";
			this.t1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t1.Suffix = " %";
			this.t1.TagName = "STP_NIVEL_MIN_TQ";
			this.t1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t1.UseInputPad = true;
			this.t1.Value = 0F;
			this.t1.EndInit();
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(20D, 84D);
			this.l2.Name = "l2";
			this.l2.Text = "Tanques: nível para retomar";
			// 
			// t2
			// 
			this.t2.BeginInit();
			this.t2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 80D);
			this.t2.MaximumTag = null;
			this.t2.MinimumTag = null;
			this.t2.Name = "t2";
			this.t2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t2.Suffix = " %";
			this.t2.TagName = "STP_NIVEL_RETOMA_TQ";
			this.t2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t2.UseInputPad = true;
			this.t2.Value = 0F;
			this.t2.EndInit();
			// 
			// l3
			// 
			this.l3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l3.Location = new NxtControl.Drawing.PointF(20D, 114D);
			this.l3.Name = "l3";
			this.l3.Text = "Vazão de lodo AD-01";
			// 
			// t3
			// 
			this.t3.BeginInit();
			this.t3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 110D);
			this.t3.MaximumTag = null;
			this.t3.MinimumTag = null;
			this.t3.Name = "t3";
			this.t3.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t3.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t3.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t3.Suffix = " m³/h";
			this.t3.TagName = "STP_VAZAO_AD1";
			this.t3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t3.UseInputPad = true;
			this.t3.Value = 0F;
			this.t3.EndInit();
			// 
			// l4
			// 
			this.l4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l4.Location = new NxtControl.Drawing.PointF(20D, 144D);
			this.l4.Name = "l4";
			this.l4.Text = "Vazão de lodo AD-02";
			// 
			// t4
			// 
			this.t4.BeginInit();
			this.t4.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 140D);
			this.t4.MaximumTag = null;
			this.t4.MinimumTag = null;
			this.t4.Name = "t4";
			this.t4.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t4.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t4.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t4.Suffix = " m³/h";
			this.t4.TagName = "STP_VAZAO_AD2";
			this.t4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t4.UseInputPad = true;
			this.t4.Value = 0F;
			this.t4.EndInit();
			// 
			// l5
			// 
			this.l5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l5.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l5.Location = new NxtControl.Drawing.PointF(20D, 174D);
			this.l5.Name = "l5";
			this.l5.Text = "Vazão de lodo AD-03 (futura)";
			// 
			// t5
			// 
			this.t5.BeginInit();
			this.t5.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 170D);
			this.t5.MaximumTag = null;
			this.t5.MinimumTag = null;
			this.t5.Name = "t5";
			this.t5.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t5.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t5.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t5.Suffix = " m³/h";
			this.t5.TagName = "STP_VAZAO_AD3";
			this.t5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t5.UseInputPad = true;
			this.t5.Value = 0F;
			this.t5.EndInit();
			// 
			// l8
			// 
			this.l8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l8.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l8.Location = new NxtControl.Drawing.PointF(20D, 204D);
			this.l8.Name = "l8";
			this.l8.Text = "Velocidade de partida da bomba";
			// 
			// t8
			// 
			this.t8.BeginInit();
			this.t8.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 200D);
			this.t8.MaximumTag = null;
			this.t8.MinimumTag = null;
			this.t8.Name = "t8";
			this.t8.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t8.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t8.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t8.Suffix = " Hz";
			this.t8.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t8.UseInputPad = true;
			this.t8.Value = 0F;
			this.t8.TagName = "STP_VEL_INICIAL";
			this.t8.EndInit();
			// 
			// l11
			// 
			this.l11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l11.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l11.Location = new NxtControl.Drawing.PointF(20D, 234D);
			this.l11.Name = "l11";
			this.l11.Text = "Floculador: suspende acima de (0 = desl.)";
			// 
			// t11
			// 
			this.t11.BeginInit();
			this.t11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 230D);
			this.t11.MaximumTag = null;
			this.t11.MinimumTag = null;
			this.t11.Name = "t11";
			this.t11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t11.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t11.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t11.Suffix = " %";
			this.t11.TagName = "STP_NIVEL_SUSPENDE";
			this.t11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t11.UseInputPad = true;
			this.t11.Value = 0F;
			this.t11.EndInit();
			// 
			// l12
			// 
			this.l12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l12.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l12.Location = new NxtControl.Drawing.PointF(20D, 264D);
			this.l12.Name = "l12";
			this.l12.Text = "Floculador: retoma abaixo de";
			// 
			// t12
			// 
			this.t12.BeginInit();
			this.t12.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 260D);
			this.t12.MaximumTag = null;
			this.t12.MinimumTag = null;
			this.t12.Name = "t12";
			this.t12.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t12.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t12.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t12.Suffix = " %";
			this.t12.TagName = "STP_NIVEL_RETOMA";
			this.t12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t12.UseInputPad = true;
			this.t12.Value = 0F;
			this.t12.EndInit();
			// 
			// l13
			// 
			this.l13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l13.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l13.Location = new NxtControl.Drawing.PointF(20D, 294D);
			this.l13.Name = "l13";
			this.l13.Text = "Tempo máx. para abrir a rota (0 = sem)";
			// 
			// t13
			// 
			this.t13.BeginInit();
			this.t13.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 290D);
			this.t13.MaximumTag = null;
			this.t13.MinimumTag = null;
			this.t13.Name = "t13";
			this.t13.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t13.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t13.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t13.Suffix = " s";
			this.t13.TagName = "STP_TEMPO_VALVULAS";
			this.t13.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t13.UseInputPad = true;
			this.t13.Value = ((short)(0));
			this.t13.EndInit();
			// 
			// l14
			// 
			this.l14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l14.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l14.Location = new NxtControl.Drawing.PointF(20D, 324D);
			this.l14.Name = "l14";
			this.l14.Text = "Bombas: horas a mais p/ BO-02 assumir (0 = sem)";
			// 
			// t14
			// 
			this.t14.BeginInit();
			this.t14.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 320D);
			this.t14.MaximumTag = null;
			this.t14.MinimumTag = null;
			this.t14.Name = "t14";
			this.t14.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t14.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t14.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t14.Suffix = " h";
			this.t14.TagName = "STP_DIF_HORAS_BO";
			this.t14.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t14.UseInputPad = true;
			this.t14.Value = ((short)(0));
			this.t14.EndInit();
			// 
			// l15
			// 
			this.l15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l15.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l15.Location = new NxtControl.Drawing.PointF(20D, 354D);
			this.l15.Name = "l15";
			this.l15.Text = "Aviso prensa não partiu (0 = desl.)";
			// 
			// t15
			// 
			this.t15.BeginInit();
			this.t15.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 380D, 350D);
			this.t15.MaximumTag = null;
			this.t15.MinimumTag = null;
			this.t15.Name = "t15";
			this.t15.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.t15.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.t15.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.t15.Suffix = " min";
			this.t15.TagName = "STP_TEMPO_SEM_PARTIR";
			this.t15.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.t15.UseInputPad = true;
			this.t15.Value = ((short)(0));
			this.t15.EndInit();
			// 
			// rSo
			// 
			this.rSo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.rSo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rSo.Location = new NxtControl.Drawing.PointF(20D, 398D);
			this.rSo.Name = "rSo";
			this.rSo.Text = "Sopradores no automático:";
			// 
			// btnSoOn
			// 
			this.btnSoOn.Bounds = new NxtControl.Drawing.RectF(((float)(220D)), ((float)(390D)), ((float)(140D)), ((float)(34D)));
			this.btnSoOn.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSoOn.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSoOn.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSoOn.Name = "btnSoOn";
			this.btnSoOn.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSoOn.Radius = 2D;
			this.btnSoOn.Text = "Habilitado";
			this.btnSoOn.Use3DEffect = false;
			this.btnSoOn.Click += new System.EventHandler(this.BtnSoOnClick);
			// 
			// btnSoOff
			// 
			this.btnSoOff.Bounds = new NxtControl.Drawing.RectF(((float)(370D)), ((float)(390D)), ((float)(130D)), ((float)(34D)));
			this.btnSoOff.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSoOff.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnSoOff.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSoOff.Name = "btnSoOff";
			this.btnSoOff.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSoOff.Radius = 2D;
			this.btnSoOff.Text = "Desabilitado";
			this.btnSoOff.Use3DEffect = false;
			this.btnSoOff.Click += new System.EventHandler(this.BtnSoOffClick);
			// 
			// xHab
			// 
			this.xHab.BeginInit();
			this.xHab.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHab.IsOnlyInput = true;
			this.xHab.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHab.Name = "xHab";
			this.xHab.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHab.TagName = "HAB_SOPRADORES";
			this.xHab.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XHabValueChanged);
			this.xHab.EndInit();
			// 
			// fpParametros
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(990D)), ((float)(460D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			// 
			// Revezamento
			// 
			this.Revezamento.BeginInit();
			this.Revezamento.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 540D, 52D);
			this.Revezamento.Name = "Revezamento";
			this.Revezamento.SecurityToken = ((uint)(4294967295u));
			this.Revezamento.TagName = "Revezamento";
			this.Revezamento.Titulo = "Revezamento dos sopradores";
			this.Revezamento.Rotulo_CMD_HABILITA = "Troca do soprador principal por tempo";
			this.Revezamento.Rotulo_STP_TEMPO_B1 = "Horas do SO-01 como principal";
			this.Revezamento.Rotulo_STP_TEMPO_B2 = "Horas do SO-02 como principal";
			this.Revezamento.EndInit();
			// 
			// PID
			// 
			this.PID.BeginInit();
			this.PID.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 540D, 208D);
			this.PID.Name = "PID";
			this.PID.SecurityToken = ((uint)(4294967295u));
			this.PID.TagName = "PID";
			this.PID.Titulo = "PID das bombas de lodo (AD-01/02/03)";
			this.PID.Mostra_CMD_HABILITA = false;
			this.PID.Mostra_STP_DESEJADO = false;
			this.PID.Mostra_STP_PARAMETRO_KD = false;
			this.PID.Rotulo_STP_PARAMETRO_KP = "PID: ganho (% por m³/h)";
			this.PID.Unidade_STP_PARAMETRO_KP = "";
			this.PID.Rotulo_STP_PARAMETRO_KI = "PID: tempo integral";
			this.PID.Unidade_STP_PARAMETRO_KI = " s";
			this.PID.Rotulo_STP_MINIMO = "Velocidade mínima (PID)";
			this.PID.Rotulo_STP_MAXIMO = "Velocidade máxima (PID)";
			this.PID.Unidade_STP_MINIMO = " Hz";
			this.PID.Unidade_STP_MAXIMO = " Hz";
			this.PID.EndInit();
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.titulo,
			this.l1,
			this.t1,
			this.l2,
			this.t2,
			this.l3,
			this.t3,
			this.l4,
			this.t4,
			this.l5,
			this.t5,
			this.l8,
			this.t8,
			this.l11,
			this.t11,
			this.l12,
			this.t12,
			this.l13,
			this.t13,
			this.l14,
			this.t14,
			this.l15,
			this.t15,
			this.rSo,
			this.btnSoOn,
			this.btnSoOff,
			this.xHab,
			this.Revezamento,
			this.PID});
			this.Size = new System.Drawing.Size(990, 460);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText l1;
		private System.HMI.Symbols.Base.TextBox<float> t1;
		private NxtControl.GuiFramework.FreeText l2;
		private System.HMI.Symbols.Base.TextBox<float> t2;
		private NxtControl.GuiFramework.FreeText l3;
		private System.HMI.Symbols.Base.TextBox<float> t3;
		private NxtControl.GuiFramework.FreeText l4;
		private System.HMI.Symbols.Base.TextBox<float> t4;
		private NxtControl.GuiFramework.FreeText l5;
		private System.HMI.Symbols.Base.TextBox<float> t5;
		private NxtControl.GuiFramework.FreeText l8;
		private System.HMI.Symbols.Base.TextBox<float> t8;
		private NxtControl.GuiFramework.FreeText l11;
		private System.HMI.Symbols.Base.TextBox<float> t11;
		private NxtControl.GuiFramework.FreeText l12;
		private System.HMI.Symbols.Base.TextBox<float> t12;
		private NxtControl.GuiFramework.FreeText l13;
		private System.HMI.Symbols.Base.TextBox<short> t13;
		private NxtControl.GuiFramework.FreeText l14;
		private System.HMI.Symbols.Base.TextBox<short> t14;
		private NxtControl.GuiFramework.FreeText l15;
		private System.HMI.Symbols.Base.TextBox<short> t15;
		private NxtControl.GuiFramework.FreeText rSo;
		private NxtControl.GuiFramework.DrawnButton btnSoOn;
		private NxtControl.GuiFramework.DrawnButton btnSoOff;
		private System.HMI.Symbols.Base.Execute<bool> xHab;
		private Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2.sAjustes Revezamento;
		private Hidryco.HidrycoLib.Symbols.Controle_PID.sAjustes PID;
		#endregion
	}
}
