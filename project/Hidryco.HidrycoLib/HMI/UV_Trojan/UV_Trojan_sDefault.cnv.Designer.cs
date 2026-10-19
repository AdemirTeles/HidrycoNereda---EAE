/*
 * Hidryco - UV_Trojan - sDefault
 * ISA-101: UV - estado dos dois canais, dose, UVT, vazao e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UV_Trojan
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
			this.c1Box = new NxtControl.GuiFramework.Rectangle();
			this.c1Txt = new NxtControl.GuiFramework.FreeText();
			this.c2Box = new NxtControl.GuiFramework.Rectangle();
			this.c2Txt = new NxtControl.GuiFramework.FreeText();
			this.vDose = new NxtControl.GuiFramework.FreeText();
			this.vVaz = new NxtControl.GuiFramework.FreeText();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAMEN = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAMAI = new System.HMI.Symbols.Base.Execute<bool>();
			this.xACRI = new System.HMI.Symbols.Base.Execute<bool>();
			this.xALIM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xSCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDBX = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCINS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xVAZ = new System.HMI.Symbols.Base.Execute<float>();
			this.xDOSE = new System.HMI.Symbols.Base.Execute<float>();
			this.xUVT = new System.HMI.Symbols.Base.Execute<float>();
			this.xC1OP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2OP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1AL = new System.HMI.Symbols.Base.Execute<short>();
			this.xC2AL = new System.HMI.Symbols.Base.Execute<short>();
			this.xC1NB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2NB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1OF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2OF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1MA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2MA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC1NR = new System.HMI.Symbols.Base.Execute<bool>();
			this.xC2NR = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLCIC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xECRI = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMAI = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMEN = new System.HMI.Symbols.Base.Execute<byte>();
			this.xELIM = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(300D)), ((float)(112D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(150D)), ((float)(16D)));
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
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(164D, 4D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(160D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(160D, 19D),
			new NxtControl.Drawing.PointF(168D, 3D),
			new NxtControl.Drawing.PointF(176D, 19D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(165D, 6D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(180D, 3D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// c1Box
			// 
			this.c1Box.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(26D)), ((float)(14D)), ((float)(14D)));
			this.c1Box.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.c1Box.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.c1Box.Name = "c1Box";
			this.c1Box.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// c1Txt
			// 
			this.c1Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.c1Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.c1Txt.Location = new NxtControl.Drawing.PointF(28D, 25D);
			this.c1Txt.Name = "c1Txt";
			this.c1Txt.Text = "";
			// 
			// c2Box
			// 
			this.c2Box.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(46D)), ((float)(14D)), ((float)(14D)));
			this.c2Box.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.c2Box.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.c2Box.Name = "c2Box";
			this.c2Box.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// c2Txt
			// 
			this.c2Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.c2Txt.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.c2Txt.Location = new NxtControl.Drawing.PointF(28D, 45D);
			this.c2Txt.Name = "c2Txt";
			this.c2Txt.Text = "";
			// 
			// vDose
			// 
			this.vDose.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vDose.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.vDose.Location = new NxtControl.Drawing.PointF(8D, 68D);
			this.vDose.Name = "vDose";
			this.vDose.Text = "";
			// 
			// vVaz
			// 
			this.vVaz.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.vVaz.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.vVaz.Location = new NxtControl.Drawing.PointF(8D, 88D);
			this.vVaz.Name = "vVaz";
			this.vVaz.Text = "";
			// 
			// xFCOM
			// 
			this.xFCOM.BeginInit();
			this.xFCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFCOM.IsOnlyInput = true;
			this.xFCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFCOM.Name = "xFCOM";
			this.xFCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFCOM.TagName = "STS_FALHA_COMUNICACAO";
			this.xFCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFCOMValueChanged);
			this.xFCOM.EndInit();
			// 
			// xAMEN
			// 
			this.xAMEN.BeginInit();
			this.xAMEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAMEN.IsOnlyInput = true;
			this.xAMEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAMEN.Name = "xAMEN";
			this.xAMEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAMEN.TagName = "STS_ALM_MENOR";
			this.xAMEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAMENValueChanged);
			this.xAMEN.EndInit();
			// 
			// xAMAI
			// 
			this.xAMAI.BeginInit();
			this.xAMAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAMAI.IsOnlyInput = true;
			this.xAMAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAMAI.Name = "xAMAI";
			this.xAMAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAMAI.TagName = "STS_ALM_MAIOR";
			this.xAMAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAMAIValueChanged);
			this.xAMAI.EndInit();
			// 
			// xACRI
			// 
			this.xACRI.BeginInit();
			this.xACRI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xACRI.IsOnlyInput = true;
			this.xACRI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xACRI.Name = "xACRI";
			this.xACRI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xACRI.TagName = "STS_ALM_CRITICO";
			this.xACRI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XACRIValueChanged);
			this.xACRI.EndInit();
			// 
			// xALIM
			// 
			this.xALIM.BeginInit();
			this.xALIM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xALIM.IsOnlyInput = true;
			this.xALIM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xALIM.Name = "xALIM";
			this.xALIM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xALIM.TagName = "STS_ALM_LIMPEZA";
			this.xALIM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XALIMValueChanged);
			this.xALIM.EndInit();
			// 
			// xSCOM
			// 
			this.xSCOM.BeginInit();
			this.xSCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSCOM.IsOnlyInput = true;
			this.xSCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSCOM.Name = "xSCOM";
			this.xSCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSCOM.TagName = "STS_SCADA_COM_FALHA";
			this.xSCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSCOMValueChanged);
			this.xSCOM.EndInit();
			// 
			// xDBX
			// 
			this.xDBX.BeginInit();
			this.xDBX.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDBX.IsOnlyInput = true;
			this.xDBX.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDBX.Name = "xDBX";
			this.xDBX.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDBX.TagName = "STS_DOSE_BAIXA";
			this.xDBX.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDBXValueChanged);
			this.xDBX.EndInit();
			// 
			// xCINS
			// 
			this.xCINS.BeginInit();
			this.xCINS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCINS.IsOnlyInput = true;
			this.xCINS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCINS.Name = "xCINS";
			this.xCINS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCINS.TagName = "STS_CANAIS_INSUFICIENTES";
			this.xCINS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCINSValueChanged);
			this.xCINS.EndInit();
			// 
			// xVAZ
			// 
			this.xVAZ.BeginInit();
			this.xVAZ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVAZ.IsOnlyInput = true;
			this.xVAZ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVAZ.Name = "xVAZ";
			this.xVAZ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVAZ.TagName = "STS_VAZAO";
			this.xVAZ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVAZValueChanged);
			this.xVAZ.EndInit();
			// 
			// xDOSE
			// 
			this.xDOSE.BeginInit();
			this.xDOSE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDOSE.IsOnlyInput = true;
			this.xDOSE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDOSE.Name = "xDOSE";
			this.xDOSE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDOSE.TagName = "STS_DOSE";
			this.xDOSE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDOSEValueChanged);
			this.xDOSE.EndInit();
			// 
			// xUVT
			// 
			this.xUVT.BeginInit();
			this.xUVT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xUVT.IsOnlyInput = true;
			this.xUVT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xUVT.Name = "xUVT";
			this.xUVT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xUVT.TagName = "STS_UVT";
			this.xUVT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XUVTValueChanged);
			this.xUVT.EndInit();
			// 
			// xC1OP
			// 
			this.xC1OP.BeginInit();
			this.xC1OP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1OP.IsOnlyInput = true;
			this.xC1OP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1OP.Name = "xC1OP";
			this.xC1OP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1OP.TagName = "STS_CH1_OPERANDO";
			this.xC1OP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1OPValueChanged);
			this.xC1OP.EndInit();
			// 
			// xC2OP
			// 
			this.xC2OP.BeginInit();
			this.xC2OP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2OP.IsOnlyInput = true;
			this.xC2OP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2OP.Name = "xC2OP";
			this.xC2OP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2OP.TagName = "STS_CH2_OPERANDO";
			this.xC2OP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2OPValueChanged);
			this.xC2OP.EndInit();
			// 
			// xC1AL
			// 
			this.xC1AL.BeginInit();
			this.xC1AL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1AL.IsOnlyInput = true;
			this.xC1AL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1AL.Name = "xC1AL";
			this.xC1AL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1AL.TagName = "STS_CH1_ALARME";
			this.xC1AL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1ALValueChanged);
			this.xC1AL.EndInit();
			// 
			// xC2AL
			// 
			this.xC2AL.BeginInit();
			this.xC2AL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2AL.IsOnlyInput = true;
			this.xC2AL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2AL.Name = "xC2AL";
			this.xC2AL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2AL.TagName = "STS_CH2_ALARME";
			this.xC2AL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2ALValueChanged);
			this.xC2AL.EndInit();
			// 
			// xC1NB
			// 
			this.xC1NB.BeginInit();
			this.xC1NB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1NB.IsOnlyInput = true;
			this.xC1NB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1NB.Name = "xC1NB";
			this.xC1NB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1NB.TagName = "STS_CH1_NIVEL_BAIXO";
			this.xC1NB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1NBValueChanged);
			this.xC1NB.EndInit();
			// 
			// xC2NB
			// 
			this.xC2NB.BeginInit();
			this.xC2NB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2NB.IsOnlyInput = true;
			this.xC2NB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2NB.Name = "xC2NB";
			this.xC2NB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2NB.TagName = "STS_CH2_NIVEL_BAIXO";
			this.xC2NB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2NBValueChanged);
			this.xC2NB.EndInit();
			// 
			// xC1OF
			// 
			this.xC1OF.BeginInit();
			this.xC1OF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1OF.IsOnlyInput = true;
			this.xC1OF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1OF.Name = "xC1OF";
			this.xC1OF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1OF.TagName = "STS_CH1_OFFLINE";
			this.xC1OF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1OFValueChanged);
			this.xC1OF.EndInit();
			// 
			// xC2OF
			// 
			this.xC2OF.BeginInit();
			this.xC2OF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2OF.IsOnlyInput = true;
			this.xC2OF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2OF.Name = "xC2OF";
			this.xC2OF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2OF.TagName = "STS_CH2_OFFLINE";
			this.xC2OF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2OFValueChanged);
			this.xC2OF.EndInit();
			// 
			// xC1MA
			// 
			this.xC1MA.BeginInit();
			this.xC1MA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1MA.IsOnlyInput = true;
			this.xC1MA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1MA.Name = "xC1MA";
			this.xC1MA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1MA.TagName = "STS_CH1_MANUTENCAO";
			this.xC1MA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1MAValueChanged);
			this.xC1MA.EndInit();
			// 
			// xC2MA
			// 
			this.xC2MA.BeginInit();
			this.xC2MA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2MA.IsOnlyInput = true;
			this.xC2MA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2MA.Name = "xC2MA";
			this.xC2MA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2MA.TagName = "STS_CH2_MANUTENCAO";
			this.xC2MA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2MAValueChanged);
			this.xC2MA.EndInit();
			// 
			// xC1NR
			// 
			this.xC1NR.BeginInit();
			this.xC1NR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC1NR.IsOnlyInput = true;
			this.xC1NR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC1NR.Name = "xC1NR";
			this.xC1NR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC1NR.TagName = "STS_CH1_NAO_REMOTO";
			this.xC1NR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC1NRValueChanged);
			this.xC1NR.EndInit();
			// 
			// xC2NR
			// 
			this.xC2NR.BeginInit();
			this.xC2NR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xC2NR.IsOnlyInput = true;
			this.xC2NR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xC2NR.Name = "xC2NR";
			this.xC2NR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xC2NR.TagName = "STS_CH2_NAO_REMOTO";
			this.xC2NR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XC2NRValueChanged);
			this.xC2NR.EndInit();
			// 
			// xLCIC
			// 
			this.xLCIC.BeginInit();
			this.xLCIC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLCIC.IsOnlyInput = true;
			this.xLCIC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLCIC.Name = "xLCIC";
			this.xLCIC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLCIC.TagName = "STS_LIMP_EM_CICLO";
			this.xLCIC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XLCICValueChanged);
			this.xLCIC.EndInit();
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
			// xECRI
			// 
			this.xECRI.BeginInit();
			this.xECRI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECRI.IsOnlyInput = true;
			this.xECRI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECRI.Name = "xECRI";
			this.xECRI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECRI.TagName = "STS_ALM_CRITICO_EST";
			this.xECRI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XECRIValueChanged);
			this.xECRI.EndInit();
			// 
			// xEMAI
			// 
			this.xEMAI.BeginInit();
			this.xEMAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMAI.IsOnlyInput = true;
			this.xEMAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMAI.Name = "xEMAI";
			this.xEMAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMAI.TagName = "STS_ALM_MAIOR_EST";
			this.xEMAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMAIValueChanged);
			this.xEMAI.EndInit();
			// 
			// xEMEN
			// 
			this.xEMEN.BeginInit();
			this.xEMEN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMEN.IsOnlyInput = true;
			this.xEMEN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMEN.Name = "xEMEN";
			this.xEMEN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMEN.TagName = "STS_ALM_MENOR_EST";
			this.xEMEN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMENValueChanged);
			this.xEMEN.EndInit();
			// 
			// xELIM
			// 
			this.xELIM.BeginInit();
			this.xELIM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xELIM.IsOnlyInput = true;
			this.xELIM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xELIM.Name = "xELIM";
			this.xELIM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xELIM.TagName = "STS_ALM_LIMPEZA_EST";
			this.xELIM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XELIMValueChanged);
			this.xELIM.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(300D)), ((float)(112D)));
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
			this.c1Box,
			this.c1Txt,
			this.c2Box,
			this.c2Txt,
			this.vDose,
			this.vVaz,
			this.xFCOM,
			this.xAMEN,
			this.xAMAI,
			this.xACRI,
			this.xALIM,
			this.xSCOM,
			this.xDBX,
			this.xCINS,
			this.xVAZ,
			this.xDOSE,
			this.xUVT,
			this.xC1OP,
			this.xC2OP,
			this.xC1AL,
			this.xC2AL,
			this.xC1NB,
			this.xC2NB,
			this.xC1OF,
			this.xC2OF,
			this.xC1MA,
			this.xC2MA,
			this.xC1NR,
			this.xC2NR,
			this.xLCIC,
			this.xECOM,
			this.xECRI,
			this.xEMAI,
			this.xEMEN,
			this.xELIM,
			this.abrir});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.Rectangle c1Box;
		private NxtControl.GuiFramework.FreeText c1Txt;
		private NxtControl.GuiFramework.Rectangle c2Box;
		private NxtControl.GuiFramework.FreeText c2Txt;
		private NxtControl.GuiFramework.FreeText vDose;
		private NxtControl.GuiFramework.FreeText vVaz;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xAMEN;
		private System.HMI.Symbols.Base.Execute<bool> xAMAI;
		private System.HMI.Symbols.Base.Execute<bool> xACRI;
		private System.HMI.Symbols.Base.Execute<bool> xALIM;
		private System.HMI.Symbols.Base.Execute<bool> xSCOM;
		private System.HMI.Symbols.Base.Execute<bool> xDBX;
		private System.HMI.Symbols.Base.Execute<bool> xCINS;
		private System.HMI.Symbols.Base.Execute<float> xVAZ;
		private System.HMI.Symbols.Base.Execute<float> xDOSE;
		private System.HMI.Symbols.Base.Execute<float> xUVT;
		private System.HMI.Symbols.Base.Execute<bool> xC1OP;
		private System.HMI.Symbols.Base.Execute<bool> xC2OP;
		private System.HMI.Symbols.Base.Execute<short> xC1AL;
		private System.HMI.Symbols.Base.Execute<short> xC2AL;
		private System.HMI.Symbols.Base.Execute<bool> xC1NB;
		private System.HMI.Symbols.Base.Execute<bool> xC2NB;
		private System.HMI.Symbols.Base.Execute<bool> xC1OF;
		private System.HMI.Symbols.Base.Execute<bool> xC2OF;
		private System.HMI.Symbols.Base.Execute<bool> xC1MA;
		private System.HMI.Symbols.Base.Execute<bool> xC2MA;
		private System.HMI.Symbols.Base.Execute<bool> xC1NR;
		private System.HMI.Symbols.Base.Execute<bool> xC2NR;
		private System.HMI.Symbols.Base.Execute<bool> xLCIC;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xECRI;
		private System.HMI.Symbols.Base.Execute<byte> xEMAI;
		private System.HMI.Symbols.Base.Execute<byte> xEMEN;
		private System.HMI.Symbols.Base.Execute<byte> xELIM;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
