<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="79a198aa-6472-4342-a54c-811b46a79d2b" Name="IMotStatus" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="3/5/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="DA4A5AB166737E2B" Name="CIRCUIT_FAIL">
        <With Var="ElectricCircuitFail" />
      </Event>
      <Event Name="SAF_SWT">
        <With Var="SafetySwitchOff" />
      </Event>
      <Event Name="FREQ_FAIL">
        <With Var="FrequencyInverterFail" />
      </Event>
      <Event Name="ATV_STE">
        <With Var="AtvReady" />
      </Event>
      <Event Name="REM_SEL">
        <With Var="RemoteSelect" />
      </Event>
      <Event Name="AUTO_SEL">
        <With Var="AutoSelect" />
      </Event>
      <Event Name="PWR_FB">
        <With Var="PowerFb" />
      </Event>
      <Event ID="8F309C1427B3D8B8" Name="TRIP_FB">
        <With Var="TripFb" />
      </Event>
      <Event ID="58CE25A170A20217" Name="MDP_MS">
        <With Var="MoistureDetectionPumpMS" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="9BFF267744CD9FD6" Name="ElectricCircuitFail" Type="BOOL" />
      <VarDeclaration ID="78CB3852B3811624" Name="SafetySwitchOff" Type="BOOL" />
      <VarDeclaration ID="D764D50DE95B92F7" Name="FrequencyInverterFail" Type="BOOL" />
      <VarDeclaration ID="469BA920D864796D" Name="AtvReady" Type="BOOL" />
      <VarDeclaration ID="EF0659DE8FA343F8" Name="RemoteSelect" Type="BOOL" />
      <VarDeclaration ID="1313714BCA2AD84D" Name="AutoSelect" Type="BOOL" />
      <VarDeclaration ID="DFE83B4BA65B6F23" Name="PowerFb" Type="BOOL" />
      <VarDeclaration ID="56D1AD5F30D2DBE7" Name="TripFb" Type="BOOL" />
      <VarDeclaration ID="6ADAD9BF6A0BA01D" Name="MoistureDetectionPumpMS" Type="BOOL" />
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