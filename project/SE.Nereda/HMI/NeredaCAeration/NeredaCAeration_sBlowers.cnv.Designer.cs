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
			this.sDefault4 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.sDefault5 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.sDefault6 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.sDefault7 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.pipe9 = new NxtControl.GuiFramework.Pipe();
			this.pipe10 = new NxtControl.GuiFramework.Pipe();
			this.pipe11 = new NxtControl.GuiFramework.Pipe();
			this.pipe12 = new NxtControl.GuiFramework.Pipe();
			// 
			// sBlower1
			// 
			this.sBlower1.BeginInit();
			this.sBlower1._iMotName = "Motor";
			this.sBlower1._iUnit = "%";
			this.sBlower1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 316D);
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
			this.sBlower2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 196D, 316D);
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
			this.sBlower3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 328D, 316D);
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
			this.sBlower4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 460D, 316D);
			this.sBlower4.Name = "sBlower4";
			this.sBlower4.SecurityToken = ((uint)(4294967295u));
			this.sBlower4.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.sBlower4.TagName = "Actuators.V4604";
			this.sBlower4.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(100D)), ((float)(132D)), ((float)(0D)), ((float)(92D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(100D, 224D),
			new NxtControl.Drawing.PointF(100D, 132D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(496D)), ((float)(132D)), ((float)(0D)), ((float)(92D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(496D, 224D),
			new NxtControl.Drawing.PointF(496D, 132D)});
			this.pipe2.Width = 10;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(184D)), ((float)(48D)), ((float)(0D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(152D, 184D),
			new NxtControl.Drawing.PointF(104D, 184D)});
			this.pipe3.Width = 10;
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iVlvName = "AV46 001";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 112D, 136D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault1.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault1.TagName = "Actuators.AV46_001";
			this.sDefault1.EndInit();
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(184D)), ((float)(104D)), ((float)(0D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(280D, 184D),
			new NxtControl.Drawing.PointF(176D, 184D)});
			this.pipe4.Width = 10;
			// 
			// sDefault2
			// 
			this.sDefault2.BeginInit();
			this.sDefault2._iVlvName = "AV46 002";
			this.sDefault2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 244D, 136D);
			this.sDefault2.Name = "sDefault2";
			this.sDefault2.SecurityToken = ((uint)(4294967295u));
			this.sDefault2.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault2.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault2.TagName = "Actuators.AV46_002";
			this.sDefault2.EndInit();
			// 
			// pipe5
			// 
			this.pipe5.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(184D)), ((float)(104D)), ((float)(0D)));
			this.pipe5.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe5.Name = "pipe5";
			this.pipe5.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(408D, 184D),
			new NxtControl.Drawing.PointF(304D, 184D)});
			this.pipe5.Width = 10;
			// 
			// sDefault3
			// 
			this.sDefault3.BeginInit();
			this.sDefault3._iVlvName = "AV46 003";
			this.sDefault3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 376D, 136D);
			this.sDefault3.Name = "sDefault3";
			this.sDefault3.SecurityToken = ((uint)(4294967295u));
			this.sDefault3.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault3.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault3.TagName = "Actuators.AV46_003";
			this.sDefault3.EndInit();
			// 
			// pipe6
			// 
			this.pipe6.Bounds = new NxtControl.Drawing.RectF(((float)(436D)), ((float)(184D)), ((float)(60D)), ((float)(0D)));
			this.pipe6.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe6.Name = "pipe6";
			this.pipe6.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(496D, 184D),
			new NxtControl.Drawing.PointF(436D, 184D)});
			this.pipe6.Width = 10;
			// 
			// pipe7
			// 
			this.pipe7.Bounds = new NxtControl.Drawing.RectF(((float)(232D)), ((float)(188D)), ((float)(0D)), ((float)(36D)));
			this.pipe7.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe7.Name = "pipe7";
			this.pipe7.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(232D, 224D),
			new NxtControl.Drawing.PointF(232D, 188D)});
			this.pipe7.Width = 10;
			// 
			// pipe8
			// 
			this.pipe8.Bounds = new NxtControl.Drawing.RectF(((float)(364D)), ((float)(188D)), ((float)(0D)), ((float)(36D)));
			this.pipe8.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe8.Name = "pipe8";
			this.pipe8.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(364D, 224D),
			new NxtControl.Drawing.PointF(364D, 188D)});
			this.pipe8.Width = 10;
			// 
			// BL001
			// 
			this.BL001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.BL001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL001.Location = new NxtControl.Drawing.PointF(92D, 416D);
			this.BL001.Name = "BL001";
			this.BL001.Text = "V4601";
			// 
			// BL002
			// 
			this.BL002.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.BL002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL002.Location = new NxtControl.Drawing.PointF(226D, 416D);
			this.BL002.Name = "BL002";
			this.BL002.Text = "V4602";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(356D, 416D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "V4603";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(490D, 416D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "V4604";
			// 
			// Logic
			// 
			this.Logic.BeginInit();
			this.Logic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 280D, 268D);
			this.Logic.Name = "Logic";
			this.Logic.SecurityToken = ((uint)(4294967295u));
			this.Logic.TagName = "Logic";
			this.Logic.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(116D, 268D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(116D, 320D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(260D)), ((float)(8D)), ((float)(12D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(116D, 260D),
			new NxtControl.Drawing.PointF(112D, 272D),
			new NxtControl.Drawing.PointF(120D, 272D)});
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(120D, 308D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Header 1";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(512D, 268D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(512D, 320D);
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(508D)), ((float)(260D)), ((float)(8D)), ((float)(12D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(512D, 260D),
			new NxtControl.Drawing.PointF(508D, 272D),
			new NxtControl.Drawing.PointF(516D, 272D)});
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(516D, 308D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Header 2";
			// 
			// sDefault4
			// 
			this.sDefault4.BeginInit();
			this.sDefault4._iVlvName = "";
			this.sDefault4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 36D, 204D);
			this.sDefault4.Name = "sDefault4";
			this.sDefault4.SecurityToken = ((uint)(4294967295u));
			this.sDefault4.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Horizontal;
			this.sDefault4.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault4.TagName = "Actuators.AV46_012";
			this.sDefault4.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5._iVlvName = "";
			this.sDefault5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 168D, 204D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Horizontal;
			this.sDefault5.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault5.TagName = "Actuators.AV46_022";
			this.sDefault5.EndInit();
			// 
			// sDefault6
			// 
			this.sDefault6.BeginInit();
			this.sDefault6._iVlvName = "";
			this.sDefault6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 300D, 204D);
			this.sDefault6.Name = "sDefault6";
			this.sDefault6.SecurityToken = ((uint)(4294967295u));
			this.sDefault6.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Horizontal;
			this.sDefault6.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault6.TagName = "Actuators.AV46_032";
			this.sDefault6.EndInit();
			// 
			// sDefault7
			// 
			this.sDefault7.BeginInit();
			this.sDefault7._iVlvName = "";
			this.sDefault7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 432D, 204D);
			this.sDefault7.Name = "sDefault7";
			this.sDefault7.SecurityToken = ((uint)(4294967295u));
			this.sDefault7.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Horizontal;
			this.sDefault7.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Show;
			this.sDefault7.TagName = "Actuators.AV46_042";
			this.sDefault7.EndInit();
			// 
			// pipe9
			// 
			this.pipe9.Bounds = new NxtControl.Drawing.RectF(((float)(364D)), ((float)(256D)), ((float)(0D)), ((float)(92D)));
			this.pipe9.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe9.Name = "pipe9";
			this.pipe9.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(364D, 348D),
			new NxtControl.Drawing.PointF(364D, 256D)});
			this.pipe9.Width = 10;
			// 
			// pipe10
			// 
			this.pipe10.Bounds = new NxtControl.Drawing.RectF(((float)(232D)), ((float)(256D)), ((float)(0D)), ((float)(92D)));
			this.pipe10.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe10.Name = "pipe10";
			this.pipe10.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe10.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(232D, 348D),
			new NxtControl.Drawing.PointF(232D, 256D)});
			this.pipe10.Width = 10;
			// 
			// pipe11
			// 
			this.pipe11.Bounds = new NxtControl.Drawing.RectF(((float)(496D)), ((float)(256D)), ((float)(0D)), ((float)(92D)));
			this.pipe11.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe11.Name = "pipe11";
			this.pipe11.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe11.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(496D, 348D),
			new NxtControl.Drawing.PointF(496D, 256D)});
			this.pipe11.Width = 10;
			// 
			// pipe12
			// 
			this.pipe12.Bounds = new NxtControl.Drawing.RectF(((float)(100D)), ((float)(256D)), ((float)(0D)), ((float)(92D)));
			this.pipe12.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe12.Name = "pipe12";
			this.pipe12.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe12.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(100D, 348D),
			new NxtControl.Drawing.PointF(100D, 256D)});
			this.pipe12.Width = 10;
			// 
			// sBlowers
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe11,
			this.pipe9,
			this.pipe10,
			this.pipe12,
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
			this.freeText4,
			this.sDefault4,
			this.sDefault5,
			this.sDefault6,
			this.sDefault7});
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
		private SE.Nereda.Symbols.ValveS.sDefault sDefault4;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault5;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault6;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault7;
		private NxtControl.GuiFramework.Pipe pipe9;
		private NxtControl.GuiFramework.Pipe pipe10;
		private NxtControl.GuiFramework.Pipe pipe11;
		private NxtControl.GuiFramework.Pipe pipe12;
		#endregion
	}
}
