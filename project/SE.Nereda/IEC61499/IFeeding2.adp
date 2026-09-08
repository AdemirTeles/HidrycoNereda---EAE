<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="9e385e9c-2213-46ed-a476-29873280337c" Name="IFeeding2" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="6/7/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="5A11906EF1EE87B0" Name="HI_LEVEL" Comment="Request from Socket">
        <With Var="HighLevel" />
      </Event>
      <Event ID="7593DE3331C575B6" Name="FLOW_PV" Comment="Response from Socket">
        <With Var="FlowPv" />
      </Event>
      <Event ID="03923062E780DBFC" Name="PUMP_FB">
        <With Var="PumpFbRunning" />
        <With Var="PumpFbStopped" />
      </Event>
      <Event ID="70EEE9F2AA8AC204" Name="PUMP_READY">
        <With Var="PumpReady" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="74BA0DB8212F2576" Name="START_FEED" Comment="Confirmation from Plug">
        <With Var="StartFeeding" />
      </Event>
      <Event ID="8D6216DA6F1D1AB3" Name="CAPACITY_FEED" Comment="Indication from Plug">
        <With Var="CapacityFeeding" />
      </Event>
      <Event ID="64A31C18B824409C" Name="PHASE">
        <With Var="Run" />
        <With Var="Stopping" />
      </Event>
      <Event ID="9C2DC160D0649F17" Name="RESET_P">
        <With Var="ResetPump" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="2B9DC646C4F67E84" Name="HighLevel" Type="BOOL" Comment="Request Data from Socket" />
      <VarDeclaration ID="E608EE3E510ADBC9" Name="FlowPv" Type="REAL" Comment="Response Data from Socket" />
      <VarDeclaration ID="15E0B0692568D904" Name="PumpFbRunning" Type="BOOL" />
      <VarDeclaration ID="78D0DDD34C9EF9F8" Name="PumpFbStopped" Type="BOOL" />
      <VarDeclaration ID="B41B0731DC9AD731" Name="PumpReady" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="9A80F414E2AF6B87" Name="StartFeeding" Type="BOOL" Comment="Confirmation Data from Plug" />
      <VarDeclaration ID="D7CF71AAE7A3D95C" Name="CapacityFeeding" Type="REAL" Comment="Indication Data from Plug" />
      <VarDeclaration ID="EAF64D7B7C3D74B7" Name="Run" Type="BOOL" />
      <VarDeclaration ID="7208B850FC6F172F" Name="Stopping" Type="BOOL" />
      <VarDeclaration ID="48C5E5A256C6457A" Name="ResetPump" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="HI_LEVEL" Parameters="HighLevel" />
        <OutputPrimitive Interface="PLUG" Event="HI_LEVEL" Parameters="HighLevel" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="START_FEED" Parameters="StartFeeding" />
        <OutputPrimitive Interface="SOCKET" Event="START_FEED" Parameters="StartFeeding" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CAPACITY_FEED" Parameters="CapacityFeeding" />
        <OutputPrimitive Interface="SOCKET" Event="CAPACITY_FEED" Parameters="CapacityFeeding" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="FLOW_PV" Parameters="FlowPv" />
        <OutputPrimitive Interface="PLUG" Event="FLOW_PV" Parameters="FlowPv" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>