/*
 * Hidryco - Agua_Reuso - sDefault
 * ISA-101: agua de reuso - niveis dos dois PIT, boia LSL-01 e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Agua_Reuso
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.r1 = new NxtControl.GuiFramework.FreeText();
			this.v1 = new NxtControl.GuiFramework.FreeText();
			this.r2 = new NxtControl.GuiFramework.FreeText();
			this.v2 = new NxtControl.GuiFramework.FreeText();
			this.r3 = new NxtControl.GuiFramework.FreeText();
			this.v3 = new NxtControl.GuiFramework.FreeText();
			this.xN1 = new System.HMI.Symbols.Base.Execute<float>();
			this.xP1 = new System.HMI.Symbols.Base.Execute<float>();
			this.xN2 = new System.HMI.Symbols.Base.Execute<float>();
			this.xP2 = new System.HMI.Symbols.Base.Execute<float>();
			this.xC1 = new System.HMI.Symbols.Base.Execute<short>();
			this.xC2 = new System.HMI.Symbols.Base.Execute<short>();
			this.xBoia = new System.HMI.Symbols.Base.Execute<bool>();
			this.xNivelBaixo = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRem1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRem2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xENivelBaixo = new System.HMI.Symbols.Base.Execute<byte>();
			this.xERem1 = new System.HMI.Symbols.Base.Execute<byte>();
			this.xERem2 = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(86D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(140D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(154D, 4D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(150D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(150D, 19D),
			new NxtControl.Drawing.PointF(158D, 3D),
			new NxtControl.Drawing.PointF(166D, 19D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(155D, 7D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(170D, 3D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// r1
			// 
			this.r1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.r1.Location = new NxtControl.Drawing.PointF(8D, 22D);
			this.r1.Name = "r1";
			this.r1.Text = "PIT-01";
			// 
			// v1
			// 
			this.v1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v1.Location = new NxtControl.Drawing.PointF(62D, 21D);
			this.v1.Name = "v1";
			this.v1.Text = "0.00 m  (0 %)";
			// 
			// r2
			// 
			this.r2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.r2.Location = new NxtControl.Drawing.PointF(8D, 42D);
			this.r2.Name = "r2";
			this.r2.Text = "PIT-02";
			// 
			// v2
			// 
			this.v2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v2.Location = new NxtControl.Drawing.PointF(62D, 41D);
			this.v2.Name = "v2";
			this.v2.Text = "0.00 m  (0 %)";
			// 
			// r3
			// 
			this.r3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.r3.Location = new NxtControl.Drawing.PointF(8D, 62D);
			this.r3.Name = "r3";
			this.r3.Text = "LSL-01";
			// 
			// v3
			// 
			this.v3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v3.Location = new NxtControl.Drawing.PointF(62D, 61D);
			this.v3.Name = "v3";
			this.v3.Text = "normal";
			// 
			// xN1
			// 
			this.xN1.BeginInit();
			this.xN1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xN1.IsOnlyInput = true;
			this.xN1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xN1.Name = "xN1";
			this.xN1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xN1.TagName = "STS_NIVEL_01";
			this.xN1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.N1ValueChanged);
			this.xN1.EndInit();
			// 
			// xP1
			// 
			this.xP1.BeginInit();
			this.xP1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xP1.IsOnlyInput = true;
			this.xP1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xP1.Name = "xP1";
			this.xP1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xP1.TagName = "STS_PORCENTAGEM_01";
			this.xP1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.P1ValueChanged);
			this.xP1.EndInit();
			// 
			// xN2
			// 
			this.xN2.BeginInit();
			this.xN2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xN2.IsOnlyInput = true;
			this.xN2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xN2.Name = "xN2";
			this.xN2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xN2.TagName = "STS_NIVEL_02";
			this.xN2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.N2ValueChanged);
			this.xN2.EndInit();
			// 
			// xP2
			// 
			this.xP2.BeginInit();
			this.xP2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xP2.IsOnlyInput = true;
			this.xP2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xP2.Name = "xP2";
			this.xP2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xP2.TagName = "STS_PORCENTAGEM_02";
			this.xP2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.P2ValueChanged);
			this.xP2.EndInit();
			// 
			// xC1
			// 
			this.xC1.BeginInit();
			this.xC1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1.IsOnlyInput = true;
			this.xC1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1.Name = "xC1";
			this.xC1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1.TagName = "STS_COND_01";
			this.xC1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.C1ValueChanged);
			this.xC1.EndInit();
			// 
			// xC2
			// 
			this.xC2.BeginInit();
			this.xC2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2.IsOnlyInput = true;
			this.xC2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2.Name = "xC2";
			this.xC2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2.TagName = "STS_COND_02";
			this.xC2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.C2ValueChanged);
			this.xC2.EndInit();
			// 
			// xBoia
			// 
			this.xBoia.BeginInit();
			this.xBoia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBoia.IsOnlyInput = true;
			this.xBoia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBoia.Name = "xBoia";
			this.xBoia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBoia.TagName = "STS_BOIA_NORMAL";
			this.xBoia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BoiaValueChanged);
			this.xBoia.EndInit();
			// 
			// xNivelBaixo
			// 
			this.xNivelBaixo.BeginInit();
			this.xNivelBaixo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNivelBaixo.IsOnlyInput = true;
			this.xNivelBaixo.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNivelBaixo.Name = "xNivelBaixo";
			this.xNivelBaixo.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNivelBaixo.TagName = "STS_NIVEL_BAIXO";
			this.xNivelBaixo.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NivelBaixoValueChanged);
			this.xNivelBaixo.EndInit();
			// 
			// xRem1
			// 
			this.xRem1.BeginInit();
			this.xRem1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRem1.IsOnlyInput = true;
			this.xRem1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRem1.Name = "xRem1";
			this.xRem1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRem1.TagName = "STS_FALHA_REMOTA1";
			this.xRem1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Rem1ValueChanged);
			this.xRem1.EndInit();
			// 
			// xRem2
			// 
			this.xRem2.BeginInit();
			this.xRem2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRem2.IsOnlyInput = true;
			this.xRem2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRem2.Name = "xRem2";
			this.xRem2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRem2.TagName = "STS_FALHA_REMOTA2";
			this.xRem2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Rem2ValueChanged);
			this.xRem2.EndInit();
			// 
			// xENivelBaixo
			// 
			this.xENivelBaixo.BeginInit();
			this.xENivelBaixo.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xENivelBaixo.IsOnlyInput = true;
			this.xENivelBaixo.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xENivelBaixo.Name = "xENivelBaixo";
			this.xENivelBaixo.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xENivelBaixo.TagName = "STS_ALM_NIVEL_BAIXO_EST";
			this.xENivelBaixo.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ENivelBaixoValueChanged);
			this.xENivelBaixo.EndInit();
			// 
			// xERem1
			// 
			this.xERem1.BeginInit();
			this.xERem1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xERem1.IsOnlyInput = true;
			this.xERem1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xERem1.Name = "xERem1";
			this.xERem1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xERem1.TagName = "STS_ALM_REMOTA1_EST";
			this.xERem1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ERem1ValueChanged);
			this.xERem1.EndInit();
			// 
			// xERem2
			// 
			this.xERem2.BeginInit();
			this.xERem2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xERem2.IsOnlyInput = true;
			this.xERem2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xERem2.Name = "xERem2";
			this.xERem2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xERem2.TagName = "STS_ALM_REMOTA2_EST";
			this.xERem2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ERem2ValueChanged);
			this.xERem2.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(250D)), ((float)(86D)));
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
			// sDefault
			// 
			this.Name = "sDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.InstanceName,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.r1,
			this.v1,
			this.r2,
			this.v2,
			this.r3,
			this.v3,
			this.xN1,
			this.xP1,
			this.xN2,
			this.xP2,
			this.xC1,
			this.xC2,
			this.xBoia,
			this.xNivelBaixo,
			this.xRem1,
			this.xRem2,
			this.xENivelBaixo,
			this.xERem1,
			this.xERem2,
			this.abrir});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText r1;
		private NxtControl.GuiFramework.FreeText v1;
		private NxtControl.GuiFramework.FreeText r2;
		private NxtControl.GuiFramework.FreeText v2;
		private NxtControl.GuiFramework.FreeText r3;
		private NxtControl.GuiFramework.FreeText v3;
		private System.HMI.Symbols.Base.Execute<float> xN1;
		private System.HMI.Symbols.Base.Execute<float> xP1;
		private System.HMI.Symbols.Base.Execute<float> xN2;
		private System.HMI.Symbols.Base.Execute<float> xP2;
		private System.HMI.Symbols.Base.Execute<short> xC1;
		private System.HMI.Symbols.Base.Execute<short> xC2;
		private System.HMI.Symbols.Base.Execute<bool> xBoia;
		private System.HMI.Symbols.Base.Execute<bool> xNivelBaixo;
		private System.HMI.Symbols.Base.Execute<bool> xRem1;
		private System.HMI.Symbols.Base.Execute<bool> xRem2;
		private System.HMI.Symbols.Base.Execute<byte> xENivelBaixo;
		private System.HMI.Symbols.Base.Execute<byte> xERem1;
		private System.HMI.Symbols.Base.Execute<byte> xERem2;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
