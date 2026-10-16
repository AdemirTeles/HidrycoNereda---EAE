/*
 * Hidryco - Motor_Generico - fpDiagnostic
 * ISA-101: estados em texto (sim/nao) e falhas com indicador de prioridade 1; linhas que nao se aplicam ao motor somem.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Motor_Generico
{
	/// <summary>
	/// Summary description for fpDiagnostic.
	/// </summary>
	partial class fpDiagnostic
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary8 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary9 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary7 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary11 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary12 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary10 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary14 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary15 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary13 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary17 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary18 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary16 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary20 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary21 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary19 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary22 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary23 = new NxtControl.GuiFramework.PropertyDictionary();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.tituloEst = new NxtControl.GuiFramework.FreeText();
			this.eSTS_REMOTO = new NxtControl.GuiFramework.FreeText();
			this.vSTS_REMOTO = new System.HMI.Symbols.Base.FreeText<bool>();
			this.eSTS_LOCAL = new NxtControl.GuiFramework.FreeText();
			this.vSTS_LOCAL = new System.HMI.Symbols.Base.FreeText<bool>();
			this.eSTS_MANUTENCAO = new NxtControl.GuiFramework.FreeText();
			this.vSTS_MANUTENCAO = new System.HMI.Symbols.Base.FreeText<bool>();
			this.efbkStsAutomatico = new NxtControl.GuiFramework.FreeText();
			this.vfbkStsAutomatico = new System.HMI.Symbols.Base.FreeText<bool>();
			this.eSTS_DISPONIVEL_AUTOMATICO = new NxtControl.GuiFramework.FreeText();
			this.vSTS_DISPONIVEL_AUTOMATICO = new System.HMI.Symbols.Base.FreeText<bool>();
			this.eSTS_BLOQUEADO = new NxtControl.GuiFramework.FreeText();
			this.vSTS_BLOQUEADO = new System.HMI.Symbols.Base.FreeText<bool>();
			this.eSTS_BLOQUEIO_GERADOR = new NxtControl.GuiFramework.FreeText();
			this.vSTS_BLOQUEIO_GERADOR = new System.HMI.Symbols.Base.FreeText<bool>();
			this.tituloFal = new NxtControl.GuiFramework.FreeText();
			this.rEmerg = new NxtControl.GuiFramework.FreeText();
			this.nEmerg = new NxtControl.GuiFramework.FreeText();
			this.iEmergP1 = new NxtControl.GuiFramework.Rectangle();
			this.iEmergP1n = new NxtControl.GuiFramework.FreeText();
			this.iEmergP2 = new NxtControl.GuiFramework.Polygon();
			this.iEmergP2n = new NxtControl.GuiFramework.FreeText();
			this.iEmergTxt = new NxtControl.GuiFramework.FreeText();
			this.rTerm = new NxtControl.GuiFramework.FreeText();
			this.nTerm = new NxtControl.GuiFramework.FreeText();
			this.iTermP1 = new NxtControl.GuiFramework.Rectangle();
			this.iTermP1n = new NxtControl.GuiFramework.FreeText();
			this.iTermP2 = new NxtControl.GuiFramework.Polygon();
			this.iTermP2n = new NxtControl.GuiFramework.FreeText();
			this.iTermTxt = new NxtControl.GuiFramework.FreeText();
			this.rInv = new NxtControl.GuiFramework.FreeText();
			this.nInv = new NxtControl.GuiFramework.FreeText();
			this.iInvP1 = new NxtControl.GuiFramework.Rectangle();
			this.iInvP1n = new NxtControl.GuiFramework.FreeText();
			this.iInvP2 = new NxtControl.GuiFramework.Polygon();
			this.iInvP2n = new NxtControl.GuiFramework.FreeText();
			this.iInvTxt = new NxtControl.GuiFramework.FreeText();
			this.rPart = new NxtControl.GuiFramework.FreeText();
			this.nPart = new NxtControl.GuiFramework.FreeText();
			this.iPartP1 = new NxtControl.GuiFramework.Rectangle();
			this.iPartP1n = new NxtControl.GuiFramework.FreeText();
			this.iPartP2 = new NxtControl.GuiFramework.Polygon();
			this.iPartP2n = new NxtControl.GuiFramework.FreeText();
			this.iPartTxt = new NxtControl.GuiFramework.FreeText();
			this.rPara = new NxtControl.GuiFramework.FreeText();
			this.nPara = new NxtControl.GuiFramework.FreeText();
			this.iParaP1 = new NxtControl.GuiFramework.Rectangle();
			this.iParaP1n = new NxtControl.GuiFramework.FreeText();
			this.iParaP2 = new NxtControl.GuiFramework.Polygon();
			this.iParaP2n = new NxtControl.GuiFramework.FreeText();
			this.iParaTxt = new NxtControl.GuiFramework.FreeText();
			this.rCom = new NxtControl.GuiFramework.FreeText();
			this.nCom = new NxtControl.GuiFramework.FreeText();
			this.iComP1 = new NxtControl.GuiFramework.Rectangle();
			this.iComP1n = new NxtControl.GuiFramework.FreeText();
			this.iComP2 = new NxtControl.GuiFramework.Polygon();
			this.iComP2n = new NxtControl.GuiFramework.FreeText();
			this.iComTxt = new NxtControl.GuiFramework.FreeText();
			this.tVelRef = new NxtControl.GuiFramework.FreeText();
			this.vVelRef = new System.HMI.Symbols.Base.Label<float>();
			this.tVel = new NxtControl.GuiFramework.FreeText();
			this.vVel = new System.HMI.Symbols.Base.Label<float>();
			this.xLigado = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAuto = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCmdManual = new System.HMI.Symbols.Base.Execute<bool>();
			this.xRemoto = new System.HMI.Symbols.Base.Execute<bool>();
			this.xLocal = new System.HMI.Symbols.Base.Execute<bool>();
			this.xManut = new System.HMI.Symbols.Base.Execute<bool>();
			this.xDisp = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBloq = new System.HMI.Symbols.Base.Execute<bool>();
			this.xBloqGer = new System.HMI.Symbols.Base.Execute<bool>();
			this.xInversor = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAnimGer = new System.HMI.Symbols.Base.Execute<short>();
			this.xVel = new System.HMI.Symbols.Base.Execute<float>();
			this.xRef = new System.HMI.Symbols.Base.Execute<float>();
			this.xEmerg = new System.HMI.Symbols.Base.Execute<bool>();
			this.xTerm = new System.HMI.Symbols.Base.Execute<bool>();
			this.xInv = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPart = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPara = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCom = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEEmerg = new System.HMI.Symbols.Base.Execute<byte>();
			this.xETerm = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEInv = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPart = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPara = new System.HMI.Symbols.Base.Execute<byte>();
			this.xECom = new System.HMI.Symbols.Base.Execute<byte>();
			this.xUsaTermica = new System.HMI.Symbols.Base.Execute<bool>();
			this.xUsaCom = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 12D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Diagnóstico";
			// 
			// tituloEst
			// 
			this.tituloEst.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloEst.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloEst.Location = new NxtControl.Drawing.PointF(20D, 44D);
			this.tituloEst.Name = "tituloEst";
			this.tituloEst.Text = "Estados";
			// 
			// eSTS_REMOTO
			// 
			this.eSTS_REMOTO.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.eSTS_REMOTO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.eSTS_REMOTO.Location = new NxtControl.Drawing.PointF(24D, 66D);
			this.eSTS_REMOTO.Name = "eSTS_REMOTO";
			this.eSTS_REMOTO.Text = "Remoto";
			// 
			// vSTS_REMOTO
			// 
			this.vSTS_REMOTO.BeginInit();
			this.vSTS_REMOTO.DecimalPlacesCount = ((uint)(2u));
			this.vSTS_REMOTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 66D);
			this.vSTS_REMOTO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vSTS_REMOTO.IsOnlyInput = true;
			this.vSTS_REMOTO.Name = "vSTS_REMOTO";
			propertyDictionary2.Add("Text", "não");
			propertyDictionary2.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary3.Add("Text", "SIM");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vSTS_REMOTO.Ranges.Clear();
			this.vSTS_REMOTO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.vSTS_REMOTO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Text", "-");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vSTS_REMOTO.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.vSTS_REMOTO.TagName = "STS_REMOTO";
			this.vSTS_REMOTO.TextAngle = 0F;
			this.vSTS_REMOTO.EndInit();
			// 
			// eSTS_LOCAL
			// 
			this.eSTS_LOCAL.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.eSTS_LOCAL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.eSTS_LOCAL.Location = new NxtControl.Drawing.PointF(24D, 90D);
			this.eSTS_LOCAL.Name = "eSTS_LOCAL";
			this.eSTS_LOCAL.Text = "Local";
			// 
			// vSTS_LOCAL
			// 
			this.vSTS_LOCAL.BeginInit();
			this.vSTS_LOCAL.DecimalPlacesCount = ((uint)(2u));
			this.vSTS_LOCAL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 90D);
			this.vSTS_LOCAL.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vSTS_LOCAL.IsOnlyInput = true;
			this.vSTS_LOCAL.Name = "vSTS_LOCAL";
			propertyDictionary5.Add("Text", "não");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary6.Add("Text", "SIM");
			propertyDictionary6.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vSTS_LOCAL.Ranges.Clear();
			this.vSTS_LOCAL.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary5));
			this.vSTS_LOCAL.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary6));
			propertyDictionary4.Add("Text", "-");
			propertyDictionary4.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vSTS_LOCAL.Ranges.DefaultPropertyValues = propertyDictionary4;
			this.vSTS_LOCAL.TagName = "STS_LOCAL";
			this.vSTS_LOCAL.TextAngle = 0F;
			this.vSTS_LOCAL.EndInit();
			// 
			// eSTS_MANUTENCAO
			// 
			this.eSTS_MANUTENCAO.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.eSTS_MANUTENCAO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.eSTS_MANUTENCAO.Location = new NxtControl.Drawing.PointF(24D, 114D);
			this.eSTS_MANUTENCAO.Name = "eSTS_MANUTENCAO";
			this.eSTS_MANUTENCAO.Text = "Manutenção (0)";
			// 
			// vSTS_MANUTENCAO
			// 
			this.vSTS_MANUTENCAO.BeginInit();
			this.vSTS_MANUTENCAO.DecimalPlacesCount = ((uint)(2u));
			this.vSTS_MANUTENCAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 114D);
			this.vSTS_MANUTENCAO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vSTS_MANUTENCAO.IsOnlyInput = true;
			this.vSTS_MANUTENCAO.Name = "vSTS_MANUTENCAO";
			propertyDictionary8.Add("Text", "não");
			propertyDictionary8.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary9.Add("Text", "SIM");
			propertyDictionary9.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vSTS_MANUTENCAO.Ranges.Clear();
			this.vSTS_MANUTENCAO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary8));
			this.vSTS_MANUTENCAO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary9));
			propertyDictionary7.Add("Text", "-");
			propertyDictionary7.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vSTS_MANUTENCAO.Ranges.DefaultPropertyValues = propertyDictionary7;
			this.vSTS_MANUTENCAO.TagName = "STS_MANUTENCAO";
			this.vSTS_MANUTENCAO.TextAngle = 0F;
			this.vSTS_MANUTENCAO.EndInit();
			// 
			// efbkStsAutomatico
			// 
			this.efbkStsAutomatico.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.efbkStsAutomatico.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.efbkStsAutomatico.Location = new NxtControl.Drawing.PointF(24D, 138D);
			this.efbkStsAutomatico.Name = "efbkStsAutomatico";
			this.efbkStsAutomatico.Text = "Automático";
			// 
			// vfbkStsAutomatico
			// 
			this.vfbkStsAutomatico.BeginInit();
			this.vfbkStsAutomatico.DecimalPlacesCount = ((uint)(2u));
			this.vfbkStsAutomatico.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 138D);
			this.vfbkStsAutomatico.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vfbkStsAutomatico.IsOnlyInput = true;
			this.vfbkStsAutomatico.Name = "vfbkStsAutomatico";
			propertyDictionary11.Add("Text", "não");
			propertyDictionary11.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary12.Add("Text", "SIM");
			propertyDictionary12.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vfbkStsAutomatico.Ranges.Clear();
			this.vfbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary11));
			this.vfbkStsAutomatico.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary12));
			propertyDictionary10.Add("Text", "-");
			propertyDictionary10.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vfbkStsAutomatico.Ranges.DefaultPropertyValues = propertyDictionary10;
			this.vfbkStsAutomatico.TagName = "fbkStsAutomatico";
			this.vfbkStsAutomatico.TextAngle = 0F;
			this.vfbkStsAutomatico.EndInit();
			// 
			// eSTS_DISPONIVEL_AUTOMATICO
			// 
			this.eSTS_DISPONIVEL_AUTOMATICO.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.eSTS_DISPONIVEL_AUTOMATICO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.eSTS_DISPONIVEL_AUTOMATICO.Location = new NxtControl.Drawing.PointF(24D, 162D);
			this.eSTS_DISPONIVEL_AUTOMATICO.Name = "eSTS_DISPONIVEL_AUTOMATICO";
			this.eSTS_DISPONIVEL_AUTOMATICO.Text = "Disponível automático";
			// 
			// vSTS_DISPONIVEL_AUTOMATICO
			// 
			this.vSTS_DISPONIVEL_AUTOMATICO.BeginInit();
			this.vSTS_DISPONIVEL_AUTOMATICO.DecimalPlacesCount = ((uint)(2u));
			this.vSTS_DISPONIVEL_AUTOMATICO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 162D);
			this.vSTS_DISPONIVEL_AUTOMATICO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vSTS_DISPONIVEL_AUTOMATICO.IsOnlyInput = true;
			this.vSTS_DISPONIVEL_AUTOMATICO.Name = "vSTS_DISPONIVEL_AUTOMATICO";
			propertyDictionary14.Add("Text", "não");
			propertyDictionary14.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary15.Add("Text", "SIM");
			propertyDictionary15.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vSTS_DISPONIVEL_AUTOMATICO.Ranges.Clear();
			this.vSTS_DISPONIVEL_AUTOMATICO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary14));
			this.vSTS_DISPONIVEL_AUTOMATICO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary15));
			propertyDictionary13.Add("Text", "-");
			propertyDictionary13.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vSTS_DISPONIVEL_AUTOMATICO.Ranges.DefaultPropertyValues = propertyDictionary13;
			this.vSTS_DISPONIVEL_AUTOMATICO.TagName = "STS_DISPONIVEL_AUTOMATICO";
			this.vSTS_DISPONIVEL_AUTOMATICO.TextAngle = 0F;
			this.vSTS_DISPONIVEL_AUTOMATICO.EndInit();
			// 
			// eSTS_BLOQUEADO
			// 
			this.eSTS_BLOQUEADO.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.eSTS_BLOQUEADO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.eSTS_BLOQUEADO.Location = new NxtControl.Drawing.PointF(24D, 186D);
			this.eSTS_BLOQUEADO.Name = "eSTS_BLOQUEADO";
			this.eSTS_BLOQUEADO.Text = "Intertravado";
			// 
			// vSTS_BLOQUEADO
			// 
			this.vSTS_BLOQUEADO.BeginInit();
			this.vSTS_BLOQUEADO.DecimalPlacesCount = ((uint)(2u));
			this.vSTS_BLOQUEADO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 186D);
			this.vSTS_BLOQUEADO.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vSTS_BLOQUEADO.IsOnlyInput = true;
			this.vSTS_BLOQUEADO.Name = "vSTS_BLOQUEADO";
			propertyDictionary17.Add("Text", "não");
			propertyDictionary17.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary18.Add("Text", "SIM");
			propertyDictionary18.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vSTS_BLOQUEADO.Ranges.Clear();
			this.vSTS_BLOQUEADO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary17));
			this.vSTS_BLOQUEADO.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary18));
			propertyDictionary16.Add("Text", "-");
			propertyDictionary16.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vSTS_BLOQUEADO.Ranges.DefaultPropertyValues = propertyDictionary16;
			this.vSTS_BLOQUEADO.TagName = "STS_BLOQUEADO";
			this.vSTS_BLOQUEADO.TextAngle = 0F;
			this.vSTS_BLOQUEADO.EndInit();
			// 
			// eSTS_BLOQUEIO_GERADOR
			// 
			this.eSTS_BLOQUEIO_GERADOR.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.eSTS_BLOQUEIO_GERADOR.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.eSTS_BLOQUEIO_GERADOR.Location = new NxtControl.Drawing.PointF(24D, 210D);
			this.eSTS_BLOQUEIO_GERADOR.Name = "eSTS_BLOQUEIO_GERADOR";
			this.eSTS_BLOQUEIO_GERADOR.Text = "Bloqueio gerador";
			// 
			// vSTS_BLOQUEIO_GERADOR
			// 
			this.vSTS_BLOQUEIO_GERADOR.BeginInit();
			this.vSTS_BLOQUEIO_GERADOR.DecimalPlacesCount = ((uint)(2u));
			this.vSTS_BLOQUEIO_GERADOR.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 240D, 210D);
			this.vSTS_BLOQUEIO_GERADOR.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vSTS_BLOQUEIO_GERADOR.IsOnlyInput = true;
			this.vSTS_BLOQUEIO_GERADOR.Name = "vSTS_BLOQUEIO_GERADOR";
			propertyDictionary20.Add("Text", "não");
			propertyDictionary20.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			propertyDictionary21.Add("Text", "SIM");
			propertyDictionary21.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			this.vSTS_BLOQUEIO_GERADOR.Ranges.Clear();
			this.vSTS_BLOQUEIO_GERADOR.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary20));
			this.vSTS_BLOQUEIO_GERADOR.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary21));
			propertyDictionary19.Add("Text", "-");
			propertyDictionary19.Add("TextColor", new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110))));
			this.vSTS_BLOQUEIO_GERADOR.Ranges.DefaultPropertyValues = propertyDictionary19;
			this.vSTS_BLOQUEIO_GERADOR.TagName = "STS_BLOQUEIO_GERADOR";
			this.vSTS_BLOQUEIO_GERADOR.TextAngle = 0F;
			this.vSTS_BLOQUEIO_GERADOR.EndInit();
			// 
			// tituloFal
			// 
			this.tituloFal.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.tituloFal.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tituloFal.Location = new NxtControl.Drawing.PointF(20D, 242D);
			this.tituloFal.Name = "tituloFal";
			this.tituloFal.Text = "Falhas (reconhecer / reset)";
			// 
			// rEmerg
			// 
			this.rEmerg.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rEmerg.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rEmerg.Location = new NxtControl.Drawing.PointF(24D, 264D);
			this.rEmerg.Name = "rEmerg";
			this.rEmerg.Text = "Emergência";
			// 
			// nEmerg
			// 
			this.nEmerg.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nEmerg.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nEmerg.Location = new NxtControl.Drawing.PointF(244D, 264D);
			this.nEmerg.Name = "nEmerg";
			this.nEmerg.Text = "—";
			// 
			// iEmergP1
			// 
			this.iEmergP1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(264D)), ((float)(16D)), ((float)(16D)));
			this.iEmergP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iEmergP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iEmergP1.Name = "iEmergP1";
			this.iEmergP1.Visible = false;
			// 
			// iEmergP1n
			// 
			this.iEmergP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iEmergP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iEmergP1n.Location = new NxtControl.Drawing.PointF(244D, 265D);
			this.iEmergP1n.Name = "iEmergP1n";
			this.iEmergP1n.Text = "1";
			this.iEmergP1n.Visible = false;
			// 
			// iEmergP2
			// 
			this.iEmergP2.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(264D)), ((float)(16D)), ((float)(16D)));
			this.iEmergP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iEmergP2.Closed = true;
			this.iEmergP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iEmergP2.Name = "iEmergP2";
			this.iEmergP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 280D),
			new NxtControl.Drawing.PointF(248D, 264D),
			new NxtControl.Drawing.PointF(256D, 280D)});
			this.iEmergP2.Visible = false;
			// 
			// iEmergP2n
			// 
			this.iEmergP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iEmergP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iEmergP2n.Location = new NxtControl.Drawing.PointF(245D, 268D);
			this.iEmergP2n.Name = "iEmergP2n";
			this.iEmergP2n.Text = "2";
			this.iEmergP2n.Visible = false;
			// 
			// iEmergTxt
			// 
			this.iEmergTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iEmergTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iEmergTxt.Location = new NxtControl.Drawing.PointF(260D, 264D);
			this.iEmergTxt.Name = "iEmergTxt";
			this.iEmergTxt.Visible = false;
			// 
			// rTerm
			// 
			this.rTerm.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rTerm.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rTerm.Location = new NxtControl.Drawing.PointF(24D, 290D);
			this.rTerm.Name = "rTerm";
			this.rTerm.Text = "Proteção térmica";
			// 
			// nTerm
			// 
			this.nTerm.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nTerm.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nTerm.Location = new NxtControl.Drawing.PointF(244D, 290D);
			this.nTerm.Name = "nTerm";
			this.nTerm.Text = "—";
			// 
			// iTermP1
			// 
			this.iTermP1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(290D)), ((float)(16D)), ((float)(16D)));
			this.iTermP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iTermP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iTermP1.Name = "iTermP1";
			this.iTermP1.Visible = false;
			// 
			// iTermP1n
			// 
			this.iTermP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iTermP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iTermP1n.Location = new NxtControl.Drawing.PointF(244D, 291D);
			this.iTermP1n.Name = "iTermP1n";
			this.iTermP1n.Text = "1";
			this.iTermP1n.Visible = false;
			// 
			// iTermP2
			// 
			this.iTermP2.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(290D)), ((float)(16D)), ((float)(16D)));
			this.iTermP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iTermP2.Closed = true;
			this.iTermP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iTermP2.Name = "iTermP2";
			this.iTermP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 306D),
			new NxtControl.Drawing.PointF(248D, 290D),
			new NxtControl.Drawing.PointF(256D, 306D)});
			this.iTermP2.Visible = false;
			// 
			// iTermP2n
			// 
			this.iTermP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iTermP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iTermP2n.Location = new NxtControl.Drawing.PointF(245D, 294D);
			this.iTermP2n.Name = "iTermP2n";
			this.iTermP2n.Text = "2";
			this.iTermP2n.Visible = false;
			// 
			// iTermTxt
			// 
			this.iTermTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iTermTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iTermTxt.Location = new NxtControl.Drawing.PointF(260D, 290D);
			this.iTermTxt.Name = "iTermTxt";
			this.iTermTxt.Visible = false;
			// 
			// rInv
			// 
			this.rInv.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rInv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rInv.Location = new NxtControl.Drawing.PointF(24D, 316D);
			this.rInv.Name = "rInv";
			this.rInv.Text = "Falha acionamento";
			// 
			// nInv
			// 
			this.nInv.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nInv.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nInv.Location = new NxtControl.Drawing.PointF(244D, 316D);
			this.nInv.Name = "nInv";
			this.nInv.Text = "—";
			// 
			// iInvP1
			// 
			this.iInvP1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(316D)), ((float)(16D)), ((float)(16D)));
			this.iInvP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iInvP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iInvP1.Name = "iInvP1";
			this.iInvP1.Visible = false;
			// 
			// iInvP1n
			// 
			this.iInvP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iInvP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iInvP1n.Location = new NxtControl.Drawing.PointF(244D, 317D);
			this.iInvP1n.Name = "iInvP1n";
			this.iInvP1n.Text = "1";
			this.iInvP1n.Visible = false;
			// 
			// iInvP2
			// 
			this.iInvP2.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(316D)), ((float)(16D)), ((float)(16D)));
			this.iInvP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iInvP2.Closed = true;
			this.iInvP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iInvP2.Name = "iInvP2";
			this.iInvP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 332D),
			new NxtControl.Drawing.PointF(248D, 316D),
			new NxtControl.Drawing.PointF(256D, 332D)});
			this.iInvP2.Visible = false;
			// 
			// iInvP2n
			// 
			this.iInvP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iInvP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iInvP2n.Location = new NxtControl.Drawing.PointF(245D, 320D);
			this.iInvP2n.Name = "iInvP2n";
			this.iInvP2n.Text = "2";
			this.iInvP2n.Visible = false;
			// 
			// iInvTxt
			// 
			this.iInvTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iInvTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iInvTxt.Location = new NxtControl.Drawing.PointF(260D, 316D);
			this.iInvTxt.Name = "iInvTxt";
			this.iInvTxt.Visible = false;
			// 
			// rPart
			// 
			this.rPart.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rPart.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rPart.Location = new NxtControl.Drawing.PointF(24D, 342D);
			this.rPart.Name = "rPart";
			this.rPart.Text = "Falha de partida";
			// 
			// nPart
			// 
			this.nPart.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nPart.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nPart.Location = new NxtControl.Drawing.PointF(244D, 342D);
			this.nPart.Name = "nPart";
			this.nPart.Text = "—";
			// 
			// iPartP1
			// 
			this.iPartP1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(342D)), ((float)(16D)), ((float)(16D)));
			this.iPartP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iPartP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iPartP1.Name = "iPartP1";
			this.iPartP1.Visible = false;
			// 
			// iPartP1n
			// 
			this.iPartP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iPartP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iPartP1n.Location = new NxtControl.Drawing.PointF(244D, 343D);
			this.iPartP1n.Name = "iPartP1n";
			this.iPartP1n.Text = "1";
			this.iPartP1n.Visible = false;
			// 
			// iPartP2
			// 
			this.iPartP2.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(342D)), ((float)(16D)), ((float)(16D)));
			this.iPartP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iPartP2.Closed = true;
			this.iPartP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iPartP2.Name = "iPartP2";
			this.iPartP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 358D),
			new NxtControl.Drawing.PointF(248D, 342D),
			new NxtControl.Drawing.PointF(256D, 358D)});
			this.iPartP2.Visible = false;
			// 
			// iPartP2n
			// 
			this.iPartP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iPartP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iPartP2n.Location = new NxtControl.Drawing.PointF(245D, 346D);
			this.iPartP2n.Name = "iPartP2n";
			this.iPartP2n.Text = "2";
			this.iPartP2n.Visible = false;
			// 
			// iPartTxt
			// 
			this.iPartTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iPartTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iPartTxt.Location = new NxtControl.Drawing.PointF(260D, 342D);
			this.iPartTxt.Name = "iPartTxt";
			this.iPartTxt.Visible = false;
			// 
			// rPara
			// 
			this.rPara.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rPara.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rPara.Location = new NxtControl.Drawing.PointF(24D, 368D);
			this.rPara.Name = "rPara";
			this.rPara.Text = "Falha de parada";
			// 
			// nPara
			// 
			this.nPara.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nPara.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nPara.Location = new NxtControl.Drawing.PointF(244D, 368D);
			this.nPara.Name = "nPara";
			this.nPara.Text = "—";
			// 
			// iParaP1
			// 
			this.iParaP1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(368D)), ((float)(16D)), ((float)(16D)));
			this.iParaP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iParaP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iParaP1.Name = "iParaP1";
			this.iParaP1.Visible = false;
			// 
			// iParaP1n
			// 
			this.iParaP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iParaP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iParaP1n.Location = new NxtControl.Drawing.PointF(244D, 369D);
			this.iParaP1n.Name = "iParaP1n";
			this.iParaP1n.Text = "1";
			this.iParaP1n.Visible = false;
			// 
			// iParaP2
			// 
			this.iParaP2.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(368D)), ((float)(16D)), ((float)(16D)));
			this.iParaP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iParaP2.Closed = true;
			this.iParaP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iParaP2.Name = "iParaP2";
			this.iParaP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 384D),
			new NxtControl.Drawing.PointF(248D, 368D),
			new NxtControl.Drawing.PointF(256D, 384D)});
			this.iParaP2.Visible = false;
			// 
			// iParaP2n
			// 
			this.iParaP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iParaP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iParaP2n.Location = new NxtControl.Drawing.PointF(245D, 372D);
			this.iParaP2n.Name = "iParaP2n";
			this.iParaP2n.Text = "2";
			this.iParaP2n.Visible = false;
			// 
			// iParaTxt
			// 
			this.iParaTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iParaTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iParaTxt.Location = new NxtControl.Drawing.PointF(260D, 368D);
			this.iParaTxt.Name = "iParaTxt";
			this.iParaTxt.Visible = false;
			// 
			// rCom
			// 
			this.rCom.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.rCom.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.rCom.Location = new NxtControl.Drawing.PointF(24D, 394D);
			this.rCom.Name = "rCom";
			this.rCom.Text = "Falha comunicação";
			// 
			// nCom
			// 
			this.nCom.Color = new NxtControl.Drawing.Color(((byte)(110)), ((byte)(110)), ((byte)(110)));
			this.nCom.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.nCom.Location = new NxtControl.Drawing.PointF(244D, 394D);
			this.nCom.Name = "nCom";
			this.nCom.Text = "—";
			// 
			// iComP1
			// 
			this.iComP1.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(394D)), ((float)(16D)), ((float)(16D)));
			this.iComP1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(0)), ((byte)(0))));
			this.iComP1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iComP1.Name = "iComP1";
			this.iComP1.Visible = false;
			// 
			// iComP1n
			// 
			this.iComP1n.Color = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255)));
			this.iComP1n.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.iComP1n.Location = new NxtControl.Drawing.PointF(244D, 395D);
			this.iComP1n.Name = "iComP1n";
			this.iComP1n.Text = "1";
			this.iComP1n.Visible = false;
			// 
			// iComP2
			// 
			this.iComP2.Bounds = new NxtControl.Drawing.RectF(((float)(240D)), ((float)(394D)), ((float)(16D)), ((float)(16D)));
			this.iComP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.iComP2.Closed = true;
			this.iComP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iComP2.Name = "iComP2";
			this.iComP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(240D, 410D),
			new NxtControl.Drawing.PointF(248D, 394D),
			new NxtControl.Drawing.PointF(256D, 410D)});
			this.iComP2.Visible = false;
			// 
			// iComP2n
			// 
			this.iComP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iComP2n.Font = new NxtControl.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Bold);
			this.iComP2n.Location = new NxtControl.Drawing.PointF(245D, 398D);
			this.iComP2n.Name = "iComP2n";
			this.iComP2n.Text = "2";
			this.iComP2n.Visible = false;
			// 
			// iComTxt
			// 
			this.iComTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.iComTxt.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.iComTxt.Location = new NxtControl.Drawing.PointF(260D, 394D);
			this.iComTxt.Name = "iComTxt";
			this.iComTxt.Visible = false;
			// 
			// tVelRef
			// 
			this.tVelRef.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tVelRef.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tVelRef.Location = new NxtControl.Drawing.PointF(24D, 428D);
			this.tVelRef.Name = "tVelRef";
			this.tVelRef.Text = "Velocidade referência";
			this.tVelRef.Visible = false;
			// 
			// vVelRef
			// 
			this.vVelRef.BeginInit();
			this.vVelRef.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vVelRef.DecimalPlacesCount = ((uint)(1u));
			this.vVelRef.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4637D, 0D, 0D, 1D, 220D, 424D);
			this.vVelRef.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vVelRef.FontScale = false;
			this.vVelRef.IsOnlyInput = true;
			this.vVelRef.IsPrefixSuffixOutside = false;
			this.vVelRef.LeadingZeros = ((uint)(0u));
			this.vVelRef.Name = "vVelRef";
			this.vVelRef.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary22.Add("Text", "${Value}");
			propertyDictionary22.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary22.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary22.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vVelRef.Ranges.DefaultPropertyValues = propertyDictionary22;
			this.vVelRef.Suffix = " %";
			this.vVelRef.TagName = "STS_VELOCIDADE_REFERENCIA";
			this.vVelRef.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vVelRef.Visible = false;
			this.vVelRef.EndInit();
			// 
			// tVel
			// 
			this.tVel.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.tVel.Location = new NxtControl.Drawing.PointF(24D, 454D);
			this.tVel.Name = "tVel";
			this.tVel.Text = "Velocidade real";
			this.tVel.Visible = false;
			// 
			// vVel
			// 
			this.vVel.BeginInit();
			this.vVel.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.vVel.DecimalPlacesCount = ((uint)(1u));
			this.vVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.4637D, 0D, 0D, 1D, 220D, 450D);
			this.vVel.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.vVel.FontScale = false;
			this.vVel.IsOnlyInput = true;
			this.vVel.IsPrefixSuffixOutside = false;
			this.vVel.LeadingZeros = ((uint)(0u));
			this.vVel.Name = "vVel";
			this.vVel.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary23.Add("Text", "${Value}");
			propertyDictionary23.Add("TextColor", new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))));
			propertyDictionary23.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary23.Add("Pen", new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid));
			this.vVel.Ranges.DefaultPropertyValues = propertyDictionary23;
			this.vVel.Suffix = " %";
			this.vVel.TagName = "STS_VELOCIDADE";
			this.vVel.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.vVel.Visible = false;
			this.vVel.EndInit();
			// 
			// xLigado
			// 
			this.xLigado.BeginInit();
			this.xLigado.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLigado.IsOnlyInput = true;
			this.xLigado.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLigado.Name = "xLigado";
			this.xLigado.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLigado.TagName = "STS_LIGADO";
			this.xLigado.Value = false;
			this.xLigado.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LigadoValueChanged);
			this.xLigado.EndInit();
			// 
			// xAuto
			// 
			this.xAuto.BeginInit();
			this.xAuto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAuto.IsOnlyInput = true;
			this.xAuto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAuto.Name = "xAuto";
			this.xAuto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAuto.TagName = "fbkStsAutomatico";
			this.xAuto.Value = false;
			this.xAuto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AutomaticoValueChanged);
			this.xAuto.EndInit();
			// 
			// xCmdManual
			// 
			this.xCmdManual.BeginInit();
			this.xCmdManual.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCmdManual.IsOnlyInput = true;
			this.xCmdManual.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCmdManual.Name = "xCmdManual";
			this.xCmdManual.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCmdManual.TagName = "fbkCmdManual";
			this.xCmdManual.Value = false;
			this.xCmdManual.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CmdManualValueChanged);
			this.xCmdManual.EndInit();
			// 
			// xRemoto
			// 
			this.xRemoto.BeginInit();
			this.xRemoto.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRemoto.IsOnlyInput = true;
			this.xRemoto.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRemoto.Name = "xRemoto";
			this.xRemoto.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRemoto.TagName = "STS_REMOTO";
			this.xRemoto.Value = false;
			this.xRemoto.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.RemotoValueChanged);
			this.xRemoto.EndInit();
			// 
			// xLocal
			// 
			this.xLocal.BeginInit();
			this.xLocal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xLocal.IsOnlyInput = true;
			this.xLocal.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xLocal.Name = "xLocal";
			this.xLocal.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xLocal.TagName = "STS_LOCAL";
			this.xLocal.Value = false;
			this.xLocal.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.LocalValueChanged);
			this.xLocal.EndInit();
			// 
			// xManut
			// 
			this.xManut.BeginInit();
			this.xManut.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xManut.IsOnlyInput = true;
			this.xManut.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xManut.Name = "xManut";
			this.xManut.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xManut.TagName = "STS_MANUTENCAO";
			this.xManut.Value = false;
			this.xManut.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ManutencaoValueChanged);
			this.xManut.EndInit();
			// 
			// xDisp
			// 
			this.xDisp.BeginInit();
			this.xDisp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xDisp.IsOnlyInput = true;
			this.xDisp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xDisp.Name = "xDisp";
			this.xDisp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xDisp.TagName = "STS_DISPONIVEL_AUTOMATICO";
			this.xDisp.Value = false;
			this.xDisp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DisponivelValueChanged);
			this.xDisp.EndInit();
			// 
			// xBloq
			// 
			this.xBloq.BeginInit();
			this.xBloq.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBloq.IsOnlyInput = true;
			this.xBloq.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBloq.Name = "xBloq";
			this.xBloq.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBloq.TagName = "STS_BLOQUEADO";
			this.xBloq.Value = false;
			this.xBloq.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BloqueadoValueChanged);
			this.xBloq.EndInit();
			// 
			// xBloqGer
			// 
			this.xBloqGer.BeginInit();
			this.xBloqGer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xBloqGer.IsOnlyInput = true;
			this.xBloqGer.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xBloqGer.Name = "xBloqGer";
			this.xBloqGer.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xBloqGer.TagName = "STS_BLOQUEIO_GERADOR";
			this.xBloqGer.Value = false;
			this.xBloqGer.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.BloqGeradorValueChanged);
			this.xBloqGer.EndInit();
			// 
			// xInversor
			// 
			this.xInversor.BeginInit();
			this.xInversor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xInversor.IsOnlyInput = true;
			this.xInversor.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xInversor.Name = "xInversor";
			this.xInversor.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xInversor.TagName = "STS_INVERSOR";
			this.xInversor.Value = false;
			this.xInversor.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InversorValueChanged);
			this.xInversor.EndInit();
			// 
			// xAnimGer
			// 
			this.xAnimGer.BeginInit();
			this.xAnimGer.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAnimGer.IsOnlyInput = true;
			this.xAnimGer.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAnimGer.Name = "xAnimGer";
			this.xAnimGer.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAnimGer.TagName = "STS_ANIMACAO_GERADOR";
			this.xAnimGer.Value = ((short)(0));
			this.xAnimGer.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.AnimGeradorValueChanged);
			this.xAnimGer.EndInit();
			// 
			// xVel
			// 
			this.xVel.BeginInit();
			this.xVel.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xVel.IsOnlyInput = true;
			this.xVel.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xVel.Name = "xVel";
			this.xVel.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xVel.TagName = "STS_VELOCIDADE";
			this.xVel.Value = 0F;
			this.xVel.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.VelocidadeValueChanged);
			this.xVel.EndInit();
			// 
			// xRef
			// 
			this.xRef.BeginInit();
			this.xRef.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xRef.IsOnlyInput = true;
			this.xRef.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xRef.Name = "xRef";
			this.xRef.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xRef.TagName = "STS_VELOCIDADE_REFERENCIA";
			this.xRef.Value = 0F;
			this.xRef.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ReferenciaValueChanged);
			this.xRef.EndInit();
			// 
			// xEmerg
			// 
			this.xEmerg.BeginInit();
			this.xEmerg.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEmerg.IsOnlyInput = true;
			this.xEmerg.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEmerg.Name = "xEmerg";
			this.xEmerg.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEmerg.TagName = "STS_EMERGENCIA";
			this.xEmerg.Value = false;
			this.xEmerg.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EmergValueChanged);
			this.xEmerg.EndInit();
			// 
			// xTerm
			// 
			this.xTerm.BeginInit();
			this.xTerm.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xTerm.IsOnlyInput = true;
			this.xTerm.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xTerm.Name = "xTerm";
			this.xTerm.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xTerm.TagName = "STS_PROTECAO_TERMICA";
			this.xTerm.Value = false;
			this.xTerm.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TermValueChanged);
			this.xTerm.EndInit();
			// 
			// xInv
			// 
			this.xInv.BeginInit();
			this.xInv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xInv.IsOnlyInput = true;
			this.xInv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xInv.Name = "xInv";
			this.xInv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xInv.TagName = "STS_FALHA_INVERSOR";
			this.xInv.Value = false;
			this.xInv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.InvValueChanged);
			this.xInv.EndInit();
			// 
			// xPart
			// 
			this.xPart.BeginInit();
			this.xPart.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPart.IsOnlyInput = true;
			this.xPart.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPart.Name = "xPart";
			this.xPart.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPart.TagName = "STS_FALHA_PARTIDA";
			this.xPart.Value = false;
			this.xPart.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PartValueChanged);
			this.xPart.EndInit();
			// 
			// xPara
			// 
			this.xPara.BeginInit();
			this.xPara.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPara.IsOnlyInput = true;
			this.xPara.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPara.Name = "xPara";
			this.xPara.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPara.TagName = "STS_FALHA_PARADA";
			this.xPara.Value = false;
			this.xPara.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ParaValueChanged);
			this.xPara.EndInit();
			// 
			// xCom
			// 
			this.xCom.BeginInit();
			this.xCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCom.IsOnlyInput = true;
			this.xCom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCom.Name = "xCom";
			this.xCom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCom.TagName = "STS_FALHA_COMUNICACAO";
			this.xCom.Value = false;
			this.xCom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ComValueChanged);
			this.xCom.EndInit();
			// 
			// xEEmerg
			// 
			this.xEEmerg.BeginInit();
			this.xEEmerg.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEmerg.IsOnlyInput = true;
			this.xEEmerg.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEmerg.Name = "xEEmerg";
			this.xEEmerg.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEmerg.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEmerg.Value = ((byte)(0));
			this.xEEmerg.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EEmergValueChanged);
			this.xEEmerg.EndInit();
			// 
			// xETerm
			// 
			this.xETerm.BeginInit();
			this.xETerm.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xETerm.IsOnlyInput = true;
			this.xETerm.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xETerm.Name = "xETerm";
			this.xETerm.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xETerm.TagName = "STS_ALM_TERMICA_EST";
			this.xETerm.Value = ((byte)(0));
			this.xETerm.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ETermValueChanged);
			this.xETerm.EndInit();
			// 
			// xEInv
			// 
			this.xEInv.BeginInit();
			this.xEInv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEInv.IsOnlyInput = true;
			this.xEInv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEInv.Name = "xEInv";
			this.xEInv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEInv.TagName = "STS_ALM_ACIONAMENTO_EST";
			this.xEInv.Value = ((byte)(0));
			this.xEInv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EInvValueChanged);
			this.xEInv.EndInit();
			// 
			// xEPart
			// 
			this.xEPart.BeginInit();
			this.xEPart.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPart.IsOnlyInput = true;
			this.xEPart.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPart.Name = "xEPart";
			this.xEPart.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPart.TagName = "STS_ALM_PARTIDA_EST";
			this.xEPart.Value = ((byte)(0));
			this.xEPart.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EPartValueChanged);
			this.xEPart.EndInit();
			// 
			// xEPara
			// 
			this.xEPara.BeginInit();
			this.xEPara.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPara.IsOnlyInput = true;
			this.xEPara.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPara.Name = "xEPara";
			this.xEPara.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPara.TagName = "STS_ALM_PARADA_EST";
			this.xEPara.Value = ((byte)(0));
			this.xEPara.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EParaValueChanged);
			this.xEPara.EndInit();
			// 
			// xECom
			// 
			this.xECom.BeginInit();
			this.xECom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xECom.IsOnlyInput = true;
			this.xECom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xECom.Name = "xECom";
			this.xECom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xECom.TagName = "STS_ALM_COMUNICACAO_EST";
			this.xECom.Value = ((byte)(0));
			this.xECom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.EComValueChanged);
			this.xECom.EndInit();
			// 
			// xUsaTermica
			// 
			this.xUsaTermica.BeginInit();
			this.xUsaTermica.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xUsaTermica.IsOnlyInput = true;
			this.xUsaTermica.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xUsaTermica.Name = "xUsaTermica";
			this.xUsaTermica.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xUsaTermica.TagName = "STS_USA_TERMICA";
			this.xUsaTermica.Value = false;
			this.xUsaTermica.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.UsaTermicaValueChanged);
			this.xUsaTermica.EndInit();
			// 
			// xUsaCom
			// 
			this.xUsaCom.BeginInit();
			this.xUsaCom.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xUsaCom.IsOnlyInput = true;
			this.xUsaCom.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xUsaCom.Name = "xUsaCom";
			this.xUsaCom.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xUsaCom.TagName = "STS_USA_FALHA_COMUNICACAO";
			this.xUsaCom.Value = false;
			this.xUsaCom.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.UsaComValueChanged);
			this.xUsaCom.EndInit();
			// 
			// fpDiagnostic
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(360D)), ((float)(492D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.titulo,
			this.tituloEst,
			this.eSTS_REMOTO,
			this.vSTS_REMOTO,
			this.eSTS_LOCAL,
			this.vSTS_LOCAL,
			this.eSTS_MANUTENCAO,
			this.vSTS_MANUTENCAO,
			this.efbkStsAutomatico,
			this.vfbkStsAutomatico,
			this.eSTS_DISPONIVEL_AUTOMATICO,
			this.vSTS_DISPONIVEL_AUTOMATICO,
			this.eSTS_BLOQUEADO,
			this.vSTS_BLOQUEADO,
			this.eSTS_BLOQUEIO_GERADOR,
			this.vSTS_BLOQUEIO_GERADOR,
			this.tituloFal,
			this.rEmerg,
			this.nEmerg,
			this.iEmergP1,
			this.iEmergP1n,
			this.iEmergP2,
			this.iEmergP2n,
			this.iEmergTxt,
			this.rTerm,
			this.nTerm,
			this.iTermP1,
			this.iTermP1n,
			this.iTermP2,
			this.iTermP2n,
			this.iTermTxt,
			this.rInv,
			this.nInv,
			this.iInvP1,
			this.iInvP1n,
			this.iInvP2,
			this.iInvP2n,
			this.iInvTxt,
			this.rPart,
			this.nPart,
			this.iPartP1,
			this.iPartP1n,
			this.iPartP2,
			this.iPartP2n,
			this.iPartTxt,
			this.rPara,
			this.nPara,
			this.iParaP1,
			this.iParaP1n,
			this.iParaP2,
			this.iParaP2n,
			this.iParaTxt,
			this.rCom,
			this.nCom,
			this.iComP1,
			this.iComP1n,
			this.iComP2,
			this.iComP2n,
			this.iComTxt,
			this.tVelRef,
			this.vVelRef,
			this.tVel,
			this.vVel,
			this.xLigado,
			this.xAuto,
			this.xCmdManual,
			this.xRemoto,
			this.xLocal,
			this.xManut,
			this.xDisp,
			this.xBloq,
			this.xBloqGer,
			this.xInversor,
			this.xAnimGer,
			this.xVel,
			this.xRef,
			this.xEmerg,
			this.xTerm,
			this.xInv,
			this.xPart,
			this.xPara,
			this.xCom,
			this.xEEmerg,
			this.xETerm,
			this.xEInv,
			this.xEPart,
			this.xEPara,
			this.xECom,
			this.xUsaTermica,
			this.xUsaCom});
			this.Size = new System.Drawing.Size(360, 492);

		}
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText tituloEst;
		private NxtControl.GuiFramework.FreeText eSTS_REMOTO;
		private System.HMI.Symbols.Base.FreeText<bool> vSTS_REMOTO;
		private NxtControl.GuiFramework.FreeText eSTS_LOCAL;
		private System.HMI.Symbols.Base.FreeText<bool> vSTS_LOCAL;
		private NxtControl.GuiFramework.FreeText eSTS_MANUTENCAO;
		private System.HMI.Symbols.Base.FreeText<bool> vSTS_MANUTENCAO;
		private NxtControl.GuiFramework.FreeText efbkStsAutomatico;
		private System.HMI.Symbols.Base.FreeText<bool> vfbkStsAutomatico;
		private NxtControl.GuiFramework.FreeText eSTS_DISPONIVEL_AUTOMATICO;
		private System.HMI.Symbols.Base.FreeText<bool> vSTS_DISPONIVEL_AUTOMATICO;
		private NxtControl.GuiFramework.FreeText eSTS_BLOQUEADO;
		private System.HMI.Symbols.Base.FreeText<bool> vSTS_BLOQUEADO;
		private NxtControl.GuiFramework.FreeText eSTS_BLOQUEIO_GERADOR;
		private System.HMI.Symbols.Base.FreeText<bool> vSTS_BLOQUEIO_GERADOR;
		private NxtControl.GuiFramework.FreeText tituloFal;
		private NxtControl.GuiFramework.FreeText rEmerg;
		private NxtControl.GuiFramework.FreeText nEmerg;
		private NxtControl.GuiFramework.Rectangle iEmergP1;
		private NxtControl.GuiFramework.FreeText iEmergP1n;
		private NxtControl.GuiFramework.Polygon iEmergP2;
		private NxtControl.GuiFramework.FreeText iEmergP2n;
		private NxtControl.GuiFramework.FreeText iEmergTxt;
		private NxtControl.GuiFramework.FreeText rTerm;
		private NxtControl.GuiFramework.FreeText nTerm;
		private NxtControl.GuiFramework.Rectangle iTermP1;
		private NxtControl.GuiFramework.FreeText iTermP1n;
		private NxtControl.GuiFramework.Polygon iTermP2;
		private NxtControl.GuiFramework.FreeText iTermP2n;
		private NxtControl.GuiFramework.FreeText iTermTxt;
		private NxtControl.GuiFramework.FreeText rInv;
		private NxtControl.GuiFramework.FreeText nInv;
		private NxtControl.GuiFramework.Rectangle iInvP1;
		private NxtControl.GuiFramework.FreeText iInvP1n;
		private NxtControl.GuiFramework.Polygon iInvP2;
		private NxtControl.GuiFramework.FreeText iInvP2n;
		private NxtControl.GuiFramework.FreeText iInvTxt;
		private NxtControl.GuiFramework.FreeText rPart;
		private NxtControl.GuiFramework.FreeText nPart;
		private NxtControl.GuiFramework.Rectangle iPartP1;
		private NxtControl.GuiFramework.FreeText iPartP1n;
		private NxtControl.GuiFramework.Polygon iPartP2;
		private NxtControl.GuiFramework.FreeText iPartP2n;
		private NxtControl.GuiFramework.FreeText iPartTxt;
		private NxtControl.GuiFramework.FreeText rPara;
		private NxtControl.GuiFramework.FreeText nPara;
		private NxtControl.GuiFramework.Rectangle iParaP1;
		private NxtControl.GuiFramework.FreeText iParaP1n;
		private NxtControl.GuiFramework.Polygon iParaP2;
		private NxtControl.GuiFramework.FreeText iParaP2n;
		private NxtControl.GuiFramework.FreeText iParaTxt;
		private NxtControl.GuiFramework.FreeText rCom;
		private NxtControl.GuiFramework.FreeText nCom;
		private NxtControl.GuiFramework.Rectangle iComP1;
		private NxtControl.GuiFramework.FreeText iComP1n;
		private NxtControl.GuiFramework.Polygon iComP2;
		private NxtControl.GuiFramework.FreeText iComP2n;
		private NxtControl.GuiFramework.FreeText iComTxt;
		private NxtControl.GuiFramework.FreeText tVelRef;
		private System.HMI.Symbols.Base.Label<System.Single> vVelRef;
		private NxtControl.GuiFramework.FreeText tVel;
		private System.HMI.Symbols.Base.Label<System.Single> vVel;
		private System.HMI.Symbols.Base.Execute<bool> xLigado;
		private System.HMI.Symbols.Base.Execute<bool> xAuto;
		private System.HMI.Symbols.Base.Execute<bool> xCmdManual;
		private System.HMI.Symbols.Base.Execute<bool> xRemoto;
		private System.HMI.Symbols.Base.Execute<bool> xLocal;
		private System.HMI.Symbols.Base.Execute<bool> xManut;
		private System.HMI.Symbols.Base.Execute<bool> xDisp;
		private System.HMI.Symbols.Base.Execute<bool> xBloq;
		private System.HMI.Symbols.Base.Execute<bool> xBloqGer;
		private System.HMI.Symbols.Base.Execute<bool> xInversor;
		private System.HMI.Symbols.Base.Execute<short> xAnimGer;
		private System.HMI.Symbols.Base.Execute<float> xVel;
		private System.HMI.Symbols.Base.Execute<float> xRef;
		private System.HMI.Symbols.Base.Execute<bool> xEmerg;
		private System.HMI.Symbols.Base.Execute<bool> xTerm;
		private System.HMI.Symbols.Base.Execute<bool> xInv;
		private System.HMI.Symbols.Base.Execute<bool> xPart;
		private System.HMI.Symbols.Base.Execute<bool> xPara;
		private System.HMI.Symbols.Base.Execute<bool> xCom;
		private System.HMI.Symbols.Base.Execute<byte> xEEmerg;
		private System.HMI.Symbols.Base.Execute<byte> xETerm;
		private System.HMI.Symbols.Base.Execute<byte> xEInv;
		private System.HMI.Symbols.Base.Execute<byte> xEPart;
		private System.HMI.Symbols.Base.Execute<byte> xEPara;
		private System.HMI.Symbols.Base.Execute<byte> xECom;
		private System.HMI.Symbols.Base.Execute<bool> xUsaTermica;
		private System.HMI.Symbols.Base.Execute<bool> xUsaCom;
		#endregion
	}
}
