/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/3/2026
 * Time: 10:19 AM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FieldSignals
{
	/// <summary>
	/// Description of sPanel.
	/// </summary>
	public partial class sPanel : NxtControl.GuiFramework.HMISymbol
	{
		bool ElecCircFail;
		bool SafetySwitchOff;
		bool FreqInverFail;
		int AtvEta;
		bool RemoteSel;
		bool AutoSel;
		bool PowerFb;
		bool AtvReady;
		bool Trip;
		bool Mdpms;
		public sPanel()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_NAME_Fired += REQ_NAME_Fired_EventHandler;
			this.REQ_SULZER_Fired += REQ_SULZER_Fired_EventHandler;
		}

		void SwitchElectriCircuitFailCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchElectriCircuitFailCheckedChanged
			ElecCircFail = SwitchElectriCircuitFail.Checked;
			LocalPanel();
		}

		void SwitchSafetySwitchOffCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchSafetySwitchOffCheckedChanged
			SafetySwitchOff = SwitchSafetySwitchOff.Checked;
			LocalPanel();
		}

		void SwitchFreqInverterFailCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchFreqInverterFailCheckedChanged
			FreqInverFail = SwitchFreqInverterFail.Checked;
			LocalPanel();
		}

		void SwitchRemoteCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchRemoteCheckedChanged
			RemoteSel = SwitchRemote.Checked;
			LocalPanel();
		}

		void SwitchAutoCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchAutoCheckedChanged
			AutoSel = SwitchAuto.Checked;
			LocalPanel();
		}

		void SwitchPowerFbCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchPowerFbCheckedChanged
			PowerFb = SwitchPowerFb.Checked;
			LocalPanel();
		}

		void SwitchAtvReadyCheckedChanged(object sender, EventArgs e)
		{
			// TODO: Implement SwitchAtvReadyCheckedChanged
			AtvReady = SwitchAtvReady.Checked;
			LocalPanel();
		}
		
		void LocalPanel()
		{
			if (ElecCircFail == false)
				LampElectriCircuitFail.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampElectriCircuitFail.BrushColor = new NxtControl.Drawing.Color(255, 0, 0);
		
			if (SafetySwitchOff == false)
				LampchSafetySwitchOff.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampchSafetySwitchOff.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (FreqInverFail == false)
				LampFreqInverterFail.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampFreqInverterFail.BrushColor = new NxtControl.Drawing.Color(255, 0, 0);
		
			if (RemoteSel == false)
				LampRemote.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampRemote.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (AutoSel == false)
				LampAuto.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampAuto.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (PowerFb == false)
				LampPowerFb.BrushColor = new NxtControl.Drawing.Color(210, 210, 210);
			else
				LampPowerFb.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
		
			if (AtvReady == false)
				LampAtvReady.BrushColor = new NxtControl.Drawing.Color(255, 0, 0);
			else
				LampAtvReady.BrushColor = new NxtControl.Drawing.Color(0, 255, 0);
			
			FireEvent_CNF_VALUES(ElecCircFail, SafetySwitchOff, FreqInverFail, RemoteSel, AutoSel, PowerFb, AtvReady);
		}

		void REQ_NAME_Fired_EventHandler(object sender, REQ_NAMEEventArgs e)
		{
			// TODO: Implement REQ_NAME_Fired_EventHandler
			PanelName.Text = e.Name;
		}
		// ---- Sulzer HST: codigo da falha inicial (Initial fault specifier, Process Data out 15) ----
		// Descricoes: lista "Eventos do compressor" do manual HST 10 (databook Sulzer, item 8.6.5).
		// So aparece nos equipamentos que publicam o codigo (symlink SulzerFaultCode), ou seja, os Sulzer.
		static readonly System.Collections.Generic.Dictionary<int, string> EventosSulzer = new System.Collections.Generic.Dictionary<int, string> {
			{1, "O bloqueio de software n\u00e3o est\u00e1 funcionando"},
			{2, "Erro de vers\u00e3o do bloqueio de software"},
			{3, "Dados de bloqueio de software ausentes"},
			{4, "Dados do VFD ausentes"},
			{5, "Atraso nos dados de bloqueio de software"},
			{6, "Atraso nos dados do VFD"},
			{7, "Dados de bloqueio de software inv\u00e1lidos"},
			{8, "Diverg\u00eancia dos dados do VFD com a solicita\u00e7\u00e3o"},
			{9, "Erro do sistema"},
			{10, "Configura\u00e7\u00e3o de f\u00e1brica n\u00e3o realizada"},
			{11, "Entrou no modo normal devido \u00e0 solicita\u00e7\u00e3o do usu\u00e1rio"},
			{12, "Entrou no modo de servi\u00e7o devido \u00e0 solicita\u00e7\u00e3o do usu\u00e1rio"},
			{13, "Entrou no modo mestre bloqueado"},
			{14, "Entrou no modo mestre desbloqueado"},
			{15, "Entrou no modo normal devido \u00e0 interrup\u00e7\u00e3o da conex\u00e3o do modo mestre"},
			{16, "Entrou no modo de servi\u00e7o devido \u00e0 interrup\u00e7\u00e3o da conex\u00e3o do modo mestre"},
			{17, "Entrada de seguran\u00e7a aberta"},
			{18, "Sinal de falha do VFD"},
			{19, "Sinal de falha interna"},
			{20, "Temperatura baixa da bobina do motor"},
			{21, "Temperatura alta da bobina do motor"},
			{23, "Viola\u00e7\u00e3o da solicita\u00e7\u00e3o de velocidade"},
			{24, "Viola\u00e7\u00e3o do torque m\u00e1ximo"},
			{25, "Viola\u00e7\u00e3o da pot\u00eancia m\u00e1xima de entrada"},
			{26, "Viola\u00e7\u00e3o da eleva\u00e7\u00e3o m\u00e1xima de press\u00e3o"},
			{27, "Erro do limitador de sa\u00edda"},
			{28, "Erro de avalia\u00e7\u00e3o de dados"},
			{29, "Tempo m\u00e1ximo de partida excedido"},
			{30, "Velocidade m\u00ednima do modo de vaz\u00e3o maior que a velocidade m\u00e1xima"},
			{31, "Erro de dados de entrada do controlador de vaz\u00e3o"},
			{32, "Dados da m\u00e1quina ausentes"},
			{33, "Local de controle selecionado ausente"},
			{34, "Erro de conex\u00e3o Fieldbus"},
			{35, "Prote\u00e7\u00e3o t\u00e9rmica contra instabilidade de funcionamento"},
			{36, "Press\u00e3o do inv\u00f3lucro demasiado baixa"},
			{37, "Aplicativo iniciado"},
			{38, "Par\u00e2metros n\u00e3o encontrados"},
			{39, "Falha ao salvar os par\u00e2metros"},
			{40, "Erro nas condi\u00e7\u00f5es de entrada medidas"},
			{41, "Erro de avalia\u00e7\u00e3o de dados da m\u00e1quina"},
			{42, "Condi\u00e7\u00f5es de entrada imposs\u00edveis"},
			{43, "Erro de avalia\u00e7\u00e3o da regi\u00e3o de vaz\u00e3o"},
			{44, "Rela\u00e7\u00e3o de press\u00e3o fora da faixa de validade do modelo"},
			{45, "Erro do limitador de refer\u00eancia"},
			{46, "Entrada auxiliar"},
			{47, "Temperatura de entrada de ar de processo baixa"},
			{48, "Temperatura de sa\u00edda do compressor baixa"},
			{49, "Temperatura do ar de refrigera\u00e7\u00e3o do motor baixa"},
			{50, "Temperatura do painel de controle baixa"},
			{51, "Temperatura de entrada de ar de processo alta"},
			{52, "Temperatura de sa\u00edda do compressor alta"},
			{53, "Temperatura do ar de refrigera\u00e7\u00e3o do motor alta"},
			{54, "Temperatura do painel de controle alta"},
			{55, "Sinal de temperatura inv\u00e1lido"},
			{56, "Sinal de temperatura ausente"},
			{57, "Erro de sinal de entrada anal\u00f3gica"},
			{58, "Erro da sa\u00edda anal\u00f3gica"},
			{59, "Erro de configura\u00e7\u00e3o no modo normal"},
			{60, "Erro do controlador PID"},
			{61, "Valor atual do PID n\u00e3o definido"},
			{62, "Erro de par\u00e2metro de escala do valor atual do PID"},
			{63, "Valor atual do PID inv\u00e1lido"},
			{64, "Press\u00e3o de entrada baixa"},
			{65, "Entrou no modo mestre offline devido \u00e0 interrup\u00e7\u00e3o da conex\u00e3o do modo mestre"},
			{66, "Entrou no modo de servi\u00e7o devido \u00e0 reutiliza\u00e7\u00e3o do ID do cliente no modo mestre"},
			{67, "Diverg\u00eancia de status da v\u00e1lvula de purga"},
			{68, "Coeficiente de perda de press\u00e3o do filtro de entrada de ar de processo alto"},
			{69, "Coeficiente de perda de press\u00e3o do filtro de entrada de ar de processo baixo"},
			{70, "Perda de press\u00e3o do filtro de entrada de ar de processo alta"},
			{71, "Bot\u00e3o de parada com bloqueio"},
			{72, "Bot\u00e3o externo de parada com bloqueio"},
			{73, "Erro de tens\u00e3o de sa\u00edda"},
			{74, "Erro de tens\u00e3o de alimenta\u00e7\u00e3o"},
			{75, "RS-232 indispon\u00edvel"},
			{76, "Erro de conex\u00e3o do MBC"},
			{77, "MBC n\u00e3o est\u00e1 em modo de opera\u00e7\u00e3o de funcionamento"},
			{78, "Desligamento do MBC"},
			{79, "Alarme do sistema do MBC"},
			{80, "Erro de posi\u00e7\u00e3o do seletor de programa do MBC"},
			{81, "Configura\u00e7\u00e3o incorreta de jumper no MBC"},
			{82, "Par\u00e2metros do MBC ausentes ou com os valores da configura\u00e7\u00e3o de f\u00e1brica"},
			{83, "O usu\u00e1rio do MBC provocou um alarme"},
			{84, "O MBC n\u00e3o recebeu dados do RS-232"},
			{85, "O MBC n\u00e3o recebeu dados pelo RS-485"},
			{86, "Erro de alimenta\u00e7\u00e3o CC do MBC"},
			{87, "Erro de alimenta\u00e7\u00e3o CA do MBC"},
			{88, "Tens\u00e3o baixa ap\u00f3s o retificador de entrada do MBC"},
			{89, "Tens\u00e3o alta ap\u00f3s o retificador de entrada do MBC"},
			{90, "Tens\u00e3o interna baixa do MBC"},
			{91, "Tens\u00e3o interna alta do MBC"},
			{92, "Ventilador de refrigera\u00e7\u00e3o do MBC de 24 V ausente"},
			{93, "Tens\u00e3o do DC-Link do MBC baixa"},
			{94, "Tens\u00e3o do DC-Link do MBC alta"},
			{95, "Falha do terra no sistema de rolamentos magn\u00e9ticos"},
			{96, "Alto consumo de energia do MBC"},
			{97, "MBC alimentado por baterias"},
			{98, "Fase de inicializa\u00e7\u00e3o do sistema de suporte com baterias do MBC"},
			{99, "Erro do sistema de suporte com baterias do MBC"},
			{100, "Limite de deslocamento do rotor excedido"},
			{101, "Limite do raio de giro do rotor excedido"},
			{102, "Dist\u00e2ncia axial at\u00e9 o rolamento de seguran\u00e7a muito pequena"},
			{103, "Limite de expans\u00e3o t\u00e9rmica excedido"},
			{104, "Temperatura do MBC baixa"},
			{105, "Temperatura do MBC alta"},
			{106, "Sinal do sensor de rota\u00e7\u00e3o ausente"},
			{107, "Rota\u00e7\u00e3o invertida do rotor ou polaridade incorreta do sinal"},
			{108, "Limite de velocidade de rota\u00e7\u00e3o excedido"},
			{109, "Limite dos rolamentos de seguran\u00e7a excedido"},
			{110, "Corrente DC alta nos rolamentos magn\u00e9ticos"},
			{111, "Satura\u00e7\u00e3o do amplificador do MBC"},
			{112, "Falha na bobina dos rolamentos magn\u00e9ticos"},
			{113, "A alimenta\u00e7\u00e3o das baterias do MBC n\u00e3o \u00e9 desligada"},
			{114, "\u00c9 necess\u00e1ria a substitui\u00e7\u00e3o da bateria de suporte do MBC"},
			{116, "Perda de press\u00e3o do filtro de ar de refrigera\u00e7\u00e3o do arm\u00e1rio de controle alta"},
			{117, "Perda de press\u00e3o do filtro de ar de refrigera\u00e7\u00e3o do painel de controle baixa"},
			{118, "Eleva\u00e7\u00e3o de press\u00e3o do arm\u00e1rio de controle alta"},
			{119, "Eleva\u00e7\u00e3o de press\u00e3o do arm\u00e1rio de controle baixa"},
			{120, "O usu\u00e1rio provocou o alarme"},
			{121, "Erro de sele\u00e7\u00e3o do local de controle"},
			{122, "O funcionamento de refrigera\u00e7\u00e3o foi iniciado"},
			{123, "O funcionamento de refrigera\u00e7\u00e3o foi conclu\u00eddo"},
			{124, "Refrigera\u00e7\u00e3o ignorada pelo usu\u00e1rio"},
			{125, "Funcionamento de refrigera\u00e7\u00e3o cancelado"},
			{126, "Observa\u00e7\u00e3o do usu\u00e1rio"},
			{127, "O registro (log) est\u00e1 cheio"},
			{128, "Opera\u00e7\u00e3o especial de software realizada"},
			{129, "Erro de conex\u00e3o do VFD"},
			{130, "Falha do VFD"},
			{131, "\u00c9 necess\u00e1ria a manuten\u00e7\u00e3o do filtro de ar de processo"},
			{132, "\u00c9 necess\u00e1ria a manuten\u00e7\u00e3o do filtro de ar de refrigera\u00e7\u00e3o"},
			{133, "\u00c9 necess\u00e1ria a manuten\u00e7\u00e3o do ventilador de refrigera\u00e7\u00e3o do VFD"},
			{134, "\u00c9 necess\u00e1ria a manuten\u00e7\u00e3o do suporte de baterias do MBC"},
			{135, "\u00c9 necess\u00e1ria a manuten\u00e7\u00e3o programada"},
			{136, "Falha no armazenamento do par\u00e2metro."},
			{137, "Foi feita a manuten\u00e7\u00e3o do filtro de ar de processo"},
			{138, "Foi feita a manuten\u00e7\u00e3o do filtro de ar de refrigera\u00e7\u00e3o"},
			{139, "Foi feita a manuten\u00e7\u00e3o do ventilador de refrigera\u00e7\u00e3o do VFD"},
			{140, "Foi feita a manuten\u00e7\u00e3o do suporte de baterias do MBC"},
			{141, "Foi feita a manuten\u00e7\u00e3o programada"},
			{142, "Reset dos contadores de funcionamento"},
			{143, "Erro de inicializa\u00e7\u00e3o do controle de vaz\u00e3o"},
			{144, "Erro de avalia\u00e7\u00e3o de dados de controle de vaz\u00e3o"},
			{145, "Erro de refer\u00eancia da entrada anal\u00f3gica"},
			{146, "Erro de sinal de entrada anal\u00f3gica"},
			{147, "Erro do sinal de sa\u00edda anal\u00f3gica"},
			{148, "Erro da sa\u00edda anal\u00f3gica"},
			{149, "Tens\u00e3o de sa\u00edda E/S do usu\u00e1rio baixa"},
			{150, "Tens\u00e3o de sa\u00edda E/S digital baixa"},
			{151, "Erro de tens\u00e3o de alimenta\u00e7\u00e3o"},
			{152, "Erro de monitoramento da fonte de alimenta\u00e7\u00e3o"},
			{153, "Press\u00e3o alta do filtro de ar de refrigera\u00e7\u00e3o do motor"},
			{154, "Press\u00e3o baixa do filtro de ar de refrigera\u00e7\u00e3o do motor"},
			{155, "Tens\u00e3o baixa do quadro de controle"},
			{156, "Tens\u00e3o alta do quadro de controle"},
			{157, "Modo de configura\u00e7\u00e3o de f\u00e1brica ativo"},
			{158, "Sinalizador rootfs de inicializa\u00e7\u00e3o de f\u00e1brica"},
			{159, "Ajuste em zero do sensor de press\u00e3o"},
		};

		void REQ_SULZER_Fired_EventHandler(object sender, SE.Nereda.Symbols.FieldSignals.REQ_SULZEREventArgs e)
		{
			int cod = e.SULZER_FALHA.HasValue ? e.SULZER_FALHA.Value : 0;
			string l1 = "Sulzer: sem falha", l2 = "";
			if (cod != 0)
			{
				string desc;
				if (!EventosSulzer.TryGetValue(cod, out desc)) desc = "evento sem descri\u00e7\u00e3o no manual";
				l1 = "Falha Sulzer " + cod.ToString() + ": " + desc;
				if (l1.Length > 58)
				{
					int corte = l1.LastIndexOf(' ', 58);
					if (corte < 20) corte = 58;
					l2 = l1.Substring(corte).TrimStart();
					l1 = l1.Substring(0, corte);
				}
			}
			NxtControl.Drawing.Color cor = cod == 0 ? new NxtControl.Drawing.Color(0, 128, 0) : new NxtControl.Drawing.Color(192, 0, 0);
			txtSulzerFalha.Text = l1;
			txtSulzerFalha2.Text = l2;
			txtSulzerFalha.Color = cor;
			txtSulzerFalha2.Color = cor;
			txtSulzerFalha.Visible = true;
			txtSulzerFalha2.Visible = l2.Length > 0;
		}
	}
}
