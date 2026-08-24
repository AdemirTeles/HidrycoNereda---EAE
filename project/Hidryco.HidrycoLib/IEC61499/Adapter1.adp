<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="9aca9fe6-b007-4053-9866-c50e75d0226f" Name="Adapter1" Comment="Adapter Interface" Namespace="Hidryco.HidrycoLib">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="26/02/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event Name="e_sts">
        <With Var="boiaAlta" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration Name="boiaAlta" Type="INT" />
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