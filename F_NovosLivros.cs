using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Livraria
{
    public partial class F_NovosLivros : Form
    {
        public F_NovosLivros()
        {
            InitializeComponent();
        }

        private void btn_addNovoAutor_Click(object sender, EventArgs e)
        {
            F_AddAutor f_AddAutor = new F_AddAutor();
            f_AddAutor.ShowDialog();
        }
    }
}
