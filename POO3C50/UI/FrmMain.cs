using System;
using POO3C50.BLL;
using POO3C50.DTO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO3C50
{    
    public partial class FrmMain : Form
    {
        tblMusicaBLL bllMusicas = new tblMusicaBLL();
        TblMusicasDTO dtoMusicas = new TblMusicasDTO();
        tblGravadoraBLL bllGravadoras = new tblGravadoraBLL();
        TblGravadoraDTO dtoGravadoras = new TblGravadoraDTO();
        tblCDBLL bllCD = new tblCDBLL();
        TblCDDTO dtoCD = new TblCDDTO();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridM.DataSource = bllMusicas.ListarTodasAsMusicas();
            gridG.DataSource = bllGravadoras.ListarTodasAsGravadoras();
            gridC.DataSource = bllCD.ListarTodosOsCd();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void gridM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_idM.Text = gridM.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nAutor.Text = gridM.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_Nmusica.Text = gridM.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_idCD.Text = gridM.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_idG.Text = gridM.Rows[e.RowIndex].Cells[4].Value.ToString();   
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                dtoMusicas.Nome = txt_Nmusica.Text.ToString();
                dtoMusicas.NomeAutor = txt_nAutor.Text.ToString();
                dtoMusicas.IdGravadora = int.Parse(txt_idG.Text);
                dtoMusicas.IdCD = int.Parse(txt_idCD.Text);

                bllMusicas.InserirMusica(dtoMusicas);
                MessageBox.Show("Música inserida com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridM.DataSource = bllMusicas.ListarTodasAsMusicas();                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Está ação irá deletar a música selecionada e não poderá ser desfeito! deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    dtoMusicas.IdMusica = Convert.ToInt32(txt_idM.Text);
                    bllMusicas.ExcluirMusica(dtoMusicas);
                    gridM.DataSource = bllMusicas.ListarTodasAsMusicas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                dtoMusicas.IdMusica = int.Parse(txt_idM.Text);
                dtoMusicas.Nome = txt_Nmusica.Text.ToString();
                dtoMusicas.NomeAutor = txt_nAutor.Text.ToString();
                dtoMusicas.IdGravadora = int.Parse(txt_idG.Text);
                dtoMusicas.IdCD = int.Parse(txt_idCD.Text);

                bllMusicas.AlterarMusica(dtoMusicas);
                MessageBox.Show("Alteração Feita com Sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                gridM.DataSource = bllMusicas.ListarTodasAsMusicas();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
