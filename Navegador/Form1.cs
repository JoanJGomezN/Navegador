using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com/");
            urltext.Text = "https://www.google.com/";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void btnIr_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void urltext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) // Comprueba si se presionó la tecla "Enter" (código de tecla 13)
            {
                e.Handled = true; // Evita que se agregue un salto de línea en el TextBox
                RealizarBusqueda();
            }
        }

        private void RealizarBusqueda()
        {
            webBrowser1.Navigate(urltext.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            
        }

        private void urltext_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
