/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/11/2026
 * Time: 3:47 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for ALARMS.
	/// </summary>
	partial class ALARMS
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.alarmGrid1 = new NxtControl.GuiFramework.AlarmGrid();
			this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton5 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton6 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton7 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			((System.ComponentModel.ISupportInitialize)(this.alarmGrid1)).BeginInit();
			// 
			// alarmGrid1
			// 
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Shortcut, true, null, 32));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Ack, true, null, 40));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Origin, true, null, 200));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Text, true, null, 100));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.CameTime, true, null, 130));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.GoneTime, true, null, 130));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Present, true, null, 48));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.State, true, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Value, true, null, 80));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.InfoValue, true, null, 80));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.CameAckTime, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.GoneAckTime, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Interval, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.CameAckUser, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.GoneAckUser, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Path, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Alias, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Time, false, null, 0));
			this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Selected, true, null, 25));
			this.alarmGrid1.AlarmFilter = new NxtControl.GuiFramework.AlarmConfiguration("");
			this.alarmGrid1.AlternatingRowColor = System.Drawing.Color.Empty;
			this.alarmGrid1.BackColor = System.Drawing.SystemColors.AppWorkspace;
			this.alarmGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.alarmGrid1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alarmGrid1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.alarmGrid1.GridCellBackColor = System.Drawing.SystemColors.Window;
			this.alarmGrid1.HeaderBackColor = System.Drawing.SystemColors.Control;
			this.alarmGrid1.HeaderForeColor = System.Drawing.SystemColors.WindowText;
			this.alarmGrid1.Location = new System.Drawing.Point(8, 64);
			this.alarmGrid1.Name = "alarmGrid1";
			this.alarmGrid1.SecurityLevel = 3;
			this.alarmGrid1.Size = new System.Drawing.Size(1353, 569);
			this.alarmGrid1.Text = "alarmGrid1";
			this.alarmGrid1.ToolBarBackColor = System.Drawing.SystemColors.AppWorkspace;
			this.alarmGrid1.ToolBarForeColor = System.Drawing.SystemColors.ControlText;
			// 
			// changeCanvasButton2
			// 
			this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(1152D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton2.CanvasName = "SLUDGE_BUFFER";
			this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton2.Name = "changeCanvasButton2";
			this.changeCanvasButton2.Text = "SLUDGE BUFFER";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(600D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton4.CanvasName = "INFLUENT_FEED";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "INFLUENT FEED";
			// 
			// changeCanvasButton1
			// 
			this.changeCanvasButton1.Bounds = new NxtControl.Drawing.RectF(((float)(416D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton1.CanvasName = "REACTOR3";
			this.changeCanvasButton1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton1.Name = "changeCanvasButton1";
			this.changeCanvasButton1.Text = "REACTOR 3";
			// 
			// changeCanvasButton3
			// 
			this.changeCanvasButton3.Bounds = new NxtControl.Drawing.RectF(((float)(232D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton3.CanvasName = "REACTOR2";
			this.changeCanvasButton3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton3.Name = "changeCanvasButton3";
			this.changeCanvasButton3.Text = "REACTOR 2";
			// 
			// changeCanvasButton5
			// 
			this.changeCanvasButton5.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton5.CanvasName = "REACTOR1";
			this.changeCanvasButton5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton5.Name = "changeCanvasButton5";
			this.changeCanvasButton5.Text = "REACTOR 1";
			// 
			// changeCanvasButton6
			// 
			this.changeCanvasButton6.Bounds = new NxtControl.Drawing.RectF(((float)(784D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton6.CanvasName = "EFFLUENT";
			this.changeCanvasButton6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton6.Name = "changeCanvasButton6";
			this.changeCanvasButton6.Text = "EFFLUENT";
			// 
			// changeCanvasButton7
			// 
			this.changeCanvasButton7.Bounds = new NxtControl.Drawing.RectF(((float)(968D)), ((float)(648D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton7.CanvasName = "CALAMITY";
			this.changeCanvasButton7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton7.Name = "changeCanvasButton7";
			this.changeCanvasButton7.Text = "CALAMITY";
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.changeCanvasButton2,
			this.changeCanvasButton4,
			this.changeCanvasButton1,
			this.changeCanvasButton3,
			this.changeCanvasButton5,
			this.changeCanvasButton6,
			this.changeCanvasButton7});
			this.group1.EndInit();
			// 
			// HeartBeat
			// 
			this.HeartBeat.BeginInit();
			this.HeartBeat.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.HeartBeat.Name = "HeartBeat";
			this.HeartBeat.SecurityToken = ((uint)(4294967295u));
			this.HeartBeat.TagName = "32B44D45F962192F";
			this.HeartBeat.EndInit();
			// 
			// MCCPower
			// 
			this.MCCPower.BeginInit();
			this.MCCPower.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 216D, 8D);
			this.MCCPower.Name = "MCCPower";
			this.MCCPower.SecurityToken = ((uint)(4294967295u));
			this.MCCPower.TagName = "E1E3B3442DD19945";
			this.MCCPower.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "7A79C015B9ADE3EB";
			this.Mode.EndInit();
			// 
			// sHiHiLevelCalamity1
			// 
			this.sHiHiLevelCalamity1.BeginInit();
			this.sHiHiLevelCalamity1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 632D, 8D);
			this.sHiHiLevelCalamity1.Name = "sHiHiLevelCalamity1";
			this.sHiHiLevelCalamity1.SecurityToken = ((uint)(4294967295u));
			this.sHiHiLevelCalamity1.TagName = "F2F66466CB372A96.EffluentLogic.Calamity";
			this.sHiHiLevelCalamity1.EndInit();
			// 
			// OpenWebPage
			// 
			this.OpenWebPage.BeginInit();
			this.OpenWebPage.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 840D, 8D);
			this.OpenWebPage.Name = "OpenWebPage";
			this.OpenWebPage.SecurityToken = ((uint)(4294967295u));
			this.OpenWebPage.TagName = "61745BDDB91DBEF5";
			this.OpenWebPage.EndInit();
			// 
			// ALARMS
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmGrid1,
			this.group1,
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage});
			this.Size = new System.Drawing.Size(1366, 698);
			((System.ComponentModel.ISupportInitialize)(this.alarmGrid1)).EndInit();

		}
		private NxtControl.GuiFramework.AlarmGrid alarmGrid1;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton1;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton5;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton6;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton7;
		private NxtControl.GuiFramework.Group group1;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		#endregion
	}
}
