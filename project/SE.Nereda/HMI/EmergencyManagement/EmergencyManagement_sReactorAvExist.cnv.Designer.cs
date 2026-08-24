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
	partial class sReactorAvExist
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.NbrAvailableReactors = new System.HMI.Symbols.Base.FreeText<short>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.NbrTotalReactors = new System.HMI.Symbols.Base.FreeText<short>();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(200D)), ((float)(40D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// NbrAvailableReactors
			// 
			this.NbrAvailableReactors.BeginInit();
			this.NbrAvailableReactors.DecimalPlacesCount = ((uint)(2u));
			this.NbrAvailableReactors.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 152D, 12D);
			this.NbrAvailableReactors.IsOnlyInput = true;
			this.NbrAvailableReactors.Name = "NbrAvailableReactors";
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.NbrAvailableReactors.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.NbrAvailableReactors.TagName = "NbrAvailableReactors";
			this.NbrAvailableReactors.TextAngle = 0F;
			this.NbrAvailableReactors.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(12D, 12D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Nbr Available Reactors :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(12D, 28D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Total Reactors :";
			// 
			// NbrTotalReactors
			// 
			this.NbrTotalReactors.BeginInit();
			this.NbrTotalReactors.DecimalPlacesCount = ((uint)(2u));
			this.NbrTotalReactors.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 152D, 28D);
			this.NbrTotalReactors.IsOnlyInput = true;
			this.NbrTotalReactors.Name = "NbrTotalReactors";
			propertyDictionary6.Add("Text", "${Value}");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.NbrTotalReactors.Ranges.DefaultPropertyValues = propertyDictionary6;
			this.NbrTotalReactors.TagName = "NbrTotalReactors";
			this.NbrTotalReactors.TextAngle = 0F;
			this.NbrTotalReactors.EndInit();
			// 
			// sReactorAvExist
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.NbrAvailableReactors,
			this.freeText1,
			this.freeText2,
			this.NbrTotalReactors});
			this.SymbolSize = new System.Drawing.Size(400, 200);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private System.HMI.Symbols.Base.FreeText<short> NbrAvailableReactors;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.FreeText<short> NbrTotalReactors;
		#endregion
	}
}
