<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="4a3fe6d6-398e-4477-b3e7-914e4f78b919" Name="IEmergencySludgeBuffer" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.1" Author=" " Date="30/10/2026" Remarks="0.1: evento PHASE_STATE com o estado das 4 fases (o passo da emergencia so termina com a fase parada)." />
  <InterfaceList>
    <EventInputs>
      <Event ID="01031D6AC20FAB24" Name="LVL">
        <With Var="Level" />
      </Event>
      <Event ID="BBC4AE70863ED310" Name="FB_FEED">
        <With Var="FeedReady" />
        <With Var="FeedRun" />
        <With Var="FeedInterlock" />
        <With Var="FeedStopping" />
        <With Var="FeedAborted" />
      </Event>
      <Event ID="FD5E09F22E2FB8C9" Name="FB_WAIT">
        <With Var="WaitReady" />
        <With Var="WaitRun" />
        <With Var="WaitInterlock" />
      </Event>
      <Event ID="D7091D88C8316783" Name="FB_SLD_DIS">
        <With Var="SludgeDischargeReady" />
        <With Var="SludgeDischargeRun" />
        <With Var="SludgeDischargeInterlocked" />
      </Event>
      <Event ID="4C01A7A01C491F67" Name="FB_SUPER_DIS">
        <With Var="SupernantDischargeReady" />
        <With Var="SupernantDischargeRun" />
        <With Var="SupernantDischargeInterlock" />
      </Event>
      <Event ID="A17A02573698B1DF" Name="ABORT_FALLBACK">
        <With Var="AbortFallback" />
      </Event>
      <Event ID="596B692476DDC92F" Name="PHASE_STATE" Comment="Mudanca de estado de alguma fase do Sludge Buffer (emergencia)">
        <With Var="FeedState" />
        <With Var="WaitState" />
        <With Var="SDState" />
        <With Var="SupState" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="4D4A6D622AA6CDB1" Name="EMER_ON">
        <With Var="EmergencyOn" />
      </Event>
      <Event ID="37BB0210227B4D88" Name="FEED">
        <With Var="CmdFeed" />
      </Event>
      <Event ID="B8FB7A13CF18B1CA" Name="WAIT">
        <With Var="CmdWait" />
      </Event>
      <Event ID="7AF6A44EC4713EB1" Name="SLD_DISCHARGE">
        <With Var="CmdSludgeDischarge" />
      </Event>
      <Event ID="6CE3EC6EFAA8A173" Name="SLD_SUPERNANAT">
        <With Var="CmdSupernantDischarge" />
      </Event>
      <Event ID="E88B6064739B22D1" Name="PAR">
        <With Var="SludgeDischargeCapacity" />
        <With Var="SupernantDischargeCapacity" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="91843A91DDCD538F" Name="Level" Type="REAL" />
      <VarDeclaration ID="D440A766CB8B17CF" Name="FeedReady" Type="BOOL" />
      <VarDeclaration ID="0408EC495DD13DC3" Name="FeedRun" Type="BOOL" />
      <VarDeclaration ID="19D1A02D19FBE393" Name="FeedStopping" Type="BOOL" />
      <VarDeclaration ID="D65512BA79AD6051" Name="FeedAborted" Type="BOOL" />
      <VarDeclaration ID="C46CE53379F5294A" Name="FeedInterlock" Type="BOOL" />
      <VarDeclaration ID="862A2E6EE70C20AF" Name="WaitReady" Type="BOOL" />
      <VarDeclaration ID="D88E26B5943BE63E" Name="WaitRun" Type="BOOL" />
      <VarDeclaration ID="18727D2D2A93A202" Name="WaitInterlock" Type="BOOL" />
      <VarDeclaration ID="695399F703F77E2B" Name="SludgeDischargeReady" Type="BOOL" />
      <VarDeclaration ID="F0EA458A3A0698F3" Name="SludgeDischargeRun" Type="BOOL" />
      <VarDeclaration ID="A279159B5A0CF8D3" Name="SludgeDischargeInterlocked" Type="BOOL" />
      <VarDeclaration ID="76FC2A554E83498F" Name="SupernantDischargeReady" Type="BOOL" />
      <VarDeclaration ID="08F354F7946D6684" Name="SupernantDischargeRun" Type="BOOL" />
      <VarDeclaration ID="FA3C227BD61E1E98" Name="SupernantDischargeInterlock" Type="BOOL" />
      <VarDeclaration ID="4D9DEF47F3639353" Name="AbortFallback" Type="BOOL" />
      <VarDeclaration ID="D5425DB8CCE26155" Name="FeedState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="A5D797AAA6D0B931" Name="WaitState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="0B49AE3B48508CEF" Name="SDState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
      <VarDeclaration ID="48F7B66A5538DD21" Name="SupState" Type="STRING[50]" Comment="Estado da fase (Phase.State)" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="A1711B52790021B0" Name="EmergencyOn" Type="BOOL" />
      <VarDeclaration ID="0CCCE0E6A38C4CC4" Name="CmdFeed" Type="BOOL" />
      <VarDeclaration ID="2D97C7DF176F1821" Name="CmdWait" Type="BOOL" />
      <VarDeclaration ID="CC5E48971A6D3B85" Name="CmdSludgeDischarge" Type="BOOL" />
      <VarDeclaration ID="FDC6C047971AF4AB" Name="CmdSupernantDischarge" Type="BOOL" />
      <VarDeclaration ID="290CB544BD4AF7E0" Name="SludgeDischargeCapacity" Type="REAL" />
      <VarDeclaration ID="D5F6310F45243454" Name="SupernantDischargeCapacity" Type="REAL" />
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