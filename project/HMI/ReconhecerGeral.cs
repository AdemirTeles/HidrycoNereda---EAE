/*
 * Hidryco - Reconhecer geral
 * Reconhece TODOS os alarmes pendentes da planta (todos os CLPs), sem resetar falhas: faz o mesmo que o
 * "reconhecer todos" do controle de alarmes do EAE (IAlarmService.AckAlarm para cada alarme reconhecivel e nao virtual).
 * O Reset geral continua resetando (e reconhecendo) so os equipamentos da tela.
 */

using System;
using System.Collections.Generic;
using NxtControl.GuiFramework;
using NxtControl.Services;

namespace HMI.Main
{
	public static class ReconhecerGeral
	{
		/// <summary>Reconhece todos os alarmes pendentes. Retorna quantos foram reconhecidos.</summary>
		public static int Executar()
		{
			IAlarmService svc = ServiceProvider.GetService(typeof(IAlarmService)) as IAlarmService;
			if (svc == null) return 0;
			// copia sob o mesmo lock do controle de alarmes e reconhece fora dele
			List<AlarmInfo> pendentes = new List<AlarmInfo>();
			List<AlarmInfo> itens = svc.Items;
			if (itens == null) return 0;
			lock (itens)
			{
				foreach (AlarmInfo a in itens)
					if (a != null && a.Acknable && !a.IsVirtual) pendentes.Add(a);
			}
			int n = 0;
			foreach (AlarmInfo a in pendentes)
			{
				try { svc.AckAlarm(a.DeviceInfo, a.TableId); n++; }
				catch (Exception ex) { LoggingService.Warn("Reconhecer geral: " + ex.Message); }
			}
			return n;
		}
	}
}
