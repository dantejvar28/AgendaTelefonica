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
    public partial class BorrarContacto : Form
    {
        private OleDbConnection ConexionConBD;
        private OleDbCommand Orden;
        private OleDbDataReader Lector;
        private string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\ProgOrObj\\AgendaTelefonica1.1\\Bases\\BasePerTelNew2.mdb;";
        private string consulta;
        private string dniABorrar;
        public BorrarContacto()
        {
            InitializeComponent();
        }
        // Validaciones 
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
        public bool ValidarLetras(string letras)
        {
            foreach (char ch in letras)
            {
                if (!Char.IsLetter(ch))
                {
                    return false;

                }

            }
            return true;

        }
        public bool NoEstaVacio(string dato)
        {
            if (dato.Trim() == "")
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        //------------------------------------------------------------------
        // Operaciones con DB
        void CargarBase()
        {
            consulta = "SELECT Personas.DNI, Personas.Nombre, Personas.Apellido, Personas.Direccion FROM Personas;";
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                dgv_borrarContacto.Rows.Add();
                dgv_borrarContacto[1, dgv_borrarContacto.Rows.Count - 1].Value = Lector["DNI"];
                dgv_borrarContacto[2, dgv_borrarContacto.Rows.Count - 1].Value = Lector["Nombre"];
                dgv_borrarContacto[3, dgv_borrarContacto.Rows.Count - 1].Value = Lector["Apellido"];
                dgv_borrarContacto[4, dgv_borrarContacto.Rows.Count - 1].Value = Lector["Direccion"];
            }
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
        //-----------------------------------------------------------------------
        private void BorrarContacto_Load(object sender, EventArgs e)
        {
            dgv_borrarContacto.EnableHeadersVisualStyles = false;
            dgv_borrarContacto.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 48, 97);
            dgv_borrarContacto.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_borrarContacto.AllowUserToResizeRows = false;
            dgv_borrarContacto.RowHeadersVisible = false;
            btn_mostrarTodo.Visible = false;
            AbrirBase();
            CargarBase();
            CerrarBase();

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            if (ValidarNumero(txb_dniBuscar.Text) && NoEstaVacio(txb_dniBuscar.Text))
            {
                consulta = "SELECT Personas.DNI, Personas.Nombre, Personas.Apellido, Personas.Direccion FROM Personas WHERE Personas.DNI = " + txb_dniBuscar.Text + ";";
                AbrirBase();
                Orden = new OleDbCommand(consulta, ConexionConBD);
                dgv_borrarContacto.Rows.Clear();
                Lector = Orden.ExecuteReader();
                while (Lector.Read())
                {
                    dgv_borrarContacto.Rows.Add();
                    dgv_borrarContacto[1, dgv_borrarContacto.Rows.Count - 1].Value = Lector["DNI"];
                    dgv_borrarContacto[2, dgv_borrarContacto.Rows.Count - 1].Value = Lector["Nombre"];
                    dgv_borrarContacto[3, dgv_borrarContacto.Rows.Count - 1].Value = Lector["Apellido"];
                    dgv_borrarContacto[4, dgv_borrarContacto.Rows.Count - 1].Value = Lector["Direccion"];
                }
                CerrarBase();
                txb_dniBuscar.Text = "";
                btn_mostrarTodo.Visible = true;
            }
            else
            {
                MessageBox.Show("Ingrese un DNI Válido");
            }
        }

        private void btn_mostrarTodo_Click(object sender, EventArgs e)
        {
            dgv_borrarContacto.Rows.Clear();
            AbrirBase();
            CargarBase();
            CerrarBase();

        }

        private void dgv_borrarContacto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_borrarContacto.Rows.Count; i++)
            {
                dgv_borrarContacto[0, i].Value = false;
            }
            dgv_borrarContacto[0, e.RowIndex].Value = true;
        }

        private void txb_dniBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void btn_borrarContacto_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dgv_borrarContacto.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dgv_borrarContacto[0, i].Value) == true)
                {
                    dniABorrar = dgv_borrarContacto[1, i].Value.ToString();
                    break;
                }
            }
            if (!(dniABorrar == "" || dniABorrar == null))
            {
                consulta = "SELECT Id_Tel FROM Per_Tel WHERE DNI= "+dniABorrar;
                AbrirBase();
                Orden = new OleDbCommand(consulta, ConexionConBD);
                List<string> idtelefono = new List<string>();
                Lector = Orden.ExecuteReader();
                while(Lector.Read())
                {
                    idtelefono.Add(Lector["Id_Tel"].ToString());
                }
                CerrarBase();
                
                AbrirBase();
                consulta = "DELETE * FROM Per_Tel WHERE DNI= "+dniABorrar;
                Orden = new OleDbCommand(consulta, ConexionConBD);
                Orden.ExecuteNonQuery();
                CerrarBase();
                AbrirBase();
                for (int i = 0; i < idtelefono.Count(); i++)
                {
                    consulta = "DELETE * FROM Telefonos WHERE Id_telefono= " + idtelefono[i]+";";
                    Orden = new OleDbCommand(consulta, ConexionConBD);
                    try
                    {
                        Orden.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("Hay algún Error");
                    }
                }
                CerrarBase();
                consulta = "DELETE * FROM Personas WHERE DNI="+dniABorrar;
                try
                {
                    AbrirBase();
                    Orden = new OleDbCommand(consulta, ConexionConBD);
                    Orden.ExecuteNonQuery();
                    CerrarBase();
                    MessageBox.Show("Se eliminó Contacto");
                }
                catch
                {
                    CerrarBase();
                    MessageBox.Show("Hay algun error");
                }
                
                
            }
            else
            {
                MessageBox.Show("Elija un Contacto a Borrar","Error");
            }
            dgv_borrarContacto.Rows.Clear();
            AbrirBase();
            CargarBase();
            CerrarBase();
        }
    }
}
