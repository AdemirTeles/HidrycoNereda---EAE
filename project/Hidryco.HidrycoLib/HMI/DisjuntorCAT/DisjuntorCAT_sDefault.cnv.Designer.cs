/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 19/05/2026
 * Tempo: 13:38
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.DisjuntorCAT
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
			this.line3 = new NxtControl.GuiFramework.Line();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.stsDisjuntorLigado = new System.HMI.Symbols.Base.Execute<bool>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(96D, 72D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(96D, 56D);
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(72D, 72D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(56D, 72D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(96D, 56D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(72D, 72D);
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(112D, 72D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1.5F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(96D, 72D);
			// 
			// stsDisjuntorLigado
			// 
			this.stsDisjuntorLigado.BeginInit();
			this.stsDisjuntorLigado.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.stsDisjuntorLigado.IsOnlyInput = true;
			this.stsDisjuntorLigado.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.stsDisjuntorLigado.Name = "stsDisjuntorLigado";
			this.stsDisjuntorLigado.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.stsDisjuntorLigado.TagName = "stsDisjuntorLigado";
			this.stsDisjuntorLigado.Value = false;
			this.stsDisjuntorLigado.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsDisjuntorLigadoValueChanged);
			this.stsDisjuntorLigado.EndInit();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(84D)), ((float)(52D)), ((float)(58D)), ((float)(13D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "label";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("SE.App2Base.SymInstanceLabelTextColor");
			// 
			// sDefault
			// 
			this.GeneralPropertySubscription.AddRange(new string[] {
			"System.DisplayAliasName"});
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.line3,
			this.line1,
			this.line2,
			this.line4,
			this.stsDisjuntorLigado,
			this.InstanceName});
			this.SymbolSize = new System.Drawing.Size(176, 160);

		}
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line4;
		private System.HMI.Symbols.Base.Execute<bool> stsDisjuntorLigado;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		#endregion
	}
}
