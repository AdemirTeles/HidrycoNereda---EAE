/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/22/2026
 * Time: 8:23 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushSelector
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
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.GSI_RDY = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.GSs_RDY = new NxtControl.GuiFramework.Rectangle();
			this.SLB_RDY = new NxtControl.GuiFramework.Rectangle();
			this.OpenGraph = new NxtControl.GuiFramework.Rectangle();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(64D)), ((float)(208D)), ((float)(24D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rectangle1.Name = "rectangle1";
			this.rectangle1.Text = "Flush Grit Screen Installation Ready :";
			this.rectangle1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GSI_RDY
			// 
			this.GSI_RDY.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(64D)), ((float)(40D)), ((float)(24D)));
			this.GSI_RDY.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center));
			this.GSI_RDY.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.GSI_RDY.Name = "GSI_RDY";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(88D)), ((float)(208D)), ((float)(24D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rectangle3.Name = "rectangle3";
			this.rectangle3.Text = "Flush Grit Screens Ready :";
			this.rectangle3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(112D)), ((float)(208D)), ((float)(24D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Text = "Flush Sludge Buffer Ready :";
			this.rectangle4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GSs_RDY
			// 
			this.GSs_RDY.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(88D)), ((float)(40D)), ((float)(24D)));
			this.GSs_RDY.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center));
			this.GSs_RDY.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.GSs_RDY.Name = "GSs_RDY";
			// 
			// SLB_RDY
			// 
			this.SLB_RDY.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(112D)), ((float)(40D)), ((float)(24D)));
			this.SLB_RDY.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(106)), ((byte)(106)), ((byte)(106))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center));
			this.SLB_RDY.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.SLB_RDY.Name = "SLB_RDY";
			// 
			// OpenGraph
			// 
			this.OpenGraph.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(64D)), ((float)(248D)), ((float)(72D)));
			this.OpenGraph.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenGraph.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenGraph.Name = "OpenGraph";
			this.OpenGraph.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpFlushDiagram", NxtControl.GuiFramework.MouseButtonType.Click));
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.GSI_RDY,
			this.rectangle3,
			this.rectangle4,
			this.GSs_RDY,
			this.SLB_RDY,
			this.OpenGraph});
			this.SymbolSize = new System.Drawing.Size(288, 192);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle GSI_RDY;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle GSs_RDY;
		private NxtControl.GuiFramework.Rectangle SLB_RDY;
		private NxtControl.GuiFramework.Rectangle OpenGraph;
		#endregion
	}
}
