<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="65faf231-1e1f-4243-bed4-3793d3ca812f" Name="OpCdtHMI" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="7/6/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="B62733FB079B1110" Name="FB_NEED_UPDATE">
        <With Var="NeedUpdate" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="57D880E7B4DD84B2" Name="REQ_UPDATE">
        <With Var="Update" />
      </Event>
      <Event ID="9CE1FFC72E63FFDE" Name="REQ_ACTIVE_UPDATE">
        <With Var="ActiveUpdate" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="A77022E881639D2E" Name="NeedUpdate" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="29C601027D1EC51C" Name="Update" Type="BOOL" />
      <VarDeclaration ID="03792516DF9C82F0" Name="ActiveUpdate" Type="BOOL" />
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