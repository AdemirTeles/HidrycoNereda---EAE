/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 4:56 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyManagement
{
	/// <summary>
	/// Summary description for sReactorAvExist.
	/// </summary>
	partial class sCycleCounter
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.CycleCounter = new System.HMI.Symbols.Base.FreeText<int>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(200D)), ((float)(40D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(12D, 12D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Feed Counter :";
			// 
			// CycleCounter
			// 
			this.CycleCounter.BeginInit();
			this.CycleCounter.DecimalPlacesCount = ((uint)(2u));
			this.CycleCounter.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 136D, 24D);
			this.CycleCounter.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.CycleCounter.IsOnlyInput = true;
			this.CycleCounter.Name = "CycleCounter";
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.CycleCounter.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.CycleCounter.TagName = "CycleCounter";
			this.CycleCounter.TextAngle = 0F;
			this.CycleCounter.EndInit();
			// 
			// sCycleCounter
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.freeText1,
			this.CycleCounter});
			this.SymbolSize = new System.Drawing.Size(400, 200);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.FreeText<int> CycleCounter;
		#endregion
	}
}
