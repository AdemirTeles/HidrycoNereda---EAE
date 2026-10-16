/*
 * Hidryco - UCT_Equipamento - sDefault
 * ISA-101: equipamento da UCT - estado em texto e caixa cheia/vazada; A = subsistema em automatico.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.UCT_Equipamento
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
			this.caixaEstado = new NxtControl.GuiFramework.Rectangle();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.textoEstado = new NxtControl.GuiFramework.FreeText();
			this.textoModo = new NxtControl.GuiFramework.FreeText();
			this.x_anim = new System.HMI.Symbols.Base.Execute<short>();
			this.x_defeito = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_auto = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbLiga = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbInt = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_fbRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgVel = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgInt = new System.HMI.Symbols.Base.Execute<bool>();
			this.x_cfgRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(130D)), ((float)(56D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// caixaEstado
			// 
			this.caixaEstado.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(26D)), ((float)(14D)), ((float)(14D)));
			this.caixaEstado.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.caixaEstado.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixaEstado.Name = "caixaEstado";
			this.caixaEstado.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 2F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(4D)), ((float)(2D)), ((float)(122D)), ((float)(18D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// textoEstado
			// 
			this.textoEstado.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoEstado.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.textoEstado.Location = new NxtControl.Drawing.PointF(26D, 25D);
			this.textoEstado.Name = "textoEstado";
			this.textoEstado.Text = "DESLIGADO";
			// 
			// textoModo
			// 
			this.textoModo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.textoModo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.textoModo.Location = new NxtControl.Drawing.PointF(112D, 38D);
			this.textoModo.Name = "textoModo";
			this.textoModo.Text = "A";
			this.textoModo.Visible = false;
			// 
			// x_anim
			// 
			this.x_anim.BeginInit();
			this.x_anim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_anim.IsOnlyInput = true;
			this.x_anim.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_anim.Name = "x_anim";
			this.x_anim.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_anim.TagName = "STS_ANIMACAO";
			this.x_anim.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_animChanged);
			this.x_anim.EndInit();
			// 
			// x_defeito
			// 
			this.x_defeito.BeginInit();
			this.x_defeito.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_defeito.IsOnlyInput = true;
			this.x_defeito.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_defeito.Name = "x_defeito";
			this.x_defeito.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_defeito.TagName = "STS_DEFEITO";
			this.x_defeito.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_defeitoChanged);
			this.x_defeito.EndInit();
			// 
			// x_auto
			// 
			this.x_auto.BeginInit();
			this.x_auto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_auto.IsOnlyInput = true;
			this.x_auto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_auto.Name = "x_auto";
			this.x_auto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_auto.TagName = "STS_AUTOMATICO_SUBSISTEMA";
			this.x_auto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_autoChanged);
			this.x_auto.EndInit();
			// 
			// x_fbLiga
			// 
			this.x_fbLiga.BeginInit();
			this.x_fbLiga.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_fbLiga.IsOnlyInput = true;
			this.x_fbLiga.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_fbLiga.Name = "x_fbLiga";
			this.x_fbLiga.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_fbLiga.TagName = "fbkCmdLigaManual";
			this.x_fbLiga.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_fbLigaChanged);
			this.x_fbLiga.EndInit();
			// 
			// x_fbInt
			// 
			this.x_fbInt.BeginInit();
			this.x_fbInt.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_fbInt.IsOnlyInput = true;
			this.x_fbInt.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_fbInt.Name = "x_fbInt";
			this.x_fbInt.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_fbInt.TagName = "fbkCmdLigaIntermitente";
			this.x_fbInt.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_fbIntChanged);
			this.x_fbInt.EndInit();
			// 
			// x_fbRev
			// 
			this.x_fbRev.BeginInit();
			this.x_fbRev.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_fbRev.IsOnlyInput = true;
			this.x_fbRev.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_fbRev.Name = "x_fbRev";
			this.x_fbRev.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_fbRev.TagName = "fbkHabilitaReversao";
			this.x_fbRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_fbRevChanged);
			this.x_fbRev.EndInit();
			// 
			// x_cfgVel
			// 
			this.x_cfgVel.BeginInit();
			this.x_cfgVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_cfgVel.IsOnlyInput = true;
			this.x_cfgVel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_cfgVel.Name = "x_cfgVel";
			this.x_cfgVel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_cfgVel.TagName = "CFG_VELOCIDADE";
			this.x_cfgVel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_cfgVelChanged);
			this.x_cfgVel.EndInit();
			// 
			// x_cfgInt
			// 
			this.x_cfgInt.BeginInit();
			this.x_cfgInt.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_cfgInt.IsOnlyInput = true;
			this.x_cfgInt.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_cfgInt.Name = "x_cfgInt";
			this.x_cfgInt.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_cfgInt.TagName = "CFG_INTERMITENTE";
			this.x_cfgInt.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_cfgIntChanged);
			this.x_cfgInt.EndInit();
			// 
			// x_cfgRev
			// 
			this.x_cfgRev.BeginInit();
			this.x_cfgRev.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.x_cfgRev.IsOnlyInput = true;
			this.x_cfgRev.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.x_cfgRev.Name = "x_cfgRev";
			this.x_cfgRev.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.x_cfgRev.TagName = "CFG_REVERSAO";
			this.x_cfgRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.V_cfgRevChanged);
			this.x_cfgRev.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(130D)), ((float)(56D)));
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
			this.caixaEstado,
			this.InstanceName,
			this.textoEstado,
			this.textoModo,
			this.x_anim,
			this.x_defeito,
			this.x_auto,
			this.x_fbLiga,
			this.x_fbInt,
			this.x_fbRev,
			this.x_cfgVel,
			this.x_cfgInt,
			this.x_cfgRev,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(130, 56);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.Rectangle caixaEstado;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.FreeText textoEstado;
		private NxtControl.GuiFramework.FreeText textoModo;
		private System.HMI.Symbols.Base.Execute<short> x_anim;
		private System.HMI.Symbols.Base.Execute<bool> x_defeito;
		private System.HMI.Symbols.Base.Execute<bool> x_auto;
		private System.HMI.Symbols.Base.Execute<bool> x_fbLiga;
		private System.HMI.Symbols.Base.Execute<bool> x_fbInt;
		private System.HMI.Symbols.Base.Execute<bool> x_fbRev;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgVel;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgInt;
		private System.HMI.Symbols.Base.Execute<bool> x_cfgRev;
		private NxtControl.GuiFramework.DrawnButton abrir;
		#endregion
	}
}
