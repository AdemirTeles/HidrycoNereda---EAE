<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="29fc4316-d3a6-4bc9-9313-462b7a9dd0cc" Name="ISludgeHoldingTankStatus" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="24/08/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="903FCADE660A71D1" Name="STATUS">
        <With Var="HH" />
        <With Var="H" />
        <With Var="LevelAvailable" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="E7029D0CFFA0BD1B" Name="HH" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration ID="DEE031011FEE6E40" Name="H" Type="BOOL" Comment="Indication Data from Plug" />
      <VarDeclaration ID="CD00A1E724699AB6" Name="LevelAvailable" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="HH" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="HH" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="H" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="H" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>