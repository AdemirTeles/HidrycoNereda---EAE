/*
 * Hidryco - Gradeamento_Inovaisa - sDefault
 * ISA-101: gradeamento - ciclo remoto, comunicacao, emergencia e alarme.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Gradeamento_Inovaisa
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.raioGerador = new Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador();
			this.xGER = new System.HMI.Symbols.Base.Execute<short>();
			this.fundo = new NxtControl.GuiFramework.Rectangle();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.stCiclo = new NxtControl.GuiFramework.Rectangle();
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.xALM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xEMG = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCOM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xAPAI = new System.HMI.Symbols.Base.Execute<bool>();
			this.xCIC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFMOT = new System.HMI.Symbols.Base.Execute<bool>();
			this.xFUNC = new System.HMI.Symbols.Base.Execute<bool>();
			this.xECOM = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEEMG = new System.HMI.Symbols.Base.Execute<byte>();
			this.xEPAI = new System.HMI.Symbols.Base.Execute<byte>();
			this.abrir = new NxtControl.GuiFramework.DrawnButton();
			// 
			// fundo
			// 
			this.fundo.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(260D)), ((float)(96D)));
			this.fundo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(232)), ((byte)(232)), ((byte)(232))));
			this.fundo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.fundo.Name = "fundo";
			this.fundo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(2D)), ((float)(160D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.InstanceName.FontScale = false;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextColor = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			// 
			// stCiclo
			// 
			this.stCiclo.Bounds = new NxtControl.Drawing.RectF(((float)(238D)), ((float)(4D)), ((float)(16D)), ((float)(16D)));
			this.stCiclo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(190)), ((byte)(190)), ((byte)(190))));
			this.stCiclo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.stCiclo.Name = "stCiclo";
			this.stCiclo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(74D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(10D, 75D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(74D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(6D, 90D),
			new NxtControl.Drawing.PointF(14D, 74D),
			new NxtControl.Drawing.PointF(22D, 90D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(11D, 77D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(26D, 74D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.l1.Location = new NxtControl.Drawing.PointF(6D, 24D);
			this.l1.Name = "l1";
			this.l1.Text = "";
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(6D, 44D);
			this.l2.Name = "l2";
			this.l2.Text = "";
			// 
			// xALM
			// 
			this.xALM.BeginInit();
			this.xALM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xALM.IsOnlyInput = true;
			this.xALM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xALM.Name = "xALM";
			this.xALM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xALM.TagName = "STS_ALARME";
			this.xALM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XALMValueChanged);
			this.xALM.EndInit();
			// 
			// xEMG
			// 
			this.xEMG.BeginInit();
			this.xEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEMG.IsOnlyInput = true;
			this.xEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEMG.Name = "xEMG";
			this.xEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEMG.TagName = "STS_EMERGENCIA";
			this.xEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEMGValueChanged);
			this.xEMG.EndInit();
			// 
			// xCOM
			// 
			this.xCOM.BeginInit();
			this.xCOM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCOM.IsOnlyInput = true;
			this.xCOM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCOM.Name = "xCOM";
			this.xCOM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCOM.TagName = "STS_COMUNICACAO_OK";
			this.xCOM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCOMValueChanged);
			this.xCOM.EndInit();
			// 
			// xAPAI
			// 
			this.xAPAI.BeginInit();
			this.xAPAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xAPAI.IsOnlyInput = true;
			this.xAPAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xAPAI.Name = "xAPAI";
			this.xAPAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xAPAI.TagName = "STS_ALARME_ACIONADO";
			this.xAPAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XAPAIValueChanged);
			this.xAPAI.EndInit();
			// 
			// xCIC
			// 
			this.xCIC.BeginInit();
			this.xCIC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xCIC.IsOnlyInput = true;
			this.xCIC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xCIC.Name = "xCIC";
			this.xCIC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xCIC.TagName = "STS_CICLO_LIGADO";
			this.xCIC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XCICValueChanged);
			this.xCIC.EndInit();
			// 
			// xFMOT
			// 
			this.xFMOT.BeginInit();
			this.xFMOT.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFMOT.IsOnlyInput = true;
			this.xFMOT.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFMOT.Name = "xFMOT";
			this.xFMOT.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFMOT.TagName = "STS_FALHA_MOTOR";
			this.xFMOT.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFMOTValueChanged);
			this.xFMOT.EndInit();
			// 
			// xFUNC
			// 
			this.xFUNC.BeginInit();
			this.xFUNC.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xFUNC.IsOnlyInput = true;
			this.xFUNC.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xFUNC.Name = "xFUNC";
			this.xFUNC.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xFUNC.TagName = "STS_FUNCIONANDO";
			this.xFUNC.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XFUNCValueChanged);
			this.xFUNC.EndInit();
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
			// xEEMG
			// 
			this.xEEMG.BeginInit();
			this.xEEMG.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEEMG.IsOnlyInput = true;
			this.xEEMG.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEEMG.Name = "xEEMG";
			this.xEEMG.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEEMG.TagName = "STS_ALM_EMERGENCIA_EST";
			this.xEEMG.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEEMGValueChanged);
			this.xEEMG.EndInit();
			// 
			// xEPAI
			// 
			this.xEPAI.BeginInit();
			this.xEPAI.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xEPAI.IsOnlyInput = true;
			this.xEPAI.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xEPAI.Name = "xEPAI";
			this.xEPAI.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xEPAI.TagName = "STS_ALM_PAINEL_EST";
			this.xEPAI.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XEPAIValueChanged);
			this.xEPAI.EndInit();
			// 
			// abrir
			// 
			this.abrir.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(260D)), ((float)(96D)));
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
			// 
			// raioGerador
			// 
			this.raioGerador.BeginInit();
			this.raioGerador.Animacao = 0;
			this.raioGerador.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 212D, 0D);
			this.raioGerador.Name = "raioGerador";
			this.raioGerador.EndInit();
			// 
			// xGER
			// 
			this.xGER.BeginInit();
			this.xGER.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xGER.IsOnlyInput = true;
			this.xGER.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xGER.Name = "xGER";
			this.xGER.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xGER.TagName = "STS_ANIMACAO_GERADOR";
			this.xGER.Value = ((short)(0));
			this.xGER.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.XGERValueChanged);
			this.xGER.EndInit();
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.fundo,
			this.InstanceName,
			this.stCiclo,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.l1,
			this.l2,
			this.xALM,
			this.xEMG,
			this.xCOM,
			this.xAPAI,
			this.xCIC,
			this.xFMOT,
			this.xFUNC,
			this.xECOM,
			this.xEEMG,
			this.xEPAI,
			this.raioGerador,
			this.xGER,
			this.abrir});
			this.SymbolSize = new System.Drawing.Size(260, 96);

		}
		private NxtControl.GuiFramework.Rectangle fundo;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private NxtControl.GuiFramework.Rectangle stCiclo;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText l1;
		private NxtControl.GuiFramework.FreeText l2;
		private System.HMI.Symbols.Base.Execute<bool> xALM;
		private System.HMI.Symbols.Base.Execute<bool> xEMG;
		private System.HMI.Symbols.Base.Execute<bool> xCOM;
		private System.HMI.Symbols.Base.Execute<bool> xAPAI;
		private System.HMI.Symbols.Base.Execute<bool> xCIC;
		private System.HMI.Symbols.Base.Execute<bool> xFMOT;
		private System.HMI.Symbols.Base.Execute<bool> xFUNC;
		private System.HMI.Symbols.Base.Execute<byte> xECOM;
		private System.HMI.Symbols.Base.Execute<byte> xEEMG;
		private System.HMI.Symbols.Base.Execute<byte> xEPAI;
		private NxtControl.GuiFramework.DrawnButton abrir;
		private Hidryco.HidrycoLib.Graphics.Energizado_por_Gerador raioGerador;
		private System.HMI.Symbols.Base.Execute<short> xGER;
		#endregion
	}
}
