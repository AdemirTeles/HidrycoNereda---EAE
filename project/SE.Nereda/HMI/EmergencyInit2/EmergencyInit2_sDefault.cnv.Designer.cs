/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/15/2026
 * Time: 1:38 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.EmergencyInit2
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
			this.ShowInitAct = new NxtControl.GuiFramework.DrawnButton();
			this.ShowInitAction = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// ShowInitAct
			// 
			this.ShowInitAct.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(16D)), ((float)(40D)), ((float)(40D)));
			this.ShowInitAct.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.ShowInitAct.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.ShowInitAct.ImageBytes = resources.GetString("ShowInitAct.ImageBytes");
			this.ShowInitAct.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.ShowInitAct.Name = "ShowInitAct";
			this.ShowInitAct.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpInitAction", NxtControl.GuiFramework.MouseButtonType.Click));
			this.ShowInitAct.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.ShowInitAct.Radius = 4D;
			this.ShowInitAct.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.ShowInitAct.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			// 
			// ShowInitAction
			// 
			this.ShowInitAction.BeginInit();
			this.ShowInitAction.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 146D, 326D);
			this.ShowInitAction.IsOnlyInput = true;
			this.ShowInitAction.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ShowInitAction.Name = "ShowInitAction";
			this.ShowInitAction.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ShowInitAction.TagName = "ShowInitAction";
			this.ShowInitAction.Value = false;
			this.ShowInitAction.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ShowInitActionValueChanged);
			this.ShowInitAction.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ShowInitAct,
			this.ShowInitAction});
			this.SymbolSize = new System.Drawing.Size(600, 400);

		}
		private NxtControl.GuiFramework.DrawnButton ShowInitAct;
		private System.HMI.Symbols.Base.Execute<bool> ShowInitAction;
		#endregion
	}
}
