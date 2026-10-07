/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 3:50 PM
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
	/// Summary description for OVER_VIEW.
	/// </summary>
	partial class OVER_VIEW
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.sDefault1 = new SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault();
			this.Reactor1 = new SE.Nereda.Symbols.NeredaReactor.sReactor3();
			this.Reactor2 = new SE.Nereda.Symbols.NeredaReactor.sReactor3();
			// 
			// HeartBeat
			// 
			this.HeartBeat.BeginInit();
			this.HeartBeat.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.HeartBeat.Name = "HeartBeat";
			this.HeartBeat.SecurityToken = ((uint)(4294967295u));
			this.HeartBeat.TagName = "32B44D45F962192F";
			this.HeartBeat.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "7A79C015B9ADE3EB";
			this.Mode.EndInit();
			// 
			// OpenWebPage
			// 
			this.OpenWebPage.BeginInit();
			this.OpenWebPage.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 840D, 8D);
			this.OpenWebPage.Name = "OpenWebPage";
			this.OpenWebPage.SecurityToken = ((uint)(4294967295u));
			this.OpenWebPage.TagName = "61745BDDB91DBEF5";
			this.OpenWebPage.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.50230414746543772D, 0D, 0D, 0.41988950276243092D, 1104D, 40D);
			this.sDefault1.HeaderText = "";
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "F903885E680FD8F5";
			this.sDefault1.EndInit();
			// 
			// Reactor1
			// 
			this.Reactor1.BeginInit();
			this.Reactor1._iREACTOR = "Reactor 1";
			this.Reactor1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48571428571428571D, 0D, 0D, 0.48571428571428571D, 96D, 136D);
			this.Reactor1.Name = "Reactor1";
			this.Reactor1.SecurityToken = ((uint)(4294967295u));
			this.Reactor1.TagName = "D41247DF3E1D30DC";
			this.Reactor1.EndInit();
			// 
			// Reactor2
			// 
			this.Reactor2.BeginInit();
			this.Reactor2._iREACTOR = "Reactor 1";
			this.Reactor2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48571428571428571D, 0D, 0D, 0.48571428571428571D, 304D, 144D);
			this.Reactor2.Name = "Reactor2";
			this.Reactor2.SecurityToken = ((uint)(4294967295u));
			this.Reactor2.TagName = "1D81A826384C2197";
			this.Reactor2.EndInit();
			// 
			// OVER_VIEW
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.HeartBeat,
			this.Mode,
			this.OpenWebPage,
			this.sDefault1,
			this.Reactor1,
			this.Reactor2});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.IoTMx.Symbols.TM262L01MDESE8T.sDefault sDefault1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor3 Reactor1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor3 Reactor2;
		#endregion
	}
}
