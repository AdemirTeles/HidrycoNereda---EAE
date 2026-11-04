/*
 * Hidryco - replicacao de ajustes de sensor entre faceplate e tela
 * O faceplate do Sensor_Generico avisa (Publicar) quando o operador grava faixa, alarmes ou habilitacoes;
 * a tela que precisa replicar (ex.: LIT-900-01/02 -> SludgeHoldingTank1/2 da Nereda) assina o evento Gravado.
 */

using System;

namespace Hidryco.HidrycoLib.SupportClasses
{
	public class AjustesSensor
	{
		public string Tag;                       // TagName do faceplate (instancia do Sensor_Generico)
		public float RangeMin, RangeMax, Altura; // valor de engenharia em 4 mA / 20 mA; altura maxima (nivel)
		public bool Nivel;                       // TRUE = alarmes em % da altura maxima
		public bool[] Hab = new bool[4];         // habilitacao HH, H, L, LL
		public float[] Sp = new float[4];        // limites HH, H, L, LL (% da altura se Nivel, senao unidade de engenharia)
		public ushort[] Tempo = new ushort[4];   // retardo dos alarmes HH, H, L, LL (s)
	}

	public static class ReplicaSensor
	{
		public static event Action<AjustesSensor> Gravado;

		public static void Publicar(AjustesSensor a)
		{
			Action<AjustesSensor> h = Gravado;
			if (h != null) h(a);
		}
	}
}
