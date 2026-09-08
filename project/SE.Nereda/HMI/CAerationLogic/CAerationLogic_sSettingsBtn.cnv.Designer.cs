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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sSettingsBtn));
			this.OpenFp = new NxtControl.GuiFramework.RoundedRectangle();
			// 
			// OpenFp
			// 
			this.OpenFp.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(40D)), ((float)(40D)));
			this.OpenFp.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.OpenFp.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.OpenFp.ImageBytes = resources.GetString("OpenFp.ImageBytes");
			this.OpenFp.Name = "OpenFp";
			this.OpenFp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSettingsS", NxtControl.GuiFramework.MouseButtonType.Click));
			this.OpenFp.Radius = 10D;
			// 
			// sSettingsBtn
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.OpenFp});
			this.SymbolSize = new System.Drawing.Size(96, 96);

		}
		private NxtControl.GuiFramework.RoundedRectangle OpenFp;
		#endregion
	}
}
