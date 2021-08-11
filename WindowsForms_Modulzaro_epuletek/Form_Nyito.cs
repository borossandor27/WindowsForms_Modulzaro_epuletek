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
                textBox_BecsultAr.Text = kiv.arBecsles().ToString("#,##0 Ft");
                groupBox_Epulet_adat.Text = $"A kiválasztott családiház adatai";
                textBox_alapterulet.Text = $"{kiv.Alapterulet.ToString()} nm";
            }
            else
            {
                Tombhaz kiv = (Tombhaz)listBox_Epuletek.SelectedItem;
                textBox_Epulet_cime.Text = kiv.Cim;
                textBox_BecsultAr.Text = kiv.arBecsles().ToString("#,##0 Ft");
                groupBox_Epulet_adat.Text = $"A kiválasztott tömbház adatai";
                textBox_alapterulet.Text = $"{kiv.Alapterulet.ToString()} nm";
            }
        }

        private void újCsaládiházToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Csaladihaz ujCsaladi = new Form_Csaladihaz("new");
            ujCsaladi.ShowDialog();
        }

        private void újTömbházToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Tombhaz ujTombhaz = new Form_Tombhaz();
            ujTombhaz.ShowDialog();
        }

        private void Form_Nyito_Load(object sender, EventArgs e)
        {
            //-- epuletek csv betöltése
            try
            {
                using (StreamReader sr = new StreamReader("epuletek.csv"))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] sor = sr.ReadLine().Split(';');
                        if (sor[0].Equals("Családiház"))
                        {
                            EpuletTipus epuletTipus;
                            Enum.TryParse<EpuletTipus>(sor[0], out epuletTipus);
                            EpitesiAnyag epitesiAnyag;
                            Enum.TryParse<EpitesiAnyag>(sor[3], out epitesiAnyag);
                            TetoTipusa tetoTipusa;
                            Enum.TryParse<TetoTipusa>(sor[9], out tetoTipusa);
                            DateTime munkaKezd = DateTime.Parse(sor[4]);
                            DateTime munkaVege = DateTime.Parse(sor[5]);
                            Csaladihaz uj = new Csaladihaz(epuletTipus, sor[1], (int)epitesiAnyag, munkaKezd, munkaVege, int.Parse(sor[6]), int.Parse(sor[7]), bool.Parse(sor[8]), tetoTipusa);
                            listBox_Epuletek.Items.Add(uj);
                            if (uj.MunkaVege.Date==DateTime.Now.Date)
                            {
                                listBox_Esedekes_befejezes.Items.Add(uj);
                            }
                        }
                        else
                        {
                            EpuletTipus epuletTipus;
                            Enum.TryParse<EpuletTipus>(sor[0], out epuletTipus);
                            EpitesiAnyag epitesiAnyag;
                            Enum.TryParse<EpitesiAnyag>(sor[3], out epitesiAnyag);
                            LakasfenntartasTipus lakasfenntartasTipus;
                            Enum.TryParse<LakasfenntartasTipus>(sor[9], out lakasfenntartasTipus);
                            Tombhaz uj = new Tombhaz(epuletTipus, sor[1], (int)epitesiAnyag, DateTime.Parse(sor[4]), DateTime.Parse(sor[5]), int.Parse(sor[6]), int.Parse(sor[7]), bool.Parse(sor[8]), (int)lakasfenntartasTipus);
                            listBox_Epuletek.Items.Add(uj);
                        }
                    }
                }
            }
            catch (FileNotFoundException ex)
            {
                MessageBox.Show("Az 'epuletek.csv' fájl nem elérhető!");
            }
            
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

        private void törlésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex < 0)
            {
                return;
            }
            DialogResult valasz = MessageBox.Show($"Valóban törölni akarja a kijelölt {(listBox_Epuletek.SelectedItem.GetType() == typeof(Csaladihaz) ? "családi házat" : "tömb házat")}", "Nem viszavonható!", MessageBoxButtons.YesNo);
            if (valasz == DialogResult.Yes)
            {
                //-- Törölni a kijelölt elemet
                listBox_Epuletek.Items.RemoveAt(listBox_Epuletek.SelectedIndex);
            }
        }

        private void módosításToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox_Epuletek.SelectedIndex < 0)
            {
                MessageBox.Show("Nincs kijelölt épület!");
                return;
            }
            if (listBox_Epuletek.SelectedItem.GetType() == typeof(Csaladihaz))
            {
                Form_Csaladihaz csaladi_update = new Form_Csaladihaz("update");
                csaladi_update.Show();
            }
        }

        private void listBox_Epuletek_DoubleClick(object sender, EventArgs e)
        {
            Epulet kiv = (Epulet)listBox_Epuletek.SelectedItem;
            string s = kiv.Cim + Environment.NewLine;
            s += $"{kiv.epuletTipus.ToString()}" + Environment.NewLine;
            s += $"Alapterület: \t\t{kiv.Alapterulet.ToString("#,##0")} nm" + Environment.NewLine;
            s += $"Építési anyag: \t\t{kiv.Epitesianyag.ToString()}" + Environment.NewLine;
            s += $"Munkavégzés kezdete: \t{kiv.MunkaKezdete.ToString("yyyy.MM.dd")}" + Environment.NewLine;
            s += $"Munkavégzés vége: \t{kiv.MunkaVege.ToString("yyyy.MM.dd")}";
            MessageBox.Show(s);
        }

        private void listBox_Esedekes_befejezes_DoubleClick(object sender, EventArgs e)
        {
            Epulet kiv = (Epulet)listBox_Esedekes_befejezes.SelectedItem;
            string s = kiv.Cim + Environment.NewLine;
            s += $"{kiv.epuletTipus.ToString()}" + Environment.NewLine;
            s += $"Alapterület: \t\t{kiv.Alapterulet.ToString("#,##0")} nm" + Environment.NewLine;
            s += $"Építési anyag: \t\t{kiv.Epitesianyag.ToString()}" + Environment.NewLine;
            s += $"Munkavégzés kezdete: \t{kiv.MunkaKezdete.ToString("yyyy.MM.dd")}" + Environment.NewLine;
            s += $"Munkavégzés vége: \t{kiv.MunkaVege.ToString("yyyy.MM.dd")}";
            MessageBox.Show(s);
        }
    }
}
