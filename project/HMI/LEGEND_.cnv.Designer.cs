/*
 * Hidryco - tela LEGEND_ (fase solida - serie 900)
 * ISA-101: cinzas planos; estados e alarmes vem dos simbolos dos CATs; arranjo do P&ID HID-PE-DE-ETE-FLX-002.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for LEGEND_.
	/// </summary>
	partial class LEGEND_
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
			this.card1 = new NxtControl.GuiFramework.Rectangle();
			this.tit2 = new NxtControl.GuiFramework.FreeText();
			this.s3 = new NxtControl.GuiFramework.FreeText();
			this.g4 = new Hidryco.HidrycoLib.Graphics.Bomba();
			this.t5 = new NxtControl.GuiFramework.FreeText();
			this.g6 = new Hidryco.HidrycoLib.Graphics.Bomba();
			this.t7 = new NxtControl.GuiFramework.FreeText();
			this.g8 = new Hidryco.HidrycoLib.Graphics.Bomba();
			this.t9 = new NxtControl.GuiFramework.FreeText();
			this.g10 = new Hidryco.HidrycoLib.Graphics.Bomba();
			this.t11 = new NxtControl.GuiFramework.FreeText();
			this.s12 = new NxtControl.GuiFramework.FreeText();
			this.lr13 = new NxtControl.GuiFramework.Rectangle();
			this.t14 = new NxtControl.GuiFramework.FreeText();
			this.t15 = new NxtControl.GuiFramework.FreeText();
			this.am16 = new NxtControl.GuiFramework.Rectangle();
			this.t17 = new NxtControl.GuiFramework.FreeText();
			this.t18 = new NxtControl.GuiFramework.FreeText();
			this.g19 = new Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica();
			this.t20 = new NxtControl.GuiFramework.FreeText();
			this.g21 = new Hidryco.HidrycoLib.Graphics.falha_comunicacao();
			this.t22 = new NxtControl.GuiFramework.FreeText();
			this.g23 = new Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador();
			this.t24 = new NxtControl.GuiFramework.FreeText();
			this.g25 = new Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador();
			this.t26 = new NxtControl.GuiFramework.FreeText();
			this.t27 = new NxtControl.GuiFramework.FreeText();
			this.t28 = new NxtControl.GuiFramework.FreeText();
			this.t29 = new NxtControl.GuiFramework.FreeText();
			this.t30 = new NxtControl.GuiFramework.FreeText();
			this.t31 = new NxtControl.GuiFramework.FreeText();
			this.t32 = new NxtControl.GuiFramework.FreeText();
			this.card33 = new NxtControl.GuiFramework.Rectangle();
			this.tit34 = new NxtControl.GuiFramework.FreeText();
			this.vE35 = new NxtControl.GuiFramework.Polygon();
			this.vD36 = new NxtControl.GuiFramework.Polygon();
			this.t37 = new NxtControl.GuiFramework.FreeText();
			this.vE38 = new NxtControl.GuiFramework.Polygon();
			this.vD39 = new NxtControl.GuiFramework.Polygon();
			this.t40 = new NxtControl.GuiFramework.FreeText();
			this.vE41 = new NxtControl.GuiFramework.Polygon();
			this.vD42 = new NxtControl.GuiFramework.Polygon();
			this.t43 = new NxtControl.GuiFramework.FreeText();
			this.vE44 = new NxtControl.GuiFramework.Polygon();
			this.vD45 = new NxtControl.GuiFramework.Polygon();
			this.t46 = new NxtControl.GuiFramework.FreeText();
			this.t47 = new NxtControl.GuiFramework.FreeText();
			this.t48 = new NxtControl.GuiFramework.FreeText();
			this.t49 = new NxtControl.GuiFramework.FreeText();
			this.titm50 = new NxtControl.GuiFramework.FreeText();
			this.mv51 = new NxtControl.GuiFramework.Rectangle();
			this.t52 = new NxtControl.GuiFramework.FreeText();
			this.t53 = new NxtControl.GuiFramework.FreeText();
			this.mf54 = new NxtControl.GuiFramework.Rectangle();
			this.t55 = new NxtControl.GuiFramework.FreeText();
			this.t56 = new NxtControl.GuiFramework.FreeText();
			this.md57 = new NxtControl.GuiFramework.Rectangle();
			this.t58 = new NxtControl.GuiFramework.FreeText();
			this.t59 = new NxtControl.GuiFramework.FreeText();
			this.t60 = new NxtControl.GuiFramework.FreeText();
			this.t61 = new NxtControl.GuiFramework.FreeText();
			this.titb62 = new NxtControl.GuiFramework.FreeText();
			this.t63 = new NxtControl.GuiFramework.FreeText();
			this.t64 = new NxtControl.GuiFramework.FreeText();
			this.titt65 = new NxtControl.GuiFramework.FreeText();
			this.tb66 = new NxtControl.GuiFramework.Rectangle();
			this.t67 = new NxtControl.GuiFramework.FreeText();
			this.tb68 = new NxtControl.GuiFramework.Rectangle();
			this.t69 = new NxtControl.GuiFramework.FreeText();
			this.tb70 = new NxtControl.GuiFramework.Rectangle();
			this.t71 = new NxtControl.GuiFramework.FreeText();
			this.tb72 = new NxtControl.GuiFramework.Rectangle();
			this.t73 = new NxtControl.GuiFramework.FreeText();
			this.tb74 = new NxtControl.GuiFramework.Rectangle();
			this.t75 = new NxtControl.GuiFramework.FreeText();
			this.card76 = new NxtControl.GuiFramework.Rectangle();
			this.tit77 = new NxtControl.GuiFramework.FreeText();
			this.p178 = new NxtControl.GuiFramework.Rectangle();
			this.t79 = new NxtControl.GuiFramework.FreeText();
			this.t80 = new NxtControl.GuiFramework.FreeText();
			this.t81 = new NxtControl.GuiFramework.FreeText();
			this.p282 = new NxtControl.GuiFramework.Polygon();
			this.t83 = new NxtControl.GuiFramework.FreeText();
			this.t84 = new NxtControl.GuiFramework.FreeText();
			this.t85 = new NxtControl.GuiFramework.FreeText();
			this.t86 = new NxtControl.GuiFramework.FreeText();
			this.t87 = new NxtControl.GuiFramework.FreeText();
			this.t88 = new NxtControl.GuiFramework.FreeText();
			this.t89 = new NxtControl.GuiFramework.FreeText();
			this.t90 = new NxtControl.GuiFramework.FreeText();
			this.t91 = new NxtControl.GuiFramework.FreeText();
			this.t92 = new NxtControl.GuiFramework.FreeText();
			this.titn93 = new NxtControl.GuiFramework.FreeText();
			this.nb94 = new NxtControl.GuiFramework.Rectangle();
			this.t95 = new NxtControl.GuiFramework.FreeText();
			this.t96 = new NxtControl.GuiFramework.FreeText();
			this.t97 = new NxtControl.GuiFramework.FreeText();
			this.t98 = new NxtControl.GuiFramework.FreeText();
			this.t99 = new NxtControl.GuiFramework.FreeText();
			this.t100 = new NxtControl.GuiFramework.FreeText();
			this.rg101 = new NxtControl.GuiFramework.Rectangle();
			this.t102 = new NxtControl.GuiFramework.FreeText();
			this.t103 = new NxtControl.GuiFramework.FreeText();
			this.t104 = new NxtControl.GuiFramework.FreeText();
			this.t105 = new NxtControl.GuiFramework.FreeText();
			this.t106 = new NxtControl.GuiFramework.FreeText();
			this.card107 = new NxtControl.GuiFramework.Rectangle();
			this.tit108 = new NxtControl.GuiFramework.FreeText();
			this.s109 = new NxtControl.GuiFramework.FreeText();
			this.nm110 = new NxtControl.GuiFramework.Rectangle();
			this.t111 = new NxtControl.GuiFramework.FreeText();
			this.nm112 = new NxtControl.GuiFramework.Rectangle();
			this.t113 = new NxtControl.GuiFramework.FreeText();
			this.np114 = new NxtControl.GuiFramework.Rectangle();
			this.t115 = new NxtControl.GuiFramework.FreeText();
			this.nm116 = new NxtControl.GuiFramework.Rectangle();
			this.t117 = new NxtControl.GuiFramework.FreeText();
			this.s118 = new NxtControl.GuiFramework.FreeText();
			this.nv119 = new NxtControl.GuiFramework.Rectangle();
			this.t120 = new NxtControl.GuiFramework.FreeText();
			this.nv121 = new NxtControl.GuiFramework.Rectangle();
			this.t122 = new NxtControl.GuiFramework.FreeText();
			this.np123 = new NxtControl.GuiFramework.Rectangle();
			this.t124 = new NxtControl.GuiFramework.FreeText();
			this.s125 = new NxtControl.GuiFramework.FreeText();
			this.t126 = new NxtControl.GuiFramework.FreeText();
			this.t127 = new NxtControl.GuiFramework.FreeText();
			this.t128 = new NxtControl.GuiFramework.FreeText();
			this.t129 = new NxtControl.GuiFramework.FreeText();
			this.t130 = new NxtControl.GuiFramework.FreeText();
			this.t131 = new NxtControl.GuiFramework.FreeText();
			this.t132 = new NxtControl.GuiFramework.FreeText();
			this.t133 = new NxtControl.GuiFramework.FreeText();
			this.t134 = new NxtControl.GuiFramework.FreeText();
			this.t135 = new NxtControl.GuiFramework.FreeText();
			this.t136 = new NxtControl.GuiFramework.FreeText();
			this.t137 = new NxtControl.GuiFramework.FreeText();
			this.t138 = new NxtControl.GuiFramework.FreeText();
			this.t139 = new NxtControl.GuiFramework.FreeText();
			this.t140 = new NxtControl.GuiFramework.FreeText();
			this.t141 = new NxtControl.GuiFramework.FreeText();
			this.t142 = new NxtControl.GuiFramework.FreeText();
			this.t143 = new NxtControl.GuiFramework.FreeText();
			this.t144 = new NxtControl.GuiFramework.FreeText();
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
			// card1
			// 
			this.card1.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(14D)), ((float)(330D)), ((float)(670D)));
			this.card1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.card1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.card1.Name = "card1";
			this.card1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tit2
			// 
			this.tit2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tit2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tit2.Location = new NxtControl.Drawing.PointF(24D, 22D);
			this.tit2.Name = "tit2";
			this.tit2.Text = "MOTORES E BOMBAS";
			// 
			// s3
			// 
			this.s3.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.s3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.s3.Location = new NxtControl.Drawing.PointF(24D, 40D);
			this.s3.Name = "s3";
			this.s3.Text = "COR (bombas, sopradores, grades, rosca)";
			// 
			// g4
			// 
			this.g4.BeginInit();
			this.g4.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 28D, 62D);
			this.g4.Name = "g4";
			this.g4.Animacao = 0;
			this.g4.EndInit();
			// 
			// t5
			// 
			this.t5.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t5.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t5.Location = new NxtControl.Drawing.PointF(88D, 70D);
			this.t5.Name = "t5";
			this.t5.Text = "Verde: desligado";
			// 
			// g6
			// 
			this.g6.BeginInit();
			this.g6.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 28D, 108D);
			this.g6.Name = "g6";
			this.g6.Animacao = 1;
			this.g6.EndInit();
			// 
			// t7
			// 
			this.t7.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t7.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t7.Location = new NxtControl.Drawing.PointF(88D, 116D);
			this.t7.Name = "t7";
			this.t7.Text = "Vermelho: ligado";
			// 
			// g8
			// 
			this.g8.BeginInit();
			this.g8.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 28D, 154D);
			this.g8.Name = "g8";
			this.g8.Animacao = 2;
			this.g8.EndInit();
			// 
			// t9
			// 
			this.t9.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t9.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t9.Location = new NxtControl.Drawing.PointF(88D, 162D);
			this.t9.Name = "t9";
			this.t9.Text = "Amarelo: em falha";
			// 
			// g10
			// 
			this.g10.BeginInit();
			this.g10.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.42D, 0D, 0D, 0.42D, 28D, 200D);
			this.g10.Name = "g10";
			this.g10.Animacao = 3;
			this.g10.EndInit();
			// 
			// t11
			// 
			this.t11.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t11.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t11.Location = new NxtControl.Drawing.PointF(88D, 208D);
			this.t11.Name = "t11";
			this.t11.Text = "Azul: em manutenção";
			// 
			// s12
			// 
			this.s12.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.s12.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.s12.Location = new NxtControl.Drawing.PointF(24D, 252D);
			this.s12.Name = "s12";
			this.s12.Text = "INDICAÇÕES AO LADO DO MOTOR";
			// 
			// lr13
			// 
			this.lr13.Bounds = new NxtControl.Drawing.RectF(((float)(30D)), ((float)(274D)), ((float)(18D)), ((float)(18D)));
			this.lr13.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.lr13.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.lr13.Name = "lr13";
			this.lr13.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t14
			// 
			this.t14.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t14.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.t14.Location = new NxtControl.Drawing.PointF(34D, 275D);
			this.t14.Name = "t14";
			this.t14.Text = "R";
			// 
			// t15
			// 
			this.t15.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t15.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t15.Location = new NxtControl.Drawing.PointF(58D, 276D);
			this.t15.Name = "t15";
			this.t15.Text = "R = remoto, L = local (chave no painel)";
			// 
			// am16
			// 
			this.am16.Bounds = new NxtControl.Drawing.RectF(((float)(30D)), ((float)(300D)), ((float)(18D)), ((float)(18D)));
			this.am16.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.am16.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.am16.Name = "am16";
			this.am16.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t17
			// 
			this.t17.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t17.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.t17.Location = new NxtControl.Drawing.PointF(34D, 301D);
			this.t17.Name = "t17";
			this.t17.Text = "A";
			// 
			// t18
			// 
			this.t18.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t18.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t18.Location = new NxtControl.Drawing.PointF(58D, 302D);
			this.t18.Name = "t18";
			this.t18.Text = "A = automático, M = manual";
			// 
			// g19
			// 
			this.g19.BeginInit();
			this.g19.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.6D, 30D, 328D);
			this.g19.Name = "g19";
			this.g19.EndInit();
			// 
			// t20
			// 
			this.t20.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t20.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t20.Location = new NxtControl.Drawing.PointF(58D, 332D);
			this.t20.Name = "t20";
			this.t20.Text = "Proteção térmica atuada";
			// 
			// g21
			// 
			this.g21.BeginInit();
			this.g21.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.6D, 30D, 358D);
			this.g21.Name = "g21";
			this.g21.EndInit();
			// 
			// t22
			// 
			this.t22.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t22.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t22.Location = new NxtControl.Drawing.PointF(58D, 362D);
			this.t22.Name = "t22";
			this.t22.Text = "Falha de comunicação (inversor ou remota)";
			// 
			// g23
			// 
			this.g23.BeginInit();
			this.g23.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.6D, 30D, 388D);
			this.g23.Name = "g23";
			this.g23.Animacao = 2;
			this.g23.EndInit();
			// 
			// t24
			// 
			this.t24.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t24.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t24.Location = new NxtControl.Drawing.PointF(58D, 390D);
			this.t24.Name = "t24";
			this.t24.Text = "Raio cinza: alimentado pelo gerador (desligado)";
			// 
			// g25
			// 
			this.g25.BeginInit();
			this.g25.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.6D, 30D, 418D);
			this.g25.Name = "g25";
			this.g25.Animacao = 3;
			this.g25.EndInit();
			// 
			// t26
			// 
			this.t26.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t26.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t26.Location = new NxtControl.Drawing.PointF(58D, 420D);
			this.t26.Name = "t26";
			this.t26.Text = "Raio vermelho: alimentado pelo gerador ligado";
			// 
			// t27
			// 
			this.t27.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t27.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t27.Location = new NxtControl.Drawing.PointF(30D, 452D);
			this.t27.Name = "t27";
			this.t27.Text = "30,0 Hz";
			// 
			// t28
			// 
			this.t28.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t28.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t28.Location = new NxtControl.Drawing.PointF(92D, 453D);
			this.t28.Name = "t28";
			this.t28.Text = "Velocidade (só motores com inversor)";
			// 
			// t29
			// 
			this.t29.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.t29.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t29.Location = new NxtControl.Drawing.PointF(30D, 478D);
			this.t29.Name = "t29";
			this.t29.Text = "Os ícones de térmica e de comunicação piscam";
			// 
			// t30
			// 
			this.t30.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.t30.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t30.Location = new NxtControl.Drawing.PointF(30D, 492D);
			this.t30.Name = "t30";
			this.t30.Text = "até o alarme ser reconhecido.";
			// 
			// t31
			// 
			this.t31.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.t31.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t31.Location = new NxtControl.Drawing.PointF(30D, 518D);
			this.t31.Name = "t31";
			this.t31.Text = "Grade, rosca e skids: mesmas cores; cinza =";
			// 
			// t32
			// 
			this.t32.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.t32.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t32.Location = new NxtControl.Drawing.PointF(30D, 532D);
			this.t32.Name = "t32";
			this.t32.Text = "sem comunicação com o painel do fornecedor.";
			// 
			// card33
			// 
			this.card33.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(14D)), ((float)(330D)), ((float)(670D)));
			this.card33.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.card33.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.card33.Name = "card33";
			this.card33.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tit34
			// 
			this.tit34.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tit34.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tit34.Location = new NxtControl.Drawing.PointF(362D, 22D);
			this.tit34.Name = "tit34";
			this.tit34.Text = "VÁLVULAS E COMPORTAS";
			// 
			// vE35
			// 
			this.vE35.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(44D)), ((float)(17D)), ((float)(22D)));
			this.vE35.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.vE35.Closed = true;
			this.vE35.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vE35.Name = "vE35";
			this.vE35.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vE35.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 44D),
			new NxtControl.Drawing.PointF(385D, 55D),
			new NxtControl.Drawing.PointF(368D, 66D)});
			// 
			// vD36
			// 
			this.vD36.Bounds = new NxtControl.Drawing.RectF(((float)(385D)), ((float)(44D)), ((float)(17D)), ((float)(22D)));
			this.vD36.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))));
			this.vD36.Closed = true;
			this.vD36.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vD36.Name = "vD36";
			this.vD36.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vD36.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(402D, 44D),
			new NxtControl.Drawing.PointF(385D, 55D),
			new NxtControl.Drawing.PointF(402D, 66D)});
			// 
			// t37
			// 
			this.t37.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t37.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t37.Location = new NxtControl.Drawing.PointF(414D, 48D);
			this.t37.Name = "t37";
			this.t37.Text = "Cheia: aberta";
			// 
			// vE38
			// 
			this.vE38.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(80D)), ((float)(17D)), ((float)(22D)));
			this.vE38.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.vE38.Closed = true;
			this.vE38.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vE38.Name = "vE38";
			this.vE38.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vE38.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 80D),
			new NxtControl.Drawing.PointF(385D, 91D),
			new NxtControl.Drawing.PointF(368D, 102D)});
			// 
			// vD39
			// 
			this.vD39.Bounds = new NxtControl.Drawing.RectF(((float)(385D)), ((float)(80D)), ((float)(17D)), ((float)(22D)));
			this.vD39.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.vD39.Closed = true;
			this.vD39.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vD39.Name = "vD39";
			this.vD39.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vD39.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(402D, 80D),
			new NxtControl.Drawing.PointF(385D, 91D),
			new NxtControl.Drawing.PointF(402D, 102D)});
			// 
			// t40
			// 
			this.t40.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t40.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t40.Location = new NxtControl.Drawing.PointF(414D, 84D);
			this.t40.Name = "t40";
			this.t40.Text = "Vazia: fechada";
			// 
			// vE41
			// 
			this.vE41.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(116D)), ((float)(17D)), ((float)(22D)));
			this.vE41.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.vE41.Closed = true;
			this.vE41.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vE41.Name = "vE41";
			this.vE41.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vE41.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 116D),
			new NxtControl.Drawing.PointF(385D, 127D),
			new NxtControl.Drawing.PointF(368D, 138D)});
			// 
			// vD42
			// 
			this.vD42.Bounds = new NxtControl.Drawing.RectF(((float)(385D)), ((float)(116D)), ((float)(17D)), ((float)(22D)));
			this.vD42.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))));
			this.vD42.Closed = true;
			this.vD42.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vD42.Name = "vD42";
			this.vD42.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vD42.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(402D, 116D),
			new NxtControl.Drawing.PointF(385D, 127D),
			new NxtControl.Drawing.PointF(402D, 138D)});
			// 
			// t43
			// 
			this.t43.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t43.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t43.Location = new NxtControl.Drawing.PointF(414D, 120D);
			this.t43.Name = "t43";
			this.t43.Text = "Cinza: intermediária / em movimento";
			// 
			// vE44
			// 
			this.vE44.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(152D)), ((float)(17D)), ((float)(22D)));
			this.vE44.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.vE44.Closed = true;
			this.vE44.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vE44.Name = "vE44";
			this.vE44.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vE44.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(368D, 152D),
			new NxtControl.Drawing.PointF(385D, 163D),
			new NxtControl.Drawing.PointF(368D, 174D)});
			// 
			// vD45
			// 
			this.vD45.Bounds = new NxtControl.Drawing.RectF(((float)(385D)), ((float)(152D)), ((float)(17D)), ((float)(22D)));
			this.vD45.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.vD45.Closed = true;
			this.vD45.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.vD45.Name = "vD45";
			this.vD45.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.vD45.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(402D, 152D),
			new NxtControl.Drawing.PointF(385D, 163D),
			new NxtControl.Drawing.PointF(402D, 174D)});
			// 
			// t46
			// 
			this.t46.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t46.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t46.Location = new NxtControl.Drawing.PointF(414D, 156D);
			this.t46.Name = "t46";
			this.t46.Text = "Cinza claro: sem comunicação";
			// 
			// t47
			// 
			this.t47.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t47.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t47.Location = new NxtControl.Drawing.PointF(368D, 192D);
			this.t47.Name = "t47";
			this.t47.Text = "A / M: modo automático / manual";
			// 
			// t48
			// 
			this.t48.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t48.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t48.Location = new NxtControl.Drawing.PointF(368D, 208D);
			this.t48.Name = "t48";
			this.t48.Text = "45 %: posição atual;  L: atuador em local";
			// 
			// t49
			// 
			this.t49.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t49.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t49.Location = new NxtControl.Drawing.PointF(368D, 224D);
			this.t49.Name = "t49";
			this.t49.Text = "Comporta: mesma regra (placa cheia = aberta)";
			// 
			// titm50
			// 
			this.titm50.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.titm50.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.titm50.Location = new NxtControl.Drawing.PointF(362D, 262D);
			this.titm50.Name = "titm50";
			this.titm50.Text = "MEDIÇÕES";
			// 
			// mv51
			// 
			this.mv51.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(288D)), ((float)(110D)), ((float)(22D)));
			this.mv51.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.mv51.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mv51.Name = "mv51";
			this.mv51.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t52
			// 
			this.t52.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t52.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t52.Location = new NxtControl.Drawing.PointF(374D, 291D);
			this.t52.Name = "t52";
			this.t52.Text = "3,52 m  44 %";
			// 
			// t53
			// 
			this.t53.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t53.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t53.Location = new NxtControl.Drawing.PointF(488D, 292D);
			this.t53.Name = "t53";
			this.t53.Text = "Valor (nível em m e em %)";
			// 
			// mf54
			// 
			this.mf54.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(316D)), ((float)(110D)), ((float)(22D)));
			this.mf54.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.mf54.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mf54.Name = "mf54";
			this.mf54.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t55
			// 
			this.t55.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t55.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t55.Location = new NxtControl.Drawing.PointF(398D, 319D);
			this.t55.Name = "t55";
			this.t55.Text = "????";
			// 
			// t56
			// 
			this.t56.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t56.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t56.Location = new NxtControl.Drawing.PointF(488D, 320D);
			this.t56.Name = "t56";
			this.t56.Text = "Sinal em falha (valor inválido)";
			// 
			// md57
			// 
			this.md57.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(344D)), ((float)(110D)), ((float)(22D)));
			this.md57.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.md57.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.md57.Name = "md57";
			this.md57.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t58
			// 
			this.t58.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t58.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t58.Location = new NxtControl.Drawing.PointF(392D, 347D);
			this.t58.Name = "t58";
			this.t58.Text = "DESAB.";
			// 
			// t59
			// 
			this.t59.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t59.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t59.Location = new NxtControl.Drawing.PointF(488D, 348D);
			this.t59.Name = "t59";
			this.t59.Text = "Sensor desabilitado";
			// 
			// t60
			// 
			this.t60.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t60.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t60.Location = new NxtControl.Drawing.PointF(368D, 378D);
			this.t60.Name = "t60";
			this.t60.Text = "HH / H / L / LL: alarmes de valor alto / baixo.";
			// 
			// t61
			// 
			this.t61.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t61.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t61.Location = new NxtControl.Drawing.PointF(368D, 394D);
			this.t61.Name = "t61";
			this.t61.Text = "Sensores de nível: alarmes em % da altura.";
			// 
			// titb62
			// 
			this.titb62.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.titb62.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.titb62.Location = new NxtControl.Drawing.PointF(362D, 430D);
			this.titb62.Name = "titb62";
			this.titb62.Text = "BOIAS";
			// 
			// t63
			// 
			this.t63.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t63.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t63.Location = new NxtControl.Drawing.PointF(368D, 454D);
			this.t63.Name = "t63";
			this.t63.Text = "levantada / abaixada: posição da boia";
			// 
			// t64
			// 
			this.t64.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t64.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t64.Location = new NxtControl.Drawing.PointF(368D, 470D);
			this.t64.Name = "t64";
			this.t64.Text = "sem leitura: sem comunicação com a remota";
			// 
			// titt65
			// 
			this.titt65.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.titt65.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.titt65.Location = new NxtControl.Drawing.PointF(362D, 500D);
			this.titt65.Name = "titt65";
			this.titt65.Text = "TUBULAÇÕES";
			// 
			// tb66
			// 
			this.tb66.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(530D)), ((float)(60D)), ((float)(6D)));
			this.tb66.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.tb66.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tb66.Name = "tb66";
			this.tb66.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t67
			// 
			this.t67.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t67.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t67.Location = new NxtControl.Drawing.PointF(442D, 526D);
			this.t67.Name = "t67";
			this.t67.Text = "Esgoto / lodo";
			// 
			// tb68
			// 
			this.tb68.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(552D)), ((float)(60D)), ((float)(6D)));
			this.tb68.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))));
			this.tb68.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tb68.Name = "tb68";
			this.tb68.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(160)), ((byte)(210))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t69
			// 
			this.t69.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t69.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t69.Location = new NxtControl.Drawing.PointF(442D, 548D);
			this.t69.Name = "t69";
			this.t69.Text = "Água";
			// 
			// tb70
			// 
			this.tb70.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(574D)), ((float)(60D)), ((float)(6D)));
			this.tb70.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))));
			this.tb70.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tb70.Name = "tb70";
			this.tb70.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(110)), ((byte)(150)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t71
			// 
			this.t71.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t71.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t71.Location = new NxtControl.Drawing.PointF(442D, 570D);
			this.t71.Name = "t71";
			this.t71.Text = "Ar";
			// 
			// tb72
			// 
			this.tb72.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(596D)), ((float)(60D)), ((float)(6D)));
			this.tb72.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))));
			this.tb72.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tb72.Name = "tb72";
			this.tb72.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(70)), ((byte)(130)), ((byte)(70))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t73
			// 
			this.t73.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t73.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t73.Location = new NxtControl.Drawing.PointF(442D, 592D);
			this.t73.Name = "t73";
			this.t73.Text = "Polímero";
			// 
			// tb74
			// 
			this.tb74.Bounds = new NxtControl.Drawing.RectF(((float)(368D)), ((float)(618D)), ((float)(60D)), ((float)(6D)));
			this.tb74.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))));
			this.tb74.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.tb74.Name = "tb74";
			this.tb74.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(185)), ((byte)(185)), ((byte)(185))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t75
			// 
			this.t75.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t75.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t75.Location = new NxtControl.Drawing.PointF(442D, 614D);
			this.t75.Name = "t75";
			this.t75.Text = "Previsto (futuro)";
			// 
			// card76
			// 
			this.card76.Bounds = new NxtControl.Drawing.RectF(((float)(690D)), ((float)(14D)), ((float)(330D)), ((float)(670D)));
			this.card76.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.card76.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.card76.Name = "card76";
			this.card76.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tit77
			// 
			this.tit77.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tit77.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tit77.Location = new NxtControl.Drawing.PointF(700D, 22D);
			this.tit77.Name = "tit77";
			this.tit77.Text = "ALARMES (ISA-101)";
			// 
			// p178
			// 
			this.p178.Bounds = new NxtControl.Drawing.RectF(((float)(706D)), ((float)(46D)), ((float)(18D)), ((float)(18D)));
			this.p178.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.p178.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.p178.Name = "p178";
			this.p178.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t79
			// 
			this.t79.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.t79.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.t79.Location = new NxtControl.Drawing.PointF(711D, 47D);
			this.t79.Name = "t79";
			this.t79.Text = "1";
			// 
			// t80
			// 
			this.t80.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t80.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t80.Location = new NxtControl.Drawing.PointF(734D, 44D);
			this.t80.Name = "t80";
			this.t80.Text = "Prioridade 1 - crítico";
			// 
			// t81
			// 
			this.t81.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t81.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t81.Location = new NxtControl.Drawing.PointF(734D, 60D);
			this.t81.Name = "t81";
			this.t81.Text = "falha, emergência: agir imediatamente";
			// 
			// p282
			// 
			this.p282.Bounds = new NxtControl.Drawing.RectF(((float)(706D)), ((float)(86D)), ((float)(18D)), ((float)(18D)));
			this.p282.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.p282.Closed = true;
			this.p282.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.p282.Name = "p282";
			this.p282.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.p282.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(706D, 104D),
			new NxtControl.Drawing.PointF(715D, 86D),
			new NxtControl.Drawing.PointF(724D, 104D)});
			// 
			// t83
			// 
			this.t83.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t83.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.t83.Location = new NxtControl.Drawing.PointF(712D, 90D);
			this.t83.Name = "t83";
			this.t83.Text = "2";
			// 
			// t84
			// 
			this.t84.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t84.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t84.Location = new NxtControl.Drawing.PointF(734D, 84D);
			this.t84.Name = "t84";
			this.t84.Text = "Prioridade 2 - aviso";
			// 
			// t85
			// 
			this.t85.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t85.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t85.Location = new NxtControl.Drawing.PointF(734D, 100D);
			this.t85.Name = "t85";
			this.t85.Text = "comunicação, disjuntor, desvio de processo";
			// 
			// t86
			// 
			this.t86.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t86.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t86.Location = new NxtControl.Drawing.PointF(706D, 130D);
			this.t86.Name = "t86";
			this.t86.Text = "Piscando: alarme ainda não reconhecido.";
			// 
			// t87
			// 
			this.t87.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t87.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t87.Location = new NxtControl.Drawing.PointF(706D, 146D);
			this.t87.Name = "t87";
			this.t87.Text = "Fixo: reconhecido, condição ainda ativa.";
			// 
			// t88
			// 
			this.t88.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t88.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t88.Location = new NxtControl.Drawing.PointF(706D, 162D);
			this.t88.Name = "t88";
			this.t88.Text = "Some quando a condição volta ao normal";
			// 
			// t89
			// 
			this.t89.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t89.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t89.Location = new NxtControl.Drawing.PointF(706D, 176D);
			this.t89.Name = "t89";
			this.t89.Text = "e o alarme foi reconhecido.";
			// 
			// t90
			// 
			this.t90.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t90.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t90.Location = new NxtControl.Drawing.PointF(706D, 200D);
			this.t90.Name = "t90";
			this.t90.Text = "Reconhecer: botão \"Reconhecer / Reset\" do";
			// 
			// t91
			// 
			this.t91.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t91.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t91.Location = new NxtControl.Drawing.PointF(706D, 214D);
			this.t91.Name = "t91";
			this.t91.Text = "faceplate ou \"Reset geral\" da tela.";
			// 
			// t92
			// 
			this.t92.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t92.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t92.Location = new NxtControl.Drawing.PointF(706D, 230D);
			this.t92.Name = "t92";
			this.t92.Text = "Lista completa: tela ALARMES.";
			// 
			// titn93
			// 
			this.titn93.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.titn93.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.titn93.Location = new NxtControl.Drawing.PointF(700D, 270D);
			this.titn93.Name = "titn93";
			this.titn93.Text = "NAVEGAÇÃO";
			// 
			// nb94
			// 
			this.nb94.Bounds = new NxtControl.Drawing.RectF(((float)(706D)), ((float)(296D)), ((float)(150D)), ((float)(26D)));
			this.nb94.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(240)), ((byte)(240)), ((byte)(240))));
			this.nb94.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nb94.Name = "nb94";
			this.nb94.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t95
			// 
			this.t95.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t95.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t95.Location = new NxtControl.Drawing.PointF(714D, 302D);
			this.t95.Name = "t95";
			this.t95.Text = "EEE BRUTO (100)  ›";
			// 
			// t96
			// 
			this.t96.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t96.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t96.Location = new NxtControl.Drawing.PointF(866D, 302D);
			this.t96.Name = "t96";
			this.t96.Text = "Abre a tela da área";
			// 
			// t97
			// 
			this.t97.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t97.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t97.Location = new NxtControl.Drawing.PointF(706D, 334D);
			this.t97.Name = "t97";
			this.t97.Text = "Clique no equipamento: abre o faceplate";
			// 
			// t98
			// 
			this.t98.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t98.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t98.Location = new NxtControl.Drawing.PointF(706D, 350D);
			this.t98.Name = "t98";
			this.t98.Text = "(estado, comandos, ajustes e alarmes).";
			// 
			// t99
			// 
			this.t99.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t99.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t99.Location = new NxtControl.Drawing.PointF(706D, 370D);
			this.t99.Name = "t99";
			this.t99.Text = "Botão \"Ver skid\": desenho do conjunto do";
			// 
			// t100
			// 
			this.t100.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t100.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t100.Location = new NxtControl.Drawing.PointF(706D, 386D);
			this.t100.Name = "t100";
			this.t100.Text = "fornecedor (prensas, polímero, gradeamento).";
			// 
			// rg101
			// 
			this.rg101.Bounds = new NxtControl.Drawing.RectF(((float)(706D)), ((float)(410D)), ((float)(110D)), ((float)(26D)));
			this.rg101.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.rg101.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rg101.Name = "rg101";
			this.rg101.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t102
			// 
			this.t102.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t102.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t102.Location = new NxtControl.Drawing.PointF(720D, 416D);
			this.t102.Name = "t102";
			this.t102.Text = "Reset geral";
			// 
			// t103
			// 
			this.t103.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t103.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t103.Location = new NxtControl.Drawing.PointF(826D, 410D);
			this.t103.Name = "t103";
			this.t103.Text = "Reconhece e reseta todos os";
			// 
			// t104
			// 
			this.t104.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t104.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t104.Location = new NxtControl.Drawing.PointF(826D, 424D);
			this.t104.Name = "t104";
			this.t104.Text = "equipamentos da tela";
			// 
			// t105
			// 
			this.t105.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t105.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t105.Location = new NxtControl.Drawing.PointF(706D, 456D);
			this.t105.Name = "t105";
			this.t105.Text = "Barra superior: áreas na ordem do processo;";
			// 
			// t106
			// 
			this.t106.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t106.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t106.Location = new NxtControl.Drawing.PointF(706D, 472D);
			this.t106.Name = "t106";
			this.t106.Text = "a segunda linha mostra as telas da área.";
			// 
			// card107
			// 
			this.card107.Bounds = new NxtControl.Drawing.RectF(((float)(1028D)), ((float)(14D)), ((float)(324D)), ((float)(670D)));
			this.card107.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(236)), ((byte)(236)), ((byte)(236))));
			this.card107.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.card107.Name = "card107";
			this.card107.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tit108
			// 
			this.tit108.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tit108.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tit108.Location = new NxtControl.Drawing.PointF(1038D, 22D);
			this.tit108.Name = "tit108";
			this.tit108.Text = "NEREDA (símbolos SE)";
			// 
			// s109
			// 
			this.s109.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.s109.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.s109.Location = new NxtControl.Drawing.PointF(1038D, 40D);
			this.s109.Name = "s109";
			this.s109.Text = "MOTORES E BOMBAS";
			// 
			// nm110
			// 
			this.nm110.Bounds = new NxtControl.Drawing.RectF(((float)(1044D)), ((float)(58D)), ((float)(30D)), ((float)(20D)));
			this.nm110.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PassiveStatus"));
			this.nm110.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nm110.Name = "nm110";
			this.nm110.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t111
			// 
			this.t111.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t111.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t111.Location = new NxtControl.Drawing.PointF(1084D, 61D);
			this.t111.Name = "t111";
			this.t111.Text = "Parado";
			// 
			// nm112
			// 
			this.nm112.Bounds = new NxtControl.Drawing.RectF(((float)(1044D)), ((float)(88D)), ((float)(30D)), ((float)(20D)));
			this.nm112.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.ActiveStatus"));
			this.nm112.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nm112.Name = "nm112";
			this.nm112.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t113
			// 
			this.t113.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t113.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t113.Location = new NxtControl.Drawing.PointF(1084D, 91D);
			this.t113.Name = "t113";
			this.t113.Text = "Ligado";
			// 
			// np114
			// 
			this.np114.Bounds = new NxtControl.Drawing.RectF(((float)(1044D)), ((float)(118D)), ((float)(30D)), ((float)(20D)));
			this.np114.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.np114.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.np114.Name = "np114";
			this.np114.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t115
			// 
			this.t115.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t115.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t115.Location = new NxtControl.Drawing.PointF(1084D, 121D);
			this.t115.Name = "t115";
			this.t115.Text = "Em falha (pisca)";
			// 
			// nm116
			// 
			this.nm116.Bounds = new NxtControl.Drawing.RectF(((float)(1044D)), ((float)(148D)), ((float)(30D)), ((float)(20D)));
			this.nm116.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PowerOFF"));
			this.nm116.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nm116.Name = "nm116";
			this.nm116.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t117
			// 
			this.t117.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t117.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t117.Location = new NxtControl.Drawing.PointF(1084D, 151D);
			this.t117.Name = "t117";
			this.t117.Text = "Sem energia";
			// 
			// s118
			// 
			this.s118.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.s118.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.s118.Location = new NxtControl.Drawing.PointF(1038D, 186D);
			this.s118.Name = "s118";
			this.s118.Text = "VÁLVULAS";
			// 
			// nv119
			// 
			this.nv119.Bounds = new NxtControl.Drawing.RectF(((float)(1044D)), ((float)(204D)), ((float)(30D)), ((float)(20D)));
			this.nv119.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.PassiveStatus"));
			this.nv119.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nv119.Name = "nv119";
			this.nv119.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t120
			// 
			this.t120.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t120.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t120.Location = new NxtControl.Drawing.PointF(1084D, 207D);
			this.t120.Name = "t120";
			this.t120.Text = "Fechada";
			// 
			// nv121
			// 
			this.nv121.Bounds = new NxtControl.Drawing.RectF(((float)(1044D)), ((float)(234D)), ((float)(30D)), ((float)(20D)));
			this.nv121.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SE.Nereda.ActiveStatus"));
			this.nv121.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.nv121.Name = "nv121";
			this.nv121.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t122
			// 
			this.t122.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t122.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t122.Location = new NxtControl.Drawing.PointF(1084D, 237D);
			this.t122.Name = "t122";
			this.t122.Text = "Aberta";
			// 
			// np123
			// 
			this.np123.Bounds = new NxtControl.Drawing.RectF(((float)(1044D)), ((float)(264D)), ((float)(30D)), ((float)(20D)));
			this.np123.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.BlinkColor("SE.Nereda.Orangwhite"));
			this.np123.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.np123.Name = "np123";
			this.np123.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// t124
			// 
			this.t124.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t124.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t124.Location = new NxtControl.Drawing.PointF(1084D, 267D);
			this.t124.Name = "t124";
			this.t124.Text = "Em falha (pisca)";
			// 
			// s125
			// 
			this.s125.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.s125.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.s125.Location = new NxtControl.Drawing.PointF(1038D, 310D);
			this.s125.Name = "s125";
			this.s125.Text = "CÓDIGO DE ESTADO DO ATUADOR";
			// 
			// t126
			// 
			this.t126.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t126.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t126.Location = new NxtControl.Drawing.PointF(1044D, 330D);
			this.t126.Name = "t126";
			this.t126.Text = "O";
			// 
			// t127
			// 
			this.t127.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t127.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t127.Location = new NxtControl.Drawing.PointF(1140D, 330D);
			this.t127.Name = "t127";
			this.t127.Text = "Modo operador";
			// 
			// t128
			// 
			this.t128.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t128.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t128.Location = new NxtControl.Drawing.PointF(1044D, 356D);
			this.t128.Name = "t128";
			this.t128.Text = "P";
			// 
			// t129
			// 
			this.t129.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t129.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t129.Location = new NxtControl.Drawing.PointF(1140D, 356D);
			this.t129.Name = "t129";
			this.t129.Text = "Modo programa";
			// 
			// t130
			// 
			this.t130.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t130.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t130.Location = new NxtControl.Drawing.PointF(1044D, 382D);
			this.t130.Name = "t130";
			this.t130.Text = "R";
			// 
			// t131
			// 
			this.t131.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t131.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t131.Location = new NxtControl.Drawing.PointF(1140D, 382D);
			this.t131.Name = "t131";
			this.t131.Text = "Modo remoto";
			// 
			// t132
			// 
			this.t132.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t132.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t132.Location = new NxtControl.Drawing.PointF(1044D, 408D);
			this.t132.Name = "t132";
			this.t132.Text = "Ilck";
			// 
			// t133
			// 
			this.t133.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t133.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t133.Location = new NxtControl.Drawing.PointF(1140D, 408D);
			this.t133.Name = "t133";
			this.t133.Text = "Intertravado";
			// 
			// t134
			// 
			this.t134.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t134.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t134.Location = new NxtControl.Drawing.PointF(1044D, 434D);
			this.t134.Name = "t134";
			this.t134.Text = "OFF";
			// 
			// t135
			// 
			this.t135.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t135.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t135.Location = new NxtControl.Drawing.PointF(1140D, 434D);
			this.t135.Name = "t135";
			this.t135.Text = "Sem energia";
			// 
			// t136
			// 
			this.t136.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t136.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t136.Location = new NxtControl.Drawing.PointF(1044D, 460D);
			this.t136.Name = "t136";
			this.t136.Text = "Need Rearm";
			// 
			// t137
			// 
			this.t137.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t137.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t137.Location = new NxtControl.Drawing.PointF(1140D, 460D);
			this.t137.Name = "t137";
			this.t137.Text = "Reset / rearme necessário";
			// 
			// t138
			// 
			this.t138.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t138.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t138.Location = new NxtControl.Drawing.PointF(1044D, 486D);
			this.t138.Name = "t138";
			this.t138.Text = "S";
			// 
			// t139
			// 
			this.t139.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t139.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t139.Location = new NxtControl.Drawing.PointF(1140D, 486D);
			this.t139.Name = "t139";
			this.t139.Text = "Simulação ou forçamento ativo";
			// 
			// t140
			// 
			this.t140.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t140.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.t140.Location = new NxtControl.Drawing.PointF(1044D, 512D);
			this.t140.Name = "t140";
			this.t140.Text = "?";
			// 
			// t141
			// 
			this.t141.Color = new NxtControl.Drawing.Color(((byte)(32)), ((byte)(32)), ((byte)(32)));
			this.t141.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.t141.Location = new NxtControl.Drawing.PointF(1140D, 512D);
			this.t141.Name = "t141";
			this.t141.Text = "Não pronto / estado desconhecido";
			// 
			// t142
			// 
			this.t142.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.t142.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t142.Location = new NxtControl.Drawing.PointF(1044D, 552D);
			this.t142.Name = "t142";
			this.t142.Text = "As telas da Nereda usam os símbolos do";
			// 
			// t143
			// 
			this.t143.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.t143.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t143.Location = new NxtControl.Drawing.PointF(1044D, 566D);
			this.t143.Name = "t143";
			this.t143.Text = "fornecedor; as demais áreas usam os";
			// 
			// t144
			// 
			this.t144.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.t144.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.t144.Location = new NxtControl.Drawing.PointF(1044D, 580D);
			this.t144.Name = "t144";
			this.t144.Text = "símbolos da HidrycoLib (colunas ao lado).";
			// 
			// LEGEND_
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.cardProcesso,
			this.card1,
			this.tit2,
			this.s3,
			this.g4,
			this.t5,
			this.g6,
			this.t7,
			this.g8,
			this.t9,
			this.g10,
			this.t11,
			this.s12,
			this.lr13,
			this.t14,
			this.t15,
			this.am16,
			this.t17,
			this.t18,
			this.g19,
			this.t20,
			this.g21,
			this.t22,
			this.g23,
			this.t24,
			this.g25,
			this.t26,
			this.t27,
			this.t28,
			this.t29,
			this.t30,
			this.t31,
			this.t32,
			this.card33,
			this.tit34,
			this.vE35,
			this.vD36,
			this.t37,
			this.vE38,
			this.vD39,
			this.t40,
			this.vE41,
			this.vD42,
			this.t43,
			this.vE44,
			this.vD45,
			this.t46,
			this.t47,
			this.t48,
			this.t49,
			this.titm50,
			this.mv51,
			this.t52,
			this.t53,
			this.mf54,
			this.t55,
			this.t56,
			this.md57,
			this.t58,
			this.t59,
			this.t60,
			this.t61,
			this.titb62,
			this.t63,
			this.t64,
			this.titt65,
			this.tb66,
			this.t67,
			this.tb68,
			this.t69,
			this.tb70,
			this.t71,
			this.tb72,
			this.t73,
			this.tb74,
			this.t75,
			this.card76,
			this.tit77,
			this.p178,
			this.t79,
			this.t80,
			this.t81,
			this.p282,
			this.t83,
			this.t84,
			this.t85,
			this.t86,
			this.t87,
			this.t88,
			this.t89,
			this.t90,
			this.t91,
			this.t92,
			this.titn93,
			this.nb94,
			this.t95,
			this.t96,
			this.t97,
			this.t98,
			this.t99,
			this.t100,
			this.rg101,
			this.t102,
			this.t103,
			this.t104,
			this.t105,
			this.t106,
			this.card107,
			this.tit108,
			this.s109,
			this.nm110,
			this.t111,
			this.nm112,
			this.t113,
			this.np114,
			this.t115,
			this.nm116,
			this.t117,
			this.s118,
			this.nv119,
			this.t120,
			this.nv121,
			this.t122,
			this.np123,
			this.t124,
			this.s125,
			this.t126,
			this.t127,
			this.t128,
			this.t129,
			this.t130,
			this.t131,
			this.t132,
			this.t133,
			this.t134,
			this.t135,
			this.t136,
			this.t137,
			this.t138,
			this.t139,
			this.t140,
			this.t141,
			this.t142,
			this.t143,
			this.t144});
		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle cardProcesso;
		private NxtControl.GuiFramework.Rectangle card1;
		private NxtControl.GuiFramework.FreeText tit2;
		private NxtControl.GuiFramework.FreeText s3;
		private Hidryco.HidrycoLib.Graphics.Bomba g4;
		private NxtControl.GuiFramework.FreeText t5;
		private Hidryco.HidrycoLib.Graphics.Bomba g6;
		private NxtControl.GuiFramework.FreeText t7;
		private Hidryco.HidrycoLib.Graphics.Bomba g8;
		private NxtControl.GuiFramework.FreeText t9;
		private Hidryco.HidrycoLib.Graphics.Bomba g10;
		private NxtControl.GuiFramework.FreeText t11;
		private NxtControl.GuiFramework.FreeText s12;
		private NxtControl.GuiFramework.Rectangle lr13;
		private NxtControl.GuiFramework.FreeText t14;
		private NxtControl.GuiFramework.FreeText t15;
		private NxtControl.GuiFramework.Rectangle am16;
		private NxtControl.GuiFramework.FreeText t17;
		private NxtControl.GuiFramework.FreeText t18;
		private Hidryco.HidrycoLib.Graphics.Unidade_Portecao_Termica g19;
		private NxtControl.GuiFramework.FreeText t20;
		private Hidryco.HidrycoLib.Graphics.falha_comunicacao g21;
		private NxtControl.GuiFramework.FreeText t22;
		private Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador g23;
		private NxtControl.GuiFramework.FreeText t24;
		private Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador g25;
		private NxtControl.GuiFramework.FreeText t26;
		private NxtControl.GuiFramework.FreeText t27;
		private NxtControl.GuiFramework.FreeText t28;
		private NxtControl.GuiFramework.FreeText t29;
		private NxtControl.GuiFramework.FreeText t30;
		private NxtControl.GuiFramework.FreeText t31;
		private NxtControl.GuiFramework.FreeText t32;
		private NxtControl.GuiFramework.Rectangle card33;
		private NxtControl.GuiFramework.FreeText tit34;
		private NxtControl.GuiFramework.Polygon vE35;
		private NxtControl.GuiFramework.Polygon vD36;
		private NxtControl.GuiFramework.FreeText t37;
		private NxtControl.GuiFramework.Polygon vE38;
		private NxtControl.GuiFramework.Polygon vD39;
		private NxtControl.GuiFramework.FreeText t40;
		private NxtControl.GuiFramework.Polygon vE41;
		private NxtControl.GuiFramework.Polygon vD42;
		private NxtControl.GuiFramework.FreeText t43;
		private NxtControl.GuiFramework.Polygon vE44;
		private NxtControl.GuiFramework.Polygon vD45;
		private NxtControl.GuiFramework.FreeText t46;
		private NxtControl.GuiFramework.FreeText t47;
		private NxtControl.GuiFramework.FreeText t48;
		private NxtControl.GuiFramework.FreeText t49;
		private NxtControl.GuiFramework.FreeText titm50;
		private NxtControl.GuiFramework.Rectangle mv51;
		private NxtControl.GuiFramework.FreeText t52;
		private NxtControl.GuiFramework.FreeText t53;
		private NxtControl.GuiFramework.Rectangle mf54;
		private NxtControl.GuiFramework.FreeText t55;
		private NxtControl.GuiFramework.FreeText t56;
		private NxtControl.GuiFramework.Rectangle md57;
		private NxtControl.GuiFramework.FreeText t58;
		private NxtControl.GuiFramework.FreeText t59;
		private NxtControl.GuiFramework.FreeText t60;
		private NxtControl.GuiFramework.FreeText t61;
		private NxtControl.GuiFramework.FreeText titb62;
		private NxtControl.GuiFramework.FreeText t63;
		private NxtControl.GuiFramework.FreeText t64;
		private NxtControl.GuiFramework.FreeText titt65;
		private NxtControl.GuiFramework.Rectangle tb66;
		private NxtControl.GuiFramework.FreeText t67;
		private NxtControl.GuiFramework.Rectangle tb68;
		private NxtControl.GuiFramework.FreeText t69;
		private NxtControl.GuiFramework.Rectangle tb70;
		private NxtControl.GuiFramework.FreeText t71;
		private NxtControl.GuiFramework.Rectangle tb72;
		private NxtControl.GuiFramework.FreeText t73;
		private NxtControl.GuiFramework.Rectangle tb74;
		private NxtControl.GuiFramework.FreeText t75;
		private NxtControl.GuiFramework.Rectangle card76;
		private NxtControl.GuiFramework.FreeText tit77;
		private NxtControl.GuiFramework.Rectangle p178;
		private NxtControl.GuiFramework.FreeText t79;
		private NxtControl.GuiFramework.FreeText t80;
		private NxtControl.GuiFramework.FreeText t81;
		private NxtControl.GuiFramework.Polygon p282;
		private NxtControl.GuiFramework.FreeText t83;
		private NxtControl.GuiFramework.FreeText t84;
		private NxtControl.GuiFramework.FreeText t85;
		private NxtControl.GuiFramework.FreeText t86;
		private NxtControl.GuiFramework.FreeText t87;
		private NxtControl.GuiFramework.FreeText t88;
		private NxtControl.GuiFramework.FreeText t89;
		private NxtControl.GuiFramework.FreeText t90;
		private NxtControl.GuiFramework.FreeText t91;
		private NxtControl.GuiFramework.FreeText t92;
		private NxtControl.GuiFramework.FreeText titn93;
		private NxtControl.GuiFramework.Rectangle nb94;
		private NxtControl.GuiFramework.FreeText t95;
		private NxtControl.GuiFramework.FreeText t96;
		private NxtControl.GuiFramework.FreeText t97;
		private NxtControl.GuiFramework.FreeText t98;
		private NxtControl.GuiFramework.FreeText t99;
		private NxtControl.GuiFramework.FreeText t100;
		private NxtControl.GuiFramework.Rectangle rg101;
		private NxtControl.GuiFramework.FreeText t102;
		private NxtControl.GuiFramework.FreeText t103;
		private NxtControl.GuiFramework.FreeText t104;
		private NxtControl.GuiFramework.FreeText t105;
		private NxtControl.GuiFramework.FreeText t106;
		private NxtControl.GuiFramework.Rectangle card107;
		private NxtControl.GuiFramework.FreeText tit108;
		private NxtControl.GuiFramework.FreeText s109;
		private NxtControl.GuiFramework.Rectangle nm110;
		private NxtControl.GuiFramework.FreeText t111;
		private NxtControl.GuiFramework.Rectangle nm112;
		private NxtControl.GuiFramework.FreeText t113;
		private NxtControl.GuiFramework.Rectangle np114;
		private NxtControl.GuiFramework.FreeText t115;
		private NxtControl.GuiFramework.Rectangle nm116;
		private NxtControl.GuiFramework.FreeText t117;
		private NxtControl.GuiFramework.FreeText s118;
		private NxtControl.GuiFramework.Rectangle nv119;
		private NxtControl.GuiFramework.FreeText t120;
		private NxtControl.GuiFramework.Rectangle nv121;
		private NxtControl.GuiFramework.FreeText t122;
		private NxtControl.GuiFramework.Rectangle np123;
		private NxtControl.GuiFramework.FreeText t124;
		private NxtControl.GuiFramework.FreeText s125;
		private NxtControl.GuiFramework.FreeText t126;
		private NxtControl.GuiFramework.FreeText t127;
		private NxtControl.GuiFramework.FreeText t128;
		private NxtControl.GuiFramework.FreeText t129;
		private NxtControl.GuiFramework.FreeText t130;
		private NxtControl.GuiFramework.FreeText t131;
		private NxtControl.GuiFramework.FreeText t132;
		private NxtControl.GuiFramework.FreeText t133;
		private NxtControl.GuiFramework.FreeText t134;
		private NxtControl.GuiFramework.FreeText t135;
		private NxtControl.GuiFramework.FreeText t136;
		private NxtControl.GuiFramework.FreeText t137;
		private NxtControl.GuiFramework.FreeText t138;
		private NxtControl.GuiFramework.FreeText t139;
		private NxtControl.GuiFramework.FreeText t140;
		private NxtControl.GuiFramework.FreeText t141;
		private NxtControl.GuiFramework.FreeText t142;
		private NxtControl.GuiFramework.FreeText t143;
		private NxtControl.GuiFramework.FreeText t144;
		#endregion
	}
}
