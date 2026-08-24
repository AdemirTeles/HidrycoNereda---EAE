<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="943bf5d8-0c73-48e1-8979-b22d71e1c49c" Name="IPhase" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="schneider" Date="19/04/2022" />
  <InterfaceList>
    <EventInputs>
      <Event ID="REQ_Start_Ready" Name="FB_START_READY">
        <With Var="FbStartReady" />
      </Event>
      <Event ID="REQ_Stop_Ready" Name="FB_STOP_READY">
        <With Var="FbStopReady" />
      </Event>
      <Event ID="REQ_Abort_Ready" Name="FB_ABORT_READY">
        <With Var="FbAbortReady" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="Interlocked_CNF" Name="CNF_PHASE">
        <With Var="Interlocked" />
        <With Var="Ready" />
        <With Var="Starting" />
        <With Var="Run" />
        <With Var="Stopping" />
        <With Var="Aborting" />
        <With Var="Aborted" />
      </Event>
      <Event ID="State_CNF" Name="CNF_STATE">
        <With Var="State" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="Start_Ready" Name="FbStartReady" Type="BOOL" />
      <VarDeclaration ID="Stop_Ready" Name="FbStopReady" Type="BOOL" />
      <VarDeclaration ID="Abort_Ready" Name="FbAbortReady" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration Name="Ready" Type="BOOL" />
      <VarDeclaration Name="Starting" Type="BOOL" />
      <VarDeclaration Name="Run" Type="BOOL" />
      <VarDeclaration Name="Stopping" Type="BOOL" />
      <VarDeclaration Name="Aborting" Type="BOOL" />
      <VarDeclaration Name="Aborted" Type="BOOL" />
      <VarDeclaration Name="Interlocked" Type="BOOL" />
      <VarDeclaration Name="State" Type="STRING[50]" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF_READY" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF_READY" Parameters="CNFD" />
      </ServiceTransaction>
    </ServiceSequence>
    <ServiceSequence Name="indication_response">
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF_STARTING" Parameters="INDD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF_STARTING" Parameters="INDD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="New_Op_Cdt" Parameters="RSPD" />
        <OutputPrimitive Interface="PLUG" Event="New_Op_Cdt" Parameters="RSPD" />
      </ServiceTransaction>
    </ServiceSequence>
  </Service>
</AdapterType>