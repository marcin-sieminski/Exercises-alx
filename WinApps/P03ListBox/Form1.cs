using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P03ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            lbData.Items.Clear();
            PlayerHelper ph = new PlayerHelper(DataSource.LocalFile);
            ph.LoadData();
            foreach (var player in ph.Players)
            {
                lbData.Items.Add(player.GetInfo());
            }
        }
    }
}
