namespace Software_de_Donaciones
{
    partial class Menu_Principal
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
            this.grp_admin = new System.Windows.Forms.GroupBox();
            this.boton_administrardeposito = new System.Windows.Forms.Button();
            this.boton_versubordinados = new System.Windows.Forms.Button();
            this.grp_cliente = new System.Windows.Forms.GroupBox();
            this.boton_rastreardonacion = new System.Windows.Forms.Button();
            this.boton_enviardonacion = new System.Windows.Forms.Button();
            this.grp_encargado = new System.Windows.Forms.GroupBox();
            this.boton_accederaldeposito = new System.Windows.Forms.Button();
            this.boton_cerrarsesion = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.grp_admin.SuspendLayout();
            this.grp_cliente.SuspendLayout();
            this.grp_encargado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_admin
            // 
            this.grp_admin.Controls.Add(this.boton_administrardeposito);
            this.grp_admin.Controls.Add(this.boton_versubordinados);
            this.grp_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_admin.Location = new System.Drawing.Point(563, 153);
            this.grp_admin.Name = "grp_admin";
            this.grp_admin.Size = new System.Drawing.Size(225, 285);
            this.grp_admin.TabIndex = 0;
            this.grp_admin.TabStop = false;
            this.grp_admin.Text = "Administrador";
            // 
            // boton_administrardeposito
            // 
            this.boton_administrardeposito.Location = new System.Drawing.Point(18, 95);
            this.boton_administrardeposito.Name = "boton_administrardeposito";
            this.boton_administrardeposito.Size = new System.Drawing.Size(201, 23);
            this.boton_administrardeposito.TabIndex = 4;
            this.boton_administrardeposito.Text = "Administrar  Deposito";
            this.boton_administrardeposito.UseVisualStyleBackColor = true;
            // 
            // boton_versubordinados
            // 
            this.boton_versubordinados.Location = new System.Drawing.Point(18, 134);
            this.boton_versubordinados.Name = "boton_versubordinados";
            this.boton_versubordinados.Size = new System.Drawing.Size(201, 23);
            this.boton_versubordinados.TabIndex = 2;
            this.boton_versubordinados.Text = "Ver Subordinados";
            this.boton_versubordinados.UseVisualStyleBackColor = true;
            this.boton_versubordinados.Click += new System.EventHandler(this.boton_versubordinados_Click);
            // 
            // grp_cliente
            // 
            this.grp_cliente.Controls.Add(this.boton_rastreardonacion);
            this.grp_cliente.Controls.Add(this.boton_enviardonacion);
            this.grp_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_cliente.Location = new System.Drawing.Point(29, 153);
            this.grp_cliente.Name = "grp_cliente";
            this.grp_cliente.Size = new System.Drawing.Size(193, 285);
            this.grp_cliente.TabIndex = 1;
            this.grp_cliente.TabStop = false;
            this.grp_cliente.Text = "Cliente";
            this.grp_cliente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // boton_rastreardonacion
            // 
            this.boton_rastreardonacion.Location = new System.Drawing.Point(6, 134);
            this.boton_rastreardonacion.Name = "boton_rastreardonacion";
            this.boton_rastreardonacion.Size = new System.Drawing.Size(168, 23);
            this.boton_rastreardonacion.TabIndex = 8;
            this.boton_rastreardonacion.Text = "Rastrear Donaciòn";
            this.boton_rastreardonacion.UseVisualStyleBackColor = true;
            // 
            // boton_enviardonacion
            // 
            this.boton_enviardonacion.Location = new System.Drawing.Point(6, 104);
            this.boton_enviardonacion.Name = "boton_enviardonacion";
            this.boton_enviardonacion.Size = new System.Drawing.Size(168, 23);
            this.boton_enviardonacion.TabIndex = 7;
            this.boton_enviardonacion.Text = "Enviar Donaciòn";
            this.boton_enviardonacion.UseVisualStyleBackColor = true;
            this.boton_enviardonacion.Click += new System.EventHandler(this.boton_enviardonacion_Click);
            // 
            // grp_encargado
            // 
            this.grp_encargado.Controls.Add(this.boton_accederaldeposito);
            this.grp_encargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_encargado.Location = new System.Drawing.Point(281, 153);
            this.grp_encargado.Name = "grp_encargado";
            this.grp_encargado.Size = new System.Drawing.Size(218, 285);
            this.grp_encargado.TabIndex = 2;
            this.grp_encargado.TabStop = false;
            this.grp_encargado.Text = "Encargado";
            // 
            // boton_accederaldeposito
            // 
            this.boton_accederaldeposito.Location = new System.Drawing.Point(11, 104);
            this.boton_accederaldeposito.Name = "boton_accederaldeposito";
            this.boton_accederaldeposito.Size = new System.Drawing.Size(201, 23);
            this.boton_accederaldeposito.TabIndex = 4;
            this.boton_accederaldeposito.Text = "Acceder al Deposito";
            this.boton_accederaldeposito.UseVisualStyleBackColor = true;
            this.boton_accederaldeposito.Click += new System.EventHandler(this.boton_accederaldeposito_Click);
            // 
            // boton_cerrarsesion
            // 
            this.boton_cerrarsesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_cerrarsesion.Location = new System.Drawing.Point(697, 3);
            this.boton_cerrarsesion.Name = "boton_cerrarsesion";
            this.boton_cerrarsesion.Size = new System.Drawing.Size(91, 26);
            this.boton_cerrarsesion.TabIndex = 4;
            this.boton_cerrarsesion.Text = "Cerrar Sesion";
            this.boton_cerrarsesion.UseVisualStyleBackColor = true;
            this.boton_cerrarsesion.Click += new System.EventHandler(this.boton_cerrarsesion_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 31);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenido Usuario ";
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.boton_cerrarsesion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grp_encargado);
            this.Controls.Add(this.grp_cliente);
            this.Controls.Add(this.grp_admin);
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.grp_admin.ResumeLayout(false);
            this.grp_cliente.ResumeLayout(false);
            this.grp_encargado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_admin;
        private System.Windows.Forms.GroupBox grp_cliente;
        private System.Windows.Forms.Button boton_administrardeposito;
        private System.Windows.Forms.Button boton_versubordinados;
        private System.Windows.Forms.Button boton_rastreardonacion;
        private System.Windows.Forms.Button boton_enviardonacion;
        private System.Windows.Forms.GroupBox grp_encargado;
        private System.Windows.Forms.Button boton_accederaldeposito;
        private System.Windows.Forms.Button boton_cerrarsesion;
        private System.Windows.Forms.Label label2;
    }
}