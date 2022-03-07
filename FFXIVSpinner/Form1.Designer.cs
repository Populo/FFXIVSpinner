
namespace FFXIVSpinner
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelProcess = new System.Windows.Forms.Label();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.backgroundWorkerAFKBot = new System.ComponentModel.BackgroundWorker();
            this.checkBoxAFKBot = new System.Windows.Forms.CheckBox();
            this.buttonAFKBot = new System.Windows.Forms.Button();
            this.timerProcess = new System.Windows.Forms.Timer(this.components);
            this.buttonOptions = new System.Windows.Forms.Button();
            this.checkBoxAltKeys = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelProcess
            // 
            this.labelProcess.AutoSize = true;
            this.labelProcess.Location = new System.Drawing.Point(12, 78);
            this.labelProcess.Name = "labelProcess";
            this.labelProcess.Size = new System.Drawing.Size(101, 15);
            this.labelProcess.TabIndex = 0;
            this.labelProcess.Text = "Process: {Process}";
            this.labelProcess.Click += new System.EventHandler(this.labelProcess_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 52);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(111, 23);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.Text = "Left";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(123, 52);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(111, 23);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.Text = "Right";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // backgroundWorkerAFKBot
            // 
            this.backgroundWorkerAFKBot.WorkerSupportsCancellation = true;
            // 
            // checkBoxAFKBot
            // 
            this.checkBoxAFKBot.AutoSize = true;
            this.checkBoxAFKBot.Location = new System.Drawing.Point(166, 27);
            this.checkBoxAFKBot.Name = "checkBoxAFKBot";
            this.checkBoxAFKBot.Size = new System.Drawing.Size(68, 19);
            this.checkBoxAFKBot.TabIndex = 7;
            this.checkBoxAFKBot.Text = "AFK Bot";
            this.checkBoxAFKBot.UseVisualStyleBackColor = true;
            this.checkBoxAFKBot.CheckedChanged += new System.EventHandler(this.checkBoxAFKBot_CheckedChanged);
            // 
            // buttonAFKBot
            // 
            this.buttonAFKBot.Location = new System.Drawing.Point(12, 52);
            this.buttonAFKBot.Name = "buttonAFKBot";
            this.buttonAFKBot.Size = new System.Drawing.Size(148, 23);
            this.buttonAFKBot.TabIndex = 8;
            this.buttonAFKBot.Text = "AFK Bot Start";
            this.buttonAFKBot.UseVisualStyleBackColor = true;
            this.buttonAFKBot.Visible = false;
            this.buttonAFKBot.Click += new System.EventHandler(this.buttonAFKBot_Click);
            // 
            // timerProcess
            // 
            this.timerProcess.Interval = 3000;
            this.timerProcess.Tick += new System.EventHandler(this.timerProcess_Tick);
            // 
            // buttonOptions
            // 
            this.buttonOptions.Location = new System.Drawing.Point(166, 52);
            this.buttonOptions.Name = "buttonOptions";
            this.buttonOptions.Size = new System.Drawing.Size(68, 24);
            this.buttonOptions.TabIndex = 9;
            this.buttonOptions.Text = "Options";
            this.buttonOptions.UseVisualStyleBackColor = true;
            this.buttonOptions.Visible = false;
            this.buttonOptions.Click += new System.EventHandler(this.buttonOptions_Click);
            // 
            // checkBoxAltKeys
            // 
            this.checkBoxAltKeys.AutoSize = true;
            this.checkBoxAltKeys.Location = new System.Drawing.Point(12, 27);
            this.checkBoxAltKeys.Name = "checkBoxAltKeys";
            this.checkBoxAltKeys.Size = new System.Drawing.Size(68, 19);
            this.checkBoxAltKeys.TabIndex = 10;
            this.checkBoxAltKeys.Text = "Alt Keys";
            this.checkBoxAltKeys.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Spins you a lot";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 107);
            this.Controls.Add(this.checkBoxAltKeys);
            this.Controls.Add(this.buttonOptions);
            this.Controls.Add(this.buttonAFKBot);
            this.Controls.Add(this.checkBoxAFKBot);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.labelProcess);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "FFXIV Spinner";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelProcess;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonRight;
        private System.ComponentModel.BackgroundWorker backgroundWorkerAFKBot;
        private System.Windows.Forms.CheckBox checkBoxAFKBot;
        private System.Windows.Forms.Button buttonAFKBot;
        private System.Windows.Forms.Timer timerProcess;
        private System.Windows.Forms.Button buttonOptions;
        private System.Windows.Forms.CheckBox checkBoxAltKeys;
        private System.Windows.Forms.Label label1;
    }
}

