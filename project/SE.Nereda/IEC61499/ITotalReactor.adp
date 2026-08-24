<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="aa3c9948-02d3-496d-8721-c906e90d0560" Name="ITotalReactor" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="SESA371406" Date="11/29/2023" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="TOTAL_REACTOR" Comment="Confirmation from Plug">
        <With Var="TotalReactor" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="TotalReactor" Type="REAL" Comment="Confirmation Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="TOTAL_REACTOR" Parameters="TotalReactor" />
        <OutputPrimitive Interface="SOCKET" Event="TOTAL_REACTOR" Parameters="TotalReactor" />
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