﻿namespace witam
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Form2 Okno2;
        private Form4 Okno4;
        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butDivide = new System.Windows.Forms.Button();
            this.butMultiply = new System.Windows.Forms.Button();
            this.butMinus = new System.Windows.Forms.Button();
            this.butEquals = new System.Windows.Forms.Button();
            this.butPlus = new System.Windows.Forms.Button();
            this.textVar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.panelClock = new System.Windows.Forms.Panel();
            this.labelDigital = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.buttonColor = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.buttonProj4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz wartość:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(89, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wynik:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butDivide
            // 
            this.butDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butDivide.Location = new System.Drawing.Point(298, 108);
            this.butDivide.Name = "butDivide";
            this.butDivide.Size = new System.Drawing.Size(50, 50);
            this.butDivide.TabIndex = 5;
            this.butDivide.Text = ":";
            this.butDivide.UseVisualStyleBackColor = true;
            this.butDivide.Click += new System.EventHandler(this.butDivide_Click);
            // 
            // butMultiply
            // 
            this.butMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butMultiply.Location = new System.Drawing.Point(203, 108);
            this.butMultiply.Name = "butMultiply";
            this.butMultiply.Size = new System.Drawing.Size(50, 50);
            this.butMultiply.TabIndex = 6;
            this.butMultiply.Text = "*";
            this.butMultiply.UseVisualStyleBackColor = true;
            this.butMultiply.Click += new System.EventHandler(this.butMultiply_Click);
            // 
            // butMinus
            // 
            this.butMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butMinus.Location = new System.Drawing.Point(112, 108);
            this.butMinus.Name = "butMinus";
            this.butMinus.Size = new System.Drawing.Size(50, 50);
            this.butMinus.TabIndex = 7;
            this.butMinus.Text = "-";
            this.butMinus.UseVisualStyleBackColor = true;
            this.butMinus.Click += new System.EventHandler(this.butMinus_Click);
            // 
            // butEquals
            // 
            this.butEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butEquals.Location = new System.Drawing.Point(399, 108);
            this.butEquals.Name = "butEquals";
            this.butEquals.Size = new System.Drawing.Size(50, 50);
            this.butEquals.TabIndex = 8;
            this.butEquals.Text = "=";
            this.butEquals.UseVisualStyleBackColor = true;
            this.butEquals.Click += new System.EventHandler(this.butEquals_Click);
            // 
            // butPlus
            // 
            this.butPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.butPlus.Location = new System.Drawing.Point(22, 108);
            this.butPlus.Name = "butPlus";
            this.butPlus.Size = new System.Drawing.Size(50, 50);
            this.butPlus.TabIndex = 10;
            this.butPlus.Text = "+";
            this.butPlus.UseVisualStyleBackColor = true;
            this.butPlus.Click += new System.EventHandler(this.butPlus_Click);
            // 
            // textVar
            // 
            this.textVar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textVar.Location = new System.Drawing.Point(168, 25);
            this.textVar.Name = "textVar";
            this.textVar.Size = new System.Drawing.Size(281, 30);
            this.textVar.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(163, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 12;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelRes
            // 
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRes.Location = new System.Drawing.Point(163, 69);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(286, 25);
            this.labelRes.TabIndex = 13;
            // 
            // panelClock
            // 
            this.panelClock.Location = new System.Drawing.Point(203, 233);
            this.panelClock.Margin = new System.Windows.Forms.Padding(2);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(277, 245);
            this.panelClock.TabIndex = 14;
            this.panelClock.Paint += new System.Windows.Forms.PaintEventHandler(this.panelClock_Paint);
            // 
            // labelDigital
            // 
            this.labelDigital.AutoSize = true;
            this.labelDigital.Location = new System.Drawing.Point(303, 349);
            this.labelDigital.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDigital.Name = "labelDigital";
            this.labelDigital.Size = new System.Drawing.Size(75, 13);
            this.labelDigital.TabIndex = 15;
            this.labelDigital.Text = "Zegar Cyfrowy";
            this.labelDigital.Click += new System.EventHandler(this.labelDigital_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(271, 525);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(108, 17);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Zegar Analogowy";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(271, 555);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(93, 17);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Zegar Cyfrowy";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.Location = new System.Drawing.Point(560, 40);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(2);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(117, 90);
            this.buttonColor.TabIndex = 18;
            this.buttonColor.Text = "Zmiana koloru skórki";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "Projekt 2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonProj4
            // 
            this.buttonProj4.Location = new System.Drawing.Point(574, 330);
            this.buttonProj4.Name = "buttonProj4";
            this.buttonProj4.Size = new System.Drawing.Size(75, 23);
            this.buttonProj4.TabIndex = 20;
            this.buttonProj4.Text = "Projekt 4";
            this.buttonProj4.UseVisualStyleBackColor = true;
            this.buttonProj4.Click += new System.EventHandler(this.buttonProj4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 622);
            this.Controls.Add(this.buttonProj4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonColor);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.labelDigital);
            this.Controls.Add(this.panelClock);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textVar);
            this.Controls.Add(this.butPlus);
            this.Controls.Add(this.butEquals);
            this.Controls.Add(this.butMinus);
            this.Controls.Add(this.butMultiply);
            this.Controls.Add(this.butDivide);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kalkulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butDivide;
        private System.Windows.Forms.Button butMultiply;
        private System.Windows.Forms.Button butMinus;
        private System.Windows.Forms.Button butEquals;
        private System.Windows.Forms.Button butPlus;
        private System.Windows.Forms.TextBox textVar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Panel panelClock;
        private System.Windows.Forms.Label labelDigital;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonProj4;
    }
}

