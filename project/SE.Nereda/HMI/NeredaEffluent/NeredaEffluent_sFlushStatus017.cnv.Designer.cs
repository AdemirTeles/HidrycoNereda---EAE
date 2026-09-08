/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/24/2026
 * Time: 11:58 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaEffluent
{
	/// <summary>
	/// Summary description for sFlushStatus017.
	/// </summary>
	partial class sFlushStatus017
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.sInfos1 = new SE.Nereda.Symbols.FlushSludgeBuffer.sInfos();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 32D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "NVPP 001 a-- 017";
			// 
			// sInfos1
			// 
			this.sInfos1.BeginInit();
			this.sInfos1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 16D);
			this.sInfos1.Name = "sInfos1";
			this.sInfos1.SecurityToken = ((uint)(4294967295u));
			this.sInfos1.TagName = "EffluentLogic.FlushSludgeBuffer";
			this.sInfos1.EndInit();
			// 
			// sFlushStatus017
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.freeText1,
			this.sInfos1});
			this.SymbolSize = new System.Drawing.Size(200, 200);

		}
		private NxtControl.GuiFramework.FreeText freeText1;
		private SE.Nereda.Symbols.FlushSludgeBuffer.sInfos sInfos1;
		#endregion
	}
}
