/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/19/2026
 * Time: 4:02 PM
 * 
 */

using System;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EffluentCdt
{
	/// <summary>
	/// Description of fpInfos.
	/// </summary>
	public partial class fpStartCdts : NxtControl.GuiFramework.HMIFaceplate
	{
		bool bit1;
		bool bit2;
		bool bit3;
		bool bit4;
		bool bit5;
		bool bit6;
		bool bit7;
		bool bit8;
		
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
		public fpStartCdts()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			this.REQ_ITEMS_Fired += REQ_ITEMS_NAME_Fired_EventHandler;
		}

		void REQ_ITEMS_NAME_Fired_EventHandler(object sender, SE.Nereda.Symbols.EffluentCdt.REQ_ITEMSEventArgs e)
		{
			// TODO: Implement REQ_ITEMS_NAME_Fired_EventHandler
			StartCdtName.Text = e.StartName;
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
			freeText1.Text = e.itemsName1;
			freeText2.Text = e.itemsName2;
			freeText3.Text = e.itemsName3;
			freeText4.Text = e.itemsName4;
			
			
			// ===============================
			// Convert values to binary text with 4 characters
			// ===============================
			string itemsValues1 = e.iTemsValue1.ToString().PadLeft(4, '0');
			string itemsValues2 = e.iTemsValue2.ToString().PadLeft(4, '0');
			
			
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
			// Update ellipse colors
			// ===============================
			ellipse1.BrushColor = bit1 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse2.BrushColor = bit2 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse3.BrushColor = bit3 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse4.BrushColor = bit4 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			
			
			// ===============================
			// Dynamic items display management
			// ===============================
			
			// ===============================
			// Item 1
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.itemsName1))
			{
			    freeText1.Text = e.itemsName1;
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
			if (!string.IsNullOrWhiteSpace(e.itemsName2))
			{
			    freeText2.Text = e.itemsName2;
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
			if (!string.IsNullOrWhiteSpace(e.itemsName3))
			{
			    freeText3.Text = e.itemsName3;
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
			if (!string.IsNullOrWhiteSpace(e.itemsName4))
			{
			    freeText4.Text = e.itemsName4;
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
			// Resize faceplate
			// ===============================
			
			// If all items are empty, keep minimum size
			if (visibleItemCount < 1)
			{
			    visibleItemCount = 1;
			}
			
			// Formula:
			// 1 item => BackGround height = 72, Faceplate height = 88
			// 2 items => BackGround height = 96, Faceplate height = 112
			// ...
			// 8 items => BackGround height = 240, Faceplate height = 256
			
			float backgroundHeight = 48 + (visibleItemCount * 24);
			int faceplateHeight = 64 + (visibleItemCount * 24);
			
			// Apply dynamic sizes
			BackGround.Size = new NxtControl.Drawing.SizeF(384, backgroundHeight);
			this.Size = new System.Drawing.Size(400, faceplateHeight);
		}
	}
}
