/*
 * Hidryco - Motor_Inovaisa - fpDefault
 * Motor do painel do gradeamento: estado, codigo do painel, sobretorque e reconhecimento dos alarmes.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Inovaisa
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
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
			this.motor = new NxtControl.GuiFramework.Rectangle();
			this.e1 = new NxtControl.GuiFramework.FreeText();
			this.e2 = new NxtControl.GuiFramework.FreeText();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.l3 = new NxtControl.GuiFramework.FreeText();
			this.l4 = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
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
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(340D)), ((float)(74D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 11D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 26D),
			new NxtControl.Drawing.PointF(28D, 10D),
			new NxtControl.Drawing.PointF(36D, 26D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 13D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 10D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// motor
			// 
			this.motor.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(30D)), ((float)(28D)), ((float)(20D)));
			this.motor.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(140)), ((byte)(60))));
			this.motor.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.motor.Name = "motor";
			this.motor.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 32D);
			this.e1.Name = "e1";
			this.e1.Text = "";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(20D, 54D);
			this.e2.Name = "e2";
			this.e2.Text = "";
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l1.Location = new NxtControl.Drawing.PointF(20D, 90D);
			this.l1.Name = "l1";
			this.l1.Text = "";
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(20D, 112D);
			this.l2.Name = "l2";
			this.l2.Text = "";
			// 
			// l3
			// 
			this.l3.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.l3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.l3.Location = new NxtControl.Drawing.PointF(20D, 140D);
			this.l3.Name = "l3";
			this.l3.Text = "Comandado pelo painel do gradeamento:";
			// 
			// l4
			// 
			this.l4.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.l4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.l4.Location = new NxtControl.Drawing.PointF(20D, 156D);
			this.l4.Name = "l4";
			this.l4.Text = "ciclo remoto e limpeza pelo diferencial de nível.";
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(196D)), ((float)(300D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer alarmes";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
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
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(340D)), ((float)(250D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.motor,
			this.e1,
			this.e2,
			this.l1,
			this.l2,
			this.l3,
			this.l4,
			this.btnReset,
			this.xFUN,
			this.xLIG,
			this.xREV,
			this.xFAL,
			this.xSOB,
			this.xCOM,
			this.xTREV,
			this.xTSOB,
			this.xEFAL,
			this.xESOB});
			this.Size = new System.Drawing.Size(340, 250);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.Rectangle motor;
		private NxtControl.GuiFramework.FreeText e1;
		private NxtControl.GuiFramework.FreeText e2;
		private NxtControl.GuiFramework.FreeText l1;
		private NxtControl.GuiFramework.FreeText l2;
		private NxtControl.GuiFramework.FreeText l3;
		private NxtControl.GuiFramework.FreeText l4;
		private NxtControl.GuiFramework.DrawnButton btnReset;
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
		#endregion
	}
}
