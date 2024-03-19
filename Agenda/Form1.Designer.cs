namespace Agenda
{
    partial class FrmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblAgenda = new Label();
            btnMinimizar = new Button();
            button1 = new Button();
            lblNome = new Label();
            txtNome = new TextBox();
            lblFone = new Label();
            txtFone = new TextBox();
            lblSexo = new Label();
            cmbSexo = new ComboBox();
            ListBox = new ListBox();
            btnAdicionar = new Button();
            btnLimpar = new Button();
            btnImportar = new Button();
            btnExportar = new Button();
            btnExcluir = new Button();
            btnNovo = new Button();
            btnRestaurar = new Button();
            SuspendLayout();
            // 
            // lblAgenda
            // 
            lblAgenda.BackColor = SystemColors.ControlDarkDark;
            lblAgenda.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgenda.ForeColor = Color.White;
            lblAgenda.Location = new Point(12, -3);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(659, 98);
            lblAgenda.TabIndex = 0;
            lblAgenda.Text = "Agenda";
            lblAgenda.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = SystemColors.Control;
            btnMinimizar.Location = new Point(22, 66);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(75, 23);
            btnMinimizar.TabIndex = 1;
            btnMinimizar.Text = "Minimizar";
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Control;
            button1.Location = new Point(103, 66);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Fechar";
            button1.UseVisualStyleBackColor = false;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNome.Location = new Point(12, 110);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(57, 21);
            lblNome.TabIndex = 3;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 134);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(292, 23);
            txtNome.TabIndex = 4;
            // 
            // lblFone
            // 
            lblFone.AutoSize = true;
            lblFone.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFone.Location = new Point(12, 175);
            lblFone.Name = "lblFone";
            lblFone.Size = new Size(47, 21);
            lblFone.TabIndex = 5;
            lblFone.Text = "Fone";
            // 
            // txtFone
            // 
            txtFone.Location = new Point(12, 199);
            txtFone.Name = "txtFone";
            txtFone.Size = new Size(292, 23);
            txtFone.TabIndex = 6;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSexo.Location = new Point(12, 235);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(47, 21);
            lblSexo.TabIndex = 7;
            lblSexo.Text = "Sexo";
            // 
            // cmbSexo
            // 
            cmbSexo.FormattingEnabled = true;
            cmbSexo.Items.AddRange(new object[] { "Masculino", "Feminino", "Não Listado" });
            cmbSexo.Location = new Point(12, 259);
            cmbSexo.Name = "cmbSexo";
            cmbSexo.Size = new Size(292, 23);
            cmbSexo.TabIndex = 8;
            // 
            // ListBox
            // 
            ListBox.FormattingEnabled = true;
            ListBox.ItemHeight = 15;
            ListBox.Location = new Point(321, 134);
            ListBox.Name = "ListBox";
            ListBox.Size = new Size(290, 199);
            ListBox.TabIndex = 9;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(12, 296);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(148, 37);
            btnAdicionar.TabIndex = 10;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(536, 339);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(86, 37);
            btnLimpar.TabIndex = 11;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(321, 340);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(102, 37);
            btnImportar.TabIndex = 12;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(429, 339);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(101, 37);
            btnExportar.TabIndex = 13;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(166, 340);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(138, 36);
            btnExcluir.TabIndex = 14;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(12, 340);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(148, 36);
            btnNovo.TabIndex = 15;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Location = new Point(166, 297);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(138, 36);
            btnRestaurar.TabIndex = 16;
            btnRestaurar.Text = "Restaurar";
            btnRestaurar.UseVisualStyleBackColor = true;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // FrmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(672, 419);
            Controls.Add(btnRestaurar);
            Controls.Add(btnNovo);
            Controls.Add(btnExcluir);
            Controls.Add(btnExportar);
            Controls.Add(btnImportar);
            Controls.Add(btnLimpar);
            Controls.Add(btnAdicionar);
            Controls.Add(ListBox);
            Controls.Add(cmbSexo);
            Controls.Add(lblSexo);
            Controls.Add(txtFone);
            Controls.Add(lblFone);
            Controls.Add(txtNome);
            Controls.Add(lblNome);
            Controls.Add(button1);
            Controls.Add(btnMinimizar);
            Controls.Add(lblAgenda);
            Name = "FrmAgenda";
            Text = "Agenda";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgenda;
        private Button btnMinimizar;
        private Button button1;
        private Label lblNome;
        private TextBox txtNome;
        private Label lblFone;
        private TextBox txtFone;
        private Label lblSexo;
        private ComboBox cmbSexo;
        private ListBox ListBox;
        private Button btnAdicionar;
        private Button btnLimpar;
        private Button btnImportar;
        private Button btnExportar;
        private Button btnExcluir;
        private Button btnNovo;
        private Button btnRestaurar;
    }
}
