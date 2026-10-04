<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="bc67895e-f111-4b11-bec3-d9e767526500" Name="IFeedRequest" Comment="Adapter Interface" Namespace="Hidryco.HidrycoLib">
  <Identification Standard="61499-1" />
  <VersionInfo Version="0.0" Author=" " Date="14/09/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="95D2FB68700BE4C9" Name="REQ" Comment="Request from Socket">
        <With Var="stsOperationCondition" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="1FBF0C498EEDAE17" Name="CNF" Comment="Confirmation from Plug">
        <With Var="stsFeedRun" />
        <With Var="stpFlow" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="3DAC8BD560B930F3" Name="stsOperationCondition" Type="BOOL" Comment="Request Data from Socket" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="2F702926EC9DA5EC" Name="stsFeedRun" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration ID="7977EB1D4722DF50" Name="stpFlow" Type="REAL" Comment="Indication Data from Plug" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="stsOperationCondition" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="stsOperationCondition" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF" Parameters="stsFeedRun" />
        <OutputPrimitive Interface="SOCKET" Event="CNF" Parameters="stsFeedRun" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="stpFlow" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="stpFlow" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>