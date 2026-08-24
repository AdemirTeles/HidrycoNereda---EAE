/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/24/2026
 * Time: 10:09 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EffluentCdt
{
	/// <summary>
	/// Summary description for sForce.
	/// </summary>
	partial class sForce
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.ActiveStart = new System.HMI.Symbols.Base.SwitchButton();
			this.FlushCdtName = new NxtControl.GuiFramework.RoundedRectangle();
			this.ActiveRdy = new System.HMI.Symbols.Base.SwitchButton();
			this.ActiveStop = new System.HMI.Symbols.Base.SwitchButton();
			this.Mode = new System.HMI.Symbols.Base.SwitchButton();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(176D)), ((float)(152D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 10D;
			// 
			// ActiveStart
			// 
			this.ActiveStart.BeginInit();
			this.ActiveStart.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.1750000000000003D, 0D, 0D, 0.93333333333333335D, 9D, 64D);
			this.ActiveStart.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveStart.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveStart.FalseText = "START";
			this.ActiveStart.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ActiveStart.Name = "ActiveStart";
			this.ActiveStart.TagName = "ActiveStart";
			this.ActiveStart.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveStart.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveStart.TrueText = "START";
			this.ActiveStart.Value = false;
			this.ActiveStart.EndInit();
			// 
			// FlushCdtName
			// 
			this.FlushCdtName.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(176D)), ((float)(24D)));
			this.FlushCdtName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.FlushCdtName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
			this.FlushCdtName.Name = "FlushCdtName";
			this.FlushCdtName.Text = "Effluent Conditions";
			this.FlushCdtName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ActiveRdy
			// 
			this.ActiveRdy.BeginInit();
			this.ActiveRdy.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.1750000000000003D, 0D, 0D, 0.93333333333333335D, 9D, 96D);
			this.ActiveRdy.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveRdy.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveRdy.FalseText = "READY";
			this.ActiveRdy.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ActiveRdy.Name = "ActiveRdy";
			this.ActiveRdy.TagName = "ActiveRdy";
			this.ActiveRdy.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveRdy.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveRdy.TrueText = "READY";
			this.ActiveRdy.Value = false;
			this.ActiveRdy.EndInit();
			// 
			// ActiveStop
			// 
			this.ActiveStop.BeginInit();
			this.ActiveStop.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.175D, 0D, 0D, 0.93333333333333335D, 9D, 128D);
			this.ActiveStop.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveStop.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveStop.FalseText = "STOP";
			this.ActiveStop.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ActiveStop.Name = "ActiveStop";
			this.ActiveStop.TagName = "ActiveStop";
			this.ActiveStop.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveStop.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveStop.TrueText = "STOP";
			this.ActiveStop.Value = false;
			this.ActiveStop.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(2.1750000000000003D, 0D, 0D, 0.93333333333333335D, 9D, 32D);
			this.Mode.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.Mode.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Mode.FalseText = "AUTO";
			this.Mode.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.Mode.Name = "Mode";
			this.Mode.TagName = "Mode";
			this.Mode.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.Mode.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.Mode.TrueText = "MAN";
			this.Mode.Value = false;
			this.Mode.EndInit();
			// 
			// sForce
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.ActiveStart,
			this.ActiveRdy,
			this.ActiveStop,
			this.Mode,
			this.FlushCdtName});
			this.SymbolSize = new System.Drawing.Size(304, 200);

		}
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private System.HMI.Symbols.Base.SwitchButton ActiveStart;
		private NxtControl.GuiFramework.RoundedRectangle FlushCdtName;
		private System.HMI.Symbols.Base.SwitchButton ActiveRdy;
		private System.HMI.Symbols.Base.SwitchButton ActiveStop;
		private System.HMI.Symbols.Base.SwitchButton Mode;
		#endregion
	}
}
