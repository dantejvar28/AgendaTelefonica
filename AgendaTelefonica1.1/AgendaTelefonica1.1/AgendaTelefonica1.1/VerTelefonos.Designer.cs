namespace AgendaTelefonica1._1
{
    partial class VerTelefonos
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
            this.dgv_Telefonos = new System.Windows.Forms.DataGridView();
            this.document = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_volver = new System.Windows.Forms.Button();
            this.pnl_VerTel = new System.Windows.Forms.Panel();
            this.pnl_verOcultar = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telefonos)).BeginInit();
            this.pnl_VerTel.SuspendLayout();
            this.pnl_verOcultar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Telefonos
            // 
            this.dgv_Telefonos.AllowUserToAddRows = false;
            this.dgv_Telefonos.AllowUserToDeleteRows = false;
            this.dgv_Telefonos.AllowUserToResizeColumns = false;
            this.dgv_Telefonos.AllowUserToResizeRows = false;
            this.dgv_Telefonos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.dgv_Telefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Telefonos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgv_Telefonos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(48)))), ((int)(((byte)(97)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Telefonos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Telefonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_Telefonos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.document,
            this.Nombre,
            this.Apellido,
            this.tipo_tel,
            this.telefono});
            this.dgv_Telefonos.GridColor = System.Drawing.Color.White;
            this.dgv_Telefonos.Location = new System.Drawing.Point(12, 132);
            this.dgv_Telefonos.Name = "dgv_Telefonos";
            this.dgv_Telefonos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgv_Telefonos.RowTemplate.Height = 24;
            this.dgv_Telefonos.Size = new System.Drawing.Size(650, 379);
            this.dgv_Telefonos.TabIndex = 1;
            // 
            // document
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.document.DefaultCellStyle = dataGridViewCellStyle2;
            this.document.HeaderText = "DNI";
            this.document.Name = "document";
            this.document.ReadOnly = true;
            // 
            // Nombre
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle3;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Apellido.DefaultCellStyle = dataGridViewCellStyle4;
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // tipo_tel
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.tipo_tel.DefaultCellStyle = dataGridViewCellStyle5;
            this.tipo_tel.HeaderText = "Tipo de Teléfono";
            this.tipo_tel.Name = "tipo_tel";
            this.tipo_tel.ReadOnly = true;
            // 
            // telefono
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.telefono.DefaultCellStyle = dataGridViewCellStyle6;
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            this.telefono.ReadOnly = true;
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_volver.FlatAppearance.BorderSize = 0;
            this.btn_volver.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(156)))), ((int)(((byte)(112)))));
            this.btn_volver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(129)))), ((int)(((byte)(100)))));
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.ForeColor = System.Drawing.Color.White;
            this.btn_volver.Location = new System.Drawing.Point(249, 29);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(128, 70);
            this.btn_volver.TabIndex = 4;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // pnl_VerTel
            // 
            this.pnl_VerTel.Controls.Add(this.pnl_verOcultar);
            this.pnl_VerTel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_VerTel.Location = new System.Drawing.Point(0, 0);
            this.pnl_VerTel.Name = "pnl_VerTel";
            this.pnl_VerTel.Size = new System.Drawing.Size(672, 523);
            this.pnl_VerTel.TabIndex = 5;
            // 
            // pnl_verOcultar
            // 
            this.pnl_verOcultar.Controls.Add(this.dgv_Telefonos);
            this.pnl_verOcultar.Controls.Add(this.btn_volver);
            this.pnl_verOcultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_verOcultar.Location = new System.Drawing.Point(0, 0);
            this.pnl_verOcultar.Name = "pnl_verOcultar";
            this.pnl_verOcultar.Size = new System.Drawing.Size(672, 523);
            this.pnl_verOcultar.TabIndex = 5;
            // 
            // VerTelefonos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(672, 523);
            this.Controls.Add(this.pnl_VerTel);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "VerTelefonos";
            this.Text = "VerTelefonos";
            this.Load += new System.EventHandler(this.VerTelefonos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Telefonos)).EndInit();
            this.pnl_VerTel.ResumeLayout(false);
            this.pnl_verOcultar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Telefonos;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Panel pnl_VerTel;
        private System.Windows.Forms.Panel pnl_verOcultar;
        private System.Windows.Forms.DataGridViewTextBoxColumn document;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    }
}