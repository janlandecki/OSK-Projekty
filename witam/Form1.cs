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
        public Form1()
        {
            InitializeComponent();
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
