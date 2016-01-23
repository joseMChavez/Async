using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsincronoForm
{
    public partial class Asincrono : Form
    {
        public Asincrono()
        {
            InitializeComponent();
        }
        private Task<int> EsperaAsync(int seg)
        {
            return Task.Run(() => {
                Thread.Sleep(seg);
                return seg / 1000;

            });
        }
        private Task<int> ContadorAsync(int cont)
        {
            return Task.Run(() => {
                Thread.SpinWait(cont);
                while (true)
                {
                    return cont - 5;

                }

            });
        }
      
        private void Reinciar()
        {
            this.AcciontextBox.Clear();
            this.AccionDosTextBox.Clear();
            this.Text = "Prueba";
            this.AccionTimer.Enabled = false;
        }
        private async void AccionUnobutton_Click(object sender, EventArgs e)
        {
            int segundo = await EsperaAsync(3000);
            this.AcciontextBox.Text = "Metodo Retornado en " + segundo + "seg";
            this.Text = "Jose Chavez";
        }

        private async void AccionDosButton_Click(object sender, EventArgs e)
        {
            int contador = await EsperaAsync(10000); //De todos Modos Espera los dos segundo.
            this.AccionDosTextBox.Text = DateTime.Now.ToLongTimeString();

        }

        private void ReiniciarButton_Click(object sender, EventArgs e)
        {
            Reinciar();
        }
    }
}

