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

namespace SE.Nereda.Faceplates.ValveBaseNer
{
	/// <summary>
	/// Faceplate da valvula no padrao Hidryco. Receptores e comandos Schneider inalterados
	/// (FbStatus/TransFbStatus/CurrentSp/CurrentOp/CurrentOwner; SP_CMD 1 = abrir, 2 = fechar; OWNER 0x10 = operador, 0x08 = programa).
	/// </summary>
	public partial class fpDefault : SE.App2Base.Faceplates.SEAppLibHMIFaceplate
	{
		public fpDefault()
		{
			InitializeComponent();
			this.AutoScroll = false;
			LigaDono();
			Atualiza();
		}

		#region Estados anormais
		bool Simulation, OverVal, Maintenece, oosVal;
		void SimValueChanged(object sender, ValueChangedEventArgs e) { Simulation = (bool)e.Value; AbnornalIndication(); }
		void OverValueChanged(object sender, ValueChangedEventArgs e) { OverVal = (bool)e.Value; AbnornalIndication(); }
		void MaintValueChanged(object sender, ValueChangedEventArgs e) { Maintenece = (bool)e.Value; AbnornalIndication(); }
		void OosValueChanged(object sender, ValueChangedEventArgs e) { oosVal = (bool)e.Value; AbnornalIndication(); }
		void AbnornalIndication()
		{
			fpNavigationPane.Abnormality("Parameter", Simulation || OverVal || Maintenece || oosVal, false);
			Atualiza();
		}
		#endregion

		#region Seguranca
		void FpDefaultSecurityOwnerChanged(bool isSecurity) { fpNavigationPane.SecOwner = SecOwner; ownerSwitch.SecOwner = SecOwner; Atualiza(); }
		void FpDefaultSecurityParameterChanged(bool isSecurity) { fpNavigationPane.SecParameter = SecParameter; }
		void FpDefaultSecuritySetpointChanged(bool isSecurity) { fpNavigationPane.SecSetpoint = SecSetpoint; Atualiza(); }
		bool Seguro(int nivel) { return ((NxtControl.Security.ISecuritySetValues)this).IsSetValuesSecure(nivel); }
		#endregion

		// Passa titulo e seguranca para os outros faceplates
		protected override void OnInitializeFaceplate(HMIFaceplate hmiFaceplate)
		{
			SE.Nereda.Faceplates.ValveBaseNer.fpParameter fp = hmiFaceplate as SE.Nereda.Faceplates.ValveBaseNer.fpParameter;
			if (fp != null)
			{
				fp.Title = Title + " - Ajustes";
				fp.SecMode = SecMode;
				fp.SecParameter = SecParameter;
				fp.SecOwner = SecOwner;
			}
			SE.Nereda.Faceplates.ValveBaseNer.fpTrend fp1 = hmiFaceplate as SE.Nereda.Faceplates.ValveBaseNer.fpTrend;
			if (fp1 != null)
				fp1.Title = Title + " - Gr\u00e1fico";
			base.OnInitializeFaceplate(hmiFaceplate);
		}

		#region UserProperties
		[DefaultValue(""), RefreshProperties(RefreshProperties.All), Category("Faceplate")]
		public string TitleText
		{
			get { return Title; }
			set { Title = value; fpNavigationPane.ParentTitle = value; }
		}
		private bool MaintVisiblity;
		public void MaintenanceVisibility(bool MntVisible) { MaintVisiblity = MntVisible; }
		private bool LpVisiblity;
		public void LocalPanelVisibility(bool LpVisible) { LpVisiblity = LpVisible; }
		private bool IlckVisiblity, PermVisiblity, FailVisiblity;
		public void InterPermFailVisibility(bool IlckVisible, bool PermVisible, bool FailVisible)
		{
			IlckVisiblity = IlckVisible; PermVisiblity = PermVisible; FailVisiblity = FailVisible;
		}
		#endregion UserProperties

		#region Dados
		bool needReset;
		short PvValve, TransPvValve, CSpValve, OpValve;
		ushort icurrentowner;
		bool Owner;           // operador (manual) e o dono
		void NeedResetValueChanged(object sender, ValueChangedEventArgs e) { needReset = (bool)e.Value; Atualiza(); }
		void PvValueChanged(object sender, ValueChangedEventArgs e) { PvValve = (short)e.Value; Atualiza(); }
		void TransFbStatusChanged(object sender, ValueChangedEventArgs e) { TransPvValve = (short)e.Value; Atualiza(); }
		void CurrentSpValueChanged(object sender, ValueChangedEventArgs e) { CSpValve = (short)e.Value; Atualiza(); }
		void CurrentOpValueChanged(object sender, ValueChangedEventArgs e) { OpValve = (short)e.Value; Atualiza(); }
		void CurrentOwnerBasicValueChanged(object sender, ValueChangedEventArgs e)
		{
			icurrentowner = (ushort)e.Value;
			Owner = (icurrentowner == 0x10);
			Atualiza();
		}

