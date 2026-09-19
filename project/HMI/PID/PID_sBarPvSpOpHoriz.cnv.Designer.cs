using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.PID
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sBarPvSpOpHoriz
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sBarPvSpOpHoriz1 = new SE.App2CommonProcess.Symbols.PIDBase.sBarPvSpOpHoriz();
			// 
			// sBarPvSpOpHoriz1
			// 
			this.sBarPvSpOpHoriz1.BeginInit();
			this.sBarPvSpOpHoriz1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 58D, 35D);
			this.sBarPvSpOpHoriz1.DisplayType = SE.App2CommonProcess.SupportClasses.PidDisplayType.PvSpOp;
			this.sBarPvSpOpHoriz1.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.sBarPvSpOpHoriz1.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sBarPvSpOpHoriz1.MyTagDisplayName = null;
			this.sBarPvSpOpHoriz1.Name = "sBarPvSpOpHoriz1";

			this.sBarPvSpOpHoriz1.SecurityToken = ((uint)(4294967295u));
			this.sBarPvSpOpHoriz1.TagName = "PIDBaseExt.PIDBase";
			this.sBarPvSpOpHoriz1.EndInit();
			// 
			// sBarPvSpOpHoriz
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sBarPvSpOpHoriz1});
			this.SymbolSize = new System.Drawing.Size(256, 136);
			this.SecurityOwnerChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecurityOwnerChanged(this.SBarPvSpOpHorizSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecurityParameterChanged(this.SBarPvSpOpHorizSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecuritySetpointChanged(this.SBarPvSpOpHorizSecuritySetpointChanged);

		}
		private SE.App2CommonProcess.Symbols.PIDBase.sBarPvSpOpHoriz sBarPvSpOpHoriz1;
		#endregion
	}
}



