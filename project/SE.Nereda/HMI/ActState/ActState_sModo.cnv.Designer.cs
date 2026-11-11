/*
 * Criado pelo gerador fp_modo (padrao Hidryco).
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.ActState
{
	/// <summary>
	/// Summary description for sModo.
	/// </summary>
	partial class sModo
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.caixa = new NxtControl.GuiFramework.Rectangle();
			this.divisao = new NxtControl.GuiFramework.Rectangle();
			this.tRL = new NxtControl.GuiFramework.FreeText();
			this.tMA = new NxtControl.GuiFramework.FreeText();
			this.rxProg = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxOper = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxRemote = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// caixa
			// 
			this.caixa.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(24D)), ((float)(40D)));
			this.caixa.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.caixa.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.caixa.Name = "caixa";
			this.caixa.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// divisao
			// 
			this.divisao.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(20D)), ((float)(24D)), ((float)(1D)));
			this.divisao.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.divisao.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.divisao.Name = "divisao";
			this.divisao.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// tRL
			// 
			this.tRL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tRL.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tRL.Location = new NxtControl.Drawing.PointF(6D, 1D);
			this.tRL.Name = "tRL";
			this.tRL.Text = "L";
			// 
			// tMA
			// 
			this.tMA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tMA.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.tMA.Location = new NxtControl.Drawing.PointF(4D, 21D);
			this.tMA.Name = "tMA";
			this.tMA.Text = "M";
			// 
			// rxProg
			// 
			this.rxProg.BeginInit();
			this.rxProg.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxProg.IsOnlyInput = true;
			this.rxProg.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxProg.Name = "rxProg";
			this.rxProg.SecurityLevel = 0;
			this.rxProg.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxProg.TagName = "Prog";
			this.rxProg.Value = false;
			this.rxProg.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxProgChanged);
			this.rxProg.EndInit();
			// 
			// rxOper
			// 
			this.rxOper.BeginInit();
			this.rxOper.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxOper.IsOnlyInput = true;
			this.rxOper.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxOper.Name = "rxOper";
			this.rxOper.SecurityLevel = 0;
			this.rxOper.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxOper.TagName = "Oper";
			this.rxOper.Value = false;
			this.rxOper.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxOperChanged);
			this.rxOper.EndInit();
			// 
			// rxRemote
			// 
			this.rxRemote.BeginInit();
			this.rxRemote.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxRemote.IsOnlyInput = true;
			this.rxRemote.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxRemote.Name = "rxRemote";
			this.rxRemote.SecurityLevel = 0;
			this.rxRemote.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxRemote.TagName = "Remote";
			this.rxRemote.Value = false;
			this.rxRemote.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxRemoteChanged);
			this.rxRemote.EndInit();
			// 
			// sModo
			// 
			this.Name = "sModo";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.caixa,
			this.divisao,
			this.tRL,
			this.tMA,
			this.rxProg,
			this.rxOper,
			this.rxRemote});
			this.SymbolSize = new System.Drawing.Size(24, 40);

		}
		private NxtControl.GuiFramework.Rectangle caixa;
		private NxtControl.GuiFramework.Rectangle divisao;
		private NxtControl.GuiFramework.FreeText tRL;
		private NxtControl.GuiFramework.FreeText tMA;
		private System.HMI.Symbols.Base.Execute<bool> rxProg;
		private System.HMI.Symbols.Base.Execute<bool> rxOper;
		private System.HMI.Symbols.Base.Execute<bool> rxRemote;

		#endregion
	}
}
