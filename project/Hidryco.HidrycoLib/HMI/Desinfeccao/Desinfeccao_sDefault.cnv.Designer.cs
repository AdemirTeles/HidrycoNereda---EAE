/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 19:43
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Desinfeccao
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TrojanUV30001 = new Hidryco.HidrycoLib.Symbols.TrojanUV3000.sDefault();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.line16 = new NxtControl.GuiFramework.Line();
			this.line17 = new NxtControl.GuiFramework.Line();
			this.group6 = new NxtControl.GuiFramework.Group();
			this.Valvula_Borboleta_Modulante1 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Valvula();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.polyline2 = new NxtControl.GuiFramework.Polyline();
			this.line15 = new NxtControl.GuiFramework.Line();
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.group5 = new NxtControl.GuiFramework.Group();
			this.polyline3 = new NxtControl.GuiFramework.Polyline();
			this.line20 = new NxtControl.GuiFramework.Line();
			this.line23 = new NxtControl.GuiFramework.Line();
			this.line24 = new NxtControl.GuiFramework.Line();
			this.line25 = new NxtControl.GuiFramework.Line();
			this.line26 = new NxtControl.GuiFramework.Line();
			this.line27 = new NxtControl.GuiFramework.Line();
			this.line28 = new NxtControl.GuiFramework.Line();
			this.line29 = new NxtControl.GuiFramework.Line();
			this.line30 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.FT_700_01 = new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault();
			this.AIT_700_01 = new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.resetFalhasProcesso = new NxtControl.GuiFramework.DrawnButton();
			this.AIT_700_03 = new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault();
			this.AIT_700_04 = new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault();
			// 
			// TrojanUV30001
			// 
			this.TrojanUV30001.BeginInit();
			this.TrojanUV30001.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 152D, 24D);
			this.TrojanUV30001.Name = "TrojanUV30001";
			this.TrojanUV30001.SecurityToken = ((uint)(4294967295u));
			this.TrojanUV30001.TagName = "TrojanUV30001";
			this.TrojanUV30001.EndInit();
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(420.27272727272731D)), ((float)(160D)), ((float)(122.72727272727269D)));
			this.polygon5.Closed = true;
			this.polygon5.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.polygon5.FillPercent = 75F;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 420.27272727272731D),
			new NxtControl.Drawing.PointF(24D, 524.590909090909D),
			new NxtControl.Drawing.PointF(149.71428571428572D, 524.590909090909D),
			new NxtControl.Drawing.PointF(149.71428571428572D, 543D),
			new NxtControl.Drawing.PointF(184D, 543D),
			new NxtControl.Drawing.PointF(184D, 420.27272727272731D)});
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(408D)), ((float)(160D)), ((float)(135D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(24D, 408D),
			new NxtControl.Drawing.PointF(24D, 524.59090909090912D),
			new NxtControl.Drawing.PointF(149.71428571428572D, 524.59090909090912D),
			new NxtControl.Drawing.PointF(149.71428571428572D, 543D),
			new NxtControl.Drawing.PointF(184D, 543D),
			new NxtControl.Drawing.PointF(184D, 408D)});
			// 
			// line16
			// 
			this.line16.EndPoint = new NxtControl.Drawing.PointF(230D, 481D);
			this.line16.Name = "line16";
			this.line16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line16.StartPoint = new NxtControl.Drawing.PointF(184D, 481D);
			// 
			// line17
			// 
			this.line17.EndPoint = new NxtControl.Drawing.PointF(360D, 393D);
			this.line17.Name = "line17";
			this.line17.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line17.StartPoint = new NxtControl.Drawing.PointF(360D, 576D);
			// 
			// group6
			// 
			this.group6.BeginInit();
			this.group6.Name = "group6";
			this.group6.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon5,
			this.polyline1});
			this.group6.EndInit();
			// 
			// Valvula_Borboleta_Modulante1
			// 
			this.Valvula_Borboleta_Modulante1.BeginInit();
			this.Valvula_Borboleta_Modulante1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 208D, 411D);
			this.Valvula_Borboleta_Modulante1.Name = "Valvula_Borboleta_Modulante1";
			this.Valvula_Borboleta_Modulante1.SecurityToken = ((uint)(4294967295u));
			this.Valvula_Borboleta_Modulante1.TagName = "VC_700_01";
			this.Valvula_Borboleta_Modulante1.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(360D, 480D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(280D, 480D);
			// 
			// polyline2
			// 
			this.polyline2.Bounds = new NxtControl.Drawing.RectF(((float)(832D)), ((float)(416D)), ((float)(256D)), ((float)(168D)));
			this.polyline2.Closed = false;
			this.polyline2.Name = "polyline2";
			this.polyline2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.polyline2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(832D, 416D),
			new NxtControl.Drawing.PointF(832D, 546.66666666666674D),
			new NxtControl.Drawing.PointF(952.470588235294D, 546.66666666666674D),
			new NxtControl.Drawing.PointF(1005.1764705882352D, 571.55555555555566D),
			new NxtControl.Drawing.PointF(1035.294117647059D, 546.66666666666674D),
			new NxtControl.Drawing.PointF(1035.294117647059D, 584D),
			new NxtControl.Drawing.PointF(1088D, 584D),
			new NxtControl.Drawing.PointF(1088D, 416D)});
			// 
			// line15
			// 
			this.line15.EndPoint = new NxtControl.Drawing.PointF(892.23529411764707D, 490.66666666666663D);
			this.line15.Name = "line15";
			this.line15.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.line15.StartPoint = new NxtControl.Drawing.PointF(892.23529411764707D, 416D);
			// 
			// polygon7
			// 
			this.polygon7.Bounds = new NxtControl.Drawing.RectF(((float)(1216D)), ((float)(592D)), ((float)(112D)), ((float)(72D)));
			this.polygon7.Closed = true;
			this.polygon7.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.polygon7.FillPercent = 75F;
			this.polygon7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon7.Name = "polygon7";
			this.polygon7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1216D, 592D),
			new NxtControl.Drawing.PointF(1256D, 624D),
			new NxtControl.Drawing.PointF(1272D, 664D),
			new NxtControl.Drawing.PointF(1312D, 664D),
			new NxtControl.Drawing.PointF(1328D, 592D)});
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(830D)), ((float)(426D)), ((float)(258D)), ((float)(160D)));
			this.polygon6.Closed = true;
			this.polygon6.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.polygon6.FillPercent = 75F;
			this.polygon6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(830D, 548D),
			new NxtControl.Drawing.PointF(832D, 426D),
			new NxtControl.Drawing.PointF(1088D, 426D),
			new NxtControl.Drawing.PointF(1088D, 586D),
			new NxtControl.Drawing.PointF(1036D, 586D),
			new NxtControl.Drawing.PointF(1036D, 546D),
			new NxtControl.Drawing.PointF(1007D, 571D),
			new NxtControl.Drawing.PointF(948D, 546D)});
			// 
			// group5
			// 
			this.group5.BeginInit();
			this.group5.Name = "group5";
			this.group5.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polyline2,
			this.line15});
			this.group5.EndInit();
			// 
			// polyline3
			// 
			this.polyline3.Bounds = new NxtControl.Drawing.RectF(((float)(1208D)), ((float)(590D)), ((float)(120D)), ((float)(72D)));
			this.polyline3.Closed = false;
			this.polyline3.Name = "polyline3";
			this.polyline3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))), 5F, NxtControl.Drawing.DashStyle.Solid);
			this.polyline3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1208D, 590D),
			new NxtControl.Drawing.PointF(1256D, 622D),
			new NxtControl.Drawing.PointF(1272D, 662D),
			new NxtControl.Drawing.PointF(1312D, 662D),
			new NxtControl.Drawing.PointF(1320D, 622D),
			new NxtControl.Drawing.PointF(1328D, 590D)});
			// 
			// line20
			// 
			this.line20.EndPoint = new NxtControl.Drawing.PointF(791D, 392D);
			this.line20.Name = "line20";
			this.line20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line20.StartPoint = new NxtControl.Drawing.PointF(791D, 576D);
			// 
			// line23
			// 
			this.line23.EndPoint = new NxtControl.Drawing.PointF(829D, 489D);
			this.line23.Name = "line23";
			this.line23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line23.StartPoint = new NxtControl.Drawing.PointF(791D, 489D);
			// 
			// line24
			// 
			this.line24.EndPoint = new NxtControl.Drawing.PointF(1112D, 520D);
			this.line24.Name = "line24";
			this.line24.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line24.StartPoint = new NxtControl.Drawing.PointF(1080D, 520D);
			// 
			// line25
			// 
			this.line25.EndPoint = new NxtControl.Drawing.PointF(1112D, 544D);
			this.line25.Name = "line25";
			this.line25.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line25.StartPoint = new NxtControl.Drawing.PointF(1112D, 520D);
			// 
			// line26
			// 
			this.line26.EndPoint = new NxtControl.Drawing.PointF(1144D, 544D);
			this.line26.Name = "line26";
			this.line26.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line26.StartPoint = new NxtControl.Drawing.PointF(1112D, 544D);
			// 
			// line27
			// 
			this.line27.EndPoint = new NxtControl.Drawing.PointF(1144D, 568D);
			this.line27.Name = "line27";
			this.line27.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line27.StartPoint = new NxtControl.Drawing.PointF(1144D, 544D);
			// 
			// line28
			// 
			this.line28.EndPoint = new NxtControl.Drawing.PointF(1176D, 568D);
			this.line28.Name = "line28";
			this.line28.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line28.StartPoint = new NxtControl.Drawing.PointF(1144D, 568D);
			// 
			// line29
			// 
			this.line29.EndPoint = new NxtControl.Drawing.PointF(1176D, 592D);
			this.line29.Name = "line29";
			this.line29.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line29.StartPoint = new NxtControl.Drawing.PointF(1176D, 568D);
			// 
			// line30
			// 
			this.line30.EndPoint = new NxtControl.Drawing.PointF(1208D, 592D);
			this.line30.Name = "line30";
			this.line30.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line30.StartPoint = new NxtControl.Drawing.PointF(1176D, 592D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line24,
			this.line25,
			this.line26,
			this.line27,
			this.line28,
			this.line29,
			this.line30});
			this.group1.EndInit();
			// 
			// FT_700_01
			// 
			this.FT_700_01.BeginInit();
			this.FT_700_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 904D, 360D);
			this.FT_700_01.Name = "FT_700_01";
			this.FT_700_01.SecurityToken = ((uint)(4294967295u));
			this.FT_700_01.TagName = "FT_700_01";
			this.FT_700_01.EndInit();
			// 
			// AIT_700_01
			// 
			this.AIT_700_01.BeginInit();
			this.AIT_700_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1136D, 480D);
			this.AIT_700_01.Name = "AIT_700_01";
			this.AIT_700_01.SecurityToken = ((uint)(4294967295u));
			this.AIT_700_01.TagName = "AIT_700_01";
			this.AIT_700_01.EndInit();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(1161D)), ((float)(17D)), ((float)(160D)), ((float)(59D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// resetFalhasProcesso
			// 
			this.resetFalhasProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(1181D)), ((float)(28D)), ((float)(120D)), ((float)(36D)));
			this.resetFalhasProcesso.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.resetFalhasProcesso.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.resetFalhasProcesso.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.resetFalhasProcesso.Name = "resetFalhasProcesso";
			this.resetFalhasProcesso.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.resetFalhasProcesso.Radius = 4D;
			this.resetFalhasProcesso.Text = "Reset Falhas";
			this.resetFalhasProcesso.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.resetFalhasProcesso.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.resetFalhasProcesso.Use3DEffect = false;
			this.resetFalhasProcesso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResetFalhasProcessoMouseDown);
			this.resetFalhasProcesso.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResetFalhasProcessoMouseUp);
			// 
			// AIT_700_03
			// 
			this.AIT_700_03.BeginInit();
			this.AIT_700_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1136D, 416D);
			this.AIT_700_03.Name = "AIT_700_03";
			this.AIT_700_03.SecurityToken = ((uint)(4294967295u));
			this.AIT_700_03.TagName = "AIT_700_03";
			this.AIT_700_03.EndInit();
			// 
			// AIT_700_04
			// 
			this.AIT_700_04.BeginInit();
			this.AIT_700_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1136D, 352D);
			this.AIT_700_04.Name = "AIT_700_04";
			this.AIT_700_04.SecurityToken = ((uint)(4294967295u));
			this.AIT_700_04.TagName = "AIT_700_04";
			this.AIT_700_04.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.TrojanUV30001,
			this.line16,
			this.line17,
			this.group6,
			this.Valvula_Borboleta_Modulante1,
			this.line1,
			this.polygon7,
			this.polygon6,
			this.group5,
			this.polyline3,
			this.line20,
			this.line23,
			this.FT_700_01,
			this.AIT_700_01,
			this.roundedRectangle1,
			this.resetFalhasProcesso,
			this.AIT_700_03,
			this.AIT_700_04});
			this.SymbolSize = new System.Drawing.Size(1350, 700);

		}
		private Hidryco.HidrycoLib.Symbols.TrojanUV3000.sDefault TrojanUV30001;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.Line line16;
		private NxtControl.GuiFramework.Line line17;
		private NxtControl.GuiFramework.Group group6;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Valvula Valvula_Borboleta_Modulante1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Polyline polyline2;
		private NxtControl.GuiFramework.Line line15;
		private NxtControl.GuiFramework.Polygon polygon7;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.Group group5;
		private NxtControl.GuiFramework.Polyline polyline3;
		private NxtControl.GuiFramework.Line line20;
		private NxtControl.GuiFramework.Line line23;
		private NxtControl.GuiFramework.Line line24;
		private NxtControl.GuiFramework.Line line25;
		private NxtControl.GuiFramework.Line line26;
		private NxtControl.GuiFramework.Line line27;
		private NxtControl.GuiFramework.Line line28;
		private NxtControl.GuiFramework.Line line29;
		private NxtControl.GuiFramework.Line line30;
		private NxtControl.GuiFramework.Group group1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault FT_700_01;
		private Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault AIT_700_01;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.DrawnButton resetFalhasProcesso;
		private Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault AIT_700_03;
		private Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault AIT_700_04;
		#endregion
	}
}
