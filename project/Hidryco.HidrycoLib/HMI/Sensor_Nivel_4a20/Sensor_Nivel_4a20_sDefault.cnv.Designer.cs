/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/9/2026
 * Time: 5:38 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Sensor_Nivel_4a20
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
			this.line6 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.stsSensor = new System.HMI.Symbols.Base.TextBox<float>();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.group2 = new NxtControl.GuiFramework.Group();
			this.stsSensorEscalonadoPorcentagem = new System.HMI.Symbols.Base.TextBox<float>();
			this.alarme_icon1 = new Hidryco.HidrycoLib.Graphics.alarme_icon();
			// 
			// line6
			// 
			this.line6.EndPoint = new NxtControl.Drawing.PointF(172.73684210526318D, 122.037037037037D);
			this.line6.Name = "line6";
			this.line6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line6.StartPoint = new NxtControl.Drawing.PointF(168.63157894736838D, 116.74074074074076D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(164.52631578947367D, 127.33333333333333D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(160.42105263157896D, 111.44444444444443D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(160.42105263157896D, 111.44444444444443D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(156.31578947368422D, 122.037037037037D);
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line3,
			this.line4,
			this.line5,
			this.line6});
			this.group1.EndInit();
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(168.63157894736838D, 116.74074074074076D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(164.52631578947367D, 127.33333333333333D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(174D, 128.55555555555557D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(150D, 128.55555555555557D);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(153.78947368421052D, 131D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(114)), ((byte)(114)), ((byte)(114))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(153.78947368421052D, 109D);
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(56D)), ((float)(85D)), ((float)(128D)), ((float)(83D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(210)), ((byte)(210)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// stsSensor
			// 
			this.stsSensor.BeginInit();
			this.stsSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 0.423076923076923D, 64D, 108D);
			this.stsSensor.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.stsSensor.IsOnlyInput = true;
			this.stsSensor.MaximumTag = null;
			this.stsSensor.MinimumTag = null;
			this.stsSensor.Name = "stsSensor";
			this.stsSensor.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stsSensor.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stsSensor.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stsSensor.TagName = "STS_SENSOR";
			this.stsSensor.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stsSensor.Value = 0F;
			this.stsSensor.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(59D)), ((float)(86D)), ((float)(87D)), ((float)(79D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.drawnButton1.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpAlarmes", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(90D)), ((float)(58D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.SymInstanceLabel");
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.line2,
			this.group1});
			this.group2.EndInit();
			// 
			// stsSensorEscalonadoPorcentagem
			// 
			this.stsSensorEscalonadoPorcentagem.BeginInit();
			this.stsSensorEscalonadoPorcentagem.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.53333333333333333D, 0D, 0D, 0.423076923076923D, 64D, 136D);
			this.stsSensorEscalonadoPorcentagem.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.stsSensorEscalonadoPorcentagem.IsOnlyInput = true;
			this.stsSensorEscalonadoPorcentagem.MaximumTag = null;
			this.stsSensorEscalonadoPorcentagem.MinimumTag = null;
			this.stsSensorEscalonadoPorcentagem.Name = "stsSensorEscalonadoPorcentagem";
			this.stsSensorEscalonadoPorcentagem.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stsSensorEscalonadoPorcentagem.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stsSensorEscalonadoPorcentagem.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stsSensorEscalonadoPorcentagem.Suffix = "%";
			this.stsSensorEscalonadoPorcentagem.TagName = "STS_SENSOR_PORCENTAGEM";
			this.stsSensorEscalonadoPorcentagem.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stsSensorEscalonadoPorcentagem.Value = 0F;
			this.stsSensorEscalonadoPorcentagem.EndInit();
			// 
			// alarme_icon1
			// 
			this.alarme_icon1.BeginInit();
			this.alarme_icon1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.5D, 0D, 0D, 0.5D, 157D, 90D);
			this.alarme_icon1.Name = "alarme_icon1";
			this.alarme_icon1.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.stsSensor,
			this.drawnButton1,
			this.InstanceName,
			this.group2,
			this.stsSensorEscalonadoPorcentagem,
			this.alarme_icon1});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Line line6;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private System.HMI.Symbols.Base.TextBox<float> stsSensor;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Group group2;
		private System.HMI.Symbols.Base.TextBox<float> stsSensorEscalonadoPorcentagem;
		private Hidryco.HidrycoLib.Graphics.alarme_icon alarme_icon1;
		#endregion
	}
}
