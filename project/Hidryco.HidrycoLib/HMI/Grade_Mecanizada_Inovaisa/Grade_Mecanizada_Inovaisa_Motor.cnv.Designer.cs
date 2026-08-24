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

namespace Hidryco.HidrycoLib.Symbols.Grade_Mecanizada_Inovaisa
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
			this.sobretorque1 = new Hidryco.HidrycoLib.Graphics.Sobretorque();
			this.grade_Mecanizada1 = new Hidryco.HidrycoLib.Graphics.Grade_Mecanizada();
			this.iconReverso = new NxtControl.GuiFramework.Polygon();
			this.iconAvante = new NxtControl.GuiFramework.Polygon();
			this.STS_SENSOR_SOBRETORQUE = new System.HMI.Symbols.Base.Execute<short>();
			this.Base1R = new NxtControl.GuiFramework.Rectangle();
			this.Base2R = new NxtControl.GuiFramework.Rectangle();
			this.Base3R = new NxtControl.GuiFramework.Rectangle();
			this.STS_FUNCIONAMENTO = new System.HMI.Symbols.Base.Execute<short>();
			this.textReverso = new NxtControl.GuiFramework.FreeText();
			this.textAvante = new NxtControl.GuiFramework.FreeText();
			// 
			// aliasDisplayLabel1
			// 
			this.aliasDisplayLabel1.AngleIgnore = true;
			this.aliasDisplayLabel1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.aliasDisplayLabel1.Bounds = new NxtControl.Drawing.RectF(((float)(187D)), ((float)(31D)), ((float)(89D)), ((float)(22D)));
			this.aliasDisplayLabel1.Brush = new NxtControl.Drawing.Brush(true);
			this.aliasDisplayLabel1.CustomInstanceName = null;
			this.aliasDisplayLabel1.Font = new NxtControl.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
			this.aliasDisplayLabel1.FontScale = true;
			this.aliasDisplayLabel1.Name = "aliasDisplayLabel1";
			this.aliasDisplayLabel1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.aliasDisplayLabel1.Text = "Label";
			this.aliasDisplayLabel1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			// 
			// sobretorque1
			// 
			this.sobretorque1.BeginInit();
			this.sobretorque1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.782608695652174D, 0D, 0D, 0.782608695652174D, 275D, 56D);
			this.sobretorque1.Name = "sobretorque1";
			this.sobretorque1.EndInit();
			// 
			// grade_Mecanizada1
			// 
			this.grade_Mecanizada1.BeginInit();
			this.grade_Mecanizada1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 194D, 56D);
			this.grade_Mecanizada1.Name = "grade_Mecanizada1";
			this.grade_Mecanizada1.EndInit();
			// 
			// iconReverso
			// 
			this.iconReverso.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(48D)), ((float)(20D)), ((float)(20D)));
			this.iconReverso.Closed = true;
			this.iconReverso.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iconReverso.Name = "iconReverso";
			this.iconReverso.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(180D, 68D),
			new NxtControl.Drawing.PointF(175D, 68D),
			new NxtControl.Drawing.PointF(175D, 58D),
			new NxtControl.Drawing.PointF(170D, 58D),
			new NxtControl.Drawing.PointF(180D, 48D),
			new NxtControl.Drawing.PointF(190D, 58D),
			new NxtControl.Drawing.PointF(185D, 58D),
			new NxtControl.Drawing.PointF(185D, 68D)});
			// 
			// iconAvante
			// 
			this.iconAvante.Bounds = new NxtControl.Drawing.RectF(((float)(170D)), ((float)(71D)), ((float)(20D)), ((float)(20D)));
			this.iconAvante.Closed = true;
			this.iconAvante.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.iconAvante.Name = "iconAvante";
			this.iconAvante.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(180D, 71D),
			new NxtControl.Drawing.PointF(175D, 71D),
			new NxtControl.Drawing.PointF(175D, 81D),
			new NxtControl.Drawing.PointF(170D, 81D),
			new NxtControl.Drawing.PointF(180D, 91D),
			new NxtControl.Drawing.PointF(190D, 81D),
			new NxtControl.Drawing.PointF(185D, 81D),
			new NxtControl.Drawing.PointF(185D, 71D)});
			// 
			// STS_SENSOR_SOBRETORQUE
			// 
			this.STS_SENSOR_SOBRETORQUE.BeginInit();
			this.STS_SENSOR_SOBRETORQUE.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.STS_SENSOR_SOBRETORQUE.IsOnlyInput = true;
			this.STS_SENSOR_SOBRETORQUE.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.STS_SENSOR_SOBRETORQUE.Name = "STS_SENSOR_SOBRETORQUE";
			this.STS_SENSOR_SOBRETORQUE.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.STS_SENSOR_SOBRETORQUE.TagName = "STS_SENSOR_SOBRETORQUE";
			this.STS_SENSOR_SOBRETORQUE.Value = ((short)(0));
			this.STS_SENSOR_SOBRETORQUE.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.STS_SENSOR_SOBRETORQUEValueChanged);
			this.STS_SENSOR_SOBRETORQUE.EndInit();
			// 
			// Base1R
			// 
			this.Base1R.Bounds = new NxtControl.Drawing.RectF(((float)(215D)), ((float)(56D)), ((float)(56D)), ((float)(40D)));
			this.Base1R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base1R.Name = "Base1R";
			// 
			// Base2R
			// 
			this.Base2R.Bounds = new NxtControl.Drawing.RectF(((float)(211D)), ((float)(68D)), ((float)(4D)), ((float)(16D)));
			this.Base2R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base2R.Name = "Base2R";
			// 
			// Base3R
			// 
			this.Base3R.Bounds = new NxtControl.Drawing.RectF(((float)(208D)), ((float)(72D)), ((float)(3D)), ((float)(7D)));
			this.Base3R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base3R.Name = "Base3R";
			// 
			// STS_FUNCIONAMENTO
			// 
			this.STS_FUNCIONAMENTO.BeginInit();
			this.STS_FUNCIONAMENTO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.STS_FUNCIONAMENTO.IsOnlyInput = true;
			this.STS_FUNCIONAMENTO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.STS_FUNCIONAMENTO.Name = "STS_FUNCIONAMENTO";
			this.STS_FUNCIONAMENTO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.STS_FUNCIONAMENTO.TagName = "STS_FUNCIONAMENTO";
			this.STS_FUNCIONAMENTO.Value = ((short)(0));
			this.STS_FUNCIONAMENTO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.STS_FUNCIONAMENTOValueChanged);
			this.STS_FUNCIONAMENTO.EndInit();
			// 
			// textReverso
			// 
			this.textReverso.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.textReverso.Font = new NxtControl.Drawing.Font("LabelFont");
			this.textReverso.Location = new NxtControl.Drawing.PointF(120D, 47D);
			this.textReverso.Name = "textReverso";
			this.textReverso.Text = "Reverso";
			// 
			// textAvante
			// 
			this.textAvante.Color = new NxtControl.Drawing.Color("LabelTextColor");
			this.textAvante.Font = new NxtControl.Drawing.Font("LabelFont");
			this.textAvante.Location = new NxtControl.Drawing.PointF(126D, 76D);
			this.textAvante.Name = "textAvante";
			this.textAvante.Text = "Avante";
			// 
			// Motor
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base3R,
			this.Base2R,
			this.Base1R,
			this.aliasDisplayLabel1,
			this.sobretorque1,
			this.grade_Mecanizada1,
			this.iconReverso,
			this.iconAvante,
			this.STS_SENSOR_SOBRETORQUE,
			this.STS_FUNCIONAMENTO,
			this.textReverso,
			this.textAvante});
			this.SymbolSize = new System.Drawing.Size(532, 328);

		}
		private NxtControl.GuiFramework.Rectangle Base3R;
		private NxtControl.GuiFramework.Rectangle Base2R;
		private NxtControl.GuiFramework.Rectangle Base1R;
		private NxtControl.GuiFramework.AliasDisplayLabel aliasDisplayLabel1;
		private Hidryco.HidrycoLib.Graphics.Sobretorque sobretorque1;
		private Hidryco.HidrycoLib.Graphics.Grade_Mecanizada grade_Mecanizada1;
		private NxtControl.GuiFramework.Polygon iconReverso;
		private NxtControl.GuiFramework.Polygon iconAvante;
		private System.HMI.Symbols.Base.Execute<short> STS_SENSOR_SOBRETORQUE;
		private System.HMI.Symbols.Base.Execute<short> STS_FUNCIONAMENTO;
		private NxtControl.GuiFramework.FreeText textReverso;
		private NxtControl.GuiFramework.FreeText textAvante;
		#endregion
	}
}
