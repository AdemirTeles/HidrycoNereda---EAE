/*
 * Hidryco - Gradeamento_Inovaisa - fpDefault
 * Gradeamento: estado, comandos do painel (ciclo remoto e setpoints de diferencial), reset do painel e skid.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Gradeamento_Inovaisa
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
			this.alP1 = new NxtControl.GuiFramework.Rectangle();
			this.alP1n = new NxtControl.GuiFramework.FreeText();
			this.alP2 = new NxtControl.GuiFramework.Polygon();
			this.alP2n = new NxtControl.GuiFramework.FreeText();
			this.alTxt = new NxtControl.GuiFramework.FreeText();
			this.e1 = new NxtControl.GuiFramework.FreeText();
			this.e2 = new NxtControl.GuiFramework.FreeText();
			this.l1 = new NxtControl.GuiFramework.FreeText();
			this.l2 = new NxtControl.GuiFramework.FreeText();
			this.comandos = new Hidryco.HidrycoLib.Symbols.Controle_Gradeamento.sAjustes();
			this.ajuda = new NxtControl.GuiFramework.FreeText();
			this.btnReset = new NxtControl.GuiFramework.DrawnButton();
			this.btnSkid = new NxtControl.GuiFramework.DrawnButton();
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
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(470D)), ((float)(74D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// alP1
			// 
			this.alP1.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
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
			this.alP1n.Location = new NxtControl.Drawing.PointF(24D, 11D);
			this.alP1n.Name = "alP1n";
			this.alP1n.Text = "1";
			this.alP1n.Visible = false;
			// 
			// alP2
			// 
			this.alP2.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(10D)), ((float)(16D)), ((float)(16D)));
			this.alP2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(205)), ((byte)(0))));
			this.alP2.Closed = true;
			this.alP2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.alP2.Name = "alP2";
			this.alP2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.alP2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(20D, 26D),
			new NxtControl.Drawing.PointF(28D, 10D),
			new NxtControl.Drawing.PointF(36D, 26D)});
			this.alP2.Visible = false;
			// 
			// alP2n
			// 
			this.alP2n.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alP2n.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alP2n.Location = new NxtControl.Drawing.PointF(25D, 13D);
			this.alP2n.Name = "alP2n";
			this.alP2n.Text = "2";
			this.alP2n.Visible = false;
			// 
			// alTxt
			// 
			this.alTxt.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.alTxt.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.alTxt.Location = new NxtControl.Drawing.PointF(40D, 10D);
			this.alTxt.Name = "alTxt";
			this.alTxt.Text = "";
			this.alTxt.Visible = false;
			// 
			// e1
			// 
			this.e1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e1.Font = new NxtControl.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
			this.e1.Location = new NxtControl.Drawing.PointF(20D, 32D);
			this.e1.Name = "e1";
			this.e1.Text = "";
			// 
			// e2
			// 
			this.e2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.e2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.e2.Location = new NxtControl.Drawing.PointF(20D, 54D);
			this.e2.Name = "e2";
			this.e2.Text = "";
			// 
			// l1
			// 
			this.l1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l1.Location = new NxtControl.Drawing.PointF(20D, 86D);
			this.l1.Name = "l1";
			this.l1.Text = "";
			// 
			// l2
			// 
			this.l2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.l2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.l2.Location = new NxtControl.Drawing.PointF(20D, 106D);
			this.l2.Name = "l2";
			this.l2.Text = "";
			// 
			// comandos
			// 
			this.comandos.BeginInit();
			this.comandos.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 20D, 132D);
			this.comandos.Name = "comandos";
			this.comandos.SecurityToken = ((uint)(4294967295u));
			this.comandos.TagName = "Grade_Status1";
			this.comandos.Titulo = "Comandos do painel";
			this.comandos.ColunaCampo = 300D;
			this.comandos.EndInit();
			// 
			// ajuda
			// 
			this.ajuda.Color = new NxtControl.Drawing.Color(((byte)(96)), ((byte)(96)), ((byte)(96)));
			this.ajuda.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.ajuda.Location = new NxtControl.Drawing.PointF(20D, 286D);
			this.ajuda.Name = "ajuda";
			this.ajuda.Text = "O painel limpa a grade quando o diferencial (montante - jusante) passa do setpoint.";
			// 
			// btnReset
			// 
			this.btnReset.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(320D)), ((float)(430D)), ((float)(34D)));
			this.btnReset.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnReset.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.btnReset.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnReset.Name = "btnReset";
			this.btnReset.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnReset.Radius = 2D;
			this.btnReset.Text = "Reset do painel / reconhecer alarmes";
			this.btnReset.Use3DEffect = false;
			this.btnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// btnSkid
			// 
			this.btnSkid.Bounds = new NxtControl.Drawing.RectF(((float)(20D)), ((float)(366D)), ((float)(430D)), ((float)(34D)));
			this.btnSkid.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnSkid.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnSkid.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnSkid.Name = "btnSkid";
			this.btnSkid.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpSkid", NxtControl.GuiFramework.MouseButtonType.Click));
			this.btnSkid.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnSkid.Radius = 2D;
			this.btnSkid.Text = "Ver skid";
			this.btnSkid.Use3DEffect = false;
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
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(470D)), ((float)(430D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.alP1,
			this.alP1n,
			this.alP2,
			this.alP2n,
			this.alTxt,
			this.e1,
			this.e2,
			this.l1,
			this.l2,
			this.comandos,
			this.ajuda,
			this.btnReset,
			this.btnSkid,
			this.xALM,
			this.xEMG,
			this.xCOM,
			this.xAPAI,
			this.xCIC,
			this.xFMOT,
			this.xFUNC,
			this.xECOM,
			this.xEEMG,
			this.xEPAI});
			this.Size = new System.Drawing.Size(470, 430);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.Rectangle alP1;
		private NxtControl.GuiFramework.FreeText alP1n;
		private NxtControl.GuiFramework.Polygon alP2;
		private NxtControl.GuiFramework.FreeText alP2n;
		private NxtControl.GuiFramework.FreeText alTxt;
		private NxtControl.GuiFramework.FreeText e1;
		private NxtControl.GuiFramework.FreeText e2;
		private NxtControl.GuiFramework.FreeText l1;
		private NxtControl.GuiFramework.FreeText l2;
		private Hidryco.HidrycoLib.Symbols.Controle_Gradeamento.sAjustes comandos;
		private NxtControl.GuiFramework.FreeText ajuda;
		private NxtControl.GuiFramework.DrawnButton btnReset;
		private NxtControl.GuiFramework.DrawnButton btnSkid;
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
		#endregion
	}
}
