using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_VarYSec_Ejercicio2
{
    public partial class fViaje : Form
    {
        public fViaje()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcularTiempo_Click(object sender, EventArgs e)
        {
            string destino = tDestino.Text;
            string sDistancia = tDistancia.Text;
            string sVelocidad = tVelocidad.Text;
            double tiempo;

            double dDistancia = Convert.ToDouble(tDistancia.Text);
            double dVelocidad = Convert.ToDouble(tVelocidad.Text);
            tiempo = Math.Round(dDistancia / dVelocidad);

            MessageBox.Show("El tiempo que durará el viaje\nhasta llegar a " + destino + " es de " + tiempo +" horas");
        }
    }
}
