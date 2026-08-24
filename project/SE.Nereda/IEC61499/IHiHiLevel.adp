<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="79842457-4964-4654-ac1c-9b5ad3e43ded" Name="IHiHiLevel" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="6/21/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="15126F43E529BB4F" Name="HIHI_LEVEL">
        <With Var="HiHiLevel" />
        <With Var="LevelSwitch" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="C818324478A2F205" Name="HiHiLevel" Type="BOOL" />
      <VarDeclaration ID="96B50ADF37756FFC" Name="LevelSwitch" Type="BOOL" />
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