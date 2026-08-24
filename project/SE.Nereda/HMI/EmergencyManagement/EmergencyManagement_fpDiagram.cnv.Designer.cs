/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/5/2026
 * Time: 6:52 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.EmergencyManagement
{
	/// <summary>
	/// Summary description for fpDiagram.
	/// </summary>
	partial class fpDiagram
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.line1 = new NxtControl.GuiFramework.Line();
			this.State1 = new NxtControl.GuiFramework.Rectangle();
			this.State2 = new NxtControl.GuiFramework.Rectangle();
			this.State3 = new NxtControl.GuiFramework.Rectangle();
			this.State4 = new NxtControl.GuiFramework.Rectangle();
			this.State10 = new NxtControl.GuiFramework.Rectangle();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line6 = new NxtControl.GuiFramework.Line();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.line20 = new NxtControl.GuiFramework.Line();
			this.line21 = new NxtControl.GuiFramework.Line();
			this.line22 = new NxtControl.GuiFramework.Line();
			this.freeText15 = new NxtControl.GuiFramework.FreeText();
			this.freeText19 = new NxtControl.GuiFramework.FreeText();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.line8 = new NxtControl.GuiFramework.Line();
			this.StartUpDelay = new SE.Nereda.Symbols.E_DELAY_V_D.sDefault();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText13 = new NxtControl.GuiFramework.FreeText();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(72D, 368D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(72D, 16D);
			// 
			// State1
			// 
			this.State1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(96D)), ((float)(32D)), ((float)(32D)));
			this.State1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State1.Name = "State1";
			this.State1.Text = "1";
			this.State1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State2
			// 
			this.State2.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(176D)), ((float)(32D)), ((float)(32D)));
			this.State2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State2.Name = "State2";
			this.State2.Text = "2";
			this.State2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State3
			// 
			this.State3.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(240D)), ((float)(32D)), ((float)(32D)));
			this.State3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State3.Name = "State3";
			this.State3.Text = "3";
			this.State3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State4
			// 
			this.State4.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(304D)), ((float)(32D)), ((float)(32D)));
			this.State4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State4.Name = "State4";
			this.State4.Text = "4";
			this.State4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// State10
			// 
			this.State10.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(32D)), ((float)(32D)), ((float)(32D)));
			this.State10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.State10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.State10.Name = "State10";
			this.State10.Text = "0";
			this.State10.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(80D, 160D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(64D, 160D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(80D, 224D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(64D, 224D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(80D, 288D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(64D, 288D);
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(80D, 80D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(64D, 80D);
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(88D, 152D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Start Up Delay Finished";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(88D, 72D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Start Emergency";
			// 
			// line20
			// 
			this.line20.EndPoint = new NxtControl.Drawing.PointF(72D, 368D);
			this.line20.Name = "line20";
			this.line20.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line20.StartPoint = new NxtControl.Drawing.PointF(16D, 368D);
			// 
			// line21
			// 
			this.line21.EndPoint = new NxtControl.Drawing.PointF(16D, 368D);
			this.line21.Name = "line21";
			this.line21.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line21.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// line22
			// 
			this.line22.EndPoint = new NxtControl.Drawing.PointF(72D, 16D);
			this.line22.Name = "line22";
			this.line22.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line22.StartPoint = new NxtControl.Drawing.PointF(16D, 16D);
			// 
			// freeText15
			// 
			this.freeText15.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText15.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText15.Location = new NxtControl.Drawing.PointF(96D, 96D);
			this.freeText15.Name = "freeText15";
			this.freeText15.Text = "Start : Start Up Delay";
			// 
			// freeText19
			// 
			this.freeText19.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText19.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText19.Location = new NxtControl.Drawing.PointF(96D, 32D);
			this.freeText19.Name = "freeText19";
			this.freeText19.Text = "Emergency OFF";
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(11D)), ((float)(172D)), ((float)(10D)), ((float)(24D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 172D),
			new NxtControl.Drawing.PointF(11D, 196D),
			new NxtControl.Drawing.PointF(21D, 196D)});
			// 
			// line8
			// 
			this.line8.EndPoint = new NxtControl.Drawing.PointF(80D, 352D);
			this.line8.Name = "line8";
			this.line8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			this.line8.StartPoint = new NxtControl.Drawing.PointF(64D, 352D);
			// 
			// StartUpDelay
			// 
			this.StartUpDelay.BeginInit();
			this.StartUpDelay.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 96D, 112D);
			this.StartUpDelay.Name = "StartUpDelay";
			this.StartUpDelay.SecurityToken = ((uint)(4294967295u));
			this.StartUpDelay.TagName = "StartUpDelay";
			this.StartUpDelay.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(96D, 176D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Ask For Feed Order";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(88D, 280D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "1";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(96D, 240D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Initialize Emergency";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(88D, 216D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Done";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(96D, 304D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Start Reactors";
			// 
			// freeText13
			// 
			this.freeText13.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.freeText13.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText13.Location = new NxtControl.Drawing.PointF(88D, 344D);
			this.freeText13.Name = "freeText13";
			this.freeText13.Text = "Emergency OFF";
			// 
			// fpDiagram
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(232D)), ((float)(384D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.State1,
			this.State2,
			this.State3,
			this.State4,
			this.State10,
			this.line2,
			this.line3,
			this.line4,
			this.line6,
			this.freeText1,
			this.freeText5,
			this.line20,
			this.line21,
			this.line22,
			this.freeText15,
			this.freeText19,
			this.polygon1,
			this.line8,
			this.StartUpDelay,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.freeText7,
			this.freeText9,
			this.freeText13});
			this.Size = new System.Drawing.Size(232, 384);
			this.Title = "Emergency Management Diagram";

		}
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Rectangle State1;
		private NxtControl.GuiFramework.Rectangle State2;
		private NxtControl.GuiFramework.Rectangle State3;
		private NxtControl.GuiFramework.Rectangle State4;
		private NxtControl.GuiFramework.Rectangle State10;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.Line line20;
		private NxtControl.GuiFramework.Line line21;
		private NxtControl.GuiFramework.Line line22;
		private NxtControl.GuiFramework.FreeText freeText15;
		private NxtControl.GuiFramework.FreeText freeText19;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Line line8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText7;
		private SE.Nereda.Symbols.E_DELAY_V_D.sDefault StartUpDelay;
		private NxtControl.GuiFramework.FreeText freeText13;
		#endregion
	}
}
