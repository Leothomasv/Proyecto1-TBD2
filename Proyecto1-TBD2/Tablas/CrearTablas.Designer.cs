namespace Proyecto1_TBD2.Tablas {
    partial class CrearTablas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ComboBox comboBox1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearTablas));
            this.label1 = new System.Windows.Forms.Label();
            this.nombre_tabla = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tabla = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.contenido = new System.Windows.Forms.DataGridView();
            this.PK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_dato = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tamano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.escala = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nullo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.caja = new System.Windows.Forms.RichTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            this.Tabla.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contenido)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comboBox1.FormattingEnabled = true;
            comboBox1.IntegralHeight = false;
            comboBox1.Location = new System.Drawing.Point(329, 54);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(401, 26);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(155, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Esquema:";
            // 
            // nombre_tabla
            // 
            this.nombre_tabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_tabla.Location = new System.Drawing.Point(329, 106);
            this.nombre_tabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre_tabla.Name = "nombre_tabla";
            this.nombre_tabla.Size = new System.Drawing.Size(401, 24);
            this.nombre_tabla.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(169, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // Tabla
            // 
            this.Tabla.Controls.Add(this.tabPage1);
            this.Tabla.Controls.Add(this.tabPage2);
            this.Tabla.Font = new System.Drawing.Font("Verdana", 12F);
            this.Tabla.Location = new System.Drawing.Point(77, 190);
            this.Tabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Tabla.Name = "Tabla";
            this.Tabla.SelectedIndex = 0;
            this.Tabla.Size = new System.Drawing.Size(812, 415);
            this.Tabla.TabIndex = 4;
            this.Tabla.SelectedIndexChanged += new System.EventHandler(this.Tabla_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.contenido);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(804, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tablas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // contenido
            // 
            this.contenido.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.contenido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contenido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PK,
            this.nombre,
            this.tipo_dato,
            this.tamano,
            this.escala,
            this.Nullo});
            this.contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenido.Location = new System.Drawing.Point(4, 4);
            this.contenido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contenido.Name = "contenido";
            this.contenido.RowHeadersWidth = 51;
            this.contenido.Size = new System.Drawing.Size(796, 369);
            this.contenido.TabIndex = 0;
            this.contenido.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.contenido_DefaultValuesNeeded);
            // 
            // PK
            // 
            this.PK.HeaderText = "PK";
            this.PK.MinimumWidth = 6;
            this.PK.Name = "PK";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            // 
            // tipo_dato
            // 
            this.tipo_dato.HeaderText = "Tipo de dato";
            this.tipo_dato.Items.AddRange(new object[] {
            "BOOLEAN",
            "VARCHAR",
            "INT",
            "DECIMAL",
            "DOUBLE"});
            this.tipo_dato.MinimumWidth = 6;
            this.tipo_dato.Name = "tipo_dato";
            // 
            // tamano
            // 
            this.tamano.HeaderText = "Tamaño";
            this.tamano.MinimumWidth = 6;
            this.tamano.Name = "tamano";
            // 
            // escala
            // 
            this.escala.HeaderText = "Escala";
            this.escala.MinimumWidth = 6;
            this.escala.Name = "escala";
            // 
            // Nullo
            // 
            this.Nullo.HeaderText = "Nullo";
            this.Nullo.MinimumWidth = 6;
            this.Nullo.Name = "Nullo";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.caja);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(804, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DDL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // caja
            // 
            this.caja.Dock = System.Windows.Forms.DockStyle.Fill;
            this.caja.Location = new System.Drawing.Point(4, 4);
            this.caja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(796, 369);
            this.caja.TabIndex = 0;
            this.caja.Text = "";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "iconfinder_sign-add_299068.png");
            this.imageList1.Images.SetKeyName(1, "iconfinder_f-cross_256_282471.png");
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(424, 613);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 49);
            this.button2.TabIndex = 5;
            this.button2.Text = "Crear Tabla";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.ImageIndex = 1;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(888, 260);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 28);
            this.button3.TabIndex = 6;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(841, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 162);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.ImageIndex = 0;
            this.button1.ImageList = this.imageList1;
            this.button1.Location = new System.Drawing.Point(888, 224);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 28);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CrearTablas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tabla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombre_tabla);
            this.Controls.Add(this.label1);
            this.Controls.Add(comboBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearTablas";
            this.Text = "CrearTablas";
            this.Load += new System.EventHandler(this.CrearTablas_Load);
            this.Tabla.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contenido)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nombre_tabla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl Tabla;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView contenido;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RichTextBox caja;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PK;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewComboBoxColumn tipo_dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamano;
        private System.Windows.Forms.DataGridViewTextBoxColumn escala;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nullo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}