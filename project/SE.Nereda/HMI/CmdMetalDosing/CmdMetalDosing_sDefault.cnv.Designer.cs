/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/7/2026
 * Time: 4:40 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CmdMetalDosing
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
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.SDLevelSetPoint = new System.HMI.Symbols.Base.TextBox<float>();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(40D)), ((float)(368D)), ((float)(48D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 56D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Sludge Discharge Level SetPoint :";
			// 
			// SDLevelSetPoint
			// 
			this.SDLevelSetPoint.BeginInit();
			this.SDLevelSetPoint.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 272D, 52D);
			this.SDLevelSetPoint.MaximumTag = null;
			this.SDLevelSetPoint.MinimumTag = null;
			this.SDLevelSetPoint.Name = "SDLevelSetPoint";
			this.SDLevelSetPoint.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.SDLevelSetPoint.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Black"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.SDLevelSetPoint.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.SDLevelSetPoint.Suffix = "m";
			this.SDLevelSetPoint.TagName = "SDLevelSetPoint";
			this.SDLevelSetPoint.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.SDLevelSetPoint.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.SDLevelSetPoint.UseInputPad = true;
			this.SDLevelSetPoint.Value = 0F;
			this.SDLevelSetPoint.EndInit();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(176D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 48D),
			new NxtControl.Drawing.PointF(8D, 24D),
			new NxtControl.Drawing.PointF(160D, 24D),
			new NxtControl.Drawing.PointF(184D, 48D)});
			this.polygon1.Text = "SLUDGE DISCHARGE";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText1,
			this.SDLevelSetPoint});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> SDLevelSetPoint;
		private NxtControl.GuiFramework.Polygon polygon1;
		#endregion
	}
}
