namespace Proyecto1_TBD2.Procedimientos {
    partial class ModificarProcedimiento {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarProcedimiento));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Modificar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.richTextBox1.Location = new System.Drawing.Point(125, 148);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(784, 404);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // Modificar
            // 
            this.Modificar.BackColor = System.Drawing.Color.LimeGreen;
            this.Modificar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modificar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Modificar.Location = new System.Drawing.Point(401, 591);
            this.Modificar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Modificar.Name = "Modificar";
            this.Modificar.Size = new System.Drawing.Size(222, 64);
            this.Modificar.TabIndex = 1;
            this.Modificar.Text = "Modificar Procedimiento";
            this.Modificar.UseVisualStyleBackColor = false;
            this.Modificar.Click += new System.EventHandler(this.Modificar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(833, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 122);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // ModificarProcedimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 686);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Modificar);
            this.Controls.Add(this.richTextBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ModificarProcedimiento";
            this.Text = "ModificarProcedimiento";
            this.Load += new System.EventHandler(this.ModificarProcedimiento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button Modificar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}