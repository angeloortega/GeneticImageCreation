﻿namespace Progra_1_Analisis
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
            System.Windows.Forms.Label objetivoLbl;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label7;
            this.lblGenNumber = new System.Windows.Forms.Label();
            this.imagenGenerada = new System.Windows.Forms.PictureBox();
            this.imagenObjetivo = new System.Windows.Forms.PictureBox();
            this.imgLoadBtn = new System.Windows.Forms.Button();
            this.indMasAptoGen = new System.Windows.Forms.Label();
            this.compararBtn = new System.Windows.Forms.Button();
            this.statBox = new System.Windows.Forms.GroupBox();
            this.indMenosGen = new System.Windows.Forms.Label();
            this.indPromedioGen = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.indMenosHistor = new System.Windows.Forms.Label();
            this.indPromedioHistor = new System.Windows.Forms.Label();
            this.indMasHistor = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.entryMenosApt = new System.Windows.Forms.TextBox();
            this.entryCruces = new System.Windows.Forms.TextBox();
            this.entryMutacion = new System.Windows.Forms.TextBox();
            this.entryPoblacion = new System.Windows.Forms.TextBox();
            this.entryIteraciones = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.histFormaCheck = new System.Windows.Forms.CheckBox();
            this.histColorCheck = new System.Windows.Forms.CheckBox();
            this.DistanciaManCheck = new System.Windows.Forms.CheckBox();
            this.DistanciaGCheck = new System.Windows.Forms.CheckBox();
            objetivoLbl = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imagenGenerada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenObjetivo)).BeginInit();
            this.statBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // objetivoLbl
            // 
            objetivoLbl.AutoSize = true;
            objetivoLbl.Location = new System.Drawing.Point(21, 37);
            objetivoLbl.Name = "objetivoLbl";
            objetivoLbl.Size = new System.Drawing.Size(87, 13);
            objetivoLbl.TabIndex = 6;
            objetivoLbl.Text = "Imagen Objetivo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(331, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(116, 13);
            label1.TabIndex = 7;
            label1.Text = "Imagen Más Apta Gen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(9, 47);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(120, 13);
            label2.TabIndex = 7;
            label2.Text = "Porcentajes de similitud:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(9, 45);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(120, 13);
            label7.TabIndex = 7;
            label7.Text = "Porcentajes de similitud:";
            // 
            // lblGenNumber
            // 
            this.lblGenNumber.AutoSize = true;
            this.lblGenNumber.Location = new System.Drawing.Point(9, 26);
            this.lblGenNumber.Name = "lblGenNumber";
            this.lblGenNumber.Size = new System.Drawing.Size(72, 13);
            this.lblGenNumber.TabIndex = 10;
            this.lblGenNumber.Text = "# Generación";
            // 
            // imagenGenerada
            // 
            this.imagenGenerada.Location = new System.Drawing.Point(453, 12);
            this.imagenGenerada.Name = "imagenGenerada";
            this.imagenGenerada.Size = new System.Drawing.Size(200, 200);
            this.imagenGenerada.TabIndex = 1;
            this.imagenGenerada.TabStop = false;
            // 
            // imagenObjetivo
            // 
            this.imagenObjetivo.Location = new System.Drawing.Point(114, 12);
            this.imagenObjetivo.Name = "imagenObjetivo";
            this.imagenObjetivo.Size = new System.Drawing.Size(200, 200);
            this.imagenObjetivo.TabIndex = 3;
            this.imagenObjetivo.TabStop = false;
            // 
            // imgLoadBtn
            // 
            this.imgLoadBtn.Location = new System.Drawing.Point(12, 174);
            this.imgLoadBtn.Name = "imgLoadBtn";
            this.imgLoadBtn.Size = new System.Drawing.Size(96, 38);
            this.imgLoadBtn.TabIndex = 2;
            this.imgLoadBtn.Text = "Cargar Imagen";
            this.imgLoadBtn.UseVisualStyleBackColor = true;
            this.imgLoadBtn.Click += new System.EventHandler(this.imgLoadBtn_Click);
            // 
            // indMasAptoGen
            // 
            this.indMasAptoGen.AutoSize = true;
            this.indMasAptoGen.Location = new System.Drawing.Point(30, 69);
            this.indMasAptoGen.Name = "indMasAptoGen";
            this.indMasAptoGen.Size = new System.Drawing.Size(99, 13);
            this.indMasAptoGen.TabIndex = 4;
            this.indMasAptoGen.Text = "Individuo más apto:";
            // 
            // compararBtn
            // 
            this.compararBtn.Location = new System.Drawing.Point(543, 387);
            this.compararBtn.Name = "compararBtn";
            this.compararBtn.Size = new System.Drawing.Size(110, 23);
            this.compararBtn.TabIndex = 5;
            this.compararBtn.Text = "Empezar Evolución";
            this.compararBtn.UseVisualStyleBackColor = true;
            this.compararBtn.Click += new System.EventHandler(this.iniciarEvolucion);
            // 
            // statBox
            // 
            this.statBox.Controls.Add(this.lblGenNumber);
            this.statBox.Controls.Add(this.indMenosGen);
            this.statBox.Controls.Add(this.indPromedioGen);
            this.statBox.Controls.Add(label2);
            this.statBox.Controls.Add(this.indMasAptoGen);
            this.statBox.Location = new System.Drawing.Point(12, 218);
            this.statBox.Name = "statBox";
            this.statBox.Size = new System.Drawing.Size(218, 163);
            this.statBox.TabIndex = 8;
            this.statBox.TabStop = false;
            this.statBox.Text = "Estadísticas Generación Actual";
            this.statBox.Enter += new System.EventHandler(this.statBox_Enter);
            // 
            // indMenosGen
            // 
            this.indMenosGen.AutoSize = true;
            this.indMenosGen.Location = new System.Drawing.Point(30, 116);
            this.indMenosGen.Name = "indMenosGen";
            this.indMenosGen.Size = new System.Drawing.Size(111, 13);
            this.indMenosGen.TabIndex = 9;
            this.indMenosGen.Text = "Individuo menos apto:";
            // 
            // indPromedioGen
            // 
            this.indPromedioGen.AutoSize = true;
            this.indPromedioGen.Location = new System.Drawing.Point(30, 92);
            this.indPromedioGen.Name = "indPromedioGen";
            this.indPromedioGen.Size = new System.Drawing.Size(99, 13);
            this.indPromedioGen.TabIndex = 8;
            this.indPromedioGen.Text = "Individuo promedio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.indMenosHistor);
            this.groupBox1.Controls.Add(this.indPromedioHistor);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.indMasHistor);
            this.groupBox1.Location = new System.Drawing.Point(236, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 163);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas Históricas:";
            // 
            // indMenosHistor
            // 
            this.indMenosHistor.AutoSize = true;
            this.indMenosHistor.Location = new System.Drawing.Point(30, 114);
            this.indMenosHistor.Name = "indMenosHistor";
            this.indMenosHistor.Size = new System.Drawing.Size(111, 13);
            this.indMenosHistor.TabIndex = 9;
            this.indMenosHistor.Text = "Individuo menos apto:";
            // 
            // indPromedioHistor
            // 
            this.indPromedioHistor.AutoSize = true;
            this.indPromedioHistor.Location = new System.Drawing.Point(30, 90);
            this.indPromedioHistor.Name = "indPromedioHistor";
            this.indPromedioHistor.Size = new System.Drawing.Size(99, 13);
            this.indPromedioHistor.TabIndex = 8;
            this.indPromedioHistor.Text = "Individuo promedio:";
            // 
            // indMasHistor
            // 
            this.indMasHistor.AutoSize = true;
            this.indMasHistor.Location = new System.Drawing.Point(30, 67);
            this.indMasHistor.Name = "indMasHistor";
            this.indMasHistor.Size = new System.Drawing.Size(99, 13);
            this.indMasHistor.TabIndex = 4;
            this.indMasHistor.Text = "Individuo más apto:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.entryMenosApt);
            this.groupBox2.Controls.Add(this.entryCruces);
            this.groupBox2.Controls.Add(this.entryMutacion);
            this.groupBox2.Controls.Add(this.entryPoblacion);
            this.groupBox2.Controls.Add(this.entryIteraciones);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(460, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 163);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuraciones:";
            // 
            // entryMenosApt
            // 
            this.entryMenosApt.Location = new System.Drawing.Point(88, 121);
            this.entryMenosApt.Name = "entryMenosApt";
            this.entryMenosApt.Size = new System.Drawing.Size(99, 20);
            this.entryMenosApt.TabIndex = 15;
            // 
            // entryCruces
            // 
            this.entryCruces.Location = new System.Drawing.Point(88, 95);
            this.entryCruces.Name = "entryCruces";
            this.entryCruces.Size = new System.Drawing.Size(99, 20);
            this.entryCruces.TabIndex = 14;
            // 
            // entryMutacion
            // 
            this.entryMutacion.Location = new System.Drawing.Point(88, 69);
            this.entryMutacion.Name = "entryMutacion";
            this.entryMutacion.Size = new System.Drawing.Size(99, 20);
            this.entryMutacion.TabIndex = 13;
            // 
            // entryPoblacion
            // 
            this.entryPoblacion.Location = new System.Drawing.Point(88, 44);
            this.entryPoblacion.Name = "entryPoblacion";
            this.entryPoblacion.Size = new System.Drawing.Size(99, 20);
            this.entryPoblacion.TabIndex = 12;
            this.entryPoblacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // entryIteraciones
            // 
            this.entryIteraciones.Location = new System.Drawing.Point(88, 19);
            this.entryIteraciones.Name = "entryIteraciones";
            this.entryIteraciones.Size = new System.Drawing.Size(99, 20);
            this.entryIteraciones.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(9, 124);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "% Menos apt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 98);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "% Cruces:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "% Mutación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "# Iteraciones:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tam población:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DistanciaGCheck);
            this.groupBox3.Controls.Add(this.DistanciaManCheck);
            this.groupBox3.Controls.Add(this.histColorCheck);
            this.groupBox3.Controls.Add(this.histFormaCheck);
            this.groupBox3.Location = new System.Drawing.Point(320, 75);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(127, 137);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculo de diferencias:";
            // 
            // histFormaCheck
            // 
            this.histFormaCheck.AutoSize = true;
            this.histFormaCheck.Location = new System.Drawing.Point(14, 35);
            this.histFormaCheck.Name = "histFormaCheck";
            this.histFormaCheck.Size = new System.Drawing.Size(79, 17);
            this.histFormaCheck.TabIndex = 0;
            this.histFormaCheck.Text = "Hist. Forma";
            this.histFormaCheck.UseVisualStyleBackColor = true;
            // 
            // histColorCheck
            // 
            this.histColorCheck.AutoSize = true;
            this.histColorCheck.Location = new System.Drawing.Point(14, 59);
            this.histColorCheck.Name = "histColorCheck";
            this.histColorCheck.Size = new System.Drawing.Size(74, 17);
            this.histColorCheck.TabIndex = 1;
            this.histColorCheck.Text = "Hist. Color";
            this.histColorCheck.UseVisualStyleBackColor = true;
            // 
            // DistanciaManCheck
            // 
            this.DistanciaManCheck.AutoSize = true;
            this.DistanciaManCheck.Location = new System.Drawing.Point(14, 82);
            this.DistanciaManCheck.Name = "DistanciaManCheck";
            this.DistanciaManCheck.Size = new System.Drawing.Size(101, 17);
            this.DistanciaManCheck.TabIndex = 2;
            this.DistanciaManCheck.Text = "Dist. Manhattan";
            this.DistanciaManCheck.UseVisualStyleBackColor = true;
            // 
            // DistanciaGCheck
            // 
            this.DistanciaGCheck.AutoSize = true;
            this.DistanciaGCheck.Location = new System.Drawing.Point(14, 105);
            this.DistanciaGCheck.Name = "DistanciaGCheck";
            this.DistanciaGCheck.Size = new System.Drawing.Size(81, 17);
            this.DistanciaGCheck.TabIndex = 3;
            this.DistanciaGCheck.Text = "Distancia G";
            this.DistanciaGCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 417);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statBox);
            this.Controls.Add(label1);
            this.Controls.Add(objetivoLbl);
            this.Controls.Add(this.compararBtn);
            this.Controls.Add(this.imagenObjetivo);
            this.Controls.Add(this.imgLoadBtn);
            this.Controls.Add(this.imagenGenerada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagenGenerada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagenObjetivo)).EndInit();
            this.statBox.ResumeLayout(false);
            this.statBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox imagenGenerada;
        private System.Windows.Forms.Button imgLoadBtn;
        private System.Windows.Forms.Button compararBtn;
        private System.Windows.Forms.GroupBox statBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imagenObjetivo;
        private System.Windows.Forms.Label indMasAptoGen;
        private System.Windows.Forms.Label indPromedioGen;
        private System.Windows.Forms.Label indMenosGen;
        private System.Windows.Forms.Label indMenosHistor;
        private System.Windows.Forms.Label indPromedioHistor;
        private System.Windows.Forms.Label indMasHistor;
        private System.Windows.Forms.TextBox entryMenosApt;
        private System.Windows.Forms.TextBox entryCruces;
        private System.Windows.Forms.TextBox entryMutacion;
        private System.Windows.Forms.TextBox entryPoblacion;
        private System.Windows.Forms.TextBox entryIteraciones;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblGenNumber;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox DistanciaGCheck;
        private System.Windows.Forms.CheckBox DistanciaManCheck;
        private System.Windows.Forms.CheckBox histColorCheck;
        private System.Windows.Forms.CheckBox histFormaCheck;
    }
}

