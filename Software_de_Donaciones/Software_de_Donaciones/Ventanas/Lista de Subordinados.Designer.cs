namespace Software_de_Donaciones.Ventanas
{
    partial class Lista_de_Subordinados
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
            this.label1 = new System.Windows.Forms.Label();
            this.boton_iralmenu = new System.Windows.Forms.Button();
            this.boton_agregar = new System.Windows.Forms.Button();
            this.boton_despedir = new System.Windows.Forms.Button();
            this.dgv_subordinados = new System.Windows.Forms.DataGridView();
            this.apellido_texto = new System.Windows.Forms.TextBox();
            this.telefono_texto = new System.Windows.Forms.TextBox();
            this.ci_texto = new System.Windows.Forms.TextBox();
            this.cargo_texto = new System.Windows.Forms.TextBox();
            this.nombre_texto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_seleccionarf = new System.Windows.Forms.Button();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subordinados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de  Subordinados";
            // 
            // boton_iralmenu
            // 
            this.boton_iralmenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_iralmenu.Location = new System.Drawing.Point(12, 424);
            this.boton_iralmenu.Name = "boton_iralmenu";
            this.boton_iralmenu.Size = new System.Drawing.Size(105, 27);
            this.boton_iralmenu.TabIndex = 1;
            this.boton_iralmenu.Text = "Ir al Menù Principal";
            this.boton_iralmenu.UseVisualStyleBackColor = true;
            this.boton_iralmenu.Click += new System.EventHandler(this.boton_iralmenu_Click);
            // 
            // boton_agregar
            // 
            this.boton_agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_agregar.Location = new System.Drawing.Point(222, 309);
            this.boton_agregar.Name = "boton_agregar";
            this.boton_agregar.Size = new System.Drawing.Size(92, 47);
            this.boton_agregar.TabIndex = 2;
            this.boton_agregar.Text = "Agregar";
            this.boton_agregar.UseVisualStyleBackColor = true;
            this.boton_agregar.Click += new System.EventHandler(this.boton_agregar_Click);
            // 
            // boton_despedir
            // 
            this.boton_despedir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_despedir.Location = new System.Drawing.Point(462, 309);
            this.boton_despedir.Name = "boton_despedir";
            this.boton_despedir.Size = new System.Drawing.Size(92, 47);
            this.boton_despedir.TabIndex = 3;
            this.boton_despedir.Text = "Despedir";
            this.boton_despedir.UseVisualStyleBackColor = true;
            this.boton_despedir.Click += new System.EventHandler(this.boton_despedir_Click);
            // 
            // dgv_subordinados
            // 
            this.dgv_subordinados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_subordinados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgv_subordinados.Location = new System.Drawing.Point(12, 47);
            this.dgv_subordinados.Name = "dgv_subordinados";
            this.dgv_subordinados.Size = new System.Drawing.Size(542, 183);
            this.dgv_subordinados.TabIndex = 6;
            this.dgv_subordinados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_subordinados_CellClick);
            this.dgv_subordinados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // apellido_texto
            // 
            this.apellido_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido_texto.Location = new System.Drawing.Point(109, 283);
            this.apellido_texto.Name = "apellido_texto";
            this.apellido_texto.Size = new System.Drawing.Size(95, 20);
            this.apellido_texto.TabIndex = 21;
            // 
            // telefono_texto
            // 
            this.telefono_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefono_texto.Location = new System.Drawing.Point(435, 283);
            this.telefono_texto.Name = "telefono_texto";
            this.telefono_texto.Size = new System.Drawing.Size(115, 20);
            this.telefono_texto.TabIndex = 20;
            // 
            // ci_texto
            // 
            this.ci_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ci_texto.Location = new System.Drawing.Point(210, 283);
            this.ci_texto.Name = "ci_texto";
            this.ci_texto.Size = new System.Drawing.Size(106, 20);
            this.ci_texto.TabIndex = 19;
            // 
            // cargo_texto
            // 
            this.cargo_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cargo_texto.Location = new System.Drawing.Point(322, 283);
            this.cargo_texto.Name = "cargo_texto";
            this.cargo_texto.Size = new System.Drawing.Size(107, 20);
            this.cargo_texto.TabIndex = 18;
            // 
            // nombre_texto
            // 
            this.nombre_texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_texto.Location = new System.Drawing.Point(12, 283);
            this.nombre_texto.Name = "nombre_texto";
            this.nombre_texto.Size = new System.Drawing.Size(91, 20);
            this.nombre_texto.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "C.I:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(432, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Teléfono:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(163, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Agregar o Modificar Subordinado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(319, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cargo:";
            // 
            // boton_modificar
            // 
            this.boton_modificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modificar.Location = new System.Drawing.Point(224, 362);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(92, 42);
            this.boton_modificar.TabIndex = 22;
            this.boton_modificar.Text = "Modificar";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.button1_Click);
            // 
            // boton_seleccionarf
            // 
            this.boton_seleccionarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_seleccionarf.Location = new System.Drawing.Point(12, 311);
            this.boton_seleccionarf.Name = "boton_seleccionarf";
            this.boton_seleccionarf.Size = new System.Drawing.Size(90, 42);
            this.boton_seleccionarf.TabIndex = 23;
            this.boton_seleccionarf.Text = "Seleccionar datos";
            this.boton_seleccionarf.UseVisualStyleBackColor = true;
            this.boton_seleccionarf.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "N:";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre:";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Apellido:";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "C.I:";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Cargo:";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Telèfono:";
            this.Column5.Name = "Column5";
            // 
            // Lista_de_Subordinados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 463);
            this.Controls.Add(this.boton_seleccionarf);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.apellido_texto);
            this.Controls.Add(this.telefono_texto);
            this.Controls.Add(this.ci_texto);
            this.Controls.Add(this.cargo_texto);
            this.Controls.Add(this.nombre_texto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgv_subordinados);
            this.Controls.Add(this.boton_despedir);
            this.Controls.Add(this.boton_agregar);
            this.Controls.Add(this.boton_iralmenu);
            this.Controls.Add(this.label1);
            this.Name = "Lista_de_Subordinados";
            this.Text = "Lista_de_Subordinados";
            this.Load += new System.EventHandler(this.Lista_de_Subordinados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_subordinados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_iralmenu;
        private System.Windows.Forms.Button boton_agregar;
        private System.Windows.Forms.Button boton_despedir;
        private System.Windows.Forms.DataGridView dgv_subordinados;
        private System.Windows.Forms.TextBox apellido_texto;
        private System.Windows.Forms.TextBox telefono_texto;
        private System.Windows.Forms.TextBox ci_texto;
        private System.Windows.Forms.TextBox cargo_texto;
        private System.Windows.Forms.TextBox nombre_texto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_seleccionarf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}