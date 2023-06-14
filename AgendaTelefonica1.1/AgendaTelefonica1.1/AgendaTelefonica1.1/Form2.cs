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
    public partial class Form2 : Form
    {
        private OleDbConnection ConexionConBD;
        private OleDbCommand Orden;
        private OleDbDataReader Lector;
        private string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\ProgOrObj\\AgendaTelefonica1.1\\Bases\\BasePerTelNew2.mdb;";
        //DataTable Tabla = new DataTable();
        private string consulta;
        private int cantidadContactos=0;

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
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            AbrirBase();
            consulta = "SELECT Personas.DNI FROM Personas;";
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                cantidadContactos++;
            }
            CerrarBase();
            lbl_NumeroContactos.Text = cantidadContactos.ToString();
        }
    }
}
