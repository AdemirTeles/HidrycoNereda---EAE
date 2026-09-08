<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="d8efff9c-74b7-4498-80db-ce8ba683814e" Name="IGritScreenFlushing" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="7/6/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="727D767C86127C4D" Name="FB_GS_INST_FLUSH">
        <With Var="FbGritScreenInstFlush" />
      </Event>
      <Event ID="0804B8CDC1B712F8" Name="AMB_TEMP_PV">
        <With Var="AmbientTemperaturePv" />
      </Event>
      <Event ID="9850048ED095E451" Name="REQ_START_GS">
        <With Var="ReqStartGritScreen" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="469E3B76B9D721DD" Name="FB_INFLUENT_FEED_PMP">
        <With Var="FbFeedInf_Stopped" />
        <With Var="FbFeedInf_Running" />
      </Event>
      <Event ID="1F1020E82AE58441" Name="FB_INFLUET_DRAIN_PMP">
        <With Var="FbDrainInf_Stopped" />
        <With Var="FbDrainInf_Running" />
      </Event>
      <Event ID="8B235293E5389BC7" Name="FB_GS_MOTOR">
        <With Var="FbGritScreenStopped" />
        <With Var="FbGritScreenRunning" />
      </Event>
      <Event ID="9EB419218931A109" Name="FREEZ_WEATHER">
        <With Var="FreezWeather" />
      </Event>
      <Event ID="84E5BD043B0B9D2B" Name="FT_001">
        <With Var="NVPP_001_ft_001" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="3A1846690B174C3E" Name="FbGritScreenInstFlush" Type="BOOL" />
      <VarDeclaration ID="F5105E8545B1ACE0" Name="AmbientTemperaturePv" Type="REAL" />
      <VarDeclaration ID="9EB3C16A25E3E4D9" Name="ReqStartGritScreen" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="DB5751043930F3B0" Name="FbFeedInf_Stopped" Type="BOOL" />
      <VarDeclaration ID="76B4FEAFDB90B7B7" Name="FbFeedInf_Running" Type="BOOL" />
      <VarDeclaration ID="E2165610E67441AB" Name="FbDrainInf_Stopped" Type="BOOL" />
      <VarDeclaration ID="48F01954AB34CBCD" Name="FbDrainInf_Running" Type="BOOL" />
      <VarDeclaration ID="CA59F9F3463F604B" Name="FbGritScreenStopped" Type="BOOL" />
      <VarDeclaration ID="917420DCD3928957" Name="FbGritScreenRunning" Type="BOOL" />
      <VarDeclaration ID="B8A74FB92C78BAA2" Name="FreezWeather" Type="BOOL" />
      <VarDeclaration ID="1B5136012ECA25B4" Name="NVPP_001_ft_001" Type="REAL" />
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