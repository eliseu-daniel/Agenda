using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Agenda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdiocionar_Click(object sender, EventArgs e)
        {
            if ((txtNome.Text != "") && (txtTelefone.Text != "") && (cmbSexo.Text != ""))
            {
                if (MessageBox.Show(
                    "Deseja adicionar na lista?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstAgenda.Items.Add(txtNome.Text + "|" + txtTelefone.Text + "|" + cmbSexo.Text);
                    //limpa os campos do formulário
                    txtNome.Clear();
                    txtTelefone.Clear();
                    cmbSexo.Text = "";

                    txtNome.Focus();
                }
                else
                {
                    MessageBox.Show(
                    "Ação cancelada pelo usuário.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(
                    "Preencha todos os campos!",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            if (btnRestaurar.Text == "Restaurar")
            {
                string itemSelecionado = lstAgenda.SelectedItem.ToString();
                string[] campos = itemSelecionado.Split("|");

                if (lstAgenda.SelectedIndex >= 0)
                {
                    txtNome.Text = campos[0];
                    txtTelefone.Text = campos[1];
                    cmbSexo.Text = campos[2];
                    btnRestaurar.Text = "Salvar";
                }
            }
            else
            {
                lstAgenda.Items.Insert(
                    lstAgenda.SelectedIndex,

                    txtNome.Text + "|" +
                    txtTelefone.Text + "|" +
                    cmbSexo.Text);

                lstAgenda.Items.RemoveAt(lstAgenda.SelectedIndex);

                btnNovo.PerformClick();

                btnRestaurar.Text = "Restaurar";
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Deseja limpar todos os campos?",
                "Informação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtNome.Clear();
                txtTelefone.Clear();
                cmbSexo.Text = "";

                txtNome.Focus();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (lstAgenda.SelectedIndex >= 0)
            {
                if (MessageBox.Show(
                    "Deseja realmente EXCLUIR esse registro?",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    lstAgenda.Items.RemoveAt(lstAgenda.SelectedIndex);
                }
            }
            else
            {
                MessageBox.Show(
                    "Selecione um registro da lista.",
                    "Informação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            FileInfo salvarArquivo = new FileInfo(@".\bk_agenda.txt");

            if (!salvarArquivo.Exists)
            {
                using (StreamWriter sa = salvarArquivo.CreateText())
                {
                    for (int i = 0; i < lstAgenda.Items.Count; i++)
                    {
                        sa.WriteLine(lstAgenda.Items[i].ToString());
                    }
                }

                MessageBox.Show(
                        "Backup realizado com sucesso!",
                        "Informação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
            }
            else
            {
                if (MessageBox.Show(
                            "Há um backup anterior, deseja apagar?",
                            "Infcrmação",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (StreamWriter sa = salvarArquivo.CreateText())
                    {
                        for (int i = 0; i < lstAgenda.Items.Count; i++)
                        {
                            sa.WriteLine(lstAgenda.Items[i].ToString());
                        }
                    }

                    MessageBox.Show(
                            "Backup realizado com sucesso!",
                            "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                }
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            FileInfo abrirArquivo = new FileInfo(@".\bk_agenda.txt");

            if (abrirArquivo.Exists)
            {
                using (StreamReader aa = abrirArquivo.OpenText())
                {
                    lstAgenda.Items.Clear();

                    string linha = null;
                    while ((linha = aa.ReadLine()) != null)
                    {
                        lstAgenda.Items.Add(linha);
                    }
                }
                MessageBox.Show(
                            "Importação realizada com sucesso!",
                            "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                            "O arquivo de backup não existe!",
                            "Informação",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                    "Deseja limpar todos os contatos",
                    "Informação",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lstAgenda.Items.Clear();
            }
        }
    }
}
