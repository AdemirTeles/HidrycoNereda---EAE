using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace HMI.Main.Symbols.MotorVsBase
{
	/// <summary>
	/// Summary description for sMotor.
	/// </summary>
	partial class sMotor
	{

		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.Base3R = new NxtControl.GuiFramework.Rectangle();
			this.polygon3 = new NxtControl.GuiFramework.Polygon();
			this.arc3 = new NxtControl.GuiFramework.Arc();
			this.polygon1 = new NxtControl.GuiFramework.Polygon();
			this.Base2R = new NxtControl.GuiFramework.Rectangle();
			this.Base1R = new NxtControl.GuiFramework.Rectangle();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.arc4 = new NxtControl.GuiFramework.Arc();
			this.polygon4 = new NxtControl.GuiFramework.Polygon();
			this.polygon5 = new NxtControl.GuiFramework.Polygon();
			this.arc5 = new NxtControl.GuiFramework.Arc();
			this.Base3D = new NxtControl.GuiFramework.Rectangle();
			this.polygon2 = new NxtControl.GuiFramework.Polygon();
			this.Base2D = new NxtControl.GuiFramework.Rectangle();
			this.roundedRectangle3 = new NxtControl.GuiFramework.RoundedRectangle();
			this.polygon7 = new NxtControl.GuiFramework.Polygon();
			this.arc7 = new NxtControl.GuiFramework.Arc();
			this.arc6 = new NxtControl.GuiFramework.Arc();
			this.polygon6 = new NxtControl.GuiFramework.Polygon();
			this.Base3U = new NxtControl.GuiFramework.Rectangle();
			this.Base2U = new NxtControl.GuiFramework.Rectangle();
			this.Base1U = new NxtControl.GuiFramework.Rectangle();
			this.roundedRectangle2 = new NxtControl.GuiFramework.RoundedRectangle();
			this.ArcRev = new NxtControl.GuiFramework.Arc();
			this.Arrowrev = new NxtControl.GuiFramework.Polygon();
			this.Base1D = new NxtControl.GuiFramework.Rectangle();
			this.arc2 = new NxtControl.GuiFramework.Arc();
			this.arc1 = new NxtControl.GuiFramework.Arc();
			this.Base3L = new NxtControl.GuiFramework.Rectangle();
			this.Base2L = new NxtControl.GuiFramework.Rectangle();
			this.Base1L = new NxtControl.GuiFramework.Rectangle();
			this.roundedRectangle4 = new NxtControl.GuiFramework.RoundedRectangle();
			this.MotBaseL = new NxtControl.GuiFramework.Group();
			this.ReverseL = new NxtControl.GuiFramework.Group();
			this.ForwardL = new NxtControl.GuiFramework.Group();
			this.MotBaseR = new NxtControl.GuiFramework.Group();
			this.ReverseR = new NxtControl.GuiFramework.Group();
			this.ForwardR = new NxtControl.GuiFramework.Group();
			this.MotbaseD = new NxtControl.GuiFramework.Group();
			this.ForwardD = new NxtControl.GuiFramework.Group();
			this.ReverseD = new NxtControl.GuiFramework.Group();
			this.MotbaseU = new NxtControl.GuiFramework.Group();
			this.ReverseU = new NxtControl.GuiFramework.Group();
			this.ForwardU = new NxtControl.GuiFramework.Group();
			this.abnormal = new SE.App2Base.Graphics.Abnormal();
			this.alarmFrame = new NxtControl.GuiFramework.AlarmFrame();
			this.SMeters = new SE.App2Base.Graphics.SMeters();
			this.state = new SE.App2Base.Graphics.State();
			this.owner = new SE.App2Base.Graphics.OwnerBasic();
			this.FbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.TransFbStatus = new System.HMI.Symbols.Base.Execute<short>();
			this.SpeedFbStatus = new System.HMI.Symbols.Base.Execute<float>();
			this.CurrentOp = new System.HMI.Symbols.Base.Execute<short>();
			this.CurrentSpeedSp = new System.HMI.Symbols.Base.Execute<float>();
			this.NeedReset = new System.HMI.Symbols.Base.Execute<bool>();
			this.IlckCond = new System.HMI.Symbols.Base.Execute<bool>();
			this.Fail = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermStop = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermFwd = new System.HMI.Symbols.Base.Execute<bool>();
			this.PermRev = new System.HMI.Symbols.Base.Execute<bool>();
			this.StdOwnerConnected = new System.HMI.Symbols.Base.Execute<bool>();
			this.SpeedSpMax = new System.HMI.Symbols.Base.Execute<float>();
			this.Simulation = new System.HMI.Symbols.Base.Execute<bool>();
			this.FbOverride = new System.HMI.Symbols.Base.Execute<bool>();
			this.Maintenance = new System.HMI.Symbols.Base.Execute<bool>();
			this.OutOfService = new System.HMI.Symbols.Base.Execute<bool>();
			this.DisReverse = new System.HMI.Symbols.Base.Execute<bool>();
			this.failure = new SE.App2CommonProcess.Graphics.FailureSmallBasic();
			this.interlock = new SE.App2CommonProcess.Graphics.InterlockSmallBasic();
			this.permissive = new SE.App2CommonProcess.Graphics.PermissiveSmallBasic();
			this.CurrentOwner = new System.HMI.Symbols.Base.Execute<ushort>();
			this.InstanceName = new NxtControl.GuiFramework.AliasDisplayLabel();
			this.ExternalControlled = new System.HMI.Symbols.Base.Execute<bool>();
			this.execute_11 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.execute_12 = new System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>>();
			this.group1 = new NxtControl.GuiFramework.Group();
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).BeginInit();
			// 
			// Base3R
			// 
			this.Base3R.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(44D)), ((float)(3D)), ((float)(3D)));
			this.Base3R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base3R.Name = "Base3R";
			// 
			// polygon3
			// 
			this.polygon3.Bounds = new NxtControl.Drawing.RectF(((float)(74D)), ((float)(50.5D)), ((float)(2D)), ((float)(2D)));
			this.polygon3.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.polygon3.Closed = true;
			this.polygon3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon3.Name = "polygon3";
			this.polygon3.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(76D, 52.5D),
			new NxtControl.Drawing.PointF(74D, 50.5D),
			new NxtControl.Drawing.PointF(74D, 52.5D)});
			// 
			// arc3
			// 
			this.arc3.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(38.5D)), ((float)(14D)), ((float)(14D)));
			this.arc3.Center = new NxtControl.Drawing.PointF(71D, 45.5D);
			this.arc3.Name = "arc3";
			this.arc3.RadiusX = 7D;
			this.arc3.RadiusY = 7D;
			this.arc3.StartAngle = 170D;
			this.arc3.SweepAngle = 250D;
			// 
			// polygon1
			// 
			this.polygon1.Bounds = new NxtControl.Drawing.RectF(((float)(79.5D)), ((float)(52D)), ((float)(2D)), ((float)(2D)));
			this.polygon1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.polygon1.Closed = true;
			this.polygon1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon1.Name = "polygon1";
			this.polygon1.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(81.5D, 54D),
			new NxtControl.Drawing.PointF(79.5D, 52D),
			new NxtControl.Drawing.PointF(79.5D, 54D)});
			// 
			// Base2R
			// 
			this.Base2R.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(41D)), ((float)(4D)), ((float)(10D)));
			this.Base2R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base2R.Name = "Base2R";
			// 
			// Base1R
			// 
			this.Base1R.Bounds = new NxtControl.Drawing.RectF(((float)(68D)), ((float)(36D)), ((float)(23D)), ((float)(19D)));
			this.Base1R.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base1R.Name = "Base1R";
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(68D)), ((float)(36D)), ((float)(23D)), ((float)(19D)));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			this.roundedRectangle1.Radius = 12D;
			// 
			// arc4
			// 
			this.arc4.Bounds = new NxtControl.Drawing.RectF(((float)(72.5D)), ((float)(38.5D)), ((float)(14D)), ((float)(14D)));
			this.arc4.Center = new NxtControl.Drawing.PointF(79.5D, 45.5D);
			this.arc4.Name = "arc4";
			this.arc4.RadiusX = 7D;
			this.arc4.RadiusY = 7D;
			this.arc4.StartAngle = 120D;
			this.arc4.SweepAngle = 250D;
			// 
			// polygon4
			// 
			this.polygon4.Bounds = new NxtControl.Drawing.RectF(((float)(75D)), ((float)(50.5D)), ((float)(2D)), ((float)(2D)));
			this.polygon4.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.polygon4.Closed = true;
			this.polygon4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon4.Name = "polygon4";
			this.polygon4.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(75D, 52.5D),
			new NxtControl.Drawing.PointF(77D, 50.5D),
			new NxtControl.Drawing.PointF(77D, 52.5D)});
			// 
			// polygon5
			// 
			this.polygon5.Bounds = new NxtControl.Drawing.RectF(((float)(82.5D)), ((float)(50.5D)), ((float)(2D)), ((float)(2D)));
			this.polygon5.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.polygon5.Closed = true;
			this.polygon5.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon5.Name = "polygon5";
			this.polygon5.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(84.5D, 52.5D),
			new NxtControl.Drawing.PointF(82.5D, 50.5D),
			new NxtControl.Drawing.PointF(82.5D, 52.5D)});
			// 
			// arc5
			// 
			this.arc5.Bounds = new NxtControl.Drawing.RectF(((float)(72.5D)), ((float)(38.5D)), ((float)(14D)), ((float)(14D)));
			this.arc5.Center = new NxtControl.Drawing.PointF(79.5D, 45.5D);
			this.arc5.Name = "arc5";
			this.arc5.RadiusX = 7D;
			this.arc5.RadiusY = 7D;
			this.arc5.StartAngle = 170D;
			this.arc5.SweepAngle = 250D;
			// 
			// Base3D
			// 
			this.Base3D.Bounds = new NxtControl.Drawing.RectF(((float)(75D)), ((float)(58D)), ((float)(3D)), ((float)(3D)));
			this.Base3D.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base3D.Name = "Base3D";
			// 
			// polygon2
			// 
			this.polygon2.Bounds = new NxtControl.Drawing.RectF(((float)(66D)), ((float)(50D)), ((float)(2D)), ((float)(2D)));
			this.polygon2.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.polygon2.Closed = true;
			this.polygon2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon2.Name = "polygon2";
			this.polygon2.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(66D, 52D),
			new NxtControl.Drawing.PointF(68D, 50D),
			new NxtControl.Drawing.PointF(68D, 52D)});
			// 
			// Base2D
			// 
			this.Base2D.Bounds = new NxtControl.Drawing.RectF(((float)(72D)), ((float)(53D)), ((float)(10D)), ((float)(4D)));
			this.Base2D.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base2D.Name = "Base2D";
			// 
			// roundedRectangle3
			// 
			this.roundedRectangle3.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(30D)), ((float)(19D)), ((float)(23D)));
			this.roundedRectangle3.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle3.Name = "roundedRectangle3";
			this.roundedRectangle3.Radius = 12D;
			// 
			// polygon7
			// 
			this.polygon7.Bounds = new NxtControl.Drawing.RectF(((float)(79.5D)), ((float)(46D)), ((float)(2D)), ((float)(2D)));
			this.polygon7.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.polygon7.Closed = true;
			this.polygon7.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon7.Name = "polygon7";
			this.polygon7.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(81.5D, 48D),
			new NxtControl.Drawing.PointF(79.5D, 46D),
			new NxtControl.Drawing.PointF(79.5D, 48D)});
			// 
			// arc7
			// 
			this.arc7.Bounds = new NxtControl.Drawing.RectF(((float)(69.5D)), ((float)(34D)), ((float)(14D)), ((float)(14D)));
			this.arc7.Center = new NxtControl.Drawing.PointF(76.5D, 41D);
			this.arc7.Name = "arc7";
			this.arc7.RadiusX = 7D;
			this.arc7.RadiusY = 7D;
			this.arc7.StartAngle = 170D;
			this.arc7.SweepAngle = 250D;
			// 
			// arc6
			// 
			this.arc6.Bounds = new NxtControl.Drawing.RectF(((float)(69.5D)), ((float)(34D)), ((float)(14D)), ((float)(14D)));
			this.arc6.Center = new NxtControl.Drawing.PointF(76.5D, 41D);
			this.arc6.Name = "arc6";
			this.arc6.RadiusX = 7D;
			this.arc6.RadiusY = 7D;
			this.arc6.StartAngle = 120D;
			this.arc6.SweepAngle = 250D;
			// 
			// polygon6
			// 
			this.polygon6.Bounds = new NxtControl.Drawing.RectF(((float)(72.199996948242188D)), ((float)(46.5D)), ((float)(2D)), ((float)(2D)));
			this.polygon6.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.polygon6.Closed = true;
			this.polygon6.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.polygon6.Name = "polygon6";
			this.polygon6.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72.199996948242188D, 48.5D),
			new NxtControl.Drawing.PointF(74.199996948242188D, 46.5D),
			new NxtControl.Drawing.PointF(74.199996948242188D, 48.5D)});
			// 
			// Base3U
			// 
			this.Base3U.Bounds = new NxtControl.Drawing.RectF(((float)(75D)), ((float)(28D)), ((float)(3D)), ((float)(3D)));
			this.Base3U.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base3U.Name = "Base3U";
			// 
			// Base2U
			// 
			this.Base2U.Bounds = new NxtControl.Drawing.RectF(((float)(71D)), ((float)(32D)), ((float)(10D)), ((float)(4D)));
			this.Base2U.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base2U.Name = "Base2U";
			// 
			// Base1U
			// 
			this.Base1U.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(36D)), ((float)(19D)), ((float)(23D)));
			this.Base1U.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base1U.Name = "Base1U";
			// 
			// roundedRectangle2
			// 
			this.roundedRectangle2.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(36D)), ((float)(19D)), ((float)(23D)));
			this.roundedRectangle2.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle2.Name = "roundedRectangle2";
			this.roundedRectangle2.Radius = 12D;
			// 
			// ArcRev
			// 
			this.ArcRev.Bounds = new NxtControl.Drawing.RectF(((float)(69.5D)), ((float)(40D)), ((float)(14D)), ((float)(14D)));
			this.ArcRev.Center = new NxtControl.Drawing.PointF(76.5D, 47D);
			this.ArcRev.Name = "ArcRev";
			this.ArcRev.RadiusX = 7D;
			this.ArcRev.RadiusY = 7D;
			this.ArcRev.StartAngle = 120D;
			this.ArcRev.SweepAngle = 250D;
			// 
			// Arrowrev
			// 
			this.Arrowrev.Bounds = new NxtControl.Drawing.RectF(((float)(72.199996948242188D)), ((float)(52.5D)), ((float)(2D)), ((float)(2D)));
			this.Arrowrev.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("SymStaticIconColor"));
			this.Arrowrev.Closed = true;
			this.Arrowrev.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Arrowrev.Name = "Arrowrev";
			this.Arrowrev.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(72.199996948242188D, 54.5D),
			new NxtControl.Drawing.PointF(74.199996948242188D, 52.5D),
			new NxtControl.Drawing.PointF(74.199996948242188D, 54.5D)});
			// 
			// Base1D
			// 
			this.Base1D.Bounds = new NxtControl.Drawing.RectF(((float)(67D)), ((float)(30D)), ((float)(19D)), ((float)(23D)));
			this.Base1D.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base1D.Name = "Base1D";
			// 
			// arc2
			// 
			this.arc2.Bounds = new NxtControl.Drawing.RectF(((float)(64D)), ((float)(38.5D)), ((float)(14D)), ((float)(14D)));
			this.arc2.Center = new NxtControl.Drawing.PointF(71D, 45.5D);
			this.arc2.Name = "arc2";
			this.arc2.RadiusX = 7D;
			this.arc2.RadiusY = 7D;
			this.arc2.StartAngle = 130D;
			this.arc2.SweepAngle = 250D;
			// 
			// arc1
			// 
			this.arc1.Bounds = new NxtControl.Drawing.RectF(((float)(69.5D)), ((float)(40D)), ((float)(14D)), ((float)(14D)));
			this.arc1.Center = new NxtControl.Drawing.PointF(76.5D, 47D);
			this.arc1.Name = "arc1";
			this.arc1.RadiusX = 7D;
			this.arc1.RadiusY = 7D;
			this.arc1.StartAngle = 170D;
			this.arc1.SweepAngle = 250D;
			// 
			// Base3L
			// 
			this.Base3L.Bounds = new NxtControl.Drawing.RectF(((float)(87.9000015258789D)), ((float)(45D)), ((float)(3.0999999046325684D)), ((float)(3D)));
			this.Base3L.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base3L.Name = "Base3L";
			// 
			// Base2L
			// 
			this.Base2L.Bounds = new NxtControl.Drawing.RectF(((float)(83.766670227050781D)), ((float)(41D)), ((float)(4.1333332061767578D)), ((float)(10D)));
			this.Base2L.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base2L.Name = "Base2L";
			// 
			// Base1L
			// 
			this.Base1L.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(36D)), ((float)(23.766666412353516D)), ((float)(19D)));
			this.Base1L.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.Base1L.Name = "Base1L";
			// 
			// roundedRectangle4
			// 
			this.roundedRectangle4.Bounds = new NxtControl.Drawing.RectF(((float)(60D)), ((float)(36D)), ((float)(23.766666412353516D)), ((float)(19D)));
			this.roundedRectangle4.Font = new NxtControl.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle4.Name = "roundedRectangle4";
			this.roundedRectangle4.Radius = 12D;
			// 
			// MotBaseL
			// 
			this.MotBaseL.BeginInit();
			this.MotBaseL.Name = "MotBaseL";
			this.MotBaseL.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.MotBaseL.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base3L,
			this.Base2L,
			this.Base1L,
			this.roundedRectangle4});
			this.MotBaseL.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.MotBaseL.EndInit();
			// 
			// ReverseL
			// 
			this.ReverseL.BeginInit();
			this.ReverseL.Name = "ReverseL";
			this.ReverseL.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.arc2,
			this.polygon2});
			this.ReverseL.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ReverseL.EndInit();
			// 
			// ForwardL
			// 
			this.ForwardL.BeginInit();
			this.ForwardL.Name = "ForwardL";
			this.ForwardL.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon3,
			this.arc3});
			this.ForwardL.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ForwardL.EndInit();
			// 
			// MotBaseR
			// 
			this.MotBaseR.BeginInit();
			this.MotBaseR.Name = "MotBaseR";
			this.MotBaseR.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.MotBaseR.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base3R,
			this.Base2R,
			this.Base1R,
			this.roundedRectangle1});
			this.MotBaseR.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.MotBaseR.EndInit();
			// 
			// ReverseR
			// 
			this.ReverseR.BeginInit();
			this.ReverseR.Name = "ReverseR";
			this.ReverseR.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.arc4,
			this.polygon4});
			this.ReverseR.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ReverseR.EndInit();
			// 
			// ForwardR
			// 
			this.ForwardR.BeginInit();
			this.ForwardR.Name = "ForwardR";
			this.ForwardR.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon5,
			this.arc5});
			this.ForwardR.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ForwardR.EndInit();
			// 
			// MotbaseD
			// 
			this.MotbaseD.BeginInit();
			this.MotbaseD.Name = "MotbaseD";
			this.MotbaseD.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.MotbaseD.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base3D,
			this.Base2D,
			this.Base1D,
			this.roundedRectangle3});
			this.MotbaseD.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.MotbaseD.EndInit();
			// 
			// ForwardD
			// 
			this.ForwardD.BeginInit();
			this.ForwardD.Name = "ForwardD";
			this.ForwardD.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon7,
			this.arc7});
			this.ForwardD.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ForwardD.EndInit();
			// 
			// ReverseD
			// 
			this.ReverseD.BeginInit();
			this.ReverseD.Name = "ReverseD";
			this.ReverseD.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.arc6,
			this.polygon6});
			this.ReverseD.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ReverseD.EndInit();
			// 
			// MotbaseU
			// 
			this.MotbaseU.BeginInit();
			this.MotbaseU.Name = "MotbaseU";
			this.MotbaseU.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.MotbaseU.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.Base3U,
			this.Base2U,
			this.Base1U,
			this.roundedRectangle2});
			this.MotbaseU.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.MotbaseU.EndInit();
			// 
			// ReverseU
			// 
			this.ReverseU.BeginInit();
			this.ReverseU.Name = "ReverseU";
			this.ReverseU.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.ArcRev,
			this.Arrowrev});
			this.ReverseU.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ReverseU.EndInit();
			// 
			// ForwardU
			// 
			this.ForwardU.BeginInit();
			this.ForwardU.Name = "ForwardU";
			this.ForwardU.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.polygon1,
			this.arc1});
			this.ForwardU.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ForwardU.EndInit();
			// 
			// abnormal
			// 
			this.abnormal.BeginInit();
			this.abnormal.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 83D, 48D);
			this.abnormal.Name = "abnormal";
			this.abnormal.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.abnormal.EndInit();
			// 
			// alarmFrame
			// 
			this.alarmFrame.Bounds = new NxtControl.Drawing.RectF(((float)(14D)), ((float)(22D)), ((float)(108D)), ((float)(134D)));
			this.alarmFrame.FrameWidth = ((uint)(2u));
			this.alarmFrame.Name = "alarmFrame";
			this.alarmFrame.Radius = 5D;
			// 
			// SMeters
			// 
			this.SMeters.BeginInit();
			this.SMeters.AbnormalXOffset = 0D;
			this.SMeters.AbnormalYOffset = 0D;
			this.SMeters.BarGraphSize = 96D;
			this.SMeters.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, -13D, -5D);
			this.SMeters.FrameColor = new NxtControl.Drawing.Color("SymLineColor");
			this.SMeters.LeftOffset = ((uint)(60u));
			this.SMeters.Name = "SMeters";
			this.SMeters.NumericalVisible = SE.App2Base.Graphics.SMeters.NumericalDisplaySel.PvSp;
			this.SMeters.OpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymOp");
			this.SMeters.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.SMeters.PvColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymPv");
			this.SMeters.RangeVisible = SE.App2Base.SupportClasses.BoolType.False;
			this.SMeters.Rotation = SE.App2Base.SupportClasses.Rotation.Horizontal;
			this.SMeters.SpColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymSp");
			this.SMeters.SpIndicator = SE.App2Base.Graphics.SMeters.Indicator.PvBarSpTriangle;
			this.SMeters.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SMeters.TextAlignmentPvSpOp = SE.App2Base.Graphics.SMeters.TextAlignment.Right;
			this.SMeters.TextLocationPvSpOp = SE.App2Base.Graphics.SMeters.TextLocation.Right;
			this.SMeters.Unit = "%";
			this.SMeters.ValuePct = 0D;
			this.SMeters.EndInit();
			// 
			// state
			// 
			this.state.BeginInit();
			this.state.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 60D, 61D);
			this.state.ExternalControlled = false;
			this.state.Name = "state";
			this.state.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.state.EndInit();
			// 
			// owner
			// 
			this.owner.BeginInit();
			this.owner.BasicOwner = ((ushort)(0));
			this.owner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 76D, 61D);
			this.owner.ExternalAvailable = false;
			this.owner.InstanceName = "";
			this.owner.Name = "owner";
			this.owner.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.owner.OnAbnormalDetected += new SE.App2Base.Graphics.OwnerBasic.AbnormalDetected(this.OwnerOnAbnormalDetected);
			this.owner.EndInit();
			// 
			// FbStatus
			// 
			this.FbStatus.BeginInit();
			this.FbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbStatus.IsOnlyInput = true;
			this.FbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbStatus.Name = "FbStatus";
			this.FbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbStatus.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.FbStatus.TagName = "FbStatus";
			this.FbStatus.Value = ((short)(0));
			this.FbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbStatusValueChanged);
			this.FbStatus.EndInit();
			// 
			// TransFbStatus
			// 
			this.TransFbStatus.BeginInit();
			this.TransFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.TransFbStatus.IsOnlyInput = true;
			this.TransFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.TransFbStatus.Name = "TransFbStatus";
			this.TransFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.TransFbStatus.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.TransFbStatus.TagName = "TransFbStatus";
			this.TransFbStatus.Value = ((short)(0));
			this.TransFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.TransFbStatusValueChanged);
			this.TransFbStatus.EndInit();
			// 
			// SpeedFbStatus
			// 
			this.SpeedFbStatus.BeginInit();
			this.SpeedFbStatus.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedFbStatus.IsOnlyInput = true;
			this.SpeedFbStatus.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedFbStatus.Name = "SpeedFbStatus";
			this.SpeedFbStatus.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedFbStatus.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SpeedFbStatus.TagName = "SpeedFbStatus";
			this.SpeedFbStatus.Value = 0F;
			this.SpeedFbStatus.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedFbStatusValueChanged);
			this.SpeedFbStatus.EndInit();
			// 
			// CurrentOp
			// 
			this.CurrentOp.BeginInit();
			this.CurrentOp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOp.IsOnlyInput = true;
			this.CurrentOp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOp.Name = "CurrentOp";
			this.CurrentOp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.CurrentOp.TagName = "CurrentOp";
			this.CurrentOp.Value = ((short)(0));
			this.CurrentOp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOpValueChanged);
			this.CurrentOp.EndInit();
			// 
			// CurrentSpeedSp
			// 
			this.CurrentSpeedSp.BeginInit();
			this.CurrentSpeedSp.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentSpeedSp.IsOnlyInput = true;
			this.CurrentSpeedSp.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentSpeedSp.Name = "CurrentSpeedSp";
			this.CurrentSpeedSp.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentSpeedSp.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.CurrentSpeedSp.TagName = "CurrentSpeedSp";
			this.CurrentSpeedSp.Value = 0F;
			this.CurrentSpeedSp.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentSpeedSpValueChanged);
			this.CurrentSpeedSp.EndInit();
			// 
			// NeedReset
			// 
			this.NeedReset.BeginInit();
			this.NeedReset.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.NeedReset.IsOnlyInput = true;
			this.NeedReset.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.NeedReset.Name = "NeedReset";
			this.NeedReset.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.NeedReset.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.NeedReset.TagName = "NeedReset";
			this.NeedReset.Value = false;
			this.NeedReset.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.NeedResetValueChanged);
			this.NeedReset.EndInit();
			// 
			// IlckCond
			// 
			this.IlckCond.BeginInit();
			this.IlckCond.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.IlckCond.IsOnlyInput = true;
			this.IlckCond.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.IlckCond.Name = "IlckCond";
			this.IlckCond.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.IlckCond.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.IlckCond.TagName = "IlckCond";
			this.IlckCond.Value = false;
			this.IlckCond.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.IlckCondValueChanged);
			this.IlckCond.EndInit();
			// 
			// Fail
			// 
			this.Fail.BeginInit();
			this.Fail.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Fail.IsOnlyInput = true;
			this.Fail.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Fail.Name = "Fail";
			this.Fail.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Fail.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.Fail.TagName = "Fail";
			this.Fail.Value = false;
			this.Fail.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FailValueChanged);
			this.Fail.EndInit();
			// 
			// PermStop
			// 
			this.PermStop.BeginInit();
			this.PermStop.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PermStop.IsOnlyInput = true;
			this.PermStop.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PermStop.Name = "PermStop";
			this.PermStop.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PermStop.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.PermStop.TagName = "PermStop";
			this.PermStop.Value = false;
			this.PermStop.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermStopValueChanged);
			this.PermStop.EndInit();
			// 
			// PermFwd
			// 
			this.PermFwd.BeginInit();
			this.PermFwd.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PermFwd.IsOnlyInput = true;
			this.PermFwd.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PermFwd.Name = "PermFwd";
			this.PermFwd.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PermFwd.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.PermFwd.TagName = "PermFwd";
			this.PermFwd.Value = false;
			this.PermFwd.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermFwdValueChanged);
			this.PermFwd.EndInit();
			// 
			// PermRev
			// 
			this.PermRev.BeginInit();
			this.PermRev.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.PermRev.IsOnlyInput = true;
			this.PermRev.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.PermRev.Name = "PermRev";
			this.PermRev.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.PermRev.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.PermRev.TagName = "PermRev";
			this.PermRev.Value = false;
			this.PermRev.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.PermRevValueChanged);
			this.PermRev.EndInit();
			// 
			// StdOwnerConnected
			// 
			this.StdOwnerConnected.BeginInit();
			this.StdOwnerConnected.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.StdOwnerConnected.IsOnlyInput = true;
			this.StdOwnerConnected.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.StdOwnerConnected.Name = "StdOwnerConnected";
			this.StdOwnerConnected.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.StdOwnerConnected.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.StdOwnerConnected.TagName = "StdOwnerConnected";
			this.StdOwnerConnected.Value = false;
			this.StdOwnerConnected.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.StdOwnerConnectedValueChanged);
			this.StdOwnerConnected.EndInit();
			// 
			// SpeedSpMax
			// 
			this.SpeedSpMax.BeginInit();
			this.SpeedSpMax.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.SpeedSpMax.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.SpeedSpMax.Name = "SpeedSpMax";
			this.SpeedSpMax.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.SpeedSpMax.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.SpeedSpMax.TagName = "SpeedSpMax";
			this.SpeedSpMax.Value = 0F;
			this.SpeedSpMax.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SpeedSpMaxValueChanged);
			this.SpeedSpMax.EndInit();
			// 
			// Simulation
			// 
			this.Simulation.BeginInit();
			this.Simulation.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Simulation.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Simulation.Name = "Simulation";
			this.Simulation.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Simulation.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.Simulation.TagName = "Simulation";
			this.Simulation.Value = false;
			this.Simulation.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.SimulationValueChanged);
			this.Simulation.EndInit();
			// 
			// FbOverride
			// 
			this.FbOverride.BeginInit();
			this.FbOverride.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.FbOverride.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.FbOverride.Name = "FbOverride";
			this.FbOverride.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.FbOverride.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.FbOverride.TagName = "FbOverride";
			this.FbOverride.Value = false;
			this.FbOverride.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbOverrideValueChanged);
			this.FbOverride.EndInit();
			// 
			// Maintenance
			// 
			this.Maintenance.BeginInit();
			this.Maintenance.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.Maintenance.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.Maintenance.Name = "Maintenance";
			this.Maintenance.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.Maintenance.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.Maintenance.TagName = "Maintenance";
			this.Maintenance.Value = false;
			this.Maintenance.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.MaintenanceValueChanged);
			this.Maintenance.EndInit();
			// 
			// OutOfService
			// 
			this.OutOfService.BeginInit();
			this.OutOfService.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.OutOfService.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.OutOfService.Name = "OutOfService";
			this.OutOfService.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.OutOfService.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.OutOfService.TagName = "OutOfService";
			this.OutOfService.Value = false;
			this.OutOfService.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.OutOfServiceValueChanged);
			this.OutOfService.EndInit();
			// 
			// DisReverse
			// 
			this.DisReverse.BeginInit();
			this.DisReverse.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.DisReverse.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.DisReverse.Name = "DisReverse";
			this.DisReverse.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.DisReverse.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.DisReverse.TagName = "DisReverse";
			this.DisReverse.Value = false;
			this.DisReverse.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DisReverseValueChanged);
			this.DisReverse.EndInit();
			// 
			// failure
			// 
			this.failure.BeginInit();
			this.failure.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 41D, 61D);
			this.failure.FailSignal = false;
			this.failure.InstanceName = "";
			this.failure.Name = "failure";
			this.failure.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.failure.SymbolType = "SE.App2CommonProcess.Symbols.FailCondSum.sFailureSmall";
			this.failure.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AbnormalDetected(this.FailureOnAbnormalDetected);
			this.failure.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.FailureSmallBasic.AvailablityChanged(this.FailureOnAvailablityChanged);
			this.failure.EndInit();
			// 
			// interlock
			// 
			this.interlock.BeginInit();
			this.interlock.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 41D, 27D);
			this.interlock.InstanceName = "";
			this.interlock.InterlockSignal = false;
			this.interlock.Name = "interlock";
			this.interlock.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.interlock.SymbolType = "SE.App2CommonProcess.Symbols.IlckCondSum.sInterlockSmall";
			this.interlock.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AbnormalDetected(this.InterlockOnAbnormalDetected);
			this.interlock.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.InterlockSmallBasic.AvailablityChanged(this.InterlockOnAvailablityChanged);
			this.interlock.EndInit();
			// 
			// permissive
			// 
			this.permissive.BeginInit();
			this.permissive.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 41D, 44D);
			this.permissive.InstanceName = "";
			this.permissive.Name = "permissive";
			this.permissive.PermissiveActive1Signal = false;
			this.permissive.PermissiveActive2Signal = false;
			this.permissive.PermissivePassiveSignal = false;
			this.permissive.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.permissive.SymbolType = "SE.App2CommonProcess.Symbols.PermCondSum.sPermissiveSmall";
			this.permissive.OnAbnormalDetected += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AbnormalDetected(this.PermissiveOnAbnormalDetected);
			this.permissive.OnAvailablityChanged += new SE.App2CommonProcess.Graphics.PermissiveSmallBasic.AvailablityChanged(this.PermissiveOnAvailablityChanged);
			this.permissive.EndInit();
			// 
			// CurrentOwner
			// 
			this.CurrentOwner.BeginInit();
			this.CurrentOwner.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.CurrentOwner.IsOnlyInput = true;
			this.CurrentOwner.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.CurrentOwner.Name = "CurrentOwner";
			this.CurrentOwner.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.CurrentOwner.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.CurrentOwner.TagName = "CurrentOwner";
			this.CurrentOwner.Value = ((ushort)(0));
			this.CurrentOwner.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.CurrentOwnerValueChanged);
			this.CurrentOwner.EndInit();
			// 
			// InstanceName
			// 
			this.InstanceName.AngleIgnore = true;
			this.InstanceName.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.InstanceName.Bounds = new NxtControl.Drawing.RectF(((float)(18D)), ((float)(3.5D)), ((float)(42D)), ((float)(16D)));
			this.InstanceName.Brush = new NxtControl.Drawing.Brush(true);
			this.InstanceName.CustomInstanceName = null;
			this.InstanceName.Font = new NxtControl.Drawing.Font("SE.App2Base.SymInstanceLabel");
			this.InstanceName.FontScale = true;
			this.InstanceName.Name = "InstanceName";
			this.InstanceName.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.InstanceName.Text = "Label";
			this.InstanceName.TextAlignment = NxtControl.Drawing.ContentAlignment.MiddleLeft;
			this.InstanceName.TextAutoSize = true;
			this.InstanceName.TextColor = new NxtControl.Drawing.Color("SE.App2Base.aaLibSymInstanceLabelTextColor");
			// 
			// ExternalControlled
			// 
			this.ExternalControlled.BeginInit();
			this.ExternalControlled.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.ExternalControlled.IsOnlyInput = true;
			this.ExternalControlled.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.ExternalControlled.Name = "ExternalControlled";
			this.ExternalControlled.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.ExternalControlled.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.ExternalControlled.TagName = "ExternalControlled";
			this.ExternalControlled.Value = false;
			this.ExternalControlled.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.ExternalControlledValueChanged);
			this.ExternalControlled.EndInit();
			// 
			// execute_11
			// 
			this.execute_11.BeginInit();
			this.execute_11.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_11.IsOnlyInput = true;
			this.execute_11.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_11.Name = "execute_11";
			this.execute_11.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_11.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.execute_11.TagName = "DeviceFail";
			this.execute_11.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.execute_11.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.DeviceFailValueChanged);
			this.execute_11.EndInit();
			// 
			// execute_12
			// 
			this.execute_12.BeginInit();
			this.execute_12.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.execute_12.IsOnlyInput = true;
			this.execute_12.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.execute_12.Name = "execute_12";
			this.execute_12.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.execute_12.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.execute_12.TagName = "FbFail";
			this.execute_12.Value = new NxtControl.GuiFramework.VTQ<bool>(false, new System.DateTime(((long)(0))), ((uint)(0u)));
			this.execute_12.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.FbFailValueChanged);
			this.execute_12.EndInit();
			// 
			// group1
			// 
			this.group1.BeginInit();
			this.group1.Name = "group1";
			this.group1.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.MotBaseL,
			this.ReverseL,
			this.ForwardL,
			this.MotBaseR,
			this.ReverseR,
			this.ForwardR,
			this.MotbaseD,
			this.ForwardD,
			this.ReverseD,
			this.MotbaseU,
			this.ReverseU,
			this.ForwardU});
			this.group1.SymbolBackgroundClickState = GuiFramework.Shapes.SymbolBackgroundClickState.Unknown;
			this.group1.EndInit();
			// 
			// sMotor
			// 
			this.OpenFaceplates.Add(new NxtControl.GuiFramework.OpenFaceplate("fpDefault", NxtControl.GuiFramework.MouseButtonType.Click));
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.alarmFrame,
			this.FbStatus,
			this.TransFbStatus,
			this.SpeedFbStatus,
			this.CurrentOp,
			this.CurrentSpeedSp,
			this.NeedReset,
			this.IlckCond,
			this.Fail,
			this.PermStop,
			this.PermFwd,
			this.PermRev,
			this.StdOwnerConnected,
			this.SpeedSpMax,
			this.Simulation,
			this.FbOverride,
			this.Maintenance,
			this.OutOfService,
			this.DisReverse,
			this.state,
			this.owner,
			this.group1,
			this.abnormal,
			this.failure,
			this.interlock,
			this.permissive,
			this.CurrentOwner,
			this.SMeters,
			this.InstanceName,
			this.ExternalControlled,
			this.execute_11,
			this.execute_12});
			this.SymbolSize = new System.Drawing.Size(176, 211);
			this.UpdateOptionalService += new SE.App2Base.Symbols.SEAppLibHMISymbol.OnUpdateOptionalService(this.SMotorUpdateOptionalService);
			((System.ComponentModel.ISupportInitialize)(this.alarmFrame)).EndInit();

		}
		private NxtControl.GuiFramework.Rectangle Base3R;
		private NxtControl.GuiFramework.Polygon polygon3;
		private NxtControl.GuiFramework.Arc arc3;
		private NxtControl.GuiFramework.Polygon polygon1;
		private NxtControl.GuiFramework.Rectangle Base2R;
		private NxtControl.GuiFramework.Rectangle Base1R;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private NxtControl.GuiFramework.Arc arc4;
		private NxtControl.GuiFramework.Polygon polygon4;
		private NxtControl.GuiFramework.Polygon polygon5;
		private NxtControl.GuiFramework.Arc arc5;
		private NxtControl.GuiFramework.Rectangle Base3D;
		private NxtControl.GuiFramework.Polygon polygon2;
		private NxtControl.GuiFramework.Rectangle Base2D;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle3;
		private NxtControl.GuiFramework.Polygon polygon7;
		private NxtControl.GuiFramework.Arc arc7;
		private NxtControl.GuiFramework.Arc arc6;
		private NxtControl.GuiFramework.Polygon polygon6;
		private NxtControl.GuiFramework.Rectangle Base3U;
		private NxtControl.GuiFramework.Rectangle Base2U;
		private NxtControl.GuiFramework.Rectangle Base1U;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle2;
		private NxtControl.GuiFramework.Arc ArcRev;
		private NxtControl.GuiFramework.Polygon Arrowrev;
		private NxtControl.GuiFramework.Rectangle Base1D;
		private NxtControl.GuiFramework.Arc arc2;
		private NxtControl.GuiFramework.Arc arc1;
		private NxtControl.GuiFramework.Rectangle Base3L;
		private NxtControl.GuiFramework.Rectangle Base2L;
		private NxtControl.GuiFramework.Rectangle Base1L;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle4;
		private NxtControl.GuiFramework.Group MotBaseL;
		private NxtControl.GuiFramework.Group ReverseL;
		private NxtControl.GuiFramework.Group ForwardL;
		private NxtControl.GuiFramework.Group MotBaseR;
		private NxtControl.GuiFramework.Group ReverseR;
		private NxtControl.GuiFramework.Group ForwardR;
		private NxtControl.GuiFramework.Group MotbaseD;
		private NxtControl.GuiFramework.Group ForwardD;
		private NxtControl.GuiFramework.Group ReverseD;
		private NxtControl.GuiFramework.Group MotbaseU;
		private NxtControl.GuiFramework.Group ReverseU;
		private NxtControl.GuiFramework.Group ForwardU;
		private SE.App2Base.Graphics.Abnormal abnormal;
		private NxtControl.GuiFramework.AlarmFrame alarmFrame;
		private NxtControl.GuiFramework.AliasDisplayLabel InstanceName;
		private SE.App2Base.Graphics.SMeters SMeters;
		private SE.App2Base.Graphics.State state;
		private SE.App2Base.Graphics.OwnerBasic owner;
		private System.HMI.Symbols.Base.Execute<short> FbStatus;
		private System.HMI.Symbols.Base.Execute<short> TransFbStatus;
		private System.HMI.Symbols.Base.Execute<float> SpeedFbStatus;
		private System.HMI.Symbols.Base.Execute<short> CurrentOp;
		private System.HMI.Symbols.Base.Execute<float> CurrentSpeedSp;
		private System.HMI.Symbols.Base.Execute<bool> NeedReset;
		private System.HMI.Symbols.Base.Execute<bool> IlckCond;
		private System.HMI.Symbols.Base.Execute<bool> Fail;
		private System.HMI.Symbols.Base.Execute<bool> PermStop;
		private System.HMI.Symbols.Base.Execute<bool> PermFwd;
		private System.HMI.Symbols.Base.Execute<bool> PermRev;
		private System.HMI.Symbols.Base.Execute<bool> StdOwnerConnected;
		private System.HMI.Symbols.Base.Execute<float> SpeedSpMax;
		private System.HMI.Symbols.Base.Execute<bool> Simulation;
		private System.HMI.Symbols.Base.Execute<bool> FbOverride;
		private System.HMI.Symbols.Base.Execute<bool> Maintenance;
		private System.HMI.Symbols.Base.Execute<bool> OutOfService;
		private System.HMI.Symbols.Base.Execute<bool> DisReverse;
		private SE.App2CommonProcess.Graphics.FailureSmallBasic failure;
		private SE.App2CommonProcess.Graphics.InterlockSmallBasic interlock;
		private SE.App2CommonProcess.Graphics.PermissiveSmallBasic permissive;
		private NxtControl.GuiFramework.Group group1;
		private System.HMI.Symbols.Base.Execute<ushort> CurrentOwner;
		private System.HMI.Symbols.Base.Execute<bool> ExternalControlled;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_11;
		private System.HMI.Symbols.Base.Execute<NxtControl.GuiFramework.VTQ<bool>> execute_12;
		#endregion
	}
}



