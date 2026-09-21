using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace HMI.Main.Faceplates.PIDBase
{
	/// <summary>
	/// Summary description for fpDefault.
	/// </summary>
	partial class fpDefault
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary2 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary1 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary4 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary3 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary6 = new NxtControl.GuiFramework.PropertyDictionary();
			NxtControl.GuiFramework.PropertyDictionary propertyDictionary5 = new NxtControl.GuiFramework.PropertyDictionary();
			this.outProhibited = new NxtControl.GuiFramework.Rectangle();
			this.txtAutoSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtManualSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.txtCurrentOp = new System.HMI.Symbols.Base.TextBox<float>();
			this.Pv = new System.HMI.Symbols.Base.Execute<float>();
			this.OutMin = new System.HMI.Symbols.Base.Execute<float>();
			this.OutMax = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMin = new System.HMI.Symbols.Base.Execute<float>();
			this.PvMax = new System.HMI.Symbols.Base.Execute<float>();
			this.txtCurrentSp = new System.HMI.Symbols.Base.TextBox<float>();
			this.lblCurOut = new System.HMI.Symbols.Base.Label<float>();
			this.lblPv = new System.HMI.Symbols.Base.Label<float>();
			this.lblCurrentSp = new System.HMI.Symbols.Base.Label<float>();
			this.lblPidMode = new NxtControl.GuiFramework.Label();
			this.line2 = new NxtControl.GuiFramework.Line();
			this.line3 = new NxtControl.GuiFramework.Line();
			this.OutChProhibited = new System.HMI.Symbols.Base.Execute<bool>();
			this.TrackOutput = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentSp = new System.HMI.Symbols.Base.Execute<float>();
			this.PvSpGroup = new SE.App2Base.Graphics.SMeters();
			this.OpGroup = new SE.App2Base.Graphics.SMeters();
			this.labelS1 = new SE.App2Base.Graphics.LabelS();
			this.labelS2 = new SE.App2Base.Graphics.LabelS();
			this.labelS3 = new SE.App2Base.Graphics.LabelS();
			this.labelS4 = new SE.App2Base.Graphics.LabelS();
			this.labelS5 = new SE.App2Base.Graphics.LabelS();
			this.labelS6 = new SE.App2Base.Graphics.LabelS();
			this.labelS7 = new SE.App2Base.Graphics.LabelS();
			this.fpNavigationPane = new SE.App2Base.Graphics.FpNavigationPane();
			this.ownerSwitch = new SE.App2Base.Graphics.OwnerSwitchBasic();
			this.ownerStatus = new SE.App2Base.Graphics.OwnerStatusBasic();
			this.PidMode = new NxtControl.GuiFramework.TwoStateButton();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentMode = new System.HMI.Symbols.Base.Execute<short>();
			this.Mode = new System.HMI.Symbols.Base.Execute<short>();
			this.TrackSpInManual = new System.HMI.Symbols.Base.Execute<bool>();
			this.IlckCond = new System.HMI.Symbols.Base.Execute<bool>();
			this.CurrentSpText = new NxtControl.GuiFramework.DrawnTextBox();
			this.Sp = new System.HMI.Symbols.Base.Execute<float>();
			// 
			// outProhibited
			// 
			this.outProhibited.Bounds = new NxtControl.Drawing.RectF(((float)(222D)), ((float)(56D)), ((float)(16D)), ((float)(16D)));
			this.outProhibited.Brush = new NxtControl.Drawing.Brush(true);
			this.outProhibited.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.outProhibited.ImageName = "SE.App2Base.HMI:modeIcons.mode_unknown2";
			this.outProhibited.Name = "outProhibited";
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.outProhibited.Pen = new NxtControl.Drawing.Pen("Transparent");
			this.outProhibited.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Normal;
			this.outProhibited.Tooltip = "Forced Manual";
			this.outProhibited.Visible = false;
			// 
			// txtAutoSp
			// 
			this.txtAutoSp.BeginInit();
			this.txtAutoSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 328D);
			this.txtAutoSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtAutoSp.MaximumTag = null;
			this.txtAutoSp.MinimumTag = null;
			this.txtAutoSp.Name = "txtAutoSp";
			this.txtAutoSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtAutoSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtAutoSp.SecurityLevel = 3;
			this.txtAutoSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtAutoSp.TagName = "Sp";
			this.txtAutoSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtAutoSp.UseInputPad = true;
			this.txtAutoSp.UseRange = true;
			this.txtAutoSp.Value = 0F;
			this.txtAutoSp.EndInit();
			// 
			// txtManualSp
			// 
			this.txtManualSp.BeginInit();
			this.txtManualSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 358D);
			this.txtManualSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtManualSp.MaximumTag = null;
			this.txtManualSp.MinimumTag = null;
			this.txtManualSp.Name = "txtManualSp";
			this.txtManualSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtManualSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtManualSp.SecurityLevel = 3;
			this.txtManualSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtManualSp.TagName = "ManualSp";
			this.txtManualSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtManualSp.Tooltip = "Manual Setpoint";
			this.txtManualSp.UseInputPad = true;
			this.txtManualSp.UseRange = true;
			this.txtManualSp.Value = 0F;
			this.txtManualSp.EndInit();
			// 
			// txtCurrentOp
			// 
			this.txtCurrentOp.BeginInit();
			this.txtCurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6333333333333333D, 0D, 0D, 1D, 120D, 358D);
			this.txtCurrentOp.Enabled = false;
			this.txtCurrentOp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtCurrentOp.IsOnlyInput = true;
			this.txtCurrentOp.MaximumTag = null;
			this.txtCurrentOp.MinimumTag = null;
			this.txtCurrentOp.Name = "txtCurrentOp";
			this.txtCurrentOp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentOp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtCurrentOp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtCurrentOp.TagName = "CurrentOp";
			this.txtCurrentOp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtCurrentOp.Tooltip = "Current Output";
			this.txtCurrentOp.UseInputPad = true;
			this.txtCurrentOp.Value = 0F;
			this.txtCurrentOp.EndInit();
			// 
			// Pv
			// 
			this.Pv.BeginInit();
			this.Pv.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Pv.IsOnlyInput = true;
			this.Pv.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Pv.Name = "Pv";
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.Pv.SecurityLevel = 0;
			this.Pv.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Pv.TagName = "Pv";
			this.Pv.Value = 0F;
			this.Pv.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PvValueChanged);
			this.Pv.EndInit();
			// 
			// OutMin
			// 
			this.OutMin.BeginInit();
			this.OutMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutMin.Name = "OutMin";
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMin.SecurityLevel = 0;
			this.OutMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutMin.TagName = "OutMin";
			this.OutMin.Value = 0F;
			this.OutMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecOutMinValueChanged);
			this.OutMin.EndInit();
			// 
			// OutMax
			// 
			this.OutMax.BeginInit();
			this.OutMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutMax.Name = "OutMax";
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OutMax.SecurityLevel = 0;
			this.OutMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutMax.TagName = "OutMax";
			this.OutMax.Value = 0F;
			this.OutMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecOutMaxValueChanged);
			this.OutMax.EndInit();
			// 
			// PvMin
			// 
			this.PvMin.BeginInit();
			this.PvMin.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMin.IsOnlyInput = true;
			this.PvMin.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMin.Name = "PvMin";
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMin.SecurityLevel = 0;
			this.PvMin.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMin.TagName = "PvMin";
			this.PvMin.Value = 0F;
			this.PvMin.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvMinValueChanged);
			this.PvMin.EndInit();
			// 
			// PvMax
			// 
			this.PvMax.BeginInit();
			this.PvMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PvMax.IsOnlyInput = true;
			this.PvMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PvMax.Name = "PvMax";
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.PvMax.SecurityLevel = 0;
			this.PvMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PvMax.TagName = "PvMax";
			this.PvMax.Value = 0F;
			this.PvMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExecPvMaxValueChanged);
			this.PvMax.EndInit();
			// 
			// txtCurrentSp
			// 
			this.txtCurrentSp.BeginInit();
			this.txtCurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.63333333333333341D, 0D, 0D, 1D, 120D, 328D);
			this.txtCurrentSp.Enabled = false;
			this.txtCurrentSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Sp");
			this.txtCurrentSp.IsOnlyInput = true;
			this.txtCurrentSp.MaximumTag = null;
			this.txtCurrentSp.MinimumTag = null;
			this.txtCurrentSp.Name = "txtCurrentSp";
			this.txtCurrentSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.txtCurrentSp.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.txtCurrentSp.SetColor = new NxtControl.Drawing.Color("Yellow");
			this.txtCurrentSp.TagName = "CurrentSp";
			this.txtCurrentSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.txtCurrentSp.Tooltip = "Current SP";
			this.txtCurrentSp.UseInputPad = true;
			this.txtCurrentSp.Value = 0F;
			this.txtCurrentSp.EndInit();
			// 
			// lblCurOut
			// 
			this.lblCurOut.BeginInit();
			this.lblCurOut.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCurOut.DecimalPlacesCount = ((uint)(1u));
			this.lblCurOut.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.68666666666666676D, 0D, 0D, 1.1904761904761905D, 120D, 52D);
			this.lblCurOut.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblCurOut.FontScale = false;
			this.lblCurOut.IsOnlyInput = true;
			this.lblCurOut.IsPrefixSuffixOutside = false;
			this.lblCurOut.LeadingZeros = ((uint)(0u));
			this.lblCurOut.Name = "lblCurOut";
			this.lblCurOut.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.lblCurOut.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurOut.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurOut.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurOut.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurOut.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurOut.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurOut.Ranges.Clear();
			this.lblCurOut.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary2));
			propertyDictionary1.Add("Text", "${Value}");
			propertyDictionary1.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp"));
			propertyDictionary1.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary1.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.lblCurOut.Ranges.DefaultPropertyValues = propertyDictionary1;
			this.lblCurOut.TagName = "CurrentOp";
			this.lblCurOut.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblCurOut.EndInit();
			// 
			// lblPv
			// 
			this.lblPv.BeginInit();
			this.lblPv.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPv.DecimalPlacesCount = ((uint)(1u));
			this.lblPv.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.72666666666666679D, 0D, 0D, 1.1904761904761905D, 120D, 8D);
			this.lblPv.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblPv.FontScale = false;
			this.lblPv.IsOnlyInput = true;
			this.lblPv.IsPrefixSuffixOutside = false;
			this.lblPv.LeadingZeros = ((uint)(0u));
			this.lblPv.Name = "lblPv";
			this.lblPv.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.lblPv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblPv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblPv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblPv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblPv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblPv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblPv.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblPv.Ranges.Clear();
			this.lblPv.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary4));
			propertyDictionary3.Add("Text", "${Value}");
			propertyDictionary3.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv"));
			propertyDictionary3.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary3.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.lblPv.Ranges.DefaultPropertyValues = propertyDictionary3;
			this.lblPv.TagName = "Pv";
			this.lblPv.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblPv.EndInit();
			// 
			// lblCurrentSp
			// 
			this.lblCurrentSp.BeginInit();
			this.lblCurrentSp.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblCurrentSp.DecimalPlacesCount = ((uint)(1u));
			this.lblCurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.72666666666666679D, 0D, 0D, 1.1904761904761905D, 119D, 30D);
			this.lblCurrentSp.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblCurrentSp.FontScale = false;
			this.lblCurrentSp.IsOnlyInput = true;
			this.lblCurrentSp.IsPrefixSuffixOutside = false;
			this.lblCurrentSp.LeadingZeros = ((uint)(0u));
			this.lblCurrentSp.Name = "lblCurrentSp";
			this.lblCurrentSp.NumberBase = NxtControl.GuiFramework.NumberBase.Decimal;
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.lblCurrentSp.Ranges.Clear();
			this.lblCurrentSp.Ranges.Add(new NxtControl.GuiFramework.Range<float>(null, true, null, true, propertyDictionary6));
			propertyDictionary5.Add("Text", "${Value}");
			propertyDictionary5.Add("TextColor", new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp"));
			propertyDictionary5.Add("Brush", new NxtControl.Drawing.Brush(true));
			propertyDictionary5.Add("Pen", new NxtControl.Drawing.Pen("LabelPen"));
			this.lblCurrentSp.Ranges.DefaultPropertyValues = propertyDictionary5;
			this.lblCurrentSp.TagName = "CurrentSp";
			this.lblCurrentSp.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblCurrentSp.EndInit();
			// 
			// lblPidMode
			// 
			this.lblPidMode.AngleIgnore = true;
			this.lblPidMode.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblPidMode.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(96D)), ((float)(109D)), ((float)(25D)));
			this.lblPidMode.Brush = new NxtControl.Drawing.Brush(true);
			this.lblPidMode.Font = new NxtControl.Drawing.Font("SE.App2Base.Pv");
			this.lblPidMode.Name = "lblPidMode";
			this.lblPidMode.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.lblPidMode.Text = "$key:SE.App2CommonProcess.TxtUnknown";
			this.lblPidMode.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.lblPidMode.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpData");
			// 
			// line2
			// 
			this.line2.EndPoint = new NxtControl.Drawing.PointF(272D, 244D);
			this.line2.Name = "line2";
			this.line2.Pen = new NxtControl.Drawing.Pen("FpLinePen");
			this.line2.StartPoint = new NxtControl.Drawing.PointF(0D, 244D);
			// 
			// line3
			// 
			this.line3.EndPoint = new NxtControl.Drawing.PointF(272D, 244D);
			this.line3.Name = "line3";
			this.line3.Pen = new NxtControl.Drawing.Pen("FpLinePen");
			this.line3.StartPoint = new NxtControl.Drawing.PointF(0D, 244D);
			// 
			// OutChProhibited
			// 
			this.OutChProhibited.BeginInit();
			this.OutChProhibited.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutChProhibited.IsOnlyInput = true;
			this.OutChProhibited.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutChProhibited.Name = "OutChProhibited";
			this.OutChProhibited.SecurityLevel = 0;
			this.OutChProhibited.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutChProhibited.TagName = "OutChannelProhibited";
			this.OutChProhibited.Value = false;
			this.OutChProhibited.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutChProhibitedValueChanged);
			this.OutChProhibited.EndInit();
			// 
			// TrackOutput
			// 
			this.TrackOutput.BeginInit();
			this.TrackOutput.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TrackOutput.IsOnlyInput = true;
			this.TrackOutput.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TrackOutput.Name = "TrackOutput";
			this.TrackOutput.SecurityLevel = 0;
			this.TrackOutput.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TrackOutput.TagName = "TrackOutput";
			this.TrackOutput.Value = false;
			this.TrackOutput.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TrackOutputValueChanged);
			this.TrackOutput.EndInit();
			// 
			// CurrentOp
			// 
			this.CurrentOp.BeginInit();
			this.CurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOp.IsOnlyInput = true;
			this.CurrentOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOp.Name = "CurrentOp";
			this.CurrentOp.SecurityLevel = 0;
			this.CurrentOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOp.TagName = "CurrentOp";
			this.CurrentOp.Value = 0F;
			this.CurrentOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOpValueChanged);
			this.CurrentOp.EndInit();
			// 
			// CurrentSp
			// 
			this.CurrentSp.BeginInit();
			this.CurrentSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSp.IsOnlyInput = true;
			this.CurrentSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSp.Name = "CurrentSp";
			this.CurrentSp.SecurityLevel = 0;
			this.CurrentSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSp.TagName = "CurrentSp";
			this.CurrentSp.Value = 0F;
			this.CurrentSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpValueChanged);
			this.CurrentSp.EndInit();
			// 
			// PvSpGroup
			// 
			this.PvSpGroup.BeginInit();
			this.PvSpGroup.AbnormalXOffset = 0D;
			this.PvSpGroup.AbnormalYOffset = 0D;
			this.PvSpGroup.BarGraphSize = 208D;
			this.PvSpGroup.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, -6D, 62D);
			this.PvSpGroup.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.PvSpGroup.LeftOffset = ((uint)(60u));
			this.PvSpGroup.Name = "PvSpGroup";
			this.PvSpGroup.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.None;
			this.PvSpGroup.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp");
			this.PvSpGroup.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv");
			this.PvSpGroup.RangeVisible = SE.App2Base.SupportClasses.BoolType.True;
			this.PvSpGroup.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.PvSpGroup.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp");
			this.PvSpGroup.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.PvBarSpTriangle;
			this.PvSpGroup.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.PvSpGroup.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Left;
			this.PvSpGroup.Unit = "";
			this.PvSpGroup.UnitColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymUnit");
			this.PvSpGroup.ValuePct = 0D;
			this.PvSpGroup.EndInit();
			// 
			// OpGroup
			// 
			this.OpGroup.BeginInit();
			this.OpGroup.AbnormalXOffset = 0D;
			this.OpGroup.AbnormalYOffset = 0D;
			this.OpGroup.BarGraphSize = 208D;
			this.OpGroup.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, -6D, 114D);
			this.OpGroup.FrameColor = new NxtControl.Drawing.Color("SymStaticIconColor");
			this.OpGroup.LeftOffset = ((uint)(60u));
			this.OpGroup.Name = "OpGroup";
			this.OpGroup.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.None;
			this.OpGroup.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpOp");
			this.OpGroup.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpPv");
			this.OpGroup.RangeVisible = SE.App2Base.SupportClasses.BoolType.True;
			this.OpGroup.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.OpGroup.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibFpSp");
			this.OpGroup.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.OpLine;
			this.OpGroup.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.OpGroup.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Left;
			this.OpGroup.Unit = "";
			this.OpGroup.UnitColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymUnit");
			this.OpGroup.ValuePct = 0D;
			this.OpGroup.EndInit();
			// 
			// labelS1
			// 
			this.labelS1.BeginInit();
			this.labelS1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 96D);
			this.labelS1.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS1.Name = "labelS1";
			this.labelS1.NameSpace = "SE.App2CommonProcess";
			this.labelS1.SeperatorVisiblity = true;
			this.labelS1.Text = "Current Mode";
			this.labelS1.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS1.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS1.TextKey = "LabelCurMode";
			this.labelS1.EndInit();
			// 
			// labelS2
			// 
			this.labelS2.BeginInit();
			this.labelS2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 8D);
			this.labelS2.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS2.Name = "labelS2";
			this.labelS2.NameSpace = "SE.App2CommonProcess";
			this.labelS2.SeperatorVisiblity = true;
			this.labelS2.Text = "Process Value";
			this.labelS2.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS2.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS2.TextKey = "LabelProcessValue";
			this.labelS2.EndInit();
			// 
			// labelS3
			// 
			this.labelS3.BeginInit();
			this.labelS3.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 30D);
			this.labelS3.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS3.Name = "labelS3";
			this.labelS3.NameSpace = "SE.App2CommonProcess";
			this.labelS3.SeperatorVisiblity = true;
			this.labelS3.Text = "Current Setpoint";
			this.labelS3.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS3.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS3.TextKey = "LabelCurrentSetpoint";
			this.labelS3.EndInit();
			// 
			// labelS4
			// 
			this.labelS4.BeginInit();
			this.labelS4.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 52D);
			this.labelS4.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS4.Name = "labelS4";
			this.labelS4.NameSpace = "SE.App2CommonProcess";
			this.labelS4.SeperatorVisiblity = true;
			this.labelS4.Text = "Current Output";
			this.labelS4.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS4.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS4.TextKey = "LabelCurrentOutput";
			this.labelS4.EndInit();
			// 
			// labelS5
			// 
			this.labelS5.BeginInit();
			this.labelS5.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 298D);
			this.labelS5.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS5.Name = "labelS5";
			this.labelS5.NameSpace = "SE.App2CommonProcess";
			this.labelS5.SeperatorVisiblity = true;
			this.labelS5.Text = "Mode";
			this.labelS5.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS5.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS5.TextKey = "LabelMode";
			this.labelS5.EndInit();
			// 
			// labelS6
			// 
			this.labelS6.BeginInit();
			this.labelS6.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 328D);
			this.labelS6.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS6.Name = "labelS6";
			this.labelS6.NameSpace = "SE.App2CommonProcess";
			this.labelS6.SeperatorVisiblity = true;
			this.labelS6.Text = "Setpoint";
			this.labelS6.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS6.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS6.TextKey = "LabelSp";
			this.labelS6.EndInit();
			// 
			// labelS7
			// 
			this.labelS7.BeginInit();
			this.labelS7.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 358D);
			this.labelS7.Font = new NxtControl.Drawing.Font("SE.App2Base.LabelFont");
			this.labelS7.Name = "labelS7";
			this.labelS7.NameSpace = "SE.App2CommonProcess";
			this.labelS7.SeperatorVisiblity = true;
			this.labelS7.Text = "Output";
			this.labelS7.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleRight;
			this.labelS7.TextColor = new NxtControl.Drawing.Color("FpLabelText");
			this.labelS7.TextKey = "LabelOutput";
			this.labelS7.EndInit();
			// 
			// fpNavigationPane
			// 
			this.fpNavigationPane.BeginInit();
			this.fpNavigationPane.Backwash.AliasName = "";
			this.fpNavigationPane.Backwash.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Backwash.ParentTitle = "Title";
			this.fpNavigationPane.Backwash.SymbolType = "SE.AppWWW.Symbols.Backwash.sDefault";
			this.fpNavigationPane.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 212D, 0D);
			this.fpNavigationPane.ExtendedMeasures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Failure.AliasName = "";
			this.fpNavigationPane.Failure.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Failure.ParentTitle = "Title";
			this.fpNavigationPane.Failure.SymbolType = "SE.App2CommonProcess.Symbols.CondSum.sFailure";
			this.fpNavigationPane.Filtration.AliasName = "";
			this.fpNavigationPane.Filtration.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Filtration.ParentTitle = "Title";
			this.fpNavigationPane.Filtration.SymbolType = "SE.AppWWW.Symbols.Filtration.sDefault";
			this.fpNavigationPane.GeneralPropertySubscription.AddRange(new string[] {
			"System.ShowTagNames"});
			this.fpNavigationPane.HideSlider = false;
			this.fpNavigationPane.Info.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.InputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Interlock.AliasName = "";
			this.fpNavigationPane.Interlock.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1L;
			this.fpNavigationPane.Interlock.ParentTitle = "Title";
			this.fpNavigationPane.Interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlock";
			this.fpNavigationPane.IsBasic = false;
			this.fpNavigationPane.LocalPanel.AliasName = "";
			this.fpNavigationPane.LocalPanel.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.LocalPanel.ParentTitle = "Title";
			this.fpNavigationPane.LocalPanel.SymbolType = "SE.App2CommonProcess.Symbols.DevLp.sDefault";
			this.fpNavigationPane.Maintenance.AliasName = "";
			this.fpNavigationPane.Maintenance.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Maintenance.ParentTitle = "Title";
			this.fpNavigationPane.Maintenance.SymbolType = "SE.App2CommonProcess.Symbols.DevMnt.sDefault";
			this.fpNavigationPane.Measures.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Name = "fpNavigationPane";
			this.fpNavigationPane.OutputParameters.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Owner.AliasName = "";
			this.fpNavigationPane.Owner.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot1R;
			this.fpNavigationPane.Owner.ParentTitle = "Title";
			this.fpNavigationPane.Owner.SymbolType = "SE.App2Base.Symbols.Owner.sOwnerConfig";
			this.fpNavigationPane.Parameter.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2R;
			this.fpNavigationPane.ParentTitle = "";
			this.fpNavigationPane.Permissive.AliasName = "";
			this.fpNavigationPane.Permissive.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.Permissive.ParentTitle = "Title";
			this.fpNavigationPane.Permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissive";
			this.fpNavigationPane.SecMode = 6;
			this.fpNavigationPane.SecOwner = 3;
			this.fpNavigationPane.SecParameter = 12;
			this.fpNavigationPane.SecSetpoint = 3;
			this.fpNavigationPane.ShortFlush.AliasName = "";
			this.fpNavigationPane.ShortFlush.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.ShortFlush.ParentTitle = "Title";
			this.fpNavigationPane.ShortFlush.SymbolType = "SE.AppWWW.Symbols.ShortFlush.sDefault";
			this.fpNavigationPane.SSC.AliasName = "";
			this.fpNavigationPane.SSC.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot2L;
			this.fpNavigationPane.SSC.ParentTitle = "Title";
			this.fpNavigationPane.SSC.SymbolType = "SE.App2CommonProcess.Symbols.PIDSSCSeqData.sDefault";
			this.fpNavigationPane.Trend.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.Slot3R;
			this.fpNavigationPane.UserDefined1.AliasName = "";
			this.fpNavigationPane.UserDefined1.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined1.ParentTitle = "Title";
			this.fpNavigationPane.UserDefined2.AliasName = "";
			this.fpNavigationPane.UserDefined2.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined2.ParentTitle = "Title";
			this.fpNavigationPane.UserDefined3.AliasName = "";
			this.fpNavigationPane.UserDefined3.Availablity = SE.App2Base.SupportClasses.FpIconSymbolAllocation.NotAvailable;
			this.fpNavigationPane.UserDefined3.ParentTitle = "Title";
			this.fpNavigationPane.OnParameterClick += new SE.App2Base.Graphics.FpNavigationPane.ParameterClicked(this.FpNavigationPaneOnParameterClick);
			this.fpNavigationPane.OnTrendClick += new SE.App2Base.Graphics.FpNavigationPane.TrendClicked(this.FpNavigationPaneOnTrendClick);
			this.fpNavigationPane.EndInit();
			// 
			// ownerSwitch
			// 
			this.ownerSwitch.BeginInit();
			this.ownerSwitch.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 268D);
			this.ownerSwitch.ExternalAvailable = false;
			this.ownerSwitch.InstanceName = "";
			this.ownerSwitch.Name = "ownerSwitch";
			this.ownerSwitch.SecOwner = 0;
			this.ownerSwitch.OnBasicOwnerChanged += new SE.App2Base.Graphics.OwnerSwitchBasic.BasicOwnerChanged(this.OwnerSwitchOnBasicOwnerChanged);
			this.ownerSwitch.EndInit();
			// 
			// ownerStatus
			// 
			this.ownerStatus.BeginInit();
			this.ownerStatus.CurrentBasicOwner = false;
			this.ownerStatus.CurrOwnerLabelTooltip = "Current Owner";
			this.ownerStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 5D, 74D);
			this.ownerStatus.ExternalAvailable = false;
			this.ownerStatus.InstanceName = "";
			this.ownerStatus.LblCurrentModeTooltip = "Current Owner";
			this.ownerStatus.Name = "ownerStatus";
			this.ownerStatus.EndInit();
			// 
			// PidMode
			// 
			this.PidMode.Bounds = new NxtControl.Drawing.RectF(((float)(119D)), ((float)(298D)), ((float)(118D)), ((float)(25D)));
			this.PidMode.DrawStyle = NxtControl.GuiFramework.TwoStateButton.ButtonDrawStyle.Switch;
			this.PidMode.FalseBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.PidMode.FalseText = "$key:SE.App2CommonProcess.LabelMan";
			this.PidMode.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.PidMode.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.PidMode.Name = "PidMode";
			this.PidMode.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.PidMode.Radius = 8D;
			this.PidMode.TextColorFalse = new NxtControl.Drawing.Color("ButtonTextColorFalse");
			this.PidMode.TextColorTrue = new NxtControl.Drawing.Color("ButtonTextColorTrue");
			this.PidMode.TrueBrush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.PidMode.TrueText = "$key:SE.App2CommonProcess.LabelAuto";
			this.PidMode.Use3DEffect = false;
			this.PidMode.CheckedChanged += new System.EventHandler(this.PidModeCheckedChanged);
			// 
			// CurrentOwner
			// 
			this.CurrentOwner.BeginInit();
			this.CurrentOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwner.IsOnlyInput = true;
			this.CurrentOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwner.Name = "CurrentOwner";
			this.CurrentOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwner.TagName = "CurrentOwner";
			this.CurrentOwner.Value = ((ushort)(0));
			this.CurrentOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerValueChanged);
			this.CurrentOwner.EndInit();
			// 
			// StdOwnerConnected
			// 
			this.StdOwnerConnected.BeginInit();
			this.StdOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.StdOwnerConnected.IsOnlyInput = true;
			this.StdOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StdOwnerConnected.Name = "StdOwnerConnected";
			this.StdOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.StdOwnerConnected.TagName = "StdOwnerConnected";
			this.StdOwnerConnected.Value = false;
			this.StdOwnerConnected.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StdOwnerConnectedValueChanged);
			this.StdOwnerConnected.EndInit();
			// 
			// CurrentMode
			// 
			this.CurrentMode.BeginInit();
			this.CurrentMode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentMode.IsOnlyInput = true;
			this.CurrentMode.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentMode.Name = "CurrentMode";
			this.CurrentMode.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentMode.TagName = "CurrentMode";
			this.CurrentMode.Value = ((short)(0));
			this.CurrentMode.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentModeValueChanged);
			this.CurrentMode.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Mode.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Mode.Name = "Mode";
			this.Mode.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Mode.TagName = "Mode";
			this.Mode.Value = ((short)(0));
			this.Mode.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ModeValueChanged);
			this.Mode.EndInit();
			// 
			// TrackSpInManual
			// 
			this.TrackSpInManual.BeginInit();
			this.TrackSpInManual.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TrackSpInManual.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TrackSpInManual.Name = "TrackSpInManual";
			this.TrackSpInManual.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TrackSpInManual.TagName = "TrackSpInManual";
			this.TrackSpInManual.Value = false;
			this.TrackSpInManual.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TrackSpInManualValueChanged);
			this.TrackSpInManual.EndInit();
			// 
			// IlckCond
			// 
			this.IlckCond.BeginInit();
			this.IlckCond.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.IlckCond.IsOnlyInput = true;
			this.IlckCond.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.IlckCond.Name = "IlckCond";
			this.IlckCond.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.IlckCond.TagName = "IlckCond";
			this.IlckCond.Value = false;
			this.IlckCond.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IlckCondValueChanged);
			this.IlckCond.EndInit();
			// 
			// CurrentSpText
			// 
			this.CurrentSpText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.CurrentSpText.Bounds = new NxtControl.Drawing.RectF(((float)(120D)), ((float)(328D)), ((float)(95D)), ((float)(25D)));
			this.CurrentSpText.Enabled = false;
			this.CurrentSpText.Font = new NxtControl.Drawing.Font("TextBoxFont");
			this.CurrentSpText.FontScale = true;
			this.CurrentSpText.Maximum = 100D;
			this.CurrentSpText.Minimum = 0D;
			this.CurrentSpText.Name = "CurrentSpText";
			this.CurrentSpText.Pen = new NxtControl.Drawing.Pen("TextBoxPen");
			this.CurrentSpText.TextAutoSizeHorizontalOffset = 10;
			this.CurrentSpText.TextAutoSizeVerticalOffset = 2;
			this.CurrentSpText.TextPadding = new NxtControl.Drawing.Padding(2);
			// 
			// Sp
			// 
			this.Sp.BeginInit();
			this.Sp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Sp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Sp.Name = "Sp";
			this.Sp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Sp.TagName = "Sp";
			this.Sp.Value = 0F;
			this.Sp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpValueChanged);
			this.Sp.EndInit();
			// 
			// fpDefault
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(272D)), ((float)(416D)));
			this.Brush = new NxtControl.Drawing.Brush("FpBackgroundBrush");
			this.FormBorderStyle = NxtControl.GuiFramework.FormBorderStyle.FixedSingle;
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("", NxtControl.GuiFramework.MouseButtonType.None));
			this.SecurityToken = ((uint)(4294967175u));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.lblPv,
			this.lblCurrentSp,
			this.lblCurOut,
			this.Pv,
			this.OutMin,
			this.OutMax,
			this.PvMin,
			this.PvMax,
			this.OutChProhibited,
			this.TrackOutput,
			this.CurrentOp,
			this.CurrentSp,
			this.PvSpGroup,
			this.OpGroup,
			this.txtCurrentSp,
			this.txtAutoSp,
			this.labelS2,
			this.labelS3,
			this.labelS4,
			this.labelS5,
			this.labelS6,
			this.labelS7,
			this.line2,
			this.line3,
			this.ownerSwitch,
			this.ownerStatus,
			this.PidMode,
			this.fpNavigationPane,
			this.outProhibited,
			this.CurrentOwner,
			this.StdOwnerConnected,
			this.txtCurrentOp,
			this.txtManualSp,
			this.CurrentMode,
			this.Mode,
			this.TrackSpInManual,
			this.IlckCond,
			this.CurrentSpText,
			this.Sp,
			this.lblPidMode,
			this.labelS1});
			this.Size = new System.Drawing.Size(272, 416);
			this.SecurityOwnerChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityOwnerChanged(this.FpDefaultSecurityOwnerChanged);
			this.SecurityParameterChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecurityParameterChanged(this.FpDefaultSecurityParameterChanged);
			this.SecuritySetpointChanged += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnSecuritySetpointChanged(this.FpDefaultSecuritySetpointChanged);
			this.UpdateOptionalService += new SE.App2Base.Faceplates.SEAppLibHMIFaceplate.OnUpdateOptionalService(this.FpDefaultUpdateOptionalService);

		}
		private NxtControl.GuiFramework.Rectangle outProhibited;
		private System.HMI.Symbols.Base.TextBox<float> txtAutoSp;
		private System.HMI.Symbols.Base.Execute<float> OutMax;
		private System.HMI.Symbols.Base.Execute<float> OutMin;
		private System.HMI.Symbols.Base.TextBox<float> txtManualSp;
		private System.HMI.Symbols.Base.TextBox<float> txtCurrentOp;
		private System.HMI.Symbols.Base.Label<float> lblPv;
		private System.HMI.Symbols.Base.Label<float> lblCurOut;
		private System.HMI.Symbols.Base.Execute<float> Pv;
		private System.HMI.Symbols.Base.Execute<float> PvMin;
		private System.HMI.Symbols.Base.Execute<float> PvMax;
		private System.HMI.Symbols.Base.TextBox<float> txtCurrentSp;
		private System.HMI.Symbols.Base.Label<float> lblCurrentSp;
		private NxtControl.GuiFramework.Label lblPidMode;
		private NxtControl.GuiFramework.Line line2;
		private NxtControl.GuiFramework.Line line3;
		private System.HMI.Symbols.Base.Execute<bool> OutChProhibited;
		private System.HMI.Symbols.Base.Execute<bool> TrackOutput;
		private System.HMI.Symbols.Base.Execute<float> CurrentOp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSp;
		private SE.App2Base.Graphics.SMeters PvSpGroup;
		private SE.App2Base.Graphics.SMeters OpGroup;
		private SE.App2Base.Graphics.LabelS labelS1;
		private SE.App2Base.Graphics.LabelS labelS2;
		private SE.App2Base.Graphics.LabelS labelS3;
		private SE.App2Base.Graphics.LabelS labelS4;
		private SE.App2Base.Graphics.LabelS labelS5;
		private SE.App2Base.Graphics.LabelS labelS6;
		private SE.App2Base.Graphics.LabelS labelS7;
		private SE.App2Base.Graphics.FpNavigationPane fpNavigationPane;
		private SE.App2Base.Graphics.OwnerSwitchBasic ownerSwitch;
		private SE.App2Base.Graphics.OwnerStatusBasic ownerStatus;
		private NxtControl.GuiFramework.TwoStateButton PidMode;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<short> CurrentMode;
		private System.HMI.Symbols.Base.Execute<short> Mode;
		private System.HMI.Symbols.Base.Execute<bool> TrackSpInManual;
		private System.HMI.Symbols.Base.Execute<bool> IlckCond;
		private NxtControl.GuiFramework.DrawnTextBox CurrentSpText;
		private System.HMI.Symbols.Base.Execute<float> Sp;
		//private System.HMI.Symbols.Base.Label<float> lblOutMin;
		//private System.HMI.Symbols.Base.Label<float> lblOutMax;
		#endregion
	}
}



