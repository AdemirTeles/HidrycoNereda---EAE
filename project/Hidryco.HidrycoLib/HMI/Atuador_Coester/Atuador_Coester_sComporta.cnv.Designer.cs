/*
 * Hidryco - Valvula_Coester - sComporta
 * ISA-101: comporta com atuador (corpo cheio = aberta, vazio = fechada, meio = intermediaria), posicao, modo e indicador de alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester
{
	/// <summary>
	/// Summary description for sComporta.
	/// </summary>
	partial class sComporta
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.haste = new NxtControl.GuiFramework.Rectangle();
			this.atuador = new NxtControl.GuiFramework.Rectangle();
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
			this.xAUTO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xREM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLOC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDESL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFATU = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFPOS = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEATU = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPOS = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			this.cxRL = new NxtControl.GuiFramework.Rectangle();
			this.lnRL = new NxtControl.GuiFramework.Line();
			this.tRem = new NxtControl.GuiFramework.FreeText();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(110D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// haste
			// 
			this.haste.Bounds = new NxtControl.Drawing.RectF(((float)(43D)), ((float)(40D)), ((float)(4D)), ((float)(20D)));
			this.haste.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.haste.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.haste.Name = "haste";
			this.haste.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// atuador
			// 
			this.atuador.Bounds = new NxtControl.Drawing.RectF(((float)(31D)), ((float)(22D)), ((float)(28D)), ((float)(18D)));
			this.atuador.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))));
			this.atuador.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.atuador.Name = "atuador";
			this.atuador.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// corpoE
			// 
			this.corpoE.Bounds = new NxtControl.Drawing.RectF(((float)(29D)), ((float)(60D)), ((float)(32D)), ((float)(44D)));
			this.corpoE.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.corpoE.Closed = true;
			this.corpoE.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpoE.Name = "corpoE";
			this.corpoE.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.corpoE.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(29D, 60D),
			new NxtControl.Drawing.PointF(61D, 60D),
			new NxtControl.Drawing.PointF(61D, 104D),
			new NxtControl.Drawing.PointF(29D, 104D)});
			// 
			// corpoD
			// 
			this.corpoD.Bounds = new NxtControl.Drawing.RectF(((float)(23D)), ((float)(56D)), ((float)(44D)), ((float)(62D)));
			this.corpoD.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.corpoD.Closed = true;
			this.corpoD.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.corpoD.Name = "corpoD";
			this.corpoD.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.corpoD.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(23D, 56D),
			new NxtControl.Drawing.PointF(29D, 56D),
			new NxtControl.Drawing.PointF(29D, 112D),
			new NxtControl.Drawing.PointF(61D, 112D),
			new NxtControl.Drawing.PointF(61D, 56D),
			new NxtControl.Drawing.PointF(67D, 56D),
			new NxtControl.Drawing.PointF(67D, 118D),
			new NxtControl.Drawing.PointF(23D, 118D)});
			// 
			// cxRL
			// 
			this.cxRL.Bounds = new NxtControl.Drawing.RectF(((float)(2D)), ((float)(18D)), ((float)(18D)), ((float)(34D)));
			this.cxRL.Brush = new NxtControl.Drawing.Brush(true);
			this.cxRL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cxRL.Name = "cxRL";
			// 
			// lnRL
			// 
			this.lnRL.EndPoint = new NxtControl.Drawing.PointF(20D, 35D);
			this.lnRL.Name = "lnRL";
			this.lnRL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lnRL.StartPoint = new NxtControl.Drawing.PointF(2D, 35D);
			// 
			// tRem
			// 
			this.tRem.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.tRem.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tRem.Location = new NxtControl.Drawing.PointF(5D, 19D);
			this.tRem.Name = "tRem";
			this.tRem.Text = "R";
			// 
			// tModo
			// 
			this.tModo.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.tModo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tModo.Location = new NxtControl.Drawing.PointF(5D, 35D);
			this.tModo.Name = "tModo";
			this.tModo.Text = "A";
			// 
			// tPos
			// 
			this.tPos.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tPos.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tPos.Location = new NxtControl.Drawing.PointF(66D, 92D);
			this.tPos.Name = "tPos";
			this.tPos.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(74D)), ((float)(22D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(78D, 23D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(74D)), ((float)(22D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(74D, 38D),
			new NxtControl.Drawing.PointF(82D, 22D),
			new NxtControl.Drawing.PointF(90D, 38D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(79D, 25D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(94D, 22D);
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
			// xAUTO
			// 
			this.xAUTO.BeginInit();
			this.xAUTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAUTO.IsOnlyInput = true;
			this.xAUTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAUTO.Name = "xAUTO";
			this.xAUTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAUTO.TagName = "fbkStsAutomatico";
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
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(96D)), ((float)(128D)));
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
			// sComporta
			// 
			this.Name = "sComporta";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InstanceName,
			this.haste,
			this.atuador,
			this.corpoE,
			this.corpoD,
			this.cxRL,
			this.lnRL,
			this.tRem,
			this.tModo,
			this.tPos,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.xANIM,
			this.xAUTO,
			this.xREM,
			this.xLOC,
			this.xDESL,
			this.xFCOM,
			this.xFATU,
			this.xFPOS,
			this.xECOM,
			this.xEATU,
			this.xEPOS,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(110, 128);

		}
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle haste;
		private NxtControl.GuiFramework.Rectangle atuador;
		private NxtControl.GuiFramework.Polygon corpoE;
		private NxtControl.GuiFramework.Polygon corpoD;
		private NxtControl.GuiFramework.Rectangle cxRL;
		private NxtControl.GuiFramework.Line lnRL;
		private NxtControl.GuiFramework.FreeText tRem;
		private NxtControl.GuiFramework.FreeText tModo;
		private NxtControl.GuiFramework.FreeText tPos;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private System.HMI.Symbols.Base.Execute<short> xANIM;
		private System.HMI.Symbols.Base.Execute<bool> xAUTO;
		private System.HMI.Symbols.Base.Execute<bool> xREM;
		private System.HMI.Symbols.Base.Execute<bool> xLOC;
		private System.HMI.Symbols.Base.Execute<bool> xDESL;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xFATU;
		private System.HMI.Symbols.Base.Execute<bool> xFPOS;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xEATU;
		private System.HMI.Symbols.Base.Execute<byte> xEPOS;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
