/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 11/03/2026
 * Tempo: 16:46
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.PreTratamentoPreliminar
{
	/// <summary>
	/// Summary description for fpDuvidas.
	/// </summary>
	partial class fpDuvidas
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.rectangle1 = new NxtControl.GuiFramework.Rectangle();
			this.label14 = new NxtControl.GuiFramework.Label();
			this.rectangle2 = new NxtControl.GuiFramework.Rectangle();
			this.label15 = new NxtControl.GuiFramework.Label();
			this.rectangle3 = new NxtControl.GuiFramework.Rectangle();
			this.label16 = new NxtControl.GuiFramework.Label();
			this.rectangle4 = new NxtControl.GuiFramework.Rectangle();
			this.label17 = new NxtControl.GuiFramework.Label();
			this.label18 = new NxtControl.GuiFramework.Label();
			// 
			// rectangle1
			// 
			this.rectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(32D)), ((float)(24D)), ((float)(24D)));
			this.rectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Green"));
			this.rectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle1.Name = "rectangle1";
			// 
			// label14
			// 
			this.label14.AngleIgnore = true;
			this.label14.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label14.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(36D)), ((float)(160D)), ((float)(17D)));
			this.label14.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label14.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.label14.FontScale = true;
			this.label14.Name = "label14";
			this.label14.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label14.Text = "Desligado/Fechado";
			this.label14.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label14.TextAutoSizeHorizontalOffset = 10;
			this.label14.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label14.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// rectangle2
			// 
			this.rectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(64D)), ((float)(24D)), ((float)(24D)));
			this.rectangle2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Red"));
			this.rectangle2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle2.Name = "rectangle2";
			// 
			// label15
			// 
			this.label15.AngleIgnore = true;
			this.label15.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label15.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(68D)), ((float)(142D)), ((float)(17D)));
			this.label15.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label15.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.label15.FontScale = true;
			this.label15.Name = "label15";
			this.label15.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label15.Text = "Ligado/Aberto";
			this.label15.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label15.TextAutoSizeHorizontalOffset = 10;
			this.label15.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label15.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// rectangle3
			// 
			this.rectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(96D)), ((float)(24D)), ((float)(24D)));
			this.rectangle3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Yellow"));
			this.rectangle3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle3.Name = "rectangle3";
			// 
			// label16
			// 
			this.label16.AngleIgnore = true;
			this.label16.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label16.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(100D)), ((float)(134D)), ((float)(17D)));
			this.label16.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label16.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.label16.FontScale = true;
			this.label16.Name = "label16";
			this.label16.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label16.Text = "Falha/Alarme";
			this.label16.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label16.TextAutoSizeHorizontalOffset = 10;
			this.label16.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label16.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// rectangle4
			// 
			this.rectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(16D)), ((float)(128D)), ((float)(24D)), ((float)(24D)));
			this.rectangle4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Blue"));
			this.rectangle4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.rectangle4.Name = "rectangle4";
			// 
			// label17
			// 
			this.label17.AngleIgnore = true;
			this.label17.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label17.Bounds = new NxtControl.Drawing.RectF(((float)(48D)), ((float)(132D)), ((float)(134D)), ((float)(17D)));
			this.label17.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label17.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.label17.FontScale = true;
			this.label17.Name = "label17";
			this.label17.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label17.Text = "Manutenção";
			this.label17.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.label17.TextAutoSizeHorizontalOffset = 10;
			this.label17.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label17.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// label18
			// 
			this.label18.AngleIgnore = true;
			this.label18.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.label18.Bounds = new NxtControl.Drawing.RectF(((float)(40D)), ((float)(5D)), ((float)(134D)), ((float)(17D)));
			this.label18.Brush = new NxtControl.Drawing.Brush("LabelBrush");
			this.label18.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.label18.FontScale = true;
			this.label18.Name = "label18";
			this.label18.Pen = new NxtControl.Drawing.Pen("LabelPen");
			this.label18.Text = "Legenda";
			this.label18.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleCenter;
			this.label18.TextAutoSizeHorizontalOffset = 10;
			this.label18.TextColor = new NxtControl.Drawing.Color("LabelTextColor");
			this.label18.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// fpDuvidas
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(208D)), ((float)(160D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.rectangle1,
			this.label14,
			this.rectangle2,
			this.label15,
			this.rectangle3,
			this.label16,
			this.rectangle4,
			this.label17,
			this.label18});
			this.Size = new System.Drawing.Size(208, 160);

		}
		private NxtControl.GuiFramework.Rectangle rectangle1;
		private NxtControl.GuiFramework.Label label14;
		private NxtControl.GuiFramework.Rectangle rectangle2;
		private NxtControl.GuiFramework.Label label15;
		private NxtControl.GuiFramework.Rectangle rectangle3;
		private NxtControl.GuiFramework.Label label16;
		private NxtControl.GuiFramework.Rectangle rectangle4;
		private NxtControl.GuiFramework.Label label17;
		private NxtControl.GuiFramework.Label label18;
		#endregion
	}
}
