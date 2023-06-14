namespace AgendaTelefonica1._1
{
    partial class EditarDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_editarDatos = new System.Windows.Forms.DataGridView();
            this.btn_AgregarContacto = new System.Windows.Forms.Button();
            this.btn_editarContacto = new System.Windows.Forms.Button();
            this.lbl_dni = new System.Windows.Forms.Label();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_Apellido = new System.Windows.Forms.Label();
            this.lbl_direccion = new System.Windows.Forms.Label();
            this.lbl_tipoTelefono = new System.Windows.Forms.Label();
            this.lbl_numero = new System.Windows.Forms.Label();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_nombre = new System.Windows.Forms.TextBox();
            this.txb_apellido = new System.Windows.Forms.TextBox();
            this.txb_direccion = new System.Windows.Forms.TextBox();
            this.txb_numeroTelefono = new System.Windows.Forms.TextBox();
            this.rb_fijo = new System.Windows.Forms.RadioButton();
            this.rb_celular = new System.Windows.Forms.RadioButton();
            this.pnl_agregaroEditar = new System.Windows.Forms.Panel();
            this.cbx_numero = new System.Windows.Forms.CheckBox();
            this.cbx_direccion = new System.Windows.Forms.CheckBox();
            this.btn_agregarTelefono = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_listo = new System.Windows.Forms.Button();
            this.pnl_dni = new System.Windows.Forms.Panel();
            this.pnl_botonesPrinc = new System.Windows.Forms.Panel();
            this.eleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DNIColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerotelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoTelColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editarDatos)).BeginInit();
            this.pnl_agregaroEditar.SuspendLayout();
            this.pnl_dni.SuspendLayout();
            this.pnl_botonesPrinc.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_editarDatos
            // 
            this.dgv_editarDatos.AllowUserToAddRows = false;
            this.dgv_editarDatos.AllowUserToDeleteRows = false;
            this.dgv_editarDatos.AllowUserToResizeColumns = false;
            this.dgv_editarDatos.AllowUserToResizeRows = false;
            this.dgv_editarDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgv_editarDatos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_editarDatos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_editarDatos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_editarDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_editarDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_editarDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eleccion,
            this.DNIColumn,
            this.nombreColumn,
            this.apellidoColumn,
            this.direccionColumn,
            this.numerotelColumn,
            this.tipoTelColumn,
            this.idtel});
            this.dgv_editarDatos.Location = new System.Drawing.Point(12, 229);
            this.dgv_editarDatos.Name = "dgv_editarDatos";
            this.dgv_editarDatos.RowTemplate.Height = 24;
            this.dgv_editarDatos.Size = new System.Drawing.Size(648, 282);
            this.dgv_editarDatos.TabIndex = 1;
            this.dgv_editarDatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_editarDatos_CellContentClick);
            // 
            // btn_AgregarContacto
            // 
            this.btn_AgregarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_AgregarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AgregarContacto.FlatAppearance.BorderSize = 0;
            this.btn_AgregarContacto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_AgregarContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_AgregarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarContacto.ForeColor = System.Drawing.Color.White;
            this.btn_AgregarContacto.Location = new System.Drawing.Point(13, 3);
            this.btn_AgregarContacto.Name = "btn_AgregarContacto";
            this.btn_AgregarContacto.Size = new System.Drawing.Size(128, 50);
            this.btn_AgregarContacto.TabIndex = 6;
            this.btn_AgregarContacto.Text = "Agregar";
            this.btn_AgregarContacto.UseVisualStyleBackColor = false;
            this.btn_AgregarContacto.Click += new System.EventHandler(this.btn_AgregarContacto_Click);
            // 
            // btn_editarContacto
            // 
            this.btn_editarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_editarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editarContacto.FlatAppearance.BorderSize = 0;
            this.btn_editarContacto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_editarContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_editarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editarContacto.ForeColor = System.Drawing.Color.White;
            this.btn_editarContacto.Location = new System.Drawing.Point(13, 110);
            this.btn_editarContacto.Name = "btn_editarContacto";
            this.btn_editarContacto.Size = new System.Drawing.Size(128, 64);
            this.btn_editarContacto.TabIndex = 7;
            this.btn_editarContacto.Text = "Editar Contacto";
            this.btn_editarContacto.UseVisualStyleBackColor = false;
            this.btn_editarContacto.Click += new System.EventHandler(this.btn_editarContacto_Click);
            // 
            // lbl_dni
            // 
            this.lbl_dni.AutoSize = true;
            this.lbl_dni.ForeColor = System.Drawing.Color.White;
            this.lbl_dni.Location = new System.Drawing.Point(-3, 7);
            this.lbl_dni.Name = "lbl_dni";
            this.lbl_dni.Size = new System.Drawing.Size(35, 17);
            this.lbl_dni.TabIndex = 8;
            this.lbl_dni.Text = "DNI:";
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscar.ForeColor = System.Drawing.Color.White;
            this.btn_buscar.Location = new System.Drawing.Point(13, 56);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(128, 50);
            this.btn_buscar.TabIndex = 9;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = false;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre.Location = new System.Drawing.Point(-3, 12);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(62, 17);
            this.lbl_nombre.TabIndex = 10;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // lbl_Apellido
            // 
            this.lbl_Apellido.AutoSize = true;
            this.lbl_Apellido.ForeColor = System.Drawing.Color.White;
            this.lbl_Apellido.Location = new System.Drawing.Point(-3, 40);
            this.lbl_Apellido.Name = "lbl_Apellido";
            this.lbl_Apellido.Size = new System.Drawing.Size(62, 17);
            this.lbl_Apellido.TabIndex = 11;
            this.lbl_Apellido.Text = "Apellido:";
            // 
            // lbl_direccion
            // 
            this.lbl_direccion.AutoSize = true;
            this.lbl_direccion.ForeColor = System.Drawing.Color.White;
            this.lbl_direccion.Location = new System.Drawing.Point(-3, 68);
            this.lbl_direccion.Name = "lbl_direccion";
            this.lbl_direccion.Size = new System.Drawing.Size(71, 17);
            this.lbl_direccion.TabIndex = 12;
            this.lbl_direccion.Text = "Dirección:";
            // 
            // lbl_tipoTelefono
            // 
            this.lbl_tipoTelefono.AutoSize = true;
            this.lbl_tipoTelefono.ForeColor = System.Drawing.Color.White;
            this.lbl_tipoTelefono.Location = new System.Drawing.Point(-3, 122);
            this.lbl_tipoTelefono.Name = "lbl_tipoTelefono";
            this.lbl_tipoTelefono.Size = new System.Drawing.Size(120, 17);
            this.lbl_tipoTelefono.TabIndex = 13;
            this.lbl_tipoTelefono.Text = "Tipo de Teléfono:";
            // 
            // lbl_numero
            // 
            this.lbl_numero.AutoSize = true;
            this.lbl_numero.ForeColor = System.Drawing.Color.White;
            this.lbl_numero.Location = new System.Drawing.Point(-3, 96);
            this.lbl_numero.Name = "lbl_numero";
            this.lbl_numero.Size = new System.Drawing.Size(122, 17);
            this.lbl_numero.TabIndex = 14;
            this.lbl_numero.Text = "Número Teléfono:";
            // 
            // txb_dni
            // 
            this.txb_dni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_dni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txb_dni.Location = new System.Drawing.Point(123, 4);
            this.txb_dni.MaxLength = 8;
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(131, 22);
            this.txb_dni.TabIndex = 15;
            this.txb_dni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_dni_KeyPress);
            // 
            // txb_nombre
            // 
            this.txb_nombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_nombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txb_nombre.Location = new System.Drawing.Point(123, 9);
            this.txb_nombre.MaxLength = 30;
            this.txb_nombre.Name = "txb_nombre";
            this.txb_nombre.Size = new System.Drawing.Size(131, 22);
            this.txb_nombre.TabIndex = 16;
            this.txb_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_nombre_KeyPress);
            // 
            // txb_apellido
            // 
            this.txb_apellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_apellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txb_apellido.Location = new System.Drawing.Point(123, 37);
            this.txb_apellido.MaxLength = 30;
            this.txb_apellido.Name = "txb_apellido";
            this.txb_apellido.Size = new System.Drawing.Size(131, 22);
            this.txb_apellido.TabIndex = 17;
            this.txb_apellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_apellido_KeyPress);
            // 
            // txb_direccion
            // 
            this.txb_direccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_direccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txb_direccion.Location = new System.Drawing.Point(123, 65);
            this.txb_direccion.MaxLength = 40;
            this.txb_direccion.Name = "txb_direccion";
            this.txb_direccion.Size = new System.Drawing.Size(131, 22);
            this.txb_direccion.TabIndex = 18;
            // 
            // txb_numeroTelefono
            // 
            this.txb_numeroTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_numeroTelefono.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.txb_numeroTelefono.Location = new System.Drawing.Point(123, 93);
            this.txb_numeroTelefono.MaxLength = 20;
            this.txb_numeroTelefono.Name = "txb_numeroTelefono";
            this.txb_numeroTelefono.Size = new System.Drawing.Size(131, 22);
            this.txb_numeroTelefono.TabIndex = 19;
            this.txb_numeroTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_numeroTelefono_KeyPress);
            // 
            // rb_fijo
            // 
            this.rb_fijo.AutoSize = true;
            this.rb_fijo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_fijo.ForeColor = System.Drawing.Color.White;
            this.rb_fijo.Location = new System.Drawing.Point(123, 122);
            this.rb_fijo.Name = "rb_fijo";
            this.rb_fijo.Size = new System.Drawing.Size(50, 21);
            this.rb_fijo.TabIndex = 20;
            this.rb_fijo.Text = "Fijo";
            this.rb_fijo.UseVisualStyleBackColor = true;
            this.rb_fijo.CheckedChanged += new System.EventHandler(this.rb_fijo_CheckedChanged);
            // 
            // rb_celular
            // 
            this.rb_celular.AutoSize = true;
            this.rb_celular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rb_celular.ForeColor = System.Drawing.Color.White;
            this.rb_celular.Location = new System.Drawing.Point(123, 140);
            this.rb_celular.Name = "rb_celular";
            this.rb_celular.Size = new System.Drawing.Size(72, 21);
            this.rb_celular.TabIndex = 21;
            this.rb_celular.Text = "Celular";
            this.rb_celular.UseVisualStyleBackColor = true;
            this.rb_celular.CheckedChanged += new System.EventHandler(this.rb_celular_CheckedChanged);
            // 
            // pnl_agregaroEditar
            // 
            this.pnl_agregaroEditar.Controls.Add(this.cbx_numero);
            this.pnl_agregaroEditar.Controls.Add(this.cbx_direccion);
            this.pnl_agregaroEditar.Controls.Add(this.btn_agregarTelefono);
            this.pnl_agregaroEditar.Controls.Add(this.btn_cancelar);
            this.pnl_agregaroEditar.Controls.Add(this.btn_listo);
            this.pnl_agregaroEditar.Controls.Add(this.lbl_nombre);
            this.pnl_agregaroEditar.Controls.Add(this.rb_celular);
            this.pnl_agregaroEditar.Controls.Add(this.lbl_Apellido);
            this.pnl_agregaroEditar.Controls.Add(this.rb_fijo);
            this.pnl_agregaroEditar.Controls.Add(this.lbl_direccion);
            this.pnl_agregaroEditar.Controls.Add(this.txb_numeroTelefono);
            this.pnl_agregaroEditar.Controls.Add(this.lbl_tipoTelefono);
            this.pnl_agregaroEditar.Controls.Add(this.txb_direccion);
            this.pnl_agregaroEditar.Controls.Add(this.lbl_numero);
            this.pnl_agregaroEditar.Controls.Add(this.txb_apellido);
            this.pnl_agregaroEditar.Controls.Add(this.txb_nombre);
            this.pnl_agregaroEditar.Location = new System.Drawing.Point(41, 47);
            this.pnl_agregaroEditar.Name = "pnl_agregaroEditar";
            this.pnl_agregaroEditar.Size = new System.Drawing.Size(456, 171);
            this.pnl_agregaroEditar.TabIndex = 22;
            // 
            // cbx_numero
            // 
            this.cbx_numero.AutoSize = true;
            this.cbx_numero.Location = new System.Drawing.Point(260, 96);
            this.cbx_numero.Name = "cbx_numero";
            this.cbx_numero.Size = new System.Drawing.Size(18, 17);
            this.cbx_numero.TabIndex = 28;
            this.cbx_numero.UseVisualStyleBackColor = true;
            this.cbx_numero.CheckedChanged += new System.EventHandler(this.cbx_numero_CheckedChanged);
            // 
            // cbx_direccion
            // 
            this.cbx_direccion.AutoSize = true;
            this.cbx_direccion.Location = new System.Drawing.Point(260, 68);
            this.cbx_direccion.Name = "cbx_direccion";
            this.cbx_direccion.Size = new System.Drawing.Size(18, 17);
            this.cbx_direccion.TabIndex = 27;
            this.cbx_direccion.UseVisualStyleBackColor = true;
            this.cbx_direccion.CheckedChanged += new System.EventHandler(this.cbx_direccion_CheckedChanged);
            // 
            // btn_agregarTelefono
            // 
            this.btn_agregarTelefono.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_agregarTelefono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarTelefono.FlatAppearance.BorderSize = 0;
            this.btn_agregarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_agregarTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_agregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregarTelefono.ForeColor = System.Drawing.Color.White;
            this.btn_agregarTelefono.Location = new System.Drawing.Point(325, 9);
            this.btn_agregarTelefono.Name = "btn_agregarTelefono";
            this.btn_agregarTelefono.Size = new System.Drawing.Size(128, 50);
            this.btn_agregarTelefono.TabIndex = 26;
            this.btn_agregarTelefono.Text = "Agregar Teléfono";
            this.btn_agregarTelefono.UseVisualStyleBackColor = false;
            this.btn_agregarTelefono.Click += new System.EventHandler(this.btn_agregarTelefono_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Location = new System.Drawing.Point(325, 62);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(128, 50);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_listo
            // 
            this.btn_listo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_listo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_listo.FlatAppearance.BorderSize = 0;
            this.btn_listo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_listo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listo.ForeColor = System.Drawing.Color.White;
            this.btn_listo.Location = new System.Drawing.Point(325, 118);
            this.btn_listo.Name = "btn_listo";
            this.btn_listo.Size = new System.Drawing.Size(128, 50);
            this.btn_listo.TabIndex = 24;
            this.btn_listo.Text = "Listo";
            this.btn_listo.UseVisualStyleBackColor = false;
            this.btn_listo.Click += new System.EventHandler(this.btn_listo_Click);
            // 
            // pnl_dni
            // 
            this.pnl_dni.Controls.Add(this.lbl_dni);
            this.pnl_dni.Controls.Add(this.txb_dni);
            this.pnl_dni.Location = new System.Drawing.Point(41, 23);
            this.pnl_dni.Name = "pnl_dni";
            this.pnl_dni.Size = new System.Drawing.Size(327, 27);
            this.pnl_dni.TabIndex = 23;
            // 
            // pnl_botonesPrinc
            // 
            this.pnl_botonesPrinc.Controls.Add(this.btn_buscar);
            this.pnl_botonesPrinc.Controls.Add(this.btn_AgregarContacto);
            this.pnl_botonesPrinc.Controls.Add(this.btn_editarContacto);
            this.pnl_botonesPrinc.Location = new System.Drawing.Point(503, 8);
            this.pnl_botonesPrinc.Name = "pnl_botonesPrinc";
            this.pnl_botonesPrinc.Size = new System.Drawing.Size(157, 178);
            this.pnl_botonesPrinc.TabIndex = 24;
            // 
            // eleccion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.eleccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.eleccion.HeaderText = ".";
            this.eleccion.Name = "eleccion";
            this.eleccion.ReadOnly = true;
            this.eleccion.Width = 30;
            // 
            // DNIColumn
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.DNIColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.DNIColumn.HeaderText = "DNI";
            this.DNIColumn.Name = "DNIColumn";
            this.DNIColumn.ReadOnly = true;
            this.DNIColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // nombreColumn
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.nombreColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.nombreColumn.HeaderText = "Nombre";
            this.nombreColumn.Name = "nombreColumn";
            this.nombreColumn.ReadOnly = true;
            // 
            // apellidoColumn
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.apellidoColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.apellidoColumn.HeaderText = "Apellido";
            this.apellidoColumn.Name = "apellidoColumn";
            this.apellidoColumn.ReadOnly = true;
            // 
            // direccionColumn
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.direccionColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.direccionColumn.HeaderText = "Dirección";
            this.direccionColumn.Name = "direccionColumn";
            this.direccionColumn.ReadOnly = true;
            // 
            // numerotelColumn
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.numerotelColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.numerotelColumn.HeaderText = "Número";
            this.numerotelColumn.Name = "numerotelColumn";
            this.numerotelColumn.ReadOnly = true;
            // 
            // tipoTelColumn
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.tipoTelColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.tipoTelColumn.HeaderText = "Tipo de Teléfono";
            this.tipoTelColumn.Name = "tipoTelColumn";
            this.tipoTelColumn.ReadOnly = true;
            // 
            // idtel
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            this.idtel.DefaultCellStyle = dataGridViewCellStyle9;
            this.idtel.HeaderText = "ID Télefono";
            this.idtel.Name = "idtel";
            this.idtel.Width = 10;
            // 
            // EditarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(672, 523);
            this.Controls.Add(this.pnl_botonesPrinc);
            this.Controls.Add(this.pnl_dni);
            this.Controls.Add(this.pnl_agregaroEditar);
            this.Controls.Add(this.dgv_editarDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditarDatos";
            this.Text = "EditarDatos";
            this.Load += new System.EventHandler(this.EditarDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_editarDatos)).EndInit();
            this.pnl_agregaroEditar.ResumeLayout(false);
            this.pnl_agregaroEditar.PerformLayout();
            this.pnl_dni.ResumeLayout(false);
            this.pnl_dni.PerformLayout();
            this.pnl_botonesPrinc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_editarDatos;
        private System.Windows.Forms.Button btn_AgregarContacto;
        private System.Windows.Forms.Button btn_editarContacto;
        private System.Windows.Forms.Label lbl_dni;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_Apellido;
        private System.Windows.Forms.Label lbl_direccion;
        private System.Windows.Forms.Label lbl_tipoTelefono;
        private System.Windows.Forms.Label lbl_numero;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox txb_nombre;
        private System.Windows.Forms.TextBox txb_apellido;
        private System.Windows.Forms.TextBox txb_direccion;
        private System.Windows.Forms.TextBox txb_numeroTelefono;
        private System.Windows.Forms.RadioButton rb_fijo;
        private System.Windows.Forms.RadioButton rb_celular;
        private System.Windows.Forms.Panel pnl_agregaroEditar;
        private System.Windows.Forms.Panel pnl_dni;
        private System.Windows.Forms.Button btn_listo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_agregarTelefono;
        private System.Windows.Forms.CheckBox cbx_numero;
        private System.Windows.Forms.CheckBox cbx_direccion;
        private System.Windows.Forms.Panel pnl_botonesPrinc;
        private System.Windows.Forms.DataGridViewCheckBoxColumn eleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNIColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerotelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoTelColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtel;
    }
}