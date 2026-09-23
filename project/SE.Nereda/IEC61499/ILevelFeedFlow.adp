<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="573c5b5d-ef19-4d65-8492-846203372132" Name="ILevelFeedFlow" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="9/23/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="CC9428CCDD032224" Name="CNF" Comment="Confirmation from Plug" />
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="957DAAEC5C0D7635" Name="FeedFlowLevelStart" Type="REAL" />
      <VarDeclaration ID="B6B46A0A077DA337" Name="FeedFlowLevelCheck" Type="REAL" />
      <VarDeclaration ID="74D3D4DE3ED1D6B7" Name="FeedFlowOk" Type="BOOL" />
      <VarDeclaration ID="102CC7A878D73816" Name="FeedFlowInsufficient" Type="BOOL" />
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