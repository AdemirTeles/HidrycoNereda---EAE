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

namespace SE.Nereda.Symbols.NeredaDAeration
{
	/// <summary>
	/// Summary description for sBlowers.
	/// </summary>
	partial class sBlowers2
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sBlowers2));
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.BL001 = new NxtControl.GuiFramework.FreeText();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.PI001 = new NxtControl.GuiFramework.FreeText();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.roundedRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.PI002 = new NxtControl.GuiFramework.FreeText();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.BL002 = new NxtControl.GuiFramework.FreeText();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.Logic = new SE.Nereda.Symbols.DAerationLogic.sGraphBtn();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(108D)), ((float)(40D)), ((float)(50D)), ((float)(50D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.ImageBytes = resources.GetString("rectangle1.ImageBytes");
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(156D)), ((float)(52D)), ((float)(200D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(156D, 52D),
			new NxtControl.Drawing.PointF(356D, 52D)});
			this.pipe1.Width = 4;
			// 
			// BL001
			// 
			this.BL001.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.BL001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL001.Location = new NxtControl.Drawing.PointF(60D, 24D);
			this.BL001.Name = "BL001";
			this.BL001.Text = "NVPP 001 BL001";
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(216D)), ((float)(64D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpPI01", NxtControl.GuiFramework.MouseButtonType.Click));
			this.roundedRectangle1.Text = "PI";
			this.roundedRectangle1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(228D, 52D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(228D, 64D);
			// 
			// PI001
			// 
			this.PI001.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.PI001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PI001.Location = new NxtControl.Drawing.PointF(184D, 84D);
			this.PI001.Name = "PI001";
			this.PI001.Text = "NVPP 001 PI001";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(284D)), ((float)(40D)), ((float)(20D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(284D, 40D),
			new NxtControl.Drawing.PointF(284D, 64D),
			new NxtControl.Drawing.PointF(304D, 52D)});
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(304D, 64D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(304D, 40D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(308D, 64D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(308D, 40D);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(108D)), ((float)(196D)), ((float)(50D)), ((float)(50D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.ImageBytes = resources.GetString("rectangle2.ImageBytes");
			this.rectangle2.Name = "rectangle2";
			this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(156D)), ((float)(208D)), ((float)(200D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(156D, 208D),
			new NxtControl.Drawing.PointF(356D, 208D)});
			this.pipe2.Width = 4;
			// 
			// roundedRectangle2
			// 
			this.roundedRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(216D)), ((float)(220D)), ((float)(24D)), ((float)(16D)));
			this.roundedRectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle2.Name = "roundedRectangle2";
			this.roundedRectangle2.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fbPI02", NxtControl.GuiFramework.MouseButtonType.Click));
			this.roundedRectangle2.Text = "PI";
			this.roundedRectangle2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(228D, 208D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(228D, 220D);
			// 
			// PI002
			// 
			this.PI002.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.PI002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PI002.Location = new NxtControl.Drawing.PointF(184D, 240D);
			this.PI002.Name = "PI002";
			this.PI002.Text = "NVPP 001 PI002";
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(284D)), ((float)(196D)), ((float)(20D)), ((float)(24D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(true);
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(284D, 196D),
			new NxtControl.Drawing.PointF(284D, 220D),
			new NxtControl.Drawing.PointF(304D, 208D)});
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(304D, 220D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(304D, 196D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(308D, 220D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(308D, 196D);
			// 
			// BL002
			// 
			this.BL002.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.BL002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL002.Location = new NxtControl.Drawing.PointF(60D, 180D);
			this.BL002.Name = "BL002";
			this.BL002.Text = "NVPP 001 BL002";
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(356D)), ((float)(52D)), ((float)(8D)), ((float)(156D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(356D, 52D),
			new NxtControl.Drawing.PointF(364D, 52D),
			new NxtControl.Drawing.PointF(364D, 208D),
			new NxtControl.Drawing.PointF(356D, 208D)});
			this.pipe3.Width = 4;
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(364D)), ((float)(128D)), ((float)(88D)), ((float)(0D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(364D, 128D),
			new NxtControl.Drawing.PointF(452D, 128D)});
			this.pipe4.Width = 4;
			// 
			// Logic
			// 
			this.Logic.BeginInit();
			this.Logic.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 275D, 136D);
			this.Logic.Name = "Logic";
			this.Logic.SecurityToken = ((uint)(4294967295u));
			this.Logic.TagName = "Logic";
			this.Logic.EndInit();
			// 
			// sBlowers2
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.pipe1,
			this.BL001,
			this.roundedRectangle1,
			this.line1,
			this.PI001,
			this.polygon1,
			this.line2,
			this.line3,
			this.rectangle2,
			this.pipe2,
			this.roundedRectangle2,
			this.line4,
			this.PI002,
			this.polygon2,
			this.line5,
			this.line6,
			this.BL002,
			this.pipe3,
			this.pipe4,
			this.Logic});
			this.SymbolSize = new System.Drawing.Size(468, 376);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.FreeText BL001;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText PI001;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle2;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.FreeText PI002;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.FreeText BL002;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe4;
		private SE.Nereda.Symbols.DAerationLogic.sGraphBtn Logic;
		#endregion
	}
}
