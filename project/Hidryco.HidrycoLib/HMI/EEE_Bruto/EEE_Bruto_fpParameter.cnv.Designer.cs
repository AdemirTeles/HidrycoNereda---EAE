/*
 * Hidryco - EEE_Bruto - fpParameter
 * ISA-101: ajustes da elevatoria - paineis dos sub-CATs Necessidade, Revezamento e PID (tags do legado).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.EEE_Bruto
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
			this.Necessidade = new Hidryco.HidrycoLib.Symbols.Controle_Necessidade.sAjustes();
			this.Revezamento = new Hidryco.HidrycoLib.Symbols.Controle_Revezamento_3.sAjustes();
			this.PID = new Hidryco.HidrycoLib.Symbols.Controle_PID.sAjustes();
			this.ajuda = new NxtControl.GuiFramework.FreeText();
			this.titFaixas = new NxtControl.GuiFramework.FreeText();
			this.faixas = new Hidryco.HidrycoLib.Symbols.Controle_Necessidade.sFaixas();
			this.ajuda2 = new NxtControl.GuiFramework.FreeText();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes da elevatória";
			// 
			// Necessidade
			// 
			this.Necessidade.BeginInit();
			this.Necessidade.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 20D, 46D);
			this.Necessidade.Name = "Necessidade";
			this.Necessidade.SecurityToken = ((uint)(4294967295u));
			this.Necessidade.TagName = "Necessidade";
			this.Necessidade.Titulo = "Necessidade";
			this.Necessidade.Rotulo_CMD_HABILITA = "Automático da elevatória";
			this.Necessidade.Rotulo_STP_LIMITE_FAIXA_1 = "Com 1 bomba: desliga abaixo de";
			this.Necessidade.Unidade_STP_LIMITE_FAIXA_1 = " %";
			this.Necessidade.Rotulo_STP_LIMITE_FAIXA_2 = "Com 2 bombas: desliga a 2ª abaixo de";
			this.Necessidade.Unidade_STP_LIMITE_FAIXA_2 = " %";
			this.Necessidade.Rotulo_STP_LIMITE_FAIXA_3 = "Parada: liga a 1ª bomba no nível";
			this.Necessidade.Unidade_STP_LIMITE_FAIXA_3 = " %";
			this.Necessidade.Rotulo_STP_LIMITE_FAIXA_4 = "Com 1 bomba: liga a 2ª no nível";
			this.Necessidade.Unidade_STP_LIMITE_FAIXA_4 = " %";
			this.Necessidade.EndInit();
			// 
			// Revezamento
			// 
			this.Revezamento.BeginInit();
			this.Revezamento.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 20D, 270D);
			this.Revezamento.Name = "Revezamento";
			this.Revezamento.SecurityToken = ((uint)(4294967295u));
			this.Revezamento.TagName = "Revezamento";
			this.Revezamento.Titulo = "Revezamento";
			this.Revezamento.Rotulo_CMD_HABILITA = "Troca da principal por tempo";
			this.Revezamento.Rotulo_STP_TEMPO_B1 = "Horas da BS-01 como principal";
			this.Revezamento.Rotulo_STP_TEMPO_B2 = "Horas da BS-02 como principal";
			this.Revezamento.Rotulo_STP_TEMPO_B3 = "Horas da BS-03 como principal";
			this.Revezamento.Rotulo_CMD_SELECAO_BOMBA = "Bomba principal";
			this.Revezamento.Nome_Selecao1 = "BS-01";
			this.Revezamento.Nome_Selecao2 = "BS-02";
			this.Revezamento.Nome_Selecao3 = "BS-03";
			this.Revezamento.EndInit();
			// 
			// PID
			// 
			this.PID.BeginInit();
			this.PID.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 480D, 46D);
			this.PID.Name = "PID";
			this.PID.SecurityToken = ((uint)(4294967295u));
			this.PID.TagName = "PID";
			this.PID.Titulo = "PID";
			this.PID.Rotulo_CMD_HABILITA = "Velocidade pelo PID (desligado = máxima)";
			this.PID.Rotulo_STP_DESEJADO = "Nível desejado do poço";
			this.PID.Unidade_STP_DESEJADO = " %";
			this.PID.Rotulo_STP_MINIMO = "Velocidade mínima";
			this.PID.Rotulo_STP_MAXIMO = "Velocidade máxima";
			this.PID.Unidade_STP_MINIMO = " Hz";
			this.PID.Unidade_STP_MAXIMO = " Hz";
			this.PID.EndInit();
			// 
			// ajuda
			// 
			this.ajuda.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ajuda.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda.Location = new NxtControl.Drawing.PointF(30D, 500D);
			this.ajuda.Name = "ajuda";
			this.ajuda.Text = "Faixas e nível desejado em % da altura do poço (LIT-03).";
			// 
			// titFaixas
			// 
			this.titFaixas.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titFaixas.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.titFaixas.Location = new NxtControl.Drawing.PointF(480D, 342D);
			this.titFaixas.Name = "titFaixas";
			this.titFaixas.Text = "Faixas de nível (% da altura do poço)";
			// 
			// faixas
			// 
			this.faixas.BeginInit();
			this.faixas.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 500D, 368D);
			this.faixas.Name = "faixas";
			this.faixas.SecurityToken = ((uint)(4294967295u));
			this.faixas.TagName = "Necessidade";
			this.faixas.Texto_Faixa1 = "Desliga a 1ª bomba";
			this.faixas.Texto_Faixa2 = "Desliga a 2ª bomba";
			this.faixas.Texto_Faixa3 = "Liga a 1ª bomba";
			this.faixas.Texto_Faixa4 = "Liga a 2ª bomba";
			this.faixas.EndInit();
			// 
			// ajuda2
			// 
			this.ajuda2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ajuda2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda2.Location = new NxtControl.Drawing.PointF(30D, 515D);
			this.ajuda2.Name = "ajuda2";
			this.ajuda2.Text = "0 h = sem troca por tempo. Velocidades em Hz (60 Hz = 100 %).";
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(930D)), ((float)(580D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.Necessidade,
			this.Revezamento,
			this.PID,
			this.ajuda,
			this.titFaixas,
			this.faixas,
			this.ajuda2});
			this.Size = new System.Drawing.Size(930, 580);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private Hidryco.HidrycoLib.Symbols.Controle_Necessidade.sAjustes Necessidade;
		private Hidryco.HidrycoLib.Symbols.Controle_Revezamento_3.sAjustes Revezamento;
		private Hidryco.HidrycoLib.Symbols.Controle_PID.sAjustes PID;
		private NxtControl.GuiFramework.FreeText ajuda;
		private NxtControl.GuiFramework.FreeText titFaixas;
		private Hidryco.HidrycoLib.Symbols.Controle_Necessidade.sFaixas faixas;
		private NxtControl.GuiFramework.FreeText ajuda2;
		#endregion
	}
}
