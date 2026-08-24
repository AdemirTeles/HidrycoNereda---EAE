<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="5117ebf5-0670-43cd-b46a-56f1ec9d69ed" Name="IFlushReq" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="6/23/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="91C62E5F9EC3AD97" Name="FLUSH_RDY">
        <With Var="FlushReady" />
      </Event>
      <Event ID="058C8BB5EF4C4954" Name="CMD_FLUSH">
        <With Var="CmdOpenValve014" />
        <With Var="CmdCloseValve014" />
        <With Var="CmdReduceSpeed" />
      </Event>
      <Event ID="A591EFC748C65FB0" Name="FLUSH_FLOW_SP">
        <With Var="FlushFlowSp" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="158ACCEF11EA11F4" Name="FB_FLUSH">
        <With Var="FbOpenValve014" />
        <With Var="FbCloseValve014" />
        <With Var="FbSpeedReduced" />
        <With Var="FbPumpRunning" />
        <With Var="FbPumpStopped" />
        <With Var="WasHiLevel" />
        <With Var="WasLoLevel" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="B5CD30493D22784A" Name="FlushReady" Type="BOOL" />
      <VarDeclaration ID="78ED129B4768A8A1" Name="CmdOpenValve014" Type="BOOL" />
      <VarDeclaration ID="23612E77D592C190" Name="CmdCloseValve014" Type="BOOL" />
      <VarDeclaration ID="10050E1891596878" Name="CmdReduceSpeed" Type="BOOL" />
      <VarDeclaration ID="34B76CCA964D89EE" Name="FlushFlowSp" Type="REAL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="309BBEDA7DF51DE0" Name="FbOpenValve014" Type="BOOL" />
      <VarDeclaration ID="E3447F193E0C5923" Name="FbCloseValve014" Type="BOOL" />
      <VarDeclaration ID="102FEFFE81A835E5" Name="FbPumpRunning" Type="BOOL" />
      <VarDeclaration ID="32E78DF7D9CBD985" Name="FbPumpStopped" Type="BOOL" />
      <VarDeclaration ID="0154EF4D281C90FC" Name="FbSpeedReduced" Type="BOOL" />
      <VarDeclaration ID="F75B2D6279DB7772" Name="WasHiLevel" Type="BOOL" />
      <VarDeclaration ID="FBD19C5680BE3A13" Name="WasLoLevel" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CMD_FLUSH" Parameters="StartFlush" />
        <OutputPrimitive Interface="SOCKET" Event="CMD_FLUSH" Parameters="StartFlush" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="IND" Parameters="StopFlush" />
        <OutputPrimitive Interface="SOCKET" Event="IND" Parameters="StopFlush" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="RSP" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="RSP" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>