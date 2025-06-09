using System.Windows.Forms;

namespace witam
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnStep = new System.Windows.Forms.Button();
            this.txtRegisters = new System.Windows.Forms.TextBox();
            this.lstProgram = new System.Windows.Forms.ListBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.txtProgramEditor = new System.Windows.Forms.TextBox();
            this.btnLoadFromEditor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.Log = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.demoBtn = new System.Windows.Forms.Button();
            this.infoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(232, 356);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(125, 26);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load from file";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(232, 388);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 26);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save to file";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(396, 338);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(125, 26);
            this.btnRun.TabIndex = 2;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnStep
            // 
            this.btnStep.Location = new System.Drawing.Point(396, 370);
            this.btnStep.Name = "btnStep";
            this.btnStep.Size = new System.Drawing.Size(125, 26);
            this.btnStep.TabIndex = 3;
            this.btnStep.Text = "Step";
            this.btnStep.UseVisualStyleBackColor = true;
            this.btnStep.Click += new System.EventHandler(this.btnStep_Click);
            // 
            // txtRegisters
            // 
            this.txtRegisters.Location = new System.Drawing.Point(90, 95);
            this.txtRegisters.Multiline = true;
            this.txtRegisters.Name = "txtRegisters";
            this.txtRegisters.Size = new System.Drawing.Size(136, 165);
            this.txtRegisters.TabIndex = 4;
            // 
            // lstProgram
            // 
            this.lstProgram.FormattingEnabled = true;
            this.lstProgram.ItemHeight = 16;
            this.lstProgram.Location = new System.Drawing.Point(309, 101);
            this.lstProgram.Name = "lstProgram";
            this.lstProgram.Size = new System.Drawing.Size(154, 148);
            this.lstProgram.TabIndex = 5;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(325, 276);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(111, 16);
            this.lblIP.TabIndex = 6;
            this.lblIP.Text = "Instruction Pointer";
            this.lblIP.Click += new System.EventHandler(this.lblIP_Click);
            // 
            // txtProgramEditor
            // 
            this.txtProgramEditor.Location = new System.Drawing.Point(527, 95);
            this.txtProgramEditor.Multiline = true;
            this.txtProgramEditor.Name = "txtProgramEditor";
            this.txtProgramEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtProgramEditor.Size = new System.Drawing.Size(217, 165);
            this.txtProgramEditor.TabIndex = 0;
            // 
            // btnLoadFromEditor
            // 
            this.btnLoadFromEditor.Location = new System.Drawing.Point(572, 276);
            this.btnLoadFromEditor.Name = "btnLoadFromEditor";
            this.btnLoadFromEditor.Size = new System.Drawing.Size(130, 23);
            this.btnLoadFromEditor.TabIndex = 0;
            this.btnLoadFromEditor.Text = "Load from editor";
            this.btnLoadFromEditor.Click += new System.EventHandler(this.btnLoadFromEditor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Program Editor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Registers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(341, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Program Code";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(396, 402);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(125, 24);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Log
            // 
            this.Log.Location = new System.Drawing.Point(798, 95);
            this.Log.Name = "Log";
            this.Log.Size = new System.Drawing.Size(304, 269);
            this.Log.TabIndex = 12;
            this.Log.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(927, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Console";
            // 
            // demoBtn
            // 
            this.demoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.demoBtn.Location = new System.Drawing.Point(968, 388);
            this.demoBtn.Name = "demoBtn";
            this.demoBtn.Size = new System.Drawing.Size(117, 23);
            this.demoBtn.TabIndex = 14;
            this.demoBtn.Text = "Demonstration";
            this.demoBtn.UseVisualStyleBackColor = true;
            this.demoBtn.Click += new System.EventHandler(this.demoBtn_Click);
            // 
            // infoBtn
            // 
            this.infoBtn.Location = new System.Drawing.Point(838, 388);
            this.infoBtn.Name = "infoBtn";
            this.infoBtn.Size = new System.Drawing.Size(97, 23);
            this.infoBtn.TabIndex = 15;
            this.infoBtn.Text = "Information";
            this.infoBtn.UseVisualStyleBackColor = true;
            this.infoBtn.Click += new System.EventHandler(this.infoBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 450);
            this.Controls.Add(this.infoBtn);
            this.Controls.Add(this.demoBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Log);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoadFromEditor);
            this.Controls.Add(this.txtProgramEditor);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lstProgram);
            this.Controls.Add(this.txtRegisters);
            this.Controls.Add(this.btnStep);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnStep;
        private System.Windows.Forms.TextBox txtRegisters;
        private System.Windows.Forms.ListBox lstProgram;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.TextBox txtProgramEditor;
        private Button btnLoadFromEditor;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnReset;
        private RichTextBox Log;
        private Label label4;
        private Button demoBtn;
        private Button infoBtn;
    }
}