/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/9/2026
 * Time: 9:47 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Boia
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
			this.line1 = new NxtControl.GuiFramework.Line();
			this.ellipse1 = new NxtControl.GuiFramework.Ellipse();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.ellipse2 = new NxtControl.GuiFramework.Ellipse();
			this.stsBoia = new System.HMI.Symbols.Base.Execute<bool>();
			this.stsAnimacao = new System.HMI.Symbols.Base.Execute<short>();
			this.group1 = new NxtControl.GuiFramework.Group();
			this.group2 = new NxtControl.GuiFramework.Group();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(130D, 109.75999999999999D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(160D, 88D);
			// 
			// ellipse1
			// 
			this.ellipse1.Bounds = new NxtControl.Drawing.RectF(((float)(113D)), ((float)(104.68000030517578D)), ((float)(18D)), ((float)(16.319999694824219D)));
			this.ellipse1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse1.Name = "ellipse1";
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(130D, 66.666666666666671D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(160D, 88D);
			// 
			// ellipse2
			// 
			this.ellipse2.Bounds = new NxtControl.Drawing.RectF(((float)(113D)), ((float)(56D)), ((float)(18D)), ((float)(16D)));
			this.ellipse2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.ellipse2.Name = "ellipse2";
			// 
			// stsBoia
			// 
			this.stsBoia.BeginInit();
			this.stsBoia.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsBoia.IsOnlyInput = true;
			this.stsBoia.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsBoia.Name = "stsBoia";
			this.stsBoia.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsBoia.TagName = "STS_BOIA";
			this.stsBoia.Value = false;
			this.stsBoia.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsBoiaValueChanged);
			this.stsBoia.EndInit();
			// 
			// stsAnimacao
			// 
			this.stsAnimacao.BeginInit();
			this.stsAnimacao.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 226D, 364D);
			this.stsAnimacao.IsOnlyInput = true;
			this.stsAnimacao.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsAnimacao.Name = "stsAnimacao";
			this.stsAnimacao.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsAnimacao.TagName = "STS_ANIMACAO";
			this.stsAnimacao.Value = ((short)(0));
			this.stsAnimacao.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsAnimacaoValueChanged);
			this.stsAnimacao.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line2,
			this.ellipse2});
			this.group1.EndInit();
			// 
			// group2
			// 
			this.group2.BeginInit();
			this.group2.Name = "group2";
			this.group2.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line1,
			this.ellipse1});
			this.group2.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stsBoia,
			this.stsAnimacao,
			this.group1,
			this.group2});
			this.SymbolSize = new System.Drawing.Size(300, 200);

		}
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Ellipse ellipse1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Ellipse ellipse2;
		private System.HMI.Symbols.Base.Execute<bool> stsBoia;
		private System.HMI.Symbols.Base.Execute<System.Int16> stsAnimacao;
		private NxtControl.GuiFramework.Group group1;
		private NxtControl.GuiFramework.Group group2;
		#endregion
	}
}
