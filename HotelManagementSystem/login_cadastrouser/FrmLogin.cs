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

namespace HotelManagementSystem
{
    public partial class FrmLogin : Form
    {
        ////////////////////////// ------ Chamar Banco de Dados ------ /////////////////////////////
        private string connectionString = "SERVER=localhost;DATABASE=hoteldb;UID=root;PWD=senac";
        

        public FrmLogin()
        {
            InitializeComponent();
        }

        //////////// ------ Código do Link clicavel que direciona para a tela de cadastros ------ ////////////
        private void LinkTxtCriarconta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmCadastro frmcadastro = new FrmCadastro();
            frmcadastro.show();
        }

        ///////////////////// ------ Código para fechar a tela ------ ///////////////////////////
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

            // Criptografar a senha (usando SHA-256)
            string senhaCriptografada = Convert.ToBase64String(
                new System.Security.Cryptography.SHA256Managed().ComputeHash(System.Text.Encoding.UTF8.GetBytes(senha))
            );

           
        }

    }
}
