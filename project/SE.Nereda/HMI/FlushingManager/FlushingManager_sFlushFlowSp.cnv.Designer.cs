/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/11/2026
 * Time: 11:34 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.FlushingManager
{
	/// <summary>
	/// Summary description for sFlushFlowSp.
	/// </summary>
	partial class sFlushFlowSp
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.FlowSP = new System.HMI.Symbols.Base.FreeText<float>();
			// 
			// FlowSP
			// 
			this.FlowSP.BeginInit();
			this.FlowSP.DecimalPlacesCount = ((uint)(2u));
			this.FlowSP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 8D);
			this.FlowSP.IsOnlyInput = true;
			this.FlowSP.Name = "FlowSP";
			this.FlowSP.Ranges.Clear();
			this.FlowSP.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.FlowSP.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.FlowSP.Suffix = "m³/h";
			this.FlowSP.TagName = "FlowSP";
			this.FlowSP.TextAngle = 0F;
			this.FlowSP.EndInit();
			// 
			// sFlushFlowSp
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.FlowSP});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private System.HMI.Symbols.Base.FreeText<float> FlowSP;
		#endregion
	}
}
