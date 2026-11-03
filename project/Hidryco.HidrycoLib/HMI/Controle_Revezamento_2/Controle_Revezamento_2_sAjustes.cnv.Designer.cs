/*
 * Hidryco - Controle_Revezamento_2 - sAjustes
 * Painel de ajustes (Revezamento) para o faceplate do processo; rotulos por propriedade.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_2
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
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(430D)), ((float)(148D)));
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
			this.c_STP_TEMPO_B2});
			this.SymbolSize = new System.Drawing.Size(430, 148);

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
		#endregion
	}
}
