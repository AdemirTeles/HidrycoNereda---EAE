/*
 * Hidryco - Sensor_Generico - sLiquido
 * Liquido dentro do desenho do tanque: sobe de baixo para cima conforme STS_PORCENTAGEM (calculada no CLP).
 * Sensor desabilitado ou em falha: tanque vazio (nao mostra valor invalido).
 * Tamanho 100 x 100: na tela, escalar pelo DesignMatrix para a area interna do tanque.
 */

using System;
using System.ComponentModel;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Generico
{
	public partial class sLiquido : NxtControl.GuiFramework.HMISymbol
	{
		public enum FluidoOption
		{
			Agua,
			Esgoto,
			Lodo
		}

		FluidoOption _fluido = FluidoOption.Agua;

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Fluido")]
		public FluidoOption _iFluido
		{
			get { return _fluido; }
			set { _fluido = value; Atualiza(); }
		}

		public sLiquido()
		{
			InitializeComponent();
			Atualiza();
		}

		// ---- dados recebidos da logica (Execute invisiveis)
		float pct;
		short estado = 4;
		bool falhaAtiva;
		void PctValueChanged(object sender, ValueChangedEventArgs e) { pct = Convert.ToSingle(e.Value); Atualiza(); }
		void EstadoValueChanged(object sender, ValueChangedEventArgs e) { estado = Convert.ToInt16(e.Value); Atualiza(); }
		void FalhaAtivaValueChanged(object sender, ValueChangedEventArgs e) { falhaAtiva = Convert.ToBoolean(e.Value); Atualiza(); }

		static readonly NxtControl.Drawing.Color AGUA = new NxtControl.Drawing.Color(120, 180, 230);
		static readonly NxtControl.Drawing.Color ESGOTO = new NxtControl.Drawing.Color(150, 135, 100);
		static readonly NxtControl.Drawing.Color LODO = new NxtControl.Drawing.Color(140, 95, 45);

		void Atualiza()
		{
			bool ok = estado != 4 && !falhaAtiva;
			float p = ok ? pct : 0F;
			if (p < 0F) p = 0F;
			if (p > 100F) p = 100F;
			liquido.Brush = new NxtControl.Drawing.Brush(_fluido == FluidoOption.Lodo ? LODO : (_fluido == FluidoOption.Esgoto ? ESGOTO : AGUA));
			liquido.FillPercent = p;
		}
	}
}
