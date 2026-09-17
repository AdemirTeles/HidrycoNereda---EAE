<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="a7eaaba4-3f68-4e9d-b961-8558b64c34b1" Name="ISludgeBufferToReactors" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="9/17/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="C2C5F94C0FA89EA2" Name="SLB_FEED_PHASE">
        <With Var="SLBFeedPhaseAborted" />
        <With Var="SLBFeedPhaseInterlocked" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="51FC34A07BFB4F2B" Name="SLBFeedPhaseAborted" Type="BOOL" />
      <VarDeclaration ID="46E0963548A81AB0" Name="SLBFeedPhaseInterlocked" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="ReactorFeedPhaseStarted" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="ReactorFeedPhaseStarted" />
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