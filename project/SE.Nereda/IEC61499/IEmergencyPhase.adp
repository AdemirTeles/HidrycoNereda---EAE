<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="aa436a7d-2ed3-49a6-bf58-847055ae7ede" Name="IEmergencyPhase" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.2" Author=" " Date="29/10/2026" Remarks="0.1: AerateAborted (fase Aerate abortada) para a receita de emergencia. 0.2: XInterlocked (sem uso) -&gt; XState (estado da fase) e evento PHASE_STATE, para o contador dos passos." />
  <InterfaceList>
    <EventInputs>
      <Event ID="3CBA18632C5993F7" Name="FEED_RDY_ILCK">
        <With Var="FeedReady" />
        <With Var="FeedRun" />
      </Event>
      <Event ID="B9A3DD1A626C862D" Name="AERATION_RDY_ILCK">
        <With Var="AerateReady" />
        <With Var="AerateRun" />
        <With Var="AerateAborted" />
      </Event>
      <Event ID="4DCB92F6993C5EE1" Name="SD_RDY_ILCK">
        <With Var="SDReady" />
        <With Var="SDRun" />
        <With Var="SDStopping" />
        <With Var="SDAborted" />
      </Event>
      <Event ID="CF95EBECB4A2EBBE" Name="LL_RDY_ILCK">
        <With Var="LLReady" />
      </Event>
      <Event ID="3F1D0A688A5176FD" Name="V_AER_RDY_ILCK">
        <With Var="VentAerateReady" />
      </Event>
      <Event ID="2E6F627FE71D38B1" Name="V_SLD_RDY_ILCK">
        <With Var="VentSludgeReady" />
      </Event>
      <Event ID="B334EFD88038E789" Name="W_RDY_ILCK">
        <With Var="WReady" />
      </Event>
      <Event ID="1F4F3B9CDE5DCB1C" Name="L1">
        <With Var="L1v" />
      </Event>
      <Event ID="0001D958FDF5E959" Name="L2">
        <With Var="L2v" />
      </Event>
      <Event ID="2DDA8AB533D7441D" Name="IFB_LVL">
        <With Var="InfluentBufferLevelReached" />
      </Event>
      <Event ID="423C760A7E390A03" Name="R_AV">
        <With Var="ReactorAvailable" />
      </Event>
      <Event ID="27FAE745C524EBCD" Name="PHASE_STATE" Comment="Mudanca de estado de qualquer fase (contador dos passos da emergencia)">
        <With Var="FeedState" />
        <With Var="AerateState" />
        <With Var="SDState" />
        <With Var="LLState" />
        <With Var="VentAerationGridState" />
        <With Var="VentSludgeGridState" />
        <With Var="WaitState" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="42529785B6820948" Name="FEED">
        <With Var="CmdFeed" />
      </Event>
      <Event ID="B633B7A44F850807" Name="AERATE">
        <With Var="CmdAerate" />
      </Event>
      <Event ID="B3BCF5E9C62C69B8" Name="SLUDGE_DISCHARGE">
        <With Var="CmdSludgeDischarge" />
      </Event>
      <Event ID="2000F66036015D52" Name="LOWER_LEVEL">
        <With Var="CmdLowerLevel" />
      </Event>
      <Event ID="ACC2803E6ACB558D" Name="VENT">
        <With Var="CmdVent" />
      </Event>
      <Event ID="0F544A40694CE400" Name="VENT_AERATION">
        <With Var="CmdVentAeration" />
      </Event>
      <Event ID="DAE1720DE74FAACB" Name="VENT_SLUDGE">
        <With Var="CmdVentSludge" />
      </Event>
      <Event ID="8A3A142CC73C9F25" Name="WAIT">
        <With Var="CmdWait" />
      </Event>
      <Event ID="0FA2667D36826F2B" Name="EMERGENCY_ON">
        <With Var="EmergencyON" />
      </Event>
      <Event ID="BC34E8F0E0F52444" Name="FEED_PAR">
        <With Var="CapacityFeed" />
      </Event>
      <Event ID="1BDE0720AC8B4391" Name="AERATION_PAR">
        <With Var="CapacityAeration" />
        <With Var="InfluentGrid" />
        <With Var="AerationGrid" />
      </Event>
      <Event ID="FF8E2C9D67AADBF4" Name="VENT_PAR">
        <With Var="AirVentGrid" />
        <With Var="AirVentInfGrid" />
      </Event>
      <Event ID="0E231F82B8E69271" Name="SLUDGE_GRID_PAR">
        <With Var="SludgeGrid" />
      </Event>
      <Event ID="4E395DC016F294D9" Name="AIR_LICK_PAR">
        <With Var="AirLockTime" />
      </Event>
      <Event ID="3CAF22C03BECB249" Name="FORCE_UNAV">
        <With Var="ForceUnavaibility" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="599667ECF678E518" Name="FeedReady" Type="BOOL" />
      <VarDeclaration ID="F208B10244BCFEF2" Name="FeedRun" Type="BOOL" />
      <VarDeclaration ID="3A105CF8591A3B4A" Name="FeedState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="656FC0E59D395E4C" Name="AerateReady" Type="BOOL" />
      <VarDeclaration ID="A63167A113600EB8" Name="AerateRun" Type="BOOL" />
      <VarDeclaration ID="1D41180E6BEABB84" Name="AerateState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="DE5DEF6F279D1DB2" Name="AerateAborted" Type="BOOL" Comment="Fase Aerate abortada (encerra o S5 da receita de emergencia)" />
      <VarDeclaration ID="9CFBB312DE29B9C4" Name="SDReady" Type="BOOL" />
      <VarDeclaration ID="28136BA3C9D3697F" Name="SDRun" Type="BOOL" />
      <VarDeclaration ID="7D771324D6C25283" Name="SDStopping" Type="BOOL" />
      <VarDeclaration ID="8B042E931163B61F" Name="SDAborted" Type="BOOL" />
      <VarDeclaration ID="64A740ED538C4B9B" Name="SDState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="A1460632301E8B7F" Name="LLReady" Type="BOOL" />
      <VarDeclaration ID="560E73BEB3AC34E7" Name="LLState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="E996774D431E1B79" Name="VentAerateReady" Type="BOOL" />
      <VarDeclaration ID="F76A95D4365E942C" Name="VentAerationGridState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="800D089965342DF6" Name="VentSludgeReady" Type="BOOL" />
      <VarDeclaration ID="1B1E58279B462F55" Name="VentSludgeGridState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="A92252B4F4DF917A" Name="WReady" Type="BOOL" />
      <VarDeclaration ID="E33DF607900BF079" Name="WaitState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="579DEB3758BDB938" Name="L1v" Type="BOOL" />
      <VarDeclaration ID="1156E288C0C38120" Name="L2v" Type="BOOL" />
      <VarDeclaration ID="C54C3886CAD71D0C" Name="InfluentBufferLevelReached" Type="BOOL" />
      <VarDeclaration ID="F1682C43F359618E" Name="ReactorAvailable" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="8B7B31E6EA54014D" Name="CmdFeed" Type="BOOL" />
      <VarDeclaration ID="09084E8C7BADBD46" Name="CmdAerate" Type="BOOL" />
      <VarDeclaration ID="C947D1396F3B0873" Name="CmdSludgeDischarge" Type="BOOL" />
      <VarDeclaration ID="419E697BA1D2FB08" Name="CmdLowerLevel" Type="BOOL" />
      <VarDeclaration ID="6926B570C8BA75E8" Name="CmdVent" Type="BOOL" />
      <VarDeclaration ID="198FB8D9804ED082" Name="CmdVentAeration" Type="BOOL" />
      <VarDeclaration ID="486306180C62B9EF" Name="CmdVentSludge" Type="BOOL" />
      <VarDeclaration ID="C584AEAB998AB515" Name="CmdWait" Type="BOOL" />
      <VarDeclaration ID="5159724764416574" Name="EmergencyON" Type="BOOL" />
      <VarDeclaration ID="34423AC7BCF3714C" Name="CapacityFeed" Type="REAL" />
      <VarDeclaration ID="8B46E1E2CAE6076D" Name="CapacityAeration" Type="REAL" />
      <VarDeclaration ID="A29A102F17AA7B5F" Name="InfluentGrid" Type="BOOL" />
      <VarDeclaration ID="EC5E58B468310216" Name="AerationGrid" Type="BOOL" />
      <VarDeclaration ID="51705890CC419D73" Name="AirVentGrid" Type="BOOL" />
      <VarDeclaration ID="F44F737D6F09989F" Name="AirVentInfGrid" Type="BOOL" />
      <VarDeclaration ID="A062B937FF3F100B" Name="SludgeGrid" Type="BOOL" />
      <VarDeclaration ID="86DD4C5333164B26" Name="AirLockTime" Type="TIME" />
      <VarDeclaration ID="63583CB69DED3592" Name="ForceUnavaibility" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="CNFD" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="INDD" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="INDD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>