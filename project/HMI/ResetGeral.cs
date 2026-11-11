/*
 * Hidryco - Reset geral da tela
 * Percorre todos os simbolos de equipamento da tela (inclusive os que estao dentro de outros simbolos) e dispara
 * em cada um o mesmo evento do botao "Reconhecer / Reset" do faceplate dele: FireEvent_<reset>(true) e (false).
 * Nao mexe em horimetro nem em numero de partidas. Cada instancia de CAT e resetada uma vez so.
 * Motores do Nereda (Motor_VS, MotorS): RESET do CAT, o mesmo do botao Reset do faceplate (reseta a base e, no
 * Motor_VS, manda um pulso de reset ao equipamento, so com ele parado).
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using NxtControl.GuiFramework;

namespace HMI.Main
{
	public static class ResetGeral
	{
		// CAT -> evento de reset da IHM (o mesmo do botao de reset do faceplate de cada CAT)
		static readonly Dictionary<string, string> EVENTO = new Dictionary<string, string>
		{
			{ "Motor_Generico", "FireEvent_E_RESET_FALHA" },
			{ "Valvula_Coester", "FireEvent_E_CMD_RESET_FALHA" },
			{ "Atuador_Coester", "FireEvent_E_CMD_RESET_FALHA" },
			{ "UCT_PreTratamento", "FireEvent_E_RESET_FALHA" },
			{ "Agua_Reuso", "FireEvent_E_RESET" },
			{ "Desinfeccao_UV", "FireEvent_E_RESET_FALHAS_PROCESSO" },
			{ "EEE_Bruto", "FireEvent_E_RESET_FALHAS_PROCESSO" },
			{ "Fase_Solida", "FireEvent_E_RESET" },
			{ "DesidratacaoLodo", "FireEvent_E_RESET" },
			{ "Gerador_Generico", "FireEvent_E_RESET" },
			{ "MGE_Generico", "FireEvent_E_RESET" },
			{ "Prensa_Vibropac", "FireEvent_E_RESET" },
			{ "Preparador_Vibropac", "FireEvent_E_RESET" },
			{ "Sensor_Generico", "FireEvent_E_RESET" },
			{ "Subestacao", "FireEvent_E_RESET" },
			{ "UV_Trojan", "FireEvent_E_RESET" },
			{ "Gradeamento_Inovaisa", "FireEvent_E_RESET_FALHAS_PROCESSO" },
			{ "Motor_Inovaisa", "FireEvent_E_RESET" },
		};
		const string NS = "Hidryco.HidrycoLib.Symbols.";

		// motores do Nereda (SE.Nereda): evento RESET do CAT
		static readonly Dictionary<string, string> EVENTO_NEREDA = new Dictionary<string, string>
		{
			{ "Motor_VS", "FireEvent_RESET" },
			{ "MotorS", "FireEvent_RESET" },
		};
		const string NS_NEREDA = "SE.Nereda.Symbols.";

		/// <summary>Reseta todos os equipamentos da tela. Retorna quantas instancias foram resetadas.</summary>
		public static int Executar(GroupShape tela)
		{
			HashSet<string> feitos = new HashSet<string>();
			int n = 0;
			Percorre(tela, feitos, ref n);
			return n;
		}

		static void Percorre(GroupShape g, HashSet<string> feitos, ref int n)
		{
			foreach (object o in g.Shapes)
			{
				HMISymbol s = o as HMISymbol;
				if (s != null) Reseta(s, feitos, ref n);
				GroupShape filho = o as GroupShape;
				if (filho != null) Percorre(filho, feitos, ref n);
			}
		}

		static void Reseta(HMISymbol s, HashSet<string> feitos, ref int n)
		{
			Type t = s.GetType();
			if (t.Namespace == null) return;
			string cat, evento;
			if (t.Namespace.StartsWith(NS))
			{
				cat = t.Namespace.Substring(NS.Length);
				if (!EVENTO.TryGetValue(cat, out evento)) return;
			}
			else if (t.Namespace.StartsWith(NS_NEREDA))
			{
				cat = t.Namespace.Substring(NS_NEREDA.Length);
				if (!EVENTO_NEREDA.TryGetValue(cat, out evento)) return;
			}
			else return;
			MethodInfo m = t.GetMethod(evento, new Type[] { typeof(bool) });
			if (m == null) return;
			// mesma instancia de CAT em varios simbolos da tela (ex.: sDefault + sSV01..08): reseta uma vez so
			string chave = cat + "|" + Caminho(s);
			if (!feitos.Add(chave)) return;
			try
			{
				m.Invoke(s, new object[] { true });
				m.Invoke(s, new object[] { false });
				n++;
			}
			catch (Exception e)
			{
				NxtControl.Services.LoggingService.ErrorFormatted("Reset geral: {0} ({1}): {2}", s.Name, cat, e.Message);
			}
		}

		// caminho da instancia do CAT ligada ao simbolo (MapPath); se nao houver, o proprio objeto
		static string Caminho(HMISymbol s)
		{
			PropertyInfo p = typeof(HMISymbol).GetProperty("MapPath", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
			object v = p != null ? p.GetValue(s, null) : null;
			string c = v as string;
			return string.IsNullOrEmpty(c) ? "obj" + System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(s) : c;
		}
	}
}
