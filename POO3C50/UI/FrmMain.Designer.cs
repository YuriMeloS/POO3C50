namespace POO3C50
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_idM = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_idG = new System.Windows.Forms.TextBox();
            this.txt_idCD = new System.Windows.Forms.TextBox();
            this.txt_Nmusica = new System.Windows.Forms.TextBox();
            this.txt_nAutor = new System.Windows.Forms.TextBox();
            this.gridM = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gridG = new System.Windows.Forms.DataGridView();
            this.gridC = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_idM
            // 
            this.txt_idM.Enabled = false;
            this.txt_idM.Location = new System.Drawing.Point(12, 28);
            this.txt_idM.Name = "txt_idM";
            this.txt_idM.Size = new System.Drawing.Size(37, 20);
            this.txt_idM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID M";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID CD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome da Música";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Autor da Música";
            // 
            // txt_idG
            // 
            this.txt_idG.Location = new System.Drawing.Point(87, 28);
            this.txt_idG.Name = "txt_idG";
            this.txt_idG.Size = new System.Drawing.Size(37, 20);
            this.txt_idG.TabIndex = 10;
            // 
            // txt_idCD
            // 
            this.txt_idCD.Location = new System.Drawing.Point(162, 28);
            this.txt_idCD.Name = "txt_idCD";
            this.txt_idCD.Size = new System.Drawing.Size(37, 20);
            this.txt_idCD.TabIndex = 11;
            // 
            // txt_Nmusica
            // 
            this.txt_Nmusica.Location = new System.Drawing.Point(12, 71);
            this.txt_Nmusica.Name = "txt_Nmusica";
            this.txt_Nmusica.Size = new System.Drawing.Size(187, 20);
            this.txt_Nmusica.TabIndex = 12;
            // 
            // txt_nAutor
            // 
            this.txt_nAutor.Location = new System.Drawing.Point(12, 110);
            this.txt_nAutor.Name = "txt_nAutor";
            this.txt_nAutor.Size = new System.Drawing.Size(187, 20);
            this.txt_nAutor.TabIndex = 13;
            // 
            // gridM
            // 
            this.gridM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridM.Location = new System.Drawing.Point(206, 12);
            this.gridM.Name = "gridM";
            this.gridM.Size = new System.Drawing.Size(351, 177);
            this.gridM.TabIndex = 14;
            this.gridM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridM_CellContentClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(12, 137);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(91, 52);
            this.btnInserir.TabIndex = 15;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(108, 137);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 52);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(12, 195);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 52);
            this.btnExcluir.TabIndex = 17;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(108, 195);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(91, 52);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // gridG
            // 
            this.gridG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridG.Location = new System.Drawing.Point(15, 263);
            this.gridG.Name = "gridG";
            this.gridG.Size = new System.Drawing.Size(187, 104);
            this.gridG.TabIndex = 19;
            // 
            // gridC
            // 
            this.gridC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridC.Location = new System.Drawing.Point(209, 211);
            this.gridC.Name = "gridC";
            this.gridC.Size = new System.Drawing.Size(348, 156);
            this.gridC.TabIndex = 20;
            this.gridC.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Gravadoras";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "CDS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(365, -1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Músicas";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 379);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridC);
            this.Controls.Add(this.gridG);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.gridM);
            this.Controls.Add(this.txt_nAutor);
            this.Controls.Add(this.txt_Nmusica);
            this.Controls.Add(this.txt_idCD);
            this.Controls.Add(this.txt_idG);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_idM);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmMain";
            this.Text = "Musica";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_idM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_idG;
        private System.Windows.Forms.TextBox txt_idCD;
        private System.Windows.Forms.TextBox txt_Nmusica;
        private System.Windows.Forms.TextBox txt_nAutor;
        private System.Windows.Forms.DataGridView gridM;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridView gridG;
        private System.Windows.Forms.DataGridView gridC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

