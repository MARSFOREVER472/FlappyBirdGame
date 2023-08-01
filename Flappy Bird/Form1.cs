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
            pipeBottom.Left -= velocidadTuberia; // Se enlaza la posición horizontal de las tuberías inferiores al valor entero de velocidad de la tubería, reducirá el valor de la velocidad de la tubería desde la posición horizontal del cuadro de imagen de la tubería, por lo que se moverá hacia la izquierda con cada tick.
            pipeTop.Left -= velocidadTuberia; // Lo mismo va a suceder con la tubería superior, reduzca el valor del número entero de velocidad de la tubería desde la posición horizontal de la tubería usando el signo -=.
            lblScore.Text = "Score: " + puntuacion; // Muestra la puntuación actual en la etiqueta de texto de puntuación.

            if (pipeBottom.Left < -50)
            {
                pipeBottom.Left = 800; // Si la ubicación de las tuberías inferiores es -50, la restableceremos a 800 y agregaremos 1 a la puntuación.
                puntuacion++; 
            }

            if (pipeTop.Left < -80)
            {
                pipeTop.Left = 950; // Si la ubicación de la tubería superior es -80, restableceremos la tubería a 950 y agregaremos 1 a la puntuación.
                puntuacion++;
            }

            // La condición if a continuación verifica si la tubería golpeó el suelo, las tuberías o si el jugador ha salido de la pantalla desde la parte superior.
            // Los dos símbolos de una tubería representan OR dentro de una declaración if, por lo que podemos tener varias condiciones dentro de esta declaración if porque todas van a hacer lo mismo.

            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || flappyBird.Top < -25
                )
            {
                // Si se cumple algunas de las condiciones anteriores, ejecutaremos la función de finalización del juego.

                endGame();
            }

            // Si la puntuación es mayor que 5, aumentaremos la velocidad de la tubería en 15.

            if (puntuacion > 5)
            {
                velocidadTuberia = 15;
            }
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

        private void endGame()
        {
            // Esta es la función de finalización del juego, y ésta se activará cuando el personaje toque el suelo o las tuberías.

            gameTimer.Stop(); // Detiene el temporizador.
            lblScore.Text += " JUEGO TERMINADO!!!"; // muestra el texto del juego terminado en el texto de la puntuación, += se usa para agregar la nueva cadena de texto junto a la puntuación en vez de omitirla.
        }
    }
}
