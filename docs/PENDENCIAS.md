# Pendências de campo - ETE Tijuco Preto (EAE)

Itens que dependem de informação de fornecedor ou de verificação em campo. A lógica já está pronta para recebê-los; o que estiver marcado **A DEFINIR** no `.hcf` precisa ser corrigido no EAE.

## Fase sólida (900 - PCE LODO / M262_Lodo)

| # | Item | Situação | Onde ajustar |
|---|---|---|---|
| S1 | **Medidores de vazão de lodo 900-FT-01, 900-FT-02 e 900-FT-07**: modelo e mapa de registradores Modbus desconhecidos. A planilha de IPs tem dois conjuntos (900-FT-01/02/03/07 em .166 a .169; "Medidor de vazão prensa 1/2/3" em .194 a .196, RTU). | Escravos Modbus provisórios (vazão REAL em m³/h) marcados A DEFINIR. Sem o FT real o PID de alimentação de cada prensa não fecha. | hcf do M262_Lodo, bus das prensas/FT |
| S2 | Linha de cada prensa: **AD-01 = 900-FT-01, AD-02 = 900-FT-02** (definido pelo usuário, conforme a planilha; o P&ID FLX-002 mostra FT-03 na AD-02). | Definido. Corrigir o P&ID. | - |
| S3 | Remota Lodo2 (.136, A10/A11 TM3AI8) é lida pelo **M262_Nereda** (bus MB_REMOTAS_LODO, canais 0-3 como 41-LT-1005, 42-LT-1005, 40-LIT-0001, 49-LIT-0001) e pelo **M262_Lodo** (canais 0-1 = 900-LIT-01/02, conforme PCE LODO). O mesmo canal não pode ser dois instrumentos: confirmar em campo o que está ligado em %IW0.0 a %IW0.3. | Mantido como o usuário pediu. | hcf do M262_Nereda e do M262_Lodo |
| S4 | Tabelas Modbus da Vibropac (prensa PV35525 e preparador PV36142) trazem IP 192.168.0.10 (padrão do fornecedor). IPs da planta: prensa 1 .237, prensa 2 .240, preparador .216. | Configurar os CLPs dos skids. Confirmar se os endereços "4001..." são holding 40001 (offset 4000) ou 4001. | CLPs Vibropac / hcf |
| S5 | PCE LODO: bornes de campo de RL47, RL48 e RL52 a RL56 aparecem na régua XS1, já usada (provável XS3). | Conferir no PCM LODO. | - |
| S6 | PCE LODO %I0.0 (RL1): o relé diz "DISJUNTOR LIGADO PCE", o contato do Q1 diz "DISJUNTOR DESLIGADO PCE". | Confirmar a lógica do contato. Fora do aviso de disjuntor até confirmar. | - |
| S7 | Emergência do PCM LODO (%I0.1) tratada como contato **NF** (FALSE = emergência), igual ao PCM da EEE Bruto. FALHA UCP das bombas também NF. | Confirmar no PCM LODO. | IO_DI32 / CAT |
| S8 | **900-VA-12** (segunda fase) sem escravo Modbus: a lógica a considera **fechada** no isolamento das rotas BO→AD-02. | Garantir em campo que fica fechada até a AD-03 existir. | - |
| S9 | 900-LIT-01/02: o nível em % depende da **altura máxima** configurada no faceplate de cada sensor. Sem ela o nível fica 0 % e as bombas ficam bloqueadas por "tanque baixo". | Configurar altura e faixa dos LIT no comissionamento. | IHM |
| S10 | Bombas, sopradores e booster (Motor_Generico) partem em **manual** a cada reinício do CLP (modo não persistente, padrão da biblioteca). | Operador coloca em automático. | IHM |
| S11 | Dosadoras de polímero M4/M5 não têm comando nem setpoint pela rede (tabela PV36142): a dosagem é ajustada no próprio preparador. | Ajustar a dosagem no skid conforme a vazão de lodo. | Skid |
| S12 | AD-03, VA-12 e FT-03 (segunda fase): instâncias criadas e desabilitadas; sem escravo no hcf (IPs .243/.231/.168 reservados). | Criar os escravos quando instalados. | hcf do M262_Lodo |
| S13 | Dosadoras de polímero: a tela considera **900-DO-01 = motor M4** e **900-DO-02 = motor M5** do preparador (tabela PV36142). Base: posição no fluxograma Vibropac DE-36142-VCE-001 (M4/B2 em cima) e no P&ID FLX-002 (DO-01 em cima). | Confirmar no painel do preparador qual bomba é M4. Se for o contrário, trocar os rótulos DO-01/DO-02 no símbolo sPolimero e no fpSkid. | IHM (Preparador_Vibropac) |

## Desinfecção (700 - M262_Lodo)

| # | Item | Situação |
|---|---|---|
| D1 | 700-VC-01 (Coester CSR6T): atuador comprado ON/OFF; modulação contínua precisa confirmação AVK/Coester. Programar Word 36 bit 12 e ação na falha de comunicação = Nenhuma; IP pelo IP-Config. | Aberto |
| D2 | Trojan UV3000Plus: unit ID e offset dos registradores; regra do 2º canal no SCC; analisador de UVT ausente. | Aberto |
| D3 | SC4500 (pH/OD .156 e turbidez .157): mapa de registradores e swapWords. | Aberto |
| D4 | Remota desinfecção .137: semântica das DIs 0/1 (contato de disjuntor DESLIGADO do PCE/PCM). | Aberto |
| D5 | M262_Lodo sem DPAC_FULLINIT; nunca compilado/implantado. Sintonia do PID da VC-01. | Aberto |
