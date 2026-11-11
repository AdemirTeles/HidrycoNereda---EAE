/*
 * Criado pelo gerador fp_diag (padrao Hidryco).
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MotVsFailures
{
	/// <summary>
	/// Summary description for sDiagnostico.
	/// </summary>
	partial class sDiagnostico
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.r_F1 = new NxtControl.GuiFramework.FreeText();
			this.v_F1 = new NxtControl.GuiFramework.FreeText();
			this.c_F1 = new NxtControl.GuiFramework.FreeText();
			this.r_F2 = new NxtControl.GuiFramework.FreeText();
			this.v_F2 = new NxtControl.GuiFramework.FreeText();
			this.c_F2 = new NxtControl.GuiFramework.FreeText();
			this.r_F3 = new NxtControl.GuiFramework.FreeText();
			this.v_F3 = new NxtControl.GuiFramework.FreeText();
			this.c_F3 = new NxtControl.GuiFramework.FreeText();
			this.r_F4 = new NxtControl.GuiFramework.FreeText();
			this.v_F4 = new NxtControl.GuiFramework.FreeText();
			this.c_F4 = new NxtControl.GuiFramework.FreeText();
			this.r_F5 = new NxtControl.GuiFramework.FreeText();
			this.v_F5 = new NxtControl.GuiFramework.FreeText();
			this.c_F5 = new NxtControl.GuiFramework.FreeText();
			this.r_F6 = new NxtControl.GuiFramework.FreeText();
			this.v_F6 = new NxtControl.GuiFramework.FreeText();
			this.c_F6 = new NxtControl.GuiFramework.FreeText();
			this.rxF1 = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxC1 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.rxF2 = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxC2 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.rxF3 = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxC3 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.rxF4 = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxC4 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.rxF5 = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxC5 = new System.HMI.Symbols.Base.Execute<ushort>();
			this.rxF6 = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxC6 = new System.HMI.Symbols.Base.Execute<ushort>();
			// 
			// r_F1
			// 
			this.r_F1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_F1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_F1.Location = new NxtControl.Drawing.PointF(6D, 3D);
			this.r_F1.Name = "r_F1";
			this.r_F1.Text = "Inversor (acionamento)";
			// 
			// v_F1
			// 
			this.v_F1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_F1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_F1.Location = new NxtControl.Drawing.PointF(210D, 3D);
			this.v_F1.Name = "v_F1";
			this.v_F1.Text = "\u2014";
			// 
			// c_F1
			// 
			this.c_F1.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.c_F1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.c_F1.Location = new NxtControl.Drawing.PointF(286D, 3D);
			this.c_F1.Name = "c_F1";
			this.c_F1.Text = "0";
			// 
			// r_F2
			// 
			this.r_F2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_F2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_F2.Location = new NxtControl.Drawing.PointF(6D, 27D);
			this.r_F2.Name = "r_F2";
			this.r_F2.Text = "Circuito el\u00e9trico";
			// 
			// v_F2
			// 
			this.v_F2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_F2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_F2.Location = new NxtControl.Drawing.PointF(210D, 27D);
			this.v_F2.Name = "v_F2";
			this.v_F2.Text = "\u2014";
			// 
			// c_F2
			// 
			this.c_F2.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.c_F2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.c_F2.Location = new NxtControl.Drawing.PointF(286D, 27D);
			this.c_F2.Name = "c_F2";
			this.c_F2.Text = "0";
			// 
			// r_F3
			// 
			this.r_F3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_F3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_F3.Location = new NxtControl.Drawing.PointF(6D, 51D);
			this.r_F3.Name = "r_F3";
			this.r_F3.Text = "Inversor de frequ\u00eancia";
			// 
			// v_F3
			// 
			this.v_F3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_F3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_F3.Location = new NxtControl.Drawing.PointF(210D, 51D);
			this.v_F3.Name = "v_F3";
			this.v_F3.Text = "\u2014";
			// 
			// c_F3
			// 
			this.c_F3.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.c_F3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.c_F3.Location = new NxtControl.Drawing.PointF(286D, 51D);
			this.c_F3.Name = "c_F3";
			this.c_F3.Text = "0";
			// 
			// r_F4
			// 
			this.r_F4.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_F4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_F4.Location = new NxtControl.Drawing.PointF(6D, 75D);
			this.r_F4.Name = "r_F4";
			this.r_F4.Text = "Falta de alimenta\u00e7\u00e3o";
			// 
			// v_F4
			// 
			this.v_F4.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_F4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_F4.Location = new NxtControl.Drawing.PointF(210D, 75D);
			this.v_F4.Name = "v_F4";
			this.v_F4.Text = "\u2014";
			// 
			// c_F4
			// 
			this.c_F4.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.c_F4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.c_F4.Location = new NxtControl.Drawing.PointF(286D, 75D);
			this.c_F4.Name = "c_F4";
			this.c_F4.Text = "0";
			// 
			// r_F5
			// 
			this.r_F5.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_F5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_F5.Location = new NxtControl.Drawing.PointF(6D, 99D);
			this.r_F5.Name = "r_F5";
			this.r_F5.Text = "TRIP";
			// 
			// v_F5
			// 
			this.v_F5.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_F5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_F5.Location = new NxtControl.Drawing.PointF(210D, 99D);
			this.v_F5.Name = "v_F5";
			this.v_F5.Text = "\u2014";
			// 
			// c_F5
			// 
			this.c_F5.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.c_F5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.c_F5.Location = new NxtControl.Drawing.PointF(286D, 99D);
			this.c_F5.Name = "c_F5";
			this.c_F5.Text = "0";
			// 
			// r_F6
			// 
			this.r_F6.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_F6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_F6.Location = new NxtControl.Drawing.PointF(6D, 123D);
			this.r_F6.Name = "r_F6";
			this.r_F6.Text = "Umidade na bomba (MS)";
			// 
			// v_F6
			// 
			this.v_F6.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_F6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_F6.Location = new NxtControl.Drawing.PointF(210D, 123D);
			this.v_F6.Name = "v_F6";
			this.v_F6.Text = "\u2014";
			// 
			// c_F6
			// 
			this.c_F6.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.c_F6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.c_F6.Location = new NxtControl.Drawing.PointF(286D, 123D);
			this.c_F6.Name = "c_F6";
			this.c_F6.Text = "0";
			// 
			// rxF1
			// 
			this.rxF1.BeginInit();
			this.rxF1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxF1.IsOnlyInput = true;
			this.rxF1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxF1.Name = "rxF1";
			this.rxF1.SecurityLevel = 0;
			this.rxF1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxF1.TagName = "Failure1";
			this.rxF1.Value = false;
			this.rxF1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxF1Changed);
			this.rxF1.EndInit();
			// 
			// rxC1
			// 
			this.rxC1.BeginInit();
			this.rxC1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxC1.IsOnlyInput = true;
			this.rxC1.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxC1.Name = "rxC1";
			this.rxC1.SecurityLevel = 0;
			this.rxC1.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxC1.TagName = "CountFailure1";
			this.rxC1.Value = ((ushort)(0));
			this.rxC1.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxC1Changed);
			this.rxC1.EndInit();
			// 
			// rxF2
			// 
			this.rxF2.BeginInit();
			this.rxF2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxF2.IsOnlyInput = true;
			this.rxF2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxF2.Name = "rxF2";
			this.rxF2.SecurityLevel = 0;
			this.rxF2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxF2.TagName = "Failure2";
			this.rxF2.Value = false;
			this.rxF2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxF2Changed);
			this.rxF2.EndInit();
			// 
			// rxC2
			// 
			this.rxC2.BeginInit();
			this.rxC2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxC2.IsOnlyInput = true;
			this.rxC2.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxC2.Name = "rxC2";
			this.rxC2.SecurityLevel = 0;
			this.rxC2.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxC2.TagName = "CountFailure2";
			this.rxC2.Value = ((ushort)(0));
			this.rxC2.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxC2Changed);
			this.rxC2.EndInit();
			// 
			// rxF3
			// 
			this.rxF3.BeginInit();
			this.rxF3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxF3.IsOnlyInput = true;
			this.rxF3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxF3.Name = "rxF3";
			this.rxF3.SecurityLevel = 0;
			this.rxF3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxF3.TagName = "Failure3";
			this.rxF3.Value = false;
			this.rxF3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxF3Changed);
			this.rxF3.EndInit();
			// 
			// rxC3
			// 
			this.rxC3.BeginInit();
			this.rxC3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxC3.IsOnlyInput = true;
			this.rxC3.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxC3.Name = "rxC3";
			this.rxC3.SecurityLevel = 0;
			this.rxC3.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxC3.TagName = "CountFailure3";
			this.rxC3.Value = ((ushort)(0));
			this.rxC3.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxC3Changed);
			this.rxC3.EndInit();
			// 
			// rxF4
			// 
			this.rxF4.BeginInit();
			this.rxF4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxF4.IsOnlyInput = true;
			this.rxF4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxF4.Name = "rxF4";
			this.rxF4.SecurityLevel = 0;
			this.rxF4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxF4.TagName = "Failure4";
			this.rxF4.Value = false;
			this.rxF4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxF4Changed);
			this.rxF4.EndInit();
			// 
			// rxC4
			// 
			this.rxC4.BeginInit();
			this.rxC4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxC4.IsOnlyInput = true;
			this.rxC4.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxC4.Name = "rxC4";
			this.rxC4.SecurityLevel = 0;
			this.rxC4.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxC4.TagName = "CountFailure4";
			this.rxC4.Value = ((ushort)(0));
			this.rxC4.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxC4Changed);
			this.rxC4.EndInit();
			// 
			// rxF5
			// 
			this.rxF5.BeginInit();
			this.rxF5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxF5.IsOnlyInput = true;
			this.rxF5.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxF5.Name = "rxF5";
			this.rxF5.SecurityLevel = 0;
			this.rxF5.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxF5.TagName = "Failure5";
			this.rxF5.Value = false;
			this.rxF5.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxF5Changed);
			this.rxF5.EndInit();
			// 
			// rxC5
			// 
			this.rxC5.BeginInit();
			this.rxC5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxC5.IsOnlyInput = true;
			this.rxC5.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxC5.Name = "rxC5";
			this.rxC5.SecurityLevel = 0;
			this.rxC5.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxC5.TagName = "CountFailure5";
			this.rxC5.Value = ((ushort)(0));
			this.rxC5.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxC5Changed);
			this.rxC5.EndInit();
			// 
			// rxF6
			// 
			this.rxF6.BeginInit();
			this.rxF6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxF6.IsOnlyInput = true;
			this.rxF6.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxF6.Name = "rxF6";
			this.rxF6.SecurityLevel = 0;
			this.rxF6.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxF6.TagName = "Failure6";
			this.rxF6.Value = false;
			this.rxF6.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxF6Changed);
			this.rxF6.EndInit();
			// 
			// rxC6
			// 
			this.rxC6.BeginInit();
			this.rxC6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxC6.IsOnlyInput = true;
			this.rxC6.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxC6.Name = "rxC6";
			this.rxC6.SecurityLevel = 0;
			this.rxC6.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxC6.TagName = "CountFailure6";
			this.rxC6.Value = ((ushort)(0));
			this.rxC6.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxC6Changed);
			this.rxC6.EndInit();
			// 
			// sDiagnostico
			// 
			this.Name = "sDiagnostico";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.r_F1,
			this.v_F1,
			this.c_F1,
			this.r_F2,
			this.v_F2,
			this.c_F2,
			this.r_F3,
			this.v_F3,
			this.c_F3,
			this.r_F4,
			this.v_F4,
			this.c_F4,
			this.r_F5,
			this.v_F5,
			this.c_F5,
			this.r_F6,
			this.v_F6,
			this.c_F6,
			this.rxF1,
			this.rxC1,
			this.rxF2,
			this.rxC2,
			this.rxF3,
			this.rxC3,
			this.rxF4,
			this.rxC4,
			this.rxF5,
			this.rxC5,
			this.rxF6,
			this.rxC6});
			this.SymbolSize = new System.Drawing.Size(330, 144);

		}
		private NxtControl.GuiFramework.FreeText r_F1;
		private NxtControl.GuiFramework.FreeText v_F1;
		private NxtControl.GuiFramework.FreeText c_F1;
		private NxtControl.GuiFramework.FreeText r_F2;
		private NxtControl.GuiFramework.FreeText v_F2;
		private NxtControl.GuiFramework.FreeText c_F2;
		private NxtControl.GuiFramework.FreeText r_F3;
		private NxtControl.GuiFramework.FreeText v_F3;
		private NxtControl.GuiFramework.FreeText c_F3;
		private NxtControl.GuiFramework.FreeText r_F4;
		private NxtControl.GuiFramework.FreeText v_F4;
		private NxtControl.GuiFramework.FreeText c_F4;
		private NxtControl.GuiFramework.FreeText r_F5;
		private NxtControl.GuiFramework.FreeText v_F5;
		private NxtControl.GuiFramework.FreeText c_F5;
		private NxtControl.GuiFramework.FreeText r_F6;
		private NxtControl.GuiFramework.FreeText v_F6;
		private NxtControl.GuiFramework.FreeText c_F6;
		private System.HMI.Symbols.Base.Execute<bool> rxF1;
		private System.HMI.Symbols.Base.Execute<ushort> rxC1;
		private System.HMI.Symbols.Base.Execute<bool> rxF2;
		private System.HMI.Symbols.Base.Execute<ushort> rxC2;
		private System.HMI.Symbols.Base.Execute<bool> rxF3;
		private System.HMI.Symbols.Base.Execute<ushort> rxC3;
		private System.HMI.Symbols.Base.Execute<bool> rxF4;
		private System.HMI.Symbols.Base.Execute<ushort> rxC4;
		private System.HMI.Symbols.Base.Execute<bool> rxF5;
		private System.HMI.Symbols.Base.Execute<ushort> rxC5;
		private System.HMI.Symbols.Base.Execute<bool> rxF6;
		private System.HMI.Symbols.Base.Execute<ushort> rxC6;

		#endregion
	}
}
