using OMelhoProjetoDaVida.Code.BLL;
using OMelhoProjetoDaVida.Code.DTO;
using System;
using System.Windows.Forms;

namespace OMelhoProjetoDaVida.Ui
{
    public partial class FrmDados : Form
    {
        DadosBLL Dadosbll = new DadosBLL();
        DadosDTO Dadosdto = new DadosDTO();

        public FrmDados()
        {
            InitializeComponent();
            dgvDados.DataSource = Dadosbll.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            { //Preenchimento do objeto 
                Dadosdto.Ylms = txtylms.Text;
                Dadosdto.Y03 = txty03.Text;
                Dadosdto.S25 = txts25.Text;

                //Envio do dto preenchido para o método inserir
                Dadosbll.Inserir(Dadosdto);

                //mensagem de cadastrado 
                MessageBox.Show("Cadastrado com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDados.DataSource = Dadosbll.Listar();

                txtylms.Clear();
                txts25.Clear();
                txty03.Clear();
            } 
            catch { MessageBox.Show("Impossivel fazr isso!"); }
            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            try {
                // Preenchimento do objeto

                Dadosdto.Ylms = txtylms.Text;
                Dadosdto.Y03 = txty03.Text;
                Dadosdto.S25 = txts25.Text;

                //Envio do dto preenchido para o método inserir
                Dadosbll.Editar(Dadosdto);

                //mensagem de cadastrado 
                MessageBox.Show("Editado com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDados.DataSource = Dadosbll.Listar();

                txtylms.Clear();
                txts25.Clear();
                txty03.Clear();
            }
            catch
            {
                MessageBox.Show("Impossivel fazr isso!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try {

                // Preenchimento do objeto

                Dadosdto.Ylms = txtylms.Text;
                Dadosdto.Y03 = txty03.Text;
                Dadosdto.S25 = txts25.Text;

                //Envio do dto preenchido para o método inserir
                Dadosbll.Excluir(Dadosdto);

                //mensagem de cadastrado 
                MessageBox.Show("Excluido com sucesso!", "Dados", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvDados.DataSource = Dadosbll.Listar();

                txtylms.Clear();
                txts25.Clear();
                txty03.Clear();
            }
            catch
            {
                MessageBox.Show("Impossivel fazr isso!");
            }
        }

        private void dgvSorvetes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Dadosdto.Id = int.Parse(dgvDados.Rows[e.RowIndex].Cells[0].Value.ToString());
                txtylms.Text = dgvDados.Rows[e.RowIndex].Cells[1].Value.ToString();
                txty03.Text = dgvDados.Rows[e.RowIndex].Cells[2].Value.ToString();
                txts25.Text = dgvDados.Rows[e.RowIndex].Cells[3].Value.ToString();
            } catch 
            {
                MessageBox.Show("Impossivel fazr isso!");
            }
           
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario user = new FrmUsuario();
            user.ShowDialog();
        }
    }
}
