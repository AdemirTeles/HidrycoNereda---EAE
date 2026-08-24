<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="48ba814c-1920-41b0-8b45-03ebab65704b" Name="IPhaseStatus" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="schneider" Date="19/04/2022" />
  <InterfaceList>
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