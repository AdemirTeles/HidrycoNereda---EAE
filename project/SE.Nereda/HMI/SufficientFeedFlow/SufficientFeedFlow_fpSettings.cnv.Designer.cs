/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 9/23/2026
 * Time: 3:32 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.SufficientFeedFlow
{
	/// <summary>
	/// Summary description for fpSettings.
	/// </summary>
	partial class fpSettings
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.MinLevelRiseSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.txtLevelCheckTimeSp = new System.HMI.Symbols.Base.TextBox<int>();
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 28D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Minimum Level Rise:";
			// 
			// MinLevelRiseSp
			// 
			this.MinLevelRiseSp.BeginInit();
			this.MinLevelRiseSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6399999999999999D, 0D, 0D, 1D, 200D, 24D);
			this.MinLevelRiseSp.MaximumTag = null;
			this.MinLevelRiseSp.MinimumTag = null;
			this.MinLevelRiseSp.Name = "MinLevelRiseSp";
			this.MinLevelRiseSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.MinLevelRiseSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.MinLevelRiseSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.MinLevelRiseSp.Suffix = "m";
			this.MinLevelRiseSp.TagName = "MinLevelRiseSp";
			this.MinLevelRiseSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.MinLevelRiseSp.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.MinLevelRiseSp.UseInputPad = true;
			this.MinLevelRiseSp.Value = 0F;
			this.MinLevelRiseSp.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 68D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Feed Flow Check Time:";
			// 
			// txtLevelCheckTimeSp
			// 
			this.txtLevelCheckTimeSp.BeginInit();
			this.txtLevelCheckTimeSp.DecimalPlacesCount = ((uint)(0u));
			this.txtLevelCheckTimeSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 200D, 64D);
			this.txtLevelCheckTimeSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtLevelCheckTimeSp.MaximumTag = null;
			this.txtLevelCheckTimeSp.MinimumTag = null;
			this.txtLevelCheckTimeSp.Name = "txtLevelCheckTimeSp";
			this.txtLevelCheckTimeSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtLevelCheckTimeSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtLevelCheckTimeSp.SecurityLevel = 6;
			this.txtLevelCheckTimeSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtLevelCheckTimeSp.Suffix = "s";
			this.txtLevelCheckTimeSp.TagName = "LevelCheckTimeSp";
			this.txtLevelCheckTimeSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtLevelCheckTimeSp.UseInputPad = true;
			this.txtLevelCheckTimeSp.UseRange = true;
			this.txtLevelCheckTimeSp.Value = 0;
			this.txtLevelCheckTimeSp.EndInit();
			// 
			// fpSettings
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(344D)), ((float)(120D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText11,
			this.MinLevelRiseSp,
			this.freeText2,
			this.txtLevelCheckTimeSp});
			this.Size = new System.Drawing.Size(344, 120);

		}
		private NxtControl.GuiFramework.FreeText freeText11;
		private System.HMI.Symbols.Base.TextBox<float> MinLevelRiseSp;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<int> txtLevelCheckTimeSp;
		#endregion
	}
}
