namespace Software_de_Donaciones.Ventanas
{
    partial class Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito
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
            this.boton_iralmenuprincipal = new System.Windows.Forms.Button();
            this.boton_informaciondeladonacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // boton_iralmenuprincipal
            // 
            this.boton_iralmenuprincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_iralmenuprincipal.Location = new System.Drawing.Point(12, 227);
            this.boton_iralmenuprincipal.Name = "boton_iralmenuprincipal";
            this.boton_iralmenuprincipal.Size = new System.Drawing.Size(163, 23);
            this.boton_iralmenuprincipal.TabIndex = 0;
            this.boton_iralmenuprincipal.Text = "<- Ir al Menú Principal";
            this.boton_iralmenuprincipal.UseVisualStyleBackColor = true;
            this.boton_iralmenuprincipal.Click += new System.EventHandler(this.boton_iralmenuprincipal_Click);
            // 
            // boton_informaciondeladonacion
            // 
            this.boton_informaciondeladonacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_informaciondeladonacion.Location = new System.Drawing.Point(155, 178);
            this.boton_informaciondeladonacion.Name = "boton_informaciondeladonacion";
            this.boton_informaciondeladonacion.Size = new System.Drawing.Size(264, 34);
            this.boton_informaciondeladonacion.TabIndex = 1;
            this.boton_informaciondeladonacion.Text = "VER INFORMACIÓN DE LA DONACIÓN";
            this.boton_informaciondeladonacion.UseVisualStyleBackColor = true;
            this.boton_informaciondeladonacion.Click += new System.EventHandler(this.boton_informaciondeladonacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(433, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Registro Actual del Material Previo a la Llegada del Deposito";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(95, 64);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(396, 108);
            this.listBox1.TabIndex = 3;
            // 
            // Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 272);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_informaciondeladonacion);
            this.Controls.Add(this.boton_iralmenuprincipal);
            this.Name = "Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito";
            this.Text = "Registro_Actual_del_Material_Previo_a_la_Llegada_del_Deposito";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_iralmenuprincipal;
        private System.Windows.Forms.Button boton_informaciondeladonacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
    }
}