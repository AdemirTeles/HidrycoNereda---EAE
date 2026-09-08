/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/29/2026
 * Time: 5:17 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaSludgeBuffer
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
			this.sDefault1 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.Logic = new SE.Nereda.Symbols.SludgeBufferLogic.sSLB();
			this.sPvBarVer1 = new SE.Nereda.Symbols.AnalogInput.sPvBarVer();
			this.polygon13 = new NxtControl.GuiFramework.Polygon();
			this.polygon14 = new NxtControl.GuiFramework.Polygon();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.line23 = new NxtControl.GuiFramework.Line();
			this.group13 = new NxtControl.GuiFramework.Group();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iVlvName = "Valve";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 600D, 184D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault1.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Hide;
			this.sDefault1.TagName = "Actuators.NVPP_001_a_029";
			this.sDefault1.EndInit();
			// 
			// Logic
			// 
			this.Logic.BeginInit();
			this.Logic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 32D);
			this.Logic.Name = "Logic";
			this.Logic.SecurityToken = ((uint)(4294967295u));
			this.Logic.TagName = "Logic";
			this.Logic.EndInit();
			// 
			// sPvBarVer1
			// 
			this.sPvBarVer1.BeginInit();
			this.sPvBarVer1._iSensorName = "NVPP 001 lt 003";
			this.sPvBarVer1._iUnit = "m";
			this.sPvBarVer1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 192D, 72D);
			this.sPvBarVer1.Name = "sPvBarVer1";
			this.sPvBarVer1.SecurityToken = ((uint)(4294967295u));
			this.sPvBarVer1.TagName = "Sensors.NVPP_001_lt_003";
			this.sPvBarVer1.EndInit();
			// 
			// polygon13
			// 
			this.polygon13.Bounds = new NxtControl.Drawing.RectF(((float)(744D)), ((float)(104D)), ((float)(16D)), ((float)(20D)));
			this.polygon13.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon13.Closed = true;
			this.polygon13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon13.Name = "polygon13";
			this.polygon13.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(760D, 104D),
			new NxtControl.Drawing.PointF(744D, 104D),
			new NxtControl.Drawing.PointF(752D, 124D)});
			// 
			// polygon14
			// 
			this.polygon14.Bounds = new NxtControl.Drawing.RectF(((float)(744D)), ((float)(124D)), ((float)(16D)), ((float)(20D)));
			this.polygon14.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon14.Closed = true;
			this.polygon14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon14.Name = "polygon14";
			this.polygon14.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(760D, 144D),
			new NxtControl.Drawing.PointF(744D, 144D),
			new NxtControl.Drawing.PointF(752D, 124D)});
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(772D, 116D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(772D, 132D);
			// 
			// line23
			// 
			this.line23.EndPoint = new NxtControl.Drawing.PointF(752D, 124D);
			this.line23.Name = "line23";
			this.line23.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line23.StartPoint = new NxtControl.Drawing.PointF(772D, 124D);
			// 
			// group13
			// 
			this.group13.BeginInit();
			this.group13.Name = "group13";
			this.group13.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon13,
			this.polygon14,
			this.line22,
			this.line23});
			this.group13.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Logic,
			this.sDefault1,
			this.sPvBarVer1,
			this.group13});
			this.SymbolSize = new System.Drawing.Size(848, 352);

		}
		private SE.Nereda.Symbols.ValveS.sDefault sDefault1;
		private SE.Nereda.Symbols.SludgeBufferLogic.sSLB Logic;
		private SE.Nereda.Symbols.AnalogInput.sPvBarVer sPvBarVer1;
		private NxtControl.GuiFramework.Polygon polygon13;
		private NxtControl.GuiFramework.Polygon polygon14;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.Line line23;
		private NxtControl.GuiFramework.Group group13;
		#endregion
	}
}
