/*
 * Hidryco - Subestacao - fpComandos
 * Comandos de abrir/fechar dos Masterpact 1Q1, 1Q0 e 1Q2 com intertravamentos e confirmacao.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Subestacao
{
	public partial class fpComandos : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpComandos()
		{
			InitializeComponent();
			Atualiza();
		}

		static readonly NxtControl.Drawing.Color corFechado = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
		static readonly NxtControl.Drawing.Color corAberto = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(140)), ((byte)(60)));
		static readonly NxtControl.Drawing.Color corIndef = new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190)));
		static void Cor(Rectangle r, int e) { r.Brush = new NxtControl.Drawing.Brush(e == 2 ? corFechado : e == 1 ? corAberto : corIndef); }
		static bool B(object v) { return v != null && Convert.ToBoolean(v); }
		static short S(object v) { return v == null ? (short)0 : Convert.ToInt16(v); }
		static string Estado(short e) { switch (e) { case 1: return "Aberto"; case 2: return "Fechado"; case 3: return "Posição indefinida"; default: return "Sem informação"; } }
		void Muda(object s, ValueChangedEventArgs e) { Atualiza(); }
		short pendente;

		// Atualiza uma coluna; "outros" = estados dos dois outros Masterpact (fechar so com um deles aberto)
		void Coluna(string nome, short est, bool local, bool remoto, bool pronto, bool mola, bool semFalha, bool pA, bool pF, bool cA, bool cF, short o1, short o2, string o1n, string o2n,
		            Rectangle b, FreeText te, FreeText vL, FreeText vP, FreeText vC, FreeText vSF, FreeText tc, FreeText tm, DrawnButton bA, DrawnButton bF, bool remota)
		{
			Cor(b, remota ? 0 : est);
			te.Text = remota ? "Sem informação" : Estado(est);
			vL.Text = remota ? "—" : local ? "LOCAL" : remoto ? "Remoto" : "—";
			vP.Text = remota ? "—" : pronto ? "Sim" : "Não";
			vC.Text = remota ? "—" : mola ? "Carregada" : "Descarregada";
			vSF.Text = remota ? "—" : semFalha ? "Normal" : "DESARMADO";
			tc.Text = cA ? "Abrindo..." : cF ? "Fechando..." : "";
			bA.Enabled = pA && !cA && !cF;
			bF.Enabled = pF && !cA && !cF;
			string m = "";
			if (!remota && est == 1 && !pF)
			{
				if (local || !remoto) m += "\r\n- em local";
				if (!pronto) m += "\r\n- não está pronto para fechar";
				if (!mola) m += "\r\n- mola descarregada";
				if (!semFalha) m += "\r\n- desarmado";
				if (o1 != 1 && o2 != 1) m += "\r\n- " + o1n + " e " + o2n + " fechados";
				m = m.Length > 0 ? "Fechar bloqueado:" + m : "";
			}
			else if (!remota && est == 2 && !pA) m = "Abrir bloqueado: em local";
			tm.Text = m;
		}

		void Atualiza()
		{
			bool remota = B(xRemota.Value);
			tRemota.Text = remota ? "Remota 1 sem comunicação: comandos bloqueados" : "";
			short e1 = S(xE_1Q1.Value), e0 = S(xE_1Q0.Value), e2 = S(xE_1Q2.Value);

			Coluna("1Q1", e1, B(xL_1Q1.Value), B(xR_1Q1.Value), B(xP_1Q1.Value), B(xC_1Q1.Value), B(xSF_1Q1.Value), B(xPA_1Q1.Value), B(xPF_1Q1.Value), B(xCA_1Q1.Value), B(xCF_1Q1.Value), e0, e2, "1Q0", "1Q2", b1Q1, e1Q1, vL_1Q1, vP_1Q1, vC_1Q1, vSF_1Q1, c1Q1, m1Q1, btnAbrir1Q1, btnFechar1Q1, remota);
			Coluna("1Q0", e0, B(xL_1Q0.Value), B(xR_1Q0.Value), B(xP_1Q0.Value), B(xC_1Q0.Value), B(xSF_1Q0.Value), B(xPA_1Q0.Value), B(xPF_1Q0.Value), B(xCA_1Q0.Value), B(xCF_1Q0.Value), e1, e2, "1Q1", "1Q2", b1Q0, e1Q0, vL_1Q0, vP_1Q0, vC_1Q0, vSF_1Q0, c1Q0, m1Q0, btnAbrir1Q0, btnFechar1Q0, remota);
			Coluna("1Q2", e2, B(xL_1Q2.Value), B(xR_1Q2.Value), B(xP_1Q2.Value), B(xC_1Q2.Value), B(xSF_1Q2.Value), B(xPA_1Q2.Value), B(xPF_1Q2.Value), B(xCA_1Q2.Value), B(xCF_1Q2.Value), e0, e1, "1Q0", "1Q1", b1Q2, e1Q2, vL_1Q2, vP_1Q2, vC_1Q2, vSF_1Q2, c1Q2, m1Q2, btnAbrir1Q2, btnFechar1Q2, remota);
		}

		void BtnCmdClick(object sender, EventArgs e)
		{
			string t;
			if (sender == btnAbrir1Q1) { pendente = 1; t = "ABRIR o 1Q1 (entrada da barra A)?\r\nA barra A fica sem alimentação, a não ser pelo 1Q0."; }
			else if (sender == btnFechar1Q1) { pendente = 2; t = "FECHAR o 1Q1 (entrada da barra A)?"; }
			else if (sender == btnAbrir1Q0) { pendente = 3; t = "ABRIR o 1Q0 (acoplamento das barras)?"; }
			else if (sender == btnFechar1Q0) { pendente = 4; t = "FECHAR o 1Q0 (acoplamento das barras)?\r\nUma QTAM passa a alimentar as duas barras."; }
			else if (sender == btnAbrir1Q2) { pendente = 5; t = "ABRIR o 1Q2 (entrada da barra B)?\r\nA barra B fica sem alimentação, a não ser pelo 1Q0."; }
			else { pendente = 6; t = "FECHAR o 1Q2 (entrada da barra B)?"; }
			confTexto.Text = t;
			Confirmacao(true);
		}
		void Confirmacao(bool v) { confFundo.Visible = v; confTexto.Visible = v; btnConfirmar.Visible = v; btnCancelar.Visible = v; }
		void BtnConfirmarClick(object sender, EventArgs e) { Confirmacao(false); if (pendente > 0) FireEvent_E_COMANDO(pendente); pendente = 0; }
		void BtnCancelarClick(object sender, EventArgs e) { Confirmacao(false); pendente = 0; }

	}
}
