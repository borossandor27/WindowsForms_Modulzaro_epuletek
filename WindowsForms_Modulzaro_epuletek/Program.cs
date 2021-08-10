using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Modulzaro_epuletek
{
    static class Program
    {
        public static Form_Nyito form_Nyito = null;
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            form_Nyito = new Form_Nyito();
            Application.Run(form_Nyito);
        }
    }
}
