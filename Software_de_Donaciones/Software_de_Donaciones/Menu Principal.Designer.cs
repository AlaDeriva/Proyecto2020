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
            this.grp_cliente = new System.Windows.Forms.GroupBox();
            this.grp_encargado = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.grp_admin.SuspendLayout();
            this.grp_cliente.SuspendLayout();
            this.grp_encargado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_admin
            // 
            this.grp_admin.Controls.Add(this.button1);
            this.grp_admin.Controls.Add(this.button4);
            this.grp_admin.Controls.Add(this.button3);
            this.grp_admin.Location = new System.Drawing.Point(563, 153);
            this.grp_admin.Name = "grp_admin";
            this.grp_admin.Size = new System.Drawing.Size(225, 285);
            this.grp_admin.TabIndex = 0;
            this.grp_admin.TabStop = false;
            this.grp_admin.Text = "Administrador";
            // 
            // grp_cliente
            // 
            this.grp_cliente.Controls.Add(this.button2);
            this.grp_cliente.Controls.Add(this.button7);
            this.grp_cliente.Location = new System.Drawing.Point(29, 153);
            this.grp_cliente.Name = "grp_cliente";
            this.grp_cliente.Size = new System.Drawing.Size(193, 285);
            this.grp_cliente.TabIndex = 1;
            this.grp_cliente.TabStop = false;
            this.grp_cliente.Text = "Cliente";
            this.grp_cliente.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // grp_encargado
            // 
            this.grp_encargado.Controls.Add(this.button6);
            this.grp_encargado.Location = new System.Drawing.Point(281, 153);
            this.grp_encargado.Name = "grp_encargado";
            this.grp_encargado.Size = new System.Drawing.Size(218, 285);
            this.grp_encargado.TabIndex = 2;
            this.grp_encargado.TabStop = false;
            this.grp_encargado.Text = "Encargado";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 133);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ver Subordinados";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(697, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(91, 26);
            this.button5.TabIndex = 4;
            this.button5.Text = "Cerrar Sesion";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(11, 104);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(201, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Acceder al Deposito";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(6, 104);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(168, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "Enviar Donaciòn";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Bienvenido Usuario Encargado";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 104);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(201, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Acceder al Deposito";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Administrar  Deposito";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 134);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(168, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Rastrear Donaciòn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox grp_encargado;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label2;
    }
}