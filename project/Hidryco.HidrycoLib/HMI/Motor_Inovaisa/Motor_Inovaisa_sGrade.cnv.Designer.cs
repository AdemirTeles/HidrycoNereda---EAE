/*
 * Hidryco - Motor_Inovaisa - sGrade
 * Grade mecanizada: motor (vermelho = ligado, verde = parado, cinza = sem comunicacao), sentido e alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Inovaisa
{
	/// <summary>
	/// Summary description for sGrade.
	/// </summary>
	partial class sGrade
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.quadro = new NxtControl.GuiFramework.Rectangle();
			this.barra0 = new NxtControl.GuiFramework.Line();
			this.barra1 = new NxtControl.GuiFramework.Line();
			this.barra2 = new NxtControl.GuiFramework.Line();
			this.barra3 = new NxtControl.GuiFramework.Line();
			this.barra4 = new NxtControl.GuiFramework.Line();
			this.barra5 = new NxtControl.GuiFramework.Line();
			this.rastelo = new NxtControl.GuiFramework.Rectangle();
			this.eixo = new NxtControl.GuiFramework.Rectangle();
			this.motor = new NxtControl.GuiFramework.Rectangle();
			this.tSent = new NxtControl.GuiFramework.FreeText();
			this.txSob = new NxtControl.GuiFramework.FreeText();
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
			// quadro
			// 
			this.quadro.Bounds = new NxtControl.Drawing.RectF(((float)(18D)), ((float)(40D)), ((float)(34D)), ((float)(84D)));
			this.quadro.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.quadro.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.quadro.Name = "quadro";
			this.quadro.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// barra0
			// 
			this.barra0.EndPoint = new NxtControl.Drawing.PointF(22D, 122D);
			this.barra0.Name = "barra0";
			this.barra0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.barra0.StartPoint = new NxtControl.Drawing.PointF(22D, 42D);
			// 
			// barra1
			// 
			this.barra1.EndPoint = new NxtControl.Drawing.PointF(27D, 122D);
			this.barra1.Name = "barra1";
			this.barra1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.barra1.StartPoint = new NxtControl.Drawing.PointF(27D, 42D);
			// 
			// barra2
			// 
			this.barra2.EndPoint = new NxtControl.Drawing.PointF(32D, 122D);
			this.barra2.Name = "barra2";
			this.barra2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.barra2.StartPoint = new NxtControl.Drawing.PointF(32D, 42D);
			// 
			// barra3
			// 
			this.barra3.EndPoint = new NxtControl.Drawing.PointF(37D, 122D);
			this.barra3.Name = "barra3";
			this.barra3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.barra3.StartPoint = new NxtControl.Drawing.PointF(37D, 42D);
			// 
			// barra4
			// 
			this.barra4.EndPoint = new NxtControl.Drawing.PointF(42D, 122D);
			this.barra4.Name = "barra4";
			this.barra4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.barra4.StartPoint = new NxtControl.Drawing.PointF(42D, 42D);
			// 
			// barra5
			// 
			this.barra5.EndPoint = new NxtControl.Drawing.PointF(47D, 122D);
			this.barra5.Name = "barra5";
			this.barra5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.barra5.StartPoint = new NxtControl.Drawing.PointF(47D, 42D);
			// 
			// rastelo
			// 
			this.rastelo.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(78D)), ((float)(38D)), ((float)(4D)));
			this.rastelo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))));
			this.rastelo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rastelo.Name = "rastelo";
			this.rastelo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// eixo
			// 
			this.eixo.Bounds = new NxtControl.Drawing.RectF(((float)(33D)), ((float)(30D)), ((float)(4D)), ((float)(10D)));
			this.eixo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))));
			this.eixo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.eixo.Name = "eixo";
			this.eixo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// motor
			// 
			this.motor.Bounds = new NxtControl.Drawing.RectF(((float)(21D)), ((float)(12D)), ((float)(28D)), ((float)(18D)));
			this.motor.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(140)), ((byte)(60))));
			this.motor.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.motor.Name = "motor";
			this.motor.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tSent
			// 
			this.tSent.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tSent.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tSent.Location = new NxtControl.Drawing.PointF(52D, 14D);
			this.tSent.Name = "tSent";
			this.tSent.Text = "";
			// 
			// txSob
			// 
			this.txSob.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(0)), ((byte)(0)));
			this.txSob.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.txSob.Location = new NxtControl.Drawing.PointF(0D, 100D);
			this.txSob.Name = "txSob";
			this.txSob.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(52D)), ((float)(40D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(56D, 41D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(52D)), ((float)(40D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(52D, 56D),
			new NxtControl.Drawing.PointF(60D, 40D),
			new NxtControl.Drawing.PointF(68D, 56D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(57D, 43D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(72D, 40D);
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
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(70D)), ((float)(128D)));
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
			// sGrade
			// 
			this.Name = "sGrade";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.quadro,
			this.barra0,
			this.barra1,
			this.barra2,
			this.barra3,
			this.barra4,
			this.barra5,
			this.rastelo,
			this.eixo,
			this.motor,
			this.tSent,
			this.txSob,
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
			this.SymbolSize = new System.Drawing.Size(70, 128);

		}
		private NxtControl.GuiFramework.Rectangle quadro;
		private NxtControl.GuiFramework.Line barra0;
		private NxtControl.GuiFramework.Line barra1;
		private NxtControl.GuiFramework.Line barra2;
		private NxtControl.GuiFramework.Line barra3;
		private NxtControl.GuiFramework.Line barra4;
		private NxtControl.GuiFramework.Line barra5;
		private NxtControl.GuiFramework.Rectangle rastelo;
		private NxtControl.GuiFramework.Rectangle eixo;
		private NxtControl.GuiFramework.Rectangle motor;
		private NxtControl.GuiFramework.FreeText tSent;
		private NxtControl.GuiFramework.FreeText txSob;
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
