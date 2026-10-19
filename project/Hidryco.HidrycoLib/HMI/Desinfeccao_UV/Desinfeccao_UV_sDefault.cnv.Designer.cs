/*
 * Hidryco - Desinfeccao_UV - sDefault
 * ISA-101: desinfeccao - vazao de lancamento x limite, controle da VC-01, totalizador, disjuntores e alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Desinfeccao_UV
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
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.l3 = new NxtControl.GuiFramework.FreeText();
			this.l4 = new NxtControl.GuiFramework.FreeText();
			this.l5 = new NxtControl.GuiFramework.FreeText();
			this.l6 = new NxtControl.GuiFramework.FreeText();
			this.xVAZ = new System.HMI.Symbols.Base.Execute<float>();
			this.xVMAX = new System.HMI.Symbols.Base.Execute<float>();
			this.xATIVO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMOT = new System.HMI.Symbols.Base.Execute<short>();
			this.xSPID = new System.HMI.Symbols.Base.Execute<float>();
			this.xVPOS = new System.HMI.Symbols.Base.Execute<float>();
			this.xFTF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xADJ = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAVR = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDPCE = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDPCM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDUV1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDUV2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDVC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDMO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEVA = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEVR = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEDJ = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEREM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xTOT = new System.HMI.Symbols.Base.Execute<int>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(150D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(180D)), ((float)(16D)));
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
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(194D, 4D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(190D)), ((float)(3D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(190D, 19D),
			new NxtControl.Drawing.PointF(198D, 3D),
			new NxtControl.Drawing.PointF(206D, 19D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(195D, 6D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(210D, 3D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.l1.Location = new NxtControl.Drawing.PointF(8D, 26D);
			this.l1.Name = "l1";
			this.l1.Text = "";
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(8D, 48D);
			this.l2.Name = "l2";
			this.l2.Text = "";
			// 
			// l3
			// 
			this.l3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l3.Location = new NxtControl.Drawing.PointF(8D, 68D);
			this.l3.Name = "l3";
			this.l3.Text = "";
			// 
			// l4
			// 
			this.l4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l4.Location = new NxtControl.Drawing.PointF(8D, 88D);
			this.l4.Name = "l4";
			this.l4.Text = "";
			// 
			// l5
			// 
			this.l5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.l5.Location = new NxtControl.Drawing.PointF(8D, 110D);
			this.l5.Name = "l5";
			this.l5.Text = "";
			// 
			// l6
			// 
			this.l6.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.l6.Location = new NxtControl.Drawing.PointF(8D, 128D);
			this.l6.Name = "l6";
			this.l6.Text = "";
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
			// xVMAX
			// 
			this.xVMAX.BeginInit();
			this.xVMAX.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVMAX.IsOnlyInput = true;
			this.xVMAX.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVMAX.Name = "xVMAX";
			this.xVMAX.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVMAX.TagName = "STS_VAZAO_MAX";
			this.xVMAX.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVMAXValueChanged);
			this.xVMAX.EndInit();
			// 
			// xATIVO
			// 
			this.xATIVO.BeginInit();
			this.xATIVO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xATIVO.IsOnlyInput = true;
			this.xATIVO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xATIVO.Name = "xATIVO";
			this.xATIVO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xATIVO.TagName = "STS_CONTROLE_ATIVO";
			this.xATIVO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XATIVOValueChanged);
			this.xATIVO.EndInit();
			// 
			// xMOT
			// 
			this.xMOT.BeginInit();
			this.xMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMOT.IsOnlyInput = true;
			this.xMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMOT.Name = "xMOT";
			this.xMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMOT.TagName = "STS_MOTIVO";
			this.xMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XMOTValueChanged);
			this.xMOT.EndInit();
			// 
			// xSPID
			// 
			this.xSPID.BeginInit();
			this.xSPID.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xSPID.IsOnlyInput = true;
			this.xSPID.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xSPID.Name = "xSPID";
			this.xSPID.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xSPID.TagName = "STS_SAIDA_PID";
			this.xSPID.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XSPIDValueChanged);
			this.xSPID.EndInit();
			// 
			// xVPOS
			// 
			this.xVPOS.BeginInit();
			this.xVPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVPOS.IsOnlyInput = true;
			this.xVPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVPOS.Name = "xVPOS";
			this.xVPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVPOS.TagName = "STS_VC_POSICAO";
			this.xVPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XVPOSValueChanged);
			this.xVPOS.EndInit();
			// 
			// xFTF
			// 
			this.xFTF.BeginInit();
			this.xFTF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFTF.IsOnlyInput = true;
			this.xFTF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFTF.Name = "xFTF";
			this.xFTF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFTF.TagName = "STS_FT_FALHA";
			this.xFTF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFTFValueChanged);
			this.xFTF.EndInit();
			// 
			// xREM
			// 
			this.xREM.BeginInit();
			this.xREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xREM.IsOnlyInput = true;
			this.xREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xREM.Name = "xREM";
			this.xREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xREM.TagName = "STS_REMOTA_OK";
			this.xREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XREMValueChanged);
			this.xREM.EndInit();
			// 
			// xADJ
			// 
			this.xADJ.BeginInit();
			this.xADJ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xADJ.IsOnlyInput = true;
			this.xADJ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xADJ.Name = "xADJ";
			this.xADJ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xADJ.TagName = "STS_AVISO_DISJUNTOR";
			this.xADJ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XADJValueChanged);
			this.xADJ.EndInit();
			// 
			// xAVA
			// 
			this.xAVA.BeginInit();
			this.xAVA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVA.IsOnlyInput = true;
			this.xAVA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVA.Name = "xAVA";
			this.xAVA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVA.TagName = "STS_ALARME_VAZAO_ALTA";
			this.xAVA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAVAValueChanged);
			this.xAVA.EndInit();
			// 
			// xAVR
			// 
			this.xAVR.BeginInit();
			this.xAVR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAVR.IsOnlyInput = true;
			this.xAVR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAVR.Name = "xAVR";
			this.xAVR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAVR.TagName = "STS_AVISO_VARIACAO";
			this.xAVR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAVRValueChanged);
			this.xAVR.EndInit();
			// 
			// xFREM
			// 
			this.xFREM.BeginInit();
			this.xFREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFREM.IsOnlyInput = true;
			this.xFREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFREM.Name = "xFREM";
			this.xFREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFREM.TagName = "STS_FALHA_REMOTA";
			this.xFREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFREMValueChanged);
			this.xFREM.EndInit();
			// 
			// xDPCE
			// 
			this.xDPCE.BeginInit();
			this.xDPCE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDPCE.IsOnlyInput = true;
			this.xDPCE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDPCE.Name = "xDPCE";
			this.xDPCE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDPCE.TagName = "STS_DJ_PCE_DESLIGADO";
			this.xDPCE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDPCEValueChanged);
			this.xDPCE.EndInit();
			// 
			// xDPCM
			// 
			this.xDPCM.BeginInit();
			this.xDPCM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDPCM.IsOnlyInput = true;
			this.xDPCM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDPCM.Name = "xDPCM";
			this.xDPCM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDPCM.TagName = "STS_DJ_PCM_DESLIGADO";
			this.xDPCM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDPCMValueChanged);
			this.xDPCM.EndInit();
			// 
			// xDUV1
			// 
			this.xDUV1.BeginInit();
			this.xDUV1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDUV1.IsOnlyInput = true;
			this.xDUV1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDUV1.Name = "xDUV1";
			this.xDUV1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDUV1.TagName = "STS_DJ_UV01";
			this.xDUV1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDUV1ValueChanged);
			this.xDUV1.EndInit();
			// 
			// xDUV2
			// 
			this.xDUV2.BeginInit();
			this.xDUV2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDUV2.IsOnlyInput = true;
			this.xDUV2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDUV2.Name = "xDUV2";
			this.xDUV2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDUV2.TagName = "STS_DJ_UV02";
			this.xDUV2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDUV2ValueChanged);
			this.xDUV2.EndInit();
			// 
			// xDVC
			// 
			this.xDVC.BeginInit();
			this.xDVC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDVC.IsOnlyInput = true;
			this.xDVC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDVC.Name = "xDVC";
			this.xDVC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDVC.TagName = "STS_DJ_VC01";
			this.xDVC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDVCValueChanged);
			this.xDVC.EndInit();
			// 
			// xDMO
			// 
			this.xDMO.BeginInit();
			this.xDMO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDMO.IsOnlyInput = true;
			this.xDMO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDMO.Name = "xDMO";
			this.xDMO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDMO.TagName = "STS_DJ_MO01";
			this.xDMO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDMOValueChanged);
			this.xDMO.EndInit();
			// 
			// xEVA
			// 
			this.xEVA.BeginInit();
			this.xEVA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVA.IsOnlyInput = true;
			this.xEVA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVA.Name = "xEVA";
			this.xEVA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVA.TagName = "STS_ALM_VAZAO_ALTA_EST";
			this.xEVA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEVAValueChanged);
			this.xEVA.EndInit();
			// 
			// xEVR
			// 
			this.xEVR.BeginInit();
			this.xEVR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEVR.IsOnlyInput = true;
			this.xEVR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEVR.Name = "xEVR";
			this.xEVR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEVR.TagName = "STS_ALM_VARIACAO_EST";
			this.xEVR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEVRValueChanged);
			this.xEVR.EndInit();
			// 
			// xEDJ
			// 
			this.xEDJ.BeginInit();
			this.xEDJ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEDJ.IsOnlyInput = true;
			this.xEDJ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEDJ.Name = "xEDJ";
			this.xEDJ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEDJ.TagName = "STS_ALM_DISJUNTOR_EST";
			this.xEDJ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEDJValueChanged);
			this.xEDJ.EndInit();
			// 
			// xEREM
			// 
			this.xEREM.BeginInit();
			this.xEREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEREM.IsOnlyInput = true;
			this.xEREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEREM.Name = "xEREM";
			this.xEREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEREM.TagName = "STS_ALM_REMOTA_EST";
			this.xEREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEREMValueChanged);
			this.xEREM.EndInit();
			// 
			// xTOT
			// 
			this.xTOT.BeginInit();
			this.xTOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTOT.IsOnlyInput = true;
			this.xTOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTOT.Name = "xTOT";
			this.xTOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTOT.TagName = "STS_TOTAL";
			this.xTOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XTOTValueChanged);
			this.xTOT.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(400D)), ((float)(150D)));
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
			this.l1,
			this.l2,
			this.l3,
			this.l4,
			this.l5,
			this.l6,
			this.xVAZ,
			this.xVMAX,
			this.xATIVO,
			this.xMOT,
			this.xSPID,
			this.xVPOS,
			this.xFTF,
			this.xREM,
			this.xADJ,
			this.xAVA,
			this.xAVR,
			this.xFREM,
			this.xDPCE,
			this.xDPCM,
			this.xDUV1,
			this.xDUV2,
			this.xDVC,
			this.xDMO,
			this.xEVA,
			this.xEVR,
			this.xEDJ,
			this.xEREM,
			this.xTOT,
			this.abrir});

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText l1;
		private NxtControl.GuiFramework.FreeText l2;
		private NxtControl.GuiFramework.FreeText l3;
		private NxtControl.GuiFramework.FreeText l4;
		private NxtControl.GuiFramework.FreeText l5;
		private NxtControl.GuiFramework.FreeText l6;
		private System.HMI.Symbols.Base.Execute<float> xVAZ;
		private System.HMI.Symbols.Base.Execute<float> xVMAX;
		private System.HMI.Symbols.Base.Execute<bool> xATIVO;
		private System.HMI.Symbols.Base.Execute<short> xMOT;
		private System.HMI.Symbols.Base.Execute<float> xSPID;
		private System.HMI.Symbols.Base.Execute<float> xVPOS;
		private System.HMI.Symbols.Base.Execute<bool> xFTF;
		private System.HMI.Symbols.Base.Execute<bool> xREM;
		private System.HMI.Symbols.Base.Execute<bool> xADJ;
		private System.HMI.Symbols.Base.Execute<bool> xAVA;
		private System.HMI.Symbols.Base.Execute<bool> xAVR;
		private System.HMI.Symbols.Base.Execute<bool> xFREM;
		private System.HMI.Symbols.Base.Execute<bool> xDPCE;
		private System.HMI.Symbols.Base.Execute<bool> xDPCM;
		private System.HMI.Symbols.Base.Execute<bool> xDUV1;
		private System.HMI.Symbols.Base.Execute<bool> xDUV2;
		private System.HMI.Symbols.Base.Execute<bool> xDVC;
		private System.HMI.Symbols.Base.Execute<bool> xDMO;
		private System.HMI.Symbols.Base.Execute<byte> xEVA;
		private System.HMI.Symbols.Base.Execute<byte> xEVR;
		private System.HMI.Symbols.Base.Execute<byte> xEDJ;
		private System.HMI.Symbols.Base.Execute<byte> xEREM;
		private System.HMI.Symbols.Base.Execute<int> xTOT;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
