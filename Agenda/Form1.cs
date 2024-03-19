namespace Agenda
{
    public partial class FrmAgenda : Form
    {
        List<string> AgendaList = new List<string>();
        public FrmAgenda()
        {
            InitializeComponent();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            AgendaList.Add(txtNome.Text);
            AgendaList.Add(txtFone.Text);
            AgendaList.Add(cmbSexo.Text);
            ListBox.DataSource = null;
            ListBox.DataSource = AgendaList;
            txtNome.Text =
            txtFone.Text =
            cmbSexo.Text = string.Empty;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            AgendaList.RemoveAt(ListBox.SelectedIndex);
            ListBox.DataSource = null;
            ListBox.DataSource = AgendaList;
            txtNome.Text =
            txtFone.Text =
            cmbSexo.Text = string.Empty;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            txtNome.Text = AgendaList[ListBox.SelectedIndex];
            txtFone.Text = AgendaList[ListBox.SelectedIndex];
            cmbSexo.Text = AgendaList[ListBox.SelectedIndex];
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            AgendaList.Clear();
            ListBox.DataSource = null;
            ListBox.DataSource = AgendaList;
        }
    }
}
