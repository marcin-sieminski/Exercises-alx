using P04PlayersManager.Domain;
using P04PlayersManager.Repository;
using System;
using System.Windows.Forms;

namespace P04PlayersManager
{
    public partial class FrmPlayers : Form
    {
        public FrmPlayers()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            PlayersRepo playersRepo = new PlayersRepo();

            Filter filter = new Filter();
            filter.Imie = txtImie.Text;
            filter.Nazwisko = txtNazwisko.Text;
            filter.Kraj = txtKraj.Text;
            if (string.IsNullOrWhiteSpace(txtWzrostOd.Text))
            {
                filter.WzrostOd = null;
            }
            else
            {
                filter.WzrostOd = Convert.ToInt32(txtWzrostOd.Text);
            }

            if (string.IsNullOrWhiteSpace(txtWzrostDo.Text))
            {
                filter.WzrostDo = null;
            }
            else
            {
                filter.WzrostDo = Convert.ToInt32(txtWzrostDo.Text);
            }

            if (string.IsNullOrWhiteSpace(txtWagaOd.Text))
            {
                filter.WagaOd = null;
            }
            else
            {
                filter.WagaOd = Convert.ToInt32(txtWagaOd.Text);
            }

            if (string.IsNullOrWhiteSpace(txtWagaDo.Text))
            {
                filter.WagaDo = null;
            }
            else
            {
                filter.WagaDo = Convert.ToInt32(txtWagaDo.Text);
            }

            if (checkBoxDataOd.Checked)
            {
                filter.DataUrOd = datDataUrOd.Value;
            }
            else
            {
                filter.DataUrOd = null;
            }

            if (checkBoxDataDo.Checked)
            {
                filter.DataUrDo = datDataUrDo.Value;
            }
            else
            {
                filter.DataUrDo = null;
            }

            lsbPlayers.DataSource = playersRepo.GetPlayers(filter);
            lsbPlayers.DisplayMember = "ImieNazwiskoKraj";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Player player = new Player
            {
                Imie = txtImieNew.Text,
                Nazwisko = txtNazwiskoNew.Text,
                Kraj = txtKrajNew.Text,
                DataUr = dateTimePicker2.Value,
                Wzrost = Convert.ToInt32(txtWzrostNew.Text),
                Waga = Convert.ToInt32(txtWagaNew.Text)
            };

            PlayersRepo playersRepo = new PlayersRepo();
            playersRepo.AddPlayer(player);
            RefreshData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Czy napewno usunąć zaznaczony rekord?", "Pytanie", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                PlayersRepo playersRepo = new PlayersRepo();
                var player = (Player) lsbPlayers.SelectedItem;
                playersRepo.DeletePlayer(player.Id);
            }
            RefreshData();
        }

        private void lsbPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var playerSelected = (Player)lsbPlayers.SelectedItem;
            txtImieNew.Text = playerSelected.Imie;
            txtNazwiskoNew.Text = playerSelected.Nazwisko;
            txtKrajNew.Text = playerSelected.Kraj;
            dateTimePicker2.Value = playerSelected.DataUr;
            txtWzrostNew.Text = playerSelected.Wzrost.ToString();
            txtWagaNew.Text = playerSelected.Waga.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Player player = new Player
            {
                Id = ((Player)lsbPlayers.SelectedItem).Id,
                Imie = txtImieNew.Text,
                Nazwisko = txtNazwiskoNew.Text,
                Kraj = txtKrajNew.Text,
                DataUr = dateTimePicker2.Value,
                Wzrost = Convert.ToInt32(txtWzrostNew.Text),
                Waga = Convert.ToInt32(txtWagaNew.Text)
            };

            PlayersRepo playersRepo = new PlayersRepo();
            playersRepo.EditPlayer(player);
            RefreshData();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtImieNew.Text = string.Empty;
            txtNazwiskoNew.Text = string.Empty;
            txtKrajNew.Text = string.Empty;
            dateTimePicker2.Value = Convert.ToDateTime("01/01/1950 00:00:00");
            txtWzrostNew.Text = string.Empty;
            txtWagaNew.Text = string.Empty;
        }
    }
}
