/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/9/2026
 * Time: 5:43 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Nivel_4a20
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
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.stpAlturaMaxima = new System.HMI.Symbols.Base.TextBox<float>();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.cmdHabilitaSensor = new System.HMI.Symbols.Base.CheckButton();
			// 
			// stpRangeMinimo
			// 
			this.stpRangeMinimo.BeginInit();
			this.stpRangeMinimo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 168D, 109D);
			this.stpRangeMinimo.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpRangeMinimo.MaximumTag = null;
			this.stpRangeMinimo.MinimumTag = null;
			this.stpRangeMinimo.Name = "stpRangeMinimo";
			this.stpRangeMinimo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpRangeMinimo.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpRangeMinimo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpRangeMinimo.TagName = "stpRangeMinimo";
			this.stpRangeMinimo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpRangeMinimo.Value = 0F;
			this.stpRangeMinimo.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 109D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Range mínimo";
			// 
			// stpRangeMaximo
			// 
			this.stpRangeMaximo.BeginInit();
			this.stpRangeMaximo.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 168D, 157D);
			this.stpRangeMaximo.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpRangeMaximo.MaximumTag = null;
			this.stpRangeMaximo.MinimumTag = null;
			this.stpRangeMaximo.Name = "stpRangeMaximo";
			this.stpRangeMaximo.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpRangeMaximo.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpRangeMaximo.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpRangeMaximo.TagName = "stpRangeMaximo";
			this.stpRangeMaximo.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpRangeMaximo.Value = 0F;
			this.stpRangeMaximo.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 159D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Range máximo";
			// 
			// drawnButton1
			// 
			this.drawnButton1.Bounds = new NxtControl.Drawing.RectF(((float)(8D)), ((float)(8D)), ((float)(30D)), ((float)(30D)));
			this.drawnButton1.Brush = new NxtControl.Drawing.Brush("Transparent");
			this.drawnButton1.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.drawnButton1.ImageName = "SE.App2Base.HMI:libImages.maintenance_data_v2";
			this.drawnButton1.Name = "drawnButton1";
			this.drawnButton1.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("Faceplate3", NxtControl.GuiFramework.MouseButtonType.None));
			this.drawnButton1.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.drawnButton1.Radius = 4D;
			this.drawnButton1.TextColor = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColor");
			this.drawnButton1.TextColorMouseDown = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.ButtonTextColorMouseDown");
			this.drawnButton1.Use3DEffect = false;
			// 
			// stpAlturaMaxima
			// 
			this.stpAlturaMaxima.BeginInit();
			this.stpAlturaMaxima.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.73333333333333328D, 0D, 0D, 1D, 168D, 205D);
			this.stpAlturaMaxima.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.stpAlturaMaxima.MaximumTag = null;
			this.stpAlturaMaxima.MinimumTag = null;
			this.stpAlturaMaxima.Name = "stpAlturaMaxima";
			this.stpAlturaMaxima.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpAlturaMaxima.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpAlturaMaxima.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpAlturaMaxima.TagName = "stpAlturaMaxima";
			this.stpAlturaMaxima.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpAlturaMaxima.Value = 0F;
			this.stpAlturaMaxima.EndInit();
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(8D, 210D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Altura máxima";
			// 
			// cmdHabilitaSensor
			// 
			this.cmdHabilitaSensor.BeginInit();
			this.cmdHabilitaSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.1D, 0D, 0D, 1.0666666666666667D, 96D, 40D);
			this.cmdHabilitaSensor.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.FalseText = "Desabilitado";
			this.cmdHabilitaSensor.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaSensor.FontScale = false;
			this.cmdHabilitaSensor.Name = "cmdHabilitaSensor";
			this.cmdHabilitaSensor.TagName = "cmdHabilitaSensor";
			this.cmdHabilitaSensor.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.TrueText = "Habilitado";
			this.cmdHabilitaSensor.Value = false;
			this.cmdHabilitaSensor.EndInit();
			// 
			// fpAjustes
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(288D)), ((float)(256D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.stpRangeMinimo,
			this.freeText1,
			this.stpRangeMaximo,
			this.freeText2,
			this.drawnButton1,
			this.stpAlturaMaxima,
			this.freeText3,
			this.cmdHabilitaSensor});
			this.Size = new System.Drawing.Size(288, 256);

		}
		private System.HMI.Symbols.Base.TextBox<float> stpRangeMinimo;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> stpRangeMaximo;
		private NxtControl.GuiFramework.FreeText freeText2;
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private System.HMI.Symbols.Base.TextBox<float> stpAlturaMaxima;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaSensor;
		#endregion
	}
}
