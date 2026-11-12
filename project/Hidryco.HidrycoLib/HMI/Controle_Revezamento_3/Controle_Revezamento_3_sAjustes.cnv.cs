/*
 * Hidryco - Controle_Revezamento_3 - sAjustes
 * Painel de ajustes para embutir no faceplate do processo (TagName = nome da instancia do sub-CAT).
 * Rotulos, unidades e linhas visiveis por propriedade; as linhas visiveis sobem para nao deixar buraco.
 */

using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Revezamento_3
{
	public partial class sAjustes : NxtControl.GuiFramework.HMISymbol
	{
		public sAjustes()
		{
			InitializeComponent();
			linhas = new Linha[] {
				new Linha(l_CMD_HABILITA, c_CMD_HABILITA, true),
				new Linha(l_STP_TEMPO_B1, c_STP_TEMPO_B1, false),
				new Linha(l_STP_TEMPO_B2, c_STP_TEMPO_B2, false),
				new Linha(l_STP_TEMPO_B3, c_STP_TEMPO_B3, false),
				new Linha(l_CMD_SELECAO_BOMBA, null, false) };
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
		public string Rotulo_STP_TEMPO_B1 { get { return l_STP_TEMPO_B1.Text; } set { l_STP_TEMPO_B1.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_TEMPO_B1 { get { return mostra[1]; } set { mostra[1] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_TEMPO_B1 { get { return c_STP_TEMPO_B1.Suffix; } set { c_STP_TEMPO_B1.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_TEMPO_B2 { get { return l_STP_TEMPO_B2.Text; } set { l_STP_TEMPO_B2.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_TEMPO_B2 { get { return mostra[2]; } set { mostra[2] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_TEMPO_B2 { get { return c_STP_TEMPO_B2.Suffix; } set { c_STP_TEMPO_B2.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_STP_TEMPO_B3 { get { return l_STP_TEMPO_B3.Text; } set { l_STP_TEMPO_B3.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_STP_TEMPO_B3 { get { return mostra[3]; } set { mostra[3] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Unidade_STP_TEMPO_B3 { get { return c_STP_TEMPO_B3.Suffix; } set { c_STP_TEMPO_B3.Suffix = value; } }

		[Category("Ajustes")]
		public string Rotulo_CMD_SELECAO_BOMBA { get { return l_CMD_SELECAO_BOMBA.Text; } set { l_CMD_SELECAO_BOMBA.Text = value; } }

		[Category("Ajustes")]
		public bool Mostra_CMD_SELECAO_BOMBA { get { return mostra[4]; } set { mostra[4] = value; Arruma(); } }

		[Category("Ajustes")]
		public string Nome_Selecao0 { get { return b_sel0.Text; } set { b_sel0.Text = value; } }

		[Category("Ajustes")]
		public string Nome_Selecao1 { get { return b_sel1.Text; } set { b_sel1.Text = value; } }

		[Category("Ajustes")]
		public string Nome_Selecao2 { get { return b_sel2.Text; } set { b_sel2.Text = value; } }

		[Category("Ajustes")]
		public string Nome_Selecao3 { get { return b_sel3.Text; } set { b_sel3.Text = value; } }

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
				if (l.Rotulo == l_CMD_SELECAO_BOMBA) PosicionaSel(y, v);
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

		// ---- bomba principal por botoes: so 1, 2 ou 3 (grava CMD_SELECAO_BOMBA; o destaque segue a tag).
		//      A selecionada e a principal ao escolher e sempre que as bombas partem de novo; o revezamento troca a partir dela.
		//      O botao "Automatica" (0) saiu: fica escondido; 0 gravado de antes vale como 1 (na logica e no destaque).
		short sel;
		DrawnButton[] BotoesSel() { return new DrawnButton[] { b_sel0, b_sel1, b_sel2, b_sel3 }; }
		static readonly float[] SEL_X = { 140F, 140F, 204F, 268F };
		static readonly float[] SEL_W = { 88F, 60F, 60F, 60F };
		void PosicionaSel(double y, bool v)
		{
			DrawnButton[] b = BotoesSel();
			for (int i = 0; i < b.Length; i++)
			{
				b[i].Bounds = new NxtControl.Drawing.RectF(SEL_X[i], (float)y, SEL_W[i], 28F);
				b[i].Visible = v && i > 0;
			}
		}
		void MarcaSel()
		{
			DrawnButton[] b = BotoesSel();
			for (int i = 0; i < b.Length; i++)
			{
				bool on = (i == (sel >= 1 && sel <= 3 ? sel : 1));
				b[i].BrushColor = on ? new NxtControl.Drawing.Color(96, 96, 96) : new NxtControl.Drawing.Color(208, 208, 208);
				b[i].TextColor = on ? new NxtControl.Drawing.Color(255, 255, 255) : new NxtControl.Drawing.Color(0, 0, 0);
			}
		}
		void SelValueChanged(object sender, ValueChangedEventArgs e) { sel = Convert.ToInt16(e.Value); MarcaSel(); }
		void BtnSel0Click(object sender, EventArgs e) { FireEvent_E_CMD_SELECAO_BOMBA((System.Int16)0); }
		void BtnSel1Click(object sender, EventArgs e) { FireEvent_E_CMD_SELECAO_BOMBA((System.Int16)1); }
		void BtnSel2Click(object sender, EventArgs e) { FireEvent_E_CMD_SELECAO_BOMBA((System.Int16)2); }
		void BtnSel3Click(object sender, EventArgs e) { FireEvent_E_CMD_SELECAO_BOMBA((System.Int16)3); }
	}
}
