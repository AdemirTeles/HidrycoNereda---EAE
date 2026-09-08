/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/5/2026
 * Time: 3:20 PM
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;

namespace SE.Nereda.Symbols.AnalogInput
{
	public partial class sPvBarVer : NxtControl.GuiFramework.HMISymbol
	{
		private bool iLoLoPv;
		private bool iLoPv;
		private bool iHiPv;
		private bool iHiHiPv;
		private bool iChFail;
		string InUnit;

		private float iPv;
		private float iPvMax;
		private float iPvMin;

		private string _Unit = "%";
		private string _SensorName = "Name";
		private string UnitOut = "%";

		public delegate void ShLevelPv(
			float ShPvMax,
			float ShPvMin,
			float ShPv
		);

		public event ShLevelPv ShareLevelPv;

		public sPvBarVer()
		{
			InitializeComponent();
			if (Unit != null)
				Unit.Text = _Unit;

			if (SensorName != null)
				SensorName.Text = _SensorName;
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("Unit")]
		public string _iUnit
		{
			get
			{
				return _Unit;
			}
			set
			{
				_Unit = value ?? "";
				UnitOut = _Unit;

				if (Unit != null){
					Unit.Text = _Unit;
					InUnit = _Unit;
				}
				/*
				 * À activer seulement si l'événement doit être envoyé
				 * lorsque la propriété Unit est modifiée.
				 */
				// FireEvent_CNF_UNIT(UnitOut);
			}
		}

		[RefreshProperties(RefreshProperties.Repaint)]
		[Category("Tagnames")]
		[DisplayName("SensorName")]
		public string _iSensorName
		{
			get
			{
				return _SensorName;
			}
			set
			{
				_SensorName = value ?? "";

				if (SensorName != null)
					SensorName.Text = _SensorName;
			}
		}

		private void LevelSensorStatus()
		{
			if (StatusTxt == null)
				return;

			StatusTxt.Text = "";

			if (iChFail)
			{
				StatusTxt.Text = "I/O Channel Failure";
				StatusTxt.TextColor =
					new NxtControl.Drawing.BlinkColor(
						"SE.Nereda.Orangwhite"
					);
			}
			else if (iLoLoPv)
			{
				StatusTxt.Text = "Low Low Level";
				StatusTxt.Color =
					new NxtControl.Drawing.Color(255, 0, 0);
			}
			else if (iHiHiPv)
			{
				StatusTxt.Text = "High High Level";
				StatusTxt.Color =
					new NxtControl.Drawing.Color(255, 0, 0);
			}
			else if (iLoPv)
			{
				StatusTxt.Text = "Low Level";
				StatusTxt.Color =
					new NxtControl.Drawing.Color(254, 186, 10);
			}
			else if (iHiPv)
			{
				StatusTxt.Text = "High Level";
				StatusTxt.Color =
					new NxtControl.Drawing.Color(254, 186, 10);
			}
		}

		private void DisplayLevel()
		{
			if (ShowLevel == null)
				return;

			float range = iPvMax - iPvMin;

			/*
			 * Avec les float, une division par zéro ne provoque pas
			 * obligatoirement une exception C# : elle peut produire
			 * NaN ou Infinity.
			 *
			 * Ces valeurs peuvent ensuite provoquer une erreur
			 * lorsqu'elles sont affectées à FillPercent.
			 */
			if (range <= 0.0f)
			{
				ShowLevel.FillPercent = 0.0f;
				return;
			}

			float fillPercent =
				((iPv - iPvMin) / range) * 100.0f;

			if (float.IsNaN(fillPercent) ||
				float.IsInfinity(fillPercent))
			{
				fillPercent = 0.0f;
			}

			if (fillPercent < 0.0f)
				fillPercent = 0.0f;
			else if (fillPercent > 100.0f)
				fillPercent = 100.0f;

			ShowLevel.FillPercent = fillPercent;

			if (ShareLevelPv != null)
			{
				ShareLevelPv(
					iPvMax,
					iPvMin,
					iPv
				);
			}
		}

		private void Pv_1ValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iPv = Convert.ToSingle(e.Value);
				DisplayLevel();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en float.
				 * On conserve la dernière valeur valide.
				 */
			}
		}

		private void PvMinValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iPvMin = Convert.ToSingle(e.Value);
				DisplayLevel();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en float.
				 */
			}
		}

		private void PvMaxValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iPvMax = Convert.ToSingle(e.Value);
				DisplayLevel();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en float.
				 */
			}
		}

		private void OverrideStatusValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null ||
				e.Value == null ||
				Override == null)
			{
				return;
			}

			try
			{
				Override.Visible =
					Convert.ToBoolean(e.Value);
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en bool.
				 */
			}
		}

		private void ChFailValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iChFail = Convert.ToBoolean(e.Value);
				LevelSensorStatus();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en bool.
				 */
			}
		}

		private void HiHiPvValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iHiHiPv = Convert.ToBoolean(e.Value);
				LevelSensorStatus();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en bool.
				 */
			}
		}

		private void HiPvValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iHiPv = Convert.ToBoolean(e.Value);
				LevelSensorStatus();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en bool.
				 */
			}
		}

		private void LoPvValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iLoPv = Convert.ToBoolean(e.Value);
				LevelSensorStatus();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en bool.
				 */
			}
		}

		private void LoLoPvValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null || e.Value == null)
				return;

			try
			{
				iLoLoPv = Convert.ToBoolean(e.Value);
				LevelSensorStatus();
			}
			catch
			{
				/*
				 * La valeur reçue n'est pas convertible en bool.
				 */
			}
		}

		private void IColorValueChanged(
			object sender,
			ValueChangedEventArgs e)
		{
			if (e == null ||
				e.Value == null ||
				ShowLevel == null)
			{
				return;
			}

			int colorValue;

			try
			{
				colorValue = Convert.ToInt32(e.Value);
			}
			catch
			{
				return;
			}

			switch (colorValue)
			{
				case 1:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							255, 255, 255
						);
					break;

				case 2:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							154, 154, 154
						);
					break;

				case 3:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							178, 14, 18
						);
					break;

				case 4:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							234, 22, 30
						);
					break;

				case 5:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							254, 186, 10
						);
					break;

				case 6:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							255, 255, 0
						);
					break;

				case 7:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							150, 214, 66
						);
					break;

				case 8:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							61, 205, 88
						);
					break;

				case 9:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							2, 178, 238
						);
					break;

				case 10:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							0, 114, 188
						);
					break;

				case 11:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							47, 54, 153
						);
					break;

				case 12:
					ShowLevel.BrushColor =
						new NxtControl.Drawing.Color(
							111, 49, 152
						);
					break;
			}
		}
	}
}