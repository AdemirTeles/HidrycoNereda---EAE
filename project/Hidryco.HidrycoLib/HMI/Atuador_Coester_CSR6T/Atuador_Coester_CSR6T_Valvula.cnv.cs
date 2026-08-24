/*
 * Created by EcoStruxure Automation Expert.
 * User:
 * Date: 1/26/2026
 * Time: 1:13 PM
 */

using System;
using NxtControl.GuiFramework;
using Hidryco.HidrycoLib.SupportClasses;

namespace Hidryco.HidrycoLib.Symbols.Atuador_Coester_CSR6T
{

    public partial class Valvula : HMISymbol
    {
        private ushort _stsAnimacao;

        public Valvula()
        {
            InitializeComponent();
            
        }

        public override void EndInit()
        {
            base.EndInit();
            // nada aqui para o nome — vem na conexão
        }

        void SDefaultConnStateChanged(string instancePath)
        {
            string name_path = instancePath;

            if (!string.IsNullOrEmpty(instancePath) && instancePath.Contains("."))
                name_path = instancePath.Substring(instancePath.LastIndexOf('.') + 1);

            InstanceName.Text = name_path;
        }

        void StsAnimacaoValueChanged(object sender, ValueChangedEventArgs e)
        {
            valvula_Horizontal1.Animacao = Convert.ToUInt16(e.Value);
		}

		void StsFalhaComunicacaoValueChanged(object sender, ValueChangedEventArgs e)
		{
			falha_comunicacao1.Visible = (bool)e.Value;
		}
    }
}
