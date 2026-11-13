/*
 * Created by ApplicationLibDevTeam
 * 
 */

using System;
using System.Drawing;
using NxtControl.GuiFramework;
using System.ComponentModel;
using System.Resources;
using System.Runtime.InteropServices;
using SE.App2Base.SupportClasses;
using SE.App2CommonProcess.SupportClasses;

namespace SE.Nereda.Faceplates.MotorBaseNer
{
	/// <summary>
	/// Faceplate do motor sem inversor no padrao Hidryco. Receptores e comandos Schneider inalterados
	/// (SP_CMD 1 = ligar, 0 = desligar; OWNER 0x10 = operador, 0x08 = programa; RESET_CMD).
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
		bool simulationVal, overrideVal, maintenanceVal, oosVal;
		public bool isOverrideEnabled = true;
		void SimValueChanged(object sender, ValueChangedEventArgs e) { simulationVal = (bool)e.Value; Anormal(); }
		void OverValueChanged(object sender, ValueChangedEventArgs e) { overrideVal = (bool)e.Value; Anormal(); }
		void MaintValueChanged(object sender, ValueChangedEventArgs e) { maintenanceVal = (bool)e.Value; Anormal(); }
		void OosValueChanged(object sender, ValueChangedEventArgs e) { oosVal = (bool)e.Value; Anormal(); }
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
			SE.Nereda.Faceplates.MotorBaseNer.fpParameter fp = hmiFaceplate as SE.Nereda.Faceplates.MotorBaseNer.fpParameter;
			if (fp != null)
			{
				fp.Title = Title + " - Ajustes";
				fp.SecOwner = SecOwner;
				fp.SecParameter = SecParameter;
				fp.SecMode = SecMode;
				fp.SecSetpoint = SecSetpoint;
				fp.isOverrideEnabled = isOverrideEnabled;
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
			SE.Nereda.Faceplates.MotorBaseNer.fpTrend fp1 = hmiFaceplate as SE.Nereda.Faceplates.MotorBaseNer.fpTrend;
			if (fp1 != null)
			{
				fp1.Title = Title + " - Gr\u00e1fico";
				
			}
			base.OnInitializeFaceplate(hmiFaceplate);
			
		}

