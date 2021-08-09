using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Modulzaro_epuletek
{
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void listBox_Epuletek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex<0)
            {
                return;
            }
        }

        private void újCsaládiházToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Csaladihaz ujCsaladi = new Form_Csaladihaz();
            ujCsaladi.ShowDialog();
        }

        private void újTömbházToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tombhaz ujTombhaz = new Form_Tombhaz();
            ujTombhaz.ShowDialog();
        }

        private void Form_Nyito_Load(object sender, EventArgs e)
        {
 
            
        }
    }
}
