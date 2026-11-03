/*
 * Hidryco - Controle_Necessidade - sAjustes
 * Painel de ajustes (Necessidade) para o faceplate do processo; rotulos por propriedade.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Necessidade
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
			this.l_STP_LIMITE_FAIXA_1 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_LIMITE_FAIXA_1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_LIMITE_FAIXA_2 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_LIMITE_FAIXA_2 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_LIMITE_FAIXA_3 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_LIMITE_FAIXA_3 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_LIMITE_FAIXA_4 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_LIMITE_FAIXA_4 = new System.HMI.Symbols.Base.TextBox<float>();
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
			this.titulo.Text = "Necessidade";
			// 
			// l_CMD_HABILITA
			// 
			this.l_CMD_HABILITA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_CMD_HABILITA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_CMD_HABILITA.Location = new NxtControl.Drawing.PointF(10D, 46D);
			this.l_CMD_HABILITA.Name = "l_CMD_HABILITA";
			this.l_CMD_HABILITA.Text = "Habilitado";
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
			// l_STP_LIMITE_FAIXA_1
			// 
			this.l_STP_LIMITE_FAIXA_1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_LIMITE_FAIXA_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_LIMITE_FAIXA_1.Location = new NxtControl.Drawing.PointF(10D, 80D);
			this.l_STP_LIMITE_FAIXA_1.Name = "l_STP_LIMITE_FAIXA_1";
			this.l_STP_LIMITE_FAIXA_1.Text = "Limite da faixa 1";
			// 
			// c_STP_LIMITE_FAIXA_1
			// 
			this.c_STP_LIMITE_FAIXA_1.BeginInit();
			this.c_STP_LIMITE_FAIXA_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 76D);
			this.c_STP_LIMITE_FAIXA_1.MaximumTag = null;
			this.c_STP_LIMITE_FAIXA_1.MinimumTag = null;
			this.c_STP_LIMITE_FAIXA_1.Name = "c_STP_LIMITE_FAIXA_1";
			this.c_STP_LIMITE_FAIXA_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_LIMITE_FAIXA_1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_LIMITE_FAIXA_1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_LIMITE_FAIXA_1.Suffix = "";
			this.c_STP_LIMITE_FAIXA_1.TagName = "STP_LIMITE_FAIXA_1";
			this.c_STP_LIMITE_FAIXA_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_LIMITE_FAIXA_1.UseInputPad = true;
			this.c_STP_LIMITE_FAIXA_1.Value = 0F;
			this.c_STP_LIMITE_FAIXA_1.EndInit();
			// 
			// l_STP_LIMITE_FAIXA_2
			// 
			this.l_STP_LIMITE_FAIXA_2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_LIMITE_FAIXA_2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_LIMITE_FAIXA_2.Location = new NxtControl.Drawing.PointF(10D, 114D);
			this.l_STP_LIMITE_FAIXA_2.Name = "l_STP_LIMITE_FAIXA_2";
			this.l_STP_LIMITE_FAIXA_2.Text = "Limite da faixa 2";
			// 
			// c_STP_LIMITE_FAIXA_2
			// 
			this.c_STP_LIMITE_FAIXA_2.BeginInit();
			this.c_STP_LIMITE_FAIXA_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 110D);
			this.c_STP_LIMITE_FAIXA_2.MaximumTag = null;
			this.c_STP_LIMITE_FAIXA_2.MinimumTag = null;
			this.c_STP_LIMITE_FAIXA_2.Name = "c_STP_LIMITE_FAIXA_2";
			this.c_STP_LIMITE_FAIXA_2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_LIMITE_FAIXA_2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_LIMITE_FAIXA_2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_LIMITE_FAIXA_2.Suffix = "";
			this.c_STP_LIMITE_FAIXA_2.TagName = "STP_LIMITE_FAIXA_2";
			this.c_STP_LIMITE_FAIXA_2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_LIMITE_FAIXA_2.UseInputPad = true;
			this.c_STP_LIMITE_FAIXA_2.Value = 0F;
			this.c_STP_LIMITE_FAIXA_2.EndInit();
			// 
			// l_STP_LIMITE_FAIXA_3
			// 
			this.l_STP_LIMITE_FAIXA_3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_LIMITE_FAIXA_3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_LIMITE_FAIXA_3.Location = new NxtControl.Drawing.PointF(10D, 148D);
			this.l_STP_LIMITE_FAIXA_3.Name = "l_STP_LIMITE_FAIXA_3";
			this.l_STP_LIMITE_FAIXA_3.Text = "Limite da faixa 3";
			// 
			// c_STP_LIMITE_FAIXA_3
			// 
			this.c_STP_LIMITE_FAIXA_3.BeginInit();
			this.c_STP_LIMITE_FAIXA_3.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 144D);
			this.c_STP_LIMITE_FAIXA_3.MaximumTag = null;
			this.c_STP_LIMITE_FAIXA_3.MinimumTag = null;
			this.c_STP_LIMITE_FAIXA_3.Name = "c_STP_LIMITE_FAIXA_3";
			this.c_STP_LIMITE_FAIXA_3.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_LIMITE_FAIXA_3.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_LIMITE_FAIXA_3.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_LIMITE_FAIXA_3.Suffix = "";
			this.c_STP_LIMITE_FAIXA_3.TagName = "STP_LIMITE_FAIXA_3";
			this.c_STP_LIMITE_FAIXA_3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_LIMITE_FAIXA_3.UseInputPad = true;
			this.c_STP_LIMITE_FAIXA_3.Value = 0F;
			this.c_STP_LIMITE_FAIXA_3.EndInit();
			// 
			// l_STP_LIMITE_FAIXA_4
			// 
			this.l_STP_LIMITE_FAIXA_4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_LIMITE_FAIXA_4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_LIMITE_FAIXA_4.Location = new NxtControl.Drawing.PointF(10D, 182D);
			this.l_STP_LIMITE_FAIXA_4.Name = "l_STP_LIMITE_FAIXA_4";
			this.l_STP_LIMITE_FAIXA_4.Text = "Limite da faixa 4";
			// 
			// c_STP_LIMITE_FAIXA_4
			// 
			this.c_STP_LIMITE_FAIXA_4.BeginInit();
			this.c_STP_LIMITE_FAIXA_4.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 178D);
			this.c_STP_LIMITE_FAIXA_4.MaximumTag = null;
			this.c_STP_LIMITE_FAIXA_4.MinimumTag = null;
			this.c_STP_LIMITE_FAIXA_4.Name = "c_STP_LIMITE_FAIXA_4";
			this.c_STP_LIMITE_FAIXA_4.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_LIMITE_FAIXA_4.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_LIMITE_FAIXA_4.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_LIMITE_FAIXA_4.Suffix = "";
			this.c_STP_LIMITE_FAIXA_4.TagName = "STP_LIMITE_FAIXA_4";
			this.c_STP_LIMITE_FAIXA_4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_LIMITE_FAIXA_4.UseInputPad = true;
			this.c_STP_LIMITE_FAIXA_4.Value = 0F;
			this.c_STP_LIMITE_FAIXA_4.EndInit();
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
			this.l_STP_LIMITE_FAIXA_1,
			this.c_STP_LIMITE_FAIXA_1,
			this.l_STP_LIMITE_FAIXA_2,
			this.c_STP_LIMITE_FAIXA_2,
			this.l_STP_LIMITE_FAIXA_3,
			this.c_STP_LIMITE_FAIXA_3,
			this.l_STP_LIMITE_FAIXA_4,
			this.c_STP_LIMITE_FAIXA_4});
			this.SymbolSize = new System.Drawing.Size(430, 216);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText l_CMD_HABILITA;
		private System.HMI.Symbols.Base.CheckButton c_CMD_HABILITA;
		private NxtControl.GuiFramework.FreeText l_STP_LIMITE_FAIXA_1;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_LIMITE_FAIXA_1;
		private NxtControl.GuiFramework.FreeText l_STP_LIMITE_FAIXA_2;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_LIMITE_FAIXA_2;
		private NxtControl.GuiFramework.FreeText l_STP_LIMITE_FAIXA_3;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_LIMITE_FAIXA_3;
		private NxtControl.GuiFramework.FreeText l_STP_LIMITE_FAIXA_4;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_LIMITE_FAIXA_4;
		#endregion
	}
}
