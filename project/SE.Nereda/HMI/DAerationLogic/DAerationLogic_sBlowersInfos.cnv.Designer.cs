/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/12/2026
 * Time: 10:11 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.DAerationLogic
{
	/// <summary>
	/// Summary description for sBlowersInfos.
	/// </summary>
	partial class sBlowersInfos
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.TotRunDurBl1Txt = new NxtControl.GuiFramework.FreeText();
			this.BL1OpCount = new System.HMI.Symbols.Base.FreeText<uint>();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.TotRunDurBl2Txt = new NxtControl.GuiFramework.FreeText();
			this.BL2OpCount = new System.HMI.Symbols.Base.FreeText<uint>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(136D)), ((float)(48D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// TotRunDurBl1Txt
			// 
			this.TotRunDurBl1Txt.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.TotRunDurBl1Txt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.TotRunDurBl1Txt.Location = new NxtControl.Drawing.PointF(44D, 16D);
			this.TotRunDurBl1Txt.Name = "TotRunDurBl1Txt";
			this.TotRunDurBl1Txt.Text = "0h : 0min";
			// 
			// BL1OpCount
			// 
			this.BL1OpCount.BeginInit();
			this.BL1OpCount.DecimalPlacesCount = ((uint)(2u));
			this.BL1OpCount.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 104D, 32D);
			this.BL1OpCount.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.BL1OpCount.IsOnlyInput = true;
			this.BL1OpCount.Name = "BL1OpCount";
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.BL1OpCount.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.BL1OpCount.TagName = "BL1OpCount";
			this.BL1OpCount.TextAngle = 0F;
			this.BL1OpCount.EndInit();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(8D)), ((float)(136D)), ((float)(48D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// TotRunDurBl2Txt
			// 
			this.TotRunDurBl2Txt.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.TotRunDurBl2Txt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.TotRunDurBl2Txt.Location = new NxtControl.Drawing.PointF(228D, 16D);
			this.TotRunDurBl2Txt.Name = "TotRunDurBl2Txt";
			this.TotRunDurBl2Txt.Text = "0h : 0min";
			// 
			// BL2OpCount
			// 
			this.BL2OpCount.BeginInit();
			this.BL2OpCount.DecimalPlacesCount = ((uint)(2u));
			this.BL2OpCount.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 288D, 32D);
			this.BL2OpCount.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.BL2OpCount.IsOnlyInput = true;
			this.BL2OpCount.Name = "BL2OpCount";
			propertyDictionary2.Add("Text", "${Value}");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114))));
			this.BL2OpCount.Ranges.DefaultPropertyValues = propertyDictionary2;
			this.BL2OpCount.TagName = "BL2OpCount";
			this.BL2OpCount.TextAngle = 0F;
			this.BL2OpCount.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 32D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Start Count";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(26)), ((byte)(62)), ((byte)(114)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(200D, 32D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Start Count";
			// 
			// sBlowersInfos
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.TotRunDurBl1Txt,
			this.BL1OpCount,
			this.rectangle2,
			this.TotRunDurBl2Txt,
			this.BL2OpCount,
			this.freeText1,
			this.freeText2});
			this.SymbolSize = new System.Drawing.Size(592, 256);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.FreeText TotRunDurBl1Txt;
		private System.HMI.Symbols.Base.FreeText<uint> BL1OpCount;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.FreeText TotRunDurBl2Txt;
		private System.HMI.Symbols.Base.FreeText<uint> BL2OpCount;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		#endregion
	}
}
