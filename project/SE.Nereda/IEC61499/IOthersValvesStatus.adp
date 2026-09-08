<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="4d3fffb6-c99d-497f-bcee-bc04d73df148" Name="IOthersValvesStatus" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="6/8/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="B4A30F6DAB6EF21B" Name="FB_CURR_VLV" Comment="Request from Socket">
        <With Var="FbCurrValveOpened" />
        <With Var="FbCurrValveClosed" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="5A72FE57EFCA2A4E" Name="CNF_OTHERS_VLV" Comment="Confirmation from Plug">
        <With Var="OthersValvesOpend" />
        <With Var="OthersValvesClosed" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="C7B96BC610FD6BB3" Name="FbCurrValveOpened" Type="BOOL" />
      <VarDeclaration ID="D759E2565BA76BAB" Name="FbCurrValveClosed" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="9E431B8970B1C49E" Name="OthersValvesOpend" Type="BOOL" />
      <VarDeclaration ID="A43ABCC4AD397EE5" Name="OthersValvesClosed" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="FB_CURR_VLV" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="FB_CURR_VLV" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF_OTHERS_VLV" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF_OTHERS_VLV" Parameters="CNFD" />
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