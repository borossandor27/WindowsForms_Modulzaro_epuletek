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
            if (listBox_Epuletek.SelectedItem.GetType() == typeof(Csaladihaz))
            {
                Csaladihaz kiv = (Csaladihaz)listBox_Epuletek.SelectedItem;
                textBox_Epulet_cime.Text = kiv.Cim;
                textBox_BecsultAr.Text = kiv.arBecsles().ToString("#,##0");
            }
            else
            {
                Tombhaz kiv = (Tombhaz)listBox_Epuletek.SelectedItem;
                textBox_Epulet_cime.Text = kiv.Cim;
                textBox_BecsultAr.Text = kiv.arBecsles().ToString("#,##0");
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

        private void Form_Nyito_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult valasztas = MessageBox.Show("Valóban ki akar lépni?", "A lista tartalma fájlba íródik!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (DialogResult.Yes == valasztas) 
            {
                csv_fajlba_irja_a_listat();
                //Application.Exit();
            }
            else if(DialogResult.No == valasztas)
            {
                e.Cancel = true;
            }
        }

        private void csv_fajlba_irja_a_listat()
        {
            using (StreamWriter sw = new StreamWriter("epuletek.csv"))
            {
                foreach (var item in listBox_Epuletek.Items)
                {
                    if (item.GetType() == typeof(Csaladihaz))
                    {
                        sw.WriteLine(((Csaladihaz)item).toCSV());
                    }
                    else
                    {
                        sw.WriteLine(((Tombhaz)item).toCSV());
                    }
                }
            }
        }
    }
}
