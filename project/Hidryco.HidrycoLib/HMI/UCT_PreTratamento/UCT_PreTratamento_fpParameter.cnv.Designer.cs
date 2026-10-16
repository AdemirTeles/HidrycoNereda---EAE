/*
 * Hidryco - UCT_PreTratamento - fpParameter
 * ISA-101: UCT habilitada para o bloqueio da EEE Bruto e tempos da bomba de gordura / valvula de lavagem.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UCT_PreTratamento
{
	/// <summary>
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.lHab = new NxtControl.GuiFramework.FreeText();
			this.cHab = new System.HMI.Symbols.Base.CheckButton();
			this.sep = new NxtControl.GuiFramework.Rectangle();
			this.tG = new NxtControl.GuiFramework.FreeText();
			this.lSTP_TEMPO_PRE_LAVAGEM = new NxtControl.GuiFramework.FreeText();
			this.tSTP_TEMPO_PRE_LAVAGEM = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lSTP_TEMPO_VALVULA_APOS_PARTIDA = new NxtControl.GuiFramework.FreeText();
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lSTP_TEMPO_DESLIGA_BOMBA = new NxtControl.GuiFramework.FreeText();
			this.tSTP_TEMPO_DESLIGA_BOMBA = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.lSTP_VELOCIDADE_BOMBA_GORDURA = new NxtControl.GuiFramework.FreeText();
			this.tSTP_VELOCIDADE_BOMBA_GORDURA = new System.HMI.Symbols.Base.TextBox<float>();
			this.ajuda = new NxtControl.GuiFramework.FreeText();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes da UCT";
			// 
			// lHab
			// 
			this.lHab.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lHab.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lHab.Location = new NxtControl.Drawing.PointF(20D, 58D);
			this.lHab.Name = "lHab";
			this.lHab.Text = "UCT em operação (conta para a EEE Bruto)";
			// 
			// cHab
			// 
			this.cHab.BeginInit();
			this.cHab.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 320D, 52D);
			this.cHab.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cHab.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cHab.FalseText = "Não";
			this.cHab.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cHab.FontScale = false;
			this.cHab.Name = "cHab";
			this.cHab.TagName = "STP_HABILITADA";
			this.cHab.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cHab.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cHab.TrueText = "Sim";
			this.cHab.Value = false;
			this.cHab.EndInit();
			// 
			// sep
			// 
			this.sep.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(98D)), ((float)(420D)), ((float)(1D)));
			this.sep.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.sep.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.sep.Name = "sep";
			this.sep.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tG
			// 
			this.tG.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tG.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tG.Location = new NxtControl.Drawing.PointF(20D, 108D);
			this.tG.Name = "tG";
			this.tG.Text = "Bomba de gordura (automático)";
			// 
			// lSTP_TEMPO_PRE_LAVAGEM
			// 
			this.lSTP_TEMPO_PRE_LAVAGEM.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSTP_TEMPO_PRE_LAVAGEM.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSTP_TEMPO_PRE_LAVAGEM.Location = new NxtControl.Drawing.PointF(20D, 142D);
			this.lSTP_TEMPO_PRE_LAVAGEM.Name = "lSTP_TEMPO_PRE_LAVAGEM";
			this.lSTP_TEMPO_PRE_LAVAGEM.Text = "Válvula aberta antes de ligar a bomba";
			// 
			// tSTP_TEMPO_PRE_LAVAGEM
			// 
			this.tSTP_TEMPO_PRE_LAVAGEM.BeginInit();
			this.tSTP_TEMPO_PRE_LAVAGEM.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 320D, 136D);
			this.tSTP_TEMPO_PRE_LAVAGEM.MaximumTag = null;
			this.tSTP_TEMPO_PRE_LAVAGEM.MinimumTag = null;
			this.tSTP_TEMPO_PRE_LAVAGEM.Name = "tSTP_TEMPO_PRE_LAVAGEM";
			this.tSTP_TEMPO_PRE_LAVAGEM.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tSTP_TEMPO_PRE_LAVAGEM.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tSTP_TEMPO_PRE_LAVAGEM.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tSTP_TEMPO_PRE_LAVAGEM.Suffix = " s";
			this.tSTP_TEMPO_PRE_LAVAGEM.TagName = "STP_TEMPO_PRE_LAVAGEM";
			this.tSTP_TEMPO_PRE_LAVAGEM.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tSTP_TEMPO_PRE_LAVAGEM.UseInputPad = true;
			this.tSTP_TEMPO_PRE_LAVAGEM.Value = ((ushort)(0));
			this.tSTP_TEMPO_PRE_LAVAGEM.EndInit();
			// 
			// lSTP_TEMPO_VALVULA_APOS_PARTIDA
			// 
			this.lSTP_TEMPO_VALVULA_APOS_PARTIDA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSTP_TEMPO_VALVULA_APOS_PARTIDA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSTP_TEMPO_VALVULA_APOS_PARTIDA.Location = new NxtControl.Drawing.PointF(20D, 180D);
			this.lSTP_TEMPO_VALVULA_APOS_PARTIDA.Name = "lSTP_TEMPO_VALVULA_APOS_PARTIDA";
			this.lSTP_TEMPO_VALVULA_APOS_PARTIDA.Text = "Válvula aberta depois da partida";
			// 
			// tSTP_TEMPO_VALVULA_APOS_PARTIDA
			// 
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.BeginInit();
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 320D, 174D);
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.MaximumTag = null;
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.MinimumTag = null;
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.Name = "tSTP_TEMPO_VALVULA_APOS_PARTIDA";
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.Suffix = " s";
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.TagName = "STP_TEMPO_VALVULA_APOS_PARTIDA";
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.UseInputPad = true;
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.Value = ((ushort)(0));
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA.EndInit();
			// 
			// lSTP_TEMPO_DESLIGA_BOMBA
			// 
			this.lSTP_TEMPO_DESLIGA_BOMBA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSTP_TEMPO_DESLIGA_BOMBA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSTP_TEMPO_DESLIGA_BOMBA.Location = new NxtControl.Drawing.PointF(20D, 218D);
			this.lSTP_TEMPO_DESLIGA_BOMBA.Name = "lSTP_TEMPO_DESLIGA_BOMBA";
			this.lSTP_TEMPO_DESLIGA_BOMBA.Text = "Bomba ligada depois do nível alto sair";
			// 
			// tSTP_TEMPO_DESLIGA_BOMBA
			// 
			this.tSTP_TEMPO_DESLIGA_BOMBA.BeginInit();
			this.tSTP_TEMPO_DESLIGA_BOMBA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 320D, 212D);
			this.tSTP_TEMPO_DESLIGA_BOMBA.MaximumTag = null;
			this.tSTP_TEMPO_DESLIGA_BOMBA.MinimumTag = null;
			this.tSTP_TEMPO_DESLIGA_BOMBA.Name = "tSTP_TEMPO_DESLIGA_BOMBA";
			this.tSTP_TEMPO_DESLIGA_BOMBA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tSTP_TEMPO_DESLIGA_BOMBA.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tSTP_TEMPO_DESLIGA_BOMBA.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tSTP_TEMPO_DESLIGA_BOMBA.Suffix = " s";
			this.tSTP_TEMPO_DESLIGA_BOMBA.TagName = "STP_TEMPO_DESLIGA_BOMBA";
			this.tSTP_TEMPO_DESLIGA_BOMBA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tSTP_TEMPO_DESLIGA_BOMBA.UseInputPad = true;
			this.tSTP_TEMPO_DESLIGA_BOMBA.Value = ((ushort)(0));
			this.tSTP_TEMPO_DESLIGA_BOMBA.EndInit();
			// 
			// lSTP_VELOCIDADE_BOMBA_GORDURA
			// 
			this.lSTP_VELOCIDADE_BOMBA_GORDURA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSTP_VELOCIDADE_BOMBA_GORDURA.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSTP_VELOCIDADE_BOMBA_GORDURA.Location = new NxtControl.Drawing.PointF(20D, 256D);
			this.lSTP_VELOCIDADE_BOMBA_GORDURA.Name = "lSTP_VELOCIDADE_BOMBA_GORDURA";
			this.lSTP_VELOCIDADE_BOMBA_GORDURA.Text = "Velocidade da bomba";
			// 
			// tSTP_VELOCIDADE_BOMBA_GORDURA
			// 
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.BeginInit();
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 320D, 250D);
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.MaximumTag = null;
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.MinimumTag = null;
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.Name = "tSTP_VELOCIDADE_BOMBA_GORDURA";
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.Suffix = " %";
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.TagName = "STP_VELOCIDADE_BOMBA_GORDURA";
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.UseInputPad = true;
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.Value = 0F;
			this.tSTP_VELOCIDADE_BOMBA_GORDURA.EndInit();
			// 
			// ajuda
			// 
			this.ajuda.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ajuda.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda.Location = new NxtControl.Drawing.PointF(20D, 290D);
			this.ajuda.Name = "ajuda";
			this.ajuda.Text = "Tempo 0 = sem espera.";
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(460D)), ((float)(318D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpParameter";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.lHab,
			this.cHab,
			this.sep,
			this.tG,
			this.lSTP_TEMPO_PRE_LAVAGEM,
			this.tSTP_TEMPO_PRE_LAVAGEM,
			this.lSTP_TEMPO_VALVULA_APOS_PARTIDA,
			this.tSTP_TEMPO_VALVULA_APOS_PARTIDA,
			this.lSTP_TEMPO_DESLIGA_BOMBA,
			this.tSTP_TEMPO_DESLIGA_BOMBA,
			this.lSTP_VELOCIDADE_BOMBA_GORDURA,
			this.tSTP_VELOCIDADE_BOMBA_GORDURA,
			this.ajuda});
			this.Size = new System.Drawing.Size(460, 318);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText lHab;
		private System.HMI.Symbols.Base.CheckButton cHab;
		private NxtControl.GuiFramework.Rectangle sep;
		private NxtControl.GuiFramework.FreeText tG;
		private NxtControl.GuiFramework.FreeText lSTP_TEMPO_PRE_LAVAGEM;
		private System.HMI.Symbols.Base.TextBox<ushort> tSTP_TEMPO_PRE_LAVAGEM;
		private NxtControl.GuiFramework.FreeText lSTP_TEMPO_VALVULA_APOS_PARTIDA;
		private System.HMI.Symbols.Base.TextBox<ushort> tSTP_TEMPO_VALVULA_APOS_PARTIDA;
		private NxtControl.GuiFramework.FreeText lSTP_TEMPO_DESLIGA_BOMBA;
		private System.HMI.Symbols.Base.TextBox<ushort> tSTP_TEMPO_DESLIGA_BOMBA;
		private NxtControl.GuiFramework.FreeText lSTP_VELOCIDADE_BOMBA_GORDURA;
		private System.HMI.Symbols.Base.TextBox<float> tSTP_VELOCIDADE_BOMBA_GORDURA;
		private NxtControl.GuiFramework.FreeText ajuda;
		#endregion
	}
}
