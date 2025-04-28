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
    public partial class MainForm: Form
    {
        private Cpu cpu = new Cpu();
        private List<Instruction> program = new List<Instruction>();
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (var dlg = new OpenFileDialog { Filter = "Programy (*.asm)|*.asm|Wszystkie|*.*" })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    program = ProgramIO.Load(dlg.FileName);
                    cpu.LoadProgram(program);
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
                MessageBox.Show("Koniec programu");
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
            lblIP.Text = $"IP = {cpu.InstructionPointer}";
        }
    }
}
