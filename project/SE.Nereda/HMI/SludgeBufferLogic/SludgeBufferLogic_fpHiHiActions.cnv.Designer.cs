/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/4/2026
 * Time: 4:06 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.SludgeBufferLogic
{
	/// <summary>
	/// Summary description for fpHiHiActions.
	/// </summary>
	partial class fpHiHiActions
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 8D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Sludge Buffer High-High Level – Interlocked Equipment :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 32D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "- Influent feed pump 46 2 AP ifp 95 001";
			// 
			// fpHiHiActions
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(392D)), ((float)(56D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1,
			this.freeText2});
			this.Size = new System.Drawing.Size(392, 56);
			this.Title = "Interlocked Equipment";

		}
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		#endregion
	}
}
