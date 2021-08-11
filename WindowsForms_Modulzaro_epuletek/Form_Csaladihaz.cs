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
    public partial class Form_Csaladihaz : Form
    {
        string muvelet;
        Csaladihaz kivalasztott = null;
        int index;
        public Form_Csaladihaz(string mod)
        {
            InitializeComponent();
            muvelet = mod;
        }

        private void button_Listaba_rakja_a_csaladihazat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty( textBox_Cim.Text))
            {
                return;
            }
            if (numericUpDown_Alapterulet.Value<20)
            {
                return;
            }
            if (comboBox_Epitesi_anyag.SelectedIndex<0)
            {
                return;
            }
            Csaladihaz uj = new Csaladihaz(EpuletTipus.Családiház, textBox_Cim.Text, comboBox_Epitesi_anyag.SelectedIndex, dateTimePicker_Munka_kezdete.Value, dateTimePicker_Munka_vege.Value, (int)numericUpDown_Alapterulet.Value, (int)numericUpDown_Ottelok_szama.Value, checkBox_Garazs.Checked, (TetoTipusa)comboBox_Teto_tipusa.SelectedIndex);
            switch (muvelet)
            {
                case "new":
                    Program.form_Nyito.listBox_Epuletek.Items.Add(uj);
                    break;
                case "update":
                    Program.form_Nyito.listBox_Epuletek.Items.RemoveAt(index);
                    Program.form_Nyito.listBox_Epuletek.Items.Insert(index, uj);
                    break;
                default:
                    break;
            }
            textBox_Cim.Text = "";
            numericUpDown_Alapterulet.Value = 20;
            comboBox_Epitesi_anyag.SelectedIndex = -1;
            dateTimePicker_Munka_kezdete.Value = DateTime.Now;
            dateTimePicker_Munka_vege.Value = DateTime.Now;
            numericUpDown_Ottelok_szama.Value = 1;
            checkBox_Garazs.Checked = false;
            comboBox_Teto_tipusa.SelectedIndex = -1;

        }

        private void Form_Csaladihaz_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(EpitesiAnyag)))
            {
                comboBox_Epitesi_anyag.Items.Add((EpitesiAnyag)item);
            }
            foreach (var item in Enum.GetValues(typeof(TetoTipusa)))
            {
                comboBox_Teto_tipusa.Items.Add((TetoTipusa)item);
            }
            switch (muvelet)
            {
                case "new":
                    break;
                case "update":
                    kivalsztottat_betolt();
                    this.Text = "Adatok módosítása";
                    button_Listaba_rakja_a_csaladihazat.Text = "Módosítás a listában";
                    break;
                default:
                    break;
            }
        }

        private void kivalsztottat_betolt()
        {
            kivalasztott = (Csaladihaz)Program.form_Nyito.listBox_Epuletek.SelectedItem;
            index = Program.form_Nyito.listBox_Epuletek.SelectedIndex;
            textBox_Cim.Text = kivalasztott.Cim;
            numericUpDown_Alapterulet.Value = kivalasztott.Alapterulet;
            comboBox_Epitesi_anyag.SelectedIndex = (int)kivalasztott.Epitesianyag;
            dateTimePicker_Munka_kezdete.Value = kivalasztott.MunkaKezdete;
            dateTimePicker_Munka_vege.Value = kivalasztott.MunkaVege;
            numericUpDown_Ottelok_szama.Value = kivalasztott.Ottelok;
            checkBox_Garazs.Checked = kivalasztott.VanGarazs;
            comboBox_Teto_tipusa.SelectedIndex = (int)kivalasztott.TetoTipusa;
        }
    }
}
