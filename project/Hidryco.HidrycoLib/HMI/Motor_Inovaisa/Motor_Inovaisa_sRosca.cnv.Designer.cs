/*
 * Hidryco - Motor_Inovaisa - sRosca
 * Rosca transportadora: calha com helicoide e motor (vermelho = ligado, verde = parado, cinza = sem comunicacao) e alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inovaisa
{
	/// <summary>
	/// Summary description for sRosca.
	/// </summary>
	partial class sRosca
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.calha = new NxtControl.GuiFramework.Rectangle();
			this.hel0 = new NxtControl.GuiFramework.Line();
			this.hel1 = new NxtControl.GuiFramework.Line();
			this.hel2 = new NxtControl.GuiFramework.Line();
			this.hel3 = new NxtControl.GuiFramework.Line();
			this.hel4 = new NxtControl.GuiFramework.Line();
			this.hel5 = new NxtControl.GuiFramework.Line();
			this.hel6 = new NxtControl.GuiFramework.Line();
			this.hel7 = new NxtControl.GuiFramework.Line();
			this.hel8 = new NxtControl.GuiFramework.Line();
			this.hel9 = new NxtControl.GuiFramework.Line();
			this.hel10 = new NxtControl.GuiFramework.Line();
			this.hel11 = new NxtControl.GuiFramework.Line();
			this.motor = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.xFUN = new System.HMI.Symbols.Base.Execute<short>();
			this.xLIG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xREV = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFAL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSOB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xTREV = new System.HMI.Symbols.Base.Execute<bool>();
			this.xTSOB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEFAL = new System.HMI.Symbols.Base.Execute<byte>();
			this.xESOB = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// calha
			// 
			this.calha.Bounds = new NxtControl.Drawing.RectF(((float)(4D)), ((float)(14D)), ((float)(190D)), ((float)(22D)));
			this.calha.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.calha.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.calha.Name = "calha";
			this.calha.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// hel0
			// 
			this.hel0.EndPoint = new NxtControl.Drawing.PointF(20D, 16D);
			this.hel0.Name = "hel0";
			this.hel0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel0.StartPoint = new NxtControl.Drawing.PointF(10D, 34D);
			// 
			// hel1
			// 
			this.hel1.EndPoint = new NxtControl.Drawing.PointF(35D, 16D);
			this.hel1.Name = "hel1";
			this.hel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel1.StartPoint = new NxtControl.Drawing.PointF(25D, 34D);
			// 
			// hel2
			// 
			this.hel2.EndPoint = new NxtControl.Drawing.PointF(50D, 16D);
			this.hel2.Name = "hel2";
			this.hel2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel2.StartPoint = new NxtControl.Drawing.PointF(40D, 34D);
			// 
			// hel3
			// 
			this.hel3.EndPoint = new NxtControl.Drawing.PointF(65D, 16D);
			this.hel3.Name = "hel3";
			this.hel3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel3.StartPoint = new NxtControl.Drawing.PointF(55D, 34D);
			// 
			// hel4
			// 
			this.hel4.EndPoint = new NxtControl.Drawing.PointF(80D, 16D);
			this.hel4.Name = "hel4";
			this.hel4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel4.StartPoint = new NxtControl.Drawing.PointF(70D, 34D);
			// 
			// hel5
			// 
			this.hel5.EndPoint = new NxtControl.Drawing.PointF(95D, 16D);
			this.hel5.Name = "hel5";
			this.hel5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel5.StartPoint = new NxtControl.Drawing.PointF(85D, 34D);
			// 
			// hel6
			// 
			this.hel6.EndPoint = new NxtControl.Drawing.PointF(110D, 16D);
			this.hel6.Name = "hel6";
			this.hel6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel6.StartPoint = new NxtControl.Drawing.PointF(100D, 34D);
			// 
			// hel7
			// 
			this.hel7.EndPoint = new NxtControl.Drawing.PointF(125D, 16D);
			this.hel7.Name = "hel7";
			this.hel7.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel7.StartPoint = new NxtControl.Drawing.PointF(115D, 34D);
			// 
			// hel8
			// 
			this.hel8.EndPoint = new NxtControl.Drawing.PointF(140D, 16D);
			this.hel8.Name = "hel8";
			this.hel8.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel8.StartPoint = new NxtControl.Drawing.PointF(130D, 34D);
			// 
			// hel9
			// 
			this.hel9.EndPoint = new NxtControl.Drawing.PointF(155D, 16D);
			this.hel9.Name = "hel9";
			this.hel9.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel9.StartPoint = new NxtControl.Drawing.PointF(145D, 34D);
			// 
			// hel10
			// 
			this.hel10.EndPoint = new NxtControl.Drawing.PointF(170D, 16D);
			this.hel10.Name = "hel10";
			this.hel10.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel10.StartPoint = new NxtControl.Drawing.PointF(160D, 34D);
			// 
			// hel11
			// 
			this.hel11.EndPoint = new NxtControl.Drawing.PointF(185D, 16D);
			this.hel11.Name = "hel11";
			this.hel11.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.hel11.StartPoint = new NxtControl.Drawing.PointF(175D, 34D);
			// 
			// motor
			// 
			this.motor.Bounds = new NxtControl.Drawing.RectF(((float)(196D)), ((float)(15D)), ((float)(30D)), ((float)(20D)));
			this.motor.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(140)), ((byte)(60))));
			this.motor.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.motor.Name = "motor";
			this.motor.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(196D)), ((float)(0D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(200D, 1D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(196D)), ((float)(0D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(196D, 16D),
			new NxtControl.Drawing.PointF(204D, 0D),
			new NxtControl.Drawing.PointF(212D, 16D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(201D, 3D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(216D, 0D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// xFUN
			// 
			this.xFUN.BeginInit();
			this.xFUN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFUN.IsOnlyInput = true;
			this.xFUN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFUN.Name = "xFUN";
			this.xFUN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFUN.TagName = "STS_FUNCIONAMENTO";
			this.xFUN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFUNValueChanged);
			this.xFUN.EndInit();
			// 
			// xLIG
			// 
			this.xLIG.BeginInit();
			this.xLIG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLIG.IsOnlyInput = true;
			this.xLIG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLIG.Name = "xLIG";
			this.xLIG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLIG.TagName = "STS_LIGADO";
			this.xLIG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XLIGValueChanged);
			this.xLIG.EndInit();
			// 
			// xREV
			// 
			this.xREV.BeginInit();
			this.xREV.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xREV.IsOnlyInput = true;
			this.xREV.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xREV.Name = "xREV";
			this.xREV.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xREV.TagName = "STS_REVERSO";
			this.xREV.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XREVValueChanged);
			this.xREV.EndInit();
			// 
			// xFAL
			// 
			this.xFAL.BeginInit();
			this.xFAL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFAL.IsOnlyInput = true;
			this.xFAL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFAL.Name = "xFAL";
			this.xFAL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFAL.TagName = "STS_FALHA";
			this.xFAL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFALValueChanged);
			this.xFAL.EndInit();
			// 
			// xSOB
			// 
			this.xSOB.BeginInit();
			this.xSOB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSOB.IsOnlyInput = true;
			this.xSOB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSOB.Name = "xSOB";
			this.xSOB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSOB.TagName = "STS_SOBRETORQUE";
			this.xSOB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSOBValueChanged);
			this.xSOB.EndInit();
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
			// xTREV
			// 
			this.xTREV.BeginInit();
			this.xTREV.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTREV.IsOnlyInput = true;
			this.xTREV.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTREV.Name = "xTREV";
			this.xTREV.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTREV.TagName = "STS_TEM_REVERSO";
			this.xTREV.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTREVValueChanged);
			this.xTREV.EndInit();
			// 
			// xTSOB
			// 
			this.xTSOB.BeginInit();
			this.xTSOB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTSOB.IsOnlyInput = true;
			this.xTSOB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTSOB.Name = "xTSOB";
			this.xTSOB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTSOB.TagName = "STS_TEM_SOBRETORQUE";
			this.xTSOB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTSOBValueChanged);
			this.xTSOB.EndInit();
			// 
			// xEFAL
			// 
			this.xEFAL.BeginInit();
			this.xEFAL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEFAL.IsOnlyInput = true;
			this.xEFAL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEFAL.Name = "xEFAL";
			this.xEFAL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEFAL.TagName = "STS_ALM_FALHA_EST";
			this.xEFAL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEFALValueChanged);
			this.xEFAL.EndInit();
			// 
			// xESOB
			// 
			this.xESOB.BeginInit();
			this.xESOB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xESOB.IsOnlyInput = true;
			this.xESOB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xESOB.Name = "xESOB";
			this.xESOB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xESOB.TagName = "STS_ALM_SOBRETORQUE_EST";
			this.xESOB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XESOBValueChanged);
			this.xESOB.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(230D)), ((float)(44D)));
			this.abrir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.ButtonPushedBrush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.abrir.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.abrir.Name = "abrir";
			this.abrir.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.abrir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.abrir.Radius = 2D;
			this.abrir.Text = "";
			this.abrir.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.abrir.Use3DEffect = false;
			// 
			// sRosca
			// 
			this.Name = "sRosca";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.calha,
			this.hel0,
			this.hel1,
			this.hel2,
			this.hel3,
			this.hel4,
			this.hel5,
			this.hel6,
			this.hel7,
			this.hel8,
			this.hel9,
			this.hel10,
			this.hel11,
			this.motor,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.xFUN,
			this.xLIG,
			this.xREV,
			this.xFAL,
			this.xSOB,
			this.xCOM,
			this.xTREV,
			this.xTSOB,
			this.xEFAL,
			this.xESOB,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(230, 44);

		}
		private NxtControl.GuiFramework.Rectangle calha;
		private NxtControl.GuiFramework.Line hel0;
		private NxtControl.GuiFramework.Line hel1;
		private NxtControl.GuiFramework.Line hel2;
		private NxtControl.GuiFramework.Line hel3;
		private NxtControl.GuiFramework.Line hel4;
		private NxtControl.GuiFramework.Line hel5;
		private NxtControl.GuiFramework.Line hel6;
		private NxtControl.GuiFramework.Line hel7;
		private NxtControl.GuiFramework.Line hel8;
		private NxtControl.GuiFramework.Line hel9;
		private NxtControl.GuiFramework.Line hel10;
		private NxtControl.GuiFramework.Line hel11;
		private NxtControl.GuiFramework.Rectangle motor;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private System.HMI.Symbols.Base.Execute<short> xFUN;
		private System.HMI.Symbols.Base.Execute<bool> xLIG;
		private System.HMI.Symbols.Base.Execute<bool> xREV;
		private System.HMI.Symbols.Base.Execute<bool> xFAL;
		private System.HMI.Symbols.Base.Execute<bool> xSOB;
		private System.HMI.Symbols.Base.Execute<bool> xCOM;
		private System.HMI.Symbols.Base.Execute<bool> xTREV;
		private System.HMI.Symbols.Base.Execute<bool> xTSOB;
		private System.HMI.Symbols.Base.Execute<byte> xEFAL;
		private System.HMI.Symbols.Base.Execute<byte> xESOB;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
