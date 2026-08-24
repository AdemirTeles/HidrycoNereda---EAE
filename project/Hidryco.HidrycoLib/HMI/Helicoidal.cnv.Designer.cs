/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 15:17
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Graphics
{
	/// <summary>
	/// Summary description for Helicoidal.
	/// </summary>
	partial class Helicoidal
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle5 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle6 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle7 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle8 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle9 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle10 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle11 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle12 = new NxtControl.GuiFramework.Rectangle();
			this.rectangle13 = new NxtControl.GuiFramework.Rectangle();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(56D)), ((float)(8D)), ((float)(56D)));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(64D)), ((float)(72D)), ((float)(32D)));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(184D)), ((float)(69D)), ((float)(6D)), ((float)(22D)));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(56D)), ((float)(8D)), ((float)(48D)));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// rectangle5
			// 
			this.rectangle5.Bounds = new NxtControl.Drawing.RectF(((float)(198D)), ((float)(64D)), ((float)(72D)), ((float)(32D)));
			this.rectangle5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle5.Name = "rectangle5";
			// 
			// rectangle6
			// 
			this.rectangle6.Bounds = new NxtControl.Drawing.RectF(((float)(88D)), ((float)(112D)), ((float)(224D)), ((float)(8D)));
			this.rectangle6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle6.Name = "rectangle6";
			// 
			// rectangle7
			// 
			this.rectangle7.Bounds = new NxtControl.Drawing.RectF(((float)(270D)), ((float)(56D)), ((float)(8D)), ((float)(56D)));
			this.rectangle7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle7.Name = "rectangle7";
			// 
			// rectangle8
			// 
			this.rectangle8.Bounds = new NxtControl.Drawing.RectF(((float)(278D)), ((float)(64D)), ((float)(10D)), ((float)(32D)));
			this.rectangle8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle8.Name = "rectangle8";
			// 
			// rectangle9
			// 
			this.rectangle9.Bounds = new NxtControl.Drawing.RectF(((float)(288D)), ((float)(56D)), ((float)(8D)), ((float)(48D)));
			this.rectangle9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle9.Name = "rectangle9";
			// 
			// rectangle10
			// 
			this.rectangle10.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(56D)), ((float)(4D)), ((float)(48D)));
			this.rectangle10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle10.Name = "rectangle10";
			// 
			// rectangle11
			// 
			this.rectangle11.Bounds = new NxtControl.Drawing.RectF(((float)(145D)), ((float)(48D)), ((float)(16D)), ((float)(16D)));
			this.rectangle11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle11.Name = "rectangle11";
			// 
			// rectangle12
			// 
			this.rectangle12.Bounds = new NxtControl.Drawing.RectF(((float)(137D)), ((float)(44D)), ((float)(32D)), ((float)(4D)));
			this.rectangle12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle12.Name = "rectangle12";
			// 
			// rectangle13
			// 
			this.rectangle13.Bounds = new NxtControl.Drawing.RectF(((float)(137D)), ((float)(40D)), ((float)(32D)), ((float)(4D)));
			this.rectangle13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle13.Name = "rectangle13";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.rectangle2,
			this.rectangle3,
			this.rectangle4,
			this.rectangle5,
			this.rectangle6,
			this.rectangle7,
			this.rectangle8,
			this.rectangle9,
			this.rectangle10,
			this.rectangle11,
			this.rectangle12,
			this.rectangle13});
			this.group1.EndInit();
			// 
			// Helicoidal
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.SymbolSize = new System.Drawing.Size(352, 216);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle rectangle5;
		private NxtControl.GuiFramework.Rectangle rectangle6;
		private NxtControl.GuiFramework.Rectangle rectangle7;
		private NxtControl.GuiFramework.Rectangle rectangle8;
		private NxtControl.GuiFramework.Rectangle rectangle9;
		private NxtControl.GuiFramework.Rectangle rectangle10;
		private NxtControl.GuiFramework.Rectangle rectangle11;
		private NxtControl.GuiFramework.Rectangle rectangle12;
		private NxtControl.GuiFramework.Rectangle rectangle13;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
