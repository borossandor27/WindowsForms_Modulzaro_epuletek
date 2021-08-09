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
        public Form_Csaladihaz()
        {
            InitializeComponent();
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
        }
    }
}
