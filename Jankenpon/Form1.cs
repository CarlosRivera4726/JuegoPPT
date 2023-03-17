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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "" || txtApellido.Text != "" || txtUserName.Text != "")
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string username = txtUserName.Text;
                Player player = new Player(nombre, apellido, username);
                JuegoJan juego = new JuegoJan();
                juego.pedirJugador(player);
                juego.Visible = true;

                txtNombre.Text = "";
                txtApellido.Text = "";
                txtUserName.Text = "";
            }
            else
            {
                MessageBox.Show("Error Datos Incorrectos, llene todos los campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
