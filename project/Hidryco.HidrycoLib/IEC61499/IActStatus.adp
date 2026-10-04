<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="53b2a6c0-c8d9-4015-9ca3-073827eb68ac" Name="IActStatus" Comment="Adapter Interface" Namespace="Hidryco.HidrycoLib">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="6/8/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="14377629A1F197A9" Name="REQ_STATUS">
        <With Var="FbStopped" />
        <With Var="FbRunning" />
        <With Var="FbOpened" />
        <With Var="FbClosed" />
        <With Var="FbReady" />
      </Event>
      <Event ID="03F1F1C982EE8DD5" Name="REQ_FbSpeed">
        <With Var="FbSpeedPv" />
      </Event>
      <Event ID="7C93B3F2EA708DB4" Name="REQ_FbCapacity">
        <With Var="FbCapacityPv" />
      </Event>
      <Event ID="BBEA373EFC18FCD4" Name="REQ_FbHorimetro">
        <With Var="FbHorimetro" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="227987A2F0C6A825" Name="FbStopped" Type="BOOL" />
      <VarDeclaration ID="D41A46B14EF7208D" Name="FbRunning" Type="BOOL" />
      <VarDeclaration ID="B9E42D72CEF16844" Name="FbSpeedPv" Type="REAL" />
      <VarDeclaration ID="63F2604DAA7CFD9F" Name="FbCapacityPv" Type="REAL" Comment="Valor em %" />
      <VarDeclaration ID="72E790857420193D" Name="FbOpened" Type="BOOL" />
      <VarDeclaration ID="3A653A8838D163CA" Name="FbClosed" Type="BOOL" />
      <VarDeclaration ID="9E0B44559326BEAF" Name="FbReady" Type="BOOL" />
      <VarDeclaration ID="6786798CC8B69406" Name="FbHorimetro" Type="TIME" />
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