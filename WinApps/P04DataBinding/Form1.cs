using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P04DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            PlayerHelper playerHelper = new PlayerHelper(DataSource.LocalFile);
            playerHelper.LoadData();

            lbData.DataSource = playerHelper.Players;
            lbData.DisplayMember = "FullName";
        }
    }
}
