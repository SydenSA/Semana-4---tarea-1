namespace _06Publicaciones
{
    partial class frm_Jobs
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
            this.Boton_cancelar_jobs = new System.Windows.Forms.Button();
            this.Boton_Insertar_jobs = new System.Windows.Forms.Button();
            this.listBox_trabajo = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_maximo = new System.Windows.Forms.TextBox();
            this.textBox_minimo = new System.Windows.Forms.TextBox();
            this.textBox_trabajoDireccion = new System.Windows.Forms.TextBox();
            this.textBox_IDjobs = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Boton_cancelar_jobs
            // 
            this.Boton_cancelar_jobs.Location = new System.Drawing.Point(250, 327);
            this.Boton_cancelar_jobs.Name = "Boton_cancelar_jobs";
            this.Boton_cancelar_jobs.Size = new System.Drawing.Size(131, 61);
            this.Boton_cancelar_jobs.TabIndex = 60;
            this.Boton_cancelar_jobs.Text = "Cancelar";
            this.Boton_cancelar_jobs.UseVisualStyleBackColor = true;
            this.Boton_cancelar_jobs.Click += new System.EventHandler(this.Boton_cancelar_jobs_Click);
            // 
            // Boton_Insertar_jobs
            // 
            this.Boton_Insertar_jobs.Location = new System.Drawing.Point(88, 327);
            this.Boton_Insertar_jobs.Name = "Boton_Insertar_jobs";
            this.Boton_Insertar_jobs.Size = new System.Drawing.Size(137, 61);
            this.Boton_Insertar_jobs.TabIndex = 59;
            this.Boton_Insertar_jobs.Text = "Insertar";
            this.Boton_Insertar_jobs.UseVisualStyleBackColor = true;
            this.Boton_Insertar_jobs.Click += new System.EventHandler(this.Boton_Insertar_jobs_Click);
            // 
            // listBox_trabajo
            // 
            this.listBox_trabajo.FormattingEnabled = true;
            this.listBox_trabajo.Location = new System.Drawing.Point(451, 103);
            this.listBox_trabajo.Name = "listBox_trabajo";
            this.listBox_trabajo.Size = new System.Drawing.Size(313, 303);
            this.listBox_trabajo.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(448, 87);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Lista trabajos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(313, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(247, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Gestion de trabajos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 50;
            this.label4.Text = "Maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 49;
            this.label3.Text = "Minimo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Direccion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Id trabajo";
            // 
            // textBox_maximo
            // 
            this.textBox_maximo.Location = new System.Drawing.Point(182, 230);
            this.textBox_maximo.Name = "textBox_maximo";
            this.textBox_maximo.Size = new System.Drawing.Size(234, 20);
            this.textBox_maximo.TabIndex = 42;
            // 
            // textBox_minimo
            // 
            this.textBox_minimo.Location = new System.Drawing.Point(182, 204);
            this.textBox_minimo.Name = "textBox_minimo";
            this.textBox_minimo.Size = new System.Drawing.Size(234, 20);
            this.textBox_minimo.TabIndex = 41;
            // 
            // textBox_trabajoDireccion
            // 
            this.textBox_trabajoDireccion.Location = new System.Drawing.Point(182, 178);
            this.textBox_trabajoDireccion.Name = "textBox_trabajoDireccion";
            this.textBox_trabajoDireccion.Size = new System.Drawing.Size(234, 20);
            this.textBox_trabajoDireccion.TabIndex = 40;
            // 
            // textBox_IDjobs
            // 
            this.textBox_IDjobs.Location = new System.Drawing.Point(182, 152);
            this.textBox_IDjobs.Name = "textBox_IDjobs";
            this.textBox_IDjobs.Size = new System.Drawing.Size(234, 20);
            this.textBox_IDjobs.TabIndex = 39;
            // 
            // frm_Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Boton_cancelar_jobs);
            this.Controls.Add(this.Boton_Insertar_jobs);
            this.Controls.Add(this.listBox_trabajo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_maximo);
            this.Controls.Add(this.textBox_minimo);
            this.Controls.Add(this.textBox_trabajoDireccion);
            this.Controls.Add(this.textBox_IDjobs);
            this.Name = "frm_Jobs";
            this.Text = "frm_Jobs";
            this.Load += new System.EventHandler(this.frm_Jobs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Boton_cancelar_jobs;
        private System.Windows.Forms.Button Boton_Insertar_jobs;
        private System.Windows.Forms.ListBox listBox_trabajo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_maximo;
        private System.Windows.Forms.TextBox textBox_minimo;
        private System.Windows.Forms.TextBox textBox_trabajoDireccion;
        private System.Windows.Forms.TextBox textBox_IDjobs;
    }
}