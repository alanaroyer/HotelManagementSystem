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

namespace HotelManagementSystem
{
    public partial class FrmLogin : Form
    {

        public FrmLogin()
        {
            InitializeComponent();
        }

        //////////// ------ Código do Link clicavel que direciona para a tela de cadastros ------ ////////////


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


        }

        private void LinkTxtCriarconta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
