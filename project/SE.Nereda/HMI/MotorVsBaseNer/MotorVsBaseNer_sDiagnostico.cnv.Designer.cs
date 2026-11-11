/*
 * Criado pelo gerador fp_diag (padrao Hidryco).
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.MotorVsBaseNer
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
			this.r_Modo = new NxtControl.GuiFramework.FreeText();
			this.v_Modo = new NxtControl.GuiFramework.FreeText();
			this.r_Ilck = new NxtControl.GuiFramework.FreeText();
			this.v_Ilck = new NxtControl.GuiFramework.FreeText();
			this.r_PermLig = new NxtControl.GuiFramework.FreeText();
			this.v_PermLig = new NxtControl.GuiFramework.FreeText();
			this.r_PermPar = new NxtControl.GuiFramework.FreeText();
			this.v_PermPar = new NxtControl.GuiFramework.FreeText();
			this.r_Fail = new NxtControl.GuiFramework.FreeText();
			this.v_Fail = new NxtControl.GuiFramework.FreeText();
			this.r_Reset = new NxtControl.GuiFramework.FreeText();
			this.v_Reset = new NxtControl.GuiFramework.FreeText();
			this.r_Ext = new NxtControl.GuiFramework.FreeText();
			this.v_Ext = new NxtControl.GuiFramework.FreeText();
			this.r_Esp = new NxtControl.GuiFramework.FreeText();
			this.v_Esp = new NxtControl.GuiFramework.FreeText();
			this.rxOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.rxIlck = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxPermLig = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxPermPar = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxFail = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxExt = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxSim = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxOver = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxMaint = new System.HMI.Symbols.Base.Execute<bool>();
			this.rxOos = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// r_Modo
			// 
			this.r_Modo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Modo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Modo.Location = new NxtControl.Drawing.PointF(6D, 3D);
			this.r_Modo.Name = "r_Modo";
			this.r_Modo.Text = "Modo";
			// 
			// v_Modo
			// 
			this.v_Modo.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Modo.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Modo.Location = new NxtControl.Drawing.PointF(210D, 3D);
			this.v_Modo.Name = "v_Modo";
			this.v_Modo.Text = "\u2014";
			// 
			// r_Ilck
			// 
			this.r_Ilck.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Ilck.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Ilck.Location = new NxtControl.Drawing.PointF(6D, 27D);
			this.r_Ilck.Name = "r_Ilck";
			this.r_Ilck.Text = "Intertravamento";
			// 
			// v_Ilck
			// 
			this.v_Ilck.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Ilck.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Ilck.Location = new NxtControl.Drawing.PointF(210D, 27D);
			this.v_Ilck.Name = "v_Ilck";
			this.v_Ilck.Text = "\u2014";
			// 
			// r_PermLig
			// 
			this.r_PermLig.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_PermLig.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_PermLig.Location = new NxtControl.Drawing.PointF(6D, 51D);
			this.r_PermLig.Name = "r_PermLig";
			this.r_PermLig.Text = "Permissivo para ligar";
			// 
			// v_PermLig
			// 
			this.v_PermLig.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_PermLig.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_PermLig.Location = new NxtControl.Drawing.PointF(210D, 51D);
			this.v_PermLig.Name = "v_PermLig";
			this.v_PermLig.Text = "\u2014";
			// 
			// r_PermPar
			// 
			this.r_PermPar.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_PermPar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_PermPar.Location = new NxtControl.Drawing.PointF(6D, 75D);
			this.r_PermPar.Name = "r_PermPar";
			this.r_PermPar.Text = "Permissivo para parar";
			// 
			// v_PermPar
			// 
			this.v_PermPar.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_PermPar.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_PermPar.Location = new NxtControl.Drawing.PointF(210D, 75D);
			this.v_PermPar.Name = "v_PermPar";
			this.v_PermPar.Text = "\u2014";
			// 
			// r_Fail
			// 
			this.r_Fail.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Fail.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Fail.Location = new NxtControl.Drawing.PointF(6D, 99D);
			this.r_Fail.Name = "r_Fail";
			this.r_Fail.Text = "Falha ativa";
			// 
			// v_Fail
			// 
			this.v_Fail.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Fail.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Fail.Location = new NxtControl.Drawing.PointF(210D, 99D);
			this.v_Fail.Name = "v_Fail";
			this.v_Fail.Text = "\u2014";
			// 
			// r_Reset
			// 
			this.r_Reset.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Reset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Reset.Location = new NxtControl.Drawing.PointF(6D, 123D);
			this.r_Reset.Name = "r_Reset";
			this.r_Reset.Text = "Aguardando reset";
			// 
			// v_Reset
			// 
			this.v_Reset.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Reset.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Reset.Location = new NxtControl.Drawing.PointF(210D, 123D);
			this.v_Reset.Name = "v_Reset";
			this.v_Reset.Text = "\u2014";
			// 
			// r_Ext
			// 
			this.r_Ext.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Ext.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Ext.Location = new NxtControl.Drawing.PointF(6D, 147D);
			this.r_Ext.Name = "r_Ext";
			this.r_Ext.Text = "Comando externo";
			// 
			// v_Ext
			// 
			this.v_Ext.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Ext.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Ext.Location = new NxtControl.Drawing.PointF(210D, 147D);
			this.v_Ext.Name = "v_Ext";
			this.v_Ext.Text = "\u2014";
			// 
			// r_Esp
			// 
			this.r_Esp.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.r_Esp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.r_Esp.Location = new NxtControl.Drawing.PointF(6D, 171D);
			this.r_Esp.Name = "r_Esp";
			this.r_Esp.Text = "Modos especiais";
			// 
			// v_Esp
			// 
			this.v_Esp.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.v_Esp.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.v_Esp.Location = new NxtControl.Drawing.PointF(210D, 171D);
			this.v_Esp.Name = "v_Esp";
			this.v_Esp.Text = "\u2014";
			// 
			// rxOwner
			// 
			this.rxOwner.BeginInit();
			this.rxOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxOwner.IsOnlyInput = true;
			this.rxOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxOwner.Name = "rxOwner";
			this.rxOwner.SecurityLevel = 0;
			this.rxOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxOwner.TagName = "CurrentOwner";
			this.rxOwner.Value = ((ushort)(0));
			this.rxOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxOwnerChanged);
			this.rxOwner.EndInit();
			// 
			// rxIlck
			// 
			this.rxIlck.BeginInit();
			this.rxIlck.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxIlck.IsOnlyInput = true;
			this.rxIlck.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxIlck.Name = "rxIlck";
			this.rxIlck.SecurityLevel = 0;
			this.rxIlck.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxIlck.TagName = "IlckCond";
			this.rxIlck.Value = false;
			this.rxIlck.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxIlckChanged);
			this.rxIlck.EndInit();
			// 
			// rxPermLig
			// 
			this.rxPermLig.BeginInit();
			this.rxPermLig.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxPermLig.IsOnlyInput = true;
			this.rxPermLig.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxPermLig.Name = "rxPermLig";
			this.rxPermLig.SecurityLevel = 0;
			this.rxPermLig.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxPermLig.TagName = "PermFwd";
			this.rxPermLig.Value = false;
			this.rxPermLig.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxPermLigChanged);
			this.rxPermLig.EndInit();
			// 
			// rxPermPar
			// 
			this.rxPermPar.BeginInit();
			this.rxPermPar.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxPermPar.IsOnlyInput = true;
			this.rxPermPar.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxPermPar.Name = "rxPermPar";
			this.rxPermPar.SecurityLevel = 0;
			this.rxPermPar.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxPermPar.TagName = "PermStop";
			this.rxPermPar.Value = false;
			this.rxPermPar.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxPermParChanged);
			this.rxPermPar.EndInit();
			// 
			// rxFail
			// 
			this.rxFail.BeginInit();
			this.rxFail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxFail.IsOnlyInput = true;
			this.rxFail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxFail.Name = "rxFail";
			this.rxFail.SecurityLevel = 0;
			this.rxFail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxFail.TagName = "Fail";
			this.rxFail.Value = false;
			this.rxFail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxFailChanged);
			this.rxFail.EndInit();
			// 
			// rxReset
			// 
			this.rxReset.BeginInit();
			this.rxReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxReset.IsOnlyInput = true;
			this.rxReset.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxReset.Name = "rxReset";
			this.rxReset.SecurityLevel = 0;
			this.rxReset.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxReset.TagName = "NeedReset";
			this.rxReset.Value = false;
			this.rxReset.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxResetChanged);
			this.rxReset.EndInit();
			// 
			// rxExt
			// 
			this.rxExt.BeginInit();
			this.rxExt.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxExt.IsOnlyInput = true;
			this.rxExt.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxExt.Name = "rxExt";
			this.rxExt.SecurityLevel = 0;
			this.rxExt.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxExt.TagName = "ExternalControlled";
			this.rxExt.Value = false;
			this.rxExt.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxExtChanged);
			this.rxExt.EndInit();
			// 
			// rxSim
			// 
			this.rxSim.BeginInit();
			this.rxSim.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxSim.IsOnlyInput = true;
			this.rxSim.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxSim.Name = "rxSim";
			this.rxSim.SecurityLevel = 0;
			this.rxSim.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxSim.TagName = "Simulation";
			this.rxSim.Value = false;
			this.rxSim.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxSimChanged);
			this.rxSim.EndInit();
			// 
			// rxOver
			// 
			this.rxOver.BeginInit();
			this.rxOver.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxOver.IsOnlyInput = true;
			this.rxOver.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxOver.Name = "rxOver";
			this.rxOver.SecurityLevel = 0;
			this.rxOver.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxOver.TagName = "FbOverride";
			this.rxOver.Value = false;
			this.rxOver.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxOverChanged);
			this.rxOver.EndInit();
			// 
			// rxMaint
			// 
			this.rxMaint.BeginInit();
			this.rxMaint.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxMaint.IsOnlyInput = true;
			this.rxMaint.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxMaint.Name = "rxMaint";
			this.rxMaint.SecurityLevel = 0;
			this.rxMaint.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxMaint.TagName = "Maintenance";
			this.rxMaint.Value = false;
			this.rxMaint.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxMaintChanged);
			this.rxMaint.EndInit();
			// 
			// rxOos
			// 
			this.rxOos.BeginInit();
			this.rxOos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.rxOos.IsOnlyInput = true;
			this.rxOos.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.rxOos.Name = "rxOos";
			this.rxOos.SecurityLevel = 0;
			this.rxOos.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.rxOos.TagName = "OutOfService";
			this.rxOos.Value = false;
			this.rxOos.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.rxOosChanged);
			this.rxOos.EndInit();
			// 
			// sDiagnostico
			// 
			this.Name = "sDiagnostico";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.r_Modo,
			this.v_Modo,
			this.r_Ilck,
			this.v_Ilck,
			this.r_PermLig,
			this.v_PermLig,
			this.r_PermPar,
			this.v_PermPar,
			this.r_Fail,
			this.v_Fail,
			this.r_Reset,
			this.v_Reset,
			this.r_Ext,
			this.v_Ext,
			this.r_Esp,
			this.v_Esp,
			this.rxOwner,
			this.rxIlck,
			this.rxPermLig,
			this.rxPermPar,
			this.rxFail,
			this.rxReset,
			this.rxExt,
			this.rxSim,
			this.rxOver,
			this.rxMaint,
			this.rxOos});
			this.SymbolSize = new System.Drawing.Size(330, 192);

		}
		private NxtControl.GuiFramework.FreeText r_Modo;
		private NxtControl.GuiFramework.FreeText v_Modo;
		private NxtControl.GuiFramework.FreeText r_Ilck;
		private NxtControl.GuiFramework.FreeText v_Ilck;
		private NxtControl.GuiFramework.FreeText r_PermLig;
		private NxtControl.GuiFramework.FreeText v_PermLig;
		private NxtControl.GuiFramework.FreeText r_PermPar;
		private NxtControl.GuiFramework.FreeText v_PermPar;
		private NxtControl.GuiFramework.FreeText r_Fail;
		private NxtControl.GuiFramework.FreeText v_Fail;
		private NxtControl.GuiFramework.FreeText r_Reset;
		private NxtControl.GuiFramework.FreeText v_Reset;
		private NxtControl.GuiFramework.FreeText r_Ext;
		private NxtControl.GuiFramework.FreeText v_Ext;
		private NxtControl.GuiFramework.FreeText r_Esp;
		private NxtControl.GuiFramework.FreeText v_Esp;
		private System.HMI.Symbols.Base.Execute<ushort> rxOwner;
		private System.HMI.Symbols.Base.Execute<bool> rxIlck;
		private System.HMI.Symbols.Base.Execute<bool> rxPermLig;
		private System.HMI.Symbols.Base.Execute<bool> rxPermPar;
		private System.HMI.Symbols.Base.Execute<bool> rxFail;
		private System.HMI.Symbols.Base.Execute<bool> rxReset;
		private System.HMI.Symbols.Base.Execute<bool> rxExt;
		private System.HMI.Symbols.Base.Execute<bool> rxSim;
		private System.HMI.Symbols.Base.Execute<bool> rxOver;
		private System.HMI.Symbols.Base.Execute<bool> rxMaint;
		private System.HMI.Symbols.Base.Execute<bool> rxOos;

		#endregion
	}
}
