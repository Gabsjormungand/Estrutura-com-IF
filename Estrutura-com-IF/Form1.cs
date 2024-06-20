using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estrutura_com_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtBoxNumero.Text, out double number))
            {
                if(number < 0)
                {
                    number = Math.Abs(number);
                }

                lblResutado.Text = $"Resutado: {number}";
            }
            else
            {
                MessageBox.Show("Por favor, digite um número válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
