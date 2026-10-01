/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 22/08/2026
 * Tempo: 14:12
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace SE.Nereda.Symbols.CmdSludgeDischargeSLBLogic
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class sDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectBg = new NxtControl.GuiFramework.Rectangle();
			this.polyTitle = new NxtControl.GuiFramework.Polygon();
			this.txtState = new NxtControl.GuiFramework.FreeText();
			this.txtPumps = new NxtControl.GuiFramework.FreeText();
			this.txtSpeed = new NxtControl.GuiFramework.FreeText();
			this.txtMode = new NxtControl.GuiFramework.FreeText();
			this.txtWarn1 = new NxtControl.GuiFramework.FreeText();
			this.txtWarn2 = new NxtControl.GuiFramework.FreeText();
			this.rectBarFrame = new NxtControl.GuiFramework.Rectangle();
			this.rectBarFill = new NxtControl.GuiFramework.Rectangle();
			this.txt100 = new NxtControl.GuiFramework.FreeText();
			this.txt0 = new NxtControl.GuiFramework.FreeText();
			this.mkCmin = new NxtControl.GuiFramework.Polygon();
			this.lbCmin = new NxtControl.GuiFramework.FreeText();
			this.mkC3 = new NxtControl.GuiFramework.Polygon();
			this.lbC3 = new NxtControl.GuiFramework.FreeText();
			this.mkC2 = new NxtControl.GuiFramework.Polygon();
			this.lbC2 = new NxtControl.GuiFramework.FreeText();
			this.mkCmax = new NxtControl.GuiFramework.Polygon();
			this.lbCmax = new NxtControl.GuiFramework.FreeText();
			// 
			// rectBg
			// 
			this.rectBg.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(24D)), ((float)(376D)), ((float)(152D)));
			this.rectBg.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.rectBg.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectBg.Name = "rectBg";
			this.rectBg.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(200)), ((byte)(200))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// polyTitle
			// 
			this.polyTitle.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(176D)), ((float)(24D)));
			this.polyTitle.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))));
			this.polyTitle.Closed = true;
			this.polyTitle.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular);
			this.polyTitle.Name = "polyTitle";
			this.polyTitle.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(78)), ((byte)(78)), ((byte)(78))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.polyTitle.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(0D, 24D),
			new NxtControl.Drawing.PointF(0D, 0D),
			new NxtControl.Drawing.PointF(152D, 0D),
			new NxtControl.Drawing.PointF(176D, 24D)});
			this.polyTitle.Text = "PUMPS STATUS";
			this.polyTitle.TextColor = new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(0)));
			// 
			// txtState
			// 
			this.txtState.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtState.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.txtState.Location = new NxtControl.Drawing.PointF(8D, 32D);
			this.txtState.Name = "txtState";
			this.txtState.Text = "-";
			// 
			// txtPumps
			// 
			this.txtPumps.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.txtPumps.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.txtPumps.Location = new NxtControl.Drawing.PointF(8D, 56D);
			this.txtPumps.Name = "txtPumps";
			this.txtPumps.Text = "Running: -";
			// 
			// txtSpeed
			// 
			this.txtSpeed.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.txtSpeed.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.txtSpeed.Location = new NxtControl.Drawing.PointF(8D, 76D);
			this.txtSpeed.Name = "txtSpeed";
			this.txtSpeed.Text = "Speed per pump: - %";
			// 
			// txtMode
			// 
			this.txtMode.Color = new NxtControl.Drawing.Color(((byte)(60)), ((byte)(60)), ((byte)(60)));
			this.txtMode.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.txtMode.Location = new NxtControl.Drawing.PointF(8D, 96D);
			this.txtMode.Name = "txtMode";
			this.txtMode.Text = "";
			// 
			// txtWarn1
			// 
			this.txtWarn1.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(120)), ((byte)(0)));
			this.txtWarn1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.txtWarn1.Location = new NxtControl.Drawing.PointF(8D, 124D);
			this.txtWarn1.Name = "txtWarn1";
			this.txtWarn1.Text = "";
			// 
			// txtWarn2
			// 
			this.txtWarn2.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
			this.txtWarn2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.txtWarn2.Location = new NxtControl.Drawing.PointF(8D, 146D);
			this.txtWarn2.Name = "txtWarn2";
			this.txtWarn2.Text = "";
			// 
			// rectBarFrame
			// 
			this.rectBarFrame.Bounds = new NxtControl.Drawing.RectF(((float)(298D)), ((float)(32D)), ((float)(28D)), ((float)(138D)));
			this.rectBarFrame.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(255)), ((byte)(255)), ((byte)(255))));
			this.rectBarFrame.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectBarFrame.Name = "rectBarFrame";
			this.rectBarFrame.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(120)), ((byte)(120)), ((byte)(120))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// rectBarFill
			// 
			this.rectBarFill.Bounds = new NxtControl.Drawing.RectF(((float)(300D)), ((float)(34D)), ((float)(24D)), ((float)(134D)));
			this.rectBarFill.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(61)), ((byte)(205)), ((byte)(88))));
			this.rectBarFill.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.rectBarFill.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectBarFill.Name = "rectBarFill";
			this.rectBarFill.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("transparent"), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// txt100
			// 
			this.txt100.Color = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
			this.txt100.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt100.Location = new NxtControl.Drawing.PointF(266D, 28D);
			this.txt100.Name = "txt100";
			this.txt100.Text = "100%";
			// 
			// txt0
			// 
			this.txt0.Color = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
			this.txt0.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.txt0.Location = new NxtControl.Drawing.PointF(280D, 160D);
			this.txt0.Name = "txt0";
			this.txt0.Text = "0%";
			// 
			// mkCmin
			// 
			this.mkCmin.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(100D)), ((float)(36D)), ((float)(3D)));
			this.mkCmin.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))));
			this.mkCmin.Closed = true;
			this.mkCmin.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkCmin.Name = "mkCmin";
			this.mkCmin.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkCmin.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(294D, 100D),
			new NxtControl.Drawing.PointF(330D, 100D),
			new NxtControl.Drawing.PointF(330D, 103D),
			new NxtControl.Drawing.PointF(294D, 103D)});
			// 
			// lbCmin
			// 
			this.lbCmin.Color = new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90)));
			this.lbCmin.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbCmin.Location = new NxtControl.Drawing.PointF(332D, 94D);
			this.lbCmin.Name = "lbCmin";
			this.lbCmin.Text = "Cmin";
			// 
			// mkC3
			// 
			this.mkC3.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(100D)), ((float)(36D)), ((float)(3D)));
			this.mkC3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))));
			this.mkC3.Closed = true;
			this.mkC3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkC3.Name = "mkC3";
			this.mkC3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkC3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(294D, 100D),
			new NxtControl.Drawing.PointF(330D, 100D),
			new NxtControl.Drawing.PointF(330D, 103D),
			new NxtControl.Drawing.PointF(294D, 103D)});
			// 
			// lbC3
			// 
			this.lbC3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(114)), ((byte)(188)));
			this.lbC3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbC3.Location = new NxtControl.Drawing.PointF(332D, 94D);
			this.lbC3.Name = "lbC3";
			this.lbC3.Text = "C3";
			// 
			// mkC2
			// 
			this.mkC2.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(100D)), ((float)(36D)), ((float)(3D)));
			this.mkC2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(120)), ((byte)(0))));
			this.mkC2.Closed = true;
			this.mkC2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkC2.Name = "mkC2";
			this.mkC2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(230)), ((byte)(120)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkC2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(294D, 100D),
			new NxtControl.Drawing.PointF(330D, 100D),
			new NxtControl.Drawing.PointF(330D, 103D),
			new NxtControl.Drawing.PointF(294D, 103D)});
			// 
			// lbC2
			// 
			this.lbC2.Color = new NxtControl.Drawing.Color(((byte)(230)), ((byte)(120)), ((byte)(0)));
			this.lbC2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbC2.Location = new NxtControl.Drawing.PointF(332D, 94D);
			this.lbC2.Name = "lbC2";
			this.lbC2.Text = "C2";
			// 
			// mkCmax
			// 
			this.mkCmax.Bounds = new NxtControl.Drawing.RectF(((float)(294D)), ((float)(100D)), ((float)(36D)), ((float)(3D)));
			this.mkCmax.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30))));
			this.mkCmax.Closed = true;
			this.mkCmax.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.mkCmax.Name = "mkCmax";
			this.mkCmax.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.mkCmax.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(294D, 100D),
			new NxtControl.Drawing.PointF(330D, 100D),
			new NxtControl.Drawing.PointF(330D, 103D),
			new NxtControl.Drawing.PointF(294D, 103D)});
			// 
			// lbCmax
			// 
			this.lbCmax.Color = new NxtControl.Drawing.Color(((byte)(200)), ((byte)(30)), ((byte)(30)));
			this.lbCmax.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
			this.lbCmax.Location = new NxtControl.Drawing.PointF(332D, 94D);
			this.lbCmax.Name = "lbCmax";
			this.lbCmax.Text = "Cmax";
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectBg,
			this.polyTitle,
			this.rectBarFrame,
			this.rectBarFill,
			this.mkCmin,
			this.mkC3,
			this.mkC2,
			this.mkCmax,
			this.lbCmin,
			this.lbC3,
			this.lbC2,
			this.lbCmax,
			this.txt100,
			this.txt0,
			this.txtState,
			this.txtPumps,
			this.txtSpeed,
			this.txtMode,
			this.txtWarn1,
			this.txtWarn2});
			this.SymbolSize = new System.Drawing.Size(376, 176);

		}
		private NxtControl.GuiFramework.Rectangle rectBg;
		private NxtControl.GuiFramework.Polygon polyTitle;
		private NxtControl.GuiFramework.FreeText txtState;
		private NxtControl.GuiFramework.FreeText txtPumps;
		private NxtControl.GuiFramework.FreeText txtSpeed;
		private NxtControl.GuiFramework.FreeText txtMode;
		private NxtControl.GuiFramework.FreeText txtWarn1;
		private NxtControl.GuiFramework.FreeText txtWarn2;
		private NxtControl.GuiFramework.Rectangle rectBarFrame;
		private NxtControl.GuiFramework.Rectangle rectBarFill;
		private NxtControl.GuiFramework.FreeText txt100;
		private NxtControl.GuiFramework.FreeText txt0;
		private NxtControl.GuiFramework.Polygon mkCmin;
		private NxtControl.GuiFramework.FreeText lbCmin;
		private NxtControl.GuiFramework.Polygon mkC3;
		private NxtControl.GuiFramework.FreeText lbC3;
		private NxtControl.GuiFramework.Polygon mkC2;
		private NxtControl.GuiFramework.FreeText lbC2;
		private NxtControl.GuiFramework.Polygon mkCmax;
		private NxtControl.GuiFramework.FreeText lbCmax;
		#endregion
	}
}