		[DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string TitleText
		{
			get { return Title; }
			set { Title = value; fpNavigationPane.ParentTitle = value; }
		}

		#region Dados
		bool Req_Reset, externControlled, Owner, StandardOwnerAvail;
		short FbStatusVal, TransVal, CSpValve, OpValue;
		ushort icurrentowner;
		void NeedResetValueChanged(object sender, ValueChangedEventArgs e) { Req_Reset = (bool)e.Value; Atualiza(); }
		void FbValueChanged(object sender, ValueChangedEventArgs e) { FbStatusVal = (short)e.Value; Atualiza(); }
		void TransFbStatusValueChanged(object sender, ValueChangedEventArgs e) { TransVal = (short)e.Value; Atualiza(); }
		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e) { CSpValve = (short)e.Value; Atualiza(); }
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e) { OpValue = (short)e.Value; Atualiza(); }
		void ExternalControlledValueChanged(object sender, ValueChangedEventArgs e) { externControlled = (bool)e.Value; Atualiza(); }
		void CurrentOwnerBasicValueChanged(object sender, ValueChangedEventArgs e)
		{
			icurrentowner = (ushort)e.Value;
			Owner = (icurrentowner == 0x10);
			Atualiza();
		}
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			StandardOwnerAvail = (bool)e.Value;
			ownerSwitch.ExternalAvailable = StandardOwnerAvail;
			
			if (StandardOwnerAvail)
			{	
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
			}
		}

		void FpDefaultUpdateOptionalService(string instancePath)
		{
			if (StandardOwnerAvail)
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
			
			fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.MotorLp.sDefault";
			fpNavigationPane.LocalPanel.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".localPanel";
			
			fpNavigationPane.Maintenance.SymbolType = "SE.App2CommonProcess.Symbols.DevMnt.sDefault";
			fpNavigationPane.Maintenance.InstanceName = FindInstanceLayer(InstanceLayer.Top)+".maintenance";
			
			ownerSwitch.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt)+".serviceManager.owner";
		}
		#endregion

		#region Desenho

		// Diagnostico: e um faceplate do CAT de cima (MotorS). O faceplate principal foi aberto pelo simbolo da base embutido
		// no simbolo da tela (Parent); sobe pelos grupos ate o simbolo do CAT de cima e pede a ele o fpDiagnostico.
		NxtControl.GuiFramework.HMISymbol SimboloMotor()
		{
			NxtControl.GuiFramework.GroupShape g = this.Parent as NxtControl.GuiFramework.GroupShape;
			while (g != null)
			{
				NxtControl.GuiFramework.HMISymbol s = g as NxtControl.GuiFramework.HMISymbol;
				if (s != null && s.GetType().Namespace == "SE.Nereda.Symbols.MotorS")
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
		void FpNavigationPaneOnParameterClick() { DoOpenFaceplate("fpParameter"); }
		void FpNavigationPaneOnTrendClick() { DoOpenFaceplate("fpTrend"); }

		void Atualiza()
		{
			// estado: mesma regra do faceplate Schneider (TransFbStatus 5 = parando, 6 = partindo; senao FbStatus)
			string est;
			NxtControl.Drawing.Color cx;
			if (TransVal == 5) { est = "PARANDO"; cx = new NxtControl.Drawing.Color(160, 160, 160); }
			else if (TransVal == 6) { est = "PARTINDO"; cx = new NxtControl.Drawing.Color(160, 160, 160); }
			else if (FbStatusVal == 1) { est = "LIGADO"; cx = new NxtControl.Drawing.Color(64, 64, 64); }
			else { est = "DESLIGADO"; cx = new NxtControl.Drawing.Color(255, 255, 255); }
			textoEstado.Text = est;
			caixaEstado.BrushColor = cx;
			textoComando.Text = "Comando atual: " + (CSpValve == 1 ? "Ligado" : "Desligado");
			textoSaida.Text = "Sa\u00edda atual: " + (OpValue == 1 ? "Ligado" : "Desligado") + (externControlled ? " (controle externo)" : "");
			textoSituacao.Text = Situacao(oosVal, maintenanceVal, simulationVal, overrideVal && isOverrideEnabled, Req_Reset);

			// mesma decodificacao do CurrOwnerDecode: programa = 16#8 (remoto) ou 16#4 (local); operador = 16#10 ou 16#40
			bool auto = icurrentowner == 0x08 || icurrentowner == 0x04;
			bool man = icurrentowner == 0x10 || icurrentowner == 0x40;
			Selecao(btnManual, man);
			Selecao(btnAutomatico, auto);
			btnManual.Enabled = btnAutomatico.Enabled = Seguro(SecOwner);

			// comando manual: mesma regra do ButtonEnablement Schneider
			bool seg = Seguro(SecSetpoint);
			if (Owner && seg && !oosVal)
			{
				btnManOff.Enabled = CSpValve == 1;
				btnManOn.Enabled = CSpValve == 0 && !Req_Reset;
			}
			else
				btnManOn.Enabled = btnManOff.Enabled = false;
			Selecao(btnManOn, CSpValve == 1);
			Selecao(btnManOff, CSpValve == 0);
			tituloComando.Text = Owner ? "Comando manual" : "Comando manual (em autom\u00e1tico: s\u00f3 indica)";
			btnReset.Enabled = Req_Reset && seg;
		}
		#endregion

		void BtnResetClick(object sender, EventArgs e) { FireEvent_RESET_CMD(true, false); }
		void BtnManOnClick(object sender, EventArgs e) { FireEvent_SP_CMD(1); }
		void BtnManOffClick(object sender, EventArgs e) { FireEvent_SP_CMD(0); }
	}
}
