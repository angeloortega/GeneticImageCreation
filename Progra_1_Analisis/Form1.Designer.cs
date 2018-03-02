namespace Progra_1_Analisis
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.imagenGenerada = new System.Windows.Forms.PictureBox();
            this.imagenObjetivo = new System.Windows.Forms.PictureBox();
            this.imgLoadBtn = new System.Windows.Forms.Button();
            this.labelDiferencia = new System.Windows.Forms.Label();
            this.compararBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGenerada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenObjetivo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 38);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generar Imágenes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // imagenGenerada
            // 
            this.imagenGenerada.Location = new System.Drawing.Point(21, 176);
            this.imagenGenerada.Name = "imagenGenerada";
            this.imagenGenerada.Size = new System.Drawing.Size(117, 109);
            this.imagenGenerada.TabIndex = 1;
            this.imagenGenerada.TabStop = false;
            // 
            // imagenObjetivo
            // 
            this.imagenObjetivo.Location = new System.Drawing.Point(21, 17);
            this.imagenObjetivo.Name = "imagenObjetivo";
            this.imagenObjetivo.Size = new System.Drawing.Size(117, 109);
            this.imagenObjetivo.TabIndex = 3;
            this.imagenObjetivo.TabStop = false;
            // 
            // imgLoadBtn
            // 
            this.imgLoadBtn.Location = new System.Drawing.Point(21, 132);
            this.imgLoadBtn.Name = "imgLoadBtn";
            this.imgLoadBtn.Size = new System.Drawing.Size(117, 38);
            this.imgLoadBtn.TabIndex = 2;
            this.imgLoadBtn.Text = "Cargar Imagen";
            this.imgLoadBtn.UseVisualStyleBackColor = true;
            this.imgLoadBtn.Click += new System.EventHandler(this.imgLoadBtn_Click);
            // 
            // labelDiferencia
            // 
            this.labelDiferencia.AutoSize = true;
            this.labelDiferencia.Location = new System.Drawing.Point(305, 82);
            this.labelDiferencia.Name = "labelDiferencia";
            this.labelDiferencia.Size = new System.Drawing.Size(35, 13);
            this.labelDiferencia.TabIndex = 4;
            this.labelDiferencia.Text = "label1";
            // 
            // compararBtn
            // 
            this.compararBtn.Location = new System.Drawing.Point(308, 102);
            this.compararBtn.Name = "compararBtn";
            this.compararBtn.Size = new System.Drawing.Size(75, 23);
            this.compararBtn.TabIndex = 5;
            this.compararBtn.Text = "Comparar";
            this.compararBtn.UseVisualStyleBackColor = true;
            this.compararBtn.Click += new System.EventHandler(this.compararBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 339);
            this.Controls.Add(this.compararBtn);
            this.Controls.Add(this.labelDiferencia);
            this.Controls.Add(this.imagenObjetivo);
            this.Controls.Add(this.imgLoadBtn);
            this.Controls.Add(this.imagenGenerada);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenGenerada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenObjetivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox imagenGenerada;
        private System.Windows.Forms.PictureBox imagenObjetivo;
        private System.Windows.Forms.Button imgLoadBtn;
        private System.Windows.Forms.Label labelDiferencia;
        private System.Windows.Forms.Button compararBtn;
    }
}

