<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="cad350e4-55e7-4e29-9999-401be521e4d4" Name="IMode" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="SESA371406" Date="11/16/2023" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="MODE" Comment="Response from Socket">
        <With Var="Mode" />
      </Event>
      <Event Name="RESET" Comment="Request from Socket">
        <With Var="Reset" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="Mode" Type="INT" Comment="Response Data from Socket" />
      <VarDeclaration Name="Reset" Type="BOOL" Comment="Request Data from Socket" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RESET" Parameters="Reset" />
        <OutputPrimitive Interface="PLUG" Event="RESET" Parameters="Reset" />
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
        <InputPrimitive Interface="SOCKET" Event="MODE" Parameters="Mode" />
        <OutputPrimitive Interface="PLUG" Event="MODE" Parameters="Mode" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>