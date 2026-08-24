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
	public partial class fpStopCdts : NxtControl.GuiFramework.HMIFaceplate
	{
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
		public fpStopCdts()
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
			StopCdtName.Text = e.StopName;

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
			freeText1.Text = e.itemsName5;
			freeText2.Text = e.itemsName6;
			freeText3.Text = e.itemsName7;
			freeText4.Text = e.itemsName8;
			
			
			// ===============================
			// Convert values to binary text with 4 characters
			// ===============================
			string itemsValues2 = e.iTemsValue2.ToString().PadLeft(4, '0');
			
			
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
			ellipse1.BrushColor = bit5 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse2.BrushColor = bit6 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse3.BrushColor = bit7 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			ellipse4.BrushColor = bit8 ? new NxtControl.Drawing.Color(0, 255, 0) : new NxtControl.Drawing.Color(114, 114, 114);
			
			
			// ===============================
			// Dynamic items display management
			// ===============================
			
			// ===============================
			// Item 5
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.itemsName5))
			{
			    freeText1.Text = e.itemsName5;
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
			// Item 6
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.itemsName6))
			{
			    freeText2.Text = e.itemsName6;
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
			// Item 7
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.itemsName7))
			{
			    freeText3.Text = e.itemsName7;
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
			// Item 8
			// ===============================
			if (!string.IsNullOrWhiteSpace(e.itemsName8))
			{
			    freeText4.Text = e.itemsName8;
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
			
			float backgroundHeight = 48 + (visibleItemCount * 24);
			int faceplateHeight = 64 + (visibleItemCount * 24);
			
			// Apply dynamic sizes
			BackGround.Size = new NxtControl.Drawing.SizeF(384, backgroundHeight);
			this.Size = new System.Drawing.Size(400, faceplateHeight);
		}
	}
}
