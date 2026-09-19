using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.PID
{
	/// <summary>
	/// Summary description for sBarPvSpOpVert.
	/// </summary>
	partial class sBarPvSpOpVert
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.sBarPvSpOpVert1 = new SE.App2CommonProcess.Symbols.PIDBase.sBarPvSpOpVert();
			// 
			// sBarPvSpOpVert1
			// 
			this.sBarPvSpOpVert1.BeginInit();
			this.sBarPvSpOpVert1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 40D, 35D);
			this.sBarPvSpOpVert1.DisplayType = SE.App2CommonProcess.SupportClasses.PidDisplayType.PvSpOp;
			this.sBarPvSpOpVert1.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.sBarPvSpOpVert1.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.sBarPvSpOpVert1.MyTagDisplayName = null;
			this.sBarPvSpOpVert1.Name = "sBarPvSpOpVert1";

			this.sBarPvSpOpVert1.SecurityToken = ((uint)(4294967295u));
			this.sBarPvSpOpVert1.TagName = "PIDBaseExt.PIDBase";
			this.sBarPvSpOpVert1.EndInit();
			// 
			// sBarPvSpOpVert
			// 
			this.Name = "sBarPvSpOpVert";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.sBarPvSpOpVert1});
			this.SymbolSize = new System.Drawing.Size(200, 232);
			this.SecurityOwnerChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecurityOwnerChanged(this.SBarPvSpOpVertSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecurityParameterChanged(this.SBarPvSpOpVertSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnSecuritySetpointChanged(this.SBarPvSpOpVertSecuritySetpointChanged);

		}
		private SE.App2CommonProcess.Symbols.PIDBase.sBarPvSpOpVert sBarPvSpOpVert1;
		#endregion
	}
}



