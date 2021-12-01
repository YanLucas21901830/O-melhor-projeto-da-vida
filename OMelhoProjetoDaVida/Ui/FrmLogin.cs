using OMelhoProjetoDaVida.Code.BLL;
using OMelhoProjetoDaVida.Code.DTO;
using OMelhoProjetoDaVida.Ui;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OMelhoProjetoDaVida
{
    public partial class Form1 : Form
    {
        LoginBLL loginBLL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txtEmail.Text;
            loginDTO.Senha = txtSenha.Text;
            loginDTO.CPF = txtCpf.Text;

            if (loginBLL.RealizarLogin(loginDTO) == true)
            {
                FrmUsuario user = new FrmUsuario();
                user.ShowDialog();
            }
            else
            {
                MessageBox.Show("Verifique os campos.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
