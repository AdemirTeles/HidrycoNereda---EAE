/*
 * Hidryco - tela DESINFECCAO (desinfeccao UV e efluente final - serie 700)
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs (DESINFECCAO, VC-01, UV, FT-01, AITs, MGE).
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for DESINFECCAO.
	/// </summary>
	partial class DESINFECCAO
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.cardProcesso = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.rEntrada = new NxtControl.GuiFramework.FreeText();
			this.tuboEntrada = new NxtControl.GuiFramework.Rectangle();
			this.tanque = new NxtControl.GuiFramework.Rectangle();
			this.rTanque = new NxtControl.GuiFramework.FreeText();
			this.rTanque2 = new NxtControl.GuiFramework.FreeText();
			this.tubo1 = new NxtControl.GuiFramework.Rectangle();
			this.tubo2 = new NxtControl.GuiFramework.Rectangle();
			this.tubo3 = new NxtControl.GuiFramework.Rectangle();
			this.parshall = new NxtControl.GuiFramework.Rectangle();
			this.rParshall = new NxtControl.GuiFramework.FreeText();
			this.tubo4 = new NxtControl.GuiFramework.Rectangle();
			this.seta = new NxtControl.GuiFramework.Polygon();
			this.rSaida = new NxtControl.GuiFramework.FreeText();
			this.rFT = new NxtControl.GuiFramework.FreeText();
			this.rAnalis = new NxtControl.GuiFramework.FreeText();
			this.rA1 = new NxtControl.GuiFramework.FreeText();
			this.rA3 = new NxtControl.GuiFramework.FreeText();
			this.rA4 = new NxtControl.GuiFramework.FreeText();
			this.rCtl = new NxtControl.GuiFramework.FreeText();
			this.rMge = new NxtControl.GuiFramework.FreeText();
			this.valvula = new Hidryco.HidrycoLib.Symbols.Valvula_Coester.sValvula();
			this.uv = new Hidryco.HidrycoLib.Symbols.UV_Trojan.sDefault();
			this.ft = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sDefault();
			this.ait1 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.ait3 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.ait4 = new Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto();
			this.controle = new Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.sDefault();
			this.mge = new Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cardProcesso
			// 
			this.cardProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(1350D)), ((float)(682D)));
			this.cardProcesso.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(242)), ((byte)(242)), ((byte)(242))));
			this.cardProcesso.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cardProcesso.Name = "cardProcesso";
			this.cardProcesso.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(24D, 18D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "DESINFECÇÃO UV E EFLUENTE FINAL (700)";
			// 
			// rEntrada
			// 
			this.rEntrada.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rEntrada.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rEntrada.Location = new NxtControl.Drawing.PointF(24D, 70D);
			this.rEntrada.Name = "rEntrada";
			this.rEntrada.Text = "Decante dos reatores Nereda";
			// 
			// tuboEntrada
			// 
			this.tuboEntrada.Bounds = new NxtControl.Drawing.RectF(((float)(24D)), ((float)(96D)), ((float)(60D)), ((float)(6D)));
			this.tuboEntrada.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.tuboEntrada.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tuboEntrada.Name = "tuboEntrada";
			this.tuboEntrada.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tanque
			// 
			this.tanque.Bounds = new NxtControl.Drawing.RectF(((float)(84D)), ((float)(70D)), ((float)(200D)), ((float)(150D)));
			this.tanque.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.tanque.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tanque.Name = "tanque";
			this.tanque.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rTanque
			// 
			this.rTanque.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rTanque.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rTanque.Location = new NxtControl.Drawing.PointF(96D, 150D);
			this.rTanque.Name = "rTanque";
			this.rTanque.Text = "TANQUE DE AMORTECIMENTO";
			// 
			// rTanque2
			// 
			this.rTanque2.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rTanque2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.rTanque2.Location = new NxtControl.Drawing.PointF(96D, 168D);
			this.rTanque2.Name = "rTanque2";
			this.rTanque2.Text = "V = 1500 m³";
			// 
			// tubo1
			// 
			this.tubo1.Bounds = new NxtControl.Drawing.RectF(((float)(284D)), ((float)(186D)), ((float)(46D)), ((float)(6D)));
			this.tubo1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.tubo1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tubo1.Name = "tubo1";
			this.tubo1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tubo2
			// 
			this.tubo2.Bounds = new NxtControl.Drawing.RectF(((float)(460D)), ((float)(186D)), ((float)(50D)), ((float)(6D)));
			this.tubo2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.tubo2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tubo2.Name = "tubo2";
			this.tubo2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tubo3
			// 
			this.tubo3.Bounds = new NxtControl.Drawing.RectF(((float)(820D)), ((float)(186D)), ((float)(60D)), ((float)(6D)));
			this.tubo3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.tubo3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tubo3.Name = "tubo3";
			this.tubo3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// parshall
			// 
			this.parshall.Bounds = new NxtControl.Drawing.RectF(((float)(880D)), ((float)(170D)), ((float)(120D)), ((float)(38D)));
			this.parshall.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.parshall.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.parshall.Name = "parshall";
			this.parshall.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rParshall
			// 
			this.rParshall.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rParshall.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.rParshall.Location = new NxtControl.Drawing.PointF(890D, 180D);
			this.rParshall.Name = "rParshall";
			this.rParshall.Text = "CALHA PARSHALL";
			// 
			// tubo4
			// 
			this.tubo4.Bounds = new NxtControl.Drawing.RectF(((float)(1000D)), ((float)(186D)), ((float)(160D)), ((float)(6D)));
			this.tubo4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.tubo4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tubo4.Name = "tubo4";
			this.tubo4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// seta
			// 
			this.seta.Bounds = new NxtControl.Drawing.RectF(((float)(1160D)), ((float)(180D)), ((float)(16D)), ((float)(18D)));
			this.seta.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))));
			this.seta.Closed = true;
			this.seta.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.seta.Name = "seta";
			this.seta.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(150)), ((byte)(150)), ((byte)(150))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.seta.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(1160D, 180D),
			new NxtControl.Drawing.PointF(1176D, 189D),
			new NxtControl.Drawing.PointF(1160D, 198D)});
			// 
			// rSaida
			// 
			this.rSaida.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rSaida.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rSaida.Location = new NxtControl.Drawing.PointF(1060D, 204D);
			this.rSaida.Name = "rSaida";
			this.rSaida.Text = "Ribeirão do Quilombo";
			// 
			// rFT
			// 
			this.rFT.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rFT.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.rFT.Location = new NxtControl.Drawing.PointF(880D, 228D);
			this.rFT.Name = "rFT";
			this.rFT.Text = "700-FT-01";
			// 
			// rAnalis
			// 
			this.rAnalis.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rAnalis.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rAnalis.Location = new NxtControl.Drawing.PointF(24D, 300D);
			this.rAnalis.Name = "rAnalis";
			this.rAnalis.Text = "ANALISADORES DO EFLUENTE FINAL";
			// 
			// rA1
			// 
			this.rA1.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rA1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rA1.Location = new NxtControl.Drawing.PointF(24D, 326D);
			this.rA1.Name = "rA1";
			this.rA1.Text = "700-AIT-001  Turbidez";
			// 
			// rA3
			// 
			this.rA3.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rA3.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rA3.Location = new NxtControl.Drawing.PointF(24D, 360D);
			this.rA3.Name = "rA3";
			this.rA3.Text = "700-AIT-003  pH";
			// 
			// rA4
			// 
			this.rA4.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.rA4.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.rA4.Location = new NxtControl.Drawing.PointF(24D, 394D);
			this.rA4.Name = "rA4";
			this.rA4.Text = "700-AIT-004  OD";
			// 
			// rCtl
			// 
			this.rCtl.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rCtl.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rCtl.Location = new NxtControl.Drawing.PointF(24D, 440D);
			this.rCtl.Name = "rCtl";
			this.rCtl.Text = "CONTROLE DA VAZÃO DE LANÇAMENTO";
			// 
			// rMge
			// 
			this.rMge.Color = new NxtControl.Drawing.Color(((byte)(40)), ((byte)(40)), ((byte)(40)));
			this.rMge.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.rMge.Location = new NxtControl.Drawing.PointF(520D, 440D);
			this.rMge.Name = "rMge";
			this.rMge.Text = "ENERGIA - PCM DESINFECÇÃO";
			// 
			// valvula
			// 
			this.valvula.BeginInit();
			this.valvula.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 330D, 128D);
			this.valvula.Name = "valvula";
			this.valvula.SecurityToken = ((uint)(4294967295u));
			this.valvula.TagName = "8005CB77235157DB.VC_700_01";
			this.valvula.EndInit();
			// 
			// uv
			// 
			this.uv.BeginInit();
			this.uv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 512D, 134D);
			this.uv.Name = "uv";
			this.uv.SecurityToken = ((uint)(4294967295u));
			this.uv.TagName = "8005CB77235157DB.UV";
			this.uv.EndInit();
			// 
			// ft
			// 
			this.ft.BeginInit();
			this.ft.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 248D);
			this.ft.Name = "ft";
			this.ft.SecurityToken = ((uint)(4294967295u));
			this.ft.TagName = "8005CB77235157DB.FT_700_01";
			this.ft.EndInit();
			// 
			// ait1
			// 
			this.ait1.BeginInit();
			this.ait1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 200D, 322D);
			this.ait1.Name = "ait1";
			this.ait1.SecurityToken = ((uint)(4294967295u));
			this.ait1.TagName = "8005CB77235157DB.AIT_700_001";
			this.ait1.EndInit();
			// 
			// ait3
			// 
			this.ait3.BeginInit();
			this.ait3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 200D, 356D);
			this.ait3.Name = "ait3";
			this.ait3.SecurityToken = ((uint)(4294967295u));
			this.ait3.TagName = "8005CB77235157DB.AIT_700_003";
			this.ait3.EndInit();
			// 
			// ait4
			// 
			this.ait4.BeginInit();
			this.ait4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 200D, 390D);
			this.ait4.Name = "ait4";
			this.ait4.SecurityToken = ((uint)(4294967295u));
			this.ait4.TagName = "8005CB77235157DB.AIT_700_004";
			this.ait4.EndInit();
			// 
			// controle
			// 
			this.controle.BeginInit();
			this.controle.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 24D, 466D);
			this.controle.Name = "controle";
			this.controle.SecurityToken = ((uint)(4294967295u));
			this.controle.TagName = "8005CB77235157DB";
			this.controle.EndInit();
			// 
			// mge
			// 
			this.mge.BeginInit();
			this.mge.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 520D, 466D);
			this.mge.Name = "mge";
			this.mge.SecurityToken = ((uint)(4294967295u));
			this.mge.TagName = "037A106217874CC9";
			this.mge.EndInit();
			// 
			// DESINFECCAO
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.titulo,
			this.rEntrada,
			this.tuboEntrada,
			this.tanque,
			this.rTanque,
			this.rTanque2,
			this.tubo1,
			this.tubo2,
			this.tubo3,
			this.parshall,
			this.rParshall,
			this.tubo4,
			this.seta,
			this.rSaida,
			this.rFT,
			this.rAnalis,
			this.rA1,
			this.rA3,
			this.rA4,
			this.rCtl,
			this.rMge,
			this.valvula,
			this.uv,
			this.ft,
			this.ait1,
			this.ait3,
			this.ait4,
			this.controle,
			this.mge});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText rEntrada;
		private NxtControl.GuiFramework.Rectangle tuboEntrada;
		private NxtControl.GuiFramework.Rectangle tanque;
		private NxtControl.GuiFramework.FreeText rTanque;
		private NxtControl.GuiFramework.FreeText rTanque2;
		private NxtControl.GuiFramework.Rectangle tubo1;
		private NxtControl.GuiFramework.Rectangle tubo2;
		private NxtControl.GuiFramework.Rectangle tubo3;
		private NxtControl.GuiFramework.Rectangle parshall;
		private NxtControl.GuiFramework.FreeText rParshall;
		private NxtControl.GuiFramework.Rectangle tubo4;
		private NxtControl.GuiFramework.Polygon seta;
		private NxtControl.GuiFramework.FreeText rSaida;
		private NxtControl.GuiFramework.FreeText rFT;
		private NxtControl.GuiFramework.FreeText rAnalis;
		private NxtControl.GuiFramework.FreeText rA1;
		private NxtControl.GuiFramework.FreeText rA3;
		private NxtControl.GuiFramework.FreeText rA4;
		private NxtControl.GuiFramework.FreeText rCtl;
		private NxtControl.GuiFramework.FreeText rMge;
		private Hidryco.HidrycoLib.Symbols.Valvula_Coester.sValvula valvula;
		private Hidryco.HidrycoLib.Symbols.UV_Trojan.sDefault uv;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sDefault ft;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ait1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ait3;
		private Hidryco.HidrycoLib.Symbols.Sensor_Generico.sCompacto ait4;
		private Hidryco.HidrycoLib.Symbols.Desinfeccao_UV.sDefault controle;
		private Hidryco.HidrycoLib.Symbols.MGE_Generico.sDefault mge;
		#endregion
	}
}
