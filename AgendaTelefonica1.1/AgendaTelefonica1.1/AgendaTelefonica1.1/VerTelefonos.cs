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
    public partial class VerTelefonos : Form
    {
        private OleDbConnection ConexionConBD;
        private OleDbCommand Orden;
        private OleDbDataReader Lector;
        private string strConexion = "Provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=C:\\ProgOrObj\\AgendaTelefonica1.1\\Bases\\BasePerTelNew2.mdb;";
        private string consulta;
        string dni;

        public VerTelefonos(string doc)
        {
            
            InitializeComponent();
            dni = doc;
            
        }
        public void AbrirOpcion(object formOpcion)
        {
            if (this.pnl_VerTel.Controls.Count > 0)
            {
                this.pnl_VerTel.Controls.RemoveAt(0);
            }
            Form opcion = formOpcion as Form;
            opcion.TopLevel = false;
            opcion.Dock = DockStyle.Fill;
            this.pnl_VerTel.Controls.Add(opcion);
            this.pnl_VerTel.Tag = opcion;
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
        private void VerTelefonos_Load(object sender, EventArgs e)
        {            
            dgv_Telefonos.EnableHeadersVisualStyles = false;
            dgv_Telefonos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(47, 48, 97);
            dgv_Telefonos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dgv_Telefonos.AllowUserToResizeRows = false;
            dgv_Telefonos.RowHeadersVisible = false;
            dgv_Telefonos.Rows.Clear();
            AbrirBase();
            consulta = "SELECT Personas.DNI, Personas.Nombre, Personas.Apellido, Telefonos.Tipo_tel, Telefonos.Numero " +
                "FROM Telefonos INNER JOIN (Personas INNER JOIN Per_Tel ON Personas.DNI = Per_Tel.DNI) " +
                "ON Telefonos.Id_telefono = Per_Tel.Id_Tel WHERE Personas.DNI = "+dni+";";
            Orden = new OleDbCommand(consulta, ConexionConBD);
            Lector = Orden.ExecuteReader();
            while (Lector.Read())
            {
                dgv_Telefonos.Rows.Add();
                dgv_Telefonos[0, dgv_Telefonos.Rows.Count - 1].Value = Lector["DNI"];
                dgv_Telefonos[1, dgv_Telefonos.Rows.Count - 1].Value = Lector["Nombre"];
                dgv_Telefonos[2, dgv_Telefonos.Rows.Count - 1].Value = Lector["Apellido"];
                dgv_Telefonos[3, dgv_Telefonos.Rows.Count - 1].Value = Lector["Tipo_Tel"];
                dgv_Telefonos[4, dgv_Telefonos.Rows.Count - 1].Value = Lector["Numero"];

            }
            CerrarBase();

        }

        private void btn_volver_Click(object sender, EventArgs e)
        {

            AbrirOpcion(new VerAgenda());
            pnl_verOcultar.Visible = false;
        }
    }
}
