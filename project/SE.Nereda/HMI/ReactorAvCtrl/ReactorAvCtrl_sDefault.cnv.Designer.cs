/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 2:26 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ReactorAvCtrl
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
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.ForceNotAvR1 = new System.HMI.Symbols.Base.SwitchButton();
			this.ForceNotAvR2 = new System.HMI.Symbols.Base.SwitchButton();
			this.ForceNotAvR3 = new System.HMI.Symbols.Base.SwitchButton();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
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
			this.polygon2.Text = "FORCE REACTOR AVAIBILITY";
			this.polygon2.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(104D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 38D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Force Unavaibility - Reactor 1 :";
			// 
			// ForceNotAvR1
			// 
			this.ForceNotAvR1.BeginInit();
			this.ForceNotAvR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.8666666666666667D, 272D, 32D);
			this.ForceNotAvR1.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR1.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ForceNotAvR1.Name = "ForceNotAvR1";
			this.ForceNotAvR1.TagName = "ForceNotAvR1";
			this.ForceNotAvR1.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR1.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR1.Value = false;
			this.ForceNotAvR1.EndInit();
			// 
			// ForceNotAvR2
			// 
			this.ForceNotAvR2.BeginInit();
			this.ForceNotAvR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.8666666666666667D, 272D, 64D);
			this.ForceNotAvR2.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR2.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR2.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ForceNotAvR2.Name = "ForceNotAvR2";
			this.ForceNotAvR2.TagName = "ForceNotAvR2";
			this.ForceNotAvR2.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR2.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR2.Value = false;
			this.ForceNotAvR2.EndInit();
			// 
			// ForceNotAvR3
			// 
			this.ForceNotAvR3.BeginInit();
			this.ForceNotAvR3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 0.8666666666666667D, 272D, 96D);
			this.ForceNotAvR3.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR3.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR3.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ForceNotAvR3.Name = "ForceNotAvR3";
			this.ForceNotAvR3.TagName = "ForceNotAvR3";
			this.ForceNotAvR3.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR3.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ForceNotAvR3.Value = false;
			this.ForceNotAvR3.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Force Unavaibility - Reactor 2 :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 100D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Force Unavaibility - Reactor 3 :";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.rectangle2,
			this.freeText1,
			this.ForceNotAvR1,
			this.ForceNotAvR2,
			this.ForceNotAvR3,
			this.freeText2,
			this.freeText3});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.SwitchButton ForceNotAvR1;
		private System.HMI.Symbols.Base.SwitchButton ForceNotAvR2;
		private System.HMI.Symbols.Base.SwitchButton ForceNotAvR3;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		#endregion
	}
}
