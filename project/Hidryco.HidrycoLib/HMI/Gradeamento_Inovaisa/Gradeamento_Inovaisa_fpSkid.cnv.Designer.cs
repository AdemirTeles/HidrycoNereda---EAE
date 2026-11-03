/*
 * Hidryco - Gradeamento_Inovaisa - fpSkid
 * Skid do gradeamento (Vibropac PV-35524): grades M1/M2, rosca M3, niveis LSH1..4, sobretorque e painel.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Gradeamento_Inovaisa
{
	/// <summary>
	/// Summary description for fpSkid.
	/// </summary>
	partial class fpSkid
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.e1 = new NxtControl.GuiFramework.FreeText();
			this.e2 = new NxtControl.GuiFramework.FreeText();
			this.calhaExt = new NxtControl.GuiFramework.Rectangle();
			this.helx0 = new NxtControl.GuiFramework.Line();
			this.helx1 = new NxtControl.GuiFramework.Line();
			this.helx2 = new NxtControl.GuiFramework.Line();
			this.helx3 = new NxtControl.GuiFramework.Line();
			this.helx4 = new NxtControl.GuiFramework.Line();
			this.helx5 = new NxtControl.GuiFramework.Line();
			this.helx6 = new NxtControl.GuiFramework.Line();
			this.helx7 = new NxtControl.GuiFramework.Line();
			this.helx8 = new NxtControl.GuiFramework.Line();
			this.helx9 = new NxtControl.GuiFramework.Line();
			this.helx10 = new NxtControl.GuiFramework.Line();
			this.helx11 = new NxtControl.GuiFramework.Line();
			this.helx12 = new NxtControl.GuiFramework.Line();
			this.helx13 = new NxtControl.GuiFramework.Line();
			this.helx14 = new NxtControl.GuiFramework.Line();
			this.rosca = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca();
			this.tRosca = new NxtControl.GuiFramework.FreeText();
			this.chute = new NxtControl.GuiFramework.Polygon();
			this.cacamba = new NxtControl.GuiFramework.Polygon();
			this.tCac = new NxtControl.GuiFramework.FreeText();
			this.bocal1 = new NxtControl.GuiFramework.Rectangle();
			this.canal1 = new NxtControl.GuiFramework.Rectangle();
			this.aguaM1 = new NxtControl.GuiFramework.Rectangle();
			this.aguaJ1 = new NxtControl.GuiFramework.Rectangle();
			this.ext1 = new NxtControl.GuiFramework.Rectangle();
			this.extb1_0 = new NxtControl.GuiFramework.Line();
			this.extb1_1 = new NxtControl.GuiFramework.Line();
			this.extb1_2 = new NxtControl.GuiFramework.Line();
			this.extb1_3 = new NxtControl.GuiFramework.Line();
			this.extb1_4 = new NxtControl.GuiFramework.Line();
			this.extb1_5 = new NxtControl.GuiFramework.Line();
			this.grade1 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.tGr1 = new NxtControl.GuiFramework.FreeText();
			this.tMont1 = new NxtControl.GuiFramework.FreeText();
			this.tJus1 = new NxtControl.GuiFramework.FreeText();
			this.lSensorMontante1 = new NxtControl.GuiFramework.FreeText();
			this.sSensorMontante1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.lSensorJusante1 = new NxtControl.GuiFramework.FreeText();
			this.sSensorJusante1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.lSensorDiferencial1 = new NxtControl.GuiFramework.FreeText();
			this.sSensorDiferencial1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.bocal2 = new NxtControl.GuiFramework.Rectangle();
			this.canal2 = new NxtControl.GuiFramework.Rectangle();
			this.aguaM2 = new NxtControl.GuiFramework.Rectangle();
			this.aguaJ2 = new NxtControl.GuiFramework.Rectangle();
			this.ext2 = new NxtControl.GuiFramework.Rectangle();
			this.extb2_0 = new NxtControl.GuiFramework.Line();
			this.extb2_1 = new NxtControl.GuiFramework.Line();
			this.extb2_2 = new NxtControl.GuiFramework.Line();
			this.extb2_3 = new NxtControl.GuiFramework.Line();
			this.extb2_4 = new NxtControl.GuiFramework.Line();
			this.extb2_5 = new NxtControl.GuiFramework.Line();
			this.grade2 = new Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade();
			this.tGr2 = new NxtControl.GuiFramework.FreeText();
			this.tMont2 = new NxtControl.GuiFramework.FreeText();
			this.tJus2 = new NxtControl.GuiFramework.FreeText();
			this.lSensorMontante2 = new NxtControl.GuiFramework.FreeText();
			this.sSensorMontante2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.lSensorJusante2 = new NxtControl.GuiFramework.FreeText();
			this.sSensorJusante2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.lSensorDiferencial2 = new NxtControl.GuiFramework.FreeText();
			this.sSensorDiferencial2 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.leg = new NxtControl.GuiFramework.FreeText();
			this.painel = new NxtControl.GuiFramework.Rectangle();
			this.tPainel = new NxtControl.GuiFramework.FreeText();
			this.tPainel2 = new NxtControl.GuiFramework.FreeText();
			this.ledCom = new NxtControl.GuiFramework.Ellipse();
			this.tCom = new NxtControl.GuiFramework.FreeText();
			this.ledEmg = new NxtControl.GuiFramework.Ellipse();
			this.tEmg = new NxtControl.GuiFramework.FreeText();
			this.ledAlm = new NxtControl.GuiFramework.Ellipse();
			this.tAlm = new NxtControl.GuiFramework.FreeText();
			this.ledCic = new NxtControl.GuiFramework.Ellipse();
			this.tCic = new NxtControl.GuiFramework.FreeText();
			this.btnCmd = new NxtControl.GuiFramework.DrawnButton();
			this.xALM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEMG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAPAI = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCIC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFMOT = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFUNC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEEMG = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPAI = new System.HMI.Symbols.Base.Execute<byte>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(820D)), ((float)(60D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(8D)), ((float)(16D)), ((float)(16D)));
			this.alP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.alP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP1.Name = "alP1";
			this.alP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP1.Visible = false;
			// 
			// alP1n
			// 
			this.alP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.alP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 9D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(8D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 24D),
			new NxtControl.Drawing.PointF(28D, 8D),
			new NxtControl.Drawing.PointF(36D, 24D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 11D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 8D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 30D);
			this.e1.Name = "e1";
			this.e1.Text = "";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(420D, 34D);
			this.e2.Name = "e2";
			this.e2.Text = "";
			// 
			// calhaExt
			// 
			this.calhaExt.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(106D)), ((float)(228D)), ((float)(22D)));
			this.calhaExt.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.calhaExt.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.calhaExt.Name = "calhaExt";
			this.calhaExt.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// helx0
			// 
			this.helx0.EndPoint = new NxtControl.Drawing.PointF(176D, 108D);
			this.helx0.Name = "helx0";
			this.helx0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx0.StartPoint = new NxtControl.Drawing.PointF(166D, 126D);
			// 
			// helx1
			// 
			this.helx1.EndPoint = new NxtControl.Drawing.PointF(191D, 108D);
			this.helx1.Name = "helx1";
			this.helx1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx1.StartPoint = new NxtControl.Drawing.PointF(181D, 126D);
			// 
			// helx2
			// 
			this.helx2.EndPoint = new NxtControl.Drawing.PointF(206D, 108D);
			this.helx2.Name = "helx2";
			this.helx2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx2.StartPoint = new NxtControl.Drawing.PointF(196D, 126D);
			// 
			// helx3
			// 
			this.helx3.EndPoint = new NxtControl.Drawing.PointF(221D, 108D);
			this.helx3.Name = "helx3";
			this.helx3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx3.StartPoint = new NxtControl.Drawing.PointF(211D, 126D);
			// 
			// helx4
			// 
			this.helx4.EndPoint = new NxtControl.Drawing.PointF(236D, 108D);
			this.helx4.Name = "helx4";
			this.helx4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx4.StartPoint = new NxtControl.Drawing.PointF(226D, 126D);
			// 
			// helx5
			// 
			this.helx5.EndPoint = new NxtControl.Drawing.PointF(251D, 108D);
			this.helx5.Name = "helx5";
			this.helx5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx5.StartPoint = new NxtControl.Drawing.PointF(241D, 126D);
			// 
			// helx6
			// 
			this.helx6.EndPoint = new NxtControl.Drawing.PointF(266D, 108D);
			this.helx6.Name = "helx6";
			this.helx6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx6.StartPoint = new NxtControl.Drawing.PointF(256D, 126D);
			// 
			// helx7
			// 
			this.helx7.EndPoint = new NxtControl.Drawing.PointF(281D, 108D);
			this.helx7.Name = "helx7";
			this.helx7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx7.StartPoint = new NxtControl.Drawing.PointF(271D, 126D);
			// 
			// helx8
			// 
			this.helx8.EndPoint = new NxtControl.Drawing.PointF(296D, 108D);
			this.helx8.Name = "helx8";
			this.helx8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx8.StartPoint = new NxtControl.Drawing.PointF(286D, 126D);
			// 
			// helx9
			// 
			this.helx9.EndPoint = new NxtControl.Drawing.PointF(311D, 108D);
			this.helx9.Name = "helx9";
			this.helx9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx9.StartPoint = new NxtControl.Drawing.PointF(301D, 126D);
			// 
			// helx10
			// 
			this.helx10.EndPoint = new NxtControl.Drawing.PointF(326D, 108D);
			this.helx10.Name = "helx10";
			this.helx10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx10.StartPoint = new NxtControl.Drawing.PointF(316D, 126D);
			// 
			// helx11
			// 
			this.helx11.EndPoint = new NxtControl.Drawing.PointF(341D, 108D);
			this.helx11.Name = "helx11";
			this.helx11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx11.StartPoint = new NxtControl.Drawing.PointF(331D, 126D);
			// 
			// helx12
			// 
			this.helx12.EndPoint = new NxtControl.Drawing.PointF(356D, 108D);
			this.helx12.Name = "helx12";
			this.helx12.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx12.StartPoint = new NxtControl.Drawing.PointF(346D, 126D);
			// 
			// helx13
			// 
			this.helx13.EndPoint = new NxtControl.Drawing.PointF(371D, 108D);
			this.helx13.Name = "helx13";
			this.helx13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx13.StartPoint = new NxtControl.Drawing.PointF(361D, 126D);
			// 
			// helx14
			// 
			this.helx14.EndPoint = new NxtControl.Drawing.PointF(386D, 108D);
			this.helx14.Name = "helx14";
			this.helx14.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.helx14.StartPoint = new NxtControl.Drawing.PointF(376D, 126D);
			// 
			// rosca
			// 
			this.rosca.BeginInit();
			this.rosca.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 380D, 92D);
			this.rosca.Name = "rosca";
			this.rosca.SecurityToken = ((uint)(4294967295u));
			this.rosca.TagName = "RT_100_01";
			this.rosca.EndInit();
			// 
			// tRosca
			// 
			this.tRosca.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tRosca.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tRosca.Location = new NxtControl.Drawing.PointF(300D, 74D);
			this.tRosca.Name = "tRosca";
			this.tRosca.Text = "ROSCA TRANSPORTADORA M3 (100-RT-01)";
			// 
			// chute
			// 
			this.chute.Bounds = new NxtControl.Drawing.RectF(((float)(106D)), ((float)(126D)), ((float)(76D)), ((float)(84D)));
			this.chute.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.chute.Closed = true;
			this.chute.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.chute.Name = "chute";
			this.chute.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.chute.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(160D, 126D),
			new NxtControl.Drawing.PointF(182D, 126D),
			new NxtControl.Drawing.PointF(130D, 210D),
			new NxtControl.Drawing.PointF(106D, 210D)});
			// 
			// cacamba
			// 
			this.cacamba.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(214D)), ((float)(120D)), ((float)(56D)));
			this.cacamba.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))));
			this.cacamba.Closed = true;
			this.cacamba.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cacamba.Name = "cacamba";
			this.cacamba.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.cacamba.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(16D, 214D),
			new NxtControl.Drawing.PointF(136D, 214D),
			new NxtControl.Drawing.PointF(126D, 270D),
			new NxtControl.Drawing.PointF(26D, 270D)});
			// 
			// tCac
			// 
			this.tCac.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tCac.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tCac.Location = new NxtControl.Drawing.PointF(46D, 234D);
			this.tCac.Name = "tCac";
			this.tCac.Text = "CAÇAMBA";
			// 
			// bocal1
			// 
			this.bocal1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(128D)), ((float)(20D)), ((float)(22D)));
			this.bocal1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.bocal1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bocal1.Name = "bocal1";
			this.bocal1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// canal1
			// 
			this.canal1.Bounds = new NxtControl.Drawing.RectF(((float)(140D)), ((float)(250D)), ((float)(220D)), ((float)(150D)));
			this.canal1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.canal1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.canal1.Name = "canal1";
			this.canal1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// aguaM1
			// 
			this.aguaM1.Bounds = new NxtControl.Drawing.RectF(((float)(142D)), ((float)(300D)), ((float)(108D)), ((float)(98D)));
			this.aguaM1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(200)), ((byte)(230))));
			this.aguaM1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.aguaM1.Name = "aguaM1";
			this.aguaM1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// aguaJ1
			// 
			this.aguaJ1.Bounds = new NxtControl.Drawing.RectF(((float)(251D)), ((float)(336D)), ((float)(107D)), ((float)(62D)));
			this.aguaJ1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(200)), ((byte)(230))));
			this.aguaJ1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.aguaJ1.Name = "aguaJ1";
			this.aguaJ1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ext1
			// 
			this.ext1.Bounds = new NxtControl.Drawing.RectF(((float)(233D)), ((float)(274D)), ((float)(34D)), ((float)(120D)));
			this.ext1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.ext1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ext1.Name = "ext1";
			this.ext1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// extb1_0
			// 
			this.extb1_0.EndPoint = new NxtControl.Drawing.PointF(237D, 392D);
			this.extb1_0.Name = "extb1_0";
			this.extb1_0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb1_0.StartPoint = new NxtControl.Drawing.PointF(237D, 276D);
			// 
			// extb1_1
			// 
			this.extb1_1.EndPoint = new NxtControl.Drawing.PointF(242D, 392D);
			this.extb1_1.Name = "extb1_1";
			this.extb1_1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb1_1.StartPoint = new NxtControl.Drawing.PointF(242D, 276D);
			// 
			// extb1_2
			// 
			this.extb1_2.EndPoint = new NxtControl.Drawing.PointF(247D, 392D);
			this.extb1_2.Name = "extb1_2";
			this.extb1_2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb1_2.StartPoint = new NxtControl.Drawing.PointF(247D, 276D);
			// 
			// extb1_3
			// 
			this.extb1_3.EndPoint = new NxtControl.Drawing.PointF(252D, 392D);
			this.extb1_3.Name = "extb1_3";
			this.extb1_3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb1_3.StartPoint = new NxtControl.Drawing.PointF(252D, 276D);
			// 
			// extb1_4
			// 
			this.extb1_4.EndPoint = new NxtControl.Drawing.PointF(257D, 392D);
			this.extb1_4.Name = "extb1_4";
			this.extb1_4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb1_4.StartPoint = new NxtControl.Drawing.PointF(257D, 276D);
			// 
			// extb1_5
			// 
			this.extb1_5.EndPoint = new NxtControl.Drawing.PointF(262D, 392D);
			this.extb1_5.Name = "extb1_5";
			this.extb1_5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb1_5.StartPoint = new NxtControl.Drawing.PointF(262D, 276D);
			// 
			// grade1
			// 
			this.grade1.BeginInit();
			this.grade1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 215D, 150D);
			this.grade1.Name = "grade1";
			this.grade1.SecurityToken = ((uint)(4294967295u));
			this.grade1.TagName = "GM_100_01.Grade_Mecanizada_Inovaisa1";
			this.grade1.EndInit();
			// 
			// tGr1
			// 
			this.tGr1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tGr1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tGr1.Location = new NxtControl.Drawing.PointF(140D, 404D);
			this.tGr1.Name = "tGr1";
			this.tGr1.Text = "GRADE 1 - M1 (100-GM-01)";
			// 
			// tMont1
			// 
			this.tMont1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tMont1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tMont1.Location = new NxtControl.Drawing.PointF(144D, 282D);
			this.tMont1.Name = "tMont1";
			this.tMont1.Text = "montante";
			// 
			// tJus1
			// 
			this.tJus1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tJus1.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tJus1.Location = new NxtControl.Drawing.PointF(272D, 318D);
			this.tJus1.Name = "tJus1";
			this.tJus1.Text = "jusante";
			// 
			// lSensorMontante1
			// 
			this.lSensorMontante1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lSensorMontante1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.lSensorMontante1.Location = new NxtControl.Drawing.PointF(140D, 430D);
			this.lSensorMontante1.Name = "lSensorMontante1";
			this.lSensorMontante1.Text = "Montante (LSH1)";
			// 
			// sSensorMontante1
			// 
			this.sSensorMontante1.BeginInit();
			this.sSensorMontante1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 424D);
			this.sSensorMontante1.Name = "sSensorMontante1";
			this.sSensorMontante1.SecurityToken = ((uint)(4294967295u));
			this.sSensorMontante1.TagName = "GM_100_01.SensorMontante";
			this.sSensorMontante1.EndInit();
			// 
			// lSensorJusante1
			// 
			this.lSensorJusante1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lSensorJusante1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.lSensorJusante1.Location = new NxtControl.Drawing.PointF(140D, 464D);
			this.lSensorJusante1.Name = "lSensorJusante1";
			this.lSensorJusante1.Text = "Jusante (LSH2)";
			// 
			// sSensorJusante1
			// 
			this.sSensorJusante1.BeginInit();
			this.sSensorJusante1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 458D);
			this.sSensorJusante1.Name = "sSensorJusante1";
			this.sSensorJusante1.SecurityToken = ((uint)(4294967295u));
			this.sSensorJusante1.TagName = "GM_100_01.SensorJusante";
			this.sSensorJusante1.EndInit();
			// 
			// lSensorDiferencial1
			// 
			this.lSensorDiferencial1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lSensorDiferencial1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.lSensorDiferencial1.Location = new NxtControl.Drawing.PointF(140D, 498D);
			this.lSensorDiferencial1.Name = "lSensorDiferencial1";
			this.lSensorDiferencial1.Text = "Diferencial";
			// 
			// sSensorDiferencial1
			// 
			this.sSensorDiferencial1.BeginInit();
			this.sSensorDiferencial1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 224D, 492D);
			this.sSensorDiferencial1.Name = "sSensorDiferencial1";
			this.sSensorDiferencial1.SecurityToken = ((uint)(4294967295u));
			this.sSensorDiferencial1.TagName = "GM_100_01.SensorDiferencial";
			this.sSensorDiferencial1.EndInit();
			// 
			// bocal2
			// 
			this.bocal2.Bounds = new NxtControl.Drawing.RectF(((float)(490D)), ((float)(128D)), ((float)(20D)), ((float)(22D)));
			this.bocal2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.bocal2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.bocal2.Name = "bocal2";
			this.bocal2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// canal2
			// 
			this.canal2.Bounds = new NxtControl.Drawing.RectF(((float)(390D)), ((float)(250D)), ((float)(220D)), ((float)(150D)));
			this.canal2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.canal2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.canal2.Name = "canal2";
			this.canal2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// aguaM2
			// 
			this.aguaM2.Bounds = new NxtControl.Drawing.RectF(((float)(392D)), ((float)(300D)), ((float)(108D)), ((float)(98D)));
			this.aguaM2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(200)), ((byte)(230))));
			this.aguaM2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.aguaM2.Name = "aguaM2";
			this.aguaM2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// aguaJ2
			// 
			this.aguaJ2.Bounds = new NxtControl.Drawing.RectF(((float)(501D)), ((float)(336D)), ((float)(107D)), ((float)(62D)));
			this.aguaJ2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(200)), ((byte)(230))));
			this.aguaJ2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.aguaJ2.Name = "aguaJ2";
			this.aguaJ2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// ext2
			// 
			this.ext2.Bounds = new NxtControl.Drawing.RectF(((float)(483D)), ((float)(274D)), ((float)(34D)), ((float)(120D)));
			this.ext2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.ext2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ext2.Name = "ext2";
			this.ext2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// extb2_0
			// 
			this.extb2_0.EndPoint = new NxtControl.Drawing.PointF(487D, 392D);
			this.extb2_0.Name = "extb2_0";
			this.extb2_0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb2_0.StartPoint = new NxtControl.Drawing.PointF(487D, 276D);
			// 
			// extb2_1
			// 
			this.extb2_1.EndPoint = new NxtControl.Drawing.PointF(492D, 392D);
			this.extb2_1.Name = "extb2_1";
			this.extb2_1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb2_1.StartPoint = new NxtControl.Drawing.PointF(492D, 276D);
			// 
			// extb2_2
			// 
			this.extb2_2.EndPoint = new NxtControl.Drawing.PointF(497D, 392D);
			this.extb2_2.Name = "extb2_2";
			this.extb2_2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb2_2.StartPoint = new NxtControl.Drawing.PointF(497D, 276D);
			// 
			// extb2_3
			// 
			this.extb2_3.EndPoint = new NxtControl.Drawing.PointF(502D, 392D);
			this.extb2_3.Name = "extb2_3";
			this.extb2_3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb2_3.StartPoint = new NxtControl.Drawing.PointF(502D, 276D);
			// 
			// extb2_4
			// 
			this.extb2_4.EndPoint = new NxtControl.Drawing.PointF(507D, 392D);
			this.extb2_4.Name = "extb2_4";
			this.extb2_4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb2_4.StartPoint = new NxtControl.Drawing.PointF(507D, 276D);
			// 
			// extb2_5
			// 
			this.extb2_5.EndPoint = new NxtControl.Drawing.PointF(512D, 392D);
			this.extb2_5.Name = "extb2_5";
			this.extb2_5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.extb2_5.StartPoint = new NxtControl.Drawing.PointF(512D, 276D);
			// 
			// grade2
			// 
			this.grade2.BeginInit();
			this.grade2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 465D, 150D);
			this.grade2.Name = "grade2";
			this.grade2.SecurityToken = ((uint)(4294967295u));
			this.grade2.TagName = "GM_100_02.Grade_Mecanizada_Inovaisa1";
			this.grade2.EndInit();
			// 
			// tGr2
			// 
			this.tGr2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tGr2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tGr2.Location = new NxtControl.Drawing.PointF(390D, 404D);
			this.tGr2.Name = "tGr2";
			this.tGr2.Text = "GRADE 2 - M2 (100-GM-02)";
			// 
			// tMont2
			// 
			this.tMont2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tMont2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tMont2.Location = new NxtControl.Drawing.PointF(394D, 282D);
			this.tMont2.Name = "tMont2";
			this.tMont2.Text = "montante";
			// 
			// tJus2
			// 
			this.tJus2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tJus2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tJus2.Location = new NxtControl.Drawing.PointF(522D, 318D);
			this.tJus2.Name = "tJus2";
			this.tJus2.Text = "jusante";
			// 
			// lSensorMontante2
			// 
			this.lSensorMontante2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lSensorMontante2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.lSensorMontante2.Location = new NxtControl.Drawing.PointF(390D, 430D);
			this.lSensorMontante2.Name = "lSensorMontante2";
			this.lSensorMontante2.Text = "Montante (LSH3)";
			// 
			// sSensorMontante2
			// 
			this.sSensorMontante2.BeginInit();
			this.sSensorMontante2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 474D, 424D);
			this.sSensorMontante2.Name = "sSensorMontante2";
			this.sSensorMontante2.SecurityToken = ((uint)(4294967295u));
			this.sSensorMontante2.TagName = "GM_100_02.SensorMontante";
			this.sSensorMontante2.EndInit();
			// 
			// lSensorJusante2
			// 
			this.lSensorJusante2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lSensorJusante2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.lSensorJusante2.Location = new NxtControl.Drawing.PointF(390D, 464D);
			this.lSensorJusante2.Name = "lSensorJusante2";
			this.lSensorJusante2.Text = "Jusante (LSH4)";
			// 
			// sSensorJusante2
			// 
			this.sSensorJusante2.BeginInit();
			this.sSensorJusante2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 474D, 458D);
			this.sSensorJusante2.Name = "sSensorJusante2";
			this.sSensorJusante2.SecurityToken = ((uint)(4294967295u));
			this.sSensorJusante2.TagName = "GM_100_02.SensorJusante";
			this.sSensorJusante2.EndInit();
			// 
			// lSensorDiferencial2
			// 
			this.lSensorDiferencial2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.lSensorDiferencial2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.lSensorDiferencial2.Location = new NxtControl.Drawing.PointF(390D, 498D);
			this.lSensorDiferencial2.Name = "lSensorDiferencial2";
			this.lSensorDiferencial2.Text = "Diferencial";
			// 
			// sSensorDiferencial2
			// 
			this.sSensorDiferencial2.BeginInit();
			this.sSensorDiferencial2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 474D, 492D);
			this.sSensorDiferencial2.Name = "sSensorDiferencial2";
			this.sSensorDiferencial2.SecurityToken = ((uint)(4294967295u));
			this.sSensorDiferencial2.TagName = "GM_100_02.SensorDiferencial";
			this.sSensorDiferencial2.EndInit();
			// 
			// leg
			// 
			this.leg.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.leg.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.leg.Location = new NxtControl.Drawing.PointF(20D, 540D);
			this.leg.Name = "leg";
			this.leg.Text = "Níveis LSH1/LSH2 (grade 1) e LSH3/LSH4 (grade 2) em %; sobretorque LI1/LI2 nos motores das grades. Clique num equipamento para os detalhes.";
			// 
			// painel
			// 
			this.painel.Bounds = new NxtControl.Drawing.RectF(((float)(690D)), ((float)(76D)), ((float)(110D)), ((float)(130D)));
			this.painel.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(225)), ((byte)(225)), ((byte)(225))));
			this.painel.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.painel.Name = "painel";
			this.painel.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tPainel
			// 
			this.tPainel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tPainel.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tPainel.Location = new NxtControl.Drawing.PointF(698D, 82D);
			this.tPainel.Name = "tPainel";
			this.tPainel.Text = "PAINEL";
			// 
			// tPainel2
			// 
			this.tPainel2.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.tPainel2.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tPainel2.Location = new NxtControl.Drawing.PointF(698D, 96D);
			this.tPainel2.Name = "tPainel2";
			this.tPainel2.Text = "TM241 .207";
			// 
			// ledCom
			// 
			this.ledCom.Bounds = new NxtControl.Drawing.RectF(((float)(700D)), ((float)(120D)), ((float)(12D)), ((float)(12D)));
			this.ledCom.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.ledCom.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ledCom.Name = "ledCom";
			this.ledCom.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tCom
			// 
			this.tCom.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tCom.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tCom.Location = new NxtControl.Drawing.PointF(716D, 119D);
			this.tCom.Name = "tCom";
			this.tCom.Text = "comunicação";
			// 
			// ledEmg
			// 
			this.ledEmg.Bounds = new NxtControl.Drawing.RectF(((float)(700D)), ((float)(142D)), ((float)(12D)), ((float)(12D)));
			this.ledEmg.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.ledEmg.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ledEmg.Name = "ledEmg";
			this.ledEmg.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tEmg
			// 
			this.tEmg.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tEmg.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tEmg.Location = new NxtControl.Drawing.PointF(716D, 141D);
			this.tEmg.Name = "tEmg";
			this.tEmg.Text = "emergência";
			// 
			// ledAlm
			// 
			this.ledAlm.Bounds = new NxtControl.Drawing.RectF(((float)(700D)), ((float)(164D)), ((float)(12D)), ((float)(12D)));
			this.ledAlm.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.ledAlm.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ledAlm.Name = "ledAlm";
			this.ledAlm.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tAlm
			// 
			this.tAlm.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tAlm.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tAlm.Location = new NxtControl.Drawing.PointF(716D, 163D);
			this.tAlm.Name = "tAlm";
			this.tAlm.Text = "alarme";
			// 
			// ledCic
			// 
			this.ledCic.Bounds = new NxtControl.Drawing.RectF(((float)(700D)), ((float)(186D)), ((float)(12D)), ((float)(12D)));
			this.ledCic.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.ledCic.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ledCic.Name = "ledCic";
			this.ledCic.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tCic
			// 
			this.tCic.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tCic.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular);
			this.tCic.Location = new NxtControl.Drawing.PointF(716D, 185D);
			this.tCic.Name = "tCic";
			this.tCic.Text = "ciclo remoto";
			// 
			// btnCmd
			// 
			this.btnCmd.Bounds = new NxtControl.Drawing.RectF(((float)(690D)), ((float)(214D)), ((float)(110D)), ((float)(30D)));
			this.btnCmd.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnCmd.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnCmd.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnCmd.Name = "btnCmd";
			this.btnCmd.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnCmd.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnCmd.Radius = 2D;
			this.btnCmd.Text = "Comandos";
			this.btnCmd.Use3DEffect = false;
			// 
			// xALM
			// 
			this.xALM.BeginInit();
			this.xALM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xALM.IsOnlyInput = true;
			this.xALM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xALM.Name = "xALM";
			this.xALM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xALM.TagName = "STS_ALARME";
			this.xALM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XALMValueChanged);
			this.xALM.EndInit();
			// 
			// xEMG
			// 
			this.xEMG.BeginInit();
			this.xEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMG.IsOnlyInput = true;
			this.xEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMG.Name = "xEMG";
			this.xEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMG.TagName = "STS_EMERGENCIA";
			this.xEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMGValueChanged);
			this.xEMG.EndInit();
			// 
			// xCOM
			// 
			this.xCOM.BeginInit();
			this.xCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCOM.IsOnlyInput = true;
			this.xCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCOM.Name = "xCOM";
			this.xCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCOM.TagName = "STS_COMUNICACAO_OK";
			this.xCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCOMValueChanged);
			this.xCOM.EndInit();
			// 
			// xAPAI
			// 
			this.xAPAI.BeginInit();
			this.xAPAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAPAI.IsOnlyInput = true;
			this.xAPAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAPAI.Name = "xAPAI";
			this.xAPAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAPAI.TagName = "STS_ALARME_ACIONADO";
			this.xAPAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAPAIValueChanged);
			this.xAPAI.EndInit();
			// 
			// xCIC
			// 
			this.xCIC.BeginInit();
			this.xCIC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCIC.IsOnlyInput = true;
			this.xCIC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCIC.Name = "xCIC";
			this.xCIC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCIC.TagName = "STS_CICLO_LIGADO";
			this.xCIC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCICValueChanged);
			this.xCIC.EndInit();
			// 
			// xFMOT
			// 
			this.xFMOT.BeginInit();
			this.xFMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFMOT.IsOnlyInput = true;
			this.xFMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFMOT.Name = "xFMOT";
			this.xFMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFMOT.TagName = "STS_FALHA_MOTOR";
			this.xFMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFMOTValueChanged);
			this.xFMOT.EndInit();
			// 
			// xFUNC
			// 
			this.xFUNC.BeginInit();
			this.xFUNC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFUNC.IsOnlyInput = true;
			this.xFUNC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFUNC.Name = "xFUNC";
			this.xFUNC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFUNC.TagName = "STS_FUNCIONANDO";
			this.xFUNC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFUNCValueChanged);
			this.xFUNC.EndInit();
			// 
			// xECOM
			// 
			this.xECOM.BeginInit();
			this.xECOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECOM.IsOnlyInput = true;
			this.xECOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECOM.Name = "xECOM";
			this.xECOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECOM.TagName = "STS_ALM_COMUNICACAO_EST";
			this.xECOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XECOMValueChanged);
			this.xECOM.EndInit();
			// 
			// xEEMG
			// 
			this.xEEMG.BeginInit();
			this.xEEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEMG.IsOnlyInput = true;
			this.xEEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEMG.Name = "xEEMG";
			this.xEEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEMG.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEEMGValueChanged);
			this.xEEMG.EndInit();
			// 
			// xEPAI
			// 
			this.xEPAI.BeginInit();
			this.xEPAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPAI.IsOnlyInput = true;
			this.xEPAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPAI.Name = "xEPAI";
			this.xEPAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPAI.TagName = "STS_ALM_PAINEL_EST";
			this.xEPAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEPAIValueChanged);
			this.xEPAI.EndInit();
			// 
			// fpSkid
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(820D)), ((float)(560D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.e1,
			this.e2,
			this.calhaExt,
			this.helx0,
			this.helx1,
			this.helx2,
			this.helx3,
			this.helx4,
			this.helx5,
			this.helx6,
			this.helx7,
			this.helx8,
			this.helx9,
			this.helx10,
			this.helx11,
			this.helx12,
			this.helx13,
			this.helx14,
			this.rosca,
			this.tRosca,
			this.chute,
			this.cacamba,
			this.tCac,
			this.bocal1,
			this.canal1,
			this.aguaM1,
			this.aguaJ1,
			this.ext1,
			this.extb1_0,
			this.extb1_1,
			this.extb1_2,
			this.extb1_3,
			this.extb1_4,
			this.extb1_5,
			this.grade1,
			this.tGr1,
			this.tMont1,
			this.tJus1,
			this.lSensorMontante1,
			this.sSensorMontante1,
			this.lSensorJusante1,
			this.sSensorJusante1,
			this.lSensorDiferencial1,
			this.sSensorDiferencial1,
			this.bocal2,
			this.canal2,
			this.aguaM2,
			this.aguaJ2,
			this.ext2,
			this.extb2_0,
			this.extb2_1,
			this.extb2_2,
			this.extb2_3,
			this.extb2_4,
			this.extb2_5,
			this.grade2,
			this.tGr2,
			this.tMont2,
			this.tJus2,
			this.lSensorMontante2,
			this.sSensorMontante2,
			this.lSensorJusante2,
			this.sSensorJusante2,
			this.lSensorDiferencial2,
			this.sSensorDiferencial2,
			this.leg,
			this.painel,
			this.tPainel,
			this.tPainel2,
			this.ledCom,
			this.tCom,
			this.ledEmg,
			this.tEmg,
			this.ledAlm,
			this.tAlm,
			this.ledCic,
			this.tCic,
			this.btnCmd,
			this.xALM,
			this.xEMG,
			this.xCOM,
			this.xAPAI,
			this.xCIC,
			this.xFMOT,
			this.xFUNC,
			this.xECOM,
			this.xEEMG,
			this.xEPAI});
			this.Size = new System.Drawing.Size(820, 560);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText e1;
		private NxtControl.GuiFramework.FreeText e2;
		private NxtControl.GuiFramework.Rectangle calhaExt;
		private NxtControl.GuiFramework.Line helx0;
		private NxtControl.GuiFramework.Line helx1;
		private NxtControl.GuiFramework.Line helx2;
		private NxtControl.GuiFramework.Line helx3;
		private NxtControl.GuiFramework.Line helx4;
		private NxtControl.GuiFramework.Line helx5;
		private NxtControl.GuiFramework.Line helx6;
		private NxtControl.GuiFramework.Line helx7;
		private NxtControl.GuiFramework.Line helx8;
		private NxtControl.GuiFramework.Line helx9;
		private NxtControl.GuiFramework.Line helx10;
		private NxtControl.GuiFramework.Line helx11;
		private NxtControl.GuiFramework.Line helx12;
		private NxtControl.GuiFramework.Line helx13;
		private NxtControl.GuiFramework.Line helx14;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sRosca rosca;
		private NxtControl.GuiFramework.FreeText tRosca;
		private NxtControl.GuiFramework.Polygon chute;
		private NxtControl.GuiFramework.Polygon cacamba;
		private NxtControl.GuiFramework.FreeText tCac;
		private NxtControl.GuiFramework.Rectangle bocal1;
		private NxtControl.GuiFramework.Rectangle canal1;
		private NxtControl.GuiFramework.Rectangle aguaM1;
		private NxtControl.GuiFramework.Rectangle aguaJ1;
		private NxtControl.GuiFramework.Rectangle ext1;
		private NxtControl.GuiFramework.Line extb1_0;
		private NxtControl.GuiFramework.Line extb1_1;
		private NxtControl.GuiFramework.Line extb1_2;
		private NxtControl.GuiFramework.Line extb1_3;
		private NxtControl.GuiFramework.Line extb1_4;
		private NxtControl.GuiFramework.Line extb1_5;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade grade1;
		private NxtControl.GuiFramework.FreeText tGr1;
		private NxtControl.GuiFramework.FreeText tMont1;
		private NxtControl.GuiFramework.FreeText tJus1;
		private NxtControl.GuiFramework.FreeText lSensorMontante1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto sSensorMontante1;
		private NxtControl.GuiFramework.FreeText lSensorJusante1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto sSensorJusante1;
		private NxtControl.GuiFramework.FreeText lSensorDiferencial1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto sSensorDiferencial1;
		private NxtControl.GuiFramework.Rectangle bocal2;
		private NxtControl.GuiFramework.Rectangle canal2;
		private NxtControl.GuiFramework.Rectangle aguaM2;
		private NxtControl.GuiFramework.Rectangle aguaJ2;
		private NxtControl.GuiFramework.Rectangle ext2;
		private NxtControl.GuiFramework.Line extb2_0;
		private NxtControl.GuiFramework.Line extb2_1;
		private NxtControl.GuiFramework.Line extb2_2;
		private NxtControl.GuiFramework.Line extb2_3;
		private NxtControl.GuiFramework.Line extb2_4;
		private NxtControl.GuiFramework.Line extb2_5;
		private Hidryco.HidrycoLib.Symbols.Motor_Inovaisa.sGrade grade2;
		private NxtControl.GuiFramework.FreeText tGr2;
		private NxtControl.GuiFramework.FreeText tMont2;
		private NxtControl.GuiFramework.FreeText tJus2;
		private NxtControl.GuiFramework.FreeText lSensorMontante2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto sSensorMontante2;
		private NxtControl.GuiFramework.FreeText lSensorJusante2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto sSensorJusante2;
		private NxtControl.GuiFramework.FreeText lSensorDiferencial2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto sSensorDiferencial2;
		private NxtControl.GuiFramework.FreeText leg;
		private NxtControl.GuiFramework.Rectangle painel;
		private NxtControl.GuiFramework.FreeText tPainel;
		private NxtControl.GuiFramework.FreeText tPainel2;
		private NxtControl.GuiFramework.Ellipse ledCom;
		private NxtControl.GuiFramework.FreeText tCom;
		private NxtControl.GuiFramework.Ellipse ledEmg;
		private NxtControl.GuiFramework.FreeText tEmg;
		private NxtControl.GuiFramework.Ellipse ledAlm;
		private NxtControl.GuiFramework.FreeText tAlm;
		private NxtControl.GuiFramework.Ellipse ledCic;
		private NxtControl.GuiFramework.FreeText tCic;
		private NxtControl.GuiFramework.DrawnButton btnCmd;
		private System.HMI.Symbols.Base.Execute<bool> xALM;
		private System.HMI.Symbols.Base.Execute<bool> xEMG;
		private System.HMI.Symbols.Base.Execute<bool> xCOM;
		private System.HMI.Symbols.Base.Execute<bool> xAPAI;
		private System.HMI.Symbols.Base.Execute<bool> xCIC;
		private System.HMI.Symbols.Base.Execute<bool> xFMOT;
		private System.HMI.Symbols.Base.Execute<bool> xFUNC;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xEEMG;
		private System.HMI.Symbols.Base.Execute<byte> xEPAI;
		#endregion
	}
}
