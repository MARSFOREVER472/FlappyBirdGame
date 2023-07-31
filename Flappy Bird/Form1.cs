using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        // Creado por MARSFOREVER472 para tutoriales.

        // Las variables iniciales empiezan aquí.

        int velocidadTuberia = 8; // La velocidad de tubería predeterminada definida por un entero.
        int gravedad = 15; // La velocidad de gravedad predeterminada definida por un entero.
        int puntuacion = 0; // Entero de puntuación predeterminado establecido en 0.

        // Las variables terminaron aquí al final.
        public Form1()
        {
            InitializeComponent();
        }

        // Métodos fundamentales del juego.
        private void gameTimerEvent(object sender, EventArgs e)
        {
            // EN INSTANTES...
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // EN INSTANTES...
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // EN INSTANTES...
        }
    }
}