		bool StandardOwnerAvail;
		void StdOwnerConnectedValueChanged(object sender, ValueChangedEventArgs e)
		{
			StandardOwnerAvail = (bool)e.Value;
			ownerSwitch.ExternalAvailable = StandardOwnerAvail;
			if (StandardOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt) + ".serviceManager.owner";
			}
		}

		void FpDefaultUpdateOptionalService(string instancePath)
		{
			if (StandardOwnerAvail)
			{
				fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
				fpNavigationPane.Owner.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt) + ".serviceManager.owner";
			}
			fpNavigationPane.Interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock";
			fpNavigationPane.Interlock.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".interlock";
			fpNavigationPane.Permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissive";
			fpNavigationPane.Permissive.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".permissive";
			fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.ValveLp.sDefault";
			fpNavigationPane.LocalPanel.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".localPanel";
			fpNavigationPane.Maintenance.SymbolType = "SE.App2CommonProcess.Symbols.DevMnt.sDefault";
			fpNavigationPane.Maintenance.InstanceName = FindInstanceLayer(InstanceLayer.Top) + ".maintenance";
			ownerSwitch.InstanceName = FindInstanceLayer(InstanceLayer.BaseExt) + ".serviceManager.owner";
		}
		#endregion

		#region Desenho
		static string Cmd(short v) { return v == 1 ? "Abrir" : (v == 2 ? "Fechar" : "-"); }

		static void Selecao(DrawnButton b, bool sel)
		{
			b.BrushColor = sel ? new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))) : new NxtControl.Drawing.Color(((byte)(215)), ((byte)(215)), ((byte)(215)));
			b.TextColor = sel ? new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))) : new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			b.TextColorMouseDown = b.TextColor;
			b.TextDisabledColor = sel ? new NxtControl.Drawing.Color(((byte)(205)), ((byte)(205)), ((byte)(205))) : new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150)));
		}

		void Atualiza()
		{
			// estado: mesma regra do faceplate Schneider (FbStatus + TransFbStatus)
			string est;
			NxtControl.Drawing.Color cx;
			if ((PvValve != 1 && PvValve != 2) && (TransPvValve == 6 || TransPvValve == 7))
			{
				est = TransPvValve == 6 ? "ABRINDO" : "FECHANDO";
				cx = new NxtControl.Drawing.Color(160, 160, 160);
			}
			else if (PvValve == 1)
			{
				est = "ABERTA";
				cx = new NxtControl.Drawing.Color(64, 64, 64);
			}
			else if (PvValve == 0 || PvValve == 2)
			{
				est = "FECHADA";
				cx = new NxtControl.Drawing.Color(255, 255, 255);
			}
			else
			{
				est = "DESCONHECIDA";
				cx = new NxtControl.Drawing.Color(255, 255, 255);
			}
			textoEstado.Text = est;
			caixaEstado.BrushColor = cx;
			textoComando.Text = "Comando atual: " + Cmd(CSpValve);
			textoSaida.Text = "Sa\u00edda atual: " + Cmd(OpValve);
			string sit = "";
			if (oosVal) sit += (sit == "" ? "" : " | ") + "Fora de servi\u00e7o";
			if (Maintenece) sit += (sit == "" ? "" : " | ") + "Manuten\u00e7\u00e3o";
			if (Simulation) sit += (sit == "" ? "" : " | ") + "Simula\u00e7\u00e3o";
			if (OverVal) sit += (sit == "" ? "" : " | ") + "Realimenta\u00e7\u00e3o for\u00e7ada";
			if (needReset) sit += (sit == "" ? "" : " | ") + "Aguardando reset";
			textoSituacao.Text = sit;

			// modo (dono): 0x10 = operador = manual, 0x08 = programa = automatico
			// mesma decodificacao do CurrOwnerDecode: programa = 16#8 (remoto) ou 16#4 (local); operador = 16#10 ou 16#40
			bool auto = icurrentowner == 0x08 || icurrentowner == 0x04;
			bool man = icurrentowner == 0x10 || icurrentowner == 0x40;
			Selecao(btnManual, man);
			Selecao(btnAutomatico, auto);
			btnManual.Enabled = btnAutomatico.Enabled = Seguro(SecOwner);

			// comando manual: mesma regra do faceplate Schneider (so o oposto do setpoint atual)
			bool pode = Owner && Seguro(SecSetpoint) && !oosVal;
			btnManOn.Enabled = pode && CSpValve != 1;
			btnManOff.Enabled = pode && CSpValve != 2;
			Selecao(btnManOn, CSpValve == 1);
			Selecao(btnManOff, CSpValve == 2);
			tituloComando.Text = Owner ? "Comando manual" : "Comando manual (em autom\u00e1tico: s\u00f3 indica)";
			btnReset.Enabled = needReset && Seguro(SecSetpoint);
		}
		#endregion

		#region Botoes
		void BtnResetClick(object sender, EventArgs e) { FireEvent_RESET_CMD(true); }
		void BtnManOnClick(object sender, EventArgs e) { FireEvent_SP_CMD(1); }
		void BtnManOffClick(object sender, EventArgs e) { FireEvent_SP_CMD(2); }

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
		#endregion
	}
}
