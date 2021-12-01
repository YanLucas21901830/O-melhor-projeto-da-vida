
namespace OMelhoProjetoDaVida.Ui
{
    partial class FrmDados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txts25 = new System.Windows.Forms.TextBox();
            this.s25 = new System.Windows.Forms.Label();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txty03 = new System.Windows.Forms.TextBox();
            this.txtylms = new System.Windows.Forms.TextBox();
            this.lbly03 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txts25
            // 
            this.txts25.Location = new System.Drawing.Point(12, 142);
            this.txts25.Name = "txts25";
            this.txts25.Size = new System.Drawing.Size(100, 20);
            this.txts25.TabIndex = 31;
            // 
            // s25
            // 
            this.s25.AutoSize = true;
            this.s25.Location = new System.Drawing.Point(9, 126);
            this.s25.Name = "s25";
            this.s25.Size = new System.Drawing.Size(24, 13);
            this.s25.TabIndex = 30;
            this.s25.Text = "s25";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(118, 49);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(364, 223);
            this.dgvDados.TabIndex = 29;
            this.dgvDados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSorvetes_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 249);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(12, 208);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 23);
            this.btnEditar.TabIndex = 27;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(12, 168);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(100, 23);
            this.btnCadastrar.TabIndex = 26;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txty03
            // 
            this.txty03.Location = new System.Drawing.Point(12, 103);
            this.txty03.Name = "txty03";
            this.txty03.Size = new System.Drawing.Size(100, 20);
            this.txty03.TabIndex = 25;
            // 
            // txtylms
            // 
            this.txtylms.Location = new System.Drawing.Point(12, 62);
            this.txtylms.Name = "txtylms";
            this.txtylms.Size = new System.Drawing.Size(100, 20);
            this.txtylms.TabIndex = 24;
            // 
            // lbly03
            // 
            this.lbly03.AutoSize = true;
            this.lbly03.Location = new System.Drawing.Point(9, 87);
            this.lbly03.Name = "lbly03";
            this.lbly03.Size = new System.Drawing.Size(24, 13);
            this.lbly03.TabIndex = 23;
            this.lbly03.Text = "y03";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(9, 46);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(27, 13);
            this.lbl.TabIndex = 22;
            this.lbl.Text = "ylms";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem,
            this.dadosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(492, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // dadosToolStripMenuItem
            // 
            this.dadosToolStripMenuItem.Name = "dadosToolStripMenuItem";
            this.dadosToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.dadosToolStripMenuItem.Text = "Dados";
            // 
            // FrmDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 289);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txts25);
            this.Controls.Add(this.s25);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txty03);
            this.Controls.Add(this.txtylms);
            this.Controls.Add(this.lbly03);
            this.Controls.Add(this.lbl);
            this.Name = "FrmDados";
            this.Text = "FrmDados";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txts25;
        private System.Windows.Forms.Label s25;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txty03;
        private System.Windows.Forms.TextBox txtylms;
        private System.Windows.Forms.Label lbly03;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dadosToolStripMenuItem;
    }
}