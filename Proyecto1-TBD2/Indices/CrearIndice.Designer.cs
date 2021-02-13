namespace Proyecto1_TBD2.Indices {
    partial class CrearIndice {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearIndice));
            this.tabla = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.data_set = new System.Windows.Forms.DataGridView();
            this.Expresion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Orden = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ddl = new System.Windows.Forms.RichTextBox();
            this.nombre_indice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.caja = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.caja2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabla.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_set)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla
            // 
            this.tabla.Controls.Add(this.tabPage1);
            this.tabla.Controls.Add(this.tabPage2);
            this.tabla.Font = new System.Drawing.Font("Verdana", 12F);
            this.tabla.Location = new System.Drawing.Point(117, 204);
            this.tabla.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabla.Name = "tabla";
            this.tabla.SelectedIndex = 0;
            this.tabla.Size = new System.Drawing.Size(777, 386);
            this.tabla.TabIndex = 0;
            this.tabla.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.data_set);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(769, 348);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Indices";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // data_set
            // 
            this.data_set.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_set.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_set.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Expresion,
            this.Orden});
            this.data_set.Dock = System.Windows.Forms.DockStyle.Fill;
            this.data_set.Location = new System.Drawing.Point(4, 4);
            this.data_set.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_set.Name = "data_set";
            this.data_set.RowHeadersWidth = 51;
            this.data_set.Size = new System.Drawing.Size(761, 340);
            this.data_set.TabIndex = 0;
            // 
            // Expresion
            // 
            this.Expresion.HeaderText = "Expresion";
            this.Expresion.MinimumWidth = 6;
            this.Expresion.Name = "Expresion";
            // 
            // Orden
            // 
            this.Orden.HeaderText = "Orden";
            this.Orden.Items.AddRange(new object[] {
            "NINGUNO",
            "ASC",
            "DESC"});
            this.Orden.MinimumWidth = 6;
            this.Orden.Name = "Orden";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ddl);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(769, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "DDL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ddl
            // 
            this.ddl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ddl.Location = new System.Drawing.Point(4, 4);
            this.ddl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ddl.Name = "ddl";
            this.ddl.Size = new System.Drawing.Size(761, 340);
            this.ddl.TabIndex = 0;
            this.ddl.Text = "";
            // 
            // nombre_indice
            // 
            this.nombre_indice.Font = new System.Drawing.Font("Verdana", 12F);
            this.nombre_indice.Location = new System.Drawing.Point(400, 70);
            this.nombre_indice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombre_indice.Name = "nombre_indice";
            this.nombre_indice.Size = new System.Drawing.Size(339, 32);
            this.nombre_indice.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F);
            this.label1.Location = new System.Drawing.Point(154, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre de Indice";
            // 
            // caja
            // 
            this.caja.Font = new System.Drawing.Font("Verdana", 12F);
            this.caja.FormattingEnabled = true;
            this.caja.Location = new System.Drawing.Point(400, 119);
            this.caja.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caja.Name = "caja";
            this.caja.Size = new System.Drawing.Size(339, 33);
            this.caja.TabIndex = 3;
            this.caja.SelectedIndexChanged += new System.EventHandler(this.caja_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F);
            this.label2.Location = new System.Drawing.Point(154, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de Tabla";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LimeGreen;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(212, 613);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 45);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Indice";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F);
            this.label3.Location = new System.Drawing.Point(154, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tipo de indice";
            // 
            // caja2
            // 
            this.caja2.Font = new System.Drawing.Font("Verdana", 12F);
            this.caja2.FormattingEnabled = true;
            this.caja2.Items.AddRange(new object[] {
            "NO UNICO",
            "UNICO"});
            this.caja2.Location = new System.Drawing.Point(400, 164);
            this.caja2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caja2.Name = "caja2";
            this.caja2.Size = new System.Drawing.Size(339, 33);
            this.caja2.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Red;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(661, 613);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(130, 45);
            this.button2.TabIndex = 8;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(831, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 160);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CrearIndice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caja2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.caja);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nombre_indice);
            this.Controls.Add(this.tabla);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CrearIndice";
            this.Text = "CrearIndice";
            this.Load += new System.EventHandler(this.CrearIndice_Load);
            this.tabla.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_set)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabla;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox nombre_indice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox caja;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView data_set;
        private System.Windows.Forms.DataGridViewComboBoxColumn Expresion;
        private System.Windows.Forms.DataGridViewComboBoxColumn Orden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox caja2;
        private System.Windows.Forms.RichTextBox ddl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}