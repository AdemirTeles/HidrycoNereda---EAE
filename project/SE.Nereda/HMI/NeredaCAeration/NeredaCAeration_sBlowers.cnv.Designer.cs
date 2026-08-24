/*
 * Created by EcoStruxure Automation Expert.
 * User: Schneider
 * Date: 5/7/2024
 * Time: 1:03 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaCAeration
{
	/// <summary>
	/// Summary description for sBlowers.
	/// </summary>
	partial class sBlowers
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sBlower1 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.sBlower2 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.sBlower3 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.sBlower4 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.sDefault1 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.sDefault2 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.pipe5 = new NxtControl.GuiFramework.Pipe();
			this.sDefault3 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.pipe6 = new NxtControl.GuiFramework.Pipe();
			this.pipe7 = new NxtControl.GuiFramework.Pipe();
			this.pipe8 = new NxtControl.GuiFramework.Pipe();
			this.BL001 = new NxtControl.GuiFramework.FreeText();
			this.BL002 = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.Logic = new SE.Nereda.Symbols.CAerationLogic.sSettingsBtn();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			// 
			// sBlower1
			// 
			this.sBlower1.BeginInit();
			this.sBlower1._iMotName = "Motor";
			this.sBlower1._iUnit = "%";
			this.sBlower1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 20D, 316D);
			this.sBlower1.Name = "sBlower1";
			this.sBlower1.SecurityToken = ((uint)(4294967295u));
			this.sBlower1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.sBlower1.TagName = "Actuators.V4601";
			this.sBlower1.EndInit();
			// 
			// sBlower2
			// 
			this.sBlower2.BeginInit();
			this.sBlower2._iMotName = "Motor";
			this.sBlower2._iUnit = "%";
			this.sBlower2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 152D, 316D);
			this.sBlower2.Name = "sBlower2";
			this.sBlower2.SecurityToken = ((uint)(4294967295u));
			this.sBlower2.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.sBlower2.TagName = "Actuators.V4602";
			this.sBlower2.EndInit();
			// 
			// sBlower3
			// 
			this.sBlower3.BeginInit();
			this.sBlower3._iMotName = "Motor";
			this.sBlower3._iUnit = "%";
			this.sBlower3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 284D, 316D);
			this.sBlower3.Name = "sBlower3";
			this.sBlower3.SecurityToken = ((uint)(4294967295u));
			this.sBlower3.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.sBlower3.TagName = "Actuators.V4603";
			this.sBlower3.EndInit();
			// 
			// sBlower4
			// 
			this.sBlower4.BeginInit();
			this.sBlower4._iMotName = "Motor";
			this.sBlower4._iUnit = "%";
			this.sBlower4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 416D, 316D);
			this.sBlower4.Name = "sBlower4";
			this.sBlower4.SecurityToken = ((uint)(4294967295u));
			this.sBlower4.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.sBlower4.TagName = "Actuators.V4604";
			this.sBlower4.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(180D)), ((float)(0D)), ((float)(172D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(56D, 352D),
			new NxtControl.Drawing.PointF(56D, 180D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(452D)), ((float)(180D)), ((float)(0D)), ((float)(172D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(452D, 352D),
			new NxtControl.Drawing.PointF(452D, 180D)});
			this.pipe2.Width = 10;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(232D)), ((float)(48D)), ((float)(0D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(108D, 232D),
			new NxtControl.Drawing.PointF(60D, 232D)});
			this.pipe3.Width = 10;
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iVlvName = "AV46 001";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 68D, 184D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault1.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault1.TagName = "Actuators.AV46_001";
			this.sDefault1.EndInit();
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(132D)), ((float)(232D)), ((float)(104D)), ((float)(0D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(236D, 232D),
			new NxtControl.Drawing.PointF(132D, 232D)});
			this.pipe4.Width = 10;
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2._iVlvName = "AV46 002";
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 200D, 184D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault2.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault2.TagName = "Actuators.AV46_002";
			this.sDefault2.EndInit();
			// 
			// pipe5
			// 
			this.pipe5.Bounds = new NxtControl.Drawing.RectF(((float)(260D)), ((float)(232D)), ((float)(104D)), ((float)(0D)));
			this.pipe5.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe5.Name = "pipe5";
			this.pipe5.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(364D, 232D),
			new NxtControl.Drawing.PointF(260D, 232D)});
			this.pipe5.Width = 10;
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3._iVlvName = "AV46 003";
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 332D, 184D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault3.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault3.TagName = "Actuators.AV46_003";
			this.sDefault3.EndInit();
			// 
			// pipe6
			// 
			this.pipe6.Bounds = new NxtControl.Drawing.RectF(((float)(392D)), ((float)(232D)), ((float)(60D)), ((float)(0D)));
			this.pipe6.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe6.Name = "pipe6";
			this.pipe6.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(452D, 232D),
			new NxtControl.Drawing.PointF(392D, 232D)});
			this.pipe6.Width = 10;
			// 
			// pipe7
			// 
			this.pipe7.Bounds = new NxtControl.Drawing.RectF(((float)(188D)), ((float)(232D)), ((float)(0D)), ((float)(120D)));
			this.pipe7.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe7.Name = "pipe7";
			this.pipe7.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(188D, 352D),
			new NxtControl.Drawing.PointF(188D, 232D)});
			this.pipe7.Width = 10;
			// 
			// pipe8
			// 
			this.pipe8.Bounds = new NxtControl.Drawing.RectF(((float)(320D)), ((float)(232D)), ((float)(0D)), ((float)(120D)));
			this.pipe8.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe8.Name = "pipe8";
			this.pipe8.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(320D, 352D),
			new NxtControl.Drawing.PointF(320D, 232D)});
			this.pipe8.Width = 10;
			// 
			// BL001
			// 
			this.BL001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.BL001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL001.Location = new NxtControl.Drawing.PointF(48D, 416D);
			this.BL001.Name = "BL001";
			this.BL001.Text = "V4601";
			// 
			// BL002
			// 
			this.BL002.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.BL002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL002.Location = new NxtControl.Drawing.PointF(182D, 416D);
			this.BL002.Name = "BL002";
			this.BL002.Text = "V4602";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(312D, 416D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "V4603";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(446D, 416D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "V4604";
			// 
			// Logic
			// 
			this.Logic.BeginInit();
			this.Logic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 234D, 268D);
			this.Logic.Name = "Logic";
			this.Logic.SecurityToken = ((uint)(4294967295u));
			this.Logic.TagName = "Logic";
			this.Logic.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(72D, 268D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(72D, 320D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(68D)), ((float)(260D)), ((float)(8D)), ((float)(12D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72D, 260D),
			new NxtControl.Drawing.PointF(68D, 272D),
			new NxtControl.Drawing.PointF(76D, 272D)});
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(76D, 308D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Header 1";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(468D, 268D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(468D, 320D);
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(464D)), ((float)(260D)), ((float)(8D)), ((float)(12D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(468D, 260D),
			new NxtControl.Drawing.PointF(464D, 272D),
			new NxtControl.Drawing.PointF(472D, 272D)});
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(472D, 308D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Header 2";
			// 
			// sBlowers
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe8,
			this.pipe7,
			this.pipe6,
			this.pipe5,
			this.pipe4,
			this.pipe2,
			this.pipe1,
			this.sBlower1,
			this.sBlower2,
			this.sBlower3,
			this.sBlower4,
			this.pipe3,
			this.sDefault1,
			this.sDefault2,
			this.sDefault3,
			this.BL001,
			this.BL002,
			this.freeText1,
			this.freeText2,
			this.Logic,
			this.line1,
			this.polygon1,
			this.freeText3,
			this.line2,
			this.polygon2,
			this.freeText4});
			this.SymbolSize = new System.Drawing.Size(668, 472);

		}
		private SE.Nereda.Symbols.Motor_VS.sBlower sBlower1;
		private SE.Nereda.Symbols.Motor_VS.sBlower sBlower2;
		private SE.Nereda.Symbols.Motor_VS.sBlower sBlower3;
		private SE.Nereda.Symbols.Motor_VS.sBlower sBlower4;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe3;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault1;
		private NxtControl.GuiFramework.Pipe pipe4;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault2;
		private NxtControl.GuiFramework.Pipe pipe5;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault3;
		private NxtControl.GuiFramework.Pipe pipe6;
		private NxtControl.GuiFramework.Pipe pipe7;
		private NxtControl.GuiFramework.Pipe pipe8;
		private NxtControl.GuiFramework.FreeText BL001;
		private NxtControl.GuiFramework.FreeText BL002;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private SE.Nereda.Symbols.CAerationLogic.sSettingsBtn Logic;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.FreeText freeText4;
		#endregion
	}
}
