/* StartCanvas.cnv.Designer.cs */
/* =====================================================================$
 * Copyright © {2022} Schneider Electric.   All rights reserved.
 * The contents of this file is subject to confidentiality.
 *
 * =====================================================================$
 */

/*
 * Created by HMI.Main.
 * User:  
 * Date: 18.09.2008
 * Time: 17:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
  /// <summary>
  /// Summary description for StartCanvas_2.
  /// </summary>
  partial class StartCanvas_2
  {
    #region Component Designer generated code
    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
    	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartCanvas_2));
    	this.canvasTopologySeparator1 = new NxtControl.GuiFramework.CanvasTopologySeparator();
    	this.canvasTopologySeparator2 = new NxtControl.GuiFramework.CanvasTopologySeparator();
    	this.workArea = new NxtControl.GuiFramework.WorkAreaControl();
    	this.header1 = new NxtControl.GuiFramework.Rectangle();
    	this.siblingsPanel = new NxtControl.GuiFramework.CanvasTopologyPanel();
    	this.childrenPanel = new NxtControl.GuiFramework.CanvasTopologyPanel();
    	this.logo = new NxtControl.GuiFramework.Rectangle();
    	this.login1 = new NxtControl.GuiFramework.Login();
    	this.currentUser1 = new NxtControl.GuiFramework.CurrentUser();
    	this.language1 = new NxtControl.GuiFramework.LanguageSwitcher();
    	this.runtimeConnection1 = new NxtControl.GuiFramework.RuntimeConnection();
    	this.newVersionDeployment1 = new NxtControl.GuiFramework.HMIDeployment();
    	this.canvasTopologyNavigation = new NxtControl.GuiFramework.CanvasTopologyRose();
    	this.logState1 = new NxtControl.GuiFramework.LogState();
    	this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
    	this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
    	this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
    	this.group1 = new NxtControl.GuiFramework.Group();
    	this.alarmGrid1 = new NxtControl.GuiFramework.AlarmGrid();
    	this.AckBtn = new NxtControl.GuiFramework.DrawnButton();
    	this.changeCanvasButton1 = new NxtControl.GuiFramework.ChangeCanvasButton();
    	this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
    	((System.ComponentModel.ISupportInitialize)(this.alarmGrid1)).BeginInit();
    	// 
    	// canvasTopologySeparator1
    	// 
    	this.canvasTopologySeparator1.Anchor = NxtControl.Drawing.AnchorStyles.Left;
    	this.canvasTopologySeparator1.Bounds = new NxtControl.Drawing.RectF(((float)(344D)), ((float)(0D)), ((float)(2D)), ((float)(70D)));
    	this.canvasTopologySeparator1.Brush = new NxtControl.Drawing.Brush("CanvasTopologySeparatorBrush");
    	this.canvasTopologySeparator1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.canvasTopologySeparator1.LookAndFeel = "Theme";
    	this.canvasTopologySeparator1.Name = "canvasTopologySeparator1";
    	this.canvasTopologySeparator1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
    	// 
    	// canvasTopologySeparator2
    	// 
    	this.canvasTopologySeparator2.Anchor = NxtControl.Drawing.AnchorStyles.Right;
    	this.canvasTopologySeparator2.Bounds = new NxtControl.Drawing.RectF(((float)(1191D)), ((float)(0D)), ((float)(2D)), ((float)(70D)));
    	this.canvasTopologySeparator2.Brush = new NxtControl.Drawing.Brush("CanvasTopologySeparatorBrush");
    	this.canvasTopologySeparator2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.canvasTopologySeparator2.LookAndFeel = "Theme";
    	this.canvasTopologySeparator2.Name = "canvasTopologySeparator2";
    	this.canvasTopologySeparator2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
    	// 
    	// workArea
    	// 
    	this.workArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.workArea.AutoScroll = true;
    	this.workArea.AutoScrollPosition = new System.Drawing.Point(0, 0);
    	this.workArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
    	this.workArea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
    	this.workArea.Dock = System.Windows.Forms.DockStyle.None;
    	this.workArea.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.workArea.ForeColor = System.Drawing.SystemColors.ControlText;
    	this.workArea.Location = new System.Drawing.Point(0, 70);
    	this.workArea.Name = "workArea";
    	this.workArea.Size = new System.Drawing.Size(1366, 698);
    	this.workArea.Text = null;
    	// 
    	// header1
    	// 
    	this.header1.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
    	this.header1.Bounds = new NxtControl.Drawing.RectF(((float)(-8D)), ((float)(0D)), ((float)(1366D)), ((float)(70D)));
    	this.header1.Brush = new NxtControl.Drawing.Brush("CanvasTopologyHeaderBrush");
    	this.header1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.header1.Name = "header1";
    	this.header1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
    	// 
    	// siblingsPanel
    	// 
    	this.siblingsPanel.BeginInit();
    	this.siblingsPanel.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
    	this.siblingsPanel.Bounds = new NxtControl.Drawing.RectF(((float)(416D)), ((float)(0D)), ((float)(767D)), ((float)(40D)));
    	this.siblingsPanel.BtnColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
    	this.siblingsPanel.BtnHeight = 30;
    	this.siblingsPanel.BtnWidth = 127;
    	this.siblingsPanel.CurrentBtnColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
    	this.siblingsPanel.LookAndFeel = "Theme";
    	this.siblingsPanel.Name = "siblingsPanel";
    	this.siblingsPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
    	this.siblingsPanel.TopologyType = NxtControl.GuiFramework.CanvasTopologyType.Sibling;
    	this.siblingsPanel.WorkArea = this.workArea;
    	this.siblingsPanel.EndInit();
    	// 
    	// childrenPanel
    	// 
    	this.childrenPanel.BeginInit();
    	this.childrenPanel.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
    	this.childrenPanel.Bounds = new NxtControl.Drawing.RectF(((float)(416D)), ((float)(34D)), ((float)(440D)), ((float)(40D)));
    	this.childrenPanel.BtnColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
    	this.childrenPanel.BtnHeight = 30;
    	this.childrenPanel.BtnWidth = 127;
    	this.childrenPanel.CurrentBtnColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
    	this.childrenPanel.LookAndFeel = "Theme";
    	this.childrenPanel.Name = "childrenPanel";
    	this.childrenPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
    	this.childrenPanel.TopologyType = NxtControl.GuiFramework.CanvasTopologyType.Child;
    	this.childrenPanel.WorkArea = this.workArea;
    	this.childrenPanel.EndInit();
    	// 
    	// logo
    	// 
    	this.logo.Anchor = NxtControl.Drawing.AnchorStyles.Left;
    	this.logo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(104D)), ((float)(70D)));
    	this.logo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
    	this.logo.Font = new NxtControl.Drawing.Font("HeaderFont");
    	this.logo.ImageBytes = resources.GetString("logo.ImageBytes");
    	this.logo.Name = "logo";
    	this.logo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
    	// 
    	// login1
    	// 
    	this.login1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
    	this.login1.AngleIgnore = true;
    	this.login1.Bounds = new NxtControl.Drawing.RectF(((float)(1296D)), ((float)(0D)), ((float)(35D)), ((float)(35D)));
    	this.login1.Brush = new NxtControl.Drawing.Brush("CanvasTopologyButtonBrush");
    	this.login1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.login1.LookAndFeel = "Theme";
    	this.login1.Name = "login1";
    	this.login1.Pen = new NxtControl.Drawing.Pen("Transparent");
    	this.login1.Radius = 2D;
    	this.login1.TextColor = new NxtControl.Drawing.Color("CanvasTopologyButtonColor");
    	this.login1.Use3DEffect = false;
    	// 
    	// currentUser1
    	// 
    	this.currentUser1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
    	this.currentUser1.AngleIgnore = true;
    	this.currentUser1.BorderStyle = System.Windows.Forms.BorderStyle.None;
    	this.currentUser1.Bounds = new NxtControl.Drawing.RectF(((float)(1266D)), ((float)(35D)), ((float)(100D)), ((float)(35D)));
    	this.currentUser1.Brush = new NxtControl.Drawing.Brush(true);
    	this.currentUser1.Font = new NxtControl.Drawing.Font("HeaderFont");
    	this.currentUser1.LookAndFeel = "Theme";
    	this.currentUser1.Name = "currentUser1";
    	this.currentUser1.Pen = new NxtControl.Drawing.Pen("CanvasTopologyButtonPen");
    	this.currentUser1.Text = "currentUser1";
    	this.currentUser1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
    	this.currentUser1.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
    	// 
    	// language1
    	// 
    	this.language1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
    	this.language1.Bounds = new NxtControl.Drawing.RectF(((float)(1331D)), ((float)(0D)), ((float)(35D)), ((float)(35D)));
    	this.language1.Font = new NxtControl.Drawing.Font("HeaderFont");
    	this.language1.LookAndFeel = "Theme";
    	this.language1.Name = "language1";
    	this.language1.Radius = 2D;
    	this.language1.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
    	this.language1.Use3DEffect = false;
    	// 
    	// runtimeConnection1
    	// 
    	this.runtimeConnection1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
    	this.runtimeConnection1.Bounds = new NxtControl.Drawing.RectF(((float)(1261D)), ((float)(0D)), ((float)(35D)), ((float)(35D)));
    	this.runtimeConnection1.ConnectedColor = new NxtControl.Drawing.Color("RuntimeConnectionConnected");
    	this.runtimeConnection1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.runtimeConnection1.MibErrorColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(0)), ((byte)(0)));
    	this.runtimeConnection1.Name = "runtimeConnection1";
    	this.runtimeConnection1.Radius = 0D;
    	// 
    	// newVersionDeployment1
    	// 
    	this.newVersionDeployment1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
    	this.newVersionDeployment1.Bounds = new NxtControl.Drawing.RectF(((float)(1226D)), ((float)(0D)), ((float)(35D)), ((float)(35D)));
    	this.newVersionDeployment1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.newVersionDeployment1.LookAndFeel = "Theme";
    	this.newVersionDeployment1.Name = "newVersionDeployment1";
    	this.newVersionDeployment1.Radius = 2D;
    	this.newVersionDeployment1.Use3DEffect = false;
    	// 
    	// canvasTopologyNavigation
    	// 
    	this.canvasTopologyNavigation.BeginInit();
    	this.canvasTopologyNavigation.Brush = new NxtControl.Drawing.Brush("CanvasTopologyRoseBrush");
    	this.canvasTopologyNavigation.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
    	this.canvasTopologyNavigation.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.769230769230769D, 0D, 0D, 0.804597701149425D, 343.53846153846155D, -2.2413793103448247D);
    	this.canvasTopologyNavigation.LookAndFeel = "Theme";
    	this.canvasTopologyNavigation.Name = "canvasTopologyNavigation";
    	this.canvasTopologyNavigation.Tooltip = "Navigation to Canvases";
    	this.canvasTopologyNavigation.WorkArea = this.workArea;
    	this.canvasTopologyNavigation.EndInit();
    	// 
    	// logState1
    	// 
    	this.logState1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
    	this.logState1.Bounds = new NxtControl.Drawing.RectF(((float)(1191D)), ((float)(0D)), ((float)(35D)), ((float)(35D)));
    	this.logState1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.logState1.Name = "logState1";
    	this.logState1.Radius = 0D;
    	// 
    	// rectangle1
    	// 
    	this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(20D)), ((float)(112D)), ((float)(29.473684310913086D)));
    	this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
    	this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.rectangle1.ImageBytes = resources.GetString("rectangle1.ImageBytes");
    	this.rectangle1.Name = "rectangle1";
    	this.rectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
    	// 
    	// rectangle2
    	// 
    	this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(4D)), ((float)(112D)), ((float)(29.473684310913086D)));
    	this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
    	this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.rectangle2.ImageBytes = resources.GetString("rectangle2.ImageBytes");
    	this.rectangle2.Name = "rectangle2";
    	this.rectangle2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
    	// 
    	// rectangle3
    	// 
    	this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(224D)), ((float)(36D)), ((float)(112D)), ((float)(29.473684310913086D)));
    	this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
    	this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.rectangle3.ImageBytes = resources.GetString("rectangle3.ImageBytes");
    	this.rectangle3.Name = "rectangle3";
    	this.rectangle3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
    	// 
    	// group1
    	// 
    	this.group1.BeginInit();
    	this.group1.Name = "group1";
    	this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.rectangle3});
    	this.group1.EndInit();
    	// 
    	// alarmGrid1
    	// 
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Shortcut, false, null, 32));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Ack, true, null, 40));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Origin, false, null, 200));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Text, false, null, 100));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.CameTime, false, null, 130));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.GoneTime, false, null, 130));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Present, false, null, 48));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.State, false, null, 0));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.Value, false, null, 80));
    	this.alarmGrid1.AlarmColumns.Add(new NxtControl.GuiFramework.AlarmColumnInformation(NxtControl.GuiFramework.AlarmColumn.InfoValue, false, null, 80));
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
    	this.alarmGrid1.Location = new System.Drawing.Point(1104, 8);
    	this.alarmGrid1.Name = "alarmGrid1";
    	this.alarmGrid1.SecurityLevel = 3;
    	this.alarmGrid1.Size = new System.Drawing.Size(81, 25);
    	this.alarmGrid1.Text = "alarmGrid1";
    	this.alarmGrid1.ToolBarBackColor = System.Drawing.SystemColors.AppWorkspace;
    	this.alarmGrid1.ToolBarForeColor = System.Drawing.SystemColors.ControlText;
    	// 
    	// AckBtn
    	// 
    	this.AckBtn.Bounds = new NxtControl.Drawing.RectF(((float)(1104D)), ((float)(38D)), ((float)(80D)), ((float)(30D)));
    	this.AckBtn.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
    	this.AckBtn.Font = new NxtControl.Drawing.Font("ButtonFont");
    	this.AckBtn.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
    	this.AckBtn.Name = "AckBtn";
    	this.AckBtn.Pen = new NxtControl.Drawing.Pen("ButtonPen");
    	this.AckBtn.Radius = 4D;
    	this.AckBtn.Text = "Ack All";
    	this.AckBtn.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
    	this.AckBtn.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
    	this.AckBtn.Use3DEffect = false;
    	this.AckBtn.Click += new System.EventHandler(this.AckBtnClick);
    	// 
    	// changeCanvasButton1
    	// 
    	this.changeCanvasButton1.Bounds = new NxtControl.Drawing.RectF(((float)(1008D)), ((float)(40D)), ((float)(88D)), ((float)(24D)));
    	this.changeCanvasButton1.CanvasName = "ALARMS";
    	this.changeCanvasButton1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.changeCanvasButton1.Name = "changeCanvasButton1";
    	this.changeCanvasButton1.Text = "ALARMS";
    	// 
    	// changeCanvasButton2
    	// 
    	this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(856D)), ((float)(40D)), ((float)(144D)), ((float)(24D)));
    	this.changeCanvasButton2.CanvasName = "EMERGENCY_RECIPE";
    	this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
    	this.changeCanvasButton2.Name = "changeCanvasButton2";
    	this.changeCanvasButton2.Text = "EMERGENCY RECIPE";
    	// 
    	// StartCanvas_2
    	// 
    	this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(768D)));
    	this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmGrid1,
			this.header1,
			this.childrenPanel,
			this.logo,
			this.login1,
			this.currentUser1,
			this.language1,
			this.runtimeConnection1,
			this.newVersionDeployment1,
			this.canvasTopologyNavigation,
			this.logState1,
			this.canvasTopologySeparator1,
			this.canvasTopologySeparator2,
			this.workArea,
			this.rectangle1,
			this.group1,
			this.AckBtn,
			this.siblingsPanel,
			this.changeCanvasButton1,
			this.changeCanvasButton2});
    	this.Size = new System.Drawing.Size(1366, 768);
    	((System.ComponentModel.ISupportInitialize)(this.alarmGrid1)).EndInit();

    }
    
    private NxtControl.GuiFramework.Rectangle header1;
	private NxtControl.GuiFramework.CanvasTopologyPanel siblingsPanel;
	private NxtControl.GuiFramework.CanvasTopologyPanel childrenPanel;
private NxtControl.GuiFramework.Rectangle logo;
private NxtControl.GuiFramework.Login login1;
private NxtControl.GuiFramework.CurrentUser currentUser1;
private NxtControl.GuiFramework.LanguageSwitcher language1;
private NxtControl.GuiFramework.RuntimeConnection runtimeConnection1;
private NxtControl.GuiFramework.HMIDeployment newVersionDeployment1;
 private NxtControl.GuiFramework.CanvasTopologyRose canvasTopologyNavigation;
private NxtControl.GuiFramework.LogState logState1;

    private NxtControl.GuiFramework.WorkAreaControl workArea;    
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator1;
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator2; 
    private NxtControl.GuiFramework.Rectangle rectangle1;
    private NxtControl.GuiFramework.Rectangle rectangle2;
    private NxtControl.GuiFramework.Rectangle rectangle3;
    private NxtControl.GuiFramework.Group group1;
    private NxtControl.GuiFramework.AlarmGrid alarmGrid1;
    private NxtControl.GuiFramework.DrawnButton AckBtn;
    private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton1;
    private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
    #endregion
  }
}
