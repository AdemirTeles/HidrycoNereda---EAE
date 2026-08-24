/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/6/2026
 * Time: 5:04 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.AnalogInput
{
	/// <summary>
	/// Summary description for fpColor.
	/// </summary>
	partial class fpColor
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.Color1 = new NxtControl.GuiFramework.Rectangle();
			this.Color2 = new NxtControl.GuiFramework.Rectangle();
			this.Color3 = new NxtControl.GuiFramework.Rectangle();
			this.Color4 = new NxtControl.GuiFramework.Rectangle();
			this.Color5 = new NxtControl.GuiFramework.Rectangle();
			this.Color6 = new NxtControl.GuiFramework.Rectangle();
			this.Color7 = new NxtControl.GuiFramework.Rectangle();
			this.Color8 = new NxtControl.GuiFramework.Rectangle();
			this.Color9 = new NxtControl.GuiFramework.Rectangle();
			this.Color10 = new NxtControl.GuiFramework.Rectangle();
			this.Color11 = new NxtControl.GuiFramework.Rectangle();
			this.Color12 = new NxtControl.GuiFramework.Rectangle();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(16D)), ((float)(136D)), ((float)(104D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 10D;
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 0D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Colors :";
			// 
			// Color1
			// 
			this.Color1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(24D)), ((float)(24D)), ((float)(24D)));
			this.Color1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color1.Name = "Color1";
			this.Color1.Click += new System.EventHandler(this.Color1Click);
			// 
			// Color2
			// 
			this.Color2.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(24D)), ((float)(24D)), ((float)(24D)));
			this.Color2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Color2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color2.Name = "Color2";
			this.Color2.Click += new System.EventHandler(this.Color2Click);
			// 
			// Color3
			// 
			this.Color3.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(24D)), ((float)(24D)), ((float)(24D)));
			this.Color3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(178)), ((byte)(14)), ((byte)(18))));
			this.Color3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color3.Name = "Color3";
			this.Color3.Click += new System.EventHandler(this.Color3Click);
			// 
			// Color4
			// 
			this.Color4.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(24D)), ((float)(24D)), ((float)(24D)));
			this.Color4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.Color4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color4.Name = "Color4";
			this.Color4.Click += new System.EventHandler(this.Color4Click);
			// 
			// Color5
			// 
			this.Color5.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(56D)), ((float)(24D)), ((float)(24D)));
			this.Color5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(254)), ((byte)(186)), ((byte)(10))));
			this.Color5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color5.Name = "Color5";
			this.Color5.Click += new System.EventHandler(this.Color5Click);
			// 
			// Color6
			// 
			this.Color6.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(56D)), ((float)(24D)), ((float)(24D)));
			this.Color6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0))));
			this.Color6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color6.Name = "Color6";
			this.Color6.Click += new System.EventHandler(this.Color6Click);
			// 
			// Color7
			// 
			this.Color7.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(56D)), ((float)(24D)), ((float)(24D)));
			this.Color7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(214)), ((byte)(66))));
			this.Color7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color7.Name = "Color7";
			this.Color7.Click += new System.EventHandler(this.Color7Click);
			// 
			// Color8
			// 
			this.Color8.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(56D)), ((float)(24D)), ((float)(24D)));
			this.Color8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(61)), ((byte)(205)), ((byte)(88))));
			this.Color8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color8.Name = "Color8";
			this.Color8.Click += new System.EventHandler(this.Color8Click);
			// 
			// Color9
			// 
			this.Color9.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(88D)), ((float)(24D)), ((float)(24D)));
			this.Color9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(2)), ((byte)(178)), ((byte)(238))));
			this.Color9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color9.Name = "Color9";
			this.Color9.Click += new System.EventHandler(this.Color9Click);
			// 
			// Color10
			// 
			this.Color10.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(88D)), ((float)(24D)), ((float)(24D)));
			this.Color10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))));
			this.Color10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color10.Name = "Color10";
			this.Color10.Click += new System.EventHandler(this.Color10Click);
			// 
			// Color11
			// 
			this.Color11.Bounds = new NxtControl.Drawing.RectF(((float)(80D)), ((float)(88D)), ((float)(24D)), ((float)(24D)));
			this.Color11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(47)), ((byte)(54)), ((byte)(153))));
			this.Color11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color11.Name = "Color11";
			this.Color11.Click += new System.EventHandler(this.Color11Click);
			// 
			// Color12
			// 
			this.Color12.Bounds = new NxtControl.Drawing.RectF(((float)(112D)), ((float)(88D)), ((float)(24D)), ((float)(24D)));
			this.Color12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(111)), ((byte)(49)), ((byte)(152))));
			this.Color12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Color12.Name = "Color12";
			this.Color12.Click += new System.EventHandler(this.Color12Click);
			// 
			// fpColor
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(152D)), ((float)(128D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.freeText1,
			this.Color1,
			this.Color2,
			this.Color3,
			this.Color4,
			this.Color5,
			this.Color6,
			this.Color7,
			this.Color8,
			this.Color9,
			this.Color10,
			this.Color11,
			this.Color12});
			this.Size = new System.Drawing.Size(152, 128);
			this.Title = "Colors";

		}
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.Rectangle Color1;
		private NxtControl.GuiFramework.Rectangle Color2;
		private NxtControl.GuiFramework.Rectangle Color3;
		private NxtControl.GuiFramework.Rectangle Color4;
		private NxtControl.GuiFramework.Rectangle Color5;
		private NxtControl.GuiFramework.Rectangle Color6;
		private NxtControl.GuiFramework.Rectangle Color7;
		private NxtControl.GuiFramework.Rectangle Color8;
		private NxtControl.GuiFramework.Rectangle Color9;
		private NxtControl.GuiFramework.Rectangle Color10;
		private NxtControl.GuiFramework.Rectangle Color11;
		private NxtControl.GuiFramework.Rectangle Color12;
		#endregion
	}
}
