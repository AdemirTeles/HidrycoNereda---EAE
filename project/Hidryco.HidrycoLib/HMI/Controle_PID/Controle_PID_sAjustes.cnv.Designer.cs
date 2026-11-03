/*
 * Hidryco - Controle_PID - sAjustes
 * Painel de ajustes (PID) para o faceplate do processo; rotulos por propriedade.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_PID
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
			this.l_STP_DESEJADO = new NxtControl.GuiFramework.FreeText();
			this.c_STP_DESEJADO = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_PARAMETRO_KP = new NxtControl.GuiFramework.FreeText();
			this.c_STP_PARAMETRO_KP = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_PARAMETRO_KI = new NxtControl.GuiFramework.FreeText();
			this.c_STP_PARAMETRO_KI = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_PARAMETRO_KD = new NxtControl.GuiFramework.FreeText();
			this.c_STP_PARAMETRO_KD = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_MINIMO = new NxtControl.GuiFramework.FreeText();
			this.c_STP_MINIMO = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_MAXIMO = new NxtControl.GuiFramework.FreeText();
			this.c_STP_MAXIMO = new System.HMI.Symbols.Base.TextBox<float>();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(430D)), ((float)(284D)));
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
			this.titulo.Text = "PID";
			// 
			// l_CMD_HABILITA
			// 
			this.l_CMD_HABILITA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_CMD_HABILITA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_CMD_HABILITA.Location = new NxtControl.Drawing.PointF(10D, 46D);
			this.l_CMD_HABILITA.Name = "l_CMD_HABILITA";
			this.l_CMD_HABILITA.Text = "PID habilitado";
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
			// l_STP_DESEJADO
			// 
			this.l_STP_DESEJADO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_DESEJADO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_DESEJADO.Location = new NxtControl.Drawing.PointF(10D, 80D);
			this.l_STP_DESEJADO.Name = "l_STP_DESEJADO";
			this.l_STP_DESEJADO.Text = "Valor desejado";
			// 
			// c_STP_DESEJADO
			// 
			this.c_STP_DESEJADO.BeginInit();
			this.c_STP_DESEJADO.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 76D);
			this.c_STP_DESEJADO.MaximumTag = null;
			this.c_STP_DESEJADO.MinimumTag = null;
			this.c_STP_DESEJADO.Name = "c_STP_DESEJADO";
			this.c_STP_DESEJADO.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_DESEJADO.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_DESEJADO.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_DESEJADO.Suffix = "";
			this.c_STP_DESEJADO.TagName = "STP_DESEJADO";
			this.c_STP_DESEJADO.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_DESEJADO.UseInputPad = true;
			this.c_STP_DESEJADO.Value = 0F;
			this.c_STP_DESEJADO.EndInit();
			// 
			// l_STP_PARAMETRO_KP
			// 
			this.l_STP_PARAMETRO_KP.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_PARAMETRO_KP.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_PARAMETRO_KP.Location = new NxtControl.Drawing.PointF(10D, 114D);
			this.l_STP_PARAMETRO_KP.Name = "l_STP_PARAMETRO_KP";
			this.l_STP_PARAMETRO_KP.Text = "Ganho (Kp)";
			// 
			// c_STP_PARAMETRO_KP
			// 
			this.c_STP_PARAMETRO_KP.BeginInit();
			this.c_STP_PARAMETRO_KP.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 110D);
			this.c_STP_PARAMETRO_KP.MaximumTag = null;
			this.c_STP_PARAMETRO_KP.MinimumTag = null;
			this.c_STP_PARAMETRO_KP.Name = "c_STP_PARAMETRO_KP";
			this.c_STP_PARAMETRO_KP.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_PARAMETRO_KP.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_PARAMETRO_KP.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_PARAMETRO_KP.Suffix = "";
			this.c_STP_PARAMETRO_KP.TagName = "STP_PARAMETRO_KP";
			this.c_STP_PARAMETRO_KP.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_PARAMETRO_KP.UseInputPad = true;
			this.c_STP_PARAMETRO_KP.Value = 0F;
			this.c_STP_PARAMETRO_KP.EndInit();
			// 
			// l_STP_PARAMETRO_KI
			// 
			this.l_STP_PARAMETRO_KI.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_PARAMETRO_KI.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_PARAMETRO_KI.Location = new NxtControl.Drawing.PointF(10D, 148D);
			this.l_STP_PARAMETRO_KI.Name = "l_STP_PARAMETRO_KI";
			this.l_STP_PARAMETRO_KI.Text = "Tempo integral (s)";
			// 
			// c_STP_PARAMETRO_KI
			// 
			this.c_STP_PARAMETRO_KI.BeginInit();
			this.c_STP_PARAMETRO_KI.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 144D);
			this.c_STP_PARAMETRO_KI.MaximumTag = null;
			this.c_STP_PARAMETRO_KI.MinimumTag = null;
			this.c_STP_PARAMETRO_KI.Name = "c_STP_PARAMETRO_KI";
			this.c_STP_PARAMETRO_KI.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_PARAMETRO_KI.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_PARAMETRO_KI.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_PARAMETRO_KI.Suffix = "";
			this.c_STP_PARAMETRO_KI.TagName = "STP_PARAMETRO_KI";
			this.c_STP_PARAMETRO_KI.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_PARAMETRO_KI.UseInputPad = true;
			this.c_STP_PARAMETRO_KI.Value = 0F;
			this.c_STP_PARAMETRO_KI.EndInit();
			// 
			// l_STP_PARAMETRO_KD
			// 
			this.l_STP_PARAMETRO_KD.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_PARAMETRO_KD.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_PARAMETRO_KD.Location = new NxtControl.Drawing.PointF(10D, 182D);
			this.l_STP_PARAMETRO_KD.Name = "l_STP_PARAMETRO_KD";
			this.l_STP_PARAMETRO_KD.Text = "Tempo derivativo (s)";
			// 
			// c_STP_PARAMETRO_KD
			// 
			this.c_STP_PARAMETRO_KD.BeginInit();
			this.c_STP_PARAMETRO_KD.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 178D);
			this.c_STP_PARAMETRO_KD.MaximumTag = null;
			this.c_STP_PARAMETRO_KD.MinimumTag = null;
			this.c_STP_PARAMETRO_KD.Name = "c_STP_PARAMETRO_KD";
			this.c_STP_PARAMETRO_KD.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_PARAMETRO_KD.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_PARAMETRO_KD.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_PARAMETRO_KD.Suffix = "";
			this.c_STP_PARAMETRO_KD.TagName = "STP_PARAMETRO_KD";
			this.c_STP_PARAMETRO_KD.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_PARAMETRO_KD.UseInputPad = true;
			this.c_STP_PARAMETRO_KD.Value = 0F;
			this.c_STP_PARAMETRO_KD.EndInit();
			// 
			// l_STP_MINIMO
			// 
			this.l_STP_MINIMO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_MINIMO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_MINIMO.Location = new NxtControl.Drawing.PointF(10D, 216D);
			this.l_STP_MINIMO.Name = "l_STP_MINIMO";
			this.l_STP_MINIMO.Text = "Saída mínima";
			// 
			// c_STP_MINIMO
			// 
			this.c_STP_MINIMO.BeginInit();
			this.c_STP_MINIMO.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 212D);
			this.c_STP_MINIMO.MaximumTag = null;
			this.c_STP_MINIMO.MinimumTag = null;
			this.c_STP_MINIMO.Name = "c_STP_MINIMO";
			this.c_STP_MINIMO.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_MINIMO.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_MINIMO.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_MINIMO.Suffix = " %";
			this.c_STP_MINIMO.TagName = "STP_MINIMO";
			this.c_STP_MINIMO.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_MINIMO.UseInputPad = true;
			this.c_STP_MINIMO.Value = 0F;
			this.c_STP_MINIMO.EndInit();
			// 
			// l_STP_MAXIMO
			// 
			this.l_STP_MAXIMO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_MAXIMO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_MAXIMO.Location = new NxtControl.Drawing.PointF(10D, 250D);
			this.l_STP_MAXIMO.Name = "l_STP_MAXIMO";
			this.l_STP_MAXIMO.Text = "Saída máxima";
			// 
			// c_STP_MAXIMO
			// 
			this.c_STP_MAXIMO.BeginInit();
			this.c_STP_MAXIMO.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 246D);
			this.c_STP_MAXIMO.MaximumTag = null;
			this.c_STP_MAXIMO.MinimumTag = null;
			this.c_STP_MAXIMO.Name = "c_STP_MAXIMO";
			this.c_STP_MAXIMO.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_MAXIMO.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_MAXIMO.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_MAXIMO.Suffix = " %";
			this.c_STP_MAXIMO.TagName = "STP_MAXIMO";
			this.c_STP_MAXIMO.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_MAXIMO.UseInputPad = true;
			this.c_STP_MAXIMO.Value = 0F;
			this.c_STP_MAXIMO.EndInit();
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
			this.l_STP_DESEJADO,
			this.c_STP_DESEJADO,
			this.l_STP_PARAMETRO_KP,
			this.c_STP_PARAMETRO_KP,
			this.l_STP_PARAMETRO_KI,
			this.c_STP_PARAMETRO_KI,
			this.l_STP_PARAMETRO_KD,
			this.c_STP_PARAMETRO_KD,
			this.l_STP_MINIMO,
			this.c_STP_MINIMO,
			this.l_STP_MAXIMO,
			this.c_STP_MAXIMO});
			this.SymbolSize = new System.Drawing.Size(430, 284);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText l_CMD_HABILITA;
		private System.HMI.Symbols.Base.CheckButton c_CMD_HABILITA;
		private NxtControl.GuiFramework.FreeText l_STP_DESEJADO;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_DESEJADO;
		private NxtControl.GuiFramework.FreeText l_STP_PARAMETRO_KP;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_PARAMETRO_KP;
		private NxtControl.GuiFramework.FreeText l_STP_PARAMETRO_KI;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_PARAMETRO_KI;
		private NxtControl.GuiFramework.FreeText l_STP_PARAMETRO_KD;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_PARAMETRO_KD;
		private NxtControl.GuiFramework.FreeText l_STP_MINIMO;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_MINIMO;
		private NxtControl.GuiFramework.FreeText l_STP_MAXIMO;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_MAXIMO;
		#endregion
	}
}
