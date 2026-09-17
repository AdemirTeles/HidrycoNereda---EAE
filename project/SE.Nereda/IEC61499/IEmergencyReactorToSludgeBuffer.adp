<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="262e61ce-bdb7-486b-a476-0327aaf37839" Name="IEmergencyReactorToSludgeBuffer" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="9/17/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="D46CB75BB047204F" Name="EMERGENCY_ON">
        <With Var="EmergencyON" />
      </Event>
      <Event ID="69A30D6F1EEC778E" Name="FORCE_UNAV">
        <With Var="ForceUnavaibility" />
      </Event>
      <Event ID="3F9F1A3D0BC5ACBF" Name="FEED_STS">
        <With Var="FeedStarted" />
        <With Var="FeedStopped" />
        <With Var="FeedAborted" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="128C534CB06CDD0F" Name="EmergencyON" Type="BOOL" />
      <VarDeclaration ID="A351B45A56D7A52F" Name="ForceUnavaibility" Type="BOOL" />
      <VarDeclaration ID="D455BE5F3243F8CD" Name="FeedStarted" Type="BOOL" />
      <VarDeclaration ID="98FFA78276DA0653" Name="FeedStopped" Type="BOOL" />
      <VarDeclaration ID="2680CB24DDCC2D3E" Name="FeedAborted" Type="BOOL" />
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