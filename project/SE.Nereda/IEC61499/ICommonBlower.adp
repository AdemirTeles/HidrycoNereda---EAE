<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="fd86b680-6e6a-4bd6-bff5-25deb34e565a" Comment="Adapter Interface" Name="ICommonBlower" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="SESA371406" Date="11/15/2023" />
  <InterfaceList>
    <EventInputs>
      <Event ID="FB_BLOWER" Name="FB_BLOWER_STATE">
        <With Var="FbRunningBlowser" />
        <With Var="FBStoppedBlowers" />
      </Event>
      <Event ID="FB_BLOWER_AVAILABLE" Name="FB_BLOWER_RDY">
        <With Var="FbReadyBlowers" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event Name="START_BLOWER">
        <With Var="StartBlowers" />
      </Event>
      <Event Name="FLOW_SP_BLOWER">
        <With Var="FlowSPBlowers" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="FBStart" Name="FbRunningBlowser" Type="BOOL" />
      <VarDeclaration ID="FBStop" Name="FBStoppedBlowers" Type="BOOL" />
      <VarDeclaration ID="FBBlowersAbailable" Name="FbReadyBlowers" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="StartBlower" Name="StartBlowers" Type="BOOL" />
      <VarDeclaration ID="FlowSPBlower" Name="FlowSPBlowers" Type="REAL" />
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