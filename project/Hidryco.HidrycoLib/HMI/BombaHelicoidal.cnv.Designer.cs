/*
 * Hidryco - grafico BombaHelicoidal
 * Bomba helicoidal (motor, succao com bocal em cima, estator, recalque na ponta); cor pela Animacao.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
	partial class BombaHelicoidal
	{
		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.hl_base = new NxtControl.GuiFramework.Rectangle();
			this.hl_1 = new NxtControl.GuiFramework.Rectangle();
			this.hl_2 = new NxtControl.GuiFramework.Rectangle();
			this.hl_3 = new NxtControl.GuiFramework.Rectangle();
			this.hl_4 = new NxtControl.GuiFramework.Rectangle();
			this.hl_5 = new NxtControl.GuiFramework.Rectangle();
			this.hl_6 = new NxtControl.GuiFramework.Rectangle();
			this.hl_7 = new NxtControl.GuiFramework.Rectangle();
			this.hl_8 = new NxtControl.GuiFramework.Rectangle();
			this.hl_9 = new NxtControl.GuiFramework.Rectangle();
			this.hl_10 = new NxtControl.GuiFramework.Rectangle();
			this.hl_11 = new NxtControl.GuiFramework.Rectangle();
			this.hl_12 = new NxtControl.GuiFramework.Rectangle();
			this.hl_13 = new NxtControl.GuiFramework.Rectangle();
			// 
			// hl_base
			// 
			this.hl_base.Bounds = new NxtControl.Drawing.RectF(((float)(4D)), ((float)(62D)), ((float)(200D)), ((float)(6D)));
			this.hl_base.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.hl_base.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_base.Name = "hl_base";
			this.hl_base.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_1
			// 
			this.hl_1.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(20D)), ((float)(44D)), ((float)(40D)));
			this.hl_1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_1.Name = "hl_1";
			this.hl_1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_2
			// 
			this.hl_2.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(13D)), ((float)(18D)), ((float)(7D)));
			this.hl_2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_2.Name = "hl_2";
			this.hl_2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_3
			// 
			this.hl_3.Bounds = new NxtControl.Drawing.RectF(((float)(44D)), ((float)(30D)), ((float)(14D)), ((float)(20D)));
			this.hl_3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_3.Name = "hl_3";
			this.hl_3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_4
			// 
			this.hl_4.Bounds = new NxtControl.Drawing.RectF(((float)(58D)), ((float)(24D)), ((float)(44D)), ((float)(32D)));
			this.hl_4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_4.Name = "hl_4";
			this.hl_4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_5
			// 
			this.hl_5.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(12D)), ((float)(16D)), ((float)(12D)));
			this.hl_5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_5.Name = "hl_5";
			this.hl_5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_6
			// 
			this.hl_6.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(8D)), ((float)(26D)), ((float)(4D)));
			this.hl_6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_6.Name = "hl_6";
			this.hl_6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_7
			// 
			this.hl_7.Bounds = new NxtControl.Drawing.RectF(((float)(102D)), ((float)(30D)), ((float)(96D)), ((float)(20D)));
			this.hl_7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_7.Name = "hl_7";
			this.hl_7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_8
			// 
			this.hl_8.Bounds = new NxtControl.Drawing.RectF(((float)(198D)), ((float)(24D)), ((float)(6D)), ((float)(32D)));
			this.hl_8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.hl_8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_8.Name = "hl_8";
			this.hl_8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_9
			// 
			this.hl_9.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(22D)), ((float)(1D)), ((float)(36D)));
			this.hl_9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))));
			this.hl_9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_9.Name = "hl_9";
			this.hl_9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_10
			// 
			this.hl_10.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(22D)), ((float)(1D)), ((float)(36D)));
			this.hl_10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))));
			this.hl_10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_10.Name = "hl_10";
			this.hl_10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_11
			// 
			this.hl_11.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(22D)), ((float)(1D)), ((float)(36D)));
			this.hl_11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))));
			this.hl_11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_11.Name = "hl_11";
			this.hl_11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_12
			// 
			this.hl_12.Bounds = new NxtControl.Drawing.RectF(((float)(30D)), ((float)(22D)), ((float)(1D)), ((float)(36D)));
			this.hl_12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))));
			this.hl_12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_12.Name = "hl_12";
			this.hl_12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hl_13
			// 
			this.hl_13.Bounds = new NxtControl.Drawing.RectF(((float)(38D)), ((float)(22D)), ((float)(1D)), ((float)(36D)));
			this.hl_13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))));
			this.hl_13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.hl_13.Name = "hl_13";
			this.hl_13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.hl_base,
			this.hl_1,
			this.hl_2,
			this.hl_3,
			this.hl_4,
			this.hl_5,
			this.hl_6,
			this.hl_7,
			this.hl_8,
			this.hl_9,
			this.hl_10,
			this.hl_11,
			this.hl_12,
			this.hl_13});
			this.SymbolSize = new System.Drawing.Size(206, 70);

		}
		private NxtControl.GuiFramework.Rectangle hl_base;
		private NxtControl.GuiFramework.Rectangle hl_1;
		private NxtControl.GuiFramework.Rectangle hl_2;
		private NxtControl.GuiFramework.Rectangle hl_3;
		private NxtControl.GuiFramework.Rectangle hl_4;
		private NxtControl.GuiFramework.Rectangle hl_5;
		private NxtControl.GuiFramework.Rectangle hl_6;
		private NxtControl.GuiFramework.Rectangle hl_7;
		private NxtControl.GuiFramework.Rectangle hl_8;
		private NxtControl.GuiFramework.Rectangle hl_9;
		private NxtControl.GuiFramework.Rectangle hl_10;
		private NxtControl.GuiFramework.Rectangle hl_11;
		private NxtControl.GuiFramework.Rectangle hl_12;
		private NxtControl.GuiFramework.Rectangle hl_13;
		#endregion
	}
}
