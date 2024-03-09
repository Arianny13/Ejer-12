namespace Ejer_12
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Capital = new System.Windows.Forms.TextBox();
            this.txt_Idioma = new System.Windows.Forms.TextBox();
            this.txt_Poblacion = new System.Windows.Forms.TextBox();
            this.lbl_Capital = new System.Windows.Forms.Label();
            this.lbl_Idioma = new System.Windows.Forms.Label();
            this.lbl_Poblacion = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Limpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(113, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(204, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txt_Capital
            // 
            this.txt_Capital.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Capital.Location = new System.Drawing.Point(179, 143);
            this.txt_Capital.Name = "txt_Capital";
            this.txt_Capital.Size = new System.Drawing.Size(166, 29);
            this.txt_Capital.TabIndex = 1;
            // 
            // txt_Idioma
            // 
            this.txt_Idioma.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Idioma.Location = new System.Drawing.Point(179, 206);
            this.txt_Idioma.Name = "txt_Idioma";
            this.txt_Idioma.Size = new System.Drawing.Size(166, 29);
            this.txt_Idioma.TabIndex = 2;
            // 
            // txt_Poblacion
            // 
            this.txt_Poblacion.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Poblacion.Location = new System.Drawing.Point(179, 271);
            this.txt_Poblacion.Name = "txt_Poblacion";
            this.txt_Poblacion.Size = new System.Drawing.Size(166, 29);
            this.txt_Poblacion.TabIndex = 3;
            // 
            // lbl_Capital
            // 
            this.lbl_Capital.AutoSize = true;
            this.lbl_Capital.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Capital.Location = new System.Drawing.Point(93, 146);
            this.lbl_Capital.Name = "lbl_Capital";
            this.lbl_Capital.Size = new System.Drawing.Size(63, 20);
            this.lbl_Capital.TabIndex = 4;
            this.lbl_Capital.Text = "Capital";
            // 
            // lbl_Idioma
            // 
            this.lbl_Idioma.AutoSize = true;
            this.lbl_Idioma.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Idioma.Location = new System.Drawing.Point(93, 209);
            this.lbl_Idioma.Name = "lbl_Idioma";
            this.lbl_Idioma.Size = new System.Drawing.Size(63, 20);
            this.lbl_Idioma.TabIndex = 5;
            this.lbl_Idioma.Text = "Idioma";
            // 
            // lbl_Poblacion
            // 
            this.lbl_Poblacion.AutoSize = true;
            this.lbl_Poblacion.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Poblacion.Location = new System.Drawing.Point(93, 274);
            this.lbl_Poblacion.Name = "lbl_Poblacion";
            this.lbl_Poblacion.Size = new System.Drawing.Size(86, 20);
            this.lbl_Poblacion.TabIndex = 6;
            this.lbl_Poblacion.Text = "Poblacion";
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Salir.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(240, 368);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(105, 54);
            this.btn_Salir.TabIndex = 7;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Limpiar
            // 
            this.btn_Limpiar.BackColor = System.Drawing.Color.LightCyan;
            this.btn_Limpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Limpiar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpiar.Location = new System.Drawing.Point(86, 368);
            this.btn_Limpiar.Name = "btn_Limpiar";
            this.btn_Limpiar.Size = new System.Drawing.Size(105, 54);
            this.btn_Limpiar.TabIndex = 9;
            this.btn_Limpiar.Text = "Limpiar";
            this.btn_Limpiar.UseVisualStyleBackColor = false;
            this.btn_Limpiar.Click += new System.EventHandler(this.btn_Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(438, 450);
            this.Controls.Add(this.btn_Limpiar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.lbl_Poblacion);
            this.Controls.Add(this.lbl_Idioma);
            this.Controls.Add(this.lbl_Capital);
            this.Controls.Add(this.txt_Poblacion);
            this.Controls.Add(this.txt_Idioma);
            this.Controls.Add(this.txt_Capital);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Capital;
        private System.Windows.Forms.TextBox txt_Idioma;
        private System.Windows.Forms.TextBox txt_Poblacion;
        private System.Windows.Forms.Label lbl_Capital;
        private System.Windows.Forms.Label lbl_Idioma;
        private System.Windows.Forms.Label lbl_Poblacion;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Limpiar;
    }
}

