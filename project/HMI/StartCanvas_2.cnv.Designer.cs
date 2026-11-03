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
this.exit1 = new NxtControl.GuiFramework.Exit();
this.login1 = new NxtControl.GuiFramework.Login();
this.currentUser1 = new NxtControl.GuiFramework.CurrentUser();
this.runtimeConnection1 = new NxtControl.GuiFramework.RuntimeConnection();
this.canvasTopologyNavigation = new NxtControl.GuiFramework.CanvasTopologyRose();
      
      // 
      // canvasTopologySeparator1
      //
      this.canvasTopologySeparator1.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.canvasTopologySeparator1.Bounds = new NxtControl.Drawing.RectF(((float)(239)), ((float)(0)), ((float)(2)), ((float)(70)));
      this.canvasTopologySeparator1.Name = "canvasTopologySeparator1";
      this.canvasTopologySeparator1.LookAndFeel = "Theme";
      this.canvasTopologySeparator1.Visible = true;
      // 
      // canvasTopologySeparator2
      //
      this.canvasTopologySeparator2.Anchor = NxtControl.Drawing.AnchorStyles.Right; 
      this.canvasTopologySeparator2.Bounds = new NxtControl.Drawing.RectF(((float)(1261)), ((float)(0)), ((float)(2)), ((float)(70)));
      this.canvasTopologySeparator2.Name = "canvasTopologySeparator2";
      this.canvasTopologySeparator2.LookAndFeel = "Theme";
      this.canvasTopologySeparator2.Visible = true;      
      // 
      // workArea
      // 
      this.workArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
                  | System.Windows.Forms.AnchorStyles.Left) 
                  | System.Windows.Forms.AnchorStyles.Right)));
      this.workArea.AutoScroll = true;
      this.workArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.workArea.Location = new System.Drawing.Point(0, 70);
      this.workArea.Name = "workArea";
      this.workArea.RuntimeMode = true;
      this.workArea.Size = new System.Drawing.Size(1366, 698);
      this.workArea.TabIndex = 0;
      this.workArea.BackColor = System.Drawing.Color.FromArgb(255, 255, 255);
      
      // 
      // header1
      // 
      this.header1.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
      this.header1.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(1366)), ((float)(70)));
      this.header1.Name = "header1";
      this.header1.Brush = NxtControl.Drawing.Brush.FromName("CanvasTopologyHeaderBrush");
      this.header1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
    //
    // siblingsPanel
    //
    this.siblingsPanel.BeginInit();
    this.siblingsPanel.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
    this.siblingsPanel.Bounds = new NxtControl.Drawing.RectF(((float)(309)), ((float)(0)), ((float)(952)), ((float)(70)));
    this.siblingsPanel.BtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.siblingsPanel.CurrentBtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.siblingsPanel.TopologyType = NxtControl.GuiFramework.CanvasTopologyType.Sibling;
    this.siblingsPanel.LookAndFeel = "Theme";
    this.siblingsPanel.BtnHeight = 30;
    this.siblingsPanel.BtnWidth = 140;
    this.siblingsPanel.Name = "siblingsPanel";
    this.siblingsPanel.WorkArea = workArea;
    this.siblingsPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
    this.siblingsPanel.EndInit();
    //
    // childrenPanel
    //
    this.childrenPanel.BeginInit();
    this.childrenPanel.Anchor = ((NxtControl.Drawing.AnchorStyles)((NxtControl.Drawing.AnchorStyles.Left | NxtControl.Drawing.AnchorStyles.Right)));
    this.childrenPanel.Bounds = new NxtControl.Drawing.RectF(((float)(309)), ((float)(34)), ((float)(952)), ((float)(70)));
    this.childrenPanel.BtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.childrenPanel.CurrentBtnColor = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
    this.childrenPanel.TopologyType = NxtControl.GuiFramework.CanvasTopologyType.Child;
    this.childrenPanel.LookAndFeel = "Theme";
    this.childrenPanel.BtnHeight = 30;
    this.childrenPanel.BtnWidth = 140;
    this.childrenPanel.Name = "childrenPanel";
    this.childrenPanel.WorkArea = workArea;
    this.childrenPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
    this.childrenPanel.EndInit();
			// 
      // logo
      // 
      this.logo.Anchor = NxtControl.Drawing.AnchorStyles.Left; 
      this.logo.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(239)), ((float)(70)));
      this.logo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
      this.logo.Font = new NxtControl.Drawing.Font("HeaderFont");
      this.logo.ImageBytes = resources.GetString("logo.ImageBytes");
      this.logo.Name = "logo";
      this.logo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
      this.logo.TextColor = new NxtControl.Drawing.Color("Black");
			// 
      // exit1
      // 
      this.exit1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.exit1.Bounds = new NxtControl.Drawing.RectF(((float)(1331)), ((float)(0)), ((float)(35)), ((float)(35)));
      this.exit1.Text = "";
      this.exit1.Radius = 0;
      this.exit1.LookAndFeel = "Theme";
      this.exit1.Pen = NxtControl.Drawing.Pen.FromName("Transparent");
      this.exit1.Name = "exit1";
      this.exit1.Warning = false;
      this.exit1.WarningText = "";
			// 
      // login1
      // 
      this.login1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.login1.Bounds = new NxtControl.Drawing.RectF(((float)(1296)), ((float)(0)), ((float)(35)), ((float)(35)));
      this.login1.Text = "";
      this.login1.Radius = 0;
      this.login1.LookAndFeel = "Theme";
      this.login1.Pen = NxtControl.Drawing.Pen.FromName("Transparent");
      this.login1.Name = "login1";
			// 
      // currentUser1
      // 
      this.currentUser1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.currentUser1.AngleIgnore = true;
      this.currentUser1.Bounds = new NxtControl.Drawing.RectF(((float)(1266)), ((float)(35)), ((float)(100)), ((float)(35)));
      this.currentUser1.Brush = new NxtControl.Drawing.Brush();
      this.currentUser1.Font = new NxtControl.Drawing.Font("HeaderFont");
      this.currentUser1.LookAndFeel = "Theme";
      this.currentUser1.Name = "currentUser1";
      this.currentUser1.Pen =  new NxtControl.Drawing.Pen("CanvasTopologyButtonPen");
      this.currentUser1.Text = "currentUser1";
      this.currentUser1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
      this.currentUser1.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			// 
      // runtimeConnection1
      // 
      this.runtimeConnection1.Anchor = NxtControl.Drawing.AnchorStyles.Right;
      this.runtimeConnection1.Bounds = new NxtControl.Drawing.RectF(((float)(1261)), ((float)(0)), ((float)(35)), ((float)(35)));
      this.runtimeConnection1.Text = "";
      this.runtimeConnection1.Radius = 0;     
      this.runtimeConnection1.Name = "runtimeConnection1";
      this.runtimeConnection1.Brush = new NxtControl.Drawing.Brush("CanvasTopologyButtonBrush");
      this.runtimeConnection1.Pen = NxtControl.Drawing.Pen.FromName("Transparent");
    // 
      // canvasTopologyNavigation
      // 
      this.canvasTopologyNavigation.BeginInit();
      this.canvasTopologyNavigation.Bounds = new NxtControl.Drawing.RectF(((float)(239)), ((float)(0)), ((float)(70)), ((float)(70)));
      this.canvasTopologyNavigation.Color = new NxtControl.Drawing.Color((byte) 255 , (byte) 255, (byte) 0);
      this.canvasTopologyNavigation.Name = "canvasTopologyRose";
      this.canvasTopologyNavigation.TransformMatrix = new NxtControl.Drawing.Matrix2D(0.769230769230769, 0, 0, 0.804597701149425, 232.846153846154, -1.60919540229885);
      this.canvasTopologyNavigation.LookAndFeel = "Theme";
      this.canvasTopologyNavigation.EndInit();

      // 
      // StartCanvas_2
      // 
      this.Bounds = new NxtControl.Drawing.RectF(((float)(0)), ((float)(0)), ((float)(1366)), ((float)(768)));
      this.Name = "StartCanvas_2";
      this.ResizeBehavior = NxtControl.GuiFramework.ResizeBehavior.Standard;
      this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
                  this.header1,
                 
                        siblingsPanel,
      childrenPanel,
      this.logo,
      exit1,
      login1,
      currentUser1,
      runtimeConnection1,
      this.canvasTopologyNavigation,

                  this.canvasTopologySeparator1,
				  this.canvasTopologySeparator2,
				  this.workArea});
      this.Size = new System.Drawing.Size(1366, 768);
    }
    
    private NxtControl.GuiFramework.Rectangle header1;
	private NxtControl.GuiFramework.CanvasTopologyPanel siblingsPanel;
	private NxtControl.GuiFramework.CanvasTopologyPanel childrenPanel;
private NxtControl.GuiFramework.Rectangle logo;
private NxtControl.GuiFramework.Exit exit1;
private NxtControl.GuiFramework.Login login1;
private NxtControl.GuiFramework.CurrentUser currentUser1;
private NxtControl.GuiFramework.RuntimeConnection runtimeConnection1;
 private NxtControl.GuiFramework.CanvasTopologyRose canvasTopologyNavigation;

    private NxtControl.GuiFramework.WorkAreaControl workArea;    
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator1;
    private NxtControl.GuiFramework.CanvasTopologySeparator canvasTopologySeparator2; 
    #endregion
  }
}
