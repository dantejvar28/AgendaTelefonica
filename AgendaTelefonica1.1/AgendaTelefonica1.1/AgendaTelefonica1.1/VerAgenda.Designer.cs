namespace AgendaTelefonica1._1
{
    partial class VerAgenda
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
            this.dgv_verAgenda = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txb_dniBuscar = new System.Windows.Forms.TextBox();
            this.lbl_dniBuscar = new System.Windows.Forms.Label();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_VerTelefonos = new System.Windows.Forms.Button();
            this.btn_mostrarTodo = new System.Windows.Forms.Button();
            this.pnl_VerAgenda = new System.Windows.Forms.Panel();
            this.pnl_verage = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verAgenda)).BeginInit();
            this.pnl_VerAgenda.SuspendLayout();
            this.pnl_verage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_verAgenda
            // 
            this.dgv_verAgenda.AllowUserToAddRows = false;
            this.dgv_verAgenda.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgv_verAgenda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_verAgenda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_verAgenda.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_verAgenda.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_verAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_verAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Direccion});
            this.dgv_verAgenda.Location = new System.Drawing.Point(12, 125);
            this.dgv_verAgenda.Name = "dgv_verAgenda";
            this.dgv_verAgenda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_verAgenda.RowTemplate.Height = 24;
            this.dgv_verAgenda.Size = new System.Drawing.Size(635, 374);
            this.dgv_verAgenda.TabIndex = 0;
            this.dgv_verAgenda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_verAgenda_CellContentClick);
            // 
            // Seleccion
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.NullValue = false;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Seleccion.DefaultCellStyle = dataGridViewCellStyle2;
            this.Seleccion.HeaderText = "Elegir";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccion.Width = 40;
            // 
            // DNI
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.DNI.DefaultCellStyle = dataGridViewCellStyle3;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 70;
            // 
            // Nombre
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle4;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle5;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Direccion
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Direccion.DefaultCellStyle = dataGridViewCellStyle6;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 160;
            // 
            // txb_dniBuscar
            // 
            this.txb_dniBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_dniBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_dniBuscar.ForeColor = System.Drawing.Color.White;
            this.txb_dniBuscar.Location = new System.Drawing.Point(64, 33);
            this.txb_dniBuscar.MaxLength = 8;
            this.txb_dniBuscar.Name = "txb_dniBuscar";
            this.txb_dniBuscar.Size = new System.Drawing.Size(162, 27);
            this.txb_dniBuscar.TabIndex = 1;
            this.txb_dniBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_dniBuscar_KeyPress);
            // 
            // lbl_dniBuscar
            // 
            this.lbl_dniBuscar.AutoSize = true;
            this.lbl_dniBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dniBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_dniBuscar.Location = new System.Drawing.Point(15, 36);
            this.lbl_dniBuscar.Name = "lbl_dniBuscar";
            this.lbl_dniBuscar.Size = new System.Drawing.Size(43, 20);
            this.lbl_dniBuscar.TabIndex = 2;
            this.lbl_dniBuscar.Text = "DNI:";
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Buscar.FlatAppearance.BorderSize = 0;
            this.btn_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(378, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(128, 70);
            this.btn_Buscar.TabIndex = 3;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_VerTelefonos
            // 
            this.btn_VerTelefonos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_VerTelefonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_VerTelefonos.FlatAppearance.BorderSize = 0;
            this.btn_VerTelefonos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_VerTelefonos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_VerTelefonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VerTelefonos.ForeColor = System.Drawing.Color.White;
            this.btn_VerTelefonos.Location = new System.Drawing.Point(512, 12);
            this.btn_VerTelefonos.Name = "btn_VerTelefonos";
            this.btn_VerTelefonos.Size = new System.Drawing.Size(128, 70);
            this.btn_VerTelefonos.TabIndex = 4;
            this.btn_VerTelefonos.Text = "Ver Teléfonos";
            this.btn_VerTelefonos.UseVisualStyleBackColor = false;
            this.btn_VerTelefonos.Click += new System.EventHandler(this.btn_VerTelefonos_Click);
            // 
            // btn_mostrarTodo
            // 
            this.btn_mostrarTodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_mostrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mostrarTodo.FlatAppearance.BorderSize = 0;
            this.btn_mostrarTodo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_mostrarTodo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_mostrarTodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mostrarTodo.ForeColor = System.Drawing.Color.White;
            this.btn_mostrarTodo.Location = new System.Drawing.Point(244, 12);
            this.btn_mostrarTodo.Name = "btn_mostrarTodo";
            this.btn_mostrarTodo.Size = new System.Drawing.Size(128, 70);
            this.btn_mostrarTodo.TabIndex = 5;
            this.btn_mostrarTodo.Text = "Ver Todo";
            this.btn_mostrarTodo.UseVisualStyleBackColor = false;
            this.btn_mostrarTodo.Click += new System.EventHandler(this.btn_mostrarTodo_Click);
            // 
            // pnl_VerAgenda
            // 
            this.pnl_VerAgenda.Controls.Add(this.pnl_verage);
            this.pnl_VerAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_VerAgenda.Location = new System.Drawing.Point(0, 0);
            this.pnl_VerAgenda.Name = "pnl_VerAgenda";
            this.pnl_VerAgenda.Size = new System.Drawing.Size(672, 523);
            this.pnl_VerAgenda.TabIndex = 6;
            // 
            // pnl_verage
            // 
            this.pnl_verage.Controls.Add(this.dgv_verAgenda);
            this.pnl_verage.Controls.Add(this.lbl_dniBuscar);
            this.pnl_verage.Controls.Add(this.btn_mostrarTodo);
            this.pnl_verage.Controls.Add(this.txb_dniBuscar);
            this.pnl_verage.Controls.Add(this.btn_VerTelefonos);
            this.pnl_verage.Controls.Add(this.btn_Buscar);
            this.pnl_verage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_verage.Location = new System.Drawing.Point(0, 0);
            this.pnl_verage.Name = "pnl_verage";
            this.pnl_verage.Size = new System.Drawing.Size(672, 523);
            this.pnl_verage.TabIndex = 6;
            // 
            // VerAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(672, 523);
            this.Controls.Add(this.pnl_VerAgenda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerAgenda";
            this.Text = "VerAgenda";
            this.Load += new System.EventHandler(this.VerAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_verAgenda)).EndInit();
            this.pnl_VerAgenda.ResumeLayout(false);
            this.pnl_verage.ResumeLayout(false);
            this.pnl_verage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_verAgenda;
        private System.Windows.Forms.TextBox txb_dniBuscar;
        private System.Windows.Forms.Label lbl_dniBuscar;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_VerTelefonos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Button btn_mostrarTodo;
        private System.Windows.Forms.Panel pnl_VerAgenda;
        private System.Windows.Forms.Panel pnl_verage;
    }
}