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
	partial class sBlowers
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BL001 = new NxtControl.GuiFramework.FreeText();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.PI001 = new NxtControl.GuiFramework.FreeText();
			this.PI002 = new NxtControl.GuiFramework.FreeText();
			this.BL002 = new NxtControl.GuiFramework.FreeText();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.line7 = new NxtControl.GuiFramework.Line();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.line9 = new NxtControl.GuiFramework.Line();
			this.Blower1 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.Blower2 = new SE.Nereda.Symbols.Motor_VS.sBlower();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.roundedRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.Logic_1 = new SE.Nereda.Symbols.DAerationLogic.sSettingsBtn();
			// 
			// BL001
			// 
			this.BL001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.BL001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL001.Location = new NxtControl.Drawing.PointF(44D, 312D);
			this.BL001.Name = "BL001";
			this.BL001.Text = "NVPP 001 BL001";
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(108D)), ((float)(160D)), ((float)(34D)), ((float)(16D)));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Text = "PI";
			this.roundedRectangle1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(70D, 168D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(112D, 168D);
			// 
			// PI001
			// 
			this.PI001.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.PI001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PI001.Location = new NxtControl.Drawing.PointF(78D, 144D);
			this.PI001.Name = "PI001";
			this.PI001.Text = "NVPP 001 PI001";
			// 
			// PI002
			// 
			this.PI002.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.PI002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PI002.Location = new NxtControl.Drawing.PointF(272D, 144D);
			this.PI002.Name = "PI002";
			this.PI002.Text = "NVPP 001 PI002";
			// 
			// BL002
			// 
			this.BL002.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.BL002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.BL002.Location = new NxtControl.Drawing.PointF(234D, 312D);
			this.BL002.Name = "BL002";
			this.BL002.Text = "NVPP 001 BL002";
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(70D)), ((float)(76D)), ((float)(190D)), ((float)(172D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(70D, 248D),
			new NxtControl.Drawing.PointF(70D, 76D),
			new NxtControl.Drawing.PointF(260D, 76D),
			new NxtControl.Drawing.PointF(260D, 248D)});
			this.pipe3.Width = 8;
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(302D)), ((float)(160D)), ((float)(34D)), ((float)(16D)));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Text = "PI";
			this.roundedRectangle3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line7
			// 
			this.line7.EndPoint = new NxtControl.Drawing.PointF(264D, 168D);
			this.line7.Name = "line7";
			this.line7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line7.StartPoint = new NxtControl.Drawing.PointF(306D, 168D);
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(58D)), ((float)(96D)), ((float)(24D)), ((float)(20D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(70D, 96D),
			new NxtControl.Drawing.PointF(82D, 116D),
			new NxtControl.Drawing.PointF(58D, 116D)});
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(82D, 96D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(58D, 96D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(82D, 92D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(58D, 92D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(248D)), ((float)(96D)), ((float)(24D)), ((float)(20D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(260D, 96D),
			new NxtControl.Drawing.PointF(272D, 116D),
			new NxtControl.Drawing.PointF(248D, 116D)});
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(272D, 96D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(248D, 96D);
			// 
			// line9
			// 
			this.line9.EndPoint = new NxtControl.Drawing.PointF(272D, 92D);
			this.line9.Name = "line9";
			this.line9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line9.StartPoint = new NxtControl.Drawing.PointF(248D, 92D);
			// 
			// Blower1
			// 
			this.Blower1.BeginInit();
			this.Blower1._iMotName = "Motor";
			this.Blower1._iUnit = "%";
			this.Blower1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 34D, 212D);
			this.Blower1.Name = "Blower1";
			this.Blower1.SecurityToken = ((uint)(4294967295u));
			this.Blower1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.Blower1.TagName = "Blower1";
			this.Blower1.EndInit();
			// 
			// Blower2
			// 
			this.Blower2.BeginInit();
			this.Blower2._iMotName = "Motor";
			this.Blower2._iUnit = "%";
			this.Blower2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 212D);
			this.Blower2.Name = "Blower2";
			this.Blower2.SecurityToken = ((uint)(4294967295u));
			this.Blower2.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sBlower.SymbolNameDisplayOption.Hide;
			this.Blower2.TagName = "Blower2";
			this.Blower2.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(165D)), ((float)(28D)), ((float)(0D)), ((float)(48D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(165D, 76D),
			new NxtControl.Drawing.PointF(165D, 28D)});
			this.pipe1.Width = 8;
			// 
			// roundedRectangle2
			// 
			this.roundedRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(145D)), ((float)(56D)), ((float)(40D)), ((float)(40D)));
			this.roundedRectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.roundedRectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle2.Name = "roundedRectangle2";
			this.roundedRectangle2.Radius = 10D;
			// 
			// Logic_1
			// 
			this.Logic_1.BeginInit();
			this.Logic_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.8D, 0D, 0D, 0.8D, 149D, 60D);
			this.Logic_1.Name = "Logic_1";
			this.Logic_1.SecurityToken = ((uint)(4294967295u));
			this.Logic_1.TagName = "Logic";
			this.Logic_1.EndInit();
			// 
			// sBlowers
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe1,
			this.BL001,
			this.line1,
			this.PI001,
			this.pipe3,
			this.polygon3,
			this.line2,
			this.line3,
			this.roundedRectangle1,
			this.PI002,
			this.BL002,
			this.line7,
			this.polygon1,
			this.line8,
			this.line9,
			this.roundedRectangle3,
			this.Blower1,
			this.Blower2,
			this.roundedRectangle2,
			this.Logic_1});
			this.SymbolSize = new System.Drawing.Size(388, 368);

		}
		private NxtControl.GuiFramework.FreeText BL001;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.FreeText PI001;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.FreeText PI002;
		private NxtControl.GuiFramework.FreeText BL002;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.Line line7;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.Line line9;
		private SE.Nereda.Symbols.Motor_VS.sBlower Blower1;
		private SE.Nereda.Symbols.Motor_VS.sBlower Blower2;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle2;
		private SE.Nereda.Symbols.DAerationLogic.sSettingsBtn Logic_1;
		#endregion
	}
}
