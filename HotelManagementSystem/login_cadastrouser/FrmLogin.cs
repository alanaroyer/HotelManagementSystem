using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagementSystem.login_cadastrouser;
using MySql.Data.MySqlClient;
using BCrypt.Net;
using HotelManagementSystem.menu;

namespace HotelManagementSystem
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        //////////// ------ Código do Link clicavel que direciona para a tela de cadastros ------ ////////////

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /////////////////// ------ Código para ativar o PasswordChar ------ //////////////////////
        private void CheckbxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckbxShowPas.Checked)
            {
                textBoxSenha.PasswordChar = '\0';
            }
            else
            {
                textBoxSenha.PasswordChar = '•';
            }
        }

        ///////// ------ código IMPORTANTE que puxa o banco de dados e te direciona para o main ------ ///////////
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string nomeUsuario = textBoxNomeUsuario.Text;
            string senha = textBoxSenha.Text;
            // 2. Validar se os campos não estão vazios
            if (string.IsNullOrWhiteSpace(nomeUsuario) || string.IsNullOrWhiteSpace(senha))
            {
                MessageBox.Show("Por favor, preencha o usuário e a senha.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Para a execução aqui
            }

            // Usaremos nossa classe de conexão
            Conexao conn = new Conexao();

            try
            {
                // Abre a conexão
                MySqlConnection conexaoAberta = conn.Abrir();

                // 3. Montar a consulta SQL de forma SEGURA com parâmetros
                //    Isso evita um ataque chamado "SQL Injection"
                string sql = "SELECT senha FROM usuario WHERE nome_usuario = @usuario";

                // 4. Criar o comando para executar a consulta
                MySqlCommand comando = new MySqlCommand(sql, conexaoAberta);

                // Substitui o @usuario pelo valor que o usuário digitou
                comando.Parameters.AddWithValue("@usuario", nomeUsuario);

                // 5. Executar a consulta e pegar o resultado
                //    ExecuteScalar é ótimo para buscar um único valor (a senha do banco)
                object resultado = comando.ExecuteScalar();

                if (resultado != null) // Se encontrou o usuário no banco...
                {
                    // Pega a senha HASH que está salva no banco
                    string senhaHashDoBanco = resultado.ToString();

                    // 6. **A MÁGICA ACONTECE AQUI**
                    //    Verifica se a senha que o usuário digitou corresponde à hash no banco
                    if (BCrypt.Net.BCrypt.Verify(senha, senhaHashDoBanco))
                    {
                        // Senha correta!
                        MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        FrmMenu tela = new FrmMenu ();
                        tela.Show();
                        this.Hide();
                    }
                    else
                    {
                        // Senha incorreta
                        MessageBox.Show("Usuário ou senha inválidos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // Usuário não encontrado no banco
                    MessageBox.Show("Usuário ou senha inválidos.", "Falha no Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Se der qualquer outro erro...
                MessageBox.Show("Ocorreu um erro durante o login: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Garante que a conexão sempre será fechada
                conn.Fechar();
            }

        }

        private void LinkTxtCriarconta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // IMPORTANTE: Troque "FormCadastro" pelo nome real da sua tela de cadastro.
            FrmCadastroUser telaDeCadastro = new FrmCadastroUser();

            // Mostra a tela de cadastro que acabamos de criar.
            telaDeCadastro.Show();

            // Esconde a tela de login atual.
            this.Hide();
        }

    }
}
