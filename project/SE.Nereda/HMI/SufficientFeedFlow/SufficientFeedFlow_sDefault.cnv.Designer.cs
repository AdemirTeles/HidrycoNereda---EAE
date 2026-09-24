/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 9/23/2026
 * Time: 3:20 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.SufficientFeedFlow
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
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.MinLevelRiseSp_1 = new System.HMI.Symbols.Base.TextBox<float>();
			this.LevelCheckTimeSp = new System.HMI.Symbols.Base.TextBox<int>();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(84D)), ((float)(192D)), ((float)(28D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(56D, 108D),
			new NxtControl.Drawing.PointF(56D, 84D),
			new NxtControl.Drawing.PointF(220D, 84D),
			new NxtControl.Drawing.PointF(248D, 112D)});
			this.polygon1.Text = "SUFFICIENT FEED FLOW";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(100D)), ((float)(394D)), ((float)(88D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(68D, 114D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Minimum Level Rise:";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(68D, 154D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Feed Flow Check Time:";
			// 
			// MinLevelRiseSp_1
			// 
			this.MinLevelRiseSp_1.BeginInit();
			this.MinLevelRiseSp_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 326D, 110D);
			this.MinLevelRiseSp_1.MaximumTag = null;
			this.MinLevelRiseSp_1.MinimumTag = null;
			this.MinLevelRiseSp_1.Name = "MinLevelRiseSp_1";
			this.MinLevelRiseSp_1.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.MinLevelRiseSp_1.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.MinLevelRiseSp_1.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.MinLevelRiseSp_1.Suffix = "m";
			this.MinLevelRiseSp_1.TagName = "MinLevelRiseSp";
			this.MinLevelRiseSp_1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.MinLevelRiseSp_1.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.MinLevelRiseSp_1.UseInputPad = true;
			this.MinLevelRiseSp_1.Value = 0F;
			this.MinLevelRiseSp_1.EndInit();
			// 
			// LevelCheckTimeSp
			// 
			this.LevelCheckTimeSp.BeginInit();
			this.LevelCheckTimeSp.DecimalPlacesCount = ((uint)(0u));
			this.LevelCheckTimeSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 326D, 150D);
			this.LevelCheckTimeSp.Maximum = 36;
			this.LevelCheckTimeSp.MaximumTag = null;
			this.LevelCheckTimeSp.MinimumTag = null;
			this.LevelCheckTimeSp.Name = "LevelCheckTimeSp";
			this.LevelCheckTimeSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.LevelCheckTimeSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.LevelCheckTimeSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.LevelCheckTimeSp.Suffix = "s";
			this.LevelCheckTimeSp.TagName = "LevelCheckTimeSp";
			this.LevelCheckTimeSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.LevelCheckTimeSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.LevelCheckTimeSp.UseInputPad = true;
			this.LevelCheckTimeSp.Value = 0;
			this.LevelCheckTimeSp.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText11,
			this.freeText2,
			this.MinLevelRiseSp_1,
			this.LevelCheckTimeSp});
			this.SymbolSize = new System.Drawing.Size(456, 256);

		}
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.TextBox<float> MinLevelRiseSp_1;
		private System.HMI.Symbols.Base.TextBox<int> LevelCheckTimeSp;
		#endregion
	}
}
