/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 3:21 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NextFeedHorizon
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
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(288D)), ((float)(24D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(264D, 8D),
			new NxtControl.Drawing.PointF(296D, 32D)});
			this.polygon2.Text = "NEXT FEED HORIZON";
			this.polygon2.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(104D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.rectangle2});
			this.SymbolSize = new System.Drawing.Size(432, 224);

		}
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		#endregion
	}
}
