using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace witam
{
    public partial class MainForm: Form
    {
        private Cpu cpu = new Cpu();
        private List<Instruction> program = new List<Instruction>();
        public MainForm()
        {
            InitializeComponent();

            var writer = new TextBoxWriter(Log);
            Console.SetOut(writer);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Programy (*.asm)|*.asm|Wszystkie|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    program = ProgramIO.Load(dlg.FileName);
                    cpu.LoadProgram(program);
                    txtProgramEditor.Lines = File.ReadAllLines(dlg.FileName);
                    RefreshDisplay();
                }
            }
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog { Filter = "Programy (*.asm)|*.asm" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    ProgramIO.Save(dlg.FileName, program);
                }
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            cpu.Reset();
            cpu.Run();
            RefreshDisplay();
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            if (!cpu.Step())
            {
                MessageBox.Show("Koniec programu");
                cpu.Reset();
            }
            RefreshDisplay();
        }

        private void RefreshDisplay()
        {
            txtRegisters.Text =
                $"AX={cpu.AX:X4}  BX={cpu.BX:X4}\r\n" +
                $"CX={cpu.CX:X4}  DX={cpu.DX:X4}\r\n" +
                $"AH={cpu.AH:X2} AL={cpu.AL:X2}  BH={cpu.BH:X2} BL={cpu.BL:X2}\r\n" +
                $"CH={cpu.CH:X2} CL={cpu.CL:X2}  DH={cpu.DH:X2} DL={cpu.DL:X2}\r\n";
            lstProgram.Items.Clear();
            foreach (var instr in program) lstProgram.Items.Add(instr.ToString());
            lblIP.Text = $"IP = {cpu.IP}";

            if (cpu.IP < lstProgram.Items.Count)
            {
                lstProgram.SelectedIndex = cpu.IP;
            }
        }

        private void btnLoadFromEditor_Click(object sender, EventArgs e)
        {
            var lines = txtProgramEditor.Lines;
            program = ProgramIO.Parse(lines);
            cpu.LoadProgram(program);
            RefreshDisplay();
        }

        private void lblIP_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            cpu.Reset();
            RefreshDisplay();
        }

        private void demoBtn_Click(object sender, EventArgs e)
        {
            cpu.Demonstracyjny();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            cpu.Dydaktyczny();
        }
    }

    class TextBoxWriter : TextWriter
    {
        private RichTextBox _box;
        public TextBoxWriter(RichTextBox box) { _box = box; }

        public override Encoding Encoding => Encoding.UTF8;

        public override void WriteLine(string value)
        {
            if (_box.InvokeRequired)
                _box.Invoke(new Action(() => _box.AppendText(value + Environment.NewLine)));
            else
                _box.AppendText(value + Environment.NewLine);
        }
    }
}
