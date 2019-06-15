namespace RegistroAnalisisMedico.UI.Registro
{
    partial class rAnalisis
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AnalisiIdnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.FechadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Nuevo = new System.Windows.Forms.Button();
            this.Guardar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Buscar = new System.Windows.Forms.Button();
            this.DetalledataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TipoAnalisicomboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Remover = new System.Windows.Forms.Button();
            this.ResultadotextBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.UsuarioscomboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AnalisiIdnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "AnalisisId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Usuario";
            // 
            // AnalisiIdnumericUpDown1
            // 
            this.AnalisiIdnumericUpDown1.Location = new System.Drawing.Point(77, 10);
            this.AnalisiIdnumericUpDown1.Name = "AnalisiIdnumericUpDown1";
            this.AnalisiIdnumericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.AnalisiIdnumericUpDown1.TabIndex = 8;
            // 
            // FechadateTimePicker1
            // 
            this.FechadateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechadateTimePicker1.Location = new System.Drawing.Point(77, 48);
            this.FechadateTimePicker1.Name = "FechadateTimePicker1";
            this.FechadateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.FechadateTimePicker1.TabIndex = 9;
            this.FechadateTimePicker1.ValueChanged += new System.EventHandler(this.FechadateTimePicker1_ValueChanged);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(30, 415);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(75, 23);
            this.Nuevo.TabIndex = 14;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(163, 415);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 15;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(299, 415);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(75, 23);
            this.Eliminar.TabIndex = 16;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(143, 7);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 17;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // DetalledataGridView1
            // 
            this.DetalledataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetalledataGridView1.Location = new System.Drawing.Point(6, 63);
            this.DetalledataGridView1.Name = "DetalledataGridView1";
            this.DetalledataGridView1.Size = new System.Drawing.Size(380, 173);
            this.DetalledataGridView1.TabIndex = 18;
            this.DetalledataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DetalledataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TipoAnalisicomboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Remover);
            this.groupBox1.Controls.Add(this.ResultadotextBox2);
            this.groupBox1.Controls.Add(this.DetalledataGridView1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(16, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 276);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // TipoAnalisicomboBox1
            // 
            this.TipoAnalisicomboBox1.FormattingEnabled = true;
            this.TipoAnalisicomboBox1.Location = new System.Drawing.Point(81, 22);
            this.TipoAnalisicomboBox1.Name = "TipoAnalisicomboBox1";
            this.TipoAnalisicomboBox1.Size = new System.Drawing.Size(94, 21);
            this.TipoAnalisicomboBox1.TabIndex = 22;
            this.TipoAnalisicomboBox1.SelectedIndexChanged += new System.EventHandler(this.TipoAnalisicomboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(349, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(37, 27);
            this.button2.TabIndex = 21;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Remover
            // 
            this.Remover.Location = new System.Drawing.Point(6, 242);
            this.Remover.Name = "Remover";
            this.Remover.Size = new System.Drawing.Size(75, 23);
            this.Remover.TabIndex = 20;
            this.Remover.Text = "Remover";
            this.Remover.UseVisualStyleBackColor = true;
            this.Remover.Click += new System.EventHandler(this.Remover_Click);
            // 
            // ResultadotextBox2
            // 
            this.ResultadotextBox2.Location = new System.Drawing.Point(256, 19);
            this.ResultadotextBox2.Multiline = true;
            this.ResultadotextBox2.Name = "ResultadotextBox2";
            this.ResultadotextBox2.Size = new System.Drawing.Size(87, 23);
            this.ResultadotextBox2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tipo";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // UsuarioscomboBox2
            // 
            this.UsuarioscomboBox2.FormattingEnabled = true;
            this.UsuarioscomboBox2.Location = new System.Drawing.Point(77, 80);
            this.UsuarioscomboBox2.Name = "UsuarioscomboBox2";
            this.UsuarioscomboBox2.Size = new System.Drawing.Size(333, 21);
            this.UsuarioscomboBox2.TabIndex = 20;
            this.UsuarioscomboBox2.SelectedIndexChanged += new System.EventHandler(this.UsuarioscomboBox2_SelectedIndexChanged);
            // 
            // rAnalisis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 450);
            this.Controls.Add(this.UsuarioscomboBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.FechadateTimePicker1);
            this.Controls.Add(this.AnalisiIdnumericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "rAnalisis";
            this.Text = "rAnalisis";
            this.Load += new System.EventHandler(this.RAnalisis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AnalisiIdnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalledataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown AnalisiIdnumericUpDown1;
        private System.Windows.Forms.DateTimePicker FechadateTimePicker1;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.DataGridView DetalledataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Remover;
        private System.Windows.Forms.TextBox ResultadotextBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ComboBox TipoAnalisicomboBox1;
        private System.Windows.Forms.ComboBox UsuarioscomboBox2;
    }
}