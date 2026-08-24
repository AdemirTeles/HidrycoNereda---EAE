/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/5/2026
 * Time: 1:44 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Motor_Status
{
	/// <summary>
	/// Summary description for sDefault.
	/// </summary>
	partial class Motor
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.aliasDisplayLabel1 = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.motor_Invertido1 = new Hidryco.HidrycoLib.Graphics.Motor_Invertido();
			this.STS_FUNCIONAMENTO = new System.HMI.Symbols.Base.Execute<short>();
			// 
			// aliasDisplayLabel1
			// 
			this.aliasDisplayLabel1.AngleIgnore = true;
			this.aliasDisplayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aliasDisplayLabel1.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(15D)), ((float)(101D)), ((float)(22D)));
			this.aliasDisplayLabel1.Brush = new NxtControl.Drawing.Brush(true);
			this.aliasDisplayLabel1.CustomInstanceName = null;
			this.aliasDisplayLabel1.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.aliasDisplayLabel1.FontScale = true;
			this.aliasDisplayLabel1.Name = "aliasDisplayLabel1";
			this.aliasDisplayLabel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.aliasDisplayLabel1.Text = "Label";
			this.aliasDisplayLabel1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// motor_Invertido1
			// 
			this.motor_Invertido1.BeginInit();
			this.motor_Invertido1.Animacao = 0;
			this.motor_Invertido1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.2156862745098038D, 0D, 0D, 1.2156862745098038D, 31.999999999999993D, 37.882352941176464D);
			this.motor_Invertido1.Name = "motor_Invertido1";
			this.motor_Invertido1.EndInit();
			// 
			// STS_FUNCIONAMENTO
			// 
			this.STS_FUNCIONAMENTO.BeginInit();
			this.STS_FUNCIONAMENTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 120D, 182D);
			this.STS_FUNCIONAMENTO.IsOnlyInput = true;
			this.STS_FUNCIONAMENTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.STS_FUNCIONAMENTO.Name = "STS_FUNCIONAMENTO";
			this.STS_FUNCIONAMENTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.STS_FUNCIONAMENTO.TagName = "STS_FUNCIONAMENTO";
			this.STS_FUNCIONAMENTO.Value = ((short)(0));
			this.STS_FUNCIONAMENTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.STS_FUNCIONAMENTOValueChanged);
			this.STS_FUNCIONAMENTO.EndInit();
			// 
			// Motor
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.aliasDisplayLabel1,
			this.motor_Invertido1,
			this.STS_FUNCIONAMENTO});
			this.SymbolSize = new System.Drawing.Size(132, 104);

		}
		private NxtControl.GuiFramework.AliasDisplayLabel aliasDisplayLabel1;
		private Hidryco.HidrycoLib.Graphics.Motor_Invertido motor_Invertido1;
		private System.HMI.Symbols.Base.Execute<short> STS_FUNCIONAMENTO;
		#endregion
	}
}
