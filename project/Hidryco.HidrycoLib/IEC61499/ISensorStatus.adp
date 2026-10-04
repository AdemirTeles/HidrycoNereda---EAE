<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="657e3838-9a3a-4da7-ad72-eb3819b632a4" Name="ISensorStatus" Comment="Adapter Interface" Namespace="Hidryco.HidrycoLib">
  <Identification Standard="61499-1" />
  <VersionInfo Version="0.0" Author=" " Date="15/09/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="9E548C371B42FEDC" Name="REQ" Comment="Request from Socket">
        <With Var="cmdReset" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="AB5911D326737849" Name="CNF_STATUS" Comment="Confirmation from Plug">
        <With Var="FbAlarmeHH" />
        <With Var="FbAlarmeH" />
        <With Var="FbAlarmeL" />
        <With Var="FbAlarmeLL" />
        <With Var="FbFailure" />
      </Event>
      <Event ID="C09F18F0C837B93D" Name="CNF_PV">
        <With Var="FbPv" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="E54954E6518AFFE0" Name="cmdReset" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="BC22E5B309EC3525" Name="FbPv" Type="REAL" />
      <VarDeclaration ID="7C32AA46813E72EF" Name="FbAlarmeHH" Type="BOOL" />
      <VarDeclaration ID="1A87F8257AB469E4" Name="FbAlarmeH" Type="BOOL" />
      <VarDeclaration ID="F1DB93298B22A3D1" Name="FbAlarmeL" Type="BOOL" />
      <VarDeclaration ID="D6ADC459B9EEBD4A" Name="FbAlarmeLL" Type="BOOL" />
      <VarDeclaration ID="C4FED0E2B2BCAFA9" Name="FbFailure" Type="BOOL" />
    </OutputVars>
  </InterfaceList>
  <Service RightInterface="PLUG" LeftInterface="SOCKET">
    <ServiceSequence Name="request_confirm">
      <ServiceTransaction>
        <InputPrimitive Interface="SOCKET" Event="REQ" Parameters="REQD" />
        <OutputPrimitive Interface="PLUG" Event="REQ" Parameters="REQD" />
      </ServiceTransaction>
      <ServiceTransaction>
        <InputPrimitive Interface="PLUG" Event="CNF_STATUS" Parameters="CNFD" />
        <OutputPrimitive Interface="SOCKET" Event="CNF_STATUS" Parameters="CNFD" />
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