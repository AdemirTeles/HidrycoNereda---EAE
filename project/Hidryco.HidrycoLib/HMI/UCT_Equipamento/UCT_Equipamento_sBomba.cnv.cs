/*
 * Hidryco - UCT_Equipamento - sBomba
 * Simbolo da bomba da UCT no padrao do Motor_Generico (cores HidrycoColors, falha de comunicacao, A/M, nome).
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
{
	public partial class sBomba : NxtControl.GuiFramework.HMISymbol
	{
		public sBomba()
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


		// cores do padrao da HidrycoLib (Graphics.Bomba/Motor): 0 desligado, 1 ligado, 2 falha, 3 manutencao, outro = desconhecido
		static NxtControl.Drawing.Color Cor(int a)
		{
			switch (a)
			{
				case 0: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Desligado;
				case 1: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Ligado;
				case 2: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Falha;
				case 3: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Manutencao;
				default: return Hidryco.HidrycoLib.SupportClasses.HidrycoColors.Unknown;
			}
		}


		void Atualiza()
		{
			// defeito vindo da UCT (40081) pinta como falha; sem comunicacao (4) = cor desconhecida + icone
			int a = (defeito && anim != 4) ? 2 : anim;
			NxtControl.Drawing.Color c = Cor(a);
			bomba1.Animacao = a;
			falhaCom.Visible = anim == 4;
			textoManut.Visible = anim == 3;
		}

	}
}
