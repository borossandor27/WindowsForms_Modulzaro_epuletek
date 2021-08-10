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
    public partial class Form_Tombhaz : Form
    {
        public Form_Tombhaz()
        {
            InitializeComponent();
        }

        private void Form_Tombhaz_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(EpitesiAnyag)))
            {
                comboBox_Epitesi_anyag.Items.Add((EpitesiAnyag)item);
            }
            foreach (var item in Enum.GetValues(typeof(LakasfenntartasTipus)))
            {
                comboBox_Lakasfenntartas_tipusa.Items.Add((LakasfenntartasTipus)item);
            }
        }

        private void button_Listaba_rakja_a_tombhazat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox_Cim.Text))
            {
                return;
            }
            if (numericUpDown_Alapterulet.Value < 20)
            {
                return;
            }
            if (comboBox_Epitesi_anyag.SelectedIndex < 0)
            {
                return;
            }
            Tombhaz uj = new Tombhaz(EpuletTipus.Tömbház, textBox_Cim.Text, comboBox_Epitesi_anyag.SelectedIndex, dateTimePicker_Munka_kezdete.Value, dateTimePicker_Munka_vege.Value, (int)numericUpDown_Alapterulet.Value, (int)numericUpDown_Lakasok_szama.Value, checkBox_Lift.Checked, comboBox_Lakasfenntartas_tipusa.SelectedIndex);
            Program.form_Nyito.listBox_Epuletek.Items.Add(uj);
            textBox_Cim.Text = "";
            numericUpDown_Alapterulet.Value = 20;
            comboBox_Epitesi_anyag.SelectedIndex = -1;
            dateTimePicker_Munka_kezdete.Value = DateTime.Now;
            dateTimePicker_Munka_vege.Value = DateTime.Now;
            numericUpDown_Lakasok_szama.Value = 1;
            checkBox_Lift.Checked = false;
            comboBox_Lakasfenntartas_tipusa.SelectedIndex = -1;
        }
    }
}
