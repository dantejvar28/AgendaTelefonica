using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaTelefonica1._1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public void AbrirOpcion(object formOpcion)
        {
            if (this.pnl_seleccionmenu.Controls.Count>0)
            {
                this.pnl_seleccionmenu.Controls.RemoveAt(0);
            }
            Form opcion = formOpcion as Form;
            opcion.TopLevel = false;
            opcion.Dock = DockStyle.Fill;
            this.pnl_seleccionmenu.Controls.Add(opcion);
            this.pnl_seleccionmenu.Tag = opcion;
            opcion.Show();
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            if (pnl_menuBorrar.Visible)
            {
                pnl_menuBorrar.Visible = false;

            }
            else
            {
                pnl_menuBorrar.Visible = true;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnl_menuBorrar.Visible = false;
            AbrirOpcion(new Form2());
        }

        private void btn_VerAgenda_Click(object sender, EventArgs e)
        {
            AbrirOpcion(new VerAgenda());
        }

        private void btn_agregarContacto_Click(object sender, EventArgs e)
        {
            AbrirOpcion(new EditarDatos());
        }

        private void btn_borrarContacto_Click(object sender, EventArgs e)
        {
            AbrirOpcion(new BorrarContacto());
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            AbrirOpcion(new Form2());
        }

    }
}
