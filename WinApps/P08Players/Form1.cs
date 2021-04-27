using System;
using System.Windows.Forms;

namespace P08Players
{
    public partial class Form1 : Form
    {
        ManagerDanych md = new ManagerDanych();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            md.ImportujZawodnikow();
            lbDane.DataSource = md.Zawodnicy;
            lbDane.DisplayMember = "ImieNazwiskoKraj";
        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Zawodnik zaznaczonyZawodnik = (Zawodnik)lbDane.SelectedItem;
            md.UsunZawodnika(zaznaczonyZawodnik.IdZawodnika);
            md.EksportujZawodników();
            lbDane.DataSource = md.Zawodnicy;
            lbDane.DisplayMember = "ImieNazwiskoKraj";
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Zawodnik z = new Zawodnik()
            {
                Imie = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                Kraj = txtKraj.Text,
                DataUrodzenia = datDataUrodzenia.Value,
                Waga = Convert.ToInt32(txtWaga.Text),
                Wzrost = Convert.ToInt32(txtWzrost.Text)
            };
            md.DodajZawodnika(z);
            md.EksportujZawodników();
            lbDane.DataSource = md.Zawodnicy;
            lbDane.DisplayMember = "ImieNazwiskoKraj";
        }

        private void btnEdytuj_Click(object sender, EventArgs e)
        {
            var zaznaczony = (Zawodnik)lbDane.SelectedItem;
            var z = new Zawodnik()
            {
                Imie = txtImie.Text,
                Nazwisko = txtNazwisko.Text,
                DataUrodzenia = datDataUrodzenia.Value,
                IdZawodnika = zaznaczony.IdZawodnika,
                Kraj = txtKraj.Text,
                Waga = Convert.ToInt32(txtWaga.Text),
                Wzrost = Convert.ToInt32(txtWzrost.Text)
            };
            md.EdytujZawodnika(z);
            md.EksportujZawodników();
            md.ImportujWszystko();
            lbDane.DataSource = md.Zawodnicy;
            lbDane.DisplayMember = "ImieNazwiskoKraj";
        }

        private void lbDane_SelectedIndexChanged(object sender, EventArgs e)
        {
            Zawodnik zaznaczonyZawodnik = (Zawodnik)lbDane.SelectedItem;

            txtImie.Text = zaznaczonyZawodnik.Imie;
            txtNazwisko.Text = zaznaczonyZawodnik.Nazwisko;
            txtKraj.Text = zaznaczonyZawodnik.Kraj;
            txtWaga.Text = zaznaczonyZawodnik.Waga.ToString();
            txtWzrost.Text = zaznaczonyZawodnik.Wzrost.ToString();
            datDataUrodzenia.Value = zaznaczonyZawodnik.DataUrodzenia;
        }

        private void btnWyczysc_Click(object sender, EventArgs e)
        {
        }

        private void btnWczytajTrenerzy_Click(object sender, EventArgs e)
        {
            md.ImportujTrenerow();
            lbTrenerzy.DataSource = md.Trenerzy;
            lbTrenerzy.DisplayMember = "ImieNazwisko";
        }

        private void lbTrenerzy_SelectedIndexChanged(object sender, EventArgs e)
        {
            Trener t = (Trener) lbTrenerzy.SelectedItem;
            tbImieTrener.Text = t.Imie;
            tbNazwiskoTrener.Text = t.Nazwisko;
            dateDataUrTrener.Value = t.DataUrodzenia;
        }

        private void btnDodajTrener_Click(object sender, EventArgs e)
        {
            Trener t = new Trener()
            {
                Imie = tbImieTrener.Text,
                Nazwisko = tbNazwiskoTrener.Text,
                DataUrodzenia = dateDataUrTrener.Value,
            };
            md.DodajTrenera(t);
            md.EksportujTrenerow();
            lbTrenerzy.DataSource = md.Trenerzy;
            lbTrenerzy.DisplayMember = "ImieNazwisko";
        }

        private void btn_EdytujTrener_Click(object sender, EventArgs e)
        {
            var zaznaczony = (Trener)lbTrenerzy.SelectedItem;
            var item = new Trener()
            {
                Imie = tbImieTrener.Text,
                Nazwisko = tbNazwiskoTrener.Text,
                DataUrodzenia = dateDataUrTrener.Value,
                IdTrenera = zaznaczony.IdTrenera
            };
            md.EdytujTrenera(item);
            md.EksportujTrenerow();
            md.ImportujTrenerow();
            lbTrenerzy.DataSource = md.Trenerzy;
            lbTrenerzy.DisplayMember = "ImieNazwisko";
        }

        private void btnUsunTrener_Click(object sender, EventArgs e)
        {
            var t = (Trener)lbTrenerzy.SelectedItem;
            md.UsunTrenera(t.IdTrenera);
            md.EksportujTrenerow();
            lbTrenerzy.DataSource = md.Trenerzy;
            lbTrenerzy.DisplayMember = "ImieNazwisko";
        }
    }
}
