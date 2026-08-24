<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="eccbf66f-6d25-4261-80be-46e90e16bd90" Name="IAIStatus" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="3/4/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="5E4B64CA1C13B8FF" Name="STATUS" Comment="Confirmation from Plug">
        <With Var="Status" />
      </Event>
      <Event ID="0EE264450E13F48C" Name="ERROR">
        <With Var="Error" />
      </Event>
      <Event ID="7A542E38889AD863" Name="TEMP">
        <With Var="Temp_C" />
      </Event>
      <Event ID="B7F22091CD20E50E" Name="RELIABILITY">
        <With Var="Reliability" />
      </Event>
      <Event ID="28292D402F2FF4AD" Name="DTM">
        <With Var="DaysToMaintenance" />
      </Event>
      <Event ID="9AB24631D5CB7536" Name="ALM">
        <With Var="ChFailAlarm" />
      </Event>
      <Event ID="345A1B84719E81CF" Name="OVER">
        <With Var="OverrideStatus" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="B041611FD4630B12" Name="Status" Type="INT" />
      <VarDeclaration ID="AEED229B1A79C3D3" Name="Error" Type="INT" />
      <VarDeclaration ID="F7EFA613AECFA949" Name="Temp_C" Type="REAL" />
      <VarDeclaration ID="7E801A3D14F8993F" Name="Reliability" Type="INT" />
      <VarDeclaration ID="6FB195A940C6F07B" Name="DaysToMaintenance" Type="INT" />
      <VarDeclaration ID="711254F0BA414691" Name="ChFailAlarm" Type="BOOL" />
      <VarDeclaration ID="C60745C2D02E38CD" Name="OverrideStatus" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="STATUS" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="STATUS" Parameters="CNFD" />
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