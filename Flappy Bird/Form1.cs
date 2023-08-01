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
        int gravedad = 5; // La velocidad de gravedad predeterminada definida por un entero.
        int puntuacion = 0; // Entero de puntuación predeterminado establecido en 0.

        // Las variables terminaron aquí al final.

        public Form1()
        {
            InitializeComponent();
        }

        // Métodos fundamentales del juego.

        private void gameTimerEvent(object sender, EventArgs e)
        {
            // CONSEJO: ACTIVAR EL TEMPORIZADOR EN TRUE PARA HABILITAR LA GRAVEDAD DEL OBJETO (FLAPPY BIRD).

            flappyBird.Top += gravedad; // Se enlaza el cuadro de imagen del Flappy Bird a la gravedad, += significa que agregará la velocidad de la gravedad a la ubicación superior del cuadro de imagen para que se mueva hacia abajo.
        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // Esta es la clave del juego es un evento inactivo que está enlazado al Main Form.

            if (e.KeyCode == Keys.Space)
            {
                // Si se presiona la tecla Espacio, la gravedad se establecerá en -15.

                gravedad = -5;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // Esta es la clave del juego es un evento activo que está enlazado al Main Form.

            if (e.KeyCode == Keys.Space)
            {
                // Si se suelta la tecla de espacio, la gravedad vuelve a 15.

                gravedad = 5;
            }
        }
    }
}
