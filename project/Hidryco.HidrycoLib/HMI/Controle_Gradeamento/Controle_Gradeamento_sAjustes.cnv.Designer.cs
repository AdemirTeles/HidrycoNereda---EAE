/*
 * Hidryco - Controle_Gradeamento - sAjustes
 * Painel de ajustes (Comandos do painel) para o faceplate do processo; rotulos por propriedade.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Gradeamento
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
			this.l_CMD_LIGA_CICLO_REMOTO = new NxtControl.GuiFramework.FreeText();
			this.c_CMD_LIGA_CICLO_REMOTO = new System.HMI.Symbols.Base.CheckButton();
			this.l_STP_DIFERENCIAL_NIVEL_GRADE1 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.l_STP_DIFERENCIAL_NIVEL_GRADE2 = new NxtControl.GuiFramework.FreeText();
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2 = new System.HMI.Symbols.Base.TextBox<float>();
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
			this.titulo.Text = "Comandos do painel";
			// 
			// l_CMD_LIGA_CICLO_REMOTO
			// 
			this.l_CMD_LIGA_CICLO_REMOTO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_CMD_LIGA_CICLO_REMOTO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_CMD_LIGA_CICLO_REMOTO.Location = new NxtControl.Drawing.PointF(10D, 46D);
			this.l_CMD_LIGA_CICLO_REMOTO.Name = "l_CMD_LIGA_CICLO_REMOTO";
			this.l_CMD_LIGA_CICLO_REMOTO.Text = "Ciclo remoto";
			// 
			// c_CMD_LIGA_CICLO_REMOTO
			// 
			this.c_CMD_LIGA_CICLO_REMOTO.BeginInit();
			this.c_CMD_LIGA_CICLO_REMOTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 310D, 40D);
			this.c_CMD_LIGA_CICLO_REMOTO.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_LIGA_CICLO_REMOTO.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_LIGA_CICLO_REMOTO.FalseText = "Desligado";
			this.c_CMD_LIGA_CICLO_REMOTO.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_CMD_LIGA_CICLO_REMOTO.FontScale = false;
			this.c_CMD_LIGA_CICLO_REMOTO.Name = "c_CMD_LIGA_CICLO_REMOTO";
			this.c_CMD_LIGA_CICLO_REMOTO.TagName = "CMD_LIGA_CICLO_REMOTO";
			this.c_CMD_LIGA_CICLO_REMOTO.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_LIGA_CICLO_REMOTO.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_CMD_LIGA_CICLO_REMOTO.TrueText = "Ligado";
			this.c_CMD_LIGA_CICLO_REMOTO.Value = false;
			this.c_CMD_LIGA_CICLO_REMOTO.EndInit();
			// 
			// l_STP_DIFERENCIAL_NIVEL_GRADE1
			// 
			this.l_STP_DIFERENCIAL_NIVEL_GRADE1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_DIFERENCIAL_NIVEL_GRADE1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_DIFERENCIAL_NIVEL_GRADE1.Location = new NxtControl.Drawing.PointF(10D, 80D);
			this.l_STP_DIFERENCIAL_NIVEL_GRADE1.Name = "l_STP_DIFERENCIAL_NIVEL_GRADE1";
			this.l_STP_DIFERENCIAL_NIVEL_GRADE1.Text = "Diferencial de nível para limpar a grade 1";
			// 
			// c_STP_DIFERENCIAL_NIVEL_GRADE1
			// 
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.BeginInit();
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 76D);
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.MaximumTag = null;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.MinimumTag = null;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.Name = "c_STP_DIFERENCIAL_NIVEL_GRADE1";
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.Suffix = " %";
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.TagName = "STP_DIFERENCIAL_NIVEL_GRADE1";
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.UseInputPad = true;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.Value = 0F;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1.EndInit();
			// 
			// l_STP_DIFERENCIAL_NIVEL_GRADE2
			// 
			this.l_STP_DIFERENCIAL_NIVEL_GRADE2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l_STP_DIFERENCIAL_NIVEL_GRADE2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.l_STP_DIFERENCIAL_NIVEL_GRADE2.Location = new NxtControl.Drawing.PointF(10D, 114D);
			this.l_STP_DIFERENCIAL_NIVEL_GRADE2.Name = "l_STP_DIFERENCIAL_NIVEL_GRADE2";
			this.l_STP_DIFERENCIAL_NIVEL_GRADE2.Text = "Diferencial de nível para limpar a grade 2";
			// 
			// c_STP_DIFERENCIAL_NIVEL_GRADE2
			// 
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.BeginInit();
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.7D, 0D, 0D, 1D, 310D, 110D);
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.MaximumTag = null;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.MinimumTag = null;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.Name = "c_STP_DIFERENCIAL_NIVEL_GRADE2";
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.Suffix = " %";
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.TagName = "STP_DIFERENCIAL_NIVEL_GRADE2";
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.UseInputPad = true;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.Value = 0F;
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2.EndInit();
			// 
			// sAjustes
			// 
			this.Name = "sAjustes";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.sep,
			this.titulo,
			this.l_CMD_LIGA_CICLO_REMOTO,
			this.c_CMD_LIGA_CICLO_REMOTO,
			this.l_STP_DIFERENCIAL_NIVEL_GRADE1,
			this.c_STP_DIFERENCIAL_NIVEL_GRADE1,
			this.l_STP_DIFERENCIAL_NIVEL_GRADE2,
			this.c_STP_DIFERENCIAL_NIVEL_GRADE2});
			this.SymbolSize = new System.Drawing.Size(430, 148);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText l_CMD_LIGA_CICLO_REMOTO;
		private System.HMI.Symbols.Base.CheckButton c_CMD_LIGA_CICLO_REMOTO;
		private NxtControl.GuiFramework.FreeText l_STP_DIFERENCIAL_NIVEL_GRADE1;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_DIFERENCIAL_NIVEL_GRADE1;
		private NxtControl.GuiFramework.FreeText l_STP_DIFERENCIAL_NIVEL_GRADE2;
		private System.HMI.Symbols.Base.TextBox<float> c_STP_DIFERENCIAL_NIVEL_GRADE2;
		#endregion
	}
}
