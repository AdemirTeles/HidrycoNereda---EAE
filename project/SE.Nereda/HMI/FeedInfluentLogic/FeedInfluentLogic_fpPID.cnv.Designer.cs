/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/17/2026
 * Time: 10:09 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace SE.Nereda.Faceplates.FeedInfluentLogic
{
	/// <summary>
	/// Summary description for fpPID.
	/// </summary>
	partial class fpPID
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.PID = new SE.App2CommonProcess.Symbols.PID.sBarPvSpOpHoriz();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.ActName = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.group1 = new NxtControl.GuiFramework.Group();
			// 
			// PID
			// 
			this.PID.BeginInit();
			this.PID.DefaultInstanceName = null;
			this.PID.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 8D);
			this.PID.DisplayType = SE.App2CommonProcess.SupportClasses.PidDisplayType.PvSpOp;
			this.PID.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.PID.MyTagDisplayName = null;
			this.PID.Name = "PID";
			this.PID.SecurityToken = ((uint)(4294967295u));
			this.PID.TagName = "PID";
			this.PID.EndInit();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(288D)), ((float)(128D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(16D, 36D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Process Value :";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78)));
			this.freeText2.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText2.Location = new NxtControl.Drawing.PointF(16D, 52D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint :";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78)));
			this.freeText3.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText3.Location = new NxtControl.Drawing.PointF(16D, 84D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "PID Output :";
			// 
			// ActName
			// 
			this.ActName.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.ActName.Font = new NxtControl.Drawing.Font("LabelFont");
			this.ActName.Location = new NxtControl.Drawing.PointF(16D, 16D);
			this.ActName.Name = "ActName";
			this.ActName.Text = "46 2 AP ifp 95 001";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(16D, 108D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "RESET Lo Lo Flow Alarm :";
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(192D)), ((float)(104D)), ((float)(80D)), ((float)(25D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.Text = "RESET";
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			this.drawnButton1.Click += new System.EventHandler(this.DrawnButton1Click);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.PID,
			this.ActName,
			this.freeText1,
			this.freeText2,
			this.freeText3,
			this.freeText4,
			this.drawnButton1});
			this.group1.EndInit();
			// 
			// fpPID
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(304D)), ((float)(144D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(154)), ((byte)(154)), ((byte)(154))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.group1});
			this.Size = new System.Drawing.Size(304, 144);
			this.Title = "Feed Influent PID";

		}
		private SE.App2CommonProcess.Symbols.PID.sBarPvSpOpHoriz PID;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.FreeText freeText3;
		private NxtControl.GuiFramework.FreeText ActName;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.Group group1;
		#endregion
	}
}
