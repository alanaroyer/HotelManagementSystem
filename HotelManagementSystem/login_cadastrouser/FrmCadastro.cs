using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ProjetoHotel
{
    public partial class FrmCadastro : Form
    {
        ///////// ------ Código que puxa o banco de dados ------ ///////////
        private string connectionString = "SERVER=localhost;DATABASE=hoteldb;UID=root;PWD=senac";

        public FrmCadastro()
        {
            InitializeComponent();
        }

        ///////// ------ Código que ativa o PasswordChar ------ ///////////
        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {

            if (CheckbxShowPas.Checked)
            {
                TextBoxSenha.PasswordChar = '\0';
                TextBoxConfirmaSenha.PasswordChar = '\0';
            }
            else
            {
                TextBoxSenha.PasswordChar = '•';
                TextBoxConfirmaSenha.PasswordChar = '•';
            }
        }

        ///////// ------ Código que fecha a tela atual ------ ///////////
        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        ///////// ------ Código IMPORTANTE que salva os seus dados no Banco de Dados ------ ///////////
        private void BtnCadastrarUsuario_Click(object sender, EventArgs e)
        {
            string nomeUsuario = TextBoxNomeUsuario.Text;
            string senha = TextBoxSenha.Text;
            string confirmaSenha = TextBoxConfirmaSenha.Text;

            // Verificar se as senhas coincidem
            if (senha != confirmaSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            // Criptografar a senha (usando SHA-256)
            string senhaCriptografada = Convert.ToBase64String(
                new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha))
            );

            // Inserir o usuário no banco de dados
            using (Conexao conexao = new Conexao())
            {
                string query = "INSERT INTO usuarios (nome_usuario, senha) VALUES (@nomeUsuario, @senha)";
                MySqlCommand cmd = new MySqlCommand(query, conexao.GetConnection());
                cmd.Parameters.AddWithValue("@nomeUsuario", nomeUsuario);
                cmd.Parameters.AddWithValue("@senha", senhaCriptografada);

                try
                {
                    conexao.GetConnection().Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário cadastrado com sucesso!");

                    new FrmLogin().Show();
                    this.Hide();

                    // Limpar os campos após o cadastro
                    TextBoxNomeUsuario.Clear();
                    TextBoxSenha.Clear();
                    TextBoxConfirmaSenha.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar usuário: " + ex.Message);
                }
                finally
                {
                    conexao.GetConnection().Close();
                }
            }
        }

    }
}