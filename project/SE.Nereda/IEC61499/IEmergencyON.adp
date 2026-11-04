<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="d8e448f5-5159-4a87-9e37-c352c8d8d8e2" Name="IEmergencyON" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.2" Author="Hidryco" Date="04/11/2026" Remarks="0.1: ModoFalhaCom junto do EMERGENCY_ON. 0.2: EmergFalhaCom (BOOL) no lugar do ModoFalhaCom" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="AD43610D6FB98F77" Name="EMERGENCY_ON">
        <With Var="EmergencyOn" />
        <With Var="EmergFalhaCom" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="48D8B3883DEA1C42" Name="EmergencyOn" Type="BOOL" />
      <VarDeclaration ID="7E863FC5FAFD2047" Name="EmergFalhaCom" Type="BOOL" Comment="Falha de comunicacao em Automatico: TRUE vai para Emergencia, FALSE para Desligado" />
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