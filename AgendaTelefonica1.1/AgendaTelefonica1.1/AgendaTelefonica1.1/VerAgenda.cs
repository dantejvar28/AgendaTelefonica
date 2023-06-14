using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AgendaTelefonica1._1
{
    public partial class VerAgenda : Form
    {
        private OleDbConnection ConexionConBD;
        private OleDbCommand Orden;
        private OleDbDataReader Lector;
        private string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\ProgOrObj\\AgendaTelefonica1.1\\Bases\\BasePerTelNew2.mdb;";
        //DataTable Tabla = new DataTable();
        private string consulta;
        


        public void AbrirOpcion(object formOpcion)
        {
            if (this.pnl_VerAgenda.Controls.Count > 0)
            {
                this.pnl_VerAgenda.Controls.RemoveAt(0);
            }
            Form opcion = formOpcion as Form;
            opcion.TopLevel = false;
            opcion.Dock = DockStyle.Fill;
            this.pnl_VerAgenda.Controls.Add(opcion);
            this.pnl_VerAgenda.Tag = opcion;
            opcion.Show();
        }
        private void AbrirBase()
        {
            ConexionConBD = new OleDbConnection(strConexion);
            ConexionConBD.Open();
        }
        private void CerrarBase()
        {
            Lector.Close();
            ConexionConBD.Close();
        }
 
        public VerAgenda()
        {
            InitializeComponent();
        }
        void CargarBase()
        {
            consulta = "SELECT Personas.DNI, Personas.Nombre, Personas.Apellido, Personas.Direccion FROM Personas;";
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                dgv_verAgenda.Rows.Add();
                dgv_verAgenda[1, dgv_verAgenda.Rows.Count - 1].Value = Lector["DNI"];
                dgv_verAgenda[2, dgv_verAgenda.Rows.Count - 1].Value = Lector["Nombre"];
                dgv_verAgenda[3, dgv_verAgenda.Rows.Count - 1].Value = Lector["Apellido"];
                dgv_verAgenda[4, dgv_verAgenda.Rows.Count - 1].Value = Lector["Direccion"];
            }
        }
        private void VerAgenda_Load(object sender, EventArgs e)
        {
            btn_mostrarTodo.Visible = false;
            dgv_verAgenda.EnableHeadersVisualStyles = false;
            dgv_verAgenda.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 48, 97);
            dgv_verAgenda.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_verAgenda.AllowUserToResizeRows = false;
            dgv_verAgenda.RowHeadersVisible = false;
            dgv_verAgenda.Rows.Clear();
            AbrirBase();
            CargarBase();
            CerrarBase();
        }

        // -------------------------------Funciones para Validar Datos ------------------------------

        public bool ValidarNumero(string numero)
        {
            bool esNumero;
            try
            {
                Convert.ToDouble(numero);
                esNumero = true;
            }
            catch
            {
                esNumero = false;
            }
            return esNumero;
        }

        private void txb_dniBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (ValidarNumero(txb_dniBuscar.Text))
            {
                consulta = "SELECT Personas.DNI, Personas.Nombre, Personas.Apellido, Personas.Direccion FROM Personas WHERE Personas.DNI = " + txb_dniBuscar.Text + ";";
                AbrirBase();
                Orden = new OleDbCommand(consulta, ConexionConBD);
                dgv_verAgenda.Rows.Clear();
                Lector = Orden.ExecuteReader();
                while (Lector.Read())
                {
                    dgv_verAgenda.Rows.Add();
                    dgv_verAgenda[1, dgv_verAgenda.Rows.Count - 1].Value = Lector["DNI"];
                    dgv_verAgenda[2, dgv_verAgenda.Rows.Count - 1].Value = Lector["Nombre"];
                    dgv_verAgenda[3, dgv_verAgenda.Rows.Count - 1].Value = Lector["Apellido"];
                    dgv_verAgenda[4, dgv_verAgenda.Rows.Count - 1].Value = Lector["Direccion"];
                }
                CerrarBase();
                txb_dniBuscar.Text = "";
                btn_mostrarTodo.Visible = true;
            }
            else
            {
                MessageBox.Show("DNI Inválido");
            }
        }

        private void btn_mostrarTodo_Click(object sender, EventArgs e)
        {
            dgv_verAgenda.Rows.Clear();
            AbrirBase();
            CargarBase();
            CerrarBase();
            btn_mostrarTodo.Visible = false;
        }

        private void btn_VerTelefonos_Click(object sender, EventArgs e)
        {
            string opcionelegida;
            for (int i = 0; i < dgv_verAgenda.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_verAgenda[0,i].Value)==true)
                {
                    opcionelegida = dgv_verAgenda[1, i].Value.ToString();
                    AbrirOpcion(new VerTelefonos(opcionelegida));
                    pnl_verage.Visible = false;
                    break;
                }
            }
            
        }

        private void dgv_verAgenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            for (int i = 0; i < dgv_verAgenda.Rows.Count; i++)
            {
                dgv_verAgenda[0, i].Value = false;
            }
            dgv_verAgenda[0, e.RowIndex].Value = true;
        }
        
    }
}
