<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="2d0e5952-6430-4fca-9e5f-f7a5ae86bc37" Name="ISludgeBuffer" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="7/4/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="6E1E38EF865F33B9" Name="FB_SLB_FLUSH">
        <With Var="fbSludgeBufferFlush" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="53832F2A5D6ADA0F" Name="FB_PUMP_SBP_001">
        <With Var="FbRunningPump_sbp_001" />
        <With Var="FbStoppedPump_sbp_001" />
      </Event>
      <Event ID="E7834F57A023D9E9" Name="REQ_LT_003">
        <With Var="Value_lt_003" />
        <With Var="ValueMin_lt_003" />
        <With Var="ValueMax_lt_003" />
      </Event>
      <Event ID="C4552068F0BCC726" Name="REQ_STATUS_LT_003">
        <With Var="Status_lt_003" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="42FB791008946C6C" Name="fbSludgeBufferFlush" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="AEFD07E0C2212479" Name="FbRunningPump_sbp_001" Type="BOOL" />
      <VarDeclaration ID="7C3414AE091CC670" Name="FbStoppedPump_sbp_001" Type="BOOL" />
      <VarDeclaration ID="98ED49B8E6019185" Name="Value_lt_003" Type="REAL" />
      <VarDeclaration ID="C5E968D74BD846AF" Name="ValueMin_lt_003" Type="REAL" />
      <VarDeclaration ID="C09AFDABE4AE7C73" Name="ValueMax_lt_003" Type="REAL" />
      <VarDeclaration ID="3AE62655EE14D04A" Name="Status_lt_003" Type="Status" Namespace="SE.App2Base" />
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