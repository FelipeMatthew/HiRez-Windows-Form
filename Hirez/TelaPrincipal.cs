using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hirez
{
    public partial class TelaPrincipal : Form
    {
        Cadastrar cadastrarPagina = new Cadastrar();
        Consultar consultarPagina = new Consultar();
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            cadastrarPagina.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            consultarPagina.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Botão de sair
            if (MessageBox.Show("Deseja sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
