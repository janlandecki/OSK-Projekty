using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace witam
{
    public partial class Form2 : Form { 
    

    public Form2()
    {
        InitializeComponent();

        // Upewnij się, że kropka jest niewidoczna na starcie
        this.pictureBoxDot.Visible = false;
        this.buttonClick.Enabled = false;

    }
        private Stopwatch stopwatch = new Stopwatch();

    private void TimerWait_Tick(object sender, EventArgs e)
    {
            this.timerWait.Stop();
            this.pictureBoxDot.Visible = true;
            this.buttonClick.Enabled = true;
            this.stopwatch.Restart();
    }


        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.pictureBoxDot.Visible = false;
            this.buttonClick.Enabled = false;

            int delay = DateTime.Now.Millisecond % 5 * 1000 + 3000;

            this.timerWait.Interval = delay;
            this.timerWait.Start();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (!pictureBoxDot.Visible)
                return;

            this.stopwatch.Stop();
            this.buttonClick.Enabled = false;

            MessageBox.Show($"Twój czas reakcji: {stopwatch.ElapsedMilliseconds} ms", "Wynik");
        }
    }
}
