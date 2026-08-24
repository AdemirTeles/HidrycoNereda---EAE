/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 1/29/2026
 * Time: 10:57 AM
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
	/// Summary description for Faceplate1.
	/// </summary>
	partial class fpAlarmes
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cmdHabilitaAlarmeLL = new System.HMI.Symbols.Base.CheckButton();
			this.freeText1 = new NxtControl.GuiFramework.FreeText();
			this.stpAlarmeLL = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpTempoAlarmeLL = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.cmdHabilitaAlarmeL = new System.HMI.Symbols.Base.CheckButton();
			this.stpAlarmeL = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpTempoAlarmeL = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.cmdHabilitaAlarmeH = new System.HMI.Symbols.Base.CheckButton();
			this.stpAlarmeH = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpTempoAlarmeH = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.cmdHabilitaAlarmeHH = new System.HMI.Symbols.Base.CheckButton();
			this.stpAlarmeHH = new System.HMI.Symbols.Base.TextBox<float>();
			this.stpTempoAlarmeHH = new System.HMI.Symbols.Base.TextBox<ushort>();
			this.freeText5 = new NxtControl.GuiFramework.FreeText();
			this.freeText9 = new NxtControl.GuiFramework.FreeText();
			this.freeText10 = new NxtControl.GuiFramework.FreeText();
			this.freeText11 = new NxtControl.GuiFramework.FreeText();
			this.freeText12 = new NxtControl.GuiFramework.FreeText();
			this.freeText2 = new NxtControl.GuiFramework.FreeText();
			this.freeText3 = new NxtControl.GuiFramework.FreeText();
			this.freeText6 = new NxtControl.GuiFramework.FreeText();
			this.freeText4 = new NxtControl.GuiFramework.FreeText();
			this.freeText7 = new NxtControl.GuiFramework.FreeText();
			this.freeText8 = new NxtControl.GuiFramework.FreeText();
			this.btnResetAlarmes = new NxtControl.GuiFramework.DrawnButton();
			// 
			// cmdHabilitaAlarmeLL
			// 
			this.cmdHabilitaAlarmeLL.BeginInit();
			this.cmdHabilitaAlarmeLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 254D);
			this.cmdHabilitaAlarmeLL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeLL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeLL.FalseText = "Desabilitado";
			this.cmdHabilitaAlarmeLL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaAlarmeLL.FontScale = false;
			this.cmdHabilitaAlarmeLL.Name = "cmdHabilitaAlarmeLL";
			this.cmdHabilitaAlarmeLL.TagName = "cmdHabilitaAlarmeLL";
			this.cmdHabilitaAlarmeLL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeLL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeLL.TrueText = "Habilitado";
			this.cmdHabilitaAlarmeLL.Value = false;
			this.cmdHabilitaAlarmeLL.EndInit();
			// 
			// freeText1
			// 
			this.freeText1.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText1.Location = new NxtControl.Drawing.PointF(8D, 232D);
			this.freeText1.Name = "freeText1";
			this.freeText1.Text = "Alarme LL";
			// 
			// stpAlarmeLL
			// 
			this.stpAlarmeLL.BeginInit();
			this.stpAlarmeLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 104D, 256D);
			this.stpAlarmeLL.MaximumTag = null;
			this.stpAlarmeLL.MinimumTag = null;
			this.stpAlarmeLL.Name = "stpAlarmeLL";
			this.stpAlarmeLL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpAlarmeLL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpAlarmeLL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpAlarmeLL.TagName = "stpAlarmeLL";
			this.stpAlarmeLL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpAlarmeLL.UseInputPad = true;
			this.stpAlarmeLL.Value = 0F;
			this.stpAlarmeLL.EndInit();
			// 
			// stpTempoAlarmeLL
			// 
			this.stpTempoAlarmeLL.BeginInit();
			this.stpTempoAlarmeLL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 216D, 256D);
			this.stpTempoAlarmeLL.MaximumTag = null;
			this.stpTempoAlarmeLL.MinimumTag = null;
			this.stpTempoAlarmeLL.Name = "stpTempoAlarmeLL";
			this.stpTempoAlarmeLL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpTempoAlarmeLL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoAlarmeLL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoAlarmeLL.TagName = "stpTempoAlarmeLL";
			this.stpTempoAlarmeLL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoAlarmeLL.UseInputPad = true;
			this.stpTempoAlarmeLL.UseRange = true;
			this.stpTempoAlarmeLL.Value = ((ushort)(0));
			this.stpTempoAlarmeLL.EndInit();
			// 
			// cmdHabilitaAlarmeL
			// 
			this.cmdHabilitaAlarmeL.BeginInit();
			this.cmdHabilitaAlarmeL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 182D);
			this.cmdHabilitaAlarmeL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeL.FalseText = "Desabilitado";
			this.cmdHabilitaAlarmeL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaAlarmeL.FontScale = false;
			this.cmdHabilitaAlarmeL.Name = "cmdHabilitaAlarmeL";
			this.cmdHabilitaAlarmeL.TagName = "cmdHabilitaAlarmeL";
			this.cmdHabilitaAlarmeL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeL.TrueText = "Habilitado";
			this.cmdHabilitaAlarmeL.Value = false;
			this.cmdHabilitaAlarmeL.EndInit();
			// 
			// stpAlarmeL
			// 
			this.stpAlarmeL.BeginInit();
			this.stpAlarmeL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 104D, 184D);
			this.stpAlarmeL.MaximumTag = null;
			this.stpAlarmeL.MinimumTag = null;
			this.stpAlarmeL.Name = "stpAlarmeL";
			this.stpAlarmeL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpAlarmeL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpAlarmeL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpAlarmeL.TagName = "stpAlarmeL";
			this.stpAlarmeL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpAlarmeL.UseInputPad = true;
			this.stpAlarmeL.Value = 0F;
			this.stpAlarmeL.EndInit();
			// 
			// stpTempoAlarmeL
			// 
			this.stpTempoAlarmeL.BeginInit();
			this.stpTempoAlarmeL.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 216D, 184D);
			this.stpTempoAlarmeL.MaximumTag = null;
			this.stpTempoAlarmeL.MinimumTag = null;
			this.stpTempoAlarmeL.Name = "stpTempoAlarmeL";
			this.stpTempoAlarmeL.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpTempoAlarmeL.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoAlarmeL.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoAlarmeL.TagName = "stpTempoAlarmeL";
			this.stpTempoAlarmeL.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoAlarmeL.UseInputPad = true;
			this.stpTempoAlarmeL.UseRange = true;
			this.stpTempoAlarmeL.Value = ((ushort)(0));
			this.stpTempoAlarmeL.EndInit();
			// 
			// cmdHabilitaAlarmeH
			// 
			this.cmdHabilitaAlarmeH.BeginInit();
			this.cmdHabilitaAlarmeH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 110D);
			this.cmdHabilitaAlarmeH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeH.FalseText = "Desabilitado";
			this.cmdHabilitaAlarmeH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaAlarmeH.FontScale = false;
			this.cmdHabilitaAlarmeH.Name = "cmdHabilitaAlarmeH";
			this.cmdHabilitaAlarmeH.TagName = "cmdHabilitaAlarmeH";
			this.cmdHabilitaAlarmeH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeH.TrueText = "Habilitado";
			this.cmdHabilitaAlarmeH.Value = false;
			this.cmdHabilitaAlarmeH.EndInit();
			// 
			// stpAlarmeH
			// 
			this.stpAlarmeH.BeginInit();
			this.stpAlarmeH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 104D, 112D);
			this.stpAlarmeH.MaximumTag = null;
			this.stpAlarmeH.MinimumTag = null;
			this.stpAlarmeH.Name = "stpAlarmeH";
			this.stpAlarmeH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpAlarmeH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpAlarmeH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpAlarmeH.TagName = "stpAlarmeH";
			this.stpAlarmeH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpAlarmeH.UseInputPad = true;
			this.stpAlarmeH.Value = 0F;
			this.stpAlarmeH.EndInit();
			// 
			// stpTempoAlarmeH
			// 
			this.stpTempoAlarmeH.BeginInit();
			this.stpTempoAlarmeH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 216D, 112D);
			this.stpTempoAlarmeH.MaximumTag = null;
			this.stpTempoAlarmeH.MinimumTag = null;
			this.stpTempoAlarmeH.Name = "stpTempoAlarmeH";
			this.stpTempoAlarmeH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpTempoAlarmeH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoAlarmeH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoAlarmeH.TagName = "stpTempoAlarmeH";
			this.stpTempoAlarmeH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoAlarmeH.UseInputPad = true;
			this.stpTempoAlarmeH.UseRange = true;
			this.stpTempoAlarmeH.Value = ((ushort)(0));
			this.stpTempoAlarmeH.EndInit();
			// 
			// cmdHabilitaAlarmeHH
			// 
			this.cmdHabilitaAlarmeHH.BeginInit();
			this.cmdHabilitaAlarmeHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 38D);
			this.cmdHabilitaAlarmeHH.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeHH.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeHH.FalseText = "Desabilitado";
			this.cmdHabilitaAlarmeHH.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.cmdHabilitaAlarmeHH.FontScale = false;
			this.cmdHabilitaAlarmeHH.Name = "cmdHabilitaAlarmeHH";
			this.cmdHabilitaAlarmeHH.TagName = "cmdHabilitaAlarmeHH";
			this.cmdHabilitaAlarmeHH.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeHH.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.cmdHabilitaAlarmeHH.TrueText = "Habilitado";
			this.cmdHabilitaAlarmeHH.Value = false;
			this.cmdHabilitaAlarmeHH.EndInit();
			// 
			// stpAlarmeHH
			// 
			this.stpAlarmeHH.BeginInit();
			this.stpAlarmeHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.58666666666666667D, 0D, 0D, 1D, 104D, 40D);
			this.stpAlarmeHH.MaximumTag = null;
			this.stpAlarmeHH.MinimumTag = null;
			this.stpAlarmeHH.Name = "stpAlarmeHH";
			this.stpAlarmeHH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpAlarmeHH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpAlarmeHH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpAlarmeHH.TagName = "stpAlarmeHH";
			this.stpAlarmeHH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpAlarmeHH.UseInputPad = true;
			this.stpAlarmeHH.Value = 0F;
			this.stpAlarmeHH.EndInit();
			// 
			// stpTempoAlarmeHH
			// 
			this.stpTempoAlarmeHH.BeginInit();
			this.stpTempoAlarmeHH.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.48D, 0D, 0D, 1D, 216D, 40D);
			this.stpTempoAlarmeHH.MaximumTag = null;
			this.stpTempoAlarmeHH.MinimumTag = null;
			this.stpTempoAlarmeHH.Name = "stpTempoAlarmeHH";
			this.stpTempoAlarmeHH.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.stpTempoAlarmeHH.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.stpTempoAlarmeHH.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.stpTempoAlarmeHH.TagName = "stpTempoAlarmeHH";
			this.stpTempoAlarmeHH.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.stpTempoAlarmeHH.UseInputPad = true;
			this.stpTempoAlarmeHH.UseRange = true;
			this.stpTempoAlarmeHH.Value = ((ushort)(0));
			this.stpTempoAlarmeHH.EndInit();
			// 
			// freeText5
			// 
			this.freeText5.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText5.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText5.Location = new NxtControl.Drawing.PointF(216D, 232D);
			this.freeText5.Name = "freeText5";
			this.freeText5.Text = "Delay LL";
			// 
			// freeText9
			// 
			this.freeText9.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText9.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText9.Location = new NxtControl.Drawing.PointF(104D, 232D);
			this.freeText9.Name = "freeText9";
			this.freeText9.Text = "Setpoint LL";
			// 
			// freeText10
			// 
			this.freeText10.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText10.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText10.Location = new NxtControl.Drawing.PointF(8D, 160D);
			this.freeText10.Name = "freeText10";
			this.freeText10.Text = "Alarme L";
			// 
			// freeText11
			// 
			this.freeText11.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText11.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText11.Location = new NxtControl.Drawing.PointF(216D, 160D);
			this.freeText11.Name = "freeText11";
			this.freeText11.Text = "Delay L";
			// 
			// freeText12
			// 
			this.freeText12.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText12.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText12.Location = new NxtControl.Drawing.PointF(104D, 160D);
			this.freeText12.Name = "freeText12";
			this.freeText12.Text = "Setpoint L";
			// 
			// freeText2
			// 
			this.freeText2.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText2.Location = new NxtControl.Drawing.PointF(8D, 88D);
			this.freeText2.Name = "freeText2";
			this.freeText2.Text = "Alarme H";
			// 
			// freeText3
			// 
			this.freeText3.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText3.Location = new NxtControl.Drawing.PointF(216D, 88D);
			this.freeText3.Name = "freeText3";
			this.freeText3.Text = "Delay H";
			// 
			// freeText6
			// 
			this.freeText6.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText6.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText6.Location = new NxtControl.Drawing.PointF(104D, 88D);
			this.freeText6.Name = "freeText6";
			this.freeText6.Text = "Setpoint H";
			// 
			// freeText4
			// 
			this.freeText4.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText4.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText4.Location = new NxtControl.Drawing.PointF(8D, 16D);
			this.freeText4.Name = "freeText4";
			this.freeText4.Text = "Alarme HH";
			// 
			// freeText7
			// 
			this.freeText7.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText7.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText7.Location = new NxtControl.Drawing.PointF(216D, 16D);
			this.freeText7.Name = "freeText7";
			this.freeText7.Text = "Delay HH";
			// 
			// freeText8
			// 
			this.freeText8.Color = new NxtControl.Drawing.Color("Hidryco.HidrycoLib.LabelTextColor");
			this.freeText8.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular);
			this.freeText8.Location = new NxtControl.Drawing.PointF(104D, 16D);
			this.freeText8.Name = "freeText8";
			this.freeText8.Text = "Setpoint HH";
			// 
			// btnResetAlarmes
			// 
			this.btnResetAlarmes.Bounds = new NxtControl.Drawing.RectF(((float)(108D)), ((float)(299D)), ((float)(80D)), ((float)(30D)));
			this.btnResetAlarmes.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.btnResetAlarmes.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.btnResetAlarmes.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.btnResetAlarmes.Name = "btnResetAlarmes";
			this.btnResetAlarmes.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.btnResetAlarmes.Radius = 4D;
			this.btnResetAlarmes.Text = "Reset Alarmes";
			this.btnResetAlarmes.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.btnResetAlarmes.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.btnResetAlarmes.Use3DEffect = false;
			this.btnResetAlarmes.Click += new System.EventHandler(this.BtnResetAlarmesClick);
			// 
			// fpAlarmes
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(304D)), ((float)(344D)));
			this.Brush = new NxtControl.Drawing.Brush("FaceplateBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.btnResetAlarmes,
			this.cmdHabilitaAlarmeHH,
			this.stpAlarmeHH,
			this.stpTempoAlarmeHH,
			this.freeText4,
			this.freeText7,
			this.freeText8,
			this.cmdHabilitaAlarmeH,
			this.stpAlarmeH,
			this.stpTempoAlarmeH,
			this.freeText2,
			this.freeText3,
			this.freeText6,
			this.cmdHabilitaAlarmeL,
			this.stpAlarmeL,
			this.stpTempoAlarmeL,
			this.freeText10,
			this.freeText11,
			this.freeText12,
			this.cmdHabilitaAlarmeLL,
			this.freeText1,
			this.stpAlarmeLL,
			this.stpTempoAlarmeLL,
			this.freeText5,
			this.freeText9});
			this.Size = new System.Drawing.Size(304, 344);

		}
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaAlarmeLL;
		private NxtControl.GuiFramework.FreeText freeText1;
		private System.HMI.Symbols.Base.TextBox<float> stpAlarmeLL;
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoAlarmeLL;
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaAlarmeL;
		private NxtControl.GuiFramework.FreeText freeText2;
		private System.HMI.Symbols.Base.TextBox<float> stpAlarmeL;
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoAlarmeL;
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaAlarmeH;
		private NxtControl.GuiFramework.FreeText freeText3;
		private System.HMI.Symbols.Base.TextBox<float> stpAlarmeH;
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoAlarmeH;
		private System.HMI.Symbols.Base.CheckButton cmdHabilitaAlarmeHH;
		private NxtControl.GuiFramework.FreeText freeText4;
		private System.HMI.Symbols.Base.TextBox<float> stpAlarmeHH;
		private System.HMI.Symbols.Base.TextBox<ushort> stpTempoAlarmeHH;
		private NxtControl.GuiFramework.FreeText freeText5;
		private NxtControl.GuiFramework.FreeText freeText6;
		private NxtControl.GuiFramework.FreeText freeText7;
		private NxtControl.GuiFramework.FreeText freeText8;
		private NxtControl.GuiFramework.FreeText freeText9;
		private NxtControl.GuiFramework.FreeText freeText10;
		private NxtControl.GuiFramework.FreeText freeText11;
		private NxtControl.GuiFramework.FreeText freeText12;
		private NxtControl.GuiFramework.DrawnButton btnResetAlarmes;
		#endregion
	}
}
