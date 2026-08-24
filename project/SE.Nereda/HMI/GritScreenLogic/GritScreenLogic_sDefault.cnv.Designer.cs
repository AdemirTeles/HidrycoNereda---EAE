/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/15/2026
 * Time: 3:56 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
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
			this.RunHoldTimeSp = new System.HMI.Symbols.Base.TimeTextBox();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.ResetSafetyStop = new System.HMI.Symbols.Base.CheckButton();
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(176D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(8D, 32D),
			new NxtControl.Drawing.PointF(8D, 8D),
			new NxtControl.Drawing.PointF(160D, 8D),
			new NxtControl.Drawing.PointF(184D, 32D)});
			this.polygon1.Text = "GRIT SCREEN";
			this.polygon1.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(24D)), ((float)(360D)), ((float)(112D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 108D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Control Logic Diagram :";
			// 
			// RunHoldTimeSp
			// 
			this.RunHoldTimeSp.BeginInit();
			this.RunHoldTimeSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.64D, 0D, 0D, 1D, 240D, 32D);
			this.RunHoldTimeSp.MaximumTag = null;
			this.RunHoldTimeSp.MinimumTag = null;
			this.RunHoldTimeSp.Name = "RunHoldTimeSp";
			this.RunHoldTimeSp.TagName = "RunHoldTimeSp";
			this.RunHoldTimeSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.RunHoldTimeSp.UseInputPad = true;
			this.RunHoldTimeSp.Value = new NxtControl.GuiFramework.Time(((long)(0)));
			this.RunHoldTimeSp.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 36D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Grit Screen Run Hold Time SP :";
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(104D)), ((float)(96D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Diagram";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 70D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Reset Safety Stop :";
			// 
			// ResetSafetyStop
			// 
			this.ResetSafetyStop.BeginInit();
			this.ResetSafetyStop.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2D, 0D, 0D, 1D, 240D, 64D);
			this.ResetSafetyStop.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ResetSafetyStop.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ResetSafetyStop.FalseText = "RESET";
			this.ResetSafetyStop.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ResetSafetyStop.FontScale = false;
			this.ResetSafetyStop.Name = "ResetSafetyStop";
			this.ResetSafetyStop.TagName = "ResetSafetyStop";
			this.ResetSafetyStop.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ResetSafetyStop.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ResetSafetyStop.TrueText = "RESET";
			this.ResetSafetyStop.Value = false;
			this.ResetSafetyStop.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.rectangle1,
			this.freeText11,
			this.RunHoldTimeSp,
			this.freeText1,
			this.drawnButton1,
			this.freeText2,
			this.ResetSafetyStop});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText11;
		private System.HMI.Symbols.Base.TimeTextBox RunHoldTimeSp;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.CheckButton ResetSafetyStop;
		#endregion
	}
}
