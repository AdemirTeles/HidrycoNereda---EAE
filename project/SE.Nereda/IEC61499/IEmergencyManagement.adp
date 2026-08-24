<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="b75d7430-8f44-4c81-a4b1-6f4c42a8cfeb" Name="IEmergencyManagement" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author="SESA371406" Date="11/28/2023" />
  <InterfaceList>
    <EventInputs>
      <Event ID="33EC5B834E8FFAF3" Name="CHECK_EXIST" />
    </EventInputs>
    <EventOutputs>
      <Event ID="PHASE_NO_ABORTED" Name="REACTOR_STATE">
        <With Var="PhaseAborted" />
        <With Var="PhaseRunning" />
        <With Var="ReactorAvailable" />
      </Event>
      <Event ID="FEED_TIME" Name="LAST_FEED_V_T">
        <With Var="CurrMinutesSinceStartFeedV" />
        <With Var="CurrMinutesSinceStartFeedT" />
        <With Var="TotMinutesSinceStartFeedV" />
        <With Var="TotMinutesSinceStartFeedT" />
      </Event>
      <Event ID="SD_REACTOR" Name="SD_REACTOR_RUN">
        <With Var="SDReactorRun" />
      </Event>
      <Event Name="MODE">
        <With Var="Mode" />
      </Event>
      <Event ID="12FB600C11F75EA2" Name="FB_EXIST">
        <With Var="FbExist" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="PhaseNoAborted" Name="PhaseAborted" Type="BOOL" />
      <VarDeclaration ID="3C69BB1A066E9338" Name="ReactorAvailable" Type="BOOL" />
      <VarDeclaration ID="PhaseRun" Name="PhaseRunning" Type="BOOL" />
      <VarDeclaration ID="FeedTime" Name="CurrMinutesSinceStartFeedV" Type="REAL" />
      <VarDeclaration ID="CD077CD9F3BB8B76" Name="CurrMinutesSinceStartFeedT" Type="TIME" />
      <VarDeclaration ID="8FB3B1E89F73B5E3" Name="TotMinutesSinceStartFeedV" Type="REAL" />
      <VarDeclaration ID="B60AD268A06073AC" Name="TotMinutesSinceStartFeedT" Type="TIME" />
      <VarDeclaration ID="SDReactor" Name="SDReactorRun" Type="BOOL" />
      <VarDeclaration Name="Mode" Type="INT" />
      <VarDeclaration ID="D997CA5474076632" Name="FbExist" Type="BOOL" />
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