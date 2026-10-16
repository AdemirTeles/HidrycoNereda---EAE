/*
 * Hidryco - Agua_Reuso - fpDefault
 * ISA-101: niveis, boia, comunicacao e alarmes da agua de reuso (forma + prioridade, piscando ate reconhecer).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Agua_Reuso
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
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.lin0 = new NxtControl.GuiFramework.Rectangle();
			this.rot0 = new NxtControl.GuiFramework.FreeText();
			this.v1 = new NxtControl.GuiFramework.FreeText();
			this.lin1 = new NxtControl.GuiFramework.Rectangle();
			this.rot1 = new NxtControl.GuiFramework.FreeText();
			this.k1 = new NxtControl.GuiFramework.FreeText();
			this.lin2 = new NxtControl.GuiFramework.Rectangle();
			this.rot2 = new NxtControl.GuiFramework.FreeText();
			this.v2 = new NxtControl.GuiFramework.FreeText();
			this.lin3 = new NxtControl.GuiFramework.Rectangle();
			this.rot3 = new NxtControl.GuiFramework.FreeText();
			this.k2 = new NxtControl.GuiFramework.FreeText();
			this.lin4 = new NxtControl.GuiFramework.Rectangle();
			this.rot4 = new NxtControl.GuiFramework.FreeText();
			this.v3 = new NxtControl.GuiFramework.FreeText();
			this.lin5 = new NxtControl.GuiFramework.Rectangle();
			this.rot5 = new NxtControl.GuiFramework.FreeText();
			this.v4 = new NxtControl.GuiFramework.FreeText();
			this.lin6 = new NxtControl.GuiFramework.Rectangle();
			this.rot6 = new NxtControl.GuiFramework.FreeText();
			this.v5 = new NxtControl.GuiFramework.FreeText();
			this.tituloAlm = new NxtControl.GuiFramework.FreeText();
			this.rNivelBaixo = new NxtControl.GuiFramework.FreeText();
			this.nNivelBaixo = new NxtControl.GuiFramework.FreeText();
			this.iNivelBaixoP1 = new NxtControl.GuiFramework.Rectangle();
			this.iNivelBaixoP1n = new NxtControl.GuiFramework.FreeText();
			this.iNivelBaixoP2 = new NxtControl.GuiFramework.Polygon();
			this.iNivelBaixoP2n = new NxtControl.GuiFramework.FreeText();
			this.iNivelBaixoTxt = new NxtControl.GuiFramework.FreeText();
			this.rRem1 = new NxtControl.GuiFramework.FreeText();
			this.nRem1 = new NxtControl.GuiFramework.FreeText();
			this.iRem1P1 = new NxtControl.GuiFramework.Rectangle();
			this.iRem1P1n = new NxtControl.GuiFramework.FreeText();
			this.iRem1P2 = new NxtControl.GuiFramework.Polygon();
			this.iRem1P2n = new NxtControl.GuiFramework.FreeText();
			this.iRem1Txt = new NxtControl.GuiFramework.FreeText();
			this.rRem2 = new NxtControl.GuiFramework.FreeText();
			this.nRem2 = new NxtControl.GuiFramework.FreeText();
			this.iRem2P1 = new NxtControl.GuiFramework.Rectangle();
			this.iRem2P1n = new NxtControl.GuiFramework.FreeText();
			this.iRem2P2 = new NxtControl.GuiFramework.Polygon();
			this.iRem2P2n = new NxtControl.GuiFramework.FreeText();
			this.iRem2Txt = new NxtControl.GuiFramework.FreeText();
			this.ajuda = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
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
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(420D)), ((float)(64D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "Normal";
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 39D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(38D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 54D),
			new NxtControl.Drawing.PointF(28D, 38D),
			new NxtControl.Drawing.PointF(36D, 54D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 42D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 38D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// lin0
			// 
			this.lin0.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(75D)), ((float)(396D)), ((float)(26D)));
			this.lin0.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin0.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin0.Name = "lin0";
			this.lin0.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot0
			// 
			this.rot0.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot0.Location = new NxtControl.Drawing.PointF(22D, 79D);
			this.rot0.Name = "rot0";
			this.rot0.Text = "Nível 1000-PIT-01";
			// 
			// v1
			// 
			this.v1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v1.Location = new NxtControl.Drawing.PointF(240D, 79D);
			this.v1.Name = "v1";
			this.v1.Text = "0.00 m  (0 %)";
			// 
			// lin1
			// 
			this.lin1.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(105D)), ((float)(396D)), ((float)(26D)));
			this.lin1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin1.Name = "lin1";
			this.lin1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot1
			// 
			this.rot1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot1.Location = new NxtControl.Drawing.PointF(22D, 109D);
			this.rot1.Name = "rot1";
			this.rot1.Text = "Condição PIT-01";
			// 
			// k1
			// 
			this.k1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.k1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.k1.Location = new NxtControl.Drawing.PointF(240D, 109D);
			this.k1.Name = "k1";
			this.k1.Text = "normal";
			// 
			// lin2
			// 
			this.lin2.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(135D)), ((float)(396D)), ((float)(26D)));
			this.lin2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin2.Name = "lin2";
			this.lin2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot2
			// 
			this.rot2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot2.Location = new NxtControl.Drawing.PointF(22D, 139D);
			this.rot2.Name = "rot2";
			this.rot2.Text = "Nível 1000-PIT-02";
			// 
			// v2
			// 
			this.v2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v2.Location = new NxtControl.Drawing.PointF(240D, 139D);
			this.v2.Name = "v2";
			this.v2.Text = "0.00 m  (0 %)";
			// 
			// lin3
			// 
			this.lin3.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(165D)), ((float)(396D)), ((float)(26D)));
			this.lin3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin3.Name = "lin3";
			this.lin3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot3
			// 
			this.rot3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot3.Location = new NxtControl.Drawing.PointF(22D, 169D);
			this.rot3.Name = "rot3";
			this.rot3.Text = "Condição PIT-02";
			// 
			// k2
			// 
			this.k2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.k2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.k2.Location = new NxtControl.Drawing.PointF(240D, 169D);
			this.k2.Name = "k2";
			this.k2.Text = "normal";
			// 
			// lin4
			// 
			this.lin4.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(195D)), ((float)(396D)), ((float)(26D)));
			this.lin4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin4.Name = "lin4";
			this.lin4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot4
			// 
			this.rot4.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot4.Location = new NxtControl.Drawing.PointF(22D, 199D);
			this.rot4.Name = "rot4";
			this.rot4.Text = "Boia 1000-LSL-01";
			// 
			// v3
			// 
			this.v3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v3.Location = new NxtControl.Drawing.PointF(240D, 199D);
			this.v3.Name = "v3";
			this.v3.Text = "normal";
			// 
			// lin5
			// 
			this.lin5.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(225D)), ((float)(396D)), ((float)(26D)));
			this.lin5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin5.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin5.Name = "lin5";
			this.lin5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot5
			// 
			this.rot5.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot5.Location = new NxtControl.Drawing.PointF(22D, 229D);
			this.rot5.Name = "rot5";
			this.rot5.Text = "Remota 1 Subestação (boia)";
			// 
			// v4
			// 
			this.v4.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v4.Location = new NxtControl.Drawing.PointF(240D, 229D);
			this.v4.Name = "v4";
			this.v4.Text = "online";
			// 
			// lin6
			// 
			this.lin6.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(255D)), ((float)(396D)), ((float)(26D)));
			this.lin6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.lin6.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lin6.Name = "lin6";
			this.lin6.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rot6
			// 
			this.rot6.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rot6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rot6.Location = new NxtControl.Drawing.PointF(22D, 259D);
			this.rot6.Name = "rot6";
			this.rot6.Text = "Remota 2 Subestação (PIT)";
			// 
			// v5
			// 
			this.v5.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.v5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v5.Location = new NxtControl.Drawing.PointF(240D, 259D);
			this.v5.Name = "v5";
			this.v5.Text = "online";
			// 
			// tituloAlm
			// 
			this.tituloAlm.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloAlm.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.tituloAlm.Location = new NxtControl.Drawing.PointF(20D, 294D);
			this.tituloAlm.Name = "tituloAlm";
			this.tituloAlm.Text = "Alarmes";
			// 
			// rNivelBaixo
			// 
			this.rNivelBaixo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rNivelBaixo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rNivelBaixo.Location = new NxtControl.Drawing.PointF(22D, 318D);
			this.rNivelBaixo.Name = "rNivelBaixo";
			this.rNivelBaixo.Text = "Nível baixo (boia LSL-01)";
			// 
			// nNivelBaixo
			// 
			this.nNivelBaixo.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nNivelBaixo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nNivelBaixo.Location = new NxtControl.Drawing.PointF(304D, 318D);
			this.nNivelBaixo.Name = "nNivelBaixo";
			this.nNivelBaixo.Text = "—";
			// 
			// iNivelBaixoP1
			// 
			this.iNivelBaixoP1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(318D)), ((float)(16D)), ((float)(16D)));
			this.iNivelBaixoP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iNivelBaixoP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNivelBaixoP1.Name = "iNivelBaixoP1";
			this.iNivelBaixoP1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNivelBaixoP1.Visible = false;
			// 
			// iNivelBaixoP1n
			// 
			this.iNivelBaixoP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iNivelBaixoP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iNivelBaixoP1n.Location = new NxtControl.Drawing.PointF(304D, 319D);
			this.iNivelBaixoP1n.Name = "iNivelBaixoP1n";
			this.iNivelBaixoP1n.Text = "1";
			this.iNivelBaixoP1n.Visible = false;
			// 
			// iNivelBaixoP2
			// 
			this.iNivelBaixoP2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(318D)), ((float)(16D)), ((float)(16D)));
			this.iNivelBaixoP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iNivelBaixoP2.Closed = true;
			this.iNivelBaixoP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iNivelBaixoP2.Name = "iNivelBaixoP2";
			this.iNivelBaixoP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iNivelBaixoP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 334D),
			new NxtControl.Drawing.PointF(308D, 318D),
			new NxtControl.Drawing.PointF(316D, 334D)});
			this.iNivelBaixoP2.Visible = false;
			// 
			// iNivelBaixoP2n
			// 
			this.iNivelBaixoP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNivelBaixoP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iNivelBaixoP2n.Location = new NxtControl.Drawing.PointF(305D, 322D);
			this.iNivelBaixoP2n.Name = "iNivelBaixoP2n";
			this.iNivelBaixoP2n.Text = "2";
			this.iNivelBaixoP2n.Visible = false;
			// 
			// iNivelBaixoTxt
			// 
			this.iNivelBaixoTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iNivelBaixoTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iNivelBaixoTxt.Location = new NxtControl.Drawing.PointF(320D, 318D);
			this.iNivelBaixoTxt.Name = "iNivelBaixoTxt";
			this.iNivelBaixoTxt.Text = "";
			this.iNivelBaixoTxt.Visible = false;
			// 
			// rRem1
			// 
			this.rRem1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rRem1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rRem1.Location = new NxtControl.Drawing.PointF(22D, 344D);
			this.rRem1.Name = "rRem1";
			this.rRem1.Text = "Sem comunicação remota 1";
			// 
			// nRem1
			// 
			this.nRem1.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nRem1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nRem1.Location = new NxtControl.Drawing.PointF(304D, 344D);
			this.nRem1.Name = "nRem1";
			this.nRem1.Text = "—";
			// 
			// iRem1P1
			// 
			this.iRem1P1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(344D)), ((float)(16D)), ((float)(16D)));
			this.iRem1P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iRem1P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iRem1P1.Name = "iRem1P1";
			this.iRem1P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iRem1P1.Visible = false;
			// 
			// iRem1P1n
			// 
			this.iRem1P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iRem1P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iRem1P1n.Location = new NxtControl.Drawing.PointF(304D, 345D);
			this.iRem1P1n.Name = "iRem1P1n";
			this.iRem1P1n.Text = "1";
			this.iRem1P1n.Visible = false;
			// 
			// iRem1P2
			// 
			this.iRem1P2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(344D)), ((float)(16D)), ((float)(16D)));
			this.iRem1P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iRem1P2.Closed = true;
			this.iRem1P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iRem1P2.Name = "iRem1P2";
			this.iRem1P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iRem1P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 360D),
			new NxtControl.Drawing.PointF(308D, 344D),
			new NxtControl.Drawing.PointF(316D, 360D)});
			this.iRem1P2.Visible = false;
			// 
			// iRem1P2n
			// 
			this.iRem1P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iRem1P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iRem1P2n.Location = new NxtControl.Drawing.PointF(305D, 348D);
			this.iRem1P2n.Name = "iRem1P2n";
			this.iRem1P2n.Text = "2";
			this.iRem1P2n.Visible = false;
			// 
			// iRem1Txt
			// 
			this.iRem1Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iRem1Txt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iRem1Txt.Location = new NxtControl.Drawing.PointF(320D, 344D);
			this.iRem1Txt.Name = "iRem1Txt";
			this.iRem1Txt.Text = "";
			this.iRem1Txt.Visible = false;
			// 
			// rRem2
			// 
			this.rRem2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rRem2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rRem2.Location = new NxtControl.Drawing.PointF(22D, 370D);
			this.rRem2.Name = "rRem2";
			this.rRem2.Text = "Sem comunicação remota 2";
			// 
			// nRem2
			// 
			this.nRem2.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nRem2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nRem2.Location = new NxtControl.Drawing.PointF(304D, 370D);
			this.nRem2.Name = "nRem2";
			this.nRem2.Text = "—";
			// 
			// iRem2P1
			// 
			this.iRem2P1.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(370D)), ((float)(16D)), ((float)(16D)));
			this.iRem2P1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iRem2P1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iRem2P1.Name = "iRem2P1";
			this.iRem2P1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iRem2P1.Visible = false;
			// 
			// iRem2P1n
			// 
			this.iRem2P1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iRem2P1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iRem2P1n.Location = new NxtControl.Drawing.PointF(304D, 371D);
			this.iRem2P1n.Name = "iRem2P1n";
			this.iRem2P1n.Text = "1";
			this.iRem2P1n.Visible = false;
			// 
			// iRem2P2
			// 
			this.iRem2P2.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(370D)), ((float)(16D)), ((float)(16D)));
			this.iRem2P2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iRem2P2.Closed = true;
			this.iRem2P2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iRem2P2.Name = "iRem2P2";
			this.iRem2P2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.iRem2P2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(300D, 386D),
			new NxtControl.Drawing.PointF(308D, 370D),
			new NxtControl.Drawing.PointF(316D, 386D)});
			this.iRem2P2.Visible = false;
			// 
			// iRem2P2n
			// 
			this.iRem2P2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iRem2P2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iRem2P2n.Location = new NxtControl.Drawing.PointF(305D, 374D);
			this.iRem2P2n.Name = "iRem2P2n";
			this.iRem2P2n.Text = "2";
			this.iRem2P2n.Visible = false;
			// 
			// iRem2Txt
			// 
			this.iRem2Txt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iRem2Txt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iRem2Txt.Location = new NxtControl.Drawing.PointF(320D, 370D);
			this.iRem2Txt.Name = "iRem2Txt";
			this.iRem2Txt.Text = "";
			this.iRem2Txt.Visible = false;
			// 
			// ajuda
			// 
			this.ajuda.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.ajuda.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda.Location = new NxtControl.Drawing.PointF(22D, 398D);
			this.ajuda.Name = "ajuda";
			this.ajuda.Text = "HH/H/L/LL dos PIT: no faceplate de cada um.";
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(426D)), ((float)(200D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reconhecer / Reset";
			this.btnReset.TextColor = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.TextColorMouseDown = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
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
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(420D)), ((float)(476D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpDefault";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.textoEstado,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.lin0,
			this.rot0,
			this.v1,
			this.lin1,
			this.rot1,
			this.k1,
			this.lin2,
			this.rot2,
			this.v2,
			this.lin3,
			this.rot3,
			this.k2,
			this.lin4,
			this.rot4,
			this.v3,
			this.lin5,
			this.rot5,
			this.v4,
			this.lin6,
			this.rot6,
			this.v5,
			this.tituloAlm,
			this.rNivelBaixo,
			this.nNivelBaixo,
			this.iNivelBaixoP1,
			this.iNivelBaixoP1n,
			this.iNivelBaixoP2,
			this.iNivelBaixoP2n,
			this.iNivelBaixoTxt,
			this.rRem1,
			this.nRem1,
			this.iRem1P1,
			this.iRem1P1n,
			this.iRem1P2,
			this.iRem1P2n,
			this.iRem1Txt,
			this.rRem2,
			this.nRem2,
			this.iRem2P1,
			this.iRem2P1n,
			this.iRem2P2,
			this.iRem2P2n,
			this.iRem2Txt,
			this.ajuda,
			this.btnReset,
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
			this.xERem2});
			this.Size = new System.Drawing.Size(420, 476);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.Rectangle lin0;
		private NxtControl.GuiFramework.FreeText rot0;
		private NxtControl.GuiFramework.FreeText v1;
		private NxtControl.GuiFramework.Rectangle lin1;
		private NxtControl.GuiFramework.FreeText rot1;
		private NxtControl.GuiFramework.FreeText k1;
		private NxtControl.GuiFramework.Rectangle lin2;
		private NxtControl.GuiFramework.FreeText rot2;
		private NxtControl.GuiFramework.FreeText v2;
		private NxtControl.GuiFramework.Rectangle lin3;
		private NxtControl.GuiFramework.FreeText rot3;
		private NxtControl.GuiFramework.FreeText k2;
		private NxtControl.GuiFramework.Rectangle lin4;
		private NxtControl.GuiFramework.FreeText rot4;
		private NxtControl.GuiFramework.FreeText v3;
		private NxtControl.GuiFramework.Rectangle lin5;
		private NxtControl.GuiFramework.FreeText rot5;
		private NxtControl.GuiFramework.FreeText v4;
		private NxtControl.GuiFramework.Rectangle lin6;
		private NxtControl.GuiFramework.FreeText rot6;
		private NxtControl.GuiFramework.FreeText v5;
		private NxtControl.GuiFramework.FreeText tituloAlm;
		private NxtControl.GuiFramework.FreeText rNivelBaixo;
		private NxtControl.GuiFramework.FreeText nNivelBaixo;
		private NxtControl.GuiFramework.Rectangle iNivelBaixoP1;
		private NxtControl.GuiFramework.FreeText iNivelBaixoP1n;
		private NxtControl.GuiFramework.Polygon iNivelBaixoP2;
		private NxtControl.GuiFramework.FreeText iNivelBaixoP2n;
		private NxtControl.GuiFramework.FreeText iNivelBaixoTxt;
		private NxtControl.GuiFramework.FreeText rRem1;
		private NxtControl.GuiFramework.FreeText nRem1;
		private NxtControl.GuiFramework.Rectangle iRem1P1;
		private NxtControl.GuiFramework.FreeText iRem1P1n;
		private NxtControl.GuiFramework.Polygon iRem1P2;
		private NxtControl.GuiFramework.FreeText iRem1P2n;
		private NxtControl.GuiFramework.FreeText iRem1Txt;
		private NxtControl.GuiFramework.FreeText rRem2;
		private NxtControl.GuiFramework.FreeText nRem2;
		private NxtControl.GuiFramework.Rectangle iRem2P1;
		private NxtControl.GuiFramework.FreeText iRem2P1n;
		private NxtControl.GuiFramework.Polygon iRem2P2;
		private NxtControl.GuiFramework.FreeText iRem2P2n;
		private NxtControl.GuiFramework.FreeText iRem2Txt;
		private NxtControl.GuiFramework.FreeText ajuda;
		private NxtControl.GuiFramework.DrawnButton btnReset;
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
		#endregion
	}
}
