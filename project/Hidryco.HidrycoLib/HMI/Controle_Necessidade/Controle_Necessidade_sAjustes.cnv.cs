/*
 * Hidryco - Controle_Necessidade - sAjustes
 * Painel de ajustes para embutir no faceplate do processo (TagName = nome da instancia do sub-CAT).
 * Rotulos, unidades e linhas visiveis por propriedade; as linhas visiveis sobem para nao deixar buraco.
 */

using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Necessidade
{
	public partial class sAjustes : NxtControl.GuiFramework.HMISymbol
	{
		public sAjustes()
		{
			InitializeComponent();
			linhas = new Linha[] {
				new Linha(l_CMD_HABILITA, c_CMD_HABILITA, true),
				new Linha(l_STP_LIMITE_FAIXA_1, c_STP_LIMITE_FAIXA_1, false),
				new Linha(l_STP_LIMITE_FAIXA_2, c_STP_LIMITE_FAIXA_2, false),
				new Linha(l_STP_LIMITE_FAIXA_3, c_STP_LIMITE_FAIXA_3, false),
				new Linha(l_STP_LIMITE_FAIXA_4, c_STP_LIMITE_FAIXA_4, false) };
			for (int i = 0; i < mostra.Length; i++) mostra[i] = true;
			Arruma();
		}

		class Linha
		{
			public FreeText Rotulo; public object Campo; public bool Botao;
			public Linha(FreeText r, object c, bool b) { Rotulo = r; Campo = c; Botao = b; }
		}
		Linha[] linhas;
		double coluna = 310D;      // x do campo (o faceplate do processo pode aproximar para caber)
		readonly bool[] mostra = new bool[5];

		[Category("Ajustes")]
		public string Titulo { get { return titulo.Text; } set { titulo.Text = value; } }

		[Category("Ajustes")]
		public double ColunaCampo { get { return coluna; } set { coluna = value; Arruma(); } }

		[Category("Ajustes")]
		public string Rotulo_CMD_HABILITA { get { return l_CMD_HABILITA.Text; } set { l_CMD_HABILITA.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_CMD_HABILITA { get { return mostra[0]; } set { mostra[0] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Rotulo_STP_LIMITE_FAIXA_1 { get { return l_STP_LIMITE_FAIXA_1.Text; } set { l_STP_LIMITE_FAIXA_1.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_LIMITE_FAIXA_1 { get { return mostra[1]; } set { mostra[1] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_LIMITE_FAIXA_1 { get { return c_STP_LIMITE_FAIXA_1.Suffix; } set { c_STP_LIMITE_FAIXA_1.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_LIMITE_FAIXA_2 { get { return l_STP_LIMITE_FAIXA_2.Text; } set { l_STP_LIMITE_FAIXA_2.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_LIMITE_FAIXA_2 { get { return mostra[2]; } set { mostra[2] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_LIMITE_FAIXA_2 { get { return c_STP_LIMITE_FAIXA_2.Suffix; } set { c_STP_LIMITE_FAIXA_2.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_LIMITE_FAIXA_3 { get { return l_STP_LIMITE_FAIXA_3.Text; } set { l_STP_LIMITE_FAIXA_3.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_LIMITE_FAIXA_3 { get { return mostra[3]; } set { mostra[3] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_LIMITE_FAIXA_3 { get { return c_STP_LIMITE_FAIXA_3.Suffix; } set { c_STP_LIMITE_FAIXA_3.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_LIMITE_FAIXA_4 { get { return l_STP_LIMITE_FAIXA_4.Text; } set { l_STP_LIMITE_FAIXA_4.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_LIMITE_FAIXA_4 { get { return mostra[4]; } set { mostra[4] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_LIMITE_FAIXA_4 { get { return c_STP_LIMITE_FAIXA_4.Suffix; } set { c_STP_LIMITE_FAIXA_4.Suffix = value; } }

		// O EndInit devolve os campos a posicao de projeto (DesignMatrix): reaplica o arranjo depois dele
		public override void EndInit() { base.EndInit(); Arruma(); }
		protected override void OnInitializationCompleted() { base.OnInitializationCompleted(); Arruma(); }

		// Reposiciona as linhas visiveis (sem buraco) e ajusta a altura do fundo (area de clique)
		void Arruma()
		{
			if (linhas == null) return;
			// depois do EndInit os campos (Group) ficam nas coordenadas de quem embute o painel: soma a origem do painel
			double ox = 0D, oy = 0D;
			if (Initialized) { ox = DesignMatrix.M31; oy = DesignMatrix.M32; }
			int k = 0;
			for (int i = 0; i < linhas.Length; i++)
			{
				Linha l = linhas[i];
				bool v = mostra[i];
				l.Rotulo.Visible = v;
				double y = 40 + 34 * k;
				l.Rotulo.Location = new NxtControl.Drawing.PointF(10D, y + 6D);
				Posiciona(l.Campo, l.Botao, coluna + ox, y + oy, v);
				if (v) k++;
			}
			fundo.Bounds = new NxtControl.Drawing.RectF(0F, 0F, (float)(coluna + 120D), (float)(40 + 34 * k + 6));
			sep.Bounds = new NxtControl.Drawing.RectF(0F, 0F, (float)(coluna + 120D), 1F);
		}

		static void Posiciona(object campo, bool botao, double x, double y, bool visivel)
		{
			GroupShape s = campo as GroupShape;
			if (s == null) return;
			s.Visible = visivel;
			// DesignMatrix e Location so valem na criacao; depois o campo anda com Move (deslocamento inteiro)
			NxtControl.Drawing.RectF b = s.Bounds;
			int dx = (int)Math.Round(x - b.X), dy = (int)Math.Round((botao ? y : y + 2D) - b.Y);
			if (dx != 0 || dy != 0) s.Move(dx, dy);
		}
	}
}
