/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 14/09/2026
 * Tempo: 09:35
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.IO_DQ32
{
	/// <summary>
	/// Description of sDefault.
	/// </summary>
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
		}

		// ---- forcamento das saidas pela IHM ----
		// mascaras em uso no CLP (bit k da palavra p = saida 16*p + k); LIGA = forcada ligada, DESL = forcada desligada
		ushort l0, l1, d0, d1;
		bool forcado;

		void MascaraValueChanged(object sender, ValueChangedEventArgs e)
		{
			if (sender == xForcado) forcado = Convert.ToBoolean(e.Value);
			else if (sender == xL0) l0 = Convert.ToUInt16(e.Value);
			else if (sender == xL1) l1 = Convert.ToUInt16(e.Value);
			else if (sender == xD0) d0 = Convert.ToUInt16(e.Value);
			else if (sender == xD1) d1 = Convert.ToUInt16(e.Value);
			Marcas();
		}

		static bool Bit(ushort w, int b) { return (w & (1 << b)) != 0; }

		void Marcas()
		{
			FreeText[] f = { f0, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15,
			                 f16, f17, f18, f19, f20, f21, f22, f23, f24, f25, f26, f27, f28, f29, f30, f31 };
			for (int k = 0; k < 32; k++)
			{
				ushort l = k < 16 ? l0 : l1, d = k < 16 ? d0 : d1; int b = k % 16;
				f[k].Text = Bit(d, b) ? "F-DESL" : (Bit(l, b) ? "F-LIG" : "");
			}
			avisoForcado.Visible = forcado || (l0 | l1 | d0 | d1) != 0;
		}

		// clique: normal -> forcar LIGADA -> forcar DESLIGADA -> normal (manda as 4 mascaras)
		void Alterna(int k)
		{
			int b = k % 16; ushort m = (ushort)(1 << b);
			ushort l = k < 16 ? l0 : l1, d = k < 16 ? d0 : d1;
			if (Bit(d, b)) { d = (ushort)(d & ~m); }                         // forcada desligada -> normal
			else if (Bit(l, b)) { l = (ushort)(l & ~m); d = (ushort)(d | m); }  // forcada ligada -> forcada desligada
			else { l = (ushort)(l | m); }                                      // normal -> forcada ligada
			if (k < 16) { l0 = l; d0 = d; } else { l1 = l; d1 = d; }
			FireEvent_E_FORCA(l0, l1, d0, d1);
			Marcas();
		}

		void B0Click(object sender, EventArgs e) { Alterna(0); }
		void B1Click(object sender, EventArgs e) { Alterna(1); }
		void B2Click(object sender, EventArgs e) { Alterna(2); }
		void B3Click(object sender, EventArgs e) { Alterna(3); }
		void B4Click(object sender, EventArgs e) { Alterna(4); }
		void B5Click(object sender, EventArgs e) { Alterna(5); }
		void B6Click(object sender, EventArgs e) { Alterna(6); }
		void B7Click(object sender, EventArgs e) { Alterna(7); }
		void B8Click(object sender, EventArgs e) { Alterna(8); }
		void B9Click(object sender, EventArgs e) { Alterna(9); }
		void B10Click(object sender, EventArgs e) { Alterna(10); }
		void B11Click(object sender, EventArgs e) { Alterna(11); }
		void B12Click(object sender, EventArgs e) { Alterna(12); }
		void B13Click(object sender, EventArgs e) { Alterna(13); }
		void B14Click(object sender, EventArgs e) { Alterna(14); }
		void B15Click(object sender, EventArgs e) { Alterna(15); }
		void B16Click(object sender, EventArgs e) { Alterna(16); }
		void B17Click(object sender, EventArgs e) { Alterna(17); }
		void B18Click(object sender, EventArgs e) { Alterna(18); }
		void B19Click(object sender, EventArgs e) { Alterna(19); }
		void B20Click(object sender, EventArgs e) { Alterna(20); }
		void B21Click(object sender, EventArgs e) { Alterna(21); }
		void B22Click(object sender, EventArgs e) { Alterna(22); }
		void B23Click(object sender, EventArgs e) { Alterna(23); }
		void B24Click(object sender, EventArgs e) { Alterna(24); }
		void B25Click(object sender, EventArgs e) { Alterna(25); }
		void B26Click(object sender, EventArgs e) { Alterna(26); }
		void B27Click(object sender, EventArgs e) { Alterna(27); }
		void B28Click(object sender, EventArgs e) { Alterna(28); }
		void B29Click(object sender, EventArgs e) { Alterna(29); }
		void B30Click(object sender, EventArgs e) { Alterna(30); }
		void B31Click(object sender, EventArgs e) { Alterna(31); }
	}
}
