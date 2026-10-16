/*
 * Hidryco - Subestacao - fpCargas
 * Cargas liberadas para operar com a planta nos geradores. Raio: contorno = nao liberada; cinza = liberada (planta na rede); vermelho = liberada e planta nos geradores.
 */
using System;
using System.ComponentModel;
using System.Collections;
using System.Diagnostics;
using NxtControl.GuiFramework;

namespace Hidryco.HidrycoLib.Faceplates.Subestacao
{
	/// <summary>
	/// Summary description for fpCargas.
	/// </summary>
	partial class fpCargas
	{

		#region Component Designer generated code
		private void InitializeComponent()
		{
			this.cabecalho = new NxtControl.GuiFramework.Rectangle();
			this.titulo = new NxtControl.GuiFramework.FreeText();
			this.tPlanta = new NxtControl.GuiFramework.FreeText();
			this.g0_0 = new NxtControl.GuiFramework.FreeText();
			this.raio_V4601 = new NxtControl.GuiFramework.Polygon();
			this.n_V4601 = new NxtControl.GuiFramework.FreeText();
			this.c_V4601 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_V4602 = new NxtControl.GuiFramework.Polygon();
			this.n_V4602 = new NxtControl.GuiFramework.FreeText();
			this.c_V4602 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_V4603 = new NxtControl.GuiFramework.Polygon();
			this.n_V4603 = new NxtControl.GuiFramework.FreeText();
			this.c_V4603 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_V4604 = new NxtControl.GuiFramework.Polygon();
			this.n_V4604 = new NxtControl.GuiFramework.FreeText();
			this.c_V4604 = new System.HMI.Symbols.Base.CheckButton();
			this.g0_1 = new NxtControl.GuiFramework.FreeText();
			this.raio_EX_500_01 = new NxtControl.GuiFramework.Polygon();
			this.n_EX_500_01 = new NxtControl.GuiFramework.FreeText();
			this.c_EX_500_01 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_EX_500_02 = new NxtControl.GuiFramework.Polygon();
			this.n_EX_500_02 = new NxtControl.GuiFramework.FreeText();
			this.c_EX_500_02 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_EX_500_03 = new NxtControl.GuiFramework.Polygon();
			this.n_EX_500_03 = new NxtControl.GuiFramework.FreeText();
			this.c_EX_500_03 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_EX_500_04 = new NxtControl.GuiFramework.Polygon();
			this.n_EX_500_04 = new NxtControl.GuiFramework.FreeText();
			this.c_EX_500_04 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_EX_500_05 = new NxtControl.GuiFramework.Polygon();
			this.n_EX_500_05 = new NxtControl.GuiFramework.FreeText();
			this.c_EX_500_05 = new System.HMI.Symbols.Base.CheckButton();
			this.g0_2 = new NxtControl.GuiFramework.FreeText();
			this.raio_COMP_500_01 = new NxtControl.GuiFramework.Polygon();
			this.n_COMP_500_01 = new NxtControl.GuiFramework.FreeText();
			this.c_COMP_500_01 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_COMP_500_02 = new NxtControl.GuiFramework.Polygon();
			this.n_COMP_500_02 = new NxtControl.GuiFramework.FreeText();
			this.c_COMP_500_02 = new System.HMI.Symbols.Base.CheckButton();
			this.g1_0 = new NxtControl.GuiFramework.FreeText();
			this.raio_UCT_200_01 = new NxtControl.GuiFramework.Polygon();
			this.n_UCT_200_01 = new NxtControl.GuiFramework.FreeText();
			this.c_UCT_200_01 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_UCT_200_02 = new NxtControl.GuiFramework.Polygon();
			this.n_UCT_200_02 = new NxtControl.GuiFramework.FreeText();
			this.c_UCT_200_02 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_UCT_200_03 = new NxtControl.GuiFramework.Polygon();
			this.n_UCT_200_03 = new NxtControl.GuiFramework.FreeText();
			this.c_UCT_200_03 = new System.HMI.Symbols.Base.CheckButton();
			this.g1_1 = new NxtControl.GuiFramework.FreeText();
			this.raio_BS_100_01 = new NxtControl.GuiFramework.Polygon();
			this.n_BS_100_01 = new NxtControl.GuiFramework.FreeText();
			this.c_BS_100_01 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_BS_100_02 = new NxtControl.GuiFramework.Polygon();
			this.n_BS_100_02 = new NxtControl.GuiFramework.FreeText();
			this.c_BS_100_02 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_BS_100_03 = new NxtControl.GuiFramework.Polygon();
			this.n_BS_100_03 = new NxtControl.GuiFramework.FreeText();
			this.c_BS_100_03 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_GM_100_01 = new NxtControl.GuiFramework.Polygon();
			this.n_GM_100_01 = new NxtControl.GuiFramework.FreeText();
			this.c_GM_100_01 = new System.HMI.Symbols.Base.CheckButton();
			this.g1_2 = new NxtControl.GuiFramework.FreeText();
			this.raio_UV_700_01 = new NxtControl.GuiFramework.Polygon();
			this.n_UV_700_01 = new NxtControl.GuiFramework.FreeText();
			this.c_UV_700_01 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_UV_700_02 = new NxtControl.GuiFramework.Polygon();
			this.n_UV_700_02 = new NxtControl.GuiFramework.FreeText();
			this.c_UV_700_02 = new System.HMI.Symbols.Base.CheckButton();
			this.g1_3 = new NxtControl.GuiFramework.FreeText();
			this.raio_DO_800_04 = new NxtControl.GuiFramework.Polygon();
			this.n_DO_800_04 = new NxtControl.GuiFramework.FreeText();
			this.c_DO_800_04 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_DO_800_05 = new NxtControl.GuiFramework.Polygon();
			this.n_DO_800_05 = new NxtControl.GuiFramework.FreeText();
			this.c_DO_800_05 = new System.HMI.Symbols.Base.CheckButton();
			this.g2_0 = new NxtControl.GuiFramework.FreeText();
			this.raio_P4901 = new NxtControl.GuiFramework.Polygon();
			this.n_P4901 = new NxtControl.GuiFramework.FreeText();
			this.c_P4901 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_P4902 = new NxtControl.GuiFramework.Polygon();
			this.n_P4902 = new NxtControl.GuiFramework.FreeText();
			this.c_P4902 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_P4903 = new NxtControl.GuiFramework.Polygon();
			this.n_P4903 = new NxtControl.GuiFramework.FreeText();
			this.c_P4903 = new System.HMI.Symbols.Base.CheckButton();
			this.raio_R4005A = new NxtControl.GuiFramework.Polygon();
			this.n_R4005A = new NxtControl.GuiFramework.FreeText();
			this.c_R4005A = new System.HMI.Symbols.Base.CheckButton();
			this.raio_R4005B = new NxtControl.GuiFramework.Polygon();
			this.n_R4005B = new NxtControl.GuiFramework.FreeText();
			this.c_R4005B = new System.HMI.Symbols.Base.CheckButton();
			this.raio_MO_300_01 = new NxtControl.GuiFramework.Polygon();
			this.n_MO_300_01 = new NxtControl.GuiFramework.FreeText();
			this.c_MO_300_01 = new System.HMI.Symbols.Base.CheckButton();
			this.g2_1 = new NxtControl.GuiFramework.FreeText();
			this.raio_QL_PORTARIA = new NxtControl.GuiFramework.Polygon();
			this.n_QL_PORTARIA = new NxtControl.GuiFramework.FreeText();
			this.c_QL_PORTARIA = new System.HMI.Symbols.Base.CheckButton();
			this.raio_QL_ADM = new NxtControl.GuiFramework.Polygon();
			this.n_QL_ADM = new NxtControl.GuiFramework.FreeText();
			this.c_QL_ADM = new System.HMI.Symbols.Base.CheckButton();
			this.raio_QL_LODO = new NxtControl.GuiFramework.Polygon();
			this.n_QL_LODO = new NxtControl.GuiFramework.FreeText();
			this.c_QL_LODO = new System.HMI.Symbols.Base.CheckButton();
			this.raio_QLSL = new NxtControl.GuiFramework.Polygon();
			this.n_QLSL = new NxtControl.GuiFramework.FreeText();
			this.c_QLSL = new System.HMI.Symbols.Base.CheckButton();
			this.raio_QL_ILUMINACAO = new NxtControl.GuiFramework.Polygon();
			this.n_QL_ILUMINACAO = new NxtControl.GuiFramework.FreeText();
			this.c_QL_ILUMINACAO = new System.HMI.Symbols.Base.CheckButton();
			this.xH_V4601 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_V4602 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_V4603 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_V4604 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_EX_500_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_EX_500_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_EX_500_03 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_EX_500_04 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_EX_500_05 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_COMP_500_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_COMP_500_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_UCT_200_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_UCT_200_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_UCT_200_03 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_BS_100_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_BS_100_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_BS_100_03 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_GM_100_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_UV_700_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_UV_700_02 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_DO_800_04 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_DO_800_05 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_P4901 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_P4902 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_P4903 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_R4005A = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_R4005B = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_MO_300_01 = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_QL_PORTARIA = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_QL_ADM = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_QL_LODO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_QLSL = new System.HMI.Symbols.Base.Execute<bool>();
			this.xH_QL_ILUMINACAO = new System.HMI.Symbols.Base.Execute<bool>();
			this.xPlanta = new System.HMI.Symbols.Base.Execute<bool>();
			// 
			// cabecalho
			// 
			this.cabecalho.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1000D)), ((float)(64D)));
			this.cabecalho.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(235)), ((byte)(235)), ((byte)(235))));
			this.cabecalho.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.cabecalho.Name = "cabecalho";
			this.cabecalho.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color("Transparent"), 0F, NxtControl.Drawing.DashStyle.Solid);
			// 
			// titulo
			// 
			this.titulo.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.titulo.Font = new NxtControl.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
			this.titulo.Location = new NxtControl.Drawing.PointF(20D, 10D);
			this.titulo.Name = "titulo";
			this.titulo.Text = "Cargas liberadas para operar nos geradores";
			// 
			// tPlanta
			// 
			this.tPlanta.Color = new NxtControl.Drawing.Color(((byte)(64)), ((byte)(64)), ((byte)(64)));
			this.tPlanta.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.tPlanta.Location = new NxtControl.Drawing.PointF(20D, 36D);
			this.tPlanta.Name = "tPlanta";
			this.tPlanta.Text = "Planta na rede";
			// 
			// g0_0
			// 
			this.g0_0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g0_0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g0_0.Location = new NxtControl.Drawing.PointF(20D, 80D);
			this.g0_0.Name = "g0_0";
			this.g0_0.Text = "Sopradores (Nereda)";
			// 
			// raio_V4601
			// 
			this.raio_V4601.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(108D)), ((float)(12D)), ((float)(22D)));
			this.raio_V4601.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_V4601.Closed = true;
			this.raio_V4601.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_V4601.Name = "raio_V4601";
			this.raio_V4601.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_V4601.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 108D),
			new NxtControl.Drawing.PointF(22D, 119D),
			new NxtControl.Drawing.PointF(27D, 119D),
			new NxtControl.Drawing.PointF(24D, 130D),
			new NxtControl.Drawing.PointF(34D, 115D),
			new NxtControl.Drawing.PointF(29D, 115D),
			new NxtControl.Drawing.PointF(32D, 108D)});
			// 
			// n_V4601
			// 
			this.n_V4601.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_V4601.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_V4601.Location = new NxtControl.Drawing.PointF(42D, 112D);
			this.n_V4601.Name = "n_V4601";
			this.n_V4601.Text = "V4601 - Soprador 01";
			// 
			// c_V4601
			// 
			this.c_V4601.BeginInit();
			this.c_V4601.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 104D);
			this.c_V4601.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4601.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4601.FalseText = "Bloqueado";
			this.c_V4601.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_V4601.FontScale = false;
			this.c_V4601.Name = "c_V4601";
			this.c_V4601.TagName = "HAB_V4601";
			this.c_V4601.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4601.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4601.TrueText = "Liberado";
			this.c_V4601.Value = false;
			this.c_V4601.EndInit();
			// 
			// raio_V4602
			// 
			this.raio_V4602.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(142D)), ((float)(12D)), ((float)(22D)));
			this.raio_V4602.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_V4602.Closed = true;
			this.raio_V4602.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_V4602.Name = "raio_V4602";
			this.raio_V4602.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_V4602.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 142D),
			new NxtControl.Drawing.PointF(22D, 153D),
			new NxtControl.Drawing.PointF(27D, 153D),
			new NxtControl.Drawing.PointF(24D, 164D),
			new NxtControl.Drawing.PointF(34D, 149D),
			new NxtControl.Drawing.PointF(29D, 149D),
			new NxtControl.Drawing.PointF(32D, 142D)});
			// 
			// n_V4602
			// 
			this.n_V4602.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_V4602.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_V4602.Location = new NxtControl.Drawing.PointF(42D, 146D);
			this.n_V4602.Name = "n_V4602";
			this.n_V4602.Text = "V4602 - Soprador 02";
			// 
			// c_V4602
			// 
			this.c_V4602.BeginInit();
			this.c_V4602.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 138D);
			this.c_V4602.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4602.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4602.FalseText = "Bloqueado";
			this.c_V4602.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_V4602.FontScale = false;
			this.c_V4602.Name = "c_V4602";
			this.c_V4602.TagName = "HAB_V4602";
			this.c_V4602.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4602.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4602.TrueText = "Liberado";
			this.c_V4602.Value = false;
			this.c_V4602.EndInit();
			// 
			// raio_V4603
			// 
			this.raio_V4603.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(176D)), ((float)(12D)), ((float)(22D)));
			this.raio_V4603.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_V4603.Closed = true;
			this.raio_V4603.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_V4603.Name = "raio_V4603";
			this.raio_V4603.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_V4603.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 176D),
			new NxtControl.Drawing.PointF(22D, 187D),
			new NxtControl.Drawing.PointF(27D, 187D),
			new NxtControl.Drawing.PointF(24D, 198D),
			new NxtControl.Drawing.PointF(34D, 183D),
			new NxtControl.Drawing.PointF(29D, 183D),
			new NxtControl.Drawing.PointF(32D, 176D)});
			// 
			// n_V4603
			// 
			this.n_V4603.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_V4603.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_V4603.Location = new NxtControl.Drawing.PointF(42D, 180D);
			this.n_V4603.Name = "n_V4603";
			this.n_V4603.Text = "V4603 - Soprador 03";
			// 
			// c_V4603
			// 
			this.c_V4603.BeginInit();
			this.c_V4603.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 172D);
			this.c_V4603.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4603.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4603.FalseText = "Bloqueado";
			this.c_V4603.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_V4603.FontScale = false;
			this.c_V4603.Name = "c_V4603";
			this.c_V4603.TagName = "HAB_V4603";
			this.c_V4603.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4603.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4603.TrueText = "Liberado";
			this.c_V4603.Value = false;
			this.c_V4603.EndInit();
			// 
			// raio_V4604
			// 
			this.raio_V4604.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(210D)), ((float)(12D)), ((float)(22D)));
			this.raio_V4604.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_V4604.Closed = true;
			this.raio_V4604.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_V4604.Name = "raio_V4604";
			this.raio_V4604.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_V4604.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 210D),
			new NxtControl.Drawing.PointF(22D, 221D),
			new NxtControl.Drawing.PointF(27D, 221D),
			new NxtControl.Drawing.PointF(24D, 232D),
			new NxtControl.Drawing.PointF(34D, 217D),
			new NxtControl.Drawing.PointF(29D, 217D),
			new NxtControl.Drawing.PointF(32D, 210D)});
			// 
			// n_V4604
			// 
			this.n_V4604.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_V4604.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_V4604.Location = new NxtControl.Drawing.PointF(42D, 214D);
			this.n_V4604.Name = "n_V4604";
			this.n_V4604.Text = "V4604 - Soprador 04";
			// 
			// c_V4604
			// 
			this.c_V4604.BeginInit();
			this.c_V4604.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 206D);
			this.c_V4604.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4604.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4604.FalseText = "Bloqueado";
			this.c_V4604.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_V4604.FontScale = false;
			this.c_V4604.Name = "c_V4604";
			this.c_V4604.TagName = "HAB_V4604";
			this.c_V4604.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_V4604.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_V4604.TrueText = "Liberado";
			this.c_V4604.Value = false;
			this.c_V4604.EndInit();
			// 
			// g0_1
			// 
			this.g0_1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g0_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g0_1.Location = new NxtControl.Drawing.PointF(20D, 246D);
			this.g0_1.Name = "g0_1";
			this.g0_1.Text = "Exaustores";
			// 
			// raio_EX_500_01
			// 
			this.raio_EX_500_01.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(274D)), ((float)(12D)), ((float)(22D)));
			this.raio_EX_500_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_EX_500_01.Closed = true;
			this.raio_EX_500_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_EX_500_01.Name = "raio_EX_500_01";
			this.raio_EX_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_EX_500_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 274D),
			new NxtControl.Drawing.PointF(22D, 285D),
			new NxtControl.Drawing.PointF(27D, 285D),
			new NxtControl.Drawing.PointF(24D, 296D),
			new NxtControl.Drawing.PointF(34D, 281D),
			new NxtControl.Drawing.PointF(29D, 281D),
			new NxtControl.Drawing.PointF(32D, 274D)});
			// 
			// n_EX_500_01
			// 
			this.n_EX_500_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_EX_500_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_EX_500_01.Location = new NxtControl.Drawing.PointF(42D, 278D);
			this.n_EX_500_01.Name = "n_EX_500_01";
			this.n_EX_500_01.Text = "500-EX-01 - Exaustor 01";
			// 
			// c_EX_500_01
			// 
			this.c_EX_500_01.BeginInit();
			this.c_EX_500_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 270D);
			this.c_EX_500_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_01.FalseText = "Bloqueado";
			this.c_EX_500_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_EX_500_01.FontScale = false;
			this.c_EX_500_01.Name = "c_EX_500_01";
			this.c_EX_500_01.TagName = "HAB_EX_500_01";
			this.c_EX_500_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_01.TrueText = "Liberado";
			this.c_EX_500_01.Value = false;
			this.c_EX_500_01.EndInit();
			// 
			// raio_EX_500_02
			// 
			this.raio_EX_500_02.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(308D)), ((float)(12D)), ((float)(22D)));
			this.raio_EX_500_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_EX_500_02.Closed = true;
			this.raio_EX_500_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_EX_500_02.Name = "raio_EX_500_02";
			this.raio_EX_500_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_EX_500_02.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 308D),
			new NxtControl.Drawing.PointF(22D, 319D),
			new NxtControl.Drawing.PointF(27D, 319D),
			new NxtControl.Drawing.PointF(24D, 330D),
			new NxtControl.Drawing.PointF(34D, 315D),
			new NxtControl.Drawing.PointF(29D, 315D),
			new NxtControl.Drawing.PointF(32D, 308D)});
			// 
			// n_EX_500_02
			// 
			this.n_EX_500_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_EX_500_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_EX_500_02.Location = new NxtControl.Drawing.PointF(42D, 312D);
			this.n_EX_500_02.Name = "n_EX_500_02";
			this.n_EX_500_02.Text = "500-EX-02 - Exaustor 02";
			// 
			// c_EX_500_02
			// 
			this.c_EX_500_02.BeginInit();
			this.c_EX_500_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 304D);
			this.c_EX_500_02.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_02.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_02.FalseText = "Bloqueado";
			this.c_EX_500_02.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_EX_500_02.FontScale = false;
			this.c_EX_500_02.Name = "c_EX_500_02";
			this.c_EX_500_02.TagName = "HAB_EX_500_02";
			this.c_EX_500_02.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_02.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_02.TrueText = "Liberado";
			this.c_EX_500_02.Value = false;
			this.c_EX_500_02.EndInit();
			// 
			// raio_EX_500_03
			// 
			this.raio_EX_500_03.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(342D)), ((float)(12D)), ((float)(22D)));
			this.raio_EX_500_03.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_EX_500_03.Closed = true;
			this.raio_EX_500_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_EX_500_03.Name = "raio_EX_500_03";
			this.raio_EX_500_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_EX_500_03.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 342D),
			new NxtControl.Drawing.PointF(22D, 353D),
			new NxtControl.Drawing.PointF(27D, 353D),
			new NxtControl.Drawing.PointF(24D, 364D),
			new NxtControl.Drawing.PointF(34D, 349D),
			new NxtControl.Drawing.PointF(29D, 349D),
			new NxtControl.Drawing.PointF(32D, 342D)});
			// 
			// n_EX_500_03
			// 
			this.n_EX_500_03.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_EX_500_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_EX_500_03.Location = new NxtControl.Drawing.PointF(42D, 346D);
			this.n_EX_500_03.Name = "n_EX_500_03";
			this.n_EX_500_03.Text = "500-EX-03 - Exaustor 03";
			// 
			// c_EX_500_03
			// 
			this.c_EX_500_03.BeginInit();
			this.c_EX_500_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 338D);
			this.c_EX_500_03.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_03.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_03.FalseText = "Bloqueado";
			this.c_EX_500_03.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_EX_500_03.FontScale = false;
			this.c_EX_500_03.Name = "c_EX_500_03";
			this.c_EX_500_03.TagName = "HAB_EX_500_03";
			this.c_EX_500_03.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_03.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_03.TrueText = "Liberado";
			this.c_EX_500_03.Value = false;
			this.c_EX_500_03.EndInit();
			// 
			// raio_EX_500_04
			// 
			this.raio_EX_500_04.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(376D)), ((float)(12D)), ((float)(22D)));
			this.raio_EX_500_04.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_EX_500_04.Closed = true;
			this.raio_EX_500_04.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_EX_500_04.Name = "raio_EX_500_04";
			this.raio_EX_500_04.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_EX_500_04.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 376D),
			new NxtControl.Drawing.PointF(22D, 387D),
			new NxtControl.Drawing.PointF(27D, 387D),
			new NxtControl.Drawing.PointF(24D, 398D),
			new NxtControl.Drawing.PointF(34D, 383D),
			new NxtControl.Drawing.PointF(29D, 383D),
			new NxtControl.Drawing.PointF(32D, 376D)});
			// 
			// n_EX_500_04
			// 
			this.n_EX_500_04.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_EX_500_04.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_EX_500_04.Location = new NxtControl.Drawing.PointF(42D, 380D);
			this.n_EX_500_04.Name = "n_EX_500_04";
			this.n_EX_500_04.Text = "500-EX-04 - Exaustor 04";
			// 
			// c_EX_500_04
			// 
			this.c_EX_500_04.BeginInit();
			this.c_EX_500_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 372D);
			this.c_EX_500_04.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_04.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_04.FalseText = "Bloqueado";
			this.c_EX_500_04.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_EX_500_04.FontScale = false;
			this.c_EX_500_04.Name = "c_EX_500_04";
			this.c_EX_500_04.TagName = "HAB_EX_500_04";
			this.c_EX_500_04.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_04.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_04.TrueText = "Liberado";
			this.c_EX_500_04.Value = false;
			this.c_EX_500_04.EndInit();
			// 
			// raio_EX_500_05
			// 
			this.raio_EX_500_05.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(410D)), ((float)(12D)), ((float)(22D)));
			this.raio_EX_500_05.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_EX_500_05.Closed = true;
			this.raio_EX_500_05.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_EX_500_05.Name = "raio_EX_500_05";
			this.raio_EX_500_05.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_EX_500_05.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 410D),
			new NxtControl.Drawing.PointF(22D, 421D),
			new NxtControl.Drawing.PointF(27D, 421D),
			new NxtControl.Drawing.PointF(24D, 432D),
			new NxtControl.Drawing.PointF(34D, 417D),
			new NxtControl.Drawing.PointF(29D, 417D),
			new NxtControl.Drawing.PointF(32D, 410D)});
			// 
			// n_EX_500_05
			// 
			this.n_EX_500_05.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_EX_500_05.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_EX_500_05.Location = new NxtControl.Drawing.PointF(42D, 414D);
			this.n_EX_500_05.Name = "n_EX_500_05";
			this.n_EX_500_05.Text = "500-EX-05 - Exaustor 05";
			// 
			// c_EX_500_05
			// 
			this.c_EX_500_05.BeginInit();
			this.c_EX_500_05.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 406D);
			this.c_EX_500_05.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_05.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_05.FalseText = "Bloqueado";
			this.c_EX_500_05.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_EX_500_05.FontScale = false;
			this.c_EX_500_05.Name = "c_EX_500_05";
			this.c_EX_500_05.TagName = "HAB_EX_500_05";
			this.c_EX_500_05.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_05.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_EX_500_05.TrueText = "Liberado";
			this.c_EX_500_05.Value = false;
			this.c_EX_500_05.EndInit();
			// 
			// g0_2
			// 
			this.g0_2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g0_2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g0_2.Location = new NxtControl.Drawing.PointF(20D, 446D);
			this.g0_2.Name = "g0_2";
			this.g0_2.Text = "Compressores";
			// 
			// raio_COMP_500_01
			// 
			this.raio_COMP_500_01.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(474D)), ((float)(12D)), ((float)(22D)));
			this.raio_COMP_500_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_COMP_500_01.Closed = true;
			this.raio_COMP_500_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_COMP_500_01.Name = "raio_COMP_500_01";
			this.raio_COMP_500_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_COMP_500_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 474D),
			new NxtControl.Drawing.PointF(22D, 485D),
			new NxtControl.Drawing.PointF(27D, 485D),
			new NxtControl.Drawing.PointF(24D, 496D),
			new NxtControl.Drawing.PointF(34D, 481D),
			new NxtControl.Drawing.PointF(29D, 481D),
			new NxtControl.Drawing.PointF(32D, 474D)});
			// 
			// n_COMP_500_01
			// 
			this.n_COMP_500_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_COMP_500_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_COMP_500_01.Location = new NxtControl.Drawing.PointF(42D, 478D);
			this.n_COMP_500_01.Name = "n_COMP_500_01";
			this.n_COMP_500_01.Text = "500-COMP-01 - Compressor 01";
			// 
			// c_COMP_500_01
			// 
			this.c_COMP_500_01.BeginInit();
			this.c_COMP_500_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 470D);
			this.c_COMP_500_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_01.FalseText = "Bloqueado";
			this.c_COMP_500_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_COMP_500_01.FontScale = false;
			this.c_COMP_500_01.Name = "c_COMP_500_01";
			this.c_COMP_500_01.TagName = "HAB_COMP_500_01";
			this.c_COMP_500_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_01.TrueText = "Liberado";
			this.c_COMP_500_01.Value = false;
			this.c_COMP_500_01.EndInit();
			// 
			// raio_COMP_500_02
			// 
			this.raio_COMP_500_02.Bounds = new NxtControl.Drawing.RectF(((float)(22D)), ((float)(508D)), ((float)(12D)), ((float)(22D)));
			this.raio_COMP_500_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_COMP_500_02.Closed = true;
			this.raio_COMP_500_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_COMP_500_02.Name = "raio_COMP_500_02";
			this.raio_COMP_500_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_COMP_500_02.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(28D, 508D),
			new NxtControl.Drawing.PointF(22D, 519D),
			new NxtControl.Drawing.PointF(27D, 519D),
			new NxtControl.Drawing.PointF(24D, 530D),
			new NxtControl.Drawing.PointF(34D, 515D),
			new NxtControl.Drawing.PointF(29D, 515D),
			new NxtControl.Drawing.PointF(32D, 508D)});
			// 
			// n_COMP_500_02
			// 
			this.n_COMP_500_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_COMP_500_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_COMP_500_02.Location = new NxtControl.Drawing.PointF(42D, 512D);
			this.n_COMP_500_02.Name = "n_COMP_500_02";
			this.n_COMP_500_02.Text = "500-COMP-02 - Compressor 02";
			// 
			// c_COMP_500_02
			// 
			this.c_COMP_500_02.BeginInit();
			this.c_COMP_500_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 220D, 504D);
			this.c_COMP_500_02.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_02.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_02.FalseText = "Bloqueado";
			this.c_COMP_500_02.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_COMP_500_02.FontScale = false;
			this.c_COMP_500_02.Name = "c_COMP_500_02";
			this.c_COMP_500_02.TagName = "HAB_COMP_500_02";
			this.c_COMP_500_02.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_02.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_COMP_500_02.TrueText = "Liberado";
			this.c_COMP_500_02.Value = false;
			this.c_COMP_500_02.EndInit();
			// 
			// g1_0
			// 
			this.g1_0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g1_0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g1_0.Location = new NxtControl.Drawing.PointF(350D, 80D);
			this.g1_0.Name = "g1_0";
			this.g1_0.Text = "Tratamento preliminar";
			// 
			// raio_UCT_200_01
			// 
			this.raio_UCT_200_01.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(108D)), ((float)(12D)), ((float)(22D)));
			this.raio_UCT_200_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_UCT_200_01.Closed = true;
			this.raio_UCT_200_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_UCT_200_01.Name = "raio_UCT_200_01";
			this.raio_UCT_200_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_UCT_200_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 108D),
			new NxtControl.Drawing.PointF(352D, 119D),
			new NxtControl.Drawing.PointF(357D, 119D),
			new NxtControl.Drawing.PointF(354D, 130D),
			new NxtControl.Drawing.PointF(364D, 115D),
			new NxtControl.Drawing.PointF(359D, 115D),
			new NxtControl.Drawing.PointF(362D, 108D)});
			// 
			// n_UCT_200_01
			// 
			this.n_UCT_200_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_UCT_200_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_UCT_200_01.Location = new NxtControl.Drawing.PointF(372D, 112D);
			this.n_UCT_200_01.Name = "n_UCT_200_01";
			this.n_UCT_200_01.Text = "200-UCT-01 - Unid. compacta 01";
			// 
			// c_UCT_200_01
			// 
			this.c_UCT_200_01.BeginInit();
			this.c_UCT_200_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 104D);
			this.c_UCT_200_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_01.FalseText = "Bloqueado";
			this.c_UCT_200_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_UCT_200_01.FontScale = false;
			this.c_UCT_200_01.Name = "c_UCT_200_01";
			this.c_UCT_200_01.TagName = "HAB_UCT_200_01";
			this.c_UCT_200_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_01.TrueText = "Liberado";
			this.c_UCT_200_01.Value = false;
			this.c_UCT_200_01.EndInit();
			// 
			// raio_UCT_200_02
			// 
			this.raio_UCT_200_02.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(142D)), ((float)(12D)), ((float)(22D)));
			this.raio_UCT_200_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_UCT_200_02.Closed = true;
			this.raio_UCT_200_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_UCT_200_02.Name = "raio_UCT_200_02";
			this.raio_UCT_200_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_UCT_200_02.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 142D),
			new NxtControl.Drawing.PointF(352D, 153D),
			new NxtControl.Drawing.PointF(357D, 153D),
			new NxtControl.Drawing.PointF(354D, 164D),
			new NxtControl.Drawing.PointF(364D, 149D),
			new NxtControl.Drawing.PointF(359D, 149D),
			new NxtControl.Drawing.PointF(362D, 142D)});
			// 
			// n_UCT_200_02
			// 
			this.n_UCT_200_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_UCT_200_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_UCT_200_02.Location = new NxtControl.Drawing.PointF(372D, 146D);
			this.n_UCT_200_02.Name = "n_UCT_200_02";
			this.n_UCT_200_02.Text = "200-UCT-02 - Unid. compacta 02";
			// 
			// c_UCT_200_02
			// 
			this.c_UCT_200_02.BeginInit();
			this.c_UCT_200_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 138D);
			this.c_UCT_200_02.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_02.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_02.FalseText = "Bloqueado";
			this.c_UCT_200_02.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_UCT_200_02.FontScale = false;
			this.c_UCT_200_02.Name = "c_UCT_200_02";
			this.c_UCT_200_02.TagName = "HAB_UCT_200_02";
			this.c_UCT_200_02.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_02.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_02.TrueText = "Liberado";
			this.c_UCT_200_02.Value = false;
			this.c_UCT_200_02.EndInit();
			// 
			// raio_UCT_200_03
			// 
			this.raio_UCT_200_03.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(176D)), ((float)(12D)), ((float)(22D)));
			this.raio_UCT_200_03.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_UCT_200_03.Closed = true;
			this.raio_UCT_200_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_UCT_200_03.Name = "raio_UCT_200_03";
			this.raio_UCT_200_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_UCT_200_03.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 176D),
			new NxtControl.Drawing.PointF(352D, 187D),
			new NxtControl.Drawing.PointF(357D, 187D),
			new NxtControl.Drawing.PointF(354D, 198D),
			new NxtControl.Drawing.PointF(364D, 183D),
			new NxtControl.Drawing.PointF(359D, 183D),
			new NxtControl.Drawing.PointF(362D, 176D)});
			// 
			// n_UCT_200_03
			// 
			this.n_UCT_200_03.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_UCT_200_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_UCT_200_03.Location = new NxtControl.Drawing.PointF(372D, 180D);
			this.n_UCT_200_03.Name = "n_UCT_200_03";
			this.n_UCT_200_03.Text = "200-UCT-03 - Unid. compacta 03";
			// 
			// c_UCT_200_03
			// 
			this.c_UCT_200_03.BeginInit();
			this.c_UCT_200_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 172D);
			this.c_UCT_200_03.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_03.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_03.FalseText = "Bloqueado";
			this.c_UCT_200_03.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_UCT_200_03.FontScale = false;
			this.c_UCT_200_03.Name = "c_UCT_200_03";
			this.c_UCT_200_03.TagName = "HAB_UCT_200_03";
			this.c_UCT_200_03.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_03.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UCT_200_03.TrueText = "Liberado";
			this.c_UCT_200_03.Value = false;
			this.c_UCT_200_03.EndInit();
			// 
			// g1_1
			// 
			this.g1_1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g1_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g1_1.Location = new NxtControl.Drawing.PointF(350D, 212D);
			this.g1_1.Name = "g1_1";
			this.g1_1.Text = "EEE Bruto";
			// 
			// raio_BS_100_01
			// 
			this.raio_BS_100_01.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(240D)), ((float)(12D)), ((float)(22D)));
			this.raio_BS_100_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_BS_100_01.Closed = true;
			this.raio_BS_100_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_BS_100_01.Name = "raio_BS_100_01";
			this.raio_BS_100_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_BS_100_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 240D),
			new NxtControl.Drawing.PointF(352D, 251D),
			new NxtControl.Drawing.PointF(357D, 251D),
			new NxtControl.Drawing.PointF(354D, 262D),
			new NxtControl.Drawing.PointF(364D, 247D),
			new NxtControl.Drawing.PointF(359D, 247D),
			new NxtControl.Drawing.PointF(362D, 240D)});
			// 
			// n_BS_100_01
			// 
			this.n_BS_100_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_BS_100_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_BS_100_01.Location = new NxtControl.Drawing.PointF(372D, 244D);
			this.n_BS_100_01.Name = "n_BS_100_01";
			this.n_BS_100_01.Text = "100-BS-01 - Bomba 01";
			// 
			// c_BS_100_01
			// 
			this.c_BS_100_01.BeginInit();
			this.c_BS_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 236D);
			this.c_BS_100_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_01.FalseText = "Bloqueado";
			this.c_BS_100_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_BS_100_01.FontScale = false;
			this.c_BS_100_01.Name = "c_BS_100_01";
			this.c_BS_100_01.TagName = "HAB_BS_100_01";
			this.c_BS_100_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_01.TrueText = "Liberado";
			this.c_BS_100_01.Value = false;
			this.c_BS_100_01.EndInit();
			// 
			// raio_BS_100_02
			// 
			this.raio_BS_100_02.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(274D)), ((float)(12D)), ((float)(22D)));
			this.raio_BS_100_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_BS_100_02.Closed = true;
			this.raio_BS_100_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_BS_100_02.Name = "raio_BS_100_02";
			this.raio_BS_100_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_BS_100_02.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 274D),
			new NxtControl.Drawing.PointF(352D, 285D),
			new NxtControl.Drawing.PointF(357D, 285D),
			new NxtControl.Drawing.PointF(354D, 296D),
			new NxtControl.Drawing.PointF(364D, 281D),
			new NxtControl.Drawing.PointF(359D, 281D),
			new NxtControl.Drawing.PointF(362D, 274D)});
			// 
			// n_BS_100_02
			// 
			this.n_BS_100_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_BS_100_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_BS_100_02.Location = new NxtControl.Drawing.PointF(372D, 278D);
			this.n_BS_100_02.Name = "n_BS_100_02";
			this.n_BS_100_02.Text = "100-BS-02 - Bomba 02";
			// 
			// c_BS_100_02
			// 
			this.c_BS_100_02.BeginInit();
			this.c_BS_100_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 270D);
			this.c_BS_100_02.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_02.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_02.FalseText = "Bloqueado";
			this.c_BS_100_02.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_BS_100_02.FontScale = false;
			this.c_BS_100_02.Name = "c_BS_100_02";
			this.c_BS_100_02.TagName = "HAB_BS_100_02";
			this.c_BS_100_02.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_02.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_02.TrueText = "Liberado";
			this.c_BS_100_02.Value = false;
			this.c_BS_100_02.EndInit();
			// 
			// raio_BS_100_03
			// 
			this.raio_BS_100_03.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(308D)), ((float)(12D)), ((float)(22D)));
			this.raio_BS_100_03.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_BS_100_03.Closed = true;
			this.raio_BS_100_03.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_BS_100_03.Name = "raio_BS_100_03";
			this.raio_BS_100_03.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_BS_100_03.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 308D),
			new NxtControl.Drawing.PointF(352D, 319D),
			new NxtControl.Drawing.PointF(357D, 319D),
			new NxtControl.Drawing.PointF(354D, 330D),
			new NxtControl.Drawing.PointF(364D, 315D),
			new NxtControl.Drawing.PointF(359D, 315D),
			new NxtControl.Drawing.PointF(362D, 308D)});
			// 
			// n_BS_100_03
			// 
			this.n_BS_100_03.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_BS_100_03.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_BS_100_03.Location = new NxtControl.Drawing.PointF(372D, 312D);
			this.n_BS_100_03.Name = "n_BS_100_03";
			this.n_BS_100_03.Text = "100-BS-03 - Bomba 03";
			// 
			// c_BS_100_03
			// 
			this.c_BS_100_03.BeginInit();
			this.c_BS_100_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 304D);
			this.c_BS_100_03.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_03.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_03.FalseText = "Bloqueado";
			this.c_BS_100_03.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_BS_100_03.FontScale = false;
			this.c_BS_100_03.Name = "c_BS_100_03";
			this.c_BS_100_03.TagName = "HAB_BS_100_03";
			this.c_BS_100_03.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_03.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_BS_100_03.TrueText = "Liberado";
			this.c_BS_100_03.Value = false;
			this.c_BS_100_03.EndInit();
			// 
			// raio_GM_100_01
			// 
			this.raio_GM_100_01.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(342D)), ((float)(12D)), ((float)(22D)));
			this.raio_GM_100_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_GM_100_01.Closed = true;
			this.raio_GM_100_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_GM_100_01.Name = "raio_GM_100_01";
			this.raio_GM_100_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_GM_100_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 342D),
			new NxtControl.Drawing.PointF(352D, 353D),
			new NxtControl.Drawing.PointF(357D, 353D),
			new NxtControl.Drawing.PointF(354D, 364D),
			new NxtControl.Drawing.PointF(364D, 349D),
			new NxtControl.Drawing.PointF(359D, 349D),
			new NxtControl.Drawing.PointF(362D, 342D)});
			// 
			// n_GM_100_01
			// 
			this.n_GM_100_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_GM_100_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_GM_100_01.Location = new NxtControl.Drawing.PointF(372D, 346D);
			this.n_GM_100_01.Name = "n_GM_100_01";
			this.n_GM_100_01.Text = "100-GM-01 - Grade mecanizada";
			// 
			// c_GM_100_01
			// 
			this.c_GM_100_01.BeginInit();
			this.c_GM_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 338D);
			this.c_GM_100_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_GM_100_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_GM_100_01.FalseText = "Bloqueado";
			this.c_GM_100_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_GM_100_01.FontScale = false;
			this.c_GM_100_01.Name = "c_GM_100_01";
			this.c_GM_100_01.TagName = "HAB_GM_100_01";
			this.c_GM_100_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_GM_100_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_GM_100_01.TrueText = "Liberado";
			this.c_GM_100_01.Value = false;
			this.c_GM_100_01.EndInit();
			// 
			// g1_2
			// 
			this.g1_2.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g1_2.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g1_2.Location = new NxtControl.Drawing.PointF(350D, 378D);
			this.g1_2.Name = "g1_2";
			this.g1_2.Text = "Desinfecção";
			// 
			// raio_UV_700_01
			// 
			this.raio_UV_700_01.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(406D)), ((float)(12D)), ((float)(22D)));
			this.raio_UV_700_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_UV_700_01.Closed = true;
			this.raio_UV_700_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_UV_700_01.Name = "raio_UV_700_01";
			this.raio_UV_700_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_UV_700_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 406D),
			new NxtControl.Drawing.PointF(352D, 417D),
			new NxtControl.Drawing.PointF(357D, 417D),
			new NxtControl.Drawing.PointF(354D, 428D),
			new NxtControl.Drawing.PointF(364D, 413D),
			new NxtControl.Drawing.PointF(359D, 413D),
			new NxtControl.Drawing.PointF(362D, 406D)});
			// 
			// n_UV_700_01
			// 
			this.n_UV_700_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_UV_700_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_UV_700_01.Location = new NxtControl.Drawing.PointF(372D, 410D);
			this.n_UV_700_01.Name = "n_UV_700_01";
			this.n_UV_700_01.Text = "700-UV-01 - Sistema UV 01";
			// 
			// c_UV_700_01
			// 
			this.c_UV_700_01.BeginInit();
			this.c_UV_700_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 402D);
			this.c_UV_700_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_01.FalseText = "Bloqueado";
			this.c_UV_700_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_UV_700_01.FontScale = false;
			this.c_UV_700_01.Name = "c_UV_700_01";
			this.c_UV_700_01.TagName = "HAB_UV_700_01";
			this.c_UV_700_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_01.TrueText = "Liberado";
			this.c_UV_700_01.Value = false;
			this.c_UV_700_01.EndInit();
			// 
			// raio_UV_700_02
			// 
			this.raio_UV_700_02.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(440D)), ((float)(12D)), ((float)(22D)));
			this.raio_UV_700_02.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_UV_700_02.Closed = true;
			this.raio_UV_700_02.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_UV_700_02.Name = "raio_UV_700_02";
			this.raio_UV_700_02.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_UV_700_02.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 440D),
			new NxtControl.Drawing.PointF(352D, 451D),
			new NxtControl.Drawing.PointF(357D, 451D),
			new NxtControl.Drawing.PointF(354D, 462D),
			new NxtControl.Drawing.PointF(364D, 447D),
			new NxtControl.Drawing.PointF(359D, 447D),
			new NxtControl.Drawing.PointF(362D, 440D)});
			// 
			// n_UV_700_02
			// 
			this.n_UV_700_02.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_UV_700_02.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_UV_700_02.Location = new NxtControl.Drawing.PointF(372D, 444D);
			this.n_UV_700_02.Name = "n_UV_700_02";
			this.n_UV_700_02.Text = "700-UV-02 - Sistema UV 02";
			// 
			// c_UV_700_02
			// 
			this.c_UV_700_02.BeginInit();
			this.c_UV_700_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 436D);
			this.c_UV_700_02.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_02.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_02.FalseText = "Bloqueado";
			this.c_UV_700_02.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_UV_700_02.FontScale = false;
			this.c_UV_700_02.Name = "c_UV_700_02";
			this.c_UV_700_02.TagName = "HAB_UV_700_02";
			this.c_UV_700_02.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_02.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_UV_700_02.TrueText = "Liberado";
			this.c_UV_700_02.Value = false;
			this.c_UV_700_02.EndInit();
			// 
			// g1_3
			// 
			this.g1_3.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g1_3.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g1_3.Location = new NxtControl.Drawing.PointF(350D, 476D);
			this.g1_3.Name = "g1_3";
			this.g1_3.Text = "Água de reúso";
			// 
			// raio_DO_800_04
			// 
			this.raio_DO_800_04.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(504D)), ((float)(12D)), ((float)(22D)));
			this.raio_DO_800_04.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_DO_800_04.Closed = true;
			this.raio_DO_800_04.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_DO_800_04.Name = "raio_DO_800_04";
			this.raio_DO_800_04.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_DO_800_04.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 504D),
			new NxtControl.Drawing.PointF(352D, 515D),
			new NxtControl.Drawing.PointF(357D, 515D),
			new NxtControl.Drawing.PointF(354D, 526D),
			new NxtControl.Drawing.PointF(364D, 511D),
			new NxtControl.Drawing.PointF(359D, 511D),
			new NxtControl.Drawing.PointF(362D, 504D)});
			// 
			// n_DO_800_04
			// 
			this.n_DO_800_04.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_DO_800_04.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_DO_800_04.Location = new NxtControl.Drawing.PointF(372D, 508D);
			this.n_DO_800_04.Name = "n_DO_800_04";
			this.n_DO_800_04.Text = "800-DO-04 - Bomba dosadora 04";
			// 
			// c_DO_800_04
			// 
			this.c_DO_800_04.BeginInit();
			this.c_DO_800_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 500D);
			this.c_DO_800_04.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_04.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_04.FalseText = "Bloqueado";
			this.c_DO_800_04.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_DO_800_04.FontScale = false;
			this.c_DO_800_04.Name = "c_DO_800_04";
			this.c_DO_800_04.TagName = "HAB_DO_800_04";
			this.c_DO_800_04.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_04.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_04.TrueText = "Liberado";
			this.c_DO_800_04.Value = false;
			this.c_DO_800_04.EndInit();
			// 
			// raio_DO_800_05
			// 
			this.raio_DO_800_05.Bounds = new NxtControl.Drawing.RectF(((float)(352D)), ((float)(538D)), ((float)(12D)), ((float)(22D)));
			this.raio_DO_800_05.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_DO_800_05.Closed = true;
			this.raio_DO_800_05.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_DO_800_05.Name = "raio_DO_800_05";
			this.raio_DO_800_05.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_DO_800_05.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(358D, 538D),
			new NxtControl.Drawing.PointF(352D, 549D),
			new NxtControl.Drawing.PointF(357D, 549D),
			new NxtControl.Drawing.PointF(354D, 560D),
			new NxtControl.Drawing.PointF(364D, 545D),
			new NxtControl.Drawing.PointF(359D, 545D),
			new NxtControl.Drawing.PointF(362D, 538D)});
			// 
			// n_DO_800_05
			// 
			this.n_DO_800_05.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_DO_800_05.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_DO_800_05.Location = new NxtControl.Drawing.PointF(372D, 542D);
			this.n_DO_800_05.Name = "n_DO_800_05";
			this.n_DO_800_05.Text = "800-DO-05 - Bomba dosadora 05";
			// 
			// c_DO_800_05
			// 
			this.c_DO_800_05.BeginInit();
			this.c_DO_800_05.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 550D, 534D);
			this.c_DO_800_05.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_05.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_05.FalseText = "Bloqueado";
			this.c_DO_800_05.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_DO_800_05.FontScale = false;
			this.c_DO_800_05.Name = "c_DO_800_05";
			this.c_DO_800_05.TagName = "HAB_DO_800_05";
			this.c_DO_800_05.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_05.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_DO_800_05.TrueText = "Liberado";
			this.c_DO_800_05.Value = false;
			this.c_DO_800_05.EndInit();
			// 
			// g2_0
			// 
			this.g2_0.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g2_0.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g2_0.Location = new NxtControl.Drawing.PointF(680D, 80D);
			this.g2_0.Name = "g2_0";
			this.g2_0.Text = "Nereda";
			// 
			// raio_P4901
			// 
			this.raio_P4901.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(108D)), ((float)(12D)), ((float)(22D)));
			this.raio_P4901.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_P4901.Closed = true;
			this.raio_P4901.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_P4901.Name = "raio_P4901";
			this.raio_P4901.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_P4901.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 108D),
			new NxtControl.Drawing.PointF(682D, 119D),
			new NxtControl.Drawing.PointF(687D, 119D),
			new NxtControl.Drawing.PointF(684D, 130D),
			new NxtControl.Drawing.PointF(694D, 115D),
			new NxtControl.Drawing.PointF(689D, 115D),
			new NxtControl.Drawing.PointF(692D, 108D)});
			// 
			// n_P4901
			// 
			this.n_P4901.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_P4901.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_P4901.Location = new NxtControl.Drawing.PointF(702D, 112D);
			this.n_P4901.Name = "n_P4901";
			this.n_P4901.Text = "P4901 - Bomba submersível 01";
			// 
			// c_P4901
			// 
			this.c_P4901.BeginInit();
			this.c_P4901.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 104D);
			this.c_P4901.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_P4901.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_P4901.FalseText = "Bloqueado";
			this.c_P4901.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_P4901.FontScale = false;
			this.c_P4901.Name = "c_P4901";
			this.c_P4901.TagName = "HAB_P4901";
			this.c_P4901.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_P4901.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_P4901.TrueText = "Liberado";
			this.c_P4901.Value = false;
			this.c_P4901.EndInit();
			// 
			// raio_P4902
			// 
			this.raio_P4902.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(142D)), ((float)(12D)), ((float)(22D)));
			this.raio_P4902.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_P4902.Closed = true;
			this.raio_P4902.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_P4902.Name = "raio_P4902";
			this.raio_P4902.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_P4902.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 142D),
			new NxtControl.Drawing.PointF(682D, 153D),
			new NxtControl.Drawing.PointF(687D, 153D),
			new NxtControl.Drawing.PointF(684D, 164D),
			new NxtControl.Drawing.PointF(694D, 149D),
			new NxtControl.Drawing.PointF(689D, 149D),
			new NxtControl.Drawing.PointF(692D, 142D)});
			// 
			// n_P4902
			// 
			this.n_P4902.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_P4902.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_P4902.Location = new NxtControl.Drawing.PointF(702D, 146D);
			this.n_P4902.Name = "n_P4902";
			this.n_P4902.Text = "P4902 - Bomba submersível 02";
			// 
			// c_P4902
			// 
			this.c_P4902.BeginInit();
			this.c_P4902.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 138D);
			this.c_P4902.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_P4902.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_P4902.FalseText = "Bloqueado";
			this.c_P4902.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_P4902.FontScale = false;
			this.c_P4902.Name = "c_P4902";
			this.c_P4902.TagName = "HAB_P4902";
			this.c_P4902.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_P4902.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_P4902.TrueText = "Liberado";
			this.c_P4902.Value = false;
			this.c_P4902.EndInit();
			// 
			// raio_P4903
			// 
			this.raio_P4903.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(176D)), ((float)(12D)), ((float)(22D)));
			this.raio_P4903.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_P4903.Closed = true;
			this.raio_P4903.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_P4903.Name = "raio_P4903";
			this.raio_P4903.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_P4903.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 176D),
			new NxtControl.Drawing.PointF(682D, 187D),
			new NxtControl.Drawing.PointF(687D, 187D),
			new NxtControl.Drawing.PointF(684D, 198D),
			new NxtControl.Drawing.PointF(694D, 183D),
			new NxtControl.Drawing.PointF(689D, 183D),
			new NxtControl.Drawing.PointF(692D, 176D)});
			// 
			// n_P4903
			// 
			this.n_P4903.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_P4903.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_P4903.Location = new NxtControl.Drawing.PointF(702D, 180D);
			this.n_P4903.Name = "n_P4903";
			this.n_P4903.Text = "P4903 - Bomba submersível 03";
			// 
			// c_P4903
			// 
			this.c_P4903.BeginInit();
			this.c_P4903.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 172D);
			this.c_P4903.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_P4903.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_P4903.FalseText = "Bloqueado";
			this.c_P4903.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_P4903.FontScale = false;
			this.c_P4903.Name = "c_P4903";
			this.c_P4903.TagName = "HAB_P4903";
			this.c_P4903.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_P4903.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_P4903.TrueText = "Liberado";
			this.c_P4903.Value = false;
			this.c_P4903.EndInit();
			// 
			// raio_R4005A
			// 
			this.raio_R4005A.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(210D)), ((float)(12D)), ((float)(22D)));
			this.raio_R4005A.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_R4005A.Closed = true;
			this.raio_R4005A.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_R4005A.Name = "raio_R4005A";
			this.raio_R4005A.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_R4005A.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 210D),
			new NxtControl.Drawing.PointF(682D, 221D),
			new NxtControl.Drawing.PointF(687D, 221D),
			new NxtControl.Drawing.PointF(684D, 232D),
			new NxtControl.Drawing.PointF(694D, 217D),
			new NxtControl.Drawing.PointF(689D, 217D),
			new NxtControl.Drawing.PointF(692D, 210D)});
			// 
			// n_R4005A
			// 
			this.n_R4005A.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_R4005A.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_R4005A.Location = new NxtControl.Drawing.PointF(702D, 214D);
			this.n_R4005A.Name = "n_R4005A";
			this.n_R4005A.Text = "R4005A - Bomba horizontal A";
			// 
			// c_R4005A
			// 
			this.c_R4005A.BeginInit();
			this.c_R4005A.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 206D);
			this.c_R4005A.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_R4005A.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_R4005A.FalseText = "Bloqueado";
			this.c_R4005A.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_R4005A.FontScale = false;
			this.c_R4005A.Name = "c_R4005A";
			this.c_R4005A.TagName = "HAB_R4005A";
			this.c_R4005A.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_R4005A.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_R4005A.TrueText = "Liberado";
			this.c_R4005A.Value = false;
			this.c_R4005A.EndInit();
			// 
			// raio_R4005B
			// 
			this.raio_R4005B.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(244D)), ((float)(12D)), ((float)(22D)));
			this.raio_R4005B.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_R4005B.Closed = true;
			this.raio_R4005B.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_R4005B.Name = "raio_R4005B";
			this.raio_R4005B.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_R4005B.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 244D),
			new NxtControl.Drawing.PointF(682D, 255D),
			new NxtControl.Drawing.PointF(687D, 255D),
			new NxtControl.Drawing.PointF(684D, 266D),
			new NxtControl.Drawing.PointF(694D, 251D),
			new NxtControl.Drawing.PointF(689D, 251D),
			new NxtControl.Drawing.PointF(692D, 244D)});
			// 
			// n_R4005B
			// 
			this.n_R4005B.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_R4005B.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_R4005B.Location = new NxtControl.Drawing.PointF(702D, 248D);
			this.n_R4005B.Name = "n_R4005B";
			this.n_R4005B.Text = "R4005B - Bomba horizontal B";
			// 
			// c_R4005B
			// 
			this.c_R4005B.BeginInit();
			this.c_R4005B.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 240D);
			this.c_R4005B.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_R4005B.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_R4005B.FalseText = "Bloqueado";
			this.c_R4005B.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_R4005B.FontScale = false;
			this.c_R4005B.Name = "c_R4005B";
			this.c_R4005B.TagName = "HAB_R4005B";
			this.c_R4005B.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_R4005B.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_R4005B.TrueText = "Liberado";
			this.c_R4005B.Value = false;
			this.c_R4005B.EndInit();
			// 
			// raio_MO_300_01
			// 
			this.raio_MO_300_01.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(278D)), ((float)(12D)), ((float)(22D)));
			this.raio_MO_300_01.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_MO_300_01.Closed = true;
			this.raio_MO_300_01.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_MO_300_01.Name = "raio_MO_300_01";
			this.raio_MO_300_01.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_MO_300_01.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 278D),
			new NxtControl.Drawing.PointF(682D, 289D),
			new NxtControl.Drawing.PointF(687D, 289D),
			new NxtControl.Drawing.PointF(684D, 300D),
			new NxtControl.Drawing.PointF(694D, 285D),
			new NxtControl.Drawing.PointF(689D, 285D),
			new NxtControl.Drawing.PointF(692D, 278D)});
			// 
			// n_MO_300_01
			// 
			this.n_MO_300_01.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_MO_300_01.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_MO_300_01.Location = new NxtControl.Drawing.PointF(702D, 282D);
			this.n_MO_300_01.Name = "n_MO_300_01";
			this.n_MO_300_01.Text = "300-MO-01 - Misturador 01";
			// 
			// c_MO_300_01
			// 
			this.c_MO_300_01.BeginInit();
			this.c_MO_300_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 274D);
			this.c_MO_300_01.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_MO_300_01.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_MO_300_01.FalseText = "Bloqueado";
			this.c_MO_300_01.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_MO_300_01.FontScale = false;
			this.c_MO_300_01.Name = "c_MO_300_01";
			this.c_MO_300_01.TagName = "HAB_MO_300_01";
			this.c_MO_300_01.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_MO_300_01.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_MO_300_01.TrueText = "Liberado";
			this.c_MO_300_01.Value = false;
			this.c_MO_300_01.EndInit();
			// 
			// g2_1
			// 
			this.g2_1.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.g2_1.Font = new NxtControl.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
			this.g2_1.Location = new NxtControl.Drawing.PointF(680D, 314D);
			this.g2_1.Name = "g2_1";
			this.g2_1.Text = "QGBT 220 V";
			// 
			// raio_QL_PORTARIA
			// 
			this.raio_QL_PORTARIA.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(342D)), ((float)(12D)), ((float)(22D)));
			this.raio_QL_PORTARIA.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_QL_PORTARIA.Closed = true;
			this.raio_QL_PORTARIA.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_QL_PORTARIA.Name = "raio_QL_PORTARIA";
			this.raio_QL_PORTARIA.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_QL_PORTARIA.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 342D),
			new NxtControl.Drawing.PointF(682D, 353D),
			new NxtControl.Drawing.PointF(687D, 353D),
			new NxtControl.Drawing.PointF(684D, 364D),
			new NxtControl.Drawing.PointF(694D, 349D),
			new NxtControl.Drawing.PointF(689D, 349D),
			new NxtControl.Drawing.PointF(692D, 342D)});
			// 
			// n_QL_PORTARIA
			// 
			this.n_QL_PORTARIA.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_QL_PORTARIA.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_QL_PORTARIA.Location = new NxtControl.Drawing.PointF(702D, 346D);
			this.n_QL_PORTARIA.Name = "n_QL_PORTARIA";
			this.n_QL_PORTARIA.Text = "QL Portaria";
			// 
			// c_QL_PORTARIA
			// 
			this.c_QL_PORTARIA.BeginInit();
			this.c_QL_PORTARIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 338D);
			this.c_QL_PORTARIA.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_PORTARIA.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_PORTARIA.FalseText = "Bloqueado";
			this.c_QL_PORTARIA.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_QL_PORTARIA.FontScale = false;
			this.c_QL_PORTARIA.Name = "c_QL_PORTARIA";
			this.c_QL_PORTARIA.TagName = "HAB_QL_PORTARIA";
			this.c_QL_PORTARIA.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_PORTARIA.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_PORTARIA.TrueText = "Liberado";
			this.c_QL_PORTARIA.Value = false;
			this.c_QL_PORTARIA.EndInit();
			// 
			// raio_QL_ADM
			// 
			this.raio_QL_ADM.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(376D)), ((float)(12D)), ((float)(22D)));
			this.raio_QL_ADM.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_QL_ADM.Closed = true;
			this.raio_QL_ADM.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_QL_ADM.Name = "raio_QL_ADM";
			this.raio_QL_ADM.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_QL_ADM.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 376D),
			new NxtControl.Drawing.PointF(682D, 387D),
			new NxtControl.Drawing.PointF(687D, 387D),
			new NxtControl.Drawing.PointF(684D, 398D),
			new NxtControl.Drawing.PointF(694D, 383D),
			new NxtControl.Drawing.PointF(689D, 383D),
			new NxtControl.Drawing.PointF(692D, 376D)});
			// 
			// n_QL_ADM
			// 
			this.n_QL_ADM.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_QL_ADM.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_QL_ADM.Location = new NxtControl.Drawing.PointF(702D, 380D);
			this.n_QL_ADM.Name = "n_QL_ADM";
			this.n_QL_ADM.Text = "QL Administração";
			// 
			// c_QL_ADM
			// 
			this.c_QL_ADM.BeginInit();
			this.c_QL_ADM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 372D);
			this.c_QL_ADM.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ADM.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ADM.FalseText = "Bloqueado";
			this.c_QL_ADM.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_QL_ADM.FontScale = false;
			this.c_QL_ADM.Name = "c_QL_ADM";
			this.c_QL_ADM.TagName = "HAB_QL_ADM";
			this.c_QL_ADM.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ADM.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ADM.TrueText = "Liberado";
			this.c_QL_ADM.Value = false;
			this.c_QL_ADM.EndInit();
			// 
			// raio_QL_LODO
			// 
			this.raio_QL_LODO.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(410D)), ((float)(12D)), ((float)(22D)));
			this.raio_QL_LODO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_QL_LODO.Closed = true;
			this.raio_QL_LODO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_QL_LODO.Name = "raio_QL_LODO";
			this.raio_QL_LODO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_QL_LODO.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 410D),
			new NxtControl.Drawing.PointF(682D, 421D),
			new NxtControl.Drawing.PointF(687D, 421D),
			new NxtControl.Drawing.PointF(684D, 432D),
			new NxtControl.Drawing.PointF(694D, 417D),
			new NxtControl.Drawing.PointF(689D, 417D),
			new NxtControl.Drawing.PointF(692D, 410D)});
			// 
			// n_QL_LODO
			// 
			this.n_QL_LODO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_QL_LODO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_QL_LODO.Location = new NxtControl.Drawing.PointF(702D, 414D);
			this.n_QL_LODO.Name = "n_QL_LODO";
			this.n_QL_LODO.Text = "QL Lodo";
			// 
			// c_QL_LODO
			// 
			this.c_QL_LODO.BeginInit();
			this.c_QL_LODO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 406D);
			this.c_QL_LODO.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_LODO.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_LODO.FalseText = "Bloqueado";
			this.c_QL_LODO.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_QL_LODO.FontScale = false;
			this.c_QL_LODO.Name = "c_QL_LODO";
			this.c_QL_LODO.TagName = "HAB_QL_LODO";
			this.c_QL_LODO.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_LODO.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_LODO.TrueText = "Liberado";
			this.c_QL_LODO.Value = false;
			this.c_QL_LODO.EndInit();
			// 
			// raio_QLSL
			// 
			this.raio_QLSL.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(444D)), ((float)(12D)), ((float)(22D)));
			this.raio_QLSL.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_QLSL.Closed = true;
			this.raio_QLSL.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_QLSL.Name = "raio_QLSL";
			this.raio_QLSL.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_QLSL.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 444D),
			new NxtControl.Drawing.PointF(682D, 455D),
			new NxtControl.Drawing.PointF(687D, 455D),
			new NxtControl.Drawing.PointF(684D, 466D),
			new NxtControl.Drawing.PointF(694D, 451D),
			new NxtControl.Drawing.PointF(689D, 451D),
			new NxtControl.Drawing.PointF(692D, 444D)});
			// 
			// n_QLSL
			// 
			this.n_QLSL.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_QLSL.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_QLSL.Location = new NxtControl.Drawing.PointF(702D, 448D);
			this.n_QLSL.Name = "n_QLSL";
			this.n_QLSL.Text = "QL Sala de quadros";
			// 
			// c_QLSL
			// 
			this.c_QLSL.BeginInit();
			this.c_QLSL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 440D);
			this.c_QLSL.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_QLSL.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QLSL.FalseText = "Bloqueado";
			this.c_QLSL.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_QLSL.FontScale = false;
			this.c_QLSL.Name = "c_QLSL";
			this.c_QLSL.TagName = "HAB_QLSL";
			this.c_QLSL.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_QLSL.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QLSL.TrueText = "Liberado";
			this.c_QLSL.Value = false;
			this.c_QLSL.EndInit();
			// 
			// raio_QL_ILUMINACAO
			// 
			this.raio_QL_ILUMINACAO.Bounds = new NxtControl.Drawing.RectF(((float)(682D)), ((float)(478D)), ((float)(12D)), ((float)(22D)));
			this.raio_QL_ILUMINACAO.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(250)), ((byte)(250)), ((byte)(250))));
			this.raio_QL_ILUMINACAO.Closed = true;
			this.raio_QL_ILUMINACAO.Font = new NxtControl.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular);
			this.raio_QL_ILUMINACAO.Name = "raio_QL_ILUMINACAO";
			this.raio_QL_ILUMINACAO.Pen = new NxtControl.Drawing.Pen(new NxtControl.Drawing.Color(((byte)(90)), ((byte)(90)), ((byte)(90))), 1F, NxtControl.Drawing.DashStyle.Solid);
			this.raio_QL_ILUMINACAO.Points.AddRange(new NxtControl.Drawing.PointF[] {
			new NxtControl.Drawing.PointF(688D, 478D),
			new NxtControl.Drawing.PointF(682D, 489D),
			new NxtControl.Drawing.PointF(687D, 489D),
			new NxtControl.Drawing.PointF(684D, 500D),
			new NxtControl.Drawing.PointF(694D, 485D),
			new NxtControl.Drawing.PointF(689D, 485D),
			new NxtControl.Drawing.PointF(692D, 478D)});
			// 
			// n_QL_ILUMINACAO
			// 
			this.n_QL_ILUMINACAO.Color = new NxtControl.Drawing.Color(((byte)(0)), ((byte)(0)), ((byte)(0)));
			this.n_QL_ILUMINACAO.Font = new NxtControl.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular);
			this.n_QL_ILUMINACAO.Location = new NxtControl.Drawing.PointF(702D, 482D);
			this.n_QL_ILUMINACAO.Name = "n_QL_ILUMINACAO";
			this.n_QL_ILUMINACAO.Text = "QL Iluminação externa";
			// 
			// c_QL_ILUMINACAO
			// 
			this.c_QL_ILUMINACAO.BeginInit();
			this.c_QL_ILUMINACAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, 880D, 474D);
			this.c_QL_ILUMINACAO.FalseImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ILUMINACAO.FalseImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ILUMINACAO.FalseText = "Bloqueado";
			this.c_QL_ILUMINACAO.Font = new NxtControl.Drawing.Font("ButtonFont");
			this.c_QL_ILUMINACAO.FontScale = false;
			this.c_QL_ILUMINACAO.Name = "c_QL_ILUMINACAO";
			this.c_QL_ILUMINACAO.TagName = "HAB_QL_ILUMINACAO";
			this.c_QL_ILUMINACAO.TrueImage = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ILUMINACAO.TrueImageDisabled = new NxtControl.Drawing.ImageHolder();
			this.c_QL_ILUMINACAO.TrueText = "Liberado";
			this.c_QL_ILUMINACAO.Value = false;
			this.c_QL_ILUMINACAO.EndInit();
			// 
			// xH_V4601
			// 
			this.xH_V4601.BeginInit();
			this.xH_V4601.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_V4601.IsOnlyInput = true;
			this.xH_V4601.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_V4601.Name = "xH_V4601";
			this.xH_V4601.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_V4601.TagName = "HAB_V4601";
			this.xH_V4601.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_V4601.EndInit();
			// 
			// xH_V4602
			// 
			this.xH_V4602.BeginInit();
			this.xH_V4602.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_V4602.IsOnlyInput = true;
			this.xH_V4602.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_V4602.Name = "xH_V4602";
			this.xH_V4602.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_V4602.TagName = "HAB_V4602";
			this.xH_V4602.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_V4602.EndInit();
			// 
			// xH_V4603
			// 
			this.xH_V4603.BeginInit();
			this.xH_V4603.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_V4603.IsOnlyInput = true;
			this.xH_V4603.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_V4603.Name = "xH_V4603";
			this.xH_V4603.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_V4603.TagName = "HAB_V4603";
			this.xH_V4603.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_V4603.EndInit();
			// 
			// xH_V4604
			// 
			this.xH_V4604.BeginInit();
			this.xH_V4604.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_V4604.IsOnlyInput = true;
			this.xH_V4604.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_V4604.Name = "xH_V4604";
			this.xH_V4604.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_V4604.TagName = "HAB_V4604";
			this.xH_V4604.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_V4604.EndInit();
			// 
			// xH_EX_500_01
			// 
			this.xH_EX_500_01.BeginInit();
			this.xH_EX_500_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_EX_500_01.IsOnlyInput = true;
			this.xH_EX_500_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_EX_500_01.Name = "xH_EX_500_01";
			this.xH_EX_500_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_EX_500_01.TagName = "HAB_EX_500_01";
			this.xH_EX_500_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_EX_500_01.EndInit();
			// 
			// xH_EX_500_02
			// 
			this.xH_EX_500_02.BeginInit();
			this.xH_EX_500_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_EX_500_02.IsOnlyInput = true;
			this.xH_EX_500_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_EX_500_02.Name = "xH_EX_500_02";
			this.xH_EX_500_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_EX_500_02.TagName = "HAB_EX_500_02";
			this.xH_EX_500_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_EX_500_02.EndInit();
			// 
			// xH_EX_500_03
			// 
			this.xH_EX_500_03.BeginInit();
			this.xH_EX_500_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_EX_500_03.IsOnlyInput = true;
			this.xH_EX_500_03.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_EX_500_03.Name = "xH_EX_500_03";
			this.xH_EX_500_03.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_EX_500_03.TagName = "HAB_EX_500_03";
			this.xH_EX_500_03.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_EX_500_03.EndInit();
			// 
			// xH_EX_500_04
			// 
			this.xH_EX_500_04.BeginInit();
			this.xH_EX_500_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_EX_500_04.IsOnlyInput = true;
			this.xH_EX_500_04.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_EX_500_04.Name = "xH_EX_500_04";
			this.xH_EX_500_04.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_EX_500_04.TagName = "HAB_EX_500_04";
			this.xH_EX_500_04.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_EX_500_04.EndInit();
			// 
			// xH_EX_500_05
			// 
			this.xH_EX_500_05.BeginInit();
			this.xH_EX_500_05.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_EX_500_05.IsOnlyInput = true;
			this.xH_EX_500_05.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_EX_500_05.Name = "xH_EX_500_05";
			this.xH_EX_500_05.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_EX_500_05.TagName = "HAB_EX_500_05";
			this.xH_EX_500_05.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_EX_500_05.EndInit();
			// 
			// xH_COMP_500_01
			// 
			this.xH_COMP_500_01.BeginInit();
			this.xH_COMP_500_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_COMP_500_01.IsOnlyInput = true;
			this.xH_COMP_500_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_COMP_500_01.Name = "xH_COMP_500_01";
			this.xH_COMP_500_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_COMP_500_01.TagName = "HAB_COMP_500_01";
			this.xH_COMP_500_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_COMP_500_01.EndInit();
			// 
			// xH_COMP_500_02
			// 
			this.xH_COMP_500_02.BeginInit();
			this.xH_COMP_500_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_COMP_500_02.IsOnlyInput = true;
			this.xH_COMP_500_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_COMP_500_02.Name = "xH_COMP_500_02";
			this.xH_COMP_500_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_COMP_500_02.TagName = "HAB_COMP_500_02";
			this.xH_COMP_500_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_COMP_500_02.EndInit();
			// 
			// xH_UCT_200_01
			// 
			this.xH_UCT_200_01.BeginInit();
			this.xH_UCT_200_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_UCT_200_01.IsOnlyInput = true;
			this.xH_UCT_200_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_UCT_200_01.Name = "xH_UCT_200_01";
			this.xH_UCT_200_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_UCT_200_01.TagName = "HAB_UCT_200_01";
			this.xH_UCT_200_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_UCT_200_01.EndInit();
			// 
			// xH_UCT_200_02
			// 
			this.xH_UCT_200_02.BeginInit();
			this.xH_UCT_200_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_UCT_200_02.IsOnlyInput = true;
			this.xH_UCT_200_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_UCT_200_02.Name = "xH_UCT_200_02";
			this.xH_UCT_200_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_UCT_200_02.TagName = "HAB_UCT_200_02";
			this.xH_UCT_200_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_UCT_200_02.EndInit();
			// 
			// xH_UCT_200_03
			// 
			this.xH_UCT_200_03.BeginInit();
			this.xH_UCT_200_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_UCT_200_03.IsOnlyInput = true;
			this.xH_UCT_200_03.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_UCT_200_03.Name = "xH_UCT_200_03";
			this.xH_UCT_200_03.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_UCT_200_03.TagName = "HAB_UCT_200_03";
			this.xH_UCT_200_03.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_UCT_200_03.EndInit();
			// 
			// xH_BS_100_01
			// 
			this.xH_BS_100_01.BeginInit();
			this.xH_BS_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_BS_100_01.IsOnlyInput = true;
			this.xH_BS_100_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_BS_100_01.Name = "xH_BS_100_01";
			this.xH_BS_100_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_BS_100_01.TagName = "HAB_BS_100_01";
			this.xH_BS_100_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_BS_100_01.EndInit();
			// 
			// xH_BS_100_02
			// 
			this.xH_BS_100_02.BeginInit();
			this.xH_BS_100_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_BS_100_02.IsOnlyInput = true;
			this.xH_BS_100_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_BS_100_02.Name = "xH_BS_100_02";
			this.xH_BS_100_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_BS_100_02.TagName = "HAB_BS_100_02";
			this.xH_BS_100_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_BS_100_02.EndInit();
			// 
			// xH_BS_100_03
			// 
			this.xH_BS_100_03.BeginInit();
			this.xH_BS_100_03.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_BS_100_03.IsOnlyInput = true;
			this.xH_BS_100_03.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_BS_100_03.Name = "xH_BS_100_03";
			this.xH_BS_100_03.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_BS_100_03.TagName = "HAB_BS_100_03";
			this.xH_BS_100_03.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_BS_100_03.EndInit();
			// 
			// xH_GM_100_01
			// 
			this.xH_GM_100_01.BeginInit();
			this.xH_GM_100_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_GM_100_01.IsOnlyInput = true;
			this.xH_GM_100_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_GM_100_01.Name = "xH_GM_100_01";
			this.xH_GM_100_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_GM_100_01.TagName = "HAB_GM_100_01";
			this.xH_GM_100_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_GM_100_01.EndInit();
			// 
			// xH_UV_700_01
			// 
			this.xH_UV_700_01.BeginInit();
			this.xH_UV_700_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_UV_700_01.IsOnlyInput = true;
			this.xH_UV_700_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_UV_700_01.Name = "xH_UV_700_01";
			this.xH_UV_700_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_UV_700_01.TagName = "HAB_UV_700_01";
			this.xH_UV_700_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_UV_700_01.EndInit();
			// 
			// xH_UV_700_02
			// 
			this.xH_UV_700_02.BeginInit();
			this.xH_UV_700_02.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_UV_700_02.IsOnlyInput = true;
			this.xH_UV_700_02.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_UV_700_02.Name = "xH_UV_700_02";
			this.xH_UV_700_02.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_UV_700_02.TagName = "HAB_UV_700_02";
			this.xH_UV_700_02.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_UV_700_02.EndInit();
			// 
			// xH_DO_800_04
			// 
			this.xH_DO_800_04.BeginInit();
			this.xH_DO_800_04.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_DO_800_04.IsOnlyInput = true;
			this.xH_DO_800_04.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_DO_800_04.Name = "xH_DO_800_04";
			this.xH_DO_800_04.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_DO_800_04.TagName = "HAB_DO_800_04";
			this.xH_DO_800_04.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_DO_800_04.EndInit();
			// 
			// xH_DO_800_05
			// 
			this.xH_DO_800_05.BeginInit();
			this.xH_DO_800_05.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_DO_800_05.IsOnlyInput = true;
			this.xH_DO_800_05.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_DO_800_05.Name = "xH_DO_800_05";
			this.xH_DO_800_05.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_DO_800_05.TagName = "HAB_DO_800_05";
			this.xH_DO_800_05.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_DO_800_05.EndInit();
			// 
			// xH_P4901
			// 
			this.xH_P4901.BeginInit();
			this.xH_P4901.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_P4901.IsOnlyInput = true;
			this.xH_P4901.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_P4901.Name = "xH_P4901";
			this.xH_P4901.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_P4901.TagName = "HAB_P4901";
			this.xH_P4901.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_P4901.EndInit();
			// 
			// xH_P4902
			// 
			this.xH_P4902.BeginInit();
			this.xH_P4902.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_P4902.IsOnlyInput = true;
			this.xH_P4902.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_P4902.Name = "xH_P4902";
			this.xH_P4902.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_P4902.TagName = "HAB_P4902";
			this.xH_P4902.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_P4902.EndInit();
			// 
			// xH_P4903
			// 
			this.xH_P4903.BeginInit();
			this.xH_P4903.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_P4903.IsOnlyInput = true;
			this.xH_P4903.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_P4903.Name = "xH_P4903";
			this.xH_P4903.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_P4903.TagName = "HAB_P4903";
			this.xH_P4903.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_P4903.EndInit();
			// 
			// xH_R4005A
			// 
			this.xH_R4005A.BeginInit();
			this.xH_R4005A.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_R4005A.IsOnlyInput = true;
			this.xH_R4005A.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_R4005A.Name = "xH_R4005A";
			this.xH_R4005A.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_R4005A.TagName = "HAB_R4005A";
			this.xH_R4005A.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_R4005A.EndInit();
			// 
			// xH_R4005B
			// 
			this.xH_R4005B.BeginInit();
			this.xH_R4005B.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_R4005B.IsOnlyInput = true;
			this.xH_R4005B.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_R4005B.Name = "xH_R4005B";
			this.xH_R4005B.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_R4005B.TagName = "HAB_R4005B";
			this.xH_R4005B.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_R4005B.EndInit();
			// 
			// xH_MO_300_01
			// 
			this.xH_MO_300_01.BeginInit();
			this.xH_MO_300_01.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_MO_300_01.IsOnlyInput = true;
			this.xH_MO_300_01.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_MO_300_01.Name = "xH_MO_300_01";
			this.xH_MO_300_01.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_MO_300_01.TagName = "HAB_MO_300_01";
			this.xH_MO_300_01.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_MO_300_01.EndInit();
			// 
			// xH_QL_PORTARIA
			// 
			this.xH_QL_PORTARIA.BeginInit();
			this.xH_QL_PORTARIA.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_QL_PORTARIA.IsOnlyInput = true;
			this.xH_QL_PORTARIA.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_QL_PORTARIA.Name = "xH_QL_PORTARIA";
			this.xH_QL_PORTARIA.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_QL_PORTARIA.TagName = "HAB_QL_PORTARIA";
			this.xH_QL_PORTARIA.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_QL_PORTARIA.EndInit();
			// 
			// xH_QL_ADM
			// 
			this.xH_QL_ADM.BeginInit();
			this.xH_QL_ADM.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_QL_ADM.IsOnlyInput = true;
			this.xH_QL_ADM.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_QL_ADM.Name = "xH_QL_ADM";
			this.xH_QL_ADM.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_QL_ADM.TagName = "HAB_QL_ADM";
			this.xH_QL_ADM.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_QL_ADM.EndInit();
			// 
			// xH_QL_LODO
			// 
			this.xH_QL_LODO.BeginInit();
			this.xH_QL_LODO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_QL_LODO.IsOnlyInput = true;
			this.xH_QL_LODO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_QL_LODO.Name = "xH_QL_LODO";
			this.xH_QL_LODO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_QL_LODO.TagName = "HAB_QL_LODO";
			this.xH_QL_LODO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_QL_LODO.EndInit();
			// 
			// xH_QLSL
			// 
			this.xH_QLSL.BeginInit();
			this.xH_QLSL.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_QLSL.IsOnlyInput = true;
			this.xH_QLSL.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_QLSL.Name = "xH_QLSL";
			this.xH_QLSL.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_QLSL.TagName = "HAB_QLSL";
			this.xH_QLSL.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_QLSL.EndInit();
			// 
			// xH_QL_ILUMINACAO
			// 
			this.xH_QL_ILUMINACAO.BeginInit();
			this.xH_QL_ILUMINACAO.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xH_QL_ILUMINACAO.IsOnlyInput = true;
			this.xH_QL_ILUMINACAO.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xH_QL_ILUMINACAO.Name = "xH_QL_ILUMINACAO";
			this.xH_QL_ILUMINACAO.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xH_QL_ILUMINACAO.TagName = "HAB_QL_ILUMINACAO";
			this.xH_QL_ILUMINACAO.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xH_QL_ILUMINACAO.EndInit();
			// 
			// xPlanta
			// 
			this.xPlanta.BeginInit();
			this.xPlanta.DesignMatrix = new NxtControl.Drawing.Matrix2D(1D, 0D, 0D, 1D, double.NaN, double.NaN);
			this.xPlanta.IsOnlyInput = true;
			this.xPlanta.Location = new NxtControl.Drawing.PointF(double.NaN, double.NaN);
			this.xPlanta.Name = "xPlanta";
			this.xPlanta.Size = new NxtControl.Drawing.SizeF(double.NegativeInfinity, double.NegativeInfinity);
			this.xPlanta.TagName = "PLANTA_NO_GERADOR";
			this.xPlanta.ValueChanged += new System.EventHandler<NxtControl.GuiFramework.ValueChangedEventArgs>(this.Muda);
			this.xPlanta.EndInit();
			// 
			// fpCargas
			// 
			this.Bounds = new NxtControl.Drawing.RectF(((float)(0D)), ((float)(0D)), ((float)(1000D)), ((float)(590D)));
			this.Brush = new NxtControl.Drawing.Brush(new NxtControl.Drawing.Color(((byte)(224)), ((byte)(224)), ((byte)(224))));
			this.Name = "fpCargas";
			this.Shapes.AddRange(new System.ComponentModel.IComponent[] {
			this.cabecalho,
			this.titulo,
			this.tPlanta,
			this.g0_0,
			this.raio_V4601,
			this.n_V4601,
			this.c_V4601,
			this.raio_V4602,
			this.n_V4602,
			this.c_V4602,
			this.raio_V4603,
			this.n_V4603,
			this.c_V4603,
			this.raio_V4604,
			this.n_V4604,
			this.c_V4604,
			this.g0_1,
			this.raio_EX_500_01,
			this.n_EX_500_01,
			this.c_EX_500_01,
			this.raio_EX_500_02,
			this.n_EX_500_02,
			this.c_EX_500_02,
			this.raio_EX_500_03,
			this.n_EX_500_03,
			this.c_EX_500_03,
			this.raio_EX_500_04,
			this.n_EX_500_04,
			this.c_EX_500_04,
			this.raio_EX_500_05,
			this.n_EX_500_05,
			this.c_EX_500_05,
			this.g0_2,
			this.raio_COMP_500_01,
			this.n_COMP_500_01,
			this.c_COMP_500_01,
			this.raio_COMP_500_02,
			this.n_COMP_500_02,
			this.c_COMP_500_02,
			this.g1_0,
			this.raio_UCT_200_01,
			this.n_UCT_200_01,
			this.c_UCT_200_01,
			this.raio_UCT_200_02,
			this.n_UCT_200_02,
			this.c_UCT_200_02,
			this.raio_UCT_200_03,
			this.n_UCT_200_03,
			this.c_UCT_200_03,
			this.g1_1,
			this.raio_BS_100_01,
			this.n_BS_100_01,
			this.c_BS_100_01,
			this.raio_BS_100_02,
			this.n_BS_100_02,
			this.c_BS_100_02,
			this.raio_BS_100_03,
			this.n_BS_100_03,
			this.c_BS_100_03,
			this.raio_GM_100_01,
			this.n_GM_100_01,
			this.c_GM_100_01,
			this.g1_2,
			this.raio_UV_700_01,
			this.n_UV_700_01,
			this.c_UV_700_01,
			this.raio_UV_700_02,
			this.n_UV_700_02,
			this.c_UV_700_02,
			this.g1_3,
			this.raio_DO_800_04,
			this.n_DO_800_04,
			this.c_DO_800_04,
			this.raio_DO_800_05,
			this.n_DO_800_05,
			this.c_DO_800_05,
			this.g2_0,
			this.raio_P4901,
			this.n_P4901,
			this.c_P4901,
			this.raio_P4902,
			this.n_P4902,
			this.c_P4902,
			this.raio_P4903,
			this.n_P4903,
			this.c_P4903,
			this.raio_R4005A,
			this.n_R4005A,
			this.c_R4005A,
			this.raio_R4005B,
			this.n_R4005B,
			this.c_R4005B,
			this.raio_MO_300_01,
			this.n_MO_300_01,
			this.c_MO_300_01,
			this.g2_1,
			this.raio_QL_PORTARIA,
			this.n_QL_PORTARIA,
			this.c_QL_PORTARIA,
			this.raio_QL_ADM,
			this.n_QL_ADM,
			this.c_QL_ADM,
			this.raio_QL_LODO,
			this.n_QL_LODO,
			this.c_QL_LODO,
			this.raio_QLSL,
			this.n_QLSL,
			this.c_QLSL,
			this.raio_QL_ILUMINACAO,
			this.n_QL_ILUMINACAO,
			this.c_QL_ILUMINACAO,
			this.xH_V4601,
			this.xH_V4602,
			this.xH_V4603,
			this.xH_V4604,
			this.xH_EX_500_01,
			this.xH_EX_500_02,
			this.xH_EX_500_03,
			this.xH_EX_500_04,
			this.xH_EX_500_05,
			this.xH_COMP_500_01,
			this.xH_COMP_500_02,
			this.xH_UCT_200_01,
			this.xH_UCT_200_02,
			this.xH_UCT_200_03,
			this.xH_BS_100_01,
			this.xH_BS_100_02,
			this.xH_BS_100_03,
			this.xH_GM_100_01,
			this.xH_UV_700_01,
			this.xH_UV_700_02,
			this.xH_DO_800_04,
			this.xH_DO_800_05,
			this.xH_P4901,
			this.xH_P4902,
			this.xH_P4903,
			this.xH_R4005A,
			this.xH_R4005B,
			this.xH_MO_300_01,
			this.xH_QL_PORTARIA,
			this.xH_QL_ADM,
			this.xH_QL_LODO,
			this.xH_QLSL,
			this.xH_QL_ILUMINACAO,
			this.xPlanta});
			this.Size = new System.Drawing.Size(1000, 590);

		}
		private NxtControl.GuiFramework.Rectangle cabecalho;
		private NxtControl.GuiFramework.FreeText titulo;
		private NxtControl.GuiFramework.FreeText tPlanta;
		private NxtControl.GuiFramework.FreeText g0_0;
		private NxtControl.GuiFramework.Polygon raio_V4601;
		private NxtControl.GuiFramework.FreeText n_V4601;
		private System.HMI.Symbols.Base.CheckButton c_V4601;
		private NxtControl.GuiFramework.Polygon raio_V4602;
		private NxtControl.GuiFramework.FreeText n_V4602;
		private System.HMI.Symbols.Base.CheckButton c_V4602;
		private NxtControl.GuiFramework.Polygon raio_V4603;
		private NxtControl.GuiFramework.FreeText n_V4603;
		private System.HMI.Symbols.Base.CheckButton c_V4603;
		private NxtControl.GuiFramework.Polygon raio_V4604;
		private NxtControl.GuiFramework.FreeText n_V4604;
		private System.HMI.Symbols.Base.CheckButton c_V4604;
		private NxtControl.GuiFramework.FreeText g0_1;
		private NxtControl.GuiFramework.Polygon raio_EX_500_01;
		private NxtControl.GuiFramework.FreeText n_EX_500_01;
		private System.HMI.Symbols.Base.CheckButton c_EX_500_01;
		private NxtControl.GuiFramework.Polygon raio_EX_500_02;
		private NxtControl.GuiFramework.FreeText n_EX_500_02;
		private System.HMI.Symbols.Base.CheckButton c_EX_500_02;
		private NxtControl.GuiFramework.Polygon raio_EX_500_03;
		private NxtControl.GuiFramework.FreeText n_EX_500_03;
		private System.HMI.Symbols.Base.CheckButton c_EX_500_03;
		private NxtControl.GuiFramework.Polygon raio_EX_500_04;
		private NxtControl.GuiFramework.FreeText n_EX_500_04;
		private System.HMI.Symbols.Base.CheckButton c_EX_500_04;
		private NxtControl.GuiFramework.Polygon raio_EX_500_05;
		private NxtControl.GuiFramework.FreeText n_EX_500_05;
		private System.HMI.Symbols.Base.CheckButton c_EX_500_05;
		private NxtControl.GuiFramework.FreeText g0_2;
		private NxtControl.GuiFramework.Polygon raio_COMP_500_01;
		private NxtControl.GuiFramework.FreeText n_COMP_500_01;
		private System.HMI.Symbols.Base.CheckButton c_COMP_500_01;
		private NxtControl.GuiFramework.Polygon raio_COMP_500_02;
		private NxtControl.GuiFramework.FreeText n_COMP_500_02;
		private System.HMI.Symbols.Base.CheckButton c_COMP_500_02;
		private NxtControl.GuiFramework.FreeText g1_0;
		private NxtControl.GuiFramework.Polygon raio_UCT_200_01;
		private NxtControl.GuiFramework.FreeText n_UCT_200_01;
		private System.HMI.Symbols.Base.CheckButton c_UCT_200_01;
		private NxtControl.GuiFramework.Polygon raio_UCT_200_02;
		private NxtControl.GuiFramework.FreeText n_UCT_200_02;
		private System.HMI.Symbols.Base.CheckButton c_UCT_200_02;
		private NxtControl.GuiFramework.Polygon raio_UCT_200_03;
		private NxtControl.GuiFramework.FreeText n_UCT_200_03;
		private System.HMI.Symbols.Base.CheckButton c_UCT_200_03;
		private NxtControl.GuiFramework.FreeText g1_1;
		private NxtControl.GuiFramework.Polygon raio_BS_100_01;
		private NxtControl.GuiFramework.FreeText n_BS_100_01;
		private System.HMI.Symbols.Base.CheckButton c_BS_100_01;
		private NxtControl.GuiFramework.Polygon raio_BS_100_02;
		private NxtControl.GuiFramework.FreeText n_BS_100_02;
		private System.HMI.Symbols.Base.CheckButton c_BS_100_02;
		private NxtControl.GuiFramework.Polygon raio_BS_100_03;
		private NxtControl.GuiFramework.FreeText n_BS_100_03;
		private System.HMI.Symbols.Base.CheckButton c_BS_100_03;
		private NxtControl.GuiFramework.Polygon raio_GM_100_01;
		private NxtControl.GuiFramework.FreeText n_GM_100_01;
		private System.HMI.Symbols.Base.CheckButton c_GM_100_01;
		private NxtControl.GuiFramework.FreeText g1_2;
		private NxtControl.GuiFramework.Polygon raio_UV_700_01;
		private NxtControl.GuiFramework.FreeText n_UV_700_01;
		private System.HMI.Symbols.Base.CheckButton c_UV_700_01;
		private NxtControl.GuiFramework.Polygon raio_UV_700_02;
		private NxtControl.GuiFramework.FreeText n_UV_700_02;
		private System.HMI.Symbols.Base.CheckButton c_UV_700_02;
		private NxtControl.GuiFramework.FreeText g1_3;
		private NxtControl.GuiFramework.Polygon raio_DO_800_04;
		private NxtControl.GuiFramework.FreeText n_DO_800_04;
		private System.HMI.Symbols.Base.CheckButton c_DO_800_04;
		private NxtControl.GuiFramework.Polygon raio_DO_800_05;
		private NxtControl.GuiFramework.FreeText n_DO_800_05;
		private System.HMI.Symbols.Base.CheckButton c_DO_800_05;
		private NxtControl.GuiFramework.FreeText g2_0;
		private NxtControl.GuiFramework.Polygon raio_P4901;
		private NxtControl.GuiFramework.FreeText n_P4901;
		private System.HMI.Symbols.Base.CheckButton c_P4901;
		private NxtControl.GuiFramework.Polygon raio_P4902;
		private NxtControl.GuiFramework.FreeText n_P4902;
		private System.HMI.Symbols.Base.CheckButton c_P4902;
		private NxtControl.GuiFramework.Polygon raio_P4903;
		private NxtControl.GuiFramework.FreeText n_P4903;
		private System.HMI.Symbols.Base.CheckButton c_P4903;
		private NxtControl.GuiFramework.Polygon raio_R4005A;
		private NxtControl.GuiFramework.FreeText n_R4005A;
		private System.HMI.Symbols.Base.CheckButton c_R4005A;
		private NxtControl.GuiFramework.Polygon raio_R4005B;
		private NxtControl.GuiFramework.FreeText n_R4005B;
		private System.HMI.Symbols.Base.CheckButton c_R4005B;
		private NxtControl.GuiFramework.Polygon raio_MO_300_01;
		private NxtControl.GuiFramework.FreeText n_MO_300_01;
		private System.HMI.Symbols.Base.CheckButton c_MO_300_01;
		private NxtControl.GuiFramework.FreeText g2_1;
		private NxtControl.GuiFramework.Polygon raio_QL_PORTARIA;
		private NxtControl.GuiFramework.FreeText n_QL_PORTARIA;
		private System.HMI.Symbols.Base.CheckButton c_QL_PORTARIA;
		private NxtControl.GuiFramework.Polygon raio_QL_ADM;
		private NxtControl.GuiFramework.FreeText n_QL_ADM;
		private System.HMI.Symbols.Base.CheckButton c_QL_ADM;
		private NxtControl.GuiFramework.Polygon raio_QL_LODO;
		private NxtControl.GuiFramework.FreeText n_QL_LODO;
		private System.HMI.Symbols.Base.CheckButton c_QL_LODO;
		private NxtControl.GuiFramework.Polygon raio_QLSL;
		private NxtControl.GuiFramework.FreeText n_QLSL;
		private System.HMI.Symbols.Base.CheckButton c_QLSL;
		private NxtControl.GuiFramework.Polygon raio_QL_ILUMINACAO;
		private NxtControl.GuiFramework.FreeText n_QL_ILUMINACAO;
		private System.HMI.Symbols.Base.CheckButton c_QL_ILUMINACAO;
		private System.HMI.Symbols.Base.Execute<bool> xH_V4601;
		private System.HMI.Symbols.Base.Execute<bool> xH_V4602;
		private System.HMI.Symbols.Base.Execute<bool> xH_V4603;
		private System.HMI.Symbols.Base.Execute<bool> xH_V4604;
		private System.HMI.Symbols.Base.Execute<bool> xH_EX_500_01;
		private System.HMI.Symbols.Base.Execute<bool> xH_EX_500_02;
		private System.HMI.Symbols.Base.Execute<bool> xH_EX_500_03;
		private System.HMI.Symbols.Base.Execute<bool> xH_EX_500_04;
		private System.HMI.Symbols.Base.Execute<bool> xH_EX_500_05;
		private System.HMI.Symbols.Base.Execute<bool> xH_COMP_500_01;
		private System.HMI.Symbols.Base.Execute<bool> xH_COMP_500_02;
		private System.HMI.Symbols.Base.Execute<bool> xH_UCT_200_01;
		private System.HMI.Symbols.Base.Execute<bool> xH_UCT_200_02;
		private System.HMI.Symbols.Base.Execute<bool> xH_UCT_200_03;
		private System.HMI.Symbols.Base.Execute<bool> xH_BS_100_01;
		private System.HMI.Symbols.Base.Execute<bool> xH_BS_100_02;
		private System.HMI.Symbols.Base.Execute<bool> xH_BS_100_03;
		private System.HMI.Symbols.Base.Execute<bool> xH_GM_100_01;
		private System.HMI.Symbols.Base.Execute<bool> xH_UV_700_01;
		private System.HMI.Symbols.Base.Execute<bool> xH_UV_700_02;
		private System.HMI.Symbols.Base.Execute<bool> xH_DO_800_04;
		private System.HMI.Symbols.Base.Execute<bool> xH_DO_800_05;
		private System.HMI.Symbols.Base.Execute<bool> xH_P4901;
		private System.HMI.Symbols.Base.Execute<bool> xH_P4902;
		private System.HMI.Symbols.Base.Execute<bool> xH_P4903;
		private System.HMI.Symbols.Base.Execute<bool> xH_R4005A;
		private System.HMI.Symbols.Base.Execute<bool> xH_R4005B;
		private System.HMI.Symbols.Base.Execute<bool> xH_MO_300_01;
		private System.HMI.Symbols.Base.Execute<bool> xH_QL_PORTARIA;
		private System.HMI.Symbols.Base.Execute<bool> xH_QL_ADM;
		private System.HMI.Symbols.Base.Execute<bool> xH_QL_LODO;
		private System.HMI.Symbols.Base.Execute<bool> xH_QLSL;
		private System.HMI.Symbols.Base.Execute<bool> xH_QL_ILUMINACAO;
		private System.HMI.Symbols.Base.Execute<bool> xPlanta;
		#endregion
	}
}
