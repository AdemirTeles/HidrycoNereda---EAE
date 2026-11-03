<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="e9c8114b-7093-4c4a-ba63-0ea289e576db" Name="IReactorData" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="7/4/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="D499D06F1953A020" Name="S5_AERATE_T">
        <With Var="S5_AerateTimeT" />
        <With Var="S5_AerateTimeV" />
      </Event>
      <Event ID="CE55FDD88A0009BF" Name="S1_FEED_T">
        <With Var="S1_FeedTimeT" />
        <With Var="S1_FeedTimeV" />
      </Event>
      <Event ID="138EEC247A2C05E7" Name="FEED_RUN">
        <With Var="FeedingRun" />
      </Event>
      <Event ID="48081868B719DABE" Name="CURR_STEP_STATE">
        <With Var="CurrStep" />
        <With Var="SDReady" />
      </Event>
      <Event ID="A726D490DA99DCD7" Name="FB_INIT">
        <With Var="InitDone" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="F4155A553C9CE1A2" Name="MODE">
        <With Var="Mode" />
      </Event>
      <Event ID="E1D373823D64ACA0" Name="EMERGENCY_ON">
        <With Var="EmergencyON" />
      </Event>
      <Event ID="395F2A7D1AB6A478" Name="START_FEED">
        <With Var="StartFeed" />
      </Event>
      <Event ID="61CD32E3E6AEDF7D" Name="INIT_R_CMD">
        <With Var="Initialize" />
        <With Var="InitRx_To_Step10" />
      </Event>
      <Event ID="911F6EFE27823BFD" Name="R_POSITION">
        <With Var="ReactorPosition" />
      </Event>
      <Event ID="198EF041C70827BC" Name="CT_ECT">
        <With Var="CT_ReactorActualV" />
        <With Var="CT_ReactorActualT" />
      </Event>
      <Event ID="9D1E5F7369C5538B" Name="FEED_INTERVAL">
        <With Var="FeedIntervalV" />
        <With Var="FeedIntervalT" />
      </Event>
      <Event ID="1C1DD8946F24CFF9" Name="CACULATE_S5" />
      <Event ID="7D5F3067068DE334" Name="FORCE_UNAV">
        <With Var="ForceUnavaibility" />
      </Event>
      <Event ID="B3BDDBF095B97A2B" Name="NEXT_FEED_HORIZON">
        <With Var="NextFeedHorizonTR" />
        <With Var="NextFeedHorizonVR" />
      </Event>
      <Event ID="452DD3D0F76A115F" Name="LAST_FEED_V_T">
        <With Var="TotMinutesSinceStartFeedV" />
        <With Var="TotMinutesSinceStartFeedT" />
      </Event>
      <Event ID="CF316F4BA7C11A07" Name="INIT_ID">
        <With Var="ID" />
      </Event>
      <Event ID="93812D9FEC4294F9" Name="SB_AV">
        <With Var="SBAvailability" />
      </Event>
      <Event ID="B87038B36154E12C" Name="EN_F_S_FEED">
        <With Var="EnableForceStopFeed" />
      </Event>
      <Event ID="8C3EDF854FD9A842" Name="PAR">
        <With Var="FB_IBL1" />
      </Event>
      <Event ID="5D60A03195272600" Name="SHOW_INIT_ACT">
        <With Var="ShowInitActions" />
        <With Var="ShowRxToFeed" />
        <With Var="ShowSettleTWait" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="793E1D04BE895F4E" Name="S5_AerateTimeT" Type="TIME" />
      <VarDeclaration ID="3807C75A82F33B22" Name="S5_AerateTimeV" Type="REAL" />
      <VarDeclaration ID="AAA3C8C42E4C22C8" Name="S1_FeedTimeT" Type="TIME" />
      <VarDeclaration ID="97E0DD6BF11B8796" Name="S1_FeedTimeV" Type="REAL" />
      <VarDeclaration ID="1D99A7E687AA4E06" Name="FeedingRun" Type="BOOL" />
      <VarDeclaration ID="613E286D19768818" Name="CurrStep" Type="INT" />
      <VarDeclaration ID="B3BCA5E1F4B3D013" Name="SDReady" Type="BOOL" />
      <VarDeclaration ID="CD0B256D4231028A" Name="InitDone" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="3DE412B51FD79A3F" Name="Mode" Type="INT" />
      <VarDeclaration ID="F0BEEA13B7FB6780" Name="EmergencyON" Type="BOOL" />
      <VarDeclaration ID="B1FC30AB336AE8E9" Name="StartFeed" Type="BOOL" />
      <VarDeclaration ID="3C27B3AC98B413B4" Name="Initialize" Type="BOOL" />
      <VarDeclaration ID="713BAA92BE7C280E" Name="InitRx_To_Step10" Type="BOOL" />
      <VarDeclaration ID="074948F0B024FF2E" Name="ReactorPosition" Type="INT" />
      <VarDeclaration ID="758E7E3A994DF6A3" Name="CT_ReactorActualV" Type="REAL" />
      <VarDeclaration ID="90388C221FF11A3D" Name="CT_ReactorActualT" Type="TIME" />
      <VarDeclaration ID="7614E537E01F969F" Name="FeedIntervalV" Type="REAL" />
      <VarDeclaration ID="852A82A24B95110C" Name="FeedIntervalT" Type="TIME" />
      <VarDeclaration ID="35F3027F47B7A966" Name="ForceUnavaibility" Type="BOOL" />
      <VarDeclaration ID="83DE9B371B83EBB9" Name="NextFeedHorizonTR" Type="TIME" />
      <VarDeclaration ID="5C25718B2BAE6B29" Name="NextFeedHorizonVR" Type="REAL" />
      <VarDeclaration ID="D48F4FEFB23A8E3D" Name="TotMinutesSinceStartFeedV" Type="REAL" />
      <VarDeclaration ID="373FD7AFCD25AEF9" Name="TotMinutesSinceStartFeedT" Type="TIME" />
      <VarDeclaration ID="7FC77B7D4B4A5A4D" Name="ID" Type="INT" />
      <VarDeclaration ID="1675BB23EEFCF5E9" Name="SBAvailability" Type="BOOL" />
      <VarDeclaration ID="D58D93F8831E8501" Name="EnableForceStopFeed" Type="BOOL" />
      <VarDeclaration ID="9947D4D2C2FC9245" Name="FB_IBL1" Type="BOOL" />
      <VarDeclaration ID="0A1AB0CF771FE270" Name="ShowInitActions" Type="BOOL" />
      <VarDeclaration ID="9F800903C2707641" Name="ShowRxToFeed" Type="INT" />
      <VarDeclaration ID="2B76AB033BC36EFC" Name="ShowSettleTWait" Type="INT" />
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