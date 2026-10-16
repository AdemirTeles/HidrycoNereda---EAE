/*
 * Hidryco - Subestacao - fpCargas
 * Cargas liberadas para operar com a planta nos geradores. Raio: contorno = nao liberada; cinza = liberada (planta na rede); vermelho = liberada e planta nos geradores.
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Subestacao
{
	public partial class fpCargas : NxtControl.GuiFramework.HMIFaceplate
	{
		public fpCargas()
		{
			InitializeComponent();
			Atualiza();
		}

		static readonly NxtControl.Drawing.Color corVermelho = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
		static readonly NxtControl.Drawing.Color corCinza = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200)));
		static readonly NxtControl.Drawing.Color corFundo = new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224)));
		static readonly NxtControl.Drawing.Color corContorno = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
		static bool B(object v) { return v != null && Convert.ToBoolean(v); }
		// Raio (mesma ideia do Energizado_por_Gerador): bloqueado = so contorno; liberado = cinza; liberado e planta nos geradores = vermelho
		static void Raio(Polygon p, bool liberado, bool planta)
		{
			p.Brush = new NxtControl.Drawing.Brush(!liberado ? corFundo : planta ? corVermelho : corCinza);
			p.Pen = new NxtControl.Drawing.Pen(liberado && planta ? corVermelho : corContorno, 1F, NxtControl.Drawing.DashStyle.Solid);
		}
		void Muda(object s, ValueChangedEventArgs e) { Atualiza(); }
		void Atualiza()
		{
			bool planta = B(xPlanta.Value);
			tPlanta.Text = planta ? "Planta nos geradores: só ligam os equipamentos liberados" : "Planta na rede: todos os equipamentos podem operar";

			Raio(raio_V4601, B(xH_V4601.Value), planta);
			Raio(raio_V4602, B(xH_V4602.Value), planta);
			Raio(raio_V4603, B(xH_V4603.Value), planta);
			Raio(raio_V4604, B(xH_V4604.Value), planta);
			Raio(raio_EX_500_01, B(xH_EX_500_01.Value), planta);
			Raio(raio_EX_500_02, B(xH_EX_500_02.Value), planta);
			Raio(raio_EX_500_03, B(xH_EX_500_03.Value), planta);
			Raio(raio_EX_500_04, B(xH_EX_500_04.Value), planta);
			Raio(raio_EX_500_05, B(xH_EX_500_05.Value), planta);
			Raio(raio_COMP_500_01, B(xH_COMP_500_01.Value), planta);
			Raio(raio_COMP_500_02, B(xH_COMP_500_02.Value), planta);
			Raio(raio_UCT_200_01, B(xH_UCT_200_01.Value), planta);
			Raio(raio_UCT_200_02, B(xH_UCT_200_02.Value), planta);
			Raio(raio_UCT_200_03, B(xH_UCT_200_03.Value), planta);
			Raio(raio_BS_100_01, B(xH_BS_100_01.Value), planta);
			Raio(raio_BS_100_02, B(xH_BS_100_02.Value), planta);
			Raio(raio_BS_100_03, B(xH_BS_100_03.Value), planta);
			Raio(raio_GM_100_01, B(xH_GM_100_01.Value), planta);
			Raio(raio_UV_700_01, B(xH_UV_700_01.Value), planta);
			Raio(raio_UV_700_02, B(xH_UV_700_02.Value), planta);
			Raio(raio_DO_800_04, B(xH_DO_800_04.Value), planta);
			Raio(raio_DO_800_05, B(xH_DO_800_05.Value), planta);
			Raio(raio_P4901, B(xH_P4901.Value), planta);
			Raio(raio_P4902, B(xH_P4902.Value), planta);
			Raio(raio_P4903, B(xH_P4903.Value), planta);
			Raio(raio_R4005A, B(xH_R4005A.Value), planta);
			Raio(raio_R4005B, B(xH_R4005B.Value), planta);
			Raio(raio_MO_300_01, B(xH_MO_300_01.Value), planta);
			Raio(raio_QL_PORTARIA, B(xH_QL_PORTARIA.Value), planta);
			Raio(raio_QL_ADM, B(xH_QL_ADM.Value), planta);
			Raio(raio_QL_LODO, B(xH_QL_LODO.Value), planta);
			Raio(raio_QLSL, B(xH_QLSL.Value), planta);
			Raio(raio_QL_ILUMINACAO, B(xH_QL_ILUMINACAO.Value), planta);
		}
	}
}
