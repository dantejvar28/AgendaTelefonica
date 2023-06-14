namespace AgendaTelefonica1._1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lbl_Bienvenida = new System.Windows.Forms.Label();
            this.lbl_cantidadContactos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_NumeroContactos = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Bienvenida
            // 
            this.lbl_Bienvenida.AutoSize = true;
            this.lbl_Bienvenida.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Bienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Bienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(140)))), ((int)(((byte)(52)))));
            this.lbl_Bienvenida.Location = new System.Drawing.Point(118, 84);
            this.lbl_Bienvenida.Name = "lbl_Bienvenida";
            this.lbl_Bienvenida.Size = new System.Drawing.Size(442, 55);
            this.lbl_Bienvenida.TabIndex = 0;
            this.lbl_Bienvenida.Text = "Agenda Telefónica";
            // 
            // lbl_cantidadContactos
            // 
            this.lbl_cantidadContactos.AutoSize = true;
            this.lbl_cantidadContactos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cantidadContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidadContactos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lbl_cantidadContactos.Location = new System.Drawing.Point(175, 238);
            this.lbl_cantidadContactos.Name = "lbl_cantidadContactos";
            this.lbl_cantidadContactos.Size = new System.Drawing.Size(317, 36);
            this.lbl_cantidadContactos.TabIndex = 1;
            this.lbl_cantidadContactos.Text = "Cantidad de Contactos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(222, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_NumeroContactos
            // 
            this.lbl_NumeroContactos.AutoSize = true;
            this.lbl_NumeroContactos.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NumeroContactos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumeroContactos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.lbl_NumeroContactos.Location = new System.Drawing.Point(316, 379);
            this.lbl_NumeroContactos.Name = "lbl_NumeroContactos";
            this.lbl_NumeroContactos.Size = new System.Drawing.Size(47, 32);
            this.lbl_NumeroContactos.TabIndex = 3;
            this.lbl_NumeroContactos.Text = "00";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(158, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(352, 277);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(672, 523);
            this.Controls.Add(this.lbl_NumeroContactos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_cantidadContactos);
            this.Controls.Add(this.lbl_Bienvenida);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Bienvenida;
        private System.Windows.Forms.Label lbl_cantidadContactos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_NumeroContactos;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}