/*
 * Hidryco - Valvula_Coester - sValvula
 * ISA-101: valvula com atuador (corpo cheio = aberta, vazio = fechada, meio = intermediaria), posicao, modo e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Valvula_Coester
{
	/// <summary>
	/// Summary description for sValvula.
	/// </summary>
	partial class sValvula
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.atuador = new NxtControl.GuiFramework.Rectangle();
			this.haste = new NxtControl.GuiFramework.Rectangle();
			this.corpoE = new NxtControl.GuiFramework.Polygon();
			this.corpoD = new NxtControl.GuiFramework.Polygon();
			this.tModo = new NxtControl.GuiFramework.FreeText();
			this.tPos = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.xANIM = new System.HMI.Symbols.Base.Execute<short>();
			this.xPOS = new System.HMI.Symbols.Base.Execute<float>();
			this.xREF = new System.HMI.Symbols.Base.Execute<float>();
			this.xAUTO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLOC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDESL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFATU = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFPOS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCOD = new System.HMI.Symbols.Base.Execute<short>();
			this.xACFG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAPART = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBLOQ = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDISP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMOD = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCMDM = new System.HMI.Symbols.Base.Execute<short>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEATU = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPOS = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(130D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// atuador
			// 
			this.atuador.Bounds = new NxtControl.Drawing.RectF(((float)(50D)), ((float)(20D)), ((float)(30D)), ((float)(18D)));
			this.atuador.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.atuador.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.atuador.Name = "atuador";
			this.atuador.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// haste
			// 
			this.haste.Bounds = new NxtControl.Drawing.RectF(((float)(63D)), ((float)(38D)), ((float)(4D)), ((float)(12D)));
			this.haste.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.haste.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.haste.Name = "haste";
			this.haste.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// corpoE
			// 
			this.corpoE.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(50D)), ((float)(45D)), ((float)(44D)));
			this.corpoE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.corpoE.Closed = true;
			this.corpoE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpoE.Name = "corpoE";
			this.corpoE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.corpoE.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 50D),
			new NxtControl.Drawing.PointF(65D, 72D),
			new NxtControl.Drawing.PointF(20D, 94D)});
			// 
			// corpoD
			// 
			this.corpoD.Bounds = new NxtControl.Drawing.RectF(((float)(65D)), ((float)(50D)), ((float)(45D)), ((float)(44D)));
			this.corpoD.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.corpoD.Closed = true;
			this.corpoD.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpoD.Name = "corpoD";
			this.corpoD.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.corpoD.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(110D, 50D),
			new NxtControl.Drawing.PointF(65D, 72D),
			new NxtControl.Drawing.PointF(110D, 94D)});
			// 
			// tModo
			// 
			this.tModo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tModo.Location = new NxtControl.Drawing.PointF(4D, 22D);
			this.tModo.Name = "tModo";
			this.tModo.Text = "A";
			// 
			// tPos
			// 
			this.tPos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPos.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tPos.Location = new NxtControl.Drawing.PointF(42D, 100D);
			this.tPos.Name = "tPos";
			this.tPos.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(21D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(96D, 22D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(92D)), ((float)(21D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(92D, 37D),
			new NxtControl.Drawing.PointF(100D, 21D),
			new NxtControl.Drawing.PointF(108D, 37D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(97D, 24D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(112D, 21D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// xANIM
			// 
			this.xANIM.BeginInit();
			this.xANIM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xANIM.IsOnlyInput = true;
			this.xANIM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xANIM.Name = "xANIM";
			this.xANIM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xANIM.TagName = "STS_ANIMACAO";
			this.xANIM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XANIMValueChanged);
			this.xANIM.EndInit();
			// 
			// xPOS
			// 
			this.xPOS.BeginInit();
			this.xPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPOS.IsOnlyInput = true;
			this.xPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPOS.Name = "xPOS";
			this.xPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPOS.TagName = "STS_POSICAO";
			this.xPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XPOSValueChanged);
			this.xPOS.EndInit();
			// 
			// xREF
			// 
			this.xREF.BeginInit();
			this.xREF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xREF.IsOnlyInput = true;
			this.xREF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xREF.Name = "xREF";
			this.xREF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xREF.TagName = "STS_POSICAO_REFERENCIA";
			this.xREF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XREFValueChanged);
			this.xREF.EndInit();
			// 
			// xAUTO
			// 
			this.xAUTO.BeginInit();
			this.xAUTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAUTO.IsOnlyInput = true;
			this.xAUTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAUTO.Name = "xAUTO";
			this.xAUTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAUTO.TagName = "STS_AUTOMATICO";
			this.xAUTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAUTOValueChanged);
			this.xAUTO.EndInit();
			// 
			// xREM
			// 
			this.xREM.BeginInit();
			this.xREM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xREM.IsOnlyInput = true;
			this.xREM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xREM.Name = "xREM";
			this.xREM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xREM.TagName = "STS_REMOTO";
			this.xREM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XREMValueChanged);
			this.xREM.EndInit();
			// 
			// xLOC
			// 
			this.xLOC.BeginInit();
			this.xLOC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLOC.IsOnlyInput = true;
			this.xLOC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLOC.Name = "xLOC";
			this.xLOC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLOC.TagName = "STS_LOCAL";
			this.xLOC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XLOCValueChanged);
			this.xLOC.EndInit();
			// 
			// xDESL
			// 
			this.xDESL.BeginInit();
			this.xDESL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDESL.IsOnlyInput = true;
			this.xDESL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDESL.Name = "xDESL";
			this.xDESL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDESL.TagName = "STS_DESLIGADO";
			this.xDESL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDESLValueChanged);
			this.xDESL.EndInit();
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
			// xFATU
			// 
			this.xFATU.BeginInit();
			this.xFATU.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFATU.IsOnlyInput = true;
			this.xFATU.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFATU.Name = "xFATU";
			this.xFATU.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFATU.TagName = "STS_FALHA_ATUADOR";
			this.xFATU.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFATUValueChanged);
			this.xFATU.EndInit();
			// 
			// xFPOS
			// 
			this.xFPOS.BeginInit();
			this.xFPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFPOS.IsOnlyInput = true;
			this.xFPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFPOS.Name = "xFPOS";
			this.xFPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFPOS.TagName = "STS_FALHA_POSICAO";
			this.xFPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFPOSValueChanged);
			this.xFPOS.EndInit();
			// 
			// xCOD
			// 
			this.xCOD.BeginInit();
			this.xCOD.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCOD.IsOnlyInput = true;
			this.xCOD.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCOD.Name = "xCOD";
			this.xCOD.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCOD.TagName = "STS_CODIGO_FALHA";
			this.xCOD.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCODValueChanged);
			this.xCOD.EndInit();
			// 
			// xACFG
			// 
			this.xACFG.BeginInit();
			this.xACFG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xACFG.IsOnlyInput = true;
			this.xACFG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xACFG.Name = "xACFG";
			this.xACFG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xACFG.TagName = "STS_AVISO_CONFIG";
			this.xACFG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XACFGValueChanged);
			this.xACFG.EndInit();
			// 
			// xAPART
			// 
			this.xAPART.BeginInit();
			this.xAPART.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAPART.IsOnlyInput = true;
			this.xAPART.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAPART.Name = "xAPART";
			this.xAPART.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAPART.TagName = "STS_AVISO_PARTIDAS";
			this.xAPART.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAPARTValueChanged);
			this.xAPART.EndInit();
			// 
			// xBLOQ
			// 
			this.xBLOQ.BeginInit();
			this.xBLOQ.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBLOQ.IsOnlyInput = true;
			this.xBLOQ.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBLOQ.Name = "xBLOQ";
			this.xBLOQ.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBLOQ.TagName = "STS_BLOQUEADO";
			this.xBLOQ.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XBLOQValueChanged);
			this.xBLOQ.EndInit();
			// 
			// xDISP
			// 
			this.xDISP.BeginInit();
			this.xDISP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDISP.IsOnlyInput = true;
			this.xDISP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDISP.Name = "xDISP";
			this.xDISP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDISP.TagName = "STS_DISPONIVEL_AUTOMATICO";
			this.xDISP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XDISPValueChanged);
			this.xDISP.EndInit();
			// 
			// xMOD
			// 
			this.xMOD.BeginInit();
			this.xMOD.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMOD.IsOnlyInput = true;
			this.xMOD.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMOD.Name = "xMOD";
			this.xMOD.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMOD.TagName = "STS_MODULANTE";
			this.xMOD.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XMODValueChanged);
			this.xMOD.EndInit();
			// 
			// xCMDM
			// 
			this.xCMDM.BeginInit();
			this.xCMDM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCMDM.IsOnlyInput = true;
			this.xCMDM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCMDM.Name = "xCMDM";
			this.xCMDM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCMDM.TagName = "STS_CMD_MANUAL";
			this.xCMDM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCMDMValueChanged);
			this.xCMDM.EndInit();
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
			// xEATU
			// 
			this.xEATU.BeginInit();
			this.xEATU.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEATU.IsOnlyInput = true;
			this.xEATU.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEATU.Name = "xEATU";
			this.xEATU.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEATU.TagName = "STS_ALM_ATUADOR_EST";
			this.xEATU.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEATUValueChanged);
			this.xEATU.EndInit();
			// 
			// xEPOS
			// 
			this.xEPOS.BeginInit();
			this.xEPOS.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPOS.IsOnlyInput = true;
			this.xEPOS.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPOS.Name = "xEPOS";
			this.xEPOS.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPOS.TagName = "STS_ALM_POSICAO_EST";
			this.xEPOS.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEPOSValueChanged);
			this.xEPOS.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(130D)), ((float)(124D)));
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
			// sValvula
			// 
			this.Name = "sValvula";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InstanceName,
			this.atuador,
			this.haste,
			this.corpoE,
			this.corpoD,
			this.tModo,
			this.tPos,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.xANIM,
			this.xPOS,
			this.xREF,
			this.xAUTO,
			this.xREM,
			this.xLOC,
			this.xDESL,
			this.xFCOM,
			this.xFATU,
			this.xFPOS,
			this.xCOD,
			this.xACFG,
			this.xAPART,
			this.xBLOQ,
			this.xDISP,
			this.xMOD,
			this.xCMDM,
			this.xECOM,
			this.xEATU,
			this.xEPOS,
			this.abrir});

		}
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle atuador;
		private NxtControl.GuiFramework.Rectangle haste;
		private NxtControl.GuiFramework.Polygon corpoE;
		private NxtControl.GuiFramework.Polygon corpoD;
		private NxtControl.GuiFramework.FreeText tModo;
		private NxtControl.GuiFramework.FreeText tPos;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private System.HMI.Symbols.Base.Execute<short> xANIM;
		private System.HMI.Symbols.Base.Execute<float> xPOS;
		private System.HMI.Symbols.Base.Execute<float> xREF;
		private System.HMI.Symbols.Base.Execute<bool> xAUTO;
		private System.HMI.Symbols.Base.Execute<bool> xREM;
		private System.HMI.Symbols.Base.Execute<bool> xLOC;
		private System.HMI.Symbols.Base.Execute<bool> xDESL;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xFATU;
		private System.HMI.Symbols.Base.Execute<bool> xFPOS;
		private System.HMI.Symbols.Base.Execute<short> xCOD;
		private System.HMI.Symbols.Base.Execute<bool> xACFG;
		private System.HMI.Symbols.Base.Execute<bool> xAPART;
		private System.HMI.Symbols.Base.Execute<bool> xBLOQ;
		private System.HMI.Symbols.Base.Execute<bool> xDISP;
		private System.HMI.Symbols.Base.Execute<bool> xMOD;
		private System.HMI.Symbols.Base.Execute<short> xCMDM;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xEATU;
		private System.HMI.Symbols.Base.Execute<byte> xEPOS;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
