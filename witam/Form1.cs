using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace witam
{
    public partial class Form1 : Form
    {
        bool isAnalog = true; // Określa czy zegar analogowy/cyfrowy
        Color skinColor = Color.LightBlue; // Domyślny kolor skórki
        public Form1()
        {
            InitializeComponent();

            // Konfiguracja timera do zegarów
            timer1.Interval = 1000; // 1 sekunda
            timer1.Tick += timer1_Tick;
            timer1.Start();

            // Ustawienia początkowe widoczności zegarów
            panelClock.Visible = isAnalog;
            labelDigital.Visible = !isAnalog;
        }
        enum Op { PLUS, MINUS, MULTIPLY, DIVIDE };
        Op operation;
        double var1, var2, res;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butDivide_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textVar.Text);
            operation = Op.DIVIDE;
            this.textVar.Text = "";
        }

        private void butMinus_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textVar.Text);
            operation = Op.MINUS;
            this.textVar.Text = "";
        }

        private void butMultiply_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textVar.Text);
            operation = Op.MULTIPLY;
            this.textVar.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                isAnalog = true;
                panelClock.Visible = true;
                labelDigital.Visible = false;
            }
        }

        private void DrawHand(Graphics g, int cx, int cy, double angle, float length, int width, Color? color = null)
        {
            double rad = (Math.PI / 180) * (angle - 90);
            float x = cx + (float)(length * Math.Cos(rad));
            float y = cy + (float)(length * Math.Sin(rad));
            using (Pen pen = new Pen(color ?? Color.Black, width))
            {
                g.DrawLine(pen, cx, cy, x, y);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isAnalog)
            {
                panelClock.Invalidate(); // wywołuje zdarzenie Paint dla analogowego zegara
            }
            else
            {
                labelDigital.Text = DateTime.Now.ToLongTimeString(); // zaktualizowanie godziny zegara cyfrowego
            }
        }

        private void panelClock_Paint(object sender, PaintEventArgs e)
        {
            if (!isAnalog) return;

            DateTime now = DateTime.Now;
            int centerX = panelClock.Width / 2;
            int centerY = panelClock.Height / 2;
            int radius = Math.Min(centerX, centerY) - 10;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // Rysowanie obwodu zegara
            e.Graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, radius * 2, radius * 2);

            // Rysowanie wskazówki godzinowej
            double hourAngle = (now.Hour % 12 + now.Minute / 60.0) * 30; 
            DrawHand(e.Graphics, centerX, centerY, hourAngle, radius * 0.5f, 6);

            // Rysowanie wskazówki minutowej
            double minuteAngle = (now.Minute + now.Second / 60.0) * 6;
            DrawHand(e.Graphics, centerX, centerY, minuteAngle, radius * 0.7f, 4);

            // Rysowanie wskazówki sekundowej
            double secondAngle = now.Second * 6; 
            DrawHand(e.Graphics, centerX, centerY, secondAngle, radius * 0.9f, 2, Color.Red);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                isAnalog = false;
                panelClock.Visible = false;
                labelDigital.Visible = true;
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    skinColor = dlg.Color;
                    this.BackColor = skinColor;
                }
            }
        }

        private void labelDigital_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Okno2 = new Form2();
            this.Okno2.Show();
        }

        private void buttonProj4_Click(object sender, EventArgs e)
        {
            this.Okno4 = new Form4();
            this.Okno4.Show();
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDouble(textVar.Text);
            operation = Op.PLUS;
            this.textVar.Text = "";
        }
        private void butEquals_Click(object sender, EventArgs e)
        {
            var2 = Convert.ToDouble(textVar.Text);
            this.textVar.Text = "";
            switch (operation)
            {
                case Op.PLUS:
                    res = var1 + var2;
                    break;
                case Op.MINUS:
                    res = var1 - var2;
                    break;
                case Op.MULTIPLY:
                    res = var1 * var2;
                    break;
                case Op.DIVIDE:
                    res = var1 / var2;
                    break;
            }
            this.labelRes.Text = res.ToString();
        }
    }
}
