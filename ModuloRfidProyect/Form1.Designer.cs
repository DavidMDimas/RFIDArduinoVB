namespace ModuloRfidProyect
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtTag = new System.Windows.Forms.TextBox();
            this.lbIdentificador = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtCarrera = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imageDenegado = new System.Windows.Forms.PictureBox();
            this.imageAcceso = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDenegado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAcceso)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // txtTag
            // 
            this.txtTag.Location = new System.Drawing.Point(89, 58);
            this.txtTag.Name = "txtTag";
            this.txtTag.Size = new System.Drawing.Size(100, 20);
            this.txtTag.TabIndex = 3;
            // 
            // lbIdentificador
            // 
            this.lbIdentificador.AutoSize = true;
            this.lbIdentificador.Location = new System.Drawing.Point(12, 61);
            this.lbIdentificador.Name = "lbIdentificador";
            this.lbIdentificador.Size = new System.Drawing.Size(71, 13);
            this.lbIdentificador.TabIndex = 4;
            this.lbIdentificador.Text = "Identificador: ";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(15, 227);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(89, 117);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Registro de Usuarios";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Matricula:";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(89, 87);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(100, 20);
            this.txtMatricula.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Carrera:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(89, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 15;
            // 
            // txtCarrera
            // 
            this.txtCarrera.Location = new System.Drawing.Point(89, 170);
            this.txtCarrera.Name = "txtCarrera";
            this.txtCarrera.Size = new System.Drawing.Size(100, 20);
            this.txtCarrera.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ModuloRfidProyect.Properties.Resources.Perfil;
            this.pictureBox1.Location = new System.Drawing.Point(235, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 152);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // imageDenegado
            // 
            this.imageDenegado.Image = global::ModuloRfidProyect.Properties.Resources.denegado;
            this.imageDenegado.Location = new System.Drawing.Point(394, 193);
            this.imageDenegado.Name = "imageDenegado";
            this.imageDenegado.Size = new System.Drawing.Size(65, 57);
            this.imageDenegado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageDenegado.TabIndex = 6;
            this.imageDenegado.TabStop = false;
            this.imageDenegado.Visible = false;
            // 
            // imageAcceso
            // 
            this.imageAcceso.Image = global::ModuloRfidProyect.Properties.Resources.acceso1;
            this.imageAcceso.Location = new System.Drawing.Point(394, 193);
            this.imageAcceso.Name = "imageAcceso";
            this.imageAcceso.Size = new System.Drawing.Size(65, 57);
            this.imageAcceso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imageAcceso.TabIndex = 5;
            this.imageAcceso.TabStop = false;
            this.imageAcceso.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 262);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtCarrera);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.imageDenegado);
            this.Controls.Add(this.imageAcceso);
            this.Controls.Add(this.lbIdentificador);
            this.Controls.Add(this.txtTag);
            this.Name = "Form1";
            this.Text = "Proyecto RFID ";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageDenegado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAcceso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtTag;
        private System.Windows.Forms.Label lbIdentificador;
        private System.Windows.Forms.PictureBox imageAcceso;
        private System.Windows.Forms.PictureBox imageDenegado;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtCarrera;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

