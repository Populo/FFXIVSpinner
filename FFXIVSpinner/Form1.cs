using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FFXIVSpinner
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);


        const UInt32 WM_KEYDOWN = 0x0100;
        const UInt32 WM_KEYUP = 0x0101;

        const int VK_A = 0x41;

        private Process _process { get; set; }
        private bool _running { get; set; }

        private Keys _key { get; set; }

        public Form1()
        {
            _running = false;
            InitializeComponent();
        }

        private void labelProcess_Click(object sender, EventArgs e)
        {
            try
            {
                _process = FindProcess();

                labelProcess.Text = $"Process: {_process.ProcessName}({_process.Id})";
            } 
            catch
            {
                MessageBox.Show("Cannot hook Final Fantasy XIV Process");
            }
        }

        private Process FindProcess()
        {
            Process proc = Process.GetProcesses().FirstOrDefault(p => p.ProcessName.StartsWith("ffxiv", StringComparison.CurrentCultureIgnoreCase));

            if (null == proc)
            {
                throw new Exception("cannot find process");
            }

            return proc;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            _running = !_running;

            if (!_running)
            {
                buttonStart.Text = "Stop";

                PostMessage(_process.MainWindowHandle, WM_KEYDOWN, VK_A, 0);
            } 
            else
            {
                buttonStart.Text = "Start";
                PostMessage(_process.MainWindowHandle, WM_KEYUP, VK_A, 0);
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelProcess_Click(sender, e);
        }
    }
}
