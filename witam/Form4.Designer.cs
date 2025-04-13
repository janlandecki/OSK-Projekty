namespace witam
{
    partial class Form4
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
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtEncodedBits = new System.Windows.Forms.TextBox();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.txtReceivedBits = new System.Windows.Forms.TextBox();
            this.btnFormatAndSend = new System.Windows.Forms.Button();
            this.btnDecode = new System.Windows.Forms.Button();
            this.lblSenderTitle = new System.Windows.Forms.Label();
            this.lblReceiverTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(97, 87);
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(191, 20);
            this.txtInputText.TabIndex = 0;
            this.txtInputText.TextChanged += new System.EventHandler(this.txtInputText_TextChanged);
            // 
            // txtEncodedBits
            // 
            this.txtEncodedBits.Location = new System.Drawing.Point(12, 237);
            this.txtEncodedBits.Multiline = true;
            this.txtEncodedBits.Name = "txtEncodedBits";
            this.txtEncodedBits.ReadOnly = true;
            this.txtEncodedBits.Size = new System.Drawing.Size(371, 191);
            this.txtEncodedBits.TabIndex = 1;
            // 
            // txtOutputText
            // 
            this.txtOutputText.Location = new System.Drawing.Point(509, 87);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.ReadOnly = true;
            this.txtOutputText.Size = new System.Drawing.Size(191, 20);
            this.txtOutputText.TabIndex = 2;
            // 
            // txtReceivedBits
            // 
            this.txtReceivedBits.Location = new System.Drawing.Point(417, 237);
            this.txtReceivedBits.Multiline = true;
            this.txtReceivedBits.Name = "txtReceivedBits";
            this.txtReceivedBits.ReadOnly = true;
            this.txtReceivedBits.Size = new System.Drawing.Size(371, 191);
            this.txtReceivedBits.TabIndex = 3;
            // 
            // btnFormatAndSend
            // 
            this.btnFormatAndSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFormatAndSend.Location = new System.Drawing.Point(144, 180);
            this.btnFormatAndSend.Margin = new System.Windows.Forms.Padding(0);
            this.btnFormatAndSend.Name = "btnFormatAndSend";
            this.btnFormatAndSend.Size = new System.Drawing.Size(115, 23);
            this.btnFormatAndSend.TabIndex = 4;
            this.btnFormatAndSend.Text = "Zakoduj i wyślij";
            this.btnFormatAndSend.UseVisualStyleBackColor = true;
            this.btnFormatAndSend.Click += new System.EventHandler(this.btnFormatAndSend_Click);
            // 
            // btnDecode
            // 
            this.btnDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecode.Location = new System.Drawing.Point(566, 180);
            this.btnDecode.Margin = new System.Windows.Forms.Padding(0);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(75, 23);
            this.btnDecode.TabIndex = 5;
            this.btnDecode.Text = "Dekoduj";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // lblSenderTitle
            // 
            this.lblSenderTitle.AutoSize = true;
            this.lblSenderTitle.BackColor = System.Drawing.Color.LightBlue;
            this.lblSenderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSenderTitle.Location = new System.Drawing.Point(139, 27);
            this.lblSenderTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblSenderTitle.Name = "lblSenderTitle";
            this.lblSenderTitle.Size = new System.Drawing.Size(120, 31);
            this.lblSenderTitle.TabIndex = 6;
            this.lblSenderTitle.Text = "Nadajnik";
            // 
            // lblReceiverTitle
            // 
            this.lblReceiverTitle.AutoSize = true;
            this.lblReceiverTitle.BackColor = System.Drawing.Color.LightGreen;
            this.lblReceiverTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblReceiverTitle.Location = new System.Drawing.Point(538, 27);
            this.lblReceiverTitle.Margin = new System.Windows.Forms.Padding(0);
            this.lblReceiverTitle.Name = "lblReceiverTitle";
            this.lblReceiverTitle.Size = new System.Drawing.Size(130, 31);
            this.lblReceiverTitle.TabIndex = 7;
            this.lblReceiverTitle.Text = "Odbiornik";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblReceiverTitle);
            this.Controls.Add(this.lblSenderTitle);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.btnFormatAndSend);
            this.Controls.Add(this.txtReceivedBits);
            this.Controls.Add(this.txtOutputText);
            this.Controls.Add(this.txtEncodedBits);
            this.Controls.Add(this.txtInputText);
            this.Name = "Form4";
            this.Text = "Transmisja szeregowa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtEncodedBits;
        private System.Windows.Forms.TextBox txtOutputText;
        private System.Windows.Forms.TextBox txtReceivedBits;
        private System.Windows.Forms.Button btnFormatAndSend;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Label lblSenderTitle;
        private System.Windows.Forms.Label lblReceiverTitle;
    }
}