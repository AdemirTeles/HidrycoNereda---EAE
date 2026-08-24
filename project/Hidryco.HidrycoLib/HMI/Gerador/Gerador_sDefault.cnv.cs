using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Gerador
	
{
	public partial class sDefault : NxtControl.GuiFramework.HMISymbol
	{
		public sDefault()
		{
			InitializeComponent();
		}

		void Remote_startMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_start.Checked = true;
		}

		void Remote_startMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_start.Checked = false;
		}

		void Remote_stopMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_stop.Checked = true;
		}

		void Remote_stopMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_stop.Checked = false;
		}

		void Remote_GB_ONMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_GB_ON.Checked = true;
		}

		void Remote_GB_ONMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_GB_ON.Checked = false;
		}

		void Remote_GB_OFFMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_GB_OFF.Checked = true;
		}

		void Remote_GB_OFFMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Remote_GB_OFF.Checked = false;
		}

		void Start_syncMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Start_sync.Checked = true;
		}

		void Start_syncMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Start_sync.Checked = false;
		}

		void Deload_stopMouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Deload_stop.Checked = true;
		}

		void Deload_stopMouseUp(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			Deload_stop.Checked = false;
		}


	}
}
