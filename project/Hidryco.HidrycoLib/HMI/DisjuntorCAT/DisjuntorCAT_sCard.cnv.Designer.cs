/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 21/05/2026
 * Tempo: 10:54
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.DisjuntorCAT
{
	/// <summary>
	/// Summary description for sCard.
	/// </summary>
	partial class sCard
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.stsDisjuntorLigado = new System.HMI.Symbols.Base.Led<bool>();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(91D)), ((float)(52D)), ((float)(58D)), ((float)(13D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "label";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("SE.App2Base.LabelTextColor");
			// 
			// stsDisjuntorLigado
			// 
			this.stsDisjuntorLigado.BeginInit();
			this.stsDisjuntorLigado.ColorFrame = new NxtControl.Drawing.Color("LedFrameColor");
			this.stsDisjuntorLigado.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 82D, 58D);
			this.stsDisjuntorLigado.FrameSize = 33F;
			this.stsDisjuntorLigado.IsOnlyInput = true;
			this.stsDisjuntorLigado.Name = "stsDisjuntorLigado";
			propertyDictionary2.Add("Color", new NxtControl.Drawing.Color(((byte)(26)), ((byte)(170)), ((byte)(66))));
			propertyDictionary3.Add("Color", new NxtControl.Drawing.Color(((byte)(234)), ((byte)(22)), ((byte)(30))));
			this.stsDisjuntorLigado.Ranges.Clear();
			this.stsDisjuntorLigado.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(false, propertyDictionary2));
			this.stsDisjuntorLigado.Ranges.Add(new NxtControl.GuiFramework.Range<bool>(true, propertyDictionary3));
			propertyDictionary1.Add("Color", new NxtControl.Drawing.Color("LedFalseColor"));
			this.stsDisjuntorLigado.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsDisjuntorLigado.TagName = "stsDisjuntorLigado";
			this.stsDisjuntorLigado.EndInit();
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(69D)), ((float)(47D)), ((float)(108D)), ((float)(22D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(true);
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(130)), ((byte)(130)), ((byte)(130))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.IsOnlyInput = true;
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.TagName = "stsDisjuntorLigado";
			this.execute_11.Value = false;
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StsDisjuntorLigadoValueChanged);
			this.execute_11.EndInit();
			// 
			// sCard
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.InstanceName,
			this.stsDisjuntorLigado,
			this.roundedRectangle1,
			this.execute_11});
			this.SymbolSize = new System.Drawing.Size(240, 200);

		}
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private System.HMI.Symbols.Base.Led<bool> stsDisjuntorLigado;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private System.HMI.Symbols.Base.Execute<bool> execute_11;
		#endregion
	}
}
