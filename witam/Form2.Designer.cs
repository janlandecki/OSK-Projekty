namespace witam
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.buttonClick = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.labelNow = new System.Windows.Forms.Label();
            this.radioButtonVisual = new System.Windows.Forms.RadioButton();
            this.radioButtonAudio = new System.Windows.Forms.RadioButton();
            this.buttonShowHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timerWait
            // 
            this.timerWait.Tick += new System.EventHandler(this.TimerWait_Tick);
            // 
            // buttonClick
            // 
            this.buttonClick.Location = new System.Drawing.Point(238, 199);
            this.buttonClick.Name = "buttonClick";
            this.buttonClick.Size = new System.Drawing.Size(315, 176);
            this.buttonClick.TabIndex = 3;
            this.buttonClick.Text = "Klik";
            this.buttonClick.UseVisualStyleBackColor = true;
            this.buttonClick.Click += new System.EventHandler(this.buttonClick_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(362, 35);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // labelNow
            // 
            this.labelNow.AutoSize = true;
            this.labelNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelNow.ForeColor = System.Drawing.Color.Red;
            this.labelNow.Location = new System.Drawing.Point(293, 87);
            this.labelNow.Name = "labelNow";
            this.labelNow.Size = new System.Drawing.Size(209, 63);
            this.labelNow.TabIndex = 5;
            this.labelNow.Text = "TERAZ";
            // 
            // radioButtonVisual
            // 
            this.radioButtonVisual.AutoSize = true;
            this.radioButtonVisual.Checked = true;
            this.radioButtonVisual.Location = new System.Drawing.Point(610, 106);
            this.radioButtonVisual.Name = "radioButtonVisual";
            this.radioButtonVisual.Size = new System.Drawing.Size(96, 17);
            this.radioButtonVisual.TabIndex = 6;
            this.radioButtonVisual.TabStop = true;
            this.radioButtonVisual.Text = "Test wzrokowy";
            this.radioButtonVisual.UseVisualStyleBackColor = true;
            // 
            // radioButtonAudio
            // 
            this.radioButtonAudio.AutoSize = true;
            this.radioButtonAudio.Location = new System.Drawing.Point(610, 151);
            this.radioButtonAudio.Name = "radioButtonAudio";
            this.radioButtonAudio.Size = new System.Drawing.Size(95, 17);
            this.radioButtonAudio.TabIndex = 7;
            this.radioButtonAudio.Text = "Test słuchowy";
            this.radioButtonAudio.UseVisualStyleBackColor = true;
            // 
            // buttonShowHistory
            // 
            this.buttonShowHistory.Location = new System.Drawing.Point(62, 106);
            this.buttonShowHistory.Name = "buttonShowHistory";
            this.buttonShowHistory.Size = new System.Drawing.Size(115, 23);
            this.buttonShowHistory.TabIndex = 8;
            this.buttonShowHistory.Text = "Historia wyników";
            this.buttonShowHistory.UseVisualStyleBackColor = true;
            this.buttonShowHistory.Click += new System.EventHandler(this.buttonShowHistory_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonShowHistory);
            this.Controls.Add(this.radioButtonAudio);
            this.Controls.Add(this.radioButtonVisual);
            this.Controls.Add(this.labelNow);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonClick);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form2";
            this.Text = "Czas reakcji";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelNow;
        private System.Windows.Forms.RadioButton radioButtonVisual;
        private System.Windows.Forms.RadioButton radioButtonAudio;
        private System.Windows.Forms.Button buttonShowHistory;
    }
}