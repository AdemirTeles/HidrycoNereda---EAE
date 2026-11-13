/*
 * Created by ApplicationLibDevTeam
 * 
 */

using System;
using NxtControl.GuiFramework;
using System.ComponentModel;
using SE.App2CommonProcess.SupportClasses;
using SE.App2Base.SupportClasses;
using NxtControl.Services;

namespace SE.Nereda.Faceplates.MotorVsBaseNer
{
	/// <summary>
	/// Faceplate do motor com inversor no padrao Hidryco. Receptores e comandos Schneider inalterados
	/// (SP_CMD 0 = desligar, 1 = avante/ligar, 2 = reverso; OWNER 0x10 = operador, 0x08 = programa; SPEED_OWNER; SPEEDSP_CMD; RESET_CMD).
	/// </summary>
	public partial class fpDefault : SE.App2Base.Faceplates.SEAppLibHMIFaceplate
	{
		public fpDefault()
		{
			InitializeComponent();
			LigaDono();
			Atualiza();
		}

		#region Estados anormais
		bool simulationVal, overrideVal, oosVal, maintenanceVal;
		public bool isOverrideEnabled = true;
		void SimulationValueChanged(object sender, ValueChangedEventArgs e) { simulationVal = (bool)e.Value; Anormal(); }
		void FbOverrideValueChanged(object sender, ValueChangedEventArgs e) { overrideVal = (bool)e.Value; Anormal(); }
		void OutOfServiceValueChanged(object sender, ValueChangedEventArgs e) { oosVal = (bool)e.Value; Anormal(); }
		void MaintenanceValueChanged(object sender, ValueChangedEventArgs e) { maintenanceVal = (bool)e.Value; Anormal(); }
		void Anormal()
		{
			fpNavigationPane.Abnormality("Parameter", simulationVal || (overrideVal && isOverrideEnabled) || maintenanceVal || oosVal, false);
			Atualiza();
		}
		#endregion

		#region Seguranca
		void FpDefaultSecurityOwnerChanged(bool isSecurity) { fpNavigationPane.SecOwner = SecOwner; ownerSwitch.SecOwner = SecOwner; Atualiza(); }
		void FpDefaultSecurityParameterChanged(bool isSecurity) { fpNavigationPane.SecParameter = SecParameter; }
		void FpDefaultSecuritySetpointChanged(bool isSecurity) { fpNavigationPane.SecSetpoint = SecSetpoint; Atualiza(); }
		#endregion

		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter fp = hmiFaceplate as SE.Nereda.Faceplates.MotorVsBaseNer.fpParameter;
			if (fp != null) {
				fp.Title = Title + " - Ajustes";
				fp.Unit = unit;
				fp.DecimalPlacesCount = decimalPlacesCount;
				fp.SecOwner = SecOwner;
				fp.SecParameter = SecParameter;
				fp.SecMode = SecMode;
				fp.SecSetpoint = SecSetpoint;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
			SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend fp1 = hmiFaceplate as SE.Nereda.Faceplates.MotorVsBaseNer.fpTrend;
			if (fp1 != null) {
				fp1.Title = Title + " - Gr\u00e1fico";
			}
			
			base.OnInitializeFaceplate(hmiFaceplate);
		}

		#region UserProperties
		string unit = "%";
		[Category("Faceplate")]
		public string Unit
		{
			get { return unit; }
			set
			{
				unit = value;
				SpeedPvValue.Tooltip = SpeedSpValue.Tooltip = SpeedOpValue.Tooltip = ConvertText(unit);
				txtSp.Tooltip = ConvertText(unit);
				SpeedPvValue.Suffix = SpeedSpValue.Suffix = SpeedOpValue.Suffix = ConvertText(unit);
				txtSp.Suffix = ConvertText(unit);
			}
		}

		[Category("Faceplate")]
		public string TitleText
		{
			get { return Title; }
			set { Title = value; this.Tooltip = value; fpNavigationPane.ParentTitle = value; }
		}

		uint decimalPlacesCount;
		[Category("Faceplate")]
		public uint DecimalPlacesCount
		{
			get { return decimalPlacesCount; }
			set
			{
				decimalPlacesCount = value;
				txtSp.DecimalPlacesCount = value;
				SpeedPvValue.DecimalPlacesCount = SpeedSpValue.DecimalPlacesCount = SpeedOpValue.DecimalPlacesCount = decimalPlacesCount;
			}
		}
		#endregion UserProperties

