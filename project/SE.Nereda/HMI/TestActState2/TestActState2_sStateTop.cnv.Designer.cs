/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/3/2026
 * Time: 11:56 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.TestActState2
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sStateTop
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sStateTop));
			this.state = new NxtControl.GuiFramework.Rectangle();
			this.starting = new NxtControl.GuiFramework.Polygon();
			this.stopping = new NxtControl.GuiFramework.Polygon();
			this.Mode = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.ManuelMode = new NxtControl.GuiFramework.Rectangle();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// state
			// 
			this.state.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(36D)), ((float)(16D)), ((float)(16D)));
			this.state.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.state.Name = "state";
			this.state.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// starting
			// 
			this.starting.Bounds = new NxtControl.Drawing.RectF(((float)(27D)), ((float)(39D)), ((float)(10D)), ((float)(10D)));
			this.starting.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(255)), ((byte)(204))));
			this.starting.Closed = true;
			this.starting.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.starting.Name = "starting";
			this.starting.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(27D, 39D),
			new NxtControl.Drawing.PointF(27D, 49D),
			new NxtControl.Drawing.PointF(37D, 44D)});
			// 
			// stopping
			// 
			this.stopping.Bounds = new NxtControl.Drawing.RectF(((float)(27D)), ((float)(39D)), ((float)(10D)), ((float)(10D)));
			this.stopping.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(204)), ((byte)(255)), ((byte)(204))));
			this.stopping.Closed = true;
			this.stopping.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.stopping.Name = "stopping";
			this.stopping.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(37D, 39D),
			new NxtControl.Drawing.PointF(37D, 49D),
			new NxtControl.Drawing.PointF(27D, 44D)});
			// 
			// Mode
			// 
			this.Mode.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(16D)), ((float)(38D)), ((float)(16D)));
			this.Mode.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.Mode.Font = new NxtControl.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold);
			this.Mode.Name = "Mode";
			this.Mode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Mode.TextAlignment = NxtControl.Drawing.ContentAlignment.BottomLeft;
			this.Mode.TextColor = new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78)));
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.state,
			this.starting,
			this.stopping,
			this.Mode});
			this.group1.EndInit();
			// 
			// ManuelMode
			// 
			this.ManuelMode.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(56D)), ((float)(16D)), ((float)(16D)));
			this.ManuelMode.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.ManuelMode.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ManuelMode.ImageBytes = resources.GetString("ManuelMode.ImageBytes");
			this.ManuelMode.Name = "ManuelMode";
			this.ManuelMode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.ManuelMode});
			this.group2.EndInit();
			// 
			// sStateTop
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group2});
			this.SymbolSize = new System.Drawing.Size(120, 96);

		}
		private NxtControl.GuiFramework.Rectangle state;
		private NxtControl.GuiFramework.Polygon starting;
		private NxtControl.GuiFramework.Polygon stopping;
		private NxtControl.GuiFramework.Rectangle Mode;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Rectangle ManuelMode;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
