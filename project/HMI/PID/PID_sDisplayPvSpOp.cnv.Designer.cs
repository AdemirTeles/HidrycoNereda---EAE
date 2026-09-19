using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.PID
{
	/// <summary>
	/// Summary description for sDisplayPvSpOp.
	/// </summary>
	partial class sDisplayPvSpOp
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sDisplayPvSpOp1 = new SE.App2CommonProcess.Symbols.PIDBase.sDisplayPvSpOp();
			// 
			// sDisplayPvSpOp1
			// 
			this.sDisplayPvSpOp1.BeginInit();
			this.sDisplayPvSpOp1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 51D, 55D);
			this.sDisplayPvSpOp1.DisplayType = SE.App2CommonProcess.SupportClasses.PidDisplayType.PvSpOp;
			this.sDisplayPvSpOp1.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.sDisplayPvSpOp1.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sDisplayPvSpOp1.MyTagDisplayName = null;
			this.sDisplayPvSpOp1.Name = "sDisplayPvSpOp1";

			this.sDisplayPvSpOp1.SecurityToken = ((uint)(4294967295u));
			this.sDisplayPvSpOp1.TagName = "PIDBaseExt.PIDBase";
			this.sDisplayPvSpOp1.EndInit();
			// 
			// sDisplayPvSpOp
			// 
			this.Name = "sDisplayPvSpOp";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sDisplayPvSpOp1});
			this.SymbolSize = new System.Drawing.Size(200, 200);
			this.SecurityOwnerChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecurityOwnerChanged(this.SDisplayPvSpOpSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecurityParameterChanged(this.SDisplayPvSpOpSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecuritySetpointChanged(this.SDisplayPvSpOpSecuritySetpointChanged);

		}
		private SE.App2CommonProcess.Symbols.PIDBase.sDisplayPvSpOp sDisplayPvSpOp1;
		#endregion
	}
}



