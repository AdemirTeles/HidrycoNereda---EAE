/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 8/19/2026
 * Time: 2:50 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for Canvas2.
	/// </summary>
	partial class Canvas2
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.REACTOR01_1 = new SE.Nereda.Symbols.NeredaReactor.sPhases();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.AERATION = new SE.Nereda.Symbols.NeredaCAeration.sBlowers();
			this.REACTOR01_2 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.REACTOR01 = new SE.Nereda.Symbols.NeredaReactor.sSettingsBtn();
			// 
			// REACTOR01_1
			// 
			this.REACTOR01_1.BeginInit();
			this.REACTOR01_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.REACTOR01_1.Name = "REACTOR01_1";
			this.REACTOR01_1.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01_1.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01_1.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 480D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "7A79C015B9ADE3EB";
			this.Mode.EndInit();
			// 
			// AERATION
			// 
			this.AERATION.BeginInit();
			this.AERATION.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 848D, 160D);
			this.AERATION.Name = "AERATION";
			this.AERATION.SecurityToken = ((uint)(4294967295u));
			this.AERATION.TagName = "6307B68BAFBA5753";
			this.AERATION.EndInit();
			// 
			// REACTOR01_2
			// 
			this.REACTOR01_2.BeginInit();
			this.REACTOR01_2._iLT001 = "NVPP 001 lt 004";
			this.REACTOR01_2._iREACTOR = "Reactor 1";
			this.REACTOR01_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 248D);
			this.REACTOR01_2.Name = "REACTOR01_2";
			this.REACTOR01_2.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01_2.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01_2.EndInit();
			// 
			// REACTOR01
			// 
			this.REACTOR01.BeginInit();
			this.REACTOR01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 480D, 64D);
			this.REACTOR01.Name = "REACTOR01";
			this.REACTOR01.SecurityToken = ((uint)(4294967295u));
			this.REACTOR01.TagName = "D32FABF3E7C17DE2";
			this.REACTOR01.EndInit();
			// 
			// Canvas2
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.REACTOR01_1,
			this.Mode,
			this.AERATION,
			this.REACTOR01_2,
			this.REACTOR01});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.NeredaReactor.sSettingsBtn REACTOR01;
		private SE.Nereda.Symbols.NeredaReactor.sPhases REACTOR01_1;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.NeredaCAeration.sBlowers AERATION;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 REACTOR01_2;
		#endregion
	}
}
