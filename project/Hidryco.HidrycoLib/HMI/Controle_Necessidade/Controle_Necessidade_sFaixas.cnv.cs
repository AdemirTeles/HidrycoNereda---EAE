/*
 * Hidryco - Controle_Necessidade - sFaixas
 * Faixas de nivel para o operador: barra 0-100 %, cada limite com valor e seta (verde = liga, vermelha = desliga)
 * e o nivel atual. Tudo posicionado pelos valores das tags (acompanha IHM e SCADA); textos das faixas por propriedade.
 */

using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Controle_Necessidade
{
	public partial class sFaixas : NxtControl.GuiFramework.HMISymbol
	{
		public sFaixas()
		{
			InitializeComponent();
			lins = new Line[] { lin0, lin1, lin2, lin3 };
			vals = new FreeText[] { val0, val1, val2, val3 };
			setas = new Polygon[] { seta0, seta1, seta2, seta3 };
			txts = new FreeText[] { txt0, txt1, txt2, txt3 };
			Atualiza();
		}

		[Category("Ajustes")]
		public string Texto_Faixa1 { get { return txt0.Text; } set { txt0.Text = value; } }

		[Category("Ajustes")]
		public string Texto_Faixa2 { get { return txt1.Text; } set { txt1.Text = value; } }

		[Category("Ajustes")]
		public string Texto_Faixa3 { get { return txt2.Text; } set { txt2.Text = value; } }

		[Category("Ajustes")]
		public string Texto_Faixa4 { get { return txt3.Text; } set { txt3.Text = value; } }

		Line[] lins; FreeText[] vals; Polygon[] setas; FreeText[] txts;
		readonly float[] f = { 20F, 40F, 50F, 70F };     // padrao do tipo ate chegar o valor do CLP
		float niv; bool temNiv, hab = true;
		static readonly NxtControl.Drawing.Color VERDE = new NxtControl.Drawing.Color(40, 170, 60);
		static readonly NxtControl.Drawing.Color VERMELHO = new NxtControl.Drawing.Color(210, 50, 40);
		static readonly NxtControl.Drawing.Color CINZA = new NxtControl.Drawing.Color(170, 170, 170);

		void F1ValueChanged(object sender, ValueChangedEventArgs e) { f[0] = Convert.ToSingle(e.Value); Atualiza(); }
		void F2ValueChanged(object sender, ValueChangedEventArgs e) { f[1] = Convert.ToSingle(e.Value); Atualiza(); }
		void F3ValueChanged(object sender, ValueChangedEventArgs e) { f[2] = Convert.ToSingle(e.Value); Atualiza(); }
		void F4ValueChanged(object sender, ValueChangedEventArgs e) { f[3] = Convert.ToSingle(e.Value); Atualiza(); }
		void NivValueChanged(object sender, ValueChangedEventArgs e) { niv = Convert.ToSingle(e.Value); temNiv = true; Atualiza(); }
		void HabValueChanged(object sender, ValueChangedEventArgs e) { hab = Convert.ToBoolean(e.Value); Atualiza(); }

		// altura na barra para um valor em % (0 embaixo, 100 em cima)
		static float Y(float v)
		{
			if (v < 0F) v = 0F;
			if (v > 100F) v = 100F;
			return 10F + 176F - 176F * v / 100F;
		}

		void Atualiza()
		{
			if (lins == null) return;
			for (int k = 0; k < 4; k++)
			{
				float y = Y(f[k]);
				lins[k].StartPoint = new NxtControl.Drawing.PointF(40D, y);
				lins[k].EndPoint = new NxtControl.Drawing.PointF(118D, y);
				vals[k].Text = f[k].ToString("0.#") + " %";
				vals[k].Location = new NxtControl.Drawing.PointF(0D, y - 7F);
				setas[k].Location = new NxtControl.Drawing.PointF(120D, y - 7F);
				setas[k].BrushColor = hab ? (k >= 2 ? VERDE : VERMELHO) : CINZA;
				txts[k].Location = new NxtControl.Drawing.PointF(120D + 20D, y - 7F);
			}
			nivel.Visible = temNiv; nivelTxt.Visible = temNiv;
			if (temNiv)
			{
				float yn = Y(niv);
				nivel.Bounds = new NxtControl.Drawing.RectF(70F - 4F, yn - 2F, 22F + 8F, 4F);
				nivelTxt.Text = niv.ToString("0") + " %";
				nivelTxt.Location = new NxtControl.Drawing.PointF(70D - 30D, yn - 7F);
			}
		}
	}
}
