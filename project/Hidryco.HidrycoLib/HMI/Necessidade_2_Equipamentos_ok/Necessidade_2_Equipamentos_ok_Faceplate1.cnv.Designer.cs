/*
 * Criado pelo EcoStruxure Automation Expert.
 * Usuário:  
 * Data: 26/02/2026
 * Tempo: 09:49
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Necessidade_2_Equipamentos_ok
{
	/// <summary>
	/// Summary description for Faceplate1.
	/// </summary>
	partial class Faceplate1
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			this.cmdHabilita = new System.HMI.Symbols.Base.CheckButton();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.stsQuantidadeEquipamentos = new System.HMI.Symbols.Base.Label<ushort>();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.line1 = new NxtControl.GuiFramework.Line();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.line4 = new NxtControl.GuiFramework.Line();
			this.line5 = new NxtControl.GuiFramework.Line();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.textBox_11 = new System.HMI.Symbols.Base.TextBox<float>();
			this.textBox_12 = new System.HMI.Symbols.Base.TextBox<float>();
			this.textBox_13 = new System.HMI.Symbols.Base.TextBox<float>();
			this.textBox_14 = new System.HMI.Symbols.Base.TextBox<float>();
			// 
			// cmdHabilita
			// 
			this.cmdHabilita.BeginInit();
			this.cmdHabilita.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 170D, 12D);
			this.cmdHabilita.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.FalseText = "Habilitar";
			this.cmdHabilita.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilita.FontScale = false;
			this.cmdHabilita.Name = "cmdHabilita";
			this.cmdHabilita.TagName = "cmdHabilita";
			this.cmdHabilita.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilita.TrueText = "Desabilitar";
			this.cmdHabilita.Value = false;
			this.cmdHabilita.EndInit();
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(7D, 204D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Setpoint limite\r\nfaixa 3";
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(7D, 348D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Setpoint limite\r\nfaixa 1";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(7D, 65D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Quantidade \r\nEquipamentos";
			// 
			// stsQuantidadeEquipamentos
			// 
			this.stsQuantidadeEquipamentos.BeginInit();
			this.stsQuantidadeEquipamentos.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.stsQuantidadeEquipamentos.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1.4285714285714286D, 142D, 72D);
			this.stsQuantidadeEquipamentos.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
			this.stsQuantidadeEquipamentos.FontScale = false;
			this.stsQuantidadeEquipamentos.IsOnlyInput = true;
			this.stsQuantidadeEquipamentos.LeadingZeros = ((uint)(0u));
			this.stsQuantidadeEquipamentos.Name = "stsQuantidadeEquipamentos";
			this.stsQuantidadeEquipamentos.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush("LabelBrush"));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.stsQuantidadeEquipamentos.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.stsQuantidadeEquipamentos.TagName = "stsNecessidadeEquipamentos";
			this.stsQuantidadeEquipamentos.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.stsQuantidadeEquipamentos.EndInit();
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText9.Location = new NxtControl.Drawing.PointF(7D, 132D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Setpoint limite\r\nfaixa 4";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.freeText10.Location = new NxtControl.Drawing.PointF(7D, 276D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Setpoint limite\r\nfaixa 2";
			// 
			// line1
			// 
			this.line1.EndPoint = new NxtControl.Drawing.PointF(272D, 391D);
			this.line1.Name = "line1";
			this.line1.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line1.StartPoint = new NxtControl.Drawing.PointF(272D, 119D);
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(392D, 150D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line2.StartPoint = new NxtControl.Drawing.PointF(224D, 150D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(392D, 366D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line3.StartPoint = new NxtControl.Drawing.PointF(224D, 366D);
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText11.Location = new NxtControl.Drawing.PointF(280D, 349D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Desliga equipamento 1";
			// 
			// line4
			// 
			this.line4.EndPoint = new NxtControl.Drawing.PointF(392D, 222D);
			this.line4.Name = "line4";
			this.line4.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line4.StartPoint = new NxtControl.Drawing.PointF(224D, 222D);
			// 
			// line5
			// 
			this.line5.EndPoint = new NxtControl.Drawing.PointF(392D, 294D);
			this.line5.Name = "line5";
			this.line5.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.line5.StartPoint = new NxtControl.Drawing.PointF(224D, 294D);
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(243D)), ((float)(287D)), ((float)(20D)), ((float)(20D)));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(253D, 287D),
			new NxtControl.Drawing.PointF(258D, 287D),
			new NxtControl.Drawing.PointF(258D, 297D),
			new NxtControl.Drawing.PointF(263D, 297D),
			new NxtControl.Drawing.PointF(253D, 307D),
			new NxtControl.Drawing.PointF(243D, 297D),
			new NxtControl.Drawing.PointF(248D, 297D),
			new NxtControl.Drawing.PointF(248D, 287D)});
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(243D)), ((float)(137D)), ((float)(20D)), ((float)(20D)));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(253D, 157D),
			new NxtControl.Drawing.PointF(248D, 157D),
			new NxtControl.Drawing.PointF(248D, 147D),
			new NxtControl.Drawing.PointF(243D, 147D),
			new NxtControl.Drawing.PointF(253D, 137D),
			new NxtControl.Drawing.PointF(263D, 147D),
			new NxtControl.Drawing.PointF(258D, 147D),
			new NxtControl.Drawing.PointF(258D, 157D)});
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(243D)), ((float)(360D)), ((float)(20D)), ((float)(20D)));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(253D, 360D),
			new NxtControl.Drawing.PointF(258D, 360D),
			new NxtControl.Drawing.PointF(258D, 370D),
			new NxtControl.Drawing.PointF(263D, 370D),
			new NxtControl.Drawing.PointF(253D, 380D),
			new NxtControl.Drawing.PointF(243D, 370D),
			new NxtControl.Drawing.PointF(248D, 370D),
			new NxtControl.Drawing.PointF(248D, 360D)});
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(243D)), ((float)(209D)), ((float)(20D)), ((float)(20D)));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(253D, 229D),
			new NxtControl.Drawing.PointF(248D, 229D),
			new NxtControl.Drawing.PointF(248D, 219D),
			new NxtControl.Drawing.PointF(243D, 219D),
			new NxtControl.Drawing.PointF(253D, 209D),
			new NxtControl.Drawing.PointF(263D, 219D),
			new NxtControl.Drawing.PointF(258D, 219D),
			new NxtControl.Drawing.PointF(258D, 229D)});
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText4.Location = new NxtControl.Drawing.PointF(280D, 205D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Liga equipamento 1";
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText5.Location = new NxtControl.Drawing.PointF(280D, 133D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Liga equipamento 2";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.freeText6.Location = new NxtControl.Drawing.PointF(280D, 277D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Desliga equipamento 2";
			// 
			// textBox_11
			// 
			this.textBox_11.BeginInit();
			this.textBox_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 123D, 354D);
			this.textBox_11.MaximumTag = null;
			this.textBox_11.MinimumTag = null;
			this.textBox_11.Name = "textBox_11";
			this.textBox_11.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.textBox_11.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.textBox_11.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_11.TagName = "stpLimiteFaixa1";
			this.textBox_11.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.textBox_11.UseInputPad = true;
			this.textBox_11.Value = 0F;
			this.textBox_11.EndInit();
			// 
			// textBox_12
			// 
			this.textBox_12.BeginInit();
			this.textBox_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 123D, 282D);
			this.textBox_12.MaximumTag = null;
			this.textBox_12.MinimumTag = null;
			this.textBox_12.Name = "textBox_12";
			this.textBox_12.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.textBox_12.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.textBox_12.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_12.TagName = "stpLimiteFaixa2";
			this.textBox_12.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.textBox_12.UseInputPad = true;
			this.textBox_12.Value = 0F;
			this.textBox_12.EndInit();
			// 
			// textBox_13
			// 
			this.textBox_13.BeginInit();
			this.textBox_13.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 123D, 210D);
			this.textBox_13.MaximumTag = null;
			this.textBox_13.MinimumTag = null;
			this.textBox_13.Name = "textBox_13";
			this.textBox_13.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.textBox_13.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.textBox_13.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_13.TagName = "stpLimiteFaixa3";
			this.textBox_13.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.textBox_13.UseInputPad = true;
			this.textBox_13.Value = 0F;
			this.textBox_13.EndInit();
			// 
			// textBox_14
			// 
			this.textBox_14.BeginInit();
			this.textBox_14.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 1D, 123D, 138D);
			this.textBox_14.MaximumTag = null;
			this.textBox_14.MinimumTag = null;
			this.textBox_14.Name = "textBox_14";
			this.textBox_14.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.textBox_14.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.textBox_14.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.textBox_14.TagName = "stpLimiteFaixa4";
			this.textBox_14.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.textBox_14.UseInputPad = true;
			this.textBox_14.Value = 0F;
			this.textBox_14.EndInit();
			// 
			// Faceplate1
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(432D)), ((float)(400D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cmdHabilita,
			this.freeText2,
			this.freeText1,
			this.freeText3,
			this.stsQuantidadeEquipamentos,
			this.freeText9,
			this.freeText10,
			this.line1,
			this.line2,
			this.line3,
			this.freeText11,
			this.line4,
			this.line5,
			this.polygon4,
			this.polygon1,
			this.polygon2,
			this.polygon3,
			this.freeText4,
			this.freeText5,
			this.freeText6,
			this.textBox_11,
			this.textBox_12,
			this.textBox_13,
			this.textBox_14});
			this.Size = new System.Drawing.Size(432, 400);

		}
		private System.HMI.Symbols.Base.CheckButton cmdHabilita;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<ushort> stpLimiteFaixa3;
		private NxtControl.GuiFramework.FreeText freeText1;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.Label<ushort> stsQuantidadeEquipamentos;
		private System.HMI.Symbols.Base.TextBox<ushort> stpLimiteFaixa2;
		private NxtControl.GuiFramework.FreeText freeText9;
		private System.HMI.Symbols.Base.TextBox<ushort> stpLimiteFaixa4;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.Line line1;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.Line line4;
		private NxtControl.GuiFramework.Line line5;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.FreeText freeText4;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private System.HMI.Symbols.Base.TextBox<float> stpLimiteFaixa1;
		private System.HMI.Symbols.Base.TextBox<float> textBox_11;
		private System.HMI.Symbols.Base.TextBox<float> textBox_12;
		private System.HMI.Symbols.Base.TextBox<float> textBox_13;
		private System.HMI.Symbols.Base.TextBox<float> textBox_14;
		#endregion
	}
}
