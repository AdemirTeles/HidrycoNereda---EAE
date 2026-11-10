/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 6/10/2026
 * Time: 3:50 PM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;

using NxtControl.GuiFramework;

namespace HMI.Main.Canvases
{
	/// <summary>
	/// Summary description for OVER_VIEW.
	/// </summary>
	partial class OVER_VIEW
	{
		#region Component Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAckNereda = new NxtControl.GuiFramework.DrawnButton();
			this.HeartBeat = new SE.Nereda.Symbols.HeartBeat.sDefault();
			this.Mode = new SE.Nereda.Symbols.Mode.ReactorMode();
			this.OpenWebPage = new SE.Nereda.Symbols.OpenWebPage.sDefault();
			this.cAlim = new NxtControl.GuiFramework.Rectangle();
			this.cRea = new NxtControl.GuiFramework.Rectangle();
			this.cAer = new NxtControl.GuiFramework.Rectangle();
			this.cLodo = new NxtControl.GuiFramework.Rectangle();
			this.irAlim = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irR1 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irR2 = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irAer = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.irLodo = new NxtControl.GuiFramework.ChangeCanvasButton();
			this.InfluentFeed = new SE.Nereda.Symbols.InfluentFeed.sInfluentFeed2();
			this.Reactor1 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.FaseR1 = new SE.Nereda.Symbols.NeredaReactor.sFase();
			this.Reactor2 = new SE.Nereda.Symbols.NeredaReactor.sReactor4();
			this.FaseR2 = new SE.Nereda.Symbols.NeredaReactor.sFase();
			this.Aeration = new SE.Nereda.Symbols.NeredaCAeration.sBlowers();
			this.SludgeBuffer = new SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSludgeBufferyellow();
			// 
			// btnAckNereda
			// 
			this.btnAckNereda.Bounds = new NxtControl.Drawing.RectF(((float)(212D)), ((float)(12D)), ((float)(200D)), ((float)(32D)));
			this.btnAckNereda.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208))));
			this.btnAckNereda.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.btnAckNereda.InnerBorderColor = new NxtControl.Drawing.Color(((byte)(208)), ((byte)(208)), ((byte)(208)));
			this.btnAckNereda.Name = "btnAckNereda";
			this.btnAckNereda.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(160)), ((byte)(160)), ((byte)(160))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.btnAckNereda.Radius = 2D;
			this.btnAckNereda.Text = "Reconhecer alarmes";
			this.btnAckNereda.Use3DEffect = false;
			this.btnAckNereda.Click += new System.EventHandler(this.BtnAckNeredaClick);
			// 
			// HeartBeat
			// 
			this.HeartBeat.BeginInit();
			this.HeartBeat.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 8D, 8D);
			this.HeartBeat.Name = "HeartBeat";
			this.HeartBeat.SecurityToken = ((uint)(4294967295u));
			this.HeartBeat.TagName = "1A7AD4234C2BE11C";
			this.HeartBeat.EndInit();
			// 
			// Mode
			// 
			this.Mode.BeginInit();
			this.Mode.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 424D, 8D);
			this.Mode.Name = "Mode";
			this.Mode.SecurityToken = ((uint)(4294967295u));
			this.Mode.TagName = "ECC9B0BB08A85534";
			this.Mode.EndInit();
			// 
			// OpenWebPage
			// 
			this.OpenWebPage.BeginInit();
			this.OpenWebPage.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 840D, 8D);
			this.OpenWebPage.Name = "OpenWebPage";
			this.OpenWebPage.SecurityToken = ((uint)(4294967295u));
			this.OpenWebPage.TagName = "61C067078E62D90F";
			this.OpenWebPage.EndInit();
			// 
			// cAlim
			// 
			this.cAlim.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(54D)), ((float)(604D)), ((float)(356D)));
			this.cAlim.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.cAlim.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cAlim.Name = "cAlim";
			this.cAlim.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cRea
			// 
			this.cRea.Bounds = new NxtControl.Drawing.RectF(((float)(616D)), ((float)(54D)), ((float)(744D)), ((float)(356D)));
			this.cRea.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.cRea.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cRea.Name = "cRea";
			this.cRea.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cAer
			// 
			this.cAer.Bounds = new NxtControl.Drawing.RectF(((float)(6D)), ((float)(416D)), ((float)(604D)), ((float)(276D)));
			this.cAer.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.cAer.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cAer.Name = "cAer";
			this.cAer.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// cLodo
			// 
			this.cLodo.Bounds = new NxtControl.Drawing.RectF(((float)(616D)), ((float)(416D)), ((float)(744D)), ((float)(276D)));
			this.cLodo.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(238)), ((byte)(238)), ((byte)(238))));
			this.cLodo.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cLodo.Name = "cLodo";
			this.cLodo.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(170)), ((byte)(170)), ((byte)(170))), 1F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// irAlim
			// 
			this.irAlim.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(60D)), ((float)(592D)), ((float)(24D)));
			this.irAlim.CanvasName = "INFLUENT_FEED";
			this.irAlim.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irAlim.Name = "irAlim";
			this.irAlim.Text = "ALIMENTA\u00c7\u00c3O  \u203a";
			// 
			// irR1
			// 
			this.irR1.Bounds = new NxtControl.Drawing.RectF(((float)(622D)), ((float)(60D)), ((float)(364D)), ((float)(24D)));
			this.irR1.CanvasName = "REACTOR1";
			this.irR1.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irR1.Name = "irR1";
			this.irR1.Text = "REATOR NEREDA 1  \u203a";
			// 
			// irR2
			// 
			this.irR2.Bounds = new NxtControl.Drawing.RectF(((float)(990D)), ((float)(60D)), ((float)(364D)), ((float)(24D)));
			this.irR2.CanvasName = "REACTOR2";
			this.irR2.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irR2.Name = "irR2";
			this.irR2.Text = "REATOR NEREDA 2  \u203a";
			// 
			// irAer
			// 
			this.irAer.Bounds = new NxtControl.Drawing.RectF(((float)(12D)), ((float)(422D)), ((float)(592D)), ((float)(24D)));
			this.irAer.CanvasName = "AERATION";
			this.irAer.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irAer.Name = "irAer";
			this.irAer.Text = "AERA\u00c7\u00c3O  \u203a";
			// 
			// irLodo
			// 
			this.irLodo.Bounds = new NxtControl.Drawing.RectF(((float)(622D)), ((float)(422D)), ((float)(732D)), ((float)(24D)));
			this.irLodo.CanvasName = "SLUDGE_BUFFER";
			this.irLodo.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
			this.irLodo.Name = "irLodo";
			this.irLodo.Text = "BUFFER DE LODO  \u203a";
			// 
			// InfluentFeed
			// 
			this.InfluentFeed.BeginInit();
			this.InfluentFeed.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6852D, 0D, 0D, 0.6852D, 12.0D, 96.0D);
			this.InfluentFeed.Name = "InfluentFeed";
			this.InfluentFeed.SecurityToken = ((uint)(4294967295u));
			this.InfluentFeed.TagName = "B949570768DD3945";
			this.InfluentFeed.EndInit();
			// 
			// Reactor1
			// 
			this.Reactor1.BeginInit();
			this.Reactor1._iAV4x101 = "AV41101\r\nAlimenta\u00e7\u00e3o";
			this.Reactor1._iAV4x102 = "AV41102\r\nN\u00edvel inferior";
			this.Reactor1._iAV4x103 = "AV41103\r\nDescarte de lodo";
			this.Reactor1._iAV4x170 = "AV41170\r\nAera\u00e7\u00e3o";
			this.Reactor1._iAV4x171 = "AV41171\r\nPressuriza\u00e7\u00e3o";
			this.Reactor1._iAV4x172 = "AV41172\r\nRespiro lodo";
			this.Reactor1._iLT001 = "41LT1005\r\nN\u00edvel";
			this.Reactor1._iREACTOR = "Reator Nereda 1";
			this.Reactor1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49D, 0D, 0D, 0.49D, 621.0D, 92.0D);
			this.Reactor1.Name = "Reactor1";
			this.Reactor1.SecurityToken = ((uint)(4294967295u));
			this.Reactor1.TagName = "0F513B831BAFCB32";
			this.Reactor1.EndInit();
			// 
			// FaseR1
			// 
			this.FaseR1.BeginInit();
			this.FaseR1._iNome = "Fase atual";
			this.FaseR1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3D, 0D, 0D, 1.3D, 685.0D, 342.0D);
			this.FaseR1.Name = "FaseR1";
			this.FaseR1.SecurityToken = ((uint)(4294967295u));
			this.FaseR1.TagName = "0F513B831BAFCB32";
			this.FaseR1.EndInit();
			// 
			// Reactor2
			// 
			this.Reactor2.BeginInit();
			this.Reactor2._iAV4x101 = "AV42101\r\nAlimenta\u00e7\u00e3o";
			this.Reactor2._iAV4x102 = "AV42102\r\nN\u00edvel inferior";
			this.Reactor2._iAV4x103 = "AV42103\r\nDescarte de lodo";
			this.Reactor2._iAV4x170 = "AV42170\r\nAera\u00e7\u00e3o";
			this.Reactor2._iAV4x171 = "AV42171\r\nPressuriza\u00e7\u00e3o";
			this.Reactor2._iAV4x172 = "AV42172\r\nRespiro lodo";
			this.Reactor2._iLT001 = "42LT1005\r\nN\u00edvel";
			this.Reactor2._iREACTOR = "Reator Nereda 2";
			this.Reactor2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.49D, 0D, 0D, 0.49D, 993.0D, 92.0D);
			this.Reactor2.Name = "Reactor2";
			this.Reactor2.SecurityToken = ((uint)(4294967295u));
			this.Reactor2.TagName = "19E8555E9622C1D3";
			this.Reactor2.EndInit();
			// 
			// FaseR2
			// 
			this.FaseR2.BeginInit();
			this.FaseR2._iNome = "Fase atual";
			this.FaseR2.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.3D, 0D, 0D, 1.3D, 1057.0D, 342.0D);
			this.FaseR2.Name = "FaseR2";
			this.FaseR2.SecurityToken = ((uint)(4294967295u));
			this.FaseR2.TagName = "19E8555E9622C1D3";
			this.FaseR2.EndInit();
			// 
			// Aeration
			// 
			this.Aeration.BeginInit();
			this.Aeration.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.75D, 0D, 0D, 0.75D, 92.0D, 452.0D);
			this.Aeration.Name = "Aeration";
			this.Aeration.SecurityToken = ((uint)(4294967295u));
			this.Aeration.TagName = "35A194BD3A715270";
			this.Aeration.EndInit();
			// 
			// SludgeBuffer
			// 
			this.SludgeBuffer.BeginInit();
			this.SludgeBuffer.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.6D, 0D, 0D, 0.5545D, 629D, 452D);
			this.SludgeBuffer.Name = "SludgeBuffer";
			this.SludgeBuffer.SecurityToken = ((uint)(4294967295u));
			this.SludgeBuffer.TagName = "2EDD2709EE346B30";
			this.SludgeBuffer.EndInit();
			// 
			// OVER_VIEW
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1366D)), ((float)(698D)));
			this.Brush = new NxtControl.Drawing.Brush("CanvasBrush");
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cAlim,
			this.cRea,
			this.cAer,
			this.cLodo,
			this.irAlim,
			this.irR1,
			this.irR2,
			this.irAer,
			this.irLodo,
			this.InfluentFeed,
			this.Reactor1,
			this.FaseR1,
			this.Reactor2,
			this.FaseR2,
			this.Aeration,
			this.SludgeBuffer,
			this.HeartBeat,
			this.Mode,
			this.OpenWebPage,
			this.btnAckNereda});
			this.Size = new System.Drawing.Size(1366, 698);

		}
		private SE.Nereda.Symbols.HeartBeat.sDefault HeartBeat;
		private SE.Nereda.Symbols.Mode.ReactorMode Mode;
		private SE.Nereda.Symbols.OpenWebPage.sDefault OpenWebPage;
		private NxtControl.GuiFramework.DrawnButton btnAckNereda;
		private NxtControl.GuiFramework.Rectangle cAlim;
		private NxtControl.GuiFramework.Rectangle cRea;
		private NxtControl.GuiFramework.Rectangle cAer;
		private NxtControl.GuiFramework.Rectangle cLodo;
		private NxtControl.GuiFramework.ChangeCanvasButton irAlim;
		private NxtControl.GuiFramework.ChangeCanvasButton irR1;
		private NxtControl.GuiFramework.ChangeCanvasButton irR2;
		private NxtControl.GuiFramework.ChangeCanvasButton irAer;
		private NxtControl.GuiFramework.ChangeCanvasButton irLodo;
		private SE.Nereda.Symbols.InfluentFeed.sInfluentFeed2 InfluentFeed;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 Reactor1;
		private SE.Nereda.Symbols.NeredaReactor.sFase FaseR1;
		private SE.Nereda.Symbols.NeredaReactor.sReactor4 Reactor2;
		private SE.Nereda.Symbols.NeredaReactor.sFase FaseR2;
		private SE.Nereda.Symbols.NeredaCAeration.sBlowers Aeration;
		private SE.Nereda.Symbols.NeredaSludgeBuffer_2.sSludgeBufferyellow SludgeBuffer;
		#endregion
	}
}
