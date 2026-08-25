/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/29/2026
 * Time: 10:59 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_4a20
{
	/// <summary>
	/// Summary description for fpAjustes.
	/// </summary>
	partial class fpAjustes
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.stpRangeMinimo = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.stpRangeMaximo = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.cmdHabilitaSensor = new System.HMI.Symbols.Base.CheckButton();
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			// 
			// stpRangeMinimo
			// 
			this.stpRangeMinimo.BeginInit();
			this.stpRangeMinimo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 168D, 104D);
			this.stpRangeMinimo.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpRangeMinimo.MaximumTag = null;
			this.stpRangeMinimo.MinimumTag = null;
			this.stpRangeMinimo.Name = "stpRangeMinimo";
			this.stpRangeMinimo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpRangeMinimo.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpRangeMinimo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpRangeMinimo.TagName = "STP_RANGE_MINIMO";
			this.stpRangeMinimo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpRangeMinimo.Value = 0F;
			this.stpRangeMinimo.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 104D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Range mínimo";
			// 
			// stpRangeMaximo
			// 
			this.stpRangeMaximo.BeginInit();
			this.stpRangeMaximo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 168D, 152D);
			this.stpRangeMaximo.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpRangeMaximo.MaximumTag = null;
			this.stpRangeMaximo.MinimumTag = null;
			this.stpRangeMaximo.Name = "stpRangeMaximo";
			this.stpRangeMaximo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpRangeMaximo.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpRangeMaximo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpRangeMaximo.TagName = "STP_RANGE_MAXIMO";
			this.stpRangeMaximo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpRangeMaximo.Value = 0F;
			this.stpRangeMaximo.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 157D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Range Máximo";
			// 
			// cmdHabilitaSensor
			// 
			this.cmdHabilitaSensor.BeginInit();
			this.cmdHabilitaSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1D, 0D, 0D, 1.0666666666666667D, 101D, 38D);
			this.cmdHabilitaSensor.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.FalseText = "Desabilitado";
			this.cmdHabilitaSensor.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaSensor.FontScale = false;
			this.cmdHabilitaSensor.Name = "cmdHabilitaSensor";
			this.cmdHabilitaSensor.TagName = "CMD_HABILITA_SENSOR";
			this.cmdHabilitaSensor.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.TrueText = "Habilitado";
			this.cmdHabilitaSensor.Value = false;
			this.cmdHabilitaSensor.EndInit();
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(30D)), ((float)(30D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.ImageName = "SE.App2Base.HMI:libImages.maintenance_data_v2";
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("Faceplate3", NxtControl.GuiFramework.MouseButtonType.Click));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// fpAjustes
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(288D)), ((float)(192D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cmdHabilitaSensor,
			this.stpRangeMinimo,
			this.freeText1,
			this.stpRangeMaximo,
			this.freeText2,
			this.drawnButton1});
			this.Size = new System.Drawing.Size(288, 192);

		}
		private System.HMI.Symbols.Base.TextBox<float> stpRangeMinimo;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> stpRangeMaximo;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaSensor;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		#endregion
	}
}
