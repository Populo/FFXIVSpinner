using FFXIVSpinner.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace FFXIVSpinner
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);

        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;

        private const int VK_Q = 0x51;
        private const int VK_E = 0x45;

        private const int VK_A = 0x41;
        private const int VK_D = 0x44;

        private const int VK_W = 0x57;
        private const int VK_S = 0x53;

        private const int VK_Space = 0x20;

        private Process _process { get; set; }
        private bool _running { get; set; }
        private int _key { get; set; }

        private List<int> afkKeys { get; set; }
        private List<int> afkKeysAlt { get; set; }

        private Random Random;

        public Form1()
        {
            Random = new Random();
            _running = false;

            InitializeComponent();

            backgroundWorkerAFKBot.DoWork += BackgroundWorkerAFKBot_DoWork;

            afkKeys = new List<int>()
            {
                VK_W,
                VK_A,
                VK_S,
                VK_D
            };

            afkKeysAlt = new List<int>()
            {
                VK_W,
                VK_Q,
                VK_E,
                VK_S
            };
        }

        private void BackgroundWorkerAFKBot_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            if (null != _process && !_process.HasExited)
            {
                while (!worker.CancellationPending)
                {
                    RunBot();
                }
            }
        }

        private void RunBot()
        {
            int min = (int)(1000 * Settings.Default.minAfk);
            int max = (int)(1000 * Settings.Default.maxAfk);
            int jump = Settings.Default.jumpPercent;

            if (jump != 0 && Random.Next(0, 100) <= jump)
            {
                _key = VK_Space;

                PressKey();
                Thread.Sleep(35);
                LiftKey();
            }
            else
            {
                _key = checkBoxAltKeys.Checked
                    ? afkKeysAlt[Random.Next(afkKeysAlt.Count)]
                    : afkKeys[Random.Next(afkKeys.Count)];

                int duration = Random.Next(min, max);

                PressKeyForDuration(duration);
            }

           
        }

        private void labelProcess_Click(object sender, EventArgs e)
        {
            try
            {
                _process = FindProcess();

                labelProcess.Text = $"Process: {_process.ProcessName} ({_process.Id})";
            } 
            catch
            {
                labelProcess.Text = "Cannot hook Final Fantasy XIV Process";
            }
        }

        private Process FindProcess()
        {
            Process proc = Process.GetProcesses()
                .Where(p => p.ProcessName != typeof(Form1).Assembly.GetName().Name)
                .Where(p => !p.ProcessName.Contains("teamcraft", StringComparison.CurrentCultureIgnoreCase))
                //.FirstOrDefault(p => p.ProcessName.StartsWith("notepad", StringComparison.CurrentCultureIgnoreCase));
                .FirstOrDefault(p => p.ProcessName.StartsWith("ffxiv", StringComparison.CurrentCultureIgnoreCase));

            if (null == proc)
            {
                throw new Exception("cannot find process");
            }

            return proc;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            if (_process.HasExited)
            {
                labelProcess_Click(sender, e);
                return;
            }

            var direction = EnumDirections.LEFT;

            if (!_running)
            {
                _running = true;

                InitiateSpin(direction);
                buttonRight.Enabled = false;
            }
            else
            {
                StopSpin(direction);
                buttonRight.Enabled = true;

                _running = false;
            }

        }
        private void buttonRight_Click(object sender, EventArgs e)
        {
            if (_process.HasExited)
            {
                labelProcess_Click(sender, e);
                return;
            }

            var direction = EnumDirections.RIGHT;

            if (!_running)
            {
                _running = true;

                InitiateSpin(direction);
                buttonLeft.Enabled = false;
            }
            else
            {
                StopSpin(direction);
                buttonLeft.Enabled = true;

                _running = false;
            }
        }

        private void InitiateSpin(EnumDirections direction)
        {
            switch (direction)
            {
                case EnumDirections.LEFT:
                    _key = checkBoxAltKeys.Checked ? VK_Q : VK_A;
                    break;
                case EnumDirections.RIGHT:
                    _key = checkBoxAltKeys.Checked ? VK_E : VK_D;
                    break;
            }

            PressKey();
        }

        private void StopSpin(EnumDirections direction)
        {
            switch (direction)
            {
                case EnumDirections.LEFT:
                    _key = checkBoxAltKeys.Checked ? VK_Q : VK_A;
                    break;
                case EnumDirections.RIGHT:
                    _key = checkBoxAltKeys.Checked ? VK_E : VK_D;
                    break;
            }

            LiftKey();
        }
        
        private void PressKey()
        {
            PostMessage(_process.MainWindowHandle, WM_KEYDOWN, _key, 0);
        }

        private void LiftKey()
        {
            PostMessage(_process.MainWindowHandle, WM_KEYUP, _key, 3);
        }


        private void PressKeyForDuration(int duration)
        {
            PressKey();
            Thread.Sleep(duration);
            LiftKey();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelProcess_Click(sender, e);
        }

        private void checkBoxAFKBot_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAFKBot.Checked)
            {
                buttonLeft.Visible = false;
                buttonRight.Visible = false;

                buttonAFKBot.Visible = true;
                buttonOptions.Visible = true;
            }
            else
            {
                buttonLeft.Visible = true;
                buttonRight.Visible = true;

                buttonAFKBot.Visible = false;
                buttonOptions.Visible= false;
            }
        }

        private void buttonAFKBot_Click(object sender, EventArgs e)
        {
            if (!_running)
            {
                _running = true;

                checkBoxAFKBot.Enabled = false;

                buttonAFKBot.Text = "Stop";

                backgroundWorkerAFKBot.RunWorkerAsync();
            }
            else
            {
                checkBoxAFKBot.Enabled = true;

                buttonAFKBot.Text = "Start";

                backgroundWorkerAFKBot.CancelAsync();

                _running = false;
            }
        }

        private void timerProcess_Tick(object sender, EventArgs e)
        {
            if (_process == null || _process.HasExited)
            {
                labelProcess_Click(sender, e);
            }
        }

        private void buttonOptions_Click(object sender, EventArgs e)
        {
            var options = new FormOptions();
            options.ShowDialog();
        }
    }

    public enum EnumDirections
    {
        LEFT,
        RIGHT,
        ALTERNATELEFT,
        ALTERNATERIGHT
    }
}
