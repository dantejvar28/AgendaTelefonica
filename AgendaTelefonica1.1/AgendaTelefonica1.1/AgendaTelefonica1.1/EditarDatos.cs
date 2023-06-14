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
    public partial class EditarDatos : Form
    {
        private OleDbConnection ConexionConBD;
        private OleDbCommand Orden;
        private OleDbDataReader Lector;
        private string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\ProgOrObj\\AgendaTelefonica1.1\\Bases\\BasePerTelNew2.mdb;";
        private string consulta;
        private string eleccionTipoTel = "";
        private int esEditar = 0; // 0 es editar 1 es agregar
        private int idtelEditar;
        // operaciones con Base ------
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
        void CargaBaseInicio()
        {
            dgv_editarDatos.Rows.Clear();
            pnl_agregaroEditar.Visible = false;
            consulta = "SELECT Personas.DNI, Personas.Nombre, Personas.Apellido, Personas.Direccion, Telefonos.Tipo_tel, Telefonos.Numero, Telefonos.Id_telefono " +
                "FROM Telefonos INNER JOIN (Personas INNER JOIN Per_Tel ON Personas.DNI = Per_Tel.DNI) " +
                "ON Telefonos.Id_telefono = Per_Tel.Id_Tel;";
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                dgv_editarDatos.Rows.Add();
                dgv_editarDatos[1, dgv_editarDatos.Rows.Count - 1].Value = Lector["DNI"];
                dgv_editarDatos[2, dgv_editarDatos.Rows.Count - 1].Value = Lector["Nombre"];
                dgv_editarDatos[3, dgv_editarDatos.Rows.Count - 1].Value = Lector["Apellido"];
                dgv_editarDatos[4, dgv_editarDatos.Rows.Count - 1].Value = Lector["Direccion"];
                dgv_editarDatos[5, dgv_editarDatos.Rows.Count - 1].Value = Lector["Numero"];
                dgv_editarDatos[6, dgv_editarDatos.Rows.Count - 1].Value = Lector["Tipo_tel"];
                dgv_editarDatos[7, dgv_editarDatos.Rows.Count - 1].Value = Lector["Id_telefono"];
            }
        }

        // -----------------------

        public EditarDatos()
        {
            InitializeComponent();
        }

        void OcultarBotonesPrincipales()
        {
            pnl_botonesPrinc.Visible = false;
        }
        private void EditarDatos_Load(object sender, EventArgs e)
        {
            btn_agregarTelefono.Visible = false;
            dgv_editarDatos.EnableHeadersVisualStyles = false;
            dgv_editarDatos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 48, 97);
            dgv_editarDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_editarDatos.AllowUserToResizeRows = false;
            dgv_editarDatos.RowHeadersVisible = false;
            FinalizaCargaOEdicion();
        }

        private void btn_AgregarContacto_Click(object sender, EventArgs e)
        {
            esEditar = 1;
            if (!(txb_dni.Text.Equals(null) || txb_dni.Text.Equals("")) && ValidarNumero(txb_dni.Text))
            {
                pnl_agregaroEditar.Visible = true;
                OcultarBotonesPrincipales();
                txb_dni.Enabled = false;
                txb_direccion.Enabled = true;
                txb_numeroTelefono.Enabled = true;
                rb_celular.Enabled = true;
                rb_fijo.Enabled = true;
                cbx_direccion.Visible = false;
                cbx_numero.Visible = false;
            }
            else
            {
                MessageBox.Show("Por favor ingrese un número de DNI válido");
            }

        }

        private void btn_editarContacto_Click(object sender, EventArgs e)
        {
            cbx_direccion.Visible = true;
            cbx_numero.Visible = true;
            esEditar = 0;
            OcultarBotonesPrincipales();
            int indice = 0;
            bool hayUnDatoElegido = false;
            for (int i = 0; i < dgv_editarDatos.Rows.Count; i++)
            {
                indice = i;
                if (Convert.ToBoolean(dgv_editarDatos[0, i].Value) == true)
                {
                    hayUnDatoElegido = true;

                    break;
                }

            }
            if (hayUnDatoElegido)
            {
                pnl_agregaroEditar.Visible = true;
                txb_dni.Text = Convert.ToString(dgv_editarDatos[1, indice].Value);
                txb_nombre.Text = Convert.ToString(dgv_editarDatos[2, indice].Value);
                txb_apellido.Text = Convert.ToString(dgv_editarDatos[3, indice].Value);
                txb_direccion.Text = Convert.ToString(dgv_editarDatos[4, indice].Value);
                txb_numeroTelefono.Text = Convert.ToString(dgv_editarDatos[5, indice].Value);
                idtelEditar = Convert.ToInt32(dgv_editarDatos[7, indice].Value);
                txb_dni.Enabled = false;
                txb_nombre.Enabled = false;
                txb_apellido.Enabled = false;
                txb_direccion.Enabled = false;
                txb_numeroTelefono.Enabled = false;
                rb_celular.Enabled = false;
                rb_fijo.Enabled = false;
            }
            else
            {
                MessageBox.Show("Elija un contacto para Editar");
            }
        }
        // validar-------------------------------
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
        //-------------------------------------------------------------------------------
        private void txb_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void txb_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 64 && e.KeyChar < 91) || (e.KeyChar > 96 && e.KeyChar < 123) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void txb_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 64 && e.KeyChar < 91) || (e.KeyChar > 96 && e.KeyChar < 123) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            FinalizaCargaOEdicion();
            pnl_botonesPrinc.Visible = true;
        }
        void OcultarDatos()
        {
            txb_dni.Text = "";
            txb_apellido.Text = "";
            txb_direccion.Text = "";
            txb_nombre.Text = "";
            txb_numeroTelefono.Text = "";
            pnl_agregaroEditar.Visible = false;
        }
        private void dgv_editarDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            for (int i = 0; i < dgv_editarDatos.Rows.Count; i++)
            {
                dgv_editarDatos[0, i].Value = false;
            }
            dgv_editarDatos[0, e.RowIndex].Value = true;
        }

        private void btn_listo_Click(object sender, EventArgs e)
        {
            switch (esEditar)
            {
                case 1:
                    if (ValidarNumero(txb_dni.Text) && ValidarLetras(txb_nombre.Text) && ValidarLetras(txb_apellido.Text)
                        && ValidarNumero(txb_numeroTelefono.Text) && (NoEstaVacio(txb_dni.Text)) && (NoEstaVacio(txb_nombre.Text))
                        && (NoEstaVacio(txb_apellido.Text)) && (NoEstaVacio(txb_direccion.Text)) && (NoEstaVacio(txb_numeroTelefono.Text))
                        && (NoEstaVacio(eleccionTipoTel)))
                    {
                        // Insert en tabla Personas
                        consulta = "INSERT INTO Personas(DNI, Nombre, Apellido, Direccion) VALUES(" + txb_dni.Text + ", '" +
                                    txb_nombre.Text + "', '" + txb_apellido.Text + "', '" + txb_direccion.Text + "');";
                        AbrirBase();
                        Orden = new OleDbCommand(consulta, ConexionConBD);
                        // Insert en tabla teléfonos
                        try
                        {
                            Orden.ExecuteNonQuery();
                            consulta = "INSERT INTO Telefonos(Numero,Tipo_tel) VALUES('" + txb_numeroTelefono.Text + "', '"
                                    + eleccionTipoTel + "');";
                            Orden = new OleDbCommand(consulta, ConexionConBD);
                            try
                            {
                                Orden.ExecuteNonQuery();
                                consulta = "SELECT max(Id_telefono) as ID_TEL FROM Telefonos";
                                Orden = new OleDbCommand(consulta, ConexionConBD);
                                Lector = Orden.ExecuteReader();
                                Lector.Read();
                                int idTelefono = Convert.ToInt32(Lector["ID_TEL"]);

                                consulta = "INSERT INTO Per_Tel(DNI, Id_Tel) VALUES(" + txb_dni.Text + ", " + idTelefono + ");";
                                Orden = new OleDbCommand(consulta, ConexionConBD);
                                Orden.ExecuteNonQuery();
                                CerrarBase();
                                rb_fijo.Checked = false;
                                rb_celular.Checked = false;
                                DialogResult mensaje = MessageBox.Show("¿Agregar Otro Teléfono?", "Carga Exitosa! ", MessageBoxButtons.YesNo);
                                if (mensaje == DialogResult.Yes)
                                {
                                    txb_dni.Enabled = false;
                                    txb_nombre.Enabled = false;
                                    txb_apellido.Enabled = false;
                                    txb_direccion.Enabled = false;
                                    btn_agregarTelefono.Visible = true;
                                    btn_listo.Visible = false;
                                    rb_fijo.AutoCheck = true;

                                }
                                else
                                {
                                    FinalizaCargaOEdicion();
                                }

                            }
                            catch
                            {
                                CerrarBase();
                                MessageBox.Show("Error en carga de base tel o per_tel");
                                FinalizaCargaOEdicion();
                            }
                        }
                        catch
                        {
                            CerrarBase();
                            MessageBox.Show("Error en cargar Datos");
                            FinalizaCargaOEdicion();
                        }



                    }
                    else
                    {
                        MessageBox.Show("Algun dato vacío o Erroneo");
                        FinalizaCargaOEdicion();
                        // cargar error Provider
                    }
                    break;
                case 0:
                    try
                    {
                        if (cbx_numero.Checked == true)
                        {
                            if (ValidarNumero(txb_numeroTelefono.Text) && NoEstaVacio(eleccionTipoTel))
                            {
                                consulta = "UPDATE Telefonos SET Numero='" + txb_numeroTelefono.Text +"', Tipo_tel='"+eleccionTipoTel + "' WHERE Id_telefono= " + idtelEditar + ";";
                                AbrirBase();
                                Orden = new OleDbCommand(consulta, ConexionConBD);
                                Orden.ExecuteNonQuery();
                                CerrarBase();
                            }
                        }
                        if (cbx_direccion.Checked == true)
                        {
                            if (NoEstaVacio(txb_direccion.Text))
                            {
                                consulta = "UPDATE Personas SET Direccion='" + txb_direccion.Text + "' WHERE DNI= " + txb_dni.Text + ";";
                                AbrirBase();
                                Orden = new OleDbCommand(consulta, ConexionConBD);
                                Orden.ExecuteNonQuery();
                                CerrarBase();
                            }
                        }
                        
                        FinalizaCargaOEdicion();
                    }
                    catch
                    {
                        CerrarBase();
                        MessageBox.Show("Hay algun Error");
                    }
                    break;
            }
            pnl_botonesPrinc.Visible = true;

        }
        void FinalizaCargaOEdicion()
        {
            OcultarDatos();
            txb_dni.Enabled = true;
            txb_nombre.Enabled = true;
            txb_apellido.Enabled = true;
            txb_direccion.Enabled = true;
            txb_numeroTelefono.Enabled = true;
            rb_celular.Enabled = true;
            rb_fijo.Enabled = true;
            AbrirBase();
            CargaBaseInicio();
            CerrarBase();
            btn_agregarTelefono.Visible = false;
            if (btn_listo.Visible == false)
            {
                btn_listo.Visible = true;
            }
        }

        private void txb_numeroTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar > 47 && e.KeyChar < 58) || (e.KeyChar == 08) || e.KeyChar == 11))
            {
                e.Handled = true;
            }
        }

        private void rb_fijo_CheckedChanged(object sender, EventArgs e)
        {
            eleccionTipoTel = rb_fijo.Text;
        }

        private void rb_celular_CheckedChanged(object sender, EventArgs e)
        {
            eleccionTipoTel = rb_celular.Text;
        }

        private void btn_agregarTelefono_Click(object sender, EventArgs e)
        {
            int idTelefono;
            if (NoEstaVacio(eleccionTipoTel))
            {
                if (ValidarNumero(txb_numeroTelefono.Text))
                {
                    try
                    {
                        AbrirBase();
                        consulta = "INSERT INTO Telefonos(Numero,Tipo_tel) VALUES('" + txb_numeroTelefono.Text + "', '"
                                        + eleccionTipoTel + "');";
                        Orden = new OleDbCommand(consulta, ConexionConBD);
                        Orden.ExecuteNonQuery();

                        consulta = "SELECT max(Id_telefono) as ID_TEL FROM Telefonos";
                        Orden = new OleDbCommand(consulta, ConexionConBD);
                        Lector = Orden.ExecuteReader();
                        Lector.Read();
                        idTelefono = Convert.ToInt32(Lector["ID_TEL"]);

                        consulta = "INSERT INTO Per_Tel(DNI, Id_Tel) VALUES(" + txb_dni.Text + ", " + idTelefono + ");";
                        Orden = new OleDbCommand(consulta, ConexionConBD);
                        Orden.ExecuteNonQuery();
                        CerrarBase();
                        FinalizaCargaOEdicion();

                    }
                    catch
                    {
                        CerrarBase();
                        MessageBox.Show("Hay Algun Error");
                        FinalizaCargaOEdicion();

                    }
                }
                else
                {
                    MessageBox.Show("El dato ingresado no es un Número");
                }
            }
            else
            {
                MessageBox.Show("No eligio tipo de teléfono");
            }
            pnl_botonesPrinc.Visible = true;
        }

        private void cbx_direccion_CheckedChanged(object sender, EventArgs e)
        {
            txb_direccion.Enabled = !txb_direccion.Enabled;
        }

        private void cbx_numero_CheckedChanged(object sender, EventArgs e)
        {
            txb_numeroTelefono.Enabled = !txb_numeroTelefono.Enabled;
            rb_celular.Enabled = !rb_celular.Enabled;
            rb_fijo.Enabled = !rb_fijo.Enabled;
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (ValidarNumero(txb_dni.Text))
            {
                consulta = "SELECT Personas.DNI, Personas.Nombre, Personas.Apellido, Personas.Direccion, Telefonos.Tipo_tel, Telefonos.Numero, Telefonos.Id_telefono " +
                "FROM Telefonos INNER JOIN (Personas INNER JOIN Per_Tel ON Personas.DNI = Per_Tel.DNI) " +
                "ON Telefonos.Id_telefono = Per_Tel.Id_Tel WHERE Personas.DNI="+txb_dni.Text+ ";";
                AbrirBase();
                Orden = new OleDbCommand(consulta,ConexionConBD);
                dgv_editarDatos.Rows.Clear();
                Lector = Orden.ExecuteReader();
                while(Lector.Read())
                {
                    dgv_editarDatos.Rows.Add();
                    dgv_editarDatos[1, dgv_editarDatos.Rows.Count - 1].Value = Lector["DNI"];
                    dgv_editarDatos[2, dgv_editarDatos.Rows.Count - 1].Value = Lector["Nombre"];
                    dgv_editarDatos[3, dgv_editarDatos.Rows.Count - 1].Value = Lector["Apellido"];
                    dgv_editarDatos[4, dgv_editarDatos.Rows.Count - 1].Value = Lector["Direccion"];
                    dgv_editarDatos[5, dgv_editarDatos.Rows.Count - 1].Value = Lector["Numero"];
                    dgv_editarDatos[6, dgv_editarDatos.Rows.Count - 1].Value = Lector["Tipo_tel"];
                    dgv_editarDatos[7, dgv_editarDatos.Rows.Count - 1].Value = Lector["Id_telefono"];
                }
                CerrarBase();
            }
        }


    }
}
