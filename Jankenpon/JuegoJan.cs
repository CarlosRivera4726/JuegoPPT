using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jankenpon
{
    public partial class JuegoJan : Form
    {
        private Player player = null;
        private Player machine = null;
        public JuegoJan()
        {
            InitializeComponent();
            machine = new Player(Environment.MachineName.ToString(), Environment.Version.ToString(), Environment.UserName.ToString());
            lblMachine.Text = machine.ToString();
        }

        public void pedirJugador(Player player)
        {
            if (player == null)
            {
                MessageBox.Show("No se ha recibido un jugador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
            else
            {
                this.player = player;
                lblDatos.Text = this.player.ToString();
            }

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            pBJugador.Image = Jankenpon.Properties.Resources.playerGif;
            pBMachine.Image = Jankenpon.Properties.Resources.machineGif;
            btnIniciar.Enabled = false;
            btnStop.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            // el resultado y vamos a cambiar a los estaticos de forma aleatoria
            // desde el 1 al 6 van a estar los estaticos
            btnStop.Enabled = false;
            btnIniciar.Enabled = true;
            Random rnd = new Random();
            // valores de .Next(), minimo incluido, maximo excluido, como vamos de 
            // 1 hasta 3 sumamos uno
            int playerStats = rnd.Next(0, 3);
            int machineStats = rnd.Next(0, 3);

            pBJugador.Image = JuegoJankenpon.Images[playerStats];
            pBMachine.Image = JuegoJankenpon.Images[machineStats];
            // TODO: resolver las condicionales XD

            if (playerStats == machineStats)
            {
                MessageBox.Show("Empate", "Estado Juego", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            // 0 = piedra
            // 1 = papel
            // 2 = tijera
            else if ((playerStats == 0 && machineStats == 2) || (playerStats == 1 && machineStats == 0) || (playerStats == 2 && machineStats == 1))
            {
                MessageBox.Show("¡Ganaste!", "Estado Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.player.Puntaje += 15;
                this.machine.Puntaje -= 15;
            }
            else
            {
                MessageBox.Show("¡Perdiste!", "Estado Juego", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.player.Puntaje -= 15;
                this.machine.Puntaje += 15;
            }

            btnIniciar.Enabled = true;
            btnStop.Enabled = false;

            lblDatos.Text = this.player.ToString();
            lblMachine.Text = this.machine.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
