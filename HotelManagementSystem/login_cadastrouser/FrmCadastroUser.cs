using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace HotelManagementSystem.login_cadastrouser
{
    public partial class FrmCadastroUser : Form
    {
        public FrmCadastroUser()
        {
            InitializeComponent();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                TextBoxSenha.PasswordChar = '\0';
                TextBoxConfirmarSenha.PasswordChar = '\0';
            }
            else
            {
                TextBoxSenha.PasswordChar = '•';
                TextBoxConfirmarSenha.PasswordChar = '•';
            }
        }

        private void Btncadastrar_Click(object sender, EventArgs e)
        {
            // --- 1. Validação dos Campos ---
            string nomeUsuario = textBoxNomeUsuario.Text;
            string senhaPlana = TextBoxSenha.Text;
            string confirmarSenha = TextBoxConfirmarSenha.Text;

            // Verifica se algum campo está vazio
            if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrWhiteSpace(senhaPlana) || string.IsNullOrWhiteSpace(confirmarSenha))
            {
                MessageBox.Show("Por favor, preencha todos os campos.", "Campos Obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Para a execução
            }

            // Verifica se as senhas digitadas são iguais
            if (senhaPlana != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem. Tente novamente.", "Erro de Senha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Para a execução
            }


            // --- 2. Interação com o Banco de Dados ---
            Conexao conn = new Conexao();
            try
            {
                MySqlConnection conexaoAberta = conn.Abrir();

                // **PASSO EXTRA, MAS IMPORTANTE: VERIFICAR SE O USUÁRIO JÁ EXISTE**
                string sqlCheck = "SELECT COUNT(*) FROM usuario WHERE nome_usuario = @usuario";
                MySqlCommand comandoCheck = new MySqlCommand(sqlCheck, conexaoAberta);
                comandoCheck.Parameters.AddWithValue("@usuario", nomeUsuario);

                // ExecuteScalar pega um único valor. Convertemos para int.
                long userCount = (long)comandoCheck.ExecuteScalar();

                if (userCount > 0)
                {
                    MessageBox.Show("Este nome de usuário já está em uso. Por favor, escolha outro.", "Usuário Existente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    conn.Fechar(); // Fecha a conexão antes de sair
                    return;
                }

                // Se o usuário não existe, continuamos com o cadastro...

                // --- 3. Criptografar a Senha ---
                string senhaHash = BCrypt.Net.BCrypt.HashPassword(senhaPlana, 12);


                // --- 4. Executar o Comando INSERT ---
                string sqlInsert = "INSERT INTO usuario (nome_usuario, senha) VALUES (@usuario, @senhaHash)";
                MySqlCommand comandoInsert = new MySqlCommand(sqlInsert, conexaoAberta);

                // Adiciona os parâmetros de forma segura para evitar SQL Injection
                comandoInsert.Parameters.AddWithValue("@usuario", nomeUsuario);
                comandoInsert.Parameters.AddWithValue("@senhaHash", senhaHash);

                // ExecuteNonQuery é usado para comandos que não retornam dados (INSERT, UPDATE, DELETE)
                comandoInsert.ExecuteNonQuery();

                // --- 5. Feedback de Sucesso ---
                MessageBox.Show("Usuário cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Opcional: Fecha a tela de cadastro após o sucesso
                FrmLogin telaDeLogin = new FrmLogin();
                telaDeLogin.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao cadastrar o usuário: " + ex.Message, "Erro de Banco de Dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Garante que a conexão será fechada de qualquer maneira
                conn.Fechar();
            }
        }

        private void LinkTxtentrarconta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            FrmLogin telaDeLogin = new FrmLogin();
            telaDeLogin.Show();
            this.Hide();
        }
    }
}
