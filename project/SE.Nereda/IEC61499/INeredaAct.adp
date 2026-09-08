<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="92cba82d-6667-44e2-8865-29dc836d46fd" Name="INeredaAct" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="6/7/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="9CD053F8408797ED" Name="FB_STATE">
        <With Var="FbStopped" />
        <With Var="FbRunning" />
        <With Var="FbForward" />
        <With Var="FbReverse" />
        <With Var="FbOpened" />
        <With Var="FbClosed" />
      </Event>
      <Event ID="F846995A4121D865" Name="FB_SPEED">
        <With Var="FbSpeedPv" />
      </Event>
      <Event ID="CC753684FA882790" Name="FB_READY">
        <With Var="FbReady" />
      </Event>
      <Event ID="C79FD2A34D0395C5" Name="FB_ALM">
        <With Var="FbAlarm" />
      </Event>
      <Event ID="476AAA40EB7AA926" Name="FB_FAIL">
        <With Var="FbFailure" />
      </Event>
      <Event ID="2DA8AEC15204E92D" Name="FB_OPD">
        <With Var="TotOpDur" />
        <With Var="CurrOpDur" />
        <With Var="OpCount" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="0F1CDF9A9B4A227A" Name="REQ_SP">
        <With Var="Sp" />
      </Event>
      <Event ID="1E00729184986247" Name="REQ_SPEED_SP">
        <With Var="SpeedSp" />
      </Event>
      <Event ID="37BBC1F841739733" Name="REQ_RESET">
        <With Var="Reset" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="D83B5BDEFA4D797C" Name="FbStopped" Type="BOOL" />
      <VarDeclaration ID="B762734C094A7162" Name="FbRunning" Type="BOOL" />
      <VarDeclaration ID="13E1B1B6EE0F07DB" Name="FbForward" Type="BOOL" />
      <VarDeclaration ID="3011FF733C667A56" Name="FbReverse" Type="BOOL" />
      <VarDeclaration ID="790C5C3BA88E0AF5" Name="FbSpeedPv" Type="REAL" />
      <VarDeclaration ID="7F6CC7FEB9223DF3" Name="FbOpened" Type="BOOL" />
      <VarDeclaration ID="A8D6C4A1FDCCA991" Name="FbClosed" Type="BOOL" />
      <VarDeclaration ID="8A8A07EFCDA1443C" Name="FbReady" Type="BOOL" />
      <VarDeclaration ID="BDD69968F2D82EAF" Name="FbAlarm" Type="BOOL" />
      <VarDeclaration ID="6EEAF63EEE6021B6" Name="FbFailure" Type="BOOL" />
      <VarDeclaration ID="C7F638DBF6B860D2" Name="TotOpDur" Type="UDINT" />
      <VarDeclaration ID="9224E22E0E82A2D7" Name="CurrOpDur" Type="UDINT" />
      <VarDeclaration ID="10624535249F94F3" Name="OpCount" Type="UDINT" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="710D7FC54EE3F35A" Name="Sp" Type="INT" />
      <VarDeclaration ID="1BC103921BBFDA0B" Name="SpeedSp" Type="REAL" />
      <VarDeclaration ID="EA28053F07575F36" Name="Reset" Type="BOOL" />
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