using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Hirez
{
    public partial class Cadastrar : Form
    {
        Cadastro cad = new Cadastro();
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Botão de voltar
            TelaPrincipal principal = new TelaPrincipal(); // Instanciando o objeto

            this.Close();
            principal.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cad.setNome(nomeBox.Text);
            cad.setUsername(usernameBox.Text);
            cad.setEmail(emailBox.Text);
            cad.setSenha(senhaBox.Text);
            cad.setConfirmaSenha(confirmaSenhaBox.Text);
            cad.setCPf(cpfBox.Text);
            cad.setEstado(estadoBox.Text);
            cad.setCep(cepBox.Text);
            cad.setIdade(int.Parse(idadeBox.Text));
            cad.setSexo(sexoBox.Text);
            cad.setTelefone(telefoneBox.Text);
            cad.setCelular(celularBox.Text);

            MessageBox.Show("Dados cadastrados com sucesso [OBJETO]", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            // Banco de dados
            MySqlConnection conexao = new MySqlConnection("server=localhost; User Id=root; database=hirez; password=''");
            MySqlCommand sqlQuery = new MySqlCommand("INSERT INTO `cadastrar-hirez` (nome, username, email, senha, cpf, estado, cep, idade, sexo, telefone, celular) " +
                  $"VALUES ('{cad.getNome()}', " +
                  $"'{cad.getUsername()}', " +
                  $"'{cad.getEmail()}', " +
                  $"'{cad.getSenha()}', " +
                  $"'{cad.getCPf()}', " +
                  $"'{cad.getEstado()}'," +
                  $"'{cad.getCep()}', " +
                  $"{cad.getIdade()}, " +
                  $"'{cad.getSexo()}', " +
                  $"'{cad.getTelefone()}', " +
                  $"'{cad.getCelular()}');", conexao);

            // INSERT INTO `cadastrar-hirez` (nome, username, email, senha, cpf, estado, cep, idade, sexo, telefone, celular) VALUES ("Jorge Ben Jor", "jorginhocarioca", "jorgebemjor@gmail.com", "jorginho123456", "485-468-557-06", "São Paulo", "08-502-969", 26, "Masculino", "4665-8895", "13 95884-6581");

            try
            {
                conexao.Open();
                sqlQuery.ExecuteReader();
                MessageBox.Show("Dados armazenados com sucesso!", "Salvar dados [DB] ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex, "ERRO Atençao!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conexao.Close();
            }

            TelaPrincipal telaPrincipal = new TelaPrincipal();

            // Retorna para inicio
            telaPrincipal.Show();
            this.Close();
        }

        private void nomeBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
