/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 3:50 PM
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
	/// Summary description for OVER_VIEW.
	/// </summary>
	partial class OVER_VIEW
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.NVPP_REACTOR01 = new SE.Nereda.Symbols.NeredaReactor.sReactor3();
			this.EFFLUENT = new SE.Nereda.Symbols.NeredaEffluent.sEffluent2();
			this.NVPP_REACTOR02 = new SE.Nereda.Symbols.NeredaReactor.sReactor3();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.MCCPower = new SE.Nereda.Symbols.MCCPower.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.sHiHiLevelCalamity1 = new SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.INFLUENT_FEED = new SE.Nereda.Symbols.InfluentFeed.sInfluentFeed();
			this.pipe14 = new NxtControl.GuiFramework.Pipe();
			this.pipe31 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.pipe34 = new NxtControl.GuiFramework.Pipe();
			this.pipe33 = new NxtControl.GuiFramework.Pipe();
			this.pipe5 = new NxtControl.GuiFramework.Pipe();
			this.pipe26 = new NxtControl.GuiFramework.Pipe();
			this.pipe25 = new NxtControl.GuiFramework.Pipe();
			this.pipe24 = new NxtControl.GuiFramework.Pipe();
			this.pipe23 = new NxtControl.GuiFramework.Pipe();
			this.pipe32 = new NxtControl.GuiFramework.Pipe();
			this.pipe13 = new NxtControl.GuiFramework.Pipe();
			this.pipe12 = new NxtControl.GuiFramework.Pipe();
			this.pipe11 = new NxtControl.GuiFramework.Pipe();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.pipe37 = new NxtControl.GuiFramework.Pipe();
			this.PUMP001 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.pipe8 = new NxtControl.GuiFramework.Pipe();
			this.pipe9 = new NxtControl.GuiFramework.Pipe();
			this.pipe10 = new NxtControl.GuiFramework.Pipe();
			this.group3 = new NxtControl.GuiFramework.Group();
			this.group4 = new NxtControl.GuiFramework.Group();
			this.pipe15 = new NxtControl.GuiFramework.Pipe();
			this.pipe17 = new NxtControl.GuiFramework.Pipe();
			this.pipe18 = new NxtControl.GuiFramework.Pipe();
			this.pipe7 = new NxtControl.GuiFramework.Pipe();
			this.pipe19 = new NxtControl.GuiFramework.Pipe();
			this.pipe20 = new NxtControl.GuiFramework.Pipe();
			this.pipe21 = new NxtControl.GuiFramework.Pipe();
			this.pipe22 = new NxtControl.GuiFramework.Pipe();
			this.group5 = new NxtControl.GuiFramework.Group();
			this.group6 = new NxtControl.GuiFramework.Group();
			this.pipe27 = new NxtControl.GuiFramework.Pipe();
			this.group8 = new NxtControl.GuiFramework.Group();
			this.pipe28 = new NxtControl.GuiFramework.Pipe();
			this.group7 = new NxtControl.GuiFramework.Group();
			this.pipe29 = new NxtControl.GuiFramework.Pipe();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.pipe30 = new NxtControl.GuiFramework.Pipe();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.pipe35 = new NxtControl.GuiFramework.Pipe();
			this.polygon9 = new NxtControl.GuiFramework.Polygon();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.polygon10 = new NxtControl.GuiFramework.Polygon();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.polygon8 = new NxtControl.GuiFramework.Polygon();
			this.polygon11 = new NxtControl.GuiFramework.Polygon();
			this.polygon12 = new NxtControl.GuiFramework.Polygon();
			this.polygon13 = new NxtControl.GuiFramework.Polygon();
			this.polygon14 = new NxtControl.GuiFramework.Polygon();
			this.polygon15 = new NxtControl.GuiFramework.Polygon();
			this.polygon16 = new NxtControl.GuiFramework.Polygon();
			this.polygon17 = new NxtControl.GuiFramework.Polygon();
			this.polygon18 = new NxtControl.GuiFramework.Polygon();
			this.pipe36 = new NxtControl.GuiFramework.Pipe();
			this.polygon19 = new NxtControl.GuiFramework.Polygon();
			this.polygon20 = new NxtControl.GuiFramework.Polygon();
			this.polygon21 = new NxtControl.GuiFramework.Polygon();
			this.polygon22 = new NxtControl.GuiFramework.Polygon();
			this.sPump1 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.sPump3 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.sPump4 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.pipe16 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.pipe6 = new NxtControl.GuiFramework.Pipe();
			this.sPump5 = new SE.Nereda.Symbols.Motor_VS.sPump();
			this.EFFLUENT_1 = new SE.Nereda.Symbols.NeredaEffluent.sCalamity3D();
			this.pipe38 = new NxtControl.GuiFramework.Pipe();
			this.polygon23 = new NxtControl.GuiFramework.Polygon();
			// 
			// NVPP_REACTOR01
			// 
			this.NVPP_REACTOR01.BeginInit();
			this.NVPP_REACTOR01._iREACTOR = "REACTOR 01";
			this.NVPP_REACTOR01.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.51428571428571423D, 0D, 0D, 0.51428571428571435D, 472D, 72D);
			this.NVPP_REACTOR01.Name = "NVPP_REACTOR01";
			this.NVPP_REACTOR01.SecurityToken = ((uint)(4294967295u));
			this.NVPP_REACTOR01.TagName = "D32FABF3E7C17DE2";
			this.NVPP_REACTOR01.Click += new System.EventHandler(this.NVPP_REACTOR01Click);
			this.NVPP_REACTOR01.EndInit();
			// 
			// EFFLUENT
			// 
			this.EFFLUENT.BeginInit();
			this.EFFLUENT._iEFFLUENT = "EFFLUENT";
			this.EFFLUENT.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.51428571428571423D, 0D, 0D, 0.51470588235294112D, 288D, 72D);
			this.EFFLUENT.Name = "EFFLUENT";
			this.EFFLUENT.SecurityToken = ((uint)(4294967295u));
			this.EFFLUENT.TagName = "F2F66466CB372A96";
			this.EFFLUENT.Click += new System.EventHandler(this.EFFLUENTClick);
			this.EFFLUENT.EndInit();
			// 
			// NVPP_REACTOR02
			// 
			this.NVPP_REACTOR02.BeginInit();
			this.NVPP_REACTOR02._iREACTOR = "REACTOR 2";
			this.NVPP_REACTOR02.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.51428571428571423D, 0D, 0D, 0.51470588235294112D, 720D, 72D);
			this.NVPP_REACTOR02.Name = "NVPP_REACTOR02";
			this.NVPP_REACTOR02.SecurityToken = ((uint)(4294967295u));
			this.NVPP_REACTOR02.TagName = "B553EA539882D2E1";
			this.NVPP_REACTOR02.Click += new System.EventHandler(this.NVPP_REACTOR02Click);
			this.NVPP_REACTOR02.EndInit();
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
			// INFLUENT_FEED
			// 
			this.INFLUENT_FEED.BeginInit();
			this.INFLUENT_FEED._iINFLUENT = "INFLUENT FEED";
			this.INFLUENT_FEED.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.51428571428571423D, 0D, 0D, 0.51470588235294112D, 72D, 72D);
			this.INFLUENT_FEED.Name = "INFLUENT_FEED";
			this.INFLUENT_FEED.SecurityToken = ((uint)(4294967295u));
			this.INFLUENT_FEED.TagName = "2098DAF96A66AD0A";
			this.INFLUENT_FEED.Click += new System.EventHandler(this.INFLUENT_FEEDClick);
			this.INFLUENT_FEED.EndInit();
			// 
			// pipe14
			// 
			this.pipe14.Bounds = new NxtControl.Drawing.RectF(((float)(712D)), ((float)(352D)), ((float)(8D)), ((float)(0D)));
			this.pipe14.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe14.Name = "pipe14";
			this.pipe14.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe14.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(712D, 352D),
			new NxtControl.Drawing.PointF(720D, 352D)});
			this.pipe14.Width = 12;
			// 
			// pipe31
			// 
			this.pipe31.Bounds = new NxtControl.Drawing.RectF(((float)(648D)), ((float)(528D)), ((float)(24D)), ((float)(16D)));
			this.pipe31.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe31.Name = "pipe31";
			this.pipe31.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe31.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(648D, 544D),
			new NxtControl.Drawing.PointF(672D, 544D),
			new NxtControl.Drawing.PointF(664D, 544D),
			new NxtControl.Drawing.PointF(664D, 528D)});
			this.pipe31.Width = 12;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(920D)), ((float)(544D)), ((float)(8D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(920D, 544D),
			new NxtControl.Drawing.PointF(928D, 544D)});
			this.pipe2.Width = 12;
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(1144D)), ((float)(528D)), ((float)(24D)), ((float)(16D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1144D, 544D),
			new NxtControl.Drawing.PointF(1168D, 544D),
			new NxtControl.Drawing.PointF(1160D, 544D),
			new NxtControl.Drawing.PointF(1160D, 528D)});
			this.pipe4.Width = 12;
			// 
			// pipe34
			// 
			this.pipe34.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(480D)), ((float)(0D)), ((float)(8D)));
			this.pipe34.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe34.Name = "pipe34";
			this.pipe34.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe34.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 480D),
			new NxtControl.Drawing.PointF(40D, 488D)});
			this.pipe34.Width = 12;
			// 
			// pipe33
			// 
			this.pipe33.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(456D)), ((float)(16D)), ((float)(24D)));
			this.pipe33.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe33.Name = "pipe33";
			this.pipe33.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe33.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 456D),
			new NxtControl.Drawing.PointF(40D, 480D),
			new NxtControl.Drawing.PointF(40D, 472D),
			new NxtControl.Drawing.PointF(56D, 472D)});
			this.pipe33.Width = 12;
			// 
			// pipe5
			// 
			this.pipe5.Bounds = new NxtControl.Drawing.RectF(((float)(1168D)), ((float)(544D)), ((float)(8D)), ((float)(0D)));
			this.pipe5.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe5.Name = "pipe5";
			this.pipe5.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1168D, 544D),
			new NxtControl.Drawing.PointF(1176D, 544D)});
			this.pipe5.Width = 12;
			// 
			// pipe26
			// 
			this.pipe26.Bounds = new NxtControl.Drawing.RectF(((float)(888D)), ((float)(440D)), ((float)(8D)), ((float)(0D)));
			this.pipe26.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe26.Name = "pipe26";
			this.pipe26.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe26.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(888D, 440D),
			new NxtControl.Drawing.PointF(896D, 440D)});
			this.pipe26.Width = 12;
			// 
			// pipe25
			// 
			this.pipe25.Bounds = new NxtControl.Drawing.RectF(((float)(864D)), ((float)(424D)), ((float)(24D)), ((float)(16D)));
			this.pipe25.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe25.Name = "pipe25";
			this.pipe25.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe25.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(864D, 440D),
			new NxtControl.Drawing.PointF(888D, 440D),
			new NxtControl.Drawing.PointF(880D, 440D),
			new NxtControl.Drawing.PointF(880D, 424D)});
			this.pipe25.Width = 12;
			// 
			// pipe24
			// 
			this.pipe24.Bounds = new NxtControl.Drawing.RectF(((float)(640D)), ((float)(440D)), ((float)(8D)), ((float)(0D)));
			this.pipe24.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe24.Name = "pipe24";
			this.pipe24.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe24.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(640D, 440D),
			new NxtControl.Drawing.PointF(648D, 440D)});
			this.pipe24.Width = 12;
			// 
			// pipe23
			// 
			this.pipe23.Bounds = new NxtControl.Drawing.RectF(((float)(616D)), ((float)(424D)), ((float)(24D)), ((float)(16D)));
			this.pipe23.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe23.Name = "pipe23";
			this.pipe23.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe23.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(616D, 440D),
			new NxtControl.Drawing.PointF(640D, 440D),
			new NxtControl.Drawing.PointF(632D, 440D),
			new NxtControl.Drawing.PointF(632D, 424D)});
			this.pipe23.Width = 12;
			// 
			// pipe32
			// 
			this.pipe32.Bounds = new NxtControl.Drawing.RectF(((float)(672D)), ((float)(544D)), ((float)(8D)), ((float)(0D)));
			this.pipe32.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe32.Name = "pipe32";
			this.pipe32.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe32.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(672D, 544D),
			new NxtControl.Drawing.PointF(680D, 544D)});
			this.pipe32.Width = 12;
			// 
			// pipe13
			// 
			this.pipe13.Bounds = new NxtControl.Drawing.RectF(((float)(688D)), ((float)(336D)), ((float)(24D)), ((float)(16D)));
			this.pipe13.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe13.Name = "pipe13";
			this.pipe13.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe13.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 352D),
			new NxtControl.Drawing.PointF(712D, 352D),
			new NxtControl.Drawing.PointF(704D, 352D),
			new NxtControl.Drawing.PointF(704D, 336D)});
			this.pipe13.Width = 12;
			// 
			// pipe12
			// 
			this.pipe12.Bounds = new NxtControl.Drawing.RectF(((float)(464D)), ((float)(352D)), ((float)(8D)), ((float)(0D)));
			this.pipe12.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe12.Name = "pipe12";
			this.pipe12.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe12.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(464D, 352D),
			new NxtControl.Drawing.PointF(472D, 352D)});
			this.pipe12.Width = 12;
			// 
			// pipe11
			// 
			this.pipe11.Bounds = new NxtControl.Drawing.RectF(((float)(440D)), ((float)(336D)), ((float)(24D)), ((float)(16D)));
			this.pipe11.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe11.Name = "pipe11";
			this.pipe11.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe11.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(440D, 352D),
			new NxtControl.Drawing.PointF(464D, 352D),
			new NxtControl.Drawing.PointF(456D, 352D),
			new NxtControl.Drawing.PointF(456D, 336D)});
			this.pipe11.Width = 12;
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(896D)), ((float)(528D)), ((float)(24D)), ((float)(16D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(896D, 544D),
			new NxtControl.Drawing.PointF(920D, 544D),
			new NxtControl.Drawing.PointF(912D, 544D),
			new NxtControl.Drawing.PointF(912D, 528D)});
			this.pipe1.Width = 12;
			// 
			// pipe37
			// 
			this.pipe37.Bounds = new NxtControl.Drawing.RectF(((float)(1256D)), ((float)(328D)), ((float)(48D)), ((float)(0D)));
			this.pipe37.InnerColor = new NxtControl.Drawing.Color(((byte)(183)), ((byte)(117)), ((byte)(64)));
			this.pipe37.Name = "pipe37";
			this.pipe37.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe37.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1256D, 328D),
			new NxtControl.Drawing.PointF(1304D, 328D)});
			this.pipe37.Width = 8;
			// 
			// PUMP001
			// 
			this.PUMP001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.PUMP001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PUMP001.Location = new NxtControl.Drawing.PointF(166D, 664D);
			this.PUMP001.Name = "PUMP001";
			this.PUMP001.Text = "NVPP 001 sbp 001";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText10.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText10.Location = new NxtControl.Drawing.PointF(454D, 664D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "NVPP 001 ctp 002";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText11.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText11.Location = new NxtControl.Drawing.PointF(310D, 664D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "NVPP 001 ctp 001";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText4.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText4.Location = new NxtControl.Drawing.PointF(590D, 664D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "NVPP 001 BL 001";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText5.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText5.Location = new NxtControl.Drawing.PointF(710D, 664D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "NVPP 001 BL 002";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText6.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText6.Location = new NxtControl.Drawing.PointF(838D, 664D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "NVPP 001 BL 003";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText7.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText7.Location = new NxtControl.Drawing.PointF(958D, 664D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "NVPP 001 BL 004";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText8.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText8.Location = new NxtControl.Drawing.PointF(1086D, 664D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "NVPP 001 BL 005";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText9.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText9.Location = new NxtControl.Drawing.PointF(1206D, 664D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "NVPP 001 BL 006";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText12.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText12.Location = new NxtControl.Drawing.PointF(8D, 664D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "NVPP 46 AP ifp 95 001";
			// 
			// pipe8
			// 
			this.pipe8.Bounds = new NxtControl.Drawing.RectF(((float)(136D)), ((float)(248D)), ((float)(832D)), ((float)(136D)));
			this.pipe8.InnerColor = new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128)));
			this.pipe8.Name = "pipe8";
			this.pipe8.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(136D, 384D),
			new NxtControl.Drawing.PointF(136D, 352D),
			new NxtControl.Drawing.PointF(952D, 352D),
			new NxtControl.Drawing.PointF(952D, 248D),
			new NxtControl.Drawing.PointF(968D, 248D)});
			this.pipe8.Width = 8;
			// 
			// pipe9
			// 
			this.pipe9.Bounds = new NxtControl.Drawing.RectF(((float)(704D)), ((float)(248D)), ((float)(16D)), ((float)(104D)));
			this.pipe9.InnerColor = new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128)));
			this.pipe9.Name = "pipe9";
			this.pipe9.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(720D, 248D),
			new NxtControl.Drawing.PointF(704D, 248D),
			new NxtControl.Drawing.PointF(704D, 352D)});
			this.pipe9.Width = 8;
			// 
			// pipe10
			// 
			this.pipe10.Bounds = new NxtControl.Drawing.RectF(((float)(456D)), ((float)(248D)), ((float)(16D)), ((float)(104D)));
			this.pipe10.InnerColor = new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128)));
			this.pipe10.Name = "pipe10";
			this.pipe10.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe10.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(472D, 248D),
			new NxtControl.Drawing.PointF(456D, 248D),
			new NxtControl.Drawing.PointF(456D, 352D)});
			this.pipe10.Width = 8;
			// 
			// group3
			// 
			this.group3.BeginInit();
			this.group3.Name = "group3";
			this.group3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe11,
			this.pipe12});
			this.group3.EndInit();
			// 
			// group4
			// 
			this.group4.BeginInit();
			this.group4.Name = "group4";
			this.group4.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe13,
			this.pipe14});
			this.group4.EndInit();
			// 
			// pipe15
			// 
			this.pipe15.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(168D)), ((float)(512D)), ((float)(432D)));
			this.pipe15.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(234)), ((byte)(240)));
			this.pipe15.Name = "pipe15";
			this.pipe15.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe15.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(520D, 600D),
			new NxtControl.Drawing.PointF(552D, 600D),
			new NxtControl.Drawing.PointF(552D, 544D),
			new NxtControl.Drawing.PointF(40D, 544D),
			new NxtControl.Drawing.PointF(40D, 168D),
			new NxtControl.Drawing.PointF(80D, 168D)});
			this.pipe15.Width = 8;
			// 
			// pipe17
			// 
			this.pipe17.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(472D)), ((float)(72D)), ((float)(152D)));
			this.pipe17.InnerColor = new NxtControl.Drawing.Color(((byte)(183)), ((byte)(117)), ((byte)(64)));
			this.pipe17.Name = "pipe17";
			this.pipe17.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe17.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(200D, 472D),
			new NxtControl.Drawing.PointF(224D, 472D),
			new NxtControl.Drawing.PointF(224D, 528D),
			new NxtControl.Drawing.PointF(232D, 536D),
			new NxtControl.Drawing.PointF(232D, 552D),
			new NxtControl.Drawing.PointF(224D, 560D),
			new NxtControl.Drawing.PointF(224D, 568D),
			new NxtControl.Drawing.PointF(160D, 568D),
			new NxtControl.Drawing.PointF(160D, 624D),
			new NxtControl.Drawing.PointF(208D, 624D)});
			this.pipe17.Width = 8;
			// 
			// pipe18
			// 
			this.pipe18.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(256D)), ((float)(288D)), ((float)(368D)));
			this.pipe18.InnerColor = new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212)));
			this.pipe18.Name = "pipe18";
			this.pipe18.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe18.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(80D, 256D),
			new NxtControl.Drawing.PointF(64D, 256D),
			new NxtControl.Drawing.PointF(64D, 328D),
			new NxtControl.Drawing.PointF(240D, 328D),
			new NxtControl.Drawing.PointF(240D, 336D),
			new NxtControl.Drawing.PointF(248D, 344D),
			new NxtControl.Drawing.PointF(248D, 360D),
			new NxtControl.Drawing.PointF(240D, 368D),
			new NxtControl.Drawing.PointF(240D, 416D),
			new NxtControl.Drawing.PointF(304D, 416D),
			new NxtControl.Drawing.PointF(304D, 528D),
			new NxtControl.Drawing.PointF(312D, 536D),
			new NxtControl.Drawing.PointF(312D, 552D),
			new NxtControl.Drawing.PointF(304D, 560D),
			new NxtControl.Drawing.PointF(304D, 624D),
			new NxtControl.Drawing.PointF(352D, 624D)});
			this.pipe18.Width = 8;
			// 
			// pipe7
			// 
			this.pipe7.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(64D)), ((float)(120D)), ((float)(536D)));
			this.pipe7.InnerColor = new NxtControl.Drawing.Color(((byte)(122)), ((byte)(78)), ((byte)(43)));
			this.pipe7.Name = "pipe7";
			this.pipe7.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(64D, 600D),
			new NxtControl.Drawing.PointF(104D, 600D),
			new NxtControl.Drawing.PointF(104D, 568D),
			new NxtControl.Drawing.PointF(16D, 568D),
			new NxtControl.Drawing.PointF(16D, 64D),
			new NxtControl.Drawing.PointF(136D, 64D),
			new NxtControl.Drawing.PointF(136D, 104D)});
			this.pipe7.Width = 8;
			// 
			// pipe19
			// 
			this.pipe19.Bounds = new NxtControl.Drawing.RectF(((float)(272D)), ((float)(248D)), ((float)(232D)), ((float)(376D)));
			this.pipe19.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(234)), ((byte)(240)));
			this.pipe19.Name = "pipe19";
			this.pipe19.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe19.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(288D, 248D),
			new NxtControl.Drawing.PointF(272D, 248D),
			new NxtControl.Drawing.PointF(272D, 336D),
			new NxtControl.Drawing.PointF(280D, 344D),
			new NxtControl.Drawing.PointF(280D, 360D),
			new NxtControl.Drawing.PointF(272D, 368D),
			new NxtControl.Drawing.PointF(272D, 392D),
			new NxtControl.Drawing.PointF(464D, 392D),
			new NxtControl.Drawing.PointF(464D, 528D),
			new NxtControl.Drawing.PointF(472D, 536D),
			new NxtControl.Drawing.PointF(472D, 552D),
			new NxtControl.Drawing.PointF(464D, 560D),
			new NxtControl.Drawing.PointF(464D, 624D),
			new NxtControl.Drawing.PointF(504D, 624D)});
			this.pipe19.Width = 8;
			// 
			// pipe20
			// 
			this.pipe20.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(248D)), ((float)(760D)), ((float)(352D)));
			this.pipe20.InnerColor = new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212)));
			this.pipe20.Name = "pipe20";
			this.pipe20.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe20.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 600D),
			new NxtControl.Drawing.PointF(408D, 600D),
			new NxtControl.Drawing.PointF(408D, 560D),
			new NxtControl.Drawing.PointF(416D, 552D),
			new NxtControl.Drawing.PointF(416D, 536D),
			new NxtControl.Drawing.PointF(408D, 528D),
			new NxtControl.Drawing.PointF(408D, 440D),
			new NxtControl.Drawing.PointF(448D, 440D),
			new NxtControl.Drawing.PointF(456D, 432D),
			new NxtControl.Drawing.PointF(472D, 432D),
			new NxtControl.Drawing.PointF(480D, 440D),
			new NxtControl.Drawing.PointF(1128D, 440D),
			new NxtControl.Drawing.PointF(1128D, 248D),
			new NxtControl.Drawing.PointF(1112D, 248D)});
			this.pipe20.Width = 8;
			// 
			// pipe21
			// 
			this.pipe21.Bounds = new NxtControl.Drawing.RectF(((float)(616D)), ((float)(248D)), ((float)(24D)), ((float)(192D)));
			this.pipe21.InnerColor = new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212)));
			this.pipe21.Name = "pipe21";
			this.pipe21.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe21.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(616D, 248D),
			new NxtControl.Drawing.PointF(632D, 248D),
			new NxtControl.Drawing.PointF(632D, 336D),
			new NxtControl.Drawing.PointF(640D, 344D),
			new NxtControl.Drawing.PointF(640D, 360D),
			new NxtControl.Drawing.PointF(632D, 368D),
			new NxtControl.Drawing.PointF(632D, 440D)});
			this.pipe21.Width = 8;
			// 
			// pipe22
			// 
			this.pipe22.Bounds = new NxtControl.Drawing.RectF(((float)(864D)), ((float)(248D)), ((float)(24D)), ((float)(192D)));
			this.pipe22.InnerColor = new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212)));
			this.pipe22.Name = "pipe22";
			this.pipe22.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe22.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(864D, 248D),
			new NxtControl.Drawing.PointF(880D, 248D),
			new NxtControl.Drawing.PointF(880D, 336D),
			new NxtControl.Drawing.PointF(888D, 344D),
			new NxtControl.Drawing.PointF(888D, 360D),
			new NxtControl.Drawing.PointF(880D, 368D),
			new NxtControl.Drawing.PointF(880D, 440D)});
			this.pipe22.Width = 8;
			// 
			// group5
			// 
			this.group5.BeginInit();
			this.group5.Name = "group5";
			this.group5.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe23,
			this.pipe24});
			this.group5.EndInit();
			// 
			// group6
			// 
			this.group6.BeginInit();
			this.group6.Name = "group6";
			this.group6.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe25,
			this.pipe26});
			this.group6.EndInit();
			// 
			// pipe27
			// 
			this.pipe27.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(472D)), ((float)(24D)), ((float)(0D)));
			this.pipe27.InnerColor = new NxtControl.Drawing.Color(((byte)(210)), ((byte)(234)), ((byte)(240)));
			this.pipe27.Name = "pipe27";
			this.pipe27.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe27.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(64D, 472D),
			new NxtControl.Drawing.PointF(40D, 472D)});
			this.pipe27.Width = 8;
			// 
			// group8
			// 
			this.group8.BeginInit();
			this.group8.Name = "group8";
			this.group8.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe33,
			this.pipe34});
			this.group8.EndInit();
			// 
			// pipe28
			// 
			this.pipe28.Bounds = new NxtControl.Drawing.RectF(((float)(600D)), ((float)(72D)), ((float)(72D)), ((float)(472D)));
			this.pipe28.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe28.Name = "pipe28";
			this.pipe28.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe28.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(600D, 96D),
			new NxtControl.Drawing.PointF(600D, 72D),
			new NxtControl.Drawing.PointF(664D, 72D),
			new NxtControl.Drawing.PointF(664D, 336D),
			new NxtControl.Drawing.PointF(672D, 344D),
			new NxtControl.Drawing.PointF(672D, 360D),
			new NxtControl.Drawing.PointF(664D, 368D),
			new NxtControl.Drawing.PointF(664D, 544D)});
			this.pipe28.Width = 8;
			// 
			// group7
			// 
			this.group7.BeginInit();
			this.group7.Name = "group7";
			this.group7.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe31,
			this.pipe32});
			this.group7.EndInit();
			// 
			// pipe29
			// 
			this.pipe29.Bounds = new NxtControl.Drawing.RectF(((float)(848D)), ((float)(72D)), ((float)(72D)), ((float)(472D)));
			this.pipe29.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe29.Name = "pipe29";
			this.pipe29.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe29.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(848D, 96D),
			new NxtControl.Drawing.PointF(848D, 72D),
			new NxtControl.Drawing.PointF(912D, 72D),
			new NxtControl.Drawing.PointF(912D, 336D),
			new NxtControl.Drawing.PointF(920D, 344D),
			new NxtControl.Drawing.PointF(920D, 360D),
			new NxtControl.Drawing.PointF(912D, 368D),
			new NxtControl.Drawing.PointF(912D, 544D)});
			this.pipe29.Width = 8;
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe1,
			this.pipe2});
			this.group1.EndInit();
			// 
			// pipe30
			// 
			this.pipe30.Bounds = new NxtControl.Drawing.RectF(((float)(1096D)), ((float)(72D)), ((float)(64D)), ((float)(472D)));
			this.pipe30.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe30.Name = "pipe30";
			this.pipe30.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe30.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1096D, 96D),
			new NxtControl.Drawing.PointF(1096D, 72D),
			new NxtControl.Drawing.PointF(1160D, 72D),
			new NxtControl.Drawing.PointF(1160D, 544D)});
			this.pipe30.Width = 8;
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe4,
			this.pipe5});
			this.group2.EndInit();
			// 
			// pipe35
			// 
			this.pipe35.Bounds = new NxtControl.Drawing.RectF(((float)(232D)), ((float)(248D)), ((float)(1112D)), ((float)(352D)));
			this.pipe35.InnerColor = new NxtControl.Drawing.Color(((byte)(183)), ((byte)(117)), ((byte)(64)));
			this.pipe35.Name = "pipe35";
			this.pipe35.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe35.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(232D, 600D),
			new NxtControl.Drawing.PointF(264D, 600D),
			new NxtControl.Drawing.PointF(264D, 560D),
			new NxtControl.Drawing.PointF(272D, 552D),
			new NxtControl.Drawing.PointF(272D, 536D),
			new NxtControl.Drawing.PointF(264D, 528D),
			new NxtControl.Drawing.PointF(264D, 480D),
			new NxtControl.Drawing.PointF(288D, 480D),
			new NxtControl.Drawing.PointF(296D, 472D),
			new NxtControl.Drawing.PointF(312D, 472D),
			new NxtControl.Drawing.PointF(320D, 480D),
			new NxtControl.Drawing.PointF(392D, 480D),
			new NxtControl.Drawing.PointF(400D, 472D),
			new NxtControl.Drawing.PointF(416D, 472D),
			new NxtControl.Drawing.PointF(424D, 480D),
			new NxtControl.Drawing.PointF(448D, 480D),
			new NxtControl.Drawing.PointF(456D, 472D),
			new NxtControl.Drawing.PointF(472D, 472D),
			new NxtControl.Drawing.PointF(480D, 480D),
			new NxtControl.Drawing.PointF(648D, 480D),
			new NxtControl.Drawing.PointF(656D, 472D),
			new NxtControl.Drawing.PointF(672D, 472D),
			new NxtControl.Drawing.PointF(680D, 480D),
			new NxtControl.Drawing.PointF(896D, 480D),
			new NxtControl.Drawing.PointF(904D, 472D),
			new NxtControl.Drawing.PointF(920D, 472D),
			new NxtControl.Drawing.PointF(928D, 480D),
			new NxtControl.Drawing.PointF(1144D, 480D),
			new NxtControl.Drawing.PointF(1152D, 472D),
			new NxtControl.Drawing.PointF(1168D, 472D),
			new NxtControl.Drawing.PointF(1176D, 480D),
			new NxtControl.Drawing.PointF(1344D, 480D),
			new NxtControl.Drawing.PointF(1344D, 248D),
			new NxtControl.Drawing.PointF(1320D, 248D)});
			this.pipe35.Width = 8;
			// 
			// polygon9
			// 
			this.polygon9.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon9.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212))));
			this.polygon9.Closed = true;
			this.polygon9.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon9.Name = "polygon9";
			this.polygon9.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72D, 288D),
			new NxtControl.Drawing.PointF(56D, 288D),
			new NxtControl.Drawing.PointF(64D, 320D)});
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(264D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(234)), ((byte)(240))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(280D, 288D),
			new NxtControl.Drawing.PointF(264D, 288D),
			new NxtControl.Drawing.PointF(272D, 320D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(448D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(464D, 288D),
			new NxtControl.Drawing.PointF(448D, 288D),
			new NxtControl.Drawing.PointF(456D, 320D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(696D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(712D, 288D),
			new NxtControl.Drawing.PointF(696D, 288D),
			new NxtControl.Drawing.PointF(704D, 320D)});
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(944D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(960D, 288D),
			new NxtControl.Drawing.PointF(944D, 288D),
			new NxtControl.Drawing.PointF(952D, 320D)});
			// 
			// polygon10
			// 
			this.polygon10.Bounds = new NxtControl.Drawing.RectF(((float)(1120D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon10.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212))));
			this.polygon10.Closed = true;
			this.polygon10.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon10.Name = "polygon10";
			this.polygon10.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1128D, 288D),
			new NxtControl.Drawing.PointF(1120D, 320D),
			new NxtControl.Drawing.PointF(1136D, 320D)});
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(872D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212))));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(880D, 288D),
			new NxtControl.Drawing.PointF(872D, 320D),
			new NxtControl.Drawing.PointF(888D, 320D)});
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(624D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212))));
			this.polygon6.Closed = true;
			this.polygon6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(632D, 288D),
			new NxtControl.Drawing.PointF(624D, 320D),
			new NxtControl.Drawing.PointF(640D, 320D)});
			// 
			// polygon7
			// 
			this.polygon7.Bounds = new NxtControl.Drawing.RectF(((float)(1336D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon7.Closed = true;
			this.polygon7.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon7.Name = "polygon7";
			this.polygon7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1344D, 288D),
			new NxtControl.Drawing.PointF(1336D, 320D),
			new NxtControl.Drawing.PointF(1352D, 320D)});
			// 
			// polygon8
			// 
			this.polygon8.Bounds = new NxtControl.Drawing.RectF(((float)(1152D)), ((float)(192D)), ((float)(16D)), ((float)(32D)));
			this.polygon8.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.polygon8.Closed = true;
			this.polygon8.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon8.Name = "polygon8";
			this.polygon8.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1160D, 192D),
			new NxtControl.Drawing.PointF(1152D, 224D),
			new NxtControl.Drawing.PointF(1168D, 224D)});
			// 
			// polygon11
			// 
			this.polygon11.Bounds = new NxtControl.Drawing.RectF(((float)(904D)), ((float)(192D)), ((float)(16D)), ((float)(32D)));
			this.polygon11.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.polygon11.Closed = true;
			this.polygon11.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon11.Name = "polygon11";
			this.polygon11.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(912D, 192D),
			new NxtControl.Drawing.PointF(904D, 224D),
			new NxtControl.Drawing.PointF(920D, 224D)});
			// 
			// polygon12
			// 
			this.polygon12.Bounds = new NxtControl.Drawing.RectF(((float)(656D)), ((float)(192D)), ((float)(16D)), ((float)(32D)));
			this.polygon12.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(186)), ((byte)(186)), ((byte)(186))));
			this.polygon12.Closed = true;
			this.polygon12.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon12.Name = "polygon12";
			this.polygon12.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(664D, 192D),
			new NxtControl.Drawing.PointF(656D, 224D),
			new NxtControl.Drawing.PointF(672D, 224D)});
			// 
			// polygon13
			// 
			this.polygon13.Bounds = new NxtControl.Drawing.RectF(((float)(776D)), ((float)(344D)), ((float)(32D)), ((float)(16D)));
			this.polygon13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon13.Closed = true;
			this.polygon13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon13.Name = "polygon13";
			this.polygon13.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(808D, 344D),
			new NxtControl.Drawing.PointF(808D, 360D),
			new NxtControl.Drawing.PointF(776D, 352D)});
			// 
			// polygon14
			// 
			this.polygon14.Bounds = new NxtControl.Drawing.RectF(((float)(776D)), ((float)(432D)), ((float)(32D)), ((float)(16D)));
			this.polygon14.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212))));
			this.polygon14.Closed = true;
			this.polygon14.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon14.Name = "polygon14";
			this.polygon14.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(808D, 440D),
			new NxtControl.Drawing.PointF(776D, 432D),
			new NxtControl.Drawing.PointF(776D, 448D)});
			// 
			// polygon15
			// 
			this.polygon15.Bounds = new NxtControl.Drawing.RectF(((float)(776D)), ((float)(472D)), ((float)(32D)), ((float)(16D)));
			this.polygon15.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon15.Closed = true;
			this.polygon15.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon15.Name = "polygon15";
			this.polygon15.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(808D, 480D),
			new NxtControl.Drawing.PointF(776D, 472D),
			new NxtControl.Drawing.PointF(776D, 488D)});
			// 
			// polygon16
			// 
			this.polygon16.Bounds = new NxtControl.Drawing.RectF(((float)(528D)), ((float)(344D)), ((float)(32D)), ((float)(16D)));
			this.polygon16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon16.Closed = true;
			this.polygon16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon16.Name = "polygon16";
			this.polygon16.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(560D, 344D),
			new NxtControl.Drawing.PointF(560D, 360D),
			new NxtControl.Drawing.PointF(528D, 352D)});
			// 
			// polygon17
			// 
			this.polygon17.Bounds = new NxtControl.Drawing.RectF(((float)(528D)), ((float)(432D)), ((float)(32D)), ((float)(16D)));
			this.polygon17.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(252)), ((byte)(230)), ((byte)(212))));
			this.polygon17.Closed = true;
			this.polygon17.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon17.Name = "polygon17";
			this.polygon17.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(560D, 440D),
			new NxtControl.Drawing.PointF(528D, 432D),
			new NxtControl.Drawing.PointF(528D, 448D)});
			// 
			// polygon18
			// 
			this.polygon18.Bounds = new NxtControl.Drawing.RectF(((float)(528D)), ((float)(472D)), ((float)(32D)), ((float)(16D)));
			this.polygon18.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon18.Closed = true;
			this.polygon18.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon18.Name = "polygon18";
			this.polygon18.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(560D, 480D),
			new NxtControl.Drawing.PointF(528D, 472D),
			new NxtControl.Drawing.PointF(528D, 488D)});
			// 
			// pipe36
			// 
			this.pipe36.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(624D)), ((float)(32D)), ((float)(0D)));
			this.pipe36.InnerColor = new NxtControl.Drawing.Color(((byte)(122)), ((byte)(78)), ((byte)(43)));
			this.pipe36.Name = "pipe36";
			this.pipe36.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe36.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 624D),
			new NxtControl.Drawing.PointF(8D, 624D)});
			this.pipe36.Width = 8;
			// 
			// polygon19
			// 
			this.polygon19.Bounds = new NxtControl.Drawing.RectF(((float)(216D)), ((float)(488D)), ((float)(16D)), ((float)(32D)));
			this.polygon19.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon19.Closed = true;
			this.polygon19.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon19.Name = "polygon19";
			this.polygon19.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(232D, 488D),
			new NxtControl.Drawing.PointF(216D, 488D),
			new NxtControl.Drawing.PointF(224D, 520D)});
			// 
			// polygon20
			// 
			this.polygon20.Bounds = new NxtControl.Drawing.RectF(((float)(1296D)), ((float)(320D)), ((float)(24D)), ((float)(16D)));
			this.polygon20.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(183)), ((byte)(117)), ((byte)(64))));
			this.polygon20.Closed = true;
			this.polygon20.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon20.Name = "polygon20";
			this.polygon20.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1320D, 328D),
			new NxtControl.Drawing.PointF(1296D, 320D),
			new NxtControl.Drawing.PointF(1296D, 336D)});
			// 
			// polygon21
			// 
			this.polygon21.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(504D)), ((float)(16D)), ((float)(32D)));
			this.polygon21.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(234)), ((byte)(240))));
			this.polygon21.Closed = true;
			this.polygon21.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon21.Name = "polygon21";
			this.polygon21.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(40D, 504D),
			new NxtControl.Drawing.PointF(32D, 536D),
			new NxtControl.Drawing.PointF(48D, 536D)});
			// 
			// polygon22
			// 
			this.polygon22.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(336D)), ((float)(16D)), ((float)(32D)));
			this.polygon22.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(122)), ((byte)(78)), ((byte)(43))));
			this.polygon22.Closed = true;
			this.polygon22.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon22.Name = "polygon22";
			this.polygon22.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 336D),
			new NxtControl.Drawing.PointF(8D, 368D),
			new NxtControl.Drawing.PointF(24D, 368D)});
			// 
			// sPump1
			// 
			this.sPump1.BeginInit();
			this.sPump1._iMotName = "Motor";
			this.sPump1._iUnit = "%";
			this.sPump1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 564D);
			this.sPump1.Name = "sPump1";
			this.sPump1.SecurityToken = ((uint)(4294967295u));
			this.sPump1.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.sPump1.TagName = "2098DAF96A66AD0A.Actuators.FeedInfluentPump01";
			this.sPump1.EndInit();
			// 
			// sPump3
			// 
			this.sPump3.BeginInit();
			this.sPump3._iMotName = "Motor";
			this.sPump3._iUnit = "%";
			this.sPump3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 312D, 564D);
			this.sPump3.Name = "sPump3";
			this.sPump3.SecurityToken = ((uint)(4294967295u));
			this.sPump3.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.sPump3.TagName = "2098DAF96A66AD0A.Actuators.FeedReactorPump01";
			this.sPump3.EndInit();
			// 
			// sPump4
			// 
			this.sPump4.BeginInit();
			this.sPump4._iMotName = "Motor";
			this.sPump4._iUnit = "%";
			this.sPump4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 460D, 564D);
			this.sPump4.Name = "sPump4";
			this.sPump4.SecurityToken = ((uint)(4294967295u));
			this.sPump4.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Hide;
			this.sPump4.TagName = "F2F66466CB372A96.Actuators.NVPP_001_ctp_002";
			this.sPump4.EndInit();
			// 
			// pipe16
			// 
			this.pipe16.Bounds = new NxtControl.Drawing.RectF(((float)(616D)), ((float)(544D)), ((float)(120D)), ((float)(56D)));
			this.pipe16.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe16.Name = "pipe16";
			this.pipe16.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe16.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(616D, 600D),
			new NxtControl.Drawing.PointF(616D, 544D),
			new NxtControl.Drawing.PointF(736D, 544D),
			new NxtControl.Drawing.PointF(736D, 600D)});
			this.pipe16.Width = 8;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(864D)), ((float)(544D)), ((float)(120D)), ((float)(56D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(864D, 600D),
			new NxtControl.Drawing.PointF(864D, 544D),
			new NxtControl.Drawing.PointF(984D, 544D),
			new NxtControl.Drawing.PointF(984D, 600D)});
			this.pipe3.Width = 8;
			// 
			// pipe6
			// 
			this.pipe6.Bounds = new NxtControl.Drawing.RectF(((float)(1112D)), ((float)(544D)), ((float)(120D)), ((float)(56D)));
			this.pipe6.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe6.Name = "pipe6";
			this.pipe6.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1112D, 600D),
			new NxtControl.Drawing.PointF(1112D, 544D),
			new NxtControl.Drawing.PointF(1232D, 544D),
			new NxtControl.Drawing.PointF(1232D, 600D)});
			this.pipe6.Width = 8;
			// 
			// sPump5
			// 
			this.sPump5.BeginInit();
			this.sPump5._iMotName = "Motor";
			this.sPump5._iUnit = "%";
			this.sPump5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1200D, 290D);
			this.sPump5.Name = "sPump5";
			this.sPump5.SecurityToken = ((uint)(4294967295u));
			this.sPump5.SymbolNameDisplay = SE.Nereda.Symbols.Motor_VS.sPump.SymbolNameDisplayOption.Show;
			this.sPump5.TagName = "F2F66466CB372A96.Actuators.NVPP_46_2_AP_lzp_95_001";
			this.sPump5.EndInit();
			// 
			// EFFLUENT_1
			// 
			this.EFFLUENT_1.BeginInit();
			this.EFFLUENT_1._iCALAMITY = "CALAMITY";
			this.EFFLUENT_1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.51428571428571423D, 0D, 0D, 0.5152439024390244D, 1184D, 112D);
			this.EFFLUENT_1.Name = "EFFLUENT_1";
			this.EFFLUENT_1.SecurityToken = ((uint)(4294967295u));
			this.EFFLUENT_1.TagName = "F2F66466CB372A96";
			this.EFFLUENT_1.Click += new System.EventHandler(this.EFFLUENT_1Click);
			this.EFFLUENT_1.EndInit();
			// 
			// pipe38
			// 
			this.pipe38.Bounds = new NxtControl.Drawing.RectF(((float)(1208D)), ((float)(270D)), ((float)(24D)), ((float)(80D)));
			this.pipe38.InnerColor = new NxtControl.Drawing.Color(((byte)(183)), ((byte)(117)), ((byte)(64)));
			this.pipe38.Name = "pipe38";
			this.pipe38.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe38.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1208D, 270D),
			new NxtControl.Drawing.PointF(1208D, 350D),
			new NxtControl.Drawing.PointF(1232D, 350D)});
			this.pipe38.Width = 8;
			// 
			// polygon23
			// 
			this.polygon23.Bounds = new NxtControl.Drawing.RectF(((float)(1200D)), ((float)(288D)), ((float)(16D)), ((float)(32D)));
			this.polygon23.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(247)), ((byte)(181)), ((byte)(128))));
			this.polygon23.Closed = true;
			this.polygon23.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon23.Name = "polygon23";
			this.polygon23.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1216D, 288D),
			new NxtControl.Drawing.PointF(1200D, 288D),
			new NxtControl.Drawing.PointF(1208D, 320D)});
			// 
			// OVER_VIEW
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe38,
			this.pipe15,
			this.pipe17,
			this.pipe27,
			this.pipe6,
			this.pipe3,
			this.pipe16,
			this.NVPP_REACTOR01,
			this.EFFLUENT,
			this.NVPP_REACTOR02,
			this.HeartBeat,
			this.MCCPower,
			this.Mode,
			this.sHiHiLevelCalamity1,
			this.OpenWebPage,
			this.INFLUENT_FEED,
			this.pipe37,
			this.PUMP001,
			this.freeText10,
			this.freeText11,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.freeText7,
			this.freeText8,
			this.freeText9,
			this.freeText12,
			this.pipe8,
			this.pipe9,
			this.pipe10,
			this.group3,
			this.group4,
			this.pipe18,
			this.pipe7,
			this.pipe19,
			this.pipe20,
			this.pipe21,
			this.pipe22,
			this.group5,
			this.group6,
			this.group8,
			this.pipe28,
			this.group7,
			this.pipe29,
			this.group1,
			this.pipe30,
			this.group2,
			this.pipe35,
			this.polygon9,
			this.polygon1,
			this.polygon2,
			this.polygon3,
			this.polygon4,
			this.polygon10,
			this.polygon5,
			this.polygon6,
			this.polygon7,
			this.polygon8,
			this.polygon11,
			this.polygon12,
			this.polygon13,
			this.polygon14,
			this.polygon15,
			this.polygon16,
			this.polygon17,
			this.polygon18,
			this.pipe36,
			this.polygon19,
			this.polygon20,
			this.polygon21,
			this.polygon22,
			this.sPump1,
			this.sPump3,
			this.sPump4,
			this.sPump5,
			this.EFFLUENT_1,
			this.polygon23});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.NeredaReactor.sReactor3 NVPP_REACTOR01;
		private SE.Nereda.Symbols.NeredaEffluent.sEffluent2 EFFLUENT;
		private SE.Nereda.Symbols.NeredaReactor.sReactor3 NVPP_REACTOR02;
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.MCCPower.sDefault MCCPower;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.Calamity.sHiHiLevelCalamity sHiHiLevelCalamity1;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private SE.Nereda.Symbols.InfluentFeed.sInfluentFeed INFLUENT_FEED;
		private NxtControl.GuiFramework.Pipe pipe14;
		private NxtControl.GuiFramework.Pipe pipe31;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.Pipe pipe4;
		private NxtControl.GuiFramework.Pipe pipe34;
		private NxtControl.GuiFramework.Pipe pipe33;
		private NxtControl.GuiFramework.Pipe pipe5;
		private NxtControl.GuiFramework.Pipe pipe26;
		private NxtControl.GuiFramework.Pipe pipe25;
		private NxtControl.GuiFramework.Pipe pipe24;
		private NxtControl.GuiFramework.Pipe pipe23;
		private NxtControl.GuiFramework.Pipe pipe32;
		private NxtControl.GuiFramework.Pipe pipe13;
		private NxtControl.GuiFramework.Pipe pipe12;
		private NxtControl.GuiFramework.Pipe pipe11;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Pipe pipe37;
		private NxtControl.GuiFramework.Pipe pipe16;
		private NxtControl.GuiFramework.FreeText PUMP001;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.Pipe pipe8;
		private NxtControl.GuiFramework.Pipe pipe9;
		private NxtControl.GuiFramework.Pipe pipe10;
		private NxtControl.GuiFramework.Group group3;
		private NxtControl.GuiFramework.Group group4;
		private NxtControl.GuiFramework.Pipe pipe15;
		private NxtControl.GuiFramework.Pipe pipe17;
		private NxtControl.GuiFramework.Pipe pipe18;
		private NxtControl.GuiFramework.Pipe pipe7;
		private NxtControl.GuiFramework.Pipe pipe19;
		private NxtControl.GuiFramework.Pipe pipe20;
		private NxtControl.GuiFramework.Pipe pipe21;
		private NxtControl.GuiFramework.Pipe pipe22;
		private NxtControl.GuiFramework.Group group5;
		private NxtControl.GuiFramework.Group group6;
		private NxtControl.GuiFramework.Pipe pipe27;
		private NxtControl.GuiFramework.Group group8;
		private NxtControl.GuiFramework.Pipe pipe28;
		private NxtControl.GuiFramework.Group group7;
		private NxtControl.GuiFramework.Pipe pipe29;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Pipe pipe30;
		private NxtControl.GuiFramework.Group group2;
		private NxtControl.GuiFramework.Pipe pipe35;
		private NxtControl.GuiFramework.Polygon polygon9;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Polygon polygon10;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.Polygon polygon7;
		private NxtControl.GuiFramework.Polygon polygon8;
		private NxtControl.GuiFramework.Polygon polygon11;
		private NxtControl.GuiFramework.Polygon polygon12;
		private NxtControl.GuiFramework.Polygon polygon13;
		private NxtControl.GuiFramework.Polygon polygon14;
		private NxtControl.GuiFramework.Polygon polygon15;
		private NxtControl.GuiFramework.Polygon polygon16;
		private NxtControl.GuiFramework.Polygon polygon17;
		private NxtControl.GuiFramework.Polygon polygon18;
		private NxtControl.GuiFramework.Pipe pipe36;
		private NxtControl.GuiFramework.Polygon polygon19;
		private NxtControl.GuiFramework.Polygon polygon20;
		private NxtControl.GuiFramework.Polygon polygon21;
		private NxtControl.GuiFramework.Polygon polygon22;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump1;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump3;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump4;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe6;
		private SE.Nereda.Symbols.Motor_VS.sPump sPump5;
		private SE.Nereda.Symbols.NeredaEffluent.sCalamity3D EFFLUENT_1;
		private NxtControl.GuiFramework.Pipe pipe38;
		private NxtControl.GuiFramework.Polygon polygon23;
		#endregion
	}
}
