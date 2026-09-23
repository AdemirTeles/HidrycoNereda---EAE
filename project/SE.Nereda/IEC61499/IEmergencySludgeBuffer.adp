<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="4a3fe6d6-398e-4477-b3e7-914e4f78b919" Name="IEmergencySludgeBuffer" Comment="Adapter Interface" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="9/17/2026" />
  <InterfaceList>
    <EventInputs>
      <Event ID="94F38E4F5A9F83A9" Name="L1">
        <With Var="L1v" />
      </Event>
      <Event ID="6F6A4B765C66EE8A" Name="L2">
        <With Var="L2v" />
      </Event>
      <Event ID="01031D6AC20FAB24" Name="LVL">
        <With Var="Level" />
      </Event>
      <Event ID="BBC4AE70863ED310" Name="FB_FEED">
        <With Var="FeedReady" />
        <With Var="FeedRun" />
        <With Var="FeedInterlock" />
      </Event>
      <Event ID="FD5E09F22E2FB8C9" Name="FB_WAIT">
        <With Var="WaitReady" />
        <With Var="WaitRun" />
        <With Var="WaitInterlock" />
      </Event>
      <Event ID="D7091D88C8316783" Name="FB_SLD_DIS">
        <With Var="SludgeDischargeReady" />
        <With Var="SludgeDischargeRun" />
        <With Var="SludgeDischargeInterlocked" />
      </Event>
      <Event ID="4C01A7A01C491F67" Name="FB_SUPER_DIS">
        <With Var="SupernantDischargeReady" />
        <With Var="SupernantDischargeRun" />
        <With Var="SupernantDischargeInterlock" />
      </Event>
    </EventInputs>
    <EventOutputs>
      <Event ID="37BB0210227B4D88" Name="FEED">
        <With Var="CmdFeed" />
      </Event>
      <Event ID="B8FB7A13CF18B1CA" Name="WAIT">
        <With Var="CmdWait" />
      </Event>
      <Event ID="7AF6A44EC4713EB1" Name="SLD_DISCHARGE">
        <With Var="CmdSludgeDischarge" />
        <With Var="SludgeDischargeCapacity" />
      </Event>
      <Event ID="6CE3EC6EFAA8A173" Name="SLD_SUPERNANAT">
        <With Var="CmdSupernantDischarge" />
        <With Var="SupernantDischargeCapacity" />
      </Event>
      <Event ID="4D4A6D622AA6CDB1" Name="EMER_ON">
        <With Var="EmergencyOn" />
      </Event>
    </EventOutputs>
    <InputVars>
      <VarDeclaration ID="C22B3197E31C2FDC" Name="L1v" Type="BOOL" />
      <VarDeclaration ID="E5D66BA160FEA7BE" Name="L2v" Type="BOOL" />
      <VarDeclaration ID="91843A91DDCD538F" Name="Level" Type="INT" />
      <VarDeclaration ID="D440A766CB8B17CF" Name="FeedReady" Type="BOOL" />
      <VarDeclaration ID="0408EC495DD13DC3" Name="FeedRun" Type="BOOL" />
      <VarDeclaration ID="C46CE53379F5294A" Name="FeedInterlock" Type="BOOL" />
      <VarDeclaration ID="862A2E6EE70C20AF" Name="WaitReady" Type="BOOL" />
      <VarDeclaration ID="D88E26B5943BE63E" Name="WaitRun" Type="BOOL" />
      <VarDeclaration ID="18727D2D2A93A202" Name="WaitInterlock" Type="BOOL" />
      <VarDeclaration ID="695399F703F77E2B" Name="SludgeDischargeReady" Type="BOOL" />
      <VarDeclaration ID="F0EA458A3A0698F3" Name="SludgeDischargeRun" Type="BOOL" />
      <VarDeclaration ID="A279159B5A0CF8D3" Name="SludgeDischargeInterlocked" Type="BOOL" />
      <VarDeclaration ID="76FC2A554E83498F" Name="SupernantDischargeReady" Type="BOOL" />
      <VarDeclaration ID="08F354F7946D6684" Name="SupernantDischargeRun" Type="BOOL" />
      <VarDeclaration ID="FA3C227BD61E1E98" Name="SupernantDischargeInterlock" Type="BOOL" />
    </InputVars>
    <OutputVars>
      <VarDeclaration ID="0CCCE0E6A38C4CC4" Name="CmdFeed" Type="BOOL" />
      <VarDeclaration ID="2D97C7DF176F1821" Name="CmdWait" Type="BOOL" />
      <VarDeclaration ID="CC5E48971A6D3B85" Name="CmdSludgeDischarge" Type="BOOL" />
      <VarDeclaration ID="FDC6C047971AF4AB" Name="CmdSupernantDischarge" Type="BOOL" />
      <VarDeclaration ID="290CB544BD4AF7E0" Name="SludgeDischargeCapacity" Type="REAL" />
      <VarDeclaration ID="D5F6310F45243454" Name="SupernantDischargeCapacity" Type="REAL" />
      <VarDeclaration ID="A1711B52790021B0" Name="EmergencyOn" Type="BOOL" />
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