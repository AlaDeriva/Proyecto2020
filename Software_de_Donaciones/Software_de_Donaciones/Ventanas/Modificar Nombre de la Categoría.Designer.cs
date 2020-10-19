namespace Software_de_Donaciones.Ventanas
{
    partial class Modificar_Nombre_de_la_Categoría
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_modificarnombredecategoria = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modificar Nombre de la Categoría:";
            // 
            // boton_modificarnombredecategoria
            // 
            this.boton_modificarnombredecategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_modificarnombredecategoria.Location = new System.Drawing.Point(136, 120);
            this.boton_modificarnombredecategoria.Name = "boton_modificarnombredecategoria";
            this.boton_modificarnombredecategoria.Size = new System.Drawing.Size(140, 43);
            this.boton_modificarnombredecategoria.TabIndex = 3;
            this.boton_modificarnombredecategoria.Text = "Modificar";
            this.boton_modificarnombredecategoria.UseVisualStyleBackColor = true;
            // 
            // Modificar_Nombre_de_la_Categoría
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 208);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_modificarnombredecategoria);
            this.Name = "Modificar_Nombre_de_la_Categoría";
            this.Text = "Modificar_Nombre_de_la_Categoría";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_modificarnombredecategoria;
    }
}