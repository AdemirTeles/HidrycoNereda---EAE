/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/6/2026
 * Time: 10:51 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Phase
{
	/// <summary>
	/// Summary description for fpOpCdt.
	/// </summary>
	partial class fpOpCdt
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BackGround = new NxtControl.GuiFramework.RoundedRectangle();
			this.PhaseName = new NxtControl.GuiFramework.RoundedRectangle();
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
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			this.freeText14 = new NxtControl.GuiFramework.FreeText();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.freeText16 = new NxtControl.GuiFramework.FreeText();
			this.ellipse9 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse10 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse11 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse12 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse13 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse14 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse15 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse16 = new NxtControl.GuiFramework.Ellipse();
			this.MemoOC = new SE.Nereda.Symbols.MemoOC_D.sMOCBtn();
			// 
			// BackGround
			// 
			this.BackGround.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(384D)), ((float)(432D)));
			this.BackGround.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.BackGround.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.BackGround.Name = "BackGround";
			this.BackGround.Radius = 10D;
			// 
			// PhaseName
			// 
			this.PhaseName.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(368D)), ((float)(24D)));
			this.PhaseName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.PhaseName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.PhaseName.Name = "PhaseName";
			this.PhaseName.Text = "Phase";
			this.PhaseName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 56D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Operating Condition 1";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 80D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Operating Condition 2";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 104D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Operating Condition 3";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 128D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Operating Condition 4";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(16D, 152D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Operating Condition 5";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(16D, 176D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Operating Condition 6";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(16D, 200D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Operating Condition 7";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(16D, 224D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Operating Condition 8";
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
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(16D, 248D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Operating Condition 9";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText10.Location = new NxtControl.Drawing.PointF(16D, 272D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Operating Condition 10";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText11.Location = new NxtControl.Drawing.PointF(16D, 296D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Operating Condition 11";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText12.Location = new NxtControl.Drawing.PointF(16D, 320D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "Operating Condition 12";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(16D, 344D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Operating Condition 13";
			// 
			// freeText14
			// 
			this.freeText14.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText14.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText14.Location = new NxtControl.Drawing.PointF(16D, 368D);
			this.freeText14.Name = "freeText14";
			this.freeText14.Text = "Operating Condition 14";
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText15.Location = new NxtControl.Drawing.PointF(16D, 392D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Operating Condition 15";
			// 
			// freeText16
			// 
			this.freeText16.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText16.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText16.Location = new NxtControl.Drawing.PointF(16D, 416D);
			this.freeText16.Name = "freeText16";
			this.freeText16.Text = "Operating Condition 16";
			// 
			// ellipse9
			// 
			this.ellipse9.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(249D)), ((float)(14D)), ((float)(14D)));
			this.ellipse9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse9.Name = "ellipse9";
			// 
			// ellipse10
			// 
			this.ellipse10.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(273D)), ((float)(14D)), ((float)(14D)));
			this.ellipse10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse10.Name = "ellipse10";
			// 
			// ellipse11
			// 
			this.ellipse11.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(297D)), ((float)(14D)), ((float)(14D)));
			this.ellipse11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse11.Name = "ellipse11";
			// 
			// ellipse12
			// 
			this.ellipse12.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(321D)), ((float)(14D)), ((float)(14D)));
			this.ellipse12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse12.Name = "ellipse12";
			// 
			// ellipse13
			// 
			this.ellipse13.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(345D)), ((float)(14D)), ((float)(14D)));
			this.ellipse13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse13.Name = "ellipse13";
			// 
			// ellipse14
			// 
			this.ellipse14.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(369D)), ((float)(14D)), ((float)(14D)));
			this.ellipse14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse14.Name = "ellipse14";
			// 
			// ellipse15
			// 
			this.ellipse15.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(393D)), ((float)(14D)), ((float)(14D)));
			this.ellipse15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse15.Name = "ellipse15";
			// 
			// ellipse16
			// 
			this.ellipse16.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(417D)), ((float)(14D)), ((float)(14D)));
			this.ellipse16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), new NxtControl.Drawing.GradientFill(NxtControl.Drawing.GradientFillOrientation.Center, NxtControl.Drawing.GradientFillBrightness.Light));
			this.ellipse16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse16.Name = "ellipse16";
			// 
			// MemoOC
			// 
			this.MemoOC.BeginInit();
			this.MemoOC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.125D, 0D, 0D, 1D, 16D, 16D);
			this.MemoOC.Name = "MemoOC";
			this.MemoOC.SecurityToken = ((uint)(4294967295u));
			this.MemoOC.TagName = "MemoOC";
			this.MemoOC.EndInit();
			// 
			// fpOpCdt
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(448D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.BackGround,
			this.PhaseName,
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
			this.ellipse8,
			this.freeText9,
			this.freeText10,
			this.freeText11,
			this.freeText12,
			this.freeText13,
			this.freeText14,
			this.freeText15,
			this.freeText16,
			this.ellipse9,
			this.ellipse10,
			this.ellipse11,
			this.ellipse12,
			this.ellipse13,
			this.ellipse14,
			this.ellipse15,
			this.ellipse16,
			this.MemoOC});
			this.Size = new System.Drawing.Size(400, 448);
			this.Title = "Operating conditions";

		}
		private NxtControl.GuiFramework.RoundedRectangle BackGround;
		private NxtControl.GuiFramework.RoundedRectangle PhaseName;
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
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.FreeText freeText13;
		private NxtControl.GuiFramework.FreeText freeText14;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.FreeText freeText16;
		private NxtControl.GuiFramework.Ellipse ellipse9;
		private NxtControl.GuiFramework.Ellipse ellipse10;
		private NxtControl.GuiFramework.Ellipse ellipse11;
		private NxtControl.GuiFramework.Ellipse ellipse12;
		private NxtControl.GuiFramework.Ellipse ellipse13;
		private NxtControl.GuiFramework.Ellipse ellipse14;
		private NxtControl.GuiFramework.Ellipse ellipse15;
		private NxtControl.GuiFramework.Ellipse ellipse16;
		private SE.Nereda.Symbols.MemoOC_D.sMOCBtn MemoOC;
		#endregion
	}
}
