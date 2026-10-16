/*
 * Hidryco - UCT_Equipamento - sDefault
 * ISA-101: equipamento da UCT - estado em texto e caixa cheia/vazada; A = subsistema em automatico.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			InitializeComponent();
			Atualiza();
		}

		short anim;
		void V_animChanged(object s, ValueChangedEventArgs e) { anim = Convert.ToInt16(e.Value); Atualiza(); }
		bool defeito;
		void V_defeitoChanged(object s, ValueChangedEventArgs e) { defeito = Convert.ToBoolean(e.Value); Atualiza(); }
		bool auto;
		void V_autoChanged(object s, ValueChangedEventArgs e) { auto = Convert.ToBoolean(e.Value); Atualiza(); }
		bool fbLiga;
		void V_fbLigaChanged(object s, ValueChangedEventArgs e) { fbLiga = Convert.ToBoolean(e.Value); Atualiza(); }
		bool fbInt;
		void V_fbIntChanged(object s, ValueChangedEventArgs e) { fbInt = Convert.ToBoolean(e.Value); Atualiza(); }
		bool fbRev;
		void V_fbRevChanged(object s, ValueChangedEventArgs e) { fbRev = Convert.ToBoolean(e.Value); Atualiza(); }
		bool cfgVel;
		void V_cfgVelChanged(object s, ValueChangedEventArgs e) { cfgVel = Convert.ToBoolean(e.Value); Atualiza(); }
		bool cfgInt;
		void V_cfgIntChanged(object s, ValueChangedEventArgs e) { cfgInt = Convert.ToBoolean(e.Value); Atualiza(); }
		bool cfgRev;
		void V_cfgRevChanged(object s, ValueChangedEventArgs e) { cfgRev = Convert.ToBoolean(e.Value); Atualiza(); }


		static string TextoEstado(short a)
		{
			switch (a) { case 1: return "LIGADO"; case 2: return "FALHA"; case 3: return "MANUTENÇÃO"; case 4: return "SEM COMUNIC."; default: return "DESLIGADO"; }
		}
		void Atualiza()
		{
			textoEstado.Text = defeito && anim != 2 && anim != 4 ? "DEFEITO" : TextoEstado(anim);
			caixaEstado.BrushColor = anim == 1 ? new NxtControl.Drawing.Color(64, 64, 64) : new NxtControl.Drawing.Color(255, 255, 255);
			caixaEstado.Visible = anim != 4;
			textoModo.Visible = auto;
		}

	}
}
