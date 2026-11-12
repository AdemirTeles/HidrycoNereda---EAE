/*
 * Created by EcoStruxure Automation Expert.
 * User: SESA685388
 * Date: 10/24/2023
 * Time: 10:47 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CAerationLogic
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sSettingsBtn
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.OpenFp = new NxtControl.GuiFramework.DrawnButton();
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(120D)), ((float)(40D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.OpenFp.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.OpenFp.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSettingsS", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.OpenFp.Radius = 4D;
			this.OpenFp.Text = "Ajustes da aeração";
			this.OpenFp.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.OpenFp.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.OpenFp.Use3DEffect = false;
			// 
			// sSettingsBtn
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.OpenFp});
			this.SymbolSize = new System.Drawing.Size(232, 200);

		}
		private NxtControl.GuiFramework.DrawnButton OpenFp;
		#endregion
	}
}
