/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 02/03/2026
 * Tempo: 13:20
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Sensor_Comunicacao
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
			this.drawnButton1 = new NxtControl.GuiFramework.DrawnButton();
			this.cmdHabilitaSensor = new System.HMI.Symbols.Base.CheckButton();
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
			// cmdHabilitaSensor
			// 
			this.cmdHabilitaSensor.BeginInit();
			this.cmdHabilitaSensor.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 81D, 48D);
			this.cmdHabilitaSensor.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaSensor.FalseText = "Desabilitado";
			this.cmdHabilitaSensor.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaSensor.FontScale = true;
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
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(236D)), ((float)(104D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.drawnButton1,
			this.cmdHabilitaSensor});
			this.Size = new System.Drawing.Size(236, 104);

		}
		private NxtControl.GuiFramework.DrawnButton drawnButton1;
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaSensor;
		#endregion
	}
}
