using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInputBase
{
	/// <summary>
	/// Summary description for fpParameter.
	/// </summary>
	partial class fpParameter
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.sec0_Escala = new NxtControl.GuiFramework.FreeText();
			this.lEnScale = new NxtControl.GuiFramework.FreeText();
			this.EnScaleBtn = new System.HMI.Symbols.Base.SwitchButton();
			this.lMinRaw = new NxtControl.GuiFramework.FreeText();
			this.txtMinRaw = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMaxRaw = new NxtControl.GuiFramework.FreeText();
			this.txtMaxRaw = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMinPv = new NxtControl.GuiFramework.FreeText();
			this.txtMinPv = new System.HMI.Symbols.Base.TextBox<float>();
			this.lMaxPv = new NxtControl.GuiFramework.FreeText();
			this.txtMaxPv = new System.HMI.Symbols.Base.TextBox<float>();
			this.lUseLim = new NxtControl.GuiFramework.FreeText();
			this.UseLimitsBtn = new System.HMI.Symbols.Base.SwitchButton();
			this.lCutoff = new NxtControl.GuiFramework.FreeText();
			this.txtPvCutOff = new System.HMI.Symbols.Base.TextBox<float>();
			this.lOffset = new NxtControl.GuiFramework.FreeText();
			this.txtPvOffset = new System.HMI.Symbols.Base.TextBox<float>();
			this.sec1_Filtro = new NxtControl.GuiFramework.FreeText();
			this.lFiltro = new NxtControl.GuiFramework.FreeText();
			this.txtFilterTime = new System.HMI.Symbols.Base.TextBox<System.Int32>();
			this.lCiclo = new NxtControl.GuiFramework.FreeText();
			this.txtPt1CycleTime = new System.HMI.Symbols.Base.TextBox<int>();
			this.lSuave = new NxtControl.GuiFramework.FreeText();
			this.SmoothType = new NxtControl.GuiFramework.DrawnComboBox();
			this.lTDiff = new NxtControl.GuiFramework.FreeText();
			this.TimeDiff = new System.HMI.Symbols.Base.TextBox<System.Int32>();
			this.lVDiff = new NxtControl.GuiFramework.FreeText();
			this.ValDiff = new System.HMI.Symbols.Base.TextBox<float>();
			this.sec1_Falhaefo = new NxtControl.GuiFramework.FreeText();
			this.lEntrada = new NxtControl.GuiFramework.FreeText();
			this.lblPvField = new System.HMI.Symbols.Base.Label<float>();
			this.lBadSel = new NxtControl.GuiFramework.FreeText();
			this.SelectBad = new System.HMI.Symbols.Base.DropDown<short>();
			this.lBad = new NxtControl.GuiFramework.FreeText();
			this.txtPvBad = new System.HMI.Symbols.Base.TextBox<float>();
			this.lOver = new NxtControl.GuiFramework.FreeText();
			this.Override = new System.HMI.Symbols.Base.SwitchButton();
			this.lOverVal = new NxtControl.GuiFramework.FreeText();
			this.txtoverridevalue = new System.HMI.Symbols.Base.TextBox<float>();
			this.BadPvSel = new System.HMI.Symbols.Base.Execute<short>();
			this.Execover = new System.HMI.Symbols.Base.Execute<bool>();
			this.Pv = new System.HMI.Symbols.Base.Execute<float>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<byte>();
			this.PvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMax = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Ajustes do sensor";
			// 
			// sec0_Escala
			// 
			this.sec0_Escala.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec0_Escala.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec0_Escala.Location = new NxtControl.Drawing.PointF(20D, 48D);
			this.sec0_Escala.Name = "sec0_Escala";
			this.sec0_Escala.Text = "Escala";
			// 
			// lEnScale
			// 
			this.lEnScale.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lEnScale.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lEnScale.Location = new NxtControl.Drawing.PointF(20D, 77D);
			this.lEnScale.Name = "lEnScale";
			this.lEnScale.Text = "Habilitar escala";
			// 
			// EnScaleBtn
			// 
			this.EnScaleBtn.BeginInit();
			this.EnScaleBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 72D);
			this.EnScaleBtn.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.EnScaleBtn.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.FalseText = "N\u00e3o";
			this.EnScaleBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.EnScaleBtn.Name = "EnScaleBtn";
			this.EnScaleBtn.SecurityLevel = 0;
			this.EnScaleBtn.TagName = "EnScale";
			this.EnScaleBtn.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.EnScaleBtn.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.EnScaleBtn.TrueText = "Sim";
			this.EnScaleBtn.Value = false;
			this.EnScaleBtn.EndInit();
			// 
			// lMinRaw
			// 
			this.lMinRaw.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMinRaw.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMinRaw.Location = new NxtControl.Drawing.PointF(20D, 111D);
			this.lMinRaw.Name = "lMinRaw";
			this.lMinRaw.Text = "Valor bruto m\u00ednimo";
			// 
			// txtMinRaw
			// 
			this.txtMinRaw.BeginInit();
			this.txtMinRaw.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 106D);
			this.txtMinRaw.MaximumTag = null;
			this.txtMinRaw.MinimumTag = null;
			this.txtMinRaw.Name = "txtMinRaw";
			this.txtMinRaw.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMinRaw.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMinRaw.SecurityLevel = 6;
			this.txtMinRaw.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMinRaw.TagName = "RawPvMin";
			this.txtMinRaw.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMinRaw.UseInputPad = true;
			this.txtMinRaw.Value = 0F;
			this.txtMinRaw.EndInit();
			// 
			// lMaxRaw
			// 
			this.lMaxRaw.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMaxRaw.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMaxRaw.Location = new NxtControl.Drawing.PointF(20D, 145D);
			this.lMaxRaw.Name = "lMaxRaw";
			this.lMaxRaw.Text = "Valor bruto m\u00e1ximo";
			// 
			// txtMaxRaw
			// 
			this.txtMaxRaw.BeginInit();
			this.txtMaxRaw.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 140D);
			this.txtMaxRaw.MaximumTag = null;
			this.txtMaxRaw.MinimumTag = null;
			this.txtMaxRaw.Name = "txtMaxRaw";
			this.txtMaxRaw.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMaxRaw.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMaxRaw.SecurityLevel = 6;
			this.txtMaxRaw.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMaxRaw.TagName = "RawPvMax";
			this.txtMaxRaw.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMaxRaw.UseInputPad = true;
			this.txtMaxRaw.Value = 0F;
			this.txtMaxRaw.EndInit();
			// 
			// lMinPv
			// 
			this.lMinPv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMinPv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMinPv.Location = new NxtControl.Drawing.PointF(20D, 179D);
			this.lMinPv.Name = "lMinPv";
			this.lMinPv.Text = "Valor m\u00ednimo";
			// 
			// txtMinPv
			// 
			this.txtMinPv.BeginInit();
			this.txtMinPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 174D);
			this.txtMinPv.MaximumTag = null;
			this.txtMinPv.MinimumTag = null;
			this.txtMinPv.Name = "txtMinPv";
			this.txtMinPv.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMinPv.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMinPv.SecurityLevel = 6;
			this.txtMinPv.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMinPv.TagName = "PvMin";
			this.txtMinPv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMinPv.UseInputPad = true;
			this.txtMinPv.Value = 0F;
			this.txtMinPv.EndInit();
			// 
			// lMaxPv
			// 
			this.lMaxPv.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lMaxPv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lMaxPv.Location = new NxtControl.Drawing.PointF(20D, 213D);
			this.lMaxPv.Name = "lMaxPv";
			this.lMaxPv.Text = "Valor m\u00e1ximo";
			// 
			// txtMaxPv
			// 
			this.txtMaxPv.BeginInit();
			this.txtMaxPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 208D);
			this.txtMaxPv.MaximumTag = null;
			this.txtMaxPv.MinimumTag = null;
			this.txtMaxPv.Name = "txtMaxPv";
			this.txtMaxPv.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtMaxPv.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtMaxPv.SecurityLevel = 6;
			this.txtMaxPv.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtMaxPv.TagName = "PvMax";
			this.txtMaxPv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtMaxPv.UseInputPad = true;
			this.txtMaxPv.Value = 0F;
			this.txtMaxPv.EndInit();
			// 
			// lUseLim
			// 
			this.lUseLim.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lUseLim.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lUseLim.Location = new NxtControl.Drawing.PointF(20D, 247D);
			this.lUseLim.Name = "lUseLim";
			this.lUseLim.Text = "Usar limites";
			// 
			// UseLimitsBtn
			// 
			this.UseLimitsBtn.BeginInit();
			this.UseLimitsBtn.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 220D, 242D);
			this.UseLimitsBtn.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.UseLimitsBtn.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.FalseText = "N\u00e3o";
			this.UseLimitsBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.UseLimitsBtn.Name = "UseLimitsBtn";
			this.UseLimitsBtn.SecurityLevel = 0;
			this.UseLimitsBtn.TagName = "UseLimits";
			this.UseLimitsBtn.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.UseLimitsBtn.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.UseLimitsBtn.TrueText = "Sim";
			this.UseLimitsBtn.Value = false;
			this.UseLimitsBtn.EndInit();
			// 
			// lCutoff
			// 
			this.lCutoff.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lCutoff.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lCutoff.Location = new NxtControl.Drawing.PointF(20D, 281D);
			this.lCutoff.Name = "lCutoff";
			this.lCutoff.Text = "Corte do valor";
			// 
			// txtPvCutOff
			// 
			this.txtPvCutOff.BeginInit();
			this.txtPvCutOff.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 276D);
			this.txtPvCutOff.MaximumTag = null;
			this.txtPvCutOff.MinimumTag = null;
			this.txtPvCutOff.Name = "txtPvCutOff";
			this.txtPvCutOff.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPvCutOff.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPvCutOff.SecurityLevel = 12;
			this.txtPvCutOff.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPvCutOff.TagName = "PvCutOff";
			this.txtPvCutOff.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPvCutOff.UseInputPad = true;
			this.txtPvCutOff.Value = 0F;
			this.txtPvCutOff.EndInit();
			// 
			// lOffset
			// 
			this.lOffset.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lOffset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lOffset.Location = new NxtControl.Drawing.PointF(20D, 315D);
			this.lOffset.Name = "lOffset";
			this.lOffset.Text = "Deslocamento (offset)";
			// 
			// txtPvOffset
			// 
			this.txtPvOffset.BeginInit();
			this.txtPvOffset.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 220D, 310D);
			this.txtPvOffset.MaximumTag = null;
			this.txtPvOffset.MinimumTag = null;
			this.txtPvOffset.Name = "txtPvOffset";
			this.txtPvOffset.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPvOffset.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPvOffset.SecurityLevel = 12;
			this.txtPvOffset.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPvOffset.TagName = "PvOffset";
			this.txtPvOffset.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPvOffset.UseInputPad = true;
			this.txtPvOffset.Value = 0F;
			this.txtPvOffset.EndInit();
			// 
			// sec1_Filtro
			// 
			this.sec1_Filtro.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec1_Filtro.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec1_Filtro.Location = new NxtControl.Drawing.PointF(380D, 48D);
			this.sec1_Filtro.Name = "sec1_Filtro";
			this.sec1_Filtro.Text = "Filtro";
			// 
			// lFiltro
			// 
			this.lFiltro.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lFiltro.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lFiltro.Location = new NxtControl.Drawing.PointF(380D, 77D);
			this.lFiltro.Name = "lFiltro";
			this.lFiltro.Text = "Tempo de filtro";
			// 
			// txtFilterTime
			// 
			this.txtFilterTime.BeginInit();
			this.txtFilterTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 580D, 72D);
			this.txtFilterTime.MaximumTag = null;
			this.txtFilterTime.MinimumTag = null;
			this.txtFilterTime.Name = "txtFilterTime";
			this.txtFilterTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtFilterTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtFilterTime.SecurityLevel = 12;
			this.txtFilterTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtFilterTime.Suffix = "s";
			this.txtFilterTime.TagName = "Pt1FTime";
			this.txtFilterTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtFilterTime.UseInputPad = true;
			this.txtFilterTime.Value = 0;
			this.txtFilterTime.EndInit();
			// 
			// lCiclo
			// 
			this.lCiclo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lCiclo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lCiclo.Location = new NxtControl.Drawing.PointF(380D, 111D);
			this.lCiclo.Name = "lCiclo";
			this.lCiclo.Text = "Tempo de ciclo do filtro";
			// 
			// txtPt1CycleTime
			// 
			this.txtPt1CycleTime.BeginInit();
			this.txtPt1CycleTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 580D, 106D);
			this.txtPt1CycleTime.MaximumTag = null;
			this.txtPt1CycleTime.MinimumTag = null;
			this.txtPt1CycleTime.Name = "txtPt1CycleTime";
			this.txtPt1CycleTime.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPt1CycleTime.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPt1CycleTime.SecurityLevel = 12;
			this.txtPt1CycleTime.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPt1CycleTime.Suffix = "ms";
			this.txtPt1CycleTime.TagName = "Pt1CycleTime";
			this.txtPt1CycleTime.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPt1CycleTime.UseInputPad = true;
			this.txtPt1CycleTime.Value = 0;
			this.txtPt1CycleTime.EndInit();
			// 
			// lSuave
			// 
			this.lSuave.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lSuave.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lSuave.Location = new NxtControl.Drawing.PointF(380D, 145D);
			this.lSuave.Name = "lSuave";
			this.lSuave.Text = "Tipo de suaviza\u00e7\u00e3o";
			// 
			// SmoothType
			// 
			this.SmoothType.Bounds = new NxtControl.Drawing.RectF(((float)(580D)), ((float)(140D)), ((float)(120D)), ((float)(26D)));
			this.SmoothType.Brush = new NxtControl.Drawing.Brush("ComboboxBrush");
			this.SmoothType.Name = "SmoothType";
			this.SmoothType.Pen = new NxtControl.Drawing.Pen("ComboBoxPen");
			this.SmoothType.SelectedIndex = -1;
			this.SmoothType.TextColor = new NxtControl.Drawing.Color("ComboboxTextColor");
			this.SmoothType.TextPadding = new NxtControl.Drawing.Padding(2);
			this.SmoothType.SelectedIndexChanged += new System.EventHandler(this.SmoothTypeSelectedIndexChanged);
			// 
			// lTDiff
			// 
			this.lTDiff.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lTDiff.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lTDiff.Location = new NxtControl.Drawing.PointF(380D, 179D);
			this.lTDiff.Name = "lTDiff";
			this.lTDiff.Text = "Diferen\u00e7a de tempo";
			// 
			// TimeDiff
			// 
			this.TimeDiff.BeginInit();
			this.TimeDiff.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 580D, 174D);
			this.TimeDiff.MaximumTag = null;
			this.TimeDiff.MinimumTag = null;
			this.TimeDiff.Name = "TimeDiff";
			this.TimeDiff.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.TimeDiff.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.TimeDiff.SecurityLevel = 12;
			this.TimeDiff.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.TimeDiff.Suffix = "ms";
			this.TimeDiff.TagName = "TimeDiff";
			this.TimeDiff.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.TimeDiff.UseInputPad = true;
			this.TimeDiff.Value = 0;
			this.TimeDiff.EndInit();
			// 
			// lVDiff
			// 
			this.lVDiff.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lVDiff.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lVDiff.Location = new NxtControl.Drawing.PointF(380D, 213D);
			this.lVDiff.Name = "lVDiff";
			this.lVDiff.Text = "Diferen\u00e7a de valor";
			// 
			// ValDiff
			// 
			this.ValDiff.BeginInit();
			this.ValDiff.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 580D, 208D);
			this.ValDiff.MaximumTag = null;
			this.ValDiff.MinimumTag = null;
			this.ValDiff.Name = "ValDiff";
			this.ValDiff.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.ValDiff.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.ValDiff.SecurityLevel = 6;
			this.ValDiff.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.ValDiff.TagName = "ValDiff";
			this.ValDiff.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.ValDiff.UseInputPad = true;
			this.ValDiff.Value = 0F;
			this.ValDiff.EndInit();
			// 
			// sec1_Falhaefo
			// 
			this.sec1_Falhaefo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.sec1_Falhaefo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.sec1_Falhaefo.Location = new NxtControl.Drawing.PointF(380D, 252D);
			this.sec1_Falhaefo.Name = "sec1_Falhaefo";
			this.sec1_Falhaefo.Text = "Falha e for\u00e7amento";
			// 
			// lEntrada
			// 
			this.lEntrada.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lEntrada.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lEntrada.Location = new NxtControl.Drawing.PointF(380D, 281D);
			this.lEntrada.Name = "lEntrada";
			this.lEntrada.Text = "Valor de entrada";
			// 
			// lblPvField
			// 
			this.lblPvField.BeginInit();
			this.lblPvField.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPvField.DecimalPlacesCount = ((uint)(2u));
			this.lblPvField.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.78666666666666663D, 0D, 0D, 0.76190476190476186D, 580D, 278D);
			this.lblPvField.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblPvField.FontScale = false;
			this.lblPvField.IsOnlyInput = true;
			this.lblPvField.IsPrefixSuffixOutside = false;
			this.lblPvField.LeadingZeros = ((uint)(0u));
			this.lblPvField.Name = "lblPvField";
			this.lblPvField.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.lblPvField.Ranges.Clear();
			this.lblPvField.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("ComboBoxPen"));
			this.lblPvField.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.lblPvField.TagName = "InputValue";
			this.lblPvField.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblPvField.EndInit();
			// 
			// lBadSel
			// 
			this.lBadSel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lBadSel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lBadSel.Location = new NxtControl.Drawing.PointF(380D, 315D);
			this.lBadSel.Name = "lBadSel";
			this.lBadSel.Text = "Valor na falha";
			// 
			// SelectBad
			// 
			this.SelectBad.BeginInit();
			this.SelectBad.Brush = new NxtControl.Drawing.Brush("ComboBoxBrush");
			this.SelectBad.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.9D, 580D, 310D);
			this.SelectBad.Font = new NxtControl.Drawing.Font("ComboBoxFont");
			this.SelectBad.Name = "SelectBad";
			this.SelectBad.SecurityLevel = 12;
			this.SelectBad.TagName = "BadPvSel";
			this.SelectBad.TextColor = new NxtControl.Drawing.Color("ComboBoxTextColor");
			this.SelectBad.TextPadding = new NxtControl.Drawing.Padding(2);
			this.SelectBad.Value = ((short)(0));
			this.SelectBad.EndInit();
			// 
			// lBad
			// 
			this.lBad.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lBad.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lBad.Location = new NxtControl.Drawing.PointF(380D, 349D);
			this.lBad.Name = "lBad";
			this.lBad.Text = "Valor fixo na falha";
			// 
			// txtPvBad
			// 
			this.txtPvBad.BeginInit();
			this.txtPvBad.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 580D, 344D);
			this.txtPvBad.MaximumTag = null;
			this.txtPvBad.MinimumTag = null;
			this.txtPvBad.Name = "txtPvBad";
			this.txtPvBad.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtPvBad.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtPvBad.SecurityLevel = 12;
			this.txtPvBad.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtPvBad.TagName = "BadPv";
			this.txtPvBad.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtPvBad.UseInputPad = true;
			this.txtPvBad.Value = 0F;
			this.txtPvBad.EndInit();
			// 
			// lOver
			// 
			this.lOver.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lOver.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lOver.Location = new NxtControl.Drawing.PointF(380D, 383D);
			this.lOver.Name = "lOver";
			this.lOver.Text = "For\u00e7ar valor";
			// 
			// Override
			// 
			this.Override.BeginInit();
			this.Override.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 0.9D, 580D, 378D);
			this.Override.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Override.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Override.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Override.FalseText = "N\u00e3o";
			this.Override.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Override.Name = "Override";
			this.Override.SecurityLevel = 0;
			this.Override.TagName = "PvOverride";
			this.Override.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.Override.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Override.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Override.TrueText = "Sim";
			this.Override.Value = false;
			this.Override.EndInit();
			// 
			// lOverVal
			// 
			this.lOverVal.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.lOverVal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.lOverVal.Location = new NxtControl.Drawing.PointF(380D, 417D);
			this.lOverVal.Name = "lOverVal";
			this.lOverVal.Text = "Valor for\u00e7ado";
			// 
			// txtoverridevalue
			// 
			this.txtoverridevalue.BeginInit();
			this.txtoverridevalue.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 1D, 580D, 412D);
			this.txtoverridevalue.MaximumTag = null;
			this.txtoverridevalue.MinimumTag = null;
			this.txtoverridevalue.Name = "txtoverridevalue";
			this.txtoverridevalue.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtoverridevalue.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtoverridevalue.SecurityLevel = 0;
			this.txtoverridevalue.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtoverridevalue.TagName = "PvOverrideVal";
			this.txtoverridevalue.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtoverridevalue.UseInputPad = true;
			this.txtoverridevalue.UseRange = true;
			this.txtoverridevalue.Value = 0F;
			this.txtoverridevalue.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvOverrideValValueChanged);
			this.txtoverridevalue.EndInit();
			// 
			// BadPvSel
			// 
			this.BadPvSel.BeginInit();
			this.BadPvSel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.BadPvSel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.BadPvSel.Name = "BadPvSel";
			this.BadPvSel.SecurityLevel = 0;
			this.BadPvSel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.BadPvSel.TagName = "BadPvSel";
			this.BadPvSel.Value = ((short)(0));
			this.BadPvSel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BadPvSelValueChanged);
			this.BadPvSel.EndInit();
			// 
			// Execover
			// 
			this.Execover.BeginInit();
			this.Execover.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Execover.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Execover.Name = "Execover";
			this.Execover.SecurityLevel = 0;
			this.Execover.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Execover.TagName = "PvOverride";
			this.Execover.Value = false;
			this.Execover.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecOverValueChanged);
			this.Execover.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv.IsOnlyInput = true;
			this.Pv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv.Name = "Pv";
			this.Pv.SecurityLevel = 0;
			this.Pv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv.TagName = "Pv";
			this.Pv.Value = 0F;
			this.Pv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvValueChanged);
			this.Pv.EndInit();
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "SmoothType";
			this.execute_11.Value = ((byte)(0));
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SmoothValueChanged);
			this.execute_11.EndInit();
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMin.Name = "PvMin";
			this.PvMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMin.TagName = "PvMin";
			this.PvMin.Value = 0F;
			this.PvMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMinValueChanged);
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMax.Name = "PvMax";
			this.PvMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMax.TagName = "PvMax";
			this.PvMax.Value = 0F;
			this.PvMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvMaxValueChanged);
			this.PvMax.EndInit();
			// 
			// fpParameter
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(720D)), ((float)(456D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.sec0_Escala,
			this.lEnScale,
			this.EnScaleBtn,
			this.lMinRaw,
			this.txtMinRaw,
			this.lMaxRaw,
			this.txtMaxRaw,
			this.lMinPv,
			this.txtMinPv,
			this.lMaxPv,
			this.txtMaxPv,
			this.lUseLim,
			this.UseLimitsBtn,
			this.lCutoff,
			this.txtPvCutOff,
			this.lOffset,
			this.txtPvOffset,
			this.sec1_Filtro,
			this.lFiltro,
			this.txtFilterTime,
			this.lCiclo,
			this.txtPt1CycleTime,
			this.lSuave,
			this.SmoothType,
			this.lTDiff,
			this.TimeDiff,
			this.lVDiff,
			this.ValDiff,
			this.sec1_Falhaefo,
			this.lEntrada,
			this.lblPvField,
			this.lBadSel,
			this.SelectBad,
			this.lBad,
			this.txtPvBad,
			this.lOver,
			this.Override,
			this.lOverVal,
			this.txtoverridevalue,
			this.BadPvSel,
			this.Execover,
			this.Pv,
			this.execute_11,
			this.PvMin,
			this.PvMax});
			this.Size = new System.Drawing.Size(720, 456);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpParameterSecurityParameterChanged);
			this.SecurityModeChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityModeChanged(this.FpParameterSecurityModeChanged);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText sec0_Escala;
		private NxtControl.GuiFramework.FreeText lEnScale;
		private System.HMI.Symbols.Base.SwitchButton EnScaleBtn;
		private NxtControl.GuiFramework.FreeText lMinRaw;
		private System.HMI.Symbols.Base.TextBox<float> txtMinRaw;
		private NxtControl.GuiFramework.FreeText lMaxRaw;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxRaw;
		private NxtControl.GuiFramework.FreeText lMinPv;
		private System.HMI.Symbols.Base.TextBox<float> txtMinPv;
		private NxtControl.GuiFramework.FreeText lMaxPv;
		private System.HMI.Symbols.Base.TextBox<float> txtMaxPv;
		private NxtControl.GuiFramework.FreeText lUseLim;
		private System.HMI.Symbols.Base.SwitchButton UseLimitsBtn;
		private NxtControl.GuiFramework.FreeText lCutoff;
		private System.HMI.Symbols.Base.TextBox<float> txtPvCutOff;
		private NxtControl.GuiFramework.FreeText lOffset;
		private System.HMI.Symbols.Base.TextBox<float> txtPvOffset;
		private NxtControl.GuiFramework.FreeText sec1_Filtro;
		private NxtControl.GuiFramework.FreeText lFiltro;
		private System.HMI.Symbols.Base.TextBox<System.Int32> txtFilterTime;
		private NxtControl.GuiFramework.FreeText lCiclo;
		private System.HMI.Symbols.Base.TextBox<int> txtPt1CycleTime;
		private NxtControl.GuiFramework.FreeText lSuave;
		private NxtControl.GuiFramework.DrawnComboBox SmoothType;
		private NxtControl.GuiFramework.FreeText lTDiff;
		private System.HMI.Symbols.Base.TextBox<System.Int32> TimeDiff;
		private NxtControl.GuiFramework.FreeText lVDiff;
		private System.HMI.Symbols.Base.TextBox<float> ValDiff;
		private NxtControl.GuiFramework.FreeText sec1_Falhaefo;
		private NxtControl.GuiFramework.FreeText lEntrada;
		private System.HMI.Symbols.Base.Label<float> lblPvField;
		private NxtControl.GuiFramework.FreeText lBadSel;
		private System.HMI.Symbols.Base.DropDown<short> SelectBad;
		private NxtControl.GuiFramework.FreeText lBad;
		private System.HMI.Symbols.Base.TextBox<float> txtPvBad;
		private NxtControl.GuiFramework.FreeText lOver;
		private System.HMI.Symbols.Base.SwitchButton Override;
		private NxtControl.GuiFramework.FreeText lOverVal;
		private System.HMI.Symbols.Base.TextBox<float> txtoverridevalue;
		private System.HMI.Symbols.Base.Execute<short> BadPvSel;
		private System.HMI.Symbols.Base.Execute<bool> Execover;
		private System.HMI.Symbols.Base.Execute<float> Pv;
		private System.HMI.Symbols.Base.Execute<byte> execute_11;
		private System.HMI.Symbols.Base.Execute<float> PvMin;
		private System.HMI.Symbols.Base.Execute<float> PvMax;

		#endregion
	}
}