		#region Dados
		bool needReset, uniDirection, externControlled, enSpdOwner, owner, speedOwner, stdOwnerAvail;
		short fbStatus, transFbStatus, spValue, oldSpValue, outValue;
		ushort icurrentowner, currSpeedOwner;
		float currSpeedSp, barGraphMinPv, barGraphMaxPv, barGraphPv;

		void NeedResetValueChanged(object sender, ValueChangedEventArgs e) { needReset = (bool)e.Value; Atualiza(); }
		void FbStatusValueChanged(object sender, ValueChangedEventArgs e) { fbStatus = (short)e.Value; Atualiza(); }
		void TransFbStatusValueChanged(object sender, ValueChangedEventArgs e) { transFbStatus = (short)e.Value; Atualiza(); }
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e) { outValue = (short)e.Value; Atualiza(); }
		void ExternalControlledValueChanged(object sender, ValueChangedEventArgs e) { externControlled = (bool)e.Value; Atualiza(); }
		void EnSpeedOwnerValueChanged(object sender, ValueChangedEventArgs e) { enSpdOwner = (bool)e.Value; Atualiza(); }
		void DisReverseValueChanged(object sender, ValueChangedEventArgs e)
		{
			uniDirection = (bool)e.Value;
			// textos da faixa (mesma regra do faceplate Schneider)
			if (uniDirection)
			{
				fpNavigationPane.Failure.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.Failure.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.Interlock.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.Interlock.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.Permissive.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.Permissive.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.LocalPanel.LabelPassive = CondPassiveLabelText.Off;
				fpNavigationPane.LocalPanel.LabelActive1 = CondActive1LabelText.On;
				fpNavigationPane.LocalPanel.ApplicableConditions = ApplicableInputConditions.PassiveActive;
				fpNavigationPane.Interlock.ApplicableConditions = ApplicableInputConditions.PassiveActive;
				fpNavigationPane.Permissive.ApplicableConditions = ApplicableInputConditions.PassiveActive;
			}
			else
			{
				fpNavigationPane.Failure.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.Failure.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.Interlock.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.Interlock.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.Permissive.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.Permissive.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.LocalPanel.LabelPassive = CondPassiveLabelText.Stop;
				fpNavigationPane.LocalPanel.LabelActive1 = CondActive1LabelText.Forward;
				fpNavigationPane.LocalPanel.ApplicableConditions = ApplicableInputConditions.PassiveActive1Active2;
				fpNavigationPane.Interlock.ApplicableConditions = ApplicableInputConditions.PassiveActive1Active2;
				fpNavigationPane.Permissive.ApplicableConditions = ApplicableInputConditions.PassiveActive1Active2;
			}
			Atualiza();
		}
		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			spValue = (short)e.Value;
			// unidirecional: o setpoint "reverso" nao muda o texto (regra Schneider)
			if (!(uniDirection && spValue == (short)SpOpFbState.Active2))
				oldSpValue = spValue;
			Atualiza();
		}
		void CurrentSpeedSpValueChanged(object sender, ValueChangedEventArgs e)
		{
			currSpeedSp = (float)e.Value;
			((IHMIPrimitiveInput<float>)txtSp).ValueChanged(currSpeedSp);
			Atualiza();
		}
		void SpeedSpMinValueChanged(object sender, ValueChangedEventArgs e) { txtSp.Minimum = (float)e.Value; barGraphMinPv = (float)e.Value; Atualiza(); }
		void SpeedSpMaxValueChanged(object sender, ValueChangedEventArgs e) { txtSp.Maximum = (float)e.Value; barGraphMaxPv = (float)e.Value; Atualiza(); }
		void SpeedFbStatusValueChanged(object sender, ValueChangedEventArgs e) { barGraphPv = (float)e.Value; Atualiza(); }
		void CurrentSpeedOpValueChanged(object sender, ValueChangedEventArgs e) { }
		void SpeedOutMinValueChanged(object sender, ValueChangedEventArgs e) { }
		void SpeedOutMaxValueChanged(object sender, ValueChangedEventArgs e) { }
		void SpeedSpValueChanged(object sender, ValueChangedEventArgs e) { ((IHMIPrimitiveInput<float>)txtSp).ValueChanged(currSpeedSp); }

		void CurrentSpeedOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			currSpeedOwner = (ushort)e.Value;
			speedOwner = (currSpeedOwner == 0x10);
			FireEvent_SPEEDSP_CMD(currSpeedSp);
			Atualiza();
		}
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			stdOwnerAvail = (bool)e.Value;
			ownerSwitch.ExternalAvailable = stdOwnerAvail;
			if (stdOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt) + ".serviceManager.owner";
			}
			Atualiza();
		}
		void CurrentOwnerValueChanged(object sender, ValueChangedEventArgs e)
		{
			icurrentowner = (ushort)e.Value;
			owner = (icurrentowner == 0x10);
			txtSp.Value = currSpeedSp;
			if (!enSpdOwner)
				btnSpeedOwner.Checked = owner;
			Atualiza();
		}

		void FpDefaultUpdateOptionalService(string instancePath)
		{
			if (stdOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			}
			
			fpNavigationPane.Interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock";
			fpNavigationPane.Interlock.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".interlock";
			
			fpNavigationPane.Permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissive";
			fpNavigationPane.Permissive.InstanceName =  FindInstanceLayer(InstanceLayer.Top)+".permissive";
			
			fpNavigationPane.Failure.SymbolType = "SE.App2CommonProcess.Symbols.FailCondSum.sFailure";
			fpNavigationPane.Failure.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".failure";
			
			fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.MotorVsLp.sDefault";
			fpNavigationPane.LocalPanel.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".localPanel";
			
			fpNavigationPane.Maintenance.SymbolType = "SE.App2CommonProcess.Symbols.DevMnt.sDefault";
			fpNavigationPane.Maintenance.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".maintenance";
			
			ownerSwitch.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
		}
		#endregion

		#region Desenho

		// Diagnostico: e um faceplate do CAT de cima (Motor_VS). O faceplate principal foi aberto pelo simbolo da base embutido
		// no simbolo da tela (Parent); sobe pelos grupos ate o simbolo do CAT de cima e pede a ele o fpDiagnostico.
		NxtControl.GuiFramework.HMISymbol SimboloMotor()
		{
			NxtControl.GuiFramework.GroupShape g = this.Parent as NxtControl.GuiFramework.GroupShape;
			while (g != null)
			{
				NxtControl.GuiFramework.HMISymbol s = g as NxtControl.GuiFramework.HMISymbol;
				if (s != null && s.GetType().Namespace == "SE.Nereda.Symbols.Motor_VS")
					return s;
				g = g.ParentGroupShape;
			}
			return null;
		}
		void BtnDiagnosticoClick(object sender, EventArgs e)
		{
			NxtControl.GuiFramework.HMISymbol s = SimboloMotor();
			if (s != null)
				s.DoOpenFaceplate("fpDiagnostico");
		}
		void BtnMedicoesClick(object sender, EventArgs e)
		{
			NxtControl.GuiFramework.HMISymbol s = SimboloMotor();
			if (s != null)
				s.DoOpenFaceplate("fpMedicoes");
		}


		static void Selecao(DrawnButton b, bool sel)
		{
			b.BrushColor = sel ? new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))) : new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215)));
			b.TextColor = sel ? new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))) : new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			b.TextColorMouseDown = b.TextColor;
			b.TextDisabledColor = sel ? new NxtControl.Drawing.Color(((byte)(205)), ((byte)(205)), ((byte)(205))) : new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150)));
		}

		bool Seguro(int nivel) { return ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(nivel); }

		static string Situacao(bool oos, bool maint, bool sim, bool over, bool reset)
		{
			string s = "";
			if (oos) s += (s == "" ? "" : " | ") + "Fora de servi\u00e7o";
			if (maint) s += (s == "" ? "" : " | ") + "Manuten\u00e7\u00e3o";
			if (sim) s += (s == "" ? "" : " | ") + "Simula\u00e7\u00e3o";
			if (over) s += (s == "" ? "" : " | ") + "Realimenta\u00e7\u00e3o for\u00e7ada";
			if (reset) s += (s == "" ? "" : " | ") + "Aguardando reset";
			return s;
		}

		// modo (dono): 0x10 = operador = manual, 0x08 = programa = automatico (mesmo pedido do OwnerSwitchBasic da Schneider)
		// Igual ao OwnerSwitchBasic da Schneider: com servico de dono (serviceManager.owner) o pedido vai por
		// sOperatorProg.REQ_OWNER (alvo & 0xE7 | 0x10 ou alvo & 0xEF | 0x08); sem servico, pelo OWNER basico do proprio CAT.
		ushort requestOwner, targetOwner;
		void AlvoDono(ushort v) { targetOwner = v; }
		void LigaDono() { ownerSwitch.OnTargetOwnerChanged += AlvoDono; }
		SE.App2Base.Symbols.Owner.sOperatorProg ServicoDono()
		{
			System.Reflection.BindingFlags bf = System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance;
			System.Reflection.FieldInfo fd = typeof(SE.App2Base.Graphics.OwnerSwitchBasic).GetField("ownerData", bf);
			System.Reflection.FieldInfo fs = typeof(SE.App2Base.Graphics.OwnerSwitchBasic).GetField("serviceAvailable", bf);
			if (fd == null || fs == null)
				return null;
			SE.App2Base.Symbols.Owner.sOperatorProg so = fd.GetValue(ownerSwitch) as SE.App2Base.Symbols.Owner.sOperatorProg;
			return (so != null && (bool)fs.GetValue(ownerSwitch)) ? so : null;
		}
		void PedeDono(bool operador)
		{
			SE.App2Base.Symbols.Owner.sOperatorProg so = ServicoDono();
			if (so != null)
			{
				ushort req = operador ? (ushort)((targetOwner & 0xE7) | 0x10) : (ushort)((targetOwner & 0xEF) | 0x08);
				so.FireEvent_REQ_OWNER(req);
			}
			else
			{
				requestOwner = operador ? (ushort)((requestOwner & (0xE7)) | 0x10) : (ushort)((requestOwner & ~(1 << 4)) | 0x8);
				FireEvent_OWNER(requestOwner);
			}
		}
		void BtnManualClick(object sender, EventArgs e) { PedeDono(true); }
		void BtnAutomaticoClick(object sender, EventArgs e) { PedeDono(false); }
		void BtnAjustesClick(object sender, EventArgs e) { DoOpenFaceplate("fpParameter"); }
		void BtnGraficoClick(object sender, EventArgs e) { DoOpenFaceplate("fpTrend"); }
		void FpNavigationPaneOnParameterClick() { DoOpenFaceplate("fpParameter"); }
		void FpNavigationPaneOnTrendClick() { DoOpenFaceplate("fpTrend"); }

		string TextoFb(short v)
		{
			if (uniDirection)
				switch (v) { case 1: return "LIGADO"; case 5: return "PARANDO"; case 6: return "PARTINDO"; case 253: return "DESCONHECIDO"; default: return "DESLIGADO"; }
			switch (v) { case 1: return "AVANTE"; case 2: return "REVERSO"; case 5: return "PARANDO"; case 6: return "PARTINDO (AVANTE)"; case 7: return "PARTINDO (REVERSO)"; case 253: return "DESCONHECIDO"; default: return "DESLIGADO"; }
		}
		string TextoCmd(short v)
		{
			if (v == 1) return uniDirection ? "Ligado" : "Avante";
			if (v == 2) return uniDirection ? "Ligado" : "Reverso";
			return "Desligado";
		}
		string TextoDono(ushort v)
		{
			switch (v) { case 0x10: return "operador"; case 0x40: return "operador local"; case 0x4: return "programa local"; case 0x8: return stdOwnerAvail ? "programa remoto" : "programa"; default: return "-"; }
		}

		void Atualiza()
		{
			// estado: mesma regra do faceplate Schneider
			short ef = (((fbStatus != 1 && fbStatus != 2) && (transFbStatus == 6 || transFbStatus == 7)) || transFbStatus == 5) ? transFbStatus : fbStatus;
			textoEstado.Text = TextoFb(ef);
			caixaEstado.BrushColor = (ef == 1 || ef == 2) ? new NxtControl.Drawing.Color(64, 64, 64) :
				((ef >= 5 && ef <= 7) ? new NxtControl.Drawing.Color(160, 160, 160) : new NxtControl.Drawing.Color(255, 255, 255));
			textoComando.Text = "Comando atual: " + TextoCmd(oldSpValue);
			textoSaida.Text = "Sa\u00edda atual: " + TextoCmd(outValue) + (externControlled ? " (controle externo)" : "");
			lPassivo.Visible = PassiveRemainTime.Visible = !uniDirection;
			textoSituacao.Text = Situacao(oosVal, maintenanceVal, simulationVal, overrideVal && isOverrideEnabled, needReset);

			// barra de velocidade (real) e marcador da referencia, entre SpMin e SpMax
			float faixa = barGraphMaxPv - barGraphMinPv;
			float pv = faixa > 0 ? Math.Max(0f, Math.Min(1f, (barGraphPv - barGraphMinPv) / faixa)) : 0f;
			float sp = faixa > 0 ? Math.Max(0f, Math.Min(1f, (currSpeedSp - barGraphMinPv) / faixa)) : 0f;
			barVal.Bounds = new NxtControl.Drawing.RectF(20f, 168f, 320f * pv, 8f);
			barRef.Bounds = new NxtControl.Drawing.RectF(20f + 317f * sp, 164f, 3f, 16f);

			// mesma decodificacao do CurrOwnerDecode: programa = 16#8 (remoto) ou 16#4 (local); operador = 16#10 ou 16#40
			bool auto = icurrentowner == 0x08 || icurrentowner == 0x04;
			bool man = icurrentowner == 0x10 || icurrentowner == 0x40;
			Selecao(btnManual, man);
			Selecao(btnAutomatico, auto);
			btnManual.Enabled = btnAutomatico.Enabled = Seguro(SecOwner);

			// comando manual: mesma regra do ButtonEnable Schneider
			bool seg = Seguro(SecSetpoint);
			btnManualOff.Enabled = owner && seg && spValue != 0 && !oosVal;
			btnManualReverse.Enabled = owner && seg && spValue != 2 && !oosVal;
			btnManualForward.Enabled = owner && seg && spValue != 1 && !oosVal;
			btnManualReverse.Visible = !uniDirection;
			if (uniDirection)
			{
				btnManualOff.Bounds = new NxtControl.Drawing.RectF(20f, 314f, 150f, 34f);
				btnManualForward.Bounds = new NxtControl.Drawing.RectF(190f, 314f, 150f, 34f);
				btnManualForward.Text = "Ligar";
			}
			else
			{
				btnManualOff.Bounds = new NxtControl.Drawing.RectF(20f, 314f, 100f, 34f);
				btnManualForward.Bounds = new NxtControl.Drawing.RectF(130f, 314f, 100f, 34f);
				btnManualForward.Text = "Avante";
			}
			Selecao(btnManualOff, spValue == 0);
			Selecao(btnManualForward, spValue == 1);
			Selecao(btnManualReverse, spValue == 2);
			tituloComando.Text = owner ? "Comando manual" : "Comando manual (em autom\u00e1tico: s\u00f3 indica)";

			txtSp.Enabled = (owner && !enSpdOwner || speedOwner && enSpdOwner) && seg && !oosVal;
			lDonoVel.Visible = btnSpeedOwner.Visible = enSpdOwner;
			lDonoVel.Text = "Dono da velocidade (atual: " + TextoDono(currSpeedOwner) + ")";
			btnSpeedOwner.Enabled = Seguro(SecOwner) && enSpdOwner;
			if (!enSpdOwner)
				btnSpeedOwner.Checked = owner;
			btnReset.Enabled = needReset && seg;
		}
		#endregion

		#region Botoes
		void BtnManualForwardClick(object sender, EventArgs e) { FireEvent_SP_CMD((short)SpOpFbState.Active1); }
		void BtnManualReverseClick(object sender, EventArgs e) { FireEvent_SP_CMD((short)SpOpFbState.Active2); }
		void BtnManualOffClick(object sender, EventArgs e) { FireEvent_SP_CMD((short)SpOpFbState.Passive); }
		void BtnResetClick(object sender, EventArgs e)
		{
			FireEvent_RESET_CMD(true, false);
			// reset do Motor_VS (o mesmo do antigo fpOptions): reseta a base e manda UM pulso de reset ao equipamento
			// (Sulzer: bit 2 da palavra de comando, so com o soprador parado). TRUE e logo FALSE = um clique, um pulso.
			NxtControl.GuiFramework.HMISymbol s = SimboloMotor();
			System.Reflection.MethodInfo m = s == null ? null : s.GetType().GetMethod("FireEvent_RESET", new Type[] { typeof(bool) });
			if (m != null)
			{
				m.Invoke(s, new object[] { true });
				m.Invoke(s, new object[] { false });
			}
		}
		void BtnSpeedOwnerCheckedChanged(object sender, EventArgs e)
		{
			if (btnSpeedOwner.Checked)
				FireEvent_SPEED_OWNER(false, true, true, false);
			else
				FireEvent_SPEED_OWNER(false, true, false, false);
		}
		#endregion
	}
}
