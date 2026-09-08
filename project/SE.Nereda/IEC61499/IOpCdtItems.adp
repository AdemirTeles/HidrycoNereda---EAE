<?xml version="1.0" encoding="utf-8"?>
<!DOCTYPE AdapterType SYSTEM "../LibraryElement.dtd">
<AdapterType GUID="64d94654-735f-4945-bcea-9f1ec08194ae" Comment="Adapter Interface" Name="IOpCdtItems" Namespace="SE.Nereda">
  <Identification Standard="61499-1" />
  <VersionInfo Organization="Schneider Electric" Version="0.0" Author=" " Date="6/5/2026" />
  <InterfaceList>
    <EventOutputs>
      <Event ID="51FD4CCF54DA16B0" Name="REQ_OP_CDT">
        <With Var="OpCdt" />
      </Event>
      <Event ID="510B9224626AA5DB" Name="REQ_M_OC">
        <With Var="MemoOC" />
      </Event>
      <Event ID="0DE1D11A791E8338" Name="REQ_ITEMS">
        <With Var="item1" />
        <With Var="item2" />
        <With Var="item3" />
        <With Var="item4" />
        <With Var="item5" />
        <With Var="item6" />
        <With Var="item7" />
        <With Var="item8" />
        <With Var="items4Bits_1" />
        <With Var="items4Bits_2" />
        <With Var="items4Bits_3" />
        <With Var="items4Bits_4" />
        <With Var="item9" />
        <With Var="item10" />
        <With Var="item11" />
        <With Var="item12" />
        <With Var="item13" />
        <With Var="item14" />
        <With Var="item15" />
        <With Var="item16" />
      </Event>
    </EventOutputs>
    <OutputVars>
      <VarDeclaration ID="5E924D1CC4B831CF" Name="OpCdt" Type="BOOL" />
      <VarDeclaration ID="7FD7CF3BAAB2C8B1" Name="MemoOC" Type="WORD" ArraySize="10" />
      <VarDeclaration ID="83A3C315F80CFE17" Name="item1" Type="STRING" />
      <VarDeclaration ID="B50BFE7459784F00" Name="item2" Type="STRING" />
      <VarDeclaration ID="946A0F582B551978" Name="item3" Type="STRING" />
      <VarDeclaration ID="FCEA282DF5077920" Name="item4" Type="STRING" />
      <VarDeclaration ID="2B4F39E9175B3855" Name="item5" Type="STRING" />
      <VarDeclaration ID="4596A1B27C10C2CD" Name="item6" Type="STRING" />
      <VarDeclaration ID="A9753615DA8DD82A" Name="item7" Type="STRING" />
      <VarDeclaration ID="824CE9000F3F9466" Name="item8" Type="STRING" />
      <VarDeclaration ID="72067FEC91126715" Name="item9" Type="STRING" />
      <VarDeclaration ID="37C7DD09745BE300" Name="item10" Type="STRING" />
      <VarDeclaration ID="03CAF86670282F7A" Name="item11" Type="STRING" />
      <VarDeclaration ID="A578CCE6834280A9" Name="item12" Type="STRING" />
      <VarDeclaration ID="932E293892006A0F" Name="item13" Type="STRING" />
      <VarDeclaration ID="3136228301C0A3F6" Name="item14" Type="STRING" />
      <VarDeclaration ID="BBA5573FBFE93EF1" Name="item15" Type="STRING" />
      <VarDeclaration ID="9095F08A1259C467" Name="item16" Type="STRING" />
      <VarDeclaration ID="87CAB742E188E408" Name="items4Bits_1" Type="INT" />
      <VarDeclaration ID="315583C88EDCE2AB" Name="items4Bits_2" Type="INT" />
      <VarDeclaration ID="DC6E7346CAD3F412" Name="items4Bits_3" Type="INT" />
      <VarDeclaration ID="154499D847362610" Name="items4Bits_4" Type="INT" />
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