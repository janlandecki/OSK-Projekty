using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace witam
{
    public partial class Form2 : Form
    {
        private Stopwatch stopwatch = new Stopwatch();
        private bool soundPlayed = false;
        private bool stimulusActive = false;

        // Dodane: historia wyników
        private List<long> visualTestHistory = new List<long>();
        private List<long> audioTestHistory = new List<long>();

        public Form2()
        {
            InitializeComponent();

            this.labelNow.Visible = false;

            this.buttonClick.Enabled = true;
            this.timerWait.Tick += TimerWait_Tick;

            this.radioButtonVisual.Checked = true;
        }

        private void TimerWait_Tick(object sender, EventArgs e)
        {
            this.timerWait.Stop();
            stimulusActive = true;

            if (radioButtonVisual.Checked)
            {
                this.labelNow.Visible = true;
            }
            else if (radioButtonAudio.Checked)
            {
                PlayBeepSound();
                soundPlayed = true;
            }

            this.stopwatch.Restart();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            this.labelNow.Visible = false;
            soundPlayed = false;
            stimulusActive = false;

            int delay = DateTime.Now.Millisecond % 5 * 1000 + 3000;
            this.timerWait.Interval = delay;
            this.timerWait.Start();
        }

        private void buttonClick_Click(object sender, EventArgs e)
        {
            if (!stimulusActive)
            {
                this.timerWait.Stop();
                this.labelNow.Visible = false;
                soundPlayed = false;
                MessageBox.Show("Za szybko! Poczekaj na sygnał.", "Zbyt wczesna reakcja");
                return;
            }

            this.stopwatch.Stop();
            this.labelNow.Visible = false;
            soundPlayed = false;
            stimulusActive = false;

            long reactionTime = stopwatch.ElapsedMilliseconds;

            if (radioButtonVisual.Checked)
                visualTestHistory.Add(reactionTime);
            else if (radioButtonAudio.Checked)
                audioTestHistory.Add(reactionTime);

            MessageBox.Show($"Twój czas reakcji: {reactionTime} ms", "Wynik");
        }

        private void PlayBeepSound()
        {
            SystemSounds.Beep.Play();
        }

        // Dodane: metoda pokazująca historię wyników
        private void ShowHistory()
        {
            string visualHistory = string.Join(", ", visualTestHistory, " ms");
            string audioHistory = string.Join(", ", audioTestHistory, " ms");

            MessageBox.Show(
                $"Historia testów wzrokowych:\n{visualHistory}\n\nHistoria testów słuchowych:\n{audioHistory}",
                "Historia wyników"
            );
        }

        private void buttonShowHistory_Click(object sender, EventArgs e)
        {
            ShowHistory();
        }
    }
}