using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pruebas_github
{
    public partial class Form1 : Form
    {
        private int x = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_lanzar_mensaje_Click(object sender, EventArgs e)
        {
            switch (x)
            {
                case 0:
                    MessageBox.Show("Primer mensaje");
                    x++;
                    break;
                case 1:
                    MessageBox.Show("Segundo mensaje");
                    x++;
                    break;
                case 2:
                    MessageBox.Show("Tercer mensaje");
                    x++;
                    break;
                default:
                    MessageBox.Show("No me quedan más mensajes. Tendremos que volver a empezar!!!");
                    x = 0;
                    break;
            }     
        }
    }
}
