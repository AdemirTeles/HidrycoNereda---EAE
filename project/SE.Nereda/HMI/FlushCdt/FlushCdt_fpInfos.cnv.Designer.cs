/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 4:02 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FlushCdt
{
	/// <summary>
	/// Summary description for fpInfos.
	/// </summary>
	partial class fpInfos
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BackGround = new NxtControl.GuiFramework.RoundedRectangle();
			this.FlushCdtName = new NxtControl.GuiFramework.RoundedRectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse4 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse5 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse6 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse7 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse8 = new NxtControl.GuiFramework.Ellipse();
			// 
			// BackGround
			// 
			this.BackGround.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(384D)), ((float)(248D)));
			this.BackGround.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.BackGround.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.BackGround.Name = "BackGround";
			this.BackGround.Radius = 10D;
			// 
			// FlushCdtName
			// 
			this.FlushCdtName.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(368D)), ((float)(24D)));
			this.FlushCdtName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.FlushCdtName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.FlushCdtName.Name = "FlushCdtName";
			this.FlushCdtName.Text = "Flushing Conditions";
			this.FlushCdtName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 56D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Condition 1";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 80D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Condition 2";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 104D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Condition 3";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 128D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Condition 4";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 152D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Condition 5";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 176D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Condition 6";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 200D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Condition 7";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 224D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Condition 8";
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(57D)), ((float)(14D)), ((float)(14D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(81D)), ((float)(14D)), ((float)(14D)));
			this.ellipse2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// ellipse3
			// 
			this.ellipse3.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(105D)), ((float)(14D)), ((float)(14D)));
			this.ellipse3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse3.Name = "ellipse3";
			// 
			// ellipse4
			// 
			this.ellipse4.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(129D)), ((float)(14D)), ((float)(14D)));
			this.ellipse4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse4.Name = "ellipse4";
			// 
			// ellipse5
			// 
			this.ellipse5.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(153D)), ((float)(14D)), ((float)(14D)));
			this.ellipse5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse5.Name = "ellipse5";
			// 
			// ellipse6
			// 
			this.ellipse6.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(177D)), ((float)(14D)), ((float)(14D)));
			this.ellipse6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse6.Name = "ellipse6";
			// 
			// ellipse7
			// 
			this.ellipse7.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(201D)), ((float)(14D)), ((float)(14D)));
			this.ellipse7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse7.Name = "ellipse7";
			// 
			// ellipse8
			// 
			this.ellipse8.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(225D)), ((float)(14D)), ((float)(14D)));
			this.ellipse8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse8.Name = "ellipse8";
			// 
			// fpInfos
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(264D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.BackGround,
			this.FlushCdtName,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.freeText8,
			this.ellipse1,
			this.ellipse2,
			this.ellipse3,
			this.ellipse4,
			this.ellipse5,
			this.ellipse6,
			this.ellipse7,
			this.ellipse8});
			this.Size = new System.Drawing.Size(400, 264);
			this.Title = "Flushing Conditions";

		}
		private NxtControl.GuiFramework.RoundedRectangle BackGround;
		private NxtControl.GuiFramework.RoundedRectangle FlushCdtName;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.Ellipse ellipse4;
		private NxtControl.GuiFramework.Ellipse ellipse5;
		private NxtControl.GuiFramework.Ellipse ellipse6;
		private NxtControl.GuiFramework.Ellipse ellipse7;
		private NxtControl.GuiFramework.Ellipse ellipse8;
		#endregion
	}
}
