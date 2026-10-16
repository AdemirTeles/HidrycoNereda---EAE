/*
 * Hidryco - UCT_Equipamento - fpDefault
 * ISA-101: estado, horimetro e comandos do equipamento da UCT (liga manual, intermitente, reversao, velocidade). Em automatico do subsistema os comandos so indicam.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.UCT_Equipamento
{
	public partial class fpDefault : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpDefault()
		{
			InitializeComponent();
			Atualiza();
		}
		const float YI = 180F, YR = 250F, YV = 320F;

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


		static void Selecao(DrawnButton b, bool sel)
		{
			b.BrushColor = sel ? new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))) : new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215)));
			b.TextColor = sel ? new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))) : new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			b.TextColorMouseDown = b.TextColor;
		}
		static string TextoEstado(short a)
		{
			switch (a) { case 1: return "LIGADO"; case 2: return "FALHA"; case 3: return "MANUTENÇÃO"; case 4: return "SEM COMUNICAÇÃO"; default: return "DESLIGADO"; }
		}


		void Atualiza()
		{
			textoEstado.Text = defeito && anim != 2 && anim != 4 ? "DEFEITO" : TextoEstado(anim);
			caixaEstado.BrushColor = anim == 1 ? new NxtControl.Drawing.Color(64, 64, 64) : new NxtControl.Drawing.Color(255, 255, 255);
			textoModo.Text = auto ? "Subsistema em automático (comandos só indicam)" : "Subsistema em manual";
			tituloComando.Text = auto ? "Comando manual (em automático: só indica)" : "Comando manual";
			bool liga = auto ? anim == 1 : fbLiga;
			Selecao(btnLigar, liga); Selecao(btnDesligar, !liga);
			// so aparecem as funcoes que o equipamento tem; as linhas sobem para nao deixar buraco
			float y = YI;
			tituloInt.Visible = cfgInt; btnIntOff.Visible = cfgInt; btnIntOn.Visible = cfgInt;
			if (cfgInt) { Linha(tituloInt, btnIntOff, btnIntOn, y); y += 70F; }
			Selecao(btnIntOn, fbInt); Selecao(btnIntOff, !fbInt);
			tituloRev.Visible = cfgRev; btnRevOff.Visible = cfgRev; btnRevOn.Visible = cfgRev;
			if (cfgRev) { Linha(tituloRev, btnRevOff, btnRevOn, y); y += 70F; }
			Selecao(btnRevOn, fbRev); Selecao(btnRevOff, !fbRev);
			tituloVel.Visible = cfgVel; rotVelAtual.Visible = cfgVel; vVel.Visible = cfgVel; rotVelRef.Visible = cfgVel; tVel.Visible = cfgVel;
			if (cfgVel)
			{
				tituloVel.Location = new NxtControl.Drawing.PointF(20F, y);
				rotVelAtual.Location = new NxtControl.Drawing.PointF(20F, y + 28F);
				rotVelRef.Location = new NxtControl.Drawing.PointF(170F, y + 28F);
				vVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 1D, 64D, y + 23F);
				tVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 220D, y + 22F);
			}
		}
		static void Linha(FreeText t, DrawnButton a, DrawnButton b, float y)
		{
			t.Location = new NxtControl.Drawing.PointF(20F, y);
			a.Bounds = new NxtControl.Drawing.RectF(20F, y + 22F, 150F, 34F);
			b.Bounds = new NxtControl.Drawing.RectF(190F, y + 22F, 150F, 34F);
		}
		void BtnLigarClick(object sender, EventArgs e) { if (!auto) FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(true); }
		void BtnDesligarClick(object sender, EventArgs e) { if (!auto) FireEvent_E_ATUALIZA_COMANDO_LIGA_MANUAL(false); }
		void BtnIntOnClick(object sender, EventArgs e) { FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(true); }
		void BtnIntOffClick(object sender, EventArgs e) { FireEvent_E_ATUALIZA_COMANDO_LIGA_INTERMITENTE(false); }
		void BtnRevOnClick(object sender, EventArgs e) { FireEvent_E_ATUALIZA_HABILITA_REVERSAO(true); }
		void BtnRevOffClick(object sender, EventArgs e) { FireEvent_E_ATUALIZA_HABILITA_REVERSAO(false); }

	}
}
