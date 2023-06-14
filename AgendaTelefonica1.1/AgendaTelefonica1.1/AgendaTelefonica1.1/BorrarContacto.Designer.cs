namespace AgendaTelefonica1._1
{
    partial class BorrarContacto
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_borrarContacto = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_dniBuscar = new System.Windows.Forms.Label();
            this.txb_dniBuscar = new System.Windows.Forms.TextBox();
            this.btn_mostrarTodo = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            this.btn_borrarContacto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarContacto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_borrarContacto
            // 
            this.dgv_borrarContacto.AllowUserToAddRows = false;
            this.dgv_borrarContacto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgv_borrarContacto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_borrarContacto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_borrarContacto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_borrarContacto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_borrarContacto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_borrarContacto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.DNI,
            this.Nombre,
            this.Apellido,
            this.Direccion});
            this.dgv_borrarContacto.Location = new System.Drawing.Point(10, 110);
            this.dgv_borrarContacto.Name = "dgv_borrarContacto";
            this.dgv_borrarContacto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_borrarContacto.RowTemplate.Height = 24;
            this.dgv_borrarContacto.Size = new System.Drawing.Size(635, 351);
            this.dgv_borrarContacto.TabIndex = 1;
            this.dgv_borrarContacto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_borrarContacto_CellContentClick);
            // 
            // Seleccion
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle14.NullValue = false;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Seleccion.DefaultCellStyle = dataGridViewCellStyle14;
            this.Seleccion.HeaderText = "Elegir";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Seleccion.Width = 40;
            // 
            // DNI
            // 
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.DNI.DefaultCellStyle = dataGridViewCellStyle15;
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 70;
            // 
            // Nombre
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle16;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle17;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Direccion
            // 
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Direccion.DefaultCellStyle = dataGridViewCellStyle18;
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 160;
            // 
            // lbl_dniBuscar
            // 
            this.lbl_dniBuscar.AutoSize = true;
            this.lbl_dniBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dniBuscar.ForeColor = System.Drawing.Color.White;
            this.lbl_dniBuscar.Location = new System.Drawing.Point(12, 38);
            this.lbl_dniBuscar.Name = "lbl_dniBuscar";
            this.lbl_dniBuscar.Size = new System.Drawing.Size(43, 20);
            this.lbl_dniBuscar.TabIndex = 3;
            this.lbl_dniBuscar.Text = "DNI:";
            // 
            // txb_dniBuscar
            // 
            this.txb_dniBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.txb_dniBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_dniBuscar.ForeColor = System.Drawing.Color.White;
            this.txb_dniBuscar.Location = new System.Drawing.Point(61, 35);
            this.txb_dniBuscar.MaxLength = 8;
            this.txb_dniBuscar.Name = "txb_dniBuscar";
            this.txb_dniBuscar.Size = new System.Drawing.Size(162, 27);
            this.txb_dniBuscar.TabIndex = 4;
            this.txb_dniBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txb_dniBuscar_KeyPress);
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
            this.btn_mostrarTodo.Location = new System.Drawing.Point(252, 12);
            this.btn_mostrarTodo.Name = "btn_mostrarTodo";
            this.btn_mostrarTodo.Size = new System.Drawing.Size(128, 70);
            this.btn_mostrarTodo.TabIndex = 6;
            this.btn_mostrarTodo.Text = "Ver Todo";
            this.btn_mostrarTodo.UseVisualStyleBackColor = false;
            this.btn_mostrarTodo.Click += new System.EventHandler(this.btn_mostrarTodo_Click);
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
            this.btn_Buscar.Location = new System.Drawing.Point(386, 12);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(128, 70);
            this.btn_Buscar.TabIndex = 7;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // btn_borrarContacto
            // 
            this.btn_borrarContacto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_borrarContacto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_borrarContacto.FlatAppearance.BorderSize = 0;
            this.btn_borrarContacto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_borrarContacto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(4)))), ((int)(((byte)(4)))));
            this.btn_borrarContacto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_borrarContacto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_borrarContacto.ForeColor = System.Drawing.Color.White;
            this.btn_borrarContacto.Location = new System.Drawing.Point(520, 12);
            this.btn_borrarContacto.Name = "btn_borrarContacto";
            this.btn_borrarContacto.Size = new System.Drawing.Size(128, 70);
            this.btn_borrarContacto.TabIndex = 8;
            this.btn_borrarContacto.Text = "Borrar Contacto";
            this.btn_borrarContacto.UseVisualStyleBackColor = false;
            this.btn_borrarContacto.Click += new System.EventHandler(this.btn_borrarContacto_Click);
            // 
            // BorrarContacto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(654, 476);
            this.Controls.Add(this.btn_borrarContacto);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_mostrarTodo);
            this.Controls.Add(this.txb_dniBuscar);
            this.Controls.Add(this.lbl_dniBuscar);
            this.Controls.Add(this.dgv_borrarContacto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrarContacto";
            this.Text = "BorrarContacto";
            this.Load += new System.EventHandler(this.BorrarContacto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_borrarContacto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_borrarContacto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.Label lbl_dniBuscar;
        private System.Windows.Forms.TextBox txb_dniBuscar;
        private System.Windows.Forms.Button btn_mostrarTodo;
        private System.Windows.Forms.Button btn_Buscar;
        private System.Windows.Forms.Button btn_borrarContacto;
    }
}