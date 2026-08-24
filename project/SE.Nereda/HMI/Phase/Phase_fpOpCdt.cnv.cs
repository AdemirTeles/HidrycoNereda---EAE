/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/6/2026
 * Time: 10:51 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.Phase
{
	/// <summary>
	/// Description of fpOpCdt.
	/// </summary>
	public partial class fpOpCdt : NxtControl.GuiFramework.HMIFaceplate
	{
		// Internal bool variables
		bool bit1;
		bool bit2;
		bool bit3;
		bool bit4;
		bool bit5;
		bool bit6;
		bool bit7;
		bool bit8;
		bool bit9;
		bool bit10;
		bool bit11;
		bool bit12;
		bool bit13;
		bool bit14;
		bool bit15;
		bool bit16;
		
		// ===============================
		// Dynamic items display management
		// ===============================
		
		// Initial positions
		float freeTextXPosition = 16;
		float ellipseXPosition = 368;
		
		float freeTextYPosition = 56;
		float ellipseYPosition = 57;
		
		float yStep = 24;
		
		// Count visible items
		int visibleItemCount = 0;
		public fpOpCdt()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_ITEMS_Fired += REQ_ITEMS_Fired_EventHandler;
			this.REQ_PHASE_NAME_Fired += REQ_PHASE_NAME_Fired_EventHandler;
			this.Size = new System.Drawing.Size(400, 80);
		}

		void REQ_ITEMS_Fired_EventHandler(object sender, SE.Nereda.Symbols.Phase.REQ_ITEMSEventArgs e)
		{
			// TODO: Implement REQ_ITEMS_Fired_EventHandler
			// ===============================
			// Initial positions
			// ===============================
			freeTextXPosition = 16;
			ellipseXPosition = 368;
			
			freeTextYPosition = 56;
			ellipseYPosition = 57;
			
			yStep = 24;
			
			// Count visible items
			visibleItemCount = 0;
			
			
			// ===============================
			// Assign item texts
			// ===============================
			freeText1.Text = e.item1;
			freeText2.Text = e.item2;
			freeText3.Text = e.item3;
			freeText4.Text = e.item4;
			freeText5.Text = e.item5;
			freeText6.Text = e.item6;
			freeText7.Text = e.item7;
			freeText8.Text = e.item8;
			freeText9.Text = e.item9;
			freeText10.Text = e.item10;
			freeText11.Text = e.item11;
			freeText12.Text = e.item12;
			freeText13.Text = e.item13;
			freeText14.Text = e.item14;
			freeText15.Text = e.item15;
			freeText16.Text = e.item16;
			
			
			// ===============================
			// Convert values to binary text with 4 characters
			// ===============================
			string itemsValues1 = e.itemsValues1.ToString().PadLeft(4, '0');
			string itemsValues2 = e.itemsValues2.ToString().PadLeft(4, '0');
			string itemsValues3 = e.itemsValues3.ToString().PadLeft(4, '0');
			string itemsValues4 = e.itemsValues4.ToString().PadLeft(4, '0');
			
			
			// ===============================
			// Decode itemsValues1
			// ===============================
			bit1 = itemsValues1[3] == '1';
			bit2 = itemsValues1[2] == '1';
			bit3 = itemsValues1[1] == '1';
			bit4 = itemsValues1[0] == '1';
			
			
			// ===============================
			// Decode itemsValues2
			// ===============================
			bit5 = itemsValues2[3] == '1';
			bit6 = itemsValues2[2] == '1';
			bit7 = itemsValues2[1] == '1';
			bit8 = itemsValues2[0] == '1';
			
			
			// ===============================
			// Decode itemsValues3
			// ===============================
			bit9 = itemsValues3[3] == '1';
			bit10 = itemsValues3[2] == '1';
			bit11 = itemsValues3[1] == '1';
			bit12 = itemsValues3[0] == '1';
			
			
			// ===============================
			// Decode itemsValues4
			// ===============================
			bit13 = itemsValues4[3] == '1';
			bit14 = itemsValues4[2] == '1';
			bit15 = itemsValues4[1] == '1';
			bit16 = itemsValues4[0] == '1';
			
			
			// ===============================
			// Update ellipse colors
			// ===============================
			ellipse1.BrushColor = bit1 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse2.BrushColor = bit2 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse3.BrushColor = bit3 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse4.BrushColor = bit4 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			
			ellipse5.BrushColor = bit5 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse6.BrushColor = bit6 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse7.BrushColor = bit7 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse8.BrushColor = bit8 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			
			ellipse9.BrushColor = bit9 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse10.BrushColor = bit10 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse11.BrushColor = bit11 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse12.BrushColor = bit12 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			
			ellipse13.BrushColor = bit13 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse14.BrushColor = bit14 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse15.BrushColor = bit15 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse16.BrushColor = bit16 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			
			
			// ===============================
			// Dynamic items display management
			// ===============================
			
			// ===============================
			// Item 1
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item1))
			{
			    freeText1.Text = e.item1;
			    freeText1.Visible = true;
			    ellipse1.Visible = true;
			
			    freeText1.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse1.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText1.Text = "";
			    freeText1.Visible = false;
			    ellipse1.Visible = false;
			}
			
			
			// ===============================
			// Item 2
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item2))
			{
			    freeText2.Text = e.item2;
			    freeText2.Visible = true;
			    ellipse2.Visible = true;
			
			    freeText2.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse2.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText2.Text = "";
			    freeText2.Visible = false;
			    ellipse2.Visible = false;
			}
			
			
			// ===============================
			// Item 3
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item3))
			{
			    freeText3.Text = e.item3;
			    freeText3.Visible = true;
			    ellipse3.Visible = true;
			
			    freeText3.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse3.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText3.Text = "";
			    freeText3.Visible = false;
			    ellipse3.Visible = false;
			}
			
			
			// ===============================
			// Item 4
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item4))
			{
			    freeText4.Text = e.item4;
			    freeText4.Visible = true;
			    ellipse4.Visible = true;
			
			    freeText4.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse4.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText4.Text = "";
			    freeText4.Visible = false;
			    ellipse4.Visible = false;
			}
			
			
			// ===============================
			// Item 5
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item5))
			{
			    freeText5.Text = e.item5;
			    freeText5.Visible = true;
			    ellipse5.Visible = true;
			
			    freeText5.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse5.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText5.Text = "";
			    freeText5.Visible = false;
			    ellipse5.Visible = false;
			}
			
			
			// ===============================
			// Item 6
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item6))
			{
			    freeText6.Text = e.item6;
			    freeText6.Visible = true;
			    ellipse6.Visible = true;
			
			    freeText6.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse6.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText6.Text = "";
			    freeText6.Visible = false;
			    ellipse6.Visible = false;
			}
			
			
			// ===============================
			// Item 7
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item7))
			{
			    freeText7.Text = e.item7;
			    freeText7.Visible = true;
			    ellipse7.Visible = true;
			
			    freeText7.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse7.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText7.Text = "";
			    freeText7.Visible = false;
			    ellipse7.Visible = false;
			}
			
			
			// ===============================
			// Item 8
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item8))
			{
			    freeText8.Text = e.item8;
			    freeText8.Visible = true;
			    ellipse8.Visible = true;
			
			    freeText8.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse8.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText8.Text = "";
			    freeText8.Visible = false;
			    ellipse8.Visible = false;
			}
			
			
			// ===============================
			// Item 9
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item9))
			{
			    freeText9.Text = e.item9;
			    freeText9.Visible = true;
			    ellipse9.Visible = true;
			
			    freeText9.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse9.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText9.Text = "";
			    freeText9.Visible = false;
			    ellipse9.Visible = false;
			}
			
			
			// ===============================
			// Item 10
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item10))
			{
			    freeText10.Text = e.item10;
			    freeText10.Visible = true;
			    ellipse10.Visible = true;
			
			    freeText10.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse10.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText10.Text = "";
			    freeText10.Visible = false;
			    ellipse10.Visible = false;
			}
			
			
			// ===============================
			// Item 11
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item11))
			{
			    freeText11.Text = e.item11;
			    freeText11.Visible = true;
			    ellipse11.Visible = true;
			
			    freeText11.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse11.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText11.Text = "";
			    freeText11.Visible = false;
			    ellipse11.Visible = false;
			}
			
			
			// ===============================
			// Item 12
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item12))
			{
			    freeText12.Text = e.item12;
			    freeText12.Visible = true;
			    ellipse12.Visible = true;
			
			    freeText12.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse12.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText12.Text = "";
			    freeText12.Visible = false;
			    ellipse12.Visible = false;
			}
			
			
			// ===============================
			// Item 13
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item13))
			{
			    freeText13.Text = e.item13;
			    freeText13.Visible = true;
			    ellipse13.Visible = true;
			
			    freeText13.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse13.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText13.Text = "";
			    freeText13.Visible = false;
			    ellipse13.Visible = false;
			}
			
			
			// ===============================
			// Item 14
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item14))
			{
			    freeText14.Text = e.item14;
			    freeText14.Visible = true;
			    ellipse14.Visible = true;
			
			    freeText14.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse14.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText14.Text = "";
			    freeText14.Visible = false;
			    ellipse14.Visible = false;
			}
			
			
			// ===============================
			// Item 15
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item15))
			{
			    freeText15.Text = e.item15;
			    freeText15.Visible = true;
			    ellipse15.Visible = true;
			
			    freeText15.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse15.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText15.Text = "";
			    freeText15.Visible = false;
			    ellipse15.Visible = false;
			}
			
			
			// ===============================
			// Item 16
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.item16))
			{
			    freeText16.Text = e.item16;
			    freeText16.Visible = true;
			    ellipse16.Visible = true;
			
			    freeText16.Location = new NxtControl.Drawing.PointF(freeTextXPosition, freeTextYPosition);
			    ellipse16.Location = new NxtControl.Drawing.PointF(ellipseXPosition, ellipseYPosition);
			
			    freeTextYPosition += yStep;
			    ellipseYPosition += yStep;
			    visibleItemCount++;
			}
			else
			{
			    freeText16.Text = "";
			    freeText16.Visible = false;
			    ellipse16.Visible = false;
			}
			
			
			// ===============================
			// Resize faceplate
			// ===============================
			
			// If all items are empty, keep minimum size
			if (visibleItemCount < 1)
			{
			    visibleItemCount = 1;
			}
			
			// Formula based on your sizes:
			// 1 item => BackGround height = 72, Faceplate height = 88
			// 2 items => BackGround height = 96, Faceplate height = 112
			// 3 items => BackGround height = 120, Faceplate height = 136
			// ...
			// 16 items => BackGround height = 432, Faceplate height = 448
			
			float backgroundHeight = 48 + (visibleItemCount * 24);
			int faceplateHeight = 64 + (visibleItemCount * 24);
			
			// Apply dynamic sizes
			BackGround.Size = new NxtControl.Drawing.SizeF(384, backgroundHeight);
			this.Size = new System.Drawing.Size(400, faceplateHeight);
		}

		void REQ_PHASE_NAME_Fired_EventHandler(object sender, SE.Nereda.Symbols.Phase.REQ_PHASE_NAMEEventArgs e)
		{
			// TODO: Implement REQ_PHASE_NAME_Fired_EventHandler
			PhaseName.Text = e.PhaseName;
		}
	}
}
