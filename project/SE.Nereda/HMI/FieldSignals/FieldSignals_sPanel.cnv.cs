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
			nomePainel = e.Name ?? "";
			MostraFalha();
		}
		// ---- Sulzer HST: codigo da falha inicial (Initial fault specifier, Process Data out 15) ----
		// Descricoes: lista "Eventos do compressor" do manual HST 10 (databook Sulzer, item 8.6.5).
		// So aparece nos equipamentos que publicam o codigo (symlink SulzerFaultCode), ou seja, os Sulzer.
		internal static readonly System.Collections.Generic.Dictionary<int, string> EventosSulzer = new System.Collections.Generic.Dictionary<int, string> {
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

		// ---- ATV600: codigo LFT 7121 (ultimo erro) -> mnemonico do display (planilha ATV600-Communication-parameters V4.6, lista LFT)
		internal static readonly System.Collections.Generic.Dictionary<int, string> FalhasAtv = new System.Collections.Generic.Dictionary<int, string> {
			{0, "NOF"}, {2, "EEF1"}, {3, "CFF"}, {4, "CFI"}, {5, "SLF1"}, {6, "ILF"}, {7, "CNF"}, {8, "EPF1"}, {9, "OCF"}, {10, "CRF1"}, {13, "LFF2"}, {15, "IHF"}, {16, "OHF"}, {17, "OLF"}, {18, "OBF"}, {19, "OSF"}, {20, "OPF1"}, {21, "PHF"}, {22, "USF"}, {23, "SCF1"}, {24, "SOF"}, {25, "TNF"}, {26, "INF1"}, {27, "INF2"}, {28, "INF3"}, {29, "INF4"}, {30, "EEF2"}, {32, "SCF3"}, {33, "OPF2"}, {34, "COF"}, {37, "INF7"}, {38, "EPF2"}, {40, "INF8"}, {42, "SLF2"}, {45, "SLF3"}, {51, "INF9"}, {52, "INFA"}, {53, "INFB"}, {54, "TJF"}, {55, "SCF4"}, {56, "SCF5"}, {58, "FCF1"}, {59, "FCF2"}, {60, "INFC"}, {64, "LCF"}, {68, "INF6"}, {69, "INFE"}, {71, "LFF3"}, {72, "LFF4"}, {73, "HCF"}, {77, "CFI2"}, {79, "LFF5"}, {80, "FFDF"}, {81, "MOF"}, {82, "LKON"}, {99, "CSF"}, {100, "ULF"}, {101, "OLC"}, {105, "ASF"}, {106, "LFF1"}, {107, "SAFF"}, {110, "TH2F"}, {111, "T2CF"}, {112, "TH3F"}, {113, "T3CF"}, {114, "PCPF"}, {115, "OPLF"}, {116, "HFPF"}, {117, "IPPF"}, {119, "PLFF"}, {120, "TH4F"}, {121, "T4CF"}, {122, "TH5F"}, {123, "T5CF"}, {124, "JAMF"}, {125, "OPHF"}, {126, "DRYF"}, {127, "PFMF"}, {128, "PGLF"}, {129, "PGRF"}, {130, "MPLF"}, {131, "LCLF"}, {132, "LCHF"}, {142, "INFG"}, {143, "INFH"}, {144, "INF0"}, {146, "INFD"}, {148, "STF"}, {149, "INFL"}, {150, "ETHF"}, {151, "INFF"}, {152, "FWER"}, {153, "INFM"}, {154, "INFP"}, {155, "INFK"}, {157, "INFR"}, {158, "INFN"}, {159, "SCF6"}, {160, "OBF2"}, {161, "INFS"}, {162, "IFA"}, {163, "IFB"}, {164, "IFC"}, {165, "IFD"}, {166, "CFA"}, {167, "CFB"}, {168, "CFC"}, {169, "TFA"}, {170, "TFB"}, {171, "TFC"}, {172, "TFD"}, {173, "CHF"}, {174, "URF"}, {175, "INFV"}, {176, "INFT"}, {177, "INFU"}, {179, "TJF2"}, {180, "CRF3"}, {181, "CFI3"}, {182, "CBF"}, {186, "MDLF"}, {190, "MPDF"}, {191, "ACF1"}, {192, "ACF2"}, {193, "MFF"}, {200, "FDR1"}, {201, "FDR2"}, {203, "P24C"}, {206, "DCRE"}, {207, "VCF"}, {208, "IDLF"}, {211, "SPFC"}, {212, "ACF3"}, {213, "COPF"}, {220, "AFLF"}
		};

		// ---- ATV600: codigo LFT -> texto em portugues (traducao da lista LFT da planilha V4.6)
		internal static readonly System.Collections.Generic.Dictionary<int, string> TextosAtv = new System.Collections.Generic.Dictionary<int, string> {
			{0, "Sem falha"}, {2, "Erro na mem\u00f3ria de controle"}, {3, "Configura\u00e7\u00e3o incorreta"}, {4, "Configura\u00e7\u00e3o inv\u00e1lida"}, {5, "Interrup\u00e7\u00e3o da comunica\u00e7\u00e3o Modbus"}, {6, "Interrup\u00e7\u00e3o da comunica\u00e7\u00e3o interna com o m\u00f3dulo opcional"}, {7, "Interrup\u00e7\u00e3o da comunica\u00e7\u00e3o de rede (fieldbus)"}, {8, "Falha externa detectada"}, {9, "Sobrecorrente"}, {10, "Falha no capacitor de pr\u00e9-carga"}, {13, "Perda do sinal 4-20 mA da AI2"}, {15, "Sobreaquecimento da entrada"}, {16, "Sobreaquecimento do inversor"}, {17, "Sobrecarga do motor"}, {18, "Sobretens\u00e3o no barramento CC"}, {19, "Sobretens\u00e3o na rede de alimenta\u00e7\u00e3o"}, {20, "Perda de uma fase de sa\u00edda"}, {21, "Perda de fase na entrada"}, {22, "Subtens\u00e3o na rede de alimenta\u00e7\u00e3o"}, {23, "Curto-circuito no motor"}, {24, "Sobrevelocidade do motor"}, {25, "Erro no autoajuste"}, {26, "Erro interno 1 (pot\u00eancia nominal)"}, {27, "Erro interno 2 (software)"}, {28, "Erro interno 3 (comunica\u00e7\u00e3o interna)"}, {29, "Erro interno 4 (fabrica\u00e7\u00e3o)"}, {30, "Erro na mem\u00f3ria de pot\u00eancia"}, {32, "Curto-circuito \u00e0 terra"}, {33, "Perda de fase na sa\u00edda"}, {34, "Interrup\u00e7\u00e3o da comunica\u00e7\u00e3o CANopen"}, {37, "Erro interno 7 (inicializa\u00e7\u00e3o)"}, {38, "Falha externa detectada pela rede"}, {40, "Erro interno 8 (fonte chaveada)"}, {42, "Interrup\u00e7\u00e3o da comunica\u00e7\u00e3o com o PC"}, {45, "Interrup\u00e7\u00e3o da comunica\u00e7\u00e3o com o terminal gr\u00e1fico"}, {51, "Erro interno 9 (medi\u00e7\u00e3o)"}, {52, "Erro interno 10 (rede)"}, {53, "Erro interno 11 (temperatura)"}, {54, "Sobreaquecimento do inversor (IGBT)"}, {55, "Curto-circuito no IGBT"}, {56, "Curto-circuito no motor"}, {58, "Contator de sa\u00edda fechado indevidamente"}, {59, "Contator de sa\u00edda aberto indevidamente"}, {60, "Erro interno 12 (alimenta\u00e7\u00e3o de corrente interna)"}, {64, "Falha no contator de entrada"}, {68, "Erro interno 6 (opcional)"}, {69, "Erro interno 14 (CPU)"}, {71, "Perda do sinal 4-20 mA da AI3"}, {72, "Perda do sinal 4-20 mA da AI4"}, {73, "Incompatibilidade entre placas"}, {77, "Erro na transfer\u00eancia da configura\u00e7\u00e3o"}, {79, "Perda do sinal 4-20 mA da AI5"}, {80, "Falha no retorno do ventilador"}, {81, "Sobreaquecimento do m\u00f3dulo"}, {82, "Erro de bloqueio ON"}, {99, "Erro na troca de canal"}, {100, "Subcarga do processo"}, {101, "Sobrecarga do processo"}, {105, "Erro de \u00e2ngulo"}, {106, "Perda do sinal 4-20 mA da AI1"}, {107, "Erro na fun\u00e7\u00e3o de seguran\u00e7a"}, {110, "N\u00edvel t\u00e9rmico da AI2"}, {111, "Erro no sensor t\u00e9rmico da AI2"}, {112, "N\u00edvel t\u00e9rmico da AI3"}, {113, "Erro no sensor t\u00e9rmico da AI3"}, {114, "Erro na partida do ciclo da bomba"}, {115, "Press\u00e3o de sa\u00edda baixa"}, {116, "Vaz\u00e3o alta"}, {117, "Erro na press\u00e3o de entrada"}, {119, "Vaz\u00e3o baixa da bomba"}, {120, "N\u00edvel t\u00e9rmico da AI4"}, {121, "Erro no sensor t\u00e9rmico da AI4"}, {122, "N\u00edvel t\u00e9rmico da AI5"}, {123, "Erro no sensor t\u00e9rmico da AI5"}, {124, "Erro do antitravamento (anti-jam)"}, {125, "Press\u00e3o de sa\u00edda alta"}, {126, "Bomba operando a seco"}, {127, "Erro no retorno do PID"}, {128, "Erro ao carregar o programa"}, {129, "Erro na execu\u00e7\u00e3o do programa"}, {130, "Bomba principal indispon\u00edvel"}, {131, "N\u00edvel baixo"}, {132, "N\u00edvel alto"}, {142, "Erro interno 16 (m\u00f3dulo de E/S - rel\u00e9)"}, {143, "Erro interno 17 (m\u00f3dulo de E/S - padr\u00e3o)"}, {144, "Erro interno 0 (IPC)"}, {146, "Erro interno 13 (corrente diferencial)"}, {148, "Motor travado"}, {149, "Erro interno 21 (rel\u00f3gio)"}, {150, "Interrup\u00e7\u00e3o da comunica\u00e7\u00e3o Ethernet embarcada"}, {151, "Erro interno 15 (mem\u00f3ria flash)"}, {152, "Erro na atualiza\u00e7\u00e3o de firmware"}, {153, "Erro interno 22 (Ethernet embarcada)"}, {154, "Erro interno 25 (incompatibilidade de placa e software)"}, {155, "Erro interno 20 (placa de interface do opcional)"}, {157, "Erro interno 27 (CPLD de diagn\u00f3stico)"}, {158, "Erro interno 23 (liga\u00e7\u00e3o de m\u00f3dulo)"}, {159, "Curto-circuito no AFE"}, {160, "Desequil\u00edbrio do barramento do AFE"}, {161, "Erro interno 28 (AFE)"}, {162, "Erro no circuito de monitora\u00e7\u00e3o A"}, {163, "Erro no circuito de monitora\u00e7\u00e3o B"}, {164, "Erro no circuito de monitora\u00e7\u00e3o C"}, {165, "Erro no circuito de monitora\u00e7\u00e3o D"}, {166, "Erro no circuito do painel A"}, {167, "Erro no circuito do painel B"}, {168, "Erro no circuito do painel C"}, {169, "Erro no enrolamento A do motor"}, {170, "Erro no enrolamento B do motor"}, {171, "Erro no mancal A do motor"}, {172, "Erro no mancal B do motor"}, {173, "Sobreaquecimento do painel"}, {174, "Subtens\u00e3o na rede do AFE"}, {175, "Erro interno 31 (m\u00f3dulo ausente)"}, {176, "Erro interno 29 (inversor)"}, {177, "Erro interno 30 (retificador)"}, {179, "Sobreaquecimento do IGBT do AFE"}, {180, "Erro no retorno do contator do AFE"}, {181, "Erro na transfer\u00eancia das pr\u00e9-configura\u00e7\u00f5es"}, {182, "Falha no disjuntor"}, {186, "Erro na liga\u00e7\u00e3o MultiDrive"}, {190, "Erro no dispositivo multibomba"}, {191, "Erro nos capacitores CC do AFE"}, {192, "Erro no controle de corrente do AFE"}, {193, "Frequ\u00eancia da rede fora da faixa"}, {200, "Erro no FDR da Ethernet embarcada"}, {201, "Erro no FDR do m\u00f3dulo Ethernet"}, {203, "Falta de 24 V nas E/S do painel"}, {206, "Ondula\u00e7\u00e3o no barramento CC"}, {207, "Erro no controle de v\u00f3rtice"}, {208, "Erro ao sair do modo de economia"}, {211, "Arquivos de seguran\u00e7a corrompidos"}, {212, "Erro no filtro de linha do AFE"}, {213, "Falha na bomba de refrigera\u00e7\u00e3o"}, {220, "Fun\u00e7\u00e3o avan\u00e7ada bloqueada"}
		};

		// Descricao da falha: curto = "45 - SLF3" (ATV) ou "45" (Sulzer); texto = descricao em portugues
		internal static void DescreveFalha(int cod, bool sulzer, out string curto, out string texto)
		{
			string mn;
			curto = cod.ToString(); texto = "";
			if (cod == 0) { curto = "nenhuma"; return; }
			if (sulzer) { if (!EventosSulzer.TryGetValue(cod, out texto)) texto = "evento sem descri\u00e7\u00e3o no manual"; return; }
			if (FalhasAtv.TryGetValue(cod, out mn)) curto = cod.ToString() + " - " + mn;
			if (!TextosAtv.TryGetValue(cod, out texto)) texto = "c\u00f3digo sem descri\u00e7\u00e3o na lista do ATV600";
		}


		string nomePainel = "";
		int codFalha;
		bool temCodigo;
		void REQ_SULZER_Fired_EventHandler(object sender, SE.Nereda.Symbols.FieldSignals.REQ_SULZEREventArgs e)
		{
			codFalha = e.SULZER_FALHA.HasValue ? e.SULZER_FALHA.Value : 0;
			temCodigo = true;
			MostraFalha();
		}

		// Sulzer (sopradores V4601-V4604): tabela de eventos do manual HST; ATV600 (Modbus generico): mnemonico do display
		void MostraFalha()
		{
			if (!temCodigo) return;
			int cod = codFalha;
			bool sulzer = nomePainel.Contains("V460");
			string l1, l2 = "";
			if (sulzer)
			{
				l1 = "Sulzer: sem falha";
				if (cod != 0)
				{
					string desc;
					if (!EventosSulzer.TryGetValue(cod, out desc)) desc = "evento sem descri\u00e7\u00e3o no manual";
					l1 = "Falha Sulzer " + cod.ToString() + ": " + desc;
				}
			}
			else
			{
				l1 = "Inversor: sem falha";
				if (cod != 0)
				{
					string curto, texto;
					DescreveFalha(cod, false, out curto, out texto);
					l1 = "Falha do inversor " + curto + ": " + texto;
				}
			}
			if (l1.Length > 58)
			{
				int corte = l1.LastIndexOf(' ', 58);
				if (corte < 20) corte = 58;
				l2 = l1.Substring(corte).TrimStart();
				l1 = l1.Substring(0, corte);
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
