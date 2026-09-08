/*
 * Created by EcoStruxure Automation Expert.
 * User:  
 * Date: 2/24/2026
 * Time: 11:57 AM
 * 
 */
using System;
using System.ComponentModel;
using System.Collections;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Symbols.Gradeamento
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
			this.Grade_Equipamentos1 = new Hidryco.HidrycoLib.Symbols.Grade_Equipamentos.sDefault();
			this.Grade_Equipamentos2 = new Hidryco.HidrycoLib.Symbols.Grade_Equipamentos.sDefault();
			this.Grade_Status1 = new Hidryco.HidrycoLib.Symbols.Grade_Comandos.sDefault();
			this.Motor_Status1 = new Hidryco.HidrycoLib.Symbols.Motor_Status.Motor();
			this.rosca_Transportadora1 = new Hidryco.HidrycoLib.Graphics.Rosca_Transportadora();
			this.resetFalhasProcesso = new NxtControl.GuiFramework.DrawnButton();
			this.roundedRectangle1 = new NxtControl.GuiFramework.RoundedRectangle();
			this.CO_100_02 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta();
			this.CO_100_01 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta();
			this.CO_100_04 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta();
			this.CO_100_03 = new Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta();
			// 
			// Grade_Equipamentos1
			// 
			this.Grade_Equipamentos1.BeginInit();
			this.Grade_Equipamentos1.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.95453641857506355D, 0D, 0D, 0.99127540924626723D, 295D, 42D);
			this.Grade_Equipamentos1.Name = "Grade_Equipamentos1";
			this.Grade_Equipamentos1.SecurityToken = ((uint)(4294967295u));
			this.Grade_Equipamentos1.TagName = "GM_100_02";
			this.Grade_Equipamentos1.EndInit();
			// 
			// Grade_Equipamentos2
			// 
			this.Grade_Equipamentos2.BeginInit();
			this.Grade_Equipamentos2.DesignMatrix = new NxtControl.Drawing.Matrix2D(0.95453641857506344D, 0D, 0D, 0.99127540924626723D, 295D, 359D);
			this.Grade_Equipamentos2.Name = "Grade_Equipamentos2";
			this.Grade_Equipamentos2.SecurityToken = ((uint)(4294967295u));
			this.Grade_Equipamentos2.TagName = "GM_100_01";
			this.Grade_Equipamentos2.EndInit();
			// 
			// Grade_Status1
			// 
			this.Grade_Status1.BeginInit();
			this.Grade_Status1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.0446428571428572D, 0D, 0D, 0.993421052631579D, 11D, 11D);
			this.Grade_Status1.Name = "Grade_Status1";
			this.Grade_Status1.SecurityToken = ((uint)(4294967295u));
			this.Grade_Status1.TagName = "Grade_Status1";
			this.Grade_Status1.EndInit();
			// 
			// Motor_Status1
			// 
			this.Motor_Status1.BeginInit();
			this.Motor_Status1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1.4356435643564356D, 0D, 0D, 1.3333333333333333D, 901D, 84D);
			this.Motor_Status1.Name = "Motor_Status1";
			this.Motor_Status1.SecurityToken = ((uint)(4294967295u));
			this.Motor_Status1.TagName = "RT_100_01";
			this.Motor_Status1.EndInit();
			// 
			// rosca_Transportadora1
			// 
			this.rosca_Transportadora1.BeginInit();
			this.rosca_Transportadora1.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1.6845238095238098D, 902D, 127D);
			this.rosca_Transportadora1.Name = "rosca_Transportadora1";
			this.rosca_Transportadora1.EndInit();
			// 
			// resetFalhasProcesso
			// 
			this.resetFalhasProcesso.Bounds = new NxtControl.Drawing.RectF(((float)(1149D)), ((float)(28D)), ((float)(120D)), ((float)(36D)));
			this.resetFalhasProcesso.Brush = new NxtControl.Drawing.Brush("ButtonBrush");
			this.resetFalhasProcesso.Font = new NxtControl.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular);
			this.resetFalhasProcesso.InnerBorderColor = new NxtControl.Drawing.Color("ButtonInnerBorderColor");
			this.resetFalhasProcesso.Name = "resetFalhasProcesso";
			this.resetFalhasProcesso.Pen = new NxtControl.Drawing.Pen("ButtonPen");
			this.resetFalhasProcesso.Radius = 4D;
			this.resetFalhasProcesso.Text = "Reset Falhas";
			this.resetFalhasProcesso.TextColor = new NxtControl.Drawing.Color("ButtonTextColor");
			this.resetFalhasProcesso.TextColorMouseDown = new NxtControl.Drawing.Color("ButtonTextColorMouseDown");
			this.resetFalhasProcesso.Use3DEffect = false;
			this.resetFalhasProcesso.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResetFalhasProcessoMouseDown);
			this.resetFalhasProcesso.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ResetFalhasProcessoMouseUp);
			// 
			// roundedRectangle1
			// 
			this.roundedRectangle1.Bounds = new NxtControl.Drawing.RectF(((float)(1129D)), ((float)(17D)), ((float)(160D)), ((float)(59D)));
			this.roundedRectangle1.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color("Transparent"));
			this.roundedRectangle1.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.roundedRectangle1.Name = "roundedRectangle1";
			// 
			// CO_100_02
			// 
			this.CO_100_02.BeginInit();
			this.CO_100_02.DefaultInstanceName = null;
			this.CO_100_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 184D, 196D);
			this.CO_100_02.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.CO_100_02.MyTagDisplayName = null;
			this.CO_100_02.Name = "CO_100_02";
			this.CO_100_02.SecurityToken = ((uint)(4294967295u));
			this.CO_100_02.TagName = "CO_100_02";
			this.CO_100_02.EndInit();
			// 
			// CO_100_01
			// 
			this.CO_100_01.BeginInit();
			this.CO_100_01.DefaultInstanceName = null;
			this.CO_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 184D, 515D);
			this.CO_100_01.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.CO_100_01.MyTagDisplayName = null;
			this.CO_100_01.Name = "CO_100_01";
			this.CO_100_01.SecurityToken = ((uint)(4294967295u));
			this.CO_100_01.TagName = "CO_100_01";
			this.CO_100_01.EndInit();
			// 
			// CO_100_04
			// 
			this.CO_100_04.BeginInit();
			this.CO_100_04.DefaultInstanceName = null;
			this.CO_100_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1016D, 196D);
			this.CO_100_04.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.CO_100_04.MyTagDisplayName = null;
			this.CO_100_04.Name = "CO_100_04";
			this.CO_100_04.SecurityToken = ((uint)(4294967295u));
			this.CO_100_04.TagName = "CO_100_04";
			this.CO_100_04.EndInit();
			// 
			// CO_100_03
			// 
			this.CO_100_03.BeginInit();
			this.CO_100_03.DefaultInstanceName = null;
			this.CO_100_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 1016D, 515D);
			this.CO_100_03.Instancelayer = SE.App2Base.SupportClasses.InstanceLayer.Base;
			this.CO_100_03.MyTagDisplayName = null;
			this.CO_100_03.Name = "CO_100_03";
			this.CO_100_03.SecurityToken = ((uint)(4294967295u));
			this.CO_100_03.TagName = "CO_100_03";
			this.CO_100_03.EndInit();
			// 
			// sDefault
			// 
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.roundedRectangle1,
			this.Grade_Equipamentos1,
			this.Grade_Equipamentos2,
			this.Grade_Status1,
			this.Motor_Status1,
			this.rosca_Transportadora1,
			this.resetFalhasProcesso,
			this.CO_100_02,
			this.CO_100_01,
			this.CO_100_04,
			this.CO_100_03});
			this.SymbolSize = new System.Drawing.Size(1300, 700);

		}
		private Hidryco.HidrycoLib.Symbols.Grade_Equipamentos.sDefault Grade_Equipamentos1;
		private Hidryco.HidrycoLib.Symbols.Grade_Equipamentos.sDefault Grade_Equipamentos2;
		private Hidryco.HidrycoLib.Symbols.Grade_Comandos.sDefault Grade_Status1;
		private Hidryco.HidrycoLib.Symbols.Motor_Status.Motor Motor_Status1;
		private Hidryco.HidrycoLib.Graphics.Rosca_Transportadora rosca_Transportadora1;
		private NxtControl.GuiFramework.DrawnButton resetFalhasProcesso;
		private NxtControl.GuiFramework.RoundedRectangle roundedRectangle1;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta CO_100_02;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta CO_100_01;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta CO_100_04;
		private Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T.Comporta CO_100_03;
		#endregion
	}
}
