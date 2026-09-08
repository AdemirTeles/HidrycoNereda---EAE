<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="9e2071cd-c9ec-44e5-93b7-e1df39105516" Name="IResetValves" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="7/6/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="6762F1A42616FBAF" Name="FB_NEED_RESET">
        <With Var="FbNeedReset" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="DB2F31576D7C8341" Name="RESET">
        <With Var="Reset" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="175754047DFBD268" Name="FbNeedReset" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="C45940A1007F76EB" Name="Reset" Type="BOOL" />
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