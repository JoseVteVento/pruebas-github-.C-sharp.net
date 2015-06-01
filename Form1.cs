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
        private String mensaje1 = "Primer mensaje";
        private String mensaje2 = "Segundo mensaje";
        private String mensaje3 = "Tercer mensaje";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_lanzar_mensaje_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;

            switch (x)
            {
                case 0:
                    MessageBox.Show(mensaje1);
                    x++;
                    break;
                case 1:
                    MessageBox.Show(mensaje2);
                    x++;
                    break;
                case 2:
                    MessageBox.Show(mensaje3);
                    x++;
                    break;
                default:
                    MessageBox.Show("No me quedan más mensajes. Tendremos que volver a empezar!!!");
                    x = 0;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Visible = false;
            textBox1.Visible = false;
        }

        private void btn_cambiar_mensaje_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            textBox1.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            switch (x)
            {
                case 0:
                    mensaje1 = textBox1.Text;
                    break;

                case 1:
                    mensaje2 = textBox1.Text;
                    break;

                case 2:
                    mensaje3 = textBox1.Text;
                    break;
            }
        }
    }
}
