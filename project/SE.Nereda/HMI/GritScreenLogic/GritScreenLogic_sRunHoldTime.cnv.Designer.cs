/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/11/2026
 * Time: 2:41 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.GritScreenLogic
{
	/// <summary>
	/// Summary description for sRunHoldTime.
	/// </summary>
	partial class sRunHoldTime
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.RunHoldTime = new SE.Nereda.Symbols.E_DELAY_V_D.sCounter();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.RunHoldT = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Grit Screen Running Hold Time";
			// 
			// RunHoldTime
			// 
			this.RunHoldTime.BeginInit();
			this.RunHoldTime.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 24D);
			this.RunHoldTime.Name = "RunHoldTime";
			this.RunHoldTime.SecurityToken = ((uint)(4294967295u));
			this.RunHoldTime.TagName = "RunHoldTime";
			this.RunHoldTime.EndInit();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(248D)), ((float)(40D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText1,
			this.RunHoldTime});
			this.group1.EndInit();
			// 
			// RunHoldT
			// 
			this.RunHoldT.BeginInit();
			this.RunHoldT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 83D, 80D);
			this.RunHoldT.IsOnlyInput = true;
			this.RunHoldT.Location = new NxtControl.Drawing.PointF(83D, 80D);
			this.RunHoldT.Name = "RunHoldT";
			this.RunHoldT.Size = new NxtControl.Drawing.SizeF(100D, 20D);
			this.RunHoldT.TagName = "RunHoldT";
			this.RunHoldT.Value = false;
			this.RunHoldT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RunHoldTValueChanged);
			this.RunHoldT.EndInit();
			// 
			// sRunHoldTime
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1,
			this.RunHoldT});
			this.SymbolSize = new System.Drawing.Size(400, 200);

		}
		private SE.Nereda.Symbols.E_DELAY_V_D.sCounter RunHoldTime;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Group group1;
		private System.HMI.Symbols.Base.Execute<bool> RunHoldT;
		#endregion
	}
}
