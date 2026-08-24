<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="32778f1a-a792-452c-8f66-5866574a96d6" Name="IFlushReady" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="7/21/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="EB400628E9D6A506" Name="FLUSH_RDY" Comment="Confirmation from Plug">
        <With Var="FlushReady" />
        <With Var="FlushStarted" />
      </Event>
      <Event ID="A6EF038FCF65FFCE" Name="FLUSH_STARTED">
        <With Var="FlushStarted" />
        <With Var="FlushReady" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="948E4422D799D3D4" Name="FlushReady" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration ID="3B406C848FF944CA" Name="FlushStarted" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="FLUSH_RDY" Parameters="FlushReady" />
        <OutputPrimitive Interface="SOCKET" Event="FLUSH_RDY" Parameters="FlushReady" />
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