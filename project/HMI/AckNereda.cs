/*
 * Hidryco - Reconhecer todos os alarmes da Nereda
 * Faz o mesmo que o "reconhecer todos" do controle de alarmes do EAE (AlarmControl.ackAlarms): para cada alarme
 * reconhecivel (Acknable) e nao virtual da lista do servico de alarmes, chama IAlarmService.AckAlarm(DeviceInfo, TableId).
 * So os alarmes do CLP da Nereda (dispositivo com "Nereda" no nome); os das outras areas ficam como estao.
 */

using System;
using System.Collections.Generic;
using NxtControl.GuiFramework;
using NxtControl.Services;

namespace HMI.Main
{
	public static class AckNereda
	{
		const string CLP = "Nereda";

		/// <summary>Reconhece os alarmes pendentes do CLP da Nereda. Retorna quantos foram reconhecidos.</summary>
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
					if (a != null && a.Acknable && !a.IsVirtual && DaNereda(a)) pendentes.Add(a);
			}
			int n = 0;
			foreach (AlarmInfo a in pendentes)
			{
				try { svc.AckAlarm(a.DeviceInfo, a.TableId); n++; }
				catch (Exception ex) { LoggingService.Warn("AckNereda: " + ex.Message); }
			}
			return n;
		}

		static bool DaNereda(AlarmInfo a)
		{
			string dev = a.DeviceName;
			if (string.IsNullOrEmpty(dev) && a.DeviceInfo != null) dev = a.DeviceInfo.Device;
			return dev != null && dev.IndexOf(CLP, StringComparison.OrdinalIgnoreCase) >= 0;
		}
	}
}
