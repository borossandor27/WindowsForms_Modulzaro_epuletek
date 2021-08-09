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
    }
}
