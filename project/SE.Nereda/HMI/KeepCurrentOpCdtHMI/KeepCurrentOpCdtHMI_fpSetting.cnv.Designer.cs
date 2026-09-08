/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/20/2024
 * Time: 12:06 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.KeepCurrentOpCdtHMI
{
	/// <summary>
	/// Summary description for fpSetting.
	/// </summary>
	partial class fpSetting
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.ActiveUpdate = new System.HMI.Symbols.Base.SwitchButton();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			// 
			// ActiveUpdate
			// 
			this.ActiveUpdate.BeginInit();
			this.ActiveUpdate.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.5D, 0D, 0D, 1.2666666666666666D, 136D, 88D);
			this.ActiveUpdate.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveUpdate.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveUpdate.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ActiveUpdate.Name = "ActiveUpdate";
			this.ActiveUpdate.TagName = "ActiveUpdate";
			this.ActiveUpdate.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.ActiveUpdate.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.ActiveUpdate.Value = false;
			this.ActiveUpdate.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "ON :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 48D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "OFF :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(48D, 8D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Aborted or interlocked, the operating conditions remain";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(48D, 24D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "displayed until the \"Acknowledge\" button is clicked";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(48D, 48D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "The \"Acknowledge\" button is deactivated, and the operating";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(48D, 64D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "conditions change based on the current state.";
			// 
			// fpSetting
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(392D)), ((float)(136D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Name = "fpSetting";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ActiveUpdate,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6});
			this.Size = new System.Drawing.Size(392, 136);

		}
		private System.HMI.Symbols.Base.SwitchButton ActiveUpdate;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		#endregion
	}
}
