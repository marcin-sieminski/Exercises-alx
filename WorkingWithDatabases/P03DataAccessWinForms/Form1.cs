using System;
using System.Windows.Forms;

namespace P03DataAccessWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            var connection = new DatabaseConnection();

            object[][] data = null;

            try
            {
                data = connection.ExecuteSqlCommand(tbSql.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show("Błąd bazy danych", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (data != null)
            {
                dataGridView.Rows.Clear();
                dataGridView.ColumnCount = data[0].Length;
                for (int i = 0; i < data.Length; i++)
                {
                    dataGridView.Rows.Add(data[i]);
                }
            }
        }

        private void tbServer_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
