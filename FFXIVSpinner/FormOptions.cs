using FFXIVSpinner.Properties;
using System;
using System.Windows.Forms;

namespace FFXIVSpinner
{
    public partial class FormOptions : Form
    {
        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            try
            {

                double min = Settings.Default.minAfk;
                double max = Settings.Default.maxAfk;
                int jumpChance = Settings.Default.jumpPercent;

                if (min <= 0.1) min = 0.1;
                if (max >= 5.0) max = 5.0;

                numericUpDownMin.Value = (decimal)min;
                numericUpDownMax.Value = (decimal)max;

                numericUpDownJumpPercent.Value = (decimal) jumpChance;
            }
            catch
            {
                Settings.Default.minAfk = 0.5;
                Settings.Default.maxAfk = 1.5;
                Settings.Default.jumpPercent = (int)numericUpDownJumpPercent.Value;

                Close();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (numericUpDownMin.Value > numericUpDownMax.Value)
            {
                decimal swap = numericUpDownMin.Value;
                numericUpDownMax.Value = numericUpDownMin.Value;
                numericUpDownMin.Value = swap;
            }

            Settings.Default.minAfk = (double)numericUpDownMin.Value;
            Settings.Default.maxAfk = (double)numericUpDownMax.Value;
            Settings.Default.jumpPercent = (int)numericUpDownJumpPercent.Value;

            Settings.Default.Save();

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
