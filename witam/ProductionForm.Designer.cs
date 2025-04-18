namespace witam
{
    partial class ProductionForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.operatorButton = new System.Windows.Forms.Button();
            this.simulationTimer = new System.Windows.Forms.Timer(this.components);
            this.operatorTimer = new System.Windows.Forms.Timer(this.components);
            this.operatorTimeoutTimer = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.fanButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.productionLineLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(234, 88);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(530, 180);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "label3";
            // 
            // operatorButton
            // 
            this.operatorButton.Location = new System.Drawing.Point(489, 346);
            this.operatorButton.Name = "operatorButton";
            this.operatorButton.Size = new System.Drawing.Size(205, 40);
            this.operatorButton.TabIndex = 5;
            this.operatorButton.Text = "Potwiedzenie obecności";
            this.operatorButton.UseVisualStyleBackColor = true;
            this.operatorButton.Click += new System.EventHandler(this.operatorButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(525, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Potwierdź obecność";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // fanButton
            // 
            this.fanButton.Location = new System.Drawing.Point(117, 310);
            this.fanButton.Name = "fanButton";
            this.fanButton.Size = new System.Drawing.Size(184, 46);
            this.fanButton.TabIndex = 7;
            this.fanButton.Text = "Uruchom dodatkowy wentylator";
            this.fanButton.UseVisualStyleBackColor = true;
            this.fanButton.Click += new System.EventHandler(this.fanButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(184, 42);
            this.button2.TabIndex = 8;
            this.button2.Text = "Wznów produkcję ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // productionLineLabel
            // 
            this.productionLineLabel.AutoSize = true;
            this.productionLineLabel.Location = new System.Drawing.Point(321, 35);
            this.productionLineLabel.Name = "productionLineLabel";
            this.productionLineLabel.Size = new System.Drawing.Size(164, 16);
            this.productionLineLabel.TabIndex = 9;
            this.productionLineLabel.Text = "Linia produkcyjna aktywna";
            // 
            // ProductionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.productionLineLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.fanButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.operatorButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "ProductionForm";
            this.Text = "ProductionForm";
            this.Load += new System.EventHandler(this.ProductionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button operatorButton;
        private System.Windows.Forms.Timer simulationTimer;
        private System.Windows.Forms.Timer operatorTimer;
        private System.Windows.Forms.Timer operatorTimeoutTimer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button fanButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label productionLineLabel;
    }
}