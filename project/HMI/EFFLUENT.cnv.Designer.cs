/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/21/2026
 * Time: 12:45 AM
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
	/// Summary description for EFFLUENT.
	/// </summary>
	partial class EFFLUENT
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.changeCanvasButton2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton3 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.changeCanvasButton4 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.EFFLUENT_1 = new SE.Nereda.Symbols.NeredaEffluent.sEffluent();
			this.EFFLUENT_2 = new SE.Nereda.Symbols.NeredaEffluent.sSensors();
			this.sDefault1 = new SE.Nereda.Symbols.EffluentLogic.sDefault();
			this.sDefault5 = new SE.Nereda.Symbols.ResetValvesManager.sDefault();
			// 
			// changeCanvasButton2
			// 
			this.changeCanvasButton2.Bounds = new NxtControl.Drawing.RectF(((float)(1176D)), ((float)(632D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton2.CanvasName = "SLUDGE_BUFFER";
			this.changeCanvasButton2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton2.Name = "changeCanvasButton2";
			this.changeCanvasButton2.Text = "SLUDGE BUFFER";
			// 
			// changeCanvasButton3
			// 
			this.changeCanvasButton3.Bounds = new NxtControl.Drawing.RectF(((float)(1176D)), ((float)(552D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton3.CanvasName = "CALAMITY";
			this.changeCanvasButton3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton3.Name = "changeCanvasButton3";
			this.changeCanvasButton3.Text = "RWZI WEERT";
			// 
			// changeCanvasButton4
			// 
			this.changeCanvasButton4.Bounds = new NxtControl.Drawing.RectF(((float)(1176D)), ((float)(472D)), ((float)(168D)), ((float)(32D)));
			this.changeCanvasButton4.CanvasName = "INFLUENT_FEED";
			this.changeCanvasButton4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.changeCanvasButton4.Name = "changeCanvasButton4";
			this.changeCanvasButton4.Text = "INFLUENT FEED";
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(1128D)), ((float)(480D)), ((float)(32D)), ((float)(16D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1128D, 496D),
			new NxtControl.Drawing.PointF(1128D, 480D),
			new NxtControl.Drawing.PointF(1160D, 488D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(1128D)), ((float)(562D)), ((float)(32D)), ((float)(16D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1128D, 578D),
			new NxtControl.Drawing.PointF(1128D, 562D),
			new NxtControl.Drawing.PointF(1160D, 570D)});
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(1128D)), ((float)(640D)), ((float)(32D)), ((float)(16D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(245)), ((byte)(245)), ((byte)(245))));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1128D, 656D),
			new NxtControl.Drawing.PointF(1128D, 640D),
			new NxtControl.Drawing.PointF(1160D, 648D)});
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(880D)), ((float)(488D)), ((float)(328D)), ((float)(0D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(880D, 488D),
			new NxtControl.Drawing.PointF(1208D, 488D)});
			this.pipe1.Width = 10;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(880D)), ((float)(648D)), ((float)(328D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(880D, 648D),
			new NxtControl.Drawing.PointF(1208D, 648D)});
			this.pipe2.Width = 10;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(880D)), ((float)(570D)), ((float)(300D)), ((float)(0D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(880D, 570D),
			new NxtControl.Drawing.PointF(1180D, 570D)});
			this.pipe3.Width = 10;
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
			// EFFLUENT_1
			// 
			this.EFFLUENT_1.BeginInit();
			this.EFFLUENT_1._iCV001 = "NVPP 001 a-- 011";
			this.EFFLUENT_1._iCV002 = "NVPP 001 a-- 002";
			this.EFFLUENT_1._iCV003 = "NVPP 001 a-- 018";
			this.EFFLUENT_1._iCV012 = "NVPP 001 a-- 012";
			this.EFFLUENT_1._iCV014 = "NVPP 001 a-- 014";
			this.EFFLUENT_1._iFT001 = "NVPP 001 ft 002";
			this.EFFLUENT_1._iFT002 = "NVPP 001 ft 003";
			this.EFFLUENT_1._iPUMP001 = "NVPP 001 ctp 002";
			this.EFFLUENT_1._iPUMP002 = "NVPP 001 ctp 003";
			this.EFFLUENT_1._iTANKNAME = "Effluent +/- 37m²";
			this.EFFLUENT_1._iXV001 = "NVPP 001 a-- 021";
			this.EFFLUENT_1._iXV002 = "NVPP 001 a-- 010";
			this.EFFLUENT_1._iXV003 = "NVPP 001 a-- 032";
			this.EFFLUENT_1._iXV004 = "NVPP 001 a-- 012";
			this.EFFLUENT_1._iXV005 = "NVPP 001 a-- 064";
			this.EFFLUENT_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 16D, 56D);
			this.EFFLUENT_1.Name = "EFFLUENT_1";
			this.EFFLUENT_1.SecurityToken = ((uint)(4294967295u));
			this.EFFLUENT_1.TagName = "F2F66466CB372A96";
			this.EFFLUENT_1.EndInit();
			// 
			// EFFLUENT_2
			// 
			this.EFFLUENT_2.BeginInit();
			this.EFFLUENT_2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 544D, 64D);
			this.EFFLUENT_2.Name = "EFFLUENT_2";
			this.EFFLUENT_2.SecurityToken = ((uint)(4294967295u));
			this.EFFLUENT_2.TagName = "F2F66466CB372A96";
			this.EFFLUENT_2.EndInit();
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 976D, 8D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.TagName = "F2F66466CB372A96.EffluentLogic";
			this.sDefault1.EndInit();
			// 
			// sDefault5
			// 
			this.sDefault5.BeginInit();
			this.sDefault5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1200D, 224D);
			this.sDefault5.Name = "sDefault5";
			this.sDefault5.SecurityToken = ((uint)(4294967295u));
			this.sDefault5.TagName = "F2F66466CB372A96.Actuators.ResetAllValves";
			this.sDefault5.EndInit();
			// 
			// EFFLUENT
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe3,
			this.pipe2,
			this.pipe1,
			this.changeCanvasButton2,
			this.changeCanvasButton3,
			this.changeCanvasButton4,
			this.polygon2,
			this.polygon3,
			this.polygon4,
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.EFFLUENT_1,
			this.EFFLUENT_2,
			this.sDefault1,
			this.sDefault5});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton2;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton3;
		private NxtControl.GuiFramework.ChangeCanvasButton changeCanvasButton4;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe3;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.NeredaEffluent.sEffluent EFFLUENT_1;
		private SE.Nereda.Symbols.NeredaEffluent.sSensors EFFLUENT_2;
		private SE.Nereda.Symbols.EffluentLogic.sDefault sDefault1;
		private SE.Nereda.Symbols.ResetValvesManager.sDefault sDefault5;
		#endregion
	}
}
