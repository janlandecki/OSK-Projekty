using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace witam
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            SetupPanels();
        }

        private void btnFormatAndSend_Click(object sender, EventArgs e)
        {
            string input = txtInputText.Text;
            string filtered = FilterProfanity(input);
            string encoded = EncodeToRs232(filtered);
            txtEncodedBits.Text = encoded;
            txtReceivedBits.Text = encoded; // symulacja transmisji
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            string bits = txtReceivedBits.Text;
            string decoded = DecodeFromRs232(bits);
            string filtered = FilterProfanity(decoded);
            txtOutputText.Text = filtered;
        }

        private string EncodeToRs232(string input)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in input)
            {
                byte b = (byte)c;
                string bits = Convert.ToString(b, 2).PadLeft(8, '0');
                char[] reversedBits = bits.Reverse().ToArray(); // LSB -> MSB

                // Ramka: start + dane + stop
                string frame = "0" + new string(reversedBits) + "11";
                sb.Append(frame + " "); // dodaj spację między ramkami
            }

            return sb.ToString().TrimEnd(); // usuń ostatnią spację
        }

        private string DecodeFromRs232(string bits)
        {
            StringBuilder result = new StringBuilder();

            // Podziel na ramki po spacjach
            string[] frames = bits.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string frame in frames)
            {
                if (frame.Length != 11 || frame[0] != '0' || !frame.EndsWith("11"))
                    continue;

                string dataBits = new string(frame.Substring(1, 8).Reverse().ToArray());
                int ascii = Convert.ToInt32(dataBits, 2);
                result.Append((char)ascii);
            }

            return result.ToString();
        }

        private string FilterProfanity(string input)
        {
            if (!File.Exists("cenzura.txt"))
            {
                this.lblReceiverTitle.Text = "blad";
                return input;
            }
            string[] badWords = File.ReadAllLines("cenzura.txt");

            foreach (var word in badWords)
            {
                string pattern = "\\b" + Regex.Escape(word) + "\\b";
                input = Regex.Replace(input, pattern, new string('*', word.Length), RegexOptions.IgnoreCase);
            }
            return input;
        }

        private void txtInputText_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetupPanels()
        {
            // Panel nadajnika (lewa strona)
            Panel senderPanel = new Panel
            {
                Dock = DockStyle.Left,
                Width = this.ClientSize.Width / 2,
                BackColor = Color.LightBlue
            };
            this.Controls.Add(senderPanel);

            // Panel odbiornika (prawa strona)
            Panel receiverPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.LightGreen
            };
            this.Controls.Add(receiverPanel);
        }
    }
}
