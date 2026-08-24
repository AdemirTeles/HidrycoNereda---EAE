/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA713705
 * Date: 8/20/2024
 * Time: 11:59 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.KeepCurrentOpCdtHMI
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sDefault));
			this.UpdateOpCndt = new System.HMI.Symbols.Base.CheckButton();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.NeedUpdate = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// UpdateOpCndt
			// 
			this.UpdateOpCndt.BeginInit();
			this.UpdateOpCndt.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2D, 0D, 0D, 1D, 8D, 8D);
			this.UpdateOpCndt.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.UpdateOpCndt.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.UpdateOpCndt.FalseText = "Acknowledge";
			this.UpdateOpCndt.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.UpdateOpCndt.FontScale = false;
			this.UpdateOpCndt.Name = "UpdateOpCndt";
			this.UpdateOpCndt.TagName = "UpdateOpCndt";
			this.UpdateOpCndt.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.UpdateOpCndt.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.UpdateOpCndt.TrueText = "Acknowledge";
			this.UpdateOpCndt.Value = false;
			this.UpdateOpCndt.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(8D)), ((float)(32D)), ((float)(32D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.ImageBytes = resources.GetString("drawnButton1.ImageBytes");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSetting", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			// 
			// NeedUpdate
			// 
			this.NeedUpdate.BeginInit();
			this.NeedUpdate.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 132D, 222D);
			this.NeedUpdate.IsOnlyInput = true;
			this.NeedUpdate.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedUpdate.Name = "NeedUpdate";
			this.NeedUpdate.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedUpdate.TagName = "NeedUpdate";
			this.NeedUpdate.Value = false;
			this.NeedUpdate.EndInit();
			// 
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.UpdateOpCndt,
			this.drawnButton1,
			this.NeedUpdate});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private System.HMI.Symbols.Base.CheckButton UpdateOpCndt;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private System.HMI.Symbols.Base.Execute<bool> NeedUpdate;
		#endregion
	}
}
