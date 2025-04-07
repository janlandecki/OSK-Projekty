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
            this.pictureBoxDot = new System.Windows.Forms.PictureBox();
            this.timerWait = new System.Windows.Forms.Timer(this.components);
            this.buttonClick = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDot)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxDot
            // 
            this.pictureBoxDot.BackColor = System.Drawing.Color.Red;
            this.pictureBoxDot.Location = new System.Drawing.Point(350, 110);
            this.pictureBoxDot.Name = "pictureBoxDot";
            this.pictureBoxDot.Size = new System.Drawing.Size(100, 83);
            this.pictureBoxDot.TabIndex = 2;
            this.pictureBoxDot.TabStop = false;
            this.pictureBoxDot.Visible = false;
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
            this.buttonStart.Location = new System.Drawing.Point(362, 51);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonClick);
            this.Controls.Add(this.pictureBoxDot);
            this.Name = "Form2";
            this.Text = "Czas reakcji";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDot)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxDot;
        private System.Windows.Forms.Timer timerWait;
        private System.Windows.Forms.Button buttonClick;
        private System.Windows.Forms.Button buttonStart;
    }
}