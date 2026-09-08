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

namespace SE.Nereda.Faceplates.EffluentCdt
{
	/// <summary>
	/// Summary description for fpInfos.
	/// </summary>
	partial class fpStopCdts
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.BackGround = new NxtControl.GuiFramework.RoundedRectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse3 = new NxtControl.GuiFramework.Ellipse();
			this.ellipse4 = new NxtControl.GuiFramework.Ellipse();
			this.StopCdtName = new NxtControl.GuiFramework.RoundedRectangle();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			// 
			// BackGround
			// 
			this.BackGround.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(384D)), ((float)(144D)));
			this.BackGround.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.BackGround.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.BackGround.Name = "BackGround";
			this.BackGround.Radius = 10D;
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
			// StopCdtName
			// 
			this.StopCdtName.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(16D)), ((float)(280D)), ((float)(24D)));
			this.StopCdtName.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.StopCdtName.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
			this.StopCdtName.Name = "StopCdtName";
			this.StopCdtName.Text = "Effluent Start Conditions";
			this.StopCdtName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(304D)), ((float)(16D)), ((float)(80D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpStartCdts", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "Start Cdts";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// fpStopCdts
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(160D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.BackGround,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.ellipse1,
			this.ellipse2,
			this.ellipse3,
			this.ellipse4,
			this.StopCdtName,
			this.drawnButton1});
			this.Size = new System.Drawing.Size(400, 160);
			this.Title = "Stop Conditions";

		}
		private NxtControl.GuiFramework.RoundedRectangle BackGround;
		private NxtControl.GuiFramework.RoundedRectangle StopCdtName;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private NxtControl.GuiFramework.Ellipse ellipse3;
		private NxtControl.GuiFramework.Ellipse ellipse4;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		#endregion
	}
}
