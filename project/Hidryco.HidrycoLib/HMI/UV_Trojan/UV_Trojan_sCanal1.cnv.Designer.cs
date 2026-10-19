/*
 * Hidryco - UV_Trojan - sCanal1
 * Canal UV 700-UV-01 (Trojan UV3000Plus): banco de lampadas nas cores HidrycoColors, lamina d agua, limpeza, potencia, intensidade e horas.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UV_Trojan
{
	/// <summary>
	/// Summary description for sCanal1.
	/// </summary>
	partial class sCanal1
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.tNome = new NxtControl.GuiFramework.FreeText();
			this.tEstado = new NxtControl.GuiFramework.FreeText();
			this.agua0 = new NxtControl.GuiFramework.Rectangle();
			this.agua1 = new NxtControl.GuiFramework.Rectangle();
			this.agua2 = new NxtControl.GuiFramework.Rectangle();
			this.parEsq = new NxtControl.GuiFramework.Rectangle();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.soleira = new NxtControl.GuiFramework.Rectangle();
			this.parDir = new NxtControl.GuiFramework.Rectangle();
			this.baseComporta = new NxtControl.GuiFramework.Rectangle();
			this.comporta = new NxtControl.GuiFramework.Polygon();
			this.modTopo = new NxtControl.GuiFramework.Rectangle();
			this.modHaste1 = new NxtControl.GuiFramework.Rectangle();
			this.modHaste2 = new NxtControl.GuiFramework.Rectangle();
			this.lamp1 = new NxtControl.GuiFramework.Rectangle();
			this.lamp2 = new NxtControl.GuiFramework.Rectangle();
			this.lamp3 = new NxtControl.GuiFramework.Rectangle();
			this.lamp4 = new NxtControl.GuiFramework.Rectangle();
			this.lamp5 = new NxtControl.GuiFramework.Rectangle();
			this.lamp6 = new NxtControl.GuiFramework.Rectangle();
			this.limpador = new NxtControl.GuiFramework.Rectangle();
			this.tNivel = new NxtControl.GuiFramework.FreeText();
			this.textoManut = new NxtControl.GuiFramework.FreeText();
			this.falhaCom = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.tInfo = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.xFCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xOP = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAL = new System.HMI.Symbols.Base.Execute<short>();
			this.xNB = new System.HMI.Symbols.Base.Execute<bool>();
			this.xOF = new System.HMI.Symbols.Base.Execute<bool>();
			this.xMA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xNR = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBI = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPO = new System.HMI.Symbols.Base.Execute<short>();
			this.xIN = new System.HMI.Symbols.Base.Execute<float>();
			this.xMW = new System.HMI.Symbols.Base.Execute<bool>();
			this.xWG = new System.HMI.Symbols.Base.Execute<short>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xECRI = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEMAI = new System.HMI.Symbols.Base.Execute<byte>();
			this.xHO = new System.HMI.Symbols.Base.Execute<int>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// tNome
			// 
			this.tNome.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.tNome.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tNome.Location = new NxtControl.Drawing.PointF(4D, 0D);
			this.tNome.Name = "tNome";
			this.tNome.Text = "700-UV-01";
			// 
			// tEstado
			// 
			this.tEstado.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.tEstado.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tEstado.Location = new NxtControl.Drawing.PointF(92D, 2D);
			this.tEstado.Name = "tEstado";
			this.tEstado.Text = "";
			// 
			// agua0
			// 
			this.agua0.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(100D)), ((float)(40D)), ((float)(20D)));
			this.agua0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230))));
			this.agua0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.agua0.Name = "agua0";
			this.agua0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// agua1
			// 
			this.agua1.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(46D)), ((float)(274D)), ((float)(56D)));
			this.agua1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230))));
			this.agua1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.agua1.Name = "agua1";
			this.agua1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// agua2
			// 
			this.agua2.Bounds = new NxtControl.Drawing.RectF(((float)(296D)), ((float)(94D)), ((float)(78D)), ((float)(26D)));
			this.agua2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230))));
			this.agua2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.agua2.Name = "agua2";
			this.agua2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(180)), ((byte)(230))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// parEsq
			// 
			this.parEsq.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(26D)), ((float)(6D)), ((float)(100D)));
			this.parEsq.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(176)), ((byte)(176)), ((byte)(176))));
			this.parEsq.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.parEsq.Name = "parEsq";
			this.parEsq.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(120D)), ((float)(380D)), ((float)(6D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(176)), ((byte)(176)), ((byte)(176))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// soleira
			// 
			this.soleira.Bounds = new NxtControl.Drawing.RectF(((float)(46D)), ((float)(102D)), ((float)(234D)), ((float)(18D)));
			this.soleira.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(176)), ((byte)(176)), ((byte)(176))));
			this.soleira.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.soleira.Name = "soleira";
			this.soleira.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// parDir
			// 
			this.parDir.Bounds = new NxtControl.Drawing.RectF(((float)(374D)), ((float)(26D)), ((float)(6D)), ((float)(100D)));
			this.parDir.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(176)), ((byte)(176)), ((byte)(176))));
			this.parDir.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.parDir.Name = "parDir";
			this.parDir.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// baseComporta
			// 
			this.baseComporta.Bounds = new NxtControl.Drawing.RectF(((float)(280D)), ((float)(92D)), ((float)(16D)), ((float)(28D)));
			this.baseComporta.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(176)), ((byte)(176)), ((byte)(176))));
			this.baseComporta.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.baseComporta.Name = "baseComporta";
			this.baseComporta.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// comporta
			// 
			this.comporta.Bounds = new NxtControl.Drawing.RectF(((float)(282D)), ((float)(54D)), ((float)(12D)), ((float)(38D)));
			this.comporta.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.comporta.Closed = true;
			this.comporta.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.comporta.Name = "comporta";
			this.comporta.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.comporta.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(282D, 54D),
			new NxtControl.Drawing.PointF(294D, 54D),
			new NxtControl.Drawing.PointF(294D, 92D),
			new NxtControl.Drawing.PointF(282D, 92D)});
			// 
			// modTopo
			// 
			this.modTopo.Bounds = new NxtControl.Drawing.RectF(((float)(110D)), ((float)(28D)), ((float)(130D)), ((float)(12D)));
			this.modTopo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.modTopo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.modTopo.Name = "modTopo";
			this.modTopo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// modHaste1
			// 
			this.modHaste1.Bounds = new NxtControl.Drawing.RectF(((float)(114D)), ((float)(40D)), ((float)(4D)), ((float)(60D)));
			this.modHaste1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.modHaste1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.modHaste1.Name = "modHaste1";
			this.modHaste1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// modHaste2
			// 
			this.modHaste2.Bounds = new NxtControl.Drawing.RectF(((float)(232D)), ((float)(40D)), ((float)(4D)), ((float)(60D)));
			this.modHaste2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.modHaste2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.modHaste2.Name = "modHaste2";
			this.modHaste2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lamp1
			// 
			this.lamp1.Bounds = new NxtControl.Drawing.RectF(((float)(118D)), ((float)(50D)), ((float)(114D)), ((float)(4D)));
			this.lamp1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.lamp1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lamp1.Name = "lamp1";
			this.lamp1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lamp2
			// 
			this.lamp2.Bounds = new NxtControl.Drawing.RectF(((float)(118D)), ((float)(58D)), ((float)(114D)), ((float)(4D)));
			this.lamp2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.lamp2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lamp2.Name = "lamp2";
			this.lamp2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lamp3
			// 
			this.lamp3.Bounds = new NxtControl.Drawing.RectF(((float)(118D)), ((float)(66D)), ((float)(114D)), ((float)(4D)));
			this.lamp3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.lamp3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lamp3.Name = "lamp3";
			this.lamp3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lamp4
			// 
			this.lamp4.Bounds = new NxtControl.Drawing.RectF(((float)(118D)), ((float)(74D)), ((float)(114D)), ((float)(4D)));
			this.lamp4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.lamp4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lamp4.Name = "lamp4";
			this.lamp4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lamp5
			// 
			this.lamp5.Bounds = new NxtControl.Drawing.RectF(((float)(118D)), ((float)(82D)), ((float)(114D)), ((float)(4D)));
			this.lamp5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.lamp5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lamp5.Name = "lamp5";
			this.lamp5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// lamp6
			// 
			this.lamp6.Bounds = new NxtControl.Drawing.RectF(((float)(118D)), ((float)(90D)), ((float)(114D)), ((float)(4D)));
			this.lamp6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(160)), ((byte)(0))));
			this.lamp6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lamp6.Name = "lamp6";
			this.lamp6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// limpador
			// 
			this.limpador.Bounds = new NxtControl.Drawing.RectF(((float)(124D)), ((float)(44D)), ((float)(4D)), ((float)(54D)));
			this.limpador.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))));
			this.limpador.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.limpador.Name = "limpador";
			this.limpador.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tNivel
			// 
			this.tNivel.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tNivel.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.tNivel.Location = new NxtControl.Drawing.PointF(10D, 104D);
			this.tNivel.Name = "tNivel";
			this.tNivel.Text = "NÍVEL BAIXO";
			this.tNivel.Visible = false;
			// 
			// textoManut
			// 
			this.textoManut.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoManut.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.textoManut.Location = new NxtControl.Drawing.PointF(300D, 30D);
			this.textoManut.Name = "textoManut";
			this.textoManut.Text = "MANUTENÇÃO";
			this.textoManut.Visible = false;
			// 
			// falhaCom
			// 
			this.falhaCom.BeginInit();
			this.falhaCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 250D, 0D);
			this.falhaCom.Name = "falhaCom";
			this.falhaCom.Visible = false;
			this.falhaCom.EndInit();
			// 
			// tInfo
			// 
			this.tInfo.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.tInfo.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.tInfo.Location = new NxtControl.Drawing.PointF(4D, 130D);
			this.tInfo.Name = "tInfo";
			this.tInfo.Text = "";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(2D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(304D, 3D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(2D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 18D),
			new NxtControl.Drawing.PointF(308D, 2D),
			new NxtControl.Drawing.PointF(316D, 18D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(305D, 5D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(320D, 2D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
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
			// xOP
			// 
			this.xOP.BeginInit();
			this.xOP.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xOP.IsOnlyInput = true;
			this.xOP.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xOP.Name = "xOP";
			this.xOP.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xOP.TagName = "STS_CH1_OPERANDO";
			this.xOP.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XOPValueChanged);
			this.xOP.EndInit();
			// 
			// xAL
			// 
			this.xAL.BeginInit();
			this.xAL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAL.IsOnlyInput = true;
			this.xAL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAL.Name = "xAL";
			this.xAL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAL.TagName = "STS_CH1_ALARME";
			this.xAL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XALValueChanged);
			this.xAL.EndInit();
			// 
			// xNB
			// 
			this.xNB.BeginInit();
			this.xNB.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNB.IsOnlyInput = true;
			this.xNB.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNB.Name = "xNB";
			this.xNB.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNB.TagName = "STS_CH1_NIVEL_BAIXO";
			this.xNB.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNBValueChanged);
			this.xNB.EndInit();
			// 
			// xOF
			// 
			this.xOF.BeginInit();
			this.xOF.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xOF.IsOnlyInput = true;
			this.xOF.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xOF.Name = "xOF";
			this.xOF.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xOF.TagName = "STS_CH1_OFFLINE";
			this.xOF.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XOFValueChanged);
			this.xOF.EndInit();
			// 
			// xMA
			// 
			this.xMA.BeginInit();
			this.xMA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMA.IsOnlyInput = true;
			this.xMA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMA.Name = "xMA";
			this.xMA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMA.TagName = "STS_CH1_MANUTENCAO";
			this.xMA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XMAValueChanged);
			this.xMA.EndInit();
			// 
			// xNR
			// 
			this.xNR.BeginInit();
			this.xNR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xNR.IsOnlyInput = true;
			this.xNR.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xNR.Name = "xNR";
			this.xNR.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xNR.TagName = "STS_CH1_NAO_REMOTO";
			this.xNR.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XNRValueChanged);
			this.xNR.EndInit();
			// 
			// xBI
			// 
			this.xBI.BeginInit();
			this.xBI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBI.IsOnlyInput = true;
			this.xBI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBI.Name = "xBI";
			this.xBI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBI.TagName = "STS_CH1_BANCOS_INSUF";
			this.xBI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XBIValueChanged);
			this.xBI.EndInit();
			// 
			// xPO
			// 
			this.xPO.BeginInit();
			this.xPO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPO.IsOnlyInput = true;
			this.xPO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPO.Name = "xPO";
			this.xPO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPO.TagName = "STS_CH1_POTENCIA";
			this.xPO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XPOValueChanged);
			this.xPO.EndInit();
			// 
			// xIN
			// 
			this.xIN.BeginInit();
			this.xIN.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xIN.IsOnlyInput = true;
			this.xIN.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xIN.Name = "xIN";
			this.xIN.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xIN.TagName = "STS_CH1_INTENSIDADE";
			this.xIN.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XINValueChanged);
			this.xIN.EndInit();
			// 
			// xMW
			// 
			this.xMW.BeginInit();
			this.xMW.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xMW.IsOnlyInput = true;
			this.xMW.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xMW.Name = "xMW";
			this.xMW.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xMW.TagName = "STS_UVI_MW";
			this.xMW.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XMWValueChanged);
			this.xMW.EndInit();
			// 
			// xWG
			// 
			this.xWG.BeginInit();
			this.xWG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xWG.IsOnlyInput = true;
			this.xWG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xWG.Name = "xWG";
			this.xWG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xWG.TagName = "STS_LIMP_W1185";
			this.xWG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XWGValueChanged);
			this.xWG.EndInit();
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
			// xHO
			// 
			this.xHO.BeginInit();
			this.xHO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xHO.IsOnlyInput = true;
			this.xHO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xHO.Name = "xHO";
			this.xHO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xHO.TagName = "STS_CH1_HORAS";
			this.xHO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XHOValueChanged);
			this.xHO.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(380D)), ((float)(148D)));
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
			// sCanal1
			// 
			this.Name = "sCanal1";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.tNome,
			this.tEstado,
			this.agua0,
			this.agua1,
			this.agua2,
			this.parEsq,
			this.fundo,
			this.soleira,
			this.parDir,
			this.baseComporta,
			this.comporta,
			this.modTopo,
			this.modHaste1,
			this.modHaste2,
			this.lamp1,
			this.lamp2,
			this.lamp3,
			this.lamp4,
			this.lamp5,
			this.lamp6,
			this.limpador,
			this.tNivel,
			this.textoManut,
			this.falhaCom,
			this.tInfo,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.xFCOM,
			this.xOP,
			this.xAL,
			this.xNB,
			this.xOF,
			this.xMA,
			this.xNR,
			this.xBI,
			this.xPO,
			this.xIN,
			this.xMW,
			this.xWG,
			this.xECOM,
			this.xECRI,
			this.xEMAI,
			this.xHO,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(380, 148);

		}
		private NxtControl.GuiFramework.FreeText tNome;
		private NxtControl.GuiFramework.FreeText tEstado;
		private NxtControl.GuiFramework.Rectangle agua0;
		private NxtControl.GuiFramework.Rectangle agua1;
		private NxtControl.GuiFramework.Rectangle agua2;
		private NxtControl.GuiFramework.Rectangle parEsq;
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle soleira;
		private NxtControl.GuiFramework.Rectangle parDir;
		private NxtControl.GuiFramework.Rectangle baseComporta;
		private NxtControl.GuiFramework.Polygon comporta;
		private NxtControl.GuiFramework.Rectangle modTopo;
		private NxtControl.GuiFramework.Rectangle modHaste1;
		private NxtControl.GuiFramework.Rectangle modHaste2;
		private NxtControl.GuiFramework.Rectangle lamp1;
		private NxtControl.GuiFramework.Rectangle lamp2;
		private NxtControl.GuiFramework.Rectangle lamp3;
		private NxtControl.GuiFramework.Rectangle lamp4;
		private NxtControl.GuiFramework.Rectangle lamp5;
		private NxtControl.GuiFramework.Rectangle lamp6;
		private NxtControl.GuiFramework.Rectangle limpador;
		private NxtControl.GuiFramework.FreeText tNivel;
		private NxtControl.GuiFramework.FreeText textoManut;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao falhaCom;
		private NxtControl.GuiFramework.FreeText tInfo;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private System.HMI.Symbols.Base.Execute<bool> xFCOM;
		private System.HMI.Symbols.Base.Execute<bool> xOP;
		private System.HMI.Symbols.Base.Execute<short> xAL;
		private System.HMI.Symbols.Base.Execute<bool> xNB;
		private System.HMI.Symbols.Base.Execute<bool> xOF;
		private System.HMI.Symbols.Base.Execute<bool> xMA;
		private System.HMI.Symbols.Base.Execute<bool> xNR;
		private System.HMI.Symbols.Base.Execute<bool> xBI;
		private System.HMI.Symbols.Base.Execute<short> xPO;
		private System.HMI.Symbols.Base.Execute<float> xIN;
		private System.HMI.Symbols.Base.Execute<bool> xMW;
		private System.HMI.Symbols.Base.Execute<short> xWG;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xECRI;
		private System.HMI.Symbols.Base.Execute<byte> xEMAI;
		private System.HMI.Symbols.Base.Execute<int> xHO;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
