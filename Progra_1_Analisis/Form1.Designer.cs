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
            this.DistanciaManCheck = new System.Windows.Forms.RadioButton();
            this.DistanciaGCheck = new System.Windows.Forms.RadioButton();
            this.conTrampaCheck = new System.Windows.Forms.CheckBox();
            this.histColorCheck = new System.Windows.Forms.CheckBox();
            this.histFormaCheck = new System.Windows.Forms.CheckBox();
            this.pixel32 = new System.Windows.Forms.RadioButton();
            this.pixel64 = new System.Windows.Forms.RadioButton();
            this.pixel128 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
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
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // objetivoLbl
            // 
            objetivoLbl.AutoSize = true;
            objetivoLbl.Location = new System.Drawing.Point(32, 72);
            objetivoLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            objetivoLbl.Name = "objetivoLbl";
            objetivoLbl.Size = new System.Drawing.Size(128, 20);
            objetivoLbl.TabIndex = 6;
            objetivoLbl.Text = "Imagen Objetivo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(496, 72);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(174, 20);
            label1.TabIndex = 7;
            label1.Text = "Imagen Más Apta Gen:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 72);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(179, 20);
            label2.TabIndex = 7;
            label2.Text = "Porcentajes de similitud:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(14, 69);
            label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(179, 20);
            label7.TabIndex = 7;
            label7.Text = "Porcentajes de similitud:";
            // 
            // lblGenNumber
            // 
            this.lblGenNumber.AutoSize = true;
            this.lblGenNumber.Location = new System.Drawing.Point(14, 40);
            this.lblGenNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenNumber.Name = "lblGenNumber";
            this.lblGenNumber.Size = new System.Drawing.Size(105, 20);
            this.lblGenNumber.TabIndex = 10;
            this.lblGenNumber.Text = "# Generación";
            // 
            // imagenGenerada
            // 
            this.imagenGenerada.Location = new System.Drawing.Point(682, 72);
            this.imagenGenerada.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imagenGenerada.Name = "imagenGenerada";
            this.imagenGenerada.Size = new System.Drawing.Size(300, 308);
            this.imagenGenerada.TabIndex = 1;
            this.imagenGenerada.TabStop = false;
            // 
            // imagenObjetivo
            // 
            this.imagenObjetivo.Location = new System.Drawing.Point(171, 72);
            this.imagenObjetivo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imagenObjetivo.Name = "imagenObjetivo";
            this.imagenObjetivo.Size = new System.Drawing.Size(300, 308);
            this.imagenObjetivo.TabIndex = 3;
            this.imagenObjetivo.TabStop = false;
            // 
            // imgLoadBtn
            // 
            this.imgLoadBtn.Location = new System.Drawing.Point(18, 322);
            this.imgLoadBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgLoadBtn.Name = "imgLoadBtn";
            this.imgLoadBtn.Size = new System.Drawing.Size(144, 58);
            this.imgLoadBtn.TabIndex = 2;
            this.imgLoadBtn.Text = "Cargar Imagen";
            this.imgLoadBtn.UseVisualStyleBackColor = true;
            this.imgLoadBtn.Click += new System.EventHandler(this.imgLoadBtn_Click);
            // 
            // indMasAptoGen
            // 
            this.indMasAptoGen.AutoSize = true;
            this.indMasAptoGen.Location = new System.Drawing.Point(45, 106);
            this.indMasAptoGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indMasAptoGen.Name = "indMasAptoGen";
            this.indMasAptoGen.Size = new System.Drawing.Size(146, 20);
            this.indMasAptoGen.TabIndex = 4;
            this.indMasAptoGen.Text = "Individuo más apto:";
            // 
            // compararBtn
            // 
            this.compararBtn.Location = new System.Drawing.Point(814, 663);
            this.compararBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.compararBtn.Name = "compararBtn";
            this.compararBtn.Size = new System.Drawing.Size(165, 35);
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
            this.statBox.Location = new System.Drawing.Point(18, 403);
            this.statBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statBox.Name = "statBox";
            this.statBox.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statBox.Size = new System.Drawing.Size(327, 251);
            this.statBox.TabIndex = 8;
            this.statBox.TabStop = false;
            this.statBox.Text = "Estadísticas Generación Actual";
            this.statBox.Enter += new System.EventHandler(this.statBox_Enter);
            // 
            // indMenosGen
            // 
            this.indMenosGen.AutoSize = true;
            this.indMenosGen.Location = new System.Drawing.Point(45, 178);
            this.indMenosGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indMenosGen.Name = "indMenosGen";
            this.indMenosGen.Size = new System.Drawing.Size(164, 20);
            this.indMenosGen.TabIndex = 9;
            this.indMenosGen.Text = "Individuo menos apto:";
            // 
            // indPromedioGen
            // 
            this.indPromedioGen.AutoSize = true;
            this.indPromedioGen.Location = new System.Drawing.Point(45, 142);
            this.indPromedioGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indPromedioGen.Name = "indPromedioGen";
            this.indPromedioGen.Size = new System.Drawing.Size(146, 20);
            this.indPromedioGen.TabIndex = 8;
            this.indPromedioGen.Text = "Individuo promedio:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.indMenosHistor);
            this.groupBox1.Controls.Add(this.indPromedioHistor);
            this.groupBox1.Controls.Add(label7);
            this.groupBox1.Controls.Add(this.indMasHistor);
            this.groupBox1.Location = new System.Drawing.Point(354, 403);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(327, 251);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estadísticas Históricas:";
            // 
            // indMenosHistor
            // 
            this.indMenosHistor.AutoSize = true;
            this.indMenosHistor.Location = new System.Drawing.Point(45, 175);
            this.indMenosHistor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indMenosHistor.Name = "indMenosHistor";
            this.indMenosHistor.Size = new System.Drawing.Size(164, 20);
            this.indMenosHistor.TabIndex = 9;
            this.indMenosHistor.Text = "Individuo menos apto:";
            // 
            // indPromedioHistor
            // 
            this.indPromedioHistor.AutoSize = true;
            this.indPromedioHistor.Location = new System.Drawing.Point(45, 138);
            this.indPromedioHistor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indPromedioHistor.Name = "indPromedioHistor";
            this.indPromedioHistor.Size = new System.Drawing.Size(146, 20);
            this.indPromedioHistor.TabIndex = 8;
            this.indPromedioHistor.Text = "Individuo promedio:";
            // 
            // indMasHistor
            // 
            this.indMasHistor.AutoSize = true;
            this.indMasHistor.Location = new System.Drawing.Point(45, 103);
            this.indMasHistor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.indMasHistor.Name = "indMasHistor";
            this.indMasHistor.Size = new System.Drawing.Size(146, 20);
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
            this.groupBox2.Location = new System.Drawing.Point(693, 403);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(290, 251);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuraciones:";
            // 
            // entryMenosApt
            // 
            this.entryMenosApt.Location = new System.Drawing.Point(132, 186);
            this.entryMenosApt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entryMenosApt.Name = "entryMenosApt";
            this.entryMenosApt.Size = new System.Drawing.Size(146, 26);
            this.entryMenosApt.TabIndex = 15;
            // 
            // entryCruces
            // 
            this.entryCruces.Location = new System.Drawing.Point(132, 146);
            this.entryCruces.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entryCruces.Name = "entryCruces";
            this.entryCruces.Size = new System.Drawing.Size(146, 26);
            this.entryCruces.TabIndex = 14;
            // 
            // entryMutacion
            // 
            this.entryMutacion.Location = new System.Drawing.Point(132, 106);
            this.entryMutacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entryMutacion.Name = "entryMutacion";
            this.entryMutacion.Size = new System.Drawing.Size(146, 26);
            this.entryMutacion.TabIndex = 13;
            // 
            // entryPoblacion
            // 
            this.entryPoblacion.Location = new System.Drawing.Point(132, 68);
            this.entryPoblacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entryPoblacion.Name = "entryPoblacion";
            this.entryPoblacion.Size = new System.Drawing.Size(146, 26);
            this.entryPoblacion.TabIndex = 12;
            this.entryPoblacion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // entryIteraciones
            // 
            this.entryIteraciones.Location = new System.Drawing.Point(132, 29);
            this.entryIteraciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.entryIteraciones.Name = "entryIteraciones";
            this.entryIteraciones.Size = new System.Drawing.Size(146, 26);
            this.entryIteraciones.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 191);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "% Menos apt:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 151);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "% Cruces:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 111);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "% Mutación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 34);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(105, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "# Iteraciones:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 72);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 20);
            this.label12.TabIndex = 4;
            this.label12.Text = "Tam población:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.DistanciaManCheck);
            this.groupBox3.Controls.Add(this.DistanciaGCheck);
            this.groupBox3.Controls.Add(this.conTrampaCheck);
            this.groupBox3.Controls.Add(this.histColorCheck);
            this.groupBox3.Controls.Add(this.histFormaCheck);
            this.groupBox3.Location = new System.Drawing.Point(480, 135);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox3.Size = new System.Drawing.Size(190, 245);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Calculo de diferencias:";
            // 
            // DistanciaManCheck
            // 
            this.DistanciaManCheck.AutoSize = true;
            this.DistanciaManCheck.Checked = true;
            this.DistanciaManCheck.Location = new System.Drawing.Point(21, 128);
            this.DistanciaManCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DistanciaManCheck.Name = "DistanciaManCheck";
            this.DistanciaManCheck.Size = new System.Drawing.Size(147, 24);
            this.DistanciaManCheck.TabIndex = 6;
            this.DistanciaManCheck.TabStop = true;
            this.DistanciaManCheck.Text = "Dist. Manhattan";
            this.DistanciaManCheck.UseVisualStyleBackColor = true;
            // 
            // DistanciaGCheck
            // 
            this.DistanciaGCheck.AutoSize = true;
            this.DistanciaGCheck.Location = new System.Drawing.Point(21, 163);
            this.DistanciaGCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DistanciaGCheck.Name = "DistanciaGCheck";
            this.DistanciaGCheck.Size = new System.Drawing.Size(116, 24);
            this.DistanciaGCheck.TabIndex = 5;
            this.DistanciaGCheck.TabStop = true;
            this.DistanciaGCheck.Text = "Distancia O";
            this.DistanciaGCheck.UseVisualStyleBackColor = true;
            // 
            // conTrampaCheck
            // 
            this.conTrampaCheck.AutoSize = true;
            this.conTrampaCheck.Location = new System.Drawing.Point(21, 198);
            this.conTrampaCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.conTrampaCheck.Name = "conTrampaCheck";
            this.conTrampaCheck.Size = new System.Drawing.Size(148, 24);
            this.conTrampaCheck.TabIndex = 4;
            this.conTrampaCheck.Text = "Selección divina";
            this.conTrampaCheck.UseVisualStyleBackColor = true;
            // 
            // histColorCheck
            // 
            this.histColorCheck.AutoSize = true;
            this.histColorCheck.Location = new System.Drawing.Point(21, 91);
            this.histColorCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.histColorCheck.Name = "histColorCheck";
            this.histColorCheck.Size = new System.Drawing.Size(108, 24);
            this.histColorCheck.TabIndex = 1;
            this.histColorCheck.Text = "Hist. Color";
            this.histColorCheck.UseVisualStyleBackColor = true;
            // 
            // histFormaCheck
            // 
            this.histFormaCheck.AutoSize = true;
            this.histFormaCheck.Location = new System.Drawing.Point(21, 54);
            this.histFormaCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.histFormaCheck.Name = "histFormaCheck";
            this.histFormaCheck.Size = new System.Drawing.Size(117, 24);
            this.histFormaCheck.TabIndex = 0;
            this.histFormaCheck.Text = "Hist. Forma";
            this.histFormaCheck.UseVisualStyleBackColor = true;
            // 
            // pixel32
            // 
            this.pixel32.AutoSize = true;
            this.pixel32.Checked = true;
            this.pixel32.Location = new System.Drawing.Point(18, 62);
            this.pixel32.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pixel32.Name = "pixel32";
            this.pixel32.Size = new System.Drawing.Size(77, 24);
            this.pixel32.TabIndex = 13;
            this.pixel32.TabStop = true;
            this.pixel32.Text = "32x32";
            this.pixel32.UseVisualStyleBackColor = true;
            this.pixel32.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // pixel64
            // 
            this.pixel64.AutoSize = true;
            this.pixel64.Location = new System.Drawing.Point(18, 89);
            this.pixel64.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pixel64.Name = "pixel64";
            this.pixel64.Size = new System.Drawing.Size(77, 24);
            this.pixel64.TabIndex = 14;
            this.pixel64.TabStop = true;
            this.pixel64.Text = "64x64";
            this.pixel64.UseVisualStyleBackColor = true;
            // 
            // pixel128
            // 
            this.pixel128.AutoSize = true;
            this.pixel128.Location = new System.Drawing.Point(18, 114);
            this.pixel128.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pixel128.Name = "pixel128";
            this.pixel128.Size = new System.Drawing.Size(95, 24);
            this.pixel128.TabIndex = 15;
            this.pixel128.TabStop = true;
            this.pixel128.Text = "128x128";
            this.pixel128.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pixel64);
            this.groupBox4.Controls.Add(this.pixel32);
            this.groupBox4.Controls.Add(this.pixel128);
            this.groupBox4.Location = new System.Drawing.Point(18, 135);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(144, 177);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tamaño por utilizar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(692, 663);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 18;
            this.button1.Text = "Restablecer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 712);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Image Evolution";
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
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
        private System.Windows.Forms.CheckBox histColorCheck;
        private System.Windows.Forms.CheckBox histFormaCheck;
        private System.Windows.Forms.CheckBox conTrampaCheck;
        private System.Windows.Forms.RadioButton pixel32;
        private System.Windows.Forms.RadioButton pixel64;
        private System.Windows.Forms.RadioButton pixel128;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton DistanciaManCheck;
        private System.Windows.Forms.RadioButton DistanciaGCheck;
    }
}

