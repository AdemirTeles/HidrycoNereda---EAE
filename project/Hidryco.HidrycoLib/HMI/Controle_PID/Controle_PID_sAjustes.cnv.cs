/*
 * Hidryco - Controle_PID - sAjustes
 * Painel de ajustes para embutir no faceplate do processo (TagName = nome da instancia do sub-CAT).
 * Rotulos, unidades e linhas visiveis por propriedade; as linhas visiveis sobem para nao deixar buraco.
 */

using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_PID
{
	public partial class sAjustes : NxtControl.GuiFramework.HMISymbol
	{
		public sAjustes()
		{
			InitializeComponent();
			linhas = new Linha[] {
				new Linha(l_CMD_HABILITA, c_CMD_HABILITA, true),
				new Linha(l_STP_DESEJADO, c_STP_DESEJADO, false),
				new Linha(l_STP_PARAMETRO_KP, c_STP_PARAMETRO_KP, false),
				new Linha(l_STP_PARAMETRO_KI, c_STP_PARAMETRO_KI, false),
				new Linha(l_STP_PARAMETRO_KD, c_STP_PARAMETRO_KD, false),
				new Linha(l_STP_MINIMO, c_STP_MINIMO, false),
				new Linha(l_STP_MAXIMO, c_STP_MAXIMO, false) };
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
		readonly bool[] mostra = new bool[7];

		[Category("Ajustes")]
		public string Titulo { get { return titulo.Text; } set { titulo.Text = value; } }

		[Category("Ajustes")]
		public double ColunaCampo { get { return coluna; } set { coluna = value; Arruma(); } }

		[Category("Ajustes")]
		public string Rotulo_CMD_HABILITA { get { return l_CMD_HABILITA.Text; } set { l_CMD_HABILITA.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_CMD_HABILITA { get { return mostra[0]; } set { mostra[0] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Rotulo_STP_DESEJADO { get { return l_STP_DESEJADO.Text; } set { l_STP_DESEJADO.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_DESEJADO { get { return mostra[1]; } set { mostra[1] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_DESEJADO { get { return c_STP_DESEJADO.Suffix; } set { c_STP_DESEJADO.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_PARAMETRO_KP { get { return l_STP_PARAMETRO_KP.Text; } set { l_STP_PARAMETRO_KP.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_PARAMETRO_KP { get { return mostra[2]; } set { mostra[2] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_PARAMETRO_KP { get { return c_STP_PARAMETRO_KP.Suffix; } set { c_STP_PARAMETRO_KP.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_PARAMETRO_KI { get { return l_STP_PARAMETRO_KI.Text; } set { l_STP_PARAMETRO_KI.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_PARAMETRO_KI { get { return mostra[3]; } set { mostra[3] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_PARAMETRO_KI { get { return c_STP_PARAMETRO_KI.Suffix; } set { c_STP_PARAMETRO_KI.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_PARAMETRO_KD { get { return l_STP_PARAMETRO_KD.Text; } set { l_STP_PARAMETRO_KD.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_PARAMETRO_KD { get { return mostra[4]; } set { mostra[4] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_PARAMETRO_KD { get { return c_STP_PARAMETRO_KD.Suffix; } set { c_STP_PARAMETRO_KD.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_MINIMO { get { return l_STP_MINIMO.Text; } set { l_STP_MINIMO.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_MINIMO { get { return mostra[5]; } set { mostra[5] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_MINIMO { get { return c_STP_MINIMO.Suffix; } set { c_STP_MINIMO.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_MAXIMO { get { return l_STP_MAXIMO.Text; } set { l_STP_MAXIMO.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_MAXIMO { get { return mostra[6]; } set { mostra[6] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_MAXIMO { get { return c_STP_MAXIMO.Suffix; } set { c_STP_MAXIMO.Suffix = value; } }

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
