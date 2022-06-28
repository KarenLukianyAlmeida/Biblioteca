using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Livraria
{
    public partial class F_NovoCliente : Form
    {
        public F_NovoCliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrarEndereco_Click(object sender, EventArgs e)
        {
            F_CadastrarEndereco f_CadastrarEndereco = new F_CadastrarEndereco();
            f_CadastrarEndereco.ShowDialog();
        }

    }
}
