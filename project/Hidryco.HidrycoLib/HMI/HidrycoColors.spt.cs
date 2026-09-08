/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 11:27
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.SupportClasses
{
	public static class HidrycoColors
	{
		public static readonly NxtControl.Drawing.Color Ligado =
			NxtControl.Drawing.SystemColors.Red;

		public static readonly NxtControl.Drawing.Color Desligado =
			NxtControl.Drawing.SystemColors.Green;

		public static readonly NxtControl.Drawing.Color Falha =
			NxtControl.Drawing.SystemColors.Yellow;

		public static readonly NxtControl.Drawing.Color Manutencao =
			NxtControl.Drawing.SystemColors.Blue;

		public static readonly NxtControl.Drawing.Color Unknown =
			NxtControl.Drawing.Color.FromName("SE.App2Base.Unknown");
		
		public static readonly NxtControl.Drawing.Color botaoTrue =
			NxtControl.Drawing.Color.FromName("RoundKnobInnerCircleColor");
		
		public static readonly NxtControl.Drawing.Color botaoFalse =
			NxtControl.Drawing.Color.FromName("ButtonPenColor");
	}
}