using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            F_NovoCliente f_NovoCliente = new F_NovoCliente();
            f_NovoCliente.ShowDialog();
        }

        private void clubeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_ClubeClientes f_ClubeClientes = new F_ClubeClientes();
            f_ClubeClientes.ShowDialog();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            F_NovosLivros f_NovosLivros = new F_NovosLivros();
            f_NovosLivros.ShowDialog();
        }

    }
}
