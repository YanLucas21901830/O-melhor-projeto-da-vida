using OMelhoProjetoDaVida.Code.BLL;
using OMelhoProjetoDaVida.Code.DTO;
using System;
using System.Windows.Forms;

namespace OMelhoProjetoDaVida.Ui
{
    public partial class FrmUsuario : Form
    {
        UsuarioBLL usuarioBLL = new UsuarioBLL();
        UsuarioDTO usuarioDTO = new UsuarioDTO();

        public FrmUsuario()
        {
            InitializeComponent();
            dgvUsuario.DataSource = usuarioBLL.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try {
                usuarioDTO.Nome = txtNome.Text;
                usuarioDTO.Tell = txtTell.Text;
                usuarioDTO.Rua = txtRua.Text;
                usuarioDTO.Numero = txtNumero.Text;
                usuarioDTO.Bairro = txtBairro.Text;
                usuarioDTO.Cidade = txtCidade.Text;
                usuarioDTO.Estado = txtEstado.Text;
                usuarioDTO.Pais = txtNomedosPais.Text;
                usuarioDTO.Cpf = txtcpf.Text;
                usuarioDTO.Rg = txtRG.Text;
                usuarioDTO.Datanas = txtData.Text;
                usuarioDTO.País = txtPais.Text;
                usuarioDTO.Email = txtEmail.Text;
                usuarioDTO.Senha = txtSenha.Text;
                usuarioBLL.Inserir(usuarioDTO);
                MessageBox.Show("Cadastrado com sucesso!", "usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUsuario.DataSource = usuarioBLL.Listar();
            } catch { MessageBox.Show("Impossivel fazr isso!"); }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try {
                usuarioDTO.Nome = txtNome.Text;
                usuarioDTO.Tell = txtTell.Text;
                usuarioDTO.Rua = txtRua.Text;
                usuarioDTO.Numero = txtNumero.Text;
                usuarioDTO.Bairro = txtBairro.Text;
                usuarioDTO.Cidade = txtCidade.Text;
                usuarioDTO.Estado = txtEstado.Text;
                usuarioDTO.Pais = txtNomedosPais.Text;
                usuarioDTO.Cpf = txtcpf.Text;
                usuarioDTO.Rg = txtRG.Text;
                usuarioDTO.Datanas = txtData.Text;
                usuarioDTO.País = txtPais.Text;
                usuarioDTO.Email = txtEmail.Text;
                usuarioDTO.Senha = txtSenha.Text;
                usuarioBLL.Excluir(usuarioDTO);
                MessageBox.Show("Excluido com sucesso!", "usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUsuario.DataSource = usuarioBLL.Listar();
            } catch { MessageBox.Show("Impossivel fazr isso!"); }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try 
            {
                usuarioDTO.Nome = txtNome.Text;
                usuarioDTO.Tell = txtTell.Text;
                usuarioDTO.Rua = txtRua.Text;
                usuarioDTO.Numero = txtNumero.Text;
                usuarioDTO.Bairro = txtBairro.Text;
                usuarioDTO.Cidade = txtCidade.Text;
                usuarioDTO.Estado = txtEstado.Text;
                usuarioDTO.Pais = txtNomedosPais.Text;
                usuarioDTO.Cpf = txtcpf.Text;
                usuarioDTO.Rg = txtRG.Text;
                usuarioDTO.Datanas = txtData.Text;
                usuarioDTO.País = txtPais.Text;
                usuarioDTO.Email = txtEmail.Text;
                usuarioDTO.Senha = txtSenha.Text;
                usuarioBLL.Editar(usuarioDTO);
                MessageBox.Show("Editado com sucesso!", "usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvUsuario.DataSource = usuarioBLL.Listar();
            } catch { MessageBox.Show("Impossivel fazr isso!"); }
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try 
            {
                txtNome.Clear();
                txtTell.Clear();
                txtRua.Clear();
                txtNumero.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
                txtNomedosPais.Clear();
                txtcpf.Clear();
                txtRG.Clear();
                txtData.Clear();
                txtPais.Clear();
                txtEmail.Clear();
                txtSenha.Clear();
            } catch { MessageBox.Show("Impossivel fazr isso!"); }
            
        }

        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try {

                usuarioDTO.Id = int.Parse(dgvUsuario.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtNome.Text = dgvUsuario.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtTell.Text = dgvUsuario.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtRua.Text = dgvUsuario.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNumero.Text = dgvUsuario.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtBairro.Text = dgvUsuario.Rows[e.RowIndex].Cells[5].Value.ToString();
                txtCidade.Text = dgvUsuario.Rows[e.RowIndex].Cells[6].Value.ToString();
                txtEstado.Text = dgvUsuario.Rows[e.RowIndex].Cells[7].Value.ToString();
                txtNomedosPais.Text = dgvUsuario.Rows[e.RowIndex].Cells[8].Value.ToString();
                txtcpf.Text = dgvUsuario.Rows[e.RowIndex].Cells[9].Value.ToString();
                txtRG.Text = dgvUsuario.Rows[e.RowIndex].Cells[10].Value.ToString();
                txtData.Text = dgvUsuario.Rows[e.RowIndex].Cells[11].Value.ToString();
                txtPais.Text = dgvUsuario.Rows[e.RowIndex].Cells[12].Value.ToString();
                txtEmail.Text = dgvUsuario.Rows[e.RowIndex].Cells[13].Value.ToString();
                txtSenha.Text = dgvUsuario.Rows[e.RowIndex].Cells[14].Value.ToString();
            } catch { MessageBox.Show("Impossivel fazr isso!"); }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDados dado = new FrmDados();
            dado.ShowDialog();
        }
    }
}
