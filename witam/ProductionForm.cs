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
    public partial class ProductionForm : Form
    {
        private Random random = new Random();
        private int cpuTemperature;
        private int cpuUsage;
        private int fanSpeed;
        private const int maxCpuTemperature = 88;
        private const int maxCpuUsage = 97;
        private const int maxFanSpeed = 5800;

        private bool waitingForOperatorResponse = false;
        private bool waitingForAction = false;
        public ProductionForm()
        {
            InitializeComponent();
            InitializeSimulation();
        }

        private void InitializeSimulation()
        {
            simulationTimer.Interval = 500;
            simulationTimer.Tick += SimulationTimer_Tick;
            simulationTimer.Start();

            operatorTimer.Interval = 15000;
            operatorTimer.Tick += OperatorTimer_Tick;
            operatorTimer.Start();

            operatorTimeoutTimer.Interval = 10000;
            operatorTimeoutTimer.Tick += OperatorTimeoutTimer_Tick;

            label1.Text = $"Temperatura CPU : 0";
            label2.Text = $"Wykorzystanie CPU: 0";
            label3.Text = $"Predkosc wentylatora: 0";
            label4.Text = "";
        }

        private void SimulationTimer_Tick(object sender, EventArgs e)
        {
            cpuTemperature = 50 + (int)(random.NextDouble() * 40);
            cpuUsage = random.Next(30, 100);
            fanSpeed = random.Next(2000, 6000);

            label1.Text = $"Temperatura CPU : {cpuTemperature}";
            label2.Text = $"Wykorzystanie CPU: {cpuUsage}";
            label3.Text = $"Predkosc wentylatora: {fanSpeed}";
            productionLineLabel.Visible = true;

            if (cpuTemperature > maxCpuTemperature)
            {
                LogEvent("Krytyczna temperatura, włącz dodatkowy wentylator.");
                waitingForAction = true;
                simulationTimer.Stop();
                productionLineLabel.Visible = false;
            }
            if (cpuUsage > maxCpuUsage)
            {
                LogEvent("Przekroczono limit wykorzystania CPU, zatrzymano produkcje.");
                waitingForAction = true;
                simulationTimer.Stop();
                productionLineLabel.Visible = false;
            }
            if (fanSpeed > maxFanSpeed)
            {
                LogEvent("Wentylator kreci sie za szybko, włącz dodatkowy wentylator..");
                waitingForAction = true;
                simulationTimer.Stop();
                productionLineLabel.Visible = false;
            }
        }

        private void LogEvent(string message)
        {
            string logMessage = $"{DateTime.Now:HH:mm:ss} - {message}";
            listBox1.Items.Insert(0, logMessage);
        }

        private void OperatorTimer_Tick(object sender, EventArgs e)
        {
            if (!waitingForOperatorResponse)
            {
                waitingForOperatorResponse = true;
                label4.Text = "Proszę potwierdź obecność";
                operatorTimeoutTimer.Start();
            }
        }

        private void ProductionForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void OperatorTimeoutTimer_Tick(object sender, EventArgs e)
        {
            operatorTimeoutTimer.Stop();
            if (waitingForOperatorResponse)
            {
                LogEvent("Alarm! Brak potwierdzenia obecności operatora. Wylogowywanie...");
                simulationTimer.Stop();
                operatorTimer.Stop();
                waitingForOperatorResponse = false;
                MessageBox.Show("Wylogowano operatora z powodu braku aktywności.", "Alarm", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
        }

        private void ProductionForm_Load(object sender, EventArgs e)
        {

        }

        private void operatorButton_Click(object sender, EventArgs e)
        {
            if (waitingForOperatorResponse)
            {
                waitingForOperatorResponse = false;
                operatorTimeoutTimer.Stop();
                LogEvent("Obecność potwierdzona przez operatora.");
                label4.Text = "";
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void fanButton_Click(object sender, EventArgs e)
        {
            waitingForAction = false;
            simulationTimer.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            waitingForAction = false;
            simulationTimer.Start();
        }
    }
}
