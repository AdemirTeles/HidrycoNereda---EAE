/*
 * Criado pelo gerador fp_modo (padrao Hidryco).
 * Caixa L/R + M/A igual a dos simbolos da HidrycoLib.
 *   R/L: Remote = oRemoteSelect do painel local (TRUE = remoto; FALSE = local, o CAT entra em LocalMode).
 *   M/A: mesma decodificacao do CurrOwnerDecode (Prog = 16#8 ou 16#4 -> A; Oper = 16#10 ou 16#40 -> M).
 */
using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ActState
{
	public partial class sModo : NxtControl.GuiFramework.HMISymbol
	{
		bool prog, oper;
		public sModo()
		{
			InitializeComponent();
		}
		static bool B(ValueChangedEventArgs e) { return e.Value != null && Convert.ToBoolean(e.Value); }
		void rxRemoteChanged(object s, ValueChangedEventArgs e) { tRL.Text = B(e) ? "R" : "L"; }
		void rxProgChanged(object s, ValueChangedEventArgs e) { prog = B(e); Modo(); }
		void rxOperChanged(object s, ValueChangedEventArgs e) { oper = B(e); Modo(); }
		void Modo() { tMA.Text = prog ? "A" : (oper ? "M" : "-"); }
	}
}
