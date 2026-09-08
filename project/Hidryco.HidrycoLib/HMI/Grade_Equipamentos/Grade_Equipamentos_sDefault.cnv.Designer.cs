/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/24/2026
 * Time: 10:06 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Grade_Equipamentos
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
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.Sensor_Comunicacao1 = new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault();
			this.Sensor_Comunicacao3 = new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault();
			this.Sensor_Comunicacao2 = new Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.Grade_Mecanizada_Inovaisa1 = new Hidryco.HidrycoLib.Symbols.Grade_Mecanizada_Inovaisa.Motor();
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(79D)), ((float)(161D)), ((float)(600D)), ((float)(168D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(147)), ((byte)(92)), ((byte)(51))));
			this.rectangle2.FillDirection = NxtControl.Drawing.FillDirection.DownToTop;
			this.rectangle2.FillPercent = 40F;
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// Sensor_Comunicacao1
			// 
			this.Sensor_Comunicacao1.BeginInit();
			this.Sensor_Comunicacao1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 172D, 73D);
			this.Sensor_Comunicacao1.Name = "Sensor_Comunicacao1";
			this.Sensor_Comunicacao1.SecurityToken = ((uint)(4294967295u));
			this.Sensor_Comunicacao1.TagName = "SensorMontante";
			this.Sensor_Comunicacao1.EndInit();
			// 
			// Sensor_Comunicacao3
			// 
			this.Sensor_Comunicacao3.BeginInit();
			this.Sensor_Comunicacao3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 484D, 73D);
			this.Sensor_Comunicacao3.Name = "Sensor_Comunicacao3";
			this.Sensor_Comunicacao3.SecurityToken = ((uint)(4294967295u));
			this.Sensor_Comunicacao3.TagName = "SensorJusante";
			this.Sensor_Comunicacao3.EndInit();
			// 
			// Sensor_Comunicacao2
			// 
			this.Sensor_Comunicacao2.BeginInit();
			this.Sensor_Comunicacao2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 329D, 23D);
			this.Sensor_Comunicacao2.Name = "Sensor_Comunicacao2";
			this.Sensor_Comunicacao2.SecurityToken = ((uint)(4294967295u));
			this.Sensor_Comunicacao2.TagName = "SensorDiferencial";
			this.Sensor_Comunicacao2.EndInit();
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(3D, 257D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(78D, 257D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(771D, 257D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(681D, 257D);
			// 
			// Grade_Mecanizada_Inovaisa1
			// 
			this.Grade_Mecanizada_Inovaisa1.BeginInit();
			this.Grade_Mecanizada_Inovaisa1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 308D, 91D);
			this.Grade_Mecanizada_Inovaisa1.Name = "Grade_Mecanizada_Inovaisa1";
			this.Grade_Mecanizada_Inovaisa1.SecurityToken = ((uint)(4294967295u));
			this.Grade_Mecanizada_Inovaisa1.TagName = "Grade_Mecanizada_Inovaisa1";
			this.Grade_Mecanizada_Inovaisa1.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle2,
			this.Sensor_Comunicacao1,
			this.Sensor_Comunicacao3,
			this.Sensor_Comunicacao2,
			this.line1,
			this.line2,
			this.Grade_Mecanizada_Inovaisa1});
			this.SymbolSize = new System.Drawing.Size(763, 367);

		}
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault Sensor_Comunicacao1;
		private Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault Sensor_Comunicacao3;
		private Hidryco.HidrycoLib.Symbols.Sensor_Comunicacao.sDefault Sensor_Comunicacao2;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private Hidryco.HidrycoLib.Symbols.Grade_Mecanizada_Inovaisa.Motor Grade_Mecanizada_Inovaisa1;
		#endregion
	}
}
