/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 7/9/2026
 * Time: 10:25 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.NeredaMetalSaltDosing
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.polyline1 = new NxtControl.GuiFramework.Polyline();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.Level = new NxtControl.GuiFramework.Rectangle();
			this.pipe4 = new NxtControl.GuiFramework.Pipe();
			this.pipe3 = new NxtControl.GuiFramework.Pipe();
			this.pipe2 = new NxtControl.GuiFramework.Pipe();
			this.PUMP001 = new NxtControl.GuiFramework.FreeText();
			this.XV001 = new NxtControl.GuiFramework.FreeText();
			this.XV003 = new NxtControl.GuiFramework.FreeText();
			this.XV002 = new NxtControl.GuiFramework.FreeText();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.LevelTankSensor = new System.HMI.Symbols.Base.FreeText<float>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.sDefault1 = new SE.Nereda.Symbols.ValveS.sDefault();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.sPump1 = new SE.Nereda.Symbols.MotorS.sPump();
			this.pipe1 = new NxtControl.GuiFramework.Pipe();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.group3 = new NxtControl.GuiFramework.Group();
			// 
			// polyline1
			// 
			this.polyline1.Bounds = new NxtControl.Drawing.RectF(((float)(144D)), ((float)(416D)), ((float)(80D)), ((float)(12D)));
			this.polyline1.Closed = false;
			this.polyline1.Name = "polyline1";
			this.polyline1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(144D, 416D),
			new NxtControl.Drawing.PointF(144D, 428D),
			new NxtControl.Drawing.PointF(224D, 428D),
			new NxtControl.Drawing.PointF(224D, 416D)});
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(148D)), ((float)(368D)), ((float)(72D)), ((float)(56D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			this.rectangle4.Text = "Fe_dosing";
			this.rectangle4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Level
			// 
			this.Level.Bounds = new NxtControl.Drawing.RectF(((float)(148D)), ((float)(370D)), ((float)(72D)), ((float)(52D)));
			this.Level.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(235)), ((byte)(145))));
			this.Level.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.Level.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.Level.Name = "Level";
			this.Level.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.Level.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Level.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pipe4
			// 
			this.pipe4.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(100D)), ((float)(88D)), ((float)(0D)));
			this.pipe4.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe4.Name = "pipe4";
			this.pipe4.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(120D, 100D),
			new NxtControl.Drawing.PointF(208D, 100D)});
			this.pipe4.Width = 8;
			// 
			// pipe3
			// 
			this.pipe3.Bounds = new NxtControl.Drawing.RectF(((float)(179D)), ((float)(100D)), ((float)(0D)), ((float)(110D)));
			this.pipe3.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe3.Name = "pipe3";
			this.pipe3.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(179D, 100D),
			new NxtControl.Drawing.PointF(179D, 210D)});
			this.pipe3.Width = 8;
			// 
			// pipe2
			// 
			this.pipe2.Bounds = new NxtControl.Drawing.RectF(((float)(32D)), ((float)(100D)), ((float)(72D)), ((float)(0D)));
			this.pipe2.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe2.Name = "pipe2";
			this.pipe2.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(32D, 100D),
			new NxtControl.Drawing.PointF(104D, 100D)});
			this.pipe2.Width = 8;
			// 
			// PUMP001
			// 
			this.PUMP001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.PUMP001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.PUMP001.Location = new NxtControl.Drawing.PointF(40D, 208D);
			this.PUMP001.Name = "PUMP001";
			this.PUMP001.Text = "NVPP 001 Pump001";
			// 
			// XV001
			// 
			this.XV001.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV001.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV001.Location = new NxtControl.Drawing.PointF(76D, 320D);
			this.XV001.Name = "XV001";
			this.XV001.Text = "NVPP 001 XV001";
			// 
			// XV003
			// 
			this.XV003.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV003.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV003.Location = new NxtControl.Drawing.PointF(64D, 112D);
			this.XV003.Name = "XV003";
			this.XV003.Text = "NVPP 001 XV003";
			// 
			// XV002
			// 
			this.XV002.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.XV002.Font = new NxtControl.Drawing.Font("LabelFont");
			this.XV002.Location = new NxtControl.Drawing.PointF(74D, 144D);
			this.XV002.Name = "XV002";
			this.XV002.Text = "NVPP 001 XV002";
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(32D, 108D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 3F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(32D, 92D);
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(92D)), ((float)(16D)), ((float)(16D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(48D, 100D),
			new NxtControl.Drawing.PointF(64D, 92D),
			new NxtControl.Drawing.PointF(64D, 108D)});
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(175D)), ((float)(96D)), ((float)(8D)), ((float)(8D)));
			this.ellipse1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// LevelTankSensor
			// 
			this.LevelTankSensor.BeginInit();
			this.LevelTankSensor.DecimalPlacesCount = ((uint)(2u));
			this.LevelTankSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 176D, 432D);
			this.LevelTankSensor.IsOnlyInput = true;
			this.LevelTankSensor.Name = "LevelTankSensor";
			this.LevelTankSensor.Ranges.Clear();
			this.LevelTankSensor.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.LevelTankSensor.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.LevelTankSensor.Suffix = "m";
			this.LevelTankSensor.TagName = "";
			this.LevelTankSensor.TextAngle = 0F;
			this.LevelTankSensor.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.freeText1.Font = new NxtControl.Drawing.Font("LabelFont");
			this.freeText1.Location = new NxtControl.Drawing.PointF(136D, 432D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Level :";
			// 
			// sDefault1
			// 
			this.sDefault1.BeginInit();
			this.sDefault1._iVlvName = "Valve";
			this.sDefault1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 64D, 52D);
			this.sDefault1.Name = "sDefault1";
			this.sDefault1.SecurityToken = ((uint)(4294967295u));
			this.sDefault1.StateTextPosition = SE.Nereda.Symbols.ValveS.sDefault.StateTextPositionOption.Vertical;
			this.sDefault1.SymbolNameDisplay = SE.Nereda.Symbols.ValveS.sDefault.SymbolNameDisplayOption.Hide;
			this.sDefault1.TagName = "Actuators.NVPP_001_a_058";
			this.sDefault1.EndInit();
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(171D)), ((float)(128D)), ((float)(16D)), ((float)(40D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(171D, 128D),
			new NxtControl.Drawing.PointF(187D, 128D),
			new NxtControl.Drawing.PointF(171D, 168D),
			new NxtControl.Drawing.PointF(187D, 168D)});
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(179D, 148D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(203D, 148D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(203D, 156D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(203D, 140D);
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon2,
			this.line1,
			this.line2});
			this.group2.EndInit();
			// 
			// sPump1
			// 
			this.sPump1.BeginInit();
			this.sPump1._iMotName = "Motor";
			this.sPump1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 111D, 168D);
			this.sPump1.Name = "sPump1";
			this.sPump1.SecurityToken = ((uint)(4294967295u));
			this.sPump1.SymbolNameDisplay = SE.Nereda.Symbols.MotorS.sPump.SymbolNameDisplayOption.Show;
			this.sPump1.TagName = "Actuators.NVPP_001_fdp_001";
			this.sPump1.EndInit();
			// 
			// pipe1
			// 
			this.pipe1.Bounds = new NxtControl.Drawing.RectF(((float)(104D)), ((float)(240D)), ((float)(80D)), ((float)(128D)));
			this.pipe1.InnerColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.pipe1.Name = "pipe1";
			this.pipe1.OuterColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.pipe1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(184D, 368D),
			new NxtControl.Drawing.PointF(184D, 280D),
			new NxtControl.Drawing.PointF(104D, 280D),
			new NxtControl.Drawing.PointF(104D, 240D),
			new NxtControl.Drawing.PointF(160D, 240D)});
			this.pipe1.Width = 8;
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(176D)), ((float)(304D)), ((float)(16D)), ((float)(40D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("transparent"));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(176D, 304D),
			new NxtControl.Drawing.PointF(192D, 304D),
			new NxtControl.Drawing.PointF(176D, 344D),
			new NxtControl.Drawing.PointF(192D, 344D)});
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(184D, 324D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(208D, 324D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(208D, 332D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 4F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(208D, 316D);
			// 
			// group3
			// 
			this.group3.BeginInit();
			this.group3.Name = "group3";
			this.group3.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon3,
			this.line4,
			this.line5});
			this.group3.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.pipe1,
			this.Level,
			this.pipe4,
			this.pipe3,
			this.pipe2,
			this.PUMP001,
			this.XV001,
			this.XV003,
			this.XV002,
			this.line3,
			this.polygon1,
			this.ellipse1,
			this.LevelTankSensor,
			this.freeText1,
			this.sDefault1,
			this.group2,
			this.sPump1,
			this.group3,
			this.rectangle4,
			this.polyline1});
			this.SymbolSize = new System.Drawing.Size(600, 552);

		}
		private NxtControl.GuiFramework.Polyline polyline1;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Rectangle Level;
		private NxtControl.GuiFramework.Pipe pipe4;
		private NxtControl.GuiFramework.Pipe pipe3;
		private NxtControl.GuiFramework.Pipe pipe2;
		private NxtControl.GuiFramework.FreeText PUMP001;
		private NxtControl.GuiFramework.FreeText XV001;
		private NxtControl.GuiFramework.FreeText XV003;
		private NxtControl.GuiFramework.FreeText XV002;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private System.HMI.Symbols.Base.FreeText<float> LevelTankSensor;
		private NxtControl.GuiFramework.FreeText freeText1;
		private SE.Nereda.Symbols.ValveS.sDefault sDefault1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Group group2;
		private SE.Nereda.Symbols.MotorS.sPump sPump1;
		private NxtControl.GuiFramework.Pipe pipe1;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Group group3;
		#endregion
	}
}
