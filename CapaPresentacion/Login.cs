using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Inicio form = new Inicio();
            form.Show();
            this.Hide();

            form.FormClosing += frmClosing;
        }

        private void frmClosing(object sender,FormClosingEventArgs e)
        {
            this.txtDocumento.Text = "";
            this.txtClave.Text = "";
            this.Show();
        }
    }
}
